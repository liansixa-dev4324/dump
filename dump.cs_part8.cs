	internal int _HResult; // 0x60
	private string _source; // 0x68
	[OptionalField(VersionAdded = 4)]
	private SafeSerializationManager _safeSerializationManager; // 0x70
	internal StackTrace[] captured_traces; // 0x78
	private IntPtr[] native_trace_ips; // 0x80
	private int caught_in_unmanaged; // 0x88
	private const int _COMPlusExceptionCode = -532462766;

	// Properties
	public virtual string Message { get; }
	public virtual IDictionary Data { get; }
	public Exception InnerException { get; }
	public MethodBase TargetSite { get; }
	public virtual string StackTrace { get; }
	public virtual string HelpLink { get; set; }
	public virtual string Source { get; set; }
	internal string RemoteStackTrace { get; }
	public int HResult { get; set; }
	internal bool IsTransient { get; }

	// Methods

	// RVA: 0x17DF6D0 Offset: 0x17DE8D0 VA: 0x1817DF6D0
	private void Init() { }

	// RVA: 0x17DFE10 Offset: 0x17DF010 VA: 0x1817DFE10
	public void .ctor() { }

	// RVA: 0x17E02F0 Offset: 0x17DF4F0 VA: 0x1817E02F0
	public void .ctor(string message) { }

	// RVA: 0x17E0370 Offset: 0x17DF570 VA: 0x1817E0370
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x17DFE80 Offset: 0x17DF080 VA: 0x1817DFE80
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17E04D0 Offset: 0x17DF6D0 VA: 0x1817E04D0 Slot: 5
	public virtual string get_Message() { }

	// RVA: 0x17E0420 Offset: 0x17DF620 VA: 0x1817E0420 Slot: 6
	public virtual IDictionary get_Data() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	private static bool IsImmutableAgileException(Exception e) { }

	// RVA: 0x17DF120 Offset: 0x17DE320 VA: 0x1817DF120
	private string GetClassName() { }

	// RVA: 0x17DF100 Offset: 0x17DE300 VA: 0x1817DF100 Slot: 7
	public virtual Exception GetBaseException() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 8
	public Exception get_InnerException() { }

	// RVA: 0x17E0740 Offset: 0x17DF940 VA: 0x1817E0740 Slot: 9
	public MethodBase get_TargetSite() { }

	// RVA: 0x17E0700 Offset: 0x17DF900 VA: 0x1817E0700 Slot: 10
	public virtual string get_StackTrace() { }

	// RVA: 0x17DF680 Offset: 0x17DE880 VA: 0x1817DF680
	private string GetStackTrace(bool needFileInfo) { }

	// RVA: 0x42D900 Offset: 0x42CB00 VA: 0x18042D900
	internal void SetErrorCode(int hr) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 11
	public virtual string get_HelpLink() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370 Slot: 12
	public virtual void set_HelpLink(string value) { }

	// RVA: 0x17E05C0 Offset: 0x17DF7C0 VA: 0x1817E05C0 Slot: 13
	public virtual string get_Source() { }

	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80 Slot: 14
	public virtual void set_Source(string value) { }

	// RVA: 0x17DF7A0 Offset: 0x17DE9A0 VA: 0x1817DF7A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x17DFB40 Offset: 0x17DED40 VA: 0x1817DFB40
	private string ToString(bool needFileLineInfo, bool needMessage) { }

	// RVA: 0x17E0400 Offset: 0x17DF600 VA: 0x1817E0400
	protected void add_SerializeObjectState(EventHandler<SafeSerializationEventArgs> value) { }

	// RVA: 0x17E0840 Offset: 0x17DFA40 VA: 0x1817E0840
	protected void remove_SerializeObjectState(EventHandler<SafeSerializationEventArgs> value) { }

	// RVA: 0x17DF200 Offset: 0x17DE400 VA: 0x1817DF200 Slot: 15
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17DF830 Offset: 0x17DEA30 VA: 0x1817DF830
	internal Exception PrepForRemoting() { }

	[OnDeserialized]
	// RVA: 0x17DF7B0 Offset: 0x17DE9B0 VA: 0x1817DF7B0
	private void OnDeserialized(StreamingContext context) { }

	// RVA: 0x17DF740 Offset: 0x17DE940 VA: 0x1817DF740
	internal void InternalPreserveStackTrace() { }

	// RVA: 0x70E580 Offset: 0x70D780 VA: 0x18070E580
	private string StripFileInfo(string stackTrace, bool isRemoteStackTrace) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	internal string get_RemoteStackTrace() { }

	// RVA: 0x17DFA80 Offset: 0x17DEC80 VA: 0x1817DFA80
	internal void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo) { }

	// RVA: 0x42D890 Offset: 0x42CA90 VA: 0x18042D890
	public int get_HResult() { }

	// RVA: 0x42D900 Offset: 0x42CB00 VA: 0x18042D900
	protected void set_HResult(int value) { }

	// RVA: 0x17DF7A0 Offset: 0x17DE9A0 VA: 0x1817DF7A0 Slot: 16
	internal virtual string InternalToString() { }

	// RVA: 0x17C7090 Offset: 0x17C6290 VA: 0x1817C7090 Slot: 17
	public Type GetType() { }

	// RVA: 0x17E0490 Offset: 0x17DF690 VA: 0x1817E0490
	internal bool get_IsTransient() { }

	// RVA: 0x17E0800 Offset: 0x17DFA00 VA: 0x1817E0800
	private static bool nIsTransient(int hr) { }

	// RVA: 0x17DF170 Offset: 0x17DE370 VA: 0x1817DF170
	internal static string GetMessageFromNativeResources(Exception.ExceptionMessageKind kind) { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void SetMessage(string s) { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	internal void SetStackTrace(string s) { }

	// RVA: 0x17DF020 Offset: 0x17DE220 VA: 0x1817DF020
	internal Exception FixRemotingException() { }

	// RVA: 0x17DFA70 Offset: 0x17DEC70 VA: 0x1817DFA70
	internal static void ReportUnhandledException(Exception exception) { }

	// RVA: 0x17DFDB0 Offset: 0x17DEFB0 VA: 0x1817DFDB0
	private static void .cctor() { }
}

// Namespace: System
[Serializable]
public enum GCCollectionMode // TypeDefIndex: 3197
{
	// Fields
	public int value__; // 0x0
	public const GCCollectionMode Default = 0;
	public const GCCollectionMode Forced = 1;
	public const GCCollectionMode Optimized = 2;
}

// Namespace: System
public static class GC // TypeDefIndex: 3198
{
	// Fields
	internal static readonly object EPHEMERON_TOMBSTONE; // 0x0

	// Properties
	public static int MaxGeneration { get; }

	// Methods

	// RVA: 0x17E1050 Offset: 0x17E0250 VA: 0x1817E1050
	private static int GetCollectionCount(int generation) { }

	// RVA: 0x17E1060 Offset: 0x17E0260 VA: 0x1817E1060
	private static int GetMaxGeneration() { }

	// RVA: 0x17E10A0 Offset: 0x17E02A0 VA: 0x1817E10A0
	private static void InternalCollect(int generation) { }

	// RVA: 0x17E1150 Offset: 0x17E0350 VA: 0x1817E1150
	private static void RecordPressure(long bytesAllocated) { }

	// RVA: 0x17E13F0 Offset: 0x17E05F0 VA: 0x1817E13F0
	internal static void register_ephemeron_array(Ephemeron[] array) { }

	// RVA: 0x17E13E0 Offset: 0x17E05E0 VA: 0x1817E13E0
	private static object get_ephemeron_tombstone() { }

	// RVA: 0x17E1070 Offset: 0x17E0270 VA: 0x1817E1070
	internal static void GetMemoryInfo(out uint highMemLoadThreshold, out ulong totalPhysicalMem, out uint lastRecordedMemLoad, out UIntPtr lastRecordedHeapSize, out UIntPtr lastRecordedFragmentation) { }

	// RVA: 0x17E0860 Offset: 0x17DFA60 VA: 0x1817E0860
	public static void AddMemoryPressure(long bytesAllocated) { }

	// RVA: 0x17E1160 Offset: 0x17E0360 VA: 0x1817E1160
	public static void RemoveMemoryPressure(long bytesAllocated) { }

	// RVA: 0x17E0B80 Offset: 0x17DFD80 VA: 0x1817E0B80
	public static void Collect(int generation) { }

	// RVA: 0x17E0B00 Offset: 0x17DFD00 VA: 0x1817E0B00
	public static void Collect() { }

	// RVA: 0x17E0CD0 Offset: 0x17DFED0 VA: 0x1817E0CD0
	public static void Collect(int generation, GCCollectionMode mode) { }

	// RVA: 0x17E09A0 Offset: 0x17DFBA0 VA: 0x1817E09A0
	public static void Collect(int generation, GCCollectionMode mode, bool blocking) { }

	// RVA: 0x17E0E60 Offset: 0x17E0060 VA: 0x1817E0E60
	public static void Collect(int generation, GCCollectionMode mode, bool blocking, bool compacting) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x17E0F90 Offset: 0x17E0190 VA: 0x1817E0F90
	public static int CollectionCount(int generation) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void KeepAlive(object obj) { }

	// RVA: 0x17E13A0 Offset: 0x17E05A0 VA: 0x1817E13A0
	public static int get_MaxGeneration() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x17E1350 Offset: 0x17E0550 VA: 0x1817E1350
	private static void _SuppressFinalize(object o) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x17E12A0 Offset: 0x17E04A0 VA: 0x1817E12A0
	public static void SuppressFinalize(object obj) { }

	// RVA: 0x17E1340 Offset: 0x17E0540 VA: 0x1817E1340
	private static void _ReRegisterForFinalize(object o) { }

	// RVA: 0x17E10B0 Offset: 0x17E02B0 VA: 0x1817E10B0
	public static void ReRegisterForFinalize(object obj) { }

	// RVA: 0x17E1090 Offset: 0x17E0290 VA: 0x1817E1090
	public static long GetTotalMemory(bool forceFullCollection) { }

	// RVA: 0x17E1360 Offset: 0x17E0560 VA: 0x1817E1360
	private static void .cctor() { }
}

// Namespace: System
internal enum TypeNameFormatFlags // TypeDefIndex: 3199
{
	// Fields
	public int value__; // 0x0
	public const TypeNameFormatFlags FormatBasic = 0;
	public const TypeNameFormatFlags FormatNamespace = 1;
	public const TypeNameFormatFlags FormatFullInst = 2;
	public const TypeNameFormatFlags FormatAssembly = 4;
	public const TypeNameFormatFlags FormatSignature = 8;
	public const TypeNameFormatFlags FormatNoVersion = 16;
	public const TypeNameFormatFlags FormatAngleBrackets = 64;
	public const TypeNameFormatFlags FormatStubInfo = 128;
	public const TypeNameFormatFlags FormatGenericParam = 256;
	public const TypeNameFormatFlags FormatSerialization = 259;
}

// Namespace: System
internal enum TypeNameKind // TypeDefIndex: 3200
{
	// Fields
	public int value__; // 0x0
	public const TypeNameKind Name = 0;
	public const TypeNameKind ToString = 1;
	public const TypeNameKind SerializationName = 2;
	public const TypeNameKind FullName = 3;
}

// Namespace: 
internal enum RuntimeType.MemberListType // TypeDefIndex: 3201
{
	// Fields
	public int value__; // 0x0
	public const RuntimeType.MemberListType All = 0;
	public const RuntimeType.MemberListType CaseSensitive = 1;
	public const RuntimeType.MemberListType CaseInsensitive = 2;
	public const RuntimeType.MemberListType HandleToInfo = 3;
}

// Namespace: 
[DefaultMember("Item")]
private struct RuntimeType.ListBuilder<T> // TypeDefIndex: 3202
{
	// Fields
	private T[] _items; // 0x0
	private T _item; // 0x0
	private int _count; // 0x0
	private int _capacity; // 0x0

	// Properties
	public T Item { get; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132C650 Offset: 0x132B850 VA: 0x18132C650
	|-RuntimeType.ListBuilder<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132C670 Offset: 0x132B870 VA: 0x18132C670
	|-RuntimeType.ListBuilder<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132C560 Offset: 0x132B760 VA: 0x18132C560
	|-RuntimeType.ListBuilder<object>.ToArray
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(object[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132C4B0 Offset: 0x132B6B0 VA: 0x18132C4B0
	|-RuntimeType.ListBuilder<object>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	|-RuntimeType.ListBuilder<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132C3A0 Offset: 0x132B5A0 VA: 0x18132C3A0
	|-RuntimeType.ListBuilder<object>.Add
	*/
}

// Namespace: System
[Serializable]
internal class RuntimeType : TypeInfo, ISerializable, ICloneable // TypeDefIndex: 3203
{
	// Fields
	internal static readonly RuntimeType ValueType; // 0x0
	internal static readonly RuntimeType EnumType; // 0x8
	private static readonly RuntimeType ObjectType; // 0x10
	private static readonly RuntimeType StringType; // 0x18
	private static readonly RuntimeType DelegateType; // 0x20
	private static Type[] s_SICtorParamTypes; // 0x28
	internal static Func<Type, Type[], Type> MakeTypeBuilderInstantiation; // 0x30
	private const BindingFlags MemberBindingMask = 255;
	private const BindingFlags InvocationMask = 65280;
	private const BindingFlags BinderNonCreateInstance = 15616;
	private const BindingFlags BinderGetSetProperty = 12288;
	private const BindingFlags BinderSetInvokeProperty = 8448;
	private const BindingFlags BinderGetSetField = 3072;
	private const BindingFlags BinderSetInvokeField = 2304;
	private const BindingFlags BinderNonFieldGetSet = 16773888;
	private const BindingFlags ClassicBindingMask = 61696;
	private static RuntimeType s_typedRef; // 0x38
	private MonoTypeInfo type_info; // 0x18
	internal object GenericCache; // 0x20
	private RuntimeConstructorInfo m_serializationCtor; // 0x28
	private const int GenericParameterCountAny = -1;

	// Properties
	public override Module Module { get; }
	public override Assembly Assembly { get; }
	public override RuntimeTypeHandle TypeHandle { get; }
	public override Type BaseType { get; }
	public override Type UnderlyingSystemType { get; }
	public override bool IsEnum { get; }
	public override GenericParameterAttributes GenericParameterAttributes { get; }
	internal override bool IsSzArray { get; }
	public override bool IsGenericTypeDefinition { get; }
	public override bool IsGenericParameter { get; }
	public override int GenericParameterPosition { get; }
	public override bool IsGenericType { get; }
	public override bool IsConstructedGenericType { get; }
	public override MemberTypes MemberType { get; }
	public override Type ReflectedType { get; }
	public override int MetadataToken { get; }
	public override bool ContainsGenericParameters { get; }
	public override Guid GUID { get; }
	public override MethodBase DeclaringMethod { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override string FullName { get; }
	public override bool IsSZArray { get; }

	// Methods

	// RVA: 0x17E9E10 Offset: 0x17E9010 VA: 0x1817E9E10
	internal static RuntimeType GetType(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark) { }

	// RVA: 0x17ED840 Offset: 0x17ECA40 VA: 0x1817ED840
	private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type) { }

	// RVA: 0x17ED4F0 Offset: 0x17EC6F0 VA: 0x1817ED4F0
	internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters) { }

	// RVA: 0x17ED760 Offset: 0x17EC960 VA: 0x1817ED760
	private static void SplitName(string fullname, out string name, out string ns) { }

	// RVA: 0x17E43A0 Offset: 0x17E35A0 VA: 0x1817E43A0
	internal static BindingFlags FilterPreCalculate(bool isPublic, bool isInherited, bool isStatic) { }

	// RVA: 0x17E4260 Offset: 0x17E3460 VA: 0x1817E4260
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x17E4160 Offset: 0x17E3360 VA: 0x1817E4160
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x17E3FC0 Offset: 0x17E31C0 VA: 0x1817E3FC0
	private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase) { }

	// RVA: 0x17E39D0 Offset: 0x17E2BD0 VA: 0x1817E39D0
	private static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup) { }

	// RVA: 0x17E4040 Offset: 0x17E3240 VA: 0x1817E4040
	private static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns) { }

	// RVA: 0x17E3F10 Offset: 0x17E3110 VA: 0x1817E3F10
	private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x17E3BE0 Offset: 0x17E2DE0 VA: 0x1817E3BE0
	private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x17E3C90 Offset: 0x17E2E90 VA: 0x1817E3C90
	private static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x17EE170 Offset: 0x17ED370 VA: 0x1817EE170
	internal void .ctor() { }

	// RVA: 0x17E7BF0 Offset: 0x17E6DF0 VA: 0x1817E7BF0
	private RuntimeType.ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, int genericParamCount, bool allowPrefixLookup) { }

	// RVA: 0x17E48B0 Offset: 0x17E3AB0 VA: 0x1817E48B0
	private RuntimeType.ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x17E95D0 Offset: 0x17E87D0 VA: 0x1817E95D0
	private RuntimeType.ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x17E5CE0 Offset: 0x17E4EE0 VA: 0x1817E5CE0
	private RuntimeType.ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x17E6410 Offset: 0x17E5610 VA: 0x1817E6410
	private RuntimeType.ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x17E8730 Offset: 0x17E7930 VA: 0x1817E8730
	private RuntimeType.ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x17E8680 Offset: 0x17E7880 VA: 0x1817E8680 Slot: 103
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	[ComVisible(True)]
	// RVA: 0x17E5140 Offset: 0x17E4340 VA: 0x1817E5140 Slot: 83
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x17E9540 Offset: 0x17E8740 VA: 0x1817E9540 Slot: 113
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x17E6370 Offset: 0x17E5570 VA: 0x1817E6370 Slot: 86
	public override EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	// RVA: 0x17E6D50 Offset: 0x17E5F50 VA: 0x1817E6D50 Slot: 90
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x17E7640 Offset: 0x17E6840 VA: 0x1817E7640 Slot: 94
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x17E4C50 Offset: 0x17E3E50 VA: 0x1817E4C50 Slot: 81
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x17E9870 Offset: 0x17E8A70 VA: 0x1817E9870 Slot: 111
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x17E5F30 Offset: 0x17E5130 VA: 0x1817E5F30 Slot: 85
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x17E6660 Offset: 0x17E5860 VA: 0x1817E6660 Slot: 88
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x17E8AD0 Offset: 0x17E7CD0 VA: 0x1817E8AD0 Slot: 104
	public override Type GetNestedType(string fullname, BindingFlags bindingAttr) { }

	// RVA: 0x17E71A0 Offset: 0x17E63A0 VA: 0x1817E71A0 Slot: 93
	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x17E9B60 Offset: 0x17E8D60 VA: 0x1817E9B60 Slot: 29
	public override Module get_Module() { }

	// RVA: 0x17E9B60 Offset: 0x17E8D60 VA: 0x1817E9B60
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x17E9B50 Offset: 0x17E8D50 VA: 0x1817E9B50 Slot: 28
	public override Assembly get_Assembly() { }

	// RVA: 0x17E9B50 Offset: 0x17E8D50 VA: 0x1817E9B50
	internal RuntimeAssembly GetRuntimeAssembly() { }

	// RVA: 0x17EE7D0 Offset: 0x17ED9D0 VA: 0x1817EE7D0 Slot: 114
	public override RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x17ECAF0 Offset: 0x17EBCF0 VA: 0x1817ECAF0 Slot: 121
	public override bool IsInstanceOfType(object o) { }

	// RVA: 0x17EB4E0 Offset: 0x17EA6E0 VA: 0x1817EB4E0 Slot: 23
	public override bool IsAssignableFrom(Type c) { }

	// RVA: 0x17ECA20 Offset: 0x17EBC20 VA: 0x1817ECA20 Slot: 122
	public override bool IsEquivalentTo(Type other) { }

	// RVA: 0x17EE1E0 Offset: 0x17ED3E0 VA: 0x1817EE1E0 Slot: 117
	public override Type get_BaseType() { }

	// RVA: 0x17E4620 Offset: 0x17E3820 VA: 0x1817E4620
	private RuntimeType GetBaseType() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 31
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x17E4610 Offset: 0x17E3810 VA: 0x1817E4610 Slot: 56
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x17EB5E0 Offset: 0x17EA7E0 VA: 0x1817EB5E0 Slot: 68
	protected override bool IsContextfulImpl() { }

	// RVA: 0x17EB5C0 Offset: 0x17EA7C0 VA: 0x1817EB5C0 Slot: 35
	protected override bool IsByRefImpl() { }

	// RVA: 0x17ECB10 Offset: 0x17EBD10 VA: 0x1817ECB10 Slot: 74
	protected override bool IsPrimitiveImpl() { }

	// RVA: 0x17ECB00 Offset: 0x17EBD00 VA: 0x1817ECB00 Slot: 37
	protected override bool IsPointerImpl() { }

	// RVA: 0x17EB5D0 Offset: 0x17EA7D0 VA: 0x1817EB5D0 Slot: 66
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x17ECC20 Offset: 0x17EBE20 VA: 0x1817ECC20 Slot: 76
	protected override bool IsValueTypeImpl() { }

	// RVA: 0x17EE650 Offset: 0x17ED850 VA: 0x1817EE650 Slot: 70
	public override bool get_IsEnum() { }

	// RVA: 0x17E9E90 Offset: 0x17E9090 VA: 0x1817E9E90 Slot: 46
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x17EE4B0 Offset: 0x17ED6B0 VA: 0x1817EE4B0 Slot: 53
	public override GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x17EE750 Offset: 0x17ED950 VA: 0x1817EE750 Slot: 131
	internal override bool get_IsSzArray() { }

	// RVA: 0x17EB4D0 Offset: 0x17EA6D0 VA: 0x1817EB4D0 Slot: 33
	protected override bool IsArrayImpl() { }

	// RVA: 0x17E4580 Offset: 0x17E3780 VA: 0x1817E4580 Slot: 48
	public override int GetArrayRank() { }

	// RVA: 0x17E5690 Offset: 0x17E4890 VA: 0x1817E5690 Slot: 47
	public override Type GetElementType() { }

	// RVA: 0x17E58E0 Offset: 0x17E4AE0 VA: 0x1817E58E0 Slot: 19
	public override string[] GetEnumNames() { }

	// RVA: 0x17E5B10 Offset: 0x17E4D10 VA: 0x1817E5B10 Slot: 124
	public override Array GetEnumValues() { }

	// RVA: 0x17E5A40 Offset: 0x17E4C40 VA: 0x1817E5A40 Slot: 123
	public override Type GetEnumUnderlyingType() { }

	// RVA: 0x17EC3F0 Offset: 0x17EB5F0 VA: 0x1817EC3F0 Slot: 17
	public override bool IsEnumDefined(object value) { }

	// RVA: 0x17E56A0 Offset: 0x17E48A0 VA: 0x1817E56A0 Slot: 18
	public override string GetEnumName(object value) { }

	// RVA: 0x17E6E00 Offset: 0x17E6000 VA: 0x1817E6E00
	internal RuntimeType[] GetGenericArgumentsInternal() { }

	// RVA: 0x17E6E80 Offset: 0x17E6080 VA: 0x1817E6E80 Slot: 51
	public override Type[] GetGenericArguments() { }

	// RVA: 0x17ECE10 Offset: 0x17EC010 VA: 0x1817ECE10 Slot: 128
	public override Type MakeGenericType(Type[] instantiation) { }

	// RVA: 0x17EE6D0 Offset: 0x17ED8D0 VA: 0x1817EE6D0 Slot: 42
	public override bool get_IsGenericTypeDefinition() { }

	// RVA: 0x17EE6C0 Offset: 0x17ED8C0 VA: 0x1817EE6C0 Slot: 39
	public override bool get_IsGenericParameter() { }

	// RVA: 0x17EE570 Offset: 0x17ED770 VA: 0x1817EE570 Slot: 52
	public override int get_GenericParameterPosition() { }

	// RVA: 0x17E7030 Offset: 0x17E6230 VA: 0x1817E7030 Slot: 49
	public override Type GetGenericTypeDefinition() { }

	// RVA: 0x17EE6E0 Offset: 0x17ED8E0 VA: 0x1817EE6E0 Slot: 41
	public override bool get_IsGenericType() { }

	// RVA: 0x17EE600 Offset: 0x17ED800 VA: 0x1817EE600 Slot: 38
	public override bool get_IsConstructedGenericType() { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x17E9EA0 Offset: 0x17E90A0 VA: 0x1817E9EA0 Slot: 119
	public override object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, object target, object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParams) { }

	// RVA: 0x17E39C0 Offset: 0x17E2BC0 VA: 0x1817E39C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xAA0BD0 Offset: 0xA9FDD0 VA: 0x180AA0BD0
	public static bool op_Equality(RuntimeType left, RuntimeType right) { }

	// RVA: 0x17C3590 Offset: 0x17C2790 VA: 0x1817C3590
	public static bool op_Inequality(RuntimeType left, RuntimeType right) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 140
	public object Clone() { }

	// RVA: 0x17E9210 Offset: 0x17E8410 VA: 0x1817E9210 Slot: 139
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17E5200 Offset: 0x17E4400 VA: 0x1817E5200 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17E52A0 Offset: 0x17E44A0 VA: 0x1817E52A0 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17EC250 Offset: 0x17EB450 VA: 0x1817EC250 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17E51F0 Offset: 0x17E43F0 VA: 0x1817E51F0 Slot: 15
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x17E43E0 Offset: 0x17E35E0 VA: 0x1817E43E0 Slot: 132
	internal override string FormatTypeName(bool serialization) { }

	// RVA: 0x17EE760 Offset: 0x17ED960 VA: 0x1817EE760 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x75AB00 Offset: 0x759D00 VA: 0x18075AB00 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x17EE7A0 Offset: 0x17ED9A0 VA: 0x1817EE7A0 Slot: 16
	public override int get_MetadataToken() { }

	// RVA: 0x17E2810 Offset: 0x17E1A10 VA: 0x1817E2810
	private void CreateInstanceCheckThis() { }

	// RVA: 0x17E2DA0 Offset: 0x17E1FA0 VA: 0x1817E2DA0
	internal object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, ref StackCrawlMark stackMark) { }

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x17E2AD0 Offset: 0x17E1CD0 VA: 0x1817E2AD0
	internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, bool wrapExceptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x17E5440 Offset: 0x17E4640 VA: 0x1817E5440
	internal RuntimeConstructorInfo GetDefaultConstructor() { }

	// RVA: 0x17E55A0 Offset: 0x17E47A0 VA: 0x1817E55A0
	private string GetDefaultMemberName() { }

	// RVA: 0x17E9B70 Offset: 0x17E8D70 VA: 0x1817E9B70
	internal RuntimeConstructorInfo GetSerializationCtor() { }

	// RVA: 0x17E3970 Offset: 0x17E2B70 VA: 0x1817E3970
	internal object CreateInstanceSlow(bool publicOnly, bool wrapExceptions, bool skipCheckThis, bool fillCache) { }

	// RVA: 0x17E3680 Offset: 0x17E2880 VA: 0x1817E3680
	private object CreateInstanceMono(bool nonPublic, bool wrapExceptions) { }

	// RVA: 0x17E25F0 Offset: 0x17E17F0 VA: 0x1817E25F0
	internal object CheckValue(object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr) { }

	// RVA: 0x17ED9B0 Offset: 0x17ECBB0 VA: 0x1817ED9B0
	private object TryConvertToType(object value, ref bool failed) { }

	// RVA: 0x17EB5F0 Offset: 0x17EA7F0 VA: 0x1817EB5F0
	private static object IsConvertibleToPrimitiveType(object value, Type targetType) { }

	// RVA: 0x17E4840 Offset: 0x17E3A40 VA: 0x1817E4840
	private string GetCachedName(TypeNameKind kind) { }

	// RVA: 0x17EE800 Offset: 0x17EDA00 VA: 0x1817EE800
	private Type make_array_type(int rank) { }

	// RVA: 0x17ECD30 Offset: 0x17EBF30 VA: 0x1817ECD30 Slot: 125
	public override Type MakeArrayType() { }

	// RVA: 0x17ECD40 Offset: 0x17EBF40 VA: 0x1817ECD40 Slot: 126
	public override Type MakeArrayType(int rank) { }

	// RVA: 0x17EE810 Offset: 0x17EDA10 VA: 0x1817EE810
	private Type make_byref_type() { }

	// RVA: 0x17ECDA0 Offset: 0x17EBFA0 VA: 0x1817ECDA0 Slot: 127
	public override Type MakeByRefType() { }

	// RVA: 0x17ED400 Offset: 0x17EC600 VA: 0x1817ED400
	private static Type MakePointerType(Type type) { }

	// RVA: 0x17ED410 Offset: 0x17EC610 VA: 0x1817ED410 Slot: 129
	public override Type MakePointerType() { }

	// RVA: 0x17EE1F0 Offset: 0x17ED3F0 VA: 0x1817EE1F0 Slot: 21
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x17E6F10 Offset: 0x17E6110 VA: 0x1817E6F10 Slot: 54
	public override Type[] GetGenericParameterConstraints() { }

	// RVA: 0x17E2C00 Offset: 0x17E1E00 VA: 0x1817E2C00
	internal static object CreateInstanceForAnotherGenericParameter(Type genericType, RuntimeType genericArgument) { }

	// RVA: 0x17ED3F0 Offset: 0x17EC5F0 VA: 0x1817ED3F0
	private static Type MakeGenericType(Type gt, Type[] types) { }

	// RVA: 0x17E8670 Offset: 0x17E7870 VA: 0x1817E8670
	internal IntPtr GetMethodsByName_native(IntPtr namePtr, BindingFlags bindingAttr, RuntimeType.MemberListType listType) { }

	// RVA: 0x17E83C0 Offset: 0x17E75C0 VA: 0x1817E83C0
	internal RuntimeMethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType) { }

	// RVA: 0x17E9530 Offset: 0x17E8730 VA: 0x1817E9530
	private IntPtr GetPropertiesByName_native(IntPtr name, BindingFlags bindingAttr, RuntimeType.MemberListType listType) { }

	// RVA: 0x17E51E0 Offset: 0x17E43E0 VA: 0x1817E51E0
	private IntPtr GetConstructors_native(BindingFlags bindingAttr) { }

	// RVA: 0x17E4F00 Offset: 0x17E4100 VA: 0x1817E4F00
	private RuntimeConstructorInfo[] GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x17E9280 Offset: 0x17E8480 VA: 0x1817E9280
	private RuntimePropertyInfo[] GetPropertiesByName(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType) { }

	// RVA: 0x17E6DF0 Offset: 0x17E5FF0 VA: 0x1817E6DF0
	private static void GetGUID(Type type, byte[] guid) { }

	// RVA: 0x17EE410 Offset: 0x17ED610 VA: 0x1817EE410 Slot: 116
	public override Guid get_GUID() { }

	// RVA: 0x17E9DC0 Offset: 0x17E8FC0 VA: 0x1817E9DC0
	internal static Type GetTypeFromCLSIDImpl(Guid clsid, string server, bool throwOnError) { }

	// RVA: 0x17E9D70 Offset: 0x17E8F70 VA: 0x1817E9D70 Slot: 115
	protected override TypeCode GetTypeCodeImpl() { }

	// RVA: 0x17E9D60 Offset: 0x17E8F60 VA: 0x1817E9D60
	private static TypeCode GetTypeCodeImplInternal(Type type) { }

	// RVA: 0x17ED9A0 Offset: 0x17ECBA0 VA: 0x1817ED9A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	private bool IsGenericCOMObjectImpl() { }

	// RVA: 0x17E3670 Offset: 0x17E2870 VA: 0x1817E3670
	private static object CreateInstanceInternal(Type type) { }

	// RVA: 0x17EE310 Offset: 0x17ED510 VA: 0x1817EE310 Slot: 30
	public override MethodBase get_DeclaringMethod() { }

	// RVA: 0x17EE1C0 Offset: 0x17ED3C0 VA: 0x1817EE1C0
	internal string getFullName(bool full_name, bool assembly_qualified) { }

	// RVA: 0x17E6E70 Offset: 0x17E6070 VA: 0x1817E6E70
	private Type[] GetGenericArgumentsInternal(bool runtimeArray) { }

	// RVA: 0x17E6ED0 Offset: 0x17E60D0 VA: 0x1817E6ED0
	private GenericParameterAttributes GetGenericParameterAttributes() { }

	// RVA: 0x17E7020 Offset: 0x17E6220 VA: 0x1817E7020
	private int GetGenericParameterPosition() { }

	// RVA: 0x17E6400 Offset: 0x17E5600 VA: 0x1817E6400
	private IntPtr GetEvents_native(IntPtr name, RuntimeType.MemberListType listType) { }

	// RVA: 0x17E6DE0 Offset: 0x17E5FE0 VA: 0x1817E6DE0
	private IntPtr GetFields_native(IntPtr name, BindingFlags bindingAttr, RuntimeType.MemberListType listType) { }

	// RVA: 0x17E6AA0 Offset: 0x17E5CA0 VA: 0x1817E6AA0
	private RuntimeFieldInfo[] GetFields_internal(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType) { }

	// RVA: 0x17E6180 Offset: 0x17E5380 VA: 0x1817E6180
	private RuntimeEventInfo[] GetEvents_internal(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType) { }

	// RVA: 0x17E7190 Offset: 0x17E6390 VA: 0x1817E7190 Slot: 120
	public override Type[] GetInterfaces() { }

	// RVA: 0x17E9200 Offset: 0x17E8400 VA: 0x1817E9200
	private IntPtr GetNestedTypes_native(IntPtr name, BindingFlags bindingAttr, RuntimeType.MemberListType listType) { }

	// RVA: 0x17E8EA0 Offset: 0x17E80A0 VA: 0x1817E8EA0
	private RuntimeType[] GetNestedTypes_internal(string displayName, BindingFlags bindingAttr, RuntimeType.MemberListType listType) { }

	// RVA: 0x17EE1D0 Offset: 0x17ED3D0 VA: 0x1817EE1D0 Slot: 26
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x17EE320 Offset: 0x17ED520 VA: 0x1817EE320 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x17EE7B0 Offset: 0x17ED9B0 VA: 0x1817EE7B0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x17EE7C0 Offset: 0x17ED9C0 VA: 0x1817EE7C0 Slot: 25
	public override string get_Namespace() { }

	// RVA: 0x17E70C0 Offset: 0x17E62C0 VA: 0x1817E70C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17EE330 Offset: 0x17ED530 VA: 0x1817EE330 Slot: 27
	public override string get_FullName() { }

	// RVA: 0x17EE6F0 Offset: 0x17ED8F0 VA: 0x1817EE6F0 Slot: 43
	public override bool get_IsSZArray() { }

	[ComVisible(True)]
	// RVA: 0x17ECB20 Offset: 0x17EBD20 VA: 0x1817ECB20 Slot: 22
	public override bool IsSubclassOf(Type type) { }

	// RVA: 0x17E8370 Offset: 0x17E7570 VA: 0x1817E8370 Slot: 101
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x17E7EC0 Offset: 0x17E70C0 VA: 0x1817E7EC0
	private MethodInfo GetMethodImplCommon(string name, int genericParameterCount, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x17E7950 Offset: 0x17E6B50 VA: 0x1817E7950
	private RuntimeType.ListBuilder<MethodInfo> GetMethodCandidates(string name, int genericParameterCount, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x17EDC50 Offset: 0x17ECE50 VA: 0x1817EDC50
	private static void .cctor() { }
}

// Namespace: System
[Serializable]
internal class ReflectionOnlyType : RuntimeType // TypeDefIndex: 3204
{
	// Properties
	public override RuntimeTypeHandle TypeHandle { get; }

	// Methods

	// RVA: 0x17FD590 Offset: 0x17FC790 VA: 0x1817FD590
	private void .ctor() { }

	// RVA: 0x17FD5E0 Offset: 0x17FC7E0 VA: 0x1817FD5E0 Slot: 114
	public override RuntimeTypeHandle get_TypeHandle() { }
}

// Namespace: System
internal sealed class SharedStatics // TypeDefIndex: 3205
{
	// Fields
	private static readonly SharedStatics _sharedStatics; // 0x0
	private Tokenizer.StringMaker _maker; // 0x10

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void .ctor() { }

	// RVA: 0x17FEAF0 Offset: 0x17FDCF0 VA: 0x1817FEAF0
	public static Tokenizer.StringMaker GetSharedStringMaker() { }

	// RVA: 0x17FEC60 Offset: 0x17FDE60 VA: 0x1817FEC60
	public static void ReleaseSharedStringMaker(ref Tokenizer.StringMaker maker) { }

	// RVA: 0x17FED60 Offset: 0x17FDF60 VA: 0x1817FED60
	private static void .cctor() { }
}

// Namespace: System
internal enum ExceptionArgument // TypeDefIndex: 3206
{
	// Fields
	public int value__; // 0x0
	public const ExceptionArgument obj = 0;
	public const ExceptionArgument dictionary = 1;
	public const ExceptionArgument dictionaryCreationThreshold = 2;
	public const ExceptionArgument array = 3;
	public const ExceptionArgument info = 4;
	public const ExceptionArgument key = 5;
	public const ExceptionArgument collection = 6;
	public const ExceptionArgument list = 7;
	public const ExceptionArgument match = 8;
	public const ExceptionArgument converter = 9;
	public const ExceptionArgument queue = 10;
	public const ExceptionArgument stack = 11;
	public const ExceptionArgument capacity = 12;
	public const ExceptionArgument index = 13;
	public const ExceptionArgument startIndex = 14;
	public const ExceptionArgument value = 15;
	public const ExceptionArgument count = 16;
	public const ExceptionArgument arrayIndex = 17;
	public const ExceptionArgument name = 18;
	public const ExceptionArgument mode = 19;
	public const ExceptionArgument item = 20;
	public const ExceptionArgument options = 21;
	public const ExceptionArgument view = 22;
	public const ExceptionArgument sourceBytesToCopy = 23;
	public const ExceptionArgument start = 24;
	public const ExceptionArgument pointer = 25;
	public const ExceptionArgument ownedMemory = 26;
	public const ExceptionArgument text = 27;
	public const ExceptionArgument length = 28;
	public const ExceptionArgument comparer = 29;
	public const ExceptionArgument comparable = 30;
	public const ExceptionArgument exceptions = 31;
	public const ExceptionArgument exception = 32;
	public const ExceptionArgument action = 33;
	public const ExceptionArgument comparison = 34;
	public const ExceptionArgument startSegment = 35;
	public const ExceptionArgument endSegment = 36;
	public const ExceptionArgument endIndex = 37;
	public const ExceptionArgument task = 38;
	public const ExceptionArgument source = 39;
	public const ExceptionArgument state = 40;
	public const ExceptionArgument culture = 41;
	public const ExceptionArgument destination = 42;
	public const ExceptionArgument byteOffset = 43;
	public const ExceptionArgument minimumBufferSize = 44;
	public const ExceptionArgument offset = 45;
	public const ExceptionArgument values = 46;
	public const ExceptionArgument comparisonType = 47;
	public const ExceptionArgument s = 48;
	public const ExceptionArgument input = 49;
	public const ExceptionArgument format = 50;
}

// Namespace: System
internal enum ExceptionResource // TypeDefIndex: 3207
{
	// Fields
	public int value__; // 0x0
	public const ExceptionResource Argument_ImplementIComparable = 0;
	public const ExceptionResource Argument_InvalidType = 1;
	public const ExceptionResource Argument_InvalidArgumentForComparison = 2;
	public const ExceptionResource Argument_InvalidRegistryKeyPermissionCheck = 3;
	public const ExceptionResource ArgumentOutOfRange_NeedNonNegNum = 4;
	public const ExceptionResource Arg_ArrayPlusOffTooSmall = 5;
	public const ExceptionResource Arg_NonZeroLowerBound = 6;
	public const ExceptionResource Arg_RankMultiDimNotSupported = 7;
	public const ExceptionResource Arg_RegKeyDelHive = 8;
	public const ExceptionResource Arg_RegKeyStrLenBug = 9;
	public const ExceptionResource Arg_RegSetStrArrNull = 10;
	public const ExceptionResource Arg_RegSetMismatchedKind = 11;
	public const ExceptionResource Arg_RegSubKeyAbsent = 12;
	public const ExceptionResource Arg_RegSubKeyValueAbsent = 13;
	public const ExceptionResource Argument_AddingDuplicate = 14;
	public const ExceptionResource Serialization_InvalidOnDeser = 15;
	public const ExceptionResource Serialization_MissingKeys = 16;
	public const ExceptionResource Serialization_NullKey = 17;
	public const ExceptionResource Argument_InvalidArrayType = 18;
	public const ExceptionResource NotSupported_KeyCollectionSet = 19;
	public const ExceptionResource NotSupported_ValueCollectionSet = 20;
	public const ExceptionResource ArgumentOutOfRange_SmallCapacity = 21;
	public const ExceptionResource ArgumentOutOfRange_Index = 22;
	public const ExceptionResource Argument_InvalidOffLen = 23;
	public const ExceptionResource Argument_ItemNotExist = 24;
	public const ExceptionResource ArgumentOutOfRange_Count = 25;
	public const ExceptionResource ArgumentOutOfRange_InvalidThreshold = 26;
	public const ExceptionResource ArgumentOutOfRange_ListInsert = 27;
	public const ExceptionResource NotSupported_ReadOnlyCollection = 28;
	public const ExceptionResource InvalidOperation_CannotRemoveFromStackOrQueue = 29;
	public const ExceptionResource InvalidOperation_EmptyQueue = 30;
	public const ExceptionResource InvalidOperation_EnumOpCantHappen = 31;
	public const ExceptionResource InvalidOperation_EnumFailedVersion = 32;
	public const ExceptionResource InvalidOperation_EmptyStack = 33;
	public const ExceptionResource ArgumentOutOfRange_BiggerThanCollection = 34;
	public const ExceptionResource InvalidOperation_EnumNotStarted = 35;
	public const ExceptionResource InvalidOperation_EnumEnded = 36;
	public const ExceptionResource NotSupported_SortedListNestedWrite = 37;
	public const ExceptionResource InvalidOperation_NoValue = 38;
	public const ExceptionResource InvalidOperation_RegRemoveSubKey = 39;
	public const ExceptionResource Security_RegistryPermission = 40;
	public const ExceptionResource UnauthorizedAccess_RegistryNoWrite = 41;
	public const ExceptionResource ObjectDisposed_RegKeyClosed = 42;
	public const ExceptionResource NotSupported_InComparableType = 43;
	public const ExceptionResource Argument_InvalidRegistryOptionsCheck = 44;
	public const ExceptionResource Argument_InvalidRegistryViewCheck = 45;
	public const ExceptionResource TaskT_TransitionToFinal_AlreadyCompleted = 46;
	public const ExceptionResource TaskCompletionSourceT_TrySetException_NullException = 47;
	public const ExceptionResource TaskCompletionSourceT_TrySetException_NoExceptions = 48;
	public const ExceptionResource NotSupported_StringComparison = 49;
	public const ExceptionResource InvalidOperation_NullArray = 50;
}

// Namespace: System
[NonVersionable]
[ComVisible(True)]
[IsByRefLike]
[CLSCompliant(False)]
public struct TypedReference // TypeDefIndex: 3208
{
	// Fields
	private RuntimeTypeHandle type; // 0x0
	private IntPtr Value; // 0x8
	private IntPtr Type; // 0x10

	// Properties
	internal bool IsNull { get; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x18060D0 Offset: 0x18052D0 VA: 0x1818060D0
	public static TypedReference MakeTypedReference(object target, FieldInfo[] flds) { }

	// RVA: 0x18060C0 Offset: 0x18052C0 VA: 0x1818060C0
	private static void InternalMakeTypedReference(void* result, object target, IntPtr[] flds, RuntimeType lastFieldType) { }

	// RVA: 0x1806030 Offset: 0x1805230 VA: 0x181806030 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1805FD0 Offset: 0x18051D0 VA: 0x181805FD0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x18066C0 Offset: 0x18058C0 VA: 0x1818066C0
	internal bool get_IsNull() { }

	[CLSCompliant(False)]
	// RVA: 0x1806670 Offset: 0x1805870 VA: 0x181806670
	public static void SetTypedReference(TypedReference target, object value) { }
}

// Namespace: System
[ComVisible(True)]
[Serializable]
public class TypeLoadException : SystemException, ISerializable // TypeDefIndex: 3209
{
	// Fields
	private string ClassName; // 0x90
	private string AssemblyName; // 0x98
	private string MessageArg; // 0xA0
	internal int ResourceId; // 0xA8

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x1805E80 Offset: 0x1805080 VA: 0x181805E80
	public void .ctor() { }

	// RVA: 0x1805E50 Offset: 0x1805050 VA: 0x181805E50
	public void .ctor(string message) { }

	// RVA: 0x1805F40 Offset: 0x1805140 VA: 0x181805F40 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1805B80 Offset: 0x1804D80 VA: 0x181805B80
	private void SetMessageField() { }

	// RVA: 0x1805ED0 Offset: 0x18050D0 VA: 0x181805ED0
	private void .ctor(string className, string assemblyName) { }

	// RVA: 0x1805C90 Offset: 0x1804E90 VA: 0x181805C90
	private void .ctor(string className, string assemblyName, string messageArg, int resourceId) { }

	// RVA: 0x1805D10 Offset: 0x1804F10 VA: 0x181805D10
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18059C0 Offset: 0x1804BC0 VA: 0x1818059C0 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System
[Serializable]
internal class UnitySerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 3210
{
	// Fields
	private Type[] m_instantiation; // 0x10
	private int[] m_elementTypes; // 0x18
	private int m_genericParameterPosition; // 0x20
	private Type m_declaringType; // 0x28
	private MethodBase m_declaringMethod; // 0x30
	private string m_data; // 0x38
	private string m_assemblyName; // 0x40
	private int m_unityType; // 0x48

	// Methods

	// RVA: 0x18066E0 Offset: 0x18058E0 VA: 0x1818066E0
	internal static RuntimeType AddElementTypes(SerializationInfo info, RuntimeType type) { }

	// RVA: 0x18077B0 Offset: 0x18069B0 VA: 0x1818077B0
	internal Type MakeElementTypes(Type type) { }

	// RVA: 0x1807680 Offset: 0x1806880 VA: 0x181807680
	internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType) { }

	// RVA: 0x1807010 Offset: 0x1806210 VA: 0x181807010
	internal static void GetUnitySerializationInfo(SerializationInfo info, RuntimeType type) { }

	// RVA: 0x1807500 Offset: 0x1806700 VA: 0x181807500
	internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType, string data, RuntimeAssembly assembly) { }

	// RVA: 0x1807990 Offset: 0x1806B90 VA: 0x181807990
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18078E0 Offset: 0x1806AE0 VA: 0x1818078E0
	private void ThrowInsufficientInformation(string field) { }

	// RVA: 0x1806920 Offset: 0x1805B20 VA: 0x181806920 Slot: 6
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1806980 Offset: 0x1805B80 VA: 0x181806980 Slot: 7
	public virtual object GetRealObject(StreamingContext context) { }
}

// Namespace: System
internal static class AppContextDefaultValues // TypeDefIndex: 3211
{
	// Fields
	internal static readonly string SwitchEnforceJapaneseEraYearRanges; // 0x0
	internal static readonly string SwitchFormatJapaneseFirstYearAsANumber; // 0x8
	internal static readonly string SwitchEnforceLegacyJapaneseDateParsing; // 0x10

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void PopulateDefaultValues() { }

	// RVA: 0x17EE920 Offset: 0x17EDB20 VA: 0x1817EE920
	public static bool TryGetSwitchOverride(string switchName, out bool overrideValue) { }

	// RVA: 0x17EE930 Offset: 0x17EDB30 VA: 0x1817EE930
	private static void .cctor() { }
}

// Namespace: System
[ClassInterface(0)]
[ComVisible(True)]
public sealed class AppDomain : MarshalByRefObject // TypeDefIndex: 3212
{
	// Fields
	private IntPtr _mono_app_domain; // 0x18
	private static string _process_guid; // 0x0
	[ThreadStatic]
	private static Dictionary<string, object> type_resolve_in_progress; // 0x80000000
	[ThreadStatic]
	private static Dictionary<string, object> assembly_resolve_in_progress; // 0x80000008
	[ThreadStatic]
	private static Dictionary<string, object> assembly_resolve_in_progress_refonly; // 0x80000010
	private object _evidence; // 0x20
	private object _granted; // 0x28
	private int _principalPolicy; // 0x30
	[CompilerGenerated]
	private AssemblyLoadEventHandler AssemblyLoad; // 0x38
	[CompilerGenerated]
	private ResolveEventHandler AssemblyResolve; // 0x40
	[CompilerGenerated]
	private EventHandler DomainUnload; // 0x48
	[CompilerGenerated]
	private EventHandler ProcessExit; // 0x50
	[CompilerGenerated]
	private ResolveEventHandler ResourceResolve; // 0x58
	[CompilerGenerated]
	private ResolveEventHandler TypeResolve; // 0x60
	[CompilerGenerated]
	private UnhandledExceptionEventHandler UnhandledException; // 0x68
	[CompilerGenerated]
	private EventHandler<FirstChanceExceptionEventArgs> FirstChanceException; // 0x70
	private object _domain_manager; // 0x78
	[CompilerGenerated]
	private ResolveEventHandler ReflectionOnlyAssemblyResolve; // 0x80
	private object _activation; // 0x88
	private object _applicationIdentity; // 0x90
	private List<string> compatibility_switch; // 0x98

	// Properties
	public static AppDomain CurrentDomain { get; }
	[MonoTODO]
	public bool IsHomogenous { get; }
	[MonoTODO]
	public bool IsFullyTrusted { get; }

	// Methods

	[Intrinsic]
	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	internal static bool IsAppXModel() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void .ctor() { }

	// RVA: 0x17EFD10 Offset: 0x17EEF10 VA: 0x1817EFD10
	private string getFriendlyName() { }

	// RVA: 0x17EFFA0 Offset: 0x17EF1A0 VA: 0x1817EFFA0
	private static AppDomain getCurDomain() { }

	// RVA: 0x17EFFA0 Offset: 0x17EF1A0 VA: 0x1817EFFA0
	public static AppDomain get_CurrentDomain() { }

	// RVA: 0x17EF290 Offset: 0x17EE490 VA: 0x1817EF290
	private Assembly[] GetAssemblies(bool refOnly) { }

	// RVA: 0x17EF280 Offset: 0x17EE480 VA: 0x1817EF280 Slot: 6
	public Assembly[] GetAssemblies() { }

	// RVA: 0x17EF2B0 Offset: 0x17EE4B0 VA: 0x1817EF2B0 Slot: 7
	public object GetData(string name) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public override object InitializeLifetimeService() { }

	// RVA: 0x17EF6A0 Offset: 0x17EE8A0 VA: 0x1817EF6A0
	internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly, ref StackCrawlMark stackMark) { }

	// RVA: 0x17EF6B0 Offset: 0x17EE8B0 VA: 0x1817EF6B0
	internal Assembly LoadSatellite(AssemblyName assemblyRef, bool throwOnError, ref StackCrawlMark stackMark) { }

	// RVA: 0x17EFAB0 Offset: 0x17EECB0 VA: 0x1817EFAB0 Slot: 8
	public Assembly Load(string assemblyString) { }

	// RVA: 0x17EF990 Offset: 0x17EEB90 VA: 0x1817EF990
	internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly, ref StackCrawlMark stackMark) { }

	// RVA: 0x17EF8F0 Offset: 0x17EEAF0 VA: 0x1817EF8F0 Slot: 9
	public Assembly Load(byte[] rawAssembly) { }

	// RVA: 0x17EF690 Offset: 0x17EE890 VA: 0x1817EF690
	internal Assembly LoadAssemblyRaw(byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence, bool refonly) { }

	[Obsolete("Use an overload that does not take an Evidence parameter")]
	// RVA: 0x17EF860 Offset: 0x17EEA60 VA: 0x1817EF860 Slot: 10
	public Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence) { }

	// RVA: 0x17EF7C0 Offset: 0x17EE9C0 VA: 0x1817EF7C0
	internal Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence, bool refonly) { }

	// RVA: 0x17EF470 Offset: 0x17EE670 VA: 0x1817EF470
	private static AppDomain InternalSetDomainByID(int domain_id) { }

	// RVA: 0x17EF480 Offset: 0x17EE680 VA: 0x1817EF480
	private static AppDomain InternalSetDomain(AppDomain context) { }

	// RVA: 0x17EF450 Offset: 0x17EE650 VA: 0x1817EF450
	internal static void InternalPushDomainRefByID(int domain_id) { }

	// RVA: 0x17EF440 Offset: 0x17EE640 VA: 0x1817EF440
	internal static void InternalPopDomainRef() { }

	// RVA: 0x17EF460 Offset: 0x17EE660 VA: 0x1817EF460
	internal static Context InternalSetContext(Context context) { }

	// RVA: 0x17EF420 Offset: 0x17EE620 VA: 0x1817EF420
	internal static Context InternalGetContext() { }

	// RVA: 0x17EF420 Offset: 0x17EE620 VA: 0x1817EF420
	internal static Context InternalGetDefaultContext() { }

	// RVA: 0x17EF430 Offset: 0x17EE630 VA: 0x1817EF430
	internal static string InternalGetProcessGuid(string newguid) { }

	// RVA: 0x17EF490 Offset: 0x17EE690 VA: 0x1817EF490
	internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, object[] args) { }

	// RVA: 0x17EF390 Offset: 0x17EE590 VA: 0x1817EF390
	internal static string GetProcessGuid() { }

	// RVA: 0x158A1E0 Offset: 0x15893E0 VA: 0x18158A1E0
	private static bool InternalIsFinalizingForUnload(int domain_id) { }

	// RVA: 0x17EF670 Offset: 0x17EE870 VA: 0x1817EF670
	public bool IsFinalizingForUnload() { }

	// RVA: 0x17EFFB0 Offset: 0x17EF1B0 VA: 0x1817EFFB0
	private int getDomainID() { }

	[Obsolete("AppDomain.GetCurrentThreadId has been deprecated because it does not provide a stable Id when managed threads are running on fibers (aka lightweight threads). To get a stable identifier for a managed thread, use the ManagedThreadId property on Thread.'")]
	// RVA: 0x17EF2A0 Offset: 0x17EE4A0 VA: 0x1817EF2A0
	public static int GetCurrentThreadId() { }

	// RVA: 0x17EFD10 Offset: 0x17EEF10 VA: 0x1817EFD10 Slot: 3
	public override string ToString() { }

	// RVA: 0x17EE9D0 Offset: 0x17EDBD0 VA: 0x1817EE9D0
	private void DoAssemblyLoad(Assembly assembly) { }

	// RVA: 0x17EEA60 Offset: 0x17EDC60 VA: 0x1817EEA60
	private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly) { }

	// RVA: 0x17EEF70 Offset: 0x17EE170 VA: 0x1817EEF70
	internal Assembly DoTypeResolve(string name) { }

	// RVA: 0x17EEE00 Offset: 0x17EE000 VA: 0x1817EEE00
	internal Assembly DoResourceResolve(string name, Assembly requesting) { }

	// RVA: 0x17EEDD0 Offset: 0x17EDFD0 VA: 0x1817EEDD0
	private void DoDomainUnload() { }

	// RVA: 0x17EF2C0 Offset: 0x17EE4C0 VA: 0x1817EF2C0
	internal byte[] GetMarshalledDomainObjRef() { }

	// RVA: 0x17EFBE0 Offset: 0x17EEDE0 VA: 0x1817EFBE0
	internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, out byte[] arrResponse, out CADMethodReturnMessage cadMrm) { }

	[CompilerGenerated]
	// RVA: 0x17EFD20 Offset: 0x17EEF20 VA: 0x1817EFD20 Slot: 11
	public void add_AssemblyResolve(ResolveEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x17EFFC0 Offset: 0x17EF1C0 VA: 0x1817EFFC0 Slot: 12
	public void remove_AssemblyResolve(ResolveEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x17EFDC0 Offset: 0x17EEFC0 VA: 0x1817EFDC0 Slot: 13
	public void add_DomainUnload(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x17F0060 Offset: 0x17EF260 VA: 0x1817F0060 Slot: 14
	public void remove_DomainUnload(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x17EFE60 Offset: 0x17EF060 VA: 0x1817EFE60 Slot: 15
	public void add_ProcessExit(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x17F0100 Offset: 0x17EF300 VA: 0x1817F0100 Slot: 16
	public void remove_ProcessExit(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x17EFF00 Offset: 0x17EF100 VA: 0x1817EFF00 Slot: 17
	public void add_UnhandledException(UnhandledExceptionEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x17F01A0 Offset: 0x17EF3A0 VA: 0x1817F01A0 Slot: 18
	public void remove_UnhandledException(UnhandledExceptionEventHandler value) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	public bool get_IsHomogenous() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	public bool get_IsFullyTrusted() { }
}

// Namespace: System
internal static class CompatibilitySwitches // TypeDefIndex: 3213
{
	// Fields
	public static readonly bool IsAppEarlierThanWindowsPhone8; // 0x0
}

// Namespace: 
[ComVisible(True)]
public enum Environment.SpecialFolder // TypeDefIndex: 3214
{
	// Fields
	public int value__; // 0x0
	public const Environment.SpecialFolder MyDocuments = 5;
	public const Environment.SpecialFolder Desktop = 0;
	public const Environment.SpecialFolder MyComputer = 17;
	public const Environment.SpecialFolder Programs = 2;
	public const Environment.SpecialFolder Personal = 5;
	public const Environment.SpecialFolder Favorites = 6;
	public const Environment.SpecialFolder Startup = 7;
	public const Environment.SpecialFolder Recent = 8;
	public const Environment.SpecialFolder SendTo = 9;
	public const Environment.SpecialFolder StartMenu = 11;
	public const Environment.SpecialFolder MyMusic = 13;
	public const Environment.SpecialFolder DesktopDirectory = 16;
	public const Environment.SpecialFolder Templates = 21;
	public const Environment.SpecialFolder ApplicationData = 26;
	public const Environment.SpecialFolder LocalApplicationData = 28;
	public const Environment.SpecialFolder InternetCache = 32;
	public const Environment.SpecialFolder Cookies = 33;
	public const Environment.SpecialFolder History = 34;
	public const Environment.SpecialFolder CommonApplicationData = 35;
	public const Environment.SpecialFolder System = 37;
	public const Environment.SpecialFolder ProgramFiles = 38;
	public const Environment.SpecialFolder MyPictures = 39;
	public const Environment.SpecialFolder CommonProgramFiles = 43;
	public const Environment.SpecialFolder MyVideos = 14;
	public const Environment.SpecialFolder NetworkShortcuts = 19;
	public const Environment.SpecialFolder Fonts = 20;
	public const Environment.SpecialFolder CommonStartMenu = 22;
	public const Environment.SpecialFolder CommonPrograms = 23;
	public const Environment.SpecialFolder CommonStartup = 24;
	public const Environment.SpecialFolder CommonDesktopDirectory = 25;
	public const Environment.SpecialFolder PrinterShortcuts = 27;
	public const Environment.SpecialFolder Windows = 36;
	public const Environment.SpecialFolder UserProfile = 40;
	public const Environment.SpecialFolder SystemX86 = 41;
	public const Environment.SpecialFolder ProgramFilesX86 = 42;
	public const Environment.SpecialFolder CommonProgramFilesX86 = 44;
	public const Environment.SpecialFolder CommonTemplates = 45;
	public const Environment.SpecialFolder CommonDocuments = 46;
	public const Environment.SpecialFolder CommonAdminTools = 47;
	public const Environment.SpecialFolder AdminTools = 48;
	public const Environment.SpecialFolder CommonMusic = 53;
	public const Environment.SpecialFolder CommonPictures = 54;
	public const Environment.SpecialFolder CommonVideos = 55;
	public const Environment.SpecialFolder Resources = 56;
	public const Environment.SpecialFolder LocalizedResources = 57;
	public const Environment.SpecialFolder CommonOemLinks = 58;
	public const Environment.SpecialFolder CDBurning = 59;
}

// Namespace: 
public enum Environment.SpecialFolderOption // TypeDefIndex: 3215
{
	// Fields
	public int value__; // 0x0
	public const Environment.SpecialFolderOption None = 0;
	public const Environment.SpecialFolderOption DoNotVerify = 16384;
	public const Environment.SpecialFolderOption Create = 32768;
}

// Namespace: System
[ComVisible(True)]
public static class Environment // TypeDefIndex: 3216
{
	// Fields
	private const string mono_corlib_version = "1A5E0066-58DC-428A-B21C-0AD6CDAE2789";
	private static string nl; // 0x0
	private static OperatingSystem os; // 0x8

	// Properties
	public static string CurrentDirectory { get; }
	public static int CurrentManagedThreadId { get; }
	public static bool HasShutdownStarted { get; }
	public static string MachineName { get; }
	public static string NewLine { get; }
	internal static PlatformID Platform { get; }
	public static OperatingSystem OSVersion { get; }
	public static string StackTrace { get; }
	public static string SystemDirectory { get; }
	public static int TickCount { get; }
	public static string UserDomainName { get; }
	public static string UserName { get; }
	public static Version Version { get; }
	public static bool Is64BitOperatingSystem { get; }
	public static bool Is64BitProcess { get; }
	public static int ProcessorCount { get; }
	internal static bool IsRunningOnWindows { get; }
	internal static bool IsUnix { get; }

	// Methods

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	internal static string GetResourceString(string key) { }

	// RVA: 0x17F5C40 Offset: 0x17F4E40 VA: 0x1817F5C40
	internal static string GetResourceString(string key, object[] values) { }

	// RVA: 0x17F5AF0 Offset: 0x17F4CF0 VA: 0x1817F5AF0
	internal static string GetResourceStringEncodingName(int codePage) { }

	// RVA: 0x17F6600 Offset: 0x17F5800 VA: 0x1817F6600
	public static string get_CurrentDirectory() { }

	// RVA: 0x17F6610 Offset: 0x17F5810 VA: 0x1817F6610
	public static int get_CurrentManagedThreadId() { }

	// RVA: 0x17F6640 Offset: 0x17F5840 VA: 0x1817F6640
	public static bool get_HasShutdownStarted() { }

	// RVA: 0x17F66A0 Offset: 0x17F58A0 VA: 0x1817F66A0
	public static string get_MachineName() { }

	// RVA: 0x17F5AC0 Offset: 0x17F4CC0 VA: 0x1817F5AC0
	private static string GetNewLine() { }

	// RVA: 0x17F66B0 Offset: 0x17F58B0 VA: 0x1817F66B0
	public static string get_NewLine() { }

	[CompilerGenerated]
	// RVA: 0x17F69A0 Offset: 0x17F5BA0 VA: 0x1817F69A0
	internal static PlatformID get_Platform() { }

	// RVA: 0x17F5AD0 Offset: 0x17F4CD0 VA: 0x1817F5AD0
	internal static string GetOSVersionString() { }

	// RVA: 0x17F6710 Offset: 0x17F5910 VA: 0x1817F6710
	public static OperatingSystem get_OSVersion() { }

	// RVA: 0x17F5250 Offset: 0x17F4450 VA: 0x1817F5250
	internal static Version CreateVersionFromString(string info) { }

	// RVA: 0x17F69C0 Offset: 0x17F5BC0 VA: 0x1817F69C0
	public static string get_StackTrace() { }

	// RVA: 0x17F6A30 Offset: 0x17F5C30 VA: 0x1817F6A30
	public static string get_SystemDirectory() { }

	// RVA: 0x17F6C90 Offset: 0x17F5E90 VA: 0x1817F6C90
	public static int get_TickCount() { }

	// RVA: 0x17F66A0 Offset: 0x17F58A0 VA: 0x1817F66A0
	public static string get_UserDomainName() { }

	// RVA: 0x17F6CA0 Offset: 0x17F5EA0 VA: 0x1817F6CA0
	public static string get_UserName() { }

	// RVA: 0x17F6CB0 Offset: 0x17F5EB0 VA: 0x1817F6CB0
	public static Version get_Version() { }

	// RVA: 0x17F5410 Offset: 0x17F4610 VA: 0x1817F5410
	public static void Exit(int exitCode) { }

	// RVA: 0x17F5420 Offset: 0x17F4620 VA: 0x1817F5420
	public static string ExpandEnvironmentVariables(string name) { }

	// RVA: 0x17F5830 Offset: 0x17F4A30 VA: 0x1817F5830
	public static string[] GetCommandLineArgs() { }

	// RVA: 0x17F6DB0 Offset: 0x17F5FB0 VA: 0x1817F6DB0
	internal static string internalGetEnvironmentVariable_native(IntPtr variable) { }

	// RVA: 0x17F6D10 Offset: 0x17F5F10 VA: 0x1817F6D10
	internal static string internalGetEnvironmentVariable(string variable) { }

	// RVA: 0x17F5850 Offset: 0x17F4A50 VA: 0x1817F5850
	public static string GetEnvironmentVariable(string variable) { }

	// RVA: 0x17F5860 Offset: 0x17F4A60 VA: 0x1817F5860
	private static Hashtable GetEnvironmentVariablesNoCase() { }

	// RVA: 0x17F5950 Offset: 0x17F4B50 VA: 0x1817F5950
	public static IDictionary GetEnvironmentVariables() { }

	// RVA: 0x17F5A20 Offset: 0x17F4C20 VA: 0x1817F5A20
	public static string GetFolderPath(Environment.SpecialFolder folder) { }

	// RVA: 0x17F5D40 Offset: 0x17F4F40 VA: 0x1817F5D40
	private static string GetWindowsFolderPath(int folder) { }

	// RVA: 0x17F5A60 Offset: 0x17F4C60 VA: 0x1817F5A60
	public static string GetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option) { }

	// RVA: 0x17F5D50 Offset: 0x17F4F50 VA: 0x1817F5D50
	private static string ReadXdgUserDir(string config_dir, string home_dir, string key, string fallback) { }

	// RVA: 0x17F6090 Offset: 0x17F5290 VA: 0x1817F6090
	internal static string UnixGetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option) { }

	// RVA: 0x17F5810 Offset: 0x17F4A10 VA: 0x1817F5810
	public static void FailFast(string message) { }

	// RVA: 0x17F5800 Offset: 0x17F4A00 VA: 0x1817F5800
	public static void FailFast(string message, Exception exception) { }

	// RVA: 0x17F5820 Offset: 0x17F4A20 VA: 0x1817F5820
	internal static void FailFast(string message, Exception exception, string errorSource) { }

	// RVA: 0x1679DF0 Offset: 0x1678FF0 VA: 0x181679DF0
	private static bool GetIs64BitOperatingSystem() { }

	// RVA: 0x1679DF0 Offset: 0x1678FF0 VA: 0x181679DF0
	public static bool get_Is64BitOperatingSystem() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	public static bool get_Is64BitProcess() { }

	// RVA: 0x17F69B0 Offset: 0x17F5BB0 VA: 0x1817F69B0
	public static int get_ProcessorCount() { }

	// RVA: 0x17F6650 Offset: 0x17F5850 VA: 0x1817F6650
	internal static bool get_IsRunningOnWindows() { }

	// RVA: 0x17F5840 Offset: 0x17F4A40 VA: 0x1817F5840
	private static string[] GetEnvironmentVariableNames() { }

	// RVA: 0x17F5AB0 Offset: 0x17F4CB0 VA: 0x1817F5AB0
	internal static string GetMachineConfigPath() { }

	// RVA: 0x17F6DC0 Offset: 0x17F5FC0 VA: 0x1817F6DC0
	internal static string internalGetHome() { }

	// RVA: 0x17F5AE0 Offset: 0x17F4CE0 VA: 0x1817F5AE0
	internal static int GetPageSize() { }

	// RVA: 0x17F6670 Offset: 0x17F5870 VA: 0x1817F6670
	internal static bool get_IsUnix() { }

	// RVA: 0x17F5CB0 Offset: 0x17F4EB0 VA: 0x1817F5CB0
	internal static string GetStackTrace(Exception e, bool needFileInfo) { }
}

// Namespace: System
internal class MonoTypeInfo // TypeDefIndex: 3217
{
	// Fields
	public string full_name; // 0x10
	public RuntimeConstructorInfo default_ctor; // 0x18

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor() { }
}

// Namespace: System
internal sealed class TypeNameParser // TypeDefIndex: 3218
{
	// Methods

	// RVA: 0x1805F60 Offset: 0x1805160 VA: 0x181805F60
	internal static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase, ref StackCrawlMark stackMark) { }
}

// Namespace: System
[ComVisible(True)]
[ClassInterface(0)]
[Serializable]
public sealed class AppDomainSetup // TypeDefIndex: 3219
{
	// Fields
	private string application_base; // 0x10
	private string application_name; // 0x18
	private string cache_path; // 0x20
	private string configuration_file; // 0x28
	private string dynamic_base; // 0x30
	private string license_file; // 0x38
	private string private_bin_path; // 0x40
	private string private_bin_path_probe; // 0x48
	private string shadow_copy_directories; // 0x50
	private string shadow_copy_files; // 0x58
	private bool publisher_policy; // 0x60
	private bool path_changed; // 0x61
	private int loader_optimization; // 0x64
	private bool disallow_binding_redirects; // 0x68
	private bool disallow_code_downloads; // 0x69
	private object _activationArguments; // 0x70
	private object domain_initializer; // 0x78
	private object application_trust; // 0x80
	private string[] domain_initializer_args; // 0x88
	private bool disallow_appbase_probe; // 0x90
	private byte[] configuration_bytes; // 0x98
	private byte[] serialized_non_primitives; // 0xA0
	private string manager_assembly; // 0xA8
	private string manager_type; // 0xB0
	private string[] partial_visible_assemblies; // 0xB8
	[CompilerGenerated]
	private string <TargetFrameworkName>k__BackingField; // 0xC0

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor() { }
}

// Namespace: System
public struct ArgIterator // TypeDefIndex: 3220
{
	// Fields
	private IntPtr sig; // 0x0
	private IntPtr args; // 0x8
	private int next_arg; // 0x10
	private int num_args; // 0x14

	// Methods

	// RVA: 0x17F0240 Offset: 0x17EF440 VA: 0x1817F0240 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
private sealed class Console.WindowsConsole.WindowsCancelHandler : MulticastDelegate // TypeDefIndex: 3221
{
	// Methods

	// RVA: 0xB865C0 Offset: 0xB857C0 VA: 0x180B865C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual bool Invoke(int keyCode) { }
}

// Namespace: 
private class Console.WindowsConsole // TypeDefIndex: 3222
{
	// Fields
	public static bool ctrlHandlerAdded; // 0x0
	private static Console.WindowsConsole.WindowsCancelHandler cancelHandler; // 0x8

	// Methods

	// RVA: 0x1807DA0 Offset: 0x1806FA0 VA: 0x181807DA0
	private static extern int GetConsoleCP() { }

	// RVA: 0x1807E10 Offset: 0x1807010 VA: 0x181807E10
	private static extern int GetConsoleOutputCP() { }

	// RVA: 0x1807D50 Offset: 0x1806F50 VA: 0x181807D50
	private static bool DoWindowsConsoleCancelEvent(int keyCode) { }

	// RVA: 0x1807E80 Offset: 0x1807080 VA: 0x181807E80
	public static int GetInputCodePage() { }

	// RVA: 0x1807F20 Offset: 0x1807120 VA: 0x181807F20
	public static int GetOutputCodePage() { }

	// RVA: 0x1807FC0 Offset: 0x18071C0 VA: 0x181807FC0
	private static void .cctor() { }
}

// Namespace: System
public static class Console // TypeDefIndex: 3223
{
	// Fields
	internal static TextWriter stdout; // 0x0
	private static TextWriter stderr; // 0x8
	private static TextReader stdin; // 0x10
	internal static bool IsRunningOnAndroid; // 0x18
	private static Encoding inputEncoding; // 0x20
	private static Encoding outputEncoding; // 0x28
	private static ConsoleCancelEventHandler cancel_event; // 0x30

	// Properties
	public static TextWriter Error { get; }
	public static TextWriter Out { get; }
	public static Encoding InputEncoding { get; }
	public static Encoding OutputEncoding { get; }

	// Methods

	// RVA: 0x17F1A50 Offset: 0x17F0C50 VA: 0x1817F1A50
	private static void .cctor() { }

	// RVA: 0x17F1470 Offset: 0x17F0670 VA: 0x1817F1470
	private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding) { }

	// RVA: 0x17F1C50 Offset: 0x17F0E50 VA: 0x1817F1C50
	public static TextWriter get_Error() { }

	// RVA: 0x17F1CF0 Offset: 0x17F0EF0 VA: 0x1817F1CF0
	public static TextWriter get_Out() { }

	// RVA: 0x17F0F30 Offset: 0x17F0130 VA: 0x1817F0F30
	private static Stream Open(IntPtr handle, FileAccess access, int bufferSize) { }

	// RVA: 0x17F0D80 Offset: 0x17EFF80 VA: 0x1817F0D80
	public static Stream OpenStandardError(int bufferSize) { }

	// RVA: 0x17F0E10 Offset: 0x17F0010 VA: 0x1817F0E10
	public static Stream OpenStandardInput(int bufferSize) { }

	// RVA: 0x17F0EA0 Offset: 0x17F00A0 VA: 0x1817F0EA0
	public static Stream OpenStandardOutput(int bufferSize) { }

	// RVA: 0x17F12D0 Offset: 0x17F04D0 VA: 0x1817F12D0
	public static void SetError(TextWriter newError) { }

	// RVA: 0x17F13A0 Offset: 0x17F05A0 VA: 0x1817F13A0
	public static void SetOut(TextWriter newOut) { }

	// RVA: 0x17F19D0 Offset: 0x17F0BD0 VA: 0x1817F19D0
	public static void Write(string value) { }

	// RVA: 0x17F1840 Offset: 0x17F0A40 VA: 0x1817F1840
	public static void WriteLine(object value) { }

	// RVA: 0x17F18C0 Offset: 0x17F0AC0 VA: 0x1817F18C0
	public static void WriteLine(string value) { }

	// RVA: 0x17F1940 Offset: 0x17F0B40 VA: 0x1817F1940
	public static void WriteLine(string format, object arg0) { }

	// RVA: 0x17F1CA0 Offset: 0x17F0EA0 VA: 0x1817F1CA0
	public static Encoding get_InputEncoding() { }

	// RVA: 0x17F1D40 Offset: 0x17F0F40 VA: 0x1817F1D40
	public static Encoding get_OutputEncoding() { }

	// RVA: 0x17F1160 Offset: 0x17F0360 VA: 0x1817F1160
	public static ConsoleKeyInfo ReadKey() { }

	// RVA: 0x17F1020 Offset: 0x17F0220 VA: 0x1817F1020
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x17F0C00 Offset: 0x17EFE00 VA: 0x1817F0C00
	private static void DoConsoleCancelEvent() { }
}

// Namespace: System
internal static class ConsoleDriver // TypeDefIndex: 3224
{
	// Fields
	internal static IConsoleDriver driver; // 0x0
	private static bool is_console; // 0x8
	private static bool called_isatty; // 0x9

	// Properties
	public static bool IsConsole { get; }

	// Methods

	// RVA: 0x17F09B0 Offset: 0x17EFBB0 VA: 0x1817F09B0
	private static void .cctor() { }

	// RVA: 0x17F07A0 Offset: 0x17EF9A0 VA: 0x1817F07A0
	private static IConsoleDriver CreateNullConsoleDriver() { }

	// RVA: 0x17F0830 Offset: 0x17EFA30 VA: 0x1817F0830
	private static IConsoleDriver CreateWindowsConsoleDriver() { }

	// RVA: 0x17F07D0 Offset: 0x17EF9D0 VA: 0x1817F07D0
	private static IConsoleDriver CreateTermInfoDriver(string term) { }

	// RVA: 0x17F0890 Offset: 0x17EFA90 VA: 0x1817F0890
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x17F0AA0 Offset: 0x17EFCA0 VA: 0x1817F0AA0
	public static bool get_IsConsole() { }

	// RVA: 0x17F0880 Offset: 0x17EFA80 VA: 0x1817F0880
	private static bool Isatty(IntPtr handle) { }

	// RVA: 0x17E1060 Offset: 0x17E0260 VA: 0x1817E1060
	internal static int InternalKeyAvailable(int ms_timeout) { }

	// RVA: 0x17F09A0 Offset: 0x17EFBA0 VA: 0x1817F09A0
	internal static bool TtySetup(string keypadXmit, string teardown, out byte[] control_characters, out int* address) { }

	// RVA: 0x160FD90 Offset: 0x160EF90 VA: 0x18160FD90
	internal static bool SetEcho(bool wantEcho) { }
}

// Namespace: System
internal sealed class DelegateData // TypeDefIndex: 3225
{
	// Fields
	public Type target_type; // 0x10
	public string method_name; // 0x18
	public bool curried_first_arg; // 0x20

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor() { }
}

// Namespace: System
[Serializable]
public abstract class Delegate : ICloneable, ISerializable // TypeDefIndex: 3226
{
	// Fields
	private IntPtr method_ptr; // 0x10
	private IntPtr invoke_impl; // 0x18
	private object m_target; // 0x20
	private IntPtr method; // 0x28
	private IntPtr delegate_trampoline; // 0x30
	private IntPtr extra_arg; // 0x38
	private IntPtr method_code; // 0x40
	private IntPtr interp_method; // 0x48
	private IntPtr interp_invoke_impl; // 0x50
	private MethodInfo method_info; // 0x58
	private MethodInfo original_method_info; // 0x60
	private DelegateData data; // 0x68
	private bool method_is_virtual; // 0x70

	// Properties
	public MethodInfo Method { get; }
	public object Target { get; }

	// Methods

	// RVA: 0x6D85F0 Offset: 0x6D77F0 VA: 0x1806D85F0
	public MethodInfo get_Method() { }

	// RVA: 0x17F4950 Offset: 0x17F3B50 VA: 0x1817F4950
	private MethodInfo GetVirtualMethod_internal() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public object get_Target() { }

	// RVA: 0x17F2AA0 Offset: 0x17F1CA0 VA: 0x1817F2AA0
	internal static Delegate CreateDelegate_internal(Type type, object target, MethodInfo info, bool throwOnBindFailure) { }

	// RVA: 0x17F4C90 Offset: 0x17F3E90 VA: 0x1817F4C90
	private static bool arg_type_match(Type delArgType, Type argType) { }

	// RVA: 0x17F4E30 Offset: 0x17F4030 VA: 0x1817F4E30
	private static bool arg_type_match_this(Type delArgType, Type argType, bool boxedThis) { }

	// RVA: 0x17F5020 Offset: 0x17F4220 VA: 0x1817F5020
	private static bool return_type_match(Type delReturnType, Type returnType) { }

	// RVA: 0x17F2BA0 Offset: 0x17F1DA0 VA: 0x1817F2BA0
	private static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure, bool allowClosed) { }

	// RVA: 0x17F37D0 Offset: 0x17F29D0 VA: 0x1817F37D0
	public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method) { }

	// RVA: 0x17F37A0 Offset: 0x17F29A0 VA: 0x1817F37A0
	public static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure) { }

	// RVA: 0x17F3560 Offset: 0x17F2760 VA: 0x1817F3560
	public static Delegate CreateDelegate(Type type, MethodInfo method) { }

	// RVA: 0x17F36A0 Offset: 0x17F28A0 VA: 0x1817F36A0
	public static Delegate CreateDelegate(Type type, object target, string method) { }

	// RVA: 0x17F3FD0 Offset: 0x17F31D0 VA: 0x1817F3FD0
	private static MethodInfo GetCandidateMethod(Type type, Type target, string method, BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0x17F37F0 Offset: 0x17F29F0 VA: 0x1817F37F0
	public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0x17F3780 Offset: 0x17F2980 VA: 0x1817F3780
	public static Delegate CreateDelegate(Type type, Type target, string method) { }

	// RVA: 0x17F3680 Offset: 0x17F2880 VA: 0x1817F3680
	public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase) { }

	// RVA: 0x17F3590 Offset: 0x17F2790 VA: 0x1817F3590
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure) { }

	// RVA: 0x17F2AB0 Offset: 0x17F1CB0 VA: 0x1817F2AB0
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase) { }

	// RVA: 0x17F3DA0 Offset: 0x17F2FA0 VA: 0x1817F3DA0
	public object DynamicInvoke(object[] args) { }

	// RVA: 0x17F4960 Offset: 0x17F3B60 VA: 0x1817F4960
	private void InitializeDelegateData() { }

	// RVA: 0x17F3920 Offset: 0x17F2B20 VA: 0x1817F3920 Slot: 6
	protected virtual object DynamicInvokeImpl(object[] args) { }

	// RVA: 0x17F26D0 Offset: 0x17F18D0 VA: 0x1817F26D0 Slot: 7
	public virtual object Clone() { }

	// RVA: 0x17F3DC0 Offset: 0x17F2FC0 VA: 0x1817F3DC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x17F44C0 Offset: 0x17F36C0 VA: 0x1817F44C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17F45F0 Offset: 0x17F37F0 VA: 0x1817F45F0 Slot: 8
	protected virtual MethodInfo GetMethodImpl() { }

	// RVA: 0x17F4710 Offset: 0x17F3910 VA: 0x1817F4710 Slot: 9
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17F4560 Offset: 0x17F3760 VA: 0x1817F4560 Slot: 10
	public virtual Delegate[] GetInvocationList() { }

	// RVA: 0x17F2740 Offset: 0x17F1940 VA: 0x1817F2740
	public static Delegate Combine(Delegate a, Delegate b) { }

	[ComVisible(True)]
	// RVA: 0x17F28C0 Offset: 0x17F1AC0 VA: 0x1817F28C0
	public static Delegate Combine(Delegate[] delegates) { }

	// RVA: 0x17F26E0 Offset: 0x17F18E0 VA: 0x1817F26E0 Slot: 11
	protected virtual Delegate CombineImpl(Delegate d) { }

	// RVA: 0x17F4B10 Offset: 0x17F3D10 VA: 0x1817F4B10
	public static Delegate Remove(Delegate source, Delegate value) { }

	// RVA: 0x17F4AE0 Offset: 0x17F3CE0 VA: 0x1817F4AE0 Slot: 12
	protected virtual Delegate RemoveImpl(Delegate d) { }

	// RVA: 0x17F4A60 Offset: 0x17F3C60 VA: 0x1817F4A60
	public static Delegate RemoveAll(Delegate source, Delegate value) { }

	// RVA: 0x17F4FA0 Offset: 0x17F41A0 VA: 0x1817F4FA0
	public static bool op_Equality(Delegate d1, Delegate d2) { }

	// RVA: 0x17F4FD0 Offset: 0x17F41D0 VA: 0x1817F4FD0
	public static bool op_Inequality(Delegate d1, Delegate d2) { }

	// RVA: 0x17F26C0 Offset: 0x17F18C0 VA: 0x1817F26C0
	internal static MulticastDelegate AllocDelegateLike_internal(Delegate d) { }
}

// Namespace: 
[Serializable]
private class DelegateSerializationHolder.DelegateEntry // TypeDefIndex: 3227
{
	// Fields
	private string type; // 0x10
	private string assembly; // 0x18
	private object target; // 0x20
	private string targetTypeAssembly; // 0x28
	private string targetTypeName; // 0x30
	private string methodName; // 0x38
	public DelegateSerializationHolder.DelegateEntry delegateEntry; // 0x40

	// Methods

	// RVA: 0x17F2070 Offset: 0x17F1270 VA: 0x1817F2070
	public void .ctor(Delegate del, string targetLabel) { }

	// RVA: 0x17F1D90 Offset: 0x17F0F90 VA: 0x1817F1D90
	public Delegate DeserializeDelegate(SerializationInfo info, int index) { }
}

// Namespace: System
[Serializable]
internal class DelegateSerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 3228
{
	// Fields
	private Delegate _delegate; // 0x10

	// Methods

	// RVA: 0x17F24A0 Offset: 0x17F16A0 VA: 0x1817F24A0
	private void .ctor(SerializationInfo info, StreamingContext ctx) { }

	// RVA: 0x17F2230 Offset: 0x17F1430 VA: 0x1817F2230
	public static void GetDelegateData(Delegate instance, SerializationInfo info, StreamingContext ctx) { }

	// RVA: 0x17F2460 Offset: 0x17F1660 VA: 0x1817F2460 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 5
	public object GetRealObject(StreamingContext context) { }
}

// Namespace: System
internal static class EmptyArray<T> // TypeDefIndex: 3229
{
	// Fields
	public static readonly T[] Value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10DCBE0 Offset: 0x10DBDE0 VA: 0x1810DCBE0
	|-EmptyArray<KeyValuePair<StructMultiKey<object, object>, object>>..cctor
	|-EmptyArray<KeyValuePair<DiscardReasonWithCategory, object>>..cctor
	|-EmptyArray<KeyValuePair<int, object>>..cctor
	|-EmptyArray<KeyValuePair<object, bool>>..cctor
	|-EmptyArray<KeyValuePair<object, char>>..cctor
	|-EmptyArray<KeyValuePair<object, DateTimeOffset>>..cctor
	|-EmptyArray<KeyValuePair<object, object>>..cctor
	|-EmptyArray<KeyValuePair<ushort, object>>..cctor
	|-EmptyArray<KeyValuePair<ulong, JsonEncodedText>>..cctor
	|-EmptyArray<RefAsValueType<object>>..cctor
	|-EmptyArray<ValueTuple<IntPtr, object>>..cctor
	|-EmptyArray<bool>..cctor
	|-EmptyArray<byte>..cctor
	|-EmptyArray<char>..cctor
	|-EmptyArray<CustomAttributeNamedArgument>..cctor
	|-EmptyArray<CustomAttributeTypedArgument>..cctor
	|-EmptyArray<IndexField>..cctor
	|-EmptyArray<int>..cctor
	|-EmptyArray<Int32Enum>..cctor
	|-EmptyArray<IntPtr>..cctor
	|-EmptyArray<LocalDefinition>..cctor
	|-EmptyArray<Matrix4x4>..cctor
	|-EmptyArray<object>..cctor
	|-EmptyArray<ParameterModifier>..cctor
	|-EmptyArray<Quaternion>..cctor
	|-EmptyArray<Rect>..cctor
	|-EmptyArray<TextureId>..cctor
	|-EmptyArray<ushort>..cctor
	|-EmptyArray<uint>..cctor
	|-EmptyArray<Vector2>..cctor
	|-EmptyArray<Vector3>..cctor
	|-EmptyArray<__Il2CppFullySharedGenericType>..cctor
	|-EmptyArray<jvalue>..cctor
	|-EmptyArray<BaseStyleMatcher.MatchContext>..cctor
	|-EmptyArray<DtlsUnityConnection.QueuedAppData>..cctor
	|-EmptyArray<EventDispatcher.DispatchContext>..cctor
	|-EmptyArray<EventDispatcher.EventRecord>..cctor
	|-EmptyArray<SequenceNode.SequenceConstructPosContext>..cctor
	|-EmptyArray<StyleVariableResolver.ResolveContext>..cctor
	|-EmptyArray<XboxOneInputSource.aTKmDsEGifKjlXcaJEDpFPOnOkdn>..cctor
	|-EmptyArray<BindingRestrictions.TestBuilder.AndNode>..cctor
	*/
}

// Namespace: System
internal enum SByteEnum // TypeDefIndex: 3230
{
	// Fields
	public sbyte value__; // 0x0
}

// Namespace: System
internal enum Int16Enum // TypeDefIndex: 3231
{
	// Fields
	public short value__; // 0x0
}

// Namespace: System
internal enum Int32Enum // TypeDefIndex: 3232
{
	// Fields
	public int value__; // 0x0
}

// Namespace: System
internal enum Int64Enum // TypeDefIndex: 3233
{
	// Fields
	public long value__; // 0x0
}

// Namespace: System
internal enum ByteEnum // TypeDefIndex: 3234
{
	// Fields
	public byte value__; // 0x0
}

// Namespace: System
internal enum UInt16Enum // TypeDefIndex: 3235
{
	// Fields
	public ushort value__; // 0x0
}

// Namespace: System
internal enum UInt32Enum // TypeDefIndex: 3236
{
	// Fields
	public uint value__; // 0x0
}

// Namespace: System
internal enum UInt64Enum // TypeDefIndex: 3237
{
	// Fields
	public ulong value__; // 0x0
}

// Namespace: System
internal interface IConsoleDriver // TypeDefIndex: 3238
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ConsoleKeyInfo ReadKey(bool intercept);
}

// Namespace: System
[ComVisible(True)]
[IsReadOnly]
[Serializable]
public struct IntPtr : ISerializable, IEquatable<IntPtr> // TypeDefIndex: 3239
{
	// Fields
	private readonly void* m_value; // 0x0
	public static readonly IntPtr Zero; // 0x0

	// Properties
	public static int Size { get; }

	// Methods

	[ReliabilityContract(2, 1)]
	// RVA: 0x17F7020 Offset: 0x17F6220 VA: 0x1817F7020
	public void .ctor(int value) { }

	[ReliabilityContract(2, 1)]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void .ctor(long value) { }

	[ReliabilityContract(2, 1)]
	[CLSCompliant(False)]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void .ctor(void* value) { }

	// RVA: 0x17F7030 Offset: 0x17F6230 VA: 0x1817F7030
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0xAA00E0 Offset: 0xA9F2E0 VA: 0x180AA00E0
	public static int get_Size() { }

	// RVA: 0x17F6F20 Offset: 0x17F6120 VA: 0x1817F6F20 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17F6E90 Offset: 0x17F6090 VA: 0x1817F6E90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030 Slot: 2
	public override int GetHashCode() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public int ToInt32() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0xA55380 Offset: 0xA54580 VA: 0x180A55380
	public long ToInt64() { }

	[ReliabilityContract(3, 2)]
	[CLSCompliant(False)]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public void* ToPointer() { }

	// RVA: 0x17F6FF0 Offset: 0x17F61F0 VA: 0x1817F6FF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x17F6FC0 Offset: 0x17F61C0 VA: 0x1817F6FC0
	public string ToString(string format) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0xAA0BD0 Offset: 0xA9FDD0 VA: 0x180AA0BD0
	public static bool op_Equality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x17C3590 Offset: 0x17C2790 VA: 0x1817C3590
	public static bool op_Inequality(IntPtr value1, IntPtr value2) { }

	[ReliabilityContract(2, 1)]
	// RVA: 0x1776240 Offset: 0x1775440 VA: 0x181776240
	public static IntPtr op_Explicit(int value) { }

	[ReliabilityContract(2, 1)]
	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	public static IntPtr op_Explicit(long value) { }

	[ReliabilityContract(2, 1)]
	[CLSCompliant(False)]
	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	public static IntPtr op_Explicit(void* value) { }

	// RVA: 0x937660 Offset: 0x936860 VA: 0x180937660
	public static int op_Explicit(IntPtr value) { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public static long op_Explicit(IntPtr value) { }

	[CLSCompliant(False)]
	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	public static void* op_Explicit(IntPtr value) { }

	[ReliabilityContract(2, 1)]
	// RVA: 0xAA09D0 Offset: 0xA9FBD0 VA: 0x180AA09D0
	public static IntPtr Add(IntPtr pointer, int offset) { }

	[ReliabilityContract(2, 1)]
	// RVA: 0xAA09D0 Offset: 0xA9FBD0 VA: 0x180AA09D0
	public static IntPtr op_Addition(IntPtr pointer, int offset) { }

	[ReliabilityContract(2, 1)]
	// RVA: 0x17F70A0 Offset: 0x17F62A0 VA: 0x1817F70A0
	public static IntPtr op_Subtraction(IntPtr pointer, int offset) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x12175A0 Offset: 0x12167A0 VA: 0x1812175A0
	internal bool IsNull() { }

	// RVA: 0x126BA20 Offset: 0x126AC20 VA: 0x18126BA20 Slot: 5
	private bool System.IEquatable<System.IntPtr>.Equals(IntPtr other) { }
}

// Namespace: System
internal static class KnownTerminals // TypeDefIndex: 3240
{
	// Properties
	public static byte[] linux { get; }
	public static byte[] xterm { get; }
	public static byte[] ansi { get; }

	// Methods

	// RVA: 0x17F7110 Offset: 0x17F6310 VA: 0x1817F7110
	public static byte[] get_linux() { }

	// RVA: 0x17F7170 Offset: 0x17F6370 VA: 0x1817F7170
	public static byte[] get_xterm() { }

	// RVA: 0x17F70B0 Offset: 0x17F62B0 VA: 0x1817F70B0
	public static byte[] get_ansi() { }
}

// Namespace: System
[ComVisible(True)]
[Serializable]
public abstract class MarshalByRefObject // TypeDefIndex: 3241
{
	// Fields
	private object _identity; // 0x10

	// Properties
	internal ServerIdentity ObjectIdentity { get; set; }

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	protected void .ctor() { }

	// RVA: 0x17F7460 Offset: 0x17F6660 VA: 0x1817F7460
	internal ServerIdentity get_ObjectIdentity() { }

	// RVA: 0x17F74A0 Offset: 0x17F66A0 VA: 0x1817F74A0
	internal void set_ObjectIdentity(ServerIdentity value) { }

	// RVA: 0x17F73E0 Offset: 0x17F65E0 VA: 0x1817F73E0 Slot: 4
	public virtual ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x17F7420 Offset: 0x17F6620 VA: 0x1817F7420 Slot: 5
	public virtual object InitializeLifetimeService() { }
}

// Namespace: System
internal class MonoAsyncCall // TypeDefIndex: 3242
{
	// Fields
	private object msg; // 0x10
	private IntPtr cb_method; // 0x18
	private object cb_target; // 0x20
	private object state; // 0x28
	private object res; // 0x30
	private object out_args; // 0x38

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor() { }
}

// Namespace: 
private class MonoCustomAttrs.AttributeInfo // TypeDefIndex: 3243
{
	// Fields
	private AttributeUsageAttribute _usage; // 0x10
	private int _inheritanceLevel; // 0x18

	// Properties
	public AttributeUsageAttribute Usage { get; }
	public int InheritanceLevel { get; }

	// Methods

	// RVA: 0x17F0290 Offset: 0x17EF490 VA: 0x1817F0290
	public void .ctor(AttributeUsageAttribute usage, int inheritanceLevel) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public AttributeUsageAttribute get_Usage() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_InheritanceLevel() { }
}

// Namespace: System
internal static class MonoCustomAttrs // TypeDefIndex: 3244
{
	// Fields
	private static Assembly corlib; // 0x0
	[ThreadStatic]
	private static Dictionary<Type, AttributeUsageAttribute> usage_cache; // 0x80000000
	private static readonly AttributeUsageAttribute DefaultAttributeUsage; // 0x8

	// Methods

	// RVA: 0x17FAC60 Offset: 0x17F9E60 VA: 0x1817FAC60
	private static bool IsUserCattrProvider(object obj) { }

	// RVA: 0x17F9200 Offset: 0x17F8400 VA: 0x1817F9200
	internal static Attribute[] GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs) { }

	// RVA: 0x17FA550 Offset: 0x17F9750 VA: 0x1817FA550
	internal static object[] GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType) { }

	// RVA: 0x17FA3E0 Offset: 0x17F95E0 VA: 0x1817FA3E0
	private static object[] GetPseudoCustomAttributes(Type type) { }

	// RVA: 0x17F7FF0 Offset: 0x17F71F0 VA: 0x1817F7FF0
	internal static object[] GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly) { }

	// RVA: 0x17F9210 Offset: 0x17F8410 VA: 0x1817F9210
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x17F9D10 Offset: 0x17F8F10 VA: 0x1817F9D10
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, bool inherit) { }

	// RVA: 0x17F8340 Offset: 0x17F7540 VA: 0x1817F8340
	private static CustomAttributeData[] GetCustomAttributesDataInternal(ICustomAttributeProvider obj) { }

	// RVA: 0x17F90C0 Offset: 0x17F82C0 VA: 0x1817F90C0
	internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj, bool inherit = False) { }

	// RVA: 0x17F8350 Offset: 0x17F7550 VA: 0x1817F8350
	internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x17F81D0 Offset: 0x17F73D0 VA: 0x1817F81D0
	internal static IList<CustomAttributeData> GetCustomAttributesDataBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly) { }

	// RVA: 0x17F9EA0 Offset: 0x17F90A0 VA: 0x1817F9EA0
	internal static CustomAttributeData[] GetPseudoCustomAttributesData(ICustomAttributeProvider obj, Type attributeType) { }

	// RVA: 0x17FA1A0 Offset: 0x17F93A0 VA: 0x1817FA1A0
	private static CustomAttributeData[] GetPseudoCustomAttributesData(Type type) { }

	// RVA: 0x17FA990 Offset: 0x17F9B90 VA: 0x1817FA990
	internal static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x17FA980 Offset: 0x17F9B80 VA: 0x1817FA980
	internal static bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType) { }

	// RVA: 0x17F7770 Offset: 0x17F6970 VA: 0x1817F7770
	private static PropertyInfo GetBasePropertyDefinition(RuntimePropertyInfo property) { }

	// RVA: 0x17F74E0 Offset: 0x17F66E0 VA: 0x1817F74E0
	private static EventInfo GetBaseEventDefinition(RuntimeEventInfo evt) { }

	// RVA: 0x17F7B10 Offset: 0x17F6D10 VA: 0x1817F7B10
	private static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj) { }

	// RVA: 0x17FAEB0 Offset: 0x17FA0B0 VA: 0x1817FAEB0
	private static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType) { }

	// RVA: 0x17FB120 Offset: 0x17FA320 VA: 0x1817FB120
	private static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType) { }

	// RVA: 0x17FB2A0 Offset: 0x17FA4A0 VA: 0x1817FB2A0
	private static void .cctor() { }
}

// Namespace: System
internal sealed class MonoListItem // TypeDefIndex: 3245
{
	// Fields
	private MonoListItem next; // 0x10
	private object data; // 0x18

	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor() { }
}

// Namespace: System
internal sealed class MonoType : RuntimeType // TypeDefIndex: 3246
{}

// Namespace: System
[ComVisible(True)]
[Serializable]
public abstract class MulticastDelegate : Delegate // TypeDefIndex: 3247
{
	// Fields
	private Delegate[] delegates; // 0x78

	// Methods

	// RVA: 0x17F4710 Offset: 0x17F3910 VA: 0x1817F4710 Slot: 9
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17FB650 Offset: 0x17FA850 VA: 0x1817FB650 Slot: 6
	protected sealed override object DynamicInvokeImpl(object[] args) { }

	// RVA: 0x17FB710 Offset: 0x17FA910 VA: 0x1817FB710 Slot: 0
	public sealed override bool Equals(object obj) { }

	// RVA: 0x17F44C0 Offset: 0x17F36C0 VA: 0x1817F44C0 Slot: 2
	public sealed override int GetHashCode() { }

	// RVA: 0x17FB970 Offset: 0x17FAB70 VA: 0x1817FB970 Slot: 8
	protected override MethodInfo GetMethodImpl() { }

	// RVA: 0x17FB890 Offset: 0x17FAA90 VA: 0x1817FB890 Slot: 10
	public sealed override Delegate[] GetInvocationList() { }

	// RVA: 0x17FB310 Offset: 0x17FA510 VA: 0x1817FB310 Slot: 11
	protected sealed override Delegate CombineImpl(Delegate follow) { }

	// RVA: 0x17FBAE0 Offset: 0x17FACE0 VA: 0x1817FBAE0
	private int LastIndexOf(Delegate[] haystack, Delegate[] needle) { }

	// RVA: 0x17FBC70 Offset: 0x17FAE70 VA: 0x1817FBC70 Slot: 12
	protected sealed override Delegate RemoveImpl(Delegate value) { }
}

// Namespace: System
internal class NullConsoleDriver : IConsoleDriver // TypeDefIndex: 3248
{
	// Fields
	private static readonly ConsoleKeyInfo EmptyConsoleKeyInfo; // 0x0

	// Methods

	// RVA: 0x17FBFE0 Offset: 0x17FB1E0 VA: 0x1817FBFE0 Slot: 4
	public ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor() { }

	// RVA: 0x17FC050 Offset: 0x17FB250 VA: 0x1817FC050
	private static void .cctor() { }
}

// Namespace: System
[ClassInterface(2)]
[ComVisible(True)]
[Serializable]
public class Object // TypeDefIndex: 3249
{
	// Methods

	// RVA: 0xAA0BD0 Offset: 0xA9FDD0 VA: 0x180AA0BD0 Slot: 0
	public virtual bool Equals(object obj) { }

	// RVA: 0x1676FE0 Offset: 0x16761E0 VA: 0x181676FE0
	public static bool Equals(object objA, object objB) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void .ctor() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 1
	protected virtual void Finalize() { }

	// RVA: 0x17FC0C0 Offset: 0x17FB2C0 VA: 0x1817FC0C0 Slot: 2
	public virtual int GetHashCode() { }

	// RVA: 0x17FC0D0 Offset: 0x17FB2D0 VA: 0x1817FC0D0
	public Type GetType() { }

	// RVA: 0x17F26D0 Offset: 0x17F18D0 VA: 0x1817F26D0
	protected object MemberwiseClone() { }

	// RVA: 0x17FC0E0 Offset: 0x17FB2E0 VA: 0x1817FC0E0 Slot: 3
	public virtual string ToString() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0xAA0BD0 Offset: 0xA9FDD0 VA: 0x180AA0BD0
	public static bool ReferenceEquals(object objA, object objB) { }

	// RVA: 0x17FC0C0 Offset: 0x17FB2C0 VA: 0x1817FC0C0
	internal static int InternalGetHashCode(object o) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void FieldGetter(string typeName, string fieldName, ref object val) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void FieldSetter(string typeName, string fieldName, object val) { }
}

// Namespace: System
[ComVisible(True)]
[Serializable]
public enum PlatformID // TypeDefIndex: 3250
{
	// Fields
	public int value__; // 0x0
	public const PlatformID Win32S = 0;
	public const PlatformID Win32Windows = 1;
	public const PlatformID Win32NT = 2;
	public const PlatformID WinCE = 3;
	public const PlatformID Unix = 4;
	public const PlatformID Xbox = 5;
	public const PlatformID MacOSX = 6;
}

// Namespace: System
[IsByRefLike]
public struct RuntimeArgumentHandle // TypeDefIndex: 3251
{
	// Fields
	internal IntPtr args; // 0x0
}

// Namespace: System
[ComVisible(True)]
[Serializable]
public struct RuntimeFieldHandle : ISerializable // TypeDefIndex: 3252
{
	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(IntPtr v) { }

	// RVA: 0x17FD900 Offset: 0x17FCB00 VA: 0x1817FD900
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_Value() { }

	// RVA: 0x17FD730 Offset: 0x17FC930 VA: 0x1817FD730 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x17FD640 Offset: 0x17FC840 VA: 0x1817FD640 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17FD8F0 Offset: 0x17FCAF0 VA: 0x1817FD8F0
	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

	// RVA: 0x17FD8F0 Offset: 0x17FCAF0 VA: 0x1817FD8F0
	internal static void SetValue(RuntimeFieldInfo field, object obj, object value, RuntimeType fieldType, FieldAttributes fieldAttr, RuntimeType declaringType, ref bool domainInitialized) { }

	// RVA: 0x17FD8E0 Offset: 0x17FCAE0 VA: 0x1817FD8E0
	internal static void SetValueDirect(RuntimeFieldInfo field, RuntimeType fieldType, void* pTypedRef, object value, RuntimeType contextType) { }
}

// Namespace: System
[ComVisible(True)]
[Serializable]
public struct RuntimeMethodHandle : ISerializable // TypeDefIndex: 3253
{
	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(IntPtr v) { }

	// RVA: 0x17FDEC0 Offset: 0x17FD0C0 VA: 0x1817FDEC0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_Value() { }

	// RVA: 0x17FDD10 Offset: 0x17FCF10 VA: 0x1817FDD10 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x17FDC20 Offset: 0x17FCE20 VA: 0x1817FDC20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17FDAC0 Offset: 0x17FCCC0 VA: 0x1817FDAC0
	internal static string ConstructInstantiation(RuntimeMethodInfo method, TypeNameFormatFlags format) { }

	// RVA: 0x12175A0 Offset: 0x12167A0 VA: 0x1812175A0
	internal bool IsNullHandle() { }
}

// Namespace: System
[ComVisible(True)]
[Serializable]
public struct RuntimeTypeHandle : ISerializable // TypeDefIndex: 3254
{
	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(IntPtr val) { }

	// RVA: 0x17FEA90 Offset: 0x17FDC90 VA: 0x1817FEA90
	internal void .ctor(RuntimeType type) { }

	// RVA: 0x17FE8D0 Offset: 0x17FDAD0 VA: 0x1817FE8D0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_Value() { }

	// RVA: 0x17FE220 Offset: 0x17FD420 VA: 0x1817FE220 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x17FE090 Offset: 0x17FD290 VA: 0x1817FE090 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17FE1A0 Offset: 0x17FD3A0 VA: 0x1817FE1A0
	internal static TypeAttributes GetAttributes(RuntimeType type) { }

	// RVA: 0x17FE200 Offset: 0x17FD400 VA: 0x1817FE200
	private static int GetMetadataToken(RuntimeType type) { }

	// RVA: 0x17FE200 Offset: 0x17FD400 VA: 0x1817FE200
	internal static int GetToken(RuntimeType type) { }

	// RVA: 0x17FE1F0 Offset: 0x17FD3F0 VA: 0x1817FE1F0
	private static Type GetGenericTypeDefinition_impl(RuntimeType type) { }

	// RVA: 0x17FE1F0 Offset: 0x17FD3F0 VA: 0x1817FE1F0
	internal static Type GetGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x17FE850 Offset: 0x17FDA50 VA: 0x1817FE850
	internal static bool IsPrimitive(RuntimeType type) { }

	// RVA: 0x17FE720 Offset: 0x17FD920 VA: 0x1817FE720
	internal static bool IsByRef(RuntimeType type) { }

	// RVA: 0x17FE830 Offset: 0x17FDA30 VA: 0x1817FE830
	internal static bool IsPointer(RuntimeType type) { }

	// RVA: 0x17FE700 Offset: 0x17FD900 VA: 0x1817FE700
	internal static bool IsArray(RuntimeType type) { }

	// RVA: 0x17FE8B0 Offset: 0x17FDAB0 VA: 0x1817FE8B0
	internal static bool IsSzArray(RuntimeType type) { }

	// RVA: 0x17FE6B0 Offset: 0x17FD8B0 VA: 0x1817FE6B0
	internal static bool HasElementType(RuntimeType type) { }

	// RVA: 0x17FE1C0 Offset: 0x17FD3C0 VA: 0x1817FE1C0
	internal static CorElementType GetCorElementType(RuntimeType type) { }

	// RVA: 0x17FE6E0 Offset: 0x17FD8E0 VA: 0x1817FE6E0
	internal static bool HasInstantiation(RuntimeType type) { }

	// RVA: 0x158A1E0 Offset: 0x15893E0 VA: 0x18158A1E0
	internal static bool IsComObject(RuntimeType type) { }

	// RVA: 0x17FE800 Offset: 0x17FDA00 VA: 0x1817FE800
	internal static bool IsInstanceOfType(RuntimeType type, object o) { }

	// RVA: 0x17FE6F0 Offset: 0x17FD8F0 VA: 0x1817FE6F0
	internal static bool HasReferences(RuntimeType type) { }

	// RVA: 0x17FE740 Offset: 0x17FD940 VA: 0x1817FE740
	internal static bool IsComObject(RuntimeType type, bool isGenericCOM) { }

	// RVA: 0x17FE750 Offset: 0x17FD950 VA: 0x1817FE750
	internal static bool IsContextful(RuntimeType type) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2) { }

	// RVA: 0x17FE810 Offset: 0x17FDA10 VA: 0x1817FE810
	internal static bool IsInterface(RuntimeType type) { }

	// RVA: 0x17FE180 Offset: 0x17FD380 VA: 0x1817FE180
	internal static int GetArrayRank(RuntimeType type) { }

	// RVA: 0x17FE190 Offset: 0x17FD390 VA: 0x1817FE190
	internal static RuntimeAssembly GetAssembly(RuntimeType type) { }

	// RVA: 0x17FE1D0 Offset: 0x17FD3D0 VA: 0x1817FE1D0
	internal static RuntimeType GetElementType(RuntimeType type) { }

	// RVA: 0x17FE210 Offset: 0x17FD410 VA: 0x1817FE210
	internal static RuntimeModule GetModule(RuntimeType type) { }

	// RVA: 0x17FE7F0 Offset: 0x17FD9F0 VA: 0x1817FE7F0
	internal static bool IsGenericVariable(RuntimeType type) { }

	// RVA: 0x17FE1B0 Offset: 0x17FD3B0 VA: 0x1817FE1B0
	internal static RuntimeType GetBaseType(RuntimeType type) { }

	// RVA: 0x17FE080 Offset: 0x17FD280 VA: 0x1817FE080
	internal static bool CanCastTo(RuntimeType type, RuntimeType target) { }

	// RVA: 0x17FEAE0 Offset: 0x17FDCE0 VA: 0x1817FEAE0
	private static bool type_is_assignable_from(Type a, Type b) { }

	// RVA: 0x17FE7E0 Offset: 0x17FD9E0 VA: 0x1817FE7E0
	internal static bool IsGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x17FE1E0 Offset: 0x17FD3E0 VA: 0x1817FE1E0
	internal static IntPtr GetGenericParameterInfo(RuntimeType type) { }

	// RVA: 0x17FE880 Offset: 0x17FDA80 VA: 0x1817FE880
	internal static bool IsSubclassOf(RuntimeType childType, RuntimeType baseType) { }

	// RVA: 0x17FEAD0 Offset: 0x17FDCD0 VA: 0x1817FEAD0
	internal static bool is_subclass_of(IntPtr childType, IntPtr baseType) { }

	// RVA: 0x17FEAB0 Offset: 0x17FDCB0 VA: 0x1817FEAB0
	private static RuntimeType internal_from_name(string name, ref StackCrawlMark stackMark, Assembly callerAssembly, bool throwOnError, bool ignoreCase, bool reflectionOnly) { }

	// RVA: 0x17FE3A0 Offset: 0x17FD5A0 VA: 0x1817FE3A0
	internal static RuntimeType GetTypeByName(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark, bool loadTypeFromPartialName) { }
}

// Namespace: System
internal class TermInfoDriver : IConsoleDriver // TypeDefIndex: 3255
{
	// Fields
	private static int* native_terminal_size; // 0x0
	private static int terminal_size; // 0x8
	private static readonly string[] locations; // 0x10
	private TermInfoReader reader; // 0x10
	private int cursorLeft; // 0x18
	private int cursorTop; // 0x1C
	private string title; // 0x20
	private string titleFormat; // 0x28
	private bool cursorVisible; // 0x30
	private string csrVisible; // 0x38
	private string csrInvisible; // 0x40
	private string clear; // 0x48
	private string bell; // 0x50
	private string term; // 0x58
	private StreamReader stdin; // 0x60
	private CStreamWriter stdout; // 0x68
	private int windowWidth; // 0x70
	private int windowHeight; // 0x74
	private int bufferHeight; // 0x78
	private int bufferWidth; // 0x7C
	private char[] buffer; // 0x80
	private int readpos; // 0x88
	private int writepos; // 0x8C
	private string keypadXmit; // 0x90
	private string keypadLocal; // 0x98
	private bool inited; // 0xA0
	private object initLock; // 0xA8
	private bool initKeys; // 0xB0
	private string origPair; // 0xB8
	private string origColors; // 0xC0
	private string cursorAddress; // 0xC8
	private ConsoleColor fgcolor; // 0xD0
	private string setfgcolor; // 0xD8
	private string setbgcolor; // 0xE0
	private int maxColors; // 0xE8
	private bool noGetPosition; // 0xEC
	private Hashtable keymap; // 0xF0
	private ByteMatcher rootmap; // 0xF8
	private int rl_startx; // 0x100
	private int rl_starty; // 0x104
	private byte[] control_characters; // 0x108
	private static readonly int[] _consoleColorToAnsiCode; // 0x18
	private char[] echobuf; // 0x110
	private int echon; // 0x118

	// Properties
	public bool Initialized { get; }
	public int WindowHeight { get; }
	public int WindowWidth { get; }

	// Methods

	// RVA: 0x1804180 Offset: 0x1803380 VA: 0x181804180
	private static string TryTermInfoDir(string dir, string term) { }

	// RVA: 0x1803CB0 Offset: 0x1802EB0 VA: 0x181803CB0
	private static string SearchTerminfo(string term) { }

	// RVA: 0x18042A0 Offset: 0x18034A0 VA: 0x1818042A0
	private void WriteConsole(string str) { }

	// RVA: 0x1804670 Offset: 0x1803870 VA: 0x181804670
	public void .ctor(string term) { }

	// RVA: 0x1200DC0 Offset: 0x11FFFC0 VA: 0x181200DC0 Slot: 5
	public bool get_Initialized() { }

	// RVA: 0x1802660 Offset: 0x1801860 VA: 0x181802660 Slot: 6
	public void Init() { }

	// RVA: 0x1802410 Offset: 0x1801610 VA: 0x181802410
	private void IncrementX() { }

	// RVA: 0x1804320 Offset: 0x1803520 VA: 0x181804320
	public void WriteSpecialKey(ConsoleKeyInfo key) { }

	// RVA: 0x18042D0 Offset: 0x18034D0 VA: 0x1818042D0
	public void WriteSpecialKey(char c) { }

	// RVA: 0x1803040 Offset: 0x1802240 VA: 0x181803040
	public bool IsSpecialKey(ConsoleKeyInfo key) { }

	// RVA: 0x1802FF0 Offset: 0x18021F0 VA: 0x181802FF0
	public bool IsSpecialKey(char c) { }

	// RVA: 0x1801D10 Offset: 0x1800F10 VA: 0x181801D10
	private void GetCursorPosition() { }

	// RVA: 0x17FF070 Offset: 0x17FE270 VA: 0x1817FF070
	private void CheckWindowDimensions() { }

	// RVA: 0x1804DA0 Offset: 0x1803FA0 VA: 0x181804DA0 Slot: 7
	public int get_WindowHeight() { }

	// RVA: 0x1804DD0 Offset: 0x1803FD0 VA: 0x181804DD0 Slot: 8
	public int get_WindowWidth() { }

	// RVA: 0x17FEF50 Offset: 0x17FE150 VA: 0x1817FEF50
	private void AddToBuffer(int b) { }

	// RVA: 0x17FF050 Offset: 0x17FE250 VA: 0x1817FF050
	private void AdjustBuffer() { }

	// RVA: 0x17FF1D0 Offset: 0x17FE3D0 VA: 0x1817FF1D0
	private ConsoleKeyInfo CreateKeyInfoFromInt(int n, bool alt) { }

	// RVA: 0x1801FF0 Offset: 0x18011F0 VA: 0x181801FF0
	private object GetKeyFromBuffer(bool cooked) { }

	// RVA: 0x1803250 Offset: 0x1802450 VA: 0x181803250
	private ConsoleKeyInfo ReadKeyInternal(out bool fresh) { }

	// RVA: 0x1802FB0 Offset: 0x18021B0 VA: 0x181802FB0
	private bool InputPending() { }

	// RVA: 0x1803160 Offset: 0x1802360 VA: 0x181803160
	private void QueueEcho(char c) { }

	// RVA: 0x1801B80 Offset: 0x1800D80 VA: 0x181801B80
	private void Echo(ConsoleKeyInfo key) { }

	// RVA: 0x1801B30 Offset: 0x1800D30 VA: 0x181801B30
	private void EchoFlush() { }

	// RVA: 0x1803950 Offset: 0x1802B50 VA: 0x181803950
	public int Read([In] [Out] char[] dest, int index, int count) { }

	// RVA: 0x1803620 Offset: 0x1802820 VA: 0x181803620 Slot: 4
	public ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x18036E0 Offset: 0x18028E0 VA: 0x1818036E0 Slot: 9
	public string ReadLine() { }

	// RVA: 0x18036F0 Offset: 0x18028F0 VA: 0x1818036F0
	public string ReadToEnd() { }

	// RVA: 0x1803700 Offset: 0x1802900 VA: 0x181803700
	private string ReadUntilConditionInternal(bool haltOnNewLine) { }

	// RVA: 0x1803E30 Offset: 0x1803030 VA: 0x181803E30 Slot: 10
	public void SetCursorPosition(int left, int top) { }

	// RVA: 0x17FF320 Offset: 0x17FE520 VA: 0x1817FF320
	private void CreateKeyMap() { }

	// RVA: 0x18024A0 Offset: 0x18016A0 VA: 0x1818024A0
	private void InitKeys() { }

	// RVA: 0x17FEDB0 Offset: 0x17FDFB0 VA: 0x1817FEDB0
	private void AddStringMapping(TermInfoStrings s) { }

	// RVA: 0x1804520 Offset: 0x1803720 VA: 0x181804520
	private static void .cctor() { }
}

// Namespace: 
public struct ParameterizedStrings.FormatParam // TypeDefIndex: 3256
{
	// Fields
	private readonly int _int32; // 0x0
	private readonly string _string; // 0x8

	// Properties
	public int Int32 { get; }
	public string String { get; }
	public object Object { get; }

	// Methods

	// RVA: 0x17F6DD0 Offset: 0x17F5FD0 VA: 0x1817F6DD0
	public void .ctor(int value) { }

	// RVA: 0xBB0D00 Offset: 0xBAFF00 VA: 0x180BB0D00
	private void .ctor(int intValue, string stringValue) { }

	// RVA: 0x17F6E80 Offset: 0x17F6080 VA: 0x1817F6E80
	public static ParameterizedStrings.FormatParam op_Implicit(int value) { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public int get_Int32() { }

	// RVA: 0x17F6E30 Offset: 0x17F6030 VA: 0x1817F6E30
	public string get_String() { }

	// RVA: 0x17F6DE0 Offset: 0x17F5FE0 VA: 0x1817F6DE0
	public object get_Object() { }
}

// Namespace: 
private sealed class ParameterizedStrings.LowLevelStack // TypeDefIndex: 3257
{
	// Fields
	private ParameterizedStrings.FormatParam[] _arr; // 0x10
	private int _count; // 0x18

	// Methods

	// RVA: 0x17F73A0 Offset: 0x17F65A0 VA: 0x1817F73A0
	public void .ctor() { }

	// RVA: 0x17F7200 Offset: 0x17F6400 VA: 0x1817F7200
	public ParameterizedStrings.FormatParam Pop() { }

	// RVA: 0x17F72D0 Offset: 0x17F64D0 VA: 0x1817F72D0
	public void Push(ParameterizedStrings.FormatParam item) { }

	// RVA: 0x17F71D0 Offset: 0x17F63D0 VA: 0x1817F71D0
	public void Clear() { }
}

// Namespace: System
internal static class ParameterizedStrings // TypeDefIndex: 3258
{
	// Fields
	[ThreadStatic]
	private static ParameterizedStrings.LowLevelStack _cachedStack; // 0x80000000

	// Methods

	// RVA: 0x17FCD80 Offset: 0x17FBF80 VA: 0x1817FCD80
	public static string Evaluate(string format, ParameterizedStrings.FormatParam[] args) { }

	// RVA: 0x17FC110 Offset: 0x17FB310 VA: 0x1817FC110
	private static string EvaluateInternal(string format, ref int pos, ParameterizedStrings.FormatParam[] args, ParameterizedStrings.LowLevelStack stack, ref ParameterizedStrings.FormatParam[] dynamicVars, ref ParameterizedStrings.FormatParam[] staticVars) { }

	// RVA: 0x1773970 Offset: 0x1772B70 VA: 0x181773970
	private static bool AsBool(int i) { }

	// RVA: 0x17753A0 Offset: 0x17745A0 VA: 0x1817753A0
	private static int AsInt(bool b) { }

	// RVA: 0x17FD310 Offset: 0x17FC510 VA: 0x1817FD310
	private static string StringFromAsciiBytes(byte[] buffer, int offset, int length) { }

	// RVA: 0x17FD3F0 Offset: 0x17FC5F0 VA: 0x1817FD3F0
	private static extern int snprintf(byte* str, IntPtr size, string format, string arg1) { }

	// RVA: 0x17FD4D0 Offset: 0x17FC6D0 VA: 0x1817FD4D0
	private static extern int snprintf(byte* str, IntPtr size, string format, int arg1) { }

	// RVA: 0x17FCF40 Offset: 0x17FC140 VA: 0x1817FCF40
	private static string FormatPrintF(string format, object arg) { }

	// RVA: 0x17FD210 Offset: 0x17FC410 VA: 0x1817FD210
	private static ParameterizedStrings.FormatParam[] GetDynamicOrStaticVariables(char c, ref ParameterizedStrings.FormatParam[] dynamicVars, ref ParameterizedStrings.FormatParam[] staticVars, out int index) { }
}

// Namespace: System
internal class ByteMatcher // TypeDefIndex: 3259
{
	// Fields
	private Hashtable map; // 0x10
	private Hashtable starts; // 0x18

	// Methods

	// RVA: 0x17F02A0 Offset: 0x17EF4A0 VA: 0x1817F02A0
	public void AddMapping(TermInfoStrings key, byte[] val) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void Sort() { }

	// RVA: 0x17F06B0 Offset: 0x17EF8B0 VA: 0x1817F06B0
	public bool StartsWith(int c) { }

	// RVA: 0x17F03D0 Offset: 0x17EF5D0 VA: 0x1817F03D0
	public TermInfoStrings Match(char[] buffer, int offset, int length, out int used) { }

	// RVA: 0x17F0730 Offset: 0x17EF930 VA: 0x1817F0730
	public void .ctor() { }
}

// Namespace: System
internal enum TermInfoNumbers // TypeDefIndex: 3260
{
	// Fields
	public int value__; // 0x0
	public const TermInfoNumbers Columns = 0;
	public const TermInfoNumbers InitTabs = 1;
	public const TermInfoNumbers Lines = 2;
	public const TermInfoNumbers LinesOfMemory = 3;
	public const TermInfoNumbers MagicCookieGlitch = 4;
	public const TermInfoNumbers PaddingBaudRate = 5;
	public const TermInfoNumbers VirtualTerminal = 6;
	public const TermInfoNumbers WidthStatusLine = 7;
	public const TermInfoNumbers NumLabels = 8;
	public const TermInfoNumbers LabelHeight = 9;
	public const TermInfoNumbers LabelWidth = 10;
	public const TermInfoNumbers MaxAttributes = 11;
	public const TermInfoNumbers MaximumWindows = 12;
	public const TermInfoNumbers MaxColors = 13;
	public const TermInfoNumbers MaxPairs = 14;
	public const TermInfoNumbers NoColorVideo = 15;
	public const TermInfoNumbers BufferCapacity = 16;
	public const TermInfoNumbers DotVertSpacing = 17;
	public const TermInfoNumbers DotHorzSpacing = 18;
	public const TermInfoNumbers MaxMicroAddress = 19;
	public const TermInfoNumbers MaxMicroJump = 20;
	public const TermInfoNumbers MicroColSize = 21;
	public const TermInfoNumbers MicroLineSize = 22;
	public const TermInfoNumbers NumberOfPins = 23;
	public const TermInfoNumbers OutputResChar = 24;
	public const TermInfoNumbers OutputResLine = 25;
	public const TermInfoNumbers OutputResHorzInch = 26;
	public const TermInfoNumbers OutputResVertInch = 27;
	public const TermInfoNumbers PrintRate = 28;
	public const TermInfoNumbers WideCharSize = 29;
	public const TermInfoNumbers Buttons = 30;
	public const TermInfoNumbers BitImageEntwining = 31;
	public const TermInfoNumbers BitImageType = 32;
	public const TermInfoNumbers Last = 33;
}

// Namespace: System
internal class TermInfoReader // TypeDefIndex: 3261
{
	// Fields
	private int boolSize; // 0x10
	private int numSize; // 0x14
	private int strOffsets; // 0x18
	private byte[] buffer; // 0x20
	private int booleansOffset; // 0x28
	private int intOffset; // 0x2C

	// Methods

	// RVA: 0x18057B0 Offset: 0x18049B0 VA: 0x1818057B0
	public void .ctor(string term, string filename) { }

	// RVA: 0x1805720 Offset: 0x1804920 VA: 0x181805720
	public void .ctor(string term, byte[] buffer) { }

	// RVA: 0x1804E00 Offset: 0x1804000 VA: 0x181804E00
	private void DetermineVersion(short magic) { }

	// RVA: 0x1805410 Offset: 0x1804610 VA: 0x181805410
	private void ReadHeader(byte[] buffer, ref int position) { }

	// RVA: 0x1805670 Offset: 0x1804870 VA: 0x181805670
	private void ReadNames(byte[] buffer, ref int position) { }

	// RVA: 0x1805350 Offset: 0x1804550 VA: 0x181805350
	public int Get(TermInfoNumbers number) { }

	// RVA: 0x18051F0 Offset: 0x18043F0 VA: 0x1818051F0
	public string Get(TermInfoStrings tstr) { }

	// RVA: 0x1804FE0 Offset: 0x18041E0 VA: 0x181804FE0
	public byte[] GetStringBytes(TermInfoStrings tstr) { }

	// RVA: 0x1804EC0 Offset: 0x18040C0 VA: 0x181804EC0
	private short GetInt16(byte[] buffer, int offset) { }

	// RVA: 0x1805150 Offset: 0x1804350 VA: 0x181805150
	private string GetString(byte[] buffer, int offset) { }

	// RVA: 0x1804F20 Offset: 0x1804120 VA: 0x181804F20
	private byte[] GetStringBytes(byte[] buffer, int offset) { }
}

// Namespace: System
internal enum TermInfoStrings // TypeDefIndex: 3262
{
	// Fields
	public int value__; // 0x0
	public const TermInfoStrings BackTab = 0;
	public const TermInfoStrings Bell = 1;
	public const TermInfoStrings CarriageReturn = 2;
	public const TermInfoStrings ChangeScrollRegion = 3;
	public const TermInfoStrings ClearAllTabs = 4;
	public const TermInfoStrings ClearScreen = 5;
	public const TermInfoStrings ClrEol = 6;
	public const TermInfoStrings ClrEos = 7;
	public const TermInfoStrings ColumnAddress = 8;
	public const TermInfoStrings CommandCharacter = 9;
	public const TermInfoStrings CursorAddress = 10;
	public const TermInfoStrings CursorDown = 11;
	public const TermInfoStrings CursorHome = 12;
	public const TermInfoStrings CursorInvisible = 13;
	public const TermInfoStrings CursorLeft = 14;
	public const TermInfoStrings CursorMemAddress = 15;
	public const TermInfoStrings CursorNormal = 16;
	public const TermInfoStrings CursorRight = 17;
	public const TermInfoStrings CursorToLl = 18;
	public const TermInfoStrings CursorUp = 19;
	public const TermInfoStrings CursorVisible = 20;
	public const TermInfoStrings DeleteCharacter = 21;
	public const TermInfoStrings DeleteLine = 22;
	public const TermInfoStrings DisStatusLine = 23;
	public const TermInfoStrings DownHalfLine = 24;
	public const TermInfoStrings EnterAltCharsetMode = 25;
	public const TermInfoStrings EnterBlinkMode = 26;
	public const TermInfoStrings EnterBoldMode = 27;
	public const TermInfoStrings EnterCaMode = 28;
	public const TermInfoStrings EnterDeleteMode = 29;
	public const TermInfoStrings EnterDimMode = 30;
	public const TermInfoStrings EnterInsertMode = 31;
	public const TermInfoStrings EnterSecureMode = 32;
	public const TermInfoStrings EnterProtectedMode = 33;
	public const TermInfoStrings EnterReverseMode = 34;
	public const TermInfoStrings EnterStandoutMode = 35;
	public const TermInfoStrings EnterUnderlineMode = 36;
	public const TermInfoStrings EraseChars = 37;
	public const TermInfoStrings ExitAltCharsetMode = 38;
	public const TermInfoStrings ExitAttributeMode = 39;
	public const TermInfoStrings ExitCaMode = 40;
	public const TermInfoStrings ExitDeleteMode = 41;
	public const TermInfoStrings ExitInsertMode = 42;
	public const TermInfoStrings ExitStandoutMode = 43;
	public const TermInfoStrings ExitUnderlineMode = 44;
	public const TermInfoStrings FlashScreen = 45;
	public const TermInfoStrings FormFeed = 46;
	public const TermInfoStrings FromStatusLine = 47;
	public const TermInfoStrings Init1string = 48;
	public const TermInfoStrings Init2string = 49;
	public const TermInfoStrings Init3string = 50;
	public const TermInfoStrings InitFile = 51;
	public const TermInfoStrings InsertCharacter = 52;
	public const TermInfoStrings InsertLine = 53;
	public const TermInfoStrings InsertPadding = 54;
	public const TermInfoStrings KeyBackspace = 55;
	public const TermInfoStrings KeyCatab = 56;
	public const TermInfoStrings KeyClear = 57;
	public const TermInfoStrings KeyCtab = 58;
	public const TermInfoStrings KeyDc = 59;
	public const TermInfoStrings KeyDl = 60;
	public const TermInfoStrings KeyDown = 61;
	public const TermInfoStrings KeyEic = 62;
	public const TermInfoStrings KeyEol = 63;
	public const TermInfoStrings KeyEos = 64;
	public const TermInfoStrings KeyF0 = 65;
	public const TermInfoStrings KeyF1 = 66;
	public const TermInfoStrings KeyF10 = 67;
	public const TermInfoStrings KeyF2 = 68;
	public const TermInfoStrings KeyF3 = 69;
	public const TermInfoStrings KeyF4 = 70;
	public const TermInfoStrings KeyF5 = 71;
	public const TermInfoStrings KeyF6 = 72;
	public const TermInfoStrings KeyF7 = 73;
	public const TermInfoStrings KeyF8 = 74;
	public const TermInfoStrings KeyF9 = 75;
	public const TermInfoStrings KeyHome = 76;
	public const TermInfoStrings KeyIc = 77;
	public const TermInfoStrings KeyIl = 78;
	public const TermInfoStrings KeyLeft = 79;
	public const TermInfoStrings KeyLl = 80;
	public const TermInfoStrings KeyNpage = 81;
	public const TermInfoStrings KeyPpage = 82;
	public const TermInfoStrings KeyRight = 83;
	public const TermInfoStrings KeySf = 84;
	public const TermInfoStrings KeySr = 85;
	public const TermInfoStrings KeyStab = 86;
	public const TermInfoStrings KeyUp = 87;
	public const TermInfoStrings KeypadLocal = 88;
	public const TermInfoStrings KeypadXmit = 89;
	public const TermInfoStrings LabF0 = 90;
	public const TermInfoStrings LabF1 = 91;
	public const TermInfoStrings LabF10 = 92;
	public const TermInfoStrings LabF2 = 93;
	public const TermInfoStrings LabF3 = 94;
	public const TermInfoStrings LabF4 = 95;
	public const TermInfoStrings LabF5 = 96;
	public const TermInfoStrings LabF6 = 97;
	public const TermInfoStrings LabF7 = 98;
	public const TermInfoStrings LabF8 = 99;
	public const TermInfoStrings LabF9 = 100;
	public const TermInfoStrings MetaOff = 101;
	public const TermInfoStrings MetaOn = 102;
	public const TermInfoStrings Newline = 103;
	public const TermInfoStrings PadChar = 104;
	public const TermInfoStrings ParmDch = 105;
	public const TermInfoStrings ParmDeleteLine = 106;
	public const TermInfoStrings ParmDownCursor = 107;
	public const TermInfoStrings ParmIch = 108;
	public const TermInfoStrings ParmIndex = 109;
	public const TermInfoStrings ParmInsertLine = 110;
	public const TermInfoStrings ParmLeftCursor = 111;
	public const TermInfoStrings ParmRightCursor = 112;
	public const TermInfoStrings ParmRindex = 113;
	public const TermInfoStrings ParmUpCursor = 114;
	public const TermInfoStrings PkeyKey = 115;
	public const TermInfoStrings PkeyLocal = 116;
	public const TermInfoStrings PkeyXmit = 117;
	public const TermInfoStrings PrintScreen = 118;
	public const TermInfoStrings PrtrOff = 119;
	public const TermInfoStrings PrtrOn = 120;
	public const TermInfoStrings RepeatChar = 121;
	public const TermInfoStrings Reset1string = 122;
	public const TermInfoStrings Reset2string = 123;
	public const TermInfoStrings Reset3string = 124;
	public const TermInfoStrings ResetFile = 125;
	public const TermInfoStrings RestoreCursor = 126;
	public const TermInfoStrings RowAddress = 127;
	public const TermInfoStrings SaveCursor = 128;
	public const TermInfoStrings ScrollForward = 129;
	public const TermInfoStrings ScrollReverse = 130;
	public const TermInfoStrings SetAttributes = 131;
	public const TermInfoStrings SetTab = 132;
	public const TermInfoStrings SetWindow = 133;
	public const TermInfoStrings Tab = 134;
	public const TermInfoStrings ToStatusLine = 135;
	public const TermInfoStrings UnderlineChar = 136;
	public const TermInfoStrings UpHalfLine = 137;
	public const TermInfoStrings InitProg = 138;
	public const TermInfoStrings KeyA1 = 139;
	public const TermInfoStrings KeyA3 = 140;
	public const TermInfoStrings KeyB2 = 141;
	public const TermInfoStrings KeyC1 = 142;
	public const TermInfoStrings KeyC3 = 143;
	public const TermInfoStrings PrtrNon = 144;
	public const TermInfoStrings CharPadding = 145;
	public const TermInfoStrings AcsChars = 146;
	public const TermInfoStrings PlabNorm = 147;
	public const TermInfoStrings KeyBtab = 148;
	public const TermInfoStrings EnterXonMode = 149;
	public const TermInfoStrings ExitXonMode = 150;
	public const TermInfoStrings EnterAmMode = 151;
	public const TermInfoStrings ExitAmMode = 152;
	public const TermInfoStrings XonCharacter = 153;
	public const TermInfoStrings XoffCharacter = 154;
	public const TermInfoStrings EnaAcs = 155;
	public const TermInfoStrings LabelOn = 156;
	public const TermInfoStrings LabelOff = 157;
	public const TermInfoStrings KeyBeg = 158;
	public const TermInfoStrings KeyCancel = 159;
	public const TermInfoStrings KeyClose = 160;
	public const TermInfoStrings KeyCommand = 161;
	public const TermInfoStrings KeyCopy = 162;
	public const TermInfoStrings KeyCreate = 163;
	public const TermInfoStrings KeyEnd = 164;
	public const TermInfoStrings KeyEnter = 165;
	public const TermInfoStrings KeyExit = 166;
	public const TermInfoStrings KeyFind = 167;
	public const TermInfoStrings KeyHelp = 168;
	public const TermInfoStrings KeyMark = 169;
	public const TermInfoStrings KeyMessage = 170;
	public const TermInfoStrings KeyMove = 171;
	public const TermInfoStrings KeyNext = 172;
	public const TermInfoStrings KeyOpen = 173;
	public const TermInfoStrings KeyOptions = 174;
	public const TermInfoStrings KeyPrevious = 175;
	public const TermInfoStrings KeyPrint = 176;
	public const TermInfoStrings KeyRedo = 177;
	public const TermInfoStrings KeyReference = 178;
	public const TermInfoStrings KeyRefresh = 179;
	public const TermInfoStrings KeyReplace = 180;
	public const TermInfoStrings KeyRestart = 181;
	public const TermInfoStrings KeyResume = 182;
	public const TermInfoStrings KeySave = 183;
	public const TermInfoStrings KeySuspend = 184;
	public const TermInfoStrings KeyUndo = 185;
	public const TermInfoStrings KeySbeg = 186;
	public const TermInfoStrings KeyScancel = 187;
	public const TermInfoStrings KeyScommand = 188;
	public const TermInfoStrings KeyScopy = 189;
	public const TermInfoStrings KeyScreate = 190;
	public const TermInfoStrings KeySdc = 191;
	public const TermInfoStrings KeySdl = 192;
	public const TermInfoStrings KeySelect = 193;
	public const TermInfoStrings KeySend = 194;
	public const TermInfoStrings KeySeol = 195;
	public const TermInfoStrings KeySexit = 196;
	public const TermInfoStrings KeySfind = 197;
	public const TermInfoStrings KeyShelp = 198;
	public const TermInfoStrings KeyShome = 199;
	public const TermInfoStrings KeySic = 200;
	public const TermInfoStrings KeySleft = 201;
	public const TermInfoStrings KeySmessage = 202;
	public const TermInfoStrings KeySmove = 203;
	public const TermInfoStrings KeySnext = 204;
	public const TermInfoStrings KeySoptions = 205;
	public const TermInfoStrings KeySprevious = 206;
	public const TermInfoStrings KeySprint = 207;
	public const TermInfoStrings KeySredo = 208;
	public const TermInfoStrings KeySreplace = 209;
	public const TermInfoStrings KeySright = 210;
	public const TermInfoStrings KeySrsume = 211;
	public const TermInfoStrings KeySsave = 212;
	public const TermInfoStrings KeySsuspend = 213;
	public const TermInfoStrings KeySundo = 214;
	public const TermInfoStrings ReqForInput = 215;
	public const TermInfoStrings KeyF11 = 216;
	public const TermInfoStrings KeyF12 = 217;
	public const TermInfoStrings KeyF13 = 218;
	public const TermInfoStrings KeyF14 = 219;
	public const TermInfoStrings KeyF15 = 220;
	public const TermInfoStrings KeyF16 = 221;
	public const TermInfoStrings KeyF17 = 222;
	public const TermInfoStrings KeyF18 = 223;
	public const TermInfoStrings KeyF19 = 224;
	public const TermInfoStrings KeyF20 = 225;
	public const TermInfoStrings KeyF21 = 226;
	public const TermInfoStrings KeyF22 = 227;
	public const TermInfoStrings KeyF23 = 228;
	public const TermInfoStrings KeyF24 = 229;
	public const TermInfoStrings KeyF25 = 230;
	public const TermInfoStrings KeyF26 = 231;
	public const TermInfoStrings KeyF27 = 232;
	public const TermInfoStrings KeyF28 = 233;
	public const TermInfoStrings KeyF29 = 234;
	public const TermInfoStrings KeyF30 = 235;
	public const TermInfoStrings KeyF31 = 236;
	public const TermInfoStrings KeyF32 = 237;
	public const TermInfoStrings KeyF33 = 238;
	public const TermInfoStrings KeyF34 = 239;
	public const TermInfoStrings KeyF35 = 240;
	public const TermInfoStrings KeyF36 = 241;
	public const TermInfoStrings KeyF37 = 242;
	public const TermInfoStrings KeyF38 = 243;
	public const TermInfoStrings KeyF39 = 244;
	public const TermInfoStrings KeyF40 = 245;
	public const TermInfoStrings KeyF41 = 246;
	public const TermInfoStrings KeyF42 = 247;
	public const TermInfoStrings KeyF43 = 248;
	public const TermInfoStrings KeyF44 = 249;
	public const TermInfoStrings KeyF45 = 250;
	public const TermInfoStrings KeyF46 = 251;
	public const TermInfoStrings KeyF47 = 252;
	public const TermInfoStrings KeyF48 = 253;
	public const TermInfoStrings KeyF49 = 254;
	public const TermInfoStrings KeyF50 = 255;
	public const TermInfoStrings KeyF51 = 256;
	public const TermInfoStrings KeyF52 = 257;
	public const TermInfoStrings KeyF53 = 258;
	public const TermInfoStrings KeyF54 = 259;
	public const TermInfoStrings KeyF55 = 260;
	public const TermInfoStrings KeyF56 = 261;
	public const TermInfoStrings KeyF57 = 262;
	public const TermInfoStrings KeyF58 = 263;
	public const TermInfoStrings KeyF59 = 264;
	public const TermInfoStrings KeyF60 = 265;
	public const TermInfoStrings KeyF61 = 266;
	public const TermInfoStrings KeyF62 = 267;
	public const TermInfoStrings KeyF63 = 268;
	public const TermInfoStrings ClrBol = 269;
	public const TermInfoStrings ClearMargins = 270;
	public const TermInfoStrings SetLeftMargin = 271;
	public const TermInfoStrings SetRightMargin = 272;
	public const TermInfoStrings LabelFormat = 273;
	public const TermInfoStrings SetClock = 274;
	public const TermInfoStrings DisplayClock = 275;
	public const TermInfoStrings RemoveClock = 276;
	public const TermInfoStrings CreateWindow = 277;
	public const TermInfoStrings GotoWindow = 278;
	public const TermInfoStrings Hangup = 279;
	public const TermInfoStrings DialPhone = 280;
	public const TermInfoStrings QuickDial = 281;
	public const TermInfoStrings Tone = 282;
	public const TermInfoStrings Pulse = 283;
	public const TermInfoStrings FlashHook = 284;
	public const TermInfoStrings FixedPause = 285;
	public const TermInfoStrings WaitTone = 286;
	public const TermInfoStrings User0 = 287;
	public const TermInfoStrings User1 = 288;
	public const TermInfoStrings User2 = 289;
	public const TermInfoStrings User3 = 290;
	public const TermInfoStrings User4 = 291;
	public const TermInfoStrings User5 = 292;
	public const TermInfoStrings User6 = 293;
	public const TermInfoStrings User7 = 294;
	public const TermInfoStrings User8 = 295;
	public const TermInfoStrings User9 = 296;
	public const TermInfoStrings OrigPair = 297;
	public const TermInfoStrings OrigColors = 298;
	public const TermInfoStrings InitializeColor = 299;
	public const TermInfoStrings InitializePair = 300;
	public const TermInfoStrings SetColorPair = 301;
	public const TermInfoStrings SetForeground = 302;
	public const TermInfoStrings SetBackground = 303;
	public const TermInfoStrings ChangeCharPitch = 304;
	public const TermInfoStrings ChangeLinePitch = 305;
	public const TermInfoStrings ChangeResHorz = 306;
	public const TermInfoStrings ChangeResVert = 307;
	public const TermInfoStrings DefineChar = 308;
	public const TermInfoStrings EnterDoublewideMode = 309;
	public const TermInfoStrings EnterDraftQuality = 310;
	public const TermInfoStrings EnterItalicsMode = 311;
	public const TermInfoStrings EnterLeftwardMode = 312;
	public const TermInfoStrings EnterMicroMode = 313;
	public const TermInfoStrings EnterNearLetterQuality = 314;
	public const TermInfoStrings EnterNormalQuality = 315;
	public const TermInfoStrings EnterShadowMode = 316;
	public const TermInfoStrings EnterSubscriptMode = 317;
	public const TermInfoStrings EnterSuperscriptMode = 318;
	public const TermInfoStrings EnterUpwardMode = 319;
	public const TermInfoStrings ExitDoublewideMode = 320;
	public const TermInfoStrings ExitItalicsMode = 321;
	public const TermInfoStrings ExitLeftwardMode = 322;
	public const TermInfoStrings ExitMicroMode = 323;
	public const TermInfoStrings ExitShadowMode = 324;
	public const TermInfoStrings ExitSubscriptMode = 325;
	public const TermInfoStrings ExitSuperscriptMode = 326;
	public const TermInfoStrings ExitUpwardMode = 327;
	public const TermInfoStrings MicroColumnAddress = 328;
	public const TermInfoStrings MicroDown = 329;
	public const TermInfoStrings MicroLeft = 330;
	public const TermInfoStrings MicroRight = 331;
	public const TermInfoStrings MicroRowAddress = 332;
	public const TermInfoStrings MicroUp = 333;
	public const TermInfoStrings OrderOfPins = 334;
	public const TermInfoStrings ParmDownMicro = 335;
	public const TermInfoStrings ParmLeftMicro = 336;
	public const TermInfoStrings ParmRightMicro = 337;
	public const TermInfoStrings ParmUpMicro = 338;
	public const TermInfoStrings SelectCharSet = 339;
	public const TermInfoStrings SetBottomMargin = 340;
	public const TermInfoStrings SetBottomMarginParm = 341;
	public const TermInfoStrings SetLeftMarginParm = 342;
	public const TermInfoStrings SetRightMarginParm = 343;
	public const TermInfoStrings SetTopMargin = 344;
	public const TermInfoStrings SetTopMarginParm = 345;
	public const TermInfoStrings StartBitImage = 346;
	public const TermInfoStrings StartCharSetDef = 347;
	public const TermInfoStrings StopBitImage = 348;
	public const TermInfoStrings StopCharSetDef = 349;
	public const TermInfoStrings SubscriptCharacters = 350;
	public const TermInfoStrings SuperscriptCharacters = 351;
	public const TermInfoStrings TheseCauseCr = 352;
	public const TermInfoStrings ZeroMotion = 353;
	public const TermInfoStrings CharSetNames = 354;
	public const TermInfoStrings KeyMouse = 355;
	public const TermInfoStrings MouseInfo = 356;
	public const TermInfoStrings ReqMousePos = 357;
	public const TermInfoStrings GetMouse = 358;
	public const TermInfoStrings SetAForeground = 359;
	public const TermInfoStrings SetABackground = 360;
	public const TermInfoStrings PkeyPlab = 361;
	public const TermInfoStrings DeviceType = 362;
	public const TermInfoStrings CodeSetInit = 363;
	public const TermInfoStrings Set0DesSeq = 364;
	public const TermInfoStrings Set1DesSeq = 365;
	public const TermInfoStrings Set2DesSeq = 366;
	public const TermInfoStrings Set3DesSeq = 367;
	public const TermInfoStrings SetLrMargin = 368;
	public const TermInfoStrings SetTbMargin = 369;
	public const TermInfoStrings BitImageRepeat = 370;
	public const TermInfoStrings BitImageNewline = 371;
	public const TermInfoStrings BitImageCarriageReturn = 372;
	public const TermInfoStrings ColorNames = 373;
	public const TermInfoStrings DefineBitImageRegion = 374;
	public const TermInfoStrings EndBitImageRegion = 375;
	public const TermInfoStrings SetColorBand = 376;
	public const TermInfoStrings SetPageLength = 377;
	public const TermInfoStrings DisplayPcChar = 378;
	public const TermInfoStrings EnterPcCharsetMode = 379;
	public const TermInfoStrings ExitPcCharsetMode = 380;
	public const TermInfoStrings EnterScancodeMode = 381;
	public const TermInfoStrings ExitScancodeMode = 382;
	public const TermInfoStrings PcTermOptions = 383;
	public const TermInfoStrings ScancodeEscape = 384;
	public const TermInfoStrings AltScancodeEsc = 385;
	public const TermInfoStrings EnterHorizontalHlMode = 386;
	public const TermInfoStrings EnterLeftHlMode = 387;
	public const TermInfoStrings EnterLowHlMode = 388;
	public const TermInfoStrings EnterRightHlMode = 389;
	public const TermInfoStrings EnterTopHlMode = 390;
	public const TermInfoStrings EnterVerticalHlMode = 391;
	public const TermInfoStrings SetAAttributes = 392;
	public const TermInfoStrings SetPglenInch = 393;
	public const TermInfoStrings Last = 394;
}

// Namespace: System
internal interface TypeName : IEquatable<TypeName> // TypeDefIndex: 3263
{
	// Properties
	public abstract string DisplayName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_DisplayName();
}

// Namespace: System
internal interface TypeIdentifier : TypeName, IEquatable<TypeName> // TypeDefIndex: 3264
{
	// Properties
	public abstract string InternalName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_InternalName();
}

// Namespace: 
internal abstract class TypeNames.ATypeName : TypeName, IEquatable<TypeName> // TypeDefIndex: 3265
{
	// Properties
	public abstract string DisplayName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_DisplayName();

	// RVA: 0x1808510 Offset: 0x1807710 VA: 0x181808510 Slot: 5
	public bool Equals(TypeName other) { }

	// RVA: 0x1808650 Offset: 0x1807850 VA: 0x181808650 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1808590 Offset: 0x1807790 VA: 0x181808590 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System
internal class TypeNames // TypeDefIndex: 3266
{}

// Namespace: 
private class TypeIdentifiers.Display : TypeNames.ATypeName, TypeIdentifier, TypeName, IEquatable<TypeName> // TypeDefIndex: 3267
{
	// Fields
	private string displayName; // 0x10
	private string internal_name; // 0x18

	// Properties
	public override string DisplayName { get; }
	public string InternalName { get; }

	// Methods

	// RVA: 0x1812F50 Offset: 0x1812150 VA: 0x181812F50
	internal void .ctor(string displayName) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 6
	public override string get_DisplayName() { }

	// RVA: 0x1812F80 Offset: 0x1812180 VA: 0x181812F80 Slot: 7
	public string get_InternalName() { }

	// RVA: 0x1812E70 Offset: 0x1812070 VA: 0x181812E70
	private string GetInternalName() { }
}

// Namespace: System
internal class TypeIdentifiers // TypeDefIndex: 3268
{
	// Methods

	// RVA: 0x181B4B0 Offset: 0x181A6B0 VA: 0x18181B4B0
	internal static TypeIdentifier FromDisplay(string displayName) { }
}

// Namespace: System
internal interface ModifierSpec // TypeDefIndex: 3269
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Type Resolve(Type type);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract StringBuilder Append(StringBuilder sb);
}

// Namespace: System
internal class ArraySpec : ModifierSpec // TypeDefIndex: 3270
{
	// Fields
	private int dimensions; // 0x10
	private bool bound; // 0x14

	// Methods

	// RVA: 0x1808A50 Offset: 0x1807C50 VA: 0x181808A50
	internal void .ctor(int dimensions, bool bound) { }

	// RVA: 0x18088D0 Offset: 0x1807AD0 VA: 0x1818088D0 Slot: 4
	public Type Resolve(Type type) { }

	// RVA: 0x1808830 Offset: 0x1807A30 VA: 0x181808830 Slot: 5
	public StringBuilder Append(StringBuilder sb) { }

	// RVA: 0x1808960 Offset: 0x1807B60 VA: 0x181808960 Slot: 3
	public override string ToString() { }
}

// Namespace: System
internal class PointerSpec : ModifierSpec // TypeDefIndex: 3271
{
	// Fields
	private int pointer_level; // 0x10

	// Methods

	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	internal void .ctor(int pointer_level) { }

	// RVA: 0x1817D40 Offset: 0x1816F40 VA: 0x181817D40 Slot: 4
	public Type Resolve(Type type) { }

	// RVA: 0x1817D10 Offset: 0x1816F10 VA: 0x181817D10 Slot: 5
	public StringBuilder Append(StringBuilder sb) { }

	// RVA: 0x1817D90 Offset: 0x1816F90 VA: 0x181817D90 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[Flags]
internal enum TypeSpec.DisplayNameFormat // TypeDefIndex: 3272
{
	// Fields
	public int value__; // 0x0
	public const TypeSpec.DisplayNameFormat Default = 0;
	public const TypeSpec.DisplayNameFormat WANT_ASSEMBLY = 1;
	public const TypeSpec.DisplayNameFormat NO_MODIFIERS = 2;
}

// Namespace: System
internal class TypeSpec // TypeDefIndex: 3273
{
	// Fields
	private TypeIdentifier name; // 0x10
	private string assembly_name; // 0x18
	private List<TypeIdentifier> nested; // 0x20
	private List<TypeSpec> generic_params; // 0x28
	private List<ModifierSpec> modifier_spec; // 0x30
	private bool is_byref; // 0x38
	private string display_fullname; // 0x40

	// Properties
	internal bool HasModifiers { get; }
	internal string DisplayFullName { get; }

	// Methods

	// RVA: 0x1656350 Offset: 0x1655550 VA: 0x181656350
	internal bool get_HasModifiers() { }

	// RVA: 0x181B830 Offset: 0x181AA30 VA: 0x18181B830
	private string GetDisplayFullName(TypeSpec.DisplayNameFormat flags) { }

	// RVA: 0x181BCE0 Offset: 0x181AEE0 VA: 0x18181BCE0
	private StringBuilder GetModifierString(StringBuilder sb) { }

	// RVA: 0x181D9E0 Offset: 0x181CBE0 VA: 0x18181D9E0
	internal string get_DisplayFullName() { }

	// RVA: 0x181CE40 Offset: 0x181C040 VA: 0x18181CE40
	internal static TypeSpec Parse(string typeName) { }

	// RVA: 0x181D900 Offset: 0x181CB00 VA: 0x18181D900
	internal static string UnescapeInternalName(string displayName) { }

	// RVA: 0x181CF30 Offset: 0x181C130 VA: 0x18181CF30
	internal Type Resolve(Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase, ref StackCrawlMark stackMark) { }

	// RVA: 0x181B600 Offset: 0x181A800 VA: 0x18181B600
	private void AddName(string type_name) { }

	// RVA: 0x181B510 Offset: 0x181A710 VA: 0x18181B510
	private void AddModifier(ModifierSpec md) { }

	// RVA: 0x181D860 Offset: 0x181CA60 VA: 0x18181D860
	private static void SkipSpace(string name, ref int pos) { }

	// RVA: 0x181B7A0 Offset: 0x181A9A0 VA: 0x18181B7A0
	private static void BoundCheck(int idx, string s) { }

	// RVA: 0x181B4B0 Offset: 0x181A6B0 VA: 0x18181B4B0
	private static TypeIdentifier ParsedTypeIdentifier(string displayName) { }

	// RVA: 0x181BEE0 Offset: 0x181B0E0 VA: 0x18181BEE0
	private static TypeSpec Parse(string name, ref int p, bool is_recurse, bool allow_aqn) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System
[CLSCompliant(False)]
[IsReadOnly]
[ComVisible(True)]
[Serializable]
public struct UIntPtr : ISerializable, IEquatable<UIntPtr> // TypeDefIndex: 3274
{
	// Fields
	public static readonly UIntPtr Zero; // 0x0
	private readonly void* _pointer; // 0x0

	// Properties
	public static int Size { get; }

	// Methods

	// RVA: 0x181E760 Offset: 0x181D960 VA: 0x18181E760
	public void .ctor(ulong value) { }

	// RVA: 0x181E750 Offset: 0x181D950 VA: 0x18181E750
	public void .ctor(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void .ctor(void* value) { }

	// RVA: 0x181E5C0 Offset: 0x181D7C0 VA: 0x18181E5C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint ToUInt32() { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ulong ToUInt64() { }

	[CLSCompliant(False)]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public void* ToPointer() { }

	// RVA: 0x181E6F0 Offset: 0x181D8F0 VA: 0x18181E6F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x181E650 Offset: 0x181D850 VA: 0x18181E650 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAA0BD0 Offset: 0xA9FDD0 VA: 0x180AA0BD0
	public static bool op_Equality(UIntPtr value1, UIntPtr value2) { }

	// RVA: 0x17C3590 Offset: 0x17C2790 VA: 0x1817C3590
	public static bool op_Inequality(UIntPtr value1, UIntPtr value2) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	public static ulong op_Explicit(UIntPtr value) { }

	// RVA: 0x937660 Offset: 0x936860 VA: 0x180937660
	public static uint op_Explicit(UIntPtr value) { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public static UIntPtr op_Explicit(ulong value) { }

	[CLSCompliant(False)]
	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	public static UIntPtr op_Explicit(void* value) { }

	[CLSCompliant(False)]
	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	public static void* op_Explicit(UIntPtr value) { }

	// RVA: 0x937660 Offset: 0x936860 VA: 0x180937660
	public static UIntPtr op_Explicit(uint value) { }

	// RVA: 0xAA00E0 Offset: 0xA9F2E0 VA: 0x180AA00E0
	public static int get_Size() { }

	// RVA: 0x17F70A0 Offset: 0x17F62A0 VA: 0x1817F70A0
	public static UIntPtr op_Subtraction(UIntPtr pointer, int offset) { }

	// RVA: 0x126BA20 Offset: 0x126AC20 VA: 0x18126BA20 Slot: 5
	private bool System.IEquatable<System.UIntPtr>.Equals(UIntPtr other) { }

	// RVA: 0x181E710 Offset: 0x181D910 VA: 0x18181E710
	private static void .cctor() { }
}

// Namespace: System
[ComVisible(True)]
[Serializable]
public abstract class ValueType // TypeDefIndex: 3275
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x181EA00 Offset: 0x181DC00 VA: 0x18181EA00
	private static bool InternalEquals(object o1, object o2, out object[] fields) { }

	// RVA: 0x181E770 Offset: 0x181D970 VA: 0x18181E770
	internal static bool DefaultEquals(object o1, object o2) { }

	// RVA: 0x17DA090 Offset: 0x17D9290 VA: 0x1817DA090 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x181EA10 Offset: 0x181DC10 VA: 0x18181EA10
	internal static int InternalGetHashCode(object o, out object[] fields) { }

	// RVA: 0x181E970 Offset: 0x181DB70 VA: 0x18181E970 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x181EA20 Offset: 0x181DC20 VA: 0x18181EA20 Slot: 3
	public override string ToString() { }
}

// Namespace: System
internal struct Variant // TypeDefIndex: 3276
{
	// Fields
	public short vt; // 0x0
	public ushort wReserved1; // 0x2
	public ushort wReserved2; // 0x4
	public ushort wReserved3; // 0x6
	public long llVal; // 0x8
	public int lVal; // 0x8
	public byte bVal; // 0x8
	public short iVal; // 0x8
	public float fltVal; // 0x8
	public double dblVal; // 0x8
	public short boolVal; // 0x8
	public IntPtr bstrVal; // 0x8
	public sbyte cVal; // 0x8
	public ushort uiVal; // 0x8
	public uint ulVal; // 0x8
	public ulong ullVal; // 0x8
	public int intVal; // 0x8
	public uint uintVal; // 0x8
	public IntPtr pdispVal; // 0x8
	public BRECORD bRecord; // 0x8

	// Methods

	// RVA: 0x181EA60 Offset: 0x181DC60 VA: 0x18181EA60
	public void Clear() { }
}

// Namespace: System
internal struct BRECORD // TypeDefIndex: 3277
{
	// Fields
	private IntPtr pvRecord; // 0x0
	private IntPtr pRecInfo; // 0x8
}

// Namespace: System
[ComVisible(True)]
[Serializable]
public class WeakReference : ISerializable // TypeDefIndex: 3278
{
	// Fields
	private bool isLongReference; // 0x10
	private GCHandle gcHandle; // 0x18

	// Properties
	public virtual bool IsAlive { get; }
	public virtual object Target { get; set; }
	public virtual bool TrackResurrection { get; }

	// Methods

	// RVA: 0x181EB70 Offset: 0x181DD70 VA: 0x18181EB70
	private void AllocateHandle(object target) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x181ED20 Offset: 0x181DF20 VA: 0x18181ED20
	public void .ctor(object target) { }

	// RVA: 0x181ED60 Offset: 0x181DF60 VA: 0x18181ED60
	public void .ctor(object target, bool trackResurrection) { }

	// RVA: 0x181EDB0 Offset: 0x181DFB0 VA: 0x18181EDB0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x181EEE0 Offset: 0x181E0E0 VA: 0x18181EEE0 Slot: 5
	public virtual bool get_IsAlive() { }

	// RVA: 0x181EF10 Offset: 0x181E110 VA: 0x18181EF10 Slot: 6
	public virtual object get_Target() { }

	// RVA: 0x181EF40 Offset: 0x181E140 VA: 0x18181EF40 Slot: 7
	public virtual void set_Target(object value) { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0 Slot: 8
	public virtual bool get_TrackResurrection() { }

	// RVA: 0x181EBA0 Offset: 0x181DDA0 VA: 0x18181EBA0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x181EC00 Offset: 0x181DE00 VA: 0x18181EC00 Slot: 9
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System
[Serializable]
public sealed class WeakReference<T> : ISerializable // TypeDefIndex: 3279
{
	// Fields
	private GCHandle handle; // 0x0
	private bool trackResurrection; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3AA40 Offset: 0xE39C40 VA: 0x180E3AA40
	|-WeakReference<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T target, bool trackResurrection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3AA80 Offset: 0xE39C80 VA: 0x180E3AA80
	|-WeakReference<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3A910 Offset: 0xE39B10 VA: 0x180E3A910
	|-WeakReference<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3A720 Offset: 0xE39920 VA: 0x180E3A720
	|-WeakReference<object>.GetObjectData
	*/

	// RVA: -1 Offset: -1
	public void SetTarget(T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3A800 Offset: 0xE39A00 VA: 0x180E3A800
	|-WeakReference<object>.SetTarget
	*/

	// RVA: -1 Offset: -1
	public bool TryGetTarget(out T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3A810 Offset: 0xE39A10 VA: 0x180E3A810
	|-WeakReference<object>.TryGetTarget
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE3A6A0 Offset: 0xE398A0 VA: 0x180E3A6A0
	|-WeakReference<object>.Finalize
	*/
}

// Namespace: System
internal struct InputRecord // TypeDefIndex: 3280
{
	// Fields
	public short EventType; // 0x0
	public bool KeyDown; // 0x2
	public short RepeatCount; // 0x4
	public short VirtualKeyCode; // 0x6
	public short VirtualScanCode; // 0x8
	public char Character; // 0xA
	public int ControlKeyState; // 0xC
	private int pad1; // 0x10
	private bool pad2; // 0x14
}

// Namespace: System
internal struct Coord // TypeDefIndex: 3281
{
	// Fields
	public short X; // 0x0
	public short Y; // 0x2
}

// Namespace: System
internal struct SmallRect // TypeDefIndex: 3282
{
	// Fields
	public short Left; // 0x0
	public short Top; // 0x2
	public short Right; // 0x4
	public short Bottom; // 0x6
}

// Namespace: System
internal struct ConsoleScreenBufferInfo // TypeDefIndex: 3283
{
	// Fields
	public Coord Size; // 0x0
	public Coord CursorPosition; // 0x4
	public short Attribute; // 0x8
	public SmallRect Window; // 0xA
	public Coord MaxWindowSize; // 0x12
}

// Namespace: System
internal enum Handles // TypeDefIndex: 3284
{
	// Fields
	public int value__; // 0x0
	public const Handles STD_INPUT = -10;
	public const Handles STD_OUTPUT = -11;
	public const Handles STD_ERROR = -12;
}

// Namespace: System
internal class WindowsConsoleDriver : IConsoleDriver // TypeDefIndex: 3285
{
	// Fields
	private IntPtr inputHandle; // 0x10
	private IntPtr outputHandle; // 0x18
	private short defaultAttribute; // 0x20

	// Methods

	// RVA: 0x181F430 Offset: 0x181E630 VA: 0x18181F430
	public void .ctor() { }

	// RVA: 0x181F1E0 Offset: 0x181E3E0 VA: 0x18181F1E0 Slot: 4
	public ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x181F080 Offset: 0x181E280 VA: 0x18181F080
	private static bool IsModifierKey(short virtualKeyCode) { }

	// RVA: 0x181EFF0 Offset: 0x181E1F0 VA: 0x18181EFF0
	private static extern IntPtr GetStdHandle(Handles handle) { }

	// RVA: 0x181EF50 Offset: 0x181E150 VA: 0x18181EF50
	private static extern bool GetConsoleScreenBufferInfo(IntPtr handle, out ConsoleScreenBufferInfo info) { }

	// RVA: 0x181F0B0 Offset: 0x181E2B0 VA: 0x18181F0B0
	private static extern bool ReadConsoleInput(IntPtr handle, out InputRecord record, int length, out int nread) { }
}

// Namespace: System
internal class __ComObject // TypeDefIndex: 3286
{
	// Methods

	// RVA: 0x181F570 Offset: 0x181E770 VA: 0x18181F570
	private void .ctor() { }
}

// Namespace: 
internal enum Decimal.DecCalc.RoundingMode // TypeDefIndex: 3287
{
	// Fields
	public int value__; // 0x0
	public const Decimal.DecCalc.RoundingMode ToEven = 0;
	public const Decimal.DecCalc.RoundingMode AwayFromZero = 1;
	public const Decimal.DecCalc.RoundingMode Truncate = 2;
	public const Decimal.DecCalc.RoundingMode Floor = 3;
	public const Decimal.DecCalc.RoundingMode Ceiling = 4;
}

// Namespace: 
private struct Decimal.DecCalc.PowerOvfl // TypeDefIndex: 3288
{
	// Fields
	public readonly uint Hi; // 0x0
	public readonly ulong MidLo; // 0x8

	// Methods

	// RVA: 0x1817E20 Offset: 0x1817020 VA: 0x181817E20
	public void .ctor(uint hi, uint mid, uint lo) { }
}

// Namespace: 
private struct Decimal.DecCalc.Buf12 // TypeDefIndex: 3289
{
	// Fields
	public uint U0; // 0x0
	public uint U1; // 0x4
	public uint U2; // 0x8
	private ulong ulo64LE; // 0x0
	private ulong uhigh64LE; // 0x4

	// Properties
	public ulong Low64 { get; set; }
	public ulong High64 { get; set; }

	// Methods

	// RVA: 0xA55380 Offset: 0xA54580 VA: 0x180A55380
	public ulong get_Low64() { }

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Low64(ulong value) { }

	// RVA: 0x1808BA0 Offset: 0x1807DA0 VA: 0x181808BA0
	public ulong get_High64() { }

	// RVA: 0x775120 Offset: 0x774320 VA: 0x180775120
	public void set_High64(ulong value) { }
}

// Namespace: 
private struct Decimal.DecCalc.Buf16 // TypeDefIndex: 3290
{
	// Fields
	public uint U0; // 0x0
	public uint U1; // 0x4
	public uint U2; // 0x8
	public uint U3; // 0xC
	private ulong ulo64LE; // 0x0
	private ulong uhigh64LE; // 0x8

	// Properties
	public ulong Low64 { get; set; }
	public ulong High64 { get; set; }

	// Methods

	// RVA: 0xA55380 Offset: 0xA54580 VA: 0x180A55380
	public ulong get_Low64() { }

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Low64(ulong value) { }

	// RVA: 0x1808BB0 Offset: 0x1807DB0 VA: 0x181808BB0
	public ulong get_High64() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_High64(ulong value) { }
}

// Namespace: 
private struct Decimal.DecCalc.Buf24 // TypeDefIndex: 3291
{
	// Fields
	public uint U0; // 0x0
	public uint U1; // 0x4
	public uint U2; // 0x8
	public uint U3; // 0xC
	public uint U4; // 0x10
	public uint U5; // 0x14
	private ulong ulo64LE; // 0x0
	private ulong umid64LE; // 0x8
	private ulong uhigh64LE; // 0x10

	// Properties
	public ulong Low64 { get; set; }
	public ulong Mid64 { set; }
	public ulong High64 { set; }

	// Methods

	// RVA: 0xA55380 Offset: 0xA54580 VA: 0x180A55380
	public ulong get_Low64() { }

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Low64(ulong value) { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Mid64(ulong value) { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_High64(ulong value) { }
}

// Namespace: 
private struct Decimal.DecCalc // TypeDefIndex: 3292
{
	// Fields
	private uint uflags; // 0x0
	private uint uhi; // 0x4
	private uint ulo; // 0x8
	private uint umid; // 0xC
	private ulong ulomidLE; // 0x8
	private static readonly uint[] s_powers10; // 0x0
	private static readonly ulong[] s_ulongPowers10; // 0x8
	private static readonly double[] s_doublePowers10; // 0x10
	private static readonly Decimal.DecCalc.PowerOvfl[] PowerOvflValues; // 0x18

	// Properties
	private uint High { get; set; }
	private uint Low { get; set; }
	private uint Mid { get; set; }
	private bool IsNegative { get; }
	private ulong Low64 { get; set; }

	// Methods

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	private uint get_High() { }

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	private void set_High(uint value) { }

	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	private uint get_Low() { }

	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	private void set_Low(uint value) { }

	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	private uint get_Mid() { }

	// RVA: 0x438090 Offset: 0x437290 VA: 0x180438090
	private void set_Mid(uint value) { }

	// RVA: 0x180F8F0 Offset: 0x180EAF0 VA: 0x18180F8F0
	private bool get_IsNegative() { }

	// RVA: 0x1808BB0 Offset: 0x1807DB0 VA: 0x181808BB0
	private ulong get_Low64() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	private void set_Low64(ulong value) { }

	// RVA: 0x180C5B0 Offset: 0x180B7B0 VA: 0x18180C5B0
	private static uint GetExponent(float f) { }

	// RVA: 0x180C5A0 Offset: 0x180B7A0 VA: 0x18180C5A0
	private static uint GetExponent(double d) { }

	// RVA: 0x17A59E0 Offset: 0x17A4BE0 VA: 0x1817A59E0
	private static ulong UInt32x32To64(uint a, uint b) { }

	// RVA: 0x180D5A0 Offset: 0x180C7A0 VA: 0x18180D5A0
	private static void UInt64x64To128(ulong a, ulong b, ref Decimal.DecCalc result) { }

	// RVA: 0x180C300 Offset: 0x180B500 VA: 0x18180C300
	private static uint Div96By32(ref Decimal.DecCalc.Buf12 bufNum, uint den) { }

	// RVA: 0x180C4C0 Offset: 0x180B6C0 VA: 0x18180C4C0
	private static bool Div96ByConst(ref ulong high64, ref uint low, uint pow) { }

	// RVA: 0x180D710 Offset: 0x180C910 VA: 0x18180D710
	private static void Unscale(ref uint low, ref ulong high64, ref int scale) { }

	// RVA: 0x180C370 Offset: 0x180B570 VA: 0x18180C370
	private static uint Div96By64(ref Decimal.DecCalc.Buf12 bufNum, ulong den) { }

	// RVA: 0x180C1E0 Offset: 0x180B3E0 VA: 0x18180C1E0
	private static uint Div128By96(ref Decimal.DecCalc.Buf16 bufNum, ref Decimal.DecCalc.Buf12 bufDen) { }

	// RVA: 0x180C790 Offset: 0x180B990 VA: 0x18180C790
	private static uint IncreaseScale(ref Decimal.DecCalc.Buf12 bufNum, uint power) { }

	// RVA: 0x180C710 Offset: 0x180B910 VA: 0x18180C710
	private static void IncreaseScale64(ref Decimal.DecCalc.Buf12 bufNum, uint power) { }

	// RVA: 0x180CC90 Offset: 0x180BE90 VA: 0x18180CC90
	private static int ScaleResult(Decimal.DecCalc.Buf24* bufRes, uint hiRes, int scale) { }

	// RVA: 0x180C520 Offset: 0x180B720 VA: 0x18180C520
	private static uint DivByConst(uint* result, uint hiRes, out uint quotient, out uint remainder, uint power) { }

	// RVA: 0x180CB10 Offset: 0x180BD10 VA: 0x18180CB10
	private static int LeadingZeroCount(uint value) { }

	// RVA: 0x180CB70 Offset: 0x180BD70 VA: 0x18180CB70
	private static int OverflowUnscale(ref Decimal.DecCalc.Buf12 bufQuo, int scale, bool sticky) { }

	// RVA: 0x180D3C0 Offset: 0x180C5C0 VA: 0x18180D3C0
	private static int SearchScale(ref Decimal.DecCalc.Buf12 bufQuo, int scale) { }

	// RVA: 0x180BA10 Offset: 0x180AC10 VA: 0x18180BA10
	private static bool Add32To96(ref Decimal.DecCalc.Buf12 bufNum, uint value) { }

	// RVA: 0x180BA30 Offset: 0x180AC30 VA: 0x18180BA30
	internal static void DecAddSub(ref Decimal.DecCalc d1, ref Decimal.DecCalc d2, bool sign) { }

	// RVA: 0x180DB20 Offset: 0x180CD20 VA: 0x18180DB20
	internal static int VarDecCmp(in Decimal d1, in Decimal d2) { }

	// RVA: 0x180D910 Offset: 0x180CB10 VA: 0x18180D910
	private static int VarDecCmpSub(in Decimal d1, in Decimal d2) { }

	// RVA: 0x180EFB0 Offset: 0x180E1B0 VA: 0x18180EFB0
	internal static void VarDecMul(ref Decimal.DecCalc d1, ref Decimal.DecCalc d2) { }

	// RVA: 0x180E7C0 Offset: 0x180D9C0 VA: 0x18180E7C0
	internal static void VarDecFromR4(float input, out Decimal.DecCalc result) { }

	// RVA: 0x180EBC0 Offset: 0x180DDC0 VA: 0x18180EBC0
	internal static void VarDecFromR8(double input, out Decimal.DecCalc result) { }

	// RVA: 0x180F4E0 Offset: 0x180E6E0 VA: 0x18180F4E0
	internal static float VarR4FromDec(in Decimal value) { }

	// RVA: 0x180F530 Offset: 0x180E730 VA: 0x18180F530
	internal static double VarR8FromDec(in Decimal value) { }

	// RVA: 0x180C5C0 Offset: 0x180B7C0 VA: 0x18180C5C0
	internal static int GetHashCode(in Decimal d) { }

	// RVA: 0x180DC30 Offset: 0x180CE30 VA: 0x18180DC30
	internal static void VarDecDiv(ref Decimal.DecCalc d1, ref Decimal.DecCalc d2) { }

	// RVA: 0x180C820 Offset: 0x180BA20 VA: 0x18180C820
	internal static void InternalRound(ref Decimal.DecCalc d, uint scale, Decimal.DecCalc.RoundingMode mode) { }

	// RVA: 0x180C160 Offset: 0x180B360 VA: 0x18180C160
	internal static uint DecDivMod1E9(ref Decimal.DecCalc value) { }

	// RVA: 0x180F640 Offset: 0x180E840 VA: 0x18180F640
	private static void .cctor() { }
}

// Namespace: System
[IsReadOnly]
[Serializable]
public struct Decimal : IFormattable, IComparable, IConvertible, IComparable<Decimal>, IEquatable<Decimal>, IDeserializationCallback, ISpanFormattable // TypeDefIndex: 3293
{
	// Fields
	private const int SignMask = -2147483648;
	private const int ScaleMask = 16711680;
	private const int ScaleShift = 16;
	[DecimalConstant(0, 0, 0, 0, 0)]
	public static readonly Decimal Zero; // 0x0
	[DecimalConstant(0, 0, 0, 0, 1)]
	public static readonly Decimal One; // 0x10
	[DecimalConstant(0, 128, 0, 0, 1)]
	public static readonly Decimal MinusOne; // 0x20
	[DecimalConstant(0, 0, 4294967295, 4294967295, 4294967295)]
	public static readonly Decimal MaxValue; // 0x30
	[DecimalConstant(0, 128, 4294967295, 4294967295, 4294967295)]
	public static readonly Decimal MinValue; // 0x40
	private readonly int flags; // 0x0
	private readonly int hi; // 0x4
	private readonly int lo; // 0x8
	private readonly int mid; // 0xC
	private readonly ulong ulomidLE; // 0x8

	// Properties
	internal uint High { get; }
	internal uint Low { get; }
	internal uint Mid { get; }
	internal bool IsNegative { get; }
	internal int Scale { get; }
	private ulong Low64 { get; }

	// Methods

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	internal uint get_High() { }

	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	internal uint get_Low() { }

	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	internal uint get_Mid() { }

	// RVA: 0x180F8F0 Offset: 0x180EAF0 VA: 0x18180F8F0
	internal bool get_IsNegative() { }

	// RVA: 0x1812090 Offset: 0x1811290 VA: 0x181812090
	internal int get_Scale() { }

	// RVA: 0x1812050 Offset: 0x1811250 VA: 0x181812050
	private ulong get_Low64() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	private static ref Decimal.DecCalc AsMutable(ref Decimal d) { }

	// RVA: 0x180FB80 Offset: 0x180ED80 VA: 0x18180FB80
	internal static uint DecDivMod1E9(ref Decimal value) { }

	// RVA: 0x1811D60 Offset: 0x1810F60 VA: 0x181811D60
	public void .ctor(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1811CD0 Offset: 0x1810ED0 VA: 0x181811CD0
	public void .ctor(uint value) { }

	// RVA: 0x1811E50 Offset: 0x1811050 VA: 0x181811E50
	public void .ctor(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1811D90 Offset: 0x1810F90 VA: 0x181811D90
	public void .ctor(ulong value) { }

	// RVA: 0x1811FD0 Offset: 0x18111D0 VA: 0x181811FD0
	public void .ctor(float value) { }

	// RVA: 0x1811CE0 Offset: 0x1810EE0 VA: 0x181811CE0
	public void .ctor(double value) { }

	// RVA: 0x1810030 Offset: 0x180F230 VA: 0x181810030
	private static bool IsValid(int flags) { }

	// RVA: 0x1811E80 Offset: 0x1811080 VA: 0x181811E80
	public void .ctor(int[] bits) { }

	// RVA: 0x1811DB0 Offset: 0x1810FB0 VA: 0x181811DB0
	public void .ctor(int lo, int mid, int hi, bool isNegative, byte scale) { }

	// RVA: 0x1810D00 Offset: 0x180FF00 VA: 0x181810D00 Slot: 25
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x1811DA0 Offset: 0x1810FA0 VA: 0x181811DA0
	private void .ctor(in Decimal d, int flags) { }

	// RVA: 0x180F900 Offset: 0x180EB00 VA: 0x18180F900
	internal static Decimal Abs(ref Decimal d) { }

	// RVA: 0x180F920 Offset: 0x180EB20 VA: 0x18180F920
	public static Decimal Add(Decimal d1, Decimal d2) { }

	// RVA: 0x180FB20 Offset: 0x180ED20 VA: 0x18180FB20
	public static int Compare(Decimal d1, Decimal d2) { }

	// RVA: 0x180F9C0 Offset: 0x180EBC0 VA: 0x18180F9C0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x180FAC0 Offset: 0x180ECC0 VA: 0x18180FAC0 Slot: 23
	public int CompareTo(Decimal value) { }

	// RVA: 0x180FC60 Offset: 0x180EE60 VA: 0x18180FC60
	public static Decimal Divide(Decimal d1, Decimal d2) { }

	// RVA: 0x180FD60 Offset: 0x180EF60 VA: 0x18180FD60 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x180FD00 Offset: 0x180EF00 VA: 0x18180FD00 Slot: 24
	public bool Equals(Decimal value) { }

	// RVA: 0x180FEB0 Offset: 0x180F0B0 VA: 0x18180FEB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1811500 Offset: 0x1810700 VA: 0x181811500 Slot: 3
	public override string ToString() { }

	// RVA: 0x1811360 Offset: 0x1810560 VA: 0x181811360 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1811410 Offset: 0x1810610 VA: 0x181811410 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1811940 Offset: 0x1810B40 VA: 0x181811940 Slot: 26
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x1810310 Offset: 0x180F510 VA: 0x181810310
	public static Decimal Parse(string s, IFormatProvider provider) { }

	// RVA: 0x18101F0 Offset: 0x180F3F0 VA: 0x1818101F0
	public static Decimal Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1811A10 Offset: 0x1810C10 VA: 0x181811A10
	public static bool TryParse(string s, out Decimal result) { }

	// RVA: 0x1811AF0 Offset: 0x1810CF0 VA: 0x181811AF0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out Decimal result) { }

	// RVA: 0x180FE20 Offset: 0x180F020 VA: 0x18180FE20
	public static int[] GetBits(Decimal d) { }

	// RVA: 0x1810050 Offset: 0x180F250 VA: 0x181810050
	internal static ref Decimal Max(ref Decimal d1, ref Decimal d2) { }

	// RVA: 0x18100C0 Offset: 0x180F2C0 VA: 0x1818100C0
	internal static ref Decimal Min(ref Decimal d1, ref Decimal d2) { }

	// RVA: 0x1810130 Offset: 0x180F330 VA: 0x181810130
	public static Decimal Multiply(Decimal d1, Decimal d2) { }

	// RVA: 0x18101D0 Offset: 0x180F3D0 VA: 0x1818101D0
	public static Decimal Negate(Decimal d) { }

	// RVA: 0x1810410 Offset: 0x180F610 VA: 0x181810410
	public static Decimal Round(Decimal d, int decimals) { }

	// RVA: 0x1810560 Offset: 0x180F760 VA: 0x181810560
	private static Decimal Round(ref Decimal d, int decimals, MidpointRounding mode) { }

	// RVA: 0x1810DB0 Offset: 0x180FFB0 VA: 0x181810DB0
	public static byte ToByte(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x18111D0 Offset: 0x18103D0 VA: 0x1818111D0
	public static sbyte ToSByte(Decimal value) { }

	// RVA: 0x1810F10 Offset: 0x1810110 VA: 0x181810F10
	public static short ToInt16(Decimal value) { }

	// RVA: 0x1810EC0 Offset: 0x18100C0 VA: 0x181810EC0
	public static double ToDouble(Decimal d) { }

	// RVA: 0x1811020 Offset: 0x1810220 VA: 0x181811020
	public static int ToInt32(Decimal d) { }

	// RVA: 0x18110F0 Offset: 0x18102F0 VA: 0x1818110F0
	public static long ToInt64(Decimal d) { }

	[CLSCompliant(False)]
	// RVA: 0x18115A0 Offset: 0x18107A0 VA: 0x1818115A0
	public static ushort ToUInt16(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x18116B0 Offset: 0x18108B0 VA: 0x1818116B0
	public static uint ToUInt32(Decimal d) { }

	[CLSCompliant(False)]
	// RVA: 0x1811770 Offset: 0x1810970 VA: 0x181811770
	public static ulong ToUInt64(Decimal d) { }

	// RVA: 0x18112E0 Offset: 0x18104E0 VA: 0x1818112E0
	public static float ToSingle(Decimal d) { }

	// RVA: 0x18118E0 Offset: 0x1810AE0 VA: 0x1818118E0
	public static Decimal Truncate(Decimal d) { }

	// RVA: 0x1811850 Offset: 0x1810A50 VA: 0x181811850
	private static void Truncate(ref Decimal d) { }

	// RVA: 0x1812B10 Offset: 0x1811D10 VA: 0x181812B10
	public static Decimal op_Implicit(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x1812A80 Offset: 0x1811C80 VA: 0x181812A80
	public static Decimal op_Implicit(sbyte value) { }

	// RVA: 0x1812AE0 Offset: 0x1811CE0 VA: 0x181812AE0
	public static Decimal op_Implicit(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x18129F0 Offset: 0x1811BF0 VA: 0x1818129F0
	public static Decimal op_Implicit(ushort value) { }

	// RVA: 0x18129F0 Offset: 0x1811BF0 VA: 0x1818129F0
	public static Decimal op_Implicit(char value) { }

	// RVA: 0x1812AB0 Offset: 0x1811CB0 VA: 0x181812AB0
	public static Decimal op_Implicit(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1812A70 Offset: 0x1811C70 VA: 0x181812A70
	public static Decimal op_Implicit(uint value) { }

	// RVA: 0x1812A10 Offset: 0x1811C10 VA: 0x181812A10
	public static Decimal op_Implicit(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1812A50 Offset: 0x1811C50 VA: 0x181812A50
	public static Decimal op_Implicit(ulong value) { }

	// RVA: 0x18123D0 Offset: 0x18115D0 VA: 0x1818123D0
	public static Decimal op_Explicit(float value) { }

	// RVA: 0x18127F0 Offset: 0x18119F0 VA: 0x1818127F0
	public static Decimal op_Explicit(double value) { }

	// RVA: 0x18124B0 Offset: 0x18116B0 VA: 0x1818124B0
	public static byte op_Explicit(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x18123F0 Offset: 0x18115F0 VA: 0x1818123F0
	public static sbyte op_Explicit(Decimal value) { }

	// RVA: 0x1812730 Offset: 0x1811930 VA: 0x181812730
	public static short op_Explicit(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x1812790 Offset: 0x1811990 VA: 0x181812790
	public static ushort op_Explicit(Decimal value) { }

	// RVA: 0x1812810 Offset: 0x1811A10 VA: 0x181812810
	public static int op_Explicit(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x1812450 Offset: 0x1811650 VA: 0x181812450
	public static uint op_Explicit(Decimal value) { }

	// RVA: 0x1812240 Offset: 0x1811440 VA: 0x181812240
	public static long op_Explicit(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x1812510 Offset: 0x1811710 VA: 0x181812510
	public static ulong op_Explicit(Decimal value) { }

	// RVA: 0x1812870 Offset: 0x1811A70 VA: 0x181812870
	public static float op_Explicit(Decimal value) { }

	// RVA: 0x18126A0 Offset: 0x18118A0 VA: 0x1818126A0
	public static double op_Explicit(Decimal value) { }

	// RVA: 0x18101D0 Offset: 0x180F3D0 VA: 0x1818101D0
	public static Decimal op_UnaryNegation(Decimal d) { }

	// RVA: 0x1812B30 Offset: 0x1811D30 VA: 0x181812B30
	public static Decimal op_Increment(Decimal d) { }

	// RVA: 0x18120A0 Offset: 0x18112A0 VA: 0x1818120A0
	public static Decimal op_Addition(Decimal d1, Decimal d2) { }

	// RVA: 0x1812DD0 Offset: 0x1811FD0 VA: 0x181812DD0
	public static Decimal op_Subtraction(Decimal d1, Decimal d2) { }

	// RVA: 0x1812D30 Offset: 0x1811F30 VA: 0x181812D30
	public static Decimal op_Multiply(Decimal d1, Decimal d2) { }

	// RVA: 0x1812140 Offset: 0x1811340 VA: 0x181812140
	public static Decimal op_Division(Decimal d1, Decimal d2) { }

	// RVA: 0x18121E0 Offset: 0x18113E0 VA: 0x1818121E0
	public static bool op_Equality(Decimal d1, Decimal d2) { }

	// RVA: 0x1812C10 Offset: 0x1811E10 VA: 0x181812C10
	public static bool op_Inequality(Decimal d1, Decimal d2) { }

	// RVA: 0x1812CD0 Offset: 0x1811ED0 VA: 0x181812CD0
	public static bool op_LessThan(Decimal d1, Decimal d2) { }

	// RVA: 0x1812C70 Offset: 0x1811E70 VA: 0x181812C70
	public static bool op_LessThanOrEqual(Decimal d1, Decimal d2) { }

	// RVA: 0x1812990 Offset: 0x1811B90 VA: 0x181812990
	public static bool op_GreaterThan(Decimal d1, Decimal d2) { }

	// RVA: 0x1812930 Offset: 0x1811B30 VA: 0x181812930
	public static bool op_GreaterThanOrEqual(Decimal d1, Decimal d2) { }

	// RVA: 0x16EC490 Offset: 0x16EB690 VA: 0x1816EC490 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1810720 Offset: 0x180F920 VA: 0x181810720 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x18107E0 Offset: 0x180F9E0 VA: 0x1818107E0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1810A80 Offset: 0x180FC80 VA: 0x181810A80 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1810780 Offset: 0x180F980 VA: 0x181810780 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1810960 Offset: 0x180FB60 VA: 0x181810960 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1810BE0 Offset: 0x180FDE0 VA: 0x181810BE0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x18109C0 Offset: 0x180FBC0 VA: 0x1818109C0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1810C40 Offset: 0x180FE40 VA: 0x181810C40 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1810A20 Offset: 0x180FC20 VA: 0x181810A20 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1810CA0 Offset: 0x180FEA0 VA: 0x181810CA0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1810AE0 Offset: 0x180FCE0 VA: 0x181810AE0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1810900 Offset: 0x180FB00 VA: 0x181810900 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x4354A0 Offset: 0x4346A0 VA: 0x1804354A0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1810870 Offset: 0x180FA70 VA: 0x181810870 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1810B40 Offset: 0x180FD40 VA: 0x181810B40 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x1811BE0 Offset: 0x1810DE0 VA: 0x181811BE0
	private static void .cctor() { }
}

// Namespace: System.Threading
[Serializable]
public class AbandonedMutexException : SystemException // TypeDefIndex: 3294
{
	// Fields
	private int _mutexIndex; // 0x90
	private Mutex _mutex; // 0x98

	// Methods

	// RVA: 0x1808700 Offset: 0x1807900 VA: 0x181808700
	public void .ctor() { }

	// RVA: 0x1808750 Offset: 0x1807950 VA: 0x181808750
	public void .ctor(int location, WaitHandle handle) { }

	// RVA: 0x1808800 Offset: 0x1807A00 VA: 0x181808800
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1808690 Offset: 0x1807890 VA: 0x181808690
	private void SetupException(int location, WaitHandle handle) { }
}

// Namespace: System.Threading
public sealed class AsyncLocal<T> : IAsyncLocal // TypeDefIndex: 3295
{
	// Fields
	private readonly Action<AsyncLocalValueChangedArgs<T>> m_valueChangedHandler; // 0x0

	// Properties
	public T Value { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-AsyncLocal<object>..ctor
	|-AsyncLocal<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Action<AsyncLocalValueChangedArgs<T>> valueChangedHandler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	|-AsyncLocal<object>..ctor
	|-AsyncLocal<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE533F0 Offset: 0xE525F0 VA: 0x180E533F0
	|-AsyncLocal<object>.get_Value
	|
	|-RVA: 0xE534A0 Offset: 0xE526A0 VA: 0x180E534A0
	|-AsyncLocal<__Il2CppFullySharedGenericType>.get_Value
	*/

	// RVA: -1 Offset: -1
	public void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE536F0 Offset: 0xE528F0 VA: 0x180E536F0
	|-AsyncLocal<object>.set_Value
	|
	|-RVA: 0xE535F0 Offset: 0xE527F0 VA: 0x180E535F0
	|-AsyncLocal<__Il2CppFullySharedGenericType>.set_Value
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private void System.Threading.IAsyncLocal.OnValueChanged(object previousValueObj, object currentValueObj, bool contextChanged) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE532A0 Offset: 0xE524A0 VA: 0x180E532A0
	|-AsyncLocal<object>.System.Threading.IAsyncLocal.OnValueChanged
	|
	|-RVA: 0xE52EB0 Offset: 0xE520B0 VA: 0x180E52EB0
	|-AsyncLocal<__Il2CppFullySharedGenericType>.System.Threading.IAsyncLocal.OnValueChanged
	*/
}

// Namespace: System.Threading
internal interface IAsyncLocal // TypeDefIndex: 3296
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnValueChanged(object previousValue, object currentValue, bool contextChanged);
}

// Namespace: System.Threading
[IsReadOnly]
public struct AsyncLocalValueChangedArgs<T> // TypeDefIndex: 3297
{
	// Fields
	[CompilerGenerated]
	private readonly T <PreviousValue>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly T <CurrentValue>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly bool <ThreadContextChanged>k__BackingField; // 0x0

	// Properties
	public T CurrentValue { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public T get_CurrentValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	|-AsyncLocalValueChangedArgs<object>.get_CurrentValue
	|
	|-RVA: 0xCC56C0 Offset: 0xCC48C0 VA: 0x180CC56C0
	|-AsyncLocalValueChangedArgs<__Il2CppFullySharedGenericType>.get_CurrentValue
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(T previousValue, T currentValue, bool contextChanged) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE52E90 Offset: 0xE52090 VA: 0x180E52E90
	|-AsyncLocalValueChangedArgs<object>..ctor
	|
	|-RVA: 0xE52C80 Offset: 0xE51E80 VA: 0x180E52C80
	|-AsyncLocalValueChangedArgs<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Threading
public sealed class AutoResetEvent : EventWaitHandle // TypeDefIndex: 3298
{
	// Methods

	// RVA: 0x1808A90 Offset: 0x1807C90 VA: 0x181808A90
	public void .ctor(bool initialState) { }
}

// Namespace: System.Threading
public enum EventResetMode // TypeDefIndex: 3299
{
	// Fields
	public int value__; // 0x0
	public const EventResetMode AutoReset = 0;
	public const EventResetMode ManualReset = 1;
}

// Namespace: System.Threading
public static class LazyInitializer // TypeDefIndex: 3300
{
	// Methods

	// RVA: -1 Offset: -1
	public static T EnsureInitialized<T>(ref T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA31880 Offset: 0xA30A80 VA: 0x180A31880
	|-LazyInitializer.EnsureInitialized<object>
	*/

	// RVA: -1 Offset: -1
	private static T EnsureInitializedCore<T>(ref T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA315A0 Offset: 0xA307A0 VA: 0x180A315A0
	|-LazyInitializer.EnsureInitializedCore<object>
	*/

	// RVA: -1 Offset: -1
	public static T EnsureInitialized<T>(ref T target, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA31970 Offset: 0xA30B70 VA: 0x180A31970
	|-LazyInitializer.EnsureInitialized<object>
	*/

	// RVA: -1 Offset: -1
	private static T EnsureInitializedCore<T>(ref T target, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA31640 Offset: 0xA30840 VA: 0x180A31640
	|-LazyInitializer.EnsureInitializedCore<object>
	*/

	// RVA: -1 Offset: -1
	public static T EnsureInitialized<T>(ref T target, ref bool initialized, ref object syncLock, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA316F0 Offset: 0xA308F0 VA: 0x180A316F0
	|-LazyInitializer.EnsureInitialized<bool>
	|
	|-RVA: 0xA31780 Offset: 0xA30980 VA: 0x180A31780
	|-LazyInitializer.EnsureInitialized<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static T EnsureInitializedCore<T>(ref T target, ref bool initialized, ref object syncLock, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA311A0 Offset: 0xA303A0 VA: 0x180A311A0
	|-LazyInitializer.EnsureInitializedCore<bool>
	|
	|-RVA: 0xA312B0 Offset: 0xA304B0 VA: 0x180A312B0
	|-LazyInitializer.EnsureInitializedCore<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T EnsureInitialized<T>(ref T target, ref object syncLock, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA318F0 Offset: 0xA30AF0 VA: 0x180A318F0
	|-LazyInitializer.EnsureInitialized<object>
	*/

	// RVA: -1 Offset: -1
	private static T EnsureInitializedCore<T>(ref T target, ref object syncLock, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA31460 Offset: 0xA30660 VA: 0x180A31460
	|-LazyInitializer.EnsureInitializedCore<object>
	*/

	// RVA: 0x1814D20 Offset: 0x1813F20 VA: 0x181814D20
	private static object EnsureLockInitialized(ref object syncLock) { }
}

// Namespace: System.Threading
public enum LazyThreadSafetyMode // TypeDefIndex: 3301
{
	// Fields
	public int value__; // 0x0
	public const LazyThreadSafetyMode None = 0;
	public const LazyThreadSafetyMode PublicationOnly = 1;
	public const LazyThreadSafetyMode ExecutionAndPublication = 2;
}

// Namespace: System.Threading
[Serializable]
public class LockRecursionException : Exception // TypeDefIndex: 3302
{
	// Methods

	// RVA: 0x1815520 Offset: 0x1814720 VA: 0x181815520
	public void .ctor() { }

	// RVA: 0x1815570 Offset: 0x1814770 VA: 0x181815570
	public void .ctor(string message) { }

	// RVA: 0x18154A0 Offset: 0x18146A0 VA: 0x1818154A0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Threading
public sealed class ManualResetEvent : EventWaitHandle // TypeDefIndex: 3303
{
	// Methods

	// RVA: 0x1817350 Offset: 0x1816550 VA: 0x181817350
	public void .ctor(bool initialState) { }
}

// Namespace: System.Threading
public sealed class ParameterizedThreadStart : MulticastDelegate // TypeDefIndex: 3304
{
	// Methods

	// RVA: 0x7F8090 Offset: 0x7F7290 VA: 0x1807F8090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(object obj) { }
}

// Namespace: System.Threading
[Serializable]
public class SemaphoreFullException : SystemException // TypeDefIndex: 3305
{
	// Methods

	// RVA: 0x1818030 Offset: 0x1817230 VA: 0x181818030
	public void .ctor() { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Threading
public sealed class SendOrPostCallback : MulticastDelegate // TypeDefIndex: 3306
{
	// Methods

	// RVA: 0x7F8090 Offset: 0x7F7290 VA: 0x1807F8090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(object state) { }
}

// Namespace: System.Threading
[Serializable]
public class SynchronizationLockException : SystemException // TypeDefIndex: 3307
{
	// Methods

	// RVA: 0x181B2B0 Offset: 0x181A4B0 VA: 0x18181B2B0
	public void .ctor() { }

	// RVA: 0x181B290 Offset: 0x181A490 VA: 0x18181B290
	public void .ctor(string message) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Threading
public enum ThreadPriority // TypeDefIndex: 3308
{
	// Fields
	public int value__; // 0x0
	public const ThreadPriority Lowest = 0;
	public const ThreadPriority BelowNormal = 1;
	public const ThreadPriority Normal = 2;
	public const ThreadPriority AboveNormal = 3;
	public const ThreadPriority Highest = 4;
}

// Namespace: System.Threading
public sealed class ThreadStart : MulticastDelegate // TypeDefIndex: 3309
{
	// Methods

	// RVA: 0x458710 Offset: 0x457910 VA: 0x180458710
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4240E0 Offset: 0x4232E0 VA: 0x1804240E0 Slot: 13
	public virtual void Invoke() { }
}

// Namespace: System.Threading
[Flags]
public enum ThreadState // TypeDefIndex: 3310
{
	// Fields
	public int value__; // 0x0
	public const ThreadState Running = 0;
	public const ThreadState StopRequested = 1;
	public const ThreadState SuspendRequested = 2;
	public const ThreadState Background = 4;
	public const ThreadState Unstarted = 8;
	public const ThreadState Stopped = 16;
	public const ThreadState WaitSleepJoin = 32;
	public const ThreadState Suspended = 64;
	public const ThreadState AbortRequested = 128;
	public const ThreadState Aborted = 256;
}

// Namespace: System.Threading
[Serializable]
public class ThreadStateException : SystemException // TypeDefIndex: 3311
{
	// Methods

	// RVA: 0x181B3A0 Offset: 0x181A5A0 VA: 0x18181B3A0
	public void .ctor() { }

	// RVA: 0x181B380 Offset: 0x181A580 VA: 0x18181B380
	public void .ctor(string message) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Threading
public static class Timeout // TypeDefIndex: 3312
{
	// Fields
	public static readonly TimeSpan InfiniteTimeSpan; // 0x0

	// Methods

	// RVA: 0x181B440 Offset: 0x181A640 VA: 0x18181B440
	private static void .cctor() { }
}

// Namespace: System.Threading
[Serializable]
public class WaitHandleCannotBeOpenedException : ApplicationException // TypeDefIndex: 3313
{
	// Methods

	// RVA: 0x181EB00 Offset: 0x181DD00 VA: 0x18181EB00
	public void .ctor() { }

	// RVA: 0x181EB50 Offset: 0x181DD50 VA: 0x18181EB50
	public void .ctor(string message) { }

	// RVA: 0x167A820 Offset: 0x1679A20 VA: 0x18167A820
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class CancellationToken.<>c // TypeDefIndex: 3314
{
	// Fields
	public static readonly CancellationToken.<>c <>9; // 0x0

	// Methods

	// RVA: 0x181DBB0 Offset: 0x181CDB0 VA: 0x18181DBB0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x181DA10 Offset: 0x181CC10 VA: 0x18181DA10
	internal void <.cctor>b__26_0(object obj) { }
}

// Namespace: System.Threading
[IsReadOnly]
[DebuggerDisplay("IsCancellationRequested = {IsCancellationRequested}")]
public struct CancellationToken // TypeDefIndex: 3315
{
	// Fields
	private readonly CancellationTokenSource _source; // 0x0
	private static readonly Action<object> s_actionToActionObjShunt; // 0x0

	// Properties
	public static CancellationToken None { get; }
	public bool IsCancellationRequested { get; }
	public bool CanBeCanceled { get; }
	public WaitHandle WaitHandle { get; }

	// Methods

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public static CancellationToken get_None() { }

	// RVA: 0x180B7B0 Offset: 0x180A9B0 VA: 0x18180B7B0
	public bool get_IsCancellationRequested() { }

	// RVA: 0x180B7A0 Offset: 0x180A9A0 VA: 0x18180B7A0
	public bool get_CanBeCanceled() { }

	// RVA: 0x180B7F0 Offset: 0x180A9F0 VA: 0x18180B7F0
	public WaitHandle get_WaitHandle() { }

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(CancellationTokenSource source) { }

	// RVA: 0x180B710 Offset: 0x180A910 VA: 0x18180B710
	public void .ctor(bool canceled) { }

	// RVA: 0x180B250 Offset: 0x180A450 VA: 0x18180B250
	public CancellationTokenRegistration Register(Action callback) { }

	// RVA: 0x180B360 Offset: 0x180A560 VA: 0x18180B360
	public CancellationTokenRegistration Register(Action<object> callback, object state) { }

	// RVA: 0x180B1A0 Offset: 0x180A3A0 VA: 0x18180B1A0
	internal CancellationTokenRegistration InternalRegisterWithoutEC(Action<object> callback, object state) { }

	// RVA: 0x180B410 Offset: 0x180A610 VA: 0x18180B410
	public CancellationTokenRegistration Register(Action<object> callback, object state, bool useSynchronizationContext, bool useExecutionContext) { }

	// RVA: 0x126BA20 Offset: 0x126AC20 VA: 0x18126BA20
	public bool Equals(CancellationToken other) { }

	// RVA: 0x180B080 Offset: 0x180A280 VA: 0x18180B080 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x180B120 Offset: 0x180A320 VA: 0x18180B120 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x180B950 Offset: 0x180AB50 VA: 0x18180B950
	public static bool op_Equality(CancellationToken left, CancellationToken right) { }

	// RVA: 0x180B9B0 Offset: 0x180ABB0 VA: 0x18180B9B0
	public static bool op_Inequality(CancellationToken left, CancellationToken right) { }

	// RVA: 0x180B570 Offset: 0x180A770 VA: 0x18180B570
	public void ThrowIfCancellationRequested() { }

	// RVA: 0x180B5F0 Offset: 0x180A7F0 VA: 0x18180B5F0
	private void ThrowOperationCanceledException() { }

	// RVA: 0x180B650 Offset: 0x180A850 VA: 0x18180B650
	private static void .cctor() { }
}

// Namespace: System.Threading
[DebuggerDisplay("Set = {IsSet}")]
public class ManualResetEventSlim : IDisposable // TypeDefIndex: 3316
{
	// Fields
	private const int DEFAULT_SPIN_SP = 1;
	private object m_lock; // 0x10
	private ManualResetEvent m_eventObj; // 0x18
	private int m_combinedState; // 0x20
	private const int SignalledState_BitMask = -2147483648;
	private const int SignalledState_ShiftCount = 31;
	private const int Dispose_BitMask = 1073741824;
	private const int SpinCountState_BitMask = 1073217536;
	private const int SpinCountState_ShiftCount = 19;
	private const int SpinCountState_MaxValue = 2047;
	private const int NumWaitersState_BitMask = 524287;
	private const int NumWaitersState_ShiftCount = 0;
	private const int NumWaitersState_MaxValue = 524287;
	private static Action<object> s_cancellationTokenCallback; // 0x0

	// Properties
	public WaitHandle WaitHandle { get; }
	public bool IsSet { get; set; }
	public int SpinCount { get; set; }
	private int Waiters { get; set; }

	// Methods

	// RVA: 0x1817140 Offset: 0x1816340 VA: 0x181817140
	public WaitHandle get_WaitHandle() { }

	// RVA: 0x1817080 Offset: 0x1816280 VA: 0x181817080
	public bool get_IsSet() { }

	// RVA: 0x1817230 Offset: 0x1816430 VA: 0x181817230
	private void set_IsSet(bool value) { }

	// RVA: 0x18170E0 Offset: 0x18162E0 VA: 0x1818170E0
	public int get_SpinCount() { }

	// RVA: 0x1817260 Offset: 0x1816460 VA: 0x181817260
	private void set_SpinCount(int value) { }

	// RVA: 0x18171E0 Offset: 0x18163E0 VA: 0x1818171E0
	private int get_Waiters() { }

	// RVA: 0x18172A0 Offset: 0x18164A0 VA: 0x1818172A0
	private void set_Waiters(int value) { }

	// RVA: 0x1816D60 Offset: 0x1815F60 VA: 0x181816D60
	public void .ctor() { }

	// RVA: 0x1816E50 Offset: 0x1816050 VA: 0x181816E50
	public void .ctor(bool initialState) { }

	// RVA: 0x1816F50 Offset: 0x1816150 VA: 0x181816F50
	public void .ctor(bool initialState, int spinCount) { }

	// RVA: 0x1815AD0 Offset: 0x1814CD0 VA: 0x181815AD0
	private void Initialize(bool initialState, int spinCount) { }

	// RVA: 0x1815A30 Offset: 0x1814C30 VA: 0x181815A30
	private void EnsureLockObjectCreated() { }

	// RVA: 0x1815B90 Offset: 0x1814D90 VA: 0x181815B90
	private bool LazyInitializeEvent() { }

	// RVA: 0x1815EC0 Offset: 0x18150C0 VA: 0x181815EC0
	public void Set() { }

	// RVA: 0x1815ED0 Offset: 0x18150D0 VA: 0x181815ED0
	private void Set(bool duringCancellation) { }

	// RVA: 0x1815DC0 Offset: 0x1814FC0 VA: 0x181815DC0
	public void Reset() { }

	// RVA: 0x18163D0 Offset: 0x18155D0 VA: 0x1818163D0
	public void Wait() { }

	// RVA: 0x18163E0 Offset: 0x18155E0 VA: 0x1818163E0
	public void Wait(CancellationToken cancellationToken) { }

	// RVA: 0x18163F0 Offset: 0x18155F0 VA: 0x1818163F0
	public bool Wait(TimeSpan timeout, CancellationToken cancellationToken) { }

	// RVA: 0x18164C0 Offset: 0x18156C0 VA: 0x1818164C0
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1815870 Offset: 0x1814A70 VA: 0x181815870 Slot: 4
	public void Dispose() { }

	// RVA: 0x18158E0 Offset: 0x1814AE0 VA: 0x1818158E0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1816250 Offset: 0x1815450 VA: 0x181816250
	private void ThrowIfDisposed() { }

	// RVA: 0x1815650 Offset: 0x1814850 VA: 0x181815650
	private static void CancellationTokenCallback(object obj) { }

	// RVA: 0x18162C0 Offset: 0x18154C0 VA: 0x1818162C0
	private void UpdateStateAtomically(int newBits, int updateBitsMask) { }

	// RVA: 0x1815AB0 Offset: 0x1814CB0 VA: 0x181815AB0
	private static int ExtractStatePortionAndShiftRight(int state, int mask, int rightBitShiftCount) { }

	// RVA: 0x1815AC0 Offset: 0x1814CC0 VA: 0x181815AC0
	private static int ExtractStatePortion(int state, int mask) { }

	// RVA: 0x1816CE0 Offset: 0x1815EE0 VA: 0x181816CE0
	private static void .cctor() { }
}

// Namespace: System.Threading
public struct NativeOverlapped // TypeDefIndex: 3317
{
	// Fields
	public IntPtr InternalLow; // 0x0
	public IntPtr InternalHigh; // 0x8
	public int OffsetLow; // 0x10
	public int OffsetHigh; // 0x14
	public IntPtr EventHandle; // 0x18
}

// Namespace: System.Threading
public struct SpinWait // TypeDefIndex: 3318
{
	// Fields
	internal static readonly int SpinCountforSpinBeforeWait; // 0x0
	private int _count; // 0x0

	// Properties
	public int Count { get; }
	public bool NextSpinWillYield { get; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public int get_Count() { }

	// RVA: 0x181ADF0 Offset: 0x1819FF0 VA: 0x18181ADF0
	public bool get_NextSpinWillYield() { }

	// RVA: 0x181AC20 Offset: 0x1819E20 VA: 0x18181AC20
	public void SpinOnce() { }

	// RVA: 0x181AC70 Offset: 0x1819E70 VA: 0x18181AC70
	public void SpinOnce(int sleep1Threshold) { }

	// RVA: 0x181AA90 Offset: 0x1819C90 VA: 0x18181AA90
	private void SpinOnceCore(int sleep1Threshold) { }

	// RVA: 0x169ECA0 Offset: 0x169DEA0 VA: 0x18169ECA0
	public void Reset() { }

	// RVA: 0x181AD70 Offset: 0x1819F70 VA: 0x18181AD70
	private static void .cctor() { }
}

// Namespace: System.Threading
internal static class PlatformHelper // TypeDefIndex: 3319
{
	// Fields
	private static int s_processorCount; // 0x0
	private static int s_lastProcessorCountRefreshTicks; // 0x4
	internal static readonly bool IsSingleProcessor; // 0x8

	// Properties
	internal static int ProcessorCount { get; }

	// Methods

	// RVA: 0x1817C00 Offset: 0x1816E00 VA: 0x181817C00
	internal static int get_ProcessorCount() { }

	// RVA: 0x1817BB0 Offset: 0x1816DB0 VA: 0x181817BB0
	private static void .cctor() { }
}

// Namespace: System.Threading
internal static class TimeoutHelper // TypeDefIndex: 3320
{
	// Methods

	// RVA: 0x181B3F0 Offset: 0x181A5F0 VA: 0x18181B3F0
	public static uint GetTime() { }

	// RVA: 0x181B400 Offset: 0x181A600 VA: 0x18181B400
	public static int UpdateTimeOut(uint startTime, int originalWaitMillisecondsTimeout) { }
}

// Namespace: System.Threading
[IsReadOnly]
public struct CancellationTokenRegistration : IEquatable<CancellationTokenRegistration>, IDisposable // TypeDefIndex: 3321
{
	// Fields
	private readonly CancellationCallbackInfo m_callbackInfo; // 0x0
	private readonly SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo; // 0x8

	// Methods

	// RVA: 0x1314440 Offset: 0x1313640 VA: 0x181314440
	internal void .ctor(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo) { }

	// RVA: 0x18093B0 Offset: 0x18085B0 VA: 0x1818093B0
	public bool Unregister() { }

	// RVA: 0x1809030 Offset: 0x1808230 VA: 0x181809030 Slot: 5
	public void Dispose() { }

	// RVA: 0x1809210 Offset: 0x1808410 VA: 0x181809210 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1809180 Offset: 0x1808380 VA: 0x181809180 Slot: 4
	public bool Equals(CancellationTokenRegistration other) { }

	// RVA: 0x1809300 Offset: 0x1808500 VA: 0x181809300 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
private sealed class CancellationTokenSource.Linked1CancellationTokenSource : CancellationTokenSource // TypeDefIndex: 3322
{
	// Fields
	private readonly CancellationTokenRegistration _reg1; // 0x40

	// Methods

	// RVA: 0x1814DD0 Offset: 0x1813FD0 VA: 0x181814DD0
	internal void .ctor(CancellationToken token1) { }

	// RVA: 0x1814D90 Offset: 0x1813F90 VA: 0x181814D90 Slot: 5
	protected override void Dispose(bool disposing) { }
}

// Namespace: 
private sealed class CancellationTokenSource.Linked2CancellationTokenSource : CancellationTokenSource // TypeDefIndex: 3323
{
	// Fields
	private readonly CancellationTokenRegistration _reg1; // 0x40
	private readonly CancellationTokenRegistration _reg2; // 0x58

	// Methods

	// RVA: 0x1814F50 Offset: 0x1814150 VA: 0x181814F50
	internal void .ctor(CancellationToken token1, CancellationToken token2) { }

	// RVA: 0x1814F00 Offset: 0x1814100 VA: 0x181814F00 Slot: 5
	protected override void Dispose(bool disposing) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class CancellationTokenSource.LinkedNCancellationTokenSource.<>c // TypeDefIndex: 3324
{
	// Fields
	public static readonly CancellationTokenSource.LinkedNCancellationTokenSource.<>c <>9; // 0x0

	// Methods

	// RVA: 0x181DB50 Offset: 0x181CD50 VA: 0x18181DB50
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x181DA80 Offset: 0x181CC80 VA: 0x18181DA80
	internal void <.cctor>b__4_0(object s) { }
}

// Namespace: 
private sealed class CancellationTokenSource.LinkedNCancellationTokenSource : CancellationTokenSource // TypeDefIndex: 3325
{
	// Fields
	internal static readonly Action<object> s_linkedTokenCancelDelegate; // 0x0
	private CancellationTokenRegistration[] _linkingRegistrations; // 0x40

	// Methods

	// RVA: 0x1815260 Offset: 0x1814460 VA: 0x181815260
	internal void .ctor(CancellationToken[] tokens) { }

	// RVA: 0x1815110 Offset: 0x1814310 VA: 0x181815110 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18151A0 Offset: 0x18143A0 VA: 0x1818151A0
	private static void .cctor() { }
}

// Namespace: System.Threading
public class CancellationTokenSource : IDisposable // TypeDefIndex: 3326
{
	// Fields
	internal static readonly CancellationTokenSource s_canceledSource; // 0x0
	internal static readonly CancellationTokenSource s_neverCanceledSource; // 0x8
	private static readonly int s_nLists; // 0x10
	private ManualResetEvent _kernelEvent; // 0x10
	private SparselyPopulatedArray<CancellationCallbackInfo>[] _registeredCallbacksLists; // 0x18
	private const int CannotBeCanceled = 0;
	private const int NotCanceledState = 1;
	private const int NotifyingState = 2;
	private const int NotifyingCompleteState = 3;
	private int _state; // 0x20
	private int _threadIDExecutingCallbacks; // 0x24
	private bool _disposed; // 0x28
	private CancellationCallbackInfo _executingCallback; // 0x30
	private Timer _timer; // 0x38
	private static readonly TimerCallback s_timerCallback; // 0x18

	// Properties
	public bool IsCancellationRequested { get; }
	internal bool IsCancellationCompleted { get; }
	internal bool IsDisposed { get; }
	internal int ThreadIDExecutingCallbacks { get; set; }
	public CancellationToken Token { get; }
	internal WaitHandle WaitHandle { get; }
	internal CancellationCallbackInfo ExecutingCallback { get; }

	// Methods

	// RVA: 0x180AEB0 Offset: 0x180A0B0 VA: 0x18180AEB0
	public bool get_IsCancellationRequested() { }

	// RVA: 0x180AE90 Offset: 0x180A090 VA: 0x18180AE90
	internal bool get_IsCancellationCompleted() { }

	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	internal bool get_IsDisposed() { }

	// RVA: 0x180AED0 Offset: 0x180A0D0 VA: 0x18180AED0
	internal int get_ThreadIDExecutingCallbacks() { }

	// RVA: 0x180B050 Offset: 0x180A250 VA: 0x18180B050
	internal void set_ThreadIDExecutingCallbacks(int value) { }

	// RVA: 0x180AEF0 Offset: 0x180A0F0 VA: 0x18180AEF0
	public CancellationToken get_Token() { }

	// RVA: 0x180AF40 Offset: 0x180A140 VA: 0x18180AF40
	internal WaitHandle get_WaitHandle() { }

	// RVA: 0x1701E40 Offset: 0x1701040 VA: 0x181701E40
	internal CancellationCallbackInfo get_ExecutingCallback() { }

	// RVA: 0x180AD20 Offset: 0x1809F20 VA: 0x18180AD20
	public void .ctor() { }

	// RVA: 0x180AD60 Offset: 0x1809F60 VA: 0x18180AD60
	public void .ctor(int millisecondsDelay) { }

	// RVA: 0x180A4C0 Offset: 0x18096C0 VA: 0x18180A4C0
	private void InitializeWithTimer(int millisecondsDelay) { }

	// RVA: 0x1809720 Offset: 0x1808920 VA: 0x181809720
	public void Cancel() { }

	// RVA: 0x18096C0 Offset: 0x18088C0 VA: 0x1818096C0
	public void Cancel(bool throwOnFirstException) { }

	// RVA: 0x1809440 Offset: 0x1808640 VA: 0x181809440
	public void CancelAfter(TimeSpan delay) { }

	// RVA: 0x1809500 Offset: 0x1808700 VA: 0x181809500
	public void CancelAfter(int millisecondsDelay) { }

	// RVA: 0x180A9D0 Offset: 0x1809BD0 VA: 0x18180A9D0
	private static void TimerCallbackLogic(object obj) { }

	// RVA: 0x1809F90 Offset: 0x1809190 VA: 0x181809F90 Slot: 4
	public void Dispose() { }

	// RVA: 0x180A000 Offset: 0x1809200 VA: 0x18180A000 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x180A920 Offset: 0x1809B20 VA: 0x18180A920
	internal void ThrowIfDisposed() { }

	// RVA: 0x180A970 Offset: 0x1809B70 VA: 0x18180A970
	private static void ThrowObjectDisposedException() { }

	// RVA: 0x180A590 Offset: 0x1809790 VA: 0x18180A590
	internal CancellationTokenRegistration InternalRegister(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext) { }

	// RVA: 0x180A870 Offset: 0x1809A70 VA: 0x18180A870
	private void NotifyCancellation(bool throwOnFirstException) { }

	// RVA: 0x180A0A0 Offset: 0x18092A0 VA: 0x18180A0A0
	private void ExecuteCallbackHandlers(bool throwOnFirstException) { }

	// RVA: 0x1809780 Offset: 0x1808980 VA: 0x181809780
	private void CancellationCallbackCoreWork_OnSyncContext(object obj) { }

	// RVA: 0x1809800 Offset: 0x1808A00 VA: 0x181809800
	private void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args) { }

	// RVA: 0x18098C0 Offset: 0x1808AC0 VA: 0x1818098C0
	public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2) { }

	// RVA: 0x1809EC0 Offset: 0x18090C0 VA: 0x181809EC0
	internal static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token) { }

	// RVA: 0x1809B70 Offset: 0x1808D70 VA: 0x181809B70
	public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken[] tokens) { }

	// RVA: 0x180AAD0 Offset: 0x1809CD0 VA: 0x18180AAD0
	internal void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo) { }

	// RVA: 0x180ABA0 Offset: 0x1809DA0 VA: 0x18180ABA0
	private static void .cctor() { }
}

// Namespace: System.Threading
internal struct CancellationCallbackCoreWorkArguments // TypeDefIndex: 3327
{
	// Fields
	internal SparselyPopulatedArrayFragment<CancellationCallbackInfo> _currArrayFragment; // 0x0
	internal int _currArrayIndex; // 0x8

	// Methods

	// RVA: 0x5511A0 Offset: 0x5503A0 VA: 0x1805511A0
	public void .ctor(SparselyPopulatedArrayFragment<CancellationCallbackInfo> currArrayFragment, int currArrayIndex) { }
}

// Namespace: 
internal sealed class CancellationCallbackInfo.WithSyncContext : CancellationCallbackInfo // TypeDefIndex: 3328
{
	// Fields
	internal readonly SynchronizationContext TargetSyncContext; // 0x30

	// Methods

	// RVA: 0x181F510 Offset: 0x181E710 VA: 0x18181F510
	internal void .ctor(Action<object> callback, object stateForCallback, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource, SynchronizationContext targetSyncContext) { }
}

// Namespace: System.Threading
internal class CancellationCallbackInfo // TypeDefIndex: 3329
{
	// Fields
	internal readonly Action<object> Callback; // 0x10
	internal readonly object StateForCallback; // 0x18
	internal readonly ExecutionContext TargetExecutionContext; // 0x20
	internal readonly CancellationTokenSource CancellationTokenSource; // 0x28
	private static ContextCallback s_executionContextCallback; // 0x0

	// Methods

	// RVA: 0x1808FD0 Offset: 0x18081D0 VA: 0x181808FD0
	internal void .ctor(Action<object> callback, object stateForCallback, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource) { }

	// RVA: 0x1808BC0 Offset: 0x1807DC0 VA: 0x181808BC0
	internal void ExecuteCallback() { }

	// RVA: 0x1808F30 Offset: 0x1808130 VA: 0x181808F30
	private static void ExecutionContextCallback(object obj) { }
}

// Namespace: System.Threading
internal class SparselyPopulatedArray<T> // TypeDefIndex: 3330
{
	// Fields
	private readonly SparselyPopulatedArrayFragment<T> _head; // 0x0
	private SparselyPopulatedArrayFragment<T> _tail; // 0x0

	// Properties
	internal SparselyPopulatedArrayFragment<T> Tail { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int initialSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC3CB80 Offset: 0xC3BD80 VA: 0x180C3CB80
	|-SparselyPopulatedArray<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal SparselyPopulatedArrayFragment<T> get_Tail() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC3CC20 Offset: 0xC3BE20 VA: 0x180C3CC20
	|-SparselyPopulatedArray<object>.get_Tail
	*/

	// RVA: -1 Offset: -1
	internal SparselyPopulatedArrayAddInfo<T> Add(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC3C920 Offset: 0xC3BB20 VA: 0x180C3C920
	|-SparselyPopulatedArray<object>.Add
	*/
}

// Namespace: System.Threading
internal struct SparselyPopulatedArrayAddInfo<T> // TypeDefIndex: 3331
{
	// Fields
	private SparselyPopulatedArrayFragment<T> _source; // 0x0
	private int _index; // 0x0

	// Properties
	internal SparselyPopulatedArrayFragment<T> Source { get; }
	internal int Index { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SparselyPopulatedArrayFragment<T> source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5511A0 Offset: 0x5503A0 VA: 0x1805511A0
	|-SparselyPopulatedArrayAddInfo<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal SparselyPopulatedArrayFragment<T> get_Source() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	|-SparselyPopulatedArrayAddInfo<object>.get_Source
	*/

	// RVA: -1 Offset: -1
	internal int get_Index() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	|-SparselyPopulatedArrayAddInfo<object>.get_Index
	*/
}

// Namespace: System.Threading
[DefaultMember("Item")]
internal class SparselyPopulatedArrayFragment<T> // TypeDefIndex: 3332
{
	// Fields
	internal readonly T[] _elements; // 0x0
	internal int _freeCount; // 0x0
	internal SparselyPopulatedArrayFragment<T> _next; // 0x0
	internal SparselyPopulatedArrayFragment<T> _prev; // 0x0

	// Properties
	internal T Item { get; }
	internal int Length { get; }
	internal SparselyPopulatedArrayFragment<T> Prev { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC3C820 Offset: 0xC3BA20 VA: 0x180C3C820
	|-SparselyPopulatedArrayFragment<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(int size, SparselyPopulatedArrayFragment<T> prev) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC3C840 Offset: 0xC3BA40 VA: 0x180C3C840
	|-SparselyPopulatedArrayFragment<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC3C8C0 Offset: 0xC3BAC0 VA: 0x180C3C8C0
	|-SparselyPopulatedArrayFragment<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	internal int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB77F20 Offset: 0xB77120 VA: 0x180B77F20
	|-SparselyPopulatedArrayFragment<object>.get_Length
	*/

	// RVA: -1 Offset: -1
	internal SparselyPopulatedArrayFragment<T> get_Prev() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC3C900 Offset: 0xC3BB00 VA: 0x180C3C900
	|-SparselyPopulatedArrayFragment<object>.get_Prev
	*/

	// RVA: -1 Offset: -1
	internal T SafeAtomicRemove(int index, T expectedElement) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC3C7A0 Offset: 0xC3B9A0 VA: 0x180C3C7A0
	|-SparselyPopulatedArrayFragment<object>.SafeAtomicRemove
	*/
}

// Namespace: System.Threading
[ReflectionBlocked]
public struct LockHolder : IDisposable // TypeDefIndex: 3333
{
	// Fields
	private Lock _lock; // 0x0

	// Methods

	// RVA: 0x1815470 Offset: 0x1814670 VA: 0x181815470
	public static LockHolder Hold(Lock l) { }

	// RVA: 0x1815450 Offset: 0x1814650 VA: 0x181815450 Slot: 4
	public void Dispose() { }
}

// Namespace: System.Threading
public class Lock // TypeDefIndex: 3334
{
	// Fields
	private object _lock; // 0x10

	// Methods

	// RVA: 0x18155D0 Offset: 0x18147D0 VA: 0x1818155D0
	public void Acquire() { }

	// RVA: 0x18155E0 Offset: 0x18147E0 VA: 0x1818155E0
	public void Release() { }

	// RVA: 0x18155F0 Offset: 0x18147F0 VA: 0x1818155F0
	public void .ctor() { }
}

// Namespace: 
private sealed class SemaphoreSlim.TaskNode : Task<bool>, IThreadPoolWorkItem // TypeDefIndex: 3335
{
	// Fields
	internal SemaphoreSlim.TaskNode Prev; // 0x58
	internal SemaphoreSlim.TaskNode Next; // 0x60

	// Methods

	// RVA: 0x181B340 Offset: 0x181A540 VA: 0x18181B340
	internal void .ctor() { }

	// RVA: 0x181B300 Offset: 0x181A500 VA: 0x18181B300 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }
}

// Namespace: 
[CompilerGenerated]
private struct SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32 : IAsyncStateMachine // TypeDefIndex: 3336
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public SemaphoreSlim.TaskNode asyncWaiter; // 0x28
	public int millisecondsTimeout; // 0x30
	public SemaphoreSlim <>4__this; // 0x38
	private CancellationTokenSource <cts>5__2; // 0x40
	private object <>7__wrap2; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task> <>u__1; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__2; // 0x60

	// Methods

	// RVA: 0x181DC10 Offset: 0x181CE10 VA: 0x18181DC10 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x181E550 Offset: 0x181D750 VA: 0x18181E550 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Threading
[ComVisible(False)]
[DebuggerDisplay("Current Count = {m_currentCount}")]
public class SemaphoreSlim : IDisposable // TypeDefIndex: 3337
{
	// Fields
	private int m_currentCount; // 0x10
	private readonly int m_maxCount; // 0x14
	private int m_waitCount; // 0x18
	private object m_lockObj; // 0x20
	private ManualResetEvent m_waitHandle; // 0x28
	private SemaphoreSlim.TaskNode m_asyncHead; // 0x30
	private SemaphoreSlim.TaskNode m_asyncTail; // 0x38
	private static readonly Task<bool> s_trueTask; // 0x0
	private static readonly Task<bool> s_falseTask; // 0x8
	private const int NO_MAXIMUM = 2147483647;
	private static Action<object> s_cancellationTokenCanceledEventHandler; // 0x10

	// Properties
	public int CurrentCount { get; }
	public WaitHandle AvailableWaitHandle { get; }

	// Methods

	// RVA: 0x1819E00 Offset: 0x1819000 VA: 0x181819E00
	public int get_CurrentCount() { }

	// RVA: 0x1819C90 Offset: 0x1818E90 VA: 0x181819C90
	public WaitHandle get_AvailableWaitHandle() { }

	// RVA: 0x1819B70 Offset: 0x1818D70 VA: 0x181819B70
	public void .ctor(int initialCount) { }

	// RVA: 0x18199A0 Offset: 0x1818BA0 VA: 0x1818199A0
	public void .ctor(int initialCount, int maxCount) { }

	// RVA: 0x1819860 Offset: 0x1818A60 VA: 0x181819860
	public void Wait() { }

	// RVA: 0x1819170 Offset: 0x1818370 VA: 0x181819170
	public bool Wait(int millisecondsTimeout) { }

	// RVA: 0x1819180 Offset: 0x1818380 VA: 0x181819180
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1819050 Offset: 0x1818250 VA: 0x181819050
	private bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken) { }

	// RVA: 0x18189C0 Offset: 0x1817BC0 VA: 0x1818189C0
	public Task WaitAsync() { }

	// RVA: 0x1818F10 Offset: 0x1818110 VA: 0x181818F10
	public Task WaitAsync(CancellationToken cancellationToken) { }

	// RVA: 0x18189D0 Offset: 0x1817BD0 VA: 0x1818189D0
	public Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1818320 Offset: 0x1817520 VA: 0x181818320
	private SemaphoreSlim.TaskNode CreateAndAddAsyncWaiter() { }

	// RVA: 0x1818930 Offset: 0x1817B30 VA: 0x181818930
	private bool RemoveAsyncWaiter(SemaphoreSlim.TaskNode task) { }

	[AsyncStateMachine(typeof(SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32))]
	// RVA: 0x1818F20 Offset: 0x1818120 VA: 0x181818F20
	private Task<bool> WaitUntilCountOrTimeoutAsync(SemaphoreSlim.TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1818920 Offset: 0x1817B20 VA: 0x181818920
	public int Release() { }

	// RVA: 0x18184F0 Offset: 0x18176F0 VA: 0x1818184F0
	public int Release(int releaseCount) { }

	// RVA: 0x18184E0 Offset: 0x18176E0 VA: 0x1818184E0
	private static void QueueWaiterTask(SemaphoreSlim.TaskNode waiterTask) { }

	// RVA: 0x18183E0 Offset: 0x18175E0 VA: 0x1818183E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1818450 Offset: 0x1817650 VA: 0x181818450 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1818070 Offset: 0x1817270 VA: 0x181818070
	private static void CancellationTokenCanceledEventHandler(object obj) { }

	// RVA: 0x1818290 Offset: 0x1817490 VA: 0x181818290
	private void CheckDispose() { }

	// RVA: 0x18184D0 Offset: 0x18176D0 VA: 0x1818184D0
	private static string GetResourceString(string str) { }

	// RVA: 0x1819870 Offset: 0x1818A70 VA: 0x181819870
	private static void .cctor() { }
}

// Namespace: 
internal class SpinLock.SystemThreading_SpinLockDebugView // TypeDefIndex: 3338
{}

// Namespace: System.Threading
[DebuggerTypeProxy(typeof(SpinLock.SystemThreading_SpinLockDebugView))]
[ComVisible(False)]
[DebuggerDisplay("IsHeld = {IsHeld}")]
public struct SpinLock // TypeDefIndex: 3339
{
	// Fields
	private int m_owner; // 0x0
	private static int MAXIMUM_WAITERS; // 0x0

	// Properties
	public bool IsHeldByCurrentThread { get; }
	public bool IsThreadOwnerTrackingEnabled { get; }

	// Methods

	// RVA: 0x181A950 Offset: 0x1819B50 VA: 0x18181A950
	public void .ctor(bool enableThreadOwnerTracking) { }

	// RVA: 0x181A5C0 Offset: 0x18197C0 VA: 0x18181A5C0
	public void Enter(ref bool lockTaken) { }

	// RVA: 0x181A840 Offset: 0x1819A40 VA: 0x18181A840
	public void TryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x181A050 Offset: 0x1819250 VA: 0x18181A050
	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x181A4E0 Offset: 0x18196E0 VA: 0x18181A4E0
	private void DecrementWaiters() { }

	// RVA: 0x1819E20 Offset: 0x1819020 VA: 0x181819E20
	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x181A7B0 Offset: 0x18199B0 VA: 0x18181A7B0
	public void Exit(bool useMemoryBarrier) { }

	// RVA: 0x181A670 Offset: 0x1819870 VA: 0x18181A670
	private void ExitSlowPath(bool useMemoryBarrier) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x181A990 Offset: 0x1819B90 VA: 0x18181A990
	public bool get_IsHeldByCurrentThread() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x181AA70 Offset: 0x1819C70 VA: 0x18181AA70
	public bool get_IsThreadOwnerTrackingEnabled() { }

	// RVA: 0x181A910 Offset: 0x1819B10 VA: 0x18181A910
	private static void .cctor() { }
}

// Namespace: 
private struct ThreadLocal.LinkedSlotVolatile<T> // TypeDefIndex: 3340
{
	// Fields
	internal ThreadLocal.LinkedSlot<T> Value; // 0x0
}

// Namespace: 
private sealed class ThreadLocal.LinkedSlot<T> // TypeDefIndex: 3341
{
	// Fields
	internal ThreadLocal.LinkedSlot<T> Next; // 0x0
	internal ThreadLocal.LinkedSlot<T> Previous; // 0x0
	internal ThreadLocal.LinkedSlotVolatile<T>[] SlotArray; // 0x0
	internal T Value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ThreadLocal.LinkedSlotVolatile<T>[] slotArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132C370 Offset: 0x132B570 VA: 0x18132C370
	|-ThreadLocal.LinkedSlot<object>..ctor
	|
	|-RVA: 0x132C300 Offset: 0x132B500 VA: 0x18132C300
	|-ThreadLocal.LinkedSlot<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
private class ThreadLocal.IdManager<T> // TypeDefIndex: 3342
{
	// Fields
	private int m_nextIdToTry; // 0x0
	private List<bool> m_freeIds; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal int GetId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126A860 Offset: 0x1269A60 VA: 0x18126A860
	|-ThreadLocal.IdManager<object>.GetId
	|
	|-RVA: 0x126A6C0 Offset: 0x12698C0 VA: 0x18126A6C0
	|-ThreadLocal.IdManager<__Il2CppFullySharedGenericType>.GetId
	*/

	// RVA: -1 Offset: -1
	internal void ReturnId(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126AA00 Offset: 0x1269C00 VA: 0x18126AA00
	|-ThreadLocal.IdManager<object>.ReturnId
	|
	|-RVA: 0x126AAE0 Offset: 0x1269CE0 VA: 0x18126AAE0
	|-ThreadLocal.IdManager<__Il2CppFullySharedGenericType>.ReturnId
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126AC30 Offset: 0x1269E30 VA: 0x18126AC30
	|-ThreadLocal.IdManager<object>..ctor
	|
	|-RVA: 0x126ABC0 Offset: 0x1269DC0 VA: 0x18126ABC0
	|-ThreadLocal.IdManager<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
private class ThreadLocal.FinalizationHelper<T> // TypeDefIndex: 3343
{
	// Fields
	internal ThreadLocal.LinkedSlotVolatile<T>[] SlotArray; // 0x0
	private bool m_trackAllValues; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ThreadLocal.LinkedSlotVolatile<T>[] slotArray, bool trackAllValues) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FF670 Offset: 0x11FE870 VA: 0x1811FF670
	|-ThreadLocal.FinalizationHelper<object>..ctor
	|-ThreadLocal.FinalizationHelper<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11FF090 Offset: 0x11FE290 VA: 0x1811FF090
	|-ThreadLocal.FinalizationHelper<object>.Finalize
	|
	|-RVA: 0x11FF300 Offset: 0x11FE500 VA: 0x1811FF300
	|-ThreadLocal.FinalizationHelper<__Il2CppFullySharedGenericType>.Finalize
	*/
}

// Namespace: System.Threading
[DebuggerDisplay("IsValueCreated={IsValueCreated}, Value={ValueForDebugDisplay}, Count={ValuesCountForDebugDisplay}")]
[DebuggerTypeProxy(typeof(SystemThreading_ThreadLocalDebugView<T>))]
public class ThreadLocal<T> : IDisposable // TypeDefIndex: 3344
{
	// Fields
	private Func<T> m_valueFactory; // 0x0
	[ThreadStatic]
	private static ThreadLocal.LinkedSlotVolatile<T>[] ts_slotArray; // 0xFFFFFFFF
	[ThreadStatic]
	private static ThreadLocal.FinalizationHelper<T> ts_finalizationHelper; // 0xFFFFFFFF
	private int m_idComplement; // 0x0
	private bool m_initialized; // 0x0
	private static ThreadLocal.IdManager<T> s_idManager; // 0x0
	private ThreadLocal.LinkedSlot<T> m_linkedSlot; // 0x0
	private bool m_trackAllValues; // 0x0

	// Properties
	[DebuggerBrowsable(0)]
	public T Value { get; set; }
	public bool IsValueCreated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCAB170 Offset: 0xCAA370 VA: 0x180CAB170
	|-ThreadLocal<object>..ctor
	|
	|-RVA: 0xCAB0D0 Offset: 0xCAA2D0 VA: 0x180CAB0D0
	|-ThreadLocal<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void Initialize(Func<T> valueFactory, bool trackAllValues) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCAA2A0 Offset: 0xCA94A0 VA: 0x180CAA2A0
	|-ThreadLocal<object>.Initialize
	|
	|-RVA: 0xCAA240 Offset: 0xCA9440 VA: 0x180CAA240
	|-ThreadLocal<__Il2CppFullySharedGenericType>.Initialize
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA9750 Offset: 0xCA8950 VA: 0x180CA9750
	|-ThreadLocal<object>.Finalize
	|-ThreadLocal<__Il2CppFullySharedGenericType>.Finalize
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA9430 Offset: 0xCA8630 VA: 0x180CA9430
	|-ThreadLocal<object>.Dispose
	|
	|-RVA: 0xCA9070 Offset: 0xCA8270 VA: 0x180CA9070
	|-ThreadLocal<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected virtual void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA94A0 Offset: 0xCA86A0 VA: 0x180CA94A0
	|-ThreadLocal<object>.Dispose
	|
	|-RVA: 0xCA90E0 Offset: 0xCA82E0 VA: 0x180CA90E0
	|-ThreadLocal<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCAAC30 Offset: 0xCA9E30 VA: 0x180CAAC30
	|-ThreadLocal<object>.ToString
	|
	|-RVA: 0xCAAD50 Offset: 0xCA9F50 VA: 0x180CAAD50
	|-ThreadLocal<__Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCAB320 Offset: 0xCAA520 VA: 0x180CAB320
	|-ThreadLocal<object>.get_Value
	|
	|-RVA: 0xCAB420 Offset: 0xCAA620 VA: 0x180CAB420
	|-ThreadLocal<__Il2CppFullySharedGenericType>.get_Value
	*/

	// RVA: -1 Offset: -1
	public void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCAB780 Offset: 0xCAA980 VA: 0x180CAB780
	|-ThreadLocal<object>.set_Value
	|
	|-RVA: 0xCAB5A0 Offset: 0xCAA7A0 VA: 0x180CAB5A0
	|-ThreadLocal<__Il2CppFullySharedGenericType>.set_Value
	*/

	// RVA: -1 Offset: -1
	private T GetValueSlow() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA9AA0 Offset: 0xCA8CA0 VA: 0x180CA9AA0
	|-ThreadLocal<object>.GetValueSlow
	|
	|-RVA: 0xCA9810 Offset: 0xCA8A10 VA: 0x180CA9810
	|-ThreadLocal<__Il2CppFullySharedGenericType>.GetValueSlow
	*/

	// RVA: -1 Offset: -1
	private void SetValueSlow(T value, ThreadLocal.LinkedSlotVolatile<T>[] slotArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCAA300 Offset: 0xCA9500 VA: 0x180CAA300
	|-ThreadLocal<object>.SetValueSlow
	|
	|-RVA: 0xCAA720 Offset: 0xCA9920 VA: 0x180CAA720
	|-ThreadLocal<__Il2CppFullySharedGenericType>.SetValueSlow
	*/

	// RVA: -1 Offset: -1
	private void CreateLinkedSlot(ThreadLocal.LinkedSlotVolatile<T>[] slotArray, int id, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA8E10 Offset: 0xCA8010 VA: 0x180CA8E10
	|-ThreadLocal<object>.CreateLinkedSlot
	|
	|-RVA: 0xCA8A40 Offset: 0xCA7C40 VA: 0x180CA8A40
	|-ThreadLocal<__Il2CppFullySharedGenericType>.CreateLinkedSlot
	*/

	// RVA: -1 Offset: -1
	public bool get_IsValueCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCAB210 Offset: 0xCAA410 VA: 0x180CAB210
	|-ThreadLocal<object>.get_IsValueCreated
	|-ThreadLocal<__Il2CppFullySharedGenericType>.get_IsValueCreated
	*/

	// RVA: -1 Offset: -1
	private void GrowTable(ref ThreadLocal.LinkedSlotVolatile<T>[] table, int minLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCAA010 Offset: 0xCA9210 VA: 0x180CAA010
	|-ThreadLocal<object>.GrowTable
	|
	|-RVA: 0xCA9DA0 Offset: 0xCA8FA0 VA: 0x180CA9DA0
	|-ThreadLocal<__Il2CppFullySharedGenericType>.GrowTable
	*/

	// RVA: -1 Offset: -1
	private static int GetNewTableSize(int minSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCA97D0 Offset: 0xCA89D0 VA: 0x180CA97D0
	|-ThreadLocal<object>.GetNewTableSize
	|-ThreadLocal<__Il2CppFullySharedGenericType>.GetNewTableSize
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCAAFE0 Offset: 0xCAA1E0 VA: 0x180CAAFE0
	|-ThreadLocal<object>..cctor
	|
	|-RVA: 0xCAAEC0 Offset: 0xCAA0C0 VA: 0x180CAAEC0
	|-ThreadLocal<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Threading
internal sealed class SystemThreading_ThreadLocalDebugView<T> // TypeDefIndex: 3345
{}

// Namespace: System.Threading
[ComVisible(True)]
public class EventWaitHandle : WaitHandle // TypeDefIndex: 3346
{
	// Methods

	// RVA: 0x1813140 Offset: 0x1812340 VA: 0x181813140
	public void .ctor(bool initialState, EventResetMode mode) { }

	// RVA: 0x1813160 Offset: 0x1812360 VA: 0x181813160
	public void .ctor(bool initialState, EventResetMode mode, string name) { }

	// RVA: 0x1813080 Offset: 0x1812280 VA: 0x181813080
	public bool Reset() { }

	// RVA: 0x18130E0 Offset: 0x18122E0 VA: 0x1818130E0
	public bool Set() { }
}

// Namespace: System.Threading
[ComVisible(True)]
public sealed class ContextCallback : MulticastDelegate // TypeDefIndex: 3347
{
	// Methods

	// RVA: 0x7F8090 Offset: 0x7F7290 VA: 0x1807F8090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(object state) { }
}

// Namespace: System.Threading
internal struct ExecutionContextSwitcher // TypeDefIndex: 3348
{
	// Fields
	internal ExecutionContext.Reader outerEC; // 0x0
	internal bool outerECBelongsToScope; // 0x8
	internal object hecsw; // 0x10
	internal Thread thread; // 0x18

	// Methods

	[ReliabilityContract(3, 1)]
	[HandleProcessCorruptedStateExceptions]
	// RVA: 0x1813480 Offset: 0x1812680 VA: 0x181813480
	internal bool UndoNoThrow() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x18134A0 Offset: 0x18126A0 VA: 0x1818134A0
	internal void Undo() { }
}

// Namespace: 
private enum ExecutionContext.Flags // TypeDefIndex: 3349
{
	// Fields
	public int value__; // 0x0
	public const ExecutionContext.Flags None = 0;
	public const ExecutionContext.Flags IsNewCapture = 1;
	public const ExecutionContext.Flags IsFlowSuppressed = 2;
	public const ExecutionContext.Flags IsPreAllocatedDefault = 4;
}

// Namespace: 
internal struct ExecutionContext.Reader // TypeDefIndex: 3350
{
	// Fields
	private ExecutionContext m_ec; // 0x0

	// Properties
	public bool IsNull { get; }
	public bool IsFlowSuppressed { get; }
	public SynchronizationContext SynchronizationContext { get; }
	public SynchronizationContext SynchronizationContextNoFlow { get; }
	public LogicalCallContext.Reader LogicalCallContext { get; }

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void .ctor(ExecutionContext ec) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ExecutionContext DangerousGetRawExecutionContext() { }

	// RVA: 0x12175A0 Offset: 0x12167A0 VA: 0x1812175A0
	public bool get_IsNull() { }

	// RVA: 0x1817EF0 Offset: 0x18170F0 VA: 0x181817EF0
	public bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	// RVA: 0x1817F50 Offset: 0x1817150 VA: 0x181817F50
	public bool get_IsFlowSuppressed() { }

	// RVA: 0x1818010 Offset: 0x1817210 VA: 0x181818010
	public SynchronizationContext get_SynchronizationContext() { }

	// RVA: 0x1817FF0 Offset: 0x18171F0 VA: 0x181817FF0
	public SynchronizationContext get_SynchronizationContextNoFlow() { }

	// RVA: 0x1817F70 Offset: 0x1817170 VA: 0x181817F70
	public LogicalCallContext.Reader get_LogicalCallContext() { }

	// RVA: 0x1817E40 Offset: 0x1817040 VA: 0x181817E40
	public object GetLocalValue(IAsyncLocal local) { }

	// RVA: 0x1817EC0 Offset: 0x18170C0 VA: 0x181817EC0
	public bool HasSameLocalValues(ExecutionContext other) { }
}

// Namespace: 
[Flags]
internal enum ExecutionContext.CaptureOptions // TypeDefIndex: 3351
{
	// Fields
	public int value__; // 0x0
	public const ExecutionContext.CaptureOptions None = 0;
	public const ExecutionContext.CaptureOptions IgnoreSyncCtx = 1;
	public const ExecutionContext.CaptureOptions OptimizeDefaultCase = 2;
}

// Namespace: System.Threading
[Serializable]
public sealed class ExecutionContext : IDisposable, ISerializable // TypeDefIndex: 3352
{
	// Fields
	private SynchronizationContext _syncContext; // 0x10
	private SynchronizationContext _syncContextNoFlow; // 0x18
	private LogicalCallContext _logicalCallContext; // 0x20
	private IllogicalCallContext _illogicalCallContext; // 0x28
	private ExecutionContext.Flags _flags; // 0x30
	private Dictionary<IAsyncLocal, object> _localValues; // 0x38
	private List<IAsyncLocal> _localChangeNotifications; // 0x40
	private static readonly ExecutionContext s_dummyDefaultEC; // 0x0
	internal static readonly ExecutionContext Default; // 0x8

	// Properties
	internal bool isNewCapture { get; set; }
	internal bool isFlowSuppressed { get; set; }
	internal bool IsPreAllocatedDefault { get; }
	internal LogicalCallContext LogicalCallContext { get; set; }
	internal IllogicalCallContext IllogicalCallContext { get; set; }
	internal SynchronizationContext SynchronizationContext { get; set; }
	internal SynchronizationContext SynchronizationContextNoFlow { get; set; }

	// Methods

	// RVA: 0x1814CD0 Offset: 0x1813ED0 VA: 0x181814CD0
	internal bool get_isNewCapture() { }

	// RVA: 0x1814D00 Offset: 0x1813F00 VA: 0x181814D00
	internal void set_isNewCapture(bool value) { }

	// RVA: 0x1814CC0 Offset: 0x1813EC0 VA: 0x181814CC0
	internal bool get_isFlowSuppressed() { }

	// RVA: 0x1814CE0 Offset: 0x1813EE0 VA: 0x181814CE0
	internal void set_isFlowSuppressed(bool value) { }

	// RVA: 0x1814C40 Offset: 0x1813E40 VA: 0x181814C40
	internal bool get_IsPreAllocatedDefault() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1814AA0 Offset: 0x1813CA0 VA: 0x181814AA0
	internal void .ctor(bool isPreAllocatedDefault) { }

	// RVA: 0x1813BD0 Offset: 0x1812DD0 VA: 0x181813BD0
	internal static object GetLocalValue(IAsyncLocal local) { }

	// RVA: 0x1814790 Offset: 0x1813990 VA: 0x181814790
	internal static void SetLocalValue(IAsyncLocal local, object newValue, bool needChangeNotifications) { }

	[HandleProcessCorruptedStateExceptions]
	// RVA: 0x1813DF0 Offset: 0x1812FF0 VA: 0x181813DF0
	internal static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current) { }

	// RVA: 0x1814C50 Offset: 0x1813E50 VA: 0x181814C50
	internal LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	internal void set_LogicalCallContext(LogicalCallContext value) { }

	// RVA: 0x1814BD0 Offset: 0x1813DD0 VA: 0x181814BD0
	internal IllogicalCallContext get_IllogicalCallContext() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	internal void set_IllogicalCallContext(IllogicalCallContext value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal SynchronizationContext get_SynchronizationContext() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void set_SynchronizationContext(SynchronizationContext value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal SynchronizationContext get_SynchronizationContextNoFlow() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void set_SynchronizationContextNoFlow(SynchronizationContext value) { }

	// RVA: 0x767080 Offset: 0x766280 VA: 0x180767080 Slot: 4
	public void Dispose() { }

	// RVA: 0x18144F0 Offset: 0x18136F0 VA: 0x1818144F0
	public static void Run(ExecutionContext executionContext, ContextCallback callback, object state) { }

	[FriendAccessAllowed]
	// RVA: 0x1814460 Offset: 0x1813660 VA: 0x181814460
	internal static void Run(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	// RVA: 0x18143E0 Offset: 0x18135E0 VA: 0x1818143E0
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state) { }

	[HandleProcessCorruptedStateExceptions]
	// RVA: 0x18141A0 Offset: 0x18133A0 VA: 0x1818141A0
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	// RVA: 0x1813AA0 Offset: 0x1812CA0 VA: 0x181813AA0
	internal static void EstablishCopyOnWriteScope(ref ExecutionContextSwitcher ecsw) { }

	// RVA: 0x1813B30 Offset: 0x1812D30 VA: 0x181813B30
	private static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ref ExecutionContextSwitcher ecsw) { }

	[HandleProcessCorruptedStateExceptions]
	// RVA: 0x1814650 Offset: 0x1813850 VA: 0x181814650
	internal static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx) { }

	// RVA: 0x18137B0 Offset: 0x18129B0 VA: 0x1818137B0
	public ExecutionContext CreateCopy() { }

	// RVA: 0x1813910 Offset: 0x1812B10 VA: 0x181813910
	internal ExecutionContext CreateMutableCopy() { }

	// RVA: 0x1813DB0 Offset: 0x1812FB0 VA: 0x181813DB0
	public static bool IsFlowSuppressed() { }

	// RVA: 0x1813760 Offset: 0x1812960 VA: 0x181813760
	public static ExecutionContext Capture() { }

	[FriendAccessAllowed]
	// RVA: 0x1813B80 Offset: 0x1812D80 VA: 0x181813B80
	internal static ExecutionContext FastCapture() { }

	// RVA: 0x1813540 Offset: 0x1812740 VA: 0x181813540
	internal static ExecutionContext Capture(ref StackCrawlMark stackMark, ExecutionContext.CaptureOptions options) { }

	// RVA: 0x1813C60 Offset: 0x1812E60 VA: 0x181813C60 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1814AD0 Offset: 0x1813CD0 VA: 0x181814AD0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1813D60 Offset: 0x1812F60 VA: 0x181813D60
	internal bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	// RVA: 0x1814A10 Offset: 0x1813C10 VA: 0x181814A10
	private static void .cctor() { }
}

// Namespace: System.Threading
public static class Monitor // TypeDefIndex: 3353
{
	// Methods

	// RVA: 0x18174E0 Offset: 0x18166E0 VA: 0x1818174E0
	public static void Enter(object obj) { }

	// RVA: 0x1817460 Offset: 0x1816660 VA: 0x181817460
	public static void Enter(object obj, ref bool lockTaken) { }

	// RVA: 0x1817990 Offset: 0x1816B90 VA: 0x181817990
	private static void ThrowLockTakenException() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x18174F0 Offset: 0x18166F0 VA: 0x1818174F0
	public static void Exit(object obj) { }

	// RVA: 0x1817A00 Offset: 0x1816C00 VA: 0x181817A00
	public static void TryEnter(object obj, ref bool lockTaken) { }

	// RVA: 0x1817A80 Offset: 0x1816C80 VA: 0x181817A80
	public static bool Wait(object obj, int millisecondsTimeout, bool exitContext) { }

	// RVA: 0x1817A80 Offset: 0x1816C80 VA: 0x181817A80
	public static bool Wait(object obj, int millisecondsTimeout) { }

	// RVA: 0x18177B0 Offset: 0x18169B0 VA: 0x1818177B0
	public static void Pulse(object obj) { }

	// RVA: 0x18176F0 Offset: 0x18168F0 VA: 0x1818176F0
	public static void PulseAll(object obj) { }

	// RVA: 0x1817520 Offset: 0x1816720 VA: 0x181817520
	private static bool Monitor_test_synchronised(object obj) { }

	// RVA: 0x1817510 Offset: 0x1816710 VA: 0x181817510
	private static void Monitor_pulse(object obj) { }

	// RVA: 0x18175B0 Offset: 0x18167B0 VA: 0x1818175B0
	private static void ObjPulse(object obj) { }

	// RVA: 0x1817500 Offset: 0x1816700 VA: 0x181817500
	private static void Monitor_pulse_all(object obj) { }

	// RVA: 0x1817540 Offset: 0x1816740 VA: 0x181817540
	private static void ObjPulseAll(object obj) { }

	// RVA: 0x1817530 Offset: 0x1816730 VA: 0x181817530
	private static bool Monitor_wait(object obj, int ms) { }

	// RVA: 0x1817620 Offset: 0x1816820 VA: 0x181817620
	private static bool ObjWait(bool exitContext, int millisecondsTimeout, object obj) { }

	// RVA: 0x1817BA0 Offset: 0x1816DA0 VA: 0x181817BA0
	private static void try_enter_with_atomic_var(object obj, int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x1817870 Offset: 0x1816A70 VA: 0x181817870
	private static void ReliableEnterTimeout(object obj, int timeout, ref bool lockTaken) { }

	// RVA: 0x1817920 Offset: 0x1816B20 VA: 0x181817920
	private static void ReliableEnter(object obj, ref bool lockTaken) { }
}

// Namespace: System.Threading
[Flags]
internal enum SynchronizationContextProperties // TypeDefIndex: 3354
{
	// Fields
	public int value__; // 0x0
	public const SynchronizationContextProperties None = 0;
	public const SynchronizationContextProperties RequireWaitNotification = 1;
}

// Namespace: System.Threading
public class SynchronizationContext // TypeDefIndex: 3355
{
	// Fields
	private SynchronizationContextProperties _props; // 0x10
	private static Type s_cachedPreparedType1; // 0x0
	private static Type s_cachedPreparedType2; // 0x8
	private static Type s_cachedPreparedType3; // 0x10
	private static Type s_cachedPreparedType4; // 0x18
	private static Type s_cachedPreparedType5; // 0x20

	// Properties
	public static SynchronizationContext Current { get; }
	internal static SynchronizationContext CurrentNoFlow { get; }
	internal static SynchronizationContext CurrentExplicit { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x181AF00 Offset: 0x181A100 VA: 0x18181AF00
	public bool IsWaitNotificationRequired() { }

	// RVA: 0x181AF90 Offset: 0x181A190 VA: 0x18181AF90 Slot: 4
	public virtual void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x181AF10 Offset: 0x181A110 VA: 0x18181AF10 Slot: 5
	public virtual void Post(SendOrPostCallback d, object state) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public virtual void OperationStarted() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public virtual void OperationCompleted() { }

	[CLSCompliant(False)]
	[PrePrepareMethod]
	// RVA: 0x181B0B0 Offset: 0x181A2B0 VA: 0x18181B0B0 Slot: 8
	public virtual int Wait(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout) { }

	[ReliabilityContract(3, 1)]
	[CLSCompliant(False)]
	[PrePrepareMethod]
	// RVA: 0x181B000 Offset: 0x181A200 VA: 0x18181B000
	protected static int WaitHelper(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout) { }

	// RVA: 0x181AFC0 Offset: 0x181A1C0 VA: 0x18181AFC0
	public static void SetSynchronizationContext(SynchronizationContext syncContext) { }

	// RVA: 0x181B220 Offset: 0x181A420 VA: 0x18181B220
	public static SynchronizationContext get_Current() { }

	[FriendAccessAllowed]
	// RVA: 0x181B1B0 Offset: 0x181A3B0 VA: 0x18181B1B0
	internal static SynchronizationContext get_CurrentNoFlow() { }

	// RVA: 0x181AEB0 Offset: 0x181A0B0 VA: 0x18181AEB0
	private static SynchronizationContext GetThreadLocalContext() { }

	// RVA: 0x181AE60 Offset: 0x181A060 VA: 0x18181AE60 Slot: 9
	public virtual SynchronizationContext CreateCopy() { }

	// RVA: 0x181B1A0 Offset: 0x181A3A0 VA: 0x18181B1A0
	internal static SynchronizationContext get_CurrentExplicit() { }
}

// Namespace: 
private sealed class OSSpecificSynchronizationContext.InvocationEntryDelegate : MulticastDelegate // TypeDefIndex: 3356
{
	// Methods

	// RVA: 0x438120 Offset: 0x437320 VA: 0x180438120
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(IntPtr arg) { }
}

// Namespace: 
private class OSSpecificSynchronizationContext.InvocationContext // TypeDefIndex: 3357
{
	// Fields
	private SendOrPostCallback m_Delegate; // 0x10
	private object m_State; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(SendOrPostCallback d, object state) { }

	// RVA: 0x159D700 Offset: 0x159C900 VA: 0x18159D700
	public void Invoke() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class OSSpecificSynchronizationContext.<>c // TypeDefIndex: 3358
{
	// Fields
	public static readonly OSSpecificSynchronizationContext.<>c <>9; // 0x0
	public static ConditionalWeakTable.CreateValueCallback<object, OSSpecificSynchronizationContext> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x15B0C40 Offset: 0x15AFE40 VA: 0x1815B0C40
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x15B03E0 Offset: 0x15AF5E0 VA: 0x1815B03E0
	internal OSSpecificSynchronizationContext <Get>b__3_0(object _osContext) { }
}

// Namespace: System.Threading
internal class OSSpecificSynchronizationContext : SynchronizationContext // TypeDefIndex: 3359
{
	// Fields
	private object m_OSSynchronizationContext; // 0x18
	private static readonly ConditionalWeakTable<object, OSSpecificSynchronizationContext> s_ContextCache; // 0x0

	// Methods

	// RVA: 0x159E350 Offset: 0x159D550 VA: 0x18159E350
	private void .ctor(object osContext) { }

	// RVA: 0x159DE20 Offset: 0x159D020 VA: 0x18159DE20
	public static OSSpecificSynchronizationContext Get() { }

	// RVA: 0x159DDB0 Offset: 0x159CFB0 VA: 0x18159DDB0 Slot: 9
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x159E2A0 Offset: 0x159D4A0 VA: 0x18159E2A0 Slot: 4
	public override void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x159E100 Offset: 0x159D300 VA: 0x18159E100 Slot: 5
	public override void Post(SendOrPostCallback d, object state) { }

	[MonoPInvokeCallback(typeof(OSSpecificSynchronizationContext.InvocationEntryDelegate))]
	// RVA: 0x159DF90 Offset: 0x159D190 VA: 0x18159DF90
	private static void InvocationEntry(IntPtr arg) { }

	// RVA: 0x159DE10 Offset: 0x159D010 VA: 0x18159DE10
	private static object GetOSContext() { }

	// RVA: 0x159E0F0 Offset: 0x159D2F0 VA: 0x18159E0F0
	private static void PostInternal(object osSynchronizationContext, IntPtr callback, IntPtr arg) { }

	// RVA: 0x159E2E0 Offset: 0x159D4E0 VA: 0x18159E2E0
	private static void .cctor() { }
}

// Namespace: System.Threading
internal class ThreadHelper // TypeDefIndex: 3360
{
	// Fields
	private Delegate _start; // 0x10
	private object _startArg; // 0x18
	private ExecutionContext _executionContext; // 0x20
	internal static ContextCallback _ccb; // 0x0

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(Delegate start) { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	internal void SetExecutionContextHelper(ExecutionContext ec) { }

	// RVA: 0x15ABEE0 Offset: 0x15AB0E0 VA: 0x1815ABEE0
	private static void ThreadStart_Context(object state) { }

	// RVA: 0x15AC020 Offset: 0x15AB220 VA: 0x1815AC020
	internal void ThreadStart(object obj) { }

	// RVA: 0x15AC130 Offset: 0x15AB330 VA: 0x1815AC130
	internal void ThreadStart() { }

	// RVA: 0x15AC240 Offset: 0x15AB440 VA: 0x1815AC240
	private static void .cctor() { }
}

// Namespace: System.Threading
public sealed class Thread : CriticalFinalizerObject // TypeDefIndex: 3361
{
	// Fields
	private static LocalDataStoreMgr s_LocalDataStoreMgr; // 0x0
	[ThreadStatic]
	private static LocalDataStoreHolder s_LocalDataStore; // 0x80000000
	[ThreadStatic]
	internal static CultureInfo m_CurrentCulture; // 0x80000008
	[ThreadStatic]
	internal static CultureInfo m_CurrentUICulture; // 0x80000010
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture; // 0x8
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture; // 0x10
	private InternalThread internal_thread; // 0x10
	private object m_ThreadStartArg; // 0x18
	private object pending_exception; // 0x20
	[ThreadStatic]
	private static Thread current_thread; // 0x80000018
	private MulticastDelegate m_Delegate; // 0x28
	private ExecutionContext m_ExecutionContext; // 0x30
	private bool m_ExecutionContextBelongsToOuterScope; // 0x38
	private IPrincipal principal; // 0x40
	private int principal_version; // 0x48

	// Properties
	internal bool ExecutionContextBelongsToCurrentScope { get; set; }
	public ThreadPriority Priority { set; }
	public CultureInfo CurrentUICulture { get; set; }
	public CultureInfo CurrentCulture { get; set; }
	private InternalThread Internal { get; }
	public static Context CurrentContext { get; }
	public static Thread CurrentThread { get; }
	internal static int CurrentThreadId { get; }
	public bool IsThreadPoolThread { get; }
	internal bool IsThreadPoolThreadInternal { get; }
	public bool IsAlive { get; }
	public bool IsBackground { set; }
	public string Name { get; set; }
	public int ManagedThreadId { get; }

	// Methods

	// RVA: 0x15AE3F0 Offset: 0x15AD5F0 VA: 0x1815AE3F0
	private static void AsyncLocalSetCurrentCulture(AsyncLocalValueChangedArgs<CultureInfo> args) { }

	// RVA: 0x15AE450 Offset: 0x15AD650 VA: 0x1815AE450
	private static void AsyncLocalSetCurrentUICulture(AsyncLocalValueChangedArgs<CultureInfo> args) { }

	// RVA: 0x15AF130 Offset: 0x15AE330 VA: 0x1815AF130
	public void .ctor(ThreadStart start) { }

	// RVA: 0x15AF1B0 Offset: 0x15AE3B0 VA: 0x1815AF1B0
	public void .ctor(ParameterizedThreadStart start) { }

	// RVA: 0x15AF030 Offset: 0x15AE230 VA: 0x1815AF030
	public void .ctor(ParameterizedThreadStart start, int maxStackSize) { }

	// RVA: 0x15AECF0 Offset: 0x15ADEF0 VA: 0x1815AECF0
	public void Start() { }

	// RVA: 0x15AEEB0 Offset: 0x15AE0B0 VA: 0x1815AEEB0
	public void Start(object parameter) { }

	// RVA: 0x15AED10 Offset: 0x15ADF10 VA: 0x1815AED10
	private void Start(ref StackCrawlMark stackMark) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	internal ExecutionContext.Reader GetExecutionContextReader() { }

	// RVA: 0x15AF380 Offset: 0x15AE580 VA: 0x1815AF380
	internal bool get_ExecutionContextBelongsToCurrentScope() { }

	// RVA: 0x15AF900 Offset: 0x15AEB00 VA: 0x1815AF900
	internal void set_ExecutionContextBelongsToCurrentScope(bool value) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x15AE7D0 Offset: 0x15AD9D0 VA: 0x1815AE7D0
	internal ExecutionContext GetMutableExecutionContext() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x15AE940 Offset: 0x15ADB40 VA: 0x1815AE940
	internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x15AE940 Offset: 0x15ADB40 VA: 0x1815AE940
	internal void SetExecutionContext(ExecutionContext.Reader value, bool belongsToCurrentScope) { }

	// RVA: 0x15AE9B0 Offset: 0x15ADBB0 VA: 0x1815AE9B0
	public void set_Priority(ThreadPriority value) { }

	// RVA: 0x15AE9B0 Offset: 0x15ADBB0 VA: 0x1815AE9B0
	private void SetPriorityNative(int priority) { }

	// RVA: 0x15AE920 Offset: 0x15ADB20 VA: 0x1815AE920
	private bool JoinInternal(int millisecondsTimeout) { }

	// RVA: 0x15AE930 Offset: 0x15ADB30 VA: 0x1815AE930
	public void Join() { }

	// RVA: 0x15AEBB0 Offset: 0x15ADDB0 VA: 0x1815AEBB0
	private static void SleepInternal(int millisecondsTimeout) { }

	// RVA: 0x15AEBC0 Offset: 0x15ADDC0 VA: 0x1815AEBC0
	public static void Sleep(int millisecondsTimeout) { }

	// RVA: 0x15AF020 Offset: 0x15AE220 VA: 0x1815AF020
	private static bool YieldInternal() { }

	// RVA: 0x15AF020 Offset: 0x15AE220 VA: 0x1815AF020
	public static bool Yield() { }

	// RVA: 0x15AE9C0 Offset: 0x15ADBC0 VA: 0x1815AE9C0
	private void SetStartHelper(Delegate start, int maxStackSize) { }

	// RVA: 0x15AF340 Offset: 0x15AE540 VA: 0x1815AF340
	public CultureInfo get_CurrentUICulture() { }

	// RVA: 0x15AF6F0 Offset: 0x15AE8F0 VA: 0x1815AF6F0
	public void set_CurrentUICulture(CultureInfo value) { }

	// RVA: 0x15AE6F0 Offset: 0x15AD8F0 VA: 0x1815AE6F0
	internal CultureInfo GetCurrentUICultureNoAppX() { }

	// RVA: 0x15AF240 Offset: 0x15AE440 VA: 0x1815AF240
	public CultureInfo get_CurrentCulture() { }

	// RVA: 0x15AF500 Offset: 0x15AE700 VA: 0x1815AF500
	public void set_CurrentCulture(CultureInfo value) { }

	// RVA: 0x15AE610 Offset: 0x15AD810 VA: 0x1815AE610
	private CultureInfo GetCurrentCultureNoAppX() { }

	// RVA: 0x15AF460 Offset: 0x15AE660 VA: 0x1815AF460
	private static void nativeInitCultureAccessors() { }

	// RVA: 0x159D070 Offset: 0x159C270 VA: 0x18159D070
	public static void MemoryBarrier() { }

	// RVA: 0x15AE560 Offset: 0x15AD760 VA: 0x1815AE560
	private void ConstructInternalThread() { }

	// RVA: 0x15AF390 Offset: 0x15AE590 VA: 0x1815AF390
	private InternalThread get_Internal() { }

	// RVA: 0x15AF230 Offset: 0x15AE430 VA: 0x1815AF230
	public static Context get_CurrentContext() { }

	// RVA: 0x15AE6B0 Offset: 0x15AD8B0 VA: 0x1815AE6B0
	private static void GetCurrentThread_icall(ref Thread thread) { }

	// RVA: 0x15AE6C0 Offset: 0x15AD8C0 VA: 0x1815AE6C0
	private static Thread GetCurrentThread() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x15AF2F0 Offset: 0x15AE4F0 VA: 0x1815AF2F0
	public static Thread get_CurrentThread() { }

	// RVA: 0x15AF280 Offset: 0x15AE480 VA: 0x1815AF280
	internal static int get_CurrentThreadId() { }

	// RVA: 0x15AE790 Offset: 0x15AD990 VA: 0x1815AE790
	public static int GetDomainID() { }

	// RVA: 0x15AEF90 Offset: 0x15AE190 VA: 0x1815AEF90
	private bool Thread_internal(MulticastDelegate start) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x159EEF0 Offset: 0x159E0F0 VA: 0x18159EEF0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x15AF3F0 Offset: 0x15AE5F0 VA: 0x1815AF3F0
	public bool get_IsThreadPoolThread() { }

	// RVA: 0x15AF3F0 Offset: 0x15AE5F0 VA: 0x1815AF3F0
	internal bool get_IsThreadPoolThreadInternal() { }

	// RVA: 0x15AF3C0 Offset: 0x15AE5C0 VA: 0x1815AF3C0
	public bool get_IsAlive() { }

	// RVA: 0x15AF910 Offset: 0x15AEB10 VA: 0x1815AF910
	public void set_IsBackground(bool value) { }

	// RVA: 0x15AE860 Offset: 0x15ADA60 VA: 0x1815AE860
	private static string GetName_internal(InternalThread thread) { }

	// RVA: 0x15AE950 Offset: 0x15ADB50 VA: 0x1815AE950
	private static void SetName_icall(InternalThread thread, char* name, int nameLength) { }

	// RVA: 0x15AE960 Offset: 0x15ADB60 VA: 0x1815AE960
	private static void SetName_internal(InternalThread thread, string name) { }

	// RVA: 0x15AF430 Offset: 0x15AE630 VA: 0x1815AF430
	public string get_Name() { }

	// RVA: 0x15AF9E0 Offset: 0x15AEBE0 VA: 0x1815AF9E0
	public void set_Name(string value) { }

	// RVA: 0x15ADB40 Offset: 0x15ACD40 VA: 0x1815ADB40
	private static void SpinWait_nop() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x15AEC50 Offset: 0x15ADE50 VA: 0x1815AEC50
	public static void SpinWait(int iterations) { }

	// RVA: 0x15AEC80 Offset: 0x15ADE80 VA: 0x1815AEC80
	private void StartInternal(object principal, ref StackCrawlMark stackMark) { }

	// RVA: 0x15AEBA0 Offset: 0x15ADDA0 VA: 0x1815AEBA0
	private static void SetState(InternalThread thread, ThreadState set) { }

	// RVA: 0x15AE550 Offset: 0x15AD750 VA: 0x1815AE550
	private static void ClrState(InternalThread thread, ThreadState clr) { }

	// RVA: 0x15AE910 Offset: 0x15ADB10 VA: 0x1815AE910
	private static ThreadState GetState(InternalThread thread) { }

	// RVA: 0x15AEF80 Offset: 0x15AE180 VA: 0x1815AEF80
	private static int SystemMaxStackStize() { }

	// RVA: 0x15AE870 Offset: 0x15ADA70 VA: 0x1815AE870
	private static int GetProcessDefaultStackSize(int maxStackSize) { }

	// RVA: 0x15AEB60 Offset: 0x15ADD60 VA: 0x1815AEB60
	private void SetStart(MulticastDelegate start, int maxStackSize) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x15AE7A0 Offset: 0x15AD9A0 VA: 0x1815AE7A0
	public int get_ManagedThreadId() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x15AE4B0 Offset: 0x15AD6B0 VA: 0x1815AE4B0
	public static void BeginCriticalRegion() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x15AE570 Offset: 0x15AD770 VA: 0x1815AE570
	public static void EndCriticalRegion() { }

	[ComVisible(False)]
	// RVA: 0x15AE7A0 Offset: 0x15AD9A0 VA: 0x1815AE7A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15AEFA0 Offset: 0x15AE1A0 VA: 0x1815AEFA0
	private ThreadState ValidateThreadState() { }
}

// Namespace: System.Threading
[Serializable]
internal enum StackCrawlMark // TypeDefIndex: 3362
{
	// Fields
	public int value__; // 0x0
	public const StackCrawlMark LookForMe = 0;
	public const StackCrawlMark LookForMyCaller = 1;
	public const StackCrawlMark LookForMyCallersCaller = 2;
	public const StackCrawlMark LookForThread = 3;
}

// Namespace: System.Threading
[ComVisible(True)]
[Serializable]
public sealed class ThreadAbortException : SystemException // TypeDefIndex: 3363
{
	// Methods

	// RVA: 0x15ABE50 Offset: 0x15AB050 VA: 0x1815ABE50
	private void .ctor() { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Threading
[ComVisible(True)]
[Serializable]
public class ThreadInterruptedException : SystemException // TypeDefIndex: 3364
{
	// Methods

	// RVA: 0x15AC2C0 Offset: 0x15AB4C0 VA: 0x1815AC2C0
	public void .ctor() { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Threading
internal interface IThreadPoolWorkItem // TypeDefIndex: 3365
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ExecuteWorkItem();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void MarkAborted(ThreadAbortException tae);
}

// Namespace: System.Threading
[ComVisible(True)]
public sealed class WaitCallback : MulticastDelegate // TypeDefIndex: 3366
{
	// Methods

	// RVA: 0x7F8090 Offset: 0x7F7290 VA: 0x1807F8090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(object state) { }
}

// Namespace: System.Threading
[ComVisible(True)]
public sealed class WaitOrTimerCallback : MulticastDelegate // TypeDefIndex: 3367
{
	// Methods

	// RVA: 0x11BA6F0 Offset: 0x11B98F0 VA: 0x1811BA6F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object state, bool timedOut) { }
}

// Namespace: System.Threading
internal static class ThreadPoolGlobals // TypeDefIndex: 3368
{
	// Fields
	public static int processorCount; // 0x0
	public static bool vmTpInitialized; // 0x4
	public static bool enableWorkerTracking; // 0x5
	public static readonly ThreadPoolWorkQueue workQueue; // 0x8

	// Methods

	// RVA: 0x15AC330 Offset: 0x15AB530 VA: 0x1815AC330
	private static void .cctor() { }
}

// Namespace: 
internal class ThreadPoolWorkQueue.SparseArray<T> // TypeDefIndex: 3369
{
	// Fields
	private T[] m_array; // 0x0

	// Properties
	internal T[] Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int initialSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC3BFA0 Offset: 0xC3B1A0 VA: 0x180C3BFA0
	|-ThreadPoolWorkQueue.SparseArray<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T[] get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC3C010 Offset: 0xC3B210 VA: 0x180C3C010
	|-ThreadPoolWorkQueue.SparseArray<object>.get_Current
	*/

	// RVA: -1 Offset: -1
	internal int Add(T e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC3BC30 Offset: 0xC3AE30 VA: 0x180C3BC30
	|-ThreadPoolWorkQueue.SparseArray<object>.Add
	*/

	// RVA: -1 Offset: -1
	internal void Remove(T e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC3BE50 Offset: 0xC3B050 VA: 0x180C3BE50
	|-ThreadPoolWorkQueue.SparseArray<object>.Remove
	*/
}

// Namespace: 
internal class ThreadPoolWorkQueue.WorkStealingQueue // TypeDefIndex: 3370
{
	// Fields
	internal IThreadPoolWorkItem[] m_array; // 0x10
	private int m_mask; // 0x18
	private int m_headIndex; // 0x1C
	private int m_tailIndex; // 0x20
	private SpinLock m_foreignLock; // 0x24

	// Methods

	// RVA: 0x15B3460 Offset: 0x15B2660 VA: 0x1815B3460
	public void LocalPush(IThreadPoolWorkItem obj) { }

	// RVA: 0x15B2E50 Offset: 0x15B2050 VA: 0x1815B2E50
	public bool LocalFindAndPop(IThreadPoolWorkItem obj) { }

	// RVA: 0x15B3160 Offset: 0x15B2360 VA: 0x1815B3160
	public bool LocalPop(out IThreadPoolWorkItem obj) { }

	// RVA: 0x15B3BD0 Offset: 0x15B2DD0 VA: 0x1815B3BD0
	public bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal) { }

	// RVA: 0x15B3960 Offset: 0x15B2B60 VA: 0x1815B3960
	private bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal, int millisecondsTimeout) { }

	// RVA: 0x15B3BF0 Offset: 0x15B2DF0 VA: 0x1815B3BF0
	public void .ctor() { }
}

// Namespace: 
internal class ThreadPoolWorkQueue.QueueSegment // TypeDefIndex: 3371
{
	// Fields
	internal readonly IThreadPoolWorkItem[] nodes; // 0x10
	private int indexes; // 0x18
	public ThreadPoolWorkQueue.QueueSegment Next; // 0x20

	// Methods

	// RVA: 0x159E400 Offset: 0x159D600 VA: 0x18159E400
	private void GetIndexes(out int upper, out int lower) { }

	// RVA: 0x159E380 Offset: 0x159D580 VA: 0x18159E380
	private bool CompareExchangeIndexes(ref int prevUpper, int newUpper, ref int prevLower, int newLower) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x159E690 Offset: 0x159D890 VA: 0x18159E690
	public void .ctor() { }

	// RVA: 0x159E440 Offset: 0x159D640 VA: 0x18159E440
	public bool IsUsedUp() { }

	// RVA: 0x159E5D0 Offset: 0x159D7D0 VA: 0x18159E5D0
	public bool TryEnqueue(IThreadPoolWorkItem node) { }

	// RVA: 0x159E4A0 Offset: 0x159D6A0 VA: 0x18159E4A0
	public bool TryDequeue(out IThreadPoolWorkItem node) { }
}

// Namespace: System.Threading
internal sealed class ThreadPoolWorkQueue // TypeDefIndex: 3372
{
	// Fields
	internal ThreadPoolWorkQueue.QueueSegment queueHead; // 0x10
	internal ThreadPoolWorkQueue.QueueSegment queueTail; // 0x18
	internal static ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue> allThreadQueues; // 0x0
	private int numOutstandingThreadRequests; // 0x20

	// Methods

	// RVA: 0x15AD9A0 Offset: 0x15ACBA0 VA: 0x1815AD9A0
	public void .ctor() { }

	// RVA: 0x15AD590 Offset: 0x15AC790 VA: 0x1815AD590
	public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue() { }

	// RVA: 0x15AD7D0 Offset: 0x15AC9D0 VA: 0x1815AD7D0
	internal void EnsureThreadRequested() { }

	// RVA: 0x15AD8D0 Offset: 0x15ACAD0 VA: 0x1815AD8D0
	internal void MarkThreadRequestSatisfied() { }

	// RVA: 0x15AD380 Offset: 0x15AC580 VA: 0x1815AD380
	public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal) { }

	// RVA: 0x15AD870 Offset: 0x15ACA70 VA: 0x1815AD870
	internal bool LocalFindAndPop(IThreadPoolWorkItem callback) { }

	// RVA: 0x15ACC30 Offset: 0x15ABE30 VA: 0x1815ACC30
	public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal) { }

	// RVA: 0x15ACF50 Offset: 0x15AC150 VA: 0x1815ACF50
	internal static bool Dispatch() { }

	// RVA: 0x15AD920 Offset: 0x15ACB20 VA: 0x1815AD920
	private static void .cctor() { }
}

// Namespace: System.Threading
internal sealed class ThreadPoolWorkQueueThreadLocals // TypeDefIndex: 3373
{
	// Fields
	[ThreadStatic]
	public static ThreadPoolWorkQueueThreadLocals threadLocals; // 0x80000000
	public readonly ThreadPoolWorkQueue workQueue; // 0x10
	public readonly ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue; // 0x18
	public readonly Random random; // 0x20

	// Methods

	// RVA: 0x15ACA60 Offset: 0x15ABC60 VA: 0x1815ACA60
	public void .ctor(ThreadPoolWorkQueue tpq) { }

	// RVA: 0x15AC8D0 Offset: 0x15ABAD0 VA: 0x1815AC8D0
	private void CleanUp() { }

	// RVA: 0x15AC9D0 Offset: 0x15ABBD0 VA: 0x1815AC9D0 Slot: 1
	protected override void Finalize() { }
}

// Namespace: System.Threading
internal static class _ThreadPoolWaitCallback // TypeDefIndex: 3374
{
	// Methods

	// RVA: 0x15B3C80 Offset: 0x15B2E80 VA: 0x1815B3C80
	internal static bool PerformWaitCallback() { }
}

// Namespace: System.Threading
internal sealed class QueueUserWorkItemCallback : IThreadPoolWorkItem // TypeDefIndex: 3375
{
	// Fields
	private WaitCallback callback; // 0x10
	private ExecutionContext context; // 0x18
	private object state; // 0x20
	internal static ContextCallback ccb; // 0x0

	// Methods

	// RVA: 0x159E8C0 Offset: 0x159DAC0 VA: 0x18159E8C0
	internal void .ctor(WaitCallback waitCallback, object stateObj, bool compressStack, ref StackCrawlMark stackMark) { }

	// RVA: 0x159E6E0 Offset: 0x159D8E0 VA: 0x18159E6E0 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x159E7C0 Offset: 0x159D9C0 VA: 0x18159E7C0
	private static void WaitCallback_Context(object state) { }

	// RVA: 0x159E840 Offset: 0x159DA40 VA: 0x18159E840
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ThreadPool.<>c__DisplayClass17_0<TState> // TypeDefIndex: 3376
{
	// Fields
	public Action<TState> callBack; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-ThreadPool.<>c__DisplayClass17_0<object>..ctor
	|-ThreadPool.<>c__DisplayClass17_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <QueueUserWorkItem>b__0(object x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0A4A0 Offset: 0xB096A0 VA: 0x180B0A4A0
	|-ThreadPool.<>c__DisplayClass17_0<object>.<QueueUserWorkItem>b__0
	|
	|-RVA: 0xB0A3B0 Offset: 0xB095B0 VA: 0x180B0A3B0
	|-ThreadPool.<>c__DisplayClass17_0<__Il2CppFullySharedGenericType>.<QueueUserWorkItem>b__0
	*/
}

// Namespace: System.Threading
public static class ThreadPool // TypeDefIndex: 3377
{
	// Properties
	internal static bool IsThreadPoolThread { get; }

	// Methods

	// RVA: 0x15ADAF0 Offset: 0x15ACCF0 VA: 0x1815ADAF0
	public static void GetMaxThreads(out int workerThreads, out int completionPortThreads) { }

	// RVA: 0x15ADB00 Offset: 0x15ACD00 VA: 0x1815ADB00
	public static void GetMinThreads(out int workerThreads, out int completionPortThreads) { }

	// RVA: 0x15ADAE0 Offset: 0x15ACCE0 VA: 0x1815ADAE0
	public static void GetAvailableThreads(out int workerThreads, out int completionPortThreads) { }

	// RVA: 0x15ADF50 Offset: 0x15AD150 VA: 0x1815ADF50
	private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack) { }

	// RVA: 0x15ADE90 Offset: 0x15AD090 VA: 0x1815ADE90
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, int millisecondsTimeOutInterval, bool executeOnlyOnce) { }

	// RVA: 0x15ADD10 Offset: 0x15ACF10 VA: 0x1815ADD10
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	// RVA: 0x15ADCE0 Offset: 0x15ACEE0 VA: 0x1815ADCE0
	public static bool QueueUserWorkItem(WaitCallback callBack, object state) { }

	// RVA: 0x15ADCB0 Offset: 0x15ACEB0 VA: 0x1815ADCB0
	public static bool QueueUserWorkItem(WaitCallback callBack) { }

	// RVA: 0x15AE340 Offset: 0x15AD540 VA: 0x1815AE340
	public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state) { }

	// RVA: -1 Offset: -1
	public static bool QueueUserWorkItem<TState>(Action<TState> callBack, TState state, bool preferLocal) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA877C0 Offset: 0xA869C0 VA: 0x180A877C0
	|-ThreadPool.QueueUserWorkItem<object>
	|
	|-RVA: 0xA87620 Offset: 0xA86820 VA: 0x180A87620
	|-ThreadPool.QueueUserWorkItem<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x15ADB50 Offset: 0x15ACD50 VA: 0x1815ADB50
	private static bool QueueUserWorkItemHelper(WaitCallback callBack, object state, ref StackCrawlMark stackMark, bool compressStack, bool forceGlobal = True) { }

	// RVA: 0x15AE2C0 Offset: 0x15AD4C0 VA: 0x1815AE2C0
	internal static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal) { }

	// RVA: 0x15AE1D0 Offset: 0x15AD3D0 VA: 0x1815AE1D0
	internal static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem) { }

	// RVA: 0x15AE1C0 Offset: 0x15AD3C0 VA: 0x1815AE1C0
	internal static bool RequestWorkerThread() { }

	// RVA: 0x15ADA40 Offset: 0x15ACC40 VA: 0x1815ADA40
	private static void EnsureVMInitialized() { }

	// RVA: 0x15ADB00 Offset: 0x15ACD00 VA: 0x1815ADB00
	private static void GetMinThreadsNative(out int workerThreads, out int completionPortThreads) { }

	// RVA: 0x15ADAF0 Offset: 0x15ACCF0 VA: 0x1815ADAF0
	private static void GetMaxThreadsNative(out int workerThreads, out int completionPortThreads) { }

	// RVA: 0x15ADAE0 Offset: 0x15ACCE0 VA: 0x1815ADAE0
	private static void GetAvailableThreadsNative(out int workerThreads, out int completionPortThreads) { }

	// RVA: 0x15ADB20 Offset: 0x15ACD20 VA: 0x1815ADB20
	internal static bool NotifyWorkItemComplete() { }

	// RVA: 0x15AE1B0 Offset: 0x15AD3B0 VA: 0x1815AE1B0
	internal static void ReportThreadStatus(bool isWorking) { }

	// RVA: 0x15AC430 Offset: 0x15AB630 VA: 0x1815AC430
	internal static void NotifyWorkItemProgress() { }

	// RVA: 0x15ADB30 Offset: 0x15ACD30 VA: 0x1815ADB30
	internal static void NotifyWorkItemProgressNative() { }

	// RVA: 0x15ADB40 Offset: 0x15ACD40 VA: 0x1815ADB40
	internal static void NotifyWorkItemQueued() { }

	// RVA: 0x15ADB10 Offset: 0x15ACD10 VA: 0x1815ADB10
	private static void InitializeVMTp(ref bool enableWorkerTracking) { }

	// RVA: 0x15AE370 Offset: 0x15AD570 VA: 0x1815AE370
	internal static bool get_IsThreadPoolThread() { }
}

// Namespace: System.Threading
[ComVisible(True)]
public abstract class WaitHandle : MarshalByRefObject, IDisposable // TypeDefIndex: 3378
{
	// Fields
	public const int WaitTimeout = 258;
	private const int MAX_WAITHANDLES = 64;
	private IntPtr waitHandle; // 0x18
	internal SafeWaitHandle safeWaitHandle; // 0x20
	internal bool hasThreadAffinity; // 0x28
	private const int WAIT_OBJECT_0 = 0;
	private const int WAIT_ABANDONED = 128;
	private const int WAIT_FAILED = 2147483647;
	private const int ERROR_TOO_MANY_POSTS = 298;
	private const int ERROR_NOT_OWNED_BY_CALLER = 299;
	protected static readonly IntPtr InvalidHandle; // 0x0
	internal const int MaxWaitHandles = 64;

	// Properties
	[Obsolete("Use the SafeWaitHandle property instead.")]
	public virtual IntPtr Handle { get; set; }
	public SafeWaitHandle SafeWaitHandle { get; set; }

	// Methods

	// RVA: 0x15B2B20 Offset: 0x15B1D20 VA: 0x1815B2B20
	protected void .ctor() { }

	// RVA: 0x15B1A60 Offset: 0x15B0C60 VA: 0x1815B1A60
	private void Init() { }

	// RVA: 0x15B2B90 Offset: 0x15B1D90 VA: 0x1815B2B90 Slot: 7
	public virtual IntPtr get_Handle() { }

	// RVA: 0x15B2CE0 Offset: 0x15B1EE0 VA: 0x1815B2CE0 Slot: 8
	public virtual void set_Handle(IntPtr value) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x15B2C20 Offset: 0x15B1E20 VA: 0x1815B2C20
	public SafeWaitHandle get_SafeWaitHandle() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x15B2DD0 Offset: 0x15B1FD0 VA: 0x1815B2DD0
	public void set_SafeWaitHandle(SafeWaitHandle value) { }

	// RVA: 0x15B1BF0 Offset: 0x15B0DF0 VA: 0x1815B1BF0
	internal void SetHandleInternal(SafeWaitHandle handle) { }

	// RVA: 0x15B27F0 Offset: 0x15B19F0 VA: 0x1815B27F0 Slot: 9
	public virtual bool WaitOne(int millisecondsTimeout, bool exitContext) { }

	// RVA: 0x15B29D0 Offset: 0x15B1BD0 VA: 0x1815B29D0 Slot: 10
	public virtual bool WaitOne(TimeSpan timeout, bool exitContext) { }

	// RVA: 0x15B27B0 Offset: 0x15B19B0 VA: 0x1815B27B0 Slot: 11
	public virtual bool WaitOne() { }

	// RVA: 0x156A970 Offset: 0x1569B70 VA: 0x18156A970 Slot: 12
	public virtual bool WaitOne(int millisecondsTimeout) { }

	// RVA: 0x15B27D0 Offset: 0x15B19D0 VA: 0x1815B27D0 Slot: 13
	public virtual bool WaitOne(TimeSpan timeout) { }

	// RVA: 0x15B2880 Offset: 0x15B1A80 VA: 0x1815B2880
	private bool WaitOne(long timeout, bool exitContext) { }

	// RVA: 0x15B1AD0 Offset: 0x15B0CD0 VA: 0x1815B1AD0
	internal static bool InternalWaitOne(SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x15B1E50 Offset: 0x15B1050 VA: 0x1815B1E50
	public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x15B1CD0 Offset: 0x15B0ED0 VA: 0x1815B1CD0
	public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x15B1DF0 Offset: 0x15B0FF0 VA: 0x1815B1DF0
	public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout) { }

	// RVA: 0x15B1C90 Offset: 0x15B0E90 VA: 0x1815B1C90
	private static void ThrowAbandonedMutexException() { }

	// RVA: 0x15B1C30 Offset: 0x15B0E30 VA: 0x1815B1C30
	private static void ThrowAbandonedMutexException(int location, WaitHandle handle) { }

	// RVA: 0x15B1930 Offset: 0x15B0B30 VA: 0x1815B1930 Slot: 14
	public virtual void Close() { }

	// RVA: 0x15B1A10 Offset: 0x15B0C10 VA: 0x1815B1A10 Slot: 15
	protected virtual void Dispose(bool explicitDisposing) { }

	// RVA: 0x15B19A0 Offset: 0x15B0BA0 VA: 0x1815B19A0 Slot: 6
	public void Dispose() { }

	// RVA: 0x15B25B0 Offset: 0x15B17B0 VA: 0x1815B25B0
	private static int WaitOneNative(SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	// RVA: 0x15B2220 Offset: 0x15B1420 VA: 0x1815B2220
	private static int WaitMultiple(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll) { }

	// RVA: 0x15B2AC0 Offset: 0x15B1CC0 VA: 0x1815B2AC0
	internal static int Wait_internal(IntPtr* handles, int numHandles, bool waitAll, int ms) { }

	// RVA: 0x15B2AD0 Offset: 0x15B1CD0 VA: 0x1815B2AD0
	private static void .cctor() { }
}

// Namespace: System.Threading
public static class Interlocked // TypeDefIndex: 3379
{
	// Methods

	[ReliabilityContract(3, 2)]
	// RVA: 0x159CF50 Offset: 0x159C150 VA: 0x18159CF50
	public static int CompareExchange(ref int location1, int value, int comparand) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x159CF30 Offset: 0x159C130 VA: 0x18159CF30
	internal static int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x159CF20 Offset: 0x159C120 VA: 0x18159CF20
	private static void CompareExchange(ref object location1, ref object value, ref object comparand, ref object result) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x159CF60 Offset: 0x159C160 VA: 0x18159CF60
	public static object CompareExchange(ref object location1, object value, object comparand) { }

	// RVA: 0x159CFA0 Offset: 0x159C1A0 VA: 0x18159CFA0
	public static float CompareExchange(ref float location1, float value, float comparand) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x159CFC0 Offset: 0x159C1C0 VA: 0x18159CFC0
	public static int Decrement(ref int location) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x159D060 Offset: 0x159C260 VA: 0x18159D060
	public static int Increment(ref int location) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x159D050 Offset: 0x159C250 VA: 0x18159D050
	public static long Increment(ref long location) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x159CFF0 Offset: 0x159C1F0 VA: 0x18159CFF0
	public static int Exchange(ref int location1, int value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x159CFD0 Offset: 0x159C1D0 VA: 0x18159CFD0
	private static void Exchange(ref object location1, ref object value, ref object result) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x159D000 Offset: 0x159C200 VA: 0x18159D000
	public static object Exchange(ref object location1, object value) { }

	// RVA: 0x159D030 Offset: 0x159C230 VA: 0x18159D030
	public static float Exchange(ref float location1, float value) { }

	// RVA: 0x159CF40 Offset: 0x159C140 VA: 0x18159CF40
	public static long CompareExchange(ref long location1, long value, long comparand) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x159CF40 Offset: 0x159C140 VA: 0x18159CF40
	public static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand) { }

	// RVA: 0x159CFB0 Offset: 0x159C1B0 VA: 0x18159CFB0
	public static double CompareExchange(ref double location1, double value, double comparand) { }

	[Intrinsic]
	[ComVisible(False)]
	[ReliabilityContract(3, 2)]
	// RVA: -1 Offset: -1
	public static T CompareExchange<T>(ref T location1, T value, T comparand) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Interlocked.CompareExchange<object>
	*/

	// RVA: 0x159CFE0 Offset: 0x159C1E0 VA: 0x18159CFE0
	public static long Exchange(ref long location1, long value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x159CFE0 Offset: 0x159C1E0 VA: 0x18159CFE0
	public static IntPtr Exchange(ref IntPtr location1, IntPtr value) { }

	// RVA: 0x159D040 Offset: 0x159C240 VA: 0x18159D040
	public static double Exchange(ref double location1, double value) { }

	[Intrinsic]
	[ComVisible(False)]
	[ReliabilityContract(3, 2)]
	// RVA: -1 Offset: -1
	public static T Exchange<T>(ref T location1, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Interlocked.Exchange<object>
	*/

	// RVA: 0x159D080 Offset: 0x159C280 VA: 0x18159D080
	public static long Read(ref long location) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x159CF00 Offset: 0x159C100 VA: 0x18159CF00
	public static int Add(ref int location1, int value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x159CF10 Offset: 0x159C110 VA: 0x18159CF10
	public static long Add(ref long location1, long value) { }

	// RVA: 0x159D070 Offset: 0x159C270 VA: 0x18159D070
	public static void MemoryBarrier() { }
}

// Namespace: System.Threading
internal class LockQueue // TypeDefIndex: 3380
{
	// Fields
	private ReaderWriterLock rwlock; // 0x10
	private int lockCount; // 0x18

	// Properties
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(ReaderWriterLock rwlock) { }

	// RVA: 0x159D7C0 Offset: 0x159C9C0 VA: 0x18159D7C0
	public bool Wait(int timeout) { }

	// RVA: 0x159D8F0 Offset: 0x159CAF0 VA: 0x18159D8F0
	public bool get_IsEmpty() { }

	// RVA: 0x159D730 Offset: 0x159C930 VA: 0x18159D730
	public void Pulse() { }
}

// Namespace: System.Threading
[ComVisible(True)]
public sealed class Mutex : WaitHandle // TypeDefIndex: 3381
{
	// Methods

	// RVA: 0x159D990 Offset: 0x159CB90 VA: 0x18159D990
	private static IntPtr CreateMutex_icall(bool initiallyOwned, char* name, int name_length, out bool created) { }

	// RVA: 0x159D9F0 Offset: 0x159CBF0 VA: 0x18159D9F0
	private static bool ReleaseMutex_internal(IntPtr handle) { }

	// RVA: 0x159D9A0 Offset: 0x159CBA0 VA: 0x18159D9A0
	private static IntPtr CreateMutex_internal(bool initiallyOwned, string name, out bool created) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x159DA80 Offset: 0x159CC80 VA: 0x18159DA80
	public void .ctor() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x159DA00 Offset: 0x159CC00 VA: 0x18159DA00
	public void ReleaseMutex() { }
}

// Namespace: System.Threading
internal static class NativeEventCalls // TypeDefIndex: 3382
{
	// Methods

	// RVA: 0x159DB80 Offset: 0x159CD80 VA: 0x18159DB80
	public static IntPtr CreateEvent_internal(bool manual, bool initial, string name, out int errorCode) { }

	// RVA: 0x159DB70 Offset: 0x159CD70 VA: 0x18159DB70
	private static IntPtr CreateEvent_icall(bool manual, bool initial, char* name, int name_length, out int errorCode) { }

	// RVA: 0x159DCE0 Offset: 0x159CEE0 VA: 0x18159DCE0
	public static bool SetEvent(SafeWaitHandle handle) { }

	// RVA: 0x159DCD0 Offset: 0x159CED0 VA: 0x18159DCD0
	private static bool SetEvent_internal(IntPtr handle) { }

	// RVA: 0x159DC00 Offset: 0x159CE00 VA: 0x18159DC00
	public static bool ResetEvent(SafeWaitHandle handle) { }

	// RVA: 0x159DBF0 Offset: 0x159CDF0 VA: 0x18159DBF0
	private static bool ResetEvent_internal(IntPtr handle) { }

	// RVA: 0x159DB60 Offset: 0x159CD60 VA: 0x18159DB60
	public static void CloseEvent_internal(IntPtr handle) { }
}

// Namespace: System.Threading
[ComVisible(True)]
public sealed class ReaderWriterLock : CriticalFinalizerObject // TypeDefIndex: 3383
{
	// Fields
	private int seq_num; // 0x10
	private int state; // 0x14
	private int readers; // 0x18
	private int writer_lock_owner; // 0x1C
	private LockQueue writer_queue; // 0x20
	private Hashtable reader_locks; // 0x28

	// Properties
	public bool IsReaderLockHeld { get; }
	public bool IsWriterLockHeld { get; }

	// Methods

	// RVA: 0x159F500 Offset: 0x159E700 VA: 0x18159F500
	public void .ctor() { }

	// RVA: 0x159EEF0 Offset: 0x159E0F0 VA: 0x18159EEF0 Slot: 1
	protected override void Finalize() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x159F5C0 Offset: 0x159E7C0 VA: 0x18159F5C0
	public bool get_IsReaderLockHeld() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x159F720 Offset: 0x159E920 VA: 0x18159F720
	public bool get_IsWriterLockHeld() { }

	// RVA: 0x159ED40 Offset: 0x159DF40 VA: 0x18159ED40
	public void AcquireReaderLock(int millisecondsTimeout) { }

	// RVA: 0x159E980 Offset: 0x159DB80 VA: 0x18159E980
	private void AcquireReaderLock(int millisecondsTimeout, int initialLockCount) { }

	// RVA: 0x159EEE0 Offset: 0x159E0E0 VA: 0x18159EEE0
	public void AcquireWriterLock(int millisecondsTimeout) { }

	// RVA: 0x159ED50 Offset: 0x159DF50 VA: 0x18159ED50
	private void AcquireWriterLock(int millisecondsTimeout, int initialLockCount) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x159F090 Offset: 0x159E290 VA: 0x18159F090
	public void ReleaseReaderLock() { }

	// RVA: 0x159EF60 Offset: 0x159E160 VA: 0x18159EF60
	private void ReleaseReaderLock(int currentCount, int releaseCount) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x159F370 Offset: 0x159E570 VA: 0x18159F370
	public void ReleaseWriterLock() { }

	// RVA: 0x159F4A0 Offset: 0x159E6A0 VA: 0x18159F4A0
	private void ReleaseWriterLock(int releaseCount) { }

	// RVA: 0x159EF30 Offset: 0x159E130 VA: 0x18159EF30
	private bool HasWriterLock() { }
}

// Namespace: System.Threading
[ComVisible(True)]
public sealed class RegisteredWaitHandle : MarshalByRefObject // TypeDefIndex: 3384
{
	// Fields
	private WaitHandle _waitObject; // 0x18
	private WaitOrTimerCallback _callback; // 0x20
	private object _state; // 0x28
	private WaitHandle _finalEvent; // 0x30
	private ManualResetEvent _cancelEvent; // 0x38
	private TimeSpan _timeout; // 0x40
	private int _callsInProcess; // 0x48
	private bool _executeOnlyOnce; // 0x4C
	private bool _unregistered; // 0x4D

	// Methods

	// RVA: 0x159FF00 Offset: 0x159F100 VA: 0x18159FF00
	internal void .ctor(WaitHandle waitObject, WaitOrTimerCallback callback, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	// RVA: 0x159F9A0 Offset: 0x159EBA0 VA: 0x18159F9A0
	internal void Wait(object state) { }

	// RVA: 0x159F7D0 Offset: 0x159E9D0 VA: 0x18159F7D0
	private void DoCallBack(object timedOut) { }

	[ComVisible(True)]
	// RVA: 0x159F8C0 Offset: 0x159EAC0 VA: 0x18159F8C0
	public bool Unregister(WaitHandle waitObject) { }
}

// Namespace: System.Threading
internal sealed class InternalThread : CriticalFinalizerObject // TypeDefIndex: 3385
{
	// Fields
	private int lock_thread_id; // 0x10
	private IntPtr handle; // 0x18
	private IntPtr native_handle; // 0x20
	private IntPtr name_chars; // 0x28
	private int name_free; // 0x30
	private int name_length; // 0x34
	private ThreadState state; // 0x38
	private object abort_exc; // 0x40
	private int abort_state_handle; // 0x48
	internal long thread_id; // 0x50
	private IntPtr debugger_thread; // 0x58
	private UIntPtr static_data; // 0x60
	private IntPtr runtime_thread_info; // 0x68
	private object current_appcontext; // 0x70
	private object root_domain_thread; // 0x78
	internal byte[] _serialized_principal; // 0x80
	internal int _serialized_principal_version; // 0x88
	private IntPtr appdomain_refs; // 0x90
	private int interruption_requested; // 0x98
	private IntPtr longlived; // 0xA0
	internal bool threadpool_thread; // 0xA8
	private bool thread_interrupt_requested; // 0xA9
	internal int stack_size; // 0xAC
	internal byte apartment_state; // 0xB0
	internal int critical_region_level; // 0xB4
	internal int managed_id; // 0xB8
	private int small_id; // 0xBC
	private IntPtr manage_callback; // 0xC0
	private IntPtr flags; // 0xC8
	private IntPtr thread_pinning_ref; // 0xD0
	private IntPtr abort_protected_block_count; // 0xD8
	private int priority; // 0xE0
	private IntPtr owned_mutex; // 0xE8
	private IntPtr suspended_event; // 0xF0
	private int self_suspended; // 0xF8
	private IntPtr thread_state; // 0x100
	private IntPtr netcore0; // 0x108
	private IntPtr netcore1; // 0x110
	private IntPtr netcore2; // 0x118
	private IntPtr last; // 0x120

	// Methods

	// RVA: 0x159D6D0 Offset: 0x159C8D0 VA: 0x18159D6D0
	private void Thread_free_internal() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x159D670 Offset: 0x159C870 VA: 0x18159D670 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x159D6E0 Offset: 0x159C8E0 VA: 0x18159D6E0
	public void .ctor() { }
}

// Namespace: 
private struct Timer.TimerComparer : IComparer, IComparer<Timer> // TypeDefIndex: 3386
{
	// Methods

	// RVA: 0x15AFAB0 Offset: 0x15AECB0 VA: 0x1815AFAB0 Slot: 4
	private int System.Collections.IComparer.Compare(object x, object y) { }

	// RVA: 0x15AFA40 Offset: 0x15AEC40 VA: 0x1815AFA40 Slot: 5
	public int Compare(Timer tx, Timer ty) { }
}

// Namespace: 
private sealed class Timer.Scheduler // TypeDefIndex: 3387
{
	// Fields
	private static readonly Timer.Scheduler instance; // 0x0
	private bool needReSort; // 0x10
	private List<Timer> list; // 0x18
	private long current_next_run; // 0x20
	private ManualResetEvent changed; // 0x28

	// Properties
	public static Timer.Scheduler Instance { get; }

	// Methods

	// RVA: 0x15A03A0 Offset: 0x159F5A0 VA: 0x1815A03A0
	private void InitScheduler() { }

	// RVA: 0x15A0BB0 Offset: 0x159FDB0 VA: 0x1815A0BB0
	private void WakeupScheduler() { }

	// RVA: 0x15A0970 Offset: 0x159FB70 VA: 0x1815A0970
	private void SchedulerThread() { }

	// RVA: 0x15A0E60 Offset: 0x15A0060 VA: 0x1815A0E60
	public static Timer.Scheduler get_Instance() { }

	// RVA: 0x15A0C30 Offset: 0x159FE30 VA: 0x1815A0C30
	private void .ctor() { }

	// RVA: 0x15A0590 Offset: 0x159F790 VA: 0x1815A0590
	public void Remove(Timer timer) { }

	// RVA: 0x15A0090 Offset: 0x159F290 VA: 0x1815A0090
	public void Change(Timer timer, long new_next_run) { }

	// RVA: 0x159FFB0 Offset: 0x159F1B0 VA: 0x18159FFB0
	private void Add(Timer timer) { }

	// RVA: 0x15A0560 Offset: 0x159F760 VA: 0x1815A0560
	private void InternalRemove(Timer timer) { }

	// RVA: 0x15A0B30 Offset: 0x159FD30 VA: 0x1815A0B30
	private static void TimerCB(object o) { }

	// RVA: 0x15A02D0 Offset: 0x159F4D0 VA: 0x1815A02D0
	private void FireTimer(Timer timer) { }

	// RVA: 0x15A0630 Offset: 0x159F830 VA: 0x1815A0630
	private int RunSchedulerLoop() { }

	// RVA: 0x15A0BD0 Offset: 0x159FDD0 VA: 0x1815A0BD0
	private static void .cctor() { }
}

// Namespace: System.Threading
[ComVisible(True)]
public sealed class Timer : MarshalByRefObject, IDisposable // TypeDefIndex: 3388
{
	// Fields
	private TimerCallback callback; // 0x18
	private object state; // 0x20
	private long due_time_ms; // 0x28
	private long period_ms; // 0x30
	private long next_run; // 0x38
	private bool disposed; // 0x40
	private bool is_dead; // 0x41
	private bool is_added; // 0x42
	private const long MaxValue = 4294967294;

	// Properties
	private static Timer.Scheduler scheduler { get; }

	// Methods

	// RVA: 0x15B0270 Offset: 0x15AF470 VA: 0x1815B0270
	private static Timer.Scheduler get_scheduler() { }

	// RVA: 0x15B00A0 Offset: 0x15AF2A0 VA: 0x1815B00A0
	public void .ctor(TimerCallback callback, object state, int dueTime, int period) { }

	// RVA: 0x15B0160 Offset: 0x15AF360 VA: 0x1815B0160
	public void .ctor(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x15AFFA0 Offset: 0x15AF1A0 VA: 0x1815AFFA0
	public void .ctor(TimerCallback callback) { }

	// RVA: 0x15AFF10 Offset: 0x15AF110 VA: 0x1815AFF10
	private void Init(TimerCallback callback, object state, long dueTime, long period) { }

	// RVA: 0x15AFE10 Offset: 0x15AF010 VA: 0x1815AFE10
	public bool Change(int dueTime, int period) { }

	// RVA: 0x15AFE30 Offset: 0x15AF030 VA: 0x1815AFE30
	public bool Change(TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x15AFEC0 Offset: 0x15AF0C0 VA: 0x1815AFEC0 Slot: 6
	public void Dispose() { }

	// RVA: 0x15AFBA0 Offset: 0x15AEDA0 VA: 0x1815AFBA0
	private bool Change(long dueTime, long period, bool first) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void KeepRootedWhileScheduled() { }

	// RVA: 0x15AFF00 Offset: 0x15AF100 VA: 0x1815AFF00
	private static long GetTimeMonotonic() { }
}

// Namespace: System.Threading
[ComVisible(True)]
public sealed class TimerCallback : MulticastDelegate // TypeDefIndex: 3389
{
	// Methods

	// RVA: 0x7F8090 Offset: 0x7F7290 VA: 0x1807F8090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(object state) { }
}

// Namespace: 
private struct Volatile.VolatileBoolean // TypeDefIndex: 3390
{
	// Fields
	public bool Value; // 0x0
}

// Namespace: 
private struct Volatile.VolatileInt32 // TypeDefIndex: 3391
{
	// Fields
	public int Value; // 0x0
}

// Namespace: 
private struct Volatile.VolatileObject // TypeDefIndex: 3392
{
	// Fields
	public object Value; // 0x0
}

// Namespace: System.Threading
public static class Volatile // TypeDefIndex: 3393
{
	// Methods

	[Intrinsic]
	// RVA: 0x15B18B0 Offset: 0x15B0AB0 VA: 0x1815B18B0
	public static bool Read(ref bool location) { }

	[Intrinsic]
	// RVA: 0x15B1900 Offset: 0x15B0B00 VA: 0x1815B1900
	public static void Write(ref bool location, bool value) { }

	[Intrinsic]
	// RVA: 0x15B1890 Offset: 0x15B0A90 VA: 0x1815B1890
	public static int Read(ref int location) { }

	[Intrinsic]
	// RVA: 0x15B18D0 Offset: 0x15B0AD0 VA: 0x1815B18D0
	public static void Write(ref int location, int value) { }

	[Intrinsic]
	// RVA: -1 Offset: -1
	public static T Read<T>(ref T location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA4350 Offset: 0xAA3550 VA: 0x180AA4350
	|-Volatile.Read<object>
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	public static void Write<T>(ref T location, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA4370 Offset: 0xAA3570 VA: 0x180AA4370
	|-Volatile.Write<object>
	*/

	[ReliabilityContract(3, 2)]
	// RVA: 0xAA4350 Offset: 0xAA3550 VA: 0x180AA4350
	public static long Read(ref long location) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0xAA4370 Offset: 0xAA3570 VA: 0x180AA4370
	public static void Write(ref long location, long value) { }
}

// Namespace: System.Threading.Tasks
[Serializable]
public class TaskCanceledException : OperationCanceledException // TypeDefIndex: 3394
{
	// Fields
	private readonly Task _canceledTask; // 0x98

	// Methods

	// RVA: 0x15A18A0 Offset: 0x15A0AA0 VA: 0x1815A18A0
	public void .ctor() { }

	// RVA: 0x15A1810 Offset: 0x15A0A10 VA: 0x1815A1810
	public void .ctor(Task task) { }

	// RVA: 0x15A17F0 Offset: 0x15A09F0 VA: 0x1815A17F0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Threading.Tasks
public class TaskCompletionSource<TResult> // TypeDefIndex: 3395
{
	// Fields
	private readonly Task<TResult> _task; // 0x0

	// Properties
	public Task<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4F5C0 Offset: 0xC4E7C0 VA: 0x180C4F5C0
	|-TaskCompletionSource<bool>..ctor
	|
	|-RVA: 0xC4F8A0 Offset: 0xC4EAA0 VA: 0x180C4F8A0
	|-TaskCompletionSource<int>..ctor
	|
	|-RVA: 0xC4EF80 Offset: 0xC4E180 VA: 0x180C4EF80
	|-TaskCompletionSource<long>..ctor
	|
	|-RVA: 0xC4F6C0 Offset: 0xC4E8C0 VA: 0x180C4F6C0
	|-TaskCompletionSource<object>..ctor
	|
	|-RVA: 0xC4F3A0 Offset: 0xC4E5A0 VA: 0x180C4F3A0
	|-TaskCompletionSource<SceneInstance>..ctor
	|
	|-RVA: 0xC4F640 Offset: 0xC4E840 VA: 0x180C4F640
	|-TaskCompletionSource<SocketReceiveFromResult>..ctor
	|
	|-RVA: 0xC4FB20 Offset: 0xC4ED20 VA: 0x180C4FB20
	|-TaskCompletionSource<SocketReceiveMessageFromResult>..ctor
	|
	|-RVA: 0xC4F080 Offset: 0xC4E280 VA: 0x180C4F080
	|-TaskCompletionSource<WaitForChangedResult>..ctor
	|
	|-RVA: 0xC4F800 Offset: 0xC4EA00 VA: 0x180C4F800
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4F180 Offset: 0xC4E380 VA: 0x180C4F180
	|-TaskCompletionSource<bool>..ctor
	|
	|-RVA: 0xC4F880 Offset: 0xC4EA80 VA: 0x180C4F880
	|-TaskCompletionSource<int>..ctor
	|
	|-RVA: 0xC4F7E0 Offset: 0xC4E9E0 VA: 0x180C4F7E0
	|-TaskCompletionSource<long>..ctor
	|
	|-RVA: 0xC4F1A0 Offset: 0xC4E3A0 VA: 0x180C4F1A0
	|-TaskCompletionSource<object>..ctor
	|
	|-RVA: 0xC4F4C0 Offset: 0xC4E6C0 VA: 0x180C4F4C0
	|-TaskCompletionSource<SceneInstance>..ctor
	|
	|-RVA: 0xC4F060 Offset: 0xC4E260 VA: 0x180C4F060
	|-TaskCompletionSource<SocketReceiveFromResult>..ctor
	|
	|-RVA: 0xC4F040 Offset: 0xC4E240 VA: 0x180C4F040
	|-TaskCompletionSource<SocketReceiveMessageFromResult>..ctor
	|
	|-RVA: 0xC4FB00 Offset: 0xC4ED00 VA: 0x180C4FB00
	|-TaskCompletionSource<WaitForChangedResult>..ctor
	|
	|-RVA: 0xC4F100 Offset: 0xC4E300 VA: 0x180C4F100
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4F020 Offset: 0xC4E220 VA: 0x180C4F020
	|-TaskCompletionSource<bool>..ctor
	|
	|-RVA: 0xC4F4E0 Offset: 0xC4E6E0 VA: 0x180C4F4E0
	|-TaskCompletionSource<int>..ctor
	|
	|-RVA: 0xC4F120 Offset: 0xC4E320 VA: 0x180C4F120
	|-TaskCompletionSource<long>..ctor
	|
	|-RVA: 0xC4F500 Offset: 0xC4E700 VA: 0x180C4F500
	|-TaskCompletionSource<object>..ctor
	|
	|-RVA: 0xC4F160 Offset: 0xC4E360 VA: 0x180C4F160
	|-TaskCompletionSource<SceneInstance>..ctor
	|
	|-RVA: 0xC4F140 Offset: 0xC4E340 VA: 0x180C4F140
	|-TaskCompletionSource<SocketReceiveFromResult>..ctor
	|
	|-RVA: 0xC4FBA0 Offset: 0xC4EDA0 VA: 0x180C4FBA0
	|-TaskCompletionSource<SocketReceiveMessageFromResult>..ctor
	|
	|-RVA: 0xC4F000 Offset: 0xC4E200 VA: 0x180C4F000
	|-TaskCompletionSource<WaitForChangedResult>..ctor
	|
	|-RVA: 0xBFC130 Offset: 0xBFB330 VA: 0x180BFC130
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4F260 Offset: 0xC4E460 VA: 0x180C4F260
	|-TaskCompletionSource<bool>..ctor
	|
	|-RVA: 0xC4F920 Offset: 0xC4EB20 VA: 0x180C4F920
	|-TaskCompletionSource<int>..ctor
	|
	|-RVA: 0xC4F300 Offset: 0xC4E500 VA: 0x180C4F300
	|-TaskCompletionSource<long>..ctor
	|
	|-RVA: 0xC4F9C0 Offset: 0xC4EBC0 VA: 0x180C4F9C0
	|-TaskCompletionSource<object>..ctor
	|
	|-RVA: 0xC4FA60 Offset: 0xC4EC60 VA: 0x180C4FA60
	|-TaskCompletionSource<SceneInstance>..ctor
	|
	|-RVA: 0xC4F520 Offset: 0xC4E720 VA: 0x180C4F520
	|-TaskCompletionSource<SocketReceiveFromResult>..ctor
	|
	|-RVA: 0xC4F740 Offset: 0xC4E940 VA: 0x180C4F740
	|-TaskCompletionSource<SocketReceiveMessageFromResult>..ctor
	|
	|-RVA: 0xC4F1C0 Offset: 0xC4E3C0 VA: 0x180C4F1C0
	|-TaskCompletionSource<WaitForChangedResult>..ctor
	|
	|-RVA: 0xC4F420 Offset: 0xC4E620 VA: 0x180C4F420
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	|-TaskCompletionSource<bool>.get_Task
	|-TaskCompletionSource<int>.get_Task
	|-TaskCompletionSource<long>.get_Task
	|-TaskCompletionSource<object>.get_Task
	|-TaskCompletionSource<SceneInstance>.get_Task
	|-TaskCompletionSource<SocketReceiveFromResult>.get_Task
	|-TaskCompletionSource<SocketReceiveMessageFromResult>.get_Task
	|-TaskCompletionSource<WaitForChangedResult>.get_Task
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.get_Task
	*/

	// RVA: -1 Offset: -1
	private void SpinUntilCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4DC70 Offset: 0xC4CE70 VA: 0x180C4DC70
	|-TaskCompletionSource<bool>.SpinUntilCompleted
	|
	|-RVA: 0xC4DB70 Offset: 0xC4CD70 VA: 0x180C4DB70
	|-TaskCompletionSource<int>.SpinUntilCompleted
	|
	|-RVA: 0xC4DAF0 Offset: 0xC4CCF0 VA: 0x180C4DAF0
	|-TaskCompletionSource<long>.SpinUntilCompleted
	|
	|-RVA: 0xC4D970 Offset: 0xC4CB70 VA: 0x180C4D970
	|-TaskCompletionSource<object>.SpinUntilCompleted
	|
	|-RVA: 0xC4DCF0 Offset: 0xC4CEF0 VA: 0x180C4DCF0
	|-TaskCompletionSource<SceneInstance>.SpinUntilCompleted
	|
	|-RVA: 0xC4D9F0 Offset: 0xC4CBF0 VA: 0x180C4D9F0
	|-TaskCompletionSource<SocketReceiveFromResult>.SpinUntilCompleted
	|
	|-RVA: 0xC4DA70 Offset: 0xC4CC70 VA: 0x180C4DA70
	|-TaskCompletionSource<SocketReceiveMessageFromResult>.SpinUntilCompleted
	|
	|-RVA: 0xC4DBF0 Offset: 0xC4CDF0 VA: 0x180C4DBF0
	|-TaskCompletionSource<WaitForChangedResult>.SpinUntilCompleted
	|
	|-RVA: 0xC4DD70 Offset: 0xC4CF70 VA: 0x180C4DD70
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.SpinUntilCompleted
	*/

	// RVA: -1 Offset: -1
	public bool TrySetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4E720 Offset: 0xC4D920 VA: 0x180C4E720
	|-TaskCompletionSource<bool>.TrySetException
	|
	|-RVA: 0xC4E9F0 Offset: 0xC4DBF0 VA: 0x180C4E9F0
	|-TaskCompletionSource<int>.TrySetException
	|
	|-RVA: 0xC4E960 Offset: 0xC4DB60 VA: 0x180C4E960
	|-TaskCompletionSource<long>.TrySetException
	|
	|-RVA: 0xC4E7B0 Offset: 0xC4D9B0 VA: 0x180C4E7B0
	|-TaskCompletionSource<object>.TrySetException
	|
	|-RVA: 0xC4E840 Offset: 0xC4DA40 VA: 0x180C4E840
	|-TaskCompletionSource<SceneInstance>.TrySetException
	|
	|-RVA: 0xC4E8D0 Offset: 0xC4DAD0 VA: 0x180C4E8D0
	|-TaskCompletionSource<SocketReceiveFromResult>.TrySetException
	|
	|-RVA: 0xC4E690 Offset: 0xC4D890 VA: 0x180C4E690
	|-TaskCompletionSource<SocketReceiveMessageFromResult>.TrySetException
	|
	|-RVA: 0xC4EA80 Offset: 0xC4DC80 VA: 0x180C4EA80
	|-TaskCompletionSource<WaitForChangedResult>.TrySetException
	|
	|-RVA: 0xC4E600 Offset: 0xC4D800 VA: 0x180C4E600
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.TrySetException
	*/

	// RVA: -1 Offset: -1
	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4CF20 Offset: 0xC4C120 VA: 0x180C4CF20
	|-TaskCompletionSource<bool>.SetException
	|
	|-RVA: 0xC4D080 Offset: 0xC4C280 VA: 0x180C4D080
	|-TaskCompletionSource<int>.SetException
	|
	|-RVA: 0xC4D250 Offset: 0xC4C450 VA: 0x180C4D250
	|-TaskCompletionSource<long>.SetException
	|
	|-RVA: 0xC4D300 Offset: 0xC4C500 VA: 0x180C4D300
	|-TaskCompletionSource<object>.SetException
	|
	|-RVA: 0xC4D130 Offset: 0xC4C330 VA: 0x180C4D130
	|-TaskCompletionSource<SceneInstance>.SetException
	|
	|-RVA: 0xC4D3B0 Offset: 0xC4C5B0 VA: 0x180C4D3B0
	|-TaskCompletionSource<SocketReceiveFromResult>.SetException
	|
	|-RVA: 0xC4CFD0 Offset: 0xC4C1D0 VA: 0x180C4CFD0
	|-TaskCompletionSource<SocketReceiveMessageFromResult>.SetException
	|
	|-RVA: 0xC4CE70 Offset: 0xC4C070 VA: 0x180C4CE70
	|-TaskCompletionSource<WaitForChangedResult>.SetException
	|
	|-RVA: 0xC4D1E0 Offset: 0xC4C3E0 VA: 0x180C4D1E0
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.SetException
	*/

	// RVA: -1 Offset: -1
	public bool TrySetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4EB10 Offset: 0xC4DD10 VA: 0x180C4EB10
	|-TaskCompletionSource<bool>.TrySetResult
	|
	|-RVA: 0xC4EF20 Offset: 0xC4E120 VA: 0x180C4EF20
	|-TaskCompletionSource<int>.TrySetResult
	|
	|-RVA: 0xC4EEC0 Offset: 0xC4E0C0 VA: 0x180C4EEC0
	|-TaskCompletionSource<long>.TrySetResult
	|
	|-RVA: 0xC4ED70 Offset: 0xC4DF70 VA: 0x180C4ED70
	|-TaskCompletionSource<object>.TrySetResult
	|
	|-RVA: 0xC4ED00 Offset: 0xC4DF00 VA: 0x180C4ED00
	|-TaskCompletionSource<SceneInstance>.TrySetResult
	|
	|-RVA: 0xC4EDD0 Offset: 0xC4DFD0 VA: 0x180C4EDD0
	|-TaskCompletionSource<SocketReceiveFromResult>.TrySetResult
	|
	|-RVA: 0xC4EE40 Offset: 0xC4E040 VA: 0x180C4EE40
	|-TaskCompletionSource<SocketReceiveMessageFromResult>.TrySetResult
	|
	|-RVA: 0xC4EC80 Offset: 0xC4DE80 VA: 0x180C4EC80
	|-TaskCompletionSource<WaitForChangedResult>.TrySetResult
	|
	|-RVA: 0xC4EB70 Offset: 0xC4DD70 VA: 0x180C4EB70
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.TrySetResult
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4D870 Offset: 0xC4CA70 VA: 0x180C4D870
	|-TaskCompletionSource<bool>.SetResult
	|
	|-RVA: 0xC4D8F0 Offset: 0xC4CAF0 VA: 0x180C4D8F0
	|-TaskCompletionSource<int>.SetResult
	|
	|-RVA: 0xC4D770 Offset: 0xC4C970 VA: 0x180C4D770
	|-TaskCompletionSource<long>.SetResult
	|
	|-RVA: 0xC4D7F0 Offset: 0xC4C9F0 VA: 0x180C4D7F0
	|-TaskCompletionSource<object>.SetResult
	|
	|-RVA: 0xC4D660 Offset: 0xC4C860 VA: 0x180C4D660
	|-TaskCompletionSource<SceneInstance>.SetResult
	|
	|-RVA: 0xC4D460 Offset: 0xC4C660 VA: 0x180C4D460
	|-TaskCompletionSource<SocketReceiveFromResult>.SetResult
	|
	|-RVA: 0xC4D5D0 Offset: 0xC4C7D0 VA: 0x180C4D5D0
	|-TaskCompletionSource<SocketReceiveMessageFromResult>.SetResult
	|
	|-RVA: 0xC4D6E0 Offset: 0xC4C8E0 VA: 0x180C4D6E0
	|-TaskCompletionSource<WaitForChangedResult>.SetResult
	|
	|-RVA: 0xC4D4E0 Offset: 0xC4C6E0 VA: 0x180C4D4E0
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.SetResult
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCanceled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4E0B0 Offset: 0xC4D2B0 VA: 0x180C4E0B0
	|-TaskCompletionSource<bool>.TrySetCanceled
	|
	|-RVA: 0xC4E490 Offset: 0xC4D690 VA: 0x180C4E490
	|-TaskCompletionSource<int>.TrySetCanceled
	|
	|-RVA: 0xC4DE60 Offset: 0xC4D060 VA: 0x180C4DE60
	|-TaskCompletionSource<long>.TrySetCanceled
	|
	|-RVA: 0xC4DEE0 Offset: 0xC4D0E0 VA: 0x180C4DEE0
	|-TaskCompletionSource<object>.TrySetCanceled
	|
	|-RVA: 0xC4E510 Offset: 0xC4D710 VA: 0x180C4E510
	|-TaskCompletionSource<SceneInstance>.TrySetCanceled
	|
	|-RVA: 0xC4E210 Offset: 0xC4D410 VA: 0x180C4E210
	|-TaskCompletionSource<SocketReceiveFromResult>.TrySetCanceled
	|
	|-RVA: 0xC4E380 Offset: 0xC4D580 VA: 0x180C4E380
	|-TaskCompletionSource<SocketReceiveMessageFromResult>.TrySetCanceled
	|
	|-RVA: 0xC4E300 Offset: 0xC4D500 VA: 0x180C4E300
	|-TaskCompletionSource<WaitForChangedResult>.TrySetCanceled
	|
	|-RVA: 0xC4E470 Offset: 0xC4D670 VA: 0x180C4E470
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCanceled(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4DFD0 Offset: 0xC4D1D0 VA: 0x180C4DFD0
	|-TaskCompletionSource<bool>.TrySetCanceled
	|
	|-RVA: 0xC4DDF0 Offset: 0xC4CFF0 VA: 0x180C4DDF0
	|-TaskCompletionSource<int>.TrySetCanceled
	|
	|-RVA: 0xC4E590 Offset: 0xC4D790 VA: 0x180C4E590
	|-TaskCompletionSource<long>.TrySetCanceled
	|
	|-RVA: 0xC4E290 Offset: 0xC4D490 VA: 0x180C4E290
	|-TaskCompletionSource<object>.TrySetCanceled
	|
	|-RVA: 0xC4E400 Offset: 0xC4D600 VA: 0x180C4E400
	|-TaskCompletionSource<SceneInstance>.TrySetCanceled
	|
	|-RVA: 0xC4E130 Offset: 0xC4D330 VA: 0x180C4E130
	|-TaskCompletionSource<SocketReceiveFromResult>.TrySetCanceled
	|
	|-RVA: 0xC4E1A0 Offset: 0xC4D3A0 VA: 0x180C4E1A0
	|-TaskCompletionSource<SocketReceiveMessageFromResult>.TrySetCanceled
	|
	|-RVA: 0xC4DF60 Offset: 0xC4D160 VA: 0x180C4DF60
	|-TaskCompletionSource<WaitForChangedResult>.TrySetCanceled
	|
	|-RVA: 0xC4E040 Offset: 0xC4D240 VA: 0x180C4E040
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public void SetCanceled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4C9F0 Offset: 0xC4BBF0 VA: 0x180C4C9F0
	|-TaskCompletionSource<bool>.SetCanceled
	|
	|-RVA: 0xC4CC30 Offset: 0xC4BE30 VA: 0x180C4CC30
	|-TaskCompletionSource<int>.SetCanceled
	|
	|-RVA: 0xC4CCC0 Offset: 0xC4BEC0 VA: 0x180C4CCC0
	|-TaskCompletionSource<long>.SetCanceled
	|
	|-RVA: 0xC4CB10 Offset: 0xC4BD10 VA: 0x180C4CB10
	|-TaskCompletionSource<object>.SetCanceled
	|
	|-RVA: 0xC4CA80 Offset: 0xC4BC80 VA: 0x180C4CA80
	|-TaskCompletionSource<SceneInstance>.SetCanceled
	|
	|-RVA: 0xC4CD50 Offset: 0xC4BF50 VA: 0x180C4CD50
	|-TaskCompletionSource<SocketReceiveFromResult>.SetCanceled
	|
	|-RVA: 0xC4CDE0 Offset: 0xC4BFE0 VA: 0x180C4CDE0
	|-TaskCompletionSource<SocketReceiveMessageFromResult>.SetCanceled
	|
	|-RVA: 0xC4CBA0 Offset: 0xC4BDA0 VA: 0x180C4CBA0
	|-TaskCompletionSource<WaitForChangedResult>.SetCanceled
	|
	|-RVA: 0xC4C9B0 Offset: 0xC4BBB0 VA: 0x180C4C9B0
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.SetCanceled
	*/
}

// Namespace: System.Threading.Tasks
[Serializable]
public class TaskSchedulerException : Exception // TypeDefIndex: 3396
{
	// Methods

	// RVA: 0x15A34B0 Offset: 0x15A26B0 VA: 0x1815A34B0
	public void .ctor() { }

	// RVA: 0x15A3510 Offset: 0x15A2710 VA: 0x1815A3510
	public void .ctor(Exception innerException) { }

	// RVA: 0x15A3430 Offset: 0x15A2630 VA: 0x1815A3430
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: 
private sealed class TaskToApm.TaskWrapperAsyncResult : IAsyncResult // TypeDefIndex: 3397
{
	// Fields
	internal readonly Task Task; // 0x10
	private readonly object _state; // 0x18
	private readonly bool _completedSynchronously; // 0x20

	// Properties
	private object System.IAsyncResult.AsyncState { get; }
	private bool System.IAsyncResult.CompletedSynchronously { get; }
	private bool System.IAsyncResult.IsCompleted { get; }
	private WaitHandle System.IAsyncResult.AsyncWaitHandle { get; }

	// Methods

	// RVA: 0x15A45E0 Offset: 0x15A37E0 VA: 0x1815A45E0
	internal void .ctor(Task task, object state, bool completedSynchronously) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	private object System.IAsyncResult.get_AsyncState() { }

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0 Slot: 7
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x15A4580 Offset: 0x15A3780 VA: 0x1815A4580 Slot: 4
	private bool System.IAsyncResult.get_IsCompleted() { }

	// RVA: 0x15A44C0 Offset: 0x15A36C0 VA: 0x1815A44C0 Slot: 5
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TaskToApm.<>c__DisplayClass3_0 // TypeDefIndex: 3398
{
	// Fields
	public AsyncCallback callback; // 0x10
	public IAsyncResult asyncResult; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x159D700 Offset: 0x159C900 VA: 0x18159D700
	internal void <InvokeCallbackWhenTaskCompletes>b__0() { }
}

// Namespace: System.Threading.Tasks
internal static class TaskToApm // TypeDefIndex: 3399
{
	// Methods

	// RVA: 0x15A40F0 Offset: 0x15A32F0 VA: 0x1815A40F0
	public static IAsyncResult Begin(Task task, AsyncCallback callback, object state) { }

	// RVA: 0x15A42D0 Offset: 0x15A34D0 VA: 0x1815A42D0
	public static void End(IAsyncResult asyncResult) { }

	// RVA: -1 Offset: -1
	public static TResult End<TResult>(IAsyncResult asyncResult) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA83570 Offset: 0xA82770 VA: 0x180A83570
	|-TaskToApm.End<int>
	|
	|-RVA: 0xA83690 Offset: 0xA82890 VA: 0x180A83690
	|-TaskToApm.End<object>
	|
	|-RVA: 0xA833F0 Offset: 0xA825F0 VA: 0x180A833F0
	|-TaskToApm.End<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x15A43C0 Offset: 0x15A35C0 VA: 0x1815A43C0
	private static void InvokeCallbackWhenTaskCompletes(Task antecedent, AsyncCallback callback, IAsyncResult asyncResult) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ValueTask.ValueTaskSourceAsTask.<>c // TypeDefIndex: 3400
{
	// Fields
	public static readonly ValueTask.ValueTaskSourceAsTask.<>c <>9; // 0x0

	// Methods

	// RVA: 0x15B0BE0 Offset: 0x15AFDE0 VA: 0x1815B0BE0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x15B06B0 Offset: 0x15AF8B0 VA: 0x1815B06B0
	internal void <.cctor>b__4_0(object state) { }
}

// Namespace: 
private sealed class ValueTask.ValueTaskSourceAsTask : Task<VoidTaskResult> // TypeDefIndex: 3401
{
	// Fields
	private static readonly Action<object> s_completionAction; // 0x0
	private IValueTaskSource _source; // 0x58
	private readonly short _token; // 0x60

	// Methods

	// RVA: 0x15B0DC0 Offset: 0x15AFFC0 VA: 0x1815B0DC0
	public void .ctor(IValueTaskSource source, short token) { }

	// RVA: 0x15B0D00 Offset: 0x15AFF00 VA: 0x1815B0D00
	private static void .cctor() { }
}

// Namespace: System.Threading.Tasks
[IsReadOnly]
[AsyncMethodBuilder(typeof(AsyncValueTaskMethodBuilder))]
public struct ValueTask : IEquatable<ValueTask> // TypeDefIndex: 3402
{
	// Fields
	private static readonly Task s_canceledTask; // 0x0
	internal readonly object _obj; // 0x0
	internal readonly short _token; // 0x8
	internal readonly bool _continueOnCapturedContext; // 0xA

	// Properties
	internal static Task CompletedTask { get; }
	public bool IsCompleted { get; }
	public bool IsCompletedSuccessfully { get; }

	// Methods

	// RVA: 0x15B1630 Offset: 0x15B0830 VA: 0x1815B1630
	internal static Task get_CompletedTask() { }

	// RVA: 0x15B15F0 Offset: 0x15B07F0 VA: 0x1815B15F0
	public void .ctor(Task task) { }

	// RVA: 0x15B1590 Offset: 0x15B0790 VA: 0x1815B1590
	public void .ctor(IValueTaskSource source, short token) { }

	// RVA: 0x15B15E0 Offset: 0x15B07E0 VA: 0x1815B15E0
	private void .ctor(object obj, short token, bool continueOnCapturedContext) { }

	// RVA: 0x15B1100 Offset: 0x15B0300 VA: 0x1815B1100 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15B1030 Offset: 0x15B0230 VA: 0x1815B1030 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15B10E0 Offset: 0x15B02E0 VA: 0x1815B10E0 Slot: 4
	public bool Equals(ValueTask other) { }

	// RVA: 0x15B0F20 Offset: 0x15B0120 VA: 0x1815B0F20
	public Task AsTask() { }

	// RVA: 0x15B1120 Offset: 0x15B0320 VA: 0x1815B1120
	private Task GetTaskForValueTaskSource(IValueTaskSource t) { }

	// RVA: 0x15B1790 Offset: 0x15B0990 VA: 0x1815B1790
	public bool get_IsCompleted() { }

	// RVA: 0x15B16C0 Offset: 0x15B08C0 VA: 0x1815B16C0
	public bool get_IsCompletedSuccessfully() { }

	[StackTraceHidden]
	// RVA: 0x15B1420 Offset: 0x15B0620 VA: 0x1815B1420
	internal void ThrowIfCompletedUnsuccessfully() { }

	// RVA: 0x4354A0 Offset: 0x4346A0 VA: 0x1804354A0
	public ValueTaskAwaiter GetAwaiter() { }

	// RVA: 0x15B1000 Offset: 0x15B0200 VA: 0x1815B1000
	public ConfiguredValueTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	// RVA: 0x15B14D0 Offset: 0x15B06D0 VA: 0x1815B14D0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ValueTask.ValueTaskSourceAsTask.<>c<TResult> // TypeDefIndex: 3403
{
	// Fields
	public static readonly ValueTask.ValueTaskSourceAsTask.<>c<TResult> <>9; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08330 Offset: 0xB07530 VA: 0x180B08330
	|-ValueTask.ValueTaskSourceAsTask.<>c<int>..cctor
	|-ValueTask.ValueTaskSourceAsTask.<>c<object>..cctor
	|-ValueTask.ValueTaskSourceAsTask.<>c<ValueWebSocketReceiveResult>..cctor
	|
	|-RVA: 0xB08640 Offset: 0xB07840 VA: 0x180B08640
	|-ValueTask.ValueTaskSourceAsTask.<>c<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-ValueTask.ValueTaskSourceAsTask.<>c<int>..ctor
	|-ValueTask.ValueTaskSourceAsTask.<>c<object>..ctor
	|-ValueTask.ValueTaskSourceAsTask.<>c<ValueWebSocketReceiveResult>..ctor
	|-ValueTask.ValueTaskSourceAsTask.<>c<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <.cctor>b__4_0(object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB07950 Offset: 0xB06B50 VA: 0x180B07950
	|-ValueTask.ValueTaskSourceAsTask.<>c<int>.<.cctor>b__4_0
	|
	|-RVA: 0xB07B40 Offset: 0xB06D40 VA: 0x180B07B40
	|-ValueTask.ValueTaskSourceAsTask.<>c<object>.<.cctor>b__4_0
	|-ValueTask.ValueTaskSourceAsTask.<>c<ValueWebSocketReceiveResult>.<.cctor>b__4_0
	|
	|-RVA: 0xB075D0 Offset: 0xB067D0 VA: 0x180B075D0
	|-ValueTask.ValueTaskSourceAsTask.<>c<__Il2CppFullySharedGenericType>.<.cctor>b__4_0
	*/
}

// Namespace: 
private sealed class ValueTask.ValueTaskSourceAsTask<TResult> : Task<TResult> // TypeDefIndex: 3404
{
	// Fields
	private static readonly Action<object> s_completionAction; // 0x0
	private IValueTaskSource<TResult> _source; // 0x0
	private readonly short _token; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IValueTaskSource<TResult> source, short token) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD15710 Offset: 0xD14910 VA: 0x180D15710
	|-ValueTask.ValueTaskSourceAsTask<int>..ctor
	|
	|-RVA: 0xD15600 Offset: 0xD14800 VA: 0x180D15600
	|-ValueTask.ValueTaskSourceAsTask<object>..ctor
	|
	|-RVA: 0xD15380 Offset: 0xD14580 VA: 0x180D15380
	|-ValueTask.ValueTaskSourceAsTask<ValueWebSocketReceiveResult>..ctor
	|
	|-RVA: 0xD15490 Offset: 0xD14690 VA: 0x180D15490
	|-ValueTask.ValueTaskSourceAsTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD14DC0 Offset: 0xD13FC0 VA: 0x180D14DC0
	|-ValueTask.ValueTaskSourceAsTask<int>..cctor
	|
	|-RVA: 0xD14F30 Offset: 0xD14130 VA: 0x180D14F30
	|-ValueTask.ValueTaskSourceAsTask<object>..cctor
	|
	|-RVA: 0xD15210 Offset: 0xD14410 VA: 0x180D15210
	|-ValueTask.ValueTaskSourceAsTask<ValueWebSocketReceiveResult>..cctor
	|
	|-RVA: 0xD150A0 Offset: 0xD142A0 VA: 0x180D150A0
	|-ValueTask.ValueTaskSourceAsTask<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Threading.Tasks
[AsyncMethodBuilder(typeof(AsyncValueTaskMethodBuilder<TResult>))]
[IsReadOnly]
public struct ValueTask<TResult> : IEquatable<ValueTask<TResult>> // TypeDefIndex: 3405
{
	// Fields
	private static Task<TResult> s_canceledTask; // 0x0
	internal readonly object _obj; // 0x0
	internal readonly TResult _result; // 0x0
	internal readonly short _token; // 0x0
	internal readonly bool _continueOnCapturedContext; // 0x0

	// Properties
	public bool IsCompleted { get; }
	public bool IsCompletedSuccessfully { get; }
	public TResult Result { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD16550 Offset: 0xD15750 VA: 0x180D16550
	|-ValueTask<int>..ctor
	|
	|-RVA: 0xD2D4D0 Offset: 0xD2C6D0 VA: 0x180D2D4D0
	|-ValueTask<object>..ctor
	|-ValueTask<ValueWebSocketReceiveResult>..ctor
	|
	|-RVA: 0xD28E20 Offset: 0xD28020 VA: 0x180D28E20
	|-ValueTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Task<TResult> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD16570 Offset: 0xD15770 VA: 0x180D16570
	|-ValueTask<int>..ctor
	|
	|-RVA: 0xD2D510 Offset: 0xD2C710 VA: 0x180D2D510
	|-ValueTask<object>..ctor
	|-ValueTask<ValueWebSocketReceiveResult>..ctor
	|
	|-RVA: 0xD28FF0 Offset: 0xD281F0 VA: 0x180D28FF0
	|-ValueTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IValueTaskSource<TResult> source, short token) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD165D0 Offset: 0xD157D0 VA: 0x180D165D0
	|-ValueTask<int>..ctor
	|
	|-RVA: 0xD2D480 Offset: 0xD2C680 VA: 0x180D2D480
	|-ValueTask<object>..ctor
	|-ValueTask<ValueWebSocketReceiveResult>..ctor
	|
	|-RVA: 0xD28C90 Offset: 0xD27E90 VA: 0x180D28C90
	|-ValueTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(object obj, TResult result, short token, bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD165B0 Offset: 0xD157B0 VA: 0x180D165B0
	|-ValueTask<int>..ctor
	|
	|-RVA: 0xD2D4F0 Offset: 0xD2C6F0 VA: 0x180D2D4F0
	|-ValueTask<object>..ctor
	|-ValueTask<ValueWebSocketReceiveResult>..ctor
	|
	|-RVA: 0xD29180 Offset: 0xD28380 VA: 0x180D29180
	|-ValueTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD15E30 Offset: 0xD15030 VA: 0x180D15E30
	|-ValueTask<int>.GetHashCode
	|
	|-RVA: 0xD2B810 Offset: 0xD2AA10 VA: 0x180D2B810
	|-ValueTask<object>.GetHashCode
	|
	|-RVA: 0xD2BDE0 Offset: 0xD2AFE0 VA: 0x180D2BDE0
	|-ValueTask<ValueWebSocketReceiveResult>.GetHashCode
	|
	|-RVA: 0xD2B840 Offset: 0xD2AA40 VA: 0x180D2B840
	|-ValueTask<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD15C70 Offset: 0xD14E70 VA: 0x180D15C70
	|-ValueTask<int>.Equals
	|
	|-RVA: 0xD2AE20 Offset: 0xD2A020 VA: 0x180D2AE20
	|-ValueTask<object>.Equals
	|
	|-RVA: 0xD2AAE0 Offset: 0xD29CE0 VA: 0x180D2AAE0
	|-ValueTask<ValueWebSocketReceiveResult>.Equals
	|
	|-RVA: 0xD2AC10 Offset: 0xD29E10 VA: 0x180D2AC10
	|-ValueTask<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTask<TResult> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD15A10 Offset: 0xD14C10 VA: 0x180D15A10
	|-ValueTask<int>.Equals
	|
	|-RVA: 0xD2AD50 Offset: 0xD29F50 VA: 0x180D2AD50
	|-ValueTask<object>.Equals
	|
	|-RVA: 0xD2AF50 Offset: 0xD2A150 VA: 0x180D2AF50
	|-ValueTask<ValueWebSocketReceiveResult>.Equals
	|
	|-RVA: 0xD2B110 Offset: 0xD2A310 VA: 0x180D2B110
	|-ValueTask<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> AsTask() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD15820 Offset: 0xD14A20 VA: 0x180D15820
	|-ValueTask<int>.AsTask
	|
	|-RVA: 0xD2A440 Offset: 0xD29640 VA: 0x180D2A440
	|-ValueTask<object>.AsTask
	|
	|-RVA: 0xD2A050 Offset: 0xD29250 VA: 0x180D2A050
	|-ValueTask<ValueWebSocketReceiveResult>.AsTask
	|
	|-RVA: 0xD2A1A0 Offset: 0xD293A0 VA: 0x180D2A1A0
	|-ValueTask<__Il2CppFullySharedGenericType>.AsTask
	*/

	// RVA: -1 Offset: -1
	private Task<TResult> GetTaskForValueTaskSource(IValueTaskSource<TResult> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD15E90 Offset: 0xD15090 VA: 0x180D15E90
	|-ValueTask<int>.GetTaskForValueTaskSource
	|
	|-RVA: 0xD2BE70 Offset: 0xD2B070 VA: 0x180D2BE70
	|-ValueTask<object>.GetTaskForValueTaskSource
	|
	|-RVA: 0xD2C2B0 Offset: 0xD2B4B0 VA: 0x180D2C2B0
	|-ValueTask<ValueWebSocketReceiveResult>.GetTaskForValueTaskSource
	|
	|-RVA: 0xD2C6F0 Offset: 0xD2B8F0 VA: 0x180D2C6F0
	|-ValueTask<__Il2CppFullySharedGenericType>.GetTaskForValueTaskSource
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD168A0 Offset: 0xD15AA0 VA: 0x180D168A0
	|-ValueTask<int>.get_IsCompleted
	|
	|-RVA: 0xD2D670 Offset: 0xD2C870 VA: 0x180D2D670
	|-ValueTask<object>.get_IsCompleted
	|-ValueTask<ValueWebSocketReceiveResult>.get_IsCompleted
	|
	|-RVA: 0xD29660 Offset: 0xD28860 VA: 0x180D29660
	|-ValueTask<__Il2CppFullySharedGenericType>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompletedSuccessfully() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD16660 Offset: 0xD15860 VA: 0x180D16660
	|-ValueTask<int>.get_IsCompletedSuccessfully
	|
	|-RVA: 0xD2D550 Offset: 0xD2C750 VA: 0x180D2D550
	|-ValueTask<object>.get_IsCompletedSuccessfully
	|-ValueTask<ValueWebSocketReceiveResult>.get_IsCompletedSuccessfully
	|
	|-RVA: 0xD294E0 Offset: 0xD286E0 VA: 0x180D294E0
	|-ValueTask<__Il2CppFullySharedGenericType>.get_IsCompletedSuccessfully
	*/

	// RVA: -1 Offset: -1
	public TResult get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD169C0 Offset: 0xD15BC0 VA: 0x180D169C0
	|-ValueTask<int>.get_Result
	|
	|-RVA: 0xD2D790 Offset: 0xD2C990 VA: 0x180D2D790
	|-ValueTask<object>.get_Result
	|-ValueTask<ValueWebSocketReceiveResult>.get_Result
	|
	|-RVA: 0xD297E0 Offset: 0xD289E0 VA: 0x180D297E0
	|-ValueTask<__Il2CppFullySharedGenericType>.get_Result
	*/

	// RVA: -1 Offset: -1
	public ValueTaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD15D90 Offset: 0xD14F90 VA: 0x180D15D90
	|-ValueTask<int>.GetAwaiter
	|
	|-RVA: 0xD2B650 Offset: 0xD2A850 VA: 0x180D2B650
	|-ValueTask<object>.GetAwaiter
	|-ValueTask<ValueWebSocketReceiveResult>.GetAwaiter
	|
	|-RVA: 0xD2B6B0 Offset: 0xD2A8B0 VA: 0x180D2B6B0
	|-ValueTask<__Il2CppFullySharedGenericType>.GetAwaiter
	*/

	// RVA: -1 Offset: -1
	public ConfiguredValueTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD15970 Offset: 0xD14B70 VA: 0x180D15970
	|-ValueTask<int>.ConfigureAwait
	|
	|-RVA: 0xD2A640 Offset: 0xD29840 VA: 0x180D2A640
	|-ValueTask<object>.ConfigureAwait
	|
	|-RVA: 0xD2A590 Offset: 0xD29790 VA: 0x180D2A590
	|-ValueTask<ValueWebSocketReceiveResult>.ConfigureAwait
	|
	|-RVA: 0xD28810 Offset: 0xD27A10 VA: 0x180D28810
	|-ValueTask<__Il2CppFullySharedGenericType>.ConfigureAwait
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD16390 Offset: 0xD15590 VA: 0x180D16390
	|-ValueTask<int>.ToString
	|
	|-RVA: 0xD2D3B0 Offset: 0xD2C5B0 VA: 0x180D2D3B0
	|-ValueTask<object>.ToString
	|
	|-RVA: 0xD2D2B0 Offset: 0xD2C4B0 VA: 0x180D2D2B0
	|-ValueTask<ValueWebSocketReceiveResult>.ToString
	|
	|-RVA: 0xD2CFE0 Offset: 0xD2C1E0 VA: 0x180D2CFE0
	|-ValueTask<__Il2CppFullySharedGenericType>.ToString
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class BeginEndAwaitableAdapter.<>c // TypeDefIndex: 3406
{
	// Fields
	public static readonly BeginEndAwaitableAdapter.<>c <>9; // 0x0

	// Methods

	// RVA: 0x15B09A0 Offset: 0x15AFBA0 VA: 0x1815B09A0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x15B0610 Offset: 0x15AF810 VA: 0x1815B0610
	internal void <.cctor>b__2_0(IAsyncResult asyncResult) { }
}

// Namespace: System.Threading.Tasks
internal sealed class BeginEndAwaitableAdapter : RendezvousAwaitable<IAsyncResult> // TypeDefIndex: 3407
{
	// Fields
	public static readonly AsyncCallback Callback; // 0x0

	// Methods

	// RVA: 0x159A960 Offset: 0x1599B60 VA: 0x18159A960
	public void .ctor() { }

	// RVA: 0x159A8A0 Offset: 0x1599AA0 VA: 0x18159A8A0
	private static void .cctor() { }
}

// Namespace: System.Threading.Tasks
[Extension]
internal static class TaskAwaiters // TypeDefIndex: 3408
{
	// Methods

	[Extension]
	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	public static ForceAsyncAwaiter ForceAsync(Task task) { }
}

// Namespace: System.Threading.Tasks
[IsReadOnly]
internal struct ForceAsyncAwaiter : ICriticalNotifyCompletion // TypeDefIndex: 3409
{
	// Fields
	private readonly Task _task; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(Task task) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ForceAsyncAwaiter GetAwaiter() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	public bool get_IsCompleted() { }

	// RVA: 0x159CE80 Offset: 0x159C080 VA: 0x18159CE80
	public void GetResult() { }

	// RVA: 0x159CEB0 Offset: 0x159C0B0 VA: 0x18159CEB0 Slot: 4
	public void UnsafeOnCompleted(Action action) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class RendezvousAwaitable.<>c<TResult> // TypeDefIndex: 3410
{
	// Fields
	public static readonly RendezvousAwaitable.<>c<TResult> <>9; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08330 Offset: 0xB07530 VA: 0x180B08330
	|-RendezvousAwaitable.<>c<object>..cctor
	|
	|-RVA: 0xB08640 Offset: 0xB07840 VA: 0x180B08640
	|-RendezvousAwaitable.<>c<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-RendezvousAwaitable.<>c<object>..ctor
	|-RendezvousAwaitable.<>c<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <.cctor>b__20_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-RendezvousAwaitable.<>c<object>.<.cctor>b__20_0
	|-RendezvousAwaitable.<>c<__Il2CppFullySharedGenericType>.<.cctor>b__20_0
	*/
}

// Namespace: System.Threading.Tasks
internal class RendezvousAwaitable<TResult> : ICriticalNotifyCompletion // TypeDefIndex: 3411
{
	// Fields
	private static readonly Action s_completionSentinel; // 0x0
	private Action _continuation; // 0x0
	private ExceptionDispatchInfo _error; // 0x0
	private TResult _result; // 0x0
	[CompilerGenerated]
	private bool <RunContinuationsAsynchronously>k__BackingField; // 0x0

	// Properties
	public bool RunContinuationsAsynchronously { get; set; }
	public bool IsCompleted { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public bool get_RunContinuationsAsynchronously() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	|-RendezvousAwaitable<object>.get_RunContinuationsAsynchronously
	|
	|-RVA: 0xBE4DF0 Offset: 0xBE3FF0 VA: 0x180BE4DF0
	|-RendezvousAwaitable<__Il2CppFullySharedGenericType>.get_RunContinuationsAsynchronously
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_RunContinuationsAsynchronously(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	|-RendezvousAwaitable<object>.set_RunContinuationsAsynchronously
	|
	|-RVA: 0xBE4E20 Offset: 0xBE4020 VA: 0x180BE4E20
	|-RendezvousAwaitable<__Il2CppFullySharedGenericType>.set_RunContinuationsAsynchronously
	*/

	// RVA: -1 Offset: -1
	public RendezvousAwaitable<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	|-RendezvousAwaitable<object>.GetAwaiter
	|-RendezvousAwaitable<__Il2CppFullySharedGenericType>.GetAwaiter
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE4DD0 Offset: 0xBE3FD0 VA: 0x180BE4DD0
	|-RendezvousAwaitable<object>.get_IsCompleted
	|
	|-RVA: 0xBE4D90 Offset: 0xBE3F90 VA: 0x180BE4D90
	|-RendezvousAwaitable<__Il2CppFullySharedGenericType>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE42E0 Offset: 0xBE34E0 VA: 0x180BE42E0
	|-RendezvousAwaitable<object>.GetResult
	|
	|-RVA: 0xBE4320 Offset: 0xBE3520 VA: 0x180BE4320
	|-RendezvousAwaitable<__Il2CppFullySharedGenericType>.GetResult
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE4920 Offset: 0xBE3B20 VA: 0x180BE4920
	|-RendezvousAwaitable<object>.SetResult
	|
	|-RVA: 0xBE4850 Offset: 0xBE3A50 VA: 0x180BE4850
	|-RendezvousAwaitable<__Il2CppFullySharedGenericType>.SetResult
	*/

	// RVA: -1 Offset: -1
	private void NotifyAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE44B0 Offset: 0xBE36B0 VA: 0x180BE44B0
	|-RendezvousAwaitable<object>.NotifyAwaiter
	|
	|-RVA: 0xBE45B0 Offset: 0xBE37B0 VA: 0x180BE45B0
	|-RendezvousAwaitable<__Il2CppFullySharedGenericType>.NotifyAwaiter
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE47D0 Offset: 0xBE39D0 VA: 0x180BE47D0
	|-RendezvousAwaitable<object>.OnCompleted
	|
	|-RVA: 0xBE4710 Offset: 0xBE3910 VA: 0x180BE4710
	|-RendezvousAwaitable<__Il2CppFullySharedGenericType>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE47D0 Offset: 0xBE39D0 VA: 0x180BE47D0
	|-RendezvousAwaitable<object>.UnsafeOnCompleted
	|
	|-RVA: 0xBE4A30 Offset: 0xBE3C30 VA: 0x180BE4A30
	|-RendezvousAwaitable<__Il2CppFullySharedGenericType>.UnsafeOnCompleted
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x590DF0 Offset: 0x58FFF0 VA: 0x180590DF0
	|-RendezvousAwaitable<object>..ctor
	|
	|-RVA: 0xBE4D30 Offset: 0xBE3F30 VA: 0x180BE4D30
	|-RendezvousAwaitable<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE4BC0 Offset: 0xBE3DC0 VA: 0x180BE4BC0
	|-RendezvousAwaitable<object>..cctor
	|
	|-RVA: 0xBE4A50 Offset: 0xBE3C50 VA: 0x180BE4A50
	|-RendezvousAwaitable<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Threading.Tasks
[Extension]
internal static class DebuggerSupport // TypeDefIndex: 3412
{
	// Fields
	private static readonly LowLevelDictionary<int, Task> s_activeTasks; // 0x0
	private static readonly object s_activeTasksLock; // 0x8

	// Properties
	public static bool LoggingOn { get; }

	// Methods

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	public static bool get_LoggingOn() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void TraceOperationCreation(CausalityTraceLevel traceLevel, Task task, string operationName, ulong relatedContext) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void TraceOperationCompletion(CausalityTraceLevel traceLevel, Task task, AsyncStatus status) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void TraceOperationRelation(CausalityTraceLevel traceLevel, Task task, CausalityRelation relation) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, Task task, CausalitySynchronousWork work) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work) { }

	// RVA: 0x159B0D0 Offset: 0x159A2D0 VA: 0x18159B0D0
	public static void AddToActiveTasks(Task task) { }

	// RVA: 0x159AF90 Offset: 0x159A190 VA: 0x18159AF90
	private static void AddToActiveTasksNonInlined(Task task) { }

	// RVA: 0x159B290 Offset: 0x159A490 VA: 0x18159B290
	public static void RemoveFromActiveTasks(Task task) { }

	// RVA: 0x159B160 Offset: 0x159A360 VA: 0x18159B160
	private static void RemoveFromActiveTasksNonInlined(Task task) { }

	// RVA: 0x159B320 Offset: 0x159A520 VA: 0x18159B320
	private static void .cctor() { }
}

// Namespace: System.Threading.Tasks
[DebuggerTypeProxy(typeof(SystemThreadingTasks_FutureDebugView<TResult>))]
[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}, Result = {DebuggerDisplayResultDescription}")]
public class Task<TResult> : Task // TypeDefIndex: 3413
{
	// Fields
	internal TResult m_result; // 0x0
	private static TaskFactory<TResult> s_defaultFactory; // 0x0

	// Properties
	[DebuggerBrowsable(0)]
	public TResult Result { get; }
	internal TResult ResultOnSuccess { get; }
	public static TaskFactory<TResult> Factory { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC5D990 Offset: 0xC5CB90 VA: 0x180C5D990
	|-Task<ArraySegment<byte>>..ctor
	|
	|-RVA: 0xC69A20 Offset: 0xC68C20 VA: 0x180C69A20
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0xC67570 Offset: 0xC66770 VA: 0x180C67570
	|-Task<Nullable<JsonElement>>..ctor
	|
	|-RVA: 0xC6BD60 Offset: 0xC6AF60 VA: 0x180C6BD60
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0xC680C0 Offset: 0xC672C0 VA: 0x180C680C0
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0xC6AF70 Offset: 0xC6A170 VA: 0x180C6AF70
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0xC68710 Offset: 0xC67910 VA: 0x180C68710
	|-Task<bool>..ctor
	|
	|-RVA: 0xC66F00 Offset: 0xC66100 VA: 0x180C66F00
	|-Task<int>..ctor
	|
	|-RVA: 0xC6A9C0 Offset: 0xC69BC0 VA: 0x180C6A9C0
	|-Task<Int32Enum>..ctor
	|
	|-RVA: 0xC69370 Offset: 0xC68570 VA: 0x180C69370
	|-Task<long>..ctor
	|
	|-RVA: 0xC691D0 Offset: 0xC683D0 VA: 0x180C691D0
	|-Task<JsonElement>..ctor
	|
	|-RVA: 0xC67870 Offset: 0xC66A70 VA: 0x180C67870
	|-Task<object>..ctor
	|
	|-RVA: 0xC67FA0 Offset: 0xC671A0 VA: 0x180C67FA0
	|-Task<SceneInstance>..ctor
	|
	|-RVA: 0xC6AC80 Offset: 0xC69E80 VA: 0x180C6AC80
	|-Task<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0xC67650 Offset: 0xC66850 VA: 0x180C67650
	|-Task<SocketReceiveFromResult>..ctor
	|
	|-RVA: 0xC69DC0 Offset: 0xC68FC0 VA: 0x180C69DC0
	|-Task<SocketReceiveMessageFromResult>..ctor
	|
	|-RVA: 0xC6B180 Offset: 0xC6A380 VA: 0x180C6B180
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0xC68070 Offset: 0xC67270 VA: 0x180C68070
	|-Task<ValueWebSocketReceiveResult>..ctor
	|
	|-RVA: 0xC67B00 Offset: 0xC66D00 VA: 0x180C67B00
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0xC6B340 Offset: 0xC6A540 VA: 0x180C6B340
	|-Task<WaitForChangedResult>..ctor
	|
	|-RVA: 0xC6AE10 Offset: 0xC6A010 VA: 0x180C6AE10
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(object state, TaskCreationOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC5D9E0 Offset: 0xC5CBE0 VA: 0x180C5D9E0
	|-Task<ArraySegment<byte>>..ctor
	|
	|-RVA: 0xC6B5A0 Offset: 0xC6A7A0 VA: 0x180C6B5A0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0xC68D60 Offset: 0xC67F60 VA: 0x180C68D60
	|-Task<Nullable<JsonElement>>..ctor
	|
	|-RVA: 0xC6A6B0 Offset: 0xC698B0 VA: 0x180C6A6B0
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0xC69020 Offset: 0xC68220 VA: 0x180C69020
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0xC6B390 Offset: 0xC6A590 VA: 0x180C6B390
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0xC67F20 Offset: 0xC67120 VA: 0x180C67F20
	|-Task<bool>..ctor
	|
	|-RVA: 0xC67B50 Offset: 0xC66D50 VA: 0x180C67B50
	|-Task<int>..ctor
	|
	|-RVA: 0xC67740 Offset: 0xC66940 VA: 0x180C67740
	|-Task<Int32Enum>..ctor
	|
	|-RVA: 0xC6A190 Offset: 0xC69390 VA: 0x180C6A190
	|-Task<long>..ctor
	|
	|-RVA: 0xC66E80 Offset: 0xC66080 VA: 0x180C66E80
	|-Task<JsonElement>..ctor
	|
	|-RVA: 0xC69150 Offset: 0xC68350 VA: 0x180C69150
	|-Task<object>..ctor
	|
	|-RVA: 0xC6A110 Offset: 0xC69310 VA: 0x180C6A110
	|-Task<SceneInstance>..ctor
	|
	|-RVA: 0xC67190 Offset: 0xC66390 VA: 0x180C67190
	|-Task<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0xC68AB0 Offset: 0xC67CB0 VA: 0x180C68AB0
	|-Task<SocketReceiveFromResult>..ctor
	|
	|-RVA: 0xC6A000 Offset: 0xC69200 VA: 0x180C6A000
	|-Task<SocketReceiveMessageFromResult>..ctor
	|
	|-RVA: 0xC6B100 Offset: 0xC6A300 VA: 0x180C6B100
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0xC67FF0 Offset: 0xC671F0 VA: 0x180C67FF0
	|-Task<ValueWebSocketReceiveResult>..ctor
	|
	|-RVA: 0xC69550 Offset: 0xC68750 VA: 0x180C69550
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0xC69EF0 Offset: 0xC690F0 VA: 0x180C69EF0
	|-Task<WaitForChangedResult>..ctor
	|
	|-RVA: 0xC67BD0 Offset: 0xC66DD0 VA: 0x180C67BD0
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC5D890 Offset: 0xC5CA90 VA: 0x180C5D890
	|-Task<ArraySegment<byte>>..ctor
	|
	|-RVA: 0xC66FE0 Offset: 0xC661E0 VA: 0x180C66FE0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0xC67210 Offset: 0xC66410 VA: 0x180C67210
	|-Task<Nullable<JsonElement>>..ctor
	|
	|-RVA: 0xC68570 Offset: 0xC67770 VA: 0x180C68570
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0xC697A0 Offset: 0xC689A0 VA: 0x180C697A0
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0xC693C0 Offset: 0xC685C0 VA: 0x180C693C0
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0xC6B8B0 Offset: 0xC6AAB0 VA: 0x180C6B8B0
	|-Task<bool>..ctor
	|
	|-RVA: 0xC6A3A0 Offset: 0xC695A0 VA: 0x180C6A3A0
	|-Task<int>..ctor
	|
	|-RVA: 0xC67E00 Offset: 0xC67000 VA: 0x180C67E00
	|-Task<Int32Enum>..ctor
	|
	|-RVA: 0xC69300 Offset: 0xC68500 VA: 0x180C69300
	|-Task<long>..ctor
	|
	|-RVA: 0xC68390 Offset: 0xC67590 VA: 0x180C68390
	|-Task<JsonElement>..ctor
	|
	|-RVA: 0xC6A510 Offset: 0xC69710 VA: 0x180C6A510
	|-Task<object>..ctor
	|
	|-RVA: 0xC6B6B0 Offset: 0xC6A8B0 VA: 0x180C6B6B0
	|-Task<SceneInstance>..ctor
	|
	|-RVA: 0xC6ACD0 Offset: 0xC69ED0 VA: 0x180C6ACD0
	|-Task<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0xC698D0 Offset: 0xC68AD0 VA: 0x180C698D0
	|-Task<SocketReceiveFromResult>..ctor
	|
	|-RVA: 0xC6AEF0 Offset: 0xC6A0F0 VA: 0x180C6AEF0
	|-Task<SocketReceiveMessageFromResult>..ctor
	|
	|-RVA: 0xC6A4A0 Offset: 0xC696A0 VA: 0x180C6A4A0
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0xC66E10 Offset: 0xC66010 VA: 0x180C66E10
	|-Task<ValueWebSocketReceiveResult>..ctor
	|
	|-RVA: 0xC68B30 Offset: 0xC67D30 VA: 0x180C68B30
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0xC69440 Offset: 0xC68640 VA: 0x180C69440
	|-Task<WaitForChangedResult>..ctor
	|
	|-RVA: 0xC673D0 Offset: 0xC665D0 VA: 0x180C673D0
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC5D900 Offset: 0xC5CB00 VA: 0x180C5D900
	|-Task<ArraySegment<byte>>..ctor
	|
	|-RVA: 0xC6A810 Offset: 0xC69A10 VA: 0x180C6A810
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0xC6A610 Offset: 0xC69810 VA: 0x180C6A610
	|-Task<Nullable<JsonElement>>..ctor
	|
	|-RVA: 0xC675C0 Offset: 0xC667C0 VA: 0x180C675C0
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0xC68BA0 Offset: 0xC67DA0 VA: 0x180C68BA0
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0xC68670 Offset: 0xC67870 VA: 0x180C68670
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0xC695D0 Offset: 0xC687D0 VA: 0x180C695D0
	|-Task<bool>..ctor
	|
	|-RVA: 0xC6BCD0 Offset: 0xC6AED0 VA: 0x180C6BCD0
	|-Task<int>..ctor
	|
	|-RVA: 0xC68CD0 Offset: 0xC67ED0 VA: 0x180C68CD0
	|-Task<Int32Enum>..ctor
	|
	|-RVA: 0xC674E0 Offset: 0xC666E0 VA: 0x180C674E0
	|-Task<long>..ctor
	|
	|-RVA: 0xC6A410 Offset: 0xC69610 VA: 0x180C6A410
	|-Task<JsonElement>..ctor
	|
	|-RVA: 0xC67C50 Offset: 0xC66E50 VA: 0x180C67C50
	|-Task<object>..ctor
	|
	|-RVA: 0xC6A580 Offset: 0xC69780 VA: 0x180C6A580
	|-Task<SceneInstance>..ctor
	|
	|-RVA: 0xC67CE0 Offset: 0xC66EE0 VA: 0x180C67CE0
	|-Task<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0xC6AE60 Offset: 0xC6A060 VA: 0x180C6AE60
	|-Task<SocketReceiveFromResult>..ctor
	|
	|-RVA: 0xC687F0 Offset: 0xC679F0 VA: 0x180C687F0
	|-Task<SocketReceiveMessageFromResult>..ctor
	|
	|-RVA: 0xC66F50 Offset: 0xC66150 VA: 0x180C66F50
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0xC6B1D0 Offset: 0xC6A3D0 VA: 0x180C6B1D0
	|-Task<ValueWebSocketReceiveResult>..ctor
	|
	|-RVA: 0xC6A080 Offset: 0xC69280 VA: 0x180C6A080
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0xC676A0 Offset: 0xC668A0 VA: 0x180C676A0
	|-Task<WaitForChangedResult>..ctor
	|
	|-RVA: 0xC6BA40 Offset: 0xC6AC40 VA: 0x180C6BA40
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC5D720 Offset: 0xC5C920 VA: 0x180C5D720
	|-Task<ArraySegment<byte>>..ctor
	|
	|-RVA: 0xC68490 Offset: 0xC67690 VA: 0x180C68490
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0xC6B410 Offset: 0xC6A610 VA: 0x180C6B410
	|-Task<Nullable<JsonElement>>..ctor
	|
	|-RVA: 0xC6B260 Offset: 0xC6A460 VA: 0x180C6B260
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0xC6A730 Offset: 0xC69930 VA: 0x180C6A730
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0xC69940 Offset: 0xC68B40 VA: 0x180C69940
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0xC6B7D0 Offset: 0xC6A9D0 VA: 0x180C6B7D0
	|-Task<bool>..ctor
	|
	|-RVA: 0xC69CE0 Offset: 0xC68EE0 VA: 0x180C69CE0
	|-Task<int>..ctor
	|
	|-RVA: 0xC66D30 Offset: 0xC65F30 VA: 0x180C66D30
	|-Task<Int32Enum>..ctor
	|
	|-RVA: 0xC6ABA0 Offset: 0xC69DA0 VA: 0x180C6ABA0
	|-Task<long>..ctor
	|
	|-RVA: 0xC68890 Offset: 0xC67A90 VA: 0x180C68890
	|-Task<JsonElement>..ctor
	|
	|-RVA: 0xC69220 Offset: 0xC68420 VA: 0x180C69220
	|-Task<object>..ctor
	|
	|-RVA: 0xC68F40 Offset: 0xC68140 VA: 0x180C68F40
	|-Task<SceneInstance>..ctor
	|
	|-RVA: 0xC6BB60 Offset: 0xC6AD60 VA: 0x180C6BB60
	|-Task<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0xC6A210 Offset: 0xC69410 VA: 0x180C6A210
	|-Task<SocketReceiveFromResult>..ctor
	|
	|-RVA: 0xC69A70 Offset: 0xC68C70 VA: 0x180C69A70
	|-Task<SocketReceiveMessageFromResult>..ctor
	|
	|-RVA: 0xC6AA10 Offset: 0xC69C10 VA: 0x180C6AA10
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0xC69C00 Offset: 0xC68E00 VA: 0x180C69C00
	|-Task<ValueWebSocketReceiveResult>..ctor
	|
	|-RVA: 0xC69E10 Offset: 0xC69010 VA: 0x180C69E10
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0xC67A20 Offset: 0xC66C20 VA: 0x180C67A20
	|-Task<WaitForChangedResult>..ctor
	|
	|-RVA: 0xC6AD40 Offset: 0xC69F40 VA: 0x180C6AD40
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC5DA60 Offset: 0xC5CC60 VA: 0x180C5DA60
	|-Task<ArraySegment<byte>>..ctor
	|
	|-RVA: 0xC6A2F0 Offset: 0xC694F0 VA: 0x180C6A2F0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0xC69B50 Offset: 0xC68D50 VA: 0x180C69B50
	|-Task<Nullable<JsonElement>>..ctor
	|
	|-RVA: 0xC67970 Offset: 0xC66B70 VA: 0x180C67970
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0xC68E90 Offset: 0xC68090 VA: 0x180C68E90
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0xC6B720 Offset: 0xC6A920 VA: 0x180C6B720
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0xC67050 Offset: 0xC66250 VA: 0x180C67050
	|-Task<bool>..ctor
	|
	|-RVA: 0xC690A0 Offset: 0xC682A0 VA: 0x180C690A0
	|-Task<int>..ctor
	|
	|-RVA: 0xC67320 Offset: 0xC66520 VA: 0x180C67320
	|-Task<Int32Enum>..ctor
	|
	|-RVA: 0xC6AAF0 Offset: 0xC69CF0 VA: 0x180C6AAF0
	|-Task<long>..ctor
	|
	|-RVA: 0xC67E70 Offset: 0xC67070 VA: 0x180C67E70
	|-Task<JsonElement>..ctor
	|
	|-RVA: 0xC68250 Offset: 0xC67450 VA: 0x180C68250
	|-Task<object>..ctor
	|
	|-RVA: 0xC6B4F0 Offset: 0xC6A6F0 VA: 0x180C6B4F0
	|-Task<SceneInstance>..ctor
	|
	|-RVA: 0xC68DE0 Offset: 0xC67FE0 VA: 0x180C68DE0
	|-Task<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0xC69820 Offset: 0xC68A20 VA: 0x180C69820
	|-Task<SocketReceiveFromResult>..ctor
	|
	|-RVA: 0xC69660 Offset: 0xC68860 VA: 0x180C69660
	|-Task<SocketReceiveMessageFromResult>..ctor
	|
	|-RVA: 0xC678C0 Offset: 0xC66AC0 VA: 0x180C678C0
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0xC68A00 Offset: 0xC67C00 VA: 0x180C68A00
	|-Task<ValueWebSocketReceiveResult>..ctor
	|
	|-RVA: 0xC68110 Offset: 0xC67310 VA: 0x180C68110
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0xC6AFC0 Offset: 0xC6A1C0 VA: 0x180C6AFC0
	|-Task<WaitForChangedResult>..ctor
	|
	|-RVA: 0xC677C0 Offset: 0xC669C0 VA: 0x180C677C0
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC5D800 Offset: 0xC5CA00 VA: 0x180C5D800
	|-Task<ArraySegment<byte>>..ctor
	|
	|-RVA: 0xC681C0 Offset: 0xC673C0 VA: 0x180C681C0
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0xC6BC40 Offset: 0xC6AE40 VA: 0x180C6BC40
	|-Task<Nullable<JsonElement>>..ctor
	|
	|-RVA: 0xC68760 Offset: 0xC67960 VA: 0x180C68760
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0xC69F70 Offset: 0xC69170 VA: 0x180C69F70
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0xC6B920 Offset: 0xC6AB20 VA: 0x180C6B920
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0xC6B620 Offset: 0xC6A820 VA: 0x180C6B620
	|-Task<bool>..ctor
	|
	|-RVA: 0xC67100 Offset: 0xC66300 VA: 0x180C67100
	|-Task<int>..ctor
	|
	|-RVA: 0xC68300 Offset: 0xC67500 VA: 0x180C68300
	|-Task<Int32Enum>..ctor
	|
	|-RVA: 0xC68C40 Offset: 0xC67E40 VA: 0x180C68C40
	|-Task<long>..ctor
	|
	|-RVA: 0xC68400 Offset: 0xC67600 VA: 0x180C68400
	|-Task<JsonElement>..ctor
	|
	|-RVA: 0xC69710 Offset: 0xC68910 VA: 0x180C69710
	|-Task<object>..ctor
	|
	|-RVA: 0xC685E0 Offset: 0xC677E0 VA: 0x180C685E0
	|-Task<SceneInstance>..ctor
	|
	|-RVA: 0xC67290 Offset: 0xC66490 VA: 0x180C67290
	|-Task<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0xC67D70 Offset: 0xC66F70 VA: 0x180C67D70
	|-Task<SocketReceiveFromResult>..ctor
	|
	|-RVA: 0xC6A8A0 Offset: 0xC69AA0 VA: 0x180C6A8A0
	|-Task<SocketReceiveMessageFromResult>..ctor
	|
	|-RVA: 0xC6B070 Offset: 0xC6A270 VA: 0x180C6B070
	|-Task<UdpReceiveResult>..ctor
	|
	|-RVA: 0xC6A930 Offset: 0xC69B30 VA: 0x180C6A930
	|-Task<ValueWebSocketReceiveResult>..ctor
	|
	|-RVA: 0xC694C0 Offset: 0xC686C0 VA: 0x180C694C0
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0xC68970 Offset: 0xC67B70 VA: 0x180C68970
	|-Task<WaitForChangedResult>..ctor
	|
	|-RVA: 0xC6B9B0 Offset: 0xC6ABB0 VA: 0x180C6B9B0
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> StartNew(Task parent, Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC5D4A0 Offset: 0xC5C6A0 VA: 0x180C5D4A0
	|-Task<ArraySegment<byte>>.StartNew
	|
	|-RVA: 0xC641C0 Offset: 0xC633C0 VA: 0x180C641C0
	|-Task<Nullable<int>>.StartNew
	|
	|-RVA: 0xC631F0 Offset: 0xC623F0 VA: 0x180C631F0
	|-Task<Nullable<JsonElement>>.StartNew
	|
	|-RVA: 0xC64E00 Offset: 0xC64000 VA: 0x180C64E00
	|-Task<ValueTuple<bool, object>>.StartNew
	|
	|-RVA: 0xC664D0 Offset: 0xC656D0 VA: 0x180C664D0
	|-Task<ValueTuple<object, object, int>>.StartNew
	|
	|-RVA: 0xC62E70 Offset: 0xC62070 VA: 0x180C62E70
	|-Task<ValueTuple<object, bool, bool, object, object>>.StartNew
	|
	|-RVA: 0xC633C0 Offset: 0xC625C0 VA: 0x180C633C0
	|-Task<bool>.StartNew
	|
	|-RVA: 0xC65C20 Offset: 0xC64E20 VA: 0x180C65C20
	|-Task<int>.StartNew
	|
	|-RVA: 0xC62790 Offset: 0xC61990 VA: 0x180C62790
	|-Task<Int32Enum>.StartNew
	|
	|-RVA: 0xC66300 Offset: 0xC65500 VA: 0x180C66300
	|-Task<long>.StartNew
	|
	|-RVA: 0xC65180 Offset: 0xC64380 VA: 0x180C65180
	|-Task<JsonElement>.StartNew
	|
	|-RVA: 0xC62260 Offset: 0xC61460 VA: 0x180C62260
	|-Task<object>.StartNew
	|
	|-RVA: 0xC64A70 Offset: 0xC63C70 VA: 0x180C64A70
	|-Task<SceneInstance>.StartNew
	|
	|-RVA: 0xC65880 Offset: 0xC64A80 VA: 0x180C65880
	|-Task<SerializableProjectConfiguration>.StartNew
	|
	|-RVA: 0xC646F0 Offset: 0xC638F0 VA: 0x180C646F0
	|-Task<SocketReceiveFromResult>.StartNew
	|
	|-RVA: 0xC63910 Offset: 0xC62B10 VA: 0x180C63910
	|-Task<SocketReceiveMessageFromResult>.StartNew
	|
	|-RVA: 0xC63590 Offset: 0xC62790 VA: 0x180C63590
	|-Task<UdpReceiveResult>.StartNew
	|
	|-RVA: 0xC63AE0 Offset: 0xC62CE0 VA: 0x180C63AE0
	|-Task<ValueWebSocketReceiveResult>.StartNew
	|
	|-RVA: 0xC65A50 Offset: 0xC64C50 VA: 0x180C65A50
	|-Task<VoidTaskResult>.StartNew
	|
	|-RVA: 0xC656B0 Offset: 0xC648B0 VA: 0x180C656B0
	|-Task<WaitForChangedResult>.StartNew
	|
	|-RVA: 0xC64C40 Offset: 0xC63E40 VA: 0x180C64C40
	|-Task<__Il2CppFullySharedGenericType>.StartNew
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> StartNew(Task parent, Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC5D2F0 Offset: 0xC5C4F0 VA: 0x180C5D2F0
	|-Task<ArraySegment<byte>>.StartNew
	|
	|-RVA: 0xC62CC0 Offset: 0xC61EC0 VA: 0x180C62CC0
	|-Task<Nullable<int>>.StartNew
	|
	|-RVA: 0xC62B10 Offset: 0xC61D10 VA: 0x180C62B10
	|-Task<Nullable<JsonElement>>.StartNew
	|
	|-RVA: 0xC63CB0 Offset: 0xC62EB0 VA: 0x180C63CB0
	|-Task<ValueTuple<bool, object>>.StartNew
	|
	|-RVA: 0xC65350 Offset: 0xC64550 VA: 0x180C65350
	|-Task<ValueTuple<object, object, int>>.StartNew
	|
	|-RVA: 0xC65DF0 Offset: 0xC64FF0 VA: 0x180C65DF0
	|-Task<ValueTuple<object, bool, bool, object, object>>.StartNew
	|
	|-RVA: 0xC63040 Offset: 0xC62240 VA: 0x180C63040
	|-Task<bool>.StartNew
	|
	|-RVA: 0xC62960 Offset: 0xC61B60 VA: 0x180C62960
	|-Task<int>.StartNew
	|
	|-RVA: 0xC65FA0 Offset: 0xC651A0 VA: 0x180C65FA0
	|-Task<Int32Enum>.StartNew
	|
	|-RVA: 0xC64FD0 Offset: 0xC641D0 VA: 0x180C64FD0
	|-Task<long>.StartNew
	|
	|-RVA: 0xC625E0 Offset: 0xC617E0 VA: 0x180C625E0
	|-Task<JsonElement>.StartNew
	|
	|-RVA: 0xC64390 Offset: 0xC63590 VA: 0x180C64390
	|-Task<object>.StartNew
	|
	|-RVA: 0xC65500 Offset: 0xC64700 VA: 0x180C65500
	|-Task<SceneInstance>.StartNew
	|
	|-RVA: 0xC63760 Offset: 0xC62960 VA: 0x180C63760
	|-Task<SerializableProjectConfiguration>.StartNew
	|
	|-RVA: 0xC64010 Offset: 0xC63210 VA: 0x180C64010
	|-Task<SocketReceiveFromResult>.StartNew
	|
	|-RVA: 0xC63E60 Offset: 0xC63060 VA: 0x180C63E60
	|-Task<SocketReceiveMessageFromResult>.StartNew
	|
	|-RVA: 0xC64540 Offset: 0xC63740 VA: 0x180C64540
	|-Task<UdpReceiveResult>.StartNew
	|
	|-RVA: 0xC648C0 Offset: 0xC63AC0 VA: 0x180C648C0
	|-Task<ValueWebSocketReceiveResult>.StartNew
	|
	|-RVA: 0xC62430 Offset: 0xC61630 VA: 0x180C62430
	|-Task<VoidTaskResult>.StartNew
	|
	|-RVA: 0xC66150 Offset: 0xC65350 VA: 0x180C66150
	|-Task<WaitForChangedResult>.StartNew
	|
	|-RVA: 0xC666A0 Offset: 0xC658A0 VA: 0x180C666A0
	|-Task<__Il2CppFullySharedGenericType>.StartNew
	*/

	// RVA: -1 Offset: -1
	internal bool TrySetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC5D670 Offset: 0xC5C870 VA: 0x180C5D670
	|-Task<ArraySegment<byte>>.TrySetResult
	|-Task<ValueTuple<bool, object>>.TrySetResult
	|-Task<JsonElement>.TrySetResult
	|-Task<SceneInstance>.TrySetResult
	|-Task<SerializableProjectConfiguration>.TrySetResult
	|-Task<SocketReceiveFromResult>.TrySetResult
	|-Task<UdpReceiveResult>.TrySetResult
	|
	|-RVA: 0xC66870 Offset: 0xC65A70 VA: 0x180C66870
	|-Task<Nullable<int>>.TrySetResult
	|-Task<long>.TrySetResult
	|-Task<object>.TrySetResult
	|-Task<ValueWebSocketReceiveResult>.TrySetResult
	|
	|-RVA: 0xC66C80 Offset: 0xC65E80 VA: 0x180C66C80
	|-Task<Nullable<JsonElement>>.TrySetResult
	|-Task<ValueTuple<object, object, int>>.TrySetResult
	|
	|-RVA: 0xC66B20 Offset: 0xC65D20 VA: 0x180C66B20
	|-Task<ValueTuple<object, bool, bool, object, object>>.TrySetResult
	|-Task<SocketReceiveMessageFromResult>.TrySetResult
	|-Task<WaitForChangedResult>.TrySetResult
	|
	|-RVA: 0xC66BD0 Offset: 0xC65DD0 VA: 0x180C66BD0
	|-Task<bool>.TrySetResult
	|-Task<VoidTaskResult>.TrySetResult
	|
	|-RVA: 0xC66920 Offset: 0xC65B20 VA: 0x180C66920
	|-Task<int>.TrySetResult
	|-Task<Int32Enum>.TrySetResult
	|
	|-RVA: 0xC669D0 Offset: 0xC65BD0 VA: 0x180C669D0
	|-Task<__Il2CppFullySharedGenericType>.TrySetResult
	*/

	// RVA: -1 Offset: -1
	internal void DangerousSetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC5D0D0 Offset: 0xC5C2D0 VA: 0x180C5D0D0
	|-Task<ArraySegment<byte>>.DangerousSetResult
	|-Task<ValueTuple<bool, object>>.DangerousSetResult
	|-Task<JsonElement>.DangerousSetResult
	|-Task<SceneInstance>.DangerousSetResult
	|-Task<SerializableProjectConfiguration>.DangerousSetResult
	|-Task<SocketReceiveFromResult>.DangerousSetResult
	|-Task<UdpReceiveResult>.DangerousSetResult
	|
	|-RVA: 0xC61450 Offset: 0xC60650 VA: 0x180C61450
	|-Task<Nullable<int>>.DangerousSetResult
	|-Task<long>.DangerousSetResult
	|-Task<object>.DangerousSetResult
	|-Task<ValueWebSocketReceiveResult>.DangerousSetResult
	|
	|-RVA: 0xC61860 Offset: 0xC60A60 VA: 0x180C61860
	|-Task<Nullable<JsonElement>>.DangerousSetResult
	|-Task<ValueTuple<object, object, int>>.DangerousSetResult
	|
	|-RVA: 0xC61500 Offset: 0xC60700 VA: 0x180C61500
	|-Task<ValueTuple<object, bool, bool, object, object>>.DangerousSetResult
	|-Task<SocketReceiveMessageFromResult>.DangerousSetResult
	|-Task<WaitForChangedResult>.DangerousSetResult
	|
	|-RVA: 0xC615D0 Offset: 0xC607D0 VA: 0x180C615D0
	|-Task<bool>.DangerousSetResult
	|-Task<VoidTaskResult>.DangerousSetResult
	|
	|-RVA: 0xC61680 Offset: 0xC60880 VA: 0x180C61680
	|-Task<int>.DangerousSetResult
	|-Task<Int32Enum>.DangerousSetResult
	|
	|-RVA: 0xC61730 Offset: 0xC60930 VA: 0x180C61730
	|-Task<__Il2CppFullySharedGenericType>.DangerousSetResult
	*/

	// RVA: -1 Offset: -1
	public TResult get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC5DC90 Offset: 0xC5CE90 VA: 0x180C5DC90
	|-Task<ArraySegment<byte>>.get_Result
	|-Task<ValueTuple<bool, object>>.get_Result
	|-Task<JsonElement>.get_Result
	|-Task<SceneInstance>.get_Result
	|-Task<SerializableProjectConfiguration>.get_Result
	|-Task<SocketReceiveFromResult>.get_Result
	|-Task<UdpReceiveResult>.get_Result
	|
	|-RVA: 0xC6C220 Offset: 0xC6B420 VA: 0x180C6C220
	|-Task<Nullable<int>>.get_Result
	|-Task<long>.get_Result
	|-Task<object>.get_Result
	|-Task<ValueWebSocketReceiveResult>.get_Result
	|
	|-RVA: 0xC6C2B0 Offset: 0xC6B4B0 VA: 0x180C6C2B0
	|-Task<Nullable<JsonElement>>.get_Result
	|-Task<ValueTuple<object, object, int>>.get_Result
	|
	|-RVA: 0xC6C170 Offset: 0xC6B370 VA: 0x180C6C170
	|-Task<ValueTuple<object, bool, bool, object, object>>.get_Result
	|-Task<SocketReceiveMessageFromResult>.get_Result
	|-Task<WaitForChangedResult>.get_Result
	|
	|-RVA: 0xC6C360 Offset: 0xC6B560 VA: 0x180C6C360
	|-Task<bool>.get_Result
	|-Task<VoidTaskResult>.get_Result
	|
	|-RVA: 0xC6C3F0 Offset: 0xC6B5F0 VA: 0x180C6C3F0
	|-Task<int>.get_Result
	|-Task<Int32Enum>.get_Result
	|
	|-RVA: 0xC6C480 Offset: 0xC6B680 VA: 0x180C6C480
	|-Task<__Il2CppFullySharedGenericType>.get_Result
	*/

	// RVA: -1 Offset: -1
	internal TResult get_ResultOnSuccess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC5DC80 Offset: 0xC5CE80 VA: 0x180C5DC80
	|-Task<ArraySegment<byte>>.get_ResultOnSuccess
	|-Task<ValueTuple<bool, object>>.get_ResultOnSuccess
	|-Task<JsonElement>.get_ResultOnSuccess
	|-Task<SceneInstance>.get_ResultOnSuccess
	|-Task<SerializableProjectConfiguration>.get_ResultOnSuccess
	|-Task<SocketReceiveFromResult>.get_ResultOnSuccess
	|-Task<UdpReceiveResult>.get_ResultOnSuccess
	|
	|-RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	|-Task<Nullable<int>>.get_ResultOnSuccess
	|-Task<long>.get_ResultOnSuccess
	|-Task<object>.get_ResultOnSuccess
	|-Task<ValueWebSocketReceiveResult>.get_ResultOnSuccess
	|
	|-RVA: 0xC6C150 Offset: 0xC6B350 VA: 0x180C6C150
	|-Task<Nullable<JsonElement>>.get_ResultOnSuccess
	|-Task<ValueTuple<object, object, int>>.get_ResultOnSuccess
	|
	|-RVA: 0xC6C080 Offset: 0xC6B280 VA: 0x180C6C080
	|-Task<ValueTuple<object, bool, bool, object, object>>.get_ResultOnSuccess
	|-Task<SocketReceiveMessageFromResult>.get_ResultOnSuccess
	|-Task<WaitForChangedResult>.get_ResultOnSuccess
	|
	|-RVA: 0x4D1A10 Offset: 0x4D0C10 VA: 0x1804D1A10
	|-Task<bool>.get_ResultOnSuccess
	|-Task<VoidTaskResult>.get_ResultOnSuccess
	|
	|-RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410
	|-Task<int>.get_ResultOnSuccess
	|-Task<Int32Enum>.get_ResultOnSuccess
	|
	|-RVA: 0xC6C0A0 Offset: 0xC6B2A0 VA: 0x180C6C0A0
	|-Task<__Il2CppFullySharedGenericType>.get_ResultOnSuccess
	*/

	// RVA: -1 Offset: -1
	internal TResult GetResultCore(bool waitCompletionNotification) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC5D190 Offset: 0xC5C390 VA: 0x180C5D190
	|-Task<ArraySegment<byte>>.GetResultCore
	|-Task<ValueTuple<bool, object>>.GetResultCore
	|-Task<JsonElement>.GetResultCore
	|-Task<SceneInstance>.GetResultCore
	|-Task<SerializableProjectConfiguration>.GetResultCore
	|-Task<SocketReceiveFromResult>.GetResultCore
	|-Task<UdpReceiveResult>.GetResultCore
	|
	|-RVA: 0xC61A50 Offset: 0xC60C50 VA: 0x180C61A50
	|-Task<Nullable<int>>.GetResultCore
	|-Task<long>.GetResultCore
	|-Task<object>.GetResultCore
	|-Task<ValueWebSocketReceiveResult>.GetResultCore
	|
	|-RVA: 0xC61930 Offset: 0xC60B30 VA: 0x180C61930
	|-Task<Nullable<JsonElement>>.GetResultCore
	|-Task<ValueTuple<object, object, int>>.GetResultCore
	|
	|-RVA: 0xC61AD0 Offset: 0xC60CD0 VA: 0x180C61AD0
	|-Task<ValueTuple<object, bool, bool, object, object>>.GetResultCore
	|-Task<SocketReceiveMessageFromResult>.GetResultCore
	|-Task<WaitForChangedResult>.GetResultCore
	|
	|-RVA: 0xC61B70 Offset: 0xC60D70 VA: 0x180C61B70
	|-Task<bool>.GetResultCore
	|-Task<VoidTaskResult>.GetResultCore
	|
	|-RVA: 0xC619D0 Offset: 0xC60BD0 VA: 0x180C619D0
	|-Task<int>.GetResultCore
	|-Task<Int32Enum>.GetResultCore
	|
	|-RVA: 0xC61BF0 Offset: 0xC60DF0 VA: 0x180C61BF0
	|-Task<__Il2CppFullySharedGenericType>.GetResultCore
	*/

	// RVA: -1 Offset: -1
	public static TaskFactory<TResult> get_Factory() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC5DB10 Offset: 0xC5CD10 VA: 0x180C5DB10
	|-Task<ArraySegment<byte>>.get_Factory
	|
	|-RVA: 0xC6BDB0 Offset: 0xC6AFB0 VA: 0x180C6BDB0
	|-Task<Nullable<int>>.get_Factory
	|-Task<Nullable<JsonElement>>.get_Factory
	|-Task<ValueTuple<bool, object>>.get_Factory
	|-Task<ValueTuple<object, object, int>>.get_Factory
	|-Task<ValueTuple<object, bool, bool, object, object>>.get_Factory
	|-Task<bool>.get_Factory
	|-Task<int>.get_Factory
	|-Task<Int32Enum>.get_Factory
	|-Task<long>.get_Factory
	|-Task<JsonElement>.get_Factory
	|-Task<object>.get_Factory
	|-Task<SceneInstance>.get_Factory
	|-Task<SerializableProjectConfiguration>.get_Factory
	|-Task<SocketReceiveFromResult>.get_Factory
	|-Task<SocketReceiveMessageFromResult>.get_Factory
	|-Task<UdpReceiveResult>.get_Factory
	|-Task<ValueWebSocketReceiveResult>.get_Factory
	|-Task<VoidTaskResult>.get_Factory
	|-Task<WaitForChangedResult>.get_Factory
	|
	|-RVA: 0xC6BF00 Offset: 0xC6B100 VA: 0x180C6BF00
	|-Task<__Il2CppFullySharedGenericType>.get_Factory
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC5D220 Offset: 0xC5C420 VA: 0x180C5D220
	|-Task<ArraySegment<byte>>.InnerInvoke
	|-Task<ValueTuple<bool, object>>.InnerInvoke
	|-Task<JsonElement>.InnerInvoke
	|-Task<SceneInstance>.InnerInvoke
	|-Task<SerializableProjectConfiguration>.InnerInvoke
	|-Task<SocketReceiveFromResult>.InnerInvoke
	|-Task<UdpReceiveResult>.InnerInvoke
	|
	|-RVA: 0xC61D00 Offset: 0xC60F00 VA: 0x180C61D00
	|-Task<Nullable<int>>.InnerInvoke
	|-Task<long>.InnerInvoke
	|-Task<object>.InnerInvoke
	|-Task<ValueWebSocketReceiveResult>.InnerInvoke
	|
	|-RVA: 0xC61FF0 Offset: 0xC611F0 VA: 0x180C61FF0
	|-Task<Nullable<JsonElement>>.InnerInvoke
	|-Task<ValueTuple<object, object, int>>.InnerInvoke
	|
	|-RVA: 0xC61DC0 Offset: 0xC60FC0 VA: 0x180C61DC0
	|-Task<ValueTuple<object, bool, bool, object, object>>.InnerInvoke
	|-Task<SocketReceiveMessageFromResult>.InnerInvoke
	|-Task<WaitForChangedResult>.InnerInvoke
	|
	|-RVA: 0xC62190 Offset: 0xC61390 VA: 0x180C62190
	|-Task<bool>.InnerInvoke
	|-Task<VoidTaskResult>.InnerInvoke
	|
	|-RVA: 0xC620C0 Offset: 0xC612C0 VA: 0x180C620C0
	|-Task<int>.InnerInvoke
	|-Task<Int32Enum>.InnerInvoke
	|
	|-RVA: 0xC61E90 Offset: 0xC61090 VA: 0x180C61E90
	|-Task<__Il2CppFullySharedGenericType>.InnerInvoke
	*/

	// RVA: -1 Offset: -1
	public TaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	|-Task<ArraySegment<byte>>.GetAwaiter
	|-Task<Nullable<int>>.GetAwaiter
	|-Task<Nullable<JsonElement>>.GetAwaiter
	|-Task<ValueTuple<bool, object>>.GetAwaiter
	|-Task<ValueTuple<object, object, int>>.GetAwaiter
	|-Task<ValueTuple<object, bool, bool, object, object>>.GetAwaiter
	|-Task<bool>.GetAwaiter
	|-Task<int>.GetAwaiter
	|-Task<Int32Enum>.GetAwaiter
	|-Task<long>.GetAwaiter
	|-Task<JsonElement>.GetAwaiter
	|-Task<object>.GetAwaiter
	|-Task<SceneInstance>.GetAwaiter
	|-Task<SerializableProjectConfiguration>.GetAwaiter
	|-Task<SocketReceiveFromResult>.GetAwaiter
	|-Task<SocketReceiveMessageFromResult>.GetAwaiter
	|-Task<UdpReceiveResult>.GetAwaiter
	|-Task<ValueWebSocketReceiveResult>.GetAwaiter
	|-Task<VoidTaskResult>.GetAwaiter
	|-Task<WaitForChangedResult>.GetAwaiter
	|-Task<__Il2CppFullySharedGenericType>.GetAwaiter
	*/

	// RVA: -1 Offset: -1
	public ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC5CDE0 Offset: 0xC5BFE0 VA: 0x180C5CDE0
	|-Task<ArraySegment<byte>>.ConfigureAwait
	|-Task<Nullable<int>>.ConfigureAwait
	|-Task<Nullable<JsonElement>>.ConfigureAwait
	|-Task<ValueTuple<bool, object>>.ConfigureAwait
	|-Task<ValueTuple<object, object, int>>.ConfigureAwait
	|-Task<ValueTuple<object, bool, bool, object, object>>.ConfigureAwait
	|-Task<bool>.ConfigureAwait
	|-Task<int>.ConfigureAwait
	|-Task<Int32Enum>.ConfigureAwait
	|-Task<long>.ConfigureAwait
	|-Task<JsonElement>.ConfigureAwait
	|-Task<object>.ConfigureAwait
	|-Task<SceneInstance>.ConfigureAwait
	|-Task<SerializableProjectConfiguration>.ConfigureAwait
	|-Task<SocketReceiveFromResult>.ConfigureAwait
	|-Task<SocketReceiveMessageFromResult>.ConfigureAwait
	|-Task<UdpReceiveResult>.ConfigureAwait
	|-Task<ValueWebSocketReceiveResult>.ConfigureAwait
	|-Task<VoidTaskResult>.ConfigureAwait
	|-Task<WaitForChangedResult>.ConfigureAwait
	|-Task<__Il2CppFullySharedGenericType>.ConfigureAwait
	*/

	// RVA: -1 Offset: -1
	public Task ContinueWith(Action<Task<TResult>> continuationAction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC5D040 Offset: 0xC5C240 VA: 0x180C5D040
	|-Task<ArraySegment<byte>>.ContinueWith
	|
	|-RVA: 0xC5F210 Offset: 0xC5E410 VA: 0x180C5F210
	|-Task<Nullable<int>>.ContinueWith
	|
	|-RVA: 0xC5EAB0 Offset: 0xC5DCB0 VA: 0x180C5EAB0
	|-Task<Nullable<JsonElement>>.ContinueWith
	|
	|-RVA: 0xC5EE90 Offset: 0xC5E090 VA: 0x180C5EE90
	|-Task<ValueTuple<bool, object>>.ContinueWith
	|
	|-RVA: 0xC5DD30 Offset: 0xC5CF30 VA: 0x180C5DD30
	|-Task<ValueTuple<object, object, int>>.ContinueWith
	|
	|-RVA: 0xC601A0 Offset: 0xC5F3A0 VA: 0x180C601A0
	|-Task<ValueTuple<object, bool, bool, object, object>>.ContinueWith
	|
	|-RVA: 0xC60230 Offset: 0xC5F430 VA: 0x180C60230
	|-Task<bool>.ContinueWith
	|
	|-RVA: 0xC5EBD0 Offset: 0xC5DDD0 VA: 0x180C5EBD0
	|-Task<int>.ContinueWith
	|
	|-RVA: 0xC5F8A0 Offset: 0xC5EAA0 VA: 0x180C5F8A0
	|-Task<Int32Enum>.ContinueWith
	|
	|-RVA: 0xC5EB40 Offset: 0xC5DD40 VA: 0x180C5EB40
	|-Task<long>.ContinueWith
	|
	|-RVA: 0xC5DDC0 Offset: 0xC5CFC0 VA: 0x180C5DDC0
	|-Task<JsonElement>.ContinueWith
	|
	|-RVA: 0xC600E0 Offset: 0xC5F2E0 VA: 0x180C600E0
	|-Task<object>.ContinueWith
	|
	|-RVA: 0xC605E0 Offset: 0xC5F7E0 VA: 0x180C605E0
	|-Task<SceneInstance>.ContinueWith
	|
	|-RVA: 0xC5EF50 Offset: 0xC5E150 VA: 0x180C5EF50
	|-Task<SerializableProjectConfiguration>.ContinueWith
	|
	|-RVA: 0xC60670 Offset: 0xC5F870 VA: 0x180C60670
	|-Task<SocketReceiveFromResult>.ContinueWith
	|
	|-RVA: 0xC5FB60 Offset: 0xC5ED60 VA: 0x180C5FB60
	|-Task<SocketReceiveMessageFromResult>.ContinueWith
	|
	|-RVA: 0xC5E180 Offset: 0xC5D380 VA: 0x180C5E180
	|-Task<UdpReceiveResult>.ContinueWith
	|
	|-RVA: 0xC60B60 Offset: 0xC5FD60 VA: 0x180C60B60
	|-Task<ValueWebSocketReceiveResult>.ContinueWith
	|
	|-RVA: 0xC602F0 Offset: 0xC5F4F0 VA: 0x180C602F0
	|-Task<VoidTaskResult>.ContinueWith
	|
	|-RVA: 0xC60050 Offset: 0xC5F250 VA: 0x180C60050
	|-Task<WaitForChangedResult>.ContinueWith
	|
	|-RVA: 0xC5E080 Offset: 0xC5D280 VA: 0x180C5E080
	|-Task<__Il2CppFullySharedGenericType>.ContinueWith
	*/

	// RVA: -1 Offset: -1
	public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC5D010 Offset: 0xC5C210 VA: 0x180C5D010
	|-Task<ArraySegment<byte>>.ContinueWith
	|
	|-RVA: 0xC5EA80 Offset: 0xC5DC80 VA: 0x180C5EA80
	|-Task<Nullable<int>>.ContinueWith
	|
	|-RVA: 0xC60E20 Offset: 0xC60020 VA: 0x180C60E20
	|-Task<Nullable<JsonElement>>.ContinueWith
	|
	|-RVA: 0xC5E120 Offset: 0xC5D320 VA: 0x180C5E120
	|-Task<ValueTuple<bool, object>>.ContinueWith
	|
	|-RVA: 0xC5FC20 Offset: 0xC5EE20 VA: 0x180C5FC20
	|-Task<ValueTuple<object, object, int>>.ContinueWith
	|
	|-RVA: 0xC5F1E0 Offset: 0xC5E3E0 VA: 0x180C5F1E0
	|-Task<ValueTuple<object, bool, bool, object, object>>.ContinueWith
	|
	|-RVA: 0xC60B30 Offset: 0xC5FD30 VA: 0x180C60B30
	|-Task<bool>.ContinueWith
	|
	|-RVA: 0xC60170 Offset: 0xC5F370 VA: 0x180C60170
	|-Task<int>.ContinueWith
	|
	|-RVA: 0xC5FBF0 Offset: 0xC5EDF0 VA: 0x180C5FBF0
	|-Task<Int32Enum>.ContinueWith
	|
	|-RVA: 0xC5E150 Offset: 0xC5D350 VA: 0x180C5E150
	|-Task<long>.ContinueWith
	|
	|-RVA: 0xC603B0 Offset: 0xC5F5B0 VA: 0x180C603B0
	|-Task<JsonElement>.ContinueWith
	|
	|-RVA: 0xC60BF0 Offset: 0xC5FDF0 VA: 0x180C60BF0
	|-Task<object>.ContinueWith
	|
	|-RVA: 0xC5EF20 Offset: 0xC5E120 VA: 0x180C5EF20
	|-Task<SceneInstance>.ContinueWith
	|
	|-RVA: 0xC60380 Offset: 0xC5F580 VA: 0x180C60380
	|-Task<SerializableProjectConfiguration>.ContinueWith
	|
	|-RVA: 0xC5E450 Offset: 0xC5D650 VA: 0x180C5E450
	|-Task<SocketReceiveFromResult>.ContinueWith
	|
	|-RVA: 0xC5FB30 Offset: 0xC5ED30 VA: 0x180C5FB30
	|-Task<SocketReceiveMessageFromResult>.ContinueWith
	|
	|-RVA: 0xC5EC60 Offset: 0xC5DE60 VA: 0x180C5EC60
	|-Task<UdpReceiveResult>.ContinueWith
	|
	|-RVA: 0xC5E050 Offset: 0xC5D250 VA: 0x180C5E050
	|-Task<ValueWebSocketReceiveResult>.ContinueWith
	|
	|-RVA: 0xC602C0 Offset: 0xC5F4C0 VA: 0x180C602C0
	|-Task<VoidTaskResult>.ContinueWith
	|
	|-RVA: 0xC60900 Offset: 0xC5FB00 VA: 0x180C60900
	|-Task<WaitForChangedResult>.ContinueWith
	|
	|-RVA: 0xC5E210 Offset: 0xC5D410 VA: 0x180C5E210
	|-Task<__Il2CppFullySharedGenericType>.ContinueWith
	*/

	// RVA: -1 Offset: -1
	internal Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC5CE10 Offset: 0xC5C010 VA: 0x180C5CE10
	|-Task<ArraySegment<byte>>.ContinueWith
	|
	|-RVA: 0xC5FE50 Offset: 0xC5F050 VA: 0x180C5FE50
	|-Task<Nullable<int>>.ContinueWith
	|
	|-RVA: 0xC5EC90 Offset: 0xC5DE90 VA: 0x180C5EC90
	|-Task<Nullable<JsonElement>>.ContinueWith
	|
	|-RVA: 0xC60930 Offset: 0xC5FB30 VA: 0x180C60930
	|-Task<ValueTuple<bool, object>>.ContinueWith
	|
	|-RVA: 0xC60E50 Offset: 0xC60050 VA: 0x180C60E50
	|-Task<ValueTuple<object, object, int>>.ContinueWith
	|
	|-RVA: 0xC603E0 Offset: 0xC5F5E0 VA: 0x180C603E0
	|-Task<ValueTuple<object, bool, bool, object, object>>.ContinueWith
	|
	|-RVA: 0xC60C20 Offset: 0xC5FE20 VA: 0x180C60C20
	|-Task<bool>.ContinueWith
	|
	|-RVA: 0xC5F2A0 Offset: 0xC5E4A0 VA: 0x180C5F2A0
	|-Task<int>.ContinueWith
	|
	|-RVA: 0xC5DE50 Offset: 0xC5D050 VA: 0x180C5DE50
	|-Task<Int32Enum>.ContinueWith
	|
	|-RVA: 0xC60700 Offset: 0xC5F900 VA: 0x180C60700
	|-Task<long>.ContinueWith
	|
	|-RVA: 0xC5F6A0 Offset: 0xC5E8A0 VA: 0x180C5F6A0
	|-Task<JsonElement>.ContinueWith
	|
	|-RVA: 0xC5E480 Offset: 0xC5D680 VA: 0x180C5E480
	|-Task<object>.ContinueWith
	|
	|-RVA: 0xC5EFE0 Offset: 0xC5E1E0 VA: 0x180C5EFE0
	|-Task<SceneInstance>.ContinueWith
	|
	|-RVA: 0xC61050 Offset: 0xC60250 VA: 0x180C61050
	|-Task<SerializableProjectConfiguration>.ContinueWith
	|
	|-RVA: 0xC5FC50 Offset: 0xC5EE50 VA: 0x180C5FC50
	|-Task<SocketReceiveFromResult>.ContinueWith
	|
	|-RVA: 0xC5F4A0 Offset: 0xC5E6A0 VA: 0x180C5F4A0
	|-Task<SocketReceiveMessageFromResult>.ContinueWith
	|
	|-RVA: 0xC5E680 Offset: 0xC5D880 VA: 0x180C5E680
	|-Task<UdpReceiveResult>.ContinueWith
	|
	|-RVA: 0xC5E250 Offset: 0xC5D450 VA: 0x180C5E250
	|-Task<ValueWebSocketReceiveResult>.ContinueWith
	|
	|-RVA: 0xC5E880 Offset: 0xC5DA80 VA: 0x180C5E880
	|-Task<VoidTaskResult>.ContinueWith
	|
	|-RVA: 0xC61250 Offset: 0xC60450 VA: 0x180C61250
	|-Task<WaitForChangedResult>.ContinueWith
	|
	|-RVA: 0xC5F930 Offset: 0xC5EB30 VA: 0x180C5F930
	|-Task<__Il2CppFullySharedGenericType>.ContinueWith
	*/

	// RVA: -1 Offset: -1
	public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F6CE0 Offset: 0x8F5EE0 VA: 0x1808F6CE0
	|-Task<object>.ContinueWith<object>
	|
	|-RVA: 0x8F61E0 Offset: 0x8F53E0 VA: 0x1808F61E0
	|-Task<__Il2CppFullySharedGenericType>.ContinueWith<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskContinuationOptions continuationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F66E0 Offset: 0x8F58E0 VA: 0x1808F66E0
	|-Task<int>.ContinueWith<Nullable<int>>
	|
	|-RVA: 0x8F68F0 Offset: 0x8F5AF0 VA: 0x1808F68F0
	|-Task<object>.ContinueWith<Nullable<int>>
	|
	|-RVA: 0x8F6460 Offset: 0x8F5660 VA: 0x1808F6460
	|-Task<__Il2CppFullySharedGenericType>.ContinueWith<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F6B00 Offset: 0x8F5D00 VA: 0x1808F6B00
	|-Task<int>.ContinueWith<Nullable<int>>
	|
	|-RVA: 0x8F6500 Offset: 0x8F5700 VA: 0x1808F6500
	|-Task<object>.ContinueWith<Nullable<int>>
	|
	|-RVA: 0x8F6EE0 Offset: 0x8F60E0 VA: 0x1808F6EE0
	|-Task<object>.ContinueWith<object>
	|
	|-RVA: 0x8F6270 Offset: 0x8F5470 VA: 0x1808F6270
	|-Task<__Il2CppFullySharedGenericType>.ContinueWith<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Threading.Tasks
internal class SystemThreadingTasks_FutureDebugView<TResult> // TypeDefIndex: 3414
{}

// Namespace: 
private sealed class TaskFactory.FromAsyncTrimPromise<TResult, TInstance> : Task<TResult> // TypeDefIndex: 3415
{
	// Fields
	internal static readonly AsyncCallback s_completeFromAsyncResult; // 0x0
	private TInstance m_thisRef; // 0x0
	private Func<TInstance, IAsyncResult, TResult> m_endMethod; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1201C00 Offset: 0x1200E00 VA: 0x181201C00
	|-TaskFactory.FromAsyncTrimPromise<int, object>..ctor
	|
	|-RVA: 0x1201BB0 Offset: 0x1200DB0 VA: 0x181201BB0
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>..ctor
	|
	|-RVA: 0x1201C50 Offset: 0x1200E50 VA: 0x181201C50
	|-TaskFactory.FromAsyncTrimPromise<__Il2CppFullySharedGenericType, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal static void CompleteFromAsyncResult(IAsyncResult asyncResult) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1200FF0 Offset: 0x12001F0 VA: 0x181200FF0
	|-TaskFactory.FromAsyncTrimPromise<int, object>.CompleteFromAsyncResult
	|
	|-RVA: 0x1200DE0 Offset: 0x11FFFE0 VA: 0x181200DE0
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>.CompleteFromAsyncResult
	|
	|-RVA: 0x1201200 Offset: 0x1200400 VA: 0x181201200
	|-TaskFactory.FromAsyncTrimPromise<__Il2CppFullySharedGenericType, object>.CompleteFromAsyncResult
	*/

	// RVA: -1 Offset: -1
	internal void Complete(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod, IAsyncResult asyncResult, bool requiresSynchronization) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1201730 Offset: 0x1200930 VA: 0x181201730
	|-TaskFactory.FromAsyncTrimPromise<int, object>.Complete
	|
	|-RVA: 0x1201820 Offset: 0x1200A20 VA: 0x181201820
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>.Complete
	|
	|-RVA: 0x1201510 Offset: 0x1200710 VA: 0x181201510
	|-TaskFactory.FromAsyncTrimPromise<__Il2CppFullySharedGenericType, object>.Complete
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1201910 Offset: 0x1200B10 VA: 0x181201910
	|-TaskFactory.FromAsyncTrimPromise<int, object>..cctor
	|
	|-RVA: 0x1201AD0 Offset: 0x1200CD0 VA: 0x181201AD0
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>..cctor
	|
	|-RVA: 0x12019F0 Offset: 0x1200BF0 VA: 0x1812019F0
	|-TaskFactory.FromAsyncTrimPromise<__Il2CppFullySharedGenericType, object>..cctor
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class TaskFactory.<>c__DisplayClass35_0<TResult> // TypeDefIndex: 3416
{
	// Fields
	public Func<IAsyncResult, TResult> endFunction; // 0x0
	public Action<IAsyncResult> endAction; // 0x0
	public Task<TResult> promise; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-TaskFactory.<>c__DisplayClass35_0<ArraySegment<byte>>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<int>>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<JsonElement>>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<ValueTuple<bool, object>>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<ValueTuple<object, object, int>>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<ValueTuple<object, bool, bool, object, object>>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<bool>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<int>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<Int32Enum>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<long>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<JsonElement>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<object>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<SceneInstance>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<SerializableProjectConfiguration>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<SocketReceiveFromResult>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<SocketReceiveMessageFromResult>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<UdpReceiveResult>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<ValueWebSocketReceiveResult>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<VoidTaskResult>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<WaitForChangedResult>..ctor
	|-TaskFactory.<>c__DisplayClass35_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <FromAsyncImpl>b__0(IAsyncResult iar) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0D5F0 Offset: 0xB0C7F0 VA: 0x180B0D5F0
	|-TaskFactory.<>c__DisplayClass35_0<ArraySegment<byte>>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0D2D0 Offset: 0xB0C4D0 VA: 0x180B0D2D0
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<int>>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0D550 Offset: 0xB0C750 VA: 0x180B0D550
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<JsonElement>>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0DB90 Offset: 0xB0CD90 VA: 0x180B0DB90
	|-TaskFactory.<>c__DisplayClass35_0<ValueTuple<bool, object>>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0D370 Offset: 0xB0C570 VA: 0x180B0D370
	|-TaskFactory.<>c__DisplayClass35_0<ValueTuple<object, object, int>>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0DAF0 Offset: 0xB0CCF0 VA: 0x180B0DAF0
	|-TaskFactory.<>c__DisplayClass35_0<ValueTuple<object, bool, bool, object, object>>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0DC30 Offset: 0xB0CE30 VA: 0x180B0DC30
	|-TaskFactory.<>c__DisplayClass35_0<bool>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0D4B0 Offset: 0xB0C6B0 VA: 0x180B0D4B0
	|-TaskFactory.<>c__DisplayClass35_0<int>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0DCD0 Offset: 0xB0CED0 VA: 0x180B0DCD0
	|-TaskFactory.<>c__DisplayClass35_0<Int32Enum>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0D190 Offset: 0xB0C390 VA: 0x180B0D190
	|-TaskFactory.<>c__DisplayClass35_0<long>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0D050 Offset: 0xB0C250 VA: 0x180B0D050
	|-TaskFactory.<>c__DisplayClass35_0<JsonElement>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0D0F0 Offset: 0xB0C2F0 VA: 0x180B0D0F0
	|-TaskFactory.<>c__DisplayClass35_0<object>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0D690 Offset: 0xB0C890 VA: 0x180B0D690
	|-TaskFactory.<>c__DisplayClass35_0<SceneInstance>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0D730 Offset: 0xB0C930 VA: 0x180B0D730
	|-TaskFactory.<>c__DisplayClass35_0<SerializableProjectConfiguration>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0D7D0 Offset: 0xB0C9D0 VA: 0x180B0D7D0
	|-TaskFactory.<>c__DisplayClass35_0<SocketReceiveFromResult>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0D230 Offset: 0xB0C430 VA: 0x180B0D230
	|-TaskFactory.<>c__DisplayClass35_0<SocketReceiveMessageFromResult>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0D910 Offset: 0xB0CB10 VA: 0x180B0D910
	|-TaskFactory.<>c__DisplayClass35_0<UdpReceiveResult>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0D870 Offset: 0xB0CA70 VA: 0x180B0D870
	|-TaskFactory.<>c__DisplayClass35_0<ValueWebSocketReceiveResult>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0DA50 Offset: 0xB0CC50 VA: 0x180B0DA50
	|-TaskFactory.<>c__DisplayClass35_0<VoidTaskResult>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0D9B0 Offset: 0xB0CBB0 VA: 0x180B0D9B0
	|-TaskFactory.<>c__DisplayClass35_0<WaitForChangedResult>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0D410 Offset: 0xB0C610 VA: 0x180B0D410
	|-TaskFactory.<>c__DisplayClass35_0<__Il2CppFullySharedGenericType>.<FromAsyncImpl>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class TaskFactory.<>c__DisplayClass38_0<TResult, TArg1> // TypeDefIndex: 3417
{
	// Fields
	public Func<IAsyncResult, TResult> endFunction; // 0x0
	public Action<IAsyncResult> endAction; // 0x0
	public Task<TResult> promise; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-TaskFactory.<>c__DisplayClass38_0<object, object>..ctor
	|-TaskFactory.<>c__DisplayClass38_0<SocketReceiveMessageFromResult, ArraySegment<byte>>..ctor
	|-TaskFactory.<>c__DisplayClass38_0<VoidTaskResult, object>..ctor
	|-TaskFactory.<>c__DisplayClass38_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <FromAsyncImpl>b__0(IAsyncResult iar) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0DF50 Offset: 0xB0D150 VA: 0x180B0DF50
	|-TaskFactory.<>c__DisplayClass38_0<object, object>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0DE10 Offset: 0xB0D010 VA: 0x180B0DE10
	|-TaskFactory.<>c__DisplayClass38_0<SocketReceiveMessageFromResult, ArraySegment<byte>>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0DEB0 Offset: 0xB0D0B0 VA: 0x180B0DEB0
	|-TaskFactory.<>c__DisplayClass38_0<VoidTaskResult, object>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0DD70 Offset: 0xB0CF70 VA: 0x180B0DD70
	|-TaskFactory.<>c__DisplayClass38_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<FromAsyncImpl>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class TaskFactory.<>c__DisplayClass41_0<TResult, TArg1, TArg2> // TypeDefIndex: 3418
{
	// Fields
	public Func<IAsyncResult, TResult> endFunction; // 0x0
	public Action<IAsyncResult> endAction; // 0x0
	public Task<TResult> promise; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-TaskFactory.<>c__DisplayClass41_0<int, ArraySegment<byte>, Int32Enum>..ctor
	|-TaskFactory.<>c__DisplayClass41_0<int, object, int>..ctor
	|-TaskFactory.<>c__DisplayClass41_0<int, object, Int32Enum>..ctor
	|-TaskFactory.<>c__DisplayClass41_0<object, object, int>..ctor
	|-TaskFactory.<>c__DisplayClass41_0<SocketReceiveFromResult, ArraySegment<byte>, Int32Enum>..ctor
	|-TaskFactory.<>c__DisplayClass41_0<VoidTaskResult, object, int>..ctor
	|-TaskFactory.<>c__DisplayClass41_0<VoidTaskResult, object, object>..ctor
	|-TaskFactory.<>c__DisplayClass41_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <FromAsyncImpl>b__0(IAsyncResult iar) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0E3C0 Offset: 0xB0D5C0 VA: 0x180B0E3C0
	|-TaskFactory.<>c__DisplayClass41_0<int, ArraySegment<byte>, Int32Enum>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0E1E0 Offset: 0xB0D3E0 VA: 0x180B0E1E0
	|-TaskFactory.<>c__DisplayClass41_0<int, object, int>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0E320 Offset: 0xB0D520 VA: 0x180B0E320
	|-TaskFactory.<>c__DisplayClass41_0<int, object, Int32Enum>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0E140 Offset: 0xB0D340 VA: 0x180B0E140
	|-TaskFactory.<>c__DisplayClass41_0<object, object, int>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0E460 Offset: 0xB0D660 VA: 0x180B0E460
	|-TaskFactory.<>c__DisplayClass41_0<SocketReceiveFromResult, ArraySegment<byte>, Int32Enum>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0E500 Offset: 0xB0D700 VA: 0x180B0E500
	|-TaskFactory.<>c__DisplayClass41_0<VoidTaskResult, object, int>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0E280 Offset: 0xB0D480 VA: 0x180B0E280
	|-TaskFactory.<>c__DisplayClass41_0<VoidTaskResult, object, object>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0E5A0 Offset: 0xB0D7A0 VA: 0x180B0E5A0
	|-TaskFactory.<>c__DisplayClass41_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<FromAsyncImpl>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class TaskFactory.<>c__DisplayClass44_0<TResult, TArg1, TArg2, TArg3> // TypeDefIndex: 3419
{
	// Fields
	public Func<IAsyncResult, TResult> endFunction; // 0x0
	public Action<IAsyncResult> endAction; // 0x0
	public Task<TResult> promise; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-TaskFactory.<>c__DisplayClass44_0<int, ArraySegment<byte>, Int32Enum, object>..ctor
	|-TaskFactory.<>c__DisplayClass44_0<int, object, int, object>..ctor
	|-TaskFactory.<>c__DisplayClass44_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <FromAsyncImpl>b__0(IAsyncResult iar) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0E640 Offset: 0xB0D840 VA: 0x180B0E640
	|-TaskFactory.<>c__DisplayClass44_0<int, ArraySegment<byte>, Int32Enum, object>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0E6E0 Offset: 0xB0D8E0 VA: 0x180B0E6E0
	|-TaskFactory.<>c__DisplayClass44_0<int, object, int, object>.<FromAsyncImpl>b__0
	|
	|-RVA: 0xB0E780 Offset: 0xB0D980 VA: 0x180B0E780
	|-TaskFactory.<>c__DisplayClass44_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<FromAsyncImpl>b__0
	*/
}

// Namespace: System.Threading.Tasks
public class TaskFactory<TResult> // TypeDefIndex: 3420
{
	// Fields
	private CancellationToken m_defaultCancellationToken; // 0x0
	private TaskScheduler m_defaultScheduler; // 0x0
	private TaskCreationOptions m_defaultCreationOptions; // 0x0
	private TaskContinuationOptions m_defaultContinuationOptions; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private TaskScheduler GetDefaultScheduler(Task currTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC59360 Offset: 0xC58560 VA: 0x180C59360
	|-TaskFactory<ArraySegment<byte>>.GetDefaultScheduler
	|
	|-RVA: 0xC59290 Offset: 0xC58490 VA: 0x180C59290
	|-TaskFactory<Nullable<int>>.GetDefaultScheduler
	|
	|-RVA: 0xC58800 Offset: 0xC57A00 VA: 0x180C58800
	|-TaskFactory<Nullable<JsonElement>>.GetDefaultScheduler
	|
	|-RVA: 0xC58DB0 Offset: 0xC57FB0 VA: 0x180C58DB0
	|-TaskFactory<ValueTuple<bool, object>>.GetDefaultScheduler
	|
	|-RVA: 0xC59500 Offset: 0xC58700 VA: 0x180C59500
	|-TaskFactory<ValueTuple<object, object, int>>.GetDefaultScheduler
	|
	|-RVA: 0xC58CE0 Offset: 0xC57EE0 VA: 0x180C58CE0
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>.GetDefaultScheduler
	|
	|-RVA: 0xC589A0 Offset: 0xC57BA0 VA: 0x180C589A0
	|-TaskFactory<bool>.GetDefaultScheduler
	|
	|-RVA: 0xC591C0 Offset: 0xC583C0 VA: 0x180C591C0
	|-TaskFactory<int>.GetDefaultScheduler
	|
	|-RVA: 0xC595D0 Offset: 0xC587D0 VA: 0x180C595D0
	|-TaskFactory<Int32Enum>.GetDefaultScheduler
	|
	|-RVA: 0xC58B40 Offset: 0xC57D40 VA: 0x180C58B40
	|-TaskFactory<long>.GetDefaultScheduler
	|
	|-RVA: 0xC590F0 Offset: 0xC582F0 VA: 0x180C590F0
	|-TaskFactory<JsonElement>.GetDefaultScheduler
	|
	|-RVA: 0xC59430 Offset: 0xC58630 VA: 0x180C59430
	|-TaskFactory<object>.GetDefaultScheduler
	|
	|-RVA: 0xC59770 Offset: 0xC58970 VA: 0x180C59770
	|-TaskFactory<SceneInstance>.GetDefaultScheduler
	|
	|-RVA: 0xC58F50 Offset: 0xC58150 VA: 0x180C58F50
	|-TaskFactory<SerializableProjectConfiguration>.GetDefaultScheduler
	|
	|-RVA: 0xC58C10 Offset: 0xC57E10 VA: 0x180C58C10
	|-TaskFactory<SocketReceiveFromResult>.GetDefaultScheduler
	|
	|-RVA: 0xC58730 Offset: 0xC57930 VA: 0x180C58730
	|-TaskFactory<SocketReceiveMessageFromResult>.GetDefaultScheduler
	|
	|-RVA: 0xC58E80 Offset: 0xC58080 VA: 0x180C58E80
	|-TaskFactory<UdpReceiveResult>.GetDefaultScheduler
	|
	|-RVA: 0xC588D0 Offset: 0xC57AD0 VA: 0x180C588D0
	|-TaskFactory<ValueWebSocketReceiveResult>.GetDefaultScheduler
	|
	|-RVA: 0xC58A70 Offset: 0xC57C70 VA: 0x180C58A70
	|-TaskFactory<VoidTaskResult>.GetDefaultScheduler
	|
	|-RVA: 0xC59020 Offset: 0xC58220 VA: 0x180C59020
	|-TaskFactory<WaitForChangedResult>.GetDefaultScheduler
	|
	|-RVA: 0xC596A0 Offset: 0xC588A0 VA: 0x180C596A0
	|-TaskFactory<__Il2CppFullySharedGenericType>.GetDefaultScheduler
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC5C980 Offset: 0xC5BB80 VA: 0x180C5C980
	|-TaskFactory<ArraySegment<byte>>..ctor
	|-TaskFactory<Nullable<int>>..ctor
	|-TaskFactory<Nullable<JsonElement>>..ctor
	|-TaskFactory<ValueTuple<bool, object>>..ctor
	|-TaskFactory<ValueTuple<object, object, int>>..ctor
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>..ctor
	|-TaskFactory<bool>..ctor
	|-TaskFactory<int>..ctor
	|-TaskFactory<Int32Enum>..ctor
	|-TaskFactory<long>..ctor
	|-TaskFactory<JsonElement>..ctor
	|-TaskFactory<object>..ctor
	|-TaskFactory<SceneInstance>..ctor
	|-TaskFactory<SerializableProjectConfiguration>..ctor
	|-TaskFactory<SocketReceiveFromResult>..ctor
	|-TaskFactory<SocketReceiveMessageFromResult>..ctor
	|-TaskFactory<UdpReceiveResult>..ctor
	|-TaskFactory<ValueWebSocketReceiveResult>..ctor
	|-TaskFactory<VoidTaskResult>..ctor
	|-TaskFactory<WaitForChangedResult>..ctor
	|
	|-RVA: 0xC5CA30 Offset: 0xC5BC30 VA: 0x180C5CA30
	|-TaskFactory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC5C9C0 Offset: 0xC5BBC0 VA: 0x180C5C9C0
	|-TaskFactory<ArraySegment<byte>>..ctor
	|-TaskFactory<Nullable<int>>..ctor
	|-TaskFactory<Nullable<JsonElement>>..ctor
	|-TaskFactory<ValueTuple<bool, object>>..ctor
	|-TaskFactory<ValueTuple<object, object, int>>..ctor
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>..ctor
	|-TaskFactory<bool>..ctor
	|-TaskFactory<int>..ctor
	|-TaskFactory<Int32Enum>..ctor
	|-TaskFactory<long>..ctor
	|-TaskFactory<JsonElement>..ctor
	|-TaskFactory<object>..ctor
	|-TaskFactory<SceneInstance>..ctor
	|-TaskFactory<SerializableProjectConfiguration>..ctor
	|-TaskFactory<SocketReceiveFromResult>..ctor
	|-TaskFactory<SocketReceiveMessageFromResult>..ctor
	|-TaskFactory<UdpReceiveResult>..ctor
	|-TaskFactory<ValueWebSocketReceiveResult>..ctor
	|-TaskFactory<VoidTaskResult>..ctor
	|-TaskFactory<WaitForChangedResult>..ctor
	|-TaskFactory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC59E40 Offset: 0xC59040 VA: 0x180C59E40
	|-TaskFactory<ArraySegment<byte>>.StartNew
	|
	|-RVA: 0xC5B0C0 Offset: 0xC5A2C0 VA: 0x180C5B0C0
	|-TaskFactory<Nullable<int>>.StartNew
	|
	|-RVA: 0xC5A4C0 Offset: 0xC596C0 VA: 0x180C5A4C0
	|-TaskFactory<Nullable<JsonElement>>.StartNew
	|
	|-RVA: 0xC59A80 Offset: 0xC58C80 VA: 0x180C59A80
	|-TaskFactory<ValueTuple<bool, object>>.StartNew
	|
	|-RVA: 0xC5A340 Offset: 0xC59540 VA: 0x180C5A340
	|-TaskFactory<ValueTuple<object, object, int>>.StartNew
	|
	|-RVA: 0xC5C630 Offset: 0xC5B830 VA: 0x180C5C630
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>.StartNew
	|
	|-RVA: 0xC5A640 Offset: 0xC59840 VA: 0x180C5A640
	|-TaskFactory<bool>.StartNew
	|
	|-RVA: 0xC5A880 Offset: 0xC59A80 VA: 0x180C5A880
	|-TaskFactory<int>.StartNew
	|
	|-RVA: 0xC5BAF0 Offset: 0xC5ACF0 VA: 0x180C5BAF0
	|-TaskFactory<Int32Enum>.StartNew
	|
	|-RVA: 0xC5AD00 Offset: 0xC59F00 VA: 0x180C5AD00
	|-TaskFactory<long>.StartNew
	|
	|-RVA: 0xC5AB80 Offset: 0xC59D80 VA: 0x180C5AB80
	|-TaskFactory<JsonElement>.StartNew
	|
	|-RVA: 0xC5C330 Offset: 0xC5B530 VA: 0x180C5C330
	|-TaskFactory<object>.StartNew
	|
	|-RVA: 0xC5B240 Offset: 0xC5A440 VA: 0x180C5B240
	|-TaskFactory<SceneInstance>.StartNew
	|
	|-RVA: 0xC5B970 Offset: 0xC5AB70 VA: 0x180C5B970
	|-TaskFactory<SerializableProjectConfiguration>.StartNew
	|
	|-RVA: 0xC5BF70 Offset: 0xC5B170 VA: 0x180C5BF70
	|-TaskFactory<SocketReceiveFromResult>.StartNew
	|
	|-RVA: 0xC59CC0 Offset: 0xC58EC0 VA: 0x180C59CC0
	|-TaskFactory<SocketReceiveMessageFromResult>.StartNew
	|
	|-RVA: 0xC5AA00 Offset: 0xC59C00 VA: 0x180C5AA00
	|-TaskFactory<UdpReceiveResult>.StartNew
	|
	|-RVA: 0xC5BC70 Offset: 0xC5AE70 VA: 0x180C5BC70
	|-TaskFactory<ValueWebSocketReceiveResult>.StartNew
	|
	|-RVA: 0xC59840 Offset: 0xC58A40 VA: 0x180C59840
	|-TaskFactory<VoidTaskResult>.StartNew
	|
	|-RVA: 0xC5BDF0 Offset: 0xC5AFF0 VA: 0x180C5BDF0
	|-TaskFactory<WaitForChangedResult>.StartNew
	|
	|-RVA: 0xC5C870 Offset: 0xC5BA70 VA: 0x180C5C870
	|-TaskFactory<__Il2CppFullySharedGenericType>.StartNew
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> StartNew(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC5B6C0 Offset: 0xC5A8C0 VA: 0x180C5B6C0
	|-TaskFactory<ArraySegment<byte>>.StartNew
	|
	|-RVA: 0xC5A7C0 Offset: 0xC599C0 VA: 0x180C5A7C0
	|-TaskFactory<Nullable<int>>.StartNew
	|
	|-RVA: 0xC5B600 Offset: 0xC5A800 VA: 0x180C5B600
	|-TaskFactory<Nullable<JsonElement>>.StartNew
	|
	|-RVA: 0xC5C1B0 Offset: 0xC5B3B0 VA: 0x180C5C1B0
	|-TaskFactory<ValueTuple<bool, object>>.StartNew
	|
	|-RVA: 0xC5B540 Offset: 0xC5A740 VA: 0x180C5B540
	|-TaskFactory<ValueTuple<object, object, int>>.StartNew
	|
	|-RVA: 0xC5C270 Offset: 0xC5B470 VA: 0x180C5C270
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>.StartNew
	|
	|-RVA: 0xC5AF40 Offset: 0xC5A140 VA: 0x180C5AF40
	|-TaskFactory<bool>.StartNew
	|
	|-RVA: 0xC5C0F0 Offset: 0xC5B2F0 VA: 0x180C5C0F0
	|-TaskFactory<int>.StartNew
	|
	|-RVA: 0xC5C4B0 Offset: 0xC5B6B0 VA: 0x180C5C4B0
	|-TaskFactory<Int32Enum>.StartNew
	|
	|-RVA: 0xC5B8B0 Offset: 0xC5AAB0 VA: 0x180C5B8B0
	|-TaskFactory<long>.StartNew
	|
	|-RVA: 0xC59C00 Offset: 0xC58E00 VA: 0x180C59C00
	|-TaskFactory<JsonElement>.StartNew
	|
	|-RVA: 0xC599C0 Offset: 0xC58BC0 VA: 0x180C599C0
	|-TaskFactory<object>.StartNew
	|
	|-RVA: 0xC5A100 Offset: 0xC59300 VA: 0x180C5A100
	|-TaskFactory<SceneInstance>.StartNew
	|
	|-RVA: 0xC5AE80 Offset: 0xC5A080 VA: 0x180C5AE80
	|-TaskFactory<SerializableProjectConfiguration>.StartNew
	|
	|-RVA: 0xC5B3C0 Offset: 0xC5A5C0 VA: 0x180C5B3C0
	|-TaskFactory<SocketReceiveFromResult>.StartNew
	|
	|-RVA: 0xC5B480 Offset: 0xC5A680 VA: 0x180C5B480
	|-TaskFactory<SocketReceiveMessageFromResult>.StartNew
	|
	|-RVA: 0xC5A1C0 Offset: 0xC593C0 VA: 0x180C5A1C0
	|-TaskFactory<UdpReceiveResult>.StartNew
	|
	|-RVA: 0xC5C7B0 Offset: 0xC5B9B0 VA: 0x180C5C7B0
	|-TaskFactory<ValueWebSocketReceiveResult>.StartNew
	|
	|-RVA: 0xC5A280 Offset: 0xC59480 VA: 0x180C5A280
	|-TaskFactory<VoidTaskResult>.StartNew
	|
	|-RVA: 0xC5C570 Offset: 0xC5B770 VA: 0x180C5C570
	|-TaskFactory<WaitForChangedResult>.StartNew
	|
	|-RVA: 0xC5B000 Offset: 0xC5A200 VA: 0x180C5B000
	|-TaskFactory<__Il2CppFullySharedGenericType>.StartNew
	*/

	// RVA: -1 Offset: -1
	private static void FromAsyncCoreLogic(IAsyncResult iar, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Task<TResult> promise, bool requiresSynchronization) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4FD50 Offset: 0xC4EF50 VA: 0x180C4FD50
	|-TaskFactory<ArraySegment<byte>>.FromAsyncCoreLogic
	|
	|-RVA: 0xC50880 Offset: 0xC4FA80 VA: 0x180C50880
	|-TaskFactory<Nullable<int>>.FromAsyncCoreLogic
	|
	|-RVA: 0xC51020 Offset: 0xC50220 VA: 0x180C51020
	|-TaskFactory<Nullable<JsonElement>>.FromAsyncCoreLogic
	|
	|-RVA: 0xC519F0 Offset: 0xC50BF0 VA: 0x180C519F0
	|-TaskFactory<ValueTuple<bool, object>>.FromAsyncCoreLogic
	|
	|-RVA: 0xC50E60 Offset: 0xC50060 VA: 0x180C50E60
	|-TaskFactory<ValueTuple<object, object, int>>.FromAsyncCoreLogic
	|
	|-RVA: 0xC51370 Offset: 0xC50570 VA: 0x180C51370
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>.FromAsyncCoreLogic
	|
	|-RVA: 0xC503C0 Offset: 0xC4F5C0 VA: 0x180C503C0
	|-TaskFactory<bool>.FromAsyncCoreLogic
	|
	|-RVA: 0xC51870 Offset: 0xC50A70 VA: 0x180C51870
	|-TaskFactory<int>.FromAsyncCoreLogic
	|
	|-RVA: 0xC500A0 Offset: 0xC4F2A0 VA: 0x180C500A0
	|-TaskFactory<Int32Enum>.FromAsyncCoreLogic
	|
	|-RVA: 0xC4FBC0 Offset: 0xC4EDC0 VA: 0x180C4FBC0
	|-TaskFactory<long>.FromAsyncCoreLogic
	|
	|-RVA: 0xC50540 Offset: 0xC4F740 VA: 0x180C50540
	|-TaskFactory<JsonElement>.FromAsyncCoreLogic
	|
	|-RVA: 0xC511E0 Offset: 0xC503E0 VA: 0x180C511E0
	|-TaskFactory<object>.FromAsyncCoreLogic
	|
	|-RVA: 0xC51B90 Offset: 0xC50D90 VA: 0x180C51B90
	|-TaskFactory<SceneInstance>.FromAsyncCoreLogic
	|
	|-RVA: 0xC50220 Offset: 0xC4F420 VA: 0x180C50220
	|-TaskFactory<SerializableProjectConfiguration>.FromAsyncCoreLogic
	|
	|-RVA: 0xC506E0 Offset: 0xC4F8E0 VA: 0x180C506E0
	|-TaskFactory<SocketReceiveFromResult>.FromAsyncCoreLogic
	|
	|-RVA: 0xC51520 Offset: 0xC50720 VA: 0x180C51520
	|-TaskFactory<SocketReceiveMessageFromResult>.FromAsyncCoreLogic
	|
	|-RVA: 0xC516D0 Offset: 0xC508D0 VA: 0x180C516D0
	|-TaskFactory<UdpReceiveResult>.FromAsyncCoreLogic
	|
	|-RVA: 0xC50CD0 Offset: 0xC4FED0 VA: 0x180C50CD0
	|-TaskFactory<ValueWebSocketReceiveResult>.FromAsyncCoreLogic
	|
	|-RVA: 0xC51D30 Offset: 0xC50F30 VA: 0x180C51D30
	|-TaskFactory<VoidTaskResult>.FromAsyncCoreLogic
	|
	|-RVA: 0xC4FEF0 Offset: 0xC4F0F0 VA: 0x180C4FEF0
	|-TaskFactory<WaitForChangedResult>.FromAsyncCoreLogic
	|
	|-RVA: 0xC50A10 Offset: 0xC4FC10 VA: 0x180C50A10
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsyncCoreLogic
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC58430 Offset: 0xC57630 VA: 0x180C58430
	|-TaskFactory<ArraySegment<byte>>.FromAsync
	|
	|-RVA: 0xC586F0 Offset: 0xC578F0 VA: 0x180C586F0
	|-TaskFactory<Nullable<int>>.FromAsync
	|
	|-RVA: 0xC584F0 Offset: 0xC576F0 VA: 0x180C584F0
	|-TaskFactory<Nullable<JsonElement>>.FromAsync
	|
	|-RVA: 0xC585B0 Offset: 0xC577B0 VA: 0x180C585B0
	|-TaskFactory<ValueTuple<bool, object>>.FromAsync
	|
	|-RVA: 0xC583F0 Offset: 0xC575F0 VA: 0x180C583F0
	|-TaskFactory<ValueTuple<object, object, int>>.FromAsync
	|
	|-RVA: 0xC58360 Offset: 0xC57560 VA: 0x180C58360
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>.FromAsync
	|
	|-RVA: 0xC58470 Offset: 0xC57670 VA: 0x180C58470
	|-TaskFactory<bool>.FromAsync
	|
	|-RVA: 0xC58260 Offset: 0xC57460 VA: 0x180C58260
	|-TaskFactory<int>.FromAsync
	|
	|-RVA: 0xC582A0 Offset: 0xC574A0 VA: 0x180C582A0
	|-TaskFactory<Int32Enum>.FromAsync
	|
	|-RVA: 0xC58630 Offset: 0xC57830 VA: 0x180C58630
	|-TaskFactory<long>.FromAsync
	|
	|-RVA: 0xC582E0 Offset: 0xC574E0 VA: 0x180C582E0
	|-TaskFactory<JsonElement>.FromAsync
	|
	|-RVA: 0xC58530 Offset: 0xC57730 VA: 0x180C58530
	|-TaskFactory<object>.FromAsync
	|
	|-RVA: 0xC58570 Offset: 0xC57770 VA: 0x180C58570
	|-TaskFactory<SceneInstance>.FromAsync
	|
	|-RVA: 0xC585F0 Offset: 0xC577F0 VA: 0x180C585F0
	|-TaskFactory<SerializableProjectConfiguration>.FromAsync
	|
	|-RVA: 0xC586B0 Offset: 0xC578B0 VA: 0x180C586B0
	|-TaskFactory<SocketReceiveFromResult>.FromAsync
	|
	|-RVA: 0xC58320 Offset: 0xC57520 VA: 0x180C58320
	|-TaskFactory<SocketReceiveMessageFromResult>.FromAsync
	|
	|-RVA: 0xC584B0 Offset: 0xC576B0 VA: 0x180C584B0
	|-TaskFactory<UdpReceiveResult>.FromAsync
	|
	|-RVA: 0xC581E0 Offset: 0xC573E0 VA: 0x180C581E0
	|-TaskFactory<ValueWebSocketReceiveResult>.FromAsync
	|
	|-RVA: 0xC58670 Offset: 0xC57870 VA: 0x180C58670
	|-TaskFactory<VoidTaskResult>.FromAsync
	|
	|-RVA: 0xC58220 Offset: 0xC57420 VA: 0x180C58220
	|-TaskFactory<WaitForChangedResult>.FromAsync
	|
	|-RVA: 0xC583A0 Offset: 0xC575A0 VA: 0x180C583A0
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsync
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncImpl(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC51EB0 Offset: 0xC510B0 VA: 0x180C51EB0
	|-TaskFactory<ArraySegment<byte>>.FromAsyncImpl
	|
	|-RVA: 0xC52380 Offset: 0xC51580 VA: 0x180C52380
	|-TaskFactory<Nullable<int>>.FromAsyncImpl
	|
	|-RVA: 0xC52CC0 Offset: 0xC51EC0 VA: 0x180C52CC0
	|-TaskFactory<Nullable<JsonElement>>.FromAsyncImpl
	|
	|-RVA: 0xC578A0 Offset: 0xC56AA0 VA: 0x180C578A0
	|-TaskFactory<ValueTuple<bool, object>>.FromAsyncImpl
	|
	|-RVA: 0xC55B80 Offset: 0xC54D80 VA: 0x180C55B80
	|-TaskFactory<ValueTuple<object, object, int>>.FromAsyncImpl
	|
	|-RVA: 0xC53640 Offset: 0xC52840 VA: 0x180C53640
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>.FromAsyncImpl
	|
	|-RVA: 0xC57400 Offset: 0xC56600 VA: 0x180C57400
	|-TaskFactory<bool>.FromAsyncImpl
	|
	|-RVA: 0xC556E0 Offset: 0xC548E0 VA: 0x180C556E0
	|-TaskFactory<int>.FromAsyncImpl
	|
	|-RVA: 0xC53B00 Offset: 0xC52D00 VA: 0x180C53B00
	|-TaskFactory<Int32Enum>.FromAsyncImpl
	|
	|-RVA: 0xC54440 Offset: 0xC53640 VA: 0x180C54440
	|-TaskFactory<long>.FromAsyncImpl
	|
	|-RVA: 0xC57D40 Offset: 0xC56F40 VA: 0x180C57D40
	|-TaskFactory<JsonElement>.FromAsyncImpl
	|
	|-RVA: 0xC54DA0 Offset: 0xC53FA0 VA: 0x180C54DA0
	|-TaskFactory<object>.FromAsyncImpl
	|
	|-RVA: 0xC56980 Offset: 0xC55B80 VA: 0x180C56980
	|-TaskFactory<SceneInstance>.FromAsyncImpl
	|
	|-RVA: 0xC55240 Offset: 0xC54440 VA: 0x180C55240
	|-TaskFactory<SerializableProjectConfiguration>.FromAsyncImpl
	|
	|-RVA: 0xC52820 Offset: 0xC51A20 VA: 0x180C52820
	|-TaskFactory<SocketReceiveFromResult>.FromAsyncImpl
	|
	|-RVA: 0xC548E0 Offset: 0xC53AE0 VA: 0x180C548E0
	|-TaskFactory<SocketReceiveMessageFromResult>.FromAsyncImpl
	|
	|-RVA: 0xC56040 Offset: 0xC55240 VA: 0x180C56040
	|-TaskFactory<UdpReceiveResult>.FromAsyncImpl
	|
	|-RVA: 0xC564E0 Offset: 0xC556E0 VA: 0x180C564E0
	|-TaskFactory<ValueWebSocketReceiveResult>.FromAsyncImpl
	|
	|-RVA: 0xC53FA0 Offset: 0xC531A0 VA: 0x180C53FA0
	|-TaskFactory<VoidTaskResult>.FromAsyncImpl
	|
	|-RVA: 0xC53180 Offset: 0xC52380 VA: 0x180C53180
	|-TaskFactory<WaitForChangedResult>.FromAsyncImpl
	|
	|-RVA: 0xC56E20 Offset: 0xC56020 VA: 0x180C56E20
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsyncImpl
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F6150 Offset: 0x8F5350 VA: 0x1808F6150
	|-TaskFactory<object>.FromAsync<object>
	|
	|-RVA: 0x8F5A00 Offset: 0x8F4C00 VA: 0x1808F5A00
	|-TaskFactory<SocketReceiveMessageFromResult>.FromAsync<ArraySegment<byte>>
	|
	|-RVA: 0x8F5E60 Offset: 0x8F5060 VA: 0x1808F5E60
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncImpl<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F4EC0 Offset: 0x8F40C0 VA: 0x1808F4EC0
	|-TaskFactory<object>.FromAsyncImpl<object>
	|
	|-RVA: 0x8F1C50 Offset: 0x8F0E50 VA: 0x1808F1C50
	|-TaskFactory<SocketReceiveMessageFromResult>.FromAsyncImpl<ArraySegment<byte>>
	|
	|-RVA: 0x8F4A60 Offset: 0x8F3C60 VA: 0x1808F4A60
	|-TaskFactory<VoidTaskResult>.FromAsyncImpl<object>
	|
	|-RVA: 0x8F2E50 Offset: 0x8F2050 VA: 0x1808F2E50
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsyncImpl<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F5960 Offset: 0x8F4B60 VA: 0x1808F5960
	|-TaskFactory<int>.FromAsync<ArraySegment<byte>, Int32Enum>
	|
	|-RVA: 0x8F5F80 Offset: 0x8F5180 VA: 0x1808F5F80
	|-TaskFactory<int>.FromAsync<object, int>
	|-TaskFactory<int>.FromAsync<object, Int32Enum>
	|
	|-RVA: 0x8F60C0 Offset: 0x8F52C0 VA: 0x1808F60C0
	|-TaskFactory<object>.FromAsync<object, int>
	|
	|-RVA: 0x8F58C0 Offset: 0x8F4AC0 VA: 0x1808F58C0
	|-TaskFactory<SocketReceiveFromResult>.FromAsync<ArraySegment<byte>, Int32Enum>
	|
	|-RVA: 0x8F5CC0 Offset: 0x8F4EC0 VA: 0x1808F5CC0
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsync<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncImpl<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F17E0 Offset: 0x8F09E0 VA: 0x1808F17E0
	|-TaskFactory<int>.FromAsyncImpl<ArraySegment<byte>, Int32Enum>
	|
	|-RVA: 0x8F3450 Offset: 0x8F2650 VA: 0x1808F3450
	|-TaskFactory<int>.FromAsyncImpl<object, int>
	|-TaskFactory<int>.FromAsyncImpl<object, Int32Enum>
	|
	|-RVA: 0x8F4190 Offset: 0x8F3390 VA: 0x1808F4190
	|-TaskFactory<object>.FromAsyncImpl<object, int>
	|
	|-RVA: 0x8F1360 Offset: 0x8F0560 VA: 0x1808F1360
	|-TaskFactory<SocketReceiveFromResult>.FromAsyncImpl<ArraySegment<byte>, Int32Enum>
	|
	|-RVA: 0x8F3D20 Offset: 0x8F2F20 VA: 0x1808F3D20
	|-TaskFactory<VoidTaskResult>.FromAsyncImpl<object, int>
	|
	|-RVA: 0x8F45F0 Offset: 0x8F37F0 VA: 0x1808F45F0
	|-TaskFactory<VoidTaskResult>.FromAsyncImpl<object, object>
	|
	|-RVA: 0x8F27D0 Offset: 0x8F19D0 VA: 0x1808F27D0
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsyncImpl<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> FromAsync<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F5810 Offset: 0x8F4A10 VA: 0x1808F5810
	|-TaskFactory<int>.FromAsync<ArraySegment<byte>, Int32Enum, object>
	|
	|-RVA: 0x8F6010 Offset: 0x8F5210 VA: 0x1808F6010
	|-TaskFactory<int>.FromAsync<object, int, object>
	|
	|-RVA: 0x8F5AA0 Offset: 0x8F4CA0 VA: 0x1808F5AA0
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsync<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncImpl<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F0EE0 Offset: 0x8F00E0 VA: 0x1808F0EE0
	|-TaskFactory<int>.FromAsyncImpl<ArraySegment<byte>, Int32Enum, object>
	|
	|-RVA: 0x8F38B0 Offset: 0x8F2AB0 VA: 0x1808F38B0
	|-TaskFactory<int>.FromAsyncImpl<object, int, object>
	|
	|-RVA: 0x8F20E0 Offset: 0x8F12E0 VA: 0x1808F20E0
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsyncImpl<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncTrim<TInstance, TArgs>(TInstance thisRef, TArgs args, Func<TInstance, TArgs, AsyncCallback, object, IAsyncResult> beginMethod, Func<TInstance, IAsyncResult, TResult> endMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F5510 Offset: 0x8F4710 VA: 0x1808F5510
	|-TaskFactory<int>.FromAsyncTrim<object, Stream.ReadWriteParameters>
	|
	|-RVA: 0x8F5690 Offset: 0x8F4890 VA: 0x1808F5690
	|-TaskFactory<VoidTaskResult>.FromAsyncTrim<object, Stream.ReadWriteParameters>
	|
	|-RVA: 0x8F5320 Offset: 0x8F4520 VA: 0x1808F5320
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsyncTrim<object, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Threading.Tasks
public enum TaskStatus // TypeDefIndex: 3421
{
	// Fields
	public int value__; // 0x0
	public const TaskStatus Created = 0;
	public const TaskStatus WaitingForActivation = 1;
	public const TaskStatus WaitingToRun = 2;
	public const TaskStatus Running = 3;
	public const TaskStatus WaitingForChildrenToComplete = 4;
	public const TaskStatus RanToCompletion = 5;
	public const TaskStatus Canceled = 6;
	public const TaskStatus Faulted = 7;
}

// Namespace: 
internal class Task.ContingentProperties // TypeDefIndex: 3422
{
	// Fields
	internal ExecutionContext m_capturedContext; // 0x10
	internal ManualResetEventSlim m_completionEvent; // 0x18
	internal TaskExceptionHolder m_exceptionsHolder; // 0x20
	internal CancellationToken m_cancellationToken; // 0x28
	internal object m_cancellationRegistration; // 0x30
	internal int m_internalCancellationRequested; // 0x38
	internal int m_completionCountdown; // 0x3C
	internal LowLevelListWithIList<Task> m_exceptionalChildren; // 0x40

	// Methods

	// RVA: 0x159AC60 Offset: 0x1599E60 VA: 0x18159AC60
	internal void SetCompleted() { }

	// RVA: 0x159AC90 Offset: 0x1599E90 VA: 0x18159AC90
	internal void UnregisterCancellationCallback() { }

	// RVA: 0x159AD40 Offset: 0x1599F40 VA: 0x18159AD40
	public void .ctor() { }
}

// Namespace: 
private sealed class Task.SetOnInvokeMres : ManualResetEventSlim, ITaskCompletionAction // TypeDefIndex: 3423
{
	// Properties
	public bool InvokeMayRunArbitraryCode { get; }

	// Methods

	// RVA: 0x15A0EC0 Offset: 0x15A00C0 VA: 0x1815A0EC0
	internal void .ctor() { }

	// RVA: 0x15A0EB0 Offset: 0x15A00B0 VA: 0x1815A0EB0 Slot: 6
	public void Invoke(Task completingTask) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	public bool get_InvokeMayRunArbitraryCode() { }
}

// Namespace: 
private sealed class Task.DelayPromise : Task<VoidTaskResult> // TypeDefIndex: 3424
{
	// Fields
	internal readonly CancellationToken Token; // 0x58
	internal CancellationTokenRegistration Registration; // 0x60
	internal Timer Timer; // 0x78

	// Methods

	// RVA: 0x159CDE0 Offset: 0x159BFE0 VA: 0x18159CDE0
	internal void .ctor(CancellationToken token) { }

	// RVA: 0x159CCD0 Offset: 0x159BED0 VA: 0x18159CCD0
	internal void Complete() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Task.<>c // TypeDefIndex: 3425
{
	// Fields
	public static readonly Task.<>c <>9; // 0x0
	public static Action<object> <>9__247_0; // 0x8
	public static TimerCallback <>9__247_1; // 0x10

	// Methods

	// RVA: 0x15B0B80 Offset: 0x15AFD80 VA: 0x1815B0B80
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x15B0300 Offset: 0x15AF500 VA: 0x1815B0300
	internal void <Delay>b__247_0(object state) { }

	// RVA: 0x15B0370 Offset: 0x15AF570 VA: 0x1815B0370
	internal void <Delay>b__247_1(object state) { }

	// RVA: 0x15B0590 Offset: 0x15AF790 VA: 0x1815B0590
	internal Task.ContingentProperties <.cctor>b__271_0() { }

	// RVA: 0x15B05E0 Offset: 0x15AF7E0 VA: 0x1815B05E0
	internal bool <.cctor>b__271_1(Task t) { }

	// RVA: 0x8D0790 Offset: 0x8CF990 VA: 0x1808D0790
	internal bool <.cctor>b__271_2(object tc) { }
}

// Namespace: System.Threading.Tasks
[DebuggerTypeProxy(typeof(SystemThreadingTasks_TaskDebugView))]
[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}")]
public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable // TypeDefIndex: 3426
{
	// Fields
	internal static int s_taskIdCounter; // 0x0
	private int m_taskId; // 0x10
	internal Delegate m_action; // 0x18
	internal object m_stateObject; // 0x20
	internal TaskScheduler m_taskScheduler; // 0x28
	internal readonly Task m_parent; // 0x30
	internal int m_stateFlags; // 0x38
	private const int OptionsMask = 65535;
	internal const int TASK_STATE_STARTED = 65536;
	internal const int TASK_STATE_DELEGATE_INVOKED = 131072;
	internal const int TASK_STATE_DISPOSED = 262144;
	internal const int TASK_STATE_EXCEPTIONOBSERVEDBYPARENT = 524288;
	internal const int TASK_STATE_CANCELLATIONACKNOWLEDGED = 1048576;
	internal const int TASK_STATE_FAULTED = 2097152;
	internal const int TASK_STATE_CANCELED = 4194304;
	internal const int TASK_STATE_WAITING_ON_CHILDREN = 8388608;
	internal const int TASK_STATE_RAN_TO_COMPLETION = 16777216;
	internal const int TASK_STATE_WAITINGFORACTIVATION = 33554432;
	internal const int TASK_STATE_COMPLETION_RESERVED = 67108864;
	internal const int TASK_STATE_THREAD_WAS_ABORTED = 134217728;
	internal const int TASK_STATE_WAIT_COMPLETION_NOTIFICATION = 268435456;
	private const int TASK_STATE_COMPLETED_MASK = 23068672;
	private const int CANCELLATION_REQUESTED = 1;
	private object m_continuationObject; // 0x40
	private static readonly object s_taskCompletionSentinel; // 0x8
	internal static bool s_asyncDebuggingEnabled; // 0x10
	internal Task.ContingentProperties m_contingentProperties; // 0x48
	private static readonly Action<object> s_taskCancelCallback; // 0x18
	[ThreadStatic]
	internal static Task t_currentTask; // 0x80000000
	[ThreadStatic]
	private static StackGuard t_stackGuard; // 0x80000008
	private static readonly Func<Task.ContingentProperties> s_createContingentProperties; // 0x20
	[CompilerGenerated]
	private static readonly TaskFactory <Factory>k__BackingField; // 0x28
	[CompilerGenerated]
	private static readonly Task <CompletedTask>k__BackingField; // 0x30
	private static readonly Predicate<Task> s_IsExceptionObservedByParentPredicate; // 0x38
	private static ContextCallback s_ecCallback; // 0x40
	private static readonly Predicate<object> s_IsTaskContinuationNullPredicate; // 0x48
	private static readonly Dictionary<int, Task> s_currentActiveTasks; // 0x50
	private static readonly object s_activeTasksLock; // 0x58

	// Properties
	internal TaskCreationOptions Options { get; }
	internal bool IsWaitNotificationEnabledOrNotRanToCompletion { get; }
	internal virtual bool ShouldNotifyDebuggerOfWaitCompletion { get; }
	internal bool IsWaitNotificationEnabled { get; }
	public int Id { get; }
	internal static Task InternalCurrent { get; }
	internal static StackGuard CurrentStackGuard { get; }
	public AggregateException Exception { get; }
	public TaskStatus Status { get; }
	public bool IsCanceled { get; }
	internal bool IsCancellationRequested { get; }
	internal CancellationToken CancellationToken { get; }
	internal bool IsCancellationAcknowledged { get; }
	public bool IsCompleted { get; }
	public bool IsCompletedSuccessfully { get; }
	public TaskCreationOptions CreationOptions { get; }
	private WaitHandle System.IAsyncResult.AsyncWaitHandle { get; }
	public object AsyncState { get; }
	private bool System.IAsyncResult.CompletedSynchronously { get; }
	internal TaskScheduler ExecutingTaskScheduler { get; }
	public static TaskFactory Factory { get; }
	public static Task CompletedTask { get; }
	internal ManualResetEventSlim CompletedEvent { get; }
	internal bool ExceptionRecorded { get; }
	public bool IsFaulted { get; }
	internal ExecutionContext CapturedContext { get; set; }
	internal bool IsExceptionObservedByParent { get; }
	internal bool IsDelegateInvoked { get; }

	// Methods

	// RVA: 0x15AB2B0 Offset: 0x15AA4B0 VA: 0x1815AB2B0
	internal void .ctor(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct) { }

	// RVA: 0x15AB440 Offset: 0x15AA640 VA: 0x1815AB440
	internal void .ctor() { }

	// RVA: 0x15AB470 Offset: 0x15AA670 VA: 0x1815AB470
	internal void .ctor(object state, TaskCreationOptions creationOptions, bool promiseStyle) { }

	// RVA: 0x15AB370 Offset: 0x15AA570 VA: 0x1815AB370
	internal void .ctor(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x15AA380 Offset: 0x15A9580 VA: 0x1815AA380
	internal void TaskConstructorCore(Delegate action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x15A52C0 Offset: 0x15A44C0 VA: 0x1815A52C0
	private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation) { }

	// RVA: 0x15AA260 Offset: 0x15A9460 VA: 0x1815AA260
	private static void TaskCancelCallback(object o) { }

	// RVA: 0x15AA5F0 Offset: 0x15A97F0 VA: 0x1815AA5F0
	internal bool TrySetCanceled(CancellationToken tokenToRecord) { }

	// RVA: 0x15AA600 Offset: 0x15A9800 VA: 0x1815AA600
	internal bool TrySetCanceled(CancellationToken tokenToRecord, object cancellationException) { }

	// RVA: 0x15AA700 Offset: 0x15A9900 VA: 0x1815AA700
	internal bool TrySetException(object exceptionObject) { }

	// RVA: 0x15ABCF0 Offset: 0x15AAEF0 VA: 0x1815ABCF0
	internal TaskCreationOptions get_Options() { }

	// RVA: 0x937680 Offset: 0x936880 VA: 0x180937680
	internal static TaskCreationOptions OptionsMethod(int flags) { }

	// RVA: 0x15A5640 Offset: 0x15A4840 VA: 0x1815A5640
	internal bool AtomicStateUpdate(int newBits, int illegalBits) { }

	// RVA: 0x15A5580 Offset: 0x15A4780 VA: 0x1815A5580
	internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags) { }

	// RVA: 0x15A9B20 Offset: 0x15A8D20 VA: 0x1815A9B20
	internal void SetNotificationForWaitCompletion(bool enabled) { }

	// RVA: 0x15A8BD0 Offset: 0x15A7DD0 VA: 0x1815A8BD0
	internal bool NotifyDebuggerOfWaitCompletionIfNecessary() { }

	// RVA: 0x15ABCA0 Offset: 0x15AAEA0 VA: 0x1815ABCA0
	internal bool get_IsWaitNotificationEnabledOrNotRanToCompletion() { }

	// RVA: 0x15ABCD0 Offset: 0x15AAED0 VA: 0x1815ABCD0 Slot: 11
	internal virtual bool get_ShouldNotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x15ABCD0 Offset: 0x15AAED0 VA: 0x1815ABCD0
	internal bool get_IsWaitNotificationEnabled() { }

	// RVA: 0x15A8C30 Offset: 0x15A7E30 VA: 0x1815A8C30
	private void NotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x15A8BB0 Offset: 0x15A7DB0 VA: 0x1815A8BB0
	internal bool MarkStarted() { }

	// RVA: 0x15A4D40 Offset: 0x15A3F40 VA: 0x1815A4D40
	internal void AddNewChild() { }

	// RVA: 0x15A6A90 Offset: 0x15A5C90 VA: 0x1815A6A90
	internal void DisregardChild() { }

	// RVA: 0x15A8510 Offset: 0x15A7710 VA: 0x1815A8510
	internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions) { }

	// RVA: 0x15AB9F0 Offset: 0x15AABF0 VA: 0x1815AB9F0
	public int get_Id() { }

	// RVA: 0x15ABA90 Offset: 0x15AAC90 VA: 0x1815ABA90
	internal static Task get_InternalCurrent() { }

	// RVA: 0x15A8480 Offset: 0x15A7680 VA: 0x1815A8480
	internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions) { }

	// RVA: 0x15AB820 Offset: 0x15AAA20 VA: 0x1815AB820
	internal static StackGuard get_CurrentStackGuard() { }

	// RVA: 0x15AB950 Offset: 0x15AAB50 VA: 0x1815AB950
	public AggregateException get_Exception() { }

	// RVA: 0x15ABD40 Offset: 0x15AAF40 VA: 0x1815ABD40
	public TaskStatus get_Status() { }

	// RVA: 0x15ABAE0 Offset: 0x15AACE0 VA: 0x1815ABAE0
	public bool get_IsCanceled() { }

	// RVA: 0x15ABB30 Offset: 0x15AAD30 VA: 0x1815ABB30
	internal bool get_IsCancellationRequested() { }

	// RVA: 0x15A6BA0 Offset: 0x15A5DA0 VA: 0x1815A6BA0
	internal Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection) { }

	// RVA: 0x15A6AD0 Offset: 0x15A5CD0 VA: 0x1815A6AD0
	private Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection) { }

	// RVA: 0x15AB5A0 Offset: 0x15AA7A0 VA: 0x1815AB5A0
	internal CancellationToken get_CancellationToken() { }

	// RVA: 0x15ABB10 Offset: 0x15AAD10 VA: 0x1815ABB10
	internal bool get_IsCancellationAcknowledged() { }

	// RVA: 0x15ABBE0 Offset: 0x15AADE0 VA: 0x1815ABBE0 Slot: 6
	public bool get_IsCompleted() { }

	// RVA: 0x15A8B60 Offset: 0x15A7D60 VA: 0x1815A8B60
	private static bool IsCompletedMethod(int flags) { }

	// RVA: 0x15ABBB0 Offset: 0x15AADB0 VA: 0x1815ABBB0
	public bool get_IsCompletedSuccessfully() { }

	// RVA: 0x15AB7D0 Offset: 0x15AA9D0 VA: 0x1815AB7D0
	public TaskCreationOptions get_CreationOptions() { }

	// RVA: 0x15AA0B0 Offset: 0x15A92B0 VA: 0x1815AA0B0 Slot: 7
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 8
	public object get_AsyncState() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 9
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal TaskScheduler get_ExecutingTaskScheduler() { }

	[CompilerGenerated]
	// RVA: 0x15AB9A0 Offset: 0x15AABA0 VA: 0x1815AB9A0
	public static TaskFactory get_Factory() { }

	[CompilerGenerated]
	// RVA: 0x15AB780 Offset: 0x15AA980 VA: 0x1815AB780
	public static Task get_CompletedTask() { }

	// RVA: 0x15AB650 Offset: 0x15AA850 VA: 0x1815AB650
	internal ManualResetEventSlim get_CompletedEvent() { }

	// RVA: 0x15AB8E0 Offset: 0x15AAAE0 VA: 0x1815AB8E0
	internal bool get_ExceptionRecorded() { }

	// RVA: 0x15ABC80 Offset: 0x15AAE80 VA: 0x1815ABC80
	public bool get_IsFaulted() { }

	// RVA: 0x15AB5D0 Offset: 0x15AA7D0 VA: 0x1815AB5D0
	internal ExecutionContext get_CapturedContext() { }

	// RVA: 0x15ABDD0 Offset: 0x15AAFD0 VA: 0x1815ABDD0
	internal void set_CapturedContext(ExecutionContext value) { }

	// RVA: 0x15A6A20 Offset: 0x15A5C20 VA: 0x1815A6A20 Slot: 10
	public void Dispose() { }

	// RVA: 0x15A68C0 Offset: 0x15A5AC0 VA: 0x1815A68C0 Slot: 12
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x15A97C0 Offset: 0x15A89C0 VA: 0x1815A97C0
	internal void ScheduleAndStart(bool needsProtection) { }

	// RVA: 0x15A49C0 Offset: 0x15A3BC0 VA: 0x1815A49C0
	internal void AddException(object exceptionObject) { }

	// RVA: 0x15A4720 Offset: 0x15A3920 VA: 0x1815A4720
	internal void AddException(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x15A7EE0 Offset: 0x15A70E0 VA: 0x1815A7EE0
	private AggregateException GetExceptions(bool includeTaskCanceledExceptions) { }

	// RVA: 0x15A7CC0 Offset: 0x15A6EC0 VA: 0x1815A7CC0
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x15A7C80 Offset: 0x15A6E80 VA: 0x1815A7C80
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x15AA5A0 Offset: 0x15A97A0 VA: 0x1815AA5A0
	internal void ThrowIfExceptional(bool includeTaskCanceledExceptions) { }

	// RVA: 0x15AA770 Offset: 0x15A9970 VA: 0x1815AA770
	internal void UpdateExceptionObservedStatus() { }

	// RVA: 0x15ABC60 Offset: 0x15AAE60 VA: 0x1815ABC60
	internal bool get_IsExceptionObservedByParent() { }

	// RVA: 0x15ABC40 Offset: 0x15AAE40 VA: 0x1815ABC40
	internal bool get_IsDelegateInvoked() { }

	// RVA: 0x15A7900 Offset: 0x15A6B00 VA: 0x1815A7900
	internal void Finish(bool bUserDelegateExecuted) { }

	// RVA: 0x15A77C0 Offset: 0x15A69C0 VA: 0x1815A77C0
	internal void FinishStageTwo() { }

	// RVA: 0x15A7720 Offset: 0x15A6920 VA: 0x1815A7720
	internal void FinishStageThree() { }

	// RVA: 0x15A8C60 Offset: 0x15A7E60 VA: 0x1815A8C60
	internal void ProcessChildCompletion(Task childTask) { }

	// RVA: 0x15A49D0 Offset: 0x15A3BD0 VA: 0x1815A49D0
	internal void AddExceptionsFromChildren() { }

	// RVA: 0x15A7050 Offset: 0x15A6250 VA: 0x1815A7050
	private void Execute() { }

	// RVA: 0x15AA250 Offset: 0x15A9450 VA: 0x1815AA250 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x15A6CA0 Offset: 0x15A5EA0 VA: 0x1815A6CA0
	internal bool ExecuteEntry(bool bPreventDoubleExecution) { }

	// RVA: 0x15A7090 Offset: 0x15A6290 VA: 0x1815A7090
	private static void ExecutionContextCallback(object obj) { }

	// RVA: 0x15A81F0 Offset: 0x15A73F0 VA: 0x1815A81F0 Slot: 13
	internal virtual void InnerInvoke() { }

	// RVA: 0x15A80C0 Offset: 0x15A72C0 VA: 0x1815A80C0
	private void HandleException(Exception unhandledException) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	public TaskAwaiter GetAwaiter() { }

	// RVA: 0x15A57D0 Offset: 0x15A49D0 VA: 0x1815A57D0
	public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	// RVA: 0x15A9970 Offset: 0x15A8B70 VA: 0x1815A9970
	internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext) { }

	// RVA: 0x15AA890 Offset: 0x15A9A90 VA: 0x1815AA890
	public void Wait() { }

	// RVA: 0x15AA880 Offset: 0x15A9A80 VA: 0x1815AA880
	public bool Wait(int millisecondsTimeout) { }

	// RVA: 0x15AA8A0 Offset: 0x15A9AA0 VA: 0x1815AA8A0
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x15AAF00 Offset: 0x15AA100 VA: 0x1815AAF00
	private bool WrappedTryRunInline() { }

	// RVA: 0x15A8690 Offset: 0x15A7890 VA: 0x1815A8690
	internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x15A9BF0 Offset: 0x15A8DF0 VA: 0x1815A9BF0
	private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x15A9F50 Offset: 0x15A9150 VA: 0x1815A9F50
	private bool SpinWait(int millisecondsTimeout) { }

	// RVA: 0x15A8290 Offset: 0x15A7490 VA: 0x1815A8290
	internal bool InternalCancel(bool bCancelNonExecutingOnly) { }

	// RVA: 0x15A8FA0 Offset: 0x15A81A0 VA: 0x1815A8FA0
	internal void RecordInternalCancellationRequest() { }

	// RVA: 0x15A8F00 Offset: 0x15A8100 VA: 0x1815A8F00
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord) { }

	// RVA: 0x15A8E30 Offset: 0x15A8030 VA: 0x1815A8E30
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException) { }

	// RVA: 0x15A5700 Offset: 0x15A4900 VA: 0x1815A5700
	internal void CancellationCleanupLogic() { }

	// RVA: 0x15A9940 Offset: 0x15A8B40 VA: 0x1815A9940
	private void SetCancellationAcknowledged() { }

	// RVA: 0x15A7150 Offset: 0x15A6350 VA: 0x1815A7150
	internal void FinishContinuations() { }

	// RVA: 0x15A8B70 Offset: 0x15A7D70 VA: 0x1815A8B70
	private void LogFinishCompletionNotification() { }

	// RVA: 0x15A5A60 Offset: 0x15A4C60 VA: 0x1815A5A60
	public Task ContinueWith(Action<Task> continuationAction) { }

	// RVA: 0x15A5DF0 Offset: 0x15A4FF0 VA: 0x1815A5DF0
	public Task ContinueWith(Action<Task> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	// RVA: 0x15A5B60 Offset: 0x15A4D60 VA: 0x1815A5B60
	private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }

	// RVA: 0x15A5A30 Offset: 0x15A4C30 VA: 0x1815A5A30
	public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	// RVA: 0x15A5E20 Offset: 0x15A5020 VA: 0x1815A5E20
	private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }

	// RVA: -1 Offset: -1
	public Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA83B70 Offset: 0xA82D70 VA: 0x180A83B70
	|-Task.ContinueWith<object>
	|
	|-RVA: 0x8F61E0 Offset: 0x8F53E0 VA: 0x1808F61E0
	|-Task.ContinueWith<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private Task<TResult> ContinueWith<TResult>(Func<Task, TResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA83990 Offset: 0xA82B90 VA: 0x180A83990
	|-Task.ContinueWith<object>
	|
	|-RVA: 0xA837B0 Offset: 0xA829B0 VA: 0x180A837B0
	|-Task.ContinueWith<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x15A60B0 Offset: 0x15A52B0 VA: 0x1815A60B0
	internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions) { }

	// RVA: 0x15A57F0 Offset: 0x15A49F0 VA: 0x1815A57F0
	internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options) { }

	// RVA: 0x15A4630 Offset: 0x15A3830 VA: 0x1815A4630
	internal void AddCompletionAction(ITaskCompletionAction action) { }

	// RVA: 0x15A46A0 Offset: 0x15A38A0 VA: 0x1815A46A0
	private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers) { }

	// RVA: 0x15A4DC0 Offset: 0x15A3FC0 VA: 0x1815A4DC0
	private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers) { }

	// RVA: 0x15A50A0 Offset: 0x15A42A0 VA: 0x1815A50A0
	private bool AddTaskContinuation(object tc, bool addBeforeOthers) { }

	// RVA: 0x15A8FD0 Offset: 0x15A81D0 VA: 0x1815A8FD0
	internal void RemoveContinuation(object continuationObject) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromResult<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA84D00 Offset: 0xA83F00 VA: 0x180A84D00
	|-Task.FromResult<bool>
	|
	|-RVA: 0xA84E60 Offset: 0xA84060 VA: 0x180A84E60
	|-Task.FromResult<int>
	|
	|-RVA: 0xA84ED0 Offset: 0xA840D0 VA: 0x180A84ED0
	|-Task.FromResult<object>
	|
	|-RVA: 0xA84D70 Offset: 0xA83F70 VA: 0x180A84D70
	|-Task.FromResult<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x15A7C20 Offset: 0x15A6E20 VA: 0x1815A7C20
	public static Task FromException(Exception exception) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromException<TResult>(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA849C0 Offset: 0xA83BC0 VA: 0x180A849C0
	|-Task.FromException<int>
	|
	|-RVA: 0xA84A90 Offset: 0xA83C90 VA: 0x180A84A90
	|-Task.FromException<object>
	|
	|-RVA: 0xA84B60 Offset: 0xA83D60 VA: 0x180A84B60
	|-Task.FromException<ValueWebSocketReceiveResult>
	|
	|-RVA: 0xA84C30 Offset: 0xA83E30 VA: 0x180A84C30
	|-Task.FromException<VoidTaskResult>
	|
	|-RVA: 0xA848F0 Offset: 0xA83AF0 VA: 0x180A848F0
	|-Task.FromException<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x15A7AD0 Offset: 0x15A6CD0 VA: 0x1815A7AD0
	internal static Task FromCancellation(CancellationToken cancellationToken) { }

	// RVA: 0x15A7A80 Offset: 0x15A6C80 VA: 0x1815A7A80
	public static Task FromCanceled(CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA840C0 Offset: 0xA832C0 VA: 0x180A840C0
	|-Task.FromCancellation<bool>
	|
	|-RVA: 0xA84450 Offset: 0xA83650 VA: 0x180A84450
	|-Task.FromCancellation<int>
	|
	|-RVA: 0xA84620 Offset: 0xA83820 VA: 0x180A84620
	|-Task.FromCancellation<object>
	|
	|-RVA: 0xA84720 Offset: 0xA83920 VA: 0x180A84720
	|-Task.FromCancellation<ValueWebSocketReceiveResult>
	|
	|-RVA: 0xA84290 Offset: 0xA83490 VA: 0x180A84290
	|-Task.FromCancellation<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> FromCanceled<TResult>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA83DE0 Offset: 0xA82FE0 VA: 0x180A83DE0
	|-Task.FromCanceled<int>
	|
	|-RVA: 0xA83F20 Offset: 0xA83120 VA: 0x180A83F20
	|-Task.FromCanceled<object>
	|
	|-RVA: 0xA83F80 Offset: 0xA83180 VA: 0x180A83F80
	|-Task.FromCanceled<ValueWebSocketReceiveResult>
	|
	|-RVA: 0xA83D70 Offset: 0xA82F70 VA: 0x180A83D70
	|-Task.FromCanceled<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA84550 Offset: 0xA83750 VA: 0x180A84550
	|-Task.FromCancellation<int>
	|
	|-RVA: 0xA84820 Offset: 0xA83A20 VA: 0x180A84820
	|-Task.FromCancellation<VoidTaskResult>
	|
	|-RVA: 0xA841C0 Offset: 0xA833C0 VA: 0x180A841C0
	|-Task.FromCancellation<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x15A9350 Offset: 0x15A8550 VA: 0x1815A9350
	public static Task Run(Action action) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<TResult> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA852C0 Offset: 0xA844C0 VA: 0x180A852C0
	|-Task.Run<int>
	|
	|-RVA: 0xA85390 Offset: 0xA84590 VA: 0x180A85390
	|-Task.Run<object>
	|
	|-RVA: 0xA84FB0 Offset: 0xA841B0 VA: 0x180A84FB0
	|-Task.Run<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x15A9530 Offset: 0x15A8730 VA: 0x1815A9530
	public static Task Run(Func<Task> function) { }

	// RVA: 0x15A9580 Offset: 0x15A8780 VA: 0x1815A9580
	public static Task Run(Func<Task> function, CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<Task<TResult>> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA85460 Offset: 0xA84660 VA: 0x180A85460
	|-Task.Run<object>
	|
	|-RVA: 0xA84F40 Offset: 0xA84140 VA: 0x180A84F40
	|-Task.Run<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA854D0 Offset: 0xA846D0 VA: 0x180A854D0
	|-Task.Run<object>
	|
	|-RVA: 0xA85080 Offset: 0xA84280 VA: 0x180A85080
	|-Task.Run<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x15A6210 Offset: 0x15A5410 VA: 0x1815A6210
	public static Task Delay(TimeSpan delay, CancellationToken cancellationToken) { }

	// RVA: 0x15A6310 Offset: 0x15A5510 VA: 0x1815A6310
	public static Task Delay(int millisecondsDelay) { }

	// RVA: 0x15A6360 Offset: 0x15A5560 VA: 0x1815A6360
	public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken) { }

	// RVA: 0x15AACD0 Offset: 0x15A9ED0 VA: 0x1815AACD0
	public static Task<Task> WhenAny(Task[] tasks) { }

	// RVA: 0x15AAA10 Offset: 0x15A9C10 VA: 0x1815AAA10
	public static Task<Task> WhenAny(IEnumerable<Task> tasks) { }

	[FriendAccessAllowed]
	// RVA: 0x15A5180 Offset: 0x15A4380 VA: 0x1815A5180
	internal static bool AddToActiveTasks(Task task) { }

	[FriendAccessAllowed]
	// RVA: 0x15A9230 Offset: 0x15A8430 VA: 0x1815A9230
	internal static void RemoveFromActiveTasks(int taskId) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	public void MarkAborted(ThreadAbortException e) { }

	// RVA: 0x15A6E50 Offset: 0x15A6050 VA: 0x1815A6E50
	private void ExecuteWithThreadLocal(ref Task currentTaskSlot) { }

	// RVA: 0x15AAFA0 Offset: 0x15AA1A0 VA: 0x1815AAFA0
	private static void .cctor() { }
}

// Namespace: System.Threading.Tasks
internal sealed class CompletionActionInvoker : IThreadPoolWorkItem // TypeDefIndex: 3427
{
	// Fields
	private readonly ITaskCompletionAction m_action; // 0x10
	private readonly Task m_completingTask; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	internal void .ctor(ITaskCompletionAction action, Task completingTask) { }

	// RVA: 0x159AC10 Offset: 0x1599E10 VA: 0x18159AC10 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	public void MarkAborted(ThreadAbortException e) { }
}

// Namespace: System.Threading.Tasks
internal class SystemThreadingTasks_TaskDebugView // TypeDefIndex: 3428
{}

// Namespace: System.Threading.Tasks
[Flags]
public enum TaskCreationOptions // TypeDefIndex: 3429
{
	// Fields
	public int value__; // 0x0
	public const TaskCreationOptions None = 0;
	public const TaskCreationOptions PreferFairness = 1;
	public const TaskCreationOptions LongRunning = 2;
	public const TaskCreationOptions AttachedToParent = 4;
	public const TaskCreationOptions DenyChildAttach = 8;
	public const TaskCreationOptions HideScheduler = 16;
	public const TaskCreationOptions RunContinuationsAsynchronously = 64;
}

// Namespace: System.Threading.Tasks
[Flags]
internal enum InternalTaskOptions // TypeDefIndex: 3430
{
	// Fields
	public int value__; // 0x0
	public const InternalTaskOptions None = 0;
	public const InternalTaskOptions InternalOptionsMask = 65280;
	public const InternalTaskOptions ContinuationTask = 512;
	public const InternalTaskOptions PromiseTask = 1024;
	public const InternalTaskOptions LazyCancellation = 4096;
	public const InternalTaskOptions QueuedByRuntime = 8192;
	public const InternalTaskOptions DoNotDispose = 16384;
}

// Namespace: System.Threading.Tasks
[Flags]
public enum TaskContinuationOptions // TypeDefIndex: 3431
{
	// Fields
	public int value__; // 0x0
	public const TaskContinuationOptions None = 0;
	public const TaskContinuationOptions PreferFairness = 1;
	public const TaskContinuationOptions LongRunning = 2;
	public const TaskContinuationOptions AttachedToParent = 4;
	public const TaskContinuationOptions DenyChildAttach = 8;
	public const TaskContinuationOptions HideScheduler = 16;
	public const TaskContinuationOptions LazyCancellation = 32;
	public const TaskContinuationOptions RunContinuationsAsynchronously = 64;
	public const TaskContinuationOptions NotOnRanToCompletion = 65536;
	public const TaskContinuationOptions NotOnFaulted = 131072;
	public const TaskContinuationOptions NotOnCanceled = 262144;
	public const TaskContinuationOptions OnlyOnRanToCompletion = 393216;
	public const TaskContinuationOptions OnlyOnFaulted = 327680;
	public const TaskContinuationOptions OnlyOnCanceled = 196608;
	public const TaskContinuationOptions ExecuteSynchronously = 524288;
}

// Namespace: System.Threading.Tasks
internal class StackGuard // TypeDefIndex: 3432
{
	// Fields
	private int m_inliningDepth; // 0x10
	private const int MAX_UNCHECKED_INLINING_DEPTH = 20;

	// Methods

	// RVA: 0x15A0F20 Offset: 0x15A0120 VA: 0x1815A0F20
	internal bool TryBeginInliningScope() { }

	// RVA: 0x15A0F10 Offset: 0x15A0110 VA: 0x1815A0F10
	internal void EndInliningScope() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Threading.Tasks
internal struct VoidTaskResult // TypeDefIndex: 3433
{}

// Namespace: System.Threading.Tasks
internal interface ITaskCompletionAction // TypeDefIndex: 3434
{
	// Properties
	public abstract bool InvokeMayRunArbitraryCode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Invoke(Task completingTask);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_InvokeMayRunArbitraryCode();
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UnwrapPromise.<>c<TResult> // TypeDefIndex: 3435
{
	// Fields
	public static readonly UnwrapPromise.<>c<TResult> <>9; // 0x0
	public static WaitCallback <>9__8_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08330 Offset: 0xB07530 VA: 0x180B08330
	|-UnwrapPromise.<>c<object>..cctor
	|-UnwrapPromise.<>c<VoidTaskResult>..cctor
	|
	|-RVA: 0xB08640 Offset: 0xB07840 VA: 0x180B08640
	|-UnwrapPromise.<>c<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-UnwrapPromise.<>c<object>..ctor
	|-UnwrapPromise.<>c<VoidTaskResult>..ctor
	|-UnwrapPromise.<>c<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <InvokeCoreAsync>b__8_0(object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB06810 Offset: 0xB05A10 VA: 0x180B06810
	|-UnwrapPromise.<>c<object>.<InvokeCoreAsync>b__8_0
	|
	|-RVA: 0xB06760 Offset: 0xB05960 VA: 0x180B06760
	|-UnwrapPromise.<>c<VoidTaskResult>.<InvokeCoreAsync>b__8_0
	|
	|-RVA: 0xB068C0 Offset: 0xB05AC0 VA: 0x180B068C0
	|-UnwrapPromise.<>c<__Il2CppFullySharedGenericType>.<InvokeCoreAsync>b__8_0
	*/
}

// Namespace: System.Threading.Tasks
internal sealed class UnwrapPromise<TResult> : Task<TResult>, ITaskCompletionAction // TypeDefIndex: 3436
{
	// Fields
	private byte _state; // 0x0
	private readonly bool _lookForOce; // 0x0

	// Properties
	public bool InvokeMayRunArbitraryCode { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Task outerTask, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE73E0 Offset: 0xCE65E0 VA: 0x180CE73E0
	|-UnwrapPromise<object>..ctor
	|
	|-RVA: 0xCE76E0 Offset: 0xCE68E0 VA: 0x180CE76E0
	|-UnwrapPromise<VoidTaskResult>..ctor
	|
	|-RVA: 0xCE7530 Offset: 0xCE6730 VA: 0x180CE7530
	|-UnwrapPromise<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void Invoke(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE5E80 Offset: 0xCE5080 VA: 0x180CE5E80
	|-UnwrapPromise<object>.Invoke
	|
	|-RVA: 0xCE5FE0 Offset: 0xCE51E0 VA: 0x180CE5FE0
	|-UnwrapPromise<VoidTaskResult>.Invoke
	|
	|-RVA: 0xCE5D60 Offset: 0xCE4F60 VA: 0x180CE5D60
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	private void InvokeCore(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE5BF0 Offset: 0xCE4DF0 VA: 0x180CE5BF0
	|-UnwrapPromise<object>.InvokeCore
	|
	|-RVA: 0xCE5D10 Offset: 0xCE4F10 VA: 0x180CE5D10
	|-UnwrapPromise<VoidTaskResult>.InvokeCore
	|
	|-RVA: 0xCE5C40 Offset: 0xCE4E40 VA: 0x180CE5C40
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.InvokeCore
	*/

	// RVA: -1 Offset: -1
	private void InvokeCoreAsync(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE56A0 Offset: 0xCE48A0 VA: 0x180CE56A0
	|-UnwrapPromise<object>.InvokeCoreAsync
	|
	|-RVA: 0xCE5860 Offset: 0xCE4A60 VA: 0x180CE5860
	|-UnwrapPromise<VoidTaskResult>.InvokeCoreAsync
	|
	|-RVA: 0xCE5A20 Offset: 0xCE4C20 VA: 0x180CE5A20
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.InvokeCoreAsync
	*/

	// RVA: -1 Offset: -1
	private void ProcessCompletedOuterTask(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE6140 Offset: 0xCE5340 VA: 0x180CE6140
	|-UnwrapPromise<object>.ProcessCompletedOuterTask
	|
	|-RVA: 0xCE65B0 Offset: 0xCE57B0 VA: 0x180CE65B0
	|-UnwrapPromise<VoidTaskResult>.ProcessCompletedOuterTask
	|
	|-RVA: 0xCE6370 Offset: 0xCE5570 VA: 0x180CE6370
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.ProcessCompletedOuterTask
	*/

	// RVA: -1 Offset: -1
	private bool TrySetFromTask(Task task, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE6DE0 Offset: 0xCE5FE0 VA: 0x180CE6DE0
	|-UnwrapPromise<object>.TrySetFromTask
	|
	|-RVA: 0xCE70E0 Offset: 0xCE62E0 VA: 0x180CE70E0
	|-UnwrapPromise<VoidTaskResult>.TrySetFromTask
	|
	|-RVA: 0xCE69C0 Offset: 0xCE5BC0 VA: 0x180CE69C0
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.TrySetFromTask
	*/

	// RVA: -1 Offset: -1
	private void ProcessInnerTask(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE67E0 Offset: 0xCE59E0 VA: 0x180CE67E0
	|-UnwrapPromise<object>.ProcessInnerTask
	|
	|-RVA: 0xCE6870 Offset: 0xCE5A70 VA: 0x180CE6870
	|-UnwrapPromise<VoidTaskResult>.ProcessInnerTask
	|
	|-RVA: 0xCE6900 Offset: 0xCE5B00 VA: 0x180CE6900
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.ProcessInnerTask
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool get_InvokeMayRunArbitraryCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-UnwrapPromise<object>.get_InvokeMayRunArbitraryCode
	|-UnwrapPromise<VoidTaskResult>.get_InvokeMayRunArbitraryCode
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.get_InvokeMayRunArbitraryCode
	*/
}

// Namespace: System.Threading.Tasks
internal sealed class ContinuationTaskFromTask : Task // TypeDefIndex: 3437
{
	// Fields
	private Task m_antecedent; // 0x50

	// Methods

	// RVA: 0x159AE70 Offset: 0x159A070 VA: 0x18159AE70
	public void .ctor(Task antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }

	// RVA: 0x159AD70 Offset: 0x1599F70 VA: 0x18159AD70 Slot: 13
	internal override void InnerInvoke() { }
}

// Namespace: System.Threading.Tasks
internal sealed class ContinuationResultTaskFromTask<TResult> : Task<TResult> // TypeDefIndex: 3438
{
	// Fields
	private Task m_antecedent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Task antecedent, Delegate function, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB9BA0 Offset: 0xFB8DA0 VA: 0x180FB9BA0
	|-ContinuationResultTaskFromTask<object>..ctor
	|
	|-RVA: 0xFB9C70 Offset: 0xFB8E70 VA: 0x180FB9C70
	|-ContinuationResultTaskFromTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB98D0 Offset: 0xFB8AD0 VA: 0x180FB98D0
	|-ContinuationResultTaskFromTask<object>.InnerInvoke
	|
	|-RVA: 0xFB99C0 Offset: 0xFB8BC0 VA: 0x180FB99C0
	|-ContinuationResultTaskFromTask<__Il2CppFullySharedGenericType>.InnerInvoke
	*/
}

// Namespace: System.Threading.Tasks
internal sealed class ContinuationTaskFromResultTask<TAntecedentResult> : Task // TypeDefIndex: 3439
{
	// Fields
	private Task<TAntecedentResult> m_antecedent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Task<TAntecedentResult> antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFBA400 Offset: 0xFB9600 VA: 0x180FBA400
	|-ContinuationTaskFromResultTask<ArraySegment<byte>>..ctor
	|
	|-RVA: 0xFBAA00 Offset: 0xFB9C00 VA: 0x180FBAA00
	|-ContinuationTaskFromResultTask<Nullable<int>>..ctor
	|
	|-RVA: 0xFBA340 Offset: 0xFB9540 VA: 0x180FBA340
	|-ContinuationTaskFromResultTask<Nullable<JsonElement>>..ctor
	|
	|-RVA: 0xFBA4C0 Offset: 0xFB96C0 VA: 0x180FBA4C0
	|-ContinuationTaskFromResultTask<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0xFBA640 Offset: 0xFB9840 VA: 0x180FBA640
	|-ContinuationTaskFromResultTask<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0xFB9F80 Offset: 0xFB9180 VA: 0x180FB9F80
	|-ContinuationTaskFromResultTask<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0xFBA580 Offset: 0xFB9780 VA: 0x180FBA580
	|-ContinuationTaskFromResultTask<bool>..ctor
	|
	|-RVA: 0xFBA940 Offset: 0xFB9B40 VA: 0x180FBA940
	|-ContinuationTaskFromResultTask<int>..ctor
	|
	|-RVA: 0xFBA1C0 Offset: 0xFB93C0 VA: 0x180FBA1C0
	|-ContinuationTaskFromResultTask<Int32Enum>..ctor
	|
	|-RVA: 0xFBA100 Offset: 0xFB9300 VA: 0x180FBA100
	|-ContinuationTaskFromResultTask<long>..ctor
	|
	|-RVA: 0xFBAE80 Offset: 0xFBA080 VA: 0x180FBAE80
	|-ContinuationTaskFromResultTask<JsonElement>..ctor
	|
	|-RVA: 0xFBA280 Offset: 0xFB9480 VA: 0x180FBA280
	|-ContinuationTaskFromResultTask<object>..ctor
	|
	|-RVA: 0xFBA7C0 Offset: 0xFB99C0 VA: 0x180FBA7C0
	|-ContinuationTaskFromResultTask<SceneInstance>..ctor
	|
	|-RVA: 0xFBA880 Offset: 0xFB9A80 VA: 0x180FBA880
	|-ContinuationTaskFromResultTask<SerializableProjectConfiguration>..ctor
	|
	|-RVA: 0xFBAB80 Offset: 0xFB9D80 VA: 0x180FBAB80
	|-ContinuationTaskFromResultTask<SocketReceiveFromResult>..ctor
	|
	|-RVA: 0xFBA040 Offset: 0xFB9240 VA: 0x180FBA040
	|-ContinuationTaskFromResultTask<SocketReceiveMessageFromResult>..ctor
	|
	|-RVA: 0xFBA700 Offset: 0xFB9900 VA: 0x180FBA700
	|-ContinuationTaskFromResultTask<UdpReceiveResult>..ctor
	|
	|-RVA: 0xFBAD00 Offset: 0xFB9F00 VA: 0x180FBAD00
	|-ContinuationTaskFromResultTask<ValueWebSocketReceiveResult>..ctor
	|
	|-RVA: 0xFBADC0 Offset: 0xFB9FC0 VA: 0x180FBADC0
	|-ContinuationTaskFromResultTask<VoidTaskResult>..ctor
	|
	|-RVA: 0xFBAAC0 Offset: 0xFB9CC0 VA: 0x180FBAAC0
	|-ContinuationTaskFromResultTask<WaitForChangedResult>..ctor
	|
	|-RVA: 0xFBAC40 Offset: 0xFB9E40 VA: 0x180FBAC40
	|-ContinuationTaskFromResultTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB9D70 Offset: 0xFB8F70 VA: 0x180FB9D70
	|-ContinuationTaskFromResultTask<ArraySegment<byte>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<int>>.InnerInvoke
	|-ContinuationTaskFromResultTask<Nullable<JsonElement>>.InnerInvoke
	|-ContinuationTaskFromResultTask<ValueTuple<bool, object>>.InnerInvoke
	|-ContinuationTaskFromResultTask<ValueTuple<object, object, int>>.InnerInvoke
	|-ContinuationTaskFromResultTask<ValueTuple<object, bool, bool, object, object>>.InnerInvoke
	|-ContinuationTaskFromResultTask<bool>.InnerInvoke
	|-ContinuationTaskFromResultTask<int>.InnerInvoke
	|-ContinuationTaskFromResultTask<Int32Enum>.InnerInvoke
	|-ContinuationTaskFromResultTask<long>.InnerInvoke
	|-ContinuationTaskFromResultTask<JsonElement>.InnerInvoke
	|-ContinuationTaskFromResultTask<object>.InnerInvoke
	|-ContinuationTaskFromResultTask<SceneInstance>.InnerInvoke
	|-ContinuationTaskFromResultTask<SerializableProjectConfiguration>.InnerInvoke
	|-ContinuationTaskFromResultTask<SocketReceiveFromResult>.InnerInvoke
	|-ContinuationTaskFromResultTask<SocketReceiveMessageFromResult>.InnerInvoke
	|-ContinuationTaskFromResultTask<UdpReceiveResult>.InnerInvoke
	|-ContinuationTaskFromResultTask<ValueWebSocketReceiveResult>.InnerInvoke
	|-ContinuationTaskFromResultTask<VoidTaskResult>.InnerInvoke
	|-ContinuationTaskFromResultTask<WaitForChangedResult>.InnerInvoke
	|
	|-RVA: 0xFB9E60 Offset: 0xFB9060 VA: 0x180FB9E60
	|-ContinuationTaskFromResultTask<__Il2CppFullySharedGenericType>.InnerInvoke
	*/
}

// Namespace: System.Threading.Tasks
internal sealed class ContinuationResultTaskFromResultTask<TAntecedentResult, TResult> : Task<TResult> // TypeDefIndex: 3440
{
	// Fields
	private Task<TAntecedentResult> m_antecedent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Task<TAntecedentResult> antecedent, Delegate function, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB9730 Offset: 0xFB8930 VA: 0x180FB9730
	|-ContinuationResultTaskFromResultTask<int, Nullable<int>>..ctor
	|
	|-RVA: 0xFB9560 Offset: 0xFB8760 VA: 0x180FB9560
	|-ContinuationResultTaskFromResultTask<object, Nullable<int>>..ctor
	|
	|-RVA: 0xFB9800 Offset: 0xFB8A00 VA: 0x180FB9800
	|-ContinuationResultTaskFromResultTask<object, object>..ctor
	|
	|-RVA: 0xFB9630 Offset: 0xFB8830 VA: 0x180FB9630
	|-ContinuationResultTaskFromResultTask<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB9290 Offset: 0xFB8490 VA: 0x180FB9290
	|-ContinuationResultTaskFromResultTask<int, Nullable<int>>.InnerInvoke
	|-ContinuationResultTaskFromResultTask<object, Nullable<int>>.InnerInvoke
	|-ContinuationResultTaskFromResultTask<object, object>.InnerInvoke
	|
	|-RVA: 0xFB9380 Offset: 0xFB8580 VA: 0x180FB9380
	|-ContinuationResultTaskFromResultTask<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InnerInvoke
	*/
}

// Namespace: System.Threading.Tasks
internal abstract class TaskContinuation // TypeDefIndex: 3441
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void Run(Task completedTask, bool bCanInlineContinuationTask);

	// RVA: 0x15A18E0 Offset: 0x15A0AE0 VA: 0x1815A18E0
	protected static void InlineIfPossibleOrElseQueue(Task task, bool needsProtection) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Threading.Tasks
internal class StandardTaskContinuation : TaskContinuation // TypeDefIndex: 3442
{
	// Fields
	internal readonly Task m_task; // 0x10
	internal readonly TaskContinuationOptions m_options; // 0x18
	private readonly TaskScheduler m_taskScheduler; // 0x20

	// Methods

	// RVA: 0x15A1080 Offset: 0x15A0280 VA: 0x1815A1080
	internal void .ctor(Task task, TaskContinuationOptions options, TaskScheduler scheduler) { }

	// RVA: 0x15A0F50 Offset: 0x15A0150 VA: 0x1815A0F50 Slot: 4
	internal override void Run(Task completedTask, bool bCanInlineContinuationTask) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SynchronizationContextAwaitTaskContinuation.<>c // TypeDefIndex: 3443
{
	// Fields
	public static readonly SynchronizationContextAwaitTaskContinuation.<>c <>9; // 0x0

	// Methods

	// RVA: 0x15B0A00 Offset: 0x15AFC00 VA: 0x1815B0A00
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x15B0860 Offset: 0x15AFA60 VA: 0x1815B0860
	internal void <.cctor>b__7_0(object state) { }
}

// Namespace: System.Threading.Tasks
internal sealed class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation // TypeDefIndex: 3444
{
	// Fields
	private static readonly SendOrPostCallback s_postCallback; // 0x0
	private static ContextCallback s_postActionCallback; // 0x8
	private readonly SynchronizationContext m_syncContext; // 0x20

	// Methods

	// RVA: 0x15A1510 Offset: 0x15A0710 VA: 0x1815A1510
	internal void .ctor(SynchronizationContext context, Action action, bool flowExecutionContext) { }

	// RVA: 0x15A12B0 Offset: 0x15A04B0 VA: 0x1815A12B0 Slot: 4
	internal sealed override void Run(Task ignored, bool canInlineContinuationTask) { }

	// RVA: 0x15A1200 Offset: 0x15A0400 VA: 0x1815A1200
	private static void PostAction(object state) { }

	// RVA: 0x15A1130 Offset: 0x15A0330 VA: 0x1815A1130
	private static ContextCallback GetPostActionCallback() { }

	// RVA: 0x15A1450 Offset: 0x15A0650 VA: 0x1815A1450
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TaskSchedulerAwaitTaskContinuation.<>c // TypeDefIndex: 3445
{
	// Fields
	public static readonly TaskSchedulerAwaitTaskContinuation.<>c <>9; // 0x0
	public static Action<object> <>9__2_0; // 0x8

	// Methods

	// RVA: 0x15B0A60 Offset: 0x15AFC60 VA: 0x1815B0A60
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x15B0440 Offset: 0x15AF640 VA: 0x1815B0440
	internal void <Run>b__2_0(object state) { }
}

// Namespace: System.Threading.Tasks
internal sealed class TaskSchedulerAwaitTaskContinuation : AwaitTaskContinuation // TypeDefIndex: 3446
{
	// Fields
	private readonly TaskScheduler m_scheduler; // 0x20

	// Methods

	// RVA: 0x15A1510 Offset: 0x15A0710 VA: 0x1815A1510
	internal void .ctor(TaskScheduler scheduler, Action action, bool flowExecutionContext) { }

	// RVA: 0x15A2FE0 Offset: 0x15A21E0 VA: 0x1815A2FE0 Slot: 4
	internal sealed override void Run(Task ignored, bool canInlineContinuationTask) { }
}

// Namespace: System.Threading.Tasks
internal class AwaitTaskContinuation : TaskContinuation, IThreadPoolWorkItem // TypeDefIndex: 3447
{
	// Fields
	private readonly ExecutionContext m_capturedContext; // 0x10
	protected readonly Action m_action; // 0x18
	private static ContextCallback s_invokeActionCallback; // 0x0

	// Properties
	internal static bool IsValidLocationForInlining { get; }

	// Methods

	// RVA: 0x159A6E0 Offset: 0x15998E0 VA: 0x18159A6E0
	internal void .ctor(Action action, bool flowExecutionContext) { }

	// RVA: 0x1599FB0 Offset: 0x15991B0 VA: 0x181599FB0
	protected Task CreateTask(Action<object> action, object state, TaskScheduler scheduler) { }

	// RVA: 0x159A4B0 Offset: 0x15996B0 VA: 0x18159A4B0 Slot: 4
	internal override void Run(Task ignored, bool canInlineContinuationTask) { }

	// RVA: 0x159A760 Offset: 0x1599960 VA: 0x18159A760
	internal static bool get_IsValidLocationForInlining() { }

	// RVA: 0x159A570 Offset: 0x1599770 VA: 0x18159A570 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x159A220 Offset: 0x1599420 VA: 0x18159A220
	private static void InvokeAction(object state) { }

	// RVA: 0x159A180 Offset: 0x1599380 VA: 0x18159A180
	protected static ContextCallback GetInvokeActionCallback() { }

	// RVA: 0x159A290 Offset: 0x1599490 VA: 0x18159A290
	protected void RunCallback(ContextCallback callback, object state, ref Task currentTask) { }

	// RVA: 0x159A3C0 Offset: 0x15995C0 VA: 0x18159A3C0
	internal static void RunOrScheduleAction(Action action, bool allowInlining, ref Task currentTask) { }

	// RVA: 0x159A660 Offset: 0x1599860 VA: 0x18159A660
	internal static void UnsafeScheduleAction(Action action) { }

	// RVA: 0x159A610 Offset: 0x1599810 VA: 0x18159A610
	protected static void ThrowAsyncIfNecessary(Exception exc) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void MarkAborted(ThreadAbortException e) { }
}

// Namespace: System.Threading.Tasks
internal class TaskExceptionHolder // TypeDefIndex: 3448
{
	// Fields
	private static readonly bool s_failFastOnUnobservedException; // 0x0
	private readonly Task m_task; // 0x10
	private LowLevelListWithIList<ExceptionDispatchInfo> m_faultExceptions; // 0x18
	private ExceptionDispatchInfo m_cancellationException; // 0x20
	private bool m_isHandled; // 0x28

	// Properties
	internal bool ContainsFaultList { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(Task task) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	private static bool ShouldFailFastOnUnobservedException() { }

	// RVA: 0x15A2100 Offset: 0x15A1300 VA: 0x1815A2100 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x15A25F0 Offset: 0x15A17F0 VA: 0x1815A25F0
	internal bool get_ContainsFaultList() { }

	// RVA: 0x15A1E20 Offset: 0x15A1020 VA: 0x1815A1E20
	internal void Add(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x15A24B0 Offset: 0x15A16B0 VA: 0x1815A24B0
	private void SetCancellationException(object exceptionObject) { }

	// RVA: 0x15A19E0 Offset: 0x15A0BE0 VA: 0x1815A19E0
	private void AddFaultException(object exceptionObject) { }

	// RVA: 0x15A2440 Offset: 0x15A1640 VA: 0x1815A2440
	private void MarkAsUnhandled() { }

	// RVA: 0x15A23C0 Offset: 0x15A15C0 VA: 0x1815A23C0
	internal void MarkAsHandled(bool calledFromFinalizer) { }

	// RVA: 0x15A1F30 Offset: 0x15A1130 VA: 0x1815A1F30
	internal AggregateException CreateExceptionObject(bool calledFromFinalizer, Exception includeThisException) { }

	// RVA: 0x15A22F0 Offset: 0x15A14F0 VA: 0x1815A22F0
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x15A25B0 Offset: 0x15A17B0 VA: 0x1815A25B0
	private static void .cctor() { }
}

// Namespace: 
internal sealed class TaskFactory.CompleteOnInvokePromise : Task<Task>, ITaskCompletionAction // TypeDefIndex: 3449
{
	// Fields
	private IList<Task> _tasks; // 0x58

	// Properties
	public bool InvokeMayRunArbitraryCode { get; }

	// Methods

	// RVA: 0x159AB70 Offset: 0x1599D70 VA: 0x18159AB70
	public void .ctor(IList<Task> tasks) { }

	// RVA: 0x159A9D0 Offset: 0x1599BD0 VA: 0x18159A9D0 Slot: 14
	public void Invoke(Task completingTask) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 15
	public bool get_InvokeMayRunArbitraryCode() { }
}

// Namespace: System.Threading.Tasks
public class TaskFactory // TypeDefIndex: 3450
{
	// Fields
	private readonly CancellationToken m_defaultCancellationToken; // 0x10
	private readonly TaskScheduler m_defaultScheduler; // 0x18
	private readonly TaskCreationOptions m_defaultCreationOptions; // 0x20
	private readonly TaskContinuationOptions m_defaultContinuationOptions; // 0x24

	// Methods

	// RVA: 0x15A2DE0 Offset: 0x15A1FE0 VA: 0x1815A2DE0
	public void .ctor() { }

	// RVA: 0x15A2E10 Offset: 0x15A2010 VA: 0x1815A2E10
	public void .ctor(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	// RVA: 0x15A2610 Offset: 0x15A1810 VA: 0x1815A2610
	internal static void CheckCreationOptions(TaskCreationOptions creationOptions) { }

	// RVA: 0x15A2C20 Offset: 0x15A1E20 VA: 0x1815A2C20
	public Task StartNew(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

	// RVA: -1 Offset: -1
	public Task<TResult> StartNew<TResult>(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA83280 Offset: 0xA82480 VA: 0x180A83280
	|-TaskFactory.StartNew<object>
	|
	|-RVA: 0xA83110 Offset: 0xA82310 VA: 0x180A83110
	|-TaskFactory.StartNew<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA83050 Offset: 0xA82250 VA: 0x180A83050
	|-TaskFactory.StartNew<bool>
	|
	|-RVA: 0xA83330 Offset: 0xA82530 VA: 0x180A83330
	|-TaskFactory.StartNew<object>
	|
	|-RVA: 0xA831C0 Offset: 0xA823C0 VA: 0x180A831C0
	|-TaskFactory.StartNew<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x15A2BA0 Offset: 0x15A1DA0 VA: 0x1815A2BA0
	public Task FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, object state) { }

	// RVA: 0x15A2B40 Offset: 0x15A1D40 VA: 0x1815A2B40
	public Task FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, object state, TaskCreationOptions creationOptions) { }

	// RVA: -1 Offset: -1
	public Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA82FB0 Offset: 0xA821B0 VA: 0x180A82FB0
	|-TaskFactory.FromAsync<object>
	|
	|-RVA: 0xA82AD0 Offset: 0xA81CD0 VA: 0x180A82AD0
	|-TaskFactory.FromAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA82F40 Offset: 0xA82140 VA: 0x180A82F40
	|-TaskFactory.FromAsync<object>
	|
	|-RVA: 0xA82BF0 Offset: 0xA81DF0 VA: 0x180A82BF0
	|-TaskFactory.FromAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA82D70 Offset: 0xA81F70 VA: 0x180A82D70
	|-TaskFactory.FromAsync<object, int>
	|
	|-RVA: 0xA82E90 Offset: 0xA82090 VA: 0x180A82E90
	|-TaskFactory.FromAsync<object, object>
	|
	|-RVA: 0xA82940 Offset: 0xA81B40 VA: 0x180A82940
	|-TaskFactory.FromAsync<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA82D00 Offset: 0xA81F00 VA: 0x180A82D00
	|-TaskFactory.FromAsync<object, int>
	|
	|-RVA: 0xA82E20 Offset: 0xA82020 VA: 0x180A82E20
	|-TaskFactory.FromAsync<object, object>
	|
	|-RVA: 0xA827A0 Offset: 0xA819A0 VA: 0x180A827A0
	|-TaskFactory.FromAsync<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x15A2680 Offset: 0x15A1880 VA: 0x1815A2680
	internal static void CheckFromAsyncOptions(TaskCreationOptions creationOptions, bool hasBeginMethod) { }

	// RVA: 0x15A28F0 Offset: 0x15A1AF0 VA: 0x1815A28F0
	internal static Task<Task> CommonCWAnyLogic(IList<Task> tasks) { }

	// RVA: 0x15A27B0 Offset: 0x15A19B0 VA: 0x1815A27B0
	internal static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions) { }
}

// Namespace: 
internal sealed class TaskScheduler.SystemThreadingTasks_TaskSchedulerDebugView // TypeDefIndex: 3451
{}

// Namespace: System.Threading.Tasks
[DebuggerDisplay("Id={Id}")]
[DebuggerTypeProxy(typeof(TaskScheduler.SystemThreadingTasks_TaskSchedulerDebugView))]
public abstract class TaskScheduler // TypeDefIndex: 3452
{
	// Fields
	private static ConditionalWeakTable<TaskScheduler, object> s_activeTaskSchedulers; // 0x0
	private static readonly TaskScheduler s_defaultTaskScheduler; // 0x8
	internal static int s_taskSchedulerIdCounter; // 0x10
	private int m_taskSchedulerId; // 0x10
	private static EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException; // 0x18
	private static readonly Lock _unobservedTaskExceptionLockObject; // 0x20

	// Properties
	internal virtual bool RequiresAtomicStartTransition { get; }
	public static TaskScheduler Default { get; }
	public static TaskScheduler Current { get; }
	internal static TaskScheduler InternalCurrent { get; }
	public int Id { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected internal abstract void QueueTask(Task task);

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued);

	// RVA: 0x15A37F0 Offset: 0x15A29F0 VA: 0x1815A37F0
	internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 6
	protected internal virtual bool TryDequeue(Task task) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	internal virtual void NotifyWorkItemProgress() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 8
	internal virtual bool get_RequiresAtomicStartTransition() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x15A3DA0 Offset: 0x15A2FA0 VA: 0x1815A3DA0
	public static TaskScheduler get_Default() { }

	// RVA: 0x15A3D00 Offset: 0x15A2F00 VA: 0x1815A3D00
	public static TaskScheduler get_Current() { }

	// RVA: 0x15A3E90 Offset: 0x15A3090 VA: 0x1815A3E90
	internal static TaskScheduler get_InternalCurrent() { }

	// RVA: 0x15A3580 Offset: 0x15A2780 VA: 0x1815A3580
	public static TaskScheduler FromCurrentSynchronizationContext() { }

	// RVA: 0x15A3DF0 Offset: 0x15A2FF0 VA: 0x1815A3DF0
	public int get_Id() { }

	// RVA: 0x15A3770 Offset: 0x15A2970 VA: 0x1815A3770
	protected bool TryExecuteTask(Task task) { }

	// RVA: 0x15A3B80 Offset: 0x15A2D80 VA: 0x1815A3B80
	public static void add_UnobservedTaskException(EventHandler<UnobservedTaskExceptionEventArgs> value) { }

	// RVA: 0x15A3F70 Offset: 0x15A3170 VA: 0x1815A3F70
	public static void remove_UnobservedTaskException(EventHandler<UnobservedTaskExceptionEventArgs> value) { }

	// RVA: 0x15A3650 Offset: 0x15A2850 VA: 0x1815A3650
	internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea) { }

	// RVA: 0x15A3AB0 Offset: 0x15A2CB0 VA: 0x1815A3AB0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SynchronizationContextTaskScheduler.<>c // TypeDefIndex: 3453
{
	// Fields
	public static readonly SynchronizationContextTaskScheduler.<>c <>9; // 0x0

	// Methods

	// RVA: 0x15B0AC0 Offset: 0x15AFCC0 VA: 0x1815B0AC0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x15B08D0 Offset: 0x15AFAD0 VA: 0x1815B08D0
	internal void <.cctor>b__8_0(object s) { }
}

// Namespace: System.Threading.Tasks
internal sealed class SynchronizationContextTaskScheduler : TaskScheduler // TypeDefIndex: 3454
{
	// Fields
	private SynchronizationContext m_synchronizationContext; // 0x18
	private static readonly SendOrPostCallback s_postCallback; // 0x0

	// Methods

	// RVA: 0x15A1740 Offset: 0x15A0940 VA: 0x1815A1740
	internal void .ctor() { }

	// RVA: 0x15A1550 Offset: 0x15A0750 VA: 0x1815A1550 Slot: 4
	protected internal override void QueueTask(Task task) { }

	// RVA: 0x15A15E0 Offset: 0x15A07E0 VA: 0x1815A15E0 Slot: 5
	protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x15A1680 Offset: 0x15A0880 VA: 0x1815A1680
	private static void .cctor() { }
}

// Namespace: System.Threading.Tasks
public class UnobservedTaskExceptionEventArgs : EventArgs // TypeDefIndex: 3455
{
	// Fields
	private AggregateException m_exception; // 0x10
	internal bool m_observed; // 0x18

	// Properties
	public AggregateException Exception { get; }

	// Methods

	// RVA: 0x15B0CA0 Offset: 0x15AFEA0 VA: 0x1815B0CA0
	public void .ctor(AggregateException exception) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public AggregateException get_Exception() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ThreadPoolTaskScheduler.<>c // TypeDefIndex: 3456
{
	// Fields
	public static readonly ThreadPoolTaskScheduler.<>c <>9; // 0x0

	// Methods

	// RVA: 0x15B0B20 Offset: 0x15AFD20 VA: 0x1815B0B20
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x15B04C0 Offset: 0x15AF6C0 VA: 0x1815B04C0
	internal void <.cctor>b__10_0(object s) { }
}

// Namespace: System.Threading.Tasks
internal sealed class ThreadPoolTaskScheduler : TaskScheduler // TypeDefIndex: 3457
{
	// Fields
	private static readonly ParameterizedThreadStart s_longRunningThreadWork; // 0x0

	// Properties
	internal override bool RequiresAtomicStartTransition { get; }

	// Methods

	// RVA: 0x15AC880 Offset: 0x15ABA80 VA: 0x1815AC880
	internal void .ctor() { }

	// RVA: 0x15AC450 Offset: 0x15AB650 VA: 0x1815AC450 Slot: 4
	protected internal override void QueueTask(Task task) { }

	// RVA: 0x15AC6F0 Offset: 0x15AB8F0 VA: 0x1815AC6F0 Slot: 5
	protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x15AC6E0 Offset: 0x15AB8E0 VA: 0x1815AC6E0 Slot: 6
	protected internal override bool TryDequeue(Task task) { }

	// RVA: 0x15AC430 Offset: 0x15AB630 VA: 0x1815AC430 Slot: 7
	internal override void NotifyWorkItemProgress() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 8
	internal override bool get_RequiresAtomicStartTransition() { }

	// RVA: 0x15AC7C0 Offset: 0x15AB9C0 VA: 0x1815AC7C0
	private static void .cctor() { }
}

// Namespace: System.Threading.Tasks
[FriendAccessAllowed]
internal enum CausalityTraceLevel // TypeDefIndex: 3458
{
	// Fields
	public int value__; // 0x0
	public const CausalityTraceLevel Required = 0;
	public const CausalityTraceLevel Important = 1;
	public const CausalityTraceLevel Verbose = 2;
}

// Namespace: System.Threading.Tasks
[FriendAccessAllowed]
internal enum AsyncCausalityStatus // TypeDefIndex: 3459
{
	// Fields
	public int value__; // 0x0
	public const AsyncCausalityStatus Started = 0;
	public const AsyncCausalityStatus Completed = 1;
	public const AsyncCausalityStatus Canceled = 2;
	public const AsyncCausalityStatus Error = 3;
}

// Namespace: System.Threading.Tasks
internal enum CausalityRelation // TypeDefIndex: 3460
{
	// Fields
	public int value__; // 0x0
	public const CausalityRelation AssignDelegate = 0;
	public const CausalityRelation Join = 1;
	public const CausalityRelation Choice = 2;
	public const CausalityRelation Cancel = 3;
	public const CausalityRelation Error = 4;
}

// Namespace: System.Threading.Tasks
internal enum CausalitySynchronousWork // TypeDefIndex: 3461
{
	// Fields
	public int value__; // 0x0
	public const CausalitySynchronousWork CompletionNotification = 0;
	public const CausalitySynchronousWork ProgressNotification = 1;
	public const CausalitySynchronousWork Execution = 2;
}

// Namespace: System.Threading.Tasks
[FriendAccessAllowed]
internal static class AsyncCausalityTracer // TypeDefIndex: 3462
{
	// Properties
	[FriendAccessAllowed]
	internal static bool LoggingOn { get; }

	// Methods

	[FriendAccessAllowed]
	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	internal static bool get_LoggingOn() { }

	[FriendAccessAllowed]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal static void TraceOperationCreation(CausalityTraceLevel traceLevel, int taskId, string operationName, ulong relatedContext) { }

	[FriendAccessAllowed]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal static void TraceOperationCompletion(CausalityTraceLevel traceLevel, int taskId, AsyncCausalityStatus status) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, int taskId, CausalitySynchronousWork work) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work) { }
}

// Namespace: System.Threading.Tasks.Sources
[Flags]
public enum ValueTaskSourceOnCompletedFlags // TypeDefIndex: 3463
{
	// Fields
	public int value__; // 0x0
	public const ValueTaskSourceOnCompletedFlags None = 0;
	public const ValueTaskSourceOnCompletedFlags UseSchedulingContext = 1;
	public const ValueTaskSourceOnCompletedFlags FlowExecutionContext = 2;
}

// Namespace: System.Threading.Tasks.Sources
public enum ValueTaskSourceStatus // TypeDefIndex: 3464
{
	// Fields
	public int value__; // 0x0
	public const ValueTaskSourceStatus Pending = 0;
	public const ValueTaskSourceStatus Succeeded = 1;
	public const ValueTaskSourceStatus Faulted = 2;
	public const ValueTaskSourceStatus Canceled = 3;
}

// Namespace: System.Threading.Tasks.Sources
public interface IValueTaskSource // TypeDefIndex: 3465
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ValueTaskSourceStatus GetStatus(short token);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void GetResult(short token);
}

// Namespace: System.Threading.Tasks.Sources
public interface IValueTaskSource<TResult> // TypeDefIndex: 3466
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ValueTaskSourceStatus GetStatus(short token);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueTaskSource<__Il2CppFullySharedGenericType>.GetStatus
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueTaskSource<__Il2CppFullySharedGenericType>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract TResult GetResult(short token);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IValueTaskSource<__Il2CppFullySharedGenericType>.GetResult
	*/
}

// Namespace: 
internal sealed class ASCIIEncoding.ASCIIEncodingSealed : ASCIIEncoding // TypeDefIndex: 3467
{
	// Methods

	// RVA: 0x1597BB0 Offset: 0x1596DB0 VA: 0x181597BB0
	public void .ctor() { }
}

// Namespace: System.Text
[Serializable]
public class ASCIIEncoding : Encoding // TypeDefIndex: 3468
{
	// Fields
	internal static readonly ASCIIEncoding.ASCIIEncodingSealed s_default; // 0x0

	// Methods

	// RVA: 0x1599FA0 Offset: 0x15991A0 VA: 0x181599FA0
	public void .ctor() { }

	// RVA: 0x1599ED0 Offset: 0x15990D0 VA: 0x181599ED0 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x1598030 Offset: 0x1597230 VA: 0x181598030 Slot: 14
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x15981E0 Offset: 0x15973E0 VA: 0x1815981E0 Slot: 13
	public override int GetByteCount(string chars) { }

	[CLSCompliant(False)]
	// RVA: 0x1597C00 Offset: 0x1596E00 VA: 0x181597C00 Slot: 15
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x1598B60 Offset: 0x1597D60 VA: 0x181598B60 Slot: 21
	public override int GetBytes(string chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1598890 Offset: 0x1597A90 VA: 0x181598890 Slot: 19
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x1598760 Offset: 0x1597960 VA: 0x181598760 Slot: 23
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x1598E30 Offset: 0x1598030 VA: 0x181598E30 Slot: 24
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x1598FE0 Offset: 0x15981E0 VA: 0x181598FE0 Slot: 25
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x15996E0 Offset: 0x15988E0 VA: 0x1815996E0 Slot: 28
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x1599280 Offset: 0x1598480 VA: 0x181599280 Slot: 29
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x1599CF0 Offset: 0x1598EF0 VA: 0x181599CF0 Slot: 37
	public override string GetString(byte[] bytes, int byteIndex, int byteCount) { }

	// RVA: 0x1597D00 Offset: 0x1596F00 VA: 0x181597D00 Slot: 16
	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	// RVA: 0x1598280 Offset: 0x1597480 VA: 0x181598280 Slot: 22
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x15990E0 Offset: 0x15982E0 VA: 0x1815990E0 Slot: 26
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x15993B0 Offset: 0x15985B0 VA: 0x1815993B0 Slot: 30
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	// RVA: 0x1599A70 Offset: 0x1598C70 VA: 0x181599A70 Slot: 34
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1599BB0 Offset: 0x1598DB0 VA: 0x181599BB0 Slot: 35
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x15999B0 Offset: 0x1598BB0 VA: 0x1815999B0 Slot: 32
	public override Decoder GetDecoder() { }

	// RVA: 0x1599A10 Offset: 0x1598C10 VA: 0x181599A10 Slot: 33
	public override Encoder GetEncoder() { }

	// RVA: 0x1599F00 Offset: 0x1599100 VA: 0x181599F00
	private static void .cctor() { }
}

// Namespace: System.Text
[Serializable]
public abstract class Decoder // TypeDefIndex: 3469
{
	// Fields
	internal DecoderFallback _fallback; // 0x10
	internal DecoderFallbackBuffer _fallbackBuffer; // 0x18

	// Properties
	public DecoderFallback Fallback { get; }
	public DecoderFallbackBuffer FallbackBuffer { get; }
	internal bool InternalHasFallbackBuffer { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public DecoderFallback get_Fallback() { }

	// RVA: 0x159CC40 Offset: 0x159BE40 VA: 0x18159CC40
	public DecoderFallbackBuffer get_FallbackBuffer() { }

	// RVA: 0x159CCC0 Offset: 0x159BEC0 VA: 0x18159CCC0
	internal bool get_InternalHasFallbackBuffer() { }

	// RVA: 0x159CB10 Offset: 0x159BD10 VA: 0x18159CB10 Slot: 4
	public virtual void Reset() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetCharCount(byte[] bytes, int index, int count);

	// RVA: 0x159C730 Offset: 0x159B930 VA: 0x18159C730 Slot: 6
	public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	[CLSCompliant(False)]
	// RVA: 0x159C5A0 Offset: 0x159B7A0 VA: 0x18159C5A0 Slot: 7
	public virtual int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	// RVA: 0x159C750 Offset: 0x159B950 VA: 0x18159C750 Slot: 9
	public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	[CLSCompliant(False)]
	// RVA: 0x159C770 Offset: 0x159B970 VA: 0x18159C770 Slot: 10
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	// RVA: 0x159C9D0 Offset: 0x159BBD0 VA: 0x18159C9D0 Slot: 11
	public virtual int GetChars(ReadOnlySpan<byte> bytes, Span<char> chars, bool flush) { }

	// RVA: 0x159BF60 Offset: 0x159B160 VA: 0x18159BF60 Slot: 12
	public virtual void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[CLSCompliant(False)]
	// RVA: 0x159C340 Offset: 0x159B540 VA: 0x18159C340 Slot: 13
	public virtual void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }
}

// Namespace: System.Text
[Serializable]
internal sealed class InternalDecoderBestFitFallback : DecoderFallback // TypeDefIndex: 3470
{
	// Fields
	internal Encoding _encoding; // 0x10
	internal char[] _arrayBestFit; // 0x18
	internal char _cReplacement; // 0x20

	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x159D640 Offset: 0x159C840 VA: 0x18159D640
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x159D4F0 Offset: 0x159C6F0 VA: 0x18159D4F0 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x159D550 Offset: 0x159C750 VA: 0x18159D550 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x159D610 Offset: 0x159C810 VA: 0x18159D610 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Text
internal sealed class InternalDecoderBestFitFallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 3471
{
	// Fields
	private char _cBestFit; // 0x20
	private int _iCount; // 0x24
	private int _iSize; // 0x28
	private InternalDecoderBestFitFallback _oFallback; // 0x30
	private static object s_InternalSyncObject; // 0x0

	// Properties
	private static object InternalSyncObject { get; }
	public override int Remaining { get; }

	// Methods

	// RVA: 0x159D440 Offset: 0x159C640 VA: 0x18159D440
	private static object get_InternalSyncObject() { }

	// RVA: 0x159D2C0 Offset: 0x159C4C0 VA: 0x18159D2C0
	public void .ctor(InternalDecoderBestFitFallback fallback) { }

	// RVA: 0x159D090 Offset: 0x159C290 VA: 0x18159D090 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x159D0E0 Offset: 0x159C2E0 VA: 0x18159D0E0 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x159D4E0 Offset: 0x159C6E0 VA: 0x18159D4E0 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x159D110 Offset: 0x159C310 VA: 0x18159D110 Slot: 7
	public override void Reset() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

	// RVA: 0x159D120 Offset: 0x159C320 VA: 0x18159D120
	private char TryBestFit(byte[] bytesCheck) { }
}

// Namespace: System.Text
[Serializable]
public sealed class DecoderExceptionFallback : DecoderFallback // TypeDefIndex: 3472
{
	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x159B5F0 Offset: 0x159A7F0 VA: 0x18159B5F0 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x159B640 Offset: 0x159A840 VA: 0x18159B640 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x159B690 Offset: 0x159A890 VA: 0x18159B690 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Text
public sealed class DecoderExceptionFallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 3473
{
	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x159B3D0 Offset: 0x159A5D0 VA: 0x18159B3D0 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x159B3E0 Offset: 0x159A5E0 VA: 0x18159B3E0
	private void Throw(byte[] bytesUnknown, int index) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Text
[Serializable]
public sealed class DecoderFallbackException : ArgumentException // TypeDefIndex: 3474
{
	// Fields
	private byte[] _bytesUnknown; // 0x98
	private int _index; // 0xA0

	// Methods

	// RVA: 0x159BDD0 Offset: 0x159AFD0 VA: 0x18159BDD0
	public void .ctor() { }

	// RVA: 0x159BD70 Offset: 0x159AF70 VA: 0x18159BD70
	public void .ctor(string message, byte[] bytesUnknown, int index) { }

	// RVA: 0x159BDB0 Offset: 0x159AFB0 VA: 0x18159BDB0
	private void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }
}

// Namespace: System.Text
[Serializable]
public abstract class DecoderFallback // TypeDefIndex: 3475
{
	// Fields
	private static DecoderFallback s_replacementFallback; // 0x0
	private static DecoderFallback s_exceptionFallback; // 0x8

	// Properties
	public static DecoderFallback ReplacementFallback { get; }
	public static DecoderFallback ExceptionFallback { get; }
	public abstract int MaxCharCount { get; }

	// Methods

	// RVA: 0x159BEC0 Offset: 0x159B0C0 VA: 0x18159BEC0
	public static DecoderFallback get_ReplacementFallback() { }

	// RVA: 0x159BE20 Offset: 0x159B020 VA: 0x18159BE20
	public static DecoderFallback get_ExceptionFallback() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract DecoderFallbackBuffer CreateFallbackBuffer();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_MaxCharCount();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Text
public abstract class DecoderFallbackBuffer // TypeDefIndex: 3476
{
	// Fields
	internal byte* byteStart; // 0x10
	internal char* charEnd; // 0x18

	// Properties
	public abstract int Remaining { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Fallback(byte[] bytesUnknown, int index);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract char GetNextChar();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_Remaining();

	// RVA: 0x159BB20 Offset: 0x159AD20 VA: 0x18159BB20 Slot: 7
	public virtual void Reset() { }

	// RVA: 0x159BB00 Offset: 0x159AD00 VA: 0x18159BB00
	internal void InternalReset() { }

	// RVA: 0x5FD790 Offset: 0x5FC990 VA: 0x1805FD790
	internal void InternalInitialize(byte* byteStart, char* charEnd) { }

	// RVA: 0x159B8C0 Offset: 0x159AAC0 VA: 0x18159B8C0 Slot: 8
	internal virtual bool InternalFallback(byte[] bytes, byte* pBytes, ref char* chars) { }

	// RVA: 0x159B6A0 Offset: 0x159A8A0 VA: 0x18159B6A0 Slot: 9
	internal virtual int InternalFallback(byte[] bytes, byte* pBytes) { }

	// RVA: 0x159BB60 Offset: 0x159AD60 VA: 0x18159BB60
	internal void ThrowLastBytesRecursive(byte[] bytesUnknown) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Text
internal class DecoderNLS : Decoder // TypeDefIndex: 3477
{
	// Fields
	private Encoding _encoding; // 0x20
	private bool _mustFlush; // 0x28
	internal bool _throwOnOverflow; // 0x29
	internal int _bytesUsed; // 0x2C

	// Properties
	public bool MustFlush { get; }
	internal virtual bool HasState { get; }

	// Methods

	// RVA: 0x15B4B20 Offset: 0x15B3D20 VA: 0x1815B4B20
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x15B4B00 Offset: 0x15B3D00 VA: 0x1815B4B00 Slot: 4
	public override void Reset() { }

	// RVA: 0x15B4300 Offset: 0x15B3500 VA: 0x1815B4300 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x15B4450 Offset: 0x15B3650 VA: 0x1815B4450 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x15B4330 Offset: 0x15B3530 VA: 0x1815B4330 Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x15B4650 Offset: 0x15B3850 VA: 0x1815B4650 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x15B47F0 Offset: 0x15B39F0 VA: 0x1815B47F0 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x15B4690 Offset: 0x15B3890 VA: 0x1815B4690 Slot: 10
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	// RVA: 0x15B3F40 Offset: 0x15B3140 VA: 0x1815B3F40 Slot: 12
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x15B3D60 Offset: 0x15B2F60 VA: 0x1815B3D60 Slot: 13
	public override void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_MustFlush() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 14
	internal virtual bool get_HasState() { }

	// RVA: 0x538580 Offset: 0x537780 VA: 0x180538580
	internal void ClearMustFlush() { }
}

// Namespace: System.Text
[Serializable]
public sealed class DecoderReplacementFallback : DecoderFallback, ISerializable // TypeDefIndex: 3478
{
	// Fields
	private string _strDefault; // 0x10

	// Properties
	public string DefaultString { get; }
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x15B4DE0 Offset: 0x15B3FE0 VA: 0x1815B4DE0
	public void .ctor() { }

	// RVA: 0x15B4E20 Offset: 0x15B4020 VA: 0x1815B4E20
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15B4D80 Offset: 0x15B3F80 VA: 0x1815B4D80 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15B4ED0 Offset: 0x15B40D0 VA: 0x1815B4ED0
	public void .ctor(string replacement) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_DefaultString() { }

	// RVA: 0x15B4CA0 Offset: 0x15B3EA0 VA: 0x1815B4CA0 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x7751D0 Offset: 0x7743D0 VA: 0x1807751D0 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x15B4D10 Offset: 0x15B3F10 VA: 0x1815B4D10 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x5BF760 Offset: 0x5BE960 VA: 0x1805BF760 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Text
public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 3479
{
	// Fields
	private string _strDefault; // 0x20
	private int _fallbackCount; // 0x28
	private int _fallbackIndex; // 0x2C

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x15B4C50 Offset: 0x15B3E50 VA: 0x1815B4C50
	public void .ctor(DecoderReplacementFallback fallback) { }

	// RVA: 0x15B4B70 Offset: 0x15B3D70 VA: 0x1815B4B70 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x15B4BC0 Offset: 0x15B3DC0 VA: 0x1815B4BC0 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x15B4C90 Offset: 0x15B3E90 VA: 0x1815B4C90 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x15B4C30 Offset: 0x15B3E30 VA: 0x1815B4C30 Slot: 7
	public override void Reset() { }

	// RVA: 0x15B4C10 Offset: 0x15B3E10 VA: 0x1815B4C10 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }
}

// Namespace: System.Text
[Serializable]
public abstract class Encoder // TypeDefIndex: 3480
{
	// Fields
	internal EncoderFallback _fallback; // 0x10
	internal EncoderFallbackBuffer _fallbackBuffer; // 0x18

	// Properties
	public EncoderFallback Fallback { get; }
	public EncoderFallbackBuffer FallbackBuffer { get; }
	internal bool InternalHasFallbackBuffer { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public EncoderFallback get_Fallback() { }

	// RVA: 0x15B7F10 Offset: 0x15B7110 VA: 0x1815B7F10
	public EncoderFallbackBuffer get_FallbackBuffer() { }

	// RVA: 0x159CCC0 Offset: 0x159BEC0 VA: 0x18159CCC0
	internal bool get_InternalHasFallbackBuffer() { }

	// RVA: 0x15B7E30 Offset: 0x15B7030 VA: 0x1815B7E30 Slot: 4
	public virtual void Reset() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetByteCount(char[] chars, int index, int count, bool flush);

	[CLSCompliant(False)]
	// RVA: 0x15B7A00 Offset: 0x15B6C00 VA: 0x1815B7A00 Slot: 6
	public virtual int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush);

	[CLSCompliant(False)]
	// RVA: 0x15B7BA0 Offset: 0x15B6DA0 VA: 0x1815B7BA0 Slot: 8
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x15B7620 Offset: 0x15B6820 VA: 0x1815B7620 Slot: 9
	public virtual void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	[CLSCompliant(False)]
	// RVA: 0x15B73C0 Offset: 0x15B65C0 VA: 0x1815B73C0 Slot: 10
	public virtual void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }
}

// Namespace: System.Text
[Serializable]
internal class InternalEncoderBestFitFallback : EncoderFallback // TypeDefIndex: 3481
{
	// Fields
	internal Encoding _encoding; // 0x10
	internal char[] _arrayBestFit; // 0x18

	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x15BA280 Offset: 0x15B9480 VA: 0x1815BA280 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x15BA2E0 Offset: 0x15B94E0 VA: 0x1815BA2E0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x159D610 Offset: 0x159C810 VA: 0x18159D610 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Text
internal sealed class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 3482
{
	// Fields
	private char _cBestFit; // 0x30
	private InternalEncoderBestFitFallback _oFallback; // 0x38
	private int _iCount; // 0x40
	private int _iSize; // 0x44
	private static object s_InternalSyncObject; // 0x0

	// Properties
	private static object InternalSyncObject { get; }
	public override int Remaining { get; }

	// Methods

	// RVA: 0x15BA1D0 Offset: 0x15B93D0 VA: 0x1815BA1D0
	private static object get_InternalSyncObject() { }

	// RVA: 0x15BA050 Offset: 0x15B9250 VA: 0x1815BA050
	public void .ctor(InternalEncoderBestFitFallback fallback) { }

	// RVA: 0x15B9BA0 Offset: 0x15B8DA0 VA: 0x1815B9BA0 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x15B9CC0 Offset: 0x15B8EC0 VA: 0x1815B9CC0 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x15B9ED0 Offset: 0x15B90D0 VA: 0x1815B9ED0 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x15B9F00 Offset: 0x15B9100 VA: 0x1815B9F00 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x15BA270 Offset: 0x15B9470 VA: 0x1815BA270 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x15B9F20 Offset: 0x15B9120 VA: 0x1815B9F20 Slot: 9
	public override void Reset() { }

	// RVA: 0x15B9F40 Offset: 0x15B9140 VA: 0x1815B9F40
	private char TryBestFit(char cUnknown) { }
}

// Namespace: System.Text
[Serializable]
public sealed class EncoderExceptionFallback : EncoderFallback // TypeDefIndex: 3483
{
	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x15B55E0 Offset: 0x15B47E0 VA: 0x1815B55E0 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x15B5630 Offset: 0x15B4830 VA: 0x1815B5630 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x15B5680 Offset: 0x15B4880 VA: 0x1815B5680 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Text
public sealed class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 3484
{
	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x15B5260 Offset: 0x15B4460 VA: 0x1815B5260 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x15B5320 Offset: 0x15B4520 VA: 0x1815B5320 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 8
	public override int get_Remaining() { }
}

// Namespace: System.Text
[Serializable]
public sealed class EncoderFallbackException : ArgumentException // TypeDefIndex: 3485
{
	// Fields
	private char _charUnknown; // 0x98
	private char _charUnknownHigh; // 0x9A
	private char _charUnknownLow; // 0x9C
	private int _index; // 0xA0

	// Methods

	// RVA: 0x15B59B0 Offset: 0x15B4BB0 VA: 0x1815B59B0
	public void .ctor() { }

	// RVA: 0x15B5C20 Offset: 0x15B4E20 VA: 0x1815B5C20
	internal void .ctor(string message, char charUnknown, int index) { }

	// RVA: 0x15B5A00 Offset: 0x15B4C00 VA: 0x1815B5A00
	internal void .ctor(string message, char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x159BDB0 Offset: 0x159AFB0 VA: 0x18159BDB0
	private void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }
}

// Namespace: System.Text
[Serializable]
public abstract class EncoderFallback // TypeDefIndex: 3486
{
	// Fields
	private static EncoderFallback s_replacementFallback; // 0x0
	private static EncoderFallback s_exceptionFallback; // 0x8

	// Properties
	public static EncoderFallback ReplacementFallback { get; }
	public static EncoderFallback ExceptionFallback { get; }
	public abstract int MaxCharCount { get; }

	// Methods

	// RVA: 0x15B5D00 Offset: 0x15B4F00 VA: 0x1815B5D00
	public static EncoderFallback get_ReplacementFallback() { }

	// RVA: 0x15B5C60 Offset: 0x15B4E60 VA: 0x1815B5C60
	public static EncoderFallback get_ExceptionFallback() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract EncoderFallbackBuffer CreateFallbackBuffer();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_MaxCharCount();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Text
public abstract class EncoderFallbackBuffer // TypeDefIndex: 3487
{
	// Fields
	internal char* charStart; // 0x10
	internal char* charEnd; // 0x18
	internal EncoderNLS encoder; // 0x20
	internal bool setEncoder; // 0x28
	internal bool bUsedEncoder; // 0x29
	internal bool bFallingBack; // 0x2A
	internal int iRecursionCount; // 0x2C
	private const int iMaxRecursion = 250;

	// Properties
	public abstract int Remaining { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Fallback(char charUnknown, int index);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract char GetNextChar();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool MovePrevious();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_Remaining();

	// RVA: 0x15B58D0 Offset: 0x15B4AD0 VA: 0x1815B58D0 Slot: 9
	public virtual void Reset() { }

	// RVA: 0x15B58B0 Offset: 0x15B4AB0 VA: 0x1815B58B0
	internal void InternalReset() { }

	// RVA: 0x15B5880 Offset: 0x15B4A80 VA: 0x1815B5880
	internal void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder) { }

	// RVA: 0x15B5840 Offset: 0x15B4A40 VA: 0x1815B5840
	internal char InternalGetNextChar() { }

	// RVA: 0x15B5690 Offset: 0x15B4890 VA: 0x1815B5690 Slot: 10
	internal virtual bool InternalFallback(char ch, ref char* chars) { }

	// RVA: 0x15B5910 Offset: 0x15B4B10 VA: 0x1815B5910
	internal void ThrowLastCharRecursive(int charRecursive) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Text
internal class EncoderNLS : Encoder // TypeDefIndex: 3488
{
	// Fields
	internal char _charLeftOver; // 0x20
	private Encoding _encoding; // 0x28
	private bool _mustFlush; // 0x30
	internal bool _throwOnOverflow; // 0x31
	internal int _charsUsed; // 0x34

	// Properties
	public Encoding Encoding { get; }
	public bool MustFlush { get; }
	internal virtual bool HasState { get; }

	// Methods

	// RVA: 0x15B6B00 Offset: 0x15B5D00 VA: 0x1815B6B00
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x15B6AD0 Offset: 0x15B5CD0 VA: 0x1815B6AD0 Slot: 4
	public override void Reset() { }

	// RVA: 0x15B6360 Offset: 0x15B5560 VA: 0x1815B6360 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool flush) { }

	// RVA: 0x15B6550 Offset: 0x15B5750 VA: 0x1815B6550 Slot: 6
	public override int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: 0x15B6670 Offset: 0x15B5870 VA: 0x1815B6670 Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: 0x15B6980 Offset: 0x15B5B80 VA: 0x1815B6980 Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x15B5FA0 Offset: 0x15B51A0 VA: 0x1815B5FA0 Slot: 9
	public override void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	// RVA: 0x15B5DC0 Offset: 0x15B4FC0 VA: 0x1815B5DC0 Slot: 10
	public override void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Encoding get_Encoding() { }

	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	public bool get_MustFlush() { }

	// RVA: 0x15B6B50 Offset: 0x15B5D50 VA: 0x1815B6B50 Slot: 11
	internal virtual bool get_HasState() { }

	// RVA: 0x723A20 Offset: 0x722C20 VA: 0x180723A20
	internal void ClearMustFlush() { }
}

// Namespace: System.Text
[Serializable]
public sealed class EncoderReplacementFallback : EncoderFallback, ISerializable // TypeDefIndex: 3489
{
	// Fields
	private string _strDefault; // 0x10

	// Properties
	public string DefaultString { get; }
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x15B7140 Offset: 0x15B6340 VA: 0x1815B7140
	public void .ctor() { }

	// RVA: 0x15B7180 Offset: 0x15B6380 VA: 0x1815B7180
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15B70E0 Offset: 0x15B62E0 VA: 0x1815B70E0 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15B7230 Offset: 0x15B6430 VA: 0x1815B7230
	public void .ctor(string replacement) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_DefaultString() { }

	// RVA: 0x15B6FF0 Offset: 0x15B61F0 VA: 0x1815B6FF0 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x7751D0 Offset: 0x7743D0 VA: 0x1807751D0 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x15B7070 Offset: 0x15B6270 VA: 0x1815B7070 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x5BF760 Offset: 0x5BE960 VA: 0x1805BF760 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Text
public sealed class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 3490
{
	// Fields
	private string _strDefault; // 0x30
	private int _fallbackCount; // 0x38
	private int _fallbackIndex; // 0x3C

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x15B6F90 Offset: 0x15B6190 VA: 0x1815B6F90
	public void .ctor(EncoderReplacementFallback fallback) { }

	// RVA: 0x15B6DB0 Offset: 0x15B5FB0 VA: 0x1815B6DB0 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x15B6B60 Offset: 0x15B5D60 VA: 0x1815B6B60 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x15B6F00 Offset: 0x15B6100 VA: 0x1815B6F00 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x15B6F50 Offset: 0x15B6150 VA: 0x1815B6F50 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x15B6FE0 Offset: 0x15B61E0 VA: 0x1815B6FE0 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x15B6F70 Offset: 0x15B6170 VA: 0x1815B6F70 Slot: 9
	public override void Reset() { }
}

// Namespace: System.Text
[Serializable]
public sealed class EncodingInfo // TypeDefIndex: 3491
{
	// Fields
	private int iCodePage; // 0x10
	private string strEncodingName; // 0x18
	private string strDisplayName; // 0x20

	// Properties
	public int CodePage { get; }

	// Methods

	// RVA: 0x10DDCC0 Offset: 0x10DCEC0 VA: 0x1810DDCC0
	internal void .ctor(int codePage, string name, string displayName) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_CodePage() { }

	// RVA: 0x15B8030 Offset: 0x15B7230 VA: 0x1815B8030 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15B80A0 Offset: 0x15B72A0 VA: 0x1815B80A0
	internal void .ctor() { }
}

// Namespace: System.Text
[Serializable]
internal abstract class EncodingNLS : Encoding // TypeDefIndex: 3492
{
	// Methods

	// RVA: 0x15B9480 Offset: 0x15B8680 VA: 0x1815B9480
	protected void .ctor(int codePage) { }

	// RVA: 0x15B8270 Offset: 0x15B7470 VA: 0x1815B8270 Slot: 14
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x15B80D0 Offset: 0x15B72D0 VA: 0x1815B80D0 Slot: 13
	public override int GetByteCount(string s) { }

	// RVA: 0x15B8170 Offset: 0x15B7370 VA: 0x1815B8170 Slot: 15
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x15B8420 Offset: 0x15B7620 VA: 0x1815B8420 Slot: 21
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x15B8820 Offset: 0x15B7A20 VA: 0x1815B8820 Slot: 19
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x15B86F0 Offset: 0x15B78F0 VA: 0x1815B86F0 Slot: 23
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x15B8AF0 Offset: 0x15B7CF0 VA: 0x1815B8AF0 Slot: 24
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x15B8CA0 Offset: 0x15B7EA0 VA: 0x1815B8CA0 Slot: 25
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x15B8ED0 Offset: 0x15B80D0 VA: 0x1815B8ED0 Slot: 28
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x15B8DA0 Offset: 0x15B7FA0 VA: 0x1815B8DA0 Slot: 29
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x15B92A0 Offset: 0x15B84A0 VA: 0x1815B92A0 Slot: 37
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x15B91A0 Offset: 0x15B83A0 VA: 0x1815B91A0 Slot: 32
	public override Decoder GetDecoder() { }

	// RVA: 0x15B9220 Offset: 0x15B8420 VA: 0x1815B9220 Slot: 33
	public override Encoder GetEncoder() { }
}

// Namespace: System.Text
public abstract class EncodingProvider // TypeDefIndex: 3493
{
	// Fields
	private static object s_InternalSyncObject; // 0x0
	private static EncodingProvider[] s_providers; // 0x8

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Encoding GetEncoding(string name);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Encoding GetEncoding(int codepage);

	// RVA: 0x15B98D0 Offset: 0x15B8AD0 VA: 0x1815B98D0 Slot: 6
	public virtual Encoding GetEncoding(string name, EncoderFallback encoderFallback, DecoderFallback decoderFallback) { }

	// RVA: 0x15B9A10 Offset: 0x15B8C10 VA: 0x1815B9A10 Slot: 7
	public virtual Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback) { }

	// RVA: 0x15B96D0 Offset: 0x15B88D0 VA: 0x1815B96D0
	internal static Encoding GetEncodingFromProvider(int codepage) { }

	// RVA: 0x15B97D0 Offset: 0x15B89D0 VA: 0x1815B97D0
	internal static Encoding GetEncodingFromProvider(string encodingName) { }

	// RVA: 0x15B9490 Offset: 0x15B8690 VA: 0x1815B9490
	internal static Encoding GetEncodingFromProvider(int codepage, EncoderFallback enc, DecoderFallback dec) { }

	// RVA: 0x15B95B0 Offset: 0x15B87B0 VA: 0x1815B95B0
	internal static Encoding GetEncodingFromProvider(string encodingName, EncoderFallback enc, DecoderFallback dec) { }

	// RVA: 0x15B9B40 Offset: 0x15B8D40 VA: 0x1815B9B40
	private static void .cctor() { }
}

// Namespace: System.Text
[Serializable]
internal class Latin1Encoding : EncodingNLS, ISerializable // TypeDefIndex: 3494
{
	// Fields
	internal static readonly Latin1Encoding s_default; // 0x0
	private static readonly char[] arrayCharBestFit; // 0x8

	// Methods

	// RVA: 0x15BAFF0 Offset: 0x15BA1F0 VA: 0x1815BAFF0
	public void .ctor() { }

	// RVA: 0x15BAFA0 Offset: 0x15BA1A0 VA: 0x1815BAFA0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15BAE10 Offset: 0x15BA010 VA: 0x1815BAE10 Slot: 40
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15BA420 Offset: 0x15B9620 VA: 0x1815BA420 Slot: 16
	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	// RVA: 0x15BA680 Offset: 0x15B9880 VA: 0x1815BA680 Slot: 22
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x15BAB00 Offset: 0x15B9D00 VA: 0x1815BAB00 Slot: 26
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x15BAB10 Offset: 0x15B9D10 VA: 0x1815BAB10 Slot: 30
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	// RVA: 0x15BAB90 Offset: 0x15B9D90 VA: 0x1815BAB90 Slot: 34
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x15BACD0 Offset: 0x15B9ED0 VA: 0x1815BACD0 Slot: 35
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x15BA3D0 Offset: 0x15B95D0 VA: 0x1815BA3D0 Slot: 38
	internal override char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x15BAEF0 Offset: 0x15BA0F0 VA: 0x1815BAEF0
	private static void .cctor() { }
}

// Namespace: System.Text
public enum NormalizationForm // TypeDefIndex: 3495
{
	// Fields
	public int value__; // 0x0
	public const NormalizationForm FormC = 1;
	public const NormalizationForm FormD = 2;
	public const NormalizationForm FormKC = 5;
	public const NormalizationForm FormKD = 6;
}

// Namespace: System.Text
[DefaultMember("Chars")]
[Serializable]
public sealed class StringBuilder : ISerializable // TypeDefIndex: 3496
{
	// Fields
	internal char[] m_ChunkChars; // 0x10
	internal StringBuilder m_ChunkPrevious; // 0x18
	internal int m_ChunkLength; // 0x20
	internal int m_ChunkOffset; // 0x24
	internal int m_MaxCapacity; // 0x28
	internal const int DefaultCapacity = 16;
	private const string CapacityField = "Capacity";
	private const string MaxCapacityField = "m_MaxCapacity";
	private const string StringValueField = "m_StringValue";
	private const string ThreadIDField = "m_currentThread";
	internal const int MaxChunkSize = 8000;
	private const int IndexLimit = 1000000;
	private const int WidthLimit = 1000000;

	// Properties
	public int Capacity { get; set; }
	public int MaxCapacity { get; }
	public int Length { get; set; }
	public char Chars { get; set; }
	private Span<char> RemainingCurrentChunk { get; }

	// Methods

	// RVA: 0x15BF330 Offset: 0x15BE530 VA: 0x1815BF330
	public void .ctor() { }

	// RVA: 0x15BF390 Offset: 0x15BE590 VA: 0x1815BF390
	public void .ctor(int capacity) { }

	// RVA: 0x15BFC90 Offset: 0x15BEE90 VA: 0x1815BFC90
	public void .ctor(string value) { }

	// RVA: 0x15BFCD0 Offset: 0x15BEED0 VA: 0x1815BFCD0
	public void .ctor(string value, int capacity) { }

	// RVA: 0x15BF580 Offset: 0x15BE780 VA: 0x1815BF580
	public void .ctor(string value, int startIndex, int length, int capacity) { }

	// RVA: 0x15BF3A0 Offset: 0x15BE5A0 VA: 0x1815BF3A0
	public void .ctor(int capacity, int maxCapacity) { }

	// RVA: 0x15BF870 Offset: 0x15BEA70 VA: 0x1815BF870
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15BEC00 Offset: 0x15BDE00 VA: 0x1815BEC00 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15BFD10 Offset: 0x15BEF10 VA: 0x1815BFD10
	public int get_Capacity() { }

	// RVA: 0x15BFEB0 Offset: 0x15BF0B0 VA: 0x1815BFEB0
	public void set_Capacity(int value) { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public int get_MaxCapacity() { }

	// RVA: 0x15BF1E0 Offset: 0x15BE3E0 VA: 0x1815BF1E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x15BEFA0 Offset: 0x15BE1A0 VA: 0x1815BEFA0
	public string ToString(int startIndex, int length) { }

	// RVA: 0x15BCE60 Offset: 0x15BC060 VA: 0x1815BCE60
	public StringBuilder Clear() { }

	// RVA: 0x15BFE00 Offset: 0x15BF000 VA: 0x1815BFE00
	public int get_Length() { }

	// RVA: 0x15C0190 Offset: 0x15BF390 VA: 0x1815C0190
	public void set_Length(int value) { }

	// RVA: 0x15BFD30 Offset: 0x15BEF30 VA: 0x1815BFD30
	public char get_Chars(int index) { }

	// RVA: 0x15C0070 Offset: 0x15BF270 VA: 0x1815C0070
	public void set_Chars(int index, char value) { }

	// RVA: 0x15BCAF0 Offset: 0x15BBCF0 VA: 0x1815BCAF0
	public StringBuilder Append(char value, int repeatCount) { }

	// RVA: 0x15BC830 Offset: 0x15BBA30 VA: 0x1815BC830
	public StringBuilder Append(char[] value, int startIndex, int charCount) { }

	// RVA: 0x15BC2B0 Offset: 0x15BB4B0 VA: 0x1815BC2B0
	public StringBuilder Append(string value) { }

	// RVA: 0x15BC200 Offset: 0x15BB400 VA: 0x1815BC200
	private void AppendHelper(string value) { }

	// RVA: 0x15BCC70 Offset: 0x15BBE70 VA: 0x1815BCC70
	public StringBuilder Append(string value, int startIndex, int count) { }

	// RVA: 0x15BC7B0 Offset: 0x15BB9B0 VA: 0x1815BC7B0
	public StringBuilder Append(StringBuilder value) { }

	// RVA: 0x15BB1E0 Offset: 0x15BA3E0 VA: 0x1815BB1E0
	private StringBuilder AppendCore(StringBuilder value, int startIndex, int count) { }

	// RVA: 0x15BC250 Offset: 0x15BB450 VA: 0x1815BC250
	public StringBuilder AppendLine() { }

	// RVA: 0x15BC280 Offset: 0x15BB480 VA: 0x1815BC280
	public StringBuilder AppendLine(string value) { }

	// RVA: 0x15BCE80 Offset: 0x15BC080 VA: 0x1815BCE80
	public void CopyTo(int sourceIndex, Span<char> destination, int count) { }

	// RVA: 0x15BDDD0 Offset: 0x15BCFD0 VA: 0x1815BDDD0
	public StringBuilder Remove(int startIndex, int length) { }

	// RVA: 0x15BCA10 Offset: 0x15BBC10 VA: 0x1815BCA10
	public StringBuilder Append(bool value) { }

	// RVA: 0x15BC6F0 Offset: 0x15BB8F0 VA: 0x1815BC6F0
	public StringBuilder Append(char value) { }

	// RVA: 0x15BC400 Offset: 0x15BB600 VA: 0x1815BC400
	public StringBuilder Append(byte value) { }

	// RVA: 0x15BC3B0 Offset: 0x15BB5B0 VA: 0x1815BC3B0
	public StringBuilder Append(int value) { }

	// RVA: 0x15BC6A0 Offset: 0x15BB8A0 VA: 0x1815BC6A0
	public StringBuilder Append(long value) { }

	// RVA: 0x15BC760 Offset: 0x15BB960 VA: 0x1815BC760
	public StringBuilder Append(float value) { }

	[CLSCompliant(False)]
	// RVA: 0x15BC650 Offset: 0x15BB850 VA: 0x1815BC650
	public StringBuilder Append(uint value) { }

	// RVA: -1 Offset: -1
	private StringBuilder AppendSpanFormattable<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA79FF0 Offset: 0xA791F0 VA: 0x180A79FF0
	|-StringBuilder.AppendSpanFormattable<byte>
	|
	|-RVA: 0xA7A1B0 Offset: 0xA793B0 VA: 0x180A7A1B0
	|-StringBuilder.AppendSpanFormattable<int>
	|
	|-RVA: 0xA7A240 Offset: 0xA79440 VA: 0x180A7A240
	|-StringBuilder.AppendSpanFormattable<long>
	|
	|-RVA: 0xA7A2D0 Offset: 0xA794D0 VA: 0x180A7A2D0
	|-StringBuilder.AppendSpanFormattable<float>
	|
	|-RVA: 0xA7A360 Offset: 0xA79560 VA: 0x180A7A360
	|-StringBuilder.AppendSpanFormattable<uint>
	|
	|-RVA: 0xA7A080 Offset: 0xA79280 VA: 0x180A7A080
	|-StringBuilder.AppendSpanFormattable<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x15BC450 Offset: 0x15BB650 VA: 0x1815BC450
	public StringBuilder Append(object value) { }

	// RVA: 0x15BC7F0 Offset: 0x15BB9F0 VA: 0x1815BC7F0
	public StringBuilder Append(char[] value) { }

	// RVA: 0x15BCA70 Offset: 0x15BBC70 VA: 0x1815BCA70
	public StringBuilder Append(ReadOnlySpan<char> value) { }

	// RVA: 0x15BD890 Offset: 0x15BCA90 VA: 0x1815BD890
	public StringBuilder Insert(int index, string value) { }

	// RVA: 0x15BD2F0 Offset: 0x15BC4F0 VA: 0x1815BD2F0
	public StringBuilder Insert(int index, char value) { }

	// RVA: 0x15BC190 Offset: 0x15BB390 VA: 0x1815BC190
	public StringBuilder AppendFormat(string format, object arg0) { }

	// RVA: 0x15BC110 Offset: 0x15BB310 VA: 0x1815BC110
	public StringBuilder AppendFormat(string format, object arg0, object arg1) { }

	// RVA: 0x15BBF70 Offset: 0x15BB170 VA: 0x1815BBF70
	public StringBuilder AppendFormat(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x15BBEA0 Offset: 0x15BB0A0 VA: 0x1815BBEA0
	public StringBuilder AppendFormat(string format, object[] args) { }

	// RVA: 0x15BC090 Offset: 0x15BB290 VA: 0x1815BC090
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x15BC000 Offset: 0x15BB200 VA: 0x1815BC000
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x15BBDC0 Offset: 0x15BAFC0 VA: 0x1815BBDC0
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object[] args) { }

	// RVA: 0x15BD2A0 Offset: 0x15BC4A0 VA: 0x1815BD2A0
	private static void FormatError() { }

	// RVA: 0x15BB440 Offset: 0x15BA640 VA: 0x1815BB440
	internal StringBuilder AppendFormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x15BEAE0 Offset: 0x15BDCE0 VA: 0x1815BEAE0
	public StringBuilder Replace(string oldValue, string newValue) { }

	// RVA: 0x15BE5F0 Offset: 0x15BD7F0 VA: 0x1815BE5F0
	public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x15BC4A0 Offset: 0x15BB6A0 VA: 0x1815BC4A0
	public StringBuilder Append(char* value, int valueCount) { }

	// RVA: 0x15BD320 Offset: 0x15BC520 VA: 0x1815BD320
	private void Insert(int index, char* value, int valueCount) { }

	// RVA: 0x15BE210 Offset: 0x15BD410 VA: 0x1815BE210
	private void ReplaceAllInChunk(int[] replacements, int replacementsCount, StringBuilder sourceChunk, int removeCount, string value) { }

	// RVA: 0x15BEB10 Offset: 0x15BDD10 VA: 0x1815BEB10
	private bool StartsWith(StringBuilder chunk, int indexInChunk, int count, string value) { }

	// RVA: 0x15BE430 Offset: 0x15BD630 VA: 0x1815BE430
	private void ReplaceInPlaceAtChunk(ref StringBuilder chunk, ref int indexInChunk, char* value, int count) { }

	// RVA: 0x15BED30 Offset: 0x15BDF30 VA: 0x1815BED30
	private static void ThreadSafeCopy(char* sourcePtr, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x15BEE00 Offset: 0x15BE000 VA: 0x1815BEE00
	private static void ThreadSafeCopy(char[] source, int sourceIndex, Span<char> destination, int destinationIndex, int count) { }

	// RVA: 0x15BD260 Offset: 0x15BC460 VA: 0x1815BD260
	private StringBuilder FindChunkForIndex(int index) { }

	// RVA: 0x15BFE10 Offset: 0x15BF010 VA: 0x1815BFE10
	private Span<char> get_RemainingCurrentChunk() { }

	// RVA: 0x15BDD80 Offset: 0x15BCF80 VA: 0x1815BDD80
	private StringBuilder Next(StringBuilder chunk) { }

	// RVA: 0x15BD0B0 Offset: 0x15BC2B0 VA: 0x1815BD0B0
	private void ExpandByABlock(int minBlockCharCount) { }

	// RVA: 0x15BFC40 Offset: 0x15BEE40 VA: 0x1815BFC40
	private void .ctor(StringBuilder from) { }

	// RVA: 0x15BD950 Offset: 0x15BCB50 VA: 0x1815BD950
	private void MakeRoom(int index, int count, out StringBuilder chunk, out int indexInChunk, bool doNotMoveFollowingChars) { }

	// RVA: 0x15BFBB0 Offset: 0x15BEDB0 VA: 0x1815BFBB0
	private void .ctor(int size, int maxCapacity, StringBuilder previousBlock) { }

	// RVA: 0x15BE070 Offset: 0x15BD270 VA: 0x1815BE070
	private void Remove(int startIndex, int count, out StringBuilder chunk, out int indexInChunk) { }
}

// Namespace: System.Text
internal static class StringBuilderCache // TypeDefIndex: 3497
{
	// Fields
	[ThreadStatic]
	private static StringBuilder t_cachedInstance; // 0x80000000

	// Methods

	// RVA: 0x15BB000 Offset: 0x15BA200 VA: 0x1815BB000
	public static StringBuilder Acquire(int capacity = 16) { }

	// RVA: 0x15BB170 Offset: 0x15BA370 VA: 0x1815BB170
	public static void Release(StringBuilder sb) { }

	// RVA: 0x15BB0E0 Offset: 0x15BA2E0 VA: 0x1815BB0E0
	public static string GetStringAndRelease(StringBuilder sb) { }
}

// Namespace: 
[Serializable]
private sealed class UTF32Encoding.UTF32Decoder : DecoderNLS // TypeDefIndex: 3498
{
	// Fields
	internal int iChar; // 0x30
	internal int readByteCount; // 0x34

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x15B4B20 Offset: 0x15B3D20 VA: 0x1815B4B20
	public void .ctor(UTF32Encoding encoding) { }

	// RVA: 0x15C0410 Offset: 0x15BF610 VA: 0x1815C0410 Slot: 4
	public override void Reset() { }

	// RVA: 0xBAE4E0 Offset: 0xBAD6E0 VA: 0x180BAE4E0 Slot: 14
	internal override bool get_HasState() { }
}

// Namespace: System.Text
[Serializable]
public sealed class UTF32Encoding : Encoding // TypeDefIndex: 3499
{
	// Fields
	internal static readonly UTF32Encoding s_default; // 0x0
	internal static readonly UTF32Encoding s_bigEndianDefault; // 0x8
	private static readonly byte[] s_bigEndianPreamble; // 0x10
	private static readonly byte[] s_littleEndianPreamble; // 0x18
	private bool _emitUTF32ByteOrderMark; // 0x38
	private bool _isThrowException; // 0x39
	private bool _bigEndian; // 0x3A

	// Properties
	public override ReadOnlySpan<byte> Preamble { get; }

	// Methods

	// RVA: 0x15C2E90 Offset: 0x15C2090 VA: 0x1815C2E90
	public void .ctor() { }

	// RVA: 0x15C2F30 Offset: 0x15C2130 VA: 0x1815C2F30
	public void .ctor(bool bigEndian, bool byteOrderMark) { }

	// RVA: 0x15C2EC0 Offset: 0x15C20C0 VA: 0x1815C2EC0
	public void .ctor(bool bigEndian, bool byteOrderMark, bool throwOnInvalidCharacters) { }

	// RVA: 0x15C2CA0 Offset: 0x15C1EA0 VA: 0x1815C2CA0 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x15C0890 Offset: 0x15BFA90 VA: 0x1815C0890 Slot: 14
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x15C0A40 Offset: 0x15BFC40 VA: 0x1815C0A40 Slot: 13
	public override int GetByteCount(string s) { }

	[CLSCompliant(False)]
	// RVA: 0x15C0AE0 Offset: 0x15BFCE0 VA: 0x1815C0AE0 Slot: 15
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x15C0FE0 Offset: 0x15C01E0 VA: 0x1815C0FE0 Slot: 21
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x15C0BE0 Offset: 0x15BFDE0 VA: 0x1815C0BE0 Slot: 19
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x15C0EB0 Offset: 0x15C00B0 VA: 0x1815C0EB0 Slot: 23
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x15C1BC0 Offset: 0x15C0DC0 VA: 0x1815C1BC0 Slot: 24
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x15C1AC0 Offset: 0x15C0CC0 VA: 0x1815C1AC0 Slot: 25
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x15C1EA0 Offset: 0x15C10A0 VA: 0x1815C1EA0 Slot: 28
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x15C1D70 Offset: 0x15C0F70 VA: 0x1815C1D70 Slot: 29
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x15C2AA0 Offset: 0x15C1CA0 VA: 0x1815C2AA0 Slot: 37
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x15C0510 Offset: 0x15BF710 VA: 0x1815C0510 Slot: 16
	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x15C12B0 Offset: 0x15C04B0 VA: 0x1815C12B0 Slot: 22
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x15C1760 Offset: 0x15C0960 VA: 0x1815C1760 Slot: 26
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x15C2170 Offset: 0x15C1370 VA: 0x1815C2170 Slot: 30
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x15C2C80 Offset: 0x15C1E80 VA: 0x1815C2C80
	private uint GetSurrogate(char cHigh, char cLow) { }

	// RVA: 0x15C2790 Offset: 0x15C1990 VA: 0x1815C2790
	private char GetHighSurrogate(uint iChar) { }

	// RVA: 0x15C27B0 Offset: 0x15C19B0 VA: 0x1815C27B0
	private char GetLowSurrogate(uint iChar) { }

	// RVA: 0x15C25E0 Offset: 0x15C17E0 VA: 0x1815C25E0 Slot: 32
	public override Decoder GetDecoder() { }

	// RVA: 0x15C2660 Offset: 0x15C1860 VA: 0x1815C2660 Slot: 33
	public override Encoder GetEncoder() { }

	// RVA: 0x15C27D0 Offset: 0x15C19D0 VA: 0x1815C27D0 Slot: 34
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x15C2910 Offset: 0x15C1B10 VA: 0x1815C2910 Slot: 35
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x15C29F0 Offset: 0x15C1BF0 VA: 0x1815C29F0 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x15C2F80 Offset: 0x15C2180 VA: 0x1815C2F80 Slot: 7
	public override ReadOnlySpan<byte> get_Preamble() { }

	// RVA: 0x15C0440 Offset: 0x15BF640 VA: 0x1815C0440 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x15C26E0 Offset: 0x15C18E0 VA: 0x1815C26E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15C2D60 Offset: 0x15C1F60 VA: 0x1815C2D60
	private static void .cctor() { }
}

// Namespace: 
[Serializable]
private sealed class UTF7Encoding.Decoder : DecoderNLS // TypeDefIndex: 3500
{
	// Fields
	internal int bits; // 0x30
	internal int bitCount; // 0x34
	internal bool firstByte; // 0x38

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x15B4B20 Offset: 0x15B3D20 VA: 0x1815B4B20
	public void .ctor(UTF7Encoding encoding) { }

	// RVA: 0x15B5210 Offset: 0x15B4410 VA: 0x1815B5210 Slot: 4
	public override void Reset() { }

	// RVA: 0x15B5250 Offset: 0x15B4450 VA: 0x1815B5250 Slot: 14
	internal override bool get_HasState() { }
}

// Namespace: 
[Serializable]
private sealed class UTF7Encoding.Encoder : EncoderNLS // TypeDefIndex: 3501
{
	// Fields
	internal int bits; // 0x38
	internal int bitCount; // 0x3C

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x15B6B00 Offset: 0x15B5D00 VA: 0x1815B6B00
	public void .ctor(UTF7Encoding encoding) { }

	// RVA: 0x15B7E00 Offset: 0x15B7000 VA: 0x1815B7E00 Slot: 4
	public override void Reset() { }

	// RVA: 0x15B8010 Offset: 0x15B7210 VA: 0x1815B8010 Slot: 11
	internal override bool get_HasState() { }
}

// Namespace: 
[Serializable]
private sealed class UTF7Encoding.DecoderUTF7Fallback : DecoderFallback // TypeDefIndex: 3502
{
	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x15B5160 Offset: 0x15B4360 VA: 0x1815B5160 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x15B51B0 Offset: 0x15B43B0 VA: 0x1815B51B0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x15B5200 Offset: 0x15B4400 VA: 0x1815B5200 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
private sealed class UTF7Encoding.DecoderUTF7FallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 3503
{
	// Fields
	private char cFallback; // 0x20
	private int iCount; // 0x24
	private int iSize; // 0x28

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x15B5150 Offset: 0x15B4350 VA: 0x1815B5150
	public void .ctor(UTF7Encoding.DecoderUTF7Fallback fallback) { }

	// RVA: 0x15B5060 Offset: 0x15B4260 VA: 0x1815B5060 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x15B50B0 Offset: 0x15B42B0 VA: 0x1815B50B0 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x159D4E0 Offset: 0x159C6E0 VA: 0x18159D4E0 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x159D110 Offset: 0x159C310 VA: 0x18159D110 Slot: 7
	public override void Reset() { }

	// RVA: 0x15B50D0 Offset: 0x15B42D0 VA: 0x1815B50D0 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }
}

// Namespace: System.Text
[Serializable]
public class UTF7Encoding : Encoding // TypeDefIndex: 3504
{
	// Fields
	internal static readonly UTF7Encoding s_default; // 0x0
	private byte[] _base64Bytes; // 0x38
	private sbyte[] _base64Values; // 0x40
	private bool[] _directEncode; // 0x48
	private bool _allowOptionals; // 0x50

	// Methods

	// RVA: 0x15C5140 Offset: 0x15C4340 VA: 0x1815C5140
	public void .ctor() { }

	// RVA: 0x15C5170 Offset: 0x15C4370 VA: 0x1815C5170
	public void .ctor(bool allowOptionals) { }

	// RVA: 0x15C4DD0 Offset: 0x15C3FD0 VA: 0x1815C4DD0
	private void MakeTables() { }

	// RVA: 0x15C5020 Offset: 0x15C4220 VA: 0x1815C5020 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x15C30E0 Offset: 0x15C22E0 VA: 0x1815C30E0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x15C49F0 Offset: 0x15C3BF0 VA: 0x1815C49F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15C33B0 Offset: 0x15C25B0 VA: 0x1815C33B0 Slot: 14
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x15C3310 Offset: 0x15C2510 VA: 0x1815C3310 Slot: 13
	public override int GetByteCount(string s) { }

	[CLSCompliant(False)]
	// RVA: 0x15C31D0 Offset: 0x15C23D0 VA: 0x1815C31D0 Slot: 15
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x15C3830 Offset: 0x15C2A30 VA: 0x1815C3830 Slot: 21
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x15C3560 Offset: 0x15C2760 VA: 0x1815C3560 Slot: 19
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x15C3E80 Offset: 0x15C3080 VA: 0x1815C3E80 Slot: 23
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x15C40B0 Offset: 0x15C32B0 VA: 0x1815C40B0 Slot: 24
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x15C3FB0 Offset: 0x15C31B0 VA: 0x1815C3FB0 Slot: 25
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x15C44F0 Offset: 0x15C36F0 VA: 0x1815C44F0 Slot: 28
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x15C47C0 Offset: 0x15C39C0 VA: 0x1815C47C0 Slot: 29
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x15C4BF0 Offset: 0x15C3DF0 VA: 0x1815C4BF0 Slot: 37
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x15C32D0 Offset: 0x15C24D0 VA: 0x1815C32D0 Slot: 16
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x15C3B00 Offset: 0x15C2D00 VA: 0x1815C3B00 Slot: 22
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x15C4260 Offset: 0x15C3460 VA: 0x1815C4260 Slot: 26
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x15C42A0 Offset: 0x15C34A0 VA: 0x1815C42A0 Slot: 30
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x15C48F0 Offset: 0x15C3AF0 VA: 0x1815C48F0 Slot: 32
	public override Decoder GetDecoder() { }

	// RVA: 0x15C4970 Offset: 0x15C3B70 VA: 0x1815C4970 Slot: 33
	public override Encoder GetEncoder() { }

	// RVA: 0x15C4A70 Offset: 0x15C3C70 VA: 0x1815C4A70 Slot: 34
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x15C4B60 Offset: 0x15C3D60 VA: 0x1815C4B60 Slot: 35
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x15C50D0 Offset: 0x15C42D0 VA: 0x1815C50D0
	private static void .cctor() { }
}

// Namespace: 
internal sealed class UTF8Encoding.UTF8EncodingSealed : UTF8Encoding // TypeDefIndex: 3505
{
	// Properties
	public override ReadOnlySpan<byte> Preamble { get; }

	// Methods

	// RVA: 0x15DBB30 Offset: 0x15DAD30 VA: 0x1815DBB30
	public void .ctor(bool encoderShouldEmitUTF8Identifier) { }

	// RVA: 0x15DBB90 Offset: 0x15DAD90 VA: 0x1815DBB90 Slot: 7
	public override ReadOnlySpan<byte> get_Preamble() { }
}

// Namespace: 
[Serializable]
private sealed class UTF8Encoding.UTF8Encoder : EncoderNLS // TypeDefIndex: 3506
{
	// Fields
	internal int surrogateChar; // 0x38

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x15DBB10 Offset: 0x15DAD10 VA: 0x1815DBB10
	public void .ctor(UTF8Encoding encoding) { }

	// RVA: 0x15DBAE0 Offset: 0x15DACE0 VA: 0x1815DBAE0 Slot: 4
	public override void Reset() { }

	// RVA: 0x15DBB20 Offset: 0x15DAD20 VA: 0x1815DBB20 Slot: 11
	internal override bool get_HasState() { }
}

// Namespace: 
[Serializable]
private sealed class UTF8Encoding.UTF8Decoder : DecoderNLS // TypeDefIndex: 3507
{
	// Fields
	internal int bits; // 0x30

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x15DBAC0 Offset: 0x15DACC0 VA: 0x1815DBAC0
	public void .ctor(UTF8Encoding encoding) { }

	// RVA: 0x15DBA90 Offset: 0x15DAC90 VA: 0x1815DBA90 Slot: 4
	public override void Reset() { }

	// RVA: 0x15DBAD0 Offset: 0x15DACD0 VA: 0x1815DBAD0 Slot: 14
	internal override bool get_HasState() { }
}

// Namespace: System.Text
[Serializable]
public class UTF8Encoding : Encoding // TypeDefIndex: 3508
{
	// Fields
	internal static readonly UTF8Encoding.UTF8EncodingSealed s_default; // 0x0
	internal static readonly byte[] s_preamble; // 0x8
	internal readonly bool _emitUTF8Identifier; // 0x38
	private bool _isThrowException; // 0x39

	// Properties
	public override ReadOnlySpan<byte> Preamble { get; }

	// Methods

	// RVA: 0x15C89F0 Offset: 0x15C7BF0 VA: 0x1815C89F0
	public void .ctor() { }

	// RVA: 0x15C8A20 Offset: 0x15C7C20 VA: 0x1815C8A20
	public void .ctor(bool encoderShouldEmitUTF8Identifier) { }

	// RVA: 0x15C8990 Offset: 0x15C7B90 VA: 0x1815C8990
	public void .ctor(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) { }

	// RVA: 0x15C8810 Offset: 0x15C7A10 VA: 0x1815C8810 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x15C5AB0 Offset: 0x15C4CB0 VA: 0x1815C5AB0 Slot: 14
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x15C5370 Offset: 0x15C4570 VA: 0x1815C5370 Slot: 13
	public override int GetByteCount(string chars) { }

	[CLSCompliant(False)]
	// RVA: 0x15C5C60 Offset: 0x15C4E60 VA: 0x1815C5C60 Slot: 15
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x15C68E0 Offset: 0x15C5AE0 VA: 0x1815C68E0 Slot: 21
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x15C6BB0 Offset: 0x15C5DB0 VA: 0x1815C6BB0 Slot: 19
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x15C67B0 Offset: 0x15C59B0 VA: 0x1815C67B0 Slot: 23
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x15C7430 Offset: 0x15C6630 VA: 0x1815C7430 Slot: 24
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x15C7330 Offset: 0x15C6530 VA: 0x1815C7330 Slot: 25
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x15C75E0 Offset: 0x15C67E0 VA: 0x1815C75E0 Slot: 28
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x15C80A0 Offset: 0x15C72A0 VA: 0x1815C80A0 Slot: 29
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x15C8610 Offset: 0x15C7810 VA: 0x1815C8610 Slot: 37
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x15C5410 Offset: 0x15C4610 VA: 0x1815C5410 Slot: 16
	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	// RVA: 0x15C8800 Offset: 0x15C7A00 VA: 0x1815C8800
	private static int PtrDiff(char* a, char* b) { }

	// RVA: 0x15C87F0 Offset: 0x15C79F0 VA: 0x1815C87F0
	private static int PtrDiff(byte* a, byte* b) { }

	// RVA: 0x10DD040 Offset: 0x10DC240 VA: 0x1810DD040
	private static bool InRange(int ch, int start, int end) { }

	// RVA: 0x15C5FC0 Offset: 0x15C51C0 VA: 0x1815C5FC0 Slot: 22
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	// RVA: 0x15C6E80 Offset: 0x15C6080 VA: 0x1815C6E80 Slot: 26
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x15C78B0 Offset: 0x15C6AB0 VA: 0x1815C78B0 Slot: 30
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x15C52F0 Offset: 0x15C44F0 VA: 0x1815C52F0
	private bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget) { }

	// RVA: 0x15C52A0 Offset: 0x15C44A0 VA: 0x1815C52A0
	private int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback) { }

	// RVA: 0x15C5D60 Offset: 0x15C4F60 VA: 0x1815C5D60
	private byte[] GetBytesUnknown(ref byte* pSrc, int ch) { }

	// RVA: 0x15C81D0 Offset: 0x15C73D0 VA: 0x1815C81D0 Slot: 32
	public override Decoder GetDecoder() { }

	// RVA: 0x15C8230 Offset: 0x15C7430 VA: 0x1815C8230 Slot: 33
	public override Encoder GetEncoder() { }

	// RVA: 0x15C8300 Offset: 0x15C7500 VA: 0x1815C8300 Slot: 34
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x15C8440 Offset: 0x15C7640 VA: 0x1815C8440 Slot: 35
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x15C8580 Offset: 0x15C7780 VA: 0x1815C8580 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x15C8A50 Offset: 0x15C7C50 VA: 0x1815C8A50 Slot: 7
	public override ReadOnlySpan<byte> get_Preamble() { }

	// RVA: 0x15C51B0 Offset: 0x15C43B0 VA: 0x1815C51B0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x15C8290 Offset: 0x15C7490 VA: 0x1815C8290 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15C88D0 Offset: 0x15C7AD0 VA: 0x1815C88D0
	private static void .cctor() { }
}

// Namespace: 
[Serializable]
private sealed class UnicodeEncoding.Decoder : DecoderNLS // TypeDefIndex: 3509
{
	// Fields
	internal int lastByte; // 0x30
	internal char lastChar; // 0x34

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x15CB2D0 Offset: 0x15CA4D0 VA: 0x1815CB2D0
	public void .ctor(UnicodeEncoding encoding) { }

	// RVA: 0x15CB2A0 Offset: 0x15CA4A0 VA: 0x1815CB2A0 Slot: 4
	public override void Reset() { }

	// RVA: 0x15CB2E0 Offset: 0x15CA4E0 VA: 0x1815CB2E0 Slot: 14
	internal override bool get_HasState() { }
}

// Namespace: System.Text
[Serializable]
public class UnicodeEncoding : Encoding // TypeDefIndex: 3510
{
	// Fields
	internal static readonly UnicodeEncoding s_bigEndianDefault; // 0x0
	internal static readonly UnicodeEncoding s_littleEndianDefault; // 0x8
	private static readonly byte[] s_bigEndianPreamble; // 0x10
	private static readonly byte[] s_littleEndianPreamble; // 0x18
	internal bool isThrowException; // 0x38
	internal bool bigEndian; // 0x39
	internal bool byteOrderMark; // 0x3A
	private static readonly ulong highLowPatternMask; // 0x20

	// Properties
	public override ReadOnlySpan<byte> Preamble { get; }

	// Methods

	// RVA: 0x15DFB90 Offset: 0x15DED90 VA: 0x1815DFB90
	public void .ctor() { }

	// RVA: 0x15DFB40 Offset: 0x15DED40 VA: 0x1815DFB40
	public void .ctor(bool bigEndian, bool byteOrderMark) { }

	// RVA: 0x15DFAC0 Offset: 0x15DECC0 VA: 0x1815DFAC0
	public void .ctor(bool bigEndian, bool byteOrderMark, bool throwOnInvalidBytes) { }

	// RVA: 0x15DF8A0 Offset: 0x15DEAA0 VA: 0x1815DF8A0 Slot: 5
	internal override void SetDefaultFallbacks() { }

	// RVA: 0x15DBD70 Offset: 0x15DAF70 VA: 0x1815DBD70 Slot: 14
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x15DC690 Offset: 0x15DB890 VA: 0x1815DC690 Slot: 13
	public override int GetByteCount(string s) { }

	[CLSCompliant(False)]
	// RVA: 0x15DC730 Offset: 0x15DB930 VA: 0x1815DC730 Slot: 15
	public override int GetByteCount(char* chars, int count) { }

	// RVA: 0x15DC830 Offset: 0x15DBA30 VA: 0x1815DC830 Slot: 21
	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x15DD460 Offset: 0x15DC660 VA: 0x1815DD460 Slot: 19
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x15DD730 Offset: 0x15DC930 VA: 0x1815DD730 Slot: 23
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: 0x15DE1C0 Offset: 0x15DD3C0 VA: 0x1815DE1C0 Slot: 24
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x15DE0C0 Offset: 0x15DD2C0 VA: 0x1815DE0C0 Slot: 25
	public override int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x15DEF50 Offset: 0x15DE150 VA: 0x1815DEF50 Slot: 28
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x15DEE20 Offset: 0x15DE020 VA: 0x1815DEE20 Slot: 29
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x15DF6C0 Offset: 0x15DE8C0 VA: 0x1815DF6C0 Slot: 37
	public override string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x15DBF20 Offset: 0x15DB120 VA: 0x1815DBF20 Slot: 16
	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x15DCB00 Offset: 0x15DBD00 VA: 0x1815DCB00 Slot: 22
	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	// RVA: 0x15DD860 Offset: 0x15DCA60 VA: 0x1815DD860 Slot: 26
	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	// RVA: 0x15DE370 Offset: 0x15DD570 VA: 0x1815DE370 Slot: 30
	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	// RVA: 0x15DF280 Offset: 0x15DE480 VA: 0x1815DF280 Slot: 33
	public override Encoder GetEncoder() { }

	// RVA: 0x15DF220 Offset: 0x15DE420 VA: 0x1815DF220 Slot: 32
	public override Decoder GetDecoder() { }

	// RVA: 0x15DF610 Offset: 0x15DE810 VA: 0x1815DF610 Slot: 6
	public override byte[] GetPreamble() { }

	// RVA: 0x15DFBC0 Offset: 0x15DEDC0 VA: 0x1815DFBC0 Slot: 7
	public override ReadOnlySpan<byte> get_Preamble() { }

	// RVA: 0x15DF380 Offset: 0x15DE580 VA: 0x1815DF380 Slot: 34
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x15DF4C0 Offset: 0x15DE6C0 VA: 0x1815DF4C0 Slot: 35
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x15DBC40 Offset: 0x15DAE40 VA: 0x1815DBC40 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x15DF2E0 Offset: 0x15DE4E0 VA: 0x1815DF2E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15DF960 Offset: 0x15DEB60 VA: 0x1815DF960
	private static void .cctor() { }
}

// Namespace: System.Text
[DefaultMember("Item")]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[IsByRefLike]
internal struct ValueStringBuilder // TypeDefIndex: 3511
{
	// Fields
	private char[] _arrayToReturnToPool; // 0x0
	private Span<char> _chars; // 0x8
	private int _pos; // 0x18

	// Properties
	public int Length { get; }
	public char Item { get; }

	// Methods

	// RVA: 0x15E07D0 Offset: 0x15DF9D0 VA: 0x1815E07D0
	public void .ctor(Span<char> initialBuffer) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_Length() { }

	// RVA: 0x15E07E0 Offset: 0x15DF9E0 VA: 0x1815E07E0
	public ref char get_Item(int index) { }

	// RVA: 0x15E0600 Offset: 0x15DF800 VA: 0x1815E0600 Slot: 3
	public override string ToString() { }

	// RVA: 0x15E06E0 Offset: 0x15DF8E0 VA: 0x1815E06E0
	public bool TryCopyTo(Span<char> destination, out int charsWritten) { }

	// RVA: 0x15E02D0 Offset: 0x15DF4D0 VA: 0x1815E02D0
	public void Append(char c) { }

	// RVA: 0x15E0030 Offset: 0x15DF230 VA: 0x1815E0030
	public void Append(string s) { }

	// RVA: 0x15DFD20 Offset: 0x15DEF20 VA: 0x1815DFD20
	private void AppendSlow(string s) { }

	// RVA: 0x15E01F0 Offset: 0x15DF3F0 VA: 0x1815E01F0
	public void Append(char c, int count) { }

	// RVA: 0x15DFF50 Offset: 0x15DF150 VA: 0x1815DFF50
	public void Append(char* value, int length) { }

	// RVA: 0x15DFE70 Offset: 0x15DF070 VA: 0x1815DFE70
	public Span<char> AppendSpan(int length) { }

	// RVA: 0x15E03E0 Offset: 0x15DF5E0 VA: 0x1815E03E0
	private void GrowAndAppend(char c) { }

	// RVA: 0x15E0450 Offset: 0x15DF650 VA: 0x1815E0450
	private void Grow(int requiredAdditionalCapacity) { }

	// RVA: 0x15E0340 Offset: 0x15DF540 VA: 0x1815E0340
	public void Dispose() { }
}

// Namespace: 
[Serializable]
internal class Encoding.DefaultEncoder : Encoder, ISerializable, IObjectReference // TypeDefIndex: 3512
{
	// Fields
	private Encoding m_encoding; // 0x20
	private bool m_hasInitializedEncoding; // 0x28
	internal char charLeftOver; // 0x2A

	// Methods

	// RVA: 0x15CB7B0 Offset: 0x15CA9B0 VA: 0x1815CB7B0
	public void .ctor(Encoding encoding) { }

	// RVA: 0x15CBA30 Offset: 0x15CAC30 VA: 0x1815CBA30
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15CB8B0 Offset: 0x15CAAB0 VA: 0x1815CB8B0 Slot: 12
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x15CB990 Offset: 0x15CAB90 VA: 0x1815CB990 Slot: 11
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15CB810 Offset: 0x15CAA10 VA: 0x1815CB810 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool flush) { }

	// RVA: 0x15CB7E0 Offset: 0x15CA9E0 VA: 0x1815CB7E0 Slot: 6
	public override int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: 0x15CB840 Offset: 0x15CAA40 VA: 0x1815CB840 Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: 0x15CB880 Offset: 0x15CAA80 VA: 0x1815CB880 Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }
}

// Namespace: 
[Serializable]
internal class Encoding.DefaultDecoder : Decoder, ISerializable, IObjectReference // TypeDefIndex: 3513
{
	// Fields
	private Encoding m_encoding; // 0x20
	private bool m_hasInitializedEncoding; // 0x28

	// Methods

	// RVA: 0x15CB7B0 Offset: 0x15CA9B0 VA: 0x1815CB7B0
	public void .ctor(Encoding encoding) { }

	// RVA: 0x15CB4D0 Offset: 0x15CA6D0 VA: 0x1815CB4D0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15CB3D0 Offset: 0x15CA5D0 VA: 0x1815CB3D0 Slot: 15
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x15CB430 Offset: 0x15CA630 VA: 0x1815CB430 Slot: 14
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15B4300 Offset: 0x15B3500 VA: 0x1815B4300 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x15CB300 Offset: 0x15CA500 VA: 0x1815CB300 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x15CB330 Offset: 0x15CA530 VA: 0x1815CB330 Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x15B4650 Offset: 0x15B3850 VA: 0x1815B4650 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x15CB390 Offset: 0x15CA590 VA: 0x1815CB390 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x15CB360 Offset: 0x15CA560 VA: 0x1815CB360 Slot: 10
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }
}

// Namespace: 
internal class Encoding.EncodingCharBuffer // TypeDefIndex: 3514
{
	// Fields
	private char* chars; // 0x10
	private char* charStart; // 0x18
	private char* charEnd; // 0x20
	private int charCountResult; // 0x28
	private Encoding enc; // 0x30
	private DecoderNLS decoder; // 0x38
	private byte* byteStart; // 0x40
	private byte* byteEnd; // 0x48
	private byte* bytes; // 0x50
	private DecoderFallbackBuffer fallbackBuffer; // 0x58

	// Properties
	internal bool MoreData { get; }
	internal int BytesUsed { get; }
	internal int Count { get; }

	// Methods

	// RVA: 0x15CC750 Offset: 0x15CB950 VA: 0x1815CC750
	internal void .ctor(Encoding enc, DecoderNLS decoder, char* charStart, int charCount, byte* byteStart, int byteCount) { }

	// RVA: 0x15CC370 Offset: 0x15CB570 VA: 0x1815CC370
	internal bool AddChar(char ch, int numBytes) { }

	// RVA: 0x15CC460 Offset: 0x15CB660 VA: 0x1815CC460
	internal bool AddChar(char ch) { }

	// RVA: 0x15CC540 Offset: 0x15CB740 VA: 0x1815CC540
	internal void AdjustBytes(int count) { }

	// RVA: 0x15CC830 Offset: 0x15CBA30 VA: 0x1815CC830
	internal bool get_MoreData() { }

	// RVA: 0x15CC730 Offset: 0x15CB930 VA: 0x1815CC730
	internal byte GetNextByte() { }

	// RVA: 0x15CC820 Offset: 0x15CBA20 VA: 0x1815CC820
	internal int get_BytesUsed() { }

	// RVA: 0x15CC550 Offset: 0x15CB750 VA: 0x1815CC550
	internal bool Fallback(byte fallbackByte) { }

	// RVA: 0x15CC5C0 Offset: 0x15CB7C0 VA: 0x1815CC5C0
	internal bool Fallback(byte[] byteBuffer) { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	internal int get_Count() { }
}

// Namespace: 
internal class Encoding.EncodingByteBuffer // TypeDefIndex: 3515
{
	// Fields
	private byte* bytes; // 0x10
	private byte* byteStart; // 0x18
	private byte* byteEnd; // 0x20
	private char* chars; // 0x28
	private char* charStart; // 0x30
	private char* charEnd; // 0x38
	private int byteCountResult; // 0x40
	private Encoding enc; // 0x48
	private EncoderNLS encoder; // 0x50
	internal EncoderFallbackBuffer fallbackBuffer; // 0x58

	// Properties
	internal bool MoreData { get; }
	internal int CharsUsed { get; }
	internal int Count { get; }

	// Methods

	// RVA: 0x15CC0C0 Offset: 0x15CB2C0 VA: 0x1815CC0C0
	internal void .ctor(Encoding inEncoding, EncoderNLS inEncoder, byte* inByteStart, int inByteCount, char* inCharStart, int inCharCount) { }

	// RVA: 0x15CBE50 Offset: 0x15CB050 VA: 0x1815CBE50
	internal bool AddByte(byte b, int moreBytesExpected) { }

	// RVA: 0x15CBE40 Offset: 0x15CB040 VA: 0x1815CBE40
	internal bool AddByte(byte b1) { }

	// RVA: 0x15CBDF0 Offset: 0x15CAFF0 VA: 0x1815CBDF0
	internal bool AddByte(byte b1, byte b2) { }

	// RVA: 0x15CBD90 Offset: 0x15CAF90 VA: 0x1815CBD90
	internal bool AddByte(byte b1, byte b2, int moreBytesExpected) { }

	// RVA: 0x15CBFC0 Offset: 0x15CB1C0 VA: 0x1815CBFC0
	internal void MovePrevious(bool bThrow) { }

	// RVA: 0x15CC320 Offset: 0x15CB520 VA: 0x1815CC320
	internal bool get_MoreData() { }

	// RVA: 0x15CBF70 Offset: 0x15CB170 VA: 0x1815CBF70
	internal char GetNextChar() { }

	// RVA: 0x15CC300 Offset: 0x15CB500 VA: 0x1815CC300
	internal int get_CharsUsed() { }

	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440
	internal int get_Count() { }
}

// Namespace: System.Text
[ComVisible(True)]
[Serializable]
public abstract class Encoding : ICloneable // TypeDefIndex: 3516
{
	// Fields
	private static Encoding defaultEncoding; // 0x0
	private static Encoding unicodeEncoding; // 0x8
	private static Encoding bigEndianUnicode; // 0x10
	private static Encoding utf7Encoding; // 0x18
	private static Encoding utf8Encoding; // 0x20
	private static Encoding utf32Encoding; // 0x28
	private static Encoding asciiEncoding; // 0x30
	private static Encoding latin1Encoding; // 0x38
	private static Dictionary<int, Encoding> encodings; // 0x40
	private const int MIMECONTF_MAILNEWS = 1;
	private const int MIMECONTF_BROWSER = 2;
	private const int MIMECONTF_SAVABLE_MAILNEWS = 256;
	private const int MIMECONTF_SAVABLE_BROWSER = 512;
	private const int CodePageDefault = 0;
	private const int CodePageNoOEM = 1;
	private const int CodePageNoMac = 2;
	private const int CodePageNoThread = 3;
	private const int CodePageNoSymbol = 42;
	private const int CodePageUnicode = 1200;
	private const int CodePageBigEndian = 1201;
	private const int CodePageWindows1252 = 1252;
	private const int CodePageMacGB2312 = 10008;
	private const int CodePageGB2312 = 20936;
	private const int CodePageMacKorean = 10003;
	private const int CodePageDLLKorean = 20949;
	private const int ISO2022JP = 50220;
	private const int ISO2022JPESC = 50221;
	private const int ISO2022JPSISO = 50222;
	private const int ISOKorean = 50225;
	private const int ISOSimplifiedCN = 50227;
	private const int EUCJP = 51932;
	private const int ChineseHZ = 52936;
	private const int DuplicateEUCCN = 51936;
	private const int EUCCN = 936;
	private const int EUCKR = 51949;
	internal const int CodePageASCII = 20127;
	internal const int ISO_8859_1 = 28591;
	private const int ISCIIAssemese = 57006;
	private const int ISCIIBengali = 57003;
	private const int ISCIIDevanagari = 57002;
	private const int ISCIIGujarathi = 57010;
	private const int ISCIIKannada = 57008;
	private const int ISCIIMalayalam = 57009;
	private const int ISCIIOriya = 57007;
	private const int ISCIIPanjabi = 57011;
	private const int ISCIITamil = 57004;
	private const int ISCIITelugu = 57005;
	private const int GB18030 = 54936;
	private const int ISO_8859_8I = 38598;
	private const int ISO_8859_8_Visual = 28598;
	private const int ENC50229 = 50229;
	private const int CodePageUTF7 = 65000;
	private const int CodePageUTF8 = 65001;
	private const int CodePageUTF32 = 12000;
	private const int CodePageUTF32BE = 12001;
	internal int m_codePage; // 0x10
	internal CodePageDataItem dataItem; // 0x18
	internal bool m_deserializedFromEverett; // 0x20
	[OptionalField(VersionAdded = 2)]
	private bool m_isReadOnly; // 0x21
	[OptionalField(VersionAdded = 2)]
	internal EncoderFallback encoderFallback; // 0x28
	[OptionalField(VersionAdded = 2)]
	internal DecoderFallback decoderFallback; // 0x30
	private static object s_InternalSyncObject; // 0x48

	// Properties
	private static object InternalSyncObject { get; }
	public virtual ReadOnlySpan<byte> Preamble { get; }
	public virtual string BodyName { get; }
	public virtual string EncodingName { get; }
	public virtual string HeaderName { get; }
	public virtual string WebName { get; }
	[ComVisible(False)]
	public EncoderFallback EncoderFallback { get; set; }
	[ComVisible(False)]
	public DecoderFallback DecoderFallback { get; set; }
	[ComVisible(False)]
	public bool IsReadOnly { get; }
	public static Encoding ASCII { get; }
	private static Encoding Latin1 { get; }
	public virtual int CodePage { get; }
	public static Encoding Default { get; }
	public static Encoding Unicode { get; }
	public static Encoding BigEndianUnicode { get; }
	public static Encoding UTF7 { get; }
	public static Encoding UTF8 { get; }
	public static Encoding UTF32 { get; }

	// Methods

	// RVA: 0x15D0250 Offset: 0x15CF450 VA: 0x1815D0250
	protected void .ctor() { }

	// RVA: 0x15D0290 Offset: 0x15CF490 VA: 0x1815D0290
	protected void .ctor(int codePage) { }

	// RVA: 0x15CFE60 Offset: 0x15CF060 VA: 0x1815CFE60 Slot: 5
	internal virtual void SetDefaultFallbacks() { }

	// RVA: 0x15CFCE0 Offset: 0x15CEEE0 VA: 0x1815CFCE0
	internal void OnDeserializing() { }

	// RVA: 0x15CFC90 Offset: 0x15CEE90 VA: 0x1815CFC90
	internal void OnDeserialized() { }

	[OnDeserializing]
	// RVA: 0x15CFCE0 Offset: 0x15CEEE0 VA: 0x1815CFCE0
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserialized]
	// RVA: 0x15CFC90 Offset: 0x15CEE90 VA: 0x1815CFC90
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializing]
	// RVA: 0x132CF80 Offset: 0x132C180 VA: 0x18132CF80
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x15CD4A0 Offset: 0x15CC6A0 VA: 0x1815CD4A0
	internal void DeserializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15CFCF0 Offset: 0x15CEEF0 VA: 0x1815CFCF0
	internal void SerializeEncoding(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15CD1B0 Offset: 0x15CC3B0 VA: 0x1815CD1B0
	public static byte[] Convert(Encoding srcEncoding, Encoding dstEncoding, byte[] bytes) { }

	// RVA: 0x15CD2F0 Offset: 0x15CC4F0 VA: 0x1815CD2F0
	public static byte[] Convert(Encoding srcEncoding, Encoding dstEncoding, byte[] bytes, int index, int count) { }

	// RVA: 0x15D05C0 Offset: 0x15CF7C0 VA: 0x1815D05C0
	private static object get_InternalSyncObject() { }

	// RVA: 0x15CED70 Offset: 0x15CDF70 VA: 0x1815CED70
	public static Encoding GetEncoding(int codepage) { }

	// RVA: 0x15CEA70 Offset: 0x15CDC70 VA: 0x1815CEA70
	public static Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback) { }

	// RVA: 0x15CECE0 Offset: 0x15CDEE0 VA: 0x1815CECE0
	public static Encoding GetEncoding(string name) { }

	// RVA: 0x15CE9C0 Offset: 0x15CDBC0 VA: 0x1815CE9C0
	public static Encoding GetEncoding(string name, EncoderFallback encoderFallback, DecoderFallback decoderFallback) { }

	// RVA: 0x15CF8F0 Offset: 0x15CEAF0 VA: 0x1815CF8F0 Slot: 6
	public virtual byte[] GetPreamble() { }

	// RVA: 0x15D0700 Offset: 0x15CF900 VA: 0x1815D0700 Slot: 7
	public virtual ReadOnlySpan<byte> get_Preamble() { }

	// RVA: 0x15CE7E0 Offset: 0x15CD9E0 VA: 0x1815CE7E0
	private void GetDataItem() { }

	// RVA: 0x15D0470 Offset: 0x15CF670 VA: 0x1815D0470 Slot: 8
	public virtual string get_BodyName() { }

	// RVA: 0x15D0570 Offset: 0x15CF770 VA: 0x1815D0570 Slot: 9
	public virtual string get_EncodingName() { }

	// RVA: 0x15D0580 Offset: 0x15CF780 VA: 0x1815D0580 Slot: 10
	public virtual string get_HeaderName() { }

	// RVA: 0x15D0A00 Offset: 0x15CFC00 VA: 0x1815D0A00 Slot: 11
	public virtual string get_WebName() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public EncoderFallback get_EncoderFallback() { }

	// RVA: 0x15D0B10 Offset: 0x15CFD10 VA: 0x1815D0B10
	public void set_EncoderFallback(EncoderFallback value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public DecoderFallback get_DecoderFallback() { }

	// RVA: 0x15D0A40 Offset: 0x15CFC40 VA: 0x1815D0A40
	public void set_DecoderFallback(DecoderFallback value) { }

	[ComVisible(False)]
	// RVA: 0x15CD110 Offset: 0x15CC310 VA: 0x1815CD110 Slot: 12
	public virtual object Clone() { }

	// RVA: 0x4BD710 Offset: 0x4BC910 VA: 0x1804BD710
	public bool get_IsReadOnly() { }

	// RVA: 0x15D0320 Offset: 0x15CF520 VA: 0x1815D0320
	public static Encoding get_ASCII() { }

	// RVA: 0x15D0660 Offset: 0x15CF860 VA: 0x1815D0660
	private static Encoding get_Latin1() { }

	// RVA: 0x15CDA20 Offset: 0x15CCC20 VA: 0x1815CDA20 Slot: 13
	public virtual int GetByteCount(string s) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int GetByteCount(char[] chars, int index, int count);

	// RVA: 0x15CDC60 Offset: 0x15CCE60 VA: 0x1815CDC60
	public int GetByteCount(string str, int index, int count) { }

	[ComVisible(False)]
	[CLSCompliant(False)]
	// RVA: 0x15CDAC0 Offset: 0x15CCCC0 VA: 0x1815CDAC0 Slot: 15
	public virtual int GetByteCount(char* chars, int count) { }

	// RVA: 0x15CDCD0 Offset: 0x15CCED0 VA: 0x1815CDCD0 Slot: 16
	internal virtual int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	// RVA: 0x15CE050 Offset: 0x15CD250 VA: 0x1815CE050 Slot: 17
	public virtual byte[] GetBytes(char[] chars) { }

	// RVA: 0x15CDF60 Offset: 0x15CD160 VA: 0x1815CDF60 Slot: 18
	public virtual byte[] GetBytes(char[] chars, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);

	// RVA: 0x15CE100 Offset: 0x15CD300 VA: 0x1815CE100 Slot: 20
	public virtual byte[] GetBytes(string s) { }

	// RVA: 0x15CE210 Offset: 0x15CD410 VA: 0x1815CE210 Slot: 21
	public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x15CE030 Offset: 0x15CD230 VA: 0x1815CE030 Slot: 22
	internal virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	[CLSCompliant(False)]
	[ComVisible(False)]
	// RVA: 0x15CDCF0 Offset: 0x15CCEF0 VA: 0x1815CDCF0 Slot: 23
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract int GetCharCount(byte[] bytes, int index, int count);

	[CLSCompliant(False)]
	[ComVisible(False)]
	// RVA: 0x15CE2C0 Offset: 0x15CD4C0 VA: 0x1815CE2C0 Slot: 25
	public virtual int GetCharCount(byte* bytes, int count) { }

	// RVA: 0x15CE460 Offset: 0x15CD660 VA: 0x1815CE460 Slot: 26
	internal virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	// RVA: 0x15CE480 Offset: 0x15CD680 VA: 0x1815CE480 Slot: 27
	public virtual char[] GetChars(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 28
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	[CLSCompliant(False)]
	[ComVisible(False)]
	// RVA: 0x15CE570 Offset: 0x15CD770 VA: 0x1815CE570 Slot: 29
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	// RVA: 0x15CE550 Offset: 0x15CD750 VA: 0x1815CE550 Slot: 30
	internal virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	[CLSCompliant(False)]
	[ComVisible(False)]
	// RVA: 0x15CF9F0 Offset: 0x15CEBF0 VA: 0x1815CF9F0
	public string GetString(byte* bytes, int byteCount) { }

	// RVA: 0x15CFAF0 Offset: 0x15CECF0 VA: 0x1815CFAF0
	public string GetString(ReadOnlySpan<byte> bytes) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 31
	public virtual int get_CodePage() { }

	// RVA: 0x15CE900 Offset: 0x15CDB00 VA: 0x1815CE900 Slot: 32
	public virtual Decoder GetDecoder() { }

	// RVA: 0x15CD450 Offset: 0x15CC650 VA: 0x1815CD450
	private static Encoding CreateDefaultEncoding() { }

	// RVA: 0x4BD770 Offset: 0x4BC970 VA: 0x1804BD770
	internal void setReadOnly(bool value = True) { }

	// RVA: 0x15D04B0 Offset: 0x15CF6B0 VA: 0x1815D04B0
	public static Encoding get_Default() { }

	// RVA: 0x15CE960 Offset: 0x15CDB60 VA: 0x1815CE960 Slot: 33
	public virtual Encoder GetEncoder() { }

	// RVA: -1 Offset: -1 Slot: 34
	public abstract int GetMaxByteCount(int charCount);

	// RVA: -1 Offset: -1 Slot: 35
	public abstract int GetMaxCharCount(int byteCount);

	// RVA: 0x15CF940 Offset: 0x15CEB40 VA: 0x1815CF940 Slot: 36
	public virtual string GetString(byte[] bytes) { }

	// RVA: 0x15CFC60 Offset: 0x15CEE60 VA: 0x1815CFC60 Slot: 37
	public virtual string GetString(byte[] bytes, int index, int count) { }

	// RVA: 0x15D0950 Offset: 0x15CFB50 VA: 0x1815D0950
	public static Encoding get_Unicode() { }

	// RVA: 0x15D03C0 Offset: 0x15CF5C0 VA: 0x1815D03C0
	public static Encoding get_BigEndianUnicode() { }

	// RVA: 0x15D0810 Offset: 0x15CFA10 VA: 0x1815D0810
	public static Encoding get_UTF7() { }

	// RVA: 0x15D08B0 Offset: 0x15CFAB0 VA: 0x1815D08B0
	public static Encoding get_UTF8() { }

	// RVA: 0x15D0770 Offset: 0x15CF970 VA: 0x1815D0770
	public static Encoding get_UTF32() { }

	// RVA: 0x15CD890 Offset: 0x15CCA90 VA: 0x1815CD890 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x15CF880 Offset: 0x15CEA80 VA: 0x1815CF880 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15CD9D0 Offset: 0x15CCBD0 VA: 0x1815CD9D0 Slot: 38
	internal virtual char[] GetBestFitUnicodeToBytesData() { }

	// RVA: 0x15CD980 Offset: 0x15CCB80 VA: 0x1815CD980 Slot: 39
	internal virtual char[] GetBestFitBytesToUnicodeData() { }

	// RVA: 0x15CFEF0 Offset: 0x15CF0F0 VA: 0x1815CFEF0
	internal void ThrowBytesOverflow() { }

	// RVA: 0x15D0000 Offset: 0x15CF200 VA: 0x1815D0000
	internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded) { }

	// RVA: 0x15D00A0 Offset: 0x15CF2A0 VA: 0x1815D00A0
	internal void ThrowCharsOverflow() { }

	// RVA: 0x15D01B0 Offset: 0x15CF3B0 VA: 0x1815D01B0
	internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded) { }
}

// Namespace: System.Text
internal enum NormalizationCheck // TypeDefIndex: 3517
{
	// Fields
	public int value__; // 0x0
	public const NormalizationCheck Yes = 0;
	public const NormalizationCheck No = 1;
	public const NormalizationCheck Maybe = 2;
}

// Namespace: System.Text
internal class Normalization // TypeDefIndex: 3518
{
	// Fields
	private static byte* props; // 0x0
	private static int* mappedChars; // 0x8
	private static short* charMapIndex; // 0x10
	private static short* helperIndex; // 0x18
	private static ushort* mapIdxToComposite; // 0x20
	private static byte* combiningClass; // 0x28
	private static object forLock; // 0x30
	public static readonly bool isReady; // 0x38

	// Methods

	// RVA: 0x15D3640 Offset: 0x15D2840 VA: 0x1815D3640
	private static uint PropValue(int cp) { }

	// RVA: 0x15D14F0 Offset: 0x15D06F0 VA: 0x1815D14F0
	private static int CharMapIdx(int cp) { }

	// RVA: 0x15D2BA0 Offset: 0x15D1DA0 VA: 0x1815D2BA0
	private static byte GetCombiningClass(int c) { }

	// RVA: 0x15D2C50 Offset: 0x15D1E50 VA: 0x1815D2C50
	private static int GetPrimaryCompositeFromMapIndex(int src) { }

	// RVA: 0x15D2D00 Offset: 0x15D1F00 VA: 0x1815D2D00
	private static int GetPrimaryCompositeHelperIndex(int cp) { }

	// RVA: 0x15D1AE0 Offset: 0x15D0CE0 VA: 0x1815D1AE0
	private static string Compose(string source, int checkType) { }

	// RVA: 0x15D1780 Offset: 0x15D0980 VA: 0x1815D1780
	private static StringBuilder Combine(string source, int start, int checkType) { }

	// RVA: 0x15D18B0 Offset: 0x15D0AB0 VA: 0x1815D18B0
	private static void Combine(StringBuilder sb, int i, int checkType) { }

	// RVA: 0x15D1580 Offset: 0x15D0780 VA: 0x1815D1580
	private static int CombineHangul(StringBuilder sb, string s, int current) { }

	// RVA: 0x15D26E0 Offset: 0x15D18E0 VA: 0x1815D26E0
	private static int Fetch(StringBuilder sb, string s, int i) { }

	// RVA: 0x15D3A90 Offset: 0x15D2C90 VA: 0x1815D3A90
	private static int TryComposeWithPreviousStarter(StringBuilder sb, string s, int current) { }

	// RVA: 0x15D3E00 Offset: 0x15D3000 VA: 0x1815D3E00
	private static int TryCompose(int i, int starter, int candidate) { }

	// RVA: 0x15D1ED0 Offset: 0x15D10D0 VA: 0x1815D1ED0
	private static string Decompose(string source, int checkType) { }

	// RVA: 0x15D2420 Offset: 0x15D1620 VA: 0x1815D2420
	private static void Decompose(string source, ref StringBuilder sb, int checkType) { }

	// RVA: 0x15D3810 Offset: 0x15D2A10 VA: 0x1815D3810
	private static void ReorderCanonical(string src, ref StringBuilder sb, int start) { }

	// RVA: 0x15D1CD0 Offset: 0x15D0ED0 VA: 0x1815D1CD0
	private static void DecomposeChar(ref StringBuilder sb, ref int[] buf, string s, int i, int checkType, ref int start) { }

	// RVA: 0x15D36D0 Offset: 0x15D28D0 VA: 0x1815D36D0
	public static NormalizationCheck QuickCheck(char c, int type) { }

	// RVA: 0x15D2730 Offset: 0x15D1930 VA: 0x1815D2730
	private static int GetCanonicalHangul(int s, int[] buf, int bufIdx) { }

	// RVA: 0x15D2850 Offset: 0x15D1A50 VA: 0x1815D2850
	private static int GetCanonical(int c, int[] buf, int bufIdx, int checkType) { }

	// RVA: 0x15D2DB0 Offset: 0x15D1FB0 VA: 0x1815D2DB0
	public static bool IsNormalized(string source, NormalizationForm normalizationForm) { }

	// RVA: 0x15D30A0 Offset: 0x15D22A0 VA: 0x1815D30A0
	public static bool IsNormalized(string source, int type) { }

	// RVA: 0x15D34D0 Offset: 0x15D26D0 VA: 0x1815D34D0
	public static string Normalize(string source, NormalizationForm normalizationForm) { }

	// RVA: 0x15D35A0 Offset: 0x15D27A0 VA: 0x1815D35A0
	public static string Normalize(string source, int type) { }

	// RVA: 0x15D41A0 Offset: 0x15D33A0 VA: 0x1815D41A0
	private static void load_normalization_resource(out IntPtr props, out IntPtr mappedChars, out IntPtr charMapIndex, out IntPtr helperIndex, out IntPtr mapIdxToComposite, out IntPtr combiningClass) { }

	// RVA: 0x15D3F70 Offset: 0x15D3170 VA: 0x1815D3F70
	private static void .cctor() { }
}

// Namespace: System.Text
internal static class EncodingHelper // TypeDefIndex: 3519
{
	// Fields
	private static Encoding utf8EncodingWithoutMarkers; // 0x0
	private static readonly object lockobj; // 0x8
	private static Assembly i18nAssembly; // 0x10
	private static bool i18nDisabled; // 0x18

	// Properties
	internal static Encoding UTF8Unmarked { get; }

	// Methods

	// RVA: 0x15CCF20 Offset: 0x15CC120 VA: 0x1815CCF20
	internal static Encoding get_UTF8Unmarked() { }

	// RVA: 0x15CC950 Offset: 0x15CBB50 VA: 0x1815CC950
	internal static string InternalCodePage(ref int code_page) { }

	// RVA: 0x15CC840 Offset: 0x15CBA40 VA: 0x1815CC840
	internal static Encoding GetDefaultEncoding() { }

	// RVA: 0x15CC960 Offset: 0x15CBB60 VA: 0x1815CC960
	internal static object InvokeI18N(string name, object[] args) { }

	// RVA: 0x15CCEC0 Offset: 0x15CC0C0 VA: 0x1815CCEC0
	private static void .cctor() { }
}

// Namespace: System.Security
public interface IPermission : ISecurityEncodable // TypeDefIndex: 3520
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Demand();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsSubsetOf(IPermission target);
}

// Namespace: System.Security
public interface ISecurityEncodable // TypeDefIndex: 3521
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract SecurityElement ToXml();
}

// Namespace: System.Security
[Serializable]
public sealed class XmlSyntaxException : SystemException // TypeDefIndex: 3522
{
	// Methods

	// RVA: 0x15E0800 Offset: 0x15DFA00 VA: 0x1815E0800
	public void .ctor() { }

	// RVA: 0x15E0800 Offset: 0x15DFA00 VA: 0x1815E0800
	public void .ctor(int lineNumber) { }

	// RVA: 0x15E0800 Offset: 0x15DFA00 VA: 0x1815E0800
	public void .ctor(int lineNumber, string message) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	private void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Security
[Serializable]
internal sealed class SecurityDocument // TypeDefIndex: 3523
{
	// Fields
	internal byte[] m_data; // 0x10

	// Methods

	// RVA: 0x15D8140 Offset: 0x15D7340 VA: 0x1815D8140
	public void .ctor(int numData) { }

	// RVA: 0x15D7E30 Offset: 0x15D7030 VA: 0x1815D7E30
	public void GuaranteeSize(int size) { }

	// RVA: 0x15D7760 Offset: 0x15D6960 VA: 0x1815D7760
	public void AddString(string str, ref int position) { }

	// RVA: 0x15D7990 Offset: 0x15D6B90 VA: 0x1815D7990
	public void AppendString(string str, ref int position) { }

	// RVA: 0x15D7A30 Offset: 0x15D6C30 VA: 0x1815D7A30
	public static int EncodedStringSize(string str) { }

	// RVA: 0x15D7AA0 Offset: 0x15D6CA0 VA: 0x1815D7AA0
	public string GetString(ref int position, bool bCreate) { }

	// RVA: 0x15D78B0 Offset: 0x15D6AB0 VA: 0x1815D78B0
	public void AddToken(byte b, ref int position) { }

	// RVA: 0x15D7A70 Offset: 0x15D6C70 VA: 0x1815D7A70
	public SecurityElement GetRootElement() { }

	// RVA: 0x15D7A50 Offset: 0x15D6C50 VA: 0x1815D7A50
	public SecurityElement GetElement(int position, bool bCreate) { }

	// RVA: 0x15D7ED0 Offset: 0x15D70D0 VA: 0x1815D7ED0
	internal SecurityElement InternalGetElement(ref int position, bool bCreate) { }
}

// Namespace: System.Security
[MonoTODO("CAS support is experimental (and unsupported).")]
[ComVisible(True)]
[Serializable]
public abstract class CodeAccessPermission : IPermission, ISecurityEncodable // TypeDefIndex: 3524
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IPermission Copy();

	[Conditional("MONO_FEATURE_CAS")]
	// RVA: 0x15C9220 Offset: 0x15C8420 VA: 0x1815C9220 Slot: 8
	public void Demand() { }

	[ComVisible(False)]
	// RVA: 0x15C93D0 Offset: 0x15C85D0 VA: 0x1815C93D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void FromXml(SecurityElement elem);

	[ComVisible(False)]
	// RVA: 0x15C9510 Offset: 0x15C8710 VA: 0x1815C9510 Slot: 2
	public override int GetHashCode() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IPermission Intersect(IPermission target);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool IsSubsetOf(IPermission target);

	// RVA: 0x15C9700 Offset: 0x15C8900 VA: 0x1815C9700 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract SecurityElement ToXml();

	// RVA: 0x15C9740 Offset: 0x15C8940 VA: 0x1815C9740 Slot: 13
	public virtual IPermission Union(IPermission other) { }

	// RVA: 0x15C9250 Offset: 0x15C8450 VA: 0x1815C9250
	internal SecurityElement Element(int version) { }

	// RVA: 0x15C8E10 Offset: 0x15C8010 VA: 0x1815C8E10
	internal static PermissionState CheckPermissionState(PermissionState state, bool allowUnrestricted) { }

	// RVA: 0x15C8ED0 Offset: 0x15C80D0 VA: 0x1815C8ED0
	internal static int CheckSecurityElement(SecurityElement se, string parameterName, int minimumVersion, int maximumVersion) { }

	// RVA: 0x15C9520 Offset: 0x15C8720 VA: 0x1815C9520
	internal static bool IsUnrestricted(SecurityElement se) { }

	// RVA: 0x15C9660 Offset: 0x15C8860 VA: 0x1815C9660
	internal static void ThrowInvalidPermission(IPermission target, Type expected) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.Security.IPermission.Demand() { }
}

// Namespace: System.Security
[ComVisible(True)]
[Serializable]
public sealed class NamedPermissionSet : PermissionSet // TypeDefIndex: 3525
{
	// Fields
	private string name; // 0x30
	private string description; // 0x38

	// Properties
	public string Name { get; set; }

	// Methods

	// RVA: 0x15D1250 Offset: 0x15D0450 VA: 0x1815D1250
	internal void .ctor() { }

	// RVA: 0x15D12E0 Offset: 0x15D04E0 VA: 0x1815D12E0
	public void .ctor(string name, PermissionState state) { }

	// RVA: 0x15D1110 Offset: 0x15D0310 VA: 0x1815D1110
	public void .ctor(string name) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_Name() { }

	// RVA: 0x15D1430 Offset: 0x15D0630 VA: 0x1815D1430
	public void set_Name(string value) { }

	// RVA: 0x15D1070 Offset: 0x15D0270 VA: 0x1815D1070 Slot: 13
	public override SecurityElement ToXml() { }

	[ComVisible(False)]
	// RVA: 0x15D0F70 Offset: 0x15D0170 VA: 0x1815D0F70 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisible(False)]
	// RVA: 0x15D0FF0 Offset: 0x15D01F0 VA: 0x1815D0FF0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Security
[ComVisible(True)]
[MonoTODO("CAS support is experimental (and unsupported).")]
[Serializable]
public class PermissionSet : ISecurityEncodable, ICollection, IEnumerable, IDeserializationCallback // TypeDefIndex: 3526
{
	// Fields
	private static object[] psUnrestricted; // 0x0
	private PermissionState state; // 0x10
	private ArrayList list; // 0x18
	private bool _declsec; // 0x20
	private bool[] _ignored; // 0x28
	private static object[] action; // 0x8

	// Properties
	public virtual int Count { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }

	// Methods

	// RVA: 0x15D61D0 Offset: 0x15D53D0 VA: 0x1815D61D0
	internal void .ctor() { }

	// RVA: 0x15D6230 Offset: 0x15D5430 VA: 0x1815D6230
	public void .ctor(PermissionState state) { }

	// RVA: 0x15D6130 Offset: 0x15D5330 VA: 0x1815D6130
	internal void .ctor(IPermission perm) { }

	// RVA: 0x15D5290 Offset: 0x15D4490 VA: 0x1815D5290 Slot: 11
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x15D5430 Offset: 0x15D4630 VA: 0x1815D5430 Slot: 12
	public void Demand() { }

	// RVA: 0x15D5220 Offset: 0x15D4420 VA: 0x1815D5220
	internal void CasOnlyDemand(int skip) { }

	// RVA: 0x15D5810 Offset: 0x15D4A10 VA: 0x1815D5810 Slot: 9
	public IEnumerator GetEnumerator() { }

	// RVA: 0x15D5890 Offset: 0x15D4A90 VA: 0x1815D5890
	public bool IsEmpty() { }

	// RVA: 0xBE5120 Offset: 0xBE4320 VA: 0x180BE5120
	public bool IsUnrestricted() { }

	// RVA: 0x15D5B20 Offset: 0x15D4D20 VA: 0x1815D5B20 Slot: 3
	public override string ToString() { }

	// RVA: 0x15D5B60 Offset: 0x15D4D60 VA: 0x1815D5B60 Slot: 13
	public virtual SecurityElement ToXml() { }

	// RVA: 0x15D62B0 Offset: 0x15D54B0 VA: 0x1815D62B0 Slot: 14
	public virtual int get_Count() { }

	// RVA: 0x15D62E0 Offset: 0x15D54E0 VA: 0x1815D62E0 Slot: 15
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 16
	public virtual object get_SyncRoot() { }

	[MonoTODO("may not be required")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 10
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[ComVisible(False)]
	// RVA: 0x15D5630 Offset: 0x15D4830 VA: 0x1815D5630 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisible(False)]
	// RVA: 0x15D5840 Offset: 0x15D4A40 VA: 0x1815D5840 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15D5FD0 Offset: 0x15D51D0 VA: 0x1815D5FD0
	private static void .cctor() { }
}

// Namespace: System.Security
[MonoTODO("work in progress - encryption is missing")]
public sealed class SecureString : IDisposable // TypeDefIndex: 3527
{
	// Fields
	private int length; // 0x10
	private bool disposed; // 0x14
	private byte[] data; // 0x18

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x15D7440 Offset: 0x15D6640 VA: 0x1815D7440
	public void .ctor() { }

	[CLSCompliant(False)]
	// RVA: 0x15D72C0 Offset: 0x15D64C0 VA: 0x1815D72C0
	public void .ctor(char* value, int length) { }

	// RVA: 0x15D74A0 Offset: 0x15D66A0 VA: 0x1815D74A0
	public int get_Length() { }

	// RVA: 0x15D7090 Offset: 0x15D6290 VA: 0x1815D7090
	public SecureString Copy() { }

	// RVA: 0x15D71C0 Offset: 0x15D63C0 VA: 0x1815D71C0 Slot: 4
	public void Dispose() { }

	// RVA: 0x767080 Offset: 0x766280 VA: 0x180767080
	private void Encrypt() { }

	// RVA: 0x767080 Offset: 0x766280 VA: 0x180767080
	private void Decrypt() { }

	// RVA: 0x15D6EE0 Offset: 0x15D60E0 VA: 0x1815D6EE0
	private void Alloc(int length, bool realloc) { }

	// RVA: 0x15D7210 Offset: 0x15D6410 VA: 0x1815D7210
	internal byte[] GetBuffer() { }
}

// Namespace: System.Security
internal enum SecurityElementType // TypeDefIndex: 3528
{
	// Fields
	public int value__; // 0x0
	public const SecurityElementType Regular = 0;
	public const SecurityElementType Format = 1;
	public const SecurityElementType Comment = 2;
}

// Namespace: 
internal class SecurityElement.SecurityAttribute // TypeDefIndex: 3529
{
	// Fields
	private string _name; // 0x10
	private string _value; // 0x18

	// Properties
	public string Name { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x15D7510 Offset: 0x15D6710 VA: 0x1815D7510
	public void .ctor(string name, string value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Value() { }
}

// Namespace: System.Security
[ComVisible(True)]
[Serializable]
public sealed class SecurityElement // TypeDefIndex: 3530
{
	// Fields
	private string text; // 0x10
	private string tag; // 0x18
	private ArrayList attributes; // 0x20
	private ArrayList children; // 0x28
	private static readonly char[] invalid_tag_chars; // 0x0
	private static readonly char[] invalid_text_chars; // 0x8
	private static readonly char[] invalid_attr_name_chars; // 0x10
	private static readonly char[] invalid_attr_value_chars; // 0x18
	private static readonly char[] invalid_chars; // 0x20

	// Properties
	public Hashtable Attributes { get; }
	public ArrayList Children { get; }
	public string Tag { get; }
	public string Text { set; }
	internal string m_strText { set; }

	// Methods

	// RVA: 0x15D9800 Offset: 0x15D8A00 VA: 0x1815D9800
	public void .ctor(string tag) { }

	// RVA: 0x15D9810 Offset: 0x15D8A10 VA: 0x1815D9810
	public void .ctor(string tag, string text) { }

	// RVA: 0x15D9AC0 Offset: 0x15D8CC0 VA: 0x1815D9AC0
	public Hashtable get_Attributes() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public ArrayList get_Children() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Tag() { }

	// RVA: 0x15D9D60 Offset: 0x15D8F60 VA: 0x1815D9D60
	public void set_Text(string value) { }

	// RVA: 0x15D81A0 Offset: 0x15D73A0 VA: 0x1815D81A0
	public void AddAttribute(string name, string value) { }

	// RVA: 0x15D8390 Offset: 0x15D7590 VA: 0x1815D8390
	public void AddChild(SecurityElement child) { }

	// RVA: 0x15D8470 Offset: 0x15D7670 VA: 0x1815D8470
	public string Attribute(string name) { }

	// RVA: 0x15D84F0 Offset: 0x15D76F0 VA: 0x1815D84F0
	public static string Escape(string str) { }

	// RVA: 0x15D94D0 Offset: 0x15D86D0 VA: 0x1815D94D0
	private static string Unescape(string str) { }

	// RVA: 0x15D88F0 Offset: 0x15D7AF0 VA: 0x1815D88F0
	public static bool IsValidAttributeName(string name) { }

	// RVA: 0x15D8970 Offset: 0x15D7B70 VA: 0x1815D8970
	public static bool IsValidAttributeValue(string value) { }

	// RVA: 0x15D89F0 Offset: 0x15D7BF0 VA: 0x1815D89F0
	public static bool IsValidTag(string tag) { }

	// RVA: 0x15D8A70 Offset: 0x15D7C70 VA: 0x1815D8A70
	public static bool IsValidText(string text) { }

	// RVA: 0x15D8AF0 Offset: 0x15D7CF0 VA: 0x1815D8AF0
	public SecurityElement SearchForChildByTag(string tag) { }

	// RVA: 0x15D8E50 Offset: 0x15D8050 VA: 0x1815D8E50 Slot: 3
	public override string ToString() { }

	// RVA: 0x15D8EE0 Offset: 0x15D80E0 VA: 0x1815D8EE0
	private void ToXml(ref StringBuilder s, int level) { }

	// RVA: 0x15D8710 Offset: 0x15D7910 VA: 0x1815D8710
	internal SecurityElement.SecurityAttribute GetAttribute(string name) { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void set_m_strText(string value) { }

	// RVA: 0x15D8C50 Offset: 0x15D7E50 VA: 0x1815D8C50
	internal string SearchForTextOfLocalName(string strLocalName) { }

	// RVA: 0x15D9660 Offset: 0x15D8860 VA: 0x1815D9660
	private static void .cctor() { }
}

// Namespace: System.Security
[ComVisible(True)]
[Serializable]
public class SecurityException : SystemException // TypeDefIndex: 3531
{
	// Fields
	private string permissionState; // 0x90

	// Methods

	// RVA: 0x15D9F80 Offset: 0x15D9180 VA: 0x1815D9F80
	public void .ctor() { }

	// RVA: 0x15D9F40 Offset: 0x15D9140 VA: 0x1815D9F40
	public void .ctor(string message) { }

	// RVA: 0x15D9FD0 Offset: 0x15D91D0 VA: 0x1815D9FD0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15D9F60 Offset: 0x15D9160 VA: 0x1815D9F60
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x15D9EA0 Offset: 0x15D90A0 VA: 0x1815D9EA0 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15D9F30 Offset: 0x15D9130 VA: 0x1815D9F30 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Security
[ComVisible(True)]
public static class SecurityManager // TypeDefIndex: 3532
{
	// Properties
	[Obsolete("The security manager cannot be turned off on MS runtime")]
	public static bool SecurityEnabled { get; }

	// Methods

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	public static bool get_SecurityEnabled() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal static void EnsureElevatedPermissions() { }
}

// Namespace: System.Security.Util
internal sealed class Parser // TypeDefIndex: 3533
{
	// Fields
	private SecurityDocument _doc; // 0x10
	private Tokenizer _t; // 0x18

	// Methods

	// RVA: 0x15D4BF0 Offset: 0x15D3DF0 VA: 0x1815D4BF0
	internal SecurityElement GetTopElement() { }

	// RVA: 0x15D43D0 Offset: 0x15D35D0 VA: 0x1815D43D0
	private void GetRequiredSizes(TokenizerStream stream, ref int index) { }

	// RVA: 0x15D41B0 Offset: 0x15D33B0 VA: 0x1815D41B0
	private int DetermineFormat(TokenizerStream stream) { }

	// RVA: 0x15D4C20 Offset: 0x15D3E20 VA: 0x1815D4C20
	private void ParseContents() { }

	// RVA: 0x15D51B0 Offset: 0x15D43B0 VA: 0x1815D51B0
	private void .ctor(Tokenizer t) { }

	// RVA: 0x15D50D0 Offset: 0x15D42D0 VA: 0x1815D50D0
	internal void .ctor(string input) { }
}

// Namespace: 
private enum Tokenizer.TokenSource // TypeDefIndex: 3534
{
	// Fields
	public int value__; // 0x0
	public const Tokenizer.TokenSource UnicodeByteArray = 0;
	public const Tokenizer.TokenSource UTF8ByteArray = 1;
	public const Tokenizer.TokenSource ASCIIByteArray = 2;
	public const Tokenizer.TokenSource CharArray = 3;
	public const Tokenizer.TokenSource String = 4;
	public const Tokenizer.TokenSource NestedStrings = 5;
	public const Tokenizer.TokenSource Other = 6;
}

// Namespace: 
[Serializable]
internal sealed class Tokenizer.StringMaker // TypeDefIndex: 3535
{
	// Fields
	private string[] aStrings; // 0x10
	private uint cStringsMax; // 0x18
	private uint cStringsUsed; // 0x1C
	public StringBuilder _outStringBuilder; // 0x20
	public char[] _outChars; // 0x28
	public int _outIndex; // 0x30

	// Methods

	// RVA: 0x15DA260 Offset: 0x15D9460 VA: 0x1815DA260
	private static uint HashString(string str) { }

	// RVA: 0x15DA200 Offset: 0x15D9400 VA: 0x1815DA200
	private static uint HashCharArray(char[] a, int l) { }

	// RVA: 0x15DA5B0 Offset: 0x15D97B0 VA: 0x1815DA5B0
	public void .ctor() { }

	// RVA: 0x15DA170 Offset: 0x15D9370 VA: 0x1815DA170
	private bool CompareStringAndChars(string str, char[] a, int l) { }

	// RVA: 0x15DA2E0 Offset: 0x15D94E0 VA: 0x1815DA2E0
	public string MakeString() { }
}

// Namespace: 
internal interface Tokenizer.ITokenReader // TypeDefIndex: 3536
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int Read();
}

// Namespace: 
internal class Tokenizer.StreamTokenReader : Tokenizer.ITokenReader // TypeDefIndex: 3537
{
	// Fields
	internal StreamReader _in; // 0x10
	internal int _numCharRead; // 0x18

	// Properties
	internal int NumCharEncountered { get; }

	// Methods

	// RVA: 0x15DA140 Offset: 0x15D9340 VA: 0x1815DA140
	internal void .ctor(StreamReader input) { }

	// RVA: 0x15DA100 Offset: 0x15D9300 VA: 0x1815DA100 Slot: 5
	public virtual int Read() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	internal int get_NumCharEncountered() { }
}

// Namespace: System.Security.Util
internal sealed class Tokenizer // TypeDefIndex: 3538
{
	// Fields
	public int LineNo; // 0x10
	private int _inProcessingTag; // 0x14
	private byte[] _inBytes; // 0x18
	private char[] _inChars; // 0x20
	private string _inString; // 0x28
	private int _inIndex; // 0x30
	private int _inSize; // 0x34
	private int _inSavedCharacter; // 0x38
	private Tokenizer.TokenSource _inTokenSource; // 0x3C
	private Tokenizer.ITokenReader _inTokenReader; // 0x40
	private Tokenizer.StringMaker _maker; // 0x48
	private string[] _searchStrings; // 0x50
	private string[] _replaceStrings; // 0x58
	private int _inNestedIndex; // 0x60
	private int _inNestedSize; // 0x64
	private string _inNestedString; // 0x68

	// Methods

	// RVA: 0x15DAC90 Offset: 0x15D9E90 VA: 0x1815DAC90
	internal void BasicInitialization() { }

	// RVA: 0x15DB9A0 Offset: 0x15DABA0 VA: 0x1815DB9A0
	public void Recycle() { }

	// RVA: 0x15DB9F0 Offset: 0x15DABF0 VA: 0x1815DB9F0
	internal void .ctor(string input) { }

	// RVA: 0x15DAD00 Offset: 0x15D9F00 VA: 0x1815DAD00
	internal void ChangeFormat(Encoding encoding) { }

	// RVA: 0x15DAFB0 Offset: 0x15DA1B0 VA: 0x1815DAFB0
	internal void GetTokens(TokenizerStream stream, int maxNum, bool endAfterKet) { }

	// RVA: 0x15DAF90 Offset: 0x15DA190 VA: 0x1815DAF90
	private string GetStringToken() { }
}

// Namespace: System.Security.Util
internal sealed class TokenizerShortBlock // TypeDefIndex: 3539
{
	// Fields
	internal short[] m_block; // 0x10
	internal TokenizerShortBlock m_next; // 0x18

	// Methods

	// RVA: 0x15DA630 Offset: 0x15D9830 VA: 0x1815DA630
	public void .ctor() { }
}

// Namespace: System.Security.Util
internal sealed class TokenizerStringBlock // TypeDefIndex: 3540
{
	// Fields
	internal string[] m_block; // 0x10
	internal TokenizerStringBlock m_next; // 0x18

	// Methods

	// RVA: 0x15DAC40 Offset: 0x15D9E40 VA: 0x1815DAC40
	public void .ctor() { }
}

// Namespace: System.Security.Util
internal sealed class TokenizerStream // TypeDefIndex: 3541
{
	// Fields
	private int m_countTokens; // 0x10
	private TokenizerShortBlock m_headTokens; // 0x18
	private TokenizerShortBlock m_lastTokens; // 0x20
	private TokenizerShortBlock m_currentTokens; // 0x28
	private int m_indexTokens; // 0x30
	private TokenizerStringBlock m_headStrings; // 0x38
	private TokenizerStringBlock m_currentStrings; // 0x40
	private int m_indexStrings; // 0x48

	// Methods

	// RVA: 0x15DAB30 Offset: 0x15D9D30 VA: 0x1815DAB30
	internal void .ctor() { }

	// RVA: 0x15DA790 Offset: 0x15D9990 VA: 0x1815DA790
	internal void AddToken(short token) { }

	// RVA: 0x15DA680 Offset: 0x15D9880 VA: 0x1815DA680
	internal void AddString(string str) { }

	// RVA: 0x15DAA10 Offset: 0x15D9C10 VA: 0x1815DAA10
	internal void Reset() { }

	// RVA: 0x15DA8A0 Offset: 0x15D9AA0 VA: 0x1815DA8A0
	internal short GetNextFullToken() { }

	// RVA: 0x15DA990 Offset: 0x15D9B90 VA: 0x1815DA990
	internal short GetNextToken() { }

	// RVA: 0x15DA920 Offset: 0x15D9B20 VA: 0x1815DA920
	internal string GetNextString() { }

	// RVA: 0x15DAAC0 Offset: 0x15D9CC0 VA: 0x1815DAAC0
	internal void ThrowAwayNextString() { }

	// RVA: 0x15DAA30 Offset: 0x15D9C30 VA: 0x1815DAA30
	internal void TagLastToken(short tag) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	internal int GetTokenCount() { }

	// RVA: 0x15DA9B0 Offset: 0x15D9BB0 VA: 0x1815DA9B0
	internal void GoToPosition(int position) { }
}

// Namespace: 
private class Evidence.EvidenceEnumerator : IEnumerator // TypeDefIndex: 3542
{
	// Fields
	private IEnumerator currentEnum; // 0x10
	private IEnumerator hostEnum; // 0x18
	private IEnumerator assemblyEnum; // 0x20

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x15D0CF0 Offset: 0x15CFEF0 VA: 0x1815D0CF0
	public void .ctor(IEnumerator hostenum, IEnumerator assemblyenum) { }

	// RVA: 0x15D0BE0 Offset: 0x15CFDE0 VA: 0x1815D0BE0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x15D0C70 Offset: 0x15CFE70 VA: 0x1815D0C70 Slot: 6
	public void Reset() { }

	// RVA: 0x15D0D30 Offset: 0x15CFF30 VA: 0x1815D0D30 Slot: 5
	public object get_Current() { }
}

// Namespace: System.Security.Policy
[ComVisible(True)]
[MonoTODO("Serialization format not compatible with .NET")]
[Serializable]
public sealed class Evidence : ICollection, IEnumerable // TypeDefIndex: 3543
{
	// Fields
	private bool _locked; // 0x10
	private ArrayList hostEvidenceList; // 0x18
	private ArrayList assemblyEvidenceList; // 0x20

	// Properties
	[Obsolete]
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x15D0F00 Offset: 0x15D0100 VA: 0x1815D0F00 Slot: 5
	public int get_Count() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 6
	public object get_SyncRoot() { }

	[Obsolete]
	// RVA: 0x15D0D80 Offset: 0x15CFF80 VA: 0x1815D0D80 Slot: 4
	public void CopyTo(Array array, int index) { }

	[Obsolete]
	// RVA: 0x15D0E50 Offset: 0x15D0050 VA: 0x1815D0E50 Slot: 8
	public IEnumerator GetEnumerator() { }
}

// Namespace: System.Security.Permissions
public interface IUnrestrictedPermission // TypeDefIndex: 3544
{}

// Namespace: System.Security.Permissions
public enum PermissionState // TypeDefIndex: 3545
{
	// Fields
	public int value__; // 0x0
	public const PermissionState None = 0;
	public const PermissionState Unrestricted = 1;
}

// Namespace: System.Security.Permissions
[Flags]
public enum ReflectionPermissionFlag // TypeDefIndex: 3546
{
	// Fields
	public int value__; // 0x0
	[Obsolete("This permission has been deprecated. Use PermissionState.Unrestricted to get full access.")]
	public const ReflectionPermissionFlag AllFlags = 7;
	public const ReflectionPermissionFlag MemberAccess = 2;
	public const ReflectionPermissionFlag NoFlags = 0;
	[Obsolete("This permission is no longer used by the CLR.")]
	public const ReflectionPermissionFlag ReflectionEmit = 4;
	public const ReflectionPermissionFlag RestrictedMemberAccess = 8;
	[Obsolete("This API has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
	public const ReflectionPermissionFlag TypeInformation = 1;
}

// Namespace: System.Security.Permissions
[Obsolete("CAS support is not available with Silverlight applications.")]
[Usage(109, AllowMultiple = True, Inherited = False)]
[ComVisible(True)]
[Serializable]
public abstract class CodeAccessSecurityAttribute : SecurityAttribute // TypeDefIndex: 3547
{
	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	protected void .ctor(SecurityAction action) { }
}

// Namespace: System.Security.Permissions
[ComVisible(True)]
[Serializable]
public sealed class ReflectionPermission : CodeAccessPermission, IUnrestrictedPermission // TypeDefIndex: 3548
{
	// Fields
	private ReflectionPermissionFlag flags; // 0x10

	// Properties
	public ReflectionPermissionFlag Flags { get; set; }

	// Methods

	// RVA: 0x15D6DE0 Offset: 0x15D5FE0 VA: 0x1815D6DE0
	public void .ctor(PermissionState state) { }

	// RVA: 0x15D6DB0 Offset: 0x15D5FB0 VA: 0x1815D6DB0
	public void .ctor(ReflectionPermissionFlag flag) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public ReflectionPermissionFlag get_Flags() { }

	// RVA: 0x15D6E20 Offset: 0x15D6020 VA: 0x1815D6E20
	public void set_Flags(ReflectionPermissionFlag value) { }

	// RVA: 0x15D63B0 Offset: 0x15D55B0 VA: 0x1815D63B0 Slot: 7
	public override IPermission Copy() { }

	// RVA: 0x15D6410 Offset: 0x15D5610 VA: 0x1815D6410 Slot: 9
	public override void FromXml(SecurityElement esd) { }

	// RVA: 0x15D66A0 Offset: 0x15D58A0 VA: 0x1815D66A0 Slot: 10
	public override IPermission Intersect(IPermission target) { }

	// RVA: 0x15D6820 Offset: 0x15D5A20 VA: 0x1815D6820 Slot: 11
	public override bool IsSubsetOf(IPermission target) { }

	// RVA: 0x15D6910 Offset: 0x15D5B10 VA: 0x1815D6910 Slot: 14
	public bool IsUnrestricted() { }

	// RVA: 0x15D6920 Offset: 0x15D5B20 VA: 0x1815D6920 Slot: 12
	public override SecurityElement ToXml() { }

	// RVA: 0x15D6C30 Offset: 0x15D5E30 VA: 0x1815D6C30 Slot: 13
	public override IPermission Union(IPermission other) { }

	// RVA: 0x15D6310 Offset: 0x15D5510 VA: 0x1815D6310
	private ReflectionPermission Cast(IPermission target) { }
}

// Namespace: System.Security.Permissions
[ComVisible(True)]
[Obsolete("CAS support is not available with Silverlight applications.")]
[Serializable]
public enum SecurityAction // TypeDefIndex: 3549
{
	// Fields
	public int value__; // 0x0
	public const SecurityAction Demand = 2;
	public const SecurityAction Assert = 3;
	[Obsolete("This requests should not be used")]
	public const SecurityAction Deny = 4;
	public const SecurityAction PermitOnly = 5;
	public const SecurityAction LinkDemand = 6;
	public const SecurityAction InheritanceDemand = 7;
	[Obsolete("This requests should not be used")]
	public const SecurityAction RequestMinimum = 8;
	[Obsolete("This requests should not be used")]
	public const SecurityAction RequestOptional = 9;
	[Obsolete("This requests should not be used")]
	public const SecurityAction RequestRefuse = 10;
}

// Namespace: System.Security.Permissions
[Usage(109, AllowMultiple = True, Inherited = False)]
[Obsolete("CAS support is not available with Silverlight applications.")]
[ComVisible(True)]
[Serializable]
public abstract class SecurityAttribute : Attribute // TypeDefIndex: 3550
{
	// Fields
	private SecurityAction m_Action; // 0x10
	private bool m_Unrestricted; // 0x14

	// Properties
	public bool Unrestricted { get; }
	public SecurityAction Action { set; }

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	protected void .ctor(SecurityAction action) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IPermission CreatePermission();

	// RVA: 0x41AC30 Offset: 0x419E30 VA: 0x18041AC30
	public bool get_Unrestricted() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Action(SecurityAction value) { }
}

// Namespace: 
[CompilerGenerated]
private struct CryptoStream.<ReadAsyncInternal>d__37 : IAsyncStateMachine // TypeDefIndex: 3551
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public CryptoStream <>4__this; // 0x20
	public byte[] buffer; // 0x28
	public int offset; // 0x30
	public int count; // 0x34
	public CancellationToken cancellationToken; // 0x38
	private SemaphoreSlim <semaphore>5__2; // 0x40
	private ForceAsyncAwaiter <>u__1; // 0x48
	private TaskAwaiter<int> <>u__2; // 0x50

	// Methods

	// RVA: 0x15EECB0 Offset: 0x15EDEB0 VA: 0x1815EECB0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x15EF140 Offset: 0x15EE340 VA: 0x1815EF140 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct CryptoStream.<ReadAsyncCore>d__42 : IAsyncStateMachine // TypeDefIndex: 3552
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public int count; // 0x20
	public int offset; // 0x24
	public CryptoStream <>4__this; // 0x28
	public byte[] buffer; // 0x30
	public bool useAsync; // 0x38
	public CancellationToken cancellationToken; // 0x40
	private int <bytesToDeliver>5__2; // 0x48
	private int <currentOutputIndex>5__3; // 0x4C
	private int <numWholeBlocksInBytes>5__4; // 0x50
	private byte[] <tempInputBuffer>5__5; // 0x58
	private byte[] <tempOutputBuffer>5__6; // 0x60
	private ValueTaskAwaiter<int> <>u__1; // 0x68

	// Methods

	// RVA: 0x15EDD30 Offset: 0x15ECF30 VA: 0x1815EDD30 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x15EEC40 Offset: 0x15EDE40 VA: 0x1815EEC40 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct CryptoStream.<WriteAsyncInternal>d__46 : IAsyncStateMachine // TypeDefIndex: 3553
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public CryptoStream <>4__this; // 0x20
	public byte[] buffer; // 0x28
	public int offset; // 0x30
	public int count; // 0x34
	public CancellationToken cancellationToken; // 0x38
	private SemaphoreSlim <semaphore>5__2; // 0x40
	private ForceAsyncAwaiter <>u__1; // 0x48
	private TaskAwaiter <>u__2; // 0x50

	// Methods

	// RVA: 0x15F0030 Offset: 0x15EF230 VA: 0x1815F0030 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x15F0450 Offset: 0x15EF650 VA: 0x1815F0450 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct CryptoStream.<WriteAsyncCore>d__49 : IAsyncStateMachine // TypeDefIndex: 3554
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public int count; // 0x20
	public int offset; // 0x24
	public CryptoStream <>4__this; // 0x28
	public byte[] buffer; // 0x30
	public bool useAsync; // 0x38
	public CancellationToken cancellationToken; // 0x40
	private int <bytesToWrite>5__2; // 0x48
	private int <currentInputIndex>5__3; // 0x4C
	private int <numOutputBytes>5__4; // 0x50
	private ValueTaskAwaiter <>u__1; // 0x58
	private int <numWholeBlocksInBytes>5__5; // 0x68
	private byte[] <tempOutputBuffer>5__6; // 0x70

	// Methods

	// RVA: 0x15EF260 Offset: 0x15EE460 VA: 0x1815EF260 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x15EFFD0 Offset: 0x15EF1D0 VA: 0x1815EFFD0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class CryptoStream.<>c // TypeDefIndex: 3555
{
	// Fields
	public static readonly CryptoStream.<>c <>9; // 0x0
	public static Func<SemaphoreSlim> <>9__54_0; // 0x8

	// Methods

	// RVA: 0x15EF200 Offset: 0x15EE400 VA: 0x1815EF200
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x15EF1B0 Offset: 0x15EE3B0 VA: 0x1815EF1B0
	internal SemaphoreSlim <get_AsyncActiveSemaphore>b__54_0() { }
}

// Namespace: System.Security.Cryptography
public class CryptoStream : Stream, IDisposable // TypeDefIndex: 3556
{
	// Fields
	private readonly Stream _stream; // 0x28
	private readonly ICryptoTransform _transform; // 0x30
	private readonly CryptoStreamMode _transformMode; // 0x38
	private byte[] _inputBuffer; // 0x40
	private int _inputBufferIndex; // 0x48
	private int _inputBlockSize; // 0x4C
	private byte[] _outputBuffer; // 0x50
	private int _outputBufferIndex; // 0x58
	private int _outputBlockSize; // 0x5C
	private bool _canRead; // 0x60
	private bool _canWrite; // 0x61
	private bool _finalBlockTransformed; // 0x62
	private SemaphoreSlim _lazyAsyncActiveSemaphore; // 0x68
	private readonly bool _leaveOpen; // 0x70

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public bool HasFlushedFinalBlock { get; }
	private SemaphoreSlim AsyncActiveSemaphore { get; }

	// Methods

	// RVA: 0x15CB080 Offset: 0x15CA280 VA: 0x1815CB080
	public void .ctor(Stream stream, ICryptoTransform transform, CryptoStreamMode mode) { }

	// RVA: 0x15CADC0 Offset: 0x15C9FC0 VA: 0x1815CADC0
	public void .ctor(Stream stream, ICryptoTransform transform, CryptoStreamMode mode, bool leaveOpen) { }

	// RVA: 0x4EE290 Offset: 0x4ED490 VA: 0x1804EE290 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0xE5B220 Offset: 0xE5A420 VA: 0x180E5B220 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x15CB1B0 Offset: 0x15CA3B0 VA: 0x1815CB1B0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x15CB200 Offset: 0x15CA400 VA: 0x1815CB200 Slot: 12
	public override long get_Position() { }

	// RVA: 0x15CB250 Offset: 0x15CA450 VA: 0x1815CB250 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x15CB1A0 Offset: 0x15CA3A0 VA: 0x1815CB1A0
	public bool get_HasFlushedFinalBlock() { }

	// RVA: 0x15C9F10 Offset: 0x15C9110 VA: 0x1815C9F10
	public void FlushFinalBlock() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 22
	public override void Flush() { }

	// RVA: 0x15C9D90 Offset: 0x15C8F90 VA: 0x1815C9D90 Slot: 23
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x15CA810 Offset: 0x15C9A10 VA: 0x1815CA810 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x15CA860 Offset: 0x15C9A60 VA: 0x1815CA860 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x15CA4C0 Offset: 0x15C96C0 VA: 0x1815CA4C0 Slot: 26
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x15C97D0 Offset: 0x15C89D0 VA: 0x1815C97D0 Slot: 24
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x15C9D40 Offset: 0x15C8F40 VA: 0x1815C9D40 Slot: 25
	public override int EndRead(IAsyncResult asyncResult) { }

	[AsyncStateMachine(typeof(CryptoStream.<ReadAsyncInternal>d__37))]
	// RVA: 0x15CA3A0 Offset: 0x15C95A0 VA: 0x1815CA3A0
	private Task<int> ReadAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x15CA600 Offset: 0x15C9800 VA: 0x1815CA600 Slot: 36
	public override int ReadByte() { }

	// RVA: 0x15CAC20 Offset: 0x15C9E20 VA: 0x1815CAC20 Slot: 39
	public override void WriteByte(byte value) { }

	// RVA: 0x15CA680 Offset: 0x15C9880 VA: 0x1815CA680 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x15C9930 Offset: 0x15C8B30 VA: 0x1815C9930
	private void CheckReadArguments(byte[] buffer, int offset, int count) { }

	[AsyncStateMachine(typeof(CryptoStream.<ReadAsyncCore>d__42))]
	// RVA: 0x15CA250 Offset: 0x15C9450 VA: 0x1815CA250
	private Task<int> ReadAsyncCore(byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync) { }

	// RVA: 0x15CAAF0 Offset: 0x15C9CF0 VA: 0x1815CAAF0 Slot: 30
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x15C9880 Offset: 0x15C8A80 VA: 0x1815C9880 Slot: 28
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x15C9D80 Offset: 0x15C8F80 VA: 0x1815C9D80 Slot: 29
	public override void EndWrite(IAsyncResult asyncResult) { }

	[AsyncStateMachine(typeof(CryptoStream.<WriteAsyncInternal>d__46))]
	// RVA: 0x15CA9E0 Offset: 0x15C9BE0 VA: 0x1815CA9E0
	private Task WriteAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x15CAC70 Offset: 0x15C9E70 VA: 0x1815CAC70 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x15C9AE0 Offset: 0x15C8CE0 VA: 0x1815C9AE0
	private void CheckWriteArguments(byte[] buffer, int offset, int count) { }

	[AsyncStateMachine(typeof(CryptoStream.<WriteAsyncCore>d__49))]
	// RVA: 0x15CA8B0 Offset: 0x15C9AB0 VA: 0x1815CA8B0
	private Task WriteAsyncCore(byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync) { }

	// RVA: 0x15C9C90 Offset: 0x15C8E90 VA: 0x1815C9C90
	public void Clear() { }

	// RVA: 0x15C9CB0 Offset: 0x15C8EB0 VA: 0x1815C9CB0 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x15CA1B0 Offset: 0x15C93B0 VA: 0x1815CA1B0
	private void InitializeBuffer() { }

	// RVA: 0x15CB0A0 Offset: 0x15CA2A0 VA: 0x1815CB0A0
	private SemaphoreSlim get_AsyncActiveSemaphore() { }
}

// Namespace: System.Security.Cryptography
public enum CryptoStreamMode // TypeDefIndex: 3557
{
	// Fields
	public int value__; // 0x0
	public const CryptoStreamMode Read = 0;
	public const CryptoStreamMode Write = 1;
}

// Namespace: System.Security.Cryptography
public static class CryptographicOperations // TypeDefIndex: 3558
{
	// Methods

	// RVA: 0x15E14C0 Offset: 0x15E06C0 VA: 0x1815E14C0
	public static void ZeroMemory(Span<byte> buffer) { }
}

// Namespace: System.Security.Cryptography
public abstract class HashAlgorithm : IDisposable, ICryptoTransform // TypeDefIndex: 3559
{
	// Fields
	private bool _disposed; // 0x10
	protected int HashSizeValue; // 0x14
	protected internal byte[] HashValue; // 0x18
	protected int State; // 0x20

	// Properties
	public virtual int HashSize { get; }
	public virtual byte[] Hash { get; }
	public virtual int InputBlockSize { get; }
	public virtual int OutputBlockSize { get; }
	public virtual bool CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x15E5590 Offset: 0x15E4790 VA: 0x1815E5590
	public static HashAlgorithm Create(string hashName) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 10
	public virtual int get_HashSize() { }

	// RVA: 0x15E5A60 Offset: 0x15E4C60 VA: 0x1815E5A60 Slot: 11
	public virtual byte[] get_Hash() { }

	// RVA: 0x15E52D0 Offset: 0x15E44D0 VA: 0x1815E52D0
	public byte[] ComputeHash(byte[] buffer) { }

	// RVA: 0x15E53A0 Offset: 0x15E45A0 VA: 0x1815E53A0
	public byte[] ComputeHash(byte[] buffer, int offset, int count) { }

	// RVA: 0x15E51E0 Offset: 0x15E43E0 VA: 0x1815E51E0
	private byte[] CaptureHashCodeAndReinitialize() { }

	// RVA: 0x15E5630 Offset: 0x15E4830 VA: 0x1815E5630 Slot: 4
	public void Dispose() { }

	// RVA: 0x15E5290 Offset: 0x15E4490 VA: 0x1815E5290
	public void Clear() { }

	// RVA: 0x15E5620 Offset: 0x15E4820 VA: 0x1815E5620 Slot: 12
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 13
	public virtual int get_InputBlockSize() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 14
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 15
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x15E56A0 Offset: 0x15E48A0 VA: 0x1815E56A0 Slot: 8
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x15E5750 Offset: 0x15E4950 VA: 0x1815E5750 Slot: 9
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x15E58A0 Offset: 0x15E4AA0 VA: 0x1815E58A0
	private void ValidateTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void HashCore(byte[] array, int ibStart, int cbSize);

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract byte[] HashFinal();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void Initialize();
}

// Namespace: System.Security.Cryptography
[IsReadOnly]
public struct HashAlgorithmName : IEquatable<HashAlgorithmName> // TypeDefIndex: 3560
{
	// Fields
	private readonly string _name; // 0x0

	// Methods

	// RVA: 0x15E5190 Offset: 0x15E4390 VA: 0x1815E5190 Slot: 3
	public override string ToString() { }

	// RVA: 0x15E50D0 Offset: 0x15E42D0 VA: 0x1815E50D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15E5160 Offset: 0x15E4360 VA: 0x1815E5160 Slot: 4
	public bool Equals(HashAlgorithmName other) { }

	// RVA: 0x15E5170 Offset: 0x15E4370 VA: 0x1815E5170 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Security.Cryptography
public sealed class RSASignaturePadding : IEquatable<RSASignaturePadding> // TypeDefIndex: 3561
{
	// Fields
	private static readonly RSASignaturePadding s_pkcs1; // 0x0
	private static readonly RSASignaturePadding s_pss; // 0x8
	private readonly RSASignaturePaddingMode _mode; // 0x10

	// Methods

	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	private void .ctor(RSASignaturePaddingMode mode) { }

	// RVA: 0x15E93D0 Offset: 0x15E85D0 VA: 0x1815E93D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15E92C0 Offset: 0x15E84C0 VA: 0x1815E92C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15E9320 Offset: 0x15E8520 VA: 0x1815E9320 Slot: 4
	public bool Equals(RSASignaturePadding other) { }

	// RVA: 0x15E94D0 Offset: 0x15E86D0 VA: 0x1815E94D0
	public static bool op_Equality(RSASignaturePadding left, RSASignaturePadding right) { }

	// RVA: 0x15E94F0 Offset: 0x15E86F0 VA: 0x1815E94F0
	public static bool op_Inequality(RSASignaturePadding left, RSASignaturePadding right) { }

	// RVA: 0x15E93E0 Offset: 0x15E85E0 VA: 0x1815E93E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x15E9440 Offset: 0x15E8640 VA: 0x1815E9440
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
public enum RSASignaturePaddingMode // TypeDefIndex: 3562
{
	// Fields
	public int value__; // 0x0
	public const RSASignaturePaddingMode Pkcs1 = 0;
	public const RSASignaturePaddingMode Pss = 1;
}

// Namespace: System.Security.Cryptography
[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
public abstract class Aes : SymmetricAlgorithm // TypeDefIndex: 3563
{
	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Methods

	// RVA: 0x15E1050 Offset: 0x15E0250 VA: 0x1815E1050
	protected void .ctor() { }

	// RVA: 0x15E0E00 Offset: 0x15E0000 VA: 0x1815E0E00
	public static Aes Create() { }

	// RVA: 0x15E0D10 Offset: 0x15DFF10 VA: 0x1815E0D10
	public static Aes Create(string algorithmName) { }

	// RVA: 0x15E0F30 Offset: 0x15E0130 VA: 0x1815E0F30
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class AsymmetricAlgorithm : IDisposable // TypeDefIndex: 3564
{
	// Fields
	protected int KeySizeValue; // 0x10
	protected KeySizes[] LegalKeySizesValue; // 0x18

	// Properties
	public virtual int KeySize { get; set; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x15E10F0 Offset: 0x15E02F0 VA: 0x1815E10F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x15E10F0 Offset: 0x15E02F0 VA: 0x1815E10F0
	public void Clear() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 6
	public virtual int get_KeySize() { }

	// RVA: 0x15E11E0 Offset: 0x15E03E0 VA: 0x1815E11E0 Slot: 7
	public virtual void set_KeySize(int value) { }

	// RVA: 0x15E1160 Offset: 0x15E0360 VA: 0x1815E1160 Slot: 8
	public virtual void FromXmlString(string xmlString) { }

	// RVA: 0x15E11A0 Offset: 0x15E03A0 VA: 0x1815E11A0 Slot: 9
	public virtual string ToXmlString(bool includePrivateParameters) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class AsymmetricSignatureDeformatter // TypeDefIndex: 3565
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetKey(AsymmetricAlgorithm key);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetHashAlgorithm(string strName);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class AsymmetricSignatureFormatter // TypeDefIndex: 3566
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
[Serializable]
public enum CipherMode // TypeDefIndex: 3567
{
	// Fields
	public int value__; // 0x0
	public const CipherMode CBC = 1;
	public const CipherMode ECB = 2;
	public const CipherMode OFB = 3;
	public const CipherMode CFB = 4;
	public const CipherMode CTS = 5;
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
[Serializable]
public enum PaddingMode // TypeDefIndex: 3568
{
	// Fields
	public int value__; // 0x0
	public const PaddingMode None = 1;
	public const PaddingMode PKCS7 = 2;
	public const PaddingMode Zeros = 3;
	public const PaddingMode ANSIX923 = 4;
	public const PaddingMode ISO10126 = 5;
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class KeySizes // TypeDefIndex: 3569
{
	// Fields
	private int m_minSize; // 0x10
	private int m_maxSize; // 0x14
	private int m_skipSize; // 0x18

	// Properties
	public int MinSize { get; }
	public int MaxSize { get; }
	public int SkipSize { get; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_MinSize() { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_MaxSize() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_SkipSize() { }

	// RVA: 0x15E5C40 Offset: 0x15E4E40 VA: 0x1815E5C40
	public void .ctor(int minSize, int maxSize, int skipSize) { }

	// RVA: 0x15E5C10 Offset: 0x15E4E10 VA: 0x1815E5C10
	internal bool IsLegal(int keySize) { }

	// RVA: 0x15E5B80 Offset: 0x15E4D80 VA: 0x1815E5B80
	internal static bool IsLegalKeySize(KeySizes[] legalKeys, int size) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
[Serializable]
public class CryptographicException : SystemException // TypeDefIndex: 3570
{
	// Methods

	// RVA: 0x15E1430 Offset: 0x15E0630 VA: 0x1815E1430
	public void .ctor() { }

	// RVA: 0x15E1490 Offset: 0x15E0690 VA: 0x1815E1490
	public void .ctor(string message) { }

	// RVA: 0x15E1370 Offset: 0x15E0570 VA: 0x1815E1370
	public void .ctor(string format, string insert) { }

	// RVA: 0x15E1400 Offset: 0x15E0600 VA: 0x1815E1400
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x15E1310 Offset: 0x15E0510 VA: 0x1815E1310
	public void .ctor(int hr) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
[Serializable]
public class CryptographicUnexpectedOperationException : CryptographicException // TypeDefIndex: 3571
{
	// Methods

	// RVA: 0x15E1510 Offset: 0x15E0710 VA: 0x1815E1510
	public void .ctor() { }

	// RVA: 0x15E1580 Offset: 0x15E0780 VA: 0x1815E1580
	public void .ctor(string message) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Security.Cryptography
[Flags]
[ComVisible(True)]
[Serializable]
public enum CspProviderFlags // TypeDefIndex: 3572
{
	// Fields
	public int value__; // 0x0
	public const CspProviderFlags NoFlags = 0;
	public const CspProviderFlags UseMachineKeyStore = 1;
	public const CspProviderFlags UseDefaultKeyContainer = 2;
	public const CspProviderFlags UseNonExportableKey = 4;
	public const CspProviderFlags UseExistingKey = 8;
	public const CspProviderFlags UseArchivableKey = 16;
	public const CspProviderFlags UseUserProtectedKey = 32;
	public const CspProviderFlags NoPrompt = 64;
	public const CspProviderFlags CreateEphemeralKey = 128;
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class CspParameters // TypeDefIndex: 3573
{
	// Fields
	public int ProviderType; // 0x10
	public string ProviderName; // 0x18
	public string KeyContainerName; // 0x20
	public int KeyNumber; // 0x28
	private int m_flags; // 0x2C

	// Properties
	public CspProviderFlags Flags { get; set; }

	// Methods

	// RVA: 0x5012C0 Offset: 0x5004C0 VA: 0x1805012C0
	public CspProviderFlags get_Flags() { }

	// RVA: 0x15E17D0 Offset: 0x15E09D0 VA: 0x1815E17D0
	public void set_Flags(CspProviderFlags value) { }

	// RVA: 0x15E1600 Offset: 0x15E0800 VA: 0x1815E1600
	public void .ctor() { }

	// RVA: 0x15E15C0 Offset: 0x15E07C0 VA: 0x1815E15C0
	public void .ctor(int dwTypeIn) { }

	// RVA: 0x15E1770 Offset: 0x15E0970 VA: 0x1815E1770
	public void .ctor(int dwTypeIn, string strProviderNameIn, string strContainerNameIn) { }

	// RVA: 0x15E1640 Offset: 0x15E0840 VA: 0x1815E1640
	internal void .ctor(int providerType, string providerName, string keyContainerName, CspProviderFlags flags) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class DES : SymmetricAlgorithm // TypeDefIndex: 3574
{
	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x15E24B0 Offset: 0x15E16B0 VA: 0x1815E24B0
	protected void .ctor() { }

	// RVA: 0x15E2540 Offset: 0x15E1740 VA: 0x1815E2540 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x15E2640 Offset: 0x15E1840 VA: 0x1815E2640 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x15E1E90 Offset: 0x15E1090 VA: 0x1815E1E90
	public static DES Create() { }

	// RVA: 0x15E21C0 Offset: 0x15E13C0 VA: 0x1815E21C0
	public static bool IsWeakKey(byte[] rgbKey) { }

	// RVA: 0x15E2010 Offset: 0x15E1210 VA: 0x1815E2010
	public static bool IsSemiWeakKey(byte[] rgbKey) { }

	// RVA: 0x15E2000 Offset: 0x15E1200 VA: 0x1815E2000
	private static bool IsLegalKeySize(byte[] rgbKey) { }

	// RVA: 0x15E22E0 Offset: 0x15E14E0 VA: 0x1815E22E0
	private static ulong QuadWordFromBigEndian(byte[] block) { }

	// RVA: 0x15E2390 Offset: 0x15E1590 VA: 0x1815E2390
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class DESCryptoServiceProvider : DES // TypeDefIndex: 3575
{
	// Methods

	// RVA: 0x15E1D50 Offset: 0x15E0F50 VA: 0x1815E1D50
	public void .ctor() { }

	// RVA: 0x15E1A60 Offset: 0x15E0C60 VA: 0x1815E1A60 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x15E18C0 Offset: 0x15E0AC0 VA: 0x1815E18C0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x15E1C70 Offset: 0x15E0E70 VA: 0x1815E1C70 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x15E1C00 Offset: 0x15E0E00 VA: 0x1815E1C00 Slot: 25
	public override void GenerateIV() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
[Serializable]
public struct DSAParameters // TypeDefIndex: 3576
{
	// Fields
	public byte[] P; // 0x0
	public byte[] Q; // 0x8
	public byte[] G; // 0x10
	public byte[] Y; // 0x18
	public byte[] J; // 0x20
	public byte[] X; // 0x28
	public byte[] Seed; // 0x30
	public int Counter; // 0x38
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class DSA : AsymmetricAlgorithm // TypeDefIndex: 3577
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x15E2E60 Offset: 0x15E2060 VA: 0x1815E2E60
	public static DSA Create() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);

	// RVA: 0x15E2EB0 Offset: 0x15E20B0 VA: 0x1815E2EB0 Slot: 8
	public override void FromXmlString(string xmlString) { }

	// RVA: 0x15E3840 Offset: 0x15E2A40 VA: 0x1815E3840 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract DSAParameters ExportParameters(bool includePrivateParameters);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void ImportParameters(DSAParameters parameters);
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class DSASignatureDeformatter : AsymmetricSignatureDeformatter // TypeDefIndex: 3578
{
	// Fields
	private DSA _dsaKey; // 0x10
	private string _oid; // 0x18

	// Methods

	// RVA: 0x15E2D80 Offset: 0x15E1F80 VA: 0x1815E2D80
	public void .ctor() { }

	// RVA: 0x15E2C00 Offset: 0x15E1E00 VA: 0x1815E2C00
	public void .ctor(AsymmetricAlgorithm key) { }

	// RVA: 0x15E29A0 Offset: 0x15E1BA0 VA: 0x1815E29A0 Slot: 4
	public override void SetKey(AsymmetricAlgorithm key) { }

	// RVA: 0x15E28E0 Offset: 0x15E1AE0 VA: 0x1815E28E0 Slot: 5
	public override void SetHashAlgorithm(string strName) { }

	// RVA: 0x15E2AD0 Offset: 0x15E1CD0 VA: 0x1815E2AD0 Slot: 6
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class DSASignatureFormatter : AsymmetricSignatureFormatter // TypeDefIndex: 3579
{
	// Fields
	private string _oid; // 0x10

	// Methods

	// RVA: 0x15E2DF0 Offset: 0x15E1FF0 VA: 0x1815E2DF0
	public void .ctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class HMAC : KeyedHashAlgorithm // TypeDefIndex: 3580
{
	// Fields
	private int blockSizeValue; // 0x30
	internal string m_hashName; // 0x38
	internal HashAlgorithm m_hash1; // 0x40
	internal HashAlgorithm m_hash2; // 0x48
	private byte[] m_inner; // 0x50
	private byte[] m_outer; // 0x58
	private bool m_hashing; // 0x60

	// Properties
	protected int BlockSizeValue { get; set; }
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	protected int get_BlockSizeValue() { }

	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	protected void set_BlockSizeValue(int value) { }

	// RVA: 0x15E4E80 Offset: 0x15E4080 VA: 0x1815E4E80
	private void UpdateIOPadBuffers() { }

	// RVA: 0x15E4B90 Offset: 0x15E3D90 VA: 0x1815E4B90
	internal void InitializeKey(byte[] key) { }

	// RVA: 0x15E4FD0 Offset: 0x15E41D0 VA: 0x1815E4FD0 Slot: 19
	public override byte[] get_Key() { }

	// RVA: 0x15E5050 Offset: 0x15E4250 VA: 0x1815E5050 Slot: 20
	public override void set_Key(byte[] value) { }

	// RVA: 0x15E4680 Offset: 0x15E3880 VA: 0x1815E4680
	public static HMAC Create() { }

	// RVA: 0x15E4E20 Offset: 0x15E4020 VA: 0x1815E4E20 Slot: 18
	public override void Initialize() { }

	// RVA: 0x15E4850 Offset: 0x15E3A50 VA: 0x1815E4850 Slot: 16
	protected override void HashCore(byte[] rgb, int ib, int cb) { }

	// RVA: 0x15E4960 Offset: 0x15E3B60 VA: 0x1815E4960 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x15E4770 Offset: 0x15E3970 VA: 0x1815E4770 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x15E4FC0 Offset: 0x15E41C0 VA: 0x1815E4FC0
	protected void .ctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class HMACMD5 : HMAC // TypeDefIndex: 3581
{
	// Methods

	// RVA: 0x15E3D20 Offset: 0x15E2F20 VA: 0x1815E3D20
	public void .ctor() { }

	// RVA: 0x15E3C60 Offset: 0x15E2E60 VA: 0x1815E3C60
	public void .ctor(byte[] key) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class HMACRIPEMD160 : HMAC // TypeDefIndex: 3582
{
	// Methods

	// RVA: 0x15E3DF0 Offset: 0x15E2FF0 VA: 0x1815E3DF0
	public void .ctor() { }

	// RVA: 0x15E3EC0 Offset: 0x15E30C0 VA: 0x1815E3EC0
	public void .ctor(byte[] key) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class HMACSHA1 : HMAC // TypeDefIndex: 3583
{
	// Methods

	// RVA: 0x15E4040 Offset: 0x15E3240 VA: 0x1815E4040
	public void .ctor() { }

	// RVA: 0x15E3F80 Offset: 0x15E3180 VA: 0x1815E3F80
	public void .ctor(byte[] key) { }

	// RVA: 0x15E3F80 Offset: 0x15E3180 VA: 0x1815E3F80
	public void .ctor(byte[] key, bool useManagedSha1) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class HMACSHA256 : HMAC // TypeDefIndex: 3584
{
	// Methods

	// RVA: 0x15E4110 Offset: 0x15E3310 VA: 0x1815E4110
	public void .ctor() { }

	// RVA: 0x15E41E0 Offset: 0x15E33E0 VA: 0x1815E41E0
	public void .ctor(byte[] key) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class HMACSHA384 : HMAC // TypeDefIndex: 3585
{
	// Fields
	private bool m_useLegacyBlockSize; // 0x68

	// Properties
	private int BlockSize { get; }

	// Methods

	// RVA: 0x15E42A0 Offset: 0x15E34A0 VA: 0x1815E42A0
	public void .ctor() { }

	// RVA: 0x15E43A0 Offset: 0x15E35A0 VA: 0x1815E43A0
	public void .ctor(byte[] key) { }

	// RVA: 0x15E4480 Offset: 0x15E3680 VA: 0x1815E4480
	private int get_BlockSize() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class HMACSHA512 : HMAC // TypeDefIndex: 3586
{
	// Fields
	private bool m_useLegacyBlockSize; // 0x68

	// Properties
	private int BlockSize { get; }

	// Methods

	// RVA: 0x15E4580 Offset: 0x15E3780 VA: 0x1815E4580
	public void .ctor() { }

	// RVA: 0x15E44A0 Offset: 0x15E36A0 VA: 0x1815E44A0
	public void .ctor(byte[] key) { }

	// RVA: 0x15E4480 Offset: 0x15E3680 VA: 0x1815E4480
	private int get_BlockSize() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public interface ICryptoTransform : IDisposable // TypeDefIndex: 3587
{
	// Properties
	public abstract int InputBlockSize { get; }
	public abstract int OutputBlockSize { get; }
	public abstract bool CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_InputBlockSize();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_OutputBlockSize();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_CanTransformMultipleBlocks();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount);
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class KeyedHashAlgorithm : HashAlgorithm // TypeDefIndex: 3588
{
	// Fields
	protected byte[] KeyValue; // 0x28

	// Properties
	public virtual byte[] Key { get; set; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x15E5C90 Offset: 0x15E4E90 VA: 0x1815E5C90 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x15E5CD0 Offset: 0x15E4ED0 VA: 0x1815E5CD0 Slot: 19
	public virtual byte[] get_Key() { }

	// RVA: 0x15E5D50 Offset: 0x15E4F50 VA: 0x1815E5D50 Slot: 20
	public virtual void set_Key(byte[] value) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class MACTripleDES : KeyedHashAlgorithm // TypeDefIndex: 3589
{
	// Fields
	private ICryptoTransform m_encryptor; // 0x30
	private CryptoStream _cs; // 0x38
	private TailStream _ts; // 0x40
	private int m_bytesPerBlock; // 0x48
	private TripleDES des; // 0x50

	// Methods

	// RVA: 0x15E6290 Offset: 0x15E5490 VA: 0x1815E6290
	public void .ctor() { }

	// RVA: 0x786CB0 Offset: 0x785EB0 VA: 0x180786CB0 Slot: 18
	public override void Initialize() { }

	// RVA: 0x15E5F30 Offset: 0x15E5130 VA: 0x1815E5F30 Slot: 16
	protected override void HashCore(byte[] rgbData, int ibStart, int cbSize) { }

	// RVA: 0x15E60C0 Offset: 0x15E52C0 VA: 0x1815E60C0 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x15E5E60 Offset: 0x15E5060 VA: 0x1815E5E60 Slot: 12
	protected override void Dispose(bool disposing) { }
}

// Namespace: System.Security.Cryptography
internal sealed class TailStream : Stream // TypeDefIndex: 3590
{
	// Fields
	private byte[] _Buffer; // 0x28
	private int _BufferSize; // 0x30
	private int _BufferIndex; // 0x34
	private bool _BufferFull; // 0x38

	// Properties
	public byte[] Buffer { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x15EDB10 Offset: 0x15ECD10 VA: 0x1815EDB10
	public void .ctor(int bufferSize) { }

	// RVA: 0x15C9C90 Offset: 0x15C8E90 VA: 0x1815C9C90
	public void Clear() { }

	// RVA: 0x15ED7C0 Offset: 0x15EC9C0 VA: 0x1815ED7C0 Slot: 21
	protected override void Dispose(bool disposing) { }

	// RVA: 0x15EDB90 Offset: 0x15ECD90 VA: 0x1815EDB90
	public byte[] get_Buffer() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x6B5280 Offset: 0x6B4480 VA: 0x1806B5280 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x15EDC10 Offset: 0x15ECE10 VA: 0x1815EDC10 Slot: 11
	public override long get_Length() { }

	// RVA: 0x15EDC70 Offset: 0x15ECE70 VA: 0x1815EDC70 Slot: 12
	public override long get_Position() { }

	// RVA: 0x15EDCD0 Offset: 0x15ECED0 VA: 0x1815EDCD0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 22
	public override void Flush() { }

	// RVA: 0x15ED8C0 Offset: 0x15ECAC0 VA: 0x1815ED8C0 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x15ED920 Offset: 0x15ECB20 VA: 0x1815ED920 Slot: 33
	public override void SetLength(long value) { }

	// RVA: 0x15ED860 Offset: 0x15ECA60 VA: 0x1815ED860 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x15ED980 Offset: 0x15ECB80 VA: 0x1815ED980 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class MD5 : HashAlgorithm // TypeDefIndex: 3591
{
	// Methods

	// RVA: 0x15E6440 Offset: 0x15E5640 VA: 0x1815E6440
	protected void .ctor() { }

	// RVA: 0x15E63F0 Offset: 0x15E55F0 VA: 0x1815E63F0
	public static MD5 Create() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class RandomNumberGenerator : IDisposable // TypeDefIndex: 3592
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x15E9570 Offset: 0x15E8770 VA: 0x1815E9570
	public static RandomNumberGenerator Create() { }

	// RVA: 0x15E95C0 Offset: 0x15E87C0 VA: 0x1815E95C0 Slot: 4
	public void Dispose() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void GetBytes(byte[] data);

	// RVA: 0x15E9630 Offset: 0x15E8830 VA: 0x1815E9630 Slot: 7
	public virtual void GetBytes(byte[] data, int offset, int count) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class RC2 : SymmetricAlgorithm // TypeDefIndex: 3593
{
	// Fields
	protected int EffectiveKeySizeValue; // 0x48
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public virtual int EffectiveKeySize { get; }
	public override int KeySize { get; set; }

	// Methods

	// RVA: 0x15E6AD0 Offset: 0x15E5CD0 VA: 0x1815E6AD0
	protected void .ctor() { }

	// RVA: 0x15E6B60 Offset: 0x15E5D60 VA: 0x1815E6B60 Slot: 26
	public virtual int get_EffectiveKeySize() { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x15E6B70 Offset: 0x15E5D70 VA: 0x1815E6B70 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x15E69B0 Offset: 0x15E5BB0 VA: 0x1815E69B0
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class RC2CryptoServiceProvider : RC2 // TypeDefIndex: 3594
{
	// Fields
	private bool m_use40bitSalt; // 0x50
	private static KeySizes[] s_legalKeySizes; // 0x0

	// Properties
	public override int EffectiveKeySize { get; }

	// Methods

	// RVA: 0x15E67B0 Offset: 0x15E59B0 VA: 0x1815E67B0
	public void .ctor() { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0 Slot: 26
	public override int get_EffectiveKeySize() { }

	// RVA: 0x15E6530 Offset: 0x15E5730 VA: 0x1815E6530 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x15E6460 Offset: 0x15E5660 VA: 0x1815E6460 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x15E6670 Offset: 0x15E5870 VA: 0x1815E6670 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x15E6600 Offset: 0x15E5800 VA: 0x1815E6600 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x15E66F0 Offset: 0x15E58F0 VA: 0x1815E66F0
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class Rijndael : SymmetricAlgorithm // TypeDefIndex: 3595
{
	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Methods

	// RVA: 0x15ED730 Offset: 0x15EC930 VA: 0x1815ED730
	protected void .ctor() { }

	// RVA: 0x15ED600 Offset: 0x15EC800 VA: 0x1815ED600
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class RijndaelManaged : Rijndael // TypeDefIndex: 3596
{
	// Methods

	// RVA: 0x15ED4B0 Offset: 0x15EC6B0 VA: 0x1815ED4B0
	public void .ctor() { }

	// RVA: 0x15ED270 Offset: 0x15EC470 VA: 0x1815ED270 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x15ED180 Offset: 0x15EC380 VA: 0x1815ED180 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x15ED390 Offset: 0x15EC590 VA: 0x1815ED390 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x15ED360 Offset: 0x15EC560 VA: 0x1815ED360 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x15ED3C0 Offset: 0x15EC5C0 VA: 0x1815ED3C0
	private ICryptoTransform NewEncryptor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int feedbackSize, RijndaelManagedTransformMode encryptMode) { }
}

// Namespace: System.Security.Cryptography
[Serializable]
internal enum RijndaelManagedTransformMode // TypeDefIndex: 3597
{
	// Fields
	public int value__; // 0x0
	public const RijndaelManagedTransformMode Encrypt = 0;
	public const RijndaelManagedTransformMode Decrypt = 1;
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class RijndaelManagedTransform : ICryptoTransform, IDisposable // TypeDefIndex: 3598
{
	// Fields
	private CipherMode m_cipherMode; // 0x10
	private PaddingMode m_paddingValue; // 0x14
	private RijndaelManagedTransformMode m_transformMode; // 0x18
	private int m_blockSizeBits; // 0x1C
	private int m_blockSizeBytes; // 0x20
	private int m_inputBlockSize; // 0x24
	private int m_outputBlockSize; // 0x28
	private int[] m_encryptKeyExpansion; // 0x30
	private int[] m_decryptKeyExpansion; // 0x38
	private int m_Nr; // 0x40
	private int m_Nb; // 0x44
	private int m_Nk; // 0x48
	private int[] m_encryptindex; // 0x50
	private int[] m_decryptindex; // 0x58
	private int[] m_IV; // 0x60
	private int[] m_lastBlockBuffer; // 0x68
	private byte[] m_depadBuffer; // 0x70
	private byte[] m_shiftRegister; // 0x78
	private static readonly byte[] s_Sbox; // 0x0
	private static readonly int[] s_Rcon; // 0x8
	private static readonly int[] s_T; // 0x10
	private static readonly int[] s_TF; // 0x18
	private static readonly int[] s_iT; // 0x20
	private static readonly int[] s_iTF; // 0x28

	// Properties
	public int InputBlockSize { get; }
	public int OutputBlockSize { get; }
	public bool CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: 0x15ECAC0 Offset: 0x15EBCC0 VA: 0x1815ECAC0
	internal void .ctor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int blockSize, int feedbackSize, PaddingMode PaddingValue, RijndaelManagedTransformMode transformMode) { }

	// RVA: 0x15EA960 Offset: 0x15E9B60 VA: 0x1815EA960 Slot: 9
	public void Dispose() { }

	// RVA: 0x15EAA40 Offset: 0x15E9C40 VA: 0x1815EAA40
	private void Dispose(bool disposing) { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90 Slot: 4
	public int get_InputBlockSize() { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050 Slot: 5
	public int get_OutputBlockSize() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 6
	public bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x15EC150 Offset: 0x15EB350 VA: 0x1815EC150 Slot: 7
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x15EC520 Offset: 0x15EB720 VA: 0x1815EC520 Slot: 8
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x15EBFF0 Offset: 0x15EB1F0 VA: 0x1815EBFF0
	public void Reset() { }

	// RVA: 0x15EAD40 Offset: 0x15E9F40 VA: 0x1815EAD40
	private int EncryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	// RVA: 0x15E9AA0 Offset: 0x15E8CA0 VA: 0x1815E9AA0
	private int DecryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	// RVA: 0x15EAB30 Offset: 0x15E9D30 VA: 0x1815EAB30
	private void Enc(int* encryptindex, int* encryptKeyExpansion, int* T, int* TF, int* work, int* temp) { }

	// RVA: 0x15E9870 Offset: 0x15E8A70 VA: 0x1815E9870
	private void Dec(int* decryptindex, int* decryptKeyExpansion, int* iT, int* iTF, int* work, int* temp) { }

	// RVA: 0x15EB9B0 Offset: 0x15EABB0 VA: 0x1815EB9B0
	private void GenerateKeyExpansion(byte[] rgbKey) { }

	// RVA: 0x15ED150 Offset: 0x15EC350 VA: 0x1815ED150
	private static int rot1(int val) { }

	// RVA: 0x15ED160 Offset: 0x15EC360 VA: 0x1815ED160
	private static int rot2(int val) { }

	// RVA: 0x15ED170 Offset: 0x15EC370 VA: 0x1815ED170
	private static int rot3(int val) { }

	// RVA: 0x15EC060 Offset: 0x15EB260 VA: 0x1815EC060
	private static int SubWord(int a) { }

	// RVA: 0x15EBFC0 Offset: 0x15EB1C0 VA: 0x1815EBFC0
	private static int MulX(int x) { }

	// RVA: 0x15EC8E0 Offset: 0x15EBAE0 VA: 0x1815EC8E0
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class RIPEMD160 : HashAlgorithm // TypeDefIndex: 3599
{
	// Methods

	// RVA: 0x15E92A0 Offset: 0x15E84A0 VA: 0x1815E92A0
	protected void .ctor() { }

	// RVA: 0x15E9250 Offset: 0x15E8450 VA: 0x1815E9250
	public static RIPEMD160 Create() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class RIPEMD160Managed : RIPEMD160 // TypeDefIndex: 3600
{
	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateMD160; // 0x38
	private uint[] _blockDWords; // 0x40

	// Methods

	// RVA: 0x15E9130 Offset: 0x15E8330 VA: 0x1815E9130
	public void .ctor() { }

	// RVA: 0x15E6CE0 Offset: 0x15E5EE0 VA: 0x1815E6CE0 Slot: 18
	public override void Initialize() { }

	// RVA: 0x15E6C20 Offset: 0x15E5E20 VA: 0x1815E6C20 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x15E6C30 Offset: 0x15E5E30 VA: 0x1815E6C30 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x15E6C50 Offset: 0x15E5E50 VA: 0x1815E6C50
	private void InitializeState() { }

	// RVA: 0x15E8F90 Offset: 0x15E8190 VA: 0x1815E8F90
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x15E8DF0 Offset: 0x15E7FF0 VA: 0x1815E8DF0
	private byte[] _EndHash() { }

	// RVA: 0x15E6D50 Offset: 0x15E5F50 VA: 0x1815E6D50
	private static void MDTransform(uint* blockDWords, uint* state, byte* block) { }

	// RVA: 0x15E6BF0 Offset: 0x15E5DF0 VA: 0x1815E6BF0
	private static uint F(uint x, uint y, uint z) { }

	// RVA: 0x15E6C00 Offset: 0x15E5E00 VA: 0x1815E6C00
	private static uint G(uint x, uint y, uint z) { }

	// RVA: 0x15E6C10 Offset: 0x15E5E10 VA: 0x1815E6C10
	private static uint H(uint x, uint y, uint z) { }

	// RVA: 0x15E6C40 Offset: 0x15E5E40 VA: 0x1815E6C40
	private static uint I(uint x, uint y, uint z) { }

	// RVA: 0x15E6D40 Offset: 0x15E5F40 VA: 0x1815E6D40
	private static uint J(uint x, uint y, uint z) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
[Serializable]
public struct RSAParameters // TypeDefIndex: 3601
{
	// Fields
	public byte[] Exponent; // 0x0
	public byte[] Modulus; // 0x8
	public byte[] P; // 0x10
	public byte[] Q; // 0x18
	public byte[] DP; // 0x20
	public byte[] DQ; // 0x28
	public byte[] InverseQ; // 0x30
	public byte[] D; // 0x38
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class RSA : AsymmetricAlgorithm // TypeDefIndex: 3602
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	protected void .ctor() { }

	// RVA: 0x15F8880 Offset: 0x15F7A80 VA: 0x1815F8880
	public static RSA Create() { }

	// RVA: 0x15F88E0 Offset: 0x15F7AE0 VA: 0x1815F88E0 Slot: 10
	public virtual byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x15F8940 Offset: 0x15F7B40 VA: 0x1815F8940 Slot: 8
	public override void FromXmlString(string xmlString) { }

	// RVA: 0x15F8F10 Offset: 0x15F8110 VA: 0x1815F8F10 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract RSAParameters ExportParameters(bool includePrivateParameters);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void ImportParameters(RSAParameters parameters);
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class RSACryptoServiceProvider : RSA // TypeDefIndex: 3603
{
	// Fields
	private static CspProviderFlags s_UseMachineKeyStore; // 0x0
	private KeyPairPersistence store; // 0x20
	private bool persistKey; // 0x28
	private bool persisted; // 0x29
	private bool privateKeyExportable; // 0x2A
	private bool m_disposed; // 0x2B
	private RSAManaged rsa; // 0x30

	// Properties
	public static bool UseMachineKeyStore { get; }
	public override int KeySize { get; }
	[ComVisible(False)]
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x15F8660 Offset: 0x15F7860 VA: 0x1815F8660
	public static bool get_UseMachineKeyStore() { }

	// RVA: 0x15F85E0 Offset: 0x15F77E0 VA: 0x1815F85E0
	public void .ctor() { }

	// RVA: 0x15F84A0 Offset: 0x15F76A0 VA: 0x1815F84A0
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x15F8320 Offset: 0x15F7520 VA: 0x1815F8320
	public void .ctor(int dwKeySize) { }

	// RVA: 0x15F8360 Offset: 0x15F7560 VA: 0x1815F8360
	public void .ctor(int dwKeySize, CspParameters parameters) { }

	// RVA: 0x15F78F0 Offset: 0x15F6AF0 VA: 0x1815F78F0
	private void Common(int dwKeySize, bool parameters) { }

	// RVA: 0x15F7B20 Offset: 0x15F6D20 VA: 0x1815F7B20
	private void Common(CspParameters p) { }

	// RVA: 0x15667F0 Offset: 0x15659F0 VA: 0x1815667F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x15F8610 Offset: 0x15F7810 VA: 0x1815F8610 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x15F8640 Offset: 0x15F7840 VA: 0x1815F8640
	public bool get_PublicOnly() { }

	// RVA: 0x15F7C40 Offset: 0x15F6E40 VA: 0x1815F7C40 Slot: 10
	public override byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x15F7C70 Offset: 0x15F6E70 VA: 0x1815F7C70 Slot: 11
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x15F48E0 Offset: 0x15F3AE0 VA: 0x1815F48E0 Slot: 12
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x15F7E10 Offset: 0x15F7010 VA: 0x1815F7E10
	private string GetHashNameFromOID(string oid) { }

	// RVA: 0x15F8050 Offset: 0x15F7250 VA: 0x1815F8050
	public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature) { }

	// RVA: 0x15F47C0 Offset: 0x15F39C0 VA: 0x1815F47C0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x15F7FC0 Offset: 0x15F71C0 VA: 0x1815F7FC0
	private void OnKeyGenerated(object sender, EventArgs e) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class SHA1 : HashAlgorithm // TypeDefIndex: 3604
{
	// Methods

	// RVA: 0x15F9E00 Offset: 0x15F9000 VA: 0x1815F9E00
	protected void .ctor() { }

	// RVA: 0x15F9DB0 Offset: 0x15F8FB0 VA: 0x1815F9DB0
	public static SHA1 Create() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class SHA1Managed : SHA1 // TypeDefIndex: 3605
{
	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateSHA1; // 0x38
	private uint[] _expandedBuffer; // 0x40

	// Methods

	// RVA: 0x15F9CF0 Offset: 0x15F8EF0 VA: 0x1815F9CF0
	public void .ctor() { }

	// RVA: 0x15F92F0 Offset: 0x15F84F0 VA: 0x1815F92F0 Slot: 18
	public override void Initialize() { }

	// RVA: 0x15F92D0 Offset: 0x15F84D0 VA: 0x1815F92D0 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x15F92E0 Offset: 0x15F84E0 VA: 0x1815F92E0 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x15E6C50 Offset: 0x15E5E50 VA: 0x1815E6C50
	private void InitializeState() { }

	// RVA: 0x15F9B50 Offset: 0x15F8D50 VA: 0x1815F9B50
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x15F9920 Offset: 0x15F8B20 VA: 0x1815F9920
	private byte[] _EndHash() { }

	// RVA: 0x15F9390 Offset: 0x15F8590 VA: 0x1815F9390
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x15F9350 Offset: 0x15F8550 VA: 0x1815F9350
	private static void SHAExpand(uint* x) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class SHA256 : HashAlgorithm // TypeDefIndex: 3606
{
	// Methods

	// RVA: 0x15FB450 Offset: 0x15FA650 VA: 0x1815FB450
	protected void .ctor() { }

	// RVA: 0x15FB400 Offset: 0x15FA600 VA: 0x1815FB400
	public static SHA256 Create() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class SHA256Managed : SHA256 // TypeDefIndex: 3607
{
	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateSHA256; // 0x38
	private uint[] _W; // 0x40
	private static readonly uint[] _K; // 0x0

	// Methods

	// RVA: 0x15FB280 Offset: 0x15FA480 VA: 0x1815FB280
	public void .ctor() { }

	// RVA: 0x15F9F40 Offset: 0x15F9140 VA: 0x1815F9F40 Slot: 18
	public override void Initialize() { }

	// RVA: 0x15F9E30 Offset: 0x15F9030 VA: 0x1815F9E30 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x15F9E40 Offset: 0x15F9040 VA: 0x1815F9E40 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x15F9E50 Offset: 0x15F9050 VA: 0x1815F9E50
	private void InitializeState() { }

	// RVA: 0x15FB020 Offset: 0x15FA220 VA: 0x1815FB020
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x15FADF0 Offset: 0x15F9FF0 VA: 0x1815FADF0
	private byte[] _EndHash() { }

	// RVA: 0x15FA110 Offset: 0x15F9310 VA: 0x1815FA110
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x15F9FB0 Offset: 0x15F91B0 VA: 0x1815F9FB0
	private static uint RotateRight(uint x, int n) { }

	// RVA: 0x15F9E20 Offset: 0x15F9020 VA: 0x1815F9E20
	private static uint Ch(uint x, uint y, uint z) { }

	// RVA: 0x15F9FA0 Offset: 0x15F91A0 VA: 0x1815F9FA0
	private static uint Maj(uint x, uint y, uint z) { }

	// RVA: 0x15FB340 Offset: 0x15FA540 VA: 0x1815FB340
	private static uint sigma_0(uint x) { }

	// RVA: 0x15FB3A0 Offset: 0x15FA5A0 VA: 0x1815FB3A0
	private static uint sigma_1(uint x) { }

	// RVA: 0x15FAD10 Offset: 0x15F9F10 VA: 0x1815FAD10
	private static uint Sigma_0(uint x) { }

	// RVA: 0x15FAD80 Offset: 0x15F9F80 VA: 0x1815FAD80
	private static uint Sigma_1(uint x) { }

	// RVA: 0x15F9FD0 Offset: 0x15F91D0 VA: 0x1815F9FD0
	private static void SHA256Expand(uint* x) { }

	// RVA: 0x15FB200 Offset: 0x15FA400 VA: 0x1815FB200
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class SHA384 : HashAlgorithm // TypeDefIndex: 3608
{
	// Methods

	// RVA: 0x15FCD40 Offset: 0x15FBF40 VA: 0x1815FCD40
	protected void .ctor() { }

	// RVA: 0x15FCCF0 Offset: 0x15FBEF0 VA: 0x1815FCCF0
	public static SHA384 Create() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class SHA384Managed : SHA384 // TypeDefIndex: 3609
{
	// Fields
	private byte[] _buffer; // 0x28
	private ulong _count; // 0x30
	private ulong[] _stateSHA384; // 0x38
	private ulong[] _W; // 0x40
	private static readonly ulong[] _K; // 0x0

	// Methods

	// RVA: 0x15FCB50 Offset: 0x15FBD50 VA: 0x1815FCB50
	public void .ctor() { }

	// RVA: 0x15FB5D0 Offset: 0x15FA7D0 VA: 0x1815FB5D0 Slot: 18
	public override void Initialize() { }

	// RVA: 0x15FB480 Offset: 0x15FA680 VA: 0x1815FB480 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x15FB490 Offset: 0x15FA690 VA: 0x1815FB490 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x15FB4A0 Offset: 0x15FA6A0 VA: 0x1815FB4A0
	private void InitializeState() { }

	// RVA: 0x15FC8E0 Offset: 0x15FBAE0 VA: 0x1815FC8E0
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x15FC620 Offset: 0x15FB820 VA: 0x1815FC620
	private byte[] _EndHash() { }

	// RVA: 0x15FB7C0 Offset: 0x15FA9C0 VA: 0x1815FB7C0
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x15FB640 Offset: 0x15FA840 VA: 0x1815FB640
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x15FB470 Offset: 0x15FA670 VA: 0x1815FB470
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x15FB630 Offset: 0x15FA830 VA: 0x1815FB630
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x15FC520 Offset: 0x15FB720 VA: 0x1815FC520
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x15FC5A0 Offset: 0x15FB7A0 VA: 0x1815FC5A0
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x15FCC10 Offset: 0x15FBE10 VA: 0x1815FCC10
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x15FCC80 Offset: 0x15FBE80 VA: 0x1815FCC80
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x15FB660 Offset: 0x15FA860 VA: 0x1815FB660
	private static void SHA384Expand(ulong* x) { }

	// RVA: 0x15FCAD0 Offset: 0x15FBCD0 VA: 0x1815FCAD0
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class SHA512 : HashAlgorithm // TypeDefIndex: 3610
{
	// Methods

	// RVA: 0x15FE5F0 Offset: 0x15FD7F0 VA: 0x1815FE5F0
	protected void .ctor() { }

	// RVA: 0x15FE5A0 Offset: 0x15FD7A0 VA: 0x1815FE5A0
	public static SHA512 Create() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class SHA512Managed : SHA512 // TypeDefIndex: 3611
{
	// Fields
	private byte[] _buffer; // 0x28
	private ulong _count; // 0x30
	private ulong[] _stateSHA512; // 0x38
	private ulong[] _W; // 0x40
	private static readonly ulong[] _K; // 0x0

	// Methods

	// RVA: 0x15FE400 Offset: 0x15FD600 VA: 0x1815FE400
	public void .ctor() { }

	// RVA: 0x15FCEB0 Offset: 0x15FC0B0 VA: 0x1815FCEB0 Slot: 18
	public override void Initialize() { }

	// RVA: 0x15FCD60 Offset: 0x15FBF60 VA: 0x1815FCD60 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x15FCD70 Offset: 0x15FBF70 VA: 0x1815FCD70 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x15FCD80 Offset: 0x15FBF80 VA: 0x1815FCD80
	private void InitializeState() { }

	// RVA: 0x15FE190 Offset: 0x15FD390 VA: 0x1815FE190
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x15FDED0 Offset: 0x15FD0D0 VA: 0x1815FDED0
	private byte[] _EndHash() { }

	// RVA: 0x15FD070 Offset: 0x15FC270 VA: 0x1815FD070
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x15FB640 Offset: 0x15FA840 VA: 0x1815FB640
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x15FB470 Offset: 0x15FA670 VA: 0x1815FB470
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x15FB630 Offset: 0x15FA830 VA: 0x1815FB630
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x15FDDD0 Offset: 0x15FCFD0 VA: 0x1815FDDD0
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x15FDE50 Offset: 0x15FD050 VA: 0x1815FDE50
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x15FE4C0 Offset: 0x15FD6C0 VA: 0x1815FE4C0
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x15FE530 Offset: 0x15FD730 VA: 0x1815FE530
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x15FCF10 Offset: 0x15FC110 VA: 0x1815FCF10
	private static void SHA512Expand(ulong* x) { }

	// RVA: 0x15FE380 Offset: 0x15FD580 VA: 0x1815FE380
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class SignatureDescription // TypeDefIndex: 3612
{
	// Fields
	private string _strKey; // 0x10
	private string _strDigest; // 0x18
	private string _strFormatter; // 0x20
	private string _strDeformatter; // 0x28

	// Properties
	public string KeyAlgorithm { set; }
	public string DigestAlgorithm { set; }
	public string FormatterAlgorithm { set; }
	public string DeformatterAlgorithm { set; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_KeyAlgorithm(string value) { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_DigestAlgorithm(string value) { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_FormatterAlgorithm(string value) { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_DeformatterAlgorithm(string value) { }
}

// Namespace: System.Security.Cryptography
internal abstract class RSAPKCS1SignatureDescription : SignatureDescription // TypeDefIndex: 3613
{
	// Fields
	private string _hashAlgorithm; // 0x30

	// Methods

	// RVA: 0x15F87F0 Offset: 0x15F79F0 VA: 0x1815F87F0
	protected void .ctor(string hashAlgorithm, string digestAlgorithm) { }
}

// Namespace: System.Security.Cryptography
internal class RSAPKCS1SHA1SignatureDescription : RSAPKCS1SignatureDescription // TypeDefIndex: 3614
{
	// Methods

	// RVA: 0x15F86B0 Offset: 0x15F78B0 VA: 0x1815F86B0
	public void .ctor() { }
}

// Namespace: System.Security.Cryptography
internal class RSAPKCS1SHA256SignatureDescription : RSAPKCS1SignatureDescription // TypeDefIndex: 3615
{
	// Methods

	// RVA: 0x15F8700 Offset: 0x15F7900 VA: 0x1815F8700
	public void .ctor() { }
}

// Namespace: System.Security.Cryptography
internal class RSAPKCS1SHA384SignatureDescription : RSAPKCS1SignatureDescription // TypeDefIndex: 3616
{
	// Methods

	// RVA: 0x15F8750 Offset: 0x15F7950 VA: 0x1815F8750
	public void .ctor() { }
}

// Namespace: System.Security.Cryptography
internal class RSAPKCS1SHA512SignatureDescription : RSAPKCS1SignatureDescription // TypeDefIndex: 3617
{
	// Methods

	// RVA: 0x15F87A0 Offset: 0x15F79A0 VA: 0x1815F87A0
	public void .ctor() { }
}

// Namespace: System.Security.Cryptography
internal class DSASignatureDescription : SignatureDescription // TypeDefIndex: 3618
{
	// Methods

	// RVA: 0x15F4C60 Offset: 0x15F3E60 VA: 0x1815F4C60
	public void .ctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class SymmetricAlgorithm : IDisposable // TypeDefIndex: 3619
{
	// Fields
	protected int BlockSizeValue; // 0x10
	protected int FeedbackSizeValue; // 0x14
	protected byte[] IVValue; // 0x18
	protected byte[] KeyValue; // 0x20
	protected KeySizes[] LegalBlockSizesValue; // 0x28
	protected KeySizes[] LegalKeySizesValue; // 0x30
	protected int KeySizeValue; // 0x38
	protected CipherMode ModeValue; // 0x3C
	protected PaddingMode PaddingValue; // 0x40

	// Properties
	public virtual int BlockSize { get; set; }
	public virtual int FeedbackSize { get; }
	public virtual byte[] IV { get; set; }
	public virtual byte[] Key { get; set; }
	public virtual KeySizes[] LegalKeySizes { get; }
	public virtual int KeySize { get; set; }
	public virtual CipherMode Mode { get; set; }
	public virtual PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x15FE9F0 Offset: 0x15FDBF0 VA: 0x1815FE9F0
	protected void .ctor() { }

	// RVA: 0x15FE8F0 Offset: 0x15FDAF0 VA: 0x1815FE8F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x15FE610 Offset: 0x15FD810 VA: 0x1815FE610
	public void Clear() { }

	// RVA: 0x15FE890 Offset: 0x15FDA90 VA: 0x1815FE890 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 6
	public virtual int get_BlockSize() { }

	// RVA: 0x15FEBF0 Offset: 0x15FDDF0 VA: 0x1815FEBF0 Slot: 7
	public virtual void set_BlockSize(int value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 8
	public virtual int get_FeedbackSize() { }

	// RVA: 0x15FEA20 Offset: 0x15FDC20 VA: 0x1815FEA20 Slot: 9
	public virtual byte[] get_IV() { }

	// RVA: 0x15FED30 Offset: 0x15FDF30 VA: 0x1815FED30 Slot: 10
	public virtual void set_IV(byte[] value) { }

	// RVA: 0x15FEAC0 Offset: 0x15FDCC0 VA: 0x1815FEAC0 Slot: 11
	public virtual byte[] get_Key() { }

	// RVA: 0x15FEF20 Offset: 0x15FE120 VA: 0x1815FEF20 Slot: 12
	public virtual void set_Key(byte[] value) { }

	// RVA: 0x15FEB60 Offset: 0x15FDD60 VA: 0x1815FEB60 Slot: 13
	public virtual KeySizes[] get_LegalKeySizes() { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0 Slot: 14
	public virtual int get_KeySize() { }

	// RVA: 0x15FEE90 Offset: 0x15FE090 VA: 0x1815FEE90 Slot: 15
	public virtual void set_KeySize(int value) { }

	// RVA: 0x15FEBE0 Offset: 0x15FDDE0 VA: 0x1815FEBE0 Slot: 16
	public virtual CipherMode get_Mode() { }

	// RVA: 0x15FF0A0 Offset: 0x15FE2A0 VA: 0x1815FF0A0 Slot: 17
	public virtual void set_Mode(CipherMode value) { }

	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440 Slot: 18
	public virtual PaddingMode get_Padding() { }

	// RVA: 0x15FF120 Offset: 0x15FE320 VA: 0x1815FF120 Slot: 19
	public virtual void set_Padding(PaddingMode value) { }

	// RVA: 0x15FE960 Offset: 0x15FDB60 VA: 0x1815FE960
	public bool ValidKeySize(int bitLength) { }

	// RVA: 0x15FE7A0 Offset: 0x15FD9A0 VA: 0x1815FE7A0
	public static SymmetricAlgorithm Create(string algName) { }

	// RVA: 0x15FE730 Offset: 0x15FD930 VA: 0x1815FE730 Slot: 20
	public virtual ICryptoTransform CreateEncryptor() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV);

	// RVA: 0x15FE6C0 Offset: 0x15FD8C0 VA: 0x1815FE6C0 Slot: 22
	public virtual ICryptoTransform CreateDecryptor() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void GenerateKey();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void GenerateIV();
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class TripleDES : SymmetricAlgorithm // TypeDefIndex: 3620
{
	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x15FFD30 Offset: 0x15FEF30 VA: 0x1815FFD30
	protected void .ctor() { }

	// RVA: 0x15FFDD0 Offset: 0x15FEFD0 VA: 0x1815FFDD0 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x15FFEA0 Offset: 0x15FF0A0 VA: 0x1815FFEA0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x15FF730 Offset: 0x15FE930 VA: 0x1815FF730
	public static TripleDES Create() { }

	// RVA: 0x15FFA00 Offset: 0x15FEC00 VA: 0x1815FFA00
	public static bool IsWeakKey(byte[] rgbKey) { }

	// RVA: 0x15FF780 Offset: 0x15FE980 VA: 0x1815FF780
	private static bool EqualBytes(byte[] rgbKey, int start1, int start2, int count) { }

	// RVA: 0x15FF9E0 Offset: 0x15FEBE0 VA: 0x1815FF9E0
	private static bool IsLegalKeySize(byte[] rgbKey) { }

	// RVA: 0x15FFC00 Offset: 0x15FEE00 VA: 0x1815FFC00
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class TripleDESCryptoServiceProvider : TripleDES // TypeDefIndex: 3621
{
	// Methods

	// RVA: 0x15FF650 Offset: 0x15FE850 VA: 0x1815FF650
	public void .ctor() { }

	// RVA: 0x15FF2C0 Offset: 0x15FE4C0 VA: 0x1815FF2C0 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x15FF1A0 Offset: 0x15FE3A0 VA: 0x1815FF1A0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x15FF4E0 Offset: 0x15FE6E0 VA: 0x1815FF4E0 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x15FF3E0 Offset: 0x15FE5E0 VA: 0x1815FF3E0 Slot: 25
	public override void GenerateIV() { }
}

// Namespace: System.Security.Cryptography
internal static class Utils // TypeDefIndex: 3622
{
	// Fields
	private static RNGCryptoServiceProvider _rng; // 0x0

	// Properties
	internal static RNGCryptoServiceProvider StaticRandomNumberGenerator { get; }

	// Methods

	// RVA: 0x1600AB0 Offset: 0x15FFCB0 VA: 0x181600AB0
	internal static RNGCryptoServiceProvider get_StaticRandomNumberGenerator() { }

	// RVA: 0x1600840 Offset: 0x15FFA40 VA: 0x181600840
	internal static byte[] GenerateRandom(int keySize) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	internal static bool HasAlgorithm(int dwCalg, int dwKeySize) { }

	// RVA: 0x1600490 Offset: 0x15FF690 VA: 0x181600490
	internal static string DiscardWhiteSpaces(string inputBuffer) { }

	// RVA: 0x16005F0 Offset: 0x15FF7F0 VA: 0x1816005F0
	internal static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x16000C0 Offset: 0x15FF2C0 VA: 0x1816000C0
	internal static int ConvertByteArrayToInt(byte[] input) { }

	// RVA: 0x1600110 Offset: 0x15FF310 VA: 0x181600110
	internal static byte[] ConvertIntToByteArray(int dwInput) { }

	// RVA: 0x1600770 Offset: 0x15FF970 VA: 0x181600770
	internal static byte[] FixupKeyParity(byte[] key) { }

	// RVA: 0x1600280 Offset: 0x15FF480 VA: 0x181600280
	internal static void DWORDFromLittleEndian(uint* x, int digits, byte* block) { }

	// RVA: 0x16003B0 Offset: 0x15FF5B0 VA: 0x1816003B0
	internal static void DWORDToLittleEndian(byte[] block, uint[] x, int digits) { }

	// RVA: 0x1600230 Offset: 0x15FF430 VA: 0x181600230
	internal static void DWORDFromBigEndian(uint* x, int digits, byte* block) { }

	// RVA: 0x16002D0 Offset: 0x15FF4D0 VA: 0x1816002D0
	internal static void DWORDToBigEndian(byte[] block, uint[] x, int digits) { }

	// RVA: 0x16008B0 Offset: 0x15FFAB0 VA: 0x1816008B0
	internal static void QuadWordFromBigEndian(ulong* x, int digits, byte* block) { }

	// RVA: 0x1600940 Offset: 0x15FFB40 VA: 0x181600940
	internal static void QuadWordToBigEndian(byte[] block, ulong[] x, int digits) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	internal static bool _ProduceLegacyHmacValues() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class CryptoConfig // TypeDefIndex: 3623
{
	// Fields
	private static readonly object lockObject; // 0x0
	private static Dictionary<string, Type> algorithms; // 0x8

	// Properties
	[MonoLimitation("nothing is FIPS certified so it never make sense to restrict to this (empty) subset")]
	public static bool AllowOnlyFipsAlgorithms { get; }

	// Methods

	// RVA: 0x15F2230 Offset: 0x15F1430 VA: 0x1815F2230
	public static object CreateFromName(string name) { }

	// RVA: 0x15F04B0 Offset: 0x15EF6B0 VA: 0x1815F04B0
	public static object CreateFromName(string name, object[] args) { }

	// RVA: 0x15F2880 Offset: 0x15F1A80 VA: 0x1815F2880
	public static string MapNameToOID(string name) { }

	// RVA: 0x15F2430 Offset: 0x15F1630 VA: 0x1815F2430
	public static byte[] EncodeOID(string str) { }

	// RVA: 0x15F2280 Offset: 0x15F1480 VA: 0x1815F2280
	private static byte[] EncodeLongNumber(long x) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	public static bool get_AllowOnlyFipsAlgorithms() { }

	// RVA: 0x15F2F40 Offset: 0x15F2140 VA: 0x1815F2F40
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
internal class DESTransform : SymmetricTransform // TypeDefIndex: 3624
{
	// Fields
	internal static readonly int KEY_BIT_SIZE; // 0x0
	internal static readonly int KEY_BYTE_SIZE; // 0x4
	internal static readonly int BLOCK_BIT_SIZE; // 0x8
	internal static readonly int BLOCK_BYTE_SIZE; // 0xC
	private byte[] keySchedule; // 0x58
	private byte[] byteBuff; // 0x60
	private uint[] dwordBuff; // 0x68
	private static readonly uint[] spBoxes; // 0x10
	private static readonly byte[] PC1; // 0x18
	private static readonly byte[] leftRotTotal; // 0x20
	private static readonly byte[] PC2; // 0x28
	internal static readonly uint[] ipTab; // 0x30
	internal static readonly uint[] fpTab; // 0x38

	// Methods

	// RVA: 0x15F42A0 Offset: 0x15F34A0 VA: 0x1815F42A0
	internal void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x15F3030 Offset: 0x15F2230 VA: 0x1815F3030
	private uint CipherFunct(uint r, int n) { }

	// RVA: 0x15F3480 Offset: 0x15F2680 VA: 0x1815F3480
	internal static void Permutation(byte[] input, byte[] output, uint[] permTab, bool preSwap) { }

	// RVA: 0x15F2FA0 Offset: 0x15F21A0 VA: 0x1815F2FA0
	private static void BSwap(byte[] byteBuff) { }

	// RVA: 0x15F3C60 Offset: 0x15F2E60 VA: 0x1815F3C60
	internal void SetKey(byte[] key) { }

	// RVA: 0x15F3810 Offset: 0x15F2A10 VA: 0x1815F3810
	public void ProcessBlock(byte[] input, byte[] output) { }

	// RVA: 0x15F3300 Offset: 0x15F2500 VA: 0x1815F3300 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x15F33D0 Offset: 0x15F25D0 VA: 0x1815F33D0
	internal static byte[] GetStrongKey() { }

	// RVA: 0x15F4050 Offset: 0x15F3250 VA: 0x1815F4050
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class DSACryptoServiceProvider : DSA // TypeDefIndex: 3625
{
	// Fields
	private KeyPairPersistence store; // 0x20
	private bool persistKey; // 0x28
	private bool persisted; // 0x29
	private bool privateKeyExportable; // 0x2A
	private bool m_disposed; // 0x2B
	private DSAManaged dsa; // 0x30
	private static bool useMachineKeyStore; // 0x0

	// Properties
	public override int KeySize { get; }
	[ComVisible(False)]
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x15F4C00 Offset: 0x15F3E00 VA: 0x1815F4C00
	public void .ctor() { }

	// RVA: 0x15F4A00 Offset: 0x15F3C00 VA: 0x1815F4A00
	public void .ctor(int dwKeySize) { }

	// RVA: 0x15F45B0 Offset: 0x15F37B0 VA: 0x1815F45B0
	private void Common(int dwKeySize, bool parameters) { }

	// RVA: 0x15667F0 Offset: 0x15659F0 VA: 0x1815667F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x15F4C10 Offset: 0x15F3E10 VA: 0x1815F4C10 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x15F4C40 Offset: 0x15F3E40 VA: 0x1815F4C40
	public bool get_PublicOnly() { }

	// RVA: 0x15F4810 Offset: 0x15F3A10 VA: 0x1815F4810 Slot: 11
	public override DSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x15F48E0 Offset: 0x15F3AE0 VA: 0x1815F48E0 Slot: 12
	public override void ImportParameters(DSAParameters parameters) { }

	// RVA: 0x15F49D0 Offset: 0x15F3BD0 VA: 0x1815F49D0 Slot: 10
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

	// RVA: 0x15F47C0 Offset: 0x15F39C0 VA: 0x1815F47C0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x15F4940 Offset: 0x15F3B40 VA: 0x1815F4940
	private void OnKeyGenerated(object sender, EventArgs e) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class MD5CryptoServiceProvider : MD5 // TypeDefIndex: 3626
{
	// Fields
	private uint[] _H; // 0x28
	private uint[] buff; // 0x30
	private ulong count; // 0x38
	private byte[] _ProcessingBuffer; // 0x40
	private int _ProcessingBufferCount; // 0x48
	private static readonly uint[] K; // 0x0

	// Methods

	// RVA: 0x15F6690 Offset: 0x15F5890 VA: 0x1815F6690
	public void .ctor() { }

	// RVA: 0x15F4E50 Offset: 0x15F4050 VA: 0x1815F4E50 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x15F4DD0 Offset: 0x15F3FD0 VA: 0x1815F4DD0 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x15F4EC0 Offset: 0x15F40C0 VA: 0x1815F4EC0 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x15F5000 Offset: 0x15F4200 VA: 0x1815F5000 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x15F50F0 Offset: 0x15F42F0 VA: 0x1815F50F0 Slot: 18
	public override void Initialize() { }

	// RVA: 0x15F5170 Offset: 0x15F4370 VA: 0x1815F5170
	private void ProcessBlock(byte[] inputBuffer, int inputOffset) { }

	// RVA: 0x15F63D0 Offset: 0x15F55D0 VA: 0x1815F63D0
	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x15F4CF0 Offset: 0x15F3EF0 VA: 0x1815F4CF0
	internal void AddLength(ulong length, byte[] buffer, int position) { }

	// RVA: 0x15F6610 Offset: 0x15F5810 VA: 0x1815F6610
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
internal class RC2Transform : SymmetricTransform // TypeDefIndex: 3627
{
	// Fields
	private ushort R0; // 0x58
	private ushort R1; // 0x5A
	private ushort R2; // 0x5C
	private ushort R3; // 0x5E
	private ushort[] K; // 0x60
	private int j; // 0x68
	private static readonly byte[] pitable; // 0x0

	// Methods

	// RVA: 0x15F72F0 Offset: 0x15F64F0 VA: 0x1815F72F0
	public void .ctor(RC2 rc2Algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x15F6730 Offset: 0x15F5930 VA: 0x1815F6730 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x15F7270 Offset: 0x15F6470 VA: 0x1815F7270
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
public sealed class RNGCryptoServiceProvider : RandomNumberGenerator // TypeDefIndex: 3628
{
	// Fields
	private static object _lock; // 0x0
	private IntPtr _handle; // 0x10

	// Methods

	// RVA: 0x160FDA0 Offset: 0x160EFA0 VA: 0x18160FDA0
	private static void .cctor() { }

	// RVA: 0x160FE10 Offset: 0x160F010 VA: 0x18160FE10
	public void .ctor() { }

	// RVA: 0x160FA00 Offset: 0x160EC00 VA: 0x18160FA00
	private void Check() { }

	// RVA: 0x160FD90 Offset: 0x160EF90 VA: 0x18160FD90
	private static bool RngOpen() { }

	// RVA: 0x160FD80 Offset: 0x160EF80 VA: 0x18160FD80
	private static IntPtr RngInitialize(byte* seed, IntPtr seed_length) { }

	// RVA: 0x160FD70 Offset: 0x160EF70 VA: 0x18160FD70
	private static IntPtr RngGetBytes(IntPtr handle, byte* data, IntPtr data_length) { }

	// RVA: 0x160FD60 Offset: 0x160EF60 VA: 0x18160FD60
	private static void RngClose(IntPtr handle) { }

	// RVA: 0x160FB60 Offset: 0x160ED60 VA: 0x18160FB60 Slot: 6
	public override void GetBytes(byte[] data) { }

	// RVA: 0x160FAA0 Offset: 0x160ECA0 VA: 0x18160FAA0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x160FA90 Offset: 0x160EC90 VA: 0x18160FA90 Slot: 5
	protected override void Dispose(bool disposing) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter // TypeDefIndex: 3629
{
	// Fields
	private RSA rsa; // 0x10
	private string hashName; // 0x18

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x1610200 Offset: 0x160F400 VA: 0x181610200
	public void .ctor(AsymmetricAlgorithm key) { }

	// RVA: 0x160FE70 Offset: 0x160F070 VA: 0x18160FE70 Slot: 5
	public override void SetHashAlgorithm(string strName) { }

	// RVA: 0x160FEE0 Offset: 0x160F0E0 VA: 0x18160FEE0 Slot: 4
	public override void SetKey(AsymmetricAlgorithm key) { }

	// RVA: 0x1610010 Offset: 0x160F210 VA: 0x181610010 Slot: 6
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class RSAPKCS1SignatureFormatter : AsymmetricSignatureFormatter // TypeDefIndex: 3630
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Security.Cryptography
internal class SHA1Internal // TypeDefIndex: 3631
{
	// Fields
	private uint[] _H; // 0x10
	private ulong count; // 0x18
	private byte[] _ProcessingBuffer; // 0x20
	private int _ProcessingBufferCount; // 0x28
	private uint[] buff; // 0x30

	// Methods

	// RVA: 0x1612940 Offset: 0x1611B40 VA: 0x181612940
	public void .ctor() { }

	// RVA: 0x1611540 Offset: 0x1610740 VA: 0x181611540
	public void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x1611680 Offset: 0x1610880 VA: 0x181611680
	public byte[] HashFinal() { }

	// RVA: 0x1611EF0 Offset: 0x16110F0 VA: 0x181611EF0
	public void Initialize() { }

	// RVA: 0x1611F80 Offset: 0x1611180 VA: 0x181611F80
	private void ProcessBlock(byte[] inputBuffer, uint inputOffset) { }

	// RVA: 0x1611770 Offset: 0x1610970 VA: 0x181611770
	private static void InitialiseBuff(uint[] buff, byte[] input, uint inputOffset) { }

	// RVA: 0x1611210 Offset: 0x1610410 VA: 0x181611210
	private static void FillBuff(uint[] buff) { }

	// RVA: 0x16126F0 Offset: 0x16118F0 VA: 0x1816126F0
	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1611130 Offset: 0x1610330 VA: 0x181611130
	internal void AddLength(ulong length, byte[] buffer, int position) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class SHA1CryptoServiceProvider : SHA1 // TypeDefIndex: 3632
{
	// Fields
	private SHA1Internal sha; // 0x28

	// Methods

	// RVA: 0x1611060 Offset: 0x1610260 VA: 0x181611060
	public void .ctor() { }

	// RVA: 0x15F4E50 Offset: 0x15F4050 VA: 0x1815F4E50 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1610DE0 Offset: 0x160FFE0 VA: 0x181610DE0 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1610DF0 Offset: 0x160FFF0 VA: 0x181610DF0 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x1610F40 Offset: 0x1610140 VA: 0x181610F40 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x1611040 Offset: 0x1610240 VA: 0x181611040 Slot: 18
	public override void Initialize() { }
}

// Namespace: System.Security.Cryptography
internal class TripleDESTransform : SymmetricTransform // TypeDefIndex: 3633
{
	// Fields
	private DESTransform E1; // 0x58
	private DESTransform D2; // 0x60
	private DESTransform E3; // 0x68
	private DESTransform D1; // 0x70
	private DESTransform E2; // 0x78
	private DESTransform D3; // 0x80

	// Methods

	// RVA: 0x16146E0 Offset: 0x16138E0 VA: 0x1816146E0
	public void .ctor(TripleDES algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x16144D0 Offset: 0x16136D0 VA: 0x1816144D0 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x1614630 Offset: 0x1613830 VA: 0x181614630
	internal static byte[] GetStrongKey() { }
}

// Namespace: System.Security.Cryptography
internal static class CryptoConfigForwarder // TypeDefIndex: 3634
{
	// Methods

	// RVA: 0x1609920 Offset: 0x1608B20 VA: 0x181609920
	internal static object CreateFromName(string name) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509ContentType // TypeDefIndex: 3635
{
	// Fields
	public int value__; // 0x0
	public const X509ContentType Unknown = 0;
	public const X509ContentType Cert = 1;
	public const X509ContentType SerializedCert = 2;
	public const X509ContentType Pfx = 3;
	public const X509ContentType Pkcs12 = 3;
	public const X509ContentType SerializedStore = 4;
	public const X509ContentType Pkcs7 = 5;
	public const X509ContentType Authenticode = 6;
}

// Namespace: System.Security.Cryptography.X509Certificates
[Flags]
public enum X509KeyStorageFlags // TypeDefIndex: 3636
{
	// Fields
	public int value__; // 0x0
	public const X509KeyStorageFlags DefaultKeySet = 0;
	public const X509KeyStorageFlags UserKeySet = 1;
	public const X509KeyStorageFlags MachineKeySet = 2;
	public const X509KeyStorageFlags Exportable = 4;
	public const X509KeyStorageFlags UserProtected = 8;
	public const X509KeyStorageFlags PersistKeySet = 16;
	public const X509KeyStorageFlags EphemeralKeySet = 32;
}

// Namespace: System.Security.Cryptography.X509Certificates
[Serializable]
public class X509Certificate : IDisposable, IDeserializationCallback, ISerializable // TypeDefIndex: 3637
{
	// Fields
	private X509CertificateImpl impl; // 0x10
	private byte[] lazyCertHash; // 0x18
	private byte[] lazySerialNumber; // 0x20
	private string lazyIssuer; // 0x28
	private string lazySubject; // 0x30
	private string lazyKeyAlgorithm; // 0x38
	private byte[] lazyKeyAlgorithmParameters; // 0x40
	private byte[] lazyPublicKey; // 0x48
	private DateTime lazyNotBefore; // 0x50
	private DateTime lazyNotAfter; // 0x58

	// Properties
	public string Issuer { get; }
	public string Subject { get; }
	internal X509CertificateImpl Impl { get; }
	internal bool IsValid { get; }

	// Methods

	// RVA: 0x161A040 Offset: 0x1619240 VA: 0x18161A040 Slot: 7
	public virtual void Reset() { }

	// RVA: 0x161AD30 Offset: 0x1619F30 VA: 0x18161AD30
	public void .ctor() { }

	// RVA: 0x161B0E0 Offset: 0x161A2E0 VA: 0x18161B0E0
	public void .ctor(byte[] data) { }

	// RVA: 0x161AD10 Offset: 0x1619F10 VA: 0x18161AD10
	public void .ctor(byte[] rawData, string password) { }

	[CLSCompliant(False)]
	// RVA: 0x161ACF0 Offset: 0x1619EF0 VA: 0x18161ACF0
	public void .ctor(byte[] rawData, SecureString password) { }

	// RVA: 0x161B3F0 Offset: 0x161A5F0 VA: 0x18161B3F0
	public void .ctor(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	[CLSCompliant(False)]
	// RVA: 0x161B230 Offset: 0x161A430 VA: 0x18161B230
	public void .ctor(byte[] rawData, SecureString password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x161AE10 Offset: 0x161A010 VA: 0x18161AE10
	public void .ctor(IntPtr handle) { }

	// RVA: 0x161B020 Offset: 0x161A220 VA: 0x18161B020
	internal void .ctor(X509CertificateImpl impl) { }

	// RVA: 0x161ADF0 Offset: 0x1619FF0 VA: 0x18161ADF0
	public void .ctor(string fileName) { }

	// RVA: 0x161ADB0 Offset: 0x1619FB0 VA: 0x18161ADB0
	public void .ctor(string fileName, string password) { }

	[CLSCompliant(False)]
	// RVA: 0x161ADD0 Offset: 0x1619FD0 VA: 0x18161ADD0
	public void .ctor(string fileName, SecureString password) { }

	// RVA: 0x161AAF0 Offset: 0x1619CF0 VA: 0x18161AAF0
	public void .ctor(string fileName, string password, X509KeyStorageFlags keyStorageFlags) { }

	[CLSCompliant(False)]
	// RVA: 0x161AEC0 Offset: 0x161A0C0 VA: 0x18161AEC0
	public void .ctor(string fileName, SecureString password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x161A950 Offset: 0x1619B50 VA: 0x18161A950
	public void .ctor(X509Certificate cert) { }

	// RVA: 0x161ACA0 Offset: 0x1619EA0 VA: 0x18161ACA0
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x161A1B0 Offset: 0x16193B0 VA: 0x18161A1B0 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x161A170 Offset: 0x1619370 VA: 0x18161A170 Slot: 5
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x161B5D0 Offset: 0x161A7D0 VA: 0x18161B5D0
	public string get_Issuer() { }

	// RVA: 0x161B670 Offset: 0x161A870 VA: 0x18161B670
	public string get_Subject() { }

	// RVA: 0x1619090 Offset: 0x1618290 VA: 0x181619090 Slot: 4
	public void Dispose() { }

	// RVA: 0x16190B0 Offset: 0x16182B0 VA: 0x1816190B0 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x16191E0 Offset: 0x16183E0 VA: 0x1816191E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x16190D0 Offset: 0x16182D0 VA: 0x1816190D0 Slot: 9
	public virtual bool Equals(X509Certificate other) { }

	// RVA: 0x1619280 Offset: 0x1618480 VA: 0x181619280 Slot: 10
	public virtual byte[] Export(X509ContentType contentType, string password) { }

	// RVA: 0x1619650 Offset: 0x1618850 VA: 0x181619650 Slot: 11
	public virtual byte[] GetCertHash() { }

	// RVA: 0x16195B0 Offset: 0x16187B0 VA: 0x1816195B0 Slot: 12
	public virtual string GetCertHashString() { }

	// RVA: 0x1619BE0 Offset: 0x1618DE0 VA: 0x181619BE0
	private byte[] GetRawCertHash() { }

	// RVA: 0x1619B60 Offset: 0x1618D60 VA: 0x181619B60 Slot: 13
	public virtual byte[] GetRawCertData() { }

	// RVA: 0x16196F0 Offset: 0x16188F0 VA: 0x1816196F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1619840 Offset: 0x1618A40 VA: 0x181619840 Slot: 14
	public virtual string GetKeyAlgorithm() { }

	// RVA: 0x16197A0 Offset: 0x16189A0 VA: 0x1816197A0 Slot: 15
	public virtual byte[] GetKeyAlgorithmParameters() { }

	// RVA: 0x1619AC0 Offset: 0x1618CC0 VA: 0x181619AC0 Slot: 16
	public virtual byte[] GetPublicKey() { }

	// RVA: 0x1619D40 Offset: 0x1618F40 VA: 0x181619D40 Slot: 17
	public virtual byte[] GetSerialNumber() { }

	// RVA: 0x1619CA0 Offset: 0x1618EA0 VA: 0x181619CA0 Slot: 18
	public virtual string GetSerialNumberString() { }

	// RVA: 0x1619C40 Offset: 0x1618E40 VA: 0x181619C40
	private byte[] GetRawSerialNumber() { }

	// RVA: 0x161A250 Offset: 0x1619450 VA: 0x18161A250 Slot: 3
	public override string ToString() { }

	// RVA: 0x161A270 Offset: 0x1619470 VA: 0x18161A270 Slot: 19
	public virtual string ToString(bool fVerbose) { }

	[ComVisible(False)]
	// RVA: 0x1619FF0 Offset: 0x16191F0 VA: 0x181619FF0 Slot: 20
	public virtual void Import(byte[] rawData) { }

	[ComVisible(False)]
	// RVA: 0x1619EB0 Offset: 0x16190B0 VA: 0x181619EB0 Slot: 21
	public virtual void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x1619FA0 Offset: 0x16191A0 VA: 0x181619FA0 Slot: 22
	public virtual void Import(byte[] rawData, SecureString password, X509KeyStorageFlags keyStorageFlags) { }

	[ComVisible(False)]
	// RVA: 0x1619F50 Offset: 0x1619150 VA: 0x181619F50 Slot: 23
	public virtual void Import(string fileName) { }

	[ComVisible(False)]
	// RVA: 0x1619F00 Offset: 0x1619100 VA: 0x181619F00 Slot: 24
	public virtual void Import(string fileName, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x1619E60 Offset: 0x1619060 VA: 0x181619E60 Slot: 25
	public virtual void Import(string fileName, SecureString password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x16198E0 Offset: 0x1618AE0 VA: 0x1816198E0
	internal DateTime GetNotAfter() { }

	// RVA: 0x16199D0 Offset: 0x1618BD0 VA: 0x1816199D0
	internal DateTime GetNotBefore() { }

	// RVA: 0x1619440 Offset: 0x1618640 VA: 0x181619440
	protected static string FormatDate(DateTime date) { }

	// RVA: 0x161A7C0 Offset: 0x16199C0 VA: 0x18161A7C0
	internal static void ValidateKeyStorageFlags(X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x161A8E0 Offset: 0x1619AE0 VA: 0x18161A8E0
	private void VerifyContentType(X509ContentType contentType) { }

	// RVA: 0x1619E20 Offset: 0x1619020 VA: 0x181619E20
	internal void ImportHandle(X509CertificateImpl impl) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal X509CertificateImpl get_Impl() { }

	// RVA: 0x161B5B0 Offset: 0x161A7B0 VA: 0x18161B5B0
	internal bool get_IsValid() { }

	// RVA: 0x161A1F0 Offset: 0x16193F0 VA: 0x18161A1F0
	internal void ThrowIfInvalid() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509CertificateImpl : IDisposable // TypeDefIndex: 3638
{
	// Properties
	public abstract bool IsValid { get; }
	public abstract IntPtr Handle { get; }
	public abstract string Issuer { get; }
	public abstract string Subject { get; }
	public abstract string LegacyIssuer { get; }
	public abstract string LegacySubject { get; }
	public abstract byte[] RawData { get; }
	public abstract DateTime NotAfter { get; }
	public abstract DateTime NotBefore { get; }
	public abstract byte[] Thumbprint { get; }
	public abstract string KeyAlgorithm { get; }
	public abstract byte[] KeyAlgorithmParameters { get; }
	public abstract byte[] PublicKeyValue { get; }
	public abstract byte[] SerialNumber { get; }
	public abstract bool HasPrivateKey { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsValid();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IntPtr get_Handle();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IntPtr GetNativeAppleCertificate();

	// RVA: 0x1619040 Offset: 0x1618240 VA: 0x181619040
	protected void ThrowIfContextInvalid() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract X509CertificateImpl Clone();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_Issuer();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract string get_Subject();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract string get_LegacyIssuer();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract string get_LegacySubject();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract byte[] get_RawData();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract DateTime get_NotAfter();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract DateTime get_NotBefore();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract byte[] get_Thumbprint();

	// RVA: 0x1618FB0 Offset: 0x16181B0 VA: 0x181618FB0 Slot: 2
	public sealed override int GetHashCode() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool Equals(X509CertificateImpl other, out bool result);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract string get_KeyAlgorithm();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract byte[] get_KeyAlgorithmParameters();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract byte[] get_PublicKeyValue();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract byte[] get_SerialNumber();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract bool get_HasPrivateKey();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract RSA GetRSAPrivateKey();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract DSA GetDSAPrivateKey();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract byte[] Export(X509ContentType contentType, SafePasswordHandle password);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract X509CertificateImpl CopyWithPrivateKey(RSA privateKey);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract X509Certificate CreateCertificate();

	// RVA: 0x1618D90 Offset: 0x1617F90 VA: 0x181618D90 Slot: 0
	public sealed override bool Equals(object obj) { }

	// RVA: 0x1618D20 Offset: 0x1617F20 VA: 0x181618D20 Slot: 4
	public void Dispose() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 28
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1618F40 Offset: 0x1618140 VA: 0x181618F40 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal static class X509Helper // TypeDefIndex: 3639
{
	// Properties
	private static ISystemCertificateProvider CertificateProvider { get; }

	// Methods

	// RVA: 0x161BAB0 Offset: 0x161ACB0 VA: 0x18161BAB0
	private static ISystemCertificateProvider get_CertificateProvider() { }

	// RVA: 0x161B950 Offset: 0x161AB50 VA: 0x18161B950
	public static X509CertificateImpl InitFromCertificate(X509Certificate cert) { }

	// RVA: 0x161BA20 Offset: 0x161AC20 VA: 0x18161BA20
	public static X509CertificateImpl InitFromCertificate(X509CertificateImpl impl) { }

	// RVA: 0x161BA40 Offset: 0x161AC40 VA: 0x18161BA40
	public static bool IsValid(X509CertificateImpl impl) { }

	// RVA: 0x161BA60 Offset: 0x161AC60 VA: 0x18161BA60
	internal static void ThrowIfContextInvalid(X509CertificateImpl impl) { }

	// RVA: 0x161B710 Offset: 0x161A910 VA: 0x18161B710
	internal static Exception GetInvalidContextException() { }

	// RVA: 0x161B890 Offset: 0x161AA90 VA: 0x18161B890
	public static X509CertificateImpl Import(byte[] rawData) { }

	// RVA: 0x161B780 Offset: 0x161A980 VA: 0x18161B780
	public static X509CertificateImpl Import(byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }
}

// Namespace: System.Security.Principal
[Serializable]
public class GenericIdentity : ClaimsIdentity // TypeDefIndex: 3640
{
	// Fields
	private readonly string m_name; // 0x78
	private readonly string m_type; // 0x80

	// Properties
	public override IEnumerable<Claim> Claims { get; }
	public override string Name { get; }
	public override string AuthenticationType { get; }

	// Methods

	// RVA: 0x160B030 Offset: 0x160A230 VA: 0x18160B030
	public void .ctor(string name, string type) { }

	// RVA: 0x1603300 Offset: 0x1602500 VA: 0x181603300
	private void .ctor() { }

	// RVA: 0x160AFE0 Offset: 0x160A1E0 VA: 0x18160AFE0
	protected void .ctor(GenericIdentity identity) { }

	// RVA: 0x160AF60 Offset: 0x160A160 VA: 0x18160AF60 Slot: 9
	public override ClaimsIdentity Clone() { }

	// RVA: 0x1603D30 Offset: 0x1602F30 VA: 0x181603D30 Slot: 7
	public override IEnumerable<Claim> get_Claims() { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830 Slot: 6
	public override string get_AuthenticationType() { }

	// RVA: 0x160ADE0 Offset: 0x1609FE0 VA: 0x18160ADE0
	private void AddNameClaim() { }
}

// Namespace: System.Security.Principal
public interface IIdentity // TypeDefIndex: 3641
{
	// Properties
	public abstract string Name { get; }
	public abstract string AuthenticationType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_AuthenticationType();
}

// Namespace: System.Security.Principal
public interface IPrincipal // TypeDefIndex: 3642
{
	// Properties
	public abstract IIdentity Identity { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IIdentity get_Identity();
}

// Namespace: System.Security.Principal
public enum TokenImpersonationLevel // TypeDefIndex: 3643
{
	// Fields
	public int value__; // 0x0
	public const TokenImpersonationLevel None = 0;
	public const TokenImpersonationLevel Anonymous = 1;
	public const TokenImpersonationLevel Identification = 2;
	public const TokenImpersonationLevel Impersonation = 3;
	public const TokenImpersonationLevel Delegation = 4;
}

// Namespace: System.Security.Principal
[ComVisible(True)]
[Serializable]
public class GenericPrincipal : ClaimsPrincipal // TypeDefIndex: 3644
{
	// Fields
	private IIdentity m_identity; // 0x28
	private string[] m_roles; // 0x30

	// Properties
	public override IIdentity Identity { get; }

	// Methods

	// RVA: 0x160B290 Offset: 0x160A490 VA: 0x18160B290
	public void .ctor(IIdentity identity, string[] roles) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 5
	public override IIdentity get_Identity() { }
}

// Namespace: System.Security.Principal
[ComVisible(False)]
[Serializable]
public sealed class IdentityNotMappedException : SystemException // TypeDefIndex: 3645
{
	// Methods

	// RVA: 0x160B4D0 Offset: 0x160A6D0 VA: 0x18160B4D0
	public void .ctor() { }

	// RVA: 0x160B4C0 Offset: 0x160A6C0 VA: 0x18160B4C0
	public void .ctor(string message) { }

	[MonoTODO("not implemented")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 15
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }
}

// Namespace: System.Security.Principal
[ComVisible(False)]
public abstract class IdentityReference // TypeDefIndex: 3646
{
	// Properties
	public abstract string Value { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_Value();

	// RVA: -1 Offset: -1 Slot: 0
	public abstract override bool Equals(object o);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract override int GetHashCode();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract override string ToString();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IdentityReference Translate(Type targetType);

	// RVA: 0x160B520 Offset: 0x160A720 VA: 0x18160B520
	public static bool op_Equality(IdentityReference left, IdentityReference right) { }
}

// Namespace: System.Security.Principal
[ComVisible(False)]
public sealed class NTAccount : IdentityReference // TypeDefIndex: 3647
{
	// Fields
	private string _value; // 0x10

	// Properties
	public override string Value { get; }

	// Methods

	// RVA: 0x160BAC0 Offset: 0x160ACC0 VA: 0x18160BAC0
	public void .ctor(string name) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public override string get_Value() { }

	// RVA: 0x160B6E0 Offset: 0x160A8E0 VA: 0x18160B6E0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x160B780 Offset: 0x160A980 VA: 0x18160B780 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x617170 Offset: 0x616370 VA: 0x180617170 Slot: 3
	public override string ToString() { }

	// RVA: 0x160B7C0 Offset: 0x160A9C0 VA: 0x18160B7C0 Slot: 5
	public override IdentityReference Translate(Type targetType) { }

	// RVA: 0x160B520 Offset: 0x160A720 VA: 0x18160B520
	public static bool op_Equality(NTAccount left, NTAccount right) { }
}

// Namespace: System.Security.Principal
[ComVisible(False)]
public sealed class SecurityIdentifier : IdentityReference, IComparable<SecurityIdentifier> // TypeDefIndex: 3648
{
	// Fields
	private byte[] buffer; // 0x10
	public static readonly int MaxBinaryLength; // 0x0
	public static readonly int MinBinaryLength; // 0x4

	// Properties
	public int BinaryLength { get; }
	public override string Value { get; }

	// Methods

	// RVA: 0x1614090 Offset: 0x1613290 VA: 0x181614090
	public void .ctor(string sddlForm) { }

	// RVA: 0x1613E00 Offset: 0x1613000 VA: 0x181613E00
	public void .ctor(byte[] binaryForm, int offset) { }

	// RVA: 0x1612B70 Offset: 0x1611D70 VA: 0x181612B70
	private void CreateFromBinaryForm(IntPtr binaryForm, int length) { }

	// RVA: 0xB77F20 Offset: 0xB77120 VA: 0x180B77F20
	public int get_BinaryLength() { }

	// RVA: 0x1614150 Offset: 0x1613350 VA: 0x181614150 Slot: 4
	public override string get_Value() { }

	// RVA: 0x1612F80 Offset: 0x1612180 VA: 0x181612F80
	private ulong GetSidAuthority() { }

	// RVA: 0x1613030 Offset: 0x1612230 VA: 0x181613030
	private byte GetSidSubAuthorityCount() { }

	// RVA: 0x1613060 Offset: 0x1612260 VA: 0x181613060
	private uint GetSidSubAuthority(byte index) { }

	// RVA: 0x16129D0 Offset: 0x1611BD0 VA: 0x1816129D0 Slot: 6
	public int CompareTo(SecurityIdentifier sid) { }

	// RVA: 0x1612DB0 Offset: 0x1611FB0 VA: 0x181612DB0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1612D10 Offset: 0x1611F10 VA: 0x181612D10
	public bool Equals(SecurityIdentifier sid) { }

	// RVA: 0x1612E90 Offset: 0x1612090 VA: 0x181612E90
	public void GetBinaryForm(byte[] binaryForm, int offset) { }

	// RVA: 0x160B780 Offset: 0x160A980 VA: 0x18160B780 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x617170 Offset: 0x616370 VA: 0x180617170 Slot: 3
	public override string ToString() { }

	// RVA: 0x1613870 Offset: 0x1612A70 VA: 0x181613870 Slot: 5
	public override IdentityReference Translate(Type targetType) { }

	// RVA: 0x160B520 Offset: 0x160A720 VA: 0x18160B520
	public static bool op_Equality(SecurityIdentifier left, SecurityIdentifier right) { }

	// RVA: 0x16143B0 Offset: 0x16135B0 VA: 0x1816143B0
	public static bool op_Inequality(SecurityIdentifier left, SecurityIdentifier right) { }

	// RVA: 0x16130F0 Offset: 0x16122F0 VA: 0x1816130F0
	private static byte[] ParseSddlForm(string sddlForm) { }

	// RVA: 0x1613BB0 Offset: 0x1612DB0 VA: 0x181613BB0
	private static bool TryParseAuthority(string s, out ulong result) { }

	// RVA: 0x1613CB0 Offset: 0x1612EB0 VA: 0x181613CB0
	private static bool TryParseSubAuthority(string s, out uint result) { }

	// RVA: 0x1613DB0 Offset: 0x1612FB0 VA: 0x181613DB0
	private static void .cctor() { }
}

// Namespace: System.Security.Principal
internal class WellKnownAccount // TypeDefIndex: 3649
{
	// Fields
	[CompilerGenerated]
	private WellKnownSidType <WellKnownValue>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <IsAbsolute>k__BackingField; // 0x14
	[CompilerGenerated]
	private string <Sid>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Rid>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <SddlForm>k__BackingField; // 0x30
	private static readonly WellKnownAccount[] accounts; // 0x0

	// Properties
	public WellKnownSidType WellKnownValue { set; }
	public bool IsAbsolute { get; set; }
	public string Sid { get; set; }
	public string Rid { set; }
	public string Name { get; set; }
	public string SddlForm { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_WellKnownValue(WellKnownSidType value) { }

	[CompilerGenerated]
	// RVA: 0x41AC30 Offset: 0x419E30 VA: 0x18041AC30
	public bool get_IsAbsolute() { }

	[CompilerGenerated]
	// RVA: 0x41AC60 Offset: 0x419E60 VA: 0x18041AC60
	public void set_IsAbsolute(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Sid() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Sid(string value) { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Rid(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_SddlForm() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_SddlForm(string value) { }

	// RVA: 0x16158F0 Offset: 0x1614AF0 VA: 0x1816158F0
	public static WellKnownAccount LookupBySid(string s) { }

	// RVA: 0x1615750 Offset: 0x1614950 VA: 0x181615750
	public static WellKnownAccount LookupByName(string s) { }

	// RVA: 0x1615820 Offset: 0x1614A20 VA: 0x181615820
	public static WellKnownAccount LookupBySddlForm(string s) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x16159C0 Offset: 0x1614BC0 VA: 0x1816159C0
	private static void .cctor() { }
}

// Namespace: System.Security.Principal
[ComVisible(False)]
public enum WellKnownSidType // TypeDefIndex: 3650
{
	// Fields
	public int value__; // 0x0
	public const WellKnownSidType NullSid = 0;
	public const WellKnownSidType WorldSid = 1;
	public const WellKnownSidType LocalSid = 2;
	public const WellKnownSidType CreatorOwnerSid = 3;
	public const WellKnownSidType CreatorGroupSid = 4;
	public const WellKnownSidType CreatorOwnerServerSid = 5;
	public const WellKnownSidType CreatorGroupServerSid = 6;
	public const WellKnownSidType NTAuthoritySid = 7;
	public const WellKnownSidType DialupSid = 8;
	public const WellKnownSidType NetworkSid = 9;
	public const WellKnownSidType BatchSid = 10;
	public const WellKnownSidType InteractiveSid = 11;
	public const WellKnownSidType ServiceSid = 12;
	public const WellKnownSidType AnonymousSid = 13;
	public const WellKnownSidType ProxySid = 14;
	public const WellKnownSidType EnterpriseControllersSid = 15;
	public const WellKnownSidType SelfSid = 16;
	public const WellKnownSidType AuthenticatedUserSid = 17;
	public const WellKnownSidType RestrictedCodeSid = 18;
	public const WellKnownSidType TerminalServerSid = 19;
	public const WellKnownSidType RemoteLogonIdSid = 20;
	public const WellKnownSidType LogonIdsSid = 21;
	public const WellKnownSidType LocalSystemSid = 22;
	public const WellKnownSidType LocalServiceSid = 23;
	public const WellKnownSidType NetworkServiceSid = 24;
	public const WellKnownSidType BuiltinDomainSid = 25;
	public const WellKnownSidType BuiltinAdministratorsSid = 26;
	public const WellKnownSidType BuiltinUsersSid = 27;
	public const WellKnownSidType BuiltinGuestsSid = 28;
	public const WellKnownSidType BuiltinPowerUsersSid = 29;
	public const WellKnownSidType BuiltinAccountOperatorsSid = 30;
	public const WellKnownSidType BuiltinSystemOperatorsSid = 31;
	public const WellKnownSidType BuiltinPrintOperatorsSid = 32;
	public const WellKnownSidType BuiltinBackupOperatorsSid = 33;
	public const WellKnownSidType BuiltinReplicatorSid = 34;
	public const WellKnownSidType BuiltinPreWindows2000CompatibleAccessSid = 35;
	public const WellKnownSidType BuiltinRemoteDesktopUsersSid = 36;
	public const WellKnownSidType BuiltinNetworkConfigurationOperatorsSid = 37;
	public const WellKnownSidType AccountAdministratorSid = 38;
	public const WellKnownSidType AccountGuestSid = 39;
	public const WellKnownSidType AccountKrbtgtSid = 40;
	public const WellKnownSidType AccountDomainAdminsSid = 41;
	public const WellKnownSidType AccountDomainUsersSid = 42;
	public const WellKnownSidType AccountDomainGuestsSid = 43;
	public const WellKnownSidType AccountComputersSid = 44;
	public const WellKnownSidType AccountControllersSid = 45;
	public const WellKnownSidType AccountCertAdminsSid = 46;
	public const WellKnownSidType AccountSchemaAdminsSid = 47;
	public const WellKnownSidType AccountEnterpriseAdminsSid = 48;
	public const WellKnownSidType AccountPolicyAdminsSid = 49;
	public const WellKnownSidType AccountRasAndIasServersSid = 50;
	public const WellKnownSidType NtlmAuthenticationSid = 51;
	public const WellKnownSidType DigestAuthenticationSid = 52;
	public const WellKnownSidType SChannelAuthenticationSid = 53;
	public const WellKnownSidType ThisOrganizationSid = 54;
	public const WellKnownSidType OtherOrganizationSid = 55;
	public const WellKnownSidType BuiltinIncomingForestTrustBuildersSid = 56;
	public const WellKnownSidType BuiltinPerformanceMonitoringUsersSid = 57;
	public const WellKnownSidType BuiltinPerformanceLoggingUsersSid = 58;
	public const WellKnownSidType BuiltinAuthorizationAccessSid = 59;
	public const WellKnownSidType WinBuiltinTerminalServerLicenseServersSid = 60;
	public const WellKnownSidType MaxDefined = 60;
	public const WellKnownSidType WinBuiltinDCOMUsersSid = 61;
	public const WellKnownSidType WinBuiltinIUsersSid = 62;
	public const WellKnownSidType WinIUserSid = 63;
	public const WellKnownSidType WinBuiltinCryptoOperatorsSid = 64;
	public const WellKnownSidType WinUntrustedLabelSid = 65;
	public const WellKnownSidType WinLowLabelSid = 66;
	public const WellKnownSidType WinMediumLabelSid = 67;
	public const WellKnownSidType WinHighLabelSid = 68;
	public const WellKnownSidType WinSystemLabelSid = 69;
	public const WellKnownSidType WinWriteRestrictedCodeSid = 70;
	public const WellKnownSidType WinCreatorOwnerRightsSid = 71;
	public const WellKnownSidType WinCacheablePrincipalsGroupSid = 72;
	public const WellKnownSidType WinNonCacheablePrincipalsGroupSid = 73;
	public const WellKnownSidType WinEnterpriseReadonlyControllersSid = 74;
	public const WellKnownSidType WinAccountReadonlyControllersSid = 75;
	public const WellKnownSidType WinBuiltinEventLogReadersGroup = 76;
	public const WellKnownSidType WinNewEnterpriseReadonlyControllersSid = 77;
	public const WellKnownSidType WinBuiltinCertSvcDComAccessGroup = 78;
	public const WellKnownSidType WinMediumPlusLabelSid = 79;
	public const WellKnownSidType WinLocalLogonSid = 80;
	public const WellKnownSidType WinConsoleLogonSid = 81;
	public const WellKnownSidType WinThisOrganizationCertificateSid = 82;
	public const WellKnownSidType WinApplicationPackageAuthoritySid = 83;
	public const WellKnownSidType WinBuiltinAnyPackageSid = 84;
	public const WellKnownSidType WinCapabilityInternetClientSid = 85;
	public const WellKnownSidType WinCapabilityInternetClientServerSid = 86;
	public const WellKnownSidType WinCapabilityPrivateNetworkClientServerSid = 87;
	public const WellKnownSidType WinCapabilityPicturesLibrarySid = 88;
	public const WellKnownSidType WinCapabilityVideosLibrarySid = 89;
	public const WellKnownSidType WinCapabilityMusicLibrarySid = 90;
	public const WellKnownSidType WinCapabilityDocumentsLibrarySid = 91;
	public const WellKnownSidType WinCapabilitySharedUserCertificatesSid = 92;
	public const WellKnownSidType WinCapabilityEnterpriseAuthenticationSid = 93;
	public const WellKnownSidType WinCapabilityRemovableStorageSid = 94;
}

// Namespace: System.Security.Principal
[ComVisible(True)]
[Serializable]
public enum WindowsAccountType // TypeDefIndex: 3651
{
	// Fields
	public int value__; // 0x0
	public const WindowsAccountType Normal = 0;
	public const WindowsAccountType Guest = 1;
	public const WindowsAccountType System = 2;
	public const WindowsAccountType Anonymous = 3;
}

// Namespace: System.Security.Principal
[ComVisible(True)]
[Serializable]
public class WindowsIdentity : ClaimsIdentity, IIdentity, IDeserializationCallback, ISerializable, IDisposable // TypeDefIndex: 3652
{
	// Fields
	private IntPtr _token; // 0x78
	private string _type; // 0x80
	private WindowsAccountType _account; // 0x88
	private bool _authenticated; // 0x8C
	private string _name; // 0x90
	private SerializationInfo _info; // 0x98
	private static IntPtr invalidWindows; // 0x0

	// Properties
	public sealed override string AuthenticationType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x1618940 Offset: 0x1617B40 VA: 0x181618940
	public void .ctor(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated) { }

	// RVA: 0x16189D0 Offset: 0x1617BD0 VA: 0x1816189D0
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1618A20 Offset: 0x1617C20 VA: 0x181618A20
	internal void .ctor(ClaimsIdentity claimsIdentity, IntPtr userToken) { }

	[ComVisible(False)]
	// RVA: 0x1618190 Offset: 0x1617390 VA: 0x181618190 Slot: 15
	public void Dispose() { }

	// RVA: 0x16181B0 Offset: 0x16173B0 VA: 0x1816181B0
	public static WindowsIdentity GetCurrent() { }

	// RVA: 0x1618280 Offset: 0x1617480 VA: 0x181618280 Slot: 16
	public virtual WindowsImpersonationContext Impersonate() { }

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830 Slot: 6
	public sealed override string get_AuthenticationType() { }

	// RVA: 0x1618A70 Offset: 0x1617C70 VA: 0x181618A70 Slot: 8
	public override string get_Name() { }

	// RVA: 0x1618490 Offset: 0x1617690 VA: 0x181618490 Slot: 13
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x16187C0 Offset: 0x16179C0 VA: 0x1816187C0 Slot: 14
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1601AE0 Offset: 0x1600CE0 VA: 0x181601AE0
	internal ClaimsIdentity CloneAsBase() { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	internal IntPtr GetTokenInternal() { }

	// RVA: 0x1618340 Offset: 0x1617540 VA: 0x181618340
	private void SetToken(IntPtr token) { }

	// RVA: 0x16181A0 Offset: 0x16173A0 VA: 0x1816181A0
	internal static IntPtr GetCurrentToken() { }

	// RVA: 0x1618270 Offset: 0x1617470 VA: 0x181618270
	private static string GetTokenName(IntPtr token) { }

	// RVA: 0x1618900 Offset: 0x1617B00 VA: 0x181618900
	private static void .cctor() { }
}

// Namespace: System.Security.Principal
[ComVisible(True)]
public class WindowsImpersonationContext : IDisposable // TypeDefIndex: 3653
{
	// Fields
	private IntPtr _token; // 0x10
	private bool undo; // 0x18

	// Methods

	// RVA: 0x1618C90 Offset: 0x1617E90 VA: 0x181618C90
	internal void .ctor(IntPtr token) { }

	[ComVisible(False)]
	// RVA: 0x1618AF0 Offset: 0x1617CF0 VA: 0x181618AF0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1618BE0 Offset: 0x1617DE0 VA: 0x181618BE0
	public void Undo() { }

	// RVA: 0x1618AE0 Offset: 0x1617CE0 VA: 0x181618AE0
	private static bool CloseToken(IntPtr token) { }

	// RVA: 0x1618BB0 Offset: 0x1617DB0 VA: 0x181618BB0
	private static IntPtr DuplicateToken(IntPtr token) { }

	// RVA: 0x1618BD0 Offset: 0x1617DD0 VA: 0x181618BD0
	private static bool SetCurrentToken(IntPtr token) { }

	// RVA: 0x1618BC0 Offset: 0x1617DC0 VA: 0x181618BC0
	private static bool RevertToSelf() { }
}

// Namespace: System.Security.Principal
[ComVisible(True)]
[Serializable]
public class WindowsPrincipal : ClaimsPrincipal // TypeDefIndex: 3654
{}

// Namespace: System.Security.Claims
[Serializable]
public class Claim // TypeDefIndex: 3655
{
	// Fields
	private string m_issuer; // 0x10
	private string m_originalIssuer; // 0x18
	private string m_type; // 0x20
	private string m_value; // 0x28
	private string m_valueType; // 0x30
	private byte[] m_userSerializationData; // 0x38
	private Dictionary<string, string> m_properties; // 0x40
	private object m_propertyLock; // 0x48
	private ClaimsIdentity m_subject; // 0x50

	// Properties
	public IDictionary<string, string> Properties { get; }
	public ClaimsIdentity Subject { get; set; }
	public string Type { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x16011D0 Offset: 0x16003D0 VA: 0x1816011D0
	public void .ctor(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject) { }

	// RVA: 0x16016A0 Offset: 0x16008A0 VA: 0x1816016A0
	internal void .ctor(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject, string propertyKey, string propertyValue) { }

	// RVA: 0x1601390 Offset: 0x1600590 VA: 0x181601390
	protected void .ctor(Claim other, ClaimsIdentity subject) { }

	[OnDeserialized]
	// RVA: 0x16010F0 Offset: 0x16002F0 VA: 0x1816010F0
	private void OnDeserializedMethod(StreamingContext context) { }

	// RVA: 0x1601900 Offset: 0x1600B00 VA: 0x181601900
	public IDictionary<string, string> get_Properties() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public ClaimsIdentity get_Subject() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	internal void set_Subject(ClaimsIdentity value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Type() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Value() { }

	// RVA: 0x1601080 Offset: 0x1600280 VA: 0x181601080 Slot: 4
	public virtual Claim Clone(ClaimsIdentity identity) { }

	// RVA: 0x1601150 Offset: 0x1600350 VA: 0x181601150 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ClaimsIdentity.<get_Claims>d__51 : IEnumerable<Claim>, IEnumerable, IEnumerator<Claim>, IDisposable, IEnumerator // TypeDefIndex: 3656
{
	// Fields
	private int <>1__state; // 0x10
	private Claim <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public ClaimsIdentity <>4__this; // 0x28
	private int <i>5__2; // 0x30
	private IEnumerator<Claim> <>7__wrap2; // 0x38

	// Properties
	private Claim System.Collections.Generic.IEnumerator<System.Security.Claims.Claim>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1615670 Offset: 0x1614870 VA: 0x181615670 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1615270 Offset: 0x1614470 VA: 0x181615270 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1615700 Offset: 0x1614900 VA: 0x181615700
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	private Claim System.Collections.Generic.IEnumerator<System.Security.Claims.Claim>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1615630 Offset: 0x1614830 VA: 0x181615630 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1615590 Offset: 0x1614790 VA: 0x181615590 Slot: 4
	private IEnumerator<Claim> System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1615590 Offset: 0x1614790 VA: 0x181615590 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: System.Security.Claims
[ComVisible(True)]
[Serializable]
public class ClaimsIdentity : IIdentity // TypeDefIndex: 3657
{
	// Fields
	private byte[] m_userSerializationData; // 0x10
	private List<Claim> m_instanceClaims; // 0x18
	private Collection<IEnumerable<Claim>> m_externalClaims; // 0x20
	private string m_nameType; // 0x28
	private string m_roleType; // 0x30
	[OptionalField(VersionAdded = 2)]
	private string m_version; // 0x38
	[OptionalField(VersionAdded = 2)]
	private ClaimsIdentity m_actor; // 0x40
	[OptionalField(VersionAdded = 2)]
	private string m_authenticationType; // 0x48
	[OptionalField(VersionAdded = 2)]
	private object m_bootstrapContext; // 0x50
	[OptionalField(VersionAdded = 2)]
	private string m_label; // 0x58
	[OptionalField(VersionAdded = 2)]
	private string m_serializedNameType; // 0x60
	[OptionalField(VersionAdded = 2)]
	private string m_serializedRoleType; // 0x68
	[OptionalField(VersionAdded = 2)]
	private string m_serializedClaims; // 0x70

	// Properties
	public virtual string AuthenticationType { get; }
	public ClaimsIdentity Actor { get; set; }
	public virtual IEnumerable<Claim> Claims { get; }
	public virtual string Name { get; }
	public string NameClaimType { get; }

	// Methods

	// RVA: 0x1603300 Offset: 0x1602500 VA: 0x181603300
	public void .ctor() { }

	// RVA: 0x16032D0 Offset: 0x16024D0 VA: 0x1816032D0
	public void .ctor(IEnumerable<Claim> claims) { }

	// RVA: 0x1603B10 Offset: 0x1602D10 VA: 0x181603B10
	public void .ctor(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType) { }

	// RVA: 0x16034B0 Offset: 0x16026B0 VA: 0x1816034B0
	internal void .ctor(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType, bool checkAuthType) { }

	// RVA: 0x1603B40 Offset: 0x1602D40 VA: 0x181603B40
	protected void .ctor(ClaimsIdentity other) { }

	// RVA: 0x1603330 Offset: 0x1602530 VA: 0x181603330
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0 Slot: 6
	public virtual string get_AuthenticationType() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public ClaimsIdentity get_Actor() { }

	// RVA: 0x1603DD0 Offset: 0x1602FD0 VA: 0x181603DD0
	public void set_Actor(ClaimsIdentity value) { }

	[IteratorStateMachine(typeof(ClaimsIdentity.<get_Claims>d__51))]
	// RVA: 0x1603D30 Offset: 0x1602F30 VA: 0x181603D30 Slot: 7
	public virtual IEnumerable<Claim> get_Claims() { }

	// RVA: 0x1603DA0 Offset: 0x1602FA0 VA: 0x181603DA0 Slot: 8
	public virtual string get_Name() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_NameClaimType() { }

	// RVA: 0x1601AE0 Offset: 0x1600CE0 VA: 0x181601AE0 Slot: 9
	public virtual ClaimsIdentity Clone() { }

	// RVA: 0x1601A00 Offset: 0x1600C00 VA: 0x181601A00 Slot: 10
	public virtual void AddClaim(Claim claim) { }

	// RVA: 0x1602F00 Offset: 0x1602100 VA: 0x181602F00
	private void SafeAddClaims(IEnumerable<Claim> claims) { }

	// RVA: 0x1602DC0 Offset: 0x1601FC0 VA: 0x181602DC0
	private void SafeAddClaim(Claim claim) { }

	// RVA: 0x1602510 Offset: 0x1601710 VA: 0x181602510 Slot: 11
	public virtual Claim FindFirst(string type) { }

	[OnSerializing]
	// RVA: 0x1602D60 Offset: 0x1601F60 VA: 0x181602D60
	private void OnSerializingMethod(StreamingContext context) { }

	[OnDeserialized]
	// RVA: 0x1602BE0 Offset: 0x1601DE0 VA: 0x181602BE0
	private void OnDeserializedMethod(StreamingContext context) { }

	[OnDeserializing]
	// RVA: 0x1602CA0 Offset: 0x1601EA0 VA: 0x181602CA0
	private void OnDeserializingMethod(StreamingContext context) { }

	// RVA: 0x1602700 Offset: 0x1601900 VA: 0x181602700 Slot: 12
	protected virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1601C80 Offset: 0x1600E80 VA: 0x181601C80
	private void DeserializeClaims(string serializedClaims) { }

	// RVA: 0x1603120 Offset: 0x1602320 VA: 0x181603120
	private string SerializeClaims() { }

	// RVA: 0x1602B90 Offset: 0x1601D90 VA: 0x181602B90
	private bool IsCircular(ClaimsIdentity subject) { }

	// RVA: 0x1601F40 Offset: 0x1601140 VA: 0x181601F40
	private void Deserialize(SerializationInfo info, StreamingContext context, bool useContext) { }
}

// Namespace: System.Security.Claims
[ComVisible(True)]
[Serializable]
public class ClaimsPrincipal : IPrincipal // TypeDefIndex: 3658
{
	// Fields
	[OptionalField(VersionAdded = 2)]
	private string m_version; // 0x10
	[OptionalField(VersionAdded = 2)]
	private string m_serializedClaimsIdentities; // 0x18
	private List<ClaimsIdentity> m_identities; // 0x20
	private static Func<IEnumerable<ClaimsIdentity>, ClaimsIdentity> s_identitySelector; // 0x0
	private static Func<ClaimsPrincipal> s_principalSelector; // 0x8

	// Properties
	public static Func<ClaimsPrincipal> ClaimsPrincipalSelector { get; }
	public virtual IIdentity Identity { get; }

	// Methods

	// RVA: 0x1604530 Offset: 0x1603730 VA: 0x181604530
	private static ClaimsIdentity SelectPrimaryIdentity(IEnumerable<ClaimsIdentity> identities) { }

	// RVA: 0x1605200 Offset: 0x1604400 VA: 0x181605200
	public static Func<ClaimsPrincipal> get_ClaimsPrincipalSelector() { }

	// RVA: 0x1605170 Offset: 0x1604370 VA: 0x181605170
	public void .ctor() { }

	// RVA: 0x1604FB0 Offset: 0x16041B0 VA: 0x181604FB0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	[OnSerializing]
	// RVA: 0x16044E0 Offset: 0x16036E0 VA: 0x1816044E0
	private void OnSerializingMethod(StreamingContext context) { }

	[OnDeserialized]
	// RVA: 0x1604480 Offset: 0x1603680 VA: 0x181604480
	private void OnDeserializedMethod(StreamingContext context) { }

	// RVA: 0x1604330 Offset: 0x1603530 VA: 0x181604330
	private void Deserialize(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1603E80 Offset: 0x1603080 VA: 0x181603E80
	private void DeserializeIdentities(string identities) { }

	// RVA: 0x16047C0 Offset: 0x16039C0 VA: 0x1816047C0
	private string SerializeIdentities() { }

	// RVA: 0x1605250 Offset: 0x1604450 VA: 0x181605250 Slot: 5
	public virtual IIdentity get_Identity() { }

	// RVA: 0x1604F00 Offset: 0x1604100 VA: 0x181604F00
	private static void .cctor() { }
}

// Namespace: System.Security.AccessControl
[Serializable]
public sealed class PrivilegeNotHeldException : UnauthorizedAccessException, ISerializable // TypeDefIndex: 3659
{
	// Fields
	private readonly string _privilegeName; // 0x90

	// Methods

	// RVA: 0x160F660 Offset: 0x160E860 VA: 0x18160F660
	public void .ctor() { }

	// RVA: 0x160F5D0 Offset: 0x160E7D0 VA: 0x18160F5D0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x160F500 Offset: 0x160E700 VA: 0x18160F500 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Security.AccessControl
public enum AccessControlModification // TypeDefIndex: 3660
{
	// Fields
	public int value__; // 0x0
	public const AccessControlModification Add = 0;
	public const AccessControlModification Set = 1;
	public const AccessControlModification Reset = 2;
	public const AccessControlModification Remove = 3;
	public const AccessControlModification RemoveAll = 4;
	public const AccessControlModification RemoveSpecific = 5;
}

// Namespace: System.Security.AccessControl
[Flags]
public enum AccessControlSections // TypeDefIndex: 3661
{
	// Fields
	public int value__; // 0x0
	public const AccessControlSections None = 0;
	public const AccessControlSections Audit = 1;
	public const AccessControlSections Access = 2;
	public const AccessControlSections Owner = 4;
	public const AccessControlSections Group = 8;
	public const AccessControlSections All = 15;
}

// Namespace: System.Security.AccessControl
public enum AccessControlType // TypeDefIndex: 3662
{
	// Fields
	public int value__; // 0x0
	public const AccessControlType Allow = 0;
	public const AccessControlType Deny = 1;
}

// Namespace: System.Security.AccessControl
public abstract class AccessRule : AuthorizationRule // TypeDefIndex: 3663
{
	// Fields
	private AccessControlType type; // 0x28

	// Properties
	public AccessControlType AccessControlType { get; }

	// Methods

	// RVA: 0x1600C40 Offset: 0x15FFE40 VA: 0x181600C40
	protected void .ctor(IdentityReference identity, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type) { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public AccessControlType get_AccessControlType() { }
}

// Namespace: System.Security.AccessControl
public sealed class AceEnumerator : IEnumerator // TypeDefIndex: 3664
{
	// Fields
	private GenericAcl owner; // 0x10
	private int current; // 0x18

	// Properties
	public GenericAce Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x1600D80 Offset: 0x15FFF80 VA: 0x181600D80
	internal void .ctor(GenericAcl owner) { }

	// RVA: 0x1600D40 Offset: 0x15FFF40 VA: 0x181600D40
	public GenericAce get_Current() { }

	// RVA: 0x1600D40 Offset: 0x15FFF40 VA: 0x181600D40 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1600CE0 Offset: 0x15FFEE0 VA: 0x181600CE0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x112DE90 Offset: 0x112D090 VA: 0x18112DE90 Slot: 6
	public void Reset() { }
}

// Namespace: System.Security.AccessControl
[Flags]
public enum AceFlags // TypeDefIndex: 3665
{
	// Fields
	public byte value__; // 0x0
	public const AceFlags None = 0;
	public const AceFlags ObjectInherit = 1;
	public const AceFlags ContainerInherit = 2;
	public const AceFlags NoPropagateInherit = 4;
	public const AceFlags InheritOnly = 8;
	public const AceFlags InheritanceFlags = 15;
	public const AceFlags Inherited = 16;
	public const AceFlags SuccessfulAccess = 64;
	public const AceFlags FailedAccess = 128;
	public const AceFlags AuditFlags = 192;
}

// Namespace: System.Security.AccessControl
public enum AceQualifier // TypeDefIndex: 3666
{
	// Fields
	public int value__; // 0x0
	public const AceQualifier AccessAllowed = 0;
	public const AceQualifier AccessDenied = 1;
	public const AceQualifier SystemAudit = 2;
	public const AceQualifier SystemAlarm = 3;
}

// Namespace: System.Security.AccessControl
public enum AceType // TypeDefIndex: 3667
{
	// Fields
	public byte value__; // 0x0
	public const AceType AccessAllowed = 0;
	public const AceType AccessDenied = 1;
	public const AceType SystemAudit = 2;
	public const AceType SystemAlarm = 3;
	public const AceType AccessAllowedCompound = 4;
	public const AceType AccessAllowedObject = 5;
	public const AceType AccessDeniedObject = 6;
	public const AceType SystemAuditObject = 7;
	public const AceType SystemAlarmObject = 8;
	public const AceType AccessAllowedCallback = 9;
	public const AceType AccessDeniedCallback = 10;
	public const AceType AccessAllowedCallbackObject = 11;
	public const AceType AccessDeniedCallbackObject = 12;
	public const AceType SystemAuditCallback = 13;
	public const AceType SystemAlarmCallback = 14;
	public const AceType SystemAuditCallbackObject = 15;
	public const AceType SystemAlarmCallbackObject = 16;
	public const AceType MaxDefinedAceType = 16;
}

// Namespace: System.Security.AccessControl
[Flags]
public enum AuditFlags // TypeDefIndex: 3668
{
	// Fields
	public int value__; // 0x0
	public const AuditFlags None = 0;
	public const AuditFlags Success = 1;
	public const AuditFlags Failure = 2;
}

// Namespace: System.Security.AccessControl
public abstract class AuditRule : AuthorizationRule // TypeDefIndex: 3669
{
	// Fields
	private AuditFlags auditFlags; // 0x28

	// Properties
	public AuditFlags AuditFlags { get; }

	// Methods

	// RVA: 0x1600DB0 Offset: 0x15FFFB0 VA: 0x181600DB0
	protected void .ctor(IdentityReference identity, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags auditFlags) { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public AuditFlags get_AuditFlags() { }
}

// Namespace: System.Security.AccessControl
public abstract class AuthorizationRule // TypeDefIndex: 3670
{
	// Fields
	private IdentityReference identity; // 0x10
	private int accessMask; // 0x18
	private bool isInherited; // 0x1C
	private InheritanceFlags inheritanceFlags; // 0x20
	private PropagationFlags propagationFlags; // 0x24

	// Properties
	public IdentityReference IdentityReference { get; }
	public InheritanceFlags InheritanceFlags { get; }
	public PropagationFlags PropagationFlags { get; }
	protected internal int AccessMask { get; }

	// Methods

	// RVA: 0x1600E60 Offset: 0x1600060 VA: 0x181600E60
	protected internal void .ctor(IdentityReference identity, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IdentityReference get_IdentityReference() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public InheritanceFlags get_InheritanceFlags() { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public PropagationFlags get_PropagationFlags() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	protected internal int get_AccessMask() { }
}

// Namespace: System.Security.AccessControl
public sealed class CommonAce : QualifiedAce // TypeDefIndex: 3671
{
	// Properties
	public override int BinaryLength { get; }

	// Methods

	// RVA: 0x1605600 Offset: 0x1604800 VA: 0x181605600
	public void .ctor(AceFlags flags, AceQualifier qualifier, int accessMask, SecurityIdentifier sid, bool isCallback, byte[] opaque) { }

	// RVA: 0x1605760 Offset: 0x1604960 VA: 0x181605760
	internal void .ctor(byte[] binaryForm, int offset) { }

	// RVA: 0x1605A10 Offset: 0x1604C10 VA: 0x181605A10 Slot: 4
	public override int get_BinaryLength() { }

	// RVA: 0x1605420 Offset: 0x1604620 VA: 0x181605420 Slot: 5
	public override void GetBinaryForm(byte[] binaryForm, int offset) { }

	// RVA: 0x1605310 Offset: 0x1604510 VA: 0x181605310
	private static AceType ConvertType(AceQualifier qualifier, bool isCallback) { }
}

// Namespace: 
internal sealed class CommonAcl.RemoveAcesCallback<T> : MulticastDelegate // TypeDefIndex: 3672
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB86840 Offset: 0xB85A40 VA: 0x180B86840
	|-CommonAcl.RemoveAcesCallback<object>..ctor
	|
	|-RVA: 0xB872C0 Offset: 0xB864C0 VA: 0x180B872C0
	|-CommonAcl.RemoveAcesCallback<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual bool Invoke(T ace) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250
	|-CommonAcl.RemoveAcesCallback<object>.Invoke
	|-CommonAcl.RemoveAcesCallback<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class CommonAcl.<>c__DisplayClass30_0 // TypeDefIndex: 3673
{
	// Fields
	public SecurityIdentifier sid; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1614F40 Offset: 0x1614140 VA: 0x181614F40
	internal bool <Purge>b__0(KnownAce ace) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CommonAcl.<>c__DisplayClass53_0 // TypeDefIndex: 3674
{
	// Fields
	public int accessMask; // 0x10
	public AceQualifier aceQualifier; // 0x14
	public SecurityIdentifier sid; // 0x18
	public InheritanceFlags inheritanceFlags; // 0x20
	public PropagationFlags propagationFlags; // 0x24
	public AuditFlags auditFlags; // 0x28

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1615010 Offset: 0x1614210 VA: 0x181615010
	internal bool <RemoveAceSpecific>b__0(CommonAce ace) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CommonAcl.<>c__DisplayClass57_0 // TypeDefIndex: 3675
{
	// Fields
	public QualifiedAce newAce; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1615160 Offset: 0x1614360 VA: 0x181615160
	internal bool <SetAce>b__0(QualifiedAce oldAce) { }
}

// Namespace: System.Security.AccessControl
[DefaultMember("Item")]
public abstract class CommonAcl : GenericAcl // TypeDefIndex: 3676
{
	// Fields
	private bool is_aefa; // 0x10
	private bool is_canonical; // 0x11
	private bool is_container; // 0x12
	private bool is_ds; // 0x13
	internal RawAcl raw_acl; // 0x18

	// Properties
	public sealed override int BinaryLength { get; }
	public sealed override int Count { get; }
	public bool IsCanonical { get; }
	public bool IsContainer { get; }
	public bool IsDS { get; }
	internal bool IsAefa { set; }
	public sealed override byte Revision { get; }
	public sealed override GenericAce Item { get; set; }

	// Methods

	// RVA: 0x1607BA0 Offset: 0x1606DA0 VA: 0x181607BA0
	internal void .ctor(bool isContainer, bool isDS, RawAcl rawAcl) { }

	// RVA: 0x1607AD0 Offset: 0x1606CD0 VA: 0x181607AD0
	internal void .ctor(bool isContainer, bool isDS, byte revision, int capacity) { }

	// RVA: 0x16079A0 Offset: 0x1606BA0 VA: 0x1816079A0
	internal void .ctor(bool isContainer, bool isDS, int capacity) { }

	// RVA: 0x16067A0 Offset: 0x16059A0 VA: 0x1816067A0
	private void Init(bool isContainer, bool isDS, RawAcl rawAcl) { }

	// RVA: 0x157DBC0 Offset: 0x157CDC0 VA: 0x18157DBC0 Slot: 9
	public sealed override int get_BinaryLength() { }

	// RVA: 0x1607D40 Offset: 0x1606F40 VA: 0x181607D40 Slot: 10
	public sealed override int get_Count() { }

	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0
	public bool get_IsCanonical() { }

	// RVA: 0x7D0D10 Offset: 0x7CFF10 VA: 0x1807D0D10
	public bool get_IsContainer() { }

	// RVA: 0x7F2E20 Offset: 0x7F2020 VA: 0x1807F2E20
	public bool get_IsDS() { }

	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	internal void set_IsAefa(bool value) { }

	// RVA: 0x1607E30 Offset: 0x1607030 VA: 0x181607E30 Slot: 13
	public sealed override byte get_Revision() { }

	// RVA: 0x1607D70 Offset: 0x1606F70 VA: 0x181607D70 Slot: 11
	public sealed override GenericAce get_Item(int index) { }

	// RVA: 0x1607E60 Offset: 0x1607060 VA: 0x181607E60 Slot: 12
	public sealed override void set_Item(int index, GenericAce value) { }

	// RVA: 0x16064F0 Offset: 0x16056F0 VA: 0x1816064F0 Slot: 15
	public sealed override void GetBinaryForm(byte[] binaryForm, int offset) { }

	// RVA: 0x1607050 Offset: 0x1606250 VA: 0x181607050
	public void Purge(SecurityIdentifier sid) { }

	// RVA: 0x16072D0 Offset: 0x16064D0 VA: 0x1816072D0
	internal void RequireCanonicity() { }

	// RVA: 0x1606160 Offset: 0x1605360 VA: 0x181606160
	internal void CanonicalizeAndClearAefa() { }

	// RVA: 0x16067C0 Offset: 0x16059C0 VA: 0x1816067C0 Slot: 16
	internal virtual bool IsAceMeaningless(GenericAce ace) { }

	// RVA: 0x16075D0 Offset: 0x16067D0 VA: 0x1816075D0
	private bool TestCanonicity() { }

	// RVA: 0x16065A0 Offset: 0x16057A0 VA: 0x1816065A0
	internal int GetCanonicalExplicitDenyAceCount() { }

	// RVA: 0x1606520 Offset: 0x1605720 VA: 0x181606520
	internal int GetCanonicalExplicitAceCount() { }

	// RVA: 0x1606F40 Offset: 0x1606140 VA: 0x181606F40
	private void MergeExplicitAces() { }

	// RVA: 0x16068D0 Offset: 0x1605AD0 VA: 0x1816068D0
	private GenericAce MergeExplicitAcePair(GenericAce ace1, GenericAce ace2) { }

	// RVA: 0x1606700 Offset: 0x1605900 VA: 0x181606700
	private static void GetObjectAceTypeGuids(ObjectAce ace, out Guid type, out Guid inheritedType) { }

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract void ApplyCanonicalSortToExplicitAces();

	// RVA: 0x1605F50 Offset: 0x1605150 VA: 0x181605F50
	internal void ApplyCanonicalSortToExplicitAces(int start, int count) { }

	// RVA: -1 Offset: -1
	internal void RemoveAces<T>(CommonAcl.RemoveAcesCallback<T> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94CC30 Offset: 0x94BE30 VA: 0x18094CC30
	|-CommonAcl.RemoveAces<object>
	*/

	// RVA: 0x1605F00 Offset: 0x1605100 VA: 0x181605F00
	internal void AddAce(AceQualifier aceQualifier, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags auditFlags) { }

	// RVA: 0x1605A60 Offset: 0x1604C60 VA: 0x181605A60
	private QualifiedAce AddAceGetQualifiedAce(AceQualifier aceQualifier, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags auditFlags) { }

	// RVA: 0x1605D00 Offset: 0x1604F00 VA: 0x181605D00
	private void AddAce(QualifiedAce newAce) { }

	// RVA: 0x1606310 Offset: 0x1605510 VA: 0x181606310
	private static GenericAce CopyAce(GenericAce ace) { }

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract int GetAceInsertPosition(AceQualifier aceQualifier);

	// RVA: 0x16063A0 Offset: 0x16055A0 VA: 0x1816063A0
	private AceFlags GetAceFlags(InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags auditFlags) { }

	// RVA: 0x1607170 Offset: 0x1606370 VA: 0x181607170
	internal void RemoveAceSpecific(AceQualifier aceQualifier, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags auditFlags) { }

	// RVA: 0x1607470 Offset: 0x1606670 VA: 0x181607470
	internal void SetAce(AceQualifier aceQualifier, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags auditFlags) { }

	// RVA: 0x1607340 Offset: 0x1606540 VA: 0x181607340
	private void SetAce(QualifiedAce newAce) { }
}

// Namespace: System.Security.AccessControl
public abstract class CommonObjectSecurity : ObjectSecurity // TypeDefIndex: 3677
{
	// Methods

	// RVA: 0x1608CD0 Offset: 0x1607ED0 VA: 0x181608CD0
	protected void .ctor(bool isContainer) { }

	// RVA: 0x1607EA0 Offset: 0x16070A0 VA: 0x181607EA0
	protected void AddAccessRule(AccessRule rule) { }

	// RVA: 0x1608B10 Offset: 0x1607D10 VA: 0x181608B10
	protected bool RemoveAccessRule(AccessRule rule) { }

	// RVA: 0x1608A90 Offset: 0x1607C90 VA: 0x181608A90
	protected void RemoveAccessRuleAll(AccessRule rule) { }

	// RVA: 0x1608AD0 Offset: 0x1607CD0 VA: 0x181608AD0
	protected void RemoveAccessRuleSpecific(AccessRule rule) { }

	// RVA: 0x1608C10 Offset: 0x1607E10 VA: 0x181608C10
	protected void ResetAccessRule(AccessRule rule) { }

	// RVA: 0x1608C50 Offset: 0x1607E50 VA: 0x181608C50
	protected void SetAccessRule(AccessRule rule) { }

	// RVA: 0x1607F20 Offset: 0x1607120 VA: 0x181607F20 Slot: 11
	protected override bool ModifyAccess(AccessControlModification modification, AccessRule rule, out bool modified) { }

	// RVA: 0x1607EE0 Offset: 0x16070E0 VA: 0x181607EE0
	protected void AddAuditRule(AuditRule rule) { }

	// RVA: 0x1608BD0 Offset: 0x1607DD0 VA: 0x181608BD0
	protected bool RemoveAuditRule(AuditRule rule) { }

	// RVA: 0x1608B50 Offset: 0x1607D50 VA: 0x181608B50
	protected void RemoveAuditRuleAll(AuditRule rule) { }

	// RVA: 0x1608B90 Offset: 0x1607D90 VA: 0x181608B90
	protected void RemoveAuditRuleSpecific(AuditRule rule) { }

	// RVA: 0x1608C90 Offset: 0x1607E90 VA: 0x181608C90
	protected void SetAuditRule(AuditRule rule) { }

	// RVA: 0x16085F0 Offset: 0x16077F0 VA: 0x1816085F0 Slot: 12
	protected override bool ModifyAudit(AccessControlModification modification, AuditRule rule, out bool modified) { }
}

// Namespace: System.Security.AccessControl
public sealed class CommonSecurityDescriptor : GenericSecurityDescriptor // TypeDefIndex: 3678
{
	// Fields
	private bool is_container; // 0x10
	private bool is_ds; // 0x11
	private ControlFlags flags; // 0x14
	private SecurityIdentifier owner; // 0x18
	private SecurityIdentifier group; // 0x20
	private SystemAcl system_acl; // 0x28
	private DiscretionaryAcl discretionary_acl; // 0x30

	// Properties
	public override ControlFlags ControlFlags { get; }
	public DiscretionaryAcl DiscretionaryAcl { get; set; }
	public override SecurityIdentifier Group { get; set; }
	public bool IsContainer { get; }
	public bool IsDS { get; }
	public override SecurityIdentifier Owner { get; set; }
	public SystemAcl SystemAcl { get; set; }

	// Methods

	// RVA: 0x1609430 Offset: 0x1608630 VA: 0x181609430
	public void .ctor(bool isContainer, bool isDS, byte[] binaryForm, int offset) { }

	// RVA: 0x16094E0 Offset: 0x16086E0 VA: 0x1816094E0
	public void .ctor(bool isContainer, bool isDS, ControlFlags flags, SecurityIdentifier owner, SecurityIdentifier group, SystemAcl systemAcl, DiscretionaryAcl discretionaryAcl) { }

	// RVA: 0x1608DB0 Offset: 0x1607FB0 VA: 0x181608DB0
	private void Init(bool isContainer, bool isDS, RawSecurityDescriptor rawSecurityDescriptor) { }

	// RVA: 0x16091D0 Offset: 0x16083D0 VA: 0x1816091D0
	private void Init(bool isContainer, bool isDS, ControlFlags flags, SecurityIdentifier owner, SecurityIdentifier group, SystemAcl systemAcl, DiscretionaryAcl discretionaryAcl) { }

	// RVA: 0x1609710 Offset: 0x1608910 VA: 0x181609710 Slot: 4
	public override ControlFlags get_ControlFlags() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public DiscretionaryAcl get_DiscretionaryAcl() { }

	// RVA: 0x1609730 Offset: 0x1608930 VA: 0x181609730
	public void set_DiscretionaryAcl(DiscretionaryAcl value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 5
	public override SecurityIdentifier get_Group() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0 Slot: 6
	public override void set_Group(SecurityIdentifier value) { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_IsContainer() { }

	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0
	public bool get_IsDS() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	public override SecurityIdentifier get_Owner() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70 Slot: 8
	public override void set_Owner(SecurityIdentifier value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public SystemAcl get_SystemAcl() { }

	// RVA: 0x16098E0 Offset: 0x1608AE0 VA: 0x1816098E0
	public void set_SystemAcl(SystemAcl value) { }

	// RVA: 0x16093F0 Offset: 0x16085F0 VA: 0x1816093F0
	public void PurgeAccessControl(SecurityIdentifier sid) { }

	// RVA: 0x1609410 Offset: 0x1608610 VA: 0x181609410
	public void PurgeAudit(SecurityIdentifier sid) { }

	// RVA: 0x1608CE0 Offset: 0x1607EE0 VA: 0x181608CE0
	private void CheckAclConsistency(CommonAcl acl) { }
}

// Namespace: System.Security.AccessControl
[Flags]
public enum ControlFlags // TypeDefIndex: 3679
{
	// Fields
	public int value__; // 0x0
	public const ControlFlags None = 0;
	public const ControlFlags OwnerDefaulted = 1;
	public const ControlFlags GroupDefaulted = 2;
	public const ControlFlags DiscretionaryAclPresent = 4;
	public const ControlFlags DiscretionaryAclDefaulted = 8;
	public const ControlFlags SystemAclPresent = 16;
	public const ControlFlags SystemAclDefaulted = 32;
	public const ControlFlags DiscretionaryAclUntrusted = 64;
	public const ControlFlags ServerSecurity = 128;
	public const ControlFlags DiscretionaryAclAutoInheritRequired = 256;
	public const ControlFlags SystemAclAutoInheritRequired = 512;
	public const ControlFlags DiscretionaryAclAutoInherited = 1024;
	public const ControlFlags SystemAclAutoInherited = 2048;
	public const ControlFlags DiscretionaryAclProtected = 4096;
	public const ControlFlags SystemAclProtected = 8192;
	public const ControlFlags RMControlValid = 16384;
	public const ControlFlags SelfRelative = 32768;
}

// Namespace: System.Security.AccessControl
public sealed class DiscretionaryAcl : CommonAcl // TypeDefIndex: 3680
{
	// Methods

	// RVA: 0x16079A0 Offset: 0x1606BA0 VA: 0x1816079A0
	public void .ctor(bool isContainer, bool isDS, int capacity) { }

	// RVA: 0x1607BA0 Offset: 0x1606DA0 VA: 0x181607BA0
	public void .ctor(bool isContainer, bool isDS, RawAcl rawAcl) { }

	// RVA: 0x1609970 Offset: 0x1608B70 VA: 0x181609970
	public void AddAccess(AccessControlType accessType, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags) { }

	[MonoTODO]
	// RVA: 0x1609E80 Offset: 0x1609080 VA: 0x181609E80
	public bool RemoveAccess(AccessControlType accessType, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags) { }

	// RVA: 0x1609CC0 Offset: 0x1608EC0 VA: 0x181609CC0
	public void RemoveAccessSpecific(AccessControlType accessType, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags) { }

	// RVA: 0x1609EC0 Offset: 0x16090C0 VA: 0x181609EC0
	public void SetAccess(AccessControlType accessType, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags) { }

	// RVA: 0x1609A10 Offset: 0x1608C10 VA: 0x181609A10 Slot: 17
	internal override void ApplyCanonicalSortToExplicitAces() { }

	// RVA: 0x1609A70 Offset: 0x1608C70 VA: 0x181609A70 Slot: 18
	internal override int GetAceInsertPosition(AceQualifier aceQualifier) { }

	// RVA: 0x1609A80 Offset: 0x1608C80 VA: 0x181609A80
	private static AceQualifier GetAceQualifier(AccessControlType accessType) { }

	// RVA: 0x1609AF0 Offset: 0x1608CF0 VA: 0x181609AF0 Slot: 16
	internal override bool IsAceMeaningless(GenericAce ace) { }
}

// Namespace: System.Security.AccessControl
public abstract class GenericAce // TypeDefIndex: 3681
{
	// Fields
	private AceFlags ace_flags; // 0x10
	private AceType ace_type; // 0x11

	// Properties
	public AceFlags AceFlags { get; }
	public AceType AceType { get; }
	public AuditFlags AuditFlags { get; }
	public abstract int BinaryLength { get; }
	public InheritanceFlags InheritanceFlags { get; }
	public bool IsInherited { get; }
	public PropagationFlags PropagationFlags { get; }

	// Methods

	// RVA: 0x160A6F0 Offset: 0x16098F0 VA: 0x18160A6F0
	internal void .ctor(AceType type, AceFlags flags) { }

	// RVA: 0x160A5B0 Offset: 0x16097B0 VA: 0x18160A5B0
	internal void .ctor(byte[] binaryForm, int offset) { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public AceFlags get_AceFlags() { }

	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0
	public AceType get_AceType() { }

	// RVA: 0x160A780 Offset: 0x1609980 VA: 0x18160A780
	public AuditFlags get_AuditFlags() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_BinaryLength();

	// RVA: 0x160A7A0 Offset: 0x16099A0 VA: 0x18160A7A0
	public InheritanceFlags get_InheritanceFlags() { }

	// RVA: 0x160A7C0 Offset: 0x16099C0 VA: 0x18160A7C0
	public bool get_IsInherited() { }

	// RVA: 0x160A7D0 Offset: 0x16099D0 VA: 0x18160A7D0
	public PropagationFlags get_PropagationFlags() { }

	// RVA: 0x160A110 Offset: 0x1609310 VA: 0x18160A110
	public static GenericAce CreateFromBinaryForm(byte[] binaryForm, int offset) { }

	// RVA: 0x160A2D0 Offset: 0x16094D0 VA: 0x18160A2D0 Slot: 0
	public sealed override bool Equals(object o) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void GetBinaryForm(byte[] binaryForm, int offset);

	// RVA: 0x160A360 Offset: 0x1609560 VA: 0x18160A360 Slot: 2
	public sealed override int GetHashCode() { }

	// RVA: 0x160A7F0 Offset: 0x16099F0 VA: 0x18160A7F0
	public static bool op_Equality(GenericAce left, GenericAce right) { }

	// RVA: 0x160A960 Offset: 0x1609B60 VA: 0x18160A960
	public static bool op_Inequality(GenericAce left, GenericAce right) { }

	// RVA: 0x160A430 Offset: 0x1609630 VA: 0x18160A430
	private static bool IsObjectType(AceType type) { }

	// RVA: 0x160A4C0 Offset: 0x16096C0 VA: 0x18160A4C0
	internal static ushort ReadUShort(byte[] buffer, int offset) { }

	// RVA: 0x160A450 Offset: 0x1609650 VA: 0x18160A450
	internal static int ReadInt(byte[] buffer, int offset) { }

	// RVA: 0x160A500 Offset: 0x1609700 VA: 0x18160A500
	internal static void WriteInt(int val, byte[] buffer, int offset) { }

	// RVA: 0x160A570 Offset: 0x1609770 VA: 0x18160A570
	internal static void WriteUShort(ushort val, byte[] buffer, int offset) { }
}

// Namespace: System.Security.AccessControl
[DefaultMember("Item")]
public abstract class GenericAcl : ICollection, IEnumerable // TypeDefIndex: 3682
{
	// Fields
	public static readonly byte AclRevision; // 0x0
	public static readonly byte AclRevisionDS; // 0x1
	public static readonly int MaxBinaryLength; // 0x4

	// Properties
	public abstract int BinaryLength { get; }
	public abstract int Count { get; }
	public bool IsSynchronized { get; }
	public abstract GenericAce Item { get; set; }
	public abstract byte Revision { get; }
	public virtual object SyncRoot { get; }

	// Methods

	// RVA: 0x160AD80 Offset: 0x1609F80 VA: 0x18160AD80
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int get_BinaryLength();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int get_Count();

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract GenericAce get_Item(int index);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void set_Item(int index, GenericAce value);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract byte get_Revision();

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 14
	public virtual object get_SyncRoot() { }

	// RVA: 0x160AAD0 Offset: 0x1609CD0 VA: 0x18160AAD0
	public void CopyTo(GenericAce[] array, int index) { }

	// RVA: 0x160ACF0 Offset: 0x1609EF0 VA: 0x18160ACF0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void GetBinaryForm(byte[] binaryForm, int offset);

	// RVA: 0x160AC90 Offset: 0x1609E90 VA: 0x18160AC90
	public AceEnumerator GetEnumerator() { }

	// RVA: 0x160AC90 Offset: 0x1609E90 VA: 0x18160AC90 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: System.Security.AccessControl
public abstract class GenericSecurityDescriptor // TypeDefIndex: 3683
{
	// Properties
	public abstract ControlFlags ControlFlags { get; }
	public abstract SecurityIdentifier Group { get; set; }
	public abstract SecurityIdentifier Owner { get; set; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ControlFlags get_ControlFlags();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract SecurityIdentifier get_Group();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void set_Group(SecurityIdentifier value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract SecurityIdentifier get_Owner();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void set_Owner(SecurityIdentifier value);
}

// Namespace: System.Security.AccessControl
[Flags]
public enum InheritanceFlags // TypeDefIndex: 3684
{
	// Fields
	public int value__; // 0x0
	public const InheritanceFlags None = 0;
	public const InheritanceFlags ContainerInherit = 1;
	public const InheritanceFlags ObjectInherit = 2;
}

// Namespace: System.Security.AccessControl
public abstract class KnownAce : GenericAce // TypeDefIndex: 3685
{
	// Fields
	private int access_mask; // 0x18
	private SecurityIdentifier identifier; // 0x20

	// Properties
	public int AccessMask { get; set; }
	public SecurityIdentifier SecurityIdentifier { get; set; }

	// Methods

	// RVA: 0x160A6F0 Offset: 0x16098F0 VA: 0x18160A6F0
	internal void .ctor(AceType type, AceFlags flags) { }

	// RVA: 0x160B5A0 Offset: 0x160A7A0 VA: 0x18160B5A0
	internal void .ctor(byte[] binaryForm, int offset) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_AccessMask() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_AccessMask(int value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public SecurityIdentifier get_SecurityIdentifier() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_SecurityIdentifier(SecurityIdentifier value) { }
}

// Namespace: 
protected internal sealed class NativeObjectSecurity.ExceptionFromErrorCode : MulticastDelegate // TypeDefIndex: 3686
{
	// Methods

	// RVA: 0x160A070 Offset: 0x1609270 VA: 0x18160A070
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual Exception Invoke(int errorCode, string name, SafeHandle handle, object context) { }
}

// Namespace: 
private sealed class NativeObjectSecurity.GetSecurityInfoNativeCall : MulticastDelegate // TypeDefIndex: 3687
{
	// Methods

	// RVA: 0x160B420 Offset: 0x160A620 VA: 0x18160B420
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4508F0 Offset: 0x44FAF0 VA: 0x1804508F0 Slot: 13
	public virtual int Invoke(SecurityInfos securityInfos, out IntPtr owner, out IntPtr group, out IntPtr dacl, out IntPtr sacl, out IntPtr descriptor) { }
}

// Namespace: 
private sealed class NativeObjectSecurity.SetSecurityInfoNativeCall : MulticastDelegate // TypeDefIndex: 3688
{
	// Methods

	// RVA: 0x1614430 Offset: 0x1613630 VA: 0x181614430
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x449250 Offset: 0x448450 VA: 0x180449250 Slot: 13
	public virtual int Invoke(SecurityInfos securityInfos, byte[] owner, byte[] group, byte[] dacl, byte[] sacl) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NativeObjectSecurity.<>c__DisplayClass19_0 // TypeDefIndex: 3689
{
	// Fields
	public SafeHandle handle; // 0x10
	public NativeObjectSecurity <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1614AD0 Offset: 0x1613CD0 VA: 0x181614AD0
	internal int <InternalGet>b__0(SecurityInfos securityInfos, out IntPtr owner, out IntPtr group, out IntPtr dacl, out IntPtr sacl, out IntPtr descriptor) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NativeObjectSecurity.<>c__DisplayClass20_0 // TypeDefIndex: 3690
{
	// Fields
	public NativeObjectSecurity <>4__this; // 0x10
	public string name; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1614C20 Offset: 0x1613E20 VA: 0x181614C20
	internal int <InternalGet>b__0(SecurityInfos securityInfos, out IntPtr owner, out IntPtr group, out IntPtr dacl, out IntPtr sacl, out IntPtr descriptor) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NativeObjectSecurity.<>c__DisplayClass21_0 // TypeDefIndex: 3691
{
	// Fields
	public SafeHandle handle; // 0x10
	public NativeObjectSecurity <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1614DD0 Offset: 0x1613FD0 VA: 0x181614DD0
	internal int <InternalSet>b__0(SecurityInfos securityInfos, byte[] owner, byte[] group, byte[] dacl, byte[] sacl) { }
}

// Namespace: System.Security.AccessControl
public abstract class NativeObjectSecurity : CommonObjectSecurity // TypeDefIndex: 3692
{
	// Fields
	private NativeObjectSecurity.ExceptionFromErrorCode exception_from_error_code; // 0x28
	private ResourceType resource_type; // 0x30

	// Properties
	internal ResourceType ResourceType { get; }

	// Methods

	// RVA: 0x160D260 Offset: 0x160C460 VA: 0x18160D260
	protected void .ctor(bool isContainer, ResourceType resourceType) { }

	// RVA: 0x160D2A0 Offset: 0x160C4A0 VA: 0x18160D2A0
	protected void .ctor(bool isContainer, ResourceType resourceType, NativeObjectSecurity.ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext) { }

	// RVA: 0x160D2E0 Offset: 0x160C4E0 VA: 0x18160D2E0
	protected void .ctor(bool isContainer, ResourceType resourceType, SafeHandle handle, AccessControlSections includeSections) { }

	// RVA: 0x160D3E0 Offset: 0x160C5E0 VA: 0x18160D3E0
	protected void .ctor(bool isContainer, ResourceType resourceType, string name, AccessControlSections includeSections) { }

	// RVA: 0x160D1D0 Offset: 0x160C3D0 VA: 0x18160D1D0
	protected void .ctor(bool isContainer, ResourceType resourceType, SafeHandle handle, AccessControlSections includeSections, NativeObjectSecurity.ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext) { }

	// RVA: 0x160D4E0 Offset: 0x160C6E0 VA: 0x18160D4E0
	protected void .ctor(bool isContainer, ResourceType resourceType, string name, AccessControlSections includeSections, NativeObjectSecurity.ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext) { }

	// RVA: 0x160BBA0 Offset: 0x160ADA0 VA: 0x18160BBA0
	private void ClearAccessControlSectionsModified() { }

	// RVA: 0x160C5A0 Offset: 0x160B7A0 VA: 0x18160C5A0
	protected void Persist(SafeHandle handle, AccessControlSections includeSections, object exceptionContext) { }

	// RVA: 0x160BC30 Offset: 0x160AE30 VA: 0x18160BC30
	internal static Exception DefaultExceptionFromErrorCode(int errorCode, string name, SafeHandle handle, object context) { }

	// RVA: 0x160C6A0 Offset: 0x160B8A0 VA: 0x18160C6A0
	private void RaiseExceptionOnFailure(int errorCode, string name, SafeHandle handle, object context) { }

	// RVA: 0x160C080 Offset: 0x160B280 VA: 0x18160C080 Slot: 13
	internal virtual int InternalGet(SafeHandle handle, AccessControlSections includeSections) { }

	// RVA: 0x160C1E0 Offset: 0x160B3E0 VA: 0x18160C1E0 Slot: 14
	internal virtual int InternalGet(string name, AccessControlSections includeSections) { }

	// RVA: 0x160C340 Offset: 0x160B540 VA: 0x18160C340 Slot: 15
	internal virtual int InternalSet(SafeHandle handle, AccessControlSections includeSections) { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	internal ResourceType get_ResourceType() { }

	// RVA: 0x160C960 Offset: 0x160BB60 VA: 0x18160C960
	private int Win32GetHelper(NativeObjectSecurity.GetSecurityInfoNativeCall nativeCall, AccessControlSections includeSections) { }

	// RVA: 0x160CCA0 Offset: 0x160BEA0 VA: 0x18160CCA0
	private int Win32SetHelper(NativeObjectSecurity.SetSecurityInfoNativeCall nativeCall, AccessControlSections includeSections) { }

	// RVA: 0x160C8A0 Offset: 0x160BAA0 VA: 0x18160C8A0
	private string Win32FixName(string name) { }

	// RVA: 0x160BF50 Offset: 0x160B150 VA: 0x18160BF50
	private static extern int GetSecurityInfo(SafeHandle handle, ResourceType resourceType, SecurityInfos securityInfos, out IntPtr owner, out IntPtr group, out IntPtr dacl, out IntPtr sacl, out IntPtr descriptor) { }

	// RVA: 0x160BDE0 Offset: 0x160AFE0 VA: 0x18160BDE0
	private static extern int GetNamedSecurityInfo(string name, ResourceType resourceType, SecurityInfos securityInfos, out IntPtr owner, out IntPtr group, out IntPtr dacl, out IntPtr sacl, out IntPtr descriptor) { }

	// RVA: 0x160C520 Offset: 0x160B720 VA: 0x18160C520
	private static extern IntPtr LocalFree(IntPtr handle) { }

	// RVA: 0x160C750 Offset: 0x160B950 VA: 0x18160C750
	private static extern int SetSecurityInfo(SafeHandle handle, ResourceType resourceType, SecurityInfos securityInfos, byte[] owner, byte[] group, byte[] dacl, byte[] sacl) { }

	// RVA: 0x160BED0 Offset: 0x160B0D0 VA: 0x18160BED0
	private static extern int GetSecurityDescriptorLength(IntPtr descriptor) { }

	// RVA: 0x160C4A0 Offset: 0x160B6A0 VA: 0x18160C4A0
	private static extern bool IsValidSecurityDescriptor(IntPtr descriptor) { }
}

// Namespace: System.Security.AccessControl
public sealed class ObjectAce : QualifiedAce // TypeDefIndex: 3693
{
	// Fields
	private Guid object_ace_type; // 0x30
	private Guid inherited_object_type; // 0x40
	private ObjectAceFlags object_ace_flags; // 0x50

	// Properties
	public override int BinaryLength { get; }
	public Guid InheritedObjectAceType { get; set; }
	private bool InheritedObjectAceTypePresent { get; }
	public ObjectAceFlags ObjectAceFlags { get; set; }
	public Guid ObjectAceType { get; set; }
	private bool ObjectAceTypePresent { get; }

	// Methods

	// RVA: 0x160DA50 Offset: 0x160CC50 VA: 0x18160DA50
	public void .ctor(AceFlags aceFlags, AceQualifier qualifier, int accessMask, SecurityIdentifier sid, ObjectAceFlags flags, Guid type, Guid inheritedType, bool isCallback, byte[] opaque) { }

	// RVA: 0x160DBC0 Offset: 0x160CDC0 VA: 0x18160DBC0
	internal void .ctor(byte[] binaryForm, int offset) { }

	// RVA: 0x160DF90 Offset: 0x160D190 VA: 0x18160DF90 Slot: 4
	public override int get_BinaryLength() { }

	// RVA: 0x4D1A20 Offset: 0x4D0C20 VA: 0x1804D1A20
	public Guid get_InheritedObjectAceType() { }

	// RVA: 0x4D1A60 Offset: 0x4D0C60 VA: 0x1804D1A60
	public void set_InheritedObjectAceType(Guid value) { }

	// RVA: 0x160DFF0 Offset: 0x160D1F0 VA: 0x18160DFF0
	private bool get_InheritedObjectAceTypePresent() { }

	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410
	public ObjectAceFlags get_ObjectAceFlags() { }

	// RVA: 0x430630 Offset: 0x42F830 VA: 0x180430630
	public void set_ObjectAceFlags(ObjectAceFlags value) { }

	// RVA: 0x160E010 Offset: 0x160D210 VA: 0x18160E010
	public Guid get_ObjectAceType() { }

	// RVA: 0x160E020 Offset: 0x160D220 VA: 0x18160E020
	public void set_ObjectAceType(Guid value) { }

	// RVA: 0x160E000 Offset: 0x160D200 VA: 0x18160E000
	private bool get_ObjectAceTypePresent() { }

	// RVA: 0x160D690 Offset: 0x160C890 VA: 0x18160D690 Slot: 5
	public override void GetBinaryForm(byte[] binaryForm, int offset) { }

	// RVA: 0x160D570 Offset: 0x160C770 VA: 0x18160D570
	private static AceType ConvertType(AceQualifier qualifier, bool isCallback) { }

	// RVA: 0x160DA00 Offset: 0x160CC00 VA: 0x18160DA00
	private void WriteGuid(Guid val, byte[] buffer, int offset) { }

	// RVA: 0x160D960 Offset: 0x160CB60 VA: 0x18160D960
	private Guid ReadGuid(byte[] buffer, int offset) { }
}

// Namespace: System.Security.AccessControl
[Flags]
public enum ObjectAceFlags // TypeDefIndex: 3694
{
	// Fields
	public int value__; // 0x0
	public const ObjectAceFlags None = 0;
	public const ObjectAceFlags ObjectAceTypePresent = 1;
	public const ObjectAceFlags InheritedObjectAceTypePresent = 2;
}

// Namespace: System.Security.AccessControl
public abstract class ObjectSecurity // TypeDefIndex: 3695
{
	// Fields
	internal CommonSecurityDescriptor descriptor; // 0x10
	private AccessControlSections sections_modified; // 0x18
	private ReaderWriterLock rw_lock; // 0x20

	// Properties
	public abstract Type AccessRightType { get; }
	public abstract Type AccessRuleType { get; }
	public abstract Type AuditRuleType { get; }
	public bool AreAccessRulesProtected { get; }
	public bool AreAuditRulesProtected { get; }
	internal AccessControlSections AccessControlSectionsModified { get; set; }
	protected bool AccessRulesModified { get; set; }
	protected bool AuditRulesModified { get; set; }
	protected bool GroupModified { get; }
	protected bool IsContainer { get; }
	protected bool IsDS { get; }
	protected bool OwnerModified { get; }

	// Methods

	// RVA: 0x160F040 Offset: 0x160E240 VA: 0x18160F040
	protected void .ctor(CommonSecurityDescriptor securityDescriptor) { }

	// RVA: 0x160ED50 Offset: 0x160DF50 VA: 0x18160ED50
	protected void .ctor(bool isContainer, bool isDS) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Type get_AccessRightType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Type get_AccessRuleType();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Type get_AuditRuleType();

	// RVA: 0x160F1A0 Offset: 0x160E3A0 VA: 0x18160F1A0
	public bool get_AreAccessRulesProtected() { }

	// RVA: 0x160F270 Offset: 0x160E470 VA: 0x18160F270
	public bool get_AreAuditRulesProtected() { }

	// RVA: 0x160F0F0 Offset: 0x160E2F0 VA: 0x18160F0F0
	internal AccessControlSections get_AccessControlSectionsModified() { }

	// RVA: 0x160F3E0 Offset: 0x160E5E0 VA: 0x18160F3E0
	internal void set_AccessControlSectionsModified(AccessControlSections value) { }

	// RVA: 0x160F180 Offset: 0x160E380 VA: 0x18160F180
	protected bool get_AccessRulesModified() { }

	// RVA: 0x160F460 Offset: 0x160E660 VA: 0x18160F460
	protected void set_AccessRulesModified(bool value) { }

	// RVA: 0x160F340 Offset: 0x160E540 VA: 0x18160F340
	protected bool get_AuditRulesModified() { }

	// RVA: 0x160F4B0 Offset: 0x160E6B0 VA: 0x18160F4B0
	protected void set_AuditRulesModified(bool value) { }

	// RVA: 0x160F360 Offset: 0x160E560 VA: 0x18160F360
	protected bool get_GroupModified() { }

	// RVA: 0x160F380 Offset: 0x160E580 VA: 0x18160F380
	protected bool get_IsContainer() { }

	// RVA: 0x160F3A0 Offset: 0x160E5A0 VA: 0x18160F3A0
	protected bool get_IsDS() { }

	// RVA: 0x160F3C0 Offset: 0x160E5C0 VA: 0x18160F3C0
	protected bool get_OwnerModified() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags);

	// RVA: 0x160E3F0 Offset: 0x160D5F0 VA: 0x18160E3F0
	public IdentityReference GetGroup(Type targetType) { }

	// RVA: 0x160E580 Offset: 0x160D780 VA: 0x18160E580
	public IdentityReference GetOwner(Type targetType) { }

	// RVA: 0x160E710 Offset: 0x160D910 VA: 0x18160E710 Slot: 9
	public virtual void PurgeAccessRules(IdentityReference identity) { }

	// RVA: 0x160E830 Offset: 0x160DA30 VA: 0x18160E830 Slot: 10
	public virtual void PurgeAuditRules(IdentityReference identity) { }

	// RVA: 0x160EA70 Offset: 0x160DC70 VA: 0x18160EA70
	public void SetSecurityDescriptorBinaryForm(byte[] binaryForm, AccessControlSections includeSections) { }

	// RVA: 0x160E050 Offset: 0x160D250 VA: 0x18160E050
	private void CopySddlForm(CommonSecurityDescriptor sourceDescriptor, AccessControlSections includeSections) { }

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract bool ModifyAccess(AccessControlModification modification, AccessRule rule, out bool modified);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract bool ModifyAudit(AccessControlModification modification, AuditRule rule, out bool modified);

	// RVA: 0x160E9A0 Offset: 0x160DBA0 VA: 0x18160E9A0
	private void Reading() { }

	// RVA: 0x160E950 Offset: 0x160DB50 VA: 0x18160E950
	protected void ReadLock() { }

	// RVA: 0x160E980 Offset: 0x160DB80 VA: 0x18160E980
	protected void ReadUnlock() { }

	// RVA: 0x160ECD0 Offset: 0x160DED0 VA: 0x18160ECD0
	private void Writing() { }

	// RVA: 0x160EC80 Offset: 0x160DE80 VA: 0x18160EC80
	protected void WriteLock() { }

	// RVA: 0x160ECB0 Offset: 0x160DEB0 VA: 0x18160ECB0
	protected void WriteUnlock() { }

	// RVA: 0x160EB70 Offset: 0x160DD70 VA: 0x18160EB70
	internal static SecurityIdentifier SidFromIR(IdentityReference identity) { }

	// RVA: 0x160E030 Offset: 0x160D230 VA: 0x18160E030
	private bool AreAccessControlSectionsModified(AccessControlSections mask) { }

	// RVA: 0x160EA30 Offset: 0x160DC30 VA: 0x18160EA30
	private void SetAccessControlSectionsModified(AccessControlSections mask, bool modified) { }
}

// Namespace: System.Security.AccessControl
[Flags]
public enum PropagationFlags // TypeDefIndex: 3696
{
	// Fields
	public int value__; // 0x0
	public const PropagationFlags None = 0;
	public const PropagationFlags NoPropagateInherit = 1;
	public const PropagationFlags InheritOnly = 2;
}

// Namespace: System.Security.AccessControl
public abstract class QualifiedAce : KnownAce // TypeDefIndex: 3697
{
	// Fields
	private byte[] opaque; // 0x28

	// Properties
	public AceQualifier AceQualifier { get; }
	public bool IsCallback { get; }
	public int OpaqueLength { get; }

	// Methods

	// RVA: 0x160F7E0 Offset: 0x160E9E0 VA: 0x18160F7E0
	internal void .ctor(AceType type, AceFlags flags, byte[] opaque) { }

	// RVA: 0x160B5A0 Offset: 0x160A7A0 VA: 0x18160B5A0
	internal void .ctor(byte[] binaryForm, int offset) { }

	// RVA: 0x160F890 Offset: 0x160EA90 VA: 0x18160F890
	public AceQualifier get_AceQualifier() { }

	// RVA: 0x160F9C0 Offset: 0x160EBC0 VA: 0x18160F9C0
	public bool get_IsCallback() { }

	// RVA: 0xCF1DC0 Offset: 0xCF0FC0 VA: 0x180CF1DC0
	public int get_OpaqueLength() { }

	// RVA: 0x160F6A0 Offset: 0x160E8A0 VA: 0x18160F6A0
	public byte[] GetOpaque() { }

	// RVA: 0x160F720 Offset: 0x160E920 VA: 0x18160F720
	public void SetOpaque(byte[] opaque) { }
}

// Namespace: System.Security.AccessControl
[DefaultMember("Item")]
public sealed class RawAcl : GenericAcl // TypeDefIndex: 3698
{
	// Fields
	private byte revision; // 0x10
	private List<GenericAce> list; // 0x18

	// Properties
	public override int BinaryLength { get; }
	public override int Count { get; }
	public override GenericAce Item { get; set; }
	public override byte Revision { get; }

	// Methods

	// RVA: 0x1610710 Offset: 0x160F910 VA: 0x181610710
	public void .ctor(byte revision, int capacity) { }

	// RVA: 0x16107C0 Offset: 0x160F9C0 VA: 0x1816107C0
	public void .ctor(byte[] binaryForm, int offset) { }

	// RVA: 0x1610BA0 Offset: 0x160FDA0 VA: 0x181610BA0 Slot: 9
	public override int get_BinaryLength() { }

	// RVA: 0x1610CD0 Offset: 0x160FED0 VA: 0x181610CD0 Slot: 10
	public override int get_Count() { }

	// RVA: 0x1610D10 Offset: 0x160FF10 VA: 0x181610D10 Slot: 11
	public override GenericAce get_Item(int index) { }

	// RVA: 0x1610D70 Offset: 0x160FF70 VA: 0x181610D70 Slot: 12
	public override void set_Item(int index, GenericAce value) { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0 Slot: 13
	public override byte get_Revision() { }

	// RVA: 0x1610240 Offset: 0x160F440 VA: 0x181610240 Slot: 15
	public override void GetBinaryForm(byte[] binaryForm, int offset) { }

	// RVA: 0x1610560 Offset: 0x160F760 VA: 0x181610560
	public void InsertAce(int index, GenericAce ace) { }

	// RVA: 0x1610670 Offset: 0x160F870 VA: 0x181610670
	public void RemoveAce(int index) { }

	// RVA: 0x16106D0 Offset: 0x160F8D0 VA: 0x1816106D0
	private void WriteUShort(ushort val, byte[] buffer, int offset) { }

	// RVA: 0x1610630 Offset: 0x160F830 VA: 0x181610630
	private ushort ReadUShort(byte[] buffer, int offset) { }
}

// Namespace: System.Security.AccessControl
public sealed class RawSecurityDescriptor : GenericSecurityDescriptor // TypeDefIndex: 3699
{
	// Fields
	private ControlFlags control_flags; // 0x10
	private SecurityIdentifier owner_sid; // 0x18
	private SecurityIdentifier group_sid; // 0x20
	private RawAcl system_acl; // 0x28
	private RawAcl discretionary_acl; // 0x30
	private byte resourcemgr_control; // 0x38

	// Properties
	public override ControlFlags ControlFlags { get; }
	public RawAcl DiscretionaryAcl { get; }
	public override SecurityIdentifier Group { get; set; }
	public override SecurityIdentifier Owner { get; set; }
	public RawAcl SystemAcl { get; }

	// Methods

	// RVA: 0x162F8C0 Offset: 0x162EAC0 VA: 0x18162F8C0
	public void .ctor(byte[] binaryForm, int offset) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 4
	public override ControlFlags get_ControlFlags() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public RawAcl get_DiscretionaryAcl() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 5
	public override SecurityIdentifier get_Group() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0 Slot: 6
	public override void set_Group(SecurityIdentifier value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	public override SecurityIdentifier get_Owner() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70 Slot: 8
	public override void set_Owner(SecurityIdentifier value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public RawAcl get_SystemAcl() { }

	// RVA: 0x1610630 Offset: 0x160F830 VA: 0x181610630
	private ushort ReadUShort(byte[] buffer, int offset) { }

	// RVA: 0x162F850 Offset: 0x162EA50 VA: 0x18162F850
	private int ReadInt(byte[] buffer, int offset) { }
}

// Namespace: System.Security.AccessControl
public enum ResourceType // TypeDefIndex: 3700
{
	// Fields
	public int value__; // 0x0
	public const ResourceType Unknown = 0;
	public const ResourceType FileObject = 1;
	public const ResourceType Service = 2;
	public const ResourceType Printer = 3;
	public const ResourceType RegistryKey = 4;
	public const ResourceType LMShare = 5;
	public const ResourceType KernelObject = 6;
	public const ResourceType WindowObject = 7;
	public const ResourceType DSObject = 8;
	public const ResourceType DSObjectAll = 9;
	public const ResourceType ProviderDefined = 10;
	public const ResourceType WmiGuidObject = 11;
	public const ResourceType RegistryWow6432Key = 12;
}

// Namespace: System.Security.AccessControl
[Flags]
public enum SecurityInfos // TypeDefIndex: 3701
{
	// Fields
	public int value__; // 0x0
	public const SecurityInfos Owner = 1;
	public const SecurityInfos Group = 2;
	public const SecurityInfos DiscretionaryAcl = 4;
	public const SecurityInfos SystemAcl = 8;
}

// Namespace: System.Security.AccessControl
public sealed class SystemAcl : CommonAcl // TypeDefIndex: 3702
{
	// Methods

	// RVA: 0x163B8A0 Offset: 0x163AAA0 VA: 0x18163B8A0
	public void .ctor(bool isContainer, bool isDS, int capacity) { }

	// RVA: 0x163B8B0 Offset: 0x163AAB0 VA: 0x18163B8B0
	public void .ctor(bool isContainer, bool isDS, RawAcl rawAcl) { }

	// RVA: 0x163B680 Offset: 0x163A880 VA: 0x18163B680
	public void AddAudit(AuditFlags auditFlags, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags) { }

	[MonoTODO]
	// RVA: 0x163B830 Offset: 0x163AA30 VA: 0x18163B830
	public bool RemoveAudit(AuditFlags auditFlags, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags) { }

	// RVA: 0x163B800 Offset: 0x163AA00 VA: 0x18163B800
	public void RemoveAuditSpecific(AuditFlags auditFlags, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags) { }

	// RVA: 0x163B870 Offset: 0x163AA70 VA: 0x18163B870
	public void SetAudit(AuditFlags auditFlags, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags) { }

	// RVA: 0x163B6B0 Offset: 0x163A8B0 VA: 0x18163B6B0 Slot: 17
	internal override void ApplyCanonicalSortToExplicitAces() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 18
	internal override int GetAceInsertPosition(AceQualifier aceQualifier) { }

	// RVA: 0x163B6E0 Offset: 0x163A8E0 VA: 0x18163B6E0 Slot: 16
	internal override bool IsAceMeaningless(GenericAce ace) { }

	// RVA: 0x163B7E0 Offset: 0x163A9E0 VA: 0x18163B7E0
	private static bool IsValidAuditFlags(AuditFlags auditFlags) { }
}

// Namespace: System.Runtime
[Serializable]
public sealed class AmbiguousImplementationException : Exception // TypeDefIndex: 3703
{
	// Methods

	// RVA: 0x161D230 Offset: 0x161C430 VA: 0x18161D230
	public void .ctor() { }

	// RVA: 0x161D320 Offset: 0x161C520 VA: 0x18161D320
	public void .ctor(string message) { }

	// RVA: 0x161D2A0 Offset: 0x161C4A0 VA: 0x18161D2A0
	private void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Runtime
public static class GCSettings // TypeDefIndex: 3704
{}

// Namespace: System.Runtime
public static class RuntimeImports // TypeDefIndex: 3705
{
	// Methods

	// RVA: 0x16391E0 Offset: 0x16383E0 VA: 0x1816391E0
	internal static void RhZeroMemory(ref byte b, ulong byteLength) { }

	// RVA: 0x16391E0 Offset: 0x16383E0 VA: 0x1816391E0
	private static void ZeroMemory(void* p, uint byteLength) { }

	// RVA: 0x16391C0 Offset: 0x16383C0 VA: 0x1816391C0
	internal static void Memmove(byte* dest, byte* src, uint len) { }

	// RVA: 0x16391D0 Offset: 0x16383D0 VA: 0x1816391D0
	internal static void Memmove_wbarrier(byte* dest, byte* src, uint len, IntPtr type_handle) { }

	// RVA: 0x16391F0 Offset: 0x16383F0 VA: 0x1816391F0
	internal static void _ecvt_s(byte* buffer, int sizeInBytes, double value, int count, int* dec, int* sign) { }
}

// Namespace: System.Runtime.Remoting
[Serializable]
internal class ChannelInfo : IChannelInfo // TypeDefIndex: 3706
{
	// Fields
	private object[] channelData; // 0x10

	// Properties
	public object[] ChannelData { get; }

	// Methods

	// RVA: 0x161F0B0 Offset: 0x161E2B0 VA: 0x18161F0B0
	public void .ctor() { }

	// RVA: 0x161F110 Offset: 0x161E310 VA: 0x18161F110
	public void .ctor(object remoteChannelData) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public object[] get_ChannelData() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public class ActivatedClientTypeEntry : TypeEntry // TypeDefIndex: 3707
{
	// Fields
	private string applicationUrl; // 0x20
	private Type obj_type; // 0x28

	// Properties
	public string ApplicationUrl { get; }
	public IContextAttribute[] ContextAttributes { get; }
	public Type ObjectType { get; }

	// Methods

	// RVA: 0x161BE60 Offset: 0x161B060 VA: 0x18161BE60
	public void .ctor(string typeName, string assemblyName, string appUrl) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_ApplicationUrl() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public IContextAttribute[] get_ContextAttributes() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Type get_ObjectType() { }

	// RVA: 0x161BE40 Offset: 0x161B040 VA: 0x18161BE40 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public class ActivatedServiceTypeEntry : TypeEntry // TypeDefIndex: 3708
{
	// Fields
	private Type obj_type; // 0x20

	// Properties
	public Type ObjectType { get; }

	// Methods

	// RVA: 0x161BFB0 Offset: 0x161B1B0 VA: 0x18161BFB0
	public void .ctor(string typeName, string assemblyName) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Type get_ObjectType() { }

	// RVA: 0x161BFA0 Offset: 0x161B1A0 VA: 0x18161BFA0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public enum CustomErrorsModes // TypeDefIndex: 3709
{
	// Fields
	public int value__; // 0x0
	public const CustomErrorsModes On = 0;
	public const CustomErrorsModes Off = 1;
	public const CustomErrorsModes RemoteOnly = 2;
}

// Namespace: System.Runtime.Remoting
[Serializable]
internal class EnvoyInfo : IEnvoyInfo // TypeDefIndex: 3710
{
	// Fields
	private IMessageSink envoySinks; // 0x10

	// Properties
	public IMessageSink EnvoySinks { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(IMessageSink sinks) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public IMessageSink get_EnvoySinks() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public interface IChannelInfo // TypeDefIndex: 3711
{
	// Properties
	public abstract object[] ChannelData { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object[] get_ChannelData();
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public interface IEnvoyInfo // TypeDefIndex: 3712
{
	// Properties
	public abstract IMessageSink EnvoySinks { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink get_EnvoySinks();
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public interface IRemotingTypeInfo // TypeDefIndex: 3713
{
	// Properties
	public abstract string TypeName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_TypeName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool CanCastTo(Type fromType, object o);
}

// Namespace: System.Runtime.Remoting
internal abstract class Identity // TypeDefIndex: 3714
{
	// Fields
	protected string _objectUri; // 0x10
	protected IMessageSink _channelSink; // 0x18
	protected IMessageSink _envoySink; // 0x20
	private DynamicPropertyCollection _clientDynamicProperties; // 0x28
	private DynamicPropertyCollection _serverDynamicProperties; // 0x30
	protected ObjRef _objRef; // 0x38
	private bool _disposed; // 0x40

	// Properties
	public IMessageSink ChannelSink { get; set; }
	public IMessageSink EnvoySink { get; }
	public string ObjectUri { get; set; }
	public bool IsConnected { get; }
	public bool Disposed { get; set; }
	public DynamicPropertyCollection ClientDynamicProperties { get; }
	public bool HasServerDynamicSinks { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(string objectUri) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ObjRef CreateObjRef(Type requestedType);

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public IMessageSink get_ChannelSink() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ChannelSink(IMessageSink value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public IMessageSink get_EnvoySink() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_ObjectUri() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ObjectUri(string value) { }

	// RVA: 0x161E290 Offset: 0x161D490 VA: 0x18161E290
	public bool get_IsConnected() { }

	// RVA: 0x4456F0 Offset: 0x4448F0 VA: 0x1804456F0
	public bool get_Disposed() { }

	// RVA: 0x445700 Offset: 0x444900 VA: 0x180445700
	public void set_Disposed(bool value) { }

	// RVA: 0x162A4B0 Offset: 0x16296B0 VA: 0x18162A4B0
	public DynamicPropertyCollection get_ClientDynamicProperties() { }

	// RVA: 0x162A560 Offset: 0x1629760 VA: 0x18162A560
	public bool get_HasServerDynamicSinks() { }

	// RVA: 0x162A370 Offset: 0x1629570 VA: 0x18162A370
	public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x162A410 Offset: 0x1629610 VA: 0x18162A410
	public void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }
}

// Namespace: System.Runtime.Remoting
internal class ClientIdentity : Identity // TypeDefIndex: 3715
{
	// Fields
	private WeakReference _proxyReference; // 0x48

	// Properties
	public MarshalByRefObject ClientProxy { get; set; }
	public string TargetUri { get; }

	// Methods

	// RVA: 0x1621E40 Offset: 0x1621040 VA: 0x181621E40
	public void .ctor(string objectUri, ObjRef objRef) { }

	// RVA: 0x1621F00 Offset: 0x1621100 VA: 0x181621F00
	public MarshalByRefObject get_ClientProxy() { }

	// RVA: 0x1621FD0 Offset: 0x16211D0 VA: 0x181621FD0
	public void set_ClientProxy(MarshalByRefObject value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 4
	public override ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x1621FA0 Offset: 0x16211A0 VA: 0x181621FA0
	public string get_TargetUri() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public class InternalRemotingServices // TypeDefIndex: 3716
{
	// Fields
	private static Hashtable _soapAttributes; // 0x0

	// Methods

	// RVA: 0x162AA10 Offset: 0x1629C10 VA: 0x18162AA10
	public static SoapAttribute GetCachedSoapAttribute(object reflectionObject) { }

	// RVA: 0x162AFE0 Offset: 0x162A1E0 VA: 0x18162AFE0
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
[Serializable]
public class ObjRef : IObjectReference, ISerializable // TypeDefIndex: 3717
{
	// Fields
	private IChannelInfo channel_info; // 0x10
	private string uri; // 0x18
	private IRemotingTypeInfo typeInfo; // 0x20
	private IEnvoyInfo envoyInfo; // 0x28
	private int flags; // 0x30
	private Type _serverType; // 0x38
	private static int MarshalledObjectRef; // 0x0
	private static int WellKnowObjectRef; // 0x4

	// Properties
	internal bool IsReferenceToWellKnow { get; }
	public virtual IChannelInfo ChannelInfo { get; }
	public virtual IEnvoyInfo EnvoyInfo { get; set; }
	public virtual IRemotingTypeInfo TypeInfo { get; set; }
	public virtual string URI { get; set; }
	internal Type ServerType { get; }

	// Methods

	// RVA: 0x162EF70 Offset: 0x162E170 VA: 0x18162EF70
	public void .ctor() { }

	// RVA: 0x162EF30 Offset: 0x162E130 VA: 0x18162EF30
	internal void .ctor(string uri, IChannelInfo cinfo) { }

	// RVA: 0x162E210 Offset: 0x162D410 VA: 0x18162E210
	internal ObjRef DeserializeInTheCurrentDomain(int domainId, byte[] tInfo) { }

	// RVA: 0x162E690 Offset: 0x162D890 VA: 0x18162E690
	internal byte[] SerializeType() { }

	// RVA: 0x162E8D0 Offset: 0x162DAD0 VA: 0x18162E8D0
	internal void .ctor(Type type, string url, object remoteChannelData) { }

	// RVA: 0x162EA30 Offset: 0x162DC30 VA: 0x18162EA30
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x162EF90 Offset: 0x162E190 VA: 0x18162EF90
	internal bool get_IsReferenceToWellKnow() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 6
	public virtual IChannelInfo get_ChannelInfo() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 7
	public virtual IEnvoyInfo get_EnvoyInfo() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650 Slot: 8
	public virtual void set_EnvoyInfo(IEnvoyInfo value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 9
	public virtual IRemotingTypeInfo get_TypeInfo() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0 Slot: 10
	public virtual void set_TypeInfo(IRemotingTypeInfo value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 11
	public virtual string get_URI() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70 Slot: 12
	public virtual void set_URI(string value) { }

	// RVA: 0x162E410 Offset: 0x162D610 VA: 0x18162E410 Slot: 13
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x162E5C0 Offset: 0x162D7C0 VA: 0x18162E5C0 Slot: 14
	public virtual object GetRealObject(StreamingContext context) { }

	// RVA: 0x162E7F0 Offset: 0x162D9F0 VA: 0x18162E7F0
	internal void UpdateChannelInfo() { }

	// RVA: 0x162EFF0 Offset: 0x162E1F0 VA: 0x18162EFF0
	internal Type get_ServerType() { }

	// RVA: 0x162E880 Offset: 0x162DA80 VA: 0x18162E880
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public static class RemotingConfiguration // TypeDefIndex: 3718
{
	// Fields
	private static string applicationID; // 0x0
	private static string applicationName; // 0x8
	private static string processGuid; // 0x10
	private static bool defaultConfigRead; // 0x18
	private static bool defaultDelayedConfigRead; // 0x19
	private static CustomErrorsModes _errorMode; // 0x1C
	private static Hashtable wellKnownClientEntries; // 0x20
	private static Hashtable activatedClientEntries; // 0x28
	private static Hashtable wellKnownServiceEntries; // 0x30
	private static Hashtable activatedServiceEntries; // 0x38
	private static Hashtable channelTemplates; // 0x40
	private static Hashtable clientProviderTemplates; // 0x48
	private static Hashtable serverProviderTemplates; // 0x50

	// Properties
	public static string ApplicationName { get; set; }
	public static string ProcessId { get; }

	// Methods

	// RVA: 0x16338B0 Offset: 0x1632AB0 VA: 0x1816338B0
	public static string get_ApplicationName() { }

	// RVA: 0x16339D0 Offset: 0x1632BD0 VA: 0x1816339D0
	public static void set_ApplicationName(string value) { }

	// RVA: 0x1633900 Offset: 0x1632B00 VA: 0x181633900
	public static string get_ProcessId() { }

	// RVA: 0x1631CA0 Offset: 0x1630EA0 VA: 0x181631CA0
	internal static void LoadDefaultDelayedChannels() { }

	// RVA: 0x1631870 Offset: 0x1630A70 VA: 0x181631870
	public static bool IsActivationAllowed(Type svrType) { }

	// RVA: 0x16319A0 Offset: 0x1630BA0 VA: 0x1816319A0
	public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType) { }

	// RVA: 0x1631B20 Offset: 0x1630D20 VA: 0x181631B20
	public static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType) { }

	// RVA: 0x1631FC0 Offset: 0x16311C0 VA: 0x181631FC0
	public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry) { }

	// RVA: 0x1632250 Offset: 0x1631450 VA: 0x181632250
	public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry) { }

	// RVA: 0x1633090 Offset: 0x1632290 VA: 0x181633090
	public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry) { }

	// RVA: 0x1633320 Offset: 0x1632520 VA: 0x181633320
	public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry) { }

	// RVA: 0x1632380 Offset: 0x1631580 VA: 0x181632380
	internal static void RegisterChannelTemplate(ChannelData channel) { }

	// RVA: 0x1632B70 Offset: 0x1631D70 VA: 0x181632B70
	internal static void RegisterClientProviderTemplate(ProviderData prov) { }

	// RVA: 0x1632BF0 Offset: 0x1631DF0 VA: 0x181632BF0
	internal static void RegisterServerProviderTemplate(ProviderData prov) { }

	// RVA: 0x1632400 Offset: 0x1631600 VA: 0x181632400
	internal static void RegisterChannels(ArrayList channels, bool onlyDelayed) { }

	// RVA: 0x1632C70 Offset: 0x1631E70 VA: 0x181632C70
	internal static void RegisterTypes(ArrayList types) { }

	// RVA: 0x16317E0 Offset: 0x16309E0 VA: 0x1816317E0
	public static bool CustomErrorsEnabled(bool isLocalRequest) { }

	// RVA: 0x16334A0 Offset: 0x16326A0 VA: 0x1816334A0
	internal static void SetCustomErrorsMode(string mode) { }

	// RVA: 0x16336E0 Offset: 0x16328E0 VA: 0x1816336E0
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting
internal class ConfigHandler : SmallXmlParser.IContentHandler // TypeDefIndex: 3719
{
	// Fields
	private ArrayList typeEntries; // 0x10
	private ArrayList channelInstances; // 0x18
	private ChannelData currentChannel; // 0x20
	private Stack currentProviderData; // 0x28
	private string currentClientUrl; // 0x30
	private string appName; // 0x38
	private string currentXmlPath; // 0x40
	private bool onlyDelayedChannels; // 0x48

	// Methods

	// RVA: 0x16257B0 Offset: 0x16249B0 VA: 0x1816257B0
	public void .ctor(bool onlyDelayedChannels) { }

	// RVA: 0x16256C0 Offset: 0x16248C0 VA: 0x1816256C0
	private void ValidatePath(string element, string[] paths) { }

	// RVA: 0x1622040 Offset: 0x1621240 VA: 0x181622040
	private bool CheckPath(string path) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	public void OnStartParsing(SmallXmlParser parser) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	public void OnProcessingInstruction(string name, string text) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 10
	public void OnIgnorableWhitespace(string s) { }

	// RVA: 0x16224A0 Offset: 0x16216A0 VA: 0x1816224A0 Slot: 6
	public void OnStartElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x16225F0 Offset: 0x16217F0 VA: 0x1816225F0
	public void ParseElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1622300 Offset: 0x1621500 VA: 0x181622300 Slot: 7
	public void OnEndElement(string name) { }

	// RVA: 0x16241E0 Offset: 0x16233E0 VA: 0x1816241E0
	private void ReadCustomProviderData(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1624790 Offset: 0x1623990 VA: 0x181624790
	private void ReadLifetine(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x16234D0 Offset: 0x16226D0 VA: 0x1816234D0
	private TimeSpan ParseTime(string s) { }

	// RVA: 0x1623850 Offset: 0x1622A50 VA: 0x181623850
	private void ReadChannel(SmallXmlParser.IAttrList attrs, bool isTemplate) { }

	// RVA: 0x1624D70 Offset: 0x1623F70 VA: 0x181624D70
	private ProviderData ReadProvider(string name, SmallXmlParser.IAttrList attrs, bool isTemplate) { }

	// RVA: 0x1623DC0 Offset: 0x1622FC0 VA: 0x181623DC0
	private void ReadClientActivated(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1625220 Offset: 0x1624420 VA: 0x181625220
	private void ReadServiceActivated(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1624000 Offset: 0x1623200 VA: 0x181624000
	private void ReadClientWellKnown(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x16253E0 Offset: 0x16245E0 VA: 0x1816253E0
	private void ReadServiceWellKnown(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x16245E0 Offset: 0x16237E0 VA: 0x1816245E0
	private void ReadInteropXml(SmallXmlParser.IAttrList attrs, bool isElement) { }

	// RVA: 0x1624AE0 Offset: 0x1623CE0 VA: 0x181624AE0
	private void ReadPreload(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1622220 Offset: 0x1621420 VA: 0x181622220
	private string GetNotNull(SmallXmlParser.IAttrList attrs, string name) { }

	// RVA: 0x1622150 Offset: 0x1621350 VA: 0x181622150
	private string ExtractAssembly(ref string type) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 9
	public void OnChars(string ch) { }

	// RVA: 0x16223A0 Offset: 0x16215A0 VA: 0x1816223A0 Slot: 5
	public void OnEndParsing(SmallXmlParser parser) { }
}

// Namespace: System.Runtime.Remoting
internal class ChannelData // TypeDefIndex: 3720
{
	// Fields
	internal string Ref; // 0x10
	internal string Type; // 0x18
	internal string Id; // 0x20
	internal string DelayLoadAsClientChannel; // 0x28
	private ArrayList _serverProviders; // 0x30
	private ArrayList _clientProviders; // 0x38
	private Hashtable _customProperties; // 0x40

	// Properties
	internal ArrayList ServerProviders { get; }
	public ArrayList ClientProviders { get; }
	public Hashtable CustomProperties { get; }

	// Methods

	// RVA: 0x161F040 Offset: 0x161E240 VA: 0x18161F040
	internal ArrayList get_ServerProviders() { }

	// RVA: 0x161EF60 Offset: 0x161E160 VA: 0x18161EF60
	public ArrayList get_ClientProviders() { }

	// RVA: 0x161EFD0 Offset: 0x161E1D0 VA: 0x18161EFD0
	public Hashtable get_CustomProperties() { }

	// RVA: 0x161E5D0 Offset: 0x161D7D0 VA: 0x18161E5D0
	public void CopyFrom(ChannelData other) { }

	// RVA: 0x161EEC0 Offset: 0x161E0C0 VA: 0x18161EEC0
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting
internal class ProviderData // TypeDefIndex: 3721
{
	// Fields
	internal string Ref; // 0x10
	internal string Type; // 0x18
	internal string Id; // 0x20
	internal Hashtable CustomProperties; // 0x28
	internal IList CustomData; // 0x30

	// Methods

	// RVA: 0x162F0D0 Offset: 0x162E2D0 VA: 0x18162F0D0
	public void CopyFrom(ProviderData other) { }

	// RVA: 0x162A310 Offset: 0x1629510 VA: 0x18162A310
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting
internal class FormatterData : ProviderData // TypeDefIndex: 3722
{
	// Methods

	// RVA: 0x162A310 Offset: 0x1629510 VA: 0x18162A310
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
[Serializable]
public class RemotingException : SystemException // TypeDefIndex: 3723
{
	// Methods

	// RVA: 0x15E0800 Offset: 0x15DFA00 VA: 0x1815E0800
	public void .ctor() { }

	// RVA: 0x160B4C0 Offset: 0x160A6C0 VA: 0x18160B4C0
	public void .ctor(string message) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1633A30 Offset: 0x1632C30 VA: 0x181633A30
	public void .ctor(string message, Exception InnerException) { }
}

// Namespace: 
[Serializable]
private class RemotingServices.CACD // TypeDefIndex: 3724
{
	// Fields
	public object d; // 0x10
	public object c; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public static class RemotingServices // TypeDefIndex: 3725
{
	// Fields
	private static Hashtable uri_hash; // 0x0
	private static BinaryFormatter _serializationFormatter; // 0x8
	private static BinaryFormatter _deserializationFormatter; // 0x10
	private static string app_id; // 0x18
	private static readonly object app_id_lock; // 0x20
	private static int next_id; // 0x28
	private static readonly MethodInfo FieldSetterMethod; // 0x30
	private static readonly MethodInfo FieldGetterMethod; // 0x38

	// Methods

	// RVA: 0x1638CE0 Offset: 0x1637EE0 VA: 0x181638CE0
	private static void .cctor() { }

	// RVA: 0x1637B10 Offset: 0x1636D10 VA: 0x181637B10
	internal static object InternalExecute(MethodBase method, object obj, object[] parameters, out object[] out_args) { }

	// RVA: 0x1637350 Offset: 0x1636550 VA: 0x181637350
	internal static MethodBase GetVirtualMethod(Type type, MethodBase method) { }

	// RVA: 0x1637BB0 Offset: 0x1636DB0 VA: 0x181637BB0
	public static bool IsTransparentProxy(object proxy) { }

	// RVA: 0x1637360 Offset: 0x1636560 VA: 0x181637360
	internal static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg) { }

	[ComVisible(True)]
	// RVA: 0x1634B60 Offset: 0x1633D60 VA: 0x181634B60
	public static object Connect(Type classToProxy, string url) { }

	[ComVisible(True)]
	// RVA: 0x1634A70 Offset: 0x1633C70 VA: 0x181634A70
	public static object Connect(Type classToProxy, string url, object data) { }

	// RVA: 0x16372A0 Offset: 0x16364A0 VA: 0x1816372A0
	public static Type GetServerTypeForUri(string URI) { }

	// RVA: 0x16386F0 Offset: 0x16378F0 VA: 0x1816386F0
	public static object Unmarshal(ObjRef objectRef) { }

	// RVA: 0x1638740 Offset: 0x1637940 VA: 0x181638740
	public static object Unmarshal(ObjRef objectRef, bool fRefine) { }

	// RVA: 0x1637C70 Offset: 0x1636E70 VA: 0x181637C70
	public static ObjRef Marshal(MarshalByRefObject Obj) { }

	// RVA: 0x1637BF0 Offset: 0x1636DF0 VA: 0x181637BF0
	public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType) { }

	// RVA: 0x1637CC0 Offset: 0x1636EC0 VA: 0x181637CC0
	private static string NewUri() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x16371E0 Offset: 0x16363E0 VA: 0x1816371E0
	public static RealProxy GetRealProxy(object proxy) { }

	// RVA: 0x1636400 Offset: 0x1635600 VA: 0x181636400
	public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg) { }

	// RVA: 0x1636600 Offset: 0x1635800 VA: 0x181636600
	internal static MethodBase GetMethodBaseFromName(Type type, string methodName, Type[] signature) { }

	// RVA: 0x1635AE0 Offset: 0x1634CE0 VA: 0x181635AE0
	private static MethodBase FindInterfaceMethod(Type type, string methodName, Type[] signature) { }

	// RVA: 0x1636870 Offset: 0x1635A70 VA: 0x181636870
	public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1637B20 Offset: 0x1636D20 VA: 0x181637B20
	public static bool IsOneWay(MethodBase method) { }

	// RVA: 0x1635320 Offset: 0x1634520 VA: 0x181635320
	internal static object CreateClientProxy(ActivatedClientTypeEntry entry, object[] activationAttributes) { }

	// RVA: 0x1634F40 Offset: 0x1634140 VA: 0x181634F40
	internal static object CreateClientProxy(Type objectType, string url, object[] activationAttributes) { }

	// RVA: 0x1635180 Offset: 0x1634380 VA: 0x181635180
	internal static object CreateClientProxy(WellKnownClientTypeEntry entry) { }

	// RVA: 0x1634D70 Offset: 0x1633F70 VA: 0x181634D70
	internal static object CreateClientProxyForContextBound(Type type, object[] activationAttributes) { }

	// RVA: 0x1635D50 Offset: 0x1634F50 VA: 0x181635D50
	internal static Identity GetIdentityForUri(string uri) { }

	// RVA: 0x16381F0 Offset: 0x16373F0 VA: 0x1816381F0
	private static string RemoveAppNameFromUri(string uri) { }

	// RVA: 0x1636920 Offset: 0x1635B20 VA: 0x181636920
	internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out object clientProxy) { }

	// RVA: 0x1635C20 Offset: 0x1634E20 VA: 0x181635C20
	private static IMessageSink GetClientChannelSinkChain(string url, object channelData, out string objectUri) { }

	// RVA: 0x1635430 Offset: 0x1634630 VA: 0x181635430
	internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType) { }

	// RVA: 0x1634CC0 Offset: 0x1633EC0 VA: 0x181634CC0
	internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri) { }

	// RVA: 0x1635500 Offset: 0x1634700 VA: 0x181635500
	internal static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0x1637FE0 Offset: 0x16371E0 VA: 0x181637FE0
	private static void RegisterServerIdentity(ServerIdentity identity) { }

	// RVA: 0x16370D0 Offset: 0x16362D0 VA: 0x1816370D0
	internal static object GetProxyForRemoteObject(ObjRef objref, Type classToProxy) { }

	// RVA: 0x1637230 Offset: 0x1636430 VA: 0x181637230
	internal static object GetRemoteObject(ObjRef objRef, Type proxyType) { }

	// RVA: 0x16382F0 Offset: 0x16374F0 VA: 0x1816382F0
	internal static byte[] SerializeCallData(object obj) { }

	// RVA: 0x1635600 Offset: 0x1634800 VA: 0x181635600
	internal static object DeserializeCallData(byte[] array) { }

	// RVA: 0x1638540 Offset: 0x1637740 VA: 0x181638540
	internal static byte[] SerializeExceptionData(Exception ex) { }

	// RVA: 0x1637FA0 Offset: 0x16371A0 VA: 0x181637FA0
	private static void RegisterInternalChannels() { }

	// RVA: 0x1635890 Offset: 0x1634A90 VA: 0x181635890
	internal static void DisposeIdentity(Identity ident) { }

	// RVA: 0x16360C0 Offset: 0x16352C0 VA: 0x1816360C0
	internal static Identity GetMessageTargetIdentity(IMessage msg) { }

	// RVA: 0x1638630 Offset: 0x1637830 VA: 0x181638630
	internal static void SetMessageTargetIdentity(IMessage msg, Identity ident) { }

	// RVA: 0x1638AD0 Offset: 0x1637CD0 VA: 0x181638AD0
	internal static bool UpdateOutArgObject(ParameterInfo pi, object local, object remote) { }

	// RVA: 0x1636800 Offset: 0x1635A00 VA: 0x181636800
	private static string GetNormalizedUri(string uri) { }
}

// Namespace: System.Runtime.Remoting
internal abstract class ServerIdentity : Identity // TypeDefIndex: 3726
{
	// Fields
	protected Type _objectType; // 0x48
	protected MarshalByRefObject _serverObject; // 0x50
	protected IMessageSink _serverSink; // 0x58
	protected Context _context; // 0x60
	protected Lease _lease; // 0x68

	// Properties
	public Type ObjectType { get; }
	public Lease Lease { get; }
	public Context Context { get; set; }

	// Methods

	// RVA: 0x1639820 Offset: 0x1638A20 VA: 0x181639820
	public void .ctor(string objectUri, Context context, Type objectType) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public Type get_ObjectType() { }

	// RVA: 0x16394E0 Offset: 0x16386E0 VA: 0x1816394E0
	public void StartTrackingLifetime(ILease lease) { }

	// RVA: 0x16394D0 Offset: 0x16386D0 VA: 0x1816394D0 Slot: 5
	public virtual void OnLifetimeExpired() { }

	// RVA: 0x1639260 Offset: 0x1638460 VA: 0x181639260 Slot: 4
	public override ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x1639200 Offset: 0x1638400 VA: 0x181639200
	public void AttachServerObject(MarshalByRefObject serverObject, Context context) { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public Lease get_Lease() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public Context get_Context() { }

	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	public void set_Context(Context value) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IMessage SyncObjectProcessMessage(IMessage msg);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink);

	// RVA: 0x1639450 Offset: 0x1638650 VA: 0x181639450
	protected void DisposeServerObject() { }
}

// Namespace: System.Runtime.Remoting
internal class ClientActivatedIdentity : ServerIdentity // TypeDefIndex: 3727
{
	// Fields
	private MarshalByRefObject _targetThis; // 0x70

	// Methods

	// RVA: 0x1621E00 Offset: 0x1621000 VA: 0x181621E00
	public void .ctor(string objectUri, Type objectType) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public MarshalByRefObject GetServerObject() { }

	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30
	public void SetClientProxy(MarshalByRefObject obj) { }

	// RVA: 0x1621D00 Offset: 0x1620F00 VA: 0x181621D00 Slot: 5
	public override void OnLifetimeExpired() { }

	// RVA: 0x1621D60 Offset: 0x1620F60 VA: 0x181621D60 Slot: 6
	public override IMessage SyncObjectProcessMessage(IMessage msg) { }

	// RVA: 0x1621C50 Offset: 0x1620E50 VA: 0x181621C50 Slot: 7
	public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting
internal class SingletonIdentity : ServerIdentity // TypeDefIndex: 3728
{
	// Methods

	// RVA: 0x1639820 Offset: 0x1638A20 VA: 0x181639820
	public void .ctor(string objectUri, Context context, Type objectType) { }

	// RVA: 0x1639C40 Offset: 0x1638E40 VA: 0x181639C40
	public MarshalByRefObject GetServerObject() { }

	// RVA: 0x1639D60 Offset: 0x1638F60 VA: 0x181639D60 Slot: 6
	public override IMessage SyncObjectProcessMessage(IMessage msg) { }

	// RVA: 0x1639BA0 Offset: 0x1638DA0 VA: 0x181639BA0 Slot: 7
	public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting
internal class SingleCallIdentity : ServerIdentity // TypeDefIndex: 3729
{
	// Methods

	// RVA: 0x1639820 Offset: 0x1638A20 VA: 0x181639820
	public void .ctor(string objectUri, Context context, Type objectType) { }

	// RVA: 0x1639A10 Offset: 0x1638C10 VA: 0x181639A10 Slot: 6
	public override IMessage SyncObjectProcessMessage(IMessage msg) { }

	// RVA: 0x1639870 Offset: 0x1638A70 VA: 0x181639870 Slot: 7
	public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting
internal class DisposerReplySink : IMessageSink // TypeDefIndex: 3730
{
	// Fields
	private IMessageSink _next; // 0x10
	private IDisposable _disposable; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(IMessageSink next, IDisposable disposable) { }

	// RVA: 0x1629880 Offset: 0x1628A80 VA: 0x181629880 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1629840 Offset: 0x1628A40 VA: 0x181629840 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

// Namespace: 
private class SoapServices.TypeInfo // TypeDefIndex: 3731
{
	// Fields
	public Hashtable Attributes; // 0x10
	public Hashtable Elements; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public class SoapServices // TypeDefIndex: 3732
{
	// Fields
	private static Hashtable _xmlTypes; // 0x0
	private static Hashtable _xmlElements; // 0x8
	private static Hashtable _soapActions; // 0x10
	private static Hashtable _soapActionsMethods; // 0x18
	private static Hashtable _typeInfos; // 0x20

	// Properties
	public static string XmlNsForClrTypeWithAssembly { get; }
	public static string XmlNsForClrTypeWithNs { get; }
	public static string XmlNsForClrTypeWithNsAndAssembly { get; }

	// Methods

	// RVA: 0x163B390 Offset: 0x163A590 VA: 0x18163B390
	public static string get_XmlNsForClrTypeWithAssembly() { }

	// RVA: 0x163B3F0 Offset: 0x163A5F0 VA: 0x18163B3F0
	public static string get_XmlNsForClrTypeWithNs() { }

	// RVA: 0x163B3C0 Offset: 0x163A5C0 VA: 0x18163B3C0
	public static string get_XmlNsForClrTypeWithNsAndAssembly() { }

	// RVA: 0x163A190 Offset: 0x1639390 VA: 0x18163A190
	public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName) { }

	// RVA: 0x163A560 Offset: 0x1639760 VA: 0x18163A560
	private static string GetNameKey(string name, string namspace) { }

	// RVA: 0x163A3F0 Offset: 0x16395F0 VA: 0x18163A3F0
	private static string GetAssemblyName(MethodBase mb) { }

	// RVA: 0x163A5C0 Offset: 0x16397C0 VA: 0x18163A5C0
	public static bool GetXmlElementForInteropType(Type type, out string xmlElement, out string xmlNamespace) { }

	// RVA: 0x163A6A0 Offset: 0x16398A0 VA: 0x18163A6A0
	public static string GetXmlNamespaceForMethodCall(MethodBase mb) { }

	// RVA: 0x163A750 Offset: 0x1639950 VA: 0x18163A750
	public static string GetXmlNamespaceForMethodResponse(MethodBase mb) { }

	// RVA: 0x163A800 Offset: 0x1639A00 VA: 0x18163A800
	public static bool GetXmlTypeForInteropType(Type type, out string xmlType, out string xmlTypeNamespace) { }

	// RVA: 0x163AEB0 Offset: 0x163A0B0 VA: 0x18163AEB0
	public static void PreLoad(Assembly assembly) { }

	// RVA: 0x163A8D0 Offset: 0x1639AD0 VA: 0x18163A8D0
	public static void PreLoad(Type type) { }

	// RVA: 0x163AF70 Offset: 0x163A170 VA: 0x18163AF70
	public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type) { }

	// RVA: 0x163B100 Offset: 0x163A300 VA: 0x18163B100
	public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type) { }

	// RVA: 0x163A320 Offset: 0x1639520 VA: 0x18163A320
	private static string EncodeNs(string ns) { }

	// RVA: 0x163B280 Offset: 0x163A480 VA: 0x18163B280
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public class TypeEntry // TypeDefIndex: 3733
{
	// Fields
	private string assembly_name; // 0x10
	private string type_name; // 0x18

	// Properties
	public string AssemblyName { get; set; }
	public string TypeName { get; set; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_AssemblyName() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_AssemblyName(string value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_TypeName() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_TypeName(string value) { }
}

// Namespace: System.Runtime.Remoting
[Serializable]
internal class TypeInfo : IRemotingTypeInfo // TypeDefIndex: 3734
{
	// Fields
	private string serverType; // 0x10
	private string[] serverHierarchy; // 0x18
	private string[] interfacesImplemented; // 0x20

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x163CEB0 Offset: 0x163C0B0 VA: 0x18163CEB0
	public void .ctor(Type type) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public string get_TypeName() { }

	// RVA: 0x163CC50 Offset: 0x163BE50 VA: 0x18163CC50 Slot: 5
	public bool CanCastTo(Type fromType, object o) { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public class WellKnownClientTypeEntry : TypeEntry // TypeDefIndex: 3735
{
	// Fields
	private Type obj_type; // 0x20
	private string obj_url; // 0x28
	private string app_url; // 0x30

	// Properties
	public string ApplicationUrl { get; }
	public Type ObjectType { get; }
	public string ObjectUrl { get; }

	// Methods

	// RVA: 0x163D2D0 Offset: 0x163C4D0 VA: 0x18163D2D0
	public void .ctor(string typeName, string assemblyName, string objectUrl) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_ApplicationUrl() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Type get_ObjectType() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_ObjectUrl() { }

	// RVA: 0x163D290 Offset: 0x163C490 VA: 0x18163D290 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
[Serializable]
public enum WellKnownObjectMode // TypeDefIndex: 3736
{
	// Fields
	public int value__; // 0x0
	public const WellKnownObjectMode Singleton = 1;
	public const WellKnownObjectMode SingleCall = 2;
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public class WellKnownServiceTypeEntry : TypeEntry // TypeDefIndex: 3737
{
	// Fields
	private Type obj_type; // 0x20
	private string obj_uri; // 0x28
	private WellKnownObjectMode obj_mode; // 0x30

	// Properties
	public WellKnownObjectMode Mode { get; }
	public Type ObjectType { get; }
	public string ObjectUri { get; }

	// Methods

	// RVA: 0x163D4D0 Offset: 0x163C6D0 VA: 0x18163D4D0
	public void .ctor(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public WellKnownObjectMode get_Mode() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Type get_ObjectType() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_ObjectUri() { }

	// RVA: 0x163D410 Offset: 0x163C610 VA: 0x18163D410 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Runtime.Remoting.Services
[ComVisible(True)]
public interface ITrackingHandler // TypeDefIndex: 3738
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void DisconnectedObject(object obj);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void MarshaledObject(object obj, ObjRef or);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void UnmarshaledObject(object obj, ObjRef or);
}

// Namespace: System.Runtime.Remoting.Services
[ComVisible(True)]
public class TrackingServices // TypeDefIndex: 3739
{
	// Fields
	private static ArrayList _handlers; // 0x0

	// Methods

	// RVA: 0x163BC10 Offset: 0x163AE10 VA: 0x18163BC10
	internal static void NotifyMarshaledObject(object obj, ObjRef or) { }

	// RVA: 0x163BF60 Offset: 0x163B160 VA: 0x18163BF60
	internal static void NotifyUnmarshaledObject(object obj, ObjRef or) { }

	// RVA: 0x163B8C0 Offset: 0x163AAC0 VA: 0x18163B8C0
	internal static void NotifyDisconnectedObject(object obj) { }

	// RVA: 0x163C2B0 Offset: 0x163B4B0 VA: 0x18163C2B0
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting.Proxies
[ComVisible(True)]
[Usage(4)]
public class ProxyAttribute : Attribute, IContextAttribute // TypeDefIndex: 3740
{
	// Methods

	// RVA: 0x162F6B0 Offset: 0x162E8B0 VA: 0x18162F6B0 Slot: 9
	public virtual MarshalByRefObject CreateInstance(Type serverType) { }

	// RVA: 0x162F7F0 Offset: 0x162E9F0 VA: 0x18162F7F0 Slot: 10
	public virtual RealProxy CreateProxy(ObjRef objRef, Type serverType, object serverObject, Context serverContext) { }

	[ComVisible(True)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public void GetPropertiesForNewContext(IConstructionCallMessage msg) { }

	[ComVisible(True)]
	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 8
	public bool IsContextOK(Context ctx, IConstructionCallMessage msg) { }
}

// Namespace: System.Runtime.Remoting.Proxies
internal class TransparentProxy // TypeDefIndex: 3741
{
	// Fields
	public RealProxy _rp; // 0x10
	private RuntimeRemoteClassHandle _class; // 0x18
	private bool _custom_type_info; // 0x20

	// Properties
	private bool IsContextBoundObject { get; }
	private Context TargetContext { get; }

	// Methods

	// RVA: 0x163C310 Offset: 0x163B510 VA: 0x18163C310
	internal RuntimeType GetProxyType() { }

	// RVA: 0x163CB70 Offset: 0x163BD70 VA: 0x18163CB70
	private bool get_IsContextBoundObject() { }

	// RVA: 0xCE7E10 Offset: 0xCE7010 VA: 0x180CE7E10
	private Context get_TargetContext() { }

	// RVA: 0x163C3E0 Offset: 0x163B5E0 VA: 0x18163C3E0
	private bool InCurrentContext() { }

	// RVA: 0x163C4F0 Offset: 0x163B6F0 VA: 0x18163C4F0
	internal object LoadRemoteFieldNew(IntPtr classPtr, IntPtr fieldPtr) { }

	// RVA: 0x163C830 Offset: 0x163BA30 VA: 0x18163C830
	internal void StoreRemoteField(IntPtr classPtr, IntPtr fieldPtr, object arg) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Proxies
[ComVisible(True)]
public abstract class RealProxy // TypeDefIndex: 3742
{
	// Fields
	private Type class_to_proxy; // 0x10
	internal Context _targetContext; // 0x18
	internal MarshalByRefObject _server; // 0x20
	private int _targetDomainId; // 0x28
	internal string _targetUri; // 0x30
	internal Identity _objectIdentity; // 0x38
	private object _objTP; // 0x40
	private object _stubData; // 0x48

	// Properties
	internal Identity ObjectIdentity { get; set; }

	// Methods

	// RVA: 0x16310D0 Offset: 0x16302D0 VA: 0x1816310D0
	protected void .ctor() { }

	// RVA: 0x16311F0 Offset: 0x16303F0 VA: 0x1816311F0
	protected void .ctor(Type classToProxy) { }

	// RVA: 0x1631090 Offset: 0x1630290 VA: 0x181631090
	internal void .ctor(Type classToProxy, ClientIdentity identity) { }

	// RVA: 0x16310E0 Offset: 0x16302E0 VA: 0x1816310E0
	protected void .ctor(Type classToProxy, IntPtr stub, object stubData) { }

	// RVA: 0x1630200 Offset: 0x162F400 VA: 0x181630200
	private static Type InternalGetProxyType(object transparentProxy) { }

	// RVA: 0x1630030 Offset: 0x162F230 VA: 0x181630030
	public Type GetProxiedType() { }

	// RVA: 0x162FFC0 Offset: 0x162F1C0 VA: 0x18162FFC0 Slot: 4
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	internal Identity get_ObjectIdentity() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	internal void set_ObjectIdentity(Identity value) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IMessage Invoke(IMessage msg);

	// RVA: 0x1630220 Offset: 0x162F420 VA: 0x181630220
	internal static object PrivateInvoke(RealProxy rp, IMessage msg, out Exception exc, out object[] out_args) { }

	// RVA: 0x1630210 Offset: 0x162F410 VA: 0x181630210 Slot: 6
	internal virtual object InternalGetTransparentProxy(string className) { }

	// RVA: 0x16300D0 Offset: 0x162F2D0 VA: 0x1816300D0 Slot: 7
	public virtual object GetTransparentProxy() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	protected void AttachServer(MarshalByRefObject s) { }

	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	internal void SetTargetDomain(int domainId) { }

	// RVA: 0x162FE90 Offset: 0x162F090 VA: 0x18162FE90
	internal object GetAppDomainTarget() { }

	// RVA: 0x1630A70 Offset: 0x162FC70 VA: 0x181630A70
	private static object[] ProcessResponse(IMethodReturnMessage mrm, MonoMethodMessage call) { }
}

// Namespace: System.Runtime.Remoting.Proxies
internal class RemotingProxy : RealProxy, IRemotingTypeInfo // TypeDefIndex: 3743
{
	// Fields
	private static MethodInfo _cache_GetTypeMethod; // 0x0
	private static MethodInfo _cache_GetHashCodeMethod; // 0x8
	private IMessageSink _sink; // 0x50
	private bool _hasEnvoySink; // 0x58
	private ConstructionCall _ctorCall; // 0x60

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x1634860 Offset: 0x1633A60 VA: 0x181634860
	internal void .ctor(Type type, ClientIdentity identity) { }

	// RVA: 0x16348D0 Offset: 0x1633AD0 VA: 0x1816348D0
	internal void .ctor(Type type, string activationUrl, object[] activationAttributes) { }

	// RVA: 0x1634280 Offset: 0x1633480 VA: 0x181634280 Slot: 5
	public override IMessage Invoke(IMessage request) { }

	// RVA: 0x1633B20 Offset: 0x1632D20 VA: 0x181633B20
	internal void AttachIdentity(Identity identity) { }

	// RVA: 0x1633A40 Offset: 0x1632C40 VA: 0x181633A40
	internal IMessage ActivateRemoteObject(IMethodMessage request) { }

	// RVA: 0x1634940 Offset: 0x1633B40 VA: 0x181634940 Slot: 8
	public string get_TypeName() { }

	// RVA: 0x1633F00 Offset: 0x1633100 VA: 0x181633F00 Slot: 9
	public bool CanCastTo(Type fromType, object o) { }

	// RVA: 0x1634190 Offset: 0x1633390 VA: 0x181634190 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1634770 Offset: 0x1633970 VA: 0x181634770
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting.Lifetime
[ComVisible(True)]
public interface ILease // TypeDefIndex: 3744
{
	// Properties
	public abstract TimeSpan CurrentLeaseTime { get; }
	public abstract LeaseState CurrentState { get; }
	public abstract TimeSpan RenewOnCallTime { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TimeSpan get_CurrentLeaseTime();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract LeaseState get_CurrentState();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract TimeSpan get_RenewOnCallTime();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract TimeSpan Renew(TimeSpan renewalTime);
}

// Namespace: System.Runtime.Remoting.Lifetime
[ComVisible(True)]
public interface ISponsor // TypeDefIndex: 3745
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TimeSpan Renewal(ILease lease);
}

// Namespace: 
private sealed class Lease.RenewalDelegate : MulticastDelegate // TypeDefIndex: 3746
{
	// Methods

	// RVA: 0x16390A0 Offset: 0x16382A0 VA: 0x1816390A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual TimeSpan Invoke(ILease lease) { }

	// RVA: 0x3FD210 Offset: 0x3FC410 VA: 0x1803FD210 Slot: 14
	public virtual IAsyncResult BeginInvoke(ILease lease, AsyncCallback callback, object object) { }

	// RVA: 0x425AE0 Offset: 0x424CE0 VA: 0x180425AE0 Slot: 15
	public virtual TimeSpan EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Runtime.Remoting.Lifetime
internal class Lease : MarshalByRefObject, ILease // TypeDefIndex: 3747
{
	// Fields
	private DateTime _leaseExpireTime; // 0x18
	private LeaseState _currentState; // 0x20
	private TimeSpan _initialLeaseTime; // 0x28
	private TimeSpan _renewOnCallTime; // 0x30
	private TimeSpan _sponsorshipTimeout; // 0x38
	private ArrayList _sponsors; // 0x40
	private Queue _renewingSponsors; // 0x48
	private Lease.RenewalDelegate _renewalDelegate; // 0x50

	// Properties
	public TimeSpan CurrentLeaseTime { get; }
	public LeaseState CurrentState { get; }
	public TimeSpan RenewOnCallTime { get; }

	// Methods

	// RVA: 0x162C780 Offset: 0x162B980 VA: 0x18162C780
	public void .ctor() { }

	// RVA: 0x162C8F0 Offset: 0x162BAF0 VA: 0x18162C8F0 Slot: 6
	public TimeSpan get_CurrentLeaseTime() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 7
	public LeaseState get_CurrentState() { }

	// RVA: 0x162BAE0 Offset: 0x162ACE0 VA: 0x18162BAE0
	public void Activate() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 8
	public TimeSpan get_RenewOnCallTime() { }

	// RVA: 0x162C3C0 Offset: 0x162B5C0 VA: 0x18162C3C0 Slot: 9
	public TimeSpan Renew(TimeSpan renewalTime) { }

	// RVA: 0x162C490 Offset: 0x162B690 VA: 0x18162C490 Slot: 10
	public void Unregister(ISponsor obj) { }

	// RVA: 0x162C5E0 Offset: 0x162B7E0 VA: 0x18162C5E0
	internal void UpdateState() { }

	// RVA: 0x162BAF0 Offset: 0x162ACF0 VA: 0x18162BAF0
	private void CheckNextSponsor() { }

	// RVA: 0x162BE50 Offset: 0x162B050 VA: 0x18162BE50
	private void ProcessSponsorResponse(object state, bool timedOut) { }
}

// Namespace: System.Runtime.Remoting.Lifetime
internal class LeaseManager // TypeDefIndex: 3748
{
	// Fields
	private ArrayList _objects; // 0x10
	private Timer _timer; // 0x18

	// Methods

	// RVA: 0x162B2A0 Offset: 0x162A4A0 VA: 0x18162B2A0
	public void SetPollTime(TimeSpan timeSpan) { }

	// RVA: 0x162B500 Offset: 0x162A700 VA: 0x18162B500
	public void TrackLifetime(ServerIdentity identity) { }

	// RVA: 0x162B370 Offset: 0x162A570 VA: 0x18162B370
	public void StartManager() { }

	// RVA: 0x162B4E0 Offset: 0x162A6E0 VA: 0x18162B4E0
	public void StopManager() { }

	// RVA: 0x162B040 Offset: 0x162A240 VA: 0x18162B040
	public void ManageLeases(object state) { }

	// RVA: 0x162B770 Offset: 0x162A970 VA: 0x18162B770
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Lifetime
internal class LeaseSink : IMessageSink // TypeDefIndex: 3749
{
	// Fields
	private IMessageSink _nextSink; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(IMessageSink nextSink) { }

	// RVA: 0x162BA70 Offset: 0x162AC70 VA: 0x18162BA70 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x162B7D0 Offset: 0x162A9D0 VA: 0x18162B7D0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x162B850 Offset: 0x162AA50 VA: 0x18162B850
	private void RenewLease(IMessage msg) { }
}

// Namespace: System.Runtime.Remoting.Lifetime
[ComVisible(True)]
[Serializable]
public enum LeaseState // TypeDefIndex: 3750
{
	// Fields
	public int value__; // 0x0
	public const LeaseState Null = 0;
	public const LeaseState Initial = 1;
	public const LeaseState Active = 2;
	public const LeaseState Renewing = 3;
	public const LeaseState Expired = 4;
}

// Namespace: System.Runtime.Remoting.Lifetime
[ComVisible(True)]
public sealed class LifetimeServices // TypeDefIndex: 3751
{
	// Fields
	private static TimeSpan _leaseManagerPollTime; // 0x0
	private static TimeSpan _leaseTime; // 0x8
	private static TimeSpan _renewOnCallTime; // 0x10
	private static TimeSpan _sponsorshipTimeout; // 0x18
	private static LeaseManager _leaseManager; // 0x20

	// Properties
	public static TimeSpan LeaseManagerPollTime { get; set; }
	public static TimeSpan LeaseTime { get; set; }
	public static TimeSpan RenewOnCallTime { get; set; }
	public static TimeSpan SponsorshipTimeout { get; set; }

	// Methods

	// RVA: 0x162C9C0 Offset: 0x162BBC0 VA: 0x18162C9C0
	private static void .cctor() { }

	// RVA: 0x162CB10 Offset: 0x162BD10 VA: 0x18162CB10
	public static TimeSpan get_LeaseManagerPollTime() { }

	// RVA: 0x162CC50 Offset: 0x162BE50 VA: 0x18162CC50
	public static void set_LeaseManagerPollTime(TimeSpan value) { }

	// RVA: 0x162CB60 Offset: 0x162BD60 VA: 0x18162CB60
	public static TimeSpan get_LeaseTime() { }

	// RVA: 0x162CCD0 Offset: 0x162BED0 VA: 0x18162CCD0
	public static void set_LeaseTime(TimeSpan value) { }

	// RVA: 0x162CBB0 Offset: 0x162BDB0 VA: 0x18162CBB0
	public static TimeSpan get_RenewOnCallTime() { }

	// RVA: 0x162CD30 Offset: 0x162BF30 VA: 0x18162CD30
	public static void set_RenewOnCallTime(TimeSpan value) { }

	// RVA: 0x162CC00 Offset: 0x162BE00 VA: 0x18162CC00
	public static TimeSpan get_SponsorshipTimeout() { }

	// RVA: 0x162CD90 Offset: 0x162BF90 VA: 0x18162CD90
	public static void set_SponsorshipTimeout(TimeSpan value) { }

	// RVA: 0x162C950 Offset: 0x162BB50 VA: 0x18162C950
	internal static void TrackLifetime(ServerIdentity identity) { }
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public class Context // TypeDefIndex: 3752
{
	// Fields
	private int domain_id; // 0x10
	private int context_id; // 0x14
	private UIntPtr static_data; // 0x18
	private UIntPtr data; // 0x20
	[ContextStatic]
	private static object[] local_slots; // 0x0
	private static IMessageSink default_server_context_sink; // 0x8
	private IMessageSink server_context_sink_chain; // 0x28
	private IMessageSink client_context_sink_chain; // 0x30
	private List<IContextProperty> context_properties; // 0x38
	private static int global_count; // 0x10
	private LocalDataStoreHolder _localDataStore; // 0x40
	private static LocalDataStoreMgr _localDataStoreMgr; // 0x18
	private static DynamicPropertyCollection global_dynamic_properties; // 0x20
	private DynamicPropertyCollection context_dynamic_properties; // 0x48
	private ContextCallbackObject callback_object; // 0x50

	// Properties
	public static Context DefaultContext { get; }
	public virtual int ContextID { get; }
	public virtual IContextProperty[] ContextProperties { get; }
	internal bool IsDefaultContext { get; }
	internal bool NeedsContextSink { get; }
	internal static bool HasGlobalDynamicSinks { get; }
	internal bool HasDynamicSinks { get; }
	internal bool HasExitSinks { get; }
	private LocalDataStore MyLocalStore { get; }

	// Methods

	// RVA: 0x1627520 Offset: 0x1626720 VA: 0x181627520
	private static void RegisterContext(Context ctx) { }

	// RVA: 0x1627740 Offset: 0x1626940 VA: 0x181627740
	private static void ReleaseContext(Context ctx) { }

	// RVA: 0x1627C30 Offset: 0x1626E30 VA: 0x181627C30
	public void .ctor() { }

	// RVA: 0x16269E0 Offset: 0x1625BE0 VA: 0x1816269E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x15AF230 Offset: 0x15AE430 VA: 0x1815AF230
	public static Context get_DefaultContext() { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 4
	public virtual int get_ContextID() { }

	// RVA: 0x1627CB0 Offset: 0x1626EB0 VA: 0x181627CB0 Slot: 5
	public virtual IContextProperty[] get_ContextProperties() { }

	// RVA: 0x1627FA0 Offset: 0x16271A0 VA: 0x181627FA0
	internal bool get_IsDefaultContext() { }

	// RVA: 0x1628120 Offset: 0x1627320 VA: 0x181628120
	internal bool get_NeedsContextSink() { }

	// RVA: 0x1627530 Offset: 0x1626730 VA: 0x181627530
	public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x16279C0 Offset: 0x1626BC0 VA: 0x1816279C0
	public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1626E40 Offset: 0x1626040 VA: 0x181626E40
	private static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1627400 Offset: 0x1626600 VA: 0x181627400
	internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1627EF0 Offset: 0x16270F0 VA: 0x181627EF0
	internal static bool get_HasGlobalDynamicSinks() { }

	// RVA: 0x1627360 Offset: 0x1626560 VA: 0x181627360
	internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1627D10 Offset: 0x1626F10 VA: 0x181627D10
	internal bool get_HasDynamicSinks() { }

	// RVA: 0x1627D60 Offset: 0x1626F60 VA: 0x181627D60
	internal bool get_HasExitSinks() { }

	// RVA: 0x1627080 Offset: 0x1626280 VA: 0x181627080 Slot: 6
	public virtual IContextProperty GetProperty(string name) { }

	// RVA: 0x16277A0 Offset: 0x16269A0 VA: 0x1816277A0 Slot: 7
	public virtual void SetProperty(IContextProperty prop) { }

	// RVA: 0x1626AE0 Offset: 0x1625CE0 VA: 0x181626AE0 Slot: 8
	public virtual void Freeze() { }

	// RVA: 0x1627970 Offset: 0x1626B70 VA: 0x181627970 Slot: 3
	public override string ToString() { }

	// RVA: 0x16271F0 Offset: 0x16263F0 VA: 0x1816271F0
	internal IMessageSink GetServerContextSinkChain() { }

	// RVA: 0x1626C90 Offset: 0x1625E90 VA: 0x181626C90
	internal IMessageSink GetClientContextSinkChain() { }

	// RVA: 0x1626750 Offset: 0x1625950 VA: 0x181626750
	internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x1625EF0 Offset: 0x16250F0 VA: 0x181625EF0
	internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject) { }

	// RVA: 0x1627960 Offset: 0x1626B60 VA: 0x181627960
	internal static Context SwitchToContext(Context newContext) { }

	// RVA: 0x1626080 Offset: 0x1625280 VA: 0x181626080
	internal static Context CreateNewContext(IConstructionCallMessage msg) { }

	// RVA: 0x16268B0 Offset: 0x1625AB0 VA: 0x1816268B0
	public void DoCallBack(CrossContextDelegate deleg) { }

	// RVA: 0x1627FB0 Offset: 0x16271B0 VA: 0x181627FB0
	private LocalDataStore get_MyLocalStore() { }

	// RVA: 0x1625E20 Offset: 0x1625020 VA: 0x181625E20
	public static LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x1625E80 Offset: 0x1625080 VA: 0x181625E80
	public static LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x1626A70 Offset: 0x1625C70 VA: 0x181626A70
	public static void FreeNamedDataSlot(string name) { }

	// RVA: 0x1627010 Offset: 0x1626210 VA: 0x181627010
	public static LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x1626E00 Offset: 0x1626000 VA: 0x181626E00
	public static object GetData(LocalDataStoreSlot slot) { }

	// RVA: 0x1627750 Offset: 0x1626950 VA: 0x181627750
	public static void SetData(LocalDataStoreSlot slot, object data) { }

	// RVA: 0x1627BD0 Offset: 0x1626DD0 VA: 0x181627BD0
	private static void .cctor() { }
}

// Namespace: 
private class DynamicPropertyCollection.DynamicPropertyReg // TypeDefIndex: 3753
{
	// Fields
	public IDynamicProperty Property; // 0x10
	public IDynamicMessageSink Sink; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Contexts
internal class DynamicPropertyCollection // TypeDefIndex: 3754
{
	// Fields
	private ArrayList _properties; // 0x10

	// Properties
	public bool HasProperties { get; }

	// Methods

	// RVA: 0x162A2E0 Offset: 0x16294E0 VA: 0x18162A2E0
	public bool get_HasProperties() { }

	// RVA: 0x1629F20 Offset: 0x1629120 VA: 0x181629F20
	public bool RegisterDynamicProperty(IDynamicProperty prop) { }

	// RVA: 0x162A130 Offset: 0x1629330 VA: 0x18162A130
	public bool UnregisterDynamicProperty(string name) { }

	// RVA: 0x1629AA0 Offset: 0x1628CA0 VA: 0x181629AA0
	public void NotifyMessage(bool start, IMessage msg, bool client_site, bool async) { }

	// RVA: 0x1629900 Offset: 0x1628B00 VA: 0x181629900
	private int FindProperty(string name) { }

	// RVA: 0x162A280 Offset: 0x1629480 VA: 0x18162A280
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Contexts
internal class ContextCallbackObject : ContextBoundObject // TypeDefIndex: 3755
{
	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void DoCallBack(CrossContextDelegate deleg) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private class CrossContextChannel.ContextRestoreSink : IMessageSink // TypeDefIndex: 3756
{
	// Fields
	private IMessageSink _next; // 0x10
	private Context _context; // 0x18
	private IMessage _call; // 0x20

	// Methods

	// RVA: 0x3F6C30 Offset: 0x3F5E30 VA: 0x1803F6C30
	public void .ctor(IMessageSink next, Context context, IMessage call) { }

	// RVA: 0x1625C00 Offset: 0x1624E00 VA: 0x181625C00 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1625BC0 Offset: 0x1624DC0 VA: 0x181625BC0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting.Contexts
internal class CrossContextChannel : IMessageSink // TypeDefIndex: 3757
{
	// Methods

	// RVA: 0x16294B0 Offset: 0x16286B0 VA: 0x1816294B0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1629100 Offset: 0x1628300 VA: 0x181629100 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public sealed class CrossContextDelegate : MulticastDelegate // TypeDefIndex: 3758
{
	// Methods

	// RVA: 0x458710 Offset: 0x457910 VA: 0x180458710
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4240E0 Offset: 0x4232E0 VA: 0x1804240E0 Slot: 13
	public virtual void Invoke() { }
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IContextAttribute // TypeDefIndex: 3759
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetPropertiesForNewContext(IConstructionCallMessage msg);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsContextOK(Context ctx, IConstructionCallMessage msg);
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IContextProperty // TypeDefIndex: 3760
{
	// Properties
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Freeze(Context newContext);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsNewContextOK(Context newCtx);
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IContributeClientContextSink // TypeDefIndex: 3761
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink GetClientContextSink(IMessageSink nextSink);
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IContributeDynamicSink // TypeDefIndex: 3762
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDynamicMessageSink GetDynamicSink();
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IContributeEnvoySink // TypeDefIndex: 3763
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink GetEnvoySink(MarshalByRefObject obj, IMessageSink nextSink);
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IContributeObjectSink // TypeDefIndex: 3764
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink GetObjectSink(MarshalByRefObject obj, IMessageSink nextSink);
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IContributeServerContextSink // TypeDefIndex: 3765
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink GetServerContextSink(IMessageSink nextSink);
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IDynamicMessageSink // TypeDefIndex: 3766
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ProcessMessageFinish(IMessage replyMsg, bool bCliSide, bool bAsync);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ProcessMessageStart(IMessage reqMsg, bool bCliSide, bool bAsync);
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IDynamicProperty // TypeDefIndex: 3767
{
	// Properties
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();
}

// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
public sealed class ChannelServices // TypeDefIndex: 3768
{
	// Fields
	private static ArrayList registeredChannels; // 0x0
	private static ArrayList delayedClientChannels; // 0x8
	private static CrossContextChannel _crossContextSink; // 0x10
	internal static string CrossContextUrl; // 0x18
	private static IList oldStartModeTypes; // 0x20

	// Properties
	internal static CrossContextChannel CrossContextChannel { get; }

	// Methods

	// RVA: 0x1621C00 Offset: 0x1620E00 VA: 0x181621C00
	internal static CrossContextChannel get_CrossContextChannel() { }

	// RVA: 0x161F6D0 Offset: 0x161E8D0 VA: 0x18161F6D0
	internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri) { }

	// RVA: 0x161F5B0 Offset: 0x161E7B0 VA: 0x18161F5B0
	internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, out string objectUri) { }

	[Obsolete("Use RegisterChannel(IChannel,Boolean)")]
	// RVA: 0x1621970 Offset: 0x1620B70 VA: 0x181621970
	public static void RegisterChannel(IChannel chnl) { }

	// RVA: 0x16212D0 Offset: 0x16204D0 VA: 0x1816212D0
	public static void RegisterChannel(IChannel chnl, bool ensureSecurity) { }

	// RVA: 0x1620320 Offset: 0x161F520 VA: 0x181620320
	internal static void RegisterChannelConfig(ChannelData channel) { }

	// RVA: 0x161FC80 Offset: 0x161EE80 VA: 0x18161FC80
	private static object CreateProvider(ProviderData prov) { }

	// RVA: 0x16219C0 Offset: 0x1620BC0 VA: 0x1816219C0
	public static IMessage SyncDispatchMessage(IMessage msg) { }

	// RVA: 0x161F1C0 Offset: 0x161E3C0 VA: 0x18161F1C0
	private static ReturnMessage CheckIncomingMessage(IMessage msg) { }

	// RVA: 0x161F3D0 Offset: 0x161E5D0 VA: 0x18161F3D0
	internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	private static bool IsLocalCall(IMessage callMsg) { }

	// RVA: 0x161FFA0 Offset: 0x161F1A0 VA: 0x18161FFA0
	internal static object[] GetCurrentChannelInfo() { }

	// RVA: 0x1621A90 Offset: 0x1620C90 VA: 0x181621A90
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting.Channels
[Serializable]
internal class CrossAppDomainData // TypeDefIndex: 3769
{
	// Fields
	private object _ContextID; // 0x10
	private int _DomainID; // 0x18
	private string _processGuid; // 0x20

	// Properties
	internal int DomainID { get; }
	internal string ProcessID { get; }

	// Methods

	// RVA: 0x16285C0 Offset: 0x16277C0 VA: 0x1816285C0
	internal void .ctor(int domainId) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	internal int get_DomainID() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal string get_ProcessID() { }
}

// Namespace: System.Runtime.Remoting.Channels
[Serializable]
internal class CrossAppDomainChannel : IChannel, IChannelSender, IChannelReceiver // TypeDefIndex: 3770
{
	// Fields
	private static object s_lock; // 0x0

	// Properties
	public virtual string ChannelName { get; }
	public virtual int ChannelPriority { get; }
	public virtual object ChannelData { get; }

	// Methods

	// RVA: 0x1628390 Offset: 0x1627590 VA: 0x181628390
	internal static void RegisterCrossAppDomainChannel() { }

	// RVA: 0x1628590 Offset: 0x1627790 VA: 0x181628590 Slot: 9
	public virtual string get_ChannelName() { }

	// RVA: 0xAA0150 Offset: 0xA9F350 VA: 0x180AA0150 Slot: 10
	public virtual int get_ChannelPriority() { }

	// RVA: 0x1628530 Offset: 0x1627730 VA: 0x181628530 Slot: 11
	public virtual object get_ChannelData() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 12
	public virtual void StartListening(object data) { }

	// RVA: 0x1628210 Offset: 0x1627410 VA: 0x181628210 Slot: 13
	public virtual IMessageSink CreateMessageSink(string url, object data, out string uri) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x16284D0 Offset: 0x16276D0 VA: 0x1816284D0
	private static void .cctor() { }
}

// Namespace: 
private struct CrossAppDomainSink.ProcessMessageRes // TypeDefIndex: 3771
{
	// Fields
	public byte[] arrResponse; // 0x0
	public CADMethodReturnMessage cadMrm; // 0x8
}

// Namespace: System.Runtime.Remoting.Channels
[MonoTODO("Handle domain unloading?")]
internal class CrossAppDomainSink : IMessageSink // TypeDefIndex: 3772
{
	// Fields
	private static Hashtable s_sinks; // 0x0
	private static MethodInfo processMessageMethod; // 0x8
	private int _domainID; // 0x10

	// Properties
	internal int TargetDomainId { get; }

	// Methods

	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	internal void .ctor(int domainID) { }

	// RVA: 0x1628710 Offset: 0x1627910 VA: 0x181628710
	internal static CrossAppDomainSink GetSink(int domainID) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	internal int get_TargetDomainId() { }

	// RVA: 0x16289F0 Offset: 0x1627BF0 VA: 0x1816289F0
	private static CrossAppDomainSink.ProcessMessageRes ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg) { }

	// RVA: 0x1628BD0 Offset: 0x1627DD0 VA: 0x181628BD0 Slot: 6
	public virtual IMessage SyncProcessMessage(IMessage msgRequest) { }

	// RVA: 0x1628650 Offset: 0x1627850 VA: 0x181628650 Slot: 7
	public virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink) { }

	// RVA: 0x1628AF0 Offset: 0x1627CF0 VA: 0x181628AF0
	public void SendAsyncMessage(object data) { }

	// RVA: 0x1629020 Offset: 0x1628220 VA: 0x181629020
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x1628F30 Offset: 0x1628130 VA: 0x181628F30
	private void <AsyncProcessMessage>b__10_0(object data) { }
}

// Namespace: System.Runtime.Remoting.Channels
internal class CADSerializer // TypeDefIndex: 3773
{
	// Methods

	// RVA: 0x161DE70 Offset: 0x161D070 VA: 0x18161DE70
	internal static IMessage DeserializeMessage(MemoryStream mem, IMethodCallMessage msg) { }

	// RVA: 0x161E040 Offset: 0x161D240 VA: 0x18161E040
	internal static MemoryStream SerializeMessage(IMessage msg) { }

	// RVA: 0x161DEB0 Offset: 0x161D0B0 VA: 0x18161DEB0
	internal static object DeserializeObjectSafe(byte[] mem) { }

	// RVA: 0x161E130 Offset: 0x161D330 VA: 0x18161E130
	internal static MemoryStream SerializeObject(object obj) { }

	// RVA: 0x161DFB0 Offset: 0x161D1B0 VA: 0x18161DFB0
	internal static object DeserializeObject(MemoryStream mem) { }
}

// Namespace: System.Runtime.Remoting.Channels
internal class AsyncRequest // TypeDefIndex: 3774
{
	// Fields
	internal IMessageSink ReplySink; // 0x10
	internal IMessage MsgRequest; // 0x18

	// Methods

	// RVA: 0x161DA80 Offset: 0x161CC80 VA: 0x18161DA80
	public void .ctor(IMessage msgRequest, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
public interface IChannel // TypeDefIndex: 3775
{
	// Properties
	public abstract string ChannelName { get; }
	public abstract int ChannelPriority { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_ChannelName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_ChannelPriority();
}

// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
[DefaultMember("Item")]
public interface IChannelDataStore // TypeDefIndex: 3776
{}

// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
public interface IChannelReceiver : IChannel // TypeDefIndex: 3777
{
	// Properties
	public abstract object ChannelData { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_ChannelData();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void StartListening(object data);
}

// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
public interface IChannelSender : IChannel // TypeDefIndex: 3778
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI);
}

// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
public interface IClientChannelSinkProvider // TypeDefIndex: 3779
{
	// Properties
	public abstract IClientChannelSinkProvider Next { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void set_Next(IClientChannelSinkProvider value);
}

// Namespace: System.Runtime.Remoting.Channels
public interface ISecurableChannel // TypeDefIndex: 3780
{
	// Properties
	public abstract bool IsSecured { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void set_IsSecured(bool value);
}

// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
public interface IServerChannelSinkProvider // TypeDefIndex: 3781
{
	// Properties
	public abstract IServerChannelSinkProvider Next { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void set_Next(IServerChannelSinkProvider value);
}

// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
public class SinkProviderData // TypeDefIndex: 3782
{
	// Fields
	private string sinkName; // 0x10
	private ArrayList children; // 0x18
	private Hashtable properties; // 0x20

	// Properties
	public IList Children { get; }
	public IDictionary Properties { get; }

	// Methods

	// RVA: 0x1639DF0 Offset: 0x1638FF0 VA: 0x181639DF0
	public void .ctor(string name) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public IList get_Children() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public IDictionary get_Properties() { }
}

// Namespace: System.Runtime.Remoting.Activation
internal class ActivationServices // TypeDefIndex: 3783
{
	// Fields
	private static IActivator _constructionActivator; // 0x0

	// Properties
	private static IActivator ConstructionActivator { get; }

	// Methods

	// RVA: 0x161D1A0 Offset: 0x161C3A0 VA: 0x18161D1A0
	private static IActivator get_ConstructionActivator() { }

	// RVA: 0x161C0F0 Offset: 0x161B2F0 VA: 0x18161C0F0
	public static IMessage Activate(RemotingProxy proxy, ConstructionCall ctorCall) { }

	// RVA: 0x161D0E0 Offset: 0x161C2E0 VA: 0x18161D0E0
	public static IMessage RemoteActivate(IConstructionCallMessage ctorCall) { }

	// RVA: 0x161C2B0 Offset: 0x161B4B0 VA: 0x18161C2B0
	public static ConstructionCall CreateConstructionCall(Type type, string activationUrl, object[] activationAttributes) { }

	// RVA: 0x161CB40 Offset: 0x161BD40 VA: 0x18161CB40
	public static IMessage CreateInstanceFromMessage(IConstructionCallMessage ctorCall) { }

	// RVA: 0x161CC40 Offset: 0x161BE40 VA: 0x18161CC40
	public static object CreateProxyForType(Type type) { }

	// RVA: 0x161C2A0 Offset: 0x161B4A0 VA: 0x18161C2A0
	public static object AllocateUninitializedClassInstance(Type type) { }

	// RVA: 0x161D0D0 Offset: 0x161C2D0 VA: 0x18161D0D0
	public static void EnableProxyActivation(Type type, bool enable) { }
}

// Namespace: System.Runtime.Remoting.Activation
internal class AppDomainLevelActivator : IActivator // TypeDefIndex: 3784
{
	// Fields
	private string _activationUrl; // 0x10
	private IActivator _next; // 0x18

	// Properties
	public IActivator NextActivator { get; }

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(string activationUrl, IActivator next) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	public IActivator get_NextActivator() { }

	// RVA: 0x161D390 Offset: 0x161C590 VA: 0x18161D390 Slot: 5
	public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }
}

// Namespace: System.Runtime.Remoting.Activation
[Serializable]
internal class ConstructionLevelActivator : IActivator // TypeDefIndex: 3785
{
	// Properties
	public IActivator NextActivator { get; }

	// Methods

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 4
	public IActivator get_NextActivator() { }

	// RVA: 0x1625850 Offset: 0x1624A50 VA: 0x181625850 Slot: 5
	public IConstructionReturnMessage Activate(IConstructionCallMessage msg) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Activation
[Serializable]
internal class ContextLevelActivator : IActivator // TypeDefIndex: 3786
{
	// Fields
	private IActivator m_NextActivator; // 0x10

	// Properties
	public IActivator NextActivator { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(IActivator next) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public IActivator get_NextActivator() { }

	// RVA: 0x1625900 Offset: 0x1624B00 VA: 0x181625900 Slot: 5
	public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }
}

// Namespace: System.Runtime.Remoting.Activation
[ComVisible(True)]
public interface IActivator // TypeDefIndex: 3787
{
	// Properties
	public abstract IActivator NextActivator { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IActivator get_NextActivator();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IConstructionReturnMessage Activate(IConstructionCallMessage msg);
}

// Namespace: System.Runtime.Remoting.Activation
[ComVisible(True)]
public interface IConstructionCallMessage : IMessage, IMethodCallMessage, IMethodMessage // TypeDefIndex: 3788
{
	// Properties
	public abstract Type ActivationType { get; }
	public abstract string ActivationTypeName { get; }
	public abstract IActivator Activator { get; set; }
	public abstract object[] CallSiteActivationAttributes { get; }
	public abstract IList ContextProperties { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Type get_ActivationType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_ActivationTypeName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IActivator get_Activator();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Activator(IActivator value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object[] get_CallSiteActivationAttributes();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IList get_ContextProperties();
}

// Namespace: System.Runtime.Remoting.Activation
[ComVisible(True)]
public interface IConstructionReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage // TypeDefIndex: 3789
{}

// Namespace: System.Runtime.Remoting.Activation
internal class RemoteActivationAttribute : Attribute, IContextAttribute // TypeDefIndex: 3790
{
	// Fields
	private IList _contextProperties; // 0x10

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(IList contextProperties) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 8
	public bool IsContextOK(Context ctx, IConstructionCallMessage ctor) { }

	// RVA: 0x1631210 Offset: 0x1630410 VA: 0x181631210 Slot: 7
	public void GetPropertiesForNewContext(IConstructionCallMessage ctor) { }
}

// Namespace: System.Runtime.Remoting.Activation
internal class RemoteActivator : MarshalByRefObject, IActivator // TypeDefIndex: 3791
{
	// Properties
	public IActivator NextActivator { get; }

	// Methods

	// RVA: 0x1631520 Offset: 0x1630720 VA: 0x181631520 Slot: 7
	public IConstructionReturnMessage Activate(IConstructionCallMessage msg) { }

	// RVA: 0x16317A0 Offset: 0x16309A0 VA: 0x1816317A0 Slot: 6
	public IActivator get_NextActivator() { }
}

// Namespace: System.Runtime.Remoting.Metadata
[ComVisible(True)]
public class SoapAttribute : Attribute // TypeDefIndex: 3792
{
	// Fields
	private bool _useAttribute; // 0x10
	protected string ProtXmlNamespace; // 0x18
	protected object ReflectInfo; // 0x20

	// Properties
	public virtual bool UseAttribute { get; }
	public virtual string XmlNamespace { get; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0 Slot: 7
	public virtual bool get_UseAttribute() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	public virtual string get_XmlNamespace() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0 Slot: 9
	internal virtual void SetReflectionObject(object reflectionObject) { }
}

// Namespace: System.Runtime.Remoting.Metadata
[Usage(256)]
[ComVisible(True)]
public sealed class SoapFieldAttribute : SoapAttribute // TypeDefIndex: 3793
{
	// Fields
	private string _elementName; // 0x28
	private bool _isElement; // 0x30

	// Properties
	public string XmlElementName { get; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_XmlElementName() { }

	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	public bool IsInteropXmlElement() { }

	// RVA: 0x1639E80 Offset: 0x1639080 VA: 0x181639E80 Slot: 9
	internal override void SetReflectionObject(object reflectionObject) { }
}

// Namespace: System.Runtime.Remoting.Metadata
[Usage(64)]
[ComVisible(True)]
public sealed class SoapMethodAttribute : SoapAttribute // TypeDefIndex: 3794
{
	// Fields
	private string _responseElement; // 0x28
	private string _responseNamespace; // 0x30
	private string _returnElement; // 0x38
	private string _soapAction; // 0x40
	private bool _useAttribute; // 0x48
	private string _namespace; // 0x50

	// Properties
	public override bool UseAttribute { get; }
	public override string XmlNamespace { get; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x445A70 Offset: 0x444C70 VA: 0x180445A70 Slot: 7
	public override bool get_UseAttribute() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0 Slot: 8
	public override string get_XmlNamespace() { }

	// RVA: 0x1639F40 Offset: 0x1639140 VA: 0x181639F40 Slot: 9
	internal override void SetReflectionObject(object reflectionObject) { }
}

// Namespace: System.Runtime.Remoting.Metadata
[Usage(2048)]
[ComVisible(True)]
public sealed class SoapParameterAttribute : SoapAttribute // TypeDefIndex: 3795
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Metadata
[Usage(1052)]
[ComVisible(True)]
public sealed class SoapTypeAttribute : SoapAttribute // TypeDefIndex: 3796
{
	// Fields
	private bool _useAttribute; // 0x28
	private string _xmlElementName; // 0x30
	private string _xmlNamespace; // 0x38
	private string _xmlTypeName; // 0x40
	private string _xmlTypeNamespace; // 0x48
	private bool _isType; // 0x50
	private bool _isElement; // 0x51

	// Properties
	public override bool UseAttribute { get; }
	public string XmlElementName { get; }
	public override string XmlNamespace { get; }
	public string XmlTypeName { get; }
	public string XmlTypeNamespace { get; }
	internal bool IsInteropXmlElement { get; }
	internal bool IsInteropXmlType { get; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840 Slot: 7
	public override bool get_UseAttribute() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_XmlElementName() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 8
	public override string get_XmlNamespace() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public string get_XmlTypeName() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public string get_XmlTypeNamespace() { }

	// RVA: 0x163B670 Offset: 0x163A870 VA: 0x18163B670
	internal bool get_IsInteropXmlElement() { }

	// RVA: 0x4D1A10 Offset: 0x4D0C10 VA: 0x1804D1A10
	internal bool get_IsInteropXmlType() { }

	// RVA: 0x163B420 Offset: 0x163A620 VA: 0x18163B420 Slot: 9
	internal override void SetReflectionObject(object reflectionObject) { }
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
[Serializable]
public sealed class CallContext // TypeDefIndex: 3797
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	internal static object SetCurrentCallContext(LogicalCallContext ctx) { }

	// RVA: 0x161E580 Offset: 0x161D780 VA: 0x18161E580
	internal static LogicalCallContext SetLogicalCallContext(LogicalCallContext callCtx) { }

	// RVA: 0x161E310 Offset: 0x161D510 VA: 0x18161E310
	public static object LogicalGetData(string name) { }

	// RVA: 0x161E3E0 Offset: 0x161D5E0 VA: 0x18161E3E0
	public static void LogicalSetData(string name, object data) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class IllogicalCallContext // TypeDefIndex: 3798
{
	// Fields
	private Hashtable m_Datastore; // 0x10
	private object m_HostContext; // 0x18

	// Properties
	private Hashtable Datastore { get; }
	internal object HostContext { get; set; }
	internal bool HasUserData { get; }

	// Methods

	// RVA: 0x162A960 Offset: 0x1629B60 VA: 0x18162A960
	private Hashtable get_Datastore() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal object get_HostContext() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void set_HostContext(object value) { }

	// RVA: 0x162A9D0 Offset: 0x1629BD0 VA: 0x18162A9D0
	internal bool get_HasUserData() { }

	// RVA: 0x162A8D0 Offset: 0x1629AD0 VA: 0x18162A8D0
	public void FreeNamedDataSlot(string name) { }

	// RVA: 0x162A5B0 Offset: 0x16297B0 VA: 0x18162A5B0
	public IllogicalCallContext CreateCopy() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
internal struct LogicalCallContext.Reader // TypeDefIndex: 3799
{
	// Fields
	private LogicalCallContext m_ctx; // 0x0

	// Properties
	public bool IsNull { get; }
	public bool HasInfo { get; }

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void .ctor(LogicalCallContext ctx) { }

	// RVA: 0x12175A0 Offset: 0x12167A0 VA: 0x1812175A0
	public bool get_IsNull() { }

	// RVA: 0x162FE10 Offset: 0x162F010 VA: 0x18162FE10
	public bool get_HasInfo() { }

	// RVA: 0x162FD00 Offset: 0x162EF00 VA: 0x18162FD00
	public LogicalCallContext Clone() { }

	// RVA: 0x162FD70 Offset: 0x162EF70 VA: 0x18162FD70
	public object GetData(string name) { }
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
[Serializable]
public sealed class LogicalCallContext : ISerializable, ICloneable // TypeDefIndex: 3800
{
	// Fields
	private static Type s_callContextType; // 0x0
	private const string s_CorrelationMgrSlotName = "System.Diagnostics.Trace.CorrelationManagerSlot";
	private Hashtable m_Datastore; // 0x10
	private CallContextRemotingData m_RemotingData; // 0x18
	private CallContextSecurityData m_SecurityData; // 0x20
	private object m_HostContext; // 0x28
	private bool m_IsCorrelationMgr; // 0x30
	private Header[] _sendHeaders; // 0x38
	private Header[] _recvHeaders; // 0x40

	// Properties
	public bool HasInfo { get; }
	private bool HasUserData { get; }
	private Hashtable Datastore { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x162DE90 Offset: 0x162D090 VA: 0x18162DE90
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x162D640 Offset: 0x162C840 VA: 0x18162D640 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x162CDF0 Offset: 0x162BFF0 VA: 0x18162CDF0 Slot: 5
	public object Clone() { }

	// RVA: 0x162DA10 Offset: 0x162CC10 VA: 0x18162DA10
	internal void Merge(LogicalCallContext lc) { }

	// RVA: 0x162E1B0 Offset: 0x162D3B0 VA: 0x18162E1B0
	public bool get_HasInfo() { }

	// RVA: 0x162A9D0 Offset: 0x1629BD0 VA: 0x18162A9D0
	private bool get_HasUserData() { }

	// RVA: 0x162E140 Offset: 0x162D340 VA: 0x18162E140
	private Hashtable get_Datastore() { }

	// RVA: 0x162D5B0 Offset: 0x162C7B0 VA: 0x18162D5B0
	public object GetData(string name) { }

	// RVA: 0x162DD30 Offset: 0x162CF30 VA: 0x18162DD30
	public void SetData(string name, object data) { }

	// RVA: 0x162DE10 Offset: 0x162D010 VA: 0x18162DE10
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class CallContextSecurityData : ICloneable // TypeDefIndex: 3801
{
	// Fields
	private IPrincipal _principal; // 0x10

	// Properties
	internal bool HasInfo { get; }

	// Methods

	// RVA: 0x161E290 Offset: 0x161D490 VA: 0x18161E290
	internal bool get_HasInfo() { }

	// RVA: 0x161E2A0 Offset: 0x161D4A0 VA: 0x18161E2A0 Slot: 4
	public object Clone() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class CallContextRemotingData : ICloneable // TypeDefIndex: 3802
{
	// Fields
	private string _logicalCallID; // 0x10

	// Properties
	internal string LogicalCallID { get; set; }
	internal bool HasInfo { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal string get_LogicalCallID() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void set_LogicalCallID(string value) { }

	// RVA: 0x161E290 Offset: 0x161D490 VA: 0x18161E290
	internal bool get_HasInfo() { }

	// RVA: 0x161E220 Offset: 0x161D420 VA: 0x18161E220 Slot: 4
	public object Clone() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal enum ArgInfoType // TypeDefIndex: 3803
{
	// Fields
	public byte value__; // 0x0
	public const ArgInfoType In = 0;
	public const ArgInfoType Out = 1;
}

// Namespace: System.Runtime.Remoting.Messaging
internal class ArgInfo // TypeDefIndex: 3804
{
	// Fields
	private int[] _paramMap; // 0x10
	private int _inoutArgCount; // 0x18
	private MethodBase _method; // 0x20

	// Methods

	// RVA: 0x161D8B0 Offset: 0x161CAB0 VA: 0x18161D8B0
	public void .ctor(MethodBase method, ArgInfoType type) { }

	// RVA: 0x161D7B0 Offset: 0x161C9B0 VA: 0x18161D7B0
	public object[] GetInOutArgs(object[] args) { }
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public class AsyncResult : IAsyncResult, IMessageSink, IThreadPoolWorkItem // TypeDefIndex: 3805
{
	// Fields
	private object async_state; // 0x10
	private WaitHandle handle; // 0x18
	private object async_delegate; // 0x20
	private IntPtr data; // 0x28
	private object object_data; // 0x30
	private bool sync_completed; // 0x38
	private bool completed; // 0x39
	private bool endinvoke_called; // 0x3A
	private object async_callback; // 0x40
	private ExecutionContext current; // 0x48
	private ExecutionContext original; // 0x50
	private long add_time; // 0x58
	private MonoMethodMessage call_message; // 0x60
	private IMessageCtrl message_ctrl; // 0x68
	private IMessage reply_message; // 0x70
	private WaitCallback orig_cb; // 0x78

	// Properties
	public virtual object AsyncState { get; }
	public virtual WaitHandle AsyncWaitHandle { get; }
	public virtual bool CompletedSynchronously { get; }
	public virtual bool IsCompleted { get; }
	public bool EndInvokeCalled { get; set; }
	public virtual object AsyncDelegate { get; }
	public IMessageSink NextSink { get; }
	internal MonoMethodMessage CallMessage { get; set; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 12
	public virtual object get_AsyncState() { }

	// RVA: 0x161DD70 Offset: 0x161CF70 VA: 0x18161DD70 Slot: 13
	public virtual WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700 Slot: 14
	public virtual bool get_CompletedSynchronously() { }

	// RVA: 0x4BD740 Offset: 0x4BC940 VA: 0x1804BD740 Slot: 15
	public virtual bool get_IsCompleted() { }

	// RVA: 0x161DE50 Offset: 0x161D050 VA: 0x18161DE50
	public bool get_EndInvokeCalled() { }

	// RVA: 0x161DE60 Offset: 0x161D060 VA: 0x18161DE60
	public void set_EndInvokeCalled(bool value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 16
	public virtual object get_AsyncDelegate() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 17
	public IMessageSink get_NextSink() { }

	// RVA: 0x161DAC0 Offset: 0x161CCC0 VA: 0x18161DAC0 Slot: 18
	public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980 Slot: 19
	public virtual IMessage GetReplyMessage() { }

	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80 Slot: 20
	public virtual void SetMessageCtrl(IMessageCtrl mc) { }

	// RVA: 0x4BD760 Offset: 0x4BC960 VA: 0x1804BD760
	internal void SetCompletedSynchronously(bool completed) { }

	// RVA: 0x161DB00 Offset: 0x161CD00 VA: 0x18161DB00
	internal IMessage EndInvoke() { }

	// RVA: 0x161DC00 Offset: 0x161CE00 VA: 0x18161DC00 Slot: 21
	public virtual IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	internal MonoMethodMessage get_CallMessage() { }

	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	internal void set_CallMessage(MonoMethodMessage value) { }

	// RVA: 0x161DBF0 Offset: 0x161CDF0 VA: 0x18161DBF0 Slot: 10
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 11
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x161DBF0 Offset: 0x161CDF0 VA: 0x18161DBF0
	internal object Invoke() { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class CADArgHolder // TypeDefIndex: 3806
{
	// Fields
	public int index; // 0x10

	// Methods

	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int i) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class CADObjRef // TypeDefIndex: 3807
{
	// Fields
	internal ObjRef objref; // 0x10
	internal int SourceDomain; // 0x18
	internal byte[] TypeInfo; // 0x20

	// Methods

	// RVA: 0x1641E20 Offset: 0x1641020 VA: 0x181641E20
	public void .ctor(ObjRef o, int sourceDomain) { }
}

// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class CADMethodRef // TypeDefIndex: 3808
{
	// Fields
	private bool ctor; // 0x10
	private string typeName; // 0x18
	private string methodName; // 0x20
	private string[] param_names; // 0x28
	private string[] generic_arg_names; // 0x30

	// Methods

	// RVA: 0x1640FC0 Offset: 0x16401C0 VA: 0x181640FC0
	private Type[] GetTypes(string[] typeArray) { }

	// RVA: 0x1641100 Offset: 0x1640300 VA: 0x181641100
	public MethodBase Resolve() { }

	// RVA: 0x16416A0 Offset: 0x16408A0 VA: 0x1816416A0
	public void .ctor(IMethodMessage msg) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class CADMessageBase // TypeDefIndex: 3809
{
	// Fields
	protected object[] _args; // 0x10
	protected byte[] _serializedArgs; // 0x18
	protected int _propertyCount; // 0x20
	protected CADArgHolder _callContext; // 0x28
	internal byte[] serializedMethod; // 0x30

	// Methods

	// RVA: 0x1640AF0 Offset: 0x163FCF0 VA: 0x181640AF0
	public void .ctor(IMethodMessage msg) { }

	// RVA: 0x163ED70 Offset: 0x163DF70 VA: 0x18163ED70
	internal MethodBase GetMethod() { }

	// RVA: 0x163EE50 Offset: 0x163E050 VA: 0x18163EE50
	protected static Type[] GetSignature(MethodBase methodBase, bool load) { }

	// RVA: 0x163F6C0 Offset: 0x163E8C0 VA: 0x18163F6C0
	internal static int MarshalProperties(IDictionary dict, ref ArrayList args) { }

	// RVA: 0x1640970 Offset: 0x163FB70 VA: 0x181640970
	internal static void UnmarshalProperties(IDictionary dict, int count, ArrayList args) { }

	// RVA: 0x163F060 Offset: 0x163E260 VA: 0x18163F060
	private static bool IsPossibleToIgnoreMarshal(object obj) { }

	// RVA: 0x163F210 Offset: 0x163E410 VA: 0x18163F210
	protected object MarshalArgument(object arg, ref ArrayList args) { }

	// RVA: 0x163FD10 Offset: 0x163EF10 VA: 0x18163FD10
	protected object UnmarshalArgument(object arg, ArrayList args) { }

	// RVA: 0x163F580 Offset: 0x163E780 VA: 0x18163F580
	internal object[] MarshalArguments(object[] arguments, ref ArrayList args) { }

	// RVA: 0x1640830 Offset: 0x163FA30 VA: 0x181640830
	internal object[] UnmarshalArguments(object[] arguments, ArrayList args) { }

	// RVA: 0x163FBA0 Offset: 0x163EDA0 VA: 0x18163FBA0
	protected void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList) { }

	// RVA: 0x163ECE0 Offset: 0x163DEE0 VA: 0x18163ECE0
	internal LogicalCallContext GetLogicalCallContext(ArrayList args) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class CADMethodCallMessage : CADMessageBase // TypeDefIndex: 3810
{
	// Fields
	private string _uri; // 0x38

	// Properties
	internal string Uri { get; }
	internal int PropertiesCount { get; }

	// Methods

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	internal string get_Uri() { }

	// RVA: 0x1640B90 Offset: 0x163FD90 VA: 0x181640B90
	internal static CADMethodCallMessage Create(IMessage callMsg) { }

	// RVA: 0x1640D70 Offset: 0x163FF70 VA: 0x181640D70
	internal void .ctor(IMethodCallMessage callMsg) { }

	// RVA: 0x1640C30 Offset: 0x163FE30 VA: 0x181640C30
	internal ArrayList GetArguments() { }

	// RVA: 0x1640C20 Offset: 0x163FE20 VA: 0x181640C20
	internal object[] GetArgs(ArrayList args) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	internal int get_PropertiesCount() { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class CADMethodReturnMessage : CADMessageBase // TypeDefIndex: 3811
{
	// Fields
	private object _returnValue; // 0x38
	private CADArgHolder _exception; // 0x40
	private Type[] _sig; // 0x48

	// Properties
	internal int PropertiesCount { get; }

	// Methods

	// RVA: 0x1641920 Offset: 0x1640B20 VA: 0x181641920
	internal static CADMethodReturnMessage Create(IMessage callMsg) { }

	// RVA: 0x1641BD0 Offset: 0x1640DD0 VA: 0x181641BD0
	internal void .ctor(IMethodReturnMessage retMsg) { }

	// RVA: 0x16419B0 Offset: 0x1640BB0 VA: 0x1816419B0
	internal ArrayList GetArguments() { }

	// RVA: 0x1640C20 Offset: 0x163FE20 VA: 0x181640C20
	internal object[] GetArgs(ArrayList args) { }

	// RVA: 0x1641BC0 Offset: 0x1640DC0 VA: 0x181641BC0
	internal object GetReturnValue(ArrayList args) { }

	// RVA: 0x1641AF0 Offset: 0x1640CF0 VA: 0x181641AF0
	internal Exception GetException(ArrayList args) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	internal int get_PropertiesCount() { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class ClientContextTerminatorSink : IMessageSink // TypeDefIndex: 3812
{
	// Fields
	private Context _context; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(Context ctx) { }

	// RVA: 0x1642190 Offset: 0x1641390 VA: 0x181642190 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1641F70 Offset: 0x1641170 VA: 0x181641F70 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class ClientContextReplySink : IMessageSink // TypeDefIndex: 3813
{
	// Fields
	private IMessageSink _replySink; // 0x10
	private Context _context; // 0x18

	// Methods

	// RVA: 0x161DA80 Offset: 0x161CC80 VA: 0x18161DA80
	public void .ctor(Context ctx, IMessageSink replySink) { }

	// RVA: 0x1641EB0 Offset: 0x16410B0 VA: 0x181641EB0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1641E70 Offset: 0x1641070 VA: 0x181641E70 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
[CLSCompliant(False)]
[Serializable]
public class ConstructionCall : MethodCall, IConstructionCallMessage, IMessage, IMethodCallMessage, IMethodMessage // TypeDefIndex: 3814
{
	// Fields
	private IActivator _activator; // 0x68
	private object[] _activationAttributes; // 0x70
	private IList _contextProperties; // 0x78
	private Type _activationType; // 0x80
	private string _activationTypeName; // 0x88
	private bool _isContextOk; // 0x90
	private RemotingProxy _sourceProxy; // 0x98

	// Properties
	internal bool IsContextOk { get; set; }
	public Type ActivationType { get; }
	public string ActivationTypeName { get; }
	public IActivator Activator { get; set; }
	public object[] CallSiteActivationAttributes { get; }
	public IList ContextProperties { get; }
	public override IDictionary Properties { get; }
	internal RemotingProxy SourceProxy { get; set; }

	// Methods

	// RVA: 0x1643A40 Offset: 0x1642C40 VA: 0x181643A40
	internal void .ctor(Type type) { }

	// RVA: 0x1643910 Offset: 0x1642B10 VA: 0x181643910
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1643490 Offset: 0x1642690 VA: 0x181643490 Slot: 22
	internal override void InitDictionary() { }

	// RVA: 0x5C4DE0 Offset: 0x5C3FE0 VA: 0x1805C4DE0
	internal bool get_IsContextOk() { }

	// RVA: 0x834530 Offset: 0x833730 VA: 0x180834530
	internal void set_IsContextOk(bool value) { }

	// RVA: 0x1643AA0 Offset: 0x1642CA0 VA: 0x181643AA0 Slot: 24
	public Type get_ActivationType() { }

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870 Slot: 25
	public string get_ActivationTypeName() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00 Slot: 26
	public IActivator get_Activator() { }

	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80 Slot: 27
	public void set_Activator(IActivator value) { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980 Slot: 28
	public object[] get_CallSiteActivationAttributes() { }

	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30
	internal void SetActivationAttributes(object[] attributes) { }

	// RVA: 0x1643B60 Offset: 0x1642D60 VA: 0x181643B60 Slot: 29
	public IList get_ContextProperties() { }

	// RVA: 0x1643570 Offset: 0x1642770 VA: 0x181643570 Slot: 19
	internal override void InitMethodProperty(string key, object value) { }

	// RVA: 0x1642B60 Offset: 0x1641D60 VA: 0x181642B60 Slot: 20
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1643BD0 Offset: 0x1642DD0 VA: 0x181643BD0 Slot: 21
	public override IDictionary get_Properties() { }

	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50
	internal RemotingProxy get_SourceProxy() { }

	// RVA: 0x834540 Offset: 0x833740 VA: 0x180834540
	internal void set_SourceProxy(RemotingProxy value) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class ConstructionCallDictionary : MessageDictionary // TypeDefIndex: 3815
{
	// Fields
	public static string[] InternalKeys; // 0x0

	// Methods

	// RVA: 0x1642AE0 Offset: 0x1641CE0 VA: 0x181642AE0
	public void .ctor(IConstructionCallMessage message) { }

	// RVA: 0x1642340 Offset: 0x1641540 VA: 0x181642340 Slot: 21
	protected override object GetMethodProperty(string key) { }

	// RVA: 0x16426F0 Offset: 0x16418F0 VA: 0x1816426F0 Slot: 22
	protected override void SetMethodProperty(string key, object value) { }

	// RVA: 0x1642910 Offset: 0x1641B10 VA: 0x181642910
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[CLSCompliant(False)]
[ComVisible(True)]
[Serializable]
public class ConstructionResponse : MethodResponse, IConstructionReturnMessage, IMethodReturnMessage, IMethodMessage, IMessage // TypeDefIndex: 3816
{
	// Properties
	public override IDictionary Properties { get; }

	// Methods

	// RVA: 0x1643C10 Offset: 0x1642E10 VA: 0x181643C10
	internal void .ctor(object resultObject, LogicalCallContext callCtx, IMethodCallMessage msg) { }

	// RVA: 0x1643CA0 Offset: 0x1642EA0 VA: 0x181643CA0
	internal void .ctor(Exception e, IMethodCallMessage msg) { }

	// RVA: 0x1643D60 Offset: 0x1642F60 VA: 0x181643D60
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1643E70 Offset: 0x1643070 VA: 0x181643E70 Slot: 22
	public override IDictionary get_Properties() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class EnvoyTerminatorSink : IMessageSink // TypeDefIndex: 3817
{
	// Fields
	public static EnvoyTerminatorSink Instance; // 0x0

	// Methods

	// RVA: 0x16443F0 Offset: 0x16435F0 VA: 0x1816443F0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1644370 Offset: 0x1643570 VA: 0x181644370 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1644450 Offset: 0x1643650 VA: 0x181644450
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class ErrorMessage : IMethodCallMessage, IMethodMessage, IMessage // TypeDefIndex: 3818
{
	// Fields
	private string _uri; // 0x10

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public virtual IDictionary Properties { get; }
	public string TypeName { get; }
	public string Uri { get; }
	public LogicalCallContext LogicalCallContext { get; }

	// Methods

	// RVA: 0x16444B0 Offset: 0x16436B0 VA: 0x1816444B0
	public void .ctor() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x16444F0 Offset: 0x16436F0 VA: 0x1816444F0 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 14
	public virtual IDictionary get_Properties() { }

	// RVA: 0x1644520 Offset: 0x1643720 VA: 0x181644520 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 11
	public string get_Uri() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 12
	public object GetArg(int arg_num) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
[Serializable]
public class Header // TypeDefIndex: 3819
{
	// Fields
	public string HeaderNamespace; // 0x10
	public bool MustUnderstand; // 0x18
	public string Name; // 0x20
	public object Value; // 0x28
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public sealed class HeaderHandler : MulticastDelegate // TypeDefIndex: 3820
{
	// Methods

	// RVA: 0x16390A0 Offset: 0x16382A0 VA: 0x1816390A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual object Invoke(Header[] headers) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal interface IInternalMessage // TypeDefIndex: 3821
{
	// Properties
	public abstract Identity TargetIdentity { get; set; }
	public abstract string Uri { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Identity get_TargetIdentity();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_TargetIdentity(Identity value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Uri();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Uri(string value);
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public interface IMessage // TypeDefIndex: 3822
{
	// Properties
	public abstract IDictionary Properties { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDictionary get_Properties();
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public interface IMessageCtrl // TypeDefIndex: 3823
{}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public interface IMessageSink // TypeDefIndex: 3824
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessage SyncProcessMessage(IMessage msg);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink);
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public interface IMethodCallMessage : IMethodMessage, IMessage // TypeDefIndex: 3825
{}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public interface IMethodMessage : IMessage // TypeDefIndex: 3826
{
	// Properties
	public abstract int ArgCount { get; }
	public abstract object[] Args { get; }
	public abstract LogicalCallContext LogicalCallContext { get; }
	public abstract MethodBase MethodBase { get; }
	public abstract string MethodName { get; }
	public abstract object MethodSignature { get; }
	public abstract string TypeName { get; }
	public abstract string Uri { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_ArgCount();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object[] get_Args();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract LogicalCallContext get_LogicalCallContext();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract MethodBase get_MethodBase();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_MethodName();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object get_MethodSignature();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_TypeName();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_Uri();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract object GetArg(int argNum);
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public interface IMethodReturnMessage : IMethodMessage, IMessage // TypeDefIndex: 3827
{
	// Properties
	public abstract Exception Exception { get; }
	public abstract object[] OutArgs { get; }
	public abstract object ReturnValue { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Exception get_Exception();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object[] get_OutArgs();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object get_ReturnValue();
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
[CLSCompliant(False)]
[Serializable]
public class MethodCall : IMethodCallMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage // TypeDefIndex: 3828
{
	// Fields
	private string _uri; // 0x10
	private string _typeName; // 0x18
	private string _methodName; // 0x20
	private object[] _args; // 0x28
	private Type[] _methodSignature; // 0x30
	private MethodBase _methodBase; // 0x38
	private LogicalCallContext _callContext; // 0x40
	private Identity _targetIdentity; // 0x48
	private Type[] _genericArguments; // 0x50
	protected IDictionary ExternalProperties; // 0x58
	protected IDictionary InternalProperties; // 0x60

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public LogicalCallContext LogicalCallContext { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public virtual IDictionary Properties { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri { get; set; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }
	private Type[] GenericArguments { get; }

	// Methods

	// RVA: 0x1643910 Offset: 0x1642B10 VA: 0x181643910
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x164B9D0 Offset: 0x164ABD0 VA: 0x18164B9D0
	internal void .ctor(CADMethodCallMessage msg) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x1649A10 Offset: 0x1648C10 VA: 0x181649A10
	internal void CopyFrom(IMethodMessage call) { }

	// RVA: 0x164AE10 Offset: 0x164A010 VA: 0x18164AE10 Slot: 19
	internal virtual void InitMethodProperty(string key, object value) { }

	// RVA: 0x1649BC0 Offset: 0x1648DC0 VA: 0x181649BC0 Slot: 20
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x164BC50 Offset: 0x164AE50 VA: 0x18164BC50 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x164BCC0 Offset: 0x164AEC0 VA: 0x18164BCC0 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x164BD30 Offset: 0x164AF30 VA: 0x18164BD30 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x164BD60 Offset: 0x164AF60 VA: 0x18164BD60 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x164BDA0 Offset: 0x164AFA0 VA: 0x18164BDA0 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x1643BD0 Offset: 0x1642DD0 VA: 0x181643BD0 Slot: 21
	public virtual IDictionary get_Properties() { }

	// RVA: 0x164AD80 Offset: 0x1649F80 VA: 0x18164AD80 Slot: 22
	internal virtual void InitDictionary() { }

	// RVA: 0x164BEF0 Offset: 0x164B0F0 VA: 0x18164BEF0 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 11
	public string get_Uri() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Uri(string value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 17
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x1649B90 Offset: 0x1648D90 VA: 0x181649B90 Slot: 12
	public object GetArg(int argNum) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 23
	public virtual void Init() { }

	// RVA: 0x164B2D0 Offset: 0x164A4D0 VA: 0x18164B2D0
	public void ResolveMethod() { }

	// RVA: 0x1649800 Offset: 0x1648A00 VA: 0x181649800
	private Type CastTo(string clientType, Type serverType) { }

	// RVA: 0x164ACF0 Offset: 0x1649EF0 VA: 0x18164ACF0
	private static string GetTypeNameFromAssemblyQualifiedName(string aqname) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0 Slot: 15
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200 Slot: 16
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	// RVA: 0x164BC70 Offset: 0x164AE70 VA: 0x18164BC70
	private Type[] get_GenericArguments() { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class MCMDictionary : MessageDictionary // TypeDefIndex: 3829
{
	// Fields
	public static string[] InternalKeys; // 0x0

	// Methods

	// RVA: 0x1647D00 Offset: 0x1646F00 VA: 0x181647D00
	public void .ctor(IMethodMessage message) { }

	// RVA: 0x1647BE0 Offset: 0x1646DE0 VA: 0x181647BE0
	private static void .cctor() { }
}

// Namespace: 
private class MessageDictionary.DictionaryEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 3830
{
	// Fields
	private MessageDictionary _methodDictionary; // 0x10
	private IDictionaryEnumerator _hashtableEnum; // 0x18
	private int _posMethod; // 0x20

	// Properties
	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x1644090 Offset: 0x1643290 VA: 0x181644090
	public void .ctor(MessageDictionary methodDictionary) { }

	// RVA: 0x1644110 Offset: 0x1643310 VA: 0x181644110 Slot: 8
	public object get_Current() { }

	// RVA: 0x1643F10 Offset: 0x1643110 VA: 0x181643F10 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x1644030 Offset: 0x1643230 VA: 0x181644030 Slot: 9
	public void Reset() { }

	// RVA: 0x1644170 Offset: 0x1643370 VA: 0x181644170 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x1644330 Offset: 0x1643530 VA: 0x181644330 Slot: 4
	public object get_Key() { }

	// RVA: 0x1644350 Offset: 0x1643550 VA: 0x181644350 Slot: 5
	public object get_Value() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[DefaultMember("Item")]
[Serializable]
internal class MessageDictionary : IDictionary, ICollection, IEnumerable // TypeDefIndex: 3831
{
	// Fields
	private IDictionary _internalProperties; // 0x10
	protected IMethodMessage _message; // 0x18
	private string[] _methodKeys; // 0x20
	private bool _ownProperties; // 0x28

	// Properties
	internal IDictionary InternalDictionary { get; }
	public string[] MethodKeys { set; }
	public bool IsFixedSize { get; }
	public bool IsReadOnly { get; }
	public object Item { get; set; }
	public ICollection Keys { get; }
	public ICollection Values { get; }
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x81DA00 Offset: 0x81CC00 VA: 0x18081DA00
	public void .ctor(IMethodMessage message) { }

	// RVA: 0x1648640 Offset: 0x1647840 VA: 0x181648640
	internal bool HasUserData() { }

	// RVA: 0x1648DB0 Offset: 0x1647FB0 VA: 0x181648DB0
	internal IDictionary get_InternalDictionary() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_MethodKeys(string[] value) { }

	// RVA: 0x1647F60 Offset: 0x1647160 VA: 0x181647F60 Slot: 20
	protected virtual IDictionary AllocInternalProperties() { }

	// RVA: 0x1648240 Offset: 0x1647440 VA: 0x181648240
	public IDictionary GetInternalProperties() { }

	// RVA: 0x1648780 Offset: 0x1647980 VA: 0x181648780
	private bool IsOverridenKey(string key) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 12
	public bool get_IsFixedSize() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 11
	public bool get_IsReadOnly() { }

	// RVA: 0x1648ED0 Offset: 0x16480D0 VA: 0x181648ED0 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x1647E00 Offset: 0x1647000 VA: 0x181647E00 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x1648280 Offset: 0x1647480 VA: 0x181648280 Slot: 21
	protected virtual object GetMethodProperty(string key) { }

	// RVA: 0x1648960 Offset: 0x1647B60 VA: 0x181648960 Slot: 22
	protected virtual void SetMethodProperty(string key, object value) { }

	// RVA: 0x1649000 Offset: 0x1648200 VA: 0x181649000 Slot: 6
	public ICollection get_Keys() { }

	// RVA: 0x16493E0 Offset: 0x16485E0 VA: 0x1816493E0 Slot: 7
	public ICollection get_Values() { }

	// RVA: 0x1647E00 Offset: 0x1647000 VA: 0x181647E00 Slot: 9
	public void Add(object key, object value) { }

	// RVA: 0x1647FB0 Offset: 0x16471B0 VA: 0x181647FB0 Slot: 10
	public void Clear() { }

	// RVA: 0x1648000 Offset: 0x1647200 VA: 0x181648000 Slot: 8
	public bool Contains(object key) { }

	// RVA: 0x1648800 Offset: 0x1647A00 VA: 0x181648800 Slot: 14
	public void Remove(object key) { }

	// RVA: 0x1648D40 Offset: 0x1647F40 VA: 0x181648D40 Slot: 16
	public int get_Count() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 18
	public bool get_IsSynchronized() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 17
	public object get_SyncRoot() { }

	// RVA: 0x1648110 Offset: 0x1647310 VA: 0x181648110 Slot: 15
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1648C90 Offset: 0x1647E90 VA: 0x181648C90 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1648190 Offset: 0x1647390 VA: 0x181648190 Slot: 13
	public IDictionaryEnumerator GetEnumerator() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[CLSCompliant(False)]
[ComVisible(True)]
[Serializable]
public class MethodResponse : IMethodReturnMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage // TypeDefIndex: 3832
{
	// Fields
	private string _methodName; // 0x10
	private string _uri; // 0x18
	private string _typeName; // 0x20
	private MethodBase _methodBase; // 0x28
	private object _returnValue; // 0x30
	private Exception _exception; // 0x38
	private Type[] _methodSignature; // 0x40
	private ArgInfo _inArgInfo; // 0x48
	private object[] _args; // 0x50
	private object[] _outArgs; // 0x58
	private IMethodCallMessage _callMsg; // 0x60
	private LogicalCallContext _callContext; // 0x68
	private Identity _targetIdentity; // 0x70
	protected IDictionary ExternalProperties; // 0x78
	protected IDictionary InternalProperties; // 0x80

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public Exception Exception { get; }
	public LogicalCallContext LogicalCallContext { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public object[] OutArgs { get; }
	public virtual IDictionary Properties { get; }
	public object ReturnValue { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri { get; set; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }

	// Methods

	// RVA: 0x1643CA0 Offset: 0x1642EA0 VA: 0x181643CA0
	internal void .ctor(Exception e, IMethodCallMessage msg) { }

	// RVA: 0x164D6F0 Offset: 0x164C8F0 VA: 0x18164D6F0
	internal void .ctor(object returnValue, object[] outArgs, LogicalCallContext callCtx, IMethodCallMessage msg) { }

	// RVA: 0x164D780 Offset: 0x164C980 VA: 0x18164D780
	internal void .ctor(IMethodCallMessage msg, CADMethodReturnMessage retmsg) { }

	// RVA: 0x1643D60 Offset: 0x1642F60 VA: 0x181643D60
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x164D1B0 Offset: 0x164C3B0 VA: 0x18164D1B0
	internal void InitMethodProperty(string key, object value) { }

	// RVA: 0x164DAF0 Offset: 0x164CCF0 VA: 0x18164DAF0 Slot: 7
	public int get_ArgCount() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0 Slot: 8
	public object[] get_Args() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 4
	public Exception get_Exception() { }

	// RVA: 0x164DB10 Offset: 0x164CD10 VA: 0x18164DB10 Slot: 9
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x164DB80 Offset: 0x164CD80 VA: 0x18164DB80 Slot: 10
	public MethodBase get_MethodBase() { }

	// RVA: 0x164DCC0 Offset: 0x164CEC0 VA: 0x18164DCC0 Slot: 11
	public string get_MethodName() { }

	// RVA: 0x164DD20 Offset: 0x164CF20 VA: 0x18164DD20 Slot: 12
	public object get_MethodSignature() { }

	// RVA: 0x164DDF0 Offset: 0x164CFF0 VA: 0x18164DDF0 Slot: 5
	public object[] get_OutArgs() { }

	// RVA: 0x1643E70 Offset: 0x1643070 VA: 0x181643E70 Slot: 22
	public virtual IDictionary get_Properties() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 6
	public object get_ReturnValue() { }

	// RVA: 0x164DFC0 Offset: 0x164D1C0 VA: 0x18164DFC0 Slot: 13
	public string get_TypeName() { }

	// RVA: 0x164D690 Offset: 0x164C890 VA: 0x18164D690 Slot: 14
	public string get_Uri() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Uri(string value) { }

	// RVA: 0x164D690 Offset: 0x164C890 VA: 0x18164D690 Slot: 20
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70 Slot: 21
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x164BF50 Offset: 0x164B150 VA: 0x18164BF50 Slot: 15
	public object GetArg(int argNum) { }

	// RVA: 0x164BF80 Offset: 0x164B180 VA: 0x18164BF80 Slot: 23
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980 Slot: 18
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30 Slot: 19
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class MethodReturnDictionary : MessageDictionary // TypeDefIndex: 3833
{
	// Fields
	public static string[] InternalReturnKeys; // 0x0
	public static string[] InternalExceptionKeys; // 0x8

	// Methods

	// RVA: 0x164E1A0 Offset: 0x164D3A0 VA: 0x18164E1A0
	public void .ctor(IMethodReturnMessage message) { }

	// RVA: 0x164E020 Offset: 0x164D220 VA: 0x18164E020
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class MonoMethodMessage : IMethodCallMessage, IMethodMessage, IMessage, IMethodReturnMessage, IInternalMessage // TypeDefIndex: 3834
{
	// Fields
	private RuntimeMethodInfo method; // 0x10
	private object[] args; // 0x18
	private string[] names; // 0x20
	private byte[] arg_types; // 0x28
	public LogicalCallContext ctx; // 0x30
	public object rval; // 0x38
	public Exception exc; // 0x40
	private AsyncResult asyncResult; // 0x48
	private CallType call_type; // 0x50
	private string uri; // 0x58
	private MCMDictionary properties; // 0x60
	private Identity identity; // 0x68
	private Type[] methodSignature; // 0x70

	// Properties
	public IDictionary Properties { get; }
	public int ArgCount { get; }
	public object[] Args { get; }
	public LogicalCallContext LogicalCallContext { get; set; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	public Exception Exception { get; }
	public int OutArgCount { get; }
	public object[] OutArgs { get; }
	public object ReturnValue { get; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }
	public AsyncResult AsyncResult { get; }
	internal CallType CallType { get; }

	// Methods

	// RVA: 0x164E370 Offset: 0x164D570 VA: 0x18164E370
	internal void InitMessage(RuntimeMethodInfo method, object[] out_args) { }

	// RVA: 0x164EA10 Offset: 0x164DC10 VA: 0x18164EA10
	public void .ctor(MethodBase method, object[] out_args) { }

	// RVA: 0x164E8B0 Offset: 0x164DAB0 VA: 0x18164E8B0
	internal void .ctor(MethodInfo minfo, object[] in_args, object[] out_args) { }

	// RVA: 0x164E2B0 Offset: 0x164D4B0 VA: 0x18164E2B0
	private static MethodInfo GetMethodInfo(Type type, string methodName) { }

	// RVA: 0x164E6C0 Offset: 0x164D8C0 VA: 0x18164E6C0
	public void .ctor(Type type, string methodName, object[] in_args) { }

	// RVA: 0x164EFC0 Offset: 0x164E1C0 VA: 0x18164EFC0 Slot: 13
	public IDictionary get_Properties() { }

	// RVA: 0x164EAF0 Offset: 0x164DCF0 VA: 0x18164EAF0 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_LogicalCallContext(LogicalCallContext value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x164EBF0 Offset: 0x164DDF0 VA: 0x18164EBF0 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x164EC70 Offset: 0x164DE70 VA: 0x18164EC70 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x164F030 Offset: 0x164E230 VA: 0x18164F030 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090 Slot: 19
	public string get_Uri() { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0 Slot: 20
	public void set_Uri(string value) { }

	// RVA: 0x164E280 Offset: 0x164D480 VA: 0x18164E280 Slot: 12
	public object GetArg(int arg_num) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 14
	public Exception get_Exception() { }

	// RVA: 0x164EDB0 Offset: 0x164DFB0 VA: 0x18164EDB0 Slot: 21
	public int get_OutArgCount() { }

	// RVA: 0x164EE10 Offset: 0x164E010 VA: 0x18164EE10 Slot: 15
	public object[] get_OutArgs() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 16
	public object get_ReturnValue() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00 Slot: 17
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public AsyncResult get_AsyncResult() { }

	// RVA: 0x164EB80 Offset: 0x164DD80 VA: 0x18164EB80
	internal CallType get_CallType() { }

	// RVA: 0x164E640 Offset: 0x164D840 VA: 0x18164E640
	public bool NeedsOutProcessing(out int outCount) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal enum CallType // TypeDefIndex: 3835
{
	// Fields
	public int value__; // 0x0
	public const CallType Sync = 0;
	public const CallType BeginInvoke = 1;
	public const CallType EndInvoke = 2;
	public const CallType OneWay = 3;
}

// Namespace: System.Runtime.Remoting.Messaging
[Usage(64)]
[ComVisible(True)]
public class OneWayAttribute : Attribute // TypeDefIndex: 3836
{}

// Namespace: System.Runtime.Remoting.Messaging
internal class RemotingSurrogate : ISerializationSurrogate // TypeDefIndex: 3837
{
	// Methods

	// RVA: 0x1654C40 Offset: 0x1653E40 VA: 0x181654C40 Slot: 6
	public virtual void GetObjectData(object obj, SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x1654D80 Offset: 0x1653F80 VA: 0x181654D80 Slot: 7
	public virtual object SetObjectData(object obj, SerializationInfo si, StreamingContext sc, ISurrogateSelector selector) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class ObjRefSurrogate : ISerializationSurrogate // TypeDefIndex: 3838
{
	// Methods

	// RVA: 0x164F0D0 Offset: 0x164E2D0 VA: 0x18164F0D0 Slot: 6
	public virtual void GetObjectData(object obj, SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x164F360 Offset: 0x164E560 VA: 0x18164F360 Slot: 7
	public virtual object SetObjectData(object obj, SerializationInfo si, StreamingContext sc, ISurrogateSelector selector) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public class RemotingSurrogateSelector : ISurrogateSelector // TypeDefIndex: 3839
{
	// Fields
	private static Type s_cachedTypeObjRef; // 0x0
	private static ObjRefSurrogate _objRefSurrogate; // 0x8
	private static RemotingSurrogate _objRemotingSurrogate; // 0x10
	private ISurrogateSelector _next; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x16549D0 Offset: 0x1653BD0 VA: 0x1816549D0 Slot: 5
	public virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector ssout) { }

	// RVA: 0x1654B50 Offset: 0x1653D50 VA: 0x181654B50
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public class ReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage, IInternalMessage // TypeDefIndex: 3840
{
	// Fields
	private object[] _outArgs; // 0x10
	private object[] _args; // 0x18
	private LogicalCallContext _callCtx; // 0x20
	private object _returnValue; // 0x28
	private string _uri; // 0x30
	private Exception _exception; // 0x38
	private MethodBase _methodBase; // 0x40
	private string _methodName; // 0x48
	private Type[] _methodSignature; // 0x50
	private string _typeName; // 0x58
	private MethodReturnDictionary _properties; // 0x60
	private Identity _targetIdentity; // 0x68
	private ArgInfo _inArgInfo; // 0x70

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public LogicalCallContext LogicalCallContext { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public virtual IDictionary Properties { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri { get; set; }
	public Exception Exception { get; }
	public object[] OutArgs { get; }
	public virtual object ReturnValue { get; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }

	// Methods

	// RVA: 0x1654EA0 Offset: 0x16540A0 VA: 0x181654EA0
	public void .ctor(object ret, object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm) { }

	// RVA: 0x1654DF0 Offset: 0x1653FF0 VA: 0x181654DF0
	public void .ctor(Exception e, IMethodCallMessage mcm) { }

	// RVA: 0xBED310 Offset: 0xBEC510 VA: 0x180BED310 Slot: 7
	public int get_ArgCount() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	public object[] get_Args() { }

	// RVA: 0x1654F70 Offset: 0x1654170 VA: 0x181654F70 Slot: 9
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 10
	public MethodBase get_MethodBase() { }

	// RVA: 0x1654FE0 Offset: 0x16541E0 VA: 0x181654FE0 Slot: 11
	public string get_MethodName() { }

	// RVA: 0x1655040 Offset: 0x1654240 VA: 0x181655040 Slot: 12
	public object get_MethodSignature() { }

	// RVA: 0x1655230 Offset: 0x1654430 VA: 0x181655230 Slot: 21
	public virtual IDictionary get_Properties() { }

	// RVA: 0x16552A0 Offset: 0x16544A0 VA: 0x1816552A0 Slot: 13
	public string get_TypeName() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 14
	public string get_Uri() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_Uri(string value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 19
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370 Slot: 20
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x1654DC0 Offset: 0x1653FC0 VA: 0x181654DC0 Slot: 15
	public object GetArg(int argNum) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 4
	public Exception get_Exception() { }

	// RVA: 0x1655190 Offset: 0x1654390 VA: 0x181655190 Slot: 5
	public object[] get_OutArgs() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 22
	public virtual object get_ReturnValue() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00 Slot: 17
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class ServerContextTerminatorSink : IMessageSink // TypeDefIndex: 3841
{
	// Methods

	// RVA: 0x165A470 Offset: 0x1659670 VA: 0x18165A470 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x165A350 Offset: 0x1659550 VA: 0x18165A350 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class ServerObjectTerminatorSink : IMessageSink // TypeDefIndex: 3842
{
	// Fields
	private IMessageSink _nextSink; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(IMessageSink nextSink) { }

	// RVA: 0x165A850 Offset: 0x1659A50 VA: 0x18165A850 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x165A6B0 Offset: 0x16598B0 VA: 0x18165A6B0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class ServerObjectReplySink : IMessageSink // TypeDefIndex: 3843
{
	// Fields
	private IMessageSink _replySink; // 0x10
	private ServerIdentity _identity; // 0x18

	// Methods

	// RVA: 0x161DA80 Offset: 0x161CC80 VA: 0x18161DA80
	public void .ctor(ServerIdentity identity, IMessageSink replySink) { }

	// RVA: 0x165A630 Offset: 0x1659830 VA: 0x18165A630 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x165A5F0 Offset: 0x16597F0 VA: 0x18165A5F0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class StackBuilderSink : IMessageSink // TypeDefIndex: 3844
{
	// Fields
	private MarshalByRefObject _target; // 0x10
	private RealProxy _rp; // 0x18

	// Methods

	// RVA: 0x165B190 Offset: 0x165A390 VA: 0x18165B190
	public void .ctor(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x165B080 Offset: 0x165A280 VA: 0x18165B080 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x165A990 Offset: 0x1659B90 VA: 0x18165A990 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x165AEB0 Offset: 0x165A0B0 VA: 0x18165AEB0
	private void ExecuteAsyncMessage(object ob) { }

	// RVA: 0x165AAD0 Offset: 0x1659CD0 VA: 0x18165AAD0
	private void CheckParameters(IMessage msg) { }

	[CompilerGenerated]
	// RVA: 0x165B170 Offset: 0x165A370 VA: 0x18165B170
	private void <AsyncProcessMessage>b__4_0(object data) { }
}

// Namespace: System.Runtime.Versioning
[Usage(108, AllowMultiple = False, Inherited = False)]
internal sealed class NonVersionableAttribute : Attribute // TypeDefIndex: 3845
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.Versioning
[Usage(1, AllowMultiple = False, Inherited = False)]
public sealed class TargetFrameworkAttribute : Attribute // TypeDefIndex: 3846
{
	// Fields
	private string _frameworkName; // 0x10
	private string _frameworkDisplayName; // 0x18

	// Properties
	public string FrameworkDisplayName { set; }

	// Methods

	// RVA: 0x165B4F0 Offset: 0x165A6F0 VA: 0x18165B4F0
	public void .ctor(string frameworkName) { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_FrameworkDisplayName(string value) { }
}

// Namespace: System.Runtime.Versioning
internal static class BinaryCompatibility // TypeDefIndex: 3847
{
	// Fields
	public static readonly bool TargetsAtLeast_Desktop_V4_5; // 0x0
	public static readonly bool TargetsAtLeast_Desktop_V4_5_1; // 0x1

	// Methods

	// RVA: 0x163D7F0 Offset: 0x163C9F0 VA: 0x18163D7F0
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization
public interface IDeserializationCallback // TypeDefIndex: 3848
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnDeserialization(object sender);
}

// Namespace: System.Runtime.Serialization
[CLSCompliant(False)]
public interface IFormatterConverter // TypeDefIndex: 3849
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object Convert(object value, Type type);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool ToBoolean(object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int ToInt32(object value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract long ToInt64(object value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float ToSingle(object value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string ToString(object value);
}

// Namespace: System.Runtime.Serialization
public interface IObjectReference // TypeDefIndex: 3850
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetRealObject(StreamingContext context);
}

// Namespace: System.Runtime.Serialization
public interface ISerializable // TypeDefIndex: 3851
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetObjectData(SerializationInfo info, StreamingContext context);
}

// Namespace: System.Runtime.Serialization
[Serializable]
public class SerializationException : SystemException // TypeDefIndex: 3852
{
	// Fields
	private static string s_nullMessage; // 0x0

	// Methods

	// RVA: 0x1656CF0 Offset: 0x1655EF0 VA: 0x181656CF0
	public void .ctor() { }

	// RVA: 0x1656CD0 Offset: 0x1655ED0 VA: 0x181656CD0
	public void .ctor(string message) { }

	// RVA: 0x1656D60 Offset: 0x1655F60 VA: 0x181656D60
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1656C80 Offset: 0x1655E80 VA: 0x181656C80
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization
[IsReadOnly]
public struct SerializationEntry // TypeDefIndex: 3853
{
	// Fields
	private readonly string _name; // 0x0
	private readonly object _value; // 0x8
	private readonly Type _type; // 0x10

	// Properties
	public object Value { get; }
	public string Name { get; }

	// Methods

	// RVA: 0xD45610 Offset: 0xD44810 VA: 0x180D45610
	internal void .ctor(string entryName, object entryValue, Type entryType) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public object get_Value() { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public string get_Name() { }
}

// Namespace: System.Runtime.Serialization
public sealed class SerializationInfoEnumerator : IEnumerator // TypeDefIndex: 3854
{
	// Fields
	private readonly string[] _members; // 0x10
	private readonly object[] _data; // 0x18
	private readonly Type[] _types; // 0x20
	private readonly int _numItems; // 0x28
	private int _currItem; // 0x2C
	private bool _current; // 0x30

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public SerializationEntry Current { get; }
	public string Name { get; }
	public object Value { get; }
	public Type ObjectType { get; }

	// Methods

	// RVA: 0x16575A0 Offset: 0x16567A0 VA: 0x1816575A0
	internal void .ctor(string[] members, object[] info, Type[] types, int numItems) { }

	// RVA: 0x1657510 Offset: 0x1656710 VA: 0x181657510 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1657540 Offset: 0x1656740 VA: 0x181657540 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1657600 Offset: 0x1656800 VA: 0x181657600
	public SerializationEntry get_Current() { }

	// RVA: 0x1657530 Offset: 0x1656730 VA: 0x181657530 Slot: 6
	public void Reset() { }

	// RVA: 0x16576E0 Offset: 0x16568E0 VA: 0x1816576E0
	public string get_Name() { }

	// RVA: 0x1657800 Offset: 0x1656A00 VA: 0x181657800
	public object get_Value() { }

	// RVA: 0x1657770 Offset: 0x1656970 VA: 0x181657770
	public Type get_ObjectType() { }
}

// Namespace: System.Runtime.Serialization
internal sealed class DeserializationEventHandler : MulticastDelegate // TypeDefIndex: 3855
{
	// Methods

	// RVA: 0x3FD260 Offset: 0x3FC460 VA: 0x1803FD260
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(object sender) { }
}

// Namespace: System.Runtime.Serialization
public sealed class SerializationEventHandler : MulticastDelegate // TypeDefIndex: 3856
{
	// Methods

	// RVA: 0xCE0B20 Offset: 0xCDFD20 VA: 0x180CE0B20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xB85FD0 Offset: 0xB851D0 VA: 0x180B85FD0 Slot: 13
	public virtual void Invoke(StreamingContext context) { }
}

// Namespace: System.Runtime.Serialization
public class FormatterConverter : IFormatterConverter // TypeDefIndex: 3857
{
	// Methods

	// RVA: 0x1644780 Offset: 0x1643980 VA: 0x181644780 Slot: 4
	public object Convert(object value, Type type) { }

	// RVA: 0x1644870 Offset: 0x1643A70 VA: 0x181644870 Slot: 5
	public bool ToBoolean(object value) { }

	// RVA: 0x1644900 Offset: 0x1643B00 VA: 0x181644900 Slot: 6
	public int ToInt32(object value) { }

	// RVA: 0x1644990 Offset: 0x1643B90 VA: 0x181644990 Slot: 7
	public long ToInt64(object value) { }

	// RVA: 0x1644A20 Offset: 0x1643C20 VA: 0x181644A20 Slot: 8
	public float ToSingle(object value) { }

	// RVA: 0x1644AB0 Offset: 0x1643CB0 VA: 0x181644AB0 Slot: 9
	public string ToString(object value) { }

	// RVA: 0x1644820 Offset: 0x1643A20 VA: 0x181644820
	private static void ThrowValueNullException() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Runtime.Serialization
public interface ISerializationSurrogate // TypeDefIndex: 3858
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetObjectData(object obj, SerializationInfo info, StreamingContext context);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector);
}

// Namespace: System.Runtime.Serialization
public interface ISurrogateSelector // TypeDefIndex: 3859
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector);
}

// Namespace: System.Runtime.Serialization
[Serializable]
internal sealed class MemberHolder // TypeDefIndex: 3860
{
	// Fields
	internal readonly Type _memberType; // 0x10
	internal readonly StreamingContext _context; // 0x18

	// Methods

	// RVA: 0xCC89D0 Offset: 0xCC7BD0 VA: 0x180CC89D0
	internal void .ctor(Type type, StreamingContext ctx) { }

	// RVA: 0x5BF760 Offset: 0x5BE960 VA: 0x1805BF760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1647D80 Offset: 0x1646F80 VA: 0x181647D80 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: System.Runtime.Serialization
[Serializable]
public abstract class SerializationBinder // TypeDefIndex: 3861
{
	// Methods

	// RVA: 0x1656410 Offset: 0x1655610 VA: 0x181656410 Slot: 4
	public virtual void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Type BindToType(string assemblyName, string typeName);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Runtime.Serialization
internal sealed class SerializationEvents // TypeDefIndex: 3862
{
	// Fields
	private readonly List<MethodInfo> _onSerializingMethods; // 0x10
	private readonly List<MethodInfo> _onSerializedMethods; // 0x18
	private readonly List<MethodInfo> _onDeserializingMethods; // 0x20
	private readonly List<MethodInfo> _onDeserializedMethods; // 0x28

	// Properties
	internal bool HasOnSerializingEvents { get; }

	// Methods

	// RVA: 0x1656B40 Offset: 0x1655D40 VA: 0x181656B40
	internal void .ctor(Type t) { }

	// RVA: 0x1656810 Offset: 0x1655A10 VA: 0x181656810
	private List<MethodInfo> GetMethodsWithAttribute(Type attribute, Type t) { }

	// RVA: 0x1656C60 Offset: 0x1655E60 VA: 0x181656C60
	internal bool get_HasOnSerializingEvents() { }

	// RVA: 0x1656AF0 Offset: 0x1655CF0 VA: 0x181656AF0
	internal void InvokeOnSerializing(object obj, StreamingContext context) { }

	// RVA: 0x1656AA0 Offset: 0x1655CA0 VA: 0x181656AA0
	internal void InvokeOnDeserializing(object obj, StreamingContext context) { }

	// RVA: 0x1656A50 Offset: 0x1655C50 VA: 0x181656A50
	internal void InvokeOnDeserialized(object obj, StreamingContext context) { }

	// RVA: 0x16567F0 Offset: 0x16559F0 VA: 0x1816567F0
	internal SerializationEventHandler AddOnSerialized(object obj, SerializationEventHandler handler) { }

	// RVA: 0x16567D0 Offset: 0x16559D0 VA: 0x1816567D0
	internal SerializationEventHandler AddOnDeserialized(object obj, SerializationEventHandler handler) { }

	// RVA: 0x1656A10 Offset: 0x1655C10 VA: 0x181656A10
	private static void InvokeOnDelegate(object obj, StreamingContext context, List<MethodInfo> methods) { }

	// RVA: 0x16565D0 Offset: 0x16557D0 VA: 0x1816565D0
	private static SerializationEventHandler AddOnDelegate(object obj, SerializationEventHandler handler, List<MethodInfo> methods) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SerializationEventsCache.<>c // TypeDefIndex: 3863
{
	// Fields
	public static readonly SerializationEventsCache.<>c <>9; // 0x0
	public static Func<Type, SerializationEvents> <>9__1_0; // 0x8

	// Methods

	// RVA: 0x165B770 Offset: 0x165A970 VA: 0x18165B770
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x165B570 Offset: 0x165A770 VA: 0x18165B570
	internal SerializationEvents <GetSerializationEventsForType>b__1_0(Type type) { }
}

// Namespace: System.Runtime.Serialization
internal static class SerializationEventsCache // TypeDefIndex: 3864
{
	// Fields
	private static readonly ConcurrentDictionary<Type, SerializationEvents> s_cache; // 0x0

	// Methods

	// RVA: 0x1656420 Offset: 0x1655620 VA: 0x181656420
	internal static SerializationEvents GetSerializationEventsForType(Type t) { }

	// RVA: 0x1656560 Offset: 0x1655760 VA: 0x181656560
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization
public sealed class SerializationObjectManager // TypeDefIndex: 3865
{
	// Fields
	private readonly Dictionary<object, object> _objectSeenTable; // 0x10
	private readonly StreamingContext _context; // 0x18
	private SerializationEventHandler _onSerializedHandler; // 0x28

	// Methods

	// RVA: 0x165A2D0 Offset: 0x16594D0 VA: 0x18165A2D0
	public void .ctor(StreamingContext context) { }

	// RVA: 0x165A120 Offset: 0x1659320 VA: 0x18165A120
	public void RegisterObject(object obj) { }

	// RVA: 0x165A0E0 Offset: 0x16592E0 VA: 0x18165A0E0
	public void RaiseOnSerializedEvent() { }

	// RVA: 0x165A040 Offset: 0x1659240 VA: 0x18165A040
	private void AddOnSerialized(object obj) { }
}

// Namespace: System.Runtime.Serialization
internal sealed class ValueTypeFixupInfo // TypeDefIndex: 3866
{
	// Fields
	private readonly long _containerID; // 0x10
	private readonly FieldInfo _parentField; // 0x18
	private readonly int[] _parentIndex; // 0x20

	// Properties
	public long ContainerID { get; }
	public FieldInfo ParentField { get; }
	public int[] ParentIndex { get; }

	// Methods

	// RVA: 0x165B7D0 Offset: 0x165A9D0 VA: 0x18165B7D0
	public void .ctor(long containerID, FieldInfo member, int[] parentIndex) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public long get_ContainerID() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public FieldInfo get_ParentField() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public int[] get_ParentIndex() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FormatterServices.<>c__DisplayClass9_0 // TypeDefIndex: 3867
{
	// Fields
	public Type type; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x165B6C0 Offset: 0x165A8C0 VA: 0x18165B6C0
	internal MemberInfo[] <GetSerializableMembers>b__0(MemberHolder _) { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
public static class FormatterServices // TypeDefIndex: 3868
{
	// Fields
	internal static ConcurrentDictionary<MemberHolder, MemberInfo[]> m_MemberInfoTable; // 0x0
	private static bool unsafeTypeForwardersIsEnabled; // 0x8
	private static bool unsafeTypeForwardersIsEnabledInitialized; // 0x9
	private static readonly Type[] advancedTypes; // 0x10
	private static Binder s_binder; // 0x18

	// Methods

	// RVA: 0x1647590 Offset: 0x1646790 VA: 0x181647590
	private static void .cctor() { }

	// RVA: 0x1645BF0 Offset: 0x1644DF0 VA: 0x181645BF0
	private static MemberInfo[] GetSerializableMembers(RuntimeType type) { }

	// RVA: 0x1644B40 Offset: 0x1643D40 VA: 0x181644B40
	private static bool CheckSerializable(RuntimeType type) { }

	// RVA: 0x16462E0 Offset: 0x16454E0 VA: 0x1816462E0
	private static MemberInfo[] InternalGetSerializableMembers(RuntimeType type) { }

	// RVA: 0x16457E0 Offset: 0x16449E0 VA: 0x1816457E0
	private static bool GetParentTypes(RuntimeType parentType, out RuntimeType[] parentTypes, out int parentTypeCount) { }

	// RVA: 0x1645DA0 Offset: 0x1644FA0 VA: 0x181645DA0
	public static MemberInfo[] GetSerializableMembers(Type type, StreamingContext context) { }

	// RVA: 0x16460F0 Offset: 0x16452F0 VA: 0x1816460F0
	public static object GetUninitializedObject(Type type) { }

	// RVA: 0x1647710 Offset: 0x1646910 VA: 0x181647710
	private static object nativeGetUninitializedObject(RuntimeType type) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	private static bool GetEnableUnsafeTypeForwarders() { }

	// RVA: 0x16474C0 Offset: 0x16466C0 VA: 0x1816474C0
	internal static bool UnsafeTypeForwardersIsEnabled() { }

	// RVA: 0x1647220 Offset: 0x1646420 VA: 0x181647220
	internal static void SerializationSetValue(MemberInfo fi, object target, object value) { }

	// RVA: 0x1646E80 Offset: 0x1646080 VA: 0x181646E80
	public static object PopulateObjectMembers(object obj, MemberInfo[] members, object[] data) { }

	// RVA: 0x16453B0 Offset: 0x16445B0 VA: 0x1816453B0
	public static object[] GetObjectData(object obj, MemberInfo[] members) { }

	// RVA: 0x1646040 Offset: 0x1645240 VA: 0x181646040
	public static Type GetTypeFromAssembly(Assembly assem, string name) { }

	// RVA: 0x1646E70 Offset: 0x1646070 VA: 0x181646E70
	internal static Assembly LoadAssemblyFromString(string assemblyName) { }

	// RVA: 0x1646E10 Offset: 0x1646010 VA: 0x181646E10
	internal static Assembly LoadAssemblyFromStringNoThrow(string assemblyName) { }

	// RVA: 0x1644B70 Offset: 0x1643D70 VA: 0x181644B70
	internal static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom) { }

	// RVA: 0x1645330 Offset: 0x1644530 VA: 0x181645330
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0x1644D10 Offset: 0x1643F10 VA: 0x181644D10
	private static string GetClrTypeFullNameForArray(Type type) { }

	// RVA: 0x1644F40 Offset: 0x1644140 VA: 0x181644F40
	private static string GetClrTypeFullNameForNonArrayTypes(Type type) { }
}

// Namespace: System.Runtime.Serialization
internal sealed class SurrogateForCyclicalReference : ISerializationSurrogate // TypeDefIndex: 3869
{
	// Fields
	private ISerializationSurrogate innerSurrogate; // 0x10

	// Methods

	// RVA: 0x165B300 Offset: 0x165A500 VA: 0x18165B300 Slot: 4
	public void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x165B3F0 Offset: 0x165A5F0 VA: 0x18165B3F0 Slot: 5
	public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector) { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
public interface IFormatter // TypeDefIndex: 3870
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object Deserialize(Stream serializationStream);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Serialize(Stream serializationStream, object graph);
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
[Serializable]
public class ObjectIDGenerator // TypeDefIndex: 3871
{
	// Fields
	internal int m_currentCount; // 0x10
	internal int m_currentSize; // 0x14
	internal long[] m_ids; // 0x18
	internal object[] m_objs; // 0x20
	private static readonly int[] sizes; // 0x0

	// Methods

	// RVA: 0x1650BA0 Offset: 0x164FDA0 VA: 0x181650BA0
	public void .ctor() { }

	// RVA: 0x1650500 Offset: 0x164F700 VA: 0x181650500
	private int FindElement(object obj, out bool found) { }

	// RVA: 0x16505D0 Offset: 0x164F7D0 VA: 0x1816505D0 Slot: 4
	public virtual long GetId(object obj, out bool firstTime) { }

	// RVA: 0x1650760 Offset: 0x164F960 VA: 0x181650760 Slot: 5
	public virtual long HasId(object obj, out bool firstTime) { }

	// RVA: 0x1650840 Offset: 0x164FA40 VA: 0x181650840
	private void Rehash() { }

	// RVA: 0x1650B20 Offset: 0x164FD20 VA: 0x181650B20
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
public class ObjectManager // TypeDefIndex: 3872
{
	// Fields
	private DeserializationEventHandler m_onDeserializationHandler; // 0x10
	private SerializationEventHandler m_onDeserializedHandler; // 0x18
	internal ObjectHolder[] m_objects; // 0x20
	internal object m_topObject; // 0x28
	internal ObjectHolderList m_specialFixupObjects; // 0x30
	internal long m_fixupCount; // 0x38
	internal ISurrogateSelector m_selector; // 0x40
	internal StreamingContext m_context; // 0x48

	// Properties
	internal object TopObject { get; set; }
	internal ObjectHolderList SpecialFixupObjects { get; }

	// Methods

	// RVA: 0x1654830 Offset: 0x1653A30 VA: 0x181654830
	internal void .ctor(ISurrogateSelector selector, StreamingContext context, bool checkSecurity, bool isCrossAppDomain) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	private bool CanCallGetType(object obj) { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	internal void set_TopObject(object value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal object get_TopObject() { }

	// RVA: 0x16548A0 Offset: 0x1653AA0 VA: 0x1816548A0
	internal ObjectHolderList get_SpecialFixupObjects() { }

	// RVA: 0x1652740 Offset: 0x1651940 VA: 0x181652740
	internal ObjectHolder FindObjectHolder(long objectID) { }

	// RVA: 0x1652790 Offset: 0x1651990 VA: 0x181652790
	internal ObjectHolder FindOrCreateObjectHolder(long objectID) { }

	// RVA: 0x1650C70 Offset: 0x164FE70 VA: 0x181650C70
	private void AddObjectHolder(ObjectHolder holder) { }

	// RVA: 0x1652C40 Offset: 0x1651E40 VA: 0x181652C40
	private bool GetCompletionInfo(FixupHolder fixup, out ObjectHolder holder, out object member, bool bThrowIfMissing) { }

	// RVA: 0x16528B0 Offset: 0x1651AB0 VA: 0x1816528B0
	private void FixupSpecialObject(ObjectHolder holder) { }

	// RVA: 0x16545F0 Offset: 0x16537F0 VA: 0x1816545F0
	private bool ResolveObjectReference(ObjectHolder holder) { }

	// RVA: 0x1652050 Offset: 0x1651250 VA: 0x181652050
	private bool DoValueTypeFixup(FieldInfo memberToFix, ObjectHolder holder, object value) { }

	// RVA: 0x1651130 Offset: 0x1650330 VA: 0x181651130
	internal void CompleteObject(ObjectHolder holder, bool bObjectFullyComplete) { }

	// RVA: 0x1651EC0 Offset: 0x16510C0 VA: 0x181651EC0
	private void DoNewlyRegisteredObjectFixups(ObjectHolder holder) { }

	// RVA: 0x1653150 Offset: 0x1652350 VA: 0x181653150 Slot: 4
	public virtual object GetObject(long objectID) { }

	// RVA: 0x16544B0 Offset: 0x16536B0 VA: 0x1816544B0
	internal void RegisterString(string obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member) { }

	// RVA: 0x1653CB0 Offset: 0x1652EB0 VA: 0x181653CB0
	public void RegisterObject(object obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member, int[] arrayIndex) { }

	// RVA: 0x1650EC0 Offset: 0x16500C0 VA: 0x181650EC0
	internal void CompleteISerializableObject(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1653020 Offset: 0x1652220 VA: 0x181653020
	internal static RuntimeConstructorInfo GetConstructor(RuntimeType t) { }

	// RVA: 0x1651A60 Offset: 0x1650C60 VA: 0x181651A60 Slot: 5
	public virtual void DoFixups() { }

	// RVA: 0x16539C0 Offset: 0x1652BC0 VA: 0x1816539C0
	private void RegisterFixup(FixupHolder fixup, long objectToBeFixed, long objectRequired) { }

	// RVA: 0x1653700 Offset: 0x1652900 VA: 0x181653700 Slot: 6
	public virtual void RecordFixup(long objectToBeFixed, MemberInfo member, long objectRequired) { }

	// RVA: 0x1653590 Offset: 0x1652790 VA: 0x181653590 Slot: 7
	public virtual void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired) { }

	// RVA: 0x1653420 Offset: 0x1652620 VA: 0x181653420 Slot: 8
	public virtual void RecordArrayElementFixup(long arrayToBeFixed, int[] indices, long objectRequired) { }

	// RVA: 0x1653240 Offset: 0x1652440 VA: 0x181653240 Slot: 9
	public virtual void RaiseDeserializationEvent() { }

	// RVA: 0x1650D80 Offset: 0x164FF80 VA: 0x181650D80 Slot: 10
	internal virtual void AddOnDeserialization(DeserializationEventHandler handler) { }

	// RVA: 0x1650E20 Offset: 0x1650020 VA: 0x181650E20 Slot: 11
	internal virtual void AddOnDeserialized(object obj) { }

	// RVA: 0x16532A0 Offset: 0x16524A0 VA: 0x1816532A0 Slot: 12
	internal virtual void RaiseOnDeserializedEvent(object obj) { }

	// RVA: 0x1653360 Offset: 0x1652560 VA: 0x181653360
	public void RaiseOnDeserializingEvent(object obj) { }
}

// Namespace: System.Runtime.Serialization
internal sealed class ObjectHolder // TypeDefIndex: 3873
{
	// Fields
	private object m_object; // 0x10
	internal long m_id; // 0x18
	private int m_missingElementsRemaining; // 0x20
	private int m_missingDecendents; // 0x24
	internal SerializationInfo m_serInfo; // 0x28
	internal ISerializationSurrogate m_surrogate; // 0x30
	internal FixupHolderList m_missingElements; // 0x38
	internal LongList m_dependentObjects; // 0x40
	internal ObjectHolder m_next; // 0x48
	internal int m_flags; // 0x50
	private bool m_markForFixupWhenAvailable; // 0x54
	private ValueTypeFixupInfo m_valueFixup; // 0x58
	private TypeLoadExceptionHolder m_typeLoad; // 0x60
	private bool m_reachable; // 0x68

	// Properties
	internal bool IsIncompleteObjectReference { get; set; }
	internal bool RequiresDelayedFixup { get; }
	internal bool RequiresValueTypeFixup { get; }
	internal bool ValueTypeFixupPerformed { get; set; }
	internal bool HasISerializable { get; }
	internal bool HasSurrogate { get; }
	internal bool CanSurrogatedObjectValueChange { get; }
	internal bool CanObjectValueChange { get; }
	internal int DirectlyDependentObjects { get; }
	internal int TotalDependentObjects { get; }
	internal bool Reachable { get; set; }
	internal bool TypeLoadExceptionReachable { get; }
	internal TypeLoadExceptionHolder TypeLoadException { get; set; }
	internal object ObjectValue { get; }
	internal SerializationInfo SerializationInfo { get; set; }
	internal ISerializationSurrogate Surrogate { get; }
	internal LongList DependentObjects { get; set; }
