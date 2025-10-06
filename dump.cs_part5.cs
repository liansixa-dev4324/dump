	internal static readonly IntPtr HKEY_DYN_DATA; // 0x30
	private static readonly string[] s_hkeyNames; // 0x38
	private SafeRegistryHandle _hkey; // 0x18
	private string _keyName; // 0x20
	private bool _remoteKey; // 0x28
	private RegistryKey.StateFlags _state; // 0x2C
	private RegistryKeyPermissionCheck _checkMode; // 0x30
	private RegistryView _regView; // 0x34

	// Methods

	// RVA: 0x1590750 Offset: 0x158F950 VA: 0x181590750
	private void ClosePerfDataKey() { }

	// RVA: 0x15907B0 Offset: 0x158F9B0 VA: 0x1815907B0
	private RegistryKey CreateSubKeyInternalCore(string subkey, RegistryKeyPermissionCheck permissionCheck, object registrySecurityObj, RegistryOptions registryOptions) { }

	// RVA: 0x1590E00 Offset: 0x1590000 VA: 0x181590E00
	private void DeleteSubKeyTreeCore(string subkey) { }

	// RVA: 0x1592E40 Offset: 0x1592040 VA: 0x181592E40
	private static RegistryKey OpenBaseKeyCore(RegistryHive hKeyHive, RegistryView view) { }

	// RVA: 0x1592690 Offset: 0x1591890 VA: 0x181592690
	private RegistryKey InternalOpenSubKeyCore(string name, bool writable, bool throwOnPermissionFailure) { }

	// RVA: 0x1592880 Offset: 0x1591A80 VA: 0x181592880
	internal RegistryKey InternalOpenSubKeyWithoutSecurityChecksCore(string name, bool writable) { }

	// RVA: 0x1592C40 Offset: 0x1591E40 VA: 0x181592C40
	private int InternalSubKeyCountCore() { }

	// RVA: 0x15919C0 Offset: 0x1590BC0 VA: 0x1815919C0
	private string[] InternalGetSubKeyNamesCore(int subkeys) { }

	// RVA: 0x1591CA0 Offset: 0x1590EA0 VA: 0x181591CA0
	private object InternalGetValueCore(string name, object defaultValue, bool doNotExpand) { }

	// RVA: 0x1593370 Offset: 0x1592570 VA: 0x181593370
	private void SetValueCore(string name, object value, RegistryValueKind valueKind) { }

	// RVA: 0x1594160 Offset: 0x1593360 VA: 0x181594160
	private void Win32Error(int errorCode, string str) { }

	// RVA: 0x15917D0 Offset: 0x15909D0 VA: 0x1815917D0
	private static int GetRegistryKeyAccess(bool isWritable) { }

	// RVA: 0x1594570 Offset: 0x1593770 VA: 0x181594570
	private void .ctor(SafeRegistryHandle hkey, bool writable, bool systemkey, bool remoteKey, bool isPerfData, RegistryView view) { }

	// RVA: 0x1591260 Offset: 0x1590460 VA: 0x181591260 Slot: 6
	public void Dispose() { }

	// RVA: 0x1590CB0 Offset: 0x158FEB0 VA: 0x181590CB0
	public RegistryKey CreateSubKey(string subkey) { }

	// RVA: 0x1590B60 Offset: 0x158FD60 VA: 0x181590B60
	public RegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck) { }

	// RVA: 0x15909E0 Offset: 0x158FBE0 VA: 0x1815909E0
	private RegistryKey CreateSubKeyInternal(string subkey, RegistryKeyPermissionCheck permissionCheck, object registrySecurityObj, RegistryOptions registryOptions) { }

	// RVA: 0x1591010 Offset: 0x1590210 VA: 0x181591010
	public void DeleteSubKeyTree(string subkey) { }

	// RVA: 0x1591020 Offset: 0x1590220 VA: 0x181591020
	public void DeleteSubKeyTree(string subkey, bool throwOnMissingSubKey) { }

	// RVA: 0x1590E70 Offset: 0x1590070 VA: 0x181590E70
	private void DeleteSubKeyTreeInternal(string subkey) { }

	// RVA: 0x1592FA0 Offset: 0x15921A0 VA: 0x181592FA0
	public static RegistryKey OpenBaseKey(RegistryHive hKey, RegistryView view) { }

	// RVA: 0x1593190 Offset: 0x1592390 VA: 0x181593190
	public RegistryKey OpenSubKey(string name) { }

	// RVA: 0x1593260 Offset: 0x1592460 VA: 0x181593260
	public RegistryKey OpenSubKey(string name, bool writable) { }

	// RVA: 0x1592A20 Offset: 0x1591C20 VA: 0x181592A20
	internal RegistryKey InternalOpenSubKeyWithoutSecurityChecks(string name, bool writable) { }

	// RVA: 0x1592CE0 Offset: 0x1591EE0 VA: 0x181592CE0
	private int InternalSubKeyCount() { }

	// RVA: 0x15917F0 Offset: 0x15909F0 VA: 0x1815917F0
	public string[] GetSubKeyNames() { }

	// RVA: 0x1591BF0 Offset: 0x1590DF0 VA: 0x181591BF0
	private string[] InternalGetSubKeyNames() { }

	// RVA: 0x1591930 Offset: 0x1590B30 VA: 0x181591930
	public object GetValue(string name) { }

	// RVA: 0x1591860 Offset: 0x1590A60 VA: 0x181591860
	public object GetValue(string name, object defaultValue, RegistryValueOptions options) { }

	// RVA: 0x15925E0 Offset: 0x15917E0 VA: 0x1815925E0
	private object InternalGetValue(string name, object defaultValue, bool doNotExpand, bool checkSecurity) { }

	// RVA: 0x1593B50 Offset: 0x1592D50 VA: 0x181593B50
	public void SetValue(string name, object value) { }

	// RVA: 0x1593B70 Offset: 0x1592D70 VA: 0x181593B70
	public void SetValue(string name, object value, RegistryValueKind valueKind) { }

	// RVA: 0x15905C0 Offset: 0x158F7C0 VA: 0x1815905C0
	private RegistryValueKind CalculateValueKind(object value) { }

	// RVA: 0x1593ED0 Offset: 0x15930D0 VA: 0x181593ED0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1591480 Offset: 0x1590680 VA: 0x181591480
	private static string FixupName(string name) { }

	// RVA: 0x1591690 Offset: 0x1590890 VA: 0x181591690
	private static void FixupPath(StringBuilder path) { }

	// RVA: 0x1591380 Offset: 0x1590580 VA: 0x181591380
	private void EnsureNotDisposed() { }

	// RVA: 0x15913E0 Offset: 0x15905E0 VA: 0x1815913E0
	private void EnsureWriteable() { }

	// RVA: 0x1591800 Offset: 0x1590A00 VA: 0x181591800
	private RegistryKeyPermissionCheck GetSubKeyPermissionCheck(bool subkeyWritable) { }

	// RVA: 0x1593FA0 Offset: 0x15931A0 VA: 0x181593FA0
	private static void ValidateKeyName(string name) { }

	// RVA: 0x1593F40 Offset: 0x1593140 VA: 0x181593F40
	private static void ValidateKeyMode(RegistryKeyPermissionCheck mode) { }

	// RVA: 0x15940A0 Offset: 0x15932A0 VA: 0x1815940A0
	private static void ValidateKeyOptions(RegistryOptions options) { }

	// RVA: 0x1594100 Offset: 0x1593300 VA: 0x181594100
	private static void ValidateKeyView(RegistryView view) { }

	// RVA: 0x1592E00 Offset: 0x1592000 VA: 0x181592E00
	private bool IsSystemKey() { }

	// RVA: 0x1592E20 Offset: 0x1592020 VA: 0x181592E20
	private bool IsWritable() { }

	// RVA: 0x1592DE0 Offset: 0x1591FE0 VA: 0x181592DE0
	private bool IsPerfDataKey() { }

	// RVA: 0x1593340 Offset: 0x1592540 VA: 0x181593340
	private void SetDirty() { }

	// RVA: 0x15942F0 Offset: 0x15934F0 VA: 0x1815942F0
	private static void .cctor() { }
}

// Namespace: Microsoft.Win32
public enum RegistryKeyPermissionCheck // TypeDefIndex: 2918
{
	// Fields
	public int value__; // 0x0
	public const RegistryKeyPermissionCheck Default = 0;
	public const RegistryKeyPermissionCheck ReadSubTree = 1;
	public const RegistryKeyPermissionCheck ReadWriteSubTree = 2;
}

// Namespace: Microsoft.Win32
[Flags]
public enum RegistryOptions // TypeDefIndex: 2919
{
	// Fields
	public int value__; // 0x0
	public const RegistryOptions None = 0;
	public const RegistryOptions Volatile = 1;
}

// Namespace: Microsoft.Win32
public enum RegistryValueKind // TypeDefIndex: 2920
{
	// Fields
	public int value__; // 0x0
	public const RegistryValueKind String = 1;
	public const RegistryValueKind ExpandString = 2;
	public const RegistryValueKind Binary = 3;
	public const RegistryValueKind DWord = 4;
	public const RegistryValueKind MultiString = 7;
	public const RegistryValueKind QWord = 11;
	public const RegistryValueKind Unknown = 0;
	public const RegistryValueKind None = -1;
}

// Namespace: Microsoft.Win32
[Flags]
public enum RegistryValueOptions // TypeDefIndex: 2921
{
	// Fields
	public int value__; // 0x0
	public const RegistryValueOptions None = 0;
	public const RegistryValueOptions DoNotExpandEnvironmentNames = 1;
}

// Namespace: Microsoft.Win32
public enum RegistryView // TypeDefIndex: 2922
{
	// Fields
	public int value__; // 0x0
	public const RegistryView Default = 0;
	public const RegistryView Registry64 = 256;
	public const RegistryView Registry32 = 512;
}

// Namespace: Microsoft.Win32
internal static class ThrowHelper // TypeDefIndex: 2923
{
	// Methods

	// RVA: 0x1596F80 Offset: 0x1596180 VA: 0x181596F80
	internal static void ThrowArgumentException(string msg) { }

	// RVA: 0x1596F20 Offset: 0x1596120 VA: 0x181596F20
	internal static void ThrowArgumentException(string msg, string argument) { }

	// RVA: 0x1596FD0 Offset: 0x15961D0 VA: 0x181596FD0
	internal static void ThrowArgumentNullException(string argument) { }

	// RVA: 0x1597080 Offset: 0x1596280 VA: 0x181597080
	internal static void ThrowSecurityException(string msg) { }

	// RVA: 0x15970D0 Offset: 0x15962D0 VA: 0x1815970D0
	internal static void ThrowUnauthorizedAccessException(string msg) { }

	// RVA: 0x1597020 Offset: 0x1596220 VA: 0x181597020
	internal static void ThrowObjectDisposedException(string objectName, string msg) { }
}

// Namespace: Microsoft.Win32
internal static class Win32Native // TypeDefIndex: 2924
{
	// Methods

	// RVA: 0x1597120 Offset: 0x1596320 VA: 0x181597120
	public static string GetMessage(int hr) { }

	// RVA: 0x1597170 Offset: 0x1596370 VA: 0x181597170
	public static int MakeHRFromErrorCode(int errorCode) { }
}

// Namespace: Microsoft.Win32.SafeHandles
internal static class SafeHandleCache<T> // TypeDefIndex: 2925
{
	// Fields
	private static T s_invalidHandle; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal static bool IsCachedInvalidHandle(SafeHandle handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEE050 Offset: 0xBED250 VA: 0x180BEE050
	|-SafeHandleCache<object>.IsCachedInvalidHandle
	*/
}

// Namespace: Microsoft.Win32.SafeHandles
internal sealed class SafeLibraryHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 2926
{
	// Methods

	// RVA: 0x15949D0 Offset: 0x1593BD0 VA: 0x1815949D0
	internal void .ctor() { }

	// RVA: 0x1594A40 Offset: 0x1593C40 VA: 0x181594A40 Slot: 7
	protected override bool ReleaseHandle() { }
}

// Namespace: Microsoft.Win32.SafeHandles
public sealed class SafeRegistryHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 2927
{
	// Methods

	// RVA: 0x1594D80 Offset: 0x1593F80 VA: 0x181594D80 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x15949D0 Offset: 0x1593BD0 VA: 0x1815949D0
	internal void .ctor() { }

	// RVA: 0x1594950 Offset: 0x1593B50 VA: 0x181594950
	public void .ctor(IntPtr preexistingHandle, bool ownsHandle) { }
}

// Namespace: Microsoft.Win32.SafeHandles
internal sealed class SafePasswordHandle : SafeHandle // TypeDefIndex: 2928
{
	// Properties
	public override bool IsInvalid { get; }

	// Methods

	// RVA: 0x1594A50 Offset: 0x1593C50 VA: 0x181594A50
	private IntPtr CreateHandle(string password) { }

	// RVA: 0x1594AA0 Offset: 0x1593CA0 VA: 0x181594AA0
	private IntPtr CreateHandle(SecureString password) { }

	// RVA: 0x1594B50 Offset: 0x1593D50 VA: 0x181594B50
	private void FreeHandle() { }

	// RVA: 0x1594C70 Offset: 0x1593E70 VA: 0x181594C70
	public void .ctor(string password) { }

	// RVA: 0x1594CE0 Offset: 0x1593EE0 VA: 0x181594CE0
	public void .ctor(SecureString password) { }

	// RVA: 0x1594BF0 Offset: 0x1593DF0 VA: 0x181594BF0 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x1594AF0 Offset: 0x1593CF0 VA: 0x181594AF0 Slot: 6
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1594D50 Offset: 0x1593F50 VA: 0x181594D50 Slot: 5
	public override bool get_IsInvalid() { }

	// RVA: 0x1594BA0 Offset: 0x1593DA0 VA: 0x181594BA0
	internal string Mono_DangerousGetString() { }
}

// Namespace: Microsoft.Win32.SafeHandles
public sealed class SafeFileHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 2929
{
	// Methods

	// RVA: 0x1594950 Offset: 0x1593B50 VA: 0x181594950
	public void .ctor(IntPtr preexistingHandle, bool ownsHandle) { }

	// RVA: 0x15948E0 Offset: 0x1593AE0 VA: 0x1815948E0 Slot: 7
	protected override bool ReleaseHandle() { }
}

// Namespace: Microsoft.Win32.SafeHandles
internal class SafeFindHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 2930
{
	// Methods

	// RVA: 0x15949D0 Offset: 0x1593BD0 VA: 0x1815949D0
	internal void .ctor() { }

	// RVA: 0x1594980 Offset: 0x1593B80 VA: 0x181594980 Slot: 7
	protected override bool ReleaseHandle() { }
}

// Namespace: Microsoft.Win32.SafeHandles
public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 2931
{
	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: 0x1594950 Offset: 0x1593B50 VA: 0x181594950
	public void .ctor(IntPtr existingHandle, bool ownsHandle) { }

	// RVA: 0x1594DA0 Offset: 0x1593FA0 VA: 0x181594DA0 Slot: 7
	protected override bool ReleaseHandle() { }
}

// Namespace: Microsoft.Win32.SafeHandles
public abstract class SafeHandleZeroOrMinusOneIsInvalid : SafeHandle // TypeDefIndex: 2932
{
	// Properties
	public override bool IsInvalid { get; }

	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: 0x1594A30 Offset: 0x1593C30 VA: 0x181594A30
	protected void .ctor(bool ownsHandle) { }

	// RVA: 0x1585830 Offset: 0x1584A30 VA: 0x181585830 Slot: 5
	public override bool get_IsInvalid() { }
}

// Namespace: Microsoft.Win32.SafeHandles
public abstract class SafeHandleMinusOneIsInvalid : SafeHandle // TypeDefIndex: 2933
{
	// Properties
	public override bool IsInvalid { get; }

	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: 0x15949E0 Offset: 0x1593BE0 VA: 0x1815949E0
	protected void .ctor(bool ownsHandle) { }

	// RVA: 0x15857E0 Offset: 0x15849E0 VA: 0x1815857E0 Slot: 5
	public override bool get_IsInvalid() { }
}

// Namespace: Microsoft.Win32.SafeHandles
public abstract class CriticalHandleZeroOrMinusOneIsInvalid : CriticalHandle // TypeDefIndex: 2934
{
	// Properties
	public override bool IsInvalid { get; }

	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: 0x1585820 Offset: 0x1584A20 VA: 0x181585820
	protected void .ctor() { }

	// RVA: 0x1585830 Offset: 0x1584A30 VA: 0x181585830 Slot: 5
	public override bool get_IsInvalid() { }
}

// Namespace: Microsoft.Win32.SafeHandles
public abstract class CriticalHandleMinusOneIsInvalid : CriticalHandle // TypeDefIndex: 2935
{
	// Properties
	public override bool IsInvalid { get; }

	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: 0x15857A0 Offset: 0x15849A0 VA: 0x1815857A0
	protected void .ctor() { }

	// RVA: 0x15857E0 Offset: 0x15849E0 VA: 0x1815857E0 Slot: 5
	public override bool get_IsInvalid() { }
}

// Namespace: Internal.Threading.Tasks.Tracing
internal static class TaskTrace // TypeDefIndex: 2936
{
	// Fields
	private static TaskTraceCallbacks s_callbacks; // 0x0

	// Properties
	public static bool Enabled { get; }

	// Methods

	// RVA: 0x1596EC0 Offset: 0x15960C0 VA: 0x181596EC0
	public static bool get_Enabled() { }

	// RVA: 0x1596D40 Offset: 0x1595F40 VA: 0x181596D40
	public static void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

	// RVA: 0x1596DC0 Offset: 0x1595FC0 VA: 0x181596DC0
	public static void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

	// RVA: 0x1596E40 Offset: 0x1596040 VA: 0x181596E40
	public static void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID) { }

	// RVA: 0x1596CA0 Offset: 0x1595EA0 VA: 0x181596CA0
	public static void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions) { }
}

// Namespace: Internal.Runtime.Augments
internal enum AsyncStatus // TypeDefIndex: 2937
{
	// Fields
	public int value__; // 0x0
	public const AsyncStatus Started = 0;
	public const AsyncStatus Completed = 1;
	public const AsyncStatus Canceled = 2;
	public const AsyncStatus Error = 3;
}

// Namespace: Internal.Runtime.Augments
internal abstract class TaskTraceCallbacks // TypeDefIndex: 2938
{
	// Properties
	public abstract bool Enabled { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_Enabled();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions);
}

// Namespace: Internal.Runtime.Augments
internal class RuntimeAugments // TypeDefIndex: 2939
{
	// Fields
	private static ReflectionExecutionDomainCallbacks s_reflectionExecutionDomainCallbacks; // 0x0

	// Properties
	internal static ReflectionExecutionDomainCallbacks Callbacks { get; }

	// Methods

	// RVA: 0x1594800 Offset: 0x1593A00 VA: 0x181594800
	public static void ReportUnhandledException(Exception exception) { }

	// RVA: 0x1594890 Offset: 0x1593A90 VA: 0x181594890
	internal static ReflectionExecutionDomainCallbacks get_Callbacks() { }

	// RVA: 0x1594830 Offset: 0x1593A30 VA: 0x181594830
	private static void .cctor() { }
}

// Namespace: Internal.Runtime.Augments
internal class ReflectionExecutionDomainCallbacks // TypeDefIndex: 2940
{
	// Methods

	// RVA: 0x1590570 Offset: 0x158F770 VA: 0x181590570
	internal Exception CreateMissingMetadataException(Type attributeType) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Internal.Runtime.Augments
internal sealed class RuntimeThread // TypeDefIndex: 2941
{
	// Fields
	internal static readonly int OptimalMaxSpinWaitsPerSpinIteration; // 0x0
	private readonly Thread thread; // 0x10

	// Properties
	public bool IsBackground { set; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	private void .ctor(Thread t) { }

	// RVA: 0x1692BD0 Offset: 0x1691DD0 VA: 0x181692BD0
	public static RuntimeThread Create(ParameterizedThreadStart start, int maxStackSize) { }

	// RVA: 0x1692D00 Offset: 0x1691F00 VA: 0x181692D00
	public void set_IsBackground(bool value) { }

	// RVA: 0x1692C90 Offset: 0x1691E90 VA: 0x181692C90
	public void Start(object state) { }

	// RVA: 0x1692C60 Offset: 0x1691E60 VA: 0x181692C60
	public static void Sleep(int millisecondsTimeout) { }

	// RVA: 0x1692CB0 Offset: 0x1691EB0 VA: 0x181692CB0
	public static bool Yield() { }

	// RVA: 0x1692C70 Offset: 0x1691E70 VA: 0x181692C70
	public static bool SpinWait(int iterations) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10
	public static int GetCurrentProcessorId() { }

	// RVA: 0x1692CC0 Offset: 0x1691EC0 VA: 0x181692CC0
	private static void .cctor() { }
}

// Namespace: Internal.Cryptography
[Extension]
internal static class Helpers // TypeDefIndex: 2942
{
	// Methods

	[Extension]
	// RVA: 0x1692880 Offset: 0x1691A80 VA: 0x181692880
	public static byte[] CloneByteArray(byte[] src) { }

	[Extension]
	// RVA: 0x1692920 Offset: 0x1691B20 VA: 0x181692920
	public static char[] ToHexArrayUpper(byte[] bytes) { }

	[Extension]
	// RVA: 0x1692A00 Offset: 0x1691C00 VA: 0x181692A00
	public static string ToHexStringUpper(byte[] bytes) { }

	// RVA: 0x1692900 Offset: 0x1691B00 VA: 0x181692900
	private static char NibbleToHex(byte b) { }
}

// Namespace: 
private enum string.TrimType // TypeDefIndex: 2943
{
	// Fields
	public int value__; // 0x0
	public const string.TrimType Head = 0;
	public const string.TrimType Tail = 1;
	public const string.TrimType Both = 2;
}

// Namespace: 
private struct string.ProbabilisticMap // TypeDefIndex: 2944
{}

// Namespace: System
[DefaultMember("Chars")]
[Serializable]
public sealed class String : IComparable, IEnumerable, IEnumerable<char>, IComparable<string>, IEquatable<string>, IConvertible, ICloneable // TypeDefIndex: 2945
{
	// Fields
	private const int StackallocIntBufferSizeLimit = 128;
	private const int PROBABILISTICMAP_BLOCK_INDEX_MASK = 7;
	private const int PROBABILISTICMAP_BLOCK_INDEX_SHIFT = 3;
	private const int PROBABILISTICMAP_SIZE = 8;
	private int _stringLength; // 0x10
	private char _firstChar; // 0x14
	public static readonly string Empty; // 0x0

	// Properties
	public int Length { get; }
	public char Chars { get; }

	// Methods

	// RVA: 0x1696CE0 Offset: 0x1695EE0 VA: 0x181696CE0
	private static bool EqualsHelper(string strA, string strB) { }

	// RVA: 0x1692F00 Offset: 0x1692100 VA: 0x181692F00
	private static int CompareOrdinalHelper(string strA, int indexA, int countA, string strB, int indexB, int countB) { }

	// RVA: 0x1692D90 Offset: 0x1691F90 VA: 0x181692D90
	private static int CompareOrdinalHelper(string strA, string strB) { }

	// RVA: 0x1693280 Offset: 0x1692480 VA: 0x181693280
	public static int Compare(string strA, string strB) { }

	// RVA: 0x1693990 Offset: 0x1692B90 VA: 0x181693990
	public static int Compare(string strA, string strB, bool ignoreCase) { }

	// RVA: 0x1693B40 Offset: 0x1692D40 VA: 0x181693B40
	public static int Compare(string strA, string strB, StringComparison comparisonType) { }

	// RVA: 0x1693FA0 Offset: 0x16931A0 VA: 0x181693FA0
	public static int Compare(string strA, string strB, CultureInfo culture, CompareOptions options) { }

	// RVA: 0x1693EE0 Offset: 0x16930E0 VA: 0x181693EE0
	public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture) { }

	// RVA: 0x1694060 Offset: 0x1693260 VA: 0x181694060
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase, CultureInfo culture) { }

	// RVA: 0x16939A0 Offset: 0x1692BA0 VA: 0x1816939A0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options) { }

	// RVA: 0x16934C0 Offset: 0x16926C0 VA: 0x1816934C0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType) { }

	// RVA: 0x1693240 Offset: 0x1692440 VA: 0x181693240
	public static int CompareOrdinal(string strA, string strB) { }

	// RVA: 0x1692F50 Offset: 0x1692150 VA: 0x181692F50
	internal static int CompareOrdinal(ReadOnlySpan<char> strA, ReadOnlySpan<char> strB) { }

	// RVA: 0x1692FF0 Offset: 0x16921F0 VA: 0x181692FF0
	public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length) { }

	// RVA: 0x1693360 Offset: 0x1692560 VA: 0x181693360 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1693280 Offset: 0x1692480 VA: 0x181693280 Slot: 7
	public int CompareTo(string strB) { }

	// RVA: 0x1696BD0 Offset: 0x1695DD0 VA: 0x181696BD0
	public bool EndsWith(string value) { }

	// RVA: 0x1696880 Offset: 0x1695A80 VA: 0x181696880
	public bool EndsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x1696D50 Offset: 0x1695F50 VA: 0x181696D50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1697410 Offset: 0x1696610 VA: 0x181697410 Slot: 8
	public bool Equals(string value) { }

	// RVA: 0x1696DE0 Offset: 0x1695FE0 VA: 0x181696DE0
	public bool Equals(string value, StringComparison comparisonType) { }

	// RVA: 0x1696D10 Offset: 0x1695F10 VA: 0x181696D10
	public static bool Equals(string a, string b) { }

	// RVA: 0x16970F0 Offset: 0x16962F0 VA: 0x1816970F0
	public static bool Equals(string a, string b, StringComparison comparisonType) { }

	// RVA: 0x1696D10 Offset: 0x1695F10 VA: 0x181696D10
	public static bool op_Equality(string a, string b) { }

	// RVA: 0x169EFC0 Offset: 0x169E1C0 VA: 0x18169EFC0
	public static bool op_Inequality(string a, string b) { }

	// RVA: 0x1698130 Offset: 0x1697330 VA: 0x181698130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1698130 Offset: 0x1697330 VA: 0x181698130
	internal int GetLegacyNonRandomizedHashCode() { }

	// RVA: 0x169D850 Offset: 0x169CA50 VA: 0x18169D850
	public bool StartsWith(string value) { }

	// RVA: 0x169D4E0 Offset: 0x169C6E0 VA: 0x18169D4E0
	public bool StartsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x1692D70 Offset: 0x1691F70 VA: 0x181692D70
	internal static void CheckStringComparison(StringComparison comparisonType) { }

	// RVA: 0x1697450 Offset: 0x1696650 VA: 0x181697450
	private static void FillStringChecked(string dest, int destPos, string src) { }

	// RVA: 0x1694760 Offset: 0x1693960 VA: 0x181694760
	public static string Concat(object arg0, object arg1) { }

	// RVA: 0x1694A30 Offset: 0x1693C30 VA: 0x181694A30
	public static string Concat(object arg0, object arg1, object arg2) { }

	// RVA: 0x1694CD0 Offset: 0x1693ED0 VA: 0x181694CD0
	public static string Concat(object[] args) { }

	// RVA: 0x1694B30 Offset: 0x1693D30 VA: 0x181694B30
	public static string Concat(string str0, string str1) { }

	// RVA: 0x1694810 Offset: 0x1693A10 VA: 0x181694810
	public static string Concat(string str0, string str1, string str2) { }

	// RVA: 0x1694200 Offset: 0x1693400 VA: 0x181694200
	public static string Concat(string str0, string str1, string str2, string str3) { }

	// RVA: 0x1694490 Offset: 0x1693690 VA: 0x181694490
	public static string Concat(string[] values) { }

	// RVA: 0x1697D40 Offset: 0x1696F40 VA: 0x181697D40
	public static string Format(string format, object arg0) { }

	// RVA: 0x1697FF0 Offset: 0x16971F0 VA: 0x181697FF0
	public static string Format(string format, object arg0, object arg1) { }

	// RVA: 0x1697C00 Offset: 0x1696E00 VA: 0x181697C00
	public static string Format(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x1697A60 Offset: 0x1696C60 VA: 0x181697A60
	public static string Format(string format, object[] args) { }

	// RVA: 0x1697600 Offset: 0x1696800 VA: 0x181697600
	public static string Format(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x1697900 Offset: 0x1696B00 VA: 0x181697900
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1) { }

	// RVA: 0x1697E80 Offset: 0x1697080 VA: 0x181697E80
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x1697750 Offset: 0x1696950 VA: 0x181697750
	public static string Format(IFormatProvider provider, string format, object[] args) { }

	// RVA: 0x16974E0 Offset: 0x16966E0 VA: 0x1816974E0
	private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x16990D0 Offset: 0x16982D0 VA: 0x1816990D0
	public string Insert(int startIndex, string value) { }

	// RVA: 0x1699B60 Offset: 0x1698D60 VA: 0x181699B60
	public static string Join(string separator, string[] value) { }

	// RVA: 0x1699AF0 Offset: 0x1698CF0 VA: 0x181699AF0
	public static string Join(string separator, object[] values) { }

	// RVA: -1 Offset: -1
	public static string Join<T>(string separator, IEnumerable<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA7CB00 Offset: 0xA7BD00 VA: 0x180A7CB00
	|-String.Join<byte>
	|
	|-RVA: 0xA7CCB0 Offset: 0xA7BEB0 VA: 0x180A7CCB0
	|-String.Join<int>
	|
	|-RVA: 0xA7CC20 Offset: 0xA7BE20 VA: 0x180A7CC20
	|-String.Join<Int32Enum>
	|
	|-RVA: 0xA7CD40 Offset: 0xA7BF40 VA: 0x180A7CD40
	|-String.Join<object>
	|
	|-RVA: 0xA7CB90 Offset: 0xA7BD90 VA: 0x180A7CB90
	|-String.Join<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1699C40 Offset: 0x1698E40 VA: 0x181699C40
	public static string Join(string separator, IEnumerable<string> values) { }

	// RVA: 0x169A060 Offset: 0x1699260 VA: 0x18169A060
	public static string Join(string separator, string[] value, int startIndex, int count) { }

	// RVA: 0x1699930 Offset: 0x1698B30 VA: 0x181699930
	private static string JoinCore(char* separator, int separatorLength, object[] values) { }

	// RVA: -1 Offset: -1
	private static string JoinCore<T>(char* separator, int separatorLength, IEnumerable<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA7B3D0 Offset: 0xA7A5D0 VA: 0x180A7B3D0
	|-String.JoinCore<byte>
	|
	|-RVA: 0xA7C290 Offset: 0xA7B490 VA: 0x180A7C290
	|-String.JoinCore<int>
	|
	|-RVA: 0xA7BE10 Offset: 0xA7B010 VA: 0x180A7BE10
	|-String.JoinCore<Int32Enum>
	|
	|-RVA: 0xA7C6C0 Offset: 0xA7B8C0 VA: 0x180A7C6C0
	|-String.JoinCore<object>
	|
	|-RVA: 0xA7B800 Offset: 0xA7AA00 VA: 0x180A7B800
	|-String.JoinCore<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1699410 Offset: 0x1698610 VA: 0x181699410
	private static string JoinCore(char* separator, int separatorLength, string[] value, int startIndex, int count) { }

	// RVA: 0x169B560 Offset: 0x169A760 VA: 0x18169B560
	public string PadLeft(int totalWidth, char paddingChar) { }

	// RVA: 0x169B760 Offset: 0x169A960 VA: 0x18169B760
	public string PadRight(int totalWidth) { }

	// RVA: 0x169B660 Offset: 0x169A860 VA: 0x18169B660
	public string PadRight(int totalWidth, char paddingChar) { }

	// RVA: 0x169B860 Offset: 0x169AA60 VA: 0x18169B860
	public string Remove(int startIndex, int count) { }

	// RVA: 0x169BA80 Offset: 0x169AC80 VA: 0x18169BA80
	public string Remove(int startIndex) { }

	// RVA: 0x169BF30 Offset: 0x169B130 VA: 0x18169BF30
	public string Replace(char oldChar, char newChar) { }

	// RVA: 0x169C020 Offset: 0x169B220 VA: 0x18169C020
	public string Replace(string oldValue, string newValue) { }

	// RVA: 0x169BB60 Offset: 0x169AD60 VA: 0x18169BB60
	private string ReplaceHelper(int oldValueLength, string newValue, ReadOnlySpan<int> indices) { }

	// RVA: 0x169D410 Offset: 0x169C610 VA: 0x18169D410
	public string[] Split(char separator, StringSplitOptions options = 0) { }

	// RVA: 0x169D1F0 Offset: 0x169C3F0 VA: 0x18169D1F0
	public string[] Split(char[] separator) { }

	// RVA: 0x169D300 Offset: 0x169C500 VA: 0x18169D300
	public string[] Split(char[] separator, int count) { }

	// RVA: 0x169D380 Offset: 0x169C580 VA: 0x18169D380
	public string[] Split(char[] separator, StringSplitOptions options) { }

	// RVA: 0x169D270 Offset: 0x169C470 VA: 0x18169D270
	public string[] Split(char[] separator, int count, StringSplitOptions options) { }

	// RVA: 0x169C2F0 Offset: 0x169B4F0 VA: 0x18169C2F0
	private string[] SplitInternal(ReadOnlySpan<char> separators, int count, StringSplitOptions options) { }

	// RVA: 0x169D1C0 Offset: 0x169C3C0 VA: 0x18169D1C0
	public string[] Split(string[] separator, StringSplitOptions options) { }

	// RVA: 0x169C900 Offset: 0x169BB00 VA: 0x18169C900
	private string[] SplitInternal(string separator, string[] separators, int count, StringSplitOptions options) { }

	// RVA: 0x169C5E0 Offset: 0x169B7E0 VA: 0x18169C5E0
	private string[] SplitInternal(string separator, int count, StringSplitOptions options) { }

	// RVA: 0x169CD10 Offset: 0x169BF10 VA: 0x18169CD10
	private string[] SplitKeepEmptyEntries(ReadOnlySpan<int> sepList, ReadOnlySpan<int> lengthList, int defaultLength, int count) { }

	// RVA: 0x169CF10 Offset: 0x169C110 VA: 0x18169CF10
	private string[] SplitOmitEmptyEntries(ReadOnlySpan<int> sepList, ReadOnlySpan<int> lengthList, int defaultLength, int count) { }

	// RVA: 0x169B1D0 Offset: 0x169A3D0 VA: 0x18169B1D0
	private void MakeSeparatorList(ReadOnlySpan<char> separators, ref ValueListBuilder<int> sepListBuilder) { }

	// RVA: 0x169ADB0 Offset: 0x1699FB0 VA: 0x18169ADB0
	private void MakeSeparatorList(string separator, ref ValueListBuilder<int> sepListBuilder) { }

	// RVA: 0x169AFA0 Offset: 0x169A1A0 VA: 0x18169AFA0
	private void MakeSeparatorList(string[] separators, ref ValueListBuilder<int> sepListBuilder, ref ValueListBuilder<int> lengthListBuilder) { }

	// RVA: 0x169D960 Offset: 0x169CB60 VA: 0x18169D960
	public string Substring(int startIndex) { }

	// RVA: 0x169D970 Offset: 0x169CB70 VA: 0x18169D970
	public string Substring(int startIndex, int length) { }

	// RVA: 0x1699260 Offset: 0x1698460 VA: 0x181699260
	private string InternalSubString(int startIndex, int length) { }

	// RVA: 0x169E3C0 Offset: 0x169D5C0 VA: 0x18169E3C0
	public string ToLower() { }

	// RVA: 0x169E450 Offset: 0x169D650 VA: 0x18169E450
	public string ToLower(CultureInfo culture) { }

	// RVA: 0x169E330 Offset: 0x169D530 VA: 0x18169E330
	public string ToLowerInvariant() { }

	// RVA: 0x169E580 Offset: 0x169D780 VA: 0x18169E580
	public string ToUpper() { }

	// RVA: 0x169E610 Offset: 0x169D810 VA: 0x18169E610
	public string ToUpper(CultureInfo culture) { }

	// RVA: 0x169E4F0 Offset: 0x169D6F0 VA: 0x18169E4F0
	public string ToUpperInvariant() { }

	// RVA: 0x169EC10 Offset: 0x169DE10 VA: 0x18169EC10
	public string Trim() { }

	// RVA: 0x169EC20 Offset: 0x169DE20 VA: 0x18169EC20
	public string Trim(char trimChar) { }

	// RVA: 0x169EBB0 Offset: 0x169DDB0 VA: 0x18169EBB0
	public string Trim(char[] trimChars) { }

	// RVA: 0x169E8E0 Offset: 0x169DAE0 VA: 0x18169E8E0
	public string TrimStart(char trimChar) { }

	// RVA: 0x169E9D0 Offset: 0x169DBD0 VA: 0x18169E9D0
	public string TrimStart(char[] trimChars) { }

	// RVA: 0x169E6B0 Offset: 0x169D8B0 VA: 0x18169E6B0
	public string TrimEnd() { }

	// RVA: 0x169E720 Offset: 0x169D920 VA: 0x18169E720
	public string TrimEnd(char trimChar) { }

	// RVA: 0x169E6C0 Offset: 0x169D8C0 VA: 0x18169E6C0
	public string TrimEnd(char[] trimChars) { }

	// RVA: 0x169EA20 Offset: 0x169DC20 VA: 0x18169EA20
	private string TrimWhiteSpaceHelper(string.TrimType trimType) { }

	// RVA: 0x169E750 Offset: 0x169D950 VA: 0x18169E750
	private string TrimHelper(char* trimChars, int trimCharsLength, string.TrimType trimType) { }

	// RVA: 0x1695AF0 Offset: 0x1694CF0 VA: 0x181695AF0
	private string CreateTrimmedString(int start, int end) { }

	// RVA: 0x1694FB0 Offset: 0x16941B0 VA: 0x181694FB0
	public bool Contains(string value) { }

	// RVA: 0x1695180 Offset: 0x1694380 VA: 0x181695180
	public bool Contains(char value) { }

	// RVA: 0x1698EE0 Offset: 0x16980E0 VA: 0x181698EE0
	public int IndexOf(char value) { }

	// RVA: 0x1698A30 Offset: 0x1697C30 VA: 0x181698A30
	public int IndexOf(char value, int startIndex) { }

	// RVA: 0x1698EF0 Offset: 0x16980F0 VA: 0x181698EF0
	public int IndexOf(char value, int startIndex, int count) { }

	// RVA: 0x1698540 Offset: 0x1697740 VA: 0x181698540
	public int IndexOfAny(char[] anyOf) { }

	// RVA: 0x16981A0 Offset: 0x16973A0 VA: 0x1816981A0
	public int IndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x16981C0 Offset: 0x16973C0 VA: 0x1816981C0
	public int IndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x16985B0 Offset: 0x16977B0 VA: 0x1816985B0
	private int IndexOfAny(char value1, char value2, int startIndex, int count) { }

	// RVA: 0x1698560 Offset: 0x1697760 VA: 0x181698560
	private int IndexOfAny(char value1, char value2, char value3, int startIndex, int count) { }

	// RVA: 0x1698620 Offset: 0x1697820 VA: 0x181698620
	private int IndexOfCharArray(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x1699000 Offset: 0x1698200 VA: 0x181699000
	private static void InitializeProbabilisticMap(uint* charMap, ReadOnlySpan<char> anyOf) { }

	// RVA: 0x1692D20 Offset: 0x1691F20 VA: 0x181692D20
	private static bool ArrayContains(char searchChar, char[] anyOf) { }

	// RVA: 0x16992D0 Offset: 0x16984D0 VA: 0x1816992D0
	private static bool IsCharBitSet(uint* charMap, byte value) { }

	// RVA: 0x169C2D0 Offset: 0x169B4D0 VA: 0x18169C2D0
	private static void SetCharBit(uint* charMap, byte value) { }

	// RVA: 0x1698EA0 Offset: 0x16980A0 VA: 0x181698EA0
	public int IndexOf(string value) { }

	// RVA: 0x1698EC0 Offset: 0x16980C0 VA: 0x181698EC0
	public int IndexOf(string value, int startIndex) { }

	// RVA: 0x1698A80 Offset: 0x1697C80 VA: 0x181698A80
	public int IndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x1698A50 Offset: 0x1697C50 VA: 0x181698A50
	public int IndexOf(string value, int startIndex, StringComparison comparisonType) { }

	// RVA: 0x1698AB0 Offset: 0x1697CB0 VA: 0x181698AB0
	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x169AC40 Offset: 0x1699E40 VA: 0x18169AC40
	public int LastIndexOf(char value) { }

	// RVA: 0x169ABF0 Offset: 0x1699DF0 VA: 0x18169ABF0
	public int LastIndexOf(char value, int startIndex) { }

	// RVA: 0x169AC80 Offset: 0x1699E80 VA: 0x18169AC80
	public int LastIndexOf(char value, int startIndex, int count) { }

	// RVA: 0x169A100 Offset: 0x1699300 VA: 0x18169A100
	public int LastIndexOfAny(char[] anyOf) { }

	// RVA: 0x169A3B0 Offset: 0x16995B0 VA: 0x18169A3B0
	public int LastIndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x169A130 Offset: 0x1699330 VA: 0x18169A130
	public int LastIndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x169A3D0 Offset: 0x16995D0 VA: 0x18169A3D0
	private int LastIndexOfCharArray(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x169AC50 Offset: 0x1699E50 VA: 0x18169AC50
	public int LastIndexOf(string value) { }

	// RVA: 0x169AC10 Offset: 0x1699E10 VA: 0x18169AC10
	public int LastIndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x169A7C0 Offset: 0x16999C0 VA: 0x18169A7C0
	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x169EC50 Offset: 0x169DE50 VA: 0x18169EC50
	public void .ctor(char[] value) { }

	// RVA: 0x1696020 Offset: 0x1695220 VA: 0x181696020
	private static string Ctor(char[] value) { }

	// RVA: 0x169EC50 Offset: 0x169DE50 VA: 0x18169EC50
	public void .ctor(char[] value, int startIndex, int length) { }

	// RVA: 0x1696640 Offset: 0x1695840 VA: 0x181696640
	private static string Ctor(char[] value, int startIndex, int length) { }

	[CLSCompliant(False)]
	// RVA: 0x169EC50 Offset: 0x169DE50 VA: 0x18169EC50
	public void .ctor(char* value) { }

	// RVA: 0x1695DE0 Offset: 0x1694FE0 VA: 0x181695DE0
	private static string Ctor(char* ptr) { }

	[CLSCompliant(False)]
	// RVA: 0x169EC50 Offset: 0x169DE50 VA: 0x18169EC50
	public void .ctor(char* value, int startIndex, int length) { }

	// RVA: 0x1696410 Offset: 0x1695610 VA: 0x181696410
	private static string Ctor(char* ptr, int startIndex, int length) { }

	[CLSCompliant(False)]
	// RVA: 0x169EC50 Offset: 0x169DE50 VA: 0x18169EC50
	public void .ctor(sbyte* value, int startIndex, int length) { }

	// RVA: 0x1695B90 Offset: 0x1694D90 VA: 0x181695B90
	private static string Ctor(sbyte* value, int startIndex, int length) { }

	// RVA: 0x16954C0 Offset: 0x16946C0 VA: 0x1816954C0
	private static string CreateStringForSByteConstructor(byte* pb, int numBytes) { }

	[CLSCompliant(False)]
	// RVA: 0x169EC50 Offset: 0x169DE50 VA: 0x18169EC50
	public void .ctor(sbyte* value, int startIndex, int length, Encoding enc) { }

	// RVA: 0x16961D0 Offset: 0x16953D0 VA: 0x1816961D0
	private static string Ctor(sbyte* value, int startIndex, int length, Encoding enc) { }

	// RVA: 0x169EC50 Offset: 0x169DE50 VA: 0x18169EC50
	public void .ctor(char c, int count) { }

	// RVA: 0x16960C0 Offset: 0x16952C0 VA: 0x1816960C0
	private static string Ctor(char c, int count) { }

	// RVA: 0x169EC60 Offset: 0x169DE60 VA: 0x18169EC60
	public void .ctor(ReadOnlySpan<char> value) { }

	// RVA: 0x1695F60 Offset: 0x1695160 VA: 0x181695F60
	private static string Ctor(ReadOnlySpan<char> value) { }

	// RVA: -1 Offset: -1
	public static string Create<TState>(int length, TState state, SpanAction<char, TState> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA7AF70 Offset: 0xA7A170 VA: 0x180A7AF70
	|-String.Create<ValueTuple<object, int, int>>
	|
	|-RVA: 0xA7B0E0 Offset: 0xA7A2E0 VA: 0x180A7B0E0
	|-String.Create<ValueTuple<IntPtr, int, IntPtr, int, bool>>
	|
	|-RVA: 0xA7B250 Offset: 0xA7A450 VA: 0x180A7B250
	|-String.Create<ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>>
	|
	|-RVA: 0xA7AD80 Offset: 0xA79F80 VA: 0x180A7AD80
	|-String.Create<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x169EF40 Offset: 0x169E140 VA: 0x18169EF40
	public static ReadOnlySpan<char> op_Implicit(string value) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 26
	public object Clone() { }

	// RVA: 0x16953F0 Offset: 0x16945F0 VA: 0x1816953F0
	public static string Copy(string str) { }

	// RVA: 0x16951A0 Offset: 0x16943A0 VA: 0x1816951A0
	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x169E230 Offset: 0x169D430 VA: 0x18169E230
	public char[] ToCharArray() { }

	[NonVersionable]
	// RVA: 0x1699350 Offset: 0x1698550 VA: 0x181699350
	public static bool IsNullOrEmpty(string value) { }

	// RVA: 0x1699360 Offset: 0x1698560 VA: 0x181699360
	public static bool IsNullOrWhiteSpace(string value) { }

	// RVA: 0x1698180 Offset: 0x1697380 VA: 0x181698180
	internal ref char GetRawStringData() { }

	// RVA: 0x1695540 Offset: 0x1694740 VA: 0x181695540
	internal static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding) { }

	// RVA: 0x1695490 Offset: 0x1694690 VA: 0x181695490
	internal static string CreateFromChar(char c) { }

	// RVA: 0x944470 Offset: 0x943670 VA: 0x180944470
	internal static void wstrcpy(char* dmem, char* smem, int charCount) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 3
	public override string ToString() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 24
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x169DBA0 Offset: 0x169CDA0 VA: 0x18169DBA0 Slot: 6
	private IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator() { }

	// RVA: 0x169DC00 Offset: 0x169CE00 VA: 0x18169DC00 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x169F010 Offset: 0x169E210 VA: 0x18169F010
	internal static int wcslen(char* ptr) { }

	// RVA: 0x1698190 Offset: 0x1697390 VA: 0x181698190 Slot: 9
	public TypeCode GetTypeCode() { }

	// RVA: 0x169DC60 Offset: 0x169CE60 VA: 0x18169DC60 Slot: 10
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x169DD20 Offset: 0x169CF20 VA: 0x18169DD20 Slot: 11
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x169DFE0 Offset: 0x169D1E0 VA: 0x18169DFE0 Slot: 12
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x169DCC0 Offset: 0x169CEC0 VA: 0x18169DCC0 Slot: 13
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x169DEC0 Offset: 0x169D0C0 VA: 0x18169DEC0 Slot: 14
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x169E110 Offset: 0x169D310 VA: 0x18169E110 Slot: 15
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x169DF20 Offset: 0x169D120 VA: 0x18169DF20 Slot: 16
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x169E170 Offset: 0x169D370 VA: 0x18169E170 Slot: 17
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x169DF80 Offset: 0x169D180 VA: 0x18169DF80 Slot: 18
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x169E1D0 Offset: 0x169D3D0 VA: 0x18169E1D0 Slot: 19
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x169E040 Offset: 0x169D240 VA: 0x18169E040 Slot: 20
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x169DE60 Offset: 0x169D060 VA: 0x18169DE60 Slot: 21
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x169DDE0 Offset: 0x169CFE0 VA: 0x18169DDE0 Slot: 22
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x169DD80 Offset: 0x169CF80 VA: 0x18169DD80 Slot: 23
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x169E0A0 Offset: 0x169D2A0 VA: 0x18169E0A0 Slot: 25
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x16992F0 Offset: 0x16984F0 VA: 0x1816992F0
	public bool IsNormalized(NormalizationForm normalizationForm) { }

	// RVA: 0x169B500 Offset: 0x169A700 VA: 0x18169B500
	public string Normalize(NormalizationForm normalizationForm) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_Length() { }

	// RVA: 0x1698940 Offset: 0x1697B40 VA: 0x181698940
	internal int IndexOfUnchecked(string value, int startIndex, int count) { }

	// RVA: 0x1698750 Offset: 0x1697950 VA: 0x181698750
	internal int IndexOfUncheckedIgnoreCase(string value, int startIndex, int count) { }

	// RVA: 0x169A6E0 Offset: 0x16998E0 VA: 0x18169A6E0
	internal int LastIndexOfUnchecked(string value, int startIndex, int count) { }

	// RVA: 0x169A500 Offset: 0x1699700 VA: 0x18169A500
	internal int LastIndexOfUncheckedIgnoreCase(string value, int startIndex, int count) { }

	// RVA: 0x169D490 Offset: 0x169C690 VA: 0x18169D490
	internal bool StartsWithOrdinalUnchecked(string value) { }

	// RVA: 0x1697440 Offset: 0x1696640 VA: 0x181697440
	internal static string FastAllocateString(int length) { }

	// RVA: 0x169EE50 Offset: 0x169E050 VA: 0x18169EE50
	private static void memset(byte* dest, int val, int len) { }

	// RVA: 0x169EE40 Offset: 0x169E040 VA: 0x18169EE40
	private static void memcpy(byte* dest, byte* src, int size) { }

	// RVA: 0x169ECC0 Offset: 0x169DEC0 VA: 0x18169ECC0
	internal static void bzero(byte* dest, int len) { }

	// RVA: 0x169EC80 Offset: 0x169DE80 VA: 0x18169EC80
	internal static void bzero_aligned_1(byte* dest, int len) { }

	// RVA: 0x169EC90 Offset: 0x169DE90 VA: 0x18169EC90
	internal static void bzero_aligned_2(byte* dest, int len) { }

	// RVA: 0x169ECA0 Offset: 0x169DEA0 VA: 0x18169ECA0
	internal static void bzero_aligned_4(byte* dest, int len) { }

	// RVA: 0x169ECB0 Offset: 0x169DEB0 VA: 0x18169ECB0
	internal static void bzero_aligned_8(byte* dest, int len) { }

	// RVA: 0x169EE00 Offset: 0x169E000 VA: 0x18169EE00
	internal static void memcpy_aligned_1(byte* dest, byte* src, int size) { }

	// RVA: 0x169EE10 Offset: 0x169E010 VA: 0x18169EE10
	internal static void memcpy_aligned_2(byte* dest, byte* src, int size) { }

	// RVA: 0x169EE20 Offset: 0x169E020 VA: 0x18169EE20
	internal static void memcpy_aligned_4(byte* dest, byte* src, int size) { }

	// RVA: 0x169EE30 Offset: 0x169E030 VA: 0x18169EE30
	internal static void memcpy_aligned_8(byte* dest, byte* src, int size) { }

	// RVA: 0x16959F0 Offset: 0x1694BF0 VA: 0x1816959F0
	private string CreateString(sbyte* value, int startIndex, int length) { }

	// RVA: 0x1695710 Offset: 0x1694910 VA: 0x181695710
	private string CreateString(char* value) { }

	// RVA: 0x1695880 Offset: 0x1694A80 VA: 0x181695880
	private string CreateString(char* value, int startIndex, int length) { }

	// RVA: 0x1695A10 Offset: 0x1694C10 VA: 0x181695A10
	private string CreateString(char[] val, int startIndex, int length) { }

	// RVA: 0x1695A30 Offset: 0x1694C30 VA: 0x181695A30
	private string CreateString(char[] val) { }

	// RVA: 0x16958D0 Offset: 0x1694AD0 VA: 0x1816958D0
	private string CreateString(char c, int count) { }

	// RVA: 0x16958A0 Offset: 0x1694AA0 VA: 0x1816958A0
	private string CreateString(sbyte* value, int startIndex, int length, Encoding enc) { }

	// RVA: 0x1695630 Offset: 0x1694830 VA: 0x181695630
	private string CreateString(ReadOnlySpan<char> value) { }

	[Intrinsic]
	// RVA: 0x169EDB0 Offset: 0x169DFB0 VA: 0x18169EDB0
	public char get_Chars(int index) { }
}

// Namespace: 
private sealed class TimeZoneInfo.CachedData // TypeDefIndex: 2946
{
	// Fields
	private TimeZoneInfo.OffsetAndRule _oneYearLocalFromUtc; // 0x10
	private TimeZoneInfo _localTimeZone; // 0x18
	public Dictionary<string, TimeZoneInfo> _systemTimeZones; // 0x20
	public ReadOnlyCollection<TimeZoneInfo> _readOnlySystemTimeZones; // 0x28
	public bool _allSystemTimeZonesRead; // 0x30

	// Properties
	public TimeZoneInfo Local { get; }

	// Methods

	// RVA: 0x1692590 Offset: 0x1691790 VA: 0x181692590
	private static TimeZoneInfo GetCurrentOneYearLocal() { }

	// RVA: 0x1692690 Offset: 0x1691890 VA: 0x181692690
	public TimeZoneInfo.OffsetAndRule GetOneYearLocalFromUtc(int year) { }

	// RVA: 0x1692360 Offset: 0x1691560 VA: 0x181692360
	private TimeZoneInfo CreateLocal() { }

	// RVA: 0x1692840 Offset: 0x1691A40 VA: 0x181692840
	public TimeZoneInfo get_Local() { }

	// RVA: 0x1692500 Offset: 0x1691700 VA: 0x181692500
	public DateTimeKind GetCorrespondingKind(TimeZoneInfo timeZone) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class TimeZoneInfo.OffsetAndRule // TypeDefIndex: 2947
{
	// Fields
	public readonly int Year; // 0x10
	public readonly TimeSpan Offset; // 0x18
	public readonly TimeZoneInfo.AdjustmentRule Rule; // 0x20

	// Methods

	// RVA: 0x1692B80 Offset: 0x1691D80 VA: 0x181692B80
	public void .ctor(int year, TimeSpan offset, TimeZoneInfo.AdjustmentRule rule) { }
}

// Namespace: 
internal struct TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION // TypeDefIndex: 2948
{
	// Fields
	internal Interop.Kernel32.TIME_ZONE_INFORMATION TZI; // 0x0
	internal string TimeZoneKeyName; // 0xB0
	internal byte DynamicDaylightTimeDisabled; // 0xB8
}

// Namespace: 
private enum TimeZoneInfo.TimeZoneInfoResult // TypeDefIndex: 2949
{
	// Fields
	public int value__; // 0x0
	public const TimeZoneInfo.TimeZoneInfoResult Success = 0;
	public const TimeZoneInfo.TimeZoneInfoResult TimeZoneNotFoundException = 1;
	public const TimeZoneInfo.TimeZoneInfoResult InvalidTimeZoneException = 2;
	public const TimeZoneInfo.TimeZoneInfoResult SecurityException = 3;
}

// Namespace: 
[Serializable]
public sealed class TimeZoneInfo.AdjustmentRule : IEquatable<TimeZoneInfo.AdjustmentRule>, ISerializable, IDeserializationCallback // TypeDefIndex: 2950
{
	// Fields
	private readonly DateTime _dateStart; // 0x10
	private readonly DateTime _dateEnd; // 0x18
	private readonly TimeSpan _daylightDelta; // 0x20
	private readonly TimeZoneInfo.TransitionTime _daylightTransitionStart; // 0x28
	private readonly TimeZoneInfo.TransitionTime _daylightTransitionEnd; // 0x40
	private readonly TimeSpan _baseUtcOffsetDelta; // 0x58
	private readonly bool _noDaylightTransitions; // 0x60

	// Properties
	public DateTime DateStart { get; }
	public DateTime DateEnd { get; }
	public TimeSpan DaylightDelta { get; }
	public TimeZoneInfo.TransitionTime DaylightTransitionStart { get; }
	public TimeZoneInfo.TransitionTime DaylightTransitionEnd { get; }
	internal TimeSpan BaseUtcOffsetDelta { get; }
	internal bool NoDaylightTransitions { get; }
	internal bool HasDaylightSaving { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public DateTime get_DateStart() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public DateTime get_DateEnd() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public TimeSpan get_DaylightDelta() { }

	// RVA: 0x4E6990 Offset: 0x4E5B90 VA: 0x1804E6990
	public TimeZoneInfo.TransitionTime get_DaylightTransitionStart() { }

	// RVA: 0x1690DB0 Offset: 0x168FFB0 VA: 0x181690DB0
	public TimeZoneInfo.TransitionTime get_DaylightTransitionEnd() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	internal TimeSpan get_BaseUtcOffsetDelta() { }

	// RVA: 0x4EE290 Offset: 0x4ED490 VA: 0x1804EE290
	internal bool get_NoDaylightTransitions() { }

	// RVA: 0x1690DD0 Offset: 0x168FFD0 VA: 0x181690DD0
	internal bool get_HasDaylightSaving() { }

	// RVA: 0x168FA90 Offset: 0x168EC90 VA: 0x18168FA90 Slot: 4
	public bool Equals(TimeZoneInfo.AdjustmentRule other) { }

	// RVA: 0x168FC10 Offset: 0x168EE10 VA: 0x18168FC10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1690C70 Offset: 0x168FE70 VA: 0x181690C70
	private void .ctor(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions) { }

	// RVA: 0x168F950 Offset: 0x168EB50 VA: 0x18168F950
	internal static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions) { }

	// RVA: 0x168FDA0 Offset: 0x168EFA0 VA: 0x18168FDA0
	internal bool IsStartDateMarkerForBeginningOfYear() { }

	// RVA: 0x168FC60 Offset: 0x168EE60 VA: 0x18168FC60
	internal bool IsEndDateMarkerForEndOfYear() { }

	// RVA: 0x16901C0 Offset: 0x168F3C0 VA: 0x1816901C0
	private static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd, bool noDaylightTransitions) { }

	// RVA: 0x168FEE0 Offset: 0x168F0E0 VA: 0x18168FEE0 Slot: 6
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x168FFC0 Offset: 0x168F1C0 VA: 0x18168FFC0 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1690850 Offset: 0x168FA50 VA: 0x181690850
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1690D80 Offset: 0x168FF80 VA: 0x181690D80
	internal void .ctor() { }
}

// Namespace: 
[IsReadOnly]
[Serializable]
public struct TimeZoneInfo.TransitionTime : IEquatable<TimeZoneInfo.TransitionTime>, ISerializable, IDeserializationCallback // TypeDefIndex: 2951
{
	// Fields
	private readonly DateTime _timeOfDay; // 0x0
	private readonly byte _month; // 0x8
	private readonly byte _week; // 0x9
	private readonly byte _day; // 0xA
	private readonly DayOfWeek _dayOfWeek; // 0xC
	private readonly bool _isFixedDateRule; // 0x10

	// Properties
	public DateTime TimeOfDay { get; }
	public int Month { get; }
	public int Week { get; }
	public int Day { get; }
	public DayOfWeek DayOfWeek { get; }
	public bool IsFixedDateRule { get; }

	// Methods

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public DateTime get_TimeOfDay() { }

	// RVA: 0x48F5C0 Offset: 0x48E7C0 VA: 0x18048F5C0
	public int get_Month() { }

	// RVA: 0x48F5B0 Offset: 0x48E7B0 VA: 0x18048F5B0
	public int get_Week() { }

	// RVA: 0x16ABF10 Offset: 0x16AB110 VA: 0x1816ABF10
	public int get_Day() { }

	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public DayOfWeek get_DayOfWeek() { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_IsFixedDateRule() { }

	// RVA: 0x16AB3D0 Offset: 0x16AA5D0 VA: 0x1816AB3D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x16ABF20 Offset: 0x16AB120 VA: 0x1816ABF20
	public static bool op_Inequality(TimeZoneInfo.TransitionTime t1, TimeZoneInfo.TransitionTime t2) { }

	// RVA: 0x16AB470 Offset: 0x16AA670 VA: 0x1816AB470 Slot: 4
	public bool Equals(TimeZoneInfo.TransitionTime other) { }

	// RVA: 0x16AB570 Offset: 0x16AA770 VA: 0x1816AB570 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x16ABB00 Offset: 0x16AAD00 VA: 0x1816ABB00
	private void .ctor(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule) { }

	// RVA: 0x16AB2C0 Offset: 0x16AA4C0 VA: 0x1816AB2C0
	public static TimeZoneInfo.TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day) { }

	// RVA: 0x16AB340 Offset: 0x16AA540 VA: 0x1816AB340
	public static TimeZoneInfo.TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek) { }

	// RVA: 0x16AB790 Offset: 0x16AA990 VA: 0x1816AB790
	private static void ValidateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek) { }

	// RVA: 0x16AB580 Offset: 0x16AA780 VA: 0x1816AB580 Slot: 6
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x16AB620 Offset: 0x16AA820 VA: 0x1816AB620 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16ABB90 Offset: 0x16AAD90 VA: 0x1816ABB90
	private void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TimeZoneInfo.<>c // TypeDefIndex: 2952
{
	// Fields
	public static readonly TimeZoneInfo.<>c <>9; // 0x0
	public static Comparison<TimeZoneInfo> <>9__49_0; // 0x8
	public static Comparison<TimeZoneInfo> <>9__110_0; // 0x10

	// Methods

	// RVA: 0x16AC340 Offset: 0x16AB540 VA: 0x1816AC340
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x16AC0E0 Offset: 0x16AB2E0 VA: 0x1816AC0E0
	internal int <GetSystemTimeZonesWinRTFallback>b__49_0(TimeZoneInfo x, TimeZoneInfo y) { }

	// RVA: 0x16ABF50 Offset: 0x16AB150 VA: 0x1816ABF50
	internal int <GetSystemTimeZones>b__110_0(TimeZoneInfo x, TimeZoneInfo y) { }

	// RVA: 0x16AC270 Offset: 0x16AB470 VA: 0x1816AC270
	internal bool <.cctor>b__157_0() { }
}

// Namespace: System
[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
[Serializable]
public sealed class TimeZoneInfo : IEquatable<TimeZoneInfo>, ISerializable, IDeserializationCallback // TypeDefIndex: 2953
{
	// Fields
	private static Lazy<bool> lazyHaveRegistry; // 0x0
	private readonly string _id; // 0x10
	private readonly string _displayName; // 0x18
	private readonly string _standardDisplayName; // 0x20
	private readonly string _daylightDisplayName; // 0x28
	private readonly TimeSpan _baseUtcOffset; // 0x30
	private readonly bool _supportsDaylightSavingTime; // 0x38
	private readonly TimeZoneInfo.AdjustmentRule[] _adjustmentRules; // 0x40
	private static readonly TimeZoneInfo s_utcTimeZone; // 0x8
	private static TimeZoneInfo.CachedData s_cachedData; // 0x10
	private static readonly DateTime s_maxDateOnly; // 0x18
	private static readonly DateTime s_minDateOnly; // 0x20
	private static readonly TimeSpan MaxOffset; // 0x28
	private static readonly TimeSpan MinOffset; // 0x30

	// Properties
	private static bool HaveRegistry { get; }
	public string Id { get; }
	public string DisplayName { get; }
	public TimeSpan BaseUtcOffset { get; }
	public static TimeZoneInfo Local { get; }
	public static TimeZoneInfo Utc { get; }

	// Methods

	// RVA: 0x16A60F0 Offset: 0x16A52F0 VA: 0x1816A60F0
	private static void PopulateAllSystemTimeZones(TimeZoneInfo.CachedData cachedData) { }

	// RVA: 0x16A5F40 Offset: 0x16A5140 VA: 0x1816A5F40
	private static void PopulateAllSystemTimeZonesFromRegistry(TimeZoneInfo.CachedData cachedData) { }

	// RVA: 0x16AADD0 Offset: 0x16A9FD0 VA: 0x1816AADD0
	private void .ctor(in Interop.Kernel32.TIME_ZONE_INFORMATION zone, bool dstDisabled) { }

	// RVA: 0x169F100 Offset: 0x169E300 VA: 0x18169F100
	private static bool CheckDaylightSavingTimeNotSupported(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone) { }

	// RVA: 0x16A0750 Offset: 0x169F950 VA: 0x1816A0750
	private static TimeZoneInfo.AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(in Interop.Kernel32.REG_TZI_FORMAT timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset) { }

	// RVA: 0x16A0F20 Offset: 0x16A0120 VA: 0x1816A0F20
	private static string FindIdFromTimeZoneInformation(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, out bool dstDisabled) { }

	// RVA: 0x16A3BD0 Offset: 0x16A2DD0 VA: 0x1816A3BD0
	private static TimeZoneInfo GetLocalTimeZone(TimeZoneInfo.CachedData cachedData) { }

	// RVA: 0x16A3840 Offset: 0x16A2A40 VA: 0x1816A3840
	private static TimeZoneInfo GetLocalTimeZoneFromWin32Data(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZoneInformation, bool dstDisabled) { }

	// RVA: 0x16A1360 Offset: 0x16A0560 VA: 0x1816A1360
	public static TimeZoneInfo FindSystemTimeZoneById(string id) { }

	// RVA: 0x16A1A10 Offset: 0x16A0C10 VA: 0x1816A1A10
	internal static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out bool isAmbiguousLocalDst) { }

	// RVA: 0x16A73D0 Offset: 0x16A65D0 VA: 0x1816A73D0
	private static bool TransitionTimeFromTimeZoneInformation(in Interop.Kernel32.REG_TZI_FORMAT timeZoneInformation, out TimeZoneInfo.TransitionTime transitionTime, bool readStartDate) { }

	// RVA: 0x16A7DD0 Offset: 0x16A6FD0 VA: 0x1816A7DD0
	private static bool TryCreateAdjustmentRules(string id, in Interop.Kernel32.REG_TZI_FORMAT defaultTimeZoneInformation, out TimeZoneInfo.AdjustmentRule[] rules, out Exception e, int defaultBaseUtcOffset) { }

	// RVA: 0x16A9600 Offset: 0x16A8800 VA: 0x1816A9600
	private static bool TryGetTimeZoneEntryFromRegistry(RegistryKey key, string name, out Interop.Kernel32.REG_TZI_FORMAT dtzi) { }

	// RVA: 0x16A7890 Offset: 0x16A6A90 VA: 0x1816A7890
	private static bool TryCompareStandardDate(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, in Interop.Kernel32.REG_TZI_FORMAT registryTimeZoneInfo) { }

	// RVA: 0x16A78D0 Offset: 0x16A6AD0 VA: 0x1816A78D0
	private static bool TryCompareTimeZoneInformationToRegistry(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, string id, out bool dstDisabled) { }

	// RVA: 0x16A9150 Offset: 0x16A8350 VA: 0x1816A9150
	private static string TryGetLocalizedNameByMuiNativeResource(string resource) { }

	// RVA: 0x16A94B0 Offset: 0x16A86B0 VA: 0x1816A94B0
	private static string TryGetLocalizedNameByNativeResource(string filePath, int resource) { }

	// RVA: 0x16A3FC0 Offset: 0x16A31C0 VA: 0x1816A3FC0
	private static void GetLocalizedNamesByRegistryKey(RegistryKey key, out string displayName, out string standardName, out string daylightName) { }

	// RVA: 0x16A99F0 Offset: 0x16A8BF0 VA: 0x1816A99F0
	private static TimeZoneInfo.TimeZoneInfoResult TryGetTimeZoneFromLocalMachine(string id, out TimeZoneInfo value, out Exception e) { }

	// RVA: 0x16A9AC0 Offset: 0x16A8CC0 VA: 0x1816A9AC0
	private static TimeZoneInfo.TimeZoneInfoResult TryGetTimeZoneFromLocalRegistry(string id, out TimeZoneInfo value, out Exception e) { }

	// RVA: 0x16AB170 Offset: 0x16AA370 VA: 0x1816AB170
	private static bool get_HaveRegistry() { }

	// RVA: 0x16A0BB0 Offset: 0x169FDB0 VA: 0x1816A0BB0
	internal static extern uint EnumDynamicTimeZoneInformation(uint dwIndex, out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation) { }

	// RVA: 0x16A2210 Offset: 0x16A1410 VA: 0x1816A2210
	internal static extern uint GetDynamicTimeZoneInformation(out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation) { }

	// RVA: 0x16A2090 Offset: 0x16A1290 VA: 0x1816A2090
	internal static extern uint GetDynamicTimeZoneInformationEffectiveYears(ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation, out uint FirstYear, out uint LastYear) { }

	// RVA: 0x16A4D60 Offset: 0x16A3F60 VA: 0x1816A4D60
	internal static extern bool GetTimeZoneInformationForYear(ushort wYear, ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pdtzi, out Interop.Kernel32.TIME_ZONE_INFORMATION ptzi) { }

	// RVA: 0x16A01A0 Offset: 0x169F3A0 VA: 0x1816A01A0
	internal static TimeZoneInfo.AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset) { }

	// RVA: 0x16A6530 Offset: 0x16A5730 VA: 0x1816A6530
	private static bool TransitionTimeFromTimeZoneInformation(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, out TimeZoneInfo.TransitionTime transitionTime, bool readStartDate) { }

	// RVA: 0x16A87B0 Offset: 0x16A79B0 VA: 0x1816A87B0
	internal static TimeZoneInfo TryCreateTimeZone(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation) { }

	// RVA: 0x16A3960 Offset: 0x16A2B60 VA: 0x1816A3960
	internal static TimeZoneInfo GetLocalTimeZoneInfoWinRTFallback() { }

	// RVA: 0x16A10E0 Offset: 0x16A02E0 VA: 0x1816A10E0
	internal static TimeZoneInfo FindSystemTimeZoneByIdWinRTFallback(string id) { }

	// RVA: 0x16A4410 Offset: 0x16A3610 VA: 0x1816A4410
	private static void GetSystemTimeZonesWinRTFallback(TimeZoneInfo.CachedData cachedData) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Id() { }

	// RVA: 0x16A64E0 Offset: 0x16A56E0 VA: 0x1816A64E0
	public string get_DisplayName() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public TimeSpan get_BaseUtcOffset() { }

	// RVA: 0x16A4300 Offset: 0x16A3500 VA: 0x1816A4300
	private TimeZoneInfo.AdjustmentRule GetPreviousAdjustmentRule(TimeZoneInfo.AdjustmentRule rule, Nullable<int> ruleIndex) { }

	// RVA: 0x16A5A90 Offset: 0x16A4C90 VA: 0x1816A5A90
	public TimeSpan GetUtcOffset(DateTime dateTime) { }

	// RVA: 0x16A3F00 Offset: 0x16A3100 VA: 0x1816A3F00
	internal static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x16A5340 Offset: 0x16A4540 VA: 0x1816A5340
	internal TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x16A54A0 Offset: 0x16A46A0 VA: 0x1816A54A0
	private TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags, TimeZoneInfo.CachedData cachedData) { }

	// RVA: 0x169F3D0 Offset: 0x169E5D0 VA: 0x18169F3D0
	public static void ClearCachedData() { }

	// RVA: 0x169F770 Offset: 0x169E970 VA: 0x18169F770
	internal static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags) { }

	// RVA: 0x169F810 Offset: 0x169EA10 VA: 0x18169F810
	private static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags, TimeZoneInfo.CachedData cachedData) { }

	// RVA: 0x169F660 Offset: 0x169E860 VA: 0x18169F660
	internal static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x16A0D10 Offset: 0x169FF10 VA: 0x1816A0D10 Slot: 4
	public bool Equals(TimeZoneInfo other) { }

	// RVA: 0x16A0DF0 Offset: 0x169FFF0 VA: 0x1816A0DF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x16A2360 Offset: 0x16A1560 VA: 0x1816A2360 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x16A4A20 Offset: 0x16A3C20 VA: 0x1816A4A20
	public static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones() { }

	// RVA: 0x16A5B10 Offset: 0x16A4D10 VA: 0x1816A5B10
	public bool HasSameRules(TimeZoneInfo other) { }

	// RVA: 0x16AB1E0 Offset: 0x16AA3E0 VA: 0x1816AB1E0
	public static TimeZoneInfo get_Local() { }

	// RVA: 0x16A64E0 Offset: 0x16A56E0 VA: 0x1816A64E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x16AB270 Offset: 0x16AA470 VA: 0x1816AB270
	public static TimeZoneInfo get_Utc() { }

	// RVA: 0x16AACF0 Offset: 0x16A9EF0 VA: 0x1816AACF0
	private void .ctor(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) { }

	// RVA: 0x16A0AC0 Offset: 0x169FCC0 VA: 0x1816A0AC0
	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName) { }

	// RVA: 0x16A6180 Offset: 0x16A5380 VA: 0x1816A6180 Slot: 6
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x16A6340 Offset: 0x16A5540 VA: 0x1816A6340 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16AA820 Offset: 0x16A9A20 VA: 0x1816AA820
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16A19F0 Offset: 0x16A0BF0 VA: 0x1816A19F0
	private TimeZoneInfo.AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, out Nullable<int> ruleIndex) { }

	// RVA: 0x16A17D0 Offset: 0x16A09D0 VA: 0x1816A17D0
	private TimeZoneInfo.AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, bool dateTimeisUtc, out Nullable<int> ruleIndex) { }

	// RVA: 0x169F460 Offset: 0x169E660 VA: 0x18169F460
	private int CompareAdjustmentRuleToDateTime(TimeZoneInfo.AdjustmentRule rule, TimeZoneInfo.AdjustmentRule previousRule, DateTime dateTime, DateTime dateOnly, bool dateTimeisUtc) { }

	// RVA: 0x169FF20 Offset: 0x169F120 VA: 0x18169FF20
	private DateTime ConvertToUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta) { }

	// RVA: 0x169F640 Offset: 0x169E840 VA: 0x18169F640
	private DateTime ConvertFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta) { }

	// RVA: 0x169FD60 Offset: 0x169EF60 VA: 0x18169FD60
	private DateTime ConvertToFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta, bool convertToUtc) { }

	// RVA: 0x169FF40 Offset: 0x169F140 VA: 0x18169FF40
	private static DateTime ConvertUtcToTimeZone(long ticks, TimeZoneInfo destinationTimeZone, out bool isAmbiguousLocalDst) { }

	// RVA: 0x16A1F10 Offset: 0x16A1110 VA: 0x1816A1F10
	private DaylightTimeStruct GetDaylightTime(int year, TimeZoneInfo.AdjustmentRule rule, Nullable<int> ruleIndex) { }

	// RVA: 0x16A3040 Offset: 0x16A2240 VA: 0x1816A3040
	private static bool GetIsDaylightSavings(DateTime time, TimeZoneInfo.AdjustmentRule rule, DaylightTimeStruct daylightTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x16A1E30 Offset: 0x16A1030 VA: 0x1816A1E30
	private TimeSpan GetDaylightSavingsStartOffsetFromUtc(TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule rule, Nullable<int> ruleIndex) { }

	// RVA: 0x16A1DA0 Offset: 0x16A0FA0 VA: 0x1816A1DA0
	private TimeSpan GetDaylightSavingsEndOffsetFromUtc(TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule rule) { }

	// RVA: 0x16A2780 Offset: 0x16A1980 VA: 0x1816A2780
	private static bool GetIsDaylightSavingsFromUtc(DateTime time, int year, TimeSpan utc, TimeZoneInfo.AdjustmentRule rule, Nullable<int> ruleIndex, out bool isAmbiguousLocalDst, TimeZoneInfo zone) { }

	// RVA: 0x169F130 Offset: 0x169E330 VA: 0x18169F130
	private static bool CheckIsDst(DateTime startTime, DateTime time, DateTime endTime, bool ignoreYearAdjustment, TimeZoneInfo.AdjustmentRule rule) { }

	// RVA: 0x16A2410 Offset: 0x16A1610 VA: 0x1816A2410
	private static bool GetIsAmbiguousTime(DateTime time, TimeZoneInfo.AdjustmentRule rule, DaylightTimeStruct daylightTime) { }

	// RVA: 0x16A34D0 Offset: 0x16A26D0 VA: 0x1816A34D0
	private static bool GetIsInvalidTime(DateTime time, TimeZoneInfo.AdjustmentRule rule, DaylightTimeStruct daylightTime) { }

	// RVA: 0x16A5880 Offset: 0x16A4A80 VA: 0x1816A5880
	private static TimeSpan GetUtcOffset(DateTime time, TimeZoneInfo zone, TimeZoneInfoOptions flags) { }

	// RVA: 0x16A4F60 Offset: 0x16A4160 VA: 0x1816A4F60
	private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone) { }

	// RVA: 0x16A4EE0 Offset: 0x16A40E0 VA: 0x1816A4EE0
	private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings) { }

	// RVA: 0x16A5010 Offset: 0x16A4210 VA: 0x1816A5010
	internal static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst) { }

	// RVA: 0x16A75C0 Offset: 0x16A67C0 VA: 0x1816A75C0
	internal static DateTime TransitionTimeToDateTime(int year, TimeZoneInfo.TransitionTime transitionTime) { }

	// RVA: 0x16A9F00 Offset: 0x16A9100 VA: 0x1816A9F00
	private static TimeZoneInfo.TimeZoneInfoResult TryGetTimeZone(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e, TimeZoneInfo.CachedData cachedData, bool alwaysFallbackToLocalMachine = False) { }

	// RVA: 0x16A96E0 Offset: 0x16A88E0 VA: 0x1816A96E0
	private static TimeZoneInfo.TimeZoneInfoResult TryGetTimeZoneFromLocalMachine(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e, TimeZoneInfo.CachedData cachedData) { }

	// RVA: 0x16AA1D0 Offset: 0x16A93D0 VA: 0x1816AA1D0
	private static void ValidateTimeZoneInfo(string id, TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule[] adjustmentRules, out bool adjustmentRulesSupportDst) { }

	// RVA: 0x16AA0E0 Offset: 0x16A92E0 VA: 0x1816AA0E0
	internal static bool UtcOffsetOutOfRange(TimeSpan offset) { }

	// RVA: 0x16A53D0 Offset: 0x16A45D0 VA: 0x1816A53D0
	private static TimeSpan GetUtcOffset(TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule adjustmentRule) { }

	// RVA: 0x16A5E30 Offset: 0x16A5030 VA: 0x1816A5E30
	private static bool IsValidAdjustmentRuleOffest(TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule adjustmentRule) { }

	// RVA: 0x16AA5D0 Offset: 0x16A97D0 VA: 0x1816AA5D0
	private static void .cctor() { }

	// RVA: 0x16AACC0 Offset: 0x16A9EC0 VA: 0x1816AACC0
	internal void .ctor() { }
}

// Namespace: System
[Flags]
internal enum TimeZoneInfoOptions // TypeDefIndex: 2954
{
	// Fields
	public int value__; // 0x0
	public const TimeZoneInfoOptions None = 1;
	public const TimeZoneInfoOptions NoThrowOnInvalidTime = 2;
}

// Namespace: System
[Serializable]
public class AccessViolationException : SystemException // TypeDefIndex: 2955
{
	// Methods

	// RVA: 0x168F900 Offset: 0x168EB00 VA: 0x18168F900
	public void .ctor() { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System
public sealed class Action : MulticastDelegate // TypeDefIndex: 2956
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

// Namespace: System
public sealed class Action<T> : MulticastDelegate // TypeDefIndex: 2957
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE0B20 Offset: 0xCDFD20 VA: 0x180CE0B20
	|-Action<ArraySegment<byte>>..ctor
	|-Action<KeyValuePair<int, object>>..ctor
	|-Action<KeyValuePair<object, char>>..ctor
	|-Action<KeyValuePair<object, object>>..ctor
	|-Action<KeyValuePair<object, ulong>>..ctor
	|-Action<KeyValuePair<PropertyName, object>>..ctor
	|-Action<NativeArray<ConvertMeshJobData>>..ctor
	|-Action<NativeArray<CopyClosingMeshJobData>>..ctor
	|-Action<NativeArray<NudgeJobData>>..ctor
	|-Action<NativeSlice<ConvertMeshJobData>>..ctor
	|-Action<NativeSlice<CopyClosingMeshJobData>>..ctor
	|-Action<NativeSlice<NudgeJobData>>..ctor
	|-Action<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>..ctor
	|-Action<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>..ctor
	|-Action<StructMultiKey<object, object>>..ctor
	|-Action<ValueTuple<object, object>>..ctor
	|-Action<Color>..ctor
	|-Action<ControllerTemplateElementTarget>..ctor
	|-Action<DateTimeOffset>..ctor
	|-Action<Decimal>..ctor
	|-Action<DetectiveSuspect>..ctor
	|-Action<DiscardReasonWithCategory>..ctor
	|-Action<GlyphRect>..ctor
	|-Action<Guid>..ctor
	|-Action<IngestData>..ctor
	|-Action<InputDevice>..ctor
	|-Action<InterpretedFrameInfo>..ctor
	|-Action<JsonElement>..ctor
	|-Action<JsonEncodedText>..ctor
	|-Action<LigatureSubstitutionRecord>..ctor
	|-Action<MultipleSubstitutionRecord>..ctor
	|-Action<NewConnectionEventArgs>..ctor
	|-Action<RangePositionInfo>..ctor
	|-Action<Rect>..ctor
	|-Action<Resolution>..ctor
	|-Action<RuleMatcher>..ctor
	|-Action<RulesCategory>..ctor
	|-Action<SslApplicationProtocol>..ctor
	|-Action<StylePropertyName>..ctor
	|-Action<StylePropertyValue>..ctor
	|-Action<StyleValueManaged>..ctor
	|-Action<SubString>..ctor
	|-Action<TimerState>..ctor
	|-Action<UILineInfo>..ctor
	|-Action<VFXOutputEventArgs>..ctor
	|-Action<Vector4>..ctor
	|-Action<VertexAttributeDescriptor>..ctor
	|-Action<X509ChainStatus>..ctor
	|-Action<XSXSubmitGraphicsCommandsDataCommandInternal>..ctor
	|-Action<XboxOneGDKSubmitGraphicsCommandsDataCommandInternal>..ctor
	|-Action<AchievementManager.AchievementProgressValue>..ctor
	|-Action<BeforeRenderHelper.OrderBlock>..ctor
	|-Action<CreditsController.CreditStruct>..ctor
	|-Action<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.YkJYhIwKoTBpWKATiflrEgjLfZIX>..ctor
	|-Action<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.fcJeYwLvuogcmgGamTgYErdESsqW>..ctor
	|-Action<FocusController.FocusedElement>..ctor
	|-Action<HardwareControllerTemplateMap.rwEetQoHfXcCclqvIDEVKbecRXpDb>..ctor
	|-Action<MultiColumnCollectionHeader.SortedColumnState>..ctor
	|-Action<PZVoNXqAhLHAMSWUdEitcRuLGMcmA.LxbGihMOwQSEjsHzfBQtamHgcTraA>..ctor
	|-Action<PackedPlayModeBuildLogs.RuntimeBuildLog>..ctor
	|-Action<QRCodeGenerator.AlignmentPattern>..ctor
	|-Action<QRCodeGenerator.VersionInfo>..ctor
	|-Action<QRCodeGenerator.VersionInfoDetails>..ctor
	|-Action<ResourceManager.DeferredCallbackRegisterRequest>..ctor
	|-Action<ServerManager.PingWrapper>..ctor
	|-Action<TextSettings.FontReferenceMap>..ctor
	|-Action<TextureRegistry.TextureInfo>..ctor
	|-Action<VisualTreeAsset.SlotDefinition>..ctor
	|-Action<VisualTreeAsset.SlotUsageEntry>..ctor
	|-Action<VisualTreeAsset.UxmlObjectEntry>..ctor
	|-Action<XjXmgYEoXluUbKoyNCodoxJzPrjJ.FSjxKnkodQibKwPtFNBnKKATQeux>..ctor
	|-Action<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|
	|-RVA: 0x448CF0 Offset: 0x447EF0 VA: 0x180448CF0
	|-Action<AsyncLocalValueChangedArgs<object>>..ctor
	|-Action<KeyValuePair<DiscardReasonWithCategory, int>>..ctor
	|-Action<KeyValuePair<DiscardReasonWithCategory, object>>..ctor
	|-Action<KeyValuePair<Rect, object>>..ctor
	|-Action<TempAllocator.Page<ushort>>..ctor
	|-Action<TempAllocator.Page<Vertex>>..ctor
	|-Action<AsyncOperationHandle>..ctor
	|-Action<ComputedTransitionProperty>..ctor
	|-Action<DataReceivedEventArgs>..ctor
	|-Action<DataRecordInternal>..ctor
	|-Action<DebugLogMessage>..ctor
	|-Action<Entitlement>..ctor
	|-Action<FileStat>..ctor
	|-Action<InputActionEventData>..ctor
	|-Action<InputActionSourceData>..ctor
	|-Action<ItemOwnershipInternal>..ctor
	|-Action<JsonPosition>..ctor
	|-Action<MarkToBaseAdjustmentRecord>..ctor
	|-Action<MarkToMarkAdjustmentRecord>..ctor
	|-Action<OptionInternal>..ctor
	|-Action<ParameterRef>..ctor
	|-Action<ParticipantMetadataInternal>..ctor
	|-Action<PlayerStatInfoInternal>..ctor
	|-Action<PropertyRef>..ctor
	|-Action<SandboxIdItemOwnershipInternal>..ctor
	|-Action<SelectorMatchRecord>..ctor
	|-Action<StatThresholdsInternal>..ctor
	|-Action<StyleSelectorPart>..ctor
	|-Action<StyleSyntaxToken>..ctor
	|-Action<StyleValue>..ctor
	|-Action<StyleVariable>..ctor
	|-Action<TreeViewItemWrapper>..ctor
	|-Action<Camera.RenderRequest>..ctor
	|-Action<CreditsController.FormatStruct>..ctor
	|-Action<TemplateAsset.AttributeOverride>..ctor
	|-Action<UnitySynchronizationContext.WorkRequest>..ctor
	|-Action<UnityUITextMeshProGlyphHelper.GlyphOrText>..ctor
	|-Action<VisualTreeAsset.UsingEntry>..ctor
	|
	|-RVA: 0x11065A0 Offset: 0x11057A0 VA: 0x1811065A0
	|-Action<AsyncOperationHandle<bool>>..ctor
	|-Action<AsyncOperationHandle<long>>..ctor
	|-Action<AsyncOperationHandle<object>>..ctor
	|-Action<AsyncOperationHandle<SceneInstance>>..ctor
	|-Action<KeyValuePair<int, ImmutableDictionary.HashBucket<object, object>>>..ctor
	|-Action<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>..ctor
	|-Action<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>..ctor
	|-Action<BoneWeight>..ctor
	|-Action<TypeWrapper>..ctor
	|-Action<DelayedActionManager.DelegateInfo>..ctor
	|-Action<QRCodeGenerator.ECCInfo>..ctor
	|-Action<UIRStylePainter.RepeatRectUV>..ctor
	|-Action<VisualTreeAsset.AssetEntry>..ctor
	|-Action<InstructionList.DebugView.InstructionView>..ctor
	|-Action<MultiColumnCollectionHeader.ViewState.ColumnState>..ctor
	|
	|-RVA: 0x1106640 Offset: 0x1105840 VA: 0x181106640
	|-Action<KeyValuePair<byte, int>>..ctor
	|-Action<ValueTuple<int, int>>..ctor
	|-Action<AnimatorClipInfo>..ctor
	|-Action<CancellationToken>..ctor
	|-Action<DateTime>..ctor
	|-Action<Edge>..ctor
	|-Action<HttpStatusCodeRange>..ctor
	|-Action<SceneAdapter>..ctor
	|-Action<TimeSpan>..ctor
	|-Action<TimeValue>..ctor
	|-Action<BitmapAllocator32.Page>..ctor
	|-Action<DtlsUnityConnection.FragmentRange>..ctor
	|-Action<QRCodeGenerator.Antilog>..ctor
	|-Action<QRCodeGenerator.PolynomItem>..ctor
	|-Action<SecurityLogBehaviour.SecurityLogEntry>..ctor
	|-Action<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>..ctor
	|
	|-RVA: 0x11B9A70 Offset: 0x11B8C70 VA: 0x1811B9A70
	|-Action<Nullable<ExternalAccountInfo>>..ctor
	|-Action<Announcement>..ctor
	|-Action<Matrix4x4>..ctor
	|-Action<TexturePacker_JsonArray.Frame>..ctor
	|
	|-RVA: 0x11BA010 Offset: 0x11B9210 VA: 0x1811BA010
	|-Action<SequenceBuffer.SequencedData<VentilationSystem.VentMoveInfo, VentilationSystem.VentMoveInfo>>..ctor
	|-Action<ManipulatorActivationFilter>..ctor
	|-Action<UICharInfo>..ctor
	|-Action<Vector3>..ctor
	|-Action<Vector3Int>..ctor
	|-Action<CustomController.CZxNqDPSLSmjvjcEzpoKeadUPlaM>..ctor
	|-Action<PlayerController.Element.TBnjpqFyveWLFptREPetgdFmwyCWA>..ctor
	|
	|-RVA: 0x46C600 Offset: 0x46B800 VA: 0x18046C600
	|-Action<bool>..ctor
	|-Action<byte>..ctor
	|-Action<ByteEnum>..ctor
	|-Action<sbyte>..ctor
	|
	|-RVA: 0x11B9B10 Offset: 0x11B8D10 VA: 0x1811B9B10
	|-Action<char>..ctor
	|-Action<short>..ctor
	|-Action<ushort>..ctor
	|-Action<UInt16Enum>..ctor
	|
	|-RVA: 0xCE0A80 Offset: 0xCDFC80 VA: 0x180CE0A80
	|-Action<Color32>..ctor
	|-Action<EasingFunction>..ctor
	|-Action<RegexCharClass.SingleRange>..ctor
	|
	|-RVA: 0x11B9930 Offset: 0x11B8B30 VA: 0x1811B9930
	|-Action<ContactPoint2D>..ctor
	|-Action<ControllerPollingInfo>..ctor
	|-Action<ExternalAccountInfo>..ctor
	|-Action<ResourceManager.DiagnosticEventContext>..ctor
	|-Action<TextureBlitter.BlitInfo>..ctor
	|
	|-RVA: 0x11B96B0 Offset: 0x11B88B0 VA: 0x1811B96B0
	|-Action<DiagnosticEvent>..ctor
	|-Action<ModIdentifierInternal>..ctor
	|-Action<ObjectInitializationData>..ctor
	|-Action<Relationship>..ctor
	|-Action<SubMeshDescriptor>..ctor
	|-Action<QRCodeGenerator.CodewordBlock>..ctor
	|
	|-RVA: 0x5C4990 Offset: 0x5C3B90 VA: 0x1805C4990
	|-Action<double>..ctor
	|-Action<float>..ctor
	|
	|-RVA: 0x11B9F70 Offset: 0x11B9170 VA: 0x1811B9F70
	|-Action<ElementAssignmentConflictInfo>..ctor
	|-Action<GlyphPairAdjustmentRecord>..ctor
	|
	|-RVA: 0x11B9750 Offset: 0x11B8950 VA: 0x1811B9750
	|-Action<Entitlement>..ctor
	|-Action<PhysicsShape2D>..ctor
	|-Action<PlayerLoopSystem>..ctor
	|-Action<PlayerLoopSystemInternal>..ctor
	|-Action<Sku>..ctor
	|-Action<TypeDispatchData>..ctor
	|-Action<User>..ctor
	|-Action<UIRenderDevice.AllocToFree>..ctor
	|
	|-RVA: 0x11B99D0 Offset: 0x11B8BD0 VA: 0x1811B99D0
	|-Action<GameListing>..ctor
	|-Action<RaycastResult>..ctor
	|-Action<WriteStackFrame>..ctor
	|-Action<UIRStylePainter.Entry>..ctor
	|-Action<UIRenderDevice.AllocToUpdate>..ctor
	|
	|-RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	|-Action<int>..ctor
	|-Action<Int32Enum>..ctor
	|-Action<uint>..ctor
	|
	|-RVA: 0x438120 Offset: 0x437320 VA: 0x180438120
	|-Action<long>..ctor
	|-Action<IntPtr>..ctor
	|-Action<ulong>..ctor
	|
	|-RVA: 0x11B9D90 Offset: 0x11B8F90 VA: 0x1811B9D90
	|-Action<MeshGenerationResult>..ctor
	|
	|-RVA: 0x89EDF0 Offset: 0x89DFF0 VA: 0x18089EDF0
	|-Action<object>..ctor
	|
	|-RVA: 0x11B97F0 Offset: 0x11B89F0 VA: 0x1811B97F0
	|-Action<RaycastHit2D>..ctor
	|
	|-RVA: 0x11BA150 Offset: 0x11B9350 VA: 0x1811BA150
	|-Action<ReadStackFrame>..ctor
	|
	|-RVA: 0x11B9E30 Offset: 0x11B9030 VA: 0x1811B9E30
	|-Action<TransformDispatchData>..ctor
	|-Action<XRNodeState>..ctor
	|-Action<RenderChain.RenderNodeData>..ctor
	|
	|-RVA: 0x11B9CF0 Offset: 0x11B8EF0 VA: 0x1811B9CF0
	|-Action<UIVertex>..ctor
	|
	|-RVA: 0xCE0CD0 Offset: 0xCDFED0 VA: 0x180CE0CD0
	|-Action<Vector2>..ctor
	|
	|-RVA: 0x11BA0B0 Offset: 0x11B92B0 VA: 0x1811BA0B0
	|-Action<Win32_IP_ADAPTER_ADDRESSES>..ctor
	|
	|-RVA: 0x11B9C50 Offset: 0x11B8E50 VA: 0x1811B9C50
	|-Action<Win32_IP_ADAPTER_INFO>..ctor
	|
	|-RVA: 0xCE0BC0 Offset: 0xCDFDC0 VA: 0x180CE0BC0
	|-Action<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x11B9ED0 Offset: 0x11B90D0 VA: 0x1811B9ED0
	|-Action<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>..ctor
	|
	|-RVA: 0x11B9BB0 Offset: 0x11B8DB0 VA: 0x1811B9BB0
	|-Action<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x11B9890 Offset: 0x11B8A90 VA: 0x1811B9890
	|-Action<RadialMenu.CachedButtonObject>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB85FD0 Offset: 0xB851D0 VA: 0x180B85FD0
	|-Action<ArraySegment<byte>>.Invoke
	|-Action<KeyValuePair<int, object>>.Invoke
	|-Action<KeyValuePair<object, char>>.Invoke
	|-Action<KeyValuePair<object, object>>.Invoke
	|-Action<KeyValuePair<object, ulong>>.Invoke
	|-Action<KeyValuePair<PropertyName, object>>.Invoke
	|-Action<NativeArray<ConvertMeshJobData>>.Invoke
	|-Action<NativeArray<CopyClosingMeshJobData>>.Invoke
	|-Action<NativeArray<NudgeJobData>>.Invoke
	|-Action<NativeSlice<ConvertMeshJobData>>.Invoke
	|-Action<NativeSlice<CopyClosingMeshJobData>>.Invoke
	|-Action<NativeSlice<NudgeJobData>>.Invoke
	|-Action<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.Invoke
	|-Action<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.Invoke
	|-Action<StructMultiKey<object, object>>.Invoke
	|-Action<ValueTuple<object, object>>.Invoke
	|-Action<Color>.Invoke
	|-Action<ControllerTemplateElementTarget>.Invoke
	|-Action<DateTimeOffset>.Invoke
	|-Action<Decimal>.Invoke
	|-Action<DetectiveSuspect>.Invoke
	|-Action<DiscardReasonWithCategory>.Invoke
	|-Action<GlyphRect>.Invoke
	|-Action<Guid>.Invoke
	|-Action<IngestData>.Invoke
	|-Action<InputDevice>.Invoke
	|-Action<InterpretedFrameInfo>.Invoke
	|-Action<JsonElement>.Invoke
	|-Action<JsonEncodedText>.Invoke
	|-Action<LigatureSubstitutionRecord>.Invoke
	|-Action<MultipleSubstitutionRecord>.Invoke
	|-Action<NewConnectionEventArgs>.Invoke
	|-Action<RangePositionInfo>.Invoke
	|-Action<Rect>.Invoke
	|-Action<Resolution>.Invoke
	|-Action<RuleMatcher>.Invoke
	|-Action<RulesCategory>.Invoke
	|-Action<SslApplicationProtocol>.Invoke
	|-Action<StylePropertyName>.Invoke
	|-Action<StylePropertyValue>.Invoke
	|-Action<StyleValueManaged>.Invoke
	|-Action<SubString>.Invoke
	|-Action<TimerState>.Invoke
	|-Action<UILineInfo>.Invoke
	|-Action<VFXOutputEventArgs>.Invoke
	|-Action<Vector4>.Invoke
	|-Action<VertexAttributeDescriptor>.Invoke
	|-Action<X509ChainStatus>.Invoke
	|-Action<XSXSubmitGraphicsCommandsDataCommandInternal>.Invoke
	|-Action<XboxOneGDKSubmitGraphicsCommandsDataCommandInternal>.Invoke
	|-Action<AchievementManager.AchievementProgressValue>.Invoke
	|-Action<BeforeRenderHelper.OrderBlock>.Invoke
	|-Action<CreditsController.CreditStruct>.Invoke
	|-Action<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.YkJYhIwKoTBpWKATiflrEgjLfZIX>.Invoke
	|-Action<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.fcJeYwLvuogcmgGamTgYErdESsqW>.Invoke
	|-Action<FocusController.FocusedElement>.Invoke
	|-Action<HardwareControllerTemplateMap.rwEetQoHfXcCclqvIDEVKbecRXpDb>.Invoke
	|-Action<MultiColumnCollectionHeader.SortedColumnState>.Invoke
	|-Action<PZVoNXqAhLHAMSWUdEitcRuLGMcmA.LxbGihMOwQSEjsHzfBQtamHgcTraA>.Invoke
	|-Action<PackedPlayModeBuildLogs.RuntimeBuildLog>.Invoke
	|-Action<QRCodeGenerator.AlignmentPattern>.Invoke
	|-Action<QRCodeGenerator.VersionInfo>.Invoke
	|-Action<QRCodeGenerator.VersionInfoDetails>.Invoke
	|-Action<ResourceManager.DeferredCallbackRegisterRequest>.Invoke
	|-Action<ServerManager.PingWrapper>.Invoke
	|-Action<TextSettings.FontReferenceMap>.Invoke
	|-Action<TextureRegistry.TextureInfo>.Invoke
	|-Action<VisualTreeAsset.SlotDefinition>.Invoke
	|-Action<VisualTreeAsset.SlotUsageEntry>.Invoke
	|-Action<VisualTreeAsset.UxmlObjectEntry>.Invoke
	|-Action<XjXmgYEoXluUbKoyNCodoxJzPrjJ.FSjxKnkodQibKwPtFNBnKKATQeux>.Invoke
	|-Action<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Invoke
	|
	|-RVA: 0x448CC0 Offset: 0x447EC0 VA: 0x180448CC0
	|-Action<AsyncLocalValueChangedArgs<object>>.Invoke
	|-Action<KeyValuePair<DiscardReasonWithCategory, int>>.Invoke
	|-Action<KeyValuePair<DiscardReasonWithCategory, object>>.Invoke
	|-Action<KeyValuePair<Rect, object>>.Invoke
	|-Action<TempAllocator.Page<ushort>>.Invoke
	|-Action<TempAllocator.Page<Vertex>>.Invoke
	|-Action<AsyncOperationHandle>.Invoke
	|-Action<ComputedTransitionProperty>.Invoke
	|-Action<DataReceivedEventArgs>.Invoke
	|-Action<DataRecordInternal>.Invoke
	|-Action<DebugLogMessage>.Invoke
	|-Action<Entitlement>.Invoke
	|-Action<FileStat>.Invoke
	|-Action<InputActionEventData>.Invoke
	|-Action<InputActionSourceData>.Invoke
	|-Action<ItemOwnershipInternal>.Invoke
	|-Action<JsonPosition>.Invoke
	|-Action<MarkToBaseAdjustmentRecord>.Invoke
	|-Action<MarkToMarkAdjustmentRecord>.Invoke
	|-Action<OptionInternal>.Invoke
	|-Action<ParameterRef>.Invoke
	|-Action<ParticipantMetadataInternal>.Invoke
	|-Action<PlayerStatInfoInternal>.Invoke
	|-Action<PropertyRef>.Invoke
	|-Action<SandboxIdItemOwnershipInternal>.Invoke
	|-Action<SelectorMatchRecord>.Invoke
	|-Action<StatThresholdsInternal>.Invoke
	|-Action<StyleSelectorPart>.Invoke
	|-Action<StyleSyntaxToken>.Invoke
	|-Action<StyleValue>.Invoke
	|-Action<StyleVariable>.Invoke
	|-Action<TreeViewItemWrapper>.Invoke
	|-Action<Camera.RenderRequest>.Invoke
	|-Action<CreditsController.FormatStruct>.Invoke
	|-Action<TemplateAsset.AttributeOverride>.Invoke
	|-Action<UnitySynchronizationContext.WorkRequest>.Invoke
	|-Action<UnityUITextMeshProGlyphHelper.GlyphOrText>.Invoke
	|-Action<VisualTreeAsset.UsingEntry>.Invoke
	|
	|-RVA: 0xB86040 Offset: 0xB85240 VA: 0x180B86040
	|-Action<AsyncOperationHandle<bool>>.Invoke
	|-Action<AsyncOperationHandle<long>>.Invoke
	|-Action<AsyncOperationHandle<object>>.Invoke
	|-Action<AsyncOperationHandle<SceneInstance>>.Invoke
	|-Action<KeyValuePair<int, ImmutableDictionary.HashBucket<object, object>>>.Invoke
	|-Action<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.Invoke
	|-Action<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.Invoke
	|-Action<BoneWeight>.Invoke
	|-Action<TypeWrapper>.Invoke
	|-Action<DelayedActionManager.DelegateInfo>.Invoke
	|-Action<QRCodeGenerator.ECCInfo>.Invoke
	|-Action<UIRStylePainter.RepeatRectUV>.Invoke
	|-Action<VisualTreeAsset.AssetEntry>.Invoke
	|-Action<InstructionList.DebugView.InstructionView>.Invoke
	|-Action<MultiColumnCollectionHeader.ViewState.ColumnState>.Invoke
	|
	|-RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250
	|-Action<KeyValuePair<byte, int>>.Invoke
	|-Action<ValueTuple<int, int>>.Invoke
	|-Action<AnimatorClipInfo>.Invoke
	|-Action<bool>.Invoke
	|-Action<byte>.Invoke
	|-Action<ByteEnum>.Invoke
	|-Action<CancellationToken>.Invoke
	|-Action<char>.Invoke
	|-Action<Color32>.Invoke
	|-Action<DateTime>.Invoke
	|-Action<double>.Invoke
	|-Action<EasingFunction>.Invoke
	|-Action<Edge>.Invoke
	|-Action<HttpStatusCodeRange>.Invoke
	|-Action<short>.Invoke
	|-Action<int>.Invoke
	|-Action<Int32Enum>.Invoke
	|-Action<long>.Invoke
	|-Action<IntPtr>.Invoke
	|-Action<object>.Invoke
	|-Action<sbyte>.Invoke
	|-Action<SceneAdapter>.Invoke
	|-Action<float>.Invoke
	|-Action<TimeSpan>.Invoke
	|-Action<TimeValue>.Invoke
	|-Action<ushort>.Invoke
	|-Action<UInt16Enum>.Invoke
	|-Action<uint>.Invoke
	|-Action<ulong>.Invoke
	|-Action<Vector2>.Invoke
	|-Action<__Il2CppFullySharedGenericType>.Invoke
	|-Action<BitmapAllocator32.Page>.Invoke
	|-Action<DtlsUnityConnection.FragmentRange>.Invoke
	|-Action<QRCodeGenerator.Antilog>.Invoke
	|-Action<QRCodeGenerator.PolynomItem>.Invoke
	|-Action<RegexCharClass.SingleRange>.Invoke
	|-Action<SecurityLogBehaviour.SecurityLogEntry>.Invoke
	|-Action<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.Invoke
	|
	|-RVA: 0xB86140 Offset: 0xB85340 VA: 0x180B86140
	|-Action<Nullable<ExternalAccountInfo>>.Invoke
	|-Action<Announcement>.Invoke
	|-Action<Matrix4x4>.Invoke
	|-Action<TexturePacker_JsonArray.Frame>.Invoke
	|
	|-RVA: 0xB86180 Offset: 0xB85380 VA: 0x180B86180
	|-Action<SequenceBuffer.SequencedData<VentilationSystem.VentMoveInfo, VentilationSystem.VentMoveInfo>>.Invoke
	|-Action<ManipulatorActivationFilter>.Invoke
	|-Action<UICharInfo>.Invoke
	|-Action<Vector3>.Invoke
	|-Action<Vector3Int>.Invoke
	|-Action<CustomController.CZxNqDPSLSmjvjcEzpoKeadUPlaM>.Invoke
	|-Action<PlayerController.Element.TBnjpqFyveWLFptREPetgdFmwyCWA>.Invoke
	|
	|-RVA: 0xB860B0 Offset: 0xB852B0 VA: 0x180B860B0
	|-Action<ContactPoint2D>.Invoke
	|-Action<ControllerPollingInfo>.Invoke
	|-Action<ExternalAccountInfo>.Invoke
	|-Action<ResourceManager.DiagnosticEventContext>.Invoke
	|-Action<TextureBlitter.BlitInfo>.Invoke
	|
	|-RVA: 0xB86100 Offset: 0xB85300 VA: 0x180B86100
	|-Action<DiagnosticEvent>.Invoke
	|-Action<ModIdentifierInternal>.Invoke
	|-Action<ObjectInitializationData>.Invoke
	|-Action<Relationship>.Invoke
	|-Action<SubMeshDescriptor>.Invoke
	|-Action<QRCodeGenerator.CodewordBlock>.Invoke
	|
	|-RVA: 0xB86070 Offset: 0xB85270 VA: 0x180B86070
	|-Action<ElementAssignmentConflictInfo>.Invoke
	|-Action<GlyphPairAdjustmentRecord>.Invoke
	|
	|-RVA: 0xB86000 Offset: 0xB85200 VA: 0x180B86000
	|-Action<Entitlement>.Invoke
	|-Action<PhysicsShape2D>.Invoke
	|-Action<PlayerLoopSystem>.Invoke
	|-Action<PlayerLoopSystemInternal>.Invoke
	|-Action<Sku>.Invoke
	|-Action<TypeDispatchData>.Invoke
	|-Action<User>.Invoke
	|-Action<UIRenderDevice.AllocToFree>.Invoke
	|
	|-RVA: 0xB861B0 Offset: 0xB853B0 VA: 0x180B861B0
	|-Action<GameListing>.Invoke
	|-Action<RaycastResult>.Invoke
	|-Action<WriteStackFrame>.Invoke
	|-Action<UIRStylePainter.Entry>.Invoke
	|-Action<UIRenderDevice.AllocToUpdate>.Invoke
	|
	|-RVA: 0x11B9650 Offset: 0x11B8850 VA: 0x1811B9650
	|-Action<MeshGenerationResult>.Invoke
	|
	|-RVA: 0xB86F00 Offset: 0xB86100 VA: 0x180B86F00
	|-Action<RaycastHit2D>.Invoke
	|
	|-RVA: 0xB87120 Offset: 0xB86320 VA: 0x180B87120
	|-Action<ReadStackFrame>.Invoke
	|
	|-RVA: 0xB86DC0 Offset: 0xB85FC0 VA: 0x180B86DC0
	|-Action<TransformDispatchData>.Invoke
	|-Action<XRNodeState>.Invoke
	|-Action<RenderChain.RenderNodeData>.Invoke
	|
	|-RVA: 0xB87030 Offset: 0xB86230 VA: 0x180B87030
	|-Action<UIVertex>.Invoke
	|
	|-RVA: 0xB86F90 Offset: 0xB86190 VA: 0x180B86F90
	|-Action<Win32_IP_ADAPTER_ADDRESSES>.Invoke
	|
	|-RVA: 0xB86E20 Offset: 0xB86020 VA: 0x180B86E20
	|-Action<Win32_IP_ADAPTER_INFO>.Invoke
	|
	|-RVA: 0xB86F40 Offset: 0xB86140 VA: 0x180B86F40
	|-Action<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>.Invoke
	|
	|-RVA: 0xB870A0 Offset: 0xB862A0 VA: 0x180B870A0
	|-Action<ParticleSystem.Particle>.Invoke
	|
	|-RVA: 0xB86EA0 Offset: 0xB860A0 VA: 0x180B86EA0
	|-Action<RadialMenu.CachedButtonObject>.Invoke
	*/
}

// Namespace: System
public sealed class Action<T1, T2> : MulticastDelegate // TypeDefIndex: 2958
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BAF10 Offset: 0x11BA110 VA: 0x1811BAF10
	|-Action<AsyncOperationHandle, object>..ctor
	|
	|-RVA: 0x11BAE70 Offset: 0x11BA070 VA: 0x1811BAE70
	|-Action<bool, object>..ctor
	|
	|-RVA: 0x11BAAF0 Offset: 0x11B9CF0 VA: 0x1811BAAF0
	|-Action<DRzFGNwLfBtrVDIrmmUwQRiiTbRh, Int32Enum>..ctor
	|-Action<SceneAdapter, Int32Enum>..ctor
	|
	|-RVA: 0xCE0EB0 Offset: 0xCE00B0 VA: 0x180CE0EB0
	|-Action<int, bool>..ctor
	|-Action<Int32Enum, bool>..ctor
	|-Action<uint, bool>..ctor
	|
	|-RVA: 0x4591F0 Offset: 0x4583F0 VA: 0x1804591F0
	|-Action<int, DebugLogMessage>..ctor
	|
	|-RVA: 0x11BACB0 Offset: 0x11B9EB0 VA: 0x1811BACB0
	|-Action<int, int>..ctor
	|-Action<int, Int32Enum>..ctor
	|-Action<Int32Enum, int>..ctor
	|-Action<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x457BE0 Offset: 0x456DE0 VA: 0x180457BE0
	|-Action<int, object>..ctor
	|-Action<Int32Enum, object>..ctor
	|
	|-RVA: 0xCE0D70 Offset: 0xCDFF70 VA: 0x180CE0D70
	|-Action<int, float>..ctor
	|
	|-RVA: 0x11BA2F0 Offset: 0x11B94F0 VA: 0x1811BA2F0
	|-Action<NYiGjGoeuAGAiAAPHzwngpUOqtqd, double>..ctor
	|-Action<WheFpGpbbVaqkxBcLsFwylkICQNKA, double>..ctor
	|
	|-RVA: 0x11BA4B0 Offset: 0x11B96B0 VA: 0x1811BA4B0
	|-Action<object, NativeArray<Vector3Int>>..ctor
	|-Action<object, Nullable<IntPtr>>..ctor
	|-Action<object, Nullable<UIntPtr>>..ctor
	|-Action<object, DateTimeOffset>..ctor
	|-Action<object, Decimal>..ctor
	|-Action<object, Guid>..ctor
	|-Action<object, JsonElement>..ctor
	|
	|-RVA: 0x11BA6F0 Offset: 0x11B98F0 VA: 0x1811BA6F0
	|-Action<object, bool>..ctor
	|-Action<object, byte>..ctor
	|-Action<object, sbyte>..ctor
	|
	|-RVA: 0x11BA930 Offset: 0x11B9B30 VA: 0x1811BA930
	|-Action<object, char>..ctor
	|-Action<object, short>..ctor
	|-Action<object, ushort>..ctor
	|
	|-RVA: 0x11BAB90 Offset: 0x11B9D90 VA: 0x1811BAB90
	|-Action<object, DateTime>..ctor
	|-Action<object, StyleValues>..ctor
	|
	|-RVA: 0x11BA390 Offset: 0x11B9590 VA: 0x1811BA390
	|-Action<object, double>..ctor
	|-Action<object, float>..ctor
	|
	|-RVA: 0x11BA5D0 Offset: 0x11B97D0 VA: 0x1811BA5D0
	|-Action<object, int>..ctor
	|-Action<object, Int32Enum>..ctor
	|
	|-RVA: 0x11BAD50 Offset: 0x11B9F50 VA: 0x1811BAD50
	|-Action<object, long>..ctor
	|-Action<object, IntPtr>..ctor
	|-Action<object, ulong>..ctor
	|-Action<object, UIntPtr>..ctor
	|
	|-RVA: 0x11BA810 Offset: 0x11B9A10 VA: 0x1811BA810
	|-Action<object, MatchResultInfo>..ctor
	|-Action<object, Vector3>..ctor
	|
	|-RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	|-Action<object, object>..ctor
	|
	|-RVA: 0x11BB050 Offset: 0x11BA250 VA: 0x1811BB050
	|-Action<object, uint>..ctor
	|
	|-RVA: 0x11BB210 Offset: 0x11BA410 VA: 0x1811BB210
	|-Action<object, tpBEkSPbhGFZAskthAKVELrwzbhGA>..ctor
	|
	|-RVA: 0x11BAFB0 Offset: 0x11BA1B0 VA: 0x1811BAFB0
	|-Action<PhysicsScene, NativeArray<ModifiableContactPair>>..ctor
	|
	|-RVA: 0x11BB170 Offset: 0x11BA370 VA: 0x1811BB170
	|-Action<SceneAdapter, SceneAdapter>..ctor
	|
	|-RVA: 0x11BAA50 Offset: 0x11B9C50 VA: 0x1811BAA50
	|-Action<float, Vector3>..ctor
	|
	|-RVA: 0xBF24F0 Offset: 0xBF16F0 VA: 0x180BF24F0
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x11BB330 Offset: 0x11BA530 VA: 0x1811BB330
	|-Action<tuMSrYDzKEBHBInfPlyIwFFIoJwK, double>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BA2C0 Offset: 0x11B94C0 VA: 0x1811BA2C0
	|-Action<AsyncOperationHandle, object>.Invoke
	|
	|-RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10
	|-Action<bool, object>.Invoke
	|-Action<DRzFGNwLfBtrVDIrmmUwQRiiTbRh, Int32Enum>.Invoke
	|-Action<int, bool>.Invoke
	|-Action<int, int>.Invoke
	|-Action<int, Int32Enum>.Invoke
	|-Action<int, object>.Invoke
	|-Action<int, float>.Invoke
	|-Action<Int32Enum, bool>.Invoke
	|-Action<Int32Enum, int>.Invoke
	|-Action<Int32Enum, Int32Enum>.Invoke
	|-Action<Int32Enum, object>.Invoke
	|-Action<object, bool>.Invoke
	|-Action<object, byte>.Invoke
	|-Action<object, char>.Invoke
	|-Action<object, DateTime>.Invoke
	|-Action<object, double>.Invoke
	|-Action<object, short>.Invoke
	|-Action<object, int>.Invoke
	|-Action<object, Int32Enum>.Invoke
	|-Action<object, long>.Invoke
	|-Action<object, IntPtr>.Invoke
	|-Action<object, object>.Invoke
	|-Action<object, sbyte>.Invoke
	|-Action<object, float>.Invoke
	|-Action<object, StyleValues>.Invoke
	|-Action<object, ushort>.Invoke
	|-Action<object, uint>.Invoke
	|-Action<object, ulong>.Invoke
	|-Action<object, UIntPtr>.Invoke
	|-Action<SceneAdapter, Int32Enum>.Invoke
	|-Action<SceneAdapter, SceneAdapter>.Invoke
	|-Action<uint, bool>.Invoke
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	|
	|-RVA: 0x448B50 Offset: 0x447D50 VA: 0x180448B50
	|-Action<int, DebugLogMessage>.Invoke
	|
	|-RVA: 0x11BA250 Offset: 0x11B9450 VA: 0x1811BA250
	|-Action<NYiGjGoeuAGAiAAPHzwngpUOqtqd, double>.Invoke
	|-Action<WheFpGpbbVaqkxBcLsFwylkICQNKA, double>.Invoke
	|
	|-RVA: 0x44A010 Offset: 0x449210 VA: 0x18044A010
	|-Action<object, NativeArray<Vector3Int>>.Invoke
	|-Action<object, Nullable<IntPtr>>.Invoke
	|-Action<object, Nullable<UIntPtr>>.Invoke
	|-Action<object, DateTimeOffset>.Invoke
	|-Action<object, Decimal>.Invoke
	|-Action<object, Guid>.Invoke
	|-Action<object, JsonElement>.Invoke
	|-Action<PhysicsScene, NativeArray<ModifiableContactPair>>.Invoke
	|
	|-RVA: 0x11BA1F0 Offset: 0x11B93F0 VA: 0x1811BA1F0
	|-Action<object, MatchResultInfo>.Invoke
	|-Action<object, Vector3>.Invoke
	|-Action<float, Vector3>.Invoke
	|
	|-RVA: 0x11BA220 Offset: 0x11B9420 VA: 0x1811BA220
	|-Action<object, tpBEkSPbhGFZAskthAKVELrwzbhGA>.Invoke
	|
	|-RVA: 0x11BA280 Offset: 0x11B9480 VA: 0x1811BA280
	|-Action<tuMSrYDzKEBHBInfPlyIwFFIoJwK, double>.Invoke
	*/
}

// Namespace: System
public sealed class Action<T1, T2, T3> : MulticastDelegate // TypeDefIndex: 2959
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BB710 Offset: 0x11BA910 VA: 0x1811BB710
	|-Action<bool, bool, int>..ctor
	|
	|-RVA: 0x11BB7B0 Offset: 0x11BA9B0 VA: 0x1811BB7B0
	|-Action<bool, int, int>..ctor
	|
	|-RVA: 0x11BB550 Offset: 0x11BA750 VA: 0x1811BB550
	|-Action<bool, int, object>..ctor
	|
	|-RVA: 0x468E20 Offset: 0x468020 VA: 0x180468E20
	|-Action<int, int, object>..ctor
	|
	|-RVA: 0x11BB970 Offset: 0x11BAB70 VA: 0x1811BB970
	|-Action<int, int, float>..ctor
	|
	|-RVA: 0x11BB430 Offset: 0x11BA630 VA: 0x1811BB430
	|-Action<object, bool, DebugScreenCapture>..ctor
	|
	|-RVA: 0x11BB5F0 Offset: 0x11BA7F0 VA: 0x1811BB5F0
	|-Action<object, int, int>..ctor
	|-Action<object, int, Int32Enum>..ctor
	|
	|-RVA: 0x11BB850 Offset: 0x11BAA50 VA: 0x1811BB850
	|-Action<object, object, object>..ctor
	|
	|-RVA: 0xCE0FF0 Offset: 0xCE01F0 VA: 0x180CE0FF0
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0
	|-Action<bool, bool, int>.Invoke
	|-Action<bool, int, int>.Invoke
	|-Action<bool, int, object>.Invoke
	|-Action<int, int, object>.Invoke
	|-Action<object, int, int>.Invoke
	|-Action<object, int, Int32Enum>.Invoke
	|-Action<object, object, object>.Invoke
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	|
	|-RVA: 0x11BB3D0 Offset: 0x11BA5D0 VA: 0x1811BB3D0
	|-Action<int, int, float>.Invoke
	|
	|-RVA: 0x11BB3F0 Offset: 0x11BA5F0 VA: 0x1811BB3F0
	|-Action<object, bool, DebugScreenCapture>.Invoke
	*/
}

// Namespace: System
public sealed class Action<T1, T2, T3, T4> : MulticastDelegate // TypeDefIndex: 2960
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BBC10 Offset: 0x11BAE10 VA: 0x1811BBC10
	|-Action<AsyncOperationHandle, Int32Enum, int, object>..ctor
	|
	|-RVA: 0x11BBDD0 Offset: 0x11BAFD0 VA: 0x1811BBDD0
	|-Action<CkhlcIPlVvypBSVaFOCHkKzsiiww, DRzFGNwLfBtrVDIrmmUwQRiiTbRh, uint, IntPtr>..ctor
	|
	|-RVA: 0x11BBA60 Offset: 0x11BAC60 VA: 0x1811BBA60
	|-Action<int, object, bool, object>..ctor
	|
	|-RVA: 0x11BBB00 Offset: 0x11BAD00 VA: 0x1811BBB00
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BBA10 Offset: 0x11BAC10 VA: 0x1811BBA10
	|-Action<AsyncOperationHandle, Int32Enum, int, object>.Invoke
	|
	|-RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0
	|-Action<CkhlcIPlVvypBSVaFOCHkKzsiiww, DRzFGNwLfBtrVDIrmmUwQRiiTbRh, uint, IntPtr>.Invoke
	|-Action<int, object, bool, object>.Invoke
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Action<T1, T2, T3, T4, T5> : MulticastDelegate // TypeDefIndex: 2961
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BBF90 Offset: 0x11BB190 VA: 0x1811BBF90
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x449250 Offset: 0x448450 VA: 0x180449250
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Action<T1, T2, T3, T4, T5, T6> : MulticastDelegate // TypeDefIndex: 2962
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BC1B0 Offset: 0x11BB3B0 VA: 0x1811BC1B0
	|-Action<object, IntPtr, IntPtr, int, int, object>..ctor
	|
	|-RVA: 0x11BC0A0 Offset: 0x11BB2A0 VA: 0x1811BC0A0
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4508F0 Offset: 0x44FAF0 VA: 0x1804508F0
	|-Action<object, IntPtr, IntPtr, int, int, object>.Invoke
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Action<T1, T2, T3, T4, T5, T6, T7> : MulticastDelegate // TypeDefIndex: 2963
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BC2D0 Offset: 0x11BB4D0 VA: 0x1811BC2D0
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF1110 Offset: 0xCF0310 VA: 0x180CF1110
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Action<T1, T2, T3, T4, T5, T6, T7, T8> : MulticastDelegate // TypeDefIndex: 2964
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BC4F0 Offset: 0x11BB6F0 VA: 0x1811BC4F0
	|-Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, object>..ctor
	|
	|-RVA: 0x11BC3E0 Offset: 0x11BB5E0 VA: 0x1811BC3E0
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF1390 Offset: 0xCF0590 VA: 0x180CF1390
	|-Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, object>.Invoke
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Func<TResult> : MulticastDelegate // TypeDefIndex: 2965
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12027A0 Offset: 0x12019A0 VA: 0x1812027A0
	|-Func<ArraySegment<byte>>..ctor
	|-Func<ValueTuple<bool, object>>..ctor
	|-Func<Color>..ctor
	|-Func<DateTimeOffset>..ctor
	|-Func<JsonElement>..ctor
	|-Func<Rect>..ctor
	|-Func<RectInt>..ctor
	|-Func<SceneInstance>..ctor
	|-Func<SerializableProjectConfiguration>..ctor
	|-Func<SocketReceiveFromResult>..ctor
	|-Func<UdpReceiveResult>..ctor
	|-Func<Vector4>..ctor
	|
	|-RVA: 0x1202B60 Offset: 0x1201D60 VA: 0x181202B60
	|-Func<KeyValuePair<int, Vector2>>..ctor
	|-Func<Vector3>..ctor
	|-Func<Vector3Int>..ctor
	|
	|-RVA: 0x1202980 Offset: 0x1201B80 VA: 0x181202980
	|-Func<Nullable<int>>..ctor
	|-Func<long>..ctor
	|-Func<IntPtr>..ctor
	|-Func<object>..ctor
	|-Func<ValueWebSocketReceiveResult>..ctor
	|-Func<Vector2Int>..ctor
	|
	|-RVA: 0x1202840 Offset: 0x1201A40 VA: 0x181202840
	|-Func<Nullable<JsonElement>>..ctor
	|-Func<ValueTuple<object, object, int>>..ctor
	|-Func<Bounds>..ctor
	|-Func<BoundsInt>..ctor
	|-Func<DownloadStatus>..ctor
	|
	|-RVA: 0x12028E0 Offset: 0x1201AE0 VA: 0x1812028E0
	|-Func<ValueTuple<object, bool, bool, object, object>>..ctor
	|-Func<SocketReceiveMessageFromResult>..ctor
	|-Func<WaitForChangedResult>..ctor
	|
	|-RVA: 0x424190 Offset: 0x423390 VA: 0x180424190
	|-Func<bool>..ctor
	|-Func<VoidTaskResult>..ctor
	|
	|-RVA: 0x4240F0 Offset: 0x4232F0 VA: 0x1804240F0
	|-Func<int>..ctor
	|-Func<Int32Enum>..ctor
	|
	|-RVA: 0x1202AC0 Offset: 0x1201CC0 VA: 0x181202AC0
	|-Func<float>..ctor
	|
	|-RVA: 0x1202A20 Offset: 0x1201C20 VA: 0x181202A20
	|-Func<Vector2>..ctor
	|
	|-RVA: 0xC3FA00 Offset: 0xC3EC00 VA: 0x180C3FA00
	|-Func<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1202730 Offset: 0x1201930 VA: 0x181202730
	|-Func<ArraySegment<byte>>.Invoke
	|-Func<ValueTuple<bool, object>>.Invoke
	|-Func<Color>.Invoke
	|-Func<DateTimeOffset>.Invoke
	|-Func<JsonElement>.Invoke
	|-Func<Rect>.Invoke
	|-Func<RectInt>.Invoke
	|-Func<SceneInstance>.Invoke
	|-Func<SerializableProjectConfiguration>.Invoke
	|-Func<SocketReceiveFromResult>.Invoke
	|-Func<UdpReceiveResult>.Invoke
	|-Func<Vector4>.Invoke
	|
	|-RVA: 0x1202760 Offset: 0x1201960 VA: 0x181202760
	|-Func<KeyValuePair<int, Vector2>>.Invoke
	|-Func<Vector3>.Invoke
	|-Func<Vector3Int>.Invoke
	|
	|-RVA: 0x4240E0 Offset: 0x4232E0 VA: 0x1804240E0
	|-Func<Nullable<int>>.Invoke
	|-Func<bool>.Invoke
	|-Func<int>.Invoke
	|-Func<Int32Enum>.Invoke
	|-Func<long>.Invoke
	|-Func<IntPtr>.Invoke
	|-Func<object>.Invoke
	|-Func<float>.Invoke
	|-Func<ValueWebSocketReceiveResult>.Invoke
	|-Func<Vector2>.Invoke
	|-Func<Vector2Int>.Invoke
	|-Func<VoidTaskResult>.Invoke
	|
	|-RVA: 0x12026B0 Offset: 0x12018B0 VA: 0x1812026B0
	|-Func<Nullable<JsonElement>>.Invoke
	|-Func<ValueTuple<object, object, int>>.Invoke
	|-Func<Bounds>.Invoke
	|-Func<BoundsInt>.Invoke
	|-Func<DownloadStatus>.Invoke
	|
	|-RVA: 0x12026F0 Offset: 0x12018F0 VA: 0x1812026F0
	|-Func<ValueTuple<object, bool, bool, object, object>>.Invoke
	|-Func<SocketReceiveMessageFromResult>.Invoke
	|-Func<WaitForChangedResult>.Invoke
	|
	|-RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250
	|-Func<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Func<T, TResult> : MulticastDelegate // TypeDefIndex: 2966
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12031F0 Offset: 0x12023F0 VA: 0x1812031F0
	|-Func<AsyncOperationHandle<object>, AsyncOperationHandle<long>>..ctor
	|-Func<AsyncOperationHandle<object>, AsyncOperationHandle<object>>..ctor
	|-Func<AsyncOperationHandle<SceneInstance>, AsyncOperationHandle<SceneInstance>>..ctor
	|
	|-RVA: 0xB86340 Offset: 0xB85540 VA: 0x180B86340
	|-Func<KeyValuePair<DiscardReasonWithCategory, int>, bool>..ctor
	|-Func<KeyValuePair<DiscardReasonWithCategory, object>, bool>..ctor
	|-Func<KeyValuePair<object, DateTimeOffset>, bool>..ctor
	|-Func<CanStartDragArgs, bool>..ctor
	|-Func<StyleSelectorPart, bool>..ctor
	|
	|-RVA: 0x1203290 Offset: 0x1202490 VA: 0x181203290
	|-Func<KeyValuePair<DiscardReasonWithCategory, int>, DataCategory>..ctor
	|-Func<KeyValuePair<DiscardReasonWithCategory, int>, DiscardReason>..ctor
	|-Func<StyleSelectorPart, object>..ctor
	|
	|-RVA: 0x1203590 Offset: 0x1202790 VA: 0x181203590
	|-Func<KeyValuePair<DiscardReasonWithCategory, object>, KeyValuePair<DiscardReasonWithCategory, int>>..ctor
	|-Func<Bounds, Bounds>..ctor
	|-Func<BoundsInt, BoundsInt>..ctor
	|
	|-RVA: 0x1203CD0 Offset: 0x1202ED0 VA: 0x181203CD0
	|-Func<KeyValuePair<DiscardReasonWithCategory, object>, DiscardReasonWithCategory>..ctor
	|
	|-RVA: 0x1203C30 Offset: 0x1202E30 VA: 0x181203C30
	|-Func<KeyValuePair<DiscardReasonWithCategory, object>, int>..ctor
	|-Func<MarkToBaseAdjustmentRecord, uint>..ctor
	|-Func<MarkToMarkAdjustmentRecord, uint>..ctor
	|-Func<StyleSelectorPart, int>..ctor
	|-Func<StyleSelectorPart, Int32Enum>..ctor
	|-Func<StyleSelectorPart, uint>..ctor
	|
	|-RVA: 0xB86200 Offset: 0xB85400 VA: 0x180B86200
	|-Func<KeyValuePair<Int32Enum, object>, bool>..ctor
	|-Func<KeyValuePair<IntPtr, object>, bool>..ctor
	|-Func<KeyValuePair<object, object>, bool>..ctor
	|-Func<ValueTuple<object, object>, bool>..ctor
	|-Func<JsonElement, bool>..ctor
	|-Func<Resolution, bool>..ctor
	|-Func<Vector4, bool>..ctor
	|-Func<QRCodeGenerator.AlignmentPattern, bool>..ctor
	|-Func<QRCodeGenerator.VersionInfo, bool>..ctor
	|-Func<QRCodeGenerator.VersionInfoDetails, bool>..ctor
	|-Func<ServerManager.PingWrapper, bool>..ctor
	|
	|-RVA: 0x1203750 Offset: 0x1202950 VA: 0x181203750
	|-Func<KeyValuePair<object, object>, KeyValuePair<object, object>>..ctor
	|-Func<Color, Color>..ctor
	|-Func<Hash128, Hash128>..ctor
	|-Func<JsonElement, SentryId>..ctor
	|-Func<Rect, Rect>..ctor
	|-Func<RectInt, RectInt>..ctor
	|-Func<Vector4, Vector4>..ctor
	|
	|-RVA: 0x12030B0 Offset: 0x12022B0 VA: 0x1812030B0
	|-Func<KeyValuePair<object, object>, int>..ctor
	|-Func<KeyValuePair<object, object>, Int32Enum>..ctor
	|-Func<KeyValuePair<object, object>, uint>..ctor
	|-Func<ValueTuple<object, object>, int>..ctor
	|-Func<ValueTuple<object, object>, Int32Enum>..ctor
	|-Func<ValueTuple<object, object>, uint>..ctor
	|-Func<Color, Color32>..ctor
	|-Func<JsonElement, int>..ctor
	|-Func<JsonElement, Int32Enum>..ctor
	|-Func<JsonElement, uint>..ctor
	|-Func<RectInt, int>..ctor
	|-Func<QRCodeGenerator.AlignmentPattern, int>..ctor
	|-Func<QRCodeGenerator.AlignmentPattern, Int32Enum>..ctor
	|-Func<QRCodeGenerator.AlignmentPattern, uint>..ctor
	|-Func<QRCodeGenerator.VersionInfo, int>..ctor
	|-Func<QRCodeGenerator.VersionInfo, Int32Enum>..ctor
	|-Func<QRCodeGenerator.VersionInfo, uint>..ctor
	|
	|-RVA: 0x1203010 Offset: 0x1202210 VA: 0x181203010
	|-Func<KeyValuePair<object, object>, object>..ctor
	|-Func<StructMultiKey<object, object>, object>..ctor
	|-Func<ValueTuple<object, object>, object>..ctor
	|-Func<ValueTuple<Int32Enum, Int32Enum, object>, object>..ctor
	|-Func<DiscardReasonWithCategory, object>..ctor
	|-Func<Guid, object>..ctor
	|-Func<JsonElement, object>..ctor
	|-Func<JsonElement, SpanId>..ctor
	|-Func<QRCodeGenerator.AlignmentPattern, object>..ctor
	|-Func<QRCodeGenerator.VersionInfo, object>..ctor
	|
	|-RVA: 0x12039D0 Offset: 0x1202BD0 VA: 0x1812039D0
	|-Func<KeyValuePair<object, object>, float>..ctor
	|-Func<ValueTuple<object, object>, float>..ctor
	|-Func<JsonElement, float>..ctor
	|-Func<Rect, float>..ctor
	|-Func<Vector4, float>..ctor
	|-Func<QRCodeGenerator.AlignmentPattern, float>..ctor
	|-Func<QRCodeGenerator.VersionInfo, float>..ctor
	|
	|-RVA: 0x1202F70 Offset: 0x1202170 VA: 0x181202F70
	|-Func<AsyncOperationHandle, AsyncOperationHandle<bool>>..ctor
	|-Func<AsyncOperationHandle, AsyncOperationHandle<long>>..ctor
	|-Func<AsyncOperationHandle, AsyncOperationHandle<object>>..ctor
	|-Func<AsyncOperationHandle, AsyncOperationHandle<SceneInstance>>..ctor
	|
	|-RVA: 0xB86700 Offset: 0xB85900 VA: 0x180B86700
	|-Func<bool, bool>..ctor
	|-Func<byte, bool>..ctor
	|-Func<ByteEnum, bool>..ctor
	|
	|-RVA: 0x12033D0 Offset: 0x12025D0 VA: 0x1812033D0
	|-Func<bool, int>..ctor
	|-Func<bool, Int32Enum>..ctor
	|-Func<bool, uint>..ctor
	|-Func<byte, int>..ctor
	|-Func<byte, Int32Enum>..ctor
	|-Func<byte, uint>..ctor
	|-Func<ByteEnum, Int32Enum>..ctor
	|
	|-RVA: 0x1203330 Offset: 0x1202530 VA: 0x181203330
	|-Func<bool, object>..ctor
	|-Func<byte, object>..ctor
	|-Func<ByteEnum, object>..ctor
	|
	|-RVA: 0x1203D70 Offset: 0x1202F70 VA: 0x181203D70
	|-Func<bool, float>..ctor
	|-Func<byte, float>..ctor
	|
	|-RVA: 0x1202ED0 Offset: 0x12020D0 VA: 0x181202ED0
	|-Func<CancellationToken, object>..ctor
	|-Func<Vector2Int, Vector2Int>..ctor
	|-Func<QRCodeGenerator.Antilog, object>..ctor
	|-Func<QRCodeGenerator.PolynomItem, object>..ctor
	|-Func<QRCodeGenerator.PolynomItem, QRCodeGenerator.PolynomItem>..ctor
	|
	|-RVA: 0xB86520 Offset: 0xB85720 VA: 0x180B86520
	|-Func<char, bool>..ctor
	|
	|-RVA: 0x1203150 Offset: 0x1202350 VA: 0x181203150
	|-Func<DiagnosticEvent, int>..ctor
	|
	|-RVA: 0x1203930 Offset: 0x1202B30 VA: 0x181203930
	|-Func<double, double>..ctor
	|-Func<float, float>..ctor
	|
	|-RVA: 0x1203E10 Offset: 0x1203010 VA: 0x181203E10
	|-Func<GlyphPairAdjustmentRecord, uint>..ctor
	|
	|-RVA: 0x1203890 Offset: 0x1202A90 VA: 0x181203890
	|-Func<HandleDragAndDropArgs, Int32Enum>..ctor
	|
	|-RVA: 0xB86660 Offset: 0xB85860 VA: 0x180B86660
	|-Func<HttpStatusCodeRange, bool>..ctor
	|-Func<QRCodeGenerator.Antilog, bool>..ctor
	|-Func<QRCodeGenerator.PolynomItem, bool>..ctor
	|
	|-RVA: 0xB865C0 Offset: 0xB857C0 VA: 0x180B865C0
	|-Func<int, bool>..ctor
	|-Func<Int32Enum, bool>..ctor
	|-Func<uint, bool>..ctor
	|
	|-RVA: 0x12037F0 Offset: 0x12029F0 VA: 0x1812037F0
	|-Func<int, int>..ctor
	|-Func<int, Int32Enum>..ctor
	|-Func<int, uint>..ctor
	|-Func<Int32Enum, int>..ctor
	|-Func<Int32Enum, Int32Enum>..ctor
	|-Func<Int32Enum, uint>..ctor
	|-Func<uint, uint>..ctor
	|
	|-RVA: 0x1203A70 Offset: 0x1202C70 VA: 0x181203A70
	|-Func<int, object>..ctor
	|-Func<Int32Enum, object>..ctor
	|
	|-RVA: 0x1202E30 Offset: 0x1202030 VA: 0x181202E30
	|-Func<int, float>..ctor
	|-Func<Int32Enum, float>..ctor
	|
	|-RVA: 0x449560 Offset: 0x448760 VA: 0x180449560
	|-Func<long, long>..ctor
	|-Func<IntPtr, object>..ctor
	|-Func<ulong, ulong>..ctor
	|
	|-RVA: 0x1203470 Offset: 0x1202670 VA: 0x181203470
	|-Func<object, ArraySegment<byte>>..ctor
	|-Func<object, Nullable<double>>..ctor
	|-Func<object, Nullable<IntPtr>>..ctor
	|-Func<object, Nullable<UIntPtr>>..ctor
	|-Func<object, ValueTuple<bool, object>>..ctor
	|-Func<object, DateTimeOffset>..ctor
	|-Func<object, Decimal>..ctor
	|-Func<object, DiscardReasonWithCategory>..ctor
	|-Func<object, Guid>..ctor
	|-Func<object, JsonElement>..ctor
	|-Func<object, SceneInstance>..ctor
	|-Func<object, SentryId>..ctor
	|-Func<object, SerializableProjectConfiguration>..ctor
	|-Func<object, SocketReceiveFromResult>..ctor
	|-Func<object, UdpReceiveResult>..ctor
	|
	|-RVA: 0x11F2F10 Offset: 0x11F2110 VA: 0x1811F2F10
	|-Func<object, Nullable<int>>..ctor
	|-Func<object, DateTime>..ctor
	|-Func<object, object>..ctor
	|-Func<object, StyleValues>..ctor
	|-Func<object, TimeSpan>..ctor
	|-Func<object, ValueWebSocketReceiveResult>..ctor
	|
	|-RVA: 0x1203630 Offset: 0x1202830 VA: 0x181203630
	|-Func<object, Nullable<JsonElement>>..ctor
	|-Func<object, ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x1203B10 Offset: 0x1202D10 VA: 0x181203B10
	|-Func<object, ValueTuple<object, bool, bool, object, object>>..ctor
	|-Func<object, SocketReceiveMessageFromResult>..ctor
	|-Func<object, WaitForChangedResult>..ctor
	|
	|-RVA: 0x1204200 Offset: 0x1203400 VA: 0x181204200
	|-Func<object, bool>..ctor
	|-Func<object, sbyte>..ctor
	|-Func<object, VoidTaskResult>..ctor
	|
	|-RVA: 0x12048A0 Offset: 0x1203AA0 VA: 0x1812048A0
	|-Func<object, byte>..ctor
	|-Func<object, ByteEnum>..ctor
	|
	|-RVA: 0x12040E0 Offset: 0x12032E0 VA: 0x1812040E0
	|-Func<object, char>..ctor
	|-Func<object, short>..ctor
	|-Func<object, ushort>..ctor
	|
	|-RVA: 0x1203FC0 Offset: 0x12031C0 VA: 0x181203FC0
	|-Func<object, double>..ctor
	|-Func<object, float>..ctor
	|
	|-RVA: 0x1205000 Offset: 0x1204200 VA: 0x181205000
	|-Func<object, int>..ctor
	|-Func<object, Int32Enum>..ctor
	|
	|-RVA: 0xB60A10 Offset: 0xB5FC10 VA: 0x180B60A10
	|-Func<object, long>..ctor
	|-Func<object, IntPtr>..ctor
	|-Func<object, ulong>..ctor
	|-Func<object, UIntPtr>..ctor
	|
	|-RVA: 0x1204320 Offset: 0x1203520 VA: 0x181204320
	|-Func<object, uint>..ctor
	|
	|-RVA: 0xB867A0 Offset: 0xB859A0 VA: 0x180B867A0
	|-Func<PidVid, bool>..ctor
	|
	|-RVA: 0x1204F60 Offset: 0x1204160 VA: 0x181204F60
	|-Func<SetupDragAndDropArgs, StartDragArgs>..ctor
	|
	|-RVA: 0xB86C80 Offset: 0xB85E80 VA: 0x180B86C80
	|-Func<float, bool>..ctor
	|
	|-RVA: 0x1204580 Offset: 0x1203780 VA: 0x181204580
	|-Func<StyleSelectorPart, float>..ctor
	|
	|-RVA: 0x1204CE0 Offset: 0x1203EE0 VA: 0x181204CE0
	|-Func<TMP_LineInfo, bool>..ctor
	|
	|-RVA: 0x12044E0 Offset: 0x12036E0 VA: 0x1812044E0
	|-Func<ushort, object>..ctor
	|
	|-RVA: 0x12046C0 Offset: 0x12038C0 VA: 0x1812046C0
	|-Func<ulong, JsonEncodedText>..ctor
	|
	|-RVA: 0xB87830 Offset: 0xB86A30 VA: 0x180B87830
	|-Func<Vector2, bool>..ctor
	|
	|-RVA: 0x1204C40 Offset: 0x1203E40 VA: 0x181204C40
	|-Func<Vector2, float>..ctor
	|
	|-RVA: 0x1204D80 Offset: 0x1203F80 VA: 0x181204D80
	|-Func<Vector2, Vector2>..ctor
	|
	|-RVA: 0x1204800 Offset: 0x1203A00 VA: 0x181204800
	|-Func<Vector2Int, int>..ctor
	|-Func<QRCodeGenerator.Antilog, int>..ctor
	|-Func<QRCodeGenerator.PolynomItem, int>..ctor
	|-Func<QRCodeGenerator.PolynomItem, Int32Enum>..ctor
	|-Func<QRCodeGenerator.PolynomItem, uint>..ctor
	|
	|-RVA: 0x1204BA0 Offset: 0x1203DA0 VA: 0x181204BA0
	|-Func<Vector3, float>..ctor
	|
	|-RVA: 0x1204440 Offset: 0x1203640 VA: 0x181204440
	|-Func<Vector3, Vector3>..ctor
	|-Func<Vector3Int, Vector3Int>..ctor
	|
	|-RVA: 0x1204E20 Offset: 0x1204020 VA: 0x181204E20
	|-Func<Vector3Int, int>..ctor
	|
	|-RVA: 0x1204A60 Offset: 0x1203C60 VA: 0x181204A60
	|-Func<Vector4, Vector2>..ctor
	|
	|-RVA: 0xB7D3D0 Offset: 0xB7C5D0 VA: 0x180B7D3D0
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0xB87650 Offset: 0xB86850 VA: 0x180B87650
	|-Func<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, bool>..ctor
	|
	|-RVA: 0x1204620 Offset: 0x1203820 VA: 0x181204620
	|-Func<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, int>..ctor
	|-Func<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, Int32Enum>..ctor
	|-Func<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, uint>..ctor
	|
	|-RVA: 0x1204B00 Offset: 0x1203D00 VA: 0x181204B00
	|-Func<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>..ctor
	|
	|-RVA: 0x1204760 Offset: 0x1203960 VA: 0x181204760
	|-Func<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, float>..ctor
	|
	|-RVA: 0xB87180 Offset: 0xB86380 VA: 0x180B87180
	|-Func<HeliSabotageSystem.ActiveConsoleData, bool>..ctor
	|-Func<MeetingHud.VoterState, bool>..ctor
	|
	|-RVA: 0xB86A00 Offset: 0xB85C00 VA: 0x180B86A00
	|-Func<QRCodeGenerator.ECCInfo, bool>..ctor
	|
	|-RVA: 0x1204EC0 Offset: 0x12040C0 VA: 0x181204EC0
	|-Func<QRCodeGenerator.PolynomItem, float>..ctor
	|
	|-RVA: 0x12049C0 Offset: 0x1203BC0 VA: 0x1812049C0
	|-Func<SpawnInMinigame.SpawnLocation, float>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1202D10 Offset: 0x1201F10 VA: 0x181202D10
	|-Func<AsyncOperationHandle<object>, AsyncOperationHandle<long>>.Invoke
	|-Func<AsyncOperationHandle<object>, AsyncOperationHandle<object>>.Invoke
	|-Func<AsyncOperationHandle<SceneInstance>, AsyncOperationHandle<SceneInstance>>.Invoke
	|
	|-RVA: 0x448CC0 Offset: 0x447EC0 VA: 0x180448CC0
	|-Func<KeyValuePair<DiscardReasonWithCategory, int>, bool>.Invoke
	|-Func<KeyValuePair<DiscardReasonWithCategory, int>, DataCategory>.Invoke
	|-Func<KeyValuePair<DiscardReasonWithCategory, int>, DiscardReason>.Invoke
	|-Func<KeyValuePair<DiscardReasonWithCategory, object>, bool>.Invoke
	|-Func<KeyValuePair<DiscardReasonWithCategory, object>, int>.Invoke
	|-Func<KeyValuePair<object, DateTimeOffset>, bool>.Invoke
	|-Func<CanStartDragArgs, bool>.Invoke
	|-Func<MarkToBaseAdjustmentRecord, uint>.Invoke
	|-Func<MarkToMarkAdjustmentRecord, uint>.Invoke
	|-Func<StyleSelectorPart, bool>.Invoke
	|-Func<StyleSelectorPart, int>.Invoke
	|-Func<StyleSelectorPart, Int32Enum>.Invoke
	|-Func<StyleSelectorPart, object>.Invoke
	|-Func<StyleSelectorPart, float>.Invoke
	|-Func<StyleSelectorPart, uint>.Invoke
	|
	|-RVA: 0x1202C70 Offset: 0x1201E70 VA: 0x181202C70
	|-Func<KeyValuePair<DiscardReasonWithCategory, object>, KeyValuePair<DiscardReasonWithCategory, int>>.Invoke
	|-Func<Bounds, Bounds>.Invoke
	|-Func<BoundsInt, BoundsInt>.Invoke
	|
	|-RVA: 0x1202DE0 Offset: 0x1201FE0 VA: 0x181202DE0
	|-Func<KeyValuePair<DiscardReasonWithCategory, object>, DiscardReasonWithCategory>.Invoke
	|
	|-RVA: 0xB85FD0 Offset: 0xB851D0 VA: 0x180B85FD0
	|-Func<KeyValuePair<Int32Enum, object>, bool>.Invoke
	|-Func<KeyValuePair<IntPtr, object>, bool>.Invoke
	|-Func<KeyValuePair<object, object>, bool>.Invoke
	|-Func<KeyValuePair<object, object>, int>.Invoke
	|-Func<KeyValuePair<object, object>, Int32Enum>.Invoke
	|-Func<KeyValuePair<object, object>, object>.Invoke
	|-Func<KeyValuePair<object, object>, float>.Invoke
	|-Func<KeyValuePair<object, object>, uint>.Invoke
	|-Func<StructMultiKey<object, object>, object>.Invoke
	|-Func<ValueTuple<object, object>, bool>.Invoke
	|-Func<ValueTuple<object, object>, int>.Invoke
	|-Func<ValueTuple<object, object>, Int32Enum>.Invoke
	|-Func<ValueTuple<object, object>, object>.Invoke
	|-Func<ValueTuple<object, object>, float>.Invoke
	|-Func<ValueTuple<object, object>, uint>.Invoke
	|-Func<ValueTuple<Int32Enum, Int32Enum, object>, object>.Invoke
	|-Func<Color, Color32>.Invoke
	|-Func<DiscardReasonWithCategory, object>.Invoke
	|-Func<Guid, object>.Invoke
	|-Func<JsonElement, bool>.Invoke
	|-Func<JsonElement, int>.Invoke
	|-Func<JsonElement, Int32Enum>.Invoke
	|-Func<JsonElement, object>.Invoke
	|-Func<JsonElement, float>.Invoke
	|-Func<JsonElement, SpanId>.Invoke
	|-Func<JsonElement, uint>.Invoke
	|-Func<Rect, float>.Invoke
	|-Func<RectInt, int>.Invoke
	|-Func<Resolution, bool>.Invoke
	|-Func<Vector4, bool>.Invoke
	|-Func<Vector4, float>.Invoke
	|-Func<Vector4, Vector2>.Invoke
	|-Func<QRCodeGenerator.AlignmentPattern, bool>.Invoke
	|-Func<QRCodeGenerator.AlignmentPattern, int>.Invoke
	|-Func<QRCodeGenerator.AlignmentPattern, Int32Enum>.Invoke
	|-Func<QRCodeGenerator.AlignmentPattern, object>.Invoke
	|-Func<QRCodeGenerator.AlignmentPattern, float>.Invoke
	|-Func<QRCodeGenerator.AlignmentPattern, uint>.Invoke
	|-Func<QRCodeGenerator.VersionInfo, bool>.Invoke
	|-Func<QRCodeGenerator.VersionInfo, int>.Invoke
	|-Func<QRCodeGenerator.VersionInfo, Int32Enum>.Invoke
	|-Func<QRCodeGenerator.VersionInfo, object>.Invoke
	|-Func<QRCodeGenerator.VersionInfo, float>.Invoke
	|-Func<QRCodeGenerator.VersionInfo, uint>.Invoke
	|-Func<QRCodeGenerator.VersionInfoDetails, bool>.Invoke
	|-Func<ServerManager.PingWrapper, bool>.Invoke
	|
	|-RVA: 0x1202C00 Offset: 0x1201E00 VA: 0x181202C00
	|-Func<KeyValuePair<object, object>, KeyValuePair<object, object>>.Invoke
	|-Func<Color, Color>.Invoke
	|-Func<Hash128, Hash128>.Invoke
	|-Func<JsonElement, SentryId>.Invoke
	|-Func<Rect, Rect>.Invoke
	|-Func<RectInt, RectInt>.Invoke
	|-Func<Vector4, Vector4>.Invoke
	|
	|-RVA: 0x1202CC0 Offset: 0x1201EC0 VA: 0x181202CC0
	|-Func<AsyncOperationHandle, AsyncOperationHandle<bool>>.Invoke
	|-Func<AsyncOperationHandle, AsyncOperationHandle<long>>.Invoke
	|-Func<AsyncOperationHandle, AsyncOperationHandle<object>>.Invoke
	|-Func<AsyncOperationHandle, AsyncOperationHandle<SceneInstance>>.Invoke
	|
	|-RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250
	|-Func<bool, bool>.Invoke
	|-Func<bool, int>.Invoke
	|-Func<bool, Int32Enum>.Invoke
	|-Func<bool, object>.Invoke
	|-Func<bool, float>.Invoke
	|-Func<bool, uint>.Invoke
	|-Func<byte, bool>.Invoke
	|-Func<byte, int>.Invoke
	|-Func<byte, Int32Enum>.Invoke
	|-Func<byte, object>.Invoke
	|-Func<byte, float>.Invoke
	|-Func<byte, uint>.Invoke
	|-Func<ByteEnum, bool>.Invoke
	|-Func<ByteEnum, Int32Enum>.Invoke
	|-Func<ByteEnum, object>.Invoke
	|-Func<CancellationToken, object>.Invoke
	|-Func<char, bool>.Invoke
	|-Func<double, double>.Invoke
	|-Func<HttpStatusCodeRange, bool>.Invoke
	|-Func<int, bool>.Invoke
	|-Func<int, int>.Invoke
	|-Func<int, Int32Enum>.Invoke
	|-Func<int, object>.Invoke
	|-Func<int, float>.Invoke
	|-Func<int, uint>.Invoke
	|-Func<Int32Enum, bool>.Invoke
	|-Func<Int32Enum, int>.Invoke
	|-Func<Int32Enum, Int32Enum>.Invoke
	|-Func<Int32Enum, object>.Invoke
	|-Func<Int32Enum, float>.Invoke
	|-Func<Int32Enum, uint>.Invoke
	|-Func<long, long>.Invoke
	|-Func<IntPtr, object>.Invoke
	|-Func<object, Nullable<int>>.Invoke
	|-Func<object, bool>.Invoke
	|-Func<object, byte>.Invoke
	|-Func<object, ByteEnum>.Invoke
	|-Func<object, char>.Invoke
	|-Func<object, DateTime>.Invoke
	|-Func<object, double>.Invoke
	|-Func<object, short>.Invoke
	|-Func<object, int>.Invoke
	|-Func<object, Int32Enum>.Invoke
	|-Func<object, long>.Invoke
	|-Func<object, IntPtr>.Invoke
	|-Func<object, object>.Invoke
	|-Func<object, sbyte>.Invoke
	|-Func<object, float>.Invoke
	|-Func<object, StyleValues>.Invoke
	|-Func<object, TimeSpan>.Invoke
	|-Func<object, ushort>.Invoke
	|-Func<object, uint>.Invoke
	|-Func<object, ulong>.Invoke
	|-Func<object, UIntPtr>.Invoke
	|-Func<object, ValueWebSocketReceiveResult>.Invoke
	|-Func<object, VoidTaskResult>.Invoke
	|-Func<PidVid, bool>.Invoke
	|-Func<float, bool>.Invoke
	|-Func<float, float>.Invoke
	|-Func<ushort, object>.Invoke
	|-Func<uint, bool>.Invoke
	|-Func<uint, uint>.Invoke
	|-Func<ulong, ulong>.Invoke
	|-Func<Vector2, bool>.Invoke
	|-Func<Vector2, float>.Invoke
	|-Func<Vector2, Vector2>.Invoke
	|-Func<Vector2Int, int>.Invoke
	|-Func<Vector2Int, Vector2Int>.Invoke
	|-Func<HeliSabotageSystem.ActiveConsoleData, bool>.Invoke
	|-Func<MeetingHud.VoterState, bool>.Invoke
	|-Func<QRCodeGenerator.Antilog, bool>.Invoke
	|-Func<QRCodeGenerator.Antilog, int>.Invoke
	|-Func<QRCodeGenerator.Antilog, object>.Invoke
	|-Func<QRCodeGenerator.PolynomItem, bool>.Invoke
	|-Func<QRCodeGenerator.PolynomItem, int>.Invoke
	|-Func<QRCodeGenerator.PolynomItem, Int32Enum>.Invoke
	|-Func<QRCodeGenerator.PolynomItem, object>.Invoke
	|-Func<QRCodeGenerator.PolynomItem, float>.Invoke
	|-Func<QRCodeGenerator.PolynomItem, uint>.Invoke
	|-Func<QRCodeGenerator.PolynomItem, QRCodeGenerator.PolynomItem>.Invoke
	|
	|-RVA: 0xB86100 Offset: 0xB85300 VA: 0x180B86100
	|-Func<DiagnosticEvent, int>.Invoke
	|-Func<SpawnInMinigame.SpawnLocation, float>.Invoke
	|
	|-RVA: 0xB86070 Offset: 0xB85270 VA: 0x180B86070
	|-Func<GlyphPairAdjustmentRecord, uint>.Invoke
	|
	|-RVA: 0xB86000 Offset: 0xB85200 VA: 0x180B86000
	|-Func<HandleDragAndDropArgs, Int32Enum>.Invoke
	|
	|-RVA: 0x1202C40 Offset: 0x1201E40 VA: 0x181202C40
	|-Func<object, ArraySegment<byte>>.Invoke
	|-Func<object, Nullable<double>>.Invoke
	|-Func<object, Nullable<IntPtr>>.Invoke
	|-Func<object, Nullable<UIntPtr>>.Invoke
	|-Func<object, ValueTuple<bool, object>>.Invoke
	|-Func<object, DateTimeOffset>.Invoke
	|-Func<object, Decimal>.Invoke
	|-Func<object, DiscardReasonWithCategory>.Invoke
	|-Func<object, Guid>.Invoke
	|-Func<object, JsonElement>.Invoke
	|-Func<object, SceneInstance>.Invoke
	|-Func<object, SentryId>.Invoke
	|-Func<object, SerializableProjectConfiguration>.Invoke
	|-Func<object, SocketReceiveFromResult>.Invoke
	|-Func<object, UdpReceiveResult>.Invoke
	|-Func<ulong, JsonEncodedText>.Invoke
	|
	|-RVA: 0x1202DA0 Offset: 0x1201FA0 VA: 0x181202DA0
	|-Func<object, Nullable<JsonElement>>.Invoke
	|-Func<object, ValueTuple<object, object, int>>.Invoke
	|
	|-RVA: 0x1202D60 Offset: 0x1201F60 VA: 0x181202D60
	|-Func<object, ValueTuple<object, bool, bool, object, object>>.Invoke
	|-Func<object, SocketReceiveMessageFromResult>.Invoke
	|-Func<object, WaitForChangedResult>.Invoke
	|
	|-RVA: 0x1203F00 Offset: 0x1203100 VA: 0x181203F00
	|-Func<SetupDragAndDropArgs, StartDragArgs>.Invoke
	|
	|-RVA: 0x1203F60 Offset: 0x1203160 VA: 0x181203F60
	|-Func<TMP_LineInfo, bool>.Invoke
	|
	|-RVA: 0xB86180 Offset: 0xB85380 VA: 0x180B86180
	|-Func<Vector3, float>.Invoke
	|-Func<Vector3Int, int>.Invoke
	|
	|-RVA: 0x1203EB0 Offset: 0x12030B0 VA: 0x181203EB0
	|-Func<Vector3, Vector3>.Invoke
	|-Func<Vector3Int, Vector3Int>.Invoke
	|
	|-RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	|
	|-RVA: 0xB86F40 Offset: 0xB86140 VA: 0x180B86F40
	|-Func<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, bool>.Invoke
	|-Func<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, int>.Invoke
	|-Func<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, Int32Enum>.Invoke
	|-Func<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, object>.Invoke
	|-Func<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, float>.Invoke
	|-Func<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv, uint>.Invoke
	|
	|-RVA: 0xB86040 Offset: 0xB85240 VA: 0x180B86040
	|-Func<QRCodeGenerator.ECCInfo, bool>.Invoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, TResult> : MulticastDelegate // TypeDefIndex: 2967
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1206340 Offset: 0x1205540 VA: 0x181206340
	|-Func<KeyValuePair<object, object>, int, object>..ctor
	|
	|-RVA: 0x1205AE0 Offset: 0x1204CE0 VA: 0x181205AE0
	|-Func<StructMultiKey<object, object>, object, object>..ctor
	|-Func<DiscardReasonWithCategory, object, object>..ctor
	|
	|-RVA: 0x12055B0 Offset: 0x12047B0 VA: 0x1812055B0
	|-Func<Background, Background, bool>..ctor
	|
	|-RVA: 0x1206800 Offset: 0x1205A00 VA: 0x181206800
	|-Func<BackgroundPosition, BackgroundPosition, bool>..ctor
	|
	|-RVA: 0x1206640 Offset: 0x1205840 VA: 0x181206640
	|-Func<BackgroundRepeat, BackgroundRepeat, bool>..ctor
	|-Func<Length, Length, bool>..ctor
	|
	|-RVA: 0x12053F0 Offset: 0x12045F0 VA: 0x1812053F0
	|-Func<BackgroundSize, BackgroundSize, bool>..ctor
	|-Func<TransformOrigin, TransformOrigin, bool>..ctor
	|
	|-RVA: 0x1206B00 Offset: 0x1205D00 VA: 0x181206B00
	|-Func<char, int, object>..ctor
	|
	|-RVA: 0x1205DE0 Offset: 0x1204FE0 VA: 0x181205DE0
	|-Func<Color, Color, bool>..ctor
	|-Func<FontDefinition, FontDefinition, bool>..ctor
	|-Func<Scale, Scale, bool>..ctor
	|
	|-RVA: 0x12062A0 Offset: 0x12054A0 VA: 0x1812062A0
	|-Func<Float2x, Float2x, Float2x>..ctor
	|
	|-RVA: 0x1205650 Offset: 0x1204850 VA: 0x181205650
	|-Func<Float3x, Float3x, Float3x>..ctor
	|
	|-RVA: 0x12063E0 Offset: 0x12055E0 VA: 0x1812063E0
	|-Func<Float4x, Float4x, Float4x>..ctor
	|
	|-RVA: 0x1205F20 Offset: 0x1205120 VA: 0x181205F20
	|-Func<int, KeyValuePair<ulong, Helper.PinnedBuffer>, int>..ctor
	|
	|-RVA: 0x1205D40 Offset: 0x1204F40 VA: 0x181205D40
	|-Func<int, int, bool>..ctor
	|
	|-RVA: 0x12069C0 Offset: 0x1205BC0 VA: 0x1812069C0
	|-Func<int, IntPtr, bool>..ctor
	|
	|-RVA: 0x1205FC0 Offset: 0x12051C0 VA: 0x181205FC0
	|-Func<int, object, object>..ctor
	|
	|-RVA: 0x1206BA0 Offset: 0x1205DA0 VA: 0x181206BA0
	|-Func<int, QRCodeGenerator.PolynomItem, int>..ctor
	|
	|-RVA: 0x12058B0 Offset: 0x1204AB0 VA: 0x1812058B0
	|-Func<object, bool, bool>..ctor
	|
	|-RVA: 0x1205790 Offset: 0x1204990 VA: 0x181205790
	|-Func<object, DateTimeOffset, DateTimeOffset>..ctor
	|-Func<object, Hash128, Hash128>..ctor
	|
	|-RVA: 0x1205B80 Offset: 0x1204D80 VA: 0x181205B80
	|-Func<object, double, double>..ctor
	|-Func<object, float, float>..ctor
	|
	|-RVA: 0x1206520 Offset: 0x1205720 VA: 0x181206520
	|-Func<object, Guid, bool>..ctor
	|
	|-RVA: 0x12068A0 Offset: 0x1205AA0 VA: 0x1812068A0
	|-Func<object, int, bool>..ctor
	|
	|-RVA: 0x1205490 Offset: 0x1204690 VA: 0x181205490
	|-Func<object, int, int>..ctor
	|-Func<object, Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0x1206180 Offset: 0x1205380 VA: 0x181206180
	|-Func<object, long, long>..ctor
	|-Func<object, object, Nullable<int>>..ctor
	|-Func<object, object, object>..ctor
	|-Func<object, ulong, ulong>..ctor
	|
	|-RVA: 0x1206060 Offset: 0x1205260 VA: 0x181206060
	|-Func<object, object, ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x12052D0 Offset: 0x12044D0 VA: 0x1812052D0
	|-Func<object, object, bool>..ctor
	|-Func<object, object, VoidTaskResult>..ctor
	|
	|-RVA: 0xF7B1F0 Offset: 0xF7A3F0 VA: 0x180F7B1F0
	|-Func<object, object, int>..ctor
	|
	|-RVA: 0x12066E0 Offset: 0x12058E0 VA: 0x1812066E0
	|-Func<object, uint, uint>..ctor
	|
	|-RVA: 0x1205E80 Offset: 0x1205080 VA: 0x181205E80
	|-Func<Rotate, Rotate, bool>..ctor
	|-Func<Translate, Translate, bool>..ctor
	|
	|-RVA: 0x1206A60 Offset: 0x1205C60 VA: 0x181206A60
	|-Func<float, float, bool>..ctor
	|
	|-RVA: 0x12056F0 Offset: 0x12048F0 VA: 0x1812056F0
	|-Func<TextShadow, TextShadow, bool>..ctor
	|
	|-RVA: 0x1206480 Offset: 0x1205680 VA: 0x181206480
	|-Func<ushort, object, object>..ctor
	|
	|-RVA: 0x1205CA0 Offset: 0x1204EA0 VA: 0x181205CA0
	|-Func<ulong, JsonEncodedText, JsonEncodedText>..ctor
	|
	|-RVA: 0x12059D0 Offset: 0x1204BD0 VA: 0x1812059D0
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4421F0 Offset: 0x4413F0 VA: 0x1804421F0
	|-Func<KeyValuePair<object, object>, int, object>.Invoke
	|-Func<StructMultiKey<object, object>, object, object>.Invoke
	|-Func<DiscardReasonWithCategory, object, object>.Invoke
	|
	|-RVA: 0xF79830 Offset: 0xF78A30 VA: 0x180F79830
	|-Func<Background, Background, bool>.Invoke
	|
	|-RVA: 0x6CAAB0 Offset: 0x6C9CB0 VA: 0x1806CAAB0
	|-Func<BackgroundPosition, BackgroundPosition, bool>.Invoke
	|
	|-RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10
	|-Func<BackgroundRepeat, BackgroundRepeat, bool>.Invoke
	|-Func<char, int, object>.Invoke
	|-Func<Float2x, Float2x, Float2x>.Invoke
	|-Func<int, int, bool>.Invoke
	|-Func<int, IntPtr, bool>.Invoke
	|-Func<int, object, object>.Invoke
	|-Func<int, QRCodeGenerator.PolynomItem, int>.Invoke
	|-Func<Length, Length, bool>.Invoke
	|-Func<object, bool, bool>.Invoke
	|-Func<object, double, double>.Invoke
	|-Func<object, int, bool>.Invoke
	|-Func<object, int, int>.Invoke
	|-Func<object, Int32Enum, Int32Enum>.Invoke
	|-Func<object, long, long>.Invoke
	|-Func<object, object, Nullable<int>>.Invoke
	|-Func<object, object, bool>.Invoke
	|-Func<object, object, int>.Invoke
	|-Func<object, object, object>.Invoke
	|-Func<object, object, VoidTaskResult>.Invoke
	|-Func<object, float, float>.Invoke
	|-Func<object, uint, uint>.Invoke
	|-Func<object, ulong, ulong>.Invoke
	|-Func<float, float, bool>.Invoke
	|-Func<ushort, object, object>.Invoke
	|
	|-RVA: 0x1205120 Offset: 0x1204320 VA: 0x181205120
	|-Func<BackgroundSize, BackgroundSize, bool>.Invoke
	|-Func<TransformOrigin, TransformOrigin, bool>.Invoke
	|
	|-RVA: 0xC31170 Offset: 0xC30370 VA: 0x180C31170
	|-Func<Color, Color, bool>.Invoke
	|-Func<FontDefinition, FontDefinition, bool>.Invoke
	|-Func<Scale, Scale, bool>.Invoke
	|
	|-RVA: 0x1205260 Offset: 0x1204460 VA: 0x181205260
	|-Func<Float3x, Float3x, Float3x>.Invoke
	|
	|-RVA: 0x12051B0 Offset: 0x12043B0 VA: 0x1812051B0
	|-Func<Float4x, Float4x, Float4x>.Invoke
	|
	|-RVA: 0x448B50 Offset: 0x447D50 VA: 0x180448B50
	|-Func<int, KeyValuePair<ulong, Helper.PinnedBuffer>, int>.Invoke
	|
	|-RVA: 0x1205170 Offset: 0x1204370 VA: 0x181205170
	|-Func<object, DateTimeOffset, DateTimeOffset>.Invoke
	|-Func<object, Hash128, Hash128>.Invoke
	|-Func<ulong, JsonEncodedText, JsonEncodedText>.Invoke
	|
	|-RVA: 0x44A010 Offset: 0x449210 VA: 0x18044A010
	|-Func<object, Guid, bool>.Invoke
	|
	|-RVA: 0x449CE0 Offset: 0x448EE0 VA: 0x180449CE0
	|-Func<object, object, ValueTuple<object, object>>.Invoke
	|
	|-RVA: 0xF79960 Offset: 0xF78B60 VA: 0x180F79960
	|-Func<Rotate, Rotate, bool>.Invoke
	|-Func<Translate, Translate, bool>.Invoke
	|
	|-RVA: 0x1205200 Offset: 0x1204400 VA: 0x181205200
	|-Func<TextShadow, TextShadow, bool>.Invoke
	|
	|-RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, T3, TResult> : MulticastDelegate // TypeDefIndex: 2968
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12070A0 Offset: 0x12062A0 VA: 0x1812070A0
	|-Func<ArraySegment<byte>, object, object, object>..ctor
	|
	|-RVA: 0x12072F0 Offset: 0x12064F0 VA: 0x1812072F0
	|-Func<object, object, bool, object>..ctor
	|
	|-RVA: 0x1206EE0 Offset: 0x12060E0 VA: 0x181206EE0
	|-Func<object, object, object, object>..ctor
	|
	|-RVA: 0x12074B0 Offset: 0x12066B0 VA: 0x1812074B0
	|-Func<StyleValues, StyleValues, float, StyleValues>..ctor
	|
	|-RVA: 0x1206E40 Offset: 0x1206040 VA: 0x181206E40
	|-Func<Vector3, Vector3, ValueTuple<Int32Enum, Vector2>, object>..ctor
	|-Func<Vector3, Vector3, ValueTuple<int, int, Int32Enum>, object>..ctor
	|
	|-RVA: 0x1207000 Offset: 0x1206200 VA: 0x181207000
	|-Func<Vector3, Vector3, object, object>..ctor
	|
	|-RVA: 0x1207140 Offset: 0x1206340 VA: 0x181207140
	|-Func<Vector3, Vector3, PenData, object>..ctor
	|
	|-RVA: 0x1207410 Offset: 0x1206610 VA: 0x181207410
	|-Func<Vector3, Vector3, Touch, object>..ctor
	|
	|-RVA: 0x12071E0 Offset: 0x12063E0 VA: 0x1812071E0
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1206E10 Offset: 0x1206010 VA: 0x181206E10
	|-Func<ArraySegment<byte>, object, object, object>.Invoke
	|
	|-RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0
	|-Func<object, object, bool, object>.Invoke
	|-Func<object, object, object, object>.Invoke
	|
	|-RVA: 0x11BB3D0 Offset: 0x11BA5D0 VA: 0x1811BB3D0
	|-Func<StyleValues, StyleValues, float, StyleValues>.Invoke
	|
	|-RVA: 0x1206C40 Offset: 0x1205E40 VA: 0x181206C40
	|-Func<Vector3, Vector3, ValueTuple<Int32Enum, Vector2>, object>.Invoke
	|-Func<Vector3, Vector3, ValueTuple<int, int, Int32Enum>, object>.Invoke
	|
	|-RVA: 0x1206CB0 Offset: 0x1205EB0 VA: 0x181206CB0
	|-Func<Vector3, Vector3, object, object>.Invoke
	|
	|-RVA: 0x1206D00 Offset: 0x1205F00 VA: 0x181206D00
	|-Func<Vector3, Vector3, PenData, object>.Invoke
	|
	|-RVA: 0x1206D80 Offset: 0x1205F80 VA: 0x181206D80
	|-Func<Vector3, Vector3, Touch, object>.Invoke
	|
	|-RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, T3, T4, TResult> : MulticastDelegate // TypeDefIndex: 2969
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1207590 Offset: 0x1206790 VA: 0x181207590
	|-Func<ArraySegment<byte>, Int32Enum, object, object, object>..ctor
	|
	|-RVA: 0x1207750 Offset: 0x1206950 VA: 0x181207750
	|-Func<object, int, object, object, object>..ctor
	|-Func<object, Int32Enum, object, object, object>..ctor
	|
	|-RVA: 0x1207630 Offset: 0x1206830 VA: 0x181207630
	|-Func<object, object, bool, object, object>..ctor
	|
	|-RVA: 0x1207990 Offset: 0x1206B90 VA: 0x181207990
	|-Func<object, object, object, object, object>..ctor
	|
	|-RVA: 0x1207870 Offset: 0x1206A70 VA: 0x181207870
	|-Func<object, Stream.ReadWriteParameters, object, object, object>..ctor
	|
	|-RVA: 0xB7D4E0 Offset: 0xB7C6E0 VA: 0x180B7D4E0
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1207550 Offset: 0x1206750 VA: 0x181207550
	|-Func<ArraySegment<byte>, Int32Enum, object, object, object>.Invoke
	|
	|-RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0
	|-Func<object, int, object, object, object>.Invoke
	|-Func<object, Int32Enum, object, object, object>.Invoke
	|-Func<object, object, bool, object, object>.Invoke
	|-Func<object, object, object, object, object>.Invoke
	|
	|-RVA: 0x46FBA0 Offset: 0x46EDA0 VA: 0x18046FBA0
	|-Func<object, Stream.ReadWriteParameters, object, object, object>.Invoke
	|
	|-RVA: 0x449250 Offset: 0x448450 VA: 0x180449250
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, T3, T4, T5, TResult> : MulticastDelegate // TypeDefIndex: 2970
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1207B00 Offset: 0x1206D00 VA: 0x181207B00
	|-Func<ArraySegment<byte>, Int32Enum, object, object, object, object>..ctor
	|
	|-RVA: 0x1207BA0 Offset: 0x1206DA0 VA: 0x181207BA0
	|-Func<object, int, object, object, object, object>..ctor
	|
	|-RVA: 0x1207CC0 Offset: 0x1206EC0 VA: 0x181207CC0
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1207AB0 Offset: 0x1206CB0 VA: 0x181207AB0
	|-Func<ArraySegment<byte>, Int32Enum, object, object, object, object>.Invoke
	|
	|-RVA: 0x449250 Offset: 0x448450 VA: 0x180449250
	|-Func<object, int, object, object, object, object>.Invoke
	|
	|-RVA: 0x4508F0 Offset: 0x44FAF0 VA: 0x1804508F0
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, T3, T4, T5, T6, TResult> : MulticastDelegate // TypeDefIndex: 2971
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1207DD0 Offset: 0x1206FD0 VA: 0x181207DD0
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF1110 Offset: 0xCF0310 VA: 0x180CF1110
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, T3, T4, T5, T6, T7, TResult> : MulticastDelegate // TypeDefIndex: 2972
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1207EE0 Offset: 0x12070E0 VA: 0x181207EE0
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF1390 Offset: 0xCF0590 VA: 0x180CF1390
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> : MulticastDelegate // TypeDefIndex: 2973
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1207FF0 Offset: 0x12071F0 VA: 0x181207FF0
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF1630 Offset: 0xCF0830 VA: 0x180CF1630
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Comparison<T> : MulticastDelegate // TypeDefIndex: 2974
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF79B90 Offset: 0xF78D90 VA: 0x180F79B90
	|-Comparison<ArraySegment<byte>>..ctor
	|-Comparison<KeyValuePair<int, object>>..ctor
	|-Comparison<KeyValuePair<object, char>>..ctor
	|-Comparison<KeyValuePair<object, object>>..ctor
	|-Comparison<KeyValuePair<object, ulong>>..ctor
	|-Comparison<KeyValuePair<PropertyName, object>>..ctor
	|-Comparison<NativeArray<ConvertMeshJobData>>..ctor
	|-Comparison<NativeArray<CopyClosingMeshJobData>>..ctor
	|-Comparison<NativeArray<NudgeJobData>>..ctor
	|-Comparison<NativeSlice<ConvertMeshJobData>>..ctor
	|-Comparison<NativeSlice<CopyClosingMeshJobData>>..ctor
	|-Comparison<NativeSlice<NudgeJobData>>..ctor
	|-Comparison<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>..ctor
	|-Comparison<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>..ctor
	|-Comparison<StructMultiKey<object, object>>..ctor
	|-Comparison<ValueTuple<object, object>>..ctor
	|-Comparison<Color>..ctor
	|-Comparison<ControllerTemplateElementTarget>..ctor
	|-Comparison<DateTimeOffset>..ctor
	|-Comparison<Decimal>..ctor
	|-Comparison<DetectiveSuspect>..ctor
	|-Comparison<DiscardReasonWithCategory>..ctor
	|-Comparison<GlyphRect>..ctor
	|-Comparison<Guid>..ctor
	|-Comparison<IngestData>..ctor
	|-Comparison<InterpretedFrameInfo>..ctor
	|-Comparison<JsonElement>..ctor
	|-Comparison<JsonEncodedText>..ctor
	|-Comparison<LigatureSubstitutionRecord>..ctor
	|-Comparison<MultipleSubstitutionRecord>..ctor
	|-Comparison<RangePositionInfo>..ctor
	|-Comparison<Rect>..ctor
	|-Comparison<Resolution>..ctor
	|-Comparison<RuleMatcher>..ctor
	|-Comparison<RulesCategory>..ctor
	|-Comparison<SslApplicationProtocol>..ctor
	|-Comparison<StylePropertyName>..ctor
	|-Comparison<StylePropertyValue>..ctor
	|-Comparison<StyleValueManaged>..ctor
	|-Comparison<SubString>..ctor
	|-Comparison<UILineInfo>..ctor
	|-Comparison<Vector4>..ctor
	|-Comparison<VertexAttributeDescriptor>..ctor
	|-Comparison<X509ChainStatus>..ctor
	|-Comparison<XSXSubmitGraphicsCommandsDataCommandInternal>..ctor
	|-Comparison<XboxOneGDKSubmitGraphicsCommandsDataCommandInternal>..ctor
	|-Comparison<AchievementManager.AchievementProgressValue>..ctor
	|-Comparison<BeforeRenderHelper.OrderBlock>..ctor
	|-Comparison<CreditsController.CreditStruct>..ctor
	|-Comparison<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.YkJYhIwKoTBpWKATiflrEgjLfZIX>..ctor
	|-Comparison<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.fcJeYwLvuogcmgGamTgYErdESsqW>..ctor
	|-Comparison<FocusController.FocusedElement>..ctor
	|-Comparison<HardwareControllerTemplateMap.rwEetQoHfXcCclqvIDEVKbecRXpDb>..ctor
	|-Comparison<MultiColumnCollectionHeader.SortedColumnState>..ctor
	|-Comparison<PZVoNXqAhLHAMSWUdEitcRuLGMcmA.LxbGihMOwQSEjsHzfBQtamHgcTraA>..ctor
	|-Comparison<PackedPlayModeBuildLogs.RuntimeBuildLog>..ctor
	|-Comparison<QRCodeGenerator.AlignmentPattern>..ctor
	|-Comparison<QRCodeGenerator.VersionInfo>..ctor
	|-Comparison<QRCodeGenerator.VersionInfoDetails>..ctor
	|-Comparison<ResourceManager.DeferredCallbackRegisterRequest>..ctor
	|-Comparison<ServerManager.PingWrapper>..ctor
	|-Comparison<TextSettings.FontReferenceMap>..ctor
	|-Comparison<TextureRegistry.TextureInfo>..ctor
	|-Comparison<VisualTreeAsset.SlotDefinition>..ctor
	|-Comparison<VisualTreeAsset.SlotUsageEntry>..ctor
	|-Comparison<VisualTreeAsset.UxmlObjectEntry>..ctor
	|-Comparison<XjXmgYEoXluUbKoyNCodoxJzPrjJ.FSjxKnkodQibKwPtFNBnKKATQeux>..ctor
	|-Comparison<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|
	|-RVA: 0xF79E10 Offset: 0xF79010 VA: 0x180F79E10
	|-Comparison<KeyValuePair<byte, int>>..ctor
	|-Comparison<ValueTuple<int, int>>..ctor
	|-Comparison<AnimatorClipInfo>..ctor
	|-Comparison<CancellationToken>..ctor
	|-Comparison<DateTime>..ctor
	|-Comparison<Edge>..ctor
	|-Comparison<HttpStatusCodeRange>..ctor
	|-Comparison<TimeSpan>..ctor
	|-Comparison<TimeValue>..ctor
	|-Comparison<BitmapAllocator32.Page>..ctor
	|-Comparison<DtlsUnityConnection.FragmentRange>..ctor
	|-Comparison<QRCodeGenerator.Antilog>..ctor
	|-Comparison<QRCodeGenerator.PolynomItem>..ctor
	|-Comparison<SecurityLogBehaviour.SecurityLogEntry>..ctor
	|-Comparison<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>..ctor
	|
	|-RVA: 0xF79D70 Offset: 0xF78F70 VA: 0x180F79D70
	|-Comparison<KeyValuePair<DiscardReasonWithCategory, int>>..ctor
	|-Comparison<KeyValuePair<DiscardReasonWithCategory, object>>..ctor
	|-Comparison<KeyValuePair<Rect, object>>..ctor
	|-Comparison<TempAllocator.Page<ushort>>..ctor
	|-Comparison<TempAllocator.Page<Vertex>>..ctor
	|-Comparison<AsyncOperationHandle>..ctor
	|-Comparison<ComputedTransitionProperty>..ctor
	|-Comparison<DataRecordInternal>..ctor
	|-Comparison<DebugLogMessage>..ctor
	|-Comparison<Entitlement>..ctor
	|-Comparison<FileStat>..ctor
	|-Comparison<InputActionSourceData>..ctor
	|-Comparison<ItemOwnershipInternal>..ctor
	|-Comparison<JsonPosition>..ctor
	|-Comparison<MarkToBaseAdjustmentRecord>..ctor
	|-Comparison<MarkToMarkAdjustmentRecord>..ctor
	|-Comparison<OptionInternal>..ctor
	|-Comparison<ParameterRef>..ctor
	|-Comparison<ParticipantMetadataInternal>..ctor
	|-Comparison<PlayerStatInfoInternal>..ctor
	|-Comparison<PropertyRef>..ctor
	|-Comparison<SandboxIdItemOwnershipInternal>..ctor
	|-Comparison<SelectorMatchRecord>..ctor
	|-Comparison<StatThresholdsInternal>..ctor
	|-Comparison<StyleSelectorPart>..ctor
	|-Comparison<StyleSyntaxToken>..ctor
	|-Comparison<StyleValue>..ctor
	|-Comparison<StyleVariable>..ctor
	|-Comparison<TreeViewItemWrapper>..ctor
	|-Comparison<Camera.RenderRequest>..ctor
	|-Comparison<CreditsController.FormatStruct>..ctor
	|-Comparison<TemplateAsset.AttributeOverride>..ctor
	|-Comparison<UnitySynchronizationContext.WorkRequest>..ctor
	|-Comparison<UnityUITextMeshProGlyphHelper.GlyphOrText>..ctor
	|-Comparison<VisualTreeAsset.UsingEntry>..ctor
	|
	|-RVA: 0xF7A090 Offset: 0xF79290 VA: 0x180F7A090
	|-Comparison<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>..ctor
	|-Comparison<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>..ctor
	|-Comparison<BoneWeight>..ctor
	|-Comparison<TypeWrapper>..ctor
	|-Comparison<DelayedActionManager.DelegateInfo>..ctor
	|-Comparison<QRCodeGenerator.ECCInfo>..ctor
	|-Comparison<UIRStylePainter.RepeatRectUV>..ctor
	|-Comparison<VisualTreeAsset.AssetEntry>..ctor
	|-Comparison<InstructionList.DebugView.InstructionView>..ctor
	|-Comparison<MultiColumnCollectionHeader.ViewState.ColumnState>..ctor
	|
	|-RVA: 0xF7A270 Offset: 0xF79470 VA: 0x180F7A270
	|-Comparison<SequenceBuffer.SequencedData<VentilationSystem.VentMoveInfo, VentilationSystem.VentMoveInfo>>..ctor
	|-Comparison<ManipulatorActivationFilter>..ctor
	|-Comparison<UICharInfo>..ctor
	|-Comparison<Vector3>..ctor
	|-Comparison<Vector3Int>..ctor
	|-Comparison<CustomController.CZxNqDPSLSmjvjcEzpoKeadUPlaM>..ctor
	|-Comparison<PlayerController.Element.TBnjpqFyveWLFptREPetgdFmwyCWA>..ctor
	|
	|-RVA: 0xF79FF0 Offset: 0xF791F0 VA: 0x180F79FF0
	|-Comparison<Announcement>..ctor
	|-Comparison<Matrix4x4>..ctor
	|-Comparison<TexturePacker_JsonArray.Frame>..ctor
	|
	|-RVA: 0xF79F50 Offset: 0xF79150 VA: 0x180F79F50
	|-Comparison<bool>..ctor
	|-Comparison<byte>..ctor
	|-Comparison<ByteEnum>..ctor
	|-Comparison<sbyte>..ctor
	|
	|-RVA: 0xF79CD0 Offset: 0xF78ED0 VA: 0x180F79CD0
	|-Comparison<char>..ctor
	|-Comparison<short>..ctor
	|-Comparison<ushort>..ctor
	|-Comparison<UInt16Enum>..ctor
	|
	|-RVA: 0xF7A1D0 Offset: 0xF793D0 VA: 0x180F7A1D0
	|-Comparison<Color32>..ctor
	|-Comparison<EasingFunction>..ctor
	|-Comparison<RegexCharClass.SingleRange>..ctor
	|
	|-RVA: 0xF7A310 Offset: 0xF79510 VA: 0x180F7A310
	|-Comparison<ContactPoint2D>..ctor
	|-Comparison<ControllerPollingInfo>..ctor
	|-Comparison<ExternalAccountInfo>..ctor
	|-Comparison<TextureBlitter.BlitInfo>..ctor
	|
	|-RVA: 0xF7A450 Offset: 0xF79650 VA: 0x180F7A450
	|-Comparison<DiagnosticEvent>..ctor
	|-Comparison<ModIdentifierInternal>..ctor
	|-Comparison<ObjectInitializationData>..ctor
	|-Comparison<Relationship>..ctor
	|-Comparison<SubMeshDescriptor>..ctor
	|-Comparison<QRCodeGenerator.CodewordBlock>..ctor
	|
	|-RVA: 0xF79EB0 Offset: 0xF790B0 VA: 0x180F79EB0
	|-Comparison<double>..ctor
	|-Comparison<float>..ctor
	|
	|-RVA: 0xF7A3B0 Offset: 0xF795B0 VA: 0x180F7A3B0
	|-Comparison<ElementAssignmentConflictInfo>..ctor
	|-Comparison<GlyphPairAdjustmentRecord>..ctor
	|-Comparison<RaycastHit>..ctor
	|
	|-RVA: 0xF7A130 Offset: 0xF79330 VA: 0x180F7A130
	|-Comparison<Entitlement>..ctor
	|-Comparison<PhysicsShape2D>..ctor
	|-Comparison<PlayerLoopSystem>..ctor
	|-Comparison<PlayerLoopSystemInternal>..ctor
	|-Comparison<Sku>..ctor
	|-Comparison<User>..ctor
	|-Comparison<UIRenderDevice.AllocToFree>..ctor
	|
	|-RVA: 0xF79C30 Offset: 0xF78E30 VA: 0x180F79C30
	|-Comparison<GameListing>..ctor
	|-Comparison<RaycastResult>..ctor
	|-Comparison<WriteStackFrame>..ctor
	|-Comparison<UIRStylePainter.Entry>..ctor
	|-Comparison<UIRenderDevice.AllocToUpdate>..ctor
	|
	|-RVA: 0xF7A4F0 Offset: 0xF796F0 VA: 0x180F7A4F0
	|-Comparison<int>..ctor
	|-Comparison<Int32Enum>..ctor
	|-Comparison<uint>..ctor
	|
	|-RVA: 0x445BB0 Offset: 0x444DB0 VA: 0x180445BB0
	|-Comparison<long>..ctor
	|-Comparison<ulong>..ctor
	|
	|-RVA: 0xF7B1F0 Offset: 0xF7A3F0 VA: 0x180F7B1F0
	|-Comparison<object>..ctor
	|
	|-RVA: 0xF7B0B0 Offset: 0xF7A2B0 VA: 0x180F7B0B0
	|-Comparison<RaycastHit2D>..ctor
	|
	|-RVA: 0xF7B450 Offset: 0xF7A650 VA: 0x180F7B450
	|-Comparison<ReadStackFrame>..ctor
	|
	|-RVA: 0xF7AE60 Offset: 0xF7A060 VA: 0x180F7AE60
	|-Comparison<UIVertex>..ctor
	|
	|-RVA: 0xF7AD20 Offset: 0xF79F20 VA: 0x180F7AD20
	|-Comparison<Vector2>..ctor
	|
	|-RVA: 0xF7AF00 Offset: 0xF7A100 VA: 0x180F7AF00
	|-Comparison<Win32_IP_ADAPTER_ADDRESSES>..ctor
	|
	|-RVA: 0xF7B150 Offset: 0xF7A350 VA: 0x180F7B150
	|-Comparison<Win32_IP_ADAPTER_INFO>..ctor
	|
	|-RVA: 0xF7AFA0 Offset: 0xF7A1A0 VA: 0x180F7AFA0
	|-Comparison<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0xF7B4F0 Offset: 0xF7A6F0 VA: 0x180F7B4F0
	|-Comparison<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>..ctor
	|
	|-RVA: 0xF7B310 Offset: 0xF7A510 VA: 0x180F7B310
	|-Comparison<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0xF7ADC0 Offset: 0xF79FC0 VA: 0x180F7ADC0
	|-Comparison<RadialMenu.CachedButtonObject>..ctor
	|
	|-RVA: 0xF7B3B0 Offset: 0xF7A5B0 VA: 0x180F7B3B0
	|-Comparison<RenderChain.RenderNodeData>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual int Invoke(T x, T y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC31170 Offset: 0xC30370 VA: 0x180C31170
	|-Comparison<ArraySegment<byte>>.Invoke
	|-Comparison<KeyValuePair<int, object>>.Invoke
	|-Comparison<KeyValuePair<object, char>>.Invoke
	|-Comparison<KeyValuePair<object, object>>.Invoke
	|-Comparison<KeyValuePair<object, ulong>>.Invoke
	|-Comparison<KeyValuePair<PropertyName, object>>.Invoke
	|-Comparison<NativeArray<ConvertMeshJobData>>.Invoke
	|-Comparison<NativeArray<CopyClosingMeshJobData>>.Invoke
	|-Comparison<NativeArray<NudgeJobData>>.Invoke
	|-Comparison<NativeSlice<ConvertMeshJobData>>.Invoke
	|-Comparison<NativeSlice<CopyClosingMeshJobData>>.Invoke
	|-Comparison<NativeSlice<NudgeJobData>>.Invoke
	|-Comparison<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.Invoke
	|-Comparison<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.Invoke
	|-Comparison<StructMultiKey<object, object>>.Invoke
	|-Comparison<ValueTuple<object, object>>.Invoke
	|-Comparison<Color>.Invoke
	|-Comparison<ControllerTemplateElementTarget>.Invoke
	|-Comparison<DateTimeOffset>.Invoke
	|-Comparison<Decimal>.Invoke
	|-Comparison<DetectiveSuspect>.Invoke
	|-Comparison<DiscardReasonWithCategory>.Invoke
	|-Comparison<GlyphRect>.Invoke
	|-Comparison<Guid>.Invoke
	|-Comparison<IngestData>.Invoke
	|-Comparison<InterpretedFrameInfo>.Invoke
	|-Comparison<JsonElement>.Invoke
	|-Comparison<JsonEncodedText>.Invoke
	|-Comparison<LigatureSubstitutionRecord>.Invoke
	|-Comparison<MultipleSubstitutionRecord>.Invoke
	|-Comparison<RangePositionInfo>.Invoke
	|-Comparison<Rect>.Invoke
	|-Comparison<Resolution>.Invoke
	|-Comparison<RuleMatcher>.Invoke
	|-Comparison<RulesCategory>.Invoke
	|-Comparison<SslApplicationProtocol>.Invoke
	|-Comparison<StylePropertyName>.Invoke
	|-Comparison<StylePropertyValue>.Invoke
	|-Comparison<StyleValueManaged>.Invoke
	|-Comparison<SubString>.Invoke
	|-Comparison<UILineInfo>.Invoke
	|-Comparison<Vector4>.Invoke
	|-Comparison<VertexAttributeDescriptor>.Invoke
	|-Comparison<X509ChainStatus>.Invoke
	|-Comparison<XSXSubmitGraphicsCommandsDataCommandInternal>.Invoke
	|-Comparison<XboxOneGDKSubmitGraphicsCommandsDataCommandInternal>.Invoke
	|-Comparison<AchievementManager.AchievementProgressValue>.Invoke
	|-Comparison<BeforeRenderHelper.OrderBlock>.Invoke
	|-Comparison<CreditsController.CreditStruct>.Invoke
	|-Comparison<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.YkJYhIwKoTBpWKATiflrEgjLfZIX>.Invoke
	|-Comparison<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.fcJeYwLvuogcmgGamTgYErdESsqW>.Invoke
	|-Comparison<FocusController.FocusedElement>.Invoke
	|-Comparison<HardwareControllerTemplateMap.rwEetQoHfXcCclqvIDEVKbecRXpDb>.Invoke
	|-Comparison<MultiColumnCollectionHeader.SortedColumnState>.Invoke
	|-Comparison<PZVoNXqAhLHAMSWUdEitcRuLGMcmA.LxbGihMOwQSEjsHzfBQtamHgcTraA>.Invoke
	|-Comparison<PackedPlayModeBuildLogs.RuntimeBuildLog>.Invoke
	|-Comparison<QRCodeGenerator.AlignmentPattern>.Invoke
	|-Comparison<QRCodeGenerator.VersionInfo>.Invoke
	|-Comparison<QRCodeGenerator.VersionInfoDetails>.Invoke
	|-Comparison<ResourceManager.DeferredCallbackRegisterRequest>.Invoke
	|-Comparison<ServerManager.PingWrapper>.Invoke
	|-Comparison<TextSettings.FontReferenceMap>.Invoke
	|-Comparison<TextureRegistry.TextureInfo>.Invoke
	|-Comparison<VisualTreeAsset.SlotDefinition>.Invoke
	|-Comparison<VisualTreeAsset.SlotUsageEntry>.Invoke
	|-Comparison<VisualTreeAsset.UxmlObjectEntry>.Invoke
	|-Comparison<XjXmgYEoXluUbKoyNCodoxJzPrjJ.FSjxKnkodQibKwPtFNBnKKATQeux>.Invoke
	|-Comparison<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Invoke
	|
	|-RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10
	|-Comparison<KeyValuePair<byte, int>>.Invoke
	|-Comparison<ValueTuple<int, int>>.Invoke
	|-Comparison<AnimatorClipInfo>.Invoke
	|-Comparison<bool>.Invoke
	|-Comparison<byte>.Invoke
	|-Comparison<ByteEnum>.Invoke
	|-Comparison<CancellationToken>.Invoke
	|-Comparison<char>.Invoke
	|-Comparison<Color32>.Invoke
	|-Comparison<DateTime>.Invoke
	|-Comparison<double>.Invoke
	|-Comparison<EasingFunction>.Invoke
	|-Comparison<Edge>.Invoke
	|-Comparison<HttpStatusCodeRange>.Invoke
	|-Comparison<short>.Invoke
	|-Comparison<int>.Invoke
	|-Comparison<Int32Enum>.Invoke
	|-Comparison<long>.Invoke
	|-Comparison<object>.Invoke
	|-Comparison<sbyte>.Invoke
	|-Comparison<float>.Invoke
	|-Comparison<TimeSpan>.Invoke
	|-Comparison<TimeValue>.Invoke
	|-Comparison<ushort>.Invoke
	|-Comparison<UInt16Enum>.Invoke
	|-Comparison<uint>.Invoke
	|-Comparison<ulong>.Invoke
	|-Comparison<Vector2>.Invoke
	|-Comparison<__Il2CppFullySharedGenericType>.Invoke
	|-Comparison<BitmapAllocator32.Page>.Invoke
	|-Comparison<DtlsUnityConnection.FragmentRange>.Invoke
	|-Comparison<QRCodeGenerator.Antilog>.Invoke
	|-Comparison<QRCodeGenerator.PolynomItem>.Invoke
	|-Comparison<RegexCharClass.SingleRange>.Invoke
	|-Comparison<SecurityLogBehaviour.SecurityLogEntry>.Invoke
	|-Comparison<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.Invoke
	|
	|-RVA: 0xF79960 Offset: 0xF78B60 VA: 0x180F79960
	|-Comparison<KeyValuePair<DiscardReasonWithCategory, int>>.Invoke
	|-Comparison<KeyValuePair<DiscardReasonWithCategory, object>>.Invoke
	|-Comparison<KeyValuePair<Rect, object>>.Invoke
	|-Comparison<TempAllocator.Page<ushort>>.Invoke
	|-Comparison<TempAllocator.Page<Vertex>>.Invoke
	|-Comparison<AsyncOperationHandle>.Invoke
	|-Comparison<ComputedTransitionProperty>.Invoke
	|-Comparison<DataRecordInternal>.Invoke
	|-Comparison<DebugLogMessage>.Invoke
	|-Comparison<Entitlement>.Invoke
	|-Comparison<FileStat>.Invoke
	|-Comparison<InputActionSourceData>.Invoke
	|-Comparison<ItemOwnershipInternal>.Invoke
	|-Comparison<JsonPosition>.Invoke
	|-Comparison<MarkToBaseAdjustmentRecord>.Invoke
	|-Comparison<MarkToMarkAdjustmentRecord>.Invoke
	|-Comparison<OptionInternal>.Invoke
	|-Comparison<ParameterRef>.Invoke
	|-Comparison<ParticipantMetadataInternal>.Invoke
	|-Comparison<PlayerStatInfoInternal>.Invoke
	|-Comparison<PropertyRef>.Invoke
	|-Comparison<SandboxIdItemOwnershipInternal>.Invoke
	|-Comparison<SelectorMatchRecord>.Invoke
	|-Comparison<StatThresholdsInternal>.Invoke
	|-Comparison<StyleSelectorPart>.Invoke
	|-Comparison<StyleSyntaxToken>.Invoke
	|-Comparison<StyleValue>.Invoke
	|-Comparison<StyleVariable>.Invoke
	|-Comparison<TreeViewItemWrapper>.Invoke
	|-Comparison<Camera.RenderRequest>.Invoke
	|-Comparison<CreditsController.FormatStruct>.Invoke
	|-Comparison<TemplateAsset.AttributeOverride>.Invoke
	|-Comparison<UnitySynchronizationContext.WorkRequest>.Invoke
	|-Comparison<UnityUITextMeshProGlyphHelper.GlyphOrText>.Invoke
	|-Comparison<VisualTreeAsset.UsingEntry>.Invoke
	|
	|-RVA: 0xF79830 Offset: 0xF78A30 VA: 0x180F79830
	|-Comparison<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.Invoke
	|-Comparison<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.Invoke
	|-Comparison<BoneWeight>.Invoke
	|-Comparison<TypeWrapper>.Invoke
	|-Comparison<DelayedActionManager.DelegateInfo>.Invoke
	|-Comparison<QRCodeGenerator.ECCInfo>.Invoke
	|-Comparison<UIRStylePainter.RepeatRectUV>.Invoke
	|-Comparison<VisualTreeAsset.AssetEntry>.Invoke
	|-Comparison<InstructionList.DebugView.InstructionView>.Invoke
	|-Comparison<MultiColumnCollectionHeader.ViewState.ColumnState>.Invoke
	|
	|-RVA: 0x6CAAB0 Offset: 0x6C9CB0 VA: 0x1806CAAB0
	|-Comparison<SequenceBuffer.SequencedData<VentilationSystem.VentMoveInfo, VentilationSystem.VentMoveInfo>>.Invoke
	|-Comparison<ManipulatorActivationFilter>.Invoke
	|-Comparison<UICharInfo>.Invoke
	|-Comparison<Vector3>.Invoke
	|-Comparison<Vector3Int>.Invoke
	|-Comparison<CustomController.CZxNqDPSLSmjvjcEzpoKeadUPlaM>.Invoke
	|-Comparison<PlayerController.Element.TBnjpqFyveWLFptREPetgdFmwyCWA>.Invoke
	|
	|-RVA: 0xF79A30 Offset: 0xF78C30 VA: 0x180F79A30
	|-Comparison<Announcement>.Invoke
	|-Comparison<Matrix4x4>.Invoke
	|-Comparison<TexturePacker_JsonArray.Frame>.Invoke
	|
	|-RVA: 0xF799B0 Offset: 0xF78BB0 VA: 0x180F799B0
	|-Comparison<ContactPoint2D>.Invoke
	|-Comparison<ControllerPollingInfo>.Invoke
	|-Comparison<ExternalAccountInfo>.Invoke
	|-Comparison<TextureBlitter.BlitInfo>.Invoke
	|
	|-RVA: 0xF79880 Offset: 0xF78A80 VA: 0x180F79880
	|-Comparison<DiagnosticEvent>.Invoke
	|-Comparison<ModIdentifierInternal>.Invoke
	|-Comparison<ObjectInitializationData>.Invoke
	|-Comparison<Relationship>.Invoke
	|-Comparison<SubMeshDescriptor>.Invoke
	|-Comparison<QRCodeGenerator.CodewordBlock>.Invoke
	|
	|-RVA: 0xF798E0 Offset: 0xF78AE0 VA: 0x180F798E0
	|-Comparison<ElementAssignmentConflictInfo>.Invoke
	|-Comparison<GlyphPairAdjustmentRecord>.Invoke
	|-Comparison<RaycastHit>.Invoke
	|
	|-RVA: 0xF79B20 Offset: 0xF78D20 VA: 0x180F79B20
	|-Comparison<Entitlement>.Invoke
	|-Comparison<PhysicsShape2D>.Invoke
	|-Comparison<PlayerLoopSystem>.Invoke
	|-Comparison<PlayerLoopSystemInternal>.Invoke
	|-Comparison<Sku>.Invoke
	|-Comparison<User>.Invoke
	|-Comparison<UIRenderDevice.AllocToFree>.Invoke
	|
	|-RVA: 0xF79AA0 Offset: 0xF78CA0 VA: 0x180F79AA0
	|-Comparison<GameListing>.Invoke
	|-Comparison<RaycastResult>.Invoke
	|-Comparison<WriteStackFrame>.Invoke
	|-Comparison<UIRStylePainter.Entry>.Invoke
	|-Comparison<UIRenderDevice.AllocToUpdate>.Invoke
	|
	|-RVA: 0xF7A8B0 Offset: 0xF79AB0 VA: 0x180F7A8B0
	|-Comparison<RaycastHit2D>.Invoke
	|
	|-RVA: 0xF7ABE0 Offset: 0xF79DE0 VA: 0x180F7ABE0
	|-Comparison<ReadStackFrame>.Invoke
	|
	|-RVA: 0xF7A7E0 Offset: 0xF799E0 VA: 0x180F7A7E0
	|-Comparison<UIVertex>.Invoke
	|
	|-RVA: 0xF7A910 Offset: 0xF79B10 VA: 0x180F7A910
	|-Comparison<Win32_IP_ADAPTER_ADDRESSES>.Invoke
	|
	|-RVA: 0xF7AAD0 Offset: 0xF79CD0 VA: 0x180F7AAD0
	|-Comparison<Win32_IP_ADAPTER_INFO>.Invoke
	|
	|-RVA: 0xF7AC90 Offset: 0xF79E90 VA: 0x180F7AC90
	|-Comparison<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>.Invoke
	|
	|-RVA: 0xF7A6F0 Offset: 0xF798F0 VA: 0x180F7A6F0
	|-Comparison<ParticleSystem.Particle>.Invoke
	|
	|-RVA: 0xF7AA20 Offset: 0xF79C20 VA: 0x180F7AA20
	|-Comparison<RadialMenu.CachedButtonObject>.Invoke
	|
	|-RVA: 0xF7A650 Offset: 0xF79850 VA: 0x180F7A650
	|-Comparison<RenderChain.RenderNodeData>.Invoke
	*/
}

// Namespace: System
public sealed class Converter<TInput, TOutput> : MulticastDelegate // TypeDefIndex: 2975
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB60A10 Offset: 0xB5FC10 VA: 0x180B60A10
	|-Converter<object, object>..ctor
	|
	|-RVA: 0xFBAF40 Offset: 0xFBA140 VA: 0x180FBAF40
	|-Converter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TOutput Invoke(TInput input) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250
	|-Converter<object, object>.Invoke
	|
	|-RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10
	|-Converter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
public sealed class Predicate<T> : MulticastDelegate // TypeDefIndex: 2976
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB86200 Offset: 0xB85400 VA: 0x180B86200
	|-Predicate<ArraySegment<byte>>..ctor
	|-Predicate<KeyValuePair<int, object>>..ctor
	|-Predicate<KeyValuePair<object, char>>..ctor
	|-Predicate<KeyValuePair<object, object>>..ctor
	|-Predicate<KeyValuePair<object, ulong>>..ctor
	|-Predicate<KeyValuePair<PropertyName, object>>..ctor
	|-Predicate<NativeArray<ConvertMeshJobData>>..ctor
	|-Predicate<NativeArray<CopyClosingMeshJobData>>..ctor
	|-Predicate<NativeArray<NudgeJobData>>..ctor
	|-Predicate<NativeSlice<ConvertMeshJobData>>..ctor
	|-Predicate<NativeSlice<CopyClosingMeshJobData>>..ctor
	|-Predicate<NativeSlice<NudgeJobData>>..ctor
	|-Predicate<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>..ctor
	|-Predicate<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>..ctor
	|-Predicate<StructMultiKey<object, object>>..ctor
	|-Predicate<ValueTuple<object, object>>..ctor
	|-Predicate<Color>..ctor
	|-Predicate<ControllerTemplateElementTarget>..ctor
	|-Predicate<DateTimeOffset>..ctor
	|-Predicate<Decimal>..ctor
	|-Predicate<DetectiveSuspect>..ctor
	|-Predicate<DiscardReasonWithCategory>..ctor
	|-Predicate<GlyphRect>..ctor
	|-Predicate<Guid>..ctor
	|-Predicate<IngestData>..ctor
	|-Predicate<InterpretedFrameInfo>..ctor
	|-Predicate<JsonElement>..ctor
	|-Predicate<JsonEncodedText>..ctor
	|-Predicate<LigatureSubstitutionRecord>..ctor
	|-Predicate<MultipleSubstitutionRecord>..ctor
	|-Predicate<RangePositionInfo>..ctor
	|-Predicate<Rect>..ctor
	|-Predicate<Resolution>..ctor
	|-Predicate<RuleMatcher>..ctor
	|-Predicate<RulesCategory>..ctor
	|-Predicate<SslApplicationProtocol>..ctor
	|-Predicate<StylePropertyName>..ctor
	|-Predicate<StylePropertyValue>..ctor
	|-Predicate<StyleValueManaged>..ctor
	|-Predicate<SubString>..ctor
	|-Predicate<UILineInfo>..ctor
	|-Predicate<Vector4>..ctor
	|-Predicate<VertexAttributeDescriptor>..ctor
	|-Predicate<X509ChainStatus>..ctor
	|-Predicate<XSXSubmitGraphicsCommandsDataCommandInternal>..ctor
	|-Predicate<XboxOneGDKSubmitGraphicsCommandsDataCommandInternal>..ctor
	|-Predicate<AchievementManager.AchievementProgressValue>..ctor
	|-Predicate<BeforeRenderHelper.OrderBlock>..ctor
	|-Predicate<CreditsController.CreditStruct>..ctor
	|-Predicate<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.YkJYhIwKoTBpWKATiflrEgjLfZIX>..ctor
	|-Predicate<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.fcJeYwLvuogcmgGamTgYErdESsqW>..ctor
	|-Predicate<FocusController.FocusedElement>..ctor
	|-Predicate<HardwareControllerTemplateMap.rwEetQoHfXcCclqvIDEVKbecRXpDb>..ctor
	|-Predicate<MultiColumnCollectionHeader.SortedColumnState>..ctor
	|-Predicate<PZVoNXqAhLHAMSWUdEitcRuLGMcmA.LxbGihMOwQSEjsHzfBQtamHgcTraA>..ctor
	|-Predicate<PackedPlayModeBuildLogs.RuntimeBuildLog>..ctor
	|-Predicate<QRCodeGenerator.AlignmentPattern>..ctor
	|-Predicate<QRCodeGenerator.VersionInfo>..ctor
	|-Predicate<QRCodeGenerator.VersionInfoDetails>..ctor
	|-Predicate<ResourceManager.DeferredCallbackRegisterRequest>..ctor
	|-Predicate<ServerManager.PingWrapper>..ctor
	|-Predicate<TextSettings.FontReferenceMap>..ctor
	|-Predicate<TextureRegistry.TextureInfo>..ctor
	|-Predicate<VisualTreeAsset.SlotDefinition>..ctor
	|-Predicate<VisualTreeAsset.SlotUsageEntry>..ctor
	|-Predicate<VisualTreeAsset.UxmlObjectEntry>..ctor
	|-Predicate<XjXmgYEoXluUbKoyNCodoxJzPrjJ.FSjxKnkodQibKwPtFNBnKKATQeux>..ctor
	|-Predicate<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|
	|-RVA: 0xB86660 Offset: 0xB85860 VA: 0x180B86660
	|-Predicate<KeyValuePair<byte, int>>..ctor
	|-Predicate<ValueTuple<int, int>>..ctor
	|-Predicate<AnimatorClipInfo>..ctor
	|-Predicate<CancellationToken>..ctor
	|-Predicate<DateTime>..ctor
	|-Predicate<Edge>..ctor
	|-Predicate<HttpStatusCodeRange>..ctor
	|-Predicate<TimeSpan>..ctor
	|-Predicate<TimeValue>..ctor
	|-Predicate<BitmapAllocator32.Page>..ctor
	|-Predicate<DtlsUnityConnection.FragmentRange>..ctor
	|-Predicate<QRCodeGenerator.Antilog>..ctor
	|-Predicate<QRCodeGenerator.PolynomItem>..ctor
	|-Predicate<SecurityLogBehaviour.SecurityLogEntry>..ctor
	|-Predicate<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>..ctor
	|
	|-RVA: 0xB86340 Offset: 0xB85540 VA: 0x180B86340
	|-Predicate<KeyValuePair<DiscardReasonWithCategory, int>>..ctor
	|-Predicate<KeyValuePair<DiscardReasonWithCategory, object>>..ctor
	|-Predicate<KeyValuePair<Rect, object>>..ctor
	|-Predicate<TempAllocator.Page<ushort>>..ctor
	|-Predicate<TempAllocator.Page<Vertex>>..ctor
	|-Predicate<AsyncOperationHandle>..ctor
	|-Predicate<ComputedTransitionProperty>..ctor
	|-Predicate<DataRecordInternal>..ctor
	|-Predicate<DebugLogMessage>..ctor
	|-Predicate<Entitlement>..ctor
	|-Predicate<FileStat>..ctor
	|-Predicate<InputActionSourceData>..ctor
	|-Predicate<ItemOwnershipInternal>..ctor
	|-Predicate<JsonPosition>..ctor
	|-Predicate<MarkToBaseAdjustmentRecord>..ctor
	|-Predicate<MarkToMarkAdjustmentRecord>..ctor
	|-Predicate<OptionInternal>..ctor
	|-Predicate<ParameterRef>..ctor
	|-Predicate<ParticipantMetadataInternal>..ctor
	|-Predicate<PlayerStatInfoInternal>..ctor
	|-Predicate<PropertyRef>..ctor
	|-Predicate<SandboxIdItemOwnershipInternal>..ctor
	|-Predicate<SelectorMatchRecord>..ctor
	|-Predicate<StatThresholdsInternal>..ctor
	|-Predicate<StyleSelectorPart>..ctor
	|-Predicate<StyleSyntaxToken>..ctor
	|-Predicate<StyleValue>..ctor
	|-Predicate<StyleVariable>..ctor
	|-Predicate<TreeViewItemWrapper>..ctor
	|-Predicate<Camera.RenderRequest>..ctor
	|-Predicate<CreditsController.FormatStruct>..ctor
	|-Predicate<TemplateAsset.AttributeOverride>..ctor
	|-Predicate<UnitySynchronizationContext.WorkRequest>..ctor
	|-Predicate<UnityUITextMeshProGlyphHelper.GlyphOrText>..ctor
	|-Predicate<VisualTreeAsset.UsingEntry>..ctor
	|
	|-RVA: 0xB86A00 Offset: 0xB85C00 VA: 0x180B86A00
	|-Predicate<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>..ctor
	|-Predicate<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>..ctor
	|-Predicate<BoneWeight>..ctor
	|-Predicate<TypeWrapper>..ctor
	|-Predicate<DelayedActionManager.DelegateInfo>..ctor
	|-Predicate<QRCodeGenerator.ECCInfo>..ctor
	|-Predicate<UIRStylePainter.RepeatRectUV>..ctor
	|-Predicate<VisualTreeAsset.AssetEntry>..ctor
	|-Predicate<InstructionList.DebugView.InstructionView>..ctor
	|-Predicate<MultiColumnCollectionHeader.ViewState.ColumnState>..ctor
	|
	|-RVA: 0xB862A0 Offset: 0xB854A0 VA: 0x180B862A0
	|-Predicate<SequenceBuffer.SequencedData<VentilationSystem.VentMoveInfo, VentilationSystem.VentMoveInfo>>..ctor
	|-Predicate<ManipulatorActivationFilter>..ctor
	|-Predicate<UICharInfo>..ctor
	|-Predicate<Vector3>..ctor
	|-Predicate<Vector3Int>..ctor
	|-Predicate<CustomController.CZxNqDPSLSmjvjcEzpoKeadUPlaM>..ctor
	|-Predicate<PlayerController.Element.TBnjpqFyveWLFptREPetgdFmwyCWA>..ctor
	|
	|-RVA: 0xB86480 Offset: 0xB85680 VA: 0x180B86480
	|-Predicate<Announcement>..ctor
	|-Predicate<Matrix4x4>..ctor
	|-Predicate<TexturePacker_JsonArray.Frame>..ctor
	|
	|-RVA: 0xB86700 Offset: 0xB85900 VA: 0x180B86700
	|-Predicate<bool>..ctor
	|-Predicate<byte>..ctor
	|-Predicate<ByteEnum>..ctor
	|-Predicate<sbyte>..ctor
	|
	|-RVA: 0xB86520 Offset: 0xB85720 VA: 0x180B86520
	|-Predicate<char>..ctor
	|-Predicate<short>..ctor
	|-Predicate<ushort>..ctor
	|-Predicate<UInt16Enum>..ctor
	|
	|-RVA: 0xB867A0 Offset: 0xB859A0 VA: 0x180B867A0
	|-Predicate<Color32>..ctor
	|-Predicate<EasingFunction>..ctor
	|-Predicate<RegexCharClass.SingleRange>..ctor
	|
	|-RVA: 0xB863E0 Offset: 0xB855E0 VA: 0x180B863E0
	|-Predicate<ContactPoint2D>..ctor
	|-Predicate<ControllerPollingInfo>..ctor
	|-Predicate<ExternalAccountInfo>..ctor
	|-Predicate<TextureBlitter.BlitInfo>..ctor
	|
	|-RVA: 0xB86D20 Offset: 0xB85F20 VA: 0x180B86D20
	|-Predicate<DiagnosticEvent>..ctor
	|-Predicate<ModIdentifierInternal>..ctor
	|-Predicate<ObjectInitializationData>..ctor
	|-Predicate<Relationship>..ctor
	|-Predicate<SubMeshDescriptor>..ctor
	|-Predicate<QRCodeGenerator.CodewordBlock>..ctor
	|
	|-RVA: 0xB86C80 Offset: 0xB85E80 VA: 0x180B86C80
	|-Predicate<double>..ctor
	|-Predicate<float>..ctor
	|
	|-RVA: 0xB86BE0 Offset: 0xB85DE0 VA: 0x180B86BE0
	|-Predicate<ElementAssignmentConflictInfo>..ctor
	|-Predicate<GlyphPairAdjustmentRecord>..ctor
	|
	|-RVA: 0xB86960 Offset: 0xB85B60 VA: 0x180B86960
	|-Predicate<Entitlement>..ctor
	|-Predicate<PhysicsShape2D>..ctor
	|-Predicate<PlayerLoopSystem>..ctor
	|-Predicate<PlayerLoopSystemInternal>..ctor
	|-Predicate<Sku>..ctor
	|-Predicate<User>..ctor
	|-Predicate<UIRenderDevice.AllocToFree>..ctor
	|
	|-RVA: 0xB86AA0 Offset: 0xB85CA0 VA: 0x180B86AA0
	|-Predicate<GameListing>..ctor
	|-Predicate<RaycastResult>..ctor
	|-Predicate<WriteStackFrame>..ctor
	|-Predicate<UIRStylePainter.Entry>..ctor
	|-Predicate<UIRenderDevice.AllocToUpdate>..ctor
	|
	|-RVA: 0xB865C0 Offset: 0xB857C0 VA: 0x180B865C0
	|-Predicate<int>..ctor
	|-Predicate<Int32Enum>..ctor
	|-Predicate<uint>..ctor
	|
	|-RVA: 0xB86B40 Offset: 0xB85D40 VA: 0x180B86B40
	|-Predicate<long>..ctor
	|-Predicate<ulong>..ctor
	|
	|-RVA: 0xB86840 Offset: 0xB85A40 VA: 0x180B86840
	|-Predicate<object>..ctor
	|
	|-RVA: 0xB87510 Offset: 0xB86710 VA: 0x180B87510
	|-Predicate<RaycastHit2D>..ctor
	|
	|-RVA: 0xB878D0 Offset: 0xB86AD0 VA: 0x180B878D0
	|-Predicate<ReadStackFrame>..ctor
	|
	|-RVA: 0xB87790 Offset: 0xB86990 VA: 0x180B87790
	|-Predicate<UIVertex>..ctor
	|
	|-RVA: 0xB87830 Offset: 0xB86A30 VA: 0x180B87830
	|-Predicate<Vector2>..ctor
	|
	|-RVA: 0xB87220 Offset: 0xB86420 VA: 0x180B87220
	|-Predicate<Win32_IP_ADAPTER_ADDRESSES>..ctor
	|
	|-RVA: 0xB876F0 Offset: 0xB868F0 VA: 0x180B876F0
	|-Predicate<Win32_IP_ADAPTER_INFO>..ctor
	|
	|-RVA: 0xB872C0 Offset: 0xB864C0 VA: 0x180B872C0
	|-Predicate<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0xB87650 Offset: 0xB86850 VA: 0x180B87650
	|-Predicate<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>..ctor
	|
	|-RVA: 0xB87180 Offset: 0xB86380 VA: 0x180B87180
	|-Predicate<HeliSabotageSystem.ActiveConsoleData>..ctor
	|
	|-RVA: 0xB87470 Offset: 0xB86670 VA: 0x180B87470
	|-Predicate<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0xB875B0 Offset: 0xB867B0 VA: 0x180B875B0
	|-Predicate<RadialMenu.CachedButtonObject>..ctor
	|
	|-RVA: 0xB873D0 Offset: 0xB865D0 VA: 0x180B873D0
	|-Predicate<RenderChain.RenderNodeData>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual bool Invoke(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB85FD0 Offset: 0xB851D0 VA: 0x180B85FD0
	|-Predicate<ArraySegment<byte>>.Invoke
	|-Predicate<KeyValuePair<int, object>>.Invoke
	|-Predicate<KeyValuePair<object, char>>.Invoke
	|-Predicate<KeyValuePair<object, object>>.Invoke
	|-Predicate<KeyValuePair<object, ulong>>.Invoke
	|-Predicate<KeyValuePair<PropertyName, object>>.Invoke
	|-Predicate<NativeArray<ConvertMeshJobData>>.Invoke
	|-Predicate<NativeArray<CopyClosingMeshJobData>>.Invoke
	|-Predicate<NativeArray<NudgeJobData>>.Invoke
	|-Predicate<NativeSlice<ConvertMeshJobData>>.Invoke
	|-Predicate<NativeSlice<CopyClosingMeshJobData>>.Invoke
	|-Predicate<NativeSlice<NudgeJobData>>.Invoke
	|-Predicate<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<int, object>>.Invoke
	|-Predicate<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<uint, object>>.Invoke
	|-Predicate<StructMultiKey<object, object>>.Invoke
	|-Predicate<ValueTuple<object, object>>.Invoke
	|-Predicate<Color>.Invoke
	|-Predicate<ControllerTemplateElementTarget>.Invoke
	|-Predicate<DateTimeOffset>.Invoke
	|-Predicate<Decimal>.Invoke
	|-Predicate<DetectiveSuspect>.Invoke
	|-Predicate<DiscardReasonWithCategory>.Invoke
	|-Predicate<GlyphRect>.Invoke
	|-Predicate<Guid>.Invoke
	|-Predicate<IngestData>.Invoke
	|-Predicate<InterpretedFrameInfo>.Invoke
	|-Predicate<JsonElement>.Invoke
	|-Predicate<JsonEncodedText>.Invoke
	|-Predicate<LigatureSubstitutionRecord>.Invoke
	|-Predicate<MultipleSubstitutionRecord>.Invoke
	|-Predicate<RangePositionInfo>.Invoke
	|-Predicate<Rect>.Invoke
	|-Predicate<Resolution>.Invoke
	|-Predicate<RuleMatcher>.Invoke
	|-Predicate<RulesCategory>.Invoke
	|-Predicate<SslApplicationProtocol>.Invoke
	|-Predicate<StylePropertyName>.Invoke
	|-Predicate<StylePropertyValue>.Invoke
	|-Predicate<StyleValueManaged>.Invoke
	|-Predicate<SubString>.Invoke
	|-Predicate<UILineInfo>.Invoke
	|-Predicate<Vector4>.Invoke
	|-Predicate<VertexAttributeDescriptor>.Invoke
	|-Predicate<X509ChainStatus>.Invoke
	|-Predicate<XSXSubmitGraphicsCommandsDataCommandInternal>.Invoke
	|-Predicate<XboxOneGDKSubmitGraphicsCommandsDataCommandInternal>.Invoke
	|-Predicate<AchievementManager.AchievementProgressValue>.Invoke
	|-Predicate<BeforeRenderHelper.OrderBlock>.Invoke
	|-Predicate<CreditsController.CreditStruct>.Invoke
	|-Predicate<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.YkJYhIwKoTBpWKATiflrEgjLfZIX>.Invoke
	|-Predicate<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.fcJeYwLvuogcmgGamTgYErdESsqW>.Invoke
	|-Predicate<FocusController.FocusedElement>.Invoke
	|-Predicate<HardwareControllerTemplateMap.rwEetQoHfXcCclqvIDEVKbecRXpDb>.Invoke
	|-Predicate<MultiColumnCollectionHeader.SortedColumnState>.Invoke
	|-Predicate<PZVoNXqAhLHAMSWUdEitcRuLGMcmA.LxbGihMOwQSEjsHzfBQtamHgcTraA>.Invoke
	|-Predicate<PackedPlayModeBuildLogs.RuntimeBuildLog>.Invoke
	|-Predicate<QRCodeGenerator.AlignmentPattern>.Invoke
	|-Predicate<QRCodeGenerator.VersionInfo>.Invoke
	|-Predicate<QRCodeGenerator.VersionInfoDetails>.Invoke
	|-Predicate<ResourceManager.DeferredCallbackRegisterRequest>.Invoke
	|-Predicate<ServerManager.PingWrapper>.Invoke
	|-Predicate<TextSettings.FontReferenceMap>.Invoke
	|-Predicate<TextureRegistry.TextureInfo>.Invoke
	|-Predicate<VisualTreeAsset.SlotDefinition>.Invoke
	|-Predicate<VisualTreeAsset.SlotUsageEntry>.Invoke
	|-Predicate<VisualTreeAsset.UxmlObjectEntry>.Invoke
	|-Predicate<XjXmgYEoXluUbKoyNCodoxJzPrjJ.FSjxKnkodQibKwPtFNBnKKATQeux>.Invoke
	|-Predicate<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Invoke
	|
	|-RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250
	|-Predicate<KeyValuePair<byte, int>>.Invoke
	|-Predicate<ValueTuple<int, int>>.Invoke
	|-Predicate<AnimatorClipInfo>.Invoke
	|-Predicate<bool>.Invoke
	|-Predicate<byte>.Invoke
	|-Predicate<ByteEnum>.Invoke
	|-Predicate<CancellationToken>.Invoke
	|-Predicate<char>.Invoke
	|-Predicate<Color32>.Invoke
	|-Predicate<DateTime>.Invoke
	|-Predicate<double>.Invoke
	|-Predicate<EasingFunction>.Invoke
	|-Predicate<Edge>.Invoke
	|-Predicate<HttpStatusCodeRange>.Invoke
	|-Predicate<short>.Invoke
	|-Predicate<int>.Invoke
	|-Predicate<Int32Enum>.Invoke
	|-Predicate<long>.Invoke
	|-Predicate<object>.Invoke
	|-Predicate<sbyte>.Invoke
	|-Predicate<float>.Invoke
	|-Predicate<TimeSpan>.Invoke
	|-Predicate<TimeValue>.Invoke
	|-Predicate<ushort>.Invoke
	|-Predicate<UInt16Enum>.Invoke
	|-Predicate<uint>.Invoke
	|-Predicate<ulong>.Invoke
	|-Predicate<Vector2>.Invoke
	|-Predicate<__Il2CppFullySharedGenericType>.Invoke
	|-Predicate<BitmapAllocator32.Page>.Invoke
	|-Predicate<DtlsUnityConnection.FragmentRange>.Invoke
	|-Predicate<HeliSabotageSystem.ActiveConsoleData>.Invoke
	|-Predicate<QRCodeGenerator.Antilog>.Invoke
	|-Predicate<QRCodeGenerator.PolynomItem>.Invoke
	|-Predicate<RegexCharClass.SingleRange>.Invoke
	|-Predicate<SecurityLogBehaviour.SecurityLogEntry>.Invoke
	|-Predicate<gyqFnpolfSFlpzqYHLkLYCneFSxf.ViddfYcHFKkMzLtUJApgjGEFxjvfB>.Invoke
	|
	|-RVA: 0x448CC0 Offset: 0x447EC0 VA: 0x180448CC0
	|-Predicate<KeyValuePair<DiscardReasonWithCategory, int>>.Invoke
	|-Predicate<KeyValuePair<DiscardReasonWithCategory, object>>.Invoke
	|-Predicate<KeyValuePair<Rect, object>>.Invoke
	|-Predicate<TempAllocator.Page<ushort>>.Invoke
	|-Predicate<TempAllocator.Page<Vertex>>.Invoke
	|-Predicate<AsyncOperationHandle>.Invoke
	|-Predicate<ComputedTransitionProperty>.Invoke
	|-Predicate<DataRecordInternal>.Invoke
	|-Predicate<DebugLogMessage>.Invoke
	|-Predicate<Entitlement>.Invoke
	|-Predicate<FileStat>.Invoke
	|-Predicate<InputActionSourceData>.Invoke
	|-Predicate<ItemOwnershipInternal>.Invoke
	|-Predicate<JsonPosition>.Invoke
	|-Predicate<MarkToBaseAdjustmentRecord>.Invoke
	|-Predicate<MarkToMarkAdjustmentRecord>.Invoke
	|-Predicate<OptionInternal>.Invoke
	|-Predicate<ParameterRef>.Invoke
	|-Predicate<ParticipantMetadataInternal>.Invoke
	|-Predicate<PlayerStatInfoInternal>.Invoke
	|-Predicate<PropertyRef>.Invoke
	|-Predicate<SandboxIdItemOwnershipInternal>.Invoke
	|-Predicate<SelectorMatchRecord>.Invoke
	|-Predicate<StatThresholdsInternal>.Invoke
	|-Predicate<StyleSelectorPart>.Invoke
	|-Predicate<StyleSyntaxToken>.Invoke
	|-Predicate<StyleValue>.Invoke
	|-Predicate<StyleVariable>.Invoke
	|-Predicate<TreeViewItemWrapper>.Invoke
	|-Predicate<Camera.RenderRequest>.Invoke
	|-Predicate<CreditsController.FormatStruct>.Invoke
	|-Predicate<TemplateAsset.AttributeOverride>.Invoke
	|-Predicate<UnitySynchronizationContext.WorkRequest>.Invoke
	|-Predicate<UnityUITextMeshProGlyphHelper.GlyphOrText>.Invoke
	|-Predicate<VisualTreeAsset.UsingEntry>.Invoke
	|
	|-RVA: 0xB86040 Offset: 0xB85240 VA: 0x180B86040
	|-Predicate<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<Bytes20, object>>.Invoke
	|-Predicate<IndexedDictionary.RbBDsGfmVKwHNiuFMOHDvrlXmIDbA<object, SerializedObject.kTevGNeBPkxdRWpwckBypFSNGZyEA>>.Invoke
	|-Predicate<BoneWeight>.Invoke
	|-Predicate<TypeWrapper>.Invoke
	|-Predicate<DelayedActionManager.DelegateInfo>.Invoke
	|-Predicate<QRCodeGenerator.ECCInfo>.Invoke
	|-Predicate<UIRStylePainter.RepeatRectUV>.Invoke
	|-Predicate<VisualTreeAsset.AssetEntry>.Invoke
	|-Predicate<InstructionList.DebugView.InstructionView>.Invoke
	|-Predicate<MultiColumnCollectionHeader.ViewState.ColumnState>.Invoke
	|
	|-RVA: 0xB86180 Offset: 0xB85380 VA: 0x180B86180
	|-Predicate<SequenceBuffer.SequencedData<VentilationSystem.VentMoveInfo, VentilationSystem.VentMoveInfo>>.Invoke
	|-Predicate<ManipulatorActivationFilter>.Invoke
	|-Predicate<UICharInfo>.Invoke
	|-Predicate<Vector3>.Invoke
	|-Predicate<Vector3Int>.Invoke
	|-Predicate<CustomController.CZxNqDPSLSmjvjcEzpoKeadUPlaM>.Invoke
	|-Predicate<PlayerController.Element.TBnjpqFyveWLFptREPetgdFmwyCWA>.Invoke
	|
	|-RVA: 0xB86140 Offset: 0xB85340 VA: 0x180B86140
	|-Predicate<Announcement>.Invoke
	|-Predicate<Matrix4x4>.Invoke
	|-Predicate<TexturePacker_JsonArray.Frame>.Invoke
	|
	|-RVA: 0xB860B0 Offset: 0xB852B0 VA: 0x180B860B0
	|-Predicate<ContactPoint2D>.Invoke
	|-Predicate<ControllerPollingInfo>.Invoke
	|-Predicate<ExternalAccountInfo>.Invoke
	|-Predicate<TextureBlitter.BlitInfo>.Invoke
	|
	|-RVA: 0xB86100 Offset: 0xB85300 VA: 0x180B86100
	|-Predicate<DiagnosticEvent>.Invoke
	|-Predicate<ModIdentifierInternal>.Invoke
	|-Predicate<ObjectInitializationData>.Invoke
	|-Predicate<Relationship>.Invoke
	|-Predicate<SubMeshDescriptor>.Invoke
	|-Predicate<QRCodeGenerator.CodewordBlock>.Invoke
	|
	|-RVA: 0xB86070 Offset: 0xB85270 VA: 0x180B86070
	|-Predicate<ElementAssignmentConflictInfo>.Invoke
	|-Predicate<GlyphPairAdjustmentRecord>.Invoke
	|
	|-RVA: 0xB86000 Offset: 0xB85200 VA: 0x180B86000
	|-Predicate<Entitlement>.Invoke
	|-Predicate<PhysicsShape2D>.Invoke
	|-Predicate<PlayerLoopSystem>.Invoke
	|-Predicate<PlayerLoopSystemInternal>.Invoke
	|-Predicate<Sku>.Invoke
	|-Predicate<User>.Invoke
	|-Predicate<UIRenderDevice.AllocToFree>.Invoke
	|
	|-RVA: 0xB861B0 Offset: 0xB853B0 VA: 0x180B861B0
	|-Predicate<GameListing>.Invoke
	|-Predicate<RaycastResult>.Invoke
	|-Predicate<WriteStackFrame>.Invoke
	|-Predicate<UIRStylePainter.Entry>.Invoke
	|-Predicate<UIRenderDevice.AllocToUpdate>.Invoke
	|
	|-RVA: 0xB86F00 Offset: 0xB86100 VA: 0x180B86F00
	|-Predicate<RaycastHit2D>.Invoke
	|
	|-RVA: 0xB87120 Offset: 0xB86320 VA: 0x180B87120
	|-Predicate<ReadStackFrame>.Invoke
	|
	|-RVA: 0xB87030 Offset: 0xB86230 VA: 0x180B87030
	|-Predicate<UIVertex>.Invoke
	|
	|-RVA: 0xB86F90 Offset: 0xB86190 VA: 0x180B86F90
	|-Predicate<Win32_IP_ADAPTER_ADDRESSES>.Invoke
	|
	|-RVA: 0xB86E20 Offset: 0xB86020 VA: 0x180B86E20
	|-Predicate<Win32_IP_ADAPTER_INFO>.Invoke
	|
	|-RVA: 0xB86F40 Offset: 0xB86140 VA: 0x180B86F40
	|-Predicate<FGmsSkeSnjpawgYuHoSaJQIhbMkIA.kwabYkkNrBZkxFRgRSMvAOJsMQMv>.Invoke
	|
	|-RVA: 0xB870A0 Offset: 0xB862A0 VA: 0x180B870A0
	|-Predicate<ParticleSystem.Particle>.Invoke
	|
	|-RVA: 0xB86EA0 Offset: 0xB860A0 VA: 0x180B86EA0
	|-Predicate<RadialMenu.CachedButtonObject>.Invoke
	|
	|-RVA: 0xB86DC0 Offset: 0xB85FC0 VA: 0x180B86DC0
	|-Predicate<RenderChain.RenderNodeData>.Invoke
	*/
}

// Namespace: System
[DebuggerDisplay("Count = {InnerExceptionCount}")]
[Serializable]
public class AggregateException : Exception // TypeDefIndex: 2977
{
	// Fields
	private ReadOnlyCollection<Exception> m_innerExceptions; // 0x90

	// Properties
	public ReadOnlyCollection<Exception> InnerExceptions { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x16920E0 Offset: 0x16912E0 VA: 0x1816920E0
	public void .ctor() { }

	// RVA: 0x1691900 Offset: 0x1690B00 VA: 0x181691900
	public void .ctor(IEnumerable<Exception> innerExceptions) { }

	// RVA: 0x1692090 Offset: 0x1691290 VA: 0x181692090
	public void .ctor(Exception[] innerExceptions) { }

	// RVA: 0x1691AB0 Offset: 0x1690CB0 VA: 0x181691AB0
	public void .ctor(string message, IEnumerable<Exception> innerExceptions) { }

	// RVA: 0x16919E0 Offset: 0x1690BE0 VA: 0x1816919E0
	public void .ctor(string message, Exception[] innerExceptions) { }

	// RVA: 0x1691B70 Offset: 0x1690D70 VA: 0x181691B70
	private void .ctor(string message, IList<Exception> innerExceptions) { }

	// RVA: 0x1691DD0 Offset: 0x1690FD0 VA: 0x181691DD0
	internal void .ctor(IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x16919F0 Offset: 0x1690BF0 VA: 0x1816919F0
	internal void .ctor(string message, IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x1691670 Offset: 0x1690870 VA: 0x181691670
	private void .ctor(string message, IList<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x1691EB0 Offset: 0x16910B0 VA: 0x181691EB0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1691310 Offset: 0x1690510 VA: 0x181691310 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1691250 Offset: 0x1690450 VA: 0x181691250 Slot: 7
	public override Exception GetBaseException() { }

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	public ReadOnlyCollection<Exception> get_InnerExceptions() { }

	// RVA: 0x1690FB0 Offset: 0x16901B0 VA: 0x181690FB0
	public AggregateException Flatten() { }

	// RVA: 0x16921B0 Offset: 0x16913B0 VA: 0x1816921B0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1691450 Offset: 0x1690650 VA: 0x181691450 Slot: 3
	public override string ToString() { }
}

// Namespace: System
[Serializable]
public class ApplicationException : Exception // TypeDefIndex: 2978
{
	// Methods

	// RVA: 0x176A090 Offset: 0x1769290 VA: 0x18176A090
	public void .ctor() { }

	// RVA: 0x176A180 Offset: 0x1769380 VA: 0x18176A180
	public void .ctor(string message) { }

	// RVA: 0x176A100 Offset: 0x1769300 VA: 0x18176A100
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x176A1F0 Offset: 0x17693F0 VA: 0x18176A1F0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System
[Serializable]
public class ArgumentException : SystemException // TypeDefIndex: 2979
{
	// Fields
	private string _paramName; // 0x90

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x176A360 Offset: 0x1769560 VA: 0x18176A360
	public void .ctor() { }

	// RVA: 0x176A340 Offset: 0x1769540 VA: 0x18176A340
	public void .ctor(string message) { }

	// RVA: 0x176A4C0 Offset: 0x17696C0 VA: 0x18176A4C0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x176A3B0 Offset: 0x17695B0 VA: 0x18176A3B0
	public void .ctor(string message, string paramName, Exception innerException) { }

	// RVA: 0x176A3F0 Offset: 0x17695F0 VA: 0x18176A3F0
	public void .ctor(string message, string paramName) { }

	// RVA: 0x176A430 Offset: 0x1769630 VA: 0x18176A430
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x176A270 Offset: 0x1769470 VA: 0x18176A270 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x176A4E0 Offset: 0x17696E0 VA: 0x18176A4E0 Slot: 5
	public override string get_Message() { }
}

// Namespace: System
[Serializable]
public class ArgumentNullException : ArgumentException // TypeDefIndex: 2980
{
	// Methods

	// RVA: 0x176A5E0 Offset: 0x17697E0 VA: 0x18176A5E0
	public void .ctor() { }

	// RVA: 0x176A580 Offset: 0x1769780 VA: 0x18176A580
	public void .ctor(string paramName) { }

	// RVA: 0x176A630 Offset: 0x1769830 VA: 0x18176A630
	public void .ctor(string paramName, string message) { }

	// RVA: 0x176A430 Offset: 0x1769630 VA: 0x18176A430
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System
[Serializable]
public class ArgumentOutOfRangeException : ArgumentException // TypeDefIndex: 2981
{
	// Fields
	private object _actualValue; // 0x98

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x176A920 Offset: 0x1769B20 VA: 0x18176A920
	public void .ctor() { }

	// RVA: 0x176A970 Offset: 0x1769B70 VA: 0x18176A970
	public void .ctor(string paramName) { }

	// RVA: 0x176A9D0 Offset: 0x1769BD0 VA: 0x18176A9D0
	public void .ctor(string paramName, string message) { }

	// RVA: 0x176A7D0 Offset: 0x17699D0 VA: 0x18176A7D0
	public void .ctor(string paramName, object actualValue, string message) { }

	// RVA: 0x176A820 Offset: 0x1769A20 VA: 0x18176A820
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x176A670 Offset: 0x1769870 VA: 0x18176A670 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x176AA10 Offset: 0x1769C10 VA: 0x18176AA10 Slot: 5
	public override string get_Message() { }
}

// Namespace: System
[Serializable]
public class ArithmeticException : SystemException // TypeDefIndex: 2982
{
	// Methods

	// RVA: 0x176AB30 Offset: 0x1769D30 VA: 0x18176AB30
	public void .ctor() { }

	// RVA: 0x176AB80 Offset: 0x1769D80 VA: 0x18176AB80
	public void .ctor(string message) { }

	// RVA: 0x176ABA0 Offset: 0x1769DA0 VA: 0x18176ABA0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: 
public struct ArraySegment.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 2983
{
	// Fields
	private readonly T[] _array; // 0x0
	private readonly int _start; // 0x0
	private readonly int _end; // 0x0
	private int _current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ArraySegment<T> arraySegment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EAAD0 Offset: 0x10E9CD0 VA: 0x1810EAAD0
	|-ArraySegment.Enumerator<byte>..ctor
	|-ArraySegment.Enumerator<char>..ctor
	|
	|-RVA: 0x1110050 Offset: 0x110F250 VA: 0x181110050
	|-ArraySegment.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E69A0 Offset: 0x10E5BA0 VA: 0x1810E69A0
	|-ArraySegment.Enumerator<byte>.MoveNext
	|-ArraySegment.Enumerator<char>.MoveNext
	|-ArraySegment.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EBF10 Offset: 0x10EB110 VA: 0x1810EBF10
	|-ArraySegment.Enumerator<byte>.get_Current
	|
	|-RVA: 0x10EBC40 Offset: 0x10EAE40 VA: 0x1810EBC40
	|-ArraySegment.Enumerator<char>.get_Current
	|
	|-RVA: 0x1111850 Offset: 0x1110A50 VA: 0x181111850
	|-ArraySegment.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EA030 Offset: 0x10E9230 VA: 0x1810EA030
	|-ArraySegment.Enumerator<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10E9E60 Offset: 0x10E9060 VA: 0x1810E9E60
	|-ArraySegment.Enumerator<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110D600 Offset: 0x110C800 VA: 0x18110D600
	|-ArraySegment.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E8DE0 Offset: 0x10E7FE0 VA: 0x1810E8DE0
	|-ArraySegment.Enumerator<byte>.System.Collections.IEnumerator.Reset
	|-ArraySegment.Enumerator<char>.System.Collections.IEnumerator.Reset
	|-ArraySegment.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-ArraySegment.Enumerator<byte>.Dispose
	|-ArraySegment.Enumerator<char>.Dispose
	|-ArraySegment.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	*/
}

// Namespace: System
[DefaultMember("Item")]
[IsReadOnly]
[Serializable]
public struct ArraySegment<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T> // TypeDefIndex: 2984
{
	// Fields
	[CompilerGenerated]
	private static readonly ArraySegment<T> <Empty>k__BackingField; // 0x0
	private readonly T[] _array; // 0x0
	private readonly int _offset; // 0x0
	private readonly int _count; // 0x0

	// Properties
	public static ArraySegment<T> Empty { get; }
	public T[] Array { get; }
	public int Offset { get; }
	public int Count { get; }
	private T System.Collections.Generic.IList<T>.Item { get; set; }
	private T System.Collections.Generic.IReadOnlyList<T>.Item { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static ArraySegment<T> get_Empty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA820 Offset: 0x12A9A20 VA: 0x1812AA820
	|-ArraySegment<byte>.get_Empty
	|-ArraySegment<char>.get_Empty
	|-ArraySegment<__Il2CppFullySharedGenericType>.get_Empty
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA7D0 Offset: 0x12A99D0 VA: 0x1812AA7D0
	|-ArraySegment<byte>..ctor
	|-ArraySegment<char>..ctor
	|-ArraySegment<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int offset, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA760 Offset: 0x12A9960 VA: 0x1812AA760
	|-ArraySegment<byte>..ctor
	|-ArraySegment<char>..ctor
	|-ArraySegment<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T[] get_Array() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	|-ArraySegment<byte>.get_Array
	|-ArraySegment<char>.get_Array
	|-ArraySegment<__Il2CppFullySharedGenericType>.get_Array
	*/

	// RVA: -1 Offset: -1
	public int get_Offset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	|-ArraySegment<byte>.get_Offset
	|-ArraySegment<char>.get_Offset
	|-ArraySegment<__Il2CppFullySharedGenericType>.get_Offset
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	|-ArraySegment<byte>.get_Count
	|-ArraySegment<char>.get_Count
	|-ArraySegment<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public ArraySegment.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9E40 Offset: 0x12A9040 VA: 0x1812A9E40
	|-ArraySegment<byte>.GetEnumerator
	|-ArraySegment<char>.GetEnumerator
	|
	|-RVA: 0x1334070 Offset: 0x1333270 VA: 0x181334070
	|-ArraySegment<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9F20 Offset: 0x12A9120 VA: 0x1812A9F20
	|-ArraySegment<byte>.GetHashCode
	|
	|-RVA: 0x1334220 Offset: 0x1333420 VA: 0x181334220
	|-ArraySegment<char>.GetHashCode
	|
	|-RVA: 0x1334180 Offset: 0x1333380 VA: 0x181334180
	|-ArraySegment<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] destination, int destinationIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9C10 Offset: 0x12A8E10 VA: 0x1812A9C10
	|-ArraySegment<byte>.CopyTo
	|-ArraySegment<char>.CopyTo
	|
	|-RVA: 0x1333DF0 Offset: 0x1332FF0 VA: 0x181333DF0
	|-ArraySegment<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9CF0 Offset: 0x12A8EF0 VA: 0x1812A9CF0
	|-ArraySegment<byte>.Equals
	|-ArraySegment<char>.Equals
	|
	|-RVA: 0x1333EE0 Offset: 0x13330E0 VA: 0x181333EE0
	|-ArraySegment<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1
	public bool Equals(ArraySegment<T> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9CD0 Offset: 0x12A8ED0 VA: 0x1812A9CD0
	|-ArraySegment<byte>.Equals
	|-ArraySegment<char>.Equals
	|-ArraySegment<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA470 Offset: 0x12A9670 VA: 0x1812AA470
	|-ArraySegment<byte>.ToArray
	|-ArraySegment<char>.ToArray
	|
	|-RVA: 0x1334EC0 Offset: 0x13340C0 VA: 0x181334EC0
	|-ArraySegment<__Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(ArraySegment<T> a, ArraySegment<T> b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA8C0 Offset: 0x12A9AC0 VA: 0x1812AA8C0
	|-ArraySegment<byte>.op_Equality
	|-ArraySegment<char>.op_Equality
	|
	|-RVA: 0x1335080 Offset: 0x1334280 VA: 0x181335080
	|-ArraySegment<__Il2CppFullySharedGenericType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static ArraySegment<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA970 Offset: 0x12A9B70 VA: 0x1812AA970
	|-ArraySegment<byte>.op_Implicit
	|-ArraySegment<char>.op_Implicit
	|-ArraySegment<__Il2CppFullySharedGenericType>.op_Implicit
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IList<T>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA2A0 Offset: 0x12A94A0 VA: 0x1812AA2A0
	|-ArraySegment<byte>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x1334B30 Offset: 0x1333D30 VA: 0x181334B30
	|-ArraySegment<char>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x13349B0 Offset: 0x1333BB0 VA: 0x1813349B0
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void System.Collections.Generic.IList<T>.set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA370 Offset: 0x12A9570 VA: 0x1812AA370
	|-ArraySegment<byte>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x1334C00 Offset: 0x1333E00 VA: 0x181334C00
	|-ArraySegment<char>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x1334CE0 Offset: 0x1333EE0 VA: 0x181334CE0
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.Generic.IList<T>.IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA1B0 Offset: 0x12A93B0 VA: 0x1812AA1B0
	|-ArraySegment<byte>.System.Collections.Generic.IList<T>.IndexOf
	|
	|-RVA: 0x13346B0 Offset: 0x13338B0 VA: 0x1813346B0
	|-ArraySegment<char>.System.Collections.Generic.IList<T>.IndexOf
	|
	|-RVA: 0x13347A0 Offset: 0x13339A0 VA: 0x1813347A0
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.IList<T>.Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9FC0 Offset: 0x12A91C0 VA: 0x1812A9FC0
	|-ArraySegment<byte>.System.Collections.Generic.IList<T>.Insert
	|-ArraySegment<char>.System.Collections.Generic.IList<T>.Insert
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9FC0 Offset: 0x12A91C0 VA: 0x1812A9FC0
	|-ArraySegment<byte>.System.Collections.Generic.IList<T>.RemoveAt
	|-ArraySegment<char>.System.Collections.Generic.IList<T>.RemoveAt
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private T System.Collections.Generic.IReadOnlyList<T>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA2A0 Offset: 0x12A94A0 VA: 0x1812AA2A0
	|-ArraySegment<byte>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	|
	|-RVA: 0x1334B30 Offset: 0x1333D30 VA: 0x181334B30
	|-ArraySegment<char>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	|
	|-RVA: 0x13349B0 Offset: 0x1333BB0 VA: 0x1813349B0
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ArraySegment<char>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9FC0 Offset: 0x12A91C0 VA: 0x1812A9FC0
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.Add
	|-ArraySegment<char>.System.Collections.Generic.ICollection<T>.Add
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private void System.Collections.Generic.ICollection<T>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9FC0 Offset: 0x12A91C0 VA: 0x1812A9FC0
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.Clear
	|-ArraySegment<char>.System.Collections.Generic.ICollection<T>.Clear
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<T>.Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9FD0 Offset: 0x12A91D0 VA: 0x1812A9FD0
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.Contains
	|
	|-RVA: 0x13344C0 Offset: 0x13336C0 VA: 0x1813344C0
	|-ArraySegment<char>.System.Collections.Generic.ICollection<T>.Contains
	|
	|-RVA: 0x13342C0 Offset: 0x13334C0 VA: 0x1813342C0
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool System.Collections.Generic.ICollection<T>.Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA0C0 Offset: 0x12A92C0 VA: 0x1812AA0C0
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.Remove
	|-ArraySegment<char>.System.Collections.Generic.ICollection<T>.Remove
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA0E0 Offset: 0x12A92E0 VA: 0x1812AA0E0
	|-ArraySegment<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-ArraySegment<char>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x13345B0 Offset: 0x13337B0 VA: 0x1813345B0
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA0E0 Offset: 0x12A92E0 VA: 0x1812AA0E0
	|-ArraySegment<byte>.System.Collections.IEnumerable.GetEnumerator
	|-ArraySegment<char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13345B0 Offset: 0x13337B0 VA: 0x1813345B0
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private void ThrowInvalidOperationIfDefault() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA450 Offset: 0x12A9650 VA: 0x1812AA450
	|-ArraySegment<byte>.ThrowInvalidOperationIfDefault
	|-ArraySegment<char>.ThrowInvalidOperationIfDefault
	|-ArraySegment<__Il2CppFullySharedGenericType>.ThrowInvalidOperationIfDefault
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA650 Offset: 0x12A9850 VA: 0x1812AA650
	|-ArraySegment<byte>..cctor
	|-ArraySegment<char>..cctor
	|-ArraySegment<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System
[Serializable]
public class ArrayTypeMismatchException : SystemException // TypeDefIndex: 2985
{
	// Methods

	// RVA: 0x176ABC0 Offset: 0x1769DC0 VA: 0x18176ABC0
	public void .ctor() { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System
public class AssemblyLoadEventArgs : EventArgs // TypeDefIndex: 2986
{
	// Fields
	[CompilerGenerated]
	private readonly Assembly <LoadedAssembly>k__BackingField; // 0x10

	// Methods

	// RVA: 0x176AC10 Offset: 0x1769E10 VA: 0x18176AC10
	public void .ctor(Assembly loadedAssembly) { }
}

// Namespace: System
[Serializable]
public sealed class AssemblyLoadEventHandler : MulticastDelegate // TypeDefIndex: 2987
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, AssemblyLoadEventArgs args) { }
}

// Namespace: System
[Serializable]
public sealed class AsyncCallback : MulticastDelegate // TypeDefIndex: 2988
{
	// Methods

	// RVA: 0x89EDF0 Offset: 0x89DFF0 VA: 0x18089EDF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(IAsyncResult ar) { }

	// RVA: 0x3FD210 Offset: 0x3FC410 VA: 0x1803FD210 Slot: 14
	public virtual IAsyncResult BeginInvoke(IAsyncResult ar, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System
[Flags]
public enum AttributeTargets // TypeDefIndex: 2989
{
	// Fields
	public int value__; // 0x0
	public const AttributeTargets Assembly = 1;
	public const AttributeTargets Module = 2;
	public const AttributeTargets Class = 4;
	public const AttributeTargets Struct = 8;
	public const AttributeTargets Enum = 16;
	public const AttributeTargets Constructor = 32;
	public const AttributeTargets Method = 64;
	public const AttributeTargets Property = 128;
	public const AttributeTargets Field = 256;
	public const AttributeTargets Event = 512;
	public const AttributeTargets Interface = 1024;
	public const AttributeTargets Parameter = 2048;
	public const AttributeTargets Delegate = 4096;
	public const AttributeTargets ReturnValue = 8192;
	public const AttributeTargets GenericParameter = 16384;
	public const AttributeTargets All = 32767;
}

// Namespace: System
[Usage(4, Inherited = True)]
[Serializable]
public sealed class AttributeUsageAttribute : Attribute // TypeDefIndex: 2990
{
	// Fields
	private AttributeTargets _attributeTarget; // 0x10
	private bool _allowMultiple; // 0x14
	private bool _inherited; // 0x15
	internal static AttributeUsageAttribute Default; // 0x0

	// Properties
	public bool AllowMultiple { get; set; }
	public bool Inherited { get; set; }

	// Methods

	// RVA: 0x176ACE0 Offset: 0x1769EE0 VA: 0x18176ACE0
	public void .ctor(AttributeTargets validOn) { }

	// RVA: 0x41AC30 Offset: 0x419E30 VA: 0x18041AC30
	public bool get_AllowMultiple() { }

	// RVA: 0x41AC60 Offset: 0x419E60 VA: 0x18041AC60
	public void set_AllowMultiple(bool value) { }

	// RVA: 0x41AC40 Offset: 0x419E40 VA: 0x18041AC40
	public bool get_Inherited() { }

	// RVA: 0x41AC70 Offset: 0x419E70 VA: 0x18041AC70
	public void set_Inherited(bool value) { }

	// RVA: 0x176AC70 Offset: 0x1769E70 VA: 0x18176AC70
	private static void .cctor() { }
}

// Namespace: System
[Serializable]
public class BadImageFormatException : SystemException // TypeDefIndex: 2991
{
	// Fields
	private string _fileName; // 0x90
	private string _fusionLog; // 0x98

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x176B1C0 Offset: 0x176A3C0 VA: 0x18176B1C0
	public void .ctor() { }

	// RVA: 0x176B160 Offset: 0x176A360 VA: 0x18176B160
	public void .ctor(string message) { }

	// RVA: 0x176B140 Offset: 0x176A340 VA: 0x18176B140
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x176B180 Offset: 0x176A380 VA: 0x18176B180
	public void .ctor(string message, string fileName) { }

	// RVA: 0x176B090 Offset: 0x176A290 VA: 0x18176B090
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x176AD10 Offset: 0x1769F10 VA: 0x18176AD10 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x176B210 Offset: 0x176A410 VA: 0x18176B210 Slot: 5
	public override string get_Message() { }

	// RVA: 0x176AE30 Offset: 0x176A030 VA: 0x18176AE30
	private void SetMessageField() { }

	// RVA: 0x176AEA0 Offset: 0x176A0A0 VA: 0x18176AEA0 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class BitConverter.<>c // TypeDefIndex: 2992
{
	// Fields
	public static readonly BitConverter.<>c <>9; // 0x0
	[TupleElementNames(new[] { "value", "startIndex", "length" })]
	public static SpanAction<char, ValueTuple<byte[], int, int>> <>9__38_0; // 0x8

	// Methods

	// RVA: 0x17891E0 Offset: 0x17883E0 VA: 0x1817891E0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1788FD0 Offset: 0x17881D0 VA: 0x181788FD0
	internal void <ToString>b__38_0(Span<char> dst, ValueTuple<byte[], int, int> state) { }
}

// Namespace: System
public static class BitConverter // TypeDefIndex: 2993
{
	// Fields
	[Intrinsic]
	public static readonly bool IsLittleEndian; // 0x0

	// Methods

	// RVA: 0x176B4D0 Offset: 0x176A6D0 VA: 0x18176B4D0
	public static byte[] GetBytes(bool value) { }

	// RVA: 0x176B2F0 Offset: 0x176A4F0 VA: 0x18176B2F0
	public static byte[] GetBytes(char value) { }

	// RVA: 0x176B290 Offset: 0x176A490 VA: 0x18176B290
	public static byte[] GetBytes(short value) { }

	// RVA: 0x176B590 Offset: 0x176A790 VA: 0x18176B590
	public static byte[] GetBytes(int value) { }

	// RVA: 0x176B470 Offset: 0x176A670 VA: 0x18176B470
	public static byte[] GetBytes(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x176B350 Offset: 0x176A550 VA: 0x18176B350
	public static byte[] GetBytes(ushort value) { }

	[CLSCompliant(False)]
	// RVA: 0x176B410 Offset: 0x176A610 VA: 0x18176B410
	public static byte[] GetBytes(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x176BC00 Offset: 0x176AE00 VA: 0x18176BC00
	public static bool TryWriteBytes(Span<byte> destination, uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x176B3B0 Offset: 0x176A5B0 VA: 0x18176B3B0
	public static byte[] GetBytes(ulong value) { }

	// RVA: 0x176B530 Offset: 0x176A730 VA: 0x18176B530
	public static byte[] GetBytes(float value) { }

	// RVA: 0x176B5F0 Offset: 0x176A7F0 VA: 0x18176B5F0
	public static byte[] GetBytes(double value) { }

	// RVA: 0x176B680 Offset: 0x176A880 VA: 0x18176B680
	public static short ToInt16(byte[] value, int startIndex) { }

	// RVA: 0x176B700 Offset: 0x176A900 VA: 0x18176B700
	public static int ToInt32(byte[] value, int startIndex) { }

	// RVA: 0x176B780 Offset: 0x176A980 VA: 0x18176B780
	public static int ToInt32(ReadOnlySpan<byte> value) { }

	// RVA: 0x176B7F0 Offset: 0x176A9F0 VA: 0x18176B7F0
	public static long ToInt64(byte[] value, int startIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x176B680 Offset: 0x176A880 VA: 0x18176B680
	public static ushort ToUInt16(byte[] value, int startIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x176B700 Offset: 0x176A900 VA: 0x18176B700
	public static uint ToUInt32(byte[] value, int startIndex) { }

	[CLSCompliant(False)]
	// RVA: 0x176B7F0 Offset: 0x176A9F0 VA: 0x18176B7F0
	public static ulong ToUInt64(byte[] value, int startIndex) { }

	// RVA: 0x176B870 Offset: 0x176AA70 VA: 0x18176B870
	public static float ToSingle(byte[] value, int startIndex) { }

	// RVA: 0x176B920 Offset: 0x176AB20 VA: 0x18176B920
	public static string ToString(byte[] value, int startIndex, int length) { }

	// RVA: 0x176B8F0 Offset: 0x176AAF0 VA: 0x18176B8F0
	public static string ToString(byte[] value) { }

	// RVA: 0x176B280 Offset: 0x176A480 VA: 0x18176B280
	public static long DoubleToInt64Bits(double value) { }

	// RVA: 0x176B660 Offset: 0x176A860 VA: 0x18176B660
	public static double Int64BitsToDouble(long value) { }

	// RVA: 0x176B670 Offset: 0x176A870 VA: 0x18176B670
	public static int SingleToInt32Bits(float value) { }

	// RVA: 0x176B650 Offset: 0x176A850 VA: 0x18176B650
	public static float Int32BitsToSingle(int value) { }

	// RVA: 0x176BC80 Offset: 0x176AE80 VA: 0x18176BC80
	private static void .cctor() { }
}

// Namespace: System
[IsReadOnly]
[Serializable]
public struct Boolean : IComparable, IConvertible, IComparable<bool>, IEquatable<bool> // TypeDefIndex: 2994
{
	// Fields
	private readonly bool m_value; // 0x0
	internal const int True = 1;
	internal const int False = 0;
	internal const string TrueLiteral = "True";
	internal const string FalseLiteral = "False";
	public static readonly string TrueString; // 0x0
	public static readonly string FalseString; // 0x8

	// Methods

	// RVA: 0x176BE80 Offset: 0x176B080 VA: 0x18176BE80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x176C690 Offset: 0x176B890 VA: 0x18176C690 Slot: 3
	public override string ToString() { }

	// RVA: 0x176C6E0 Offset: 0x176B8E0 VA: 0x18176C6E0 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x176BDE0 Offset: 0x176AFE0 VA: 0x18176BDE0 Slot: 0
	public override bool Equals(object obj) { }

	[NonVersionable]
	// RVA: 0x176BE70 Offset: 0x176B070 VA: 0x18176BE70 Slot: 23
	public bool Equals(bool obj) { }

	// RVA: 0x176BCE0 Offset: 0x176AEE0 VA: 0x18176BCE0 Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0x176BCC0 Offset: 0x176AEC0 VA: 0x18176BCC0 Slot: 22
	public int CompareTo(bool value) { }

	// RVA: 0x176BF50 Offset: 0x176B150 VA: 0x18176BF50
	public static bool Parse(string value) { }

	// RVA: 0x176BE90 Offset: 0x176B090 VA: 0x18176BE90
	public static bool Parse(ReadOnlySpan<char> value) { }

	// RVA: 0x176CD90 Offset: 0x176BF90 VA: 0x18176CD90
	public static bool TryParse(string value, out bool result) { }

	// RVA: 0x176C8F0 Offset: 0x176BAF0 VA: 0x18176C8F0
	public static bool TryParse(ReadOnlySpan<char> value, out bool result) { }

	// RVA: 0x176C760 Offset: 0x176B960 VA: 0x18176C760
	private static ReadOnlySpan<char> TrimWhiteSpaceAndNull(ReadOnlySpan<char> value) { }

	// RVA: 0xCCA530 Offset: 0xCC9730 VA: 0x180CCA530 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x176C0D0 Offset: 0x176B2D0 VA: 0x18176C0D0 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x176C130 Offset: 0x176B330 VA: 0x18176C130 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x176C450 Offset: 0x176B650 VA: 0x18176C450 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x176C0E0 Offset: 0x176B2E0 VA: 0x18176C0E0 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x176C360 Offset: 0x176B560 VA: 0x18176C360 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x176C5A0 Offset: 0x176B7A0 VA: 0x18176C5A0 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x176C3B0 Offset: 0x176B5B0 VA: 0x18176C3B0 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x176C5F0 Offset: 0x176B7F0 VA: 0x18176C5F0 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x176C400 Offset: 0x176B600 VA: 0x18176C400 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x176C640 Offset: 0x176B840 VA: 0x18176C640 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x176C4A0 Offset: 0x176B6A0 VA: 0x18176C4A0 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x176C300 Offset: 0x176B500 VA: 0x18176C300 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x176C250 Offset: 0x176B450 VA: 0x18176C250 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x176C1C0 Offset: 0x176B3C0 VA: 0x18176C1C0 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x176C500 Offset: 0x176B700 VA: 0x18176C500 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x176CE50 Offset: 0x176C050 VA: 0x18176CE50
	private static void .cctor() { }
}

// Namespace: System
[IsReadOnly]
[Serializable]
public struct Byte : IComparable, IConvertible, IFormattable, IComparable<byte>, IEquatable<byte>, ISpanFormattable // TypeDefIndex: 2995
{
	// Fields
	private readonly byte m_value; // 0x0
	public const byte MaxValue = 255;
	public const byte MinValue = 0;

	// Methods

	// RVA: 0x176CED0 Offset: 0x176C0D0 VA: 0x18176CED0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x176CEC0 Offset: 0x176C0C0 VA: 0x18176CEC0 Slot: 23
	public int CompareTo(byte value) { }

	// RVA: 0x176CFB0 Offset: 0x176C1B0 VA: 0x18176CFB0 Slot: 0
	public override bool Equals(object obj) { }

	[NonVersionable]
	// RVA: 0x176BE70 Offset: 0x176B070 VA: 0x18176BE70 Slot: 24
	public bool Equals(byte obj) { }

	// RVA: 0x41D600 Offset: 0x41C800 VA: 0x18041D600 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x176D230 Offset: 0x176C430 VA: 0x18176D230
	public static byte Parse(string s, IFormatProvider provider) { }

	// RVA: 0x176D170 Offset: 0x176C370 VA: 0x18176D170
	public static byte Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x176D040 Offset: 0x176C240 VA: 0x18176D040
	private static byte Parse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x176DD60 Offset: 0x176CF60 VA: 0x18176DD60
	public static bool TryParse(string s, out byte result) { }

	// RVA: 0x176DC50 Offset: 0x176CE50 VA: 0x18176DC50
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out byte result) { }

	// RVA: 0x176DBA0 Offset: 0x176CDA0 VA: 0x18176DBA0
	private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out byte result) { }

	// RVA: 0x176DA70 Offset: 0x176CC70 VA: 0x18176DA70 Slot: 3
	public override string ToString() { }

	// RVA: 0x176D9B0 Offset: 0x176CBB0 VA: 0x18176D9B0
	public string ToString(string format) { }

	// RVA: 0x176D850 Offset: 0x176CA50 VA: 0x18176D850 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x176D8E0 Offset: 0x176CAE0 VA: 0x18176D8E0 Slot: 22
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x176DAF0 Offset: 0x176CCF0 VA: 0x18176DAF0 Slot: 25
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x16F8530 Offset: 0x16F7730 VA: 0x1816F8530 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x176D2E0 Offset: 0x176C4E0 VA: 0x18176D2E0 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x176D330 Offset: 0x176C530 VA: 0x18176D330 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x176D5F0 Offset: 0x176C7F0 VA: 0x18176D5F0 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x41D600 Offset: 0x41C800 VA: 0x18041D600 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x176D500 Offset: 0x176C700 VA: 0x18176D500 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x176D760 Offset: 0x176C960 VA: 0x18176D760 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x176D550 Offset: 0x176C750 VA: 0x18176D550 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x176D7B0 Offset: 0x176C9B0 VA: 0x18176D7B0 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x176D5A0 Offset: 0x176C7A0 VA: 0x18176D5A0 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x176D800 Offset: 0x176CA00 VA: 0x18176D800 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x176D670 Offset: 0x176C870 VA: 0x18176D670 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x176D4B0 Offset: 0x176C6B0 VA: 0x18176D4B0 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x176D410 Offset: 0x176C610 VA: 0x18176D410 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x176D380 Offset: 0x176C580 VA: 0x18176D380 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x176D6C0 Offset: 0x176C8C0 VA: 0x18176D6C0 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

// Namespace: System
[Usage(32767, Inherited = True, AllowMultiple = False)]
[Serializable]
public sealed class CLSCompliantAttribute : Attribute // TypeDefIndex: 2996
{
	// Fields
	private bool _compliant; // 0x10

	// Methods

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool isCompliant) { }
}

// Namespace: System
[IsReadOnly]
[Serializable]
public struct Char : IComparable, IComparable<char>, IEquatable<char>, IConvertible // TypeDefIndex: 2997
{
	// Fields
	private readonly char m_value; // 0x0
	public const char MaxValue = '\xffff';
	public const char MinValue = '\x0';
	private static readonly byte[] s_categoryForLatin1; // 0x0
	internal const int UNICODE_PLANE00_END = 65535;
	internal const int UNICODE_PLANE01_START = 65536;
	internal const int UNICODE_PLANE16_END = 1114111;
	internal const int HIGH_SURROGATE_START = 55296;
	internal const int LOW_SURROGATE_END = 57343;

	// Methods

	// RVA: 0x176EA40 Offset: 0x176DC40 VA: 0x18176EA40
	private static bool IsLatin1(char ch) { }

	// RVA: 0x176E7D0 Offset: 0x176D9D0 VA: 0x18176E7D0
	private static bool IsAscii(char ch) { }

	// RVA: 0x176E580 Offset: 0x176D780 VA: 0x18176E580
	private static UnicodeCategory GetLatin1UnicodeCategory(char ch) { }

	// RVA: 0x176E570 Offset: 0x176D770 VA: 0x18176E570 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x176E4D0 Offset: 0x176D6D0 VA: 0x18176E4D0 Slot: 0
	public override bool Equals(object obj) { }

	[NonVersionable]
	// RVA: 0x176E560 Offset: 0x176D760 VA: 0x18176E560 Slot: 6
	public bool Equals(char obj) { }

	// RVA: 0x176E170 Offset: 0x176D370 VA: 0x18176E170 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x176E160 Offset: 0x176D360 VA: 0x18176E160 Slot: 5
	public int CompareTo(char value) { }

	// RVA: 0x17700C0 Offset: 0x176F2C0 VA: 0x1817700C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1770110 Offset: 0x176F310 VA: 0x181770110 Slot: 22
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1770160 Offset: 0x176F360 VA: 0x181770160
	public static string ToString(char c) { }

	// RVA: 0x176F7C0 Offset: 0x176E9C0 VA: 0x18176F7C0
	public static char Parse(string s) { }

	// RVA: 0x1770330 Offset: 0x176F530 VA: 0x181770330
	public static bool TryParse(string s, out char result) { }

	// RVA: 0x176E870 Offset: 0x176DA70 VA: 0x18176E870
	public static bool IsDigit(char c) { }

	// RVA: 0x176E120 Offset: 0x176D320 VA: 0x18176E120
	internal static bool CheckLetter(UnicodeCategory uc) { }

	// RVA: 0x176EB00 Offset: 0x176DD00 VA: 0x18176EB00
	public static bool IsLetter(char c) { }

	// RVA: 0x176F570 Offset: 0x176E770 VA: 0x18176F570
	private static bool IsWhiteSpaceLatin1(char c) { }

	// RVA: 0x176F5A0 Offset: 0x176E7A0 VA: 0x18176F5A0
	public static bool IsWhiteSpace(char c) { }

	// RVA: 0x176F4B0 Offset: 0x176E6B0 VA: 0x18176F4B0
	public static bool IsUpper(char c) { }

	// RVA: 0x176EDC0 Offset: 0x176DFC0 VA: 0x18176EDC0
	public static bool IsLower(char c) { }

	// RVA: 0x176E130 Offset: 0x176D330 VA: 0x18176E130
	internal static bool CheckPunctuation(UnicodeCategory uc) { }

	// RVA: 0x176F110 Offset: 0x176E310 VA: 0x18176F110
	public static bool IsPunctuation(char c) { }

	// RVA: 0x176E110 Offset: 0x176D310 VA: 0x18176E110
	internal static bool CheckLetterOrDigit(UnicodeCategory uc) { }

	// RVA: 0x176EA50 Offset: 0x176DC50 VA: 0x18176EA50
	public static bool IsLetterOrDigit(char c) { }

	// RVA: 0x1770290 Offset: 0x176F490 VA: 0x181770290
	public static char ToUpper(char c, CultureInfo culture) { }

	// RVA: 0x1770200 Offset: 0x176F400 VA: 0x181770200
	public static char ToUpper(char c) { }

	// RVA: 0x1770170 Offset: 0x176F370 VA: 0x181770170
	public static char ToUpperInvariant(char c) { }

	// RVA: 0x176FF90 Offset: 0x176F190 VA: 0x18176FF90
	public static char ToLower(char c, CultureInfo culture) { }

	// RVA: 0x1770030 Offset: 0x176F230 VA: 0x181770030
	public static char ToLower(char c) { }

	// RVA: 0x176FF00 Offset: 0x176F100 VA: 0x18176FF00
	public static char ToLowerInvariant(char c) { }

	// RVA: 0x68EEE0 Offset: 0x68E0E0 VA: 0x18068EEE0 Slot: 7
	public TypeCode GetTypeCode() { }

	// RVA: 0x176F880 Offset: 0x176EA80 VA: 0x18176F880 Slot: 8
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0DF0 VA: 0x1804D1BF0 Slot: 9
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x176FC60 Offset: 0x176EE60 VA: 0x18176FC60 Slot: 10
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x176F910 Offset: 0x176EB10 VA: 0x18176F910 Slot: 11
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x176FB40 Offset: 0x176ED40 VA: 0x18176FB40 Slot: 12
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x176FE10 Offset: 0x176F010 VA: 0x18176FE10 Slot: 13
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x176FBC0 Offset: 0x176EDC0 VA: 0x18176FBC0 Slot: 14
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x176FE60 Offset: 0x176F060 VA: 0x18176FE60 Slot: 15
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x176FC10 Offset: 0x176EE10 VA: 0x18176FC10 Slot: 16
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x176FEB0 Offset: 0x176F0B0 VA: 0x18176FEB0 Slot: 17
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x176FCE0 Offset: 0x176EEE0 VA: 0x18176FCE0 Slot: 18
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x176FAB0 Offset: 0x176ECB0 VA: 0x18176FAB0 Slot: 19
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x176FA20 Offset: 0x176EC20 VA: 0x18176FA20 Slot: 20
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x176F990 Offset: 0x176EB90 VA: 0x18176F990 Slot: 21
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x176FD70 Offset: 0x176EF70 VA: 0x18176FD70 Slot: 23
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x176E7E0 Offset: 0x176D9E0 VA: 0x18176E7E0
	public static bool IsControl(char c) { }

	// RVA: 0x176EBE0 Offset: 0x176DDE0 VA: 0x18176EBE0
	public static bool IsLetter(string s, int index) { }

	// RVA: 0x6910D0 Offset: 0x6902D0 VA: 0x1806910D0
	internal static bool CheckNumber(UnicodeCategory uc) { }

	// RVA: 0x176EE80 Offset: 0x176E080 VA: 0x18176EE80
	public static bool IsNumber(char c) { }

	// RVA: 0x176EF60 Offset: 0x176E160 VA: 0x18176EF60
	public static bool IsNumber(string s, int index) { }

	// RVA: 0x176E140 Offset: 0x176D340 VA: 0x18176E140
	internal static bool CheckSeparator(UnicodeCategory uc) { }

	// RVA: 0x176F1C0 Offset: 0x176E3C0 VA: 0x18176F1C0
	private static bool IsSeparatorLatin1(char c) { }

	// RVA: 0x176F1E0 Offset: 0x176E3E0 VA: 0x18176F1E0
	public static bool IsSeparator(char c) { }

	// RVA: 0x176F3E0 Offset: 0x176E5E0 VA: 0x18176F3E0
	public static bool IsSurrogate(char c) { }

	// RVA: 0x176F2C0 Offset: 0x176E4C0 VA: 0x18176F2C0
	public static bool IsSurrogate(string s, int index) { }

	// RVA: 0x176E150 Offset: 0x176D350 VA: 0x18176E150
	internal static bool CheckSymbol(UnicodeCategory uc) { }

	// RVA: 0x176F400 Offset: 0x176E600 VA: 0x18176F400
	public static bool IsSymbol(char c) { }

	// RVA: 0x176F640 Offset: 0x176E840 VA: 0x18176F640
	public static bool IsWhiteSpace(string s, int index) { }

	// RVA: 0x176E5F0 Offset: 0x176D7F0 VA: 0x18176E5F0
	public static UnicodeCategory GetUnicodeCategory(char c) { }

	// RVA: 0x176E670 Offset: 0x176D870 VA: 0x18176E670
	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	// RVA: 0x176EA20 Offset: 0x176DC20 VA: 0x18176EA20
	public static bool IsHighSurrogate(char c) { }

	// RVA: 0x176E8F0 Offset: 0x176DAF0 VA: 0x18176E8F0
	public static bool IsHighSurrogate(string s, int index) { }

	// RVA: 0x176EDA0 Offset: 0x176DFA0 VA: 0x18176EDA0
	public static bool IsLowSurrogate(char c) { }

	// RVA: 0x176F290 Offset: 0x176E490 VA: 0x18176F290
	public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate) { }

	// RVA: 0x176E250 Offset: 0x176D450 VA: 0x18176E250
	public static string ConvertFromUtf32(int utf32) { }

	// RVA: 0x176E380 Offset: 0x176D580 VA: 0x18176E380
	public static int ConvertToUtf32(char highSurrogate, char lowSurrogate) { }

	// RVA: 0x1770360 Offset: 0x176F560 VA: 0x181770360
	private static void .cctor() { }
}

// Namespace: System
[Serializable]
public sealed class CharEnumerator : IEnumerator, IEnumerator<char>, IDisposable, ICloneable // TypeDefIndex: 2998
{
	// Fields
	private string _str; // 0x10
	private int _index; // 0x18
	private char _currentElement; // 0x1C

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public char Current { get; }

	// Methods

	// RVA: 0x176DFE0 Offset: 0x176D1E0 VA: 0x18176DFE0
	internal void .ctor(string str) { }

	// RVA: 0x17256E0 Offset: 0x17248E0 VA: 0x1817256E0 Slot: 9
	public object Clone() { }

	// RVA: 0x176DE80 Offset: 0x176D080 VA: 0x18176DE80 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x176DE60 Offset: 0x176D060 VA: 0x18176DE60 Slot: 8
	public void Dispose() { }

	// RVA: 0x176DEE0 Offset: 0x176D0E0 VA: 0x18176DEE0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x176E040 Offset: 0x176D240 VA: 0x18176E040 Slot: 7
	public char get_Current() { }

	// RVA: 0x176DED0 Offset: 0x176D0D0 VA: 0x18176DED0 Slot: 6
	public void Reset() { }

	// RVA: 0x176E010 Offset: 0x176D210 VA: 0x18176E010
	internal void .ctor() { }
}

// Namespace: System
[Extension]
public static class Convert // TypeDefIndex: 2999
{
	// Fields
	private static readonly sbyte[] s_decodingMap; // 0x0
	internal static readonly Type[] ConvertTypes; // 0x8
	private static readonly Type EnumType; // 0x10
	internal static readonly char[] base64Table; // 0x18
	public static readonly object DBNull; // 0x20

	// Methods

	// RVA: 0x17784A0 Offset: 0x17776A0 VA: 0x1817784A0
	private static bool TryDecodeFromUtf16(ReadOnlySpan<char> utf16, Span<byte> bytes, out int consumed, out int written) { }

	// RVA: 0x17717D0 Offset: 0x17709D0 VA: 0x1817717D0
	private static int Decode(ref char encodedChars, ref sbyte decodingMap) { }

	// RVA: 0x1778E60 Offset: 0x1778060 VA: 0x181778E60
	private static void WriteThreeLowOrderBytes(ref byte destination, int value) { }

	// RVA: 0x17728D0 Offset: 0x1771AD0 VA: 0x1817728D0
	public static TypeCode GetTypeCode(object value) { }

	// RVA: 0x1770DF0 Offset: 0x176FFF0 VA: 0x181770DF0
	public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider) { }

	// RVA: 0x1771830 Offset: 0x1770A30 VA: 0x181771830
	internal static object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider) { }

	// RVA: 0x17703E0 Offset: 0x176F5E0 VA: 0x1817703E0
	public static object ChangeType(object value, Type conversionType) { }

	// RVA: 0x1770480 Offset: 0x176F680 VA: 0x181770480
	public static object ChangeType(object value, Type conversionType, IFormatProvider provider) { }

	// RVA: 0x1772A30 Offset: 0x1771C30 VA: 0x181772A30
	private static void ThrowCharOverflowException() { }

	// RVA: 0x17729E0 Offset: 0x1771BE0 VA: 0x1817729E0
	private static void ThrowByteOverflowException() { }

	// RVA: 0x1772B70 Offset: 0x1771D70 VA: 0x181772B70
	private static void ThrowSByteOverflowException() { }

	// RVA: 0x1772A80 Offset: 0x1771C80 VA: 0x181772A80
	private static void ThrowInt16OverflowException() { }

	// RVA: 0x1772BC0 Offset: 0x1771DC0 VA: 0x181772BC0
	private static void ThrowUInt16OverflowException() { }

	// RVA: 0x1772AD0 Offset: 0x1771CD0 VA: 0x181772AD0
	private static void ThrowInt32OverflowException() { }

	// RVA: 0x1772C10 Offset: 0x1771E10 VA: 0x181772C10
	private static void ThrowUInt32OverflowException() { }

	// RVA: 0x1772B20 Offset: 0x1771D20 VA: 0x181772B20
	private static void ThrowInt64OverflowException() { }

	// RVA: 0x1772C60 Offset: 0x1771E60 VA: 0x181772C60
	private static void ThrowUInt64OverflowException() { }

	// RVA: 0x17738C0 Offset: 0x1772AC0 VA: 0x1817738C0
	public static bool ToBoolean(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x884ED0 Offset: 0x8840D0 VA: 0x180884ED0
	public static bool ToBoolean(sbyte value) { }

	// RVA: 0x884ED0 Offset: 0x8840D0 VA: 0x180884ED0
	public static bool ToBoolean(byte value) { }

	// RVA: 0x1773990 Offset: 0x1772B90 VA: 0x181773990
	public static bool ToBoolean(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x1773990 Offset: 0x1772B90 VA: 0x181773990
	public static bool ToBoolean(ushort value) { }

	// RVA: 0x1773970 Offset: 0x1772B70 VA: 0x181773970
	public static bool ToBoolean(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1773970 Offset: 0x1772B70 VA: 0x181773970
	public static bool ToBoolean(uint value) { }

	// RVA: 0x17738B0 Offset: 0x1772AB0 VA: 0x1817738B0
	public static bool ToBoolean(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x17738B0 Offset: 0x1772AB0 VA: 0x1817738B0
	public static bool ToBoolean(ulong value) { }

	// RVA: 0x1773A40 Offset: 0x1772C40 VA: 0x181773A40
	public static bool ToBoolean(string value, IFormatProvider provider) { }

	// RVA: 0x1773980 Offset: 0x1772B80 VA: 0x181773980
	public static bool ToBoolean(float value) { }

	// RVA: 0x17739A0 Offset: 0x1772BA0 VA: 0x1817739A0
	public static bool ToBoolean(double value) { }

	// RVA: 0x17739C0 Offset: 0x1772BC0 VA: 0x1817739C0
	public static bool ToBoolean(Decimal value) { }

	// RVA: 0x17746C0 Offset: 0x17738C0 VA: 0x1817746C0
	public static char ToChar(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x1774670 Offset: 0x1773870 VA: 0x181774670
	public static char ToChar(sbyte value) { }

	// RVA: 0x9375A0 Offset: 0x9367A0 VA: 0x1809375A0
	public static char ToChar(byte value) { }

	// RVA: 0x17745D0 Offset: 0x17737D0 VA: 0x1817745D0
	public static char ToChar(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x937680 Offset: 0x936880 VA: 0x180937680
	public static char ToChar(ushort value) { }

	// RVA: 0x1774770 Offset: 0x1773970 VA: 0x181774770
	public static char ToChar(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1774620 Offset: 0x1773820 VA: 0x181774620
	public static char ToChar(uint value) { }

	// RVA: 0x1774490 Offset: 0x1773690 VA: 0x181774490
	public static char ToChar(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1774380 Offset: 0x1773580 VA: 0x181774380
	public static char ToChar(ulong value) { }

	// RVA: 0x17744E0 Offset: 0x17736E0 VA: 0x1817744E0
	public static char ToChar(string value) { }

	// RVA: 0x17743D0 Offset: 0x17735D0 VA: 0x1817743D0
	public static char ToChar(string value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x1776510 Offset: 0x1775710 VA: 0x181776510
	public static sbyte ToSByte(object value) { }

	[CLSCompliant(False)]
	// RVA: 0x1776A80 Offset: 0x1775C80 VA: 0x181776A80
	public static sbyte ToSByte(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x884ED0 Offset: 0x8840D0 VA: 0x180884ED0
	public static sbyte ToSByte(bool value) { }

	[CLSCompliant(False)]
	// RVA: 0x1776990 Offset: 0x1775B90 VA: 0x181776990
	public static sbyte ToSByte(char value) { }

	[CLSCompliant(False)]
	// RVA: 0x1776A30 Offset: 0x1775C30 VA: 0x181776A30
	public static sbyte ToSByte(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x17768E0 Offset: 0x1775AE0 VA: 0x1817768E0
	public static sbyte ToSByte(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x17766D0 Offset: 0x17758D0 VA: 0x1817766D0
	public static sbyte ToSByte(ushort value) { }

	[CLSCompliant(False)]
	// RVA: 0x1776940 Offset: 0x1775B40 VA: 0x181776940
	public static sbyte ToSByte(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x17765B0 Offset: 0x17757B0 VA: 0x1817765B0
	public static sbyte ToSByte(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x1776600 Offset: 0x1775800 VA: 0x181776600
	public static sbyte ToSByte(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x17769E0 Offset: 0x1775BE0 VA: 0x1817769E0
	public static sbyte ToSByte(ulong value) { }

	[CLSCompliant(False)]
	// RVA: 0x1776660 Offset: 0x1775860 VA: 0x181776660
	public static sbyte ToSByte(float value) { }

	[CLSCompliant(False)]
	// RVA: 0x1776470 Offset: 0x1775670 VA: 0x181776470
	public static sbyte ToSByte(double value) { }

	[CLSCompliant(False)]
	// RVA: 0x1776720 Offset: 0x1775920 VA: 0x181776720
	public static sbyte ToSByte(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x17766C0 Offset: 0x17758C0 VA: 0x1817766C0
	public static sbyte ToSByte(string value, IFormatProvider provider) { }

	// RVA: 0x1774210 Offset: 0x1773410 VA: 0x181774210
	public static byte ToByte(object value) { }

	// RVA: 0x1773CB0 Offset: 0x1772EB0 VA: 0x181773CB0
	public static byte ToByte(object value, IFormatProvider provider) { }

	// RVA: 0x884ED0 Offset: 0x8840D0 VA: 0x180884ED0
	public static byte ToByte(bool value) { }

	// RVA: 0x1773ED0 Offset: 0x17730D0 VA: 0x181773ED0
	public static byte ToByte(char value) { }

	[CLSCompliant(False)]
	// RVA: 0x1774170 Offset: 0x1773370 VA: 0x181774170
	public static byte ToByte(sbyte value) { }

	// RVA: 0x1773C00 Offset: 0x1772E00 VA: 0x181773C00
	public static byte ToByte(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x17741C0 Offset: 0x17733C0 VA: 0x1817741C0
	public static byte ToByte(ushort value) { }

	// RVA: 0x1773F20 Offset: 0x1773120 VA: 0x181773F20
	public static byte ToByte(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1774010 Offset: 0x1773210 VA: 0x181774010
	public static byte ToByte(uint value) { }

	// RVA: 0x1773E80 Offset: 0x1773080 VA: 0x181773E80
	public static byte ToByte(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1773BB0 Offset: 0x1772DB0 VA: 0x181773BB0
	public static byte ToByte(ulong value) { }

	// RVA: 0x1773C50 Offset: 0x1772E50 VA: 0x181773C50
	public static byte ToByte(float value) { }

	// RVA: 0x1773DE0 Offset: 0x1772FE0 VA: 0x181773DE0
	public static byte ToByte(double value) { }

	// RVA: 0x1773D60 Offset: 0x1772F60 VA: 0x181773D60
	public static byte ToByte(Decimal value) { }

	// RVA: 0x17742B0 Offset: 0x17734B0 VA: 0x1817742B0
	public static byte ToByte(string value) { }

	// RVA: 0x1773F70 Offset: 0x1773170 VA: 0x181773F70
	public static byte ToByte(string value, IFormatProvider provider) { }

	// RVA: 0x17757F0 Offset: 0x17749F0 VA: 0x1817757F0
	public static short ToInt16(object value) { }

	// RVA: 0x1775400 Offset: 0x1774600 VA: 0x181775400
	public static short ToInt16(object value, IFormatProvider provider) { }

	// RVA: 0x17753A0 Offset: 0x17745A0 VA: 0x1817753A0
	public static short ToInt16(bool value) { }

	// RVA: 0x1775710 Offset: 0x1774910 VA: 0x181775710
	public static short ToInt16(char value) { }

	[CLSCompliant(False)]
	// RVA: 0x1775760 Offset: 0x1774960 VA: 0x181775760
	public static short ToInt16(sbyte value) { }

	// RVA: 0x9375A0 Offset: 0x9367A0 VA: 0x1809375A0
	public static short ToInt16(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x17753B0 Offset: 0x17745B0 VA: 0x1817753B0
	public static short ToInt16(ushort value) { }

	// RVA: 0x1775890 Offset: 0x1774A90 VA: 0x181775890
	public static short ToInt16(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x17758E0 Offset: 0x1774AE0 VA: 0x1817758E0
	public static short ToInt16(uint value) { }

	// RVA: 0x17754B0 Offset: 0x17746B0 VA: 0x1817754B0
	public static short ToInt16(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1775510 Offset: 0x1774710 VA: 0x181775510
	public static short ToInt16(ulong value) { }

	// RVA: 0x1775790 Offset: 0x1774990 VA: 0x181775790
	public static short ToInt16(float value) { }

	// RVA: 0x1775930 Offset: 0x1774B30 VA: 0x181775930
	public static short ToInt16(double value) { }

	// RVA: 0x1775690 Offset: 0x1774890 VA: 0x181775690
	public static short ToInt16(Decimal value) { }

	// RVA: 0x1775770 Offset: 0x1774970 VA: 0x181775770
	public static short ToInt16(string value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x1777740 Offset: 0x1776940 VA: 0x181777740
	public static ushort ToUInt16(object value) { }

	[CLSCompliant(False)]
	// RVA: 0x1777690 Offset: 0x1776890 VA: 0x181777690
	public static ushort ToUInt16(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x17753A0 Offset: 0x17745A0 VA: 0x1817753A0
	public static ushort ToUInt16(bool value) { }

	[CLSCompliant(False)]
	// RVA: 0x937680 Offset: 0x936880 VA: 0x180937680
	public static ushort ToUInt16(char value) { }

	[CLSCompliant(False)]
	// RVA: 0x1777500 Offset: 0x1776700 VA: 0x181777500
	public static ushort ToUInt16(sbyte value) { }

	[CLSCompliant(False)]
	// RVA: 0x9375A0 Offset: 0x9367A0 VA: 0x1809375A0
	public static ushort ToUInt16(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x1777640 Offset: 0x1776840 VA: 0x181777640
	public static ushort ToUInt16(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x17777E0 Offset: 0x17769E0 VA: 0x1817777E0
	public static ushort ToUInt16(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1777880 Offset: 0x1776A80 VA: 0x181777880
	public static ushort ToUInt16(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x17775D0 Offset: 0x17767D0 VA: 0x1817775D0
	public static ushort ToUInt16(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1777830 Offset: 0x1776A30 VA: 0x181777830
	public static ushort ToUInt16(ulong value) { }

	[CLSCompliant(False)]
	// RVA: 0x1777970 Offset: 0x1776B70 VA: 0x181777970
	public static ushort ToUInt16(float value) { }

	[CLSCompliant(False)]
	// RVA: 0x17778D0 Offset: 0x1776AD0 VA: 0x1817778D0
	public static ushort ToUInt16(double value) { }

	[CLSCompliant(False)]
	// RVA: 0x1777550 Offset: 0x1776750 VA: 0x181777550
	public static ushort ToUInt16(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x1777620 Offset: 0x1776820 VA: 0x181777620
	public static ushort ToUInt16(string value, IFormatProvider provider) { }

	// RVA: 0x1775D20 Offset: 0x1774F20 VA: 0x181775D20
	public static int ToInt32(object value) { }

	// RVA: 0x1775B60 Offset: 0x1774D60 VA: 0x181775B60
	public static int ToInt32(object value, IFormatProvider provider) { }

	// RVA: 0x17753A0 Offset: 0x17745A0 VA: 0x1817753A0
	public static int ToInt32(bool value) { }

	// RVA: 0x937680 Offset: 0x936880 VA: 0x180937680
	public static int ToInt32(char value) { }

	// RVA: 0x9375A0 Offset: 0x9367A0 VA: 0x1809375A0
	public static int ToInt32(byte value) { }

	// RVA: 0x1775D10 Offset: 0x1774F10 VA: 0x181775D10
	public static int ToInt32(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x937680 Offset: 0x936880 VA: 0x180937680
	public static int ToInt32(ushort value) { }

	[CLSCompliant(False)]
	// RVA: 0x1775B10 Offset: 0x1774D10 VA: 0x181775B10
	public static int ToInt32(uint value) { }

	// RVA: 0x937660 Offset: 0x936860 VA: 0x180937660
	public static int ToInt32(int value) { }

	// RVA: 0x1775DC0 Offset: 0x1774FC0 VA: 0x181775DC0
	public static int ToInt32(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1775A60 Offset: 0x1774C60 VA: 0x181775A60
	public static int ToInt32(ulong value) { }

	// RVA: 0x1775AB0 Offset: 0x1774CB0 VA: 0x181775AB0
	public static int ToInt32(float value) { }

	// RVA: 0x1775C10 Offset: 0x1774E10 VA: 0x181775C10
	public static int ToInt32(double value) { }

	// RVA: 0x1775E20 Offset: 0x1775020 VA: 0x181775E20
	public static int ToInt32(Decimal value) { }

	// RVA: 0x17759D0 Offset: 0x1774BD0 VA: 0x1817759D0
	public static int ToInt32(string value) { }

	// RVA: 0x1775A40 Offset: 0x1774C40 VA: 0x181775A40
	public static int ToInt32(string value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x1777B20 Offset: 0x1776D20 VA: 0x181777B20
	public static uint ToUInt32(object value) { }

	[CLSCompliant(False)]
	// RVA: 0x1777E30 Offset: 0x1777030 VA: 0x181777E30
	public static uint ToUInt32(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x17753A0 Offset: 0x17745A0 VA: 0x1817753A0
	public static uint ToUInt32(bool value) { }

	[CLSCompliant(False)]
	// RVA: 0x937680 Offset: 0x936880 VA: 0x180937680
	public static uint ToUInt32(char value) { }

	[CLSCompliant(False)]
	// RVA: 0x1777DC0 Offset: 0x1776FC0 VA: 0x181777DC0
	public static uint ToUInt32(sbyte value) { }

	[CLSCompliant(False)]
	// RVA: 0x9375A0 Offset: 0x9367A0 VA: 0x1809375A0
	public static uint ToUInt32(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x17779D0 Offset: 0x1776BD0 VA: 0x1817779D0
	public static uint ToUInt32(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x937680 Offset: 0x936880 VA: 0x180937680
	public static uint ToUInt32(ushort value) { }

	[CLSCompliant(False)]
	// RVA: 0x1777AD0 Offset: 0x1776CD0 VA: 0x181777AD0
	public static uint ToUInt32(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1777CB0 Offset: 0x1776EB0 VA: 0x181777CB0
	public static uint ToUInt32(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1777A80 Offset: 0x1776C80 VA: 0x181777A80
	public static uint ToUInt32(ulong value) { }

	[CLSCompliant(False)]
	// RVA: 0x1777A20 Offset: 0x1776C20 VA: 0x181777A20
	public static uint ToUInt32(float value) { }

	[CLSCompliant(False)]
	// RVA: 0x1777D00 Offset: 0x1776F00 VA: 0x181777D00
	public static uint ToUInt32(double value) { }

	[CLSCompliant(False)]
	// RVA: 0x1777EE0 Offset: 0x17770E0 VA: 0x181777EE0
	public static uint ToUInt32(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x1777E10 Offset: 0x1777010 VA: 0x181777E10
	public static uint ToUInt32(string value, IFormatProvider provider) { }

	// RVA: 0x1776350 Offset: 0x1775550 VA: 0x181776350
	public static long ToInt64(object value) { }

	// RVA: 0x1776170 Offset: 0x1775370 VA: 0x181776170
	public static long ToInt64(object value, IFormatProvider provider) { }

	// RVA: 0x1776460 Offset: 0x1775660 VA: 0x181776460
	public static long ToInt64(bool value) { }

	// RVA: 0x937680 Offset: 0x936880 VA: 0x180937680
	public static long ToInt64(char value) { }

	[CLSCompliant(False)]
	// RVA: 0x1776250 Offset: 0x1775450 VA: 0x181776250
	public static long ToInt64(sbyte value) { }

	// RVA: 0x9375A0 Offset: 0x9367A0 VA: 0x1809375A0
	public static long ToInt64(byte value) { }

	// RVA: 0x1776160 Offset: 0x1775360 VA: 0x181776160
	public static long ToInt64(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x937680 Offset: 0x936880 VA: 0x180937680
	public static long ToInt64(ushort value) { }

	// RVA: 0x1776240 Offset: 0x1775440 VA: 0x181776240
	public static long ToInt64(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x937660 Offset: 0x936860 VA: 0x180937660
	public static long ToInt64(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x1776260 Offset: 0x1775460 VA: 0x181776260
	public static long ToInt64(ulong value) { }

	// RVA: 0x1776080 Offset: 0x1775280 VA: 0x181776080
	public static long ToInt64(float value) { }

	// RVA: 0x17762C0 Offset: 0x17754C0 VA: 0x1817762C0
	public static long ToInt64(double value) { }

	// RVA: 0x17760E0 Offset: 0x17752E0 VA: 0x1817760E0
	public static long ToInt64(Decimal value) { }

	// RVA: 0x17763F0 Offset: 0x17755F0 VA: 0x1817763F0
	public static long ToInt64(string value) { }

	// RVA: 0x1776220 Offset: 0x1775420 VA: 0x181776220
	public static long ToInt64(string value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x1778190 Offset: 0x1777390 VA: 0x181778190
	public static ulong ToUInt64(object value) { }

	[CLSCompliant(False)]
	// RVA: 0x17780E0 Offset: 0x17772E0 VA: 0x1817780E0
	public static ulong ToUInt64(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x17753A0 Offset: 0x17745A0 VA: 0x1817753A0
	public static ulong ToUInt64(bool value) { }

	[CLSCompliant(False)]
	// RVA: 0x937680 Offset: 0x936880 VA: 0x180937680
	public static ulong ToUInt64(char value) { }

	[CLSCompliant(False)]
	// RVA: 0x1777F60 Offset: 0x1777160 VA: 0x181777F60
	public static ulong ToUInt64(sbyte value) { }

	[CLSCompliant(False)]
	// RVA: 0x9375A0 Offset: 0x9367A0 VA: 0x1809375A0
	public static ulong ToUInt64(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x1778310 Offset: 0x1777510 VA: 0x181778310
	public static ulong ToUInt64(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x937680 Offset: 0x936880 VA: 0x180937680
	public static ulong ToUInt64(ushort value) { }

	[CLSCompliant(False)]
	// RVA: 0x1777FD0 Offset: 0x17771D0 VA: 0x181777FD0
	public static ulong ToUInt64(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x937660 Offset: 0x936860 VA: 0x180937660
	public static ulong ToUInt64(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x1778360 Offset: 0x1777560 VA: 0x181778360
	public static ulong ToUInt64(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1778230 Offset: 0x1777430 VA: 0x181778230
	public static ulong ToUInt64(float value) { }

	[CLSCompliant(False)]
	// RVA: 0x1778020 Offset: 0x1777220 VA: 0x181778020
	public static ulong ToUInt64(double value) { }

	[CLSCompliant(False)]
	// RVA: 0x1778290 Offset: 0x1777490 VA: 0x181778290
	public static ulong ToUInt64(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x1777FB0 Offset: 0x17771B0 VA: 0x181777FB0
	public static ulong ToUInt64(string value, IFormatProvider provider) { }

	// RVA: 0x1776B80 Offset: 0x1775D80 VA: 0x181776B80
	public static float ToSingle(object value) { }

	// RVA: 0x1776D00 Offset: 0x1775F00 VA: 0x181776D00
	public static float ToSingle(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x1776C20 Offset: 0x1775E20 VA: 0x181776C20
	public static float ToSingle(sbyte value) { }

	// RVA: 0x1776B40 Offset: 0x1775D40 VA: 0x181776B40
	public static float ToSingle(byte value) { }

	// RVA: 0x1776B50 Offset: 0x1775D50 VA: 0x181776B50
	public static float ToSingle(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x1776B30 Offset: 0x1775D30 VA: 0x181776B30
	public static float ToSingle(ushort value) { }

	// RVA: 0x1776CF0 Offset: 0x1775EF0 VA: 0x181776CF0
	public static float ToSingle(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1776B60 Offset: 0x1775D60 VA: 0x181776B60
	public static float ToSingle(uint value) { }

	// RVA: 0x1776B70 Offset: 0x1775D70 VA: 0x181776B70
	public static float ToSingle(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1776C50 Offset: 0x1775E50 VA: 0x181776C50
	public static float ToSingle(ulong value) { }

	// RVA: 0x1776DB0 Offset: 0x1775FB0 VA: 0x181776DB0
	public static float ToSingle(double value) { }

	// RVA: 0x1776C80 Offset: 0x1775E80 VA: 0x181776C80
	public static float ToSingle(Decimal value) { }

	// RVA: 0x1776C30 Offset: 0x1775E30 VA: 0x181776C30
	public static float ToSingle(string value, IFormatProvider provider) { }

	// RVA: 0x1776CE0 Offset: 0x1775EE0 VA: 0x181776CE0
	public static float ToSingle(bool value) { }

	// RVA: 0x1775140 Offset: 0x1774340 VA: 0x181775140
	public static double ToDouble(object value) { }

	// RVA: 0x17751E0 Offset: 0x17743E0 VA: 0x1817751E0
	public static double ToDouble(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x1775050 Offset: 0x1774250 VA: 0x181775050
	public static double ToDouble(sbyte value) { }

	// RVA: 0x1775130 Offset: 0x1774330 VA: 0x181775130
	public static double ToDouble(byte value) { }

	// RVA: 0x1775390 Offset: 0x1774590 VA: 0x181775390
	public static double ToDouble(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x17750C0 Offset: 0x17742C0 VA: 0x1817750C0
	public static double ToDouble(ushort value) { }

	// RVA: 0x1775060 Offset: 0x1774260 VA: 0x181775060
	public static double ToDouble(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1775290 Offset: 0x1774490 VA: 0x181775290
	public static double ToDouble(uint value) { }

	// RVA: 0x1775070 Offset: 0x1774270 VA: 0x181775070
	public static double ToDouble(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1775090 Offset: 0x1774290 VA: 0x181775090
	public static double ToDouble(ulong value) { }

	// RVA: 0x17752A0 Offset: 0x17744A0 VA: 0x1817752A0
	public static double ToDouble(float value) { }

	// RVA: 0x17750D0 Offset: 0x17742D0 VA: 0x1817750D0
	public static double ToDouble(Decimal value) { }

	// RVA: 0x17752B0 Offset: 0x17744B0 VA: 0x1817752B0
	public static double ToDouble(string value, IFormatProvider provider) { }

	// RVA: 0x1775080 Offset: 0x1774280 VA: 0x181775080
	public static double ToDouble(bool value) { }

	// RVA: 0x1774B10 Offset: 0x1773D10 VA: 0x181774B10
	public static Decimal ToDecimal(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x1774D70 Offset: 0x1773F70 VA: 0x181774D70
	public static Decimal ToDecimal(sbyte value) { }

	// RVA: 0x1774A30 Offset: 0x1773C30 VA: 0x181774A30
	public static Decimal ToDecimal(byte value) { }

	// RVA: 0x1774D00 Offset: 0x1773F00 VA: 0x181774D00
	public static Decimal ToDecimal(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x1774DE0 Offset: 0x1773FE0 VA: 0x181774DE0
	public static Decimal ToDecimal(ushort value) { }

	// RVA: 0x1774C20 Offset: 0x1773E20 VA: 0x181774C20
	public static Decimal ToDecimal(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1774F30 Offset: 0x1774130 VA: 0x181774F30
	public static Decimal ToDecimal(uint value) { }

	// RVA: 0x1774AA0 Offset: 0x1773CA0 VA: 0x181774AA0
	public static Decimal ToDecimal(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1774E50 Offset: 0x1774050 VA: 0x181774E50
	public static Decimal ToDecimal(ulong value) { }

	// RVA: 0x17749C0 Offset: 0x1773BC0 VA: 0x1817749C0
	public static Decimal ToDecimal(float value) { }

	// RVA: 0x1774EC0 Offset: 0x17740C0 VA: 0x181774EC0
	public static Decimal ToDecimal(double value) { }

	// RVA: 0x1774FA0 Offset: 0x17741A0 VA: 0x181774FA0
	public static Decimal ToDecimal(string value, IFormatProvider provider) { }

	// RVA: 0x4354A0 Offset: 0x4346A0 VA: 0x1804354A0
	public static Decimal ToDecimal(Decimal value) { }

	// RVA: 0x1774C90 Offset: 0x1773E90 VA: 0x181774C90
	public static Decimal ToDecimal(bool value) { }

	// RVA: 0x17747C0 Offset: 0x17739C0 VA: 0x1817747C0
	public static DateTime ToDateTime(object value, IFormatProvider provider) { }

	// RVA: 0x17748A0 Offset: 0x1773AA0 VA: 0x1817748A0
	public static DateTime ToDateTime(string value, IFormatProvider provider) { }

	// RVA: 0x1776DC0 Offset: 0x1775FC0 VA: 0x181776DC0
	public static string ToString(object value) { }

	// RVA: 0x17770B0 Offset: 0x17762B0 VA: 0x1817770B0
	public static string ToString(object value, IFormatProvider provider) { }

	// RVA: 0x1777060 Offset: 0x1776260 VA: 0x181777060
	public static string ToString(char value) { }

	// RVA: 0x1777360 Offset: 0x1776560 VA: 0x181777360
	public static string ToString(char value, IFormatProvider provider) { }

	// RVA: 0x17772B0 Offset: 0x17764B0 VA: 0x1817772B0
	public static string ToString(int value, IFormatProvider provider) { }

	// RVA: 0x1774060 Offset: 0x1773260 VA: 0x181774060
	public static byte ToByte(string value, int fromBase) { }

	[CLSCompliant(False)]
	// RVA: 0x17767A0 Offset: 0x17759A0 VA: 0x1817767A0
	public static sbyte ToSByte(string value, int fromBase) { }

	// RVA: 0x1775560 Offset: 0x1774760 VA: 0x181775560
	public static short ToInt16(string value, int fromBase) { }

	[CLSCompliant(False)]
	// RVA: 0x17773E0 Offset: 0x17765E0 VA: 0x1817773E0
	public static ushort ToUInt16(string value, int fromBase) { }

	// RVA: 0x1775EA0 Offset: 0x17750A0 VA: 0x181775EA0
	public static int ToInt32(string value, int fromBase) { }

	[CLSCompliant(False)]
	// RVA: 0x1777BC0 Offset: 0x1776DC0 VA: 0x181777BC0
	public static uint ToUInt32(string value, int fromBase) { }

	// RVA: 0x1775F90 Offset: 0x1775190 VA: 0x181775F90
	public static long ToInt64(string value, int fromBase) { }

	[CLSCompliant(False)]
	// RVA: 0x17783B0 Offset: 0x17775B0 VA: 0x1817783B0
	public static ulong ToUInt64(string value, int fromBase) { }

	// RVA: 0x1776F40 Offset: 0x1776140 VA: 0x181776F40
	public static string ToString(byte value, int toBase) { }

	// RVA: 0x1776FD0 Offset: 0x17761D0 VA: 0x181776FD0
	public static string ToString(short value, int toBase) { }

	// RVA: 0x1777220 Offset: 0x1776420 VA: 0x181777220
	public static string ToString(int value, int toBase) { }

	// RVA: 0x17772D0 Offset: 0x17764D0 VA: 0x1817772D0
	public static string ToString(long value, int toBase) { }

	// RVA: 0x1773670 Offset: 0x1772870 VA: 0x181773670
	public static string ToBase64String(byte[] inArray) { }

	// RVA: 0x1773180 Offset: 0x1772380 VA: 0x181773180
	public static string ToBase64String(byte[] inArray, Base64FormattingOptions options) { }

	// RVA: 0x1773740 Offset: 0x1772940 VA: 0x181773740
	public static string ToBase64String(byte[] inArray, int offset, int length) { }

	// RVA: 0x1773260 Offset: 0x1772460 VA: 0x181773260
	public static string ToBase64String(byte[] inArray, int offset, int length, Base64FormattingOptions options) { }

	// RVA: 0x17734A0 Offset: 0x17726A0 VA: 0x1817734A0
	public static string ToBase64String(ReadOnlySpan<byte> bytes, Base64FormattingOptions options = 0) { }

	// RVA: 0x1772CB0 Offset: 0x1771EB0 VA: 0x181772CB0
	public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut) { }

	// RVA: 0x1772D40 Offset: 0x1771F40 VA: 0x181772D40
	public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut, Base64FormattingOptions options) { }

	// RVA: 0x1771330 Offset: 0x1770530 VA: 0x181771330
	private static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks) { }

	// RVA: 0x17737C0 Offset: 0x17729C0 VA: 0x1817737C0
	private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks) { }

	// RVA: 0x1772750 Offset: 0x1771950 VA: 0x181772750
	public static byte[] FromBase64String(string s) { }

	// RVA: 0x1778850 Offset: 0x1777A50 VA: 0x181778850
	public static bool TryFromBase64Chars(ReadOnlySpan<char> chars, Span<byte> bytes, out int bytesWritten) { }

	// RVA: 0x17716B0 Offset: 0x17708B0 VA: 0x1817716B0
	private static void CopyToTempBufferWithoutWhiteSpace(ReadOnlySpan<char> chars, Span<char> tempBuffer, out int consumed, out int charsWritten) { }

	[Extension]
	// RVA: 0x17729B0 Offset: 0x1771BB0 VA: 0x1817729B0
	private static bool IsSpace(char c) { }

	// RVA: 0x17722B0 Offset: 0x17714B0 VA: 0x1817722B0
	public static byte[] FromBase64CharArray(char[] inArray, int offset, int length) { }

	// RVA: 0x1772530 Offset: 0x1771730 VA: 0x181772530
	private static byte[] FromBase64CharPtr(char* inputPtr, int inputLength) { }

	// RVA: 0x1772810 Offset: 0x1771A10 VA: 0x181772810
	private static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength) { }

	// RVA: 0x1778E80 Offset: 0x1778080 VA: 0x181778E80
	private static void .cctor() { }
}

// Namespace: System
[Flags]
public enum Base64FormattingOptions // TypeDefIndex: 3000
{
	// Fields
	public int value__; // 0x0
	public const Base64FormattingOptions None = 0;
	public const Base64FormattingOptions InsertLineBreaks = 1;
}

// Namespace: System
[Serializable]
public sealed class DBNull : ISerializable, IConvertible // TypeDefIndex: 3001
{
	// Fields
	public static readonly DBNull Value; // 0x0

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x1779C90 Offset: 0x1778E90 VA: 0x181779C90
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17796D0 Offset: 0x17788D0 VA: 0x1817796D0 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1779BB0 Offset: 0x1778DB0 VA: 0x181779BB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1779BF0 Offset: 0x1778DF0 VA: 0x181779BF0 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x17796E0 Offset: 0x17788E0 VA: 0x1817796E0 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1779780 Offset: 0x1778980 VA: 0x181779780 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x17799B0 Offset: 0x1778BB0 VA: 0x1817799B0 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1779730 Offset: 0x1778930 VA: 0x181779730 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x17798C0 Offset: 0x1778AC0 VA: 0x1817798C0 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1779AC0 Offset: 0x1778CC0 VA: 0x181779AC0 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1779910 Offset: 0x1778B10 VA: 0x181779910 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1779B10 Offset: 0x1778D10 VA: 0x181779B10 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1779960 Offset: 0x1778B60 VA: 0x181779960 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1779B60 Offset: 0x1778D60 VA: 0x181779B60 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1779A00 Offset: 0x1778C00 VA: 0x181779A00 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1779870 Offset: 0x1778A70 VA: 0x181779870 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1779820 Offset: 0x1778A20 VA: 0x181779820 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x17797D0 Offset: 0x17789D0 VA: 0x1817797D0 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1779A50 Offset: 0x1778C50 VA: 0x181779A50 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x1779C30 Offset: 0x1778E30 VA: 0x181779C30
	private static void .cctor() { }
}

// Namespace: System
[IsReadOnly]
[Serializable]
public struct DateTime : IComparable, IFormattable, IConvertible, IComparable<DateTime>, IEquatable<DateTime>, ISerializable, ISpanFormattable // TypeDefIndex: 3002
{
	// Fields
	private const long TicksPerMillisecond = 10000;
	private const long TicksPerSecond = 10000000;
	private const long TicksPerMinute = 600000000;
	private const long TicksPerHour = 36000000000;
	private const long TicksPerDay = 864000000000;
	private const int MillisPerSecond = 1000;
	private const int MillisPerMinute = 60000;
	private const int MillisPerHour = 3600000;
	private const int MillisPerDay = 86400000;
	private const int DaysPerYear = 365;
	private const int DaysPer4Years = 1461;
	private const int DaysPer100Years = 36524;
	private const int DaysPer400Years = 146097;
	private const int DaysTo1601 = 584388;
	private const int DaysTo1899 = 693593;
	internal const int DaysTo1970 = 719162;
	private const int DaysTo10000 = 3652059;
	internal const long MinTicks = 0;
	internal const long MaxTicks = 3155378975999999999;
	private const long MaxMillis = 315537897600000;
	internal const long UnixEpochTicks = 621355968000000000;
	private const long FileTimeOffset = 504911232000000000;
	private const long DoubleDateOffset = 599264352000000000;
	private const long OADateMinAsTicks = 31241376000000000;
	private const double OADateMinAsDouble = -657435;
	private const double OADateMaxAsDouble = 2958466;
	private const int DatePartYear = 0;
	private const int DatePartDayOfYear = 1;
	private const int DatePartMonth = 2;
	private const int DatePartDay = 3;
	private static readonly int[] s_daysToMonth365; // 0x0
	private static readonly int[] s_daysToMonth366; // 0x8
	public static readonly DateTime MinValue; // 0x10
	public static readonly DateTime MaxValue; // 0x18
	public static readonly DateTime UnixEpoch; // 0x20
	private const ulong TicksMask = 4611686018427387903;
	private const ulong FlagsMask = 13835058055282163712;
	private const ulong LocalMask = 9223372036854775808;
	private const long TicksCeiling = 4611686018427387904;
	private const ulong KindUnspecified = 0;
	private const ulong KindUtc = 4611686018427387904;
	private const ulong KindLocal = 9223372036854775808;
	private const ulong KindLocalAmbiguousDst = 13835058055282163712;
	private const int KindShift = 62;
	private const string TicksField = "ticks";
	private const string DateDataField = "dateData";
	private readonly ulong _dateData; // 0x0

	// Properties
	internal long InternalTicks { get; }
	private ulong InternalKind { get; }
	public DateTime Date { get; }
	public int Day { get; }
	public DayOfWeek DayOfWeek { get; }
	public int DayOfYear { get; }
	public int Hour { get; }
	public DateTimeKind Kind { get; }
	public int Millisecond { get; }
	public int Minute { get; }
	public int Month { get; }
	public static DateTime Now { get; }
	public int Second { get; }
	public long Ticks { get; }
	public TimeSpan TimeOfDay { get; }
	public int Year { get; }
	public static DateTime UtcNow { get; }

	// Methods

	// RVA: 0x1786280 Offset: 0x1785480 VA: 0x181786280
	public void .ctor(long ticks) { }

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	private void .ctor(ulong dateData) { }

	// RVA: 0x17869A0 Offset: 0x1785BA0 VA: 0x1817869A0
	public void .ctor(long ticks, DateTimeKind kind) { }

	// RVA: 0x17865A0 Offset: 0x17857A0 VA: 0x1817865A0
	internal void .ctor(long ticks, DateTimeKind kind, bool isAmbiguousDst) { }

	// RVA: 0x1786640 Offset: 0x1785840 VA: 0x181786640
	public void .ctor(int year, int month, int day) { }

	// RVA: 0x1785C90 Offset: 0x1784E90 VA: 0x181785C90
	public void .ctor(int year, int month, int day, int hour, int minute, int second) { }

	// RVA: 0x1786890 Offset: 0x1785A90 VA: 0x181786890
	public void .ctor(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind) { }

	// RVA: 0x17866C0 Offset: 0x17858C0 VA: 0x1817866C0
	public void .ctor(int year, int month, int day, int hour, int minute, int second, int millisecond) { }

	// RVA: 0x1785D30 Offset: 0x1784F30 VA: 0x181785D30
	public void .ctor(int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind) { }

	// RVA: 0x1786310 Offset: 0x1785510 VA: 0x181786310
	public void .ctor(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar) { }

	// RVA: 0x1785F80 Offset: 0x1785180 VA: 0x181785F80
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1786CF0 Offset: 0x1785EF0 VA: 0x181786CF0
	internal long get_InternalTicks() { }

	// RVA: 0x1786CD0 Offset: 0x1785ED0 VA: 0x181786CD0
	private ulong get_InternalKind() { }

	// RVA: 0x1782AB0 Offset: 0x1781CB0 VA: 0x181782AB0
	public DateTime Add(TimeSpan value) { }

	// RVA: 0x1782990 Offset: 0x1781B90 VA: 0x181782990
	private DateTime Add(double value, int scale) { }

	// RVA: 0x17822C0 Offset: 0x17814C0 VA: 0x1817822C0
	public DateTime AddDays(double value) { }

	// RVA: 0x1782320 Offset: 0x1781520 VA: 0x181782320
	public DateTime AddHours(double value) { }

	// RVA: 0x1782380 Offset: 0x1781580 VA: 0x181782380
	public DateTime AddMilliseconds(double value) { }

	// RVA: 0x17823E0 Offset: 0x17815E0 VA: 0x1817823E0
	public DateTime AddMonths(int months) { }

	// RVA: 0x1782750 Offset: 0x1781950 VA: 0x181782750
	public DateTime AddSeconds(double value) { }

	// RVA: 0x17827B0 Offset: 0x17819B0 VA: 0x1817827B0
	public DateTime AddTicks(long value) { }

	// RVA: 0x17828C0 Offset: 0x1781AC0 VA: 0x1817828C0
	public DateTime AddYears(int value) { }

	// RVA: 0x1782C60 Offset: 0x1781E60 VA: 0x181782C60
	public static int Compare(DateTime t1, DateTime t2) { }

	// RVA: 0x1782B10 Offset: 0x1781D10 VA: 0x181782B10 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1782C00 Offset: 0x1781E00 VA: 0x181782C00 Slot: 23
	public int CompareTo(DateTime value) { }

	// RVA: 0x1782CE0 Offset: 0x1781EE0 VA: 0x181782CE0
	private static long DateToTicks(int year, int month, int day) { }

	// RVA: 0x1784D90 Offset: 0x1783F90 VA: 0x181784D90
	private static long TimeToTicks(int hour, int minute, int second) { }

	// RVA: 0x1782EB0 Offset: 0x17820B0 VA: 0x181782EB0
	public static int DaysInMonth(int year, int month) { }

	// RVA: 0x1782FF0 Offset: 0x17821F0 VA: 0x181782FF0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x17830B0 Offset: 0x17822B0 VA: 0x1817830B0 Slot: 24
	public bool Equals(DateTime value) { }

	// RVA: 0x17831B0 Offset: 0x17823B0 VA: 0x1817831B0
	public static DateTime FromBinary(long dateData) { }

	// RVA: 0x1783110 Offset: 0x1782310 VA: 0x181783110
	internal static DateTime FromBinaryRaw(long dateData) { }

	// RVA: 0x1783540 Offset: 0x1782740 VA: 0x181783540
	public static DateTime FromFileTime(long fileTime) { }

	// RVA: 0x1783480 Offset: 0x1782680 VA: 0x181783480
	public static DateTime FromFileTimeUtc(long fileTime) { }

	// RVA: 0x1784CA0 Offset: 0x1783EA0 VA: 0x181784CA0 Slot: 25
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17843C0 Offset: 0x17835C0 VA: 0x1817843C0
	public static DateTime SpecifyKind(DateTime value, DateTimeKind kind) { }

	// RVA: 0x1786A90 Offset: 0x1785C90 VA: 0x181786A90
	public DateTime get_Date() { }

	// RVA: 0x1783670 Offset: 0x1782870 VA: 0x181783670
	private int GetDatePart(int part) { }

	// RVA: 0x1783860 Offset: 0x1782A60 VA: 0x181783860
	internal void GetDatePart(out int year, out int month, out int day) { }

	// RVA: 0x1786BF0 Offset: 0x1785DF0 VA: 0x181786BF0
	public int get_Day() { }

	// RVA: 0x1786B10 Offset: 0x1785D10 VA: 0x181786B10
	public DayOfWeek get_DayOfWeek() { }

	// RVA: 0x1786BA0 Offset: 0x1785DA0 VA: 0x181786BA0
	public int get_DayOfYear() { }

	// RVA: 0x1783A50 Offset: 0x1782C50 VA: 0x181783A50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1786C40 Offset: 0x1785E40 VA: 0x181786C40
	public int get_Hour() { }

	// RVA: 0x1783AC0 Offset: 0x1782CC0 VA: 0x181783AC0
	internal bool IsAmbiguousDaylightSavingTime() { }

	// RVA: 0x1786D10 Offset: 0x1785F10 VA: 0x181786D10
	public DateTimeKind get_Kind() { }

	// RVA: 0x1786D80 Offset: 0x1785F80 VA: 0x181786D80
	public int get_Millisecond() { }

	// RVA: 0x1786E10 Offset: 0x1786010 VA: 0x181786E10
	public int get_Minute() { }

	// RVA: 0x1786EA0 Offset: 0x17860A0 VA: 0x181786EA0
	public int get_Month() { }

	// RVA: 0x1786EF0 Offset: 0x17860F0 VA: 0x181786EF0
	public static DateTime get_Now() { }

	// RVA: 0x1787070 Offset: 0x1786270 VA: 0x181787070
	public int get_Second() { }

	// RVA: 0x1787100 Offset: 0x1786300 VA: 0x181787100
	public long get_Ticks() { }

	// RVA: 0x1787150 Offset: 0x1786350 VA: 0x181787150
	public TimeSpan get_TimeOfDay() { }

	// RVA: 0x1787220 Offset: 0x1786420 VA: 0x181787220
	public int get_Year() { }

	// RVA: 0x1783B20 Offset: 0x1782D20 VA: 0x181783B20
	public static bool IsLeapYear(int year) { }

	// RVA: 0x1784090 Offset: 0x1783290 VA: 0x181784090
	public static DateTime Parse(string s) { }

	// RVA: 0x17842C0 Offset: 0x17834C0 VA: 0x1817842C0
	public static DateTime Parse(string s, IFormatProvider provider) { }

	// RVA: 0x1784180 Offset: 0x1783380 VA: 0x181784180
	public static DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles) { }

	// RVA: 0x1783F10 Offset: 0x1783110 VA: 0x181783F10
	public static DateTime ParseExact(string s, string format, IFormatProvider provider) { }

	// RVA: 0x1783C00 Offset: 0x1782E00 VA: 0x181783C00
	public static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style) { }

	// RVA: 0x1783DC0 Offset: 0x1782FC0 VA: 0x181783DC0
	public static DateTime ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style) { }

	// RVA: 0x1784440 Offset: 0x1783640 VA: 0x181784440
	public TimeSpan Subtract(DateTime value) { }

	// RVA: 0x17850E0 Offset: 0x17842E0 VA: 0x1817850E0
	public DateTime ToLocalTime() { }

	// RVA: 0x1784E50 Offset: 0x1784050 VA: 0x181784E50
	internal DateTime ToLocalTime(bool throwOnOverflow) { }

	// RVA: 0x17851A0 Offset: 0x17843A0 VA: 0x1817851A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x17852A0 Offset: 0x17844A0 VA: 0x1817852A0
	public string ToString(string format) { }

	// RVA: 0x1785240 Offset: 0x1784440 VA: 0x181785240 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1785130 Offset: 0x1784330 VA: 0x181785130 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1785560 Offset: 0x1784760 VA: 0x181785560 Slot: 26
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x1785300 Offset: 0x1784500 VA: 0x181785300
	public DateTime ToUniversalTime() { }

	// RVA: 0x1785940 Offset: 0x1784B40 VA: 0x181785940
	public static bool TryParse(string s, out DateTime result) { }

	// RVA: 0x1785A40 Offset: 0x1784C40 VA: 0x181785A40
	public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result) { }

	// RVA: 0x17857A0 Offset: 0x17849A0 VA: 0x1817857A0
	public static bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result) { }

	// RVA: 0x1785650 Offset: 0x1784850 VA: 0x181785650
	public static bool TryParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style, out DateTime result) { }

	// RVA: 0x1787270 Offset: 0x1786470 VA: 0x181787270
	public static DateTime op_Addition(DateTime d, TimeSpan t) { }

	// RVA: 0x1787600 Offset: 0x1786800 VA: 0x181787600
	public static DateTime op_Subtraction(DateTime d, TimeSpan t) { }

	// RVA: 0x1787700 Offset: 0x1786900 VA: 0x181787700
	public static TimeSpan op_Subtraction(DateTime d1, DateTime d2) { }

	// RVA: 0x1787380 Offset: 0x1786580 VA: 0x181787380
	public static bool op_Equality(DateTime d1, DateTime d2) { }

	// RVA: 0x17874C0 Offset: 0x17866C0 VA: 0x1817874C0
	public static bool op_Inequality(DateTime d1, DateTime d2) { }

	// RVA: 0x1787590 Offset: 0x1786790 VA: 0x181787590
	public static bool op_LessThan(DateTime t1, DateTime t2) { }

	// RVA: 0x1787520 Offset: 0x1786720 VA: 0x181787520
	public static bool op_LessThanOrEqual(DateTime t1, DateTime t2) { }

	// RVA: 0x1787450 Offset: 0x1786650 VA: 0x181787450
	public static bool op_GreaterThan(DateTime t1, DateTime t2) { }

	// RVA: 0x17873E0 Offset: 0x17865E0 VA: 0x1817873E0
	public static bool op_GreaterThanOrEqual(DateTime t1, DateTime t2) { }

	// RVA: 0x6F8DD0 Offset: 0x6F7FD0 VA: 0x1806F8DD0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x17844B0 Offset: 0x17836B0 VA: 0x1817844B0 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x17845D0 Offset: 0x17837D0 VA: 0x1817845D0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1784930 Offset: 0x1783B30 VA: 0x181784930 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1784540 Offset: 0x1783740 VA: 0x181784540 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1784780 Offset: 0x1783980 VA: 0x181784780 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1784AF0 Offset: 0x1783CF0 VA: 0x181784AF0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1784810 Offset: 0x1783A10 VA: 0x181784810 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1784B80 Offset: 0x1783D80 VA: 0x181784B80 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x17848A0 Offset: 0x1783AA0 VA: 0x1817848A0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1784C10 Offset: 0x1783E10 VA: 0x181784C10 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x17849C0 Offset: 0x1783BC0 VA: 0x1817849C0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x17846F0 Offset: 0x17838F0 VA: 0x1817846F0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1784660 Offset: 0x1783860 VA: 0x181784660 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1784A50 Offset: 0x1783C50 VA: 0x181784A50 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x1785360 Offset: 0x1784560 VA: 0x181785360
	internal static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out DateTime result) { }

	// RVA: 0x17871C0 Offset: 0x17863C0 VA: 0x1817871C0
	public static DateTime get_UtcNow() { }

	// RVA: 0x1783AB0 Offset: 0x1782CB0 VA: 0x181783AB0
	internal static long GetSystemTimeAsFileTime() { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	internal long ToBinaryRaw() { }

	// RVA: 0x1785B80 Offset: 0x1784D80 VA: 0x181785B80
	private static void .cctor() { }
}

// Namespace: System
public enum DateTimeKind // TypeDefIndex: 3003
{
	// Fields
	public int value__; // 0x0
	public const DateTimeKind Unspecified = 0;
	public const DateTimeKind Utc = 1;
	public const DateTimeKind Local = 2;
}

// Namespace: System
[IsReadOnly]
[Serializable]
public struct DateTimeOffset : IComparable, IFormattable, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset>, ISerializable, IDeserializationCallback, ISpanFormattable // TypeDefIndex: 3004
{
	// Fields
	internal const long MaxOffset = 504000000000;
	internal const long MinOffset = -504000000000;
	private const long UnixEpochSeconds = 62135596800;
	private const long UnixEpochMilliseconds = 62135596800000;
	internal const long UnixMinSeconds = -62135596800;
	internal const long UnixMaxSeconds = 253402300799;
	public static readonly DateTimeOffset MinValue; // 0x0
	public static readonly DateTimeOffset MaxValue; // 0x10
	public static readonly DateTimeOffset UnixEpoch; // 0x20
	private readonly DateTime _dateTime; // 0x0
	private readonly short _offsetMinutes; // 0x8

	// Properties
	public static DateTimeOffset Now { get; }
	public static DateTimeOffset UtcNow { get; }
	public DateTime DateTime { get; }
	public DateTime UtcDateTime { get; }
	public DateTime LocalDateTime { get; }
	private DateTime ClockDateTime { get; }
	public int Day { get; }
	public int Hour { get; }
	public int Millisecond { get; }
	public int Minute { get; }
	public int Month { get; }
	public TimeSpan Offset { get; }
	public int Second { get; }
	public long Ticks { get; }
	public long UtcTicks { get; }
	public TimeSpan TimeOfDay { get; }
	public int Year { get; }

	// Methods

	// RVA: 0x1780C80 Offset: 0x177FE80 VA: 0x181780C80
	public void .ctor(long ticks, TimeSpan offset) { }

	// RVA: 0x1780F70 Offset: 0x1780170 VA: 0x181780F70
	public void .ctor(DateTime dateTime) { }

	// RVA: 0x17809C0 Offset: 0x177FBC0 VA: 0x1817809C0
	public void .ctor(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x1780D90 Offset: 0x177FF90 VA: 0x181780D90
	public void .ctor(int year, int month, int day, int hour, int minute, int second, TimeSpan offset) { }

	// RVA: 0x17810C0 Offset: 0x17802C0 VA: 0x1817810C0
	public void .ctor(int year, int month, int day, int hour, int minute, int second, int millisecond, TimeSpan offset) { }

	// RVA: 0x1780E80 Offset: 0x1780080 VA: 0x181780E80
	public void .ctor(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, TimeSpan offset) { }

	// RVA: 0x1781800 Offset: 0x1780A00 VA: 0x181781800
	public static DateTimeOffset get_Now() { }

	// RVA: 0x1781BA0 Offset: 0x1780DA0 VA: 0x181781BA0
	public static DateTimeOffset get_UtcNow() { }

	// RVA: 0x17812B0 Offset: 0x17804B0 VA: 0x1817812B0
	public DateTime get_DateTime() { }

	// RVA: 0x1781AF0 Offset: 0x1780CF0 VA: 0x181781AF0
	public DateTime get_UtcDateTime() { }

	// RVA: 0x17814B0 Offset: 0x17806B0 VA: 0x1817814B0
	public DateTime get_LocalDateTime() { }

	// RVA: 0x17811A0 Offset: 0x17803A0 VA: 0x1817811A0
	private DateTime get_ClockDateTime() { }

	// RVA: 0x1781300 Offset: 0x1780500 VA: 0x181781300
	public int get_Day() { }

	// RVA: 0x17813C0 Offset: 0x17805C0 VA: 0x1817813C0
	public int get_Hour() { }

	// RVA: 0x1781560 Offset: 0x1780760 VA: 0x181781560
	public int get_Millisecond() { }

	// RVA: 0x1781650 Offset: 0x1780850 VA: 0x181781650
	public int get_Minute() { }

	// RVA: 0x1781740 Offset: 0x1780940 VA: 0x181781740
	public int get_Month() { }

	// RVA: 0x1781860 Offset: 0x1780A60 VA: 0x181781860
	public TimeSpan get_Offset() { }

	// RVA: 0x1781890 Offset: 0x1780A90 VA: 0x181781890
	public int get_Second() { }

	// RVA: 0x1781980 Offset: 0x1780B80 VA: 0x181781980
	public long get_Ticks() { }

	// RVA: 0x1781C50 Offset: 0x1780E50 VA: 0x181781C50
	public long get_UtcTicks() { }

	// RVA: 0x1781A30 Offset: 0x1780C30 VA: 0x181781A30
	public TimeSpan get_TimeOfDay() { }

	// RVA: 0x1781D00 Offset: 0x1780F00 VA: 0x181781D00
	public int get_Year() { }

	// RVA: 0x177E740 Offset: 0x177D940 VA: 0x18177E740
	public DateTimeOffset Add(TimeSpan timeSpan) { }

	// RVA: 0x177E420 Offset: 0x177D620 VA: 0x18177E420
	public DateTimeOffset AddMilliseconds(double milliseconds) { }

	// RVA: 0x177E540 Offset: 0x177D740 VA: 0x18177E540
	public DateTimeOffset AddSeconds(double seconds) { }

	// RVA: 0x177E660 Offset: 0x177D860 VA: 0x18177E660
	public DateTimeOffset AddTicks(long ticks) { }

	// RVA: 0x177E9A0 Offset: 0x177DBA0 VA: 0x18177E9A0
	public static int Compare(DateTimeOffset first, DateTimeOffset second) { }

	// RVA: 0x177F3D0 Offset: 0x177E5D0 VA: 0x18177F3D0 Slot: 4
	private int System.IComparable.CompareTo(object obj) { }

	// RVA: 0x177E850 Offset: 0x177DA50 VA: 0x18177E850 Slot: 6
	public int CompareTo(DateTimeOffset other) { }

	// RVA: 0x177EA40 Offset: 0x177DC40 VA: 0x18177EA40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x177EBE0 Offset: 0x177DDE0 VA: 0x18177EBE0 Slot: 7
	public bool Equals(DateTimeOffset other) { }

	// RVA: 0x177ECB0 Offset: 0x177DEB0 VA: 0x18177ECB0
	public static DateTimeOffset FromFileTime(long fileTime) { }

	// RVA: 0x177F540 Offset: 0x177E740 VA: 0x18177F540 Slot: 9
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x177F660 Offset: 0x177E860 VA: 0x18177F660 Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1780810 Offset: 0x177FA10 VA: 0x181780810
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x177EE30 Offset: 0x177E030 VA: 0x18177EE30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x177F340 Offset: 0x177E540 VA: 0x18177F340
	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider) { }

	// RVA: 0x177F160 Offset: 0x177E360 VA: 0x18177F160
	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles) { }

	// RVA: 0x177EEF0 Offset: 0x177E0F0 VA: 0x18177EEF0
	public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles) { }

	// RVA: 0x177FAD0 Offset: 0x177ECD0 VA: 0x18177FAD0
	public long ToUnixTimeSeconds() { }

	// RVA: 0x177F800 Offset: 0x177EA00 VA: 0x18177F800 Slot: 3
	public override string ToString() { }

	// RVA: 0x177F8C0 Offset: 0x177EAC0 VA: 0x18177F8C0
	public string ToString(string format) { }

	// RVA: 0x177F990 Offset: 0x177EB90 VA: 0x18177F990
	public string ToString(IFormatProvider formatProvider) { }

	// RVA: 0x177F720 Offset: 0x177E920 VA: 0x18177F720 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x177FBA0 Offset: 0x177EDA0 VA: 0x18177FBA0 Slot: 10
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider formatProvider) { }

	// RVA: 0x177FA60 Offset: 0x177EC60 VA: 0x18177FA60
	public DateTimeOffset ToUniversalTime() { }

	// RVA: 0x1780120 Offset: 0x177F320 VA: 0x181780120
	public static bool TryParse(string input, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	// RVA: 0x177FCB0 Offset: 0x177EEB0 VA: 0x18177FCB0
	public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	// RVA: 0x177FF10 Offset: 0x177F110 VA: 0x18177FF10
	public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	// RVA: 0x1780450 Offset: 0x177F650 VA: 0x181780450
	private static short ValidateOffset(TimeSpan offset) { }

	// RVA: 0x1780310 Offset: 0x177F510 VA: 0x181780310
	private static DateTime ValidateDate(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x17805D0 Offset: 0x177F7D0 VA: 0x1817805D0
	private static DateTimeStyles ValidateStyles(DateTimeStyles style, string parameterName) { }

	// RVA: 0x1782030 Offset: 0x1781230 VA: 0x181782030
	public static DateTimeOffset op_Implicit(DateTime dateTime) { }

	// RVA: 0x1781DB0 Offset: 0x1780FB0 VA: 0x181781DB0
	public static DateTimeOffset op_Addition(DateTimeOffset dateTimeOffset, TimeSpan timeSpan) { }

	// RVA: 0x17821F0 Offset: 0x17813F0 VA: 0x1817821F0
	public static TimeSpan op_Subtraction(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0x1781E90 Offset: 0x1781090 VA: 0x181781E90
	public static bool op_Equality(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0x1782050 Offset: 0x1781250 VA: 0x181782050
	public static bool op_Inequality(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0x1782120 Offset: 0x1781320 VA: 0x181782120
	public static bool op_LessThan(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0x1781F60 Offset: 0x1781160 VA: 0x181781F60
	public static bool op_GreaterThan(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0x17806F0 Offset: 0x177F8F0 VA: 0x1817806F0
	private static void .cctor() { }
}

// Namespace: System
public enum DayOfWeek // TypeDefIndex: 3005
{
	// Fields
	public int value__; // 0x0
	public const DayOfWeek Sunday = 0;
	public const DayOfWeek Monday = 1;
	public const DayOfWeek Tuesday = 2;
	public const DayOfWeek Wednesday = 3;
	public const DayOfWeek Thursday = 4;
	public const DayOfWeek Friday = 5;
	public const DayOfWeek Saturday = 6;
}

// Namespace: System
[Serializable]
public class DivideByZeroException : ArithmeticException // TypeDefIndex: 3006
{
	// Methods

	// RVA: 0x1787790 Offset: 0x1786990 VA: 0x181787790
	public void .ctor() { }

	// RVA: 0x1787770 Offset: 0x1786970 VA: 0x181787770
	public void .ctor(string message) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System
[Serializable]
public class DllNotFoundException : TypeLoadException // TypeDefIndex: 3007
{
	// Methods

	// RVA: 0x1787820 Offset: 0x1786A20 VA: 0x181787820
	public void .ctor() { }

	// RVA: 0x1787800 Offset: 0x1786A00 VA: 0x181787800
	public void .ctor(string message) { }

	// RVA: 0x17877E0 Offset: 0x17869E0 VA: 0x1817877E0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System
[IsReadOnly]
[Serializable]
public struct Double : IComparable, IConvertible, IFormattable, IComparable<double>, IEquatable<double>, ISpanFormattable // TypeDefIndex: 3008
{
	// Fields
	private readonly double m_value; // 0x0
	public const double MinValue = -1,7976931348623157E+308;
	public const double MaxValue = 1,7976931348623157E+308;
	public const double Epsilon = 5E-324;
	public const double NegativeInfinity = -∞;
	public const double PositiveInfinity = ∞;
	public const double NaN = NaN;
	internal const double NegativeZero = -0;

	// Methods

	[NonVersionable]
	// RVA: 0x1787B30 Offset: 0x1786D30 VA: 0x181787B30
	public static bool IsFinite(double d) { }

	[NonVersionable]
	// RVA: 0x1787B60 Offset: 0x1786D60 VA: 0x181787B60
	public static bool IsInfinity(double d) { }

	[NonVersionable]
	// RVA: 0x1787B90 Offset: 0x1786D90 VA: 0x181787B90
	public static bool IsNaN(double d) { }

	[NonVersionable]
	// RVA: 0x1787BE0 Offset: 0x1786DE0 VA: 0x181787BE0
	public static bool IsNegative(double d) { }

	[NonVersionable]
	// RVA: 0x1787BC0 Offset: 0x1786DC0 VA: 0x181787BC0
	public static bool IsNegativeInfinity(double d) { }

	[NonVersionable]
	// RVA: 0x1787BF0 Offset: 0x1786DF0 VA: 0x181787BF0
	public static bool IsPositiveInfinity(double d) { }

	// RVA: 0x1787870 Offset: 0x1786A70 VA: 0x181787870 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x17879A0 Offset: 0x1786BA0 VA: 0x1817879A0 Slot: 23
	public int CompareTo(double value) { }

	// RVA: 0x1787A00 Offset: 0x1786C00 VA: 0x181787A00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1787AC0 Offset: 0x1786CC0 VA: 0x181787AC0 Slot: 24
	public bool Equals(double obj) { }

	// RVA: 0x1787B00 Offset: 0x1786D00 VA: 0x181787B00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17885F0 Offset: 0x17877F0 VA: 0x1817885F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1788570 Offset: 0x1787770 VA: 0x181788570
	public string ToString(string format) { }

	// RVA: 0x17884F0 Offset: 0x17876F0 VA: 0x1817884F0 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1788660 Offset: 0x1787860 VA: 0x181788660 Slot: 22
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x17886F0 Offset: 0x17878F0 VA: 0x1817886F0 Slot: 25
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x1787DE0 Offset: 0x1786FE0 VA: 0x181787DE0
	public static double Parse(string s) { }

	// RVA: 0x1787C10 Offset: 0x1786E10 VA: 0x181787C10
	public static double Parse(string s, IFormatProvider provider) { }

	// RVA: 0x1787CF0 Offset: 0x1786EF0 VA: 0x181787CF0
	public static double Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1788870 Offset: 0x1787A70 VA: 0x181788870
	public static bool TryParse(string s, out double result) { }

	// RVA: 0x17887B0 Offset: 0x17879B0 VA: 0x1817887B0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out double result) { }

	// RVA: 0x1788910 Offset: 0x1787B10 VA: 0x181788910
	private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out double result) { }

	// RVA: 0x16FB640 Offset: 0x16FA840 VA: 0x1816FB640 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x1787EB0 Offset: 0x17870B0 VA: 0x181787EB0 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1787F80 Offset: 0x1787180 VA: 0x181787F80 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1788270 Offset: 0x1787470 VA: 0x181788270 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1787F20 Offset: 0x1787120 VA: 0x181787F20 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1788150 Offset: 0x1787350 VA: 0x181788150 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x17883D0 Offset: 0x17875D0 VA: 0x1817883D0 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x17881B0 Offset: 0x17873B0 VA: 0x1817881B0 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1788430 Offset: 0x1787630 VA: 0x181788430 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1788210 Offset: 0x1787410 VA: 0x181788210 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1788490 Offset: 0x1787690 VA: 0x181788490 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x17882D0 Offset: 0x17874D0 VA: 0x1817882D0 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x4F9860 Offset: 0x4F8A60 VA: 0x1804F9860 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x17880A0 Offset: 0x17872A0 VA: 0x1817880A0 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1788010 Offset: 0x1787210 VA: 0x181788010 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1788330 Offset: 0x1787530 VA: 0x181788330 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

// Namespace: System
[Serializable]
public class EntryPointNotFoundException : TypeLoadException // TypeDefIndex: 3009
{
	// Methods

	// RVA: 0x1788B50 Offset: 0x1787D50 VA: 0x181788B50
	public void .ctor() { }

	// RVA: 0x1788BA0 Offset: 0x1787DA0 VA: 0x181788BA0
	public void .ctor(string message) { }

	// RVA: 0x17877E0 Offset: 0x17869E0 VA: 0x1817877E0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System
[Serializable]
public class EventArgs // TypeDefIndex: 3010
{
	// Fields
	public static readonly EventArgs Empty; // 0x0

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1788BC0 Offset: 0x1787DC0 VA: 0x181788BC0
	private static void .cctor() { }
}

// Namespace: System
public sealed class EventHandler : MulticastDelegate // TypeDefIndex: 3011
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, EventArgs e) { }
}

// Namespace: System
public sealed class EventHandler<TEventArgs> : MulticastDelegate // TypeDefIndex: 3012
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BAD50 Offset: 0x11B9F50 VA: 0x1811BAD50
	|-EventHandler<object>..ctor
	|
	|-RVA: 0x11EF8A0 Offset: 0x11EEAA0 VA: 0x1811EF8A0
	|-EventHandler<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(object sender, TEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10
	|-EventHandler<object>.Invoke
	|-EventHandler<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System
[Obsolete("This type previously indicated an unspecified fatal error in the runtime. The runtime no longer raises this exception so this type is obsolete.")]
[Serializable]
public sealed class ExecutionEngineException : SystemException // TypeDefIndex: 3013
{
	// Methods

	// RVA: 0x1788C20 Offset: 0x1787E20 VA: 0x181788C20
	public void .ctor() { }

	// RVA: 0x1788C70 Offset: 0x1787E70 VA: 0x181788C70
	public void .ctor(string message) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System
[Serializable]
public class FieldAccessException : MemberAccessException // TypeDefIndex: 3014
{
	// Methods

	// RVA: 0x1788CB0 Offset: 0x1787EB0 VA: 0x181788CB0
	public void .ctor() { }

	// RVA: 0x1788C90 Offset: 0x1787E90 VA: 0x181788C90
	public void .ctor(string message) { }

	// RVA: 0x15A17F0 Offset: 0x15A09F0 VA: 0x1815A17F0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System
[Usage(16, Inherited = False)]
[Serializable]
public class FlagsAttribute : Attribute // TypeDefIndex: 3015
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System
[Serializable]
public class FormatException : SystemException // TypeDefIndex: 3016
{
	// Methods

	// RVA: 0x1788D40 Offset: 0x1787F40 VA: 0x181788D40
	public void .ctor() { }

	// RVA: 0x1788D00 Offset: 0x1787F00 VA: 0x181788D00
	public void .ctor(string message) { }

	// RVA: 0x1788D20 Offset: 0x1787F20 VA: 0x181788D20
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System
public abstract class FormattableString : IFormattable // TypeDefIndex: 3017
{
	// Properties
	public abstract string Format { get; }
	public abstract int ArgumentCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Format();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object[] GetArguments();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_ArgumentCount();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract object GetArgument(int index);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string ToString(IFormatProvider formatProvider);

	// RVA: 0x1788D90 Offset: 0x1787F90 VA: 0x181788D90 Slot: 4
	private string System.IFormattable.ToString(string ignored, IFormatProvider formatProvider) { }

	// RVA: 0x1788DB0 Offset: 0x1787FB0 VA: 0x181788DB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System
internal sealed class Gen2GcCallback : CriticalFinalizerObject // TypeDefIndex: 3018
{
	// Fields
	private Func<object, bool> _callback; // 0x10
	private GCHandle _weakTargetObj; // 0x18

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x1788F20 Offset: 0x1788120 VA: 0x181788F20
	public static void Register(Func<object, bool> callback, object targetObj) { }

	// RVA: 0x1788FA0 Offset: 0x17881A0 VA: 0x181788FA0
	private void Setup(Func<object, bool> callback, object targetObj) { }

	// RVA: 0x1788E10 Offset: 0x1788010 VA: 0x181788E10 Slot: 1
	protected override void Finalize() { }
}

// Namespace: System
internal static class DateTimeFormat // TypeDefIndex: 3019
{
	// Fields
	internal static readonly TimeSpan NullOffset; // 0x0
	internal static char[] allStandardFormats; // 0x8
	internal static readonly DateTimeFormatInfo InvariantFormatInfo; // 0x10
	internal static readonly string[] InvariantAbbreviatedMonthNames; // 0x18
	internal static readonly string[] InvariantAbbreviatedDayNames; // 0x20
	internal static string[] fixedNumberFormats; // 0x28

	// Methods

	// RVA: 0x177BF20 Offset: 0x177B120 VA: 0x18177BF20
	internal static void FormatDigits(StringBuilder outputBuffer, int value, int len) { }

	// RVA: 0x177BFA0 Offset: 0x177B1A0 VA: 0x18177BFA0
	internal static void FormatDigits(StringBuilder outputBuffer, int value, int len, bool overrideLengthLimit) { }

	// RVA: 0x177CBE0 Offset: 0x177BDE0 VA: 0x18177CBE0
	private static void HebrewFormatDigits(StringBuilder outputBuffer, int digits) { }

	// RVA: 0x177CFE0 Offset: 0x177C1E0 VA: 0x18177CFE0
	internal static int ParseRepeatPattern(ReadOnlySpan<char> format, int pos, char patternChar) { }

	// RVA: 0x177BEE0 Offset: 0x177B0E0 VA: 0x18177BEE0
	private static string FormatDayOfWeek(int dayOfWeek, int repeat, DateTimeFormatInfo dtfi) { }

	// RVA: 0x177C170 Offset: 0x177B370 VA: 0x18177C170
	private static string FormatMonth(int month, int repeatCount, DateTimeFormatInfo dtfi) { }

	// RVA: 0x177C0A0 Offset: 0x177B2A0 VA: 0x18177C0A0
	private static string FormatHebrewMonthName(DateTime time, int month, int repeatCount, DateTimeFormatInfo dtfi) { }

	// RVA: 0x177CDF0 Offset: 0x177BFF0 VA: 0x18177CDF0
	internal static int ParseQuoteString(ReadOnlySpan<char> format, int pos, StringBuilder result) { }

	// RVA: 0x177CD80 Offset: 0x177BF80 VA: 0x18177CD80
	internal static int ParseNextChar(ReadOnlySpan<char> format, int pos) { }

	// RVA: 0x177CC50 Offset: 0x177BE50 VA: 0x18177CC50
	private static bool IsUseGenitiveForm(ReadOnlySpan<char> format, int index, int tokenLen, char patternToMatch) { }

	// RVA: 0x177ABD0 Offset: 0x1779DD0 VA: 0x18177ABD0
	private static StringBuilder FormatCustomized(DateTime dateTime, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, TimeSpan offset, StringBuilder result) { }

	// RVA: 0x177A750 Offset: 0x1779950 VA: 0x18177A750
	private static void FormatCustomizedTimeZone(DateTime dateTime, TimeSpan offset, ReadOnlySpan<char> format, int tokenLen, bool timeOnly, StringBuilder result) { }

	// RVA: 0x177A430 Offset: 0x1779630 VA: 0x18177A430
	private static void FormatCustomizedRoundripTimeZone(DateTime dateTime, TimeSpan offset, StringBuilder result) { }

	// RVA: 0x1779CF0 Offset: 0x1778EF0 VA: 0x181779CF0
	private static void Append2DigitNumber(StringBuilder result, int val) { }

	// RVA: 0x177C8A0 Offset: 0x177BAA0 VA: 0x18177C8A0
	internal static string GetRealFormat(ReadOnlySpan<char> format, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1779D70 Offset: 0x1778F70 VA: 0x181779D70
	private static string ExpandPredefinedFormat(ReadOnlySpan<char> format, ref DateTime dateTime, ref DateTimeFormatInfo dtfi, ref TimeSpan offset) { }

	// RVA: 0x177C530 Offset: 0x177B730 VA: 0x18177C530
	internal static string Format(DateTime dateTime, string format, IFormatProvider provider) { }

	// RVA: 0x177C5C0 Offset: 0x177B7C0 VA: 0x18177C5C0
	internal static string Format(DateTime dateTime, string format, IFormatProvider provider, TimeSpan offset) { }

	// RVA: 0x177DD70 Offset: 0x177CF70 VA: 0x18177DD70
	internal static bool TryFormat(DateTime dateTime, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x177DE30 Offset: 0x177D030 VA: 0x18177DE30
	internal static bool TryFormat(DateTime dateTime, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider, TimeSpan offset) { }

	// RVA: 0x177C1B0 Offset: 0x177B3B0 VA: 0x18177C1B0
	private static StringBuilder FormatStringBuilder(DateTime dateTime, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, TimeSpan offset) { }

	// RVA: 0x177D070 Offset: 0x177C270 VA: 0x18177D070
	private static bool TryFormatO(DateTime dateTime, TimeSpan offset, Span<char> destination, out int charsWritten) { }

	// RVA: 0x177D810 Offset: 0x177CA10 VA: 0x18177D810
	private static bool TryFormatR(DateTime dateTime, TimeSpan offset, Span<char> destination, out int charsWritten) { }

	// RVA: 0x177E120 Offset: 0x177D320 VA: 0x18177E120
	private static void WriteTwoDecimalDigits(uint value, Span<char> destination, int offset) { }

	// RVA: 0x1769FC0 Offset: 0x17691C0 VA: 0x181769FC0
	private static void WriteFourDecimalDigits(uint value, Span<char> buffer, int startingIndex = 0) { }

	// RVA: 0x177E060 Offset: 0x177D260 VA: 0x18177E060
	private static void WriteDigits(ulong value, Span<char> buffer) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal static void InvalidFormatForLocal(ReadOnlySpan<char> format, DateTime dateTime) { }

	// RVA: 0x177E180 Offset: 0x177D380 VA: 0x18177E180
	private static void .cctor() { }
}

// Namespace: 
internal sealed class DateTimeParse.MatchNumberDelegate : MulticastDelegate // TypeDefIndex: 3020
{
	// Methods

	// RVA: 0x17999F0 Offset: 0x1798BF0 VA: 0x1817999F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual bool Invoke(ref __DTString str, int digitLen, out int result) { }
}

// Namespace: 
internal enum DateTimeParse.DTT // TypeDefIndex: 3021
{
	// Fields
	public int value__; // 0x0
	public const DateTimeParse.DTT End = 0;
	public const DateTimeParse.DTT NumEnd = 1;
	public const DateTimeParse.DTT NumAmpm = 2;
	public const DateTimeParse.DTT NumSpace = 3;
	public const DateTimeParse.DTT NumDatesep = 4;
	public const DateTimeParse.DTT NumTimesep = 5;
	public const DateTimeParse.DTT MonthEnd = 6;
	public const DateTimeParse.DTT MonthSpace = 7;
	public const DateTimeParse.DTT MonthDatesep = 8;
	public const DateTimeParse.DTT NumDatesuff = 9;
	public const DateTimeParse.DTT NumTimesuff = 10;
	public const DateTimeParse.DTT DayOfWeek = 11;
	public const DateTimeParse.DTT YearSpace = 12;
	public const DateTimeParse.DTT YearDateSep = 13;
	public const DateTimeParse.DTT YearEnd = 14;
	public const DateTimeParse.DTT TimeZone = 15;
	public const DateTimeParse.DTT Era = 16;
	public const DateTimeParse.DTT NumUTCTimeMark = 17;
	public const DateTimeParse.DTT Unk = 18;
	public const DateTimeParse.DTT NumLocalTimeMark = 19;
	public const DateTimeParse.DTT Max = 20;
}

// Namespace: 
internal enum DateTimeParse.TM // TypeDefIndex: 3022
{
	// Fields
	public int value__; // 0x0
	public const DateTimeParse.TM NotSet = -1;
	public const DateTimeParse.TM AM = 0;
	public const DateTimeParse.TM PM = 1;
}

// Namespace: 
internal enum DateTimeParse.DS // TypeDefIndex: 3023
{
	// Fields
	public int value__; // 0x0
	public const DateTimeParse.DS BEGIN = 0;
	public const DateTimeParse.DS N = 1;
	public const DateTimeParse.DS NN = 2;
	public const DateTimeParse.DS D_Nd = 3;
	public const DateTimeParse.DS D_NN = 4;
	public const DateTimeParse.DS D_NNd = 5;
	public const DateTimeParse.DS D_M = 6;
	public const DateTimeParse.DS D_MN = 7;
	public const DateTimeParse.DS D_NM = 8;
	public const DateTimeParse.DS D_MNd = 9;
	public const DateTimeParse.DS D_NDS = 10;
	public const DateTimeParse.DS D_Y = 11;
	public const DateTimeParse.DS D_YN = 12;
	public const DateTimeParse.DS D_YNd = 13;
	public const DateTimeParse.DS D_YM = 14;
	public const DateTimeParse.DS D_YMd = 15;
	public const DateTimeParse.DS D_S = 16;
	public const DateTimeParse.DS T_S = 17;
	public const DateTimeParse.DS T_Nt = 18;
	public const DateTimeParse.DS T_NNt = 19;
	public const DateTimeParse.DS ERROR = 20;
	public const DateTimeParse.DS DX_NN = 21;
	public const DateTimeParse.DS DX_NNN = 22;
	public const DateTimeParse.DS DX_MN = 23;
	public const DateTimeParse.DS DX_NM = 24;
	public const DateTimeParse.DS DX_MNN = 25;
	public const DateTimeParse.DS DX_DS = 26;
	public const DateTimeParse.DS DX_DSN = 27;
	public const DateTimeParse.DS DX_NDS = 28;
	public const DateTimeParse.DS DX_NNDS = 29;
	public const DateTimeParse.DS DX_YNN = 30;
	public const DateTimeParse.DS DX_YMN = 31;
	public const DateTimeParse.DS DX_YN = 32;
	public const DateTimeParse.DS DX_YM = 33;
	public const DateTimeParse.DS TX_N = 34;
	public const DateTimeParse.DS TX_NN = 35;
	public const DateTimeParse.DS TX_NNN = 36;
	public const DateTimeParse.DS TX_TS = 37;
	public const DateTimeParse.DS DX_NNY = 38;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DateTimeParse.<>c // TypeDefIndex: 3024
{
	// Fields
	public static readonly DateTimeParse.<>c <>9; // 0x0
	public static Func<DateTimeParse.MatchNumberDelegate> <>9__98_0; // 0x8

	// Methods

	// RVA: 0x1799B80 Offset: 0x1798D80 VA: 0x181799B80
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1799AB0 Offset: 0x1798CB0 VA: 0x181799AB0
	internal DateTimeParse.MatchNumberDelegate <DoStrictParse>b__98_0() { }
}

// Namespace: System
internal static class DateTimeParse // TypeDefIndex: 3025
{
	// Fields
	internal static DateTimeParse.MatchNumberDelegate m_hebrewNumberParser; // 0x0
	private static DateTimeParse.DS[][] dateParsingStates; // 0x8

	// Methods

	// RVA: 0x17917E0 Offset: 0x17909E0 VA: 0x1817917E0
	internal static DateTime ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style) { }

	// RVA: 0x17915A0 Offset: 0x17907A0 VA: 0x1817915A0
	internal static DateTime ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out TimeSpan offset) { }

	// RVA: 0x17944B0 Offset: 0x17936B0 VA: 0x1817944B0
	internal static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result) { }

	// RVA: 0x17946C0 Offset: 0x17938C0 VA: 0x1817946C0
	internal static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result, out TimeSpan offset) { }

	// RVA: 0x17943B0 Offset: 0x17935B0 VA: 0x1817943B0
	internal static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result) { }

	// RVA: 0x1791440 Offset: 0x1790640 VA: 0x181791440
	internal static DateTime ParseExactMultiple(ReadOnlySpan<char> s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style) { }

	// RVA: 0x1793E10 Offset: 0x1793010 VA: 0x181793E10
	internal static bool TryParseExactMultiple(ReadOnlySpan<char> s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result, out TimeSpan offset) { }

	// RVA: 0x1793CA0 Offset: 0x1792EA0 VA: 0x181793CA0
	internal static bool TryParseExactMultiple(ReadOnlySpan<char> s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result) { }

	// RVA: 0x1793FD0 Offset: 0x17931D0 VA: 0x181793FD0
	internal static bool TryParseExactMultiple(ReadOnlySpan<char> s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result) { }

	// RVA: 0x178F6F0 Offset: 0x178E8F0 VA: 0x18178F6F0
	private static bool MatchWord(ref __DTString str, string target) { }

	// RVA: 0x178D170 Offset: 0x178C370 VA: 0x18178D170
	private static bool GetTimeZoneName(ref __DTString str) { }

	// RVA: 0x178D780 Offset: 0x178C980 VA: 0x18178D780
	internal static bool IsDigit(char ch) { }

	// RVA: 0x1791B70 Offset: 0x1790D70 VA: 0x181791B70
	private static bool ParseFraction(ref __DTString str, out double result) { }

	// RVA: 0x1792770 Offset: 0x1791970 VA: 0x181792770
	private static bool ParseTimeZone(ref __DTString str, ref TimeSpan result) { }

	// RVA: 0x178D5A0 Offset: 0x178C7A0 VA: 0x18178D5A0
	private static bool HandleTimeZone(ref __DTString str, ref DateTimeResult result) { }

	// RVA: 0x178D790 Offset: 0x178C990 VA: 0x18178D790
	private static bool Lex(DateTimeParse.DS dps, ref __DTString str, ref DateTimeToken dtok, ref DateTimeRawInfo raw, ref DateTimeResult result, ref DateTimeFormatInfo dtfi, DateTimeStyles styles) { }

	// RVA: 0x178CCA0 Offset: 0x178BEA0 VA: 0x18178CCA0
	private static Calendar GetJapaneseCalendarDefaultInstance() { }

	// RVA: 0x178CF20 Offset: 0x178C120 VA: 0x18178CF20
	internal static Calendar GetTaiwanCalendarDefaultInstance() { }

	// RVA: 0x1795750 Offset: 0x1794950 VA: 0x181795750
	private static bool VerifyValidPunctuation(ref __DTString str) { }

	// RVA: 0x178D220 Offset: 0x178C420 VA: 0x18178D220
	private static bool GetYearMonthDayOrder(string datePattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x178D450 Offset: 0x178C650 VA: 0x18178D450
	private static bool GetYearMonthOrder(string pattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x178CD90 Offset: 0x178BF90 VA: 0x18178CD90
	private static bool GetMonthDayOrder(string pattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x1793C40 Offset: 0x1792E40 VA: 0x181793C40
	private static bool TryAdjustYear(ref DateTimeResult result, int year, out int adjustedYear) { }

	// RVA: 0x1793BC0 Offset: 0x1792DC0 VA: 0x181793BC0
	private static bool SetDateYMD(ref DateTimeResult result, int year, int month, int day) { }

	// RVA: 0x1793A60 Offset: 0x1792C60 VA: 0x181793A60
	private static bool SetDateMDY(ref DateTimeResult result, int month, int day, int year) { }

	// RVA: 0x17939B0 Offset: 0x1792BB0 VA: 0x1817939B0
	private static bool SetDateDMY(ref DateTimeResult result, int day, int month, int year) { }

	// RVA: 0x1793B10 Offset: 0x1792D10 VA: 0x181793B10
	private static bool SetDateYDM(ref DateTimeResult result, int year, int day, int month) { }

	// RVA: 0x178CA70 Offset: 0x178BC70 VA: 0x18178CA70
	private static void GetDefaultYear(ref DateTimeResult result, ref DateTimeStyles styles) { }

	// RVA: 0x178C490 Offset: 0x178B690 VA: 0x18178C490
	private static bool GetDayOfNN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x178BEE0 Offset: 0x178B0E0 VA: 0x18178BEE0
	private static bool GetDayOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x178BA80 Offset: 0x178AC80 VA: 0x18178BA80
	private static bool GetDayOfMN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x178CB10 Offset: 0x178BD10 VA: 0x18178CB10
	private static bool GetHebrewDayOfNM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x178BCB0 Offset: 0x178AEB0 VA: 0x18178BCB0
	private static bool GetDayOfNM(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x178B6E0 Offset: 0x178A8E0 VA: 0x18178B6E0
	private static bool GetDayOfMNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x178C800 Offset: 0x178BA00 VA: 0x18178C800
	private static bool GetDayOfYNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x178C310 Offset: 0x178B510 VA: 0x18178C310
	private static bool GetDayOfNNY(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x178C610 Offset: 0x178B810 VA: 0x18178C610
	private static bool GetDayOfYMN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x178C960 Offset: 0x178BB60 VA: 0x18178C960
	private static bool GetDayOfYN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x178C6F0 Offset: 0x178B8F0 VA: 0x18178C6F0
	private static bool GetDayOfYM(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x17895D0 Offset: 0x17887D0 VA: 0x1817895D0
	private static void AdjustTimeMark(DateTimeFormatInfo dtfi, ref DateTimeRawInfo raw) { }

	// RVA: 0x1789590 Offset: 0x1788790 VA: 0x181789590
	private static bool AdjustHour(ref int hour, DateTimeParse.TM timeMark) { }

	// RVA: 0x178D100 Offset: 0x178C300 VA: 0x18178D100
	private static bool GetTimeOfN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x178D090 Offset: 0x178C290 VA: 0x18178D090
	private static bool GetTimeOfNN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x178D010 Offset: 0x178C210 VA: 0x18178D010
	private static bool GetTimeOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x178B060 Offset: 0x178A260 VA: 0x18178B060
	private static bool GetDateOfDSN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x178B0D0 Offset: 0x178A2D0 VA: 0x18178B0D0
	private static bool GetDateOfNDS(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x178B190 Offset: 0x178A390 VA: 0x18178B190
	private static bool GetDateOfNNDS(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1792E20 Offset: 0x1792020 VA: 0x181792E20
	private static bool ProcessDateTimeSuffix(ref DateTimeResult result, ref DateTimeRawInfo raw, ref DateTimeToken dtok) { }

	// RVA: 0x1792EE0 Offset: 0x17920E0 VA: 0x181792EE0
	internal static bool ProcessHebrewTerminalState(DateTimeParse.DS dps, ref __DTString str, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1793400 Offset: 0x1792600 VA: 0x181793400
	internal static bool ProcessTerminalState(DateTimeParse.DS dps, ref __DTString str, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1792CE0 Offset: 0x1791EE0 VA: 0x181792CE0
	internal static DateTime Parse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles) { }

	// RVA: 0x1792B80 Offset: 0x1791D80 VA: 0x181792B80
	internal static DateTime Parse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out TimeSpan offset) { }

	// RVA: 0x1794BB0 Offset: 0x1793DB0 VA: 0x181794BB0
	internal static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result) { }

	// RVA: 0x1794A00 Offset: 0x1793C00 VA: 0x181794A00
	internal static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result, out TimeSpan offset) { }

	// RVA: 0x1794D00 Offset: 0x1793F00 VA: 0x181794D00
	internal static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, ref DateTimeResult result) { }

	// RVA: 0x1789F80 Offset: 0x1789180 VA: 0x181789F80
	private static bool DetermineTimeZoneAdjustments(ref __DTString str, ref DateTimeResult result, DateTimeStyles styles, bool bTimeOnly) { }

	// RVA: 0x1789D20 Offset: 0x1788F20 VA: 0x181789D20
	private static bool DateTimeOffsetTimeZonePostProcessing(ref __DTString str, ref DateTimeResult result, DateTimeStyles styles) { }

	// RVA: 0x1789950 Offset: 0x1788B50 VA: 0x181789950
	private static bool AdjustTimeZoneToUniversal(ref DateTimeResult result) { }

	// RVA: 0x1789690 Offset: 0x1788890 VA: 0x181789690
	private static bool AdjustTimeZoneToLocal(ref DateTimeResult result, bool bTimeOnly) { }

	// RVA: 0x1791C60 Offset: 0x1790E60 VA: 0x181791C60
	private static bool ParseISO8601(ref DateTimeRawInfo raw, ref __DTString str, DateTimeStyles styles, ref DateTimeResult result) { }

	// RVA: 0x178F050 Offset: 0x178E250 VA: 0x18178F050
	internal static bool MatchHebrewDigits(ref __DTString str, int digitLen, out int number) { }

	// RVA: 0x17913A0 Offset: 0x17905A0 VA: 0x1817913A0
	internal static bool ParseDigits(ref __DTString str, int digitLen, out int result) { }

	// RVA: 0x17912A0 Offset: 0x17904A0 VA: 0x1817912A0
	internal static bool ParseDigits(ref __DTString str, int minDigitLen, int maxDigitLen, out int result) { }

	// RVA: 0x17919D0 Offset: 0x1790BD0 VA: 0x1817919D0
	private static bool ParseFractionExact(ref __DTString str, int maxDigitLen, ref double result) { }

	// RVA: 0x17923E0 Offset: 0x17915E0 VA: 0x1817923E0
	private static bool ParseSign(ref __DTString str, ref bool result) { }

	// RVA: 0x17924A0 Offset: 0x17916A0 VA: 0x1817924A0
	private static bool ParseTimeZoneOffset(ref __DTString str, int len, ref TimeSpan result) { }

	// RVA: 0x178E970 Offset: 0x178DB70 VA: 0x18178E970
	private static bool MatchAbbreviatedMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x178F1D0 Offset: 0x178E3D0 VA: 0x18178F1D0
	private static bool MatchMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x178E810 Offset: 0x178DA10 VA: 0x18178E810
	private static bool MatchAbbreviatedDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x178ED60 Offset: 0x178DF60 VA: 0x18178ED60
	private static bool MatchDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x178EEC0 Offset: 0x178E0C0 VA: 0x18178EEC0
	private static bool MatchEraName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x178F570 Offset: 0x178E770 VA: 0x18178F570
	private static bool MatchTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result) { }

	// RVA: 0x178EC00 Offset: 0x178DE00 VA: 0x18178EC00
	private static bool MatchAbbreviatedTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result) { }

	// RVA: 0x1789C80 Offset: 0x1788E80 VA: 0x181789C80
	private static bool CheckNewValue(ref int currentValue, int newValue, char patternChar, ref DateTimeResult result) { }

	// RVA: 0x178B3D0 Offset: 0x178A5D0 VA: 0x18178B3D0
	private static DateTime GetDateTimeNow(ref DateTimeResult result, ref DateTimeStyles styles) { }

	// RVA: 0x1789A50 Offset: 0x1788C50 VA: 0x181789A50
	private static bool CheckDefaultDateTime(ref DateTimeResult result, ref Calendar cal, DateTimeStyles styles) { }

	// RVA: 0x178ACD0 Offset: 0x1789ED0 VA: 0x18178ACD0
	private static string ExpandPredefinedFormat(ReadOnlySpan<char> format, ref DateTimeFormatInfo dtfi, ref ParsingInfo parseInfo, ref DateTimeResult result) { }

	// RVA: 0x17922F0 Offset: 0x17914F0 VA: 0x1817922F0
	private static bool ParseJapaneseEraStart(ref __DTString str, DateTimeFormatInfo dtfi) { }

	// RVA: 0x178F8E0 Offset: 0x178EAE0 VA: 0x18178F8E0
	private static bool ParseByFormat(ref __DTString str, ref __DTString format, ref ParsingInfo parseInfo, DateTimeFormatInfo dtfi, ref DateTimeResult result) { }

	// RVA: 0x17948F0 Offset: 0x1793AF0 VA: 0x1817948F0
	internal static bool TryParseQuoteString(ReadOnlySpan<char> format, int pos, StringBuilder result, out int returnValue) { }

	// RVA: 0x178A1F0 Offset: 0x17893F0 VA: 0x18178A1F0
	private static bool DoStrictParse(ReadOnlySpan<char> s, ReadOnlySpan<char> formatParam, DateTimeStyles styles, DateTimeFormatInfo dtfi, ref DateTimeResult result) { }

	// RVA: 0x178B4F0 Offset: 0x178A6F0 VA: 0x18178B4F0
	private static Exception GetDateTimeParseException(ref DateTimeResult result) { }

	// RVA: 0x17959A0 Offset: 0x1794BA0 VA: 0x1817959A0
	private static void .cctor() { }
}

// Namespace: System
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[IsByRefLike]
internal struct __DTString // TypeDefIndex: 3026
{
	// Fields
	internal ReadOnlySpan<char> Value; // 0x0
	internal int Index; // 0x10
	internal char m_current; // 0x14
	private CompareInfo m_info; // 0x18
	private bool m_checkDigitToken; // 0x20
	private static readonly char[] WhiteSpaceChecks; // 0x0

	// Properties
	internal int Length { get; }
	internal CompareInfo CompareInfo { get; }

	// Methods

	// RVA: 0x179BAB0 Offset: 0x179ACB0 VA: 0x18179BAB0
	internal int get_Length() { }

	// RVA: 0x179B8D0 Offset: 0x179AAD0 VA: 0x18179B8D0
	internal void .ctor(ReadOnlySpan<char> str, DateTimeFormatInfo dtfi, bool checkDigitToken) { }

	// RVA: 0x179B9D0 Offset: 0x179ABD0 VA: 0x18179B9D0
	internal void .ctor(ReadOnlySpan<char> str, DateTimeFormatInfo dtfi) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal CompareInfo get_CompareInfo() { }

	// RVA: 0x1799EA0 Offset: 0x17990A0 VA: 0x181799EA0
	internal bool GetNext() { }

	// RVA: 0x1799C80 Offset: 0x1798E80 VA: 0x181799C80
	internal bool AtEnd() { }

	// RVA: 0x1799BE0 Offset: 0x1798DE0 VA: 0x181799BE0
	internal bool Advance(int count) { }

	// RVA: 0x1799F40 Offset: 0x1799140 VA: 0x181799F40
	internal void GetRegularToken(out TokenType tokenType, out int tokenValue, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179A310 Offset: 0x1799510 VA: 0x18179A310
	internal TokenType GetSeparatorToken(DateTimeFormatInfo dtfi, out int indexBeforeSeparator, out char charBeforeSeparator) { }

	// RVA: 0x179A780 Offset: 0x1799980 VA: 0x18179A780
	internal bool MatchSpecifiedWord(string target) { }

	// RVA: 0x179A8C0 Offset: 0x1799AC0 VA: 0x18179A8C0
	internal bool MatchSpecifiedWords(string target, bool checkWordBoundary, ref int matchLength) { }

	// RVA: 0x179AD90 Offset: 0x1799F90 VA: 0x18179AD90
	internal bool Match(string str) { }

	// RVA: 0x179AF00 Offset: 0x179A100 VA: 0x18179AF00
	internal bool Match(char ch) { }

	// RVA: 0x179A690 Offset: 0x1799890 VA: 0x18179A690
	internal int MatchLongestWords(string[] words, ref int maxMatchStrLen) { }

	// RVA: 0x179A240 Offset: 0x1799440 VA: 0x18179A240
	internal int GetRepeatCount() { }

	// RVA: 0x1799DE0 Offset: 0x1798FE0 VA: 0x181799DE0
	internal bool GetNextDigit() { }

	// RVA: 0x1799D90 Offset: 0x1798F90 VA: 0x181799D90
	internal char GetChar() { }

	// RVA: 0x1799DB0 Offset: 0x1798FB0 VA: 0x181799DB0
	internal int GetDigit() { }

	// RVA: 0x179B670 Offset: 0x179A870 VA: 0x18179B670
	internal void SkipWhiteSpaces() { }

	// RVA: 0x179B530 Offset: 0x179A730 VA: 0x18179B530
	internal bool SkipWhiteSpaceCurrent() { }

	// RVA: 0x179B730 Offset: 0x179A930 VA: 0x18179B730
	internal void TrimTail() { }

	// RVA: 0x179B2B0 Offset: 0x179A4B0 VA: 0x18179B2B0
	internal void RemoveTrailingInQuoteSpaces() { }

	// RVA: 0x179AFC0 Offset: 0x179A1C0 VA: 0x18179AFC0
	internal void RemoveLeadingInQuoteSpaces() { }

	// RVA: 0x179A530 Offset: 0x1799730 VA: 0x18179A530
	internal DTSubString GetSubString() { }

	// RVA: 0x1799CF0 Offset: 0x1798EF0 VA: 0x181799CF0
	internal void ConsumeSubString(DTSubString sub) { }

	// RVA: 0x179B850 Offset: 0x179AA50 VA: 0x18179B850
	private static void .cctor() { }
}

// Namespace: System
internal enum DTSubStringType // TypeDefIndex: 3027
{
	// Fields
	public int value__; // 0x0
	public const DTSubStringType Unknown = 0;
	public const DTSubStringType Invalid = 1;
	public const DTSubStringType Number = 2;
	public const DTSubStringType End = 3;
	public const DTSubStringType Other = 4;
}

// Namespace: System
[DefaultMember("Item")]
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct DTSubString // TypeDefIndex: 3028
{
	// Fields
	internal ReadOnlySpan<char> s; // 0x0
	internal int index; // 0x10
	internal int length; // 0x14
	internal DTSubStringType type; // 0x18
	internal int value; // 0x1C

	// Properties
	internal char Item { get; }

	// Methods

	// RVA: 0x1789560 Offset: 0x1788760 VA: 0x181789560
	internal char get_Item(int relativeIndex) { }
}

// Namespace: System
internal struct DateTimeToken // TypeDefIndex: 3029
{
	// Fields
	internal DateTimeParse.DTT dtt; // 0x0
	internal TokenType suffix; // 0x4
	internal int num; // 0x8
}

// Namespace: System
internal struct DateTimeRawInfo // TypeDefIndex: 3030
{
	// Fields
	private int* num; // 0x0
	internal int numCount; // 0x8
	internal int month; // 0xC
	internal int year; // 0x10
	internal int dayOfWeek; // 0x14
	internal int era; // 0x18
	internal DateTimeParse.TM timeMark; // 0x1C
	internal double fraction; // 0x20
	internal bool hasSameDateAndTimeSeparators; // 0x28

	// Methods

	// RVA: 0x1795F70 Offset: 0x1795170 VA: 0x181795F70
	internal void Init(int* numberBuffer) { }

	// RVA: 0x1795F40 Offset: 0x1795140 VA: 0x181795F40
	internal void AddNumber(int value) { }

	// RVA: 0x1795F60 Offset: 0x1795160 VA: 0x181795F60
	internal int GetNumber(int index) { }
}

// Namespace: System
internal enum ParseFailureKind // TypeDefIndex: 3031
{
	// Fields
	public int value__; // 0x0
	public const ParseFailureKind None = 0;
	public const ParseFailureKind ArgumentNull = 1;
	public const ParseFailureKind Format = 2;
	public const ParseFailureKind FormatWithParameter = 3;
	public const ParseFailureKind FormatWithOriginalDateTime = 4;
	public const ParseFailureKind FormatWithFormatSpecifier = 5;
	public const ParseFailureKind FormatWithOriginalDateTimeAndParameter = 6;
	public const ParseFailureKind FormatBadDateTimeCalendar = 7;
}

// Namespace: System
[Flags]
internal enum ParseFlags // TypeDefIndex: 3032
{
	// Fields
	public int value__; // 0x0
	public const ParseFlags HaveYear = 1;
	public const ParseFlags HaveMonth = 2;
	public const ParseFlags HaveDay = 4;
	public const ParseFlags HaveHour = 8;
	public const ParseFlags HaveMinute = 16;
	public const ParseFlags HaveSecond = 32;
	public const ParseFlags HaveTime = 64;
	public const ParseFlags HaveDate = 128;
	public const ParseFlags TimeZoneUsed = 256;
	public const ParseFlags TimeZoneUtc = 512;
	public const ParseFlags ParsedMonthName = 1024;
	public const ParseFlags CaptureOffset = 2048;
	public const ParseFlags YearDefault = 4096;
	public const ParseFlags Rfc1123Pattern = 8192;
	public const ParseFlags UtcSortPattern = 16384;
}

// Namespace: System
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[IsByRefLike]
internal struct DateTimeResult // TypeDefIndex: 3033
{
	// Fields
	internal int Year; // 0x0
	internal int Month; // 0x4
	internal int Day; // 0x8
	internal int Hour; // 0xC
	internal int Minute; // 0x10
	internal int Second; // 0x14
	internal double fraction; // 0x18
	internal int era; // 0x20
	internal ParseFlags flags; // 0x24
	internal TimeSpan timeZoneOffset; // 0x28
	internal Calendar calendar; // 0x30
	internal DateTime parsedDate; // 0x38
	internal ParseFailureKind failure; // 0x40
	internal string failureMessageID; // 0x48
	internal object failureMessageFormatArgument; // 0x50
	internal string failureArgumentName; // 0x58
	internal ReadOnlySpan<char> originalDateTimeString; // 0x60
	internal ReadOnlySpan<char> failedFormatSpecifier; // 0x70

	// Methods

	// RVA: 0x1795FA0 Offset: 0x17951A0 VA: 0x181795FA0
	internal void Init(ReadOnlySpan<char> originalDateTimeString) { }

	// RVA: 0xD45600 Offset: 0xD44800 VA: 0x180D45600
	internal void SetDate(int year, int month, int day) { }

	// RVA: 0x1796070 Offset: 0x1795270 VA: 0x181796070
	internal void SetBadFormatSpecifierFailure() { }

	// RVA: 0x1796020 Offset: 0x1795220 VA: 0x181796020
	internal void SetBadFormatSpecifierFailure(ReadOnlySpan<char> failedFormatSpecifier) { }

	// RVA: 0x1795FD0 Offset: 0x17951D0 VA: 0x181795FD0
	internal void SetBadDateTimeFailure() { }

	// RVA: 0x1796120 Offset: 0x1795320 VA: 0x181796120
	internal void SetFailure(ParseFailureKind failure, string failureMessageID) { }

	// RVA: 0x17960F0 Offset: 0x17952F0 VA: 0x1817960F0
	internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	// RVA: 0x1796100 Offset: 0x1795300 VA: 0x181796100
	internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName) { }
}

// Namespace: System
internal struct ParsingInfo // TypeDefIndex: 3034
{
	// Fields
	internal Calendar calendar; // 0x0
	internal int dayOfWeek; // 0x8
	internal DateTimeParse.TM timeMark; // 0xC
	internal bool fUseHour12; // 0x10
	internal bool fUseTwoDigitYear; // 0x11
	internal bool fAllowInnerWhite; // 0x12
	internal bool fAllowTrailingWhite; // 0x13
	internal bool fCustomNumberParser; // 0x14
	internal DateTimeParse.MatchNumberDelegate parseNumberDelegate; // 0x18

	// Methods

	// RVA: 0x1799AA0 Offset: 0x1798CA0 VA: 0x181799AA0
	internal void Init() { }
}

// Namespace: System
internal enum TokenType // TypeDefIndex: 3035
{
	// Fields
	public int value__; // 0x0
	public const TokenType NumberToken = 1;
	public const TokenType YearNumberToken = 2;
	public const TokenType Am = 3;
	public const TokenType Pm = 4;
	public const TokenType MonthToken = 5;
	public const TokenType EndOfString = 6;
	public const TokenType DayOfWeekToken = 7;
	public const TokenType TimeZoneToken = 8;
	public const TokenType EraToken = 9;
	public const TokenType DateWordToken = 10;
	public const TokenType UnknownToken = 11;
	public const TokenType HebrewNumber = 12;
	public const TokenType JapaneseEraToken = 13;
	public const TokenType TEraToken = 14;
	public const TokenType IgnorableSymbol = 15;
	public const TokenType SEP_Unk = 256;
	public const TokenType SEP_End = 512;
	public const TokenType SEP_Space = 768;
	public const TokenType SEP_Am = 1024;
	public const TokenType SEP_Pm = 1280;
	public const TokenType SEP_Date = 1536;
	public const TokenType SEP_Time = 1792;
	public const TokenType SEP_YearSuff = 2048;
	public const TokenType SEP_MonthSuff = 2304;
	public const TokenType SEP_DaySuff = 2560;
	public const TokenType SEP_HourSuff = 2816;
	public const TokenType SEP_MinuteSuff = 3072;
	public const TokenType SEP_SecondSuff = 3328;
	public const TokenType SEP_LocalTimeMark = 3584;
	public const TokenType SEP_DateOrOffset = 3840;
	public const TokenType RegularTokenMask = 255;
	public const TokenType SeparatorTokenMask = 65280;
}

// Namespace: 
[Flags]
private enum Guid.GuidStyles // TypeDefIndex: 3036
{
	// Fields
	public int value__; // 0x0
	public const Guid.GuidStyles None = 0;
	public const Guid.GuidStyles AllowParenthesis = 1;
	public const Guid.GuidStyles AllowBraces = 2;
	public const Guid.GuidStyles AllowDashes = 4;
	public const Guid.GuidStyles AllowHexPrefix = 8;
	public const Guid.GuidStyles RequireParenthesis = 16;
	public const Guid.GuidStyles RequireBraces = 32;
	public const Guid.GuidStyles RequireDashes = 64;
	public const Guid.GuidStyles RequireHexPrefix = 128;
	public const Guid.GuidStyles HexFormat = 160;
	public const Guid.GuidStyles NumberFormat = 0;
	public const Guid.GuidStyles DigitFormat = 64;
	public const Guid.GuidStyles BraceFormat = 96;
	public const Guid.GuidStyles ParenthesisFormat = 80;
	public const Guid.GuidStyles Any = 15;
}

// Namespace: 
private enum Guid.GuidParseThrowStyle // TypeDefIndex: 3037
{
	// Fields
	public int value__; // 0x0
	public const Guid.GuidParseThrowStyle None = 0;
	public const Guid.GuidParseThrowStyle All = 1;
	public const Guid.GuidParseThrowStyle AllButOverflow = 2;
}

// Namespace: 
private enum Guid.ParseFailureKind // TypeDefIndex: 3038
{
	// Fields
	public int value__; // 0x0
	public const Guid.ParseFailureKind None = 0;
	public const Guid.ParseFailureKind ArgumentNull = 1;
	public const Guid.ParseFailureKind Format = 2;
	public const Guid.ParseFailureKind FormatWithParameter = 3;
	public const Guid.ParseFailureKind NativeException = 4;
	public const Guid.ParseFailureKind FormatWithInnerException = 5;
}

// Namespace: 
private struct Guid.GuidResult // TypeDefIndex: 3039
{
	// Fields
	internal Guid _parsedGuid; // 0x0
	internal Guid.GuidParseThrowStyle _throwStyle; // 0x10
	private Guid.ParseFailureKind _failure; // 0x14
	private string _failureMessageID; // 0x18
	private object _failureMessageFormatArgument; // 0x20
	private string _failureArgumentName; // 0x28
	private Exception _innerException; // 0x30

	// Methods

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	internal void Init(Guid.GuidParseThrowStyle canThrow) { }

	// RVA: 0x179C030 Offset: 0x179B230 VA: 0x18179C030
	internal void SetFailure(Exception nativeException) { }

	// RVA: 0x179C040 Offset: 0x179B240 VA: 0x18179C040
	internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID) { }

	// RVA: 0x179BFE0 Offset: 0x179B1E0 VA: 0x18179BFE0
	internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	// RVA: 0x179BF80 Offset: 0x179B180 VA: 0x18179BF80
	internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName, Exception innerException) { }

	// RVA: 0x179BDE0 Offset: 0x179AFE0 VA: 0x18179BDE0
	internal Exception GetGuidParseException() { }
}

// Namespace: System
[NonVersionable]
[Serializable]
public struct Guid : IFormattable, IComparable, IComparable<Guid>, IEquatable<Guid>, ISpanFormattable // TypeDefIndex: 3040
{
	// Fields
	public static readonly Guid Empty; // 0x0
	private int _a; // 0x0
	private short _b; // 0x4
	private short _c; // 0x6
	private byte _d; // 0x8
	private byte _e; // 0x9
	private byte _f; // 0xA
	private byte _g; // 0xB
	private byte _h; // 0xC
	private byte _i; // 0xD
	private byte _j; // 0xE
	private byte _k; // 0xF

	// Methods

	// RVA: 0x1796B50 Offset: 0x1795D50 VA: 0x181796B50
	public static Guid NewGuid() { }

	// RVA: 0x1799620 Offset: 0x1798820 VA: 0x181799620
	public void .ctor(byte[] b) { }

	// RVA: 0x1799450 Offset: 0x1798650 VA: 0x181799450
	public void .ctor(ReadOnlySpan<byte> b) { }

	[CLSCompliant(False)]
	// RVA: 0x1799400 Offset: 0x1798600 VA: 0x181799400
	public void .ctor(uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) { }

	// RVA: 0x17996E0 Offset: 0x17988E0 VA: 0x1817996E0
	public void .ctor(int a, short b, short c, byte[] d) { }

	// RVA: 0x1799400 Offset: 0x1798600 VA: 0x181799400
	public void .ctor(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) { }

	// RVA: 0x1799870 Offset: 0x1798A70 VA: 0x181799870
	public void .ctor(string g) { }

	// RVA: 0x1796C30 Offset: 0x1795E30 VA: 0x181796C30
	public static Guid Parse(string input) { }

	// RVA: 0x1796BA0 Offset: 0x1795DA0 VA: 0x181796BA0
	public static Guid Parse(ReadOnlySpan<char> input) { }

	// RVA: 0x17992B0 Offset: 0x17984B0 VA: 0x1817992B0
	public static bool TryParse(string input, out Guid result) { }

	// RVA: 0x1799390 Offset: 0x1798590 VA: 0x181799390
	public static bool TryParse(ReadOnlySpan<char> input, out Guid result) { }

	// RVA: 0x1797ED0 Offset: 0x17970D0 VA: 0x181797ED0
	public static bool TryParseExact(string input, string format, out Guid result) { }

	// RVA: 0x17980C0 Offset: 0x17972C0 VA: 0x1817980C0
	public static bool TryParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, out Guid result) { }

	// RVA: 0x17990E0 Offset: 0x17982E0 VA: 0x1817990E0
	private static bool TryParseGuid(ReadOnlySpan<char> guidString, Guid.GuidStyles flags, ref Guid.GuidResult result) { }

	// RVA: 0x1798510 Offset: 0x1797710 VA: 0x181798510
	private static bool TryParseGuidWithHexPrefix(ReadOnlySpan<char> guidString, ref Guid.GuidResult result) { }

	// RVA: 0x1798CA0 Offset: 0x1797EA0 VA: 0x181798CA0
	private static bool TryParseGuidWithNoStyle(ReadOnlySpan<char> guidString, ref Guid.GuidResult result) { }

	// RVA: 0x17981E0 Offset: 0x17973E0 VA: 0x1817981E0
	private static bool TryParseGuidWithDashes(ReadOnlySpan<char> guidString, ref Guid.GuidResult result) { }

	// RVA: 0x1797080 Offset: 0x1796280 VA: 0x181797080
	private static bool StringToShort(ReadOnlySpan<char> str, int requiredLength, int flags, out short result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x1797020 Offset: 0x1796220 VA: 0x181797020
	private static bool StringToShort(ReadOnlySpan<char> str, ref int parsePos, int requiredLength, int flags, out short result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x1796D60 Offset: 0x1795F60 VA: 0x181796D60
	private static bool StringToInt(ReadOnlySpan<char> str, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x1796DB0 Offset: 0x1795FB0 VA: 0x181796DB0
	private static bool StringToInt(ReadOnlySpan<char> str, ref int parsePos, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x1796F30 Offset: 0x1796130 VA: 0x181796F30
	private static bool StringToLong(ReadOnlySpan<char> str, ref int parsePos, int flags, out long result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x17965A0 Offset: 0x17957A0 VA: 0x1817965A0
	private static ReadOnlySpan<char> EatAllWhitespace(ReadOnlySpan<char> str) { }

	// RVA: 0x1796A90 Offset: 0x1795C90 VA: 0x181796A90
	private static bool IsHexPrefix(ReadOnlySpan<char> str, int i) { }

	// RVA: 0x1789240 Offset: 0x1788440 VA: 0x181789240
	private void WriteByteHelper(Span<byte> destination) { }

	// RVA: 0x1797120 Offset: 0x1796320 VA: 0x181797120
	public byte[] ToByteArray() { }

	// RVA: 0x17971B0 Offset: 0x17963B0 VA: 0x1817971B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1796920 Offset: 0x1795B20 VA: 0x181796920 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1796870 Offset: 0x1795A70 VA: 0x181796870 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1796840 Offset: 0x1795A40 VA: 0x181796840 Slot: 7
	public bool Equals(Guid g) { }

	// RVA: 0x1796930 Offset: 0x1795B30 VA: 0x181796930
	private int GetResult(uint me, uint them) { }

	// RVA: 0x1796130 Offset: 0x1795330 VA: 0x181796130 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1796400 Offset: 0x1795600 VA: 0x181796400 Slot: 6
	public int CompareTo(Guid value) { }

	// RVA: 0x1799990 Offset: 0x1798B90 VA: 0x181799990
	public static bool op_Equality(Guid a, Guid b) { }

	// RVA: 0x17999C0 Offset: 0x1798BC0 VA: 0x1817999C0
	public static bool op_Inequality(Guid a, Guid b) { }

	// RVA: 0x1797460 Offset: 0x1796660 VA: 0x181797460
	public string ToString(string format) { }

	// RVA: 0x1796950 Offset: 0x1795B50 VA: 0x181796950
	private static char HexToChar(int a) { }

	// RVA: 0x1796A10 Offset: 0x1795C10 VA: 0x181796A10
	private static int HexsToChars(char* guidChars, int a, int b) { }

	// RVA: 0x1796970 Offset: 0x1795B70 VA: 0x181796970
	private static int HexsToCharsHexOutput(char* guidChars, int a, int b) { }

	// RVA: 0x17971F0 Offset: 0x17963F0 VA: 0x1817971F0 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1797470 Offset: 0x1796670 VA: 0x181797470
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format) { }

	// RVA: 0x17970E0 Offset: 0x17962E0 VA: 0x1817970E0 Slot: 8
	private bool System.ISpanFormattable.TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }
}

// Namespace: System
public struct HashCode // TypeDefIndex: 3041
{
	// Fields
	private static readonly uint s_seed; // 0x0
	private uint _v1; // 0x0
	private uint _v2; // 0x4
	private uint _v3; // 0x8
	private uint _v4; // 0xC
	private uint _queue1; // 0x10
	private uint _queue2; // 0x14
	private uint _queue3; // 0x18
	private uint _length; // 0x1C

	// Methods

	// RVA: 0x179C280 Offset: 0x179B480 VA: 0x18179C280
	private static uint GenerateGlobalSeed() { }

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3, T4>(T1 value1, T2 value2, T3 value3, T4 value4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B1A80 Offset: 0x9B0C80 VA: 0x1809B1A80
	|-HashCode.Combine<object, AssemblyVersion, object, object>
	|
	|-RVA: 0x9B1E00 Offset: 0x9B1000 VA: 0x1809B1E00
	|-HashCode.Combine<ushort, ushort, ushort, ushort>
	|
	|-RVA: 0x9B0D30 Offset: 0x9AFF30 VA: 0x1809B0D30
	|-HashCode.Combine<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x858440 Offset: 0x857640 VA: 0x180858440
	private static uint Rol(uint value, int count) { }

	// RVA: 0x179C300 Offset: 0x179B500 VA: 0x18179C300
	private static void Initialize(out uint v1, out uint v2, out uint v3, out uint v4) { }

	// RVA: 0x179C570 Offset: 0x179B770 VA: 0x18179C570
	private static uint Round(uint hash, uint input) { }

	// RVA: 0x179C500 Offset: 0x179B700 VA: 0x18179C500
	private static uint QueueRound(uint hash, uint queuedValue) { }

	// RVA: 0x179C460 Offset: 0x179B660 VA: 0x18179C460
	private static uint MixState(uint v1, uint v2, uint v3, uint v4) { }

	// RVA: 0x179C3D0 Offset: 0x179B5D0 VA: 0x18179C3D0
	private static uint MixEmptyState() { }

	// RVA: 0x179C430 Offset: 0x179B630 VA: 0x18179C430
	private static uint MixFinal(uint hash) { }

	// RVA: -1 Offset: -1
	public void Add<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B0790 Offset: 0x9AF990 VA: 0x1809B0790
	|-HashCode.Add<bool>
	|
	|-RVA: 0x9B0830 Offset: 0x9AFA30 VA: 0x1809B0830
	|-HashCode.Add<Color>
	|
	|-RVA: 0x9B0AB0 Offset: 0x9AFCB0 VA: 0x1809B0AB0
	|-HashCode.Add<int>
	|
	|-RVA: 0x9B0BB0 Offset: 0x9AFDB0 VA: 0x1809B0BB0
	|-HashCode.Add<object>
	|
	|-RVA: 0x9B0B30 Offset: 0x9AFD30 VA: 0x1809B0B30
	|-HashCode.Add<Rect>
	|
	|-RVA: 0x9B0C30 Offset: 0x9AFE30 VA: 0x1809B0C30
	|-HashCode.Add<float>
	|
	|-RVA: 0x9B0CB0 Offset: 0x9AFEB0 VA: 0x1809B0CB0
	|-HashCode.Add<Vector4>
	|
	|-RVA: 0x9B0940 Offset: 0x9AFB40 VA: 0x1809B0940
	|-HashCode.Add<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x179C090 Offset: 0x179B290 VA: 0x18179C090
	private void Add(int value) { }

	// RVA: 0x179C5E0 Offset: 0x179B7E0 VA: 0x18179C5E0
	public int ToHashCode() { }

	[Obsolete("HashCode is a mutable struct and should not be compared with other HashCodes. Use ToHashCode to retrieve the computed hash code.", True)]
	// RVA: 0x179C2B0 Offset: 0x179B4B0 VA: 0x18179C2B0 Slot: 2
	public override int GetHashCode() { }

	[Obsolete("HashCode is a mutable struct and should not be compared with other HashCodes.", True)]
	// RVA: 0x179C230 Offset: 0x179B430 VA: 0x18179C230 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x179C830 Offset: 0x179BA30 VA: 0x18179C830
	private static void .cctor() { }
}

// Namespace: System
public interface IAsyncResult // TypeDefIndex: 3042
{
	// Properties
	public abstract bool IsCompleted { get; }
	public abstract WaitHandle AsyncWaitHandle { get; }
	public abstract object AsyncState { get; }
	public abstract bool CompletedSynchronously { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsCompleted();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract WaitHandle get_AsyncWaitHandle();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object get_AsyncState();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_CompletedSynchronously();
}

// Namespace: System
public interface ICloneable // TypeDefIndex: 3043
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object Clone();
}

// Namespace: System
public interface IComparable // TypeDefIndex: 3044
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int CompareTo(object obj);
}

// Namespace: System
public interface IComparable<T> // TypeDefIndex: 3045
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int CompareTo(T other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IComparable<__Il2CppFullySharedGenericType>.CompareTo
	*/
}

// Namespace: System
[CLSCompliant(False)]
public interface IConvertible // TypeDefIndex: 3046
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TypeCode GetTypeCode();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool ToBoolean(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract char ToChar(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract sbyte ToSByte(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract byte ToByte(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract short ToInt16(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract ushort ToUInt16(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int ToInt32(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract uint ToUInt32(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract long ToInt64(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract ulong ToUInt64(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract float ToSingle(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract double ToDouble(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract Decimal ToDecimal(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract DateTime ToDateTime(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract string ToString(IFormatProvider provider);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract object ToType(Type conversionType, IFormatProvider provider);
}

// Namespace: System
public interface ICustomFormatter // TypeDefIndex: 3047
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string Format(string format, object arg, IFormatProvider formatProvider);
}

// Namespace: System
public interface IDisposable // TypeDefIndex: 3048
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Dispose();
}

// Namespace: System
public interface IEquatable<T> // TypeDefIndex: 3049
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Equals(T other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IEquatable<__Il2CppFullySharedGenericType>.Equals
	*/
}

// Namespace: System
public interface IFormatProvider // TypeDefIndex: 3050
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetFormat(Type formatType);
}

// Namespace: System
public interface IFormattable // TypeDefIndex: 3051
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string ToString(string format, IFormatProvider formatProvider);
}

// Namespace: System
internal interface ISpanFormattable // TypeDefIndex: 3052
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider);
}

// Namespace: System
[Serializable]
public sealed class IndexOutOfRangeException : SystemException // TypeDefIndex: 3053
{
	// Methods

	// RVA: 0x179C890 Offset: 0x179BA90 VA: 0x18179C890
	public void .ctor() { }

	// RVA: 0x179C8E0 Offset: 0x179BAE0 VA: 0x18179C8E0
	public void .ctor(string message) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System
[Serializable]
public sealed class InsufficientExecutionStackException : SystemException // TypeDefIndex: 3054
{
	// Methods

	// RVA: 0x179C900 Offset: 0x179BB00 VA: 0x18179C900
	public void .ctor() { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System
[IsReadOnly]
[Serializable]
public struct Int16 : IComparable, IConvertible, IFormattable, IComparable<short>, IEquatable<short>, ISpanFormattable // TypeDefIndex: 3055
{
	// Fields
	private readonly short m_value; // 0x0
	public const short MaxValue = 32767;
	public const short MinValue = -32768;

	// Methods

	// RVA: 0x179C950 Offset: 0x179BB50 VA: 0x18179C950 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x179CA30 Offset: 0x179BC30 VA: 0x18179CA30 Slot: 23
	public int CompareTo(short value) { }

	// RVA: 0x179CA40 Offset: 0x179BC40 VA: 0x18179CA40 Slot: 0
	public override bool Equals(object obj) { }

	[NonVersionable]
	// RVA: 0x176E560 Offset: 0x176D760 VA: 0x18176E560 Slot: 24
	public bool Equals(short obj) { }

	// RVA: 0x179CAD0 Offset: 0x179BCD0 VA: 0x18179CAD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x179D510 Offset: 0x179C710 VA: 0x18179D510 Slot: 3
	public override string ToString() { }

	// RVA: 0x179D480 Offset: 0x179C680 VA: 0x18179D480 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x179D2F0 Offset: 0x179C4F0 VA: 0x18179D2F0 Slot: 22
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x179D590 Offset: 0x179C790 VA: 0x18179D590 Slot: 25
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x179CAE0 Offset: 0x179BCE0 VA: 0x18179CAE0
	public static short Parse(string s, IFormatProvider provider) { }

	// RVA: 0x179CB90 Offset: 0x179BD90 VA: 0x18179CB90
	public static short Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x179CC50 Offset: 0x179BE50 VA: 0x18179CC50
	private static short Parse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x179D790 Offset: 0x179C990 VA: 0x18179D790
	public static bool TryParse(string s, out short result) { }

	// RVA: 0x179D8D0 Offset: 0x179CAD0 VA: 0x18179D8D0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out short result) { }

	// RVA: 0x179D6C0 Offset: 0x179C8C0 VA: 0x18179D6C0
	private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out short result) { }

	// RVA: 0x68EEF0 Offset: 0x68E0F0 VA: 0x18068EEF0 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x179CDE0 Offset: 0x179BFE0 VA: 0x18179CDE0 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x179CE80 Offset: 0x179C080 VA: 0x18179CE80 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x179D0C0 Offset: 0x179C2C0 VA: 0x18179D0C0 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x179CE30 Offset: 0x179C030 VA: 0x18179CE30 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0DF0 VA: 0x1804D1BF0 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x179D200 Offset: 0x179C400 VA: 0x18179D200 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x179D020 Offset: 0x179C220 VA: 0x18179D020 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x179D250 Offset: 0x179C450 VA: 0x18179D250 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x179D070 Offset: 0x179C270 VA: 0x18179D070 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x179D2A0 Offset: 0x179C4A0 VA: 0x18179D2A0 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x179D110 Offset: 0x179C310 VA: 0x18179D110 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x179CFD0 Offset: 0x179C1D0 VA: 0x18179CFD0 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x179CF60 Offset: 0x179C160 VA: 0x18179CF60 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x179CED0 Offset: 0x179C0D0 VA: 0x18179CED0 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x179D160 Offset: 0x179C360 VA: 0x18179D160 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

// Namespace: System
[IsReadOnly]
[Serializable]
public struct Int32 : IComparable, IConvertible, IFormattable, IComparable<int>, IEquatable<int>, ISpanFormattable // TypeDefIndex: 3056
{
	// Fields
	private readonly int m_value; // 0x0
	public const int MaxValue = 2147483647;
	public const int MinValue = -2147483648;

	// Methods

	// RVA: 0x179D990 Offset: 0x179CB90 VA: 0x18179D990 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x179DA80 Offset: 0x179CC80 VA: 0x18179DA80 Slot: 23
	public int CompareTo(int value) { }

	// RVA: 0x179DAA0 Offset: 0x179CCA0 VA: 0x18179DAA0 Slot: 0
	public override bool Equals(object obj) { }

	[NonVersionable]
	// RVA: 0x179DB20 Offset: 0x179CD20 VA: 0x18179DB20 Slot: 24
	public bool Equals(int obj) { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x179E440 Offset: 0x179D640 VA: 0x18179E440 Slot: 3
	public override string ToString() { }

	// RVA: 0x179E550 Offset: 0x179D750 VA: 0x18179E550
	public string ToString(string format) { }

	// RVA: 0x179E4C0 Offset: 0x179D6C0 VA: 0x18179E4C0 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x179E610 Offset: 0x179D810 VA: 0x18179E610 Slot: 22
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x179E6E0 Offset: 0x179D8E0 VA: 0x18179E6E0 Slot: 25
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x179DB30 Offset: 0x179CD30 VA: 0x18179DB30
	public static int Parse(string s) { }

	// RVA: 0x179DE60 Offset: 0x179D060 VA: 0x18179DE60
	public static int Parse(string s, NumberStyles style) { }

	// RVA: 0x179DD80 Offset: 0x179CF80 VA: 0x18179DD80
	public static int Parse(string s, IFormatProvider provider) { }

	// RVA: 0x179DC00 Offset: 0x179CE00 VA: 0x18179DC00
	public static int Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x179DCF0 Offset: 0x179CEF0 VA: 0x18179DCF0
	public static int Parse(ReadOnlySpan<char> s, NumberStyles style = 7, IFormatProvider provider) { }

	// RVA: 0x179E910 Offset: 0x179DB10 VA: 0x18179E910
	public static bool TryParse(string s, out int result) { }

	// RVA: 0x179E820 Offset: 0x179DA20 VA: 0x18179E820
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out int result) { }

	// RVA: 0x179E780 Offset: 0x179D980 VA: 0x18179E780
	public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out int result) { }

	// RVA: 0x563540 Offset: 0x562740 VA: 0x180563540 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x179DF40 Offset: 0x179D140 VA: 0x18179DF40 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x179DFE0 Offset: 0x179D1E0 VA: 0x18179DFE0 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x179E220 Offset: 0x179D420 VA: 0x18179E220 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x179DF90 Offset: 0x179D190 VA: 0x18179DF90 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x179E180 Offset: 0x179D380 VA: 0x18179E180 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x179E350 Offset: 0x179D550 VA: 0x18179E350 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x179E3A0 Offset: 0x179D5A0 VA: 0x18179E3A0 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x179E1D0 Offset: 0x179D3D0 VA: 0x18179E1D0 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x179E3F0 Offset: 0x179D5F0 VA: 0x18179E3F0 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x179E270 Offset: 0x179D470 VA: 0x18179E270 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x179E130 Offset: 0x179D330 VA: 0x18179E130 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x179E0C0 Offset: 0x179D2C0 VA: 0x18179E0C0 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x179E030 Offset: 0x179D230 VA: 0x18179E030 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x179E2C0 Offset: 0x179D4C0 VA: 0x18179E2C0 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

// Namespace: System
[IsReadOnly]
[Serializable]
public struct Int64 : IComparable, IConvertible, IFormattable, IComparable<long>, IEquatable<long>, ISpanFormattable // TypeDefIndex: 3057
{
	// Fields
	private readonly long m_value; // 0x0
	public const long MaxValue = 9223372036854775807;
	public const long MinValue = -9223372036854775808;

	// Methods

	// RVA: 0x179E9F0 Offset: 0x179DBF0 VA: 0x18179E9F0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x179EAE0 Offset: 0x179DCE0 VA: 0x18179EAE0 Slot: 23
	public int CompareTo(long value) { }

	// RVA: 0x179EB00 Offset: 0x179DD00 VA: 0x18179EB00 Slot: 0
	public override bool Equals(object obj) { }

	[NonVersionable]
	// RVA: 0x126BA20 Offset: 0x126AC20 VA: 0x18126BA20 Slot: 24
	public bool Equals(long obj) { }

	// RVA: 0x179EB90 Offset: 0x179DD90 VA: 0x18179EB90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x179F360 Offset: 0x179E560 VA: 0x18179F360 Slot: 3
	public override string ToString() { }

	// RVA: 0x179F3E0 Offset: 0x179E5E0 VA: 0x18179F3E0 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x179F540 Offset: 0x179E740 VA: 0x18179F540
	public string ToString(string format) { }

	// RVA: 0x179F470 Offset: 0x179E670 VA: 0x18179F470 Slot: 22
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x179F600 Offset: 0x179E800 VA: 0x18179F600 Slot: 25
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x179ECA0 Offset: 0x179DEA0 VA: 0x18179ECA0
	public static long Parse(string s) { }

	// RVA: 0x179ED70 Offset: 0x179DF70 VA: 0x18179ED70
	public static long Parse(string s, IFormatProvider provider) { }

	// RVA: 0x179EBB0 Offset: 0x179DDB0 VA: 0x18179EBB0
	public static long Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x179F6B0 Offset: 0x179E8B0 VA: 0x18179F6B0
	public static bool TryParse(string s, out long result) { }

	// RVA: 0x179F790 Offset: 0x179E990 VA: 0x18179F790
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result) { }

	// RVA: 0x179EBA0 Offset: 0x179DDA0 VA: 0x18179EBA0 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x179EE50 Offset: 0x179E050 VA: 0x18179EE50 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x179EEF0 Offset: 0x179E0F0 VA: 0x18179EEF0 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x179F130 Offset: 0x179E330 VA: 0x18179F130 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x179EEA0 Offset: 0x179E0A0 VA: 0x18179EEA0 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x179F090 Offset: 0x179E290 VA: 0x18179F090 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x179F270 Offset: 0x179E470 VA: 0x18179F270 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x179F0E0 Offset: 0x179E2E0 VA: 0x18179F0E0 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x179F2C0 Offset: 0x179E4C0 VA: 0x18179F2C0 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x179F310 Offset: 0x179E510 VA: 0x18179F310 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x179F180 Offset: 0x179E380 VA: 0x18179F180 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x179F040 Offset: 0x179E240 VA: 0x18179F040 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x179EFD0 Offset: 0x179E1D0 VA: 0x18179EFD0 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x179EF40 Offset: 0x179E140 VA: 0x18179EF40 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x179F1D0 Offset: 0x179E3D0 VA: 0x18179F1D0 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }
}

// Namespace: System
[Serializable]
public class InvalidCastException : SystemException // TypeDefIndex: 3058
{
	// Methods

	// RVA: 0x179F8B0 Offset: 0x179EAB0 VA: 0x18179F8B0
	public void .ctor() { }

	// RVA: 0x179F900 Offset: 0x179EB00 VA: 0x18179F900
	public void .ctor(string message) { }

	// RVA: 0x179F890 Offset: 0x179EA90 VA: 0x18179F890
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System
[Serializable]
public class InvalidOperationException : SystemException // TypeDefIndex: 3059
{
	// Methods

	// RVA: 0x179F920 Offset: 0x179EB20 VA: 0x18179F920
	public void .ctor() { }

	// RVA: 0x179F990 Offset: 0x179EB90 VA: 0x18179F990
	public void .ctor(string message) { }

	// RVA: 0x179F970 Offset: 0x179EB70 VA: 0x18179F970
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System
[Serializable]
public sealed class InvalidProgramException : SystemException // TypeDefIndex: 3060
{
	// Methods

	// RVA: 0x179F9B0 Offset: 0x179EBB0 VA: 0x18179F9B0
	public void .ctor() { }

	// RVA: 0x179FA00 Offset: 0x179EC00 VA: 0x18179FA00
	public void .ctor(string message) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System
[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
[Serializable]
public class InvalidTimeZoneException : Exception // TypeDefIndex: 3061
{
	// Methods

	// RVA: 0x179FA80 Offset: 0x179EC80 VA: 0x18179FA80
	public void .ctor() { }

	// RVA: 0x179FA20 Offset: 0x179EC20 VA: 0x18179FA20
	public void .ctor(string message) { }

	// RVA: 0x179FAD0 Offset: 0x179ECD0 VA: 0x18179FAD0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x179FB40 Offset: 0x179ED40 VA: 0x18179FB40
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System
internal enum LazyState // TypeDefIndex: 3062
{
	// Fields
	public int value__; // 0x0
	public const LazyState NoneViaConstructor = 0;
	public const LazyState NoneViaFactory = 1;
	public const LazyState NoneException = 2;
	public const LazyState PublicationOnlyViaConstructor = 3;
	public const LazyState PublicationOnlyViaFactory = 4;
	public const LazyState PublicationOnlyWait = 5;
	public const LazyState PublicationOnlyException = 6;
	public const LazyState ExecutionAndPublicationViaConstructor = 7;
	public const LazyState ExecutionAndPublicationViaFactory = 8;
	public const LazyState ExecutionAndPublicationException = 9;
}

// Namespace: System
internal class LazyHelper // TypeDefIndex: 3063
{
	// Fields
	internal static readonly LazyHelper NoneViaConstructor; // 0x0
	internal static readonly LazyHelper NoneViaFactory; // 0x8
	internal static readonly LazyHelper PublicationOnlyViaConstructor; // 0x10
	internal static readonly LazyHelper PublicationOnlyViaFactory; // 0x18
	internal static readonly LazyHelper PublicationOnlyWaitForOtherThreadToPublish; // 0x20
	[CompilerGenerated]
	private readonly LazyState <State>k__BackingField; // 0x10
	private readonly ExceptionDispatchInfo _exceptionDispatch; // 0x18

	// Properties
	internal LazyState State { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	internal LazyState get_State() { }

	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	internal void .ctor(LazyState state) { }

	// RVA: 0x179FF20 Offset: 0x179F120 VA: 0x18179FF20
	internal void .ctor(LazyThreadSafetyMode mode, Exception exception) { }

	// RVA: 0x179FDD0 Offset: 0x179EFD0 VA: 0x18179FDD0
	internal void ThrowException() { }

	// RVA: 0x179FC30 Offset: 0x179EE30 VA: 0x18179FC30
	internal static LazyHelper Create(LazyThreadSafetyMode mode, bool useDefaultConstructor) { }

	// RVA: 0x179FBC0 Offset: 0x179EDC0 VA: 0x18179FBC0
	internal static object CreateViaDefaultConstructor(Type type) { }

	// RVA: 0x179FDF0 Offset: 0x179EFF0 VA: 0x18179FDF0
	private static void .cctor() { }
}

// Namespace: System
[DebuggerDisplay("ThreadSafetyMode={Mode}, IsValueCreated={IsValueCreated}, IsValueFaulted={IsValueFaulted}, Value={ValueForDebugDisplay}")]
[DebuggerTypeProxy(typeof(LazyDebugView<T>))]
[Serializable]
public class Lazy<T> // TypeDefIndex: 3064
{
	// Fields
	private LazyHelper _state; // 0x0
	private Func<T> _factory; // 0x0
	private T _value; // 0x0

	// Properties
	public bool IsValueCreated { get; }
	[DebuggerBrowsable(0)]
	public T Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	private static T CreateViaDefaultConstructor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131E7E0 Offset: 0x131D9E0 VA: 0x18131E7E0
	|-Lazy<bool>.CreateViaDefaultConstructor
	|
	|-RVA: 0x131E8E0 Offset: 0x131DAE0 VA: 0x18131E8E0
	|-Lazy<DateTimeOffset>.CreateViaDefaultConstructor
	|
	|-RVA: 0x131E6D0 Offset: 0x131D8D0 VA: 0x18131E6D0
	|-Lazy<object>.CreateViaDefaultConstructor
	|
	|-RVA: 0x131EA00 Offset: 0x131DC00 VA: 0x18131EA00
	|-Lazy<__Il2CppFullySharedGenericType>.CreateViaDefaultConstructor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13208C0 Offset: 0x131FAC0 VA: 0x1813208C0
	|-Lazy<bool>..ctor
	|
	|-RVA: 0x1320C80 Offset: 0x131FE80 VA: 0x181320C80
	|-Lazy<DateTimeOffset>..ctor
	|
	|-RVA: 0x13206C0 Offset: 0x131F8C0 VA: 0x1813206C0
	|-Lazy<object>..ctor
	|
	|-RVA: 0x1320890 Offset: 0x131FA90 VA: 0x181320890
	|-Lazy<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1320EE0 Offset: 0x13200E0 VA: 0x181320EE0
	|-Lazy<bool>..ctor
	|
	|-RVA: 0x1320D00 Offset: 0x131FF00 VA: 0x181320D00
	|-Lazy<DateTimeOffset>..ctor
	|
	|-RVA: 0x1320B00 Offset: 0x131FD00 VA: 0x181320B00
	|-Lazy<object>..ctor
	|
	|-RVA: 0x1320DD0 Offset: 0x131FFD0 VA: 0x181320DD0
	|-Lazy<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(LazyThreadSafetyMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1320FB0 Offset: 0x13201B0 VA: 0x181320FB0
	|-Lazy<bool>..ctor
	|
	|-RVA: 0x1320C00 Offset: 0x131FE00 VA: 0x181320C00
	|-Lazy<DateTimeOffset>..ctor
	|
	|-RVA: 0x1320640 Offset: 0x131F840 VA: 0x181320640
	|-Lazy<object>..ctor
	|
	|-RVA: 0x1320BD0 Offset: 0x131FDD0 VA: 0x181320BD0
	|-Lazy<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(Func<T> valueFactory, LazyThreadSafetyMode mode, bool useDefaultConstructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1320E00 Offset: 0x1320000 VA: 0x181320E00
	|-Lazy<bool>..ctor
	|
	|-RVA: 0x1320A20 Offset: 0x131FC20 VA: 0x181320A20
	|-Lazy<DateTimeOffset>..ctor
	|
	|-RVA: 0x1320940 Offset: 0x131FB40 VA: 0x181320940
	|-Lazy<object>..ctor
	|
	|-RVA: 0x1320740 Offset: 0x131F940 VA: 0x181320740
	|-Lazy<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void ViaConstructor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131FF80 Offset: 0x131F180 VA: 0x18131FF80
	|-Lazy<bool>.ViaConstructor
	|
	|-RVA: 0x13200F0 Offset: 0x131F2F0 VA: 0x1813200F0
	|-Lazy<DateTimeOffset>.ViaConstructor
	|
	|-RVA: 0x131FFC0 Offset: 0x131F1C0 VA: 0x18131FFC0
	|-Lazy<object>.ViaConstructor
	|
	|-RVA: 0x1320000 Offset: 0x131F200 VA: 0x181320000
	|-Lazy<__Il2CppFullySharedGenericType>.ViaConstructor
	*/

	// RVA: -1 Offset: -1
	private void ViaFactory(LazyThreadSafetyMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1320320 Offset: 0x131F520 VA: 0x181320320
	|-Lazy<bool>.ViaFactory
	|
	|-RVA: 0x1320220 Offset: 0x131F420 VA: 0x181320220
	|-Lazy<DateTimeOffset>.ViaFactory
	|
	|-RVA: 0x1320130 Offset: 0x131F330 VA: 0x181320130
	|-Lazy<object>.ViaFactory
	|
	|-RVA: 0x1320410 Offset: 0x131F610 VA: 0x181320410
	|-Lazy<__Il2CppFullySharedGenericType>.ViaFactory
	*/

	// RVA: -1 Offset: -1
	private void ExecutionAndPublication(LazyHelper executionAndPublication, bool useDefaultConstructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131EEE0 Offset: 0x131E0E0 VA: 0x18131EEE0
	|-Lazy<bool>.ExecutionAndPublication
	|
	|-RVA: 0x131EB60 Offset: 0x131DD60 VA: 0x18131EB60
	|-Lazy<DateTimeOffset>.ExecutionAndPublication
	|
	|-RVA: 0x131EDC0 Offset: 0x131DFC0 VA: 0x18131EDC0
	|-Lazy<object>.ExecutionAndPublication
	|
	|-RVA: 0x131EC90 Offset: 0x131DE90 VA: 0x18131EC90
	|-Lazy<__Il2CppFullySharedGenericType>.ExecutionAndPublication
	*/

	// RVA: -1 Offset: -1
	private void PublicationOnly(LazyHelper publicationOnly, T possibleValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131FAC0 Offset: 0x131ECC0 VA: 0x18131FAC0
	|-Lazy<bool>.PublicationOnly
	|
	|-RVA: 0x131F7C0 Offset: 0x131E9C0 VA: 0x18131F7C0
	|-Lazy<DateTimeOffset>.PublicationOnly
	|
	|-RVA: 0x131F860 Offset: 0x131EA60 VA: 0x18131F860
	|-Lazy<object>.PublicationOnly
	|
	|-RVA: 0x131F900 Offset: 0x131EB00 VA: 0x18131F900
	|-Lazy<__Il2CppFullySharedGenericType>.PublicationOnly
	*/

	// RVA: -1 Offset: -1
	private void PublicationOnlyViaConstructor(LazyHelper initializer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131F0E0 Offset: 0x131E2E0 VA: 0x18131F0E0
	|-Lazy<bool>.PublicationOnlyViaConstructor
	|
	|-RVA: 0x131F140 Offset: 0x131E340 VA: 0x18131F140
	|-Lazy<DateTimeOffset>.PublicationOnlyViaConstructor
	|
	|-RVA: 0x131F1F0 Offset: 0x131E3F0 VA: 0x18131F1F0
	|-Lazy<object>.PublicationOnlyViaConstructor
	|
	|-RVA: 0x131F000 Offset: 0x131E200 VA: 0x18131F000
	|-Lazy<__Il2CppFullySharedGenericType>.PublicationOnlyViaConstructor
	*/

	// RVA: -1 Offset: -1
	private void PublicationOnlyViaFactory(LazyHelper initializer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131F250 Offset: 0x131E450 VA: 0x18131F250
	|-Lazy<bool>.PublicationOnlyViaFactory
	|
	|-RVA: 0x131F490 Offset: 0x131E690 VA: 0x18131F490
	|-Lazy<DateTimeOffset>.PublicationOnlyViaFactory
	|
	|-RVA: 0x131F400 Offset: 0x131E600 VA: 0x18131F400
	|-Lazy<object>.PublicationOnlyViaFactory
	|
	|-RVA: 0x131F2E0 Offset: 0x131E4E0 VA: 0x18131F2E0
	|-Lazy<__Il2CppFullySharedGenericType>.PublicationOnlyViaFactory
	*/

	// RVA: -1 Offset: -1
	private void PublicationOnlyWaitForOtherThreadToPublish() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131F6C0 Offset: 0x131E8C0 VA: 0x18131F6C0
	|-Lazy<bool>.PublicationOnlyWaitForOtherThreadToPublish
	|
	|-RVA: 0x131F640 Offset: 0x131E840 VA: 0x18131F640
	|-Lazy<DateTimeOffset>.PublicationOnlyWaitForOtherThreadToPublish
	|
	|-RVA: 0x131F740 Offset: 0x131E940 VA: 0x18131F740
	|-Lazy<object>.PublicationOnlyWaitForOtherThreadToPublish
	|
	|-RVA: 0x131F570 Offset: 0x131E770 VA: 0x18131F570
	|-Lazy<__Il2CppFullySharedGenericType>.PublicationOnlyWaitForOtherThreadToPublish
	*/

	// RVA: -1 Offset: -1
	private T CreateValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131E050 Offset: 0x131D250 VA: 0x18131E050
	|-Lazy<bool>.CreateValue
	|
	|-RVA: 0x131E3F0 Offset: 0x131D5F0 VA: 0x18131E3F0
	|-Lazy<DateTimeOffset>.CreateValue
	|
	|-RVA: 0x131DEA0 Offset: 0x131D0A0 VA: 0x18131DEA0
	|-Lazy<object>.CreateValue
	|
	|-RVA: 0x131E200 Offset: 0x131D400 VA: 0x18131E200
	|-Lazy<__Il2CppFullySharedGenericType>.CreateValue
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131FC00 Offset: 0x131EE00 VA: 0x18131FC00
	|-Lazy<bool>.ToString
	|
	|-RVA: 0x131FCC0 Offset: 0x131EEC0 VA: 0x18131FCC0
	|-Lazy<DateTimeOffset>.ToString
	|
	|-RVA: 0x131FB60 Offset: 0x131ED60 VA: 0x18131FB60
	|-Lazy<object>.ToString
	|
	|-RVA: 0x131FDC0 Offset: 0x131EFC0 VA: 0x18131FDC0
	|-Lazy<__Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1
	public bool get_IsValueCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1321030 Offset: 0x1320230 VA: 0x181321030
	|-Lazy<bool>.get_IsValueCreated
	|-Lazy<DateTimeOffset>.get_IsValueCreated
	|-Lazy<object>.get_IsValueCreated
	|
	|-RVA: 0x1321050 Offset: 0x1320250 VA: 0x181321050
	|-Lazy<__Il2CppFullySharedGenericType>.get_IsValueCreated
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1321090 Offset: 0x1320290 VA: 0x181321090
	|-Lazy<bool>.get_Value
	|
	|-RVA: 0x1321570 Offset: 0x1320770 VA: 0x181321570
	|-Lazy<DateTimeOffset>.get_Value
	|
	|-RVA: 0x1321270 Offset: 0x1320470 VA: 0x181321270
	|-Lazy<object>.get_Value
	|
	|-RVA: 0x1321450 Offset: 0x1320650 VA: 0x181321450
	|-Lazy<__Il2CppFullySharedGenericType>.get_Value
	*/
}

// Namespace: System
internal sealed class LazyDebugView<T> // TypeDefIndex: 3065
{}

// Namespace: System
internal static class Marvin // TypeDefIndex: 3066
{
	// Fields
	[CompilerGenerated]
	private static readonly ulong <DefaultSeed>k__BackingField; // 0x0

	// Properties
	public static ulong DefaultSeed { get; }

	// Methods

	// RVA: 0x17A0030 Offset: 0x179F230 VA: 0x1817A0030
	public static int ComputeHash32(ReadOnlySpan<byte> data, ulong seed) { }

	// RVA: 0x17A00D0 Offset: 0x179F2D0 VA: 0x1817A00D0
	public static int ComputeHash32(ref byte data, int count, ulong seed) { }

	// RVA: 0x179FF90 Offset: 0x179F190 VA: 0x18179FF90
	private static void Block(ref uint rp0, ref uint rp1) { }

	// RVA: 0x858440 Offset: 0x857640 VA: 0x180858440
	private static uint _rotl(uint value, int shift) { }

	[CompilerGenerated]
	// RVA: 0x17A05F0 Offset: 0x179F7F0 VA: 0x1817A05F0
	public static ulong get_DefaultSeed() { }

	// RVA: 0x17A05A0 Offset: 0x179F7A0 VA: 0x1817A05A0
	private static ulong GenerateSeed() { }

	// RVA: 0x17A05B0 Offset: 0x179F7B0 VA: 0x1817A05B0
	private static void .cctor() { }
}

// Namespace: System
public static class Math // TypeDefIndex: 3067
{
	// Fields
	private static double doubleRoundLimit; // 0x0
	private static double[] roundPower10Double; // 0x8

	// Methods

	// RVA: 0x17A0690 Offset: 0x179F890 VA: 0x1817A0690
	public static int Abs(int value) { }

	// RVA: 0x17A0640 Offset: 0x179F840 VA: 0x1817A0640
	public static long Abs(long value) { }

	// RVA: 0x17A0700 Offset: 0x179F900 VA: 0x1817A0700
	public static Decimal Abs(Decimal value) { }

	[StackTraceHidden]
	// RVA: 0x17A11A0 Offset: 0x17A03A0 VA: 0x1817A11A0
	private static void ThrowAbsOverflow() { }

	// RVA: 0x17A0870 Offset: 0x179FA70 VA: 0x1817A0870
	public static int DivRem(int a, int b, out int result) { }

	// RVA: 0x17A07C0 Offset: 0x179F9C0 VA: 0x1817A07C0
	public static int Clamp(int value, int min, int max) { }

	// RVA: 0x17A08D0 Offset: 0x179FAD0 VA: 0x1817A08D0
	public static double Log(double a, double newBase) { }

	[NonVersionable]
	// RVA: 0x17A09D0 Offset: 0x179FBD0 VA: 0x1817A09D0
	public static byte Max(byte val1, byte val2) { }

	// RVA: 0x17A0AA0 Offset: 0x179FCA0 VA: 0x1817A0AA0
	public static Decimal Max(Decimal val1, Decimal val2) { }

	// RVA: 0x17A0A10 Offset: 0x179FC10 VA: 0x1817A0A10
	public static double Max(double val1, double val2) { }

	[NonVersionable]
	// RVA: 0x17A0A40 Offset: 0x179FC40 VA: 0x1817A0A40
	public static short Max(short val1, short val2) { }

	[NonVersionable]
	// RVA: 0x17A09E0 Offset: 0x179FBE0 VA: 0x1817A09E0
	public static int Max(int val1, int val2) { }

	[NonVersionable]
	// RVA: 0x17A0A90 Offset: 0x179FC90 VA: 0x1817A0A90
	public static long Max(long val1, long val2) { }

	[CLSCompliant(False)]
	[NonVersionable]
	// RVA: 0x17A0A50 Offset: 0x179FC50 VA: 0x1817A0A50
	public static sbyte Max(sbyte val1, sbyte val2) { }

	// RVA: 0x17A0A70 Offset: 0x179FC70 VA: 0x1817A0A70
	public static float Max(float val1, float val2) { }

	[NonVersionable]
	[CLSCompliant(False)]
	// RVA: 0x17A0A00 Offset: 0x179FC00 VA: 0x1817A0A00
	public static ushort Max(ushort val1, ushort val2) { }

	[NonVersionable]
	[CLSCompliant(False)]
	// RVA: 0x17A09F0 Offset: 0x179FBF0 VA: 0x1817A09F0
	public static uint Max(uint val1, uint val2) { }

	[CLSCompliant(False)]
	[NonVersionable]
	// RVA: 0x17A0A60 Offset: 0x179FC60 VA: 0x1817A0A60
	public static ulong Max(ulong val1, ulong val2) { }

	[NonVersionable]
	// RVA: 0x17A0BD0 Offset: 0x179FDD0 VA: 0x1817A0BD0
	public static byte Min(byte val1, byte val2) { }

	// RVA: 0x17A0B50 Offset: 0x179FD50 VA: 0x1817A0B50
	public static Decimal Min(Decimal val1, Decimal val2) { }

	// RVA: 0x17A0C00 Offset: 0x179FE00 VA: 0x1817A0C00
	public static double Min(double val1, double val2) { }

	[NonVersionable]
	// RVA: 0x17A0BC0 Offset: 0x179FDC0 VA: 0x1817A0BC0
	public static short Min(short val1, short val2) { }

	[NonVersionable]
	// RVA: 0x17A0BE0 Offset: 0x179FDE0 VA: 0x1817A0BE0
	public static int Min(int val1, int val2) { }

	[NonVersionable]
	// RVA: 0x17A0C40 Offset: 0x179FE40 VA: 0x1817A0C40
	public static long Min(long val1, long val2) { }

	[NonVersionable]
	[CLSCompliant(False)]
	// RVA: 0x17A0B30 Offset: 0x179FD30 VA: 0x1817A0B30
	public static sbyte Min(sbyte val1, sbyte val2) { }

	// RVA: 0x17A0C50 Offset: 0x179FE50 VA: 0x1817A0C50
	public static float Min(float val1, float val2) { }

	[CLSCompliant(False)]
	[NonVersionable]
	// RVA: 0x17A0C30 Offset: 0x179FE30 VA: 0x1817A0C30
	public static ushort Min(ushort val1, ushort val2) { }

	[CLSCompliant(False)]
	[NonVersionable]
	// RVA: 0x17A0BF0 Offset: 0x179FDF0 VA: 0x1817A0BF0
	public static uint Min(uint val1, uint val2) { }

	[CLSCompliant(False)]
	[NonVersionable]
	// RVA: 0x17A0B40 Offset: 0x179FD40 VA: 0x1817A0B40
	public static ulong Min(ulong val1, ulong val2) { }

	// RVA: 0x17A1030 Offset: 0x17A0230 VA: 0x1817A1030
	public static Decimal Round(Decimal d) { }

	// RVA: 0x17A1020 Offset: 0x17A0220 VA: 0x1817A1020
	public static double Round(double a) { }

	// RVA: 0x17A0C90 Offset: 0x179FE90 VA: 0x1817A0C90
	public static double Round(double value, int digits) { }

	// RVA: 0x17A0CF0 Offset: 0x179FEF0 VA: 0x1817A0CF0
	public static double Round(double value, int digits, MidpointRounding mode) { }

	// RVA: 0x17A10B0 Offset: 0x17A02B0 VA: 0x1817A10B0
	public static int Sign(double value) { }

	// RVA: 0x17A1140 Offset: 0x17A0340 VA: 0x1817A1140
	public static int Sign(long value) { }

	// RVA: 0x17A1260 Offset: 0x17A0460 VA: 0x1817A1260
	public static Decimal Truncate(Decimal d) { }

	// RVA: 0x17A11F0 Offset: 0x17A03F0 VA: 0x1817A11F0
	public static double Truncate(double d) { }

	// RVA: -1 Offset: -1
	private static void ThrowMinMaxException<T>(T min, T max) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA47210 Offset: 0xA46410 VA: 0x180A47210
	|-Math.ThrowMinMaxException<int>
	|
	|-RVA: 0xA470B0 Offset: 0xA462B0 VA: 0x180A470B0
	|-Math.ThrowMinMaxException<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x17A06F0 Offset: 0x179F8F0 VA: 0x1817A06F0
	public static double Abs(double value) { }

	// RVA: 0x17A06E0 Offset: 0x179F8E0 VA: 0x1817A06E0
	public static float Abs(float value) { }

	// RVA: 0x17A0770 Offset: 0x179F970 VA: 0x1817A0770
	public static double Acos(double d) { }

	// RVA: 0x17A0780 Offset: 0x179F980 VA: 0x1817A0780
	public static double Asin(double d) { }

	// RVA: 0x17A07A0 Offset: 0x179F9A0 VA: 0x1817A07A0
	public static double Atan(double d) { }

	// RVA: 0x17A0790 Offset: 0x179F990 VA: 0x1817A0790
	public static double Atan2(double y, double x) { }

	// RVA: 0x17A07B0 Offset: 0x179F9B0 VA: 0x1817A07B0
	public static double Ceiling(double a) { }

	// RVA: 0x17A0860 Offset: 0x179FA60 VA: 0x1817A0860
	public static double Cos(double d) { }

	// RVA: 0x17A0890 Offset: 0x179FA90 VA: 0x1817A0890
	public static double Exp(double d) { }

	// RVA: 0x17A08A0 Offset: 0x179FAA0 VA: 0x1817A08A0
	public static double Floor(double d) { }

	// RVA: 0x17A08C0 Offset: 0x179FAC0 VA: 0x1817A08C0
	public static double Log(double d) { }

	// RVA: 0x17A08B0 Offset: 0x179FAB0 VA: 0x1817A08B0
	public static double Log10(double d) { }

	// RVA: 0x17A0C80 Offset: 0x179FE80 VA: 0x1817A0C80
	public static double Pow(double x, double y) { }

	// RVA: 0x17A1160 Offset: 0x17A0360 VA: 0x1817A1160
	public static double Sin(double a) { }

	// RVA: 0x17A1170 Offset: 0x17A0370 VA: 0x1817A1170
	public static double Sqrt(double d) { }

	// RVA: 0x17A1190 Offset: 0x17A0390 VA: 0x1817A1190
	public static double Tan(double a) { }

	// RVA: 0x17A0C70 Offset: 0x179FE70 VA: 0x1817A0C70
	private static double ModF(double x, double* intptr) { }

	// RVA: 0x17A12D0 Offset: 0x17A04D0 VA: 0x1817A12D0
	private static void .cctor() { }
}

// Namespace: System
[Serializable]
public class MemberAccessException : SystemException // TypeDefIndex: 3068
{
	// Methods

	// RVA: 0x17A1370 Offset: 0x17A0570 VA: 0x1817A1370
	public void .ctor() { }

	// RVA: 0x17A13C0 Offset: 0x17A05C0 VA: 0x1817A13C0
	public void .ctor(string message) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System
[IsReadOnly]
[DebuggerTypeProxy(typeof(MemoryDebugView<T>))]
[DebuggerDisplay("{ToString(),raw}")]
public struct Memory<T> : IEquatable<Memory<T>> // TypeDefIndex: 3069
{
	// Fields
	private readonly object _object; // 0x0
	private readonly int _index; // 0x0
	private readonly int _length; // 0x0
	private const int RemoveFlagsBitMask = 2147483647;

	// Properties
	public static Memory<T> Empty { get; }
	public int Length { get; }
	public Span<T> Span { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD29C0 Offset: 0xBD1BC0 VA: 0x180BD29C0
	|-Memory<byte>..ctor
	|-Memory<char>..ctor
	|
	|-RVA: 0x14647E0 Offset: 0x14639E0 VA: 0x1814647E0
	|-Memory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD2940 Offset: 0xBD1B40 VA: 0x180BD2940
	|-Memory<byte>..ctor
	|-Memory<char>..ctor
	|
	|-RVA: 0x1464990 Offset: 0x1463B90 VA: 0x181464990
	|-Memory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(object obj, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD29B0 Offset: 0xBD1BB0 VA: 0x180BD29B0
	|-Memory<byte>..ctor
	|-Memory<char>..ctor
	|-Memory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public static Memory<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD4800 Offset: 0xBD3A00 VA: 0x180BD4800
	|-Memory<byte>.op_Implicit
	|-Memory<char>.op_Implicit
	|
	|-RVA: 0x1466D30 Offset: 0x1465F30 VA: 0x181466D30
	|-Memory<__Il2CppFullySharedGenericType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static Memory<T> op_Implicit(ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1466A70 Offset: 0x1465C70 VA: 0x181466A70
	|-Memory<byte>.op_Implicit
	|-Memory<char>.op_Implicit
	|
	|-RVA: 0x1466B90 Offset: 0x1465D90 VA: 0x181466B90
	|-Memory<__Il2CppFullySharedGenericType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlyMemory<T> op_Implicit(Memory<T> memory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4354A0 Offset: 0x4346A0 VA: 0x1804354A0
	|-Memory<byte>.op_Implicit
	|-Memory<char>.op_Implicit
	|-Memory<__Il2CppFullySharedGenericType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static Memory<T> get_Empty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9E8FF0 Offset: 0x9E81F0 VA: 0x1809E8FF0
	|-Memory<byte>.get_Empty
	|-Memory<char>.get_Empty
	|-Memory<__Il2CppFullySharedGenericType>.get_Empty
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD2A60 Offset: 0xBD1C60 VA: 0x180BD2A60
	|-Memory<byte>.get_Length
	|-Memory<char>.get_Length
	|-Memory<__Il2CppFullySharedGenericType>.get_Length
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1464330 Offset: 0x1463530 VA: 0x181464330
	|-Memory<byte>.ToString
	|
	|-RVA: 0x1463A20 Offset: 0x1462C20 VA: 0x181463A20
	|-Memory<char>.ToString
	|
	|-RVA: 0x1463EB0 Offset: 0x14630B0 VA: 0x181463EB0
	|-Memory<__Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1
	public Memory<T> Slice(int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14634F0 Offset: 0x14626F0 VA: 0x1814634F0
	|-Memory<byte>.Slice
	|-Memory<char>.Slice
	|-Memory<__Il2CppFullySharedGenericType>.Slice
	*/

	// RVA: -1 Offset: -1
	public Span<T> get_Span() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14661B0 Offset: 0x14653B0 VA: 0x1814661B0
	|-Memory<byte>.get_Span
	|
	|-RVA: 0x1465D90 Offset: 0x1464F90 VA: 0x181465D90
	|-Memory<char>.get_Span
	|
	|-RVA: 0x1465950 Offset: 0x1464B50 VA: 0x181465950
	|-Memory<__Il2CppFullySharedGenericType>.get_Span
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(Memory<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1461DD0 Offset: 0x1460FD0 VA: 0x181461DD0
	|-Memory<byte>.CopyTo
	|
	|-RVA: 0x1461BB0 Offset: 0x1460DB0 VA: 0x181461BB0
	|-Memory<char>.CopyTo
	|
	|-RVA: 0x1461C80 Offset: 0x1460E80 VA: 0x181461C80
	|-Memory<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public MemoryHandle Pin() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14631B0 Offset: 0x14623B0 VA: 0x1814631B0
	|-Memory<byte>.Pin
	|
	|-RVA: 0x1462E60 Offset: 0x1462060 VA: 0x181462E60
	|-Memory<char>.Pin
	|
	|-RVA: 0x1462A20 Offset: 0x1461C20 VA: 0x181462A20
	|-Memory<__Il2CppFullySharedGenericType>.Pin
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14639A0 Offset: 0x1462BA0 VA: 0x1814639A0
	|-Memory<byte>.ToArray
	|
	|-RVA: 0x1463720 Offset: 0x1462920 VA: 0x181463720
	|-Memory<char>.ToArray
	|
	|-RVA: 0x14638C0 Offset: 0x1462AC0 VA: 0x1814638C0
	|-Memory<__Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1462640 Offset: 0x1461840 VA: 0x181462640
	|-Memory<byte>.Equals
	|-Memory<char>.Equals
	|
	|-RVA: 0x1461EA0 Offset: 0x14610A0 VA: 0x181461EA0
	|-Memory<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(Memory<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD08B0 Offset: 0xBCFAB0 VA: 0x180BD08B0
	|-Memory<byte>.Equals
	|-Memory<char>.Equals
	|-Memory<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1462940 Offset: 0x1461B40 VA: 0x181462940
	|-Memory<byte>.GetHashCode
	|-Memory<char>.GetHashCode
	|
	|-RVA: 0x1462860 Offset: 0x1461A60 VA: 0x181462860
	|-Memory<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private static int CombineHashCodes(int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD0650 Offset: 0xBCF850 VA: 0x180BD0650
	|-Memory<byte>.CombineHashCodes
	|-Memory<char>.CombineHashCodes
	|-Memory<__Il2CppFullySharedGenericType>.CombineHashCodes
	*/

	// RVA: -1 Offset: -1
	private static int CombineHashCodes(int h1, int h2, int h3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD0840 Offset: 0xBCFA40 VA: 0x180BD0840
	|-Memory<byte>.CombineHashCodes
	|-Memory<char>.CombineHashCodes
	|
	|-RVA: 0x1461AC0 Offset: 0x1460CC0 VA: 0x181461AC0
	|-Memory<__Il2CppFullySharedGenericType>.CombineHashCodes
	*/
}

// Namespace: System
internal sealed class MemoryDebugView<T> // TypeDefIndex: 3070
{}

// Namespace: System
[Extension]
public static class MemoryExtensions // TypeDefIndex: 3071
{
	// Methods

	[Extension]
	// RVA: 0x17A1AE0 Offset: 0x17A0CE0 VA: 0x1817A1AE0
	internal static bool EqualsOrdinal(ReadOnlySpan<char> span, ReadOnlySpan<char> value) { }

	[Extension]
	// RVA: 0x17A1A30 Offset: 0x17A0C30 VA: 0x1817A1A30
	internal static bool EqualsOrdinalIgnoreCase(ReadOnlySpan<char> span, ReadOnlySpan<char> value) { }

	[Extension]
	// RVA: 0x17A15C0 Offset: 0x17A07C0 VA: 0x1817A15C0
	internal static bool Contains(ReadOnlySpan<char> source, char value) { }

	[Extension]
	// RVA: 0x17A1C30 Offset: 0x17A0E30 VA: 0x1817A1C30
	public static int ToUpperInvariant(ReadOnlySpan<char> source, Span<char> destination) { }

	[Extension]
	// RVA: 0x17A1640 Offset: 0x17A0840 VA: 0x1817A1640
	public static bool EndsWith(ReadOnlySpan<char> span, ReadOnlySpan<char> value, StringComparison comparisonType) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static Span<T> AsSpan<T>(T[] array, int start) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA47700 Offset: 0xA46900 VA: 0x180A47700
	|-MemoryExtensions.AsSpan<byte>
	|
	|-RVA: 0xA47F00 Offset: 0xA47100 VA: 0x180A47F00
	|-MemoryExtensions.AsSpan<object>
	|
	|-RVA: 0xA47C30 Offset: 0xA46E30 VA: 0x180A47C30
	|-MemoryExtensions.AsSpan<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x17A13E0 Offset: 0x17A05E0 VA: 0x1817A13E0
	public static ReadOnlySpan<char> AsSpan(string text) { }

	[Extension]
	// RVA: 0x17A1520 Offset: 0x17A0720 VA: 0x1817A1520
	public static ReadOnlySpan<char> AsSpan(string text, int start) { }

	[Extension]
	// RVA: 0x17A1460 Offset: 0x17A0660 VA: 0x1817A1460
	public static ReadOnlySpan<char> AsSpan(string text, int start, int length) { }

	[Extension]
	// RVA: 0x17A2030 Offset: 0x17A1230 VA: 0x1817A2030
	public static ReadOnlySpan<char> Trim(ReadOnlySpan<char> span) { }

	[Extension]
	// RVA: 0x17A1F00 Offset: 0x17A1100 VA: 0x1817A1F00
	public static ReadOnlySpan<char> TrimStart(ReadOnlySpan<char> span) { }

	[Extension]
	// RVA: 0x17A1DF0 Offset: 0x17A0FF0 VA: 0x1817A1DF0
	public static ReadOnlySpan<char> TrimEnd(ReadOnlySpan<char> span) { }

	[Extension]
	// RVA: 0x17A1B70 Offset: 0x17A0D70 VA: 0x1817A1B70
	public static bool IsWhiteSpace(ReadOnlySpan<char> span) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOf<T>(ReadOnlySpan<T> span, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA499F0 Offset: 0xA48BF0 VA: 0x180A499F0
	|-MemoryExtensions.IndexOf<char>
	|
	|-RVA: 0xA49E30 Offset: 0xA49030 VA: 0x180A49E30
	|-MemoryExtensions.IndexOf<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOfAny<T>(ReadOnlySpan<T> span, ReadOnlySpan<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA491C0 Offset: 0xA483C0 VA: 0x180A491C0
	|-MemoryExtensions.IndexOfAny<char>
	|
	|-RVA: 0xA49300 Offset: 0xA48500 VA: 0x180A49300
	|-MemoryExtensions.IndexOfAny<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool SequenceEqual<T>(ReadOnlySpan<T> span, ReadOnlySpan<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4A4D0 Offset: 0xA496D0 VA: 0x180A4A4D0
	|-MemoryExtensions.SequenceEqual<byte>
	|
	|-RVA: 0xA4A7C0 Offset: 0xA499C0 VA: 0x180A4A7C0
	|-MemoryExtensions.SequenceEqual<char>
	|
	|-RVA: 0xA4AFD0 Offset: 0xA4A1D0 VA: 0x180A4AFD0
	|-MemoryExtensions.SequenceEqual<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool StartsWith<T>(ReadOnlySpan<T> span, ReadOnlySpan<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA4B5B0 Offset: 0xA4A7B0 VA: 0x180A4B5B0
	|-MemoryExtensions.StartsWith<char>
	|
	|-RVA: 0xA4BB50 Offset: 0xA4AD50 VA: 0x180A4BB50
	|-MemoryExtensions.StartsWith<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool EndsWith<T>(ReadOnlySpan<T> span, ReadOnlySpan<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA483A0 Offset: 0xA475A0 VA: 0x180A483A0
	|-MemoryExtensions.EndsWith<char>
	|
	|-RVA: 0xA48B60 Offset: 0xA47D60 VA: 0x180A48B60
	|-MemoryExtensions.EndsWith<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Span<T> AsSpan<T>(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA47780 Offset: 0xA46980 VA: 0x180A47780
	|-MemoryExtensions.AsSpan<byte>
	|
	|-RVA: 0xA47920 Offset: 0xA46B20 VA: 0x180A47920
	|-MemoryExtensions.AsSpan<char>
	|
	|-RVA: 0xA47DD0 Offset: 0xA46FD0 VA: 0x180A47DD0
	|-MemoryExtensions.AsSpan<object>
	|
	|-RVA: 0xA479B0 Offset: 0xA46BB0 VA: 0x180A479B0
	|-MemoryExtensions.AsSpan<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void CopyTo<T>(T[] source, Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA48000 Offset: 0xA47200 VA: 0x180A48000
	|-MemoryExtensions.CopyTo<byte>
	|
	|-RVA: 0xA481D0 Offset: 0xA473D0 VA: 0x180A481D0
	|-MemoryExtensions.CopyTo<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static bool IsTypeComparableAsBytes<T>(out ulong size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA25120 Offset: 0xA24320 VA: 0x180A25120
	|-MemoryExtensions.IsTypeComparableAsBytes<byte>
	|-MemoryExtensions.IsTypeComparableAsBytes<char>
	|-MemoryExtensions.IsTypeComparableAsBytes<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System
[Serializable]
public class MethodAccessException : MemberAccessException // TypeDefIndex: 3072
{
	// Methods

	// RVA: 0x17A21F0 Offset: 0x17A13F0 VA: 0x1817A21F0
	public void .ctor() { }

	// RVA: 0x17A2240 Offset: 0x17A1440 VA: 0x1817A2240
	public void .ctor(string message) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System
public enum MidpointRounding // TypeDefIndex: 3073
{
	// Fields
	public int value__; // 0x0
	public const MidpointRounding ToEven = 0;
	public const MidpointRounding AwayFromZero = 1;
}

// Namespace: System
[Serializable]
public class MissingMethodException : MissingMemberException // TypeDefIndex: 3074
{
	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x17A22C0 Offset: 0x17A14C0 VA: 0x1817A22C0
	public void .ctor() { }

	// RVA: 0x17A2310 Offset: 0x17A1510 VA: 0x1817A2310
	public void .ctor(string message) { }

	// RVA: 0x17A2260 Offset: 0x17A1460 VA: 0x1817A2260
	public void .ctor(string className, string methodName) { }

	// RVA: 0x17A22A0 Offset: 0x17A14A0 VA: 0x1817A22A0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17A2330 Offset: 0x17A1530 VA: 0x1817A2330 Slot: 5
	public override string get_Message() { }
}

// Namespace: System
[Serializable]
public sealed class MulticastNotSupportedException : SystemException // TypeDefIndex: 3075
{
	// Methods

	// RVA: 0x17A2460 Offset: 0x17A1660 VA: 0x1817A2460
	public void .ctor() { }

	// RVA: 0x17A24B0 Offset: 0x17A16B0 VA: 0x1817A24B0
	public void .ctor(string message) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System
[Usage(256, Inherited = False)]
public sealed class NonSerializedAttribute : Attribute // TypeDefIndex: 3076
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System
[Serializable]
public class NotImplementedException : SystemException // TypeDefIndex: 3077
{
	// Methods

	// RVA: 0x17A24F0 Offset: 0x17A16F0 VA: 0x1817A24F0
	public void .ctor() { }

	// RVA: 0x17A24D0 Offset: 0x17A16D0 VA: 0x1817A24D0
	public void .ctor(string message) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System
[Serializable]
public class NotSupportedException : SystemException // TypeDefIndex: 3078
{
	// Methods

	// RVA: 0x17A2540 Offset: 0x17A1740 VA: 0x1817A2540
	public void .ctor() { }

	// RVA: 0x17A25B0 Offset: 0x17A17B0 VA: 0x1817A25B0
	public void .ctor(string message) { }

	// RVA: 0x17A2590 Offset: 0x17A1790 VA: 0x1817A2590
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System
[Serializable]
public class NullReferenceException : SystemException // TypeDefIndex: 3079
{
	// Methods

	// RVA: 0x17A25F0 Offset: 0x17A17F0 VA: 0x1817A25F0
	public void .ctor() { }

	// RVA: 0x17A25D0 Offset: 0x17A17D0 VA: 0x1817A25D0
	public void .ctor(string message) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System
[NonVersionable]
[Serializable]
public struct Nullable<T> // TypeDefIndex: 3080
{
	// Fields
	private readonly bool hasValue; // 0x0
	internal T value; // 0x0

	// Properties
	public bool HasValue { get; }
	public T Value { get; }

	// Methods

	[NonVersionable]
	// RVA: -1 Offset: -1
	public void .ctor(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB54880 Offset: 0xB53A80 VA: 0x180B54880
	|-Nullable<ArraySegment<byte>>..ctor
	|-Nullable<ValueTuple<object, object>>..ctor
	|-Nullable<AcceptInviteOptions>..ctor
	|-Nullable<AcceptRequestToJoinOptions>..ctor
	|-Nullable<AccountFeatureRestrictedInfoInternal>..ctor
	|-Nullable<AcknowledgeEventIdOptions>..ctor
	|-Nullable<AddNotifyAudioBeforeSendOptions>..ctor
	|-Nullable<AddNotifyAudioInputStateOptions>..ctor
	|-Nullable<AddNotifyAudioOutputStateOptions>..ctor
	|-Nullable<AddNotifyDataReceivedOptions>..ctor
	|-Nullable<AddNotifyDisconnectedOptions>..ctor
	|-Nullable<AddNotifyParticipantStatusChangedOptions>..ctor
	|-Nullable<AddNotifyParticipantUpdatedOptions>..ctor
	|-Nullable<AddNotifyParticipantUpdatedOptions>..ctor
	|-Nullable<AddNotifyRTCRoomConnectionChangedOptions>..ctor
	|-Nullable<AddNotifyRoomStatisticsUpdatedOptions>..ctor
	|-Nullable<AndroidIAPVerifyPurchaseOptionsPlatformSpecificOptions>..ctor
	|-Nullable<AudioBuffer>..ctor
	|-Nullable<AuthExpirationCallbackInfo>..ctor
	|-Nullable<BeginSessionOptions>..ctor
	|-Nullable<BigInteger>..ctor
	|-Nullable<ClientCredentials>..ctor
	|-Nullable<CopyBestDisplayNameOptions>..ctor
	|-Nullable<CopyEntitlementByIdOptions>..ctor
	|-Nullable<CopyEntitlementByIndexOptions>..ctor
	|-Nullable<CopyFileMetadataAtIndexOptions>..ctor
	|-Nullable<CopyFileMetadataAtIndexOptions>..ctor
	|-Nullable<CopyFileMetadataByFilenameOptions>..ctor
	|-Nullable<CopyFileMetadataByFilenameOptions>..ctor
	|-Nullable<CopyItemByIdOptions>..ctor
	|-Nullable<CopyLastRedeemedEntitlementByIndexOptions>..ctor
	|-Nullable<CopyLeaderboardUserScoreByIndexOptions>..ctor
	|-Nullable<CopyLeaderboardUserScoreByUserIdOptions>..ctor
	|-Nullable<CopyLobbyDetailsHandleOptions>..ctor
	|-Nullable<CopyModInfoOptions>..ctor
	|-Nullable<CopyOfferByIdOptions>..ctor
	|-Nullable<CopyOfferByIndexOptions>..ctor
	|-Nullable<CopyPermissionByIndexOptions>..ctor
	|-Nullable<CopyPlayerSanctionByIndexOptions>..ctor
	|-Nullable<CopyPresenceOptions>..ctor
	|-Nullable<CopyProductUserExternalAccountByAccountIdOptions>..ctor
	|-Nullable<CopyProductUserExternalAccountByAccountTypeOptions>..ctor
	|-Nullable<CopyProductUserExternalAccountByIndexOptions>..ctor
	|-Nullable<CopyStatByIndexOptions>..ctor
	|-Nullable<CopyStatByNameOptions>..ctor
	|-Nullable<CopyTransactionByIdOptions>..ctor
	|-Nullable<CopyTransactionByIndexOptions>..ctor
	|-Nullable<CopyUnlockedAchievementByAchievementIdOptions>..ctor
	|-Nullable<CopyUnlockedAchievementByIndexOptions>..ctor
	|-Nullable<CopyUserInfoOptions>..ctor
	|-Nullable<CopyUserTokenByUserIdOptions>..ctor
	|-Nullable<CreateDeviceIdCallbackInfo>..ctor
	|-Nullable<Credentials>..ctor
	|-Nullable<DataRecord>..ctor
	|-Nullable<DateTimeOffset>..ctor
	|-Nullable<Decimal>..ctor
	|-Nullable<DeleteDeviceIdCallbackInfo>..ctor
	|-Nullable<DeleteFileOptions>..ctor
	|-Nullable<DeletePersistentAuthCallbackInfo>..ctor
	|-Nullable<DestroyLobbyOptions>..ctor
	|-Nullable<DestroySessionCallbackInfo>..ctor
	|-Nullable<EGSDLCVerifyPurchaseOptionsPlatformSpecificOptions>..ctor
	|-Nullable<EGSIAPVerifyPurchaseOptionsPlatformSpecificOptions>..ctor
	|-Nullable<EndSessionCallbackInfo>..ctor
	|-Nullable<EnumerateModsOptions>..ctor
	|-Nullable<GetBlockedUserAtIndexOptions>..ctor
	|-Nullable<GetConnectStringOptions>..ctor
	|-Nullable<GetEntitlementsByNameCountOptions>..ctor
	|-Nullable<GetExternalUserInfoCountOptions>..ctor
	|-Nullable<GetFriendAtIndexOptions>..ctor
	|-Nullable<GetInviteIdByIndexOptions>..ctor
	|-Nullable<GetInviteIdByIndexOptions>..ctor
	|-Nullable<GetItemImageInfoCountOptions>..ctor
	|-Nullable<GetItemReleaseCountOptions>..ctor
	|-Nullable<GetJoinInfoOptions>..ctor
	|-Nullable<GetNextReceivedPacketSizeOptions>..ctor
	|-Nullable<GetOfferImageInfoCountOptions>..ctor
	|-Nullable<GetOfferItemCountOptions>..ctor
	|-Nullable<GetPermissionByKeyOptions>..ctor
	|-Nullable<GetRTCRoomNameOptions>..ctor
	|-Nullable<GetStatusOptions>..ctor
	|-Nullable<HasPresenceOptions>..ctor
	|-Nullable<IOSIAPVerifyPurchaseOptionsPlatformSpecificOptions>..ctor
	|-Nullable<IdToken>..ctor
	|-Nullable<IdToken>..ctor
	|-Nullable<IngestData>..ctor
	|-Nullable<IsRTCRoomConnectedOptions>..ctor
	|-Nullable<IsUserInSessionOptions>..ctor
	|-Nullable<ItemOwnership>..ctor
	|-Nullable<JoinSessionCallbackInfo>..ctor
	|-Nullable<JsonElement>..ctor
	|-Nullable<KickCompleteCallbackInfo>..ctor
	|-Nullable<KickOptions>..ctor
	|-Nullable<LeaderboardUserScore>..ctor
	|-Nullable<LeaveLobbyOptions>..ctor
	|-Nullable<LeaveRoomOptions>..ctor
	|-Nullable<LinkAccountOptions>..ctor
	|-Nullable<LobbyDetailsCopyMemberAttributeByIndexOptions>..ctor
	|-Nullable<LobbyDetailsCopyMemberAttributeByKeyOptions>..ctor
	|-Nullable<LobbyDetailsMemberInfo>..ctor
	|-Nullable<LobbySearchFindCallbackInfo>..ctor
	|-Nullable<LobbySearchRemoveParameterOptions>..ctor
	|-Nullable<LobbyUpdateReceivedCallbackInfo>..ctor
	|-Nullable<LocalDefinition>..ctor
	|-Nullable<LogPlayerReviveOptions>..ctor
	|-Nullable<LogPlayerSpawnOptions>..ctor
	|-Nullable<MemoryMonitorCallbackInfo>..ctor
	|-Nullable<ModInfo>..ctor
	|-Nullable<OnCheckpointCompleteCallbackInfo>..ctor
	|-Nullable<OnCloseCompleteCallbackInfo>..ctor
	|-Nullable<OnDisplaySettingsUpdatedCallbackInfo>..ctor
	|-Nullable<OnQueryDefinitionsCompleteCallbackInfo>..ctor
	|-Nullable<OnQueryInputDevicesInformationCallbackInfo>..ctor
	|-Nullable<OnQueryLeaderboardDefinitionsCompleteCallbackInfo>..ctor
	|-Nullable<OnQueryLeaderboardUserScoresCompleteCallbackInfo>..ctor
	|-Nullable<OnQueryOutputDevicesInformationCallbackInfo>..ctor
	|-Nullable<Option>..ctor
	|-Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReport>..ctor
	|-Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReport>..ctor
	|-Nullable<PS5Options>..ctor
	|-Nullable<ParticipantMetadata>..ctor
	|-Nullable<PermissionStatus>..ctor
	|-Nullable<PlayerStatInfo>..ctor
	|-Nullable<QueryActivePlayerSanctionsOptions>..ctor
	|-Nullable<QueryEntitlementTokenOptions>..ctor
	|-Nullable<QueryFileListOptions>..ctor
	|-Nullable<QueryFileOptions>..ctor
	|-Nullable<QueryFileOptions>..ctor
	|-Nullable<QueryIdTokenOptions>..ctor
	|-Nullable<QueryLeaderboardRanksOptions>..ctor
	|-Nullable<QueryOffersOptions>..ctor
	|-Nullable<QueryOwnershipBySandboxIdsOptions>..ctor
	|-Nullable<QueryPlayerAchievementsOptions>..ctor
	|-Nullable<QueryPresenceOptions>..ctor
	|-Nullable<QueryUserInfoByDisplayNameOptions>..ctor
	|-Nullable<QueryUserInfoOptions>..ctor
	|-Nullable<RTCOptions>..ctor
	|-Nullable<ReceiveMessageFromServerOptions>..ctor
	|-Nullable<RedeemEntitlementsOptions>..ctor
	|-Nullable<RegexPrefix>..ctor
	|-Nullable<RegisterEventParamDef>..ctor
	|-Nullable<RegisterPlayersOptions>..ctor
	|-Nullable<RejectInviteCallbackInfo>..ctor
	|-Nullable<RejectInviteOptions>..ctor
	|-Nullable<RejectInviteOptions>..ctor
	|-Nullable<RejectInviteOptions>..ctor
	|-Nullable<RejectRequestToJoinOptions>..ctor
	|-Nullable<RequestPermissionsOptions>..ctor
	|-Nullable<SandboxIdItemOwnership>..ctor
	|-Nullable<SendCustomInviteOptions>..ctor
	|-Nullable<SendInviteCallbackInfo>..ctor
	|-Nullable<SendInviteOptions>..ctor
	|-Nullable<SendPlayerBehaviorReportCompleteCallbackInfo>..ctor
	|-Nullable<SendRequestToJoinOptions>..ctor
	|-Nullable<SessionSearchFindCallbackInfo>..ctor
	|-Nullable<SessionSearchRemoveParameterOptions>..ctor
	|-Nullable<SetClientDetailsOptions>..ctor
	|-Nullable<SetClientNetworkStateOptions>..ctor
	|-Nullable<SetCustomInviteOptions>..ctor
	|-Nullable<SetOutputDeviceSettingsOptions>..ctor
	|-Nullable<SetPacketQueueSizeOptions>..ctor
	|-Nullable<SetParticipantHardMuteCompleteCallbackInfo>..ctor
	|-Nullable<SetPresenceOptions>..ctor
	|-Nullable<SetSettingOptions>..ctor
	|-Nullable<ShowBlockPlayerOptions>..ctor
	|-Nullable<ShowNativeProfileOptions>..ctor
	|-Nullable<ShowReportPlayerOptions>..ctor
	|-Nullable<SocketIdInternal>..ctor
	|-Nullable<StartSessionCallbackInfo>..ctor
	|-Nullable<StatThresholds>..ctor
	|-Nullable<SteamDLCVerifyPurchaseOptionsPlatformSpecificOptions>..ctor
	|-Nullable<StreamingContext>..ctor
	|-Nullable<SubmitSnapshotCallbackInfo>..ctor
	|-Nullable<UnlockAchievementsOptions>..ctor
	|-Nullable<UnregisterPlayersOptions>..ctor
	|-Nullable<UpdateLobbyModificationOptions>..ctor
	|-Nullable<UpdateParentEmailOptions>..ctor
	|-Nullable<UserLoginInfo>..ctor
	|-Nullable<UserScoresQueryStatInfo>..ctor
	|-Nullable<UserToken>..ctor
	|-Nullable<VerifyPurchaseCompleteCallbackInfo>..ctor
	|-Nullable<VerifyUserAuthCallbackInfo>..ctor
	|-Nullable<WindowsRTCOptionsPlatformSpecificOptionsInternal>..ctor
	|-Nullable<XSXDLCVerifyPurchaseOptionsPlatformSpecificOptions>..ctor
	|-Nullable<XSXIAPVerifyPurchaseOptionsPlatformSpecificOptions>..ctor
	|-Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>..ctor
	|-Nullable<XSXSubmitGraphicsCommandsDataCommand>..ctor
	|-Nullable<XSXXBLOptionsInitOptions>..ctor
	|-Nullable<XboxOneGDKDLCVerifyPurchaseOptionsPlatformSpecificOptions>..ctor
	|-Nullable<XboxOneGDKIAPVerifyPurchaseOptionsPlatformSpecificOptions>..ctor
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>..ctor
	|-Nullable<XboxOneGDKSubmitGraphicsCommandsDataCommand>..ctor
	|-Nullable<XboxOneGDKXBLOptionsInitOptions>..ctor
	|
	|-RVA: 0xB548D0 Offset: 0xB53AD0 VA: 0x180B548D0
	|-Nullable<AcceptConnectionOptions>..ctor
	|-Nullable<AttributeDataValue>..ctor
	|-Nullable<AttributeDataValue>..ctor
	|-Nullable<AudioBeforeRenderCallbackInfo>..ctor
	|-Nullable<BeginPlayerSessionOptions>..ctor
	|-Nullable<ClearPacketQueueOptions>..ctor
	|-Nullable<CloseConnectionOptions>..ctor
	|-Nullable<ExternalAccountInfo>..ctor
	|-Nullable<FileMetadata>..ctor
	|-Nullable<LobbyDetailsInfo>..ctor
	|-Nullable<LogPlayerUseWeaponData>..ctor
	|-Nullable<PS4IntegratedPlatformOptionsContainerAddOptions>..ctor
	|-Nullable<PS4PrePresentOptions>..ctor
	|-Nullable<PS5PrePresentOptions>..ctor
	|-Nullable<ParticipantStatusChangedCallbackInfo>..ctor
	|-Nullable<QueryLeaderboardDefinitionsOptions>..ctor
	|-Nullable<QueryPermissionsCallbackInfo>..ctor
	|-Nullable<SessionDetailsInfoInternal>..ctor
	|-Nullable<SessionDetailsSettingsInternal>..ctor
	|-Nullable<UninstallModOptions>..ctor
	|-Nullable<UpdateModOptions>..ctor
	|-Nullable<UserInfoDataInternal>..ctor
	|-Nullable<XSXInitializeOptionsSystemInitializeOptions>..ctor
	|-Nullable<XSXPrePresentOptionsPlatformSpecificData>..ctor
	|-Nullable<XboxOneGDKInitializeOptionsSystemInitializeOptions>..ctor
	|-Nullable<XboxOneGDKPrePresentOptionsPlatformSpecificData>..ctor
	|
	|-RVA: 0xB54A90 Offset: 0xB53C90 VA: 0x180B54A90
	|-Nullable<AcceptInviteCallbackInfo>..ctor
	|-Nullable<AcceptRequestToJoinCallbackInfo>..ctor
	|-Nullable<AttributeDataInternal>..ctor
	|-Nullable<AttributeDataInternal>..ctor
	|-Nullable<AudioBufferInternal>..ctor
	|-Nullable<AudioInputStateCallbackInfo>..ctor
	|-Nullable<AudioOutputStateCallbackInfo>..ctor
	|-Nullable<BeginSessionOptions>..ctor
	|-Nullable<BlockParticipantOptions>..ctor
	|-Nullable<CheckoutCallbackInfo>..ctor
	|-Nullable<DisconnectedCallbackInfo>..ctor
	|-Nullable<EnumerateModsCallbackInfo>..ctor
	|-Nullable<ExternalUserInfo>..ctor
	|-Nullable<ExternalUserInfoInternal>..ctor
	|-Nullable<FileMetadata>..ctor
	|-Nullable<FileMetadataInternal>..ctor
	|-Nullable<FileTransferProgressCallbackInfo>..ctor
	|-Nullable<FileTransferProgressCallbackInfo>..ctor
	|-Nullable<FinalizeInviteOptions>..ctor
	|-Nullable<HardMuteMemberCallbackInfo>..ctor
	|-Nullable<HardMuteMemberOptions>..ctor
	|-Nullable<IOSCredentialsSystemAuthCredentialsOptionsInternal>..ctor
	|-Nullable<IngestStatCompleteCallbackInfo>..ctor
	|-Nullable<IntegratedPlatformOptionsContainerAddOptions>..ctor
	|-Nullable<JoinSessionOptions>..ctor
	|-Nullable<KeyImageInfoInternal>..ctor
	|-Nullable<LeaderboardRecordInternal>..ctor
	|-Nullable<LeaveRoomCallbackInfo>..ctor
	|-Nullable<LobbyInviteReceivedCallbackInfo>..ctor
	|-Nullable<LobbyMemberStatusReceivedCallbackInfo>..ctor
	|-Nullable<LogGameRoundStartOptions>..ctor
	|-Nullable<LoginCallbackInfo>..ctor
	|-Nullable<OnBlockedUsersUpdateInfo>..ctor
	|-Nullable<OnClientActionRequiredCallbackInfo>..ctor
	|-Nullable<OnFriendsUpdateInfo>..ctor
	|-Nullable<OnMessageToClientCallbackInfo>..ctor
	|-Nullable<OnQueryPlayerAchievementsCompleteCallbackInfo>..ctor
	|-Nullable<OnQueryStatsCompleteCallbackInfo>..ctor
	|-Nullable<OnShowBlockPlayerCallbackInfo>..ctor
	|-Nullable<OnShowReportPlayerCallbackInfo>..ctor
	|-Nullable<OnUnlockAchievementsCompleteCallbackInfo>..ctor
	|-Nullable<PS4DLCVerifyPurchaseOptionsPlatformSpecificOptions>..ctor
	|-Nullable<PS4IAPVerifyPurchaseOptionsPlatformSpecificOptions>..ctor
	|-Nullable<PS4MemoryMonitorCallbackInfo>..ctor
	|-Nullable<PS4OptionsInitOptionsInternal>..ctor
	|-Nullable<PS5DLCVerifyPurchaseOptionsPlatformSpecificOptions>..ctor
	|-Nullable<PS5IAPVerifyPurchaseOptionsPlatformSpecificOptions>..ctor
	|-Nullable<PS5MemoryMonitorCallbackInfo>..ctor
	|-Nullable<PS5SubmitGraphicsCommandsCallbackInfo>..ctor
	|-Nullable<PinGrantInfo>..ctor
	|-Nullable<PlayerSanction>..ctor
	|-Nullable<ProtectMessageOptions>..ctor
	|-Nullable<QueryActivePlayerSanctionsCallbackInfo>..ctor
	|-Nullable<QueryAgeGateCallbackInfo>..ctor
	|-Nullable<QueryEntitlementTokenCallbackInfo>..ctor
	|-Nullable<QueryFileListCallbackInfo>..ctor
	|-Nullable<QueryFileListCallbackInfo>..ctor
	|-Nullable<QueryIdTokenCallbackInfo>..ctor
	|-Nullable<QueryJoinRoomTokenOptions>..ctor
	|-Nullable<QueryOwnershipBySandboxIdsCallbackInfo>..ctor
	|-Nullable<QueryOwnershipCallbackInfo>..ctor
	|-Nullable<QueryOwnershipTokenCallbackInfo>..ctor
	|-Nullable<QueryPresenceCallbackInfo>..ctor
	|-Nullable<QueryUserInfoCallbackInfo>..ctor
	|-Nullable<RTCRoomConnectionChangedCallbackInfo>..ctor
	|-Nullable<ReadFileCallbackInfo>..ctor
	|-Nullable<ReadFileCallbackInfo>..ctor
	|-Nullable<RedeemEntitlementsCallbackInfo>..ctor
	|-Nullable<RegisterEventOptions>..ctor
	|-Nullable<RegisterPlayersCallbackInfo>..ctor
	|-Nullable<RejectInviteCallbackInfo>..ctor
	|-Nullable<RejectRequestToJoinCallbackInfo>..ctor
	|-Nullable<RequestToJoinResponseReceivedCallbackInfo>..ctor
	|-Nullable<RoomStatisticsUpdatedInfo>..ctor
	|-Nullable<SendCustomInviteCallbackInfo>..ctor
	|-Nullable<SendDataOptions>..ctor
	|-Nullable<SendInviteCallbackInfo>..ctor
	|-Nullable<SendRequestToJoinCallbackInfo>..ctor
	|-Nullable<SessionDetailsSettings>..ctor
	|-Nullable<SessionInviteReceivedCallbackInfo>..ctor
	|-Nullable<SetRoomSettingOptions>..ctor
	|-Nullable<ShowNativeProfileCallbackInfo>..ctor
	|-Nullable<SocketId>..ctor
	|-Nullable<SteamOptions>..ctor
	|-Nullable<UnlockedAchievement>..ctor
	|-Nullable<UnprotectMessageOptions>..ctor
	|-Nullable<UpdateParticipantVolumeOptions>..ctor
	|-Nullable<UpdateReceivingOptions>..ctor
	|-Nullable<UpdateReceivingOptions>..ctor
	|-Nullable<UpdateSessionCallbackInfo>..ctor
	|-Nullable<VerifyPurchaseOptions>..ctor
	|-Nullable<WriteFileCallbackInfo>..ctor
	|-Nullable<WriteFileDataCallbackInfo>..ctor
	|
	|-RVA: 0xB54900 Offset: 0xB53B00 VA: 0x180B54900
	|-Nullable<AccountFeatureRestrictedInfo>..ctor
	|-Nullable<AddExternalIntegrityCatalogOptions>..ctor
	|-Nullable<AudioDevicesChangedCallbackInfo>..ctor
	|-Nullable<BeginSnapshotOptions>..ctor
	|-Nullable<CheckoutEntry>..ctor
	|-Nullable<CopyAchievementDefinitionByAchievementIdOptions>..ctor
	|-Nullable<CopyAchievementDefinitionV2ByAchievementIdOptions>..ctor
	|-Nullable<CopyActiveSessionHandleOptions>..ctor
	|-Nullable<CopyIdTokenOptions>..ctor
	|-Nullable<CopyIdTokenOptions>..ctor
	|-Nullable<CopyLeaderboardDefinitionByLeaderboardIdOptions>..ctor
	|-Nullable<CopyLeaderboardRecordByUserIdOptions>..ctor
	|-Nullable<CopyLobbyDetailsHandleByInviteIdOptions>..ctor
	|-Nullable<CopyLobbyDetailsHandleByUiEventIdOptions>..ctor
	|-Nullable<CopyProductUserInfoOptions>..ctor
	|-Nullable<CopySessionHandleByInviteIdOptions>..ctor
	|-Nullable<CopySessionHandleByUiEventIdOptions>..ctor
	|-Nullable<CopySessionHandleForPresenceOptions>..ctor
	|-Nullable<CreateDeviceIdOptions>..ctor
	|-Nullable<CreatePresenceModificationOptions>..ctor
	|-Nullable<CreateUserOptions>..ctor
	|-Nullable<DataKey>..ctor
	|-Nullable<DateTime>..ctor
	|-Nullable<DeleteCacheOptions>..ctor
	|-Nullable<DeleteCacheOptions>..ctor
	|-Nullable<DeletePersistentAuthOptions>..ctor
	|-Nullable<DeleteSnapshotOptions>..ctor
	|-Nullable<DestroySessionOptions>..ctor
	|-Nullable<DumpSessionStateOptions>..ctor
	|-Nullable<EndSessionOptions>..ctor
	|-Nullable<EventDispatcherGate>..ctor
	|-Nullable<GCHandle>..ctor
	|-Nullable<GetBlockedUsersCountOptions>..ctor
	|-Nullable<GetEntitlementsCountOptions>..ctor
	|-Nullable<GetFileMetadataCountOptions>..ctor
	|-Nullable<GetFileMetadataCountOptions>..ctor
	|-Nullable<GetFriendsCountOptions>..ctor
	|-Nullable<GetFriendsExclusiveInputOptions>..ctor
	|-Nullable<GetFriendsVisibleOptions>..ctor
	|-Nullable<GetInviteCountOptions>..ctor
	|-Nullable<GetInviteCountOptions>..ctor
	|-Nullable<GetLastRedeemedEntitlementsCountOptions>..ctor
	|-Nullable<GetLeaderboardUserScoreCountOptions>..ctor
	|-Nullable<GetOfferCountOptions>..ctor
	|-Nullable<GetPermissionsCountOptions>..ctor
	|-Nullable<GetPlayerAchievementCountOptions>..ctor
	|-Nullable<GetPlayerSanctionCountOptions>..ctor
	|-Nullable<GetProductUserExternalAccountCountOptions>..ctor
	|-Nullable<GetStatCountOptions>..ctor
	|-Nullable<GetTransactionCountOptions>..ctor
	|-Nullable<GetUnlockedAchievementCountOptions>..ctor
	|-Nullable<HideFriendsOptions>..ctor
	|-Nullable<long>..ctor
	|-Nullable<IntPtr>..ctor
	|-Nullable<InventoryItemCreateSubItemOptions>..ctor
	|-Nullable<InventoryItemDeleteSubItemOptions>..ctor
	|-Nullable<InventoryItemGetSubItemOptions>..ctor
	|-Nullable<InventoryItemSetKeyOptions>..ctor
	|-Nullable<InventoryItemSetValueAsDoubleOptions>..ctor
	|-Nullable<InventoryItemSetValueAsDoubleSetOptions>..ctor
	|-Nullable<InventoryItemSetValueAsInt64Options>..ctor
	|-Nullable<InventoryItemSetValueAsInt64SetOptions>..ctor
	|-Nullable<InventoryItemSetValueAsStringOptions>..ctor
	|-Nullable<InventoryItemSetValueAsStringSetOptions>..ctor
	|-Nullable<InventoryItemSetValueAsTimestampOptions>..ctor
	|-Nullable<LobbyDetailsCopyAttributeByKeyOptions>..ctor
	|-Nullable<LobbyDetailsCopyMemberInfoOptions>..ctor
	|-Nullable<LobbyDetailsGetMemberAttributeCountOptions>..ctor
	|-Nullable<LobbyModificationRemoveAttributeOptions>..ctor
	|-Nullable<LobbyModificationRemoveMemberAttributeOptions>..ctor
	|-Nullable<LobbyModificationSetAllowedPlatformIdsOptions>..ctor
	|-Nullable<LobbyModificationSetBucketIdOptions>..ctor
	|-Nullable<LobbySearchFindOptions>..ctor
	|-Nullable<LobbySearchSetLobbyIdOptions>..ctor
	|-Nullable<LobbySearchSetTargetUserIdOptions>..ctor
	|-Nullable<LogPlayerDespawnOptions>..ctor
	|-Nullable<LogoutOptions>..ctor
	|-Nullable<LogoutOptions>..ctor
	|-Nullable<ParseConnectStringOptions>..ctor
	|-Nullable<PrePresentOptions>..ctor
	|-Nullable<PresenceModificationDataRecordId>..ctor
	|-Nullable<PresenceModificationDeleteDataOptions>..ctor
	|-Nullable<PresenceModificationSetDataOptions>..ctor
	|-Nullable<PresenceModificationSetJoinInfoOptions>..ctor
	|-Nullable<PresenceModificationSetRawRichTextOptions>..ctor
	|-Nullable<QueryFileListOptions>..ctor
	|-Nullable<QueryFriendsOptions>..ctor
	|-Nullable<QueryInvitesOptions>..ctor
	|-Nullable<QueryInvitesOptions>..ctor
	|-Nullable<QueryPermissionsOptions>..ctor
	|-Nullable<RegisterPlatformAudioUserOptions>..ctor
	|-Nullable<RegisterPlatformUserOptions>..ctor
	|-Nullable<SessionDetailsCopySessionAttributeByKeyOptions>..ctor
	|-Nullable<SessionModificationRemoveAttributeOptions>..ctor
	|-Nullable<SessionModificationSetAllowedPlatformIdsOptions>..ctor
	|-Nullable<SessionModificationSetBucketIdOptions>..ctor
	|-Nullable<SessionModificationSetHostAddressOptions>..ctor
	|-Nullable<SessionSearchFindOptions>..ctor
	|-Nullable<SessionSearchSetSessionIdOptions>..ctor
	|-Nullable<SessionSearchSetTargetUserIdOptions>..ctor
	|-Nullable<SetGameSessionIdOptions>..ctor
	|-Nullable<ShowFriendsOptions>..ctor
	|-Nullable<SpanId>..ctor
	|-Nullable<SqlBinary>..ctor
	|-Nullable<StartSessionOptions>..ctor
	|-Nullable<SteamIAPVerifyPurchaseOptionsPlatformSpecificOptions>..ctor
	|-Nullable<SwitchIAPVerifyPurchaseOptionsPlatformSpecificOptions>..ctor
	|-Nullable<TimeSpan>..ctor
	|-Nullable<ulong>..ctor
	|-Nullable<UIntPtr>..ctor
	|-Nullable<UnlinkAccountOptions>..ctor
	|-Nullable<UnregisterClientOptions>..ctor
	|-Nullable<UnregisterPeerOptions>..ctor
	|-Nullable<UnregisterPlatformAudioUserOptions>..ctor
	|-Nullable<UnregisterPlatformUserOptions>..ctor
	|-Nullable<UpdateLobbyOptions>..ctor
	|-Nullable<UpdateSessionModificationOptions>..ctor
	|-Nullable<UpdateSessionOptions>..ctor
	|-Nullable<WindowsRTCOptionsPlatformSpecificOptions>..ctor
	|-Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReport>..ctor
	|-Nullable<XSXOptionsSystemSpecificOptions>..ctor
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReport>..ctor
	|-Nullable<XboxOneGDKOptionsSystemSpecificOptions>..ctor
	|-Nullable<C.sentry_value_t>..ctor
	|
	|-RVA: 0x149BD80 Offset: 0x149AF80 VA: 0x18149BD80
	|-Nullable<ActiveSessionCopyInfoOptions>..ctor
	|-Nullable<ActiveSessionGetRegisteredPlayerCountOptions>..ctor
	|-Nullable<AddNotifyAchievementsUnlockedOptions>..ctor
	|-Nullable<AddNotifyAchievementsUnlockedV2Options>..ctor
	|-Nullable<AddNotifyAudioDevicesChangedOptions>..ctor
	|-Nullable<AddNotifyAuthExpirationOptions>..ctor
	|-Nullable<AddNotifyBlockedUsersUpdateOptions>..ctor
	|-Nullable<AddNotifyClientActionRequiredOptions>..ctor
	|-Nullable<AddNotifyClientAuthStatusChangedOptions>..ctor
	|-Nullable<AddNotifyClientIntegrityViolatedOptions>..ctor
	|-Nullable<AddNotifyCustomInviteAcceptedOptions>..ctor
	|-Nullable<AddNotifyCustomInviteReceivedOptions>..ctor
	|-Nullable<AddNotifyCustomInviteRejectedOptions>..ctor
	|-Nullable<AddNotifyDisplaySettingsUpdatedOptions>..ctor
	|-Nullable<AddNotifyFriendsUpdateOptions>..ctor
	|-Nullable<AddNotifyIncomingPacketQueueFullOptions>..ctor
	|-Nullable<AddNotifyJoinGameAcceptedOptions>..ctor
	|-Nullable<AddNotifyJoinLobbyAcceptedOptions>..ctor
	|-Nullable<AddNotifyJoinSessionAcceptedOptions>..ctor
	|-Nullable<AddNotifyLeaveLobbyRequestedOptions>..ctor
	|-Nullable<AddNotifyLeaveSessionRequestedOptions>..ctor
	|-Nullable<AddNotifyLobbyInviteAcceptedOptions>..ctor
	|-Nullable<AddNotifyLobbyInviteReceivedOptions>..ctor
	|-Nullable<AddNotifyLobbyInviteRejectedOptions>..ctor
	|-Nullable<AddNotifyLobbyMemberStatusReceivedOptions>..ctor
	|-Nullable<AddNotifyLobbyMemberUpdateReceivedOptions>..ctor
	|-Nullable<AddNotifyLobbyUpdateReceivedOptions>..ctor
	|-Nullable<AddNotifyLoginStatusChangedOptions>..ctor
	|-Nullable<AddNotifyLoginStatusChangedOptions>..ctor
	|-Nullable<AddNotifyMemoryMonitorOptions>..ctor
	|-Nullable<AddNotifyMessageToClientOptions>..ctor
	|-Nullable<AddNotifyMessageToPeerOptions>..ctor
	|-Nullable<AddNotifyMessageToServerOptions>..ctor
	|-Nullable<AddNotifyOnPresenceChangedOptions>..ctor
	|-Nullable<AddNotifyPeerActionRequiredOptions>..ctor
	|-Nullable<AddNotifyPeerAuthStatusChangedOptions>..ctor
	|-Nullable<AddNotifyPermissionsUpdateReceivedOptions>..ctor
	|-Nullable<AddNotifyRequestToJoinAcceptedOptions>..ctor
	|-Nullable<AddNotifyRequestToJoinReceivedOptions>..ctor
	|-Nullable<AddNotifyRequestToJoinRejectedOptions>..ctor
	|-Nullable<AddNotifyRequestToJoinResponseReceivedOptions>..ctor
	|-Nullable<AddNotifySendCustomNativeInviteRequestedOptions>..ctor
	|-Nullable<AddNotifySendLobbyNativeInviteRequestedOptions>..ctor
	|-Nullable<AddNotifySendSessionNativeInviteRequestedOptions>..ctor
	|-Nullable<AddNotifySessionInviteAcceptedOptions>..ctor
	|-Nullable<AddNotifySessionInviteReceivedOptions>..ctor
	|-Nullable<AddNotifySessionInviteRejectedOptions>..ctor
	|-Nullable<AddNotifyUserLoginStatusChangedOptions>..ctor
	|-Nullable<bool>..ctor
	|-Nullable<byte>..ctor
	|-Nullable<ClearUserPreLogoutCallbackOptions>..ctor
	|-Nullable<CopyUserAuthTokenOptions>..ctor
	|-Nullable<CreateIntegratedPlatformOptionsContainerOptions>..ctor
	|-Nullable<DeleteDeviceIdOptions>..ctor
	|-Nullable<EndSessionOptions>..ctor
	|-Nullable<EndSessionOptions>..ctor
	|-Nullable<GetAchievementDefinitionCountOptions>..ctor
	|-Nullable<GetAudioInputDevicesCountOptions>..ctor
	|-Nullable<GetAudioOutputDevicesCountOptions>..ctor
	|-Nullable<GetDesktopCrossplayStatusOptions>..ctor
	|-Nullable<GetInputDevicesCountOptions>..ctor
	|-Nullable<GetLeaderboardDefinitionCountOptions>..ctor
	|-Nullable<GetLeaderboardRecordCountOptions>..ctor
	|-Nullable<GetLocalPlatformTypeOptions>..ctor
	|-Nullable<GetNATTypeOptions>..ctor
	|-Nullable<GetOutputDevicesCountOptions>..ctor
	|-Nullable<GetPacketQueueInfoOptions>..ctor
	|-Nullable<GetPortRangeOptions>..ctor
	|-Nullable<GetRelayControlOptions>..ctor
	|-Nullable<GetToggleFriendsButtonOptions>..ctor
	|-Nullable<GetToggleFriendsKeyOptions>..ctor
	|-Nullable<InventoryItemGetKeyOptions>..ctor
	|-Nullable<InventoryItemGetSubItemsCountOptions>..ctor
	|-Nullable<InventoryItemGetValueAsBoolOptions>..ctor
	|-Nullable<InventoryItemGetValueAsDoubleOptions>..ctor
	|-Nullable<InventoryItemGetValueAsInt64Options>..ctor
	|-Nullable<InventoryItemGetValueAsStringOptions>..ctor
	|-Nullable<InventoryItemGetValueAsTimestampOptions>..ctor
	|-Nullable<InventoryItemGetValueCountOptions>..ctor
	|-Nullable<InventoryItemGetValueTypeOptions>..ctor
	|-Nullable<InventoryItemSetValueAsBoolOptions>..ctor
	|-Nullable<IsSocialOverlayPausedOptions>..ctor
	|-Nullable<LobbyDetailsCopyInfoOptions>..ctor
	|-Nullable<LobbyDetailsGetAttributeCountOptions>..ctor
	|-Nullable<LobbyDetailsGetLobbyOwnerOptions>..ctor
	|-Nullable<LobbyDetailsGetMemberCountOptions>..ctor
	|-Nullable<LobbyModificationSetInvitesAllowedOptions>..ctor
	|-Nullable<LobbySearchGetSearchResultCountOptions>..ctor
	|-Nullable<PS5OptionsInitOptions>..ctor
	|-Nullable<PauseSocialOverlayOptions>..ctor
	|-Nullable<QueryAgeGateOptions>..ctor
	|-Nullable<QueryInputDevicesInformationOptions>..ctor
	|-Nullable<QueryNATTypeOptions>..ctor
	|-Nullable<QueryOutputDevicesInformationOptions>..ctor
	|-Nullable<sbyte>..ctor
	|-Nullable<SessionDetailsCopyInfoOptions>..ctor
	|-Nullable<SessionDetailsGetSessionAttributeCountOptions>..ctor
	|-Nullable<SessionModificationSetInvitesAllowedOptions>..ctor
	|-Nullable<SessionModificationSetJoinInProgressAllowedOptions>..ctor
	|-Nullable<SessionSearchGetSearchResultCountOptions>..ctor
	|-Nullable<SetUserPreLogoutCallbackOptions>..ctor
	|-Nullable<TransactionGetEntitlementsCountOptions>..ctor
	|
	|-RVA: 0xB54A50 Offset: 0xB53C50 VA: 0x180B54A50
	|-Nullable<ActiveSessionGetRegisteredPlayerByIndexOptions>..ctor
	|-Nullable<CopyAchievementDefinitionByIndexOptions>..ctor
	|-Nullable<CopyAchievementDefinitionV2ByIndexOptions>..ctor
	|-Nullable<CopyInputDeviceInformationByIndexOptions>..ctor
	|-Nullable<CopyLeaderboardDefinitionByIndexOptions>..ctor
	|-Nullable<CopyLeaderboardRecordByIndexOptions>..ctor
	|-Nullable<CopyOutputDeviceInformationByIndexOptions>..ctor
	|-Nullable<CreateLobbySearchOptions>..ctor
	|-Nullable<CreateSessionSearchOptions>..ctor
	|-Nullable<EndSnapshotOptions>..ctor
	|-Nullable<GetAudioInputDeviceByIndexOptions>..ctor
	|-Nullable<GetAudioOutputDeviceByIndexOptions>..ctor
	|-Nullable<GetProtectMessageOutputLengthOptions>..ctor
	|-Nullable<GetProtectMessageOutputLengthOptions>..ctor
	|-Nullable<int>..ctor
	|-Nullable<Int32Enum>..ctor
	|-Nullable<InventoryItemGetDoubleSetValueByIndexOptions>..ctor
	|-Nullable<InventoryItemGetInt64SetValueByIndexOptions>..ctor
	|-Nullable<InventoryItemGetStringSetValueByIndexOptions>..ctor
	|-Nullable<InventoryItemGetSubItemByIndexOptions>..ctor
	|-Nullable<LobbyDetailsCopyAttributeByIndexOptions>..ctor
	|-Nullable<LobbyDetailsGetMemberByIndexOptions>..ctor
	|-Nullable<LobbyModificationSetMaxMembersOptions>..ctor
	|-Nullable<LobbyModificationSetPermissionLevelOptions>..ctor
	|-Nullable<LobbySearchCopySearchResultByIndexOptions>..ctor
	|-Nullable<LobbySearchSetMaxResultsOptions>..ctor
	|-Nullable<LogGameRoundEndOptions>..ctor
	|-Nullable<PollStatusOptions>..ctor
	|-Nullable<PresenceModificationSetStatusOptions>..ctor
	|-Nullable<SessionDetailsCopySessionAttributeByIndexOptions>..ctor
	|-Nullable<SessionModificationSetMaxPlayersOptions>..ctor
	|-Nullable<SessionModificationSetPermissionLevelOptions>..ctor
	|-Nullable<SessionSearchCopySearchResultByIndexOptions>..ctor
	|-Nullable<SessionSearchSetMaxResultsOptions>..ctor
	|-Nullable<SetDisplayPreferenceOptions>..ctor
	|-Nullable<SetRelayControlOptions>..ctor
	|-Nullable<SetToggleFriendsButtonOptions>..ctor
	|-Nullable<SetToggleFriendsKeyOptions>..ctor
	|-Nullable<SubmitSnapshotOptions>..ctor
	|-Nullable<TransactionCopyEntitlementByIndexOptions>..ctor
	|-Nullable<uint>..ctor
	|-Nullable<XSXPrePresentAdditionalData>..ctor
	|-Nullable<XboxOneGDKPrePresentAdditionalData>..ctor
	|
	|-RVA: 0x149BE30 Offset: 0x149B030 VA: 0x18149BE30
	|-Nullable<ActiveSessionInfo>..ctor
	|
	|-RVA: 0xB54890 Offset: 0xB53A90 VA: 0x180B54890
	|-Nullable<ActiveSessionInfoInternal>..ctor
	|-Nullable<BestDisplayName>..ctor
	|-Nullable<CatalogReleaseInternal>..ctor
	|-Nullable<CreateUserCallbackInfo>..ctor
	|-Nullable<Credentials>..ctor
	|-Nullable<CustomInviteRejectedCallbackInfo>..ctor
	|-Nullable<Entitlement>..ctor
	|-Nullable<FileMetadataInternal>..ctor
	|-Nullable<JoinGameAcceptedCallbackInfo>..ctor
	|-Nullable<JoinLobbyByIdOptions>..ctor
	|-Nullable<JoinLobbyOptions>..ctor
	|-Nullable<JoinRoomCallbackInfo>..ctor
	|-Nullable<LobbyInviteAcceptedCallbackInfo>..ctor
	|-Nullable<LobbyInviteRejectedCallbackInfo>..ctor
	|-Nullable<ModIdentifier>..ctor
	|-Nullable<OnCustomInviteAcceptedCallbackInfo>..ctor
	|-Nullable<OnCustomInviteReceivedCallbackInfo>..ctor
	|-Nullable<OnIncomingPacketQueueFullInfo>..ctor
	|-Nullable<PS4SubmitGraphicsCommandsCallbackInfo>..ctor
	|-Nullable<ParticipantUpdatedCallbackInfo>..ctor
	|-Nullable<ParticipantUpdatedCallbackInfo>..ctor
	|-Nullable<PinGrantInfoInternal>..ctor
	|-Nullable<PlayerSanctionInternal>..ctor
	|-Nullable<QueryJoinRoomTokenCompleteCallbackInfo>..ctor
	|-Nullable<QueryUserInfoByDisplayNameCallbackInfo>..ctor
	|-Nullable<ReadFileOptions>..ctor
	|-Nullable<ReadFileOptions>..ctor
	|-Nullable<RegisterClientOptions>..ctor
	|-Nullable<SendAudioOptions>..ctor
	|-Nullable<SendPlayerBehaviorReportOptions>..ctor
	|-Nullable<SessionInviteAcceptedCallbackInfo>..ctor
	|-Nullable<SessionInviteRejectedCallbackInfo>..ctor
	|-Nullable<StatInternal>..ctor
	|-Nullable<SteamIAPVerifyPurchaseOptions>..ctor
	|-Nullable<SwitchIAPVerifyPurchaseOptions>..ctor
	|-Nullable<UpdateReceivingVolumeCallbackInfo>..ctor
	|-Nullable<UpdateSendingCallbackInfo>..ctor
	|-Nullable<UpdateSendingCallbackInfo>..ctor
	|-Nullable<UpdateSendingVolumeCallbackInfo>..ctor
	|-Nullable<UserPreLogoutCallbackInfo>..ctor
	|-Nullable<WriteFileOptions>..ctor
	|-Nullable<XSXXBLOptions>..ctor
	|-Nullable<XboxOneGDKXBLOptions>..ctor
	|
	|-RVA: 0xB548B0 Offset: 0xB53AB0 VA: 0x180B548B0
	|-Nullable<AddNotifyAudioBeforeRenderOptions>..ctor
	|-Nullable<AddProgressionOptions>..ctor
	|-Nullable<AndroidInitializeOptionsSystemInitializeOptions>..ctor
	|-Nullable<AttributeInternal>..ctor
	|-Nullable<AudioInputDeviceInfo>..ctor
	|-Nullable<AudioInputDeviceInfoInternal>..ctor
	|-Nullable<AudioOutputDeviceInfo>..ctor
	|-Nullable<AudioOutputDeviceInfoInternal>..ctor
	|-Nullable<BeginPlayerSessionOptionsAccountId>..ctor
	|-Nullable<CatalogRelease>..ctor
	|-Nullable<CheckoutOptions>..ctor
	|-Nullable<CheckpointOptions>..ctor
	|-Nullable<CloseOptions>..ctor
	|-Nullable<CopyBestDisplayNameWithPlatformOptions>..ctor
	|-Nullable<CopyEntitlementByNameAndIndexOptions>..ctor
	|-Nullable<CopyExternalUserInfoByAccountIdOptions>..ctor
	|-Nullable<CopyExternalUserInfoByAccountTypeOptions>..ctor
	|-Nullable<CopyExternalUserInfoByIndexOptions>..ctor
	|-Nullable<CopyItemImageInfoByIndexOptions>..ctor
	|-Nullable<CopyItemReleaseByIndexOptions>..ctor
	|-Nullable<CopyOfferImageInfoByIndexOptions>..ctor
	|-Nullable<CopyOfferItemByIndexOptions>..ctor
	|-Nullable<CopyPlayerAchievementByAchievementIdOptions>..ctor
	|-Nullable<CopyPlayerAchievementByIndexOptions>..ctor
	|-Nullable<CreateLobbyCallbackInfo>..ctor
	|-Nullable<CreateOptions>..ctor
	|-Nullable<CreatePlayerSanctionAppealCallbackInfo>..ctor
	|-Nullable<CreatePlayerSanctionAppealOptions>..ctor
	|-Nullable<CreateUserCallbackInfo>..ctor
	|-Nullable<CreateUserOptions>..ctor
	|-Nullable<DeleteCacheCallbackInfo>..ctor
	|-Nullable<DeleteCacheCallbackInfo>..ctor
	|-Nullable<DeleteFileCallbackInfo>..ctor
	|-Nullable<DeleteSnapshotCallbackInfo>..ctor
	|-Nullable<DestroyLobbyCallbackInfo>..ctor
	|-Nullable<DuplicateFileCallbackInfo>..ctor
	|-Nullable<DuplicateFileOptions>..ctor
	|-Nullable<EndPlayerSessionOptions>..ctor
	|-Nullable<EndPlayerSessionOptionsAccountId>..ctor
	|-Nullable<FinalizeDeferredUserLogoutOptions>..ctor
	|-Nullable<GetExternalAccountMappingsOptions>..ctor
	|-Nullable<GetProductUserIdMappingOptions>..ctor
	|-Nullable<HideFriendsCallbackInfo>..ctor
	|-Nullable<IOSCredentialsSystemAuthCredentialsOptions>..ctor
	|-Nullable<IdTokenInternal>..ctor
	|-Nullable<IdTokenInternal>..ctor
	|-Nullable<IngestStatOptions>..ctor
	|-Nullable<InputDeviceInformation>..ctor
	|-Nullable<InputDeviceInformationInternal>..ctor
	|-Nullable<JoinLobbyAcceptedCallbackInfo>..ctor
	|-Nullable<JoinLobbyByIdCallbackInfo>..ctor
	|-Nullable<JoinLobbyCallbackInfo>..ctor
	|-Nullable<JoinSessionAcceptedCallbackInfo>..ctor
	|-Nullable<JsonPosition>..ctor
	|-Nullable<KeyImageInfo>..ctor
	|-Nullable<KickMemberCallbackInfo>..ctor
	|-Nullable<KickMemberOptions>..ctor
	|-Nullable<LeaderboardRecord>..ctor
	|-Nullable<LeaderboardUserScoreInternal>..ctor
	|-Nullable<LeaveLobbyCallbackInfo>..ctor
	|-Nullable<LeaveLobbyRequestedCallbackInfo>..ctor
	|-Nullable<LeaveSessionRequestedCallbackInfo>..ctor
	|-Nullable<LinkAccountCallbackInfo>..ctor
	|-Nullable<LinkAccountOptions>..ctor
	|-Nullable<LobbyDetailsMemberInfoInternal>..ctor
	|-Nullable<LobbyMemberUpdateReceivedCallbackInfo>..ctor
	|-Nullable<LogEventOptions>..ctor
	|-Nullable<LogMessage>..ctor
	|-Nullable<LogPlayerUseAbilityOptions>..ctor
	|-Nullable<LoginStatusChangedCallbackInfo>..ctor
	|-Nullable<LoginStatusChangedCallbackInfo>..ctor
	|-Nullable<LogoutCallbackInfo>..ctor
	|-Nullable<LogoutCallbackInfo>..ctor
	|-Nullable<ModInfoInternal>..ctor
	|-Nullable<OnAchievementsUnlockedCallbackInfo>..ctor
	|-Nullable<OnClientAuthStatusChangedCallbackInfo>..ctor
	|-Nullable<OnClientIntegrityViolatedCallbackInfo>..ctor
	|-Nullable<OnCreateCompleteCallbackInfo>..ctor
	|-Nullable<OnMessageToServerCallbackInfo>..ctor
	|-Nullable<OnOpenCompleteCallbackInfo>..ctor
	|-Nullable<OnQueryLeaderboardRanksCompleteCallbackInfo>..ctor
	|-Nullable<OnQueryNATTypeCompleteInfo>..ctor
	|-Nullable<OnRegisterPlatformUserCallbackInfo>..ctor
	|-Nullable<OnRequestToJoinAcceptedCallbackInfo>..ctor
	|-Nullable<OnRequestToJoinRejectedCallbackInfo>..ctor
	|-Nullable<OnSetInputDeviceSettingsCallbackInfo>..ctor
	|-Nullable<OnSetOutputDeviceSettingsCallbackInfo>..ctor
	|-Nullable<OnUnregisterPlatformUserCallbackInfo>..ctor
	|-Nullable<OpenOptions>..ctor
	|-Nullable<Options>..ctor
	|-Nullable<OutputDeviceInformation>..ctor
	|-Nullable<OutputDeviceInformationInternal>..ctor
	|-Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>..ctor
	|-Nullable<PS4OptionsInitOptions>..ctor
	|-Nullable<PS5IntegratedPlatformOptionsContainerAddOptions>..ctor
	|-Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>..ctor
	|-Nullable<PermissionStatusInternal>..ctor
	|-Nullable<PresenceChangedCallbackInfo>..ctor
	|-Nullable<PromoteMemberCallbackInfo>..ctor
	|-Nullable<PromoteMemberOptions>..ctor
	|-Nullable<ProtectMessageOptions>..ctor
	|-Nullable<QueryDefinitionsOptions>..ctor
	|-Nullable<QueryEntitlementsCallbackInfo>..ctor
	|-Nullable<QueryEntitlementsOptions>..ctor
	|-Nullable<QueryExternalAccountMappingsCallbackInfo>..ctor
	|-Nullable<QueryExternalAccountMappingsOptions>..ctor
	|-Nullable<QueryFileCallbackInfo>..ctor
	|-Nullable<QueryFileCallbackInfo>..ctor
	|-Nullable<QueryFriendsCallbackInfo>..ctor
	|-Nullable<QueryInvitesCallbackInfo>..ctor
	|-Nullable<QueryInvitesCallbackInfo>..ctor
	|-Nullable<QueryOffersCallbackInfo>..ctor
	|-Nullable<QueryOwnershipOptions>..ctor
	|-Nullable<QueryOwnershipTokenOptions>..ctor
	|-Nullable<QueryProductUserIdMappingsCallbackInfo>..ctor
	|-Nullable<QueryProductUserIdMappingsOptions>..ctor
	|-Nullable<QueryUserInfoByExternalAccountOptions>..ctor
	|-Nullable<ReceiveMessageFromClientOptions>..ctor
	|-Nullable<ReceiveMessageFromPeerOptions>..ctor
	|-Nullable<RejectInviteCallbackInfo>..ctor
	|-Nullable<RequestPermissionsCallbackInfo>..ctor
	|-Nullable<RequestToJoinReceivedCallbackInfo>..ctor
	|-Nullable<SendInviteCallbackInfo>..ctor
	|-Nullable<SendInviteOptions>..ctor
	|-Nullable<SendInviteOptions>..ctor
	|-Nullable<SessionDetailsAttributeInternal>..ctor
	|-Nullable<SetAudioInputSettingsOptions>..ctor
	|-Nullable<SetAudioOutputSettingsOptions>..ctor
	|-Nullable<SetInputDeviceSettingsOptions>..ctor
	|-Nullable<SetParticipantHardMuteOptions>..ctor
	|-Nullable<SetPresenceCallbackInfo>..ctor
	|-Nullable<SetUserLoginStatusOptions>..ctor
	|-Nullable<ShowFriendsCallbackInfo>..ctor
	|-Nullable<TransferDeviceIdAccountCallbackInfo>..ctor
	|-Nullable<TransferDeviceIdAccountOptions>..ctor
	|-Nullable<UnlinkAccountCallbackInfo>..ctor
	|-Nullable<UnlockedAchievementInternal>..ctor
	|-Nullable<UnprotectMessageOptions>..ctor
	|-Nullable<UnregisterPlayersCallbackInfo>..ctor
	|-Nullable<UpdateLobbyCallbackInfo>..ctor
	|-Nullable<UpdateParentEmailCallbackInfo>..ctor
	|-Nullable<UpdateReceivingVolumeOptions>..ctor
	|-Nullable<UpdateSendingOptions>..ctor
	|-Nullable<UpdateSendingOptions>..ctor
	|-Nullable<UpdateSendingVolumeOptions>..ctor
	|-Nullable<UserTokenInternal>..ctor
	|-Nullable<VerifyIdTokenOptions>..ctor
	|-Nullable<VerifyIdTokenOptions>..ctor
	|-Nullable<WindowsRTCOptions>..ctor
	|-Nullable<XSXMemoryMonitorCallbackInfo>..ctor
	|-Nullable<XSXSubmitGraphicsCommandsCallbackInfo>..ctor
	|-Nullable<XSXXBLOptionsInitOptionsInternal>..ctor
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfo>..ctor
	|-Nullable<XboxOneGDKSubmitGraphicsCommandsCallbackInfo>..ctor
	|-Nullable<XboxOneGDKXBLOptionsInitOptionsInternal>..ctor
	|
	|-RVA: 0xB54A60 Offset: 0xB53C60 VA: 0x180B54A60
	|-Nullable<AddNotifyPeerConnectionClosedOptions>..ctor
	|-Nullable<AddNotifyPeerConnectionEstablishedOptions>..ctor
	|-Nullable<AddNotifyPeerConnectionInterruptedOptions>..ctor
	|-Nullable<AddNotifyPeerConnectionRequestOptions>..ctor
	|-Nullable<AndroidIAPVerifyPurchaseOptions>..ctor
	|-Nullable<AudioBeforeSendCallbackInfo>..ctor
	|-Nullable<BestDisplayNameInternal>..ctor
	|-Nullable<BlockParticipantCallbackInfo>..ctor
	|-Nullable<CloseConnectionsOptions>..ctor
	|-Nullable<DataReceivedCallbackInfo>..ctor
	|-Nullable<DefinitionInternal>..ctor
	|-Nullable<EGSDLCVerifyPurchaseOptions>..ctor
	|-Nullable<EGSIAPVerifyPurchaseOptions>..ctor
	|-Nullable<EntitlementInternal>..ctor
	|-Nullable<ExternalAccountInfoInternal>..ctor
	|-Nullable<IOSIAPVerifyPurchaseOptions>..ctor
	|-Nullable<JoinRoomOptions>..ctor
	|-Nullable<LoginOptions>..ctor
	|-Nullable<ModIdentifierInternal>..ctor
	|-Nullable<OnAchievementsUnlockedCallbackV2Info>..ctor
	|-Nullable<PS4Options>..ctor
	|-Nullable<PS4PrePresentOptionsPlatformSpecificData>..ctor
	|-Nullable<PS5PrePresentOptionsPlatformSpecificData>..ctor
	|-Nullable<PacketQueueInfo>..ctor
	|-Nullable<PermissionsUpdateReceivedCallbackInfo>..ctor
	|-Nullable<QueryUserInfoByExternalAccountCallbackInfo>..ctor
	|-Nullable<ReadFileDataCallbackInfo>..ctor
	|-Nullable<ReadFileDataCallbackInfo>..ctor
	|-Nullable<RegisterPeerOptions>..ctor
	|-Nullable<SendCustomNativeInviteRequestedCallbackInfo>..ctor
	|-Nullable<SendLobbyNativeInviteRequestedCallbackInfo>..ctor
	|-Nullable<SendSessionNativeInviteRequestedCallbackInfo>..ctor
	|-Nullable<SteamDLCVerifyPurchaseOptions>..ctor
	|-Nullable<UpdateParticipantVolumeCallbackInfo>..ctor
	|-Nullable<UpdateReceivingCallbackInfo>..ctor
	|-Nullable<UpdateReceivingCallbackInfo>..ctor
	|-Nullable<UserInfoData>..ctor
	|-Nullable<UserLoginStatusChangedCallbackInfo>..ctor
	|-Nullable<XSXDLCVerifyPurchaseOptions>..ctor
	|-Nullable<XSXIAPVerifyPurchaseOptions>..ctor
	|-Nullable<XSXIntegratedPlatformOptionsContainerAddOptions>..ctor
	|-Nullable<XboxOneGDKDLCVerifyPurchaseOptions>..ctor
	|-Nullable<XboxOneGDKIAPVerifyPurchaseOptions>..ctor
	|-Nullable<XboxOneGDKIntegratedPlatformOptionsContainerAddOptions>..ctor
	|
	|-RVA: 0x149BD90 Offset: 0x149AF90 VA: 0x18149BD90
	|-Nullable<AndroidInitializeOptions>..ctor
	|
	|-RVA: 0xB54A20 Offset: 0xB53C20 VA: 0x180B54A20
	|-Nullable<Announcement>..ctor
	|-Nullable<AttributeData>..ctor
	|-Nullable<AttributeData>..ctor
	|-Nullable<CreateSessionModificationOptions>..ctor
	|-Nullable<IOSCredentials>..ctor
	|-Nullable<InitializeThreadAffinity>..ctor
	|-Nullable<InstallModOptions>..ctor
	|-Nullable<LogPlayerUseWeaponOptions>..ctor
	|-Nullable<LoginOptions>..ctor
	|-Nullable<OnIncomingConnectionRequestInfo>..ctor
	|-Nullable<OnPeerConnectionInterruptedInfo>..ctor
	|-Nullable<PS4DLCVerifyPurchaseOptions>..ctor
	|-Nullable<PS4IAPVerifyPurchaseOptions>..ctor
	|-Nullable<PS5DLCVerifyPurchaseOptions>..ctor
	|-Nullable<PS5IAPVerifyPurchaseOptions>..ctor
	|-Nullable<Stat>..ctor
	|-Nullable<XSXPrePresentOptions>..ctor
	|-Nullable<XboxOneGDKPrePresentOptions>..ctor
	|
	|-RVA: 0x149BE00 Offset: 0x149B000 VA: 0x18149BE00
	|-Nullable<Attribute>..ctor
	|-Nullable<CatalogItem>..ctor
	|-Nullable<CreateLobbyOptions>..ctor
	|-Nullable<DefinitionV2>..ctor
	|-Nullable<InfoInternal>..ctor
	|-Nullable<LobbyModificationAddAttributeOptions>..ctor
	|-Nullable<LobbyModificationAddMemberAttributeOptions>..ctor
	|-Nullable<LobbySearchSetParameterOptions>..ctor
	|-Nullable<PS4InitializeOptionsSystemInitializeOptions>..ctor
	|-Nullable<PlayerAchievement>..ctor
	|-Nullable<PlayerAchievementInternal>..ctor
	|-Nullable<SessionDetailsAttribute>..ctor
	|-Nullable<SessionDetailsInfo>..ctor
	|-Nullable<SessionModificationAddAttributeOptions>..ctor
	|-Nullable<SessionSearchSetParameterOptions>..ctor
	|-Nullable<Token>..ctor
	|
	|-RVA: 0x14AC290 Offset: 0x14AB490 VA: 0x1814AC290
	|-Nullable<CatalogItemInternal>..ctor
	|-Nullable<Definition>..ctor
	|-Nullable<DefinitionV2Internal>..ctor
	|-Nullable<IOSLoginOptions>..ctor
	|-Nullable<LobbyDetailsInfoInternal>..ctor
	|-Nullable<TokenInternal>..ctor
	|-Nullable<VerifyIdTokenCallbackInfo>..ctor
	|-Nullable<VerifyUserAuthOptions>..ctor
	|
	|-RVA: 0x14AC220 Offset: 0x14AB420 VA: 0x1814AC220
	|-Nullable<CatalogOffer>..ctor
	|-Nullable<CatalogOfferInternal>..ctor
	|
	|-RVA: 0x14AC280 Offset: 0x14AB480 VA: 0x1814AC280
	|-Nullable<char>..ctor
	|-Nullable<short>..ctor
	|-Nullable<Int16Enum>..ctor
	|-Nullable<ushort>..ctor
	|-Nullable<UInt16Enum>..ctor
	|
	|-RVA: 0x14AC210 Offset: 0x14AB410 VA: 0x1814AC210
	|-Nullable<Color>..ctor
	|-Nullable<Guid>..ctor
	|-Nullable<Quat>..ctor
	|-Nullable<QuatInternal>..ctor
	|-Nullable<Rect>..ctor
	|-Nullable<SentryId>..ctor
	|
	|-RVA: 0xB54A80 Offset: 0xB53C80 VA: 0x180B54A80
	|-Nullable<CopyUserTokenByIndexOptions>..ctor
	|-Nullable<DesktopCrossplayStatusInfo>..ctor
	|-Nullable<LocalRTCOptions>..ctor
	|-Nullable<PS5OptionsInitOptionsInternal>..ctor
	|-Nullable<PageQuery>..ctor
	|-Nullable<Vector2>..ctor
	|-Nullable<XSXPrePresentAdditionalDataInternal>..ctor
	|-Nullable<XboxOneGDKPrePresentAdditionalDataInternal>..ctor
	|
	|-RVA: 0x14BC1B0 Offset: 0x14BB3B0 VA: 0x1814BC1B0
	|-Nullable<Definition>..ctor
	|-Nullable<Info>..ctor
	|-Nullable<InstallModCallbackInfo>..ctor
	|-Nullable<LinkAccountCallbackInfo>..ctor
	|-Nullable<LogPlayerTickOptions>..ctor
	|-Nullable<OnPeerConnectionEstablishedInfo>..ctor
	|-Nullable<OnRemoteConnectionClosedInfo>..ctor
	|-Nullable<PS5InitializeOptionsSystemInitializeOptions>..ctor
	|-Nullable<QueryLeaderboardUserScoresOptions>..ctor
	|-Nullable<QueryStatsOptions>..ctor
	|-Nullable<UninstallModCallbackInfo>..ctor
	|-Nullable<UpdateModCallbackInfo>..ctor
	|
	|-RVA: 0x14BC170 Offset: 0x14BB370 VA: 0x1814BC170
	|-Nullable<DefinitionInternal>..ctor
	|-Nullable<LoginCallbackInfo>..ctor
	|-Nullable<SendPacketOptions>..ctor
	|-Nullable<VerifyIdTokenCallbackInfo>..ctor
	|
	|-RVA: 0x14BC1E0 Offset: 0x14BB3E0 VA: 0x1814BC1E0
	|-Nullable<double>..ctor
	|
	|-RVA: 0x14CB0A0 Offset: 0x14CA2A0 VA: 0x1814CB0A0
	|-Nullable<InitializeOptions>..ctor
	|
	|-RVA: 0x14DAFB0 Offset: 0x14DA1B0 VA: 0x1814DAFB0
	|-Nullable<LogEventParamPair>..ctor
	|-Nullable<LogEventParamPairParamValue>..ctor
	|
	|-RVA: 0x14DB000 Offset: 0x14DA200 VA: 0x1814DB000
	|-Nullable<LogPlayerTakeDamageOptions>..ctor
	|
	|-RVA: 0x14EC3D0 Offset: 0x14EB5D0 VA: 0x1814EC3D0
	|-Nullable<Options>..ctor
	|
	|-RVA: 0x14EC430 Offset: 0x14EB630 VA: 0x1814EC430
	|-Nullable<PS4InitializeOptions>..ctor
	|
	|-RVA: 0x14EC4D0 Offset: 0x14EB6D0 VA: 0x1814EC4D0
	|-Nullable<PS5InitializeOptions>..ctor
	|
	|-RVA: 0x14EC4B0 Offset: 0x14EB6B0 VA: 0x1814EC4B0
	|-Nullable<PageResult>..ctor
	|-Nullable<Token>..ctor
	|-Nullable<Vec3f>..ctor
	|-Nullable<Vec3fInternal>..ctor
	|-Nullable<Vector3>..ctor
	|
	|-RVA: 0x14FB9C0 Offset: 0x14FABC0 VA: 0x1814FB9C0
	|-Nullable<RectInternal>..ctor
	|
	|-RVA: 0x150AF50 Offset: 0x150A150 VA: 0x18150AF50
	|-Nullable<ReportInputStateOptions>..ctor
	|
	|-RVA: 0x150AF30 Offset: 0x150A130 VA: 0x18150AF30
	|-Nullable<SequencePoint>..ctor
	|
	|-RVA: 0x150AF20 Offset: 0x150A120 VA: 0x18150AF20
	|-Nullable<SetPortRangeOptions>..ctor
	|
	|-RVA: 0x151B410 Offset: 0x151A610 VA: 0x18151B410
	|-Nullable<float>..ctor
	|
	|-RVA: 0x151B3E0 Offset: 0x151A5E0 VA: 0x18151B3E0
	|-Nullable<Touch>..ctor
	|
	|-RVA: 0xB54810 Offset: 0xB53A10 VA: 0x180B54810
	|-Nullable<WindowsOptions>..ctor
	|-Nullable<XSXOptions>..ctor
	|-Nullable<XboxOneGDKOptions>..ctor
	|
	|-RVA: 0xB54AB0 Offset: 0xB53CB0 VA: 0x180B54AB0
	|-Nullable<XSXInitializeOptions>..ctor
	|-Nullable<XboxOneGDKInitializeOptions>..ctor
	|
	|-RVA: 0xB54910 Offset: 0xB53B10 VA: 0x180B54910
	|-Nullable<__Il2CppFullySharedGenericStructType>..ctor
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public bool get_HasValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x41D600 Offset: 0x41C800 VA: 0x18041D600
	|-Nullable<ArraySegment<byte>>.get_HasValue
	|-Nullable<ValueTuple<object, object>>.get_HasValue
	|-Nullable<AcceptConnectionOptions>.get_HasValue
	|-Nullable<AcceptInviteCallbackInfo>.get_HasValue
	|-Nullable<AcceptInviteOptions>.get_HasValue
	|-Nullable<AcceptRequestToJoinCallbackInfo>.get_HasValue
	|-Nullable<AcceptRequestToJoinOptions>.get_HasValue
	|-Nullable<AccountFeatureRestrictedInfo>.get_HasValue
	|-Nullable<AccountFeatureRestrictedInfoInternal>.get_HasValue
	|-Nullable<AcknowledgeEventIdOptions>.get_HasValue
	|-Nullable<ActiveSessionCopyInfoOptions>.get_HasValue
	|-Nullable<ActiveSessionGetRegisteredPlayerByIndexOptions>.get_HasValue
	|-Nullable<ActiveSessionGetRegisteredPlayerCountOptions>.get_HasValue
	|-Nullable<ActiveSessionInfo>.get_HasValue
	|-Nullable<ActiveSessionInfoInternal>.get_HasValue
	|-Nullable<AddExternalIntegrityCatalogOptions>.get_HasValue
	|-Nullable<AddNotifyAchievementsUnlockedOptions>.get_HasValue
	|-Nullable<AddNotifyAchievementsUnlockedV2Options>.get_HasValue
	|-Nullable<AddNotifyAudioBeforeRenderOptions>.get_HasValue
	|-Nullable<AddNotifyAudioBeforeSendOptions>.get_HasValue
	|-Nullable<AddNotifyAudioDevicesChangedOptions>.get_HasValue
	|-Nullable<AddNotifyAudioInputStateOptions>.get_HasValue
	|-Nullable<AddNotifyAudioOutputStateOptions>.get_HasValue
	|-Nullable<AddNotifyAuthExpirationOptions>.get_HasValue
	|-Nullable<AddNotifyBlockedUsersUpdateOptions>.get_HasValue
	|-Nullable<AddNotifyClientActionRequiredOptions>.get_HasValue
	|-Nullable<AddNotifyClientAuthStatusChangedOptions>.get_HasValue
	|-Nullable<AddNotifyClientIntegrityViolatedOptions>.get_HasValue
	|-Nullable<AddNotifyCustomInviteAcceptedOptions>.get_HasValue
	|-Nullable<AddNotifyCustomInviteReceivedOptions>.get_HasValue
	|-Nullable<AddNotifyCustomInviteRejectedOptions>.get_HasValue
	|-Nullable<AddNotifyDataReceivedOptions>.get_HasValue
	|-Nullable<AddNotifyDisconnectedOptions>.get_HasValue
	|-Nullable<AddNotifyDisplaySettingsUpdatedOptions>.get_HasValue
	|-Nullable<AddNotifyFriendsUpdateOptions>.get_HasValue
	|-Nullable<AddNotifyIncomingPacketQueueFullOptions>.get_HasValue
	|-Nullable<AddNotifyJoinGameAcceptedOptions>.get_HasValue
	|-Nullable<AddNotifyJoinLobbyAcceptedOptions>.get_HasValue
	|-Nullable<AddNotifyJoinSessionAcceptedOptions>.get_HasValue
	|-Nullable<AddNotifyLeaveLobbyRequestedOptions>.get_HasValue
	|-Nullable<AddNotifyLeaveSessionRequestedOptions>.get_HasValue
	|-Nullable<AddNotifyLobbyInviteAcceptedOptions>.get_HasValue
	|-Nullable<AddNotifyLobbyInviteReceivedOptions>.get_HasValue
	|-Nullable<AddNotifyLobbyInviteRejectedOptions>.get_HasValue
	|-Nullable<AddNotifyLobbyMemberStatusReceivedOptions>.get_HasValue
	|-Nullable<AddNotifyLobbyMemberUpdateReceivedOptions>.get_HasValue
	|-Nullable<AddNotifyLobbyUpdateReceivedOptions>.get_HasValue
	|-Nullable<AddNotifyLoginStatusChangedOptions>.get_HasValue
	|-Nullable<AddNotifyLoginStatusChangedOptions>.get_HasValue
	|-Nullable<AddNotifyMemoryMonitorOptions>.get_HasValue
	|-Nullable<AddNotifyMessageToClientOptions>.get_HasValue
	|-Nullable<AddNotifyMessageToPeerOptions>.get_HasValue
	|-Nullable<AddNotifyMessageToServerOptions>.get_HasValue
	|-Nullable<AddNotifyOnPresenceChangedOptions>.get_HasValue
	|-Nullable<AddNotifyParticipantStatusChangedOptions>.get_HasValue
	|-Nullable<AddNotifyParticipantUpdatedOptions>.get_HasValue
	|-Nullable<AddNotifyParticipantUpdatedOptions>.get_HasValue
	|-Nullable<AddNotifyPeerActionRequiredOptions>.get_HasValue
	|-Nullable<AddNotifyPeerAuthStatusChangedOptions>.get_HasValue
	|-Nullable<AddNotifyPeerConnectionClosedOptions>.get_HasValue
	|-Nullable<AddNotifyPeerConnectionEstablishedOptions>.get_HasValue
	|-Nullable<AddNotifyPeerConnectionInterruptedOptions>.get_HasValue
	|-Nullable<AddNotifyPeerConnectionRequestOptions>.get_HasValue
	|-Nullable<AddNotifyPermissionsUpdateReceivedOptions>.get_HasValue
	|-Nullable<AddNotifyRTCRoomConnectionChangedOptions>.get_HasValue
	|-Nullable<AddNotifyRequestToJoinAcceptedOptions>.get_HasValue
	|-Nullable<AddNotifyRequestToJoinReceivedOptions>.get_HasValue
	|-Nullable<AddNotifyRequestToJoinRejectedOptions>.get_HasValue
	|-Nullable<AddNotifyRequestToJoinResponseReceivedOptions>.get_HasValue
	|-Nullable<AddNotifyRoomStatisticsUpdatedOptions>.get_HasValue
	|-Nullable<AddNotifySendCustomNativeInviteRequestedOptions>.get_HasValue
	|-Nullable<AddNotifySendLobbyNativeInviteRequestedOptions>.get_HasValue
	|-Nullable<AddNotifySendSessionNativeInviteRequestedOptions>.get_HasValue
	|-Nullable<AddNotifySessionInviteAcceptedOptions>.get_HasValue
	|-Nullable<AddNotifySessionInviteReceivedOptions>.get_HasValue
	|-Nullable<AddNotifySessionInviteRejectedOptions>.get_HasValue
	|-Nullable<AddNotifyUserLoginStatusChangedOptions>.get_HasValue
	|-Nullable<AddProgressionOptions>.get_HasValue
	|-Nullable<AndroidIAPVerifyPurchaseOptions>.get_HasValue
	|-Nullable<AndroidIAPVerifyPurchaseOptionsPlatformSpecificOptions>.get_HasValue
	|-Nullable<AndroidInitializeOptions>.get_HasValue
	|-Nullable<AndroidInitializeOptionsSystemInitializeOptions>.get_HasValue
	|-Nullable<Announcement>.get_HasValue
	|-Nullable<Attribute>.get_HasValue
	|-Nullable<AttributeData>.get_HasValue
	|-Nullable<AttributeData>.get_HasValue
	|-Nullable<AttributeDataInternal>.get_HasValue
	|-Nullable<AttributeDataInternal>.get_HasValue
	|-Nullable<AttributeDataValue>.get_HasValue
	|-Nullable<AttributeDataValue>.get_HasValue
	|-Nullable<AttributeInternal>.get_HasValue
	|-Nullable<AudioBeforeRenderCallbackInfo>.get_HasValue
	|-Nullable<AudioBeforeSendCallbackInfo>.get_HasValue
	|-Nullable<AudioBuffer>.get_HasValue
	|-Nullable<AudioBufferInternal>.get_HasValue
	|-Nullable<AudioDevicesChangedCallbackInfo>.get_HasValue
	|-Nullable<AudioInputDeviceInfo>.get_HasValue
	|-Nullable<AudioInputDeviceInfoInternal>.get_HasValue
	|-Nullable<AudioInputStateCallbackInfo>.get_HasValue
	|-Nullable<AudioOutputDeviceInfo>.get_HasValue
	|-Nullable<AudioOutputDeviceInfoInternal>.get_HasValue
	|-Nullable<AudioOutputStateCallbackInfo>.get_HasValue
	|-Nullable<AuthExpirationCallbackInfo>.get_HasValue
	|-Nullable<BeginPlayerSessionOptions>.get_HasValue
	|-Nullable<BeginPlayerSessionOptionsAccountId>.get_HasValue
	|-Nullable<BeginSessionOptions>.get_HasValue
	|-Nullable<BeginSessionOptions>.get_HasValue
	|-Nullable<BeginSnapshotOptions>.get_HasValue
	|-Nullable<BestDisplayName>.get_HasValue
	|-Nullable<BestDisplayNameInternal>.get_HasValue
	|-Nullable<BigInteger>.get_HasValue
	|-Nullable<BlockParticipantCallbackInfo>.get_HasValue
	|-Nullable<BlockParticipantOptions>.get_HasValue
	|-Nullable<bool>.get_HasValue
	|-Nullable<byte>.get_HasValue
	|-Nullable<CatalogItem>.get_HasValue
	|-Nullable<CatalogItemInternal>.get_HasValue
	|-Nullable<CatalogOffer>.get_HasValue
	|-Nullable<CatalogOfferInternal>.get_HasValue
	|-Nullable<CatalogRelease>.get_HasValue
	|-Nullable<CatalogReleaseInternal>.get_HasValue
	|-Nullable<char>.get_HasValue
	|-Nullable<CheckoutCallbackInfo>.get_HasValue
	|-Nullable<CheckoutEntry>.get_HasValue
	|-Nullable<CheckoutOptions>.get_HasValue
	|-Nullable<CheckpointOptions>.get_HasValue
	|-Nullable<ClearPacketQueueOptions>.get_HasValue
	|-Nullable<ClearUserPreLogoutCallbackOptions>.get_HasValue
	|-Nullable<ClientCredentials>.get_HasValue
	|-Nullable<CloseConnectionOptions>.get_HasValue
	|-Nullable<CloseConnectionsOptions>.get_HasValue
	|-Nullable<CloseOptions>.get_HasValue
	|-Nullable<Color>.get_HasValue
	|-Nullable<CopyAchievementDefinitionByAchievementIdOptions>.get_HasValue
	|-Nullable<CopyAchievementDefinitionByIndexOptions>.get_HasValue
	|-Nullable<CopyAchievementDefinitionV2ByAchievementIdOptions>.get_HasValue
	|-Nullable<CopyAchievementDefinitionV2ByIndexOptions>.get_HasValue
	|-Nullable<CopyActiveSessionHandleOptions>.get_HasValue
	|-Nullable<CopyBestDisplayNameOptions>.get_HasValue
	|-Nullable<CopyBestDisplayNameWithPlatformOptions>.get_HasValue
	|-Nullable<CopyEntitlementByIdOptions>.get_HasValue
	|-Nullable<CopyEntitlementByIndexOptions>.get_HasValue
	|-Nullable<CopyEntitlementByNameAndIndexOptions>.get_HasValue
	|-Nullable<CopyExternalUserInfoByAccountIdOptions>.get_HasValue
	|-Nullable<CopyExternalUserInfoByAccountTypeOptions>.get_HasValue
	|-Nullable<CopyExternalUserInfoByIndexOptions>.get_HasValue
	|-Nullable<CopyFileMetadataAtIndexOptions>.get_HasValue
	|-Nullable<CopyFileMetadataAtIndexOptions>.get_HasValue
	|-Nullable<CopyFileMetadataByFilenameOptions>.get_HasValue
	|-Nullable<CopyFileMetadataByFilenameOptions>.get_HasValue
	|-Nullable<CopyIdTokenOptions>.get_HasValue
	|-Nullable<CopyIdTokenOptions>.get_HasValue
	|-Nullable<CopyInputDeviceInformationByIndexOptions>.get_HasValue
	|-Nullable<CopyItemByIdOptions>.get_HasValue
	|-Nullable<CopyItemImageInfoByIndexOptions>.get_HasValue
	|-Nullable<CopyItemReleaseByIndexOptions>.get_HasValue
	|-Nullable<CopyLastRedeemedEntitlementByIndexOptions>.get_HasValue
	|-Nullable<CopyLeaderboardDefinitionByIndexOptions>.get_HasValue
	|-Nullable<CopyLeaderboardDefinitionByLeaderboardIdOptions>.get_HasValue
	|-Nullable<CopyLeaderboardRecordByIndexOptions>.get_HasValue
	|-Nullable<CopyLeaderboardRecordByUserIdOptions>.get_HasValue
	|-Nullable<CopyLeaderboardUserScoreByIndexOptions>.get_HasValue
	|-Nullable<CopyLeaderboardUserScoreByUserIdOptions>.get_HasValue
	|-Nullable<CopyLobbyDetailsHandleByInviteIdOptions>.get_HasValue
	|-Nullable<CopyLobbyDetailsHandleByUiEventIdOptions>.get_HasValue
	|-Nullable<CopyLobbyDetailsHandleOptions>.get_HasValue
	|-Nullable<CopyModInfoOptions>.get_HasValue
	|-Nullable<CopyOfferByIdOptions>.get_HasValue
	|-Nullable<CopyOfferByIndexOptions>.get_HasValue
	|-Nullable<CopyOfferImageInfoByIndexOptions>.get_HasValue
	|-Nullable<CopyOfferItemByIndexOptions>.get_HasValue
	|-Nullable<CopyOutputDeviceInformationByIndexOptions>.get_HasValue
	|-Nullable<CopyPermissionByIndexOptions>.get_HasValue
	|-Nullable<CopyPlayerAchievementByAchievementIdOptions>.get_HasValue
	|-Nullable<CopyPlayerAchievementByIndexOptions>.get_HasValue
	|-Nullable<CopyPlayerSanctionByIndexOptions>.get_HasValue
	|-Nullable<CopyPresenceOptions>.get_HasValue
	|-Nullable<CopyProductUserExternalAccountByAccountIdOptions>.get_HasValue
	|-Nullable<CopyProductUserExternalAccountByAccountTypeOptions>.get_HasValue
	|-Nullable<CopyProductUserExternalAccountByIndexOptions>.get_HasValue
	|-Nullable<CopyProductUserInfoOptions>.get_HasValue
	|-Nullable<CopySessionHandleByInviteIdOptions>.get_HasValue
	|-Nullable<CopySessionHandleByUiEventIdOptions>.get_HasValue
	|-Nullable<CopySessionHandleForPresenceOptions>.get_HasValue
	|-Nullable<CopyStatByIndexOptions>.get_HasValue
	|-Nullable<CopyStatByNameOptions>.get_HasValue
	|-Nullable<CopyTransactionByIdOptions>.get_HasValue
	|-Nullable<CopyTransactionByIndexOptions>.get_HasValue
	|-Nullable<CopyUnlockedAchievementByAchievementIdOptions>.get_HasValue
	|-Nullable<CopyUnlockedAchievementByIndexOptions>.get_HasValue
	|-Nullable<CopyUserAuthTokenOptions>.get_HasValue
	|-Nullable<CopyUserInfoOptions>.get_HasValue
	|-Nullable<CopyUserTokenByIndexOptions>.get_HasValue
	|-Nullable<CopyUserTokenByUserIdOptions>.get_HasValue
	|-Nullable<CreateDeviceIdCallbackInfo>.get_HasValue
	|-Nullable<CreateDeviceIdOptions>.get_HasValue
	|-Nullable<CreateIntegratedPlatformOptionsContainerOptions>.get_HasValue
	|-Nullable<CreateLobbyCallbackInfo>.get_HasValue
	|-Nullable<CreateLobbyOptions>.get_HasValue
	|-Nullable<CreateLobbySearchOptions>.get_HasValue
	|-Nullable<CreateOptions>.get_HasValue
	|-Nullable<CreatePlayerSanctionAppealCallbackInfo>.get_HasValue
	|-Nullable<CreatePlayerSanctionAppealOptions>.get_HasValue
	|-Nullable<CreatePresenceModificationOptions>.get_HasValue
	|-Nullable<CreateSessionModificationOptions>.get_HasValue
	|-Nullable<CreateSessionSearchOptions>.get_HasValue
	|-Nullable<CreateUserCallbackInfo>.get_HasValue
	|-Nullable<CreateUserCallbackInfo>.get_HasValue
	|-Nullable<CreateUserOptions>.get_HasValue
	|-Nullable<CreateUserOptions>.get_HasValue
	|-Nullable<Credentials>.get_HasValue
	|-Nullable<Credentials>.get_HasValue
	|-Nullable<CustomInviteRejectedCallbackInfo>.get_HasValue
	|-Nullable<DataKey>.get_HasValue
	|-Nullable<DataReceivedCallbackInfo>.get_HasValue
	|-Nullable<DataRecord>.get_HasValue
	|-Nullable<DateTime>.get_HasValue
	|-Nullable<DateTimeOffset>.get_HasValue
	|-Nullable<Decimal>.get_HasValue
	|-Nullable<Definition>.get_HasValue
	|-Nullable<Definition>.get_HasValue
	|-Nullable<DefinitionInternal>.get_HasValue
	|-Nullable<DefinitionInternal>.get_HasValue
	|-Nullable<DefinitionV2>.get_HasValue
	|-Nullable<DefinitionV2Internal>.get_HasValue
	|-Nullable<DeleteCacheCallbackInfo>.get_HasValue
	|-Nullable<DeleteCacheCallbackInfo>.get_HasValue
	|-Nullable<DeleteCacheOptions>.get_HasValue
	|-Nullable<DeleteCacheOptions>.get_HasValue
	|-Nullable<DeleteDeviceIdCallbackInfo>.get_HasValue
	|-Nullable<DeleteDeviceIdOptions>.get_HasValue
	|-Nullable<DeleteFileCallbackInfo>.get_HasValue
	|-Nullable<DeleteFileOptions>.get_HasValue
	|-Nullable<DeletePersistentAuthCallbackInfo>.get_HasValue
	|-Nullable<DeletePersistentAuthOptions>.get_HasValue
	|-Nullable<DeleteSnapshotCallbackInfo>.get_HasValue
	|-Nullable<DeleteSnapshotOptions>.get_HasValue
	|-Nullable<DesktopCrossplayStatusInfo>.get_HasValue
	|-Nullable<DestroyLobbyCallbackInfo>.get_HasValue
	|-Nullable<DestroyLobbyOptions>.get_HasValue
	|-Nullable<DestroySessionCallbackInfo>.get_HasValue
	|-Nullable<DestroySessionOptions>.get_HasValue
	|-Nullable<DisconnectedCallbackInfo>.get_HasValue
	|-Nullable<double>.get_HasValue
	|-Nullable<DumpSessionStateOptions>.get_HasValue
	|-Nullable<DuplicateFileCallbackInfo>.get_HasValue
	|-Nullable<DuplicateFileOptions>.get_HasValue
	|-Nullable<EGSDLCVerifyPurchaseOptions>.get_HasValue
	|-Nullable<EGSDLCVerifyPurchaseOptionsPlatformSpecificOptions>.get_HasValue
	|-Nullable<EGSIAPVerifyPurchaseOptions>.get_HasValue
	|-Nullable<EGSIAPVerifyPurchaseOptionsPlatformSpecificOptions>.get_HasValue
	|-Nullable<EndPlayerSessionOptions>.get_HasValue
	|-Nullable<EndPlayerSessionOptionsAccountId>.get_HasValue
	|-Nullable<EndSessionCallbackInfo>.get_HasValue
	|-Nullable<EndSessionOptions>.get_HasValue
	|-Nullable<EndSessionOptions>.get_HasValue
	|-Nullable<EndSessionOptions>.get_HasValue
	|-Nullable<EndSnapshotOptions>.get_HasValue
	|-Nullable<Entitlement>.get_HasValue
	|-Nullable<EntitlementInternal>.get_HasValue
	|-Nullable<EnumerateModsCallbackInfo>.get_HasValue
	|-Nullable<EnumerateModsOptions>.get_HasValue
	|-Nullable<EventDispatcherGate>.get_HasValue
	|-Nullable<ExternalAccountInfo>.get_HasValue
	|-Nullable<ExternalAccountInfoInternal>.get_HasValue
	|-Nullable<ExternalUserInfo>.get_HasValue
	|-Nullable<ExternalUserInfoInternal>.get_HasValue
	|-Nullable<FileMetadata>.get_HasValue
	|-Nullable<FileMetadata>.get_HasValue
	|-Nullable<FileMetadataInternal>.get_HasValue
	|-Nullable<FileMetadataInternal>.get_HasValue
	|-Nullable<FileTransferProgressCallbackInfo>.get_HasValue
	|-Nullable<FileTransferProgressCallbackInfo>.get_HasValue
	|-Nullable<FinalizeDeferredUserLogoutOptions>.get_HasValue
	|-Nullable<FinalizeInviteOptions>.get_HasValue
	|-Nullable<GCHandle>.get_HasValue
	|-Nullable<GetAchievementDefinitionCountOptions>.get_HasValue
	|-Nullable<GetAudioInputDeviceByIndexOptions>.get_HasValue
	|-Nullable<GetAudioInputDevicesCountOptions>.get_HasValue
	|-Nullable<GetAudioOutputDeviceByIndexOptions>.get_HasValue
	|-Nullable<GetAudioOutputDevicesCountOptions>.get_HasValue
	|-Nullable<GetBlockedUserAtIndexOptions>.get_HasValue
	|-Nullable<GetBlockedUsersCountOptions>.get_HasValue
	|-Nullable<GetConnectStringOptions>.get_HasValue
	|-Nullable<GetDesktopCrossplayStatusOptions>.get_HasValue
	|-Nullable<GetEntitlementsByNameCountOptions>.get_HasValue
	|-Nullable<GetEntitlementsCountOptions>.get_HasValue
	|-Nullable<GetExternalAccountMappingsOptions>.get_HasValue
	|-Nullable<GetExternalUserInfoCountOptions>.get_HasValue
	|-Nullable<GetFileMetadataCountOptions>.get_HasValue
	|-Nullable<GetFileMetadataCountOptions>.get_HasValue
	|-Nullable<GetFriendAtIndexOptions>.get_HasValue
	|-Nullable<GetFriendsCountOptions>.get_HasValue
	|-Nullable<GetFriendsExclusiveInputOptions>.get_HasValue
	|-Nullable<GetFriendsVisibleOptions>.get_HasValue
	|-Nullable<GetInputDevicesCountOptions>.get_HasValue
	|-Nullable<GetInviteCountOptions>.get_HasValue
	|-Nullable<GetInviteCountOptions>.get_HasValue
	|-Nullable<GetInviteIdByIndexOptions>.get_HasValue
	|-Nullable<GetInviteIdByIndexOptions>.get_HasValue
	|-Nullable<GetItemImageInfoCountOptions>.get_HasValue
	|-Nullable<GetItemReleaseCountOptions>.get_HasValue
	|-Nullable<GetJoinInfoOptions>.get_HasValue
	|-Nullable<GetLastRedeemedEntitlementsCountOptions>.get_HasValue
	|-Nullable<GetLeaderboardDefinitionCountOptions>.get_HasValue
	|-Nullable<GetLeaderboardRecordCountOptions>.get_HasValue
	|-Nullable<GetLeaderboardUserScoreCountOptions>.get_HasValue
	|-Nullable<GetLocalPlatformTypeOptions>.get_HasValue
	|-Nullable<GetNATTypeOptions>.get_HasValue
	|-Nullable<GetNextReceivedPacketSizeOptions>.get_HasValue
	|-Nullable<GetOfferCountOptions>.get_HasValue
	|-Nullable<GetOfferImageInfoCountOptions>.get_HasValue
	|-Nullable<GetOfferItemCountOptions>.get_HasValue
	|-Nullable<GetOutputDevicesCountOptions>.get_HasValue
	|-Nullable<GetPacketQueueInfoOptions>.get_HasValue
	|-Nullable<GetPermissionByKeyOptions>.get_HasValue
	|-Nullable<GetPermissionsCountOptions>.get_HasValue
	|-Nullable<GetPlayerAchievementCountOptions>.get_HasValue
	|-Nullable<GetPlayerSanctionCountOptions>.get_HasValue
	|-Nullable<GetPortRangeOptions>.get_HasValue
	|-Nullable<GetProductUserExternalAccountCountOptions>.get_HasValue
	|-Nullable<GetProductUserIdMappingOptions>.get_HasValue
	|-Nullable<GetProtectMessageOutputLengthOptions>.get_HasValue
	|-Nullable<GetProtectMessageOutputLengthOptions>.get_HasValue
	|-Nullable<GetRTCRoomNameOptions>.get_HasValue
	|-Nullable<GetRelayControlOptions>.get_HasValue
	|-Nullable<GetStatCountOptions>.get_HasValue
	|-Nullable<GetStatusOptions>.get_HasValue
	|-Nullable<GetToggleFriendsButtonOptions>.get_HasValue
	|-Nullable<GetToggleFriendsKeyOptions>.get_HasValue
	|-Nullable<GetTransactionCountOptions>.get_HasValue
	|-Nullable<GetUnlockedAchievementCountOptions>.get_HasValue
	|-Nullable<Guid>.get_HasValue
	|-Nullable<HardMuteMemberCallbackInfo>.get_HasValue
	|-Nullable<HardMuteMemberOptions>.get_HasValue
	|-Nullable<HasPresenceOptions>.get_HasValue
	|-Nullable<HideFriendsCallbackInfo>.get_HasValue
	|-Nullable<HideFriendsOptions>.get_HasValue
	|-Nullable<IOSCredentials>.get_HasValue
	|-Nullable<IOSCredentialsSystemAuthCredentialsOptions>.get_HasValue
	|-Nullable<IOSCredentialsSystemAuthCredentialsOptionsInternal>.get_HasValue
	|-Nullable<IOSIAPVerifyPurchaseOptions>.get_HasValue
	|-Nullable<IOSIAPVerifyPurchaseOptionsPlatformSpecificOptions>.get_HasValue
	|-Nullable<IOSLoginOptions>.get_HasValue
	|-Nullable<IdToken>.get_HasValue
	|-Nullable<IdToken>.get_HasValue
	|-Nullable<IdTokenInternal>.get_HasValue
	|-Nullable<IdTokenInternal>.get_HasValue
	|-Nullable<Info>.get_HasValue
	|-Nullable<InfoInternal>.get_HasValue
	|-Nullable<IngestData>.get_HasValue
	|-Nullable<IngestStatCompleteCallbackInfo>.get_HasValue
	|-Nullable<IngestStatOptions>.get_HasValue
	|-Nullable<InitializeOptions>.get_HasValue
	|-Nullable<InitializeThreadAffinity>.get_HasValue
	|-Nullable<InputDeviceInformation>.get_HasValue
	|-Nullable<InputDeviceInformationInternal>.get_HasValue
	|-Nullable<InstallModCallbackInfo>.get_HasValue
	|-Nullable<InstallModOptions>.get_HasValue
	|-Nullable<short>.get_HasValue
	|-Nullable<Int16Enum>.get_HasValue
	|-Nullable<int>.get_HasValue
	|-Nullable<Int32Enum>.get_HasValue
	|-Nullable<long>.get_HasValue
	|-Nullable<IntPtr>.get_HasValue
	|-Nullable<IntegratedPlatformOptionsContainerAddOptions>.get_HasValue
	|-Nullable<InventoryItemCreateSubItemOptions>.get_HasValue
	|-Nullable<InventoryItemDeleteSubItemOptions>.get_HasValue
	|-Nullable<InventoryItemGetDoubleSetValueByIndexOptions>.get_HasValue
	|-Nullable<InventoryItemGetInt64SetValueByIndexOptions>.get_HasValue
	|-Nullable<InventoryItemGetKeyOptions>.get_HasValue
	|-Nullable<InventoryItemGetStringSetValueByIndexOptions>.get_HasValue
	|-Nullable<InventoryItemGetSubItemByIndexOptions>.get_HasValue
	|-Nullable<InventoryItemGetSubItemOptions>.get_HasValue
	|-Nullable<InventoryItemGetSubItemsCountOptions>.get_HasValue
	|-Nullable<InventoryItemGetValueAsBoolOptions>.get_HasValue
	|-Nullable<InventoryItemGetValueAsDoubleOptions>.get_HasValue
	|-Nullable<InventoryItemGetValueAsInt64Options>.get_HasValue
	|-Nullable<InventoryItemGetValueAsStringOptions>.get_HasValue
	|-Nullable<InventoryItemGetValueAsTimestampOptions>.get_HasValue
	|-Nullable<InventoryItemGetValueCountOptions>.get_HasValue
	|-Nullable<InventoryItemGetValueTypeOptions>.get_HasValue
	|-Nullable<InventoryItemSetKeyOptions>.get_HasValue
	|-Nullable<InventoryItemSetValueAsBoolOptions>.get_HasValue
	|-Nullable<InventoryItemSetValueAsDoubleOptions>.get_HasValue
	|-Nullable<InventoryItemSetValueAsDoubleSetOptions>.get_HasValue
	|-Nullable<InventoryItemSetValueAsInt64Options>.get_HasValue
	|-Nullable<InventoryItemSetValueAsInt64SetOptions>.get_HasValue
	|-Nullable<InventoryItemSetValueAsStringOptions>.get_HasValue
	|-Nullable<InventoryItemSetValueAsStringSetOptions>.get_HasValue
	|-Nullable<InventoryItemSetValueAsTimestampOptions>.get_HasValue
	|-Nullable<IsRTCRoomConnectedOptions>.get_HasValue
	|-Nullable<IsSocialOverlayPausedOptions>.get_HasValue
	|-Nullable<IsUserInSessionOptions>.get_HasValue
	|-Nullable<ItemOwnership>.get_HasValue
	|-Nullable<JoinGameAcceptedCallbackInfo>.get_HasValue
	|-Nullable<JoinLobbyAcceptedCallbackInfo>.get_HasValue
	|-Nullable<JoinLobbyByIdCallbackInfo>.get_HasValue
	|-Nullable<JoinLobbyByIdOptions>.get_HasValue
	|-Nullable<JoinLobbyCallbackInfo>.get_HasValue
	|-Nullable<JoinLobbyOptions>.get_HasValue
	|-Nullable<JoinRoomCallbackInfo>.get_HasValue
	|-Nullable<JoinRoomOptions>.get_HasValue
	|-Nullable<JoinSessionAcceptedCallbackInfo>.get_HasValue
	|-Nullable<JoinSessionCallbackInfo>.get_HasValue
	|-Nullable<JoinSessionOptions>.get_HasValue
	|-Nullable<JsonElement>.get_HasValue
	|-Nullable<JsonPosition>.get_HasValue
	|-Nullable<KeyImageInfo>.get_HasValue
	|-Nullable<KeyImageInfoInternal>.get_HasValue
	|-Nullable<KickCompleteCallbackInfo>.get_HasValue
	|-Nullable<KickMemberCallbackInfo>.get_HasValue
	|-Nullable<KickMemberOptions>.get_HasValue
	|-Nullable<KickOptions>.get_HasValue
	|-Nullable<LeaderboardRecord>.get_HasValue
	|-Nullable<LeaderboardRecordInternal>.get_HasValue
	|-Nullable<LeaderboardUserScore>.get_HasValue
	|-Nullable<LeaderboardUserScoreInternal>.get_HasValue
	|-Nullable<LeaveLobbyCallbackInfo>.get_HasValue
	|-Nullable<LeaveLobbyOptions>.get_HasValue
	|-Nullable<LeaveLobbyRequestedCallbackInfo>.get_HasValue
	|-Nullable<LeaveRoomCallbackInfo>.get_HasValue
	|-Nullable<LeaveRoomOptions>.get_HasValue
	|-Nullable<LeaveSessionRequestedCallbackInfo>.get_HasValue
	|-Nullable<LinkAccountCallbackInfo>.get_HasValue
	|-Nullable<LinkAccountCallbackInfo>.get_HasValue
	|-Nullable<LinkAccountOptions>.get_HasValue
	|-Nullable<LinkAccountOptions>.get_HasValue
	|-Nullable<LobbyDetailsCopyAttributeByIndexOptions>.get_HasValue
	|-Nullable<LobbyDetailsCopyAttributeByKeyOptions>.get_HasValue
	|-Nullable<LobbyDetailsCopyInfoOptions>.get_HasValue
	|-Nullable<LobbyDetailsCopyMemberAttributeByIndexOptions>.get_HasValue
	|-Nullable<LobbyDetailsCopyMemberAttributeByKeyOptions>.get_HasValue
	|-Nullable<LobbyDetailsCopyMemberInfoOptions>.get_HasValue
	|-Nullable<LobbyDetailsGetAttributeCountOptions>.get_HasValue
	|-Nullable<LobbyDetailsGetLobbyOwnerOptions>.get_HasValue
	|-Nullable<LobbyDetailsGetMemberAttributeCountOptions>.get_HasValue
	|-Nullable<LobbyDetailsGetMemberByIndexOptions>.get_HasValue
	|-Nullable<LobbyDetailsGetMemberCountOptions>.get_HasValue
	|-Nullable<LobbyDetailsInfo>.get_HasValue
	|-Nullable<LobbyDetailsInfoInternal>.get_HasValue
	|-Nullable<LobbyDetailsMemberInfo>.get_HasValue
	|-Nullable<LobbyDetailsMemberInfoInternal>.get_HasValue
	|-Nullable<LobbyInviteAcceptedCallbackInfo>.get_HasValue
	|-Nullable<LobbyInviteReceivedCallbackInfo>.get_HasValue
	|-Nullable<LobbyInviteRejectedCallbackInfo>.get_HasValue
	|-Nullable<LobbyMemberStatusReceivedCallbackInfo>.get_HasValue
	|-Nullable<LobbyMemberUpdateReceivedCallbackInfo>.get_HasValue
	|-Nullable<LobbyModificationAddAttributeOptions>.get_HasValue
	|-Nullable<LobbyModificationAddMemberAttributeOptions>.get_HasValue
	|-Nullable<LobbyModificationRemoveAttributeOptions>.get_HasValue
	|-Nullable<LobbyModificationRemoveMemberAttributeOptions>.get_HasValue
	|-Nullable<LobbyModificationSetAllowedPlatformIdsOptions>.get_HasValue
	|-Nullable<LobbyModificationSetBucketIdOptions>.get_HasValue
	|-Nullable<LobbyModificationSetInvitesAllowedOptions>.get_HasValue
	|-Nullable<LobbyModificationSetMaxMembersOptions>.get_HasValue
	|-Nullable<LobbyModificationSetPermissionLevelOptions>.get_HasValue
	|-Nullable<LobbySearchCopySearchResultByIndexOptions>.get_HasValue
	|-Nullable<LobbySearchFindCallbackInfo>.get_HasValue
	|-Nullable<LobbySearchFindOptions>.get_HasValue
	|-Nullable<LobbySearchGetSearchResultCountOptions>.get_HasValue
	|-Nullable<LobbySearchRemoveParameterOptions>.get_HasValue
	|-Nullable<LobbySearchSetLobbyIdOptions>.get_HasValue
	|-Nullable<LobbySearchSetMaxResultsOptions>.get_HasValue
	|-Nullable<LobbySearchSetParameterOptions>.get_HasValue
	|-Nullable<LobbySearchSetTargetUserIdOptions>.get_HasValue
	|-Nullable<LobbyUpdateReceivedCallbackInfo>.get_HasValue
	|-Nullable<LocalDefinition>.get_HasValue
	|-Nullable<LocalRTCOptions>.get_HasValue
	|-Nullable<LogEventOptions>.get_HasValue
	|-Nullable<LogEventParamPair>.get_HasValue
	|-Nullable<LogEventParamPairParamValue>.get_HasValue
	|-Nullable<LogGameRoundEndOptions>.get_HasValue
	|-Nullable<LogGameRoundStartOptions>.get_HasValue
	|-Nullable<LogMessage>.get_HasValue
	|-Nullable<LogPlayerDespawnOptions>.get_HasValue
	|-Nullable<LogPlayerReviveOptions>.get_HasValue
	|-Nullable<LogPlayerSpawnOptions>.get_HasValue
	|-Nullable<LogPlayerTakeDamageOptions>.get_HasValue
	|-Nullable<LogPlayerTickOptions>.get_HasValue
	|-Nullable<LogPlayerUseAbilityOptions>.get_HasValue
	|-Nullable<LogPlayerUseWeaponData>.get_HasValue
	|-Nullable<LogPlayerUseWeaponOptions>.get_HasValue
	|-Nullable<LoginCallbackInfo>.get_HasValue
	|-Nullable<LoginCallbackInfo>.get_HasValue
	|-Nullable<LoginOptions>.get_HasValue
	|-Nullable<LoginOptions>.get_HasValue
	|-Nullable<LoginStatusChangedCallbackInfo>.get_HasValue
	|-Nullable<LoginStatusChangedCallbackInfo>.get_HasValue
	|-Nullable<LogoutCallbackInfo>.get_HasValue
	|-Nullable<LogoutCallbackInfo>.get_HasValue
	|-Nullable<LogoutOptions>.get_HasValue
	|-Nullable<LogoutOptions>.get_HasValue
	|-Nullable<MemoryMonitorCallbackInfo>.get_HasValue
	|-Nullable<ModIdentifier>.get_HasValue
	|-Nullable<ModIdentifierInternal>.get_HasValue
	|-Nullable<ModInfo>.get_HasValue
	|-Nullable<ModInfoInternal>.get_HasValue
	|-Nullable<OnAchievementsUnlockedCallbackInfo>.get_HasValue
	|-Nullable<OnAchievementsUnlockedCallbackV2Info>.get_HasValue
	|-Nullable<OnBlockedUsersUpdateInfo>.get_HasValue
	|-Nullable<OnCheckpointCompleteCallbackInfo>.get_HasValue
	|-Nullable<OnClientActionRequiredCallbackInfo>.get_HasValue
	|-Nullable<OnClientAuthStatusChangedCallbackInfo>.get_HasValue
	|-Nullable<OnClientIntegrityViolatedCallbackInfo>.get_HasValue
	|-Nullable<OnCloseCompleteCallbackInfo>.get_HasValue
	|-Nullable<OnCreateCompleteCallbackInfo>.get_HasValue
	|-Nullable<OnCustomInviteAcceptedCallbackInfo>.get_HasValue
	|-Nullable<OnCustomInviteReceivedCallbackInfo>.get_HasValue
	|-Nullable<OnDisplaySettingsUpdatedCallbackInfo>.get_HasValue
	|-Nullable<OnFriendsUpdateInfo>.get_HasValue
	|-Nullable<OnIncomingConnectionRequestInfo>.get_HasValue
	|-Nullable<OnIncomingPacketQueueFullInfo>.get_HasValue
	|-Nullable<OnMessageToClientCallbackInfo>.get_HasValue
	|-Nullable<OnMessageToServerCallbackInfo>.get_HasValue
	|-Nullable<OnOpenCompleteCallbackInfo>.get_HasValue
	|-Nullable<OnPeerConnectionEstablishedInfo>.get_HasValue
	|-Nullable<OnPeerConnectionInterruptedInfo>.get_HasValue
	|-Nullable<OnQueryDefinitionsCompleteCallbackInfo>.get_HasValue
	|-Nullable<OnQueryInputDevicesInformationCallbackInfo>.get_HasValue
	|-Nullable<OnQueryLeaderboardDefinitionsCompleteCallbackInfo>.get_HasValue
	|-Nullable<OnQueryLeaderboardRanksCompleteCallbackInfo>.get_HasValue
	|-Nullable<OnQueryLeaderboardUserScoresCompleteCallbackInfo>.get_HasValue
	|-Nullable<OnQueryNATTypeCompleteInfo>.get_HasValue
	|-Nullable<OnQueryOutputDevicesInformationCallbackInfo>.get_HasValue
	|-Nullable<OnQueryPlayerAchievementsCompleteCallbackInfo>.get_HasValue
	|-Nullable<OnQueryStatsCompleteCallbackInfo>.get_HasValue
	|-Nullable<OnRegisterPlatformUserCallbackInfo>.get_HasValue
	|-Nullable<OnRemoteConnectionClosedInfo>.get_HasValue
	|-Nullable<OnRequestToJoinAcceptedCallbackInfo>.get_HasValue
	|-Nullable<OnRequestToJoinRejectedCallbackInfo>.get_HasValue
	|-Nullable<OnSetInputDeviceSettingsCallbackInfo>.get_HasValue
	|-Nullable<OnSetOutputDeviceSettingsCallbackInfo>.get_HasValue
	|-Nullable<OnShowBlockPlayerCallbackInfo>.get_HasValue
	|-Nullable<OnShowReportPlayerCallbackInfo>.get_HasValue
	|-Nullable<OnUnlockAchievementsCompleteCallbackInfo>.get_HasValue
	|-Nullable<OnUnregisterPlatformUserCallbackInfo>.get_HasValue
	|-Nullable<OpenOptions>.get_HasValue
	|-Nullable<Option>.get_HasValue
	|-Nullable<Options>.get_HasValue
	|-Nullable<Options>.get_HasValue
	|-Nullable<OutputDeviceInformation>.get_HasValue
	|-Nullable<OutputDeviceInformationInternal>.get_HasValue
	|-Nullable<PS4DLCVerifyPurchaseOptions>.get_HasValue
	|-Nullable<PS4DLCVerifyPurchaseOptionsPlatformSpecificOptions>.get_HasValue
	|-Nullable<PS4IAPVerifyPurchaseOptions>.get_HasValue
	|-Nullable<PS4IAPVerifyPurchaseOptionsPlatformSpecificOptions>.get_HasValue
	|-Nullable<PS4InitializeOptions>.get_HasValue
	|-Nullable<PS4InitializeOptionsSystemInitializeOptions>.get_HasValue
	|-Nullable<PS4IntegratedPlatformOptionsContainerAddOptions>.get_HasValue
	|-Nullable<PS4MemoryMonitorCallbackInfo>.get_HasValue
	|-Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReport>.get_HasValue
	|-Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.get_HasValue
	|-Nullable<PS4Options>.get_HasValue
	|-Nullable<PS4OptionsInitOptions>.get_HasValue
	|-Nullable<PS4OptionsInitOptionsInternal>.get_HasValue
	|-Nullable<PS4PrePresentOptions>.get_HasValue
	|-Nullable<PS4PrePresentOptionsPlatformSpecificData>.get_HasValue
	|-Nullable<PS4SubmitGraphicsCommandsCallbackInfo>.get_HasValue
	|-Nullable<PS5DLCVerifyPurchaseOptions>.get_HasValue
	|-Nullable<PS5DLCVerifyPurchaseOptionsPlatformSpecificOptions>.get_HasValue
	|-Nullable<PS5IAPVerifyPurchaseOptions>.get_HasValue
	|-Nullable<PS5IAPVerifyPurchaseOptionsPlatformSpecificOptions>.get_HasValue
	|-Nullable<PS5InitializeOptions>.get_HasValue
	|-Nullable<PS5InitializeOptionsSystemInitializeOptions>.get_HasValue
	|-Nullable<PS5IntegratedPlatformOptionsContainerAddOptions>.get_HasValue
	|-Nullable<PS5MemoryMonitorCallbackInfo>.get_HasValue
	|-Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReport>.get_HasValue
	|-Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.get_HasValue
	|-Nullable<PS5Options>.get_HasValue
	|-Nullable<PS5OptionsInitOptions>.get_HasValue
	|-Nullable<PS5OptionsInitOptionsInternal>.get_HasValue
	|-Nullable<PS5PrePresentOptions>.get_HasValue
	|-Nullable<PS5PrePresentOptionsPlatformSpecificData>.get_HasValue
	|-Nullable<PS5SubmitGraphicsCommandsCallbackInfo>.get_HasValue
	|-Nullable<PacketQueueInfo>.get_HasValue
	|-Nullable<PageQuery>.get_HasValue
	|-Nullable<PageResult>.get_HasValue
	|-Nullable<ParseConnectStringOptions>.get_HasValue
	|-Nullable<ParticipantMetadata>.get_HasValue
	|-Nullable<ParticipantStatusChangedCallbackInfo>.get_HasValue
	|-Nullable<ParticipantUpdatedCallbackInfo>.get_HasValue
	|-Nullable<ParticipantUpdatedCallbackInfo>.get_HasValue
	|-Nullable<PauseSocialOverlayOptions>.get_HasValue
	|-Nullable<PermissionStatus>.get_HasValue
	|-Nullable<PermissionStatusInternal>.get_HasValue
	|-Nullable<PermissionsUpdateReceivedCallbackInfo>.get_HasValue
	|-Nullable<PinGrantInfo>.get_HasValue
	|-Nullable<PinGrantInfoInternal>.get_HasValue
	|-Nullable<PlayerAchievement>.get_HasValue
	|-Nullable<PlayerAchievementInternal>.get_HasValue
	|-Nullable<PlayerSanction>.get_HasValue
	|-Nullable<PlayerSanctionInternal>.get_HasValue
	|-Nullable<PlayerStatInfo>.get_HasValue
	|-Nullable<PollStatusOptions>.get_HasValue
	|-Nullable<PrePresentOptions>.get_HasValue
	|-Nullable<PresenceChangedCallbackInfo>.get_HasValue
	|-Nullable<PresenceModificationDataRecordId>.get_HasValue
	|-Nullable<PresenceModificationDeleteDataOptions>.get_HasValue
	|-Nullable<PresenceModificationSetDataOptions>.get_HasValue
	|-Nullable<PresenceModificationSetJoinInfoOptions>.get_HasValue
	|-Nullable<PresenceModificationSetRawRichTextOptions>.get_HasValue
	|-Nullable<PresenceModificationSetStatusOptions>.get_HasValue
	|-Nullable<PromoteMemberCallbackInfo>.get_HasValue
	|-Nullable<PromoteMemberOptions>.get_HasValue
	|-Nullable<ProtectMessageOptions>.get_HasValue
	|-Nullable<ProtectMessageOptions>.get_HasValue
	|-Nullable<Quat>.get_HasValue
	|-Nullable<QuatInternal>.get_HasValue
	|-Nullable<QueryActivePlayerSanctionsCallbackInfo>.get_HasValue
	|-Nullable<QueryActivePlayerSanctionsOptions>.get_HasValue
	|-Nullable<QueryAgeGateCallbackInfo>.get_HasValue
	|-Nullable<QueryAgeGateOptions>.get_HasValue
	|-Nullable<QueryDefinitionsOptions>.get_HasValue
	|-Nullable<QueryEntitlementTokenCallbackInfo>.get_HasValue
	|-Nullable<QueryEntitlementTokenOptions>.get_HasValue
	|-Nullable<QueryEntitlementsCallbackInfo>.get_HasValue
	|-Nullable<QueryEntitlementsOptions>.get_HasValue
	|-Nullable<QueryExternalAccountMappingsCallbackInfo>.get_HasValue
	|-Nullable<QueryExternalAccountMappingsOptions>.get_HasValue
	|-Nullable<QueryFileCallbackInfo>.get_HasValue
	|-Nullable<QueryFileCallbackInfo>.get_HasValue
	|-Nullable<QueryFileListCallbackInfo>.get_HasValue
	|-Nullable<QueryFileListCallbackInfo>.get_HasValue
	|-Nullable<QueryFileListOptions>.get_HasValue
	|-Nullable<QueryFileListOptions>.get_HasValue
	|-Nullable<QueryFileOptions>.get_HasValue
	|-Nullable<QueryFileOptions>.get_HasValue
	|-Nullable<QueryFriendsCallbackInfo>.get_HasValue
	|-Nullable<QueryFriendsOptions>.get_HasValue
	|-Nullable<QueryIdTokenCallbackInfo>.get_HasValue
	|-Nullable<QueryIdTokenOptions>.get_HasValue
	|-Nullable<QueryInputDevicesInformationOptions>.get_HasValue
	|-Nullable<QueryInvitesCallbackInfo>.get_HasValue
	|-Nullable<QueryInvitesCallbackInfo>.get_HasValue
	|-Nullable<QueryInvitesOptions>.get_HasValue
	|-Nullable<QueryInvitesOptions>.get_HasValue
	|-Nullable<QueryJoinRoomTokenCompleteCallbackInfo>.get_HasValue
	|-Nullable<QueryJoinRoomTokenOptions>.get_HasValue
	|-Nullable<QueryLeaderboardDefinitionsOptions>.get_HasValue
	|-Nullable<QueryLeaderboardRanksOptions>.get_HasValue
	|-Nullable<QueryLeaderboardUserScoresOptions>.get_HasValue
	|-Nullable<QueryNATTypeOptions>.get_HasValue
	|-Nullable<QueryOffersCallbackInfo>.get_HasValue
	|-Nullable<QueryOffersOptions>.get_HasValue
	|-Nullable<QueryOutputDevicesInformationOptions>.get_HasValue
	|-Nullable<QueryOwnershipBySandboxIdsCallbackInfo>.get_HasValue
	|-Nullable<QueryOwnershipBySandboxIdsOptions>.get_HasValue
	|-Nullable<QueryOwnershipCallbackInfo>.get_HasValue
	|-Nullable<QueryOwnershipOptions>.get_HasValue
	|-Nullable<QueryOwnershipTokenCallbackInfo>.get_HasValue
	|-Nullable<QueryOwnershipTokenOptions>.get_HasValue
	|-Nullable<QueryPermissionsCallbackInfo>.get_HasValue
	|-Nullable<QueryPermissionsOptions>.get_HasValue
	|-Nullable<QueryPlayerAchievementsOptions>.get_HasValue
	|-Nullable<QueryPresenceCallbackInfo>.get_HasValue
	|-Nullable<QueryPresenceOptions>.get_HasValue
	|-Nullable<QueryProductUserIdMappingsCallbackInfo>.get_HasValue
	|-Nullable<QueryProductUserIdMappingsOptions>.get_HasValue
	|-Nullable<QueryStatsOptions>.get_HasValue
	|-Nullable<QueryUserInfoByDisplayNameCallbackInfo>.get_HasValue
	|-Nullable<QueryUserInfoByDisplayNameOptions>.get_HasValue
	|-Nullable<QueryUserInfoByExternalAccountCallbackInfo>.get_HasValue
	|-Nullable<QueryUserInfoByExternalAccountOptions>.get_HasValue
	|-Nullable<QueryUserInfoCallbackInfo>.get_HasValue
	|-Nullable<QueryUserInfoOptions>.get_HasValue
	|-Nullable<RTCOptions>.get_HasValue
	|-Nullable<RTCRoomConnectionChangedCallbackInfo>.get_HasValue
	|-Nullable<ReadFileCallbackInfo>.get_HasValue
	|-Nullable<ReadFileCallbackInfo>.get_HasValue
	|-Nullable<ReadFileDataCallbackInfo>.get_HasValue
	|-Nullable<ReadFileDataCallbackInfo>.get_HasValue
	|-Nullable<ReadFileOptions>.get_HasValue
	|-Nullable<ReadFileOptions>.get_HasValue
	|-Nullable<ReceiveMessageFromClientOptions>.get_HasValue
	|-Nullable<ReceiveMessageFromPeerOptions>.get_HasValue
	|-Nullable<ReceiveMessageFromServerOptions>.get_HasValue
	|-Nullable<Rect>.get_HasValue
	|-Nullable<RectInternal>.get_HasValue
	|-Nullable<RedeemEntitlementsCallbackInfo>.get_HasValue
	|-Nullable<RedeemEntitlementsOptions>.get_HasValue
	|-Nullable<RegexPrefix>.get_HasValue
	|-Nullable<RegisterClientOptions>.get_HasValue
	|-Nullable<RegisterEventOptions>.get_HasValue
	|-Nullable<RegisterEventParamDef>.get_HasValue
	|-Nullable<RegisterPeerOptions>.get_HasValue
	|-Nullable<RegisterPlatformAudioUserOptions>.get_HasValue
	|-Nullable<RegisterPlatformUserOptions>.get_HasValue
	|-Nullable<RegisterPlayersCallbackInfo>.get_HasValue
	|-Nullable<RegisterPlayersOptions>.get_HasValue
	|-Nullable<RejectInviteCallbackInfo>.get_HasValue
	|-Nullable<RejectInviteCallbackInfo>.get_HasValue
	|-Nullable<RejectInviteCallbackInfo>.get_HasValue
	|-Nullable<RejectInviteOptions>.get_HasValue
	|-Nullable<RejectInviteOptions>.get_HasValue
	|-Nullable<RejectInviteOptions>.get_HasValue
	|-Nullable<RejectRequestToJoinCallbackInfo>.get_HasValue
	|-Nullable<RejectRequestToJoinOptions>.get_HasValue
	|-Nullable<ReportInputStateOptions>.get_HasValue
	|-Nullable<RequestPermissionsCallbackInfo>.get_HasValue
	|-Nullable<RequestPermissionsOptions>.get_HasValue
	|-Nullable<RequestToJoinReceivedCallbackInfo>.get_HasValue
	|-Nullable<RequestToJoinResponseReceivedCallbackInfo>.get_HasValue
	|-Nullable<RoomStatisticsUpdatedInfo>.get_HasValue
	|-Nullable<sbyte>.get_HasValue
	|-Nullable<SandboxIdItemOwnership>.get_HasValue
	|-Nullable<SendAudioOptions>.get_HasValue
	|-Nullable<SendCustomInviteCallbackInfo>.get_HasValue
	|-Nullable<SendCustomInviteOptions>.get_HasValue
	|-Nullable<SendCustomNativeInviteRequestedCallbackInfo>.get_HasValue
	|-Nullable<SendDataOptions>.get_HasValue
	|-Nullable<SendInviteCallbackInfo>.get_HasValue
	|-Nullable<SendInviteCallbackInfo>.get_HasValue
	|-Nullable<SendInviteCallbackInfo>.get_HasValue
	|-Nullable<SendInviteOptions>.get_HasValue
	|-Nullable<SendInviteOptions>.get_HasValue
	|-Nullable<SendInviteOptions>.get_HasValue
	|-Nullable<SendLobbyNativeInviteRequestedCallbackInfo>.get_HasValue
	|-Nullable<SendPacketOptions>.get_HasValue
	|-Nullable<SendPlayerBehaviorReportCompleteCallbackInfo>.get_HasValue
	|-Nullable<SendPlayerBehaviorReportOptions>.get_HasValue
	|-Nullable<SendRequestToJoinCallbackInfo>.get_HasValue
	|-Nullable<SendRequestToJoinOptions>.get_HasValue
	|-Nullable<SendSessionNativeInviteRequestedCallbackInfo>.get_HasValue
	|-Nullable<SentryId>.get_HasValue
	|-Nullable<SequencePoint>.get_HasValue
	|-Nullable<SessionDetailsAttribute>.get_HasValue
	|-Nullable<SessionDetailsAttributeInternal>.get_HasValue
	|-Nullable<SessionDetailsCopyInfoOptions>.get_HasValue
	|-Nullable<SessionDetailsCopySessionAttributeByIndexOptions>.get_HasValue
	|-Nullable<SessionDetailsCopySessionAttributeByKeyOptions>.get_HasValue
	|-Nullable<SessionDetailsGetSessionAttributeCountOptions>.get_HasValue
	|-Nullable<SessionDetailsInfo>.get_HasValue
	|-Nullable<SessionDetailsInfoInternal>.get_HasValue
	|-Nullable<SessionDetailsSettings>.get_HasValue
	|-Nullable<SessionDetailsSettingsInternal>.get_HasValue
	|-Nullable<SessionInviteAcceptedCallbackInfo>.get_HasValue
	|-Nullable<SessionInviteReceivedCallbackInfo>.get_HasValue
	|-Nullable<SessionInviteRejectedCallbackInfo>.get_HasValue
	|-Nullable<SessionModificationAddAttributeOptions>.get_HasValue
	|-Nullable<SessionModificationRemoveAttributeOptions>.get_HasValue
	|-Nullable<SessionModificationSetAllowedPlatformIdsOptions>.get_HasValue
	|-Nullable<SessionModificationSetBucketIdOptions>.get_HasValue
	|-Nullable<SessionModificationSetHostAddressOptions>.get_HasValue
	|-Nullable<SessionModificationSetInvitesAllowedOptions>.get_HasValue
	|-Nullable<SessionModificationSetJoinInProgressAllowedOptions>.get_HasValue
	|-Nullable<SessionModificationSetMaxPlayersOptions>.get_HasValue
	|-Nullable<SessionModificationSetPermissionLevelOptions>.get_HasValue
	|-Nullable<SessionSearchCopySearchResultByIndexOptions>.get_HasValue
	|-Nullable<SessionSearchFindCallbackInfo>.get_HasValue
	|-Nullable<SessionSearchFindOptions>.get_HasValue
	|-Nullable<SessionSearchGetSearchResultCountOptions>.get_HasValue
	|-Nullable<SessionSearchRemoveParameterOptions>.get_HasValue
	|-Nullable<SessionSearchSetMaxResultsOptions>.get_HasValue
	|-Nullable<SessionSearchSetParameterOptions>.get_HasValue
	|-Nullable<SessionSearchSetSessionIdOptions>.get_HasValue
	|-Nullable<SessionSearchSetTargetUserIdOptions>.get_HasValue
	|-Nullable<SetAudioInputSettingsOptions>.get_HasValue
	|-Nullable<SetAudioOutputSettingsOptions>.get_HasValue
	|-Nullable<SetClientDetailsOptions>.get_HasValue
	|-Nullable<SetClientNetworkStateOptions>.get_HasValue
	|-Nullable<SetCustomInviteOptions>.get_HasValue
	|-Nullable<SetDisplayPreferenceOptions>.get_HasValue
	|-Nullable<SetGameSessionIdOptions>.get_HasValue
	|-Nullable<SetInputDeviceSettingsOptions>.get_HasValue
	|-Nullable<SetOutputDeviceSettingsOptions>.get_HasValue
	|-Nullable<SetPacketQueueSizeOptions>.get_HasValue
	|-Nullable<SetParticipantHardMuteCompleteCallbackInfo>.get_HasValue
	|-Nullable<SetParticipantHardMuteOptions>.get_HasValue
	|-Nullable<SetPortRangeOptions>.get_HasValue
	|-Nullable<SetPresenceCallbackInfo>.get_HasValue
	|-Nullable<SetPresenceOptions>.get_HasValue
	|-Nullable<SetRelayControlOptions>.get_HasValue
	|-Nullable<SetRoomSettingOptions>.get_HasValue
	|-Nullable<SetSettingOptions>.get_HasValue
	|-Nullable<SetToggleFriendsButtonOptions>.get_HasValue
	|-Nullable<SetToggleFriendsKeyOptions>.get_HasValue
	|-Nullable<SetUserLoginStatusOptions>.get_HasValue
	|-Nullable<SetUserPreLogoutCallbackOptions>.get_HasValue
	|-Nullable<ShowBlockPlayerOptions>.get_HasValue
	|-Nullable<ShowFriendsCallbackInfo>.get_HasValue
	|-Nullable<ShowFriendsOptions>.get_HasValue
	|-Nullable<ShowNativeProfileCallbackInfo>.get_HasValue
	|-Nullable<ShowNativeProfileOptions>.get_HasValue
	|-Nullable<ShowReportPlayerOptions>.get_HasValue
	|-Nullable<float>.get_HasValue
	|-Nullable<SocketId>.get_HasValue
	|-Nullable<SocketIdInternal>.get_HasValue
	|-Nullable<SpanId>.get_HasValue
	|-Nullable<SqlBinary>.get_HasValue
	|-Nullable<StartSessionCallbackInfo>.get_HasValue
	|-Nullable<StartSessionOptions>.get_HasValue
	|-Nullable<Stat>.get_HasValue
	|-Nullable<StatInternal>.get_HasValue
	|-Nullable<StatThresholds>.get_HasValue
	|-Nullable<SteamDLCVerifyPurchaseOptions>.get_HasValue
	|-Nullable<SteamDLCVerifyPurchaseOptionsPlatformSpecificOptions>.get_HasValue
	|-Nullable<SteamIAPVerifyPurchaseOptions>.get_HasValue
	|-Nullable<SteamIAPVerifyPurchaseOptionsPlatformSpecificOptions>.get_HasValue
	|-Nullable<SteamOptions>.get_HasValue
	|-Nullable<StreamingContext>.get_HasValue
	|-Nullable<SubmitSnapshotCallbackInfo>.get_HasValue
	|-Nullable<SubmitSnapshotOptions>.get_HasValue
	|-Nullable<SwitchIAPVerifyPurchaseOptions>.get_HasValue
	|-Nullable<SwitchIAPVerifyPurchaseOptionsPlatformSpecificOptions>.get_HasValue
	|-Nullable<TimeSpan>.get_HasValue
	|-Nullable<Token>.get_HasValue
	|-Nullable<Token>.get_HasValue
	|-Nullable<TokenInternal>.get_HasValue
	|-Nullable<Touch>.get_HasValue
	|-Nullable<TransactionCopyEntitlementByIndexOptions>.get_HasValue
	|-Nullable<TransactionGetEntitlementsCountOptions>.get_HasValue
	|-Nullable<TransferDeviceIdAccountCallbackInfo>.get_HasValue
	|-Nullable<TransferDeviceIdAccountOptions>.get_HasValue
	|-Nullable<ushort>.get_HasValue
	|-Nullable<UInt16Enum>.get_HasValue
	|-Nullable<uint>.get_HasValue
	|-Nullable<ulong>.get_HasValue
	|-Nullable<UIntPtr>.get_HasValue
	|-Nullable<UninstallModCallbackInfo>.get_HasValue
	|-Nullable<UninstallModOptions>.get_HasValue
	|-Nullable<UnlinkAccountCallbackInfo>.get_HasValue
	|-Nullable<UnlinkAccountOptions>.get_HasValue
	|-Nullable<UnlockAchievementsOptions>.get_HasValue
	|-Nullable<UnlockedAchievement>.get_HasValue
	|-Nullable<UnlockedAchievementInternal>.get_HasValue
	|-Nullable<UnprotectMessageOptions>.get_HasValue
	|-Nullable<UnprotectMessageOptions>.get_HasValue
	|-Nullable<UnregisterClientOptions>.get_HasValue
	|-Nullable<UnregisterPeerOptions>.get_HasValue
	|-Nullable<UnregisterPlatformAudioUserOptions>.get_HasValue
	|-Nullable<UnregisterPlatformUserOptions>.get_HasValue
	|-Nullable<UnregisterPlayersCallbackInfo>.get_HasValue
	|-Nullable<UnregisterPlayersOptions>.get_HasValue
	|-Nullable<UpdateLobbyCallbackInfo>.get_HasValue
	|-Nullable<UpdateLobbyModificationOptions>.get_HasValue
	|-Nullable<UpdateLobbyOptions>.get_HasValue
	|-Nullable<UpdateModCallbackInfo>.get_HasValue
	|-Nullable<UpdateModOptions>.get_HasValue
	|-Nullable<UpdateParentEmailCallbackInfo>.get_HasValue
	|-Nullable<UpdateParentEmailOptions>.get_HasValue
	|-Nullable<UpdateParticipantVolumeCallbackInfo>.get_HasValue
	|-Nullable<UpdateParticipantVolumeOptions>.get_HasValue
	|-Nullable<UpdateReceivingCallbackInfo>.get_HasValue
	|-Nullable<UpdateReceivingCallbackInfo>.get_HasValue
	|-Nullable<UpdateReceivingOptions>.get_HasValue
	|-Nullable<UpdateReceivingOptions>.get_HasValue
	|-Nullable<UpdateReceivingVolumeCallbackInfo>.get_HasValue
	|-Nullable<UpdateReceivingVolumeOptions>.get_HasValue
	|-Nullable<UpdateSendingCallbackInfo>.get_HasValue
	|-Nullable<UpdateSendingCallbackInfo>.get_HasValue
	|-Nullable<UpdateSendingOptions>.get_HasValue
	|-Nullable<UpdateSendingOptions>.get_HasValue
	|-Nullable<UpdateSendingVolumeCallbackInfo>.get_HasValue
	|-Nullable<UpdateSendingVolumeOptions>.get_HasValue
	|-Nullable<UpdateSessionCallbackInfo>.get_HasValue
	|-Nullable<UpdateSessionModificationOptions>.get_HasValue
	|-Nullable<UpdateSessionOptions>.get_HasValue
	|-Nullable<UserInfoData>.get_HasValue
	|-Nullable<UserInfoDataInternal>.get_HasValue
	|-Nullable<UserLoginInfo>.get_HasValue
	|-Nullable<UserLoginStatusChangedCallbackInfo>.get_HasValue
	|-Nullable<UserPreLogoutCallbackInfo>.get_HasValue
	|-Nullable<UserScoresQueryStatInfo>.get_HasValue
	|-Nullable<UserToken>.get_HasValue
	|-Nullable<UserTokenInternal>.get_HasValue
	|-Nullable<Vec3f>.get_HasValue
	|-Nullable<Vec3fInternal>.get_HasValue
	|-Nullable<Vector2>.get_HasValue
	|-Nullable<Vector3>.get_HasValue
	|-Nullable<VerifyIdTokenCallbackInfo>.get_HasValue
	|-Nullable<VerifyIdTokenCallbackInfo>.get_HasValue
	|-Nullable<VerifyIdTokenOptions>.get_HasValue
	|-Nullable<VerifyIdTokenOptions>.get_HasValue
	|-Nullable<VerifyPurchaseCompleteCallbackInfo>.get_HasValue
	|-Nullable<VerifyPurchaseOptions>.get_HasValue
	|-Nullable<VerifyUserAuthCallbackInfo>.get_HasValue
	|-Nullable<VerifyUserAuthOptions>.get_HasValue
	|-Nullable<WindowsOptions>.get_HasValue
	|-Nullable<WindowsRTCOptions>.get_HasValue
	|-Nullable<WindowsRTCOptionsPlatformSpecificOptions>.get_HasValue
	|-Nullable<WindowsRTCOptionsPlatformSpecificOptionsInternal>.get_HasValue
	|-Nullable<WriteFileCallbackInfo>.get_HasValue
	|-Nullable<WriteFileDataCallbackInfo>.get_HasValue
	|-Nullable<WriteFileOptions>.get_HasValue
	|-Nullable<XSXDLCVerifyPurchaseOptions>.get_HasValue
	|-Nullable<XSXDLCVerifyPurchaseOptionsPlatformSpecificOptions>.get_HasValue
	|-Nullable<XSXIAPVerifyPurchaseOptions>.get_HasValue
	|-Nullable<XSXIAPVerifyPurchaseOptionsPlatformSpecificOptions>.get_HasValue
	|-Nullable<XSXInitializeOptions>.get_HasValue
	|-Nullable<XSXInitializeOptionsSystemInitializeOptions>.get_HasValue
	|-Nullable<XSXIntegratedPlatformOptionsContainerAddOptions>.get_HasValue
	|-Nullable<XSXMemoryMonitorCallbackInfo>.get_HasValue
	|-Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReport>.get_HasValue
	|-Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.get_HasValue
	|-Nullable<XSXOptions>.get_HasValue
	|-Nullable<XSXOptionsSystemSpecificOptions>.get_HasValue
	|-Nullable<XSXPrePresentAdditionalData>.get_HasValue
	|-Nullable<XSXPrePresentAdditionalDataInternal>.get_HasValue
	|-Nullable<XSXPrePresentOptions>.get_HasValue
	|-Nullable<XSXPrePresentOptionsPlatformSpecificData>.get_HasValue
	|-Nullable<XSXSubmitGraphicsCommandsCallbackInfo>.get_HasValue
	|-Nullable<XSXSubmitGraphicsCommandsDataCommand>.get_HasValue
	|-Nullable<XSXXBLOptions>.get_HasValue
	|-Nullable<XSXXBLOptionsInitOptions>.get_HasValue
	|-Nullable<XSXXBLOptionsInitOptionsInternal>.get_HasValue
	|-Nullable<XboxOneGDKDLCVerifyPurchaseOptions>.get_HasValue
	|-Nullable<XboxOneGDKDLCVerifyPurchaseOptionsPlatformSpecificOptions>.get_HasValue
	|-Nullable<XboxOneGDKIAPVerifyPurchaseOptions>.get_HasValue
	|-Nullable<XboxOneGDKIAPVerifyPurchaseOptionsPlatformSpecificOptions>.get_HasValue
	|-Nullable<XboxOneGDKInitializeOptions>.get_HasValue
	|-Nullable<XboxOneGDKInitializeOptionsSystemInitializeOptions>.get_HasValue
	|-Nullable<XboxOneGDKIntegratedPlatformOptionsContainerAddOptions>.get_HasValue
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfo>.get_HasValue
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReport>.get_HasValue
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.get_HasValue
	|-Nullable<XboxOneGDKOptions>.get_HasValue
	|-Nullable<XboxOneGDKOptionsSystemSpecificOptions>.get_HasValue
	|-Nullable<XboxOneGDKPrePresentAdditionalData>.get_HasValue
	|-Nullable<XboxOneGDKPrePresentAdditionalDataInternal>.get_HasValue
	|-Nullable<XboxOneGDKPrePresentOptions>.get_HasValue
	|-Nullable<XboxOneGDKPrePresentOptionsPlatformSpecificData>.get_HasValue
	|-Nullable<XboxOneGDKSubmitGraphicsCommandsCallbackInfo>.get_HasValue
	|-Nullable<XboxOneGDKSubmitGraphicsCommandsDataCommand>.get_HasValue
	|-Nullable<XboxOneGDKXBLOptions>.get_HasValue
	|-Nullable<XboxOneGDKXBLOptionsInitOptions>.get_HasValue
	|-Nullable<XboxOneGDKXBLOptionsInitOptionsInternal>.get_HasValue
	|-Nullable<C.sentry_value_t>.get_HasValue
	|
	|-RVA: 0xB54B30 Offset: 0xB53D30 VA: 0x180B54B30
	|-Nullable<__Il2CppFullySharedGenericStructType>.get_HasValue
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB54BF0 Offset: 0xB53DF0 VA: 0x180B54BF0
	|-Nullable<ArraySegment<byte>>.get_Value
	|-Nullable<ValueTuple<object, object>>.get_Value
	|-Nullable<AcceptInviteOptions>.get_Value
	|-Nullable<AcceptRequestToJoinOptions>.get_Value
	|-Nullable<AccountFeatureRestrictedInfoInternal>.get_Value
	|-Nullable<AcknowledgeEventIdOptions>.get_Value
	|-Nullable<AddNotifyAudioBeforeSendOptions>.get_Value
	|-Nullable<AddNotifyAudioInputStateOptions>.get_Value
	|-Nullable<AddNotifyAudioOutputStateOptions>.get_Value
	|-Nullable<AddNotifyDataReceivedOptions>.get_Value
	|-Nullable<AddNotifyDisconnectedOptions>.get_Value
	|-Nullable<AddNotifyParticipantStatusChangedOptions>.get_Value
	|-Nullable<AddNotifyParticipantUpdatedOptions>.get_Value
	|-Nullable<AddNotifyParticipantUpdatedOptions>.get_Value
	|-Nullable<AddNotifyRTCRoomConnectionChangedOptions>.get_Value
	|-Nullable<AddNotifyRoomStatisticsUpdatedOptions>.get_Value
	|-Nullable<AndroidIAPVerifyPurchaseOptionsPlatformSpecificOptions>.get_Value
	|-Nullable<AudioBuffer>.get_Value
	|-Nullable<AuthExpirationCallbackInfo>.get_Value
	|-Nullable<BeginSessionOptions>.get_Value
	|-Nullable<BigInteger>.get_Value
	|-Nullable<ClientCredentials>.get_Value
	|-Nullable<CopyBestDisplayNameOptions>.get_Value
	|-Nullable<CopyEntitlementByIdOptions>.get_Value
	|-Nullable<CopyEntitlementByIndexOptions>.get_Value
	|-Nullable<CopyFileMetadataAtIndexOptions>.get_Value
	|-Nullable<CopyFileMetadataAtIndexOptions>.get_Value
	|-Nullable<CopyFileMetadataByFilenameOptions>.get_Value
	|-Nullable<CopyFileMetadataByFilenameOptions>.get_Value
	|-Nullable<CopyItemByIdOptions>.get_Value
	|-Nullable<CopyLastRedeemedEntitlementByIndexOptions>.get_Value
	|-Nullable<CopyLeaderboardUserScoreByIndexOptions>.get_Value
	|-Nullable<CopyLeaderboardUserScoreByUserIdOptions>.get_Value
	|-Nullable<CopyLobbyDetailsHandleOptions>.get_Value
	|-Nullable<CopyModInfoOptions>.get_Value
	|-Nullable<CopyOfferByIdOptions>.get_Value
	|-Nullable<CopyOfferByIndexOptions>.get_Value
	|-Nullable<CopyPermissionByIndexOptions>.get_Value
	|-Nullable<CopyPlayerSanctionByIndexOptions>.get_Value
	|-Nullable<CopyPresenceOptions>.get_Value
	|-Nullable<CopyProductUserExternalAccountByAccountIdOptions>.get_Value
	|-Nullable<CopyProductUserExternalAccountByAccountTypeOptions>.get_Value
	|-Nullable<CopyProductUserExternalAccountByIndexOptions>.get_Value
	|-Nullable<CopyStatByIndexOptions>.get_Value
	|-Nullable<CopyStatByNameOptions>.get_Value
	|-Nullable<CopyTransactionByIdOptions>.get_Value
	|-Nullable<CopyTransactionByIndexOptions>.get_Value
	|-Nullable<CopyUnlockedAchievementByAchievementIdOptions>.get_Value
	|-Nullable<CopyUnlockedAchievementByIndexOptions>.get_Value
	|-Nullable<CopyUserInfoOptions>.get_Value
	|-Nullable<CopyUserTokenByUserIdOptions>.get_Value
	|-Nullable<CreateDeviceIdCallbackInfo>.get_Value
	|-Nullable<Credentials>.get_Value
	|-Nullable<DataRecord>.get_Value
	|-Nullable<DateTimeOffset>.get_Value
	|-Nullable<Decimal>.get_Value
	|-Nullable<DeleteDeviceIdCallbackInfo>.get_Value
	|-Nullable<DeleteFileOptions>.get_Value
	|-Nullable<DeletePersistentAuthCallbackInfo>.get_Value
	|-Nullable<DestroyLobbyOptions>.get_Value
	|-Nullable<DestroySessionCallbackInfo>.get_Value
	|-Nullable<EGSDLCVerifyPurchaseOptionsPlatformSpecificOptions>.get_Value
	|-Nullable<EGSIAPVerifyPurchaseOptionsPlatformSpecificOptions>.get_Value
	|-Nullable<EndSessionCallbackInfo>.get_Value
	|-Nullable<EnumerateModsOptions>.get_Value
	|-Nullable<GetBlockedUserAtIndexOptions>.get_Value
	|-Nullable<GetConnectStringOptions>.get_Value
	|-Nullable<GetEntitlementsByNameCountOptions>.get_Value
	|-Nullable<GetExternalUserInfoCountOptions>.get_Value
	|-Nullable<GetFriendAtIndexOptions>.get_Value
	|-Nullable<GetInviteIdByIndexOptions>.get_Value
	|-Nullable<GetInviteIdByIndexOptions>.get_Value
	|-Nullable<GetItemImageInfoCountOptions>.get_Value
	|-Nullable<GetItemReleaseCountOptions>.get_Value
	|-Nullable<GetJoinInfoOptions>.get_Value
	|-Nullable<GetNextReceivedPacketSizeOptions>.get_Value
	|-Nullable<GetOfferImageInfoCountOptions>.get_Value
	|-Nullable<GetOfferItemCountOptions>.get_Value
	|-Nullable<GetPermissionByKeyOptions>.get_Value
	|-Nullable<GetRTCRoomNameOptions>.get_Value
	|-Nullable<GetStatusOptions>.get_Value
	|-Nullable<HasPresenceOptions>.get_Value
	|-Nullable<IOSIAPVerifyPurchaseOptionsPlatformSpecificOptions>.get_Value
	|-Nullable<IdToken>.get_Value
	|-Nullable<IdToken>.get_Value
	|-Nullable<IngestData>.get_Value
	|-Nullable<IsRTCRoomConnectedOptions>.get_Value
	|-Nullable<IsUserInSessionOptions>.get_Value
	|-Nullable<ItemOwnership>.get_Value
	|-Nullable<JoinSessionCallbackInfo>.get_Value
	|-Nullable<JsonElement>.get_Value
	|-Nullable<KickCompleteCallbackInfo>.get_Value
	|-Nullable<KickOptions>.get_Value
	|-Nullable<LeaderboardUserScore>.get_Value
	|-Nullable<LeaveLobbyOptions>.get_Value
	|-Nullable<LeaveRoomOptions>.get_Value
	|-Nullable<LinkAccountOptions>.get_Value
	|-Nullable<LobbyDetailsCopyMemberAttributeByIndexOptions>.get_Value
	|-Nullable<LobbyDetailsCopyMemberAttributeByKeyOptions>.get_Value
	|-Nullable<LobbyDetailsMemberInfo>.get_Value
	|-Nullable<LobbySearchFindCallbackInfo>.get_Value
	|-Nullable<LobbySearchRemoveParameterOptions>.get_Value
	|-Nullable<LobbyUpdateReceivedCallbackInfo>.get_Value
	|-Nullable<LocalDefinition>.get_Value
	|-Nullable<LogPlayerReviveOptions>.get_Value
	|-Nullable<LogPlayerSpawnOptions>.get_Value
	|-Nullable<MemoryMonitorCallbackInfo>.get_Value
	|-Nullable<ModInfo>.get_Value
	|-Nullable<OnCheckpointCompleteCallbackInfo>.get_Value
	|-Nullable<OnCloseCompleteCallbackInfo>.get_Value
	|-Nullable<OnDisplaySettingsUpdatedCallbackInfo>.get_Value
	|-Nullable<OnQueryDefinitionsCompleteCallbackInfo>.get_Value
	|-Nullable<OnQueryInputDevicesInformationCallbackInfo>.get_Value
	|-Nullable<OnQueryLeaderboardDefinitionsCompleteCallbackInfo>.get_Value
	|-Nullable<OnQueryLeaderboardUserScoresCompleteCallbackInfo>.get_Value
	|-Nullable<OnQueryOutputDevicesInformationCallbackInfo>.get_Value
	|-Nullable<Option>.get_Value
	|-Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReport>.get_Value
	|-Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReport>.get_Value
	|-Nullable<PS5Options>.get_Value
	|-Nullable<ParticipantMetadata>.get_Value
	|-Nullable<PermissionStatus>.get_Value
	|-Nullable<PlayerStatInfo>.get_Value
	|-Nullable<QueryActivePlayerSanctionsOptions>.get_Value
	|-Nullable<QueryEntitlementTokenOptions>.get_Value
	|-Nullable<QueryFileListOptions>.get_Value
	|-Nullable<QueryFileOptions>.get_Value
	|-Nullable<QueryFileOptions>.get_Value
	|-Nullable<QueryIdTokenOptions>.get_Value
	|-Nullable<QueryLeaderboardRanksOptions>.get_Value
	|-Nullable<QueryOffersOptions>.get_Value
	|-Nullable<QueryOwnershipBySandboxIdsOptions>.get_Value
	|-Nullable<QueryPlayerAchievementsOptions>.get_Value
	|-Nullable<QueryPresenceOptions>.get_Value
	|-Nullable<QueryUserInfoByDisplayNameOptions>.get_Value
	|-Nullable<QueryUserInfoOptions>.get_Value
	|-Nullable<RTCOptions>.get_Value
	|-Nullable<ReceiveMessageFromServerOptions>.get_Value
	|-Nullable<RedeemEntitlementsOptions>.get_Value
	|-Nullable<RegexPrefix>.get_Value
	|-Nullable<RegisterEventParamDef>.get_Value
	|-Nullable<RegisterPlayersOptions>.get_Value
	|-Nullable<RejectInviteCallbackInfo>.get_Value
	|-Nullable<RejectInviteOptions>.get_Value
	|-Nullable<RejectInviteOptions>.get_Value
	|-Nullable<RejectInviteOptions>.get_Value
	|-Nullable<RejectRequestToJoinOptions>.get_Value
	|-Nullable<RequestPermissionsOptions>.get_Value
	|-Nullable<SandboxIdItemOwnership>.get_Value
	|-Nullable<SendCustomInviteOptions>.get_Value
	|-Nullable<SendInviteCallbackInfo>.get_Value
	|-Nullable<SendInviteOptions>.get_Value
	|-Nullable<SendPlayerBehaviorReportCompleteCallbackInfo>.get_Value
	|-Nullable<SendRequestToJoinOptions>.get_Value
	|-Nullable<SessionSearchFindCallbackInfo>.get_Value
	|-Nullable<SessionSearchRemoveParameterOptions>.get_Value
	|-Nullable<SetClientDetailsOptions>.get_Value
	|-Nullable<SetClientNetworkStateOptions>.get_Value
	|-Nullable<SetCustomInviteOptions>.get_Value
	|-Nullable<SetOutputDeviceSettingsOptions>.get_Value
	|-Nullable<SetPacketQueueSizeOptions>.get_Value
	|-Nullable<SetParticipantHardMuteCompleteCallbackInfo>.get_Value
	|-Nullable<SetPresenceOptions>.get_Value
	|-Nullable<SetSettingOptions>.get_Value
	|-Nullable<ShowBlockPlayerOptions>.get_Value
	|-Nullable<ShowNativeProfileOptions>.get_Value
	|-Nullable<ShowReportPlayerOptions>.get_Value
	|-Nullable<SocketIdInternal>.get_Value
	|-Nullable<StartSessionCallbackInfo>.get_Value
	|-Nullable<StatThresholds>.get_Value
	|-Nullable<SteamDLCVerifyPurchaseOptionsPlatformSpecificOptions>.get_Value
	|-Nullable<StreamingContext>.get_Value
	|-Nullable<SubmitSnapshotCallbackInfo>.get_Value
	|-Nullable<UnlockAchievementsOptions>.get_Value
	|-Nullable<UnregisterPlayersOptions>.get_Value
	|-Nullable<UpdateLobbyModificationOptions>.get_Value
	|-Nullable<UpdateParentEmailOptions>.get_Value
	|-Nullable<UserLoginInfo>.get_Value
	|-Nullable<UserScoresQueryStatInfo>.get_Value
	|-Nullable<UserToken>.get_Value
	|-Nullable<VerifyPurchaseCompleteCallbackInfo>.get_Value
	|-Nullable<VerifyUserAuthCallbackInfo>.get_Value
	|-Nullable<WindowsRTCOptionsPlatformSpecificOptionsInternal>.get_Value
	|-Nullable<XSXDLCVerifyPurchaseOptionsPlatformSpecificOptions>.get_Value
	|-Nullable<XSXIAPVerifyPurchaseOptionsPlatformSpecificOptions>.get_Value
	|-Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.get_Value
	|-Nullable<XSXSubmitGraphicsCommandsDataCommand>.get_Value
	|-Nullable<XSXXBLOptionsInitOptions>.get_Value
	|-Nullable<XboxOneGDKDLCVerifyPurchaseOptionsPlatformSpecificOptions>.get_Value
	|-Nullable<XboxOneGDKIAPVerifyPurchaseOptionsPlatformSpecificOptions>.get_Value
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.get_Value
	|-Nullable<XboxOneGDKSubmitGraphicsCommandsDataCommand>.get_Value
	|-Nullable<XboxOneGDKXBLOptionsInitOptions>.get_Value
	|
	|-RVA: 0xB54C80 Offset: 0xB53E80 VA: 0x180B54C80
	|-Nullable<AcceptConnectionOptions>.get_Value
	|-Nullable<AttributeDataValue>.get_Value
	|-Nullable<AttributeDataValue>.get_Value
	|-Nullable<AudioBeforeRenderCallbackInfo>.get_Value
	|-Nullable<BeginPlayerSessionOptions>.get_Value
	|-Nullable<ClearPacketQueueOptions>.get_Value
	|-Nullable<CloseConnectionOptions>.get_Value
	|-Nullable<ExternalAccountInfo>.get_Value
	|-Nullable<FileMetadata>.get_Value
	|-Nullable<LobbyDetailsInfo>.get_Value
	|-Nullable<LogPlayerUseWeaponData>.get_Value
	|-Nullable<PS4IntegratedPlatformOptionsContainerAddOptions>.get_Value
	|-Nullable<PS4PrePresentOptions>.get_Value
	|-Nullable<PS5PrePresentOptions>.get_Value
	|-Nullable<ParticipantStatusChangedCallbackInfo>.get_Value
	|-Nullable<QueryLeaderboardDefinitionsOptions>.get_Value
	|-Nullable<QueryPermissionsCallbackInfo>.get_Value
	|-Nullable<SessionDetailsInfoInternal>.get_Value
	|-Nullable<SessionDetailsSettingsInternal>.get_Value
	|-Nullable<UninstallModOptions>.get_Value
	|-Nullable<UpdateModOptions>.get_Value
	|-Nullable<UserInfoDataInternal>.get_Value
	|-Nullable<XSXInitializeOptionsSystemInitializeOptions>.get_Value
	|-Nullable<XSXPrePresentOptionsPlatformSpecificData>.get_Value
	|-Nullable<XboxOneGDKInitializeOptionsSystemInitializeOptions>.get_Value
	|-Nullable<XboxOneGDKPrePresentOptionsPlatformSpecificData>.get_Value
	|
	|-RVA: 0xB55030 Offset: 0xB54230 VA: 0x180B55030
	|-Nullable<AcceptInviteCallbackInfo>.get_Value
	|-Nullable<AcceptRequestToJoinCallbackInfo>.get_Value
	|-Nullable<AttributeDataInternal>.get_Value
	|-Nullable<AttributeDataInternal>.get_Value
	|-Nullable<AudioBufferInternal>.get_Value
	|-Nullable<AudioInputStateCallbackInfo>.get_Value
	|-Nullable<AudioOutputStateCallbackInfo>.get_Value
	|-Nullable<BeginSessionOptions>.get_Value
	|-Nullable<BlockParticipantOptions>.get_Value
	|-Nullable<CheckoutCallbackInfo>.get_Value
	|-Nullable<DisconnectedCallbackInfo>.get_Value
	|-Nullable<EnumerateModsCallbackInfo>.get_Value
	|-Nullable<ExternalUserInfo>.get_Value
	|-Nullable<ExternalUserInfoInternal>.get_Value
	|-Nullable<FileMetadata>.get_Value
	|-Nullable<FileMetadataInternal>.get_Value
	|-Nullable<FileTransferProgressCallbackInfo>.get_Value
	|-Nullable<FileTransferProgressCallbackInfo>.get_Value
	|-Nullable<FinalizeInviteOptions>.get_Value
	|-Nullable<HardMuteMemberCallbackInfo>.get_Value
	|-Nullable<HardMuteMemberOptions>.get_Value
	|-Nullable<IOSCredentialsSystemAuthCredentialsOptionsInternal>.get_Value
	|-Nullable<IngestStatCompleteCallbackInfo>.get_Value
	|-Nullable<IntegratedPlatformOptionsContainerAddOptions>.get_Value
	|-Nullable<JoinSessionOptions>.get_Value
	|-Nullable<KeyImageInfoInternal>.get_Value
	|-Nullable<LeaderboardRecordInternal>.get_Value
	|-Nullable<LeaveRoomCallbackInfo>.get_Value
	|-Nullable<LobbyInviteReceivedCallbackInfo>.get_Value
	|-Nullable<LobbyMemberStatusReceivedCallbackInfo>.get_Value
	|-Nullable<LogGameRoundStartOptions>.get_Value
	|-Nullable<LoginCallbackInfo>.get_Value
	|-Nullable<OnBlockedUsersUpdateInfo>.get_Value
	|-Nullable<OnClientActionRequiredCallbackInfo>.get_Value
	|-Nullable<OnFriendsUpdateInfo>.get_Value
	|-Nullable<OnMessageToClientCallbackInfo>.get_Value
	|-Nullable<OnQueryPlayerAchievementsCompleteCallbackInfo>.get_Value
	|-Nullable<OnQueryStatsCompleteCallbackInfo>.get_Value
	|-Nullable<OnShowBlockPlayerCallbackInfo>.get_Value
	|-Nullable<OnShowReportPlayerCallbackInfo>.get_Value
	|-Nullable<OnUnlockAchievementsCompleteCallbackInfo>.get_Value
	|-Nullable<PS4DLCVerifyPurchaseOptionsPlatformSpecificOptions>.get_Value
	|-Nullable<PS4IAPVerifyPurchaseOptionsPlatformSpecificOptions>.get_Value
	|-Nullable<PS4MemoryMonitorCallbackInfo>.get_Value
	|-Nullable<PS4OptionsInitOptionsInternal>.get_Value
	|-Nullable<PS5DLCVerifyPurchaseOptionsPlatformSpecificOptions>.get_Value
	|-Nullable<PS5IAPVerifyPurchaseOptionsPlatformSpecificOptions>.get_Value
	|-Nullable<PS5MemoryMonitorCallbackInfo>.get_Value
	|-Nullable<PS5SubmitGraphicsCommandsCallbackInfo>.get_Value
	|-Nullable<PinGrantInfo>.get_Value
	|-Nullable<PlayerSanction>.get_Value
	|-Nullable<ProtectMessageOptions>.get_Value
	|-Nullable<QueryActivePlayerSanctionsCallbackInfo>.get_Value
	|-Nullable<QueryAgeGateCallbackInfo>.get_Value
	|-Nullable<QueryEntitlementTokenCallbackInfo>.get_Value
	|-Nullable<QueryFileListCallbackInfo>.get_Value
	|-Nullable<QueryFileListCallbackInfo>.get_Value
	|-Nullable<QueryIdTokenCallbackInfo>.get_Value
	|-Nullable<QueryJoinRoomTokenOptions>.get_Value
	|-Nullable<QueryOwnershipBySandboxIdsCallbackInfo>.get_Value
	|-Nullable<QueryOwnershipCallbackInfo>.get_Value
	|-Nullable<QueryOwnershipTokenCallbackInfo>.get_Value
	|-Nullable<QueryPresenceCallbackInfo>.get_Value
	|-Nullable<QueryUserInfoCallbackInfo>.get_Value
	|-Nullable<RTCRoomConnectionChangedCallbackInfo>.get_Value
	|-Nullable<ReadFileCallbackInfo>.get_Value
	|-Nullable<ReadFileCallbackInfo>.get_Value
	|-Nullable<RedeemEntitlementsCallbackInfo>.get_Value
	|-Nullable<RegisterEventOptions>.get_Value
	|-Nullable<RegisterPlayersCallbackInfo>.get_Value
	|-Nullable<RejectInviteCallbackInfo>.get_Value
	|-Nullable<RejectRequestToJoinCallbackInfo>.get_Value
	|-Nullable<RequestToJoinResponseReceivedCallbackInfo>.get_Value
	|-Nullable<RoomStatisticsUpdatedInfo>.get_Value
	|-Nullable<SendCustomInviteCallbackInfo>.get_Value
	|-Nullable<SendDataOptions>.get_Value
	|-Nullable<SendInviteCallbackInfo>.get_Value
	|-Nullable<SendRequestToJoinCallbackInfo>.get_Value
	|-Nullable<SessionDetailsSettings>.get_Value
	|-Nullable<SessionInviteReceivedCallbackInfo>.get_Value
	|-Nullable<SetRoomSettingOptions>.get_Value
	|-Nullable<ShowNativeProfileCallbackInfo>.get_Value
	|-Nullable<SocketId>.get_Value
	|-Nullable<SteamOptions>.get_Value
	|-Nullable<UnlockedAchievement>.get_Value
	|-Nullable<UnprotectMessageOptions>.get_Value
	|-Nullable<UpdateParticipantVolumeOptions>.get_Value
	|-Nullable<UpdateReceivingOptions>.get_Value
	|-Nullable<UpdateReceivingOptions>.get_Value
	|-Nullable<UpdateSessionCallbackInfo>.get_Value
	|-Nullable<VerifyPurchaseOptions>.get_Value
	|-Nullable<WriteFileCallbackInfo>.get_Value
	|-Nullable<WriteFileDataCallbackInfo>.get_Value
	|
	|-RVA: 0xB54BC0 Offset: 0xB53DC0 VA: 0x180B54BC0
	|-Nullable<AccountFeatureRestrictedInfo>.get_Value
	|-Nullable<AddExternalIntegrityCatalogOptions>.get_Value
	|-Nullable<AudioDevicesChangedCallbackInfo>.get_Value
	|-Nullable<BeginSnapshotOptions>.get_Value
	|-Nullable<CheckoutEntry>.get_Value
	|-Nullable<CopyAchievementDefinitionByAchievementIdOptions>.get_Value
	|-Nullable<CopyAchievementDefinitionV2ByAchievementIdOptions>.get_Value
	|-Nullable<CopyActiveSessionHandleOptions>.get_Value
	|-Nullable<CopyIdTokenOptions>.get_Value
	|-Nullable<CopyIdTokenOptions>.get_Value
	|-Nullable<CopyLeaderboardDefinitionByLeaderboardIdOptions>.get_Value
	|-Nullable<CopyLeaderboardRecordByUserIdOptions>.get_Value
	|-Nullable<CopyLobbyDetailsHandleByInviteIdOptions>.get_Value
	|-Nullable<CopyLobbyDetailsHandleByUiEventIdOptions>.get_Value
	|-Nullable<CopyProductUserInfoOptions>.get_Value
	|-Nullable<CopySessionHandleByInviteIdOptions>.get_Value
	|-Nullable<CopySessionHandleByUiEventIdOptions>.get_Value
	|-Nullable<CopySessionHandleForPresenceOptions>.get_Value
	|-Nullable<CreateDeviceIdOptions>.get_Value
	|-Nullable<CreatePresenceModificationOptions>.get_Value
	|-Nullable<CreateUserOptions>.get_Value
	|-Nullable<DataKey>.get_Value
	|-Nullable<DateTime>.get_Value
	|-Nullable<DeleteCacheOptions>.get_Value
	|-Nullable<DeleteCacheOptions>.get_Value
	|-Nullable<DeletePersistentAuthOptions>.get_Value
	|-Nullable<DeleteSnapshotOptions>.get_Value
	|-Nullable<DestroySessionOptions>.get_Value
	|-Nullable<DumpSessionStateOptions>.get_Value
	|-Nullable<EndSessionOptions>.get_Value
	|-Nullable<EventDispatcherGate>.get_Value
	|-Nullable<GCHandle>.get_Value
	|-Nullable<GetBlockedUsersCountOptions>.get_Value
	|-Nullable<GetEntitlementsCountOptions>.get_Value
	|-Nullable<GetFileMetadataCountOptions>.get_Value
	|-Nullable<GetFileMetadataCountOptions>.get_Value
	|-Nullable<GetFriendsCountOptions>.get_Value
	|-Nullable<GetFriendsExclusiveInputOptions>.get_Value
	|-Nullable<GetFriendsVisibleOptions>.get_Value
	|-Nullable<GetInviteCountOptions>.get_Value
	|-Nullable<GetInviteCountOptions>.get_Value
	|-Nullable<GetLastRedeemedEntitlementsCountOptions>.get_Value
	|-Nullable<GetLeaderboardUserScoreCountOptions>.get_Value
	|-Nullable<GetOfferCountOptions>.get_Value
	|-Nullable<GetPermissionsCountOptions>.get_Value
	|-Nullable<GetPlayerAchievementCountOptions>.get_Value
	|-Nullable<GetPlayerSanctionCountOptions>.get_Value
	|-Nullable<GetProductUserExternalAccountCountOptions>.get_Value
	|-Nullable<GetStatCountOptions>.get_Value
	|-Nullable<GetTransactionCountOptions>.get_Value
	|-Nullable<GetUnlockedAchievementCountOptions>.get_Value
	|-Nullable<HideFriendsOptions>.get_Value
	|-Nullable<long>.get_Value
	|-Nullable<IntPtr>.get_Value
	|-Nullable<InventoryItemCreateSubItemOptions>.get_Value
	|-Nullable<InventoryItemDeleteSubItemOptions>.get_Value
	|-Nullable<InventoryItemGetSubItemOptions>.get_Value
	|-Nullable<InventoryItemSetKeyOptions>.get_Value
	|-Nullable<InventoryItemSetValueAsDoubleOptions>.get_Value
	|-Nullable<InventoryItemSetValueAsDoubleSetOptions>.get_Value
	|-Nullable<InventoryItemSetValueAsInt64Options>.get_Value
	|-Nullable<InventoryItemSetValueAsInt64SetOptions>.get_Value
	|-Nullable<InventoryItemSetValueAsStringOptions>.get_Value
	|-Nullable<InventoryItemSetValueAsStringSetOptions>.get_Value
	|-Nullable<InventoryItemSetValueAsTimestampOptions>.get_Value
	|-Nullable<LobbyDetailsCopyAttributeByKeyOptions>.get_Value
	|-Nullable<LobbyDetailsCopyMemberInfoOptions>.get_Value
	|-Nullable<LobbyDetailsGetMemberAttributeCountOptions>.get_Value
	|-Nullable<LobbyModificationRemoveAttributeOptions>.get_Value
	|-Nullable<LobbyModificationRemoveMemberAttributeOptions>.get_Value
	|-Nullable<LobbyModificationSetAllowedPlatformIdsOptions>.get_Value
	|-Nullable<LobbyModificationSetBucketIdOptions>.get_Value
	|-Nullable<LobbySearchFindOptions>.get_Value
	|-Nullable<LobbySearchSetLobbyIdOptions>.get_Value
	|-Nullable<LobbySearchSetTargetUserIdOptions>.get_Value
	|-Nullable<LogPlayerDespawnOptions>.get_Value
	|-Nullable<LogoutOptions>.get_Value
	|-Nullable<LogoutOptions>.get_Value
	|-Nullable<ParseConnectStringOptions>.get_Value
	|-Nullable<PrePresentOptions>.get_Value
	|-Nullable<PresenceModificationDataRecordId>.get_Value
	|-Nullable<PresenceModificationDeleteDataOptions>.get_Value
	|-Nullable<PresenceModificationSetDataOptions>.get_Value
	|-Nullable<PresenceModificationSetJoinInfoOptions>.get_Value
	|-Nullable<PresenceModificationSetRawRichTextOptions>.get_Value
	|-Nullable<QueryFileListOptions>.get_Value
	|-Nullable<QueryFriendsOptions>.get_Value
	|-Nullable<QueryInvitesOptions>.get_Value
	|-Nullable<QueryInvitesOptions>.get_Value
	|-Nullable<QueryPermissionsOptions>.get_Value
	|-Nullable<RegisterPlatformAudioUserOptions>.get_Value
	|-Nullable<RegisterPlatformUserOptions>.get_Value
	|-Nullable<SessionDetailsCopySessionAttributeByKeyOptions>.get_Value
	|-Nullable<SessionModificationRemoveAttributeOptions>.get_Value
	|-Nullable<SessionModificationSetAllowedPlatformIdsOptions>.get_Value
	|-Nullable<SessionModificationSetBucketIdOptions>.get_Value
	|-Nullable<SessionModificationSetHostAddressOptions>.get_Value
	|-Nullable<SessionSearchFindOptions>.get_Value
	|-Nullable<SessionSearchSetSessionIdOptions>.get_Value
	|-Nullable<SessionSearchSetTargetUserIdOptions>.get_Value
	|-Nullable<SetGameSessionIdOptions>.get_Value
	|-Nullable<ShowFriendsOptions>.get_Value
	|-Nullable<SpanId>.get_Value
	|-Nullable<SqlBinary>.get_Value
	|-Nullable<StartSessionOptions>.get_Value
	|-Nullable<SteamIAPVerifyPurchaseOptionsPlatformSpecificOptions>.get_Value
	|-Nullable<SwitchIAPVerifyPurchaseOptionsPlatformSpecificOptions>.get_Value
	|-Nullable<TimeSpan>.get_Value
	|-Nullable<ulong>.get_Value
	|-Nullable<UIntPtr>.get_Value
	|-Nullable<UnlinkAccountOptions>.get_Value
	|-Nullable<UnregisterClientOptions>.get_Value
	|-Nullable<UnregisterPeerOptions>.get_Value
	|-Nullable<UnregisterPlatformAudioUserOptions>.get_Value
	|-Nullable<UnregisterPlatformUserOptions>.get_Value
	|-Nullable<UpdateLobbyOptions>.get_Value
	|-Nullable<UpdateSessionModificationOptions>.get_Value
	|-Nullable<UpdateSessionOptions>.get_Value
	|-Nullable<WindowsRTCOptionsPlatformSpecificOptions>.get_Value
	|-Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReport>.get_Value
	|-Nullable<XSXOptionsSystemSpecificOptions>.get_Value
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReport>.get_Value
	|-Nullable<XboxOneGDKOptionsSystemSpecificOptions>.get_Value
	|-Nullable<C.sentry_value_t>.get_Value
	|
	|-RVA: 0x149BE70 Offset: 0x149B070 VA: 0x18149BE70
	|-Nullable<ActiveSessionCopyInfoOptions>.get_Value
	|-Nullable<ActiveSessionGetRegisteredPlayerCountOptions>.get_Value
	|-Nullable<AddNotifyAchievementsUnlockedOptions>.get_Value
	|-Nullable<AddNotifyAchievementsUnlockedV2Options>.get_Value
	|-Nullable<AddNotifyAudioDevicesChangedOptions>.get_Value
	|-Nullable<AddNotifyAuthExpirationOptions>.get_Value
	|-Nullable<AddNotifyBlockedUsersUpdateOptions>.get_Value
	|-Nullable<AddNotifyClientActionRequiredOptions>.get_Value
	|-Nullable<AddNotifyClientAuthStatusChangedOptions>.get_Value
	|-Nullable<AddNotifyClientIntegrityViolatedOptions>.get_Value
	|-Nullable<AddNotifyCustomInviteAcceptedOptions>.get_Value
	|-Nullable<AddNotifyCustomInviteReceivedOptions>.get_Value
	|-Nullable<AddNotifyCustomInviteRejectedOptions>.get_Value
	|-Nullable<AddNotifyDisplaySettingsUpdatedOptions>.get_Value
	|-Nullable<AddNotifyFriendsUpdateOptions>.get_Value
	|-Nullable<AddNotifyIncomingPacketQueueFullOptions>.get_Value
	|-Nullable<AddNotifyJoinGameAcceptedOptions>.get_Value
	|-Nullable<AddNotifyJoinLobbyAcceptedOptions>.get_Value
	|-Nullable<AddNotifyJoinSessionAcceptedOptions>.get_Value
	|-Nullable<AddNotifyLeaveLobbyRequestedOptions>.get_Value
	|-Nullable<AddNotifyLeaveSessionRequestedOptions>.get_Value
	|-Nullable<AddNotifyLobbyInviteAcceptedOptions>.get_Value
	|-Nullable<AddNotifyLobbyInviteReceivedOptions>.get_Value
	|-Nullable<AddNotifyLobbyInviteRejectedOptions>.get_Value
	|-Nullable<AddNotifyLobbyMemberStatusReceivedOptions>.get_Value
	|-Nullable<AddNotifyLobbyMemberUpdateReceivedOptions>.get_Value
	|-Nullable<AddNotifyLobbyUpdateReceivedOptions>.get_Value
	|-Nullable<AddNotifyLoginStatusChangedOptions>.get_Value
	|-Nullable<AddNotifyLoginStatusChangedOptions>.get_Value
	|-Nullable<AddNotifyMemoryMonitorOptions>.get_Value
	|-Nullable<AddNotifyMessageToClientOptions>.get_Value
	|-Nullable<AddNotifyMessageToPeerOptions>.get_Value
	|-Nullable<AddNotifyMessageToServerOptions>.get_Value
	|-Nullable<AddNotifyOnPresenceChangedOptions>.get_Value
	|-Nullable<AddNotifyPeerActionRequiredOptions>.get_Value
	|-Nullable<AddNotifyPeerAuthStatusChangedOptions>.get_Value
	|-Nullable<AddNotifyPermissionsUpdateReceivedOptions>.get_Value
	|-Nullable<AddNotifyRequestToJoinAcceptedOptions>.get_Value
	|-Nullable<AddNotifyRequestToJoinReceivedOptions>.get_Value
	|-Nullable<AddNotifyRequestToJoinRejectedOptions>.get_Value
	|-Nullable<AddNotifyRequestToJoinResponseReceivedOptions>.get_Value
	|-Nullable<AddNotifySendCustomNativeInviteRequestedOptions>.get_Value
	|-Nullable<AddNotifySendLobbyNativeInviteRequestedOptions>.get_Value
	|-Nullable<AddNotifySendSessionNativeInviteRequestedOptions>.get_Value
	|-Nullable<AddNotifySessionInviteAcceptedOptions>.get_Value
	|-Nullable<AddNotifySessionInviteReceivedOptions>.get_Value
	|-Nullable<AddNotifySessionInviteRejectedOptions>.get_Value
	|-Nullable<AddNotifyUserLoginStatusChangedOptions>.get_Value
	|-Nullable<bool>.get_Value
	|-Nullable<byte>.get_Value
	|-Nullable<ClearUserPreLogoutCallbackOptions>.get_Value
	|-Nullable<CopyUserAuthTokenOptions>.get_Value
	|-Nullable<CreateIntegratedPlatformOptionsContainerOptions>.get_Value
	|-Nullable<DeleteDeviceIdOptions>.get_Value
	|-Nullable<EndSessionOptions>.get_Value
	|-Nullable<EndSessionOptions>.get_Value
	|-Nullable<GetAchievementDefinitionCountOptions>.get_Value
	|-Nullable<GetAudioInputDevicesCountOptions>.get_Value
	|-Nullable<GetAudioOutputDevicesCountOptions>.get_Value
	|-Nullable<GetDesktopCrossplayStatusOptions>.get_Value
	|-Nullable<GetInputDevicesCountOptions>.get_Value
	|-Nullable<GetLeaderboardDefinitionCountOptions>.get_Value
	|-Nullable<GetLeaderboardRecordCountOptions>.get_Value
	|-Nullable<GetLocalPlatformTypeOptions>.get_Value
	|-Nullable<GetNATTypeOptions>.get_Value
	|-Nullable<GetOutputDevicesCountOptions>.get_Value
	|-Nullable<GetPacketQueueInfoOptions>.get_Value
	|-Nullable<GetPortRangeOptions>.get_Value
	|-Nullable<GetRelayControlOptions>.get_Value
	|-Nullable<GetToggleFriendsButtonOptions>.get_Value
	|-Nullable<GetToggleFriendsKeyOptions>.get_Value
	|-Nullable<InventoryItemGetKeyOptions>.get_Value
	|-Nullable<InventoryItemGetSubItemsCountOptions>.get_Value
	|-Nullable<InventoryItemGetValueAsBoolOptions>.get_Value
	|-Nullable<InventoryItemGetValueAsDoubleOptions>.get_Value
	|-Nullable<InventoryItemGetValueAsInt64Options>.get_Value
	|-Nullable<InventoryItemGetValueAsStringOptions>.get_Value
	|-Nullable<InventoryItemGetValueAsTimestampOptions>.get_Value
	|-Nullable<InventoryItemGetValueCountOptions>.get_Value
	|-Nullable<InventoryItemGetValueTypeOptions>.get_Value
	|-Nullable<InventoryItemSetValueAsBoolOptions>.get_Value
	|-Nullable<IsSocialOverlayPausedOptions>.get_Value
	|-Nullable<LobbyDetailsCopyInfoOptions>.get_Value
	|-Nullable<LobbyDetailsGetAttributeCountOptions>.get_Value
	|-Nullable<LobbyDetailsGetLobbyOwnerOptions>.get_Value
	|-Nullable<LobbyDetailsGetMemberCountOptions>.get_Value
	|-Nullable<LobbyModificationSetInvitesAllowedOptions>.get_Value
	|-Nullable<LobbySearchGetSearchResultCountOptions>.get_Value
	|-Nullable<PS5OptionsInitOptions>.get_Value
	|-Nullable<PauseSocialOverlayOptions>.get_Value
	|-Nullable<QueryAgeGateOptions>.get_Value
	|-Nullable<QueryInputDevicesInformationOptions>.get_Value
	|-Nullable<QueryNATTypeOptions>.get_Value
	|-Nullable<QueryOutputDevicesInformationOptions>.get_Value
	|-Nullable<sbyte>.get_Value
	|-Nullable<SessionDetailsCopyInfoOptions>.get_Value
	|-Nullable<SessionDetailsGetSessionAttributeCountOptions>.get_Value
	|-Nullable<SessionModificationSetInvitesAllowedOptions>.get_Value
	|-Nullable<SessionModificationSetJoinInProgressAllowedOptions>.get_Value
	|-Nullable<SessionSearchGetSearchResultCountOptions>.get_Value
	|-Nullable<SetUserPreLogoutCallbackOptions>.get_Value
	|-Nullable<TransactionGetEntitlementsCountOptions>.get_Value
	|
	|-RVA: 0xB54D20 Offset: 0xB53F20 VA: 0x180B54D20
	|-Nullable<ActiveSessionGetRegisteredPlayerByIndexOptions>.get_Value
	|-Nullable<CopyAchievementDefinitionByIndexOptions>.get_Value
	|-Nullable<CopyAchievementDefinitionV2ByIndexOptions>.get_Value
	|-Nullable<CopyInputDeviceInformationByIndexOptions>.get_Value
	|-Nullable<CopyLeaderboardDefinitionByIndexOptions>.get_Value
	|-Nullable<CopyLeaderboardRecordByIndexOptions>.get_Value
	|-Nullable<CopyOutputDeviceInformationByIndexOptions>.get_Value
	|-Nullable<CreateLobbySearchOptions>.get_Value
	|-Nullable<CreateSessionSearchOptions>.get_Value
	|-Nullable<EndSnapshotOptions>.get_Value
	|-Nullable<GetAudioInputDeviceByIndexOptions>.get_Value
	|-Nullable<GetAudioOutputDeviceByIndexOptions>.get_Value
	|-Nullable<GetProtectMessageOutputLengthOptions>.get_Value
	|-Nullable<GetProtectMessageOutputLengthOptions>.get_Value
	|-Nullable<int>.get_Value
	|-Nullable<Int32Enum>.get_Value
	|-Nullable<InventoryItemGetDoubleSetValueByIndexOptions>.get_Value
	|-Nullable<InventoryItemGetInt64SetValueByIndexOptions>.get_Value
	|-Nullable<InventoryItemGetStringSetValueByIndexOptions>.get_Value
	|-Nullable<InventoryItemGetSubItemByIndexOptions>.get_Value
	|-Nullable<LobbyDetailsCopyAttributeByIndexOptions>.get_Value
	|-Nullable<LobbyDetailsGetMemberByIndexOptions>.get_Value
	|-Nullable<LobbyModificationSetMaxMembersOptions>.get_Value
	|-Nullable<LobbyModificationSetPermissionLevelOptions>.get_Value
	|-Nullable<LobbySearchCopySearchResultByIndexOptions>.get_Value
	|-Nullable<LobbySearchSetMaxResultsOptions>.get_Value
	|-Nullable<LogGameRoundEndOptions>.get_Value
	|-Nullable<PollStatusOptions>.get_Value
	|-Nullable<PresenceModificationSetStatusOptions>.get_Value
	|-Nullable<SessionDetailsCopySessionAttributeByIndexOptions>.get_Value
	|-Nullable<SessionModificationSetMaxPlayersOptions>.get_Value
	|-Nullable<SessionModificationSetPermissionLevelOptions>.get_Value
	|-Nullable<SessionSearchCopySearchResultByIndexOptions>.get_Value
	|-Nullable<SessionSearchSetMaxResultsOptions>.get_Value
	|-Nullable<SetDisplayPreferenceOptions>.get_Value
	|-Nullable<SetRelayControlOptions>.get_Value
	|-Nullable<SetToggleFriendsButtonOptions>.get_Value
	|-Nullable<SetToggleFriendsKeyOptions>.get_Value
	|-Nullable<SubmitSnapshotOptions>.get_Value
	|-Nullable<TransactionCopyEntitlementByIndexOptions>.get_Value
	|-Nullable<uint>.get_Value
	|-Nullable<XSXPrePresentAdditionalData>.get_Value
	|-Nullable<XboxOneGDKPrePresentAdditionalData>.get_Value
	|
	|-RVA: 0x149BF00 Offset: 0x149B100 VA: 0x18149BF00
	|-Nullable<ActiveSessionInfo>.get_Value
	|
	|-RVA: 0xB54CD0 Offset: 0xB53ED0 VA: 0x180B54CD0
	|-Nullable<ActiveSessionInfoInternal>.get_Value
	|-Nullable<BestDisplayName>.get_Value
	|-Nullable<CatalogReleaseInternal>.get_Value
	|-Nullable<CreateUserCallbackInfo>.get_Value
	|-Nullable<Credentials>.get_Value
	|-Nullable<CustomInviteRejectedCallbackInfo>.get_Value
	|-Nullable<Entitlement>.get_Value
	|-Nullable<FileMetadataInternal>.get_Value
	|-Nullable<JoinGameAcceptedCallbackInfo>.get_Value
	|-Nullable<JoinLobbyByIdOptions>.get_Value
	|-Nullable<JoinLobbyOptions>.get_Value
	|-Nullable<JoinRoomCallbackInfo>.get_Value
	|-Nullable<LobbyInviteAcceptedCallbackInfo>.get_Value
	|-Nullable<LobbyInviteRejectedCallbackInfo>.get_Value
	|-Nullable<ModIdentifier>.get_Value
	|-Nullable<OnCustomInviteAcceptedCallbackInfo>.get_Value
	|-Nullable<OnCustomInviteReceivedCallbackInfo>.get_Value
	|-Nullable<OnIncomingPacketQueueFullInfo>.get_Value
	|-Nullable<PS4SubmitGraphicsCommandsCallbackInfo>.get_Value
	|-Nullable<ParticipantUpdatedCallbackInfo>.get_Value
	|-Nullable<ParticipantUpdatedCallbackInfo>.get_Value
	|-Nullable<PinGrantInfoInternal>.get_Value
	|-Nullable<PlayerSanctionInternal>.get_Value
	|-Nullable<QueryJoinRoomTokenCompleteCallbackInfo>.get_Value
	|-Nullable<QueryUserInfoByDisplayNameCallbackInfo>.get_Value
	|-Nullable<ReadFileOptions>.get_Value
	|-Nullable<ReadFileOptions>.get_Value
	|-Nullable<RegisterClientOptions>.get_Value
	|-Nullable<SendAudioOptions>.get_Value
	|-Nullable<SendPlayerBehaviorReportOptions>.get_Value
	|-Nullable<SessionInviteAcceptedCallbackInfo>.get_Value
	|-Nullable<SessionInviteRejectedCallbackInfo>.get_Value
	|-Nullable<StatInternal>.get_Value
	|-Nullable<SteamIAPVerifyPurchaseOptions>.get_Value
	|-Nullable<SwitchIAPVerifyPurchaseOptions>.get_Value
	|-Nullable<UpdateReceivingVolumeCallbackInfo>.get_Value
	|-Nullable<UpdateSendingCallbackInfo>.get_Value
	|-Nullable<UpdateSendingCallbackInfo>.get_Value
	|-Nullable<UpdateSendingVolumeCallbackInfo>.get_Value
	|-Nullable<UserPreLogoutCallbackInfo>.get_Value
	|-Nullable<WriteFileOptions>.get_Value
	|-Nullable<XSXXBLOptions>.get_Value
	|-Nullable<XboxOneGDKXBLOptions>.get_Value
	|
	|-RVA: 0xB54B80 Offset: 0xB53D80 VA: 0x180B54B80
	|-Nullable<AddNotifyAudioBeforeRenderOptions>.get_Value
	|-Nullable<AddProgressionOptions>.get_Value
	|-Nullable<AndroidInitializeOptionsSystemInitializeOptions>.get_Value
	|-Nullable<AttributeInternal>.get_Value
	|-Nullable<AudioInputDeviceInfo>.get_Value
	|-Nullable<AudioInputDeviceInfoInternal>.get_Value
	|-Nullable<AudioOutputDeviceInfo>.get_Value
	|-Nullable<AudioOutputDeviceInfoInternal>.get_Value
	|-Nullable<BeginPlayerSessionOptionsAccountId>.get_Value
	|-Nullable<CatalogRelease>.get_Value
	|-Nullable<CheckoutOptions>.get_Value
	|-Nullable<CheckpointOptions>.get_Value
	|-Nullable<CloseOptions>.get_Value
	|-Nullable<CopyBestDisplayNameWithPlatformOptions>.get_Value
	|-Nullable<CopyEntitlementByNameAndIndexOptions>.get_Value
	|-Nullable<CopyExternalUserInfoByAccountIdOptions>.get_Value
	|-Nullable<CopyExternalUserInfoByAccountTypeOptions>.get_Value
	|-Nullable<CopyExternalUserInfoByIndexOptions>.get_Value
	|-Nullable<CopyItemImageInfoByIndexOptions>.get_Value
	|-Nullable<CopyItemReleaseByIndexOptions>.get_Value
	|-Nullable<CopyOfferImageInfoByIndexOptions>.get_Value
	|-Nullable<CopyOfferItemByIndexOptions>.get_Value
	|-Nullable<CopyPlayerAchievementByAchievementIdOptions>.get_Value
	|-Nullable<CopyPlayerAchievementByIndexOptions>.get_Value
	|-Nullable<CreateLobbyCallbackInfo>.get_Value
	|-Nullable<CreateOptions>.get_Value
	|-Nullable<CreatePlayerSanctionAppealCallbackInfo>.get_Value
	|-Nullable<CreatePlayerSanctionAppealOptions>.get_Value
	|-Nullable<CreateUserCallbackInfo>.get_Value
	|-Nullable<CreateUserOptions>.get_Value
	|-Nullable<DeleteCacheCallbackInfo>.get_Value
	|-Nullable<DeleteCacheCallbackInfo>.get_Value
	|-Nullable<DeleteFileCallbackInfo>.get_Value
	|-Nullable<DeleteSnapshotCallbackInfo>.get_Value
	|-Nullable<DestroyLobbyCallbackInfo>.get_Value
	|-Nullable<DuplicateFileCallbackInfo>.get_Value
	|-Nullable<DuplicateFileOptions>.get_Value
	|-Nullable<EndPlayerSessionOptions>.get_Value
	|-Nullable<EndPlayerSessionOptionsAccountId>.get_Value
	|-Nullable<FinalizeDeferredUserLogoutOptions>.get_Value
	|-Nullable<GetExternalAccountMappingsOptions>.get_Value
	|-Nullable<GetProductUserIdMappingOptions>.get_Value
	|-Nullable<HideFriendsCallbackInfo>.get_Value
	|-Nullable<IOSCredentialsSystemAuthCredentialsOptions>.get_Value
	|-Nullable<IdTokenInternal>.get_Value
	|-Nullable<IdTokenInternal>.get_Value
	|-Nullable<IngestStatOptions>.get_Value
	|-Nullable<InputDeviceInformation>.get_Value
	|-Nullable<InputDeviceInformationInternal>.get_Value
	|-Nullable<JoinLobbyAcceptedCallbackInfo>.get_Value
	|-Nullable<JoinLobbyByIdCallbackInfo>.get_Value
	|-Nullable<JoinLobbyCallbackInfo>.get_Value
	|-Nullable<JoinSessionAcceptedCallbackInfo>.get_Value
	|-Nullable<JsonPosition>.get_Value
	|-Nullable<KeyImageInfo>.get_Value
	|-Nullable<KickMemberCallbackInfo>.get_Value
	|-Nullable<KickMemberOptions>.get_Value
	|-Nullable<LeaderboardRecord>.get_Value
	|-Nullable<LeaderboardUserScoreInternal>.get_Value
	|-Nullable<LeaveLobbyCallbackInfo>.get_Value
	|-Nullable<LeaveLobbyRequestedCallbackInfo>.get_Value
	|-Nullable<LeaveSessionRequestedCallbackInfo>.get_Value
	|-Nullable<LinkAccountCallbackInfo>.get_Value
	|-Nullable<LinkAccountOptions>.get_Value
	|-Nullable<LobbyDetailsMemberInfoInternal>.get_Value
	|-Nullable<LobbyMemberUpdateReceivedCallbackInfo>.get_Value
	|-Nullable<LogEventOptions>.get_Value
	|-Nullable<LogMessage>.get_Value
	|-Nullable<LogPlayerUseAbilityOptions>.get_Value
	|-Nullable<LoginStatusChangedCallbackInfo>.get_Value
	|-Nullable<LoginStatusChangedCallbackInfo>.get_Value
	|-Nullable<LogoutCallbackInfo>.get_Value
	|-Nullable<LogoutCallbackInfo>.get_Value
	|-Nullable<ModInfoInternal>.get_Value
	|-Nullable<OnAchievementsUnlockedCallbackInfo>.get_Value
	|-Nullable<OnClientAuthStatusChangedCallbackInfo>.get_Value
	|-Nullable<OnClientIntegrityViolatedCallbackInfo>.get_Value
	|-Nullable<OnCreateCompleteCallbackInfo>.get_Value
	|-Nullable<OnMessageToServerCallbackInfo>.get_Value
	|-Nullable<OnOpenCompleteCallbackInfo>.get_Value
	|-Nullable<OnQueryLeaderboardRanksCompleteCallbackInfo>.get_Value
	|-Nullable<OnQueryNATTypeCompleteInfo>.get_Value
	|-Nullable<OnRegisterPlatformUserCallbackInfo>.get_Value
	|-Nullable<OnRequestToJoinAcceptedCallbackInfo>.get_Value
	|-Nullable<OnRequestToJoinRejectedCallbackInfo>.get_Value
	|-Nullable<OnSetInputDeviceSettingsCallbackInfo>.get_Value
	|-Nullable<OnSetOutputDeviceSettingsCallbackInfo>.get_Value
	|-Nullable<OnUnregisterPlatformUserCallbackInfo>.get_Value
	|-Nullable<OpenOptions>.get_Value
	|-Nullable<Options>.get_Value
	|-Nullable<OutputDeviceInformation>.get_Value
	|-Nullable<OutputDeviceInformationInternal>.get_Value
	|-Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.get_Value
	|-Nullable<PS4OptionsInitOptions>.get_Value
	|-Nullable<PS5IntegratedPlatformOptionsContainerAddOptions>.get_Value
	|-Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.get_Value
	|-Nullable<PermissionStatusInternal>.get_Value
	|-Nullable<PresenceChangedCallbackInfo>.get_Value
	|-Nullable<PromoteMemberCallbackInfo>.get_Value
	|-Nullable<PromoteMemberOptions>.get_Value
	|-Nullable<ProtectMessageOptions>.get_Value
	|-Nullable<QueryDefinitionsOptions>.get_Value
	|-Nullable<QueryEntitlementsCallbackInfo>.get_Value
	|-Nullable<QueryEntitlementsOptions>.get_Value
	|-Nullable<QueryExternalAccountMappingsCallbackInfo>.get_Value
	|-Nullable<QueryExternalAccountMappingsOptions>.get_Value
	|-Nullable<QueryFileCallbackInfo>.get_Value
	|-Nullable<QueryFileCallbackInfo>.get_Value
	|-Nullable<QueryFriendsCallbackInfo>.get_Value
	|-Nullable<QueryInvitesCallbackInfo>.get_Value
	|-Nullable<QueryInvitesCallbackInfo>.get_Value
	|-Nullable<QueryOffersCallbackInfo>.get_Value
	|-Nullable<QueryOwnershipOptions>.get_Value
	|-Nullable<QueryOwnershipTokenOptions>.get_Value
	|-Nullable<QueryProductUserIdMappingsCallbackInfo>.get_Value
	|-Nullable<QueryProductUserIdMappingsOptions>.get_Value
	|-Nullable<QueryUserInfoByExternalAccountOptions>.get_Value
	|-Nullable<ReceiveMessageFromClientOptions>.get_Value
	|-Nullable<ReceiveMessageFromPeerOptions>.get_Value
	|-Nullable<RejectInviteCallbackInfo>.get_Value
	|-Nullable<RequestPermissionsCallbackInfo>.get_Value
	|-Nullable<RequestToJoinReceivedCallbackInfo>.get_Value
	|-Nullable<SendInviteCallbackInfo>.get_Value
	|-Nullable<SendInviteOptions>.get_Value
	|-Nullable<SendInviteOptions>.get_Value
	|-Nullable<SessionDetailsAttributeInternal>.get_Value
	|-Nullable<SetAudioInputSettingsOptions>.get_Value
	|-Nullable<SetAudioOutputSettingsOptions>.get_Value
	|-Nullable<SetInputDeviceSettingsOptions>.get_Value
	|-Nullable<SetParticipantHardMuteOptions>.get_Value
	|-Nullable<SetPresenceCallbackInfo>.get_Value
	|-Nullable<SetUserLoginStatusOptions>.get_Value
	|-Nullable<ShowFriendsCallbackInfo>.get_Value
	|-Nullable<TransferDeviceIdAccountCallbackInfo>.get_Value
	|-Nullable<TransferDeviceIdAccountOptions>.get_Value
	|-Nullable<UnlinkAccountCallbackInfo>.get_Value
	|-Nullable<UnlockedAchievementInternal>.get_Value
	|-Nullable<UnprotectMessageOptions>.get_Value
	|-Nullable<UnregisterPlayersCallbackInfo>.get_Value
	|-Nullable<UpdateLobbyCallbackInfo>.get_Value
	|-Nullable<UpdateParentEmailCallbackInfo>.get_Value
	|-Nullable<UpdateReceivingVolumeOptions>.get_Value
	|-Nullable<UpdateSendingOptions>.get_Value
	|-Nullable<UpdateSendingOptions>.get_Value
	|-Nullable<UpdateSendingVolumeOptions>.get_Value
	|-Nullable<UserTokenInternal>.get_Value
	|-Nullable<VerifyIdTokenOptions>.get_Value
	|-Nullable<VerifyIdTokenOptions>.get_Value
	|-Nullable<WindowsRTCOptions>.get_Value
	|-Nullable<XSXMemoryMonitorCallbackInfo>.get_Value
	|-Nullable<XSXSubmitGraphicsCommandsCallbackInfo>.get_Value
	|-Nullable<XSXXBLOptionsInitOptionsInternal>.get_Value
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfo>.get_Value
	|-Nullable<XboxOneGDKSubmitGraphicsCommandsCallbackInfo>.get_Value
	|-Nullable<XboxOneGDKXBLOptionsInitOptionsInternal>.get_Value
	|
	|-RVA: 0xB54C30 Offset: 0xB53E30 VA: 0x180B54C30
	|-Nullable<AddNotifyPeerConnectionClosedOptions>.get_Value
	|-Nullable<AddNotifyPeerConnectionEstablishedOptions>.get_Value
	|-Nullable<AddNotifyPeerConnectionInterruptedOptions>.get_Value
	|-Nullable<AddNotifyPeerConnectionRequestOptions>.get_Value
	|-Nullable<AndroidIAPVerifyPurchaseOptions>.get_Value
	|-Nullable<AudioBeforeSendCallbackInfo>.get_Value
	|-Nullable<BestDisplayNameInternal>.get_Value
	|-Nullable<BlockParticipantCallbackInfo>.get_Value
	|-Nullable<CloseConnectionsOptions>.get_Value
	|-Nullable<DataReceivedCallbackInfo>.get_Value
	|-Nullable<DefinitionInternal>.get_Value
	|-Nullable<EGSDLCVerifyPurchaseOptions>.get_Value
	|-Nullable<EGSIAPVerifyPurchaseOptions>.get_Value
	|-Nullable<EntitlementInternal>.get_Value
	|-Nullable<ExternalAccountInfoInternal>.get_Value
	|-Nullable<IOSIAPVerifyPurchaseOptions>.get_Value
	|-Nullable<JoinRoomOptions>.get_Value
	|-Nullable<LoginOptions>.get_Value
	|-Nullable<ModIdentifierInternal>.get_Value
	|-Nullable<OnAchievementsUnlockedCallbackV2Info>.get_Value
	|-Nullable<PS4Options>.get_Value
	|-Nullable<PS4PrePresentOptionsPlatformSpecificData>.get_Value
	|-Nullable<PS5PrePresentOptionsPlatformSpecificData>.get_Value
	|-Nullable<PacketQueueInfo>.get_Value
	|-Nullable<PermissionsUpdateReceivedCallbackInfo>.get_Value
	|-Nullable<QueryUserInfoByExternalAccountCallbackInfo>.get_Value
	|-Nullable<ReadFileDataCallbackInfo>.get_Value
	|-Nullable<ReadFileDataCallbackInfo>.get_Value
	|-Nullable<RegisterPeerOptions>.get_Value
	|-Nullable<SendCustomNativeInviteRequestedCallbackInfo>.get_Value
	|-Nullable<SendLobbyNativeInviteRequestedCallbackInfo>.get_Value
	|-Nullable<SendSessionNativeInviteRequestedCallbackInfo>.get_Value
	|-Nullable<SteamDLCVerifyPurchaseOptions>.get_Value
	|-Nullable<UpdateParticipantVolumeCallbackInfo>.get_Value
	|-Nullable<UpdateReceivingCallbackInfo>.get_Value
	|-Nullable<UpdateReceivingCallbackInfo>.get_Value
	|-Nullable<UserInfoData>.get_Value
	|-Nullable<UserLoginStatusChangedCallbackInfo>.get_Value
	|-Nullable<XSXDLCVerifyPurchaseOptions>.get_Value
	|-Nullable<XSXIAPVerifyPurchaseOptions>.get_Value
	|-Nullable<XSXIntegratedPlatformOptionsContainerAddOptions>.get_Value
	|-Nullable<XboxOneGDKDLCVerifyPurchaseOptions>.get_Value
	|-Nullable<XboxOneGDKIAPVerifyPurchaseOptions>.get_Value
	|-Nullable<XboxOneGDKIntegratedPlatformOptionsContainerAddOptions>.get_Value
	|
	|-RVA: 0x149BF70 Offset: 0x149B170 VA: 0x18149BF70
	|-Nullable<AndroidInitializeOptions>.get_Value
	|
	|-RVA: 0xB54E00 Offset: 0xB54000 VA: 0x180B54E00
	|-Nullable<Announcement>.get_Value
	|-Nullable<AttributeData>.get_Value
	|-Nullable<AttributeData>.get_Value
	|-Nullable<CreateSessionModificationOptions>.get_Value
	|-Nullable<IOSCredentials>.get_Value
	|-Nullable<InitializeThreadAffinity>.get_Value
	|-Nullable<InstallModOptions>.get_Value
	|-Nullable<LogPlayerUseWeaponOptions>.get_Value
	|-Nullable<LoginOptions>.get_Value
	|-Nullable<OnIncomingConnectionRequestInfo>.get_Value
	|-Nullable<OnPeerConnectionInterruptedInfo>.get_Value
	|-Nullable<PS4DLCVerifyPurchaseOptions>.get_Value
	|-Nullable<PS4IAPVerifyPurchaseOptions>.get_Value
	|-Nullable<PS5DLCVerifyPurchaseOptions>.get_Value
	|-Nullable<PS5IAPVerifyPurchaseOptions>.get_Value
	|-Nullable<Stat>.get_Value
	|-Nullable<XSXPrePresentOptions>.get_Value
	|-Nullable<XboxOneGDKPrePresentOptions>.get_Value
	|
	|-RVA: 0x149BEA0 Offset: 0x149B0A0 VA: 0x18149BEA0
	|-Nullable<Attribute>.get_Value
	|-Nullable<CatalogItem>.get_Value
	|-Nullable<CreateLobbyOptions>.get_Value
	|-Nullable<DefinitionV2>.get_Value
	|-Nullable<InfoInternal>.get_Value
	|-Nullable<LobbyModificationAddAttributeOptions>.get_Value
	|-Nullable<LobbyModificationAddMemberAttributeOptions>.get_Value
	|-Nullable<LobbySearchSetParameterOptions>.get_Value
	|-Nullable<PS4InitializeOptionsSystemInitializeOptions>.get_Value
	|-Nullable<PlayerAchievement>.get_Value
	|-Nullable<PlayerAchievementInternal>.get_Value
	|-Nullable<SessionDetailsAttribute>.get_Value
	|-Nullable<SessionDetailsInfo>.get_Value
	|-Nullable<SessionModificationAddAttributeOptions>.get_Value
	|-Nullable<SessionSearchSetParameterOptions>.get_Value
	|-Nullable<Token>.get_Value
	|
	|-RVA: 0x14AC3C0 Offset: 0x14AB5C0 VA: 0x1814AC3C0
	|-Nullable<CatalogItemInternal>.get_Value
	|-Nullable<Definition>.get_Value
	|-Nullable<DefinitionV2Internal>.get_Value
	|-Nullable<IOSLoginOptions>.get_Value
	|-Nullable<LobbyDetailsInfoInternal>.get_Value
	|-Nullable<TokenInternal>.get_Value
	|-Nullable<VerifyIdTokenCallbackInfo>.get_Value
	|-Nullable<VerifyUserAuthOptions>.get_Value
	|
	|-RVA: 0x14AC340 Offset: 0x14AB540 VA: 0x1814AC340
	|-Nullable<CatalogOffer>.get_Value
	|-Nullable<CatalogOfferInternal>.get_Value
	|
	|-RVA: 0x14AC310 Offset: 0x14AB510 VA: 0x1814AC310
	|-Nullable<char>.get_Value
	|-Nullable<short>.get_Value
	|-Nullable<Int16Enum>.get_Value
	|-Nullable<ushort>.get_Value
	|-Nullable<UInt16Enum>.get_Value
	|
	|-RVA: 0x14AC2D0 Offset: 0x14AB4D0 VA: 0x1814AC2D0
	|-Nullable<Color>.get_Value
	|-Nullable<Guid>.get_Value
	|-Nullable<Quat>.get_Value
	|-Nullable<QuatInternal>.get_Value
	|-Nullable<Rect>.get_Value
	|-Nullable<SentryId>.get_Value
	|
	|-RVA: 0xB54E50 Offset: 0xB54050 VA: 0x180B54E50
	|-Nullable<CopyUserTokenByIndexOptions>.get_Value
	|-Nullable<DesktopCrossplayStatusInfo>.get_Value
	|-Nullable<LocalRTCOptions>.get_Value
	|-Nullable<PS5OptionsInitOptionsInternal>.get_Value
	|-Nullable<PageQuery>.get_Value
	|-Nullable<XSXPrePresentAdditionalDataInternal>.get_Value
	|-Nullable<XboxOneGDKPrePresentAdditionalDataInternal>.get_Value
	|
	|-RVA: 0x14BC280 Offset: 0x14BB480 VA: 0x1814BC280
	|-Nullable<Definition>.get_Value
	|-Nullable<Info>.get_Value
	|-Nullable<InstallModCallbackInfo>.get_Value
	|-Nullable<LinkAccountCallbackInfo>.get_Value
	|-Nullable<LogPlayerTickOptions>.get_Value
	|-Nullable<OnPeerConnectionEstablishedInfo>.get_Value
	|-Nullable<OnRemoteConnectionClosedInfo>.get_Value
	|-Nullable<PS5InitializeOptionsSystemInitializeOptions>.get_Value
	|-Nullable<QueryLeaderboardUserScoresOptions>.get_Value
	|-Nullable<QueryStatsOptions>.get_Value
	|-Nullable<UninstallModCallbackInfo>.get_Value
	|-Nullable<UpdateModCallbackInfo>.get_Value
	|
	|-RVA: 0x14BC220 Offset: 0x14BB420 VA: 0x1814BC220
	|-Nullable<DefinitionInternal>.get_Value
	|-Nullable<LoginCallbackInfo>.get_Value
	|-Nullable<SendPacketOptions>.get_Value
	|-Nullable<VerifyIdTokenCallbackInfo>.get_Value
	|
	|-RVA: 0x14BC1F0 Offset: 0x14BB3F0 VA: 0x1814BC1F0
	|-Nullable<double>.get_Value
	|
	|-RVA: 0x14CB0F0 Offset: 0x14CA2F0 VA: 0x1814CB0F0
	|-Nullable<InitializeOptions>.get_Value
	|
	|-RVA: 0x14DB080 Offset: 0x14DA280 VA: 0x1814DB080
	|-Nullable<LogEventParamPair>.get_Value
	|-Nullable<LogEventParamPairParamValue>.get_Value
	|
	|-RVA: 0x14DB0F0 Offset: 0x14DA2F0 VA: 0x1814DB0F0
	|-Nullable<LogPlayerTakeDamageOptions>.get_Value
	|
	|-RVA: 0x14EC560 Offset: 0x14EB760 VA: 0x1814EC560
	|-Nullable<Options>.get_Value
	|
	|-RVA: 0x14EC6A0 Offset: 0x14EB8A0 VA: 0x1814EC6A0
	|-Nullable<PS4InitializeOptions>.get_Value
	|
	|-RVA: 0x14EC5F0 Offset: 0x14EB7F0 VA: 0x1814EC5F0
	|-Nullable<PS5InitializeOptions>.get_Value
	|
	|-RVA: 0x14EC750 Offset: 0x14EB950 VA: 0x1814EC750
	|-Nullable<PageResult>.get_Value
	|-Nullable<Token>.get_Value
	|-Nullable<Vec3f>.get_Value
	|-Nullable<Vec3fInternal>.get_Value
	|-Nullable<Vector3>.get_Value
	|
	|-RVA: 0x14FB9E0 Offset: 0x14FABE0 VA: 0x1814FB9E0
	|-Nullable<RectInternal>.get_Value
	|
	|-RVA: 0x150AFB0 Offset: 0x150A1B0 VA: 0x18150AFB0
	|-Nullable<ReportInputStateOptions>.get_Value
	|
	|-RVA: 0x150B000 Offset: 0x150A200 VA: 0x18150B000
	|-Nullable<SequencePoint>.get_Value
	|
	|-RVA: 0x150AF80 Offset: 0x150A180 VA: 0x18150AF80
	|-Nullable<SetPortRangeOptions>.get_Value
	|
	|-RVA: 0x151B450 Offset: 0x151A650 VA: 0x18151B450
	|-Nullable<float>.get_Value
	|
	|-RVA: 0x151B480 Offset: 0x151A680 VA: 0x18151B480
	|-Nullable<Touch>.get_Value
	|
	|-RVA: 0x151B420 Offset: 0x151A620 VA: 0x18151B420
	|-Nullable<Vector2>.get_Value
	|
	|-RVA: 0xB54E80 Offset: 0xB54080 VA: 0x180B54E80
	|-Nullable<WindowsOptions>.get_Value
	|-Nullable<XSXOptions>.get_Value
	|-Nullable<XboxOneGDKOptions>.get_Value
	|
	|-RVA: 0xB54D50 Offset: 0xB53F50 VA: 0x180B54D50
	|-Nullable<XSXInitializeOptions>.get_Value
	|-Nullable<XboxOneGDKInitializeOptions>.get_Value
	|
	|-RVA: 0xB54F20 Offset: 0xB54120 VA: 0x180B54F20
	|-Nullable<__Il2CppFullySharedGenericStructType>.get_Value
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public T GetValueOrDefault() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x42C4A0 Offset: 0x42B6A0 VA: 0x18042C4A0
	|-Nullable<ArraySegment<byte>>.GetValueOrDefault
	|-Nullable<ValueTuple<object, object>>.GetValueOrDefault
	|-Nullable<AcceptInviteOptions>.GetValueOrDefault
	|-Nullable<AcceptRequestToJoinOptions>.GetValueOrDefault
	|-Nullable<AccountFeatureRestrictedInfoInternal>.GetValueOrDefault
	|-Nullable<AcknowledgeEventIdOptions>.GetValueOrDefault
	|-Nullable<AddNotifyAudioBeforeSendOptions>.GetValueOrDefault
	|-Nullable<AddNotifyAudioInputStateOptions>.GetValueOrDefault
	|-Nullable<AddNotifyAudioOutputStateOptions>.GetValueOrDefault
	|-Nullable<AddNotifyDataReceivedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyDisconnectedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyParticipantStatusChangedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyParticipantUpdatedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyParticipantUpdatedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyRTCRoomConnectionChangedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyRoomStatisticsUpdatedOptions>.GetValueOrDefault
	|-Nullable<AndroidIAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<AudioBuffer>.GetValueOrDefault
	|-Nullable<AuthExpirationCallbackInfo>.GetValueOrDefault
	|-Nullable<BeginSessionOptions>.GetValueOrDefault
	|-Nullable<BigInteger>.GetValueOrDefault
	|-Nullable<ClientCredentials>.GetValueOrDefault
	|-Nullable<CopyBestDisplayNameOptions>.GetValueOrDefault
	|-Nullable<CopyEntitlementByIdOptions>.GetValueOrDefault
	|-Nullable<CopyEntitlementByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyFileMetadataAtIndexOptions>.GetValueOrDefault
	|-Nullable<CopyFileMetadataAtIndexOptions>.GetValueOrDefault
	|-Nullable<CopyFileMetadataByFilenameOptions>.GetValueOrDefault
	|-Nullable<CopyFileMetadataByFilenameOptions>.GetValueOrDefault
	|-Nullable<CopyItemByIdOptions>.GetValueOrDefault
	|-Nullable<CopyLastRedeemedEntitlementByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyLeaderboardUserScoreByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyLeaderboardUserScoreByUserIdOptions>.GetValueOrDefault
	|-Nullable<CopyLobbyDetailsHandleOptions>.GetValueOrDefault
	|-Nullable<CopyModInfoOptions>.GetValueOrDefault
	|-Nullable<CopyOfferByIdOptions>.GetValueOrDefault
	|-Nullable<CopyOfferByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyPermissionByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyPlayerSanctionByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyPresenceOptions>.GetValueOrDefault
	|-Nullable<CopyProductUserExternalAccountByAccountIdOptions>.GetValueOrDefault
	|-Nullable<CopyProductUserExternalAccountByAccountTypeOptions>.GetValueOrDefault
	|-Nullable<CopyProductUserExternalAccountByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyStatByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyStatByNameOptions>.GetValueOrDefault
	|-Nullable<CopyTransactionByIdOptions>.GetValueOrDefault
	|-Nullable<CopyTransactionByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyUnlockedAchievementByAchievementIdOptions>.GetValueOrDefault
	|-Nullable<CopyUnlockedAchievementByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyUserInfoOptions>.GetValueOrDefault
	|-Nullable<CopyUserTokenByUserIdOptions>.GetValueOrDefault
	|-Nullable<CreateDeviceIdCallbackInfo>.GetValueOrDefault
	|-Nullable<Credentials>.GetValueOrDefault
	|-Nullable<DataRecord>.GetValueOrDefault
	|-Nullable<DateTimeOffset>.GetValueOrDefault
	|-Nullable<Decimal>.GetValueOrDefault
	|-Nullable<DeleteDeviceIdCallbackInfo>.GetValueOrDefault
	|-Nullable<DeleteFileOptions>.GetValueOrDefault
	|-Nullable<DeletePersistentAuthCallbackInfo>.GetValueOrDefault
	|-Nullable<DestroyLobbyOptions>.GetValueOrDefault
	|-Nullable<DestroySessionCallbackInfo>.GetValueOrDefault
	|-Nullable<EGSDLCVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<EGSIAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<EndSessionCallbackInfo>.GetValueOrDefault
	|-Nullable<EnumerateModsOptions>.GetValueOrDefault
	|-Nullable<GetBlockedUserAtIndexOptions>.GetValueOrDefault
	|-Nullable<GetConnectStringOptions>.GetValueOrDefault
	|-Nullable<GetEntitlementsByNameCountOptions>.GetValueOrDefault
	|-Nullable<GetExternalUserInfoCountOptions>.GetValueOrDefault
	|-Nullable<GetFriendAtIndexOptions>.GetValueOrDefault
	|-Nullable<GetInviteIdByIndexOptions>.GetValueOrDefault
	|-Nullable<GetInviteIdByIndexOptions>.GetValueOrDefault
	|-Nullable<GetItemImageInfoCountOptions>.GetValueOrDefault
	|-Nullable<GetItemReleaseCountOptions>.GetValueOrDefault
	|-Nullable<GetJoinInfoOptions>.GetValueOrDefault
	|-Nullable<GetNextReceivedPacketSizeOptions>.GetValueOrDefault
	|-Nullable<GetOfferImageInfoCountOptions>.GetValueOrDefault
	|-Nullable<GetOfferItemCountOptions>.GetValueOrDefault
	|-Nullable<GetPermissionByKeyOptions>.GetValueOrDefault
	|-Nullable<GetRTCRoomNameOptions>.GetValueOrDefault
	|-Nullable<GetStatusOptions>.GetValueOrDefault
	|-Nullable<HasPresenceOptions>.GetValueOrDefault
	|-Nullable<IOSIAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<IdToken>.GetValueOrDefault
	|-Nullable<IdToken>.GetValueOrDefault
	|-Nullable<IngestData>.GetValueOrDefault
	|-Nullable<IsRTCRoomConnectedOptions>.GetValueOrDefault
	|-Nullable<IsUserInSessionOptions>.GetValueOrDefault
	|-Nullable<ItemOwnership>.GetValueOrDefault
	|-Nullable<JoinSessionCallbackInfo>.GetValueOrDefault
	|-Nullable<JsonElement>.GetValueOrDefault
	|-Nullable<KickCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<KickOptions>.GetValueOrDefault
	|-Nullable<LeaderboardUserScore>.GetValueOrDefault
	|-Nullable<LeaveLobbyOptions>.GetValueOrDefault
	|-Nullable<LeaveRoomOptions>.GetValueOrDefault
	|-Nullable<LinkAccountOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsCopyMemberAttributeByIndexOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsCopyMemberAttributeByKeyOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsMemberInfo>.GetValueOrDefault
	|-Nullable<LobbySearchFindCallbackInfo>.GetValueOrDefault
	|-Nullable<LobbySearchRemoveParameterOptions>.GetValueOrDefault
	|-Nullable<LobbyUpdateReceivedCallbackInfo>.GetValueOrDefault
	|-Nullable<LocalDefinition>.GetValueOrDefault
	|-Nullable<LogPlayerReviveOptions>.GetValueOrDefault
	|-Nullable<LogPlayerSpawnOptions>.GetValueOrDefault
	|-Nullable<MemoryMonitorCallbackInfo>.GetValueOrDefault
	|-Nullable<ModInfo>.GetValueOrDefault
	|-Nullable<OnCheckpointCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<OnCloseCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<OnDisplaySettingsUpdatedCallbackInfo>.GetValueOrDefault
	|-Nullable<OnQueryDefinitionsCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<OnQueryInputDevicesInformationCallbackInfo>.GetValueOrDefault
	|-Nullable<OnQueryLeaderboardDefinitionsCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<OnQueryLeaderboardUserScoresCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<OnQueryOutputDevicesInformationCallbackInfo>.GetValueOrDefault
	|-Nullable<Option>.GetValueOrDefault
	|-Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReport>.GetValueOrDefault
	|-Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReport>.GetValueOrDefault
	|-Nullable<PS5Options>.GetValueOrDefault
	|-Nullable<ParticipantMetadata>.GetValueOrDefault
	|-Nullable<PermissionStatus>.GetValueOrDefault
	|-Nullable<PlayerStatInfo>.GetValueOrDefault
	|-Nullable<QueryActivePlayerSanctionsOptions>.GetValueOrDefault
	|-Nullable<QueryEntitlementTokenOptions>.GetValueOrDefault
	|-Nullable<QueryFileListOptions>.GetValueOrDefault
	|-Nullable<QueryFileOptions>.GetValueOrDefault
	|-Nullable<QueryFileOptions>.GetValueOrDefault
	|-Nullable<QueryIdTokenOptions>.GetValueOrDefault
	|-Nullable<QueryLeaderboardRanksOptions>.GetValueOrDefault
	|-Nullable<QueryOffersOptions>.GetValueOrDefault
	|-Nullable<QueryOwnershipBySandboxIdsOptions>.GetValueOrDefault
	|-Nullable<QueryPlayerAchievementsOptions>.GetValueOrDefault
	|-Nullable<QueryPresenceOptions>.GetValueOrDefault
	|-Nullable<QueryUserInfoByDisplayNameOptions>.GetValueOrDefault
	|-Nullable<QueryUserInfoOptions>.GetValueOrDefault
	|-Nullable<RTCOptions>.GetValueOrDefault
	|-Nullable<ReceiveMessageFromServerOptions>.GetValueOrDefault
	|-Nullable<RedeemEntitlementsOptions>.GetValueOrDefault
	|-Nullable<RegexPrefix>.GetValueOrDefault
	|-Nullable<RegisterEventParamDef>.GetValueOrDefault
	|-Nullable<RegisterPlayersOptions>.GetValueOrDefault
	|-Nullable<RejectInviteCallbackInfo>.GetValueOrDefault
	|-Nullable<RejectInviteOptions>.GetValueOrDefault
	|-Nullable<RejectInviteOptions>.GetValueOrDefault
	|-Nullable<RejectInviteOptions>.GetValueOrDefault
	|-Nullable<RejectRequestToJoinOptions>.GetValueOrDefault
	|-Nullable<RequestPermissionsOptions>.GetValueOrDefault
	|-Nullable<SandboxIdItemOwnership>.GetValueOrDefault
	|-Nullable<SendCustomInviteOptions>.GetValueOrDefault
	|-Nullable<SendInviteCallbackInfo>.GetValueOrDefault
	|-Nullable<SendInviteOptions>.GetValueOrDefault
	|-Nullable<SendPlayerBehaviorReportCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<SendRequestToJoinOptions>.GetValueOrDefault
	|-Nullable<SessionSearchFindCallbackInfo>.GetValueOrDefault
	|-Nullable<SessionSearchRemoveParameterOptions>.GetValueOrDefault
	|-Nullable<SetClientDetailsOptions>.GetValueOrDefault
	|-Nullable<SetClientNetworkStateOptions>.GetValueOrDefault
	|-Nullable<SetCustomInviteOptions>.GetValueOrDefault
	|-Nullable<SetOutputDeviceSettingsOptions>.GetValueOrDefault
	|-Nullable<SetPacketQueueSizeOptions>.GetValueOrDefault
	|-Nullable<SetParticipantHardMuteCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<SetPresenceOptions>.GetValueOrDefault
	|-Nullable<SetSettingOptions>.GetValueOrDefault
	|-Nullable<ShowBlockPlayerOptions>.GetValueOrDefault
	|-Nullable<ShowNativeProfileOptions>.GetValueOrDefault
	|-Nullable<ShowReportPlayerOptions>.GetValueOrDefault
	|-Nullable<SocketIdInternal>.GetValueOrDefault
	|-Nullable<StartSessionCallbackInfo>.GetValueOrDefault
	|-Nullable<StatThresholds>.GetValueOrDefault
	|-Nullable<SteamDLCVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<StreamingContext>.GetValueOrDefault
	|-Nullable<SubmitSnapshotCallbackInfo>.GetValueOrDefault
	|-Nullable<UnlockAchievementsOptions>.GetValueOrDefault
	|-Nullable<UnregisterPlayersOptions>.GetValueOrDefault
	|-Nullable<UpdateLobbyModificationOptions>.GetValueOrDefault
	|-Nullable<UpdateParentEmailOptions>.GetValueOrDefault
	|-Nullable<UserLoginInfo>.GetValueOrDefault
	|-Nullable<UserScoresQueryStatInfo>.GetValueOrDefault
	|-Nullable<UserToken>.GetValueOrDefault
	|-Nullable<VerifyPurchaseCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<VerifyUserAuthCallbackInfo>.GetValueOrDefault
	|-Nullable<WindowsRTCOptionsPlatformSpecificOptionsInternal>.GetValueOrDefault
	|-Nullable<XSXDLCVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<XSXIAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.GetValueOrDefault
	|-Nullable<XSXSubmitGraphicsCommandsDataCommand>.GetValueOrDefault
	|-Nullable<XSXXBLOptionsInitOptions>.GetValueOrDefault
	|-Nullable<XboxOneGDKDLCVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<XboxOneGDKIAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.GetValueOrDefault
	|-Nullable<XboxOneGDKSubmitGraphicsCommandsDataCommand>.GetValueOrDefault
	|-Nullable<XboxOneGDKXBLOptionsInitOptions>.GetValueOrDefault
	|
	|-RVA: 0x40D970 Offset: 0x40CB70 VA: 0x18040D970
	|-Nullable<AcceptConnectionOptions>.GetValueOrDefault
	|-Nullable<AttributeDataValue>.GetValueOrDefault
	|-Nullable<AttributeDataValue>.GetValueOrDefault
	|-Nullable<AudioBeforeRenderCallbackInfo>.GetValueOrDefault
	|-Nullable<BeginPlayerSessionOptions>.GetValueOrDefault
	|-Nullable<ClearPacketQueueOptions>.GetValueOrDefault
	|-Nullable<CloseConnectionOptions>.GetValueOrDefault
	|-Nullable<ExternalAccountInfo>.GetValueOrDefault
	|-Nullable<FileMetadata>.GetValueOrDefault
	|-Nullable<LobbyDetailsInfo>.GetValueOrDefault
	|-Nullable<LogPlayerUseWeaponData>.GetValueOrDefault
	|-Nullable<PS4IntegratedPlatformOptionsContainerAddOptions>.GetValueOrDefault
	|-Nullable<PS4PrePresentOptions>.GetValueOrDefault
	|-Nullable<PS5PrePresentOptions>.GetValueOrDefault
	|-Nullable<ParticipantStatusChangedCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryLeaderboardDefinitionsOptions>.GetValueOrDefault
	|-Nullable<QueryPermissionsCallbackInfo>.GetValueOrDefault
	|-Nullable<SessionDetailsInfoInternal>.GetValueOrDefault
	|-Nullable<SessionDetailsSettingsInternal>.GetValueOrDefault
	|-Nullable<UninstallModOptions>.GetValueOrDefault
	|-Nullable<UpdateModOptions>.GetValueOrDefault
	|-Nullable<UserInfoDataInternal>.GetValueOrDefault
	|-Nullable<XSXInitializeOptionsSystemInitializeOptions>.GetValueOrDefault
	|-Nullable<XSXPrePresentOptionsPlatformSpecificData>.GetValueOrDefault
	|-Nullable<XboxOneGDKInitializeOptionsSystemInitializeOptions>.GetValueOrDefault
	|-Nullable<XboxOneGDKPrePresentOptionsPlatformSpecificData>.GetValueOrDefault
	|
	|-RVA: 0xB4BAE0 Offset: 0xB4ACE0 VA: 0x180B4BAE0
	|-Nullable<AcceptInviteCallbackInfo>.GetValueOrDefault
	|-Nullable<AcceptRequestToJoinCallbackInfo>.GetValueOrDefault
	|-Nullable<AttributeDataInternal>.GetValueOrDefault
	|-Nullable<AttributeDataInternal>.GetValueOrDefault
	|-Nullable<AudioBufferInternal>.GetValueOrDefault
	|-Nullable<AudioInputStateCallbackInfo>.GetValueOrDefault
	|-Nullable<AudioOutputStateCallbackInfo>.GetValueOrDefault
	|-Nullable<BeginSessionOptions>.GetValueOrDefault
	|-Nullable<BlockParticipantOptions>.GetValueOrDefault
	|-Nullable<CheckoutCallbackInfo>.GetValueOrDefault
	|-Nullable<DisconnectedCallbackInfo>.GetValueOrDefault
	|-Nullable<EnumerateModsCallbackInfo>.GetValueOrDefault
	|-Nullable<ExternalUserInfo>.GetValueOrDefault
	|-Nullable<ExternalUserInfoInternal>.GetValueOrDefault
	|-Nullable<FileMetadata>.GetValueOrDefault
	|-Nullable<FileMetadataInternal>.GetValueOrDefault
	|-Nullable<FileTransferProgressCallbackInfo>.GetValueOrDefault
	|-Nullable<FileTransferProgressCallbackInfo>.GetValueOrDefault
	|-Nullable<FinalizeInviteOptions>.GetValueOrDefault
	|-Nullable<HardMuteMemberCallbackInfo>.GetValueOrDefault
	|-Nullable<HardMuteMemberOptions>.GetValueOrDefault
	|-Nullable<IOSCredentialsSystemAuthCredentialsOptionsInternal>.GetValueOrDefault
	|-Nullable<IngestStatCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<IntegratedPlatformOptionsContainerAddOptions>.GetValueOrDefault
	|-Nullable<JoinSessionOptions>.GetValueOrDefault
	|-Nullable<KeyImageInfoInternal>.GetValueOrDefault
	|-Nullable<LeaderboardRecordInternal>.GetValueOrDefault
	|-Nullable<LeaveRoomCallbackInfo>.GetValueOrDefault
	|-Nullable<LobbyInviteReceivedCallbackInfo>.GetValueOrDefault
	|-Nullable<LobbyMemberStatusReceivedCallbackInfo>.GetValueOrDefault
	|-Nullable<LogGameRoundStartOptions>.GetValueOrDefault
	|-Nullable<LoginCallbackInfo>.GetValueOrDefault
	|-Nullable<OnBlockedUsersUpdateInfo>.GetValueOrDefault
	|-Nullable<OnClientActionRequiredCallbackInfo>.GetValueOrDefault
	|-Nullable<OnFriendsUpdateInfo>.GetValueOrDefault
	|-Nullable<OnMessageToClientCallbackInfo>.GetValueOrDefault
	|-Nullable<OnQueryPlayerAchievementsCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<OnQueryStatsCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<OnShowBlockPlayerCallbackInfo>.GetValueOrDefault
	|-Nullable<OnShowReportPlayerCallbackInfo>.GetValueOrDefault
	|-Nullable<OnUnlockAchievementsCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<PS4DLCVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<PS4IAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<PS4MemoryMonitorCallbackInfo>.GetValueOrDefault
	|-Nullable<PS4OptionsInitOptionsInternal>.GetValueOrDefault
	|-Nullable<PS5DLCVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<PS5IAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<PS5MemoryMonitorCallbackInfo>.GetValueOrDefault
	|-Nullable<PS5SubmitGraphicsCommandsCallbackInfo>.GetValueOrDefault
	|-Nullable<PinGrantInfo>.GetValueOrDefault
	|-Nullable<PlayerSanction>.GetValueOrDefault
	|-Nullable<ProtectMessageOptions>.GetValueOrDefault
	|-Nullable<QueryActivePlayerSanctionsCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryAgeGateCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryEntitlementTokenCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryFileListCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryFileListCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryIdTokenCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryJoinRoomTokenOptions>.GetValueOrDefault
	|-Nullable<QueryOwnershipBySandboxIdsCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryOwnershipCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryOwnershipTokenCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryPresenceCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryUserInfoCallbackInfo>.GetValueOrDefault
	|-Nullable<RTCRoomConnectionChangedCallbackInfo>.GetValueOrDefault
	|-Nullable<ReadFileCallbackInfo>.GetValueOrDefault
	|-Nullable<ReadFileCallbackInfo>.GetValueOrDefault
	|-Nullable<RedeemEntitlementsCallbackInfo>.GetValueOrDefault
	|-Nullable<RegisterEventOptions>.GetValueOrDefault
	|-Nullable<RegisterPlayersCallbackInfo>.GetValueOrDefault
	|-Nullable<RejectInviteCallbackInfo>.GetValueOrDefault
	|-Nullable<RejectRequestToJoinCallbackInfo>.GetValueOrDefault
	|-Nullable<RequestToJoinResponseReceivedCallbackInfo>.GetValueOrDefault
	|-Nullable<RoomStatisticsUpdatedInfo>.GetValueOrDefault
	|-Nullable<SendCustomInviteCallbackInfo>.GetValueOrDefault
	|-Nullable<SendDataOptions>.GetValueOrDefault
	|-Nullable<SendInviteCallbackInfo>.GetValueOrDefault
	|-Nullable<SendRequestToJoinCallbackInfo>.GetValueOrDefault
	|-Nullable<SessionDetailsSettings>.GetValueOrDefault
	|-Nullable<SessionInviteReceivedCallbackInfo>.GetValueOrDefault
	|-Nullable<SetRoomSettingOptions>.GetValueOrDefault
	|-Nullable<ShowNativeProfileCallbackInfo>.GetValueOrDefault
	|-Nullable<SocketId>.GetValueOrDefault
	|-Nullable<SteamOptions>.GetValueOrDefault
	|-Nullable<UnlockedAchievement>.GetValueOrDefault
	|-Nullable<UnprotectMessageOptions>.GetValueOrDefault
	|-Nullable<UpdateParticipantVolumeOptions>.GetValueOrDefault
	|-Nullable<UpdateReceivingOptions>.GetValueOrDefault
	|-Nullable<UpdateReceivingOptions>.GetValueOrDefault
	|-Nullable<UpdateSessionCallbackInfo>.GetValueOrDefault
	|-Nullable<VerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<WriteFileCallbackInfo>.GetValueOrDefault
	|-Nullable<WriteFileDataCallbackInfo>.GetValueOrDefault
	|
	|-RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	|-Nullable<AccountFeatureRestrictedInfo>.GetValueOrDefault
	|-Nullable<AddExternalIntegrityCatalogOptions>.GetValueOrDefault
	|-Nullable<AudioDevicesChangedCallbackInfo>.GetValueOrDefault
	|-Nullable<BeginSnapshotOptions>.GetValueOrDefault
	|-Nullable<CheckoutEntry>.GetValueOrDefault
	|-Nullable<CopyAchievementDefinitionByAchievementIdOptions>.GetValueOrDefault
	|-Nullable<CopyAchievementDefinitionV2ByAchievementIdOptions>.GetValueOrDefault
	|-Nullable<CopyActiveSessionHandleOptions>.GetValueOrDefault
	|-Nullable<CopyIdTokenOptions>.GetValueOrDefault
	|-Nullable<CopyIdTokenOptions>.GetValueOrDefault
	|-Nullable<CopyLeaderboardDefinitionByLeaderboardIdOptions>.GetValueOrDefault
	|-Nullable<CopyLeaderboardRecordByUserIdOptions>.GetValueOrDefault
	|-Nullable<CopyLobbyDetailsHandleByInviteIdOptions>.GetValueOrDefault
	|-Nullable<CopyLobbyDetailsHandleByUiEventIdOptions>.GetValueOrDefault
	|-Nullable<CopyProductUserInfoOptions>.GetValueOrDefault
	|-Nullable<CopySessionHandleByInviteIdOptions>.GetValueOrDefault
	|-Nullable<CopySessionHandleByUiEventIdOptions>.GetValueOrDefault
	|-Nullable<CopySessionHandleForPresenceOptions>.GetValueOrDefault
	|-Nullable<CreateDeviceIdOptions>.GetValueOrDefault
	|-Nullable<CreatePresenceModificationOptions>.GetValueOrDefault
	|-Nullable<CreateUserOptions>.GetValueOrDefault
	|-Nullable<DataKey>.GetValueOrDefault
	|-Nullable<DateTime>.GetValueOrDefault
	|-Nullable<DeleteCacheOptions>.GetValueOrDefault
	|-Nullable<DeleteCacheOptions>.GetValueOrDefault
	|-Nullable<DeletePersistentAuthOptions>.GetValueOrDefault
	|-Nullable<DeleteSnapshotOptions>.GetValueOrDefault
	|-Nullable<DestroySessionOptions>.GetValueOrDefault
	|-Nullable<DumpSessionStateOptions>.GetValueOrDefault
	|-Nullable<EndSessionOptions>.GetValueOrDefault
	|-Nullable<EventDispatcherGate>.GetValueOrDefault
	|-Nullable<GCHandle>.GetValueOrDefault
	|-Nullable<GetBlockedUsersCountOptions>.GetValueOrDefault
	|-Nullable<GetEntitlementsCountOptions>.GetValueOrDefault
	|-Nullable<GetFileMetadataCountOptions>.GetValueOrDefault
	|-Nullable<GetFileMetadataCountOptions>.GetValueOrDefault
	|-Nullable<GetFriendsCountOptions>.GetValueOrDefault
	|-Nullable<GetFriendsExclusiveInputOptions>.GetValueOrDefault
	|-Nullable<GetFriendsVisibleOptions>.GetValueOrDefault
	|-Nullable<GetInviteCountOptions>.GetValueOrDefault
	|-Nullable<GetInviteCountOptions>.GetValueOrDefault
	|-Nullable<GetLastRedeemedEntitlementsCountOptions>.GetValueOrDefault
	|-Nullable<GetLeaderboardUserScoreCountOptions>.GetValueOrDefault
	|-Nullable<GetOfferCountOptions>.GetValueOrDefault
	|-Nullable<GetPermissionsCountOptions>.GetValueOrDefault
	|-Nullable<GetPlayerAchievementCountOptions>.GetValueOrDefault
	|-Nullable<GetPlayerSanctionCountOptions>.GetValueOrDefault
	|-Nullable<GetProductUserExternalAccountCountOptions>.GetValueOrDefault
	|-Nullable<GetStatCountOptions>.GetValueOrDefault
	|-Nullable<GetTransactionCountOptions>.GetValueOrDefault
	|-Nullable<GetUnlockedAchievementCountOptions>.GetValueOrDefault
	|-Nullable<HideFriendsOptions>.GetValueOrDefault
	|-Nullable<long>.GetValueOrDefault
	|-Nullable<IntPtr>.GetValueOrDefault
	|-Nullable<InventoryItemCreateSubItemOptions>.GetValueOrDefault
	|-Nullable<InventoryItemDeleteSubItemOptions>.GetValueOrDefault
	|-Nullable<InventoryItemGetSubItemOptions>.GetValueOrDefault
	|-Nullable<InventoryItemSetKeyOptions>.GetValueOrDefault
	|-Nullable<InventoryItemSetValueAsDoubleOptions>.GetValueOrDefault
	|-Nullable<InventoryItemSetValueAsDoubleSetOptions>.GetValueOrDefault
	|-Nullable<InventoryItemSetValueAsInt64Options>.GetValueOrDefault
	|-Nullable<InventoryItemSetValueAsInt64SetOptions>.GetValueOrDefault
	|-Nullable<InventoryItemSetValueAsStringOptions>.GetValueOrDefault
	|-Nullable<InventoryItemSetValueAsStringSetOptions>.GetValueOrDefault
	|-Nullable<InventoryItemSetValueAsTimestampOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsCopyAttributeByKeyOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsCopyMemberInfoOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsGetMemberAttributeCountOptions>.GetValueOrDefault
	|-Nullable<LobbyModificationRemoveAttributeOptions>.GetValueOrDefault
	|-Nullable<LobbyModificationRemoveMemberAttributeOptions>.GetValueOrDefault
	|-Nullable<LobbyModificationSetAllowedPlatformIdsOptions>.GetValueOrDefault
	|-Nullable<LobbyModificationSetBucketIdOptions>.GetValueOrDefault
	|-Nullable<LobbySearchFindOptions>.GetValueOrDefault
	|-Nullable<LobbySearchSetLobbyIdOptions>.GetValueOrDefault
	|-Nullable<LobbySearchSetTargetUserIdOptions>.GetValueOrDefault
	|-Nullable<LogPlayerDespawnOptions>.GetValueOrDefault
	|-Nullable<LogoutOptions>.GetValueOrDefault
	|-Nullable<LogoutOptions>.GetValueOrDefault
	|-Nullable<ParseConnectStringOptions>.GetValueOrDefault
	|-Nullable<PrePresentOptions>.GetValueOrDefault
	|-Nullable<PresenceModificationDataRecordId>.GetValueOrDefault
	|-Nullable<PresenceModificationDeleteDataOptions>.GetValueOrDefault
	|-Nullable<PresenceModificationSetDataOptions>.GetValueOrDefault
	|-Nullable<PresenceModificationSetJoinInfoOptions>.GetValueOrDefault
	|-Nullable<PresenceModificationSetRawRichTextOptions>.GetValueOrDefault
	|-Nullable<QueryFileListOptions>.GetValueOrDefault
	|-Nullable<QueryFriendsOptions>.GetValueOrDefault
	|-Nullable<QueryInvitesOptions>.GetValueOrDefault
	|-Nullable<QueryInvitesOptions>.GetValueOrDefault
	|-Nullable<QueryPermissionsOptions>.GetValueOrDefault
	|-Nullable<RegisterPlatformAudioUserOptions>.GetValueOrDefault
	|-Nullable<RegisterPlatformUserOptions>.GetValueOrDefault
	|-Nullable<SessionDetailsCopySessionAttributeByKeyOptions>.GetValueOrDefault
	|-Nullable<SessionModificationRemoveAttributeOptions>.GetValueOrDefault
	|-Nullable<SessionModificationSetAllowedPlatformIdsOptions>.GetValueOrDefault
	|-Nullable<SessionModificationSetBucketIdOptions>.GetValueOrDefault
	|-Nullable<SessionModificationSetHostAddressOptions>.GetValueOrDefault
	|-Nullable<SessionSearchFindOptions>.GetValueOrDefault
	|-Nullable<SessionSearchSetSessionIdOptions>.GetValueOrDefault
	|-Nullable<SessionSearchSetTargetUserIdOptions>.GetValueOrDefault
	|-Nullable<SetGameSessionIdOptions>.GetValueOrDefault
	|-Nullable<ShowFriendsOptions>.GetValueOrDefault
	|-Nullable<SpanId>.GetValueOrDefault
	|-Nullable<SqlBinary>.GetValueOrDefault
	|-Nullable<StartSessionOptions>.GetValueOrDefault
	|-Nullable<SteamIAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<SwitchIAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<TimeSpan>.GetValueOrDefault
	|-Nullable<ulong>.GetValueOrDefault
	|-Nullable<UIntPtr>.GetValueOrDefault
	|-Nullable<UnlinkAccountOptions>.GetValueOrDefault
	|-Nullable<UnregisterClientOptions>.GetValueOrDefault
	|-Nullable<UnregisterPeerOptions>.GetValueOrDefault
	|-Nullable<UnregisterPlatformAudioUserOptions>.GetValueOrDefault
	|-Nullable<UnregisterPlatformUserOptions>.GetValueOrDefault
	|-Nullable<UpdateLobbyOptions>.GetValueOrDefault
	|-Nullable<UpdateSessionModificationOptions>.GetValueOrDefault
	|-Nullable<UpdateSessionOptions>.GetValueOrDefault
	|-Nullable<WindowsRTCOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReport>.GetValueOrDefault
	|-Nullable<XSXOptionsSystemSpecificOptions>.GetValueOrDefault
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReport>.GetValueOrDefault
	|-Nullable<XboxOneGDKOptionsSystemSpecificOptions>.GetValueOrDefault
	|-Nullable<C.sentry_value_t>.GetValueOrDefault
	|
	|-RVA: 0x13147E0 Offset: 0x13139E0 VA: 0x1813147E0
	|-Nullable<ActiveSessionCopyInfoOptions>.GetValueOrDefault
	|-Nullable<ActiveSessionGetRegisteredPlayerCountOptions>.GetValueOrDefault
	|-Nullable<AddNotifyAchievementsUnlockedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyAchievementsUnlockedV2Options>.GetValueOrDefault
	|-Nullable<AddNotifyAudioDevicesChangedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyAuthExpirationOptions>.GetValueOrDefault
	|-Nullable<AddNotifyBlockedUsersUpdateOptions>.GetValueOrDefault
	|-Nullable<AddNotifyClientActionRequiredOptions>.GetValueOrDefault
	|-Nullable<AddNotifyClientAuthStatusChangedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyClientIntegrityViolatedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyCustomInviteAcceptedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyCustomInviteReceivedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyCustomInviteRejectedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyDisplaySettingsUpdatedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyFriendsUpdateOptions>.GetValueOrDefault
	|-Nullable<AddNotifyIncomingPacketQueueFullOptions>.GetValueOrDefault
	|-Nullable<AddNotifyJoinGameAcceptedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyJoinLobbyAcceptedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyJoinSessionAcceptedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyLeaveLobbyRequestedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyLeaveSessionRequestedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyLobbyInviteAcceptedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyLobbyInviteReceivedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyLobbyInviteRejectedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyLobbyMemberStatusReceivedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyLobbyMemberUpdateReceivedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyLobbyUpdateReceivedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyLoginStatusChangedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyLoginStatusChangedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyMemoryMonitorOptions>.GetValueOrDefault
	|-Nullable<AddNotifyMessageToClientOptions>.GetValueOrDefault
	|-Nullable<AddNotifyMessageToPeerOptions>.GetValueOrDefault
	|-Nullable<AddNotifyMessageToServerOptions>.GetValueOrDefault
	|-Nullable<AddNotifyOnPresenceChangedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyPeerActionRequiredOptions>.GetValueOrDefault
	|-Nullable<AddNotifyPeerAuthStatusChangedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyPermissionsUpdateReceivedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyRequestToJoinAcceptedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyRequestToJoinReceivedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyRequestToJoinRejectedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyRequestToJoinResponseReceivedOptions>.GetValueOrDefault
	|-Nullable<AddNotifySendCustomNativeInviteRequestedOptions>.GetValueOrDefault
	|-Nullable<AddNotifySendLobbyNativeInviteRequestedOptions>.GetValueOrDefault
	|-Nullable<AddNotifySendSessionNativeInviteRequestedOptions>.GetValueOrDefault
	|-Nullable<AddNotifySessionInviteAcceptedOptions>.GetValueOrDefault
	|-Nullable<AddNotifySessionInviteReceivedOptions>.GetValueOrDefault
	|-Nullable<AddNotifySessionInviteRejectedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyUserLoginStatusChangedOptions>.GetValueOrDefault
	|-Nullable<bool>.GetValueOrDefault
	|-Nullable<byte>.GetValueOrDefault
	|-Nullable<ClearUserPreLogoutCallbackOptions>.GetValueOrDefault
	|-Nullable<CopyUserAuthTokenOptions>.GetValueOrDefault
	|-Nullable<CreateIntegratedPlatformOptionsContainerOptions>.GetValueOrDefault
	|-Nullable<DeleteDeviceIdOptions>.GetValueOrDefault
	|-Nullable<EndSessionOptions>.GetValueOrDefault
	|-Nullable<EndSessionOptions>.GetValueOrDefault
	|-Nullable<GetAchievementDefinitionCountOptions>.GetValueOrDefault
	|-Nullable<GetAudioInputDevicesCountOptions>.GetValueOrDefault
	|-Nullable<GetAudioOutputDevicesCountOptions>.GetValueOrDefault
	|-Nullable<GetDesktopCrossplayStatusOptions>.GetValueOrDefault
	|-Nullable<GetInputDevicesCountOptions>.GetValueOrDefault
	|-Nullable<GetLeaderboardDefinitionCountOptions>.GetValueOrDefault
	|-Nullable<GetLeaderboardRecordCountOptions>.GetValueOrDefault
	|-Nullable<GetLocalPlatformTypeOptions>.GetValueOrDefault
	|-Nullable<GetNATTypeOptions>.GetValueOrDefault
	|-Nullable<GetOutputDevicesCountOptions>.GetValueOrDefault
	|-Nullable<GetPacketQueueInfoOptions>.GetValueOrDefault
	|-Nullable<GetPortRangeOptions>.GetValueOrDefault
	|-Nullable<GetRelayControlOptions>.GetValueOrDefault
	|-Nullable<GetToggleFriendsButtonOptions>.GetValueOrDefault
	|-Nullable<GetToggleFriendsKeyOptions>.GetValueOrDefault
	|-Nullable<InventoryItemGetKeyOptions>.GetValueOrDefault
	|-Nullable<InventoryItemGetSubItemsCountOptions>.GetValueOrDefault
	|-Nullable<InventoryItemGetValueAsBoolOptions>.GetValueOrDefault
	|-Nullable<InventoryItemGetValueAsDoubleOptions>.GetValueOrDefault
	|-Nullable<InventoryItemGetValueAsInt64Options>.GetValueOrDefault
	|-Nullable<InventoryItemGetValueAsStringOptions>.GetValueOrDefault
	|-Nullable<InventoryItemGetValueAsTimestampOptions>.GetValueOrDefault
	|-Nullable<InventoryItemGetValueCountOptions>.GetValueOrDefault
	|-Nullable<InventoryItemGetValueTypeOptions>.GetValueOrDefault
	|-Nullable<InventoryItemSetValueAsBoolOptions>.GetValueOrDefault
	|-Nullable<IsSocialOverlayPausedOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsCopyInfoOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsGetAttributeCountOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsGetLobbyOwnerOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsGetMemberCountOptions>.GetValueOrDefault
	|-Nullable<LobbyModificationSetInvitesAllowedOptions>.GetValueOrDefault
	|-Nullable<LobbySearchGetSearchResultCountOptions>.GetValueOrDefault
	|-Nullable<PS5OptionsInitOptions>.GetValueOrDefault
	|-Nullable<PauseSocialOverlayOptions>.GetValueOrDefault
	|-Nullable<QueryAgeGateOptions>.GetValueOrDefault
	|-Nullable<QueryInputDevicesInformationOptions>.GetValueOrDefault
	|-Nullable<QueryNATTypeOptions>.GetValueOrDefault
	|-Nullable<QueryOutputDevicesInformationOptions>.GetValueOrDefault
	|-Nullable<sbyte>.GetValueOrDefault
	|-Nullable<SessionDetailsCopyInfoOptions>.GetValueOrDefault
	|-Nullable<SessionDetailsGetSessionAttributeCountOptions>.GetValueOrDefault
	|-Nullable<SessionModificationSetInvitesAllowedOptions>.GetValueOrDefault
	|-Nullable<SessionModificationSetJoinInProgressAllowedOptions>.GetValueOrDefault
	|-Nullable<SessionSearchGetSearchResultCountOptions>.GetValueOrDefault
	|-Nullable<SetUserPreLogoutCallbackOptions>.GetValueOrDefault
	|-Nullable<TransactionGetEntitlementsCountOptions>.GetValueOrDefault
	|
	|-RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	|-Nullable<ActiveSessionGetRegisteredPlayerByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyAchievementDefinitionByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyAchievementDefinitionV2ByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyInputDeviceInformationByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyLeaderboardDefinitionByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyLeaderboardRecordByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyOutputDeviceInformationByIndexOptions>.GetValueOrDefault
	|-Nullable<CreateLobbySearchOptions>.GetValueOrDefault
	|-Nullable<CreateSessionSearchOptions>.GetValueOrDefault
	|-Nullable<EndSnapshotOptions>.GetValueOrDefault
	|-Nullable<GetAudioInputDeviceByIndexOptions>.GetValueOrDefault
	|-Nullable<GetAudioOutputDeviceByIndexOptions>.GetValueOrDefault
	|-Nullable<GetProtectMessageOutputLengthOptions>.GetValueOrDefault
	|-Nullable<GetProtectMessageOutputLengthOptions>.GetValueOrDefault
	|-Nullable<int>.GetValueOrDefault
	|-Nullable<Int32Enum>.GetValueOrDefault
	|-Nullable<InventoryItemGetDoubleSetValueByIndexOptions>.GetValueOrDefault
	|-Nullable<InventoryItemGetInt64SetValueByIndexOptions>.GetValueOrDefault
	|-Nullable<InventoryItemGetStringSetValueByIndexOptions>.GetValueOrDefault
	|-Nullable<InventoryItemGetSubItemByIndexOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsCopyAttributeByIndexOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsGetMemberByIndexOptions>.GetValueOrDefault
	|-Nullable<LobbyModificationSetMaxMembersOptions>.GetValueOrDefault
	|-Nullable<LobbyModificationSetPermissionLevelOptions>.GetValueOrDefault
	|-Nullable<LobbySearchCopySearchResultByIndexOptions>.GetValueOrDefault
	|-Nullable<LobbySearchSetMaxResultsOptions>.GetValueOrDefault
	|-Nullable<LogGameRoundEndOptions>.GetValueOrDefault
	|-Nullable<PollStatusOptions>.GetValueOrDefault
	|-Nullable<PresenceModificationSetStatusOptions>.GetValueOrDefault
	|-Nullable<SessionDetailsCopySessionAttributeByIndexOptions>.GetValueOrDefault
	|-Nullable<SessionModificationSetMaxPlayersOptions>.GetValueOrDefault
	|-Nullable<SessionModificationSetPermissionLevelOptions>.GetValueOrDefault
	|-Nullable<SessionSearchCopySearchResultByIndexOptions>.GetValueOrDefault
	|-Nullable<SessionSearchSetMaxResultsOptions>.GetValueOrDefault
	|-Nullable<SetDisplayPreferenceOptions>.GetValueOrDefault
	|-Nullable<SetRelayControlOptions>.GetValueOrDefault
	|-Nullable<SetToggleFriendsButtonOptions>.GetValueOrDefault
	|-Nullable<SetToggleFriendsKeyOptions>.GetValueOrDefault
	|-Nullable<SubmitSnapshotOptions>.GetValueOrDefault
	|-Nullable<TransactionCopyEntitlementByIndexOptions>.GetValueOrDefault
	|-Nullable<uint>.GetValueOrDefault
	|-Nullable<XSXPrePresentAdditionalData>.GetValueOrDefault
	|-Nullable<XboxOneGDKPrePresentAdditionalData>.GetValueOrDefault
	|
	|-RVA: 0x148E810 Offset: 0x148DA10 VA: 0x18148E810
	|-Nullable<ActiveSessionInfo>.GetValueOrDefault
	|
	|-RVA: 0x4A1CF0 Offset: 0x4A0EF0 VA: 0x1804A1CF0
	|-Nullable<ActiveSessionInfoInternal>.GetValueOrDefault
	|-Nullable<BestDisplayName>.GetValueOrDefault
	|-Nullable<CatalogReleaseInternal>.GetValueOrDefault
	|-Nullable<CreateUserCallbackInfo>.GetValueOrDefault
	|-Nullable<Credentials>.GetValueOrDefault
	|-Nullable<CustomInviteRejectedCallbackInfo>.GetValueOrDefault
	|-Nullable<Entitlement>.GetValueOrDefault
	|-Nullable<FileMetadataInternal>.GetValueOrDefault
	|-Nullable<JoinGameAcceptedCallbackInfo>.GetValueOrDefault
	|-Nullable<JoinLobbyByIdOptions>.GetValueOrDefault
	|-Nullable<JoinLobbyOptions>.GetValueOrDefault
	|-Nullable<JoinRoomCallbackInfo>.GetValueOrDefault
	|-Nullable<LobbyInviteAcceptedCallbackInfo>.GetValueOrDefault
	|-Nullable<LobbyInviteRejectedCallbackInfo>.GetValueOrDefault
	|-Nullable<ModIdentifier>.GetValueOrDefault
	|-Nullable<OnCustomInviteAcceptedCallbackInfo>.GetValueOrDefault
	|-Nullable<OnCustomInviteReceivedCallbackInfo>.GetValueOrDefault
	|-Nullable<OnIncomingPacketQueueFullInfo>.GetValueOrDefault
	|-Nullable<PS4SubmitGraphicsCommandsCallbackInfo>.GetValueOrDefault
	|-Nullable<ParticipantUpdatedCallbackInfo>.GetValueOrDefault
	|-Nullable<ParticipantUpdatedCallbackInfo>.GetValueOrDefault
	|-Nullable<PinGrantInfoInternal>.GetValueOrDefault
	|-Nullable<PlayerSanctionInternal>.GetValueOrDefault
	|-Nullable<QueryJoinRoomTokenCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryUserInfoByDisplayNameCallbackInfo>.GetValueOrDefault
	|-Nullable<ReadFileOptions>.GetValueOrDefault
	|-Nullable<ReadFileOptions>.GetValueOrDefault
	|-Nullable<RegisterClientOptions>.GetValueOrDefault
	|-Nullable<SendAudioOptions>.GetValueOrDefault
	|-Nullable<SendPlayerBehaviorReportOptions>.GetValueOrDefault
	|-Nullable<SessionInviteAcceptedCallbackInfo>.GetValueOrDefault
	|-Nullable<SessionInviteRejectedCallbackInfo>.GetValueOrDefault
	|-Nullable<StatInternal>.GetValueOrDefault
	|-Nullable<SteamIAPVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<SwitchIAPVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<UpdateReceivingVolumeCallbackInfo>.GetValueOrDefault
	|-Nullable<UpdateSendingCallbackInfo>.GetValueOrDefault
	|-Nullable<UpdateSendingCallbackInfo>.GetValueOrDefault
	|-Nullable<UpdateSendingVolumeCallbackInfo>.GetValueOrDefault
	|-Nullable<UserPreLogoutCallbackInfo>.GetValueOrDefault
	|-Nullable<WriteFileOptions>.GetValueOrDefault
	|-Nullable<XSXXBLOptions>.GetValueOrDefault
	|-Nullable<XboxOneGDKXBLOptions>.GetValueOrDefault
	|
	|-RVA: 0x4157B0 Offset: 0x4149B0 VA: 0x1804157B0
	|-Nullable<AddNotifyAudioBeforeRenderOptions>.GetValueOrDefault
	|-Nullable<AddProgressionOptions>.GetValueOrDefault
	|-Nullable<AndroidInitializeOptionsSystemInitializeOptions>.GetValueOrDefault
	|-Nullable<AttributeInternal>.GetValueOrDefault
	|-Nullable<AudioInputDeviceInfo>.GetValueOrDefault
	|-Nullable<AudioInputDeviceInfoInternal>.GetValueOrDefault
	|-Nullable<AudioOutputDeviceInfo>.GetValueOrDefault
	|-Nullable<AudioOutputDeviceInfoInternal>.GetValueOrDefault
	|-Nullable<BeginPlayerSessionOptionsAccountId>.GetValueOrDefault
	|-Nullable<CatalogRelease>.GetValueOrDefault
	|-Nullable<CheckoutOptions>.GetValueOrDefault
	|-Nullable<CheckpointOptions>.GetValueOrDefault
	|-Nullable<CloseOptions>.GetValueOrDefault
	|-Nullable<CopyBestDisplayNameWithPlatformOptions>.GetValueOrDefault
	|-Nullable<CopyEntitlementByNameAndIndexOptions>.GetValueOrDefault
	|-Nullable<CopyExternalUserInfoByAccountIdOptions>.GetValueOrDefault
	|-Nullable<CopyExternalUserInfoByAccountTypeOptions>.GetValueOrDefault
	|-Nullable<CopyExternalUserInfoByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyItemImageInfoByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyItemReleaseByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyOfferImageInfoByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyOfferItemByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyPlayerAchievementByAchievementIdOptions>.GetValueOrDefault
	|-Nullable<CopyPlayerAchievementByIndexOptions>.GetValueOrDefault
	|-Nullable<CreateLobbyCallbackInfo>.GetValueOrDefault
	|-Nullable<CreateOptions>.GetValueOrDefault
	|-Nullable<CreatePlayerSanctionAppealCallbackInfo>.GetValueOrDefault
	|-Nullable<CreatePlayerSanctionAppealOptions>.GetValueOrDefault
	|-Nullable<CreateUserCallbackInfo>.GetValueOrDefault
	|-Nullable<CreateUserOptions>.GetValueOrDefault
	|-Nullable<DeleteCacheCallbackInfo>.GetValueOrDefault
	|-Nullable<DeleteCacheCallbackInfo>.GetValueOrDefault
	|-Nullable<DeleteFileCallbackInfo>.GetValueOrDefault
	|-Nullable<DeleteSnapshotCallbackInfo>.GetValueOrDefault
	|-Nullable<DestroyLobbyCallbackInfo>.GetValueOrDefault
	|-Nullable<DuplicateFileCallbackInfo>.GetValueOrDefault
	|-Nullable<DuplicateFileOptions>.GetValueOrDefault
	|-Nullable<EndPlayerSessionOptions>.GetValueOrDefault
	|-Nullable<EndPlayerSessionOptionsAccountId>.GetValueOrDefault
	|-Nullable<FinalizeDeferredUserLogoutOptions>.GetValueOrDefault
	|-Nullable<GetExternalAccountMappingsOptions>.GetValueOrDefault
	|-Nullable<GetProductUserIdMappingOptions>.GetValueOrDefault
	|-Nullable<HideFriendsCallbackInfo>.GetValueOrDefault
	|-Nullable<IOSCredentialsSystemAuthCredentialsOptions>.GetValueOrDefault
	|-Nullable<IdTokenInternal>.GetValueOrDefault
	|-Nullable<IdTokenInternal>.GetValueOrDefault
	|-Nullable<IngestStatOptions>.GetValueOrDefault
	|-Nullable<InputDeviceInformation>.GetValueOrDefault
	|-Nullable<InputDeviceInformationInternal>.GetValueOrDefault
	|-Nullable<JoinLobbyAcceptedCallbackInfo>.GetValueOrDefault
	|-Nullable<JoinLobbyByIdCallbackInfo>.GetValueOrDefault
	|-Nullable<JoinLobbyCallbackInfo>.GetValueOrDefault
	|-Nullable<JoinSessionAcceptedCallbackInfo>.GetValueOrDefault
	|-Nullable<JsonPosition>.GetValueOrDefault
	|-Nullable<KeyImageInfo>.GetValueOrDefault
	|-Nullable<KickMemberCallbackInfo>.GetValueOrDefault
	|-Nullable<KickMemberOptions>.GetValueOrDefault
	|-Nullable<LeaderboardRecord>.GetValueOrDefault
	|-Nullable<LeaderboardUserScoreInternal>.GetValueOrDefault
	|-Nullable<LeaveLobbyCallbackInfo>.GetValueOrDefault
	|-Nullable<LeaveLobbyRequestedCallbackInfo>.GetValueOrDefault
	|-Nullable<LeaveSessionRequestedCallbackInfo>.GetValueOrDefault
	|-Nullable<LinkAccountCallbackInfo>.GetValueOrDefault
	|-Nullable<LinkAccountOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsMemberInfoInternal>.GetValueOrDefault
	|-Nullable<LobbyMemberUpdateReceivedCallbackInfo>.GetValueOrDefault
	|-Nullable<LogEventOptions>.GetValueOrDefault
	|-Nullable<LogMessage>.GetValueOrDefault
	|-Nullable<LogPlayerUseAbilityOptions>.GetValueOrDefault
	|-Nullable<LoginStatusChangedCallbackInfo>.GetValueOrDefault
	|-Nullable<LoginStatusChangedCallbackInfo>.GetValueOrDefault
	|-Nullable<LogoutCallbackInfo>.GetValueOrDefault
	|-Nullable<LogoutCallbackInfo>.GetValueOrDefault
	|-Nullable<ModInfoInternal>.GetValueOrDefault
	|-Nullable<OnAchievementsUnlockedCallbackInfo>.GetValueOrDefault
	|-Nullable<OnClientAuthStatusChangedCallbackInfo>.GetValueOrDefault
	|-Nullable<OnClientIntegrityViolatedCallbackInfo>.GetValueOrDefault
	|-Nullable<OnCreateCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<OnMessageToServerCallbackInfo>.GetValueOrDefault
	|-Nullable<OnOpenCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<OnQueryLeaderboardRanksCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<OnQueryNATTypeCompleteInfo>.GetValueOrDefault
	|-Nullable<OnRegisterPlatformUserCallbackInfo>.GetValueOrDefault
	|-Nullable<OnRequestToJoinAcceptedCallbackInfo>.GetValueOrDefault
	|-Nullable<OnRequestToJoinRejectedCallbackInfo>.GetValueOrDefault
	|-Nullable<OnSetInputDeviceSettingsCallbackInfo>.GetValueOrDefault
	|-Nullable<OnSetOutputDeviceSettingsCallbackInfo>.GetValueOrDefault
	|-Nullable<OnUnregisterPlatformUserCallbackInfo>.GetValueOrDefault
	|-Nullable<OpenOptions>.GetValueOrDefault
	|-Nullable<Options>.GetValueOrDefault
	|-Nullable<OutputDeviceInformation>.GetValueOrDefault
	|-Nullable<OutputDeviceInformationInternal>.GetValueOrDefault
	|-Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.GetValueOrDefault
	|-Nullable<PS4OptionsInitOptions>.GetValueOrDefault
	|-Nullable<PS5IntegratedPlatformOptionsContainerAddOptions>.GetValueOrDefault
	|-Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.GetValueOrDefault
	|-Nullable<PermissionStatusInternal>.GetValueOrDefault
	|-Nullable<PresenceChangedCallbackInfo>.GetValueOrDefault
	|-Nullable<PromoteMemberCallbackInfo>.GetValueOrDefault
	|-Nullable<PromoteMemberOptions>.GetValueOrDefault
	|-Nullable<ProtectMessageOptions>.GetValueOrDefault
	|-Nullable<QueryDefinitionsOptions>.GetValueOrDefault
	|-Nullable<QueryEntitlementsCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryEntitlementsOptions>.GetValueOrDefault
	|-Nullable<QueryExternalAccountMappingsCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryExternalAccountMappingsOptions>.GetValueOrDefault
	|-Nullable<QueryFileCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryFileCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryFriendsCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryInvitesCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryInvitesCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryOffersCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryOwnershipOptions>.GetValueOrDefault
	|-Nullable<QueryOwnershipTokenOptions>.GetValueOrDefault
	|-Nullable<QueryProductUserIdMappingsCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryProductUserIdMappingsOptions>.GetValueOrDefault
	|-Nullable<QueryUserInfoByExternalAccountOptions>.GetValueOrDefault
	|-Nullable<ReceiveMessageFromClientOptions>.GetValueOrDefault
	|-Nullable<ReceiveMessageFromPeerOptions>.GetValueOrDefault
	|-Nullable<RejectInviteCallbackInfo>.GetValueOrDefault
	|-Nullable<RequestPermissionsCallbackInfo>.GetValueOrDefault
	|-Nullable<RequestToJoinReceivedCallbackInfo>.GetValueOrDefault
	|-Nullable<SendInviteCallbackInfo>.GetValueOrDefault
	|-Nullable<SendInviteOptions>.GetValueOrDefault
	|-Nullable<SendInviteOptions>.GetValueOrDefault
	|-Nullable<SessionDetailsAttributeInternal>.GetValueOrDefault
	|-Nullable<SetAudioInputSettingsOptions>.GetValueOrDefault
	|-Nullable<SetAudioOutputSettingsOptions>.GetValueOrDefault
	|-Nullable<SetInputDeviceSettingsOptions>.GetValueOrDefault
	|-Nullable<SetParticipantHardMuteOptions>.GetValueOrDefault
	|-Nullable<SetPresenceCallbackInfo>.GetValueOrDefault
	|-Nullable<SetUserLoginStatusOptions>.GetValueOrDefault
	|-Nullable<ShowFriendsCallbackInfo>.GetValueOrDefault
	|-Nullable<TransferDeviceIdAccountCallbackInfo>.GetValueOrDefault
	|-Nullable<TransferDeviceIdAccountOptions>.GetValueOrDefault
	|-Nullable<UnlinkAccountCallbackInfo>.GetValueOrDefault
	|-Nullable<UnlockedAchievementInternal>.GetValueOrDefault
	|-Nullable<UnprotectMessageOptions>.GetValueOrDefault
	|-Nullable<UnregisterPlayersCallbackInfo>.GetValueOrDefault
	|-Nullable<UpdateLobbyCallbackInfo>.GetValueOrDefault
	|-Nullable<UpdateParentEmailCallbackInfo>.GetValueOrDefault
	|-Nullable<UpdateReceivingVolumeOptions>.GetValueOrDefault
	|-Nullable<UpdateSendingOptions>.GetValueOrDefault
	|-Nullable<UpdateSendingOptions>.GetValueOrDefault
	|-Nullable<UpdateSendingVolumeOptions>.GetValueOrDefault
	|-Nullable<UserTokenInternal>.GetValueOrDefault
	|-Nullable<VerifyIdTokenOptions>.GetValueOrDefault
	|-Nullable<VerifyIdTokenOptions>.GetValueOrDefault
	|-Nullable<WindowsRTCOptions>.GetValueOrDefault
	|-Nullable<XSXMemoryMonitorCallbackInfo>.GetValueOrDefault
	|-Nullable<XSXSubmitGraphicsCommandsCallbackInfo>.GetValueOrDefault
	|-Nullable<XSXXBLOptionsInitOptionsInternal>.GetValueOrDefault
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfo>.GetValueOrDefault
	|-Nullable<XboxOneGDKSubmitGraphicsCommandsCallbackInfo>.GetValueOrDefault
	|-Nullable<XboxOneGDKXBLOptionsInitOptionsInternal>.GetValueOrDefault
	|
	|-RVA: 0x4C16D0 Offset: 0x4C08D0 VA: 0x1804C16D0
	|-Nullable<AddNotifyPeerConnectionClosedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyPeerConnectionEstablishedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyPeerConnectionInterruptedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyPeerConnectionRequestOptions>.GetValueOrDefault
	|-Nullable<AndroidIAPVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<AudioBeforeSendCallbackInfo>.GetValueOrDefault
	|-Nullable<BestDisplayNameInternal>.GetValueOrDefault
	|-Nullable<BlockParticipantCallbackInfo>.GetValueOrDefault
	|-Nullable<CloseConnectionsOptions>.GetValueOrDefault
	|-Nullable<DataReceivedCallbackInfo>.GetValueOrDefault
	|-Nullable<DefinitionInternal>.GetValueOrDefault
	|-Nullable<EGSDLCVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<EGSIAPVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<EntitlementInternal>.GetValueOrDefault
	|-Nullable<ExternalAccountInfoInternal>.GetValueOrDefault
	|-Nullable<IOSIAPVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<JoinRoomOptions>.GetValueOrDefault
	|-Nullable<LoginOptions>.GetValueOrDefault
	|-Nullable<ModIdentifierInternal>.GetValueOrDefault
	|-Nullable<OnAchievementsUnlockedCallbackV2Info>.GetValueOrDefault
	|-Nullable<PS4Options>.GetValueOrDefault
	|-Nullable<PS4PrePresentOptionsPlatformSpecificData>.GetValueOrDefault
	|-Nullable<PS5PrePresentOptionsPlatformSpecificData>.GetValueOrDefault
	|-Nullable<PacketQueueInfo>.GetValueOrDefault
	|-Nullable<PermissionsUpdateReceivedCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryUserInfoByExternalAccountCallbackInfo>.GetValueOrDefault
	|-Nullable<ReadFileDataCallbackInfo>.GetValueOrDefault
	|-Nullable<ReadFileDataCallbackInfo>.GetValueOrDefault
	|-Nullable<RegisterPeerOptions>.GetValueOrDefault
	|-Nullable<SendCustomNativeInviteRequestedCallbackInfo>.GetValueOrDefault
	|-Nullable<SendLobbyNativeInviteRequestedCallbackInfo>.GetValueOrDefault
	|-Nullable<SendSessionNativeInviteRequestedCallbackInfo>.GetValueOrDefault
	|-Nullable<SteamDLCVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<UpdateParticipantVolumeCallbackInfo>.GetValueOrDefault
	|-Nullable<UpdateReceivingCallbackInfo>.GetValueOrDefault
	|-Nullable<UpdateReceivingCallbackInfo>.GetValueOrDefault
	|-Nullable<UserInfoData>.GetValueOrDefault
	|-Nullable<UserLoginStatusChangedCallbackInfo>.GetValueOrDefault
	|-Nullable<XSXDLCVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<XSXIAPVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<XSXIntegratedPlatformOptionsContainerAddOptions>.GetValueOrDefault
	|-Nullable<XboxOneGDKDLCVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<XboxOneGDKIAPVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<XboxOneGDKIntegratedPlatformOptionsContainerAddOptions>.GetValueOrDefault
	|
	|-RVA: 0x148E7A0 Offset: 0x148D9A0 VA: 0x18148E7A0
	|-Nullable<AndroidInitializeOptions>.GetValueOrDefault
	|
	|-RVA: 0xB4BAB0 Offset: 0xB4ACB0 VA: 0x180B4BAB0
	|-Nullable<Announcement>.GetValueOrDefault
	|-Nullable<AttributeData>.GetValueOrDefault
	|-Nullable<AttributeData>.GetValueOrDefault
	|-Nullable<CreateSessionModificationOptions>.GetValueOrDefault
	|-Nullable<IOSCredentials>.GetValueOrDefault
	|-Nullable<InitializeThreadAffinity>.GetValueOrDefault
	|-Nullable<InstallModOptions>.GetValueOrDefault
	|-Nullable<LogPlayerUseWeaponOptions>.GetValueOrDefault
	|-Nullable<LoginOptions>.GetValueOrDefault
	|-Nullable<OnIncomingConnectionRequestInfo>.GetValueOrDefault
	|-Nullable<OnPeerConnectionInterruptedInfo>.GetValueOrDefault
	|-Nullable<PS4DLCVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<PS4IAPVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<PS5DLCVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<PS5IAPVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<Stat>.GetValueOrDefault
	|-Nullable<XSXPrePresentOptions>.GetValueOrDefault
	|-Nullable<XboxOneGDKPrePresentOptions>.GetValueOrDefault
	|
	|-RVA: 0x148E690 Offset: 0x148D890 VA: 0x18148E690
	|-Nullable<Attribute>.GetValueOrDefault
	|-Nullable<CatalogItem>.GetValueOrDefault
	|-Nullable<CreateLobbyOptions>.GetValueOrDefault
	|-Nullable<DefinitionV2>.GetValueOrDefault
	|-Nullable<InfoInternal>.GetValueOrDefault
	|-Nullable<LobbyModificationAddAttributeOptions>.GetValueOrDefault
	|-Nullable<LobbyModificationAddMemberAttributeOptions>.GetValueOrDefault
	|-Nullable<LobbySearchSetParameterOptions>.GetValueOrDefault
	|-Nullable<PS4InitializeOptionsSystemInitializeOptions>.GetValueOrDefault
	|-Nullable<PlayerAchievement>.GetValueOrDefault
	|-Nullable<PlayerAchievementInternal>.GetValueOrDefault
	|-Nullable<SessionDetailsAttribute>.GetValueOrDefault
	|-Nullable<SessionDetailsInfo>.GetValueOrDefault
	|-Nullable<SessionModificationAddAttributeOptions>.GetValueOrDefault
	|-Nullable<SessionSearchSetParameterOptions>.GetValueOrDefault
	|-Nullable<Token>.GetValueOrDefault
	|
	|-RVA: 0x1314850 Offset: 0x1313A50 VA: 0x181314850
	|-Nullable<CatalogItemInternal>.GetValueOrDefault
	|-Nullable<Definition>.GetValueOrDefault
	|-Nullable<DefinitionV2Internal>.GetValueOrDefault
	|-Nullable<IOSLoginOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsInfoInternal>.GetValueOrDefault
	|-Nullable<TokenInternal>.GetValueOrDefault
	|-Nullable<VerifyIdTokenCallbackInfo>.GetValueOrDefault
	|-Nullable<VerifyUserAuthOptions>.GetValueOrDefault
	|
	|-RVA: 0x149CF00 Offset: 0x149C100 VA: 0x18149CF00
	|-Nullable<CatalogOffer>.GetValueOrDefault
	|-Nullable<CatalogOfferInternal>.GetValueOrDefault
	|
	|-RVA: 0x4D1BE0 Offset: 0x4D0DE0 VA: 0x1804D1BE0
	|-Nullable<char>.GetValueOrDefault
	|-Nullable<short>.GetValueOrDefault
	|-Nullable<Int16Enum>.GetValueOrDefault
	|-Nullable<ushort>.GetValueOrDefault
	|-Nullable<UInt16Enum>.GetValueOrDefault
	|
	|-RVA: 0x789960 Offset: 0x788B60 VA: 0x180789960
	|-Nullable<Color>.GetValueOrDefault
	|-Nullable<Guid>.GetValueOrDefault
	|-Nullable<Quat>.GetValueOrDefault
	|-Nullable<QuatInternal>.GetValueOrDefault
	|-Nullable<Rect>.GetValueOrDefault
	|-Nullable<SentryId>.GetValueOrDefault
	|
	|-RVA: 0xB4BB00 Offset: 0xB4AD00 VA: 0x180B4BB00
	|-Nullable<CopyUserTokenByIndexOptions>.GetValueOrDefault
	|-Nullable<DesktopCrossplayStatusInfo>.GetValueOrDefault
	|-Nullable<LocalRTCOptions>.GetValueOrDefault
	|-Nullable<PS5OptionsInitOptionsInternal>.GetValueOrDefault
	|-Nullable<PageQuery>.GetValueOrDefault
	|-Nullable<XSXPrePresentAdditionalDataInternal>.GetValueOrDefault
	|-Nullable<XboxOneGDKPrePresentAdditionalDataInternal>.GetValueOrDefault
	|
	|-RVA: 0x14AD0E0 Offset: 0x14AC2E0 VA: 0x1814AD0E0
	|-Nullable<Definition>.GetValueOrDefault
	|-Nullable<Info>.GetValueOrDefault
	|-Nullable<InstallModCallbackInfo>.GetValueOrDefault
	|-Nullable<LinkAccountCallbackInfo>.GetValueOrDefault
	|-Nullable<LogPlayerTickOptions>.GetValueOrDefault
	|-Nullable<OnPeerConnectionEstablishedInfo>.GetValueOrDefault
	|-Nullable<OnRemoteConnectionClosedInfo>.GetValueOrDefault
	|-Nullable<PS5InitializeOptionsSystemInitializeOptions>.GetValueOrDefault
	|-Nullable<QueryLeaderboardUserScoresOptions>.GetValueOrDefault
	|-Nullable<QueryStatsOptions>.GetValueOrDefault
	|-Nullable<UninstallModCallbackInfo>.GetValueOrDefault
	|-Nullable<UpdateModCallbackInfo>.GetValueOrDefault
	|
	|-RVA: 0x14AD0A0 Offset: 0x14AC2A0 VA: 0x1814AD0A0
	|-Nullable<DefinitionInternal>.GetValueOrDefault
	|-Nullable<LoginCallbackInfo>.GetValueOrDefault
	|-Nullable<SendPacketOptions>.GetValueOrDefault
	|-Nullable<VerifyIdTokenCallbackInfo>.GetValueOrDefault
	|
	|-RVA: 0x44F1E0 Offset: 0x44E3E0 VA: 0x18044F1E0
	|-Nullable<double>.GetValueOrDefault
	|
	|-RVA: 0x14BCB60 Offset: 0x14BBD60 VA: 0x1814BCB60
	|-Nullable<InitializeOptions>.GetValueOrDefault
	|
	|-RVA: 0x14CB870 Offset: 0x14CAA70 VA: 0x1814CB870
	|-Nullable<LogEventParamPair>.GetValueOrDefault
	|-Nullable<LogEventParamPairParamValue>.GetValueOrDefault
	|
	|-RVA: 0x14CB960 Offset: 0x14CAB60 VA: 0x1814CB960
	|-Nullable<LogPlayerTakeDamageOptions>.GetValueOrDefault
	|
	|-RVA: 0x14DBD70 Offset: 0x14DAF70 VA: 0x1814DBD70
	|-Nullable<Options>.GetValueOrDefault
	|
	|-RVA: 0x14DBE00 Offset: 0x14DB000 VA: 0x1814DBE00
	|-Nullable<PS4InitializeOptions>.GetValueOrDefault
	|
	|-RVA: 0x14DBEA0 Offset: 0x14DB0A0 VA: 0x1814DBEA0
	|-Nullable<PS5InitializeOptions>.GetValueOrDefault
	|
	|-RVA: 0x14DBE80 Offset: 0x14DB080 VA: 0x1814DBE80
	|-Nullable<PageResult>.GetValueOrDefault
	|-Nullable<Token>.GetValueOrDefault
	|-Nullable<Vec3f>.GetValueOrDefault
	|-Nullable<Vec3fInternal>.GetValueOrDefault
	|-Nullable<Vector3>.GetValueOrDefault
	|
	|-RVA: 0x14ECA40 Offset: 0x14EBC40 VA: 0x1814ECA40
	|-Nullable<RectInternal>.GetValueOrDefault
	|
	|-RVA: 0x1314810 Offset: 0x1313A10 VA: 0x181314810
	|-Nullable<ReportInputStateOptions>.GetValueOrDefault
	|
	|-RVA: 0x13147C0 Offset: 0x13139C0 VA: 0x1813147C0
	|-Nullable<SequencePoint>.GetValueOrDefault
	|
	|-RVA: 0x14FC130 Offset: 0x14FB330 VA: 0x1814FC130
	|-Nullable<SetPortRangeOptions>.GetValueOrDefault
	|
	|-RVA: 0x439FB0 Offset: 0x4391B0 VA: 0x180439FB0
	|-Nullable<float>.GetValueOrDefault
	|
	|-RVA: 0x150BD70 Offset: 0x150AF70 VA: 0x18150BD70
	|-Nullable<Touch>.GetValueOrDefault
	|
	|-RVA: 0x774F90 Offset: 0x774190 VA: 0x180774F90
	|-Nullable<Vector2>.GetValueOrDefault
	|
	|-RVA: 0xB4B780 Offset: 0xB4A980 VA: 0x180B4B780
	|-Nullable<WindowsOptions>.GetValueOrDefault
	|-Nullable<XSXOptions>.GetValueOrDefault
	|-Nullable<XboxOneGDKOptions>.GetValueOrDefault
	|
	|-RVA: 0xB4BC40 Offset: 0xB4AE40 VA: 0x180B4BC40
	|-Nullable<XSXInitializeOptions>.GetValueOrDefault
	|-Nullable<XboxOneGDKInitializeOptions>.GetValueOrDefault
	|
	|-RVA: 0xB4BDA0 Offset: 0xB4AFA0 VA: 0x180B4BDA0
	|-Nullable<__Il2CppFullySharedGenericStructType>.GetValueOrDefault
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public T GetValueOrDefault(T defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB4B980 Offset: 0xB4AB80 VA: 0x180B4B980
	|-Nullable<ArraySegment<byte>>.GetValueOrDefault
	|-Nullable<ValueTuple<object, object>>.GetValueOrDefault
	|-Nullable<AcceptInviteOptions>.GetValueOrDefault
	|-Nullable<AcceptRequestToJoinOptions>.GetValueOrDefault
	|-Nullable<AccountFeatureRestrictedInfoInternal>.GetValueOrDefault
	|-Nullable<AcknowledgeEventIdOptions>.GetValueOrDefault
	|-Nullable<AddNotifyAudioBeforeSendOptions>.GetValueOrDefault
	|-Nullable<AddNotifyAudioInputStateOptions>.GetValueOrDefault
	|-Nullable<AddNotifyAudioOutputStateOptions>.GetValueOrDefault
	|-Nullable<AddNotifyDataReceivedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyDisconnectedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyParticipantStatusChangedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyParticipantUpdatedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyParticipantUpdatedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyRTCRoomConnectionChangedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyRoomStatisticsUpdatedOptions>.GetValueOrDefault
	|-Nullable<AndroidIAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<AudioBuffer>.GetValueOrDefault
	|-Nullable<AuthExpirationCallbackInfo>.GetValueOrDefault
	|-Nullable<BeginSessionOptions>.GetValueOrDefault
	|-Nullable<BigInteger>.GetValueOrDefault
	|-Nullable<ClientCredentials>.GetValueOrDefault
	|-Nullable<CopyBestDisplayNameOptions>.GetValueOrDefault
	|-Nullable<CopyEntitlementByIdOptions>.GetValueOrDefault
	|-Nullable<CopyEntitlementByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyFileMetadataAtIndexOptions>.GetValueOrDefault
	|-Nullable<CopyFileMetadataAtIndexOptions>.GetValueOrDefault
	|-Nullable<CopyFileMetadataByFilenameOptions>.GetValueOrDefault
	|-Nullable<CopyFileMetadataByFilenameOptions>.GetValueOrDefault
	|-Nullable<CopyItemByIdOptions>.GetValueOrDefault
	|-Nullable<CopyLastRedeemedEntitlementByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyLeaderboardUserScoreByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyLeaderboardUserScoreByUserIdOptions>.GetValueOrDefault
	|-Nullable<CopyLobbyDetailsHandleOptions>.GetValueOrDefault
	|-Nullable<CopyModInfoOptions>.GetValueOrDefault
	|-Nullable<CopyOfferByIdOptions>.GetValueOrDefault
	|-Nullable<CopyOfferByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyPermissionByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyPlayerSanctionByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyPresenceOptions>.GetValueOrDefault
	|-Nullable<CopyProductUserExternalAccountByAccountIdOptions>.GetValueOrDefault
	|-Nullable<CopyProductUserExternalAccountByAccountTypeOptions>.GetValueOrDefault
	|-Nullable<CopyProductUserExternalAccountByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyStatByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyStatByNameOptions>.GetValueOrDefault
	|-Nullable<CopyTransactionByIdOptions>.GetValueOrDefault
	|-Nullable<CopyTransactionByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyUnlockedAchievementByAchievementIdOptions>.GetValueOrDefault
	|-Nullable<CopyUnlockedAchievementByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyUserInfoOptions>.GetValueOrDefault
	|-Nullable<CopyUserTokenByUserIdOptions>.GetValueOrDefault
	|-Nullable<CreateDeviceIdCallbackInfo>.GetValueOrDefault
	|-Nullable<Credentials>.GetValueOrDefault
	|-Nullable<DataRecord>.GetValueOrDefault
	|-Nullable<DateTimeOffset>.GetValueOrDefault
	|-Nullable<Decimal>.GetValueOrDefault
	|-Nullable<DeleteDeviceIdCallbackInfo>.GetValueOrDefault
	|-Nullable<DeleteFileOptions>.GetValueOrDefault
	|-Nullable<DeletePersistentAuthCallbackInfo>.GetValueOrDefault
	|-Nullable<DestroyLobbyOptions>.GetValueOrDefault
	|-Nullable<DestroySessionCallbackInfo>.GetValueOrDefault
	|-Nullable<EGSDLCVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<EGSIAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<EndSessionCallbackInfo>.GetValueOrDefault
	|-Nullable<EnumerateModsOptions>.GetValueOrDefault
	|-Nullable<GetBlockedUserAtIndexOptions>.GetValueOrDefault
	|-Nullable<GetConnectStringOptions>.GetValueOrDefault
	|-Nullable<GetEntitlementsByNameCountOptions>.GetValueOrDefault
	|-Nullable<GetExternalUserInfoCountOptions>.GetValueOrDefault
	|-Nullable<GetFriendAtIndexOptions>.GetValueOrDefault
	|-Nullable<GetInviteIdByIndexOptions>.GetValueOrDefault
	|-Nullable<GetInviteIdByIndexOptions>.GetValueOrDefault
	|-Nullable<GetItemImageInfoCountOptions>.GetValueOrDefault
	|-Nullable<GetItemReleaseCountOptions>.GetValueOrDefault
	|-Nullable<GetJoinInfoOptions>.GetValueOrDefault
	|-Nullable<GetNextReceivedPacketSizeOptions>.GetValueOrDefault
	|-Nullable<GetOfferImageInfoCountOptions>.GetValueOrDefault
	|-Nullable<GetOfferItemCountOptions>.GetValueOrDefault
	|-Nullable<GetPermissionByKeyOptions>.GetValueOrDefault
	|-Nullable<GetRTCRoomNameOptions>.GetValueOrDefault
	|-Nullable<GetStatusOptions>.GetValueOrDefault
	|-Nullable<HasPresenceOptions>.GetValueOrDefault
	|-Nullable<IOSIAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<IdToken>.GetValueOrDefault
	|-Nullable<IdToken>.GetValueOrDefault
	|-Nullable<IngestData>.GetValueOrDefault
	|-Nullable<IsRTCRoomConnectedOptions>.GetValueOrDefault
	|-Nullable<IsUserInSessionOptions>.GetValueOrDefault
	|-Nullable<ItemOwnership>.GetValueOrDefault
	|-Nullable<JoinSessionCallbackInfo>.GetValueOrDefault
	|-Nullable<JsonElement>.GetValueOrDefault
	|-Nullable<KickCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<KickOptions>.GetValueOrDefault
	|-Nullable<LeaderboardUserScore>.GetValueOrDefault
	|-Nullable<LeaveLobbyOptions>.GetValueOrDefault
	|-Nullable<LeaveRoomOptions>.GetValueOrDefault
	|-Nullable<LinkAccountOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsCopyMemberAttributeByIndexOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsCopyMemberAttributeByKeyOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsMemberInfo>.GetValueOrDefault
	|-Nullable<LobbySearchFindCallbackInfo>.GetValueOrDefault
	|-Nullable<LobbySearchRemoveParameterOptions>.GetValueOrDefault
	|-Nullable<LobbyUpdateReceivedCallbackInfo>.GetValueOrDefault
	|-Nullable<LocalDefinition>.GetValueOrDefault
	|-Nullable<LogPlayerReviveOptions>.GetValueOrDefault
	|-Nullable<LogPlayerSpawnOptions>.GetValueOrDefault
	|-Nullable<MemoryMonitorCallbackInfo>.GetValueOrDefault
	|-Nullable<ModInfo>.GetValueOrDefault
	|-Nullable<OnCheckpointCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<OnCloseCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<OnDisplaySettingsUpdatedCallbackInfo>.GetValueOrDefault
	|-Nullable<OnQueryDefinitionsCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<OnQueryInputDevicesInformationCallbackInfo>.GetValueOrDefault
	|-Nullable<OnQueryLeaderboardDefinitionsCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<OnQueryLeaderboardUserScoresCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<OnQueryOutputDevicesInformationCallbackInfo>.GetValueOrDefault
	|-Nullable<Option>.GetValueOrDefault
	|-Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReport>.GetValueOrDefault
	|-Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReport>.GetValueOrDefault
	|-Nullable<PS5Options>.GetValueOrDefault
	|-Nullable<ParticipantMetadata>.GetValueOrDefault
	|-Nullable<PermissionStatus>.GetValueOrDefault
	|-Nullable<PlayerStatInfo>.GetValueOrDefault
	|-Nullable<QueryActivePlayerSanctionsOptions>.GetValueOrDefault
	|-Nullable<QueryEntitlementTokenOptions>.GetValueOrDefault
	|-Nullable<QueryFileListOptions>.GetValueOrDefault
	|-Nullable<QueryFileOptions>.GetValueOrDefault
	|-Nullable<QueryFileOptions>.GetValueOrDefault
	|-Nullable<QueryIdTokenOptions>.GetValueOrDefault
	|-Nullable<QueryLeaderboardRanksOptions>.GetValueOrDefault
	|-Nullable<QueryOffersOptions>.GetValueOrDefault
	|-Nullable<QueryOwnershipBySandboxIdsOptions>.GetValueOrDefault
	|-Nullable<QueryPlayerAchievementsOptions>.GetValueOrDefault
	|-Nullable<QueryPresenceOptions>.GetValueOrDefault
	|-Nullable<QueryUserInfoByDisplayNameOptions>.GetValueOrDefault
	|-Nullable<QueryUserInfoOptions>.GetValueOrDefault
	|-Nullable<RTCOptions>.GetValueOrDefault
	|-Nullable<ReceiveMessageFromServerOptions>.GetValueOrDefault
	|-Nullable<RedeemEntitlementsOptions>.GetValueOrDefault
	|-Nullable<RegexPrefix>.GetValueOrDefault
	|-Nullable<RegisterEventParamDef>.GetValueOrDefault
	|-Nullable<RegisterPlayersOptions>.GetValueOrDefault
	|-Nullable<RejectInviteCallbackInfo>.GetValueOrDefault
	|-Nullable<RejectInviteOptions>.GetValueOrDefault
	|-Nullable<RejectInviteOptions>.GetValueOrDefault
	|-Nullable<RejectInviteOptions>.GetValueOrDefault
	|-Nullable<RejectRequestToJoinOptions>.GetValueOrDefault
	|-Nullable<RequestPermissionsOptions>.GetValueOrDefault
	|-Nullable<SandboxIdItemOwnership>.GetValueOrDefault
	|-Nullable<SendCustomInviteOptions>.GetValueOrDefault
	|-Nullable<SendInviteCallbackInfo>.GetValueOrDefault
	|-Nullable<SendInviteOptions>.GetValueOrDefault
	|-Nullable<SendPlayerBehaviorReportCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<SendRequestToJoinOptions>.GetValueOrDefault
	|-Nullable<SessionSearchFindCallbackInfo>.GetValueOrDefault
	|-Nullable<SessionSearchRemoveParameterOptions>.GetValueOrDefault
	|-Nullable<SetClientDetailsOptions>.GetValueOrDefault
	|-Nullable<SetClientNetworkStateOptions>.GetValueOrDefault
	|-Nullable<SetCustomInviteOptions>.GetValueOrDefault
	|-Nullable<SetOutputDeviceSettingsOptions>.GetValueOrDefault
	|-Nullable<SetPacketQueueSizeOptions>.GetValueOrDefault
	|-Nullable<SetParticipantHardMuteCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<SetPresenceOptions>.GetValueOrDefault
	|-Nullable<SetSettingOptions>.GetValueOrDefault
	|-Nullable<ShowBlockPlayerOptions>.GetValueOrDefault
	|-Nullable<ShowNativeProfileOptions>.GetValueOrDefault
	|-Nullable<ShowReportPlayerOptions>.GetValueOrDefault
	|-Nullable<SocketIdInternal>.GetValueOrDefault
	|-Nullable<StartSessionCallbackInfo>.GetValueOrDefault
	|-Nullable<StatThresholds>.GetValueOrDefault
	|-Nullable<SteamDLCVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<StreamingContext>.GetValueOrDefault
	|-Nullable<SubmitSnapshotCallbackInfo>.GetValueOrDefault
	|-Nullable<UnlockAchievementsOptions>.GetValueOrDefault
	|-Nullable<UnregisterPlayersOptions>.GetValueOrDefault
	|-Nullable<UpdateLobbyModificationOptions>.GetValueOrDefault
	|-Nullable<UpdateParentEmailOptions>.GetValueOrDefault
	|-Nullable<UserLoginInfo>.GetValueOrDefault
	|-Nullable<UserScoresQueryStatInfo>.GetValueOrDefault
	|-Nullable<UserToken>.GetValueOrDefault
	|-Nullable<VerifyPurchaseCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<VerifyUserAuthCallbackInfo>.GetValueOrDefault
	|-Nullable<WindowsRTCOptionsPlatformSpecificOptionsInternal>.GetValueOrDefault
	|-Nullable<XSXDLCVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<XSXIAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.GetValueOrDefault
	|-Nullable<XSXSubmitGraphicsCommandsDataCommand>.GetValueOrDefault
	|-Nullable<XSXXBLOptionsInitOptions>.GetValueOrDefault
	|-Nullable<XboxOneGDKDLCVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<XboxOneGDKIAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.GetValueOrDefault
	|-Nullable<XboxOneGDKSubmitGraphicsCommandsDataCommand>.GetValueOrDefault
	|-Nullable<XboxOneGDKXBLOptionsInitOptions>.GetValueOrDefault
	|
	|-RVA: 0xB4BA60 Offset: 0xB4AC60 VA: 0x180B4BA60
	|-Nullable<AcceptConnectionOptions>.GetValueOrDefault
	|-Nullable<AttributeDataValue>.GetValueOrDefault
	|-Nullable<AttributeDataValue>.GetValueOrDefault
	|-Nullable<AudioBeforeRenderCallbackInfo>.GetValueOrDefault
	|-Nullable<BeginPlayerSessionOptions>.GetValueOrDefault
	|-Nullable<ClearPacketQueueOptions>.GetValueOrDefault
	|-Nullable<CloseConnectionOptions>.GetValueOrDefault
	|-Nullable<ExternalAccountInfo>.GetValueOrDefault
	|-Nullable<FileMetadata>.GetValueOrDefault
	|-Nullable<LobbyDetailsInfo>.GetValueOrDefault
	|-Nullable<LogPlayerUseWeaponData>.GetValueOrDefault
	|-Nullable<PS4IntegratedPlatformOptionsContainerAddOptions>.GetValueOrDefault
	|-Nullable<PS4PrePresentOptions>.GetValueOrDefault
	|-Nullable<PS5PrePresentOptions>.GetValueOrDefault
	|-Nullable<ParticipantStatusChangedCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryLeaderboardDefinitionsOptions>.GetValueOrDefault
	|-Nullable<QueryPermissionsCallbackInfo>.GetValueOrDefault
	|-Nullable<SessionDetailsInfoInternal>.GetValueOrDefault
	|-Nullable<SessionDetailsSettingsInternal>.GetValueOrDefault
	|-Nullable<UninstallModOptions>.GetValueOrDefault
	|-Nullable<UpdateModOptions>.GetValueOrDefault
	|-Nullable<UserInfoDataInternal>.GetValueOrDefault
	|-Nullable<XSXInitializeOptionsSystemInitializeOptions>.GetValueOrDefault
	|-Nullable<XSXPrePresentOptionsPlatformSpecificData>.GetValueOrDefault
	|-Nullable<XboxOneGDKInitializeOptionsSystemInitializeOptions>.GetValueOrDefault
	|-Nullable<XboxOneGDKPrePresentOptionsPlatformSpecificData>.GetValueOrDefault
	|
	|-RVA: 0xB4BA30 Offset: 0xB4AC30 VA: 0x180B4BA30
	|-Nullable<AcceptInviteCallbackInfo>.GetValueOrDefault
	|-Nullable<AcceptRequestToJoinCallbackInfo>.GetValueOrDefault
	|-Nullable<AttributeDataInternal>.GetValueOrDefault
	|-Nullable<AttributeDataInternal>.GetValueOrDefault
	|-Nullable<AudioBufferInternal>.GetValueOrDefault
	|-Nullable<AudioInputStateCallbackInfo>.GetValueOrDefault
	|-Nullable<AudioOutputStateCallbackInfo>.GetValueOrDefault
	|-Nullable<BeginSessionOptions>.GetValueOrDefault
	|-Nullable<BlockParticipantOptions>.GetValueOrDefault
	|-Nullable<CheckoutCallbackInfo>.GetValueOrDefault
	|-Nullable<DisconnectedCallbackInfo>.GetValueOrDefault
	|-Nullable<EnumerateModsCallbackInfo>.GetValueOrDefault
	|-Nullable<ExternalUserInfo>.GetValueOrDefault
	|-Nullable<ExternalUserInfoInternal>.GetValueOrDefault
	|-Nullable<FileMetadata>.GetValueOrDefault
	|-Nullable<FileMetadataInternal>.GetValueOrDefault
	|-Nullable<FileTransferProgressCallbackInfo>.GetValueOrDefault
	|-Nullable<FileTransferProgressCallbackInfo>.GetValueOrDefault
	|-Nullable<FinalizeInviteOptions>.GetValueOrDefault
	|-Nullable<HardMuteMemberCallbackInfo>.GetValueOrDefault
	|-Nullable<HardMuteMemberOptions>.GetValueOrDefault
	|-Nullable<IOSCredentialsSystemAuthCredentialsOptionsInternal>.GetValueOrDefault
	|-Nullable<IngestStatCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<IntegratedPlatformOptionsContainerAddOptions>.GetValueOrDefault
	|-Nullable<JoinSessionOptions>.GetValueOrDefault
	|-Nullable<KeyImageInfoInternal>.GetValueOrDefault
	|-Nullable<LeaderboardRecordInternal>.GetValueOrDefault
	|-Nullable<LeaveRoomCallbackInfo>.GetValueOrDefault
	|-Nullable<LobbyInviteReceivedCallbackInfo>.GetValueOrDefault
	|-Nullable<LobbyMemberStatusReceivedCallbackInfo>.GetValueOrDefault
	|-Nullable<LogGameRoundStartOptions>.GetValueOrDefault
	|-Nullable<LoginCallbackInfo>.GetValueOrDefault
	|-Nullable<OnBlockedUsersUpdateInfo>.GetValueOrDefault
	|-Nullable<OnClientActionRequiredCallbackInfo>.GetValueOrDefault
	|-Nullable<OnFriendsUpdateInfo>.GetValueOrDefault
	|-Nullable<OnMessageToClientCallbackInfo>.GetValueOrDefault
	|-Nullable<OnQueryPlayerAchievementsCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<OnQueryStatsCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<OnShowBlockPlayerCallbackInfo>.GetValueOrDefault
	|-Nullable<OnShowReportPlayerCallbackInfo>.GetValueOrDefault
	|-Nullable<OnUnlockAchievementsCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<PS4DLCVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<PS4IAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<PS4MemoryMonitorCallbackInfo>.GetValueOrDefault
	|-Nullable<PS4OptionsInitOptionsInternal>.GetValueOrDefault
	|-Nullable<PS5DLCVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<PS5IAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<PS5MemoryMonitorCallbackInfo>.GetValueOrDefault
	|-Nullable<PS5SubmitGraphicsCommandsCallbackInfo>.GetValueOrDefault
	|-Nullable<PinGrantInfo>.GetValueOrDefault
	|-Nullable<PlayerSanction>.GetValueOrDefault
	|-Nullable<ProtectMessageOptions>.GetValueOrDefault
	|-Nullable<QueryActivePlayerSanctionsCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryAgeGateCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryEntitlementTokenCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryFileListCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryFileListCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryIdTokenCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryJoinRoomTokenOptions>.GetValueOrDefault
	|-Nullable<QueryOwnershipBySandboxIdsCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryOwnershipCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryOwnershipTokenCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryPresenceCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryUserInfoCallbackInfo>.GetValueOrDefault
	|-Nullable<RTCRoomConnectionChangedCallbackInfo>.GetValueOrDefault
	|-Nullable<ReadFileCallbackInfo>.GetValueOrDefault
	|-Nullable<ReadFileCallbackInfo>.GetValueOrDefault
	|-Nullable<RedeemEntitlementsCallbackInfo>.GetValueOrDefault
	|-Nullable<RegisterEventOptions>.GetValueOrDefault
	|-Nullable<RegisterPlayersCallbackInfo>.GetValueOrDefault
	|-Nullable<RejectInviteCallbackInfo>.GetValueOrDefault
	|-Nullable<RejectRequestToJoinCallbackInfo>.GetValueOrDefault
	|-Nullable<RequestToJoinResponseReceivedCallbackInfo>.GetValueOrDefault
	|-Nullable<RoomStatisticsUpdatedInfo>.GetValueOrDefault
	|-Nullable<SendCustomInviteCallbackInfo>.GetValueOrDefault
	|-Nullable<SendDataOptions>.GetValueOrDefault
	|-Nullable<SendInviteCallbackInfo>.GetValueOrDefault
	|-Nullable<SendRequestToJoinCallbackInfo>.GetValueOrDefault
	|-Nullable<SessionDetailsSettings>.GetValueOrDefault
	|-Nullable<SessionInviteReceivedCallbackInfo>.GetValueOrDefault
	|-Nullable<SetRoomSettingOptions>.GetValueOrDefault
	|-Nullable<ShowNativeProfileCallbackInfo>.GetValueOrDefault
	|-Nullable<SocketId>.GetValueOrDefault
	|-Nullable<SteamOptions>.GetValueOrDefault
	|-Nullable<UnlockedAchievement>.GetValueOrDefault
	|-Nullable<UnprotectMessageOptions>.GetValueOrDefault
	|-Nullable<UpdateParticipantVolumeOptions>.GetValueOrDefault
	|-Nullable<UpdateReceivingOptions>.GetValueOrDefault
	|-Nullable<UpdateReceivingOptions>.GetValueOrDefault
	|-Nullable<UpdateSessionCallbackInfo>.GetValueOrDefault
	|-Nullable<VerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<WriteFileCallbackInfo>.GetValueOrDefault
	|-Nullable<WriteFileDataCallbackInfo>.GetValueOrDefault
	|
	|-RVA: 0xB4B800 Offset: 0xB4AA00 VA: 0x180B4B800
	|-Nullable<AccountFeatureRestrictedInfo>.GetValueOrDefault
	|-Nullable<AddExternalIntegrityCatalogOptions>.GetValueOrDefault
	|-Nullable<AudioDevicesChangedCallbackInfo>.GetValueOrDefault
	|-Nullable<BeginSnapshotOptions>.GetValueOrDefault
	|-Nullable<CheckoutEntry>.GetValueOrDefault
	|-Nullable<CopyAchievementDefinitionByAchievementIdOptions>.GetValueOrDefault
	|-Nullable<CopyAchievementDefinitionV2ByAchievementIdOptions>.GetValueOrDefault
	|-Nullable<CopyActiveSessionHandleOptions>.GetValueOrDefault
	|-Nullable<CopyIdTokenOptions>.GetValueOrDefault
	|-Nullable<CopyIdTokenOptions>.GetValueOrDefault
	|-Nullable<CopyLeaderboardDefinitionByLeaderboardIdOptions>.GetValueOrDefault
	|-Nullable<CopyLeaderboardRecordByUserIdOptions>.GetValueOrDefault
	|-Nullable<CopyLobbyDetailsHandleByInviteIdOptions>.GetValueOrDefault
	|-Nullable<CopyLobbyDetailsHandleByUiEventIdOptions>.GetValueOrDefault
	|-Nullable<CopyProductUserInfoOptions>.GetValueOrDefault
	|-Nullable<CopySessionHandleByInviteIdOptions>.GetValueOrDefault
	|-Nullable<CopySessionHandleByUiEventIdOptions>.GetValueOrDefault
	|-Nullable<CopySessionHandleForPresenceOptions>.GetValueOrDefault
	|-Nullable<CreateDeviceIdOptions>.GetValueOrDefault
	|-Nullable<CreatePresenceModificationOptions>.GetValueOrDefault
	|-Nullable<CreateUserOptions>.GetValueOrDefault
	|-Nullable<DataKey>.GetValueOrDefault
	|-Nullable<DateTime>.GetValueOrDefault
	|-Nullable<DeleteCacheOptions>.GetValueOrDefault
	|-Nullable<DeleteCacheOptions>.GetValueOrDefault
	|-Nullable<DeletePersistentAuthOptions>.GetValueOrDefault
	|-Nullable<DeleteSnapshotOptions>.GetValueOrDefault
	|-Nullable<DestroySessionOptions>.GetValueOrDefault
	|-Nullable<DumpSessionStateOptions>.GetValueOrDefault
	|-Nullable<EndSessionOptions>.GetValueOrDefault
	|-Nullable<EventDispatcherGate>.GetValueOrDefault
	|-Nullable<GCHandle>.GetValueOrDefault
	|-Nullable<GetBlockedUsersCountOptions>.GetValueOrDefault
	|-Nullable<GetEntitlementsCountOptions>.GetValueOrDefault
	|-Nullable<GetFileMetadataCountOptions>.GetValueOrDefault
	|-Nullable<GetFileMetadataCountOptions>.GetValueOrDefault
	|-Nullable<GetFriendsCountOptions>.GetValueOrDefault
	|-Nullable<GetFriendsExclusiveInputOptions>.GetValueOrDefault
	|-Nullable<GetFriendsVisibleOptions>.GetValueOrDefault
	|-Nullable<GetInviteCountOptions>.GetValueOrDefault
	|-Nullable<GetInviteCountOptions>.GetValueOrDefault
	|-Nullable<GetLastRedeemedEntitlementsCountOptions>.GetValueOrDefault
	|-Nullable<GetLeaderboardUserScoreCountOptions>.GetValueOrDefault
	|-Nullable<GetOfferCountOptions>.GetValueOrDefault
	|-Nullable<GetPermissionsCountOptions>.GetValueOrDefault
	|-Nullable<GetPlayerAchievementCountOptions>.GetValueOrDefault
	|-Nullable<GetPlayerSanctionCountOptions>.GetValueOrDefault
	|-Nullable<GetProductUserExternalAccountCountOptions>.GetValueOrDefault
	|-Nullable<GetStatCountOptions>.GetValueOrDefault
	|-Nullable<GetTransactionCountOptions>.GetValueOrDefault
	|-Nullable<GetUnlockedAchievementCountOptions>.GetValueOrDefault
	|-Nullable<HideFriendsOptions>.GetValueOrDefault
	|-Nullable<long>.GetValueOrDefault
	|-Nullable<IntPtr>.GetValueOrDefault
	|-Nullable<InventoryItemCreateSubItemOptions>.GetValueOrDefault
	|-Nullable<InventoryItemDeleteSubItemOptions>.GetValueOrDefault
	|-Nullable<InventoryItemGetSubItemOptions>.GetValueOrDefault
	|-Nullable<InventoryItemSetKeyOptions>.GetValueOrDefault
	|-Nullable<InventoryItemSetValueAsDoubleOptions>.GetValueOrDefault
	|-Nullable<InventoryItemSetValueAsDoubleSetOptions>.GetValueOrDefault
	|-Nullable<InventoryItemSetValueAsInt64Options>.GetValueOrDefault
	|-Nullable<InventoryItemSetValueAsInt64SetOptions>.GetValueOrDefault
	|-Nullable<InventoryItemSetValueAsStringOptions>.GetValueOrDefault
	|-Nullable<InventoryItemSetValueAsStringSetOptions>.GetValueOrDefault
	|-Nullable<InventoryItemSetValueAsTimestampOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsCopyAttributeByKeyOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsCopyMemberInfoOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsGetMemberAttributeCountOptions>.GetValueOrDefault
	|-Nullable<LobbyModificationRemoveAttributeOptions>.GetValueOrDefault
	|-Nullable<LobbyModificationRemoveMemberAttributeOptions>.GetValueOrDefault
	|-Nullable<LobbyModificationSetAllowedPlatformIdsOptions>.GetValueOrDefault
	|-Nullable<LobbyModificationSetBucketIdOptions>.GetValueOrDefault
	|-Nullable<LobbySearchFindOptions>.GetValueOrDefault
	|-Nullable<LobbySearchSetLobbyIdOptions>.GetValueOrDefault
	|-Nullable<LobbySearchSetTargetUserIdOptions>.GetValueOrDefault
	|-Nullable<LogPlayerDespawnOptions>.GetValueOrDefault
	|-Nullable<LogoutOptions>.GetValueOrDefault
	|-Nullable<LogoutOptions>.GetValueOrDefault
	|-Nullable<ParseConnectStringOptions>.GetValueOrDefault
	|-Nullable<PrePresentOptions>.GetValueOrDefault
	|-Nullable<PresenceModificationDataRecordId>.GetValueOrDefault
	|-Nullable<PresenceModificationDeleteDataOptions>.GetValueOrDefault
	|-Nullable<PresenceModificationSetDataOptions>.GetValueOrDefault
	|-Nullable<PresenceModificationSetJoinInfoOptions>.GetValueOrDefault
	|-Nullable<PresenceModificationSetRawRichTextOptions>.GetValueOrDefault
	|-Nullable<QueryFileListOptions>.GetValueOrDefault
	|-Nullable<QueryFriendsOptions>.GetValueOrDefault
	|-Nullable<QueryInvitesOptions>.GetValueOrDefault
	|-Nullable<QueryInvitesOptions>.GetValueOrDefault
	|-Nullable<QueryPermissionsOptions>.GetValueOrDefault
	|-Nullable<RegisterPlatformAudioUserOptions>.GetValueOrDefault
	|-Nullable<RegisterPlatformUserOptions>.GetValueOrDefault
	|-Nullable<SessionDetailsCopySessionAttributeByKeyOptions>.GetValueOrDefault
	|-Nullable<SessionModificationRemoveAttributeOptions>.GetValueOrDefault
	|-Nullable<SessionModificationSetAllowedPlatformIdsOptions>.GetValueOrDefault
	|-Nullable<SessionModificationSetBucketIdOptions>.GetValueOrDefault
	|-Nullable<SessionModificationSetHostAddressOptions>.GetValueOrDefault
	|-Nullable<SessionSearchFindOptions>.GetValueOrDefault
	|-Nullable<SessionSearchSetSessionIdOptions>.GetValueOrDefault
	|-Nullable<SessionSearchSetTargetUserIdOptions>.GetValueOrDefault
	|-Nullable<SetGameSessionIdOptions>.GetValueOrDefault
	|-Nullable<ShowFriendsOptions>.GetValueOrDefault
	|-Nullable<SpanId>.GetValueOrDefault
	|-Nullable<SqlBinary>.GetValueOrDefault
	|-Nullable<StartSessionOptions>.GetValueOrDefault
	|-Nullable<SteamIAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<SwitchIAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<TimeSpan>.GetValueOrDefault
	|-Nullable<ulong>.GetValueOrDefault
	|-Nullable<UIntPtr>.GetValueOrDefault
	|-Nullable<UnlinkAccountOptions>.GetValueOrDefault
	|-Nullable<UnregisterClientOptions>.GetValueOrDefault
	|-Nullable<UnregisterPeerOptions>.GetValueOrDefault
	|-Nullable<UnregisterPlatformAudioUserOptions>.GetValueOrDefault
	|-Nullable<UnregisterPlatformUserOptions>.GetValueOrDefault
	|-Nullable<UpdateLobbyOptions>.GetValueOrDefault
	|-Nullable<UpdateSessionModificationOptions>.GetValueOrDefault
	|-Nullable<UpdateSessionOptions>.GetValueOrDefault
	|-Nullable<WindowsRTCOptionsPlatformSpecificOptions>.GetValueOrDefault
	|-Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReport>.GetValueOrDefault
	|-Nullable<XSXOptionsSystemSpecificOptions>.GetValueOrDefault
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReport>.GetValueOrDefault
	|-Nullable<XboxOneGDKOptionsSystemSpecificOptions>.GetValueOrDefault
	|-Nullable<C.sentry_value_t>.GetValueOrDefault
	|
	|-RVA: 0x148E5B0 Offset: 0x148D7B0 VA: 0x18148E5B0
	|-Nullable<ActiveSessionCopyInfoOptions>.GetValueOrDefault
	|-Nullable<ActiveSessionGetRegisteredPlayerCountOptions>.GetValueOrDefault
	|-Nullable<AddNotifyAchievementsUnlockedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyAchievementsUnlockedV2Options>.GetValueOrDefault
	|-Nullable<AddNotifyAudioDevicesChangedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyAuthExpirationOptions>.GetValueOrDefault
	|-Nullable<AddNotifyBlockedUsersUpdateOptions>.GetValueOrDefault
	|-Nullable<AddNotifyClientActionRequiredOptions>.GetValueOrDefault
	|-Nullable<AddNotifyClientAuthStatusChangedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyClientIntegrityViolatedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyCustomInviteAcceptedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyCustomInviteReceivedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyCustomInviteRejectedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyDisplaySettingsUpdatedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyFriendsUpdateOptions>.GetValueOrDefault
	|-Nullable<AddNotifyIncomingPacketQueueFullOptions>.GetValueOrDefault
	|-Nullable<AddNotifyJoinGameAcceptedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyJoinLobbyAcceptedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyJoinSessionAcceptedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyLeaveLobbyRequestedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyLeaveSessionRequestedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyLobbyInviteAcceptedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyLobbyInviteReceivedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyLobbyInviteRejectedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyLobbyMemberStatusReceivedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyLobbyMemberUpdateReceivedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyLobbyUpdateReceivedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyLoginStatusChangedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyLoginStatusChangedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyMemoryMonitorOptions>.GetValueOrDefault
	|-Nullable<AddNotifyMessageToClientOptions>.GetValueOrDefault
	|-Nullable<AddNotifyMessageToPeerOptions>.GetValueOrDefault
	|-Nullable<AddNotifyMessageToServerOptions>.GetValueOrDefault
	|-Nullable<AddNotifyOnPresenceChangedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyPeerActionRequiredOptions>.GetValueOrDefault
	|-Nullable<AddNotifyPeerAuthStatusChangedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyPermissionsUpdateReceivedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyRequestToJoinAcceptedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyRequestToJoinReceivedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyRequestToJoinRejectedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyRequestToJoinResponseReceivedOptions>.GetValueOrDefault
	|-Nullable<AddNotifySendCustomNativeInviteRequestedOptions>.GetValueOrDefault
	|-Nullable<AddNotifySendLobbyNativeInviteRequestedOptions>.GetValueOrDefault
	|-Nullable<AddNotifySendSessionNativeInviteRequestedOptions>.GetValueOrDefault
	|-Nullable<AddNotifySessionInviteAcceptedOptions>.GetValueOrDefault
	|-Nullable<AddNotifySessionInviteReceivedOptions>.GetValueOrDefault
	|-Nullable<AddNotifySessionInviteRejectedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyUserLoginStatusChangedOptions>.GetValueOrDefault
	|-Nullable<bool>.GetValueOrDefault
	|-Nullable<byte>.GetValueOrDefault
	|-Nullable<ClearUserPreLogoutCallbackOptions>.GetValueOrDefault
	|-Nullable<CopyUserAuthTokenOptions>.GetValueOrDefault
	|-Nullable<CreateIntegratedPlatformOptionsContainerOptions>.GetValueOrDefault
	|-Nullable<DeleteDeviceIdOptions>.GetValueOrDefault
	|-Nullable<EndSessionOptions>.GetValueOrDefault
	|-Nullable<EndSessionOptions>.GetValueOrDefault
	|-Nullable<GetAchievementDefinitionCountOptions>.GetValueOrDefault
	|-Nullable<GetAudioInputDevicesCountOptions>.GetValueOrDefault
	|-Nullable<GetAudioOutputDevicesCountOptions>.GetValueOrDefault
	|-Nullable<GetDesktopCrossplayStatusOptions>.GetValueOrDefault
	|-Nullable<GetInputDevicesCountOptions>.GetValueOrDefault
	|-Nullable<GetLeaderboardDefinitionCountOptions>.GetValueOrDefault
	|-Nullable<GetLeaderboardRecordCountOptions>.GetValueOrDefault
	|-Nullable<GetLocalPlatformTypeOptions>.GetValueOrDefault
	|-Nullable<GetNATTypeOptions>.GetValueOrDefault
	|-Nullable<GetOutputDevicesCountOptions>.GetValueOrDefault
	|-Nullable<GetPacketQueueInfoOptions>.GetValueOrDefault
	|-Nullable<GetPortRangeOptions>.GetValueOrDefault
	|-Nullable<GetRelayControlOptions>.GetValueOrDefault
	|-Nullable<GetToggleFriendsButtonOptions>.GetValueOrDefault
	|-Nullable<GetToggleFriendsKeyOptions>.GetValueOrDefault
	|-Nullable<InventoryItemGetKeyOptions>.GetValueOrDefault
	|-Nullable<InventoryItemGetSubItemsCountOptions>.GetValueOrDefault
	|-Nullable<InventoryItemGetValueAsBoolOptions>.GetValueOrDefault
	|-Nullable<InventoryItemGetValueAsDoubleOptions>.GetValueOrDefault
	|-Nullable<InventoryItemGetValueAsInt64Options>.GetValueOrDefault
	|-Nullable<InventoryItemGetValueAsStringOptions>.GetValueOrDefault
	|-Nullable<InventoryItemGetValueAsTimestampOptions>.GetValueOrDefault
	|-Nullable<InventoryItemGetValueCountOptions>.GetValueOrDefault
	|-Nullable<InventoryItemGetValueTypeOptions>.GetValueOrDefault
	|-Nullable<InventoryItemSetValueAsBoolOptions>.GetValueOrDefault
	|-Nullable<IsSocialOverlayPausedOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsCopyInfoOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsGetAttributeCountOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsGetLobbyOwnerOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsGetMemberCountOptions>.GetValueOrDefault
	|-Nullable<LobbyModificationSetInvitesAllowedOptions>.GetValueOrDefault
	|-Nullable<LobbySearchGetSearchResultCountOptions>.GetValueOrDefault
	|-Nullable<PS5OptionsInitOptions>.GetValueOrDefault
	|-Nullable<PauseSocialOverlayOptions>.GetValueOrDefault
	|-Nullable<QueryAgeGateOptions>.GetValueOrDefault
	|-Nullable<QueryInputDevicesInformationOptions>.GetValueOrDefault
	|-Nullable<QueryNATTypeOptions>.GetValueOrDefault
	|-Nullable<QueryOutputDevicesInformationOptions>.GetValueOrDefault
	|-Nullable<sbyte>.GetValueOrDefault
	|-Nullable<SessionDetailsCopyInfoOptions>.GetValueOrDefault
	|-Nullable<SessionDetailsGetSessionAttributeCountOptions>.GetValueOrDefault
	|-Nullable<SessionModificationSetInvitesAllowedOptions>.GetValueOrDefault
	|-Nullable<SessionModificationSetJoinInProgressAllowedOptions>.GetValueOrDefault
	|-Nullable<SessionSearchGetSearchResultCountOptions>.GetValueOrDefault
	|-Nullable<SetUserPreLogoutCallbackOptions>.GetValueOrDefault
	|-Nullable<TransactionGetEntitlementsCountOptions>.GetValueOrDefault
	|
	|-RVA: 0xB4B7F0 Offset: 0xB4A9F0 VA: 0x180B4B7F0
	|-Nullable<ActiveSessionGetRegisteredPlayerByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyAchievementDefinitionByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyAchievementDefinitionV2ByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyInputDeviceInformationByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyLeaderboardDefinitionByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyLeaderboardRecordByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyOutputDeviceInformationByIndexOptions>.GetValueOrDefault
	|-Nullable<CreateLobbySearchOptions>.GetValueOrDefault
	|-Nullable<CreateSessionSearchOptions>.GetValueOrDefault
	|-Nullable<EndSnapshotOptions>.GetValueOrDefault
	|-Nullable<GetAudioInputDeviceByIndexOptions>.GetValueOrDefault
	|-Nullable<GetAudioOutputDeviceByIndexOptions>.GetValueOrDefault
	|-Nullable<GetProtectMessageOutputLengthOptions>.GetValueOrDefault
	|-Nullable<GetProtectMessageOutputLengthOptions>.GetValueOrDefault
	|-Nullable<int>.GetValueOrDefault
	|-Nullable<Int32Enum>.GetValueOrDefault
	|-Nullable<InventoryItemGetDoubleSetValueByIndexOptions>.GetValueOrDefault
	|-Nullable<InventoryItemGetInt64SetValueByIndexOptions>.GetValueOrDefault
	|-Nullable<InventoryItemGetStringSetValueByIndexOptions>.GetValueOrDefault
	|-Nullable<InventoryItemGetSubItemByIndexOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsCopyAttributeByIndexOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsGetMemberByIndexOptions>.GetValueOrDefault
	|-Nullable<LobbyModificationSetMaxMembersOptions>.GetValueOrDefault
	|-Nullable<LobbyModificationSetPermissionLevelOptions>.GetValueOrDefault
	|-Nullable<LobbySearchCopySearchResultByIndexOptions>.GetValueOrDefault
	|-Nullable<LobbySearchSetMaxResultsOptions>.GetValueOrDefault
	|-Nullable<LogGameRoundEndOptions>.GetValueOrDefault
	|-Nullable<PollStatusOptions>.GetValueOrDefault
	|-Nullable<PresenceModificationSetStatusOptions>.GetValueOrDefault
	|-Nullable<SessionDetailsCopySessionAttributeByIndexOptions>.GetValueOrDefault
	|-Nullable<SessionModificationSetMaxPlayersOptions>.GetValueOrDefault
	|-Nullable<SessionModificationSetPermissionLevelOptions>.GetValueOrDefault
	|-Nullable<SessionSearchCopySearchResultByIndexOptions>.GetValueOrDefault
	|-Nullable<SessionSearchSetMaxResultsOptions>.GetValueOrDefault
	|-Nullable<SetDisplayPreferenceOptions>.GetValueOrDefault
	|-Nullable<SetRelayControlOptions>.GetValueOrDefault
	|-Nullable<SetToggleFriendsButtonOptions>.GetValueOrDefault
	|-Nullable<SetToggleFriendsKeyOptions>.GetValueOrDefault
	|-Nullable<SubmitSnapshotOptions>.GetValueOrDefault
	|-Nullable<TransactionCopyEntitlementByIndexOptions>.GetValueOrDefault
	|-Nullable<uint>.GetValueOrDefault
	|-Nullable<XSXPrePresentAdditionalData>.GetValueOrDefault
	|-Nullable<XboxOneGDKPrePresentAdditionalData>.GetValueOrDefault
	|
	|-RVA: 0x148E720 Offset: 0x148D920 VA: 0x18148E720
	|-Nullable<ActiveSessionInfo>.GetValueOrDefault
	|
	|-RVA: 0xB4B840 Offset: 0xB4AA40 VA: 0x180B4B840
	|-Nullable<ActiveSessionInfoInternal>.GetValueOrDefault
	|-Nullable<BestDisplayName>.GetValueOrDefault
	|-Nullable<CatalogReleaseInternal>.GetValueOrDefault
	|-Nullable<CreateUserCallbackInfo>.GetValueOrDefault
	|-Nullable<Credentials>.GetValueOrDefault
	|-Nullable<CustomInviteRejectedCallbackInfo>.GetValueOrDefault
	|-Nullable<Entitlement>.GetValueOrDefault
	|-Nullable<FileMetadataInternal>.GetValueOrDefault
	|-Nullable<JoinGameAcceptedCallbackInfo>.GetValueOrDefault
	|-Nullable<JoinLobbyByIdOptions>.GetValueOrDefault
	|-Nullable<JoinLobbyOptions>.GetValueOrDefault
	|-Nullable<JoinRoomCallbackInfo>.GetValueOrDefault
	|-Nullable<LobbyInviteAcceptedCallbackInfo>.GetValueOrDefault
	|-Nullable<LobbyInviteRejectedCallbackInfo>.GetValueOrDefault
	|-Nullable<ModIdentifier>.GetValueOrDefault
	|-Nullable<OnCustomInviteAcceptedCallbackInfo>.GetValueOrDefault
	|-Nullable<OnCustomInviteReceivedCallbackInfo>.GetValueOrDefault
	|-Nullable<OnIncomingPacketQueueFullInfo>.GetValueOrDefault
	|-Nullable<PS4SubmitGraphicsCommandsCallbackInfo>.GetValueOrDefault
	|-Nullable<ParticipantUpdatedCallbackInfo>.GetValueOrDefault
	|-Nullable<ParticipantUpdatedCallbackInfo>.GetValueOrDefault
	|-Nullable<PinGrantInfoInternal>.GetValueOrDefault
	|-Nullable<PlayerSanctionInternal>.GetValueOrDefault
	|-Nullable<QueryJoinRoomTokenCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryUserInfoByDisplayNameCallbackInfo>.GetValueOrDefault
	|-Nullable<ReadFileOptions>.GetValueOrDefault
	|-Nullable<ReadFileOptions>.GetValueOrDefault
	|-Nullable<RegisterClientOptions>.GetValueOrDefault
	|-Nullable<SendAudioOptions>.GetValueOrDefault
	|-Nullable<SendPlayerBehaviorReportOptions>.GetValueOrDefault
	|-Nullable<SessionInviteAcceptedCallbackInfo>.GetValueOrDefault
	|-Nullable<SessionInviteRejectedCallbackInfo>.GetValueOrDefault
	|-Nullable<StatInternal>.GetValueOrDefault
	|-Nullable<SteamIAPVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<SwitchIAPVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<UpdateReceivingVolumeCallbackInfo>.GetValueOrDefault
	|-Nullable<UpdateSendingCallbackInfo>.GetValueOrDefault
	|-Nullable<UpdateSendingCallbackInfo>.GetValueOrDefault
	|-Nullable<UpdateSendingVolumeCallbackInfo>.GetValueOrDefault
	|-Nullable<UserPreLogoutCallbackInfo>.GetValueOrDefault
	|-Nullable<WriteFileOptions>.GetValueOrDefault
	|-Nullable<XSXXBLOptions>.GetValueOrDefault
	|-Nullable<XboxOneGDKXBLOptions>.GetValueOrDefault
	|
	|-RVA: 0xB4B810 Offset: 0xB4AA10 VA: 0x180B4B810
	|-Nullable<AddNotifyAudioBeforeRenderOptions>.GetValueOrDefault
	|-Nullable<AddProgressionOptions>.GetValueOrDefault
	|-Nullable<AndroidInitializeOptionsSystemInitializeOptions>.GetValueOrDefault
	|-Nullable<AttributeInternal>.GetValueOrDefault
	|-Nullable<AudioInputDeviceInfo>.GetValueOrDefault
	|-Nullable<AudioInputDeviceInfoInternal>.GetValueOrDefault
	|-Nullable<AudioOutputDeviceInfo>.GetValueOrDefault
	|-Nullable<AudioOutputDeviceInfoInternal>.GetValueOrDefault
	|-Nullable<BeginPlayerSessionOptionsAccountId>.GetValueOrDefault
	|-Nullable<CatalogRelease>.GetValueOrDefault
	|-Nullable<CheckoutOptions>.GetValueOrDefault
	|-Nullable<CheckpointOptions>.GetValueOrDefault
	|-Nullable<CloseOptions>.GetValueOrDefault
	|-Nullable<CopyBestDisplayNameWithPlatformOptions>.GetValueOrDefault
	|-Nullable<CopyEntitlementByNameAndIndexOptions>.GetValueOrDefault
	|-Nullable<CopyExternalUserInfoByAccountIdOptions>.GetValueOrDefault
	|-Nullable<CopyExternalUserInfoByAccountTypeOptions>.GetValueOrDefault
	|-Nullable<CopyExternalUserInfoByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyItemImageInfoByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyItemReleaseByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyOfferImageInfoByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyOfferItemByIndexOptions>.GetValueOrDefault
	|-Nullable<CopyPlayerAchievementByAchievementIdOptions>.GetValueOrDefault
	|-Nullable<CopyPlayerAchievementByIndexOptions>.GetValueOrDefault
	|-Nullable<CreateLobbyCallbackInfo>.GetValueOrDefault
	|-Nullable<CreateOptions>.GetValueOrDefault
	|-Nullable<CreatePlayerSanctionAppealCallbackInfo>.GetValueOrDefault
	|-Nullable<CreatePlayerSanctionAppealOptions>.GetValueOrDefault
	|-Nullable<CreateUserCallbackInfo>.GetValueOrDefault
	|-Nullable<CreateUserOptions>.GetValueOrDefault
	|-Nullable<DeleteCacheCallbackInfo>.GetValueOrDefault
	|-Nullable<DeleteCacheCallbackInfo>.GetValueOrDefault
	|-Nullable<DeleteFileCallbackInfo>.GetValueOrDefault
	|-Nullable<DeleteSnapshotCallbackInfo>.GetValueOrDefault
	|-Nullable<DestroyLobbyCallbackInfo>.GetValueOrDefault
	|-Nullable<DuplicateFileCallbackInfo>.GetValueOrDefault
	|-Nullable<DuplicateFileOptions>.GetValueOrDefault
	|-Nullable<EndPlayerSessionOptions>.GetValueOrDefault
	|-Nullable<EndPlayerSessionOptionsAccountId>.GetValueOrDefault
	|-Nullable<FinalizeDeferredUserLogoutOptions>.GetValueOrDefault
	|-Nullable<GetExternalAccountMappingsOptions>.GetValueOrDefault
	|-Nullable<GetProductUserIdMappingOptions>.GetValueOrDefault
	|-Nullable<HideFriendsCallbackInfo>.GetValueOrDefault
	|-Nullable<IOSCredentialsSystemAuthCredentialsOptions>.GetValueOrDefault
	|-Nullable<IdTokenInternal>.GetValueOrDefault
	|-Nullable<IdTokenInternal>.GetValueOrDefault
	|-Nullable<IngestStatOptions>.GetValueOrDefault
	|-Nullable<InputDeviceInformation>.GetValueOrDefault
	|-Nullable<InputDeviceInformationInternal>.GetValueOrDefault
	|-Nullable<JoinLobbyAcceptedCallbackInfo>.GetValueOrDefault
	|-Nullable<JoinLobbyByIdCallbackInfo>.GetValueOrDefault
	|-Nullable<JoinLobbyCallbackInfo>.GetValueOrDefault
	|-Nullable<JoinSessionAcceptedCallbackInfo>.GetValueOrDefault
	|-Nullable<JsonPosition>.GetValueOrDefault
	|-Nullable<KeyImageInfo>.GetValueOrDefault
	|-Nullable<KickMemberCallbackInfo>.GetValueOrDefault
	|-Nullable<KickMemberOptions>.GetValueOrDefault
	|-Nullable<LeaderboardRecord>.GetValueOrDefault
	|-Nullable<LeaderboardUserScoreInternal>.GetValueOrDefault
	|-Nullable<LeaveLobbyCallbackInfo>.GetValueOrDefault
	|-Nullable<LeaveLobbyRequestedCallbackInfo>.GetValueOrDefault
	|-Nullable<LeaveSessionRequestedCallbackInfo>.GetValueOrDefault
	|-Nullable<LinkAccountCallbackInfo>.GetValueOrDefault
	|-Nullable<LinkAccountOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsMemberInfoInternal>.GetValueOrDefault
	|-Nullable<LobbyMemberUpdateReceivedCallbackInfo>.GetValueOrDefault
	|-Nullable<LogEventOptions>.GetValueOrDefault
	|-Nullable<LogMessage>.GetValueOrDefault
	|-Nullable<LogPlayerUseAbilityOptions>.GetValueOrDefault
	|-Nullable<LoginStatusChangedCallbackInfo>.GetValueOrDefault
	|-Nullable<LoginStatusChangedCallbackInfo>.GetValueOrDefault
	|-Nullable<LogoutCallbackInfo>.GetValueOrDefault
	|-Nullable<LogoutCallbackInfo>.GetValueOrDefault
	|-Nullable<ModInfoInternal>.GetValueOrDefault
	|-Nullable<OnAchievementsUnlockedCallbackInfo>.GetValueOrDefault
	|-Nullable<OnClientAuthStatusChangedCallbackInfo>.GetValueOrDefault
	|-Nullable<OnClientIntegrityViolatedCallbackInfo>.GetValueOrDefault
	|-Nullable<OnCreateCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<OnMessageToServerCallbackInfo>.GetValueOrDefault
	|-Nullable<OnOpenCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<OnQueryLeaderboardRanksCompleteCallbackInfo>.GetValueOrDefault
	|-Nullable<OnQueryNATTypeCompleteInfo>.GetValueOrDefault
	|-Nullable<OnRegisterPlatformUserCallbackInfo>.GetValueOrDefault
	|-Nullable<OnRequestToJoinAcceptedCallbackInfo>.GetValueOrDefault
	|-Nullable<OnRequestToJoinRejectedCallbackInfo>.GetValueOrDefault
	|-Nullable<OnSetInputDeviceSettingsCallbackInfo>.GetValueOrDefault
	|-Nullable<OnSetOutputDeviceSettingsCallbackInfo>.GetValueOrDefault
	|-Nullable<OnUnregisterPlatformUserCallbackInfo>.GetValueOrDefault
	|-Nullable<OpenOptions>.GetValueOrDefault
	|-Nullable<Options>.GetValueOrDefault
	|-Nullable<OutputDeviceInformation>.GetValueOrDefault
	|-Nullable<OutputDeviceInformationInternal>.GetValueOrDefault
	|-Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.GetValueOrDefault
	|-Nullable<PS4OptionsInitOptions>.GetValueOrDefault
	|-Nullable<PS5IntegratedPlatformOptionsContainerAddOptions>.GetValueOrDefault
	|-Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.GetValueOrDefault
	|-Nullable<PermissionStatusInternal>.GetValueOrDefault
	|-Nullable<PresenceChangedCallbackInfo>.GetValueOrDefault
	|-Nullable<PromoteMemberCallbackInfo>.GetValueOrDefault
	|-Nullable<PromoteMemberOptions>.GetValueOrDefault
	|-Nullable<ProtectMessageOptions>.GetValueOrDefault
	|-Nullable<QueryDefinitionsOptions>.GetValueOrDefault
	|-Nullable<QueryEntitlementsCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryEntitlementsOptions>.GetValueOrDefault
	|-Nullable<QueryExternalAccountMappingsCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryExternalAccountMappingsOptions>.GetValueOrDefault
	|-Nullable<QueryFileCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryFileCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryFriendsCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryInvitesCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryInvitesCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryOffersCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryOwnershipOptions>.GetValueOrDefault
	|-Nullable<QueryOwnershipTokenOptions>.GetValueOrDefault
	|-Nullable<QueryProductUserIdMappingsCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryProductUserIdMappingsOptions>.GetValueOrDefault
	|-Nullable<QueryUserInfoByExternalAccountOptions>.GetValueOrDefault
	|-Nullable<ReceiveMessageFromClientOptions>.GetValueOrDefault
	|-Nullable<ReceiveMessageFromPeerOptions>.GetValueOrDefault
	|-Nullable<RejectInviteCallbackInfo>.GetValueOrDefault
	|-Nullable<RequestPermissionsCallbackInfo>.GetValueOrDefault
	|-Nullable<RequestToJoinReceivedCallbackInfo>.GetValueOrDefault
	|-Nullable<SendInviteCallbackInfo>.GetValueOrDefault
	|-Nullable<SendInviteOptions>.GetValueOrDefault
	|-Nullable<SendInviteOptions>.GetValueOrDefault
	|-Nullable<SessionDetailsAttributeInternal>.GetValueOrDefault
	|-Nullable<SetAudioInputSettingsOptions>.GetValueOrDefault
	|-Nullable<SetAudioOutputSettingsOptions>.GetValueOrDefault
	|-Nullable<SetInputDeviceSettingsOptions>.GetValueOrDefault
	|-Nullable<SetParticipantHardMuteOptions>.GetValueOrDefault
	|-Nullable<SetPresenceCallbackInfo>.GetValueOrDefault
	|-Nullable<SetUserLoginStatusOptions>.GetValueOrDefault
	|-Nullable<ShowFriendsCallbackInfo>.GetValueOrDefault
	|-Nullable<TransferDeviceIdAccountCallbackInfo>.GetValueOrDefault
	|-Nullable<TransferDeviceIdAccountOptions>.GetValueOrDefault
	|-Nullable<UnlinkAccountCallbackInfo>.GetValueOrDefault
	|-Nullable<UnlockedAchievementInternal>.GetValueOrDefault
	|-Nullable<UnprotectMessageOptions>.GetValueOrDefault
	|-Nullable<UnregisterPlayersCallbackInfo>.GetValueOrDefault
	|-Nullable<UpdateLobbyCallbackInfo>.GetValueOrDefault
	|-Nullable<UpdateParentEmailCallbackInfo>.GetValueOrDefault
	|-Nullable<UpdateReceivingVolumeOptions>.GetValueOrDefault
	|-Nullable<UpdateSendingOptions>.GetValueOrDefault
	|-Nullable<UpdateSendingOptions>.GetValueOrDefault
	|-Nullable<UpdateSendingVolumeOptions>.GetValueOrDefault
	|-Nullable<UserTokenInternal>.GetValueOrDefault
	|-Nullable<VerifyIdTokenOptions>.GetValueOrDefault
	|-Nullable<VerifyIdTokenOptions>.GetValueOrDefault
	|-Nullable<WindowsRTCOptions>.GetValueOrDefault
	|-Nullable<XSXMemoryMonitorCallbackInfo>.GetValueOrDefault
	|-Nullable<XSXSubmitGraphicsCommandsCallbackInfo>.GetValueOrDefault
	|-Nullable<XSXXBLOptionsInitOptionsInternal>.GetValueOrDefault
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfo>.GetValueOrDefault
	|-Nullable<XboxOneGDKSubmitGraphicsCommandsCallbackInfo>.GetValueOrDefault
	|-Nullable<XboxOneGDKXBLOptionsInitOptionsInternal>.GetValueOrDefault
	|
	|-RVA: 0xB4B9F0 Offset: 0xB4ABF0 VA: 0x180B4B9F0
	|-Nullable<AddNotifyPeerConnectionClosedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyPeerConnectionEstablishedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyPeerConnectionInterruptedOptions>.GetValueOrDefault
	|-Nullable<AddNotifyPeerConnectionRequestOptions>.GetValueOrDefault
	|-Nullable<AndroidIAPVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<AudioBeforeSendCallbackInfo>.GetValueOrDefault
	|-Nullable<BestDisplayNameInternal>.GetValueOrDefault
	|-Nullable<BlockParticipantCallbackInfo>.GetValueOrDefault
	|-Nullable<CloseConnectionsOptions>.GetValueOrDefault
	|-Nullable<DataReceivedCallbackInfo>.GetValueOrDefault
	|-Nullable<DefinitionInternal>.GetValueOrDefault
	|-Nullable<EGSDLCVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<EGSIAPVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<EntitlementInternal>.GetValueOrDefault
	|-Nullable<ExternalAccountInfoInternal>.GetValueOrDefault
	|-Nullable<IOSIAPVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<JoinRoomOptions>.GetValueOrDefault
	|-Nullable<LoginOptions>.GetValueOrDefault
	|-Nullable<ModIdentifierInternal>.GetValueOrDefault
	|-Nullable<OnAchievementsUnlockedCallbackV2Info>.GetValueOrDefault
	|-Nullable<PS4Options>.GetValueOrDefault
	|-Nullable<PS4PrePresentOptionsPlatformSpecificData>.GetValueOrDefault
	|-Nullable<PS5PrePresentOptionsPlatformSpecificData>.GetValueOrDefault
	|-Nullable<PacketQueueInfo>.GetValueOrDefault
	|-Nullable<PermissionsUpdateReceivedCallbackInfo>.GetValueOrDefault
	|-Nullable<QueryUserInfoByExternalAccountCallbackInfo>.GetValueOrDefault
	|-Nullable<ReadFileDataCallbackInfo>.GetValueOrDefault
	|-Nullable<ReadFileDataCallbackInfo>.GetValueOrDefault
	|-Nullable<RegisterPeerOptions>.GetValueOrDefault
	|-Nullable<SendCustomNativeInviteRequestedCallbackInfo>.GetValueOrDefault
	|-Nullable<SendLobbyNativeInviteRequestedCallbackInfo>.GetValueOrDefault
	|-Nullable<SendSessionNativeInviteRequestedCallbackInfo>.GetValueOrDefault
	|-Nullable<SteamDLCVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<UpdateParticipantVolumeCallbackInfo>.GetValueOrDefault
	|-Nullable<UpdateReceivingCallbackInfo>.GetValueOrDefault
	|-Nullable<UpdateReceivingCallbackInfo>.GetValueOrDefault
	|-Nullable<UserInfoData>.GetValueOrDefault
	|-Nullable<UserLoginStatusChangedCallbackInfo>.GetValueOrDefault
	|-Nullable<XSXDLCVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<XSXIAPVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<XSXIntegratedPlatformOptionsContainerAddOptions>.GetValueOrDefault
	|-Nullable<XboxOneGDKDLCVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<XboxOneGDKIAPVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<XboxOneGDKIntegratedPlatformOptionsContainerAddOptions>.GetValueOrDefault
	|
	|-RVA: 0x148E5C0 Offset: 0x148D7C0 VA: 0x18148E5C0
	|-Nullable<AndroidInitializeOptions>.GetValueOrDefault
	|
	|-RVA: 0xB4B9A0 Offset: 0xB4ABA0 VA: 0x180B4B9A0
	|-Nullable<Announcement>.GetValueOrDefault
	|-Nullable<AttributeData>.GetValueOrDefault
	|-Nullable<AttributeData>.GetValueOrDefault
	|-Nullable<CreateSessionModificationOptions>.GetValueOrDefault
	|-Nullable<IOSCredentials>.GetValueOrDefault
	|-Nullable<InitializeThreadAffinity>.GetValueOrDefault
	|-Nullable<InstallModOptions>.GetValueOrDefault
	|-Nullable<LogPlayerUseWeaponOptions>.GetValueOrDefault
	|-Nullable<LoginOptions>.GetValueOrDefault
	|-Nullable<OnIncomingConnectionRequestInfo>.GetValueOrDefault
	|-Nullable<OnPeerConnectionInterruptedInfo>.GetValueOrDefault
	|-Nullable<PS4DLCVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<PS4IAPVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<PS5DLCVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<PS5IAPVerifyPurchaseOptions>.GetValueOrDefault
	|-Nullable<Stat>.GetValueOrDefault
	|-Nullable<XSXPrePresentOptions>.GetValueOrDefault
	|-Nullable<XboxOneGDKPrePresentOptions>.GetValueOrDefault
	|
	|-RVA: 0x148E6C0 Offset: 0x148D8C0 VA: 0x18148E6C0
	|-Nullable<Attribute>.GetValueOrDefault
	|-Nullable<CatalogItem>.GetValueOrDefault
	|-Nullable<CreateLobbyOptions>.GetValueOrDefault
	|-Nullable<DefinitionV2>.GetValueOrDefault
	|-Nullable<InfoInternal>.GetValueOrDefault
	|-Nullable<LobbyModificationAddAttributeOptions>.GetValueOrDefault
	|-Nullable<LobbyModificationAddMemberAttributeOptions>.GetValueOrDefault
	|-Nullable<LobbySearchSetParameterOptions>.GetValueOrDefault
	|-Nullable<PS4InitializeOptionsSystemInitializeOptions>.GetValueOrDefault
	|-Nullable<PlayerAchievement>.GetValueOrDefault
	|-Nullable<PlayerAchievementInternal>.GetValueOrDefault
	|-Nullable<SessionDetailsAttribute>.GetValueOrDefault
	|-Nullable<SessionDetailsInfo>.GetValueOrDefault
	|-Nullable<SessionModificationAddAttributeOptions>.GetValueOrDefault
	|-Nullable<SessionSearchSetParameterOptions>.GetValueOrDefault
	|-Nullable<Token>.GetValueOrDefault
	|
	|-RVA: 0x149D040 Offset: 0x149C240 VA: 0x18149D040
	|-Nullable<CatalogItemInternal>.GetValueOrDefault
	|-Nullable<Definition>.GetValueOrDefault
	|-Nullable<DefinitionV2Internal>.GetValueOrDefault
	|-Nullable<IOSLoginOptions>.GetValueOrDefault
	|-Nullable<LobbyDetailsInfoInternal>.GetValueOrDefault
	|-Nullable<TokenInternal>.GetValueOrDefault
	|-Nullable<VerifyIdTokenCallbackInfo>.GetValueOrDefault
	|-Nullable<VerifyUserAuthOptions>.GetValueOrDefault
	|
	|-RVA: 0x149CF60 Offset: 0x149C160 VA: 0x18149CF60
	|-Nullable<CatalogOffer>.GetValueOrDefault
	|-Nullable<CatalogOfferInternal>.GetValueOrDefault
	|
	|-RVA: 0x149D010 Offset: 0x149C210 VA: 0x18149D010
	|-Nullable<char>.GetValueOrDefault
	|-Nullable<short>.GetValueOrDefault
	|-Nullable<Int16Enum>.GetValueOrDefault
	|-Nullable<ushort>.GetValueOrDefault
	|-Nullable<UInt16Enum>.GetValueOrDefault
	|
	|-RVA: 0x149D020 Offset: 0x149C220 VA: 0x18149D020
	|-Nullable<Color>.GetValueOrDefault
	|-Nullable<Guid>.GetValueOrDefault
	|-Nullable<Quat>.GetValueOrDefault
	|-Nullable<QuatInternal>.GetValueOrDefault
	|-Nullable<Rect>.GetValueOrDefault
	|-Nullable<SentryId>.GetValueOrDefault
	|
	|-RVA: 0xB4BC30 Offset: 0xB4AE30 VA: 0x180B4BC30
	|-Nullable<CopyUserTokenByIndexOptions>.GetValueOrDefault
	|-Nullable<DesktopCrossplayStatusInfo>.GetValueOrDefault
	|-Nullable<LocalRTCOptions>.GetValueOrDefault
	|-Nullable<PS5OptionsInitOptionsInternal>.GetValueOrDefault
	|-Nullable<PageQuery>.GetValueOrDefault
	|-Nullable<XSXPrePresentAdditionalDataInternal>.GetValueOrDefault
	|-Nullable<XboxOneGDKPrePresentAdditionalDataInternal>.GetValueOrDefault
	|
	|-RVA: 0x14AD110 Offset: 0x14AC310 VA: 0x1814AD110
	|-Nullable<Definition>.GetValueOrDefault
	|-Nullable<Info>.GetValueOrDefault
	|-Nullable<InstallModCallbackInfo>.GetValueOrDefault
	|-Nullable<LinkAccountCallbackInfo>.GetValueOrDefault
	|-Nullable<LogPlayerTickOptions>.GetValueOrDefault
	|-Nullable<OnPeerConnectionEstablishedInfo>.GetValueOrDefault
	|-Nullable<OnRemoteConnectionClosedInfo>.GetValueOrDefault
	|-Nullable<PS5InitializeOptionsSystemInitializeOptions>.GetValueOrDefault
	|-Nullable<QueryLeaderboardUserScoresOptions>.GetValueOrDefault
	|-Nullable<QueryStatsOptions>.GetValueOrDefault
	|-Nullable<UninstallModCallbackInfo>.GetValueOrDefault
	|-Nullable<UpdateModCallbackInfo>.GetValueOrDefault
	|
	|-RVA: 0x14AD030 Offset: 0x14AC230 VA: 0x1814AD030
	|-Nullable<DefinitionInternal>.GetValueOrDefault
	|-Nullable<LoginCallbackInfo>.GetValueOrDefault
	|-Nullable<SendPacketOptions>.GetValueOrDefault
	|-Nullable<VerifyIdTokenCallbackInfo>.GetValueOrDefault
	|
	|-RVA: 0x14AD020 Offset: 0x14AC220 VA: 0x1814AD020
	|-Nullable<double>.GetValueOrDefault
	|
	|-RVA: 0x14BCBB0 Offset: 0x14BBDB0 VA: 0x1814BCBB0
	|-Nullable<InitializeOptions>.GetValueOrDefault
	|
	|-RVA: 0x14CB8C0 Offset: 0x14CAAC0 VA: 0x1814CB8C0
	|-Nullable<LogEventParamPair>.GetValueOrDefault
	|-Nullable<LogEventParamPairParamValue>.GetValueOrDefault
	|
	|-RVA: 0x14CB9E0 Offset: 0x14CABE0 VA: 0x1814CB9E0
	|-Nullable<LogPlayerTakeDamageOptions>.GetValueOrDefault
	|
	|-RVA: 0x14DBF30 Offset: 0x14DB130 VA: 0x1814DBF30
	|-Nullable<Options>.GetValueOrDefault
	|
	|-RVA: 0x14DC000 Offset: 0x14DB200 VA: 0x1814DC000
	|-Nullable<PS4InitializeOptions>.GetValueOrDefault
	|
	|-RVA: 0x14DC120 Offset: 0x14DB320 VA: 0x1814DC120
	|-Nullable<PS5InitializeOptions>.GetValueOrDefault
	|
	|-RVA: 0x14DBDD0 Offset: 0x14DAFD0 VA: 0x1814DBDD0
	|-Nullable<PageResult>.GetValueOrDefault
	|-Nullable<Token>.GetValueOrDefault
	|-Nullable<Vec3f>.GetValueOrDefault
	|-Nullable<Vec3fInternal>.GetValueOrDefault
	|-Nullable<Vector3>.GetValueOrDefault
	|
	|-RVA: 0x14ECA60 Offset: 0x14EBC60 VA: 0x1814ECA60
	|-Nullable<RectInternal>.GetValueOrDefault
	|
	|-RVA: 0x14FC0A0 Offset: 0x14FB2A0 VA: 0x1814FC0A0
	|-Nullable<ReportInputStateOptions>.GetValueOrDefault
	|
	|-RVA: 0x14FC0F0 Offset: 0x14FB2F0 VA: 0x1814FC0F0
	|-Nullable<SequencePoint>.GetValueOrDefault
	|
	|-RVA: 0x14FC120 Offset: 0x14FB320 VA: 0x1814FC120
	|-Nullable<SetPortRangeOptions>.GetValueOrDefault
	|
	|-RVA: 0x150BDA0 Offset: 0x150AFA0 VA: 0x18150BDA0
	|-Nullable<float>.GetValueOrDefault
	|
	|-RVA: 0x150BDB0 Offset: 0x150AFB0 VA: 0x18150BDB0
	|-Nullable<Touch>.GetValueOrDefault
	|
	|-RVA: 0x150BE10 Offset: 0x150B010 VA: 0x18150BE10
	|-Nullable<Vector2>.GetValueOrDefault
	|
	|-RVA: 0xB4BCC0 Offset: 0xB4AEC0 VA: 0x180B4BCC0
	|-Nullable<WindowsOptions>.GetValueOrDefault
	|-Nullable<XSXOptions>.GetValueOrDefault
	|-Nullable<XboxOneGDKOptions>.GetValueOrDefault
	|
	|-RVA: 0xB4B880 Offset: 0xB4AA80 VA: 0x180B4B880
	|-Nullable<XSXInitializeOptions>.GetValueOrDefault
	|-Nullable<XboxOneGDKInitializeOptions>.GetValueOrDefault
	|
	|-RVA: 0xB4BB10 Offset: 0xB4AD10 VA: 0x180B4BB10
	|-Nullable<__Il2CppFullySharedGenericStructType>.GetValueOrDefault
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x148E150 Offset: 0x148D350 VA: 0x18148E150
	|-Nullable<ArraySegment<byte>>.Equals
	|
	|-RVA: 0x148DFC0 Offset: 0x148D1C0 VA: 0x18148DFC0
	|-Nullable<ValueTuple<object, object>>.Equals
	|
	|-RVA: 0xB4A8E0 Offset: 0xB49AE0 VA: 0x180B4A8E0
	|-Nullable<AcceptConnectionOptions>.Equals
	|-Nullable<AttributeDataValue>.Equals
	|-Nullable<AttributeDataValue>.Equals
	|-Nullable<AudioBeforeRenderCallbackInfo>.Equals
	|-Nullable<BeginPlayerSessionOptions>.Equals
	|-Nullable<ClearPacketQueueOptions>.Equals
	|-Nullable<CloseConnectionOptions>.Equals
	|-Nullable<ExternalAccountInfo>.Equals
	|-Nullable<FileMetadata>.Equals
	|-Nullable<LobbyDetailsInfo>.Equals
	|-Nullable<LogPlayerUseWeaponData>.Equals
	|-Nullable<PS4IntegratedPlatformOptionsContainerAddOptions>.Equals
	|-Nullable<PS4PrePresentOptions>.Equals
	|-Nullable<PS5PrePresentOptions>.Equals
	|-Nullable<ParticipantStatusChangedCallbackInfo>.Equals
	|-Nullable<QueryLeaderboardDefinitionsOptions>.Equals
	|-Nullable<QueryPermissionsCallbackInfo>.Equals
	|-Nullable<SessionDetailsInfoInternal>.Equals
	|-Nullable<SessionDetailsSettingsInternal>.Equals
	|-Nullable<UninstallModOptions>.Equals
	|-Nullable<UpdateModOptions>.Equals
	|-Nullable<UserInfoDataInternal>.Equals
	|-Nullable<XSXInitializeOptionsSystemInitializeOptions>.Equals
	|-Nullable<XSXPrePresentOptionsPlatformSpecificData>.Equals
	|-Nullable<XboxOneGDKInitializeOptionsSystemInitializeOptions>.Equals
	|-Nullable<XboxOneGDKPrePresentOptionsPlatformSpecificData>.Equals
	|
	|-RVA: 0xB4AAC0 Offset: 0xB49CC0 VA: 0x180B4AAC0
	|-Nullable<AcceptInviteCallbackInfo>.Equals
	|-Nullable<AcceptRequestToJoinCallbackInfo>.Equals
	|-Nullable<AttributeDataInternal>.Equals
	|-Nullable<AttributeDataInternal>.Equals
	|-Nullable<AudioBufferInternal>.Equals
	|-Nullable<AudioInputStateCallbackInfo>.Equals
	|-Nullable<AudioOutputStateCallbackInfo>.Equals
	|-Nullable<BeginSessionOptions>.Equals
	|-Nullable<BlockParticipantOptions>.Equals
	|-Nullable<CheckoutCallbackInfo>.Equals
	|-Nullable<DisconnectedCallbackInfo>.Equals
	|-Nullable<EnumerateModsCallbackInfo>.Equals
	|-Nullable<ExternalUserInfo>.Equals
	|-Nullable<ExternalUserInfoInternal>.Equals
	|-Nullable<FileMetadata>.Equals
	|-Nullable<FileMetadataInternal>.Equals
	|-Nullable<FileTransferProgressCallbackInfo>.Equals
	|-Nullable<FileTransferProgressCallbackInfo>.Equals
	|-Nullable<FinalizeInviteOptions>.Equals
	|-Nullable<HardMuteMemberCallbackInfo>.Equals
	|-Nullable<HardMuteMemberOptions>.Equals
	|-Nullable<IOSCredentialsSystemAuthCredentialsOptionsInternal>.Equals
	|-Nullable<IngestStatCompleteCallbackInfo>.Equals
	|-Nullable<IntegratedPlatformOptionsContainerAddOptions>.Equals
	|-Nullable<JoinSessionOptions>.Equals
	|-Nullable<KeyImageInfoInternal>.Equals
	|-Nullable<LeaderboardRecordInternal>.Equals
	|-Nullable<LeaveRoomCallbackInfo>.Equals
	|-Nullable<LobbyInviteReceivedCallbackInfo>.Equals
	|-Nullable<LobbyMemberStatusReceivedCallbackInfo>.Equals
	|-Nullable<LogGameRoundStartOptions>.Equals
	|-Nullable<LoginCallbackInfo>.Equals
	|-Nullable<OnBlockedUsersUpdateInfo>.Equals
	|-Nullable<OnClientActionRequiredCallbackInfo>.Equals
	|-Nullable<OnFriendsUpdateInfo>.Equals
	|-Nullable<OnMessageToClientCallbackInfo>.Equals
	|-Nullable<OnQueryPlayerAchievementsCompleteCallbackInfo>.Equals
	|-Nullable<OnQueryStatsCompleteCallbackInfo>.Equals
	|-Nullable<OnShowBlockPlayerCallbackInfo>.Equals
	|-Nullable<OnShowReportPlayerCallbackInfo>.Equals
	|-Nullable<OnUnlockAchievementsCompleteCallbackInfo>.Equals
	|-Nullable<PS4DLCVerifyPurchaseOptionsPlatformSpecificOptions>.Equals
	|-Nullable<PS4IAPVerifyPurchaseOptionsPlatformSpecificOptions>.Equals
	|-Nullable<PS4MemoryMonitorCallbackInfo>.Equals
	|-Nullable<PS4OptionsInitOptionsInternal>.Equals
	|-Nullable<PS5DLCVerifyPurchaseOptionsPlatformSpecificOptions>.Equals
	|-Nullable<PS5IAPVerifyPurchaseOptionsPlatformSpecificOptions>.Equals
	|-Nullable<PS5MemoryMonitorCallbackInfo>.Equals
	|-Nullable<PS5SubmitGraphicsCommandsCallbackInfo>.Equals
	|-Nullable<PinGrantInfo>.Equals
	|-Nullable<PlayerSanction>.Equals
	|-Nullable<ProtectMessageOptions>.Equals
	|-Nullable<QueryActivePlayerSanctionsCallbackInfo>.Equals
	|-Nullable<QueryAgeGateCallbackInfo>.Equals
	|-Nullable<QueryEntitlementTokenCallbackInfo>.Equals
	|-Nullable<QueryFileListCallbackInfo>.Equals
	|-Nullable<QueryFileListCallbackInfo>.Equals
	|-Nullable<QueryIdTokenCallbackInfo>.Equals
	|-Nullable<QueryJoinRoomTokenOptions>.Equals
	|-Nullable<QueryOwnershipBySandboxIdsCallbackInfo>.Equals
	|-Nullable<QueryOwnershipCallbackInfo>.Equals
	|-Nullable<QueryOwnershipTokenCallbackInfo>.Equals
	|-Nullable<QueryPresenceCallbackInfo>.Equals
	|-Nullable<QueryUserInfoCallbackInfo>.Equals
	|-Nullable<RTCRoomConnectionChangedCallbackInfo>.Equals
	|-Nullable<ReadFileCallbackInfo>.Equals
	|-Nullable<ReadFileCallbackInfo>.Equals
	|-Nullable<RedeemEntitlementsCallbackInfo>.Equals
	|-Nullable<RegisterEventOptions>.Equals
	|-Nullable<RegisterPlayersCallbackInfo>.Equals
	|-Nullable<RejectInviteCallbackInfo>.Equals
	|-Nullable<RejectRequestToJoinCallbackInfo>.Equals
	|-Nullable<RequestToJoinResponseReceivedCallbackInfo>.Equals
	|-Nullable<RoomStatisticsUpdatedInfo>.Equals
	|-Nullable<SendCustomInviteCallbackInfo>.Equals
	|-Nullable<SendDataOptions>.Equals
	|-Nullable<SendInviteCallbackInfo>.Equals
	|-Nullable<SendRequestToJoinCallbackInfo>.Equals
	|-Nullable<SessionDetailsSettings>.Equals
	|-Nullable<SessionInviteReceivedCallbackInfo>.Equals
	|-Nullable<SetRoomSettingOptions>.Equals
	|-Nullable<ShowNativeProfileCallbackInfo>.Equals
	|-Nullable<SocketId>.Equals
	|-Nullable<SteamOptions>.Equals
	|-Nullable<UnlockedAchievement>.Equals
	|-Nullable<UnprotectMessageOptions>.Equals
	|-Nullable<UpdateParticipantVolumeOptions>.Equals
	|-Nullable<UpdateReceivingOptions>.Equals
	|-Nullable<UpdateReceivingOptions>.Equals
	|-Nullable<UpdateSessionCallbackInfo>.Equals
	|-Nullable<VerifyPurchaseOptions>.Equals
	|-Nullable<WriteFileCallbackInfo>.Equals
	|-Nullable<WriteFileDataCallbackInfo>.Equals
	|
	|-RVA: 0xB4A770 Offset: 0xB49970 VA: 0x180B4A770
	|-Nullable<AcceptInviteOptions>.Equals
	|-Nullable<AcceptRequestToJoinOptions>.Equals
	|-Nullable<AccountFeatureRestrictedInfoInternal>.Equals
	|-Nullable<AcknowledgeEventIdOptions>.Equals
	|-Nullable<AddNotifyAudioBeforeSendOptions>.Equals
	|-Nullable<AddNotifyAudioInputStateOptions>.Equals
	|-Nullable<AddNotifyAudioOutputStateOptions>.Equals
	|-Nullable<AddNotifyDataReceivedOptions>.Equals
	|-Nullable<AddNotifyDisconnectedOptions>.Equals
	|-Nullable<AddNotifyParticipantStatusChangedOptions>.Equals
	|-Nullable<AddNotifyParticipantUpdatedOptions>.Equals
	|-Nullable<AddNotifyParticipantUpdatedOptions>.Equals
	|-Nullable<AddNotifyRTCRoomConnectionChangedOptions>.Equals
	|-Nullable<AddNotifyRoomStatisticsUpdatedOptions>.Equals
	|-Nullable<AndroidIAPVerifyPurchaseOptionsPlatformSpecificOptions>.Equals
	|-Nullable<AudioBuffer>.Equals
	|-Nullable<AuthExpirationCallbackInfo>.Equals
	|-Nullable<BeginSessionOptions>.Equals
	|-Nullable<ClientCredentials>.Equals
	|-Nullable<CopyBestDisplayNameOptions>.Equals
	|-Nullable<CopyEntitlementByIdOptions>.Equals
	|-Nullable<CopyEntitlementByIndexOptions>.Equals
	|-Nullable<CopyFileMetadataAtIndexOptions>.Equals
	|-Nullable<CopyFileMetadataAtIndexOptions>.Equals
	|-Nullable<CopyFileMetadataByFilenameOptions>.Equals
	|-Nullable<CopyFileMetadataByFilenameOptions>.Equals
	|-Nullable<CopyItemByIdOptions>.Equals
	|-Nullable<CopyLastRedeemedEntitlementByIndexOptions>.Equals
	|-Nullable<CopyLeaderboardUserScoreByIndexOptions>.Equals
	|-Nullable<CopyLeaderboardUserScoreByUserIdOptions>.Equals
	|-Nullable<CopyLobbyDetailsHandleOptions>.Equals
	|-Nullable<CopyModInfoOptions>.Equals
	|-Nullable<CopyOfferByIdOptions>.Equals
	|-Nullable<CopyOfferByIndexOptions>.Equals
	|-Nullable<CopyPermissionByIndexOptions>.Equals
	|-Nullable<CopyPlayerSanctionByIndexOptions>.Equals
	|-Nullable<CopyPresenceOptions>.Equals
	|-Nullable<CopyProductUserExternalAccountByAccountIdOptions>.Equals
	|-Nullable<CopyProductUserExternalAccountByAccountTypeOptions>.Equals
	|-Nullable<CopyProductUserExternalAccountByIndexOptions>.Equals
	|-Nullable<CopyStatByIndexOptions>.Equals
	|-Nullable<CopyStatByNameOptions>.Equals
	|-Nullable<CopyTransactionByIdOptions>.Equals
	|-Nullable<CopyTransactionByIndexOptions>.Equals
	|-Nullable<CopyUnlockedAchievementByAchievementIdOptions>.Equals
	|-Nullable<CopyUnlockedAchievementByIndexOptions>.Equals
	|-Nullable<CopyUserInfoOptions>.Equals
	|-Nullable<CopyUserTokenByUserIdOptions>.Equals
	|-Nullable<CreateDeviceIdCallbackInfo>.Equals
	|-Nullable<Credentials>.Equals
	|-Nullable<DataRecord>.Equals
	|-Nullable<DeleteDeviceIdCallbackInfo>.Equals
	|-Nullable<DeleteFileOptions>.Equals
	|-Nullable<DeletePersistentAuthCallbackInfo>.Equals
	|-Nullable<DestroyLobbyOptions>.Equals
	|-Nullable<DestroySessionCallbackInfo>.Equals
	|-Nullable<EGSDLCVerifyPurchaseOptionsPlatformSpecificOptions>.Equals
	|-Nullable<EGSIAPVerifyPurchaseOptionsPlatformSpecificOptions>.Equals
	|-Nullable<EndSessionCallbackInfo>.Equals
	|-Nullable<EnumerateModsOptions>.Equals
	|-Nullable<GetBlockedUserAtIndexOptions>.Equals
	|-Nullable<GetConnectStringOptions>.Equals
	|-Nullable<GetEntitlementsByNameCountOptions>.Equals
	|-Nullable<GetExternalUserInfoCountOptions>.Equals
	|-Nullable<GetFriendAtIndexOptions>.Equals
	|-Nullable<GetInviteIdByIndexOptions>.Equals
	|-Nullable<GetInviteIdByIndexOptions>.Equals
	|-Nullable<GetItemImageInfoCountOptions>.Equals
	|-Nullable<GetItemReleaseCountOptions>.Equals
	|-Nullable<GetJoinInfoOptions>.Equals
	|-Nullable<GetNextReceivedPacketSizeOptions>.Equals
	|-Nullable<GetOfferImageInfoCountOptions>.Equals
	|-Nullable<GetOfferItemCountOptions>.Equals
	|-Nullable<GetPermissionByKeyOptions>.Equals
	|-Nullable<GetRTCRoomNameOptions>.Equals
	|-Nullable<GetStatusOptions>.Equals
	|-Nullable<HasPresenceOptions>.Equals
	|-Nullable<IOSIAPVerifyPurchaseOptionsPlatformSpecificOptions>.Equals
	|-Nullable<IdToken>.Equals
	|-Nullable<IdToken>.Equals
	|-Nullable<IngestData>.Equals
	|-Nullable<IsRTCRoomConnectedOptions>.Equals
	|-Nullable<IsUserInSessionOptions>.Equals
	|-Nullable<ItemOwnership>.Equals
	|-Nullable<JoinSessionCallbackInfo>.Equals
	|-Nullable<JsonElement>.Equals
	|-Nullable<KickCompleteCallbackInfo>.Equals
	|-Nullable<KickOptions>.Equals
	|-Nullable<LeaderboardUserScore>.Equals
	|-Nullable<LeaveLobbyOptions>.Equals
	|-Nullable<LeaveRoomOptions>.Equals
	|-Nullable<LinkAccountOptions>.Equals
	|-Nullable<LobbyDetailsCopyMemberAttributeByIndexOptions>.Equals
	|-Nullable<LobbyDetailsCopyMemberAttributeByKeyOptions>.Equals
	|-Nullable<LobbyDetailsMemberInfo>.Equals
	|-Nullable<LobbySearchFindCallbackInfo>.Equals
	|-Nullable<LobbySearchRemoveParameterOptions>.Equals
	|-Nullable<LobbyUpdateReceivedCallbackInfo>.Equals
	|-Nullable<LogPlayerReviveOptions>.Equals
	|-Nullable<LogPlayerSpawnOptions>.Equals
	|-Nullable<MemoryMonitorCallbackInfo>.Equals
	|-Nullable<ModInfo>.Equals
	|-Nullable<OnCheckpointCompleteCallbackInfo>.Equals
	|-Nullable<OnCloseCompleteCallbackInfo>.Equals
	|-Nullable<OnDisplaySettingsUpdatedCallbackInfo>.Equals
	|-Nullable<OnQueryDefinitionsCompleteCallbackInfo>.Equals
	|-Nullable<OnQueryInputDevicesInformationCallbackInfo>.Equals
	|-Nullable<OnQueryLeaderboardDefinitionsCompleteCallbackInfo>.Equals
	|-Nullable<OnQueryLeaderboardUserScoresCompleteCallbackInfo>.Equals
	|-Nullable<OnQueryOutputDevicesInformationCallbackInfo>.Equals
	|-Nullable<Option>.Equals
	|-Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReport>.Equals
	|-Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReport>.Equals
	|-Nullable<PS5Options>.Equals
	|-Nullable<ParticipantMetadata>.Equals
	|-Nullable<PermissionStatus>.Equals
	|-Nullable<PlayerStatInfo>.Equals
	|-Nullable<QueryActivePlayerSanctionsOptions>.Equals
	|-Nullable<QueryEntitlementTokenOptions>.Equals
	|-Nullable<QueryFileListOptions>.Equals
	|-Nullable<QueryFileOptions>.Equals
	|-Nullable<QueryFileOptions>.Equals
	|-Nullable<QueryIdTokenOptions>.Equals
	|-Nullable<QueryLeaderboardRanksOptions>.Equals
	|-Nullable<QueryOffersOptions>.Equals
	|-Nullable<QueryOwnershipBySandboxIdsOptions>.Equals
	|-Nullable<QueryPlayerAchievementsOptions>.Equals
	|-Nullable<QueryPresenceOptions>.Equals
	|-Nullable<QueryUserInfoByDisplayNameOptions>.Equals
	|-Nullable<QueryUserInfoOptions>.Equals
	|-Nullable<RTCOptions>.Equals
	|-Nullable<ReceiveMessageFromServerOptions>.Equals
	|-Nullable<RedeemEntitlementsOptions>.Equals
	|-Nullable<RegexPrefix>.Equals
	|-Nullable<RegisterEventParamDef>.Equals
	|-Nullable<RegisterPlayersOptions>.Equals
	|-Nullable<RejectInviteCallbackInfo>.Equals
	|-Nullable<RejectInviteOptions>.Equals
	|-Nullable<RejectInviteOptions>.Equals
	|-Nullable<RejectInviteOptions>.Equals
	|-Nullable<RejectRequestToJoinOptions>.Equals
	|-Nullable<RequestPermissionsOptions>.Equals
	|-Nullable<SandboxIdItemOwnership>.Equals
	|-Nullable<SendCustomInviteOptions>.Equals
	|-Nullable<SendInviteCallbackInfo>.Equals
	|-Nullable<SendInviteOptions>.Equals
	|-Nullable<SendPlayerBehaviorReportCompleteCallbackInfo>.Equals
	|-Nullable<SendRequestToJoinOptions>.Equals
	|-Nullable<SessionSearchFindCallbackInfo>.Equals
	|-Nullable<SessionSearchRemoveParameterOptions>.Equals
	|-Nullable<SetClientDetailsOptions>.Equals
	|-Nullable<SetClientNetworkStateOptions>.Equals
	|-Nullable<SetCustomInviteOptions>.Equals
	|-Nullable<SetOutputDeviceSettingsOptions>.Equals
	|-Nullable<SetPacketQueueSizeOptions>.Equals
	|-Nullable<SetParticipantHardMuteCompleteCallbackInfo>.Equals
	|-Nullable<SetPresenceOptions>.Equals
	|-Nullable<SetSettingOptions>.Equals
	|-Nullable<ShowBlockPlayerOptions>.Equals
	|-Nullable<ShowNativeProfileOptions>.Equals
	|-Nullable<ShowReportPlayerOptions>.Equals
	|-Nullable<SocketIdInternal>.Equals
	|-Nullable<StartSessionCallbackInfo>.Equals
	|-Nullable<StatThresholds>.Equals
	|-Nullable<SteamDLCVerifyPurchaseOptionsPlatformSpecificOptions>.Equals
	|-Nullable<SubmitSnapshotCallbackInfo>.Equals
	|-Nullable<UnlockAchievementsOptions>.Equals
	|-Nullable<UnregisterPlayersOptions>.Equals
	|-Nullable<UpdateLobbyModificationOptions>.Equals
	|-Nullable<UpdateParentEmailOptions>.Equals
	|-Nullable<UserLoginInfo>.Equals
	|-Nullable<UserScoresQueryStatInfo>.Equals
	|-Nullable<UserToken>.Equals
	|-Nullable<VerifyPurchaseCompleteCallbackInfo>.Equals
	|-Nullable<VerifyUserAuthCallbackInfo>.Equals
	|-Nullable<WindowsRTCOptionsPlatformSpecificOptionsInternal>.Equals
	|-Nullable<XSXDLCVerifyPurchaseOptionsPlatformSpecificOptions>.Equals
	|-Nullable<XSXIAPVerifyPurchaseOptionsPlatformSpecificOptions>.Equals
	|-Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.Equals
	|-Nullable<XSXSubmitGraphicsCommandsDataCommand>.Equals
	|-Nullable<XSXXBLOptionsInitOptions>.Equals
	|-Nullable<XboxOneGDKDLCVerifyPurchaseOptionsPlatformSpecificOptions>.Equals
	|-Nullable<XboxOneGDKIAPVerifyPurchaseOptionsPlatformSpecificOptions>.Equals
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.Equals
	|-Nullable<XboxOneGDKSubmitGraphicsCommandsDataCommand>.Equals
	|-Nullable<XboxOneGDKXBLOptionsInitOptions>.Equals
	|
	|-RVA: 0xB4A580 Offset: 0xB49780 VA: 0x180B4A580
	|-Nullable<AccountFeatureRestrictedInfo>.Equals
	|-Nullable<AddExternalIntegrityCatalogOptions>.Equals
	|-Nullable<AudioDevicesChangedCallbackInfo>.Equals
	|-Nullable<BeginSnapshotOptions>.Equals
	|-Nullable<CheckoutEntry>.Equals
	|-Nullable<CopyAchievementDefinitionByAchievementIdOptions>.Equals
	|-Nullable<CopyAchievementDefinitionV2ByAchievementIdOptions>.Equals
	|-Nullable<CopyActiveSessionHandleOptions>.Equals
	|-Nullable<CopyIdTokenOptions>.Equals
	|-Nullable<CopyIdTokenOptions>.Equals
	|-Nullable<CopyLeaderboardDefinitionByLeaderboardIdOptions>.Equals
	|-Nullable<CopyLeaderboardRecordByUserIdOptions>.Equals
	|-Nullable<CopyLobbyDetailsHandleByInviteIdOptions>.Equals
	|-Nullable<CopyLobbyDetailsHandleByUiEventIdOptions>.Equals
	|-Nullable<CopyProductUserInfoOptions>.Equals
	|-Nullable<CopySessionHandleByInviteIdOptions>.Equals
	|-Nullable<CopySessionHandleByUiEventIdOptions>.Equals
	|-Nullable<CopySessionHandleForPresenceOptions>.Equals
	|-Nullable<CreateDeviceIdOptions>.Equals
	|-Nullable<CreatePresenceModificationOptions>.Equals
	|-Nullable<CreateUserOptions>.Equals
	|-Nullable<DeleteCacheOptions>.Equals
	|-Nullable<DeleteCacheOptions>.Equals
	|-Nullable<DeletePersistentAuthOptions>.Equals
	|-Nullable<DeleteSnapshotOptions>.Equals
	|-Nullable<DestroySessionOptions>.Equals
	|-Nullable<DumpSessionStateOptions>.Equals
	|-Nullable<EndSessionOptions>.Equals
	|-Nullable<GetBlockedUsersCountOptions>.Equals
	|-Nullable<GetEntitlementsCountOptions>.Equals
	|-Nullable<GetFileMetadataCountOptions>.Equals
	|-Nullable<GetFileMetadataCountOptions>.Equals
	|-Nullable<GetFriendsCountOptions>.Equals
	|-Nullable<GetFriendsExclusiveInputOptions>.Equals
	|-Nullable<GetFriendsVisibleOptions>.Equals
	|-Nullable<GetInviteCountOptions>.Equals
	|-Nullable<GetInviteCountOptions>.Equals
	|-Nullable<GetLastRedeemedEntitlementsCountOptions>.Equals
	|-Nullable<GetLeaderboardUserScoreCountOptions>.Equals
	|-Nullable<GetOfferCountOptions>.Equals
	|-Nullable<GetPermissionsCountOptions>.Equals
	|-Nullable<GetPlayerAchievementCountOptions>.Equals
	|-Nullable<GetPlayerSanctionCountOptions>.Equals
	|-Nullable<GetProductUserExternalAccountCountOptions>.Equals
	|-Nullable<GetStatCountOptions>.Equals
	|-Nullable<GetTransactionCountOptions>.Equals
	|-Nullable<GetUnlockedAchievementCountOptions>.Equals
	|-Nullable<HideFriendsOptions>.Equals
	|-Nullable<InventoryItemCreateSubItemOptions>.Equals
	|-Nullable<InventoryItemDeleteSubItemOptions>.Equals
	|-Nullable<InventoryItemGetSubItemOptions>.Equals
	|-Nullable<InventoryItemSetKeyOptions>.Equals
	|-Nullable<InventoryItemSetValueAsDoubleSetOptions>.Equals
	|-Nullable<InventoryItemSetValueAsInt64Options>.Equals
	|-Nullable<InventoryItemSetValueAsInt64SetOptions>.Equals
	|-Nullable<InventoryItemSetValueAsStringOptions>.Equals
	|-Nullable<InventoryItemSetValueAsStringSetOptions>.Equals
	|-Nullable<InventoryItemSetValueAsTimestampOptions>.Equals
	|-Nullable<LobbyDetailsCopyAttributeByKeyOptions>.Equals
	|-Nullable<LobbyDetailsCopyMemberInfoOptions>.Equals
	|-Nullable<LobbyDetailsGetMemberAttributeCountOptions>.Equals
	|-Nullable<LobbyModificationRemoveAttributeOptions>.Equals
	|-Nullable<LobbyModificationRemoveMemberAttributeOptions>.Equals
	|-Nullable<LobbyModificationSetAllowedPlatformIdsOptions>.Equals
	|-Nullable<LobbyModificationSetBucketIdOptions>.Equals
	|-Nullable<LobbySearchFindOptions>.Equals
	|-Nullable<LobbySearchSetLobbyIdOptions>.Equals
	|-Nullable<LobbySearchSetTargetUserIdOptions>.Equals
	|-Nullable<LogPlayerDespawnOptions>.Equals
	|-Nullable<LogoutOptions>.Equals
	|-Nullable<LogoutOptions>.Equals
	|-Nullable<ParseConnectStringOptions>.Equals
	|-Nullable<PrePresentOptions>.Equals
	|-Nullable<PresenceModificationDataRecordId>.Equals
	|-Nullable<PresenceModificationDeleteDataOptions>.Equals
	|-Nullable<PresenceModificationSetDataOptions>.Equals
	|-Nullable<PresenceModificationSetJoinInfoOptions>.Equals
	|-Nullable<PresenceModificationSetRawRichTextOptions>.Equals
	|-Nullable<QueryFileListOptions>.Equals
	|-Nullable<QueryFriendsOptions>.Equals
	|-Nullable<QueryInvitesOptions>.Equals
	|-Nullable<QueryInvitesOptions>.Equals
	|-Nullable<QueryPermissionsOptions>.Equals
	|-Nullable<RegisterPlatformAudioUserOptions>.Equals
	|-Nullable<RegisterPlatformUserOptions>.Equals
	|-Nullable<SessionDetailsCopySessionAttributeByKeyOptions>.Equals
	|-Nullable<SessionModificationRemoveAttributeOptions>.Equals
	|-Nullable<SessionModificationSetAllowedPlatformIdsOptions>.Equals
	|-Nullable<SessionModificationSetBucketIdOptions>.Equals
	|-Nullable<SessionModificationSetHostAddressOptions>.Equals
	|-Nullable<SessionSearchFindOptions>.Equals
	|-Nullable<SessionSearchSetSessionIdOptions>.Equals
	|-Nullable<SessionSearchSetTargetUserIdOptions>.Equals
	|-Nullable<SetGameSessionIdOptions>.Equals
	|-Nullable<ShowFriendsOptions>.Equals
	|-Nullable<StartSessionOptions>.Equals
	|-Nullable<SteamIAPVerifyPurchaseOptionsPlatformSpecificOptions>.Equals
	|-Nullable<SwitchIAPVerifyPurchaseOptionsPlatformSpecificOptions>.Equals
	|-Nullable<UnlinkAccountOptions>.Equals
	|-Nullable<UnregisterClientOptions>.Equals
	|-Nullable<UnregisterPeerOptions>.Equals
	|-Nullable<UnregisterPlatformAudioUserOptions>.Equals
	|-Nullable<UnregisterPlatformUserOptions>.Equals
	|-Nullable<UpdateLobbyOptions>.Equals
	|-Nullable<UpdateSessionModificationOptions>.Equals
	|-Nullable<UpdateSessionOptions>.Equals
	|-Nullable<WindowsRTCOptionsPlatformSpecificOptions>.Equals
	|-Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReport>.Equals
	|-Nullable<XSXOptionsSystemSpecificOptions>.Equals
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReport>.Equals
	|-Nullable<XboxOneGDKOptionsSystemSpecificOptions>.Equals
	|-Nullable<C.sentry_value_t>.Equals
	|
	|-RVA: 0x148DD40 Offset: 0x148CF40 VA: 0x18148DD40
	|-Nullable<ActiveSessionCopyInfoOptions>.Equals
	|-Nullable<ActiveSessionGetRegisteredPlayerCountOptions>.Equals
	|-Nullable<AddNotifyAchievementsUnlockedOptions>.Equals
	|-Nullable<AddNotifyAchievementsUnlockedV2Options>.Equals
	|-Nullable<AddNotifyAudioDevicesChangedOptions>.Equals
	|-Nullable<AddNotifyAuthExpirationOptions>.Equals
	|-Nullable<AddNotifyBlockedUsersUpdateOptions>.Equals
	|-Nullable<AddNotifyClientActionRequiredOptions>.Equals
	|-Nullable<AddNotifyClientAuthStatusChangedOptions>.Equals
	|-Nullable<AddNotifyClientIntegrityViolatedOptions>.Equals
	|-Nullable<AddNotifyCustomInviteAcceptedOptions>.Equals
	|-Nullable<AddNotifyCustomInviteReceivedOptions>.Equals
	|-Nullable<AddNotifyCustomInviteRejectedOptions>.Equals
	|-Nullable<AddNotifyDisplaySettingsUpdatedOptions>.Equals
	|-Nullable<AddNotifyFriendsUpdateOptions>.Equals
	|-Nullable<AddNotifyIncomingPacketQueueFullOptions>.Equals
	|-Nullable<AddNotifyJoinGameAcceptedOptions>.Equals
	|-Nullable<AddNotifyJoinLobbyAcceptedOptions>.Equals
	|-Nullable<AddNotifyJoinSessionAcceptedOptions>.Equals
	|-Nullable<AddNotifyLeaveLobbyRequestedOptions>.Equals
	|-Nullable<AddNotifyLeaveSessionRequestedOptions>.Equals
	|-Nullable<AddNotifyLobbyInviteAcceptedOptions>.Equals
	|-Nullable<AddNotifyLobbyInviteReceivedOptions>.Equals
	|-Nullable<AddNotifyLobbyInviteRejectedOptions>.Equals
	|-Nullable<AddNotifyLobbyMemberStatusReceivedOptions>.Equals
	|-Nullable<AddNotifyLobbyMemberUpdateReceivedOptions>.Equals
	|-Nullable<AddNotifyLobbyUpdateReceivedOptions>.Equals
	|-Nullable<AddNotifyLoginStatusChangedOptions>.Equals
	|-Nullable<AddNotifyLoginStatusChangedOptions>.Equals
	|-Nullable<AddNotifyMemoryMonitorOptions>.Equals
	|-Nullable<AddNotifyMessageToClientOptions>.Equals
	|-Nullable<AddNotifyMessageToPeerOptions>.Equals
	|-Nullable<AddNotifyMessageToServerOptions>.Equals
	|-Nullable<AddNotifyOnPresenceChangedOptions>.Equals
	|-Nullable<AddNotifyPeerActionRequiredOptions>.Equals
	|-Nullable<AddNotifyPeerAuthStatusChangedOptions>.Equals
	|-Nullable<AddNotifyPermissionsUpdateReceivedOptions>.Equals
	|-Nullable<AddNotifyRequestToJoinAcceptedOptions>.Equals
	|-Nullable<AddNotifyRequestToJoinReceivedOptions>.Equals
	|-Nullable<AddNotifyRequestToJoinRejectedOptions>.Equals
	|-Nullable<AddNotifyRequestToJoinResponseReceivedOptions>.Equals
	|-Nullable<AddNotifySendCustomNativeInviteRequestedOptions>.Equals
	|-Nullable<AddNotifySendLobbyNativeInviteRequestedOptions>.Equals
	|-Nullable<AddNotifySendSessionNativeInviteRequestedOptions>.Equals
	|-Nullable<AddNotifySessionInviteAcceptedOptions>.Equals
	|-Nullable<AddNotifySessionInviteReceivedOptions>.Equals
	|-Nullable<AddNotifySessionInviteRejectedOptions>.Equals
	|-Nullable<AddNotifyUserLoginStatusChangedOptions>.Equals
	|-Nullable<ClearUserPreLogoutCallbackOptions>.Equals
	|-Nullable<CopyUserAuthTokenOptions>.Equals
	|-Nullable<CreateIntegratedPlatformOptionsContainerOptions>.Equals
	|-Nullable<DeleteDeviceIdOptions>.Equals
	|-Nullable<EndSessionOptions>.Equals
	|-Nullable<EndSessionOptions>.Equals
	|-Nullable<GetAchievementDefinitionCountOptions>.Equals
	|-Nullable<GetAudioInputDevicesCountOptions>.Equals
	|-Nullable<GetAudioOutputDevicesCountOptions>.Equals
	|-Nullable<GetDesktopCrossplayStatusOptions>.Equals
	|-Nullable<GetInputDevicesCountOptions>.Equals
	|-Nullable<GetLeaderboardDefinitionCountOptions>.Equals
	|-Nullable<GetLeaderboardRecordCountOptions>.Equals
	|-Nullable<GetLocalPlatformTypeOptions>.Equals
	|-Nullable<GetNATTypeOptions>.Equals
	|-Nullable<GetOutputDevicesCountOptions>.Equals
	|-Nullable<GetPacketQueueInfoOptions>.Equals
	|-Nullable<GetPortRangeOptions>.Equals
	|-Nullable<GetRelayControlOptions>.Equals
	|-Nullable<GetToggleFriendsButtonOptions>.Equals
	|-Nullable<GetToggleFriendsKeyOptions>.Equals
	|-Nullable<InventoryItemGetKeyOptions>.Equals
	|-Nullable<InventoryItemGetSubItemsCountOptions>.Equals
	|-Nullable<InventoryItemGetValueAsBoolOptions>.Equals
	|-Nullable<InventoryItemGetValueAsDoubleOptions>.Equals
	|-Nullable<InventoryItemGetValueAsInt64Options>.Equals
	|-Nullable<InventoryItemGetValueAsStringOptions>.Equals
	|-Nullable<InventoryItemGetValueAsTimestampOptions>.Equals
	|-Nullable<InventoryItemGetValueCountOptions>.Equals
	|-Nullable<InventoryItemGetValueTypeOptions>.Equals
	|-Nullable<InventoryItemSetValueAsBoolOptions>.Equals
	|-Nullable<IsSocialOverlayPausedOptions>.Equals
	|-Nullable<LobbyDetailsCopyInfoOptions>.Equals
	|-Nullable<LobbyDetailsGetAttributeCountOptions>.Equals
	|-Nullable<LobbyDetailsGetLobbyOwnerOptions>.Equals
	|-Nullable<LobbyDetailsGetMemberCountOptions>.Equals
	|-Nullable<LobbyModificationSetInvitesAllowedOptions>.Equals
	|-Nullable<LobbySearchGetSearchResultCountOptions>.Equals
	|-Nullable<PS5OptionsInitOptions>.Equals
	|-Nullable<PauseSocialOverlayOptions>.Equals
	|-Nullable<QueryAgeGateOptions>.Equals
	|-Nullable<QueryInputDevicesInformationOptions>.Equals
	|-Nullable<QueryNATTypeOptions>.Equals
	|-Nullable<QueryOutputDevicesInformationOptions>.Equals
	|-Nullable<SessionDetailsCopyInfoOptions>.Equals
	|-Nullable<SessionDetailsGetSessionAttributeCountOptions>.Equals
	|-Nullable<SessionModificationSetInvitesAllowedOptions>.Equals
	|-Nullable<SessionModificationSetJoinInProgressAllowedOptions>.Equals
	|-Nullable<SessionSearchGetSearchResultCountOptions>.Equals
	|-Nullable<SetUserPreLogoutCallbackOptions>.Equals
	|-Nullable<TransactionGetEntitlementsCountOptions>.Equals
	|
	|-RVA: 0xB4A430 Offset: 0xB49630 VA: 0x180B4A430
	|-Nullable<ActiveSessionGetRegisteredPlayerByIndexOptions>.Equals
	|-Nullable<CopyAchievementDefinitionByIndexOptions>.Equals
	|-Nullable<CopyAchievementDefinitionV2ByIndexOptions>.Equals
	|-Nullable<CopyInputDeviceInformationByIndexOptions>.Equals
	|-Nullable<CopyLeaderboardDefinitionByIndexOptions>.Equals
	|-Nullable<CopyLeaderboardRecordByIndexOptions>.Equals
	|-Nullable<CopyOutputDeviceInformationByIndexOptions>.Equals
	|-Nullable<CreateLobbySearchOptions>.Equals
	|-Nullable<CreateSessionSearchOptions>.Equals
	|-Nullable<EndSnapshotOptions>.Equals
	|-Nullable<GetAudioInputDeviceByIndexOptions>.Equals
	|-Nullable<GetAudioOutputDeviceByIndexOptions>.Equals
	|-Nullable<GetProtectMessageOutputLengthOptions>.Equals
	|-Nullable<GetProtectMessageOutputLengthOptions>.Equals
	|-Nullable<Int32Enum>.Equals
	|-Nullable<InventoryItemGetDoubleSetValueByIndexOptions>.Equals
	|-Nullable<InventoryItemGetInt64SetValueByIndexOptions>.Equals
	|-Nullable<InventoryItemGetStringSetValueByIndexOptions>.Equals
	|-Nullable<InventoryItemGetSubItemByIndexOptions>.Equals
	|-Nullable<LobbyDetailsCopyAttributeByIndexOptions>.Equals
	|-Nullable<LobbyDetailsGetMemberByIndexOptions>.Equals
	|-Nullable<LobbyModificationSetMaxMembersOptions>.Equals
	|-Nullable<LobbyModificationSetPermissionLevelOptions>.Equals
	|-Nullable<LobbySearchCopySearchResultByIndexOptions>.Equals
	|-Nullable<LobbySearchSetMaxResultsOptions>.Equals
	|-Nullable<LogGameRoundEndOptions>.Equals
	|-Nullable<PollStatusOptions>.Equals
	|-Nullable<PresenceModificationSetStatusOptions>.Equals
	|-Nullable<SessionDetailsCopySessionAttributeByIndexOptions>.Equals
	|-Nullable<SessionModificationSetMaxPlayersOptions>.Equals
	|-Nullable<SessionModificationSetPermissionLevelOptions>.Equals
	|-Nullable<SessionSearchCopySearchResultByIndexOptions>.Equals
	|-Nullable<SessionSearchSetMaxResultsOptions>.Equals
	|-Nullable<SetDisplayPreferenceOptions>.Equals
	|-Nullable<SetRelayControlOptions>.Equals
	|-Nullable<SetToggleFriendsButtonOptions>.Equals
	|-Nullable<SetToggleFriendsKeyOptions>.Equals
	|-Nullable<SubmitSnapshotOptions>.Equals
	|-Nullable<TransactionCopyEntitlementByIndexOptions>.Equals
	|-Nullable<XSXPrePresentAdditionalData>.Equals
	|-Nullable<XboxOneGDKPrePresentAdditionalData>.Equals
	|
	|-RVA: 0x148DDE0 Offset: 0x148CFE0 VA: 0x18148DDE0
	|-Nullable<ActiveSessionInfo>.Equals
	|
	|-RVA: 0xB4AE40 Offset: 0xB4A040 VA: 0x180B4AE40
	|-Nullable<ActiveSessionInfoInternal>.Equals
	|-Nullable<BestDisplayName>.Equals
	|-Nullable<CatalogReleaseInternal>.Equals
	|-Nullable<CreateUserCallbackInfo>.Equals
	|-Nullable<Credentials>.Equals
	|-Nullable<CustomInviteRejectedCallbackInfo>.Equals
	|-Nullable<Entitlement>.Equals
	|-Nullable<FileMetadataInternal>.Equals
	|-Nullable<JoinGameAcceptedCallbackInfo>.Equals
	|-Nullable<JoinLobbyByIdOptions>.Equals
	|-Nullable<JoinLobbyOptions>.Equals
	|-Nullable<JoinRoomCallbackInfo>.Equals
	|-Nullable<LobbyInviteAcceptedCallbackInfo>.Equals
	|-Nullable<LobbyInviteRejectedCallbackInfo>.Equals
	|-Nullable<ModIdentifier>.Equals
	|-Nullable<OnCustomInviteAcceptedCallbackInfo>.Equals
	|-Nullable<OnCustomInviteReceivedCallbackInfo>.Equals
	|-Nullable<OnIncomingPacketQueueFullInfo>.Equals
	|-Nullable<PS4SubmitGraphicsCommandsCallbackInfo>.Equals
	|-Nullable<ParticipantUpdatedCallbackInfo>.Equals
	|-Nullable<ParticipantUpdatedCallbackInfo>.Equals
	|-Nullable<PinGrantInfoInternal>.Equals
	|-Nullable<PlayerSanctionInternal>.Equals
	|-Nullable<QueryJoinRoomTokenCompleteCallbackInfo>.Equals
	|-Nullable<QueryUserInfoByDisplayNameCallbackInfo>.Equals
	|-Nullable<ReadFileOptions>.Equals
	|-Nullable<ReadFileOptions>.Equals
	|-Nullable<RegisterClientOptions>.Equals
	|-Nullable<SendAudioOptions>.Equals
	|-Nullable<SendPlayerBehaviorReportOptions>.Equals
	|-Nullable<SessionInviteAcceptedCallbackInfo>.Equals
	|-Nullable<SessionInviteRejectedCallbackInfo>.Equals
	|-Nullable<StatInternal>.Equals
	|-Nullable<SteamIAPVerifyPurchaseOptions>.Equals
	|-Nullable<SwitchIAPVerifyPurchaseOptions>.Equals
	|-Nullable<UpdateReceivingVolumeCallbackInfo>.Equals
	|-Nullable<UpdateSendingCallbackInfo>.Equals
	|-Nullable<UpdateSendingCallbackInfo>.Equals
	|-Nullable<UpdateSendingVolumeCallbackInfo>.Equals
	|-Nullable<UserPreLogoutCallbackInfo>.Equals
	|-Nullable<WriteFileOptions>.Equals
	|-Nullable<XSXXBLOptions>.Equals
	|-Nullable<XboxOneGDKXBLOptions>.Equals
	|
	|-RVA: 0xB4A620 Offset: 0xB49820 VA: 0x180B4A620
	|-Nullable<AddNotifyAudioBeforeRenderOptions>.Equals
	|-Nullable<AddProgressionOptions>.Equals
	|-Nullable<AndroidInitializeOptionsSystemInitializeOptions>.Equals
	|-Nullable<AttributeInternal>.Equals
	|-Nullable<AudioInputDeviceInfo>.Equals
	|-Nullable<AudioInputDeviceInfoInternal>.Equals
	|-Nullable<AudioOutputDeviceInfo>.Equals
	|-Nullable<AudioOutputDeviceInfoInternal>.Equals
	|-Nullable<BeginPlayerSessionOptionsAccountId>.Equals
	|-Nullable<CatalogRelease>.Equals
	|-Nullable<CheckoutOptions>.Equals
	|-Nullable<CheckpointOptions>.Equals
	|-Nullable<CloseOptions>.Equals
	|-Nullable<CopyBestDisplayNameWithPlatformOptions>.Equals
	|-Nullable<CopyEntitlementByNameAndIndexOptions>.Equals
	|-Nullable<CopyExternalUserInfoByAccountIdOptions>.Equals
	|-Nullable<CopyExternalUserInfoByAccountTypeOptions>.Equals
	|-Nullable<CopyExternalUserInfoByIndexOptions>.Equals
	|-Nullable<CopyItemImageInfoByIndexOptions>.Equals
	|-Nullable<CopyItemReleaseByIndexOptions>.Equals
	|-Nullable<CopyOfferImageInfoByIndexOptions>.Equals
	|-Nullable<CopyOfferItemByIndexOptions>.Equals
	|-Nullable<CopyPlayerAchievementByAchievementIdOptions>.Equals
	|-Nullable<CopyPlayerAchievementByIndexOptions>.Equals
	|-Nullable<CreateLobbyCallbackInfo>.Equals
	|-Nullable<CreateOptions>.Equals
	|-Nullable<CreatePlayerSanctionAppealCallbackInfo>.Equals
	|-Nullable<CreatePlayerSanctionAppealOptions>.Equals
	|-Nullable<CreateUserCallbackInfo>.Equals
	|-Nullable<CreateUserOptions>.Equals
	|-Nullable<DeleteCacheCallbackInfo>.Equals
	|-Nullable<DeleteCacheCallbackInfo>.Equals
	|-Nullable<DeleteFileCallbackInfo>.Equals
	|-Nullable<DeleteSnapshotCallbackInfo>.Equals
	|-Nullable<DestroyLobbyCallbackInfo>.Equals
	|-Nullable<DuplicateFileCallbackInfo>.Equals
	|-Nullable<DuplicateFileOptions>.Equals
	|-Nullable<EndPlayerSessionOptions>.Equals
	|-Nullable<EndPlayerSessionOptionsAccountId>.Equals
	|-Nullable<FinalizeDeferredUserLogoutOptions>.Equals
	|-Nullable<GetExternalAccountMappingsOptions>.Equals
	|-Nullable<GetProductUserIdMappingOptions>.Equals
	|-Nullable<HideFriendsCallbackInfo>.Equals
	|-Nullable<IOSCredentialsSystemAuthCredentialsOptions>.Equals
	|-Nullable<IdTokenInternal>.Equals
	|-Nullable<IdTokenInternal>.Equals
	|-Nullable<IngestStatOptions>.Equals
	|-Nullable<InputDeviceInformation>.Equals
	|-Nullable<InputDeviceInformationInternal>.Equals
	|-Nullable<JoinLobbyAcceptedCallbackInfo>.Equals
	|-Nullable<JoinLobbyByIdCallbackInfo>.Equals
	|-Nullable<JoinLobbyCallbackInfo>.Equals
	|-Nullable<JoinSessionAcceptedCallbackInfo>.Equals
	|-Nullable<JsonPosition>.Equals
	|-Nullable<KeyImageInfo>.Equals
	|-Nullable<KickMemberCallbackInfo>.Equals
	|-Nullable<KickMemberOptions>.Equals
	|-Nullable<LeaderboardRecord>.Equals
	|-Nullable<LeaderboardUserScoreInternal>.Equals
	|-Nullable<LeaveLobbyCallbackInfo>.Equals
	|-Nullable<LeaveLobbyRequestedCallbackInfo>.Equals
	|-Nullable<LeaveSessionRequestedCallbackInfo>.Equals
	|-Nullable<LinkAccountCallbackInfo>.Equals
	|-Nullable<LinkAccountOptions>.Equals
	|-Nullable<LobbyDetailsMemberInfoInternal>.Equals
	|-Nullable<LobbyMemberUpdateReceivedCallbackInfo>.Equals
	|-Nullable<LogEventOptions>.Equals
	|-Nullable<LogMessage>.Equals
	|-Nullable<LogPlayerUseAbilityOptions>.Equals
	|-Nullable<LoginStatusChangedCallbackInfo>.Equals
	|-Nullable<LoginStatusChangedCallbackInfo>.Equals
	|-Nullable<LogoutCallbackInfo>.Equals
	|-Nullable<LogoutCallbackInfo>.Equals
	|-Nullable<ModInfoInternal>.Equals
	|-Nullable<OnAchievementsUnlockedCallbackInfo>.Equals
	|-Nullable<OnClientAuthStatusChangedCallbackInfo>.Equals
	|-Nullable<OnClientIntegrityViolatedCallbackInfo>.Equals
	|-Nullable<OnCreateCompleteCallbackInfo>.Equals
	|-Nullable<OnMessageToServerCallbackInfo>.Equals
	|-Nullable<OnOpenCompleteCallbackInfo>.Equals
	|-Nullable<OnQueryLeaderboardRanksCompleteCallbackInfo>.Equals
	|-Nullable<OnQueryNATTypeCompleteInfo>.Equals
	|-Nullable<OnRegisterPlatformUserCallbackInfo>.Equals
	|-Nullable<OnRequestToJoinAcceptedCallbackInfo>.Equals
	|-Nullable<OnRequestToJoinRejectedCallbackInfo>.Equals
	|-Nullable<OnSetInputDeviceSettingsCallbackInfo>.Equals
	|-Nullable<OnSetOutputDeviceSettingsCallbackInfo>.Equals
	|-Nullable<OnUnregisterPlatformUserCallbackInfo>.Equals
	|-Nullable<OpenOptions>.Equals
	|-Nullable<Options>.Equals
	|-Nullable<OutputDeviceInformation>.Equals
	|-Nullable<OutputDeviceInformationInternal>.Equals
	|-Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.Equals
	|-Nullable<PS4OptionsInitOptions>.Equals
	|-Nullable<PS5IntegratedPlatformOptionsContainerAddOptions>.Equals
	|-Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.Equals
	|-Nullable<PermissionStatusInternal>.Equals
	|-Nullable<PresenceChangedCallbackInfo>.Equals
	|-Nullable<PromoteMemberCallbackInfo>.Equals
	|-Nullable<PromoteMemberOptions>.Equals
	|-Nullable<ProtectMessageOptions>.Equals
	|-Nullable<QueryDefinitionsOptions>.Equals
	|-Nullable<QueryEntitlementsCallbackInfo>.Equals
	|-Nullable<QueryEntitlementsOptions>.Equals
	|-Nullable<QueryExternalAccountMappingsCallbackInfo>.Equals
	|-Nullable<QueryExternalAccountMappingsOptions>.Equals
	|-Nullable<QueryFileCallbackInfo>.Equals
	|-Nullable<QueryFileCallbackInfo>.Equals
	|-Nullable<QueryFriendsCallbackInfo>.Equals
	|-Nullable<QueryInvitesCallbackInfo>.Equals
	|-Nullable<QueryInvitesCallbackInfo>.Equals
	|-Nullable<QueryOffersCallbackInfo>.Equals
	|-Nullable<QueryOwnershipOptions>.Equals
	|-Nullable<QueryOwnershipTokenOptions>.Equals
	|-Nullable<QueryProductUserIdMappingsCallbackInfo>.Equals
	|-Nullable<QueryProductUserIdMappingsOptions>.Equals
	|-Nullable<QueryUserInfoByExternalAccountOptions>.Equals
	|-Nullable<ReceiveMessageFromClientOptions>.Equals
	|-Nullable<ReceiveMessageFromPeerOptions>.Equals
	|-Nullable<RejectInviteCallbackInfo>.Equals
	|-Nullable<RequestPermissionsCallbackInfo>.Equals
	|-Nullable<RequestToJoinReceivedCallbackInfo>.Equals
	|-Nullable<SendInviteCallbackInfo>.Equals
	|-Nullable<SendInviteOptions>.Equals
	|-Nullable<SendInviteOptions>.Equals
	|-Nullable<SessionDetailsAttributeInternal>.Equals
	|-Nullable<SetAudioInputSettingsOptions>.Equals
	|-Nullable<SetAudioOutputSettingsOptions>.Equals
	|-Nullable<SetInputDeviceSettingsOptions>.Equals
	|-Nullable<SetParticipantHardMuteOptions>.Equals
	|-Nullable<SetPresenceCallbackInfo>.Equals
	|-Nullable<SetUserLoginStatusOptions>.Equals
	|-Nullable<ShowFriendsCallbackInfo>.Equals
	|-Nullable<TransferDeviceIdAccountCallbackInfo>.Equals
	|-Nullable<TransferDeviceIdAccountOptions>.Equals
	|-Nullable<UnlinkAccountCallbackInfo>.Equals
	|-Nullable<UnlockedAchievementInternal>.Equals
	|-Nullable<UnprotectMessageOptions>.Equals
	|-Nullable<UnregisterPlayersCallbackInfo>.Equals
	|-Nullable<UpdateLobbyCallbackInfo>.Equals
	|-Nullable<UpdateParentEmailCallbackInfo>.Equals
	|-Nullable<UpdateReceivingVolumeOptions>.Equals
	|-Nullable<UpdateSendingOptions>.Equals
	|-Nullable<UpdateSendingOptions>.Equals
	|-Nullable<UpdateSendingVolumeOptions>.Equals
	|-Nullable<UserTokenInternal>.Equals
	|-Nullable<VerifyIdTokenOptions>.Equals
	|-Nullable<VerifyIdTokenOptions>.Equals
	|-Nullable<WindowsRTCOptions>.Equals
	|-Nullable<XSXMemoryMonitorCallbackInfo>.Equals
	|-Nullable<XSXSubmitGraphicsCommandsCallbackInfo>.Equals
	|-Nullable<XSXXBLOptionsInitOptionsInternal>.Equals
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfo>.Equals
	|-Nullable<XboxOneGDKSubmitGraphicsCommandsCallbackInfo>.Equals
	|-Nullable<XboxOneGDKXBLOptionsInitOptionsInternal>.Equals
	|
	|-RVA: 0xB4A4D0 Offset: 0xB496D0 VA: 0x180B4A4D0
	|-Nullable<AddNotifyPeerConnectionClosedOptions>.Equals
	|-Nullable<AddNotifyPeerConnectionEstablishedOptions>.Equals
	|-Nullable<AddNotifyPeerConnectionInterruptedOptions>.Equals
	|-Nullable<AddNotifyPeerConnectionRequestOptions>.Equals
	|-Nullable<AndroidIAPVerifyPurchaseOptions>.Equals
	|-Nullable<AudioBeforeSendCallbackInfo>.Equals
	|-Nullable<BestDisplayNameInternal>.Equals
	|-Nullable<BlockParticipantCallbackInfo>.Equals
	|-Nullable<CloseConnectionsOptions>.Equals
	|-Nullable<DataReceivedCallbackInfo>.Equals
	|-Nullable<DefinitionInternal>.Equals
	|-Nullable<EGSDLCVerifyPurchaseOptions>.Equals
	|-Nullable<EGSIAPVerifyPurchaseOptions>.Equals
	|-Nullable<EntitlementInternal>.Equals
	|-Nullable<ExternalAccountInfoInternal>.Equals
	|-Nullable<IOSIAPVerifyPurchaseOptions>.Equals
	|-Nullable<JoinRoomOptions>.Equals
	|-Nullable<LoginOptions>.Equals
	|-Nullable<ModIdentifierInternal>.Equals
	|-Nullable<OnAchievementsUnlockedCallbackV2Info>.Equals
	|-Nullable<PS4Options>.Equals
	|-Nullable<PS4PrePresentOptionsPlatformSpecificData>.Equals
	|-Nullable<PS5PrePresentOptionsPlatformSpecificData>.Equals
	|-Nullable<PacketQueueInfo>.Equals
	|-Nullable<PermissionsUpdateReceivedCallbackInfo>.Equals
	|-Nullable<QueryUserInfoByExternalAccountCallbackInfo>.Equals
	|-Nullable<ReadFileDataCallbackInfo>.Equals
	|-Nullable<ReadFileDataCallbackInfo>.Equals
	|-Nullable<RegisterPeerOptions>.Equals
	|-Nullable<SendCustomNativeInviteRequestedCallbackInfo>.Equals
	|-Nullable<SendLobbyNativeInviteRequestedCallbackInfo>.Equals
	|-Nullable<SendSessionNativeInviteRequestedCallbackInfo>.Equals
	|-Nullable<SteamDLCVerifyPurchaseOptions>.Equals
	|-Nullable<UpdateParticipantVolumeCallbackInfo>.Equals
	|-Nullable<UpdateReceivingCallbackInfo>.Equals
	|-Nullable<UpdateReceivingCallbackInfo>.Equals
	|-Nullable<UserInfoData>.Equals
	|-Nullable<UserLoginStatusChangedCallbackInfo>.Equals
	|-Nullable<XSXDLCVerifyPurchaseOptions>.Equals
	|-Nullable<XSXIAPVerifyPurchaseOptions>.Equals
	|-Nullable<XSXIntegratedPlatformOptionsContainerAddOptions>.Equals
	|-Nullable<XboxOneGDKDLCVerifyPurchaseOptions>.Equals
	|-Nullable<XboxOneGDKIAPVerifyPurchaseOptions>.Equals
	|-Nullable<XboxOneGDKIntegratedPlatformOptionsContainerAddOptions>.Equals
	|
	|-RVA: 0x148E030 Offset: 0x148D230 VA: 0x18148E030
	|-Nullable<AndroidInitializeOptions>.Equals
	|
	|-RVA: 0xB4A810 Offset: 0xB49A10 VA: 0x180B4A810
	|-Nullable<Announcement>.Equals
	|-Nullable<AttributeData>.Equals
	|-Nullable<AttributeData>.Equals
	|-Nullable<CreateSessionModificationOptions>.Equals
	|-Nullable<IOSCredentials>.Equals
	|-Nullable<InitializeThreadAffinity>.Equals
	|-Nullable<InstallModOptions>.Equals
	|-Nullable<LogPlayerUseWeaponOptions>.Equals
	|-Nullable<LoginOptions>.Equals
	|-Nullable<OnIncomingConnectionRequestInfo>.Equals
	|-Nullable<OnPeerConnectionInterruptedInfo>.Equals
	|-Nullable<PS4DLCVerifyPurchaseOptions>.Equals
	|-Nullable<PS4IAPVerifyPurchaseOptions>.Equals
	|-Nullable<PS5DLCVerifyPurchaseOptions>.Equals
	|-Nullable<PS5IAPVerifyPurchaseOptions>.Equals
	|-Nullable<Stat>.Equals
	|-Nullable<XSXPrePresentOptions>.Equals
	|-Nullable<XboxOneGDKPrePresentOptions>.Equals
	|
	|-RVA: 0x148DEE0 Offset: 0x148D0E0 VA: 0x18148DEE0
	|-Nullable<Attribute>.Equals
	|-Nullable<CatalogItem>.Equals
	|-Nullable<CreateLobbyOptions>.Equals
	|-Nullable<DefinitionV2>.Equals
	|-Nullable<InfoInternal>.Equals
	|-Nullable<LobbyModificationAddAttributeOptions>.Equals
	|-Nullable<LobbyModificationAddMemberAttributeOptions>.Equals
	|-Nullable<LobbySearchSetParameterOptions>.Equals
	|-Nullable<PS4InitializeOptionsSystemInitializeOptions>.Equals
	|-Nullable<PlayerAchievement>.Equals
	|-Nullable<PlayerAchievementInternal>.Equals
	|-Nullable<SessionDetailsAttribute>.Equals
	|-Nullable<SessionDetailsInfo>.Equals
	|-Nullable<SessionModificationAddAttributeOptions>.Equals
	|-Nullable<SessionSearchSetParameterOptions>.Equals
	|-Nullable<Token>.Equals
	|
	|-RVA: 0x149C4C0 Offset: 0x149B6C0 VA: 0x18149C4C0
	|-Nullable<BigInteger>.Equals
	|
	|-RVA: 0x149C690 Offset: 0x149B890 VA: 0x18149C690
	|-Nullable<bool>.Equals
	|
	|-RVA: 0x149C810 Offset: 0x149BA10 VA: 0x18149C810
	|-Nullable<byte>.Equals
	|
	|-RVA: 0x149C9B0 Offset: 0x149BBB0 VA: 0x18149C9B0
	|-Nullable<CatalogItemInternal>.Equals
	|-Nullable<Definition>.Equals
	|-Nullable<DefinitionV2Internal>.Equals
	|-Nullable<IOSLoginOptions>.Equals
	|-Nullable<LobbyDetailsInfoInternal>.Equals
	|-Nullable<TokenInternal>.Equals
	|-Nullable<VerifyIdTokenCallbackInfo>.Equals
	|-Nullable<VerifyUserAuthOptions>.Equals
	|
	|-RVA: 0x149C580 Offset: 0x149B780 VA: 0x18149C580
	|-Nullable<CatalogOffer>.Equals
	|-Nullable<CatalogOfferInternal>.Equals
	|
	|-RVA: 0x149C750 Offset: 0x149B950 VA: 0x18149C750
	|-Nullable<char>.Equals
	|
	|-RVA: 0x149C880 Offset: 0x149BA80 VA: 0x18149C880
	|-Nullable<Color>.Equals
	|
	|-RVA: 0xB4A6D0 Offset: 0xB498D0 VA: 0x180B4A6D0
	|-Nullable<CopyUserTokenByIndexOptions>.Equals
	|-Nullable<DesktopCrossplayStatusInfo>.Equals
	|-Nullable<LocalRTCOptions>.Equals
	|-Nullable<PS5OptionsInitOptionsInternal>.Equals
	|-Nullable<PageQuery>.Equals
	|-Nullable<XSXPrePresentAdditionalDataInternal>.Equals
	|-Nullable<XboxOneGDKPrePresentAdditionalDataInternal>.Equals
	|
	|-RVA: 0x14ACA70 Offset: 0x14ABC70 VA: 0x1814ACA70
	|-Nullable<DataKey>.Equals
	|
	|-RVA: 0x14AC800 Offset: 0x14ABA00 VA: 0x1814AC800
	|-Nullable<DateTime>.Equals
	|
	|-RVA: 0x14AC740 Offset: 0x14AB940 VA: 0x1814AC740
	|-Nullable<DateTimeOffset>.Equals
	|
	|-RVA: 0x14AC9B0 Offset: 0x14ABBB0 VA: 0x1814AC9B0
	|-Nullable<Decimal>.Equals
	|
	|-RVA: 0x14AC5F0 Offset: 0x14AB7F0 VA: 0x1814AC5F0
	|-Nullable<Definition>.Equals
	|-Nullable<Info>.Equals
	|-Nullable<InstallModCallbackInfo>.Equals
	|-Nullable<LinkAccountCallbackInfo>.Equals
	|-Nullable<LogPlayerTickOptions>.Equals
	|-Nullable<OnPeerConnectionEstablishedInfo>.Equals
	|-Nullable<OnRemoteConnectionClosedInfo>.Equals
	|-Nullable<PS5InitializeOptionsSystemInitializeOptions>.Equals
	|-Nullable<QueryLeaderboardUserScoresOptions>.Equals
	|-Nullable<QueryStatsOptions>.Equals
	|-Nullable<UninstallModCallbackInfo>.Equals
	|-Nullable<UpdateModCallbackInfo>.Equals
	|
	|-RVA: 0x14AC8C0 Offset: 0x14ABAC0 VA: 0x1814AC8C0
	|-Nullable<DefinitionInternal>.Equals
	|-Nullable<LoginCallbackInfo>.Equals
	|-Nullable<SendPacketOptions>.Equals
	|-Nullable<VerifyIdTokenCallbackInfo>.Equals
	|
	|-RVA: 0x14AC6D0 Offset: 0x14AB8D0 VA: 0x1814AC6D0
	|-Nullable<double>.Equals
	|
	|-RVA: 0x14ACB50 Offset: 0x14ABD50 VA: 0x1814ACB50
	|-Nullable<EventDispatcherGate>.Equals
	|
	|-RVA: 0x14ACAE0 Offset: 0x14ABCE0 VA: 0x1814ACAE0
	|-Nullable<GCHandle>.Equals
	|
	|-RVA: 0x14BC620 Offset: 0x14BB820 VA: 0x1814BC620
	|-Nullable<Guid>.Equals
	|
	|-RVA: 0x14BC520 Offset: 0x14BB720 VA: 0x1814BC520
	|-Nullable<InitializeOptions>.Equals
	|
	|-RVA: 0x14BC4B0 Offset: 0x14BB6B0 VA: 0x1814BC4B0
	|-Nullable<short>.Equals
	|
	|-RVA: 0x14BC690 Offset: 0x14BB890 VA: 0x1814BC690
	|-Nullable<Int16Enum>.Equals
	|-Nullable<UInt16Enum>.Equals
	|
	|-RVA: 0x14BC440 Offset: 0x14BB640 VA: 0x1814BC440
	|-Nullable<int>.Equals
	|
	|-RVA: 0x14BC3D0 Offset: 0x14BB5D0 VA: 0x1814BC3D0
	|-Nullable<long>.Equals
	|
	|-RVA: 0x14BC7D0 Offset: 0x14BB9D0 VA: 0x1814BC7D0
	|-Nullable<IntPtr>.Equals
	|
	|-RVA: 0x14BC730 Offset: 0x14BB930 VA: 0x1814BC730
	|-Nullable<InventoryItemSetValueAsDoubleOptions>.Equals
	|
	|-RVA: 0x14CB4C0 Offset: 0x14CA6C0 VA: 0x1814CB4C0
	|-Nullable<LocalDefinition>.Equals
	|
	|-RVA: 0x14CB3B0 Offset: 0x14CA5B0 VA: 0x1814CB3B0
	|-Nullable<LogEventParamPair>.Equals
	|-Nullable<LogEventParamPairParamValue>.Equals
	|
	|-RVA: 0x14CB530 Offset: 0x14CA730 VA: 0x1814CB530
	|-Nullable<LogPlayerTakeDamageOptions>.Equals
	|
	|-RVA: 0x14DB5E0 Offset: 0x14DA7E0 VA: 0x1814DB5E0
	|-Nullable<Options>.Equals
	|
	|-RVA: 0x14DB820 Offset: 0x14DAA20 VA: 0x1814DB820
	|-Nullable<PS4InitializeOptions>.Equals
	|
	|-RVA: 0x14DB6F0 Offset: 0x14DA8F0 VA: 0x1814DB6F0
	|-Nullable<PS5InitializeOptions>.Equals
	|
	|-RVA: 0x14DB950 Offset: 0x14DAB50 VA: 0x1814DB950
	|-Nullable<PageResult>.Equals
	|-Nullable<Token>.Equals
	|-Nullable<Vec3f>.Equals
	|-Nullable<Vec3fInternal>.Equals
	|
	|-RVA: 0x14EC8B0 Offset: 0x14EBAB0 VA: 0x1814EC8B0
	|-Nullable<Quat>.Equals
	|-Nullable<QuatInternal>.Equals
	|-Nullable<Rect>.Equals
	|
	|-RVA: 0x14EC800 Offset: 0x14EBA00 VA: 0x1814EC800
	|-Nullable<RectInternal>.Equals
	|
	|-RVA: 0x14FBCA0 Offset: 0x14FAEA0 VA: 0x1814FBCA0
	|-Nullable<ReportInputStateOptions>.Equals
	|
	|-RVA: 0x14FBD60 Offset: 0x14FAF60 VA: 0x1814FBD60
	|-Nullable<sbyte>.Equals
	|
	|-RVA: 0x14FBB70 Offset: 0x14FAD70 VA: 0x1814FBB70
	|-Nullable<SentryId>.Equals
	|
	|-RVA: 0x14FBC30 Offset: 0x14FAE30 VA: 0x1814FBC30
	|-Nullable<SequencePoint>.Equals
	|
	|-RVA: 0x14FBDD0 Offset: 0x14FAFD0 VA: 0x1814FBDD0
	|-Nullable<SetPortRangeOptions>.Equals
	|
	|-RVA: 0x150B250 Offset: 0x150A450 VA: 0x18150B250
	|-Nullable<float>.Equals
	|
	|-RVA: 0x150B460 Offset: 0x150A660 VA: 0x18150B460
	|-Nullable<SpanId>.Equals
	|
	|-RVA: 0x150B6E0 Offset: 0x150A8E0 VA: 0x18150B6E0
	|-Nullable<SqlBinary>.Equals
	|
	|-RVA: 0x150B880 Offset: 0x150AA80 VA: 0x18150B880
	|-Nullable<StreamingContext>.Equals
	|
	|-RVA: 0x150B190 Offset: 0x150A390 VA: 0x18150B190
	|-Nullable<TimeSpan>.Equals
	|
	|-RVA: 0x150B600 Offset: 0x150A800 VA: 0x18150B600
	|-Nullable<Touch>.Equals
	|
	|-RVA: 0x150B520 Offset: 0x150A720 VA: 0x18150B520
	|-Nullable<ushort>.Equals
	|
	|-RVA: 0x150B3F0 Offset: 0x150A5F0 VA: 0x18150B3F0
	|-Nullable<uint>.Equals
	|
	|-RVA: 0x150B590 Offset: 0x150A790 VA: 0x18150B590
	|-Nullable<ulong>.Equals
	|
	|-RVA: 0x150B2C0 Offset: 0x150A4C0 VA: 0x18150B2C0
	|-Nullable<UIntPtr>.Equals
	|
	|-RVA: 0x150B330 Offset: 0x150A530 VA: 0x18150B330
	|-Nullable<Vector2>.Equals
	|
	|-RVA: 0x150B7A0 Offset: 0x150A9A0 VA: 0x18150B7A0
	|-Nullable<Vector3>.Equals
	|
	|-RVA: 0xB4A9B0 Offset: 0xB49BB0 VA: 0x180B4A9B0
	|-Nullable<WindowsOptions>.Equals
	|-Nullable<XSXOptions>.Equals
	|-Nullable<XboxOneGDKOptions>.Equals
	|
	|-RVA: 0xB4AD20 Offset: 0xB49F20 VA: 0x180B4AD20
	|-Nullable<XSXInitializeOptions>.Equals
	|-Nullable<XboxOneGDKInitializeOptions>.Equals
	|
	|-RVA: 0xB4AB70 Offset: 0xB49D70 VA: 0x180B4AB70
	|-Nullable<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x148E430 Offset: 0x148D630 VA: 0x18148E430
	|-Nullable<ArraySegment<byte>>.GetHashCode
	|
	|-RVA: 0x148E3E0 Offset: 0x148D5E0 VA: 0x18148E3E0
	|-Nullable<ValueTuple<object, object>>.GetHashCode
	|
	|-RVA: 0xB4AF00 Offset: 0xB4A100 VA: 0x180B4AF00
	|-Nullable<AcceptConnectionOptions>.GetHashCode
	|-Nullable<AttributeDataValue>.GetHashCode
	|-Nullable<AttributeDataValue>.GetHashCode
	|-Nullable<AudioBeforeRenderCallbackInfo>.GetHashCode
	|-Nullable<BeginPlayerSessionOptions>.GetHashCode
	|-Nullable<ClearPacketQueueOptions>.GetHashCode
	|-Nullable<CloseConnectionOptions>.GetHashCode
	|-Nullable<ExternalAccountInfo>.GetHashCode
	|-Nullable<FileMetadata>.GetHashCode
	|-Nullable<LobbyDetailsInfo>.GetHashCode
	|-Nullable<LogPlayerUseWeaponData>.GetHashCode
	|-Nullable<PS4IntegratedPlatformOptionsContainerAddOptions>.GetHashCode
	|-Nullable<PS4PrePresentOptions>.GetHashCode
	|-Nullable<PS5PrePresentOptions>.GetHashCode
	|-Nullable<ParticipantStatusChangedCallbackInfo>.GetHashCode
	|-Nullable<QueryLeaderboardDefinitionsOptions>.GetHashCode
	|-Nullable<QueryPermissionsCallbackInfo>.GetHashCode
	|-Nullable<SessionDetailsInfoInternal>.GetHashCode
	|-Nullable<SessionDetailsSettingsInternal>.GetHashCode
	|-Nullable<UninstallModOptions>.GetHashCode
	|-Nullable<UpdateModOptions>.GetHashCode
	|-Nullable<UserInfoDataInternal>.GetHashCode
	|-Nullable<XSXInitializeOptionsSystemInitializeOptions>.GetHashCode
	|-Nullable<XSXPrePresentOptionsPlatformSpecificData>.GetHashCode
	|-Nullable<XboxOneGDKInitializeOptionsSystemInitializeOptions>.GetHashCode
	|-Nullable<XboxOneGDKPrePresentOptionsPlatformSpecificData>.GetHashCode
	|
	|-RVA: 0xB4B4A0 Offset: 0xB4A6A0 VA: 0x180B4B4A0
	|-Nullable<AcceptInviteCallbackInfo>.GetHashCode
	|-Nullable<AcceptRequestToJoinCallbackInfo>.GetHashCode
	|-Nullable<AttributeDataInternal>.GetHashCode
	|-Nullable<AttributeDataInternal>.GetHashCode
	|-Nullable<AudioBufferInternal>.GetHashCode
	|-Nullable<AudioInputStateCallbackInfo>.GetHashCode
	|-Nullable<AudioOutputStateCallbackInfo>.GetHashCode
	|-Nullable<BeginSessionOptions>.GetHashCode
	|-Nullable<BlockParticipantOptions>.GetHashCode
	|-Nullable<CheckoutCallbackInfo>.GetHashCode
	|-Nullable<DisconnectedCallbackInfo>.GetHashCode
	|-Nullable<EnumerateModsCallbackInfo>.GetHashCode
	|-Nullable<ExternalUserInfo>.GetHashCode
	|-Nullable<ExternalUserInfoInternal>.GetHashCode
	|-Nullable<FileMetadata>.GetHashCode
	|-Nullable<FileMetadataInternal>.GetHashCode
	|-Nullable<FileTransferProgressCallbackInfo>.GetHashCode
	|-Nullable<FileTransferProgressCallbackInfo>.GetHashCode
	|-Nullable<FinalizeInviteOptions>.GetHashCode
	|-Nullable<HardMuteMemberCallbackInfo>.GetHashCode
	|-Nullable<HardMuteMemberOptions>.GetHashCode
	|-Nullable<IOSCredentialsSystemAuthCredentialsOptionsInternal>.GetHashCode
	|-Nullable<IngestStatCompleteCallbackInfo>.GetHashCode
	|-Nullable<IntegratedPlatformOptionsContainerAddOptions>.GetHashCode
	|-Nullable<JoinSessionOptions>.GetHashCode
	|-Nullable<KeyImageInfoInternal>.GetHashCode
	|-Nullable<LeaderboardRecordInternal>.GetHashCode
	|-Nullable<LeaveRoomCallbackInfo>.GetHashCode
	|-Nullable<LobbyInviteReceivedCallbackInfo>.GetHashCode
	|-Nullable<LobbyMemberStatusReceivedCallbackInfo>.GetHashCode
	|-Nullable<LogGameRoundStartOptions>.GetHashCode
	|-Nullable<LoginCallbackInfo>.GetHashCode
	|-Nullable<OnBlockedUsersUpdateInfo>.GetHashCode
	|-Nullable<OnClientActionRequiredCallbackInfo>.GetHashCode
	|-Nullable<OnFriendsUpdateInfo>.GetHashCode
	|-Nullable<OnMessageToClientCallbackInfo>.GetHashCode
	|-Nullable<OnQueryPlayerAchievementsCompleteCallbackInfo>.GetHashCode
	|-Nullable<OnQueryStatsCompleteCallbackInfo>.GetHashCode
	|-Nullable<OnShowBlockPlayerCallbackInfo>.GetHashCode
	|-Nullable<OnShowReportPlayerCallbackInfo>.GetHashCode
	|-Nullable<OnUnlockAchievementsCompleteCallbackInfo>.GetHashCode
	|-Nullable<PS4DLCVerifyPurchaseOptionsPlatformSpecificOptions>.GetHashCode
	|-Nullable<PS4IAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetHashCode
	|-Nullable<PS4MemoryMonitorCallbackInfo>.GetHashCode
	|-Nullable<PS4OptionsInitOptionsInternal>.GetHashCode
	|-Nullable<PS5DLCVerifyPurchaseOptionsPlatformSpecificOptions>.GetHashCode
	|-Nullable<PS5IAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetHashCode
	|-Nullable<PS5MemoryMonitorCallbackInfo>.GetHashCode
	|-Nullable<PS5SubmitGraphicsCommandsCallbackInfo>.GetHashCode
	|-Nullable<PinGrantInfo>.GetHashCode
	|-Nullable<PlayerSanction>.GetHashCode
	|-Nullable<ProtectMessageOptions>.GetHashCode
	|-Nullable<QueryActivePlayerSanctionsCallbackInfo>.GetHashCode
	|-Nullable<QueryAgeGateCallbackInfo>.GetHashCode
	|-Nullable<QueryEntitlementTokenCallbackInfo>.GetHashCode
	|-Nullable<QueryFileListCallbackInfo>.GetHashCode
	|-Nullable<QueryFileListCallbackInfo>.GetHashCode
	|-Nullable<QueryIdTokenCallbackInfo>.GetHashCode
	|-Nullable<QueryJoinRoomTokenOptions>.GetHashCode
	|-Nullable<QueryOwnershipBySandboxIdsCallbackInfo>.GetHashCode
	|-Nullable<QueryOwnershipCallbackInfo>.GetHashCode
	|-Nullable<QueryOwnershipTokenCallbackInfo>.GetHashCode
	|-Nullable<QueryPresenceCallbackInfo>.GetHashCode
	|-Nullable<QueryUserInfoCallbackInfo>.GetHashCode
	|-Nullable<RTCRoomConnectionChangedCallbackInfo>.GetHashCode
	|-Nullable<ReadFileCallbackInfo>.GetHashCode
	|-Nullable<ReadFileCallbackInfo>.GetHashCode
	|-Nullable<RedeemEntitlementsCallbackInfo>.GetHashCode
	|-Nullable<RegisterEventOptions>.GetHashCode
	|-Nullable<RegisterPlayersCallbackInfo>.GetHashCode
	|-Nullable<RejectInviteCallbackInfo>.GetHashCode
	|-Nullable<RejectRequestToJoinCallbackInfo>.GetHashCode
	|-Nullable<RequestToJoinResponseReceivedCallbackInfo>.GetHashCode
	|-Nullable<RoomStatisticsUpdatedInfo>.GetHashCode
	|-Nullable<SendCustomInviteCallbackInfo>.GetHashCode
	|-Nullable<SendDataOptions>.GetHashCode
	|-Nullable<SendInviteCallbackInfo>.GetHashCode
	|-Nullable<SendRequestToJoinCallbackInfo>.GetHashCode
	|-Nullable<SessionDetailsSettings>.GetHashCode
	|-Nullable<SessionInviteReceivedCallbackInfo>.GetHashCode
	|-Nullable<SetRoomSettingOptions>.GetHashCode
	|-Nullable<ShowNativeProfileCallbackInfo>.GetHashCode
	|-Nullable<SocketId>.GetHashCode
	|-Nullable<SteamOptions>.GetHashCode
	|-Nullable<UnlockedAchievement>.GetHashCode
	|-Nullable<UnprotectMessageOptions>.GetHashCode
	|-Nullable<UpdateParticipantVolumeOptions>.GetHashCode
	|-Nullable<UpdateReceivingOptions>.GetHashCode
	|-Nullable<UpdateReceivingOptions>.GetHashCode
	|-Nullable<UpdateSessionCallbackInfo>.GetHashCode
	|-Nullable<VerifyPurchaseOptions>.GetHashCode
	|-Nullable<WriteFileCallbackInfo>.GetHashCode
	|-Nullable<WriteFileDataCallbackInfo>.GetHashCode
	|
	|-RVA: 0xB4AF90 Offset: 0xB4A190 VA: 0x180B4AF90
	|-Nullable<AcceptInviteOptions>.GetHashCode
	|-Nullable<AcceptRequestToJoinOptions>.GetHashCode
	|-Nullable<AccountFeatureRestrictedInfoInternal>.GetHashCode
	|-Nullable<AcknowledgeEventIdOptions>.GetHashCode
	|-Nullable<AddNotifyAudioBeforeSendOptions>.GetHashCode
	|-Nullable<AddNotifyAudioInputStateOptions>.GetHashCode
	|-Nullable<AddNotifyAudioOutputStateOptions>.GetHashCode
	|-Nullable<AddNotifyDataReceivedOptions>.GetHashCode
	|-Nullable<AddNotifyDisconnectedOptions>.GetHashCode
	|-Nullable<AddNotifyParticipantStatusChangedOptions>.GetHashCode
	|-Nullable<AddNotifyParticipantUpdatedOptions>.GetHashCode
	|-Nullable<AddNotifyParticipantUpdatedOptions>.GetHashCode
	|-Nullable<AddNotifyRTCRoomConnectionChangedOptions>.GetHashCode
	|-Nullable<AddNotifyRoomStatisticsUpdatedOptions>.GetHashCode
	|-Nullable<AndroidIAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetHashCode
	|-Nullable<AudioBuffer>.GetHashCode
	|-Nullable<AuthExpirationCallbackInfo>.GetHashCode
	|-Nullable<BeginSessionOptions>.GetHashCode
	|-Nullable<ClientCredentials>.GetHashCode
	|-Nullable<CopyBestDisplayNameOptions>.GetHashCode
	|-Nullable<CopyEntitlementByIdOptions>.GetHashCode
	|-Nullable<CopyEntitlementByIndexOptions>.GetHashCode
	|-Nullable<CopyFileMetadataAtIndexOptions>.GetHashCode
	|-Nullable<CopyFileMetadataAtIndexOptions>.GetHashCode
	|-Nullable<CopyFileMetadataByFilenameOptions>.GetHashCode
	|-Nullable<CopyFileMetadataByFilenameOptions>.GetHashCode
	|-Nullable<CopyItemByIdOptions>.GetHashCode
	|-Nullable<CopyLastRedeemedEntitlementByIndexOptions>.GetHashCode
	|-Nullable<CopyLeaderboardUserScoreByIndexOptions>.GetHashCode
	|-Nullable<CopyLeaderboardUserScoreByUserIdOptions>.GetHashCode
	|-Nullable<CopyLobbyDetailsHandleOptions>.GetHashCode
	|-Nullable<CopyModInfoOptions>.GetHashCode
	|-Nullable<CopyOfferByIdOptions>.GetHashCode
	|-Nullable<CopyOfferByIndexOptions>.GetHashCode
	|-Nullable<CopyPermissionByIndexOptions>.GetHashCode
	|-Nullable<CopyPlayerSanctionByIndexOptions>.GetHashCode
	|-Nullable<CopyPresenceOptions>.GetHashCode
	|-Nullable<CopyProductUserExternalAccountByAccountIdOptions>.GetHashCode
	|-Nullable<CopyProductUserExternalAccountByAccountTypeOptions>.GetHashCode
	|-Nullable<CopyProductUserExternalAccountByIndexOptions>.GetHashCode
	|-Nullable<CopyStatByIndexOptions>.GetHashCode
	|-Nullable<CopyStatByNameOptions>.GetHashCode
	|-Nullable<CopyTransactionByIdOptions>.GetHashCode
	|-Nullable<CopyTransactionByIndexOptions>.GetHashCode
	|-Nullable<CopyUnlockedAchievementByAchievementIdOptions>.GetHashCode
	|-Nullable<CopyUnlockedAchievementByIndexOptions>.GetHashCode
	|-Nullable<CopyUserInfoOptions>.GetHashCode
	|-Nullable<CopyUserTokenByUserIdOptions>.GetHashCode
	|-Nullable<CreateDeviceIdCallbackInfo>.GetHashCode
	|-Nullable<Credentials>.GetHashCode
	|-Nullable<DataRecord>.GetHashCode
	|-Nullable<DeleteDeviceIdCallbackInfo>.GetHashCode
	|-Nullable<DeleteFileOptions>.GetHashCode
	|-Nullable<DeletePersistentAuthCallbackInfo>.GetHashCode
	|-Nullable<DestroyLobbyOptions>.GetHashCode
	|-Nullable<DestroySessionCallbackInfo>.GetHashCode
	|-Nullable<EGSDLCVerifyPurchaseOptionsPlatformSpecificOptions>.GetHashCode
	|-Nullable<EGSIAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetHashCode
	|-Nullable<EndSessionCallbackInfo>.GetHashCode
	|-Nullable<EnumerateModsOptions>.GetHashCode
	|-Nullable<GetBlockedUserAtIndexOptions>.GetHashCode
	|-Nullable<GetConnectStringOptions>.GetHashCode
	|-Nullable<GetEntitlementsByNameCountOptions>.GetHashCode
	|-Nullable<GetExternalUserInfoCountOptions>.GetHashCode
	|-Nullable<GetFriendAtIndexOptions>.GetHashCode
	|-Nullable<GetInviteIdByIndexOptions>.GetHashCode
	|-Nullable<GetInviteIdByIndexOptions>.GetHashCode
	|-Nullable<GetItemImageInfoCountOptions>.GetHashCode
	|-Nullable<GetItemReleaseCountOptions>.GetHashCode
	|-Nullable<GetJoinInfoOptions>.GetHashCode
	|-Nullable<GetNextReceivedPacketSizeOptions>.GetHashCode
	|-Nullable<GetOfferImageInfoCountOptions>.GetHashCode
	|-Nullable<GetOfferItemCountOptions>.GetHashCode
	|-Nullable<GetPermissionByKeyOptions>.GetHashCode
	|-Nullable<GetRTCRoomNameOptions>.GetHashCode
	|-Nullable<GetStatusOptions>.GetHashCode
	|-Nullable<HasPresenceOptions>.GetHashCode
	|-Nullable<IOSIAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetHashCode
	|-Nullable<IdToken>.GetHashCode
	|-Nullable<IdToken>.GetHashCode
	|-Nullable<IngestData>.GetHashCode
	|-Nullable<IsRTCRoomConnectedOptions>.GetHashCode
	|-Nullable<IsUserInSessionOptions>.GetHashCode
	|-Nullable<ItemOwnership>.GetHashCode
	|-Nullable<JoinSessionCallbackInfo>.GetHashCode
	|-Nullable<JsonElement>.GetHashCode
	|-Nullable<KickCompleteCallbackInfo>.GetHashCode
	|-Nullable<KickOptions>.GetHashCode
	|-Nullable<LeaderboardUserScore>.GetHashCode
	|-Nullable<LeaveLobbyOptions>.GetHashCode
	|-Nullable<LeaveRoomOptions>.GetHashCode
	|-Nullable<LinkAccountOptions>.GetHashCode
	|-Nullable<LobbyDetailsCopyMemberAttributeByIndexOptions>.GetHashCode
	|-Nullable<LobbyDetailsCopyMemberAttributeByKeyOptions>.GetHashCode
	|-Nullable<LobbyDetailsMemberInfo>.GetHashCode
	|-Nullable<LobbySearchFindCallbackInfo>.GetHashCode
	|-Nullable<LobbySearchRemoveParameterOptions>.GetHashCode
	|-Nullable<LobbyUpdateReceivedCallbackInfo>.GetHashCode
	|-Nullable<LogPlayerReviveOptions>.GetHashCode
	|-Nullable<LogPlayerSpawnOptions>.GetHashCode
	|-Nullable<MemoryMonitorCallbackInfo>.GetHashCode
	|-Nullable<ModInfo>.GetHashCode
	|-Nullable<OnCheckpointCompleteCallbackInfo>.GetHashCode
	|-Nullable<OnCloseCompleteCallbackInfo>.GetHashCode
	|-Nullable<OnDisplaySettingsUpdatedCallbackInfo>.GetHashCode
	|-Nullable<OnQueryDefinitionsCompleteCallbackInfo>.GetHashCode
	|-Nullable<OnQueryInputDevicesInformationCallbackInfo>.GetHashCode
	|-Nullable<OnQueryLeaderboardDefinitionsCompleteCallbackInfo>.GetHashCode
	|-Nullable<OnQueryLeaderboardUserScoresCompleteCallbackInfo>.GetHashCode
	|-Nullable<OnQueryOutputDevicesInformationCallbackInfo>.GetHashCode
	|-Nullable<Option>.GetHashCode
	|-Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReport>.GetHashCode
	|-Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReport>.GetHashCode
	|-Nullable<PS5Options>.GetHashCode
	|-Nullable<ParticipantMetadata>.GetHashCode
	|-Nullable<PermissionStatus>.GetHashCode
	|-Nullable<PlayerStatInfo>.GetHashCode
	|-Nullable<QueryActivePlayerSanctionsOptions>.GetHashCode
	|-Nullable<QueryEntitlementTokenOptions>.GetHashCode
	|-Nullable<QueryFileListOptions>.GetHashCode
	|-Nullable<QueryFileOptions>.GetHashCode
	|-Nullable<QueryFileOptions>.GetHashCode
	|-Nullable<QueryIdTokenOptions>.GetHashCode
	|-Nullable<QueryLeaderboardRanksOptions>.GetHashCode
	|-Nullable<QueryOffersOptions>.GetHashCode
	|-Nullable<QueryOwnershipBySandboxIdsOptions>.GetHashCode
	|-Nullable<QueryPlayerAchievementsOptions>.GetHashCode
	|-Nullable<QueryPresenceOptions>.GetHashCode
	|-Nullable<QueryUserInfoByDisplayNameOptions>.GetHashCode
	|-Nullable<QueryUserInfoOptions>.GetHashCode
	|-Nullable<RTCOptions>.GetHashCode
	|-Nullable<ReceiveMessageFromServerOptions>.GetHashCode
	|-Nullable<RedeemEntitlementsOptions>.GetHashCode
	|-Nullable<RegexPrefix>.GetHashCode
	|-Nullable<RegisterEventParamDef>.GetHashCode
	|-Nullable<RegisterPlayersOptions>.GetHashCode
	|-Nullable<RejectInviteCallbackInfo>.GetHashCode
	|-Nullable<RejectInviteOptions>.GetHashCode
	|-Nullable<RejectInviteOptions>.GetHashCode
	|-Nullable<RejectInviteOptions>.GetHashCode
	|-Nullable<RejectRequestToJoinOptions>.GetHashCode
	|-Nullable<RequestPermissionsOptions>.GetHashCode
	|-Nullable<SandboxIdItemOwnership>.GetHashCode
	|-Nullable<SendCustomInviteOptions>.GetHashCode
	|-Nullable<SendInviteCallbackInfo>.GetHashCode
	|-Nullable<SendInviteOptions>.GetHashCode
	|-Nullable<SendPlayerBehaviorReportCompleteCallbackInfo>.GetHashCode
	|-Nullable<SendRequestToJoinOptions>.GetHashCode
	|-Nullable<SessionSearchFindCallbackInfo>.GetHashCode
	|-Nullable<SessionSearchRemoveParameterOptions>.GetHashCode
	|-Nullable<SetClientDetailsOptions>.GetHashCode
	|-Nullable<SetClientNetworkStateOptions>.GetHashCode
	|-Nullable<SetCustomInviteOptions>.GetHashCode
	|-Nullable<SetOutputDeviceSettingsOptions>.GetHashCode
	|-Nullable<SetPacketQueueSizeOptions>.GetHashCode
	|-Nullable<SetParticipantHardMuteCompleteCallbackInfo>.GetHashCode
	|-Nullable<SetPresenceOptions>.GetHashCode
	|-Nullable<SetSettingOptions>.GetHashCode
	|-Nullable<ShowBlockPlayerOptions>.GetHashCode
	|-Nullable<ShowNativeProfileOptions>.GetHashCode
	|-Nullable<ShowReportPlayerOptions>.GetHashCode
	|-Nullable<SocketIdInternal>.GetHashCode
	|-Nullable<StartSessionCallbackInfo>.GetHashCode
	|-Nullable<StatThresholds>.GetHashCode
	|-Nullable<SteamDLCVerifyPurchaseOptionsPlatformSpecificOptions>.GetHashCode
	|-Nullable<SubmitSnapshotCallbackInfo>.GetHashCode
	|-Nullable<UnlockAchievementsOptions>.GetHashCode
	|-Nullable<UnregisterPlayersOptions>.GetHashCode
	|-Nullable<UpdateLobbyModificationOptions>.GetHashCode
	|-Nullable<UpdateParentEmailOptions>.GetHashCode
	|-Nullable<UserLoginInfo>.GetHashCode
	|-Nullable<UserScoresQueryStatInfo>.GetHashCode
	|-Nullable<UserToken>.GetHashCode
	|-Nullable<VerifyPurchaseCompleteCallbackInfo>.GetHashCode
	|-Nullable<VerifyUserAuthCallbackInfo>.GetHashCode
	|-Nullable<WindowsRTCOptionsPlatformSpecificOptionsInternal>.GetHashCode
	|-Nullable<XSXDLCVerifyPurchaseOptionsPlatformSpecificOptions>.GetHashCode
	|-Nullable<XSXIAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetHashCode
	|-Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.GetHashCode
	|-Nullable<XSXSubmitGraphicsCommandsDataCommand>.GetHashCode
	|-Nullable<XSXXBLOptionsInitOptions>.GetHashCode
	|-Nullable<XboxOneGDKDLCVerifyPurchaseOptionsPlatformSpecificOptions>.GetHashCode
	|-Nullable<XboxOneGDKIAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetHashCode
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.GetHashCode
	|-Nullable<XboxOneGDKSubmitGraphicsCommandsDataCommand>.GetHashCode
	|-Nullable<XboxOneGDKXBLOptionsInitOptions>.GetHashCode
	|
	|-RVA: 0xB4B090 Offset: 0xB4A290 VA: 0x180B4B090
	|-Nullable<AccountFeatureRestrictedInfo>.GetHashCode
	|-Nullable<AddExternalIntegrityCatalogOptions>.GetHashCode
	|-Nullable<AudioDevicesChangedCallbackInfo>.GetHashCode
	|-Nullable<BeginSnapshotOptions>.GetHashCode
	|-Nullable<CheckoutEntry>.GetHashCode
	|-Nullable<CopyAchievementDefinitionByAchievementIdOptions>.GetHashCode
	|-Nullable<CopyAchievementDefinitionV2ByAchievementIdOptions>.GetHashCode
	|-Nullable<CopyActiveSessionHandleOptions>.GetHashCode
	|-Nullable<CopyIdTokenOptions>.GetHashCode
	|-Nullable<CopyIdTokenOptions>.GetHashCode
	|-Nullable<CopyLeaderboardDefinitionByLeaderboardIdOptions>.GetHashCode
	|-Nullable<CopyLeaderboardRecordByUserIdOptions>.GetHashCode
	|-Nullable<CopyLobbyDetailsHandleByInviteIdOptions>.GetHashCode
	|-Nullable<CopyLobbyDetailsHandleByUiEventIdOptions>.GetHashCode
	|-Nullable<CopyProductUserInfoOptions>.GetHashCode
	|-Nullable<CopySessionHandleByInviteIdOptions>.GetHashCode
	|-Nullable<CopySessionHandleByUiEventIdOptions>.GetHashCode
	|-Nullable<CopySessionHandleForPresenceOptions>.GetHashCode
	|-Nullable<CreateDeviceIdOptions>.GetHashCode
	|-Nullable<CreatePresenceModificationOptions>.GetHashCode
	|-Nullable<CreateUserOptions>.GetHashCode
	|-Nullable<DeleteCacheOptions>.GetHashCode
	|-Nullable<DeleteCacheOptions>.GetHashCode
	|-Nullable<DeletePersistentAuthOptions>.GetHashCode
	|-Nullable<DeleteSnapshotOptions>.GetHashCode
	|-Nullable<DestroySessionOptions>.GetHashCode
	|-Nullable<DumpSessionStateOptions>.GetHashCode
	|-Nullable<EndSessionOptions>.GetHashCode
	|-Nullable<GetBlockedUsersCountOptions>.GetHashCode
	|-Nullable<GetEntitlementsCountOptions>.GetHashCode
	|-Nullable<GetFileMetadataCountOptions>.GetHashCode
	|-Nullable<GetFileMetadataCountOptions>.GetHashCode
	|-Nullable<GetFriendsCountOptions>.GetHashCode
	|-Nullable<GetFriendsExclusiveInputOptions>.GetHashCode
	|-Nullable<GetFriendsVisibleOptions>.GetHashCode
	|-Nullable<GetInviteCountOptions>.GetHashCode
	|-Nullable<GetInviteCountOptions>.GetHashCode
	|-Nullable<GetLastRedeemedEntitlementsCountOptions>.GetHashCode
	|-Nullable<GetLeaderboardUserScoreCountOptions>.GetHashCode
	|-Nullable<GetOfferCountOptions>.GetHashCode
	|-Nullable<GetPermissionsCountOptions>.GetHashCode
	|-Nullable<GetPlayerAchievementCountOptions>.GetHashCode
	|-Nullable<GetPlayerSanctionCountOptions>.GetHashCode
	|-Nullable<GetProductUserExternalAccountCountOptions>.GetHashCode
	|-Nullable<GetStatCountOptions>.GetHashCode
	|-Nullable<GetTransactionCountOptions>.GetHashCode
	|-Nullable<GetUnlockedAchievementCountOptions>.GetHashCode
	|-Nullable<HideFriendsOptions>.GetHashCode
	|-Nullable<InventoryItemCreateSubItemOptions>.GetHashCode
	|-Nullable<InventoryItemDeleteSubItemOptions>.GetHashCode
	|-Nullable<InventoryItemGetSubItemOptions>.GetHashCode
	|-Nullable<InventoryItemSetKeyOptions>.GetHashCode
	|-Nullable<InventoryItemSetValueAsDoubleSetOptions>.GetHashCode
	|-Nullable<InventoryItemSetValueAsInt64Options>.GetHashCode
	|-Nullable<InventoryItemSetValueAsInt64SetOptions>.GetHashCode
	|-Nullable<InventoryItemSetValueAsStringOptions>.GetHashCode
	|-Nullable<InventoryItemSetValueAsStringSetOptions>.GetHashCode
	|-Nullable<InventoryItemSetValueAsTimestampOptions>.GetHashCode
	|-Nullable<LobbyDetailsCopyAttributeByKeyOptions>.GetHashCode
	|-Nullable<LobbyDetailsCopyMemberInfoOptions>.GetHashCode
	|-Nullable<LobbyDetailsGetMemberAttributeCountOptions>.GetHashCode
	|-Nullable<LobbyModificationRemoveAttributeOptions>.GetHashCode
	|-Nullable<LobbyModificationRemoveMemberAttributeOptions>.GetHashCode
	|-Nullable<LobbyModificationSetAllowedPlatformIdsOptions>.GetHashCode
	|-Nullable<LobbyModificationSetBucketIdOptions>.GetHashCode
	|-Nullable<LobbySearchFindOptions>.GetHashCode
	|-Nullable<LobbySearchSetLobbyIdOptions>.GetHashCode
	|-Nullable<LobbySearchSetTargetUserIdOptions>.GetHashCode
	|-Nullable<LogPlayerDespawnOptions>.GetHashCode
	|-Nullable<LogoutOptions>.GetHashCode
	|-Nullable<LogoutOptions>.GetHashCode
	|-Nullable<ParseConnectStringOptions>.GetHashCode
	|-Nullable<PrePresentOptions>.GetHashCode
	|-Nullable<PresenceModificationDataRecordId>.GetHashCode
	|-Nullable<PresenceModificationDeleteDataOptions>.GetHashCode
	|-Nullable<PresenceModificationSetDataOptions>.GetHashCode
	|-Nullable<PresenceModificationSetJoinInfoOptions>.GetHashCode
	|-Nullable<PresenceModificationSetRawRichTextOptions>.GetHashCode
	|-Nullable<QueryFileListOptions>.GetHashCode
	|-Nullable<QueryFriendsOptions>.GetHashCode
	|-Nullable<QueryInvitesOptions>.GetHashCode
	|-Nullable<QueryInvitesOptions>.GetHashCode
	|-Nullable<QueryPermissionsOptions>.GetHashCode
	|-Nullable<RegisterPlatformAudioUserOptions>.GetHashCode
	|-Nullable<RegisterPlatformUserOptions>.GetHashCode
	|-Nullable<SessionDetailsCopySessionAttributeByKeyOptions>.GetHashCode
	|-Nullable<SessionModificationRemoveAttributeOptions>.GetHashCode
	|-Nullable<SessionModificationSetAllowedPlatformIdsOptions>.GetHashCode
	|-Nullable<SessionModificationSetBucketIdOptions>.GetHashCode
	|-Nullable<SessionModificationSetHostAddressOptions>.GetHashCode
	|-Nullable<SessionSearchFindOptions>.GetHashCode
	|-Nullable<SessionSearchSetSessionIdOptions>.GetHashCode
	|-Nullable<SessionSearchSetTargetUserIdOptions>.GetHashCode
	|-Nullable<SetGameSessionIdOptions>.GetHashCode
	|-Nullable<ShowFriendsOptions>.GetHashCode
	|-Nullable<StartSessionOptions>.GetHashCode
	|-Nullable<SteamIAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetHashCode
	|-Nullable<SwitchIAPVerifyPurchaseOptionsPlatformSpecificOptions>.GetHashCode
	|-Nullable<UnlinkAccountOptions>.GetHashCode
	|-Nullable<UnregisterClientOptions>.GetHashCode
	|-Nullable<UnregisterPeerOptions>.GetHashCode
	|-Nullable<UnregisterPlatformAudioUserOptions>.GetHashCode
	|-Nullable<UnregisterPlatformUserOptions>.GetHashCode
	|-Nullable<UpdateLobbyOptions>.GetHashCode
	|-Nullable<UpdateSessionModificationOptions>.GetHashCode
	|-Nullable<UpdateSessionOptions>.GetHashCode
	|-Nullable<WindowsRTCOptionsPlatformSpecificOptions>.GetHashCode
	|-Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReport>.GetHashCode
	|-Nullable<XSXOptionsSystemSpecificOptions>.GetHashCode
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReport>.GetHashCode
	|-Nullable<XboxOneGDKOptionsSystemSpecificOptions>.GetHashCode
	|-Nullable<C.sentry_value_t>.GetHashCode
	|
	|-RVA: 0x148E210 Offset: 0x148D410 VA: 0x18148E210
	|-Nullable<ActiveSessionCopyInfoOptions>.GetHashCode
	|-Nullable<ActiveSessionGetRegisteredPlayerCountOptions>.GetHashCode
	|-Nullable<AddNotifyAchievementsUnlockedOptions>.GetHashCode
	|-Nullable<AddNotifyAchievementsUnlockedV2Options>.GetHashCode
	|-Nullable<AddNotifyAudioDevicesChangedOptions>.GetHashCode
	|-Nullable<AddNotifyAuthExpirationOptions>.GetHashCode
	|-Nullable<AddNotifyBlockedUsersUpdateOptions>.GetHashCode
	|-Nullable<AddNotifyClientActionRequiredOptions>.GetHashCode
	|-Nullable<AddNotifyClientAuthStatusChangedOptions>.GetHashCode
	|-Nullable<AddNotifyClientIntegrityViolatedOptions>.GetHashCode
	|-Nullable<AddNotifyCustomInviteAcceptedOptions>.GetHashCode
	|-Nullable<AddNotifyCustomInviteReceivedOptions>.GetHashCode
	|-Nullable<AddNotifyCustomInviteRejectedOptions>.GetHashCode
	|-Nullable<AddNotifyDisplaySettingsUpdatedOptions>.GetHashCode
	|-Nullable<AddNotifyFriendsUpdateOptions>.GetHashCode
	|-Nullable<AddNotifyIncomingPacketQueueFullOptions>.GetHashCode
	|-Nullable<AddNotifyJoinGameAcceptedOptions>.GetHashCode
	|-Nullable<AddNotifyJoinLobbyAcceptedOptions>.GetHashCode
	|-Nullable<AddNotifyJoinSessionAcceptedOptions>.GetHashCode
	|-Nullable<AddNotifyLeaveLobbyRequestedOptions>.GetHashCode
	|-Nullable<AddNotifyLeaveSessionRequestedOptions>.GetHashCode
	|-Nullable<AddNotifyLobbyInviteAcceptedOptions>.GetHashCode
	|-Nullable<AddNotifyLobbyInviteReceivedOptions>.GetHashCode
	|-Nullable<AddNotifyLobbyInviteRejectedOptions>.GetHashCode
	|-Nullable<AddNotifyLobbyMemberStatusReceivedOptions>.GetHashCode
	|-Nullable<AddNotifyLobbyMemberUpdateReceivedOptions>.GetHashCode
	|-Nullable<AddNotifyLobbyUpdateReceivedOptions>.GetHashCode
	|-Nullable<AddNotifyLoginStatusChangedOptions>.GetHashCode
	|-Nullable<AddNotifyLoginStatusChangedOptions>.GetHashCode
	|-Nullable<AddNotifyMemoryMonitorOptions>.GetHashCode
	|-Nullable<AddNotifyMessageToClientOptions>.GetHashCode
	|-Nullable<AddNotifyMessageToPeerOptions>.GetHashCode
	|-Nullable<AddNotifyMessageToServerOptions>.GetHashCode
	|-Nullable<AddNotifyOnPresenceChangedOptions>.GetHashCode
	|-Nullable<AddNotifyPeerActionRequiredOptions>.GetHashCode
	|-Nullable<AddNotifyPeerAuthStatusChangedOptions>.GetHashCode
	|-Nullable<AddNotifyPermissionsUpdateReceivedOptions>.GetHashCode
	|-Nullable<AddNotifyRequestToJoinAcceptedOptions>.GetHashCode
	|-Nullable<AddNotifyRequestToJoinReceivedOptions>.GetHashCode
	|-Nullable<AddNotifyRequestToJoinRejectedOptions>.GetHashCode
	|-Nullable<AddNotifyRequestToJoinResponseReceivedOptions>.GetHashCode
	|-Nullable<AddNotifySendCustomNativeInviteRequestedOptions>.GetHashCode
	|-Nullable<AddNotifySendLobbyNativeInviteRequestedOptions>.GetHashCode
	|-Nullable<AddNotifySendSessionNativeInviteRequestedOptions>.GetHashCode
	|-Nullable<AddNotifySessionInviteAcceptedOptions>.GetHashCode
	|-Nullable<AddNotifySessionInviteReceivedOptions>.GetHashCode
	|-Nullable<AddNotifySessionInviteRejectedOptions>.GetHashCode
	|-Nullable<AddNotifyUserLoginStatusChangedOptions>.GetHashCode
	|-Nullable<ClearUserPreLogoutCallbackOptions>.GetHashCode
	|-Nullable<CopyUserAuthTokenOptions>.GetHashCode
	|-Nullable<CreateIntegratedPlatformOptionsContainerOptions>.GetHashCode
	|-Nullable<DeleteDeviceIdOptions>.GetHashCode
	|-Nullable<EndSessionOptions>.GetHashCode
	|-Nullable<EndSessionOptions>.GetHashCode
	|-Nullable<GetAchievementDefinitionCountOptions>.GetHashCode
	|-Nullable<GetAudioInputDevicesCountOptions>.GetHashCode
	|-Nullable<GetAudioOutputDevicesCountOptions>.GetHashCode
	|-Nullable<GetDesktopCrossplayStatusOptions>.GetHashCode
	|-Nullable<GetInputDevicesCountOptions>.GetHashCode
	|-Nullable<GetLeaderboardDefinitionCountOptions>.GetHashCode
	|-Nullable<GetLeaderboardRecordCountOptions>.GetHashCode
	|-Nullable<GetLocalPlatformTypeOptions>.GetHashCode
	|-Nullable<GetNATTypeOptions>.GetHashCode
	|-Nullable<GetOutputDevicesCountOptions>.GetHashCode
	|-Nullable<GetPacketQueueInfoOptions>.GetHashCode
	|-Nullable<GetPortRangeOptions>.GetHashCode
	|-Nullable<GetRelayControlOptions>.GetHashCode
	|-Nullable<GetToggleFriendsButtonOptions>.GetHashCode
	|-Nullable<GetToggleFriendsKeyOptions>.GetHashCode
	|-Nullable<InventoryItemGetKeyOptions>.GetHashCode
	|-Nullable<InventoryItemGetSubItemsCountOptions>.GetHashCode
	|-Nullable<InventoryItemGetValueAsBoolOptions>.GetHashCode
	|-Nullable<InventoryItemGetValueAsDoubleOptions>.GetHashCode
	|-Nullable<InventoryItemGetValueAsInt64Options>.GetHashCode
	|-Nullable<InventoryItemGetValueAsStringOptions>.GetHashCode
	|-Nullable<InventoryItemGetValueAsTimestampOptions>.GetHashCode
	|-Nullable<InventoryItemGetValueCountOptions>.GetHashCode
	|-Nullable<InventoryItemGetValueTypeOptions>.GetHashCode
	|-Nullable<InventoryItemSetValueAsBoolOptions>.GetHashCode
	|-Nullable<IsSocialOverlayPausedOptions>.GetHashCode
	|-Nullable<LobbyDetailsCopyInfoOptions>.GetHashCode
	|-Nullable<LobbyDetailsGetAttributeCountOptions>.GetHashCode
	|-Nullable<LobbyDetailsGetLobbyOwnerOptions>.GetHashCode
	|-Nullable<LobbyDetailsGetMemberCountOptions>.GetHashCode
	|-Nullable<LobbyModificationSetInvitesAllowedOptions>.GetHashCode
	|-Nullable<LobbySearchGetSearchResultCountOptions>.GetHashCode
	|-Nullable<PS5OptionsInitOptions>.GetHashCode
	|-Nullable<PauseSocialOverlayOptions>.GetHashCode
	|-Nullable<QueryAgeGateOptions>.GetHashCode
	|-Nullable<QueryInputDevicesInformationOptions>.GetHashCode
	|-Nullable<QueryNATTypeOptions>.GetHashCode
	|-Nullable<QueryOutputDevicesInformationOptions>.GetHashCode
	|-Nullable<SessionDetailsCopyInfoOptions>.GetHashCode
	|-Nullable<SessionDetailsGetSessionAttributeCountOptions>.GetHashCode
	|-Nullable<SessionModificationSetInvitesAllowedOptions>.GetHashCode
	|-Nullable<SessionModificationSetJoinInProgressAllowedOptions>.GetHashCode
	|-Nullable<SessionSearchGetSearchResultCountOptions>.GetHashCode
	|-Nullable<SetUserPreLogoutCallbackOptions>.GetHashCode
	|-Nullable<TransactionGetEntitlementsCountOptions>.GetHashCode
	|
	|-RVA: 0xB4B220 Offset: 0xB4A420 VA: 0x180B4B220
	|-Nullable<ActiveSessionGetRegisteredPlayerByIndexOptions>.GetHashCode
	|-Nullable<CopyAchievementDefinitionByIndexOptions>.GetHashCode
	|-Nullable<CopyAchievementDefinitionV2ByIndexOptions>.GetHashCode
	|-Nullable<CopyInputDeviceInformationByIndexOptions>.GetHashCode
	|-Nullable<CopyLeaderboardDefinitionByIndexOptions>.GetHashCode
	|-Nullable<CopyLeaderboardRecordByIndexOptions>.GetHashCode
	|-Nullable<CopyOutputDeviceInformationByIndexOptions>.GetHashCode
	|-Nullable<CreateLobbySearchOptions>.GetHashCode
	|-Nullable<CreateSessionSearchOptions>.GetHashCode
	|-Nullable<EndSnapshotOptions>.GetHashCode
	|-Nullable<GetAudioInputDeviceByIndexOptions>.GetHashCode
	|-Nullable<GetAudioOutputDeviceByIndexOptions>.GetHashCode
	|-Nullable<GetProtectMessageOutputLengthOptions>.GetHashCode
	|-Nullable<GetProtectMessageOutputLengthOptions>.GetHashCode
	|-Nullable<InventoryItemGetDoubleSetValueByIndexOptions>.GetHashCode
	|-Nullable<InventoryItemGetInt64SetValueByIndexOptions>.GetHashCode
	|-Nullable<InventoryItemGetStringSetValueByIndexOptions>.GetHashCode
	|-Nullable<InventoryItemGetSubItemByIndexOptions>.GetHashCode
	|-Nullable<LobbyDetailsCopyAttributeByIndexOptions>.GetHashCode
	|-Nullable<LobbyDetailsGetMemberByIndexOptions>.GetHashCode
	|-Nullable<LobbyModificationSetMaxMembersOptions>.GetHashCode
	|-Nullable<LobbyModificationSetPermissionLevelOptions>.GetHashCode
	|-Nullable<LobbySearchCopySearchResultByIndexOptions>.GetHashCode
	|-Nullable<LobbySearchSetMaxResultsOptions>.GetHashCode
	|-Nullable<LogGameRoundEndOptions>.GetHashCode
	|-Nullable<PollStatusOptions>.GetHashCode
	|-Nullable<PresenceModificationSetStatusOptions>.GetHashCode
	|-Nullable<SessionDetailsCopySessionAttributeByIndexOptions>.GetHashCode
	|-Nullable<SessionModificationSetMaxPlayersOptions>.GetHashCode
	|-Nullable<SessionModificationSetPermissionLevelOptions>.GetHashCode
	|-Nullable<SessionSearchCopySearchResultByIndexOptions>.GetHashCode
	|-Nullable<SessionSearchSetMaxResultsOptions>.GetHashCode
	|-Nullable<SetDisplayPreferenceOptions>.GetHashCode
	|-Nullable<SetRelayControlOptions>.GetHashCode
	|-Nullable<SetToggleFriendsButtonOptions>.GetHashCode
	|-Nullable<SetToggleFriendsKeyOptions>.GetHashCode
	|-Nullable<SubmitSnapshotOptions>.GetHashCode
	|-Nullable<TransactionCopyEntitlementByIndexOptions>.GetHashCode
	|-Nullable<XSXPrePresentAdditionalData>.GetHashCode
	|-Nullable<XboxOneGDKPrePresentAdditionalData>.GetHashCode
	|
	|-RVA: 0x148E280 Offset: 0x148D480 VA: 0x18148E280
	|-Nullable<ActiveSessionInfo>.GetHashCode
	|
	|-RVA: 0xB4B100 Offset: 0xB4A300 VA: 0x180B4B100
	|-Nullable<ActiveSessionInfoInternal>.GetHashCode
	|-Nullable<BestDisplayName>.GetHashCode
	|-Nullable<CatalogReleaseInternal>.GetHashCode
	|-Nullable<CreateUserCallbackInfo>.GetHashCode
	|-Nullable<Credentials>.GetHashCode
	|-Nullable<CustomInviteRejectedCallbackInfo>.GetHashCode
	|-Nullable<Entitlement>.GetHashCode
	|-Nullable<FileMetadataInternal>.GetHashCode
	|-Nullable<JoinGameAcceptedCallbackInfo>.GetHashCode
	|-Nullable<JoinLobbyByIdOptions>.GetHashCode
	|-Nullable<JoinLobbyOptions>.GetHashCode
	|-Nullable<JoinRoomCallbackInfo>.GetHashCode
	|-Nullable<LobbyInviteAcceptedCallbackInfo>.GetHashCode
	|-Nullable<LobbyInviteRejectedCallbackInfo>.GetHashCode
	|-Nullable<ModIdentifier>.GetHashCode
	|-Nullable<OnCustomInviteAcceptedCallbackInfo>.GetHashCode
	|-Nullable<OnCustomInviteReceivedCallbackInfo>.GetHashCode
	|-Nullable<OnIncomingPacketQueueFullInfo>.GetHashCode
	|-Nullable<PS4SubmitGraphicsCommandsCallbackInfo>.GetHashCode
	|-Nullable<ParticipantUpdatedCallbackInfo>.GetHashCode
	|-Nullable<ParticipantUpdatedCallbackInfo>.GetHashCode
	|-Nullable<PinGrantInfoInternal>.GetHashCode
	|-Nullable<PlayerSanctionInternal>.GetHashCode
	|-Nullable<QueryJoinRoomTokenCompleteCallbackInfo>.GetHashCode
	|-Nullable<QueryUserInfoByDisplayNameCallbackInfo>.GetHashCode
	|-Nullable<ReadFileOptions>.GetHashCode
	|-Nullable<ReadFileOptions>.GetHashCode
	|-Nullable<RegisterClientOptions>.GetHashCode
	|-Nullable<SendAudioOptions>.GetHashCode
	|-Nullable<SendPlayerBehaviorReportOptions>.GetHashCode
	|-Nullable<SessionInviteAcceptedCallbackInfo>.GetHashCode
	|-Nullable<SessionInviteRejectedCallbackInfo>.GetHashCode
	|-Nullable<StatInternal>.GetHashCode
	|-Nullable<SteamIAPVerifyPurchaseOptions>.GetHashCode
	|-Nullable<SwitchIAPVerifyPurchaseOptions>.GetHashCode
	|-Nullable<UpdateReceivingVolumeCallbackInfo>.GetHashCode
	|-Nullable<UpdateSendingCallbackInfo>.GetHashCode
	|-Nullable<UpdateSendingCallbackInfo>.GetHashCode
	|-Nullable<UpdateSendingVolumeCallbackInfo>.GetHashCode
	|-Nullable<UserPreLogoutCallbackInfo>.GetHashCode
	|-Nullable<WriteFileOptions>.GetHashCode
	|-Nullable<XSXXBLOptions>.GetHashCode
	|-Nullable<XboxOneGDKXBLOptions>.GetHashCode
	|
	|-RVA: 0xB4B290 Offset: 0xB4A490 VA: 0x180B4B290
	|-Nullable<AddNotifyAudioBeforeRenderOptions>.GetHashCode
	|-Nullable<AddProgressionOptions>.GetHashCode
	|-Nullable<AndroidInitializeOptionsSystemInitializeOptions>.GetHashCode
	|-Nullable<AttributeInternal>.GetHashCode
	|-Nullable<AudioInputDeviceInfo>.GetHashCode
	|-Nullable<AudioInputDeviceInfoInternal>.GetHashCode
	|-Nullable<AudioOutputDeviceInfo>.GetHashCode
	|-Nullable<AudioOutputDeviceInfoInternal>.GetHashCode
	|-Nullable<BeginPlayerSessionOptionsAccountId>.GetHashCode
	|-Nullable<CatalogRelease>.GetHashCode
	|-Nullable<CheckoutOptions>.GetHashCode
	|-Nullable<CheckpointOptions>.GetHashCode
	|-Nullable<CloseOptions>.GetHashCode
	|-Nullable<CopyBestDisplayNameWithPlatformOptions>.GetHashCode
	|-Nullable<CopyEntitlementByNameAndIndexOptions>.GetHashCode
	|-Nullable<CopyExternalUserInfoByAccountIdOptions>.GetHashCode
	|-Nullable<CopyExternalUserInfoByAccountTypeOptions>.GetHashCode
	|-Nullable<CopyExternalUserInfoByIndexOptions>.GetHashCode
	|-Nullable<CopyItemImageInfoByIndexOptions>.GetHashCode
	|-Nullable<CopyItemReleaseByIndexOptions>.GetHashCode
	|-Nullable<CopyOfferImageInfoByIndexOptions>.GetHashCode
	|-Nullable<CopyOfferItemByIndexOptions>.GetHashCode
	|-Nullable<CopyPlayerAchievementByAchievementIdOptions>.GetHashCode
	|-Nullable<CopyPlayerAchievementByIndexOptions>.GetHashCode
	|-Nullable<CreateLobbyCallbackInfo>.GetHashCode
	|-Nullable<CreateOptions>.GetHashCode
	|-Nullable<CreatePlayerSanctionAppealCallbackInfo>.GetHashCode
	|-Nullable<CreatePlayerSanctionAppealOptions>.GetHashCode
	|-Nullable<CreateUserCallbackInfo>.GetHashCode
	|-Nullable<CreateUserOptions>.GetHashCode
	|-Nullable<DeleteCacheCallbackInfo>.GetHashCode
	|-Nullable<DeleteCacheCallbackInfo>.GetHashCode
	|-Nullable<DeleteFileCallbackInfo>.GetHashCode
	|-Nullable<DeleteSnapshotCallbackInfo>.GetHashCode
	|-Nullable<DestroyLobbyCallbackInfo>.GetHashCode
	|-Nullable<DuplicateFileCallbackInfo>.GetHashCode
	|-Nullable<DuplicateFileOptions>.GetHashCode
	|-Nullable<EndPlayerSessionOptions>.GetHashCode
	|-Nullable<EndPlayerSessionOptionsAccountId>.GetHashCode
	|-Nullable<FinalizeDeferredUserLogoutOptions>.GetHashCode
	|-Nullable<GetExternalAccountMappingsOptions>.GetHashCode
	|-Nullable<GetProductUserIdMappingOptions>.GetHashCode
	|-Nullable<HideFriendsCallbackInfo>.GetHashCode
	|-Nullable<IOSCredentialsSystemAuthCredentialsOptions>.GetHashCode
	|-Nullable<IdTokenInternal>.GetHashCode
	|-Nullable<IdTokenInternal>.GetHashCode
	|-Nullable<IngestStatOptions>.GetHashCode
	|-Nullable<InputDeviceInformation>.GetHashCode
	|-Nullable<InputDeviceInformationInternal>.GetHashCode
	|-Nullable<JoinLobbyAcceptedCallbackInfo>.GetHashCode
	|-Nullable<JoinLobbyByIdCallbackInfo>.GetHashCode
	|-Nullable<JoinLobbyCallbackInfo>.GetHashCode
	|-Nullable<JoinSessionAcceptedCallbackInfo>.GetHashCode
	|-Nullable<JsonPosition>.GetHashCode
	|-Nullable<KeyImageInfo>.GetHashCode
	|-Nullable<KickMemberCallbackInfo>.GetHashCode
	|-Nullable<KickMemberOptions>.GetHashCode
	|-Nullable<LeaderboardRecord>.GetHashCode
	|-Nullable<LeaderboardUserScoreInternal>.GetHashCode
	|-Nullable<LeaveLobbyCallbackInfo>.GetHashCode
	|-Nullable<LeaveLobbyRequestedCallbackInfo>.GetHashCode
	|-Nullable<LeaveSessionRequestedCallbackInfo>.GetHashCode
	|-Nullable<LinkAccountCallbackInfo>.GetHashCode
	|-Nullable<LinkAccountOptions>.GetHashCode
	|-Nullable<LobbyDetailsMemberInfoInternal>.GetHashCode
	|-Nullable<LobbyMemberUpdateReceivedCallbackInfo>.GetHashCode
	|-Nullable<LogEventOptions>.GetHashCode
	|-Nullable<LogMessage>.GetHashCode
	|-Nullable<LogPlayerUseAbilityOptions>.GetHashCode
	|-Nullable<LoginStatusChangedCallbackInfo>.GetHashCode
	|-Nullable<LoginStatusChangedCallbackInfo>.GetHashCode
	|-Nullable<LogoutCallbackInfo>.GetHashCode
	|-Nullable<LogoutCallbackInfo>.GetHashCode
	|-Nullable<ModInfoInternal>.GetHashCode
	|-Nullable<OnAchievementsUnlockedCallbackInfo>.GetHashCode
	|-Nullable<OnClientAuthStatusChangedCallbackInfo>.GetHashCode
	|-Nullable<OnClientIntegrityViolatedCallbackInfo>.GetHashCode
	|-Nullable<OnCreateCompleteCallbackInfo>.GetHashCode
	|-Nullable<OnMessageToServerCallbackInfo>.GetHashCode
	|-Nullable<OnOpenCompleteCallbackInfo>.GetHashCode
	|-Nullable<OnQueryLeaderboardRanksCompleteCallbackInfo>.GetHashCode
	|-Nullable<OnQueryNATTypeCompleteInfo>.GetHashCode
	|-Nullable<OnRegisterPlatformUserCallbackInfo>.GetHashCode
	|-Nullable<OnRequestToJoinAcceptedCallbackInfo>.GetHashCode
	|-Nullable<OnRequestToJoinRejectedCallbackInfo>.GetHashCode
	|-Nullable<OnSetInputDeviceSettingsCallbackInfo>.GetHashCode
	|-Nullable<OnSetOutputDeviceSettingsCallbackInfo>.GetHashCode
	|-Nullable<OnUnregisterPlatformUserCallbackInfo>.GetHashCode
	|-Nullable<OpenOptions>.GetHashCode
	|-Nullable<Options>.GetHashCode
	|-Nullable<OutputDeviceInformation>.GetHashCode
	|-Nullable<OutputDeviceInformationInternal>.GetHashCode
	|-Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.GetHashCode
	|-Nullable<PS4OptionsInitOptions>.GetHashCode
	|-Nullable<PS5IntegratedPlatformOptionsContainerAddOptions>.GetHashCode
	|-Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.GetHashCode
	|-Nullable<PermissionStatusInternal>.GetHashCode
	|-Nullable<PresenceChangedCallbackInfo>.GetHashCode
	|-Nullable<PromoteMemberCallbackInfo>.GetHashCode
	|-Nullable<PromoteMemberOptions>.GetHashCode
	|-Nullable<ProtectMessageOptions>.GetHashCode
	|-Nullable<QueryDefinitionsOptions>.GetHashCode
	|-Nullable<QueryEntitlementsCallbackInfo>.GetHashCode
	|-Nullable<QueryEntitlementsOptions>.GetHashCode
	|-Nullable<QueryExternalAccountMappingsCallbackInfo>.GetHashCode
	|-Nullable<QueryExternalAccountMappingsOptions>.GetHashCode
	|-Nullable<QueryFileCallbackInfo>.GetHashCode
	|-Nullable<QueryFileCallbackInfo>.GetHashCode
	|-Nullable<QueryFriendsCallbackInfo>.GetHashCode
	|-Nullable<QueryInvitesCallbackInfo>.GetHashCode
	|-Nullable<QueryInvitesCallbackInfo>.GetHashCode
	|-Nullable<QueryOffersCallbackInfo>.GetHashCode
	|-Nullable<QueryOwnershipOptions>.GetHashCode
	|-Nullable<QueryOwnershipTokenOptions>.GetHashCode
	|-Nullable<QueryProductUserIdMappingsCallbackInfo>.GetHashCode
	|-Nullable<QueryProductUserIdMappingsOptions>.GetHashCode
	|-Nullable<QueryUserInfoByExternalAccountOptions>.GetHashCode
	|-Nullable<ReceiveMessageFromClientOptions>.GetHashCode
	|-Nullable<ReceiveMessageFromPeerOptions>.GetHashCode
	|-Nullable<RejectInviteCallbackInfo>.GetHashCode
	|-Nullable<RequestPermissionsCallbackInfo>.GetHashCode
	|-Nullable<RequestToJoinReceivedCallbackInfo>.GetHashCode
	|-Nullable<SendInviteCallbackInfo>.GetHashCode
	|-Nullable<SendInviteOptions>.GetHashCode
	|-Nullable<SendInviteOptions>.GetHashCode
	|-Nullable<SessionDetailsAttributeInternal>.GetHashCode
	|-Nullable<SetAudioInputSettingsOptions>.GetHashCode
	|-Nullable<SetAudioOutputSettingsOptions>.GetHashCode
	|-Nullable<SetInputDeviceSettingsOptions>.GetHashCode
	|-Nullable<SetParticipantHardMuteOptions>.GetHashCode
	|-Nullable<SetPresenceCallbackInfo>.GetHashCode
	|-Nullable<SetUserLoginStatusOptions>.GetHashCode
	|-Nullable<ShowFriendsCallbackInfo>.GetHashCode
	|-Nullable<TransferDeviceIdAccountCallbackInfo>.GetHashCode
	|-Nullable<TransferDeviceIdAccountOptions>.GetHashCode
	|-Nullable<UnlinkAccountCallbackInfo>.GetHashCode
	|-Nullable<UnlockedAchievementInternal>.GetHashCode
	|-Nullable<UnprotectMessageOptions>.GetHashCode
	|-Nullable<UnregisterPlayersCallbackInfo>.GetHashCode
	|-Nullable<UpdateLobbyCallbackInfo>.GetHashCode
	|-Nullable<UpdateParentEmailCallbackInfo>.GetHashCode
	|-Nullable<UpdateReceivingVolumeOptions>.GetHashCode
	|-Nullable<UpdateSendingOptions>.GetHashCode
	|-Nullable<UpdateSendingOptions>.GetHashCode
	|-Nullable<UpdateSendingVolumeOptions>.GetHashCode
	|-Nullable<UserTokenInternal>.GetHashCode
	|-Nullable<VerifyIdTokenOptions>.GetHashCode
	|-Nullable<VerifyIdTokenOptions>.GetHashCode
	|-Nullable<WindowsRTCOptions>.GetHashCode
	|-Nullable<XSXMemoryMonitorCallbackInfo>.GetHashCode
	|-Nullable<XSXSubmitGraphicsCommandsCallbackInfo>.GetHashCode
	|-Nullable<XSXXBLOptionsInitOptionsInternal>.GetHashCode
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfo>.GetHashCode
	|-Nullable<XboxOneGDKSubmitGraphicsCommandsCallbackInfo>.GetHashCode
	|-Nullable<XboxOneGDKXBLOptionsInitOptionsInternal>.GetHashCode
	|
	|-RVA: 0xB4B190 Offset: 0xB4A390 VA: 0x180B4B190
	|-Nullable<AddNotifyPeerConnectionClosedOptions>.GetHashCode
	|-Nullable<AddNotifyPeerConnectionEstablishedOptions>.GetHashCode
	|-Nullable<AddNotifyPeerConnectionInterruptedOptions>.GetHashCode
	|-Nullable<AddNotifyPeerConnectionRequestOptions>.GetHashCode
	|-Nullable<AndroidIAPVerifyPurchaseOptions>.GetHashCode
	|-Nullable<AudioBeforeSendCallbackInfo>.GetHashCode
	|-Nullable<BestDisplayNameInternal>.GetHashCode
	|-Nullable<BlockParticipantCallbackInfo>.GetHashCode
	|-Nullable<CloseConnectionsOptions>.GetHashCode
	|-Nullable<DataReceivedCallbackInfo>.GetHashCode
	|-Nullable<DefinitionInternal>.GetHashCode
	|-Nullable<EGSDLCVerifyPurchaseOptions>.GetHashCode
	|-Nullable<EGSIAPVerifyPurchaseOptions>.GetHashCode
	|-Nullable<EntitlementInternal>.GetHashCode
	|-Nullable<ExternalAccountInfoInternal>.GetHashCode
	|-Nullable<IOSIAPVerifyPurchaseOptions>.GetHashCode
	|-Nullable<JoinRoomOptions>.GetHashCode
	|-Nullable<LoginOptions>.GetHashCode
	|-Nullable<ModIdentifierInternal>.GetHashCode
	|-Nullable<OnAchievementsUnlockedCallbackV2Info>.GetHashCode
	|-Nullable<PS4Options>.GetHashCode
	|-Nullable<PS4PrePresentOptionsPlatformSpecificData>.GetHashCode
	|-Nullable<PS5PrePresentOptionsPlatformSpecificData>.GetHashCode
	|-Nullable<PacketQueueInfo>.GetHashCode
	|-Nullable<PermissionsUpdateReceivedCallbackInfo>.GetHashCode
	|-Nullable<QueryUserInfoByExternalAccountCallbackInfo>.GetHashCode
	|-Nullable<ReadFileDataCallbackInfo>.GetHashCode
	|-Nullable<ReadFileDataCallbackInfo>.GetHashCode
	|-Nullable<RegisterPeerOptions>.GetHashCode
	|-Nullable<SendCustomNativeInviteRequestedCallbackInfo>.GetHashCode
	|-Nullable<SendLobbyNativeInviteRequestedCallbackInfo>.GetHashCode
	|-Nullable<SendSessionNativeInviteRequestedCallbackInfo>.GetHashCode
	|-Nullable<SteamDLCVerifyPurchaseOptions>.GetHashCode
	|-Nullable<UpdateParticipantVolumeCallbackInfo>.GetHashCode
	|-Nullable<UpdateReceivingCallbackInfo>.GetHashCode
	|-Nullable<UpdateReceivingCallbackInfo>.GetHashCode
	|-Nullable<UserInfoData>.GetHashCode
	|-Nullable<UserLoginStatusChangedCallbackInfo>.GetHashCode
	|-Nullable<XSXDLCVerifyPurchaseOptions>.GetHashCode
	|-Nullable<XSXIAPVerifyPurchaseOptions>.GetHashCode
	|-Nullable<XSXIntegratedPlatformOptionsContainerAddOptions>.GetHashCode
	|-Nullable<XboxOneGDKDLCVerifyPurchaseOptions>.GetHashCode
	|-Nullable<XboxOneGDKIAPVerifyPurchaseOptions>.GetHashCode
	|-Nullable<XboxOneGDKIntegratedPlatformOptionsContainerAddOptions>.GetHashCode
	|
	|-RVA: 0x148E4C0 Offset: 0x148D6C0 VA: 0x18148E4C0
	|-Nullable<AndroidInitializeOptions>.GetHashCode
	|
	|-RVA: 0xB4B000 Offset: 0xB4A200 VA: 0x180B4B000
	|-Nullable<Announcement>.GetHashCode
	|-Nullable<AttributeData>.GetHashCode
	|-Nullable<AttributeData>.GetHashCode
	|-Nullable<CreateSessionModificationOptions>.GetHashCode
	|-Nullable<IOSCredentials>.GetHashCode
	|-Nullable<InitializeThreadAffinity>.GetHashCode
	|-Nullable<InstallModOptions>.GetHashCode
	|-Nullable<LogPlayerUseWeaponOptions>.GetHashCode
	|-Nullable<LoginOptions>.GetHashCode
	|-Nullable<OnIncomingConnectionRequestInfo>.GetHashCode
	|-Nullable<OnPeerConnectionInterruptedInfo>.GetHashCode
	|-Nullable<PS4DLCVerifyPurchaseOptions>.GetHashCode
	|-Nullable<PS4IAPVerifyPurchaseOptions>.GetHashCode
	|-Nullable<PS5DLCVerifyPurchaseOptions>.GetHashCode
	|-Nullable<PS5IAPVerifyPurchaseOptions>.GetHashCode
	|-Nullable<Stat>.GetHashCode
	|-Nullable<XSXPrePresentOptions>.GetHashCode
	|-Nullable<XboxOneGDKPrePresentOptions>.GetHashCode
	|
	|-RVA: 0x148E340 Offset: 0x148D540 VA: 0x18148E340
	|-Nullable<Attribute>.GetHashCode
	|-Nullable<CatalogItem>.GetHashCode
	|-Nullable<CreateLobbyOptions>.GetHashCode
	|-Nullable<DefinitionV2>.GetHashCode
	|-Nullable<InfoInternal>.GetHashCode
	|-Nullable<LobbyModificationAddAttributeOptions>.GetHashCode
	|-Nullable<LobbyModificationAddMemberAttributeOptions>.GetHashCode
	|-Nullable<LobbySearchSetParameterOptions>.GetHashCode
	|-Nullable<PS4InitializeOptionsSystemInitializeOptions>.GetHashCode
	|-Nullable<PlayerAchievement>.GetHashCode
	|-Nullable<PlayerAchievementInternal>.GetHashCode
	|-Nullable<SessionDetailsAttribute>.GetHashCode
	|-Nullable<SessionDetailsInfo>.GetHashCode
	|-Nullable<SessionModificationAddAttributeOptions>.GetHashCode
	|-Nullable<SessionSearchSetParameterOptions>.GetHashCode
	|-Nullable<Token>.GetHashCode
	|
	|-RVA: 0x149CB80 Offset: 0x149BD80 VA: 0x18149CB80
	|-Nullable<BigInteger>.GetHashCode
	|
	|-RVA: 0x149CAF0 Offset: 0x149BCF0 VA: 0x18149CAF0
	|-Nullable<bool>.GetHashCode
	|
	|-RVA: 0x149CAA0 Offset: 0x149BCA0 VA: 0x18149CAA0
	|-Nullable<byte>.GetHashCode
	|
	|-RVA: 0x149CC10 Offset: 0x149BE10 VA: 0x18149CC10
	|-Nullable<CatalogItemInternal>.GetHashCode
	|-Nullable<Definition>.GetHashCode
	|-Nullable<DefinitionV2Internal>.GetHashCode
	|-Nullable<IOSLoginOptions>.GetHashCode
	|-Nullable<LobbyDetailsInfoInternal>.GetHashCode
	|-Nullable<TokenInternal>.GetHashCode
	|-Nullable<VerifyIdTokenCallbackInfo>.GetHashCode
	|-Nullable<VerifyUserAuthOptions>.GetHashCode
	|
	|-RVA: 0x149CCC0 Offset: 0x149BEC0 VA: 0x18149CCC0
	|-Nullable<CatalogOffer>.GetHashCode
	|-Nullable<CatalogOfferInternal>.GetHashCode
	|
	|-RVA: 0x149CDA0 Offset: 0x149BFA0 VA: 0x18149CDA0
	|-Nullable<char>.GetHashCode
	|
	|-RVA: 0x149CE30 Offset: 0x149C030 VA: 0x18149CE30
	|-Nullable<Color>.GetHashCode
	|
	|-RVA: 0xB4B710 Offset: 0xB4A910 VA: 0x180B4B710
	|-Nullable<CopyUserTokenByIndexOptions>.GetHashCode
	|-Nullable<DesktopCrossplayStatusInfo>.GetHashCode
	|-Nullable<LocalRTCOptions>.GetHashCode
	|-Nullable<PS5OptionsInitOptionsInternal>.GetHashCode
	|-Nullable<PageQuery>.GetHashCode
	|-Nullable<XSXPrePresentAdditionalDataInternal>.GetHashCode
	|-Nullable<XboxOneGDKPrePresentAdditionalDataInternal>.GetHashCode
	|
	|-RVA: 0x14ACF40 Offset: 0x14AC140 VA: 0x1814ACF40
	|-Nullable<DataKey>.GetHashCode
	|
	|-RVA: 0x14ACEB0 Offset: 0x14AC0B0 VA: 0x1814ACEB0
	|-Nullable<DateTime>.GetHashCode
	|
	|-RVA: 0x14ACC70 Offset: 0x14ABE70 VA: 0x1814ACC70
	|-Nullable<DateTimeOffset>.GetHashCode
	|
	|-RVA: 0x14ACF90 Offset: 0x14AC190 VA: 0x1814ACF90
	|-Nullable<Decimal>.GetHashCode
	|
	|-RVA: 0x14ACE00 Offset: 0x14AC000 VA: 0x1814ACE00
	|-Nullable<Definition>.GetHashCode
	|-Nullable<Info>.GetHashCode
	|-Nullable<InstallModCallbackInfo>.GetHashCode
	|-Nullable<LinkAccountCallbackInfo>.GetHashCode
	|-Nullable<LogPlayerTickOptions>.GetHashCode
	|-Nullable<OnPeerConnectionEstablishedInfo>.GetHashCode
	|-Nullable<OnRemoteConnectionClosedInfo>.GetHashCode
	|-Nullable<PS5InitializeOptionsSystemInitializeOptions>.GetHashCode
	|-Nullable<QueryLeaderboardUserScoresOptions>.GetHashCode
	|-Nullable<QueryStatsOptions>.GetHashCode
	|-Nullable<UninstallModCallbackInfo>.GetHashCode
	|-Nullable<UpdateModCallbackInfo>.GetHashCode
	|
	|-RVA: 0x14ACBC0 Offset: 0x14ABDC0 VA: 0x1814ACBC0
	|-Nullable<DefinitionInternal>.GetHashCode
	|-Nullable<LoginCallbackInfo>.GetHashCode
	|-Nullable<SendPacketOptions>.GetHashCode
	|-Nullable<VerifyIdTokenCallbackInfo>.GetHashCode
	|
	|-RVA: 0x14ACD00 Offset: 0x14ABF00 VA: 0x1814ACD00
	|-Nullable<double>.GetHashCode
	|
	|-RVA: 0x14ACD60 Offset: 0x14ABF60 VA: 0x1814ACD60
	|-Nullable<EventDispatcherGate>.GetHashCode
	|
	|-RVA: 0x14ACDB0 Offset: 0x14ABFB0 VA: 0x1814ACDB0
	|-Nullable<GCHandle>.GetHashCode
	|
	|-RVA: 0x14BC890 Offset: 0x14BBA90 VA: 0x1814BC890
	|-Nullable<Guid>.GetHashCode
	|
	|-RVA: 0x14BC9C0 Offset: 0x14BBBC0 VA: 0x1814BC9C0
	|-Nullable<InitializeOptions>.GetHashCode
	|
	|-RVA: 0x14BC970 Offset: 0x14BBB70 VA: 0x1814BC970
	|-Nullable<short>.GetHashCode
	|
	|-RVA: 0x14BC950 Offset: 0x14BBB50 VA: 0x1814BC950
	|-Nullable<Int16Enum>.GetHashCode
	|
	|-RVA: 0x14BCB10 Offset: 0x14BBD10 VA: 0x1814BCB10
	|-Nullable<int>.GetHashCode
	|-Nullable<uint>.GetHashCode
	|
	|-RVA: 0x14BC930 Offset: 0x14BBB30 VA: 0x1814BC930
	|-Nullable<Int32Enum>.GetHashCode
	|
	|-RVA: 0x14BC840 Offset: 0x14BBA40 VA: 0x1814BC840
	|-Nullable<long>.GetHashCode
	|
	|-RVA: 0x14BC8E0 Offset: 0x14BBAE0 VA: 0x1814BC8E0
	|-Nullable<IntPtr>.GetHashCode
	|-Nullable<UIntPtr>.GetHashCode
	|
	|-RVA: 0x14BCA90 Offset: 0x14BBC90 VA: 0x1814BCA90
	|-Nullable<InventoryItemSetValueAsDoubleOptions>.GetHashCode
	|
	|-RVA: 0x14CB720 Offset: 0x14CA920 VA: 0x1814CB720
	|-Nullable<LocalDefinition>.GetHashCode
	|
	|-RVA: 0x14CB650 Offset: 0x14CA850 VA: 0x1814CB650
	|-Nullable<LogEventParamPair>.GetHashCode
	|-Nullable<LogEventParamPairParamValue>.GetHashCode
	|
	|-RVA: 0x14CB770 Offset: 0x14CA970 VA: 0x1814CB770
	|-Nullable<LogPlayerTakeDamageOptions>.GetHashCode
	|
	|-RVA: 0x14DBB00 Offset: 0x14DAD00 VA: 0x1814DBB00
	|-Nullable<Options>.GetHashCode
	|
	|-RVA: 0x14DBA00 Offset: 0x14DAC00 VA: 0x1814DBA00
	|-Nullable<PS4InitializeOptions>.GetHashCode
	|
	|-RVA: 0x14DBC60 Offset: 0x14DAE60 VA: 0x1814DBC60
	|-Nullable<PS5InitializeOptions>.GetHashCode
	|
	|-RVA: 0x14DBBE0 Offset: 0x14DADE0 VA: 0x1814DBBE0
	|-Nullable<PageResult>.GetHashCode
	|-Nullable<Token>.GetHashCode
	|-Nullable<Vec3f>.GetHashCode
	|-Nullable<Vec3fInternal>.GetHashCode
	|
	|-RVA: 0x14EC9D0 Offset: 0x14EBBD0 VA: 0x1814EC9D0
	|-Nullable<Quat>.GetHashCode
	|-Nullable<QuatInternal>.GetHashCode
	|-Nullable<Rect>.GetHashCode
	|
	|-RVA: 0x14EC950 Offset: 0x14EBB50 VA: 0x1814EC950
	|-Nullable<RectInternal>.GetHashCode
	|
	|-RVA: 0x14FBEE0 Offset: 0x14FB0E0 VA: 0x1814FBEE0
	|-Nullable<ReportInputStateOptions>.GetHashCode
	|
	|-RVA: 0x14FBF70 Offset: 0x14FB170 VA: 0x1814FBF70
	|-Nullable<sbyte>.GetHashCode
	|
	|-RVA: 0x14FC010 Offset: 0x14FB210 VA: 0x1814FC010
	|-Nullable<SentryId>.GetHashCode
	|
	|-RVA: 0x14FBFC0 Offset: 0x14FB1C0 VA: 0x1814FBFC0
	|-Nullable<SequencePoint>.GetHashCode
	|
	|-RVA: 0x14FBE70 Offset: 0x14FB070 VA: 0x1814FBE70
	|-Nullable<SetPortRangeOptions>.GetHashCode
	|
	|-RVA: 0x150BC40 Offset: 0x150AE40 VA: 0x18150BC40
	|-Nullable<float>.GetHashCode
	|
	|-RVA: 0x150B8F0 Offset: 0x150AAF0 VA: 0x18150B8F0
	|-Nullable<SpanId>.GetHashCode
	|
	|-RVA: 0x150BC90 Offset: 0x150AE90 VA: 0x18150BC90
	|-Nullable<SqlBinary>.GetHashCode
	|
	|-RVA: 0x150BC00 Offset: 0x150AE00 VA: 0x18150BC00
	|-Nullable<StreamingContext>.GetHashCode
	|
	|-RVA: 0x150BA70 Offset: 0x150AC70 VA: 0x18150BA70
	|-Nullable<TimeSpan>.GetHashCode
	|
	|-RVA: 0x150BB00 Offset: 0x150AD00 VA: 0x18150BB00
	|-Nullable<Touch>.GetHashCode
	|
	|-RVA: 0x150B980 Offset: 0x150AB80 VA: 0x18150B980
	|-Nullable<ushort>.GetHashCode
	|
	|-RVA: 0x150BA50 Offset: 0x150AC50 VA: 0x18150BA50
	|-Nullable<UInt16Enum>.GetHashCode
	|
	|-RVA: 0x150BD20 Offset: 0x150AF20 VA: 0x18150BD20
	|-Nullable<ulong>.GetHashCode
	|
	|-RVA: 0x150BBA0 Offset: 0x150ADA0 VA: 0x18150BBA0
	|-Nullable<Vector2>.GetHashCode
	|
	|-RVA: 0x150B9D0 Offset: 0x150ABD0 VA: 0x18150B9D0
	|-Nullable<Vector3>.GetHashCode
	|
	|-RVA: 0xB4B520 Offset: 0xB4A720 VA: 0x180B4B520
	|-Nullable<WindowsOptions>.GetHashCode
	|-Nullable<XSXOptions>.GetHashCode
	|-Nullable<XboxOneGDKOptions>.GetHashCode
	|
	|-RVA: 0xB4B610 Offset: 0xB4A810 VA: 0x180B4B610
	|-Nullable<XSXInitializeOptions>.GetHashCode
	|-Nullable<XboxOneGDKInitializeOptions>.GetHashCode
	|
	|-RVA: 0xB4B310 Offset: 0xB4A510 VA: 0x180B4B310
	|-Nullable<__Il2CppFullySharedGenericStructType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1492260 Offset: 0x1491460 VA: 0x181492260
	|-Nullable<ArraySegment<byte>>.ToString
	|
	|-RVA: 0x14905C0 Offset: 0x148F7C0 VA: 0x1814905C0
	|-Nullable<ValueTuple<object, object>>.ToString
	|
	|-RVA: 0x148F5E0 Offset: 0x148E7E0 VA: 0x18148F5E0
	|-Nullable<AcceptConnectionOptions>.ToString
	|
	|-RVA: 0x148FA20 Offset: 0x148EC20 VA: 0x18148FA20
	|-Nullable<AcceptInviteCallbackInfo>.ToString
	|
	|-RVA: 0x14915D0 Offset: 0x14907D0 VA: 0x1814915D0
	|-Nullable<AcceptInviteOptions>.ToString
	|
	|-RVA: 0x1491030 Offset: 0x1490230 VA: 0x181491030
	|-Nullable<AcceptRequestToJoinCallbackInfo>.ToString
	|
	|-RVA: 0x148EE10 Offset: 0x148E010 VA: 0x18148EE10
	|-Nullable<AcceptRequestToJoinOptions>.ToString
	|
	|-RVA: 0x14903C0 Offset: 0x148F5C0 VA: 0x1814903C0
	|-Nullable<AccountFeatureRestrictedInfo>.ToString
	|
	|-RVA: 0x14924F0 Offset: 0x14916F0 VA: 0x1814924F0
	|-Nullable<AccountFeatureRestrictedInfoInternal>.ToString
	|
	|-RVA: 0x148F0D0 Offset: 0x148E2D0 VA: 0x18148F0D0
	|-Nullable<AcknowledgeEventIdOptions>.ToString
	|
	|-RVA: 0x14906F0 Offset: 0x148F8F0 VA: 0x1814906F0
	|-Nullable<ActiveSessionCopyInfoOptions>.ToString
	|
	|-RVA: 0x148FFA0 Offset: 0x148F1A0 VA: 0x18148FFA0
	|-Nullable<ActiveSessionGetRegisteredPlayerByIndexOptions>.ToString
	|
	|-RVA: 0x1490970 Offset: 0x148FB70 VA: 0x181490970
	|-Nullable<ActiveSessionGetRegisteredPlayerCountOptions>.ToString
	|
	|-RVA: 0x148F6B0 Offset: 0x148E8B0 VA: 0x18148F6B0
	|-Nullable<ActiveSessionInfo>.ToString
	|
	|-RVA: 0x1490040 Offset: 0x148F240 VA: 0x181490040
	|-Nullable<ActiveSessionInfoInternal>.ToString
	|
	|-RVA: 0x1490260 Offset: 0x148F460 VA: 0x181490260
	|-Nullable<AddExternalIntegrityCatalogOptions>.ToString
	|
	|-RVA: 0x148E850 Offset: 0x148DA50 VA: 0x18148E850
	|-Nullable<AddNotifyAchievementsUnlockedOptions>.ToString
	|
	|-RVA: 0x1490470 Offset: 0x148F670 VA: 0x181490470
	|-Nullable<AddNotifyAchievementsUnlockedV2Options>.ToString
	|
	|-RVA: 0x1490310 Offset: 0x148F510 VA: 0x181490310
	|-Nullable<AddNotifyAudioBeforeRenderOptions>.ToString
	|
	|-RVA: 0x1490D90 Offset: 0x148FF90 VA: 0x181490D90
	|-Nullable<AddNotifyAudioBeforeSendOptions>.ToString
	|
	|-RVA: 0x1491530 Offset: 0x1490730 VA: 0x181491530
	|-Nullable<AddNotifyAudioDevicesChangedOptions>.ToString
	|
	|-RVA: 0x1492050 Offset: 0x1491250 VA: 0x181492050
	|-Nullable<AddNotifyAudioInputStateOptions>.ToString
	|
	|-RVA: 0x1490640 Offset: 0x148F840 VA: 0x181490640
	|-Nullable<AddNotifyAudioOutputStateOptions>.ToString
	|
	|-RVA: 0x1491750 Offset: 0x1490950 VA: 0x181491750
	|-Nullable<AddNotifyAuthExpirationOptions>.ToString
	|
	|-RVA: 0x1491250 Offset: 0x1490450 VA: 0x181491250
	|-Nullable<AddNotifyBlockedUsersUpdateOptions>.ToString
	|
	|-RVA: 0x1490A10 Offset: 0x148FC10 VA: 0x181490A10
	|-Nullable<AddNotifyClientActionRequiredOptions>.ToString
	|
	|-RVA: 0x148EC20 Offset: 0x148DE20 VA: 0x18148EC20
	|-Nullable<AddNotifyClientAuthStatusChangedOptions>.ToString
	|
	|-RVA: 0x148F4A0 Offset: 0x148E6A0 VA: 0x18148F4A0
	|-Nullable<AddNotifyClientIntegrityViolatedOptions>.ToString
	|
	|-RVA: 0x148F030 Offset: 0x148E230 VA: 0x18148F030
	|-Nullable<AddNotifyCustomInviteAcceptedOptions>.ToString
	|
	|-RVA: 0x1491F10 Offset: 0x1491110 VA: 0x181491F10
	|-Nullable<AddNotifyCustomInviteReceivedOptions>.ToString
	|
	|-RVA: 0x148F7A0 Offset: 0x148E9A0 VA: 0x18148F7A0
	|-Nullable<AddNotifyCustomInviteRejectedOptions>.ToString
	|
	|-RVA: 0x1490B50 Offset: 0x148FD50 VA: 0x181490B50
	|-Nullable<AddNotifyDataReceivedOptions>.ToString
	|
	|-RVA: 0x1491890 Offset: 0x1490A90 VA: 0x181491890
	|-Nullable<AddNotifyDisconnectedOptions>.ToString
	|
	|-RVA: 0x148E990 Offset: 0x148DB90 VA: 0x18148E990
	|-Nullable<AddNotifyDisplaySettingsUpdatedOptions>.ToString
	|
	|-RVA: 0x14923B0 Offset: 0x14915B0 VA: 0x1814923B0
	|-Nullable<AddNotifyFriendsUpdateOptions>.ToString
	|
	|-RVA: 0x14919E0 Offset: 0x1490BE0 VA: 0x1814919E0
	|-Nullable<AddNotifyIncomingPacketQueueFullOptions>.ToString
	|
	|-RVA: 0x1491FB0 Offset: 0x14911B0 VA: 0x181491FB0
	|-Nullable<AddNotifyJoinGameAcceptedOptions>.ToString
	|
	|-RVA: 0x1490790 Offset: 0x148F990 VA: 0x181490790
	|-Nullable<AddNotifyJoinLobbyAcceptedOptions>.ToString
	|
	|-RVA: 0x148E8F0 Offset: 0x148DAF0 VA: 0x18148E8F0
	|-Nullable<AddNotifyJoinSessionAcceptedOptions>.ToString
	|
	|-RVA: 0x148ECC0 Offset: 0x148DEC0 VA: 0x18148ECC0
	|-Nullable<AddNotifyLeaveLobbyRequestedOptions>.ToString
	|
	|-RVA: 0x14913D0 Offset: 0x14905D0 VA: 0x1814913D0
	|-Nullable<AddNotifyLeaveSessionRequestedOptions>.ToString
	|
	|-RVA: 0x148F220 Offset: 0x148E420 VA: 0x18148F220
	|-Nullable<AddNotifyLobbyInviteAcceptedOptions>.ToString
	|
	|-RVA: 0x148EA30 Offset: 0x148DC30 VA: 0x18148EA30
	|-Nullable<AddNotifyLobbyInviteReceivedOptions>.ToString
	|
	|-RVA: 0x14908D0 Offset: 0x148FAD0 VA: 0x1814908D0
	|-Nullable<AddNotifyLobbyInviteRejectedOptions>.ToString
	|
	|-RVA: 0x148F180 Offset: 0x148E380 VA: 0x18148F180
	|-Nullable<AddNotifyLobbyMemberStatusReceivedOptions>.ToString
	|
	|-RVA: 0x1490F90 Offset: 0x1490190 VA: 0x181490F90
	|-Nullable<AddNotifyLobbyMemberUpdateReceivedOptions>.ToString
	|
	|-RVA: 0x1491BE0 Offset: 0x1490DE0 VA: 0x181491BE0
	|-Nullable<AddNotifyLobbyUpdateReceivedOptions>.ToString
	|
	|-RVA: 0x1490AB0 Offset: 0x148FCB0 VA: 0x181490AB0
	|-Nullable<AddNotifyLoginStatusChangedOptions>.ToString
	|
	|-RVA: 0x1492310 Offset: 0x1491510 VA: 0x181492310
	|-Nullable<AddNotifyLoginStatusChangedOptions>.ToString
	|
	|-RVA: 0x1490100 Offset: 0x148F300 VA: 0x181490100
	|-Nullable<AddNotifyMemoryMonitorOptions>.ToString
	|
	|-RVA: 0x148F400 Offset: 0x148E600 VA: 0x18148F400
	|-Nullable<AddNotifyMessageToClientOptions>.ToString
	|
	|-RVA: 0x148EB80 Offset: 0x148DD80 VA: 0x18148EB80
	|-Nullable<AddNotifyMessageToPeerOptions>.ToString
	|
	|-RVA: 0x148F360 Offset: 0x148E560 VA: 0x18148F360
	|-Nullable<AddNotifyMessageToServerOptions>.ToString
	|
	|-RVA: 0x148FE40 Offset: 0x148F040 VA: 0x18148FE40
	|-Nullable<AddNotifyOnPresenceChangedOptions>.ToString
	|
	|-RVA: 0x148FB80 Offset: 0x148ED80 VA: 0x18148FB80
	|-Nullable<AddNotifyParticipantStatusChangedOptions>.ToString
	|
	|-RVA: 0x148FAD0 Offset: 0x148ECD0 VA: 0x18148FAD0
	|-Nullable<AddNotifyParticipantUpdatedOptions>.ToString
	|
	|-RVA: 0x14921B0 Offset: 0x14913B0 VA: 0x1814921B0
	|-Nullable<AddNotifyParticipantUpdatedOptions>.ToString
	|
	|-RVA: 0x148F840 Offset: 0x148EA40 VA: 0x18148F840
	|-Nullable<AddNotifyPeerActionRequiredOptions>.ToString
	|
	|-RVA: 0x14911B0 Offset: 0x14903B0 VA: 0x1814911B0
	|-Nullable<AddNotifyPeerAuthStatusChangedOptions>.ToString
	|
	|-RVA: 0x148EF70 Offset: 0x148E170 VA: 0x18148EF70
	|-Nullable<AddNotifyPeerConnectionClosedOptions>.ToString
	|
	|-RVA: 0x148FEE0 Offset: 0x148F0E0 VA: 0x18148FEE0
	|-Nullable<AddNotifyPeerConnectionEstablishedOptions>.ToString
	|
	|-RVA: 0x14901A0 Offset: 0x148F3A0 VA: 0x1814901A0
	|-Nullable<AddNotifyPeerConnectionInterruptedOptions>.ToString
	|
	|-RVA: 0x1491470 Offset: 0x1490670 VA: 0x181491470
	|-Nullable<AddNotifyPeerConnectionRequestOptions>.ToString
	|
	|-RVA: 0x148F540 Offset: 0x148E740 VA: 0x18148F540
	|-Nullable<AddNotifyPermissionsUpdateReceivedOptions>.ToString
	|
	|-RVA: 0x1491A80 Offset: 0x1490C80 VA: 0x181491A80
	|-Nullable<AddNotifyRTCRoomConnectionChangedOptions>.ToString
	|
	|-RVA: 0x1491940 Offset: 0x1490B40 VA: 0x181491940
	|-Nullable<AddNotifyRequestToJoinAcceptedOptions>.ToString
	|
	|-RVA: 0x148FD00 Offset: 0x148EF00 VA: 0x18148FD00
	|-Nullable<AddNotifyRequestToJoinReceivedOptions>.ToString
	|
	|-RVA: 0x1490E40 Offset: 0x1490040 VA: 0x181490E40
	|-Nullable<AddNotifyRequestToJoinRejectedOptions>.ToString
	|
	|-RVA: 0x1492450 Offset: 0x1491650 VA: 0x181492450
	|-Nullable<AddNotifyRequestToJoinResponseReceivedOptions>.ToString
	|
	|-RVA: 0x1490510 Offset: 0x148F710 VA: 0x181490510
	|-Nullable<AddNotifyRoomStatisticsUpdatedOptions>.ToString
	|
	|-RVA: 0x148F2C0 Offset: 0x148E4C0 VA: 0x18148F2C0
	|-Nullable<AddNotifySendCustomNativeInviteRequestedOptions>.ToString
	|
	|-RVA: 0x148F980 Offset: 0x148EB80 VA: 0x18148F980
	|-Nullable<AddNotifySendLobbyNativeInviteRequestedOptions>.ToString
	|
	|-RVA: 0x1490830 Offset: 0x148FA30 VA: 0x181490830
	|-Nullable<AddNotifySendSessionNativeInviteRequestedOptions>.ToString
	|
	|-RVA: 0x14917F0 Offset: 0x14909F0 VA: 0x1814917F0
	|-Nullable<AddNotifySessionInviteAcceptedOptions>.ToString
	|
	|-RVA: 0x1491E70 Offset: 0x1491070 VA: 0x181491E70
	|-Nullable<AddNotifySessionInviteReceivedOptions>.ToString
	|
	|-RVA: 0x148FDA0 Offset: 0x148EFA0 VA: 0x18148FDA0
	|-Nullable<AddNotifySessionInviteRejectedOptions>.ToString
	|
	|-RVA: 0x148F8E0 Offset: 0x148EAE0 VA: 0x18148F8E0
	|-Nullable<AddNotifyUserLoginStatusChangedOptions>.ToString
	|
	|-RVA: 0x148EAD0 Offset: 0x148DCD0 VA: 0x18148EAD0
	|-Nullable<AddProgressionOptions>.ToString
	|
	|-RVA: 0x1490CD0 Offset: 0x148FED0 VA: 0x181490CD0
	|-Nullable<AndroidIAPVerifyPurchaseOptions>.ToString
	|
	|-RVA: 0x1491B30 Offset: 0x1490D30 VA: 0x181491B30
	|-Nullable<AndroidIAPVerifyPurchaseOptionsPlatformSpecificOptions>.ToString
	|
	|-RVA: 0x1491C80 Offset: 0x1490E80 VA: 0x181491C80
	|-Nullable<AndroidInitializeOptions>.ToString
	|
	|-RVA: 0x1490EE0 Offset: 0x14900E0 VA: 0x181490EE0
	|-Nullable<AndroidInitializeOptionsSystemInitializeOptions>.ToString
	|
	|-RVA: 0x1491680 Offset: 0x1490880 VA: 0x181491680
	|-Nullable<Announcement>.ToString
	|
	|-RVA: 0x14912F0 Offset: 0x14904F0 VA: 0x1814912F0
	|-Nullable<Attribute>.ToString
	|
	|-RVA: 0x148FC30 Offset: 0x148EE30 VA: 0x18148FC30
	|-Nullable<AttributeData>.ToString
	|
	|-RVA: 0x14910E0 Offset: 0x14902E0 VA: 0x1814910E0
	|-Nullable<AttributeData>.ToString
	|
	|-RVA: 0x1492100 Offset: 0x1491300 VA: 0x181492100
	|-Nullable<AttributeDataInternal>.ToString
	|
	|-RVA: 0x148EEC0 Offset: 0x148E0C0 VA: 0x18148EEC0
	|-Nullable<AttributeDataInternal>.ToString
	|
	|-RVA: 0x1491DA0 Offset: 0x1490FA0 VA: 0x181491DA0
	|-Nullable<AttributeDataValue>.ToString
	|
	|-RVA: 0x1490C00 Offset: 0x148FE00 VA: 0x181490C00
	|-Nullable<AttributeDataValue>.ToString
	|
	|-RVA: 0x148ED60 Offset: 0x148DF60 VA: 0x18148ED60
	|-Nullable<AttributeInternal>.ToString
	|
	|-RVA: 0x14A0810 Offset: 0x149FA10 VA: 0x1814A0810
	|-Nullable<AudioBeforeRenderCallbackInfo>.ToString
	|
	|-RVA: 0x149E270 Offset: 0x149D470 VA: 0x18149E270
	|-Nullable<AudioBeforeSendCallbackInfo>.ToString
	|
	|-RVA: 0x149D480 Offset: 0x149C680 VA: 0x18149D480
	|-Nullable<AudioBuffer>.ToString
	|
	|-RVA: 0x149E530 Offset: 0x149D730 VA: 0x18149E530
	|-Nullable<AudioBufferInternal>.ToString
	|
	|-RVA: 0x149E1C0 Offset: 0x149D3C0 VA: 0x18149E1C0
	|-Nullable<AudioDevicesChangedCallbackInfo>.ToString
	|
	|-RVA: 0x149FD50 Offset: 0x149EF50 VA: 0x18149FD50
	|-Nullable<AudioInputDeviceInfo>.ToString
	|
	|-RVA: 0x149E480 Offset: 0x149D680 VA: 0x18149E480
	|-Nullable<AudioInputDeviceInfoInternal>.ToString
	|
	|-RVA: 0x149E930 Offset: 0x149DB30 VA: 0x18149E930
	|-Nullable<AudioInputStateCallbackInfo>.ToString
	|
	|-RVA: 0x149DCF0 Offset: 0x149CEF0 VA: 0x18149DCF0
	|-Nullable<AudioOutputDeviceInfo>.ToString
	|
	|-RVA: 0x149D530 Offset: 0x149C730 VA: 0x18149D530
	|-Nullable<AudioOutputDeviceInfoInternal>.ToString
	|
	|-RVA: 0x149D320 Offset: 0x149C520 VA: 0x18149D320
	|-Nullable<AudioOutputStateCallbackInfo>.ToString
	|
	|-RVA: 0x149EB40 Offset: 0x149DD40 VA: 0x18149EB40
	|-Nullable<AuthExpirationCallbackInfo>.ToString
	|
	|-RVA: 0x149E860 Offset: 0x149DA60 VA: 0x18149E860
	|-Nullable<BeginPlayerSessionOptions>.ToString
	|
	|-RVA: 0x14A1310 Offset: 0x14A0510 VA: 0x1814A1310
	|-Nullable<BeginPlayerSessionOptionsAccountId>.ToString
	|
	|-RVA: 0x149F020 Offset: 0x149E220 VA: 0x18149F020
	|-Nullable<BeginSessionOptions>.ToString
	|
	|-RVA: 0x149E700 Offset: 0x149D900 VA: 0x18149E700
	|-Nullable<BeginSessionOptions>.ToString
	|
	|-RVA: 0x149F6A0 Offset: 0x149E8A0 VA: 0x18149F6A0
	|-Nullable<BeginSnapshotOptions>.ToString
	|
	|-RVA: 0x14A03B0 Offset: 0x149F5B0 VA: 0x1814A03B0
	|-Nullable<BestDisplayName>.ToString
	|
	|-RVA: 0x149EE00 Offset: 0x149E000 VA: 0x18149EE00
	|-Nullable<BestDisplayNameInternal>.ToString
	|
	|-RVA: 0x14A0470 Offset: 0x149F670 VA: 0x1814A0470
	|-Nullable<BigInteger>.ToString
	|
	|-RVA: 0x149D5E0 Offset: 0x149C7E0 VA: 0x18149D5E0
	|-Nullable<BlockParticipantCallbackInfo>.ToString
	|
	|-RVA: 0x149DA10 Offset: 0x149CC10 VA: 0x18149DA10
	|-Nullable<BlockParticipantOptions>.ToString
	|
	|-RVA: 0x14A00C0 Offset: 0x149F2C0 VA: 0x1814A00C0
	|-Nullable<bool>.ToString
	|
	|-RVA: 0x149FA30 Offset: 0x149EC30 VA: 0x18149FA30
	|-Nullable<byte>.ToString
	|
	|-RVA: 0x14A0680 Offset: 0x149F880 VA: 0x1814A0680
	|-Nullable<CatalogItem>.ToString
	|
	|-RVA: 0x14A02C0 Offset: 0x149F4C0 VA: 0x1814A02C0
	|-Nullable<CatalogItemInternal>.ToString
	|
	|-RVA: 0x149F430 Offset: 0x149E630 VA: 0x18149F430
	|-Nullable<CatalogOffer>.ToString
	|
	|-RVA: 0x149D0C0 Offset: 0x149C2C0 VA: 0x18149D0C0
	|-Nullable<CatalogOfferInternal>.ToString
	|
	|-RVA: 0x149F5F0 Offset: 0x149E7F0 VA: 0x18149F5F0
	|-Nullable<CatalogRelease>.ToString
	|
	|-RVA: 0x14A11A0 Offset: 0x14A03A0 VA: 0x1814A11A0
	|-Nullable<CatalogReleaseInternal>.ToString
	|
	|-RVA: 0x149F2E0 Offset: 0x149E4E0 VA: 0x18149F2E0
	|-Nullable<char>.ToString
	|
	|-RVA: 0x149F0D0 Offset: 0x149E2D0 VA: 0x18149F0D0
	|-Nullable<CheckoutCallbackInfo>.ToString
	|
	|-RVA: 0x149ED50 Offset: 0x149DF50 VA: 0x18149ED50
	|-Nullable<CheckoutEntry>.ToString
	|
	|-RVA: 0x149E650 Offset: 0x149D850 VA: 0x18149E650
	|-Nullable<CheckoutOptions>.ToString
	|
	|-RVA: 0x149FC00 Offset: 0x149EE00 VA: 0x18149FC00
	|-Nullable<CheckpointOptions>.ToString
	|
	|-RVA: 0x149DC20 Offset: 0x149CE20 VA: 0x18149DC20
	|-Nullable<ClearPacketQueueOptions>.ToString
	|
	|-RVA: 0x149FCB0 Offset: 0x149EEB0 VA: 0x18149FCB0
	|-Nullable<ClearUserPreLogoutCallbackOptions>.ToString
	|
	|-RVA: 0x149EA90 Offset: 0x149DC90 VA: 0x18149EA90
	|-Nullable<ClientCredentials>.ToString
	|
	|-RVA: 0x149F8B0 Offset: 0x149EAB0 VA: 0x18149F8B0
	|-Nullable<CloseConnectionOptions>.ToString
	|
	|-RVA: 0x14A0510 Offset: 0x149F710 VA: 0x1814A0510
	|-Nullable<CloseConnectionsOptions>.ToString
	|
	|-RVA: 0x14A0CF0 Offset: 0x149FEF0 VA: 0x1814A0CF0
	|-Nullable<CloseOptions>.ToString
	|
	|-RVA: 0x149E5E0 Offset: 0x149D7E0 VA: 0x18149E5E0
	|-Nullable<Color>.ToString
	|
	|-RVA: 0x14A0210 Offset: 0x149F410 VA: 0x1814A0210
	|-Nullable<CopyAchievementDefinitionByAchievementIdOptions>.ToString
	|
	|-RVA: 0x149FAB0 Offset: 0x149ECB0 VA: 0x18149FAB0
	|-Nullable<CopyAchievementDefinitionByIndexOptions>.ToString
	|
	|-RVA: 0x149DFB0 Offset: 0x149D1B0 VA: 0x18149DFB0
	|-Nullable<CopyAchievementDefinitionV2ByAchievementIdOptions>.ToString
	|
	|-RVA: 0x149E330 Offset: 0x149D530 VA: 0x18149E330
	|-Nullable<CopyAchievementDefinitionV2ByIndexOptions>.ToString
	|
	|-RVA: 0x149F980 Offset: 0x149EB80 VA: 0x18149F980
	|-Nullable<CopyActiveSessionHandleOptions>.ToString
	|
	|-RVA: 0x149FB50 Offset: 0x149ED50 VA: 0x18149FB50
	|-Nullable<CopyBestDisplayNameOptions>.ToString
	|
	|-RVA: 0x149F540 Offset: 0x149E740 VA: 0x18149F540
	|-Nullable<CopyBestDisplayNameWithPlatformOptions>.ToString
	|
	|-RVA: 0x14A0C40 Offset: 0x149FE40 VA: 0x1814A0C40
	|-Nullable<CopyEntitlementByIdOptions>.ToString
	|
	|-RVA: 0x149DF00 Offset: 0x149D100 VA: 0x18149DF00
	|-Nullable<CopyEntitlementByIndexOptions>.ToString
	|
	|-RVA: 0x149D1D0 Offset: 0x149C3D0 VA: 0x18149D1D0
	|-Nullable<CopyEntitlementByNameAndIndexOptions>.ToString
	|
	|-RVA: 0x14A0AE0 Offset: 0x149FCE0 VA: 0x1814A0AE0
	|-Nullable<CopyExternalUserInfoByAccountIdOptions>.ToString
	|
	|-RVA: 0x149E3D0 Offset: 0x149D5D0 VA: 0x18149E3D0
	|-Nullable<CopyExternalUserInfoByAccountTypeOptions>.ToString
	|
	|-RVA: 0x149EF70 Offset: 0x149E170 VA: 0x18149EF70
	|-Nullable<CopyExternalUserInfoByIndexOptions>.ToString
	|
	|-RVA: 0x14A0A30 Offset: 0x149FC30 VA: 0x1814A0A30
	|-Nullable<CopyFileMetadataAtIndexOptions>.ToString
	|
	|-RVA: 0x14A0760 Offset: 0x149F960 VA: 0x1814A0760
	|-Nullable<CopyFileMetadataAtIndexOptions>.ToString
	|
	|-RVA: 0x14A1520 Offset: 0x14A0720 VA: 0x1814A1520
	|-Nullable<CopyFileMetadataByFilenameOptions>.ToString
	|
	|-RVA: 0x14A0EF0 Offset: 0x14A00F0 VA: 0x1814A0EF0
	|-Nullable<CopyFileMetadataByFilenameOptions>.ToString
	|
	|-RVA: 0x149F750 Offset: 0x149E950 VA: 0x18149F750
	|-Nullable<CopyIdTokenOptions>.ToString
	|
	|-RVA: 0x149F800 Offset: 0x149EA00 VA: 0x18149F800
	|-Nullable<CopyIdTokenOptions>.ToString
	|
	|-RVA: 0x14A0E50 Offset: 0x14A0050 VA: 0x1814A0E50
	|-Nullable<CopyInputDeviceInformationByIndexOptions>.ToString
	|
	|-RVA: 0x149D3D0 Offset: 0x149C5D0 VA: 0x18149D3D0
	|-Nullable<CopyItemByIdOptions>.ToString
	|
	|-RVA: 0x149FE00 Offset: 0x149F000 VA: 0x18149FE00
	|-Nullable<CopyItemImageInfoByIndexOptions>.ToString
	|
	|-RVA: 0x149DB70 Offset: 0x149CD70 VA: 0x18149DB70
	|-Nullable<CopyItemReleaseByIndexOptions>.ToString
	|
	|-RVA: 0x149E110 Offset: 0x149D310 VA: 0x18149E110
	|-Nullable<CopyLastRedeemedEntitlementByIndexOptions>.ToString
	|
	|-RVA: 0x14A0990 Offset: 0x149FB90 VA: 0x1814A0990
	|-Nullable<CopyLeaderboardDefinitionByIndexOptions>.ToString
	|
	|-RVA: 0x149F230 Offset: 0x149E430 VA: 0x18149F230
	|-Nullable<CopyLeaderboardDefinitionByLeaderboardIdOptions>.ToString
	|
	|-RVA: 0x149D280 Offset: 0x149C480 VA: 0x18149D280
	|-Nullable<CopyLeaderboardRecordByIndexOptions>.ToString
	|
	|-RVA: 0x149DE50 Offset: 0x149D050 VA: 0x18149DE50
	|-Nullable<CopyLeaderboardRecordByUserIdOptions>.ToString
	|
	|-RVA: 0x14A08E0 Offset: 0x149FAE0 VA: 0x1814A08E0
	|-Nullable<CopyLeaderboardUserScoreByIndexOptions>.ToString
	|
	|-RVA: 0x149D6A0 Offset: 0x149C8A0 VA: 0x18149D6A0
	|-Nullable<CopyLeaderboardUserScoreByUserIdOptions>.ToString
	|
	|-RVA: 0x14A1260 Offset: 0x14A0460 VA: 0x1814A1260
	|-Nullable<CopyLobbyDetailsHandleByInviteIdOptions>.ToString
	|
	|-RVA: 0x14A13C0 Offset: 0x14A05C0 VA: 0x1814A13C0
	|-Nullable<CopyLobbyDetailsHandleByUiEventIdOptions>.ToString
	|
	|-RVA: 0x149FF60 Offset: 0x149F160 VA: 0x18149FF60
	|-Nullable<CopyLobbyDetailsHandleOptions>.ToString
	|
	|-RVA: 0x149FEB0 Offset: 0x149F0B0 VA: 0x18149FEB0
	|-Nullable<CopyModInfoOptions>.ToString
	|
	|-RVA: 0x149D750 Offset: 0x149C950 VA: 0x18149D750
	|-Nullable<CopyOfferByIdOptions>.ToString
	|
	|-RVA: 0x149ECA0 Offset: 0x149DEA0 VA: 0x18149ECA0
	|-Nullable<CopyOfferByIndexOptions>.ToString
	|
	|-RVA: 0x149D960 Offset: 0x149CB60 VA: 0x18149D960
	|-Nullable<CopyOfferImageInfoByIndexOptions>.ToString
	|
	|-RVA: 0x149D8B0 Offset: 0x149CAB0 VA: 0x18149D8B0
	|-Nullable<CopyOfferItemByIndexOptions>.ToString
	|
	|-RVA: 0x14A1100 Offset: 0x14A0300 VA: 0x1814A1100
	|-Nullable<CopyOutputDeviceInformationByIndexOptions>.ToString
	|
	|-RVA: 0x14A0DA0 Offset: 0x149FFA0 VA: 0x1814A0DA0
	|-Nullable<CopyPermissionByIndexOptions>.ToString
	|
	|-RVA: 0x149D800 Offset: 0x149CA00 VA: 0x18149D800
	|-Nullable<CopyPlayerAchievementByAchievementIdOptions>.ToString
	|
	|-RVA: 0x149EBF0 Offset: 0x149DDF0 VA: 0x18149EBF0
	|-Nullable<CopyPlayerAchievementByIndexOptions>.ToString
	|
	|-RVA: 0x149E7B0 Offset: 0x149D9B0 VA: 0x18149E7B0
	|-Nullable<CopyPlayerSanctionByIndexOptions>.ToString
	|
	|-RVA: 0x14A05D0 Offset: 0x149F7D0 VA: 0x1814A05D0
	|-Nullable<CopyPresenceOptions>.ToString
	|
	|-RVA: 0x14A1050 Offset: 0x14A0250 VA: 0x1814A1050
	|-Nullable<CopyProductUserExternalAccountByAccountIdOptions>.ToString
	|
	|-RVA: 0x14A0010 Offset: 0x149F210 VA: 0x1814A0010
	|-Nullable<CopyProductUserExternalAccountByAccountTypeOptions>.ToString
	|
	|-RVA: 0x149F180 Offset: 0x149E380 VA: 0x18149F180
	|-Nullable<CopyProductUserExternalAccountByIndexOptions>.ToString
	|
	|-RVA: 0x149E060 Offset: 0x149D260 VA: 0x18149E060
	|-Nullable<CopyProductUserInfoOptions>.ToString
	|
	|-RVA: 0x14A0B90 Offset: 0x149FD90 VA: 0x1814A0B90
	|-Nullable<CopySessionHandleByInviteIdOptions>.ToString
	|
	|-RVA: 0x14A0FA0 Offset: 0x14A01A0 VA: 0x1814A0FA0
	|-Nullable<CopySessionHandleByUiEventIdOptions>.ToString
	|
	|-RVA: 0x149DAC0 Offset: 0x149CCC0 VA: 0x18149DAC0
	|-Nullable<CopySessionHandleForPresenceOptions>.ToString
	|
	|-RVA: 0x149DDA0 Offset: 0x149CFA0 VA: 0x18149DDA0
	|-Nullable<CopyStatByIndexOptions>.ToString
	|
	|-RVA: 0x14A0160 Offset: 0x149F360 VA: 0x1814A0160
	|-Nullable<CopyStatByNameOptions>.ToString
	|
	|-RVA: 0x149E9E0 Offset: 0x149DBE0 VA: 0x18149E9E0
	|-Nullable<CopyTransactionByIdOptions>.ToString
	|
	|-RVA: 0x14A1470 Offset: 0x14A0670 VA: 0x1814A1470
	|-Nullable<CopyTransactionByIndexOptions>.ToString
	|
	|-RVA: 0x149F380 Offset: 0x149E580 VA: 0x18149F380
	|-Nullable<CopyUnlockedAchievementByAchievementIdOptions>.ToString
	|
	|-RVA: 0x149EEC0 Offset: 0x149E0C0 VA: 0x18149EEC0
	|-Nullable<CopyUnlockedAchievementByIndexOptions>.ToString
	|
	|-RVA: 0x14AFE30 Offset: 0x14AF030 VA: 0x1814AFE30
	|-Nullable<CopyUserAuthTokenOptions>.ToString
	|
	|-RVA: 0x14AECC0 Offset: 0x14ADEC0 VA: 0x1814AECC0
	|-Nullable<CopyUserInfoOptions>.ToString
	|
	|-RVA: 0x14B0D10 Offset: 0x14AFF10 VA: 0x1814B0D10
	|-Nullable<CopyUserTokenByIndexOptions>.ToString
	|
	|-RVA: 0x14B1080 Offset: 0x14B0280 VA: 0x1814B1080
	|-Nullable<CopyUserTokenByUserIdOptions>.ToString
	|
	|-RVA: 0x14AEF80 Offset: 0x14AE180 VA: 0x1814AEF80
	|-Nullable<CreateDeviceIdCallbackInfo>.ToString
	|
	|-RVA: 0x14AFCD0 Offset: 0x14AEED0 VA: 0x1814AFCD0
	|-Nullable<CreateDeviceIdOptions>.ToString
	|
	|-RVA: 0x14AE610 Offset: 0x14AD810 VA: 0x1814AE610
	|-Nullable<CreateIntegratedPlatformOptionsContainerOptions>.ToString
	|
	|-RVA: 0x14AD2C0 Offset: 0x14AC4C0 VA: 0x1814AD2C0
	|-Nullable<CreateLobbyCallbackInfo>.ToString
	|
	|-RVA: 0x14AE990 Offset: 0x14ADB90 VA: 0x1814AE990
	|-Nullable<CreateLobbyOptions>.ToString
	|
	|-RVA: 0x14AD170 Offset: 0x14AC370 VA: 0x1814AD170
	|-Nullable<CreateLobbySearchOptions>.ToString
	|
	|-RVA: 0x14B0810 Offset: 0x14AFA10 VA: 0x1814B0810
	|-Nullable<CreateOptions>.ToString
	|
	|-RVA: 0x14ADEA0 Offset: 0x14AD0A0 VA: 0x1814ADEA0
	|-Nullable<CreatePlayerSanctionAppealCallbackInfo>.ToString
	|
	|-RVA: 0x14B0760 Offset: 0x14AF960 VA: 0x1814B0760
	|-Nullable<CreatePlayerSanctionAppealOptions>.ToString
	|
	|-RVA: 0x14AF4F0 Offset: 0x14AE6F0 VA: 0x1814AF4F0
	|-Nullable<CreatePresenceModificationOptions>.ToString
	|
	|-RVA: 0x14B01C0 Offset: 0x14AF3C0 VA: 0x1814B01C0
	|-Nullable<CreateSessionModificationOptions>.ToString
	|
	|-RVA: 0x14AF2E0 Offset: 0x14AE4E0 VA: 0x1814AF2E0
	|-Nullable<CreateSessionSearchOptions>.ToString
	|
	|-RVA: 0x14B0A60 Offset: 0x14AFC60 VA: 0x1814B0A60
	|-Nullable<CreateUserCallbackInfo>.ToString
	|
	|-RVA: 0x14B0540 Offset: 0x14AF740 VA: 0x1814B0540
	|-Nullable<CreateUserCallbackInfo>.ToString
	|
	|-RVA: 0x14B0060 Offset: 0x14AF260 VA: 0x1814B0060
	|-Nullable<CreateUserOptions>.ToString
	|
	|-RVA: 0x14AE160 Offset: 0x14AD360 VA: 0x1814AE160
	|-Nullable<CreateUserOptions>.ToString
	|
	|-RVA: 0x14AF700 Offset: 0x14AE900 VA: 0x1814AF700
	|-Nullable<Credentials>.ToString
	|
	|-RVA: 0x14B0B10 Offset: 0x14AFD10 VA: 0x1814B0B10
	|-Nullable<Credentials>.ToString
	|
	|-RVA: 0x14AD630 Offset: 0x14AC830 VA: 0x1814AD630
	|-Nullable<CustomInviteRejectedCallbackInfo>.ToString
	|
	|-RVA: 0x14B1540 Offset: 0x14B0740 VA: 0x1814B1540
	|-Nullable<DataKey>.ToString
	|
	|-RVA: 0x14AF430 Offset: 0x14AE630 VA: 0x1814AF430
	|-Nullable<DataReceivedCallbackInfo>.ToString
	|
	|-RVA: 0x14AFB40 Offset: 0x14AED40 VA: 0x1814AFB40
	|-Nullable<DataRecord>.ToString
	|
	|-RVA: 0x14AF0E0 Offset: 0x14AE2E0 VA: 0x1814AF0E0
	|-Nullable<DateTime>.ToString
	|
	|-RVA: 0x14AFFC0 Offset: 0x14AF1C0 VA: 0x1814AFFC0
	|-Nullable<DateTimeOffset>.ToString
	|
	|-RVA: 0x14AE210 Offset: 0x14AD410 VA: 0x1814AE210
	|-Nullable<Decimal>.ToString
	|
	|-RVA: 0x14AEB20 Offset: 0x14ADD20 VA: 0x1814AEB20
	|-Nullable<Definition>.ToString
	|
	|-RVA: 0x14AFBF0 Offset: 0x14AEDF0 VA: 0x1814AFBF0
	|-Nullable<Definition>.ToString
	|
	|-RVA: 0x14B08C0 Offset: 0x14AFAC0 VA: 0x1814B08C0
	|-Nullable<DefinitionInternal>.ToString
	|
	|-RVA: 0x14AE780 Offset: 0x14AD980 VA: 0x1814AE780
	|-Nullable<DefinitionInternal>.ToString
	|
	|-RVA: 0x14AF200 Offset: 0x14AE400 VA: 0x1814AF200
	|-Nullable<DefinitionV2>.ToString
	|
	|-RVA: 0x14AFED0 Offset: 0x14AF0D0 VA: 0x1814AFED0
	|-Nullable<DefinitionV2Internal>.ToString
	|
	|-RVA: 0x14AF870 Offset: 0x14AEA70 VA: 0x1814AF870
	|-Nullable<DeleteCacheCallbackInfo>.ToString
	|
	|-RVA: 0x14AEED0 Offset: 0x14AE0D0 VA: 0x1814AEED0
	|-Nullable<DeleteCacheCallbackInfo>.ToString
	|
	|-RVA: 0x14ADDF0 Offset: 0x14ACFF0 VA: 0x1814ADDF0
	|-Nullable<DeleteCacheOptions>.ToString
	|
	|-RVA: 0x14AD840 Offset: 0x14ACA40 VA: 0x1814AD840
	|-Nullable<DeleteCacheOptions>.ToString
	|
	|-RVA: 0x14B11E0 Offset: 0x14B03E0 VA: 0x1814B11E0
	|-Nullable<DeleteDeviceIdCallbackInfo>.ToString
	|
	|-RVA: 0x14AD6F0 Offset: 0x14AC8F0 VA: 0x1814AD6F0
	|-Nullable<DeleteDeviceIdOptions>.ToString
	|
	|-RVA: 0x14B0F20 Offset: 0x14B0120 VA: 0x1814B0F20
	|-Nullable<DeleteFileCallbackInfo>.ToString
	|
	|-RVA: 0x14AE0B0 Offset: 0x14AD2B0 VA: 0x1814AE0B0
	|-Nullable<DeleteFileOptions>.ToString
	|
	|-RVA: 0x14B09B0 Offset: 0x14AFBB0 VA: 0x1814B09B0
	|-Nullable<DeletePersistentAuthCallbackInfo>.ToString
	|
	|-RVA: 0x14AF7C0 Offset: 0x14AE9C0 VA: 0x1814AF7C0
	|-Nullable<DeletePersistentAuthOptions>.ToString
	|
	|-RVA: 0x14ADBC0 Offset: 0x14ACDC0 VA: 0x1814ADBC0
	|-Nullable<DeleteSnapshotCallbackInfo>.ToString
	|
	|-RVA: 0x14AF380 Offset: 0x14AE580 VA: 0x1814AF380
	|-Nullable<DeleteSnapshotOptions>.ToString
	|
	|-RVA: 0x14ADF50 Offset: 0x14AD150 VA: 0x1814ADF50
	|-Nullable<DesktopCrossplayStatusInfo>.ToString
	|
	|-RVA: 0x14B0600 Offset: 0x14AF800 VA: 0x1814B0600
	|-Nullable<DestroyLobbyCallbackInfo>.ToString
	|
	|-RVA: 0x14B1490 Offset: 0x14B0690 VA: 0x1814B1490
	|-Nullable<DestroyLobbyOptions>.ToString
	|
	|-RVA: 0x14AE560 Offset: 0x14AD760 VA: 0x1814AE560
	|-Nullable<DestroySessionCallbackInfo>.ToString
	|
	|-RVA: 0x14AD790 Offset: 0x14AC990 VA: 0x1814AD790
	|-Nullable<DestroySessionOptions>.ToString
	|
	|-RVA: 0x14AFD80 Offset: 0x14AEF80 VA: 0x1814AFD80
	|-Nullable<DisconnectedCallbackInfo>.ToString
	|
	|-RVA: 0x14AF180 Offset: 0x14AE380 VA: 0x1814AF180
	|-Nullable<double>.ToString
	|
	|-RVA: 0x14AE000 Offset: 0x14AD200 VA: 0x1814AE000
	|-Nullable<DumpSessionStateOptions>.ToString
	|
	|-RVA: 0x14AD370 Offset: 0x14AC570 VA: 0x1814AD370
	|-Nullable<DuplicateFileCallbackInfo>.ToString
	|
	|-RVA: 0x14AD580 Offset: 0x14AC780 VA: 0x1814AD580
	|-Nullable<DuplicateFileOptions>.ToString
	|
	|-RVA: 0x14AF5A0 Offset: 0x14AE7A0 VA: 0x1814AF5A0
	|-Nullable<EGSDLCVerifyPurchaseOptions>.ToString
	|
	|-RVA: 0x14B1130 Offset: 0x14B0330 VA: 0x1814B1130
	|-Nullable<EGSDLCVerifyPurchaseOptionsPlatformSpecificOptions>.ToString
	|
	|-RVA: 0x14ADA40 Offset: 0x14ACC40 VA: 0x1814ADA40
	|-Nullable<EGSIAPVerifyPurchaseOptions>.ToString
	|
	|-RVA: 0x14B0DC0 Offset: 0x14AFFC0 VA: 0x1814B0DC0
	|-Nullable<EGSIAPVerifyPurchaseOptionsPlatformSpecificOptions>.ToString
	|
	|-RVA: 0x14AE360 Offset: 0x14AD560 VA: 0x1814AE360
	|-Nullable<EndPlayerSessionOptions>.ToString
	|
	|-RVA: 0x14AEE20 Offset: 0x14AE020 VA: 0x1814AEE20
	|-Nullable<EndPlayerSessionOptionsAccountId>.ToString
	|
	|-RVA: 0x14B0110 Offset: 0x14AF310 VA: 0x1814B0110
	|-Nullable<EndSessionCallbackInfo>.ToString
	|
	|-RVA: 0x14AE4C0 Offset: 0x14AD6C0 VA: 0x1814AE4C0
	|-Nullable<EndSessionOptions>.ToString
	|
	|-RVA: 0x14B0C70 Offset: 0x14AFE70 VA: 0x1814B0C70
	|-Nullable<EndSessionOptions>.ToString
	|
	|-RVA: 0x14B06B0 Offset: 0x14AF8B0 VA: 0x1814B06B0
	|-Nullable<EndSessionOptions>.ToString
	|
	|-RVA: 0x14AF9E0 Offset: 0x14AEBE0 VA: 0x1814AF9E0
	|-Nullable<EndSnapshotOptions>.ToString
	|
	|-RVA: 0x14ADB00 Offset: 0x14ACD00 VA: 0x1814ADB00
	|-Nullable<Entitlement>.ToString
	|
	|-RVA: 0x14AF920 Offset: 0x14AEB20 VA: 0x1814AF920
	|-Nullable<EntitlementInternal>.ToString
	|
	|-RVA: 0x14AF030 Offset: 0x14AE230 VA: 0x1814AF030
	|-Nullable<EnumerateModsCallbackInfo>.ToString
	|
	|-RVA: 0x14B0E70 Offset: 0x14B0070 VA: 0x1814B0E70
	|-Nullable<EnumerateModsOptions>.ToString
	|
	|-RVA: 0x14B0340 Offset: 0x14AF540 VA: 0x1814B0340
	|-Nullable<EventDispatcherGate>.ToString
	|
	|-RVA: 0x14ADC70 Offset: 0x14ACE70 VA: 0x1814ADC70
	|-Nullable<ExternalAccountInfo>.ToString
	|
	|-RVA: 0x14AD420 Offset: 0x14AC620 VA: 0x1814AD420
	|-Nullable<ExternalAccountInfoInternal>.ToString
	|
	|-RVA: 0x14AE840 Offset: 0x14ADA40 VA: 0x1814AE840
	|-Nullable<ExternalUserInfo>.ToString
	|
	|-RVA: 0x14B0BC0 Offset: 0x14AFDC0 VA: 0x1814B0BC0
	|-Nullable<ExternalUserInfoInternal>.ToString
	|
	|-RVA: 0x14AE6B0 Offset: 0x14AD8B0 VA: 0x1814AE6B0
	|-Nullable<FileMetadata>.ToString
	|
	|-RVA: 0x14B15F0 Offset: 0x14B07F0 VA: 0x1814B15F0
	|-Nullable<FileMetadata>.ToString
	|
	|-RVA: 0x14AFA80 Offset: 0x14AEC80 VA: 0x1814AFA80
	|-Nullable<FileMetadataInternal>.ToString
	|
	|-RVA: 0x14AD990 Offset: 0x14ACB90 VA: 0x1814AD990
	|-Nullable<FileMetadataInternal>.ToString
	|
	|-RVA: 0x14AE410 Offset: 0x14AD610 VA: 0x1814AE410
	|-Nullable<FileTransferProgressCallbackInfo>.ToString
	|
	|-RVA: 0x14AEC10 Offset: 0x14ADE10 VA: 0x1814AEC10
	|-Nullable<FileTransferProgressCallbackInfo>.ToString
	|
	|-RVA: 0x14AEA70 Offset: 0x14ADC70 VA: 0x1814AEA70
	|-Nullable<FinalizeDeferredUserLogoutOptions>.ToString
	|
	|-RVA: 0x14AED70 Offset: 0x14ADF70 VA: 0x1814AED70
	|-Nullable<FinalizeInviteOptions>.ToString
	|
	|-RVA: 0x14ADD40 Offset: 0x14ACF40 VA: 0x1814ADD40
	|-Nullable<GCHandle>.ToString
	|
	|-RVA: 0x14B1340 Offset: 0x14B0540 VA: 0x1814B1340
	|-Nullable<GetAchievementDefinitionCountOptions>.ToString
	|
	|-RVA: 0x14AD4E0 Offset: 0x14AC6E0 VA: 0x1814AD4E0
	|-Nullable<GetAudioInputDeviceByIndexOptions>.ToString
	|
	|-RVA: 0x14B03F0 Offset: 0x14AF5F0 VA: 0x1814B03F0
	|-Nullable<GetAudioInputDevicesCountOptions>.ToString
	|
	|-RVA: 0x14AE8F0 Offset: 0x14ADAF0 VA: 0x1814AE8F0
	|-Nullable<GetAudioOutputDeviceByIndexOptions>.ToString
	|
	|-RVA: 0x14AF660 Offset: 0x14AE860 VA: 0x1814AF660
	|-Nullable<GetAudioOutputDevicesCountOptions>.ToString
	|
	|-RVA: 0x14AE2B0 Offset: 0x14AD4B0 VA: 0x1814AE2B0
	|-Nullable<GetBlockedUserAtIndexOptions>.ToString
	|
	|-RVA: 0x14B0490 Offset: 0x14AF690 VA: 0x1814B0490
	|-Nullable<GetBlockedUsersCountOptions>.ToString
	|
	|-RVA: 0x14B0290 Offset: 0x14AF490 VA: 0x1814B0290
	|-Nullable<GetConnectStringOptions>.ToString
	|
	|-RVA: 0x14AD8F0 Offset: 0x14ACAF0 VA: 0x1814AD8F0
	|-Nullable<GetDesktopCrossplayStatusOptions>.ToString
	|
	|-RVA: 0x14B1290 Offset: 0x14B0490 VA: 0x1814B1290
	|-Nullable<GetEntitlementsByNameCountOptions>.ToString
	|
	|-RVA: 0x14B13E0 Offset: 0x14B05E0 VA: 0x1814B13E0
	|-Nullable<GetEntitlementsCountOptions>.ToString
	|
	|-RVA: 0x14B0FD0 Offset: 0x14B01D0 VA: 0x1814B0FD0
	|-Nullable<GetExternalAccountMappingsOptions>.ToString
	|
	|-RVA: 0x14AD210 Offset: 0x14AC410 VA: 0x1814AD210
	|-Nullable<GetExternalUserInfoCountOptions>.ToString
	|
	|-RVA: 0x14BFF40 Offset: 0x14BF140 VA: 0x1814BFF40
	|-Nullable<GetFileMetadataCountOptions>.ToString
	|
	|-RVA: 0x14BF600 Offset: 0x14BE800 VA: 0x1814BF600
	|-Nullable<GetFileMetadataCountOptions>.ToString
	|
	|-RVA: 0x14BEC30 Offset: 0x14BDE30 VA: 0x1814BEC30
	|-Nullable<GetFriendAtIndexOptions>.ToString
	|
	|-RVA: 0x14BEB80 Offset: 0x14BDD80 VA: 0x1814BEB80
	|-Nullable<GetFriendsCountOptions>.ToString
	|
	|-RVA: 0x14BE4C0 Offset: 0x14BD6C0 VA: 0x1814BE4C0
	|-Nullable<GetFriendsExclusiveInputOptions>.ToString
	|
	|-RVA: 0x14C0350 Offset: 0x14BF550 VA: 0x1814C0350
	|-Nullable<GetFriendsVisibleOptions>.ToString
	|
	|-RVA: 0x14BDB40 Offset: 0x14BCD40 VA: 0x1814BDB40
	|-Nullable<GetInputDevicesCountOptions>.ToString
	|
	|-RVA: 0x14BD4E0 Offset: 0x14BC6E0 VA: 0x1814BD4E0
	|-Nullable<GetInviteCountOptions>.ToString
	|
	|-RVA: 0x14BEE60 Offset: 0x14BE060 VA: 0x1814BEE60
	|-Nullable<GetInviteCountOptions>.ToString
	|
	|-RVA: 0x14C0900 Offset: 0x14BFB00 VA: 0x1814C0900
	|-Nullable<GetInviteIdByIndexOptions>.ToString
	|
	|-RVA: 0x14BD7D0 Offset: 0x14BC9D0 VA: 0x1814BD7D0
	|-Nullable<GetInviteIdByIndexOptions>.ToString
	|
	|-RVA: 0x14BF6B0 Offset: 0x14BE8B0 VA: 0x1814BF6B0
	|-Nullable<GetItemImageInfoCountOptions>.ToString
	|
	|-RVA: 0x14BE610 Offset: 0x14BD810 VA: 0x1814BE610
	|-Nullable<GetItemReleaseCountOptions>.ToString
	|
	|-RVA: 0x14BF760 Offset: 0x14BE960 VA: 0x1814BF760
	|-Nullable<GetJoinInfoOptions>.ToString
	|
	|-RVA: 0x14BCE00 Offset: 0x14BC000 VA: 0x1814BCE00
	|-Nullable<GetLastRedeemedEntitlementsCountOptions>.ToString
	|
	|-RVA: 0x14BE570 Offset: 0x14BD770 VA: 0x1814BE570
	|-Nullable<GetLeaderboardDefinitionCountOptions>.ToString
	|
	|-RVA: 0x14BCCE0 Offset: 0x14BBEE0 VA: 0x1814BCCE0
	|-Nullable<GetLeaderboardRecordCountOptions>.ToString
	|
	|-RVA: 0x14C0B10 Offset: 0x14BFD10 VA: 0x1814C0B10
	|-Nullable<GetLeaderboardUserScoreCountOptions>.ToString
	|
	|-RVA: 0x14BF1E0 Offset: 0x14BE3E0 VA: 0x1814BF1E0
	|-Nullable<GetLocalPlatformTypeOptions>.ToString
	|
	|-RVA: 0x14BEFF0 Offset: 0x14BE1F0 VA: 0x1814BEFF0
	|-Nullable<GetNATTypeOptions>.ToString
	|
	|-RVA: 0x14C0C70 Offset: 0x14BFE70 VA: 0x1814C0C70
	|-Nullable<GetNextReceivedPacketSizeOptions>.ToString
	|
	|-RVA: 0x14BD380 Offset: 0x14BC580 VA: 0x1814BD380
	|-Nullable<GetOfferCountOptions>.ToString
	|
	|-RVA: 0x14BD430 Offset: 0x14BC630 VA: 0x1814BD430
	|-Nullable<GetOfferImageInfoCountOptions>.ToString
	|
	|-RVA: 0x14BCF60 Offset: 0x14BC160 VA: 0x1814BCF60
	|-Nullable<GetOfferItemCountOptions>.ToString
	|
	|-RVA: 0x14BFBE0 Offset: 0x14BEDE0 VA: 0x1814BFBE0
	|-Nullable<GetOutputDevicesCountOptions>.ToString
	|
	|-RVA: 0x14BF560 Offset: 0x14BE760 VA: 0x1814BF560
	|-Nullable<GetPacketQueueInfoOptions>.ToString
	|
	|-RVA: 0x14C0E80 Offset: 0x14C0080 VA: 0x1814C0E80
	|-Nullable<GetPermissionByKeyOptions>.ToString
	|
	|-RVA: 0x14C0780 Offset: 0x14BF980 VA: 0x1814C0780
	|-Nullable<GetPermissionsCountOptions>.ToString
	|
	|-RVA: 0x14BD880 Offset: 0x14BCA80 VA: 0x1814BD880
	|-Nullable<GetPlayerAchievementCountOptions>.ToString
	|
	|-RVA: 0x14C09B0 Offset: 0x14BFBB0 VA: 0x1814C09B0
	|-Nullable<GetPlayerSanctionCountOptions>.ToString
	|
	|-RVA: 0x14BCC40 Offset: 0x14BBE40 VA: 0x1814BCC40
	|-Nullable<GetPortRangeOptions>.ToString
	|
	|-RVA: 0x14BDA90 Offset: 0x14BCC90 VA: 0x1814BDA90
	|-Nullable<GetProductUserExternalAccountCountOptions>.ToString
	|
	|-RVA: 0x14BE8C0 Offset: 0x14BDAC0 VA: 0x1814BE8C0
	|-Nullable<GetProductUserIdMappingOptions>.ToString
	|
	|-RVA: 0x14BDC80 Offset: 0x14BCE80 VA: 0x1814BDC80
	|-Nullable<GetProtectMessageOutputLengthOptions>.ToString
	|
	|-RVA: 0x14BD0C0 Offset: 0x14BC2C0 VA: 0x1814BD0C0
	|-Nullable<GetProtectMessageOutputLengthOptions>.ToString
	|
	|-RVA: 0x14BCEB0 Offset: 0x14BC0B0 VA: 0x1814BCEB0
	|-Nullable<GetRTCRoomNameOptions>.ToString
	|
	|-RVA: 0x14BFFF0 Offset: 0x14BF1F0 VA: 0x1814BFFF0
	|-Nullable<GetRelayControlOptions>.ToString
	|
	|-RVA: 0x14C0140 Offset: 0x14BF340 VA: 0x1814C0140
	|-Nullable<GetStatCountOptions>.ToString
	|
	|-RVA: 0x14BD590 Offset: 0x14BC790 VA: 0x1814BD590
	|-Nullable<GetStatusOptions>.ToString
	|
	|-RVA: 0x14BE300 Offset: 0x14BD500 VA: 0x1814BE300
	|-Nullable<GetToggleFriendsButtonOptions>.ToString
	|
	|-RVA: 0x14BD160 Offset: 0x14BC360 VA: 0x1814BD160
	|-Nullable<GetToggleFriendsKeyOptions>.ToString
	|
	|-RVA: 0x14BE790 Offset: 0x14BD990 VA: 0x1814BE790
	|-Nullable<GetTransactionCountOptions>.ToString
	|
	|-RVA: 0x14C0D20 Offset: 0x14BFF20 VA: 0x1814C0D20
	|-Nullable<GetUnlockedAchievementCountOptions>.ToString
	|
	|-RVA: 0x14BD300 Offset: 0x14BC500 VA: 0x1814BD300
	|-Nullable<Guid>.ToString
	|
	|-RVA: 0x14BFC80 Offset: 0x14BEE80 VA: 0x1814BFC80
	|-Nullable<HardMuteMemberCallbackInfo>.ToString
	|
	|-RVA: 0x14C04D0 Offset: 0x14BF6D0 VA: 0x1814C04D0
	|-Nullable<HardMuteMemberOptions>.ToString
	|
	|-RVA: 0x14BFA80 Offset: 0x14BEC80 VA: 0x1814BFA80
	|-Nullable<HasPresenceOptions>.ToString
	|
	|-RVA: 0x14BFD30 Offset: 0x14BEF30 VA: 0x1814BFD30
	|-Nullable<HideFriendsCallbackInfo>.ToString
	|
	|-RVA: 0x14C0DD0 Offset: 0x14BFFD0 VA: 0x1814C0DD0
	|-Nullable<HideFriendsOptions>.ToString
	|
	|-RVA: 0x14C0400 Offset: 0x14BF600 VA: 0x1814C0400
	|-Nullable<IOSCredentials>.ToString
	|
	|-RVA: 0x14BDDC0 Offset: 0x14BCFC0 VA: 0x1814BDDC0
	|-Nullable<IOSCredentialsSystemAuthCredentialsOptions>.ToString
	|
	|-RVA: 0x14C0BC0 Offset: 0x14BFDC0 VA: 0x1814C0BC0
	|-Nullable<IOSCredentialsSystemAuthCredentialsOptionsInternal>.ToString
	|
	|-RVA: 0x14BFDE0 Offset: 0x14BEFE0 VA: 0x1814BFDE0
	|-Nullable<IOSIAPVerifyPurchaseOptions>.ToString
	|
	|-RVA: 0x14BF280 Offset: 0x14BE480 VA: 0x1814BF280
	|-Nullable<IOSIAPVerifyPurchaseOptionsPlatformSpecificOptions>.ToString
	|
	|-RVA: 0x14BD640 Offset: 0x14BC840 VA: 0x1814BD640
	|-Nullable<IOSLoginOptions>.ToString
	|
	|-RVA: 0x14C0A60 Offset: 0x14BFC60 VA: 0x1814C0A60
	|-Nullable<IdToken>.ToString
	|
	|-RVA: 0x14BF9D0 Offset: 0x14BEBD0 VA: 0x1814BF9D0
	|-Nullable<IdToken>.ToString
	|
	|-RVA: 0x14BEA20 Offset: 0x14BDC20 VA: 0x1814BEA20
	|-Nullable<IdTokenInternal>.ToString
	|
	|-RVA: 0x14C0090 Offset: 0x14BF290 VA: 0x1814C0090
	|-Nullable<IdTokenInternal>.ToString
	|
	|-RVA: 0x14BF3D0 Offset: 0x14BE5D0 VA: 0x1814BF3D0
	|-Nullable<Info>.ToString
	|
	|-RVA: 0x14BEF10 Offset: 0x14BE110 VA: 0x1814BEF10
	|-Nullable<InfoInternal>.ToString
	|
	|-RVA: 0x14BE970 Offset: 0x14BDB70 VA: 0x1814BE970
	|-Nullable<IngestData>.ToString
	|
	|-RVA: 0x14BEAD0 Offset: 0x14BDCD0 VA: 0x1814BEAD0
	|-Nullable<IngestStatCompleteCallbackInfo>.ToString
	|
	|-RVA: 0x14C02A0 Offset: 0x14BF4A0 VA: 0x1814C02A0
	|-Nullable<IngestStatOptions>.ToString
	|
	|-RVA: 0x14BD200 Offset: 0x14BC400 VA: 0x1814BD200
	|-Nullable<InitializeOptions>.ToString
	|
	|-RVA: 0x14C0830 Offset: 0x14BFA30 VA: 0x1814C0830
	|-Nullable<InitializeThreadAffinity>.ToString
	|
	|-RVA: 0x14C01F0 Offset: 0x14BF3F0 VA: 0x1814C01F0
	|-Nullable<InputDeviceInformation>.ToString
	|
	|-RVA: 0x14BF130 Offset: 0x14BE330 VA: 0x1814BF130
	|-Nullable<InputDeviceInformationInternal>.ToString
	|
	|-RVA: 0x14BECE0 Offset: 0x14BDEE0 VA: 0x1814BECE0
	|-Nullable<InstallModCallbackInfo>.ToString
	|
	|-RVA: 0x14BE6C0 Offset: 0x14BD8C0 VA: 0x1814BE6C0
	|-Nullable<InstallModOptions>.ToString
	|
	|-RVA: 0x14BE440 Offset: 0x14BD640 VA: 0x1814BE440
	|-Nullable<short>.ToString
	|
	|-RVA: 0x14BD930 Offset: 0x14BCB30 VA: 0x1814BD930
	|-Nullable<Int16Enum>.ToString
	|
	|-RVA: 0x14BE840 Offset: 0x14BDA40 VA: 0x1814BE840
	|-Nullable<int>.ToString
	|
	|-RVA: 0x14BDD20 Offset: 0x14BCF20 VA: 0x1814BDD20
	|-Nullable<Int32Enum>.ToString
	|
	|-RVA: 0x14BCD80 Offset: 0x14BBF80 VA: 0x1814BCD80
	|-Nullable<long>.ToString
	|
	|-RVA: 0x14BF810 Offset: 0x14BEA10 VA: 0x1814BF810
	|-Nullable<IntPtr>.ToString
	|
	|-RVA: 0x14C0580 Offset: 0x14BF780 VA: 0x1814C0580
	|-Nullable<IntegratedPlatformOptionsContainerAddOptions>.ToString
	|
	|-RVA: 0x14BD9E0 Offset: 0x14BCBE0 VA: 0x1814BD9E0
	|-Nullable<InventoryItemCreateSubItemOptions>.ToString
	|
	|-RVA: 0x14BDFC0 Offset: 0x14BD1C0 VA: 0x1814BDFC0
	|-Nullable<InventoryItemDeleteSubItemOptions>.ToString
	|
	|-RVA: 0x14BFEA0 Offset: 0x14BF0A0 VA: 0x1814BFEA0
	|-Nullable<InventoryItemGetDoubleSetValueByIndexOptions>.ToString
	|
	|-RVA: 0x14BDF20 Offset: 0x14BD120 VA: 0x1814BDF20
	|-Nullable<InventoryItemGetInt64SetValueByIndexOptions>.ToString
	|
	|-RVA: 0x14BD730 Offset: 0x14BC930 VA: 0x1814BD730
	|-Nullable<InventoryItemGetKeyOptions>.ToString
	|
	|-RVA: 0x14BF090 Offset: 0x14BE290 VA: 0x1814BF090
	|-Nullable<InventoryItemGetStringSetValueByIndexOptions>.ToString
	|
	|-RVA: 0x14BF890 Offset: 0x14BEA90 VA: 0x1814BF890
	|-Nullable<InventoryItemGetSubItemByIndexOptions>.ToString
	|
	|-RVA: 0x14BF4B0 Offset: 0x14BE6B0 VA: 0x1814BF4B0
	|-Nullable<InventoryItemGetSubItemOptions>.ToString
	|
	|-RVA: 0x14BE3A0 Offset: 0x14BD5A0 VA: 0x1814BE3A0
	|-Nullable<InventoryItemGetSubItemsCountOptions>.ToString
	|
	|-RVA: 0x14BF330 Offset: 0x14BE530 VA: 0x1814BF330
	|-Nullable<InventoryItemGetValueAsBoolOptions>.ToString
	|
	|-RVA: 0x14BDBE0 Offset: 0x14BCDE0 VA: 0x1814BDBE0
	|-Nullable<InventoryItemGetValueAsDoubleOptions>.ToString
	|
	|-RVA: 0x14BF930 Offset: 0x14BEB30 VA: 0x1814BF930
	|-Nullable<InventoryItemGetValueAsInt64Options>.ToString
	|
	|-RVA: 0x14BE1C0 Offset: 0x14BD3C0 VA: 0x1814BE1C0
	|-Nullable<InventoryItemGetValueAsStringOptions>.ToString
	|
	|-RVA: 0x14BE260 Offset: 0x14BD460 VA: 0x1814BE260
	|-Nullable<InventoryItemGetValueAsTimestampOptions>.ToString
	|
	|-RVA: 0x14BE070 Offset: 0x14BD270 VA: 0x1814BE070
	|-Nullable<InventoryItemGetValueCountOptions>.ToString
	|
	|-RVA: 0x14BEDC0 Offset: 0x14BDFC0 VA: 0x1814BEDC0
	|-Nullable<InventoryItemGetValueTypeOptions>.ToString
	|
	|-RVA: 0x14C0630 Offset: 0x14BF830 VA: 0x1814C0630
	|-Nullable<InventoryItemSetKeyOptions>.ToString
	|
	|-RVA: 0x14C06E0 Offset: 0x14BF8E0 VA: 0x1814C06E0
	|-Nullable<InventoryItemSetValueAsBoolOptions>.ToString
	|
	|-RVA: 0x14BD010 Offset: 0x14BC210 VA: 0x1814BD010
	|-Nullable<InventoryItemSetValueAsDoubleOptions>.ToString
	|
	|-RVA: 0x14BE110 Offset: 0x14BD310 VA: 0x1814BE110
	|-Nullable<InventoryItemSetValueAsDoubleSetOptions>.ToString
	|
	|-RVA: 0x14BDE70 Offset: 0x14BD070 VA: 0x1814BDE70
	|-Nullable<InventoryItemSetValueAsInt64Options>.ToString
	|
	|-RVA: 0x14BFB30 Offset: 0x14BED30 VA: 0x1814BFB30
	|-Nullable<InventoryItemSetValueAsInt64SetOptions>.ToString
	|
	|-RVA: 0x14CFA70 Offset: 0x14CEC70 VA: 0x1814CFA70
	|-Nullable<InventoryItemSetValueAsStringOptions>.ToString
	|
	|-RVA: 0x14CC040 Offset: 0x14CB240 VA: 0x1814CC040
	|-Nullable<InventoryItemSetValueAsStringSetOptions>.ToString
	|
	|-RVA: 0x14CF210 Offset: 0x14CE410 VA: 0x1814CF210
	|-Nullable<InventoryItemSetValueAsTimestampOptions>.ToString
	|
	|-RVA: 0x14CD920 Offset: 0x14CCB20 VA: 0x1814CD920
	|-Nullable<IsRTCRoomConnectedOptions>.ToString
	|
	|-RVA: 0x14CD040 Offset: 0x14CC240 VA: 0x1814CD040
	|-Nullable<IsSocialOverlayPausedOptions>.ToString
	|
	|-RVA: 0x14CBB00 Offset: 0x14CAD00 VA: 0x1814CBB00
	|-Nullable<IsUserInSessionOptions>.ToString
	|
	|-RVA: 0x14CE370 Offset: 0x14CD570 VA: 0x1814CE370
	|-Nullable<ItemOwnership>.ToString
	|
	|-RVA: 0x14CC450 Offset: 0x14CB650 VA: 0x1814CC450
	|-Nullable<JoinGameAcceptedCallbackInfo>.ToString
	|
	|-RVA: 0x14CC8B0 Offset: 0x14CBAB0 VA: 0x1814CC8B0
	|-Nullable<JoinLobbyAcceptedCallbackInfo>.ToString
	|
	|-RVA: 0x14CDB20 Offset: 0x14CCD20 VA: 0x1814CDB20
	|-Nullable<JoinLobbyByIdCallbackInfo>.ToString
	|
	|-RVA: 0x14CE9E0 Offset: 0x14CDBE0 VA: 0x1814CE9E0
	|-Nullable<JoinLobbyByIdOptions>.ToString
	|
	|-RVA: 0x14CCD40 Offset: 0x14CBF40 VA: 0x1814CCD40
	|-Nullable<JoinLobbyCallbackInfo>.ToString
	|
	|-RVA: 0x14CC7F0 Offset: 0x14CB9F0 VA: 0x1814CC7F0
	|-Nullable<JoinLobbyOptions>.ToString
	|
	|-RVA: 0x14CDFF0 Offset: 0x14CD1F0 VA: 0x1814CDFF0
	|-Nullable<JoinRoomCallbackInfo>.ToString
	|
	|-RVA: 0x14CEC20 Offset: 0x14CDE20 VA: 0x1814CEC20
	|-Nullable<JoinRoomOptions>.ToString
	|
	|-RVA: 0x14CFE50 Offset: 0x14CF050 VA: 0x1814CFE50
	|-Nullable<JoinSessionAcceptedCallbackInfo>.ToString
	|
	|-RVA: 0x14CCDF0 Offset: 0x14CBFF0 VA: 0x1814CCDF0
	|-Nullable<JoinSessionCallbackInfo>.ToString
	|
	|-RVA: 0x14CF6E0 Offset: 0x14CE8E0 VA: 0x1814CF6E0
	|-Nullable<JoinSessionOptions>.ToString
	|
	|-RVA: 0x14CF190 Offset: 0x14CE390 VA: 0x1814CF190
	|-Nullable<JsonElement>.ToString
	|
	|-RVA: 0x14CC5C0 Offset: 0x14CB7C0 VA: 0x1814CC5C0
	|-Nullable<JsonPosition>.ToString
	|
	|-RVA: 0x14CD650 Offset: 0x14CC850 VA: 0x1814CD650
	|-Nullable<KeyImageInfo>.ToString
	|
	|-RVA: 0x14CD4D0 Offset: 0x14CC6D0 VA: 0x1814CD4D0
	|-Nullable<KeyImageInfoInternal>.ToString
	|
	|-RVA: 0x14CEF90 Offset: 0x14CE190 VA: 0x1814CEF90
	|-Nullable<KickCompleteCallbackInfo>.ToString
	|
	|-RVA: 0x14CDE90 Offset: 0x14CD090 VA: 0x1814CDE90
	|-Nullable<KickMemberCallbackInfo>.ToString
	|
	|-RVA: 0x14CD190 Offset: 0x14CC390 VA: 0x1814CD190
	|-Nullable<KickMemberOptions>.ToString
	|
	|-RVA: 0x14CE0B0 Offset: 0x14CD2B0 VA: 0x1814CE0B0
	|-Nullable<KickOptions>.ToString
	|
	|-RVA: 0x14CE880 Offset: 0x14CDA80 VA: 0x1814CE880
	|-Nullable<LeaderboardRecord>.ToString
	|
	|-RVA: 0x14CF4C0 Offset: 0x14CE6C0 VA: 0x1814CF4C0
	|-Nullable<LeaderboardRecordInternal>.ToString
	|
	|-RVA: 0x14CE160 Offset: 0x14CD360 VA: 0x1814CE160
	|-Nullable<LeaderboardUserScore>.ToString
	|
	|-RVA: 0x14CDDE0 Offset: 0x14CCFE0 VA: 0x1814CDDE0
	|-Nullable<LeaderboardUserScoreInternal>.ToString
	|
	|-RVA: 0x14CCAB0 Offset: 0x14CBCB0 VA: 0x1814CCAB0
	|-Nullable<LeaveLobbyCallbackInfo>.ToString
	|
	|-RVA: 0x14CCC90 Offset: 0x14CBE90 VA: 0x1814CCC90
	|-Nullable<LeaveLobbyOptions>.ToString
	|
	|-RVA: 0x14CF570 Offset: 0x14CE770 VA: 0x1814CF570
	|-Nullable<LeaveLobbyRequestedCallbackInfo>.ToString
	|
	|-RVA: 0x14CF410 Offset: 0x14CE610 VA: 0x1814CF410
	|-Nullable<LeaveRoomCallbackInfo>.ToString
	|
	|-RVA: 0x14CE930 Offset: 0x14CDB30 VA: 0x1814CE930
	|-Nullable<LeaveRoomOptions>.ToString
	|
	|-RVA: 0x14CC510 Offset: 0x14CB710 VA: 0x1814CC510
	|-Nullable<LeaveSessionRequestedCallbackInfo>.ToString
	|
	|-RVA: 0x14CE6F0 Offset: 0x14CD8F0 VA: 0x1814CE6F0
	|-Nullable<LinkAccountCallbackInfo>.ToString
	|
	|-RVA: 0x14CC3A0 Offset: 0x14CB5A0 VA: 0x1814CC3A0
	|-Nullable<LinkAccountCallbackInfo>.ToString
	|
	|-RVA: 0x14CD9D0 Offset: 0x14CCBD0 VA: 0x1814CD9D0
	|-Nullable<LinkAccountOptions>.ToString
	|
	|-RVA: 0x14CCA00 Offset: 0x14CBC00 VA: 0x1814CCA00
	|-Nullable<LinkAccountOptions>.ToString
	|
	|-RVA: 0x14CDA80 Offset: 0x14CCC80 VA: 0x1814CDA80
	|-Nullable<LobbyDetailsCopyAttributeByIndexOptions>.ToString
	|
	|-RVA: 0x14CF0E0 Offset: 0x14CE2E0 VA: 0x1814CF0E0
	|-Nullable<LobbyDetailsCopyAttributeByKeyOptions>.ToString
	|
	|-RVA: 0x14CD430 Offset: 0x14CC630 VA: 0x1814CD430
	|-Nullable<LobbyDetailsCopyInfoOptions>.ToString
	|
	|-RVA: 0x14CF360 Offset: 0x14CE560 VA: 0x1814CF360
	|-Nullable<LobbyDetailsCopyMemberAttributeByIndexOptions>.ToString
	|
	|-RVA: 0x14CE2C0 Offset: 0x14CD4C0 VA: 0x1814CE2C0
	|-Nullable<LobbyDetailsCopyMemberAttributeByKeyOptions>.ToString
	|
	|-RVA: 0x14CEE30 Offset: 0x14CE030 VA: 0x1814CEE30
	|-Nullable<LobbyDetailsCopyMemberInfoOptions>.ToString
	|
	|-RVA: 0x14CFDB0 Offset: 0x14CEFB0 VA: 0x1814CFDB0
	|-Nullable<LobbyDetailsGetAttributeCountOptions>.ToString
	|
	|-RVA: 0x14CF2C0 Offset: 0x14CE4C0 VA: 0x1814CF2C0
	|-Nullable<LobbyDetailsGetLobbyOwnerOptions>.ToString
	|
	|-RVA: 0x14CDD30 Offset: 0x14CCF30 VA: 0x1814CDD30
	|-Nullable<LobbyDetailsGetMemberAttributeCountOptions>.ToString
	|
	|-RVA: 0x14CD240 Offset: 0x14CC440 VA: 0x1814CD240
	|-Nullable<LobbyDetailsGetMemberByIndexOptions>.ToString
	|
	|-RVA: 0x14CCFA0 Offset: 0x14CC1A0 VA: 0x1814CCFA0
	|-Nullable<LobbyDetailsGetMemberCountOptions>.ToString
	|
	|-RVA: 0x14CC670 Offset: 0x14CB870 VA: 0x1814CC670
	|-Nullable<LobbyDetailsInfo>.ToString
	|
	|-RVA: 0x14CFB20 Offset: 0x14CED20 VA: 0x1814CFB20
	|-Nullable<LobbyDetailsInfoInternal>.ToString
	|
	|-RVA: 0x14CBBB0 Offset: 0x14CADB0 VA: 0x1814CBBB0
	|-Nullable<LobbyDetailsMemberInfo>.ToString
	|
	|-RVA: 0x14CDBD0 Offset: 0x14CCDD0 VA: 0x1814CDBD0
	|-Nullable<LobbyDetailsMemberInfoInternal>.ToString
	|
	|-RVA: 0x14CF620 Offset: 0x14CE820 VA: 0x1814CF620
	|-Nullable<LobbyInviteAcceptedCallbackInfo>.ToString
	|
	|-RVA: 0x14CEAA0 Offset: 0x14CDCA0 VA: 0x1814CEAA0
	|-Nullable<LobbyInviteReceivedCallbackInfo>.ToString
	|
	|-RVA: 0x14CD700 Offset: 0x14CC900 VA: 0x1814CD700
	|-Nullable<LobbyInviteRejectedCallbackInfo>.ToString
	|
	|-RVA: 0x14CBC60 Offset: 0x14CAE60 VA: 0x1814CBC60
	|-Nullable<LobbyMemberStatusReceivedCallbackInfo>.ToString
	|
	|-RVA: 0x14CC2F0 Offset: 0x14CB4F0 VA: 0x1814CC2F0
	|-Nullable<LobbyMemberUpdateReceivedCallbackInfo>.ToString
	|
	|-RVA: 0x14CFCD0 Offset: 0x14CEED0 VA: 0x1814CFCD0
	|-Nullable<LobbyModificationAddAttributeOptions>.ToString
	|
	|-RVA: 0x14CFF00 Offset: 0x14CF100 VA: 0x1814CFF00
	|-Nullable<LobbyModificationAddMemberAttributeOptions>.ToString
	|
	|-RVA: 0x14CEEE0 Offset: 0x14CE0E0 VA: 0x1814CEEE0
	|-Nullable<LobbyModificationRemoveAttributeOptions>.ToString
	|
	|-RVA: 0x14CBD10 Offset: 0x14CAF10 VA: 0x1814CBD10
	|-Nullable<LobbyModificationRemoveMemberAttributeOptions>.ToString
	|
	|-RVA: 0x14CD2E0 Offset: 0x14CC4E0 VA: 0x1814CD2E0
	|-Nullable<LobbyModificationSetAllowedPlatformIdsOptions>.ToString
	|
	|-RVA: 0x14CFFE0 Offset: 0x14CF1E0 VA: 0x1814CFFE0
	|-Nullable<LobbyModificationSetBucketIdOptions>.ToString
	|
	|-RVA: 0x14CC1A0 Offset: 0x14CB3A0 VA: 0x1814CC1A0
	|-Nullable<LobbyModificationSetInvitesAllowedOptions>.ToString
	|
	|-RVA: 0x14CF040 Offset: 0x14CE240 VA: 0x1814CF040
	|-Nullable<LobbyModificationSetMaxMembersOptions>.ToString
	|
	|-RVA: 0x14CE420 Offset: 0x14CD620 VA: 0x1814CE420
	|-Nullable<LobbyModificationSetPermissionLevelOptions>.ToString
	|
	|-RVA: 0x14CF920 Offset: 0x14CEB20 VA: 0x1814CF920
	|-Nullable<LobbySearchCopySearchResultByIndexOptions>.ToString
	|
	|-RVA: 0x14CE7D0 Offset: 0x14CD9D0 VA: 0x1814CE7D0
	|-Nullable<LobbySearchFindCallbackInfo>.ToString
	|
	|-RVA: 0x14CF9C0 Offset: 0x14CEBC0 VA: 0x1814CF9C0
	|-Nullable<LobbySearchFindOptions>.ToString
	|
	|-RVA: 0x14CECE0 Offset: 0x14CDEE0 VA: 0x1814CECE0
	|-Nullable<LobbySearchGetSearchResultCountOptions>.ToString
	|
	|-RVA: 0x14CDC80 Offset: 0x14CCE80 VA: 0x1814CDC80
	|-Nullable<LobbySearchRemoveParameterOptions>.ToString
	|
	|-RVA: 0x14CC740 Offset: 0x14CB940 VA: 0x1814CC740
	|-Nullable<LobbySearchSetLobbyIdOptions>.ToString
	|
	|-RVA: 0x14CC960 Offset: 0x14CBB60 VA: 0x1814CC960
	|-Nullable<LobbySearchSetMaxResultsOptions>.ToString
	|
	|-RVA: 0x14CBF60 Offset: 0x14CB160 VA: 0x1814CBF60
	|-Nullable<LobbySearchSetParameterOptions>.ToString
	|
	|-RVA: 0x14CE4C0 Offset: 0x14CD6C0 VA: 0x1814CE4C0
	|-Nullable<LobbySearchSetTargetUserIdOptions>.ToString
	|
	|-RVA: 0x14CE210 Offset: 0x14CD410 VA: 0x1814CE210
	|-Nullable<LobbyUpdateReceivedCallbackInfo>.ToString
	|
	|-RVA: 0x14CC0F0 Offset: 0x14CB2F0 VA: 0x1814CC0F0
	|-Nullable<LocalDefinition>.ToString
	|
	|-RVA: 0x14CD870 Offset: 0x14CCA70 VA: 0x1814CD870
	|-Nullable<LocalRTCOptions>.ToString
	|
	|-RVA: 0x14CBEB0 Offset: 0x14CB0B0 VA: 0x1814CBEB0
	|-Nullable<LogEventOptions>.ToString
	|
	|-RVA: 0x14D0090 Offset: 0x14CF290 VA: 0x1814D0090
	|-Nullable<LogEventParamPair>.ToString
	|
	|-RVA: 0x14CCEA0 Offset: 0x14CC0A0 VA: 0x1814CCEA0
	|-Nullable<LogEventParamPairParamValue>.ToString
	|
	|-RVA: 0x14CD390 Offset: 0x14CC590 VA: 0x1814CD390
	|-Nullable<LogGameRoundEndOptions>.ToString
	|
	|-RVA: 0x14CC240 Offset: 0x14CB440 VA: 0x1814CC240
	|-Nullable<LogGameRoundStartOptions>.ToString
	|
	|-RVA: 0x14CE640 Offset: 0x14CD840 VA: 0x1814CE640
	|-Nullable<LogMessage>.ToString
	|
	|-RVA: 0x14CD7C0 Offset: 0x14CC9C0 VA: 0x1814CD7C0
	|-Nullable<LogPlayerDespawnOptions>.ToString
	|
	|-RVA: 0x14CDF40 Offset: 0x14CD140 VA: 0x1814CDF40
	|-Nullable<LogPlayerReviveOptions>.ToString
	|
	|-RVA: 0x14CF870 Offset: 0x14CEA70 VA: 0x1814CF870
	|-Nullable<LogPlayerSpawnOptions>.ToString
	|
	|-RVA: 0x14CCB60 Offset: 0x14CBD60 VA: 0x1814CCB60
	|-Nullable<LogPlayerTakeDamageOptions>.ToString
	|
	|-RVA: 0x14CF790 Offset: 0x14CE990 VA: 0x1814CF790
	|-Nullable<LogPlayerTickOptions>.ToString
	|
	|-RVA: 0x14CED80 Offset: 0x14CDF80 VA: 0x1814CED80
	|-Nullable<LogPlayerUseAbilityOptions>.ToString
	|
	|-RVA: 0x14CE570 Offset: 0x14CD770 VA: 0x1814CE570
	|-Nullable<LogPlayerUseWeaponData>.ToString
	|
	|-RVA: 0x14CEB50 Offset: 0x14CDD50 VA: 0x1814CEB50
	|-Nullable<LogPlayerUseWeaponOptions>.ToString
	|
	|-RVA: 0x14CBDC0 Offset: 0x14CAFC0 VA: 0x1814CBDC0
	|-Nullable<LoginCallbackInfo>.ToString
	|
	|-RVA: 0x14CD0E0 Offset: 0x14CC2E0 VA: 0x1814CD0E0
	|-Nullable<LoginCallbackInfo>.ToString
	|
	|-RVA: 0x14CD580 Offset: 0x14CC780 VA: 0x1814CD580
	|-Nullable<LoginOptions>.ToString
	|
	|-RVA: 0x14CFC10 Offset: 0x14CEE10 VA: 0x1814CFC10
	|-Nullable<LoginOptions>.ToString
	|
	|-RVA: 0x14DF880 Offset: 0x14DEA80 VA: 0x1814DF880
	|-Nullable<LoginStatusChangedCallbackInfo>.ToString
	|
	|-RVA: 0x14DC6E0 Offset: 0x14DB8E0 VA: 0x1814DC6E0
	|-Nullable<LoginStatusChangedCallbackInfo>.ToString
	|
	|-RVA: 0x14DFA90 Offset: 0x14DEC90 VA: 0x1814DFA90
	|-Nullable<LogoutCallbackInfo>.ToString
	|
	|-RVA: 0x14DD0D0 Offset: 0x14DC2D0 VA: 0x1814DD0D0
	|-Nullable<LogoutCallbackInfo>.ToString
	|
	|-RVA: 0x14DF680 Offset: 0x14DE880 VA: 0x1814DF680
	|-Nullable<LogoutOptions>.ToString
	|
	|-RVA: 0x14E01E0 Offset: 0x14DF3E0 VA: 0x1814E01E0
	|-Nullable<LogoutOptions>.ToString
	|
	|-RVA: 0x14DD550 Offset: 0x14DC750 VA: 0x1814DD550
	|-Nullable<MemoryMonitorCallbackInfo>.ToString
	|
	|-RVA: 0x14DE0A0 Offset: 0x14DD2A0 VA: 0x1814DE0A0
	|-Nullable<ModIdentifier>.ToString
	|
	|-RVA: 0x14DCEB0 Offset: 0x14DC0B0 VA: 0x1814DCEB0
	|-Nullable<ModIdentifierInternal>.ToString
	|
	|-RVA: 0x14DD600 Offset: 0x14DC800 VA: 0x1814DD600
	|-Nullable<ModInfo>.ToString
	|
	|-RVA: 0x14DE910 Offset: 0x14DDB10 VA: 0x1814DE910
	|-Nullable<ModInfoInternal>.ToString
	|
	|-RVA: 0x14DEB20 Offset: 0x14DDD20 VA: 0x1814DEB20
	|-Nullable<OnAchievementsUnlockedCallbackInfo>.ToString
	|
	|-RVA: 0x14DC790 Offset: 0x14DB990 VA: 0x1814DC790
	|-Nullable<OnAchievementsUnlockedCallbackV2Info>.ToString
	|
	|-RVA: 0x14DE630 Offset: 0x14DD830 VA: 0x1814DE630
	|-Nullable<OnBlockedUsersUpdateInfo>.ToString
	|
	|-RVA: 0x14DC2F0 Offset: 0x14DB4F0 VA: 0x1814DC2F0
	|-Nullable<OnCheckpointCompleteCallbackInfo>.ToString
	|
	|-RVA: 0x14DDF40 Offset: 0x14DD140 VA: 0x1814DDF40
	|-Nullable<OnClientActionRequiredCallbackInfo>.ToString
	|
	|-RVA: 0x14DDDD0 Offset: 0x14DCFD0 VA: 0x1814DDDD0
	|-Nullable<OnClientAuthStatusChangedCallbackInfo>.ToString
	|
	|-RVA: 0x14DE3E0 Offset: 0x14DD5E0 VA: 0x1814DE3E0
	|-Nullable<OnClientIntegrityViolatedCallbackInfo>.ToString
	|
	|-RVA: 0x14DEA70 Offset: 0x14DDC70 VA: 0x1814DEA70
	|-Nullable<OnCloseCompleteCallbackInfo>.ToString
	|
	|-RVA: 0x14DFB40 Offset: 0x14DED40 VA: 0x1814DFB40
	|-Nullable<OnCreateCompleteCallbackInfo>.ToString
	|
	|-RVA: 0x14DF430 Offset: 0x14DE630 VA: 0x1814DF430
	|-Nullable<OnCustomInviteAcceptedCallbackInfo>.ToString
	|
	|-RVA: 0x14DF160 Offset: 0x14DE360 VA: 0x1814DF160
	|-Nullable<OnCustomInviteReceivedCallbackInfo>.ToString
	|
	|-RVA: 0x14E0290 Offset: 0x14DF490 VA: 0x1814E0290
	|-Nullable<OnDisplaySettingsUpdatedCallbackInfo>.ToString
	|
	|-RVA: 0x14DF0B0 Offset: 0x14DE2B0 VA: 0x1814DF0B0
	|-Nullable<OnFriendsUpdateInfo>.ToString
	|
	|-RVA: 0x14DCDE0 Offset: 0x14DBFE0 VA: 0x1814DCDE0
	|-Nullable<OnIncomingConnectionRequestInfo>.ToString
	|
	|-RVA: 0x14DF5C0 Offset: 0x14DE7C0 VA: 0x1814DF5C0
	|-Nullable<OnIncomingPacketQueueFullInfo>.ToString
	|
	|-RVA: 0x14DC9B0 Offset: 0x14DBBB0 VA: 0x1814DC9B0
	|-Nullable<OnMessageToClientCallbackInfo>.ToString
	|
	|-RVA: 0x14E0080 Offset: 0x14DF280 VA: 0x1814E0080
	|-Nullable<OnMessageToServerCallbackInfo>.ToString
	|
	|-RVA: 0x14DC630 Offset: 0x14DB830 VA: 0x1814DC630
	|-Nullable<OnOpenCompleteCallbackInfo>.ToString
	|
	|-RVA: 0x14DD230 Offset: 0x14DC430 VA: 0x1814DD230
	|-Nullable<OnPeerConnectionEstablishedInfo>.ToString
	|
	|-RVA: 0x14DE560 Offset: 0x14DD760 VA: 0x1814DE560
	|-Nullable<OnPeerConnectionInterruptedInfo>.ToString
	|
	|-RVA: 0x14DE6E0 Offset: 0x14DD8E0 VA: 0x1814DE6E0
	|-Nullable<OnQueryDefinitionsCompleteCallbackInfo>.ToString
	|
	|-RVA: 0x14E0820 Offset: 0x14DFA20 VA: 0x1814E0820
	|-Nullable<OnQueryInputDevicesInformationCallbackInfo>.ToString
	|
	|-RVA: 0x14DC450 Offset: 0x14DB650 VA: 0x1814DC450
	|-Nullable<OnQueryLeaderboardDefinitionsCompleteCallbackInfo>.ToString
	|
	|-RVA: 0x14DFE20 Offset: 0x14DF020 VA: 0x1814DFE20
	|-Nullable<OnQueryLeaderboardRanksCompleteCallbackInfo>.ToString
	|
	|-RVA: 0x14E0550 Offset: 0x14DF750 VA: 0x1814E0550
	|-Nullable<OnQueryLeaderboardUserScoresCompleteCallbackInfo>.ToString
	|
	|-RVA: 0x14E0770 Offset: 0x14DF970 VA: 0x1814E0770
	|-Nullable<OnQueryNATTypeCompleteInfo>.ToString
	|
	|-RVA: 0x14DF220 Offset: 0x14DE420 VA: 0x1814DF220
	|-Nullable<OnQueryOutputDevicesInformationCallbackInfo>.ToString
	|
	|-RVA: 0x14DD780 Offset: 0x14DC980 VA: 0x1814DD780
	|-Nullable<OnQueryPlayerAchievementsCompleteCallbackInfo>.ToString
	|
	|-RVA: 0x14DCC80 Offset: 0x14DBE80 VA: 0x1814DCC80
	|-Nullable<OnQueryStatsCompleteCallbackInfo>.ToString
	|
	|-RVA: 0x14DCBD0 Offset: 0x14DBDD0 VA: 0x1814DCBD0
	|-Nullable<OnRegisterPlatformUserCallbackInfo>.ToString
	|
	|-RVA: 0x14E08D0 Offset: 0x14DFAD0 VA: 0x1814E08D0
	|-Nullable<OnRemoteConnectionClosedInfo>.ToString
	|
	|-RVA: 0x14E04A0 Offset: 0x14DF6A0 VA: 0x1814E04A0
	|-Nullable<OnRequestToJoinAcceptedCallbackInfo>.ToString
	|
	|-RVA: 0x14DDD20 Offset: 0x14DCF20 VA: 0x1814DDD20
	|-Nullable<OnRequestToJoinRejectedCallbackInfo>.ToString
	|
	|-RVA: 0x14DCF70 Offset: 0x14DC170 VA: 0x1814DCF70
	|-Nullable<OnSetInputDeviceSettingsCallbackInfo>.ToString
	|
	|-RVA: 0x14DC900 Offset: 0x14DBB00 VA: 0x1814DC900
	|-Nullable<OnSetOutputDeviceSettingsCallbackInfo>.ToString
	|
	|-RVA: 0x14DF2D0 Offset: 0x14DE4D0 VA: 0x1814DF2D0
	|-Nullable<OnShowBlockPlayerCallbackInfo>.ToString
	|
	|-RVA: 0x14DE330 Offset: 0x14DD530 VA: 0x1814DE330
	|-Nullable<OnShowReportPlayerCallbackInfo>.ToString
	|
	|-RVA: 0x14DEBD0 Offset: 0x14DDDD0 VA: 0x1814DEBD0
	|-Nullable<OnUnlockAchievementsCompleteCallbackInfo>.ToString
	|
	|-RVA: 0x14DCD30 Offset: 0x14DBF30 VA: 0x1814DCD30
	|-Nullable<OnUnregisterPlatformUserCallbackInfo>.ToString
	|
	|-RVA: 0x14DEF30 Offset: 0x14DE130 VA: 0x1814DEF30
	|-Nullable<OpenOptions>.ToString
	|
	|-RVA: 0x14DF9E0 Offset: 0x14DEBE0 VA: 0x1814DF9E0
	|-Nullable<Option>.ToString
	|
	|-RVA: 0x14DCB20 Offset: 0x14DBD20 VA: 0x1814DCB20
	|-Nullable<Options>.ToString
	|
	|-RVA: 0x14DE220 Offset: 0x14DD420 VA: 0x1814DE220
	|-Nullable<Options>.ToString
	|
	|-RVA: 0x14DDB10 Offset: 0x14DCD10 VA: 0x1814DDB10
	|-Nullable<OutputDeviceInformation>.ToString
	|
	|-RVA: 0x14E09B0 Offset: 0x14DFBB0 VA: 0x1814E09B0
	|-Nullable<OutputDeviceInformationInternal>.ToString
	|
	|-RVA: 0x14DD480 Offset: 0x14DC680 VA: 0x1814DD480
	|-Nullable<PS4DLCVerifyPurchaseOptions>.ToString
	|
	|-RVA: 0x14E03F0 Offset: 0x14DF5F0 VA: 0x1814E03F0
	|-Nullable<PS4DLCVerifyPurchaseOptionsPlatformSpecificOptions>.ToString
	|
	|-RVA: 0x14DFED0 Offset: 0x14DF0D0 VA: 0x1814DFED0
	|-Nullable<PS4IAPVerifyPurchaseOptions>.ToString
	|
	|-RVA: 0x14DF380 Offset: 0x14DE580 VA: 0x1814DF380
	|-Nullable<PS4IAPVerifyPurchaseOptionsPlatformSpecificOptions>.ToString
	|
	|-RVA: 0x14DC500 Offset: 0x14DB700 VA: 0x1814DC500
	|-Nullable<PS4InitializeOptions>.ToString
	|
	|-RVA: 0x14DFFA0 Offset: 0x14DF1A0 VA: 0x1814DFFA0
	|-Nullable<PS4InitializeOptionsSystemInitializeOptions>.ToString
	|
	|-RVA: 0x14DE490 Offset: 0x14DD690 VA: 0x1814DE490
	|-Nullable<PS4IntegratedPlatformOptionsContainerAddOptions>.ToString
	|
	|-RVA: 0x14E0130 Offset: 0x14DF330 VA: 0x1814E0130
	|-Nullable<PS4MemoryMonitorCallbackInfo>.ToString
	|
	|-RVA: 0x14DF7D0 Offset: 0x14DE9D0 VA: 0x1814DF7D0
	|-Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReport>.ToString
	|
	|-RVA: 0x14E0600 Offset: 0x14DF800 VA: 0x1814E0600
	|-Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.ToString
	|
	|-RVA: 0x14DDE80 Offset: 0x14DD080 VA: 0x1814DDE80
	|-Nullable<PS4Options>.ToString
	|
	|-RVA: 0x14DDC70 Offset: 0x14DCE70 VA: 0x1814DDC70
	|-Nullable<PS4OptionsInitOptions>.ToString
	|
	|-RVA: 0x14DDBC0 Offset: 0x14DCDC0 VA: 0x1814DDBC0
	|-Nullable<PS4OptionsInitOptionsInternal>.ToString
	|
	|-RVA: 0x14DE840 Offset: 0x14DDA40 VA: 0x1814DE840
	|-Nullable<PS4PrePresentOptions>.ToString
	|
	|-RVA: 0x14DE160 Offset: 0x14DD360 VA: 0x1814DE160
	|-Nullable<PS4PrePresentOptionsPlatformSpecificData>.ToString
	|
	|-RVA: 0x14DCA60 Offset: 0x14DBC60 VA: 0x1814DCA60
	|-Nullable<PS4SubmitGraphicsCommandsCallbackInfo>.ToString
	|
	|-RVA: 0x14DEE60 Offset: 0x14DE060 VA: 0x1814DEE60
	|-Nullable<PS5DLCVerifyPurchaseOptions>.ToString
	|
	|-RVA: 0x14DD3D0 Offset: 0x14DC5D0 VA: 0x1814DD3D0
	|-Nullable<PS5DLCVerifyPurchaseOptionsPlatformSpecificOptions>.ToString
	|
	|-RVA: 0x14DEFE0 Offset: 0x14DE1E0 VA: 0x1814DEFE0
	|-Nullable<PS5IAPVerifyPurchaseOptions>.ToString
	|
	|-RVA: 0x14E0340 Offset: 0x14DF540 VA: 0x1814E0340
	|-Nullable<PS5IAPVerifyPurchaseOptionsPlatformSpecificOptions>.ToString
	|
	|-RVA: 0x14DED30 Offset: 0x14DDF30 VA: 0x1814DED30
	|-Nullable<PS5InitializeOptions>.ToString
	|
	|-RVA: 0x14DFCA0 Offset: 0x14DEEA0 VA: 0x1814DFCA0
	|-Nullable<PS5InitializeOptionsSystemInitializeOptions>.ToString
	|
	|-RVA: 0x14DC850 Offset: 0x14DBA50 VA: 0x1814DC850
	|-Nullable<PS5IntegratedPlatformOptionsContainerAddOptions>.ToString
	|
	|-RVA: 0x14DD180 Offset: 0x14DC380 VA: 0x1814DD180
	|-Nullable<PS5MemoryMonitorCallbackInfo>.ToString
	|
	|-RVA: 0x14DC240 Offset: 0x14DB440 VA: 0x1814DC240
	|-Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReport>.ToString
	|
	|-RVA: 0x14DF930 Offset: 0x14DEB30 VA: 0x1814DF930
	|-Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.ToString
	|
	|-RVA: 0x14DD830 Offset: 0x14DCA30 VA: 0x1814DD830
	|-Nullable<PS5Options>.ToString
	|
	|-RVA: 0x14DF730 Offset: 0x14DE930 VA: 0x1814DF730
	|-Nullable<PS5OptionsInitOptions>.ToString
	|
	|-RVA: 0x14DE790 Offset: 0x14DD990 VA: 0x1814DE790
	|-Nullable<PS5OptionsInitOptionsInternal>.ToString
	|
	|-RVA: 0x14DD6B0 Offset: 0x14DC8B0 VA: 0x1814DD6B0
	|-Nullable<PS5PrePresentOptions>.ToString
	|
	|-RVA: 0x14DD9A0 Offset: 0x14DCBA0 VA: 0x1814DD9A0
	|-Nullable<PS5PrePresentOptionsPlatformSpecificData>.ToString
	|
	|-RVA: 0x14DDFF0 Offset: 0x14DD1F0 VA: 0x1814DDFF0
	|-Nullable<PS5SubmitGraphicsCommandsCallbackInfo>.ToString
	|
	|-RVA: 0x14DD8E0 Offset: 0x14DCAE0 VA: 0x1814DD8E0
	|-Nullable<PacketQueueInfo>.ToString
	|
	|-RVA: 0x14DEC80 Offset: 0x14DDE80 VA: 0x1814DEC80
	|-Nullable<PageQuery>.ToString
	|
	|-RVA: 0x14DDA60 Offset: 0x14DCC60 VA: 0x1814DDA60
	|-Nullable<PageResult>.ToString
	|
	|-RVA: 0x14DD020 Offset: 0x14DC220 VA: 0x1814DD020
	|-Nullable<ParseConnectStringOptions>.ToString
	|
	|-RVA: 0x14DC3A0 Offset: 0x14DB5A0 VA: 0x1814DC3A0
	|-Nullable<ParticipantMetadata>.ToString
	|
	|-RVA: 0x14DF4F0 Offset: 0x14DE6F0 VA: 0x1814DF4F0
	|-Nullable<ParticipantStatusChangedCallbackInfo>.ToString
	|
	|-RVA: 0x14DD310 Offset: 0x14DC510 VA: 0x1814DD310
	|-Nullable<ParticipantUpdatedCallbackInfo>.ToString
	|
	|-RVA: 0x14E06B0 Offset: 0x14DF8B0 VA: 0x1814E06B0
	|-Nullable<ParticipantUpdatedCallbackInfo>.ToString
	|
	|-RVA: 0x14DFD80 Offset: 0x14DEF80 VA: 0x1814DFD80
	|-Nullable<PauseSocialOverlayOptions>.ToString
	|
	|-RVA: 0x14DE9C0 Offset: 0x14DDBC0 VA: 0x1814DE9C0
	|-Nullable<PermissionStatus>.ToString
	|
	|-RVA: 0x14DFBF0 Offset: 0x14DEDF0 VA: 0x1814DFBF0
	|-Nullable<PermissionStatusInternal>.ToString
	|
	|-RVA: 0x14ED0C0 Offset: 0x14EC2C0 VA: 0x1814ED0C0
	|-Nullable<PermissionsUpdateReceivedCallbackInfo>.ToString
	|
	|-RVA: 0x14EF580 Offset: 0x14EE780 VA: 0x1814EF580
	|-Nullable<PinGrantInfo>.ToString
	|
	|-RVA: 0x14ECDF0 Offset: 0x14EBFF0 VA: 0x1814ECDF0
	|-Nullable<PinGrantInfoInternal>.ToString
	|
	|-RVA: 0x14ED890 Offset: 0x14ECA90 VA: 0x1814ED890
	|-Nullable<PlayerAchievement>.ToString
	|
	|-RVA: 0x14EDE40 Offset: 0x14ED040 VA: 0x1814EDE40
	|-Nullable<PlayerAchievementInternal>.ToString
	|
	|-RVA: 0x14EE130 Offset: 0x14ED330 VA: 0x1814EE130
	|-Nullable<PlayerSanction>.ToString
	|
	|-RVA: 0x14EFF40 Offset: 0x14EF140 VA: 0x1814EFF40
	|-Nullable<PlayerSanctionInternal>.ToString
	|
	|-RVA: 0x14EDB90 Offset: 0x14ECD90 VA: 0x1814EDB90
	|-Nullable<PlayerStatInfo>.ToString
	|
	|-RVA: 0x14F0930 Offset: 0x14EFB30 VA: 0x1814F0930
	|-Nullable<PollStatusOptions>.ToString
	|
	|-RVA: 0x14ECA90 Offset: 0x14EBC90 VA: 0x1814ECA90
	|-Nullable<PrePresentOptions>.ToString
	|
	|-RVA: 0x14F03A0 Offset: 0x14EF5A0 VA: 0x1814F03A0
	|-Nullable<PresenceChangedCallbackInfo>.ToString
	|
	|-RVA: 0x14F0A80 Offset: 0x14EFC80 VA: 0x1814F0A80
	|-Nullable<PresenceModificationDataRecordId>.ToString
	|
	|-RVA: 0x14EE4C0 Offset: 0x14ED6C0 VA: 0x1814EE4C0
	|-Nullable<PresenceModificationDeleteDataOptions>.ToString
	|
	|-RVA: 0x14EF630 Offset: 0x14EE830 VA: 0x1814EF630
	|-Nullable<PresenceModificationSetDataOptions>.ToString
	|
	|-RVA: 0x14EDA20 Offset: 0x14ECC20 VA: 0x1814EDA20
	|-Nullable<PresenceModificationSetJoinInfoOptions>.ToString
	|
	|-RVA: 0x14EEF20 Offset: 0x14EE120 VA: 0x1814EEF20
	|-Nullable<PresenceModificationSetRawRichTextOptions>.ToString
	|
	|-RVA: 0x14EDCF0 Offset: 0x14ECEF0 VA: 0x1814EDCF0
	|-Nullable<PresenceModificationSetStatusOptions>.ToString
	|
	|-RVA: 0x14F0500 Offset: 0x14EF700 VA: 0x1814F0500
	|-Nullable<PromoteMemberCallbackInfo>.ToString
	|
	|-RVA: 0x14F02F0 Offset: 0x14EF4F0 VA: 0x1814F02F0
	|-Nullable<PromoteMemberOptions>.ToString
	|
	|-RVA: 0x14F0E90 Offset: 0x14F0090 VA: 0x1814F0E90
	|-Nullable<ProtectMessageOptions>.ToString
	|
	|-RVA: 0x14EF8F0 Offset: 0x14EEAF0 VA: 0x1814EF8F0
	|-Nullable<ProtectMessageOptions>.ToString
	|
	|-RVA: 0x14EE1E0 Offset: 0x14ED3E0 VA: 0x1814EE1E0
	|-Nullable<Quat>.ToString
	|
	|-RVA: 0x14EE340 Offset: 0x14ED540 VA: 0x1814EE340
	|-Nullable<QuatInternal>.ToString
	|
	|-RVA: 0x14EE790 Offset: 0x14ED990 VA: 0x1814EE790
	|-Nullable<QueryActivePlayerSanctionsCallbackInfo>.ToString
	|
	|-RVA: 0x14EEB00 Offset: 0x14EDD00 VA: 0x1814EEB00
	|-Nullable<QueryActivePlayerSanctionsOptions>.ToString
	|
	|-RVA: 0x14F0D30 Offset: 0x14EFF30 VA: 0x1814F0D30
	|-Nullable<QueryAgeGateCallbackInfo>.ToString
	|
	|-RVA: 0x14EFBB0 Offset: 0x14EEDB0 VA: 0x1814EFBB0
	|-Nullable<QueryAgeGateOptions>.ToString
	|
	|-RVA: 0x14EDC40 Offset: 0x14ECE40 VA: 0x1814EDC40
	|-Nullable<QueryDefinitionsOptions>.ToString
	|
	|-RVA: 0x14EFB00 Offset: 0x14EED00 VA: 0x1814EFB00
	|-Nullable<QueryEntitlementTokenCallbackInfo>.ToString
	|
	|-RVA: 0x14ED390 Offset: 0x14EC590 VA: 0x1814ED390
	|-Nullable<QueryEntitlementTokenOptions>.ToString
	|
	|-RVA: 0x14ED5D0 Offset: 0x14EC7D0 VA: 0x1814ED5D0
	|-Nullable<QueryEntitlementsCallbackInfo>.ToString
	|
	|-RVA: 0x14EF790 Offset: 0x14EE990 VA: 0x1814EF790
	|-Nullable<QueryEntitlementsOptions>.ToString
	|
	|-RVA: 0x14EDD90 Offset: 0x14ECF90 VA: 0x1814EDD90
	|-Nullable<QueryExternalAccountMappingsCallbackInfo>.ToString
	|
	|-RVA: 0x14ECEB0 Offset: 0x14EC0B0 VA: 0x1814ECEB0
	|-Nullable<QueryExternalAccountMappingsOptions>.ToString
	|
	|-RVA: 0x14EE570 Offset: 0x14ED770 VA: 0x1814EE570
	|-Nullable<QueryFileCallbackInfo>.ToString
	|
	|-RVA: 0x14EF6E0 Offset: 0x14EE8E0 VA: 0x1814EF6E0
	|-Nullable<QueryFileCallbackInfo>.ToString
	|
	|-RVA: 0x14EF420 Offset: 0x14EE620 VA: 0x1814EF420
	|-Nullable<QueryFileListCallbackInfo>.ToString
	|
	|-RVA: 0x14ED440 Offset: 0x14EC640 VA: 0x1814ED440
	|-Nullable<QueryFileListCallbackInfo>.ToString
	|
	|-RVA: 0x14F0DE0 Offset: 0x14EFFE0 VA: 0x1814F0DE0
	|-Nullable<QueryFileListOptions>.ToString
	|
	|-RVA: 0x14F0450 Offset: 0x14EF650 VA: 0x1814F0450
	|-Nullable<QueryFileListOptions>.ToString
	|
	|-RVA: 0x14EFDE0 Offset: 0x14EEFE0 VA: 0x1814EFDE0
	|-Nullable<QueryFileOptions>.ToString
	|
	|-RVA: 0x14F0F40 Offset: 0x14F0140 VA: 0x1814F0F40
	|-Nullable<QueryFileOptions>.ToString
	|
	|-RVA: 0x14F05B0 Offset: 0x14EF7B0 VA: 0x1814F05B0
	|-Nullable<QueryFriendsCallbackInfo>.ToString
	|
	|-RVA: 0x14ED010 Offset: 0x14EC210 VA: 0x1814ED010
	|-Nullable<QueryFriendsOptions>.ToString
	|
	|-RVA: 0x14EE290 Offset: 0x14ED490 VA: 0x1814EE290
	|-Nullable<QueryIdTokenCallbackInfo>.ToString
	|
	|-RVA: 0x14F0710 Offset: 0x14EF910 VA: 0x1814F0710
	|-Nullable<QueryIdTokenOptions>.ToString
	|
	|-RVA: 0x14ECBF0 Offset: 0x14EBDF0 VA: 0x1814ECBF0
	|-Nullable<QueryInputDevicesInformationOptions>.ToString
	|
	|-RVA: 0x14EEBB0 Offset: 0x14EDDB0 VA: 0x1814EEBB0
	|-Nullable<QueryInvitesCallbackInfo>.ToString
	|
	|-RVA: 0x14ED7E0 Offset: 0x14EC9E0 VA: 0x1814ED7E0
	|-Nullable<QueryInvitesCallbackInfo>.ToString
	|
	|-RVA: 0x14EE840 Offset: 0x14EDA40 VA: 0x1814EE840
	|-Nullable<QueryInvitesOptions>.ToString
	|
	|-RVA: 0x14F0C80 Offset: 0x14EFE80 VA: 0x1814F0C80
	|-Nullable<QueryInvitesOptions>.ToString
	|
	|-RVA: 0x14F0170 Offset: 0x14EF370 VA: 0x1814F0170
	|-Nullable<QueryJoinRoomTokenCompleteCallbackInfo>.ToString
	|
	|-RVA: 0x14EDFD0 Offset: 0x14ED1D0 VA: 0x1814EDFD0
	|-Nullable<QueryJoinRoomTokenOptions>.ToString
	|
	|-RVA: 0x14EF1E0 Offset: 0x14EE3E0 VA: 0x1814EF1E0
	|-Nullable<QueryLeaderboardDefinitionsOptions>.ToString
	|
	|-RVA: 0x14EF840 Offset: 0x14EEA40 VA: 0x1814EF840
	|-Nullable<QueryLeaderboardRanksOptions>.ToString
	|
	|-RVA: 0x14ED4F0 Offset: 0x14EC6F0 VA: 0x1814ED4F0
	|-Nullable<QueryLeaderboardUserScoresOptions>.ToString
	|
	|-RVA: 0x14F0B30 Offset: 0x14EFD30 VA: 0x1814F0B30
	|-Nullable<QueryNATTypeOptions>.ToString
	|
	|-RVA: 0x14ED2E0 Offset: 0x14EC4E0 VA: 0x1814ED2E0
	|-Nullable<QueryOffersCallbackInfo>.ToString
	|
	|-RVA: 0x14EEFD0 Offset: 0x14EE1D0 VA: 0x1814EEFD0
	|-Nullable<QueryOffersOptions>.ToString
	|
	|-RVA: 0x14EEC60 Offset: 0x14EDE60 VA: 0x1814EEC60
	|-Nullable<QueryOutputDevicesInformationOptions>.ToString
	|
	|-RVA: 0x14EF4D0 Offset: 0x14EE6D0 VA: 0x1814EF4D0
	|-Nullable<QueryOwnershipBySandboxIdsCallbackInfo>.ToString
	|
	|-RVA: 0x14ED970 Offset: 0x14ECB70 VA: 0x1814ED970
	|-Nullable<QueryOwnershipBySandboxIdsOptions>.ToString
	|
	|-RVA: 0x14F0880 Offset: 0x14EFA80 VA: 0x1814F0880
	|-Nullable<QueryOwnershipCallbackInfo>.ToString
	|
	|-RVA: 0x14EF9A0 Offset: 0x14EEBA0 VA: 0x1814EF9A0
	|-Nullable<QueryOwnershipOptions>.ToString
	|
	|-RVA: 0x14EFE90 Offset: 0x14EF090 VA: 0x1814EFE90
	|-Nullable<QueryOwnershipTokenCallbackInfo>.ToString
	|
	|-RVA: 0x14ECC90 Offset: 0x14EBE90 VA: 0x1814ECC90
	|-Nullable<QueryOwnershipTokenOptions>.ToString
	|
	|-RVA: 0x14EE3F0 Offset: 0x14ED5F0 VA: 0x1814EE3F0
	|-Nullable<QueryPermissionsCallbackInfo>.ToString
	|
	|-RVA: 0x14EF080 Offset: 0x14EE280 VA: 0x1814EF080
	|-Nullable<QueryPermissionsOptions>.ToString
	|
	|-RVA: 0x14EEA50 Offset: 0x14EDC50 VA: 0x1814EEA50
	|-Nullable<QueryPlayerAchievementsOptions>.ToString
	|
	|-RVA: 0x14EFA50 Offset: 0x14EEC50 VA: 0x1814EFA50
	|-Nullable<QueryPresenceCallbackInfo>.ToString
	|
	|-RVA: 0x14EE9A0 Offset: 0x14EDBA0 VA: 0x1814EE9A0
	|-Nullable<QueryPresenceOptions>.ToString
	|
	|-RVA: 0x14F09D0 Offset: 0x14EFBD0 VA: 0x1814F09D0
	|-Nullable<QueryProductUserIdMappingsCallbackInfo>.ToString
	|
	|-RVA: 0x14ED730 Offset: 0x14EC930 VA: 0x1814ED730
	|-Nullable<QueryProductUserIdMappingsOptions>.ToString
	|
	|-RVA: 0x14EFC50 Offset: 0x14EEE50 VA: 0x1814EFC50
	|-Nullable<QueryStatsOptions>.ToString
	|
	|-RVA: 0x14EE6D0 Offset: 0x14ED8D0 VA: 0x1814EE6D0
	|-Nullable<QueryUserInfoByDisplayNameCallbackInfo>.ToString
	|
	|-RVA: 0x14ECF60 Offset: 0x14EC160 VA: 0x1814ECF60
	|-Nullable<QueryUserInfoByDisplayNameOptions>.ToString
	|
	|-RVA: 0x14F07C0 Offset: 0x14EF9C0 VA: 0x1814F07C0
	|-Nullable<QueryUserInfoByExternalAccountCallbackInfo>.ToString
	|
	|-RVA: 0x14ED230 Offset: 0x14EC430 VA: 0x1814ED230
	|-Nullable<QueryUserInfoByExternalAccountOptions>.ToString
	|
	|-RVA: 0x14F0660 Offset: 0x14EF860 VA: 0x1814F0660
	|-Nullable<QueryUserInfoCallbackInfo>.ToString
	|
	|-RVA: 0x14EEE70 Offset: 0x14EE070 VA: 0x1814EEE70
	|-Nullable<QueryUserInfoOptions>.ToString
	|
	|-RVA: 0x14ED680 Offset: 0x14EC880 VA: 0x1814ED680
	|-Nullable<RTCOptions>.ToString
	|
	|-RVA: 0x14EE080 Offset: 0x14ED280 VA: 0x1814EE080
	|-Nullable<RTCRoomConnectionChangedCallbackInfo>.ToString
	|
	|-RVA: 0x14ECB40 Offset: 0x14EBD40 VA: 0x1814ECB40
	|-Nullable<ReadFileCallbackInfo>.ToString
	|
	|-RVA: 0x14EE8F0 Offset: 0x14EDAF0 VA: 0x1814EE8F0
	|-Nullable<ReadFileCallbackInfo>.ToString
	|
	|-RVA: 0x14EF360 Offset: 0x14EE560 VA: 0x1814EF360
	|-Nullable<ReadFileDataCallbackInfo>.ToString
	|
	|-RVA: 0x14EDAD0 Offset: 0x14ECCD0 VA: 0x1814EDAD0
	|-Nullable<ReadFileDataCallbackInfo>.ToString
	|
	|-RVA: 0x14F00B0 Offset: 0x14EF2B0 VA: 0x1814F00B0
	|-Nullable<ReadFileOptions>.ToString
	|
	|-RVA: 0x14EEDB0 Offset: 0x14EDFB0 VA: 0x1814EEDB0
	|-Nullable<ReadFileOptions>.ToString
	|
	|-RVA: 0x14ED180 Offset: 0x14EC380 VA: 0x1814ED180
	|-Nullable<ReceiveMessageFromClientOptions>.ToString
	|
	|-RVA: 0x14EF130 Offset: 0x14EE330 VA: 0x1814EF130
	|-Nullable<ReceiveMessageFromPeerOptions>.ToString
	|
	|-RVA: 0x14EDF20 Offset: 0x14ED120 VA: 0x1814EDF20
	|-Nullable<ReceiveMessageFromServerOptions>.ToString
	|
	|-RVA: 0x14EFD30 Offset: 0x14EEF30 VA: 0x1814EFD30
	|-Nullable<Rect>.ToString
	|
	|-RVA: 0x14ECD40 Offset: 0x14EBF40 VA: 0x1814ECD40
	|-Nullable<RectInternal>.ToString
	|
	|-RVA: 0x14F0BD0 Offset: 0x14EFDD0 VA: 0x1814F0BD0
	|-Nullable<RedeemEntitlementsCallbackInfo>.ToString
	|
	|-RVA: 0x14F0000 Offset: 0x14EF200 VA: 0x1814F0000
	|-Nullable<RedeemEntitlementsOptions>.ToString
	|
	|-RVA: 0x14EF2B0 Offset: 0x14EE4B0 VA: 0x1814EF2B0
	|-Nullable<RegexPrefix>.ToString
	|
	|-RVA: 0x14F0230 Offset: 0x14EF430 VA: 0x1814F0230
	|-Nullable<RegisterClientOptions>.ToString
	|
	|-RVA: 0x14EED00 Offset: 0x14EDF00 VA: 0x1814EED00
	|-Nullable<RegisterEventOptions>.ToString
	|
	|-RVA: 0x14EE620 Offset: 0x14ED820 VA: 0x1814EE620
	|-Nullable<RegisterEventParamDef>.ToString
	|
	|-RVA: 0x14FF490 Offset: 0x14FE690 VA: 0x1814FF490
	|-Nullable<RegisterPeerOptions>.ToString
	|
	|-RVA: 0x14FF980 Offset: 0x14FEB80 VA: 0x1814FF980
	|-Nullable<RegisterPlatformAudioUserOptions>.ToString
	|
	|-RVA: 0x14FF120 Offset: 0x14FE320 VA: 0x1814FF120
	|-Nullable<RegisterPlatformUserOptions>.ToString
	|
	|-RVA: 0x1500130 Offset: 0x14FF330 VA: 0x181500130
	|-Nullable<RegisterPlayersCallbackInfo>.ToString
	|
	|-RVA: 0x14FE8B0 Offset: 0x14FDAB0 VA: 0x1814FE8B0
	|-Nullable<RegisterPlayersOptions>.ToString
	|
	|-RVA: 0x14FCF40 Offset: 0x14FC140 VA: 0x1814FCF40
	|-Nullable<RejectInviteCallbackInfo>.ToString
	|
	|-RVA: 0x14FC7D0 Offset: 0x14FB9D0 VA: 0x1814FC7D0
	|-Nullable<RejectInviteCallbackInfo>.ToString
	|
	|-RVA: 0x14FD310 Offset: 0x14FC510 VA: 0x1814FD310
	|-Nullable<RejectInviteCallbackInfo>.ToString
	|
	|-RVA: 0x15003E0 Offset: 0x14FF5E0 VA: 0x1815003E0
	|-Nullable<RejectInviteOptions>.ToString
	|
	|-RVA: 0x14FF070 Offset: 0x14FE270 VA: 0x1814FF070
	|-Nullable<RejectInviteOptions>.ToString
	|
	|-RVA: 0x14FCE90 Offset: 0x14FC090 VA: 0x1814FCE90
	|-Nullable<RejectInviteOptions>.ToString
	|
	|-RVA: 0x14FC590 Offset: 0x14FB790 VA: 0x1814FC590
	|-Nullable<RejectRequestToJoinCallbackInfo>.ToString
	|
	|-RVA: 0x14FDF00 Offset: 0x14FD100 VA: 0x1814FDF00
	|-Nullable<RejectRequestToJoinOptions>.ToString
	|
	|-RVA: 0x1500320 Offset: 0x14FF520 VA: 0x181500320
	|-Nullable<ReportInputStateOptions>.ToString
	|
	|-RVA: 0x14FCA80 Offset: 0x14FBC80 VA: 0x1814FCA80
	|-Nullable<RequestPermissionsCallbackInfo>.ToString
	|
	|-RVA: 0x14FDB60 Offset: 0x14FCD60 VA: 0x1814FDB60
	|-Nullable<RequestPermissionsOptions>.ToString
	|
	|-RVA: 0x14FFCE0 Offset: 0x14FEEE0 VA: 0x1814FFCE0
	|-Nullable<RequestToJoinReceivedCallbackInfo>.ToString
	|
	|-RVA: 0x14FFB80 Offset: 0x14FED80 VA: 0x1814FFB80
	|-Nullable<RequestToJoinResponseReceivedCallbackInfo>.ToString
	|
	|-RVA: 0x14FEB80 Offset: 0x14FDD80 VA: 0x1814FEB80
	|-Nullable<RoomStatisticsUpdatedInfo>.ToString
	|
	|-RVA: 0x14FD290 Offset: 0x14FC490 VA: 0x1814FD290
	|-Nullable<sbyte>.ToString
	|
	|-RVA: 0x14FC640 Offset: 0x14FB840 VA: 0x1814FC640
	|-Nullable<SandboxIdItemOwnership>.ToString
	|
	|-RVA: 0x14FFF10 Offset: 0x14FF110 VA: 0x1814FFF10
	|-Nullable<SendAudioOptions>.ToString
	|
	|-RVA: 0x14FC230 Offset: 0x14FB430 VA: 0x1814FC230
	|-Nullable<SendCustomInviteCallbackInfo>.ToString
	|
	|-RVA: 0x14FC390 Offset: 0x14FB590 VA: 0x1814FC390
	|-Nullable<SendCustomInviteOptions>.ToString
	|
	|-RVA: 0x14FFE50 Offset: 0x14FF050 VA: 0x1814FFE50
	|-Nullable<SendCustomNativeInviteRequestedCallbackInfo>.ToString
	|
	|-RVA: 0x14FEC30 Offset: 0x14FDE30 VA: 0x1814FEC30
	|-Nullable<SendDataOptions>.ToString
	|
	|-RVA: 0x14FCDE0 Offset: 0x14FBFE0 VA: 0x1814FCDE0
	|-Nullable<SendInviteCallbackInfo>.ToString
	|
	|-RVA: 0x14FCBE0 Offset: 0x14FBDE0 VA: 0x1814FCBE0
	|-Nullable<SendInviteCallbackInfo>.ToString
	|
	|-RVA: 0x14FE1D0 Offset: 0x14FD3D0 VA: 0x1814FE1D0
	|-Nullable<SendInviteCallbackInfo>.ToString
	|
	|-RVA: 0x14FEE50 Offset: 0x14FE050 VA: 0x1814FEE50
	|-Nullable<SendInviteOptions>.ToString
	|
	|-RVA: 0x14FF1D0 Offset: 0x14FE3D0 VA: 0x1814FF1D0
	|-Nullable<SendInviteOptions>.ToString
	|
	|-RVA: 0x14FE4B0 Offset: 0x14FD6B0 VA: 0x1814FE4B0
	|-Nullable<SendInviteOptions>.ToString
	|
	|-RVA: 0x14FED90 Offset: 0x14FDF90 VA: 0x1814FED90
	|-Nullable<SendLobbyNativeInviteRequestedCallbackInfo>.ToString
	|
	|-RVA: 0x14FC140 Offset: 0x14FB340 VA: 0x1814FC140
	|-Nullable<SendPacketOptions>.ToString
	|
	|-RVA: 0x14FD8A0 Offset: 0x14FCAA0 VA: 0x1814FD8A0
	|-Nullable<SendPlayerBehaviorReportCompleteCallbackInfo>.ToString
	|
	|-RVA: 0x14FE110 Offset: 0x14FD310 VA: 0x1814FE110
	|-Nullable<SendPlayerBehaviorReportOptions>.ToString
	|
	|-RVA: 0x14FC880 Offset: 0x14FBA80 VA: 0x1814FC880
	|-Nullable<SendRequestToJoinCallbackInfo>.ToString
	|
	|-RVA: 0x14FCFF0 Offset: 0x14FC1F0 VA: 0x1814FCFF0
	|-Nullable<SendRequestToJoinOptions>.ToString
	|
	|-RVA: 0x14FFD90 Offset: 0x14FEF90 VA: 0x1814FFD90
	|-Nullable<SendSessionNativeInviteRequestedCallbackInfo>.ToString
	|
	|-RVA: 0x14FD1F0 Offset: 0x14FC3F0 VA: 0x1814FD1F0
	|-Nullable<SentryId>.ToString
	|
	|-RVA: 0x14FF750 Offset: 0x14FE950 VA: 0x1814FF750
	|-Nullable<SequencePoint>.ToString
	|
	|-RVA: 0x14FE3D0 Offset: 0x14FD5D0 VA: 0x1814FE3D0
	|-Nullable<SessionDetailsAttribute>.ToString
	|
	|-RVA: 0x14FC9D0 Offset: 0x14FBBD0 VA: 0x1814FC9D0
	|-Nullable<SessionDetailsAttributeInternal>.ToString
	|
	|-RVA: 0x14FE770 Offset: 0x14FD970 VA: 0x1814FE770
	|-Nullable<SessionDetailsCopyInfoOptions>.ToString
	|
	|-RVA: 0x14FF800 Offset: 0x14FEA00 VA: 0x1814FF800
	|-Nullable<SessionDetailsCopySessionAttributeByIndexOptions>.ToString
	|
	|-RVA: 0x14FD950 Offset: 0x14FCB50 VA: 0x1814FD950
	|-Nullable<SessionDetailsCopySessionAttributeByKeyOptions>.ToString
	|
	|-RVA: 0x14FC930 Offset: 0x14FBB30 VA: 0x1814FC930
	|-Nullable<SessionDetailsGetSessionAttributeCountOptions>.ToString
	|
	|-RVA: 0x14FF8A0 Offset: 0x14FEAA0 VA: 0x1814FF8A0
	|-Nullable<SessionDetailsInfo>.ToString
	|
	|-RVA: 0x14FD720 Offset: 0x14FC920 VA: 0x1814FD720
	|-Nullable<SessionDetailsInfoInternal>.ToString
	|
	|-RVA: 0x14FECE0 Offset: 0x14FDEE0 VA: 0x1814FECE0
	|-Nullable<SessionDetailsSettings>.ToString
	|
	|-RVA: 0x14FEAB0 Offset: 0x14FDCB0 VA: 0x1814FEAB0
	|-Nullable<SessionDetailsSettingsInternal>.ToString
	|
	|-RVA: 0x14FDAA0 Offset: 0x14FCCA0 VA: 0x1814FDAA0
	|-Nullable<SessionInviteAcceptedCallbackInfo>.ToString
	|
	|-RVA: 0x14FD0A0 Offset: 0x14FC2A0 VA: 0x1814FD0A0
	|-Nullable<SessionInviteReceivedCallbackInfo>.ToString
	|
	|-RVA: 0x14FEF00 Offset: 0x14FE100 VA: 0x1814FEF00
	|-Nullable<SessionInviteRejectedCallbackInfo>.ToString
	|
	|-RVA: 0x14FDE20 Offset: 0x14FD020 VA: 0x1814FDE20
	|-Nullable<SessionModificationAddAttributeOptions>.ToString
	|
	|-RVA: 0x14FE320 Offset: 0x14FD520 VA: 0x1814FE320
	|-Nullable<SessionModificationRemoveAttributeOptions>.ToString
	|
	|-RVA: 0x1500080 Offset: 0x14FF280 VA: 0x181500080
	|-Nullable<SessionModificationSetAllowedPlatformIdsOptions>.ToString
	|
	|-RVA: 0x14FF550 Offset: 0x14FE750 VA: 0x1814FF550
	|-Nullable<SessionModificationSetBucketIdOptions>.ToString
	|
	|-RVA: 0x14FFAD0 Offset: 0x14FECD0 VA: 0x1814FFAD0
	|-Nullable<SessionModificationSetHostAddressOptions>.ToString
	|
	|-RVA: 0x14FC440 Offset: 0x14FB640 VA: 0x1814FC440
	|-Nullable<SessionModificationSetInvitesAllowedOptions>.ToString
	|
	|-RVA: 0x14FFA30 Offset: 0x14FEC30 VA: 0x1814FFA30
	|-Nullable<SessionModificationSetJoinInProgressAllowedOptions>.ToString
	|
	|-RVA: 0x14FD520 Offset: 0x14FC720 VA: 0x1814FD520
	|-Nullable<SessionModificationSetMaxPlayersOptions>.ToString
	|
	|-RVA: 0x14FD150 Offset: 0x14FC350 VA: 0x1814FD150
	|-Nullable<SessionModificationSetPermissionLevelOptions>.ToString
	|
	|-RVA: 0x14FE960 Offset: 0x14FDB60 VA: 0x1814FE960
	|-Nullable<SessionSearchCopySearchResultByIndexOptions>.ToString
	|
	|-RVA: 0x14FE610 Offset: 0x14FD810 VA: 0x1814FE610
	|-Nullable<SessionSearchFindCallbackInfo>.ToString
	|
	|-RVA: 0x14FC2E0 Offset: 0x14FB4E0 VA: 0x1814FC2E0
	|-Nullable<SessionSearchFindOptions>.ToString
	|
	|-RVA: 0x1500280 Offset: 0x14FF480 VA: 0x181500280
	|-Nullable<SessionSearchGetSearchResultCountOptions>.ToString
	|
	|-RVA: 0x14FEA00 Offset: 0x14FDC00 VA: 0x1814FEA00
	|-Nullable<SessionSearchRemoveParameterOptions>.ToString
	|
	|-RVA: 0x15001E0 Offset: 0x14FF3E0 VA: 0x1815001E0
	|-Nullable<SessionSearchSetMaxResultsOptions>.ToString
	|
	|-RVA: 0x14FC6F0 Offset: 0x14FB8F0 VA: 0x1814FC6F0
	|-Nullable<SessionSearchSetParameterOptions>.ToString
	|
	|-RVA: 0x1500530 Offset: 0x14FF730 VA: 0x181500530
	|-Nullable<SessionSearchSetSessionIdOptions>.ToString
	|
	|-RVA: 0x14FCB30 Offset: 0x14FBD30 VA: 0x1814FCB30
	|-Nullable<SessionSearchSetTargetUserIdOptions>.ToString
	|
	|-RVA: 0x14FC4E0 Offset: 0x14FB6E0 VA: 0x1814FC4E0
	|-Nullable<SetAudioInputSettingsOptions>.ToString
	|
	|-RVA: 0x14FF280 Offset: 0x14FE480 VA: 0x1814FF280
	|-Nullable<SetAudioOutputSettingsOptions>.ToString
	|
	|-RVA: 0x14FF330 Offset: 0x14FE530 VA: 0x1814FF330
	|-Nullable<SetClientDetailsOptions>.ToString
	|
	|-RVA: 0x14FF3E0 Offset: 0x14FE5E0 VA: 0x1814FF3E0
	|-Nullable<SetClientNetworkStateOptions>.ToString
	|
	|-RVA: 0x14FD3C0 Offset: 0x14FC5C0 VA: 0x1814FD3C0
	|-Nullable<SetCustomInviteOptions>.ToString
	|
	|-RVA: 0x14FF600 Offset: 0x14FE800 VA: 0x1814FF600
	|-Nullable<SetDisplayPreferenceOptions>.ToString
	|
	|-RVA: 0x14FCC90 Offset: 0x14FBE90 VA: 0x1814FCC90
	|-Nullable<SetGameSessionIdOptions>.ToString
	|
	|-RVA: 0x14FE060 Offset: 0x14FD260 VA: 0x1814FE060
	|-Nullable<SetInputDeviceSettingsOptions>.ToString
	|
	|-RVA: 0x14FD5C0 Offset: 0x14FC7C0 VA: 0x1814FD5C0
	|-Nullable<SetOutputDeviceSettingsOptions>.ToString
	|
	|-RVA: 0x14FEFC0 Offset: 0x14FE1C0 VA: 0x1814FEFC0
	|-Nullable<SetPacketQueueSizeOptions>.ToString
	|
	|-RVA: 0x14FD7F0 Offset: 0x14FC9F0 VA: 0x1814FD7F0
	|-Nullable<SetParticipantHardMuteCompleteCallbackInfo>.ToString
	|
	|-RVA: 0x14FE560 Offset: 0x14FD760 VA: 0x1814FE560
	|-Nullable<SetParticipantHardMuteOptions>.ToString
	|
	|-RVA: 0x14FE810 Offset: 0x14FDA10 VA: 0x1814FE810
	|-Nullable<SetPortRangeOptions>.ToString
	|
	|-RVA: 0x14FFFD0 Offset: 0x14FF1D0 VA: 0x1814FFFD0
	|-Nullable<SetPresenceCallbackInfo>.ToString
	|
	|-RVA: 0x14FF6A0 Offset: 0x14FE8A0 VA: 0x1814FF6A0
	|-Nullable<SetPresenceOptions>.ToString
	|
	|-RVA: 0x14FE280 Offset: 0x14FD480 VA: 0x1814FE280
	|-Nullable<SetRelayControlOptions>.ToString
	|
	|-RVA: 0x14FFC30 Offset: 0x14FEE30 VA: 0x1814FFC30
	|-Nullable<SetRoomSettingOptions>.ToString
	|
	|-RVA: 0x14FDD70 Offset: 0x14FCF70 VA: 0x1814FDD70
	|-Nullable<SetSettingOptions>.ToString
	|
	|-RVA: 0x14FCD40 Offset: 0x14FBF40 VA: 0x1814FCD40
	|-Nullable<SetToggleFriendsButtonOptions>.ToString
	|
	|-RVA: 0x14FDA00 Offset: 0x14FCC00 VA: 0x1814FDA00
	|-Nullable<SetToggleFriendsKeyOptions>.ToString
	|
	|-RVA: 0x14FD470 Offset: 0x14FC670 VA: 0x1814FD470
	|-Nullable<SetUserLoginStatusOptions>.ToString
	|
	|-RVA: 0x1500490 Offset: 0x14FF690 VA: 0x181500490
	|-Nullable<SetUserPreLogoutCallbackOptions>.ToString
	|
	|-RVA: 0x14FDFB0 Offset: 0x14FD1B0 VA: 0x1814FDFB0
	|-Nullable<ShowBlockPlayerOptions>.ToString
	|
	|-RVA: 0x14FDCC0 Offset: 0x14FCEC0 VA: 0x1814FDCC0
	|-Nullable<ShowFriendsCallbackInfo>.ToString
	|
	|-RVA: 0x14FD670 Offset: 0x14FC870 VA: 0x1814FD670
	|-Nullable<ShowFriendsOptions>.ToString
	|
	|-RVA: 0x14FDC10 Offset: 0x14FCE10 VA: 0x1814FDC10
	|-Nullable<ShowNativeProfileCallbackInfo>.ToString
	|
	|-RVA: 0x14FE6C0 Offset: 0x14FD8C0 VA: 0x1814FE6C0
	|-Nullable<ShowNativeProfileOptions>.ToString
	|
	|-RVA: 0x150E3D0 Offset: 0x150D5D0 VA: 0x18150E3D0
	|-Nullable<ShowReportPlayerOptions>.ToString
	|
	|-RVA: 0x150C050 Offset: 0x150B250 VA: 0x18150C050
	|-Nullable<float>.ToString
	|
	|-RVA: 0x1510160 Offset: 0x150F360 VA: 0x181510160
	|-Nullable<SocketId>.ToString
	|
	|-RVA: 0x150C9E0 Offset: 0x150BBE0 VA: 0x18150C9E0
	|-Nullable<SocketIdInternal>.ToString
	|
	|-RVA: 0x150F7F0 Offset: 0x150E9F0 VA: 0x18150F7F0
	|-Nullable<SpanId>.ToString
	|
	|-RVA: 0x150C360 Offset: 0x150B560 VA: 0x18150C360
	|-Nullable<SqlBinary>.ToString
	|
	|-RVA: 0x150EFF0 Offset: 0x150E1F0 VA: 0x18150EFF0
	|-Nullable<StartSessionCallbackInfo>.ToString
	|
	|-RVA: 0x150D010 Offset: 0x150C210 VA: 0x18150D010
	|-Nullable<StartSessionOptions>.ToString
	|
	|-RVA: 0x150F1D0 Offset: 0x150E3D0 VA: 0x18150F1D0
	|-Nullable<Stat>.ToString
	|
	|-RVA: 0x150E480 Offset: 0x150D680 VA: 0x18150E480
	|-Nullable<StatInternal>.ToString
	|
	|-RVA: 0x150D7E0 Offset: 0x150C9E0 VA: 0x18150D7E0
	|-Nullable<StatThresholds>.ToString
	|
	|-RVA: 0x150C700 Offset: 0x150B900 VA: 0x18150C700
	|-Nullable<SteamDLCVerifyPurchaseOptions>.ToString
	|
	|-RVA: 0x150CF60 Offset: 0x150C160 VA: 0x18150CF60
	|-Nullable<SteamDLCVerifyPurchaseOptionsPlatformSpecificOptions>.ToString
	|
	|-RVA: 0x150E720 Offset: 0x150D920 VA: 0x18150E720
	|-Nullable<SteamIAPVerifyPurchaseOptions>.ToString
	|
	|-RVA: 0x150DB90 Offset: 0x150CD90 VA: 0x18150DB90
	|-Nullable<SteamIAPVerifyPurchaseOptionsPlatformSpecificOptions>.ToString
	|
	|-RVA: 0x150C4C0 Offset: 0x150B6C0 VA: 0x18150C4C0
	|-Nullable<SteamOptions>.ToString
	|
	|-RVA: 0x150F9F0 Offset: 0x150EBF0 VA: 0x18150F9F0
	|-Nullable<StreamingContext>.ToString
	|
	|-RVA: 0x150DFA0 Offset: 0x150D1A0 VA: 0x18150DFA0
	|-Nullable<SubmitSnapshotCallbackInfo>.ToString
	|
	|-RVA: 0x150E0F0 Offset: 0x150D2F0 VA: 0x18150E0F0
	|-Nullable<SubmitSnapshotOptions>.ToString
	|
	|-RVA: 0x150F410 Offset: 0x150E610 VA: 0x18150F410
	|-Nullable<SwitchIAPVerifyPurchaseOptions>.ToString
	|
	|-RVA: 0x150EA80 Offset: 0x150DC80 VA: 0x18150EA80
	|-Nullable<SwitchIAPVerifyPurchaseOptionsPlatformSpecificOptions>.ToString
	|
	|-RVA: 0x150DC40 Offset: 0x150CE40 VA: 0x18150DC40
	|-Nullable<TimeSpan>.ToString
	|
	|-RVA: 0x150F4D0 Offset: 0x150E6D0 VA: 0x18150F4D0
	|-Nullable<Token>.ToString
	|
	|-RVA: 0x1510210 Offset: 0x150F410 VA: 0x181510210
	|-Nullable<Token>.ToString
	|
	|-RVA: 0x150D890 Offset: 0x150CA90 VA: 0x18150D890
	|-Nullable<TokenInternal>.ToString
	|
	|-RVA: 0x1510080 Offset: 0x150F280 VA: 0x181510080
	|-Nullable<Touch>.ToString
	|
	|-RVA: 0x150E050 Offset: 0x150D250 VA: 0x18150E050
	|-Nullable<TransactionCopyEntitlementByIndexOptions>.ToString
	|
	|-RVA: 0x150CB40 Offset: 0x150BD40 VA: 0x18150CB40
	|-Nullable<TransactionGetEntitlementsCountOptions>.ToString
	|
	|-RVA: 0x150F2A0 Offset: 0x150E4A0 VA: 0x18150F2A0
	|-Nullable<TransferDeviceIdAccountCallbackInfo>.ToString
	|
	|-RVA: 0x150D5D0 Offset: 0x150C7D0 VA: 0x18150D5D0
	|-Nullable<TransferDeviceIdAccountOptions>.ToString
	|
	|-RVA: 0x150D170 Offset: 0x150C370 VA: 0x18150D170
	|-Nullable<ushort>.ToString
	|
	|-RVA: 0x150D980 Offset: 0x150CB80 VA: 0x18150D980
	|-Nullable<UInt16Enum>.ToString
	|
	|-RVA: 0x150EE00 Offset: 0x150E000 VA: 0x18150EE00
	|-Nullable<uint>.ToString
	|
	|-RVA: 0x150E5F0 Offset: 0x150D7F0 VA: 0x18150E5F0
	|-Nullable<ulong>.ToString
	|
	|-RVA: 0x150F0A0 Offset: 0x150E2A0 VA: 0x18150F0A0
	|-Nullable<UIntPtr>.ToString
	|
	|-RVA: 0x150D4F0 Offset: 0x150C6F0 VA: 0x18150D4F0
	|-Nullable<UninstallModCallbackInfo>.ToString
	|
	|-RVA: 0x150E240 Offset: 0x150D440 VA: 0x18150E240
	|-Nullable<UninstallModOptions>.ToString
	|
	|-RVA: 0x150FFD0 Offset: 0x150F1D0 VA: 0x18150FFD0
	|-Nullable<UnlinkAccountCallbackInfo>.ToString
	|
	|-RVA: 0x150F120 Offset: 0x150E320 VA: 0x18150F120
	|-Nullable<UnlinkAccountOptions>.ToString
	|
	|-RVA: 0x150CA90 Offset: 0x150BC90 VA: 0x18150CA90
	|-Nullable<UnlockAchievementsOptions>.ToString
	|
	|-RVA: 0x150C0D0 Offset: 0x150B2D0 VA: 0x18150C0D0
	|-Nullable<UnlockedAchievement>.ToString
	|
	|-RVA: 0x150CCA0 Offset: 0x150BEA0 VA: 0x18150CCA0
	|-Nullable<UnlockedAchievementInternal>.ToString
	|
	|-RVA: 0x150ECA0 Offset: 0x150DEA0 VA: 0x18150ECA0
	|-Nullable<UnprotectMessageOptions>.ToString
	|
	|-RVA: 0x150DAE0 Offset: 0x150CCE0 VA: 0x18150DAE0
	|-Nullable<UnprotectMessageOptions>.ToString
	|
	|-RVA: 0x150E670 Offset: 0x150D870 VA: 0x18150E670
	|-Nullable<UnregisterClientOptions>.ToString
	|
	|-RVA: 0x150DE40 Offset: 0x150D040 VA: 0x18150DE40
	|-Nullable<UnregisterPeerOptions>.ToString
	|
	|-RVA: 0x150D680 Offset: 0x150C880 VA: 0x18150D680
	|-Nullable<UnregisterPlatformAudioUserOptions>.ToString
	|
	|-RVA: 0x15102B0 Offset: 0x150F4B0 VA: 0x1815102B0
	|-Nullable<UnregisterPlatformUserOptions>.ToString
	|
	|-RVA: 0x150F940 Offset: 0x150EB40 VA: 0x18150F940
	|-Nullable<UnregisterPlayersCallbackInfo>.ToString
	|
	|-RVA: 0x150F890 Offset: 0x150EA90 VA: 0x18150F890
	|-Nullable<UnregisterPlayersOptions>.ToString
	|
	|-RVA: 0x150CE00 Offset: 0x150C000 VA: 0x18150CE00
	|-Nullable<UpdateLobbyCallbackInfo>.ToString
	|
	|-RVA: 0x150DA30 Offset: 0x150CC30 VA: 0x18150DA30
	|-Nullable<UpdateLobbyModificationOptions>.ToString
	|
	|-RVA: 0x150C570 Offset: 0x150B770 VA: 0x18150C570
	|-Nullable<UpdateLobbyOptions>.ToString
	|
	|-RVA: 0x150C620 Offset: 0x150B820 VA: 0x18150C620
	|-Nullable<UpdateModCallbackInfo>.ToString
	|
	|-RVA: 0x150E9B0 Offset: 0x150DBB0 VA: 0x18150E9B0
	|-Nullable<UpdateModOptions>.ToString
	|
	|-RVA: 0x150CEB0 Offset: 0x150C0B0 VA: 0x18150CEB0
	|-Nullable<UpdateParentEmailCallbackInfo>.ToString
	|
	|-RVA: 0x150F740 Offset: 0x150E940 VA: 0x18150F740
	|-Nullable<UpdateParentEmailOptions>.ToString
	|
	|-RVA: 0x150CBE0 Offset: 0x150BDE0 VA: 0x18150CBE0
	|-Nullable<UpdateParticipantVolumeCallbackInfo>.ToString
	|
	|-RVA: 0x150CD50 Offset: 0x150BF50 VA: 0x18150CD50
	|-Nullable<UpdateParticipantVolumeOptions>.ToString
	|
	|-RVA: 0x150C180 Offset: 0x150B380 VA: 0x18150C180
	|-Nullable<UpdateReceivingCallbackInfo>.ToString
	|
	|-RVA: 0x150E310 Offset: 0x150D510 VA: 0x18150E310
	|-Nullable<UpdateReceivingCallbackInfo>.ToString
	|
	|-RVA: 0x150FD80 Offset: 0x150EF80 VA: 0x18150FD80
	|-Nullable<UpdateReceivingOptions>.ToString
	|
	|-RVA: 0x150C2B0 Offset: 0x150B4B0 VA: 0x18150C2B0
	|-Nullable<UpdateReceivingOptions>.ToString
	|
	|-RVA: 0x150F680 Offset: 0x150E880 VA: 0x18150F680
	|-Nullable<UpdateReceivingVolumeCallbackInfo>.ToString
	|
	|-RVA: 0x150D730 Offset: 0x150C930 VA: 0x18150D730
	|-Nullable<UpdateReceivingVolumeOptions>.ToString
	|
	|-RVA: 0x150EE80 Offset: 0x150E080 VA: 0x18150EE80
	|-Nullable<UpdateSendingCallbackInfo>.ToString
	|
	|-RVA: 0x150C400 Offset: 0x150B600 VA: 0x18150C400
	|-Nullable<UpdateSendingCallbackInfo>.ToString
	|
	|-RVA: 0x150BE30 Offset: 0x150B030 VA: 0x18150BE30
	|-Nullable<UpdateSendingOptions>.ToString
	|
	|-RVA: 0x1510360 Offset: 0x150F560 VA: 0x181510360
	|-Nullable<UpdateSendingOptions>.ToString
	|
	|-RVA: 0x150F350 Offset: 0x150E550 VA: 0x18150F350
	|-Nullable<UpdateSendingVolumeCallbackInfo>.ToString
	|
	|-RVA: 0x150D2A0 Offset: 0x150C4A0 VA: 0x18150D2A0
	|-Nullable<UpdateSendingVolumeOptions>.ToString
	|
	|-RVA: 0x150EF40 Offset: 0x150E140 VA: 0x18150EF40
	|-Nullable<UpdateSessionCallbackInfo>.ToString
	|
	|-RVA: 0x15104C0 Offset: 0x150F6C0 VA: 0x1815104C0
	|-Nullable<UpdateSessionModificationOptions>.ToString
	|
	|-RVA: 0x150EB30 Offset: 0x150DD30 VA: 0x18150EB30
	|-Nullable<UpdateSessionOptions>.ToString
	|
	|-RVA: 0x150C870 Offset: 0x150BA70 VA: 0x18150C870
	|-Nullable<UserInfoData>.ToString
	|
	|-RVA: 0x150F5B0 Offset: 0x150E7B0 VA: 0x18150F5B0
	|-Nullable<UserInfoDataInternal>.ToString
	|
	|-RVA: 0x150D440 Offset: 0x150C640 VA: 0x18150D440
	|-Nullable<UserLoginInfo>.ToString
	|
	|-RVA: 0x150EBE0 Offset: 0x150DDE0 VA: 0x18150EBE0
	|-Nullable<UserLoginStatusChangedCallbackInfo>.ToString
	|
	|-RVA: 0x150BF90 Offset: 0x150B190 VA: 0x18150BF90
	|-Nullable<UserPreLogoutCallbackInfo>.ToString
	|
	|-RVA: 0x150DEF0 Offset: 0x150D0F0 VA: 0x18150DEF0
	|-Nullable<UserScoresQueryStatInfo>.ToString
	|
	|-RVA: 0x150E900 Offset: 0x150DB00 VA: 0x18150E900
	|-Nullable<UserToken>.ToString
	|
	|-RVA: 0x150E190 Offset: 0x150D390 VA: 0x18150E190
	|-Nullable<UserTokenInternal>.ToString
	|
	|-RVA: 0x150C930 Offset: 0x150BB30 VA: 0x18150C930
	|-Nullable<Vec3f>.ToString
	|
	|-RVA: 0x150C7C0 Offset: 0x150B9C0 VA: 0x18150C7C0
	|-Nullable<Vec3fInternal>.ToString
	|
	|-RVA: 0x150FAA0 Offset: 0x150ECA0 VA: 0x18150FAA0
	|-Nullable<Vector2>.ToString
	|
	|-RVA: 0x150C240 Offset: 0x150B440 VA: 0x18150C240
	|-Nullable<Vector3>.ToString
	|
	|-RVA: 0x150FE30 Offset: 0x150F030 VA: 0x18150FE30
	|-Nullable<VerifyIdTokenCallbackInfo>.ToString
	|
	|-RVA: 0x150FC90 Offset: 0x150EE90 VA: 0x18150FC90
	|-Nullable<VerifyIdTokenCallbackInfo>.ToString
	|
	|-RVA: 0x1510410 Offset: 0x150F610 VA: 0x181510410
	|-Nullable<VerifyIdTokenOptions>.ToString
	|
	|-RVA: 0x150D0C0 Offset: 0x150C2C0 VA: 0x18150D0C0
	|-Nullable<VerifyIdTokenOptions>.ToString
	|
	|-RVA: 0x150DCE0 Offset: 0x150CEE0 VA: 0x18150DCE0
	|-Nullable<VerifyPurchaseCompleteCallbackInfo>.ToString
	|
	|-RVA: 0x150FF20 Offset: 0x150F120 VA: 0x18150FF20
	|-Nullable<VerifyPurchaseOptions>.ToString
	|
	|-RVA: 0x150DD90 Offset: 0x150CF90 VA: 0x18150DD90
	|-Nullable<VerifyUserAuthCallbackInfo>.ToString
	|
	|-RVA: 0x150D350 Offset: 0x150C550 VA: 0x18150D350
	|-Nullable<VerifyUserAuthOptions>.ToString
	|
	|-RVA: 0x150E7E0 Offset: 0x150D9E0 VA: 0x18150E7E0
	|-Nullable<WindowsOptions>.ToString
	|
	|-RVA: 0x150D1F0 Offset: 0x150C3F0 VA: 0x18150D1F0
	|-Nullable<WindowsRTCOptions>.ToString
	|
	|-RVA: 0x150E540 Offset: 0x150D740 VA: 0x18150E540
	|-Nullable<WindowsRTCOptionsPlatformSpecificOptions>.ToString
	|
	|-RVA: 0x150ED50 Offset: 0x150DF50 VA: 0x18150ED50
	|-Nullable<WindowsRTCOptionsPlatformSpecificOptionsInternal>.ToString
	|
	|-RVA: 0x150BEE0 Offset: 0x150B0E0 VA: 0x18150BEE0
	|-Nullable<WriteFileCallbackInfo>.ToString
	|
	|-RVA: 0xB4C6D0 Offset: 0xB4B8D0 VA: 0x180B4C6D0
	|-Nullable<WriteFileDataCallbackInfo>.ToString
	|
	|-RVA: 0xB4DE80 Offset: 0xB4D080 VA: 0x180B4DE80
	|-Nullable<WriteFileOptions>.ToString
	|
	|-RVA: 0xB4D9A0 Offset: 0xB4CBA0 VA: 0x180B4D9A0
	|-Nullable<XSXDLCVerifyPurchaseOptions>.ToString
	|
	|-RVA: 0xB4D540 Offset: 0xB4C740 VA: 0x180B4D540
	|-Nullable<XSXDLCVerifyPurchaseOptionsPlatformSpecificOptions>.ToString
	|
	|-RVA: 0xB4D210 Offset: 0xB4C410 VA: 0x180B4D210
	|-Nullable<XSXIAPVerifyPurchaseOptions>.ToString
	|
	|-RVA: 0xB4C400 Offset: 0xB4B600 VA: 0x180B4C400
	|-Nullable<XSXIAPVerifyPurchaseOptionsPlatformSpecificOptions>.ToString
	|
	|-RVA: 0xB4C150 Offset: 0xB4B350 VA: 0x180B4C150
	|-Nullable<XSXInitializeOptions>.ToString
	|
	|-RVA: 0xB4DBC0 Offset: 0xB4CDC0 VA: 0x180B4DBC0
	|-Nullable<XSXInitializeOptionsSystemInitializeOptions>.ToString
	|
	|-RVA: 0xB4C090 Offset: 0xB4B290 VA: 0x180B4C090
	|-Nullable<XSXIntegratedPlatformOptionsContainerAddOptions>.ToString
	|
	|-RVA: 0xB4C620 Offset: 0xB4B820 VA: 0x180B4C620
	|-Nullable<XSXMemoryMonitorCallbackInfo>.ToString
	|
	|-RVA: 0xB4BF30 Offset: 0xB4B130 VA: 0x180B4BF30
	|-Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReport>.ToString
	|
	|-RVA: 0xB4C780 Offset: 0xB4B980 VA: 0x180B4C780
	|-Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.ToString
	|
	|-RVA: 0xB4DD60 Offset: 0xB4CF60 VA: 0x180B4DD60
	|-Nullable<XSXOptions>.ToString
	|
	|-RVA: 0xB4DA60 Offset: 0xB4CC60 VA: 0x180B4DA60
	|-Nullable<XSXOptionsSystemSpecificOptions>.ToString
	|
	|-RVA: 0xB4D4A0 Offset: 0xB4C6A0 VA: 0x180B4D4A0
	|-Nullable<XSXPrePresentAdditionalData>.ToString
	|
	|-RVA: 0xB4D8F0 Offset: 0xB4CAF0 VA: 0x180B4D8F0
	|-Nullable<XSXPrePresentAdditionalDataInternal>.ToString
	|
	|-RVA: 0xB4D5F0 Offset: 0xB4C7F0 VA: 0x180B4D5F0
	|-Nullable<XSXPrePresentOptions>.ToString
	|
	|-RVA: 0xB4DC90 Offset: 0xB4CE90 VA: 0x180B4DC90
	|-Nullable<XSXPrePresentOptionsPlatformSpecificData>.ToString
	|
	|-RVA: 0xB4DFF0 Offset: 0xB4D1F0 VA: 0x180B4DFF0
	|-Nullable<XSXSubmitGraphicsCommandsCallbackInfo>.ToString
	|
	|-RVA: 0xB4BFE0 Offset: 0xB4B1E0 VA: 0x180B4BFE0
	|-Nullable<XSXSubmitGraphicsCommandsDataCommand>.ToString
	|
	|-RVA: 0xB4E0A0 Offset: 0xB4D2A0 VA: 0x180B4E0A0
	|-Nullable<XSXXBLOptions>.ToString
	|
	|-RVA: 0xB4CFB0 Offset: 0xB4C1B0 VA: 0x180B4CFB0
	|-Nullable<XSXXBLOptionsInitOptions>.ToString
	|
	|-RVA: 0xB4CF00 Offset: 0xB4C100 VA: 0x180B4CF00
	|-Nullable<XSXXBLOptionsInitOptionsInternal>.ToString
	|
	|-RVA: 0xB4D830 Offset: 0xB4CA30 VA: 0x180B4D830
	|-Nullable<XboxOneGDKDLCVerifyPurchaseOptions>.ToString
	|
	|-RVA: 0xB4CB80 Offset: 0xB4BD80 VA: 0x180B4CB80
	|-Nullable<XboxOneGDKDLCVerifyPurchaseOptionsPlatformSpecificOptions>.ToString
	|
	|-RVA: 0xB4C4B0 Offset: 0xB4B6B0 VA: 0x180B4C4B0
	|-Nullable<XboxOneGDKIAPVerifyPurchaseOptions>.ToString
	|
	|-RVA: 0xB4C280 Offset: 0xB4B480 VA: 0x180B4C280
	|-Nullable<XboxOneGDKIAPVerifyPurchaseOptionsPlatformSpecificOptions>.ToString
	|
	|-RVA: 0xB4CA50 Offset: 0xB4BC50 VA: 0x180B4CA50
	|-Nullable<XboxOneGDKInitializeOptions>.ToString
	|
	|-RVA: 0xB4E160 Offset: 0xB4D360 VA: 0x180B4E160
	|-Nullable<XboxOneGDKInitializeOptionsSystemInitializeOptions>.ToString
	|
	|-RVA: 0xB4D770 Offset: 0xB4C970 VA: 0x180B4D770
	|-Nullable<XboxOneGDKIntegratedPlatformOptionsContainerAddOptions>.ToString
	|
	|-RVA: 0xB4D3F0 Offset: 0xB4C5F0 VA: 0x180B4D3F0
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfo>.ToString
	|
	|-RVA: 0xB4D6C0 Offset: 0xB4C8C0 VA: 0x180B4D6C0
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReport>.ToString
	|
	|-RVA: 0xB4CC30 Offset: 0xB4BE30 VA: 0x180B4CC30
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.ToString
	|
	|-RVA: 0xB4D2D0 Offset: 0xB4C4D0 VA: 0x180B4D2D0
	|-Nullable<XboxOneGDKOptions>.ToString
	|
	|-RVA: 0xB4DB10 Offset: 0xB4CD10 VA: 0x180B4DB10
	|-Nullable<XboxOneGDKOptionsSystemSpecificOptions>.ToString
	|
	|-RVA: 0xB4CE60 Offset: 0xB4C060 VA: 0x180B4CE60
	|-Nullable<XboxOneGDKPrePresentAdditionalData>.ToString
	|
	|-RVA: 0xB4C8F0 Offset: 0xB4BAF0 VA: 0x180B4C8F0
	|-Nullable<XboxOneGDKPrePresentAdditionalDataInternal>.ToString
	|
	|-RVA: 0xB4C330 Offset: 0xB4B530 VA: 0x180B4C330
	|-Nullable<XboxOneGDKPrePresentOptions>.ToString
	|
	|-RVA: 0xB4CD90 Offset: 0xB4BF90 VA: 0x180B4CD90
	|-Nullable<XboxOneGDKPrePresentOptionsPlatformSpecificData>.ToString
	|
	|-RVA: 0xB4DF40 Offset: 0xB4D140 VA: 0x180B4DF40
	|-Nullable<XboxOneGDKSubmitGraphicsCommandsCallbackInfo>.ToString
	|
	|-RVA: 0xB4CCE0 Offset: 0xB4BEE0 VA: 0x180B4CCE0
	|-Nullable<XboxOneGDKSubmitGraphicsCommandsDataCommand>.ToString
	|
	|-RVA: 0xB4C830 Offset: 0xB4BA30 VA: 0x180B4C830
	|-Nullable<XboxOneGDKXBLOptions>.ToString
	|
	|-RVA: 0xB4C570 Offset: 0xB4B770 VA: 0x180B4C570
	|-Nullable<XboxOneGDKXBLOptionsInitOptions>.ToString
	|
	|-RVA: 0xB4BE80 Offset: 0xB4B080 VA: 0x180B4BE80
	|-Nullable<XboxOneGDKXBLOptionsInitOptionsInternal>.ToString
	|
	|-RVA: 0xB4D060 Offset: 0xB4C260 VA: 0x180B4D060
	|-Nullable<__Il2CppFullySharedGenericStructType>.ToString
	|
	|-RVA: 0xB4C9A0 Offset: 0xB4BBA0 VA: 0x180B4C9A0
	|-Nullable<C.sentry_value_t>.ToString
	*/

	// RVA: -1 Offset: -1
	private static object Box(Nullable<T> o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB49BB0 Offset: 0xB48DB0 VA: 0x180B49BB0
	|-Nullable<ArraySegment<byte>>.Box
	|-Nullable<ValueTuple<object, object>>.Box
	|-Nullable<AcceptInviteOptions>.Box
	|-Nullable<AcceptRequestToJoinOptions>.Box
	|-Nullable<AccountFeatureRestrictedInfoInternal>.Box
	|-Nullable<AcknowledgeEventIdOptions>.Box
	|-Nullable<AddNotifyAudioBeforeSendOptions>.Box
	|-Nullable<AddNotifyAudioInputStateOptions>.Box
	|-Nullable<AddNotifyAudioOutputStateOptions>.Box
	|-Nullable<AddNotifyDataReceivedOptions>.Box
	|-Nullable<AddNotifyDisconnectedOptions>.Box
	|-Nullable<AddNotifyParticipantStatusChangedOptions>.Box
	|-Nullable<AddNotifyParticipantUpdatedOptions>.Box
	|-Nullable<AddNotifyParticipantUpdatedOptions>.Box
	|-Nullable<AddNotifyRTCRoomConnectionChangedOptions>.Box
	|-Nullable<AddNotifyRoomStatisticsUpdatedOptions>.Box
	|-Nullable<AndroidIAPVerifyPurchaseOptionsPlatformSpecificOptions>.Box
	|-Nullable<AudioBuffer>.Box
	|-Nullable<AuthExpirationCallbackInfo>.Box
	|-Nullable<BeginSessionOptions>.Box
	|-Nullable<BigInteger>.Box
	|-Nullable<ClientCredentials>.Box
	|-Nullable<CopyBestDisplayNameOptions>.Box
	|-Nullable<CopyEntitlementByIdOptions>.Box
	|-Nullable<CopyEntitlementByIndexOptions>.Box
	|-Nullable<CopyFileMetadataAtIndexOptions>.Box
	|-Nullable<CopyFileMetadataAtIndexOptions>.Box
	|-Nullable<CopyFileMetadataByFilenameOptions>.Box
	|-Nullable<CopyFileMetadataByFilenameOptions>.Box
	|-Nullable<CopyItemByIdOptions>.Box
	|-Nullable<CopyLastRedeemedEntitlementByIndexOptions>.Box
	|-Nullable<CopyLeaderboardUserScoreByIndexOptions>.Box
	|-Nullable<CopyLeaderboardUserScoreByUserIdOptions>.Box
	|-Nullable<CopyLobbyDetailsHandleOptions>.Box
	|-Nullable<CopyModInfoOptions>.Box
	|-Nullable<CopyOfferByIdOptions>.Box
	|-Nullable<CopyOfferByIndexOptions>.Box
	|-Nullable<CopyPermissionByIndexOptions>.Box
	|-Nullable<CopyPlayerSanctionByIndexOptions>.Box
	|-Nullable<CopyPresenceOptions>.Box
	|-Nullable<CopyProductUserExternalAccountByAccountIdOptions>.Box
	|-Nullable<CopyProductUserExternalAccountByAccountTypeOptions>.Box
	|-Nullable<CopyProductUserExternalAccountByIndexOptions>.Box
	|-Nullable<CopyStatByIndexOptions>.Box
	|-Nullable<CopyStatByNameOptions>.Box
	|-Nullable<CopyTransactionByIdOptions>.Box
	|-Nullable<CopyTransactionByIndexOptions>.Box
	|-Nullable<CopyUnlockedAchievementByAchievementIdOptions>.Box
	|-Nullable<CopyUnlockedAchievementByIndexOptions>.Box
	|-Nullable<CopyUserInfoOptions>.Box
	|-Nullable<CopyUserTokenByUserIdOptions>.Box
	|-Nullable<CreateDeviceIdCallbackInfo>.Box
	|-Nullable<Credentials>.Box
	|-Nullable<DataRecord>.Box
	|-Nullable<DateTimeOffset>.Box
	|-Nullable<Decimal>.Box
	|-Nullable<DeleteDeviceIdCallbackInfo>.Box
	|-Nullable<DeleteFileOptions>.Box
	|-Nullable<DeletePersistentAuthCallbackInfo>.Box
	|-Nullable<DestroyLobbyOptions>.Box
	|-Nullable<DestroySessionCallbackInfo>.Box
	|-Nullable<EGSDLCVerifyPurchaseOptionsPlatformSpecificOptions>.Box
	|-Nullable<EGSIAPVerifyPurchaseOptionsPlatformSpecificOptions>.Box
	|-Nullable<EndSessionCallbackInfo>.Box
	|-Nullable<EnumerateModsOptions>.Box
	|-Nullable<GetBlockedUserAtIndexOptions>.Box
	|-Nullable<GetConnectStringOptions>.Box
	|-Nullable<GetEntitlementsByNameCountOptions>.Box
	|-Nullable<GetExternalUserInfoCountOptions>.Box
	|-Nullable<GetFriendAtIndexOptions>.Box
	|-Nullable<GetInviteIdByIndexOptions>.Box
	|-Nullable<GetInviteIdByIndexOptions>.Box
	|-Nullable<GetItemImageInfoCountOptions>.Box
	|-Nullable<GetItemReleaseCountOptions>.Box
	|-Nullable<GetJoinInfoOptions>.Box
	|-Nullable<GetNextReceivedPacketSizeOptions>.Box
	|-Nullable<GetOfferImageInfoCountOptions>.Box
	|-Nullable<GetOfferItemCountOptions>.Box
	|-Nullable<GetPermissionByKeyOptions>.Box
	|-Nullable<GetRTCRoomNameOptions>.Box
	|-Nullable<GetStatusOptions>.Box
	|-Nullable<HasPresenceOptions>.Box
	|-Nullable<IOSIAPVerifyPurchaseOptionsPlatformSpecificOptions>.Box
	|-Nullable<IdToken>.Box
	|-Nullable<IdToken>.Box
	|-Nullable<IngestData>.Box
	|-Nullable<IsRTCRoomConnectedOptions>.Box
	|-Nullable<IsUserInSessionOptions>.Box
	|-Nullable<ItemOwnership>.Box
	|-Nullable<JoinSessionCallbackInfo>.Box
	|-Nullable<JsonElement>.Box
	|-Nullable<KickCompleteCallbackInfo>.Box
	|-Nullable<KickOptions>.Box
	|-Nullable<LeaderboardUserScore>.Box
	|-Nullable<LeaveLobbyOptions>.Box
	|-Nullable<LeaveRoomOptions>.Box
	|-Nullable<LinkAccountOptions>.Box
	|-Nullable<LobbyDetailsCopyMemberAttributeByIndexOptions>.Box
	|-Nullable<LobbyDetailsCopyMemberAttributeByKeyOptions>.Box
	|-Nullable<LobbyDetailsMemberInfo>.Box
	|-Nullable<LobbySearchFindCallbackInfo>.Box
	|-Nullable<LobbySearchRemoveParameterOptions>.Box
	|-Nullable<LobbyUpdateReceivedCallbackInfo>.Box
	|-Nullable<LocalDefinition>.Box
	|-Nullable<LogPlayerReviveOptions>.Box
	|-Nullable<LogPlayerSpawnOptions>.Box
	|-Nullable<MemoryMonitorCallbackInfo>.Box
	|-Nullable<ModInfo>.Box
	|-Nullable<OnCheckpointCompleteCallbackInfo>.Box
	|-Nullable<OnCloseCompleteCallbackInfo>.Box
	|-Nullable<OnDisplaySettingsUpdatedCallbackInfo>.Box
	|-Nullable<OnQueryDefinitionsCompleteCallbackInfo>.Box
	|-Nullable<OnQueryInputDevicesInformationCallbackInfo>.Box
	|-Nullable<OnQueryLeaderboardDefinitionsCompleteCallbackInfo>.Box
	|-Nullable<OnQueryLeaderboardUserScoresCompleteCallbackInfo>.Box
	|-Nullable<OnQueryOutputDevicesInformationCallbackInfo>.Box
	|-Nullable<Option>.Box
	|-Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReport>.Box
	|-Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReport>.Box
	|-Nullable<PS5Options>.Box
	|-Nullable<ParticipantMetadata>.Box
	|-Nullable<PermissionStatus>.Box
	|-Nullable<PlayerStatInfo>.Box
	|-Nullable<QueryActivePlayerSanctionsOptions>.Box
	|-Nullable<QueryEntitlementTokenOptions>.Box
	|-Nullable<QueryFileListOptions>.Box
	|-Nullable<QueryFileOptions>.Box
	|-Nullable<QueryFileOptions>.Box
	|-Nullable<QueryIdTokenOptions>.Box
	|-Nullable<QueryLeaderboardRanksOptions>.Box
	|-Nullable<QueryOffersOptions>.Box
	|-Nullable<QueryOwnershipBySandboxIdsOptions>.Box
	|-Nullable<QueryPlayerAchievementsOptions>.Box
	|-Nullable<QueryPresenceOptions>.Box
	|-Nullable<QueryUserInfoByDisplayNameOptions>.Box
	|-Nullable<QueryUserInfoOptions>.Box
	|-Nullable<RTCOptions>.Box
	|-Nullable<ReceiveMessageFromServerOptions>.Box
	|-Nullable<RedeemEntitlementsOptions>.Box
	|-Nullable<RegexPrefix>.Box
	|-Nullable<RegisterEventParamDef>.Box
	|-Nullable<RegisterPlayersOptions>.Box
	|-Nullable<RejectInviteCallbackInfo>.Box
	|-Nullable<RejectInviteOptions>.Box
	|-Nullable<RejectInviteOptions>.Box
	|-Nullable<RejectInviteOptions>.Box
	|-Nullable<RejectRequestToJoinOptions>.Box
	|-Nullable<RequestPermissionsOptions>.Box
	|-Nullable<SandboxIdItemOwnership>.Box
	|-Nullable<SendCustomInviteOptions>.Box
	|-Nullable<SendInviteCallbackInfo>.Box
	|-Nullable<SendInviteOptions>.Box
	|-Nullable<SendPlayerBehaviorReportCompleteCallbackInfo>.Box
	|-Nullable<SendRequestToJoinOptions>.Box
	|-Nullable<SessionSearchFindCallbackInfo>.Box
	|-Nullable<SessionSearchRemoveParameterOptions>.Box
	|-Nullable<SetClientDetailsOptions>.Box
	|-Nullable<SetClientNetworkStateOptions>.Box
	|-Nullable<SetCustomInviteOptions>.Box
	|-Nullable<SetOutputDeviceSettingsOptions>.Box
	|-Nullable<SetPacketQueueSizeOptions>.Box
	|-Nullable<SetParticipantHardMuteCompleteCallbackInfo>.Box
	|-Nullable<SetPresenceOptions>.Box
	|-Nullable<SetSettingOptions>.Box
	|-Nullable<ShowBlockPlayerOptions>.Box
	|-Nullable<ShowNativeProfileOptions>.Box
	|-Nullable<ShowReportPlayerOptions>.Box
	|-Nullable<SocketIdInternal>.Box
	|-Nullable<StartSessionCallbackInfo>.Box
	|-Nullable<StatThresholds>.Box
	|-Nullable<SteamDLCVerifyPurchaseOptionsPlatformSpecificOptions>.Box
	|-Nullable<StreamingContext>.Box
	|-Nullable<SubmitSnapshotCallbackInfo>.Box
	|-Nullable<UnlockAchievementsOptions>.Box
	|-Nullable<UnregisterPlayersOptions>.Box
	|-Nullable<UpdateLobbyModificationOptions>.Box
	|-Nullable<UpdateParentEmailOptions>.Box
	|-Nullable<UserLoginInfo>.Box
	|-Nullable<UserScoresQueryStatInfo>.Box
	|-Nullable<UserToken>.Box
	|-Nullable<VerifyPurchaseCompleteCallbackInfo>.Box
	|-Nullable<VerifyUserAuthCallbackInfo>.Box
	|-Nullable<WindowsRTCOptionsPlatformSpecificOptionsInternal>.Box
	|-Nullable<XSXDLCVerifyPurchaseOptionsPlatformSpecificOptions>.Box
	|-Nullable<XSXIAPVerifyPurchaseOptionsPlatformSpecificOptions>.Box
	|-Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.Box
	|-Nullable<XSXSubmitGraphicsCommandsDataCommand>.Box
	|-Nullable<XSXXBLOptionsInitOptions>.Box
	|-Nullable<XboxOneGDKDLCVerifyPurchaseOptionsPlatformSpecificOptions>.Box
	|-Nullable<XboxOneGDKIAPVerifyPurchaseOptionsPlatformSpecificOptions>.Box
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.Box
	|-Nullable<XboxOneGDKSubmitGraphicsCommandsDataCommand>.Box
	|-Nullable<XboxOneGDKXBLOptionsInitOptions>.Box
	|
	|-RVA: 0xB4A030 Offset: 0xB49230 VA: 0x180B4A030
	|-Nullable<AcceptConnectionOptions>.Box
	|-Nullable<AttributeDataValue>.Box
	|-Nullable<AttributeDataValue>.Box
	|-Nullable<AudioBeforeRenderCallbackInfo>.Box
	|-Nullable<BeginPlayerSessionOptions>.Box
	|-Nullable<ClearPacketQueueOptions>.Box
	|-Nullable<CloseConnectionOptions>.Box
	|-Nullable<ExternalAccountInfo>.Box
	|-Nullable<FileMetadata>.Box
	|-Nullable<LobbyDetailsInfo>.Box
	|-Nullable<LogPlayerUseWeaponData>.Box
	|-Nullable<PS4IntegratedPlatformOptionsContainerAddOptions>.Box
	|-Nullable<PS4PrePresentOptions>.Box
	|-Nullable<PS5PrePresentOptions>.Box
	|-Nullable<ParticipantStatusChangedCallbackInfo>.Box
	|-Nullable<QueryLeaderboardDefinitionsOptions>.Box
	|-Nullable<QueryPermissionsCallbackInfo>.Box
	|-Nullable<SessionDetailsInfoInternal>.Box
	|-Nullable<SessionDetailsSettingsInternal>.Box
	|-Nullable<UninstallModOptions>.Box
	|-Nullable<UpdateModOptions>.Box
	|-Nullable<UserInfoDataInternal>.Box
	|-Nullable<XSXInitializeOptionsSystemInitializeOptions>.Box
	|-Nullable<XSXPrePresentOptionsPlatformSpecificData>.Box
	|-Nullable<XboxOneGDKInitializeOptionsSystemInitializeOptions>.Box
	|-Nullable<XboxOneGDKPrePresentOptionsPlatformSpecificData>.Box
	|
	|-RVA: 0xB49C10 Offset: 0xB48E10 VA: 0x180B49C10
	|-Nullable<AcceptInviteCallbackInfo>.Box
	|-Nullable<AcceptRequestToJoinCallbackInfo>.Box
	|-Nullable<AttributeDataInternal>.Box
	|-Nullable<AttributeDataInternal>.Box
	|-Nullable<AudioBufferInternal>.Box
	|-Nullable<AudioInputStateCallbackInfo>.Box
	|-Nullable<AudioOutputStateCallbackInfo>.Box
	|-Nullable<BeginSessionOptions>.Box
	|-Nullable<BlockParticipantOptions>.Box
	|-Nullable<CheckoutCallbackInfo>.Box
	|-Nullable<DisconnectedCallbackInfo>.Box
	|-Nullable<EnumerateModsCallbackInfo>.Box
	|-Nullable<ExternalUserInfo>.Box
	|-Nullable<ExternalUserInfoInternal>.Box
	|-Nullable<FileMetadata>.Box
	|-Nullable<FileMetadataInternal>.Box
	|-Nullable<FileTransferProgressCallbackInfo>.Box
	|-Nullable<FileTransferProgressCallbackInfo>.Box
	|-Nullable<FinalizeInviteOptions>.Box
	|-Nullable<HardMuteMemberCallbackInfo>.Box
	|-Nullable<HardMuteMemberOptions>.Box
	|-Nullable<IOSCredentialsSystemAuthCredentialsOptionsInternal>.Box
	|-Nullable<IngestStatCompleteCallbackInfo>.Box
	|-Nullable<IntegratedPlatformOptionsContainerAddOptions>.Box
	|-Nullable<JoinSessionOptions>.Box
	|-Nullable<KeyImageInfoInternal>.Box
	|-Nullable<LeaderboardRecordInternal>.Box
	|-Nullable<LeaveRoomCallbackInfo>.Box
	|-Nullable<LobbyInviteReceivedCallbackInfo>.Box
	|-Nullable<LobbyMemberStatusReceivedCallbackInfo>.Box
	|-Nullable<LogGameRoundStartOptions>.Box
	|-Nullable<LoginCallbackInfo>.Box
	|-Nullable<OnBlockedUsersUpdateInfo>.Box
	|-Nullable<OnClientActionRequiredCallbackInfo>.Box
	|-Nullable<OnFriendsUpdateInfo>.Box
	|-Nullable<OnMessageToClientCallbackInfo>.Box
	|-Nullable<OnQueryPlayerAchievementsCompleteCallbackInfo>.Box
	|-Nullable<OnQueryStatsCompleteCallbackInfo>.Box
	|-Nullable<OnShowBlockPlayerCallbackInfo>.Box
	|-Nullable<OnShowReportPlayerCallbackInfo>.Box
	|-Nullable<OnUnlockAchievementsCompleteCallbackInfo>.Box
	|-Nullable<PS4DLCVerifyPurchaseOptionsPlatformSpecificOptions>.Box
	|-Nullable<PS4IAPVerifyPurchaseOptionsPlatformSpecificOptions>.Box
	|-Nullable<PS4MemoryMonitorCallbackInfo>.Box
	|-Nullable<PS4OptionsInitOptionsInternal>.Box
	|-Nullable<PS5DLCVerifyPurchaseOptionsPlatformSpecificOptions>.Box
	|-Nullable<PS5IAPVerifyPurchaseOptionsPlatformSpecificOptions>.Box
	|-Nullable<PS5MemoryMonitorCallbackInfo>.Box
	|-Nullable<PS5SubmitGraphicsCommandsCallbackInfo>.Box
	|-Nullable<PinGrantInfo>.Box
	|-Nullable<PlayerSanction>.Box
	|-Nullable<ProtectMessageOptions>.Box
	|-Nullable<QueryActivePlayerSanctionsCallbackInfo>.Box
	|-Nullable<QueryAgeGateCallbackInfo>.Box
	|-Nullable<QueryEntitlementTokenCallbackInfo>.Box
	|-Nullable<QueryFileListCallbackInfo>.Box
	|-Nullable<QueryFileListCallbackInfo>.Box
	|-Nullable<QueryIdTokenCallbackInfo>.Box
	|-Nullable<QueryJoinRoomTokenOptions>.Box
	|-Nullable<QueryOwnershipBySandboxIdsCallbackInfo>.Box
	|-Nullable<QueryOwnershipCallbackInfo>.Box
	|-Nullable<QueryOwnershipTokenCallbackInfo>.Box
	|-Nullable<QueryPresenceCallbackInfo>.Box
	|-Nullable<QueryUserInfoCallbackInfo>.Box
	|-Nullable<RTCRoomConnectionChangedCallbackInfo>.Box
	|-Nullable<ReadFileCallbackInfo>.Box
	|-Nullable<ReadFileCallbackInfo>.Box
	|-Nullable<RedeemEntitlementsCallbackInfo>.Box
	|-Nullable<RegisterEventOptions>.Box
	|-Nullable<RegisterPlayersCallbackInfo>.Box
	|-Nullable<RejectInviteCallbackInfo>.Box
	|-Nullable<RejectRequestToJoinCallbackInfo>.Box
	|-Nullable<RequestToJoinResponseReceivedCallbackInfo>.Box
	|-Nullable<RoomStatisticsUpdatedInfo>.Box
	|-Nullable<SendCustomInviteCallbackInfo>.Box
	|-Nullable<SendDataOptions>.Box
	|-Nullable<SendInviteCallbackInfo>.Box
	|-Nullable<SendRequestToJoinCallbackInfo>.Box
	|-Nullable<SessionDetailsSettings>.Box
	|-Nullable<SessionInviteReceivedCallbackInfo>.Box
	|-Nullable<SetRoomSettingOptions>.Box
	|-Nullable<ShowNativeProfileCallbackInfo>.Box
	|-Nullable<SocketId>.Box
	|-Nullable<SteamOptions>.Box
	|-Nullable<UnlockedAchievement>.Box
	|-Nullable<UnprotectMessageOptions>.Box
	|-Nullable<UpdateParticipantVolumeOptions>.Box
	|-Nullable<UpdateReceivingOptions>.Box
	|-Nullable<UpdateReceivingOptions>.Box
	|-Nullable<UpdateSessionCallbackInfo>.Box
	|-Nullable<VerifyPurchaseOptions>.Box
	|-Nullable<WriteFileCallbackInfo>.Box
	|-Nullable<WriteFileDataCallbackInfo>.Box
	|
	|-RVA: 0xB49F90 Offset: 0xB49190 VA: 0x180B49F90
	|-Nullable<AccountFeatureRestrictedInfo>.Box
	|-Nullable<AddExternalIntegrityCatalogOptions>.Box
	|-Nullable<AudioDevicesChangedCallbackInfo>.Box
	|-Nullable<BeginSnapshotOptions>.Box
	|-Nullable<CheckoutEntry>.Box
	|-Nullable<CopyAchievementDefinitionByAchievementIdOptions>.Box
	|-Nullable<CopyAchievementDefinitionV2ByAchievementIdOptions>.Box
	|-Nullable<CopyActiveSessionHandleOptions>.Box
	|-Nullable<CopyIdTokenOptions>.Box
	|-Nullable<CopyIdTokenOptions>.Box
	|-Nullable<CopyLeaderboardDefinitionByLeaderboardIdOptions>.Box
	|-Nullable<CopyLeaderboardRecordByUserIdOptions>.Box
	|-Nullable<CopyLobbyDetailsHandleByInviteIdOptions>.Box
	|-Nullable<CopyLobbyDetailsHandleByUiEventIdOptions>.Box
	|-Nullable<CopyProductUserInfoOptions>.Box
	|-Nullable<CopySessionHandleByInviteIdOptions>.Box
	|-Nullable<CopySessionHandleByUiEventIdOptions>.Box
	|-Nullable<CopySessionHandleForPresenceOptions>.Box
	|-Nullable<CreateDeviceIdOptions>.Box
	|-Nullable<CreatePresenceModificationOptions>.Box
	|-Nullable<CreateUserOptions>.Box
	|-Nullable<DataKey>.Box
	|-Nullable<DateTime>.Box
	|-Nullable<DeleteCacheOptions>.Box
	|-Nullable<DeleteCacheOptions>.Box
	|-Nullable<DeletePersistentAuthOptions>.Box
	|-Nullable<DeleteSnapshotOptions>.Box
	|-Nullable<DestroySessionOptions>.Box
	|-Nullable<DumpSessionStateOptions>.Box
	|-Nullable<EndSessionOptions>.Box
	|-Nullable<EventDispatcherGate>.Box
	|-Nullable<GCHandle>.Box
	|-Nullable<GetBlockedUsersCountOptions>.Box
	|-Nullable<GetEntitlementsCountOptions>.Box
	|-Nullable<GetFileMetadataCountOptions>.Box
	|-Nullable<GetFileMetadataCountOptions>.Box
	|-Nullable<GetFriendsCountOptions>.Box
	|-Nullable<GetFriendsExclusiveInputOptions>.Box
	|-Nullable<GetFriendsVisibleOptions>.Box
	|-Nullable<GetInviteCountOptions>.Box
	|-Nullable<GetInviteCountOptions>.Box
	|-Nullable<GetLastRedeemedEntitlementsCountOptions>.Box
	|-Nullable<GetLeaderboardUserScoreCountOptions>.Box
	|-Nullable<GetOfferCountOptions>.Box
	|-Nullable<GetPermissionsCountOptions>.Box
	|-Nullable<GetPlayerAchievementCountOptions>.Box
	|-Nullable<GetPlayerSanctionCountOptions>.Box
	|-Nullable<GetProductUserExternalAccountCountOptions>.Box
	|-Nullable<GetStatCountOptions>.Box
	|-Nullable<GetTransactionCountOptions>.Box
	|-Nullable<GetUnlockedAchievementCountOptions>.Box
	|-Nullable<HideFriendsOptions>.Box
	|-Nullable<long>.Box
	|-Nullable<IntPtr>.Box
	|-Nullable<InventoryItemCreateSubItemOptions>.Box
	|-Nullable<InventoryItemDeleteSubItemOptions>.Box
	|-Nullable<InventoryItemGetSubItemOptions>.Box
	|-Nullable<InventoryItemSetKeyOptions>.Box
	|-Nullable<InventoryItemSetValueAsDoubleSetOptions>.Box
	|-Nullable<InventoryItemSetValueAsInt64Options>.Box
	|-Nullable<InventoryItemSetValueAsInt64SetOptions>.Box
	|-Nullable<InventoryItemSetValueAsStringOptions>.Box
	|-Nullable<InventoryItemSetValueAsStringSetOptions>.Box
	|-Nullable<InventoryItemSetValueAsTimestampOptions>.Box
	|-Nullable<LobbyDetailsCopyAttributeByKeyOptions>.Box
	|-Nullable<LobbyDetailsCopyMemberInfoOptions>.Box
	|-Nullable<LobbyDetailsGetMemberAttributeCountOptions>.Box
	|-Nullable<LobbyModificationRemoveAttributeOptions>.Box
	|-Nullable<LobbyModificationRemoveMemberAttributeOptions>.Box
	|-Nullable<LobbyModificationSetAllowedPlatformIdsOptions>.Box
	|-Nullable<LobbyModificationSetBucketIdOptions>.Box
	|-Nullable<LobbySearchFindOptions>.Box
	|-Nullable<LobbySearchSetLobbyIdOptions>.Box
	|-Nullable<LobbySearchSetTargetUserIdOptions>.Box
	|-Nullable<LogPlayerDespawnOptions>.Box
	|-Nullable<LogoutOptions>.Box
	|-Nullable<LogoutOptions>.Box
	|-Nullable<ParseConnectStringOptions>.Box
	|-Nullable<PrePresentOptions>.Box
	|-Nullable<PresenceModificationDataRecordId>.Box
	|-Nullable<PresenceModificationDeleteDataOptions>.Box
	|-Nullable<PresenceModificationSetDataOptions>.Box
	|-Nullable<PresenceModificationSetJoinInfoOptions>.Box
	|-Nullable<PresenceModificationSetRawRichTextOptions>.Box
	|-Nullable<QueryFileListOptions>.Box
	|-Nullable<QueryFriendsOptions>.Box
	|-Nullable<QueryInvitesOptions>.Box
	|-Nullable<QueryInvitesOptions>.Box
	|-Nullable<QueryPermissionsOptions>.Box
	|-Nullable<RegisterPlatformAudioUserOptions>.Box
	|-Nullable<RegisterPlatformUserOptions>.Box
	|-Nullable<SessionDetailsCopySessionAttributeByKeyOptions>.Box
	|-Nullable<SessionModificationRemoveAttributeOptions>.Box
	|-Nullable<SessionModificationSetAllowedPlatformIdsOptions>.Box
	|-Nullable<SessionModificationSetBucketIdOptions>.Box
	|-Nullable<SessionModificationSetHostAddressOptions>.Box
	|-Nullable<SessionSearchFindOptions>.Box
	|-Nullable<SessionSearchSetSessionIdOptions>.Box
	|-Nullable<SessionSearchSetTargetUserIdOptions>.Box
	|-Nullable<SetGameSessionIdOptions>.Box
	|-Nullable<ShowFriendsOptions>.Box
	|-Nullable<SpanId>.Box
	|-Nullable<SqlBinary>.Box
	|-Nullable<StartSessionOptions>.Box
	|-Nullable<SteamIAPVerifyPurchaseOptionsPlatformSpecificOptions>.Box
	|-Nullable<SwitchIAPVerifyPurchaseOptionsPlatformSpecificOptions>.Box
	|-Nullable<TimeSpan>.Box
	|-Nullable<ulong>.Box
	|-Nullable<UIntPtr>.Box
	|-Nullable<UnlinkAccountOptions>.Box
	|-Nullable<UnregisterClientOptions>.Box
	|-Nullable<UnregisterPeerOptions>.Box
	|-Nullable<UnregisterPlatformAudioUserOptions>.Box
	|-Nullable<UnregisterPlatformUserOptions>.Box
	|-Nullable<UpdateLobbyOptions>.Box
	|-Nullable<UpdateSessionModificationOptions>.Box
	|-Nullable<UpdateSessionOptions>.Box
	|-Nullable<WindowsRTCOptionsPlatformSpecificOptions>.Box
	|-Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReport>.Box
	|-Nullable<XSXOptionsSystemSpecificOptions>.Box
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReport>.Box
	|-Nullable<XboxOneGDKOptionsSystemSpecificOptions>.Box
	|-Nullable<C.sentry_value_t>.Box
	|
	|-RVA: 0x148DA30 Offset: 0x148CC30 VA: 0x18148DA30
	|-Nullable<ActiveSessionCopyInfoOptions>.Box
	|-Nullable<ActiveSessionGetRegisteredPlayerCountOptions>.Box
	|-Nullable<AddNotifyAchievementsUnlockedOptions>.Box
	|-Nullable<AddNotifyAchievementsUnlockedV2Options>.Box
	|-Nullable<AddNotifyAudioDevicesChangedOptions>.Box
	|-Nullable<AddNotifyAuthExpirationOptions>.Box
	|-Nullable<AddNotifyBlockedUsersUpdateOptions>.Box
	|-Nullable<AddNotifyClientActionRequiredOptions>.Box
	|-Nullable<AddNotifyClientAuthStatusChangedOptions>.Box
	|-Nullable<AddNotifyClientIntegrityViolatedOptions>.Box
	|-Nullable<AddNotifyCustomInviteAcceptedOptions>.Box
	|-Nullable<AddNotifyCustomInviteReceivedOptions>.Box
	|-Nullable<AddNotifyCustomInviteRejectedOptions>.Box
	|-Nullable<AddNotifyDisplaySettingsUpdatedOptions>.Box
	|-Nullable<AddNotifyFriendsUpdateOptions>.Box
	|-Nullable<AddNotifyIncomingPacketQueueFullOptions>.Box
	|-Nullable<AddNotifyJoinGameAcceptedOptions>.Box
	|-Nullable<AddNotifyJoinLobbyAcceptedOptions>.Box
	|-Nullable<AddNotifyJoinSessionAcceptedOptions>.Box
	|-Nullable<AddNotifyLeaveLobbyRequestedOptions>.Box
	|-Nullable<AddNotifyLeaveSessionRequestedOptions>.Box
	|-Nullable<AddNotifyLobbyInviteAcceptedOptions>.Box
	|-Nullable<AddNotifyLobbyInviteReceivedOptions>.Box
	|-Nullable<AddNotifyLobbyInviteRejectedOptions>.Box
	|-Nullable<AddNotifyLobbyMemberStatusReceivedOptions>.Box
	|-Nullable<AddNotifyLobbyMemberUpdateReceivedOptions>.Box
	|-Nullable<AddNotifyLobbyUpdateReceivedOptions>.Box
	|-Nullable<AddNotifyLoginStatusChangedOptions>.Box
	|-Nullable<AddNotifyLoginStatusChangedOptions>.Box
	|-Nullable<AddNotifyMemoryMonitorOptions>.Box
	|-Nullable<AddNotifyMessageToClientOptions>.Box
	|-Nullable<AddNotifyMessageToPeerOptions>.Box
	|-Nullable<AddNotifyMessageToServerOptions>.Box
	|-Nullable<AddNotifyOnPresenceChangedOptions>.Box
	|-Nullable<AddNotifyPeerActionRequiredOptions>.Box
	|-Nullable<AddNotifyPeerAuthStatusChangedOptions>.Box
	|-Nullable<AddNotifyPermissionsUpdateReceivedOptions>.Box
	|-Nullable<AddNotifyRequestToJoinAcceptedOptions>.Box
	|-Nullable<AddNotifyRequestToJoinReceivedOptions>.Box
	|-Nullable<AddNotifyRequestToJoinRejectedOptions>.Box
	|-Nullable<AddNotifyRequestToJoinResponseReceivedOptions>.Box
	|-Nullable<AddNotifySendCustomNativeInviteRequestedOptions>.Box
	|-Nullable<AddNotifySendLobbyNativeInviteRequestedOptions>.Box
	|-Nullable<AddNotifySendSessionNativeInviteRequestedOptions>.Box
	|-Nullable<AddNotifySessionInviteAcceptedOptions>.Box
	|-Nullable<AddNotifySessionInviteReceivedOptions>.Box
	|-Nullable<AddNotifySessionInviteRejectedOptions>.Box
	|-Nullable<AddNotifyUserLoginStatusChangedOptions>.Box
	|-Nullable<bool>.Box
	|-Nullable<byte>.Box
	|-Nullable<ClearUserPreLogoutCallbackOptions>.Box
	|-Nullable<CopyUserAuthTokenOptions>.Box
	|-Nullable<CreateIntegratedPlatformOptionsContainerOptions>.Box
	|-Nullable<DeleteDeviceIdOptions>.Box
	|-Nullable<EndSessionOptions>.Box
	|-Nullable<EndSessionOptions>.Box
	|-Nullable<GetAchievementDefinitionCountOptions>.Box
	|-Nullable<GetAudioInputDevicesCountOptions>.Box
	|-Nullable<GetAudioOutputDevicesCountOptions>.Box
	|-Nullable<GetDesktopCrossplayStatusOptions>.Box
	|-Nullable<GetInputDevicesCountOptions>.Box
	|-Nullable<GetLeaderboardDefinitionCountOptions>.Box
	|-Nullable<GetLeaderboardRecordCountOptions>.Box
	|-Nullable<GetLocalPlatformTypeOptions>.Box
	|-Nullable<GetNATTypeOptions>.Box
	|-Nullable<GetOutputDevicesCountOptions>.Box
	|-Nullable<GetPacketQueueInfoOptions>.Box
	|-Nullable<GetPortRangeOptions>.Box
	|-Nullable<GetRelayControlOptions>.Box
	|-Nullable<GetToggleFriendsButtonOptions>.Box
	|-Nullable<GetToggleFriendsKeyOptions>.Box
	|-Nullable<InventoryItemGetKeyOptions>.Box
	|-Nullable<InventoryItemGetSubItemsCountOptions>.Box
	|-Nullable<InventoryItemGetValueAsBoolOptions>.Box
	|-Nullable<InventoryItemGetValueAsDoubleOptions>.Box
	|-Nullable<InventoryItemGetValueAsInt64Options>.Box
	|-Nullable<InventoryItemGetValueAsStringOptions>.Box
	|-Nullable<InventoryItemGetValueAsTimestampOptions>.Box
	|-Nullable<InventoryItemGetValueCountOptions>.Box
	|-Nullable<InventoryItemGetValueTypeOptions>.Box
	|-Nullable<InventoryItemSetValueAsBoolOptions>.Box
	|-Nullable<IsSocialOverlayPausedOptions>.Box
	|-Nullable<LobbyDetailsCopyInfoOptions>.Box
	|-Nullable<LobbyDetailsGetAttributeCountOptions>.Box
	|-Nullable<LobbyDetailsGetLobbyOwnerOptions>.Box
	|-Nullable<LobbyDetailsGetMemberCountOptions>.Box
	|-Nullable<LobbyModificationSetInvitesAllowedOptions>.Box
	|-Nullable<LobbySearchGetSearchResultCountOptions>.Box
	|-Nullable<PS5OptionsInitOptions>.Box
	|-Nullable<PauseSocialOverlayOptions>.Box
	|-Nullable<QueryAgeGateOptions>.Box
	|-Nullable<QueryInputDevicesInformationOptions>.Box
	|-Nullable<QueryNATTypeOptions>.Box
	|-Nullable<QueryOutputDevicesInformationOptions>.Box
	|-Nullable<sbyte>.Box
	|-Nullable<SessionDetailsCopyInfoOptions>.Box
	|-Nullable<SessionDetailsGetSessionAttributeCountOptions>.Box
	|-Nullable<SessionModificationSetInvitesAllowedOptions>.Box
	|-Nullable<SessionModificationSetJoinInProgressAllowedOptions>.Box
	|-Nullable<SessionSearchGetSearchResultCountOptions>.Box
	|-Nullable<SetUserPreLogoutCallbackOptions>.Box
	|-Nullable<TransactionGetEntitlementsCountOptions>.Box
	|
	|-RVA: 0xB49FE0 Offset: 0xB491E0 VA: 0x180B49FE0
	|-Nullable<ActiveSessionGetRegisteredPlayerByIndexOptions>.Box
	|-Nullable<CopyAchievementDefinitionByIndexOptions>.Box
	|-Nullable<CopyAchievementDefinitionV2ByIndexOptions>.Box
	|-Nullable<CopyInputDeviceInformationByIndexOptions>.Box
	|-Nullable<CopyLeaderboardDefinitionByIndexOptions>.Box
	|-Nullable<CopyLeaderboardRecordByIndexOptions>.Box
	|-Nullable<CopyOutputDeviceInformationByIndexOptions>.Box
	|-Nullable<CreateLobbySearchOptions>.Box
	|-Nullable<CreateSessionSearchOptions>.Box
	|-Nullable<EndSnapshotOptions>.Box
	|-Nullable<GetAudioInputDeviceByIndexOptions>.Box
	|-Nullable<GetAudioOutputDeviceByIndexOptions>.Box
	|-Nullable<GetProtectMessageOutputLengthOptions>.Box
	|-Nullable<GetProtectMessageOutputLengthOptions>.Box
	|-Nullable<int>.Box
	|-Nullable<Int32Enum>.Box
	|-Nullable<InventoryItemGetDoubleSetValueByIndexOptions>.Box
	|-Nullable<InventoryItemGetInt64SetValueByIndexOptions>.Box
	|-Nullable<InventoryItemGetStringSetValueByIndexOptions>.Box
	|-Nullable<InventoryItemGetSubItemByIndexOptions>.Box
	|-Nullable<LobbyDetailsCopyAttributeByIndexOptions>.Box
	|-Nullable<LobbyDetailsGetMemberByIndexOptions>.Box
	|-Nullable<LobbyModificationSetMaxMembersOptions>.Box
	|-Nullable<LobbyModificationSetPermissionLevelOptions>.Box
	|-Nullable<LobbySearchCopySearchResultByIndexOptions>.Box
	|-Nullable<LobbySearchSetMaxResultsOptions>.Box
	|-Nullable<LogGameRoundEndOptions>.Box
	|-Nullable<PollStatusOptions>.Box
	|-Nullable<PresenceModificationSetStatusOptions>.Box
	|-Nullable<SessionDetailsCopySessionAttributeByIndexOptions>.Box
	|-Nullable<SessionModificationSetMaxPlayersOptions>.Box
	|-Nullable<SessionModificationSetPermissionLevelOptions>.Box
	|-Nullable<SessionSearchCopySearchResultByIndexOptions>.Box
	|-Nullable<SessionSearchSetMaxResultsOptions>.Box
	|-Nullable<SetDisplayPreferenceOptions>.Box
	|-Nullable<SetRelayControlOptions>.Box
	|-Nullable<SetToggleFriendsButtonOptions>.Box
	|-Nullable<SetToggleFriendsKeyOptions>.Box
	|-Nullable<SubmitSnapshotOptions>.Box
	|-Nullable<TransactionCopyEntitlementByIndexOptions>.Box
	|-Nullable<uint>.Box
	|-Nullable<XSXPrePresentAdditionalData>.Box
	|-Nullable<XboxOneGDKPrePresentAdditionalData>.Box
	|
	|-RVA: 0x148DC60 Offset: 0x148CE60 VA: 0x18148DC60
	|-Nullable<ActiveSessionInfo>.Box
	|
	|-RVA: 0xB49F10 Offset: 0xB49110 VA: 0x180B49F10
	|-Nullable<ActiveSessionInfoInternal>.Box
	|-Nullable<BestDisplayName>.Box
	|-Nullable<CatalogReleaseInternal>.Box
	|-Nullable<CreateUserCallbackInfo>.Box
	|-Nullable<Credentials>.Box
	|-Nullable<CustomInviteRejectedCallbackInfo>.Box
	|-Nullable<Entitlement>.Box
	|-Nullable<FileMetadataInternal>.Box
	|-Nullable<JoinGameAcceptedCallbackInfo>.Box
	|-Nullable<JoinLobbyByIdOptions>.Box
	|-Nullable<JoinLobbyOptions>.Box
	|-Nullable<JoinRoomCallbackInfo>.Box
	|-Nullable<LobbyInviteAcceptedCallbackInfo>.Box
	|-Nullable<LobbyInviteRejectedCallbackInfo>.Box
	|-Nullable<ModIdentifier>.Box
	|-Nullable<OnCustomInviteAcceptedCallbackInfo>.Box
	|-Nullable<OnCustomInviteReceivedCallbackInfo>.Box
	|-Nullable<OnIncomingPacketQueueFullInfo>.Box
	|-Nullable<PS4SubmitGraphicsCommandsCallbackInfo>.Box
	|-Nullable<ParticipantUpdatedCallbackInfo>.Box
	|-Nullable<ParticipantUpdatedCallbackInfo>.Box
	|-Nullable<PinGrantInfoInternal>.Box
	|-Nullable<PlayerSanctionInternal>.Box
	|-Nullable<QueryJoinRoomTokenCompleteCallbackInfo>.Box
	|-Nullable<QueryUserInfoByDisplayNameCallbackInfo>.Box
	|-Nullable<ReadFileOptions>.Box
	|-Nullable<ReadFileOptions>.Box
	|-Nullable<RegisterClientOptions>.Box
	|-Nullable<SendAudioOptions>.Box
	|-Nullable<SendPlayerBehaviorReportOptions>.Box
	|-Nullable<SessionInviteAcceptedCallbackInfo>.Box
	|-Nullable<SessionInviteRejectedCallbackInfo>.Box
	|-Nullable<StatInternal>.Box
	|-Nullable<SteamIAPVerifyPurchaseOptions>.Box
	|-Nullable<SwitchIAPVerifyPurchaseOptions>.Box
	|-Nullable<UpdateReceivingVolumeCallbackInfo>.Box
	|-Nullable<UpdateSendingCallbackInfo>.Box
	|-Nullable<UpdateSendingCallbackInfo>.Box
	|-Nullable<UpdateSendingVolumeCallbackInfo>.Box
	|-Nullable<UserPreLogoutCallbackInfo>.Box
	|-Nullable<WriteFileOptions>.Box
	|-Nullable<XSXXBLOptions>.Box
	|-Nullable<XboxOneGDKXBLOptions>.Box
	|
	|-RVA: 0xB49EA0 Offset: 0xB490A0 VA: 0x180B49EA0
	|-Nullable<AddNotifyAudioBeforeRenderOptions>.Box
	|-Nullable<AddProgressionOptions>.Box
	|-Nullable<AndroidInitializeOptionsSystemInitializeOptions>.Box
	|-Nullable<AttributeInternal>.Box
	|-Nullable<AudioInputDeviceInfo>.Box
	|-Nullable<AudioInputDeviceInfoInternal>.Box
	|-Nullable<AudioOutputDeviceInfo>.Box
	|-Nullable<AudioOutputDeviceInfoInternal>.Box
	|-Nullable<BeginPlayerSessionOptionsAccountId>.Box
	|-Nullable<CatalogRelease>.Box
	|-Nullable<CheckoutOptions>.Box
	|-Nullable<CheckpointOptions>.Box
	|-Nullable<CloseOptions>.Box
	|-Nullable<CopyBestDisplayNameWithPlatformOptions>.Box
	|-Nullable<CopyEntitlementByNameAndIndexOptions>.Box
	|-Nullable<CopyExternalUserInfoByAccountIdOptions>.Box
	|-Nullable<CopyExternalUserInfoByAccountTypeOptions>.Box
	|-Nullable<CopyExternalUserInfoByIndexOptions>.Box
	|-Nullable<CopyItemImageInfoByIndexOptions>.Box
	|-Nullable<CopyItemReleaseByIndexOptions>.Box
	|-Nullable<CopyOfferImageInfoByIndexOptions>.Box
	|-Nullable<CopyOfferItemByIndexOptions>.Box
	|-Nullable<CopyPlayerAchievementByAchievementIdOptions>.Box
	|-Nullable<CopyPlayerAchievementByIndexOptions>.Box
	|-Nullable<CreateLobbyCallbackInfo>.Box
	|-Nullable<CreateOptions>.Box
	|-Nullable<CreatePlayerSanctionAppealCallbackInfo>.Box
	|-Nullable<CreatePlayerSanctionAppealOptions>.Box
	|-Nullable<CreateUserCallbackInfo>.Box
	|-Nullable<CreateUserOptions>.Box
	|-Nullable<DeleteCacheCallbackInfo>.Box
	|-Nullable<DeleteCacheCallbackInfo>.Box
	|-Nullable<DeleteFileCallbackInfo>.Box
	|-Nullable<DeleteSnapshotCallbackInfo>.Box
	|-Nullable<DestroyLobbyCallbackInfo>.Box
	|-Nullable<DuplicateFileCallbackInfo>.Box
	|-Nullable<DuplicateFileOptions>.Box
	|-Nullable<EndPlayerSessionOptions>.Box
	|-Nullable<EndPlayerSessionOptionsAccountId>.Box
	|-Nullable<FinalizeDeferredUserLogoutOptions>.Box
	|-Nullable<GetExternalAccountMappingsOptions>.Box
	|-Nullable<GetProductUserIdMappingOptions>.Box
	|-Nullable<HideFriendsCallbackInfo>.Box
	|-Nullable<IOSCredentialsSystemAuthCredentialsOptions>.Box
	|-Nullable<IdTokenInternal>.Box
	|-Nullable<IdTokenInternal>.Box
	|-Nullable<IngestStatOptions>.Box
	|-Nullable<InputDeviceInformation>.Box
	|-Nullable<InputDeviceInformationInternal>.Box
	|-Nullable<JoinLobbyAcceptedCallbackInfo>.Box
	|-Nullable<JoinLobbyByIdCallbackInfo>.Box
	|-Nullable<JoinLobbyCallbackInfo>.Box
	|-Nullable<JoinSessionAcceptedCallbackInfo>.Box
	|-Nullable<JsonPosition>.Box
	|-Nullable<KeyImageInfo>.Box
	|-Nullable<KickMemberCallbackInfo>.Box
	|-Nullable<KickMemberOptions>.Box
	|-Nullable<LeaderboardRecord>.Box
	|-Nullable<LeaderboardUserScoreInternal>.Box
	|-Nullable<LeaveLobbyCallbackInfo>.Box
	|-Nullable<LeaveLobbyRequestedCallbackInfo>.Box
	|-Nullable<LeaveSessionRequestedCallbackInfo>.Box
	|-Nullable<LinkAccountCallbackInfo>.Box
	|-Nullable<LinkAccountOptions>.Box
	|-Nullable<LobbyDetailsMemberInfoInternal>.Box
	|-Nullable<LobbyMemberUpdateReceivedCallbackInfo>.Box
	|-Nullable<LogEventOptions>.Box
	|-Nullable<LogMessage>.Box
	|-Nullable<LogPlayerUseAbilityOptions>.Box
	|-Nullable<LoginStatusChangedCallbackInfo>.Box
	|-Nullable<LoginStatusChangedCallbackInfo>.Box
	|-Nullable<LogoutCallbackInfo>.Box
	|-Nullable<LogoutCallbackInfo>.Box
	|-Nullable<ModInfoInternal>.Box
	|-Nullable<OnAchievementsUnlockedCallbackInfo>.Box
	|-Nullable<OnClientAuthStatusChangedCallbackInfo>.Box
	|-Nullable<OnClientIntegrityViolatedCallbackInfo>.Box
	|-Nullable<OnCreateCompleteCallbackInfo>.Box
	|-Nullable<OnMessageToServerCallbackInfo>.Box
	|-Nullable<OnOpenCompleteCallbackInfo>.Box
	|-Nullable<OnQueryLeaderboardRanksCompleteCallbackInfo>.Box
	|-Nullable<OnQueryNATTypeCompleteInfo>.Box
	|-Nullable<OnRegisterPlatformUserCallbackInfo>.Box
	|-Nullable<OnRequestToJoinAcceptedCallbackInfo>.Box
	|-Nullable<OnRequestToJoinRejectedCallbackInfo>.Box
	|-Nullable<OnSetInputDeviceSettingsCallbackInfo>.Box
	|-Nullable<OnSetOutputDeviceSettingsCallbackInfo>.Box
	|-Nullable<OnUnregisterPlatformUserCallbackInfo>.Box
	|-Nullable<OpenOptions>.Box
	|-Nullable<Options>.Box
	|-Nullable<OutputDeviceInformation>.Box
	|-Nullable<OutputDeviceInformationInternal>.Box
	|-Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.Box
	|-Nullable<PS4OptionsInitOptions>.Box
	|-Nullable<PS5IntegratedPlatformOptionsContainerAddOptions>.Box
	|-Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.Box
	|-Nullable<PermissionStatusInternal>.Box
	|-Nullable<PresenceChangedCallbackInfo>.Box
	|-Nullable<PromoteMemberCallbackInfo>.Box
	|-Nullable<PromoteMemberOptions>.Box
	|-Nullable<ProtectMessageOptions>.Box
	|-Nullable<QueryDefinitionsOptions>.Box
	|-Nullable<QueryEntitlementsCallbackInfo>.Box
	|-Nullable<QueryEntitlementsOptions>.Box
	|-Nullable<QueryExternalAccountMappingsCallbackInfo>.Box
	|-Nullable<QueryExternalAccountMappingsOptions>.Box
	|-Nullable<QueryFileCallbackInfo>.Box
	|-Nullable<QueryFileCallbackInfo>.Box
	|-Nullable<QueryFriendsCallbackInfo>.Box
	|-Nullable<QueryInvitesCallbackInfo>.Box
	|-Nullable<QueryInvitesCallbackInfo>.Box
	|-Nullable<QueryOffersCallbackInfo>.Box
	|-Nullable<QueryOwnershipOptions>.Box
	|-Nullable<QueryOwnershipTokenOptions>.Box
	|-Nullable<QueryProductUserIdMappingsCallbackInfo>.Box
	|-Nullable<QueryProductUserIdMappingsOptions>.Box
	|-Nullable<QueryUserInfoByExternalAccountOptions>.Box
	|-Nullable<ReceiveMessageFromClientOptions>.Box
	|-Nullable<ReceiveMessageFromPeerOptions>.Box
	|-Nullable<RejectInviteCallbackInfo>.Box
	|-Nullable<RequestPermissionsCallbackInfo>.Box
	|-Nullable<RequestToJoinReceivedCallbackInfo>.Box
	|-Nullable<SendInviteCallbackInfo>.Box
	|-Nullable<SendInviteOptions>.Box
	|-Nullable<SendInviteOptions>.Box
	|-Nullable<SessionDetailsAttributeInternal>.Box
	|-Nullable<SetAudioInputSettingsOptions>.Box
	|-Nullable<SetAudioOutputSettingsOptions>.Box
	|-Nullable<SetInputDeviceSettingsOptions>.Box
	|-Nullable<SetParticipantHardMuteOptions>.Box
	|-Nullable<SetPresenceCallbackInfo>.Box
	|-Nullable<SetUserLoginStatusOptions>.Box
	|-Nullable<ShowFriendsCallbackInfo>.Box
	|-Nullable<TransferDeviceIdAccountCallbackInfo>.Box
	|-Nullable<TransferDeviceIdAccountOptions>.Box
	|-Nullable<UnlinkAccountCallbackInfo>.Box
	|-Nullable<UnlockedAchievementInternal>.Box
	|-Nullable<UnprotectMessageOptions>.Box
	|-Nullable<UnregisterPlayersCallbackInfo>.Box
	|-Nullable<UpdateLobbyCallbackInfo>.Box
	|-Nullable<UpdateParentEmailCallbackInfo>.Box
	|-Nullable<UpdateReceivingVolumeOptions>.Box
	|-Nullable<UpdateSendingOptions>.Box
	|-Nullable<UpdateSendingOptions>.Box
	|-Nullable<UpdateSendingVolumeOptions>.Box
	|-Nullable<UserTokenInternal>.Box
	|-Nullable<VerifyIdTokenOptions>.Box
	|-Nullable<VerifyIdTokenOptions>.Box
	|-Nullable<WindowsRTCOptions>.Box
	|-Nullable<XSXMemoryMonitorCallbackInfo>.Box
	|-Nullable<XSXSubmitGraphicsCommandsCallbackInfo>.Box
	|-Nullable<XSXXBLOptionsInitOptionsInternal>.Box
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfo>.Box
	|-Nullable<XboxOneGDKSubmitGraphicsCommandsCallbackInfo>.Box
	|-Nullable<XboxOneGDKXBLOptionsInitOptionsInternal>.Box
	|
	|-RVA: 0xB49E10 Offset: 0xB49010 VA: 0x180B49E10
	|-Nullable<AddNotifyPeerConnectionClosedOptions>.Box
	|-Nullable<AddNotifyPeerConnectionEstablishedOptions>.Box
	|-Nullable<AddNotifyPeerConnectionInterruptedOptions>.Box
	|-Nullable<AddNotifyPeerConnectionRequestOptions>.Box
	|-Nullable<AndroidIAPVerifyPurchaseOptions>.Box
	|-Nullable<AudioBeforeSendCallbackInfo>.Box
	|-Nullable<BestDisplayNameInternal>.Box
	|-Nullable<BlockParticipantCallbackInfo>.Box
	|-Nullable<CloseConnectionsOptions>.Box
	|-Nullable<DataReceivedCallbackInfo>.Box
	|-Nullable<DefinitionInternal>.Box
	|-Nullable<EGSDLCVerifyPurchaseOptions>.Box
	|-Nullable<EGSIAPVerifyPurchaseOptions>.Box
	|-Nullable<EntitlementInternal>.Box
	|-Nullable<ExternalAccountInfoInternal>.Box
	|-Nullable<IOSIAPVerifyPurchaseOptions>.Box
	|-Nullable<JoinRoomOptions>.Box
	|-Nullable<LoginOptions>.Box
	|-Nullable<ModIdentifierInternal>.Box
	|-Nullable<OnAchievementsUnlockedCallbackV2Info>.Box
	|-Nullable<PS4Options>.Box
	|-Nullable<PS4PrePresentOptionsPlatformSpecificData>.Box
	|-Nullable<PS5PrePresentOptionsPlatformSpecificData>.Box
	|-Nullable<PacketQueueInfo>.Box
	|-Nullable<PermissionsUpdateReceivedCallbackInfo>.Box
	|-Nullable<QueryUserInfoByExternalAccountCallbackInfo>.Box
	|-Nullable<ReadFileDataCallbackInfo>.Box
	|-Nullable<ReadFileDataCallbackInfo>.Box
	|-Nullable<RegisterPeerOptions>.Box
	|-Nullable<SendCustomNativeInviteRequestedCallbackInfo>.Box
	|-Nullable<SendLobbyNativeInviteRequestedCallbackInfo>.Box
	|-Nullable<SendSessionNativeInviteRequestedCallbackInfo>.Box
	|-Nullable<SteamDLCVerifyPurchaseOptions>.Box
	|-Nullable<UpdateParticipantVolumeCallbackInfo>.Box
	|-Nullable<UpdateReceivingCallbackInfo>.Box
	|-Nullable<UpdateReceivingCallbackInfo>.Box
	|-Nullable<UserInfoData>.Box
	|-Nullable<UserLoginStatusChangedCallbackInfo>.Box
	|-Nullable<XSXDLCVerifyPurchaseOptions>.Box
	|-Nullable<XSXIAPVerifyPurchaseOptions>.Box
	|-Nullable<XSXIntegratedPlatformOptionsContainerAddOptions>.Box
	|-Nullable<XboxOneGDKDLCVerifyPurchaseOptions>.Box
	|-Nullable<XboxOneGDKIAPVerifyPurchaseOptions>.Box
	|-Nullable<XboxOneGDKIntegratedPlatformOptionsContainerAddOptions>.Box
	|
	|-RVA: 0x148DB30 Offset: 0x148CD30 VA: 0x18148DB30
	|-Nullable<AndroidInitializeOptions>.Box
	|
	|-RVA: 0xB4A240 Offset: 0xB49440 VA: 0x180B4A240
	|-Nullable<Announcement>.Box
	|-Nullable<AttributeData>.Box
	|-Nullable<AttributeData>.Box
	|-Nullable<CreateSessionModificationOptions>.Box
	|-Nullable<IOSCredentials>.Box
	|-Nullable<InitializeThreadAffinity>.Box
	|-Nullable<InstallModOptions>.Box
	|-Nullable<LogPlayerUseWeaponOptions>.Box
	|-Nullable<LoginOptions>.Box
	|-Nullable<OnIncomingConnectionRequestInfo>.Box
	|-Nullable<OnPeerConnectionInterruptedInfo>.Box
	|-Nullable<PS4DLCVerifyPurchaseOptions>.Box
	|-Nullable<PS4IAPVerifyPurchaseOptions>.Box
	|-Nullable<PS5DLCVerifyPurchaseOptions>.Box
	|-Nullable<PS5IAPVerifyPurchaseOptions>.Box
	|-Nullable<Stat>.Box
	|-Nullable<XSXPrePresentOptions>.Box
	|-Nullable<XboxOneGDKPrePresentOptions>.Box
	|
	|-RVA: 0x148DA80 Offset: 0x148CC80 VA: 0x18148DA80
	|-Nullable<Attribute>.Box
	|-Nullable<CatalogItem>.Box
	|-Nullable<CreateLobbyOptions>.Box
	|-Nullable<DefinitionV2>.Box
	|-Nullable<InfoInternal>.Box
	|-Nullable<LobbyModificationAddAttributeOptions>.Box
	|-Nullable<LobbyModificationAddMemberAttributeOptions>.Box
	|-Nullable<LobbySearchSetParameterOptions>.Box
	|-Nullable<PS4InitializeOptionsSystemInitializeOptions>.Box
	|-Nullable<PlayerAchievement>.Box
	|-Nullable<PlayerAchievementInternal>.Box
	|-Nullable<SessionDetailsAttribute>.Box
	|-Nullable<SessionDetailsInfo>.Box
	|-Nullable<SessionModificationAddAttributeOptions>.Box
	|-Nullable<SessionSearchSetParameterOptions>.Box
	|-Nullable<Token>.Box
	|
	|-RVA: 0x149C400 Offset: 0x149B600 VA: 0x18149C400
	|-Nullable<CatalogItemInternal>.Box
	|-Nullable<Definition>.Box
	|-Nullable<DefinitionV2Internal>.Box
	|-Nullable<IOSLoginOptions>.Box
	|-Nullable<LobbyDetailsInfoInternal>.Box
	|-Nullable<TokenInternal>.Box
	|-Nullable<VerifyIdTokenCallbackInfo>.Box
	|-Nullable<VerifyUserAuthOptions>.Box
	|
	|-RVA: 0x149C300 Offset: 0x149B500 VA: 0x18149C300
	|-Nullable<CatalogOffer>.Box
	|-Nullable<CatalogOfferInternal>.Box
	|
	|-RVA: 0x149C2B0 Offset: 0x149B4B0 VA: 0x18149C2B0
	|-Nullable<char>.Box
	|-Nullable<short>.Box
	|-Nullable<Int16Enum>.Box
	|-Nullable<ushort>.Box
	|-Nullable<UInt16Enum>.Box
	|
	|-RVA: 0x149C250 Offset: 0x149B450 VA: 0x18149C250
	|-Nullable<Color>.Box
	|-Nullable<Guid>.Box
	|-Nullable<Quat>.Box
	|-Nullable<QuatInternal>.Box
	|-Nullable<Rect>.Box
	|-Nullable<SentryId>.Box
	|
	|-RVA: 0xB4A0C0 Offset: 0xB492C0 VA: 0x180B4A0C0
	|-Nullable<CopyUserTokenByIndexOptions>.Box
	|-Nullable<DesktopCrossplayStatusInfo>.Box
	|-Nullable<LocalRTCOptions>.Box
	|-Nullable<PS5OptionsInitOptionsInternal>.Box
	|-Nullable<PageQuery>.Box
	|-Nullable<XSXPrePresentAdditionalDataInternal>.Box
	|-Nullable<XboxOneGDKPrePresentAdditionalDataInternal>.Box
	|
	|-RVA: 0x14AC4F0 Offset: 0x14AB6F0 VA: 0x1814AC4F0
	|-Nullable<Definition>.Box
	|-Nullable<Info>.Box
	|-Nullable<InstallModCallbackInfo>.Box
	|-Nullable<LinkAccountCallbackInfo>.Box
	|-Nullable<LogPlayerTickOptions>.Box
	|-Nullable<OnPeerConnectionEstablishedInfo>.Box
	|-Nullable<OnRemoteConnectionClosedInfo>.Box
	|-Nullable<PS5InitializeOptionsSystemInitializeOptions>.Box
	|-Nullable<QueryLeaderboardUserScoresOptions>.Box
	|-Nullable<QueryStatsOptions>.Box
	|-Nullable<UninstallModCallbackInfo>.Box
	|-Nullable<UpdateModCallbackInfo>.Box
	|
	|-RVA: 0x14AC420 Offset: 0x14AB620 VA: 0x1814AC420
	|-Nullable<DefinitionInternal>.Box
	|-Nullable<LoginCallbackInfo>.Box
	|-Nullable<SendPacketOptions>.Box
	|-Nullable<VerifyIdTokenCallbackInfo>.Box
	|
	|-RVA: 0x14AC5A0 Offset: 0x14AB7A0 VA: 0x1814AC5A0
	|-Nullable<double>.Box
	|-Nullable<InventoryItemSetValueAsDoubleOptions>.Box
	|
	|-RVA: 0x14BC2E0 Offset: 0x14BB4E0 VA: 0x1814BC2E0
	|-Nullable<InitializeOptions>.Box
	|
	|-RVA: 0x14CB160 Offset: 0x14CA360 VA: 0x1814CB160
	|-Nullable<LogEventParamPair>.Box
	|-Nullable<LogEventParamPairParamValue>.Box
	|
	|-RVA: 0x14CB240 Offset: 0x14CA440 VA: 0x1814CB240
	|-Nullable<LogPlayerTakeDamageOptions>.Box
	|
	|-RVA: 0x14DB300 Offset: 0x14DA500 VA: 0x1814DB300
	|-Nullable<Options>.Box
	|
	|-RVA: 0x14DB1A0 Offset: 0x14DA3A0 VA: 0x1814DB1A0
	|-Nullable<PS4InitializeOptions>.Box
	|
	|-RVA: 0x14DB430 Offset: 0x14DA630 VA: 0x1814DB430
	|-Nullable<PS5InitializeOptions>.Box
	|
	|-RVA: 0x14DB590 Offset: 0x14DA790 VA: 0x1814DB590
	|-Nullable<PageResult>.Box
	|-Nullable<Token>.Box
	|-Nullable<Vec3f>.Box
	|-Nullable<Vec3fInternal>.Box
	|-Nullable<Vector3>.Box
	|
	|-RVA: 0x14EC790 Offset: 0x14EB990 VA: 0x1814EC790
	|-Nullable<RectInternal>.Box
	|
	|-RVA: 0x14FBA20 Offset: 0x14FAC20 VA: 0x1814FBA20
	|-Nullable<ReportInputStateOptions>.Box
	|
	|-RVA: 0x14FBB00 Offset: 0x14FAD00 VA: 0x1814FBB00
	|-Nullable<SequencePoint>.Box
	|
	|-RVA: 0x14FBAB0 Offset: 0x14FACB0 VA: 0x1814FBAB0
	|-Nullable<SetPortRangeOptions>.Box
	|
	|-RVA: 0x150B140 Offset: 0x150A340 VA: 0x18150B140
	|-Nullable<float>.Box
	|
	|-RVA: 0x150B040 Offset: 0x150A240 VA: 0x18150B040
	|-Nullable<Touch>.Box
	|
	|-RVA: 0x150B0F0 Offset: 0x150A2F0 VA: 0x18150B0F0
	|-Nullable<Vector2>.Box
	|
	|-RVA: 0xB4A110 Offset: 0xB49310 VA: 0x180B4A110
	|-Nullable<WindowsOptions>.Box
	|-Nullable<XSXOptions>.Box
	|-Nullable<XboxOneGDKOptions>.Box
	|
	|-RVA: 0xB4A2E0 Offset: 0xB494E0 VA: 0x180B4A2E0
	|-Nullable<XSXInitializeOptions>.Box
	|-Nullable<XboxOneGDKInitializeOptions>.Box
	|
	|-RVA: 0xB49C80 Offset: 0xB48E80 VA: 0x180B49C80
	|-Nullable<__Il2CppFullySharedGenericStructType>.Box
	*/

	// RVA: -1 Offset: -1
	private static Nullable<T> Unbox(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB53A80 Offset: 0xB52C80 VA: 0x180B53A80
	|-Nullable<ArraySegment<byte>>.Unbox
	|-Nullable<ValueTuple<object, object>>.Unbox
	|-Nullable<AcceptInviteOptions>.Unbox
	|-Nullable<AcceptRequestToJoinOptions>.Unbox
	|-Nullable<AccountFeatureRestrictedInfoInternal>.Unbox
	|-Nullable<AcknowledgeEventIdOptions>.Unbox
	|-Nullable<AddNotifyAudioBeforeSendOptions>.Unbox
	|-Nullable<AddNotifyAudioInputStateOptions>.Unbox
	|-Nullable<AddNotifyAudioOutputStateOptions>.Unbox
	|-Nullable<AddNotifyDataReceivedOptions>.Unbox
	|-Nullable<AddNotifyDisconnectedOptions>.Unbox
	|-Nullable<AddNotifyParticipantStatusChangedOptions>.Unbox
	|-Nullable<AddNotifyParticipantUpdatedOptions>.Unbox
	|-Nullable<AddNotifyParticipantUpdatedOptions>.Unbox
	|-Nullable<AddNotifyRTCRoomConnectionChangedOptions>.Unbox
	|-Nullable<AddNotifyRoomStatisticsUpdatedOptions>.Unbox
	|-Nullable<AndroidIAPVerifyPurchaseOptionsPlatformSpecificOptions>.Unbox
	|-Nullable<AudioBuffer>.Unbox
	|-Nullable<AuthExpirationCallbackInfo>.Unbox
	|-Nullable<BeginSessionOptions>.Unbox
	|-Nullable<BigInteger>.Unbox
	|-Nullable<ClientCredentials>.Unbox
	|-Nullable<CopyBestDisplayNameOptions>.Unbox
	|-Nullable<CopyEntitlementByIdOptions>.Unbox
	|-Nullable<CopyEntitlementByIndexOptions>.Unbox
	|-Nullable<CopyFileMetadataAtIndexOptions>.Unbox
	|-Nullable<CopyFileMetadataAtIndexOptions>.Unbox
	|-Nullable<CopyFileMetadataByFilenameOptions>.Unbox
	|-Nullable<CopyFileMetadataByFilenameOptions>.Unbox
	|-Nullable<CopyItemByIdOptions>.Unbox
	|-Nullable<CopyLastRedeemedEntitlementByIndexOptions>.Unbox
	|-Nullable<CopyLeaderboardUserScoreByIndexOptions>.Unbox
	|-Nullable<CopyLeaderboardUserScoreByUserIdOptions>.Unbox
	|-Nullable<CopyLobbyDetailsHandleOptions>.Unbox
	|-Nullable<CopyModInfoOptions>.Unbox
	|-Nullable<CopyOfferByIdOptions>.Unbox
	|-Nullable<CopyOfferByIndexOptions>.Unbox
	|-Nullable<CopyPermissionByIndexOptions>.Unbox
	|-Nullable<CopyPlayerSanctionByIndexOptions>.Unbox
	|-Nullable<CopyPresenceOptions>.Unbox
	|-Nullable<CopyProductUserExternalAccountByAccountIdOptions>.Unbox
	|-Nullable<CopyProductUserExternalAccountByAccountTypeOptions>.Unbox
	|-Nullable<CopyProductUserExternalAccountByIndexOptions>.Unbox
	|-Nullable<CopyStatByIndexOptions>.Unbox
	|-Nullable<CopyStatByNameOptions>.Unbox
	|-Nullable<CopyTransactionByIdOptions>.Unbox
	|-Nullable<CopyTransactionByIndexOptions>.Unbox
	|-Nullable<CopyUnlockedAchievementByAchievementIdOptions>.Unbox
	|-Nullable<CopyUnlockedAchievementByIndexOptions>.Unbox
	|-Nullable<CopyUserInfoOptions>.Unbox
	|-Nullable<CopyUserTokenByUserIdOptions>.Unbox
	|-Nullable<CreateDeviceIdCallbackInfo>.Unbox
	|-Nullable<Credentials>.Unbox
	|-Nullable<DataRecord>.Unbox
	|-Nullable<DateTimeOffset>.Unbox
	|-Nullable<Decimal>.Unbox
	|-Nullable<DeleteDeviceIdCallbackInfo>.Unbox
	|-Nullable<DeleteFileOptions>.Unbox
	|-Nullable<DeletePersistentAuthCallbackInfo>.Unbox
	|-Nullable<DestroyLobbyOptions>.Unbox
	|-Nullable<DestroySessionCallbackInfo>.Unbox
	|-Nullable<EGSDLCVerifyPurchaseOptionsPlatformSpecificOptions>.Unbox
	|-Nullable<EGSIAPVerifyPurchaseOptionsPlatformSpecificOptions>.Unbox
	|-Nullable<EndSessionCallbackInfo>.Unbox
	|-Nullable<EnumerateModsOptions>.Unbox
	|-Nullable<GetBlockedUserAtIndexOptions>.Unbox
	|-Nullable<GetConnectStringOptions>.Unbox
	|-Nullable<GetEntitlementsByNameCountOptions>.Unbox
	|-Nullable<GetExternalUserInfoCountOptions>.Unbox
	|-Nullable<GetFriendAtIndexOptions>.Unbox
	|-Nullable<GetInviteIdByIndexOptions>.Unbox
	|-Nullable<GetInviteIdByIndexOptions>.Unbox
	|-Nullable<GetItemImageInfoCountOptions>.Unbox
	|-Nullable<GetItemReleaseCountOptions>.Unbox
	|-Nullable<GetJoinInfoOptions>.Unbox
	|-Nullable<GetNextReceivedPacketSizeOptions>.Unbox
	|-Nullable<GetOfferImageInfoCountOptions>.Unbox
	|-Nullable<GetOfferItemCountOptions>.Unbox
	|-Nullable<GetPermissionByKeyOptions>.Unbox
	|-Nullable<GetRTCRoomNameOptions>.Unbox
	|-Nullable<GetStatusOptions>.Unbox
	|-Nullable<HasPresenceOptions>.Unbox
	|-Nullable<IOSIAPVerifyPurchaseOptionsPlatformSpecificOptions>.Unbox
	|-Nullable<IdToken>.Unbox
	|-Nullable<IdToken>.Unbox
	|-Nullable<IngestData>.Unbox
	|-Nullable<IsRTCRoomConnectedOptions>.Unbox
	|-Nullable<IsUserInSessionOptions>.Unbox
	|-Nullable<ItemOwnership>.Unbox
	|-Nullable<JoinSessionCallbackInfo>.Unbox
	|-Nullable<JsonElement>.Unbox
	|-Nullable<KickCompleteCallbackInfo>.Unbox
	|-Nullable<KickOptions>.Unbox
	|-Nullable<LeaderboardUserScore>.Unbox
	|-Nullable<LeaveLobbyOptions>.Unbox
	|-Nullable<LeaveRoomOptions>.Unbox
	|-Nullable<LinkAccountOptions>.Unbox
	|-Nullable<LobbyDetailsCopyMemberAttributeByIndexOptions>.Unbox
	|-Nullable<LobbyDetailsCopyMemberAttributeByKeyOptions>.Unbox
	|-Nullable<LobbyDetailsMemberInfo>.Unbox
	|-Nullable<LobbySearchFindCallbackInfo>.Unbox
	|-Nullable<LobbySearchRemoveParameterOptions>.Unbox
	|-Nullable<LobbyUpdateReceivedCallbackInfo>.Unbox
	|-Nullable<LocalDefinition>.Unbox
	|-Nullable<LogPlayerReviveOptions>.Unbox
	|-Nullable<LogPlayerSpawnOptions>.Unbox
	|-Nullable<MemoryMonitorCallbackInfo>.Unbox
	|-Nullable<ModInfo>.Unbox
	|-Nullable<OnCheckpointCompleteCallbackInfo>.Unbox
	|-Nullable<OnCloseCompleteCallbackInfo>.Unbox
	|-Nullable<OnDisplaySettingsUpdatedCallbackInfo>.Unbox
	|-Nullable<OnQueryDefinitionsCompleteCallbackInfo>.Unbox
	|-Nullable<OnQueryInputDevicesInformationCallbackInfo>.Unbox
	|-Nullable<OnQueryLeaderboardDefinitionsCompleteCallbackInfo>.Unbox
	|-Nullable<OnQueryLeaderboardUserScoresCompleteCallbackInfo>.Unbox
	|-Nullable<OnQueryOutputDevicesInformationCallbackInfo>.Unbox
	|-Nullable<Option>.Unbox
	|-Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReport>.Unbox
	|-Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReport>.Unbox
	|-Nullable<PS5Options>.Unbox
	|-Nullable<ParticipantMetadata>.Unbox
	|-Nullable<PermissionStatus>.Unbox
	|-Nullable<PlayerStatInfo>.Unbox
	|-Nullable<QueryActivePlayerSanctionsOptions>.Unbox
	|-Nullable<QueryEntitlementTokenOptions>.Unbox
	|-Nullable<QueryFileListOptions>.Unbox
	|-Nullable<QueryFileOptions>.Unbox
	|-Nullable<QueryFileOptions>.Unbox
	|-Nullable<QueryIdTokenOptions>.Unbox
	|-Nullable<QueryLeaderboardRanksOptions>.Unbox
	|-Nullable<QueryOffersOptions>.Unbox
	|-Nullable<QueryOwnershipBySandboxIdsOptions>.Unbox
	|-Nullable<QueryPlayerAchievementsOptions>.Unbox
	|-Nullable<QueryPresenceOptions>.Unbox
	|-Nullable<QueryUserInfoByDisplayNameOptions>.Unbox
	|-Nullable<QueryUserInfoOptions>.Unbox
	|-Nullable<RTCOptions>.Unbox
	|-Nullable<ReceiveMessageFromServerOptions>.Unbox
	|-Nullable<RedeemEntitlementsOptions>.Unbox
	|-Nullable<RegexPrefix>.Unbox
	|-Nullable<RegisterEventParamDef>.Unbox
	|-Nullable<RegisterPlayersOptions>.Unbox
	|-Nullable<RejectInviteCallbackInfo>.Unbox
	|-Nullable<RejectInviteOptions>.Unbox
	|-Nullable<RejectInviteOptions>.Unbox
	|-Nullable<RejectInviteOptions>.Unbox
	|-Nullable<RejectRequestToJoinOptions>.Unbox
	|-Nullable<RequestPermissionsOptions>.Unbox
	|-Nullable<SandboxIdItemOwnership>.Unbox
	|-Nullable<SendCustomInviteOptions>.Unbox
	|-Nullable<SendInviteCallbackInfo>.Unbox
	|-Nullable<SendInviteOptions>.Unbox
	|-Nullable<SendPlayerBehaviorReportCompleteCallbackInfo>.Unbox
	|-Nullable<SendRequestToJoinOptions>.Unbox
	|-Nullable<SessionSearchFindCallbackInfo>.Unbox
	|-Nullable<SessionSearchRemoveParameterOptions>.Unbox
	|-Nullable<SetClientDetailsOptions>.Unbox
	|-Nullable<SetClientNetworkStateOptions>.Unbox
	|-Nullable<SetCustomInviteOptions>.Unbox
	|-Nullable<SetOutputDeviceSettingsOptions>.Unbox
	|-Nullable<SetPacketQueueSizeOptions>.Unbox
	|-Nullable<SetParticipantHardMuteCompleteCallbackInfo>.Unbox
	|-Nullable<SetPresenceOptions>.Unbox
	|-Nullable<SetSettingOptions>.Unbox
	|-Nullable<ShowBlockPlayerOptions>.Unbox
	|-Nullable<ShowNativeProfileOptions>.Unbox
	|-Nullable<ShowReportPlayerOptions>.Unbox
	|-Nullable<SocketIdInternal>.Unbox
	|-Nullable<StartSessionCallbackInfo>.Unbox
	|-Nullable<StatThresholds>.Unbox
	|-Nullable<SteamDLCVerifyPurchaseOptionsPlatformSpecificOptions>.Unbox
	|-Nullable<StreamingContext>.Unbox
	|-Nullable<SubmitSnapshotCallbackInfo>.Unbox
	|-Nullable<UnlockAchievementsOptions>.Unbox
	|-Nullable<UnregisterPlayersOptions>.Unbox
	|-Nullable<UpdateLobbyModificationOptions>.Unbox
	|-Nullable<UpdateParentEmailOptions>.Unbox
	|-Nullable<UserLoginInfo>.Unbox
	|-Nullable<UserScoresQueryStatInfo>.Unbox
	|-Nullable<UserToken>.Unbox
	|-Nullable<VerifyPurchaseCompleteCallbackInfo>.Unbox
	|-Nullable<VerifyUserAuthCallbackInfo>.Unbox
	|-Nullable<WindowsRTCOptionsPlatformSpecificOptionsInternal>.Unbox
	|-Nullable<XSXDLCVerifyPurchaseOptionsPlatformSpecificOptions>.Unbox
	|-Nullable<XSXIAPVerifyPurchaseOptionsPlatformSpecificOptions>.Unbox
	|-Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.Unbox
	|-Nullable<XSXSubmitGraphicsCommandsDataCommand>.Unbox
	|-Nullable<XSXXBLOptionsInitOptions>.Unbox
	|-Nullable<XboxOneGDKDLCVerifyPurchaseOptionsPlatformSpecificOptions>.Unbox
	|-Nullable<XboxOneGDKIAPVerifyPurchaseOptionsPlatformSpecificOptions>.Unbox
	|-Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal>.Unbox
	|-Nullable<XboxOneGDKSubmitGraphicsCommandsDataCommand>.Unbox
	|-Nullable<XboxOneGDKXBLOptionsInitOptions>.Unbox
	|
	|-RVA: 0xB53E90 Offset: 0xB53090 VA: 0x180B53E90
	|-Nullable<AcceptConnectionOptions>.Unbox
	|-Nullable<AttributeDataValue>.Unbox
	|-Nullable<AttributeDataValue>.Unbox
	|-Nullable<AudioBeforeRenderCallbackInfo>.Unbox
	|-Nullable<BeginPlayerSessionOptions>.Unbox
	|-Nullable<ClearPacketQueueOptions>.Unbox
	|-Nullable<CloseConnectionOptions>.Unbox
	|-Nullable<ExternalAccountInfo>.Unbox
	|-Nullable<FileMetadata>.Unbox
	|-Nullable<LobbyDetailsInfo>.Unbox
	|-Nullable<LogPlayerUseWeaponData>.Unbox
	|-Nullable<PS4IntegratedPlatformOptionsContainerAddOptions>.Unbox
	|-Nullable<PS4PrePresentOptions>.Unbox
	|-Nullable<PS5PrePresentOptions>.Unbox
	|-Nullable<ParticipantStatusChangedCallbackInfo>.Unbox
	|-Nullable<QueryLeaderboardDefinitionsOptions>.Unbox
	|-Nullable<QueryPermissionsCallbackInfo>.Unbox
	|-Nullable<SessionDetailsInfoInternal>.Unbox
	|-Nullable<SessionDetailsSettingsInternal>.Unbox
	|-Nullable<UninstallModOptions>.Unbox
	|-Nullable<UpdateModOptions>.Unbox
	|-Nullable<UserInfoDataInternal>.Unbox
	|-Nullable<XSXInitializeOptionsSystemInitializeOptions>.Unbox
	|-Nullable<XSXPrePresentOptionsPlatformSpecificData>.Unbox
	|-Nullable<XboxOneGDKInitializeOptionsSystemInitializeOptions>.Unbox
	|-Nullable<XboxOneGDKPrePresentOptionsPlatformSpecificData>.Unbox
	|
	|-RVA: 0xB540D0 Offset: 0xB532D0 VA: 0x180B540D0
