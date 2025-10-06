	internal bool RequiresSerInfoFixup { get; set; }
	internal ValueTypeFixupInfo ValueFixup { get; }
	internal bool CompletelyFixed { get; }
	internal long ContainerID { get; }

	// Methods

	// RVA: 0x164FED0 Offset: 0x164F0D0 VA: 0x18164FED0
	internal void .ctor(long objID) { }

	// RVA: 0x164FF50 Offset: 0x164F150 VA: 0x18164FF50
	internal void .ctor(object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x16501D0 Offset: 0x164F3D0 VA: 0x1816501D0
	internal void .ctor(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x164FA20 Offset: 0x164EC20 VA: 0x18164FA20
	private void IncrementDescendentFixups(int amount) { }

	// RVA: 0x164F9C0 Offset: 0x164EBC0 VA: 0x18164F9C0
	internal void DecrementFixupsRemaining(ObjectManager manager) { }

	// RVA: 0x164FA40 Offset: 0x164EC40 VA: 0x18164FA40
	internal void RemoveDependency(long id) { }

	// RVA: 0x164F8A0 Offset: 0x164EAA0 VA: 0x18164F8A0
	internal void AddFixup(FixupHolder fixup, ObjectManager manager) { }

	// RVA: 0x164FE70 Offset: 0x164F070 VA: 0x18164FE70
	private void UpdateDescendentDependencyChain(int amount, ObjectManager manager) { }

	// RVA: 0x164F750 Offset: 0x164E950 VA: 0x18164F750
	internal void AddDependency(long dependentObject) { }

	// RVA: 0x164FCB0 Offset: 0x164EEB0 VA: 0x18164FCB0
	internal void UpdateData(object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, int[] arrayIndex, ObjectManager manager) { }

	// RVA: 0x164FA30 Offset: 0x164EC30 VA: 0x18164FA30
	internal void MarkForCompletionWhenAvailable() { }

	// RVA: 0x164FAC0 Offset: 0x164ECC0 VA: 0x18164FAC0
	internal void SetFlags() { }

	// RVA: 0x160E000 Offset: 0x160D200 VA: 0x18160E000
	internal bool get_IsIncompleteObjectReference() { }

	// RVA: 0x16504B0 Offset: 0x164F6B0 VA: 0x1816504B0
	internal void set_IsIncompleteObjectReference(bool value) { }

	// RVA: 0x1650430 Offset: 0x164F630 VA: 0x181650430
	internal bool get_RequiresDelayedFixup() { }

	// RVA: 0x1650460 Offset: 0x164F660 VA: 0x181650460
	internal bool get_RequiresValueTypeFixup() { }

	// RVA: 0x1650480 Offset: 0x164F680 VA: 0x181650480
	internal bool get_ValueTypeFixupPerformed() { }

	// RVA: 0x16504F0 Offset: 0x164F6F0 VA: 0x1816504F0
	internal void set_ValueTypeFixupPerformed(bool value) { }

	// RVA: 0x160DFF0 Offset: 0x160D1F0 VA: 0x18160DFF0
	internal bool get_HasISerializable() { }

	// RVA: 0x1650420 Offset: 0x164F620 VA: 0x181650420
	internal bool get_HasSurrogate() { }

	// RVA: 0x1650340 Offset: 0x164F540 VA: 0x181650340
	internal bool get_CanSurrogatedObjectValueChange() { }

	// RVA: 0x1650320 Offset: 0x164F520 VA: 0x181650320
	internal bool get_CanObjectValueChange() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	internal int get_DirectlyDependentObjects() { }

	// RVA: 0x15BFE00 Offset: 0x15BF000 VA: 0x1815BFE00
	internal int get_TotalDependentObjects() { }

	// RVA: 0x563E40 Offset: 0x563040 VA: 0x180563E40
	internal bool get_Reachable() { }

	// RVA: 0x563E60 Offset: 0x563060 VA: 0x180563E60
	internal void set_Reachable(bool value) { }

	// RVA: 0x1650470 Offset: 0x164F670 VA: 0x181650470
	internal bool get_TypeLoadExceptionReachable() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	internal TypeLoadExceptionHolder get_TypeLoadException() { }

	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	internal void set_TypeLoadException(TypeLoadExceptionHolder value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal object get_ObjectValue() { }

	// RVA: 0x164FB50 Offset: 0x164ED50 VA: 0x18164FB50
	internal void SetObjectValue(object obj, ObjectManager manager) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal SerializationInfo get_SerializationInfo() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	internal void set_SerializationInfo(SerializationInfo value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	internal ISerializationSurrogate get_Surrogate() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	internal LongList get_DependentObjects() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	internal void set_DependentObjects(LongList value) { }

	// RVA: 0x1650440 Offset: 0x164F640 VA: 0x181650440
	internal bool get_RequiresSerInfoFixup() { }

	// RVA: 0x16504D0 Offset: 0x164F6D0 VA: 0x1816504D0
	internal void set_RequiresSerInfoFixup(bool value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	internal ValueTypeFixupInfo get_ValueFixup() { }

	// RVA: 0x16503E0 Offset: 0x164F5E0 VA: 0x1816503E0
	internal bool get_CompletelyFixed() { }

	// RVA: 0x1650400 Offset: 0x164F600 VA: 0x181650400
	internal long get_ContainerID() { }
}

// Namespace: System.Runtime.Serialization
[Serializable]
internal class FixupHolder // TypeDefIndex: 3874
{
	// Fields
	internal long m_id; // 0x10
	internal object m_fixupInfo; // 0x18
	internal int m_fixupType; // 0x20

	// Methods

	// RVA: 0xB18200 Offset: 0xB17400 VA: 0x180B18200
	internal void .ctor(long id, object fixupInfo, int fixupType) { }
}

// Namespace: System.Runtime.Serialization
[Serializable]
internal class FixupHolderList // TypeDefIndex: 3875
{
	// Fields
	internal FixupHolder[] m_values; // 0x10
	internal int m_count; // 0x18

	// Methods

	// RVA: 0x1644720 Offset: 0x1643920 VA: 0x181644720
	internal void .ctor() { }

	// RVA: 0x16446C0 Offset: 0x16438C0 VA: 0x1816446C0
	internal void .ctor(int startingSize) { }

	// RVA: 0x1644550 Offset: 0x1643750 VA: 0x181644550 Slot: 4
	internal virtual void Add(FixupHolder fixup) { }

	// RVA: 0x1644640 Offset: 0x1643840 VA: 0x181644640
	private void EnlargeArray() { }
}

// Namespace: System.Runtime.Serialization
[Serializable]
internal class LongList // TypeDefIndex: 3876
{
	// Fields
	private long[] m_values; // 0x10
	private int m_count; // 0x18
	private int m_totalItems; // 0x1C
	private int m_currentItem; // 0x20

	// Properties
	internal int Count { get; }
	internal long Current { get; }

	// Methods

	// RVA: 0x1647B00 Offset: 0x1646D00 VA: 0x181647B00
	internal void .ctor() { }

	// RVA: 0x1647B50 Offset: 0x1646D50 VA: 0x181647B50
	internal void .ctor(int startingSize) { }

	// RVA: 0x16478E0 Offset: 0x1646AE0 VA: 0x1816478E0
	internal void Add(long value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	internal int get_Count() { }

	// RVA: 0x1647AF0 Offset: 0x1646CF0 VA: 0x181647AF0
	internal void StartEnumeration() { }

	// RVA: 0x1647A20 Offset: 0x1646C20 VA: 0x181647A20
	internal bool MoveNext() { }

	// RVA: 0x1647BB0 Offset: 0x1646DB0 VA: 0x181647BB0
	internal long get_Current() { }

	// RVA: 0x1647A70 Offset: 0x1646C70 VA: 0x181647A70
	internal bool RemoveElement(long value) { }

	// RVA: 0x16479A0 Offset: 0x1646BA0 VA: 0x1816479A0
	private void EnlargeArray() { }
}

// Namespace: System.Runtime.Serialization
internal class ObjectHolderList // TypeDefIndex: 3877
{
	// Fields
	internal ObjectHolder[] m_values; // 0x10
	internal int m_count; // 0x18

	// Properties
	internal int Version { get; }
	internal int Count { get; }

	// Methods

	// RVA: 0x164F690 Offset: 0x164E890 VA: 0x18164F690
	internal void .ctor() { }

	// RVA: 0x164F6F0 Offset: 0x164E8F0 VA: 0x18164F6F0
	internal void .ctor(int startingSize) { }

	// RVA: 0x164F4E0 Offset: 0x164E6E0 VA: 0x18164F4E0 Slot: 4
	internal virtual void Add(ObjectHolder value) { }

	// RVA: 0x164F620 Offset: 0x164E820 VA: 0x18164F620
	internal ObjectHolderListEnumerator GetFixupEnumerator() { }

	// RVA: 0x164F5A0 Offset: 0x164E7A0 VA: 0x18164F5A0
	private void EnlargeArray() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	internal int get_Version() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	internal int get_Count() { }
}

// Namespace: System.Runtime.Serialization
internal class ObjectHolderListEnumerator // TypeDefIndex: 3878
{
	// Fields
	private bool m_isFixupEnumerator; // 0x10
	private ObjectHolderList m_list; // 0x18
	private int m_startingVersion; // 0x20
	private int m_currPos; // 0x24

	// Properties
	internal ObjectHolder Current { get; }

	// Methods

	// RVA: 0x164F450 Offset: 0x164E650 VA: 0x18164F450
	internal void .ctor(ObjectHolderList list, bool isFixupEnumerator) { }

	// RVA: 0x164F3B0 Offset: 0x164E5B0 VA: 0x18164F3B0
	internal bool MoveNext() { }

	// RVA: 0x164F4A0 Offset: 0x164E6A0 VA: 0x18164F4A0
	internal ObjectHolder get_Current() { }
}

// Namespace: System.Runtime.Serialization
internal class TypeLoadExceptionHolder // TypeDefIndex: 3879
{
	// Fields
	private string m_typeName; // 0x10

	// Properties
	internal string TypeName { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(string typeName) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal string get_TypeName() { }
}

// Namespace: System.Runtime.Serialization
public sealed class SafeSerializationEventArgs : EventArgs // TypeDefIndex: 3880
{
	// Fields
	private StreamingContext m_streamingContext; // 0x10
	private List<object> m_serializedStates; // 0x20

	// Properties
	internal IList<object> SerializedStates { get; }

	// Methods

	// RVA: 0x1655310 Offset: 0x1654510 VA: 0x181655310
	internal void .ctor(StreamingContext streamingContext) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal IList<object> get_SerializedStates() { }
}

// Namespace: System.Runtime.Serialization
public interface ISafeSerializationData // TypeDefIndex: 3881
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CompleteDeserialization(object deserialized);
}

// Namespace: System.Runtime.Serialization
[Serializable]
internal sealed class SafeSerializationManager : IObjectReference, ISerializable // TypeDefIndex: 3882
{
	// Fields
	private IList<object> m_serializedStates; // 0x10
	private SerializationInfo m_savedSerializationInfo; // 0x18
	private object m_realObject; // 0x20
	private RuntimeType m_realType; // 0x28
	[CompilerGenerated]
	private EventHandler<SafeSerializationEventArgs> SerializeObjectState; // 0x30
	private const string RealTypeSerializationName = "CLR_SafeSerializationManager_RealType";

	// Properties
	internal bool IsActive { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x16562A0 Offset: 0x16554A0 VA: 0x1816562A0
	internal void add_SerializeObjectState(EventHandler<SafeSerializationEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x1656360 Offset: 0x1655560 VA: 0x181656360
	internal void remove_SerializeObjectState(EventHandler<SafeSerializationEventArgs> value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x1655F60 Offset: 0x1655160 VA: 0x181655F60
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1656350 Offset: 0x1655550 VA: 0x181656350
	internal bool get_IsActive() { }

	// RVA: 0x1655660 Offset: 0x1654860 VA: 0x181655660
	internal void CompleteSerialization(object serializedObject, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16553C0 Offset: 0x16545C0 VA: 0x1816553C0
	internal void CompleteDeserialization(object deserializedObject) { }

	// RVA: 0x1655E10 Offset: 0x1655010 VA: 0x181655E10 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1655AF0 Offset: 0x1654CF0 VA: 0x181655AF0 Slot: 4
	private object System.Runtime.Serialization.IObjectReference.GetRealObject(StreamingContext context) { }

	[OnDeserialized]
	// RVA: 0x1655A30 Offset: 0x1654C30 VA: 0x181655A30
	private void OnDeserialized(StreamingContext context) { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
[Usage(256, Inherited = False)]
public sealed class OptionalFieldAttribute : Attribute // TypeDefIndex: 3883
{
	// Fields
	private int versionAdded; // 0x10

	// Properties
	public int VersionAdded { set; }

	// Methods

	// RVA: 0x1654940 Offset: 0x1653B40 VA: 0x181654940
	public void .ctor() { }

	// RVA: 0x1654950 Offset: 0x1653B50 VA: 0x181654950
	public void set_VersionAdded(int value) { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
[Usage(64, Inherited = False)]
public sealed class OnSerializingAttribute : Attribute // TypeDefIndex: 3884
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.Serialization
[Usage(64, Inherited = False)]
[ComVisible(True)]
public sealed class OnSerializedAttribute : Attribute // TypeDefIndex: 3885
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
[Usage(64, Inherited = False)]
public sealed class OnDeserializingAttribute : Attribute // TypeDefIndex: 3886
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
[Usage(64, Inherited = False)]
public sealed class OnDeserializedAttribute : Attribute // TypeDefIndex: 3887
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.Serialization
internal sealed class SerializationFieldInfo : FieldInfo // TypeDefIndex: 3888
{
	// Fields
	private RuntimeFieldInfo m_field; // 0x10
	private string m_serializationName; // 0x18

	// Properties
	public override Module Module { get; }
	public override int MetadataToken { get; }
	public override string Name { get; }
	public override Type DeclaringType { get; }
	public override Type ReflectedType { get; }
	public override Type FieldType { get; }
	internal RuntimeFieldInfo FieldInfo { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override FieldAttributes Attributes { get; }

	// Methods

	// RVA: 0x1657180 Offset: 0x1656380 VA: 0x181657180 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x1657150 Offset: 0x1656350 VA: 0x181657150 Slot: 16
	public override int get_MetadataToken() { }

	// RVA: 0x1657000 Offset: 0x1656200 VA: 0x181657000
	internal void .ctor(RuntimeFieldInfo field, string namePrefix) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x16570C0 Offset: 0x16562C0 VA: 0x1816570C0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x16571B0 Offset: 0x16563B0 VA: 0x1816571B0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x1656D80 Offset: 0x1655F80 VA: 0x181656D80 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1656DB0 Offset: 0x1655FB0 VA: 0x181656DB0 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1656F90 Offset: 0x1656190 VA: 0x181656F90 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1657120 Offset: 0x1656320 VA: 0x181657120 Slot: 18
	public override Type get_FieldType() { }

	// RVA: 0xB10540 Offset: 0xB0F740 VA: 0x180B10540 Slot: 28
	public override object GetValue(object obj) { }

	// RVA: 0x1656DE0 Offset: 0x1655FE0 VA: 0x181656DE0
	internal object InternalGetValue(object obj) { }

	// RVA: 0x1656FC0 Offset: 0x16561C0 VA: 0x181656FC0 Slot: 30
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x1656E90 Offset: 0x1656090 VA: 0x181656E90
	internal void InternalSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal RuntimeFieldInfo get_FieldInfo() { }

	// RVA: 0x16570F0 Offset: 0x16562F0 VA: 0x1816570F0 Slot: 27
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x1657090 Offset: 0x1656290 VA: 0x181657090 Slot: 17
	public override FieldAttributes get_Attributes() { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
public sealed class SerializationInfo // TypeDefIndex: 3889
{
	// Fields
	private const int defaultSize = 4;
	private const string s_mscorlibAssemblySimpleName = "mscorlib";
	private const string s_mscorlibFileName = "mscorlib.dll";
	internal string[] m_members; // 0x10
	internal object[] m_data; // 0x18
	internal Type[] m_types; // 0x20
	private Dictionary<string, int> m_nameToIndex; // 0x28
	internal int m_currMember; // 0x30
	internal IFormatterConverter m_converter; // 0x38
	private string m_fullTypeName; // 0x40
	private string m_assemName; // 0x48
	private Type objectType; // 0x50
	private bool isFullTypeNameSetExplicit; // 0x58
	private bool isAssemblyNameSetExplicit; // 0x59
	private bool requireSameTokenInPartialTrust; // 0x5A

	// Properties
	public string FullTypeName { get; }
	public string AssemblyName { get; }
	public int MemberCount { get; }
	public Type ObjectType { get; }
	public bool IsFullTypeNameSetExplicit { get; }
	public bool IsAssemblyNameSetExplicit { get; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x1659E00 Offset: 0x1659000 VA: 0x181659E00
	public void .ctor(Type type, IFormatterConverter converter) { }

	[CLSCompliant(False)]
	// RVA: 0x1659E20 Offset: 0x1659020 VA: 0x181659E20
	public void .ctor(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public string get_FullTypeName() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public string get_AssemblyName() { }

	// RVA: 0x1659AD0 Offset: 0x1658CD0 VA: 0x181659AD0
	public void SetType(Type type) { }

	// RVA: 0x1658900 Offset: 0x1657B00 VA: 0x181658900
	private static bool Compare(byte[] a, byte[] b) { }

	// RVA: 0x1658980 Offset: 0x1657B80 VA: 0x181658980
	internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x1659930 Offset: 0x1658B30 VA: 0x181659930
	internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public int get_MemberCount() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public Type get_ObjectType() { }

	// RVA: 0x4D1A30 Offset: 0x4D0C30 VA: 0x1804D1A30
	public bool get_IsFullTypeNameSetExplicit() { }

	// RVA: 0x7725E0 Offset: 0x7717E0 VA: 0x1807725E0
	public bool get_IsAssemblyNameSetExplicit() { }

	// RVA: 0x1658F30 Offset: 0x1658130 VA: 0x181658F30
	public SerializationInfoEnumerator GetEnumerator() { }

	// RVA: 0x1658990 Offset: 0x1657B90 VA: 0x181658990
	private void ExpandArrays() { }

	// RVA: 0x1657B30 Offset: 0x1656D30 VA: 0x181657B30
	public void AddValue(string name, object value, Type type) { }

	// RVA: 0x1657D50 Offset: 0x1656F50 VA: 0x181657D50
	public void AddValue(string name, object value) { }

	// RVA: 0x16587A0 Offset: 0x16579A0 VA: 0x1816587A0
	public void AddValue(string name, bool value) { }

	// RVA: 0x16580C0 Offset: 0x16572C0 VA: 0x1816580C0
	public void AddValue(string name, byte value) { }

	// RVA: 0x1658220 Offset: 0x1657420 VA: 0x181658220
	public void AddValue(string name, short value) { }

	// RVA: 0x16584E0 Offset: 0x16576E0 VA: 0x1816584E0
	public void AddValue(string name, int value) { }

	// RVA: 0x1657BF0 Offset: 0x1656DF0 VA: 0x181657BF0
	public void AddValue(string name, long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1658640 Offset: 0x1657840 VA: 0x181658640
	public void AddValue(string name, ulong value) { }

	// RVA: 0x1657F50 Offset: 0x1657150 VA: 0x181657F50
	public void AddValue(string name, float value) { }

	// RVA: 0x1658380 Offset: 0x1657580 VA: 0x181658380
	public void AddValue(string name, DateTime value) { }

	// RVA: 0x1657890 Offset: 0x1656A90 VA: 0x181657890
	internal void AddValueInternal(string name, object value, Type type) { }

	// RVA: 0x1659C60 Offset: 0x1658E60 VA: 0x181659C60
	internal void UpdateValue(string name, object value, Type type) { }

	// RVA: 0x1658A80 Offset: 0x1657C80 VA: 0x181658A80
	private int FindElement(string name) { }

	// RVA: 0x1658D80 Offset: 0x1657F80 VA: 0x181658D80
	private object GetElement(string name, out Type foundType) { }

	[ComVisible(True)]
	// RVA: 0x1658C50 Offset: 0x1657E50 VA: 0x181658C50
	private object GetElementNoThrow(string name, out Type foundType) { }

	// RVA: 0x1659750 Offset: 0x1658950 VA: 0x181659750
	public object GetValue(string name, Type type) { }

	[ComVisible(True)]
	// RVA: 0x16595A0 Offset: 0x16587A0 VA: 0x1816595A0
	internal object GetValueNoThrow(string name, Type type) { }

	// RVA: 0x1658B40 Offset: 0x1657D40 VA: 0x181658B40
	public bool GetBoolean(string name) { }

	// RVA: 0x1658FD0 Offset: 0x16581D0 VA: 0x181658FD0
	public int GetInt32(string name) { }

	// RVA: 0x1659140 Offset: 0x1658340 VA: 0x181659140
	public long GetInt64(string name) { }

	// RVA: 0x16592B0 Offset: 0x16584B0 VA: 0x1816592B0
	public float GetSingle(string name) { }

	// RVA: 0x1659420 Offset: 0x1658620 VA: 0x181659420
	public string GetString(string name) { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
[IsReadOnly]
[Serializable]
public struct StreamingContext // TypeDefIndex: 3890
{
	// Fields
	internal readonly object m_additionalContext; // 0x0
	internal readonly StreamingContextStates m_state; // 0x8

	// Properties
	public object Context { get; }
	public StreamingContextStates State { get; }

	// Methods

	// RVA: 0x165B2E0 Offset: 0x165A4E0 VA: 0x18165B2E0
	public void .ctor(StreamingContextStates state) { }

	// RVA: 0x165B2F0 Offset: 0x165A4F0 VA: 0x18165B2F0
	public void .ctor(StreamingContextStates state, object additional) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public object get_Context() { }

	// RVA: 0x165B230 Offset: 0x165A430 VA: 0x18165B230 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public StreamingContextStates get_State() { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
[Flags]
[Serializable]
public enum StreamingContextStates // TypeDefIndex: 3891
{
	// Fields
	public int value__; // 0x0
	public const StreamingContextStates CrossProcess = 1;
	public const StreamingContextStates CrossMachine = 2;
	public const StreamingContextStates File = 4;
	public const StreamingContextStates Persistence = 8;
	public const StreamingContextStates Remoting = 16;
	public const StreamingContextStates Other = 32;
	public const StreamingContextStates Clone = 64;
	public const StreamingContextStates CrossAppDomain = 128;
	public const StreamingContextStates All = 255;
}

// Namespace: System.Runtime.Serialization.Formatters
public enum FormatterTypeStyle // TypeDefIndex: 3892
{
	// Fields
	public int value__; // 0x0
	public const FormatterTypeStyle TypesWhenNeeded = 0;
	public const FormatterTypeStyle TypesAlways = 1;
	public const FormatterTypeStyle XsdString = 2;
}

// Namespace: System.Runtime.Serialization.Formatters
public enum FormatterAssemblyStyle // TypeDefIndex: 3893
{
	// Fields
	public int value__; // 0x0
	public const FormatterAssemblyStyle Simple = 0;
	public const FormatterAssemblyStyle Full = 1;
}

// Namespace: System.Runtime.Serialization.Formatters
public enum TypeFilterLevel // TypeDefIndex: 3894
{
	// Fields
	public int value__; // 0x0
	public const TypeFilterLevel Low = 2;
	public const TypeFilterLevel Full = 3;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum BinaryHeaderEnum // TypeDefIndex: 3895
{
	// Fields
	public int value__; // 0x0
	public const BinaryHeaderEnum SerializedStreamHeader = 0;
	public const BinaryHeaderEnum Object = 1;
	public const BinaryHeaderEnum ObjectWithMap = 2;
	public const BinaryHeaderEnum ObjectWithMapAssemId = 3;
	public const BinaryHeaderEnum ObjectWithMapTyped = 4;
	public const BinaryHeaderEnum ObjectWithMapTypedAssemId = 5;
	public const BinaryHeaderEnum ObjectString = 6;
	public const BinaryHeaderEnum Array = 7;
	public const BinaryHeaderEnum MemberPrimitiveTyped = 8;
	public const BinaryHeaderEnum MemberReference = 9;
	public const BinaryHeaderEnum ObjectNull = 10;
	public const BinaryHeaderEnum MessageEnd = 11;
	public const BinaryHeaderEnum Assembly = 12;
	public const BinaryHeaderEnum ObjectNullMultiple256 = 13;
	public const BinaryHeaderEnum ObjectNullMultiple = 14;
	public const BinaryHeaderEnum ArraySinglePrimitive = 15;
	public const BinaryHeaderEnum ArraySingleObject = 16;
	public const BinaryHeaderEnum ArraySingleString = 17;
	public const BinaryHeaderEnum CrossAppDomainMap = 18;
	public const BinaryHeaderEnum CrossAppDomainString = 19;
	public const BinaryHeaderEnum CrossAppDomainAssembly = 20;
	public const BinaryHeaderEnum MethodCall = 21;
	public const BinaryHeaderEnum MethodReturn = 22;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum BinaryTypeEnum // TypeDefIndex: 3896
{
	// Fields
	public int value__; // 0x0
	public const BinaryTypeEnum Primitive = 0;
	public const BinaryTypeEnum String = 1;
	public const BinaryTypeEnum Object = 2;
	public const BinaryTypeEnum ObjectUrt = 3;
	public const BinaryTypeEnum ObjectUser = 4;
	public const BinaryTypeEnum ObjectArray = 5;
	public const BinaryTypeEnum StringArray = 6;
	public const BinaryTypeEnum PrimitiveArray = 7;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum BinaryArrayTypeEnum // TypeDefIndex: 3897
{
	// Fields
	public int value__; // 0x0
	public const BinaryArrayTypeEnum Single = 0;
	public const BinaryArrayTypeEnum Jagged = 1;
	public const BinaryArrayTypeEnum Rectangular = 2;
	public const BinaryArrayTypeEnum SingleOffset = 3;
	public const BinaryArrayTypeEnum JaggedOffset = 4;
	public const BinaryArrayTypeEnum RectangularOffset = 5;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum InternalSerializerTypeE // TypeDefIndex: 3898
{
	// Fields
	public int value__; // 0x0
	public const InternalSerializerTypeE Soap = 1;
	public const InternalSerializerTypeE Binary = 2;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum InternalParseTypeE // TypeDefIndex: 3899
{
	// Fields
	public int value__; // 0x0
	public const InternalParseTypeE Empty = 0;
	public const InternalParseTypeE SerializedStreamHeader = 1;
	public const InternalParseTypeE Object = 2;
	public const InternalParseTypeE Member = 3;
	public const InternalParseTypeE ObjectEnd = 4;
	public const InternalParseTypeE MemberEnd = 5;
	public const InternalParseTypeE Headers = 6;
	public const InternalParseTypeE HeadersEnd = 7;
	public const InternalParseTypeE SerializedStreamHeaderEnd = 8;
	public const InternalParseTypeE Envelope = 9;
	public const InternalParseTypeE EnvelopeEnd = 10;
	public const InternalParseTypeE Body = 11;
	public const InternalParseTypeE BodyEnd = 12;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum InternalObjectTypeE // TypeDefIndex: 3900
{
	// Fields
	public int value__; // 0x0
	public const InternalObjectTypeE Empty = 0;
	public const InternalObjectTypeE Object = 1;
	public const InternalObjectTypeE Array = 2;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum InternalObjectPositionE // TypeDefIndex: 3901
{
	// Fields
	public int value__; // 0x0
	public const InternalObjectPositionE Empty = 0;
	public const InternalObjectPositionE Top = 1;
	public const InternalObjectPositionE Child = 2;
	public const InternalObjectPositionE Headers = 3;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum InternalArrayTypeE // TypeDefIndex: 3902
{
	// Fields
	public int value__; // 0x0
	public const InternalArrayTypeE Empty = 0;
	public const InternalArrayTypeE Single = 1;
	public const InternalArrayTypeE Jagged = 2;
	public const InternalArrayTypeE Rectangular = 3;
	public const InternalArrayTypeE Base64 = 4;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum InternalMemberTypeE // TypeDefIndex: 3903
{
	// Fields
	public int value__; // 0x0
	public const InternalMemberTypeE Empty = 0;
	public const InternalMemberTypeE Header = 1;
	public const InternalMemberTypeE Field = 2;
	public const InternalMemberTypeE Item = 3;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum InternalMemberValueE // TypeDefIndex: 3904
{
	// Fields
	public int value__; // 0x0
	public const InternalMemberValueE Empty = 0;
	public const InternalMemberValueE InlineValue = 1;
	public const InternalMemberValueE Nested = 2;
	public const InternalMemberValueE Reference = 3;
	public const InternalMemberValueE Null = 4;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum InternalPrimitiveTypeE // TypeDefIndex: 3905
{
	// Fields
	public int value__; // 0x0
	public const InternalPrimitiveTypeE Invalid = 0;
	public const InternalPrimitiveTypeE Boolean = 1;
	public const InternalPrimitiveTypeE Byte = 2;
	public const InternalPrimitiveTypeE Char = 3;
	public const InternalPrimitiveTypeE Currency = 4;
	public const InternalPrimitiveTypeE Decimal = 5;
	public const InternalPrimitiveTypeE Double = 6;
	public const InternalPrimitiveTypeE Int16 = 7;
	public const InternalPrimitiveTypeE Int32 = 8;
	public const InternalPrimitiveTypeE Int64 = 9;
	public const InternalPrimitiveTypeE SByte = 10;
	public const InternalPrimitiveTypeE Single = 11;
	public const InternalPrimitiveTypeE TimeSpan = 12;
	public const InternalPrimitiveTypeE DateTime = 13;
	public const InternalPrimitiveTypeE UInt16 = 14;
	public const InternalPrimitiveTypeE UInt32 = 15;
	public const InternalPrimitiveTypeE UInt64 = 16;
	public const InternalPrimitiveTypeE Null = 17;
	public const InternalPrimitiveTypeE String = 18;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum ValueFixupEnum // TypeDefIndex: 3906
{
	// Fields
	public int value__; // 0x0
	public const ValueFixupEnum Empty = 0;
	public const ValueFixupEnum Array = 1;
	public const ValueFixupEnum Header = 2;
	public const ValueFixupEnum Member = 3;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal static class BinaryConverter // TypeDefIndex: 3907
{
	// Methods

	// RVA: 0x163D840 Offset: 0x163CA40 VA: 0x18163D840
	internal static BinaryTypeEnum GetBinaryTypeInfo(Type type, WriteObjectInfo objectInfo, string typeName, ObjectWriter objectWriter, out object typeInformation, out int assemId) { }

	// RVA: 0x163DB80 Offset: 0x163CD80 VA: 0x18163DB80
	internal static BinaryTypeEnum GetParserBinaryTypeInfo(Type type, out object typeInformation) { }

	// RVA: 0x163E350 Offset: 0x163D550 VA: 0x18163E350
	internal static void WriteTypeInfo(BinaryTypeEnum binaryTypeEnum, object typeInformation, int assemId, __BinaryWriter sout) { }

	// RVA: 0x163DDE0 Offset: 0x163CFE0 VA: 0x18163DDE0
	internal static object ReadTypeInfo(BinaryTypeEnum binaryTypeEnum, __BinaryParser input, out int assemId) { }

	// RVA: 0x163DFB0 Offset: 0x163D1B0 VA: 0x18163DFB0
	internal static void TypeFromInfo(BinaryTypeEnum binaryTypeEnum, object typeInformation, ObjectReader objectReader, BinaryAssemblyInfo assemblyInfo, out InternalPrimitiveTypeE primitiveTypeEnum, out string typeString, out Type type, out bool isVariant) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal static class IOUtil // TypeDefIndex: 3908
{
	// Methods

	// RVA: 0x1647720 Offset: 0x1646920 VA: 0x181647720
	internal static bool FlagTest(MessageEnum flag, MessageEnum target) { }

	// RVA: 0x1647730 Offset: 0x1646930 VA: 0x181647730
	internal static void WriteStringWithCode(string value, __BinaryWriter sout) { }

	// RVA: 0x1647790 Offset: 0x1646990 VA: 0x181647790
	internal static void WriteWithCode(Type type, object value, __BinaryWriter sout) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryAssemblyInfo // TypeDefIndex: 3909
{
	// Fields
	internal string assemblyString; // 0x10
	private Assembly assembly; // 0x18

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(string assemblyString) { }

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	internal void .ctor(string assemblyString, Assembly assembly) { }

	// RVA: 0x163D620 Offset: 0x163C820 VA: 0x18163D620
	internal Assembly GetAssembly() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class SerializationHeaderRecord // TypeDefIndex: 3910
{
	// Fields
	internal int binaryFormatterMajorVersion; // 0x10
	internal int binaryFormatterMinorVersion; // 0x14
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x18
	internal int topId; // 0x1C
	internal int headerId; // 0x20
	internal int majorVersion; // 0x24
	internal int minorVersion; // 0x28

	// Methods

	// RVA: 0x16574A0 Offset: 0x16566A0 VA: 0x1816574A0
	internal void .ctor() { }

	// RVA: 0x16574B0 Offset: 0x16566B0 VA: 0x1816574B0
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum, int topId, int headerId, int majorVersion, int minorVersion) { }

	// RVA: 0x1657420 Offset: 0x1656620 VA: 0x181657420 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x160A450 Offset: 0x1609650 VA: 0x18160A450
	private static int GetInt32(byte[] buffer, int index) { }

	// RVA: 0x16571E0 Offset: 0x16563E0 VA: 0x1816571E0 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryAssembly // TypeDefIndex: 3911
{
	// Fields
	internal int assemId; // 0x10
	internal string assemblyString; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x163D790 Offset: 0x163C990 VA: 0x18163D790
	internal void Set(int assemId, string assemblyString) { }

	// RVA: 0x163D7A0 Offset: 0x163C9A0 VA: 0x18163D7A0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x163D740 Offset: 0x163C940 VA: 0x18163D740 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryCrossAppDomainAssembly // TypeDefIndex: 3912
{
	// Fields
	internal int assemId; // 0x10
	internal int assemblyIndex; // 0x14

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x163E570 Offset: 0x163D770 VA: 0x18163E570 Slot: 4
	public void Read(__BinaryParser input) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryObject // TypeDefIndex: 3913
{
	// Fields
	internal int objectId; // 0x10
	internal int mapId; // 0x14

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x163EC80 Offset: 0x163DE80 VA: 0x18163EC80
	internal void Set(int objectId, int mapId) { }

	// RVA: 0x163EC90 Offset: 0x163DE90 VA: 0x18163EC90 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x163E570 Offset: 0x163D770 VA: 0x18163E570 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryMethodCall // TypeDefIndex: 3914
{
	// Fields
	private string methodName; // 0x10
	private string typeName; // 0x18
	private object[] args; // 0x20
	private object callContext; // 0x28
	private Type[] argTypes; // 0x30
	private bool bArgsPrimitive; // 0x38
	private MessageEnum messageEnum; // 0x3C

	// Methods

	// RVA: 0x163E5B0 Offset: 0x163D7B0 VA: 0x18163E5B0
	internal void Write(__BinaryWriter sout) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void Dump() { }

	// RVA: 0x163E870 Offset: 0x163DA70 VA: 0x18163E870
	public void .ctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryMethodReturn // TypeDefIndex: 3915
{
	// Fields
	private object returnValue; // 0x10
	private object[] args; // 0x18
	private object callContext; // 0x20
	private Type[] argTypes; // 0x28
	private bool bArgsPrimitive; // 0x30
	private MessageEnum messageEnum; // 0x34
	private Type returnType; // 0x38
	private static object instanceOfVoid; // 0x0

	// Methods

	// RVA: 0x163EBD0 Offset: 0x163DDD0 VA: 0x18163EBD0
	private static void .cctor() { }

	// RVA: 0x163EC70 Offset: 0x163DE70 VA: 0x18163EC70
	internal void .ctor() { }

	// RVA: 0x163E880 Offset: 0x163DA80 VA: 0x18163E880 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryObjectString // TypeDefIndex: 3916
{
	// Fields
	internal int objectId; // 0x10
	internal string value; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x163D790 Offset: 0x163C990 VA: 0x18163D790
	internal void Set(int objectId, string value) { }

	// RVA: 0x165CDC0 Offset: 0x165BFC0 VA: 0x18165CDC0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x165CD50 Offset: 0x165BF50 VA: 0x18165CD50 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryCrossAppDomainString // TypeDefIndex: 3917
{
	// Fields
	internal int objectId; // 0x10
	internal int value; // 0x14

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x165C250 Offset: 0x165B450 VA: 0x18165C250 Slot: 4
	public void Read(__BinaryParser input) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryCrossAppDomainMap // TypeDefIndex: 3918
{
	// Fields
	internal int crossAppDomainArrayIndex; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x165C210 Offset: 0x165B410 VA: 0x18165C210 Slot: 4
	public void Read(__BinaryParser input) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class MemberPrimitiveTyped // TypeDefIndex: 3919
{
	// Fields
	internal InternalPrimitiveTypeE primitiveTypeEnum; // 0x10
	internal object value; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x163D790 Offset: 0x163C990 VA: 0x18163D790
	internal void Set(InternalPrimitiveTypeE primitiveTypeEnum, object value) { }

	// RVA: 0x165FED0 Offset: 0x165F0D0 VA: 0x18165FED0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x165FE70 Offset: 0x165F070 VA: 0x18165FE70 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryObjectWithMap // TypeDefIndex: 3920
{
	// Fields
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x10
	internal int objectId; // 0x14
	internal string name; // 0x18
	internal int numMembers; // 0x20
	internal string[] memberNames; // 0x28
	internal int assemId; // 0x30

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x165D560 Offset: 0x165C760 VA: 0x18165D560
	internal void Set(int objectId, string name, int numMembers, string[] memberNames, int assemId) { }

	// RVA: 0x165D590 Offset: 0x165C790 VA: 0x18165D590 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x165D400 Offset: 0x165C600 VA: 0x18165D400 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryObjectWithMapTyped // TypeDefIndex: 3921
{
	// Fields
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x10
	internal int objectId; // 0x14
	internal string name; // 0x18
	internal int numMembers; // 0x20
	internal string[] memberNames; // 0x28
	internal BinaryTypeEnum[] binaryTypeEnumA; // 0x30
	internal object[] typeInformationA; // 0x38
	internal int[] memberAssemIds; // 0x40
	internal int assemId; // 0x48

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x165D190 Offset: 0x165C390 VA: 0x18165D190
	internal void Set(int objectId, string name, int numMembers, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, int assemId) { }

	// RVA: 0x165D1E0 Offset: 0x165C3E0 VA: 0x18165D1E0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x165CE50 Offset: 0x165C050 VA: 0x18165CE50 Slot: 5
	public void Read(__BinaryParser input) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryArray // TypeDefIndex: 3922
{
	// Fields
	internal int objectId; // 0x10
	internal int rank; // 0x14
	internal int[] lengthA; // 0x18
	internal int[] lowerBoundA; // 0x20
	internal BinaryTypeEnum binaryTypeEnum; // 0x28
	internal object typeInformation; // 0x30
	internal int assemId; // 0x38
	private BinaryHeaderEnum binaryHeaderEnum; // 0x3C
	internal BinaryArrayTypeEnum binaryArrayTypeEnum; // 0x40

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x165C1E0 Offset: 0x165B3E0 VA: 0x18165C1E0
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x165BE00 Offset: 0x165B000 VA: 0x18165BE00
	internal void Set(int objectId, int rank, int[] lengthA, int[] lowerBoundA, BinaryTypeEnum binaryTypeEnum, object typeInformation, BinaryArrayTypeEnum binaryArrayTypeEnum, int assemId) { }

	// RVA: 0x165BE70 Offset: 0x165B070 VA: 0x18165BE70 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x165B990 Offset: 0x165AB90 VA: 0x18165B990 Slot: 5
	public void Read(__BinaryParser input) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class MemberPrimitiveUnTyped // TypeDefIndex: 3923
{
	// Fields
	internal InternalPrimitiveTypeE typeInformation; // 0x10
	internal object value; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x163D790 Offset: 0x163C990 VA: 0x18163D790
	internal void Set(InternalPrimitiveTypeE typeInformation, object value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	internal void Set(InternalPrimitiveTypeE typeInformation) { }

	// RVA: 0x165FF80 Offset: 0x165F180 VA: 0x18165FF80 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x165FF50 Offset: 0x165F150 VA: 0x18165FF50 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class MemberReference // TypeDefIndex: 3924
{
	// Fields
	internal int idRef; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	internal void Set(int idRef) { }

	// RVA: 0x165FFB0 Offset: 0x165F1B0 VA: 0x18165FFB0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x165C210 Offset: 0x165B410 VA: 0x18165C210 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectNull // TypeDefIndex: 3925
{
	// Fields
	internal int nullCount; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	internal void SetNullCount(int nullCount) { }

	// RVA: 0x1660AA0 Offset: 0x165FCA0 VA: 0x181660AA0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x1660A00 Offset: 0x165FC00 VA: 0x181660A00
	public void Read(__BinaryParser input, BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class MessageEnd // TypeDefIndex: 3926
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x1660020 Offset: 0x165F220 VA: 0x181660020 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void Dump() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void Dump(Stream sout) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectMap // TypeDefIndex: 3927
{
	// Fields
	internal string objectName; // 0x10
	internal Type objectType; // 0x18
	internal BinaryTypeEnum[] binaryTypeEnumA; // 0x20
	internal object[] typeInformationA; // 0x28
	internal Type[] memberTypes; // 0x30
	internal string[] memberNames; // 0x38
	internal ReadObjectInfo objectInfo; // 0x40
	internal bool isInitObjectInfo; // 0x48
	internal ObjectReader objectReader; // 0x50
	internal int objectId; // 0x58
	internal BinaryAssemblyInfo assemblyInfo; // 0x60

	// Methods

	// RVA: 0x16607C0 Offset: 0x165F9C0 VA: 0x1816607C0
	internal void .ctor(string objectName, Type objectType, string[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo) { }

	// RVA: 0x1660370 Offset: 0x165F570 VA: 0x181660370
	internal void .ctor(string objectName, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable) { }

	// RVA: 0x16601B0 Offset: 0x165F3B0 VA: 0x1816601B0
	internal ReadObjectInfo CreateObjectInfo(ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x1660200 Offset: 0x165F400 VA: 0x181660200
	internal static ObjectMap Create(string name, Type objectType, string[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo) { }

	// RVA: 0x16602A0 Offset: 0x165F4A0 VA: 0x1816602A0
	internal static ObjectMap Create(string name, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectProgress // TypeDefIndex: 3928
{
	// Fields
	internal static int opRecordIdCount; // 0x0
	internal bool isInitial; // 0x10
	internal int count; // 0x14
	internal BinaryTypeEnum expectedType; // 0x18
	internal object expectedTypeInformation; // 0x20
	internal string name; // 0x28
	internal InternalObjectTypeE objectTypeEnum; // 0x30
	internal InternalMemberTypeE memberTypeEnum; // 0x34
	internal InternalMemberValueE memberValueEnum; // 0x38
	internal Type dtType; // 0x40
	internal int numItems; // 0x48
	internal BinaryTypeEnum binaryTypeEnum; // 0x4C
	internal object typeInformation; // 0x50
	internal int nullCount; // 0x58
	internal int memberLength; // 0x5C
	internal BinaryTypeEnum[] binaryTypeEnumA; // 0x60
	internal object[] typeInformationA; // 0x68
	internal string[] memberNames; // 0x70
	internal Type[] memberTypes; // 0x78
	internal ParseRecord pr; // 0x80

	// Methods

	// RVA: 0x1660D50 Offset: 0x165FF50 VA: 0x181660D50
	internal void .ctor() { }

	// RVA: 0x1660CB0 Offset: 0x165FEB0 VA: 0x181660CB0
	internal void Init() { }

	// RVA: 0x1660BA0 Offset: 0x165FDA0 VA: 0x181660BA0
	internal void ArrayCountIncrement(int value) { }

	// RVA: 0x1660BB0 Offset: 0x165FDB0 VA: 0x181660BB0
	internal bool GetNext(out BinaryTypeEnum outBinaryTypeEnum, out object outTypeInformation) { }

	// RVA: 0x1660D10 Offset: 0x165FF10 VA: 0x181660D10
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class Converter // TypeDefIndex: 3929
{
	// Fields
	private static int primitiveTypeEnumLength; // 0x0
	private static Type[] typeA; // 0x8
	private static Type[] arrayTypeA; // 0x10
	private static string[] valueA; // 0x18
	private static TypeCode[] typeCodeA; // 0x20
	private static InternalPrimitiveTypeE[] codeA; // 0x28
	internal static Type typeofISerializable; // 0x30
	internal static Type typeofString; // 0x38
	internal static Type typeofConverter; // 0x40
	internal static Type typeofBoolean; // 0x48
	internal static Type typeofByte; // 0x50
	internal static Type typeofChar; // 0x58
	internal static Type typeofDecimal; // 0x60
	internal static Type typeofDouble; // 0x68
	internal static Type typeofInt16; // 0x70
	internal static Type typeofInt32; // 0x78
	internal static Type typeofInt64; // 0x80
	internal static Type typeofSByte; // 0x88
	internal static Type typeofSingle; // 0x90
	internal static Type typeofTimeSpan; // 0x98
	internal static Type typeofDateTime; // 0xA0
	internal static Type typeofUInt16; // 0xA8
	internal static Type typeofUInt32; // 0xB0
	internal static Type typeofUInt64; // 0xB8
	internal static Type typeofObject; // 0xC0
	internal static Type typeofSystemVoid; // 0xC8
	internal static Assembly urtAssembly; // 0xD0
	internal static string urtAssemblyString; // 0xD8
	internal static Type typeofTypeArray; // 0xE0
	internal static Type typeofObjectArray; // 0xE8
	internal static Type typeofStringArray; // 0xF0
	internal static Type typeofBooleanArray; // 0xF8
	internal static Type typeofByteArray; // 0x100
	internal static Type typeofCharArray; // 0x108
	internal static Type typeofDecimalArray; // 0x110
	internal static Type typeofDoubleArray; // 0x118
	internal static Type typeofInt16Array; // 0x120
	internal static Type typeofInt32Array; // 0x128
	internal static Type typeofInt64Array; // 0x130
	internal static Type typeofSByteArray; // 0x138
	internal static Type typeofSingleArray; // 0x140
	internal static Type typeofTimeSpanArray; // 0x148
	internal static Type typeofDateTimeArray; // 0x150
	internal static Type typeofUInt16Array; // 0x158
	internal static Type typeofUInt32Array; // 0x160
	internal static Type typeofUInt64Array; // 0x168
	internal static Type typeofMarshalByRefObject; // 0x170

	// Methods

	// RVA: 0x165EE60 Offset: 0x165E060 VA: 0x18165EE60
	internal static InternalPrimitiveTypeE ToCode(Type type) { }

	// RVA: 0x165ED20 Offset: 0x165DF20 VA: 0x18165ED20
	internal static bool IsWriteAsByteArray(InternalPrimitiveTypeE code) { }

	// RVA: 0x165F5F0 Offset: 0x165E7F0 VA: 0x18165F5F0
	internal static int TypeLength(InternalPrimitiveTypeE code) { }

	// RVA: 0x165ED90 Offset: 0x165DF90 VA: 0x18165ED90
	internal static Type ToArrayType(InternalPrimitiveTypeE code) { }

	// RVA: 0x165E0B0 Offset: 0x165D2B0 VA: 0x18165E0B0
	private static void InitTypeA() { }

	// RVA: 0x165D980 Offset: 0x165CB80 VA: 0x18165D980
	private static void InitArrayTypeA() { }

	// RVA: 0x165F520 Offset: 0x165E720 VA: 0x18165F520
	internal static Type ToType(InternalPrimitiveTypeE code) { }

	// RVA: 0x165D6D0 Offset: 0x165C8D0 VA: 0x18165D6D0
	internal static Array CreatePrimitiveArray(InternalPrimitiveTypeE code, int length) { }

	// RVA: 0x165EA40 Offset: 0x165DC40 VA: 0x18165EA40
	internal static bool IsPrimitiveArray(Type type, out object typeInformation) { }

	// RVA: 0x165E7A0 Offset: 0x165D9A0 VA: 0x18165E7A0
	private static void InitValueA() { }

	// RVA: 0x165EF90 Offset: 0x165E190 VA: 0x18165EF90
	internal static string ToComType(InternalPrimitiveTypeE code) { }

	// RVA: 0x165E610 Offset: 0x165D810 VA: 0x18165E610
	private static void InitTypeCodeA() { }

	// RVA: 0x165F2D0 Offset: 0x165E4D0 VA: 0x18165F2D0
	internal static TypeCode ToTypeCode(InternalPrimitiveTypeE code) { }

	// RVA: 0x165DF00 Offset: 0x165D100 VA: 0x18165DF00
	private static void InitCodeA() { }

	// RVA: 0x165F060 Offset: 0x165E260 VA: 0x18165F060
	internal static InternalPrimitiveTypeE ToPrimitiveTypeEnum(TypeCode typeCode) { }

	// RVA: 0x165D8B0 Offset: 0x165CAB0 VA: 0x18165D8B0
	internal static object FromString(string value, InternalPrimitiveTypeE code) { }

	// RVA: 0x165F680 Offset: 0x165E880 VA: 0x18165F680
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
[ComVisible(True)]
public sealed class BinaryFormatter : IFormatter // TypeDefIndex: 3930
{
	// Fields
	internal ISurrogateSelector m_surrogates; // 0x10
	internal StreamingContext m_context; // 0x18
	internal SerializationBinder m_binder; // 0x28
	internal FormatterTypeStyle m_typeFormat; // 0x30
	internal FormatterAssemblyStyle m_assemblyFormat; // 0x34
	internal TypeFilterLevel m_securityLevel; // 0x38
	internal object[] m_crossAppDomainArray; // 0x40
	private static Dictionary<Type, TypeInformation> typeNameCache; // 0x0

	// Properties
	public FormatterAssemblyStyle AssemblyFormat { set; }
	public ISurrogateSelector SurrogateSelector { set; }

	// Methods

	// RVA: 0x4D19A0 Offset: 0x4D0BA0 VA: 0x1804D19A0
	public void set_AssemblyFormat(FormatterAssemblyStyle value) { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0 Slot: 6
	public void set_SurrogateSelector(ISurrogateSelector value) { }

	// RVA: 0x165CCB0 Offset: 0x165BEB0 VA: 0x18165CCB0
	public void .ctor() { }

	// RVA: 0x165CD00 Offset: 0x165BF00 VA: 0x18165CD00
	public void .ctor(ISurrogateSelector selector, StreamingContext context) { }

	// RVA: 0x165C680 Offset: 0x165B880 VA: 0x18165C680 Slot: 4
	public object Deserialize(Stream serializationStream) { }

	// RVA: 0x165C2C0 Offset: 0x165B4C0 VA: 0x18165C2C0
	internal object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck) { }

	// RVA: 0x165C660 Offset: 0x165B860 VA: 0x18165C660 Slot: 7
	public object Deserialize(Stream serializationStream, HeaderHandler handler) { }

	// RVA: 0x165CC20 Offset: 0x165BE20 VA: 0x18165CC20 Slot: 5
	public void Serialize(Stream serializationStream, object graph) { }

	// RVA: 0x165C8F0 Offset: 0x165BAF0 VA: 0x18165C8F0 Slot: 8
	public void Serialize(Stream serializationStream, object graph, Header[] headers) { }

	// RVA: 0x165C910 Offset: 0x165BB10 VA: 0x18165C910
	internal void Serialize(Stream serializationStream, object graph, Header[] headers, bool fCheck) { }

	// RVA: 0x165C6A0 Offset: 0x165B8A0 VA: 0x18165C6A0
	internal static TypeInformation GetTypeInformation(Type type) { }

	// RVA: 0x165CC40 Offset: 0x165BE40 VA: 0x18165CC40
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class __BinaryWriter // TypeDefIndex: 3931
{
	// Fields
	internal Stream sout; // 0x10
	internal FormatterTypeStyle formatterTypeStyle; // 0x18
	internal Hashtable objectMapTable; // 0x20
	internal ObjectWriter objectWriter; // 0x28
	internal BinaryWriter dataWriter; // 0x30
	internal int m_nestedObjectCount; // 0x38
	private int nullCount; // 0x3C
	internal BinaryMethodCall binaryMethodCall; // 0x40
	internal BinaryMethodReturn binaryMethodReturn; // 0x48
	internal BinaryObject binaryObject; // 0x50
	internal BinaryObjectWithMap binaryObjectWithMap; // 0x58
	internal BinaryObjectWithMapTyped binaryObjectWithMapTyped; // 0x60
	internal BinaryObjectString binaryObjectString; // 0x68
	internal BinaryArray binaryArray; // 0x70
	private byte[] byteBuffer; // 0x78
	private int chunkSize; // 0x80
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; // 0x88
	internal MemberPrimitiveTyped memberPrimitiveTyped; // 0x90
	internal ObjectNull objectNull; // 0x98
	internal MemberReference memberReference; // 0xA0
	internal BinaryAssembly binaryAssembly; // 0xA8

	// Methods

	// RVA: 0x1674DA0 Offset: 0x1673FA0 VA: 0x181674DA0
	internal void .ctor(Stream sout, ObjectWriter objectWriter, FormatterTypeStyle formatterTypeStyle) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void WriteBegin() { }

	// RVA: 0x15F4C10 Offset: 0x15F3E10 VA: 0x1815F4C10
	internal void WriteEnd() { }

	// RVA: 0x16727D0 Offset: 0x16719D0 VA: 0x1816727D0
	internal void WriteBoolean(bool value) { }

	// RVA: 0x1672800 Offset: 0x1671A00 VA: 0x181672800
	internal void WriteByte(byte value) { }

	// RVA: 0x1672830 Offset: 0x1671A30 VA: 0x181672830
	private void WriteBytes(byte[] value) { }

	// RVA: 0x1672860 Offset: 0x1671A60 VA: 0x181672860
	private void WriteBytes(byte[] byteA, int offset, int size) { }

	// RVA: 0x1672890 Offset: 0x1671A90 VA: 0x181672890
	internal void WriteChar(char value) { }

	// RVA: 0x16728C0 Offset: 0x1671AC0 VA: 0x1816728C0
	internal void WriteChars(char[] value) { }

	// RVA: 0x1672970 Offset: 0x1671B70 VA: 0x181672970
	internal void WriteDecimal(Decimal value) { }

	// RVA: 0x1674380 Offset: 0x1673580 VA: 0x181674380
	internal void WriteSingle(float value) { }

	// RVA: 0x1672A40 Offset: 0x1671C40 VA: 0x181672A40
	internal void WriteDouble(double value) { }

	// RVA: 0x1672A70 Offset: 0x1671C70 VA: 0x181672A70
	internal void WriteInt16(short value) { }

	// RVA: 0x1672AA0 Offset: 0x1671CA0 VA: 0x181672AA0
	internal void WriteInt32(int value) { }

	// RVA: 0x1672AD0 Offset: 0x1671CD0 VA: 0x181672AD0
	internal void WriteInt64(long value) { }

	// RVA: 0x1672800 Offset: 0x1671A00 VA: 0x181672800
	internal void WriteSByte(sbyte value) { }

	// RVA: 0x16743B0 Offset: 0x16735B0 VA: 0x1816743B0
	internal void WriteString(string value) { }

	// RVA: 0x16743E0 Offset: 0x16735E0 VA: 0x1816743E0
	internal void WriteTimeSpan(TimeSpan value) { }

	// RVA: 0x16728F0 Offset: 0x1671AF0 VA: 0x1816728F0
	internal void WriteDateTime(DateTime value) { }

	// RVA: 0x1674460 Offset: 0x1673660 VA: 0x181674460
	internal void WriteUInt16(ushort value) { }

	// RVA: 0x1674490 Offset: 0x1673690 VA: 0x181674490
	internal void WriteUInt32(uint value) { }

	// RVA: 0x16744C0 Offset: 0x16736C0 VA: 0x1816744C0
	internal void WriteUInt64(ulong value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void WriteObjectEnd(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x1673D60 Offset: 0x1672F60 VA: 0x181673D60
	internal void WriteSerializationHeaderEnd() { }

	// RVA: 0x1673DE0 Offset: 0x1672FE0 VA: 0x181673DE0
	internal void WriteSerializationHeader(int topId, int headerId, int minorVersion, int majorVersion) { }

	// RVA: 0x16730A0 Offset: 0x16722A0 VA: 0x1816730A0
	internal void WriteMethodCall() { }

	// RVA: 0x1673130 Offset: 0x1672330 VA: 0x181673130
	internal void WriteMethodReturn() { }

	// RVA: 0x16733F0 Offset: 0x16725F0 VA: 0x1816733F0
	internal void WriteObject(NameInfo nameInfo, NameInfo typeNameInfo, int numMembers, string[] memberNames, Type[] memberTypes, WriteObjectInfo[] memberObjectInfos) { }

	// RVA: 0x16732F0 Offset: 0x16724F0 VA: 0x1816732F0
	internal void WriteObjectString(int objectId, string value) { }

	// RVA: 0x1673EA0 Offset: 0x16730A0 VA: 0x181673EA0
	internal void WriteSingleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Array array) { }

	// RVA: 0x1672580 Offset: 0x1671780 VA: 0x181672580
	private void WriteArrayAsBytes(Array array, int typeLength) { }

	// RVA: 0x1672BB0 Offset: 0x1671DB0 VA: 0x181672BB0
	internal void WriteJaggedArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound) { }

	// RVA: 0x1673BC0 Offset: 0x1672DC0 VA: 0x181673BC0
	internal void WriteRectangleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int rank, int[] lengthA, int[] lowerBoundA) { }

	// RVA: 0x1673290 Offset: 0x1672490 VA: 0x181673290
	internal void WriteObjectByteArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, byte[] byteA) { }

	// RVA: 0x1672F10 Offset: 0x1672110 VA: 0x181672F10
	internal void WriteMember(NameInfo memberNameInfo, NameInfo typeNameInfo, object value) { }

	// RVA: 0x16731D0 Offset: 0x16723D0 VA: 0x1816731D0
	internal void WriteNullMember(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x1672DC0 Offset: 0x1671FC0 VA: 0x181672DC0
	internal void WriteMemberObjectRef(NameInfo memberNameInfo, int idRef) { }

	// RVA: 0x1672D90 Offset: 0x1671F90 VA: 0x181672D90
	internal void WriteMemberNested(NameInfo memberNameInfo) { }

	// RVA: 0x1672EB0 Offset: 0x16720B0 VA: 0x181672EB0
	internal void WriteMemberString(NameInfo memberNameInfo, NameInfo typeNameInfo, string value) { }

	// RVA: 0x1672B50 Offset: 0x1671D50 VA: 0x181672B50
	internal void WriteItem(NameInfo itemNameInfo, NameInfo typeNameInfo, object value) { }

	// RVA: 0x16731C0 Offset: 0x16723C0 VA: 0x1816731C0
	internal void WriteNullItem(NameInfo itemNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x1672A30 Offset: 0x1671C30 VA: 0x181672A30
	internal void WriteDelayedNullItem() { }

	// RVA: 0x1672B00 Offset: 0x1671D00 VA: 0x181672B00
	internal void WriteItemEnd() { }

	// RVA: 0x16724E0 Offset: 0x16716E0 VA: 0x1816724E0
	private void InternalWriteItemNull() { }

	// RVA: 0x1672B10 Offset: 0x1671D10 VA: 0x181672B10
	internal void WriteItemObjectRef(NameInfo nameInfo, int idRef) { }

	// RVA: 0x16726D0 Offset: 0x16718D0 VA: 0x1816726D0
	internal void WriteAssembly(Type type, string assemblyString, int assemId, bool isNew) { }

	// RVA: 0x16744F0 Offset: 0x16736F0 VA: 0x1816744F0
	internal void WriteValue(InternalPrimitiveTypeE code, object value) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectMapInfo // TypeDefIndex: 3932
{
	// Fields
	internal int objectId; // 0x10
	private int numMembers; // 0x14
	private string[] memberNames; // 0x18
	private Type[] memberTypes; // 0x20

	// Methods

	// RVA: 0x795590 Offset: 0x794790 VA: 0x180795590
	internal void .ctor(int objectId, int numMembers, string[] memberNames, Type[] memberTypes) { }

	// RVA: 0x1660060 Offset: 0x165F260 VA: 0x181660060
	internal bool isCompatible(int numMembers, string[] memberNames, Type[] memberTypes) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class WriteObjectInfo // TypeDefIndex: 3933
{
	// Fields
	internal int objectInfoId; // 0x10
	internal object obj; // 0x18
	internal Type objectType; // 0x20
	internal bool isSi; // 0x28
	internal bool isNamed; // 0x29
	internal bool isTyped; // 0x2A
	internal bool isArray; // 0x2B
	internal SerializationInfo si; // 0x30
	internal SerObjectInfoCache cache; // 0x38
	internal object[] memberData; // 0x40
	internal ISerializationSurrogate serializationSurrogate; // 0x48
	internal StreamingContext context; // 0x50
	internal SerObjectInfoInit serObjectInfoInit; // 0x60
	internal long objectId; // 0x68
	internal long assemId; // 0x70
	private string binderTypeName; // 0x78
	private string binderAssemblyString; // 0x80

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x166C940 Offset: 0x166BB40 VA: 0x18166C940
	internal void ObjectEnd() { }

	// RVA: 0x166C8D0 Offset: 0x166BAD0 VA: 0x18166C8D0
	private void InternalInit() { }

	// RVA: 0x166CA40 Offset: 0x166BC40 VA: 0x18166CA40
	internal static WriteObjectInfo Serialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	// RVA: 0x166BD90 Offset: 0x166AF90 VA: 0x18166BD90
	internal void InitSerialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	// RVA: 0x166C9A0 Offset: 0x166BBA0 VA: 0x18166C9A0
	internal static WriteObjectInfo Serialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

	// RVA: 0x166B7A0 Offset: 0x166A9A0 VA: 0x18166B7A0
	internal void InitSerialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

	// RVA: 0x166C5D0 Offset: 0x166B7D0 VA: 0x18166C5D0
	private void InitSiWrite() { }

	// RVA: 0x166AC10 Offset: 0x1669E10 VA: 0x18166AC10
	private static void CheckTypeForwardedFrom(SerObjectInfoCache cache, Type objectType, string binderAssemblyString) { }

	// RVA: 0x166B620 Offset: 0x166A820 VA: 0x18166B620
	private void InitNoMembers() { }

	// RVA: 0x166B260 Offset: 0x166A460 VA: 0x18166B260
	private void InitMemberInfo() { }

	// RVA: 0x166B230 Offset: 0x166A430 VA: 0x18166B230
	internal string GetTypeFullName() { }

	// RVA: 0x166AD90 Offset: 0x1669F90 VA: 0x18166AD90
	internal string GetAssemblyString() { }

	// RVA: 0x166C900 Offset: 0x166BB00 VA: 0x18166C900
	private void InvokeSerializationBinder(SerializationBinder binder) { }

	// RVA: 0x166AE80 Offset: 0x166A080 VA: 0x18166AE80
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x166ADC0 Offset: 0x1669FC0 VA: 0x18166ADC0
	internal void GetMemberInfo(out string[] outMemberNames, out Type[] outMemberTypes, out object[] outMemberData) { }

	// RVA: 0x166B130 Offset: 0x166A330 VA: 0x18166B130
	private static WriteObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }

	// RVA: 0x166C970 Offset: 0x166BB70 VA: 0x18166C970
	private static void PutObjectInfo(SerObjectInfoInit serObjectInfoInit, WriteObjectInfo objectInfo) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ReadObjectInfo // TypeDefIndex: 3934
{
	// Fields
	internal int objectInfoId; // 0x10
	internal static int readObjectInfoCounter; // 0x0
	internal Type objectType; // 0x18
	internal ObjectManager objectManager; // 0x20
	internal int count; // 0x28
	internal bool isSi; // 0x2C
	internal bool isNamed; // 0x2D
	internal bool isTyped; // 0x2E
	internal bool bSimpleAssembly; // 0x2F
	internal SerObjectInfoCache cache; // 0x30
	internal string[] wireMemberNames; // 0x38
	internal Type[] wireMemberTypes; // 0x40
	private int lastPosition; // 0x48
	internal ISerializationSurrogate serializationSurrogate; // 0x50
	internal StreamingContext context; // 0x58
	internal List<Type> memberTypesList; // 0x68
	internal SerObjectInfoInit serObjectInfoInit; // 0x70
	internal IFormatterConverter formatterConverter; // 0x78

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void ObjectEnd() { }

	// RVA: 0x166A980 Offset: 0x1669B80 VA: 0x18166A980
	internal void PrepareForReuse() { }

	// RVA: 0x1669090 Offset: 0x1668290 VA: 0x181669090
	internal static ReadObjectInfo Create(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x166A690 Offset: 0x1669890 VA: 0x18166A690
	internal void Init(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1669180 Offset: 0x1668380 VA: 0x181669180
	internal static ReadObjectInfo Create(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x166A6F0 Offset: 0x16698F0 VA: 0x18166A6F0
	internal void Init(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x166A3D0 Offset: 0x16695D0 VA: 0x18166A3D0
	private void InitReadConstructor(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context) { }

	// RVA: 0x166A620 Offset: 0x1669820 VA: 0x18166A620
	private void InitSiRead() { }

	// RVA: 0x166A360 Offset: 0x1669560 VA: 0x18166A360
	private void InitNoMembers() { }

	// RVA: 0x166A110 Offset: 0x1669310 VA: 0x18166A110
	private void InitMemberInfo() { }

	// RVA: 0x16692A0 Offset: 0x16684A0 VA: 0x1816692A0
	internal MemberInfo GetMemberInfo(string name) { }

	// RVA: 0x1669E90 Offset: 0x1669090 VA: 0x181669E90
	internal Type GetType(string name) { }

	// RVA: 0x1668FE0 Offset: 0x16681E0 VA: 0x181668FE0
	internal void AddValue(string name, object value, ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x166A030 Offset: 0x1669230 VA: 0x18166A030
	internal void InitDataStore(ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x166A990 Offset: 0x1669B90 VA: 0x18166A990
	internal void RecordFixup(long objectId, string name, long idRef) { }

	// RVA: 0x166A780 Offset: 0x1669980 VA: 0x18166A780
	internal void PopulateObjectMembers(object obj, object[] memberData) { }

	// RVA: 0x166A810 Offset: 0x1669A10 VA: 0x18166A810
	private int Position(string name) { }

	// RVA: 0x16697C0 Offset: 0x16689C0 VA: 0x1816697C0
	internal Type[] GetMemberTypes(string[] inMemberNames, Type objectType) { }

	// RVA: 0x1669510 Offset: 0x1668710 VA: 0x181669510
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x1669E20 Offset: 0x1669020 VA: 0x181669E20
	private static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class SerObjectInfoInit // TypeDefIndex: 3935
{
	// Fields
	internal Hashtable seenBeforeTable; // 0x10
	internal int objectInfoIdCount; // 0x18
	internal SerStack oiPool; // 0x20

	// Methods

	// RVA: 0x166AAF0 Offset: 0x1669CF0 VA: 0x18166AAF0
	public void .ctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class SerObjectInfoCache // TypeDefIndex: 3936
{
	// Fields
	internal string fullTypeName; // 0x10
	internal string assemblyString; // 0x18
	internal bool hasTypeForwardedFrom; // 0x20
	internal MemberInfo[] memberInfos; // 0x28
	internal string[] memberNames; // 0x30
	internal Type[] memberTypes; // 0x38

	// Methods

	// RVA: 0x15A45E0 Offset: 0x15A37E0 VA: 0x1815A45E0
	internal void .ctor(string typeName, string assemblyName, bool hasTypeForwardedFrom) { }

	// RVA: 0x166AA60 Offset: 0x1669C60 VA: 0x18166AA60
	internal void .ctor(Type type) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class TypeInformation // TypeDefIndex: 3937
{
	// Fields
	private string fullTypeName; // 0x10
	private string assemblyString; // 0x18
	private bool hasTypeForwardedFrom; // 0x20

	// Properties
	internal string FullTypeName { get; }
	internal string AssemblyString { get; }
	internal bool HasTypeForwardedFrom { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal string get_FullTypeName() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal string get_AssemblyString() { }

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	internal bool get_HasTypeForwardedFrom() { }

	// RVA: 0x15A45E0 Offset: 0x15A37E0 VA: 0x1815A45E0
	internal void .ctor(string fullTypeName, string assemblyString, bool hasTypeForwardedFrom) { }
}

// Namespace: 
internal class ObjectReader.TypeNAssembly // TypeDefIndex: 3938
{
	// Fields
	public Type type; // 0x10
	public string assemblyName; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
internal sealed class ObjectReader.TopLevelAssemblyTypeResolver // TypeDefIndex: 3939
{
	// Fields
	private Assembly m_topLevelAssembly; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(Assembly topLevelAssembly) { }

	// RVA: 0x166AB90 Offset: 0x1669D90 VA: 0x18166AB90
	public Type ResolveType(Assembly assembly, string simpleTypeName, bool ignoreCase) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectReader // TypeDefIndex: 3940
{
	// Fields
	internal Stream m_stream; // 0x10
	internal ISurrogateSelector m_surrogates; // 0x18
	internal StreamingContext m_context; // 0x20
	internal ObjectManager m_objectManager; // 0x30
	internal InternalFE formatterEnums; // 0x38
	internal SerializationBinder m_binder; // 0x40
	internal long topId; // 0x48
	internal bool bSimpleAssembly; // 0x50
	internal object handlerObject; // 0x58
	internal object m_topObject; // 0x60
	internal Header[] headers; // 0x68
	internal HeaderHandler handler; // 0x70
	internal SerObjectInfoInit serObjectInfoInit; // 0x78
	internal IFormatterConverter m_formatterConverter; // 0x80
	internal SerStack stack; // 0x88
	private SerStack valueFixupStack; // 0x90
	internal object[] crossAppDomainArray; // 0x98
	private bool bFullDeserialization; // 0xA0
	private bool bOldFormatDetected; // 0xA1
	private IntSizedArray valTypeObjectIdTable; // 0xA8
	private NameCache typeCache; // 0xB0
	private string previousAssemblyString; // 0xB8
	private string previousName; // 0xC0
	private Type previousType; // 0xC8

	// Properties
	private SerStack ValueFixupStack { get; }
	internal object TopObject { get; set; }

	// Methods

	// RVA: 0x1664C40 Offset: 0x1663E40 VA: 0x181664C40
	private SerStack get_ValueFixupStack() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	internal object get_TopObject() { }

	// RVA: 0x1664CD0 Offset: 0x1663ED0 VA: 0x181664CD0
	internal void set_TopObject(object value) { }

	// RVA: 0x1664B20 Offset: 0x1663D20 VA: 0x181664B20
	internal void .ctor(Stream stream, ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	// RVA: 0x16611D0 Offset: 0x16603D0 VA: 0x1816611D0
	internal object Deserialize(HeaderHandler handler, __BinaryParser serParser, bool fCheck) { }

	// RVA: 0x1661CB0 Offset: 0x1660EB0 VA: 0x181661CB0
	private bool HasSurrogate(Type t) { }

	// RVA: 0x1660E20 Offset: 0x1660020 VA: 0x181660E20
	private void CheckSerializable(Type t) { }

	// RVA: 0x1661DA0 Offset: 0x1660FA0 VA: 0x181661DA0
	private void InitFullDeserialization() { }

	// RVA: 0x16611A0 Offset: 0x16603A0 VA: 0x1816611A0
	internal object CrossAppDomainArray(int index) { }

	// RVA: 0x1661020 Offset: 0x1660220 VA: 0x181661020
	internal ReadObjectInfo CreateReadObjectInfo(Type objectType) { }

	// RVA: 0x1661070 Offset: 0x1660270 VA: 0x181661070
	internal ReadObjectInfo CreateReadObjectInfo(Type objectType, string[] memberNames, Type[] memberTypes) { }

	// RVA: 0x1664640 Offset: 0x1663840 VA: 0x181664640
	internal void Parse(ParseRecord pr) { }

	// RVA: 0x1663370 Offset: 0x1662570 VA: 0x181663370
	private void ParseError(ParseRecord processing, ParseRecord onStack) { }

	// RVA: 0x16644E0 Offset: 0x16636E0 VA: 0x1816644E0
	private void ParseSerializedStreamHeader(ParseRecord pr) { }

	// RVA: 0x16644B0 Offset: 0x16636B0 VA: 0x1816644B0
	private void ParseSerializedStreamHeaderEnd(ParseRecord pr) { }

	// RVA: 0x1664120 Offset: 0x1663320 VA: 0x181664120
	private void ParseObject(ParseRecord pr) { }

	// RVA: 0x1663E10 Offset: 0x1663010 VA: 0x181663E10
	private void ParseObjectEnd(ParseRecord pr) { }

	// RVA: 0x1662BD0 Offset: 0x1661DD0 VA: 0x181662BD0
	private void ParseArray(ParseRecord pr) { }

	// RVA: 0x1661EB0 Offset: 0x16610B0 VA: 0x181661EB0
	private void NextRectangleMap(ParseRecord pr) { }

	// RVA: 0x1661FE0 Offset: 0x16611E0 VA: 0x181661FE0
	private void ParseArrayMember(ParseRecord pr) { }

	// RVA: 0x1661FB0 Offset: 0x16611B0 VA: 0x181661FB0
	private void ParseArrayMemberEnd(ParseRecord pr) { }

	// RVA: 0x1663690 Offset: 0x1662890 VA: 0x181663690
	private void ParseMember(ParseRecord pr) { }

	// RVA: 0x16635D0 Offset: 0x16627D0 VA: 0x1816635D0
	private void ParseMemberEnd(ParseRecord pr) { }

	// RVA: 0x1664510 Offset: 0x1663710 VA: 0x181664510
	private void ParseString(ParseRecord pr, ParseRecord parentPr) { }

	// RVA: 0x16649C0 Offset: 0x1663BC0 VA: 0x1816649C0
	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr) { }

	// RVA: 0x1664880 Offset: 0x1663A80 VA: 0x181664880
	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr, bool bIsString) { }

	// RVA: 0x1661850 Offset: 0x1660A50 VA: 0x181661850
	internal long GetId(long objectId) { }

	// RVA: 0x1660DC0 Offset: 0x165FFC0 VA: 0x181660DC0
	internal Type Bind(string assemblyString, string typeString) { }

	// RVA: 0x16615E0 Offset: 0x16607E0 VA: 0x1816615E0
	internal Type FastBindToType(string assemblyName, string typeName) { }

	// RVA: 0x1664AB0 Offset: 0x1663CB0 VA: 0x181664AB0
	private static Assembly ResolveSimpleAssemblyName(AssemblyName assemblyName) { }

	// RVA: 0x1661940 Offset: 0x1660B40 VA: 0x181661940
	private static void GetSimplyNamedTypeFromAssembly(Assembly assm, string typeName, ref Type type) { }

	// RVA: 0x1661AB0 Offset: 0x1660CB0 VA: 0x181661AB0
	internal Type GetType(BinaryAssemblyInfo assemblyInfo, string name) { }

	// RVA: 0x1660F60 Offset: 0x1660160 VA: 0x181660F60
	private static void CheckTypeForwardedTo(Assembly sourceAssembly, Assembly destAssembly, Type resolvedType) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectWriter // TypeDefIndex: 3941
{
	// Fields
	private Queue m_objectQueue; // 0x10
	private ObjectIDGenerator m_idGenerator; // 0x18
	private int m_currentId; // 0x20
	private ISurrogateSelector m_surrogates; // 0x28
	private StreamingContext m_context; // 0x30
	private __BinaryWriter serWriter; // 0x40
	private SerializationObjectManager m_objectManager; // 0x48
	private long topId; // 0x50
	private string topName; // 0x58
	private Header[] headers; // 0x60
	private InternalFE formatterEnums; // 0x68
	private SerializationBinder m_binder; // 0x70
	private SerObjectInfoInit serObjectInfoInit; // 0x78
	private IFormatterConverter m_formatterConverter; // 0x80
	internal object[] crossAppDomainArray; // 0x88
	private object previousObj; // 0x90
	private long previousId; // 0x98
	private Type previousType; // 0xA0
	private InternalPrimitiveTypeE previousCode; // 0xA8
	private Hashtable assemblyToIdTable; // 0xB0
	private SerStack niPool; // 0xB8

	// Properties
	internal SerializationObjectManager ObjectManager { get; }

	// Methods

	// RVA: 0x1668EE0 Offset: 0x16680E0 VA: 0x181668EE0
	internal void .ctor(ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	// RVA: 0x1665770 Offset: 0x1664970 VA: 0x181665770
	internal void Serialize(object graph, Header[] inHeaders, __BinaryWriter serWriter, bool fCheck) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	internal SerializationObjectManager get_ObjectManager() { }

	// RVA: 0x1668640 Offset: 0x1667840 VA: 0x181668640
	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x16681C0 Offset: 0x16673C0 VA: 0x1816681C0
	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string[] memberNames, Type[] memberTypes, object[] memberData, WriteObjectInfo[] memberObjectInfos) { }

	// RVA: 0x1667510 Offset: 0x1666710 VA: 0x181667510
	private void WriteMemberSetup(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string memberName, Type memberType, object memberData, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x16676B0 Offset: 0x16668B0 VA: 0x1816676B0
	private void WriteMembers(NameInfo memberNameInfo, NameInfo memberTypeNameInfo, object memberData, WriteObjectInfo objectInfo, NameInfo typeNameInfo, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x1666450 Offset: 0x1665650 VA: 0x181666450
	private void WriteArray(WriteObjectInfo objectInfo, NameInfo memberNameInfo, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x1666020 Offset: 0x1665220 VA: 0x181666020
	private void WriteArrayMember(WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, object data) { }

	// RVA: 0x1667D60 Offset: 0x1666F60 VA: 0x181667D60
	private void WriteRectangle(WriteObjectInfo objectInfo, int rank, int[] maxA, Array array, NameInfo arrayElemNameTypeInfo, int[] lowerBoundA) { }

	// RVA: 0x16652B0 Offset: 0x16644B0 VA: 0x1816652B0
	private object GetNext(out long objID) { }

	// RVA: 0x1665490 Offset: 0x1664690 VA: 0x181665490
	private long InternalGetId(object obj, bool assignUniqueIdToValueType, Type type, out bool isNew) { }

	// RVA: 0x1665750 Offset: 0x1664950 VA: 0x181665750
	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type) { }

	// RVA: 0x16655E0 Offset: 0x16647E0 VA: 0x1816655E0
	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type, WriteObjectInfo objectInfo) { }

	// RVA: 0x16672F0 Offset: 0x16664F0 VA: 0x1816672F0
	private bool WriteKnownValueClass(NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	// RVA: 0x1667D40 Offset: 0x1666F40 VA: 0x181667D40
	private void WriteObjectRef(NameInfo nameInfo, long objectId) { }

	// RVA: 0x1668060 Offset: 0x1667260 VA: 0x181668060
	private void WriteString(NameInfo memberNameInfo, NameInfo typeNameInfo, object stringObject) { }

	// RVA: 0x1664CF0 Offset: 0x1663EF0 VA: 0x181664CF0
	private bool CheckForNull(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	// RVA: 0x1667FB0 Offset: 0x16671B0 VA: 0x181667FB0
	private void WriteSerializedStreamHeader(long topId, long headerId) { }

	// RVA: 0x1665E20 Offset: 0x1665020 VA: 0x181665E20
	private NameInfo TypeToNameInfo(Type type, WriteObjectInfo objectInfo, InternalPrimitiveTypeE code, NameInfo nameInfo) { }

	// RVA: 0x1665EC0 Offset: 0x16650C0 VA: 0x181665EC0
	private NameInfo TypeToNameInfo(Type type) { }

	// RVA: 0x1665F10 Offset: 0x1665110 VA: 0x181665F10
	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo) { }

	// RVA: 0x1665D60 Offset: 0x1664F60 VA: 0x181665D60
	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo, NameInfo nameInfo) { }

	// RVA: 0x1665FB0 Offset: 0x16651B0 VA: 0x181665FB0
	private void TypeToNameInfo(Type type, NameInfo nameInfo) { }

	// RVA: 0x1665580 Offset: 0x1664780 VA: 0x181665580
	private NameInfo MemberToNameInfo(string name) { }

	// RVA: 0x1665CD0 Offset: 0x1664ED0 VA: 0x181665CD0
	internal InternalPrimitiveTypeE ToCode(Type type) { }

	// RVA: 0x1664ED0 Offset: 0x16640D0 VA: 0x181664ED0
	private long GetAssemblyId(WriteObjectInfo objectInfo) { }

	// RVA: 0x1665470 Offset: 0x1664670 VA: 0x181665470
	private Type GetType(object obj) { }

	// RVA: 0x1665200 Offset: 0x1664400 VA: 0x181665200
	private NameInfo GetNameInfo() { }

	// RVA: 0x1664EC0 Offset: 0x16640C0 VA: 0x181664EC0
	private bool CheckTypeFormat(FormatterTypeStyle test, FormatterTypeStyle want) { }

	// RVA: 0x16655B0 Offset: 0x16647B0 VA: 0x1816655B0
	private void PutNameInfo(NameInfo nameInfo) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class __BinaryParser // TypeDefIndex: 3942
{
	// Fields
	internal ObjectReader objectReader; // 0x10
	internal Stream input; // 0x18
	internal long topId; // 0x20
	internal long headerId; // 0x28
	internal SizedArray objectMapIdTable; // 0x30
	internal SizedArray assemIdToAssemblyTable; // 0x38
	internal SerStack stack; // 0x40
	internal BinaryTypeEnum expectedType; // 0x48
	internal object expectedTypeInformation; // 0x50
	internal ParseRecord PRS; // 0x58
	private BinaryAssemblyInfo systemAssemblyInfo; // 0x60
	private BinaryReader dataReader; // 0x68
	private static Encoding encoding; // 0x0
	private SerStack opPool; // 0x70
	private BinaryObject binaryObject; // 0x78
	private BinaryObjectWithMap bowm; // 0x80
	private BinaryObjectWithMapTyped bowmt; // 0x88
	internal BinaryObjectString objectString; // 0x90
	internal BinaryCrossAppDomainString crossAppDomainString; // 0x98
	internal MemberPrimitiveTyped memberPrimitiveTyped; // 0xA0
	private byte[] byteBuffer; // 0xA8
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; // 0xB0
	internal MemberReference memberReference; // 0xB8
	internal ObjectNull objectNull; // 0xC0
	internal static MessageEnd messageEnd; // 0x8

	// Properties
	internal BinaryAssemblyInfo SystemAssemblyInfo { get; }
	internal SizedArray ObjectMapIdTable { get; }
	internal SizedArray AssemIdToAssemblyTable { get; }
	internal ParseRecord prs { get; }

	// Methods

	// RVA: 0x16721D0 Offset: 0x16713D0 VA: 0x1816721D0
	internal void .ctor(Stream stream, ObjectReader objectReader) { }

	// RVA: 0x16723B0 Offset: 0x16715B0 VA: 0x1816723B0
	internal BinaryAssemblyInfo get_SystemAssemblyInfo() { }

	// RVA: 0x1672340 Offset: 0x1671540 VA: 0x181672340
	internal SizedArray get_ObjectMapIdTable() { }

	// RVA: 0x16722D0 Offset: 0x16714D0 VA: 0x1816722D0
	internal SizedArray get_AssemIdToAssemblyTable() { }

	// RVA: 0x1672470 Offset: 0x1671670 VA: 0x181672470
	internal ParseRecord get_prs() { }

	// RVA: 0x1671B50 Offset: 0x1670D50 VA: 0x181671B50
	internal void Run() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void ReadBegin() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void ReadEnd() { }

	// RVA: 0x166D980 Offset: 0x166CB80 VA: 0x18166D980
	internal bool ReadBoolean() { }

	// RVA: 0x166D9B0 Offset: 0x166CBB0 VA: 0x18166D9B0
	internal byte ReadByte() { }

	// RVA: 0x166D9E0 Offset: 0x166CBE0 VA: 0x18166D9E0
	internal byte[] ReadBytes(int length) { }

	// RVA: 0x166DA10 Offset: 0x166CC10 VA: 0x18166DA10
	internal void ReadBytes(byte[] byteA, int offset, int size) { }

	// RVA: 0x166DAB0 Offset: 0x166CCB0 VA: 0x18166DAB0
	internal char ReadChar() { }

	// RVA: 0x166DAE0 Offset: 0x166CCE0 VA: 0x18166DAE0
	internal char[] ReadChars(int length) { }

	// RVA: 0x166DD70 Offset: 0x166CF70 VA: 0x18166DD70
	internal Decimal ReadDecimal() { }

	// RVA: 0x1671450 Offset: 0x1670650 VA: 0x181671450
	internal float ReadSingle() { }

	// RVA: 0x166DE40 Offset: 0x166D040 VA: 0x18166DE40
	internal double ReadDouble() { }

	// RVA: 0x166DE70 Offset: 0x166D070 VA: 0x18166DE70
	internal short ReadInt16() { }

	// RVA: 0x166DEA0 Offset: 0x166D0A0 VA: 0x18166DEA0
	internal int ReadInt32() { }

	// RVA: 0x166DED0 Offset: 0x166D0D0 VA: 0x18166DED0
	internal long ReadInt64() { }

	// RVA: 0x166D9B0 Offset: 0x166CBB0 VA: 0x18166D9B0
	internal sbyte ReadSByte() { }

	// RVA: 0x1671480 Offset: 0x1670680 VA: 0x181671480
	internal string ReadString() { }

	// RVA: 0x166DED0 Offset: 0x166D0D0 VA: 0x18166DED0
	internal TimeSpan ReadTimeSpan() { }

	// RVA: 0x166DD00 Offset: 0x166CF00 VA: 0x18166DD00
	internal DateTime ReadDateTime() { }

	// RVA: 0x16714B0 Offset: 0x16706B0 VA: 0x1816714B0
	internal ushort ReadUInt16() { }

	// RVA: 0x16714E0 Offset: 0x16706E0 VA: 0x1816714E0
	internal uint ReadUInt32() { }

	// RVA: 0x1671510 Offset: 0x1670710 VA: 0x181671510
	internal ulong ReadUInt64() { }

	// RVA: 0x1671390 Offset: 0x1670590 VA: 0x181671390
	internal void ReadSerializationHeaderRecord() { }

	// RVA: 0x166D6A0 Offset: 0x166C8A0 VA: 0x18166D6A0
	internal void ReadAssembly(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1670ED0 Offset: 0x16700D0 VA: 0x181670ED0
	private void ReadObject() { }

	// RVA: 0x166DB10 Offset: 0x166CD10 VA: 0x18166DB10
	internal void ReadCrossAppDomainMap() { }

	// RVA: 0x16706E0 Offset: 0x166F8E0 VA: 0x1816706E0
	internal void ReadObjectWithMap(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x16708C0 Offset: 0x166FAC0 VA: 0x1816708C0
	private void ReadObjectWithMap(BinaryObjectWithMap record) { }

	// RVA: 0x166FFE0 Offset: 0x166F1E0 VA: 0x18166FFE0
	internal void ReadObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1670090 Offset: 0x166F290 VA: 0x181670090
	private void ReadObjectWithMapTyped(BinaryObjectWithMapTyped record) { }

	// RVA: 0x166F600 Offset: 0x166E800 VA: 0x18166F600
	private void ReadObjectString(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x166DF00 Offset: 0x166D100 VA: 0x18166DF00
	private void ReadMemberPrimitiveTyped() { }

	// RVA: 0x166CFF0 Offset: 0x166C1F0 VA: 0x18166CFF0
	private void ReadArray(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x166CCF0 Offset: 0x166BEF0 VA: 0x18166CCF0
	private void ReadArrayAsBytes(ParseRecord pr) { }

	// RVA: 0x166E620 Offset: 0x166D820 VA: 0x18166E620
	private void ReadMemberPrimitiveUnTyped() { }

	// RVA: 0x166EBA0 Offset: 0x166DDA0 VA: 0x18166EBA0
	private void ReadMemberReference() { }

	// RVA: 0x166F160 Offset: 0x166E360 VA: 0x18166F160
	private void ReadObjectNull(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x166EFE0 Offset: 0x166E1E0 VA: 0x18166EFE0
	private void ReadMessageEnd() { }

	// RVA: 0x1671540 Offset: 0x1670740 VA: 0x181671540
	internal object ReadValue(InternalPrimitiveTypeE code) { }

	// RVA: 0x166CAF0 Offset: 0x166BCF0 VA: 0x18166CAF0
	private ObjectProgress GetOp() { }

	// RVA: 0x166CC50 Offset: 0x166BE50 VA: 0x18166CC50
	private void PutOp(ObjectProgress op) { }

	// RVA: 0x1672160 Offset: 0x1671360 VA: 0x181672160
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ParseRecord // TypeDefIndex: 3943
{
	// Fields
	internal static int parseRecordIdCount; // 0x0
	internal InternalParseTypeE PRparseTypeEnum; // 0x10
	internal InternalObjectTypeE PRobjectTypeEnum; // 0x14
	internal InternalArrayTypeE PRarrayTypeEnum; // 0x18
	internal InternalMemberTypeE PRmemberTypeEnum; // 0x1C
	internal InternalMemberValueE PRmemberValueEnum; // 0x20
	internal InternalObjectPositionE PRobjectPositionEnum; // 0x24
	internal string PRname; // 0x28
	internal string PRvalue; // 0x30
	internal object PRvarValue; // 0x38
	internal string PRkeyDt; // 0x40
	internal Type PRdtType; // 0x48
	internal InternalPrimitiveTypeE PRdtTypeCode; // 0x50
	internal bool PRisEnum; // 0x54
	internal long PRobjectId; // 0x58
	internal long PRidRef; // 0x60
	internal string PRarrayElementTypeString; // 0x68
	internal Type PRarrayElementType; // 0x70
	internal bool PRisArrayVariant; // 0x78
	internal InternalPrimitiveTypeE PRarrayElementTypeCode; // 0x7C
	internal int PRrank; // 0x80
	internal int[] PRlengthA; // 0x88
	internal int[] PRpositionA; // 0x90
	internal int[] PRlowerBoundA; // 0x98
	internal int[] PRupperBoundA; // 0xA0
	internal int[] PRindexMap; // 0xA8
	internal int PRmemberIndex; // 0xB0
	internal int PRlinearlength; // 0xB4
	internal int[] PRrectangularMap; // 0xB8
	internal bool PRisLowerBound; // 0xC0
	internal long PRtopId; // 0xC8
	internal long PRheaderId; // 0xD0
	internal ReadObjectInfo PRobjectInfo; // 0xD8
	internal bool PRisValueTypeFixup; // 0xE0
	internal object PRnewObj; // 0xE8
	internal object[] PRobjectA; // 0xF0
	internal PrimitiveArray PRprimitiveArray; // 0xF8
	internal bool PRisRegistered; // 0x100
	internal object[] PRmemberData; // 0x108
	internal SerializationInfo PRsi; // 0x110
	internal int PRnullCount; // 0x118

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x1681BE0 Offset: 0x1680DE0 VA: 0x181681BE0
	internal void Init() { }

	// RVA: 0x1681CA0 Offset: 0x1680EA0 VA: 0x181681CA0
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class SerStack // TypeDefIndex: 3944
{
	// Fields
	internal object[] objects; // 0x10
	internal string stackId; // 0x18
	internal int top; // 0x20

	// Methods

	// RVA: 0x168DA50 Offset: 0x168CC50 VA: 0x18168DA50
	internal void .ctor(string stackId) { }

	// RVA: 0x168D940 Offset: 0x168CB40 VA: 0x18168D940
	internal void Push(object obj) { }

	// RVA: 0x168D8E0 Offset: 0x168CAE0 VA: 0x18168D8E0
	internal object Pop() { }

	// RVA: 0x168D7C0 Offset: 0x168C9C0 VA: 0x18168D7C0
	internal void IncreaseCapacity() { }

	// RVA: 0x168D8A0 Offset: 0x168CAA0 VA: 0x18168D8A0
	internal object Peek() { }

	// RVA: 0x168D860 Offset: 0x168CA60 VA: 0x18168D860
	internal object PeekPeek() { }

	// RVA: 0x168D850 Offset: 0x168CA50 VA: 0x18168D850
	internal bool IsEmpty() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
[DefaultMember("Item")]
[Serializable]
internal sealed class SizedArray : ICloneable // TypeDefIndex: 3945
{
	// Fields
	internal object[] objects; // 0x10
	internal object[] negObjects; // 0x18

	// Properties
	internal object Item { get; set; }

	// Methods

	// RVA: 0x168DD50 Offset: 0x168CF50 VA: 0x18168DD50
	internal void .ctor() { }

	// RVA: 0x168DDB0 Offset: 0x168CFB0 VA: 0x18168DDB0
	internal void .ctor(int length) { }

	// RVA: 0x168DE20 Offset: 0x168D020 VA: 0x18168DE20
	private void .ctor(SizedArray sizedArray) { }

	// RVA: 0x168DAC0 Offset: 0x168CCC0 VA: 0x18168DAC0 Slot: 4
	public object Clone() { }

	// RVA: 0x168DEE0 Offset: 0x168D0E0 VA: 0x18168DEE0
	internal object get_Item(int index) { }

	// RVA: 0x168DF50 Offset: 0x168D150 VA: 0x18168DF50
	internal void set_Item(int index, object value) { }

	// RVA: 0x168DBA0 Offset: 0x168CDA0 VA: 0x18168DBA0
	internal void IncreaseCapacity(int index) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
[DefaultMember("Item")]
[Serializable]
internal sealed class IntSizedArray : ICloneable // TypeDefIndex: 3946
{
	// Fields
	internal int[] objects; // 0x10
	internal int[] negObjects; // 0x18

	// Properties
	internal int Item { get; set; }

	// Methods

	// RVA: 0x167A4D0 Offset: 0x16796D0 VA: 0x18167A4D0
	public void .ctor() { }

	// RVA: 0x167A3F0 Offset: 0x16795F0 VA: 0x18167A3F0
	private void .ctor(IntSizedArray sizedArray) { }

	// RVA: 0x167A130 Offset: 0x1679330 VA: 0x18167A130 Slot: 4
	public object Clone() { }

	// RVA: 0x167A530 Offset: 0x1679730 VA: 0x18167A530
	internal int get_Item(int index) { }

	// RVA: 0x167A5A0 Offset: 0x16797A0 VA: 0x18167A5A0
	internal void set_Item(int index, int value) { }

	// RVA: 0x167A240 Offset: 0x1679440 VA: 0x18167A240
	internal void IncreaseCapacity(int index) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class NameCache // TypeDefIndex: 3947
{
	// Fields
	private static ConcurrentDictionary<string, object> ht; // 0x0
	private string name; // 0x10

	// Methods

	// RVA: 0x1681160 Offset: 0x1680360 VA: 0x181681160
	internal object GetCachedValue(string name) { }

	// RVA: 0x1681210 Offset: 0x1680410 VA: 0x181681210
	internal void SetCachedValue(object value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x16812A0 Offset: 0x16804A0 VA: 0x1816812A0
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ValueFixup // TypeDefIndex: 3948
{
	// Fields
	internal ValueFixupEnum valueFixupEnum; // 0x10
	internal Array arrayObj; // 0x18
	internal int[] indexMap; // 0x20
	internal object header; // 0x28
	internal object memberObject; // 0x30
	internal static MemberInfo valueInfo; // 0x0
	internal ReadObjectInfo objectInfo; // 0x38
	internal string memberName; // 0x40

	// Methods

	// RVA: 0x168F350 Offset: 0x168E550 VA: 0x18168F350
	internal void .ctor(Array arrayObj, int[] indexMap) { }

	// RVA: 0x168F390 Offset: 0x168E590 VA: 0x18168F390
	internal void .ctor(object memberObject, string memberName, ReadObjectInfo objectInfo) { }

	// RVA: 0x168EF90 Offset: 0x168E190 VA: 0x18168EF90
	internal void Fixup(ParseRecord record, ParseRecord parent) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class InternalFE // TypeDefIndex: 3949
{
	// Fields
	internal FormatterTypeStyle FEtypeFormat; // 0x10
	internal FormatterAssemblyStyle FEassemblyFormat; // 0x14
	internal TypeFilterLevel FEsecurityLevel; // 0x18
	internal InternalSerializerTypeE FEserializerTypeEnum; // 0x1C

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class NameInfo // TypeDefIndex: 3950
{
	// Fields
	internal string NIFullName; // 0x10
	internal long NIobjectId; // 0x18
	internal long NIassemId; // 0x20
	internal InternalPrimitiveTypeE NIprimitiveTypeEnum; // 0x28
	internal Type NItype; // 0x30
	internal bool NIisSealed; // 0x38
	internal bool NIisArray; // 0x39
	internal bool NIisArrayItem; // 0x3A
	internal bool NItransmitTypeOnObject; // 0x3B
	internal bool NItransmitTypeOnMember; // 0x3C
	internal bool NIisParentTypeOnObject; // 0x3D
	internal InternalArrayTypeE NIarrayEnum; // 0x40
	private bool NIsealedStatusChecked; // 0x44

	// Properties
	public bool IsSealed { get; }
	public string NIname { get; set; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor() { }

	// RVA: 0x1681310 Offset: 0x1680510 VA: 0x181681310
	internal void Init() { }

	// RVA: 0x1681340 Offset: 0x1680540 VA: 0x181681340
	public bool get_IsSealed() { }

	// RVA: 0x1681380 Offset: 0x1680580 VA: 0x181681380
	public string get_NIname() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_NIname(string value) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class PrimitiveArray // TypeDefIndex: 3951
{
	// Fields
	private InternalPrimitiveTypeE code; // 0x10
	private bool[] booleanA; // 0x18
	private char[] charA; // 0x20
	private double[] doubleA; // 0x28
	private short[] int16A; // 0x30
	private int[] int32A; // 0x38
	private long[] int64A; // 0x40
	private sbyte[] sbyteA; // 0x48
	private float[] singleA; // 0x50
	private ushort[] uint16A; // 0x58
	private uint[] uint32A; // 0x60
	private ulong[] uint64A; // 0x68

	// Methods

	// RVA: 0x16826A0 Offset: 0x16818A0 VA: 0x1816826A0
	internal void .ctor(InternalPrimitiveTypeE code, Array array) { }

	// RVA: 0x1681CE0 Offset: 0x1680EE0 VA: 0x181681CE0
	internal void Init(InternalPrimitiveTypeE code, Array array) { }

	// RVA: 0x1682280 Offset: 0x1681480 VA: 0x181682280
	internal void SetValue(string value, int index) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
[Flags]
[Serializable]
internal enum MessageEnum // TypeDefIndex: 3952
{
	// Fields
	public int value__; // 0x0
	public const MessageEnum NoArgs = 1;
	public const MessageEnum ArgsInline = 2;
	public const MessageEnum ArgsIsArray = 4;
	public const MessageEnum ArgsInArray = 8;
	public const MessageEnum NoContext = 16;
	public const MessageEnum ContextInline = 32;
	public const MessageEnum ContextInArray = 64;
	public const MessageEnum MethodSignatureInArray = 128;
	public const MessageEnum PropertyInArray = 256;
	public const MessageEnum NoReturnValue = 512;
	public const MessageEnum ReturnValueVoid = 1024;
	public const MessageEnum ReturnValueInline = 2048;
	public const MessageEnum ReturnValueInArray = 4096;
	public const MessageEnum ExceptionInArray = 8192;
	public const MessageEnum GenericMethod = 32768;
}

// Namespace: System.Runtime.InteropServices
public enum CharSet // TypeDefIndex: 3953
{
	// Fields
	public int value__; // 0x0
	public const CharSet None = 1;
	public const CharSet Ansi = 2;
	public const CharSet Unicode = 3;
	public const CharSet Auto = 4;
}

// Namespace: System.Runtime.InteropServices
[Serializable]
public class ExternalException : SystemException // TypeDefIndex: 3954
{
	// Properties
	public virtual int ErrorCode { get; }

	// Methods

	// RVA: 0x1676950 Offset: 0x1675B50 VA: 0x181676950
	public void .ctor() { }

	// RVA: 0x1677FE0 Offset: 0x16771E0 VA: 0x181677FE0
	public void .ctor(string message) { }

	// RVA: 0x1678000 Offset: 0x1677200 VA: 0x181678000
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x1678020 Offset: 0x1677220 VA: 0x181678020
	public void .ctor(string message, int errorCode) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x42D890 Offset: 0x42CA90 VA: 0x18042D890 Slot: 18
	public virtual int get_ErrorCode() { }

	// RVA: 0x1677E00 Offset: 0x1677000 VA: 0x181677E00 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Runtime.InteropServices
[IsReadOnly]
public struct HandleRef // TypeDefIndex: 3955
{
	// Fields
	private readonly object _wrapper; // 0x0
	private readonly IntPtr _handle; // 0x8

	// Properties
	public IntPtr Handle { get; }

	// Methods

	// RVA: 0x5C3520 Offset: 0x5C2720 VA: 0x1805C3520
	public void .ctor(object wrapper, IntPtr handle) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_Handle() { }
}

// Namespace: System.Runtime.InteropServices
[Serializable]
public class MarshalDirectiveException : SystemException // TypeDefIndex: 3956
{
	// Methods

	// RVA: 0x167CC40 Offset: 0x167BE40 VA: 0x18167CC40
	public void .ctor() { }

	// RVA: 0x167CC90 Offset: 0x167BE90 VA: 0x18167CC90
	public void .ctor(string message) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Runtime.InteropServices
public static class MemoryMarshal // TypeDefIndex: 3957
{
	// Methods

	// RVA: -1 Offset: -1
	public static Span<byte> AsBytes<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4C8D0 Offset: 0xA4BAD0 VA: 0x180A4C8D0
	|-MemoryMarshal.AsBytes<char>
	|
	|-RVA: 0xA4CAB0 Offset: 0xA4BCB0 VA: 0x180A4CAB0
	|-MemoryMarshal.AsBytes<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<byte> AsBytes<T>(ReadOnlySpan<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4CBF0 Offset: 0xA4BDF0 VA: 0x180A4CBF0
	|-MemoryMarshal.AsBytes<ushort>
	|
	|-RVA: 0xA4CC90 Offset: 0xA4BE90 VA: 0x180A4CC90
	|-MemoryMarshal.AsBytes<uint>
	|
	|-RVA: 0xA4C970 Offset: 0xA4BB70 VA: 0x180A4C970
	|-MemoryMarshal.AsBytes<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static Memory<T> AsMemory<T>(ReadOnlyMemory<T> memory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4354A0 Offset: 0x4346A0 VA: 0x1804354A0
	|-MemoryMarshal.AsMemory<byte>
	|-MemoryMarshal.AsMemory<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ref T GetReference<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	|-MemoryMarshal.GetReference<byte>
	|-MemoryMarshal.GetReference<char>
	|-MemoryMarshal.GetReference<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ref T GetReference<T>(ReadOnlySpan<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	|-MemoryMarshal.GetReference<byte>
	|-MemoryMarshal.GetReference<char>
	|-MemoryMarshal.GetReference<ushort>
	|-MemoryMarshal.GetReference<uint>
	|-MemoryMarshal.GetReference<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static ref T GetNonNullPinnableReference<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4CD80 Offset: 0xA4BF80 VA: 0x180A4CD80
	|-MemoryMarshal.GetNonNullPinnableReference<char>
	|
	|-RVA: 0xA4CDC0 Offset: 0xA4BFC0 VA: 0x180A4CDC0
	|-MemoryMarshal.GetNonNullPinnableReference<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static ref T GetNonNullPinnableReference<T>(ReadOnlySpan<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4CD80 Offset: 0xA4BF80 VA: 0x180A4CD80
	|-MemoryMarshal.GetNonNullPinnableReference<byte>
	|
	|-RVA: 0xA4CDC0 Offset: 0xA4BFC0 VA: 0x180A4CDC0
	|-MemoryMarshal.GetNonNullPinnableReference<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<T> CreateReadOnlySpan<T>(ref T reference, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4CD30 Offset: 0xA4BF30 VA: 0x180A4CD30
	|-MemoryMarshal.CreateReadOnlySpan<char>
	|-MemoryMarshal.CreateReadOnlySpan<uint>
	|-MemoryMarshal.CreateReadOnlySpan<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryGetArray<T>(ReadOnlyMemory<T> memory, out ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4D5A0 Offset: 0xA4C7A0 VA: 0x180A4D5A0
	|-MemoryMarshal.TryGetArray<byte>
	|
	|-RVA: 0xA4DB90 Offset: 0xA4CD90 VA: 0x180A4DB90
	|-MemoryMarshal.TryGetArray<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Runtime.InteropServices
public enum Architecture // TypeDefIndex: 3958
{
	// Fields
	public int value__; // 0x0
	public const Architecture X86 = 0;
	public const Architecture X64 = 1;
	public const Architecture Arm = 2;
	public const Architecture Arm64 = 3;
}

// Namespace: System.Runtime.InteropServices
[IsReadOnly]
public struct OSPlatform : IEquatable<OSPlatform> // TypeDefIndex: 3959
{
	// Fields
	private readonly string _osPlatform; // 0x0
	[CompilerGenerated]
	private static readonly OSPlatform <Linux>k__BackingField; // 0x0
	[CompilerGenerated]
	private static readonly OSPlatform <OSX>k__BackingField; // 0x8
	[CompilerGenerated]
	private static readonly OSPlatform <Windows>k__BackingField; // 0x10

	// Properties
	public static OSPlatform Linux { get; }
	public static OSPlatform OSX { get; }
	public static OSPlatform Windows { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1681A60 Offset: 0x1680C60 VA: 0x181681A60
	public static OSPlatform get_Linux() { }

	[CompilerGenerated]
	// RVA: 0x1681AB0 Offset: 0x1680CB0 VA: 0x181681AB0
	public static OSPlatform get_OSX() { }

	[CompilerGenerated]
	// RVA: 0x1681B00 Offset: 0x1680D00 VA: 0x181681B00
	public static OSPlatform get_Windows() { }

	// RVA: 0x1681990 Offset: 0x1680B90 VA: 0x181681990
	private void .ctor(string osPlatform) { }

	// RVA: 0x1681440 Offset: 0x1680640 VA: 0x181681440
	public static OSPlatform Create(string osPlatform) { }

	// RVA: 0x1681510 Offset: 0x1680710 VA: 0x181681510 Slot: 4
	public bool Equals(OSPlatform other) { }

	// RVA: 0x1681650 Offset: 0x1680850 VA: 0x181681650
	internal bool Equals(string other) { }

	// RVA: 0x1681570 Offset: 0x1680770 VA: 0x181681570 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15E5170 Offset: 0x15E4370 VA: 0x1815E5170 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1681670 Offset: 0x1680870 VA: 0x181681670 Slot: 3
	public override string ToString() { }

	// RVA: 0x1681B50 Offset: 0x1680D50 VA: 0x181681B50
	public static bool op_Equality(OSPlatform left, OSPlatform right) { }

	// RVA: 0x16816C0 Offset: 0x16808C0 VA: 0x1816816C0
	private static void .cctor() { }
}

// Namespace: System.Runtime.InteropServices
public enum GCHandleType // TypeDefIndex: 3960
{
	// Fields
	public int value__; // 0x0
	public const GCHandleType Weak = 0;
	public const GCHandleType WeakTrackResurrection = 1;
	public const GCHandleType Normal = 2;
	public const GCHandleType Pinned = 3;
}

// Namespace: System.Runtime.InteropServices
public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 3961
{
	// Fields
	private static readonly UIntPtr Uninitialized; // 0x0
	private UIntPtr _numBytes; // 0x20

	// Properties
	[CLSCompliant(False)]
	public ulong ByteLength { get; }

	// Methods

	// RVA: 0x168D250 Offset: 0x168C450 VA: 0x18168D250
	protected void .ctor(bool ownsHandle) { }

	[CLSCompliant(False)]
	// RVA: 0x168CF80 Offset: 0x168C180 VA: 0x18168CF80
	public void Initialize(ulong numBytes) { }

	[CLSCompliant(False)]
	// RVA: 0x168CEA0 Offset: 0x168C0A0 VA: 0x18168CEA0
	public void AcquirePointer(ref byte* pointer) { }

	// RVA: 0x168D130 Offset: 0x168C330 VA: 0x18168D130
	public void ReleasePointer() { }

	// RVA: 0x168D2D0 Offset: 0x168C4D0 VA: 0x18168D2D0
	public ulong get_ByteLength() { }

	// RVA: 0x168D0D0 Offset: 0x168C2D0 VA: 0x18168D0D0
	private static InvalidOperationException NotInitialized() { }

	// RVA: 0x168D1F0 Offset: 0x168C3F0 VA: 0x18168D1F0
	private static void .cctor() { }
}

// Namespace: System.Runtime.InteropServices
[Serializable]
public class COMException : ExternalException // TypeDefIndex: 3962
{
	// Methods

	// RVA: 0x1676950 Offset: 0x1675B50 VA: 0x181676950
	public void .ctor() { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1676780 Offset: 0x1675980 VA: 0x181676780 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Runtime.InteropServices
public sealed class ErrorWrapper // TypeDefIndex: 3963
{
	// Fields
	private int m_ErrorCode; // 0x10
}

// Namespace: System.Runtime.InteropServices
public interface ICustomMarshaler // TypeDefIndex: 3964
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object MarshalNativeToManaged(IntPtr pNativeData);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IntPtr MarshalManagedToNative(object ManagedObj);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void CleanUpNativeData(IntPtr pNativeData);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void CleanUpManagedData(object ManagedObj);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int GetNativeDataSize();
}

// Namespace: System.Runtime.InteropServices
[Usage(4096, AllowMultiple = False, Inherited = False)]
[ComVisible(True)]
public sealed class UnmanagedFunctionPointerAttribute : Attribute // TypeDefIndex: 3965
{
	// Fields
	private CallingConvention m_callingConvention; // 0x10
	public bool SetLastError; // 0x14

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	public void .ctor(CallingConvention callingConvention) { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Serializable]
public enum ComInterfaceType // TypeDefIndex: 3966
{
	// Fields
	public int value__; // 0x0
	public const ComInterfaceType InterfaceIsDual = 0;
	public const ComInterfaceType InterfaceIsIUnknown = 1;
	public const ComInterfaceType InterfaceIsIDispatch = 2;
	[ComVisible(False)]
	public const ComInterfaceType InterfaceIsIInspectable = 3;
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Usage(1024, Inherited = False)]
public sealed class InterfaceTypeAttribute : Attribute // TypeDefIndex: 3967
{
	// Fields
	internal ComInterfaceType _val; // 0x10

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	public void .ctor(ComInterfaceType interfaceType) { }
}

// Namespace: System.Runtime.InteropServices
[Usage(4, Inherited = False)]
[ComVisible(True)]
public sealed class ComDefaultInterfaceAttribute : Attribute // TypeDefIndex: 3968
{
	// Fields
	internal Type _val; // 0x10

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(Type defaultInterface) { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Serializable]
public enum ClassInterfaceType // TypeDefIndex: 3969
{
	// Fields
	public int value__; // 0x0
	public const ClassInterfaceType None = 0;
	public const ClassInterfaceType AutoDispatch = 1;
	public const ClassInterfaceType AutoDual = 2;
}

// Namespace: System.Runtime.InteropServices
[Usage(5, Inherited = False)]
[ComVisible(True)]
public sealed class ClassInterfaceAttribute : Attribute // TypeDefIndex: 3970
{
	// Fields
	internal ClassInterfaceType _val; // 0x10

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	public void .ctor(ClassInterfaceType classInterfaceType) { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Usage(5597, Inherited = False)]
public sealed class ComVisibleAttribute : Attribute // TypeDefIndex: 3971
{
	// Fields
	internal bool _val; // 0x10

	// Methods

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool visibility) { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Serializable]
public enum VarEnum // TypeDefIndex: 3972
{
	// Fields
	public int value__; // 0x0
	public const VarEnum VT_EMPTY = 0;
	public const VarEnum VT_NULL = 1;
	public const VarEnum VT_I2 = 2;
	public const VarEnum VT_I4 = 3;
	public const VarEnum VT_R4 = 4;
	public const VarEnum VT_R8 = 5;
	public const VarEnum VT_CY = 6;
	public const VarEnum VT_DATE = 7;
	public const VarEnum VT_BSTR = 8;
	public const VarEnum VT_DISPATCH = 9;
	public const VarEnum VT_ERROR = 10;
	public const VarEnum VT_BOOL = 11;
	public const VarEnum VT_VARIANT = 12;
	public const VarEnum VT_UNKNOWN = 13;
	public const VarEnum VT_DECIMAL = 14;
	public const VarEnum VT_I1 = 16;
	public const VarEnum VT_UI1 = 17;
	public const VarEnum VT_UI2 = 18;
	public const VarEnum VT_UI4 = 19;
	public const VarEnum VT_I8 = 20;
	public const VarEnum VT_UI8 = 21;
	public const VarEnum VT_INT = 22;
	public const VarEnum VT_UINT = 23;
	public const VarEnum VT_VOID = 24;
	public const VarEnum VT_HRESULT = 25;
	public const VarEnum VT_PTR = 26;
	public const VarEnum VT_SAFEARRAY = 27;
	public const VarEnum VT_CARRAY = 28;
	public const VarEnum VT_USERDEFINED = 29;
	public const VarEnum VT_LPSTR = 30;
	public const VarEnum VT_LPWSTR = 31;
	public const VarEnum VT_RECORD = 36;
	public const VarEnum VT_FILETIME = 64;
	public const VarEnum VT_BLOB = 65;
	public const VarEnum VT_STREAM = 66;
	public const VarEnum VT_STORAGE = 67;
	public const VarEnum VT_STREAMED_OBJECT = 68;
	public const VarEnum VT_STORED_OBJECT = 69;
	public const VarEnum VT_BLOB_OBJECT = 70;
	public const VarEnum VT_CF = 71;
	public const VarEnum VT_CLSID = 72;
	public const VarEnum VT_VECTOR = 4096;
	public const VarEnum VT_ARRAY = 8192;
	public const VarEnum VT_BYREF = 16384;
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Serializable]
public enum UnmanagedType // TypeDefIndex: 3973
{
	// Fields
	public int value__; // 0x0
	public const UnmanagedType Bool = 2;
	public const UnmanagedType I1 = 3;
	public const UnmanagedType U1 = 4;
	public const UnmanagedType I2 = 5;
	public const UnmanagedType U2 = 6;
	public const UnmanagedType I4 = 7;
	public const UnmanagedType U4 = 8;
	public const UnmanagedType I8 = 9;
	public const UnmanagedType U8 = 10;
	public const UnmanagedType R4 = 11;
	public const UnmanagedType R8 = 12;
	public const UnmanagedType Currency = 15;
	public const UnmanagedType BStr = 19;
	public const UnmanagedType LPStr = 20;
	public const UnmanagedType LPWStr = 21;
	public const UnmanagedType LPTStr = 22;
	public const UnmanagedType ByValTStr = 23;
	public const UnmanagedType IUnknown = 25;
	public const UnmanagedType IDispatch = 26;
	public const UnmanagedType Struct = 27;
	public const UnmanagedType Interface = 28;
	public const UnmanagedType SafeArray = 29;
	public const UnmanagedType ByValArray = 30;
	public const UnmanagedType SysInt = 31;
	public const UnmanagedType SysUInt = 32;
	public const UnmanagedType VBByRefStr = 34;
	public const UnmanagedType AnsiBStr = 35;
	public const UnmanagedType TBStr = 36;
	public const UnmanagedType VariantBool = 37;
	public const UnmanagedType FunctionPtr = 38;
	public const UnmanagedType AsAny = 40;
	public const UnmanagedType LPArray = 42;
	public const UnmanagedType LPStruct = 43;
	public const UnmanagedType CustomMarshaler = 44;
	public const UnmanagedType Error = 45;
	[ComVisible(False)]
	public const UnmanagedType IInspectable = 46;
	[ComVisible(False)]
	public const UnmanagedType HString = 47;
	[ComVisible(False)]
	public const UnmanagedType LPUTF8Str = 48;
}

// Namespace: System.Runtime.InteropServices
[Usage(1028, Inherited = False)]
[ComVisible(True)]
public sealed class ComImportAttribute : Attribute // TypeDefIndex: 3974
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.InteropServices
[Usage(5149, Inherited = False)]
[ComVisible(True)]
public sealed class GuidAttribute : Attribute // TypeDefIndex: 3975
{
	// Fields
	internal string _val; // 0x10

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string guid) { }
}

// Namespace: System.Runtime.InteropServices
[Usage(64, Inherited = False)]
[ComVisible(True)]
public sealed class PreserveSigAttribute : Attribute // TypeDefIndex: 3976
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Usage(2048, Inherited = False)]
public sealed class InAttribute : Attribute // TypeDefIndex: 3977
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.InteropServices
[Usage(2048, Inherited = False)]
[ComVisible(True)]
public sealed class OutAttribute : Attribute // TypeDefIndex: 3978
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Usage(2048, Inherited = False)]
public sealed class OptionalAttribute : Attribute // TypeDefIndex: 3979
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.InteropServices
[Flags]
public enum DllImportSearchPath // TypeDefIndex: 3980
{
	// Fields
	public int value__; // 0x0
	public const DllImportSearchPath UseDllDirectoryForDependencies = 256;
	public const DllImportSearchPath ApplicationDirectory = 512;
	public const DllImportSearchPath UserDirectories = 1024;
	public const DllImportSearchPath System32 = 2048;
	public const DllImportSearchPath SafeDirectories = 4096;
	public const DllImportSearchPath AssemblyDirectory = 2;
	public const DllImportSearchPath LegacyBehavior = 0;
}

// Namespace: System.Runtime.InteropServices
[Usage(65, AllowMultiple = False)]
[ComVisible(False)]
public sealed class DefaultDllImportSearchPathsAttribute : Attribute // TypeDefIndex: 3981
{
	// Fields
	internal DllImportSearchPath _paths; // 0x10

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	public void .ctor(DllImportSearchPath paths) { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Usage(64, Inherited = False)]
public sealed class DllImportAttribute : Attribute // TypeDefIndex: 3982
{
	// Fields
	internal string _val; // 0x10
	public string EntryPoint; // 0x18
	public CharSet CharSet; // 0x20
	public bool SetLastError; // 0x24
	public bool ExactSpelling; // 0x25
	public bool PreserveSig; // 0x26
	public CallingConvention CallingConvention; // 0x28
	public bool BestFitMapping; // 0x2C
	public bool ThrowOnUnmappableChar; // 0x2D

	// Properties
	public string Value { get; }

	// Methods

	// RVA: 0x16774F0 Offset: 0x16766F0 VA: 0x1816774F0
	internal static Attribute GetCustomAttribute(RuntimeMethodInfo method) { }

	// RVA: 0x1677750 Offset: 0x1676950 VA: 0x181677750
	internal static bool IsDefined(RuntimeMethodInfo method) { }

	// RVA: 0x1677780 Offset: 0x1676980 VA: 0x181677780
	internal void .ctor(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar) { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string dllName) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Value() { }
}

// Namespace: System.Runtime.InteropServices
[Usage(256, Inherited = False)]
[ComVisible(True)]
public sealed class FieldOffsetAttribute : Attribute // TypeDefIndex: 3983
{
	// Fields
	internal int _val; // 0x10

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	public void .ctor(int offset) { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Usage(1, Inherited = False)]
public sealed class ComCompatibleVersionAttribute : Attribute // TypeDefIndex: 3984
{
	// Fields
	internal int _major; // 0x10
	internal int _minor; // 0x14
	internal int _build; // 0x18
	internal int _revision; // 0x1C

	// Methods

	// RVA: 0x16769A0 Offset: 0x1675BA0 VA: 0x1816769A0
	public void .ctor(int major, int minor, int build, int revision) { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Serializable]
public enum CallingConvention // TypeDefIndex: 3985
{
	// Fields
	public int value__; // 0x0
	public const CallingConvention Winapi = 1;
	public const CallingConvention Cdecl = 2;
	public const CallingConvention StdCall = 3;
	public const CallingConvention ThisCall = 4;
	public const CallingConvention FastCall = 5;
}

// Namespace: System.Runtime.InteropServices
public abstract class CriticalHandle : CriticalFinalizerObject, IDisposable // TypeDefIndex: 3986
{
	// Fields
	protected IntPtr handle; // 0x10
	private bool _isClosed; // 0x18

	// Properties
	public bool IsClosed { get; }
	public abstract bool IsInvalid { get; }

	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: 0x1677300 Offset: 0x1676500 VA: 0x181677300
	protected void .ctor(IntPtr invalidHandleValue) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1677290 Offset: 0x1676490 VA: 0x181677290 Slot: 1
	protected override void Finalize() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x16771B0 Offset: 0x16763B0 VA: 0x1816771B0
	private void Cleanup() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private static void FireCustomerDebugProbe() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	protected void SetHandle(IntPtr handle) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_IsClosed() { }

	[ReliabilityContract(3, 2)]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsInvalid();

	[ReliabilityContract(3, 2)]
	// RVA: 0x151FDB0 Offset: 0x151EFB0 VA: 0x18151FDB0 Slot: 4
	public void Dispose() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x16771B0 Offset: 0x16763B0 VA: 0x1816771B0 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	[ReliabilityContract(3, 2)]
	// RVA: -1 Offset: -1 Slot: 7
	protected abstract bool ReleaseHandle();
}

// Namespace: System.Runtime.InteropServices
public abstract class SafeHandle : CriticalFinalizerObject, IDisposable // TypeDefIndex: 3987
{
	// Fields
	protected IntPtr handle; // 0x10
	private int _state; // 0x18
	private bool _ownsHandle; // 0x1C
	private bool _fullyInitialized; // 0x1D
	private const int RefCount_Mask = 2147483644;
	private const int RefCount_One = 4;

	// Properties
	public bool IsClosed { get; }
	public abstract bool IsInvalid { get; }

	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: 0x168D6A0 Offset: 0x168C8A0 VA: 0x18168D6A0
	protected void .ctor(IntPtr invalidHandleValue, bool ownsHandle) { }

	// RVA: 0x1677290 Offset: 0x1676490 VA: 0x181677290 Slot: 1
	protected override void Finalize() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	protected void SetHandle(IntPtr handle) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IntPtr DangerousGetHandle() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x168D730 Offset: 0x168C930 VA: 0x18168D730
	public bool get_IsClosed() { }

	[ReliabilityContract(3, 2)]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsInvalid();

	[ReliabilityContract(3, 2)]
	// RVA: 0x151FDB0 Offset: 0x151EFB0 VA: 0x18151FDB0
	public void Close() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x151FDB0 Offset: 0x151EFB0 VA: 0x18151FDB0 Slot: 4
	public void Dispose() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x168D4A0 Offset: 0x168C6A0 VA: 0x18168D4A0 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	[ReliabilityContract(3, 2)]
	// RVA: -1 Offset: -1 Slot: 7
	protected abstract bool ReleaseHandle();

	[ReliabilityContract(3, 2)]
	// RVA: 0x168D620 Offset: 0x168C820 VA: 0x18168D620
	public void SetHandleAsInvalid() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x168D380 Offset: 0x168C580 VA: 0x18168D380
	public void DangerousAddRef(ref bool success) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x168D490 Offset: 0x168C690 VA: 0x18168D490
	public void DangerousRelease() { }

	// RVA: 0x168D560 Offset: 0x168C760 VA: 0x18168D560
	private void InternalDispose() { }

	// RVA: 0x168D600 Offset: 0x168C800 VA: 0x18168D600
	private void InternalFinalize() { }

	// RVA: 0x168D3F0 Offset: 0x168C5F0 VA: 0x18168D3F0
	private void DangerousReleaseInternal(bool dispose) { }
}

// Namespace: System.Runtime.InteropServices
public static class RuntimeInformation // TypeDefIndex: 3988
{
	// Fields
	private static readonly Architecture _osArchitecture; // 0x0
	private static readonly Architecture _processArchitecture; // 0x4
	private static readonly OSPlatform _osPlatform; // 0x8

	// Properties
	public static string FrameworkDescription { get; }
	public static string OSDescription { get; }

	// Methods

	// RVA: 0x168B070 Offset: 0x168A270 VA: 0x18168B070
	private static void .cctor() { }

	// RVA: 0x168AF60 Offset: 0x168A160 VA: 0x18168AF60
	private static string GetRuntimeArchitecture() { }

	// RVA: 0x168AF50 Offset: 0x168A150 VA: 0x18168AF50
	private static string GetOSName() { }

	// RVA: 0x168B860 Offset: 0x168AA60 VA: 0x18168B860
	public static string get_FrameworkDescription() { }

	// RVA: 0x168AF70 Offset: 0x168A170 VA: 0x18168AF70
	public static bool IsOSPlatform(OSPlatform osPlatform) { }

	// RVA: 0x168B8C0 Offset: 0x168AAC0 VA: 0x18168B8C0
	public static string get_OSDescription() { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
public struct GCHandle // TypeDefIndex: 3989
{
	// Fields
	private IntPtr handle; // 0x0

	// Properties
	public bool IsAllocated { get; }
	public object Target { get; set; }

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	private void .ctor(IntPtr h) { }

	// RVA: 0x167A050 Offset: 0x1679250 VA: 0x18167A050
	private void .ctor(object obj) { }

	// RVA: 0x167A020 Offset: 0x1679220 VA: 0x18167A020
	internal void .ctor(object value, GCHandleType type) { }

	// RVA: 0x167A080 Offset: 0x1679280 VA: 0x18167A080
	public bool get_IsAllocated() { }

	// RVA: 0x167A090 Offset: 0x1679290 VA: 0x18167A090
	public object get_Target() { }

	// RVA: 0x167A100 Offset: 0x1679300 VA: 0x18167A100
	public void set_Target(object value) { }

	// RVA: 0x1679CD0 Offset: 0x1678ED0 VA: 0x181679CD0
	public IntPtr AddrOfPinnedObject() { }

	// RVA: 0x1679DE0 Offset: 0x1678FE0 VA: 0x181679DE0
	public static GCHandle Alloc(object value) { }

	// RVA: 0x1679DC0 Offset: 0x1678FC0 VA: 0x181679DC0
	public static GCHandle Alloc(object value, GCHandleType type) { }

	// RVA: 0x1679EA0 Offset: 0x16790A0 VA: 0x181679EA0
	public void Free() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	public static IntPtr op_Explicit(GCHandle value) { }

	// RVA: 0x1679F40 Offset: 0x1679140 VA: 0x181679F40
	public static GCHandle op_Explicit(IntPtr value) { }

	// RVA: 0x1679DF0 Offset: 0x1678FF0 VA: 0x181679DF0
	private static bool CheckCurrentDomain(IntPtr handle) { }

	// RVA: 0x1538180 Offset: 0x1537380 VA: 0x181538180
	private static object GetTarget(IntPtr handle) { }

	// RVA: 0x167A010 Offset: 0x1679210 VA: 0x18167A010
	private static IntPtr GetTargetHandle(object obj, IntPtr handle, GCHandleType type) { }

	// RVA: 0x1679E90 Offset: 0x1679090 VA: 0x181679E90
	private static void FreeHandle(IntPtr handle) { }

	// RVA: 0x167A000 Offset: 0x1679200 VA: 0x18167A000
	private static IntPtr GetAddrOfPinnedObject(IntPtr handle) { }

	// RVA: 0x1676F20 Offset: 0x1676120 VA: 0x181676F20
	public static bool op_Equality(GCHandle a, GCHandle b) { }

	// RVA: 0x1679E00 Offset: 0x1679000 VA: 0x181679E00 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1575BE0 Offset: 0x1574DE0 VA: 0x181575BE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1679F40 Offset: 0x1679140 VA: 0x181679F40
	public static GCHandle FromIntPtr(IntPtr value) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	public static IntPtr ToIntPtr(GCHandle value) { }
}

// Namespace: 
internal sealed class Marshal.SecureStringAllocator : MulticastDelegate // TypeDefIndex: 3990
{
	// Methods

	// RVA: 0x1203A70 Offset: 0x1202C70 VA: 0x181203A70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual IntPtr Invoke(int len) { }
}

// Namespace: 
internal class Marshal.MarshalerInstanceKeyComparer : IEqualityComparer<ValueTuple<Type, string>> // TypeDefIndex: 3991
{
	// Methods

	// RVA: 0x167FA00 Offset: 0x167EC00 VA: 0x18167FA00 Slot: 4
	public bool Equals(ValueTuple<Type, string> lhs, ValueTuple<Type, string> rhs) { }

	// RVA: 0x167FA60 Offset: 0x167EC60 VA: 0x18167FA60 Slot: 5
	public int GetHashCode(ValueTuple<Type, string> key) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Marshal.<>c // TypeDefIndex: 3992
{
	// Fields
	public static readonly Marshal.<>c <>9; // 0x0
	public static Func<Dictionary<ValueTuple<Type, string>, ICustomMarshaler>> <>9__201_0; // 0x8

	// Methods

	// RVA: 0x168EE60 Offset: 0x168E060 VA: 0x18168EE60
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x168EAD0 Offset: 0x168DCD0 VA: 0x18168EAD0
	internal Dictionary<ValueTuple<Type, string>, ICustomMarshaler> <GetCustomMarshalerInstance>b__201_0() { }
}

// Namespace: System.Runtime.InteropServices
public static class Marshal // TypeDefIndex: 3993
{
	// Fields
	public static readonly int SystemMaxDBCSCharSize; // 0x0
	public static readonly int SystemDefaultCharSize; // 0x4
	internal static Dictionary<ValueTuple<Type, string>, ICustomMarshaler> MarshalerInstanceCache; // 0x8
	internal static readonly object MarshalerInstanceCacheLock; // 0x10

	// Methods

	// RVA: 0x167CCB0 Offset: 0x167BEB0 VA: 0x18167CCB0
	public static IntPtr AllocCoTaskMem(int cb) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x167CCC0 Offset: 0x167BEC0 VA: 0x18167CCC0
	public static IntPtr AllocHGlobal(IntPtr cb) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x167CCD0 Offset: 0x167BED0 VA: 0x18167CCD0
	public static IntPtr AllocHGlobal(int cb) { }

	// RVA: 0x167F860 Offset: 0x167EA60 VA: 0x18167F860
	internal static void copy_to_unmanaged(Array source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x167F850 Offset: 0x167EA50 VA: 0x18167F850
	private static void copy_to_unmanaged_fixed(Array source, int startIndex, IntPtr destination, int length, void* fixed_source_element) { }

	// RVA: 0x167F9C0 Offset: 0x167EBC0 VA: 0x18167F9C0
	private static bool skip_fixed(Array array, int startIndex) { }

	// RVA: 0x167F8E0 Offset: 0x167EAE0 VA: 0x18167F8E0
	internal static void copy_to_unmanaged(byte[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x167CF20 Offset: 0x167C120 VA: 0x18167CF20
	public static void Copy(byte[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x167D220 Offset: 0x167C420 VA: 0x18167D220
	public static void Copy(short[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x167D020 Offset: 0x167C220 VA: 0x18167D020
	public static void Copy(int[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x167D120 Offset: 0x167C320 VA: 0x18167D120
	public static void Copy(IntPtr[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x167F7D0 Offset: 0x167E9D0 VA: 0x18167F7D0
	internal static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length) { }

	// RVA: 0x167F7C0 Offset: 0x167E9C0 VA: 0x18167F7C0
	private static void copy_from_unmanaged_fixed(IntPtr source, int startIndex, Array destination, int length, void* fixed_destination_element) { }

	// RVA: 0x167D720 Offset: 0x167C920 VA: 0x18167D720
	public static void Copy(IntPtr source, byte[] destination, int startIndex, int length) { }

	// RVA: 0x167D320 Offset: 0x167C520 VA: 0x18167D320
	public static void Copy(IntPtr source, char[] destination, int startIndex, int length) { }

	// RVA: 0x167D420 Offset: 0x167C620 VA: 0x18167D420
	public static void Copy(IntPtr source, short[] destination, int startIndex, int length) { }

	// RVA: 0x167D520 Offset: 0x167C720 VA: 0x18167D520
	public static void Copy(IntPtr source, int[] destination, int startIndex, int length) { }

	// RVA: 0x167D620 Offset: 0x167C820 VA: 0x18167D620
	public static void Copy(IntPtr source, IntPtr[] destination, int startIndex, int length) { }

	// RVA: 0x167D820 Offset: 0x167CA20 VA: 0x18167D820
	public static void FreeBSTR(IntPtr ptr) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x167D830 Offset: 0x167CA30 VA: 0x18167D830
	public static void FreeHGlobal(IntPtr hglobal) { }

	// RVA: 0x167CD40 Offset: 0x167BF40 VA: 0x18167CD40
	private static void ClearBSTR(IntPtr ptr) { }

	// RVA: 0x167F4F0 Offset: 0x167E6F0 VA: 0x18167F4F0
	public static void ZeroFreeBSTR(IntPtr s) { }

	// RVA: 0x167CE10 Offset: 0x167C010 VA: 0x18167CE10
	private static void ClearUnicode(IntPtr ptr) { }

	// RVA: 0x167F5F0 Offset: 0x167E7F0 VA: 0x18167F5F0
	public static void ZeroFreeGlobalAllocUnicode(IntPtr s) { }

	// RVA: 0x167E170 Offset: 0x167D370 VA: 0x18167E170
	public static int GetHRForException(Exception e) { }

	// RVA: 0x167E190 Offset: 0x167D390 VA: 0x18167E190
	public static bool IsComObject(object o) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x167E180 Offset: 0x167D380 VA: 0x18167E180
	public static int GetLastWin32Error() { }

	// RVA: 0x167E1A0 Offset: 0x167D3A0 VA: 0x18167E1A0
	public static IntPtr OffsetOf(Type t, string fieldName) { }

	// RVA: 0x167E1B0 Offset: 0x167D3B0 VA: 0x18167E1B0
	public static string PtrToStringAnsi(IntPtr ptr) { }

	// RVA: 0x167E1C0 Offset: 0x167D3C0 VA: 0x18167E1C0
	public static string PtrToStringAnsi(IntPtr ptr, int len) { }

	// RVA: 0x167E1D0 Offset: 0x167D3D0 VA: 0x18167E1D0
	public static string PtrToStringUni(IntPtr ptr) { }

	// RVA: 0x167E1E0 Offset: 0x167D3E0 VA: 0x18167E1E0
	public static string PtrToStringUni(IntPtr ptr, int len) { }

	[ComVisible(True)]
	// RVA: 0x167E200 Offset: 0x167D400 VA: 0x18167E200
	public static void PtrToStructure(IntPtr ptr, object structure) { }

	[ComVisible(True)]
	// RVA: 0x167E1F0 Offset: 0x167D3F0 VA: 0x18167E1F0
	public static object PtrToStructure(IntPtr ptr, Type structureType) { }

	// RVA: -1 Offset: -1
	public static void PtrToStructure<T>(IntPtr ptr, T structure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA455A0 Offset: 0xA447A0 VA: 0x180A455A0
	|-Marshal.PtrToStructure<object>
	|
	|-RVA: 0xA452A0 Offset: 0xA444A0 VA: 0x180A452A0
	|-Marshal.PtrToStructure<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T PtrToStructure<T>(IntPtr ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA454B0 Offset: 0xA446B0 VA: 0x180A454B0
	|-Marshal.PtrToStructure<object>
	|
	|-RVA: 0xA45710 Offset: 0xA44910 VA: 0x180A45710
	|-Marshal.PtrToStructure<Win32_FIXED_INFO_Marshal>
	|
	|-RVA: 0xA45890 Offset: 0xA44A90 VA: 0x180A45890
	|-Marshal.PtrToStructure<Win32_IP_ADAPTER_ADDRESSES>
	|
	|-RVA: 0xA459F0 Offset: 0xA44BF0 VA: 0x180A459F0
	|-Marshal.PtrToStructure<Win32_IP_ADAPTER_INFO>
	|
	|-RVA: 0xA45380 Offset: 0xA44580 VA: 0x180A45380
	|-Marshal.PtrToStructure<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xA45600 Offset: 0xA44800 VA: 0x180A45600
	|-Marshal.PtrToStructure<SentryNativeBridge.VaListLinux64>
	*/

	// RVA: 0x167E230 Offset: 0x167D430 VA: 0x18167E230
	public static byte ReadByte(IntPtr ptr) { }

	// RVA: 0x167E210 Offset: 0x167D410 VA: 0x18167E210
	public static byte ReadByte(IntPtr ptr, int ofs) { }

	// RVA: 0x167E250 Offset: 0x167D450 VA: 0x18167E250
	public static short ReadInt16(IntPtr ptr, int ofs) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x167E2F0 Offset: 0x167D4F0 VA: 0x18167E2F0
	public static int ReadInt32(IntPtr ptr) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x167E2A0 Offset: 0x167D4A0 VA: 0x18167E2A0
	public static int ReadInt32(IntPtr ptr, int ofs) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x167E330 Offset: 0x167D530 VA: 0x18167E330
	public static long ReadInt64(IntPtr ptr) { }

	// RVA: 0x167E390 Offset: 0x167D590 VA: 0x18167E390
	public static long ReadInt64(IntPtr ptr, int ofs) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x167E3E0 Offset: 0x167D5E0 VA: 0x18167E3E0
	public static IntPtr ReadIntPtr(IntPtr ptr) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x167E4E0 Offset: 0x167D6E0 VA: 0x18167E4E0
	private static int ReleaseInternal(IntPtr pUnk) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x167E4F0 Offset: 0x167D6F0 VA: 0x18167E4F0
	public static int Release(IntPtr pUnk) { }

	[ComVisible(True)]
	// RVA: 0x167F200 Offset: 0x167E400 VA: 0x18167F200
	public static int SizeOf(object structure) { }

	// RVA: 0x167F260 Offset: 0x167E460 VA: 0x18167F260
	public static int SizeOf(Type t) { }

	// RVA: -1 Offset: -1
	public static int SizeOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA45B50 Offset: 0xA44D50 VA: 0x180A45B50
	|-Marshal.SizeOf<object>
	|-Marshal.SizeOf<__Il2CppFullySharedGenericType>
	|-Marshal.SizeOf<Interop.SspiCli.SecPkgContext_IssuerListInfoEx>
	|-Marshal.SizeOf<Interop.Kernel32.COPYFILE2_EXTENDED_PARAMETERS>
	*/

	// RVA: -1 Offset: -1
	public static int SizeOf<T>(T structure) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA45F20 Offset: 0xA45120 VA: 0x180A45F20
	|-Marshal.SizeOf<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xA45BE0 Offset: 0xA44DE0 VA: 0x180A45BE0
	|-Marshal.SizeOf<AchievementManager.FFIEvents>
	|-Marshal.SizeOf<OverlayManager.FFIEvents>
	|-Marshal.SizeOf<UserManager.FFIEvents>
	|-Marshal.SizeOf<VoiceManager.FFIEvents>
	|
	|-RVA: 0xA45C80 Offset: 0xA44E80 VA: 0x180A45C80
	|-Marshal.SizeOf<ActivityManager.FFIEvents>
	|
	|-RVA: 0xA45DF0 Offset: 0xA44FF0 VA: 0x180A45DF0
	|-Marshal.SizeOf<ApplicationManager.FFIEvents>
	|-Marshal.SizeOf<Discord.FFIEvents>
	|-Marshal.SizeOf<ImageManager.FFIEvents>
	|-Marshal.SizeOf<StorageManager.FFIEvents>
	|
	|-RVA: 0xA45D30 Offset: 0xA44F30 VA: 0x180A45D30
	|-Marshal.SizeOf<LobbyManager.FFIEvents>
	|
	|-RVA: 0xA45E80 Offset: 0xA45080 VA: 0x180A45E80
	|-Marshal.SizeOf<NetworkManager.FFIEvents>
	|-Marshal.SizeOf<RelationshipManager.FFIEvents>
	|-Marshal.SizeOf<StoreManager.FFIEvents>
	|
	|-RVA: 0xA46030 Offset: 0xA45230 VA: 0x180A46030
	|-Marshal.SizeOf<SentryNativeBridge.VaListLinux64>
	*/

	// RVA: 0x167F270 Offset: 0x167E470 VA: 0x18167F270
	private static IntPtr StringToHGlobalAnsi(char* s, int length) { }

	// RVA: 0x167F280 Offset: 0x167E480 VA: 0x18167F280
	public static IntPtr StringToHGlobalAnsi(string s) { }

	// RVA: 0x167F380 Offset: 0x167E580 VA: 0x18167F380
	private static IntPtr StringToHGlobalUni(char* s, int length) { }

	// RVA: 0x167F300 Offset: 0x167E500 VA: 0x18167F300
	public static IntPtr StringToHGlobalUni(string s) { }

	// RVA: 0x167E990 Offset: 0x167DB90 VA: 0x18167E990
	public static IntPtr SecureStringToBSTR(SecureString s) { }

	// RVA: 0x167E5A0 Offset: 0x167D7A0 VA: 0x18167E5A0
	internal static IntPtr SecureStringCoTaskMemAllocator(int len) { }

	// RVA: 0x167E5F0 Offset: 0x167D7F0 VA: 0x18167E5F0
	internal static IntPtr SecureStringGlobalAllocator(int len) { }

	// RVA: 0x167E680 Offset: 0x167D880 VA: 0x18167E680
	internal static IntPtr SecureStringToAnsi(SecureString s, Marshal.SecureStringAllocator allocator) { }

	// RVA: 0x167EF70 Offset: 0x167E170 VA: 0x18167EF70
	internal static IntPtr SecureStringToUnicode(SecureString s, Marshal.SecureStringAllocator allocator) { }

	// RVA: 0x167EAD0 Offset: 0x167DCD0 VA: 0x18167EAD0
	public static IntPtr SecureStringToCoTaskMemAnsi(SecureString s) { }

	// RVA: 0x167EBD0 Offset: 0x167DDD0 VA: 0x18167EBD0
	public static IntPtr SecureStringToCoTaskMemUnicode(SecureString s) { }

	// RVA: 0x167ECD0 Offset: 0x167DED0 VA: 0x18167ECD0
	public static IntPtr SecureStringToGlobalAllocAnsi(SecureString s) { }

	// RVA: 0x167EE20 Offset: 0x167E020 VA: 0x18167EE20
	public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s) { }

	[ComVisible(True)]
	[ReliabilityContract(3, 1)]
	// RVA: 0x167F390 Offset: 0x167E590 VA: 0x18167F390
	public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld) { }

	// RVA: -1 Offset: -1
	public static void StructureToPtr<T>(T structure, IntPtr ptr, bool fDeleteOld) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA460E0 Offset: 0xA452E0 VA: 0x180A460E0
	|-Marshal.StructureToPtr<ArraySegment<byte>>
	|-Marshal.StructureToPtr<Nullable<double>>
	|-Marshal.StructureToPtr<AccountFeatureRestrictedInfoInternal>
	|-Marshal.StructureToPtr<CheckoutEntryInternal>
	|-Marshal.StructureToPtr<PresenceModificationDataRecordIdInternal>
	|-Marshal.StructureToPtr<QuatInternal>
	|-Marshal.StructureToPtr<RegisterEventParamDefInternal>
	|-Marshal.StructureToPtr<SocketIdInternal>
	|-Marshal.StructureToPtr<SteamIAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal>
	|-Marshal.StructureToPtr<SwitchIAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal>
	|-Marshal.StructureToPtr<WindowsRTCOptionsPlatformSpecificOptionsInternal>
	|-Marshal.StructureToPtr<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>
	|-Marshal.StructureToPtr<XSXOptionsSystemSpecificOptionsInternal>
	|-Marshal.StructureToPtr<XSXSubmitGraphicsCommandsDataCommandInternal>
	|-Marshal.StructureToPtr<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>
	|-Marshal.StructureToPtr<XboxOneGDKOptionsSystemSpecificOptionsInternal>
	|-Marshal.StructureToPtr<XboxOneGDKSubmitGraphicsCommandsDataCommandInternal>
	|-Marshal.StructureToPtr<NetworkManager.FFIEvents>
	|-Marshal.StructureToPtr<RelationshipManager.FFIEvents>
	|-Marshal.StructureToPtr<StoreManager.FFIEvents>
	|
	|-RVA: 0xA464E0 Offset: 0xA456E0 VA: 0x180A464E0
	|-Marshal.StructureToPtr<Nullable<uint>>
	|-Marshal.StructureToPtr<PS5OptionsInitOptionsInternal>
	|-Marshal.StructureToPtr<XSXPrePresentAdditionalDataInternal>
	|-Marshal.StructureToPtr<XboxOneGDKPrePresentAdditionalDataInternal>
	|-Marshal.StructureToPtr<AchievementManager.FFIEvents>
	|-Marshal.StructureToPtr<OverlayManager.FFIEvents>
	|-Marshal.StructureToPtr<UserManager.FFIEvents>
	|-Marshal.StructureToPtr<VoiceManager.FFIEvents>
	|
	|-RVA: 0xA46180 Offset: 0xA45380 VA: 0x180A46180
	|-Marshal.StructureToPtr<AndroidIAPVerifyPurchaseOptionsInternal>
	|-Marshal.StructureToPtr<EGSDLCVerifyPurchaseOptionsInternal>
	|-Marshal.StructureToPtr<EGSIAPVerifyPurchaseOptionsInternal>
	|-Marshal.StructureToPtr<IOSIAPVerifyPurchaseOptionsInternal>
	|-Marshal.StructureToPtr<LogPlayerUseWeaponDataInternal>
	|-Marshal.StructureToPtr<PS4DLCVerifyPurchaseOptionsInternal>
	|-Marshal.StructureToPtr<PS4DLCVerifyPurchaseOptionsPlatformSpecificOptionsInternal>
	|-Marshal.StructureToPtr<PS4IAPVerifyPurchaseOptionsInternal>
	|-Marshal.StructureToPtr<PS4IAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal>
	|-Marshal.StructureToPtr<PS4PrePresentOptionsPlatformSpecificDataInternal>
	|-Marshal.StructureToPtr<PS5DLCVerifyPurchaseOptionsInternal>
	|-Marshal.StructureToPtr<PS5DLCVerifyPurchaseOptionsPlatformSpecificOptionsInternal>
	|-Marshal.StructureToPtr<PS5IAPVerifyPurchaseOptionsInternal>
	|-Marshal.StructureToPtr<PS5IAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal>
	|-Marshal.StructureToPtr<PS5PrePresentOptionsPlatformSpecificDataInternal>
	|-Marshal.StructureToPtr<PinGrantInfoInternal>
	|-Marshal.StructureToPtr<SteamDLCVerifyPurchaseOptionsInternal>
	|-Marshal.StructureToPtr<SteamIAPVerifyPurchaseOptionsInternal>
	|-Marshal.StructureToPtr<SwitchIAPVerifyPurchaseOptionsInternal>
	|-Marshal.StructureToPtr<VerifyPurchaseOptionsInternal>
	|-Marshal.StructureToPtr<XSXDLCVerifyPurchaseOptionsInternal>
	|-Marshal.StructureToPtr<XSXIAPVerifyPurchaseOptionsInternal>
	|-Marshal.StructureToPtr<XboxOneGDKDLCVerifyPurchaseOptionsInternal>
	|-Marshal.StructureToPtr<XboxOneGDKIAPVerifyPurchaseOptionsInternal>
	|
	|-RVA: 0xA46230 Offset: 0xA45430 VA: 0x180A46230
	|-Marshal.StructureToPtr<AndroidIAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal>
	|-Marshal.StructureToPtr<CredentialsInternal>
	|-Marshal.StructureToPtr<DataRecordInternal>
	|-Marshal.StructureToPtr<EGSDLCVerifyPurchaseOptionsPlatformSpecificOptionsInternal>
	|-Marshal.StructureToPtr<EGSIAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal>
	|-Marshal.StructureToPtr<IOSIAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal>
	|-Marshal.StructureToPtr<IdTokenInternal>
	|-Marshal.StructureToPtr<IdTokenInternal>
	|-Marshal.StructureToPtr<IngestDataInternal>
	|-Marshal.StructureToPtr<ItemOwnershipInternal>
	|-Marshal.StructureToPtr<LogEventParamPairInternal>
	|-Marshal.StructureToPtr<OptionInternal>
	|-Marshal.StructureToPtr<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>
	|-Marshal.StructureToPtr<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>
	|-Marshal.StructureToPtr<ParticipantMetadataInternal>
	|-Marshal.StructureToPtr<PlayerStatInfoInternal>
	|-Marshal.StructureToPtr<RTCOptionsInternal>
	|-Marshal.StructureToPtr<SandboxIdItemOwnershipInternal>
	|-Marshal.StructureToPtr<StatThresholdsInternal>
	|-Marshal.StructureToPtr<SteamDLCVerifyPurchaseOptionsPlatformSpecificOptionsInternal>
	|-Marshal.StructureToPtr<UserLoginInfoInternal>
	|-Marshal.StructureToPtr<UserScoresQueryStatInfoInternal>
	|-Marshal.StructureToPtr<WindowsRTCOptionsInternal>
	|-Marshal.StructureToPtr<XSXDLCVerifyPurchaseOptionsPlatformSpecificOptionsInternal>
	|-Marshal.StructureToPtr<XSXIAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal>
	|-Marshal.StructureToPtr<XSXXBLOptionsInitOptionsInternal>
	|-Marshal.StructureToPtr<XboxOneGDKDLCVerifyPurchaseOptionsPlatformSpecificOptionsInternal>
	|-Marshal.StructureToPtr<XboxOneGDKIAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal>
	|-Marshal.StructureToPtr<XboxOneGDKXBLOptionsInitOptionsInternal>
	|-Marshal.StructureToPtr<SentryNativeBridge.VaListLinux64>
	|
	|-RVA: 0xA462E0 Offset: 0xA454E0 VA: 0x180A462E0
	|-Marshal.StructureToPtr<AndroidInitializeOptionsSystemInitializeOptionsInternal>
	|-Marshal.StructureToPtr<AttributeDataInternal>
	|-Marshal.StructureToPtr<AttributeDataInternal>
	|-Marshal.StructureToPtr<AudioBufferInternal>
	|-Marshal.StructureToPtr<IOSCredentialsSystemAuthCredentialsOptionsInternal>
	|-Marshal.StructureToPtr<OptionsInternal>
	|-Marshal.StructureToPtr<PS4OptionsInitOptionsInternal>
	|-Marshal.StructureToPtr<PS4OptionsInternal>
	|-Marshal.StructureToPtr<PS5OptionsInternal>
	|-Marshal.StructureToPtr<XSXXBLOptionsInternal>
	|-Marshal.StructureToPtr<XboxOneGDKXBLOptionsInternal>
	|-Marshal.StructureToPtr<ActivityManager.FFIEvents>
	|
	|-RVA: 0xA46390 Offset: 0xA45590 VA: 0x180A46390
	|-Marshal.StructureToPtr<CredentialsInternal>
	|-Marshal.StructureToPtr<IOSCredentialsInternal>
	|-Marshal.StructureToPtr<ModIdentifierInternal>
	|-Marshal.StructureToPtr<XSXPrePresentOptionsPlatformSpecificDataInternal>
	|-Marshal.StructureToPtr<XboxOneGDKPrePresentOptionsPlatformSpecificDataInternal>
	|
	|-RVA: 0xA46440 Offset: 0xA45640 VA: 0x180A46440
	|-Marshal.StructureToPtr<double>
	|
	|-RVA: 0xA467C0 Offset: 0xA459C0 VA: 0x180A467C0
	|-Marshal.StructureToPtr<InitializeThreadAffinityInternal>
	|
	|-RVA: 0xA46890 Offset: 0xA45A90 VA: 0x180A46890
	|-Marshal.StructureToPtr<short>
	|
	|-RVA: 0xA46930 Offset: 0xA45B30 VA: 0x180A46930
	|-Marshal.StructureToPtr<int>
	|-Marshal.StructureToPtr<uint>
	|
	|-RVA: 0xA469D0 Offset: 0xA45BD0 VA: 0x180A469D0
	|-Marshal.StructureToPtr<long>
	|-Marshal.StructureToPtr<IntPtr>
	|
	|-RVA: 0xA46A70 Offset: 0xA45C70 VA: 0x180A46A70
	|-Marshal.StructureToPtr<LocalRTCOptionsInternal>
	|-Marshal.StructureToPtr<RectInternal>
	|
	|-RVA: 0xA46CC0 Offset: 0xA45EC0 VA: 0x180A46CC0
	|-Marshal.StructureToPtr<object>
	|
	|-RVA: 0xA46B20 Offset: 0xA45D20 VA: 0x180A46B20
	|-Marshal.StructureToPtr<PS4InitializeOptionsSystemInitializeOptionsInternal>
	|-Marshal.StructureToPtr<TokenInternal>
	|
	|-RVA: 0xA46C00 Offset: 0xA45E00 VA: 0x180A46C00
	|-Marshal.StructureToPtr<PS5InitializeOptionsSystemInitializeOptionsInternal>
	|
	|-RVA: 0xA46D30 Offset: 0xA45F30 VA: 0x180A46D30
	|-Marshal.StructureToPtr<SessionDetailsInfoInternal>
	|-Marshal.StructureToPtr<SessionDetailsSettingsInternal>
	|
	|-RVA: 0xA46DF0 Offset: 0xA45FF0 VA: 0x180A46DF0
	|-Marshal.StructureToPtr<Vec3fInternal>
	|
	|-RVA: 0xA46580 Offset: 0xA45780 VA: 0x180A46580
	|-Marshal.StructureToPtr<XSXInitializeOptionsSystemInitializeOptionsInternal>
	|-Marshal.StructureToPtr<XboxOneGDKInitializeOptionsSystemInitializeOptionsInternal>
	|-Marshal.StructureToPtr<LobbyManager.FFIEvents>
	|
	|-RVA: 0xA466D0 Offset: 0xA458D0 VA: 0x180A466D0
	|-Marshal.StructureToPtr<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xA46640 Offset: 0xA45840 VA: 0x180A46640
	|-Marshal.StructureToPtr<ApplicationManager.FFIEvents>
	|-Marshal.StructureToPtr<Discord.FFIEvents>
	|-Marshal.StructureToPtr<ImageManager.FFIEvents>
	|-Marshal.StructureToPtr<StorageManager.FFIEvents>
	*/

	// RVA: 0x167CD30 Offset: 0x167BF30 VA: 0x18167CD30
	private static IntPtr BufferToBSTR(char* ptr, int slen) { }

	// RVA: 0x167F3A0 Offset: 0x167E5A0 VA: 0x18167F3A0
	public static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index) { }

	// RVA: -1 Offset: -1
	public static IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA46EA0 Offset: 0xA460A0 VA: 0x180A46EA0
	|-Marshal.UnsafeAddrOfPinnedArrayElement<byte>
	|
	|-RVA: 0xA46F00 Offset: 0xA46100 VA: 0x180A46F00
	|-Marshal.UnsafeAddrOfPinnedArrayElement<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x167F3B0 Offset: 0x167E5B0 VA: 0x18167F3B0
	public static void WriteByte(IntPtr ptr, byte val) { }

	// RVA: 0x167F3D0 Offset: 0x167E5D0 VA: 0x18167F3D0
	public static void WriteByte(IntPtr ptr, int ofs, byte val) { }

	// RVA: 0x167F400 Offset: 0x167E600 VA: 0x18167F400
	public static void WriteInt16(IntPtr ptr, int ofs, short val) { }

	// RVA: 0x167F450 Offset: 0x167E650 VA: 0x18167F450
	public static void WriteInt32(IntPtr ptr, int ofs, int val) { }

	// RVA: 0x167F4A0 Offset: 0x167E6A0 VA: 0x18167F4A0
	public static void WriteInt64(IntPtr ptr, int ofs, long val) { }

	// RVA: 0x167E0C0 Offset: 0x167D2C0 VA: 0x18167E0C0
	private static IntPtr GetFunctionPointerForDelegateInternal(Delegate d) { }

	// RVA: 0x167E0D0 Offset: 0x167D2D0 VA: 0x18167E0D0
	public static IntPtr GetFunctionPointerForDelegate(Delegate d) { }

	// RVA: -1 Offset: -1
	public static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA451B0 Offset: 0xA443B0 VA: 0x180A451B0
	|-Marshal.GetFunctionPointerForDelegate<object>
	|
	|-RVA: 0xA45010 Offset: 0xA44210 VA: 0x180A45010
	|-Marshal.GetFunctionPointerForDelegate<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x167F1F0 Offset: 0x167E3F0 VA: 0x18167F1F0
	internal static void SetLastWin32Error(int error) { }

	// RVA: 0x167D840 Offset: 0x167CA40 VA: 0x18167D840
	internal static ICustomMarshaler GetCustomMarshalerInstance(Type type, string cookie) { }

	// RVA: 0x167F730 Offset: 0x167E930 VA: 0x18167F730
	private static void .cctor() { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Usage(10496, Inherited = False)]
public sealed class MarshalAsAttribute : Attribute // TypeDefIndex: 3994
{
	// Fields
	public string MarshalCookie; // 0x10
	[ComVisible(True)]
	public string MarshalType; // 0x18
	[ComVisible(True)]
	public Type MarshalTypeRef; // 0x20
	public Type SafeArrayUserDefinedSubType; // 0x28
	private UnmanagedType utype; // 0x30
	public UnmanagedType ArraySubType; // 0x34
	public VarEnum SafeArraySubType; // 0x38
	public int SizeConst; // 0x3C
	public int IidParameterIndex; // 0x40
	public short SizeParamIndex; // 0x44

	// Properties
	public UnmanagedType Value { get; }

	// Methods

	// RVA: 0x167CC10 Offset: 0x167BE10 VA: 0x18167CC10
	public void .ctor(UnmanagedType unmanagedType) { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public UnmanagedType get_Value() { }

	// RVA: 0x167CBB0 Offset: 0x167BDB0 VA: 0x18167CBB0
	internal MarshalAsAttribute Copy() { }
}

// Namespace: System.Runtime.InteropServices
[Guid("03973551-57A1-3900-A2B5-9083E3FF2943")]
[InterfaceType(1)]
[CLSCompliant(False)]
[ComVisible(True)]
public interface _Activator // TypeDefIndex: 3995
{}

// Namespace: System.Runtime.InteropServices
[Guid("17156360-2F1A-384A-BC52-FDE93C215C5B")]
[ComVisible(True)]
[InterfaceType(0)]
[CLSCompliant(False)]
public interface _Assembly // TypeDefIndex: 3996
{}

// Namespace: System.Runtime.InteropServices
[InterfaceType(1)]
[CLSCompliant(False)]
[ComVisible(True)]
[Guid("B42B6AAC-317E-34D5-9FA9-093BB4160C50")]
public interface _AssemblyName // TypeDefIndex: 3997
{}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[CLSCompliant(False)]
[InterfaceType(0)]
[Guid("b36b5c63-42ef-38bc-a07e-0b34c98f164a")]
public interface _Exception // TypeDefIndex: 3998
{}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[CLSCompliant(False)]
[Guid("D002E9BA-D9E3-3749-B1D3-D565A08B13E7")]
[InterfaceType(1)]
public interface _Module // TypeDefIndex: 3999
{}

// Namespace: System.Runtime.InteropServices
[Guid("993634C4-E47A-32CC-BE08-85F567DC27D6")]
[InterfaceType(1)]
[ComVisible(True)]
[CLSCompliant(False)]
public interface _ParameterInfo // TypeDefIndex: 4000
{}

// Namespace: System.Runtime.InteropServices.ComTypes
[Guid("0000000f-0000-0000-C000-000000000046")]
[InterfaceType(1)]
public interface IMoniker // TypeDefIndex: 4001
{
	// Methods

	// RVA: -1 Offset: -1
	public abstract void $__Stripped0_GetClassID();

	// RVA: -1 Offset: -1
	public abstract void $__Stripped1_IsDirty();

	// RVA: -1 Offset: -1
	public abstract void $__Stripped2_Load();

	// RVA: -1 Offset: -1
	public abstract void $__Stripped3_Save();

	// RVA: -1 Offset: -1
	public abstract void $__Stripped4_GetSizeMax();

	// RVA: -1 Offset: -1
	public abstract void $__Stripped5_BindToObject();

	// RVA: -1 Offset: -1
	public abstract void $__Stripped6_BindToStorage();

	// RVA: -1 Offset: -1
	public abstract void $__Stripped7_Reduce();

	// RVA: -1 Offset: -1
	public abstract void $__Stripped8_ComposeWith();

	// RVA: -1 Offset: -1
	public abstract void $__Stripped9_Enum();

	// RVA: -1 Offset: -1
	public abstract void $__Stripped10_IsEqual();

	// RVA: -1 Offset: -1
	public abstract void $__Stripped11_Hash();

	// RVA: -1 Offset: -1
	public abstract void $__Stripped12_IsRunning();

	// RVA: -1 Offset: -1
	public abstract void $__Stripped13_GetTimeOfLastChange();

	// RVA: -1 Offset: -1
	public abstract void $__Stripped14_Inverse();

	// RVA: -1 Offset: -1
	public abstract void $__Stripped15_CommonPrefixWith();

	// RVA: -1 Offset: -1
	public abstract void $__Stripped16_RelativePathTo();

	// RVA: -1 Offset: -1
	public abstract void $__Stripped17_GetDisplayName();

	// RVA: -1 Offset: -1
	public abstract void $__Stripped18_ParseDisplayName();

	// RVA: -1 Offset: -1
	public abstract void $__Stripped19_IsSystemMoniker();
}

// Namespace: System.Runtime.ExceptionServices
public class FirstChanceExceptionEventArgs : EventArgs // TypeDefIndex: 4002
{}

// Namespace: System.Runtime.ExceptionServices
[Usage(64, AllowMultiple = False, Inherited = False)]
public sealed class HandleProcessCorruptedStateExceptionsAttribute : Attribute // TypeDefIndex: 4003
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.ExceptionServices
public sealed class ExceptionDispatchInfo // TypeDefIndex: 4004
{
	// Fields
	private Exception m_Exception; // 0x10
	private object m_stackTrace; // 0x18

	// Properties
	internal object BinaryStackTraceArray { get; }
	public Exception SourceException { get; }

	// Methods

	// RVA: 0x1677CD0 Offset: 0x1676ED0 VA: 0x181677CD0
	private void .ctor(Exception exception) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal object get_BinaryStackTraceArray() { }

	// RVA: 0x1677A80 Offset: 0x1676C80 VA: 0x181677A80
	public static ExceptionDispatchInfo Capture(Exception source) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Exception get_SourceException() { }

	[StackTraceHidden]
	// RVA: 0x1677C50 Offset: 0x1676E50 VA: 0x181677C50
	public void Throw() { }

	[StackTraceHidden]
	// RVA: 0x1677CA0 Offset: 0x1676EA0 VA: 0x181677CA0
	public static void Throw(Exception source) { }
}

// Namespace: System.Runtime.ConstrainedExecution
public enum Cer // TypeDefIndex: 4005
{
	// Fields
	public int value__; // 0x0
	public const Cer None = 0;
	public const Cer MayFail = 1;
	public const Cer Success = 2;
}

// Namespace: System.Runtime.ConstrainedExecution
public enum Consistency // TypeDefIndex: 4006
{
	// Fields
	public int value__; // 0x0
	public const Consistency MayCorruptProcess = 0;
	public const Consistency MayCorruptAppDomain = 1;
	public const Consistency MayCorruptInstance = 2;
	public const Consistency WillNotCorruptState = 3;
}

// Namespace: System.Runtime.ConstrainedExecution
[Usage(1133, Inherited = False)]
public sealed class ReliabilityContractAttribute : Attribute // TypeDefIndex: 4007
{
	// Fields
	[CompilerGenerated]
	private readonly Consistency <ConsistencyGuarantee>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Cer <Cer>k__BackingField; // 0x14

	// Methods

	// RVA: 0x16826E0 Offset: 0x16818E0 VA: 0x1816826E0
	public void .ctor(Consistency consistencyGuarantee, Cer cer) { }
}

// Namespace: System.Runtime.ConstrainedExecution
[Usage(96, Inherited = False)]
public sealed class PrePrepareMethodAttribute : Attribute // TypeDefIndex: 4008
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.ConstrainedExecution
public abstract class CriticalFinalizerObject // TypeDefIndex: 4009
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x1677170 Offset: 0x1676370 VA: 0x181677170 Slot: 1
	protected override void Finalize() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(64, Inherited = False, AllowMultiple = False)]
public sealed class AsyncIteratorStateMachineAttribute : StateMachineAttribute // TypeDefIndex: 4010
{}

// Namespace: System.Runtime.CompilerServices
[Usage(5148, Inherited = False, AllowMultiple = False)]
public sealed class AsyncMethodBuilderAttribute : Attribute // TypeDefIndex: 4011
{
	// Fields
	[CompilerGenerated]
	private readonly Type <BuilderType>k__BackingField; // 0x10

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(Type builderType) { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(64, Inherited = False, AllowMultiple = False)]
[Serializable]
public sealed class AsyncStateMachineAttribute : StateMachineAttribute // TypeDefIndex: 4012
{
	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(Type stateMachineType) { }
}

// Namespace: System.Runtime.CompilerServices
public struct AsyncValueTaskMethodBuilder // TypeDefIndex: 4013
{
	// Fields
	private AsyncTaskMethodBuilder _methodBuilder; // 0x0
	private bool _haveResult; // 0x18
	private bool _useBuilder; // 0x19
}

// Namespace: System.Runtime.CompilerServices
public struct AsyncValueTaskMethodBuilder<TResult> // TypeDefIndex: 4014
{
	// Fields
	private AsyncTaskMethodBuilder<TResult> _methodBuilder; // 0x0
	private TResult _result; // 0x0
	private bool _haveResult; // 0x0
	private bool _useBuilder; // 0x0

	// Properties
	public ValueTask<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static AsyncValueTaskMethodBuilder<TResult> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9E9120 Offset: 0x9E8320 VA: 0x1809E9120
	|-AsyncValueTaskMethodBuilder<int>.Create
	|
	|-RVA: 0x6F8E60 Offset: 0x6F8060 VA: 0x1806F8E60
	|-AsyncValueTaskMethodBuilder<object>.Create
	|-AsyncValueTaskMethodBuilder<ValueWebSocketReceiveResult>.Create
	|
	|-RVA: 0xE95F90 Offset: 0xE95190 VA: 0x180E95F90
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.Create
	*/

	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E1050 Offset: 0x8E0250 VA: 0x1808E1050
	|-AsyncValueTaskMethodBuilder<int>.Start<Stream.<<ReadAsync>g__FinishReadAsync|44_0>d>
	|
	|-RVA: 0x8E0EA0 Offset: 0x8E00A0 VA: 0x1808E0EA0
	|-AsyncValueTaskMethodBuilder<int>.Start<StreamReader.<ReadAsyncInternal>d__66>
	|
	|-RVA: 0x8E0F30 Offset: 0x8E0130 VA: 0x1808E0F30
	|-AsyncValueTaskMethodBuilder<object>.Start<ManagedWebSocket.<ReceiveAsyncPrivate>d__61<ManagedWebSocket.WebSocketReceiveResultGetter, object>>
	|
	|-RVA: 0x8E0FC0 Offset: 0x8E01C0 VA: 0x1808E0FC0
	|-AsyncValueTaskMethodBuilder<ValueWebSocketReceiveResult>.Start<WebSocket.<ReceiveAsync>d__14>
	|
	|-RVA: 0x8E0DC0 Offset: 0x8DFFC0 VA: 0x1808E0DC0
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.Start<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE96830 Offset: 0xE95A30 VA: 0x180E96830
	|-AsyncValueTaskMethodBuilder<int>.SetStateMachine
	|-AsyncValueTaskMethodBuilder<object>.SetStateMachine
	|-AsyncValueTaskMethodBuilder<ValueWebSocketReceiveResult>.SetStateMachine
	|
	|-RVA: 0xE968C0 Offset: 0xE95AC0 VA: 0x180E968C0
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetStateMachine
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE964D0 Offset: 0xE956D0 VA: 0x180E964D0
	|-AsyncValueTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0xE96410 Offset: 0xE95610 VA: 0x180E96410
	|-AsyncValueTaskMethodBuilder<object>.SetResult
	|
	|-RVA: 0xE96350 Offset: 0xE95550 VA: 0x180E96350
	|-AsyncValueTaskMethodBuilder<ValueWebSocketReceiveResult>.SetResult
	|
	|-RVA: 0xE96580 Offset: 0xE95780 VA: 0x180E96580
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetResult
	*/

	// RVA: -1 Offset: -1
	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE962B0 Offset: 0xE954B0 VA: 0x180E962B0
	|-AsyncValueTaskMethodBuilder<int>.SetException
	|
	|-RVA: 0xE96170 Offset: 0xE95370 VA: 0x180E96170
	|-AsyncValueTaskMethodBuilder<object>.SetException
	|
	|-RVA: 0xE96210 Offset: 0xE95410 VA: 0x180E96210
	|-AsyncValueTaskMethodBuilder<ValueWebSocketReceiveResult>.SetException
	|
	|-RVA: 0xE96070 Offset: 0xE95270 VA: 0x180E96070
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetException
	*/

	// RVA: -1 Offset: -1
	public ValueTask<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE96E10 Offset: 0xE96010 VA: 0x180E96E10
	|-AsyncValueTaskMethodBuilder<int>.get_Task
	|
	|-RVA: 0xE96F20 Offset: 0xE96120 VA: 0x180E96F20
	|-AsyncValueTaskMethodBuilder<object>.get_Task
	|
	|-RVA: 0xE969C0 Offset: 0xE95BC0 VA: 0x180E969C0
	|-AsyncValueTaskMethodBuilder<ValueWebSocketReceiveResult>.get_Task
	|
	|-RVA: 0xE96AE0 Offset: 0xE95CE0 VA: 0x180E96AE0
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.get_Task
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E0AC0 Offset: 0x8DFCC0 VA: 0x1808E0AC0
	|-AsyncValueTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, Stream.<<ReadAsync>g__FinishReadAsync|44_0>d>
	|
	|-RVA: 0x8E0A20 Offset: 0x8DFC20 VA: 0x1808E0A20
	|-AsyncValueTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, StreamReader.<ReadAsyncInternal>d__66>
	|
	|-RVA: 0x8E0B60 Offset: 0x8DFD60 VA: 0x1808E0B60
	|-AsyncValueTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, StreamReader.<ReadAsyncInternal>d__66>
	|
	|-RVA: 0x8E0C00 Offset: 0x8DFE00 VA: 0x1808E0C00
	|-AsyncValueTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, ManagedWebSocket.<ReceiveAsyncPrivate>d__61<ManagedWebSocket.WebSocketReceiveResultGetter, object>>
	|
	|-RVA: 0x8E0980 Offset: 0x8DFB80 VA: 0x1808E0980
	|-AsyncValueTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, ManagedWebSocket.<ReceiveAsyncPrivate>d__61<ManagedWebSocket.WebSocketReceiveResultGetter, object>>
	|
	|-RVA: 0x8E08E0 Offset: 0x8DFAE0 VA: 0x1808E08E0
	|-AsyncValueTaskMethodBuilder<ValueWebSocketReceiveResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebSocket.<ReceiveAsync>d__14>
	|
	|-RVA: 0x8E0CA0 Offset: 0x8DFEA0 VA: 0x1808E0CA0
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.AwaitUnsafeOnCompleted<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Runtime.CompilerServices
[Usage(2048, Inherited = False)]
public sealed class CallerMemberNameAttribute : Attribute // TypeDefIndex: 4015
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(32767, Inherited = True)]
[Serializable]
public sealed class CompilerGeneratedAttribute : Attribute // TypeDefIndex: 4016
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[IsReadOnly]
public struct ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter : ICriticalNotifyCompletion // TypeDefIndex: 4017
{
	// Fields
	private readonly ValueTask _value; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x4354B0 Offset: 0x4346B0 VA: 0x1804354B0
	internal void .ctor(ValueTask value) { }

	// RVA: 0x1676ED0 Offset: 0x16760D0 VA: 0x181676ED0
	public bool get_IsCompleted() { }

	[StackTraceHidden]
	// RVA: 0x1676C00 Offset: 0x1675E00 VA: 0x181676C00
	public void GetResult() { }

	// RVA: 0x1676C50 Offset: 0x1675E50 VA: 0x181676C50 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct ConfiguredValueTaskAwaitable // TypeDefIndex: 4018
{
	// Fields
	private readonly ValueTask _value; // 0x0

	// Methods

	// RVA: 0x4354B0 Offset: 0x4346B0 VA: 0x1804354B0
	internal void .ctor(ValueTask value) { }

	// RVA: 0x4354A0 Offset: 0x4346A0 VA: 0x1804354A0
	public ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter GetAwaiter() { }
}

// Namespace: 
[IsReadOnly]
public struct ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<TResult> : ICriticalNotifyCompletion // TypeDefIndex: 4019
{
	// Fields
	private readonly ValueTask<TResult> _value; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ValueTask<TResult> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4354B0 Offset: 0x4346B0 VA: 0x1804354B0
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>..ctor
	|
	|-RVA: 0x4BBD50 Offset: 0x4BAF50 VA: 0x1804BBD50
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<object>..ctor
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<ValueWebSocketReceiveResult>..ctor
	|
	|-RVA: 0xD14BC0 Offset: 0xD13DC0 VA: 0x180D14BC0
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD14D80 Offset: 0xD13F80 VA: 0x180D14D80
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>.get_IsCompleted
	|
	|-RVA: 0xD14C90 Offset: 0xD13E90 VA: 0x180D14C90
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<object>.get_IsCompleted
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<ValueWebSocketReceiveResult>.get_IsCompleted
	|
	|-RVA: 0xD14CD0 Offset: 0xD13ED0 VA: 0x180D14CD0
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<__Il2CppFullySharedGenericType>.get_IsCompleted
	*/

	[StackTraceHidden]
	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD04350 Offset: 0xD03550 VA: 0x180D04350
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>.GetResult
	|
	|-RVA: 0xD13DD0 Offset: 0xD12FD0 VA: 0x180D13DD0
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<object>.GetResult
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<ValueWebSocketReceiveResult>.GetResult
	|
	|-RVA: 0xD13E10 Offset: 0xD13010 VA: 0x180D13E10
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<__Il2CppFullySharedGenericType>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB7390 Offset: 0xFB6590 VA: 0x180FB7390
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>.UnsafeOnCompleted
	|
	|-RVA: 0xFB7AE0 Offset: 0xFB6CE0 VA: 0x180FB7AE0
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<object>.UnsafeOnCompleted
	|
	|-RVA: 0xFB7130 Offset: 0xFB6330 VA: 0x180FB7130
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<ValueWebSocketReceiveResult>.UnsafeOnCompleted
	|
	|-RVA: 0xFB75F0 Offset: 0xFB67F0 VA: 0x180FB75F0
	|-ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<__Il2CppFullySharedGenericType>.UnsafeOnCompleted
	*/
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct ConfiguredValueTaskAwaitable<TResult> // TypeDefIndex: 4020
{
	// Fields
	private readonly ValueTask<TResult> _value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ValueTask<TResult> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4354B0 Offset: 0x4346B0 VA: 0x1804354B0
	|-ConfiguredValueTaskAwaitable<int>..ctor
	|
	|-RVA: 0x4BBD50 Offset: 0x4BAF50 VA: 0x1804BBD50
	|-ConfiguredValueTaskAwaitable<object>..ctor
	|-ConfiguredValueTaskAwaitable<ValueWebSocketReceiveResult>..ctor
	|
	|-RVA: 0xD14BC0 Offset: 0xD13DC0 VA: 0x180D14BC0
	|-ConfiguredValueTaskAwaitable<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD15D90 Offset: 0xD14F90 VA: 0x180D15D90
	|-ConfiguredValueTaskAwaitable<int>.GetAwaiter
	|
	|-RVA: 0xD2B650 Offset: 0xD2A850 VA: 0x180D2B650
	|-ConfiguredValueTaskAwaitable<object>.GetAwaiter
	|-ConfiguredValueTaskAwaitable<ValueWebSocketReceiveResult>.GetAwaiter
	|
	|-RVA: 0xFB3EF0 Offset: 0xFB30F0 VA: 0x180FB3EF0
	|-ConfiguredValueTaskAwaitable<__Il2CppFullySharedGenericType>.GetAwaiter
	*/
}

// Namespace: System.Runtime.CompilerServices
[Usage(2304, Inherited = False)]
[Serializable]
public abstract class CustomConstantAttribute : Attribute // TypeDefIndex: 4021
{
	// Properties
	public abstract object Value { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract object get_Value();

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	protected void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(2304, Inherited = False)]
[Serializable]
public sealed class DateTimeConstantAttribute : CustomConstantAttribute // TypeDefIndex: 4022
{
	// Fields
	private DateTime _date; // 0x10

	// Properties
	public override object Value { get; }

	// Methods

	// RVA: 0x16773D0 Offset: 0x16765D0 VA: 0x1816773D0 Slot: 7
	public override object get_Value() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(2304, Inherited = False)]
[Serializable]
public sealed class DecimalConstantAttribute : Attribute // TypeDefIndex: 4023
{
	// Fields
	private Decimal _dec; // 0x10

	// Properties
	public Decimal Value { get; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x1677420 Offset: 0x1676620 VA: 0x181677420
	public void .ctor(byte scale, byte sign, uint hi, uint mid, uint low) { }

	// RVA: 0x482990 Offset: 0x481B90 VA: 0x180482990
	public Decimal get_Value() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(69)]
public sealed class ExtensionAttribute : Attribute // TypeDefIndex: 4024
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(256, Inherited = False)]
public sealed class FixedBufferAttribute : Attribute // TypeDefIndex: 4025
{
	// Fields
	[CompilerGenerated]
	private readonly Type <ElementType>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly int <Length>k__BackingField; // 0x18

	// Properties
	public Type ElementType { get; }
	public int Length { get; }

	// Methods

	// RVA: 0x16774B0 Offset: 0x16766B0 VA: 0x1816774B0
	public void .ctor(Type elementType, int length) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Type get_ElementType() { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_Length() { }
}

// Namespace: 
private sealed class FormattableStringFactory.ConcreteFormattableString : FormattableString // TypeDefIndex: 4026
{
	// Fields
	private readonly string _format; // 0x10
	private readonly object[] _arguments; // 0x18

	// Properties
	public override string Format { get; }
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1675460 Offset: 0x1674660 VA: 0x181675460
	internal void .ctor(string format, object[] arguments) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 5
	public override string get_Format() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	public override object[] GetArguments() { }

	// RVA: 0xBED310 Offset: 0xBEC510 VA: 0x180BED310 Slot: 7
	public override int get_ArgumentCount() { }

	// RVA: 0x1654DC0 Offset: 0x1653FC0 VA: 0x181654DC0 Slot: 8
	public override object GetArgument(int index) { }

	// RVA: 0x16769F0 Offset: 0x1675BF0 VA: 0x1816769F0 Slot: 9
	public override string ToString(IFormatProvider formatProvider) { }
}

// Namespace: System.Runtime.CompilerServices
public static class FormattableStringFactory // TypeDefIndex: 4027
{
	// Methods

	// RVA: 0x1679BC0 Offset: 0x1678DC0 VA: 0x181679BC0
	public static FormattableString Create(string format, object[] arguments) { }
}

// Namespace: System.Runtime.CompilerServices
public interface IAsyncStateMachine // TypeDefIndex: 4028
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void MoveNext();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetStateMachine(IAsyncStateMachine stateMachine);
}

// Namespace: System.Runtime.CompilerServices
public interface ICriticalNotifyCompletion // TypeDefIndex: 4029
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void UnsafeOnCompleted(Action continuation);
}

// Namespace: System.Runtime.CompilerServices
[DefaultMember("Item")]
public interface ITuple // TypeDefIndex: 4030
{
	// Properties
	public abstract int Length { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Length();
}

// Namespace: System.Runtime.CompilerServices
[Usage(364, Inherited = False)]
internal sealed class IntrinsicAttribute : Attribute // TypeDefIndex: 4031
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(8)]
public sealed class IsByRefLikeAttribute : Attribute // TypeDefIndex: 4032
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(32767, Inherited = False)]
public sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 4033
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
public static class IsVolatile // TypeDefIndex: 4034
{}

// Namespace: System.Runtime.CompilerServices
[Usage(64, Inherited = False, AllowMultiple = False)]
[Serializable]
public sealed class IteratorStateMachineAttribute : StateMachineAttribute // TypeDefIndex: 4035
{
	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(Type stateMachineType) { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(1, Inherited = False, AllowMultiple = False)]
[Serializable]
public sealed class RuntimeCompatibilityAttribute : Attribute // TypeDefIndex: 4036
{
	// Fields
	[CompilerGenerated]
	private bool <WrapNonExceptionThrows>k__BackingField; // 0x10

	// Properties
	public bool WrapNonExceptionThrows { set; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_WrapNonExceptionThrows(bool value) { }
}

// Namespace: System.Runtime.CompilerServices
public static class RuntimeFeature // TypeDefIndex: 4037
{
	// Properties
	public static bool IsDynamicCodeSupported { get; }

	// Methods

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	public static bool get_IsDynamicCodeSupported() { }
}

// Namespace: System.Runtime.CompilerServices
[Serializable]
public sealed class RuntimeWrappedException : Exception // TypeDefIndex: 4038
{
	// Fields
	private object _wrappedException; // 0x90

	// Properties
	public object WrappedException { get; }

	// Methods

	// RVA: 0x168CE20 Offset: 0x168C020 VA: 0x18168CE20
	public void .ctor(object thrownObject) { }

	// RVA: 0x168CD30 Offset: 0x168BF30 VA: 0x18168CD30
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x168CC30 Offset: 0x168BE30 VA: 0x18168CC30 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	public object get_WrappedException() { }

	// RVA: 0x168CD00 Offset: 0x168BF00 VA: 0x18168CD00
	internal void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(64, Inherited = False, AllowMultiple = False)]
[Serializable]
public class StateMachineAttribute : Attribute // TypeDefIndex: 4039
{
	// Fields
	[CompilerGenerated]
	private readonly Type <StateMachineType>k__BackingField; // 0x10

	// Properties
	public Type StateMachineType { get; }

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(Type stateMachineType) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Type get_StateMachineType() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(1, Inherited = False)]
[Serializable]
public sealed class StringFreezingAttribute : Attribute // TypeDefIndex: 4040
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(3)]
public sealed class SuppressIldasmAttribute : Attribute // TypeDefIndex: 4041
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CLSCompliant(False)]
[Usage(11148)]
public sealed class TupleElementNamesAttribute : Attribute // TypeDefIndex: 4042
{
	// Fields
	private readonly string[] _transformNames; // 0x10

	// Methods

	// RVA: 0x168E6F0 Offset: 0x168D8F0 VA: 0x18168E6F0
	public void .ctor(string[] transformNames) { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(5148, Inherited = False, AllowMultiple = False)]
public sealed class TypeForwardedFromAttribute : Attribute // TypeDefIndex: 4043
{
	// Fields
	[CompilerGenerated]
	private readonly string <AssemblyFullName>k__BackingField; // 0x10

	// Properties
	public string AssemblyFullName { get; }

	// Methods

	// RVA: 0x168E7F0 Offset: 0x168D9F0 VA: 0x18168E7F0
	public void .ctor(string assemblyFullName) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_AssemblyFullName() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(8)]
[Serializable]
public sealed class UnsafeValueTypeAttribute : Attribute // TypeDefIndex: 4044
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ValueTaskAwaiter.<>c // TypeDefIndex: 4045
{
	// Fields
	public static readonly ValueTaskAwaiter.<>c <>9; // 0x0

	// Methods

	// RVA: 0x168EEC0 Offset: 0x168E0C0 VA: 0x18168EEC0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x168EC20 Offset: 0x168DE20 VA: 0x18168EC20
	internal void <.cctor>b__9_0(object state) { }
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct ValueTaskAwaiter : ICriticalNotifyCompletion // TypeDefIndex: 4046
{
	// Fields
	internal static readonly Action<object> s_invokeActionDelegate; // 0x0
	private readonly ValueTask _value; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x4354B0 Offset: 0x4346B0 VA: 0x1804354B0
	internal void .ctor(ValueTask value) { }

	// RVA: 0x168F720 Offset: 0x168E920 VA: 0x18168F720
	public bool get_IsCompleted() { }

	[StackTraceHidden]
	// RVA: 0x168F3E0 Offset: 0x168E5E0 VA: 0x18168F3E0
	public void GetResult() { }

	// RVA: 0x168F430 Offset: 0x168E630 VA: 0x18168F430 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	// RVA: 0x168F660 Offset: 0x168E860 VA: 0x18168F660
	private static void .cctor() { }
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct ValueTaskAwaiter<TResult> : ICriticalNotifyCompletion // TypeDefIndex: 4047
{
	// Fields
	private readonly ValueTask<TResult> _value; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ValueTask<TResult> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4354B0 Offset: 0x4346B0 VA: 0x1804354B0
	|-ValueTaskAwaiter<int>..ctor
	|
	|-RVA: 0x4BBD50 Offset: 0x4BAF50 VA: 0x1804BBD50
	|-ValueTaskAwaiter<object>..ctor
	|-ValueTaskAwaiter<ValueWebSocketReceiveResult>..ctor
	|
	|-RVA: 0xD14BC0 Offset: 0xD13DC0 VA: 0x180D14BC0
	|-ValueTaskAwaiter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD14D80 Offset: 0xD13F80 VA: 0x180D14D80
	|-ValueTaskAwaiter<int>.get_IsCompleted
	|
	|-RVA: 0xD14C90 Offset: 0xD13E90 VA: 0x180D14C90
	|-ValueTaskAwaiter<object>.get_IsCompleted
	|-ValueTaskAwaiter<ValueWebSocketReceiveResult>.get_IsCompleted
	|
	|-RVA: 0xD14CD0 Offset: 0xD13ED0 VA: 0x180D14CD0
	|-ValueTaskAwaiter<__Il2CppFullySharedGenericType>.get_IsCompleted
	*/

	[StackTraceHidden]
	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD04350 Offset: 0xD03550 VA: 0x180D04350
	|-ValueTaskAwaiter<int>.GetResult
	|
	|-RVA: 0xD13DD0 Offset: 0xD12FD0 VA: 0x180D13DD0
	|-ValueTaskAwaiter<object>.GetResult
	|-ValueTaskAwaiter<ValueWebSocketReceiveResult>.GetResult
	|
	|-RVA: 0xD13E10 Offset: 0xD13010 VA: 0x180D13E10
	|-ValueTaskAwaiter<__Il2CppFullySharedGenericType>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD14140 Offset: 0xD13340 VA: 0x180D14140
	|-ValueTaskAwaiter<int>.UnsafeOnCompleted
	|
	|-RVA: 0xD14350 Offset: 0xD13550 VA: 0x180D14350
	|-ValueTaskAwaiter<object>.UnsafeOnCompleted
	|
	|-RVA: 0xD13F30 Offset: 0xD13130 VA: 0x180D13F30
	|-ValueTaskAwaiter<ValueWebSocketReceiveResult>.UnsafeOnCompleted
	|
	|-RVA: 0xD14560 Offset: 0xD13760 VA: 0x180D14560
	|-ValueTaskAwaiter<__Il2CppFullySharedGenericType>.UnsafeOnCompleted
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class TaskAwaiter.<>c__DisplayClass11_0 // TypeDefIndex: 4048
{
	// Fields
	public Task task; // 0x10
	public Action continuation; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x168EC90 Offset: 0x168DE90 VA: 0x18168EC90
	internal void <OutputWaitEtwEvents>b__0() { }
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct TaskAwaiter : ICriticalNotifyCompletion // TypeDefIndex: 4049
{
	// Fields
	internal readonly Task m_task; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(Task task) { }

	// RVA: 0xC4C990 Offset: 0xC4BB90 VA: 0x180C4C990
	public bool get_IsCompleted() { }

	// RVA: 0x168E5F0 Offset: 0x168D7F0 VA: 0x18168E5F0 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	[StackTraceHidden]
	// RVA: 0x1676A30 Offset: 0x1675C30 VA: 0x181676A30
	public void GetResult() { }

	[StackTraceHidden]
	// RVA: 0x168E6A0 Offset: 0x168D8A0 VA: 0x18168E6A0
	internal static void ValidateEnd(Task task) { }

	[StackTraceHidden]
	// RVA: 0x168E070 Offset: 0x168D270 VA: 0x18168E070
	private static void HandleNonSuccessAndDebuggerNotification(Task task) { }

	[StackTraceHidden]
	// RVA: 0x168E490 Offset: 0x168D690 VA: 0x18168E490
	private static void ThrowForNonSuccess(Task task) { }

	// RVA: 0x168E200 Offset: 0x168D400 VA: 0x18168E200
	internal static void OnCompletedInternal(Task task, Action continuation, bool continueOnCapturedContext, bool flowExecutionContext) { }

	// RVA: 0x168E2D0 Offset: 0x168D4D0 VA: 0x18168E2D0
	private static Action OutputWaitEtwEvents(Task task, Action continuation) { }
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct TaskAwaiter<TResult> : ICriticalNotifyCompletion // TypeDefIndex: 4050
{
	// Fields
	private readonly Task<TResult> m_task; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<TResult> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	|-TaskAwaiter<ArraySegment<byte>>..ctor
	|-TaskAwaiter<Nullable<int>>..ctor
	|-TaskAwaiter<Nullable<JsonElement>>..ctor
	|-TaskAwaiter<ValueTuple<bool, object>>..ctor
	|-TaskAwaiter<ValueTuple<object, object, int>>..ctor
	|-TaskAwaiter<ValueTuple<object, bool, bool, object, object>>..ctor
	|-TaskAwaiter<bool>..ctor
	|-TaskAwaiter<int>..ctor
	|-TaskAwaiter<Int32Enum>..ctor
	|-TaskAwaiter<long>..ctor
	|-TaskAwaiter<JsonElement>..ctor
	|-TaskAwaiter<object>..ctor
	|-TaskAwaiter<SceneInstance>..ctor
	|-TaskAwaiter<SerializableProjectConfiguration>..ctor
	|-TaskAwaiter<SocketReceiveFromResult>..ctor
	|-TaskAwaiter<SocketReceiveMessageFromResult>..ctor
	|-TaskAwaiter<UdpReceiveResult>..ctor
	|-TaskAwaiter<ValueWebSocketReceiveResult>..ctor
	|-TaskAwaiter<VoidTaskResult>..ctor
	|-TaskAwaiter<WaitForChangedResult>..ctor
	|-TaskAwaiter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4C990 Offset: 0xC4BB90 VA: 0x180C4C990
	|-TaskAwaiter<ArraySegment<byte>>.get_IsCompleted
	|-TaskAwaiter<Nullable<int>>.get_IsCompleted
	|-TaskAwaiter<Nullable<JsonElement>>.get_IsCompleted
	|-TaskAwaiter<ValueTuple<bool, object>>.get_IsCompleted
	|-TaskAwaiter<ValueTuple<object, object, int>>.get_IsCompleted
	|-TaskAwaiter<ValueTuple<object, bool, bool, object, object>>.get_IsCompleted
	|-TaskAwaiter<bool>.get_IsCompleted
	|-TaskAwaiter<int>.get_IsCompleted
	|-TaskAwaiter<Int32Enum>.get_IsCompleted
	|-TaskAwaiter<long>.get_IsCompleted
	|-TaskAwaiter<JsonElement>.get_IsCompleted
	|-TaskAwaiter<object>.get_IsCompleted
	|-TaskAwaiter<SceneInstance>.get_IsCompleted
	|-TaskAwaiter<SerializableProjectConfiguration>.get_IsCompleted
	|-TaskAwaiter<SocketReceiveFromResult>.get_IsCompleted
	|-TaskAwaiter<SocketReceiveMessageFromResult>.get_IsCompleted
	|-TaskAwaiter<UdpReceiveResult>.get_IsCompleted
	|-TaskAwaiter<ValueWebSocketReceiveResult>.get_IsCompleted
	|-TaskAwaiter<VoidTaskResult>.get_IsCompleted
	|-TaskAwaiter<WaitForChangedResult>.get_IsCompleted
	|-TaskAwaiter<__Il2CppFullySharedGenericType>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4C970 Offset: 0xC4BB70 VA: 0x180C4C970
	|-TaskAwaiter<ArraySegment<byte>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<int>>.UnsafeOnCompleted
	|-TaskAwaiter<Nullable<JsonElement>>.UnsafeOnCompleted
	|-TaskAwaiter<ValueTuple<bool, object>>.UnsafeOnCompleted
	|-TaskAwaiter<ValueTuple<object, object, int>>.UnsafeOnCompleted
	|-TaskAwaiter<ValueTuple<object, bool, bool, object, object>>.UnsafeOnCompleted
	|-TaskAwaiter<bool>.UnsafeOnCompleted
	|-TaskAwaiter<int>.UnsafeOnCompleted
	|-TaskAwaiter<Int32Enum>.UnsafeOnCompleted
	|-TaskAwaiter<long>.UnsafeOnCompleted
	|-TaskAwaiter<JsonElement>.UnsafeOnCompleted
	|-TaskAwaiter<object>.UnsafeOnCompleted
	|-TaskAwaiter<SceneInstance>.UnsafeOnCompleted
	|-TaskAwaiter<SerializableProjectConfiguration>.UnsafeOnCompleted
	|-TaskAwaiter<SocketReceiveFromResult>.UnsafeOnCompleted
	|-TaskAwaiter<SocketReceiveMessageFromResult>.UnsafeOnCompleted
	|-TaskAwaiter<UdpReceiveResult>.UnsafeOnCompleted
	|-TaskAwaiter<ValueWebSocketReceiveResult>.UnsafeOnCompleted
	|-TaskAwaiter<VoidTaskResult>.UnsafeOnCompleted
	|-TaskAwaiter<WaitForChangedResult>.UnsafeOnCompleted
	|-TaskAwaiter<__Il2CppFullySharedGenericType>.UnsafeOnCompleted
	*/

	[StackTraceHidden]
	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4C630 Offset: 0xC4B830 VA: 0x180C4C630
	|-TaskAwaiter<ArraySegment<byte>>.GetResult
	|-TaskAwaiter<ValueTuple<bool, object>>.GetResult
	|-TaskAwaiter<JsonElement>.GetResult
	|-TaskAwaiter<SceneInstance>.GetResult
	|-TaskAwaiter<SerializableProjectConfiguration>.GetResult
	|-TaskAwaiter<SocketReceiveFromResult>.GetResult
	|-TaskAwaiter<UdpReceiveResult>.GetResult
	|
	|-RVA: 0xC4C770 Offset: 0xC4B970 VA: 0x180C4C770
	|-TaskAwaiter<Nullable<int>>.GetResult
	|-TaskAwaiter<long>.GetResult
	|-TaskAwaiter<object>.GetResult
	|-TaskAwaiter<ValueWebSocketReceiveResult>.GetResult
	|
	|-RVA: 0xC4C700 Offset: 0xC4B900 VA: 0x180C4C700
	|-TaskAwaiter<Nullable<JsonElement>>.GetResult
	|-TaskAwaiter<ValueTuple<object, object, int>>.GetResult
	|
	|-RVA: 0xC4C690 Offset: 0xC4B890 VA: 0x180C4C690
	|-TaskAwaiter<ValueTuple<object, bool, bool, object, object>>.GetResult
	|-TaskAwaiter<SocketReceiveMessageFromResult>.GetResult
	|-TaskAwaiter<WaitForChangedResult>.GetResult
	|
	|-RVA: 0xC4C920 Offset: 0xC4BB20 VA: 0x180C4C920
	|-TaskAwaiter<bool>.GetResult
	|-TaskAwaiter<VoidTaskResult>.GetResult
	|
	|-RVA: 0xC4C7C0 Offset: 0xC4B9C0 VA: 0x180C4C7C0
	|-TaskAwaiter<int>.GetResult
	|-TaskAwaiter<Int32Enum>.GetResult
	|
	|-RVA: 0xC4C810 Offset: 0xC4BA10 VA: 0x180C4C810
	|-TaskAwaiter<__Il2CppFullySharedGenericType>.GetResult
	*/
}

// Namespace: 
[IsReadOnly]
public struct ConfiguredTaskAwaitable.ConfiguredTaskAwaiter : ICriticalNotifyCompletion // TypeDefIndex: 4051
{
	// Fields
	internal readonly Task m_task; // 0x0
	internal readonly bool m_continueOnCapturedContext; // 0x8

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0xD3BB10 Offset: 0xD3AD10 VA: 0x180D3BB10
	internal void .ctor(Task task, bool continueOnCapturedContext) { }

	// RVA: 0xC4C990 Offset: 0xC4BB90 VA: 0x180C4C990
	public bool get_IsCompleted() { }

	// RVA: 0x1676A80 Offset: 0x1675C80 VA: 0x181676A80 Slot: 5
	public void OnCompleted(Action continuation) { }

	// RVA: 0x1676B40 Offset: 0x1675D40 VA: 0x181676B40 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	[StackTraceHidden]
	// RVA: 0x1676A30 Offset: 0x1675C30 VA: 0x181676A30
	public void GetResult() { }
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct ConfiguredTaskAwaitable // TypeDefIndex: 4052
{
	// Fields
	private readonly ConfiguredTaskAwaitable.ConfiguredTaskAwaiter m_configuredTaskAwaiter; // 0x0

	// Methods

	// RVA: 0x1676A10 Offset: 0x1675C10 VA: 0x181676A10
	internal void .ctor(Task task, bool continueOnCapturedContext) { }

	// RVA: 0x4354A0 Offset: 0x4346A0 VA: 0x1804354A0
	public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter() { }
}

// Namespace: 
[IsReadOnly]
public struct ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> : ICriticalNotifyCompletion // TypeDefIndex: 4053
{
	// Fields
	private readonly Task<TResult> m_task; // 0x0
	private readonly bool m_continueOnCapturedContext; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<TResult> task, bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3BB10 Offset: 0xD3AD10 VA: 0x180D3BB10
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ArraySegment<byte>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<JsonElement>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<bool, object>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Int32Enum>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<long>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<JsonElement>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SceneInstance>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SerializableProjectConfiguration>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SocketReceiveFromResult>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SocketReceiveMessageFromResult>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<UdpReceiveResult>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueWebSocketReceiveResult>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WaitForChangedResult>..ctor
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4C990 Offset: 0xC4BB90 VA: 0x180C4C990
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ArraySegment<byte>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<JsonElement>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<bool, object>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Int32Enum>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<long>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<JsonElement>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SceneInstance>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SerializableProjectConfiguration>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SocketReceiveFromResult>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SocketReceiveMessageFromResult>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<UdpReceiveResult>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueWebSocketReceiveResult>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WaitForChangedResult>.get_IsCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<__Il2CppFullySharedGenericType>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB7100 Offset: 0xFB6300 VA: 0x180FB7100
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ArraySegment<byte>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<JsonElement>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<bool, object>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Int32Enum>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<long>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<JsonElement>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SceneInstance>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SerializableProjectConfiguration>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SocketReceiveFromResult>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SocketReceiveMessageFromResult>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<UdpReceiveResult>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueWebSocketReceiveResult>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WaitForChangedResult>.UnsafeOnCompleted
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<__Il2CppFullySharedGenericType>.UnsafeOnCompleted
	*/

	[StackTraceHidden]
	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4C630 Offset: 0xC4B830 VA: 0x180C4C630
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ArraySegment<byte>>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<bool, object>>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<JsonElement>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SceneInstance>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SerializableProjectConfiguration>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SocketReceiveFromResult>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<UdpReceiveResult>.GetResult
	|
	|-RVA: 0xC4C770 Offset: 0xC4B970 VA: 0x180C4C770
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<long>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueWebSocketReceiveResult>.GetResult
	|
	|-RVA: 0xC4C700 Offset: 0xC4B900 VA: 0x180C4C700
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<JsonElement>>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>.GetResult
	|
	|-RVA: 0xC4C690 Offset: 0xC4B890 VA: 0x180C4C690
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<SocketReceiveMessageFromResult>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WaitForChangedResult>.GetResult
	|
	|-RVA: 0xC4C920 Offset: 0xC4BB20 VA: 0x180C4C920
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.GetResult
	|
	|-RVA: 0xC4C7C0 Offset: 0xC4B9C0 VA: 0x180C4C7C0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.GetResult
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Int32Enum>.GetResult
	|
	|-RVA: 0xC4C810 Offset: 0xC4BA10 VA: 0x180C4C810
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<__Il2CppFullySharedGenericType>.GetResult
	*/
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct ConfiguredTaskAwaitable<TResult> // TypeDefIndex: 4054
{
	// Fields
	private readonly ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> m_configuredTaskAwaiter; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<TResult> task, bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB70A0 Offset: 0xFB62A0 VA: 0x180FB70A0
	|-ConfiguredTaskAwaitable<ArraySegment<byte>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<int>>..ctor
	|-ConfiguredTaskAwaitable<Nullable<JsonElement>>..ctor
	|-ConfiguredTaskAwaitable<ValueTuple<bool, object>>..ctor
	|-ConfiguredTaskAwaitable<ValueTuple<object, object, int>>..ctor
	|-ConfiguredTaskAwaitable<ValueTuple<object, bool, bool, object, object>>..ctor
	|-ConfiguredTaskAwaitable<bool>..ctor
	|-ConfiguredTaskAwaitable<int>..ctor
	|-ConfiguredTaskAwaitable<Int32Enum>..ctor
	|-ConfiguredTaskAwaitable<long>..ctor
	|-ConfiguredTaskAwaitable<JsonElement>..ctor
	|-ConfiguredTaskAwaitable<object>..ctor
	|-ConfiguredTaskAwaitable<SceneInstance>..ctor
	|-ConfiguredTaskAwaitable<SerializableProjectConfiguration>..ctor
	|-ConfiguredTaskAwaitable<SocketReceiveFromResult>..ctor
	|-ConfiguredTaskAwaitable<SocketReceiveMessageFromResult>..ctor
	|-ConfiguredTaskAwaitable<UdpReceiveResult>..ctor
	|-ConfiguredTaskAwaitable<ValueWebSocketReceiveResult>..ctor
	|-ConfiguredTaskAwaitable<VoidTaskResult>..ctor
	|-ConfiguredTaskAwaitable<WaitForChangedResult>..ctor
	|-ConfiguredTaskAwaitable<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4354A0 Offset: 0x4346A0 VA: 0x1804354A0
	|-ConfiguredTaskAwaitable<ArraySegment<byte>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<int>>.GetAwaiter
	|-ConfiguredTaskAwaitable<Nullable<JsonElement>>.GetAwaiter
	|-ConfiguredTaskAwaitable<ValueTuple<bool, object>>.GetAwaiter
	|-ConfiguredTaskAwaitable<ValueTuple<object, object, int>>.GetAwaiter
	|-ConfiguredTaskAwaitable<ValueTuple<object, bool, bool, object, object>>.GetAwaiter
	|-ConfiguredTaskAwaitable<bool>.GetAwaiter
	|-ConfiguredTaskAwaitable<int>.GetAwaiter
	|-ConfiguredTaskAwaitable<Int32Enum>.GetAwaiter
	|-ConfiguredTaskAwaitable<long>.GetAwaiter
	|-ConfiguredTaskAwaitable<JsonElement>.GetAwaiter
	|-ConfiguredTaskAwaitable<object>.GetAwaiter
	|-ConfiguredTaskAwaitable<SceneInstance>.GetAwaiter
	|-ConfiguredTaskAwaitable<SerializableProjectConfiguration>.GetAwaiter
	|-ConfiguredTaskAwaitable<SocketReceiveFromResult>.GetAwaiter
	|-ConfiguredTaskAwaitable<SocketReceiveMessageFromResult>.GetAwaiter
	|-ConfiguredTaskAwaitable<UdpReceiveResult>.GetAwaiter
	|-ConfiguredTaskAwaitable<ValueWebSocketReceiveResult>.GetAwaiter
	|-ConfiguredTaskAwaitable<VoidTaskResult>.GetAwaiter
	|-ConfiguredTaskAwaitable<WaitForChangedResult>.GetAwaiter
	|-ConfiguredTaskAwaitable<__Il2CppFullySharedGenericType>.GetAwaiter
	*/
}

// Namespace: System.Runtime.CompilerServices
[Usage(5148, Inherited = False, AllowMultiple = False)]
internal class ReflectionBlockedAttribute : Attribute // TypeDefIndex: 4055
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
public struct AsyncVoidMethodBuilder // TypeDefIndex: 4056
{
	// Fields
	private SynchronizationContext m_synchronizationContext; // 0x0
	private AsyncMethodBuilderCore m_coreState; // 0x8
	private Task m_task; // 0x18

	// Properties
	internal Task Task { get; }

	// Methods

	// RVA: 0x16763C0 Offset: 0x16755C0 VA: 0x1816763C0
	public static AsyncVoidMethodBuilder Create() { }

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8DCF90 Offset: 0x8DC190 VA: 0x1808DCF90
	|-AsyncVoidMethodBuilder.Start<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x943C40 Offset: 0x942E40 VA: 0x180943C40
	|-AsyncVoidMethodBuilder.Start<FtpWebRequest.<CreateConnectionAsync>d__86>
	|
	|-RVA: 0x943E80 Offset: 0x943080 VA: 0x180943E80
	|-AsyncVoidMethodBuilder.Start<TwitchManager.<LaunchImplicitAuthAsync>d__17>
	|
	|-RVA: 0x943DC0 Offset: 0x942FC0 VA: 0x180943DC0
	|-AsyncVoidMethodBuilder.Start<UnityServicesInitializer.<EnableServicesInitializationAsync>d__1>
	|
	|-RVA: 0x943D00 Offset: 0x942F00 VA: 0x180943D00
	|-AsyncVoidMethodBuilder.Start<WebClient.<DownloadBitsAsync>d__150>
	|
	|-RVA: 0x944000 Offset: 0x943200 VA: 0x180944000
	|-AsyncVoidMethodBuilder.Start<WebClient.<UploadBitsAsync>d__152>
	|
	|-RVA: 0x943F40 Offset: 0x943140 VA: 0x180943F40
	|-AsyncVoidMethodBuilder.Start<WebOperation.<Run>d__58>
	*/

	// RVA: 0x1676640 Offset: 0x1675840 VA: 0x181676640
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x941D00 Offset: 0x940F00 VA: 0x180941D00
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebClient.<DownloadBitsAsync>d__150>
	|
	|-RVA: 0x9421C0 Offset: 0x9413C0 VA: 0x1809421C0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebClient.<UploadBitsAsync>d__152>
	|
	|-RVA: 0x941F80 Offset: 0x941180 VA: 0x180941F80
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebOperation.<Run>d__58>
	|
	|-RVA: 0x942E20 Offset: 0x942020 VA: 0x180942E20
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, WebClient.<DownloadBitsAsync>d__150>
	|
	|-RVA: 0x9430A0 Offset: 0x9422A0 VA: 0x1809430A0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, WebClient.<UploadBitsAsync>d__152>
	|
	|-RVA: 0x943630 Offset: 0x942830 VA: 0x180943630
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<Int32Enum>, TwitchManager.<LaunchImplicitAuthAsync>d__17>
	|
	|-RVA: 0x943A30 Offset: 0x942C30 VA: 0x180943A30
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, TwitchManager.<LaunchImplicitAuthAsync>d__17>
	|
	|-RVA: 0x943840 Offset: 0x942A40 VA: 0x180943840
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, UnityServicesInitializer.<EnableServicesInitializationAsync>d__1>
	|
	|-RVA: 0x943360 Offset: 0x942560 VA: 0x180943360
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	|
	|-RVA: 0x942480 Offset: 0x941680 VA: 0x180942480
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, FtpWebRequest.<CreateConnectionAsync>d__86>
	|
	|-RVA: 0x9426A0 Offset: 0x9418A0 VA: 0x1809426A0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebOperation.<Run>d__58>
	|
	|-RVA: 0x9428E0 Offset: 0x941AE0 VA: 0x1809428E0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, WebClient.<DownloadBitsAsync>d__150>
	|
	|-RVA: 0x942B60 Offset: 0x941D60 VA: 0x180942B60
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, WebClient.<UploadBitsAsync>d__152>
	*/

	// RVA: 0x1676590 Offset: 0x1675790 VA: 0x181676590
	public void SetResult() { }

	// RVA: 0x1676470 Offset: 0x1675670 VA: 0x181676470
	public void SetException(Exception exception) { }

	// RVA: 0x1676420 Offset: 0x1675620 VA: 0x181676420
	private void NotifySynchronizationContextOfCompletion() { }

	// RVA: 0x1676710 Offset: 0x1675910 VA: 0x181676710
	internal Task get_Task() { }
}

// Namespace: System.Runtime.CompilerServices
public struct AsyncTaskMethodBuilder // TypeDefIndex: 4057
{
	// Fields
	private static readonly Task<VoidTaskResult> s_cachedCompleted; // 0x0
	private AsyncTaskMethodBuilder<VoidTaskResult> m_builder; // 0x0

	// Properties
	public Task Task { get; }

	// Methods

	// RVA: 0x9E9000 Offset: 0x9E8200 VA: 0x1809E9000
	public static AsyncTaskMethodBuilder Create() { }

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8DCF90 Offset: 0x8DC190 VA: 0x1808DCF90
	|-AsyncTaskMethodBuilder.Start<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x940920 Offset: 0x93FB20 VA: 0x180940920
	|-AsyncTaskMethodBuilder.Start<AsyncJsonSerializable.<SerializeAsync>d__5>
	|
	|-RVA: 0x93FF60 Offset: 0x93F160 VA: 0x18093FF60
	|-AsyncTaskMethodBuilder.Start<AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x93EA60 Offset: 0x93DC60 VA: 0x18093EA60
	|-AsyncTaskMethodBuilder.Start<BackgroundWorker.<DoFlushAsync>d__22>
	|
	|-RVA: 0x93EB20 Offset: 0x93DD20 VA: 0x18093EB20
	|-AsyncTaskMethodBuilder.Start<BackgroundWorker.<DoWorkAsync>d__20>
	|
	|-RVA: 0x93F120 Offset: 0x93E320 VA: 0x18093F120
	|-AsyncTaskMethodBuilder.Start<BackgroundWorker.<FlushAsync>d__21>
	|
	|-RVA: 0x9404A0 Offset: 0x93F6A0 VA: 0x1809404A0
	|-AsyncTaskMethodBuilder.Start<BackgroundWorker.<SendFinalClientReportAsync>d__23>
	|
	|-RVA: 0x93E2E0 Offset: 0x93D4E0 VA: 0x18093E2E0
	|-AsyncTaskMethodBuilder.Start<CachingTransport.<CachedTransportBackgroundTaskAsync>d__20>
	|
	|-RVA: 0x93E8E0 Offset: 0x93DAE0 VA: 0x18093E8E0
	|-AsyncTaskMethodBuilder.Start<CachingTransport.<DisposeAsync>d__33>
	|
	|-RVA: 0x93FBA0 Offset: 0x93EDA0 VA: 0x18093FBA0
	|-AsyncTaskMethodBuilder.Start<CachingTransport.<InnerProcessCacheAsync>d__25>
	|
	|-RVA: 0x93FEA0 Offset: 0x93F0A0 VA: 0x18093FEA0
	|-AsyncTaskMethodBuilder.Start<CachingTransport.<ProcessCacheAsync>d__24>
	|
	|-RVA: 0x940320 Offset: 0x93F520 VA: 0x180940320
	|-AsyncTaskMethodBuilder.Start<CachingTransport.<SendEnvelopeAsync>d__30>
	|
	|-RVA: 0x940E60 Offset: 0x940060 VA: 0x180940E60
	|-AsyncTaskMethodBuilder.Start<CachingTransport.<StoreToCacheAsync>d__28>
	|
	|-RVA: 0x93E5E0 Offset: 0x93D7E0 VA: 0x18093E5E0
	|-AsyncTaskMethodBuilder.Start<ClientWebSocket.<ConnectAsyncCore>d__16>
	|
	|-RVA: 0x93F720 Offset: 0x93E920 VA: 0x18093F720
	|-AsyncTaskMethodBuilder.Start<CorePackageInitializer.<InitializeComponents>d__47>
	|
	|-RVA: 0x93F7E0 Offset: 0x93E9E0 VA: 0x18093F7E0
	|-AsyncTaskMethodBuilder.Start<CorePackageInitializer.<InitializeProjectConfigAsync>d__52>
	|
	|-RVA: 0x941520 Offset: 0x940720 VA: 0x180941520
	|-AsyncTaskMethodBuilder.Start<CryptoStream.<WriteAsyncCore>d__49>
	|
	|-RVA: 0x9416A0 Offset: 0x9408A0 VA: 0x1809416A0
	|-AsyncTaskMethodBuilder.Start<CryptoStream.<WriteAsyncInternal>d__46>
	|
	|-RVA: 0x9406E0 Offset: 0x93F8E0 VA: 0x1809406E0
	|-AsyncTaskMethodBuilder.Start<Envelope.<SerializeAsync>d__14>
	|
	|-RVA: 0x9409E0 Offset: 0x93FBE0 VA: 0x1809409E0
	|-AsyncTaskMethodBuilder.Start<Envelope.<SerializeHeaderAsync>d__11>
	|
	|-RVA: 0x940C20 Offset: 0x93FE20 VA: 0x180940C20
	|-AsyncTaskMethodBuilder.Start<EnvelopeHttpContent.<SerializeToStreamAsync>d__4>
	|
	|-RVA: 0x9407A0 Offset: 0x93F9A0 VA: 0x1809407A0
	|-AsyncTaskMethodBuilder.Start<EnvelopeItem.<SerializeAsync>d__26>
	|
	|-RVA: 0x940AA0 Offset: 0x93FCA0 VA: 0x180940AA0
	|-AsyncTaskMethodBuilder.Start<EnvelopeItem.<SerializeHeaderAsync>d__24>
	|
	|-RVA: 0x93FD20 Offset: 0x93EF20 VA: 0x18093FD20
	|-AsyncTaskMethodBuilder.Start<HttpContent.<LoadIntoBufferAsync>d__17>
	|
	|-RVA: 0x9403E0 Offset: 0x93F5E0 VA: 0x1809403E0
	|-AsyncTaskMethodBuilder.Start<HttpTransport.<SendEnvelopeAsync>d__3>
	|
	|-RVA: 0x93F360 Offset: 0x93E560 VA: 0x18093F360
	|-AsyncTaskMethodBuilder.Start<HttpTransportBase.<HandleFailureAsync>d__20>
	|
	|-RVA: 0x93F5A0 Offset: 0x93E7A0 VA: 0x18093F5A0
	|-AsyncTaskMethodBuilder.Start<HttpTransportBase.<HandleSuccessAsync>d__17>
	|
	|-RVA: 0x93E520 Offset: 0x93D720 VA: 0x18093E520
	|-AsyncTaskMethodBuilder.Start<Hub.<ConfigureScopeAsync>d__21>
	|
	|-RVA: 0x93F2A0 Offset: 0x93E4A0 VA: 0x18093F2A0
	|-AsyncTaskMethodBuilder.Start<Hub.<FlushAsync>d__55>
	|
	|-RVA: 0x940860 Offset: 0x93FA60 VA: 0x180940860
	|-AsyncTaskMethodBuilder.Start<JsonSerializable.<SerializeAsync>d__4>
	|
	|-RVA: 0x93E3A0 Offset: 0x93D5A0 VA: 0x18093E3A0
	|-AsyncTaskMethodBuilder.Start<ManagedWebSocket.<CloseAsyncPrivate>d__68>
	|
	|-RVA: 0x93E460 Offset: 0x93D660 VA: 0x18093E460
	|-AsyncTaskMethodBuilder.Start<ManagedWebSocket.<CloseWithReceiveErrorAndThrowAsync>d__66>
	|
	|-RVA: 0x93ECA0 Offset: 0x93DEA0 VA: 0x18093ECA0
	|-AsyncTaskMethodBuilder.Start<ManagedWebSocket.<EnsureBufferContainsAsync>d__71>
	|
	|-RVA: 0x93F420 Offset: 0x93E620 VA: 0x18093F420
	|-AsyncTaskMethodBuilder.Start<ManagedWebSocket.<HandleReceivedCloseAsync>d__62>
	|
	|-RVA: 0x93F4E0 Offset: 0x93E6E0 VA: 0x18093F4E0
	|-AsyncTaskMethodBuilder.Start<ManagedWebSocket.<HandleReceivedPingPongAsync>d__64>
	|
	|-RVA: 0x940260 Offset: 0x93F460 VA: 0x180940260
	|-AsyncTaskMethodBuilder.Start<ManagedWebSocket.<SendCloseFrameAsync>d__69>
	|
	|-RVA: 0x940560 Offset: 0x93F760 VA: 0x180940560
	|-AsyncTaskMethodBuilder.Start<ManagedWebSocket.<SendFrameFallbackAsync>d__56>
	|
	|-RVA: 0x9412E0 Offset: 0x9404E0 VA: 0x1809412E0
	|-AsyncTaskMethodBuilder.Start<ManagedWebSocket.<WaitForServerToCloseConnectionAsync>d__63>
	|
	|-RVA: 0x9413A0 Offset: 0x9405A0 VA: 0x1809413A0
	|-AsyncTaskMethodBuilder.Start<ManagedWebSocket.<WaitForWriteTaskAsync>d__55>
	|
	|-RVA: 0x93FC60 Offset: 0x93EE60 VA: 0x18093FC60
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x93FDE0 Offset: 0x93EFE0 VA: 0x18093FDE0
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<ProcessAuthentication>d__48>
	|
	|-RVA: 0x93EE20 Offset: 0x93E020 VA: 0x18093EE20
	|-AsyncTaskMethodBuilder.Start<MonoChunkStream.<FinishReading>d__8>
	|
	|-RVA: 0x941160 Offset: 0x940360 VA: 0x180941160
	|-AsyncTaskMethodBuilder.Start<PolyfillExtensions.<WaitAsync>d__77>
	|
	|-RVA: 0x941220 Offset: 0x940420 VA: 0x180941220
	|-AsyncTaskMethodBuilder.Start<PolyfillExtensions.<WaitAsync>d__78>
	|
	|-RVA: 0x941460 Offset: 0x940660 VA: 0x180941460
	|-AsyncTaskMethodBuilder.Start<SentryScopeManager.<WithScopeAsync>d__21>
	|
	|-RVA: 0x9401A0 Offset: 0x93F3A0 VA: 0x1809401A0
	|-AsyncTaskMethodBuilder.Start<ServicePointScheduler.<RunScheduler>d__32>
	|
	|-RVA: 0x93E820 Offset: 0x93DA20 VA: 0x18093E820
	|-AsyncTaskMethodBuilder.Start<Stream.<CopyToAsyncInternal>d__28>
	|
	|-RVA: 0x93EEE0 Offset: 0x93E0E0 VA: 0x18093EEE0
	|-AsyncTaskMethodBuilder.Start<Stream.<FinishWriteAsync>d__57>
	|
	|-RVA: 0x940DA0 Offset: 0x93FFA0 VA: 0x180940DA0
	|-AsyncTaskMethodBuilder.Start<StreamExtensions.<SkipNewlinesAsync>d__1>
	|
	|-RVA: 0x93F060 Offset: 0x93E260 VA: 0x18093F060
	|-AsyncTaskMethodBuilder.Start<StreamWriter.<FlushAsyncInternal>d__74>
	|
	|-RVA: 0x941760 Offset: 0x940960 VA: 0x180941760
	|-AsyncTaskMethodBuilder.Start<StreamWriter.<WriteAsyncInternal>d__62>
	|
	|-RVA: 0x93ED60 Offset: 0x93DF60 VA: 0x18093ED60
	|-AsyncTaskMethodBuilder.Start<TwitchManager.<FetchNewToken>d__18>
	|
	|-RVA: 0x93F960 Offset: 0x93EB60 VA: 0x18093F960
	|-AsyncTaskMethodBuilder.Start<Ua2CoreInitializeCallback.<Initialize>d__2>
	|
	|-RVA: 0x93EBE0 Offset: 0x93DDE0 VA: 0x18093EBE0
	|-AsyncTaskMethodBuilder.Start<UnityServicesInternal.<EnableInitializationAsync>d__25>
	|
	|-RVA: 0x93F8A0 Offset: 0x93EAA0 VA: 0x18093F8A0
	|-AsyncTaskMethodBuilder.Start<UnityServicesInternal.<InitializeServicesAsync>d__22>
	|
	|-RVA: 0x93E9A0 Offset: 0x93DBA0 VA: 0x18093E9A0
	|-AsyncTaskMethodBuilder.Start<Utf8JsonWriter.<DisposeAsync>d__35>
	|
	|-RVA: 0x93F1E0 Offset: 0x93E3E0 VA: 0x18093F1E0
	|-AsyncTaskMethodBuilder.Start<Utf8JsonWriter.<FlushAsync>d__36>
	|
	|-RVA: 0x93E760 Offset: 0x93D960 VA: 0x18093E760
	|-AsyncTaskMethodBuilder.Start<WebConnection.<Connect>d__16>
	|
	|-RVA: 0x93FAE0 Offset: 0x93ECE0 VA: 0x18093FAE0
	|-AsyncTaskMethodBuilder.Start<WebConnectionTunnel.<Initialize>d__42>
	|
	|-RVA: 0x93EFA0 Offset: 0x93E1A0 VA: 0x18093EFA0
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<FinishWriting>d__31>
	|
	|-RVA: 0x93FA20 Offset: 0x93EC20 VA: 0x18093FA20
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<Initialize>d__36>
	|
	|-RVA: 0x940020 Offset: 0x93F220 VA: 0x180940020
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<ProcessWrite>d__34>
	|
	|-RVA: 0x940CE0 Offset: 0x93FEE0 VA: 0x180940CE0
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<SetHeadersAsync>d__37>
	|
	|-RVA: 0x9415E0 Offset: 0x9407E0 VA: 0x1809415E0
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteAsyncInner>d__33>
	|
	|-RVA: 0x941820 Offset: 0x940A20 VA: 0x180941820
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteChunkTrailer>d__40>
	|
	|-RVA: 0x9418E0 Offset: 0x940AE0 VA: 0x1809418E0
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteChunkTrailer_inner>d__39>
	|
	|-RVA: 0x9419A0 Offset: 0x940BA0 VA: 0x1809419A0
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteRequestAsync>d__38>
	|
	|-RVA: 0x93F660 Offset: 0x93E860 VA: 0x18093F660
	|-AsyncTaskMethodBuilder.Start<WebResponseStream.<InitReadAsync>d__52>
	|
	|-RVA: 0x9400E0 Offset: 0x93F2E0 VA: 0x1809400E0
	|-AsyncTaskMethodBuilder.Start<WebResponseStream.<ReadAllAsync>d__48>
	|
	|-RVA: 0x940620 Offset: 0x93F820 VA: 0x180940620
	|-AsyncTaskMethodBuilder.Start<WebSocket.<SendWithArrayPoolAsync>d__16>
	|
	|-RVA: 0x93E6A0 Offset: 0x93D8A0 VA: 0x18093E6A0
	|-AsyncTaskMethodBuilder.Start<WebSocketHandle.<ConnectAsyncCore>d__26>
	|
	|-RVA: 0x940F20 Offset: 0x940120 VA: 0x180940F20
	|-AsyncTaskMethodBuilder.Start<CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__InitializePackageAsync|2>d>
	|
	|-RVA: 0x940FE0 Offset: 0x9401E0 VA: 0x180940FE0
	|-AsyncTaskMethodBuilder.Start<CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__TryInitializePackageAsync|0>d>
	|
	|-RVA: 0x940B60 Offset: 0x93FD60 VA: 0x180940B60
	|-AsyncTaskMethodBuilder.Start<GzipRequestBodyHandler.GzipContent.<SerializeToStreamAsync>d__4>
	|
	|-RVA: 0x9410A0 Offset: 0x9402A0 VA: 0x1809410A0
	|-AsyncTaskMethodBuilder.Start<UnityServicesInternal.<>c__DisplayClass22_0.<<InitializeServicesAsync>g__InitializePackagesAsync|1>d>
	*/

	// RVA: 0x1676280 Offset: 0x1675480 VA: 0x181676280
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x93CF30 Offset: 0x93C130 VA: 0x18093CF30
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>, AsyncProtocolRequest.<ProcessOperation>d__24>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, BackgroundWorker.<DoFlushAsync>d__22>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, MonoChunkStream.<FinishReading>d__8>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebRequestStream.<WriteChunkTrailer>d__40>
	|
	|-RVA: 0x93CE10 Offset: 0x93C010 VA: 0x18093CE10
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>, WebConnectionTunnel.<Initialize>d__42>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, ServicePointScheduler.<RunScheduler>d__32>
	|
	|-RVA: 0x93CBD0 Offset: 0x93BDD0 VA: 0x18093CBD0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, StreamExtensions.<SkipNewlinesAsync>d__1>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpTransportBase.<HandleSuccessAsync>d__17>
	|
	|-RVA: 0x93CCF0 Offset: 0x93BEF0 VA: 0x18093CCF0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebResponseStream.<InitReadAsync>d__52>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, CachingTransport.<ProcessCacheAsync>d__24>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<ProcessAuthentication>d__48>
	|
	|-RVA: 0x93CB40 Offset: 0x93BD40 VA: 0x18093CB40
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<JsonElement>, HttpTransportBase.<HandleFailureAsync>d__20>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpTransportBase.<HandleFailureAsync>d__20>
	|
	|-RVA: 0x93CEA0 Offset: 0x93C0A0 VA: 0x18093CEA0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, AsyncJsonSerializable.<SerializeAsync>d__5>
	|
	|-RVA: 0x93CC60 Offset: 0x93BE60 VA: 0x18093CC60
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, CachingTransport.<InnerProcessCacheAsync>d__25>
	|
	|-RVA: 0x93CD80 Offset: 0x93BF80 VA: 0x18093CD80
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, CachingTransport.<StoreToCacheAsync>d__28>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, EnvelopeItem.<SerializeAsync>d__26>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpTransport.<SendEnvelopeAsync>d__3>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebResponseStream.<ReadAllAsync>d__48>
	|
	|-RVA: 0x93CAB0 Offset: 0x93BCB0 VA: 0x18093CAB0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebSocketHandle.<ConnectAsyncCore>d__26>
	|
	|-RVA: 0x93D8C0 Offset: 0x93CAC0 VA: 0x18093D8C0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, ManagedWebSocket.<EnsureBufferContainsAsync>d__71>
	|
	|-RVA: 0x93D950 Offset: 0x93CB50 VA: 0x18093D950
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, ManagedWebSocket.<WaitForServerToCloseConnectionAsync>d__63>
	|
	|-RVA: 0x93D830 Offset: 0x93CA30 VA: 0x18093D830
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, Stream.<CopyToAsyncInternal>d__28>
	|
	|-RVA: 0x93DC20 Offset: 0x93CE20 VA: 0x18093DC20
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, CorePackageInitializer.<InitializeProjectConfigAsync>d__52>
	|
	|-RVA: 0x93DD40 Offset: 0x93CF40 VA: 0x18093DD40
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, PolyfillExtensions.<WaitAsync>d__78>
	|
	|-RVA: 0x93DCB0 Offset: 0x93CEB0 VA: 0x18093DCB0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<object>, UnityServicesInternal.<>c__DisplayClass22_0.<<InitializeServicesAsync>g__InitializePackagesAsync|1>d>
	|
	|-RVA: 0x93DB00 Offset: 0x93CD00 VA: 0x18093DB00
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ForceAsyncAwaiter, CryptoStream.<WriteAsyncInternal>d__46>
	|
	|-RVA: 0x93DDD0 Offset: 0x93CFD0 VA: 0x18093DDD0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, CorePackageInitializer.<InitializeComponents>d__47>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, Ua2CoreInitializeCallback.<Initialize>d__2>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, UnityServicesInternal.<EnableInitializationAsync>d__25>
	|
	|-RVA: 0x93E130 Offset: 0x93D330 VA: 0x18093E130
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, CryptoStream.<WriteAsyncInternal>d__46>
	|
	|-RVA: 0x93DF80 Offset: 0x93D180 VA: 0x18093DF80
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, PolyfillExtensions.<WaitAsync>d__77>
	|
	|-RVA: 0x93E010 Offset: 0x93D210 VA: 0x18093E010
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, PolyfillExtensions.<WaitAsync>d__78>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<WriteRequestAsync>d__38>
	|
	|-RVA: 0x93DE60 Offset: 0x93D060 VA: 0x18093DE60
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, TwitchManager.<FetchNewToken>d__18>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, UnityServicesInternal.<InitializeServicesAsync>d__22>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__InitializePackageAsync|2>d>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__TryInitializePackageAsync|0>d>
	|
	|-RVA: 0x93DEF0 Offset: 0x93D0F0 VA: 0x18093DEF0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<Initialize>d__36>
	|
	|-RVA: 0x93E0A0 Offset: 0x93D2A0 VA: 0x18093E0A0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<WriteAsyncInner>d__33>
	|
	|-RVA: 0x93E250 Offset: 0x93D450 VA: 0x18093E250
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, Envelope.<SerializeHeaderAsync>d__11>
	|
	|-RVA: 0x93E1C0 Offset: 0x93D3C0 VA: 0x18093E1C0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, CryptoStream.<WriteAsyncCore>d__49>
	|
	|-RVA: 0x93DB90 Offset: 0x93CD90 VA: 0x18093DB90
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	|
	|-RVA: 0x93D320 Offset: 0x93C520 VA: 0x18093D320
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncJsonSerializable.<SerializeAsync>d__5>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamWriter.<FlushAsyncInternal>d__74>
	|
	|-RVA: 0x93D050 Offset: 0x93C250 VA: 0x18093D050
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<ProcessOperation>d__24>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, BackgroundWorker.<DoFlushAsync>d__22>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, ManagedWebSocket.<CloseAsyncPrivate>d__68>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MonoChunkStream.<FinishReading>d__8>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<ProcessWrite>d__34>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteChunkTrailer>d__40>
	|
	|-RVA: 0x93D290 Offset: 0x93C490 VA: 0x18093D290
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, BackgroundWorker.<DoWorkAsync>d__20>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CachingTransport.<StoreToCacheAsync>d__28>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, EnvelopeItem.<SerializeAsync>d__26>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpTransport.<SendEnvelopeAsync>d__3>
	|
	|-RVA: 0x93D3B0 Offset: 0x93C5B0 VA: 0x18093D3B0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, BackgroundWorker.<FlushAsync>d__21>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CachingTransport.<InnerProcessCacheAsync>d__25>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, ManagedWebSocket.<HandleReceivedCloseAsync>d__62>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, ManagedWebSocket.<HandleReceivedPingPongAsync>d__64>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, ManagedWebSocket.<SendCloseFrameAsync>d__69>
	|
	|-RVA: 0x93CFC0 Offset: 0x93C1C0 VA: 0x18093CFC0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, BackgroundWorker.<SendFinalClientReportAsync>d__23>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CachingTransport.<CachedTransportBackgroundTaskAsync>d__20>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, ClientWebSocket.<ConnectAsyncCore>d__16>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, ManagedWebSocket.<CloseWithReceiveErrorAndThrowAsync>d__66>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MobileAuthenticatedStream.<InnerWrite>d__67>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, SentryScopeManager.<WithScopeAsync>d__21>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<Initialize>d__36>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<SetHeadersAsync>d__37>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, GzipRequestBodyHandler.GzipContent.<SerializeToStreamAsync>d__4>
	|
	|-RVA: 0x93D0E0 Offset: 0x93C2E0 VA: 0x18093D0E0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CachingTransport.<DisposeAsync>d__33>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, EnvelopeHttpContent.<SerializeToStreamAsync>d__4>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpContent.<LoadIntoBufferAsync>d__17>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Hub.<ConfigureScopeAsync>d__21>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Hub.<FlushAsync>d__55>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Stream.<FinishWriteAsync>d__57>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Utf8JsonWriter.<DisposeAsync>d__35>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Utf8JsonWriter.<FlushAsync>d__36>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<FinishWriting>d__31>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteChunkTrailer_inner>d__39>
	|
	|-RVA: 0x93D4D0 Offset: 0x93C6D0 VA: 0x18093D4D0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CachingTransport.<ProcessCacheAsync>d__24>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CachingTransport.<SendEnvelopeAsync>d__30>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteRequestAsync>d__38>
	|
	|-RVA: 0x93D200 Offset: 0x93C400 VA: 0x18093D200
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Envelope.<SerializeAsync>d__14>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<Connect>d__16>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnectionTunnel.<Initialize>d__42>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteAsyncInner>d__33>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebSocket.<SendWithArrayPoolAsync>d__16>
	|
	|-RVA: 0x93D560 Offset: 0x93C760 VA: 0x18093D560
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Envelope.<SerializeHeaderAsync>d__11>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, EnvelopeItem.<SerializeHeaderAsync>d__24>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonSerializable.<SerializeAsync>d__4>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, ManagedWebSocket.<SendFrameFallbackAsync>d__56>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamWriter.<WriteAsyncInternal>d__62>
	|
	|-RVA: 0x93D440 Offset: 0x93C640 VA: 0x18093D440
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpTransportBase.<HandleFailureAsync>d__20>
	|
	|-RVA: 0x93D170 Offset: 0x93C370 VA: 0x18093D170
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebSocketHandle.<ConnectAsyncCore>d__26>
	|
	|-RVA: 0x93DA70 Offset: 0x93CC70 VA: 0x18093DA70
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, AsyncJsonSerializable.<SerializeAsync>d__5>
	|
	|-RVA: 0x93D9E0 Offset: 0x93CBE0 VA: 0x18093D9E0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, EnvelopeItem.<SerializeHeaderAsync>d__24>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, JsonSerializable.<SerializeAsync>d__4>
	|
	|-RVA: 0x93D5F0 Offset: 0x93C7F0 VA: 0x18093D5F0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, ManagedWebSocket.<HandleReceivedPingPongAsync>d__64>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, ManagedWebSocket.<SendCloseFrameAsync>d__69>
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, Stream.<CopyToAsyncInternal>d__28>
	|
	|-RVA: 0x93D710 Offset: 0x93C910 VA: 0x18093D710
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, ManagedWebSocket.<SendFrameFallbackAsync>d__56>
	|
	|-RVA: 0x93D7A0 Offset: 0x93C9A0 VA: 0x18093D7A0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, ManagedWebSocket.<WaitForWriteTaskAsync>d__55>
	|
	|-RVA: 0x93D680 Offset: 0x93C880 VA: 0x18093D680
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, StreamWriter.<FlushAsyncInternal>d__74>
	*/

	// RVA: 0x1676360 Offset: 0x1675560 VA: 0x181676360
	public Task get_Task() { }

	// RVA: 0x16761E0 Offset: 0x16753E0 VA: 0x1816761E0
	public void SetResult() { }

	// RVA: 0x1676170 Offset: 0x1675370 VA: 0x181676170
	public void SetException(Exception exception) { }

	// RVA: 0x16762F0 Offset: 0x16754F0 VA: 0x1816762F0
	private static void .cctor() { }
}

// Namespace: System.Runtime.CompilerServices
public struct AsyncTaskMethodBuilder<TResult> // TypeDefIndex: 4058
{
	// Fields
	internal static readonly Task<TResult> s_defaultResultTask; // 0x0
	private AsyncMethodBuilderCore m_coreState; // 0x0
	private Task<TResult> m_task; // 0x0

	// Properties
	public Task<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static AsyncTaskMethodBuilder<TResult> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9E9000 Offset: 0x9E8200 VA: 0x1809E9000
	|-AsyncTaskMethodBuilder<ArraySegment<byte>>.Create
	|-AsyncTaskMethodBuilder<Nullable<int>>.Create
	|-AsyncTaskMethodBuilder<Nullable<JsonElement>>.Create
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.Create
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.Create
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.Create
	|-AsyncTaskMethodBuilder<bool>.Create
	|-AsyncTaskMethodBuilder<int>.Create
	|-AsyncTaskMethodBuilder<Int32Enum>.Create
	|-AsyncTaskMethodBuilder<JsonElement>.Create
	|-AsyncTaskMethodBuilder<object>.Create
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.Create
	|-AsyncTaskMethodBuilder<ValueWebSocketReceiveResult>.Create
	|-AsyncTaskMethodBuilder<VoidTaskResult>.Create
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.Create
	*/

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8DF9E0 Offset: 0x8DEBE0 VA: 0x1808DF9E0
	|-AsyncTaskMethodBuilder<ArraySegment<byte>>.Start<JsonDocument.<ReadToEndAsync>d__65>
	|
	|-RVA: 0x8DE660 Offset: 0x8DD860 VA: 0x1808DE660
	|-AsyncTaskMethodBuilder<Nullable<int>>.Start<AsyncProtocolRequest.<InnerRead>d__25>
	|
	|-RVA: 0x8DDB20 Offset: 0x8DCD20 VA: 0x1808DDB20
	|-AsyncTaskMethodBuilder<Nullable<JsonElement>>.Start<GraphQLContentExtractor.<ExtractResponseContentAsync>d__1>
	|
	|-RVA: 0x8E0760 Offset: 0x8DF960 VA: 0x1808E0760
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.Start<WebCompletionSource.<WaitForCompletion>d__15<ValueTuple<bool, object>>>
	|
	|-RVA: 0x8DF620 Offset: 0x8DE820 VA: 0x1808DF620
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.Start<WebConnectionTunnel.<ReadHeaders>d__43>
	|
	|-RVA: 0x8DE120 Offset: 0x8DD320 VA: 0x1808DE120
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.Start<HttpWebRequest.<GetResponseFromData>d__244>
	|
	|-RVA: 0x8E0820 Offset: 0x8DFA20 VA: 0x1808E0820
	|-AsyncTaskMethodBuilder<bool>.Start<SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32>
	|
	|-RVA: 0x8E05E0 Offset: 0x8DF7E0 VA: 0x1808E05E0
	|-AsyncTaskMethodBuilder<bool>.Start<ServicePointScheduler.<WaitAsync>d__46>
	|
	|-RVA: 0x8DD520 Offset: 0x8DC720 VA: 0x1808DD520
	|-AsyncTaskMethodBuilder<bool>.Start<WebConnection.<CreateStream>d__18>
	|
	|-RVA: 0x8DFCE0 Offset: 0x8DEEE0 VA: 0x1808DFCE0
	|-AsyncTaskMethodBuilder<int>.Start<HttpWebRequest.<RunWithTimeoutWorker>d__241<int>>
	|
	|-RVA: 0x8DEA20 Offset: 0x8DDC20 VA: 0x1808DEA20
	|-AsyncTaskMethodBuilder<int>.Start<BufferedReadStream.<ProcessReadAsync>d__2>
	|
	|-RVA: 0x8DF020 Offset: 0x8DE220 VA: 0x1808DF020
	|-AsyncTaskMethodBuilder<int>.Start<CryptoStream.<ReadAsyncCore>d__42>
	|
	|-RVA: 0x8DF0E0 Offset: 0x8DE2E0 VA: 0x1808DF0E0
	|-AsyncTaskMethodBuilder<int>.Start<CryptoStream.<ReadAsyncInternal>d__37>
	|
	|-RVA: 0x8DEAE0 Offset: 0x8DDCE0 VA: 0x1808DEAE0
	|-AsyncTaskMethodBuilder<int>.Start<FixedSizeReadStream.<ProcessReadAsync>d__5>
	|
	|-RVA: 0x8DE720 Offset: 0x8DD920 VA: 0x1808DE720
	|-AsyncTaskMethodBuilder<int>.Start<MobileAuthenticatedStream.<InnerRead>d__66>
	|
	|-RVA: 0x8E02E0 Offset: 0x8DF4E0 VA: 0x1808E02E0
	|-AsyncTaskMethodBuilder<int>.Start<MobileAuthenticatedStream.<StartOperation>d__57>
	|
	|-RVA: 0x8DEBA0 Offset: 0x8DDDA0 VA: 0x1808DEBA0
	|-AsyncTaskMethodBuilder<int>.Start<MonoChunkStream.<ProcessReadAsync>d__7>
	|
	|-RVA: 0x8DF260 Offset: 0x8DE460 VA: 0x1808DF260
	|-AsyncTaskMethodBuilder<int>.Start<PartialStream.<ReadAsync>d__16>
	|
	|-RVA: 0x8E0520 Offset: 0x8DF720 VA: 0x1808E0520
	|-AsyncTaskMethodBuilder<int>.Start<Stream.<<ReadAsync>g__FinishReadAsync|44_0>d>
	|
	|-RVA: 0x8DF1A0 Offset: 0x8DE3A0 VA: 0x1808DF1A0
	|-AsyncTaskMethodBuilder<int>.Start<StreamReader.<ReadAsyncInternal>d__66>
	|
	|-RVA: 0x8DF4A0 Offset: 0x8DE6A0 VA: 0x1808DF4A0
	|-AsyncTaskMethodBuilder<int>.Start<StreamReader.<ReadBufferAsync>d__69>
	|
	|-RVA: 0x8DF320 Offset: 0x8DE520 VA: 0x1808DF320
	|-AsyncTaskMethodBuilder<int>.Start<WebReadStream.<ReadAsync>d__28>
	|
	|-RVA: 0x8DF3E0 Offset: 0x8DE5E0 VA: 0x1808DF3E0
	|-AsyncTaskMethodBuilder<int>.Start<WebResponseStream.<ReadAsync>d__40>
	|
	|-RVA: 0x8DDBE0 Offset: 0x8DCDE0 VA: 0x1808DDBE0
	|-AsyncTaskMethodBuilder<Int32Enum>.Start<TwitchManager.<FetchEntitlements>d__19>
	|
	|-RVA: 0x8DEDE0 Offset: 0x8DDFE0 VA: 0x1808DEDE0
	|-AsyncTaskMethodBuilder<JsonElement>.Start<HttpClientExtensions.<ReadAsJsonAsync>d__0>
	|
	|-RVA: 0x8DFAA0 Offset: 0x8DECA0 VA: 0x1808DFAA0
	|-AsyncTaskMethodBuilder<object>.Start<ManagedWebSocket.<ReceiveAsyncPrivate>d__61<ManagedWebSocket.WebSocketReceiveResultGetter, object>>
	|
	|-RVA: 0x8DFC20 Offset: 0x8DEE20 VA: 0x1808DFC20
	|-AsyncTaskMethodBuilder<object>.Start<HttpWebRequest.<RunWithTimeoutWorker>d__241<object>>
	|
	|-RVA: 0x8E06A0 Offset: 0x8DF8A0 VA: 0x1808E06A0
	|-AsyncTaskMethodBuilder<object>.Start<WebCompletionSource.<WaitForCompletion>d__15<object>>
	|
	|-RVA: 0x8E0220 Offset: 0x8DF420 VA: 0x1808E0220
	|-AsyncTaskMethodBuilder<object>.Start<AsyncProtocolRequest.<StartOperation>d__23>
	|
	|-RVA: 0x8E03A0 Offset: 0x8DF5A0 VA: 0x1808E03A0
	|-AsyncTaskMethodBuilder<object>.Start<CachingTransport.<TryPrepareNextCacheFileAsync>d__27>
	|
	|-RVA: 0x8DDCA0 Offset: 0x8DCEA0 VA: 0x1808DDCA0
	|-AsyncTaskMethodBuilder<object>.Start<CorePackageInitializer.<GenerateProjectConfigurationAsync>d__53>
	|
	|-RVA: 0x8DE5A0 Offset: 0x8DD7A0 VA: 0x1808DE5A0
	|-AsyncTaskMethodBuilder<object>.Start<CoreRegistryInitializer.<InitializeRegistryAsync>d__3>
	|
	|-RVA: 0x8DD5E0 Offset: 0x8DC7E0 VA: 0x1808DD5E0
	|-AsyncTaskMethodBuilder<object>.Start<Envelope.<DeserializeAsync>d__28>
	|
	|-RVA: 0x8DD760 Offset: 0x8DC960 VA: 0x1808DD760
	|-AsyncTaskMethodBuilder<object>.Start<Envelope.<DeserializeHeaderAsync>d__27>
	|
	|-RVA: 0x8DD220 Offset: 0x8DC420 VA: 0x1808DD220
	|-AsyncTaskMethodBuilder<object>.Start<EnvelopeItem.<BufferPayloadAsync>d__22>
	|
	|-RVA: 0x8DD6A0 Offset: 0x8DC8A0 VA: 0x1808DD6A0
	|-AsyncTaskMethodBuilder<object>.Start<EnvelopeItem.<DeserializeAsync>d__39>
	|
	|-RVA: 0x8DD820 Offset: 0x8DCA20 VA: 0x1808DD820
	|-AsyncTaskMethodBuilder<object>.Start<EnvelopeItem.<DeserializeHeaderAsync>d__37>
	|
	|-RVA: 0x8DD8E0 Offset: 0x8DCAE0 VA: 0x1808DD8E0
	|-AsyncTaskMethodBuilder<object>.Start<EnvelopeItem.<DeserializePayloadAsync>d__38>
	|
	|-RVA: 0x8DD9A0 Offset: 0x8DCBA0 VA: 0x1808DD9A0
	|-AsyncTaskMethodBuilder<object>.Start<GraphQLContentExtractor.<ExtractContentAsync>d__3>
	|
	|-RVA: 0x8DDA60 Offset: 0x8DCC60 VA: 0x1808DDA60
	|-AsyncTaskMethodBuilder<object>.Start<GraphQLContentExtractor.<ExtractRequestContentAsync>d__0>
	|
	|-RVA: 0x8DFDA0 Offset: 0x8DEFA0 VA: 0x1808DFDA0
	|-AsyncTaskMethodBuilder<object>.Start<GzipBufferedRequestBodyHandler.<SendAsync>d__3>
	|
	|-RVA: 0x8E00A0 Offset: 0x8DF2A0 VA: 0x1808E00A0
	|-AsyncTaskMethodBuilder<object>.Start<HttpClient.<SendAsyncWorker>d__47>
	|
	|-RVA: 0x8DD3A0 Offset: 0x8DC5A0 VA: 0x1808DD3A0
	|-AsyncTaskMethodBuilder<object>.Start<HttpContent.<CreateContentReadStreamAsync>d__12>
	|
	|-RVA: 0x8DED20 Offset: 0x8DDF20 VA: 0x1808DED20
	|-AsyncTaskMethodBuilder<object>.Start<HttpContent.<ReadAsByteArrayAsync>d__19>
	|
	|-RVA: 0x8DEEA0 Offset: 0x8DE0A0 VA: 0x1808DEEA0
	|-AsyncTaskMethodBuilder<object>.Start<HttpContent.<ReadAsStreamAsync>d__18>
	|
	|-RVA: 0x8DEF60 Offset: 0x8DE160 VA: 0x1808DEF60
	|-AsyncTaskMethodBuilder<object>.Start<HttpContent.<ReadAsStringAsync>d__20>
	|
	|-RVA: 0x8E0460 Offset: 0x8DF660 VA: 0x1808E0460
	|-AsyncTaskMethodBuilder<object>.Start<HttpWebRequest.<<GetRewriteHandler>b__271_0>d>
	|
	|-RVA: 0x8DE7E0 Offset: 0x8DD9E0 VA: 0x1808DE7E0
	|-AsyncTaskMethodBuilder<object>.Start<HttpWebRequest.<MyGetResponseAsync>d__243>
	|
	|-RVA: 0x8DE960 Offset: 0x8DDB60 VA: 0x1808DE960
	|-AsyncTaskMethodBuilder<object>.Start<JsonDocument.<ParseAsyncCore>d__57>
	|
	|-RVA: 0x8DD160 Offset: 0x8DC360 VA: 0x1808DD160
	|-AsyncTaskMethodBuilder<object>.Start<Lock.<AcquireAsync>d__2>
	|
	|-RVA: 0x8DD460 Offset: 0x8DC660 VA: 0x1808DD460
	|-AsyncTaskMethodBuilder<object>.Start<MonoTlsStream.<CreateStream>d__18>
	|
	|-RVA: 0x8DFF20 Offset: 0x8DF120 VA: 0x1808DFF20
	|-AsyncTaskMethodBuilder<object>.Start<MonoWebRequestHandler.<SendAsync>d__99>
	|
	|-RVA: 0x8DDD60 Offset: 0x8DCF60 VA: 0x1808DDD60
	|-AsyncTaskMethodBuilder<object>.Start<PolyfillExtensions.<GetByteArrayAsync>d__25>
	|
	|-RVA: 0x8DE2A0 Offset: 0x8DD4A0 VA: 0x1808DE2A0
	|-AsyncTaskMethodBuilder<object>.Start<PolyfillExtensions.<GetStreamAsync>d__23>
	|
	|-RVA: 0x8DE360 Offset: 0x8DD560 VA: 0x1808DE360
	|-AsyncTaskMethodBuilder<object>.Start<PolyfillExtensions.<GetStringAsync>d__27>
	|
	|-RVA: 0x8DFE60 Offset: 0x8DF060 VA: 0x1808DFE60
	|-AsyncTaskMethodBuilder<object>.Start<RetryAfterHandler.<SendAsync>d__8>
	|
	|-RVA: 0x8DFFE0 Offset: 0x8DF1E0 VA: 0x1808DFFE0
	|-AsyncTaskMethodBuilder<object>.Start<SentryMessageHandler.<SendAsync>d__9>
	|
	|-RVA: 0x8E0160 Offset: 0x8DF360 VA: 0x1808E0160
	|-AsyncTaskMethodBuilder<object>.Start<SerializableExtensions.<SerializeToStringAsync>d__0>
	|
	|-RVA: 0x8DF560 Offset: 0x8DE760 VA: 0x1808DF560
	|-AsyncTaskMethodBuilder<object>.Start<StreamExtensions.<ReadByteChunkAsync>d__2>
	|
	|-RVA: 0x8DF6E0 Offset: 0x8DE8E0 VA: 0x1808DF6E0
	|-AsyncTaskMethodBuilder<object>.Start<StreamExtensions.<ReadLineAsync>d__0>
	|
	|-RVA: 0x8DF860 Offset: 0x8DEA60 VA: 0x1808DF860
	|-AsyncTaskMethodBuilder<object>.Start<StreamReader.<ReadToEndAsyncInternal>d__63>
	|
	|-RVA: 0x8DF920 Offset: 0x8DEB20 VA: 0x1808DF920
	|-AsyncTaskMethodBuilder<object>.Start<TextReader.<ReadToEndAsync>d__14>
	|
	|-RVA: 0x8DE420 Offset: 0x8DD620 VA: 0x1808DE420
	|-AsyncTaskMethodBuilder<object>.Start<WebClient.<GetWebResponseTaskAsync>d__112>
	|
	|-RVA: 0x8DE4E0 Offset: 0x8DD6E0 VA: 0x1808DE4E0
	|-AsyncTaskMethodBuilder<object>.Start<WebConnection.<InitConnection>d__19>
	|
	|-RVA: 0x8DE060 Offset: 0x8DD260 VA: 0x1808DE060
	|-AsyncTaskMethodBuilder<object>.Start<WebOperation.<GetRequestStream>d__50>
	|
	|-RVA: 0x8DEC60 Offset: 0x8DDE60 VA: 0x1808DEC60
	|-AsyncTaskMethodBuilder<object>.Start<WebResponseStream.<ReadAllAsyncInner>d__47>
	|
	|-RVA: 0x8DD2E0 Offset: 0x8DC4E0 VA: 0x1808DD2E0
	|-AsyncTaskMethodBuilder<object>.Start<WebSocketHandle.<ConnectSocketAsync>d__27>
	|
	|-RVA: 0x8DE8A0 Offset: 0x8DDAA0 VA: 0x1808DE8A0
	|-AsyncTaskMethodBuilder<object>.Start<WebSocketHandle.<ParseAndValidateConnectResponseAsync>d__30>
	|
	|-RVA: 0x8DF7A0 Offset: 0x8DE9A0 VA: 0x1808DF7A0
	|-AsyncTaskMethodBuilder<object>.Start<WebSocketHandle.<ReadResponseHeaderLineAsync>d__32>
	|
	|-RVA: 0x8DDFA0 Offset: 0x8DD1A0 VA: 0x1808DDFA0
	|-AsyncTaskMethodBuilder<object>.Start<XmlDownloadManager.<GetNonFileStreamAsync>d__5>
	|
	|-RVA: 0x8DDEE0 Offset: 0x8DD0E0 VA: 0x1808DDEE0
	|-AsyncTaskMethodBuilder<object>.Start<XmlUrlResolver.<GetEntityAsync>d__15>
	|
	|-RVA: 0x8DE1E0 Offset: 0x8DD3E0 VA: 0x1808DE1E0
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.Start<CorePackageInitializer.<GetSerializedConfigOrEmptyAsync>d__54>
	|
	|-RVA: 0x8DDE20 Offset: 0x8DD020 VA: 0x1808DDE20
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.Start<StreamingAssetsConfigurationLoader.<GetConfigAsync>d__2>
	|
	|-RVA: 0x8DFB60 Offset: 0x8DED60 VA: 0x1808DFB60
	|-AsyncTaskMethodBuilder<ValueWebSocketReceiveResult>.Start<WebSocket.<ReceiveAsync>d__14>
	|
	|-RVA: 0x8DCF90 Offset: 0x8DC190 VA: 0x1808DCF90
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.Start<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE946F0 Offset: 0xE938F0 VA: 0x180E946F0
	|-AsyncTaskMethodBuilder<ArraySegment<byte>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetStateMachine
	|-AsyncTaskMethodBuilder<Nullable<JsonElement>>.SetStateMachine
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.SetStateMachine
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.SetStateMachine
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.SetStateMachine
	|-AsyncTaskMethodBuilder<bool>.SetStateMachine
	|-AsyncTaskMethodBuilder<int>.SetStateMachine
	|-AsyncTaskMethodBuilder<Int32Enum>.SetStateMachine
	|-AsyncTaskMethodBuilder<JsonElement>.SetStateMachine
	|-AsyncTaskMethodBuilder<object>.SetStateMachine
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.SetStateMachine
	|-AsyncTaskMethodBuilder<ValueWebSocketReceiveResult>.SetStateMachine
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetStateMachine
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetStateMachine
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8D8260 Offset: 0x8D7460 VA: 0x1808D8260
	|-AsyncTaskMethodBuilder<ArraySegment<byte>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, JsonDocument.<ReadToEndAsync>d__65>
	|
	|-RVA: 0x8D7450 Offset: 0x8D6650 VA: 0x1808D7450
	|-AsyncTaskMethodBuilder<Nullable<int>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, AsyncProtocolRequest.<InnerRead>d__25>
	|
	|-RVA: 0x8D1D30 Offset: 0x8D0F30 VA: 0x1808D1D30
	|-AsyncTaskMethodBuilder<Nullable<JsonElement>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, GraphQLContentExtractor.<ExtractResponseContentAsync>d__1>
	|
	|-RVA: 0x8D3F70 Offset: 0x8D3170 VA: 0x1808D3F70
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebCompletionSource.<WaitForCompletion>d__15<ValueTuple<bool, object>>>
	|
	|-RVA: 0x8D8050 Offset: 0x8D7250 VA: 0x1808D8050
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebConnectionTunnel.<ReadHeaders>d__43>
	|
	|-RVA: 0x8D20F0 Offset: 0x8D12F0 VA: 0x1808D20F0
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpWebRequest.<GetResponseFromData>d__244>
	|
	|-RVA: 0x8D63D0 Offset: 0x8D55D0 VA: 0x1808D63D0
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpWebRequest.<GetResponseFromData>d__244>
	|
	|-RVA: 0x8D4150 Offset: 0x8D3350 VA: 0x1808D4150
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32>
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32>
	|
	|-RVA: 0x8D3D80 Offset: 0x8D2F80 VA: 0x1808D3D80
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, ServicePointScheduler.<WaitAsync>d__46>
	|
	|-RVA: 0x8D1120 Offset: 0x8D0320 VA: 0x1808D1120
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebConnection.<CreateStream>d__18>
	|
	|-RVA: 0x8D5740 Offset: 0x8D4940 VA: 0x1808D5740
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<CreateStream>d__18>
	|
	|-RVA: 0x8D7830 Offset: 0x8D6A30 VA: 0x1808D7830
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, HttpWebRequest.<RunWithTimeoutWorker>d__241<int>>
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, BufferedReadStream.<ProcessReadAsync>d__2>
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, FixedSizeReadStream.<ProcessReadAsync>d__5>
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, MonoChunkStream.<ProcessReadAsync>d__7>
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, PartialStream.<ReadAsync>d__16>
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, Stream.<<ReadAsync>g__FinishReadAsync|44_0>d>
	|
	|-RVA: 0x8D7640 Offset: 0x8D6840 VA: 0x1808D7640
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, MobileAuthenticatedStream.<InnerRead>d__66>
	|
	|-RVA: 0x8D7A30 Offset: 0x8D6C30 VA: 0x1808D7A30
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, StreamReader.<ReadAsyncInternal>d__66>
	|
	|-RVA: 0x8D7C60 Offset: 0x8D6E60 VA: 0x1808D7C60
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebReadStream.<ReadAsync>d__28>
	|
	|-RVA: 0x8D3120 Offset: 0x8D2320 VA: 0x1808D3120
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebResponseStream.<ReadAsync>d__40>
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebResponseStream.<ReadAsync>d__40>
	|
	|-RVA: 0x8D3B90 Offset: 0x8D2D90 VA: 0x1808D3B90
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<StartOperation>d__57>
	|
	|-RVA: 0x8D90B0 Offset: 0x8D82B0 VA: 0x1808D90B0
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, StreamReader.<ReadAsyncInternal>d__66>
	|
	|-RVA: 0x8D92E0 Offset: 0x8D84E0 VA: 0x1808D92E0
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, StreamReader.<ReadBufferAsync>d__69>
	|
	|-RVA: 0x8DB7A0 Offset: 0x8DA9A0 VA: 0x1808DB7A0
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<TaskAwaiter<int>, CryptoStream.<ReadAsyncInternal>d__37>
	|
	|-RVA: 0x8DC8F0 Offset: 0x8DBAF0 VA: 0x1808DC8F0
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ValueTaskAwaiter<int>, CryptoStream.<ReadAsyncCore>d__42>
	|
	|-RVA: 0x8D9F40 Offset: 0x8D9140 VA: 0x1808D9F40
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ForceAsyncAwaiter, CryptoStream.<ReadAsyncInternal>d__37>
	|
	|-RVA: 0x8D6BF0 Offset: 0x8D5DF0 VA: 0x1808D6BF0
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebReadStream.<ReadAsync>d__28>
	|
	|-RVA: 0x8DA850 Offset: 0x8D9A50 VA: 0x1808DA850
	|-AsyncTaskMethodBuilder<Int32Enum>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, TwitchManager.<FetchEntitlements>d__19>
	|
	|-RVA: 0x8D2F20 Offset: 0x8D2120 VA: 0x1808D2F20
	|-AsyncTaskMethodBuilder<JsonElement>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpClientExtensions.<ReadAsJsonAsync>d__0>
	|
	|-RVA: 0x8D1920 Offset: 0x8D0B20 VA: 0x1808D1920
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ArraySegment<byte>>, JsonDocument.<ParseAsyncCore>d__57>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, EnvelopeItem.<DeserializePayloadAsync>d__38>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, RetryAfterHandler.<SendAsync>d__8>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, XmlUrlResolver.<GetEntityAsync>d__15>
	|
	|-RVA: 0x8D0EF0 Offset: 0x8D00F0 VA: 0x1808D0EF0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>, HttpWebRequest.<MyGetResponseAsync>d__243>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpWebRequest.<MyGetResponseAsync>d__243>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MonoWebRequestHandler.<SendAsync>d__99>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebSocketHandle.<ConnectSocketAsync>d__27>
	|
	|-RVA: 0x8D2300 Offset: 0x8D1500 VA: 0x1808D2300
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, HttpWebRequest.<RunWithTimeoutWorker>d__241<object>>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, StreamExtensions.<ReadLineAsync>d__0>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebResponseStream.<ReadAllAsyncInner>d__47>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebSocketHandle.<ReadResponseHeaderLineAsync>d__32>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, PolyfillExtensions.<GetStreamAsync>d__23>
	|
	|-RVA: 0x8D1330 Offset: 0x8D0530 VA: 0x1808D1330
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, WebConnection.<InitConnection>d__19>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, Envelope.<DeserializeAsync>d__28>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, PolyfillExtensions.<GetByteArrayAsync>d__25>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, PolyfillExtensions.<GetStringAsync>d__27>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, SentryMessageHandler.<SendAsync>d__9>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebSocketHandle.<ParseAndValidateConnectResponseAsync>d__30>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, XmlDownloadManager.<GetNonFileStreamAsync>d__5>
	|
	|-RVA: 0x8D7E60 Offset: 0x8D7060 VA: 0x1808D7E60
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, StreamExtensions.<ReadByteChunkAsync>d__2>
	|
	|-RVA: 0x8D1740 Offset: 0x8D0940 VA: 0x1808D1740
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, StreamReader.<ReadToEndAsyncInternal>d__63>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, CachingTransport.<TryPrepareNextCacheFileAsync>d__27>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, Envelope.<DeserializeHeaderAsync>d__27>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, EnvelopeItem.<DeserializeHeaderAsync>d__37>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, GraphQLContentExtractor.<ExtractRequestContentAsync>d__0>
	|
	|-RVA: 0x8D1F10 Offset: 0x8D1110 VA: 0x1808D1F10
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebCompletionSource.<WaitForCompletion>d__15<object>>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpContent.<ReadAsStreamAsync>d__18>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebOperation.<GetRequestStream>d__50>
	|
	|-RVA: 0x8D1530 Offset: 0x8D0730 VA: 0x1808D1530
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, EnvelopeItem.<DeserializeAsync>d__39>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpClient.<SendAsyncWorker>d__47>
	|
	|-RVA: 0x8D1B10 Offset: 0x8D0D10 VA: 0x1808D1B10
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, GraphQLContentExtractor.<ExtractContentAsync>d__3>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, SerializableExtensions.<SerializeToStringAsync>d__0>
	|
	|-RVA: 0x8D3750 Offset: 0x8D2950 VA: 0x1808D3750
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, GzipBufferedRequestBodyHandler.<SendAsync>d__3>
	|
	|-RVA: 0x8D96C0 Offset: 0x8D88C0 VA: 0x1808D96C0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, ManagedWebSocket.<ReceiveAsyncPrivate>d__61<ManagedWebSocket.WebSocketReceiveResultGetter, object>>
	|
	|-RVA: 0x8D94D0 Offset: 0x8D86D0 VA: 0x1808D94D0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, TextReader.<ReadToEndAsync>d__14>
	|
	|-RVA: 0x8DAE00 Offset: 0x8DA000 VA: 0x1808DAE00
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, HttpWebRequest.<MyGetResponseAsync>d__243>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, MonoWebRequestHandler.<SendAsync>d__99>
	|
	|-RVA: 0x8DB3F0 Offset: 0x8DA5F0 VA: 0x1808DB3F0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<SerializableProjectConfiguration>, CorePackageInitializer.<GenerateProjectConfigurationAsync>d__53>
	|
	|-RVA: 0x8DA5E0 Offset: 0x8D97E0 VA: 0x1808DA5E0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<object, WebClient.<GetWebResponseTaskAsync>d__112>
	|
	|-RVA: 0x8DBD50 Offset: 0x8DAF50 VA: 0x1808DBD50
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter, CoreRegistryInitializer.<InitializeRegistryAsync>d__3>
	|
	|-RVA: 0x8D6DF0 Offset: 0x8D5FF0 VA: 0x1808D6DF0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, ManagedWebSocket.<ReceiveAsyncPrivate>d__61<ManagedWebSocket.WebSocketReceiveResultGetter, object>>
	|
	|-RVA: 0x8D4560 Offset: 0x8D3760 VA: 0x1808D4560
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<StartOperation>d__23>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpWebRequest.<<GetRewriteHandler>b__271_0>d>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Lock.<AcquireAsync>d__2>
	|
	|-RVA: 0x8D4740 Offset: 0x8D3940 VA: 0x1808D4740
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, EnvelopeItem.<BufferPayloadAsync>d__22>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MonoTlsStream.<CreateStream>d__18>
	|
	|-RVA: 0x8D5950 Offset: 0x8D4B50 VA: 0x1808D5950
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, EnvelopeItem.<DeserializeAsync>d__39>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpClient.<SendAsyncWorker>d__47>
	|
	|-RVA: 0x8D5D70 Offset: 0x8D4F70 VA: 0x1808D5D70
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, GraphQLContentExtractor.<ExtractContentAsync>d__3>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, SerializableExtensions.<SerializeToStringAsync>d__0>
	|
	|-RVA: 0x8D7020 Offset: 0x8D6220 VA: 0x1808D7020
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, GzipBufferedRequestBodyHandler.<SendAsync>d__3>
	|
	|-RVA: 0x8D5560 Offset: 0x8D4760 VA: 0x1808D5560
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpContent.<CreateContentReadStreamAsync>d__12>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpContent.<ReadAsByteArrayAsync>d__19>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpContent.<ReadAsStringAsync>d__20>
	|
	|-RVA: 0x8D5130 Offset: 0x8D4330 VA: 0x1808D5130
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpWebRequest.<MyGetResponseAsync>d__243>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MonoWebRequestHandler.<SendAsync>d__99>
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebSocketHandle.<ConnectSocketAsync>d__27>
	|
	|-RVA: 0x8D6800 Offset: 0x8D5A00 VA: 0x1808D6800
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<InitConnection>d__19>
	|
	|-RVA: 0x8DAA50 Offset: 0x8D9C50 VA: 0x1808DAA50
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, StreamingAssetsConfigurationLoader.<GetConfigAsync>d__2>
	|
	|-RVA: 0x8DB5D0 Offset: 0x8DA7D0 VA: 0x1808DB5D0
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.AwaitUnsafeOnCompleted<TaskAwaiter<SerializableProjectConfiguration>, CorePackageInitializer.<GetSerializedConfigOrEmptyAsync>d__54>
	|
	|-RVA: 0x8D3340 Offset: 0x8D2540 VA: 0x1808D3340
	|-AsyncTaskMethodBuilder<ValueWebSocketReceiveResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebSocket.<ReceiveAsync>d__14>
	|
	|-RVA: 0x8D4360 Offset: 0x8D3560 VA: 0x1808D4360
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>, AsyncProtocolRequest.<ProcessOperation>d__24>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, BackgroundWorker.<DoFlushAsync>d__22>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, MonoChunkStream.<FinishReading>d__8>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebRequestStream.<WriteChunkTrailer>d__40>
	|
	|-RVA: 0x8D3550 Offset: 0x8D2750 VA: 0x1808D3550
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>, WebConnectionTunnel.<Initialize>d__42>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, ServicePointScheduler.<RunScheduler>d__32>
	|
	|-RVA: 0x8D2720 Offset: 0x8D1920 VA: 0x1808D2720
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, StreamExtensions.<SkipNewlinesAsync>d__1>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpTransportBase.<HandleSuccessAsync>d__17>
	|
	|-RVA: 0x8D2B20 Offset: 0x8D1D20 VA: 0x1808D2B20
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebResponseStream.<InitReadAsync>d__52>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, CachingTransport.<ProcessCacheAsync>d__24>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<ProcessAuthentication>d__48>
	|
	|-RVA: 0x8D2500 Offset: 0x8D1700 VA: 0x1808D2500
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<JsonElement>, HttpTransportBase.<HandleFailureAsync>d__20>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpTransportBase.<HandleFailureAsync>d__20>
	|
	|-RVA: 0x8D3960 Offset: 0x8D2B60 VA: 0x1808D3960
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, AsyncJsonSerializable.<SerializeAsync>d__5>
	|
	|-RVA: 0x8D2910 Offset: 0x8D1B10 VA: 0x1808D2910
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, CachingTransport.<InnerProcessCacheAsync>d__25>
	|
	|-RVA: 0x8D2D10 Offset: 0x8D1F10 VA: 0x1808D2D10
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, CachingTransport.<StoreToCacheAsync>d__28>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, EnvelopeItem.<SerializeAsync>d__26>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpTransport.<SendEnvelopeAsync>d__3>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebResponseStream.<ReadAllAsync>d__48>
	|
	|-RVA: 0x8D0CC0 Offset: 0x8CFEC0 VA: 0x1808D0CC0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebSocketHandle.<ConnectAsyncCore>d__26>
	|
	|-RVA: 0x8D8EC0 Offset: 0x8D80C0 VA: 0x1808D8EC0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, ManagedWebSocket.<EnsureBufferContainsAsync>d__71>
	|
	|-RVA: 0x8D98F0 Offset: 0x8D8AF0 VA: 0x1808D98F0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, ManagedWebSocket.<WaitForServerToCloseConnectionAsync>d__63>
	|
	|-RVA: 0x8D8CB0 Offset: 0x8D7EB0 VA: 0x1808D8CB0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int>, Stream.<CopyToAsyncInternal>d__28>
	|
	|-RVA: 0x8DAC20 Offset: 0x8D9E20 VA: 0x1808DAC20
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, CorePackageInitializer.<InitializeProjectConfigAsync>d__52>
	|
	|-RVA: 0x8DB200 Offset: 0x8DA400 VA: 0x1808DB200
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, PolyfillExtensions.<WaitAsync>d__78>
	|
	|-RVA: 0x8DB030 Offset: 0x8DA230 VA: 0x1808DB030
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, UnityServicesInternal.<>c__DisplayClass22_0.<<InitializeServicesAsync>g__InitializePackagesAsync|1>d>
	|
	|-RVA: 0x8DA140 Offset: 0x8D9340 VA: 0x1808DA140
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ForceAsyncAwaiter, CryptoStream.<WriteAsyncInternal>d__46>
	|
	|-RVA: 0x8DB9A0 Offset: 0x8DABA0 VA: 0x1808DB9A0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, CorePackageInitializer.<InitializeComponents>d__47>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, Ua2CoreInitializeCallback.<Initialize>d__2>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, UnityServicesInternal.<EnableInitializationAsync>d__25>
	|
	|-RVA: 0x8DC6F0 Offset: 0x8DB8F0 VA: 0x1808DC6F0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, CryptoStream.<WriteAsyncInternal>d__46>
	|
	|-RVA: 0x8DC120 Offset: 0x8DB320 VA: 0x1808DC120
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, PolyfillExtensions.<WaitAsync>d__77>
	|
	|-RVA: 0x8DC300 Offset: 0x8DB500 VA: 0x1808DC300
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, PolyfillExtensions.<WaitAsync>d__78>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<WriteRequestAsync>d__38>
	|
	|-RVA: 0x8DBB70 Offset: 0x8DAD70 VA: 0x1808DBB70
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, TwitchManager.<FetchNewToken>d__18>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, UnityServicesInternal.<InitializeServicesAsync>d__22>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__InitializePackageAsync|2>d>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__TryInitializePackageAsync|0>d>
	|
	|-RVA: 0x8DBF30 Offset: 0x8DB130 VA: 0x1808DBF30
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<Initialize>d__36>
	|
	|-RVA: 0x8DC4F0 Offset: 0x8DB6F0 VA: 0x1808DC4F0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<WriteAsyncInner>d__33>
	|
	|-RVA: 0x8DCD50 Offset: 0x8DBF50 VA: 0x1808DCD50
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ValueTaskAwaiter, Envelope.<SerializeHeaderAsync>d__11>
	|
	|-RVA: 0x8DCB10 Offset: 0x8DBD10 VA: 0x1808DCB10
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ValueTaskAwaiter, CryptoStream.<WriteAsyncCore>d__49>
	|
	|-RVA: 0x8D5F90 Offset: 0x8D5190 VA: 0x1808D5F90
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncJsonSerializable.<SerializeAsync>d__5>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamWriter.<FlushAsyncInternal>d__74>
	|
	|-RVA: 0x8D4B20 Offset: 0x8D3D20 VA: 0x1808D4B20
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<ProcessOperation>d__24>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, BackgroundWorker.<DoFlushAsync>d__22>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, ManagedWebSocket.<CloseAsyncPrivate>d__68>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MonoChunkStream.<FinishReading>d__8>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<ProcessWrite>d__34>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteChunkTrailer>d__40>
	|
	|-RVA: 0x8D5B60 Offset: 0x8D4D60 VA: 0x1808D5B60
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, BackgroundWorker.<DoWorkAsync>d__20>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CachingTransport.<StoreToCacheAsync>d__28>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, EnvelopeItem.<SerializeAsync>d__26>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpTransport.<SendEnvelopeAsync>d__3>
	|
	|-RVA: 0x8D61C0 Offset: 0x8D53C0 VA: 0x1808D61C0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, BackgroundWorker.<FlushAsync>d__21>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CachingTransport.<InnerProcessCacheAsync>d__25>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, ManagedWebSocket.<HandleReceivedCloseAsync>d__62>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, ManagedWebSocket.<HandleReceivedPingPongAsync>d__64>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, ManagedWebSocket.<SendCloseFrameAsync>d__69>
	|
	|-RVA: 0x8D4930 Offset: 0x8D3B30 VA: 0x1808D4930
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, BackgroundWorker.<SendFinalClientReportAsync>d__23>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CachingTransport.<CachedTransportBackgroundTaskAsync>d__20>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, ClientWebSocket.<ConnectAsyncCore>d__16>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, ManagedWebSocket.<CloseWithReceiveErrorAndThrowAsync>d__66>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MobileAuthenticatedStream.<InnerWrite>d__67>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, SentryScopeManager.<WithScopeAsync>d__21>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<Initialize>d__36>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<SetHeadersAsync>d__37>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, GzipRequestBodyHandler.GzipContent.<SerializeToStreamAsync>d__4>
	|
	|-RVA: 0x8D4D20 Offset: 0x8D3F20 VA: 0x1808D4D20
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CachingTransport.<DisposeAsync>d__33>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, EnvelopeHttpContent.<SerializeToStreamAsync>d__4>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpContent.<LoadIntoBufferAsync>d__17>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Hub.<ConfigureScopeAsync>d__21>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Hub.<FlushAsync>d__55>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Stream.<FinishWriteAsync>d__57>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Utf8JsonWriter.<DisposeAsync>d__35>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Utf8JsonWriter.<FlushAsync>d__36>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<FinishWriting>d__31>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteChunkTrailer_inner>d__39>
	|
	|-RVA: 0x8D6A00 Offset: 0x8D5C00 VA: 0x1808D6A00
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CachingTransport.<ProcessCacheAsync>d__24>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, CachingTransport.<SendEnvelopeAsync>d__30>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteRequestAsync>d__38>
	|
	|-RVA: 0x8D5360 Offset: 0x8D4560 VA: 0x1808D5360
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Envelope.<SerializeAsync>d__14>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<Connect>d__16>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnectionTunnel.<Initialize>d__42>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteAsyncInner>d__33>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebSocket.<SendWithArrayPoolAsync>d__16>
	|
	|-RVA: 0x8D7230 Offset: 0x8D6430 VA: 0x1808D7230
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Envelope.<SerializeHeaderAsync>d__11>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, EnvelopeItem.<SerializeHeaderAsync>d__24>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, JsonSerializable.<SerializeAsync>d__4>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, ManagedWebSocket.<SendFrameFallbackAsync>d__56>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, StreamWriter.<WriteAsyncInternal>d__62>
	|
	|-RVA: 0x8D65E0 Offset: 0x8D57E0 VA: 0x1808D65E0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpTransportBase.<HandleFailureAsync>d__20>
	|
	|-RVA: 0x8D4F00 Offset: 0x8D4100 VA: 0x1808D4F00
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebSocketHandle.<ConnectAsyncCore>d__26>
	|
	|-RVA: 0x8D9D10 Offset: 0x8D8F10 VA: 0x1808D9D10
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, AsyncJsonSerializable.<SerializeAsync>d__5>
	|
	|-RVA: 0x8D9AF0 Offset: 0x8D8CF0 VA: 0x1808D9AF0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, EnvelopeItem.<SerializeHeaderAsync>d__24>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, JsonSerializable.<SerializeAsync>d__4>
	|
	|-RVA: 0x8D8460 Offset: 0x8D7660 VA: 0x1808D8460
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, ManagedWebSocket.<HandleReceivedPingPongAsync>d__64>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, ManagedWebSocket.<SendCloseFrameAsync>d__69>
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, Stream.<CopyToAsyncInternal>d__28>
	|
	|-RVA: 0x8D88A0 Offset: 0x8D7AA0 VA: 0x1808D88A0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, ManagedWebSocket.<SendFrameFallbackAsync>d__56>
	|
	|-RVA: 0x8D8AC0 Offset: 0x8D7CC0 VA: 0x1808D8AC0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, ManagedWebSocket.<WaitForWriteTaskAsync>d__55>
	|
	|-RVA: 0x8D8670 Offset: 0x8D7870 VA: 0x1808D8670
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter, StreamWriter.<FlushAsyncInternal>d__74>
	|
	|-RVA: 0x8DA340 Offset: 0x8D9540 VA: 0x1808DA340
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.AwaitUnsafeOnCompleted<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE959C0 Offset: 0xE94BC0 VA: 0x180E959C0
	|-AsyncTaskMethodBuilder<ArraySegment<byte>>.get_Task
	|
	|-RVA: 0xE95DB0 Offset: 0xE94FB0 VA: 0x180E95DB0
	|-AsyncTaskMethodBuilder<Nullable<int>>.get_Task
	|
	|-RVA: 0xE95B00 Offset: 0xE94D00 VA: 0x180E95B00
	|-AsyncTaskMethodBuilder<Nullable<JsonElement>>.get_Task
	|
	|-RVA: 0xE95920 Offset: 0xE94B20 VA: 0x180E95920
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.get_Task
	|
	|-RVA: 0xE957E0 Offset: 0xE949E0 VA: 0x180E957E0
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.get_Task
	|
	|-RVA: 0xE95880 Offset: 0xE94A80 VA: 0x180E95880
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.get_Task
	|
	|-RVA: 0xE95600 Offset: 0xE94800 VA: 0x180E95600
	|-AsyncTaskMethodBuilder<bool>.get_Task
	|
	|-RVA: 0xE95740 Offset: 0xE94940 VA: 0x180E95740
	|-AsyncTaskMethodBuilder<int>.get_Task
	|
	|-RVA: 0xE956A0 Offset: 0xE948A0 VA: 0x180E956A0
	|-AsyncTaskMethodBuilder<Int32Enum>.get_Task
	|
	|-RVA: 0xE95A60 Offset: 0xE94C60 VA: 0x180E95A60
	|-AsyncTaskMethodBuilder<JsonElement>.get_Task
	|
	|-RVA: 0xE95EF0 Offset: 0xE950F0 VA: 0x180E95EF0
	|-AsyncTaskMethodBuilder<object>.get_Task
	|
	|-RVA: 0xE95C70 Offset: 0xE94E70 VA: 0x180E95C70
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.get_Task
	|
	|-RVA: 0xE95E50 Offset: 0xE95050 VA: 0x180E95E50
	|-AsyncTaskMethodBuilder<ValueWebSocketReceiveResult>.get_Task
	|
	|-RVA: 0xE95D10 Offset: 0xE94F10 VA: 0x180E95D10
	|-AsyncTaskMethodBuilder<VoidTaskResult>.get_Task
	|
	|-RVA: 0xE95BA0 Offset: 0xE94DA0 VA: 0x180E95BA0
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.get_Task
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE92D80 Offset: 0xE91F80 VA: 0x180E92D80
	|-AsyncTaskMethodBuilder<ArraySegment<byte>>.SetResult
	|
	|-RVA: 0xE92BB0 Offset: 0xE91DB0 VA: 0x180E92BB0
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetResult
	|
	|-RVA: 0xE94320 Offset: 0xE93520 VA: 0x180E94320
	|-AsyncTaskMethodBuilder<Nullable<JsonElement>>.SetResult
	|
	|-RVA: 0xE93470 Offset: 0xE92670 VA: 0x180E93470
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.SetResult
	|
	|-RVA: 0xE92F60 Offset: 0xE92160 VA: 0x180E92F60
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.SetResult
	|
	|-RVA: 0xE92220 Offset: 0xE91420 VA: 0x180E92220
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.SetResult
	|
	|-RVA: 0xE94150 Offset: 0xE93350 VA: 0x180E94150
	|-AsyncTaskMethodBuilder<bool>.SetResult
	|
	|-RVA: 0xE93650 Offset: 0xE92850 VA: 0x180E93650
	|-AsyncTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0xE929E0 Offset: 0xE91BE0 VA: 0x180E929E0
	|-AsyncTaskMethodBuilder<Int32Enum>.SetResult
	|
	|-RVA: 0xE93B70 Offset: 0xE92D70 VA: 0x180E93B70
	|-AsyncTaskMethodBuilder<JsonElement>.SetResult
	|
	|-RVA: 0xE91E30 Offset: 0xE91030 VA: 0x180E91E30
	|-AsyncTaskMethodBuilder<object>.SetResult
	|
	|-RVA: 0xE93EB0 Offset: 0xE930B0 VA: 0x180E93EB0
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.SetResult
	|
	|-RVA: 0xE94520 Offset: 0xE93720 VA: 0x180E94520
	|-AsyncTaskMethodBuilder<ValueWebSocketReceiveResult>.SetResult
	|
	|-RVA: 0xE92570 Offset: 0xE91770 VA: 0x180E92570
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetResult
	|
	|-RVA: 0xE93820 Offset: 0xE92A20 VA: 0x180E93820
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetResult
	*/

	// RVA: -1 Offset: -1
	internal void SetResult(Task<TResult> completedTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE93D50 Offset: 0xE92F50 VA: 0x180E93D50
	|-AsyncTaskMethodBuilder<ArraySegment<byte>>.SetResult
	|
	|-RVA: 0xE928A0 Offset: 0xE91AA0 VA: 0x180E928A0
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetResult
	|
	|-RVA: 0xE92000 Offset: 0xE91200 VA: 0x180E92000
	|-AsyncTaskMethodBuilder<Nullable<JsonElement>>.SetResult
	|
	|-RVA: 0xE92410 Offset: 0xE91610 VA: 0x180E92410
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.SetResult
	|
	|-RVA: 0xE933B0 Offset: 0xE925B0 VA: 0x180E933B0
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.SetResult
	|
	|-RVA: 0xE92740 Offset: 0xE91940 VA: 0x180E92740
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.SetResult
	|
	|-RVA: 0xE92180 Offset: 0xE91380 VA: 0x180E92180
	|-AsyncTaskMethodBuilder<bool>.SetResult
	|
	|-RVA: 0xE924D0 Offset: 0xE916D0 VA: 0x180E924D0
	|-AsyncTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0xE93160 Offset: 0xE92360 VA: 0x180E93160
	|-AsyncTaskMethodBuilder<Int32Enum>.SetResult
	|
	|-RVA: 0xE94090 Offset: 0xE93290 VA: 0x180E94090
	|-AsyncTaskMethodBuilder<JsonElement>.SetResult
	|
	|-RVA: 0xE92800 Offset: 0xE91A00 VA: 0x180E92800
	|-AsyncTaskMethodBuilder<object>.SetResult
	|
	|-RVA: 0xE920C0 Offset: 0xE912C0 VA: 0x180E920C0
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.SetResult
	|
	|-RVA: 0xE93E10 Offset: 0xE93010 VA: 0x180E93E10
	|-AsyncTaskMethodBuilder<ValueWebSocketReceiveResult>.SetResult
	|
	|-RVA: 0xE92940 Offset: 0xE91B40 VA: 0x180E92940
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetResult
	|
	|-RVA: 0xE93200 Offset: 0xE92400 VA: 0x180E93200
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetResult
	*/

	// RVA: -1 Offset: -1
	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE91350 Offset: 0xE90550 VA: 0x180E91350
	|-AsyncTaskMethodBuilder<ArraySegment<byte>>.SetException
	|
	|-RVA: 0xE90C10 Offset: 0xE8FE10 VA: 0x180E90C10
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetException
	|
	|-RVA: 0xE91180 Offset: 0xE90380 VA: 0x180E91180
	|-AsyncTaskMethodBuilder<Nullable<JsonElement>>.SetException
	|
	|-RVA: 0xE90FB0 Offset: 0xE901B0 VA: 0x180E90FB0
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.SetException
	|
	|-RVA: 0xE91A90 Offset: 0xE90C90 VA: 0x180E91A90
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.SetException
	|
	|-RVA: 0xE90A40 Offset: 0xE8FC40 VA: 0x180E90A40
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.SetException
	|
	|-RVA: 0xE916F0 Offset: 0xE908F0 VA: 0x180E916F0
	|-AsyncTaskMethodBuilder<bool>.SetException
	|
	|-RVA: 0xE91520 Offset: 0xE90720 VA: 0x180E91520
	|-AsyncTaskMethodBuilder<int>.SetException
	|
	|-RVA: 0xE90870 Offset: 0xE8FA70 VA: 0x180E90870
	|-AsyncTaskMethodBuilder<Int32Enum>.SetException
	|
	|-RVA: 0xE902D0 Offset: 0xE8F4D0 VA: 0x180E902D0
	|-AsyncTaskMethodBuilder<JsonElement>.SetException
	|
	|-RVA: 0xE918C0 Offset: 0xE90AC0 VA: 0x180E918C0
	|-AsyncTaskMethodBuilder<object>.SetException
	|
	|-RVA: 0xE91C60 Offset: 0xE90E60 VA: 0x180E91C60
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.SetException
	|
	|-RVA: 0xE904A0 Offset: 0xE8F6A0 VA: 0x180E904A0
	|-AsyncTaskMethodBuilder<ValueWebSocketReceiveResult>.SetException
	|
	|-RVA: 0xE90DE0 Offset: 0xE8FFE0 VA: 0x180E90DE0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetException
	|
	|-RVA: 0xE90670 Offset: 0xE8F870 VA: 0x180E90670
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetException
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> GetTaskForResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE8F580 Offset: 0xE8E780 VA: 0x180E8F580
	|-AsyncTaskMethodBuilder<ArraySegment<byte>>.GetTaskForResult
	|
	|-RVA: 0xE88250 Offset: 0xE87450 VA: 0x180E88250
	|-AsyncTaskMethodBuilder<Nullable<int>>.GetTaskForResult
	|
	|-RVA: 0xE84C20 Offset: 0xE83E20 VA: 0x180E84C20
	|-AsyncTaskMethodBuilder<Nullable<JsonElement>>.GetTaskForResult
	|
	|-RVA: 0xE86730 Offset: 0xE85930 VA: 0x180E86730
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.GetTaskForResult
	|
	|-RVA: 0xE87480 Offset: 0xE86680 VA: 0x180E87480
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.GetTaskForResult
	|
	|-RVA: 0xE8DAB0 Offset: 0xE8CCB0 VA: 0x180E8DAB0
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.GetTaskForResult
	|
	|-RVA: 0xE8E860 Offset: 0xE8DA60 VA: 0x180E8E860
	|-AsyncTaskMethodBuilder<bool>.GetTaskForResult
	|
	|-RVA: 0xE898D0 Offset: 0xE88AD0 VA: 0x180E898D0
	|-AsyncTaskMethodBuilder<int>.GetTaskForResult
	|
	|-RVA: 0xE8A5E0 Offset: 0xE897E0 VA: 0x180E8A5E0
	|-AsyncTaskMethodBuilder<Int32Enum>.GetTaskForResult
	|
	|-RVA: 0xE8CD60 Offset: 0xE8BF60 VA: 0x180E8CD60
	|-AsyncTaskMethodBuilder<JsonElement>.GetTaskForResult
	|
	|-RVA: 0xE89660 Offset: 0xE88860 VA: 0x180E89660
	|-AsyncTaskMethodBuilder<object>.GetTaskForResult
	|
	|-RVA: 0xE8B2F0 Offset: 0xE8A4F0 VA: 0x180E8B2F0
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>.GetTaskForResult
	|
	|-RVA: 0xE8C040 Offset: 0xE8B240 VA: 0x180E8C040
	|-AsyncTaskMethodBuilder<ValueWebSocketReceiveResult>.GetTaskForResult
	|
	|-RVA: 0xE85A20 Offset: 0xE84C20 VA: 0x180E85A20
	|-AsyncTaskMethodBuilder<VoidTaskResult>.GetTaskForResult
	|
	|-RVA: 0xE884C0 Offset: 0xE876C0 VA: 0x180E884C0
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.GetTaskForResult
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE94AD0 Offset: 0xE93CD0 VA: 0x180E94AD0
	|-AsyncTaskMethodBuilder<ArraySegment<byte>>..cctor
	|
	|-RVA: 0xE94F70 Offset: 0xE94170 VA: 0x180E94F70
	|-AsyncTaskMethodBuilder<Nullable<int>>..cctor
	|
	|-RVA: 0xE95420 Offset: 0xE94620 VA: 0x180E95420
	|-AsyncTaskMethodBuilder<Nullable<JsonElement>>..cctor
	|
	|-RVA: 0xE948D0 Offset: 0xE93AD0 VA: 0x180E948D0
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>..cctor
	|
	|-RVA: 0xE94CB0 Offset: 0xE93EB0 VA: 0x180E94CB0
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>..cctor
	|
	|-RVA: 0xE94700 Offset: 0xE93900 VA: 0x180E94700
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>..cctor
	|
	|-RVA: 0xE95520 Offset: 0xE94720 VA: 0x180E95520
	|-AsyncTaskMethodBuilder<bool>..cctor
	|
	|-RVA: 0xE94BD0 Offset: 0xE93DD0 VA: 0x180E94BD0
	|-AsyncTaskMethodBuilder<int>..cctor
	|
	|-RVA: 0xE947F0 Offset: 0xE939F0 VA: 0x180E947F0
	|-AsyncTaskMethodBuilder<Int32Enum>..cctor
	|
	|-RVA: 0xE949D0 Offset: 0xE93BD0 VA: 0x180E949D0
	|-AsyncTaskMethodBuilder<JsonElement>..cctor
	|
	|-RVA: 0xE95340 Offset: 0xE94540 VA: 0x180E95340
	|-AsyncTaskMethodBuilder<object>..cctor
	|
	|-RVA: 0xE95050 Offset: 0xE94250 VA: 0x180E95050
	|-AsyncTaskMethodBuilder<SerializableProjectConfiguration>..cctor
	|
	|-RVA: 0xE94E90 Offset: 0xE94090 VA: 0x180E94E90
	|-AsyncTaskMethodBuilder<ValueWebSocketReceiveResult>..cctor
	|
	|-RVA: 0xE94DB0 Offset: 0xE93FB0 VA: 0x180E94DB0
	|-AsyncTaskMethodBuilder<VoidTaskResult>..cctor
	|
	|-RVA: 0xE95150 Offset: 0xE94350 VA: 0x180E95150
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Runtime.CompilerServices
internal static class AsyncTaskCache // TypeDefIndex: 4059
{
	// Fields
	internal static readonly Task<bool> TrueTask; // 0x0
	internal static readonly Task<bool> FalseTask; // 0x8
	internal static readonly Task<int>[] Int32Tasks; // 0x10

	// Methods

	// RVA: 0x1675F00 Offset: 0x1675100 VA: 0x181675F00
	private static Task<int>[] CreateInt32Tasks() { }

	// RVA: -1 Offset: -1
	internal static Task<TResult> CreateCacheableTask<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x93C180 Offset: 0x93B380 VA: 0x18093C180
	|-AsyncTaskCache.CreateCacheableTask<ArraySegment<byte>>
	|
	|-RVA: 0x93C610 Offset: 0x93B810 VA: 0x18093C610
	|-AsyncTaskCache.CreateCacheableTask<Nullable<int>>
	|
	|-RVA: 0x93C570 Offset: 0x93B770 VA: 0x18093C570
	|-AsyncTaskCache.CreateCacheableTask<Nullable<JsonElement>>
	|
	|-RVA: 0x93C7C0 Offset: 0x93B9C0 VA: 0x18093C7C0
	|-AsyncTaskCache.CreateCacheableTask<ValueTuple<bool, object>>
	|
	|-RVA: 0x93C850 Offset: 0x93BA50 VA: 0x18093C850
	|-AsyncTaskCache.CreateCacheableTask<ValueTuple<object, object, int>>
	|
	|-RVA: 0x93C8F0 Offset: 0x93BAF0 VA: 0x18093C8F0
	|-AsyncTaskCache.CreateCacheableTask<ValueTuple<object, bool, bool, object, object>>
	|
	|-RVA: 0x93C210 Offset: 0x93B410 VA: 0x18093C210
	|-AsyncTaskCache.CreateCacheableTask<bool>
	|
	|-RVA: 0x93C450 Offset: 0x93B650 VA: 0x18093C450
	|-AsyncTaskCache.CreateCacheableTask<int>
	|
	|-RVA: 0x93C3C0 Offset: 0x93B5C0 VA: 0x18093C3C0
	|-AsyncTaskCache.CreateCacheableTask<Int32Enum>
	|
	|-RVA: 0x93C4E0 Offset: 0x93B6E0 VA: 0x18093C4E0
	|-AsyncTaskCache.CreateCacheableTask<JsonElement>
	|
	|-RVA: 0x93C6A0 Offset: 0x93B8A0 VA: 0x18093C6A0
	|-AsyncTaskCache.CreateCacheableTask<object>
	|
	|-RVA: 0x93C730 Offset: 0x93B930 VA: 0x18093C730
	|-AsyncTaskCache.CreateCacheableTask<SerializableProjectConfiguration>
	|
	|-RVA: 0x93C990 Offset: 0x93BB90 VA: 0x18093C990
	|-AsyncTaskCache.CreateCacheableTask<ValueWebSocketReceiveResult>
	|
	|-RVA: 0x93CA20 Offset: 0x93BC20 VA: 0x18093CA20
	|-AsyncTaskCache.CreateCacheableTask<VoidTaskResult>
	|
	|-RVA: 0x93C2A0 Offset: 0x93B4A0 VA: 0x18093C2A0
	|-AsyncTaskCache.CreateCacheableTask<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1676000 Offset: 0x1675200 VA: 0x181676000
	private static void .cctor() { }
}

// Namespace: 
internal sealed class AsyncMethodBuilderCore.MoveNextRunner // TypeDefIndex: 4060
{
	// Fields
	private readonly ExecutionContext m_context; // 0x10
	internal IAsyncStateMachine m_stateMachine; // 0x18
	private static ContextCallback s_invokeMoveNext; // 0x0

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	internal void .ctor(ExecutionContext context, IAsyncStateMachine stateMachine) { }

	// RVA: 0x1680FE0 Offset: 0x16801E0 VA: 0x181680FE0
	internal void Run() { }

	// RVA: 0x1680F40 Offset: 0x1680140 VA: 0x181680F40
	private static void InvokeMoveNext(object stateMachine) { }
}

// Namespace: 
private class AsyncMethodBuilderCore.ContinuationWrapper // TypeDefIndex: 4061
{
	// Fields
	internal readonly Action m_continuation; // 0x10
	private readonly Action m_invokeAction; // 0x18
	internal readonly Task m_innerTask; // 0x20

	// Methods

	// RVA: 0x16770B0 Offset: 0x16762B0 VA: 0x1816770B0
	internal void .ctor(Action continuation, Action invokeAction, Task innerTask) { }

	// RVA: 0xB767D0 Offset: 0xB759D0 VA: 0x180B767D0
	internal void Invoke() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AsyncMethodBuilderCore.<>c__DisplayClass5_0 // TypeDefIndex: 4062
{
	// Fields
	public Task innerTask; // 0x10
	public Action continuation; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x168EE00 Offset: 0x168E000 VA: 0x18168EE00
	internal void <OutputAsyncCausalityEvents>b__0() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class AsyncMethodBuilderCore.<>c // TypeDefIndex: 4063
{
	// Fields
	public static readonly AsyncMethodBuilderCore.<>c <>9; // 0x0
	public static SendOrPostCallback <>9__7_0; // 0x8
	public static WaitCallback <>9__7_1; // 0x10

	// Methods

	// RVA: 0x168EF20 Offset: 0x168E120 VA: 0x18168EF20
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x168EB60 Offset: 0x168DD60 VA: 0x18168EB60
	internal void <ThrowAsync>b__7_0(object state) { }

	// RVA: 0x168EBC0 Offset: 0x168DDC0 VA: 0x18168EBC0
	internal void <ThrowAsync>b__7_1(object state) { }
}

// Namespace: System.Runtime.CompilerServices
internal struct AsyncMethodBuilderCore // TypeDefIndex: 4064
{
	// Fields
	internal IAsyncStateMachine m_stateMachine; // 0x0
	internal Action m_defaultContextAction; // 0x8

	// Methods

	// RVA: 0x1675B00 Offset: 0x1674D00 VA: 0x181675B00
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: 0x16755D0 Offset: 0x16747D0 VA: 0x1816755D0
	internal Action GetCompletionAction(Task taskForTracing, ref AsyncMethodBuilderCore.MoveNextRunner runnerToInitialize) { }

	// RVA: 0x1675790 Offset: 0x1674990 VA: 0x181675790
	private Action OutputAsyncCausalityEvents(Task innerTask, Action continuation) { }

	// RVA: 0x1675940 Offset: 0x1674B40 VA: 0x181675940
	internal void PostBoxInitialization(IAsyncStateMachine stateMachine, AsyncMethodBuilderCore.MoveNextRunner runner, Task builtTask) { }

	// RVA: 0x1675BD0 Offset: 0x1674DD0 VA: 0x181675BD0
	internal static void ThrowAsync(Exception exception, SynchronizationContext targetContext) { }

	// RVA: 0x16754A0 Offset: 0x16746A0 VA: 0x1816754A0
	internal static Action CreateContinuationWrapper(Action continuation, Action invokeAction, Task innerTask) { }

	// RVA: 0x1675E70 Offset: 0x1675070 VA: 0x181675E70
	internal static Task TryGetContinuationTask(Action action) { }
}

// Namespace: System.Runtime.CompilerServices
[Serializable]
public enum LoadHint // TypeDefIndex: 4065
{
	// Fields
	public int value__; // 0x0
	public const LoadHint Default = 0;
	public const LoadHint Always = 1;
	public const LoadHint Sometimes = 2;
}

// Namespace: System.Runtime.CompilerServices
[Usage(1)]
[Serializable]
public sealed class DefaultDependencyAttribute : Attribute // TypeDefIndex: 4066
{
	// Fields
	private LoadHint loadHint; // 0x10

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	public void .ctor(LoadHint loadHintArgument) { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(1, AllowMultiple = True)]
[Serializable]
public sealed class DependencyAttribute : Attribute // TypeDefIndex: 4067
{
	// Fields
	private string dependentAssembly; // 0x10
	private LoadHint loadHint; // 0x18

	// Methods

	// RVA: 0x16774B0 Offset: 0x16766B0 VA: 0x1816774B0
	public void .ctor(string dependentAssemblyArgument, LoadHint loadHintArgument) { }
}

// Namespace: System.Runtime.CompilerServices
[Flags]
[ComVisible(True)]
[Serializable]
public enum CompilationRelaxations // TypeDefIndex: 4068
{
	// Fields
	public int value__; // 0x0
	public const CompilationRelaxations NoStringInterning = 8;
}

// Namespace: System.Runtime.CompilerServices
[Usage(71)]
[ComVisible(True)]
[Serializable]
public class CompilationRelaxationsAttribute : Attribute // TypeDefIndex: 4069
{
	// Fields
	private int m_relaxations; // 0x10

	// Properties
	public int CompilationRelaxations { get; }

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	public void .ctor(int relaxations) { }

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	public void .ctor(CompilationRelaxations relaxations) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_CompilationRelaxations() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(1, AllowMultiple = True, Inherited = False)]
public sealed class InternalsVisibleToAttribute : Attribute // TypeDefIndex: 4070
{
	// Fields
	private string _assemblyName; // 0x10
	private bool _allInternalsVisible; // 0x18

	// Properties
	public bool AllInternalsVisible { set; }

	// Methods

	// RVA: 0x167A650 Offset: 0x1679850 VA: 0x18167A650
	public void .ctor(string assemblyName) { }

	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	public void set_AllInternalsVisible(bool value) { }
}

// Namespace: System.Runtime.CompilerServices
[FriendAccessAllowed]
[Usage(2044, AllowMultiple = False, Inherited = False)]
internal sealed class FriendAccessAllowedAttribute : Attribute // TypeDefIndex: 4071
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(1036, AllowMultiple = True, Inherited = False)]
internal sealed class TypeDependencyAttribute : Attribute // TypeDefIndex: 4072
{
	// Fields
	private string typeName; // 0x10

	// Methods

	// RVA: 0x168E770 Offset: 0x168D970 VA: 0x18168E770
	public void .ctor(string typeName) { }
}

// Namespace: System.Runtime.CompilerServices
internal static class JitHelpers // TypeDefIndex: 4073
{
	// Methods

	// RVA: -1 Offset: -1
	internal static T UnsafeCast<T>(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA26270 Offset: 0xA25470 VA: 0x180A26270
	|-JitHelpers.UnsafeCast<object>
	*/

	// RVA: -1 Offset: -1
	internal static int UnsafeEnumCast<T>(T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA26350 Offset: 0xA25550 VA: 0x180A26350
	|-JitHelpers.UnsafeEnumCast<ByteEnum>
	|
	|-RVA: 0xA26430 Offset: 0xA25630 VA: 0x180A26430
	|-JitHelpers.UnsafeEnumCast<Int32Enum>
	|
	|-RVA: 0xA26470 Offset: 0xA25670 VA: 0x180A26470
	|-JitHelpers.UnsafeEnumCast<UInt16Enum>
	|
	|-RVA: 0xA26390 Offset: 0xA25590 VA: 0x180A26390
	|-JitHelpers.UnsafeEnumCast<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	internal static long UnsafeEnumCastLong<T>(T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA262B0 Offset: 0xA254B0 VA: 0x180A262B0
	|-JitHelpers.UnsafeEnumCastLong<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: System.Runtime.CompilerServices
internal struct Ephemeron // TypeDefIndex: 4074
{
	// Fields
	internal object key; // 0x0
	internal object value; // 0x8
}

// Namespace: 
public sealed class ConditionalWeakTable.CreateValueCallback<TKey, TValue> : MulticastDelegate // TypeDefIndex: 4075
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB60A10 Offset: 0xB5FC10 VA: 0x180B60A10
	|-ConditionalWeakTable.CreateValueCallback<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TValue Invoke(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250
	|-ConditionalWeakTable.CreateValueCallback<object, object>.Invoke
	*/
}

// Namespace: 
private sealed class ConditionalWeakTable.Enumerator<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator // TypeDefIndex: 4076
{
	// Fields
	private ConditionalWeakTable<TKey, TValue> _table; // 0x0
	private int _currentIndex; // 0x0
	private KeyValuePair<TKey, TValue> _current; // 0x0

	// Properties
	public KeyValuePair<TKey, TValue> Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ConditionalWeakTable<TKey, TValue> table) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112CEB0 Offset: 0x112C0B0 VA: 0x18112CEB0
	|-ConditionalWeakTable.Enumerator<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1126F70 Offset: 0x1126170 VA: 0x181126F70
	|-ConditionalWeakTable.Enumerator<object, object>.Finalize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1126BC0 Offset: 0x1125DC0 VA: 0x181126BC0
	|-ConditionalWeakTable.Enumerator<object, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1127440 Offset: 0x1126640 VA: 0x181127440
	|-ConditionalWeakTable.Enumerator<object, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public KeyValuePair<TKey, TValue> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112D500 Offset: 0x112C700 VA: 0x18112D500
	|-ConditionalWeakTable.Enumerator<object, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112A480 Offset: 0x1129680 VA: 0x18112A480
	|-ConditionalWeakTable.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-ConditionalWeakTable.Enumerator<object, object>.Reset
	*/
}

// Namespace: System.Runtime.CompilerServices
public sealed class ConditionalWeakTable<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable // TypeDefIndex: 4077
{
	// Fields
	private const int INITIAL_SIZE = 13;
	private const float LOAD_FACTOR = 0,7;
	private const float COMPACT_FACTOR = 0,5;
	private const float EXPAND_FACTOR = 1,1;
	private Ephemeron[] data; // 0x0
	private object _lock; // 0x0
	private int size; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB6FF0 Offset: 0xFB61F0 VA: 0x180FB6FF0
	|-ConditionalWeakTable<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB6180 Offset: 0xFB5380 VA: 0x180FB6180
	|-ConditionalWeakTable<object, object>.Finalize
	*/

	// RVA: -1 Offset: -1
	private void RehashWithoutResize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB63B0 Offset: 0xFB55B0 VA: 0x180FB63B0
	|-ConditionalWeakTable<object, object>.RehashWithoutResize
	*/

	// RVA: -1 Offset: -1
	private void RecomputeSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB6350 Offset: 0xFB5550 VA: 0x180FB6350
	|-ConditionalWeakTable<object, object>.RecomputeSize
	*/

	// RVA: -1 Offset: -1
	private void Rehash() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB65F0 Offset: 0xFB57F0 VA: 0x180FB65F0
	|-ConditionalWeakTable<object, object>.Rehash
	*/

	// RVA: -1 Offset: -1
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB5E50 Offset: 0xFB5050 VA: 0x180FB5E50
	|-ConditionalWeakTable<object, object>.Add
	*/

	// RVA: -1 Offset: -1
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB6940 Offset: 0xFB5B40 VA: 0x180FB6940
	|-ConditionalWeakTable<object, object>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB6D60 Offset: 0xFB5F60 VA: 0x180FB6D60
	|-ConditionalWeakTable<object, object>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public TValue GetValue(TKey key, ConditionalWeakTable.CreateValueCallback<TKey, TValue> createValueCallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB61D0 Offset: 0xFB53D0 VA: 0x180FB61D0
	|-ConditionalWeakTable<object, object>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFB6BD0 Offset: 0xFB5DD0 VA: 0x180FB6BD0
	|-ConditionalWeakTable<object, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCD13A0 Offset: 0xCD05A0 VA: 0x180CD13A0
	|-ConditionalWeakTable<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: System.Runtime.CompilerServices
public static class RuntimeHelpers // TypeDefIndex: 4078
{
	// Properties
	public static int OffsetToStringData { get; }

	// Methods

	// RVA: 0x168AE90 Offset: 0x168A090 VA: 0x18168AE90
	private static void InitializeArray(Array array, IntPtr fldHandle) { }

	// RVA: 0x168AE10 Offset: 0x168A010 VA: 0x18168AE10
	public static void InitializeArray(Array array, RuntimeFieldHandle fldHandle) { }

	// RVA: 0x168AF40 Offset: 0x168A140 VA: 0x18168AF40
	public static int get_OffsetToStringData() { }

	// RVA: 0x15C9510 Offset: 0x15C8710 VA: 0x1815C9510
	public static int GetHashCode(object o) { }

	// RVA: 0x168AE00 Offset: 0x168A000 VA: 0x18168AE00
	public static object GetObjectValue(object obj) { }

	// RVA: 0x168AEA0 Offset: 0x168A0A0 VA: 0x18168AEA0
	private static void RunClassConstructor(IntPtr type) { }

	// RVA: 0x168AEB0 Offset: 0x168A0B0 VA: 0x18168AEB0
	public static void RunClassConstructor(RuntimeTypeHandle type) { }

	// RVA: 0x1679DF0 Offset: 0x1678FF0 VA: 0x181679DF0
	private static bool SufficientExecutionStack() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x168ADA0 Offset: 0x1689FA0 VA: 0x18168ADA0
	public static void EnsureSufficientExecutionStack() { }

	// RVA: 0x1679DF0 Offset: 0x1678FF0 VA: 0x181679DF0
	public static bool TryEnsureSufficientExecutionStack() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void PrepareConstrainedRegions() { }

	// RVA: -1 Offset: -1
	public static bool IsReferenceOrContainsReferences<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA69DF0 Offset: 0xA68FF0 VA: 0x180A69DF0
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ArraySegment<byte>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<AsyncOperationHandle<object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DynamicHeightVirtualizationController.ContentHeightCacheInfo<object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<byte, int>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<DiscardReasonWithCategory, int>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<DiscardReasonWithCategory, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<int, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<object, char>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<object, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<object, ulong>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<PropertyName, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<Rect, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NativeArray<ConvertMeshJobData>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NativeArray<CopyClosingMeshJobData>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NativeArray<NudgeJobData>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NativeSlice<ConvertMeshJobData>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NativeSlice<CopyClosingMeshJobData>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<NativeSlice<NudgeJobData>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TempAllocator.Page<ushort>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TempAllocator.Page<Vertex>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RefAsValueType<object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SequenceBuffer.SequencedData<VentilationSystem.VentMoveInfo, VentilationSystem.VentMoveInfo>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StructMultiKey<object, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TreeViewItemData<object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<int, int>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<Int32Enum, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<IntPtr, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<object, object>>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<AnimatorClipInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Announcement>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<AsyncOperationHandle>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BoneWeight>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<bool>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<byte>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ByteEnum>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<CancellationToken>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<char>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Color>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Color32>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ComputedStyle>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ComputedTransitionProperty>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ContactPoint2D>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ControllerPollingInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ControllerTemplateElementTarget>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DataRecordInternal>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DateTime>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DateTimeOffset>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DebugLogMessage>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Decimal>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DetectiveSuspect>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DiagnosticEvent>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DiscardReasonWithCategory>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<double>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<EasingFunction>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Edge>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ElementAssignmentConflictInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Entitlement>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Entitlement>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<EnumData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ExternalAccountInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<FileStat>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<GameListing>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<GlyphPairAdjustmentRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<GlyphRect>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Guid>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<HatOptions>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<HttpStatusCodeRange>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<IngestData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<InputActionSourceData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<short>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<int>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Int32Enum>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<long>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<IntPtr>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<IntVec3>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<InterpretedFrameInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ItemOwnershipInternal>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<JsonElement>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<JsonEncodedText>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<JsonPosition>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<LigatureSubstitutionRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MNJcwvoQkulZtllpaHFcSdphQVOi>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ManipulatorActivationFilter>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MarkToBaseAdjustmentRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MarkToMarkAdjustmentRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Matrix4x4>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ModIdentifierInternal>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MultipleSubstitutionRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<object>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ObjectInitializationData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<OptionInternal>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ParameterRef>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ParticipantMetadataInternal>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<PhysicsShape2D>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<PlayerLoopSystem>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<PlayerLoopSystemInternal>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<PlayerStatInfoInternal>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<PropertyRef>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Quaternion>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RangePositionInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RaycastHit2D>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RaycastResult>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ReadStackFrame>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Rect>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Relationship>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RenderInstancedDataLayout>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Resolution>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ResourceLocator>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RoleRate>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RuleMatcher>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RulesCategory>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<sbyte>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SandboxIdItemOwnershipInternal>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SelectorMatchRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<float>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SkinOptions>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Sku>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SslApplicationProtocol>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StatThresholdsInternal>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StylePropertyName>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StylePropertyValue>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StyleSelectorPart>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StyleSyntaxToken>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StyleValue>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StyleValueManaged>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StyleVariable>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SubMeshDescriptor>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SubString>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TerrainTileCoord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TextureId>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TimeSpan>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TimeValue>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TreeItem>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TreeViewItemWrapper>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TypeWrapper>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UICharInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UILineInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UIVertex>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ushort>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UInt16Enum>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<uint>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ulong>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<User>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Vector2>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Vector3>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Vector3Int>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Vector4>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<VertexAttributeDescriptor>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<VisorOptions>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Win32_IP_ADAPTER_ADDRESSES>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Win32_IP_ADAPTER_INFO>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<WriteStackFrame>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<X509ChainStatus>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<XPathNodeRef>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<XSXSubmitGraphicsCommandsDataCommandInternal>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<XboxOneGDKSubmitGraphicsCommandsDataCommandInternal>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<__Il2CppFullySharedGenericType>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<jvalue>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<AchievementManager.AchievementProgressValue>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BaseStyleMatcher.MatchContext>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BeforeRenderHelper.OrderBlock>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BitmapAllocator32.Page>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Camera.RenderRequest>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<CreditsController.CreditStruct>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<CreditsController.FormatStruct>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<CustomController.CZxNqDPSLSmjvjcEzpoKeadUPlaM>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DelayedActionManager.DelegateInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DtlsUnityConnection.FragmentRange>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DtlsUnityConnection.QueuedAppData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<EventDispatcher.DispatchContext>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<EventDispatcher.EventRecord>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<EventInterestReflectionUtils.DefaultEventInterests>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.YkJYhIwKoTBpWKATiflrEgjLfZIX>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.fcJeYwLvuogcmgGamTgYErdESsqW>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<FocusController.FocusedElement>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<HardwareControllerTemplateMap.rwEetQoHfXcCclqvIDEVKbecRXpDb>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<HeliSabotageSystem.ActiveConsoleData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Helper.Allocation>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Helper.PinnedBuffer>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MemberRelationshipService.RelationshipEntry>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MultiColumnCollectionHeader.SortedColumnState>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MushroomMixupSabotageSystem.CondensedOutfit>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<PZVoNXqAhLHAMSWUdEitcRuLGMcmA.LxbGihMOwQSEjsHzfBQtamHgcTraA>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ParticleSystem.Particle>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<QRCodeGenerator.AlignmentPattern>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<QRCodeGenerator.Antilog>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<QRCodeGenerator.CodewordBlock>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<QRCodeGenerator.ECCInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<QRCodeGenerator.PolynomItem>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<QRCodeGenerator.VersionInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<QRCodeGenerator.VersionInfoDetails>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RadialMenu.CachedButtonObject>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Regex.CachedCodeEntryKey>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RegexCharClass.SingleRange>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RenderChain.RenderNodeData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ResourceManager.DeferredCallbackRegisterRequest>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SecurityLogBehaviour.SecurityLogEntry>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SequenceNode.SequenceConstructPosContext>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ServerManager.PingWrapper>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StyleComplexSelector.PseudoStateData>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StylePropertyAnimationSystem.ElementPropertyPair>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StyleSheetCache.SheetHandleKey>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<StyleVariableResolver.ResolveContext>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TemplateAsset.AttributeOverride>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TextResourceManager.FontAssetRef>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TextSettings.FontReferenceMap>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TextureBlitter.BlitInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TexturePacker_JsonArray.Frame>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TextureRegistry.TextureInfo>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UIRStylePainter.Entry>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UIRStylePainter.RepeatRectUV>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UIRenderDevice.AllocToFree>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UIRenderDevice.AllocToUpdate>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UnitySynchronizationContext.WorkRequest>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UnityUITextMeshProGlyphHelper.GlyphOrText>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<VirtualHeap.PinnedBlob>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<VisualTreeAsset.AssetEntry>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<VisualTreeAsset.SlotDefinition>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<VisualTreeAsset.SlotUsageEntry>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<VisualTreeAsset.UsingEntry>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<VisualTreeAsset.UxmlObjectEntry>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<XboxOneInputSource.aTKmDsEGifKjlXcaJEDpFPOnOkdn>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<XjXmgYEoXluUbKoyNCodoxJzPrjJ.FSjxKnkodQibKwPtFNBnKKATQeux>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BindingRestrictions.TestBuilder.AndNode>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<InstructionList.DebugView.InstructionView>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MultiColumnCollectionHeader.ViewState.ColumnState>
	|-RuntimeHelpers.IsReferenceOrContainsReferences<PlayerController.Element.TBnjpqFyveWLFptREPetgdFmwyCWA>
	*/
}

// Namespace: System.Runtime.CompilerServices
internal static class Unsafe // TypeDefIndex: 4079
{
	// Methods

	// RVA: -1 Offset: -1
	public static ref T Add<T>(ref T source, int elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA0950 Offset: 0xA9FB50 VA: 0x180AA0950
	|-Unsafe.Add<ArraySegment<byte>>
	|-Unsafe.Add<KeyValuePair<int, object>>
	|-Unsafe.Add<KeyValuePair<object, char>>
	|-Unsafe.Add<KeyValuePair<object, object>>
	|-Unsafe.Add<KeyValuePair<object, ulong>>
	|-Unsafe.Add<KeyValuePair<PropertyName, object>>
	|-Unsafe.Add<NativeArray<ConvertMeshJobData>>
	|-Unsafe.Add<NativeArray<CopyClosingMeshJobData>>
	|-Unsafe.Add<NativeArray<NudgeJobData>>
	|-Unsafe.Add<NativeSlice<ConvertMeshJobData>>
	|-Unsafe.Add<NativeSlice<CopyClosingMeshJobData>>
	|-Unsafe.Add<NativeSlice<NudgeJobData>>
	|-Unsafe.Add<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>
	|-Unsafe.Add<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>
	|-Unsafe.Add<StructMultiKey<object, object>>
	|-Unsafe.Add<ValueTuple<object, object>>
	|-Unsafe.Add<Color>
	|-Unsafe.Add<ControllerTemplateElementTarget>
	|-Unsafe.Add<DateTimeOffset>
	|-Unsafe.Add<Decimal>
	|-Unsafe.Add<DetectiveSuspect>
	|-Unsafe.Add<DiscardReasonWithCategory>
	|-Unsafe.Add<GlyphRect>
	|-Unsafe.Add<Guid>
	|-Unsafe.Add<IngestData>
	|-Unsafe.Add<InterpretedFrameInfo>
	|-Unsafe.Add<JsonElement>
	|-Unsafe.Add<JsonEncodedText>
	|-Unsafe.Add<LigatureSubstitutionRecord>
	|-Unsafe.Add<MultipleSubstitutionRecord>
	|-Unsafe.Add<Quaternion>
	|-Unsafe.Add<RangePositionInfo>
	|-Unsafe.Add<Rect>
	|-Unsafe.Add<Resolution>
	|-Unsafe.Add<RuleMatcher>
	|-Unsafe.Add<RulesCategory>
	|-Unsafe.Add<SslApplicationProtocol>
	|-Unsafe.Add<StylePropertyName>
	|-Unsafe.Add<StylePropertyValue>
	|-Unsafe.Add<StyleValueManaged>
	|-Unsafe.Add<SubString>
	|-Unsafe.Add<UILineInfo>
	|-Unsafe.Add<Vector4>
	|-Unsafe.Add<VertexAttributeDescriptor>
	|-Unsafe.Add<X509ChainStatus>
	|-Unsafe.Add<XSXSubmitGraphicsCommandsDataCommandInternal>
	|-Unsafe.Add<XboxOneGDKSubmitGraphicsCommandsDataCommandInternal>
	|-Unsafe.Add<AchievementManager.AchievementProgressValue>
	|-Unsafe.Add<BeforeRenderHelper.OrderBlock>
	|-Unsafe.Add<CreditsController.CreditStruct>
	|-Unsafe.Add<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.YkJYhIwKoTBpWKATiflrEgjLfZIX>
	|-Unsafe.Add<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.fcJeYwLvuogcmgGamTgYErdESsqW>
	|-Unsafe.Add<FocusController.FocusedElement>
	|-Unsafe.Add<HardwareControllerTemplateMap.rwEetQoHfXcCclqvIDEVKbecRXpDb>
	|-Unsafe.Add<MultiColumnCollectionHeader.SortedColumnState>
	|-Unsafe.Add<PZVoNXqAhLHAMSWUdEitcRuLGMcmA.LxbGihMOwQSEjsHzfBQtamHgcTraA>
	|-Unsafe.Add<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|-Unsafe.Add<QRCodeGenerator.AlignmentPattern>
	|-Unsafe.Add<QRCodeGenerator.VersionInfo>
	|-Unsafe.Add<QRCodeGenerator.VersionInfoDetails>
	|-Unsafe.Add<ResourceManager.DeferredCallbackRegisterRequest>
	|-Unsafe.Add<ServerManager.PingWrapper>
	|-Unsafe.Add<TextSettings.FontReferenceMap>
	|-Unsafe.Add<TextureRegistry.TextureInfo>
	|-Unsafe.Add<VisualTreeAsset.SlotDefinition>
	|-Unsafe.Add<VisualTreeAsset.SlotUsageEntry>
	|-Unsafe.Add<VisualTreeAsset.UxmlObjectEntry>
	|-Unsafe.Add<XjXmgYEoXluUbKoyNCodoxJzPrjJ.FSjxKnkodQibKwPtFNBnKKATQeux>
	|-Unsafe.Add<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0xAA0980 Offset: 0xA9FB80 VA: 0x180AA0980
	|-Unsafe.Add<KeyValuePair<byte, int>>
	|-Unsafe.Add<ValueTuple<int, int>>
	|-Unsafe.Add<AnimatorClipInfo>
	|-Unsafe.Add<CancellationToken>
	|-Unsafe.Add<DateTime>
	|-Unsafe.Add<double>
	|-Unsafe.Add<Edge>
	|-Unsafe.Add<HttpStatusCodeRange>
	|-Unsafe.Add<long>
	|-Unsafe.Add<IntPtr>
	|-Unsafe.Add<object>
	|-Unsafe.Add<TimeSpan>
	|-Unsafe.Add<TimeValue>
	|-Unsafe.Add<ulong>
	|-Unsafe.Add<Vector2>
	|-Unsafe.Add<jvalue>
	|-Unsafe.Add<BitmapAllocator32.Page>
	|-Unsafe.Add<DtlsUnityConnection.FragmentRange>
	|-Unsafe.Add<QRCodeGenerator.Antilog>
	|-Unsafe.Add<QRCodeGenerator.PolynomItem>
	|-Unsafe.Add<SecurityLogBehaviour.SecurityLogEntry>
	|-Unsafe.Add<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>
	|
	|-RVA: 0xAA09B0 Offset: 0xA9FBB0 VA: 0x180AA09B0
	|-Unsafe.Add<KeyValuePair<DiscardReasonWithCategory, int>>
	|-Unsafe.Add<KeyValuePair<DiscardReasonWithCategory, object>>
	|-Unsafe.Add<KeyValuePair<Rect, object>>
	|-Unsafe.Add<TempAllocator.Page<ushort>>
	|-Unsafe.Add<TempAllocator.Page<Vertex>>
	|-Unsafe.Add<AsyncOperationHandle>
	|-Unsafe.Add<ComputedTransitionProperty>
	|-Unsafe.Add<DataRecordInternal>
	|-Unsafe.Add<DebugLogMessage>
	|-Unsafe.Add<Entitlement>
	|-Unsafe.Add<FileStat>
	|-Unsafe.Add<InputActionSourceData>
	|-Unsafe.Add<ItemOwnershipInternal>
	|-Unsafe.Add<JsonPosition>
	|-Unsafe.Add<MarkToBaseAdjustmentRecord>
	|-Unsafe.Add<MarkToMarkAdjustmentRecord>
	|-Unsafe.Add<OptionInternal>
	|-Unsafe.Add<ParameterRef>
	|-Unsafe.Add<ParticipantMetadataInternal>
	|-Unsafe.Add<PlayerStatInfoInternal>
	|-Unsafe.Add<PropertyRef>
	|-Unsafe.Add<SandboxIdItemOwnershipInternal>
	|-Unsafe.Add<SelectorMatchRecord>
	|-Unsafe.Add<StatThresholdsInternal>
	|-Unsafe.Add<StyleSelectorPart>
	|-Unsafe.Add<StyleSyntaxToken>
	|-Unsafe.Add<StyleValue>
	|-Unsafe.Add<StyleVariable>
	|-Unsafe.Add<TreeViewItemWrapper>
	|-Unsafe.Add<Camera.RenderRequest>
	|-Unsafe.Add<CreditsController.FormatStruct>
	|-Unsafe.Add<TemplateAsset.AttributeOverride>
	|-Unsafe.Add<UnitySynchronizationContext.WorkRequest>
	|-Unsafe.Add<UnityUITextMeshProGlyphHelper.GlyphOrText>
	|-Unsafe.Add<VisualTreeAsset.UsingEntry>
	|
	|-RVA: 0xAA09A0 Offset: 0xA9FBA0 VA: 0x180AA09A0
	|-Unsafe.Add<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>
	|-Unsafe.Add<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>
	|-Unsafe.Add<BoneWeight>
	|-Unsafe.Add<TypeWrapper>
	|-Unsafe.Add<DelayedActionManager.DelegateInfo>
	|-Unsafe.Add<QRCodeGenerator.ECCInfo>
	|-Unsafe.Add<UIRStylePainter.RepeatRectUV>
	|-Unsafe.Add<VisualTreeAsset.AssetEntry>
	|-Unsafe.Add<InstructionList.DebugView.InstructionView>
	|-Unsafe.Add<MultiColumnCollectionHeader.ViewState.ColumnState>
	|
	|-RVA: 0xAA09E0 Offset: 0xA9FBE0 VA: 0x180AA09E0
	|-Unsafe.Add<SequenceBuffer.SequencedData<VentilationSystem.VentMoveInfo, VentilationSystem.VentMoveInfo>>
	|-Unsafe.Add<ManipulatorActivationFilter>
	|-Unsafe.Add<UICharInfo>
	|-Unsafe.Add<Vector3>
	|-Unsafe.Add<Vector3Int>
	|-Unsafe.Add<CustomController.CZxNqDPSLSmjvjcEzpoKeadUPlaM>
	|-Unsafe.Add<PlayerController.Element.TBnjpqFyveWLFptREPetgdFmwyCWA>
	|
	|-RVA: 0xAA0990 Offset: 0xA9FB90 VA: 0x180AA0990
	|-Unsafe.Add<Announcement>
	|-Unsafe.Add<Matrix4x4>
	|-Unsafe.Add<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0xAA09D0 Offset: 0xA9FBD0 VA: 0x180AA09D0
	|-Unsafe.Add<bool>
	|-Unsafe.Add<byte>
	|-Unsafe.Add<ByteEnum>
	|-Unsafe.Add<sbyte>
	|
	|-RVA: 0xAA0A00 Offset: 0xA9FC00 VA: 0x180AA0A00
	|-Unsafe.Add<char>
	|-Unsafe.Add<short>
	|-Unsafe.Add<ushort>
	|-Unsafe.Add<UInt16Enum>
	|
	|-RVA: 0xAA0A30 Offset: 0xA9FC30 VA: 0x180AA0A30
	|-Unsafe.Add<Color32>
	|-Unsafe.Add<EasingFunction>
	|-Unsafe.Add<int>
	|-Unsafe.Add<Int32Enum>
	|-Unsafe.Add<float>
	|-Unsafe.Add<uint>
	|-Unsafe.Add<RegexCharClass.SingleRange>
	|
	|-RVA: 0xAA09C0 Offset: 0xA9FBC0 VA: 0x180AA09C0
	|-Unsafe.Add<ContactPoint2D>
	|-Unsafe.Add<ControllerPollingInfo>
	|-Unsafe.Add<ExternalAccountInfo>
	|-Unsafe.Add<TextureBlitter.BlitInfo>
	|
	|-RVA: 0xAA0A20 Offset: 0xA9FC20 VA: 0x180AA0A20
	|-Unsafe.Add<DiagnosticEvent>
	|-Unsafe.Add<ModIdentifierInternal>
	|-Unsafe.Add<ObjectInitializationData>
	|-Unsafe.Add<Relationship>
	|-Unsafe.Add<SubMeshDescriptor>
	|-Unsafe.Add<QRCodeGenerator.CodewordBlock>
	|
	|-RVA: 0xAA0A40 Offset: 0xA9FC40 VA: 0x180AA0A40
	|-Unsafe.Add<ElementAssignmentConflictInfo>
	|-Unsafe.Add<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0xAA0960 Offset: 0xA9FB60 VA: 0x180AA0960
	|-Unsafe.Add<Entitlement>
	|-Unsafe.Add<PhysicsShape2D>
	|-Unsafe.Add<PlayerLoopSystem>
	|-Unsafe.Add<PlayerLoopSystemInternal>
	|-Unsafe.Add<Sku>
	|-Unsafe.Add<User>
	|-Unsafe.Add<UIRenderDevice.AllocToFree>
	|
	|-RVA: 0xAA0970 Offset: 0xA9FB70 VA: 0x180AA0970
	|-Unsafe.Add<GameListing>
	|-Unsafe.Add<RaycastResult>
	|-Unsafe.Add<WriteStackFrame>
	|-Unsafe.Add<UIRStylePainter.Entry>
	|-Unsafe.Add<UIRenderDevice.AllocToUpdate>
	|
	|-RVA: 0xAA0B60 Offset: 0xA9FD60 VA: 0x180AA0B60
	|-Unsafe.Add<RaycastHit2D>
	|
	|-RVA: 0xAA0B70 Offset: 0xA9FD70 VA: 0x180AA0B70
	|-Unsafe.Add<ReadStackFrame>
	|
	|-RVA: 0xAA0B90 Offset: 0xA9FD90 VA: 0x180AA0B90
	|-Unsafe.Add<UIVertex>
	|
	|-RVA: 0xAA0BA0 Offset: 0xA9FDA0 VA: 0x180AA0BA0
	|-Unsafe.Add<Win32_IP_ADAPTER_ADDRESSES>
	|
	|-RVA: 0xAA0BB0 Offset: 0xA9FDB0 VA: 0x180AA0BB0
	|-Unsafe.Add<Win32_IP_ADAPTER_INFO>
	|
	|-RVA: 0xAA0AA0 Offset: 0xA9FCA0 VA: 0x180AA0AA0
	|-Unsafe.Add<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xAA0BC0 Offset: 0xA9FDC0 VA: 0x180AA0BC0
	|-Unsafe.Add<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>
	|
	|-RVA: 0xAA0B50 Offset: 0xA9FD50 VA: 0x180AA0B50
	|-Unsafe.Add<ParticleSystem.Particle>
	|
	|-RVA: 0xAA09F0 Offset: 0xA9FBF0 VA: 0x180AA09F0
	|-Unsafe.Add<RadialMenu.CachedButtonObject>
	|
	|-RVA: 0xAA0B80 Offset: 0xA9FD80 VA: 0x180AA0B80
	|-Unsafe.Add<RenderChain.RenderNodeData>
	*/

	// RVA: -1 Offset: -1
	public static ref T Add<T>(ref T source, IntPtr elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA08C0 Offset: 0xA9FAC0 VA: 0x180AA08C0
	|-Unsafe.Add<byte>
	|
	|-RVA: 0xAA0A10 Offset: 0xA9FC10 VA: 0x180AA0A10
	|-Unsafe.Add<char>
	|
	|-RVA: 0xAA0B40 Offset: 0xA9FD40 VA: 0x180AA0B40
	|-Unsafe.Add<IntPtr>
	|
	|-RVA: 0xAA0AF0 Offset: 0xA9FCF0 VA: 0x180AA0AF0
	|-Unsafe.Add<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void* Add<T>(void* source, int elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA09D0 Offset: 0xA9FBD0 VA: 0x180AA09D0
	|-Unsafe.Add<byte>
	|
	|-RVA: 0xAA0A00 Offset: 0xA9FC00 VA: 0x180AA0A00
	|-Unsafe.Add<char>
	|
	|-RVA: 0xAA0A50 Offset: 0xA9FC50 VA: 0x180AA0A50
	|-Unsafe.Add<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ref T AddByteOffset<T>(ref T source, IntPtr byteOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA08C0 Offset: 0xA9FAC0 VA: 0x180AA08C0
	|-Unsafe.AddByteOffset<byte>
	|-Unsafe.AddByteOffset<char>
	|-Unsafe.AddByteOffset<int>
	|-Unsafe.AddByteOffset<object>
	|-Unsafe.AddByteOffset<Quaternion>
	|-Unsafe.AddByteOffset<ushort>
	|-Unsafe.AddByteOffset<uint>
	|-Unsafe.AddByteOffset<Vector3>
	|-Unsafe.AddByteOffset<__Il2CppFullySharedGenericType>
	|-Unsafe.AddByteOffset<jvalue>
	*/

	// RVA: -1 Offset: -1
	public static bool AreSame<T>(ref T left, ref T right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA0BD0 Offset: 0xA9FDD0 VA: 0x180AA0BD0
	|-Unsafe.AreSame<byte>
	|-Unsafe.AreSame<char>
	|-Unsafe.AreSame<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T As<T>(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	|-Unsafe.As<object>
	*/

	// RVA: -1 Offset: -1
	public static ref TTo As<TFrom, TTo>(ref TFrom source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	|-Unsafe.As<Memory<byte>, ReadOnlyMemory<byte>>
	|-Unsafe.As<Memory<char>, ReadOnlyMemory<char>>
	|-Unsafe.As<ReadOnlyMemory<byte>, Memory<byte>>
	|-Unsafe.As<bool, Volatile.VolatileBoolean>
	|-Unsafe.As<byte, ArraySegment<byte>>
	|-Unsafe.As<byte, KeyValuePair<byte, int>>
	|-Unsafe.As<byte, KeyValuePair<DiscardReasonWithCategory, int>>
	|-Unsafe.As<byte, KeyValuePair<DiscardReasonWithCategory, object>>
	|-Unsafe.As<byte, KeyValuePair<int, object>>
	|-Unsafe.As<byte, KeyValuePair<object, char>>
	|-Unsafe.As<byte, KeyValuePair<object, object>>
	|-Unsafe.As<byte, KeyValuePair<object, ulong>>
	|-Unsafe.As<byte, KeyValuePair<PropertyName, object>>
	|-Unsafe.As<byte, KeyValuePair<Rect, object>>
	|-Unsafe.As<byte, NativeArray<ConvertMeshJobData>>
	|-Unsafe.As<byte, NativeArray<CopyClosingMeshJobData>>
	|-Unsafe.As<byte, NativeArray<NudgeJobData>>
	|-Unsafe.As<byte, NativeSlice<ConvertMeshJobData>>
	|-Unsafe.As<byte, NativeSlice<CopyClosingMeshJobData>>
	|-Unsafe.As<byte, NativeSlice<NudgeJobData>>
	|-Unsafe.As<byte, TempAllocator.Page<ushort>>
	|-Unsafe.As<byte, TempAllocator.Page<Vertex>>
	|-Unsafe.As<byte, IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>
	|-Unsafe.As<byte, IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>
	|-Unsafe.As<byte, IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>
	|-Unsafe.As<byte, IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>
	|-Unsafe.As<byte, SequenceBuffer.SequencedData<VentilationSystem.VentMoveInfo, VentilationSystem.VentMoveInfo>>
	|-Unsafe.As<byte, StructMultiKey<object, object>>
	|-Unsafe.As<byte, ValueTuple<int, int>>
	|-Unsafe.As<byte, ValueTuple<object, object>>
	|-Unsafe.As<byte, AnimatorClipInfo>
	|-Unsafe.As<byte, Announcement>
	|-Unsafe.As<byte, AsyncOperationHandle>
	|-Unsafe.As<byte, BoneWeight>
	|-Unsafe.As<byte, bool>
	|-Unsafe.As<byte, byte>
	|-Unsafe.As<byte, ByteEnum>
	|-Unsafe.As<byte, CancellationToken>
	|-Unsafe.As<byte, char>
	|-Unsafe.As<byte, Color>
	|-Unsafe.As<byte, Color32>
	|-Unsafe.As<byte, ComputedTransitionProperty>
	|-Unsafe.As<byte, ContactPoint2D>
	|-Unsafe.As<byte, ControllerPollingInfo>
	|-Unsafe.As<byte, ControllerTemplateElementTarget>
	|-Unsafe.As<byte, DataRecordInternal>
	|-Unsafe.As<byte, DateTime>
	|-Unsafe.As<byte, DateTimeOffset>
	|-Unsafe.As<byte, DebugLogMessage>
	|-Unsafe.As<byte, Decimal>
	|-Unsafe.As<byte, DetectiveSuspect>
	|-Unsafe.As<byte, DiagnosticEvent>
	|-Unsafe.As<byte, DiscardReasonWithCategory>
	|-Unsafe.As<byte, double>
	|-Unsafe.As<byte, EasingFunction>
	|-Unsafe.As<byte, Edge>
	|-Unsafe.As<byte, ElementAssignmentConflictInfo>
	|-Unsafe.As<byte, Entitlement>
	|-Unsafe.As<byte, Entitlement>
	|-Unsafe.As<byte, ExternalAccountInfo>
	|-Unsafe.As<byte, FileStat>
	|-Unsafe.As<byte, GameListing>
	|-Unsafe.As<byte, GlyphPairAdjustmentRecord>
	|-Unsafe.As<byte, GlyphRect>
	|-Unsafe.As<byte, Guid>
	|-Unsafe.As<byte, HttpStatusCodeRange>
	|-Unsafe.As<byte, IngestData>
	|-Unsafe.As<byte, InputActionSourceData>
	|-Unsafe.As<byte, short>
	|-Unsafe.As<byte, int>
	|-Unsafe.As<byte, Int32Enum>
	|-Unsafe.As<byte, long>
	|-Unsafe.As<byte, IntPtr>
	|-Unsafe.As<byte, InterpretedFrameInfo>
	|-Unsafe.As<byte, ItemOwnershipInternal>
	|-Unsafe.As<byte, JsonElement>
	|-Unsafe.As<byte, JsonEncodedText>
	|-Unsafe.As<byte, JsonPosition>
	|-Unsafe.As<byte, LigatureSubstitutionRecord>
	|-Unsafe.As<byte, ManipulatorActivationFilter>
	|-Unsafe.As<byte, MarkToBaseAdjustmentRecord>
	|-Unsafe.As<byte, MarkToMarkAdjustmentRecord>
	|-Unsafe.As<byte, Matrix4x4>
	|-Unsafe.As<byte, ModIdentifierInternal>
	|-Unsafe.As<byte, MultipleSubstitutionRecord>
	|-Unsafe.As<byte, object>
	|-Unsafe.As<byte, ObjectInitializationData>
	|-Unsafe.As<byte, OptionInternal>
	|-Unsafe.As<byte, ParameterRef>
	|-Unsafe.As<byte, ParticipantMetadataInternal>
	|-Unsafe.As<byte, PhysicsShape2D>
	|-Unsafe.As<byte, PlayerLoopSystem>
	|-Unsafe.As<byte, PlayerLoopSystemInternal>
	|-Unsafe.As<byte, PlayerStatInfoInternal>
	|-Unsafe.As<byte, PropertyRef>
	|-Unsafe.As<byte, Quaternion>
	|-Unsafe.As<byte, RangePositionInfo>
	|-Unsafe.As<byte, RaycastHit2D>
	|-Unsafe.As<byte, RaycastResult>
	|-Unsafe.As<byte, ReadStackFrame>
	|-Unsafe.As<byte, Rect>
	|-Unsafe.As<byte, Relationship>
	|-Unsafe.As<byte, Resolution>
	|-Unsafe.As<byte, RuleMatcher>
	|-Unsafe.As<byte, RulesCategory>
	|-Unsafe.As<byte, sbyte>
	|-Unsafe.As<byte, SandboxIdItemOwnershipInternal>
	|-Unsafe.As<byte, SelectorMatchRecord>
	|-Unsafe.As<byte, float>
	|-Unsafe.As<byte, Sku>
	|-Unsafe.As<byte, SslApplicationProtocol>
	|-Unsafe.As<byte, StatThresholdsInternal>
	|-Unsafe.As<byte, StylePropertyName>
	|-Unsafe.As<byte, StylePropertyValue>
	|-Unsafe.As<byte, StyleSelectorPart>
	|-Unsafe.As<byte, StyleSyntaxToken>
	|-Unsafe.As<byte, StyleValue>
	|-Unsafe.As<byte, StyleValueManaged>
	|-Unsafe.As<byte, StyleVariable>
	|-Unsafe.As<byte, SubMeshDescriptor>
	|-Unsafe.As<byte, SubString>
	|-Unsafe.As<byte, TimeSpan>
	|-Unsafe.As<byte, TimeValue>
	|-Unsafe.As<byte, TreeViewItemWrapper>
	|-Unsafe.As<byte, TypeWrapper>
	|-Unsafe.As<byte, UICharInfo>
	|-Unsafe.As<byte, UILineInfo>
	|-Unsafe.As<byte, UIVertex>
	|-Unsafe.As<byte, ushort>
	|-Unsafe.As<byte, UInt16Enum>
	|-Unsafe.As<byte, uint>
	|-Unsafe.As<byte, ulong>
	|-Unsafe.As<byte, User>
	|-Unsafe.As<byte, Vector2>
	|-Unsafe.As<byte, Vector3>
	|-Unsafe.As<byte, Vector3Int>
	|-Unsafe.As<byte, Vector4>
	|-Unsafe.As<byte, VertexAttributeDescriptor>
	|-Unsafe.As<byte, Win32_IP_ADAPTER_ADDRESSES>
	|-Unsafe.As<byte, Win32_IP_ADAPTER_INFO>
	|-Unsafe.As<byte, WriteStackFrame>
	|-Unsafe.As<byte, X509ChainStatus>
	|-Unsafe.As<byte, XSXSubmitGraphicsCommandsDataCommandInternal>
	|-Unsafe.As<byte, XboxOneGDKSubmitGraphicsCommandsDataCommandInternal>
	|-Unsafe.As<byte, jvalue>
	|-Unsafe.As<byte, AchievementManager.AchievementProgressValue>
	|-Unsafe.As<byte, BeforeRenderHelper.OrderBlock>
	|-Unsafe.As<byte, BitmapAllocator32.Page>
	|-Unsafe.As<byte, Camera.RenderRequest>
	|-Unsafe.As<byte, CreditsController.CreditStruct>
	|-Unsafe.As<byte, CreditsController.FormatStruct>
	|-Unsafe.As<byte, CustomController.CZxNqDPSLSmjvjcEzpoKeadUPlaM>
	|-Unsafe.As<byte, DelayedActionManager.DelegateInfo>
	|-Unsafe.As<byte, DtlsUnityConnection.FragmentRange>
	|-Unsafe.As<byte, FGmsSkeSnjpawgYuHoSaJQIhbMkIA.YkJYhIwKoTBpWKATiflrEgjLfZIX>
	|-Unsafe.As<byte, FGmsSkeSnjpawgYuHoSaJQIhbMkIA.fcJeYwLvuogcmgGamTgYErdESsqW>
	|-Unsafe.As<byte, FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>
	|-Unsafe.As<byte, FocusController.FocusedElement>
	|-Unsafe.As<byte, HardwareControllerTemplateMap.rwEetQoHfXcCclqvIDEVKbecRXpDb>
	|-Unsafe.As<byte, MultiColumnCollectionHeader.SortedColumnState>
	|-Unsafe.As<byte, PZVoNXqAhLHAMSWUdEitcRuLGMcmA.LxbGihMOwQSEjsHzfBQtamHgcTraA>
	|-Unsafe.As<byte, PackedPlayModeBuildLogs.RuntimeBuildLog>
	|-Unsafe.As<byte, ParticleSystem.Particle>
	|-Unsafe.As<byte, QRCodeGenerator.AlignmentPattern>
	|-Unsafe.As<byte, QRCodeGenerator.Antilog>
	|-Unsafe.As<byte, QRCodeGenerator.CodewordBlock>
	|-Unsafe.As<byte, QRCodeGenerator.ECCInfo>
	|-Unsafe.As<byte, QRCodeGenerator.PolynomItem>
	|-Unsafe.As<byte, QRCodeGenerator.VersionInfo>
	|-Unsafe.As<byte, QRCodeGenerator.VersionInfoDetails>
	|-Unsafe.As<byte, RadialMenu.CachedButtonObject>
	|-Unsafe.As<byte, RegexCharClass.SingleRange>
	|-Unsafe.As<byte, RenderChain.RenderNodeData>
	|-Unsafe.As<byte, ResourceManager.DeferredCallbackRegisterRequest>
	|-Unsafe.As<byte, SecurityLogBehaviour.SecurityLogEntry>
	|-Unsafe.As<byte, ServerManager.PingWrapper>
	|-Unsafe.As<byte, TemplateAsset.AttributeOverride>
	|-Unsafe.As<byte, TextSettings.FontReferenceMap>
	|-Unsafe.As<byte, TextureBlitter.BlitInfo>
	|-Unsafe.As<byte, TexturePacker_JsonArray.Frame>
	|-Unsafe.As<byte, TextureRegistry.TextureInfo>
	|-Unsafe.As<byte, UIRStylePainter.Entry>
	|-Unsafe.As<byte, UIRStylePainter.RepeatRectUV>
	|-Unsafe.As<byte, UIRenderDevice.AllocToFree>
	|-Unsafe.As<byte, UIRenderDevice.AllocToUpdate>
	|-Unsafe.As<byte, UnitySynchronizationContext.WorkRequest>
	|-Unsafe.As<byte, UnityUITextMeshProGlyphHelper.GlyphOrText>
	|-Unsafe.As<byte, VisualTreeAsset.AssetEntry>
	|-Unsafe.As<byte, VisualTreeAsset.SlotDefinition>
	|-Unsafe.As<byte, VisualTreeAsset.SlotUsageEntry>
	|-Unsafe.As<byte, VisualTreeAsset.UsingEntry>
	|-Unsafe.As<byte, VisualTreeAsset.UxmlObjectEntry>
	|-Unsafe.As<byte, XjXmgYEoXluUbKoyNCodoxJzPrjJ.FSjxKnkodQibKwPtFNBnKKATQeux>
	|-Unsafe.As<byte, XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|-Unsafe.As<byte, gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>
	|-Unsafe.As<byte, InstructionList.DebugView.InstructionView>
	|-Unsafe.As<byte, MultiColumnCollectionHeader.ViewState.ColumnState>
	|-Unsafe.As<byte, PlayerController.Element.TBnjpqFyveWLFptREPetgdFmwyCWA>
	|-Unsafe.As<char, byte>
	|-Unsafe.As<char, char>
	|-Unsafe.As<char, IntPtr>
	|-Unsafe.As<Decimal, Decimal.DecCalc>
	|-Unsafe.As<int, byte>
	|-Unsafe.As<int, char>
	|-Unsafe.As<int, IntPtr>
	|-Unsafe.As<int, uint>
	|-Unsafe.As<int, Volatile.VolatileInt32>
	|-Unsafe.As<long, ulong>
	|-Unsafe.As<object, byte>
	|-Unsafe.As<object, char>
	|-Unsafe.As<object, IntPtr>
	|-Unsafe.As<object, object>
	|-Unsafe.As<object, Volatile.VolatileObject>
	|-Unsafe.As<Quaternion, byte>
	|-Unsafe.As<Quaternion, char>
	|-Unsafe.As<Quaternion, IntPtr>
	|-Unsafe.As<ushort, byte>
	|-Unsafe.As<ushort, char>
	|-Unsafe.As<ushort, IntPtr>
	|-Unsafe.As<uint, byte>
	|-Unsafe.As<uint, char>
	|-Unsafe.As<uint, IntPtr>
	|-Unsafe.As<Vector3, byte>
	|-Unsafe.As<Vector3, char>
	|-Unsafe.As<Vector3, IntPtr>
	|-Unsafe.As<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	|-Unsafe.As<jvalue, byte>
	|-Unsafe.As<jvalue, char>
	|-Unsafe.As<jvalue, IntPtr>
	*/

	// RVA: -1 Offset: -1
	public static void* AsPointer<T>(ref T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	|-Unsafe.AsPointer<byte>
	|-Unsafe.AsPointer<char>
	|-Unsafe.AsPointer<object>
	|-Unsafe.AsPointer<__Il2CppFullySharedGenericType>
	|-Unsafe.AsPointer<Number.NumberBuffer.DigitsAndNullTerminator>
	*/

	// RVA: -1 Offset: -1
	public static ref T AsRef<T>(void* source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	|-Unsafe.AsRef<byte>
	|-Unsafe.AsRef<char>
	|-Unsafe.AsRef<int>
	|-Unsafe.AsRef<object>
	|-Unsafe.AsRef<Quaternion>
	|-Unsafe.AsRef<ushort>
	|-Unsafe.AsRef<uint>
	|-Unsafe.AsRef<Vector3>
	|-Unsafe.AsRef<__Il2CppFullySharedGenericType>
	|-Unsafe.AsRef<jvalue>
	*/

	// RVA: -1 Offset: -1
	public static ref T AsRef<T>(in T source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	|-Unsafe.AsRef<byte>
	|-Unsafe.AsRef<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x168EF80 Offset: 0x168E180 VA: 0x18168EF80
	public static void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount) { }

	// RVA: -1 Offset: -1
	public static T Read<T>(void* source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4354A0 Offset: 0x4346A0 VA: 0x1804354A0
	|-Unsafe.Read<Vector<ushort>>
	|
	|-RVA: 0xAA0C20 Offset: 0xA9FE20 VA: 0x180AA0C20
	|-Unsafe.Read<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T ReadUnaligned<T>(ref byte source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4354A0 Offset: 0x4346A0 VA: 0x1804354A0
	|-Unsafe.ReadUnaligned<Vector<ushort>>
	|
	|-RVA: 0x4F9860 Offset: 0x4F8A60 VA: 0x1804F9860
	|-Unsafe.ReadUnaligned<double>
	|
	|-RVA: 0x4D1BF0 Offset: 0x4D0DF0 VA: 0x1804D1BF0
	|-Unsafe.ReadUnaligned<short>
	|-Unsafe.ReadUnaligned<ushort>
	|
	|-RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	|-Unsafe.ReadUnaligned<int>
	|-Unsafe.ReadUnaligned<uint>
	|
	|-RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	|-Unsafe.ReadUnaligned<long>
	|-Unsafe.ReadUnaligned<UIntPtr>
	|
	|-RVA: 0xAA0C20 Offset: 0xA9FE20 VA: 0x180AA0C20
	|-Unsafe.ReadUnaligned<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int SizeOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F8DD0 Offset: 0x6F7FD0 VA: 0x1806F8DD0
	|-Unsafe.SizeOf<Vector<ushort>>
	|-Unsafe.SizeOf<Quaternion>
	|
	|-RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10
	|-Unsafe.SizeOf<byte>
	|
	|-RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920
	|-Unsafe.SizeOf<char>
	|-Unsafe.SizeOf<ushort>
	|
	|-RVA: 0x68EEE0 Offset: 0x68E0E0 VA: 0x18068EEE0
	|-Unsafe.SizeOf<int>
	|-Unsafe.SizeOf<uint>
	|
	|-RVA: 0xAA00E0 Offset: 0xA9F2E0 VA: 0x180AA00E0
	|-Unsafe.SizeOf<object>
	|-Unsafe.SizeOf<jvalue>
	|
	|-RVA: 0xAA0160 Offset: 0xA9F360 VA: 0x180AA0160
	|-Unsafe.SizeOf<Vector3>
	|
	|-RVA: 0xAA01D0 Offset: 0xA9F3D0 VA: 0x180AA01D0
	|-Unsafe.SizeOf<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void WriteUnaligned<T>(ref byte destination, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	|-Unsafe.WriteUnaligned<uint>
	|
	|-RVA: 0xAA0CD0 Offset: 0xA9FED0 VA: 0x180AA0CD0
	|-Unsafe.WriteUnaligned<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool IsAddressLessThan<T>(ref T left, ref T right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA0BF0 Offset: 0xA9FDF0 VA: 0x180AA0BF0
	|-Unsafe.IsAddressLessThan<ArraySegment<byte>>
	|-Unsafe.IsAddressLessThan<KeyValuePair<byte, int>>
	|-Unsafe.IsAddressLessThan<KeyValuePair<DiscardReasonWithCategory, int>>
	|-Unsafe.IsAddressLessThan<KeyValuePair<DiscardReasonWithCategory, object>>
	|-Unsafe.IsAddressLessThan<KeyValuePair<int, object>>
	|-Unsafe.IsAddressLessThan<KeyValuePair<object, char>>
	|-Unsafe.IsAddressLessThan<KeyValuePair<object, object>>
	|-Unsafe.IsAddressLessThan<KeyValuePair<object, ulong>>
	|-Unsafe.IsAddressLessThan<KeyValuePair<PropertyName, object>>
	|-Unsafe.IsAddressLessThan<KeyValuePair<Rect, object>>
	|-Unsafe.IsAddressLessThan<NativeArray<ConvertMeshJobData>>
	|-Unsafe.IsAddressLessThan<NativeArray<CopyClosingMeshJobData>>
	|-Unsafe.IsAddressLessThan<NativeArray<NudgeJobData>>
	|-Unsafe.IsAddressLessThan<NativeSlice<ConvertMeshJobData>>
	|-Unsafe.IsAddressLessThan<NativeSlice<CopyClosingMeshJobData>>
	|-Unsafe.IsAddressLessThan<NativeSlice<NudgeJobData>>
	|-Unsafe.IsAddressLessThan<TempAllocator.Page<ushort>>
	|-Unsafe.IsAddressLessThan<TempAllocator.Page<Vertex>>
	|-Unsafe.IsAddressLessThan<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>
	|-Unsafe.IsAddressLessThan<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>
	|-Unsafe.IsAddressLessThan<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>
	|-Unsafe.IsAddressLessThan<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>
	|-Unsafe.IsAddressLessThan<SequenceBuffer.SequencedData<VentilationSystem.VentMoveInfo, VentilationSystem.VentMoveInfo>>
	|-Unsafe.IsAddressLessThan<StructMultiKey<object, object>>
	|-Unsafe.IsAddressLessThan<ValueTuple<int, int>>
	|-Unsafe.IsAddressLessThan<ValueTuple<object, object>>
	|-Unsafe.IsAddressLessThan<AnimatorClipInfo>
	|-Unsafe.IsAddressLessThan<Announcement>
	|-Unsafe.IsAddressLessThan<AsyncOperationHandle>
	|-Unsafe.IsAddressLessThan<BoneWeight>
	|-Unsafe.IsAddressLessThan<bool>
	|-Unsafe.IsAddressLessThan<byte>
	|-Unsafe.IsAddressLessThan<ByteEnum>
	|-Unsafe.IsAddressLessThan<CancellationToken>
	|-Unsafe.IsAddressLessThan<char>
	|-Unsafe.IsAddressLessThan<Color>
	|-Unsafe.IsAddressLessThan<Color32>
	|-Unsafe.IsAddressLessThan<ComputedTransitionProperty>
	|-Unsafe.IsAddressLessThan<ContactPoint2D>
	|-Unsafe.IsAddressLessThan<ControllerPollingInfo>
	|-Unsafe.IsAddressLessThan<ControllerTemplateElementTarget>
	|-Unsafe.IsAddressLessThan<DataRecordInternal>
	|-Unsafe.IsAddressLessThan<DateTime>
	|-Unsafe.IsAddressLessThan<DateTimeOffset>
	|-Unsafe.IsAddressLessThan<DebugLogMessage>
	|-Unsafe.IsAddressLessThan<Decimal>
	|-Unsafe.IsAddressLessThan<DetectiveSuspect>
	|-Unsafe.IsAddressLessThan<DiagnosticEvent>
	|-Unsafe.IsAddressLessThan<DiscardReasonWithCategory>
	|-Unsafe.IsAddressLessThan<double>
	|-Unsafe.IsAddressLessThan<EasingFunction>
	|-Unsafe.IsAddressLessThan<Edge>
	|-Unsafe.IsAddressLessThan<ElementAssignmentConflictInfo>
	|-Unsafe.IsAddressLessThan<Entitlement>
	|-Unsafe.IsAddressLessThan<Entitlement>
	|-Unsafe.IsAddressLessThan<ExternalAccountInfo>
	|-Unsafe.IsAddressLessThan<FileStat>
	|-Unsafe.IsAddressLessThan<GameListing>
	|-Unsafe.IsAddressLessThan<GlyphPairAdjustmentRecord>
	|-Unsafe.IsAddressLessThan<GlyphRect>
	|-Unsafe.IsAddressLessThan<Guid>
	|-Unsafe.IsAddressLessThan<HttpStatusCodeRange>
	|-Unsafe.IsAddressLessThan<IngestData>
	|-Unsafe.IsAddressLessThan<InputActionSourceData>
	|-Unsafe.IsAddressLessThan<short>
	|-Unsafe.IsAddressLessThan<int>
	|-Unsafe.IsAddressLessThan<Int32Enum>
	|-Unsafe.IsAddressLessThan<long>
	|-Unsafe.IsAddressLessThan<InterpretedFrameInfo>
	|-Unsafe.IsAddressLessThan<ItemOwnershipInternal>
	|-Unsafe.IsAddressLessThan<JsonElement>
	|-Unsafe.IsAddressLessThan<JsonEncodedText>
	|-Unsafe.IsAddressLessThan<JsonPosition>
	|-Unsafe.IsAddressLessThan<LigatureSubstitutionRecord>
	|-Unsafe.IsAddressLessThan<ManipulatorActivationFilter>
	|-Unsafe.IsAddressLessThan<MarkToBaseAdjustmentRecord>
	|-Unsafe.IsAddressLessThan<MarkToMarkAdjustmentRecord>
	|-Unsafe.IsAddressLessThan<Matrix4x4>
	|-Unsafe.IsAddressLessThan<ModIdentifierInternal>
	|-Unsafe.IsAddressLessThan<MultipleSubstitutionRecord>
	|-Unsafe.IsAddressLessThan<object>
	|-Unsafe.IsAddressLessThan<ObjectInitializationData>
	|-Unsafe.IsAddressLessThan<OptionInternal>
	|-Unsafe.IsAddressLessThan<ParameterRef>
	|-Unsafe.IsAddressLessThan<ParticipantMetadataInternal>
	|-Unsafe.IsAddressLessThan<PhysicsShape2D>
	|-Unsafe.IsAddressLessThan<PlayerLoopSystem>
	|-Unsafe.IsAddressLessThan<PlayerLoopSystemInternal>
	|-Unsafe.IsAddressLessThan<PlayerStatInfoInternal>
	|-Unsafe.IsAddressLessThan<PropertyRef>
	|-Unsafe.IsAddressLessThan<RangePositionInfo>
	|-Unsafe.IsAddressLessThan<RaycastHit2D>
	|-Unsafe.IsAddressLessThan<RaycastResult>
	|-Unsafe.IsAddressLessThan<ReadStackFrame>
	|-Unsafe.IsAddressLessThan<Rect>
	|-Unsafe.IsAddressLessThan<Relationship>
	|-Unsafe.IsAddressLessThan<Resolution>
	|-Unsafe.IsAddressLessThan<RuleMatcher>
	|-Unsafe.IsAddressLessThan<RulesCategory>
	|-Unsafe.IsAddressLessThan<sbyte>
	|-Unsafe.IsAddressLessThan<SandboxIdItemOwnershipInternal>
	|-Unsafe.IsAddressLessThan<SelectorMatchRecord>
	|-Unsafe.IsAddressLessThan<float>
	|-Unsafe.IsAddressLessThan<Sku>
	|-Unsafe.IsAddressLessThan<SslApplicationProtocol>
	|-Unsafe.IsAddressLessThan<StatThresholdsInternal>
	|-Unsafe.IsAddressLessThan<StylePropertyName>
	|-Unsafe.IsAddressLessThan<StylePropertyValue>
	|-Unsafe.IsAddressLessThan<StyleSelectorPart>
	|-Unsafe.IsAddressLessThan<StyleSyntaxToken>
	|-Unsafe.IsAddressLessThan<StyleValue>
	|-Unsafe.IsAddressLessThan<StyleValueManaged>
	|-Unsafe.IsAddressLessThan<StyleVariable>
	|-Unsafe.IsAddressLessThan<SubMeshDescriptor>
	|-Unsafe.IsAddressLessThan<SubString>
	|-Unsafe.IsAddressLessThan<TimeSpan>
	|-Unsafe.IsAddressLessThan<TimeValue>
	|-Unsafe.IsAddressLessThan<TreeViewItemWrapper>
	|-Unsafe.IsAddressLessThan<TypeWrapper>
	|-Unsafe.IsAddressLessThan<UICharInfo>
	|-Unsafe.IsAddressLessThan<UILineInfo>
	|-Unsafe.IsAddressLessThan<UIVertex>
	|-Unsafe.IsAddressLessThan<ushort>
	|-Unsafe.IsAddressLessThan<UInt16Enum>
	|-Unsafe.IsAddressLessThan<uint>
	|-Unsafe.IsAddressLessThan<ulong>
	|-Unsafe.IsAddressLessThan<User>
	|-Unsafe.IsAddressLessThan<Vector2>
	|-Unsafe.IsAddressLessThan<Vector3>
	|-Unsafe.IsAddressLessThan<Vector3Int>
	|-Unsafe.IsAddressLessThan<Vector4>
	|-Unsafe.IsAddressLessThan<VertexAttributeDescriptor>
	|-Unsafe.IsAddressLessThan<Win32_IP_ADAPTER_ADDRESSES>
	|-Unsafe.IsAddressLessThan<Win32_IP_ADAPTER_INFO>
	|-Unsafe.IsAddressLessThan<WriteStackFrame>
	|-Unsafe.IsAddressLessThan<X509ChainStatus>
	|-Unsafe.IsAddressLessThan<XSXSubmitGraphicsCommandsDataCommandInternal>
	|-Unsafe.IsAddressLessThan<XboxOneGDKSubmitGraphicsCommandsDataCommandInternal>
	|-Unsafe.IsAddressLessThan<__Il2CppFullySharedGenericType>
	|-Unsafe.IsAddressLessThan<AchievementManager.AchievementProgressValue>
	|-Unsafe.IsAddressLessThan<BeforeRenderHelper.OrderBlock>
	|-Unsafe.IsAddressLessThan<BitmapAllocator32.Page>
	|-Unsafe.IsAddressLessThan<Camera.RenderRequest>
	|-Unsafe.IsAddressLessThan<CreditsController.CreditStruct>
	|-Unsafe.IsAddressLessThan<CreditsController.FormatStruct>
	|-Unsafe.IsAddressLessThan<CustomController.CZxNqDPSLSmjvjcEzpoKeadUPlaM>
	|-Unsafe.IsAddressLessThan<DelayedActionManager.DelegateInfo>
	|-Unsafe.IsAddressLessThan<DtlsUnityConnection.FragmentRange>
	|-Unsafe.IsAddressLessThan<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.YkJYhIwKoTBpWKATiflrEgjLfZIX>
	|-Unsafe.IsAddressLessThan<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.fcJeYwLvuogcmgGamTgYErdESsqW>
	|-Unsafe.IsAddressLessThan<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>
	|-Unsafe.IsAddressLessThan<FocusController.FocusedElement>
	|-Unsafe.IsAddressLessThan<HardwareControllerTemplateMap.rwEetQoHfXcCclqvIDEVKbecRXpDb>
	|-Unsafe.IsAddressLessThan<MultiColumnCollectionHeader.SortedColumnState>
	|-Unsafe.IsAddressLessThan<PZVoNXqAhLHAMSWUdEitcRuLGMcmA.LxbGihMOwQSEjsHzfBQtamHgcTraA>
	|-Unsafe.IsAddressLessThan<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|-Unsafe.IsAddressLessThan<ParticleSystem.Particle>
	|-Unsafe.IsAddressLessThan<QRCodeGenerator.AlignmentPattern>
	|-Unsafe.IsAddressLessThan<QRCodeGenerator.Antilog>
	|-Unsafe.IsAddressLessThan<QRCodeGenerator.CodewordBlock>
	|-Unsafe.IsAddressLessThan<QRCodeGenerator.ECCInfo>
	|-Unsafe.IsAddressLessThan<QRCodeGenerator.PolynomItem>
	|-Unsafe.IsAddressLessThan<QRCodeGenerator.VersionInfo>
	|-Unsafe.IsAddressLessThan<QRCodeGenerator.VersionInfoDetails>
	|-Unsafe.IsAddressLessThan<RadialMenu.CachedButtonObject>
	|-Unsafe.IsAddressLessThan<RegexCharClass.SingleRange>
	|-Unsafe.IsAddressLessThan<RenderChain.RenderNodeData>
	|-Unsafe.IsAddressLessThan<ResourceManager.DeferredCallbackRegisterRequest>
	|-Unsafe.IsAddressLessThan<SecurityLogBehaviour.SecurityLogEntry>
	|-Unsafe.IsAddressLessThan<ServerManager.PingWrapper>
	|-Unsafe.IsAddressLessThan<TemplateAsset.AttributeOverride>
	|-Unsafe.IsAddressLessThan<TextSettings.FontReferenceMap>
	|-Unsafe.IsAddressLessThan<TextureBlitter.BlitInfo>
	|-Unsafe.IsAddressLessThan<TexturePacker_JsonArray.Frame>
	|-Unsafe.IsAddressLessThan<TextureRegistry.TextureInfo>
	|-Unsafe.IsAddressLessThan<UIRStylePainter.Entry>
	|-Unsafe.IsAddressLessThan<UIRStylePainter.RepeatRectUV>
	|-Unsafe.IsAddressLessThan<UIRenderDevice.AllocToFree>
	|-Unsafe.IsAddressLessThan<UIRenderDevice.AllocToUpdate>
	|-Unsafe.IsAddressLessThan<UnitySynchronizationContext.WorkRequest>
	|-Unsafe.IsAddressLessThan<UnityUITextMeshProGlyphHelper.GlyphOrText>
	|-Unsafe.IsAddressLessThan<VisualTreeAsset.AssetEntry>
	|-Unsafe.IsAddressLessThan<VisualTreeAsset.SlotDefinition>
	|-Unsafe.IsAddressLessThan<VisualTreeAsset.SlotUsageEntry>
	|-Unsafe.IsAddressLessThan<VisualTreeAsset.UsingEntry>
	|-Unsafe.IsAddressLessThan<VisualTreeAsset.UxmlObjectEntry>
	|-Unsafe.IsAddressLessThan<XjXmgYEoXluUbKoyNCodoxJzPrjJ.FSjxKnkodQibKwPtFNBnKKATQeux>
	|-Unsafe.IsAddressLessThan<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|-Unsafe.IsAddressLessThan<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>
	|-Unsafe.IsAddressLessThan<InstructionList.DebugView.InstructionView>
	|-Unsafe.IsAddressLessThan<MultiColumnCollectionHeader.ViewState.ColumnState>
	|-Unsafe.IsAddressLessThan<PlayerController.Element.TBnjpqFyveWLFptREPetgdFmwyCWA>
	*/

	// RVA: -1 Offset: -1
	internal static ref T AddByteOffset<T>(ref T source, ulong byteOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA08D0 Offset: 0xA9FAD0 VA: 0x180AA08D0
	|-Unsafe.AddByteOffset<byte>
	|-Unsafe.AddByteOffset<char>
	|-Unsafe.AddByteOffset<int>
	|-Unsafe.AddByteOffset<object>
	|-Unsafe.AddByteOffset<Quaternion>
	|-Unsafe.AddByteOffset<ushort>
	|-Unsafe.AddByteOffset<uint>
	|-Unsafe.AddByteOffset<Vector3>
	|-Unsafe.AddByteOffset<jvalue>
	|
	|-RVA: 0xAA08F0 Offset: 0xA9FAF0 VA: 0x180AA08F0
	|-Unsafe.AddByteOffset<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Resources
public interface IResourceReader : IEnumerable, IDisposable // TypeDefIndex: 4080
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Close();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDictionaryEnumerator GetEnumerator();
}

// Namespace: System.Resources
[Serializable]
public class MissingManifestResourceException : SystemException // TypeDefIndex: 4081
{
	// Methods

	// RVA: 0x1680E60 Offset: 0x1680060 VA: 0x181680E60
	public void .ctor() { }

	// RVA: 0x1680E40 Offset: 0x1680040 VA: 0x181680E40
	public void .ctor(string message) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Resources
[Serializable]
public class MissingSatelliteAssemblyException : SystemException // TypeDefIndex: 4082
{
	// Fields
	private string _cultureName; // 0x90

	// Methods

	// RVA: 0x1680EF0 Offset: 0x16800F0 VA: 0x181680EF0
	public void .ctor() { }

	// RVA: 0x1680EB0 Offset: 0x16800B0 VA: 0x181680EB0
	public void .ctor(string message, string cultureName) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Resources
[Usage(1, AllowMultiple = False)]
public sealed class NeutralResourcesLanguageAttribute : Attribute // TypeDefIndex: 4083
{
	// Fields
	[CompilerGenerated]
	private readonly string <CultureName>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly UltimateResourceFallbackLocation <Location>k__BackingField; // 0x18

	// Properties
	public string CultureName { get; }
	public UltimateResourceFallbackLocation Location { get; }

	// Methods

	// RVA: 0x16813C0 Offset: 0x16805C0 VA: 0x1816813C0
	public void .ctor(string cultureName) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_CultureName() { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public UltimateResourceFallbackLocation get_Location() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ResourceFallbackManager.<GetEnumerator>d__5 : IEnumerator<CultureInfo>, IDisposable, IEnumerator // TypeDefIndex: 4084
{
	// Fields
	private int <>1__state; // 0x10
	private CultureInfo <>2__current; // 0x18
	public ResourceFallbackManager <>4__this; // 0x20
	private bool <reachedNeutralResourcesCulture>5__2; // 0x28
	private CultureInfo <currentCulture>5__3; // 0x30

	// Properties
	private CultureInfo System.Collections.Generic.IEnumerator<System.Globalization.CultureInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x168E870 Offset: 0x168DA70 VA: 0x18168E870 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private CultureInfo System.Collections.Generic.IEnumerator<System.Globalization.CultureInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x168EA90 Offset: 0x168DC90 VA: 0x18168EA90 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: System.Resources
internal class ResourceFallbackManager : IEnumerable<CultureInfo>, IEnumerable // TypeDefIndex: 4085
{
	// Fields
	private CultureInfo m_startingCulture; // 0x10
	private CultureInfo m_neutralResourcesCulture; // 0x18
	private bool m_useParents; // 0x20

	// Methods

	// RVA: 0x1682FC0 Offset: 0x16821C0 VA: 0x181682FC0
	internal void .ctor(CultureInfo startingCulture, CultureInfo neutralResourcesCulture, bool useParents) { }

	// RVA: 0x1682F60 Offset: 0x1682160 VA: 0x181682F60 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[IteratorStateMachine(typeof(ResourceFallbackManager.<GetEnumerator>d__5))]
	// RVA: 0x1682F60 Offset: 0x1682160 VA: 0x181682F60 Slot: 4
	public IEnumerator<CultureInfo> GetEnumerator() { }
}

// Namespace: System.Resources
internal enum ResourceTypeCode // TypeDefIndex: 4086
{
	// Fields
	public int value__; // 0x0
	public const ResourceTypeCode Null = 0;
	public const ResourceTypeCode String = 1;
	public const ResourceTypeCode Boolean = 2;
	public const ResourceTypeCode Char = 3;
	public const ResourceTypeCode Byte = 4;
	public const ResourceTypeCode SByte = 5;
	public const ResourceTypeCode Int16 = 6;
	public const ResourceTypeCode UInt16 = 7;
	public const ResourceTypeCode Int32 = 8;
	public const ResourceTypeCode UInt32 = 9;
	public const ResourceTypeCode Int64 = 10;
	public const ResourceTypeCode UInt64 = 11;
	public const ResourceTypeCode Single = 12;
	public const ResourceTypeCode Double = 13;
	public const ResourceTypeCode Decimal = 14;
	public const ResourceTypeCode DateTime = 15;
	public const ResourceTypeCode TimeSpan = 16;
	public const ResourceTypeCode LastPrimitive = 16;
	public const ResourceTypeCode ByteArray = 32;
	public const ResourceTypeCode Stream = 33;
	public const ResourceTypeCode StartOfUserTypes = 64;
}

// Namespace: System.Resources
internal sealed class RuntimeResourceSet : ResourceSet, IEnumerable // TypeDefIndex: 4087
{
	// Fields
	internal const int Version = 2;
	private Dictionary<string, ResourceLocator> _resCache; // 0x28
	private ResourceReader _defaultReader; // 0x30
	private Dictionary<string, ResourceLocator> _caseInsensitiveTable; // 0x38
	private bool _haveReadFromReader; // 0x40

	// Methods

	// RVA: 0x168CA40 Offset: 0x168BC40 VA: 0x18168CA40
	internal void .ctor(string fileName) { }

	// RVA: 0x168C8A0 Offset: 0x168BAA0 VA: 0x18168C8A0
	internal void .ctor(Stream stream) { }

	// RVA: 0x168B8F0 Offset: 0x168AAF0 VA: 0x18168B8F0 Slot: 6
	protected override void Dispose(bool disposing) { }

	// RVA: 0x168BB00 Offset: 0x168AD00 VA: 0x18168BB00 Slot: 7
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x168BB00 Offset: 0x168AD00 VA: 0x18168BB00 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x168BA60 Offset: 0x168AC60 VA: 0x18168BA60
	private IDictionaryEnumerator GetEnumeratorHelper() { }

	// RVA: 0x168C650 Offset: 0x168B850 VA: 0x18168C650 Slot: 8
	public override string GetString(string key) { }

	// RVA: 0x168C5C0 Offset: 0x168B7C0 VA: 0x18168C5C0 Slot: 9
	public override string GetString(string key, bool ignoreCase) { }

	// RVA: 0x168BB10 Offset: 0x168AD10 VA: 0x18168BB10 Slot: 10
	public override object GetObject(string key) { }

	// RVA: 0x168C5A0 Offset: 0x168B7A0 VA: 0x18168C5A0 Slot: 11
	public override object GetObject(string key, bool ignoreCase) { }

	// RVA: 0x168BB30 Offset: 0x168AD30 VA: 0x18168BB30
	private object GetObject(string key, bool ignoreCase, bool isString) { }

	// RVA: 0x168C6D0 Offset: 0x168B8D0 VA: 0x18168C6D0
	private object ResolveResourceLocator(ResourceLocator resLocation, string key, Dictionary<string, ResourceLocator> copyOfCache, bool keyInWrongCase) { }
}

// Namespace: System.Resources
[Usage(1, AllowMultiple = False)]
public sealed class SatelliteContractVersionAttribute : Attribute // TypeDefIndex: 4088
{
	// Fields
	[CompilerGenerated]
	private readonly string <Version>k__BackingField; // 0x10

	// Properties
	public string Version { get; }

	// Methods

	// RVA: 0x168D740 Offset: 0x168C940 VA: 0x18168D740
	public void .ctor(string version) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Version() { }
}

// Namespace: System.Resources
public enum UltimateResourceFallbackLocation // TypeDefIndex: 4089
{
	// Fields
	public int value__; // 0x0
	public const UltimateResourceFallbackLocation MainAssembly = 0;
	public const UltimateResourceFallbackLocation Satellite = 1;
}

// Namespace: System.Resources
public interface IResourceWriter : IDisposable // TypeDefIndex: 4090
{}

// Namespace: System.Resources
internal sealed class FastResourceComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string> // TypeDefIndex: 4091
{
	// Fields
	internal static readonly FastResourceComparer Default; // 0x0

	// Methods

	// RVA: 0x1678440 Offset: 0x1677640 VA: 0x181678440 Slot: 6
	public int GetHashCode(object key) { }

	// RVA: 0x1678500 Offset: 0x1677700 VA: 0x181678500 Slot: 9
	public int GetHashCode(string key) { }

	// RVA: 0x1678590 Offset: 0x1677790 VA: 0x181678590
	internal static int HashFunction(string key) { }

	// RVA: 0x16782E0 Offset: 0x16774E0 VA: 0x1816782E0 Slot: 4
	public int Compare(object a, object b) { }

	// RVA: 0x16782C0 Offset: 0x16774C0 VA: 0x1816782C0 Slot: 7
	public int Compare(string a, string b) { }

	// RVA: 0x1678420 Offset: 0x1677620 VA: 0x181678420 Slot: 8
	public bool Equals(string a, string b) { }

	// RVA: 0x1678380 Offset: 0x1677580 VA: 0x181678380 Slot: 5
	public bool Equals(object a, object b) { }

	// RVA: 0x16781F0 Offset: 0x16773F0 VA: 0x1816781F0
	public static int CompareOrdinal(string a, byte[] bytes, int bCharLength) { }

	// RVA: 0x1678050 Offset: 0x1677250 VA: 0x181678050
	public static int CompareOrdinal(byte[] bytes, int aCharLength, string b) { }

	// RVA: 0x1678140 Offset: 0x1677340 VA: 0x181678140
	internal static int CompareOrdinal(byte* a, int byteLen, string b) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x16785F0 Offset: 0x16777F0 VA: 0x1816785F0
	private static void .cctor() { }
}

// Namespace: System.Resources
internal class FileBasedResourceGroveler : IResourceGroveler // TypeDefIndex: 4092
{
	// Fields
	private ResourceManager.ResourceManagerMediator _mediator; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(ResourceManager.ResourceManagerMediator mediator) { }

	// RVA: 0x1679870 Offset: 0x1678A70 VA: 0x181679870 Slot: 4
	public ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark) { }

	// RVA: 0x16797B0 Offset: 0x16789B0 VA: 0x1816797B0
	private string FindResourceFile(CultureInfo culture, string fileName) { }

	// RVA: 0x1679360 Offset: 0x1678560 VA: 0x181679360
	private ResourceSet CreateResourceSet(string file) { }
}

// Namespace: System.Resources
internal interface IResourceGroveler // TypeDefIndex: 4093
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark);
}

// Namespace: System.Resources
internal class ManifestBasedResourceGroveler : IResourceGroveler // TypeDefIndex: 4094
{
	// Fields
	private ResourceManager.ResourceManagerMediator _mediator; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(ResourceManager.ResourceManagerMediator mediator) { }

	// RVA: 0x167BF20 Offset: 0x167B120 VA: 0x18167BF20 Slot: 4
	public ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark) { }

	// RVA: 0x167CA80 Offset: 0x167BC80 VA: 0x18167CA80
	private CultureInfo UltimateFallbackFixup(CultureInfo lookForCulture) { }

	// RVA: 0x167BA10 Offset: 0x167AC10 VA: 0x18167BA10
	internal static CultureInfo GetNeutralResourcesLanguage(Assembly a, ref UltimateResourceFallbackLocation fallbackLocation) { }

	// RVA: 0x167AE30 Offset: 0x167A030 VA: 0x18167AE30
	internal ResourceSet CreateResourceSet(Stream store, Assembly assembly) { }

	// RVA: 0x167B890 Offset: 0x167AA90 VA: 0x18167B890
	private Stream GetManifestResourceStream(RuntimeAssembly satellite, string fileName, ref StackCrawlMark stackMark) { }

	// RVA: 0x167AA40 Offset: 0x1679C40 VA: 0x18167AA40
	private Stream CaseInsensitiveManifestResourceStreamLookup(RuntimeAssembly satellite, string name) { }

	// RVA: 0x167BD80 Offset: 0x167AF80 VA: 0x18167BD80
	private RuntimeAssembly GetSatelliteAssembly(CultureInfo lookForCulture, ref StackCrawlMark stackMark) { }

	// RVA: 0x167A8B0 Offset: 0x1679AB0 VA: 0x18167A8B0
	private bool CanUseDefaultResourceClasses(string readerTypeName, string resSetTypeName) { }

	// RVA: 0x167BD10 Offset: 0x167AF10 VA: 0x18167BD10
	private string GetSatelliteAssemblyName() { }

	// RVA: 0x167C6D0 Offset: 0x167B8D0 VA: 0x18167C6D0
	private void HandleSatelliteMissing() { }

	// RVA: 0x167C3C0 Offset: 0x167B5C0 VA: 0x18167C3C0
	private void HandleResourceStreamMissing(string fileName) { }

	// RVA: 0x167B990 Offset: 0x167AB90 VA: 0x18167B990
	private static bool GetNeutralResourcesLanguageAttribute(Assembly assembly, ref string cultureName, ref short fallbackLocation) { }
}

// Namespace: 
internal class ResourceManager.CultureNameResourceSetPair // TypeDefIndex: 4095
{
	// Fields
	public string lastCultureName; // 0x10
	public ResourceSet lastResourceSet; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
internal class ResourceManager.ResourceManagerMediator // TypeDefIndex: 4096
{
	// Fields
	private ResourceManager _rm; // 0x10

	// Properties
	internal string ModuleDir { get; }
	internal Type LocationInfo { get; }
	internal Type UserResourceSet { get; }
	internal string BaseNameField { get; }
	internal CultureInfo NeutralResourcesCulture { get; }
	internal bool LookedForSatelliteContractVersion { get; set; }
	internal Version SatelliteContractVersion { get; set; }
	internal UltimateResourceFallbackLocation FallbackLoc { get; }
	internal RuntimeAssembly CallingAssembly { get; }
	internal RuntimeAssembly MainAssembly { get; }
	internal string BaseName { get; }

	// Methods

	// RVA: 0x16830E0 Offset: 0x16822E0 VA: 0x1816830E0
	internal void .ctor(ResourceManager rm) { }

	// RVA: 0x1683290 Offset: 0x1682490 VA: 0x181683290
	internal string get_ModuleDir() { }

	// RVA: 0x7751F0 Offset: 0x7743F0 VA: 0x1807751F0
	internal Type get_LocationInfo() { }

	// RVA: 0x16832F0 Offset: 0x16824F0 VA: 0x1816832F0
	internal Type get_UserResourceSet() { }

	// RVA: 0xE3BAB0 Offset: 0xE3ACB0 VA: 0x180E3BAB0
	internal string get_BaseNameField() { }

	// RVA: 0x16832B0 Offset: 0x16824B0 VA: 0x1816832B0
	internal CultureInfo get_NeutralResourcesCulture() { }

	// RVA: 0x1683060 Offset: 0x1682260 VA: 0x181683060
	internal string GetResourceFileName(CultureInfo culture) { }

	// RVA: 0x16831D0 Offset: 0x16823D0 VA: 0x1816831D0
	internal bool get_LookedForSatelliteContractVersion() { }

	// RVA: 0x1683310 Offset: 0x1682510 VA: 0x181683310
	internal void set_LookedForSatelliteContractVersion(bool value) { }

	// RVA: 0x16832D0 Offset: 0x16824D0 VA: 0x1816832D0
	internal Version get_SatelliteContractVersion() { }

	// RVA: 0x1683330 Offset: 0x1682530 VA: 0x181683330
	internal void set_SatelliteContractVersion(Version value) { }

	// RVA: 0x1683090 Offset: 0x1682290 VA: 0x181683090
	internal Version ObtainSatelliteContractVersion(Assembly a) { }

	// RVA: 0x16831B0 Offset: 0x16823B0 VA: 0x1816831B0
	internal UltimateResourceFallbackLocation get_FallbackLoc() { }

	// RVA: 0x1683190 Offset: 0x1682390 VA: 0x181683190
	internal RuntimeAssembly get_CallingAssembly() { }

	// RVA: 0x16831F0 Offset: 0x16823F0 VA: 0x1816831F0
	internal RuntimeAssembly get_MainAssembly() { }

	// RVA: 0x1683160 Offset: 0x1682360 VA: 0x181683160
	internal string get_BaseName() { }
}

// Namespace: System.Resources
[ComVisible(True)]
[Serializable]
public class ResourceManager // TypeDefIndex: 4097
{
	// Fields
	protected string BaseNameField; // 0x10
	[Obsolete("call InternalGetResourceSet instead")]
	protected Hashtable ResourceSets; // 0x18
	private Dictionary<string, ResourceSet> _resourceSets; // 0x20
	private string moduleDir; // 0x28
	protected Assembly MainAssembly; // 0x30
	private Type _locationInfo; // 0x38
	private Type _userResourceSet; // 0x40
	private CultureInfo _neutralResourcesCulture; // 0x48
	private ResourceManager.CultureNameResourceSetPair _lastUsedResourceCache; // 0x50
	private bool _ignoreCase; // 0x58
	private bool UseManifest; // 0x59
	[OptionalField(VersionAdded = 1)]
	private bool UseSatelliteAssem; // 0x5A
	[OptionalField]
	private UltimateResourceFallbackLocation _fallbackLoc; // 0x5C
	[OptionalField]
	private Version _satelliteContractVersion; // 0x60
	[OptionalField]
	private bool _lookedForSatelliteContractVersion; // 0x68
	[OptionalField(VersionAdded = 1)]
	private Assembly _callingAssembly; // 0x70
	[OptionalField(VersionAdded = 4)]
	private RuntimeAssembly m_callingAssembly; // 0x78
	private IResourceGroveler resourceGroveler; // 0x80
	public static readonly int MagicNumber; // 0x0
	public static readonly int HeaderVersionNumber; // 0x4
	private static readonly Type _minResourceSet; // 0x8
	internal static readonly string ResReaderTypeName; // 0x10
	internal static readonly string ResSetTypeName; // 0x18
	internal static readonly string MscorlibName; // 0x20
	internal static readonly int DEBUG; // 0x28

	// Properties
	public virtual string BaseName { get; }
	public virtual bool IgnoreCase { get; }
	protected UltimateResourceFallbackLocation FallbackLocation { get; }

	// Methods

	// RVA: 0x1684C30 Offset: 0x1683E30 VA: 0x181684C30
	private void Init() { }

	// RVA: 0x16857E0 Offset: 0x16849E0 VA: 0x1816857E0
	protected void .ctor() { }

	// RVA: 0x16858B0 Offset: 0x1684AB0 VA: 0x1816858B0
	public void .ctor(Type resourceSource) { }

	[OnDeserializing]
	// RVA: 0x16855B0 Offset: 0x16847B0 VA: 0x1816855B0
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserialized]
	// RVA: 0x16853B0 Offset: 0x16845B0 VA: 0x1816853B0
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializing]
	// RVA: 0x16855D0 Offset: 0x16847D0 VA: 0x1816855D0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x16834C0 Offset: 0x16826C0 VA: 0x1816834C0
	private void CommonAssemblyInit() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public virtual string get_BaseName() { }

	// RVA: 0x4D1A30 Offset: 0x4D0C30 VA: 0x1804D1A30 Slot: 5
	public virtual bool get_IgnoreCase() { }

	// RVA: 0x4EDB10 Offset: 0x4ECD10 VA: 0x1804EDB10
	protected UltimateResourceFallbackLocation get_FallbackLocation() { }

	// RVA: 0x1683C70 Offset: 0x1682E70 VA: 0x181683C70 Slot: 6
	protected virtual string GetResourceFileName(CultureInfo culture) { }

	// RVA: 0x1683850 Offset: 0x1682A50 VA: 0x181683850
	internal ResourceSet GetFirstResourceSet(CultureInfo culture) { }

	// RVA: 0x1683DC0 Offset: 0x1682FC0 VA: 0x181683DC0 Slot: 7
	public virtual ResourceSet GetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents) { }

	// RVA: 0x1684D30 Offset: 0x1683F30 VA: 0x181684D30 Slot: 8
	protected virtual ResourceSet InternalGetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents) { }

	// RVA: 0x1684D60 Offset: 0x1683F60 VA: 0x181684D60
	private ResourceSet InternalGetResourceSet(CultureInfo requestedCulture, bool createIfNotExists, bool tryParents, ref StackCrawlMark stackMark) { }

	// RVA: 0x1683350 Offset: 0x1682550 VA: 0x181683350
	private static void AddResourceSet(Dictionary<string, ResourceSet> localResourceSets, string cultureName, ref ResourceSet rs) { }

	// RVA: 0x16841E0 Offset: 0x16833E0 VA: 0x1816841E0
	protected static Version GetSatelliteContractVersion(Assembly a) { }

	// RVA: 0x1683C50 Offset: 0x1682E50 VA: 0x181683C50
	protected static CultureInfo GetNeutralResourcesLanguage(Assembly a) { }

	// RVA: 0x1683600 Offset: 0x1682800 VA: 0x181683600
	internal static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void SetAppXConfiguration() { }

	// RVA: 0x15B27D0 Offset: 0x15B19D0 VA: 0x1815B27D0 Slot: 9
	public virtual string GetString(string name) { }

	// RVA: 0x1684800 Offset: 0x1683A00 VA: 0x181684800 Slot: 10
	public virtual string GetString(string name, CultureInfo culture) { }

	// RVA: 0x1685630 Offset: 0x1684830 VA: 0x181685630
	private static void .cctor() { }
}

// Namespace: System.Resources
internal struct ResourceLocator // TypeDefIndex: 4098
{
	// Fields
	internal object _value; // 0x0
	internal int _dataPos; // 0x8

	// Properties
	internal int DataPosition { get; }
	internal object Value { get; set; }

	// Methods

	// RVA: 0x165B2F0 Offset: 0x165A4F0 VA: 0x18165B2F0
	internal void .ctor(int dataPos, object value) { }

	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	internal int get_DataPosition() { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	internal object get_Value() { }

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void set_Value(object value) { }

	// RVA: 0x1683050 Offset: 0x1682250 VA: 0x181683050
	internal static bool CanCache(ResourceTypeCode value) { }
}

// Namespace: 
internal sealed class ResourceReader.ResourceEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 4099
{
	// Fields
	private ResourceReader _reader; // 0x10
	private bool _currentIsValid; // 0x18
	private int _currentName; // 0x1C
	private int _dataPosition; // 0x20

	// Properties
	public object Key { get; }
	public object Current { get; }
	internal int DataPosition { get; }
	public DictionaryEntry Entry { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x1682810 Offset: 0x1681A10 VA: 0x181682810
	internal void .ctor(ResourceReader reader) { }

	// RVA: 0x1682720 Offset: 0x1681920 VA: 0x181682720 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x1682CA0 Offset: 0x1681EA0 VA: 0x181682CA0 Slot: 4
	public object get_Key() { }

	// RVA: 0x1682850 Offset: 0x1681A50 VA: 0x181682850 Slot: 8
	public object get_Current() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	internal int get_DataPosition() { }

	// RVA: 0x16828B0 Offset: 0x1681AB0 VA: 0x1816828B0 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x1682E00 Offset: 0x1682000 VA: 0x181682E00 Slot: 5
	public object get_Value() { }

	// RVA: 0x1682770 Offset: 0x1681970 VA: 0x181682770 Slot: 9
	public void Reset() { }
}

// Namespace: System.Resources
[ComVisible(True)]
public sealed class ResourceReader : IResourceReader, IEnumerable, IDisposable // TypeDefIndex: 4100
{
	// Fields
	private BinaryReader _store; // 0x10
	internal Dictionary<string, ResourceLocator> _resCache; // 0x18
	private long _nameSectionOffset; // 0x20
	private long _dataSectionOffset; // 0x28
	private int[] _nameHashes; // 0x30
	private int* _nameHashesPtr; // 0x38
	private int[] _namePositions; // 0x40
	private int* _namePositionsPtr; // 0x48
	private RuntimeType[] _typeTable; // 0x50
	private int[] _typeNamePositions; // 0x58
	private BinaryFormatter _objFormatter; // 0x60
	private int _numResources; // 0x68
	private UnmanagedMemoryStream _ums; // 0x70
	private int _version; // 0x78

	// Methods

	// RVA: 0x168A0E0 Offset: 0x16892E0 VA: 0x18168A0E0
	internal void .ctor(Stream stream, Dictionary<string, ResourceLocator> resCache) { }

	// RVA: 0x1686440 Offset: 0x1685640 VA: 0x181686440 Slot: 4
	public void Close() { }

	// RVA: 0x1686440 Offset: 0x1685640 VA: 0x181686440 Slot: 7
	public void Dispose() { }

	// RVA: 0x1686A70 Offset: 0x1685C70 VA: 0x181686A70
	private void Dispose(bool disposing) { }

	// RVA: 0x1688030 Offset: 0x1687230 VA: 0x181688030
	internal static int ReadUnalignedI4(int* p) { }

	// RVA: 0x1688050 Offset: 0x1687250 VA: 0x181688050
	private void SkipString() { }

	// RVA: 0x1687490 Offset: 0x1686690 VA: 0x181687490
	private int GetNameHash(int index) { }

	// RVA: 0x1687500 Offset: 0x1686700 VA: 0x181687500
	private int GetNamePosition(int index) { }

	// RVA: 0x16873D0 Offset: 0x16865D0 VA: 0x1816873D0 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x16873D0 Offset: 0x16865D0 VA: 0x1816873D0 Slot: 5
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1687360 Offset: 0x1686560 VA: 0x181687360
	internal ResourceReader.ResourceEnumerator GetEnumeratorInternal() { }

	// RVA: 0x1686AE0 Offset: 0x1685CE0 VA: 0x181686AE0
	internal int FindPosForResource(string name) { }

	// RVA: 0x16864A0 Offset: 0x16856A0 VA: 0x1816864A0
	private bool CompareStringEqualsName(string name) { }

	// RVA: 0x1685CD0 Offset: 0x1684ED0 VA: 0x181685CD0
	private string AllocateStringForNameIndex(int index, out int dataOffset) { }

	// RVA: 0x1687640 Offset: 0x1686840 VA: 0x181687640
	private object GetValueForNameIndex(int index) { }

	// RVA: 0x1687BB0 Offset: 0x1686DB0 VA: 0x181687BB0
	internal string LoadString(int pos) { }

	// RVA: 0x1687AE0 Offset: 0x1686CE0 VA: 0x181687AE0
	internal object LoadObject(int pos) { }

	// RVA: 0x1687B10 Offset: 0x1686D10 VA: 0x181687B10
	internal object LoadObject(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0x16878E0 Offset: 0x1686AE0 VA: 0x1816878E0
	internal object LoadObjectV1(int pos) { }

	// RVA: 0x1688120 Offset: 0x1687320 VA: 0x181688120
	private object _LoadObjectV1(int pos) { }

	// RVA: 0x16879E0 Offset: 0x1686BE0 VA: 0x1816879E0
	internal object LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0x1688A20 Offset: 0x1687C20 VA: 0x181688A20
	private object _LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0x1686890 Offset: 0x1685A90 VA: 0x181686890
	private object DeserializeObject(int typeIndex) { }

	// RVA: 0x1687EC0 Offset: 0x16870C0 VA: 0x181687EC0
	private void ReadResources() { }

	// RVA: 0x1689630 Offset: 0x1688830 VA: 0x181689630
	private void _ReadResources() { }

	// RVA: 0x1686FB0 Offset: 0x16861B0 VA: 0x181686FB0
	private RuntimeType FindType(int typeIndex) { }
}

// Namespace: System.Resources
[ComVisible(True)]
[Serializable]
public class ResourceSet : IDisposable, IEnumerable // TypeDefIndex: 4101
{
	// Fields
	protected IResourceReader Reader; // 0x10
	protected Hashtable Table; // 0x18
	private Hashtable _caseInsensitiveTable; // 0x20

	// Methods

	// RVA: 0x168AD40 Offset: 0x1689F40 VA: 0x18168AD40
	protected void .ctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor(bool junk) { }

	// RVA: 0x168A1D0 Offset: 0x16893D0 VA: 0x18168A1D0
	private void CommonInit() { }

	// RVA: 0x168A230 Offset: 0x1689430 VA: 0x18168A230 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x151FDB0 Offset: 0x151EFB0 VA: 0x18151FDB0 Slot: 4
	public void Dispose() { }

	[ComVisible(False)]
	// RVA: 0x168A690 Offset: 0x1689890 VA: 0x18168A690 Slot: 7
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x168A690 Offset: 0x1689890 VA: 0x18168A690 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x168A600 Offset: 0x1689800 VA: 0x18168A600
	private IDictionaryEnumerator GetEnumeratorHelper() { }

	// RVA: 0x168A890 Offset: 0x1689A90 VA: 0x18168A890 Slot: 8
	public virtual string GetString(string name) { }

	// RVA: 0x168AA70 Offset: 0x1689C70 VA: 0x18168AA70 Slot: 9
	public virtual string GetString(string name, bool ignoreCase) { }

	// RVA: 0x168A6A0 Offset: 0x16898A0 VA: 0x18168A6A0 Slot: 10
	public virtual object GetObject(string name) { }

	// RVA: 0x168A780 Offset: 0x1689980 VA: 0x18168A780 Slot: 11
	public virtual object GetObject(string name, bool ignoreCase) { }

	// RVA: 0x168A6A0 Offset: 0x16898A0 VA: 0x18168A6A0
	private object GetObjectInternal(string name) { }

	// RVA: 0x168A2A0 Offset: 0x16894A0 VA: 0x18168A2A0
	private object GetCaseInsensitiveObjectInternal(string name) { }
}

// Namespace: System.Reflection
[Serializable]
public sealed class AmbiguousMatchException : SystemException // TypeDefIndex: 4102
{
	// Methods

	// RVA: 0x1675390 Offset: 0x1674590 VA: 0x181675390
	public void .ctor() { }

	// RVA: 0x1675370 Offset: 0x1674570 VA: 0x181675370
	public void .ctor(string message) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyCompanyAttribute : Attribute // TypeDefIndex: 4103
{
	// Fields
	[CompilerGenerated]
	private readonly string <Company>k__BackingField; // 0x10

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string company) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyConfigurationAttribute : Attribute // TypeDefIndex: 4104
{
	// Fields
	[CompilerGenerated]
	private readonly string <Configuration>k__BackingField; // 0x10

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string configuration) { }
}

// Namespace: System.Reflection
public enum AssemblyContentType // TypeDefIndex: 4105
{
	// Fields
	public int value__; // 0x0
	public const AssemblyContentType Default = 0;
	public const AssemblyContentType WindowsRuntime = 1;
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyCopyrightAttribute : Attribute // TypeDefIndex: 4106
{
	// Fields
	[CompilerGenerated]
	private readonly string <Copyright>k__BackingField; // 0x10

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string copyright) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyDefaultAliasAttribute : Attribute // TypeDefIndex: 4107
{
	// Fields
	[CompilerGenerated]
	private readonly string <DefaultAlias>k__BackingField; // 0x10

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string defaultAlias) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyDelaySignAttribute : Attribute // TypeDefIndex: 4108
{
	// Fields
	[CompilerGenerated]
	private readonly bool <DelaySign>k__BackingField; // 0x10

	// Methods

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool delaySign) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyDescriptionAttribute : Attribute // TypeDefIndex: 4109
{
	// Fields
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; // 0x10

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string description) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyFileVersionAttribute : Attribute // TypeDefIndex: 4110
{
	// Fields
	[CompilerGenerated]
	private readonly string <Version>k__BackingField; // 0x10

	// Methods

	// RVA: 0x16753E0 Offset: 0x16745E0 VA: 0x1816753E0
	public void .ctor(string version) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyInformationalVersionAttribute : Attribute // TypeDefIndex: 4111
{
	// Fields
	[CompilerGenerated]
	private readonly string <InformationalVersion>k__BackingField; // 0x10

	// Properties
	public string InformationalVersion { get; }

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string informationalVersion) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_InformationalVersion() { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyKeyFileAttribute : Attribute // TypeDefIndex: 4112
{
	// Fields
	[CompilerGenerated]
	private readonly string <KeyFile>k__BackingField; // 0x10

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string keyFile) { }
}

// Namespace: System.Reflection
[Usage(1, AllowMultiple = True, Inherited = False)]
public sealed class AssemblyMetadataAttribute : Attribute // TypeDefIndex: 4113
{
	// Fields
	[CompilerGenerated]
	private readonly string <Key>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <Value>k__BackingField; // 0x18

	// Properties
	public string Key { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x1675460 Offset: 0x1674660 VA: 0x181675460
	public void .ctor(string key, string value) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Key() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Value() { }
}

// Namespace: System.Reflection
[Flags]
public enum AssemblyNameFlags // TypeDefIndex: 4114
{
	// Fields
	public int value__; // 0x0
	public const AssemblyNameFlags None = 0;
	public const AssemblyNameFlags PublicKey = 1;
	public const AssemblyNameFlags EnableJITcompileOptimizer = 16384;
	public const AssemblyNameFlags EnableJITcompileTracking = 32768;
	public const AssemblyNameFlags Retargetable = 256;
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyProductAttribute : Attribute // TypeDefIndex: 4115
{
	// Fields
	[CompilerGenerated]
	private readonly string <Product>k__BackingField; // 0x10

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string product) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyTitleAttribute : Attribute // TypeDefIndex: 4116
{
	// Fields
	[CompilerGenerated]
	private readonly string <Title>k__BackingField; // 0x10

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string title) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyTrademarkAttribute : Attribute // TypeDefIndex: 4117
{
	// Fields
	[CompilerGenerated]
	private readonly string <Trademark>k__BackingField; // 0x10

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string trademark) { }
}

// Namespace: System.Reflection
public abstract class Binder // TypeDefIndex: 4118
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo culture);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] names, out object state);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object ChangeType(object value, Type type, CultureInfo culture);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ReorderArgumentArray(ref object[] args, object state);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers);
}

// Namespace: System.Reflection
[Flags]
public enum BindingFlags // TypeDefIndex: 4119
{
	// Fields
	public int value__; // 0x0
	public const BindingFlags Default = 0;
	public const BindingFlags IgnoreCase = 1;
	public const BindingFlags DeclaredOnly = 2;
	public const BindingFlags Instance = 4;
	public const BindingFlags Static = 8;
	public const BindingFlags Public = 16;
	public const BindingFlags NonPublic = 32;
	public const BindingFlags FlattenHierarchy = 64;
	public const BindingFlags InvokeMethod = 256;
	public const BindingFlags CreateInstance = 512;
	public const BindingFlags GetField = 1024;
	public const BindingFlags SetField = 2048;
	public const BindingFlags GetProperty = 4096;
	public const BindingFlags SetProperty = 8192;
	public const BindingFlags PutDispProperty = 16384;
	public const BindingFlags PutRefDispProperty = 32768;
	public const BindingFlags ExactBinding = 65536;
	public const BindingFlags SuppressChangeType = 131072;
	public const BindingFlags OptionalParamBinding = 262144;
	public const BindingFlags IgnoreReturn = 16777216;
	public const BindingFlags DoNotWrapExceptions = 33554432;
}

// Namespace: System.Reflection
[Flags]
public enum CallingConventions // TypeDefIndex: 4120
{
	// Fields
	public int value__; // 0x0
	public const CallingConventions Standard = 1;
	public const CallingConventions VarArgs = 2;
	public const CallingConventions Any = 3;
	public const CallingConventions HasThis = 32;
	public const CallingConventions ExplicitThis = 64;
}

// Namespace: System.Reflection
[Serializable]
public abstract class ConstructorInfo : MethodBase // TypeDefIndex: 4121
{
	// Fields
	public static readonly string ConstructorName; // 0x0
	public static readonly string TypeConstructorName; // 0x8

	// Properties
	public override MemberTypes MemberType { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 7
	public override MemberTypes get_MemberType() { }

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x1676F30 Offset: 0x1676130 VA: 0x181676F30
	public object Invoke(object[] parameters) { }

	// RVA: -1 Offset: -1 Slot: 45
	public abstract object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

	// RVA: 0x1676F20 Offset: 0x1676120 VA: 0x181676F20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15C9510 Offset: 0x15C8710 VA: 0x1815C9510 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1676FE0 Offset: 0x16761E0 VA: 0x181676FE0
	public static bool op_Equality(ConstructorInfo left, ConstructorInfo right) { }

	// RVA: 0x1677010 Offset: 0x1676210 VA: 0x181677010
	public static bool op_Inequality(ConstructorInfo left, ConstructorInfo right) { }

	// RVA: 0x1676F70 Offset: 0x1676170 VA: 0x181676F70
	private static void .cctor() { }
}

// Namespace: System.Reflection
[Serializable]
public class CustomAttributeFormatException : FormatException // TypeDefIndex: 4122
{
	// Methods

	// RVA: 0x1677330 Offset: 0x1676530 VA: 0x181677330
	public void .ctor() { }

	// RVA: 0x1677380 Offset: 0x1676580 VA: 0x181677380
	public void .ctor(string message) { }

	// RVA: 0x16773B0 Offset: 0x16765B0 VA: 0x1816773B0
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x15A17F0 Offset: 0x15A09F0 VA: 0x1815A17F0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Reflection
[Usage(1036)]
public sealed class DefaultMemberAttribute : Attribute // TypeDefIndex: 4123
{
	// Fields
	[CompilerGenerated]
	private readonly string <MemberName>k__BackingField; // 0x10

	// Properties
	public string MemberName { get; }

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string memberName) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_MemberName() { }
}

// Namespace: System.Reflection
[Flags]
public enum EventAttributes // TypeDefIndex: 4124
{
	// Fields
	public int value__; // 0x0
	public const EventAttributes None = 0;
	public const EventAttributes SpecialName = 512;
	public const EventAttributes RTSpecialName = 1024;
	public const EventAttributes ReservedMask = 1024;
}

// Namespace: 
private sealed class EventInfo.AddEventAdapter : MulticastDelegate // TypeDefIndex: 4125
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object _this, Delegate dele) { }
}

// Namespace: System.Reflection
[Serializable]
public abstract class EventInfo : MemberInfo // TypeDefIndex: 4126
{
	// Fields
	private EventInfo.AddEventAdapter cached_add_event; // 0x10

	// Properties
	public override MemberTypes MemberType { get; }
	public virtual Type EventHandlerType { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x161A250 Offset: 0x1619450 VA: 0x18161A250 Slot: 17
	public MethodInfo GetAddMethod() { }

	// RVA: 0x16778D0 Offset: 0x1676AD0 VA: 0x1816778D0 Slot: 18
	public MethodInfo GetRemoveMethod() { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract MethodInfo GetAddMethod(bool nonPublic);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract MethodInfo GetRemoveMethod(bool nonPublic);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract MethodInfo GetRaiseMethod(bool nonPublic);

	// RVA: 0x16778F0 Offset: 0x1676AF0 VA: 0x1816778F0 Slot: 22
	public virtual Type get_EventHandlerType() { }

	// RVA: 0x1676F20 Offset: 0x1676120 VA: 0x181676F20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15C9510 Offset: 0x15C8710 VA: 0x1815C9510 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1676FE0 Offset: 0x16761E0 VA: 0x181676FE0
	public static bool op_Equality(EventInfo left, EventInfo right) { }

	// RVA: 0x1677A40 Offset: 0x1676C40 VA: 0x181677A40
	public static bool op_Inequality(EventInfo left, EventInfo right) { }

	// RVA: 0x1677A30 Offset: 0x1676C30 VA: 0x181677A30
	private static EventInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	// RVA: 0x1677800 Offset: 0x1676A00 VA: 0x181677800
	internal static EventInfo GetEventFromHandle(RuntimeEventHandle handle, RuntimeTypeHandle reflectedType) { }
}

// Namespace: System.Reflection
[Flags]
public enum ExceptionHandlingClauseOptions // TypeDefIndex: 4127
{
	// Fields
	public int value__; // 0x0
	public const ExceptionHandlingClauseOptions Clause = 0;
	public const ExceptionHandlingClauseOptions Filter = 1;
	public const ExceptionHandlingClauseOptions Finally = 2;
	public const ExceptionHandlingClauseOptions Fault = 4;
}

// Namespace: System.Reflection
[Flags]
public enum FieldAttributes // TypeDefIndex: 4128
{
	// Fields
	public int value__; // 0x0
	public const FieldAttributes FieldAccessMask = 7;
	public const FieldAttributes PrivateScope = 0;
	public const FieldAttributes Private = 1;
	public const FieldAttributes FamANDAssem = 2;
	public const FieldAttributes Assembly = 3;
	public const FieldAttributes Family = 4;
	public const FieldAttributes FamORAssem = 5;
	public const FieldAttributes Public = 6;
	public const FieldAttributes Static = 16;
	public const FieldAttributes InitOnly = 32;
	public const FieldAttributes Literal = 64;
	public const FieldAttributes NotSerialized = 128;
	public const FieldAttributes SpecialName = 512;
	public const FieldAttributes PinvokeImpl = 8192;
	public const FieldAttributes RTSpecialName = 1024;
	public const FieldAttributes HasFieldMarshal = 4096;
	public const FieldAttributes HasDefault = 32768;
	public const FieldAttributes HasFieldRVA = 256;
	public const FieldAttributes ReservedMask = 38144;
}

// Namespace: System.Reflection
[Serializable]
public abstract class FieldInfo : MemberInfo // TypeDefIndex: 4129
{
	// Properties
	public override MemberTypes MemberType { get; }
	public abstract FieldAttributes Attributes { get; }
	public abstract Type FieldType { get; }
	public bool IsInitOnly { get; }
	public bool IsLiteral { get; }
	public bool IsNotSerialized { get; }
	public bool IsStatic { get; }
	public bool IsAssembly { get; }
	public bool IsFamilyAndAssembly { get; }
	public bool IsPrivate { get; }
	public bool IsPublic { get; }
	public abstract RuntimeFieldHandle FieldHandle { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x68EEE0 Offset: 0x68E0E0 VA: 0x18068EEE0 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract FieldAttributes get_Attributes();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract Type get_FieldType();

	// RVA: 0x1679230 Offset: 0x1678430 VA: 0x181679230 Slot: 19
	public bool get_IsInitOnly() { }

	// RVA: 0x1679260 Offset: 0x1678460 VA: 0x181679260 Slot: 20
	public bool get_IsLiteral() { }

	// RVA: 0x1679290 Offset: 0x1678490 VA: 0x181679290 Slot: 21
	public bool get_IsNotSerialized() { }

	// RVA: 0x1679320 Offset: 0x1678520 VA: 0x181679320 Slot: 22
	public bool get_IsStatic() { }

	// RVA: 0x16791D0 Offset: 0x16783D0 VA: 0x1816791D0 Slot: 23
	public bool get_IsAssembly() { }

	// RVA: 0x1679200 Offset: 0x1678400 VA: 0x181679200 Slot: 24
	public bool get_IsFamilyAndAssembly() { }

	// RVA: 0x16792C0 Offset: 0x16784C0 VA: 0x1816792C0 Slot: 25
	public bool get_IsPrivate() { }

	// RVA: 0x16792F0 Offset: 0x16784F0 VA: 0x1816792F0 Slot: 26
	public bool get_IsPublic() { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract RuntimeFieldHandle get_FieldHandle();

	// RVA: 0x1676F20 Offset: 0x1676120 VA: 0x181676F20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15C9510 Offset: 0x15C8710 VA: 0x1815C9510 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1676FE0 Offset: 0x16761E0 VA: 0x181676FE0
	public static bool op_Equality(FieldInfo left, FieldInfo right) { }

	// RVA: 0x1677A40 Offset: 0x1676C40 VA: 0x181677A40
	public static bool op_Inequality(FieldInfo left, FieldInfo right) { }

	// RVA: -1 Offset: -1 Slot: 28
	public abstract object GetValue(object obj);

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x1679130 Offset: 0x1678330 VA: 0x181679130 Slot: 29
	public void SetValue(object obj, object value) { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

	[CLSCompliant(False)]
	// RVA: 0x16790E0 Offset: 0x16782E0 VA: 0x1816790E0 Slot: 31
	public virtual void SetValueDirect(TypedReference obj, object value) { }

	// RVA: 0x1679090 Offset: 0x1678290 VA: 0x181679090 Slot: 32
	public virtual object GetRawConstantValue() { }

	// RVA: 0x1679350 Offset: 0x1678550 VA: 0x181679350
	private static FieldInfo internal_from_handle_type(IntPtr field_handle, IntPtr type_handle) { }

	// RVA: 0x1678650 Offset: 0x1677850 VA: 0x181678650
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle) { }

	[ComVisible(False)]
	// RVA: 0x16786C0 Offset: 0x16778C0 VA: 0x1816786C0
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType) { }

	// RVA: 0x1678790 Offset: 0x1677990 VA: 0x181678790 Slot: 33
	internal virtual int GetFieldOffset() { }

	// RVA: 0x16181A0 Offset: 0x16173A0 VA: 0x1816181A0
	private MarshalAsAttribute get_marshal_info() { }

	// RVA: 0x1678E30 Offset: 0x1678030 VA: 0x181678E30
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x16787E0 Offset: 0x16779E0 VA: 0x1816787E0
	internal CustomAttributeData[] GetPseudoCustomAttributesData() { }
}

// Namespace: System.Reflection
[Flags]
public enum GenericParameterAttributes // TypeDefIndex: 4130
{
	// Fields
	public int value__; // 0x0
	public const GenericParameterAttributes None = 0;
	public const GenericParameterAttributes VarianceMask = 3;
	public const GenericParameterAttributes Covariant = 1;
	public const GenericParameterAttributes Contravariant = 2;
	public const GenericParameterAttributes SpecialConstraintMask = 28;
	public const GenericParameterAttributes ReferenceTypeConstraint = 4;
	public const GenericParameterAttributes NotNullableValueTypeConstraint = 8;
	public const GenericParameterAttributes DefaultConstructorConstraint = 16;
}

// Namespace: System.Reflection
public interface ICustomAttributeProvider // TypeDefIndex: 4131
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object[] GetCustomAttributes(bool inherit);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object[] GetCustomAttributes(Type attributeType, bool inherit);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsDefined(Type attributeType, bool inherit);
}

// Namespace: System.Reflection
public interface IReflectableType // TypeDefIndex: 4132
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TypeInfo GetTypeInfo();
}

// Namespace: System.Reflection
[Extension]
public static class IntrospectionExtensions // TypeDefIndex: 4133
{
	// Methods

	[Extension]
	// RVA: 0x167A680 Offset: 0x1679880 VA: 0x18167A680
	public static TypeInfo GetTypeInfo(Type type) { }
}

// Namespace: System.Reflection
[Serializable]
public class InvalidFilterCriteriaException : ApplicationException // TypeDefIndex: 4134
{
	// Methods

	// RVA: 0x167A860 Offset: 0x1679A60 VA: 0x18167A860
	public void .ctor() { }

	// RVA: 0x167A7F0 Offset: 0x16799F0 VA: 0x18167A7F0
	public void .ctor(string message) { }

	// RVA: 0x167A840 Offset: 0x1679A40 VA: 0x18167A840
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x167A820 Offset: 0x1679A20 VA: 0x18167A820
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Reflection
public class ManifestResourceInfo // TypeDefIndex: 4135
{
	// Fields
	[CompilerGenerated]
	private readonly Assembly <ReferencedAssembly>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <FileName>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly ResourceLocation <ResourceLocation>k__BackingField; // 0x20

	// Properties
	public virtual Assembly ReferencedAssembly { get; }
	public virtual string FileName { get; }
	public virtual ResourceLocation ResourceLocation { get; }

	// Methods

	// RVA: 0xB18200 Offset: 0xB17400 VA: 0x180B18200
	public void .ctor(Assembly containingAssembly, string containingFileName, ResourceLocation resourceLocation) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public virtual Assembly get_ReferencedAssembly() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 5
	public virtual string get_FileName() { }

	[CompilerGenerated]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 6
	public virtual ResourceLocation get_ResourceLocation() { }
}

// Namespace: System.Reflection
public sealed class MemberFilter : MulticastDelegate // TypeDefIndex: 4136
{
	// Methods

	// RVA: 0x12052D0 Offset: 0x12044D0 VA: 0x1812052D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual bool Invoke(MemberInfo m, object filterCriteria) { }
}

// Namespace: System.Reflection
[Serializable]
public abstract class MemberInfo : ICustomAttributeProvider // TypeDefIndex: 4137
{
	// Properties
	public abstract MemberTypes MemberType { get; }
	public abstract string Name { get; }
	public abstract Type DeclaringType { get; }
	public abstract Type ReflectedType { get; }
	public virtual Module Module { get; }
	public virtual int MetadataToken { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract MemberTypes get_MemberType();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Type get_DeclaringType();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Type get_ReflectedType();

	// RVA: 0x167FB10 Offset: 0x167ED10 VA: 0x18167FB10 Slot: 11
	public virtual Module get_Module() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool IsDefined(Type attributeType, bool inherit);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract object[] GetCustomAttributes(bool inherit);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract object[] GetCustomAttributes(Type attributeType, bool inherit);

	// RVA: 0x167FAA0 Offset: 0x167ECA0 VA: 0x18167FAA0 Slot: 15
	public virtual IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x167FAD0 Offset: 0x167ECD0 VA: 0x18167FAD0 Slot: 16
	public virtual int get_MetadataToken() { }

	// RVA: 0x1676F20 Offset: 0x1676120 VA: 0x181676F20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15C9510 Offset: 0x15C8710 VA: 0x1815C9510 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x167FBF0 Offset: 0x167EDF0 VA: 0x18167FBF0
	public static bool op_Equality(MemberInfo left, MemberInfo right) { }

	// RVA: 0x1680020 Offset: 0x167F220 VA: 0x181680020
	public static bool op_Inequality(MemberInfo left, MemberInfo right) { }
}

// Namespace: System.Reflection
[Flags]
public enum MemberTypes // TypeDefIndex: 4138
{
	// Fields
	public int value__; // 0x0
	public const MemberTypes Constructor = 1;
	public const MemberTypes Event = 2;
	public const MemberTypes Field = 4;
	public const MemberTypes Method = 8;
	public const MemberTypes Property = 16;
	public const MemberTypes TypeInfo = 32;
	public const MemberTypes Custom = 64;
	public const MemberTypes NestedType = 128;
	public const MemberTypes All = 191;
}

// Namespace: System.Reflection
[Flags]
public enum MethodAttributes // TypeDefIndex: 4139
{
	// Fields
	public int value__; // 0x0
	public const MethodAttributes MemberAccessMask = 7;
	public const MethodAttributes PrivateScope = 0;
	public const MethodAttributes Private = 1;
	public const MethodAttributes FamANDAssem = 2;
	public const MethodAttributes Assembly = 3;
	public const MethodAttributes Family = 4;
	public const MethodAttributes FamORAssem = 5;
	public const MethodAttributes Public = 6;
	public const MethodAttributes Static = 16;
	public const MethodAttributes Final = 32;
	public const MethodAttributes Virtual = 64;
	public const MethodAttributes HideBySig = 128;
	public const MethodAttributes CheckAccessOnOverride = 512;
	public const MethodAttributes VtableLayoutMask = 256;
	public const MethodAttributes ReuseSlot = 0;
	public const MethodAttributes NewSlot = 256;
	public const MethodAttributes Abstract = 1024;
	public const MethodAttributes SpecialName = 2048;
	public const MethodAttributes PinvokeImpl = 8192;
	public const MethodAttributes UnmanagedExport = 8;
	public const MethodAttributes RTSpecialName = 4096;
	public const MethodAttributes HasSecurity = 16384;
	public const MethodAttributes RequireSecObject = 32768;
	public const MethodAttributes ReservedMask = 53248;
}

// Namespace: System.Reflection
[Serializable]
public abstract class MethodBase : MemberInfo // TypeDefIndex: 4140
{
	// Properties
	public abstract MethodAttributes Attributes { get; }
	public virtual MethodImplAttributes MethodImplementationFlags { get; }
	public virtual CallingConventions CallingConvention { get; }
	public bool IsAbstract { get; }
	public bool IsConstructor { get; }
	public bool IsSpecialName { get; }
	public bool IsStatic { get; }
	public bool IsVirtual { get; }
	public bool IsAssembly { get; }
	public bool IsFamilyAndAssembly { get; }
	public bool IsPrivate { get; }
	public bool IsPublic { get; }
	public virtual bool IsGenericMethod { get; }
	public virtual bool IsGenericMethodDefinition { get; }
	public virtual bool ContainsGenericParameters { get; }
	public abstract RuntimeMethodHandle MethodHandle { get; }
	public virtual bool IsSecurityCritical { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract ParameterInfo[] GetParameters();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract MethodAttributes get_Attributes();

	// RVA: 0x15C9C90 Offset: 0x15C8E90 VA: 0x1815C9C90 Slot: 19
	public virtual MethodImplAttributes get_MethodImplementationFlags() { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract MethodImplAttributes GetMethodImplementationFlags();

	// RVA: 0x16803D0 Offset: 0x167F5D0 VA: 0x1816803D0 Slot: 21
	public virtual MethodBody GetMethodBody() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 22
	public virtual CallingConventions get_CallingConvention() { }

	// RVA: 0x1680920 Offset: 0x167FB20 VA: 0x181680920 Slot: 23
	public bool get_IsAbstract() { }

	// RVA: 0x1680980 Offset: 0x167FB80 VA: 0x181680980 Slot: 24
	public bool get_IsConstructor() { }

	// RVA: 0x1680AF0 Offset: 0x167FCF0 VA: 0x181680AF0 Slot: 25
	public bool get_IsSpecialName() { }

	// RVA: 0x1680B20 Offset: 0x167FD20 VA: 0x181680B20 Slot: 26
	public bool get_IsStatic() { }

	// RVA: 0x1680B50 Offset: 0x167FD50 VA: 0x181680B50 Slot: 27
	public bool get_IsVirtual() { }

	// RVA: 0x1680950 Offset: 0x167FB50 VA: 0x181680950 Slot: 28
	public bool get_IsAssembly() { }

	// RVA: 0x1680A30 Offset: 0x167FC30 VA: 0x181680A30 Slot: 29
	public bool get_IsFamilyAndAssembly() { }

	// RVA: 0x1680A60 Offset: 0x167FC60 VA: 0x181680A60 Slot: 30
	public bool get_IsPrivate() { }

	// RVA: 0x1680A90 Offset: 0x167FC90 VA: 0x181680A90 Slot: 31
	public bool get_IsPublic() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 32
	public virtual bool get_IsGenericMethod() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 33
	public virtual bool get_IsGenericMethodDefinition() { }

	// RVA: 0x1680380 Offset: 0x167F580 VA: 0x181680380 Slot: 34
	public virtual Type[] GetGenericArguments() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 35
	public virtual bool get_ContainsGenericParameters() { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x16808E0 Offset: 0x167FAE0 VA: 0x1816808E0 Slot: 36
	public object Invoke(object obj, object[] parameters) { }

	// RVA: -1 Offset: -1 Slot: 37
	public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

	// RVA: -1 Offset: -1 Slot: 38
	public abstract RuntimeMethodHandle get_MethodHandle();

	// RVA: 0x1680AC0 Offset: 0x167FCC0 VA: 0x181680AC0 Slot: 39
	public virtual bool get_IsSecurityCritical() { }

	// RVA: 0x1676F20 Offset: 0x1676120 VA: 0x181676F20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15C9510 Offset: 0x15C8710 VA: 0x1815C9510 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1680B80 Offset: 0x167FD80 VA: 0x181680B80
	public static bool op_Equality(MethodBase left, MethodBase right) { }

	// RVA: 0x1680E20 Offset: 0x1680020 VA: 0x181680E20
	public static bool op_Inequality(MethodBase left, MethodBase right) { }

	// RVA: 0x75C760 Offset: 0x75B960 VA: 0x18075C760 Slot: 40
	internal virtual ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x16808B0 Offset: 0x167FAB0 VA: 0x1816808B0 Slot: 41
	internal virtual int GetParametersCount() { }

	// RVA: 0x1680240 Offset: 0x167F440 VA: 0x181680240 Slot: 42
	internal virtual string FormatNameAndSig(bool serialization) { }

	// RVA: 0x1680780 Offset: 0x167F980 VA: 0x181680780 Slot: 43
	internal virtual Type[] GetParameterTypes() { }

	// RVA: 0x75C760 Offset: 0x75B960 VA: 0x18075C760 Slot: 44
	internal virtual ParameterInfo[] GetParametersNoCopy() { }

	// RVA: 0x1680410 Offset: 0x167F610 VA: 0x181680410
	public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle) { }

	[ComVisible(False)]
	// RVA: 0x1680670 Offset: 0x167F870 VA: 0x181680670
	public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle, RuntimeTypeHandle declaringType) { }

	// RVA: 0x1680040 Offset: 0x167F240 VA: 0x181680040
	internal static string ConstructParameters(Type[] parameterTypes, CallingConventions callingConvention, bool serialization) { }
}

// Namespace: System.Reflection
public enum MethodImplAttributes // TypeDefIndex: 4141
{
	// Fields
	public int value__; // 0x0
	public const MethodImplAttributes CodeTypeMask = 3;
	public const MethodImplAttributes IL = 0;
	public const MethodImplAttributes Native = 1;
	public const MethodImplAttributes OPTIL = 2;
	public const MethodImplAttributes Runtime = 3;
	public const MethodImplAttributes ManagedMask = 4;
	public const MethodImplAttributes Unmanaged = 4;
	public const MethodImplAttributes Managed = 0;
	public const MethodImplAttributes ForwardRef = 16;
	public const MethodImplAttributes PreserveSig = 128;
	public const MethodImplAttributes InternalCall = 4096;
	public const MethodImplAttributes Synchronized = 32;
	public const MethodImplAttributes NoInlining = 8;
	public const MethodImplAttributes AggressiveInlining = 256;
	public const MethodImplAttributes NoOptimization = 64;
	public const MethodImplAttributes MaxMethodImplVal = 65535;
	public const MethodImplAttributes SecurityMitigations = 1024;
}

// Namespace: System.Reflection
[Serializable]
public abstract class MethodInfo : MethodBase // TypeDefIndex: 4142
{
	// Properties
	public override MemberTypes MemberType { get; }
	public virtual ParameterInfo ReturnParameter { get; }
	public virtual Type ReturnType { get; }
	internal virtual int GenericParameterCount { get; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	protected void .ctor() { }

	// RVA: 0xAA00E0 Offset: 0xA9F2E0 VA: 0x180AA00E0 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x16B4D40 Offset: 0x16B3F40 VA: 0x1816B4D40 Slot: 45
	public virtual ParameterInfo get_ReturnParameter() { }

	// RVA: 0x16B4D70 Offset: 0x16B3F70 VA: 0x1816B4D70 Slot: 46
	public virtual Type get_ReturnType() { }

	// RVA: 0x16B4C10 Offset: 0x16B3E10 VA: 0x1816B4C10 Slot: 34
	public override Type[] GetGenericArguments() { }

	// RVA: 0x16B4C60 Offset: 0x16B3E60 VA: 0x1816B4C60 Slot: 47
	public virtual MethodInfo GetGenericMethodDefinition() { }

	// RVA: 0x16B4CC0 Offset: 0x16B3EC0 VA: 0x1816B4CC0 Slot: 48
	public virtual MethodInfo MakeGenericMethod(Type[] typeArguments) { }

	// RVA: -1 Offset: -1 Slot: 49
	public abstract MethodInfo GetBaseDefinition();

	// RVA: 0x16B4B60 Offset: 0x16B3D60 VA: 0x1816B4B60 Slot: 50
	public virtual Delegate CreateDelegate(Type delegateType) { }

	// RVA: 0x16B4BB0 Offset: 0x16B3DB0 VA: 0x1816B4BB0 Slot: 51
	public virtual Delegate CreateDelegate(Type delegateType, object target) { }

	// RVA: 0x16B4C00 Offset: 0x16B3E00 VA: 0x1816B4C00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x16B4CB0 Offset: 0x16B3EB0 VA: 0x1816B4CB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1676FE0 Offset: 0x16761E0 VA: 0x181676FE0
	public static bool op_Equality(MethodInfo left, MethodInfo right) { }

	// RVA: 0x1677A40 Offset: 0x1676C40 VA: 0x181677A40
	public static bool op_Inequality(MethodInfo left, MethodInfo right) { }

	// RVA: 0x16B4D10 Offset: 0x16B3F10 VA: 0x1816B4D10 Slot: 52
	internal virtual int get_GenericParameterCount() { }
}

// Namespace: System.Reflection
public sealed class Missing : ISerializable // TypeDefIndex: 4143
{
	// Fields
	public static readonly Missing Value; // 0x0

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x16B4DB0 Offset: 0x16B3FB0 VA: 0x1816B4DB0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16B4DF0 Offset: 0x16B3FF0 VA: 0x1816B4DF0
	private static void .cctor() { }
}

// Namespace: System.Reflection
[Serializable]
public abstract class Module : ICustomAttributeProvider, ISerializable, _Module // TypeDefIndex: 4144
{
	// Fields
	public static readonly TypeFilter FilterTypeName; // 0x0
	public static readonly TypeFilter FilterTypeNameIgnoreCase; // 0x8
	private const BindingFlags DefaultLookup = 28;

	// Properties
	public virtual Assembly Assembly { get; }
	public virtual string FullyQualifiedName { get; }
	public virtual string Name { get; }
	public virtual Guid ModuleVersionId { get; }
	public virtual string ScopeName { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x16B53D0 Offset: 0x16B45D0 VA: 0x1816B53D0 Slot: 8
	public virtual Assembly get_Assembly() { }

	// RVA: 0x16B5400 Offset: 0x16B4600 VA: 0x1816B5400 Slot: 9
	public virtual string get_FullyQualifiedName() { }

	// RVA: 0x16B5460 Offset: 0x16B4660 VA: 0x1816B5460 Slot: 10
	public virtual string get_Name() { }

	// RVA: 0x16B5430 Offset: 0x16B4630 VA: 0x1816B5430 Slot: 11
	public virtual Guid get_ModuleVersionId() { }

	// RVA: 0x16B5490 Offset: 0x16B4690 VA: 0x1816B5490 Slot: 12
	public virtual string get_ScopeName() { }

	// RVA: 0x16B52B0 Offset: 0x16B44B0 VA: 0x1816B52B0 Slot: 13
	public virtual bool IsResource() { }

	// RVA: 0x16B5280 Offset: 0x16B4480 VA: 0x1816B5280 Slot: 14
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x16B5180 Offset: 0x16B4380 VA: 0x1816B5180 Slot: 15
	public virtual IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x16B51E0 Offset: 0x16B43E0 VA: 0x1816B51E0 Slot: 16
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x16B51B0 Offset: 0x16B43B0 VA: 0x1816B51B0 Slot: 17
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x16B52E0 Offset: 0x16B44E0 VA: 0x1816B52E0 Slot: 18
	public virtual MemberInfo ResolveMember(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments) { }

	// RVA: 0x16B5250 Offset: 0x16B4450 VA: 0x1816B5250 Slot: 19
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1676F20 Offset: 0x1676120 VA: 0x181676F20 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x15C9510 Offset: 0x15C8710 VA: 0x1815C9510 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1676FE0 Offset: 0x16761E0 VA: 0x181676FE0
	public static bool op_Equality(Module left, Module right) { }

	// RVA: 0x7F66E0 Offset: 0x7F58E0 VA: 0x1807F66E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x16B5000 Offset: 0x16B4200 VA: 0x1816B5000
	private static bool FilterTypeNameImpl(Type cls, object filterCriteria) { }

	// RVA: 0x16B4E50 Offset: 0x16B4050 VA: 0x1816B4E50
	private static bool FilterTypeNameIgnoreCaseImpl(Type cls, object filterCriteria) { }

	// RVA: 0x16B5210 Offset: 0x16B4410 VA: 0x1816B5210 Slot: 20
	internal virtual Guid GetModuleVersionId() { }

	// RVA: 0x16B5310 Offset: 0x16B4510 VA: 0x1816B5310
	private static void .cctor() { }
}

// Namespace: System.Reflection
[Usage(8157, AllowMultiple = True, Inherited = False)]
public sealed class ObfuscationAttribute : Attribute // TypeDefIndex: 4145
{
	// Fields
	[CompilerGenerated]
	private bool <StripAfterObfuscation>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <Exclude>k__BackingField; // 0x11
	[CompilerGenerated]
	private bool <ApplyToMembers>k__BackingField; // 0x12
	[CompilerGenerated]
	private string <Feature>k__BackingField; // 0x18

	// Properties
	public bool Exclude { set; }

	// Methods

	// RVA: 0x16B56A0 Offset: 0x16B48A0 VA: 0x1816B56A0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x4BD750 Offset: 0x4BC950 VA: 0x1804BD750
	public void set_Exclude(bool value) { }
}

// Namespace: System.Reflection
[Flags]
public enum ParameterAttributes // TypeDefIndex: 4146
{
	// Fields
	public int value__; // 0x0
	public const ParameterAttributes None = 0;
	public const ParameterAttributes In = 1;
	public const ParameterAttributes Out = 2;
	public const ParameterAttributes Lcid = 4;
	public const ParameterAttributes Retval = 8;
	public const ParameterAttributes Optional = 16;
	public const ParameterAttributes HasDefault = 4096;
	public const ParameterAttributes HasFieldMarshal = 8192;
	public const ParameterAttributes Reserved3 = 16384;
	public const ParameterAttributes Reserved4 = 32768;
	public const ParameterAttributes ReservedMask = 61440;
}

// Namespace: System.Reflection
[Serializable]
public class ParameterInfo : ICustomAttributeProvider, IObjectReference, _ParameterInfo // TypeDefIndex: 4147
{
	// Fields
	protected ParameterAttributes AttrsImpl; // 0x10
	protected Type ClassImpl; // 0x18
	protected object DefaultValueImpl; // 0x20
	protected MemberInfo MemberImpl; // 0x28
	protected string NameImpl; // 0x30
	protected int PositionImpl; // 0x38
	private const int MetadataToken_ParamDef = 134217728;

	// Properties
	public virtual ParameterAttributes Attributes { get; }
	public virtual MemberInfo Member { get; }
	public virtual string Name { get; }
	public virtual Type ParameterType { get; }
	public virtual int Position { get; }
	public bool IsIn { get; }
	public bool IsOptional { get; }
	public bool IsOut { get; }
	public virtual object DefaultValue { get; }
	public virtual bool HasDefaultValue { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 8
	public virtual ParameterAttributes get_Attributes() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 9
	public virtual MemberInfo get_Member() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 10
	public virtual string get_Name() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 11
	public virtual Type get_ParameterType() { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0 Slot: 12
	public virtual int get_Position() { }

	// RVA: 0x16BA3B0 Offset: 0x16B95B0 VA: 0x1816BA3B0
	public bool get_IsIn() { }

	// RVA: 0x16BA3D0 Offset: 0x16B95D0 VA: 0x1816BA3D0
	public bool get_IsOptional() { }

	// RVA: 0x16BA400 Offset: 0x16B9600 VA: 0x1816BA400
	public bool get_IsOut() { }

	// RVA: 0x16BA350 Offset: 0x16B9550 VA: 0x1816BA350 Slot: 13
	public virtual object get_DefaultValue() { }

	// RVA: 0x16BA380 Offset: 0x16B9580 VA: 0x1816BA380 Slot: 14
	public virtual bool get_HasDefaultValue() { }

	// RVA: 0x16BA220 Offset: 0x16B9420 VA: 0x1816BA220 Slot: 15
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x16B9CB0 Offset: 0x16B8EB0 VA: 0x1816B9CB0 Slot: 16
	public virtual IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x16B9CE0 Offset: 0x16B8EE0 VA: 0x1816B9CE0 Slot: 17
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x16B9D10 Offset: 0x16B8F10 VA: 0x1816B9D10 Slot: 18
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x16B9DD0 Offset: 0x16B8FD0 VA: 0x1816B9DD0 Slot: 7
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x16BA2C0 Offset: 0x16B94C0 VA: 0x1816BA2C0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Reflection
[DefaultMember("Item")]
[IsReadOnly]
public struct ParameterModifier // TypeDefIndex: 4148
{
	// Fields
	private readonly bool[] _byRef; // 0x0
}

// Namespace: System.Reflection
[CLSCompliant(False)]
public sealed class Pointer : ISerializable // TypeDefIndex: 4149
{
	// Fields
	private readonly void* _ptr; // 0x10
	private readonly Type _ptrType; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	private void .ctor(void* ptr, Type ptrType) { }

	// RVA: 0x16BA430 Offset: 0x16B9630 VA: 0x1816BA430
	public static object Box(void* ptr, Type type) { }

	// RVA: 0x16BA600 Offset: 0x16B9800 VA: 0x1816BA600 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Reflection
public enum ProcessorArchitecture // TypeDefIndex: 4150
{
	// Fields
	public int value__; // 0x0
	public const ProcessorArchitecture None = 0;
	public const ProcessorArchitecture MSIL = 1;
	public const ProcessorArchitecture X86 = 2;
	public const ProcessorArchitecture IA64 = 3;
	public const ProcessorArchitecture Amd64 = 4;
	public const ProcessorArchitecture Arm = 5;
}

// Namespace: System.Reflection
[Flags]
public enum PropertyAttributes // TypeDefIndex: 4151
{
	// Fields
	public int value__; // 0x0
	public const PropertyAttributes None = 0;
	public const PropertyAttributes SpecialName = 512;
	public const PropertyAttributes RTSpecialName = 1024;
	public const PropertyAttributes HasDefault = 4096;
	public const PropertyAttributes Reserved2 = 8192;
	public const PropertyAttributes Reserved3 = 16384;
	public const PropertyAttributes Reserved4 = 32768;
	public const PropertyAttributes ReservedMask = 62464;
}

// Namespace: System.Reflection
[Serializable]
public abstract class PropertyInfo : MemberInfo // TypeDefIndex: 4152
{
	// Properties
	public override MemberTypes MemberType { get; }
	public abstract Type PropertyType { get; }
	public abstract bool CanRead { get; }
	public abstract bool CanWrite { get; }
	public virtual MethodInfo GetMethod { get; }
	public virtual MethodInfo SetMethod { get; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	protected void .ctor() { }

	// RVA: 0x6F8DD0 Offset: 0x6F7FD0 VA: 0x1806F8DD0 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract Type get_PropertyType();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract ParameterInfo[] GetIndexParameters();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract bool get_CanRead();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool get_CanWrite();

	// RVA: 0x16BA730 Offset: 0x16B9930 VA: 0x1816BA730 Slot: 21
	public virtual MethodInfo get_GetMethod() { }

	// RVA: 0x16AE280 Offset: 0x16AD480 VA: 0x1816AE280 Slot: 22
	public MethodInfo GetGetMethod() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract MethodInfo GetGetMethod(bool nonPublic);

	// RVA: 0x16BA750 Offset: 0x16B9950 VA: 0x1816BA750 Slot: 24
	public virtual MethodInfo get_SetMethod() { }

	// RVA: 0x16BA640 Offset: 0x16B9840 VA: 0x1816BA640 Slot: 25
	public MethodInfo GetSetMethod() { }

	// RVA: -1 Offset: -1 Slot: 26
	public abstract MethodInfo GetSetMethod(bool nonPublic);

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x16BA660 Offset: 0x16B9860 VA: 0x1816BA660
	public object GetValue(object obj) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x16BA680 Offset: 0x16B9880 VA: 0x1816BA680 Slot: 27
	public virtual object GetValue(object obj, object[] index) { }

	// RVA: -1 Offset: -1 Slot: 28
	public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x16BA6C0 Offset: 0x16B98C0 VA: 0x1816BA6C0
	public void SetValue(object obj, object value) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x16BA6F0 Offset: 0x16B98F0 VA: 0x1816BA6F0 Slot: 29
	public virtual void SetValue(object obj, object value, object[] index) { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	// RVA: 0x16B4C00 Offset: 0x16B3E00 VA: 0x1816B4C00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x16B4CB0 Offset: 0x16B3EB0 VA: 0x1816B4CB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1676FE0 Offset: 0x16761E0 VA: 0x181676FE0
	public static bool op_Equality(PropertyInfo left, PropertyInfo right) { }

	// RVA: 0x1677A40 Offset: 0x1676C40 VA: 0x181677A40
	public static bool op_Inequality(PropertyInfo left, PropertyInfo right) { }
}

// Namespace: System.Reflection
[Serializable]
public sealed class ReflectionTypeLoadException : SystemException, ISerializable // TypeDefIndex: 4153
{
	// Fields
	[CompilerGenerated]
	private readonly Type[] <Types>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly Exception[] <LoaderExceptions>k__BackingField; // 0x98

	// Properties
	public Exception[] LoaderExceptions { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x16BAB30 Offset: 0x16B9D30 VA: 0x1816BAB30
	public void .ctor(Type[] classes, Exception[] exceptions) { }

	// RVA: 0x16BAA00 Offset: 0x16B9C00 VA: 0x1816BAA00
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16BA8D0 Offset: 0x16B9AD0 VA: 0x1816BA8D0 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CompilerGenerated]
	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50
	public Exception[] get_LoaderExceptions() { }

	// RVA: 0x16BAB80 Offset: 0x16B9D80 VA: 0x1816BAB80 Slot: 5
	public override string get_Message() { }

	// RVA: 0x16BA9F0 Offset: 0x16B9BF0 VA: 0x1816BA9F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x16BA770 Offset: 0x16B9970 VA: 0x1816BA770
	private string CreateString(bool isMessage) { }
}

// Namespace: System.Reflection
[Flags]
public enum ResourceLocation // TypeDefIndex: 4154
{
	// Fields
	public int value__; // 0x0
	public const ResourceLocation ContainedInAnotherAssembly = 2;
	public const ResourceLocation ContainedInManifestFile = 4;
	public const ResourceLocation Embedded = 1;
}

// Namespace: System.Reflection
internal sealed class SignatureArrayType : SignatureHasElementType // TypeDefIndex: 4155
{
	// Fields
	private readonly int _rank; // 0x20
	private readonly bool _isMultiDim; // 0x24

	// Properties
	public sealed override bool IsSZArray { get; }
	public sealed override bool IsVariableBoundArray { get; }
	protected sealed override string Suffix { get; }

	// Methods

	// RVA: 0x16C3110 Offset: 0x16C2310 VA: 0x1816C3110
	internal void .ctor(SignatureType elementType, int rank, bool isMultiDim) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 33
	protected sealed override bool IsArrayImpl() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 35
	protected sealed override bool IsByRefImpl() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 37
	protected sealed override bool IsPointerImpl() { }

	// RVA: 0x16C3190 Offset: 0x16C2390 VA: 0x1816C3190 Slot: 43
	public sealed override bool get_IsSZArray() { }

	// RVA: 0x695F30 Offset: 0x695130 VA: 0x180695F30 Slot: 44
	public sealed override bool get_IsVariableBoundArray() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 48
	public sealed override int GetArrayRank() { }

	// RVA: 0x16C31A0 Offset: 0x16C23A0 VA: 0x1816C31A0 Slot: 136
	protected sealed override string get_Suffix() { }
}

// Namespace: System.Reflection
internal sealed class SignatureByRefType : SignatureHasElementType // TypeDefIndex: 4156
{
	// Properties
	public sealed override bool IsSZArray { get; }
	public sealed override bool IsVariableBoundArray { get; }
	protected sealed override string Suffix { get; }

	// Methods

	// RVA: 0x16C32A0 Offset: 0x16C24A0 VA: 0x1816C32A0
	internal void .ctor(SignatureType elementType) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 33
	protected sealed override bool IsArrayImpl() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 35
	protected sealed override bool IsByRefImpl() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 37
	protected sealed override bool IsPointerImpl() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 43
	public sealed override bool get_IsSZArray() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 44
	public sealed override bool get_IsVariableBoundArray() { }

	// RVA: 0x16C3250 Offset: 0x16C2450 VA: 0x1816C3250 Slot: 48
	public sealed override int GetArrayRank() { }

	// RVA: 0x16C3300 Offset: 0x16C2500 VA: 0x1816C3300 Slot: 136
	protected sealed override string get_Suffix() { }
}

// Namespace: System.Reflection
internal sealed class SignatureConstructedGenericType : SignatureType // TypeDefIndex: 4157
{
	// Fields
	private readonly Type _genericTypeDefinition; // 0x18
	private readonly Type[] _genericTypeArguments; // 0x20

	// Properties
	public sealed override bool IsGenericTypeDefinition { get; }
	public sealed override bool IsSZArray { get; }
	public sealed override bool IsVariableBoundArray { get; }
	public sealed override bool IsConstructedGenericType { get; }
	public sealed override bool IsGenericParameter { get; }
	public sealed override bool IsGenericMethodParameter { get; }
	public sealed override bool ContainsGenericParameters { get; }
	internal sealed override SignatureType ElementType { get; }
	public sealed override Type[] GenericTypeArguments { get; }
	public sealed override int GenericParameterPosition { get; }
	public sealed override string Name { get; }
	public sealed override string Namespace { get; }

	// Methods

	// RVA: 0x16C3500 Offset: 0x16C2700 VA: 0x1816C3500
	internal void .ctor(Type genericTypeDefinition, Type[] typeArguments) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 42
	public sealed override bool get_IsGenericTypeDefinition() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 46
	protected sealed override bool HasElementTypeImpl() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 33
	protected sealed override bool IsArrayImpl() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 35
	protected sealed override bool IsByRefImpl() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 37
	protected sealed override bool IsPointerImpl() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 43
	public sealed override bool get_IsSZArray() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 44
	public sealed override bool get_IsVariableBoundArray() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 38
	public sealed override bool get_IsConstructedGenericType() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 39
	public sealed override bool get_IsGenericParameter() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 40
	public sealed override bool get_IsGenericMethodParameter() { }

	// RVA: 0x16C3760 Offset: 0x16C2960 VA: 0x1816C3760 Slot: 21
	public sealed override bool get_ContainsGenericParameters() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 135
	internal sealed override SignatureType get_ElementType() { }

	// RVA: 0x16C3330 Offset: 0x16C2530 VA: 0x1816C3330 Slot: 48
	public sealed override int GetArrayRank() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 49
	public sealed override Type GetGenericTypeDefinition() { }

	// RVA: 0x16C3380 Offset: 0x16C2580 VA: 0x1816C3380 Slot: 51
	public sealed override Type[] GetGenericArguments() { }

	// RVA: 0x16C3850 Offset: 0x16C2A50 VA: 0x1816C3850 Slot: 50
	public sealed override Type[] get_GenericTypeArguments() { }

	// RVA: 0x16C3800 Offset: 0x16C2A00 VA: 0x1816C3800 Slot: 52
	public sealed override int get_GenericParameterPosition() { }

	// RVA: 0x16C38D0 Offset: 0x16C2AD0 VA: 0x1816C38D0 Slot: 8
	public sealed override string get_Name() { }

	// RVA: 0x15D62E0 Offset: 0x15D54E0 VA: 0x1815D62E0 Slot: 25
	public sealed override string get_Namespace() { }

	// RVA: 0x16C33A0 Offset: 0x16C25A0 VA: 0x1816C33A0 Slot: 3
	public sealed override string ToString() { }
}

// Namespace: System.Reflection
internal abstract class SignatureHasElementType : SignatureType // TypeDefIndex: 4158
{
	// Fields
	private readonly SignatureType _elementType; // 0x18

	// Properties
	public sealed override bool IsGenericTypeDefinition { get; }
	public abstract override bool IsSZArray { get; }
	public abstract override bool IsVariableBoundArray { get; }
	public sealed override bool IsConstructedGenericType { get; }
	public sealed override bool IsGenericParameter { get; }
	public sealed override bool IsGenericMethodParameter { get; }
	public sealed override bool ContainsGenericParameters { get; }
	internal sealed override SignatureType ElementType { get; }
	public sealed override Type[] GenericTypeArguments { get; }
	public sealed override int GenericParameterPosition { get; }
	public sealed override string Name { get; }
	public sealed override string Namespace { get; }
	protected abstract string Suffix { get; }

	// Methods

	// RVA: 0x16C32A0 Offset: 0x16C24A0 VA: 0x1816C32A0
	protected void .ctor(SignatureType elementType) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 42
	public sealed override bool get_IsGenericTypeDefinition() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 46
	protected sealed override bool HasElementTypeImpl() { }

	// RVA: -1 Offset: -1 Slot: 33
	protected abstract override bool IsArrayImpl();

	// RVA: -1 Offset: -1 Slot: 35
	protected abstract override bool IsByRefImpl();

	// RVA: -1 Offset: -1 Slot: 37
	protected abstract override bool IsPointerImpl();

	// RVA: -1 Offset: -1 Slot: 43
	public abstract override bool get_IsSZArray();

	// RVA: -1 Offset: -1 Slot: 44
	public abstract override bool get_IsVariableBoundArray();

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 38
	public sealed override bool get_IsConstructedGenericType() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 39
	public sealed override bool get_IsGenericParameter() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 40
	public sealed override bool get_IsGenericMethodParameter() { }

	// RVA: 0x16C39F0 Offset: 0x16C2BF0 VA: 0x1816C39F0 Slot: 21
	public sealed override bool get_ContainsGenericParameters() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 135
	internal sealed override SignatureType get_ElementType() { }

	// RVA: -1 Offset: -1 Slot: 48
	public abstract override int GetArrayRank();

	// RVA: 0x16C3930 Offset: 0x16C2B30 VA: 0x1816C3930 Slot: 49
	public sealed override Type GetGenericTypeDefinition() { }

	// RVA: 0x16C3900 Offset: 0x16C2B00 VA: 0x1816C3900 Slot: 51
	public sealed override Type[] GetGenericArguments() { }

	// RVA: 0x16C3A70 Offset: 0x16C2C70 VA: 0x1816C3A70 Slot: 50
	public sealed override Type[] get_GenericTypeArguments() { }

	// RVA: 0x16C3A20 Offset: 0x16C2C20 VA: 0x1816C3A20 Slot: 52
	public sealed override int get_GenericParameterPosition() { }

	// RVA: 0x16C3AA0 Offset: 0x16C2CA0 VA: 0x1816C3AA0 Slot: 8
	public sealed override string get_Name() { }

	// RVA: 0x15D62E0 Offset: 0x15D54E0 VA: 0x1815D62E0 Slot: 25
	public sealed override string get_Namespace() { }

	// RVA: 0x16C3980 Offset: 0x16C2B80 VA: 0x1816C3980 Slot: 3
	public sealed override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 136
	protected abstract string get_Suffix();
}

// Namespace: System.Reflection
internal sealed class SignaturePointerType : SignatureHasElementType // TypeDefIndex: 4159
{
	// Properties
	public sealed override bool IsSZArray { get; }
	public sealed override bool IsVariableBoundArray { get; }
	protected sealed override string Suffix { get; }

	// Methods

	// RVA: 0x16C32A0 Offset: 0x16C24A0 VA: 0x1816C32A0
	internal void .ctor(SignatureType elementType) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 33
	protected sealed override bool IsArrayImpl() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 35
	protected sealed override bool IsByRefImpl() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 37
	protected sealed override bool IsPointerImpl() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 43
	public sealed override bool get_IsSZArray() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 44
	public sealed override bool get_IsVariableBoundArray() { }

	// RVA: 0x16C3B10 Offset: 0x16C2D10 VA: 0x1816C3B10 Slot: 48
	public sealed override int GetArrayRank() { }

	// RVA: 0x16C3B60 Offset: 0x16C2D60 VA: 0x1816C3B60 Slot: 136
	protected sealed override string get_Suffix() { }
}

// Namespace: System.Reflection
internal abstract class SignatureType : Type // TypeDefIndex: 4160
{
	// Properties
	public sealed override bool IsSignatureType { get; }
	public abstract override bool IsSZArray { get; }
	public abstract override bool IsVariableBoundArray { get; }
	public sealed override bool IsGenericType { get; }
	public abstract override bool IsGenericTypeDefinition { get; }
	public abstract override bool IsConstructedGenericType { get; }
	public abstract override bool IsGenericParameter { get; }
	public abstract override bool IsGenericMethodParameter { get; }
	public abstract override bool ContainsGenericParameters { get; }
	public sealed override MemberTypes MemberType { get; }
	public abstract override Type[] GenericTypeArguments { get; }
	public abstract override int GenericParameterPosition { get; }
	internal abstract SignatureType ElementType { get; }
	public sealed override Type UnderlyingSystemType { get; }
	public abstract override string Name { get; }
	public abstract override string Namespace { get; }
	public sealed override string FullName { get; }
	public sealed override string AssemblyQualifiedName { get; }
	public sealed override Assembly Assembly { get; }
	public sealed override Module Module { get; }
	public sealed override Type ReflectedType { get; }
	public sealed override Type BaseType { get; }
	public sealed override int MetadataToken { get; }
	public sealed override Type DeclaringType { get; }
	public sealed override MethodBase DeclaringMethod { get; }
	public sealed override GenericParameterAttributes GenericParameterAttributes { get; }
	public sealed override Guid GUID { get; }
	public sealed override bool IsEnum { get; }
	public sealed override bool IsSerializable { get; }
	public sealed override RuntimeTypeHandle TypeHandle { get; }

	// Methods

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 77
	public sealed override bool get_IsSignatureType() { }

	// RVA: -1 Offset: -1 Slot: 46
	protected abstract override bool HasElementTypeImpl();

	// RVA: -1 Offset: -1 Slot: 33
	protected abstract override bool IsArrayImpl();

	// RVA: -1 Offset: -1 Slot: 43
	public abstract override bool get_IsSZArray();

	// RVA: -1 Offset: -1 Slot: 44
	public abstract override bool get_IsVariableBoundArray();

	// RVA: -1 Offset: -1 Slot: 35
	protected abstract override bool IsByRefImpl();

	// RVA: -1 Offset: -1 Slot: 37
	protected abstract override bool IsPointerImpl();

	// RVA: 0x16C56F0 Offset: 0x16C48F0 VA: 0x1816C56F0 Slot: 41
	public sealed override bool get_IsGenericType() { }

	// RVA: -1 Offset: -1 Slot: 42
	public abstract override bool get_IsGenericTypeDefinition();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract override bool get_IsConstructedGenericType();

	// RVA: -1 Offset: -1 Slot: 39
	public abstract override bool get_IsGenericParameter();

	// RVA: -1 Offset: -1 Slot: 40
	public abstract override bool get_IsGenericMethodParameter();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract override bool get_ContainsGenericParameters();

	// RVA: 0x1533C40 Offset: 0x1532E40 VA: 0x181533C40 Slot: 7
	public sealed override MemberTypes get_MemberType() { }

	// RVA: 0x16C51C0 Offset: 0x16C43C0 VA: 0x1816C51C0 Slot: 125
	public sealed override Type MakeArrayType() { }

	// RVA: 0x16C5250 Offset: 0x16C4450 VA: 0x1816C5250 Slot: 126
	public sealed override Type MakeArrayType(int rank) { }

	// RVA: 0x16C5300 Offset: 0x16C4500 VA: 0x1816C5300 Slot: 127
	public sealed override Type MakeByRefType() { }

	// RVA: 0x16C53E0 Offset: 0x16C45E0 VA: 0x1816C53E0 Slot: 129
	public sealed override Type MakePointerType() { }

	// RVA: 0x16C5390 Offset: 0x16C4590 VA: 0x1816C5390 Slot: 128
	public sealed override Type MakeGenericType(Type[] typeArguments) { }

	// RVA: 0x16C47F0 Offset: 0x16C39F0 VA: 0x1816C47F0 Slot: 47
	public sealed override Type GetElementType() { }

	// RVA: -1 Offset: -1 Slot: 48
	public abstract override int GetArrayRank();

	// RVA: -1 Offset: -1 Slot: 49
	public abstract override Type GetGenericTypeDefinition();

	// RVA: -1 Offset: -1 Slot: 50
	public abstract override Type[] get_GenericTypeArguments();

	// RVA: -1 Offset: -1 Slot: 51
	public abstract override Type[] GetGenericArguments();

	// RVA: -1 Offset: -1 Slot: 52
	public abstract override int get_GenericParameterPosition();

	// RVA: -1 Offset: -1 Slot: 135
	internal abstract SignatureType get_ElementType();

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 31
	public sealed override Type get_UnderlyingSystemType() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract override string get_Name();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract override string get_Namespace();

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 27
	public sealed override string get_FullName() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 26
	public sealed override string get_AssemblyQualifiedName() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract override string ToString();

	// RVA: 0x16C54C0 Offset: 0x16C46C0 VA: 0x1816C54C0 Slot: 28
	public sealed override Assembly get_Assembly() { }

	// RVA: 0x16C57E0 Offset: 0x16C49E0 VA: 0x1816C57E0 Slot: 29
	public sealed override Module get_Module() { }

	// RVA: 0x16C5830 Offset: 0x16C4A30 VA: 0x1816C5830 Slot: 10
	public sealed override Type get_ReflectedType() { }

	// RVA: 0x16C5510 Offset: 0x16C4710 VA: 0x1816C5510 Slot: 117
	public sealed override Type get_BaseType() { }

	// RVA: 0x16C4AE0 Offset: 0x16C3CE0 VA: 0x1816C4AE0 Slot: 120
	public sealed override Type[] GetInterfaces() { }

	// RVA: 0x16C4E50 Offset: 0x16C4050 VA: 0x1816C4E50 Slot: 23
	public sealed override bool IsAssignableFrom(Type c) { }

	// RVA: 0x16C5790 Offset: 0x16C4990 VA: 0x1816C5790 Slot: 16
	public sealed override int get_MetadataToken() { }

	// RVA: 0x16C55B0 Offset: 0x16C47B0 VA: 0x1816C55B0 Slot: 9
	public sealed override Type get_DeclaringType() { }

	// RVA: 0x16C5560 Offset: 0x16C4760 VA: 0x1816C5560 Slot: 30
	public sealed override MethodBase get_DeclaringMethod() { }

	// RVA: 0x16C4A90 Offset: 0x16C3C90 VA: 0x1816C4A90 Slot: 54
	public sealed override Type[] GetGenericParameterConstraints() { }

	// RVA: 0x16C5650 Offset: 0x16C4850 VA: 0x1816C5650 Slot: 53
	public sealed override GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x16C4F90 Offset: 0x16C4190 VA: 0x1816C4F90 Slot: 17
	public sealed override bool IsEnumDefined(object value) { }

	// RVA: 0x16C4810 Offset: 0x16C3A10 VA: 0x1816C4810 Slot: 18
	public sealed override string GetEnumName(object value) { }

	// RVA: 0x16C4860 Offset: 0x16C3A60 VA: 0x1816C4860 Slot: 19
	public sealed override string[] GetEnumNames() { }

	// RVA: 0x16C48B0 Offset: 0x16C3AB0 VA: 0x1816C48B0 Slot: 123
	public sealed override Type GetEnumUnderlyingType() { }

	// RVA: 0x16C4900 Offset: 0x16C3B00 VA: 0x1816C4900 Slot: 124
	public sealed override Array GetEnumValues() { }

	// RVA: 0x16C5600 Offset: 0x16C4800 VA: 0x1816C5600 Slot: 116
	public sealed override Guid get_GUID() { }

	// RVA: 0x16C4DB0 Offset: 0x16C3FB0 VA: 0x1816C4DB0 Slot: 115
	protected sealed override TypeCode GetTypeCodeImpl() { }

	// RVA: 0x16C4610 Offset: 0x16C3810 VA: 0x1816C4610 Slot: 56
	protected sealed override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x16C46B0 Offset: 0x16C38B0 VA: 0x1816C46B0 Slot: 83
	public sealed override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x16C4950 Offset: 0x16C3B50 VA: 0x1816C4950 Slot: 85
	public sealed override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x16C49A0 Offset: 0x16C3BA0 VA: 0x1816C49A0 Slot: 86
	public sealed override EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	// RVA: 0x16C49F0 Offset: 0x16C3BF0 VA: 0x1816C49F0 Slot: 88
	public sealed override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x16C4A40 Offset: 0x16C3C40 VA: 0x1816C4A40 Slot: 90
	public sealed override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x16C4BD0 Offset: 0x16C3DD0 VA: 0x1816C4BD0 Slot: 94
	public sealed override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x16C4C70 Offset: 0x16C3E70 VA: 0x1816C4C70 Slot: 103
	public sealed override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x16C4CC0 Offset: 0x16C3EC0 VA: 0x1816C4CC0 Slot: 104
	public sealed override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x16C4D10 Offset: 0x16C3F10 VA: 0x1816C4D10 Slot: 113
	public sealed override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x16C4E00 Offset: 0x16C4000 VA: 0x1816C4E00 Slot: 119
	public sealed override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x16C4C20 Offset: 0x16C3E20 VA: 0x1816C4C20 Slot: 101
	protected sealed override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x16C4D60 Offset: 0x16C3F60 VA: 0x1816C4D60 Slot: 111
	protected sealed override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x16C4B80 Offset: 0x16C3D80 VA: 0x1816C4B80 Slot: 92
	public sealed override MemberInfo[] GetMember(string name, BindingFlags bindingAttr) { }

	// RVA: 0x16C4B30 Offset: 0x16C3D30 VA: 0x1816C4B30 Slot: 93
	public sealed override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x16C4750 Offset: 0x16C3950 VA: 0x1816C4750 Slot: 13
	public sealed override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x16C47A0 Offset: 0x16C39A0 VA: 0x1816C47A0 Slot: 14
	public sealed override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x16C4F40 Offset: 0x16C4140 VA: 0x1816C4F40 Slot: 12
	public sealed override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x16C4700 Offset: 0x16C3900 VA: 0x1816C4700 Slot: 15
	public sealed override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x16C4660 Offset: 0x16C3860 VA: 0x1816C4660 Slot: 81
	protected sealed override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x16C4EA0 Offset: 0x16C40A0 VA: 0x1816C4EA0 Slot: 66
	protected sealed override bool IsCOMObjectImpl() { }

	// RVA: 0x16C50D0 Offset: 0x16C42D0 VA: 0x1816C50D0 Slot: 74
	protected sealed override bool IsPrimitiveImpl() { }

	// RVA: 0x16C4EF0 Offset: 0x16C40F0 VA: 0x1816C4EF0 Slot: 68
	protected sealed override bool IsContextfulImpl() { }

	// RVA: 0x16C56A0 Offset: 0x16C48A0 VA: 0x1816C56A0 Slot: 70
	public sealed override bool get_IsEnum() { }

	// RVA: 0x16C4FE0 Offset: 0x16C41E0 VA: 0x1816C4FE0 Slot: 122
	public sealed override bool IsEquivalentTo(Type other) { }

	// RVA: 0x16C5030 Offset: 0x16C4230 VA: 0x1816C5030 Slot: 121
	public sealed override bool IsInstanceOfType(object o) { }

	// RVA: 0x16C5080 Offset: 0x16C4280 VA: 0x1816C5080 Slot: 72
	protected sealed override bool IsMarshalByRefImpl() { }

	// RVA: 0x16C5740 Offset: 0x16C4940 VA: 0x1816C5740 Slot: 20
	public sealed override bool get_IsSerializable() { }

	// RVA: 0x16C5120 Offset: 0x16C4320 VA: 0x1816C5120 Slot: 22
	public sealed override bool IsSubclassOf(Type c) { }

	// RVA: 0x16C5170 Offset: 0x16C4370 VA: 0x1816C5170 Slot: 76
	protected sealed override bool IsValueTypeImpl() { }

	// RVA: 0x16C5880 Offset: 0x16C4A80 VA: 0x1816C5880 Slot: 114
	public sealed override RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x16C5470 Offset: 0x16C4670 VA: 0x1816C5470
	protected void .ctor() { }
}

// Namespace: System.Reflection
[Extension]
internal static class SignatureTypeExtensions // TypeDefIndex: 4161
{
	// Methods

	[Extension]
	// RVA: 0x16C3FD0 Offset: 0x16C31D0 VA: 0x1816C3FD0
	public static bool MatchesParameterTypeExactly(Type pattern, ParameterInfo parameter) { }

	[Extension]
	// RVA: 0x16C3B90 Offset: 0x16C2D90 VA: 0x1816C3B90
	internal static bool MatchesExactly(SignatureType pattern, Type actual) { }

	[Extension]
	// RVA: 0x16C41B0 Offset: 0x16C33B0 VA: 0x1816C41B0
	internal static Type TryResolveAgainstGenericMethod(SignatureType signatureType, MethodInfo genericMethod) { }

	[Extension]
	// RVA: 0x16C41F0 Offset: 0x16C33F0 VA: 0x1816C41F0
	private static Type TryResolve(SignatureType signatureType, Type[] genericMethodParameters) { }

	[Extension]
	// RVA: 0x16C40F0 Offset: 0x16C32F0 VA: 0x1816C40F0
	private static Type TryMakeArrayType(Type type) { }

	[Extension]
	// RVA: 0x16C40C0 Offset: 0x16C32C0 VA: 0x1816C40C0
	private static Type TryMakeArrayType(Type type, int rank) { }

	[Extension]
	// RVA: 0x16C4120 Offset: 0x16C3320 VA: 0x1816C4120
	private static Type TryMakeByRefType(Type type) { }

	[Extension]
	// RVA: 0x16C4180 Offset: 0x16C3380 VA: 0x1816C4180
	private static Type TryMakePointerType(Type type) { }

	[Extension]
	// RVA: 0x16C4150 Offset: 0x16C3350 VA: 0x1816C4150
	private static Type TryMakeGenericType(Type type, Type[] instantiation) { }
}

// Namespace: System.Reflection
[Serializable]
public class TargetException : ApplicationException // TypeDefIndex: 4162
{
	// Methods

	// RVA: 0x16C5C30 Offset: 0x16C4E30 VA: 0x1816C5C30
	public void .ctor() { }

	// RVA: 0x16C5C60 Offset: 0x16C4E60 VA: 0x1816C5C60
	public void .ctor(string message) { }

	// RVA: 0x16C5C10 Offset: 0x16C4E10 VA: 0x1816C5C10
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x167A820 Offset: 0x1679A20 VA: 0x18167A820
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Reflection
[Serializable]
public sealed class TargetInvocationException : ApplicationException // TypeDefIndex: 4163
{
	// Methods

	// RVA: 0x16C5C90 Offset: 0x16C4E90 VA: 0x1816C5C90
	public void .ctor(Exception inner) { }

	// RVA: 0x16C5CF0 Offset: 0x16C4EF0 VA: 0x1816C5CF0
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x167A820 Offset: 0x1679A20 VA: 0x18167A820
	internal void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Reflection
[Serializable]
public sealed class TargetParameterCountException : ApplicationException // TypeDefIndex: 4164
{
	// Methods

	// RVA: 0x16C5D30 Offset: 0x16C4F30 VA: 0x1816C5D30
	public void .ctor() { }

	// RVA: 0x16C5D10 Offset: 0x16C4F10 VA: 0x1816C5D10
	public void .ctor(string message) { }

	// RVA: 0x167A820 Offset: 0x1679A20 VA: 0x18167A820
	internal void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Reflection
[Flags]
public enum TypeAttributes // TypeDefIndex: 4165
{
	// Fields
	public int value__; // 0x0
	public const TypeAttributes VisibilityMask = 7;
	public const TypeAttributes NotPublic = 0;
	public const TypeAttributes Public = 1;
	public const TypeAttributes NestedPublic = 2;
	public const TypeAttributes NestedPrivate = 3;
	public const TypeAttributes NestedFamily = 4;
	public const TypeAttributes NestedAssembly = 5;
	public const TypeAttributes NestedFamANDAssem = 6;
	public const TypeAttributes NestedFamORAssem = 7;
	public const TypeAttributes LayoutMask = 24;
	public const TypeAttributes AutoLayout = 0;
	public const TypeAttributes SequentialLayout = 8;
	public const TypeAttributes ExplicitLayout = 16;
	public const TypeAttributes ClassSemanticsMask = 32;
	public const TypeAttributes Class = 0;
	public const TypeAttributes Interface = 32;
	public const TypeAttributes Abstract = 128;
	public const TypeAttributes Sealed = 256;
	public const TypeAttributes SpecialName = 1024;
	public const TypeAttributes Import = 4096;
	public const TypeAttributes Serializable = 8192;
	public const TypeAttributes WindowsRuntime = 16384;
	public const TypeAttributes StringFormatMask = 196608;
	public const TypeAttributes AnsiClass = 0;
	public const TypeAttributes UnicodeClass = 65536;
	public const TypeAttributes AutoClass = 131072;
	public const TypeAttributes CustomFormatClass = 196608;
	public const TypeAttributes CustomFormatMask = 12582912;
	public const TypeAttributes BeforeFieldInit = 1048576;
	public const TypeAttributes RTSpecialName = 2048;
	public const TypeAttributes HasSecurity = 262144;
	public const TypeAttributes ReservedMask = 264192;
}

// Namespace: System.Reflection
public class TypeDelegator : TypeInfo // TypeDefIndex: 4166
{
	// Fields
	protected Type typeImpl; // 0x18

	// Properties
	public override Guid GUID { get; }
	public override int MetadataToken { get; }
	public override Module Module { get; }
	public override Assembly Assembly { get; }
	public override RuntimeTypeHandle TypeHandle { get; }
	public override string Name { get; }
	public override string FullName { get; }
	public override string Namespace { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type BaseType { get; }
	public override bool IsSZArray { get; }
	public override bool IsGenericMethodParameter { get; }
	public override bool IsConstructedGenericType { get; }
	public override bool IsCollectible { get; }
	public override Type UnderlyingSystemType { get; }

	// Methods

	// RVA: 0x16C62F0 Offset: 0x16C54F0 VA: 0x1816C62F0
	public void .ctor(Type delegatingType) { }

	// RVA: 0x16C64A0 Offset: 0x16C56A0 VA: 0x1816C64A0 Slot: 116
	public override Guid get_GUID() { }

	// RVA: 0x16C65A0 Offset: 0x16C57A0 VA: 0x1816C65A0 Slot: 16
	public override int get_MetadataToken() { }

	// RVA: 0x16C61C0 Offset: 0x16C53C0 VA: 0x1816C61C0 Slot: 119
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x16C65D0 Offset: 0x16C57D0 VA: 0x1816C65D0 Slot: 29
	public override Module get_Module() { }

	// RVA: 0x16C6410 Offset: 0x16C5610 VA: 0x1816C6410 Slot: 28
	public override Assembly get_Assembly() { }

	// RVA: 0x16C6600 Offset: 0x16C5800 VA: 0x1816C6600 Slot: 114
	public override RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x16C38D0 Offset: 0x16C2AD0 VA: 0x1816C38D0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x16C6470 Offset: 0x16C5670 VA: 0x1816C6470 Slot: 27
	public override string get_FullName() { }

	// RVA: 0x15D62E0 Offset: 0x15D54E0 VA: 0x1815D62E0 Slot: 25
	public override string get_Namespace() { }

	// RVA: 0x16C63E0 Offset: 0x16C55E0 VA: 0x1816C63E0 Slot: 26
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x16C6440 Offset: 0x16C5640 VA: 0x1816C6440 Slot: 117
	public override Type get_BaseType() { }

	// RVA: 0x16C5DA0 Offset: 0x16C4FA0 VA: 0x1816C5DA0 Slot: 81
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	// RVA: 0x16C5DD0 Offset: 0x16C4FD0 VA: 0x1816C5DD0 Slot: 83
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x16C5FE0 Offset: 0x16C51E0 VA: 0x1816C5FE0 Slot: 101
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x16C6020 Offset: 0x16C5220 VA: 0x1816C6020 Slot: 103
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x16C5EF0 Offset: 0x16C50F0 VA: 0x1816C5EF0 Slot: 88
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x16C5F20 Offset: 0x16C5120 VA: 0x1816C5F20 Slot: 90
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x16C5F50 Offset: 0x16C5150 VA: 0x1816C5F50 Slot: 120
	public override Type[] GetInterfaces() { }

	// RVA: 0x16C5E90 Offset: 0x16C5090 VA: 0x1816C5E90 Slot: 85
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x16C60B0 Offset: 0x16C52B0 VA: 0x1816C60B0 Slot: 111
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x16C6080 Offset: 0x16C5280 VA: 0x1816C6080 Slot: 113
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x16C5EC0 Offset: 0x16C50C0 VA: 0x1816C5EC0 Slot: 86
	public override EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	// RVA: 0x16C6050 Offset: 0x16C5250 VA: 0x1816C6050 Slot: 104
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x16C5F80 Offset: 0x16C5180 VA: 0x1816C5F80 Slot: 93
	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x16C5FB0 Offset: 0x16C51B0 VA: 0x1816C5FB0 Slot: 94
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x16C5D80 Offset: 0x16C4F80 VA: 0x1816C5D80 Slot: 56
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x16C6570 Offset: 0x16C5770 VA: 0x1816C6570 Slot: 43
	public override bool get_IsSZArray() { }

	// RVA: 0x16C6200 Offset: 0x16C5400 VA: 0x1816C6200 Slot: 33
	protected override bool IsArrayImpl() { }

	// RVA: 0x16C62B0 Offset: 0x16C54B0 VA: 0x1816C62B0 Slot: 74
	protected override bool IsPrimitiveImpl() { }

	// RVA: 0x16C6220 Offset: 0x16C5420 VA: 0x1816C6220 Slot: 35
	protected override bool IsByRefImpl() { }

	// RVA: 0x16C6540 Offset: 0x16C5740 VA: 0x1816C6540 Slot: 40
	public override bool get_IsGenericMethodParameter() { }

	// RVA: 0x16C6290 Offset: 0x16C5490 VA: 0x1816C6290 Slot: 37
	protected override bool IsPointerImpl() { }

	// RVA: 0x16C62D0 Offset: 0x16C54D0 VA: 0x1816C62D0 Slot: 76
	protected override bool IsValueTypeImpl() { }

	// RVA: 0x16C6240 Offset: 0x16C5440 VA: 0x1816C6240 Slot: 66
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x16C6510 Offset: 0x16C5710 VA: 0x1816C6510 Slot: 38
	public override bool get_IsConstructedGenericType() { }

	// RVA: 0x16C64E0 Offset: 0x16C56E0 VA: 0x1816C64E0 Slot: 69
	public override bool get_IsCollectible() { }

	// RVA: 0x16C5E60 Offset: 0x16C5060 VA: 0x1816C5E60 Slot: 47
	public override Type GetElementType() { }

	// RVA: 0x16C61A0 Offset: 0x16C53A0 VA: 0x1816C61A0 Slot: 46
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x16C6630 Offset: 0x16C5830 VA: 0x1816C6630 Slot: 31
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x16C5E30 Offset: 0x16C5030 VA: 0x1816C5E30 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x16C5E00 Offset: 0x16C5000 VA: 0x1816C5E00 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x16C6260 Offset: 0x16C5460 VA: 0x1816C6260 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }
}

// Namespace: System.Reflection
public sealed class TypeFilter : MulticastDelegate // TypeDefIndex: 4167
{
	// Methods

	// RVA: 0x12052D0 Offset: 0x12044D0 VA: 0x1812052D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual bool Invoke(Type m, object filterCriteria) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TypeInfo.<GetDeclaredMethods>d__10 : IEnumerable<MethodInfo>, IEnumerable, IEnumerator<MethodInfo>, IDisposable, IEnumerator // TypeDefIndex: 4168
{
	// Fields
	private int <>1__state; // 0x10
	private MethodInfo <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public TypeInfo <>4__this; // 0x28
	private string name; // 0x30
	public string <>3__name; // 0x38
	private MethodInfo[] <>7__wrap1; // 0x40
	private int <>7__wrap2; // 0x48

	// Properties
	private MethodInfo System.Collections.Generic.IEnumerator<System.Reflection.MethodInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x16C6770 Offset: 0x16C5970 VA: 0x1816C6770 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	private MethodInfo System.Collections.Generic.IEnumerator<System.Reflection.MethodInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x16C6900 Offset: 0x16C5B00 VA: 0x1816C6900 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x16C6860 Offset: 0x16C5A60 VA: 0x1816C6860 Slot: 4
	private IEnumerator<MethodInfo> System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x16C6860 Offset: 0x16C5A60 VA: 0x1816C6860 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: System.Reflection
public abstract class TypeInfo : Type, IReflectableType // TypeDefIndex: 4169
{
	// Fields
	private const BindingFlags DeclaredOnlyLookup = 62;

	// Properties
	public virtual IEnumerable<FieldInfo> DeclaredFields { get; }
	public virtual IEnumerable<Type> ImplementedInterfaces { get; }

	// Methods

	// RVA: 0x16C66E0 Offset: 0x16C58E0 VA: 0x1816C66E0
	protected void .ctor() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 135
	private TypeInfo System.Reflection.IReflectableType.GetTypeInfo() { }

	[IteratorStateMachine(typeof(TypeInfo.<GetDeclaredMethods>d__10))]
	// RVA: 0x16C6660 Offset: 0x16C5860 VA: 0x1816C6660 Slot: 136
	public virtual IEnumerable<MethodInfo> GetDeclaredMethods(string name) { }

	// RVA: 0x16C6730 Offset: 0x16C5930 VA: 0x1816C6730 Slot: 137
	public virtual IEnumerable<FieldInfo> get_DeclaredFields() { }

	// RVA: 0x16C6750 Offset: 0x16C5950 VA: 0x1816C6750 Slot: 138
	public virtual IEnumerable<Type> get_ImplementedInterfaces() { }
}

// Namespace: System.Reflection
[Extension]
public static class RuntimeReflectionExtensions // TypeDefIndex: 4170
{
	// Methods

	[Extension]
	// RVA: 0x16C3040 Offset: 0x16C2240 VA: 0x1816C3040
	public static MethodInfo GetRuntimeMethod(Type type, string name, Type[] parameters) { }
}

// Namespace: System.Reflection
public struct CustomAttributeNamedArgument // TypeDefIndex: 4171
{
	// Fields
	[CompilerGenerated]
	private readonly CustomAttributeTypedArgument <TypedValue>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly bool <IsField>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <MemberName>k__BackingField; // 0x18
	private readonly Type _attributeType; // 0x20
	private MemberInfo _lazyMemberInfo; // 0x28

	// Properties
	public CustomAttributeTypedArgument TypedValue { get; }
	public bool IsField { get; }
	public string MemberName { get; }
	public MemberInfo MemberInfo { get; }

	// Methods

	// RVA: 0x16B08E0 Offset: 0x16AFAE0 VA: 0x1816B08E0
	internal void .ctor(Type attributeType, string memberName, bool isField, CustomAttributeTypedArgument typedValue) { }

	// RVA: 0x16B0920 Offset: 0x16AFB20 VA: 0x1816B0920
	public void .ctor(MemberInfo memberInfo, object value) { }

	// RVA: 0x16B0BD0 Offset: 0x16AFDD0 VA: 0x1816B0BD0
	public void .ctor(MemberInfo memberInfo, CustomAttributeTypedArgument typedArgument) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4354A0 Offset: 0x4346A0 VA: 0x1804354A0
	public CustomAttributeTypedArgument get_TypedValue() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_IsField() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_MemberName() { }

	// RVA: 0x16B0D10 Offset: 0x16AFF10 VA: 0x1816B0D10
	public MemberInfo get_MemberInfo() { }

	// RVA: 0x16B0480 Offset: 0x16AF680 VA: 0x1816B0480 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x16B04F0 Offset: 0x16AF6F0 VA: 0x1816B04F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x16B0E10 Offset: 0x16B0010 VA: 0x1816B0E10
	public static bool op_Equality(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right) { }

	// RVA: 0x16B0ED0 Offset: 0x16B00D0 VA: 0x1816B0ED0
	public static bool op_Inequality(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right) { }

	// RVA: 0x16B0550 Offset: 0x16AF750 VA: 0x1816B0550 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Reflection
public struct CustomAttributeTypedArgument // TypeDefIndex: 4172
{
	// Fields
	[CompilerGenerated]
	private readonly Type <ArgumentType>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly object <Value>k__BackingField; // 0x8

	// Properties
	public Type ArgumentType { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x16B1AE0 Offset: 0x16B0CE0 VA: 0x1816B1AE0
	public void .ctor(object value) { }

	// RVA: 0x16B1830 Offset: 0x16B0A30 VA: 0x1816B1830
	public void .ctor(Type argumentType, object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Type get_ArgumentType() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public object get_Value() { }

	// RVA: 0x16B10A0 Offset: 0x16B02A0 VA: 0x1816B10A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x16B1100 Offset: 0x16B0300 VA: 0x1816B1100 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x16B1B70 Offset: 0x16B0D70 VA: 0x1816B1B70
	public static bool op_Equality(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right) { }

	// RVA: 0x16B1C00 Offset: 0x16B0E00 VA: 0x1816B1C00
	public static bool op_Inequality(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right) { }

	// RVA: 0x16B1820 Offset: 0x16B0A20 VA: 0x1816B1820 Slot: 3
	public override string ToString() { }

	// RVA: 0x16B1150 Offset: 0x16B0350 VA: 0x1816B1150
	internal string ToString(bool typed) { }

	// RVA: 0x16B0F90 Offset: 0x16B0190 VA: 0x1816B0F90
	private static object CanonicalizeValue(object value) { }
}

// Namespace: System.Reflection
public sealed class MissingMetadataException : TypeAccessException // TypeDefIndex: 4173
{
	// Methods

	// RVA: 0x16B4DA0 Offset: 0x16B3FA0 VA: 0x1816B4DA0
	public void .ctor() { }
}

// Namespace: System.Reflection
[Extension]
public static class CustomAttributeExtensions // TypeDefIndex: 4174
{
	// Methods

	[Extension]
	// RVA: 0x16B0400 Offset: 0x16AF600 VA: 0x1816B0400
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType) { }

	[Extension]
	// RVA: 0x16B0410 Offset: 0x16AF610 VA: 0x1816B0410
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetCustomAttribute<T>(Assembly element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x951250 Offset: 0x950450 VA: 0x180951250
	|-CustomAttributeExtensions.GetCustomAttribute<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetCustomAttribute<T>(MemberInfo element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x951310 Offset: 0x950510 VA: 0x180951310
	|-CustomAttributeExtensions.GetCustomAttribute<object>
	*/

	[Extension]
	// RVA: 0x16B0420 Offset: 0x16AF620 VA: 0x1816B0420
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetCustomAttribute<T>(MemberInfo element, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9513D0 Offset: 0x9505D0 VA: 0x1809513D0
	|-CustomAttributeExtensions.GetCustomAttribute<object>
	*/

	[Extension]
	// RVA: 0x16B0440 Offset: 0x16AF640 VA: 0x1816B0440
	public static IEnumerable<Attribute> GetCustomAttributes(MemberInfo element) { }

	[Extension]
	// RVA: 0x16B0460 Offset: 0x16AF660 VA: 0x1816B0460
	public static IEnumerable<Attribute> GetCustomAttributes(Assembly element, Type attributeType) { }

	[Extension]
	// RVA: 0x16B0450 Offset: 0x16AF650 VA: 0x1816B0450
	public static IEnumerable<Attribute> GetCustomAttributes(MemberInfo element, Type attributeType) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetCustomAttributes<T>(Assembly element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x951630 Offset: 0x950830 VA: 0x180951630
	|-CustomAttributeExtensions.GetCustomAttributes<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetCustomAttributes<T>(MemberInfo element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9514A0 Offset: 0x9506A0 VA: 0x1809514A0
	|-CustomAttributeExtensions.GetCustomAttributes<object>
	*/

	[Extension]
	// RVA: 0x16B0430 Offset: 0x16AF630 VA: 0x1816B0430
	public static IEnumerable<Attribute> GetCustomAttributes(MemberInfo element, Type attributeType, bool inherit) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetCustomAttributes<T>(MemberInfo element, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x951560 Offset: 0x950760 VA: 0x180951560
	|-CustomAttributeExtensions.GetCustomAttributes<object>
	*/

	[Extension]
	// RVA: 0x16B0470 Offset: 0x16AF670 VA: 0x1816B0470
	public static bool IsDefined(MemberInfo element, Type attributeType) { }
}

// Namespace: System.Reflection
[Serializable]
internal enum CorElementType // TypeDefIndex: 4175
{
	// Fields
	public byte value__; // 0x0
	public const CorElementType End = 0;
	public const CorElementType Void = 1;
	public const CorElementType Boolean = 2;
	public const CorElementType Char = 3;
	public const CorElementType I1 = 4;
	public const CorElementType U1 = 5;
	public const CorElementType I2 = 6;
	public const CorElementType U2 = 7;
	public const CorElementType I4 = 8;
	public const CorElementType U4 = 9;
	public const CorElementType I8 = 10;
	public const CorElementType U8 = 11;
	public const CorElementType R4 = 12;
	public const CorElementType R8 = 13;
	public const CorElementType String = 14;
	public const CorElementType Ptr = 15;
	public const CorElementType ByRef = 16;
	public const CorElementType ValueType = 17;
	public const CorElementType Class = 18;
	public const CorElementType Var = 19;
	public const CorElementType Array = 20;
	public const CorElementType GenericInst = 21;
	public const CorElementType TypedByRef = 22;
	public const CorElementType I = 24;
	public const CorElementType U = 25;
	public const CorElementType FnPtr = 27;
	public const CorElementType Object = 28;
	public const CorElementType SzArray = 29;
	public const CorElementType MVar = 30;
	public const CorElementType CModReqd = 31;
	public const CorElementType CModOpt = 32;
	public const CorElementType Internal = 33;
	public const CorElementType Max = 34;
	public const CorElementType Modifier = 64;
	public const CorElementType Sentinel = 65;
	public const CorElementType Pinned = 69;
	public const CorElementType ELEMENT_TYPE_END = 0;
	public const CorElementType ELEMENT_TYPE_VOID = 1;
	public const CorElementType ELEMENT_TYPE_BOOLEAN = 2;
	public const CorElementType ELEMENT_TYPE_CHAR = 3;
	public const CorElementType ELEMENT_TYPE_I1 = 4;
	public const CorElementType ELEMENT_TYPE_U1 = 5;
	public const CorElementType ELEMENT_TYPE_I2 = 6;
	public const CorElementType ELEMENT_TYPE_U2 = 7;
	public const CorElementType ELEMENT_TYPE_I4 = 8;
	public const CorElementType ELEMENT_TYPE_U4 = 9;
	public const CorElementType ELEMENT_TYPE_I8 = 10;
	public const CorElementType ELEMENT_TYPE_U8 = 11;
	public const CorElementType ELEMENT_TYPE_R4 = 12;
	public const CorElementType ELEMENT_TYPE_R8 = 13;
	public const CorElementType ELEMENT_TYPE_STRING = 14;
	public const CorElementType ELEMENT_TYPE_PTR = 15;
	public const CorElementType ELEMENT_TYPE_BYREF = 16;
	public const CorElementType ELEMENT_TYPE_VALUETYPE = 17;
	public const CorElementType ELEMENT_TYPE_CLASS = 18;
	public const CorElementType ELEMENT_TYPE_VAR = 19;
	public const CorElementType ELEMENT_TYPE_ARRAY = 20;
	public const CorElementType ELEMENT_TYPE_GENERICINST = 21;
	public const CorElementType ELEMENT_TYPE_TYPEDBYREF = 22;
	public const CorElementType ELEMENT_TYPE_I = 24;
	public const CorElementType ELEMENT_TYPE_U = 25;
	public const CorElementType ELEMENT_TYPE_FNPTR = 27;
	public const CorElementType ELEMENT_TYPE_OBJECT = 28;
	public const CorElementType ELEMENT_TYPE_SZARRAY = 29;
	public const CorElementType ELEMENT_TYPE_MVAR = 30;
	public const CorElementType ELEMENT_TYPE_CMOD_REQD = 31;
	public const CorElementType ELEMENT_TYPE_CMOD_OPT = 32;
	public const CorElementType ELEMENT_TYPE_INTERNAL = 33;
	public const CorElementType ELEMENT_TYPE_MAX = 34;
	public const CorElementType ELEMENT_TYPE_MODIFIER = 64;
	public const CorElementType ELEMENT_TYPE_SENTINEL = 65;
	public const CorElementType ELEMENT_TYPE_PINNED = 69;
}

// Namespace: System.Reflection
[Flags]
[Serializable]
internal enum PInvokeAttributes // TypeDefIndex: 4176
{
	// Fields
	public int value__; // 0x0
	public const PInvokeAttributes NoMangle = 1;
	public const PInvokeAttributes CharSetMask = 6;
	public const PInvokeAttributes CharSetNotSpec = 0;
	public const PInvokeAttributes CharSetAnsi = 2;
	public const PInvokeAttributes CharSetUnicode = 4;
	public const PInvokeAttributes CharSetAuto = 6;
	public const PInvokeAttributes BestFitUseAssem = 0;
	public const PInvokeAttributes BestFitEnabled = 16;
	public const PInvokeAttributes BestFitDisabled = 32;
	public const PInvokeAttributes BestFitMask = 48;
	public const PInvokeAttributes ThrowOnUnmappableCharUseAssem = 0;
	public const PInvokeAttributes ThrowOnUnmappableCharEnabled = 4096;
	public const PInvokeAttributes ThrowOnUnmappableCharDisabled = 8192;
	public const PInvokeAttributes ThrowOnUnmappableCharMask = 12288;
	public const PInvokeAttributes SupportsLastError = 64;
	public const PInvokeAttributes CallConvMask = 1792;
	public const PInvokeAttributes CallConvWinapi = 256;
	public const PInvokeAttributes CallConvCdecl = 512;
	public const PInvokeAttributes CallConvStdcall = 768;
	public const PInvokeAttributes CallConvThiscall = 1024;
	public const PInvokeAttributes CallConvFastcall = 1280;
	public const PInvokeAttributes MaxValue = 65535;
}

// Namespace: System.Reflection
[Serializable]
internal class MemberInfoSerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 4177
{
	// Fields
	private string m_memberName; // 0x10
	private RuntimeType m_reflectedType; // 0x18
	private string m_signature; // 0x20
	private string m_signature2; // 0x28
	private MemberTypes m_memberType; // 0x30
	private SerializationInfo m_info; // 0x38

	// Methods

	// RVA: 0x16B4460 Offset: 0x16B3660 VA: 0x1816B4460
	public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, MemberTypes type) { }

	// RVA: 0x16B4170 Offset: 0x16B3370 VA: 0x1816B4170
	public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, string signature2, MemberTypes type, Type[] genericArguments) { }

	// RVA: 0x16B4490 Offset: 0x16B3690 VA: 0x1816B4490
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16B3460 Offset: 0x16B2660 VA: 0x1816B3460 Slot: 6
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16B34C0 Offset: 0x16B26C0 VA: 0x1816B34C0 Slot: 7
	public virtual object GetRealObject(StreamingContext context) { }
}

// Namespace: 
internal class Assembly.ResolveEventHolder // TypeDefIndex: 4178
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Reflection
[ComVisible(True)]
[ComDefaultInterface(typeof(_Assembly))]
[ClassInterface(0)]
[Serializable]
public class Assembly : ICustomAttributeProvider, ISerializable, _Assembly // TypeDefIndex: 4179
{
	// Properties
	public virtual string CodeBase { get; }
	public virtual string EscapedCodeBase { get; }
	public virtual string FullName { get; }
	internal virtual IntPtr MonoAssembly { get; }
	internal virtual bool FromByteArray { set; }
	public virtual string Location { get; }
	[ComVisible(False)]
	public virtual bool ReflectionOnly { get; }
	[MonoTODO]
	public bool IsFullyTrusted { get; }
	public virtual Module ManifestModule { get; }
	public virtual bool IsDynamic { get; }

	// Methods

	// RVA: 0x16AEA40 Offset: 0x16ADC40 VA: 0x1816AEA40 Slot: 8
	public virtual string get_CodeBase() { }

	// RVA: 0x16AEA80 Offset: 0x16ADC80 VA: 0x1816AEA80 Slot: 9
	public virtual string get_EscapedCodeBase() { }

	// RVA: 0x16AEAC0 Offset: 0x16ADCC0 VA: 0x1816AEAC0 Slot: 10
	public virtual string get_FullName() { }

	// RVA: 0x16AEB70 Offset: 0x16ADD70 VA: 0x1816AEB70 Slot: 11
	internal virtual IntPtr get_MonoAssembly() { }

	// RVA: 0x16AECC0 Offset: 0x16ADEC0 VA: 0x1816AECC0 Slot: 12
	internal virtual void set_FromByteArray(bool value) { }

	// RVA: 0x16AEB00 Offset: 0x16ADD00 VA: 0x1816AEB00 Slot: 13
	public virtual string get_Location() { }

	// RVA: 0x16AE2A0 Offset: 0x16AD4A0 VA: 0x1816AE2A0 Slot: 14
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16AE7E0 Offset: 0x16AD9E0 VA: 0x1816AE7E0 Slot: 15
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x16ADCF0 Offset: 0x16ACEF0 VA: 0x1816ADCF0 Slot: 16
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x16ADCB0 Offset: 0x16ACEB0 VA: 0x1816ADCB0 Slot: 17
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x16ADE50 Offset: 0x16AD050 VA: 0x1816ADE50 Slot: 18
	public virtual Stream GetManifestResourceStream(string name) { }

	// RVA: 0x16ADFC0 Offset: 0x16AD1C0 VA: 0x1816ADFC0
	internal Stream GetManifestResourceStream(Type type, string name, bool skipSecurityCheck, ref StackCrawlMark stackMark) { }

	// RVA: 0x16ADE90 Offset: 0x16AD090 VA: 0x1816ADE90
	internal Stream GetManifestResourceStream(string name, ref StackCrawlMark stackMark, bool skipSecurityCheck) { }

	// RVA: 0x16AE310 Offset: 0x16AD510 VA: 0x1816AE310
	internal string GetSimpleName() { }

	// RVA: 0x16AE2E0 Offset: 0x16AD4E0 VA: 0x1816AE2E0
	internal byte[] GetPublicKey() { }

	// RVA: 0x16AE3E0 Offset: 0x16AD5E0 VA: 0x1816AE3E0
	internal Version GetVersion() { }

	// RVA: 0x16ADD60 Offset: 0x16ACF60 VA: 0x1816ADD60
	private AssemblyNameFlags GetFlags() { }

	// RVA: 0x16AE3D0 Offset: 0x16AD5D0 VA: 0x1816AE3D0 Slot: 19
	internal virtual Type[] GetTypes(bool exportedOnly) { }

	// RVA: 0x161A250 Offset: 0x1619450 VA: 0x18161A250 Slot: 20
	public virtual Type[] GetTypes() { }

	// RVA: 0x16AE370 Offset: 0x16AD570 VA: 0x1816AE370 Slot: 21
	public virtual Type GetType(string name, bool throwOnError) { }

	// RVA: 0x16AE340 Offset: 0x16AD540 VA: 0x1816AE340 Slot: 22
	public virtual Type GetType(string name) { }

	// RVA: 0x16AE7D0 Offset: 0x16AD9D0 VA: 0x1816AE7D0
	internal Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x16AE240 Offset: 0x16AD440 VA: 0x1816AE240 Slot: 23
	public virtual AssemblyName GetName(bool copiedName) { }

	// RVA: 0x16AE280 Offset: 0x16AD480 VA: 0x1816AE280 Slot: 24
	public virtual AssemblyName GetName() { }

	// RVA: 0x16AEA30 Offset: 0x16ADC30 VA: 0x1816AEA30 Slot: 3
	public override string ToString() { }

	// RVA: 0x16ADBE0 Offset: 0x16ACDE0 VA: 0x1816ADBE0
	public static Assembly GetAssembly(Type type) { }

	// RVA: 0x16181A0 Offset: 0x16173A0 VA: 0x1816181A0
	public static Assembly GetEntryAssembly() { }

	// RVA: 0x16AE410 Offset: 0x16AD610 VA: 0x1816AE410
	internal RuntimeAssembly InternalGetSatelliteAssembly(string name, CultureInfo culture, Version version, bool throwOnFileNotFound, ref StackCrawlMark stackMark) { }

	// RVA: 0x16AE820 Offset: 0x16ADA20 VA: 0x1816AE820
	private static Assembly LoadFrom(string assemblyFile, bool refOnly, ref StackCrawlMark stackMark) { }

	// RVA: 0x16AE980 Offset: 0x16ADB80 VA: 0x1816AE980
	public static Assembly Load(string assemblyString) { }

	// RVA: 0x16AE9B0 Offset: 0x16ADBB0 VA: 0x1816AE9B0
	public static Assembly Load(byte[] rawAssembly) { }

	// RVA: 0x16AE9E0 Offset: 0x16ADBE0 VA: 0x1816AE9E0
	public static Assembly ReflectionOnlyLoad(string assemblyString) { }

	[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x16AE830 Offset: 0x16ADA30 VA: 0x1816AE830
	public static Assembly LoadWithPartialName(string partialName) { }

	// RVA: 0x16AEBF0 Offset: 0x16ADDF0 VA: 0x1816AEBF0
	private static Assembly load_with_partial_name(string name, Evidence e) { }

	[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x16AE920 Offset: 0x16ADB20 VA: 0x1816AE920
	public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence) { }

	// RVA: 0x16AE890 Offset: 0x16ADA90 VA: 0x1816AE890
	internal static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence, bool oldBehavior) { }

	// RVA: 0x16AE220 Offset: 0x16AD420 VA: 0x1816AE220 Slot: 25
	public Module[] GetModules() { }

	// RVA: 0x16AE1B0 Offset: 0x16AD3B0 VA: 0x1816AE1B0 Slot: 26
	internal virtual Module[] GetModulesInternal() { }

	// RVA: 0x16ADD30 Offset: 0x16ACF30 VA: 0x1816ADD30
	public static Assembly GetExecutingAssembly() { }

	// RVA: 0x16ADCA0 Offset: 0x16ACEA0 VA: 0x1816ADCA0
	public static Assembly GetCallingAssembly() { }

	// RVA: 0x16ADE10 Offset: 0x16AD010 VA: 0x1816ADE10 Slot: 27
	public virtual string[] GetManifestResourceNames() { }

	// RVA: 0x16ADDD0 Offset: 0x16ACFD0 VA: 0x1816ADDD0 Slot: 28
	public virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName) { }

	// RVA: 0x16ADD90 Offset: 0x16ACF90 VA: 0x1816ADD90 Slot: 29
	internal virtual Module GetManifestModule() { }

	// RVA: 0x16AEBB0 Offset: 0x16ADDB0 VA: 0x1816AEBB0 Slot: 30
	public virtual bool get_ReflectionOnly() { }

	// RVA: 0x15C9510 Offset: 0x15C8710 VA: 0x1815C9510 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1676F20 Offset: 0x1676120 VA: 0x181676F20 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x16ADB80 Offset: 0x16ACD80 VA: 0x1816ADB80
	private static Exception CreateNIE() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	public bool get_IsFullyTrusted() { }

	// RVA: 0x16AE3A0 Offset: 0x16AD5A0 VA: 0x1816AE3A0 Slot: 31
	public virtual Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x16AE180 Offset: 0x16AD380 VA: 0x1816AE180 Slot: 32
	public virtual Module GetModule(string name) { }

	// RVA: 0x16AE1F0 Offset: 0x16AD3F0 VA: 0x1816AE1F0 Slot: 33
	public virtual Module[] GetModules(bool getResourceModules) { }

	// RVA: 0x16AEB40 Offset: 0x16ADD40 VA: 0x1816AEB40 Slot: 34
	public virtual Module get_ManifestModule() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 35
	public virtual bool get_IsDynamic() { }

	// RVA: 0x16AEC00 Offset: 0x16ADE00 VA: 0x1816AEC00
	public static bool op_Equality(Assembly left, Assembly right) { }

	// RVA: 0x16AEC60 Offset: 0x16ADE60 VA: 0x1816AEC60
	public static bool op_Inequality(Assembly left, Assembly right) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Reflection
[ComVisible(True)]
[ClassInterface(0)]
[ComDefaultInterface(typeof(_AssemblyName))]
[Serializable]
public sealed class AssemblyName : ICloneable, ISerializable, IDeserializationCallback, _AssemblyName // TypeDefIndex: 4180
{
	// Fields
	private string name; // 0x10
	private string codebase; // 0x18
	private int major; // 0x20
	private int minor; // 0x24
	private int build; // 0x28
	private int revision; // 0x2C
	private CultureInfo cultureinfo; // 0x30
	private AssemblyNameFlags flags; // 0x38
	private AssemblyHashAlgorithm hashalg; // 0x3C
	private StrongNameKeyPair keypair; // 0x40
	private byte[] publicKey; // 0x48
	private byte[] keyToken; // 0x50
	private AssemblyVersionCompatibility versioncompat; // 0x58
	private Version version; // 0x60
	private ProcessorArchitecture processor_architecture; // 0x68
	private AssemblyContentType contentType; // 0x6C

	// Properties
	public string Name { get; set; }
	public CultureInfo CultureInfo { get; set; }
	public AssemblyNameFlags Flags { get; set; }
	public string FullName { get; }
	public Version Version { get; set; }
	private bool IsPublicKeyValid { get; }

	// Methods

	// RVA: 0x16AD0B0 Offset: 0x16AC2B0 VA: 0x1816AD0B0
	public void .ctor() { }

	// RVA: 0x16ACE00 Offset: 0x16AC000 VA: 0x1816ACE00
	private static bool ParseAssemblyName(IntPtr name, out MonoAssemblyName aname, out bool is_version_definited, out bool is_token_defined) { }

	// RVA: 0x16ACE60 Offset: 0x16AC060 VA: 0x1816ACE60
	public void .ctor(string assemblyName) { }

	// RVA: 0x16AD0D0 Offset: 0x16AC2D0 VA: 0x1816AD0D0
	internal void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Name(string value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public CultureInfo get_CultureInfo() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_CultureInfo(CultureInfo value) { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	public AssemblyNameFlags get_Flags() { }

	// RVA: 0x423300 Offset: 0x422500 VA: 0x180423300
	public void set_Flags(AssemblyNameFlags value) { }

	// RVA: 0x16AD640 Offset: 0x16AC840 VA: 0x1816AD640
	public string get_FullName() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public Version get_Version() { }

	// RVA: 0x16ADB10 Offset: 0x16ACD10 VA: 0x1816ADB10
	public void set_Version(Version value) { }

	// RVA: 0x16ACE30 Offset: 0x16AC030 VA: 0x1816ACE30 Slot: 3
	public override string ToString() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public byte[] GetPublicKey() { }

	// RVA: 0x16ACBB0 Offset: 0x16ABDB0 VA: 0x1816ACBB0
	public byte[] GetPublicKeyToken() { }

	// RVA: 0x16ADA40 Offset: 0x16ACC40 VA: 0x1816ADA40
	private bool get_IsPublicKeyValid() { }

	// RVA: 0x16ACCA0 Offset: 0x16ABEA0 VA: 0x1816ACCA0
	private byte[] InternalGetPublicKeyToken() { }

	// RVA: 0x16ADB00 Offset: 0x16ACD00 VA: 0x1816ADB00
	private static void get_public_token(byte* token, byte* pubkey, int len) { }

	// RVA: 0x16AC4B0 Offset: 0x16AB6B0 VA: 0x1816AC4B0
	private byte[] ComputePublicKeyToken() { }

	// RVA: 0x16ACE10 Offset: 0x16AC010 VA: 0x1816ACE10
	public void SetPublicKey(byte[] publicKey) { }

	// RVA: 0x16AC8E0 Offset: 0x16ABAE0 VA: 0x1816AC8E0 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16AC3F0 Offset: 0x16AB5F0 VA: 0x1816AC3F0 Slot: 4
	public object Clone() { }

	// RVA: 0x16ACD90 Offset: 0x16ABF90 VA: 0x1816ACD90 Slot: 6
	public void OnDeserialization(object sender) { }

	// RVA: 0x16AC8D0 Offset: 0x16ABAD0 VA: 0x1816AC8D0
	private static MonoAssemblyName* GetNativeName(IntPtr assembly_ptr) { }

	// RVA: 0x16AC640 Offset: 0x16AB840 VA: 0x1816AC640
	internal void FillName(MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken, bool assemblyRef) { }

	// RVA: 0x16AC550 Offset: 0x16AB750 VA: 0x1816AC550
	internal static AssemblyName Create(Assembly assembly, bool fillCodebase) { }
}

// Namespace: 
private class CustomAttributeData.LazyCAttrData // TypeDefIndex: 4181
{
	// Fields
	internal Assembly assembly; // 0x10
	internal IntPtr data; // 0x18
	internal uint data_length; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Reflection
[ComVisible(True)]
[Serializable]
public class CustomAttributeData // TypeDefIndex: 4182
{
	// Fields
	private ConstructorInfo ctorInfo; // 0x10
	private IList<CustomAttributeTypedArgument> ctorArgs; // 0x18
	private IList<CustomAttributeNamedArgument> namedArgs; // 0x20
	private CustomAttributeData.LazyCAttrData lazyData; // 0x28

	// Properties
	[ComVisible(True)]
	public virtual ConstructorInfo Constructor { get; }
	[ComVisible(True)]
	public virtual IList<CustomAttributeTypedArgument> ConstructorArguments { get; }
	public virtual IList<CustomAttributeNamedArgument> NamedArguments { get; }
	public Type AttributeType { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x16B0280 Offset: 0x16AF480 VA: 0x1816B0280
	internal void .ctor(ConstructorInfo ctorInfo, Assembly assembly, IntPtr data, uint data_length) { }

	// RVA: 0x16B0330 Offset: 0x16AF530 VA: 0x1816B0330
	internal void .ctor(ConstructorInfo ctorInfo) { }

	// RVA: 0x3F6C30 Offset: 0x3F5E30 VA: 0x1803F6C30
	internal void .ctor(ConstructorInfo ctorInfo, IList<CustomAttributeTypedArgument> ctorArgs, IList<CustomAttributeNamedArgument> namedArgs) { }

	// RVA: 0x16AFB40 Offset: 0x16AED40 VA: 0x1816AFB40
	private static void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, IntPtr data, uint data_length, out object[] ctorArgs, out object[] namedArgs) { }

	// RVA: 0x16AFB50 Offset: 0x16AED50 VA: 0x1816AFB50
	private void ResolveArguments() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public virtual ConstructorInfo get_Constructor() { }

	// RVA: 0x16B03C0 Offset: 0x16AF5C0 VA: 0x1816B03C0 Slot: 5
	public virtual IList<CustomAttributeTypedArgument> get_ConstructorArguments() { }

	// RVA: 0x16B03E0 Offset: 0x16AF5E0 VA: 0x1816B03E0 Slot: 6
	public virtual IList<CustomAttributeNamedArgument> get_NamedArguments() { }

	// RVA: 0x16AF670 Offset: 0x16AE870 VA: 0x1816AF670
	public static IList<CustomAttributeData> GetCustomAttributes(Assembly target) { }

	// RVA: 0x16AF620 Offset: 0x16AE820 VA: 0x1816AF620
	public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target) { }

	// RVA: 0x16AF530 Offset: 0x16AE730 VA: 0x1816AF530
	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target) { }

	// RVA: 0x16AF580 Offset: 0x16AE780 VA: 0x1816AF580
	public static IList<CustomAttributeData> GetCustomAttributes(Module target) { }

	// RVA: 0x16AF5D0 Offset: 0x16AE7D0 VA: 0x1816AF5D0
	public static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target) { }

	// RVA: 0x16570C0 Offset: 0x16562C0 VA: 0x1816570C0
	public Type get_AttributeType() { }

	// RVA: 0x16AFC80 Offset: 0x16AEE80 VA: 0x1816AFC80 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	private static T[] UnboxValues<T>(object[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x950EB0 Offset: 0x9500B0 VA: 0x180950EB0
	|-CustomAttributeData.UnboxValues<CustomAttributeNamedArgument>
	|
	|-RVA: 0x950FE0 Offset: 0x9501E0 VA: 0x180950FE0
	|-CustomAttributeData.UnboxValues<CustomAttributeTypedArgument>
	|
	|-RVA: 0x9510F0 Offset: 0x9502F0 VA: 0x1809510F0
	|-CustomAttributeData.UnboxValues<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x16AF000 Offset: 0x16AE200 VA: 0x1816AF000 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x16AF6C0 Offset: 0x16AE8C0 VA: 0x1816AF6C0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Reflection
[ComVisible(True)]
public class ExceptionHandlingClause // TypeDefIndex: 4183
{
	// Fields
	internal Type catch_type; // 0x10
	internal int filter_offset; // 0x18
	internal ExceptionHandlingClauseOptions flags; // 0x1C
	internal int try_offset; // 0x20
	internal int try_length; // 0x24
	internal int handler_offset; // 0x28
	internal int handler_length; // 0x2C

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x16B2810 Offset: 0x16B1A10 VA: 0x1816B2810 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Reflection
[ComVisible(True)]
public class LocalVariableInfo // TypeDefIndex: 4184
{
	// Fields
	internal Type type; // 0x10
	internal bool is_pinned; // 0x18
	internal ushort position; // 0x1A

	// Properties
	public virtual Type LocalType { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public virtual Type get_LocalType() { }

	// RVA: 0x16B33C0 Offset: 0x16B25C0 VA: 0x1816B33C0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Reflection
[ComVisible(True)]
public class MethodBody // TypeDefIndex: 4185
{
	// Fields
	private ExceptionHandlingClause[] clauses; // 0x10
	private LocalVariableInfo[] locals; // 0x18
	private byte[] il; // 0x20
	private bool init_locals; // 0x28
	private int sig_token; // 0x2C
	private int max_stack; // 0x30

	// Properties
	public virtual IList<LocalVariableInfo> LocalVariables { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x16B47C0 Offset: 0x16B39C0 VA: 0x1816B47C0
	internal void .ctor(ExceptionHandlingClause[] clauses, LocalVariableInfo[] locals, byte[] il, bool init_locals, int sig_token, int max_stack) { }

	// RVA: 0x16B4820 Offset: 0x16B3A20 VA: 0x1816B4820 Slot: 4
	public virtual IList<LocalVariableInfo> get_LocalVariables() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 5
	public virtual byte[] GetILAsByteArray() { }
}

// Namespace: 
internal class RuntimeAssembly.UnmanagedMemoryStreamForModule : UnmanagedMemoryStream // TypeDefIndex: 4186
{
	// Fields
	private Module module; // 0x68

	// Methods

	// RVA: 0x16C6960 Offset: 0x16C5B60 VA: 0x1816C6960
	public void .ctor(byte* pointer, long length, Module module) { }

	// RVA: 0x16C6940 Offset: 0x16C5B40 VA: 0x1816C6940 Slot: 21
	protected override void Dispose(bool disposing) { }
}

// Namespace: System.Reflection
[ComVisible(True)]
[ClassInterface(0)]
[ComDefaultInterface(typeof(_Assembly))]
[Serializable]
internal class RuntimeAssembly : Assembly // TypeDefIndex: 4187
{
	// Fields
	internal IntPtr _mono_assembly; // 0x10
	private object _evidence; // 0x18
	internal Assembly.ResolveEventHolder resolve_event_holder; // 0x20
	private object _minimum; // 0x28
	private object _optional; // 0x30
	private object _refuse; // 0x38
	private object _granted; // 0x40
	private object _denied; // 0x48
	internal bool fromByteArray; // 0x50
	internal string assemblyName; // 0x58

	// Properties
	[ComVisible(False)]
	public override Module ManifestModule { get; }
	[ComVisible(False)]
	public override bool ReflectionOnly { get; }
	public override string CodeBase { get; }
	public override string EscapedCodeBase { get; }
	public override string FullName { get; }
	internal override IntPtr MonoAssembly { get; }
	internal override bool FromByteArray { set; }
	public override string Location { get; }

	// Methods

	// RVA: 0x16BBAE0 Offset: 0x16BACE0 VA: 0x1816BBAE0
	protected void .ctor() { }

	// RVA: 0x16BB6E0 Offset: 0x16BA8E0 VA: 0x1816BB6E0 Slot: 14
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16BB9C0 Offset: 0x16BABC0 VA: 0x1816BB9C0
	internal static RuntimeAssembly LoadWithPartialNameInternal(string partialName, Evidence securityEvidence, ref StackCrawlMark stackMark) { }

	// RVA: 0x16BB8C0 Offset: 0x16BAAC0 VA: 0x1816BB8C0
	internal static RuntimeAssembly LoadWithPartialNameInternal(AssemblyName an, Evidence securityEvidence, ref StackCrawlMark stackMark) { }

	// RVA: 0x16BB610 Offset: 0x16BA810 VA: 0x1816BB610 Slot: 23
	public override AssemblyName GetName(bool copiedName) { }

	// RVA: 0x16BB780 Offset: 0x16BA980 VA: 0x1816BB780 Slot: 31
	public override Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x16BB350 Offset: 0x16BA550 VA: 0x1816BB350 Slot: 32
	public override Module GetModule(string name) { }

	// RVA: 0x16BB4D0 Offset: 0x16BA6D0 VA: 0x1816BB4D0 Slot: 33
	public override Module[] GetModules(bool getResourceModules) { }

	// RVA: 0x16BBBC0 Offset: 0x16BADC0 VA: 0x1816BBBC0 Slot: 34
	public override Module get_ManifestModule() { }

	// RVA: 0x16BACD0 Offset: 0x16B9ED0 VA: 0x1816BACD0
	internal static byte[] GetAotId() { }

	// RVA: 0x16BAD20 Offset: 0x16B9F20 VA: 0x1816BAD20
	private static string get_code_base(Assembly a, bool escaped) { }

	// RVA: 0x16BBBE0 Offset: 0x16BADE0 VA: 0x1816BBBE0
	private string get_location() { }

	// RVA: 0x16BBB60 Offset: 0x16BAD60 VA: 0x1816BBB60
	internal static string get_fullname(Assembly a) { }

	// RVA: 0x158A1E0 Offset: 0x15893E0 VA: 0x18158A1E0
	internal static bool GetAotIdInternal(byte[] aotid) { }

	// RVA: 0x158A1E0 Offset: 0x15893E0 VA: 0x18158A1E0 Slot: 30
	public override bool get_ReflectionOnly() { }

	// RVA: 0x16BAD20 Offset: 0x16B9F20 VA: 0x1816BAD20
	internal static string GetCodeBase(Assembly a, bool escaped) { }

	// RVA: 0x16BBB40 Offset: 0x16BAD40 VA: 0x1816BBB40 Slot: 8
	public override string get_CodeBase() { }

	// RVA: 0x16BBB50 Offset: 0x16BAD50 VA: 0x1816BBB50 Slot: 9
	public override string get_EscapedCodeBase() { }

	// RVA: 0x16BBB60 Offset: 0x16BAD60 VA: 0x1816BBB60 Slot: 10
	public override string get_FullName() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 11
	internal override IntPtr get_MonoAssembly() { }

	// RVA: 0x4D1A50 Offset: 0x4D0C50 VA: 0x1804D1A50 Slot: 12
	internal override void set_FromByteArray(bool value) { }

	// RVA: 0x16BBB70 Offset: 0x16BAD70 VA: 0x1816BBB70 Slot: 13
	public override string get_Location() { }

	// RVA: 0x16BAE10 Offset: 0x16BA010 VA: 0x1816BAE10
	private bool GetManifestResourceInfoInternal(string name, ManifestResourceInfo info) { }

	// RVA: 0x16BAE20 Offset: 0x16BA020 VA: 0x1816BAE20 Slot: 28
	public override ManifestResourceInfo GetManifestResourceInfo(string resourceName) { }

	// RVA: 0x16BAF60 Offset: 0x16BA160 VA: 0x1816BAF60 Slot: 27
	public override string[] GetManifestResourceNames() { }

	// RVA: 0x16BAF50 Offset: 0x16BA150 VA: 0x1816BAF50
	internal IntPtr GetManifestResourceInternal(string name, out int size, out Module module) { }

	// RVA: 0x16BAF70 Offset: 0x16BA170 VA: 0x1816BAF70 Slot: 18
	public override Stream GetManifestResourceStream(string name) { }

	// RVA: 0x16BB850 Offset: 0x16BAA50 VA: 0x1816BB850 Slot: 15
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x16BAD30 Offset: 0x16B9F30 VA: 0x1816BAD30 Slot: 16
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x16BAD90 Offset: 0x16B9F90 VA: 0x1816BAD90 Slot: 17
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x16BAE00 Offset: 0x16BA000 VA: 0x1816BAE00 Slot: 29
	internal override Module GetManifestModule() { }

	// RVA: 0x16BAE00 Offset: 0x16BA000 VA: 0x1816BAE00
	internal Module GetManifestModuleInternal() { }

	// RVA: 0x16BB4C0 Offset: 0x16BA6C0 VA: 0x1816BB4C0 Slot: 26
	internal override Module[] GetModulesInternal() { }

	// RVA: 0x15C9510 Offset: 0x15C8710 VA: 0x1815C9510 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x16BAB90 Offset: 0x16B9D90 VA: 0x1816BAB90 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x16BBAA0 Offset: 0x16BACA0 VA: 0x1816BBAA0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Reflection
internal struct MonoEventInfo // TypeDefIndex: 4188
{
	// Fields
	public Type declaring_type; // 0x0
	public Type reflected_type; // 0x8
	public string name; // 0x10
	public MethodInfo add_method; // 0x18
	public MethodInfo remove_method; // 0x20
	public MethodInfo raise_method; // 0x28
	public EventAttributes attrs; // 0x30
	public MethodInfo[] other_methods; // 0x38
}

// Namespace: System.Reflection
[Serializable]
internal sealed class RuntimeEventInfo : EventInfo, ISerializable // TypeDefIndex: 4189
{
	// Fields
	private IntPtr klass; // 0x18
	private IntPtr handle; // 0x20

	// Properties
	public override Module Module { get; }
	internal BindingFlags BindingFlags { get; }
	private RuntimeType ReflectedTypeInternal { get; }
	public override Type DeclaringType { get; }
	public override Type ReflectedType { get; }
	public override string Name { get; }
	public override int MetadataToken { get; }

	// Methods

	// RVA: 0x16BCFF0 Offset: 0x16BC1F0 VA: 0x1816BCFF0
	private static void get_event_info(RuntimeEventInfo ev, out MonoEventInfo info) { }

	// RVA: 0x16BCB30 Offset: 0x16BBD30 VA: 0x1816BCB30
	internal static MonoEventInfo GetEventInfo(RuntimeEventInfo ev) { }

	// RVA: 0x16BCD80 Offset: 0x16BBF80 VA: 0x1816BCD80 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x16BC880 Offset: 0x16BBA80 VA: 0x1816BC880
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x16BCA90 Offset: 0x16BBC90 VA: 0x1816BCA90
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x16BCF20 Offset: 0x16BC120 VA: 0x1816BCF20
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x16BCD80 Offset: 0x16BBF80 VA: 0x1816BCD80
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x16BCB70 Offset: 0x16BBD70 VA: 0x1816BCB70 Slot: 23
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16BC880 Offset: 0x16BBA80 VA: 0x1816BC880
	internal BindingFlags GetBindingFlags() { }

	// RVA: 0x16BC820 Offset: 0x16BBA20 VA: 0x1816BC820 Slot: 19
	public override MethodInfo GetAddMethod(bool nonPublic) { }

	// RVA: 0x16BCCC0 Offset: 0x16BBEC0 VA: 0x1816BCCC0 Slot: 21
	public override MethodInfo GetRaiseMethod(bool nonPublic) { }

	// RVA: 0x16BCD20 Offset: 0x16BBF20 VA: 0x1816BCD20 Slot: 20
	public override MethodInfo GetRemoveMethod(bool nonPublic) { }

	// RVA: 0x16BCEC0 Offset: 0x16BC0C0 VA: 0x1816BCEC0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x16BCFC0 Offset: 0x16BC1C0 VA: 0x1816BCFC0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x16BCEF0 Offset: 0x16BC0F0 VA: 0x1816BCEF0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x16BCE20 Offset: 0x16BC020 VA: 0x1816BCE20 Slot: 3
	public override string ToString() { }

	// RVA: 0x16BCDB0 Offset: 0x16BBFB0 VA: 0x1816BCDB0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x16BCA30 Offset: 0x16BBC30 VA: 0x1816BCA30 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x16BC9C0 Offset: 0x16BBBC0 VA: 0x1816BC9C0 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x16AF620 Offset: 0x16AE820 VA: 0x1816AF620 Slot: 15
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x16BC760 Offset: 0x16BB960 VA: 0x1816BC760 Slot: 16
	public override int get_MetadataToken() { }

	// RVA: 0x16BC760 Offset: 0x16BB960 VA: 0x1816BC760
	internal static int get_metadata_token(RuntimeEventInfo monoEvent) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Reflection
internal abstract class RtFieldInfo : FieldInfo // TypeDefIndex: 4190
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 34
	internal abstract object UnsafeGetValue(object obj);

	// RVA: -1 Offset: -1 Slot: 35
	internal abstract void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

	// RVA: -1 Offset: -1 Slot: 36
	internal abstract void CheckConsistency(object target);

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	protected void .ctor() { }
}

// Namespace: System.Reflection
[Serializable]
internal class RuntimeFieldInfo : RtFieldInfo, ISerializable // TypeDefIndex: 4191
{
	// Fields
	internal IntPtr klass; // 0x10
	internal RuntimeFieldHandle fhandle; // 0x18
	private string name; // 0x20
	private Type type; // 0x28
	private FieldAttributes attrs; // 0x30

	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }
	public override FieldAttributes Attributes { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override Type FieldType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override int MetadataToken { get; }

	// Methods

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x16BD570 Offset: 0x16BC770 VA: 0x1816BD570 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x16BD330 Offset: 0x16BC530 VA: 0x1816BD330
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x16BDEB0 Offset: 0x16BD0B0 VA: 0x1816BDEB0
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x16BD570 Offset: 0x16BC770 VA: 0x1816BD570
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x16BD3E0 Offset: 0x16BC5E0 VA: 0x1816BD3E0 Slot: 37
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16BD620 Offset: 0x16BC820 VA: 0x1816BD620 Slot: 34
	internal override object UnsafeGetValue(object obj) { }

	// RVA: 0x16BD000 Offset: 0x16BC200 VA: 0x1816BD000 Slot: 36
	internal override void CheckConsistency(object target) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x16BDDC0 Offset: 0x16BCFC0 VA: 0x1816BDDC0 Slot: 35
	internal override void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x16BD850 Offset: 0x16BCA50 VA: 0x1816BD850 Slot: 31
	public override void SetValueDirect(TypedReference obj, object value) { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300 Slot: 17
	public override FieldAttributes get_Attributes() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 27
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x15AE1B0 Offset: 0x15AD3B0 VA: 0x1815AE1B0
	private Type ResolveType() { }

	// RVA: 0x16BDE40 Offset: 0x16BD040 VA: 0x1816BDE40 Slot: 18
	public override Type get_FieldType() { }

	// RVA: 0x16BD550 Offset: 0x16BC750 VA: 0x1816BD550
	private Type GetParentType(bool declaring) { }

	// RVA: 0x16BDF50 Offset: 0x16BD150 VA: 0x1816BDF50 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x16BDE30 Offset: 0x16BD030 VA: 0x1816BDE30 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 8
	public override string get_Name() { }

	// RVA: 0x16BD7E0 Offset: 0x16BC9E0 VA: 0x1816BD7E0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x16BD260 Offset: 0x16BC460 VA: 0x1816BD260 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x16BD2C0 Offset: 0x16BC4C0 VA: 0x1816BD2C0 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x16BD3D0 Offset: 0x16BC5D0 VA: 0x1816BD3D0 Slot: 33
	internal override int GetFieldOffset() { }

	// RVA: 0x16BD620 Offset: 0x16BC820 VA: 0x1816BD620
	private object GetValueInternal(object obj) { }

	// RVA: 0x16BD630 Offset: 0x16BC830 VA: 0x1816BD630 Slot: 28
	public override object GetValue(object obj) { }

	// RVA: 0x16BDD60 Offset: 0x16BCF60 VA: 0x1816BDD60 Slot: 3
	public override string ToString() { }

	// RVA: 0x16BDA00 Offset: 0x16BCC00 VA: 0x1816BDA00
	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

	// RVA: 0x16BDA10 Offset: 0x16BCC10 VA: 0x1816BDA10 Slot: 30
	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x16BD560 Offset: 0x16BC760 VA: 0x1816BD560 Slot: 32
	public override object GetRawConstantValue() { }

	// RVA: 0x16AF620 Offset: 0x16AE820 VA: 0x1816AF620 Slot: 15
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x16BD1C0 Offset: 0x16BC3C0 VA: 0x1816BD1C0
	private void CheckGeneric() { }

	// RVA: 0x16BC760 Offset: 0x16BB960 VA: 0x1816BC760 Slot: 16
	public override int get_MetadataToken() { }

	// RVA: 0x16BC760 Offset: 0x16BB960 VA: 0x1816BC760
	internal static int get_metadata_token(RuntimeFieldInfo monoField) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Reflection
internal struct MonoMethodInfo // TypeDefIndex: 4192
{
	// Fields
	private Type parent; // 0x0
	private Type ret; // 0x8
	internal MethodAttributes attrs; // 0x10
	internal MethodImplAttributes iattrs; // 0x14
	private CallingConventions callconv; // 0x18

	// Methods

	// RVA: 0x16B5690 Offset: 0x16B4890 VA: 0x1816B5690
	private static void get_method_info(IntPtr handle, out MonoMethodInfo info) { }

	// RVA: 0x16B54C0 Offset: 0x16B46C0 VA: 0x1816B54C0
	private static int get_method_attributes(IntPtr handle) { }

	// RVA: 0x16B5560 Offset: 0x16B4760 VA: 0x1816B5560
	internal static MonoMethodInfo GetMethodInfo(IntPtr handle) { }

	// RVA: 0x16B5500 Offset: 0x16B4700 VA: 0x1816B5500
	internal static Type GetDeclaringType(IntPtr handle) { }

	// RVA: 0x16B5660 Offset: 0x16B4860 VA: 0x1816B5660
	internal static Type GetReturnType(IntPtr handle) { }

	// RVA: 0x16B54C0 Offset: 0x16B46C0 VA: 0x1816B54C0
	internal static MethodAttributes GetAttributes(IntPtr handle) { }

	// RVA: 0x16B54D0 Offset: 0x16B46D0 VA: 0x1816B54D0
	internal static CallingConventions GetCallingConvention(IntPtr handle) { }

	// RVA: 0x16B5530 Offset: 0x16B4730 VA: 0x1816B5530
	internal static MethodImplAttributes GetMethodImplementationFlags(IntPtr handle) { }

	// RVA: 0x16B5590 Offset: 0x16B4790 VA: 0x1816B5590
	private static ParameterInfo[] get_parameter_info(IntPtr handle, MemberInfo member) { }

	// RVA: 0x16B5590 Offset: 0x16B4790 VA: 0x1816B5590
	internal static ParameterInfo[] GetParametersInfo(IntPtr handle, MemberInfo member) { }

	// RVA: 0x16181A0 Offset: 0x16173A0 VA: 0x1816181A0
	private static MarshalAsAttribute get_retval_marshal(IntPtr handle) { }

	// RVA: 0x16B55A0 Offset: 0x16B47A0 VA: 0x1816B55A0
	internal static ParameterInfo GetReturnParameterInfo(RuntimeMethodInfo method) { }
}

// Namespace: System.Reflection
[Serializable]
internal class RuntimeMethodInfo : MethodInfo, ISerializable // TypeDefIndex: 4193
{
	// Fields
	internal IntPtr mhandle; // 0x10
	private string name; // 0x18
	private Type reftype; // 0x20

	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }
	public override ParameterInfo ReturnParameter { get; }
	public override Type ReturnType { get; }
	public override int MetadataToken { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsGenericMethodDefinition { get; }
	public override bool IsGenericMethod { get; }
	public override bool ContainsGenericParameters { get; }
	public override bool IsSecurityCritical { get; }

	// Methods

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x16BF530 Offset: 0x16BE730 VA: 0x1816BF530 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x16BFF80 Offset: 0x16BF180 VA: 0x1816BFF80
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x16BE2E0 Offset: 0x16BD4E0 VA: 0x1816BE2E0 Slot: 42
	internal override string FormatNameAndSig(bool serialization) { }

	// RVA: 0x16BE2A0 Offset: 0x16BD4A0 VA: 0x1816BE2A0 Slot: 50
	public override Delegate CreateDelegate(Type delegateType) { }

	// RVA: 0x16BE2C0 Offset: 0x16BD4C0 VA: 0x1816BE2C0 Slot: 51
	public override Delegate CreateDelegate(Type delegateType, object target) { }

	// RVA: 0x16BFDE0 Offset: 0x16BEFE0 VA: 0x1816BFDE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x16BF530 Offset: 0x16BE730 VA: 0x1816BF530
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x16BEF10 Offset: 0x16BE110 VA: 0x1816BEF10 Slot: 53
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16BFD40 Offset: 0x16BEF40 VA: 0x1816BFD40
	internal string SerializationToString() { }

	// RVA: 0x16BEEF0 Offset: 0x16BE0F0 VA: 0x1816BEEF0
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle) { }

	// RVA: 0x16BEF00 Offset: 0x16BE100 VA: 0x1816BEF00
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle, RuntimeTypeHandle reflectedType) { }

	// RVA: 0x16BEEC0 Offset: 0x16BE0C0 VA: 0x1816BEEC0
	internal static MethodBody GetMethodBodyInternal(IntPtr handle) { }

	// RVA: 0x16BEEC0 Offset: 0x16BE0C0 VA: 0x1816BEEC0
	internal static MethodBody GetMethodBody(IntPtr handle) { }

	// RVA: 0x16BEED0 Offset: 0x16BE0D0 VA: 0x1816BEED0
	internal static MethodBase GetMethodFromHandleInternalType(IntPtr method_handle, IntPtr type_handle) { }

	// RVA: 0x16BEEE0 Offset: 0x16BE0E0 VA: 0x1816BEEE0
	private static MethodBase GetMethodFromHandleInternalType_native(IntPtr method_handle, IntPtr type_handle, bool genericCheck) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	internal void .ctor() { }

	// RVA: 0x16C0060 Offset: 0x16BF260 VA: 0x1816C0060
	internal static string get_name(MethodBase method) { }

	// RVA: 0x16C0050 Offset: 0x16BF250 VA: 0x1816C0050
	internal static RuntimeMethodInfo get_base_method(RuntimeMethodInfo method, bool definition) { }

	// RVA: 0x16BC760 Offset: 0x16BB960 VA: 0x1816BC760
	internal static int get_metadata_token(RuntimeMethodInfo method) { }

	// RVA: 0x16BE5E0 Offset: 0x16BD7E0 VA: 0x1816BE5E0 Slot: 49
	public override MethodInfo GetBaseDefinition() { }

	// RVA: 0x16BE5F0 Offset: 0x16BD7F0 VA: 0x1816BE5F0
	internal MethodInfo GetBaseMethod() { }

	// RVA: 0x16B55A0 Offset: 0x16B47A0 VA: 0x1816B55A0 Slot: 45
	public override ParameterInfo get_ReturnParameter() { }

	// RVA: 0x16C0020 Offset: 0x16BF220 VA: 0x1816C0020 Slot: 46
	public override Type get_ReturnType() { }

	// RVA: 0x16BC760 Offset: 0x16BB960 VA: 0x1816BC760 Slot: 16
	public override int get_MetadataToken() { }

	// RVA: 0x16BBF30 Offset: 0x16BB130 VA: 0x1816BBF30 Slot: 20
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x16BF130 Offset: 0x16BE330 VA: 0x1816BF130 Slot: 17
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x16BC120 Offset: 0x16BB320 VA: 0x1816BC120 Slot: 40
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x16BF100 Offset: 0x16BE300 VA: 0x1816BF100 Slot: 41
	internal override int GetParametersCount() { }

	// RVA: 0x16BF620 Offset: 0x16BE820 VA: 0x1816BF620
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x16BF630 Offset: 0x16BE830 VA: 0x1816BF630 Slot: 37
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x16BDF60 Offset: 0x16BD160 VA: 0x1816BDF60
	internal static void ConvertValues(Binder binder, object[] args, ParameterInfo[] pinfo, CultureInfo culture, BindingFlags invokeAttr) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 38
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x16BC6B0 Offset: 0x16BB8B0 VA: 0x1816BC6B0 Slot: 18
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x16BC6C0 Offset: 0x16BB8C0 VA: 0x1816BC6C0 Slot: 22
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x16BC730 Offset: 0x16BB930 VA: 0x1816BC730 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x16BC770 Offset: 0x16BB970 VA: 0x1816BC770 Slot: 8
	public override string get_Name() { }

	// RVA: 0x16BF920 Offset: 0x16BEB20 VA: 0x1816BF920 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x16BE670 Offset: 0x16BD870 VA: 0x1816BE670 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x16BE600 Offset: 0x16BD800 VA: 0x1816BE600 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x16BF0F0 Offset: 0x16BE2F0 VA: 0x1816BF0F0
	internal void GetPInvoke(out PInvokeAttributes flags, out string entryPoint, out string dllName) { }

	// RVA: 0x16BF3B0 Offset: 0x16BE5B0 VA: 0x1816BF3B0
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x16BF1C0 Offset: 0x16BE3C0 VA: 0x1816BF1C0
	internal CustomAttributeData[] GetPseudoCustomAttributesData() { }

	// RVA: 0x16BE6D0 Offset: 0x16BD8D0 VA: 0x1816BE6D0
	private CustomAttributeData GetDllImportAttributeData() { }

	// RVA: 0x16BF9A0 Offset: 0x16BEBA0 VA: 0x1816BF9A0 Slot: 48
	public override MethodInfo MakeGenericMethod(Type[] methodInstantiation) { }

	// RVA: 0x16BF990 Offset: 0x16BEB90 VA: 0x1816BF990
	private MethodInfo MakeGenericMethod_impl(Type[] types) { }

	// RVA: 0x16BEE40 Offset: 0x16BE040 VA: 0x1816BEE40 Slot: 34
	public override Type[] GetGenericArguments() { }

	// RVA: 0x16BEE50 Offset: 0x16BE050 VA: 0x1816BEE50
	private MethodInfo GetGenericMethodDefinition_impl() { }

	// RVA: 0x16BEE60 Offset: 0x16BE060 VA: 0x1816BEE60 Slot: 47
	public override MethodInfo GetGenericMethodDefinition() { }

	// RVA: 0x16BFF60 Offset: 0x16BF160 VA: 0x1816BFF60 Slot: 33
	public override bool get_IsGenericMethodDefinition() { }

	// RVA: 0x16BFF70 Offset: 0x16BF170 VA: 0x1816BFF70 Slot: 32
	public override bool get_IsGenericMethod() { }

	// RVA: 0x16BFE70 Offset: 0x16BF070 VA: 0x1816BFE70 Slot: 35
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x16BBF20 Offset: 0x16BB120 VA: 0x1816BBF20 Slot: 21
	public override MethodBody GetMethodBody() { }

	// RVA: 0x16AF620 Offset: 0x16AE820 VA: 0x1816AF620 Slot: 15
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10
	private static int get_core_clr_security_level() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 39
	public override bool get_IsSecurityCritical() { }
}

// Namespace: System.Reflection
[Serializable]
internal class RuntimeConstructorInfo : ConstructorInfo, ISerializable // TypeDefIndex: 4194
{
	// Fields
	internal IntPtr mhandle; // 0x10
	private string name; // 0x18
	private Type reftype; // 0x20

	// Properties
	public override Module Module { get; }
	internal BindingFlags BindingFlags { get; }
	private RuntimeType ReflectedTypeInternal { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override bool ContainsGenericParameters { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsSecurityCritical { get; }
	public override int MetadataToken { get; }

	// Methods

	// RVA: 0x16BC130 Offset: 0x16BB330 VA: 0x1816BC130 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x16BC130 Offset: 0x16BB330 VA: 0x1816BC130
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x16BC780 Offset: 0x16BB980 VA: 0x1816BC780
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x16BBF60 Offset: 0x16BB160 VA: 0x1816BBF60 Slot: 46
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16BC5E0 Offset: 0x16BB7E0 VA: 0x1816BC5E0
	internal string SerializationToString() { }

	// RVA: 0x16BC4B0 Offset: 0x16BB6B0 VA: 0x1816BC4B0
	internal void SerializationInvoke(object target, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16BBF30 Offset: 0x16BB130 VA: 0x1816BBF30 Slot: 20
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x16BC120 Offset: 0x16BB320 VA: 0x1816BC120 Slot: 17
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x16BC120 Offset: 0x16BB320 VA: 0x1816BC120 Slot: 40
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x16BC0F0 Offset: 0x16BB2F0 VA: 0x1816BC0F0 Slot: 41
	internal override int GetParametersCount() { }

	// RVA: 0x16BC1D0 Offset: 0x16BB3D0 VA: 0x1816BC1D0
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x16BC300 Offset: 0x16BB500 VA: 0x1816BC300 Slot: 37
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x16BBBF0 Offset: 0x16BADF0 VA: 0x1816BBBF0
	private object DoInvoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x16BC1E0 Offset: 0x16BB3E0 VA: 0x1816BC1E0
	public object InternalInvoke(object obj, object[] parameters, bool wrapExceptions) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x16BC2D0 Offset: 0x16BB4D0 VA: 0x1816BC2D0 Slot: 45
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 38
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x16BC6B0 Offset: 0x16BB8B0 VA: 0x1816BC6B0 Slot: 18
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x16BC6C0 Offset: 0x16BB8C0 VA: 0x1816BC6C0 Slot: 22
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x16BC6F0 Offset: 0x16BB8F0 VA: 0x1816BC6F0 Slot: 35
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x16BC730 Offset: 0x16BB930 VA: 0x1816BC730 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x16BC770 Offset: 0x16BB970 VA: 0x1816BC770 Slot: 8
	public override string get_Name() { }

	// RVA: 0x16BC440 Offset: 0x16BB640 VA: 0x1816BC440 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x16BBE50 Offset: 0x16BB050 VA: 0x1816BBE50 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x16BBEB0 Offset: 0x16BB0B0 VA: 0x1816BBEB0 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x16BBF20 Offset: 0x16BB120 VA: 0x1816BBF20 Slot: 21
	public override MethodBody GetMethodBody() { }

	// RVA: 0x16BC600 Offset: 0x16BB800 VA: 0x1816BC600 Slot: 3
	public override string ToString() { }

	// RVA: 0x16AF620 Offset: 0x16AE820 VA: 0x1816AF620 Slot: 15
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10
	private static int get_core_clr_security_level() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 39
	public override bool get_IsSecurityCritical() { }

	// RVA: 0x16BC760 Offset: 0x16BB960 VA: 0x1816BC760 Slot: 16
	public override int get_MetadataToken() { }

	// RVA: 0x16BC760 Offset: 0x16BB960 VA: 0x1816BC760
	internal static int get_metadata_token(RuntimeConstructorInfo method) { }

	// RVA: 0x16BC660 Offset: 0x16BB860 VA: 0x1816BC660
	public void .ctor() { }
}

// Namespace: System.Reflection
[ComDefaultInterface(typeof(_Module))]
[ComVisible(True)]
[ClassInterface(0)]
[Serializable]
internal class RuntimeModule : Module // TypeDefIndex: 4195
{
	// Fields
	internal IntPtr _impl; // 0x10
	internal Assembly assembly; // 0x18
	internal string fqname; // 0x20
	internal string name; // 0x28
	internal string scopename; // 0x30
	internal bool is_resource; // 0x38
	internal int token; // 0x3C

	// Properties
	public override Assembly Assembly { get; }
	public override string Name { get; }
	public override string ScopeName { get; }
	public override Guid ModuleVersionId { get; }
	public override string FullyQualifiedName { get; }

	// Methods

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	public override Assembly get_Assembly() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 10
	public override string get_Name() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 12
	public override string get_ScopeName() { }

	// RVA: 0x16C0600 Offset: 0x16BF800 VA: 0x1816C0600 Slot: 11
	public override Guid get_ModuleVersionId() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 9
	public override string get_FullyQualifiedName() { }

	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700 Slot: 13
	public override bool IsResource() { }

	// RVA: 0x16C00E0 Offset: 0x16BF2E0 VA: 0x1816C00E0 Slot: 16
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x16C0070 Offset: 0x16BF270 VA: 0x1816C0070 Slot: 17
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x16C0370 Offset: 0x16BF570 VA: 0x1816C0370 Slot: 14
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x16C04D0 Offset: 0x16BF6D0 VA: 0x1816C04D0 Slot: 18
	public override MemberInfo ResolveMember(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments) { }

	// RVA: 0x16C03F0 Offset: 0x16BF5F0 VA: 0x1816C03F0
	internal static MemberInfo ResolveMember(Module module, IntPtr monoModule, int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments) { }

	// RVA: 0x16C01C0 Offset: 0x16BF3C0 VA: 0x1816C01C0 Slot: 19
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16AF580 Offset: 0x16AE780 VA: 0x1816AF580 Slot: 15
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x16C02E0 Offset: 0x16BF4E0 VA: 0x1816C02E0
	internal RuntimeAssembly GetRuntimeAssembly() { }

	// RVA: 0x16C0140 Offset: 0x16BF340 VA: 0x1816C0140 Slot: 20
	internal override Guid GetModuleVersionId() { }

	// RVA: 0x16C0790 Offset: 0x16BF990 VA: 0x1816C0790
	internal static Exception resolve_token_exception(string name, int metadataToken, ResolveTokenError error, string tokenType) { }

	// RVA: 0x16C0630 Offset: 0x16BF830 VA: 0x1816C0630
	internal static IntPtr[] ptrs_from_types(Type[] types) { }

	// RVA: 0x15ADB40 Offset: 0x15ACD40 VA: 0x1815ADB40
	private static void GetGuidInternal(IntPtr module, byte[] guid) { }

	// RVA: 0x16C03E0 Offset: 0x16BF5E0 VA: 0x1816C03E0
	internal static MemberInfo ResolveMemberToken(IntPtr module, int token, IntPtr[] type_args, IntPtr[] method_args, out ResolveTokenError error) { }

	// RVA: 0x16C05B0 Offset: 0x16BF7B0 VA: 0x1816C05B0
	public void .ctor() { }
}

// Namespace: System.Reflection
internal enum ResolveTokenError // TypeDefIndex: 4196
{
	// Fields
	public int value__; // 0x0
	public const ResolveTokenError OutOfRange = 0;
	public const ResolveTokenError BadTable = 1;
	public const ResolveTokenError Other = 2;
}

// Namespace: System.Reflection
[ClassInterface(0)]
[ComVisible(True)]
[ComDefaultInterface(typeof(_ParameterInfo))]
[Serializable]
internal class RuntimeParameterInfo : ParameterInfo // TypeDefIndex: 4197
{
	// Fields
	internal MarshalAsAttribute marshalAs; // 0x40

	// Properties
	public override object DefaultValue { get; }
	public override bool HasDefaultValue { get; }

	// Methods

	// RVA: 0x16C1740 Offset: 0x16C0940 VA: 0x1816C1740
	internal void .ctor(string name, Type type, int position, int attrs, object defaultValue, MemberInfo member, MarshalAsAttribute marshalAs) { }

	// RVA: 0x16C08C0 Offset: 0x16BFAC0 VA: 0x1816C08C0
	internal static void FormatParameters(StringBuilder sb, ParameterInfo[] p, CallingConventions callingConvention, bool serialization) { }

	// RVA: 0x16C1810 Offset: 0x16C0A10 VA: 0x1816C1810
	internal void .ctor(ParameterInfo pinfo, MemberInfo member) { }

	// RVA: 0x16C17B0 Offset: 0x16C09B0 VA: 0x1816C17B0
	internal void .ctor(Type type, MemberInfo member, MarshalAsAttribute marshalAs) { }

	// RVA: 0x16C1960 Offset: 0x16C0B60 VA: 0x1816C1960 Slot: 13
	public override object get_DefaultValue() { }

	// RVA: 0x16C0B10 Offset: 0x16BFD10 VA: 0x1816C0B10 Slot: 17
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x16C0AB0 Offset: 0x16BFCB0 VA: 0x1816C0AB0 Slot: 18
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x16C0B60 Offset: 0x16BFD60 VA: 0x1816C0B60
	internal object GetDefaultValueImpl(ParameterInfo pinfo) { }

	// RVA: 0x16C14C0 Offset: 0x16C06C0 VA: 0x1816C14C0 Slot: 15
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x16AF5D0 Offset: 0x16AE7D0 VA: 0x1816AF5D0 Slot: 16
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x16C11E0 Offset: 0x16C03E0 VA: 0x1816C11E0
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x16C0C20 Offset: 0x16BFE20 VA: 0x1816C0C20
	internal CustomAttributeData[] GetPseudoCustomAttributesData() { }

	// RVA: 0x16C1C90 Offset: 0x16C0E90 VA: 0x1816C1C90 Slot: 14
	public override bool get_HasDefaultValue() { }

	// RVA: 0x16C1530 Offset: 0x16C0730 VA: 0x1816C1530
	internal static ParameterInfo New(ParameterInfo pinfo, MemberInfo member) { }

	// RVA: 0x16C16B0 Offset: 0x16C08B0 VA: 0x1816C16B0
	internal static ParameterInfo New(Type type, MemberInfo member, MarshalAsAttribute marshalAs) { }
}

// Namespace: System.Reflection
internal struct MonoPropertyInfo // TypeDefIndex: 4198
{
	// Fields
	public Type parent; // 0x0
	public Type declaring_type; // 0x8
	public string name; // 0x10
	public MethodInfo get_method; // 0x18
	public MethodInfo set_method; // 0x20
	public PropertyAttributes attrs; // 0x28
}

// Namespace: System.Reflection
[Flags]
internal enum PInfo // TypeDefIndex: 4199
{
	// Fields
	public int value__; // 0x0
	public const PInfo Attributes = 1;
	public const PInfo GetMethod = 2;
	public const PInfo SetMethod = 4;
	public const PInfo ReflectedType = 8;
	public const PInfo DeclaringType = 16;
	public const PInfo Name = 32;
}

// Namespace: 
private sealed class RuntimePropertyInfo.GetterAdapter : MulticastDelegate // TypeDefIndex: 4200
{
	// Methods

	// RVA: 0x11F2F10 Offset: 0x11F2110 VA: 0x1811F2F10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual object Invoke(object _this) { }
}

// Namespace: 
private sealed class RuntimePropertyInfo.Getter<T, R> : MulticastDelegate // TypeDefIndex: 4201
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1211CC0 Offset: 0x1210EC0 VA: 0x181211CC0
	|-RuntimePropertyInfo.Getter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual R Invoke(T _this) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10
	|-RuntimePropertyInfo.Getter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
private sealed class RuntimePropertyInfo.StaticGetter<R> : MulticastDelegate // TypeDefIndex: 4202
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC3FA00 Offset: 0xC3EC00 VA: 0x180C3FA00
	|-RuntimePropertyInfo.StaticGetter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual R Invoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250
	|-RuntimePropertyInfo.StaticGetter<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System.Reflection
[Serializable]
internal class RuntimePropertyInfo : PropertyInfo, ISerializable // TypeDefIndex: 4203
{
	// Fields
	internal IntPtr klass; // 0x10
	internal IntPtr prop; // 0x18
	private MonoPropertyInfo info; // 0x20
	private PInfo cached; // 0x50
	private RuntimePropertyInfo.GetterAdapter cached_getter; // 0x58

	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override Type PropertyType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override int MetadataToken { get; }

	// Methods

	// RVA: 0x16C3020 Offset: 0x16C2220 VA: 0x1816C3020
	internal static void get_property_info(RuntimePropertyInfo prop, ref MonoPropertyInfo info, PInfo req_info) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x16C2840 Offset: 0x16C1A40 VA: 0x1816C2840 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x16C2190 Offset: 0x16C1390 VA: 0x1816C2190
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x16C2F40 Offset: 0x16C2140 VA: 0x1816C2F40
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x16C2840 Offset: 0x16C1A40 VA: 0x1816C2840
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x16C2DA0 Offset: 0x16C1FA0 VA: 0x1816C2DA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x16C1DF0 Offset: 0x16C0FF0 VA: 0x1816C1DF0
	private string FormatNameAndSig(bool serialization) { }

	// RVA: 0x16C25E0 Offset: 0x16C17E0 VA: 0x1816C25E0 Slot: 31
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16C2B60 Offset: 0x16C1D60 VA: 0x1816C2B60
	internal string SerializationToString() { }

	// RVA: 0x16C1DB0 Offset: 0x16C0FB0 VA: 0x1816C1DB0
	private void CachePropertyInfo(PInfo flags) { }

	// RVA: 0x16C2DB0 Offset: 0x16C1FB0 VA: 0x1816C2DB0 Slot: 19
	public override bool get_CanRead() { }

	// RVA: 0x16C2DE0 Offset: 0x16C1FE0 VA: 0x1816C2DE0 Slot: 20
	public override bool get_CanWrite() { }

	// RVA: 0x16C2E90 Offset: 0x16C2090 VA: 0x1816C2E90 Slot: 17
	public override Type get_PropertyType() { }

	// RVA: 0x16C2FE0 Offset: 0x16C21E0 VA: 0x1816C2FE0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x16C2E10 Offset: 0x16C2010 VA: 0x1816C2E10 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x16C2E50 Offset: 0x16C2050 VA: 0x1816C2E50 Slot: 8
	public override string get_Name() { }

	// RVA: 0x16C2230 Offset: 0x16C1430 VA: 0x1816C2230 Slot: 23
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x16C2290 Offset: 0x16C1490 VA: 0x1816C2290 Slot: 18
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x16C28F0 Offset: 0x16C1AF0 VA: 0x1816C28F0 Slot: 26
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0x16C2B00 Offset: 0x16C1D00 VA: 0x1816C2B00 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x16C20E0 Offset: 0x16C12E0 VA: 0x1816C20E0 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x16C2130 Offset: 0x16C1330 VA: 0x1816C2130 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: -1 Offset: -1
	private static object GetterAdapterFrame<T, R>(RuntimePropertyInfo.Getter<T, R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA69F00 Offset: 0xA69100 VA: 0x180A69F00
	|-RuntimePropertyInfo.GetterAdapterFrame<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static object StaticGetterAdapterFrame<R>(RuntimePropertyInfo.StaticGetter<R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA6A030 Offset: 0xA69230 VA: 0x180A6A030
	|-RuntimePropertyInfo.StaticGetterAdapterFrame<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x16BA680 Offset: 0x16B9880 VA: 0x1816BA680 Slot: 27
	public override object GetValue(object obj, object[] index) { }

	// RVA: 0x16C2950 Offset: 0x16C1B50 VA: 0x1816C2950 Slot: 28
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x16C2B70 Offset: 0x16C1D70 VA: 0x1816C2B70 Slot: 30
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x16AF620 Offset: 0x16AE820 VA: 0x1816AF620 Slot: 15
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x16BC760 Offset: 0x16BB960 VA: 0x1816BC760 Slot: 16
	public override int get_MetadataToken() { }

	// RVA: 0x16BC760 Offset: 0x16BB960 VA: 0x1816BC760
	internal static int get_metadata_token(RuntimePropertyInfo monoProperty) { }

	// RVA: 0x16C3030 Offset: 0x16C2230 VA: 0x1816C3030
	private static PropertyInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	// RVA: 0x16C2770 Offset: 0x16C1970 VA: 0x1816C2770
	internal static PropertyInfo GetPropertyFromHandle(RuntimePropertyHandle handle, RuntimeTypeHandle reflectedType) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Reflection
[ComVisible(True)]
[Serializable]
public class StrongNameKeyPair : ISerializable, IDeserializationCallback // TypeDefIndex: 4204
{
	// Fields
	private byte[] _publicKey; // 0x10
	private string _keyPairContainer; // 0x18
	private bool _keyPairExported; // 0x20
	private byte[] _keyPairArray; // 0x28

	// Methods

	// RVA: 0x16C5A10 Offset: 0x16C4C10 VA: 0x1816C5A10
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16C58D0 Offset: 0x16C4AD0 VA: 0x1816C58D0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
}

// Namespace: System.Reflection.Emit
public enum OpCodeType // TypeDefIndex: 4205
{
	// Fields
	public int value__; // 0x0
	[Obsolete("This API has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
	public const OpCodeType Annotation = 0;
	public const OpCodeType Macro = 1;
	public const OpCodeType Nternal = 2;
	public const OpCodeType Objmodel = 3;
	public const OpCodeType Prefix = 4;
	public const OpCodeType Primitive = 5;
}

// Namespace: System.Reflection.Emit
public enum OperandType // TypeDefIndex: 4206
{
	// Fields
	public int value__; // 0x0
	public const OperandType InlineBrTarget = 0;
	public const OperandType InlineField = 1;
	public const OperandType InlineI = 2;
	public const OperandType InlineI8 = 3;
	public const OperandType InlineMethod = 4;
	public const OperandType InlineNone = 5;
	[Obsolete("This API has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
	public const OperandType InlinePhi = 6;
	public const OperandType InlineR = 7;
	public const OperandType InlineSig = 9;
	public const OperandType InlineString = 10;
	public const OperandType InlineSwitch = 11;
	public const OperandType InlineTok = 12;
	public const OperandType InlineType = 13;
	public const OperandType InlineVar = 14;
	public const OperandType ShortInlineBrTarget = 15;
	public const OperandType ShortInlineI = 16;
	public const OperandType ShortInlineR = 17;
	public const OperandType ShortInlineVar = 18;
}

// Namespace: System.Reflection.Emit
public class AssemblyBuilder : Assembly // TypeDefIndex: 4207
{}

// Namespace: System.Reflection.Emit
public class ConstructorBuilder : ConstructorInfo // TypeDefIndex: 4208
{
	// Properties
	public override MethodAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x16AEEC0 Offset: 0x16AE0C0 VA: 0x1816AEEC0 Slot: 18
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x16AEF00 Offset: 0x16AE100 VA: 0x1816AEF00 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x16AEF80 Offset: 0x16AE180 VA: 0x1816AEF80 Slot: 8
	public override string get_Name() { }

	// RVA: 0x16AEDC0 Offset: 0x16ADFC0 VA: 0x1816AEDC0 Slot: 17
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x16AED80 Offset: 0x16ADF80 VA: 0x1816AED80 Slot: 20
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x16AEF40 Offset: 0x16AE140 VA: 0x1816AEF40 Slot: 38
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x16AEE40 Offset: 0x16AE040 VA: 0x1816AEE40 Slot: 45
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x16AEE80 Offset: 0x16AE080 VA: 0x1816AEE80 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x16AED00 Offset: 0x16ADF00 VA: 0x1816AED00 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x16AED40 Offset: 0x16ADF40 VA: 0x1816AED40 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x16AEFC0 Offset: 0x16AE1C0 VA: 0x1816AEFC0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x16AEE00 Offset: 0x16AE000 VA: 0x1816AEE00 Slot: 37
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }
}

// Namespace: System.Reflection.Emit
public class CustomAttributeBuilder // TypeDefIndex: 4209
{}

// Namespace: System.Reflection.Emit
public sealed class DynamicMethod : MethodInfo // TypeDefIndex: 4210
{
	// Properties
	public override MethodAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x16B1E50 Offset: 0x16B1050 VA: 0x1816B1E50 Slot: 18
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x16B1E90 Offset: 0x16B1090 VA: 0x1816B1E90 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x16B1F10 Offset: 0x16B1110 VA: 0x1816B1F10 Slot: 8
	public override string get_Name() { }

	// RVA: 0x16B1D90 Offset: 0x16B0F90 VA: 0x1816B1D90 Slot: 17
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x16B1ED0 Offset: 0x16B10D0 VA: 0x1816B1ED0 Slot: 38
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x16B1F50 Offset: 0x16B1150 VA: 0x1816B1F50 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x16B1D10 Offset: 0x16B0F10 VA: 0x1816B1D10 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x16B1CD0 Offset: 0x16B0ED0 VA: 0x1816B1CD0 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x16B1D50 Offset: 0x16B0F50 VA: 0x1816B1D50 Slot: 20
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x16B1C90 Offset: 0x16B0E90 VA: 0x1816B1C90 Slot: 49
	public override MethodInfo GetBaseDefinition() { }

	// RVA: 0x16B1DD0 Offset: 0x16B0FD0 VA: 0x1816B1DD0 Slot: 37
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x16B1E10 Offset: 0x16B1010 VA: 0x1816B1E10 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }
}

// Namespace: System.Reflection.Emit
public sealed class EnumBuilder : TypeInfo // TypeDefIndex: 4211
{
	// Properties
	public override Assembly Assembly { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type BaseType { get; }
	public override string FullName { get; }
	public override Guid GUID { get; }
	public override Module Module { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override Type UnderlyingSystemType { get; }

	// Methods

	// RVA: 0x16B2610 Offset: 0x16B1810 VA: 0x1816B2610 Slot: 28
	public override Assembly get_Assembly() { }

	// RVA: 0x16B25D0 Offset: 0x16B17D0 VA: 0x1816B25D0 Slot: 26
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x16B2650 Offset: 0x16B1850 VA: 0x1816B2650 Slot: 117
	public override Type get_BaseType() { }

	// RVA: 0x16B2690 Offset: 0x16B1890 VA: 0x1816B2690 Slot: 27
	public override string get_FullName() { }

	// RVA: 0x16B26D0 Offset: 0x16B18D0 VA: 0x1816B26D0 Slot: 116
	public override Guid get_GUID() { }

	// RVA: 0x16B2710 Offset: 0x16B1910 VA: 0x1816B2710 Slot: 29
	public override Module get_Module() { }

	// RVA: 0x16B2750 Offset: 0x16B1950 VA: 0x1816B2750 Slot: 8
	public override string get_Name() { }

	// RVA: 0x16B2790 Offset: 0x16B1990 VA: 0x1816B2790 Slot: 25
	public override string get_Namespace() { }

	// RVA: 0x16B27D0 Offset: 0x16B19D0 VA: 0x1816B27D0 Slot: 31
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x16B1F90 Offset: 0x16B1190 VA: 0x1816B1F90 Slot: 56
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x16B1FD0 Offset: 0x16B11D0 VA: 0x1816B1FD0 Slot: 81
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	// RVA: 0x16B2010 Offset: 0x16B1210 VA: 0x1816B2010 Slot: 83
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x16B2090 Offset: 0x16B1290 VA: 0x1816B2090 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x16B2050 Offset: 0x16B1250 VA: 0x1816B2050 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x16B20D0 Offset: 0x16B12D0 VA: 0x1816B20D0 Slot: 47
	public override Type GetElementType() { }

	// RVA: 0x16B2110 Offset: 0x16B1310 VA: 0x1816B2110 Slot: 85
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x16B2150 Offset: 0x16B1350 VA: 0x1816B2150 Slot: 86
	public override EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	// RVA: 0x16B2190 Offset: 0x16B1390 VA: 0x1816B2190 Slot: 88
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x16B21D0 Offset: 0x16B13D0 VA: 0x1816B21D0 Slot: 90
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x16B2210 Offset: 0x16B1410 VA: 0x1816B2210 Slot: 120
	public override Type[] GetInterfaces() { }

	// RVA: 0x16B2250 Offset: 0x16B1450 VA: 0x1816B2250 Slot: 94
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x16B2290 Offset: 0x16B1490 VA: 0x1816B2290 Slot: 101
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x16B22D0 Offset: 0x16B14D0 VA: 0x1816B22D0 Slot: 103
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x16B2310 Offset: 0x16B1510 VA: 0x1816B2310 Slot: 104
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x16B2350 Offset: 0x16B1550 VA: 0x1816B2350 Slot: 113
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x16B2390 Offset: 0x16B1590 VA: 0x1816B2390 Slot: 111
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x16B23D0 Offset: 0x16B15D0 VA: 0x1816B23D0 Slot: 46
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x16B2410 Offset: 0x16B1610 VA: 0x1816B2410 Slot: 119
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x16B2450 Offset: 0x16B1650 VA: 0x1816B2450 Slot: 33
	protected override bool IsArrayImpl() { }

	// RVA: 0x16B2490 Offset: 0x16B1690 VA: 0x1816B2490 Slot: 35
	protected override bool IsByRefImpl() { }

	// RVA: 0x16B24D0 Offset: 0x16B16D0 VA: 0x1816B24D0 Slot: 66
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x16B2510 Offset: 0x16B1710 VA: 0x1816B2510 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x16B2550 Offset: 0x16B1750 VA: 0x1816B2550 Slot: 37
	protected override bool IsPointerImpl() { }

	// RVA: 0x16B2590 Offset: 0x16B1790 VA: 0x1816B2590 Slot: 74
	protected override bool IsPrimitiveImpl() { }
}

// Namespace: System.Reflection.Emit
public class EventBuilder // TypeDefIndex: 4212
{}

// Namespace: System.Reflection.Emit
public sealed class FieldBuilder : FieldInfo // TypeDefIndex: 4213
{
	// Properties
	public override FieldAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override Type FieldType { get; }
	public override string Name { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x16B2AF0 Offset: 0x16B1CF0 VA: 0x1816B2AF0 Slot: 17
	public override FieldAttributes get_Attributes() { }

	// RVA: 0x16B2AF0 Offset: 0x16B1CF0 VA: 0x1816B2AF0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x16B2AF0 Offset: 0x16B1CF0 VA: 0x1816B2AF0 Slot: 27
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x16B2AF0 Offset: 0x16B1CF0 VA: 0x1816B2AF0 Slot: 18
	public override Type get_FieldType() { }

	// RVA: 0x16B2AF0 Offset: 0x16B1CF0 VA: 0x1816B2AF0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x16B2AF0 Offset: 0x16B1CF0 VA: 0x1816B2AF0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x16B2AF0 Offset: 0x16B1CF0 VA: 0x1816B2AF0 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x16B2AF0 Offset: 0x16B1CF0 VA: 0x1816B2AF0 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x16B2AF0 Offset: 0x16B1CF0 VA: 0x1816B2AF0 Slot: 28
	public override object GetValue(object obj) { }

	// RVA: 0x16B2AF0 Offset: 0x16B1CF0 VA: 0x1816B2AF0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x16B2B00 Offset: 0x16B1D00 VA: 0x1816B2B00 Slot: 30
	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }
}

// Namespace: System.Reflection.Emit
public sealed class GenericTypeParameterBuilder : TypeInfo // TypeDefIndex: 4214
{
	// Properties
	public override Assembly Assembly { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type BaseType { get; }
	public override string FullName { get; }
	public override Guid GUID { get; }
	public override Module Module { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override Type UnderlyingSystemType { get; }

	// Methods

	// RVA: 0x16B31C0 Offset: 0x16B23C0 VA: 0x1816B31C0 Slot: 28
	public override Assembly get_Assembly() { }

	// RVA: 0x16B3180 Offset: 0x16B2380 VA: 0x1816B3180 Slot: 26
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x16B3200 Offset: 0x16B2400 VA: 0x1816B3200 Slot: 117
	public override Type get_BaseType() { }

	// RVA: 0x16B3240 Offset: 0x16B2440 VA: 0x1816B3240 Slot: 27
	public override string get_FullName() { }

	// RVA: 0x16B3280 Offset: 0x16B2480 VA: 0x1816B3280 Slot: 116
	public override Guid get_GUID() { }

	// RVA: 0x16B32C0 Offset: 0x16B24C0 VA: 0x1816B32C0 Slot: 29
	public override Module get_Module() { }

	// RVA: 0x16B3300 Offset: 0x16B2500 VA: 0x1816B3300 Slot: 8
	public override string get_Name() { }

	// RVA: 0x16B3340 Offset: 0x16B2540 VA: 0x1816B3340 Slot: 25
	public override string get_Namespace() { }

	// RVA: 0x16B3380 Offset: 0x16B2580 VA: 0x1816B3380 Slot: 31
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x16B2B40 Offset: 0x16B1D40 VA: 0x1816B2B40 Slot: 56
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x16B2B80 Offset: 0x16B1D80 VA: 0x1816B2B80 Slot: 81
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	// RVA: 0x16B2BC0 Offset: 0x16B1DC0 VA: 0x1816B2BC0 Slot: 83
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x16B2C40 Offset: 0x16B1E40 VA: 0x1816B2C40 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x16B2C00 Offset: 0x16B1E00 VA: 0x1816B2C00 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x16B2C80 Offset: 0x16B1E80 VA: 0x1816B2C80 Slot: 47
	public override Type GetElementType() { }

	// RVA: 0x16B2CC0 Offset: 0x16B1EC0 VA: 0x1816B2CC0 Slot: 85
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x16B2D00 Offset: 0x16B1F00 VA: 0x1816B2D00 Slot: 86
	public override EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	// RVA: 0x16B2D40 Offset: 0x16B1F40 VA: 0x1816B2D40 Slot: 88
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x16B2D80 Offset: 0x16B1F80 VA: 0x1816B2D80 Slot: 90
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x16B2DC0 Offset: 0x16B1FC0 VA: 0x1816B2DC0 Slot: 120
	public override Type[] GetInterfaces() { }

	// RVA: 0x16B2E00 Offset: 0x16B2000 VA: 0x1816B2E00 Slot: 94
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x16B2E40 Offset: 0x16B2040 VA: 0x1816B2E40 Slot: 101
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x16B2E80 Offset: 0x16B2080 VA: 0x1816B2E80 Slot: 103
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x16B2EC0 Offset: 0x16B20C0 VA: 0x1816B2EC0 Slot: 104
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x16B2F00 Offset: 0x16B2100 VA: 0x1816B2F00 Slot: 113
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x16B2F40 Offset: 0x16B2140 VA: 0x1816B2F40 Slot: 111
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x16B2F80 Offset: 0x16B2180 VA: 0x1816B2F80 Slot: 46
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x16B2FC0 Offset: 0x16B21C0 VA: 0x1816B2FC0 Slot: 119
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x16B3000 Offset: 0x16B2200 VA: 0x1816B3000 Slot: 33
	protected override bool IsArrayImpl() { }

	// RVA: 0x16B3040 Offset: 0x16B2240 VA: 0x1816B3040 Slot: 35
	protected override bool IsByRefImpl() { }

	// RVA: 0x16B3080 Offset: 0x16B2280 VA: 0x1816B3080 Slot: 66
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x16B30C0 Offset: 0x16B22C0 VA: 0x1816B30C0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x16B3100 Offset: 0x16B2300 VA: 0x1816B3100 Slot: 37
	protected override bool IsPointerImpl() { }

	// RVA: 0x16B3140 Offset: 0x16B2340 VA: 0x1816B3140 Slot: 74
	protected override bool IsPrimitiveImpl() { }
}

// Namespace: System.Reflection.Emit
public class ILGenerator // TypeDefIndex: 4215
{}

// Namespace: System.Reflection.Emit
public sealed class LocalBuilder : LocalVariableInfo // TypeDefIndex: 4216
{
	// Fields
	private string name; // 0x20
	internal ILGenerator ilgen; // 0x28
	private int startOffset; // 0x30
	private int endOffset; // 0x34
}

// Namespace: System.Reflection.Emit
public sealed class MethodBuilder : MethodInfo // TypeDefIndex: 4217
{
	// Properties
	public override MethodAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override string Name { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x16B4A20 Offset: 0x16B3C20 VA: 0x1816B4A20 Slot: 18
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x16B4A60 Offset: 0x16B3C60 VA: 0x1816B4A60 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x16B4AA0 Offset: 0x16B3CA0 VA: 0x1816B4AA0 Slot: 38
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x16B4AE0 Offset: 0x16B3CE0 VA: 0x1816B4AE0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x16B4B20 Offset: 0x16B3D20 VA: 0x1816B4B20 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x16B4860 Offset: 0x16B3A60 VA: 0x1816B4860 Slot: 49
	public override MethodInfo GetBaseDefinition() { }

	// RVA: 0x16B48A0 Offset: 0x16B3AA0 VA: 0x1816B48A0 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x16B48E0 Offset: 0x16B3AE0 VA: 0x1816B48E0 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x16B4920 Offset: 0x16B3B20 VA: 0x1816B4920 Slot: 20
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x16B4960 Offset: 0x16B3B60 VA: 0x1816B4960 Slot: 17
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x16B49A0 Offset: 0x16B3BA0 VA: 0x1816B49A0 Slot: 37
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x16B49E0 Offset: 0x16B3BE0 VA: 0x1816B49E0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }
}

// Namespace: System.Reflection.Emit
public class ModuleBuilder : Module // TypeDefIndex: 4218
{}

// Namespace: System.Reflection.Emit
[ComVisible(True)]
[IsReadOnly]
public struct OpCode : IEquatable<OpCode> // TypeDefIndex: 4219
{
	// Fields
	internal readonly byte op1; // 0x0
	internal readonly byte op2; // 0x1
	private readonly byte push; // 0x2
	private readonly byte pop; // 0x3
	private readonly byte size; // 0x4
	private readonly byte type; // 0x5
	private readonly byte args; // 0x6
	private readonly byte flow; // 0x7

	// Properties
	public string Name { get; }
	public int Size { get; }
	public OpCodeType OpCodeType { get; }
	public OperandType OperandType { get; }
	public short Value { get; }

	// Methods

	// RVA: 0x16B7920 Offset: 0x16B6B20 VA: 0x1816B7920
	internal void .ctor(int p, int q) { }

	// RVA: 0x16B78D0 Offset: 0x16B6AD0 VA: 0x1816B78D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x16B7840 Offset: 0x16B6A40 VA: 0x1816B7840 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x16B7820 Offset: 0x16B6A20 VA: 0x1816B7820 Slot: 4
	public bool Equals(OpCode obj) { }

	// RVA: 0x16B7910 Offset: 0x16B6B10 VA: 0x1816B7910 Slot: 3
	public override string ToString() { }

	// RVA: 0x16B7960 Offset: 0x16B6B60 VA: 0x1816B7960
	public string get_Name() { }

	// RVA: 0x499020 Offset: 0x498220 VA: 0x180499020
	public int get_Size() { }

	// RVA: 0x499050 Offset: 0x498250 VA: 0x180499050
	public OpCodeType get_OpCodeType() { }

	// RVA: 0x4E0820 Offset: 0x4DFA20 VA: 0x1804E0820
	public OperandType get_OperandType() { }

	// RVA: 0x16B7A20 Offset: 0x16B6C20 VA: 0x1816B7A20
	public short get_Value() { }
}

// Namespace: System.Reflection.Emit
internal static class OpCodeNames // TypeDefIndex: 4220
{
	// Fields
	internal static readonly string[] names; // 0x0

	// Methods

	// RVA: 0x16B56F0 Offset: 0x16B48F0 VA: 0x1816B56F0
	private static void .cctor() { }
}

// Namespace: System.Reflection.Emit
[ComVisible(True)]
public class OpCodes // TypeDefIndex: 4221
{
	// Fields
	public static readonly OpCode Nop; // 0x0
	public static readonly OpCode Break; // 0x8
	public static readonly OpCode Ldarg_0; // 0x10
	public static readonly OpCode Ldarg_1; // 0x18
	public static readonly OpCode Ldarg_2; // 0x20
	public static readonly OpCode Ldarg_3; // 0x28
	public static readonly OpCode Ldloc_0; // 0x30
	public static readonly OpCode Ldloc_1; // 0x38
	public static readonly OpCode Ldloc_2; // 0x40
	public static readonly OpCode Ldloc_3; // 0x48
	public static readonly OpCode Stloc_0; // 0x50
	public static readonly OpCode Stloc_1; // 0x58
	public static readonly OpCode Stloc_2; // 0x60
	public static readonly OpCode Stloc_3; // 0x68
	public static readonly OpCode Ldarg_S; // 0x70
	public static readonly OpCode Ldarga_S; // 0x78
	public static readonly OpCode Starg_S; // 0x80
	public static readonly OpCode Ldloc_S; // 0x88
	public static readonly OpCode Ldloca_S; // 0x90
	public static readonly OpCode Stloc_S; // 0x98
	public static readonly OpCode Ldnull; // 0xA0
	public static readonly OpCode Ldc_I4_M1; // 0xA8
	public static readonly OpCode Ldc_I4_0; // 0xB0
	public static readonly OpCode Ldc_I4_1; // 0xB8
	public static readonly OpCode Ldc_I4_2; // 0xC0
	public static readonly OpCode Ldc_I4_3; // 0xC8
	public static readonly OpCode Ldc_I4_4; // 0xD0
	public static readonly OpCode Ldc_I4_5; // 0xD8
	public static readonly OpCode Ldc_I4_6; // 0xE0
	public static readonly OpCode Ldc_I4_7; // 0xE8
	public static readonly OpCode Ldc_I4_8; // 0xF0
	public static readonly OpCode Ldc_I4_S; // 0xF8
	public static readonly OpCode Ldc_I4; // 0x100
	public static readonly OpCode Ldc_I8; // 0x108
	public static readonly OpCode Ldc_R4; // 0x110
	public static readonly OpCode Ldc_R8; // 0x118
	public static readonly OpCode Dup; // 0x120
	public static readonly OpCode Pop; // 0x128
	public static readonly OpCode Jmp; // 0x130
	public static readonly OpCode Call; // 0x138
	public static readonly OpCode Calli; // 0x140
	public static readonly OpCode Ret; // 0x148
	public static readonly OpCode Br_S; // 0x150
	public static readonly OpCode Brfalse_S; // 0x158
	public static readonly OpCode Brtrue_S; // 0x160
	public static readonly OpCode Beq_S; // 0x168
	public static readonly OpCode Bge_S; // 0x170
	public static readonly OpCode Bgt_S; // 0x178
	public static readonly OpCode Ble_S; // 0x180
	public static readonly OpCode Blt_S; // 0x188
	public static readonly OpCode Bne_Un_S; // 0x190
	public static readonly OpCode Bge_Un_S; // 0x198
	public static readonly OpCode Bgt_Un_S; // 0x1A0
	public static readonly OpCode Ble_Un_S; // 0x1A8
	public static readonly OpCode Blt_Un_S; // 0x1B0
	public static readonly OpCode Br; // 0x1B8
	public static readonly OpCode Brfalse; // 0x1C0
	public static readonly OpCode Brtrue; // 0x1C8
	public static readonly OpCode Beq; // 0x1D0
	public static readonly OpCode Bge; // 0x1D8
	public static readonly OpCode Bgt; // 0x1E0
	public static readonly OpCode Ble; // 0x1E8
	public static readonly OpCode Blt; // 0x1F0
	public static readonly OpCode Bne_Un; // 0x1F8
	public static readonly OpCode Bge_Un; // 0x200
	public static readonly OpCode Bgt_Un; // 0x208
	public static readonly OpCode Ble_Un; // 0x210
	public static readonly OpCode Blt_Un; // 0x218
	public static readonly OpCode Switch; // 0x220
	public static readonly OpCode Ldind_I1; // 0x228
	public static readonly OpCode Ldind_U1; // 0x230
	public static readonly OpCode Ldind_I2; // 0x238
	public static readonly OpCode Ldind_U2; // 0x240
	public static readonly OpCode Ldind_I4; // 0x248
	public static readonly OpCode Ldind_U4; // 0x250
	public static readonly OpCode Ldind_I8; // 0x258
	public static readonly OpCode Ldind_I; // 0x260
	public static readonly OpCode Ldind_R4; // 0x268
	public static readonly OpCode Ldind_R8; // 0x270
	public static readonly OpCode Ldind_Ref; // 0x278
	public static readonly OpCode Stind_Ref; // 0x280
	public static readonly OpCode Stind_I1; // 0x288
	public static readonly OpCode Stind_I2; // 0x290
	public static readonly OpCode Stind_I4; // 0x298
	public static readonly OpCode Stind_I8; // 0x2A0
	public static readonly OpCode Stind_R4; // 0x2A8
	public static readonly OpCode Stind_R8; // 0x2B0
	public static readonly OpCode Add; // 0x2B8
	public static readonly OpCode Sub; // 0x2C0
	public static readonly OpCode Mul; // 0x2C8
	public static readonly OpCode Div; // 0x2D0
	public static readonly OpCode Div_Un; // 0x2D8
	public static readonly OpCode Rem; // 0x2E0
	public static readonly OpCode Rem_Un; // 0x2E8
	public static readonly OpCode And; // 0x2F0
	public static readonly OpCode Or; // 0x2F8
	public static readonly OpCode Xor; // 0x300
	public static readonly OpCode Shl; // 0x308
	public static readonly OpCode Shr; // 0x310
	public static readonly OpCode Shr_Un; // 0x318
	public static readonly OpCode Neg; // 0x320
	public static readonly OpCode Not; // 0x328
	public static readonly OpCode Conv_I1; // 0x330
	public static readonly OpCode Conv_I2; // 0x338
	public static readonly OpCode Conv_I4; // 0x340
	public static readonly OpCode Conv_I8; // 0x348
	public static readonly OpCode Conv_R4; // 0x350
	public static readonly OpCode Conv_R8; // 0x358
	public static readonly OpCode Conv_U4; // 0x360
	public static readonly OpCode Conv_U8; // 0x368
	public static readonly OpCode Callvirt; // 0x370
	public static readonly OpCode Cpobj; // 0x378
	public static readonly OpCode Ldobj; // 0x380
	public static readonly OpCode Ldstr; // 0x388
	public static readonly OpCode Newobj; // 0x390
	[ComVisible(True)]
	public static readonly OpCode Castclass; // 0x398
	public static readonly OpCode Isinst; // 0x3A0
	public static readonly OpCode Conv_R_Un; // 0x3A8
	public static readonly OpCode Unbox; // 0x3B0
	public static readonly OpCode Throw; // 0x3B8
	public static readonly OpCode Ldfld; // 0x3C0
	public static readonly OpCode Ldflda; // 0x3C8
	public static readonly OpCode Stfld; // 0x3D0
	public static readonly OpCode Ldsfld; // 0x3D8
	public static readonly OpCode Ldsflda; // 0x3E0
	public static readonly OpCode Stsfld; // 0x3E8
	public static readonly OpCode Stobj; // 0x3F0
	public static readonly OpCode Conv_Ovf_I1_Un; // 0x3F8
	public static readonly OpCode Conv_Ovf_I2_Un; // 0x400
	public static readonly OpCode Conv_Ovf_I4_Un; // 0x408
	public static readonly OpCode Conv_Ovf_I8_Un; // 0x410
	public static readonly OpCode Conv_Ovf_U1_Un; // 0x418
	public static readonly OpCode Conv_Ovf_U2_Un; // 0x420
	public static readonly OpCode Conv_Ovf_U4_Un; // 0x428
	public static readonly OpCode Conv_Ovf_U8_Un; // 0x430
	public static readonly OpCode Conv_Ovf_I_Un; // 0x438
	public static readonly OpCode Conv_Ovf_U_Un; // 0x440
	public static readonly OpCode Box; // 0x448
	public static readonly OpCode Newarr; // 0x450
	public static readonly OpCode Ldlen; // 0x458
	public static readonly OpCode Ldelema; // 0x460
	public static readonly OpCode Ldelem_I1; // 0x468
	public static readonly OpCode Ldelem_U1; // 0x470
	public static readonly OpCode Ldelem_I2; // 0x478
	public static readonly OpCode Ldelem_U2; // 0x480
	public static readonly OpCode Ldelem_I4; // 0x488
	public static readonly OpCode Ldelem_U4; // 0x490
	public static readonly OpCode Ldelem_I8; // 0x498
	public static readonly OpCode Ldelem_I; // 0x4A0
	public static readonly OpCode Ldelem_R4; // 0x4A8
	public static readonly OpCode Ldelem_R8; // 0x4B0
	public static readonly OpCode Ldelem_Ref; // 0x4B8
	public static readonly OpCode Stelem_I; // 0x4C0
	public static readonly OpCode Stelem_I1; // 0x4C8
	public static readonly OpCode Stelem_I2; // 0x4D0
	public static readonly OpCode Stelem_I4; // 0x4D8
	public static readonly OpCode Stelem_I8; // 0x4E0
	public static readonly OpCode Stelem_R4; // 0x4E8
	public static readonly OpCode Stelem_R8; // 0x4F0
	public static readonly OpCode Stelem_Ref; // 0x4F8
	public static readonly OpCode Ldelem; // 0x500
	public static readonly OpCode Stelem; // 0x508
	public static readonly OpCode Unbox_Any; // 0x510
	public static readonly OpCode Conv_Ovf_I1; // 0x518
	public static readonly OpCode Conv_Ovf_U1; // 0x520
	public static readonly OpCode Conv_Ovf_I2; // 0x528
	public static readonly OpCode Conv_Ovf_U2; // 0x530
	public static readonly OpCode Conv_Ovf_I4; // 0x538
	public static readonly OpCode Conv_Ovf_U4; // 0x540
	public static readonly OpCode Conv_Ovf_I8; // 0x548
	public static readonly OpCode Conv_Ovf_U8; // 0x550
	public static readonly OpCode Refanyval; // 0x558
	public static readonly OpCode Ckfinite; // 0x560
	public static readonly OpCode Mkrefany; // 0x568
	public static readonly OpCode Ldtoken; // 0x570
	public static readonly OpCode Conv_U2; // 0x578
	public static readonly OpCode Conv_U1; // 0x580
	public static readonly OpCode Conv_I; // 0x588
	public static readonly OpCode Conv_Ovf_I; // 0x590
	public static readonly OpCode Conv_Ovf_U; // 0x598
	public static readonly OpCode Add_Ovf; // 0x5A0
	public static readonly OpCode Add_Ovf_Un; // 0x5A8
	public static readonly OpCode Mul_Ovf; // 0x5B0
	public static readonly OpCode Mul_Ovf_Un; // 0x5B8
	public static readonly OpCode Sub_Ovf; // 0x5C0
	public static readonly OpCode Sub_Ovf_Un; // 0x5C8
	public static readonly OpCode Endfinally; // 0x5D0
	public static readonly OpCode Leave; // 0x5D8
	public static readonly OpCode Leave_S; // 0x5E0
	public static readonly OpCode Stind_I; // 0x5E8
	public static readonly OpCode Conv_U; // 0x5F0
	public static readonly OpCode Prefix7; // 0x5F8
	public static readonly OpCode Prefix6; // 0x600
	public static readonly OpCode Prefix5; // 0x608
	public static readonly OpCode Prefix4; // 0x610
	public static readonly OpCode Prefix3; // 0x618
	public static readonly OpCode Prefix2; // 0x620
	public static readonly OpCode Prefix1; // 0x628
	public static readonly OpCode Prefixref; // 0x630
	public static readonly OpCode Arglist; // 0x638
	public static readonly OpCode Ceq; // 0x640
	public static readonly OpCode Cgt; // 0x648
	public static readonly OpCode Cgt_Un; // 0x650
	public static readonly OpCode Clt; // 0x658
	public static readonly OpCode Clt_Un; // 0x660
	public static readonly OpCode Ldftn; // 0x668
	public static readonly OpCode Ldvirtftn; // 0x670
	public static readonly OpCode Ldarg; // 0x678
	public static readonly OpCode Ldarga; // 0x680
	public static readonly OpCode Starg; // 0x688
	public static readonly OpCode Ldloc; // 0x690
	public static readonly OpCode Ldloca; // 0x698
	public static readonly OpCode Stloc; // 0x6A0
	public static readonly OpCode Localloc; // 0x6A8
	public static readonly OpCode Endfilter; // 0x6B0
	public static readonly OpCode Unaligned; // 0x6B8
	public static readonly OpCode Volatile; // 0x6C0
	public static readonly OpCode Tailcall; // 0x6C8
	public static readonly OpCode Initobj; // 0x6D0
	public static readonly OpCode Constrained; // 0x6D8
	public static readonly OpCode Cpblk; // 0x6E0
	public static readonly OpCode Initblk; // 0x6E8
	public static readonly OpCode Rethrow; // 0x6F0
	public static readonly OpCode Sizeof; // 0x6F8
	public static readonly OpCode Refanytype; // 0x700
	public static readonly OpCode Readonly; // 0x708

	// Methods

	// RVA: 0x16B7A40 Offset: 0x16B6C40 VA: 0x1816B7A40
	private static void .cctor() { }
}

// Namespace: System.Reflection.Emit
public class ParameterBuilder // TypeDefIndex: 4222
{}

// Namespace: System.Reflection.Emit
public sealed class PropertyBuilder : PropertyInfo // TypeDefIndex: 4223
{
	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override Type PropertyType { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x16DC1E0 Offset: 0x16DB3E0 VA: 0x1816DC1E0 Slot: 19
	public override bool get_CanRead() { }

	// RVA: 0x16DC220 Offset: 0x16DB420 VA: 0x1816DC220 Slot: 20
	public override bool get_CanWrite() { }

	// RVA: 0x16DC260 Offset: 0x16DB460 VA: 0x1816DC260 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x16DC2A0 Offset: 0x16DB4A0 VA: 0x1816DC2A0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x16DC2E0 Offset: 0x16DB4E0 VA: 0x1816DC2E0 Slot: 17
	public override Type get_PropertyType() { }

	// RVA: 0x16DC320 Offset: 0x16DB520 VA: 0x1816DC320 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x16DC020 Offset: 0x16DB220 VA: 0x1816DC020 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x16DBFE0 Offset: 0x16DB1E0 VA: 0x1816DBFE0 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x16DC060 Offset: 0x16DB260 VA: 0x1816DC060 Slot: 23
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x16DC0A0 Offset: 0x16DB2A0 VA: 0x1816DC0A0 Slot: 18
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x16DC0E0 Offset: 0x16DB2E0 VA: 0x1816DC0E0 Slot: 26
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0x16DC120 Offset: 0x16DB320 VA: 0x1816DC120 Slot: 28
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x16DC160 Offset: 0x16DB360 VA: 0x1816DC160 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x16DC1A0 Offset: 0x16DB3A0 VA: 0x1816DC1A0 Slot: 30
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }
}

// Namespace: System.Reflection.Emit
public class SignatureHelper // TypeDefIndex: 4224
{}

// Namespace: System.Reflection.Emit
public sealed class TypeBuilder : TypeInfo // TypeDefIndex: 4225
{
	// Fields
	public const int UnspecifiedTypeSize = 0;

	// Properties
	public override Assembly Assembly { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type BaseType { get; }
	public override string FullName { get; }
	public override Guid GUID { get; }
	public override Module Module { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override Type UnderlyingSystemType { get; }

	// Methods

	// RVA: 0x16E4080 Offset: 0x16E3280 VA: 0x1816E4080 Slot: 28
	public override Assembly get_Assembly() { }

	// RVA: 0x16E4040 Offset: 0x16E3240 VA: 0x1816E4040 Slot: 26
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x16E40C0 Offset: 0x16E32C0 VA: 0x1816E40C0 Slot: 117
	public override Type get_BaseType() { }

	// RVA: 0x16E4100 Offset: 0x16E3300 VA: 0x1816E4100 Slot: 27
	public override string get_FullName() { }

	// RVA: 0x16E4140 Offset: 0x16E3340 VA: 0x1816E4140 Slot: 116
	public override Guid get_GUID() { }

	// RVA: 0x16E4180 Offset: 0x16E3380 VA: 0x1816E4180 Slot: 29
	public override Module get_Module() { }

	// RVA: 0x16E41C0 Offset: 0x16E33C0 VA: 0x1816E41C0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x16E4200 Offset: 0x16E3400 VA: 0x1816E4200 Slot: 25
	public override string get_Namespace() { }

	// RVA: 0x16E4240 Offset: 0x16E3440 VA: 0x1816E4240 Slot: 31
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x16E3A00 Offset: 0x16E2C00 VA: 0x1816E3A00 Slot: 56
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x16E3A40 Offset: 0x16E2C40 VA: 0x1816E3A40 Slot: 81
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	// RVA: 0x16E3A80 Offset: 0x16E2C80 VA: 0x1816E3A80 Slot: 83
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x16E3AC0 Offset: 0x16E2CC0 VA: 0x1816E3AC0 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x16E3B00 Offset: 0x16E2D00 VA: 0x1816E3B00 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x16E3B40 Offset: 0x16E2D40 VA: 0x1816E3B40 Slot: 47
	public override Type GetElementType() { }

	// RVA: 0x16E3B80 Offset: 0x16E2D80 VA: 0x1816E3B80 Slot: 85
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x16E3BC0 Offset: 0x16E2DC0 VA: 0x1816E3BC0 Slot: 86
	public override EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	// RVA: 0x16E3C00 Offset: 0x16E2E00 VA: 0x1816E3C00 Slot: 88
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x16E3C40 Offset: 0x16E2E40 VA: 0x1816E3C40 Slot: 90
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x16E3C80 Offset: 0x16E2E80 VA: 0x1816E3C80 Slot: 120
	public override Type[] GetInterfaces() { }

	// RVA: 0x16E3CC0 Offset: 0x16E2EC0 VA: 0x1816E3CC0 Slot: 94
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x16E3D00 Offset: 0x16E2F00 VA: 0x1816E3D00 Slot: 101
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x16E3D40 Offset: 0x16E2F40 VA: 0x1816E3D40 Slot: 103
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x16E3D80 Offset: 0x16E2F80 VA: 0x1816E3D80 Slot: 104
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x16E3DC0 Offset: 0x16E2FC0 VA: 0x1816E3DC0 Slot: 113
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x16E3E00 Offset: 0x16E3000 VA: 0x1816E3E00 Slot: 111
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x16E3E40 Offset: 0x16E3040 VA: 0x1816E3E40 Slot: 46
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x16E3E80 Offset: 0x16E3080 VA: 0x1816E3E80 Slot: 119
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x16E3EC0 Offset: 0x16E30C0 VA: 0x1816E3EC0 Slot: 33
	protected override bool IsArrayImpl() { }

	// RVA: 0x16E3F00 Offset: 0x16E3100 VA: 0x1816E3F00 Slot: 35
	protected override bool IsByRefImpl() { }

	// RVA: 0x16E3F40 Offset: 0x16E3140 VA: 0x1816E3F40 Slot: 66
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x16E3F80 Offset: 0x16E3180 VA: 0x1816E3F80 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x16E3FC0 Offset: 0x16E31C0 VA: 0x1816E3FC0 Slot: 37
	protected override bool IsPointerImpl() { }

	// RVA: 0x16E4000 Offset: 0x16E3200 VA: 0x1816E4000 Slot: 74
	protected override bool IsPrimitiveImpl() { }
}

// Namespace: System.Reflection.Emit
[Obsolete("An alternate API is available: Emit the MarshalAs custom attribute instead.")]
[ComVisible(True)]
[Serializable]
public sealed class UnmanagedMarshal // TypeDefIndex: 4226
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }
}

// Namespace: System.Numerics
internal class ConstantHelper // TypeDefIndex: 4227
{
	// Methods

	// RVA: 0x16CEF20 Offset: 0x16CE120 VA: 0x1816CEF20
	public static byte GetByteWithAllBitsSet() { }

	// RVA: 0x16CEF20 Offset: 0x16CE120 VA: 0x1816CEF20
	public static sbyte GetSByteWithAllBitsSet() { }

	// RVA: 0x16CEF60 Offset: 0x16CE160 VA: 0x1816CEF60
	public static ushort GetUInt16WithAllBitsSet() { }

	// RVA: 0x729380 Offset: 0x728580 VA: 0x180729380
	public static short GetInt16WithAllBitsSet() { }

	// RVA: 0x729380 Offset: 0x728580 VA: 0x180729380
	public static uint GetUInt32WithAllBitsSet() { }

	// RVA: 0x729380 Offset: 0x728580 VA: 0x180729380
	public static int GetInt32WithAllBitsSet() { }

	// RVA: 0x16CEF40 Offset: 0x16CE140 VA: 0x1816CEF40
	public static ulong GetUInt64WithAllBitsSet() { }

	// RVA: 0x16CEF40 Offset: 0x16CE140 VA: 0x1816CEF40
	public static long GetInt64WithAllBitsSet() { }

	// RVA: 0x16CEF50 Offset: 0x16CE150 VA: 0x1816CEF50
	public static float GetSingleWithAllBitsSet() { }

	// RVA: 0x16CEF30 Offset: 0x16CE130 VA: 0x1816CEF30
	public static double GetDoubleWithAllBitsSet() { }
}

// Namespace: System.Numerics
internal struct Register // TypeDefIndex: 4228
{
	// Fields
	internal byte byte_0; // 0x0
	internal byte byte_1; // 0x1
	internal byte byte_2; // 0x2
	internal byte byte_3; // 0x3
	internal byte byte_4; // 0x4
	internal byte byte_5; // 0x5
	internal byte byte_6; // 0x6
	internal byte byte_7; // 0x7
	internal byte byte_8; // 0x8
	internal byte byte_9; // 0x9
	internal byte byte_10; // 0xA
	internal byte byte_11; // 0xB
	internal byte byte_12; // 0xC
	internal byte byte_13; // 0xD
	internal byte byte_14; // 0xE
	internal byte byte_15; // 0xF
	internal sbyte sbyte_0; // 0x0
	internal sbyte sbyte_1; // 0x1
	internal sbyte sbyte_2; // 0x2
	internal sbyte sbyte_3; // 0x3
	internal sbyte sbyte_4; // 0x4
	internal sbyte sbyte_5; // 0x5
	internal sbyte sbyte_6; // 0x6
	internal sbyte sbyte_7; // 0x7
	internal sbyte sbyte_8; // 0x8
	internal sbyte sbyte_9; // 0x9
	internal sbyte sbyte_10; // 0xA
	internal sbyte sbyte_11; // 0xB
	internal sbyte sbyte_12; // 0xC
	internal sbyte sbyte_13; // 0xD
	internal sbyte sbyte_14; // 0xE
	internal sbyte sbyte_15; // 0xF
	internal ushort uint16_0; // 0x0
	internal ushort uint16_1; // 0x2
	internal ushort uint16_2; // 0x4
	internal ushort uint16_3; // 0x6
	internal ushort uint16_4; // 0x8
	internal ushort uint16_5; // 0xA
	internal ushort uint16_6; // 0xC
	internal ushort uint16_7; // 0xE
	internal short int16_0; // 0x0
	internal short int16_1; // 0x2
	internal short int16_2; // 0x4
	internal short int16_3; // 0x6
	internal short int16_4; // 0x8
	internal short int16_5; // 0xA
	internal short int16_6; // 0xC
	internal short int16_7; // 0xE
	internal uint uint32_0; // 0x0
	internal uint uint32_1; // 0x4
	internal uint uint32_2; // 0x8
	internal uint uint32_3; // 0xC
	internal int int32_0; // 0x0
	internal int int32_1; // 0x4
	internal int int32_2; // 0x8
	internal int int32_3; // 0xC
	internal ulong uint64_0; // 0x0
	internal ulong uint64_1; // 0x8
	internal long int64_0; // 0x0
	internal long int64_1; // 0x8
	internal float single_0; // 0x0
	internal float single_1; // 0x4
	internal float single_2; // 0x8
	internal float single_3; // 0xC
	internal double double_0; // 0x0
	internal double double_1; // 0x8
}

// Namespace: 
private struct Vector.VectorSizeHelper<T> // TypeDefIndex: 4229
{
	// Fields
	internal Vector<T> _placeholder; // 0x0
	internal byte _byte; // 0x0
}

// Namespace: System.Numerics
[DefaultMember("Item")]
[Intrinsic]
public struct Vector<T> : IEquatable<Vector<T>>, IFormattable // TypeDefIndex: 4230
{
	// Fields
	private Register register; // 0x0
	private static readonly int s_count; // 0x0
	private static readonly Vector<T> s_zero; // 0x0
	private static readonly Vector<T> s_one; // 0x0
	private static readonly Vector<T> s_allOnes; // 0x0

	// Properties
	public static int Count { get; }
	public static Vector<T> Zero { get; }
	public T Item { get; }

	// Methods

	[Intrinsic]
	// RVA: -1 Offset: -1
	public static int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDBFF50 Offset: 0xDBF150 VA: 0x180DBFF50
	|-Vector<ushort>.get_Count
	|-Vector<ulong>.get_Count
	|-Vector<__Il2CppFullySharedGenericStructType>.get_Count
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	public static Vector<T> get_Zero() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC16D0 Offset: 0xDC08D0 VA: 0x180DC16D0
	|-Vector<ushort>.get_Zero
	|-Vector<ulong>.get_Zero
	|-Vector<__Il2CppFullySharedGenericStructType>.get_Zero
	*/

	// RVA: -1 Offset: -1
	private static int InitializeCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDD1DC0 Offset: 0xDD0FC0 VA: 0x180DD1DC0
	|-Vector<ushort>.InitializeCount
	|
	|-RVA: 0xE160D0 Offset: 0xE152D0 VA: 0x180E160D0
	|-Vector<ulong>.InitializeCount
	|
	|-RVA: 0xE2DBD0 Offset: 0xE2CDD0 VA: 0x180E2DBD0
	|-Vector<__Il2CppFullySharedGenericStructType>.InitializeCount
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	public void .ctor(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDD9D60 Offset: 0xDD8F60 VA: 0x180DD9D60
	|-Vector<ushort>..ctor
	|
	|-RVA: 0xE1D4B0 Offset: 0xE1C6B0 VA: 0x180E1D4B0
	|-Vector<ulong>..ctor
	|
	|-RVA: 0xE2F970 Offset: 0xE2EB70 VA: 0x180E2F970
	|-Vector<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(void* dataPointer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDD83F0 Offset: 0xDD75F0 VA: 0x180DD83F0
	|-Vector<ushort>..ctor
	|
	|-RVA: 0xE21A80 Offset: 0xE20C80 VA: 0x180E21A80
	|-Vector<ulong>..ctor
	|
	|-RVA: 0xE24EC0 Offset: 0xE240C0 VA: 0x180E24EC0
	|-Vector<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(void* dataPointer, int offset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDD8490 Offset: 0xDD7690 VA: 0x180DD8490
	|-Vector<ushort>..ctor
	|
	|-RVA: 0xE20E70 Offset: 0xE20070 VA: 0x180E20E70
	|-Vector<ulong>..ctor
	|
	|-RVA: 0xE32D10 Offset: 0xE31F10 VA: 0x180E32D10
	|-Vector<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(ref Register existingRegister) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4354B0 Offset: 0x4346B0 VA: 0x1804354B0
	|-Vector<ushort>..ctor
	|-Vector<ulong>..ctor
	|-Vector<__Il2CppFullySharedGenericStructType>..ctor
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDDF940 Offset: 0xDDEB40 VA: 0x180DDF940
	|-Vector<ushort>.get_Item
	|
	|-RVA: 0xE24F90 Offset: 0xE24190 VA: 0x180E24F90
	|-Vector<ulong>.get_Item
	|
	|-RVA: 0xE33910 Offset: 0xE32B10 VA: 0x180E33910
	|-Vector<__Il2CppFullySharedGenericStructType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC2030 Offset: 0xDC1230 VA: 0x180DC2030
	|-Vector<ushort>.Equals
	|
	|-RVA: 0xE06B50 Offset: 0xE05D50 VA: 0x180E06B50
	|-Vector<ulong>.Equals
	|
	|-RVA: 0xE069C0 Offset: 0xE05BC0 VA: 0x180E069C0
	|-Vector<__Il2CppFullySharedGenericStructType>.Equals
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(Vector<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC7C60 Offset: 0xDC6E60 VA: 0x180DC7C60
	|-Vector<ushort>.Equals
	|
	|-RVA: 0xE0DE40 Offset: 0xE0D040 VA: 0x180E0DE40
	|-Vector<ulong>.Equals
	|
	|-RVA: 0xE29850 Offset: 0xE28A50 VA: 0x180E29850
	|-Vector<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCC530 Offset: 0xDCB730 VA: 0x180DCC530
	|-Vector<ushort>.GetHashCode
	|
	|-RVA: 0xE129F0 Offset: 0xE11BF0 VA: 0x180E129F0
	|-Vector<ulong>.GetHashCode
	|
	|-RVA: 0xE2AC70 Offset: 0xE29E70 VA: 0x180E2AC70
	|-Vector<__Il2CppFullySharedGenericStructType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDD7630 Offset: 0xDD6830 VA: 0x180DD7630
	|-Vector<ushort>.ToString
	|
	|-RVA: 0xE1C3F0 Offset: 0xE1B5F0 VA: 0x180E1C3F0
	|-Vector<ulong>.ToString
	|
	|-RVA: 0xE2EFA0 Offset: 0xE2E1A0 VA: 0x180E2EFA0
	|-Vector<__Il2CppFullySharedGenericStructType>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDD7B10 Offset: 0xDD6D10 VA: 0x180DD7B10
	|-Vector<ushort>.ToString
	|
	|-RVA: 0xE1C4D0 Offset: 0xE1B6D0 VA: 0x180E1C4D0
	|-Vector<ulong>.ToString
	|
	|-RVA: 0xE2F0B0 Offset: 0xE2E2B0 VA: 0x180E2F0B0
	|-Vector<__Il2CppFullySharedGenericStructType>.ToString
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDE1200 Offset: 0xDE0400 VA: 0x180DE1200
	|-Vector<ushort>.op_Equality
	|
	|-RVA: 0xE268E0 Offset: 0xE25AE0 VA: 0x180E268E0
	|-Vector<ulong>.op_Equality
	|
	|-RVA: 0xE26810 Offset: 0xE25A10 VA: 0x180E26810
	|-Vector<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDE14D0 Offset: 0xDE06D0 VA: 0x180DE14D0
	|-Vector<ushort>.op_Inequality
	|
	|-RVA: 0xE26A80 Offset: 0xE25C80 VA: 0x180E26A80
	|-Vector<ulong>.op_Inequality
	|
	|-RVA: 0xE26B90 Offset: 0xE25D90 VA: 0x180E26B90
	|-Vector<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	[CLSCompliant(False)]
	[Intrinsic]
	// RVA: -1 Offset: -1
	public static Vector<ulong> op_Explicit(Vector<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDE12A0 Offset: 0xDE04A0 VA: 0x180DE12A0
	|-Vector<ushort>.op_Explicit
	|
	|-RVA: 0xE26A40 Offset: 0xE25C40 VA: 0x180E26A40
	|-Vector<ulong>.op_Explicit
	|
	|-RVA: 0xE344C0 Offset: 0xE336C0 VA: 0x180E344C0
	|-Vector<__Il2CppFullySharedGenericStructType>.op_Explicit
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	internal static Vector<T> Equals(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC5910 Offset: 0xDC4B10 VA: 0x180DC5910
	|-Vector<ushort>.Equals
	|
	|-RVA: 0xE08F00 Offset: 0xE08100 VA: 0x180E08F00
	|-Vector<ulong>.Equals
	|
	|-RVA: 0xE26C70 Offset: 0xE25E70 VA: 0x180E26C70
	|-Vector<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	private static bool ScalarEquals(T left, T right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDD4D10 Offset: 0xDD3F10 VA: 0x180DD4D10
	|-Vector<ushort>.ScalarEquals
	|
	|-RVA: 0xE1A790 Offset: 0xE19990 VA: 0x180E1A790
	|-Vector<ulong>.ScalarEquals
	|
	|-RVA: 0xE2E0F0 Offset: 0xE2D2F0 VA: 0x180E2E0F0
	|-Vector<__Il2CppFullySharedGenericStructType>.ScalarEquals
	*/

	// RVA: -1 Offset: -1
	private static T GetOneValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDD08F0 Offset: 0xDCFAF0 VA: 0x180DD08F0
	|-Vector<ushort>.GetOneValue
	|
	|-RVA: 0xE15670 Offset: 0xE14870 VA: 0x180E15670
	|-Vector<ulong>.GetOneValue
	|
	|-RVA: 0xE2D130 Offset: 0xE2C330 VA: 0x180E2D130
	|-Vector<__Il2CppFullySharedGenericStructType>.GetOneValue
	*/

	// RVA: -1 Offset: -1
	private static T GetAllBitsSetValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDCB050 Offset: 0xDCA250 VA: 0x180DCB050
	|-Vector<ushort>.GetAllBitsSetValue
	|
	|-RVA: 0xE0EFF0 Offset: 0xE0E1F0 VA: 0x180E0EFF0
	|-Vector<ulong>.GetAllBitsSetValue
	|
	|-RVA: 0xE2A1C0 Offset: 0xE293C0 VA: 0x180E2A1C0
	|-Vector<__Il2CppFullySharedGenericStructType>.GetAllBitsSetValue
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDD7FF0 Offset: 0xDD71F0 VA: 0x180DD7FF0
	|-Vector<ushort>..cctor
	|
	|-RVA: 0xE1CF30 Offset: 0xE1C130 VA: 0x180E1CF30
	|-Vector<ulong>..cctor
	|
	|-RVA: 0xE2F600 Offset: 0xE2E800 VA: 0x180E2F600
	|-Vector<__Il2CppFullySharedGenericStructType>..cctor
	*/
}

// Namespace: System.Numerics
[Intrinsic]
public static class Vector // TypeDefIndex: 4231
{
	// Properties
	public static bool IsHardwareAccelerated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static Vector<T> Equals<T>(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA2C50 Offset: 0xAA1E50 VA: 0x180AA2C50
	|-Vector.Equals<ushort>
	|
	|-RVA: 0xAA2AF0 Offset: 0xAA1CF0 VA: 0x180AA2AF0
	|-Vector.Equals<__Il2CppFullySharedGenericStructType>
	*/

	[Intrinsic]
	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	public static bool get_IsHardwareAccelerated() { }

	[CLSCompliant(False)]
	// RVA: -1 Offset: -1
	public static Vector<ulong> AsVectorUInt64<T>(Vector<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA2920 Offset: 0xAA1B20 VA: 0x180AA2920
	|-Vector.AsVectorUInt64<ushort>
	|
	|-RVA: 0xAA2770 Offset: 0xAA1970 VA: 0x180AA2770
	|-Vector.AsVectorUInt64<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: System.Numerics.Hashing
internal static class HashHelpers // TypeDefIndex: 4232
{
	// Fields
	public static readonly int RandomSeed; // 0x0

	// Methods

	// RVA: 0x16DB5B0 Offset: 0x16DA7B0 VA: 0x1816DB5B0
	public static int Combine(int h1, int h2) { }

	// RVA: 0x16DB5D0 Offset: 0x16DA7D0 VA: 0x1816DB5D0
	private static void .cctor() { }
}

// Namespace: System.Globalization
internal enum BidiCategory // TypeDefIndex: 4233
{
	// Fields
	public int value__; // 0x0
	public const BidiCategory LeftToRight = 0;
	public const BidiCategory LeftToRightEmbedding = 1;
	public const BidiCategory LeftToRightOverride = 2;
	public const BidiCategory RightToLeft = 3;
	public const BidiCategory RightToLeftArabic = 4;
	public const BidiCategory RightToLeftEmbedding = 5;
	public const BidiCategory RightToLeftOverride = 6;
	public const BidiCategory PopDirectionalFormat = 7;
	public const BidiCategory EuropeanNumber = 8;
	public const BidiCategory EuropeanNumberSeparator = 9;
	public const BidiCategory EuropeanNumberTerminator = 10;
	public const BidiCategory ArabicNumber = 11;
	public const BidiCategory CommonNumberSeparator = 12;
	public const BidiCategory NonSpacingMark = 13;
	public const BidiCategory BoundaryNeutral = 14;
	public const BidiCategory ParagraphSeparator = 15;
	public const BidiCategory SegmentSeparator = 16;
	public const BidiCategory Whitespace = 17;
	public const BidiCategory OtherNeutrals = 18;
	public const BidiCategory LeftToRightIsolate = 19;
	public const BidiCategory RightToLeftIsolate = 20;
	public const BidiCategory FirstStrongIsolate = 21;
	public const BidiCategory PopDirectionIsolate = 22;
}

// Namespace: System.Globalization
public enum CalendarAlgorithmType // TypeDefIndex: 4234
{
	// Fields
	public int value__; // 0x0
	public const CalendarAlgorithmType Unknown = 0;
	public const CalendarAlgorithmType SolarCalendar = 1;
	public const CalendarAlgorithmType LunarCalendar = 2;
	public const CalendarAlgorithmType LunisolarCalendar = 3;
}

// Namespace: System.Globalization
public enum CalendarWeekRule // TypeDefIndex: 4235
{
	// Fields
	public int value__; // 0x0
	public const CalendarWeekRule FirstDay = 0;
	public const CalendarWeekRule FirstFullWeek = 1;
	public const CalendarWeekRule FirstFourDayWeek = 2;
}

// Namespace: System.Globalization
public static class CharUnicodeInfo // TypeDefIndex: 4236
{
	// Fields
	internal const char HIGH_SURROGATE_START = '\xd800';
	internal const char HIGH_SURROGATE_END = '\xdbff';
	internal const char LOW_SURROGATE_START = '\xdc00';
	internal const char LOW_SURROGATE_END = '\xdfff';
	internal const int HIGH_SURROGATE_RANGE = 1023;
	internal const int UNICODE_CATEGORY_OFFSET = 0;
	internal const int BIDI_CATEGORY_OFFSET = 1;
	internal const int UNICODE_PLANE01_START = 65536;

	// Properties
	private static ReadOnlySpan<byte> CategoryLevel1Index { get; }
	private static ReadOnlySpan<byte> CategoryLevel2Index { get; }
	private static ReadOnlySpan<byte> CategoryLevel3Index { get; }
	private static ReadOnlySpan<byte> CategoriesValue { get; }
	private static ReadOnlySpan<byte> NumericLevel1Index { get; }
	private static ReadOnlySpan<byte> NumericLevel2Index { get; }
	private static ReadOnlySpan<byte> NumericLevel3Index { get; }
	private static ReadOnlySpan<byte> NumericValues { get; }
	private static ReadOnlySpan<byte> DigitValues { get; }

	// Methods

	// RVA: 0x16C71C0 Offset: 0x16C63C0 VA: 0x1816C71C0
	internal static int InternalConvertToUtf32(string s, int index) { }

	// RVA: 0x16C7300 Offset: 0x16C6500 VA: 0x1816C7300
	internal static int InternalConvertToUtf32(StringBuilder s, int index) { }

	// RVA: 0x16C7260 Offset: 0x16C6460 VA: 0x1816C7260
	internal static int InternalConvertToUtf32(string s, int index, out int charLength) { }

	// RVA: 0x16C76A0 Offset: 0x16C68A0 VA: 0x1816C76A0
	internal static double InternalGetNumericValue(int ch) { }

	// RVA: 0x16C7500 Offset: 0x16C6700 VA: 0x1816C7500
	internal static byte InternalGetDigitValues(int ch, int offset) { }

	// RVA: 0x16C7040 Offset: 0x16C6240 VA: 0x1816C7040
	public static double GetNumericValue(char ch) { }

	// RVA: 0x16C6EF0 Offset: 0x16C60F0 VA: 0x1816C6EF0
	public static double GetNumericValue(string s, int index) { }

	// RVA: 0x16C6D60 Offset: 0x16C5F60 VA: 0x1816C6D60
	public static int GetDecimalDigitValue(char ch) { }

	// RVA: 0x16C6C10 Offset: 0x16C5E10 VA: 0x1816C6C10
	public static int GetDecimalDigitValue(string s, int index) { }

	// RVA: 0x16C6ED0 Offset: 0x16C60D0 VA: 0x1816C6ED0
	public static int GetDigitValue(char ch) { }

	// RVA: 0x16C6D80 Offset: 0x16C5F80 VA: 0x1816C6D80
	public static int GetDigitValue(string s, int index) { }

	// RVA: 0x16C71A0 Offset: 0x16C63A0 VA: 0x1816C71A0
	public static UnicodeCategory GetUnicodeCategory(char ch) { }

	// RVA: 0x16C7070 Offset: 0x16C6270 VA: 0x1816C7070
	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	// RVA: 0x16C7050 Offset: 0x16C6250 VA: 0x1816C7050
	public static UnicodeCategory GetUnicodeCategory(int codePoint) { }

	// RVA: 0x16C7390 Offset: 0x16C6590 VA: 0x1816C7390
	internal static byte InternalGetCategoryValue(int ch, int offset) { }

	// RVA: 0x16C7850 Offset: 0x16C6A50 VA: 0x1816C7850
	internal static UnicodeCategory InternalGetUnicodeCategory(string value, int index) { }

	// RVA: 0x16C6A30 Offset: 0x16C5C30 VA: 0x1816C6A30
	internal static BidiCategory GetBidiCategory(string s, int index) { }

	// RVA: 0x16C6B70 Offset: 0x16C5D70 VA: 0x1816C6B70
	internal static BidiCategory GetBidiCategory(StringBuilder s, int index) { }

	// RVA: 0x16C78F0 Offset: 0x16C6AF0 VA: 0x1816C78F0
	internal static UnicodeCategory InternalGetUnicodeCategory(string str, int index, out int charLength) { }

	// RVA: 0x16C79B0 Offset: 0x16C6BB0 VA: 0x1816C79B0
	internal static bool IsCombiningCategory(UnicodeCategory uc) { }

	// RVA: 0x16C7A00 Offset: 0x16C6C00 VA: 0x1816C7A00
	internal static bool IsWhiteSpace(string s, int index) { }

	// RVA: 0x16C79D0 Offset: 0x16C6BD0 VA: 0x1816C79D0
	internal static bool IsWhiteSpace(char c) { }

	// RVA: 0x16C7B90 Offset: 0x16C6D90 VA: 0x1816C7B90
	private static ReadOnlySpan<byte> get_CategoryLevel1Index() { }

	// RVA: 0x16C7BE0 Offset: 0x16C6DE0 VA: 0x1816C7BE0
	private static ReadOnlySpan<byte> get_CategoryLevel2Index() { }

	// RVA: 0x16C7C30 Offset: 0x16C6E30 VA: 0x1816C7C30
	private static ReadOnlySpan<byte> get_CategoryLevel3Index() { }

	// RVA: 0x16C7B40 Offset: 0x16C6D40 VA: 0x1816C7B40
	private static ReadOnlySpan<byte> get_CategoriesValue() { }

	// RVA: 0x16C7CD0 Offset: 0x16C6ED0 VA: 0x1816C7CD0
	private static ReadOnlySpan<byte> get_NumericLevel1Index() { }

	// RVA: 0x16C7D20 Offset: 0x16C6F20 VA: 0x1816C7D20
	private static ReadOnlySpan<byte> get_NumericLevel2Index() { }

	// RVA: 0x16C7D70 Offset: 0x16C6F70 VA: 0x1816C7D70
	private static ReadOnlySpan<byte> get_NumericLevel3Index() { }

	// RVA: 0x16C7DC0 Offset: 0x16C6FC0 VA: 0x1816C7DC0
	private static ReadOnlySpan<byte> get_NumericValues() { }

	// RVA: 0x16C7C80 Offset: 0x16C6E80 VA: 0x1816C7C80
	private static ReadOnlySpan<byte> get_DigitValues() { }
}

// Namespace: System.Globalization
[Serializable]
public class CompareInfo : IDeserializationCallback // TypeDefIndex: 4237
{
	// Fields
	private const CompareOptions ValidIndexMaskOffFlags = -32;
	private const CompareOptions ValidCompareMaskOffFlags = -536870944;
	private const CompareOptions ValidHashCodeOfStringMaskOffFlags = -32;
	private const CompareOptions ValidSortkeyCtorMaskOffFlags = -536870944;
	internal static readonly CompareInfo Invariant; // 0x0
	[OptionalField(VersionAdded = 2)]
	private string m_name; // 0x10
	private string _sortName; // 0x18
	[OptionalField(VersionAdded = 3)]
	private SortVersion m_SortVersion; // 0x20
	private int culture; // 0x28
	private ISimpleCollator collator; // 0x30
	private static Dictionary<string, ISimpleCollator> collators; // 0x8
	private static bool managedCollation; // 0x10
	private static bool managedCollationChecked; // 0x11

	// Properties
	public virtual string Name { get; }
	public SortVersion Version { get; }
	public int LCID { get; }
	private static bool UseManagedCollation { get; }

	// Methods

	// RVA: 0x16CC800 Offset: 0x16CBA00 VA: 0x1816CC800
	internal static int InvariantIndexOf(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x16CC710 Offset: 0x16CB910 VA: 0x1816CC710
	internal static int InvariantIndexOf(ReadOnlySpan<char> source, ReadOnlySpan<char> value, bool ignoreCase) { }

	// RVA: 0x16CC8E0 Offset: 0x16CBAE0 VA: 0x1816CC8E0
	internal static int InvariantLastIndexOf(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x16CC330 Offset: 0x16CB530 VA: 0x1816CC330
	private static int InvariantFindString(char* source, int sourceCount, char* value, int valueCount, bool ignoreCase, bool start) { }

	// RVA: 0x16CC9D0 Offset: 0x16CBBD0 VA: 0x1816CC9D0
	private static char InvariantToUpper(char c) { }

	// RVA: 0x16CC070 Offset: 0x16CB270 VA: 0x1816CC070
	private SortKey InvariantCreateSortKey(string source, CompareOptions options) { }

	// RVA: 0x16CE250 Offset: 0x16CD450 VA: 0x1816CE250
	internal void .ctor(CultureInfo culture) { }

	// RVA: 0x16CA260 Offset: 0x16C9460 VA: 0x1816CA260
	public static CompareInfo GetCompareInfo(int culture, Assembly assembly) { }

	// RVA: 0x16CA050 Offset: 0x16C9250 VA: 0x1816CA050
	public static CompareInfo GetCompareInfo(string name, Assembly assembly) { }

	// RVA: 0x16CA4C0 Offset: 0x16C96C0 VA: 0x1816CA4C0
	public static CompareInfo GetCompareInfo(int culture) { }

	// RVA: 0x16C9F90 Offset: 0x16C9190 VA: 0x1816C9F90
	public static CompareInfo GetCompareInfo(string name) { }

	// RVA: 0x16CCDB0 Offset: 0x16CBFB0 VA: 0x1816CCDB0
	public static bool IsSortable(char ch) { }

	// RVA: 0x16CCC70 Offset: 0x16CBE70 VA: 0x1816CCC70
	public static bool IsSortable(string text) { }

	[OnDeserializing]
	// RVA: 0x832C50 Offset: 0x831E50 VA: 0x180832C50
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x16CDF70 Offset: 0x16CD170 VA: 0x1816CDF70 Slot: 4
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[OnDeserialized]
	// RVA: 0x16CDF70 Offset: 0x16CD170 VA: 0x1816CDF70
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x16CDEC0 Offset: 0x16CD0C0 VA: 0x1816CDEC0
	private void OnDeserialized() { }

	[OnSerializing]
	// RVA: 0x16CDF80 Offset: 0x16CD180 VA: 0x1816CDF80
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x16CE320 Offset: 0x16CD520 VA: 0x1816CE320 Slot: 5
	public virtual string get_Name() { }

	// RVA: 0x16C91A0 Offset: 0x16C83A0 VA: 0x1816C91A0 Slot: 6
	public virtual int Compare(string string1, string string2) { }

	// RVA: 0x16C8940 Offset: 0x16C7B40 VA: 0x1816C8940 Slot: 7
	public virtual int Compare(string string1, string string2, CompareOptions options) { }

	// RVA: 0x16C9260 Offset: 0x16C8460 VA: 0x1816C9260
	internal int Compare(ReadOnlySpan<char> string1, string string2, CompareOptions options) { }

	// RVA: 0x16C7F70 Offset: 0x16C7170 VA: 0x1816C7F70
	internal int CompareOptionNone(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2) { }

	// RVA: 0x16C7E10 Offset: 0x16C7010 VA: 0x1816C7E10
	internal int CompareOptionIgnoreCase(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2) { }

	// RVA: 0x16C9150 Offset: 0x16C8350 VA: 0x1816C9150 Slot: 8
	public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2) { }

	// RVA: 0x16C91D0 Offset: 0x16C83D0 VA: 0x1816C91D0 Slot: 9
	public virtual int Compare(string string1, int offset1, string string2, int offset2, CompareOptions options) { }

	// RVA: 0x16C8900 Offset: 0x16C7B00 VA: 0x1816C8900 Slot: 10
	public virtual int Compare(string string1, int offset1, string string2, int offset2) { }

	// RVA: 0x16C8BE0 Offset: 0x16C7DE0 VA: 0x1816C8BE0 Slot: 11
	public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x16C8430 Offset: 0x16C7630 VA: 0x1816C8430
	internal static int CompareOrdinalIgnoreCase(string strA, int indexA, int lengthA, string strB, int indexB, int lengthB) { }

	// RVA: 0x16C8100 Offset: 0x16C7300 VA: 0x1816C8100
	internal static int CompareOrdinalIgnoreCase(ReadOnlySpan<char> strA, ReadOnlySpan<char> strB) { }

	// RVA: 0x16CCAA0 Offset: 0x16CBCA0 VA: 0x1816CCAA0 Slot: 12
	public virtual bool IsPrefix(string source, string prefix, CompareOptions options) { }

	// RVA: 0x16CC9F0 Offset: 0x16CBBF0 VA: 0x1816CC9F0
	internal bool IsPrefix(ReadOnlySpan<char> source, ReadOnlySpan<char> prefix, CompareOptions options) { }

	// RVA: 0x16CCA70 Offset: 0x16CBC70 VA: 0x1816CCA70 Slot: 13
	public virtual bool IsPrefix(string source, string prefix) { }

	// RVA: 0x16CCF40 Offset: 0x16CC140 VA: 0x1816CCF40 Slot: 14
	public virtual bool IsSuffix(string source, string suffix, CompareOptions options) { }

	// RVA: 0x16C9B40 Offset: 0x16C8D40 VA: 0x1816C9B40
	internal bool IsSuffix(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options) { }

	// RVA: 0x16CD110 Offset: 0x16CC310 VA: 0x1816CD110 Slot: 15
	public virtual bool IsSuffix(string source, string suffix) { }

	// RVA: 0x16CB680 Offset: 0x16CA880 VA: 0x1816CB680 Slot: 16
	public virtual int IndexOf(string source, char value) { }

	// RVA: 0x16CB560 Offset: 0x16CA760 VA: 0x1816CB560 Slot: 17
	public virtual int IndexOf(string source, string value) { }

	// RVA: 0x16CBFC0 Offset: 0x16CB1C0 VA: 0x1816CBFC0 Slot: 18
	public virtual int IndexOf(string source, char value, CompareOptions options) { }

	// RVA: 0x16CB5F0 Offset: 0x16CA7F0 VA: 0x1816CB5F0 Slot: 19
	public virtual int IndexOf(string source, string value, CompareOptions options) { }

	// RVA: 0x16CBEB0 Offset: 0x16CB0B0 VA: 0x1816CBEB0 Slot: 20
	public virtual int IndexOf(string source, char value, int startIndex) { }

	// RVA: 0x16CBE20 Offset: 0x16CB020 VA: 0x1816CBE20 Slot: 21
	public virtual int IndexOf(string source, string value, int startIndex) { }

	// RVA: 0x16CB430 Offset: 0x16CA630 VA: 0x1816CB430 Slot: 22
	public virtual int IndexOf(string source, char value, int startIndex, CompareOptions options) { }

	// RVA: 0x16CBD90 Offset: 0x16CAF90 VA: 0x1816CBD90 Slot: 23
	public virtual int IndexOf(string source, string value, int startIndex, CompareOptions options) { }

	// RVA: 0x16CBF80 Offset: 0x16CB180 VA: 0x1816CBF80 Slot: 24
	public virtual int IndexOf(string source, char value, int startIndex, int count) { }

	// RVA: 0x16CBF40 Offset: 0x16CB140 VA: 0x1816CBF40 Slot: 25
	public virtual int IndexOf(string source, string value, int startIndex, int count) { }

	// RVA: 0x16CB710 Offset: 0x16CA910 VA: 0x1816CB710 Slot: 26
	public virtual int IndexOf(string source, char value, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x16CBA20 Offset: 0x16CAC20 VA: 0x1816CBA20 Slot: 27
	public virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x16CB070 Offset: 0x16CA270 VA: 0x1816CB070
	internal int IndexOfOrdinal(ReadOnlySpan<char> source, ReadOnlySpan<char> value, bool ignoreCase) { }

	// RVA: 0x16CB4C0 Offset: 0x16CA6C0 VA: 0x1816CB4C0
	internal int IndexOf(ReadOnlySpan<char> source, ReadOnlySpan<char> value, CompareOptions options) { }

	// RVA: 0x16CB2D0 Offset: 0x16CA4D0 VA: 0x1816CB2D0
	internal int IndexOf(string source, string value, int startIndex, int count, CompareOptions options, int* matchLengthPtr) { }

	// RVA: 0x16CB110 Offset: 0x16CA310 VA: 0x1816CB110
	internal int IndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x16CD300 Offset: 0x16CC500 VA: 0x1816CD300 Slot: 28
	public virtual int LastIndexOf(string source, char value) { }

	// RVA: 0x16CD9D0 Offset: 0x16CCBD0 VA: 0x1816CD9D0 Slot: 29
	public virtual int LastIndexOf(string source, string value) { }

	// RVA: 0x16CD8B0 Offset: 0x16CCAB0 VA: 0x1816CD8B0 Slot: 30
	public virtual int LastIndexOf(string source, char value, CompareOptions options) { }

	// RVA: 0x16CD940 Offset: 0x16CCB40 VA: 0x1816CD940 Slot: 31
	public virtual int LastIndexOf(string source, string value, CompareOptions options) { }

	// RVA: 0x16CD870 Offset: 0x16CCA70 VA: 0x1816CD870 Slot: 32
	public virtual int LastIndexOf(string source, char value, int startIndex) { }

	// RVA: 0x16CDA60 Offset: 0x16CCC60 VA: 0x1816CDA60 Slot: 33
	public virtual int LastIndexOf(string source, string value, int startIndex) { }

	// RVA: 0x16CDAE0 Offset: 0x16CCCE0 VA: 0x1816CDAE0 Slot: 34
	public virtual int LastIndexOf(string source, char value, int startIndex, CompareOptions options) { }

	// RVA: 0x16CD390 Offset: 0x16CC590 VA: 0x1816CD390 Slot: 35
	public virtual int LastIndexOf(string source, string value, int startIndex, CompareOptions options) { }

	// RVA: 0x16CDE80 Offset: 0x16CD080 VA: 0x1816CDE80 Slot: 36
	public virtual int LastIndexOf(string source, char value, int startIndex, int count) { }

	// RVA: 0x16CDAA0 Offset: 0x16CCCA0 VA: 0x1816CDAA0 Slot: 37
	public virtual int LastIndexOf(string source, string value, int startIndex, int count) { }

	// RVA: 0x16CDB20 Offset: 0x16CCD20 VA: 0x1816CDB20 Slot: 38
	public virtual int LastIndexOf(string source, char value, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x16CD3D0 Offset: 0x16CC5D0 VA: 0x1816CD3D0 Slot: 39
	public virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x16CD1C0 Offset: 0x16CC3C0 VA: 0x1816CD1C0
	internal int LastIndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x16CAD10 Offset: 0x16C9F10 VA: 0x1816CAD10 Slot: 40
	public virtual SortKey GetSortKey(string source, CompareOptions options) { }

	// RVA: 0x16CADE0 Offset: 0x16C9FE0 VA: 0x1816CADE0 Slot: 41
	public virtual SortKey GetSortKey(string source) { }

	// RVA: 0x16C9BC0 Offset: 0x16C8DC0 VA: 0x1816C9BC0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x16CA8F0 Offset: 0x16C9AF0 VA: 0x1816CA8F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x16CA930 Offset: 0x16C9B30 VA: 0x1816CA930
	internal static int GetIgnoreCaseHash(string source) { }

	// RVA: 0x16CA5E0 Offset: 0x16C97E0 VA: 0x1816CA5E0
	internal int GetHashCodeOfString(string source, CompareOptions options) { }

	// RVA: 0x16CA7E0 Offset: 0x16C99E0 VA: 0x1816CA7E0 Slot: 42
	public virtual int GetHashCode(string source, CompareOptions options) { }

	// RVA: 0x16CE140 Offset: 0x16CD340 VA: 0x1816CE140 Slot: 3
	public override string ToString() { }

	// RVA: 0x16CE520 Offset: 0x16CD720 VA: 0x1816CE520
	public SortVersion get_Version() { }

	// RVA: 0x16CE290 Offset: 0x16CD490 VA: 0x1816CE290
	public int get_LCID() { }

	// RVA: 0x16CE3A0 Offset: 0x16CD5A0 VA: 0x1816CE3A0
	private static bool get_UseManagedCollation() { }

	// RVA: 0x16C9CA0 Offset: 0x16C8EA0 VA: 0x1816C9CA0
	private ISimpleCollator GetCollator() { }

	// RVA: 0x16C96C0 Offset: 0x16C88C0 VA: 0x1816C96C0
	private SortKey CreateSortKeyCore(string source, CompareOptions options) { }

	// RVA: 0x16CED20 Offset: 0x16CDF20 VA: 0x1816CED20
	private int internal_index_switch(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	// RVA: 0x16CE8E0 Offset: 0x16CDAE0 VA: 0x1816CE8E0
	private int internal_compare_switch(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x16CE7F0 Offset: 0x16CD9F0 VA: 0x1816CE7F0
	private int internal_compare_managed(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x16CEBB0 Offset: 0x16CDDB0 VA: 0x1816CEBB0
	private int internal_index_managed(string s, int sindex, int count, char c, CompareOptions opt, bool first) { }

	// RVA: 0x16CEC70 Offset: 0x16CDE70 VA: 0x1816CEC70
	private int internal_index_managed(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	// RVA: 0x16CE730 Offset: 0x16CD930 VA: 0x1816CE730
	private static int internal_compare_icall(char* str1, int length1, char* str2, int length2, CompareOptions options) { }

	// RVA: 0x16CE740 Offset: 0x16CD940 VA: 0x1816CE740
	private static int internal_compare(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x16CEAE0 Offset: 0x16CDCE0 VA: 0x1816CEAE0
	private static int internal_index_icall(char* source, int sindex, int count, char* value, int value_length, bool first) { }

	// RVA: 0x16CEAF0 Offset: 0x16CDCF0 VA: 0x1816CEAF0
	private static int internal_index(string source, int sindex, int count, string value, bool first) { }

	// RVA: 0x16CC050 Offset: 0x16CB250 VA: 0x1816CC050
	private void InitSort(CultureInfo culture) { }

	// RVA: 0x16C85E0 Offset: 0x16C77E0 VA: 0x1816C85E0
	private static int CompareStringOrdinalIgnoreCase(char* pString1, int length1, char* pString2, int length2) { }

	// RVA: 0x16CB030 Offset: 0x16CA230 VA: 0x1816CB030
	internal static int IndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x16CD180 Offset: 0x16CC380 VA: 0x1816CD180
	internal static int LastIndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x16CD140 Offset: 0x16CC340 VA: 0x1816CD140
	private int LastIndexOfCore(string source, string target, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x16CAED0 Offset: 0x16CA0D0 VA: 0x1816CAED0
	private int IndexOfCore(string source, string target, int startIndex, int count, CompareOptions options, int* matchLengthPtr) { }

	// RVA: 0x16CAF50 Offset: 0x16CA150 VA: 0x1816CAF50
	private int IndexOfCore(ReadOnlySpan<char> source, ReadOnlySpan<char> target, CompareOptions options, int* matchLengthPtr) { }

	// RVA: 0x16CB070 Offset: 0x16CA270 VA: 0x1816CB070
	private int IndexOfOrdinalCore(ReadOnlySpan<char> source, ReadOnlySpan<char> value, bool ignoreCase) { }

	// RVA: 0x16C8880 Offset: 0x16C7A80 VA: 0x1816C8880
	private int CompareString(ReadOnlySpan<char> string1, string string2, CompareOptions options) { }

	// RVA: 0x16C8760 Offset: 0x16C7960 VA: 0x1816C8760
	private int CompareString(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2, CompareOptions options) { }

	// RVA: 0x16CCED0 Offset: 0x16CC0D0 VA: 0x1816CCED0
	private static bool IsSortable(char* text, int length) { }

	// RVA: 0x16C9810 Offset: 0x16C8A10 VA: 0x1816C9810
	private SortKey CreateSortKey(string source, CompareOptions options) { }

	// RVA: 0x16CE020 Offset: 0x16CD220 VA: 0x1816CE020
	private bool StartsWith(string source, string prefix, CompareOptions options) { }

	// RVA: 0x16CC9F0 Offset: 0x16CBBF0 VA: 0x1816CC9F0
	private bool StartsWith(ReadOnlySpan<char> source, ReadOnlySpan<char> prefix, CompareOptions options) { }

	// RVA: 0x16C9A20 Offset: 0x16C8C20 VA: 0x1816C9A20
	private bool EndsWith(string source, string suffix, CompareOptions options) { }

	// RVA: 0x16C9B40 Offset: 0x16C8D40 VA: 0x1816C9B40
	private bool EndsWith(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options) { }

	// RVA: 0x16CA5A0 Offset: 0x16C97A0 VA: 0x1816CA5A0
	internal int GetHashCodeOfStringCore(string source, CompareOptions options) { }

	// RVA: 0x16CAE90 Offset: 0x16CA090 VA: 0x1816CAE90
	private SortVersion GetSortVersion() { }

	// RVA: 0x16CE1A0 Offset: 0x16CD3A0 VA: 0x1816CE1A0
	private static void .cctor() { }

	// RVA: 0x16CE220 Offset: 0x16CD420 VA: 0x1816CE220
	internal void .ctor() { }
}

// Namespace: System.Globalization
[Flags]
public enum CompareOptions // TypeDefIndex: 4238
{
	// Fields
	public int value__; // 0x0
	public const CompareOptions None = 0;
	public const CompareOptions IgnoreCase = 1;
	public const CompareOptions IgnoreNonSpace = 2;
	public const CompareOptions IgnoreSymbols = 4;
	public const CompareOptions IgnoreKanaType = 8;
	public const CompareOptions IgnoreWidth = 16;
	public const CompareOptions OrdinalIgnoreCase = 268435456;
	public const CompareOptions StringSort = 536870912;
	public const CompareOptions Ordinal = 1073741824;
}

// Namespace: System.Globalization
[Serializable]
public class CultureNotFoundException : ArgumentException // TypeDefIndex: 4239
{
	// Fields
	private string _invalidCultureName; // 0x98
	private Nullable<int> _invalidCultureId; // 0xA0

	// Properties
	public virtual Nullable<int> InvalidCultureId { get; }
	public virtual string InvalidCultureName { get; }
	private static string DefaultMessage { get; }
	private string FormatedInvalidCultureId { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x16CF200 Offset: 0x16CE400 VA: 0x1816CF200
	public void .ctor() { }

	// RVA: 0x16CF0C0 Offset: 0x16CE2C0 VA: 0x1816CF0C0
	public void .ctor(string message) { }

	// RVA: 0x16CF0E0 Offset: 0x16CE2E0 VA: 0x1816CF0E0
	public void .ctor(string paramName, string message) { }

	// RVA: 0x16CF0D0 Offset: 0x16CE2D0 VA: 0x1816CF0D0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x16CF100 Offset: 0x16CE300 VA: 0x1816CF100
	public void .ctor(string paramName, string invalidCultureName, string message) { }

	// RVA: 0x16CF1D0 Offset: 0x16CE3D0 VA: 0x1816CF1D0
	public void .ctor(string message, string invalidCultureName, Exception innerException) { }

	// RVA: 0x16CF400 Offset: 0x16CE600 VA: 0x1816CF400
	public void .ctor(string message, int invalidCultureId, Exception innerException) { }

	// RVA: 0x16CF140 Offset: 0x16CE340 VA: 0x1816CF140
	public void .ctor(string paramName, int invalidCultureId, string message) { }

	// RVA: 0x16CF240 Offset: 0x16CE440 VA: 0x1816CF240
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16CEF70 Offset: 0x16CE170 VA: 0x1816CEF70 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0 Slot: 18
	public virtual Nullable<int> get_InvalidCultureId() { }

	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50 Slot: 19
	public virtual string get_InvalidCultureName() { }

	// RVA: 0x16CF490 Offset: 0x16CE690 VA: 0x1816CF490
	private static string get_DefaultMessage() { }

	// RVA: 0x16CF4C0 Offset: 0x16CE6C0 VA: 0x1816CF4C0
	private string get_FormatedInvalidCultureId() { }

	// RVA: 0x16CF5E0 Offset: 0x16CE7E0 VA: 0x1816CF5E0 Slot: 5
	public override string get_Message() { }
}

// Namespace: System.Globalization
[Flags]
public enum CultureTypes // TypeDefIndex: 4240
{
	// Fields
	public int value__; // 0x0
	public const CultureTypes NeutralCultures = 1;
	public const CultureTypes SpecificCultures = 2;
	public const CultureTypes InstalledWin32Cultures = 4;
	public const CultureTypes AllCultures = 7;
	public const CultureTypes UserCustomCulture = 8;
	public const CultureTypes ReplacementCultures = 16;
	[Obsolete("This value has been deprecated.  Please use other values in CultureTypes.")]
	public const CultureTypes WindowsOnlyCultures = 32;
	[Obsolete("This value has been deprecated.  Please use other values in CultureTypes.")]
	public const CultureTypes FrameworkCultures = 64;
}

// Namespace: System.Globalization
[Flags]
internal enum MonthNameStyles // TypeDefIndex: 4241
{
	// Fields
	public int value__; // 0x0
	public const MonthNameStyles Regular = 0;
	public const MonthNameStyles Genitive = 1;
	public const MonthNameStyles LeapYear = 2;
}

// Namespace: System.Globalization
[Flags]
internal enum DateTimeFormatFlags // TypeDefIndex: 4242
{
	// Fields
	public int value__; // 0x0
	public const DateTimeFormatFlags None = 0;
	public const DateTimeFormatFlags UseGenitiveMonth = 1;
	public const DateTimeFormatFlags UseLeapYearMonth = 2;
	public const DateTimeFormatFlags UseSpacesInMonthNames = 4;
	public const DateTimeFormatFlags UseHebrewRule = 8;
	public const DateTimeFormatFlags UseSpacesInDayNames = 16;
	public const DateTimeFormatFlags UseDigitPrefixInTokens = 32;
	public const DateTimeFormatFlags NotInitialized = -1;
}

// Namespace: 
internal class DateTimeFormatInfo.TokenHashValue // TypeDefIndex: 4243
{
	// Fields
	internal string tokenString; // 0x10
	internal TokenType tokenType; // 0x18
	internal int tokenValue; // 0x1C

	// Methods

	// RVA: 0x6BFA00 Offset: 0x6BEC00 VA: 0x1806BFA00
	internal void .ctor(string tokenString, TokenType tokenType, int tokenValue) { }
}

// Namespace: System.Globalization
[Serializable]
public sealed class DateTimeFormatInfo : IFormatProvider, ICloneable // TypeDefIndex: 4244
{
	// Fields
	private static DateTimeFormatInfo s_invariantInfo; // 0x0
	private CultureData _cultureData; // 0x10
	private string _name; // 0x18
	private string _langName; // 0x20
	private CompareInfo _compareInfo; // 0x28
	private CultureInfo _cultureInfo; // 0x30
	private string amDesignator; // 0x38
	private string pmDesignator; // 0x40
	private string dateSeparator; // 0x48
	private string generalShortTimePattern; // 0x50
	private string generalLongTimePattern; // 0x58
	private string timeSeparator; // 0x60
	private string monthDayPattern; // 0x68
	private string dateTimeOffsetPattern; // 0x70
	private const string rfc1123Pattern = "ddd, dd MMM yyyy HH\':\'mm\':\'ss \'GMT\'";
	private const string sortableDateTimePattern = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss";
	private const string universalSortableDateTimePattern = "yyyy\'-\'MM\'-\'dd HH\':\'mm\':\'ss\'Z\'";
	private Calendar calendar; // 0x78
	private int firstDayOfWeek; // 0x80
	private int calendarWeekRule; // 0x84
	private string fullDateTimePattern; // 0x88
	private string[] abbreviatedDayNames; // 0x90
	private string[] m_superShortDayNames; // 0x98
	private string[] dayNames; // 0xA0
	private string[] abbreviatedMonthNames; // 0xA8
	private string[] monthNames; // 0xB0
	private string[] genitiveMonthNames; // 0xB8
	private string[] m_genitiveAbbreviatedMonthNames; // 0xC0
	private string[] leapYearMonthNames; // 0xC8
	private string longDatePattern; // 0xD0
	private string shortDatePattern; // 0xD8
	private string yearMonthPattern; // 0xE0
	private string longTimePattern; // 0xE8
	private string shortTimePattern; // 0xF0
	private string[] allYearMonthPatterns; // 0xF8
	private string[] allShortDatePatterns; // 0x100
	private string[] allLongDatePatterns; // 0x108
	private string[] allShortTimePatterns; // 0x110
	private string[] allLongTimePatterns; // 0x118
	private string[] m_eraNames; // 0x120
	private string[] m_abbrevEraNames; // 0x128
	private string[] m_abbrevEnglishEraNames; // 0x130
	private CalendarId[] optionalCalendars; // 0x138
	private const int DEFAULT_ALL_DATETIMES_SIZE = 132;
	internal bool _isReadOnly; // 0x140
	private DateTimeFormatFlags formatFlags; // 0x144
	private static readonly char[] s_monthSpaces; // 0x8
	internal const string RoundtripFormat = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss.fffffffK";
	internal const string RoundtripDateTimeUnfixed = "yyyy\'-\'MM\'-\'ddTHH\':\'mm\':\'ss zzz";
	private string _fullTimeSpanPositivePattern; // 0x148
	private string _fullTimeSpanNegativePattern; // 0x150
	internal const DateTimeStyles InvalidDateTimeStyles = -256;
	private DateTimeFormatInfo.TokenHashValue[] _dtfiTokenHash; // 0x158
	private const int TOKEN_HASH_SIZE = 199;
	private const int SECOND_PRIME = 197;
	private const string dateSeparatorOrTimeZoneOffset = "-";
	private const string invariantDateSeparator = "/";
	private const string invariantTimeSeparator = ":";
	internal const string IgnorablePeriod = ".";
	internal const string IgnorableComma = ",";
	internal const string CJKYearSuff = "年";
	internal const string CJKMonthSuff = "月";
	internal const string CJKDaySuff = "日";
	internal const string KoreanYearSuff = "년";
	internal const string KoreanMonthSuff = "월";
	internal const string KoreanDaySuff = "일";
	internal const string KoreanHourSuff = "시";
	internal const string KoreanMinuteSuff = "분";
	internal const string KoreanSecondSuff = "초";
	internal const string CJKHourSuff = "時";
	internal const string ChineseHourSuff = "时";
	internal const string CJKMinuteSuff = "分";
	internal const string CJKSecondSuff = "秒";
	internal const string JapaneseEraStart = "元";
	internal const string LocalTimeMark = "T";
	internal const string GMTName = "GMT";
	internal const string ZuluName = "Z";
	internal const string KoreanLangName = "ko";
	internal const string JapaneseLangName = "ja";
	internal const string EnglishLangName = "en";
	private static DateTimeFormatInfo s_jajpDTFI; // 0x10
	private static DateTimeFormatInfo s_zhtwDTFI; // 0x18

	// Properties
	private string CultureName { get; }
	private CultureInfo Culture { get; }
	private string LanguageName { get; }
	public static DateTimeFormatInfo InvariantInfo { get; }
	public static DateTimeFormatInfo CurrentInfo { get; }
	public string AMDesignator { get; set; }
	public Calendar Calendar { get; set; }
	private CalendarId[] OptionalCalendars { get; }
	internal string[] EraNames { get; }
	internal string[] AbbreviatedEraNames { get; }
	internal string[] AbbreviatedEnglishEraNames { get; }
	public string DateSeparator { get; set; }
	public DayOfWeek FirstDayOfWeek { get; set; }
	public CalendarWeekRule CalendarWeekRule { get; set; }
	public string FullDateTimePattern { get; set; }
	public string LongDatePattern { get; set; }
	public string LongTimePattern { get; set; }
	public string MonthDayPattern { get; set; }
	public string PMDesignator { get; set; }
	public string RFC1123Pattern { get; }
	public string ShortDatePattern { get; set; }
	public string ShortTimePattern { get; set; }
	public string SortableDateTimePattern { get; }
	internal string GeneralShortTimePattern { get; }
	internal string GeneralLongTimePattern { get; }
	internal string DateTimeOffsetPattern { get; }
	public string TimeSeparator { get; set; }
	public string UniversalSortableDateTimePattern { get; }
	public string YearMonthPattern { get; set; }
	public string[] AbbreviatedDayNames { get; set; }
	public string[] ShortestDayNames { get; set; }
	public string[] DayNames { get; set; }
	public string[] AbbreviatedMonthNames { get; set; }
	public string[] MonthNames { get; set; }
	internal bool HasSpacesInMonthNames { get; }
	internal bool HasSpacesInDayNames { get; }
	private string[] AllYearMonthPatterns { get; }
	private string[] AllShortDatePatterns { get; }
	private string[] AllShortTimePatterns { get; }
	private string[] AllLongDatePatterns { get; }
	private string[] AllLongTimePatterns { get; }
	private string[] UnclonedYearMonthPatterns { get; }
	private string[] UnclonedShortDatePatterns { get; }
	private string[] UnclonedLongDatePatterns { get; }
	private string[] UnclonedShortTimePatterns { get; }
	private string[] UnclonedLongTimePatterns { get; }
	public bool IsReadOnly { get; }
	public string NativeCalendarName { get; }
	public string[] AbbreviatedMonthGenitiveNames { get; set; }
	public string[] MonthGenitiveNames { get; set; }
	internal string FullTimeSpanPositivePattern { get; }
	internal string FullTimeSpanNegativePattern { get; }
	internal CompareInfo CompareInfo { get; }
	internal DateTimeFormatFlags FormatFlags { get; }
	internal bool HasForceTwoDigitYears { get; }
	internal bool HasYearMonthAdjustment { get; }

	// Methods

	// RVA: 0x16D71C0 Offset: 0x16D63C0 VA: 0x1816D71C0
	private string get_CultureName() { }

	// RVA: 0x16D71F0 Offset: 0x16D63F0 VA: 0x1816D71F0
	private CultureInfo get_Culture() { }

	// RVA: 0x16D7E20 Offset: 0x16D7020 VA: 0x1816D7E20
	private string get_LanguageName() { }

	// RVA: 0x16D8610 Offset: 0x16D7810 VA: 0x1816D8610
	private string[] internalGetAbbreviatedDayOfWeekNames() { }

	// RVA: 0x16D85B0 Offset: 0x16D77B0 VA: 0x1816D85B0
	private string[] internalGetAbbreviatedDayOfWeekNamesCore() { }

	// RVA: 0x16D8B10 Offset: 0x16D7D10 VA: 0x1816D8B10
	private string[] internalGetSuperShortDayNames() { }

	// RVA: 0x16D8AB0 Offset: 0x16D7CB0 VA: 0x1816D8AB0
	private string[] internalGetSuperShortDayNamesCore() { }

	// RVA: 0x16D8710 Offset: 0x16D7910 VA: 0x1816D8710
	private string[] internalGetDayOfWeekNames() { }

	// RVA: 0x16D86B0 Offset: 0x16D78B0 VA: 0x1816D86B0
	private string[] internalGetDayOfWeekNamesCore() { }

	// RVA: 0x16D8690 Offset: 0x16D7890 VA: 0x1816D8690
	private string[] internalGetAbbreviatedMonthNames() { }

	// RVA: 0x16D8630 Offset: 0x16D7830 VA: 0x1816D8630
	private string[] internalGetAbbreviatedMonthNamesCore() { }

	// RVA: 0x16D8A90 Offset: 0x16D7C90 VA: 0x1816D8A90
	private string[] internalGetMonthNames() { }

	// RVA: 0x16D8A30 Offset: 0x16D7C30 VA: 0x1816D8A30
	private string[] internalGetMonthNamesCore() { }

	// RVA: 0x16D6690 Offset: 0x16D5890 VA: 0x1816D6690
	public void .ctor() { }

	// RVA: 0x16D6890 Offset: 0x16D5A90 VA: 0x1816D6890
	internal void .ctor(CultureData cultureData, Calendar cal) { }

	// RVA: 0x16D3D20 Offset: 0x16D2F20 VA: 0x1816D3D20
	private void InitializeOverridableProperties(CultureData cultureData, int calendarId) { }

	// RVA: 0x16D7CA0 Offset: 0x16D6EA0 VA: 0x1816D7CA0
	public static DateTimeFormatInfo get_InvariantInfo() { }

	// RVA: 0x16D7280 Offset: 0x16D6480 VA: 0x1816D7280
	public static DateTimeFormatInfo get_CurrentInfo() { }

	// RVA: 0x16D2F60 Offset: 0x16D2160 VA: 0x1816D2F60
	public static DateTimeFormatInfo GetInstance(IFormatProvider provider) { }

	// RVA: 0x16D2ED0 Offset: 0x16D20D0 VA: 0x1816D2ED0 Slot: 4
	public object GetFormat(Type formatType) { }

	// RVA: 0x16D0FA0 Offset: 0x16D01A0 VA: 0x1816D0FA0 Slot: 5
	public object Clone() { }

	// RVA: 0x16D68F0 Offset: 0x16D5AF0 VA: 0x1816D68F0
	public string get_AMDesignator() { }

	// RVA: 0x16D8B30 Offset: 0x16D7D30 VA: 0x1816D8B30
	public void set_AMDesignator(string value) { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	public Calendar get_Calendar() { }

	// RVA: 0x16D9470 Offset: 0x16D8670 VA: 0x1816D9470
	public void set_Calendar(Calendar value) { }

	// RVA: 0x16D8110 Offset: 0x16D7310 VA: 0x1816D8110
	private CalendarId[] get_OptionalCalendars() { }

	// RVA: 0x16D2AF0 Offset: 0x16D1CF0 VA: 0x1816D2AF0
	public int GetEra(string eraName) { }

	// RVA: 0x16D76F0 Offset: 0x16D68F0 VA: 0x1816D76F0
	internal string[] get_EraNames() { }

	// RVA: 0x16D29C0 Offset: 0x16D1BC0 VA: 0x1816D29C0
	public string GetEraName(int era) { }

	// RVA: 0x16D6A20 Offset: 0x16D5C20 VA: 0x1816D6A20
	internal string[] get_AbbreviatedEraNames() { }

	// RVA: 0x16D1E40 Offset: 0x16D1040 VA: 0x1816D1E40
	public string GetAbbreviatedEraName(int era) { }

	// RVA: 0x16D69B0 Offset: 0x16D5BB0 VA: 0x1816D69B0
	internal string[] get_AbbreviatedEnglishEraNames() { }

	// RVA: 0x16D7390 Offset: 0x16D6590 VA: 0x1816D7390
	public string get_DateSeparator() { }

	// RVA: 0x16D98F0 Offset: 0x16D8AF0 VA: 0x1816D98F0
	public void set_DateSeparator(string value) { }

	// RVA: 0x16D7760 Offset: 0x16D6960 VA: 0x1816D7760
	public DayOfWeek get_FirstDayOfWeek() { }

	// RVA: 0x16D9C40 Offset: 0x16D8E40 VA: 0x1816D9C40
	public void set_FirstDayOfWeek(DayOfWeek value) { }

	// RVA: 0x16D7070 Offset: 0x16D6270 VA: 0x1816D7070
	public CalendarWeekRule get_CalendarWeekRule() { }

	// RVA: 0x16D9340 Offset: 0x16D8540 VA: 0x1816D9340
	public void set_CalendarWeekRule(CalendarWeekRule value) { }

	// RVA: 0x16D77B0 Offset: 0x16D69B0 VA: 0x1816D77B0
	public string get_FullDateTimePattern() { }

	// RVA: 0x16D9D70 Offset: 0x16D8F70 VA: 0x1816D9D70
	public void set_FullDateTimePattern(string value) { }

	// RVA: 0x16D7E50 Offset: 0x16D7050 VA: 0x1816D7E50
	public string get_LongDatePattern() { }

	// RVA: 0x16D9E50 Offset: 0x16D9050 VA: 0x1816D9E50
	public void set_LongDatePattern(string value) { }

	// RVA: 0x16D7EA0 Offset: 0x16D70A0 VA: 0x1816D7EA0
	public string get_LongTimePattern() { }

	// RVA: 0x16D9F40 Offset: 0x16D9140 VA: 0x1816D9F40
	public void set_LongTimePattern(string value) { }

	// RVA: 0x16D7F10 Offset: 0x16D7110 VA: 0x1816D7F10
	public string get_MonthDayPattern() { }

	// RVA: 0x16DA040 Offset: 0x16D9240 VA: 0x1816DA040
	public void set_MonthDayPattern(string value) { }

	// RVA: 0x16D8150 Offset: 0x16D7350 VA: 0x1816D8150
	public string get_PMDesignator() { }

	// RVA: 0x16DA5E0 Offset: 0x16D97E0 VA: 0x1816DA5E0
	public void set_PMDesignator(string value) { }

	// RVA: 0x16D8180 Offset: 0x16D7380 VA: 0x1816D8180
	public string get_RFC1123Pattern() { }

	// RVA: 0x16D81B0 Offset: 0x16D73B0 VA: 0x1816D81B0
	public string get_ShortDatePattern() { }

	// RVA: 0x16DA6D0 Offset: 0x16D98D0 VA: 0x1816DA6D0
	public void set_ShortDatePattern(string value) { }

	// RVA: 0x16D8200 Offset: 0x16D7400 VA: 0x1816D8200
	public string get_ShortTimePattern() { }

	// RVA: 0x16DA7D0 Offset: 0x16D99D0 VA: 0x1816DA7D0
	public void set_ShortTimePattern(string value) { }

	// RVA: 0x16D8300 Offset: 0x16D7500 VA: 0x1816D8300
	public string get_SortableDateTimePattern() { }

	// RVA: 0x16D7AE0 Offset: 0x16D6CE0 VA: 0x1816D7AE0
	internal string get_GeneralShortTimePattern() { }

	// RVA: 0x16D79F0 Offset: 0x16D6BF0 VA: 0x1816D79F0
	internal string get_GeneralLongTimePattern() { }

	// RVA: 0x16D73F0 Offset: 0x16D65F0 VA: 0x1816D73F0
	internal string get_DateTimeOffsetPattern() { }

	// RVA: 0x16D8330 Offset: 0x16D7530 VA: 0x1816D8330
	public string get_TimeSeparator() { }

	// RVA: 0x16DAB10 Offset: 0x16D9D10 VA: 0x1816DAB10
	public void set_TimeSeparator(string value) { }

	// RVA: 0x16D8530 Offset: 0x16D7730 VA: 0x1816D8530
	public string get_UniversalSortableDateTimePattern() { }

	// RVA: 0x16D8560 Offset: 0x16D7760 VA: 0x1816D8560
	public string get_YearMonthPattern() { }

	// RVA: 0x16DAC00 Offset: 0x16D9E00 VA: 0x1816DAC00
	public void set_YearMonthPattern(string value) { }

	// RVA: 0x16D0EC0 Offset: 0x16D00C0 VA: 0x1816D0EC0
	private static void CheckNullValue(string[] values, int length) { }

	// RVA: 0x16D6920 Offset: 0x16D5B20 VA: 0x1816D6920
	public string[] get_AbbreviatedDayNames() { }

	// RVA: 0x16D8C20 Offset: 0x16D7E20 VA: 0x1816D8C20
	public void set_AbbreviatedDayNames(string[] value) { }

	// RVA: 0x16D8270 Offset: 0x16D7470 VA: 0x1816D8270
	public string[] get_ShortestDayNames() { }

	// RVA: 0x16DA8C0 Offset: 0x16D9AC0 VA: 0x1816DA8C0
	public void set_ShortestDayNames(string[] value) { }

	// RVA: 0x16D7660 Offset: 0x16D6860 VA: 0x1816D7660
	public string[] get_DayNames() { }

	// RVA: 0x16D99E0 Offset: 0x16D8BE0 VA: 0x1816D99E0
	public void set_DayNames(string[] value) { }

	// RVA: 0x16D6B50 Offset: 0x16D5D50 VA: 0x1816D6B50
	public string[] get_AbbreviatedMonthNames() { }

	// RVA: 0x16D90E0 Offset: 0x16D82E0 VA: 0x1816D90E0
	public void set_AbbreviatedMonthNames(string[] value) { }

	// RVA: 0x16D8030 Offset: 0x16D7230 VA: 0x1816D8030
	public string[] get_MonthNames() { }

	// RVA: 0x16DA380 Offset: 0x16D9580 VA: 0x1816DA380
	public void set_MonthNames(string[] value) { }

	// RVA: 0x16D7C40 Offset: 0x16D6E40 VA: 0x1816D7C40
	internal bool get_HasSpacesInMonthNames() { }

	// RVA: 0x16D7C10 Offset: 0x16D6E10 VA: 0x1816D7C10
	internal bool get_HasSpacesInDayNames() { }

	// RVA: 0x16D8870 Offset: 0x16D7A70 VA: 0x1816D8870
	internal string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated) { }

	// RVA: 0x16D8730 Offset: 0x16D7930 VA: 0x1816D8730
	private string[] internalGetGenitiveMonthNames(bool abbreviated) { }

	// RVA: 0x16D8800 Offset: 0x16D7A00 VA: 0x1816D8800
	internal string[] internalGetLeapYearMonthNames() { }

	// RVA: 0x16D1D30 Offset: 0x16D0F30 VA: 0x1816D1D30
	public string GetAbbreviatedDayName(DayOfWeek dayofweek) { }

	// RVA: 0x16D35B0 Offset: 0x16D27B0 VA: 0x1816D35B0
	public string GetShortestDayName(DayOfWeek dayOfWeek) { }

	// RVA: 0x16D2770 Offset: 0x16D1970 VA: 0x1816D2770
	private static string[] GetCombinedPatterns(string[] patterns1, string[] patterns2, string connectString) { }

	// RVA: 0x16D20B0 Offset: 0x16D12B0 VA: 0x1816D20B0
	public string[] GetAllDateTimePatterns() { }

	// RVA: 0x16D2250 Offset: 0x16D1450 VA: 0x1816D2250
	public string[] GetAllDateTimePatterns(char format) { }

	// RVA: 0x16D28B0 Offset: 0x16D1AB0 VA: 0x1816D28B0
	public string GetDayName(DayOfWeek dayofweek) { }

	// RVA: 0x16D1FA0 Offset: 0x16D11A0 VA: 0x1816D1FA0
	public string GetAbbreviatedMonthName(int month) { }

	// RVA: 0x16D34A0 Offset: 0x16D26A0 VA: 0x1816D34A0
	public string GetMonthName(int month) { }

	// RVA: 0x16D32F0 Offset: 0x16D24F0 VA: 0x1816D32F0
	private static string[] GetMergedPatterns(string[] patterns, string defaultPattern) { }

	// RVA: 0x16D6F80 Offset: 0x16D6180 VA: 0x1816D6F80
	private string[] get_AllYearMonthPatterns() { }

	// RVA: 0x16D6DB0 Offset: 0x16D5FB0 VA: 0x1816D6DB0
	private string[] get_AllShortDatePatterns() { }

	// RVA: 0x16D6EA0 Offset: 0x16D60A0 VA: 0x1816D6EA0
	private string[] get_AllShortTimePatterns() { }

	// RVA: 0x16D6BE0 Offset: 0x16D5DE0 VA: 0x1816D6BE0
	private string[] get_AllLongDatePatterns() { }

	// RVA: 0x16D6CD0 Offset: 0x16D5ED0 VA: 0x1816D6CD0
	private string[] get_AllLongTimePatterns() { }

	// RVA: 0x16D84C0 Offset: 0x16D76C0 VA: 0x1816D84C0
	private string[] get_UnclonedYearMonthPatterns() { }

	// RVA: 0x16D8410 Offset: 0x16D7610 VA: 0x1816D8410
	private string[] get_UnclonedShortDatePatterns() { }

	// RVA: 0x16D8360 Offset: 0x16D7560 VA: 0x1816D8360
	private string[] get_UnclonedLongDatePatterns() { }

	// RVA: 0x16D8480 Offset: 0x16D7680 VA: 0x1816D8480
	private string[] get_UnclonedShortTimePatterns() { }

	// RVA: 0x16D83D0 Offset: 0x16D75D0 VA: 0x1816D83D0
	private string[] get_UnclonedLongTimePatterns() { }

	// RVA: 0x16D5640 Offset: 0x16D4840 VA: 0x1816D5640
	public static DateTimeFormatInfo ReadOnly(DateTimeFormatInfo dtfi) { }

	// RVA: 0x16D7D90 Offset: 0x16D6F90 VA: 0x1816D7D90
	public bool get_IsReadOnly() { }

	// RVA: 0x16D80C0 Offset: 0x16D72C0 VA: 0x1816D80C0
	public string get_NativeCalendarName() { }

	// RVA: 0x16D5750 Offset: 0x16D4950 VA: 0x1816D5750
	public void SetAllDateTimePatterns(string[] patterns, char format) { }

	// RVA: 0x16D6A90 Offset: 0x16D5C90 VA: 0x1816D6A90
	public string[] get_AbbreviatedMonthGenitiveNames() { }

	// RVA: 0x16D8E80 Offset: 0x16D8080 VA: 0x1816D8E80
	public void set_AbbreviatedMonthGenitiveNames(string[] value) { }

	// RVA: 0x16D7F70 Offset: 0x16D7170 VA: 0x1816D7F70
	public string[] get_MonthGenitiveNames() { }

	// RVA: 0x16DA120 Offset: 0x16D9320 VA: 0x1816DA120
	public void set_MonthGenitiveNames(string[] value) { }

	// RVA: 0x16D7910 Offset: 0x16D6B10 VA: 0x1816D7910
	internal string get_FullTimeSpanPositivePattern() { }

	// RVA: 0x16D78B0 Offset: 0x16D6AB0 VA: 0x1816D78B0
	internal string get_FullTimeSpanNegativePattern() { }

	// RVA: 0x16D70A0 Offset: 0x16D62A0 VA: 0x1816D70A0
	internal CompareInfo get_CompareInfo() { }

	// RVA: 0x16D63A0 Offset: 0x16D55A0 VA: 0x1816D63A0
	internal static void ValidateStyles(DateTimeStyles style, string parameterName) { }

	// RVA: 0x16D7790 Offset: 0x16D6990 VA: 0x1816D7790
	internal DateTimeFormatFlags get_FormatFlags() { }

	// RVA: 0x16D3860 Offset: 0x16D2A60 VA: 0x1816D3860
	private DateTimeFormatFlags InitializeFormatFlags() { }

	// RVA: 0x16D7BD0 Offset: 0x16D6DD0 VA: 0x1816D7BD0
	internal bool get_HasForceTwoDigitYears() { }

	// RVA: 0x16D7C70 Offset: 0x16D6E70 VA: 0x1816D7C70
	internal bool get_HasYearMonthAdjustment() { }

	// RVA: 0x16D64D0 Offset: 0x16D56D0 VA: 0x1816D64D0
	internal bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName) { }

	// RVA: 0x16D3150 Offset: 0x16D2350 VA: 0x1816D3150
	internal static DateTimeFormatInfo GetJapaneseCalendarDTFI() { }

	// RVA: 0x16D36C0 Offset: 0x16D28C0 VA: 0x1816D36C0
	internal static DateTimeFormatInfo GetTaiwanCalendarDTFI() { }

	// RVA: 0x16D0F80 Offset: 0x16D0180 VA: 0x1816D0F80
	private void ClearTokenHashTable() { }

	// RVA: 0x16D1220 Offset: 0x16D0420 VA: 0x1816D1220
	internal DateTimeFormatInfo.TokenHashValue[] CreateTokenHashTable() { }

	// RVA: 0x16D4720 Offset: 0x16D3920 VA: 0x1816D4720
	private void PopulateSpecialTokenHashTable(DateTimeFormatInfo.TokenHashValue[] temp, ref bool useDateSepAsIgnorableSymbol) { }

	// RVA: 0x16D45F0 Offset: 0x16D37F0 VA: 0x1816D45F0
	private static bool IsJapaneseCalendar(Calendar calendar) { }

	// RVA: 0x16D0DF0 Offset: 0x16CFFF0 VA: 0x1816D0DF0
	private void AddMonthNames(DateTimeFormatInfo.TokenHashValue[] temp, string monthPostfix) { }

	// RVA: 0x16D61B0 Offset: 0x16D53B0 VA: 0x1816D61B0
	private static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number) { }

	// RVA: 0x16D45D0 Offset: 0x16D37D0 VA: 0x1816D45D0
	private static bool IsHebrewChar(char ch) { }

	// RVA: 0x16D44B0 Offset: 0x16D36B0 VA: 0x1816D44B0
	private bool IsAllowedJapaneseTokenFollowedByNonSpaceLetter(string tokenString, char nextCh) { }

	// RVA: 0x16D5AD0 Offset: 0x16D4CD0 VA: 0x1816D5AD0
	internal bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str) { }

	// RVA: 0x16D3E60 Offset: 0x16D3060 VA: 0x1816D3E60
	private void InsertAtCurrentHashNode(DateTimeFormatInfo.TokenHashValue[] hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe) { }

	// RVA: 0x16D4090 Offset: 0x16D3290 VA: 0x1816D4090
	private void InsertHash(DateTimeFormatInfo.TokenHashValue[] hashTable, string str, TokenType tokenType, int tokenValue) { }

	// RVA: 0x16D1100 Offset: 0x16D0300 VA: 0x1816D1100
	private bool CompareStringIgnoreCaseOptimized(string string1, int offset1, int length1, string string2, int offset2, int length2) { }

	// RVA: 0x16D6610 Offset: 0x16D5810 VA: 0x1816D6610
	private static void .cctor() { }
}

// Namespace: System.Globalization
internal enum FORMATFLAGS // TypeDefIndex: 4245
{
	// Fields
	public int value__; // 0x0
	public const FORMATFLAGS None = 0;
	public const FORMATFLAGS UseGenitiveMonth = 1;
	public const FORMATFLAGS UseLeapYearMonth = 2;
	public const FORMATFLAGS UseSpacesInMonthNames = 4;
	public const FORMATFLAGS UseHebrewParsing = 8;
	public const FORMATFLAGS UseSpacesInDayNames = 16;
	public const FORMATFLAGS UseDigitPrefixInTokens = 32;
}

// Namespace: System.Globalization
internal enum CalendarId // TypeDefIndex: 4246
{
	// Fields
	public ushort value__; // 0x0
	public const CalendarId UNINITIALIZED_VALUE = 0;
	public const CalendarId GREGORIAN = 1;
	public const CalendarId GREGORIAN_US = 2;
	public const CalendarId JAPAN = 3;
	public const CalendarId TAIWAN = 4;
	public const CalendarId KOREA = 5;
	public const CalendarId HIJRI = 6;
	public const CalendarId THAI = 7;
	public const CalendarId HEBREW = 8;
	public const CalendarId GREGORIAN_ME_FRENCH = 9;
	public const CalendarId GREGORIAN_ARABIC = 10;
	public const CalendarId GREGORIAN_XLIT_ENGLISH = 11;
	public const CalendarId GREGORIAN_XLIT_FRENCH = 12;
	public const CalendarId JULIAN = 13;
	public const CalendarId JAPANESELUNISOLAR = 14;
	public const CalendarId CHINESELUNISOLAR = 15;
	public const CalendarId SAKA = 16;
	public const CalendarId LUNAR_ETO_CHN = 17;
	public const CalendarId LUNAR_ETO_KOR = 18;
	public const CalendarId LUNAR_ETO_ROKUYOU = 19;
	public const CalendarId KOREANLUNISOLAR = 20;
	public const CalendarId TAIWANLUNISOLAR = 21;
	public const CalendarId PERSIAN = 22;
	public const CalendarId UMALQURA = 23;
	public const CalendarId LAST_CALENDAR = 23;
}

// Namespace: 
private enum DateTimeFormatInfoScanner.FoundDatePattern // TypeDefIndex: 4247
{
	// Fields
	public int value__; // 0x0
	public const DateTimeFormatInfoScanner.FoundDatePattern None = 0;
	public const DateTimeFormatInfoScanner.FoundDatePattern FoundYearPatternFlag = 1;
	public const DateTimeFormatInfoScanner.FoundDatePattern FoundMonthPatternFlag = 2;
	public const DateTimeFormatInfoScanner.FoundDatePattern FoundDayPatternFlag = 4;
	public const DateTimeFormatInfoScanner.FoundDatePattern FoundYMDPatternFlag = 7;
}

// Namespace: System.Globalization
internal class DateTimeFormatInfoScanner // TypeDefIndex: 4248
{
	// Fields
	internal const char MonthPostfixChar = '\xe000';
	internal const char IgnorableSymbolChar = '\xe001';
	internal const string CJKYearSuff = "年";
	internal const string CJKMonthSuff = "月";
	internal const string CJKDaySuff = "日";
	internal const string KoreanYearSuff = "년";
	internal const string KoreanMonthSuff = "월";
	internal const string KoreanDaySuff = "일";
	internal const string KoreanHourSuff = "시";
	internal const string KoreanMinuteSuff = "분";
	internal const string KoreanSecondSuff = "초";
	internal const string CJKHourSuff = "時";
	internal const string ChineseHourSuff = "时";
	internal const string CJKMinuteSuff = "分";
	internal const string CJKSecondSuff = "秒";
	internal List<string> m_dateWords; // 0x10
	private static Dictionary<string, string> s_knownWords; // 0x0
	private DateTimeFormatInfoScanner.FoundDatePattern _ymdFlags; // 0x18

	// Properties
	private static Dictionary<string, string> KnownWords { get; }

	// Methods

	// RVA: 0x16D09E0 Offset: 0x16CFBE0 VA: 0x1816D09E0
	private static Dictionary<string, string> get_KnownWords() { }

	// RVA: 0x16D08A0 Offset: 0x16CFAA0 VA: 0x1816D08A0
	internal static int SkipWhiteSpacesAndNonLetter(string pattern, int currentIndex) { }

	// RVA: 0x16CF780 Offset: 0x16CE980 VA: 0x1816CF780
	internal void AddDateWordOrPostfix(string formatPostfix, string str) { }

	// RVA: 0x16CF9A0 Offset: 0x16CEBA0 VA: 0x1816CF9A0
	internal int AddDateWords(string pattern, int index, string formatPostfix) { }

	// RVA: 0x16D0830 Offset: 0x16CFA30 VA: 0x1816D0830
	internal static int ScanRepeatChar(string pattern, char ch, int index, out int count) { }

	// RVA: 0x16CFBD0 Offset: 0x16CEDD0 VA: 0x1816CFBD0
	internal void AddIgnorableSymbols(string text) { }

	// RVA: 0x16D0610 Offset: 0x16CF810 VA: 0x1816D0610
	internal void ScanDateWord(string pattern) { }

	// RVA: 0x16D00F0 Offset: 0x16CF2F0 VA: 0x1816D00F0
	internal string[] GetDateWordsOfDTFI(DateTimeFormatInfo dtfi) { }

	// RVA: 0x16D03D0 Offset: 0x16CF5D0 VA: 0x1816D03D0
	internal static FORMATFLAGS GetFormatFlagGenitiveMonth(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames) { }

	// RVA: 0x16D0550 Offset: 0x16CF750 VA: 0x1816D0550
	internal static FORMATFLAGS GetFormatFlagUseSpaceInMonthNames(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames) { }

	// RVA: 0x16D0510 Offset: 0x16CF710 VA: 0x1816D0510
	internal static FORMATFLAGS GetFormatFlagUseSpaceInDayNames(string[] dayNames, string[] abbrevDayNames) { }

	// RVA: 0x16D0500 Offset: 0x16CF700 VA: 0x1816D0500
	internal static FORMATFLAGS GetFormatFlagUseHebrewCalendar(int calID) { }

	// RVA: 0x16D0040 Offset: 0x16CF240 VA: 0x1816D0040
	private static bool EqualStringArrays(string[] array1, string[] array2) { }

	// RVA: 0x16CFF60 Offset: 0x16CF160 VA: 0x1816CFF60
	private static bool ArrayElementsHaveSpace(string[] array) { }

	// RVA: 0x16CFD10 Offset: 0x16CEF10 VA: 0x1816CFD10
	private static bool ArrayElementsBeginWithDigit(string[] array) { }

	// RVA: 0x16D0970 Offset: 0x16CFB70 VA: 0x1816D0970
	public void .ctor() { }
}

// Namespace: System.Globalization
[Flags]
public enum DateTimeStyles // TypeDefIndex: 4249
{
	// Fields
	public int value__; // 0x0
	public const DateTimeStyles None = 0;
	public const DateTimeStyles AllowLeadingWhite = 1;
	public const DateTimeStyles AllowTrailingWhite = 2;
	public const DateTimeStyles AllowInnerWhite = 4;
	public const DateTimeStyles AllowWhiteSpaces = 7;
	public const DateTimeStyles NoCurrentDateDefault = 8;
	public const DateTimeStyles AdjustToUniversal = 16;
	public const DateTimeStyles AssumeLocal = 32;
	public const DateTimeStyles AssumeUniversal = 64;
	public const DateTimeStyles RoundtripKind = 128;
}

// Namespace: System.Globalization
[Serializable]
public class DaylightTime // TypeDefIndex: 4250
{
	// Fields
	private readonly DateTime _start; // 0x10
	private readonly DateTime _end; // 0x18
	private readonly TimeSpan _delta; // 0x20

	// Properties
	public DateTime Start { get; }
	public DateTime End { get; }
	public TimeSpan Delta { get; }

	// Methods

	// RVA: 0x16DACF0 Offset: 0x16D9EF0 VA: 0x1816DACF0
	public void .ctor(DateTime start, DateTime end, TimeSpan delta) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public DateTime get_Start() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public DateTime get_End() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public TimeSpan get_Delta() { }
}

// Namespace: System.Globalization
[IsReadOnly]
internal struct DaylightTimeStruct // TypeDefIndex: 4251
{
	// Fields
	public readonly DateTime Start; // 0x0
	public readonly DateTime End; // 0x8
	public readonly TimeSpan Delta; // 0x10

	// Methods

	// RVA: 0xD45610 Offset: 0xD44810 VA: 0x180D45610
	public void .ctor(DateTime start, DateTime end, TimeSpan delta) { }
}

// Namespace: System.Globalization
public enum DigitShapes // TypeDefIndex: 4252
{
	// Fields
	public int value__; // 0x0
	public const DigitShapes Context = 0;
	public const DigitShapes None = 1;
	public const DigitShapes NativeNational = 2;
}

// Namespace: System.Globalization
[Extension]
public static class GlobalizationExtensions // TypeDefIndex: 4253
{
	// Methods

	[Extension]
	// RVA: 0x16DB400 Offset: 0x16DA600 VA: 0x1816DB400
	public static StringComparer GetStringComparer(CompareInfo compareInfo, CompareOptions options) { }
}

// Namespace: System.Globalization
internal struct HebrewNumberParsingContext // TypeDefIndex: 4254
{
	// Fields
	internal HebrewNumber.HS state; // 0x0
	internal int result; // 0x4

	// Methods

	// RVA: 0x16DB660 Offset: 0x16DA860 VA: 0x1816DB660
	public void .ctor(int result) { }
}

// Namespace: System.Globalization
internal enum HebrewNumberParsingState // TypeDefIndex: 4255
{
	// Fields
	public int value__; // 0x0
	public const HebrewNumberParsingState InvalidHebrewNumber = 0;
	public const HebrewNumberParsingState NotHebrewDigit = 1;
	public const HebrewNumberParsingState FoundEndOfHebrewNumber = 2;
	public const HebrewNumberParsingState ContinueParsing = 3;
}

// Namespace: 
private enum HebrewNumber.HebrewToken // TypeDefIndex: 4256
{
	// Fields
	public short value__; // 0x0
	public const HebrewNumber.HebrewToken Invalid = -1;
	public const HebrewNumber.HebrewToken Digit400 = 0;
	public const HebrewNumber.HebrewToken Digit200_300 = 1;
	public const HebrewNumber.HebrewToken Digit100 = 2;
	public const HebrewNumber.HebrewToken Digit10 = 3;
	public const HebrewNumber.HebrewToken Digit1 = 4;
	public const HebrewNumber.HebrewToken Digit6_7 = 5;
	public const HebrewNumber.HebrewToken Digit7 = 6;
	public const HebrewNumber.HebrewToken Digit9 = 7;
	public const HebrewNumber.HebrewToken SingleQuote = 8;
	public const HebrewNumber.HebrewToken DoubleQuote = 9;
}

// Namespace: 
private struct HebrewNumber.HebrewValue // TypeDefIndex: 4257
{
	// Fields
	internal HebrewNumber.HebrewToken token; // 0x0
	internal short value; // 0x2

	// Methods

	// RVA: 0x16DBF30 Offset: 0x16DB130 VA: 0x1816DBF30
	internal void .ctor(HebrewNumber.HebrewToken token, short value) { }
}

// Namespace: 
internal enum HebrewNumber.HS // TypeDefIndex: 4258
{
	// Fields
	public sbyte value__; // 0x0
	public const HebrewNumber.HS _err = -1;
	public const HebrewNumber.HS Start = 0;
	public const HebrewNumber.HS S400 = 1;
	public const HebrewNumber.HS S400_400 = 2;
	public const HebrewNumber.HS S400_X00 = 3;
	public const HebrewNumber.HS S400_X0 = 4;
	public const HebrewNumber.HS X00_DQ = 5;
	public const HebrewNumber.HS S400_X00_X0 = 6;
	public const HebrewNumber.HS X0_DQ = 7;
	public const HebrewNumber.HS X = 8;
	public const HebrewNumber.HS X0 = 9;
	public const HebrewNumber.HS X00 = 10;
	public const HebrewNumber.HS S400_DQ = 11;
	public const HebrewNumber.HS S400_400_DQ = 12;
	public const HebrewNumber.HS S400_400_100 = 13;
	public const HebrewNumber.HS S9 = 14;
	public const HebrewNumber.HS X00_S9 = 15;
	public const HebrewNumber.HS S9_DQ = 16;
	public const HebrewNumber.HS END = 100;
}

// Namespace: System.Globalization
internal class HebrewNumber // TypeDefIndex: 4259
{
	// Fields
	private static readonly HebrewNumber.HebrewValue[] s_hebrewValues; // 0x0
	private const int minHebrewNumberCh = 1488;
	private static char s_maxHebrewNumberCh; // 0x8
	private static readonly HebrewNumber.HS[] s_numberPasingState; // 0x10
	private const int HebrewTokenCount = 10;

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x16DB8E0 Offset: 0x16DAAE0 VA: 0x1816DB8E0
	internal static string ToString(int Number) { }

	// RVA: 0x16DB730 Offset: 0x16DA930 VA: 0x1816DB730
	internal static HebrewNumberParsingState ParseByChar(char ch, ref HebrewNumberParsingContext context) { }

	// RVA: 0x16DB670 Offset: 0x16DA870 VA: 0x1816DB670
	internal static bool IsDigit(char ch) { }

	// RVA: 0x16DBB90 Offset: 0x16DAD90 VA: 0x1816DBB90
	private static void .cctor() { }
}

// Namespace: System.Globalization
internal class InternalGlobalizationHelper // TypeDefIndex: 4260
{
	// Fields
	internal const long TicksPerMillisecond = 10000;
	internal const long TicksPerTenthSecond = 1000000;
	internal const long TicksPerSecond = 10000000;
	internal const long MaxSeconds = 922337203685;
	internal const long MinSeconds = -922337203685;
	private const int DaysPerYear = 365;
	private const int DaysPer4Years = 1461;
	private const int DaysPer100Years = 36524;
	private const int DaysPer400Years = 146097;
	private const int DaysTo10000 = 3652059;
	private const long TicksPerMinute = 600000000;
	private const long TicksPerHour = 36000000000;
	private const long TicksPerDay = 864000000000;
	internal const long MaxTicks = 3155378975999999999;
	internal const long MinTicks = 0;
	internal const long MaxMilliSeconds = 922337203685477;
	internal const long MinMilliSeconds = -922337203685477;
	internal const int StringBuilderDefaultCapacity = 16;
	internal const long MaxOffset = 504000000000;
	internal const long MinOffset = -504000000000;

	// Methods

	// RVA: 0x16DBF40 Offset: 0x16DB140 VA: 0x1816DBF40
	internal static long TimeToTicks(int hour, int minute, int second) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Globalization
[Flags]
public enum NumberStyles // TypeDefIndex: 4261
{
	// Fields
	public int value__; // 0x0
	public const NumberStyles None = 0;
	public const NumberStyles AllowLeadingWhite = 1;
	public const NumberStyles AllowTrailingWhite = 2;
	public const NumberStyles AllowLeadingSign = 4;
	public const NumberStyles AllowTrailingSign = 8;
	public const NumberStyles AllowParentheses = 16;
	public const NumberStyles AllowDecimalPoint = 32;
	public const NumberStyles AllowThousands = 64;
	public const NumberStyles AllowExponent = 128;
	public const NumberStyles AllowCurrencySymbol = 256;
	public const NumberStyles AllowHexSpecifier = 512;
	public const NumberStyles Integer = 7;
	public const NumberStyles HexNumber = 515;
	public const NumberStyles Number = 111;
	public const NumberStyles Float = 167;
	public const NumberStyles Currency = 383;
	public const NumberStyles Any = 511;
}

// Namespace: System.Globalization
[Serializable]
public sealed class SortVersion : IEquatable<SortVersion> // TypeDefIndex: 4262
{
	// Fields
	private int m_NlsVersion; // 0x10
	private Guid m_SortId; // 0x14

	// Properties
	public int FullVersion { get; }
	public Guid SortId { get; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_FullVersion() { }

	// RVA: 0x10EBEA0 Offset: 0x10EB0A0 VA: 0x1810EBEA0
	public Guid get_SortId() { }

	// RVA: 0x16DC5A0 Offset: 0x16DB7A0 VA: 0x1816DC5A0
	public void .ctor(int fullVersion, Guid sortId) { }

	// RVA: 0x16DC4B0 Offset: 0x16DB6B0 VA: 0x1816DC4B0
	internal void .ctor(int nlsVersion, int effectiveId, Guid customVersion) { }

	// RVA: 0x16DC3D0 Offset: 0x16DB5D0 VA: 0x1816DC3D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x16DC360 Offset: 0x16DB560 VA: 0x1816DC360 Slot: 4
	public bool Equals(SortVersion other) { }

	// RVA: 0x16DC490 Offset: 0x16DB690 VA: 0x1816DC490 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x16DC5E0 Offset: 0x16DB7E0 VA: 0x1816DC5E0
	public static bool op_Equality(SortVersion left, SortVersion right) { }

	// RVA: 0x16DC680 Offset: 0x16DB880 VA: 0x1816DC680
	public static bool op_Inequality(SortVersion left, SortVersion right) { }
}

// Namespace: 
internal enum TimeSpanFormat.Pattern // TypeDefIndex: 4263
{
	// Fields
	public int value__; // 0x0
	public const TimeSpanFormat.Pattern None = 0;
	public const TimeSpanFormat.Pattern Minimum = 1;
	public const TimeSpanFormat.Pattern Full = 2;
}

// Namespace: 
internal struct TimeSpanFormat.FormatLiterals // TypeDefIndex: 4264
{
	// Fields
	internal string AppCompatLiteral; // 0x0
	internal int dd; // 0x8
	internal int hh; // 0xC
	internal int mm; // 0x10
	internal int ss; // 0x14
	internal int ff; // 0x18
	private string[] _literals; // 0x20

	// Properties
	internal string Start { get; }
	internal string DayHourSep { get; }
	internal string HourMinuteSep { get; }
	internal string MinuteSecondSep { get; }
	internal string SecondFractionSep { get; }
	internal string End { get; }

	// Methods

	// RVA: 0x16DB3D0 Offset: 0x16DA5D0 VA: 0x1816DB3D0
	internal string get_Start() { }

	// RVA: 0x16DB2E0 Offset: 0x16DA4E0 VA: 0x1816DB2E0
	internal string get_DayHourSep() { }

	// RVA: 0x16DB340 Offset: 0x16DA540 VA: 0x1816DB340
	internal string get_HourMinuteSep() { }

	// RVA: 0x16DB370 Offset: 0x16DA570 VA: 0x1816DB370
	internal string get_MinuteSecondSep() { }

	// RVA: 0x16DB3A0 Offset: 0x16DA5A0 VA: 0x1816DB3A0
	internal string get_SecondFractionSep() { }

	// RVA: 0x16DB310 Offset: 0x16DA510 VA: 0x1816DB310
	internal string get_End() { }

	// RVA: 0x16DAD40 Offset: 0x16D9F40 VA: 0x1816DAD40
	internal static TimeSpanFormat.FormatLiterals InitInvariant(bool isNegative) { }

	// RVA: 0x16DAF30 Offset: 0x16DA130 VA: 0x1816DAF30
	internal void Init(ReadOnlySpan<char> format, bool useInvariantFieldLengths) { }
}

// Namespace: System.Globalization
internal static class TimeSpanFormat // TypeDefIndex: 4265
{
	// Fields
	internal static readonly TimeSpanFormat.FormatLiterals PositiveInvariantFormatLiterals; // 0x0
	internal static readonly TimeSpanFormat.FormatLiterals NegativeInvariantFormatLiterals; // 0x28

	// Methods

	// RVA: 0x16DC730 Offset: 0x16DB930 VA: 0x1816DC730
	private static void AppendNonNegativeInt32(StringBuilder sb, int n, int digits) { }

	// RVA: 0x16DD880 Offset: 0x16DCA80 VA: 0x1816DD880
	internal static string Format(TimeSpan value, string format, IFormatProvider formatProvider) { }

	// RVA: 0x16DD950 Offset: 0x16DCB50 VA: 0x1816DD950
	internal static bool TryFormat(TimeSpan value, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider formatProvider) { }

	// RVA: 0x16DD530 Offset: 0x16DC730 VA: 0x1816DD530
	private static StringBuilder FormatToBuilder(TimeSpan value, ReadOnlySpan<char> format, IFormatProvider formatProvider) { }

	// RVA: 0x16DCFF0 Offset: 0x16DC1F0 VA: 0x1816DCFF0
	private static StringBuilder FormatStandard(TimeSpan value, bool isInvariant, ReadOnlySpan<char> format, TimeSpanFormat.Pattern pattern) { }

	// RVA: 0x16DC820 Offset: 0x16DBA20 VA: 0x1816DC820
	private static StringBuilder FormatCustomized(TimeSpan value, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, StringBuilder result) { }

	// RVA: 0x16DDA60 Offset: 0x16DCC60 VA: 0x1816DDA60
	private static void .cctor() { }
}

// Namespace: 
private enum TimeSpanParse.ParseFailureKind // TypeDefIndex: 4266
{
	// Fields
	public byte value__; // 0x0
	public const TimeSpanParse.ParseFailureKind None = 0;
	public const TimeSpanParse.ParseFailureKind ArgumentNull = 1;
	public const TimeSpanParse.ParseFailureKind Format = 2;
	public const TimeSpanParse.ParseFailureKind FormatWithParameter = 3;
	public const TimeSpanParse.ParseFailureKind Overflow = 4;
}

// Namespace: 
[Flags]
private enum TimeSpanParse.TimeSpanStandardStyles // TypeDefIndex: 4267
{
	// Fields
	public byte value__; // 0x0
	public const TimeSpanParse.TimeSpanStandardStyles None = 0;
	public const TimeSpanParse.TimeSpanStandardStyles Invariant = 1;
	public const TimeSpanParse.TimeSpanStandardStyles Localized = 2;
	public const TimeSpanParse.TimeSpanStandardStyles RequireFull = 4;
	public const TimeSpanParse.TimeSpanStandardStyles Any = 3;
}

// Namespace: 
private enum TimeSpanParse.TTT // TypeDefIndex: 4268
{
	// Fields
	public byte value__; // 0x0
	public const TimeSpanParse.TTT None = 0;
	public const TimeSpanParse.TTT End = 1;
	public const TimeSpanParse.TTT Num = 2;
	public const TimeSpanParse.TTT Sep = 3;
	public const TimeSpanParse.TTT NumOverflow = 4;
}

// Namespace: 
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
private struct TimeSpanParse.TimeSpanToken // TypeDefIndex: 4269
{
	// Fields
	internal TimeSpanParse.TTT _ttt; // 0x0
	internal int _num; // 0x4
	internal int _zeroes; // 0x8
	internal ReadOnlySpan<char> _sep; // 0x10

	// Methods

	// RVA: 0x16FFE30 Offset: 0x16FF030 VA: 0x1816FFE30
	public void .ctor(TimeSpanParse.TTT type) { }

	// RVA: 0x16FFE80 Offset: 0x16FF080 VA: 0x1816FFE80
	public void .ctor(int number) { }

	// RVA: 0x16FFE40 Offset: 0x16FF040 VA: 0x1816FFE40
	public void .ctor(int number, int leadingZeroes) { }

	// RVA: 0x16FFE60 Offset: 0x16FF060 VA: 0x1816FFE60
	public void .ctor(TimeSpanParse.TTT type, int number, int leadingZeroes, ReadOnlySpan<char> separator) { }

	// RVA: 0x16FFDD0 Offset: 0x16FEFD0 VA: 0x1816FFDD0
	public bool IsInvalidFraction() { }
}

// Namespace: 
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[IsByRefLike]
private struct TimeSpanParse.TimeSpanTokenizer // TypeDefIndex: 4270
{
	// Fields
	private ReadOnlySpan<char> _value; // 0x0
	private int _pos; // 0x10

	// Properties
	internal bool EOL { get; }
	internal char NextChar { get; }

	// Methods

	// RVA: 0x1700100 Offset: 0x16FF300 VA: 0x181700100
	internal void .ctor(ReadOnlySpan<char> input) { }

	// RVA: 0x13144C0 Offset: 0x13136C0 VA: 0x1813144C0
	internal void .ctor(ReadOnlySpan<char> input, int startPosition) { }

	// RVA: 0x16FFEB0 Offset: 0x16FF0B0 VA: 0x1816FFEB0
	internal TimeSpanParse.TimeSpanToken GetNextToken() { }

	// RVA: 0x1700110 Offset: 0x16FF310 VA: 0x181700110
	internal bool get_EOL() { }

	// RVA: 0x16FFEA0 Offset: 0x16FF0A0 VA: 0x1816FFEA0
	internal void BackOne() { }

	// RVA: 0x1700150 Offset: 0x16FF350 VA: 0x181700150
	internal char get_NextChar() { }
}

// Namespace: 
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[IsByRefLike]
private struct TimeSpanParse.TimeSpanRawInfo // TypeDefIndex: 4271
{
	// Fields
	internal TimeSpanParse.TTT _lastSeenTTT; // 0x0
	internal int _tokenCount; // 0x4
	internal int _sepCount; // 0x8
	internal int _numCount; // 0xC
	private TimeSpanFormat.FormatLiterals _posLoc; // 0x10
	private TimeSpanFormat.FormatLiterals _negLoc; // 0x38
	private bool _posLocInit; // 0x60
	private bool _negLocInit; // 0x61
	private string _fullPosPattern; // 0x68
	private string _fullNegPattern; // 0x70
	private const int MaxTokens = 11;
	private const int MaxLiteralTokens = 6;
	private const int MaxNumericTokens = 5;
	internal TimeSpanParse.TimeSpanToken _numbers0; // 0x78
	internal TimeSpanParse.TimeSpanToken _numbers1; // 0x98
	internal TimeSpanParse.TimeSpanToken _numbers2; // 0xB8
	internal TimeSpanParse.TimeSpanToken _numbers3; // 0xD8
	internal TimeSpanParse.TimeSpanToken _numbers4; // 0xF8
	internal ReadOnlySpan<char> _literals0; // 0x118
	internal ReadOnlySpan<char> _literals1; // 0x128
	internal ReadOnlySpan<char> _literals2; // 0x138
	internal ReadOnlySpan<char> _literals3; // 0x148
	internal ReadOnlySpan<char> _literals4; // 0x158
	internal ReadOnlySpan<char> _literals5; // 0x168

	// Properties
	internal TimeSpanFormat.FormatLiterals PositiveInvariant { get; }
	internal TimeSpanFormat.FormatLiterals NegativeInvariant { get; }
	internal TimeSpanFormat.FormatLiterals PositiveLocalized { get; }
	internal TimeSpanFormat.FormatLiterals NegativeLocalized { get; }

	// Methods

	// RVA: 0x16FFB10 Offset: 0x16FED10 VA: 0x1816FFB10
	internal TimeSpanFormat.FormatLiterals get_PositiveInvariant() { }

	// RVA: 0x16FF9D0 Offset: 0x16FEBD0 VA: 0x1816FF9D0
	internal TimeSpanFormat.FormatLiterals get_NegativeInvariant() { }

	// RVA: 0x16FFB80 Offset: 0x16FED80 VA: 0x1816FFB80
	internal TimeSpanFormat.FormatLiterals get_PositiveLocalized() { }

	// RVA: 0x16FFA40 Offset: 0x16FEC40 VA: 0x1816FFA40
	internal TimeSpanFormat.FormatLiterals get_NegativeLocalized() { }

	// RVA: 0x16FE240 Offset: 0x16FD440 VA: 0x1816FE240
	internal bool FullAppCompatMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x16FF590 Offset: 0x16FE790 VA: 0x1816FF590
	internal bool PartialAppCompatMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x16FF200 Offset: 0x16FE400 VA: 0x1816FF200
	internal bool FullMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x16FE9F0 Offset: 0x16FDBF0 VA: 0x1816FE9F0
	internal bool FullDMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x16FEB50 Offset: 0x16FDD50 VA: 0x1816FEB50
	internal bool FullHMMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x16FE500 Offset: 0x16FD700 VA: 0x1816FE500
	internal bool FullDHMMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x16FEFC0 Offset: 0x16FE1C0 VA: 0x1816FEFC0
	internal bool FullHMSMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x16FE740 Offset: 0x16FD940 VA: 0x1816FE740
	internal bool FullDHMSMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x16FED10 Offset: 0x16FDF10 VA: 0x1816FED10
	internal bool FullHMSFMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x16FF530 Offset: 0x16FE730 VA: 0x1816FF530
	internal void Init(DateTimeFormatInfo dtfi) { }

	// RVA: 0x16FF7D0 Offset: 0x16FE9D0 VA: 0x1816FF7D0
	internal bool ProcessToken(ref TimeSpanParse.TimeSpanToken tok, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x16FE0F0 Offset: 0x16FD2F0 VA: 0x1816FE0F0
	private bool AddSep(ReadOnlySpan<char> sep, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x16FDFA0 Offset: 0x16FD1A0 VA: 0x1816FDFA0
	private bool AddNum(TimeSpanParse.TimeSpanToken num, ref TimeSpanParse.TimeSpanResult result) { }
}

// Namespace: 
private struct TimeSpanParse.TimeSpanResult // TypeDefIndex: 4272
{
	// Fields
	internal TimeSpan parsedTimeSpan; // 0x0
	private readonly bool _throwOnFailure; // 0x8

	// Methods

	// RVA: 0x16FFDC0 Offset: 0x16FEFC0 VA: 0x1816FFDC0
	internal void .ctor(bool throwOnFailure) { }

	// RVA: 0x16FFC50 Offset: 0x16FEE50 VA: 0x1816FFC50
	internal bool SetFailure(TimeSpanParse.ParseFailureKind kind, string resourceKey, object messageArgument, string argumentName) { }
}

// Namespace: 
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
private struct TimeSpanParse.StringParser // TypeDefIndex: 4273
{
	// Fields
	private ReadOnlySpan<char> _str; // 0x0
	private char _ch; // 0x10
	private int _pos; // 0x14
	private int _len; // 0x18

	// Methods

	// RVA: 0x16FD6D0 Offset: 0x16FC8D0 VA: 0x1816FD6D0
	internal void NextChar() { }

	// RVA: 0x16FD710 Offset: 0x16FC910 VA: 0x1816FD710
	internal char NextNonDigit() { }

	// RVA: 0x16FDC30 Offset: 0x16FCE30 VA: 0x1816FDC30
	internal bool TryParse(ReadOnlySpan<char> input, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x16FD770 Offset: 0x16FC970 VA: 0x1816FD770
	internal bool ParseInt(int max, out int i, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x16FD860 Offset: 0x16FCA60 VA: 0x1816FD860
	internal bool ParseTime(out long time, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x16FDBD0 Offset: 0x16FCDD0 VA: 0x1816FDBD0
	internal void SkipBlanks() { }
}

// Namespace: System.Globalization
internal static class TimeSpanParse // TypeDefIndex: 4274
{
	// Fields
	private const int MaxFractionDigits = 7;
	private const int MaxDays = 10675199;
	private const int MaxHours = 23;
	private const int MaxMinutes = 59;
	private const int MaxSeconds = 59;
	private const int MaxFraction = 9999999;

	// Methods

	// RVA: 0x16DDE20 Offset: 0x16DD020 VA: 0x1816DDE20
	internal static long Pow10(int pow) { }

	// RVA: 0x16E37F0 Offset: 0x16E29F0 VA: 0x1816E37F0
	private static bool TryTimeToTicks(bool positive, TimeSpanParse.TimeSpanToken days, TimeSpanParse.TimeSpanToken hours, TimeSpanParse.TimeSpanToken minutes, TimeSpanParse.TimeSpanToken seconds, TimeSpanParse.TimeSpanToken fraction, out long result) { }

	// RVA: 0x16DDDC0 Offset: 0x16DCFC0 VA: 0x1816DDDC0
	internal static TimeSpan Parse(ReadOnlySpan<char> input, IFormatProvider formatProvider) { }

	// RVA: 0x16E3760 Offset: 0x16E2960 VA: 0x1816E3760
	internal static bool TryParse(ReadOnlySpan<char> input, IFormatProvider formatProvider, out TimeSpan result) { }

	// RVA: 0x16DDD30 Offset: 0x16DCF30 VA: 0x1816DDD30
	internal static TimeSpan ParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, TimeSpanStyles styles) { }

	// RVA: 0x16E3390 Offset: 0x16E2590 VA: 0x1816E3390
	internal static bool TryParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result) { }

	// RVA: 0x16DDCB0 Offset: 0x16DCEB0 VA: 0x1816DDCB0
	internal static TimeSpan ParseExactMultiple(ReadOnlySpan<char> input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles) { }

	// RVA: 0x16E3150 Offset: 0x16E2350 VA: 0x1816E3150
	internal static bool TryParseExactMultiple(ReadOnlySpan<char> input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result) { }

	// RVA: 0x16E3480 Offset: 0x16E2680 VA: 0x1816E3480
	private static bool TryParseTimeSpan(ReadOnlySpan<char> input, TimeSpanParse.TimeSpanStandardStyles style, IFormatProvider formatProvider, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x16DDF10 Offset: 0x16DD110 VA: 0x1816DDF10
	private static bool ProcessTerminalState(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x16DE080 Offset: 0x16DD280 VA: 0x1816DE080
	private static bool ProcessTerminal_DHMSF(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x16DE890 Offset: 0x16DDA90 VA: 0x1816DE890
	private static bool ProcessTerminal_HMS_F_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x16E04F0 Offset: 0x16DF6F0 VA: 0x1816E04F0
	private static bool ProcessTerminal_HM_S_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x16E2030 Offset: 0x16E1230 VA: 0x1816E2030
	private static bool ProcessTerminal_HM(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x16DE4A0 Offset: 0x16DD6A0 VA: 0x1816DE4A0
	private static bool ProcessTerminal_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x16E3200 Offset: 0x16E2400 VA: 0x1816E3200
	private static bool TryParseExactTimeSpan(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, TimeSpanStyles styles, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x16E2460 Offset: 0x16E1660 VA: 0x1816E2460
	private static bool TryParseByFormat(ReadOnlySpan<char> input, ReadOnlySpan<char> format, TimeSpanStyles styles, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x16DDB90 Offset: 0x16DCD90 VA: 0x1816DDB90
	private static bool ParseExactDigits(ref TimeSpanParse.TimeSpanTokenizer tokenizer, int minDigitLength, out int result) { }

	// RVA: 0x16DDAF0 Offset: 0x16DCCF0 VA: 0x1816DDAF0
	private static bool ParseExactDigits(ref TimeSpanParse.TimeSpanTokenizer tokenizer, int minDigitLength, int maxDigitLength, out int zeroes, out int result) { }

	// RVA: 0x16DDC30 Offset: 0x16DCE30 VA: 0x1816DDC30
	private static bool ParseExactLiteral(ref TimeSpanParse.TimeSpanTokenizer tokenizer, StringBuilder enquotedString) { }

	// RVA: 0x16E3440 Offset: 0x16E2640 VA: 0x1816E3440
	private static bool TryParseTimeSpanConstant(ReadOnlySpan<char> input, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x16E2EE0 Offset: 0x16E20E0 VA: 0x1816E2EE0
	private static bool TryParseExactMultipleTimeSpan(ReadOnlySpan<char> input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x16E3980 Offset: 0x16E2B80 VA: 0x1816E3980
	internal static void ValidateStyles(TimeSpanStyles style, string parameterName) { }
}

// Namespace: System.Globalization
[Flags]
public enum TimeSpanStyles // TypeDefIndex: 4275
{
	// Fields
	public int value__; // 0x0
	public const TimeSpanStyles None = 0;
	public const TimeSpanStyles AssumeNegative = 1;
}

// Namespace: System.Globalization
public enum UnicodeCategory // TypeDefIndex: 4276
{
	// Fields
	public int value__; // 0x0
	public const UnicodeCategory UppercaseLetter = 0;
	public const UnicodeCategory LowercaseLetter = 1;
	public const UnicodeCategory TitlecaseLetter = 2;
	public const UnicodeCategory ModifierLetter = 3;
	public const UnicodeCategory OtherLetter = 4;
	public const UnicodeCategory NonSpacingMark = 5;
	public const UnicodeCategory SpacingCombiningMark = 6;
	public const UnicodeCategory EnclosingMark = 7;
	public const UnicodeCategory DecimalDigitNumber = 8;
	public const UnicodeCategory LetterNumber = 9;
	public const UnicodeCategory OtherNumber = 10;
	public const UnicodeCategory SpaceSeparator = 11;
	public const UnicodeCategory LineSeparator = 12;
	public const UnicodeCategory ParagraphSeparator = 13;
	public const UnicodeCategory Control = 14;
	public const UnicodeCategory Format = 15;
	public const UnicodeCategory Surrogate = 16;
	public const UnicodeCategory PrivateUse = 17;
	public const UnicodeCategory ConnectorPunctuation = 18;
	public const UnicodeCategory DashPunctuation = 19;
	public const UnicodeCategory OpenPunctuation = 20;
	public const UnicodeCategory ClosePunctuation = 21;
	public const UnicodeCategory InitialQuotePunctuation = 22;
	public const UnicodeCategory FinalQuotePunctuation = 23;
	public const UnicodeCategory OtherPunctuation = 24;
	public const UnicodeCategory MathSymbol = 25;
	public const UnicodeCategory CurrencySymbol = 26;
	public const UnicodeCategory ModifierSymbol = 27;
	public const UnicodeCategory OtherSymbol = 28;
	public const UnicodeCategory OtherNotAssigned = 29;
}

// Namespace: System.Globalization
public static class ISOWeek // TypeDefIndex: 4277
{
	// Fields
	private const int WeeksInLongYear = 53;
	private const int WeeksInShortYear = 52;
	private const int MinWeek = 1;
	private const int MaxWeek = 53;

	// Methods

	// RVA: 0x16F8910 Offset: 0x16F7B10 VA: 0x1816F8910
	public static int GetWeekOfYear(DateTime date) { }

	// RVA: 0x16F8B60 Offset: 0x16F7D60 VA: 0x1816F8B60
	public static int GetYear(DateTime date) { }

	// RVA: 0x16F8B50 Offset: 0x16F7D50 VA: 0x1816F8B50
	public static DateTime GetYearStart(int year) { }

	// RVA: 0x16F8B20 Offset: 0x16F7D20 VA: 0x1816F8B20
	public static DateTime GetYearEnd(int year) { }

	// RVA: 0x16F89C0 Offset: 0x16F7BC0 VA: 0x1816F89C0
	public static int GetWeeksInYear(int year) { }

	// RVA: 0x16F8C40 Offset: 0x16F7E40 VA: 0x1816F8C40
	public static DateTime ToDateTime(int year, int week, DayOfWeek dayOfWeek) { }

	// RVA: 0x16F8890 Offset: 0x16F7A90 VA: 0x1816F8890
	private static int GetWeekNumber(DateTime date) { }

	// RVA: 0x16F89B0 Offset: 0x16F7BB0 VA: 0x1816F89B0
	private static int GetWeekday(DayOfWeek dayOfWeek) { }

	[CompilerGenerated]
	// RVA: 0x16F8E70 Offset: 0x16F8070 VA: 0x1816F8E70
	internal static int <GetWeeksInYear>g__P|8_0(int y) { }
}

// Namespace: System.Globalization
internal static class GlobalizationMode // TypeDefIndex: 4278
{
	// Fields
	private const string c_InvariantModeConfigSwitch = "System.Globalization.Invariant";
	[CompilerGenerated]
	private static readonly bool <Invariant>k__BackingField; // 0x0

	// Properties
	internal static bool Invariant { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x16EF8E0 Offset: 0x16EEAE0 VA: 0x1816EF8E0
	internal static bool get_Invariant() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	private static bool GetGlobalizationInvariantMode() { }

	// RVA: 0x16EF8A0 Offset: 0x16EEAA0 VA: 0x1816EF8A0
	private static void .cctor() { }
}

// Namespace: 
private enum CalendricalCalculationsHelper.CorrectionAlgorithm // TypeDefIndex: 4279
{
	// Fields
	public int value__; // 0x0
	public const CalendricalCalculationsHelper.CorrectionAlgorithm Default = 0;
	public const CalendricalCalculationsHelper.CorrectionAlgorithm Year1988to2019 = 1;
	public const CalendricalCalculationsHelper.CorrectionAlgorithm Year1900to1987 = 2;
	public const CalendricalCalculationsHelper.CorrectionAlgorithm Year1800to1899 = 3;
	public const CalendricalCalculationsHelper.CorrectionAlgorithm Year1700to1799 = 4;
	public const CalendricalCalculationsHelper.CorrectionAlgorithm Year1620to1699 = 5;
}

// Namespace: 
private struct CalendricalCalculationsHelper.EphemerisCorrectionAlgorithmMap // TypeDefIndex: 4280
{
	// Fields
	internal int _lowestYear; // 0x0
	internal CalendricalCalculationsHelper.CorrectionAlgorithm _algorithm; // 0x4

	// Methods

	// RVA: 0xD3BAD0 Offset: 0xD3ACD0 VA: 0x180D3BAD0
	public void .ctor(int year, CalendricalCalculationsHelper.CorrectionAlgorithm algorithm) { }
}

// Namespace: System.Globalization
internal class CalendricalCalculationsHelper // TypeDefIndex: 4281
{
	// Fields
	private const double FullCircleOfArc = 360;
	private const int HalfCircleOfArc = 180;
	private const double TwelveHours = 0,5;
	private const double Noon2000Jan01 = 730120,5;
	internal const double MeanTropicalYearInDays = 365,242189;
	private const double MeanSpeedOfSun = 1,0145616361111112;
	private const double LongitudeSpring = 0;
	private const double TwoDegreesAfterSpring = 2;
	private const int SecondsPerDay = 86400;
	private const int DaysInUniformLengthCentury = 36525;
	private const int SecondsPerMinute = 60;
	private const int MinutesPerDegree = 60;
	private static long StartOf1810; // 0x0
	private static long StartOf1900Century; // 0x8
	private static double[] Coefficients1900to1987; // 0x10
	private static double[] Coefficients1800to1899; // 0x18
	private static double[] Coefficients1700to1799; // 0x20
	private static double[] Coefficients1620to1699; // 0x28
	private static double[] LambdaCoefficients; // 0x30
	private static double[] AnomalyCoefficients; // 0x38
	private static double[] EccentricityCoefficients; // 0x40
	private static double[] Coefficients; // 0x48
	private static double[] CoefficientsA; // 0x50
	private static double[] CoefficientsB; // 0x58
	private static CalendricalCalculationsHelper.EphemerisCorrectionAlgorithmMap[] EphemerisCorrectionTable; // 0x60

	// Methods

	// RVA: 0x16EA430 Offset: 0x16E9630 VA: 0x1816EA430
	private static double RadiansFromDegrees(double degree) { }

	// RVA: 0x16EA4C0 Offset: 0x16E96C0 VA: 0x1816EA4C0
	private static double SinOfDegree(double degree) { }

	// RVA: 0x16E8BD0 Offset: 0x16E7DD0 VA: 0x1816E8BD0
	private static double CosOfDegree(double degree) { }

	// RVA: 0x16EB8C0 Offset: 0x16EAAC0 VA: 0x1816EB8C0
	private static double TanOfDegree(double degree) { }

	// RVA: 0x16E8680 Offset: 0x16E7880 VA: 0x1816E8680
	public static double Angle(int degrees, int minutes, double seconds) { }

	// RVA: 0x16EA090 Offset: 0x16E9290 VA: 0x1816EA090
	private static double Obliquity(double julianCenturies) { }

	// RVA: 0x16E9AB0 Offset: 0x16E8CB0 VA: 0x1816E9AB0
	internal static long GetNumberOfDays(DateTime date) { }

	// RVA: 0x16E99D0 Offset: 0x16E8BD0 VA: 0x1816E99D0
	private static int GetGregorianYear(double numberOfDays) { }

	// RVA: 0x16EA450 Offset: 0x16E9650 VA: 0x1816EA450
	private static double Reminder(double divisor, double dividend) { }

	// RVA: 0x16E9E90 Offset: 0x16E9090 VA: 0x1816E9E90
	private static double NormalizeLongitude(double longitude) { }

	// RVA: 0x16E86B0 Offset: 0x16E78B0 VA: 0x1816E86B0
	public static double AsDayFraction(double longitude) { }

	// RVA: 0x16EA3C0 Offset: 0x16E95C0 VA: 0x1816EA3C0
	private static double PolynomialSum(double[] coefficients, double indeterminate) { }

	// RVA: 0x16E8760 Offset: 0x16E7960 VA: 0x1816E8760
	private static double CenturiesFrom1900(int gregorianYear) { }

	// RVA: 0x16E8C50 Offset: 0x16E7E50 VA: 0x1816E8C50
	private static double DefaultEphemerisCorrection(int gregorianYear) { }

	// RVA: 0x16E90A0 Offset: 0x16E82A0 VA: 0x1816E90A0
	private static double EphemerisCorrection1988to2019(int gregorianYear) { }

	// RVA: 0x16E8FE0 Offset: 0x16E81E0 VA: 0x1816E8FE0
	private static double EphemerisCorrection1900to1987(int gregorianYear) { }

	// RVA: 0x16E8F20 Offset: 0x16E8120 VA: 0x1816E8F20
	private static double EphemerisCorrection1800to1899(int gregorianYear) { }

	// RVA: 0x16E8E50 Offset: 0x16E8050 VA: 0x1816E8E50
	private static double EphemerisCorrection1700to1799(int gregorianYear) { }

	// RVA: 0x16E8D80 Offset: 0x16E7F80 VA: 0x1816E8D80
	private static double EphemerisCorrection1620to1699(int gregorianYear) { }

	// RVA: 0x16E90C0 Offset: 0x16E82C0 VA: 0x1816E90C0
	private static double EphemerisCorrection(double time) { }

	// RVA: 0x16E9C60 Offset: 0x16E8E60 VA: 0x1816E9C60
	public static double JulianCenturies(double moment) { }

	// RVA: 0x16E9C00 Offset: 0x16E8E00 VA: 0x1816E9C00
	private static bool IsNegative(double value) { }

	// RVA: 0x16E8AE0 Offset: 0x16E7CE0 VA: 0x1816E8AE0
	private static double CopySign(double value, double sign) { }

	// RVA: 0x16E9350 Offset: 0x16E8550 VA: 0x1816E9350
	private static double EquationOfTime(double time) { }

	// RVA: 0x16E86C0 Offset: 0x16E78C0 VA: 0x1816E86C0
	private static double AsLocalTime(double apparentMidday, double longitude) { }

	// RVA: 0x16E9DD0 Offset: 0x16E8FD0 VA: 0x1816E9DD0
	public static double Midday(double date, double longitude) { }

	// RVA: 0x16E9B10 Offset: 0x16E8D10 VA: 0x1816E9B10
	private static double InitLongitude(double longitude) { }

	// RVA: 0x16E9CD0 Offset: 0x16E8ED0 VA: 0x1816E9CD0
	public static double MiddayAtPersianObservationSite(double date) { }

	// RVA: 0x16EA150 Offset: 0x16E9350 VA: 0x1816EA150
	private static double PeriodicTerm(double julianCenturies, int x, double y, double z) { }

	// RVA: 0x16EA540 Offset: 0x16E9740 VA: 0x1816EA540
	private static double SumLongSequenceOfPeriodicTerms(double julianCenturies) { }

	// RVA: 0x16E8600 Offset: 0x16E7800 VA: 0x1816E8600
	private static double Aberration(double julianCenturies) { }

	// RVA: 0x16E9F40 Offset: 0x16E9140 VA: 0x1816E9F40
	private static double Nutation(double julianCenturies) { }

	// RVA: 0x16E8840 Offset: 0x16E7A40 VA: 0x1816E8840
	public static double Compute(double time) { }

	// RVA: 0x16E8740 Offset: 0x16E7940 VA: 0x1816E8740
	public static double AsSeason(double longitude) { }

	// RVA: 0x16E98E0 Offset: 0x16E8AE0 VA: 0x1816E98E0
	private static double EstimatePrior(double longitude, double time) { }

	// RVA: 0x16EA1E0 Offset: 0x16E93E0 VA: 0x1816EA1E0
	internal static long PersianNewYearOnOrBefore(long numberOfDays) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x16EB940 Offset: 0x16EAB40 VA: 0x1816EB940
	private static void .cctor() { }
}

// Namespace: System.Globalization
[Serializable]
public class PersianCalendar : Calendar // TypeDefIndex: 4282
{
	// Fields
	public static readonly int PersianEra; // 0x0
	internal static long PersianEpoch; // 0x8
	private const int ApproximateHalfYear = 180;
	internal const int DatePartYear = 0;
	internal const int DatePartDayOfYear = 1;
	internal const int DatePartMonth = 2;
	internal const int DatePartDay = 3;
	internal const int MonthsPerYear = 12;
	internal static int[] DaysToMonth; // 0x10
	internal const int MaxCalendarYear = 9378;
	internal const int MaxCalendarMonth = 10;
	internal const int MaxCalendarDay = 13;
	internal static DateTime minDate; // 0x18
	internal static DateTime maxDate; // 0x20
	private const int DEFAULT_TWO_DIGIT_YEAR_MAX = 1410;

	// Properties
	public override DateTime MinSupportedDateTime { get; }
	public override DateTime MaxSupportedDateTime { get; }
	public override CalendarAlgorithmType AlgorithmType { get; }
	internal override int BaseCalendarID { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x16FD4F0 Offset: 0x16FC6F0 VA: 0x1816FD4F0 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x16FD4A0 Offset: 0x16FC6A0 VA: 0x1816FD4A0 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 9
	public override CalendarAlgorithmType get_AlgorithmType() { }

	// RVA: 0x16E82A0 Offset: 0x16E74A0 VA: 0x1816E82A0
	public void .ctor() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 8
	internal override int get_BaseCalendarID() { }

	// RVA: 0x16FD490 Offset: 0x16FC690 VA: 0x1816FD490 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x16FC1C0 Offset: 0x16FB3C0 VA: 0x1816FC1C0
	private long GetAbsoluteDatePersian(int year, int month, int day) { }

	// RVA: 0x16FBB80 Offset: 0x16FAD80 VA: 0x1816FBB80
	internal static void CheckTicksRange(long ticks) { }

	// RVA: 0x16FBAB0 Offset: 0x16FACB0 VA: 0x1816FBAB0
	internal static void CheckEraRange(int era) { }

	// RVA: 0x16FBF50 Offset: 0x16FB150 VA: 0x1816FBF50
	internal static void CheckYearRange(int year, int era) { }

	// RVA: 0x16FBD80 Offset: 0x16FAF80 VA: 0x1816FBD80
	internal static void CheckYearMonthRange(int year, int month, int era) { }

	// RVA: 0x16FCE30 Offset: 0x16FC030 VA: 0x1816FCE30
	private static int MonthFromOrdinalDay(int ordinalDay) { }

	// RVA: 0x16FC140 Offset: 0x16FB340 VA: 0x1816FC140
	private static int DaysInPreviousMonths(int month) { }

	// RVA: 0x16FC300 Offset: 0x16FB500 VA: 0x1816FC300
	internal int GetDatePart(long ticks, int part) { }

	// RVA: 0x16FB7B0 Offset: 0x16FA9B0 VA: 0x1816FB7B0 Slot: 16
	public override DateTime AddMonths(DateTime time, int months) { }

	// RVA: 0x16F1F20 Offset: 0x16F1120 VA: 0x1816F1F20 Slot: 19
	public override DateTime AddYears(DateTime time, int years) { }

	// RVA: 0x16FC5E0 Offset: 0x16FB7E0 VA: 0x1816FC5E0 Slot: 20
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x16FC650 Offset: 0x16FB850 VA: 0x1816FC650 Slot: 21
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x16FC6D0 Offset: 0x16FB8D0 VA: 0x1816FC6D0 Slot: 22
	public override int GetDayOfYear(DateTime time) { }

	// RVA: 0x16FC740 Offset: 0x16FB940 VA: 0x1816FC740 Slot: 24
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x16FC850 Offset: 0x16FBA50 VA: 0x1816FC850 Slot: 26
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x16FC940 Offset: 0x16FBB40 VA: 0x1816FC940 Slot: 27
	public override int GetEra(DateTime time) { }

	// RVA: 0x16FD400 Offset: 0x16FC600 VA: 0x1816FD400 Slot: 28
	public override int[] get_Eras() { }

	// RVA: 0x16FCA30 Offset: 0x16FBC30 VA: 0x1816FCA30 Slot: 32
	public override int GetMonth(DateTime time) { }

	// RVA: 0x16FCAA0 Offset: 0x16FBCA0 VA: 0x1816FCAA0 Slot: 34
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x16FCB10 Offset: 0x16FBD10 VA: 0x1816FCB10 Slot: 38
	public override int GetYear(DateTime time) { }

	// RVA: 0x16FCB80 Offset: 0x16FBD80 VA: 0x1816FCB80 Slot: 40
	public override bool IsLeapDay(int year, int month, int day, int era) { }

	// RVA: 0x16FC9D0 Offset: 0x16FBBD0 VA: 0x1816FC9D0 Slot: 44
	public override int GetLeapMonth(int year, int era) { }

	// RVA: 0x16FCCF0 Offset: 0x16FBEF0 VA: 0x1816FCCF0 Slot: 42
	public override bool IsLeapMonth(int year, int month, int era) { }

	// RVA: 0x16FCD60 Offset: 0x16FBF60 VA: 0x1816FCD60 Slot: 46
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x16FCED0 Offset: 0x16FC0D0 VA: 0x1816FCED0 Slot: 48
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x16FD540 Offset: 0x16FC740 VA: 0x1816FD540 Slot: 53
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x16FD5B0 Offset: 0x16FC7B0 VA: 0x1816FD5B0 Slot: 54
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x16FD0E0 Offset: 0x16FC2E0 VA: 0x1816FD0E0 Slot: 55
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x16FD280 Offset: 0x16FC480 VA: 0x1816FD280
	private static void .cctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public abstract class Calendar : ICloneable // TypeDefIndex: 4283
{
	// Fields
	internal const long TicksPerMillisecond = 10000;
	internal const long TicksPerSecond = 10000000;
	internal const long TicksPerMinute = 600000000;
	internal const long TicksPerHour = 36000000000;
	internal const long TicksPerDay = 864000000000;
	internal const int MillisPerSecond = 1000;
	internal const int MillisPerMinute = 60000;
	internal const int MillisPerHour = 3600000;
	internal const int MillisPerDay = 86400000;
	internal const int DaysPerYear = 365;
	internal const int DaysPer4Years = 1461;
	internal const int DaysPer100Years = 36524;
	internal const int DaysPer400Years = 146097;
	internal const int DaysTo10000 = 3652059;
	internal const long MaxMillis = 315537897600000;
	internal const int CAL_GREGORIAN = 1;
	internal const int CAL_GREGORIAN_US = 2;
	internal const int CAL_JAPAN = 3;
	internal const int CAL_TAIWAN = 4;
	internal const int CAL_KOREA = 5;
	internal const int CAL_HIJRI = 6;
	internal const int CAL_THAI = 7;
	internal const int CAL_HEBREW = 8;
	internal const int CAL_GREGORIAN_ME_FRENCH = 9;
	internal const int CAL_GREGORIAN_ARABIC = 10;
	internal const int CAL_GREGORIAN_XLIT_ENGLISH = 11;
	internal const int CAL_GREGORIAN_XLIT_FRENCH = 12;
	internal const int CAL_JULIAN = 13;
	internal const int CAL_JAPANESELUNISOLAR = 14;
	internal const int CAL_CHINESELUNISOLAR = 15;
	internal const int CAL_SAKA = 16;
	internal const int CAL_LUNAR_ETO_CHN = 17;
	internal const int CAL_LUNAR_ETO_KOR = 18;
	internal const int CAL_LUNAR_ETO_ROKUYOU = 19;
	internal const int CAL_KOREANLUNISOLAR = 20;
	internal const int CAL_TAIWANLUNISOLAR = 21;
	internal const int CAL_PERSIAN = 22;
	internal const int CAL_UMALQURA = 23;
	internal int m_currentEraValue; // 0x10
	[OptionalField(VersionAdded = 2)]
	private bool m_isReadOnly; // 0x14
	public const int CurrentEra = 0;
	internal int twoDigitYearMax; // 0x18

	// Properties
	[ComVisible(False)]
	public virtual DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public virtual DateTime MaxSupportedDateTime { get; }
	internal virtual int ID { get; }
	internal virtual int BaseCalendarID { get; }
	[ComVisible(False)]
	public virtual CalendarAlgorithmType AlgorithmType { get; }
	[ComVisible(False)]
	public bool IsReadOnly { get; }
	internal virtual int CurrentEraValue { get; }
	public abstract int[] Eras { get; }
	protected virtual int DaysInYearBeforeMinSupportedYear { get; }
	public virtual int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x16E8580 Offset: 0x16E7780 VA: 0x1816E8580 Slot: 5
	public virtual DateTime get_MinSupportedDateTime() { }

	// RVA: 0x16E8530 Offset: 0x16E7730 VA: 0x1816E8530 Slot: 6
	public virtual DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x16E82A0 Offset: 0x16E74A0 VA: 0x1816E82A0
	protected void .ctor() { }

	// RVA: 0x729380 Offset: 0x728580 VA: 0x180729380 Slot: 7
	internal virtual int get_ID() { }

	// RVA: 0x82EEC0 Offset: 0x82E0C0 VA: 0x18082EEC0 Slot: 8
	internal virtual int get_BaseCalendarID() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 9
	public virtual CalendarAlgorithmType get_AlgorithmType() { }

	// RVA: 0x41AC30 Offset: 0x419E30 VA: 0x18041AC30
	public bool get_IsReadOnly() { }

	[ComVisible(False)]
	// RVA: 0x16E6D70 Offset: 0x16E5F70 VA: 0x1816E6D70 Slot: 10
	public virtual object Clone() { }

	[ComVisible(False)]
	// RVA: 0x16E7CE0 Offset: 0x16E6EE0 VA: 0x1816E7CE0
	public static Calendar ReadOnly(Calendar calendar) { }

	// RVA: 0x16E8220 Offset: 0x16E7420 VA: 0x1816E8220
	internal void VerifyWritable() { }

	// RVA: 0x41AC60 Offset: 0x419E60 VA: 0x18041AC60
	internal void SetReadOnlyState(bool readOnly) { }

	// RVA: 0x16E82C0 Offset: 0x16E74C0 VA: 0x1816E82C0 Slot: 11
	internal virtual int get_CurrentEraValue() { }

	// RVA: 0x16E6C00 Offset: 0x16E5E00 VA: 0x1816E6C00
	internal static void CheckAddResult(long ticks, DateTime minValue, DateTime maxValue) { }

	// RVA: 0x16E6A60 Offset: 0x16E5C60 VA: 0x1816E6A60
	internal DateTime Add(DateTime time, double value, int scale) { }

	// RVA: 0x16E69C0 Offset: 0x16E5BC0 VA: 0x1816E69C0 Slot: 12
	public virtual DateTime AddMilliseconds(DateTime time, double milliseconds) { }

	// RVA: 0x16E6960 Offset: 0x16E5B60 VA: 0x1816E6960 Slot: 13
	public virtual DateTime AddDays(DateTime time, int days) { }

	// RVA: 0x16E6990 Offset: 0x16E5B90 VA: 0x1816E6990 Slot: 14
	public virtual DateTime AddHours(DateTime time, int hours) { }

	// RVA: 0x16E69E0 Offset: 0x16E5BE0 VA: 0x1816E69E0 Slot: 15
	public virtual DateTime AddMinutes(DateTime time, int minutes) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract DateTime AddMonths(DateTime time, int months);

	// RVA: 0x16E6A10 Offset: 0x16E5C10 VA: 0x1816E6A10 Slot: 17
	public virtual DateTime AddSeconds(DateTime time, int seconds) { }

	// RVA: 0x16E6A40 Offset: 0x16E5C40 VA: 0x1816E6A40 Slot: 18
	public virtual DateTime AddWeeks(DateTime time, int weeks) { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract DateTime AddYears(DateTime time, int years);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract int GetDayOfMonth(DateTime time);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract DayOfWeek GetDayOfWeek(DateTime time);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract int GetDayOfYear(DateTime time);

	// RVA: 0x16E6E50 Offset: 0x16E6050 VA: 0x1816E6E50 Slot: 23
	public virtual int GetDaysInMonth(int year, int month) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract int GetDaysInMonth(int year, int month, int era);

	// RVA: 0x16E6E80 Offset: 0x16E6080 VA: 0x1816E6E80 Slot: 25
	public virtual int GetDaysInYear(int year) { }

	// RVA: -1 Offset: -1 Slot: 26
	public abstract int GetDaysInYear(int year, int era);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract int GetEra(DateTime time);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract int[] get_Eras();

	// RVA: 0x16E6F60 Offset: 0x16E6160 VA: 0x1816E6F60 Slot: 29
	public virtual int GetHour(DateTime time) { }

	// RVA: 0x16E70D0 Offset: 0x16E62D0 VA: 0x1816E70D0 Slot: 30
	public virtual double GetMilliseconds(DateTime time) { }

	// RVA: 0x16E7170 Offset: 0x16E6370 VA: 0x1816E7170 Slot: 31
	public virtual int GetMinute(DateTime time) { }

	// RVA: -1 Offset: -1 Slot: 32
	public abstract int GetMonth(DateTime time);

	// RVA: 0x16E7210 Offset: 0x16E6410 VA: 0x1816E7210 Slot: 33
	public virtual int GetMonthsInYear(int year) { }

	// RVA: -1 Offset: -1 Slot: 34
	public abstract int GetMonthsInYear(int year, int era);

	// RVA: 0x16E7230 Offset: 0x16E6430 VA: 0x1816E7230 Slot: 35
	public virtual int GetSecond(DateTime time) { }

	// RVA: 0x16E6EA0 Offset: 0x16E60A0 VA: 0x1816E6EA0
	internal int GetFirstDayWeekOfYear(DateTime time, int firstDayOfWeek) { }

	// RVA: 0x16E7320 Offset: 0x16E6520 VA: 0x1816E7320
	private int GetWeekOfYearFullDays(DateTime time, int firstDayOfWeek, int fullDays) { }

	// RVA: 0x16E7620 Offset: 0x16E6820 VA: 0x1816E7620
	private int GetWeekOfYearOfMinSupportedDateTime(int firstDayOfWeek, int minimumDaysInFirstWeek) { }

	// RVA: 0x16E8520 Offset: 0x16E7720 VA: 0x1816E8520 Slot: 36
	protected virtual int get_DaysInYearBeforeMinSupportedYear() { }

	// RVA: 0x16E7790 Offset: 0x16E6990 VA: 0x1816E7790 Slot: 37
	public virtual int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek) { }

	// RVA: -1 Offset: -1 Slot: 38
	public abstract int GetYear(DateTime time);

	// RVA: 0x16E7AC0 Offset: 0x16E6CC0 VA: 0x1816E7AC0 Slot: 39
	public virtual bool IsLeapDay(int year, int month, int day) { }

	// RVA: -1 Offset: -1 Slot: 40
	public abstract bool IsLeapDay(int year, int month, int day, int era);

	// RVA: 0x16E7AF0 Offset: 0x16E6CF0 VA: 0x1816E7AF0 Slot: 41
	public virtual bool IsLeapMonth(int year, int month) { }

	// RVA: -1 Offset: -1 Slot: 42
	public abstract bool IsLeapMonth(int year, int month, int era);

	[ComVisible(False)]
	// RVA: 0x16E6FF0 Offset: 0x16E61F0 VA: 0x1816E6FF0 Slot: 43
	public virtual int GetLeapMonth(int year) { }

	[ComVisible(False)]
	// RVA: 0x16E7010 Offset: 0x16E6210 VA: 0x1816E7010 Slot: 44
	public virtual int GetLeapMonth(int year, int era) { }

	// RVA: 0x16E7B20 Offset: 0x16E6D20 VA: 0x1816E7B20 Slot: 45
	public virtual bool IsLeapYear(int year) { }

	// RVA: -1 Offset: -1 Slot: 46
	public abstract bool IsLeapYear(int year, int era);

	// RVA: 0x16E7FB0 Offset: 0x16E71B0 VA: 0x1816E7FB0 Slot: 47
	public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond) { }

	// RVA: -1 Offset: -1 Slot: 48
	public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);

	// RVA: 0x16E8120 Offset: 0x16E7320 VA: 0x1816E8120 Slot: 49
	internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	// RVA: 0x16E7C50 Offset: 0x16E6E50 VA: 0x1816E7C50 Slot: 50
	internal virtual bool IsValidYear(int year, int era) { }

	// RVA: 0x16E7BD0 Offset: 0x16E6DD0 VA: 0x1816E7BD0 Slot: 51
	internal virtual bool IsValidMonth(int year, int month, int era) { }

	// RVA: 0x16E7B40 Offset: 0x16E6D40 VA: 0x1816E7B40 Slot: 52
	internal virtual bool IsValidDay(int year, int month, int day, int era) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 53
	public virtual int get_TwoDigitYearMax() { }

	// RVA: 0x16E85D0 Offset: 0x16E77D0 VA: 0x1816E85D0 Slot: 54
	public virtual void set_TwoDigitYearMax(int value) { }

	// RVA: 0x16E8010 Offset: 0x16E7210 VA: 0x1816E8010 Slot: 55
	public virtual int ToFourDigitYear(int year) { }

	// RVA: 0x16E7DE0 Offset: 0x16E6FE0 VA: 0x1816E7DE0
	internal static long TimeToTicks(int hour, int minute, int second, int millisecond) { }

	// RVA: 0x16E72D0 Offset: 0x16E64D0 VA: 0x1816E72D0
	internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue) { }
}

// Namespace: System.Globalization
internal class CalendarData // TypeDefIndex: 4284
{
	// Fields
	internal const int MAX_CALENDARS = 23;
	internal string sNativeName; // 0x10
	internal string[] saShortDates; // 0x18
	internal string[] saYearMonths; // 0x20
	internal string[] saLongDates; // 0x28
	internal string sMonthDay; // 0x30
	internal string[] saEraNames; // 0x38
	internal string[] saAbbrevEraNames; // 0x40
	internal string[] saAbbrevEnglishEraNames; // 0x48
	internal string[] saDayNames; // 0x50
	internal string[] saAbbrevDayNames; // 0x58
	internal string[] saSuperShortDayNames; // 0x60
	internal string[] saMonthNames; // 0x68
	internal string[] saAbbrevMonthNames; // 0x70
	internal string[] saMonthGenitiveNames; // 0x78
	internal string[] saAbbrevMonthGenitiveNames; // 0x80
	internal string[] saLeapYearMonthNames; // 0x88
	internal int iTwoDigitYearMax; // 0x90
	internal int iCurrentEra; // 0x94
	internal bool bUseUserOverrides; // 0x98
	internal static CalendarData Invariant; // 0x0
	private static string[] HEBREW_MONTH_NAMES; // 0x8
	private static string[] HEBREW_LEAP_MONTH_NAMES; // 0x10

	// Methods

	// RVA: 0x16E6850 Offset: 0x16E5A50 VA: 0x1816E6850
	private void .ctor() { }

	// RVA: 0x16E53E0 Offset: 0x16E45E0 VA: 0x1816E53E0
	private static void .cctor() { }

	// RVA: 0x16E6030 Offset: 0x16E5230 VA: 0x1816E6030
	internal void .ctor(string localeName, int calendarId, bool bUseUserOverrides) { }

	// RVA: 0x16E4E40 Offset: 0x16E4040 VA: 0x1816E4E40
	private void InitializeEraNames(string localeName, int calendarId) { }

	// RVA: 0x16E4930 Offset: 0x16E3B30 VA: 0x1816E4930
	private static string[] GetJapaneseEraNames() { }

	// RVA: 0x16E4790 Offset: 0x16E3990 VA: 0x1816E4790
	private static string[] GetJapaneseEnglishEraNames() { }

	// RVA: 0x16E4AD0 Offset: 0x16E3CD0 VA: 0x1816E4AD0
	private void InitializeAbbreviatedEraNames(string localeName, int calendarId) { }

	// RVA: 0x16E45A0 Offset: 0x16E37A0 VA: 0x1816E45A0
	internal static CalendarData GetCalendarData(int calendarId) { }

	// RVA: 0x16E4410 Offset: 0x16E3610 VA: 0x1816E4410
	private static string CalendarIdToCultureName(int calendarId) { }

	// RVA: 0x729380 Offset: 0x728580 VA: 0x180729380
	public static int nativeGetTwoDigitYearMax(int calID) { }

	// RVA: 0x16E6880 Offset: 0x16E5A80 VA: 0x1816E6880
	private static bool nativeGetCalendarData(CalendarData data, string localeName, int calendarId) { }

	// RVA: 0x16E6870 Offset: 0x16E5A70 VA: 0x1816E6870
	private bool fill_calendar_data(string localeName, int datetimeIndex) { }
}

// Namespace: System.Globalization
[Serializable]
public class ChineseLunisolarCalendar : EastAsianLunisolarCalendar // TypeDefIndex: 4285
{
	// Fields
	public const int ChineseEra = 1;
	internal const int MIN_LUNISOLAR_YEAR = 1901;
	internal const int MAX_LUNISOLAR_YEAR = 2100;
	internal const int MIN_GREGORIAN_YEAR = 1901;
	internal const int MIN_GREGORIAN_MONTH = 2;
	internal const int MIN_GREGORIAN_DAY = 19;
	internal const int MAX_GREGORIAN_YEAR = 2101;
	internal const int MAX_GREGORIAN_MONTH = 1;
	internal const int MAX_GREGORIAN_DAY = 28;
	internal static DateTime minDate; // 0x0
	internal static DateTime maxDate; // 0x8
	private static readonly int[,] yinfo; // 0x10

	// Properties
	[ComVisible(False)]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime { get; }
	protected override int DaysInYearBeforeMinSupportedYear { get; }
	internal override int MinCalendarYear { get; }
	internal override int MaxCalendarYear { get; }
	internal override DateTime MinDate { get; }
	internal override DateTime MaxDate { get; }
	internal override EraInfo[] CalEraInfo { get; }
	internal override int ID { get; }
	internal override int BaseCalendarID { get; }
	[ComVisible(False)]
	public override int[] Eras { get; }

	// Methods

	// RVA: 0x16EC5B0 Offset: 0x16EB7B0 VA: 0x1816EC5B0 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x16EC500 Offset: 0x16EB700 VA: 0x1816EC500 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x16EC420 Offset: 0x16EB620 VA: 0x1816EC420 Slot: 36
	protected override int get_DaysInYearBeforeMinSupportedYear() { }

	// RVA: 0x16EC550 Offset: 0x16EB750 VA: 0x1816EC550 Slot: 60
	internal override int get_MinCalendarYear() { }

	// RVA: 0x16EC4A0 Offset: 0x16EB6A0 VA: 0x1816EC4A0 Slot: 61
	internal override int get_MaxCalendarYear() { }

	// RVA: 0x16EC560 Offset: 0x16EB760 VA: 0x1816EC560 Slot: 63
	internal override DateTime get_MinDate() { }

	// RVA: 0x16EC4B0 Offset: 0x16EB6B0 VA: 0x1816EC4B0 Slot: 64
	internal override DateTime get_MaxDate() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 62
	internal override EraInfo[] get_CalEraInfo() { }

	// RVA: 0x16EC090 Offset: 0x16EB290 VA: 0x1816EC090 Slot: 57
	internal override int GetYearInfo(int LunarYear, int Index) { }

	// RVA: 0x1529D90 Offset: 0x1528F90 VA: 0x181529D90 Slot: 58
	internal override int GetYear(int year, DateTime time) { }

	// RVA: 0x16EBF10 Offset: 0x16EB110 VA: 0x1816EBF10 Slot: 59
	internal override int GetGregorianYear(int year, int era) { }

	// RVA: 0x16EC3C0 Offset: 0x16EB5C0 VA: 0x1816EC3C0
	public void .ctor() { }

	[ComVisible(False)]
	// RVA: 0x16EBEA0 Offset: 0x16EB0A0 VA: 0x1816EBEA0 Slot: 27
	public override int GetEra(DateTime time) { }

	// RVA: 0x16EC490 Offset: 0x16EB690 VA: 0x1816EC490 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 8
	internal override int get_BaseCalendarID() { }

	// RVA: 0x16EC430 Offset: 0x16EB630 VA: 0x1816EC430 Slot: 28
	public override int[] get_Eras() { }

	// RVA: 0x16EC230 Offset: 0x16EB430 VA: 0x1816EC230
	private static void .cctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public abstract class EastAsianLunisolarCalendar : Calendar // TypeDefIndex: 4286
{
	// Fields
	internal const int LeapMonth = 0;
	internal const int Jan1Month = 1;
	internal const int Jan1Date = 2;
	internal const int nDaysPerMonth = 3;
	internal static readonly int[] DaysToMonth365; // 0x0
	internal static readonly int[] DaysToMonth366; // 0x8
	internal const int DatePartYear = 0;
	internal const int DatePartDayOfYear = 1;
	internal const int DatePartMonth = 2;
	internal const int DatePartDay = 3;
	internal const int MaxCalendarMonth = 13;
	internal const int MaxCalendarDay = 30;
	private const int DEFAULT_GREGORIAN_TWO_DIGIT_YEAR_MAX = 2029;

	// Properties
	public override CalendarAlgorithmType AlgorithmType { get; }
	internal abstract int MinCalendarYear { get; }
	internal abstract int MaxCalendarYear { get; }
	internal abstract EraInfo[] CalEraInfo { get; }
	internal abstract DateTime MinDate { get; }
	internal abstract DateTime MaxDate { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0xCCA530 Offset: 0xCC9730 VA: 0x180CCA530 Slot: 9
	public override CalendarAlgorithmType get_AlgorithmType() { }

	// RVA: 0x16EDC00 Offset: 0x16ECE00 VA: 0x1816EDC00 Slot: 56
	public virtual int GetSexagenaryYear(DateTime time) { }

	// RVA: 0x16ED370 Offset: 0x16EC570 VA: 0x1816ED370
	public int GetCelestialStem(int sexagenaryYear) { }

	// RVA: 0x16EDDA0 Offset: 0x16ECFA0 VA: 0x1816EDDA0
	public int GetTerrestrialBranch(int sexagenaryYear) { }

	// RVA: -1 Offset: -1 Slot: 57
	internal abstract int GetYearInfo(int LunarYear, int Index);

	// RVA: -1 Offset: -1 Slot: 58
	internal abstract int GetYear(int year, DateTime time);

	// RVA: -1 Offset: -1 Slot: 59
	internal abstract int GetGregorianYear(int year, int era);

	// RVA: -1 Offset: -1 Slot: 60
	internal abstract int get_MinCalendarYear();

	// RVA: -1 Offset: -1 Slot: 61
	internal abstract int get_MaxCalendarYear();

	// RVA: -1 Offset: -1 Slot: 62
	internal abstract EraInfo[] get_CalEraInfo();

	// RVA: -1 Offset: -1 Slot: 63
	internal abstract DateTime get_MinDate();

	// RVA: -1 Offset: -1 Slot: 64
	internal abstract DateTime get_MaxDate();

	// RVA: 0x16EECA0 Offset: 0x16EDEA0 VA: 0x1816EECA0
	internal int MinEraCalendarYear(int era) { }

	// RVA: 0x16EEAD0 Offset: 0x16EDCD0 VA: 0x1816EEAD0
	internal int MaxEraCalendarYear(int era) { }

	// RVA: 0x16E82A0 Offset: 0x16E74A0 VA: 0x1816E82A0
	internal void .ctor() { }

	// RVA: 0x16ECDE0 Offset: 0x16EBFE0 VA: 0x1816ECDE0
	internal void CheckTicksRange(long ticks) { }

	// RVA: 0x16ECCE0 Offset: 0x16EBEE0 VA: 0x1816ECCE0
	internal void CheckEraRange(int era) { }

	// RVA: 0x16ED0E0 Offset: 0x16EC2E0 VA: 0x1816ED0E0
	internal int CheckYearRange(int year, int era) { }

	// RVA: 0x16ECFA0 Offset: 0x16EC1A0 VA: 0x1816ECFA0
	internal int CheckYearMonthRange(int year, int month, int era) { }

	// RVA: 0x16EE430 Offset: 0x16ED630 VA: 0x1816EE430
	internal int InternalGetDaysInMonth(int year, int month) { }

	// RVA: 0x16ED8E0 Offset: 0x16ECAE0 VA: 0x1816ED8E0 Slot: 24
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x16EE0A0 Offset: 0x16ED2A0 VA: 0x1816EE0A0
	private static int GregorianIsLeapYear(int y) { }

	// RVA: 0x16EEF90 Offset: 0x16EE190 VA: 0x1816EEF90 Slot: 48
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x16EE100 Offset: 0x16ED300 VA: 0x1816EE100
	internal void GregorianToLunar(int nSYear, int nSMonth, int nSDate, ref int nLYear, ref int nLMonth, ref int nLDate) { }

	// RVA: 0x16EE6F0 Offset: 0x16ED8F0 VA: 0x1816EE6F0
	internal bool LunarToGregorian(int nLYear, int nLMonth, int nLDate, ref int nSolarYear, ref int nSolarMonth, ref int nSolarDay) { }

	// RVA: 0x16EE960 Offset: 0x16EDB60 VA: 0x1816EE960
	internal DateTime LunarToTime(DateTime time, int year, int month, int day) { }

	// RVA: 0x16EEE70 Offset: 0x16EE070 VA: 0x1816EEE70
	internal void TimeToLunar(DateTime time, ref int year, ref int month, ref int day) { }

	// RVA: 0x16EC600 Offset: 0x16EB800 VA: 0x1816EC600 Slot: 16
	public override DateTime AddMonths(DateTime time, int months) { }

	// RVA: 0x16ECA30 Offset: 0x16EBC30 VA: 0x1816ECA30 Slot: 19
	public override DateTime AddYears(DateTime time, int years) { }

	// RVA: 0x16ED6F0 Offset: 0x16EC8F0 VA: 0x1816ED6F0 Slot: 22
	public override int GetDayOfYear(DateTime time) { }

	// RVA: 0x16ED4D0 Offset: 0x16EC6D0 VA: 0x1816ED4D0 Slot: 20
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x16ED950 Offset: 0x16ECB50 VA: 0x1816ED950 Slot: 26
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x16EDA40 Offset: 0x16ECC40 VA: 0x1816EDA40 Slot: 32
	public override int GetMonth(DateTime time) { }

	// RVA: 0x16EDF00 Offset: 0x16ED100 VA: 0x1816EDF00 Slot: 38
	public override int GetYear(DateTime time) { }

	// RVA: 0x16ED650 Offset: 0x16EC850 VA: 0x1816ED650 Slot: 21
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x16EDBC0 Offset: 0x16ECDC0 VA: 0x1816EDBC0 Slot: 34
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x16EE4A0 Offset: 0x16ED6A0 VA: 0x1816EE4A0 Slot: 40
	public override bool IsLeapDay(int year, int month, int day, int era) { }

	// RVA: 0x16EE650 Offset: 0x16ED850 VA: 0x1816EE650 Slot: 42
	public override bool IsLeapMonth(int year, int month, int era) { }

	// RVA: 0x16EDA00 Offset: 0x16ECC00 VA: 0x1816EDA00 Slot: 44
	public override int GetLeapMonth(int year, int era) { }

	// RVA: 0x16EE470 Offset: 0x16ED670 VA: 0x1816EE470
	internal bool InternalIsLeapYear(int year) { }

	// RVA: 0x16EE6B0 Offset: 0x16ED8B0 VA: 0x1816EE6B0 Slot: 46
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x16EF3B0 Offset: 0x16EE5B0 VA: 0x1816EF3B0 Slot: 53
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x16EF470 Offset: 0x16EE670 VA: 0x1816EF470 Slot: 54
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x16EF250 Offset: 0x16EE450 VA: 0x1816EF250 Slot: 55
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x16EF2F0 Offset: 0x16EE4F0 VA: 0x1816EF2F0
	private static void .cctor() { }
}

// Namespace: System.Globalization
internal sealed class GlobalizationAssembly // TypeDefIndex: 4287
{
	// Methods

	// RVA: 0x16EF7A0 Offset: 0x16EE9A0 VA: 0x1816EF7A0
	internal static byte* GetGlobalizationResourceBytePtr(Assembly assembly, string tableName) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class GregorianCalendar : Calendar // TypeDefIndex: 4288
{
	// Fields
	public const int ADEra = 1;
	internal const int DatePartYear = 0;
	internal const int DatePartDayOfYear = 1;
	internal const int DatePartMonth = 2;
	internal const int DatePartDay = 3;
	internal const int MaxYear = 9999;
	internal const int MinYear = 1;
	internal GregorianCalendarTypes m_type; // 0x20
	internal static readonly int[] DaysToMonth365; // 0x0
	internal static readonly int[] DaysToMonth366; // 0x8
	private static Calendar s_defaultInstance; // 0x10
	private const int DEFAULT_TWO_DIGIT_YEAR_MAX = 2029;

	// Properties
	[ComVisible(False)]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime { get; }
	[ComVisible(False)]
	public override CalendarAlgorithmType AlgorithmType { get; }
	public virtual GregorianCalendarTypes CalendarType { get; set; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	[OnDeserialized]
	// RVA: 0x16F3780 Offset: 0x16F2980 VA: 0x1816F3780
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x16F3EC0 Offset: 0x16F30C0 VA: 0x1816F3EC0 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x16F3E70 Offset: 0x16F3070 VA: 0x1816F3E70 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 9
	public override CalendarAlgorithmType get_AlgorithmType() { }

	// RVA: 0x16F29E0 Offset: 0x16F1BE0 VA: 0x1816F29E0
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x16F3C90 Offset: 0x16F2E90 VA: 0x1816F3C90
	public void .ctor() { }

	// RVA: 0x16F3CC0 Offset: 0x16F2EC0 VA: 0x1816F3CC0
	public void .ctor(GregorianCalendarTypes type) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 56
	public virtual GregorianCalendarTypes get_CalendarType() { }

	// RVA: 0x16F3F80 Offset: 0x16F3180 VA: 0x1816F3F80 Slot: 57
	public virtual void set_CalendarType(GregorianCalendarTypes value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x16F21B0 Offset: 0x16F13B0 VA: 0x1816F21B0 Slot: 58
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x16F1FC0 Offset: 0x16F11C0 VA: 0x1816F1FC0
	internal static long GetAbsoluteDate(int year, int month, int day) { }

	// RVA: 0x16F1F40 Offset: 0x16F1140 VA: 0x1816F1F40 Slot: 59
	internal virtual long DateToTicks(int year, int month, int day) { }

	// RVA: 0x16F1B30 Offset: 0x16F0D30 VA: 0x1816F1B30 Slot: 16
	public override DateTime AddMonths(DateTime time, int months) { }

	// RVA: 0x16F1F20 Offset: 0x16F1120 VA: 0x1816F1F20 Slot: 19
	public override DateTime AddYears(DateTime time, int years) { }

	// RVA: 0x16F2380 Offset: 0x16F1580 VA: 0x1816F2380 Slot: 20
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x16F23F0 Offset: 0x16F15F0 VA: 0x1816F23F0 Slot: 21
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x16F2470 Offset: 0x16F1670 VA: 0x1816F2470 Slot: 22
	public override int GetDayOfYear(DateTime time) { }

	// RVA: 0x16F24E0 Offset: 0x16F16E0 VA: 0x1816F24E0 Slot: 24
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x16F2800 Offset: 0x16F1A00 VA: 0x1816F2800 Slot: 26
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 27
	public override int GetEra(DateTime time) { }

	// RVA: 0x16F3E10 Offset: 0x16F3010 VA: 0x1816F3E10 Slot: 28
	public override int[] get_Eras() { }

	// RVA: 0x16F2C50 Offset: 0x16F1E50 VA: 0x1816F2C50 Slot: 32
	public override int GetMonth(DateTime time) { }

	// RVA: 0x16F2CC0 Offset: 0x16F1EC0 VA: 0x1816F2CC0 Slot: 34
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x16F2E50 Offset: 0x16F2050 VA: 0x1816F2E50 Slot: 38
	public override int GetYear(DateTime time) { }

	// RVA: 0x16F2EC0 Offset: 0x16F20C0 VA: 0x1816F2EC0 Slot: 40
	public override bool IsLeapDay(int year, int month, int day, int era) { }

	[ComVisible(False)]
	// RVA: 0x16F2AD0 Offset: 0x16F1CD0 VA: 0x1816F2AD0 Slot: 44
	public override int GetLeapMonth(int year, int era) { }

	// RVA: 0x16F3310 Offset: 0x16F2510 VA: 0x1816F3310 Slot: 42
	public override bool IsLeapMonth(int year, int month, int era) { }

	// RVA: 0x16F35B0 Offset: 0x16F27B0 VA: 0x1816F35B0 Slot: 46
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x16F3870 Offset: 0x16F2A70 VA: 0x1816F3870 Slot: 48
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x16F3AD0 Offset: 0x16F2CD0 VA: 0x1816F3AD0 Slot: 49
	internal override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	// RVA: 0x16F3F10 Offset: 0x16F3110 VA: 0x1816F3F10 Slot: 53
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x16F4020 Offset: 0x16F3220 VA: 0x1816F4020 Slot: 54
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x16F3950 Offset: 0x16F2B50 VA: 0x1816F3950 Slot: 55
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x16F3BD0 Offset: 0x16F2DD0 VA: 0x1816F3BD0
	private static void .cctor() { }
}

// Namespace: System.Globalization
[Serializable]
internal class EraInfo // TypeDefIndex: 4289
{
	// Fields
	internal int era; // 0x10
	internal long ticks; // 0x18
	internal int yearOffset; // 0x20
	internal int minEraYear; // 0x24
	internal int maxEraYear; // 0x28
	[OptionalField(VersionAdded = 4)]
	internal string eraName; // 0x30
	[OptionalField(VersionAdded = 4)]
	internal string abbrevEraName; // 0x38
	[OptionalField(VersionAdded = 4)]
	internal string englishEraName; // 0x40

	// Methods

	// RVA: 0x16EF6D0 Offset: 0x16EE8D0 VA: 0x1816EF6D0
	internal void .ctor(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear) { }

	// RVA: 0x16EF5E0 Offset: 0x16EE7E0 VA: 0x1816EF5E0
	internal void .ctor(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear, string eraName, string abbrevEraName, string englishEraName) { }
}

// Namespace: System.Globalization
[Serializable]
internal class GregorianCalendarHelper // TypeDefIndex: 4290
{
	// Fields
	internal const long TicksPerMillisecond = 10000;
	internal const long TicksPerSecond = 10000000;
	internal const long TicksPerMinute = 600000000;
	internal const long TicksPerHour = 36000000000;
	internal const long TicksPerDay = 864000000000;
	internal const int MillisPerSecond = 1000;
	internal const int MillisPerMinute = 60000;
	internal const int MillisPerHour = 3600000;
	internal const int MillisPerDay = 86400000;
	internal const int DaysPerYear = 365;
	internal const int DaysPer4Years = 1461;
	internal const int DaysPer100Years = 36524;
	internal const int DaysPer400Years = 146097;
	internal const int DaysTo10000 = 3652059;
	internal const long MaxMillis = 315537897600000;
	internal const int DatePartYear = 0;
	internal const int DatePartDayOfYear = 1;
	internal const int DatePartMonth = 2;
	internal const int DatePartDay = 3;
	internal static readonly int[] DaysToMonth365; // 0x0
	internal static readonly int[] DaysToMonth366; // 0x8
	[OptionalField(VersionAdded = 1)]
	internal int m_maxYear; // 0x10
	[OptionalField(VersionAdded = 1)]
	internal int m_minYear; // 0x14
	internal Calendar m_Cal; // 0x18
	[OptionalField(VersionAdded = 1)]
	internal EraInfo[] m_EraInfo; // 0x20
	[OptionalField(VersionAdded = 1)]
	internal int[] m_eras; // 0x28
	[OptionalField(VersionAdded = 1)]
	internal DateTime m_minDate; // 0x30

	// Properties
	internal int MaxYear { get; }
	public int[] Eras { get; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	internal int get_MaxYear() { }

	// RVA: 0x16F1950 Offset: 0x16F0B50 VA: 0x1816F1950
	internal void .ctor(Calendar cal, EraInfo[] eraInfo) { }

	// RVA: 0x16F0A50 Offset: 0x16EFC50 VA: 0x1816F0A50
	private int GetYearOffset(int year, int era, bool throwOnError) { }

	// RVA: 0x16F0890 Offset: 0x16EFA90 VA: 0x1816F0890
	internal int GetGregorianYear(int year, int era) { }

	// RVA: 0x16F1360 Offset: 0x16F0560 VA: 0x1816F1360
	internal bool IsValidYear(int year, int era) { }

	// RVA: 0x16F01D0 Offset: 0x16EF3D0 VA: 0x1816F01D0 Slot: 4
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x16EFFE0 Offset: 0x16EF1E0 VA: 0x1816EFFE0
	internal static long GetAbsoluteDate(int year, int month, int day) { }

	// RVA: 0x16EFF60 Offset: 0x16EF160 VA: 0x1816EFF60
	internal static long DateToTicks(int year, int month, int day) { }

	// RVA: 0x16F1380 Offset: 0x16F0580 VA: 0x1816F1380
	internal static long TimeToTicks(int hour, int minute, int second, int millisecond) { }

	// RVA: 0x16EFD60 Offset: 0x16EEF60 VA: 0x1816EFD60
	internal void CheckTicksRange(long ticks) { }

	// RVA: 0x16EF930 Offset: 0x16EEB30 VA: 0x1816EF930
	public DateTime AddMonths(DateTime time, int months) { }

	// RVA: 0x16EFD50 Offset: 0x16EEF50 VA: 0x1816EFD50
	public DateTime AddYears(DateTime time, int years) { }

	// RVA: 0x16F03C0 Offset: 0x16EF5C0 VA: 0x1816F03C0
	public int GetDayOfMonth(DateTime time) { }

	// RVA: 0x16F0430 Offset: 0x16EF630 VA: 0x1816F0430
	public DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x16F04D0 Offset: 0x16EF6D0 VA: 0x1816F04D0
	public int GetDayOfYear(DateTime time) { }

	// RVA: 0x16F0540 Offset: 0x16EF740 VA: 0x1816F0540
	public int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x16F06F0 Offset: 0x16EF8F0 VA: 0x1816F06F0
	public int GetDaysInYear(int year, int era) { }

	// RVA: 0x16F0780 Offset: 0x16EF980 VA: 0x1816F0780
	public int GetEra(DateTime time) { }

	// RVA: 0x16F1A00 Offset: 0x16F0C00 VA: 0x1816F1A00
	public int[] get_Eras() { }

	// RVA: 0x16F08E0 Offset: 0x16EFAE0 VA: 0x1816F08E0
	public int GetMonth(DateTime time) { }

	// RVA: 0x16F0950 Offset: 0x16EFB50 VA: 0x1816F0950
	public int GetMonthsInYear(int year, int era) { }

	// RVA: 0x16F0EE0 Offset: 0x16F00E0 VA: 0x1816F0EE0
	public int GetYear(DateTime time) { }

	// RVA: 0x16F0DD0 Offset: 0x16EFFD0 VA: 0x1816F0DD0
	public int GetYear(int year, DateTime time) { }

	// RVA: 0x16F1010 Offset: 0x16F0210 VA: 0x1816F1010
	public bool IsLeapDay(int year, int month, int day, int era) { }

	// RVA: 0x16F08C0 Offset: 0x16EFAC0 VA: 0x1816F08C0
	public int GetLeapMonth(int year, int era) { }

	// RVA: 0x16F11B0 Offset: 0x16F03B0 VA: 0x1816F11B0
	public bool IsLeapMonth(int year, int month, int era) { }

	// RVA: 0x16F12E0 Offset: 0x16F04E0 VA: 0x1816F12E0
	public bool IsLeapYear(int year, int era) { }

	// RVA: 0x16F1550 Offset: 0x16F0750 VA: 0x1816F1550
	public DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x16F0970 Offset: 0x16EFB70 VA: 0x1816F0970 Slot: 5
	public virtual int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek) { }

	// RVA: 0x16F1690 Offset: 0x16F0890 VA: 0x1816F1690
	public int ToFourDigitYear(int year, int twoDigitYearMax) { }

	// RVA: 0x16F1890 Offset: 0x16F0A90 VA: 0x1816F1890
	private static void .cctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public enum GregorianCalendarTypes // TypeDefIndex: 4291
{
	// Fields
	public int value__; // 0x0
	public const GregorianCalendarTypes Localized = 1;
	public const GregorianCalendarTypes USEnglish = 2;
	public const GregorianCalendarTypes MiddleEastFrench = 9;
	public const GregorianCalendarTypes Arabic = 10;
	public const GregorianCalendarTypes TransliteratedEnglish = 11;
	public const GregorianCalendarTypes TransliteratedFrench = 12;
}

// Namespace: 
internal class HebrewCalendar.__DateBuffer // TypeDefIndex: 4292
{
	// Fields
	internal int year; // 0x10
	internal int month; // 0x14
	internal int day; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class HebrewCalendar : Calendar // TypeDefIndex: 4293
{
	// Fields
	public static readonly int HebrewEra; // 0x0
	internal const int DatePartYear = 0;
	internal const int DatePartDayOfYear = 1;
	internal const int DatePartMonth = 2;
	internal const int DatePartDay = 3;
	internal const int DatePartDayOfWeek = 4;
	private const int HebrewYearOf1AD = 3760;
	private const int FirstGregorianTableYear = 1583;
	private const int LastGregorianTableYear = 2239;
	private const int TABLESIZE = 656;
	private const int MinHebrewYear = 5343;
	private const int MaxHebrewYear = 5999;
	private static readonly int[] HebrewTable; // 0x8
	private static readonly int[,] LunarMonthLen; // 0x10
	internal static readonly DateTime calendarMinValue; // 0x18
	internal static readonly DateTime calendarMaxValue; // 0x20
	private const int DEFAULT_TWO_DIGIT_YEAR_MAX = 5790;

	// Properties
	public override DateTime MinSupportedDateTime { get; }
	public override DateTime MaxSupportedDateTime { get; }
	public override CalendarAlgorithmType AlgorithmType { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x16F6880 Offset: 0x16F5A80 VA: 0x1816F6880 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x16F6830 Offset: 0x16F5A30 VA: 0x1816F6830 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0xCCA530 Offset: 0xCC9730 VA: 0x180CCA530 Slot: 9
	public override CalendarAlgorithmType get_AlgorithmType() { }

	// RVA: 0x16E82A0 Offset: 0x16E74A0 VA: 0x1816E82A0
	public void .ctor() { }

	// RVA: 0xAA00E0 Offset: 0xA9F2E0 VA: 0x180AA00E0 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x16F49F0 Offset: 0x16F3BF0 VA: 0x1816F49F0
	private static void CheckHebrewYearValue(int y, int era, string varName) { }

	// RVA: 0x16F48C0 Offset: 0x16F3AC0 VA: 0x1816F48C0
	private void CheckHebrewMonthValue(int year, int month, int era) { }

	// RVA: 0x16F4780 Offset: 0x16F3980 VA: 0x1816F4780
	private void CheckHebrewDayValue(int year, int month, int day, int era) { }

	// RVA: 0x16F46B0 Offset: 0x16F38B0 VA: 0x1816F46B0
	internal static void CheckEraRange(int era) { }

	// RVA: 0x16F4B30 Offset: 0x16F3D30 VA: 0x1816F4B30
	private static void CheckTicksRange(long ticks) { }

	// RVA: 0x16F5C70 Offset: 0x16F4E70 VA: 0x1816F5C70
	internal static int GetResult(HebrewCalendar.__DateBuffer result, int part) { }

	// RVA: 0x16F5A10 Offset: 0x16F4C10 VA: 0x1816F5A10
	internal static int GetLunarMonthDay(int gregorianYear, HebrewCalendar.__DateBuffer lunarDate) { }

	// RVA: 0x16F4D30 Offset: 0x16F3F30 VA: 0x1816F4D30 Slot: 56
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x16F4140 Offset: 0x16F3340 VA: 0x1816F4140 Slot: 16
	public override DateTime AddMonths(DateTime time, int months) { }

	// RVA: 0x16F4450 Offset: 0x16F3650 VA: 0x1816F4450 Slot: 19
	public override DateTime AddYears(DateTime time, int years) { }

	// RVA: 0x16F5500 Offset: 0x16F4700 VA: 0x1816F5500 Slot: 20
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x16F5570 Offset: 0x16F4770 VA: 0x1816F5570 Slot: 21
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x16F5940 Offset: 0x16F4B40 VA: 0x1816F5940
	internal static int GetHebrewYearType(int year, int era) { }

	// RVA: 0x16F55F0 Offset: 0x16F47F0 VA: 0x1816F55F0 Slot: 22
	public override int GetDayOfYear(DateTime time) { }

	// RVA: 0x16F5710 Offset: 0x16F4910 VA: 0x1816F5710 Slot: 24
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x16F5870 Offset: 0x16F4A70 VA: 0x1816F5870 Slot: 26
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x16F58F0 Offset: 0x16F4AF0 VA: 0x1816F58F0 Slot: 27
	public override int GetEra(DateTime time) { }

	// RVA: 0x16F67A0 Offset: 0x16F59A0 VA: 0x1816F67A0 Slot: 28
	public override int[] get_Eras() { }

	// RVA: 0x16F5BD0 Offset: 0x16F4DD0 VA: 0x1816F5BD0 Slot: 32
	public override int GetMonth(DateTime time) { }

	// RVA: 0x16F5C40 Offset: 0x16F4E40 VA: 0x1816F5C40 Slot: 34
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x16F5D20 Offset: 0x16F4F20 VA: 0x1816F5D20 Slot: 38
	public override int GetYear(DateTime time) { }

	// RVA: 0x16F60D0 Offset: 0x16F52D0 VA: 0x1816F60D0 Slot: 40
	public override bool IsLeapDay(int year, int month, int day, int era) { }

	// RVA: 0x16F59E0 Offset: 0x16F4BE0 VA: 0x1816F59E0 Slot: 44
	public override int GetLeapMonth(int year, int era) { }

	// RVA: 0x16F61A0 Offset: 0x16F53A0 VA: 0x1816F61A0 Slot: 42
	public override bool IsLeapMonth(int year, int month, int era) { }

	// RVA: 0x16F6220 Offset: 0x16F5420 VA: 0x1816F6220 Slot: 46
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x16F5350 Offset: 0x16F4550 VA: 0x1816F5350
	private static int GetDayDifference(int lunarYearType, int month1, int day1, int month2, int day2) { }

	// RVA: 0x16F5D90 Offset: 0x16F4F90 VA: 0x1816F5D90
	private static DateTime HebrewToGregorian(int hebrewYear, int hebrewMonth, int hebrewDay, int hour, int minute, int second, int millisecond) { }

	// RVA: 0x16F62C0 Offset: 0x16F54C0 VA: 0x1816F62C0 Slot: 48
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x16F68D0 Offset: 0x16F5AD0 VA: 0x1816F68D0 Slot: 53
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x16F6940 Offset: 0x16F5B40 VA: 0x1816F6940 Slot: 54
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x16F6410 Offset: 0x16F5610 VA: 0x1816F6410 Slot: 55
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x16F65B0 Offset: 0x16F57B0 VA: 0x1816F65B0
	private static void .cctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class HijriCalendar : Calendar // TypeDefIndex: 4294
{
	// Fields
	public static readonly int HijriEra; // 0x0
	internal const int DatePartYear = 0;
	internal const int DatePartDayOfYear = 1;
	internal const int DatePartMonth = 2;
	internal const int DatePartDay = 3;
	internal const int MinAdvancedHijri = -2;
	internal const int MaxAdvancedHijri = 2;
	internal static readonly int[] HijriMonthDays; // 0x8
	private const string HijriAdvanceRegKeyEntry = "AddHijriDate";
	private int m_HijriAdvance; // 0x20
	internal const int MaxCalendarYear = 9666;
	internal const int MaxCalendarMonth = 4;
	internal const int MaxCalendarDay = 3;
	internal static readonly DateTime calendarMinValue; // 0x10
	internal static readonly DateTime calendarMaxValue; // 0x18
	private const int DEFAULT_TWO_DIGIT_YEAR_MAX = 1451;

	// Properties
	[ComVisible(False)]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime { get; }
	[ComVisible(False)]
	public override CalendarAlgorithmType AlgorithmType { get; }
	internal override int ID { get; }
	protected override int DaysInYearBeforeMinSupportedYear { get; }
	public int HijriAdjustment { get; set; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x16F8590 Offset: 0x16F7790 VA: 0x1816F8590 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x16F8540 Offset: 0x16F7740 VA: 0x1816F8540 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 9
	public override CalendarAlgorithmType get_AlgorithmType() { }

	// RVA: 0x16F8410 Offset: 0x16F7610 VA: 0x1816F8410
	public void .ctor() { }

	// RVA: 0x16F8530 Offset: 0x16F7730 VA: 0x1816F8530 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x16F8430 Offset: 0x16F7630 VA: 0x1816F8430 Slot: 36
	protected override int get_DaysInYearBeforeMinSupportedYear() { }

	// RVA: 0x16F7440 Offset: 0x16F6640 VA: 0x1816F7440
	private long GetAbsoluteDateHijri(int y, int m, int d) { }

	// RVA: 0x16F7380 Offset: 0x16F6580 VA: 0x1816F7380
	private long DaysUpToHijriYear(int HijriYear) { }

	// RVA: 0x16F84D0 Offset: 0x16F76D0 VA: 0x1816F84D0
	public int get_HijriAdjustment() { }

	// RVA: 0x16F8650 Offset: 0x16F7850 VA: 0x1816F8650
	public void set_HijriAdjustment(int value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	private static int GetAdvanceHijriDate() { }

	// RVA: 0x16F6DC0 Offset: 0x16F5FC0 VA: 0x1816F6DC0
	internal static void CheckTicksRange(long ticks) { }

	// RVA: 0x16F6CF0 Offset: 0x16F5EF0 VA: 0x1816F6CF0
	internal static void CheckEraRange(int era) { }

	// RVA: 0x16F7190 Offset: 0x16F6390 VA: 0x1816F7190
	internal static void CheckYearRange(int year, int era) { }

	// RVA: 0x16F6FC0 Offset: 0x16F61C0 VA: 0x1816F6FC0
	internal static void CheckYearMonthRange(int year, int month, int era) { }

	// RVA: 0x16F7550 Offset: 0x16F6750 VA: 0x1816F7550 Slot: 56
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x16F69D0 Offset: 0x16F5BD0 VA: 0x1816F69D0 Slot: 16
	public override DateTime AddMonths(DateTime time, int months) { }

	// RVA: 0x16F1F20 Offset: 0x16F1120 VA: 0x1816F1F20 Slot: 19
	public override DateTime AddYears(DateTime time, int years) { }

	// RVA: 0x16F77F0 Offset: 0x16F69F0 VA: 0x1816F77F0 Slot: 20
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x16F7860 Offset: 0x16F6A60 VA: 0x1816F7860 Slot: 21
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x16F78E0 Offset: 0x16F6AE0 VA: 0x1816F78E0 Slot: 22
	public override int GetDayOfYear(DateTime time) { }

	// RVA: 0x16F7950 Offset: 0x16F6B50 VA: 0x1816F7950 Slot: 24
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x16F7A20 Offset: 0x16F6C20 VA: 0x1816F7A20 Slot: 26
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x16F7AB0 Offset: 0x16F6CB0 VA: 0x1816F7AB0 Slot: 27
	public override int GetEra(DateTime time) { }

	// RVA: 0x16F8440 Offset: 0x16F7640 VA: 0x1816F8440 Slot: 28
	public override int[] get_Eras() { }

	// RVA: 0x16F7BA0 Offset: 0x16F6DA0 VA: 0x1816F7BA0 Slot: 32
	public override int GetMonth(DateTime time) { }

	// RVA: 0x16F7C10 Offset: 0x16F6E10 VA: 0x1816F7C10 Slot: 34
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x16F7C70 Offset: 0x16F6E70 VA: 0x1816F7C70 Slot: 38
	public override int GetYear(DateTime time) { }

	// RVA: 0x16F7CE0 Offset: 0x16F6EE0 VA: 0x1816F7CE0 Slot: 40
	public override bool IsLeapDay(int year, int month, int day, int era) { }

	[ComVisible(False)]
	// RVA: 0x16F7B40 Offset: 0x16F6D40 VA: 0x1816F7B40 Slot: 44
	public override int GetLeapMonth(int year, int era) { }

	// RVA: 0x16F7E50 Offset: 0x16F7050 VA: 0x1816F7E50 Slot: 42
	public override bool IsLeapMonth(int year, int month, int era) { }

	// RVA: 0x16F7EC0 Offset: 0x16F70C0 VA: 0x1816F7EC0 Slot: 46
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x16F7F40 Offset: 0x16F7140 VA: 0x1816F7F40 Slot: 48
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x16F85E0 Offset: 0x16F77E0 VA: 0x1816F85E0 Slot: 53
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x16F8770 Offset: 0x16F7970 VA: 0x1816F8770 Slot: 54
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x16F8150 Offset: 0x16F7350 VA: 0x1816F8150 Slot: 55
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x16F82F0 Offset: 0x16F74F0 VA: 0x1816F82F0
	private static void .cctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class JapaneseCalendar : Calendar // TypeDefIndex: 4295
{
	// Fields
	internal static readonly DateTime calendarMinValue; // 0x0
	internal static EraInfo[] japaneseEraInfo; // 0x8
	private const string c_japaneseErasHive = "System\\CurrentControlSet\\Control\\Nls\\Calendars\\Japanese\\Eras";
	private const string c_japaneseErasHivePermissionList = "HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Nls\\Calendars\\Japanese\\Eras";
	internal static Calendar s_defaultInstance; // 0x10
	internal GregorianCalendarHelper helper; // 0x20
	private const int DEFAULT_TWO_DIGIT_YEAR_MAX = 99;

	// Properties
	[ComVisible(False)]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime { get; }
	[ComVisible(False)]
	public override CalendarAlgorithmType AlgorithmType { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x16FAB60 Offset: 0x16F9D60 VA: 0x1816FAB60 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x16FAB10 Offset: 0x16F9D10 VA: 0x1816FAB10 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 9
	public override CalendarAlgorithmType get_AlgorithmType() { }

	// RVA: 0x16F98F0 Offset: 0x16F8AF0 VA: 0x1816F98F0
	internal static EraInfo[] GetEraInfo() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	private static EraInfo[] GetErasFromRegistry() { }

	// RVA: 0x16F8FE0 Offset: 0x16F81E0 VA: 0x1816F8FE0
	private static int CompareEraRanges(EraInfo a, EraInfo b) { }

	// RVA: 0x16F94F0 Offset: 0x16F86F0 VA: 0x1816F94F0
	private static EraInfo GetEraFromValue(string value, string data) { }

	// RVA: 0x16F9410 Offset: 0x16F8610 VA: 0x1816F9410
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x16FA900 Offset: 0x16F9B00 VA: 0x1816FA900
	public void .ctor() { }

	// RVA: 0xCCA530 Offset: 0xCC9730 VA: 0x180CCA530 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x16F8F90 Offset: 0x16F8190 VA: 0x1816F8F90 Slot: 16
	public override DateTime AddMonths(DateTime time, int months) { }

	// RVA: 0x16F8FB0 Offset: 0x16F81B0 VA: 0x1816F8FB0 Slot: 19
	public override DateTime AddYears(DateTime time, int years) { }

	// RVA: 0x16F9350 Offset: 0x16F8550 VA: 0x1816F9350 Slot: 24
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x16F9380 Offset: 0x16F8580 VA: 0x1816F9380 Slot: 26
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x16F9190 Offset: 0x16F8390 VA: 0x1816F9190 Slot: 20
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x16F9210 Offset: 0x16F8410 VA: 0x1816F9210 Slot: 21
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x16F92D0 Offset: 0x16F84D0 VA: 0x1816F92D0 Slot: 22
	public override int GetDayOfYear(DateTime time) { }

	// RVA: 0x16FA0D0 Offset: 0x16F92D0 VA: 0x1816FA0D0 Slot: 34
	public override int GetMonthsInYear(int year, int era) { }

	[ComVisible(False)]
	// RVA: 0x16FA100 Offset: 0x16F9300 VA: 0x1816FA100 Slot: 37
	public override int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek) { }

	// RVA: 0x16FA000 Offset: 0x16F9200 VA: 0x1816FA000 Slot: 27
	public override int GetEra(DateTime time) { }

	// RVA: 0x16FA050 Offset: 0x16F9250 VA: 0x1816FA050 Slot: 32
	public override int GetMonth(DateTime time) { }

	// RVA: 0x16FA130 Offset: 0x16F9330 VA: 0x1816FA130 Slot: 38
	public override int GetYear(DateTime time) { }

	// RVA: 0x16FA280 Offset: 0x16F9480 VA: 0x1816FA280 Slot: 40
	public override bool IsLeapDay(int year, int month, int day, int era) { }

	// RVA: 0x16FA560 Offset: 0x16F9760 VA: 0x1816FA560 Slot: 46
	public override bool IsLeapYear(int year, int era) { }

	[ComVisible(False)]
	// RVA: 0x16FA020 Offset: 0x16F9220 VA: 0x1816FA020 Slot: 44
	public override int GetLeapMonth(int year, int era) { }

	// RVA: 0x16FA420 Offset: 0x16F9620 VA: 0x1816FA420 Slot: 42
	public override bool IsLeapMonth(int year, int month, int era) { }

	// RVA: 0x16FA5B0 Offset: 0x16F97B0 VA: 0x1816FA5B0 Slot: 48
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x16FA6F0 Offset: 0x16F98F0 VA: 0x1816FA6F0 Slot: 55
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x16FAAF0 Offset: 0x16F9CF0 VA: 0x1816FAAF0 Slot: 28
	public override int[] get_Eras() { }

	// RVA: 0x16F90D0 Offset: 0x16F82D0 VA: 0x1816F90D0
	internal static string[] EraNames() { }

	// RVA: 0x16F8ED0 Offset: 0x16F80D0 VA: 0x1816F8ED0
	internal static string[] AbbrevEraNames() { }

	// RVA: 0x16F9010 Offset: 0x16F8210 VA: 0x1816F9010
	internal static string[] EnglishEraNames() { }

	// RVA: 0x16FA580 Offset: 0x16F9780 VA: 0x1816FA580 Slot: 50
	internal override bool IsValidYear(int year, int era) { }

	// RVA: 0x16FABB0 Offset: 0x16F9DB0 VA: 0x1816FABB0 Slot: 53
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x16FAC20 Offset: 0x16F9E20 VA: 0x1816FAC20 Slot: 54
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x16FA890 Offset: 0x16F9A90 VA: 0x1816FA890
	private static void .cctor() { }
}

// Namespace: System.Globalization
[Serializable]
public class JapaneseLunisolarCalendar : EastAsianLunisolarCalendar // TypeDefIndex: 4296
{
	// Fields
	public const int JapaneseEra = 1;
	internal GregorianCalendarHelper helper; // 0x20
	internal const int MIN_LUNISOLAR_YEAR = 1960;
	internal const int MAX_LUNISOLAR_YEAR = 2049;
	internal const int MIN_GREGORIAN_YEAR = 1960;
	internal const int MIN_GREGORIAN_MONTH = 1;
	internal const int MIN_GREGORIAN_DAY = 28;
	internal const int MAX_GREGORIAN_YEAR = 2050;
	internal const int MAX_GREGORIAN_MONTH = 1;
	internal const int MAX_GREGORIAN_DAY = 22;
	internal static DateTime minDate; // 0x0
	internal static DateTime maxDate; // 0x8
	private static readonly int[,] yinfo; // 0x10

	// Properties
	public override DateTime MinSupportedDateTime { get; }
	public override DateTime MaxSupportedDateTime { get; }
	protected override int DaysInYearBeforeMinSupportedYear { get; }
	internal override int MinCalendarYear { get; }
	internal override int MaxCalendarYear { get; }
	internal override DateTime MinDate { get; }
	internal override DateTime MaxDate { get; }
	internal override EraInfo[] CalEraInfo { get; }
	internal override int BaseCalendarID { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }

	// Methods

	// RVA: 0x16FB760 Offset: 0x16FA960 VA: 0x1816FB760 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x16FB6B0 Offset: 0x16FA8B0 VA: 0x1816FB6B0 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x16F8430 Offset: 0x16F7630 VA: 0x1816F8430 Slot: 36
	protected override int get_DaysInYearBeforeMinSupportedYear() { }

	// RVA: 0x16FB700 Offset: 0x16FA900 VA: 0x1816FB700 Slot: 60
	internal override int get_MinCalendarYear() { }

	// RVA: 0x16FB650 Offset: 0x16FA850 VA: 0x1816FB650 Slot: 61
	internal override int get_MaxCalendarYear() { }

	// RVA: 0x16FB710 Offset: 0x16FA910 VA: 0x1816FB710 Slot: 63
	internal override DateTime get_MinDate() { }

	// RVA: 0x16FB660 Offset: 0x16FA860 VA: 0x1816FB660 Slot: 64
	internal override DateTime get_MaxDate() { }

	// RVA: 0x16FB600 Offset: 0x16FA800 VA: 0x1816FB600 Slot: 62
	internal override EraInfo[] get_CalEraInfo() { }

	// RVA: 0x16FADA0 Offset: 0x16F9FA0 VA: 0x1816FADA0 Slot: 57
	internal override int GetYearInfo(int LunarYear, int Index) { }

	// RVA: 0x16FAF40 Offset: 0x16FA140 VA: 0x1816FAF40 Slot: 58
	internal override int GetYear(int year, DateTime time) { }

	// RVA: 0x16FAD70 Offset: 0x16F9F70 VA: 0x1816FAD70 Slot: 59
	internal override int GetGregorianYear(int year, int era) { }

	// RVA: 0x16FB070 Offset: 0x16FA270 VA: 0x1816FB070
	private static EraInfo[] TrimEras(EraInfo[] baseEras) { }

	// RVA: 0x16FB360 Offset: 0x16FA560 VA: 0x1816FB360
	public void .ctor() { }

	// RVA: 0x16FA000 Offset: 0x16F9200 VA: 0x1816FA000 Slot: 27
	public override int GetEra(DateTime time) { }

	// RVA: 0xCCA530 Offset: 0xCC9730 VA: 0x180CCA530 Slot: 8
	internal override int get_BaseCalendarID() { }

	// RVA: 0x16FB640 Offset: 0x16FA840 VA: 0x1816FB640 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x16FAAF0 Offset: 0x16F9CF0 VA: 0x1816FAAF0 Slot: 28
	public override int[] get_Eras() { }

	// RVA: 0x16FB1D0 Offset: 0x16FA3D0 VA: 0x1816FB1D0
	private static void .cctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class JulianCalendar : Calendar // TypeDefIndex: 4297
{
	// Fields
	public static readonly int JulianEra; // 0x0
	private const int DatePartYear = 0;
	private const int DatePartDayOfYear = 1;
	private const int DatePartMonth = 2;
	private const int DatePartDay = 3;
	private const int JulianDaysPerYear = 365;
	private const int JulianDaysPer4Years = 1461;
	private static readonly int[] DaysToMonth365; // 0x8
	private static readonly int[] DaysToMonth366; // 0x10
	internal int MaxYear; // 0x20

	// Properties
	[ComVisible(False)]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime { get; }
	[ComVisible(False)]
	public override CalendarAlgorithmType AlgorithmType { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x170C340 Offset: 0x170B540 VA: 0x18170C340 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x170C2F0 Offset: 0x170B4F0 VA: 0x18170C2F0 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 9
	public override CalendarAlgorithmType get_AlgorithmType() { }

	// RVA: 0x170C220 Offset: 0x170B420 VA: 0x18170C220
	public void .ctor() { }

	// RVA: 0x170C2E0 Offset: 0x170B4E0 VA: 0x18170C2E0 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x170B030 Offset: 0x170A230 VA: 0x18170B030
	internal static void CheckEraRange(int era) { }

	// RVA: 0x170B190 Offset: 0x170A390 VA: 0x18170B190
	internal void CheckYearEraRange(int year, int era) { }

	// RVA: 0x170B100 Offset: 0x170A300 VA: 0x18170B100
	internal static void CheckMonthRange(int month) { }

	// RVA: 0x170ADF0 Offset: 0x1709FF0 VA: 0x18170ADF0
	internal static void CheckDayRange(int year, int month, int day) { }

	// RVA: 0x170B480 Offset: 0x170A680 VA: 0x18170B480
	internal static int GetDatePart(long ticks, int part) { }

	// RVA: 0x170B390 Offset: 0x170A590 VA: 0x18170B390
	internal static long DateToTicks(int year, int month, int day) { }

	// RVA: 0x170A9B0 Offset: 0x1709BB0 VA: 0x18170A9B0 Slot: 16
	public override DateTime AddMonths(DateTime time, int months) { }

	// RVA: 0x16F1F20 Offset: 0x16F1120 VA: 0x1816F1F20 Slot: 19
	public override DateTime AddYears(DateTime time, int years) { }

	// RVA: 0x170B600 Offset: 0x170A800 VA: 0x18170B600 Slot: 20
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x170B690 Offset: 0x170A890 VA: 0x18170B690 Slot: 21
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x170B710 Offset: 0x170A910 VA: 0x18170B710 Slot: 22
	public override int GetDayOfYear(DateTime time) { }

	// RVA: 0x170B810 Offset: 0x170AA10 VA: 0x18170B810 Slot: 24
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x170B920 Offset: 0x170AB20 VA: 0x18170B920 Slot: 26
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x170B950 Offset: 0x170AB50 VA: 0x18170B950 Slot: 27
	public override int GetEra(DateTime time) { }

	// RVA: 0x170B9C0 Offset: 0x170ABC0 VA: 0x18170B9C0 Slot: 32
	public override int GetMonth(DateTime time) { }

	// RVA: 0x170C250 Offset: 0x170B450 VA: 0x18170C250 Slot: 28
	public override int[] get_Eras() { }

	// RVA: 0x170BA50 Offset: 0x170AC50 VA: 0x18170BA50 Slot: 34
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x170BA70 Offset: 0x170AC70 VA: 0x18170BA70 Slot: 38
	public override int GetYear(DateTime time) { }

	// RVA: 0x170BB70 Offset: 0x170AD70 VA: 0x18170BB70 Slot: 40
	public override bool IsLeapDay(int year, int month, int day, int era) { }

	[ComVisible(False)]
	// RVA: 0x170B9A0 Offset: 0x170ABA0 VA: 0x18170B9A0 Slot: 44
	public override int GetLeapMonth(int year, int era) { }

	// RVA: 0x170BC60 Offset: 0x170AE60 VA: 0x18170BC60 Slot: 42
	public override bool IsLeapMonth(int year, int month, int era) { }

	// RVA: 0x170BCE0 Offset: 0x170AEE0 VA: 0x18170BCE0 Slot: 46
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x170BD10 Offset: 0x170AF10 VA: 0x18170BD10 Slot: 48
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 53
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x170C390 Offset: 0x170B590 VA: 0x18170C390 Slot: 54
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x170BFD0 Offset: 0x170B1D0 VA: 0x18170BFD0 Slot: 55
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x170C150 Offset: 0x170B350 VA: 0x18170C150
	private static void .cctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class KoreanCalendar : Calendar // TypeDefIndex: 4298
{
	// Fields
	public const int KoreanEra = 1;
	internal static EraInfo[] koreanEraInfo; // 0x0
	internal GregorianCalendarHelper helper; // 0x20
	private const int DEFAULT_TWO_DIGIT_YEAR_MAX = 4362;

	// Properties
	[ComVisible(False)]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime { get; }
	[ComVisible(False)]
	public override CalendarAlgorithmType AlgorithmType { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x170C9D0 Offset: 0x170BBD0 VA: 0x18170C9D0 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x170C980 Offset: 0x170BB80 VA: 0x18170C980 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 9
	public override CalendarAlgorithmType get_AlgorithmType() { }

	// RVA: 0x170C820 Offset: 0x170BA20 VA: 0x18170C820
	public void .ctor() { }

	// RVA: 0xD55FE0 Offset: 0xD551E0 VA: 0x180D55FE0 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x16F8F90 Offset: 0x16F8190 VA: 0x1816F8F90 Slot: 16
	public override DateTime AddMonths(DateTime time, int months) { }

	// RVA: 0x170C4B0 Offset: 0x170B6B0 VA: 0x18170C4B0 Slot: 19
	public override DateTime AddYears(DateTime time, int years) { }

	// RVA: 0x16F9350 Offset: 0x16F8550 VA: 0x1816F9350 Slot: 24
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x170C530 Offset: 0x170B730 VA: 0x18170C530 Slot: 26
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x170C4D0 Offset: 0x170B6D0 VA: 0x18170C4D0 Slot: 20
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x170C4F0 Offset: 0x170B6F0 VA: 0x18170C4F0 Slot: 21
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x170C510 Offset: 0x170B710 VA: 0x18170C510 Slot: 22
	public override int GetDayOfYear(DateTime time) { }

	// RVA: 0x170C590 Offset: 0x170B790 VA: 0x18170C590 Slot: 34
	public override int GetMonthsInYear(int year, int era) { }

	[ComVisible(False)]
	// RVA: 0x16FA100 Offset: 0x16F9300 VA: 0x1816FA100 Slot: 37
	public override int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek) { }

	// RVA: 0x16FA000 Offset: 0x16F9200 VA: 0x1816FA000 Slot: 27
	public override int GetEra(DateTime time) { }

	// RVA: 0x170C570 Offset: 0x170B770 VA: 0x18170C570 Slot: 32
	public override int GetMonth(DateTime time) { }

	// RVA: 0x170C5B0 Offset: 0x170B7B0 VA: 0x18170C5B0 Slot: 38
	public override int GetYear(DateTime time) { }

	// RVA: 0x170C5D0 Offset: 0x170B7D0 VA: 0x18170C5D0 Slot: 40
	public override bool IsLeapDay(int year, int month, int day, int era) { }

	// RVA: 0x16FA560 Offset: 0x16F9760 VA: 0x1816FA560 Slot: 46
	public override bool IsLeapYear(int year, int era) { }

	[ComVisible(False)]
	// RVA: 0x170C550 Offset: 0x170B750 VA: 0x18170C550 Slot: 44
	public override int GetLeapMonth(int year, int era) { }

	// RVA: 0x170C600 Offset: 0x170B800 VA: 0x18170C600 Slot: 42
	public override bool IsLeapMonth(int year, int month, int era) { }

	// RVA: 0x170C630 Offset: 0x170B830 VA: 0x18170C630 Slot: 48
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x16FAAF0 Offset: 0x16F9CF0 VA: 0x1816FAAF0 Slot: 28
	public override int[] get_Eras() { }

	// RVA: 0x170CA20 Offset: 0x170BC20 VA: 0x18170CA20 Slot: 53
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x170CA70 Offset: 0x170BC70 VA: 0x18170CA70 Slot: 54
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x170C660 Offset: 0x170B860 VA: 0x18170C660 Slot: 55
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x170C720 Offset: 0x170B920 VA: 0x18170C720
	private static void .cctor() { }
}

// Namespace: System.Globalization
[Serializable]
public class KoreanLunisolarCalendar : EastAsianLunisolarCalendar // TypeDefIndex: 4299
{
	// Fields
	public const int GregorianEra = 1;
	internal const int MIN_LUNISOLAR_YEAR = 918;
	internal const int MAX_LUNISOLAR_YEAR = 2050;
	internal const int MIN_GREGORIAN_YEAR = 918;
	internal const int MIN_GREGORIAN_MONTH = 2;
	internal const int MIN_GREGORIAN_DAY = 14;
	internal const int MAX_GREGORIAN_YEAR = 2051;
	internal const int MAX_GREGORIAN_MONTH = 2;
	internal const int MAX_GREGORIAN_DAY = 10;
	internal static DateTime minDate; // 0x0
	internal static DateTime maxDate; // 0x8
	private static readonly int[,] yinfo; // 0x10

	// Properties
	public override DateTime MinSupportedDateTime { get; }
	public override DateTime MaxSupportedDateTime { get; }
	protected override int DaysInYearBeforeMinSupportedYear { get; }
	internal override int MinCalendarYear { get; }
	internal override int MaxCalendarYear { get; }
	internal override DateTime MinDate { get; }
	internal override DateTime MaxDate { get; }
	internal override EraInfo[] CalEraInfo { get; }
	internal override int BaseCalendarID { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }

	// Methods

	// RVA: 0x170D2A0 Offset: 0x170C4A0 VA: 0x18170D2A0 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x170D1F0 Offset: 0x170C3F0 VA: 0x18170D1F0 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x16EC420 Offset: 0x16EB620 VA: 0x1816EC420 Slot: 36
	protected override int get_DaysInYearBeforeMinSupportedYear() { }

	// RVA: 0x170D240 Offset: 0x170C440 VA: 0x18170D240 Slot: 60
	internal override int get_MinCalendarYear() { }

	// RVA: 0x170D190 Offset: 0x170C390 VA: 0x18170D190 Slot: 61
	internal override int get_MaxCalendarYear() { }

	// RVA: 0x170D250 Offset: 0x170C450 VA: 0x18170D250 Slot: 63
	internal override DateTime get_MinDate() { }

	// RVA: 0x170D1A0 Offset: 0x170C3A0 VA: 0x18170D1A0 Slot: 64
	internal override DateTime get_MaxDate() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 62
	internal override EraInfo[] get_CalEraInfo() { }

	// RVA: 0x170CDB0 Offset: 0x170BFB0 VA: 0x18170CDB0 Slot: 57
	internal override int GetYearInfo(int LunarYear, int Index) { }

	// RVA: 0x1529D90 Offset: 0x1528F90 VA: 0x181529D90 Slot: 58
	internal override int GetYear(int year, DateTime time) { }

	// RVA: 0x170CC30 Offset: 0x170BE30 VA: 0x18170CC30 Slot: 59
	internal override int GetGregorianYear(int year, int era) { }

	// RVA: 0x170D0E0 Offset: 0x170C2E0 VA: 0x18170D0E0
	public void .ctor() { }

	// RVA: 0x170CBC0 Offset: 0x170BDC0 VA: 0x18170CBC0 Slot: 27
	public override int GetEra(DateTime time) { }

	// RVA: 0xD55FE0 Offset: 0xD551E0 VA: 0x180D55FE0 Slot: 8
	internal override int get_BaseCalendarID() { }

	// RVA: 0xAA00C0 Offset: 0xA9F2C0 VA: 0x180AA00C0 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x170D130 Offset: 0x170C330 VA: 0x18170D130 Slot: 28
	public override int[] get_Eras() { }

	// RVA: 0x170CF50 Offset: 0x170C150 VA: 0x18170CF50
	private static void .cctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public sealed class NumberFormatInfo : ICloneable, IFormatProvider // TypeDefIndex: 4300
{
	// Fields
	private static NumberFormatInfo invariantInfo; // 0x0
	internal int[] numberGroupSizes; // 0x10
	internal int[] currencyGroupSizes; // 0x18
	internal int[] percentGroupSizes; // 0x20
	internal string positiveSign; // 0x28
	internal string negativeSign; // 0x30
	internal string numberDecimalSeparator; // 0x38
	internal string numberGroupSeparator; // 0x40
	internal string currencyGroupSeparator; // 0x48
	internal string currencyDecimalSeparator; // 0x50
	internal string currencySymbol; // 0x58
	internal string ansiCurrencySymbol; // 0x60
	internal string nanSymbol; // 0x68
	internal string positiveInfinitySymbol; // 0x70
	internal string negativeInfinitySymbol; // 0x78
	internal string percentDecimalSeparator; // 0x80
	internal string percentGroupSeparator; // 0x88
	internal string percentSymbol; // 0x90
	internal string perMilleSymbol; // 0x98
	[OptionalField(VersionAdded = 2)]
	internal string[] nativeDigits; // 0xA0
	[OptionalField(VersionAdded = 1)]
	internal int m_dataItem; // 0xA8
	internal int numberDecimalDigits; // 0xAC
	internal int currencyDecimalDigits; // 0xB0
	internal int currencyPositivePattern; // 0xB4
	internal int currencyNegativePattern; // 0xB8
	internal int numberNegativePattern; // 0xBC
	internal int percentPositivePattern; // 0xC0
	internal int percentNegativePattern; // 0xC4
	internal int percentDecimalDigits; // 0xC8
	[OptionalField(VersionAdded = 2)]
	internal int digitSubstitution; // 0xCC
	internal bool isReadOnly; // 0xD0
	[OptionalField(VersionAdded = 1)]
	internal bool m_useUserOverride; // 0xD1
	[OptionalField(VersionAdded = 2)]
	internal bool m_isInvariant; // 0xD2
	[OptionalField(VersionAdded = 1)]
	internal bool validForParseAsNumber; // 0xD3
	[OptionalField(VersionAdded = 1)]
	internal bool validForParseAsCurrency; // 0xD4
	private const NumberStyles InvalidNumberStyles = -1024;

	// Properties
	public static NumberFormatInfo InvariantInfo { get; }
	public int CurrencyDecimalDigits { get; set; }
	public string CurrencyDecimalSeparator { get; set; }
	public bool IsReadOnly { get; }
	public int[] CurrencyGroupSizes { get; set; }
	public int[] NumberGroupSizes { get; set; }
	public int[] PercentGroupSizes { get; set; }
	public string CurrencyGroupSeparator { get; set; }
	public string CurrencySymbol { get; set; }
	public static NumberFormatInfo CurrentInfo { get; }
	public string NaNSymbol { get; set; }
	public int CurrencyNegativePattern { get; set; }
	public int NumberNegativePattern { get; set; }
	public int PercentPositivePattern { get; set; }
	public int PercentNegativePattern { get; set; }
	public string NegativeInfinitySymbol { get; set; }
	public string NegativeSign { get; set; }
	public int NumberDecimalDigits { get; set; }
	public string NumberDecimalSeparator { get; set; }
	public string NumberGroupSeparator { get; set; }
	public int CurrencyPositivePattern { get; set; }
	public string PositiveInfinitySymbol { get; set; }
	public string PositiveSign { get; set; }
	public int PercentDecimalDigits { get; set; }
	public string PercentDecimalSeparator { get; set; }
	public string PercentGroupSeparator { get; set; }
	public string PercentSymbol { get; set; }
	public string PerMilleSymbol { get; set; }
	[ComVisible(False)]
	public string[] NativeDigits { get; set; }
	[ComVisible(False)]
	public DigitShapes DigitSubstitution { get; set; }

	// Methods

	// RVA: 0x170E110 Offset: 0x170D310 VA: 0x18170E110
	public void .ctor() { }

	[OnSerializing]
	// RVA: 0x170D810 Offset: 0x170CA10 VA: 0x18170D810
	private void OnSerializing(StreamingContext ctx) { }

	[OnDeserializing]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserialized]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x170DB40 Offset: 0x170CD40 VA: 0x18170DB40
	private static void VerifyDecimalSeparator(string decSep, string propertyName) { }

	// RVA: 0x170DCA0 Offset: 0x170CEA0 VA: 0x18170DCA0
	private static void VerifyGroupSeparator(string groupSep, string propertyName) { }

	// RVA: 0x170DD20 Offset: 0x170CF20 VA: 0x18170DD20
	private static void VerifyNativeDigits(string[] nativeDig, string propertyName) { }

	// RVA: 0x170DC20 Offset: 0x170CE20 VA: 0x18170DC20
	private static void VerifyDigitSubstitution(DigitShapes digitSub, string propertyName) { }

	// RVA: 0x170E120 Offset: 0x170D320 VA: 0x18170E120
	internal void .ctor(CultureData cultureData) { }

	// RVA: 0x170E090 Offset: 0x170D290 VA: 0x18170E090
	private void VerifyWritable() { }

	// RVA: 0x170E700 Offset: 0x170D900 VA: 0x18170E700
	public static NumberFormatInfo get_InvariantInfo() { }

	// RVA: 0x170D530 Offset: 0x170C730 VA: 0x18170D530
	public static NumberFormatInfo GetInstance(IFormatProvider formatProvider) { }

	// RVA: 0x170D430 Offset: 0x170C630 VA: 0x18170D430 Slot: 4
	public object Clone() { }

	// RVA: 0x738180 Offset: 0x737380 VA: 0x180738180
	public int get_CurrencyDecimalDigits() { }

	// RVA: 0x170E9C0 Offset: 0x170DBC0 VA: 0x18170E9C0
	public void set_CurrencyDecimalDigits(int value) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public string get_CurrencyDecimalSeparator() { }

	// RVA: 0x170EAE0 Offset: 0x170DCE0 VA: 0x18170EAE0
	public void set_CurrencyDecimalSeparator(string value) { }

	// RVA: 0x6BF980 Offset: 0x6BEB80 VA: 0x1806BF980
	public bool get_IsReadOnly() { }

	// RVA: 0x170D2F0 Offset: 0x170C4F0 VA: 0x18170D2F0
	internal static void CheckGroupSize(string propName, int[] groupSize) { }

	// RVA: 0x170E560 Offset: 0x170D760 VA: 0x18170E560
	public int[] get_CurrencyGroupSizes() { }

	// RVA: 0x170ECB0 Offset: 0x170DEB0 VA: 0x18170ECB0
	public void set_CurrencyGroupSizes(int[] value) { }

	// RVA: 0x170E890 Offset: 0x170DA90 VA: 0x18170E890
	public int[] get_NumberGroupSizes() { }

	// RVA: 0x170F670 Offset: 0x170E870 VA: 0x18170F670
	public void set_NumberGroupSizes(int[] value) { }

	// RVA: 0x170E930 Offset: 0x170DB30 VA: 0x18170E930
	public int[] get_PercentGroupSizes() { }

	// RVA: 0x170FC60 Offset: 0x170EE60 VA: 0x18170FC60
	public void set_PercentGroupSizes(int[] value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public string get_CurrencyGroupSeparator() { }

	// RVA: 0x170EBF0 Offset: 0x170DDF0 VA: 0x18170EBF0
	public void set_CurrencyGroupSeparator(string value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public string get_CurrencySymbol() { }

	// RVA: 0x170F020 Offset: 0x170E220 VA: 0x18170F020
	public void set_CurrencySymbol(string value) { }

	// RVA: 0x170E5E0 Offset: 0x170D7E0 VA: 0x18170E5E0
	public static NumberFormatInfo get_CurrentInfo() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public string get_NaNSymbol() { }

	// RVA: 0x170F170 Offset: 0x170E370 VA: 0x18170F170
	public void set_NaNSymbol(string value) { }

	// RVA: 0x526D40 Offset: 0x525F40 VA: 0x180526D40
	public int get_CurrencyNegativePattern() { }

	// RVA: 0x170EDE0 Offset: 0x170DFE0 VA: 0x18170EDE0
	public void set_CurrencyNegativePattern(int value) { }

	// RVA: 0x170E910 Offset: 0x170DB10 VA: 0x18170E910
	public int get_NumberNegativePattern() { }

	// RVA: 0x170F7A0 Offset: 0x170E9A0 VA: 0x18170F7A0
	public void set_NumberNegativePattern(int value) { }

	// RVA: 0x5B5FB0 Offset: 0x5B51B0 VA: 0x1805B5FB0
	public int get_PercentPositivePattern() { }

	// RVA: 0x170FEB0 Offset: 0x170F0B0 VA: 0x18170FEB0
	public void set_PercentPositivePattern(int value) { }

	// RVA: 0x170E9B0 Offset: 0x170DBB0 VA: 0x18170E9B0
	public int get_PercentNegativePattern() { }

	// RVA: 0x170FD90 Offset: 0x170EF90 VA: 0x18170FD90
	public void set_PercentNegativePattern(int value) { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	public string get_NegativeInfinitySymbol() { }

	// RVA: 0x170F260 Offset: 0x170E460 VA: 0x18170F260
	public void set_NegativeInfinitySymbol(string value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_NegativeSign() { }

	// RVA: 0x170F2F0 Offset: 0x170E4F0 VA: 0x18170F2F0
	public void set_NegativeSign(string value) { }

	// RVA: 0x738040 Offset: 0x737240 VA: 0x180738040
	public int get_NumberDecimalDigits() { }

	// RVA: 0x170F380 Offset: 0x170E580 VA: 0x18170F380
	public void set_NumberDecimalDigits(int value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_NumberDecimalSeparator() { }

	// RVA: 0x170F4A0 Offset: 0x170E6A0 VA: 0x18170F4A0
	public void set_NumberDecimalSeparator(string value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public string get_NumberGroupSeparator() { }

	// RVA: 0x170F5B0 Offset: 0x170E7B0 VA: 0x18170F5B0
	public void set_NumberGroupSeparator(string value) { }

	// RVA: 0x738160 Offset: 0x737360 VA: 0x180738160
	public int get_CurrencyPositivePattern() { }

	// RVA: 0x170EF00 Offset: 0x170E100 VA: 0x18170EF00
	public void set_CurrencyPositivePattern(int value) { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public string get_PositiveInfinitySymbol() { }

	// RVA: 0x1710070 Offset: 0x170F270 VA: 0x181710070
	public void set_PositiveInfinitySymbol(string value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_PositiveSign() { }

	// RVA: 0x1710100 Offset: 0x170F300 VA: 0x181710100
	public void set_PositiveSign(string value) { }

	// RVA: 0x170E920 Offset: 0x170DB20 VA: 0x18170E920
	public int get_PercentDecimalDigits() { }

	// RVA: 0x170F960 Offset: 0x170EB60 VA: 0x18170F960
	public void set_PercentDecimalDigits(int value) { }

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	public string get_PercentDecimalSeparator() { }

	// RVA: 0x170FA80 Offset: 0x170EC80 VA: 0x18170FA80
	public void set_PercentDecimalSeparator(string value) { }

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	public string get_PercentGroupSeparator() { }

	// RVA: 0x170FBA0 Offset: 0x170EDA0 VA: 0x18170FBA0
	public void set_PercentGroupSeparator(string value) { }

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	public string get_PercentSymbol() { }

	// RVA: 0x170FFD0 Offset: 0x170F1D0 VA: 0x18170FFD0
	public void set_PercentSymbol(string value) { }

	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50
	public string get_PerMilleSymbol() { }

	// RVA: 0x170F8C0 Offset: 0x170EAC0 VA: 0x18170F8C0
	public void set_PerMilleSymbol(string value) { }

	// RVA: 0x170E810 Offset: 0x170DA10 VA: 0x18170E810
	public string[] get_NativeDigits() { }

	// RVA: 0x170F200 Offset: 0x170E400 VA: 0x18170F200
	public void set_NativeDigits(string[] value) { }

	// RVA: 0x170E6F0 Offset: 0x170D8F0 VA: 0x18170E6F0
	public DigitShapes get_DigitSubstitution() { }

	// RVA: 0x170F0B0 Offset: 0x170E2B0 VA: 0x18170F0B0
	public void set_DigitSubstitution(DigitShapes value) { }

	// RVA: 0x170D4A0 Offset: 0x170C6A0 VA: 0x18170D4A0 Slot: 5
	public object GetFormat(Type formatType) { }

	// RVA: 0x170D8A0 Offset: 0x170CAA0 VA: 0x18170D8A0
	public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi) { }

	// RVA: 0x170DA50 Offset: 0x170CC50 VA: 0x18170DA50
	internal static void ValidateParseStyleInteger(NumberStyles style) { }

	// RVA: 0x170D970 Offset: 0x170CB70 VA: 0x18170D970
	internal static void ValidateParseStyleFloatingPoint(NumberStyles style) { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class StringInfo // TypeDefIndex: 4301
{
	// Fields
	[OptionalField(VersionAdded = 2)]
	private string m_str; // 0x10
	private int[] m_indexes; // 0x18

	// Properties
	private int[] Indexes { get; }
	public string String { get; set; }
	public int LengthInTextElements { get; }

	// Methods

	// RVA: 0x1711680 Offset: 0x1710880 VA: 0x181711680
	public void .ctor() { }

	// RVA: 0x17115E0 Offset: 0x17107E0 VA: 0x1817115E0
	public void .ctor(string value) { }

	[OnDeserializing]
	// RVA: 0x1710F10 Offset: 0x1710110 VA: 0x181710F10
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserialized]
	// RVA: 0x1710EE0 Offset: 0x17100E0 VA: 0x181710EE0
	private void OnDeserialized(StreamingContext ctx) { }

	[ComVisible(False)]
	// RVA: 0x1710790 Offset: 0x170F990 VA: 0x181710790 Slot: 0
	public override bool Equals(object value) { }

	[ComVisible(False)]
	// RVA: 0x5BF760 Offset: 0x5BE960 VA: 0x1805BF760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1711740 Offset: 0x1710940 VA: 0x181711740
	private int[] get_Indexes() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_String() { }

	// RVA: 0x17117D0 Offset: 0x17109D0 VA: 0x1817117D0
	public void set_String(string value) { }

	// RVA: 0x1711780 Offset: 0x1710980 VA: 0x181711780
	public int get_LengthInTextElements() { }

	// RVA: 0x17114A0 Offset: 0x17106A0 VA: 0x1817114A0
	public string SubstringByTextElements(int startingTextElement) { }

	// RVA: 0x1711190 Offset: 0x1710390 VA: 0x181711190
	public string SubstringByTextElements(int startingTextElement, int lengthInTextElements) { }

	// RVA: 0x1710950 Offset: 0x170FB50 VA: 0x181710950
	public static string GetNextTextElement(string str) { }

	// RVA: 0x1710840 Offset: 0x170FA40 VA: 0x181710840
	internal static int GetCurrentTextElementLen(string str, int index, int len, ref UnicodeCategory ucCurrent, ref int currentCharCount) { }

	// RVA: 0x1710AC0 Offset: 0x170FCC0 VA: 0x181710AC0
	public static string GetNextTextElement(string str, int index) { }

	// RVA: 0x1710DA0 Offset: 0x170FFA0 VA: 0x181710DA0
	public static TextElementEnumerator GetTextElementEnumerator(string str) { }

	// RVA: 0x1710C40 Offset: 0x170FE40 VA: 0x181710C40
	public static TextElementEnumerator GetTextElementEnumerator(string str, int index) { }

	// RVA: 0x1710F50 Offset: 0x1710150 VA: 0x181710F50
	public static int[] ParseCombiningCharacters(string str) { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class TaiwanCalendar : Calendar // TypeDefIndex: 4302
{
	// Fields
	internal static EraInfo[] taiwanEraInfo; // 0x0
	internal static Calendar s_defaultInstance; // 0x8
	internal GregorianCalendarHelper helper; // 0x20
	internal static readonly DateTime calendarMinValue; // 0x10
	private const int DEFAULT_TWO_DIGIT_YEAR_MAX = 99;

	// Properties
	[ComVisible(False)]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime { get; }
	[ComVisible(False)]
	public override CalendarAlgorithmType AlgorithmType { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x1711870 Offset: 0x1710A70 VA: 0x181711870
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x1711DF0 Offset: 0x1710FF0 VA: 0x181711DF0 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x1711DA0 Offset: 0x1710FA0 VA: 0x181711DA0 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 9
	public override CalendarAlgorithmType get_AlgorithmType() { }

	// RVA: 0x1711C40 Offset: 0x1710E40 VA: 0x181711C40
	public void .ctor() { }

	// RVA: 0x68EEE0 Offset: 0x68E0E0 VA: 0x18068EEE0 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x16F8F90 Offset: 0x16F8190 VA: 0x1816F8F90 Slot: 16
	public override DateTime AddMonths(DateTime time, int months) { }

	// RVA: 0x170C4B0 Offset: 0x170B6B0 VA: 0x18170C4B0 Slot: 19
	public override DateTime AddYears(DateTime time, int years) { }

	// RVA: 0x16F9350 Offset: 0x16F8550 VA: 0x1816F9350 Slot: 24
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x170C530 Offset: 0x170B730 VA: 0x18170C530 Slot: 26
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x170C4D0 Offset: 0x170B6D0 VA: 0x18170C4D0 Slot: 20
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x170C4F0 Offset: 0x170B6F0 VA: 0x18170C4F0 Slot: 21
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x170C510 Offset: 0x170B710 VA: 0x18170C510 Slot: 22
	public override int GetDayOfYear(DateTime time) { }

	// RVA: 0x170C590 Offset: 0x170B790 VA: 0x18170C590 Slot: 34
	public override int GetMonthsInYear(int year, int era) { }

	[ComVisible(False)]
	// RVA: 0x16FA100 Offset: 0x16F9300 VA: 0x1816FA100 Slot: 37
	public override int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek) { }

	// RVA: 0x16FA000 Offset: 0x16F9200 VA: 0x1816FA000 Slot: 27
	public override int GetEra(DateTime time) { }

	// RVA: 0x170C570 Offset: 0x170B770 VA: 0x18170C570 Slot: 32
	public override int GetMonth(DateTime time) { }

	// RVA: 0x170C5B0 Offset: 0x170B7B0 VA: 0x18170C5B0 Slot: 38
	public override int GetYear(DateTime time) { }

	// RVA: 0x170C5D0 Offset: 0x170B7D0 VA: 0x18170C5D0 Slot: 40
	public override bool IsLeapDay(int year, int month, int day, int era) { }

	// RVA: 0x16FA560 Offset: 0x16F9760 VA: 0x1816FA560 Slot: 46
	public override bool IsLeapYear(int year, int era) { }

	[ComVisible(False)]
	// RVA: 0x170C550 Offset: 0x170B750 VA: 0x18170C550 Slot: 44
	public override int GetLeapMonth(int year, int era) { }

	// RVA: 0x170C600 Offset: 0x170B800 VA: 0x18170C600 Slot: 42
	public override bool IsLeapMonth(int year, int month, int era) { }

	// RVA: 0x170C630 Offset: 0x170B830 VA: 0x18170C630 Slot: 48
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x16FAAF0 Offset: 0x16F9CF0 VA: 0x1816FAAF0 Slot: 28
	public override int[] get_Eras() { }

	// RVA: 0x1711E40 Offset: 0x1711040 VA: 0x181711E40 Slot: 53
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x1711E90 Offset: 0x1711090 VA: 0x181711E90 Slot: 54
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x1711950 Offset: 0x1710B50 VA: 0x181711950 Slot: 55
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x1711AF0 Offset: 0x1710CF0 VA: 0x181711AF0
	private static void .cctor() { }
}

// Namespace: System.Globalization
[Serializable]
public class TaiwanLunisolarCalendar : EastAsianLunisolarCalendar // TypeDefIndex: 4303
{
	// Fields
	internal static EraInfo[] taiwanLunisolarEraInfo; // 0x0
	internal GregorianCalendarHelper helper; // 0x20
	internal const int MIN_LUNISOLAR_YEAR = 1912;
	internal const int MAX_LUNISOLAR_YEAR = 2050;
	internal const int MIN_GREGORIAN_YEAR = 1912;
	internal const int MIN_GREGORIAN_MONTH = 2;
	internal const int MIN_GREGORIAN_DAY = 18;
	internal const int MAX_GREGORIAN_YEAR = 2051;
	internal const int MAX_GREGORIAN_MONTH = 2;
	internal const int MAX_GREGORIAN_DAY = 10;
	internal static DateTime minDate; // 0x8
	internal static DateTime maxDate; // 0x10
	private static readonly int[,] yinfo; // 0x18

	// Properties
	public override DateTime MinSupportedDateTime { get; }
	public override DateTime MaxSupportedDateTime { get; }
	protected override int DaysInYearBeforeMinSupportedYear { get; }
	internal override int MinCalendarYear { get; }
	internal override int MaxCalendarYear { get; }
	internal override DateTime MinDate { get; }
	internal override DateTime MaxDate { get; }
	internal override EraInfo[] CalEraInfo { get; }
	internal override int BaseCalendarID { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }

	// Methods

	// RVA: 0x1712660 Offset: 0x1711860 VA: 0x181712660 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x17125B0 Offset: 0x17117B0 VA: 0x1817125B0 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x16EC420 Offset: 0x16EB620 VA: 0x1816EC420 Slot: 36
	protected override int get_DaysInYearBeforeMinSupportedYear() { }

	// RVA: 0x1712600 Offset: 0x1711800 VA: 0x181712600 Slot: 60
	internal override int get_MinCalendarYear() { }

	// RVA: 0x170D190 Offset: 0x170C390 VA: 0x18170D190 Slot: 61
	internal override int get_MaxCalendarYear() { }

	// RVA: 0x1712610 Offset: 0x1711810 VA: 0x181712610 Slot: 63
	internal override DateTime get_MinDate() { }

	// RVA: 0x1712560 Offset: 0x1711760 VA: 0x181712560 Slot: 64
	internal override DateTime get_MaxDate() { }

	// RVA: 0x1712500 Offset: 0x1711700 VA: 0x181712500 Slot: 62
	internal override EraInfo[] get_CalEraInfo() { }

	// RVA: 0x1712000 Offset: 0x1711200 VA: 0x181712000 Slot: 57
	internal override int GetYearInfo(int LunarYear, int Index) { }

	// RVA: 0x17121A0 Offset: 0x17113A0 VA: 0x1817121A0 Slot: 58
	internal override int GetYear(int year, DateTime time) { }

	// RVA: 0x1711FE0 Offset: 0x17111E0 VA: 0x181711FE0 Slot: 59
	internal override int GetGregorianYear(int year, int era) { }

	// RVA: 0x1712430 Offset: 0x1711630 VA: 0x181712430
	public void .ctor() { }

	// RVA: 0x16FA000 Offset: 0x16F9200 VA: 0x1816FA000 Slot: 27
	public override int GetEra(DateTime time) { }

	// RVA: 0x68EEE0 Offset: 0x68E0E0 VA: 0x18068EEE0 Slot: 8
	internal override int get_BaseCalendarID() { }

	// RVA: 0x1712550 Offset: 0x1711750 VA: 0x181712550 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x16FAAF0 Offset: 0x16F9CF0 VA: 0x1816FAAF0 Slot: 28
	public override int[] get_Eras() { }

	// RVA: 0x17121C0 Offset: 0x17113C0 VA: 0x1817121C0
	private static void .cctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class TextElementEnumerator : IEnumerator // TypeDefIndex: 4304
{
	// Fields
	private string str; // 0x10
	private int index; // 0x18
	private int startIndex; // 0x1C
	private int strLen; // 0x20
	private int currTextElementLen; // 0x24
	[OptionalField(VersionAdded = 2)]
	private UnicodeCategory uc; // 0x28
	[OptionalField(VersionAdded = 2)]
	private int charLen; // 0x2C
	private int endIndex; // 0x30
	private int nextTextElementLen; // 0x34

	// Properties
	public object Current { get; }
	public int ElementIndex { get; }

	// Methods

	// RVA: 0x17128D0 Offset: 0x1711AD0 VA: 0x1817128D0
	internal void .ctor(string str, int startIndex, int strLen) { }

	[OnDeserializing]
	// RVA: 0x1712850 Offset: 0x1711A50 VA: 0x181712850
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserialized]
	// RVA: 0x1712810 Offset: 0x1711A10 VA: 0x181712810
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializing]
	// RVA: 0x1712860 Offset: 0x1711A60 VA: 0x181712860
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x17127B0 Offset: 0x17119B0 VA: 0x1817127B0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x17126B0 Offset: 0x17118B0 VA: 0x1817126B0 Slot: 5
	public object get_Current() { }

	// RVA: 0x17126B0 Offset: 0x17118B0 VA: 0x1817126B0
	public string GetTextElement() { }

	// RVA: 0x1712940 Offset: 0x1711B40 VA: 0x181712940
	public int get_ElementIndex() { }

	// RVA: 0x1712870 Offset: 0x1711A70 VA: 0x181712870 Slot: 6
	public void Reset() { }

	// RVA: 0x17128A0 Offset: 0x1711AA0 VA: 0x1817128A0
	internal void .ctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class TextInfo : ICloneable, IDeserializationCallback // TypeDefIndex: 4305
{
	// Fields
	[OptionalField(VersionAdded = 2)]
	private string m_listSeparator; // 0x10
	[OptionalField(VersionAdded = 2)]
	private bool m_isReadOnly; // 0x18
	[OptionalField(VersionAdded = 3)]
	private string m_cultureName; // 0x20
	private CultureData m_cultureData; // 0x28
	private string m_textInfoName; // 0x30
	private Nullable<bool> m_IsAsciiCasingSameAsInvariant; // 0x38
	internal static TextInfo s_Invariant; // 0x0
	[OptionalField(VersionAdded = 2)]
	private string customCultureName; // 0x40
	[OptionalField(VersionAdded = 1)]
	internal int m_nDataItem; // 0x48
	[OptionalField(VersionAdded = 1)]
	internal bool m_useUserOverride; // 0x4C
	[OptionalField(VersionAdded = 1)]
	internal int m_win32LangID; // 0x50
	private const int wordSeparatorMask = 536672256;

	// Properties
	internal static TextInfo Invariant { get; }
	public virtual int ANSICodePage { get; }
	public virtual int OEMCodePage { get; }
	public virtual int MacCodePage { get; }
	public virtual int EBCDICCodePage { get; }
	[ComVisible(False)]
	public int LCID { get; }
	[ComVisible(False)]
	public string CultureName { get; }
	[ComVisible(False)]
	public bool IsReadOnly { get; }
	public virtual string ListSeparator { get; set; }
	private bool IsAsciiCasingSameAsInvariant { get; }
	[ComVisible(False)]
	public bool IsRightToLeft { get; }

	// Methods

	// RVA: 0x1715220 Offset: 0x1714420 VA: 0x181715220
	internal static TextInfo get_Invariant() { }

	// RVA: 0x1715160 Offset: 0x1714360 VA: 0x181715160
	internal void .ctor(CultureData cultureData) { }

	[OnDeserializing]
	// RVA: 0x17138E0 Offset: 0x1712AE0 VA: 0x1817138E0
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x17137E0 Offset: 0x17129E0 VA: 0x1817137E0
	private void OnDeserialized() { }

	[OnDeserialized]
	// RVA: 0x17138D0 Offset: 0x1712AD0 VA: 0x1817138D0
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializing]
	// RVA: 0x17138F0 Offset: 0x1712AF0 VA: 0x1817138F0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x1713120 Offset: 0x1712320 VA: 0x181713120
	internal static int GetHashCodeOrdinalIgnoreCase(string s) { }

	// RVA: 0x1713210 Offset: 0x1712410 VA: 0x181713210
	internal static int GetHashCodeOrdinalIgnoreCase(string s, bool forceRandomizedHashing, long additionalEntropy) { }

	// RVA: 0x1712E60 Offset: 0x1712060 VA: 0x181712E60
	internal static int CompareOrdinalIgnoreCaseEx(string strA, int indexA, string strB, int indexB, int lengthA, int lengthB) { }

	// RVA: 0x1713460 Offset: 0x1712660 VA: 0x181713460
	internal static int IndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count) { }

	// RVA: 0x1713720 Offset: 0x1712920 VA: 0x181713720
	internal static int LastIndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count) { }

	// RVA: 0x17151E0 Offset: 0x17143E0 VA: 0x1817151E0 Slot: 6
	public virtual int get_ANSICodePage() { }

	// RVA: 0x17154A0 Offset: 0x17146A0 VA: 0x1817154A0 Slot: 7
	public virtual int get_OEMCodePage() { }

	// RVA: 0x1715480 Offset: 0x1714680 VA: 0x181715480 Slot: 8
	public virtual int get_MacCodePage() { }

	// RVA: 0x1715200 Offset: 0x1714400 VA: 0x181715200 Slot: 9
	public virtual int get_EBCDICCodePage() { }

	// RVA: 0x17153E0 Offset: 0x17145E0 VA: 0x1817153E0
	public int get_LCID() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_CultureName() { }

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_IsReadOnly() { }

	[ComVisible(False)]
	// RVA: 0x1712D80 Offset: 0x1711F80 VA: 0x181712D80 Slot: 10
	public virtual object Clone() { }

	[ComVisible(False)]
	// RVA: 0x1713980 Offset: 0x1712B80 VA: 0x181713980
	public static TextInfo ReadOnly(TextInfo textInfo) { }

	// RVA: 0x17150E0 Offset: 0x17142E0 VA: 0x1817150E0
	private void VerifyWritable() { }

	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	internal void SetReadOnlyState(bool readOnly) { }

	// RVA: 0x1715450 Offset: 0x1714650 VA: 0x181715450 Slot: 11
	public virtual string get_ListSeparator() { }

	[ComVisible(False)]
	// RVA: 0x17154C0 Offset: 0x17146C0 VA: 0x1817154C0 Slot: 12
	public virtual void set_ListSeparator(string value) { }

	// RVA: 0x1714180 Offset: 0x1713380 VA: 0x181714180 Slot: 13
	public virtual char ToLower(char c) { }

	// RVA: 0x17141E0 Offset: 0x17133E0 VA: 0x1817141E0 Slot: 14
	public virtual string ToLower(string str) { }

	// RVA: 0x1713B30 Offset: 0x1712D30 VA: 0x181713B30
	private static char ToLowerAsciiInvariant(char c) { }

	// RVA: 0x1715080 Offset: 0x1714280 VA: 0x181715080 Slot: 15
	public virtual char ToUpper(char c) { }

	// RVA: 0x1714F40 Offset: 0x1714140 VA: 0x181714F40 Slot: 16
	public virtual string ToUpper(string str) { }

	// RVA: 0x1714800 Offset: 0x1713A00 VA: 0x181714800
	internal static char ToUpperAsciiInvariant(char c) { }

	// RVA: 0x17136F0 Offset: 0x17128F0 VA: 0x1817136F0
	private static bool IsAscii(char c) { }

	// RVA: 0x17152E0 Offset: 0x17144E0 VA: 0x1817152E0
	private bool get_IsAsciiCasingSameAsInvariant() { }

	// RVA: 0x1712E70 Offset: 0x1712070 VA: 0x181712E70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1713320 Offset: 0x1712520 VA: 0x181713320 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1714320 Offset: 0x1713520 VA: 0x181714320 Slot: 3
	public override string ToString() { }

	// RVA: 0x1714370 Offset: 0x1713570 VA: 0x181714370
	public string ToTitleCase(string str) { }

	// RVA: 0x17129C0 Offset: 0x1711BC0 VA: 0x1817129C0
	private static int AddNonLetter(ref StringBuilder result, ref string input, int inputIndex, int charLen) { }

	// RVA: 0x1712A60 Offset: 0x1711C60 VA: 0x181712A60
	private int AddTitlecaseLetter(ref StringBuilder result, ref string input, int inputIndex, int charLen) { }

	// RVA: 0x1713710 Offset: 0x1712910 VA: 0x181713710
	private static bool IsWordSeparator(UnicodeCategory category) { }

	// RVA: 0x1713700 Offset: 0x1712900 VA: 0x181713700
	private static bool IsLetterCategory(UnicodeCategory uc) { }

	// RVA: 0x17153C0 Offset: 0x17145C0 VA: 0x1817153C0
	public bool get_IsRightToLeft() { }

	// RVA: 0x17138D0 Offset: 0x1712AD0 VA: 0x1817138D0 Slot: 5
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x1713100 Offset: 0x1712300 VA: 0x181713100
	internal int GetCaseInsensitiveHashCode(string str) { }

	// RVA: 0x1712F20 Offset: 0x1712120 VA: 0x181712F20
	internal int GetCaseInsensitiveHashCode(string str, bool forceRandomizedHashing, long additionalEntropy) { }

	// RVA: 0x1713350 Offset: 0x1712550 VA: 0x181713350
	private int GetInvariantCaseInsensitiveHashCode(string str) { }

	// RVA: 0x1714E50 Offset: 0x1714050 VA: 0x181714E50
	private string ToUpperInternal(string str) { }

	// RVA: 0x1714090 Offset: 0x1713290 VA: 0x181714090
	private string ToLowerInternal(string str) { }

	// RVA: 0x1714820 Offset: 0x1713A20 VA: 0x181714820
	private char ToUpperInternal(char c) { }

	// RVA: 0x1713B50 Offset: 0x1712D50 VA: 0x181713B50
	private char ToLowerInternal(char c) { }

	// RVA: 0x1713530 Offset: 0x1712730 VA: 0x181713530
	internal static int InternalCompareStringOrdinalIgnoreCase(string strA, int indexA, string strB, int indexB, int lenA, int lenB) { }

	// RVA: 0x1713A80 Offset: 0x1712C80 VA: 0x181713A80
	internal void ToLowerAsciiInvariant(ReadOnlySpan<char> source, Span<char> destination) { }

	// RVA: 0x1714740 Offset: 0x1713940 VA: 0x181714740
	internal void ToUpperAsciiInvariant(ReadOnlySpan<char> source, Span<char> destination) { }

	// RVA: 0x1712C30 Offset: 0x1711E30 VA: 0x181712C30
	internal void ChangeCase(ReadOnlySpan<char> source, Span<char> destination, bool toUpper) { }

	// RVA: 0x17151B0 Offset: 0x17143B0 VA: 0x1817151B0
	internal void .ctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class ThaiBuddhistCalendar : Calendar // TypeDefIndex: 4306
{
	// Fields
	internal static EraInfo[] thaiBuddhistEraInfo; // 0x0
	public const int ThaiBuddhistEra = 1;
	internal GregorianCalendarHelper helper; // 0x20
	private const int DEFAULT_TWO_DIGIT_YEAR_MAX = 2572;

	// Properties
	[ComVisible(False)]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime { get; }
	[ComVisible(False)]
	public override CalendarAlgorithmType AlgorithmType { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x1715860 Offset: 0x1714A60 VA: 0x181715860 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x1715810 Offset: 0x1714A10 VA: 0x181715810 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 9
	public override CalendarAlgorithmType get_AlgorithmType() { }

	// RVA: 0x1715760 Offset: 0x1714960 VA: 0x181715760
	public void .ctor() { }

	// RVA: 0x68EEF0 Offset: 0x68E0F0 VA: 0x18068EEF0 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x16F8F90 Offset: 0x16F8190 VA: 0x1816F8F90 Slot: 16
	public override DateTime AddMonths(DateTime time, int months) { }

	// RVA: 0x170C4B0 Offset: 0x170B6B0 VA: 0x18170C4B0 Slot: 19
	public override DateTime AddYears(DateTime time, int years) { }

	// RVA: 0x16F9350 Offset: 0x16F8550 VA: 0x1816F9350 Slot: 24
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x170C530 Offset: 0x170B730 VA: 0x18170C530 Slot: 26
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x170C4D0 Offset: 0x170B6D0 VA: 0x18170C4D0 Slot: 20
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x170C4F0 Offset: 0x170B6F0 VA: 0x18170C4F0 Slot: 21
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x170C510 Offset: 0x170B710 VA: 0x18170C510 Slot: 22
	public override int GetDayOfYear(DateTime time) { }

	// RVA: 0x170C590 Offset: 0x170B790 VA: 0x18170C590 Slot: 34
	public override int GetMonthsInYear(int year, int era) { }

	[ComVisible(False)]
	// RVA: 0x16FA100 Offset: 0x16F9300 VA: 0x1816FA100 Slot: 37
	public override int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek) { }

	// RVA: 0x16FA000 Offset: 0x16F9200 VA: 0x1816FA000 Slot: 27
	public override int GetEra(DateTime time) { }

	// RVA: 0x170C570 Offset: 0x170B770 VA: 0x18170C570 Slot: 32
	public override int GetMonth(DateTime time) { }

	// RVA: 0x170C5B0 Offset: 0x170B7B0 VA: 0x18170C5B0 Slot: 38
	public override int GetYear(DateTime time) { }

	// RVA: 0x170C5D0 Offset: 0x170B7D0 VA: 0x18170C5D0 Slot: 40
	public override bool IsLeapDay(int year, int month, int day, int era) { }

	// RVA: 0x16FA560 Offset: 0x16F9760 VA: 0x1816FA560 Slot: 46
	public override bool IsLeapYear(int year, int era) { }

	[ComVisible(False)]
	// RVA: 0x170C550 Offset: 0x170B750 VA: 0x18170C550 Slot: 44
	public override int GetLeapMonth(int year, int era) { }

	// RVA: 0x170C600 Offset: 0x170B800 VA: 0x18170C600 Slot: 42
	public override bool IsLeapMonth(int year, int month, int era) { }

	// RVA: 0x170C630 Offset: 0x170B830 VA: 0x18170C630 Slot: 48
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x16FAAF0 Offset: 0x16F9CF0 VA: 0x1816FAAF0 Slot: 28
	public override int[] get_Eras() { }

	// RVA: 0x17158B0 Offset: 0x1714AB0 VA: 0x1817158B0 Slot: 53
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x1715900 Offset: 0x1714B00 VA: 0x181715900 Slot: 54
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x17155A0 Offset: 0x17147A0 VA: 0x1817155A0 Slot: 55
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x1715660 Offset: 0x1714860 VA: 0x181715660
	private static void .cctor() { }
}

// Namespace: 
internal struct UmAlQuraCalendar.DateMapping // TypeDefIndex: 4307
{
	// Fields
	internal int HijriMonthsLengthFlags; // 0x0
	internal DateTime GregorianDate; // 0x8

	// Methods

	// RVA: 0x1701EE0 Offset: 0x17010E0 VA: 0x181701EE0
	internal void .ctor(int MonthsLengthFlags, int GYear, int GMonth, int GDay) { }
}

// Namespace: System.Globalization
[Serializable]
public class UmAlQuraCalendar : Calendar // TypeDefIndex: 4308
{
	// Fields
	internal const int MinCalendarYear = 1318;
	internal const int MaxCalendarYear = 1500;
	private static readonly UmAlQuraCalendar.DateMapping[] HijriYearInfo; // 0x0
	public const int UmAlQuraEra = 1;
	internal const int DateCycle = 30;
	internal const int DatePartYear = 0;
	internal const int DatePartDayOfYear = 1;
	internal const int DatePartMonth = 2;
	internal const int DatePartDay = 3;
	internal static DateTime minDate; // 0x8
	internal static DateTime maxDate; // 0x10
	private const int DEFAULT_TWO_DIGIT_YEAR_MAX = 1451;

	// Properties
	public override DateTime MinSupportedDateTime { get; }
	public override DateTime MaxSupportedDateTime { get; }
	public override CalendarAlgorithmType AlgorithmType { get; }
	internal override int BaseCalendarID { get; }
	internal override int ID { get; }
	protected override int DaysInYearBeforeMinSupportedYear { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x1716DF0 Offset: 0x1715FF0 VA: 0x181716DF0
	private static UmAlQuraCalendar.DateMapping[] InitDateMapping() { }

	// RVA: 0x1717A70 Offset: 0x1716C70 VA: 0x181717A70 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x1717A20 Offset: 0x1716C20 VA: 0x181717A20 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 9
	public override CalendarAlgorithmType get_AlgorithmType() { }

	// RVA: 0x1717990 Offset: 0x1716B90 VA: 0x181717990
	public void .ctor() { }

	// RVA: 0x16F8530 Offset: 0x16F7730 VA: 0x1816F8530 Slot: 8
	internal override int get_BaseCalendarID() { }

	// RVA: 0x1717A10 Offset: 0x1716C10 VA: 0x181717A10 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x17179A0 Offset: 0x1716BA0 VA: 0x1817179A0 Slot: 36
	protected override int get_DaysInYearBeforeMinSupportedYear() { }

	// RVA: 0x17165B0 Offset: 0x17157B0 VA: 0x1817165B0
	private static void ConvertHijriToGregorian(int HijriYear, int HijriMonth, int HijriDay, ref int yg, ref int mg, ref int dg) { }

	// RVA: 0x1716720 Offset: 0x1715920 VA: 0x181716720
	private static long GetAbsoluteDateUmAlQura(int year, int month, int day) { }

	// RVA: 0x1715E00 Offset: 0x1715000 VA: 0x181715E00
	internal static void CheckTicksRange(long ticks) { }

	// RVA: 0x1715D70 Offset: 0x1714F70 VA: 0x181715D70
	internal static void CheckEraRange(int era) { }

	// RVA: 0x17160D0 Offset: 0x17152D0 VA: 0x1817160D0
	internal static void CheckYearRange(int year, int era) { }

	// RVA: 0x1716000 Offset: 0x1715200 VA: 0x181716000
	internal static void CheckYearMonthRange(int year, int month, int era) { }

	// RVA: 0x1716290 Offset: 0x1715490 VA: 0x181716290
	private static void ConvertGregorianToHijri(DateTime time, ref int HijriYear, ref int HijriMonth, ref int HijriDay) { }

	// RVA: 0x17168E0 Offset: 0x1715AE0 VA: 0x1817168E0 Slot: 56
	internal virtual int GetDatePart(DateTime time, int part) { }

	// RVA: 0x1715A50 Offset: 0x1714C50 VA: 0x181715A50 Slot: 16
	public override DateTime AddMonths(DateTime time, int months) { }

	// RVA: 0x16F1F20 Offset: 0x16F1120 VA: 0x1816F1F20 Slot: 19
	public override DateTime AddYears(DateTime time, int years) { }

	// RVA: 0x1716A90 Offset: 0x1715C90 VA: 0x181716A90 Slot: 20
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x1716AB0 Offset: 0x1715CB0 VA: 0x181716AB0 Slot: 21
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x1716B30 Offset: 0x1715D30 VA: 0x181716B30 Slot: 22
	public override int GetDayOfYear(DateTime time) { }

	// RVA: 0x1716B50 Offset: 0x1715D50 VA: 0x181716B50 Slot: 24
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x1717200 Offset: 0x1716400 VA: 0x181717200
	internal static int RealGetDaysInYear(int year) { }

	// RVA: 0x1716C10 Offset: 0x1715E10 VA: 0x181716C10 Slot: 26
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x1716C70 Offset: 0x1715E70 VA: 0x181716C70 Slot: 27
	public override int GetEra(DateTime time) { }

	// RVA: 0x17179B0 Offset: 0x1716BB0 VA: 0x1817179B0 Slot: 28
	public override int[] get_Eras() { }

	// RVA: 0x1716D50 Offset: 0x1715F50 VA: 0x181716D50 Slot: 32
	public override int GetMonth(DateTime time) { }

	// RVA: 0x1716D70 Offset: 0x1715F70 VA: 0x181716D70 Slot: 34
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x1716DD0 Offset: 0x1715FD0 VA: 0x181716DD0 Slot: 38
	public override int GetYear(DateTime time) { }

	// RVA: 0x1716F80 Offset: 0x1716180 VA: 0x181716F80 Slot: 40
	public override bool IsLeapDay(int year, int month, int day, int era) { }

	// RVA: 0x1716CF0 Offset: 0x1715EF0 VA: 0x181716CF0 Slot: 44
	public override int GetLeapMonth(int year, int era) { }

	// RVA: 0x1717120 Offset: 0x1716320 VA: 0x181717120 Slot: 42
	public override bool IsLeapMonth(int year, int month, int era) { }

	// RVA: 0x1717190 Offset: 0x1716390 VA: 0x181717190 Slot: 46
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x17172A0 Offset: 0x17164A0 VA: 0x1817172A0 Slot: 48
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x1717AC0 Offset: 0x1716CC0 VA: 0x181717AC0 Slot: 53
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x1717B10 Offset: 0x1716D10 VA: 0x181717B10 Slot: 54
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x1717510 Offset: 0x1716710 VA: 0x181717510 Slot: 55
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x17176B0 Offset: 0x17168B0 VA: 0x1817176B0
	private static void .cctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class SortKey // TypeDefIndex: 4309
{
	// Fields
	private readonly string source; // 0x10
	private readonly byte[] key; // 0x18
	private readonly CompareOptions options; // 0x20
	private readonly int lcid; // 0x24

	// Properties
	public virtual string OriginalString { get; }
	public virtual byte[] KeyData { get; }

	// Methods

	// RVA: 0x1710190 Offset: 0x170F390 VA: 0x181710190
	public static int Compare(SortKey sortkey1, SortKey sortkey2) { }

	// RVA: 0x1710690 Offset: 0x170F890 VA: 0x181710690
	internal void .ctor(int lcid, string source, CompareOptions opt) { }

	// RVA: 0x17105F0 Offset: 0x170F7F0 VA: 0x1817105F0
	internal void .ctor(int lcid, string source, byte[] buffer, CompareOptions opt, int lv1Length, int lv2Length, int lv3Length, int kanaSmallLength, int markTypeLength, int katakanaLength, int kanaWidthLength, int identLength) { }

	// RVA: 0x1710640 Offset: 0x170F840 VA: 0x181710640
	internal void .ctor(string localeName, string str, CompareOptions options, byte[] keyData) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public virtual string get_OriginalString() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 5
	public virtual byte[] get_KeyData() { }

	// RVA: 0x17103B0 Offset: 0x170F5B0 VA: 0x1817103B0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1710460 Offset: 0x170F660 VA: 0x181710460 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17104D0 Offset: 0x170F6D0 VA: 0x1817104D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1710760 Offset: 0x170F960 VA: 0x181710760
	internal void .ctor() { }
}

// Namespace: System.Globalization
internal interface ISimpleCollator // TypeDefIndex: 4310
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract SortKey GetSortKey(string source, CompareOptions options);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int Compare(string s1, string s2);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool IsPrefix(string src, string target, CompareOptions opt);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool IsSuffix(string src, string target, CompareOptions opt);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int IndexOf(string s, string target, int start, int length, CompareOptions opt);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int IndexOf(string s, char target, int start, int length, CompareOptions opt);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int LastIndexOf(string s, string target, CompareOptions opt);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int LastIndexOf(string s, string target, int start, int length, CompareOptions opt);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int LastIndexOf(string s, char target, CompareOptions opt);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int LastIndexOf(string s, char target, int start, int length, CompareOptions opt);
}

// Namespace: 
internal struct CultureData.NumberFormatEntryManaged // TypeDefIndex: 4311
{
	// Fields
	internal int currency_decimal_digits; // 0x0
	internal int currency_decimal_separator; // 0x4
	internal int currency_group_separator; // 0x8
	internal int currency_group_sizes0; // 0xC
	internal int currency_group_sizes1; // 0x10
	internal int currency_negative_pattern; // 0x14
	internal int currency_positive_pattern; // 0x18
	internal int currency_symbol; // 0x1C
	internal int nan_symbol; // 0x20
	internal int negative_infinity_symbol; // 0x24
	internal int negative_sign; // 0x28
	internal int number_decimal_digits; // 0x2C
	internal int number_decimal_separator; // 0x30
	internal int number_group_separator; // 0x34
	internal int number_group_sizes0; // 0x38
	internal int number_group_sizes1; // 0x3C
	internal int number_negative_pattern; // 0x40
	internal int per_mille_symbol; // 0x44
	internal int percent_negative_pattern; // 0x48
	internal int percent_positive_pattern; // 0x4C
	internal int percent_symbol; // 0x50
	internal int positive_infinity_symbol; // 0x54
	internal int positive_sign; // 0x58
}

// Namespace: System.Globalization
internal class CultureData // TypeDefIndex: 4312
{
	// Fields
	private string sAM1159; // 0x10
	private string sPM2359; // 0x18
	private string sTimeSeparator; // 0x20
	private string[] saLongTimes; // 0x28
	private string[] saShortTimes; // 0x30
	private int iFirstDayOfWeek; // 0x38
	private int iFirstWeekOfYear; // 0x3C
	private int[] waCalendars; // 0x40
	private CalendarData[] calendars; // 0x48
	private string sISO639Language; // 0x50
	private readonly string sRealName; // 0x58
	private bool bUseOverrides; // 0x60
	private int calendarId; // 0x64
	private int numberIndex; // 0x68
	private int iDefaultAnsiCodePage; // 0x6C
	private int iDefaultOemCodePage; // 0x70
	private int iDefaultMacCodePage; // 0x74
	private int iDefaultEbcdicCodePage; // 0x78
	private bool isRightToLeft; // 0x7C
	private string sListSeparator; // 0x80
	private static CultureData s_Invariant; // 0x0

	// Properties
	public static CultureData Invariant { get; }
	internal string[] LongTimes { get; }
	internal string[] ShortTimes { get; }
	internal string SISO639LANGNAME { get; }
	internal int IFIRSTDAYOFWEEK { get; }
	internal int IFIRSTWEEKOFYEAR { get; }
	internal string SAM1159 { get; }
	internal string SPM2359 { get; }
	internal string TimeSeparator { get; }
	internal int[] CalendarIds { get; }
	internal bool IsInvariantCulture { get; }
	internal string CultureName { get; }
	internal string SCOMPAREINFO { get; }
	internal string STEXTINFO { get; }
	internal int ILANGUAGE { get; }
	internal int IDEFAULTANSICODEPAGE { get; }
	internal int IDEFAULTOEMCODEPAGE { get; }
	internal int IDEFAULTMACCODEPAGE { get; }
	internal int IDEFAULTEBCDICCODEPAGE { get; }
	internal bool IsRightToLeft { get; }
	internal string SLIST { get; }
	internal bool UseUserOverride { get; }

	// Methods

	// RVA: 0x1701810 Offset: 0x1700A10 VA: 0x181701810
	private void .ctor(string name) { }

	// RVA: 0x1701AC0 Offset: 0x1700CC0 VA: 0x181701AC0
	public static CultureData get_Invariant() { }

	// RVA: 0x1700CB0 Offset: 0x16FFEB0 VA: 0x181700CB0
	public static CultureData GetCultureData(string cultureName, bool useUserOverride) { }

	// RVA: 0x1700BC0 Offset: 0x16FFDC0 VA: 0x181700BC0
	public static CultureData GetCultureData(string cultureName, bool useUserOverride, int datetimeIndex, int calendarId, int numberIndex, string iso2lang, int ansiCodePage, int oemCodePage, int macCodePage, int ebcdicCodePage, bool rightToLeft, string listSeparator) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	internal static CultureData GetCultureData(int culture, bool bUseUserOverride) { }

	// RVA: 0x17018F0 Offset: 0x1700AF0 VA: 0x1817018F0
	private void fill_culture_data(int datetimeIndex) { }

	// RVA: 0x1700A90 Offset: 0x16FFC90 VA: 0x181700A90
	public CalendarData GetCalendar(int calendarId) { }

	// RVA: 0xC3C900 Offset: 0xC3BB00 VA: 0x180C3C900
	internal string[] get_LongTimes() { }

	// RVA: 0x1701E40 Offset: 0x1701040 VA: 0x181701E40
	internal string[] get_ShortTimes() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	internal string get_SISO639LANGNAME() { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	internal int get_IFIRSTDAYOFWEEK() { }

	// RVA: 0x15FEBE0 Offset: 0x15FDDE0 VA: 0x1815FEBE0
	internal int get_IFIRSTWEEKOFYEAR() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal string get_SAM1159() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal string get_SPM2359() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal string get_TimeSeparator() { }

	// RVA: 0x1701910 Offset: 0x1700B10 VA: 0x181701910
	internal int[] get_CalendarIds() { }

	// RVA: 0x1700800 Offset: 0x16FFA00 VA: 0x181700800
	internal CalendarId[] GetCalendarIds() { }

	// RVA: 0x1701DF0 Offset: 0x1700FF0 VA: 0x181701DF0
	internal bool get_IsInvariantCulture() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	internal string get_CultureName() { }

	// RVA: 0x1701E10 Offset: 0x1701010 VA: 0x181701E10
	internal string get_SCOMPAREINFO() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	internal string get_STEXTINFO() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	internal int get_ILANGUAGE() { }

	// RVA: 0x526CA0 Offset: 0x525EA0 VA: 0x180526CA0
	internal int get_IDEFAULTANSICODEPAGE() { }

	// RVA: 0x526CC0 Offset: 0x525EC0 VA: 0x180526CC0
	internal int get_IDEFAULTOEMCODEPAGE() { }

	// RVA: 0x526C90 Offset: 0x525E90 VA: 0x180526C90
	internal int get_IDEFAULTMACCODEPAGE() { }

	// RVA: 0x4ED990 Offset: 0x4ECB90 VA: 0x1804ED990
	internal int get_IDEFAULTEBCDICCODEPAGE() { }

	// RVA: 0x1701E00 Offset: 0x1701000 VA: 0x181701E00
	internal bool get_IsRightToLeft() { }

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	internal string get_SLIST() { }

	// RVA: 0x4EE290 Offset: 0x4ED490 VA: 0x1804EE290
	internal bool get_UseUserOverride() { }

	// RVA: 0x17006B0 Offset: 0x16FF8B0 VA: 0x1817006B0
	internal string CalendarName(int calendarId) { }

	// RVA: 0x17007C0 Offset: 0x16FF9C0 VA: 0x1817007C0
	internal string[] EraNames(int calendarId) { }

	// RVA: 0x1700600 Offset: 0x16FF800 VA: 0x181700600
	internal string[] AbbrevEraNames(int calendarId) { }

	// RVA: 0x1700640 Offset: 0x16FF840 VA: 0x181700640
	internal string[] AbbreviatedEnglishEraNames(int calendarId) { }

	// RVA: 0x1701610 Offset: 0x1700810 VA: 0x181701610
	internal string[] ShortDates(int calendarId) { }

	// RVA: 0x17015B0 Offset: 0x17007B0 VA: 0x1817015B0
	internal string[] LongDates(int calendarId) { }

	// RVA: 0x17017F0 Offset: 0x17009F0 VA: 0x1817017F0
	internal string[] YearMonths(int calendarId) { }

	// RVA: 0x17007A0 Offset: 0x16FF9A0 VA: 0x1817007A0
	internal string[] DayNames(int calendarId) { }

	// RVA: 0x1700620 Offset: 0x16FF820 VA: 0x181700620
	internal string[] AbbreviatedDayNames(int calendarId) { }

	// RVA: 0x1701630 Offset: 0x1700830 VA: 0x181701630
	internal string[] SuperShortDayNames(int calendarId) { }

	// RVA: 0x17015F0 Offset: 0x17007F0 VA: 0x1817015F0
	internal string[] MonthNames(int calendarId) { }

	// RVA: 0x17007E0 Offset: 0x16FF9E0 VA: 0x1817007E0
	internal string[] GenitiveMonthNames(int calendarId) { }

	// RVA: 0x1700690 Offset: 0x16FF890 VA: 0x181700690
	internal string[] AbbreviatedMonthNames(int calendarId) { }

	// RVA: 0x1700660 Offset: 0x16FF860 VA: 0x181700660
	internal string[] AbbreviatedGenitiveMonthNames(int calendarId) { }

	// RVA: 0x1701580 Offset: 0x1700780 VA: 0x181701580
	internal string[] LeapYearMonthNames(int calendarId) { }

	// RVA: 0x17015D0 Offset: 0x17007D0 VA: 0x1817015D0
	internal string MonthDay(int calendarId) { }

	// RVA: 0x17006D0 Offset: 0x16FF8D0 VA: 0x1817006D0
	internal string DateSeparator(int calendarId) { }

	// RVA: 0x1700D30 Offset: 0x16FFF30 VA: 0x181700D30
	private static string GetDateSeparator(string format) { }

	// RVA: 0x1701280 Offset: 0x1700480 VA: 0x181701280
	private static string GetSeparator(string format, string timeParts) { }

	// RVA: 0x1701490 Offset: 0x1700690 VA: 0x181701490
	private static int IndexOfTimePart(string format, int startIndex, string timeParts) { }

	// RVA: 0x1701650 Offset: 0x1700850 VA: 0x181701650
	private static string UnescapeNlsString(string str, int start, int end) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	internal static string[] ReescapeWin32Strings(string[] array) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	internal static string ReescapeWin32String(string str) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	internal static bool IsCustomCultureId(int cultureId) { }

	// RVA: 0x1701EC0 Offset: 0x17010C0 VA: 0x181701EC0
	private static int strlen(byte* s) { }

	// RVA: 0x1701E60 Offset: 0x1701060 VA: 0x181701E60
	private static string idx2string(byte* data, int idx) { }

	// RVA: 0x1701840 Offset: 0x1700A40 VA: 0x181701840
	private int[] create_group_sizes_array(int gs0, int gs1) { }

	// RVA: 0x1700D70 Offset: 0x16FFF70 VA: 0x181700D70
	internal void GetNFIValues(NumberFormatInfo nfi) { }

	// RVA: 0x1701900 Offset: 0x1700B00 VA: 0x181701900
	private static byte* fill_number_data(int index, ref CultureData.NumberFormatEntryManaged nfe) { }
}

// Namespace: System.Globalization
[Serializable]
internal class CodePageDataItem // TypeDefIndex: 4313
{
	// Fields
	internal int m_dataIndex; // 0x10
	internal int m_uiFamilyCodePage; // 0x14
	internal string m_webName; // 0x18
	internal string m_headerName; // 0x20
	internal string m_bodyName; // 0x28
	internal uint m_flags; // 0x30
	private static readonly char[] sep; // 0x0

	// Properties
	public string WebName { get; }
	public virtual int UIFamilyCodePage { get; }
	public string HeaderName { get; }
	public string BodyName { get; }
	public uint Flags { get; }

	// Methods

	// RVA: 0x17002E0 Offset: 0x16FF4E0 VA: 0x1817002E0
	internal void .ctor(int dataIndex) { }

	// RVA: 0x17001A0 Offset: 0x16FF3A0 VA: 0x1817001A0
	internal static string CreateString(string pStrings, uint index) { }

	// RVA: 0x1700540 Offset: 0x16FF740 VA: 0x181700540
	public string get_WebName() { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 4
	public virtual int get_UIFamilyCodePage() { }

	// RVA: 0x1700470 Offset: 0x16FF670 VA: 0x181700470
	public string get_HeaderName() { }

	// RVA: 0x17003A0 Offset: 0x16FF5A0 VA: 0x1817003A0
	public string get_BodyName() { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public uint get_Flags() { }

	// RVA: 0x1700260 Offset: 0x16FF460 VA: 0x181700260
	private static void .cctor() { }
}

// Namespace: System.Globalization
internal static class EncodingTable // TypeDefIndex: 4314
{
	// Fields
	internal static InternalEncodingDataItem[] encodingDataPtr; // 0x0
	internal static InternalCodePageDataItem[] codePageDataPtr; // 0x8
	private const int MIMECONTF_MAILNEWS = 1;
	private const int MIMECONTF_BROWSER = 2;
	private const int MIMECONTF_MINIMAL = 4;
	private const int MIMECONTF_IMPORT = 8;
	private const int MIMECONTF_SAVABLE_MAILNEWS = 256;
	private const int MIMECONTF_SAVABLE_BROWSER = 512;
	private const int MIMECONTF_EXPORT = 1024;
	private const int MIMECONTF_PRIVCONVERTER = 65536;
	private const int MIMECONTF_VALID = 131072;
	private const int MIMECONTF_VALID_NLS = 262144;
	private const int MIMECONTF_MIME_IE4 = 268435456;
	private const int MIMECONTF_MIME_LATEST = 536870912;
	private const int MIMECONTF_MIME_REGISTRY = 1073741824;
	private static int lastEncodingItem; // 0x10
	private static int lastCodePageItem; // 0x14
	private static Dictionary<string, int> hashByName; // 0x18
	private static Dictionary<int, CodePageDataItem> hashByCodePage; // 0x20

	// Methods

	// RVA: 0x17027A0 Offset: 0x17019A0 VA: 0x1817027A0
	private static int GetNumEncodingItems() { }

	// RVA: 0x1701F30 Offset: 0x1701130 VA: 0x181701F30
	private static InternalEncodingDataItem ENC(string name, ushort cp) { }

	// RVA: 0x1702800 Offset: 0x1701A00 VA: 0x181702800
	private static InternalCodePageDataItem MapCodePageDataItem(ushort cp, ushort fcp, string names, uint flags) { }

	// RVA: 0x1702820 Offset: 0x1701A20 VA: 0x181702820
	private static void .cctor() { }

	// RVA: 0x170A710 Offset: 0x1709910 VA: 0x18170A710
	private static int internalGetCodePageFromName(string name) { }

	// RVA: 0x1702450 Offset: 0x1701650 VA: 0x181702450
	internal static EncodingInfo[] GetEncodings() { }

	// RVA: 0x1702210 Offset: 0x1701410 VA: 0x181702210
	internal static int GetCodePageFromName(string name) { }

	// RVA: 0x1701F50 Offset: 0x1701150 VA: 0x181701F50
	internal static CodePageDataItem GetCodePageDataItem(int codepage) { }
}

// Namespace: System.Globalization
internal struct InternalEncodingDataItem // TypeDefIndex: 4315
{
	// Fields
	internal string webName; // 0x0
	internal ushort codePage; // 0x8
}

// Namespace: System.Globalization
internal struct InternalCodePageDataItem // TypeDefIndex: 4316
{
	// Fields
	internal ushort codePage; // 0x0
	internal ushort uiFamilyCodePage; // 0x2
	internal uint flags; // 0x4
	internal string Names; // 0x8
}

// Namespace: System.Globalization
internal static class TextInfoToUpperData // TypeDefIndex: 4317
{
	// Fields
	public static readonly char[] range_00e0_0586; // 0x0
	public static readonly char[] range_1e01_1ff3; // 0x8
	public static readonly char[] range_2170_2184; // 0x10
	public static readonly char[] range_24d0_24e9; // 0x18
	public static readonly char[] range_2c30_2ce3; // 0x20
	public static readonly char[] range_2d00_2d25; // 0x28
	public static readonly char[] range_a641_a697; // 0x30
	public static readonly char[] range_a723_a78c; // 0x38

	// Methods

	// RVA: 0x172BC00 Offset: 0x172AE00 VA: 0x18172BC00
	private static void .cctor() { }
}

// Namespace: System.Globalization
internal static class TextInfoToLowerData // TypeDefIndex: 4318
{
	// Fields
	public static readonly char[] range_00c0_0556; // 0x0
	public static readonly char[] range_10a0_10c5; // 0x8
	public static readonly char[] range_1e00_1ffc; // 0x10
	public static readonly char[] range_2160_216f; // 0x18
	public static readonly char[] range_24b6_24cf; // 0x20
	public static readonly char[] range_2c00_2c2e; // 0x28
	public static readonly char[] range_2c60_2ce2; // 0x30
	public static readonly char[] range_a640_a696; // 0x38
	public static readonly char[] range_a722_a78b; // 0x40

	// Methods

	// RVA: 0x172B960 Offset: 0x172AB60 VA: 0x18172B960
	private static void .cctor() { }
}

// Namespace: 
private struct CultureInfo.Data // TypeDefIndex: 4319
{
	// Fields
	public int ansi; // 0x0
	public int ebcdic; // 0x4
	public int mac; // 0x8
	public int oem; // 0xC
	public bool right_to_left; // 0x10
	public byte list_sep; // 0x11
}

// Namespace: 
private sealed class CultureInfo.OnCultureInfoChangedDelegate : MulticastDelegate // TypeDefIndex: 4320
{
	// Methods

	// RVA: 0x4047F0 Offset: 0x4039F0 VA: 0x1804047F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(string language) { }

	// RVA: 0x3FD210 Offset: 0x3FC410 VA: 0x1803FD210 Slot: 14
	public virtual IAsyncResult BeginInvoke(string language, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class CultureInfo : ICloneable, IFormatProvider // TypeDefIndex: 4321
{
	// Fields
	private static CultureInfo invariant_culture_info; // 0x0
	private static object shared_table_lock; // 0x8
	private static CultureInfo default_current_culture; // 0x10
	private bool m_isReadOnly; // 0x10
	private int cultureID; // 0x14
	private int parent_lcid; // 0x18
	private int datetime_index; // 0x1C
	private int number_index; // 0x20
	private int default_calendar_type; // 0x24
	private bool m_useUserOverride; // 0x28
	internal NumberFormatInfo numInfo; // 0x30
	internal DateTimeFormatInfo dateTimeInfo; // 0x38
	private TextInfo textInfo; // 0x40
	internal string m_name; // 0x48
	private string englishname; // 0x50
	private string nativename; // 0x58
	private string iso3lang; // 0x60
	private string iso2lang; // 0x68
	private string win3lang; // 0x70
	private string territory; // 0x78
	private string[] native_calendar_names; // 0x80
	private CompareInfo compareInfo; // 0x88
	private readonly void* textinfo_data; // 0x90
	private int m_dataItem; // 0x98
	private Calendar calendar; // 0xA0
	private CultureInfo parent_culture; // 0xA8
	private bool constructed; // 0xB0
	internal byte[] cached_serialized_form; // 0xB8
	internal CultureData m_cultureData; // 0xC0
	internal bool m_isInherited; // 0xC8
	internal const int InvariantCultureId = 127;
	private const int CalendarTypeBits = 8;
	internal const int LOCALE_INVARIANT = 127;
	private const string MSG_READONLY = "This instance is read only";
	private static CultureInfo s_DefaultThreadCurrentUICulture; // 0x18
	private static CultureInfo s_DefaultThreadCurrentCulture; // 0x20
	private static Dictionary<int, CultureInfo> shared_by_number; // 0x28
	private static Dictionary<string, CultureInfo> shared_by_name; // 0x30
	private static CultureInfo s_UserPreferredCultureInfoInAppX; // 0x38
	internal static readonly bool IsTaiwanSku; // 0x40

	// Properties
	internal CultureData _cultureData { get; }
	internal bool _isInherited { get; }
	public static CultureInfo InvariantCulture { get; }
	public static CultureInfo CurrentCulture { get; set; }
	public static CultureInfo CurrentUICulture { get; set; }
	internal string Territory { get; }
	internal string _name { get; }
	[ComVisible(False)]
	public CultureTypes CultureTypes { get; }
	[ComVisible(False)]
	public string IetfLanguageTag { get; }
	[ComVisible(False)]
	public virtual int KeyboardLayoutId { get; }
	public virtual int LCID { get; }
	public virtual string Name { get; }
	public virtual string NativeName { get; }
	internal string NativeCalendarName { get; }
	public virtual Calendar Calendar { get; }
	[MonoLimitation("Optional calendars are not supported only default calendar is returned")]
	public virtual Calendar[] OptionalCalendars { get; }
	public virtual CultureInfo Parent { get; }
	public virtual TextInfo TextInfo { get; }
	public virtual string ThreeLetterISOLanguageName { get; }
	public virtual string ThreeLetterWindowsLanguageName { get; }
	public virtual string TwoLetterISOLanguageName { get; }
	public bool UseUserOverride { get; }
	public virtual CompareInfo CompareInfo { get; }
	public virtual bool IsNeutralCulture { get; }
	public virtual NumberFormatInfo NumberFormat { get; set; }
	public virtual DateTimeFormatInfo DateTimeFormat { get; set; }
	public virtual string DisplayName { get; }
	public virtual string EnglishName { get; }
	public static CultureInfo InstalledUICulture { get; }
	public bool IsReadOnly { get; }
	internal int CalendarType { get; }
	public static CultureInfo DefaultThreadCurrentCulture { get; set; }
	public static CultureInfo DefaultThreadCurrentUICulture { get; set; }
	internal string SortName { get; }
	internal static CultureInfo UserDefaultUICulture { get; }
	internal static CultureInfo UserDefaultCulture { get; }
	internal bool HasInvariantCultureName { get; }

	// Methods

	// RVA: 0x7381F0 Offset: 0x7373F0 VA: 0x1807381F0
	internal CultureData get__cultureData() { }

	// RVA: 0x772600 Offset: 0x771800 VA: 0x180772600
	internal bool get__isInherited() { }

	// RVA: 0x1720580 Offset: 0x171F780 VA: 0x181720580
	public static CultureInfo get_InvariantCulture() { }

	// RVA: 0x1720080 Offset: 0x171F280 VA: 0x181720080
	public static CultureInfo get_CurrentCulture() { }

	// RVA: 0x1720FD0 Offset: 0x17201D0 VA: 0x181720FD0
	public static void set_CurrentCulture(CultureInfo value) { }

	// RVA: 0x17200B0 Offset: 0x171F2B0 VA: 0x1817200B0
	public static CultureInfo get_CurrentUICulture() { }

	// RVA: 0x1721000 Offset: 0x1720200 VA: 0x181721000
	public static void set_CurrentUICulture(CultureInfo value) { }

	// RVA: 0x171A620 Offset: 0x1719820 VA: 0x18171A620
	internal static CultureInfo ConstructCurrentCulture() { }

	// RVA: 0x171A7F0 Offset: 0x17199F0 VA: 0x18171A7F0
	internal static CultureInfo ConstructCurrentUICulture() { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	internal string get_Territory() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	internal string get__name() { }

	// RVA: 0x171FDC0 Offset: 0x171EFC0 VA: 0x18171FDC0
	public CultureTypes get_CultureTypes() { }

	[ComVisible(False)]
	// RVA: 0x171D3D0 Offset: 0x171C5D0 VA: 0x18171D3D0
	public CultureInfo GetConsoleFallbackUICulture() { }

	// RVA: 0x1720460 Offset: 0x171F660 VA: 0x181720460
	public string get_IetfLanguageTag() { }

	// RVA: 0x1720620 Offset: 0x171F820 VA: 0x181720620 Slot: 6
	public virtual int get_KeyboardLayoutId() { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 7
	public virtual int get_LCID() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0 Slot: 8
	public virtual string get_Name() { }

	// RVA: 0x1720730 Offset: 0x171F930 VA: 0x181720730 Slot: 9
	public virtual string get_NativeName() { }

	// RVA: 0x17206D0 Offset: 0x171F8D0 VA: 0x1817206D0
	internal string get_NativeCalendarName() { }

	// RVA: 0x171FC00 Offset: 0x171EE00 VA: 0x18171FC00 Slot: 10
	public virtual Calendar get_Calendar() { }

	// RVA: 0x1720810 Offset: 0x171FA10 VA: 0x181720810 Slot: 11
	public virtual Calendar[] get_OptionalCalendars() { }

	// RVA: 0x17208C0 Offset: 0x171FAC0 VA: 0x1817208C0 Slot: 12
	public virtual CultureInfo get_Parent() { }

	// RVA: 0x1720B50 Offset: 0x171FD50 VA: 0x181720B50 Slot: 13
	public virtual TextInfo get_TextInfo() { }

	// RVA: 0x1720C90 Offset: 0x171FE90 VA: 0x181720C90 Slot: 14
	public virtual string get_ThreeLetterISOLanguageName() { }

	// RVA: 0x1720CD0 Offset: 0x171FED0 VA: 0x181720CD0 Slot: 15
	public virtual string get_ThreeLetterWindowsLanguageName() { }

	// RVA: 0x1720D10 Offset: 0x171FF10 VA: 0x181720D10 Slot: 16
	public virtual string get_TwoLetterISOLanguageName() { }

	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_UseUserOverride() { }

	// RVA: 0x171A2B0 Offset: 0x17194B0 VA: 0x18171A2B0
	public void ClearCachedData() { }

	// RVA: 0x171A440 Offset: 0x1719640 VA: 0x18171A440 Slot: 17
	public virtual object Clone() { }

	// RVA: 0x171D320 Offset: 0x171C520 VA: 0x18171D320 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x171E3A0 Offset: 0x171D5A0 VA: 0x18171E3A0
	public static CultureInfo[] GetCultures(CultureTypes types) { }

	// RVA: 0x171E8A0 Offset: 0x171DAA0 VA: 0x18171E8A0
	private CultureInfo.Data GetTextInfoData() { }

	// RVA: 0x171E890 Offset: 0x171DA90 VA: 0x18171E890 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x171E9A0 Offset: 0x171DBA0 VA: 0x18171E9A0
	public static CultureInfo ReadOnly(CultureInfo ci) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x171FC90 Offset: 0x171EE90 VA: 0x18171FC90 Slot: 18
	public virtual CompareInfo get_CompareInfo() { }

	// RVA: 0x17205E0 Offset: 0x171F7E0 VA: 0x1817205E0 Slot: 19
	public virtual bool get_IsNeutralCulture() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void CheckNeutral() { }

	// RVA: 0x1720770 Offset: 0x171F970 VA: 0x181720770 Slot: 20
	public virtual NumberFormatInfo get_NumberFormat() { }

	// RVA: 0x17211D0 Offset: 0x17203D0 VA: 0x1817211D0 Slot: 21
	public virtual void set_NumberFormat(NumberFormatInfo value) { }

	// RVA: 0x17200E0 Offset: 0x171F2E0 VA: 0x1817200E0 Slot: 22
	public virtual DateTimeFormatInfo get_DateTimeFormat() { }

	// RVA: 0x1721030 Offset: 0x1720230 VA: 0x181721030 Slot: 23
	public virtual void set_DateTimeFormat(DateTimeFormatInfo value) { }

	// RVA: 0x1720320 Offset: 0x171F520 VA: 0x181720320 Slot: 24
	public virtual string get_DisplayName() { }

	// RVA: 0x1720340 Offset: 0x171F540 VA: 0x181720340 Slot: 25
	public virtual string get_EnglishName() { }

	// RVA: 0x1720540 Offset: 0x171F740 VA: 0x181720540
	public static CultureInfo get_InstalledUICulture() { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_IsReadOnly() { }

	// RVA: 0x171E780 Offset: 0x171D980 VA: 0x18171E780 Slot: 26
	public virtual object GetFormat(Type formatType) { }

	// RVA: 0x171AA40 Offset: 0x1719C40 VA: 0x18171AA40
	private void Construct() { }

	// RVA: 0x171FB40 Offset: 0x171ED40 VA: 0x18171FB40
	private bool construct_internal_locale_from_lcid(int lcid) { }

	// RVA: 0x171FB50 Offset: 0x171ED50 VA: 0x18171FB50
	private bool construct_internal_locale_from_name(string name) { }

	// RVA: 0x1720E10 Offset: 0x1720010 VA: 0x181720E10
	private static string get_current_locale_name() { }

	// RVA: 0x1720FC0 Offset: 0x17201C0 VA: 0x181720FC0
	private static CultureInfo[] internal_get_cultures(bool neutral, bool specific, bool installed) { }

	// RVA: 0x171A830 Offset: 0x1719A30 VA: 0x18171A830
	private void ConstructInvariant(bool read_only) { }

	// RVA: 0x171D2A0 Offset: 0x171C4A0 VA: 0x18171D2A0
	private TextInfo CreateTextInfo(bool readOnly) { }

	// RVA: 0x171FB20 Offset: 0x171ED20 VA: 0x18171FB20
	public void .ctor(int culture) { }

	// RVA: 0x171F7B0 Offset: 0x171E9B0 VA: 0x18171F7B0
	public void .ctor(int culture, bool useUserOverride) { }

	// RVA: 0x171F7D0 Offset: 0x171E9D0 VA: 0x18171F7D0
	private void .ctor(int culture, bool useUserOverride, bool read_only) { }

	// RVA: 0x171F770 Offset: 0x171E970 VA: 0x18171F770
	public void .ctor(string name) { }

	// RVA: 0x171FB00 Offset: 0x171ED00 VA: 0x18171FB00
	public void .ctor(string name, bool useUserOverride) { }

	// RVA: 0x171F4A0 Offset: 0x171E6A0 VA: 0x18171F4A0
	private void .ctor(string name, bool useUserOverride, bool read_only) { }

	// RVA: 0x171F790 Offset: 0x171E990 VA: 0x18171F790
	private void .ctor() { }

	// RVA: 0x1720E20 Offset: 0x1720020 VA: 0x181720E20
	private static void insert_into_shared_tables(CultureInfo c) { }

	// RVA: 0x171DEE0 Offset: 0x171D0E0 VA: 0x18171DEE0
	public static CultureInfo GetCultureInfo(int culture) { }

	// RVA: 0x171E140 Offset: 0x171D340 VA: 0x18171E140
	public static CultureInfo GetCultureInfo(string name) { }

	[MonoTODO("Currently it ignores the altName parameter")]
	// RVA: 0x171DDE0 Offset: 0x171CFE0 VA: 0x18171DDE0
	public static CultureInfo GetCultureInfo(string name, string altName) { }

	// RVA: 0x171DB90 Offset: 0x171CD90 VA: 0x18171DB90
	public static CultureInfo GetCultureInfoByIetfLanguageTag(string name) { }

	// RVA: 0x171AC80 Offset: 0x1719E80 VA: 0x18171AC80
	internal static CultureInfo CreateCulture(string name, bool reference) { }

	// RVA: 0x171CF90 Offset: 0x171C190 VA: 0x18171CF90
	public static CultureInfo CreateSpecificCulture(string name) { }

	// RVA: 0x171A9A0 Offset: 0x1719BA0 VA: 0x18171A9A0
	private bool ConstructLocaleFromName(string name) { }

	// RVA: 0x171ADB0 Offset: 0x1719FB0 VA: 0x18171ADB0
	private static CultureInfo CreateSpecificCultureFromNeutral(string name) { }

	// RVA: 0x171FB60 Offset: 0x171ED60 VA: 0x18171FB60
	internal int get_CalendarType() { }

	// RVA: 0x171AA60 Offset: 0x1719C60 VA: 0x18171AA60
	private static Calendar CreateCalendar(int calendarType) { }

	// RVA: 0x171AD10 Offset: 0x1719F10 VA: 0x18171AD10
	private static Exception CreateNotFoundException(string name) { }

	// RVA: 0x1720260 Offset: 0x171F460 VA: 0x181720260
	public static CultureInfo get_DefaultThreadCurrentCulture() { }

	// RVA: 0x1721110 Offset: 0x1720310 VA: 0x181721110
	public static void set_DefaultThreadCurrentCulture(CultureInfo value) { }

	// RVA: 0x17202C0 Offset: 0x171F4C0 VA: 0x1817202C0
	public static CultureInfo get_DefaultThreadCurrentUICulture() { }

	// RVA: 0x1721170 Offset: 0x1720370 VA: 0x181721170
	public static void set_DefaultThreadCurrentUICulture(CultureInfo value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	internal string get_SortName() { }

	// RVA: 0x1720D90 Offset: 0x171FF90 VA: 0x181720D90
	internal static CultureInfo get_UserDefaultUICulture() { }

	// RVA: 0x1720D50 Offset: 0x171FF50 VA: 0x181720D50
	internal static CultureInfo get_UserDefaultCulture() { }

	// RVA: 0x171E8C0 Offset: 0x171DAC0 VA: 0x18171E8C0
	private static extern void InitializeUserPreferredCultureInfoInAppX(CultureInfo.OnCultureInfoChangedDelegate onCultureInfoChangedInAppX) { }

	// RVA: 0x171ED00 Offset: 0x171DF00 VA: 0x18171ED00
	private static extern void SetUserPreferredCultureInfoInAppX(string name) { }

	[MonoPInvokeCallback(typeof(CultureInfo.OnCultureInfoChangedDelegate))]
	// RVA: 0x171E8E0 Offset: 0x171DAE0 VA: 0x18171E8E0
	private static void OnCultureInfoChangedInAppX(string language) { }

	// RVA: 0x171DC80 Offset: 0x171CE80 VA: 0x18171DC80
	internal static CultureInfo GetCultureInfoForUserPreferredLanguageInAppX() { }

	// RVA: 0x171EB60 Offset: 0x171DD60 VA: 0x18171EB60
	internal static void SetCultureInfoForUserPreferredLanguageInAppX(CultureInfo cultureInfo) { }

	// RVA: 0x171A100 Offset: 0x1719300 VA: 0x18171A100
	internal static void CheckDomainSafetyObject(object obj, object container) { }

	// RVA: 0x1720380 Offset: 0x171F580 VA: 0x181720380
	internal bool get_HasInvariantCultureName() { }

	// RVA: 0x171EEE0 Offset: 0x171E0E0 VA: 0x18171EEE0
	internal static bool VerifyCultureName(string cultureName, bool throwException) { }

	// RVA: 0x171ED20 Offset: 0x171DF20 VA: 0x18171ED20
	internal static bool VerifyCultureName(CultureInfo culture, bool throwException) { }

	// RVA: 0x171F030 Offset: 0x171E230 VA: 0x18171F030
	private static void .cctor() { }
}

// Namespace: System.Globalization
public sealed class IdnMapping // TypeDefIndex: 4322
{
	// Fields
	private bool allow_unassigned; // 0x10
	private bool use_std3; // 0x11
	private Punycode puny; // 0x18

	// Properties
	public bool AllowUnassigned { get; set; }
	public bool UseStd3AsciiRules { get; set; }

	// Methods

	// RVA: 0x1724290 Offset: 0x1723490 VA: 0x181724290
	public void .ctor() { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_AllowUnassigned() { }

	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_AllowUnassigned(bool value) { }

	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0
	public bool get_UseStd3AsciiRules() { }

	// RVA: 0x4BD750 Offset: 0x4BC950 VA: 0x1804BD750
	public void set_UseStd3AsciiRules(bool value) { }

	// RVA: 0x17230A0 Offset: 0x17222A0 VA: 0x1817230A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1723390 Offset: 0x1722590 VA: 0x181723390 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17231A0 Offset: 0x17223A0 VA: 0x1817231A0
	public string GetAscii(string unicode) { }

	// RVA: 0x1723120 Offset: 0x1722320 VA: 0x181723120
	public string GetAscii(string unicode, int index) { }

	// RVA: 0x1723270 Offset: 0x1722470 VA: 0x181723270
	public string GetAscii(string unicode, int index, int count) { }

	// RVA: 0x1722EC0 Offset: 0x17220C0 VA: 0x181722EC0
	private string Convert(string input, int index, int count, bool toAscii) { }

	// RVA: 0x1723770 Offset: 0x1722970 VA: 0x181723770
	private string ToAscii(string s, int offset) { }

	// RVA: 0x1723CC0 Offset: 0x1722EC0 VA: 0x181723CC0
	private void VerifyLength(string s, int offset) { }

	// RVA: 0x1723620 Offset: 0x1722820 VA: 0x181723620
	private string NamePrep(string s, int offset) { }

	// RVA: 0x1723E00 Offset: 0x1723000 VA: 0x181723E00
	private void VerifyProhibitedCharacters(string s, int offset) { }

	// RVA: 0x1724020 Offset: 0x1723220 VA: 0x181724020
	private void VerifyStd3AsciiRules(string s, int offset) { }

	// RVA: 0x1723550 Offset: 0x1722750 VA: 0x181723550
	public string GetUnicode(string ascii) { }

	// RVA: 0x17234D0 Offset: 0x17226D0 VA: 0x1817234D0
	public string GetUnicode(string ascii, int index) { }

	// RVA: 0x17233B0 Offset: 0x17225B0 VA: 0x1817233B0
	public string GetUnicode(string ascii, int index, int count) { }

	// RVA: 0x1723AF0 Offset: 0x1722CF0 VA: 0x181723AF0
	private string ToUnicode(string s, int offset) { }
}

// Namespace: System.Globalization
internal class Bootstring // TypeDefIndex: 4323
{
	// Fields
	private readonly char delimiter; // 0x10
	private readonly int base_num; // 0x14
	private readonly int tmin; // 0x18
	private readonly int tmax; // 0x1C
	private readonly int skew; // 0x20
	private readonly int damp; // 0x24
	private readonly int initial_bias; // 0x28
	private readonly int initial_n; // 0x2C

	// Methods

	// RVA: 0x17183D0 Offset: 0x17175D0 VA: 0x1817183D0
	public void .ctor(char delimiter, int baseNum, int tmin, int tmax, int skew, int damp, int initialBias, int initialN) { }

	// RVA: 0x1717FC0 Offset: 0x17171C0 VA: 0x181717FC0
	public string Encode(string s, int offset) { }

	// RVA: 0x1717FA0 Offset: 0x17171A0 VA: 0x181717FA0
	private char EncodeDigit(int d) { }

	// RVA: 0x1717CC0 Offset: 0x1716EC0 VA: 0x181717CC0
	private int DecodeDigit(char c) { }

	// RVA: 0x1717C40 Offset: 0x1716E40 VA: 0x181717C40
	private int Adapt(int delta, int numPoints, bool firstTime) { }

	// RVA: 0x1717CF0 Offset: 0x1716EF0 VA: 0x181717CF0
	public string Decode(string s, int offset) { }
}

// Namespace: System.Globalization
internal class Punycode : Bootstring // TypeDefIndex: 4324
{
	// Methods

	// RVA: 0x1725690 Offset: 0x1724890 VA: 0x181725690
	public void .ctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class RegionInfo // TypeDefIndex: 4325
{
	// Fields
	private static RegionInfo currentRegion; // 0x0
	private int regionId; // 0x10
	private string iso2Name; // 0x18
	private string iso3Name; // 0x20
	private string win3Name; // 0x28
	private string englishName; // 0x30
	private string nativeName; // 0x38
	private string currencySymbol; // 0x40
	private string isoCurrencySymbol; // 0x48
	private string currencyEnglishName; // 0x50
	private string currencyNativeName; // 0x58

	// Properties
	public static RegionInfo CurrentRegion { get; }
	[ComVisible(False)]
	public virtual string CurrencyEnglishName { get; }
	public virtual string CurrencySymbol { get; }
	[MonoTODO("DisplayName currently only returns the EnglishName")]
	public virtual string DisplayName { get; }
	public virtual string EnglishName { get; }
	[ComVisible(False)]
	public virtual int GeoId { get; }
	public virtual bool IsMetric { get; }
	public virtual string ISOCurrencySymbol { get; }
	[ComVisible(False)]
	public virtual string NativeName { get; }
	[ComVisible(False)]
	public virtual string CurrencyNativeName { get; }
	public virtual string Name { get; }
	public virtual string ThreeLetterISORegionName { get; }
	public virtual string ThreeLetterWindowsRegionName { get; }
	public virtual string TwoLetterISORegionName { get; }

	// Methods

	// RVA: 0x1727120 Offset: 0x1726320 VA: 0x181727120
	public static RegionInfo get_CurrentRegion() { }

	// RVA: 0x1726F80 Offset: 0x1726180 VA: 0x181726F80
	public void .ctor(int culture) { }

	// RVA: 0x1726C30 Offset: 0x1725E30 VA: 0x181726C30
	public void .ctor(string name) { }

	// RVA: 0x1726DF0 Offset: 0x1725FF0 VA: 0x181726DF0
	private void .ctor(CultureInfo ci) { }

	// RVA: 0x1726B40 Offset: 0x1725D40 VA: 0x181726B40
	private bool GetByTerritory(CultureInfo ci) { }

	// RVA: 0x1727110 Offset: 0x1726310 VA: 0x181727110
	private bool construct_internal_region_from_name(string name) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0 Slot: 4
	public virtual string get_CurrencyEnglishName() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 5
	public virtual string get_CurrencySymbol() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 6
	public virtual string get_DisplayName() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 7
	public virtual string get_EnglishName() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 8
	public virtual int get_GeoId() { }

	// RVA: 0x1727350 Offset: 0x1726550 VA: 0x181727350 Slot: 9
	public virtual bool get_IsMetric() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0 Slot: 10
	public virtual string get_ISOCurrencySymbol() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 11
	public virtual string get_NativeName() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090 Slot: 12
	public virtual string get_CurrencyNativeName() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 13
	public virtual string get_Name() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 14
	public virtual string get_ThreeLetterISORegionName() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 15
	public virtual string get_ThreeLetterWindowsRegionName() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 16
	public virtual string get_TwoLetterISORegionName() { }

	// RVA: 0x1726A60 Offset: 0x1725C60 VA: 0x181726A60 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1726BF0 Offset: 0x1725DF0 VA: 0x181726BF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x7C41D0 Offset: 0x7C33D0 VA: 0x1807C41D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1726A20 Offset: 0x1725C20 VA: 0x181726A20
	internal static void ClearCachedData() { }
}

// Namespace: System.Diagnostics
[Usage(68, AllowMultiple = True)]
[Serializable]
public sealed class ConditionalAttribute : Attribute // TypeDefIndex: 4326
{
	// Fields
	[CompilerGenerated]
	private readonly string <ConditionString>k__BackingField; // 0x10

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string conditionString) { }
}

// Namespace: System.Diagnostics
[Usage(108, Inherited = False)]
internal sealed class StackTraceHiddenAttribute : Attribute // TypeDefIndex: 4327
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Diagnostics
[ComVisible(True)]
[Usage(108, Inherited = False)]
[Serializable]
public sealed class DebuggerStepThroughAttribute : Attribute // TypeDefIndex: 4328
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Diagnostics
[ComVisible(True)]
[Usage(224, Inherited = False)]
[Serializable]
public sealed class DebuggerHiddenAttribute : Attribute // TypeDefIndex: 4329
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Diagnostics
[ComVisible(True)]
[Usage(236, Inherited = False)]
[Serializable]
public sealed class DebuggerNonUserCodeAttribute : Attribute // TypeDefIndex: 4330
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[Flags]
[ComVisible(True)]
public enum DebuggableAttribute.DebuggingModes // TypeDefIndex: 4331
{
	// Fields
	public int value__; // 0x0
	public const DebuggableAttribute.DebuggingModes None = 0;
	public const DebuggableAttribute.DebuggingModes Default = 1;
	public const DebuggableAttribute.DebuggingModes DisableOptimizations = 256;
	public const DebuggableAttribute.DebuggingModes IgnoreSymbolStoreSequencePoints = 2;
	public const DebuggableAttribute.DebuggingModes EnableEditAndContinue = 4;
}

// Namespace: System.Diagnostics
[Usage(3, AllowMultiple = False)]
[ComVisible(True)]
public sealed class DebuggableAttribute : Attribute // TypeDefIndex: 4332
{
	// Fields
	private DebuggableAttribute.DebuggingModes m_debuggingModes; // 0x10

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	public void .ctor(DebuggableAttribute.DebuggingModes modes) { }
}

// Namespace: System.Diagnostics
[ComVisible(True)]
public enum DebuggerBrowsableState // TypeDefIndex: 4333
{
	// Fields
	public int value__; // 0x0
	public const DebuggerBrowsableState Never = 0;
	public const DebuggerBrowsableState Collapsed = 2;
	public const DebuggerBrowsableState RootHidden = 3;
}

// Namespace: System.Diagnostics
[ComVisible(True)]
[Usage(384, AllowMultiple = False)]
public sealed class DebuggerBrowsableAttribute : Attribute // TypeDefIndex: 4334
{
	// Fields
	private DebuggerBrowsableState state; // 0x10

	// Methods

	// RVA: 0x17212B0 Offset: 0x17204B0 VA: 0x1817212B0
	public void .ctor(DebuggerBrowsableState state) { }
}

// Namespace: System.Diagnostics
[Usage(13, AllowMultiple = True)]
[ComVisible(True)]
public sealed class DebuggerTypeProxyAttribute : Attribute // TypeDefIndex: 4335
{
	// Fields
	private string typeName; // 0x10

	// Methods

	// RVA: 0x17213A0 Offset: 0x17205A0 VA: 0x1817213A0
	public void .ctor(Type type) { }
}

// Namespace: System.Diagnostics
[ComVisible(True)]
[Usage(4509, AllowMultiple = True)]
public sealed class DebuggerDisplayAttribute : Attribute // TypeDefIndex: 4336
{
	// Fields
	private string name; // 0x10
	private string value; // 0x18
	private string type; // 0x20

	// Properties
	public string Name { set; }
	public string Type { set; }

	// Methods

	// RVA: 0x1721330 Offset: 0x1720530 VA: 0x181721330
	public void .ctor(string value) { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Name(string value) { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Type(string value) { }
}

// Namespace: System.Diagnostics
[ComVisible(True)]
public sealed class Debugger // TypeDefIndex: 4337
{
	// Fields
	public static readonly string DefaultCategory; // 0x0

	// Properties
	public static bool IsAttached { get; }

	// Methods

	// RVA: 0x1721540 Offset: 0x1720740 VA: 0x181721540
	public static bool get_IsAttached() { }

	// RVA: 0x1721480 Offset: 0x1720680 VA: 0x181721480
	private static bool IsAttached_internal() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void Break() { }

	// RVA: 0x158A1E0 Offset: 0x15893E0 VA: 0x18158A1E0
	public static bool IsLogging() { }

	// RVA: 0x15ADB40 Offset: 0x15ACD40 VA: 0x1815ADB40
	private static void Log_icall(int level, ref string category, ref string message) { }

	// RVA: 0x1721490 Offset: 0x1720690 VA: 0x181721490
	public static void Log(int level, string category, string message) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void NotifyOfCrossThreadDependency() { }

	// RVA: 0x17214F0 Offset: 0x17206F0 VA: 0x1817214F0
	private static void .cctor() { }
}

// Namespace: System.Diagnostics
[ComVisible(True)]
[MonoTODO("Serialized objects are not compatible with MS.NET")]
[Serializable]
public class StackFrame // TypeDefIndex: 4338
{
	// Fields
	public const int OFFSET_UNKNOWN = -1;
	private int ilOffset; // 0x10
	private int nativeOffset; // 0x14
	private long methodAddress; // 0x18
	private uint methodIndex; // 0x20
	private MethodBase methodBase; // 0x28
	private string fileName; // 0x30
	private int lineNumber; // 0x38
	private int columnNumber; // 0x3C
	private string internalMethodName; // 0x40

	// Methods

	// RVA: 0x1728ED0 Offset: 0x17280D0 VA: 0x181728ED0
	private static bool get_frame_info(int skip, bool needFileInfo, out MethodBase method, out int iloffset, out int native_offset, out string file, out int line, out int column) { }

	// RVA: 0x1728E70 Offset: 0x1728070 VA: 0x181728E70
	public void .ctor() { }

	// RVA: 0x1728DF0 Offset: 0x1727FF0 VA: 0x181728DF0
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x1728D60 Offset: 0x1727F60 VA: 0x181728D60
	public void .ctor(string fileName, int lineNumber, int colNumber) { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0 Slot: 4
	public virtual int GetFileLineNumber() { }

	// RVA: 0x15FEBE0 Offset: 0x15FDDE0 VA: 0x1815FEBE0 Slot: 5
	public virtual int GetFileColumnNumber() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 6
	public virtual string GetFileName() { }

	// RVA: 0x1728AF0 Offset: 0x1727CF0 VA: 0x181728AF0
	internal string GetSecureFileName() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 7
	public virtual int GetILOffset() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 8
	public virtual MethodBase GetMethod() { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 9
	public virtual int GetNativeOffset() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal long GetMethodAddress() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	internal uint GetMethodIndex() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	internal string GetInternalMethodName() { }

	// RVA: 0x1728B50 Offset: 0x1727D50 VA: 0x181728B50 Slot: 3
	public override string ToString() { }
}

// Namespace: 
internal enum StackTrace.TraceFormat // TypeDefIndex: 4339
{
	// Fields
	public int value__; // 0x0
	public const StackTrace.TraceFormat Normal = 0;
	public const StackTrace.TraceFormat TrailingNewLine = 1;
	public const StackTrace.TraceFormat NoResourceLookup = 2;
}

// Namespace: System.Diagnostics
[MonoTODO("Serialized objects are not compatible with .NET")]
[ComVisible(True)]
[Serializable]
public class StackTrace // TypeDefIndex: 4340
{
	// Fields
	public const int METHODS_TO_SKIP = 0;
	private const string prefix = "  at ";
	private StackFrame[] frames; // 0x10
	private readonly StackTrace[] captured_traces; // 0x18
	private bool debug_info; // 0x20
	private static bool isAotidSet; // 0x0
	private static string aotid; // 0x8

	// Properties
	public virtual int FrameCount { get; }

	// Methods

	// RVA: 0x172A6F0 Offset: 0x17298F0 VA: 0x18172A6F0
	public void .ctor() { }

	// RVA: 0x172A350 Offset: 0x1729550 VA: 0x18172A350
	public void .ctor(bool fNeedFileInfo) { }

	// RVA: 0x172A5E0 Offset: 0x17297E0 VA: 0x18172A5E0
	public void .ctor(int skipFrames) { }

	// RVA: 0x172A610 Offset: 0x1729810 VA: 0x18172A610
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x172A7E0 Offset: 0x17299E0 VA: 0x18172A7E0
	private void init_frames(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x172A7D0 Offset: 0x17299D0 VA: 0x18172A7D0
	private static StackFrame[] get_trace(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x172A720 Offset: 0x1729920 VA: 0x18172A720
	public void .ctor(Exception e) { }

	// RVA: 0x172A650 Offset: 0x1729850 VA: 0x18172A650
	public void .ctor(Exception e, bool fNeedFileInfo) { }

	// RVA: 0x172A250 Offset: 0x1729450 VA: 0x18172A250
	public void .ctor(Exception e, int skipFrames) { }

	// RVA: 0x172A440 Offset: 0x1729640 VA: 0x18172A440
	public void .ctor(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x172A390 Offset: 0x1729590 VA: 0x18172A390
	public void .ctor(StackFrame frame) { }

	[MonoLimitation("Not possible to create StackTraces from other threads")]
	[Obsolete]
	// RVA: 0x172A550 Offset: 0x1729750 VA: 0x18172A550
	public void .ctor(Thread targetThread, bool needFileInfo) { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(StackFrame[] frames) { }

	// RVA: 0x172A7B0 Offset: 0x17299B0 VA: 0x18172A7B0 Slot: 4
	public virtual int get_FrameCount() { }

	// RVA: 0x17297B0 Offset: 0x17289B0 VA: 0x1817297B0 Slot: 5
	public virtual StackFrame GetFrame(int index) { }

	[ComVisible(False)]
	// RVA: 0x1729820 Offset: 0x1728A20 VA: 0x181729820 Slot: 6
	public virtual StackFrame[] GetFrames() { }

	// RVA: 0x17296E0 Offset: 0x17288E0 VA: 0x1817296E0
	private static string GetAotId() { }

	// RVA: 0x1728EE0 Offset: 0x17280E0 VA: 0x181728EE0
	private bool AddFrames(StringBuilder sb, bool separator, out bool isAsync) { }

	// RVA: 0x17299B0 Offset: 0x1728BB0 VA: 0x1817299B0
	private void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi, bool needsNewLine, out bool skipped, out bool isAsync) { }

	// RVA: 0x1729410 Offset: 0x1728610 VA: 0x181729410
	private static void ConvertAsyncStateMachineMethod(ref MethodBase method, ref Type declaringType) { }

	// RVA: 0x172A0B0 Offset: 0x17292B0 VA: 0x18172A0B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x172A230 Offset: 0x1729430 VA: 0x18172A230
	internal string ToString(StackTrace.TraceFormat traceFormat) { }
}

// Namespace: System.Diagnostics.Contracts
public static class Contract // TypeDefIndex: 4341
{
	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: -1 Offset: -1
	public static bool ForAll<T>(IEnumerable<T> collection, Predicate<T> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94F160 Offset: 0x94E360 VA: 0x18094F160
	|-Contract.ForAll<object>
	|
	|-RVA: 0x94EE70 Offset: 0x94E070 VA: 0x18094EE70
	|-Contract.ForAll<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Diagnostics.Tracing
public enum EventLevel // TypeDefIndex: 4342
{
	// Fields
	public int value__; // 0x0
	public const EventLevel LogAlways = 0;
	public const EventLevel Critical = 1;
	public const EventLevel Error = 2;
	public const EventLevel Warning = 3;
	public const EventLevel Informational = 4;
	public const EventLevel Verbose = 5;
}

// Namespace: System.Diagnostics.Tracing
[Flags]
public enum EventKeywords // TypeDefIndex: 4343
{
	// Fields
	public long value__; // 0x0
	public const EventKeywords None = 0;
	public const EventKeywords All = -1;
	public const EventKeywords MicrosoftTelemetry = 562949953421312;
	public const EventKeywords WdiContext = 562949953421312;
	public const EventKeywords WdiDiagnostic = 1125899906842624;
	public const EventKeywords Sqm = 2251799813685248;
	public const EventKeywords AuditFailure = 4503599627370496;
	public const EventKeywords AuditSuccess = 9007199254740992;
	public const EventKeywords CorrelationHint = 4503599627370496;
	public const EventKeywords EventLogClassic = 36028797018963968;
}

// Namespace: System.Diagnostics.Tracing
[Usage(64)]
public sealed class EventAttribute : Attribute // TypeDefIndex: 4344
{
	// Fields
	[CompilerGenerated]
	private int <EventId>k__BackingField; // 0x10
	[CompilerGenerated]
	private EventLevel <Level>k__BackingField; // 0x14
	[CompilerGenerated]
	private EventKeywords <Keywords>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x20

	// Properties
	private int EventId { set; }
	public EventLevel Level { set; }
	public EventKeywords Keywords { set; }
	public string Message { set; }

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	public void .ctor(int eventId) { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	private void set_EventId(int value) { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_Level(EventLevel value) { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Keywords(EventKeywords value) { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Message(string value) { }
}

// Namespace: 
protected internal struct EventSource.EventData // TypeDefIndex: 4345
{
	// Fields
	[CompilerGenerated]
	private IntPtr <DataPointer>k__BackingField; // 0x0
	[CompilerGenerated]
	private int <Size>k__BackingField; // 0x8
	[CompilerGenerated]
	private int <Reserved>k__BackingField; // 0xC

	// Properties
	public IntPtr DataPointer { set; }
	public int Size { set; }
	internal int Reserved { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_DataPointer(IntPtr value) { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Size(int value) { }

	[CompilerGenerated]
	// RVA: 0x438090 Offset: 0x437290 VA: 0x180438090
	internal void set_Reserved(int value) { }
}

// Namespace: System.Diagnostics.Tracing
public class EventSource : IDisposable // TypeDefIndex: 4346
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10

	// Properties
	private string Name { set; }

	// Methods

	// RVA: 0x17229B0 Offset: 0x1721BB0 VA: 0x1817229B0
	protected void .ctor() { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(string eventSourceName) { }

	// RVA: 0x1722980 Offset: 0x1721B80 VA: 0x181722980
	internal void .ctor(Guid eventSourceGuid, string eventSourceName) { }

	// RVA: 0x15667F0 Offset: 0x15659F0 VA: 0x1815667F0 Slot: 1
	protected override void Finalize() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_Name(string value) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	public bool IsEnabled() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	public bool IsEnabled(EventLevel level, EventKeywords keywords) { }

	// RVA: 0x1722230 Offset: 0x1721430 VA: 0x181722230 Slot: 4
	public void Dispose() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1722830 Offset: 0x1721A30 VA: 0x181722830
	protected void WriteEvent(int eventId) { }

	// RVA: 0x17225A0 Offset: 0x17217A0 VA: 0x1817225A0
	protected void WriteEvent(int eventId, int arg1) { }

	// RVA: 0x17222A0 Offset: 0x17214A0 VA: 0x1817222A0
	protected void WriteEvent(int eventId, string arg1) { }

	// RVA: 0x1722870 Offset: 0x1721A70 VA: 0x181722870
	protected void WriteEvent(int eventId, int arg1, int arg2) { }

	// RVA: 0x1722330 Offset: 0x1721530 VA: 0x181722330
	protected void WriteEvent(int eventId, int arg1, int arg2, int arg3) { }

	// RVA: 0x1722770 Offset: 0x1721970 VA: 0x181722770
	protected void WriteEvent(int eventId, long arg1) { }

	// RVA: 0x17224A0 Offset: 0x17216A0 VA: 0x1817224A0
	protected void WriteEvent(int eventId, long arg1, string arg2) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	protected void WriteEvent(int eventId, object[] args) { }

	// RVA: 0x1722660 Offset: 0x1721860 VA: 0x181722660
	protected void WriteEvent(int eventId, string arg1, string arg2, string arg3) { }

	[CLSCompliant(False)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	protected void WriteEventCore(int eventId, int eventDataCount, EventSource.EventData* data) { }
}

// Namespace: System.Diagnostics.Tracing
[Usage(4)]
public sealed class EventSourceAttribute : Attribute // TypeDefIndex: 4347
{
	// Fields
	[CompilerGenerated]
	private string <Guid>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x18

	// Properties
	public string Guid { set; }
	public string Name { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Guid(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Name(string value) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Diagnostics.Tracing
[Usage(64)]
public sealed class NonEventAttribute : Attribute // TypeDefIndex: 4348
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Configuration.Assemblies
public enum AssemblyHashAlgorithm // TypeDefIndex: 4349
{
	// Fields
	public int value__; // 0x0
	public const AssemblyHashAlgorithm None = 0;
	public const AssemblyHashAlgorithm MD5 = 32771;
	public const AssemblyHashAlgorithm SHA1 = 32772;
	public const AssemblyHashAlgorithm SHA256 = 32780;
	public const AssemblyHashAlgorithm SHA384 = 32781;
	public const AssemblyHashAlgorithm SHA512 = 32782;
}

// Namespace: System.Configuration.Assemblies
public enum AssemblyVersionCompatibility // TypeDefIndex: 4350
{
	// Fields
	public int value__; // 0x0
	public const AssemblyVersionCompatibility SameMachine = 1;
	public const AssemblyVersionCompatibility SameProcess = 2;
	public const AssemblyVersionCompatibility SameDomain = 3;
}

// Namespace: System.Collections
[Serializable]
public sealed class Comparer : IComparer, ISerializable // TypeDefIndex: 4351
{
	// Fields
	private CompareInfo _compareInfo; // 0x10
	public static readonly Comparer Default; // 0x0
	public static readonly Comparer DefaultInvariant; // 0x8

	// Methods

	// RVA: 0x1719C50 Offset: 0x1718E50 VA: 0x181719C50
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x1719AA0 Offset: 0x1718CA0 VA: 0x181719AA0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1719800 Offset: 0x1718A00 VA: 0x181719800 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1719650 Offset: 0x1718850 VA: 0x181719650 Slot: 4
	public int Compare(object a, object b) { }

	// RVA: 0x17198A0 Offset: 0x1718AA0 VA: 0x1817198A0
	private static void .cctor() { }
}

// Namespace: System.Collections
[Serializable]
public struct DictionaryEntry // TypeDefIndex: 4352
{
	// Fields
	private object _key; // 0x0
	private object _value; // 0x8

	// Properties
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x5C3520 Offset: 0x5C2720 VA: 0x1805C3520
	public void .ctor(object key, object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public object get_Key() { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public object get_Value() { }
}

// Namespace: System.Collections
internal static class HashHelpers // TypeDefIndex: 4353
{
	// Fields
	public static readonly int[] primes; // 0x0
	private static ConditionalWeakTable<object, SerializationInfo> s_serializationInfoTable; // 0x8

	// Properties
	internal static ConditionalWeakTable<object, SerializationInfo> SerializationInfoTable { get; }

	// Methods

	// RVA: 0x1722C90 Offset: 0x1721E90 VA: 0x181722C90
	public static bool IsPrime(int candidate) { }

	// RVA: 0x1722A80 Offset: 0x1721C80 VA: 0x181722A80
	public static int GetPrime(int min) { }

	// RVA: 0x1722A00 Offset: 0x1721C00 VA: 0x181722A00
	public static int ExpandPrime(int oldSize) { }

	// RVA: 0x1722DC0 Offset: 0x1721FC0 VA: 0x181722DC0
	internal static ConditionalWeakTable<object, SerializationInfo> get_SerializationInfoTable() { }

	// RVA: 0x1722D40 Offset: 0x1721F40 VA: 0x181722D40
	private static void .cctor() { }
}

// Namespace: System.Collections
public interface ICollection : IEnumerable // TypeDefIndex: 4354
{
	// Properties
	public abstract int Count { get; }
	public abstract object SyncRoot { get; }
	public abstract bool IsSynchronized { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CopyTo(Array array, int index);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_Count();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object get_SyncRoot();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsSynchronized();
}

// Namespace: System.Collections
public interface IComparer // TypeDefIndex: 4355
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int Compare(object x, object y);
}

// Namespace: System.Collections
[DefaultMember("Item")]
public interface IDictionary : ICollection, IEnumerable // TypeDefIndex: 4356
{
	// Properties
	public abstract object Item { get; set; }
	public abstract ICollection Keys { get; }
	public abstract ICollection Values { get; }
	public abstract bool IsReadOnly { get; }
	public abstract bool IsFixedSize { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_Item(object key);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Item(object key, object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ICollection get_Keys();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract ICollection get_Values();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Contains(object key);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Add(object key, object value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_IsReadOnly();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_IsFixedSize();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IDictionaryEnumerator GetEnumerator();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Remove(object key);
}

// Namespace: System.Collections
public interface IDictionaryEnumerator : IEnumerator // TypeDefIndex: 4357
{
	// Properties
	public abstract object Key { get; }
	public abstract object Value { get; }
	public abstract DictionaryEntry Entry { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_Key();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object get_Value();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract DictionaryEntry get_Entry();
}

// Namespace: System.Collections
public interface IEnumerable // TypeDefIndex: 4358
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IEnumerator GetEnumerator();
}

// Namespace: System.Collections
public interface IEnumerator // TypeDefIndex: 4359
{
	// Properties
	public abstract object Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool MoveNext();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object get_Current();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Reset();
}

// Namespace: System.Collections
public interface IEqualityComparer // TypeDefIndex: 4360
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Equals(object x, object y);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int GetHashCode(object obj);
}

// Namespace: System.Collections
[DefaultMember("Item")]
public interface IList : ICollection, IEnumerable // TypeDefIndex: 4361
{
	// Properties
	public abstract object Item { get; set; }
	public abstract bool IsReadOnly { get; }
	public abstract bool IsFixedSize { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_Item(int index);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Item(int index, object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int Add(object value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool Contains(object value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsReadOnly();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsFixedSize();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int IndexOf(object value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Insert(int index, object value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Remove(object value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void RemoveAt(int index);
}

// Namespace: System.Collections
public interface IStructuralComparable // TypeDefIndex: 4362
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int CompareTo(object other, IComparer comparer);
}

// Namespace: System.Collections
public interface IStructuralEquatable // TypeDefIndex: 4363
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Equals(object other, IEqualityComparer comparer);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int GetHashCode(IEqualityComparer comparer);
}

// Namespace: 
private class ListDictionaryInternal.NodeEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 4364
{
	// Fields
	private ListDictionaryInternal list; // 0x10
	private ListDictionaryInternal.DictionaryNode current; // 0x18
	private int version; // 0x20
	private bool start; // 0x24

	// Properties
	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x1724EA0 Offset: 0x17240A0 VA: 0x181724EA0
	public void .ctor(ListDictionaryInternal list) { }

	// RVA: 0x1724EF0 Offset: 0x17240F0 VA: 0x181724EF0 Slot: 8
	public object get_Current() { }

	// RVA: 0x1724FA0 Offset: 0x17241A0 VA: 0x181724FA0 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x1725020 Offset: 0x1724220 VA: 0x181725020 Slot: 4
	public object get_Key() { }

	// RVA: 0x1725090 Offset: 0x1724290 VA: 0x181725090 Slot: 5
	public object get_Value() { }

	// RVA: 0x1724D60 Offset: 0x1723F60 VA: 0x181724D60 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x1724E20 Offset: 0x1724020 VA: 0x181724E20 Slot: 9
	public void Reset() { }
}

// Namespace: 
private class ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator : IEnumerator // TypeDefIndex: 4365
{
	// Fields
	private ListDictionaryInternal list; // 0x10
	private ListDictionaryInternal.DictionaryNode current; // 0x18
	private int version; // 0x20
	private bool isKeys; // 0x24
	private bool start; // 0x25

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x17255B0 Offset: 0x17247B0 VA: 0x1817255B0
	public void .ctor(ListDictionaryInternal list, bool isKeys) { }

	// RVA: 0x1725610 Offset: 0x1724810 VA: 0x181725610 Slot: 5
	public object get_Current() { }

	// RVA: 0x1725470 Offset: 0x1724670 VA: 0x181725470 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1725530 Offset: 0x1724730 VA: 0x181725530 Slot: 6
	public void Reset() { }
}

// Namespace: 
private class ListDictionaryInternal.NodeKeyValueCollection : ICollection, IEnumerable // TypeDefIndex: 4366
{
	// Fields
	private ListDictionaryInternal list; // 0x10
	private bool isKeys; // 0x18

	// Properties
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x11FF670 Offset: 0x11FE870 VA: 0x1811FF670
	public void .ctor(ListDictionaryInternal list, bool isKeys) { }

	// RVA: 0x1725100 Offset: 0x1724300 VA: 0x181725100 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1725320 Offset: 0x1724520 VA: 0x181725320 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1725360 Offset: 0x1724560 VA: 0x181725360 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x17253E0 Offset: 0x17245E0 VA: 0x1817253E0 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[Serializable]
private class ListDictionaryInternal.DictionaryNode // TypeDefIndex: 4367
{
	// Fields
	public object key; // 0x10
	public object value; // 0x18
	public ListDictionaryInternal.DictionaryNode next; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Collections
[DefaultMember("Item")]
[Serializable]
internal class ListDictionaryInternal : IDictionary, ICollection, IEnumerable // TypeDefIndex: 4368
{
	// Fields
	private ListDictionaryInternal.DictionaryNode head; // 0x10
	private int version; // 0x18
	private int count; // 0x1C
	private object _syncRoot; // 0x20

	// Properties
	public object Item { get; set; }
	public int Count { get; }
	public ICollection Keys { get; }
	public bool IsReadOnly { get; }
	public bool IsFixedSize { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	public ICollection Values { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1724A00 Offset: 0x1723C00 VA: 0x181724A00 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x1724C00 Offset: 0x1723E00 VA: 0x181724C00 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110 Slot: 16
	public int get_Count() { }

	// RVA: 0x1724AD0 Offset: 0x1723CD0 VA: 0x181724AD0 Slot: 6
	public ICollection get_Keys() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 11
	public bool get_IsReadOnly() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 12
	public bool get_IsFixedSize() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 18
	public bool get_IsSynchronized() { }

	// RVA: 0x1724B30 Offset: 0x1723D30 VA: 0x181724B30 Slot: 17
	public object get_SyncRoot() { }

	// RVA: 0x1724BA0 Offset: 0x1723DA0 VA: 0x181724BA0 Slot: 7
	public ICollection get_Values() { }

	// RVA: 0x1724330 Offset: 0x1723530 VA: 0x181724330 Slot: 9
	public void Add(object key, object value) { }

	// RVA: 0x17244F0 Offset: 0x17236F0 VA: 0x1817244F0 Slot: 10
	public void Clear() { }

	// RVA: 0x1724500 Offset: 0x1723700 VA: 0x181724500 Slot: 8
	public bool Contains(object key) { }

	// RVA: 0x17245D0 Offset: 0x17237D0 VA: 0x1817245D0 Slot: 15
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1724800 Offset: 0x1723A00 VA: 0x181724800 Slot: 13
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1724980 Offset: 0x1723B80 VA: 0x181724980 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1724880 Offset: 0x1723A80 VA: 0x181724880 Slot: 14
	public void Remove(object key) { }
}

// Namespace: System.Collections
[Serializable]
internal sealed class CompatibleComparer : IEqualityComparer // TypeDefIndex: 4369
{
	// Fields
	private readonly IHashCodeProvider _hcp; // 0x10
	private readonly IComparer _comparer; // 0x18

	// Properties
	internal IHashCodeProvider HashCodeProvider { get; }
	internal IComparer Comparer { get; }

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	internal void .ctor(IHashCodeProvider hashCodeProvider, IComparer comparer) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal IHashCodeProvider get_HashCodeProvider() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal IComparer get_Comparer() { }

	// RVA: 0x1719EA0 Offset: 0x17190A0 VA: 0x181719EA0 Slot: 4
	public bool Equals(object a, object b) { }

	// RVA: 0x1719CE0 Offset: 0x1718EE0 VA: 0x181719CE0
	public int Compare(object a, object b) { }

	// RVA: 0x171A030 Offset: 0x1719230 VA: 0x18171A030 Slot: 5
	public int GetHashCode(object obj) { }
}

// Namespace: System.Collections
[Serializable]
public class CaseInsensitiveComparer : IComparer // TypeDefIndex: 4370
{
	// Fields
	private CompareInfo _compareInfo; // 0x10

	// Properties
	public static CaseInsensitiveComparer Default { get; }

	// Methods

	// RVA: 0x1718690 Offset: 0x1717890 VA: 0x181718690
	public void .ctor() { }

	// RVA: 0x1718720 Offset: 0x1717920 VA: 0x181718720
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x17187B0 Offset: 0x17179B0 VA: 0x1817187B0
	public static CaseInsensitiveComparer get_Default() { }

	// RVA: 0x1718440 Offset: 0x1717640 VA: 0x181718440 Slot: 4
	public int Compare(object a, object b) { }
}

// Namespace: System.Collections
[Obsolete("Please use StringComparer instead.")]
[Serializable]
public class CaseInsensitiveHashCodeProvider : IHashCodeProvider // TypeDefIndex: 4371
{
	// Fields
	private readonly CompareInfo _compareInfo; // 0x10

	// Properties
	public static CaseInsensitiveHashCodeProvider Default { get; }

	// Methods

	// RVA: 0x17189A0 Offset: 0x1717BA0 VA: 0x1817189A0
	public void .ctor() { }

	// RVA: 0x1718A30 Offset: 0x1717C30 VA: 0x181718A30
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x1718AC0 Offset: 0x1717CC0 VA: 0x181718AC0
	public static CaseInsensitiveHashCodeProvider get_Default() { }

	// RVA: 0x17188B0 Offset: 0x1717AB0 VA: 0x1817188B0 Slot: 4
	public int GetHashCode(object obj) { }
}

// Namespace: System.Collections
[Serializable]
public abstract class CollectionBase : IList, ICollection, IEnumerable // TypeDefIndex: 4372
{
	// Fields
	private ArrayList _list; // 0x10

	// Properties
	protected ArrayList InnerList { get; }
	protected IList List { get; }
	public int Count { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x17195C0 Offset: 0x17187C0 VA: 0x1817195C0
	protected void .ctor() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	protected ArrayList get_InnerList() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	protected IList get_List() { }

	// RVA: 0x1719620 Offset: 0x1718820 VA: 0x181719620 Slot: 16
	public int get_Count() { }

	// RVA: 0x1718B80 Offset: 0x1717D80 VA: 0x181718B80 Slot: 8
	public void Clear() { }

	// RVA: 0x1718C40 Offset: 0x1717E40 VA: 0x181718C40 Slot: 14
	public void RemoveAt(int index) { }

	// RVA: 0x17192F0 Offset: 0x17184F0 VA: 0x1817192F0 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x17192C0 Offset: 0x17184C0 VA: 0x1817192C0 Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1718E10 Offset: 0x1718010 VA: 0x181718E10 Slot: 18
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1718E40 Offset: 0x1718040 VA: 0x181718E40 Slot: 17
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1718DE0 Offset: 0x1717FE0 VA: 0x181718DE0 Slot: 15
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1719320 Offset: 0x1718520 VA: 0x181719320 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x17193F0 Offset: 0x17185F0 VA: 0x1817193F0 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1718F80 Offset: 0x1718180 VA: 0x181718F80 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1718E70 Offset: 0x1718070 VA: 0x181718E70 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1719160 Offset: 0x1718360 VA: 0x181719160 Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1718FB0 Offset: 0x17181B0 VA: 0x181718FB0 Slot: 11
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1718FE0 Offset: 0x17181E0 VA: 0x181718FE0 Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x154B250 Offset: 0x154A450 VA: 0x18154B250 Slot: 19
	public IEnumerator GetEnumerator() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 20
	protected virtual void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 21
	protected virtual void OnInsert(int index, object value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 22
	protected virtual void OnClear() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 23
	protected virtual void OnRemove(int index, object value) { }

	// RVA: 0x1718BE0 Offset: 0x1717DE0 VA: 0x181718BE0 Slot: 24
	protected virtual void OnValidate(object value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 25
	protected virtual void OnSetComplete(int index, object oldValue, object newValue) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 26
	protected virtual void OnInsertComplete(int index, object value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 27
	protected virtual void OnClearComplete() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 28
	protected virtual void OnRemoveComplete(int index, object value) { }
}

// Namespace: System.Collections
[Serializable]
public abstract class DictionaryBase : IDictionary, ICollection, IEnumerable // TypeDefIndex: 4373
{
	// Fields
	private Hashtable _hashtable; // 0x10

	// Properties
	protected Hashtable InnerHashtable { get; }
	public int Count { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private object System.Collections.IDictionary.Item { get; set; }

	// Methods

	// RVA: 0x17221C0 Offset: 0x17213C0 VA: 0x1817221C0
	protected Hashtable get_InnerHashtable() { }

	// RVA: 0x1722190 Offset: 0x1721390 VA: 0x181722190 Slot: 16
	public int get_Count() { }

	// RVA: 0x1721CF0 Offset: 0x1720EF0 VA: 0x181721CF0 Slot: 11
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x1721C60 Offset: 0x1720E60 VA: 0x181721C60 Slot: 12
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x1721770 Offset: 0x1720970 VA: 0x181721770 Slot: 18
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1721E30 Offset: 0x1721030 VA: 0x181721E30 Slot: 6
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x1721800 Offset: 0x1720A00 VA: 0x181721800 Slot: 17
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1721EC0 Offset: 0x17210C0 VA: 0x181721EC0 Slot: 7
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x1721630 Offset: 0x1720830 VA: 0x181721630 Slot: 15
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1721D80 Offset: 0x1720F80 VA: 0x181721D80 Slot: 4
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x1721F50 Offset: 0x1721150 VA: 0x181721F50 Slot: 5
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x17219C0 Offset: 0x1720BC0 VA: 0x1817219C0 Slot: 8
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x1721890 Offset: 0x1720A90 VA: 0x181721890 Slot: 9
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x1721580 Offset: 0x1720780 VA: 0x181721580 Slot: 10
	public void Clear() { }

	// RVA: 0x1721A50 Offset: 0x1720C50 VA: 0x181721A50 Slot: 14
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x17216D0 Offset: 0x17208D0 VA: 0x1817216D0 Slot: 13
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x17216D0 Offset: 0x17208D0 VA: 0x1817216D0 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1721760 Offset: 0x1720960 VA: 0x181721760 Slot: 20
	protected virtual object OnGet(object key, object currentValue) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 21
	protected virtual void OnSet(object key, object oldValue, object newValue) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 22
	protected virtual void OnInsert(object key, object value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 23
	protected virtual void OnClear() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 24
	protected virtual void OnRemove(object key, object value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 25
	protected virtual void OnValidate(object key, object value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 26
	protected virtual void OnSetComplete(object key, object oldValue, object newValue) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 27
	protected virtual void OnInsertComplete(object key, object value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 28
	protected virtual void OnClearComplete() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 29
	protected virtual void OnRemoveComplete(object key, object value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
[Serializable]
private class Queue.QueueEnumerator : IEnumerator, ICloneable // TypeDefIndex: 4374
{
	// Fields
	private Queue _q; // 0x10
	private int _index; // 0x18
	private int _version; // 0x1C
	private object _currentElement; // 0x20

	// Properties
	public virtual object Current { get; }

	// Methods

	// RVA: 0x1725870 Offset: 0x1724A70 VA: 0x181725870
	internal void .ctor(Queue q) { }

	// RVA: 0x17256E0 Offset: 0x17248E0 VA: 0x1817256E0 Slot: 7
	public object Clone() { }

	// RVA: 0x17256F0 Offset: 0x17248F0 VA: 0x1817256F0 Slot: 8
	public virtual bool MoveNext() { }

	// RVA: 0x17258D0 Offset: 0x1724AD0 VA: 0x1817258D0 Slot: 9
	public virtual object get_Current() { }

	// RVA: 0x17257D0 Offset: 0x17249D0 VA: 0x1817257D0 Slot: 10
	public virtual void Reset() { }
}

// Namespace: 
internal class Queue.QueueDebugView // TypeDefIndex: 4375
{}

// Namespace: System.Collections
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(Queue.QueueDebugView))]
[Serializable]
public class Queue : ICollection, IEnumerable, ICloneable // TypeDefIndex: 4376
{
	// Fields
	private object[] _array; // 0x10
	private int _head; // 0x18
	private int _tail; // 0x1C
	private int _size; // 0x20
	private int _growFactor; // 0x24
	private int _version; // 0x28
	private object _syncRoot; // 0x30

	// Properties
	public virtual int Count { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }

	// Methods

	// RVA: 0x1726640 Offset: 0x1725840 VA: 0x181726640
	public void .ctor() { }

	// RVA: 0x1726630 Offset: 0x1725830 VA: 0x181726630
	public void .ctor(int capacity) { }

	// RVA: 0x17261E0 Offset: 0x17253E0 VA: 0x1817261E0
	public void .ctor(int capacity, float growFactor) { }

	// RVA: 0x1726390 Offset: 0x1725590 VA: 0x181726390
	public void .ctor(ICollection col) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 10
	public virtual int get_Count() { }

	// RVA: 0x1725990 Offset: 0x1724B90 VA: 0x181725990 Slot: 11
	public virtual object Clone() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 12
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x1726660 Offset: 0x1725860 VA: 0x181726660 Slot: 13
	public virtual object get_SyncRoot() { }

	// RVA: 0x1725AA0 Offset: 0x1724CA0 VA: 0x181725AA0 Slot: 14
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x1725DC0 Offset: 0x1724FC0 VA: 0x181725DC0 Slot: 15
	public virtual void Enqueue(object obj) { }

	// RVA: 0x1725FC0 Offset: 0x17251C0 VA: 0x181725FC0 Slot: 16
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1725CF0 Offset: 0x1724EF0 VA: 0x181725CF0 Slot: 17
	public virtual object Dequeue() { }

	// RVA: 0x1726050 Offset: 0x1725250 VA: 0x181726050 Slot: 18
	public virtual object Peek() { }

	// RVA: 0x1725F80 Offset: 0x1725180 VA: 0x181725F80
	internal object GetElement(int i) { }

	// RVA: 0x17260F0 Offset: 0x17252F0 VA: 0x1817260F0
	private void SetCapacity(int capacity) { }
}

// Namespace: System.Collections
[Serializable]
public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable // TypeDefIndex: 4377
{
	// Fields
	private ArrayList _list; // 0x10

	// Properties
	protected ArrayList InnerList { get; }
	public virtual int Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x17269B0 Offset: 0x1725BB0 VA: 0x1817269B0
	protected ArrayList get_InnerList() { }

	// RVA: 0x1726920 Offset: 0x1725B20 VA: 0x181726920 Slot: 9
	public virtual int get_Count() { }

	// RVA: 0x1726800 Offset: 0x1725A00 VA: 0x181726800 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1726890 Offset: 0x1725A90 VA: 0x181726890 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1726760 Offset: 0x1725960 VA: 0x181726760 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x17266D0 Offset: 0x17258D0 VA: 0x1817266D0 Slot: 10
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
[DefaultMember("Item")]
[Serializable]
private class SortedList.SyncSortedList : SortedList // TypeDefIndex: 4378
{
	// Fields
	private SortedList _list; // 0x48
	private object _root; // 0x50

	// Properties
	public override int Count { get; }
	public override object SyncRoot { get; }
	public override bool IsReadOnly { get; }
	public override bool IsFixedSize { get; }
	public override bool IsSynchronized { get; }
	public override object Item { get; set; }

	// Methods

	// RVA: 0x172B670 Offset: 0x172A870 VA: 0x18172B670
	internal void .ctor(SortedList list) { }

	// RVA: 0x172B6C0 Offset: 0x172A8C0 VA: 0x18172B6C0 Slot: 23
	public override int get_Count() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0 Slot: 29
	public override object get_SyncRoot() { }

	// RVA: 0x172B7A0 Offset: 0x172A9A0 VA: 0x18172B7A0 Slot: 26
	public override bool get_IsReadOnly() { }

	// RVA: 0x172B770 Offset: 0x172A970 VA: 0x18172B770 Slot: 27
	public override bool get_IsFixedSize() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 28
	public override bool get_IsSynchronized() { }

	// RVA: 0x172B7D0 Offset: 0x172A9D0 VA: 0x18172B7D0 Slot: 41
	public override object get_Item(object key) { }

	// RVA: 0x172B8A0 Offset: 0x172AAA0 VA: 0x18172B8A0 Slot: 42
	public override void set_Item(object key, object value) { }

	// RVA: 0x172AA00 Offset: 0x1729C00 VA: 0x18172AA00 Slot: 21
	public override void Add(object key, object value) { }

	// RVA: 0x172AAC0 Offset: 0x1729CC0 VA: 0x18172AAC0 Slot: 30
	public override void Clear() { }

	// RVA: 0x172AB70 Offset: 0x1729D70 VA: 0x18172AB70 Slot: 31
	public override object Clone() { }

	// RVA: 0x172ADD0 Offset: 0x1729FD0 VA: 0x18172ADD0 Slot: 32
	public override bool Contains(object key) { }

	// RVA: 0x172AC30 Offset: 0x1729E30 VA: 0x18172AC30 Slot: 33
	public override bool ContainsKey(object key) { }

	// RVA: 0x172AD00 Offset: 0x1729F00 VA: 0x18172AD00 Slot: 34
	public override bool ContainsValue(object key) { }

	// RVA: 0x172AEA0 Offset: 0x172A0A0 VA: 0x18172AEA0 Slot: 35
	public override void CopyTo(Array array, int index) { }

	// RVA: 0x172AF60 Offset: 0x172A160 VA: 0x18172AF60 Slot: 36
	public override object GetByIndex(int index) { }

	// RVA: 0x172B020 Offset: 0x172A220 VA: 0x18172B020 Slot: 37
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x172B1A0 Offset: 0x172A3A0 VA: 0x18172B1A0 Slot: 38
	public override object GetKey(int index) { }

	// RVA: 0x172B0E0 Offset: 0x172A2E0 VA: 0x18172B0E0 Slot: 39
	public override IList GetKeyList() { }

	// RVA: 0x172B260 Offset: 0x172A460 VA: 0x18172B260 Slot: 40
	public override IList GetValueList() { }

	// RVA: 0x172B320 Offset: 0x172A520 VA: 0x18172B320 Slot: 43
	public override int IndexOfKey(object key) { }

	// RVA: 0x172B450 Offset: 0x172A650 VA: 0x18172B450 Slot: 44
	public override int IndexOfValue(object value) { }

	// RVA: 0x172B510 Offset: 0x172A710 VA: 0x18172B510 Slot: 45
	public override void RemoveAt(int index) { }

	// RVA: 0x172B5C0 Offset: 0x172A7C0 VA: 0x18172B5C0 Slot: 46
	public override void Remove(object key) { }
}

// Namespace: 
[Serializable]
private class SortedList.SortedListEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable // TypeDefIndex: 4379
{
	// Fields
	private SortedList _sortedList; // 0x10
	private object _key; // 0x18
	private object _value; // 0x20
	private int _index; // 0x28
	private int _startIndex; // 0x2C
	private int _endIndex; // 0x30
	private int _version; // 0x34
	private bool _current; // 0x38
	private int _getObjectRetType; // 0x3C

	// Properties
	public virtual object Key { get; }
	public virtual DictionaryEntry Entry { get; }
	public virtual object Current { get; }
	public virtual object Value { get; }

	// Methods

	// RVA: 0x173D6C0 Offset: 0x173C8C0 VA: 0x18173D6C0
	internal void .ctor(SortedList sortedList, int index, int count, int getObjRetType) { }

	// RVA: 0x17256E0 Offset: 0x17248E0 VA: 0x1817256E0 Slot: 10
	public object Clone() { }

	// RVA: 0x173D8E0 Offset: 0x173CAE0 VA: 0x18173D8E0 Slot: 11
	public virtual object get_Key() { }

	// RVA: 0x173D540 Offset: 0x173C740 VA: 0x18173D540 Slot: 12
	public virtual bool MoveNext() { }

	// RVA: 0x173D800 Offset: 0x173CA00 VA: 0x18173D800 Slot: 13
	public virtual DictionaryEntry get_Entry() { }

	// RVA: 0x173D730 Offset: 0x173C930 VA: 0x18173D730 Slot: 14
	public virtual object get_Current() { }

	// RVA: 0x173D9B0 Offset: 0x173CBB0 VA: 0x18173D9B0 Slot: 15
	public virtual object get_Value() { }

	// RVA: 0x173D630 Offset: 0x173C830 VA: 0x18173D630 Slot: 16
	public virtual void Reset() { }
}

// Namespace: 
[DefaultMember("Item")]
[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
[Serializable]
private class SortedList.KeyList : IList, ICollection, IEnumerable // TypeDefIndex: 4380
{
	// Fields
	private SortedList sortedList; // 0x10

	// Properties
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsFixedSize { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(SortedList sortedList) { }

	// RVA: 0xD13CB0 Offset: 0xD12EB0 VA: 0x180D13CB0 Slot: 20
	public virtual int get_Count() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 21
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 22
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x17384B0 Offset: 0x17376B0 VA: 0x1817384B0 Slot: 23
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x17384E0 Offset: 0x17376E0 VA: 0x1817384E0 Slot: 24
	public virtual object get_SyncRoot() { }

	// RVA: 0x1738070 Offset: 0x1737270 VA: 0x181738070 Slot: 25
	public virtual int Add(object key) { }

	// RVA: 0x17380C0 Offset: 0x17372C0 VA: 0x1817380C0 Slot: 26
	public virtual void Clear() { }

	// RVA: 0x1738110 Offset: 0x1737310 VA: 0x181738110 Slot: 27
	public virtual bool Contains(object key) { }

	// RVA: 0x1738140 Offset: 0x1737340 VA: 0x181738140 Slot: 28
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x17383C0 Offset: 0x17375C0 VA: 0x1817383C0 Slot: 29
	public virtual void Insert(int index, object value) { }

	// RVA: 0x1718FB0 Offset: 0x17181B0 VA: 0x181718FB0 Slot: 30
	public virtual object get_Item(int index) { }

	// RVA: 0x1738510 Offset: 0x1737710 VA: 0x181738510 Slot: 31
	public virtual void set_Item(int index, object value) { }

	// RVA: 0x1738230 Offset: 0x1737430 VA: 0x181738230 Slot: 32
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x17382D0 Offset: 0x17374D0 VA: 0x1817382D0 Slot: 33
	public virtual int IndexOf(object key) { }

	// RVA: 0x1738460 Offset: 0x1737660 VA: 0x181738460 Slot: 34
	public virtual void Remove(object key) { }

	// RVA: 0x1738410 Offset: 0x1737610 VA: 0x181738410 Slot: 35
	public virtual void RemoveAt(int index) { }
}

// Namespace: 
[DefaultMember("Item")]
[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
[Serializable]
private class SortedList.ValueList : IList, ICollection, IEnumerable // TypeDefIndex: 4381
{
	// Fields
	private SortedList sortedList; // 0x10

	// Properties
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsFixedSize { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(SortedList sortedList) { }

	// RVA: 0xD13CB0 Offset: 0xD12EB0 VA: 0x180D13CB0 Slot: 20
	public virtual int get_Count() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 21
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 22
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x17384B0 Offset: 0x17376B0 VA: 0x1817384B0 Slot: 23
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x17384E0 Offset: 0x17376E0 VA: 0x1817384E0 Slot: 24
	public virtual object get_SyncRoot() { }

	// RVA: 0x1742530 Offset: 0x1741730 VA: 0x181742530 Slot: 25
	public virtual int Add(object key) { }

	// RVA: 0x1742580 Offset: 0x1741780 VA: 0x181742580 Slot: 26
	public virtual void Clear() { }

	// RVA: 0x17425D0 Offset: 0x17417D0 VA: 0x1817425D0 Slot: 27
	public virtual bool Contains(object value) { }

	// RVA: 0x1742600 Offset: 0x1741800 VA: 0x181742600 Slot: 28
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1742820 Offset: 0x1741A20 VA: 0x181742820 Slot: 29
	public virtual void Insert(int index, object value) { }

	// RVA: 0x1742910 Offset: 0x1741B10 VA: 0x181742910 Slot: 30
	public virtual object get_Item(int index) { }

	// RVA: 0x1742940 Offset: 0x1741B40 VA: 0x181742940 Slot: 31
	public virtual void set_Item(int index, object value) { }

	// RVA: 0x17426F0 Offset: 0x17418F0 VA: 0x1817426F0 Slot: 32
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1742790 Offset: 0x1741990 VA: 0x181742790 Slot: 33
	public virtual int IndexOf(object value) { }

	// RVA: 0x17428C0 Offset: 0x1741AC0 VA: 0x1817428C0 Slot: 34
	public virtual void Remove(object value) { }

	// RVA: 0x1742870 Offset: 0x1741A70 VA: 0x181742870 Slot: 35
	public virtual void RemoveAt(int index) { }
}

// Namespace: 
internal class SortedList.SortedListDebugView // TypeDefIndex: 4382
{}

// Namespace: System.Collections
[DebuggerTypeProxy(typeof(SortedList.SortedListDebugView))]
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class SortedList : IDictionary, ICollection, IEnumerable, ICloneable // TypeDefIndex: 4383
{
	// Fields
	private object[] keys; // 0x10
	private object[] values; // 0x18
	private int _size; // 0x20
	private int version; // 0x24
	private IComparer comparer; // 0x28
	private SortedList.KeyList keyList; // 0x30
	private SortedList.ValueList valueList; // 0x38
	private object _syncRoot; // 0x40

	// Properties
	public virtual int Capacity { set; }
	public virtual int Count { get; }
	public virtual ICollection Keys { get; }
	public virtual ICollection Values { get; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsFixedSize { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x1728450 Offset: 0x1727650 VA: 0x181728450
	public void .ctor() { }

	// RVA: 0x1727EA0 Offset: 0x17270A0 VA: 0x181727EA0
	private void Init() { }

	// RVA: 0x1728590 Offset: 0x1727790 VA: 0x181728590
	public void .ctor(int initialCapacity) { }

	// RVA: 0x1728420 Offset: 0x1727620 VA: 0x181728420
	public void .ctor(IComparer comparer) { }

	// RVA: 0x17273C0 Offset: 0x17265C0 VA: 0x1817273C0 Slot: 21
	public virtual void Add(object key, object value) { }

	// RVA: 0x1728840 Offset: 0x1727A40 VA: 0x181728840 Slot: 22
	public virtual void set_Capacity(int value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 23
	public virtual int get_Count() { }

	// RVA: 0x1728790 Offset: 0x1727990 VA: 0x181728790 Slot: 24
	public virtual ICollection get_Keys() { }

	// RVA: 0x1728820 Offset: 0x1727A20 VA: 0x181728820 Slot: 25
	public virtual ICollection get_Values() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 26
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 27
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 28
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x17287B0 Offset: 0x17279B0 VA: 0x1817287B0 Slot: 29
	public virtual object get_SyncRoot() { }

	// RVA: 0xBFEBA0 Offset: 0xBFDDA0 VA: 0x180BFEBA0 Slot: 30
	public virtual void Clear() { }

	// RVA: 0x1727500 Offset: 0x1726700 VA: 0x181727500 Slot: 31
	public virtual object Clone() { }

	// RVA: 0x1727740 Offset: 0x1726940 VA: 0x181727740 Slot: 32
	public virtual bool Contains(object key) { }

	// RVA: 0x1727740 Offset: 0x1726940 VA: 0x181727740 Slot: 33
	public virtual bool ContainsKey(object key) { }

	// RVA: 0x1727770 Offset: 0x1726970 VA: 0x181727770 Slot: 34
	public virtual bool ContainsValue(object value) { }

	// RVA: 0x17277A0 Offset: 0x17269A0 VA: 0x1817277A0 Slot: 35
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1727A70 Offset: 0x1726C70 VA: 0x181727A70
	private void EnsureCapacity(int min) { }

	// RVA: 0x1727AD0 Offset: 0x1726CD0 VA: 0x181727AD0 Slot: 36
	public virtual object GetByIndex(int index) { }

	// RVA: 0x17283A0 Offset: 0x17275A0 VA: 0x1817283A0 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1727B80 Offset: 0x1726D80 VA: 0x181727B80 Slot: 37
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1727C70 Offset: 0x1726E70 VA: 0x181727C70 Slot: 38
	public virtual object GetKey(int index) { }

	// RVA: 0x1727C00 Offset: 0x1726E00 VA: 0x181727C00 Slot: 39
	public virtual IList GetKeyList() { }

	// RVA: 0x1727D20 Offset: 0x1726F20 VA: 0x181727D20 Slot: 40
	public virtual IList GetValueList() { }

	// RVA: 0x1728740 Offset: 0x1727940 VA: 0x181728740 Slot: 41
	public virtual object get_Item(object key) { }

	// RVA: 0x17289C0 Offset: 0x1727BC0 VA: 0x1817289C0 Slot: 42
	public virtual void set_Item(object key, object value) { }

	// RVA: 0x1727D90 Offset: 0x1726F90 VA: 0x181727D90 Slot: 43
	public virtual int IndexOfKey(object key) { }

	// RVA: 0x1727E40 Offset: 0x1727040 VA: 0x181727E40 Slot: 44
	public virtual int IndexOfValue(object value) { }

	// RVA: 0x1727FE0 Offset: 0x17271E0 VA: 0x181727FE0
	private void Insert(int index, object key, object value) { }

	// RVA: 0x1728150 Offset: 0x1727350 VA: 0x181728150 Slot: 45
	public virtual void RemoveAt(int index) { }

	// RVA: 0x1728290 Offset: 0x1727490 VA: 0x181728290 Slot: 46
	public virtual void Remove(object key) { }

	// RVA: 0x17282E0 Offset: 0x17274E0 VA: 0x1817282E0
	public static SortedList Synchronized(SortedList list) { }
}

// Namespace: 
[Serializable]
private class Stack.StackEnumerator : IEnumerator, ICloneable // TypeDefIndex: 4384
{
	// Fields
	private Stack _stack; // 0x10
	private int _index; // 0x18
	private int _version; // 0x1C
	private object _currentElement; // 0x20

	// Properties
	public virtual object Current { get; }

	// Methods

	// RVA: 0x173DC40 Offset: 0x173CE40 VA: 0x18173DC40
	internal void .ctor(Stack stack) { }

	// RVA: 0x17256E0 Offset: 0x17248E0 VA: 0x1817256E0 Slot: 7
	public object Clone() { }

	// RVA: 0x173DA80 Offset: 0x173CC80 VA: 0x18173DA80 Slot: 8
	public virtual bool MoveNext() { }

	// RVA: 0x173DC90 Offset: 0x173CE90 VA: 0x18173DC90 Slot: 9
	public virtual object get_Current() { }

	// RVA: 0x173DBB0 Offset: 0x173CDB0 VA: 0x18173DBB0 Slot: 10
	public virtual void Reset() { }
}

// Namespace: 
internal class Stack.StackDebugView // TypeDefIndex: 4385
{}

// Namespace: System.Collections
[DebuggerTypeProxy(typeof(Stack.StackDebugView))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class Stack : ICollection, IEnumerable, ICloneable // TypeDefIndex: 4386
{
	// Fields
	private object[] _array; // 0x10
	private int _size; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20
	private const int _defaultCapacity = 10;

	// Properties
	public virtual int Count { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }

	// Methods

	// RVA: 0x173E4B0 Offset: 0x173D6B0 VA: 0x18173E4B0
	public void .ctor() { }

	// RVA: 0x173E3F0 Offset: 0x173D5F0 VA: 0x18173E3F0
	public void .ctor(int initialCapacity) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 10
	public virtual int get_Count() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 11
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x173E500 Offset: 0x173D700 VA: 0x18173E500 Slot: 12
	public virtual object get_SyncRoot() { }

	// RVA: 0xC3CFE0 Offset: 0xC3C1E0 VA: 0x180C3CFE0 Slot: 13
	public virtual void Clear() { }

	// RVA: 0x173DD40 Offset: 0x173CF40 VA: 0x18173DD40 Slot: 14
	public virtual object Clone() { }

	// RVA: 0x173DE70 Offset: 0x173D070 VA: 0x18173DE70 Slot: 15
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x173E130 Offset: 0x173D330 VA: 0x18173E130 Slot: 16
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x173E1B0 Offset: 0x173D3B0 VA: 0x18173E1B0 Slot: 17
	public virtual object Peek() { }

	// RVA: 0x173E240 Offset: 0x173D440 VA: 0x18173E240 Slot: 18
	public virtual object Pop() { }

	// RVA: 0x173E2F0 Offset: 0x173D4F0 VA: 0x18173E2F0 Slot: 19
	public virtual void Push(object obj) { }
}

// Namespace: 
[Serializable]
private class BitArray.BitArrayEnumeratorSimple : IEnumerator, ICloneable // TypeDefIndex: 4387
{
	// Fields
	private BitArray bitarray; // 0x10
	private int index; // 0x18
	private int version; // 0x1C
	private bool currentElement; // 0x20

	// Properties
	public virtual object Current { get; }

	// Methods

	// RVA: 0x172E130 Offset: 0x172D330 VA: 0x18172E130
	internal void .ctor(BitArray bitarray) { }

	// RVA: 0x17256E0 Offset: 0x17248E0 VA: 0x1817256E0 Slot: 7
	public object Clone() { }

	// RVA: 0x172DFA0 Offset: 0x172D1A0 VA: 0x18172DFA0 Slot: 8
	public virtual bool MoveNext() { }

	// RVA: 0x172E170 Offset: 0x172D370 VA: 0x18172E170 Slot: 9
	public virtual object get_Current() { }

	// RVA: 0x172E0B0 Offset: 0x172D2B0 VA: 0x18172E0B0 Slot: 6
	public void Reset() { }
}

// Namespace: System.Collections
[DefaultMember("Item")]
[Serializable]
public sealed class BitArray : ICollection, IEnumerable, ICloneable // TypeDefIndex: 4388
{
	// Fields
	private int[] m_array; // 0x10
	private int m_length; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20

	// Properties
	public bool Item { get; set; }
	public int Length { get; set; }
	public int Count { get; }
	public object SyncRoot { get; }
	public bool IsSynchronized { get; }

	// Methods

	// RVA: 0x172EDE0 Offset: 0x172DFE0 VA: 0x18172EDE0
	public void .ctor(int length) { }

	// RVA: 0x172EC70 Offset: 0x172DE70 VA: 0x18172EC70
	public void .ctor(int length, bool defaultValue) { }

	// RVA: 0x172EF50 Offset: 0x172E150 VA: 0x18172EF50
	public void .ctor(bool[] values) { }

	// RVA: 0x172F090 Offset: 0x172E290 VA: 0x18172F090
	public void .ctor(BitArray bits) { }

	// RVA: 0x172F180 Offset: 0x172E380 VA: 0x18172F180
	public bool get_Item(int index) { }

	// RVA: 0x172F200 Offset: 0x172E400 VA: 0x18172F200
	public void set_Item(int index, bool value) { }

	// RVA: 0x172EA40 Offset: 0x172DC40 VA: 0x18172EA40
	public bool Get(int index) { }

	// RVA: 0x172EB40 Offset: 0x172DD40 VA: 0x18172EB40
	public void Set(int index, bool value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_Length() { }

	// RVA: 0x172F330 Offset: 0x172E530 VA: 0x18172F330
	public void set_Length(int value) { }

	// RVA: 0x172E3B0 Offset: 0x172D5B0 VA: 0x18172E3B0 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 5
	public int get_Count() { }

	// RVA: 0x172F190 Offset: 0x172E390 VA: 0x18172F190 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x172E290 Offset: 0x172D490 VA: 0x18172E290 Slot: 9
	public object Clone() { }

	// RVA: 0x172E9D0 Offset: 0x172DBD0 VA: 0x18172E9D0 Slot: 8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x172E9B0 Offset: 0x172DBB0 VA: 0x18172E9B0
	private static int GetArrayLength(int n, int div) { }
}

// Namespace: 
[DefaultMember("Item")]
[Serializable]
private class ArrayList.IListWrapper : ArrayList // TypeDefIndex: 4389
{
	// Fields
	private IList _list; // 0x28

	// Properties
	public override int Capacity { set; }
	public override int Count { get; }
	public override bool IsReadOnly { get; }
	public override bool IsFixedSize { get; }
	public override bool IsSynchronized { get; }
	public override object Item { get; set; }
	public override object SyncRoot { get; }

	// Methods

	// RVA: 0x1737810 Offset: 0x1736A10 VA: 0x181737810
	internal void .ctor(IList list) { }

	// RVA: 0x1737A60 Offset: 0x1736C60 VA: 0x181737A60 Slot: 21
	public override void set_Capacity(int value) { }

	// RVA: 0x1737870 Offset: 0x1736A70 VA: 0x181737870 Slot: 22
	public override int get_Count() { }

	// RVA: 0x1737910 Offset: 0x1736B10 VA: 0x181737910 Slot: 24
	public override bool get_IsReadOnly() { }

	// RVA: 0x17378C0 Offset: 0x1736AC0 VA: 0x1817378C0 Slot: 23
	public override bool get_IsFixedSize() { }

	// RVA: 0x1737960 Offset: 0x1736B60 VA: 0x181737960 Slot: 25
	public override bool get_IsSynchronized() { }

	// RVA: 0x17379B0 Offset: 0x1736BB0 VA: 0x1817379B0 Slot: 27
	public override object get_Item(int index) { }

	// RVA: 0x1737AF0 Offset: 0x1736CF0 VA: 0x181737AF0 Slot: 28
	public override void set_Item(int index, object value) { }

	// RVA: 0x1737A10 Offset: 0x1736C10 VA: 0x181737A10 Slot: 26
	public override object get_SyncRoot() { }

	// RVA: 0x17366A0 Offset: 0x17358A0 VA: 0x1817366A0 Slot: 29
	public override int Add(object obj) { }

	// RVA: 0x1736650 Offset: 0x1735850 VA: 0x181736650 Slot: 30
	public override void AddRange(ICollection c) { }

	// RVA: 0x1736700 Offset: 0x1735900 VA: 0x181736700 Slot: 31
	public override void Clear() { }

	// RVA: 0x17367C0 Offset: 0x17359C0 VA: 0x1817367C0 Slot: 32
	public override object Clone() { }

	// RVA: 0x1736850 Offset: 0x1735A50 VA: 0x181736850 Slot: 33
	public override bool Contains(object obj) { }

	// RVA: 0x1736920 Offset: 0x1735B20 VA: 0x181736920 Slot: 35
	public override void CopyTo(Array array, int index) { }

	// RVA: 0x1736990 Offset: 0x1735B90 VA: 0x181736990 Slot: 36
	public override void CopyTo(int index, Array array, int arrayIndex, int count) { }

	// RVA: 0x1736CB0 Offset: 0x1735EB0 VA: 0x181736CB0 Slot: 37
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x1736D00 Offset: 0x1735F00 VA: 0x181736D00 Slot: 38
	public override int IndexOf(object value) { }

	// RVA: 0x17370C0 Offset: 0x17362C0 VA: 0x1817370C0 Slot: 39
	public override void Insert(int index, object obj) { }

	// RVA: 0x1736D60 Offset: 0x1735F60 VA: 0x181736D60 Slot: 40
	public override void InsertRange(int index, ICollection c) { }

	// RVA: 0x172D230 Offset: 0x172C430 VA: 0x18172D230 Slot: 41
	public override void Remove(object value) { }

	// RVA: 0x1737130 Offset: 0x1736330 VA: 0x181737130 Slot: 42
	public override void RemoveAt(int index) { }

	// RVA: 0x1737190 Offset: 0x1736390 VA: 0x181737190 Slot: 43
	public override void RemoveRange(int index, int count) { }

	// RVA: 0x1737380 Offset: 0x1736580 VA: 0x181737380 Slot: 45
	public override void Sort(int index, int count, IComparer comparer) { }

	// RVA: 0x1737630 Offset: 0x1736830 VA: 0x181737630 Slot: 46
	public override object[] ToArray() { }

	// RVA: 0x1737700 Offset: 0x1736900 VA: 0x181737700 Slot: 47
	public override Array ToArray(Type type) { }
}

// Namespace: 
[DefaultMember("Item")]
[Serializable]
private class ArrayList.ReadOnlyArrayList : ArrayList // TypeDefIndex: 4390
{
	// Fields
	private ArrayList _list; // 0x28

	// Properties
	public override int Count { get; }
	public override bool IsReadOnly { get; }
	public override bool IsFixedSize { get; }
	public override bool IsSynchronized { get; }
	public override object Item { get; set; }
	public override object SyncRoot { get; }
	public override int Capacity { set; }

	// Methods

