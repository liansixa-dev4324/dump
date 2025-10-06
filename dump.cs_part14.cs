	[MonitoringDescription("The number of bytes that are paged.")]
	public int PagedMemorySize { get; }
	[MonitoringDescription("The amount of paged system memory in bytes.")]
	[DesignerSerializationVisibility(0)]
	[Obsolete("Use PagedSystemMemorySize64")]
	public int PagedSystemMemorySize { get; }
	[MonitoringDescription("The maximum amount of paged memory used by this process.")]
	[DesignerSerializationVisibility(0)]
	[MonoTODO]
	[Obsolete("Use PeakPagedMemorySize64")]
	public int PeakPagedMemorySize { get; }
	[Obsolete("Use PeakVirtualMemorySize64")]
	[DesignerSerializationVisibility(0)]
	[MonitoringDescription("The maximum amount of virtual memory used by this process.")]
	public int PeakVirtualMemorySize { get; }
	[Obsolete("Use PeakWorkingSet64")]
	[MonitoringDescription("The maximum amount of system memory used by this process.")]
	[DesignerSerializationVisibility(0)]
	public int PeakWorkingSet { get; }
	[DesignerSerializationVisibility(0)]
	[MonitoringDescription("The number of bytes that are not pageable.")]
	[ComVisible(False)]
	[MonoTODO]
	public long NonpagedSystemMemorySize64 { get; }
	[DesignerSerializationVisibility(0)]
	[MonitoringDescription("The number of bytes that are paged.")]
	[ComVisible(False)]
	public long PagedMemorySize64 { get; }
	[ComVisible(False)]
	[MonitoringDescription("The amount of paged system memory in bytes.")]
	[DesignerSerializationVisibility(0)]
	public long PagedSystemMemorySize64 { get; }
	[MonoTODO]
	[DesignerSerializationVisibility(0)]
	[MonitoringDescription("The maximum amount of paged memory used by this process.")]
	[ComVisible(False)]
	public long PeakPagedMemorySize64 { get; }
	[ComVisible(False)]
	[MonitoringDescription("The maximum amount of virtual memory used by this process.")]
	[DesignerSerializationVisibility(0)]
	public long PeakVirtualMemorySize64 { get; }
	[DesignerSerializationVisibility(0)]
	[MonitoringDescription("The maximum amount of system memory used by this process.")]
	[ComVisible(False)]
	public long PeakWorkingSet64 { get; }
	[MonitoringDescription("Process will be of higher priority while it is actively used.")]
	[DesignerSerializationVisibility(0)]
	[MonoTODO]
	public bool PriorityBoostEnabled { get; set; }
	[Obsolete("Use PrivateMemorySize64")]
	[MonitoringDescription("The amount of memory exclusively used by this process.")]
	[DesignerSerializationVisibility(0)]
	public int PrivateMemorySize { get; }
	[DesignerSerializationVisibility(0)]
	[MonitoringDescription("The session ID for this process.")]
	[MonoNotSupported("")]
	public int SessionId { get; }
	[DesignerSerializationVisibility(0)]
	[MonitoringDescription("The name of this process.")]
	public string ProcessName { get; }
	[DesignerSerializationVisibility(0)]
	[MonitoringDescription("Allowed processor that can be used by this process.")]
	[MonoTODO]
	public IntPtr ProcessorAffinity { get; set; }
	[DesignerSerializationVisibility(0)]
	[MonitoringDescription("Is this process responsive.")]
	[MonoTODO]
	public bool Responding { get; }
	[MonitoringDescription("The number of threads of this process.")]
	[MonoTODO]
	[DesignerSerializationVisibility(0)]
	public ProcessThreadCollection Threads { get; }
	[MonitoringDescription("The amount of virtual memory currently used for this process.")]
	[DesignerSerializationVisibility(0)]
	[Obsolete("Use VirtualMemorySize64")]
	public int VirtualMemorySize { get; }
	[Obsolete("Use WorkingSet64")]
	[DesignerSerializationVisibility(0)]
	[MonitoringDescription("The amount of physical memory currently used for this process.")]
	public int WorkingSet { get; }
	[DesignerSerializationVisibility(0)]
	[MonitoringDescription("The amount of memory exclusively used by this process.")]
	[ComVisible(False)]
	public long PrivateMemorySize64 { get; }
	[DesignerSerializationVisibility(0)]
	[MonitoringDescription("The amount of virtual memory currently used for this process.")]
	[ComVisible(False)]
	public long VirtualMemorySize64 { get; }
	[MonitoringDescription("The amount of physical memory currently used for this process.")]
	[DesignerSerializationVisibility(0)]
	[ComVisible(False)]
	public long WorkingSet64 { get; }
	private static bool IsWindows { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x22D6280 Offset: 0x22D5480 VA: 0x1822D6280
	public void add_OutputDataReceived(DataReceivedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x22D78D0 Offset: 0x22D6AD0 VA: 0x1822D78D0
	public void remove_OutputDataReceived(DataReceivedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x22D6130 Offset: 0x22D5330 VA: 0x1822D6130
	public void add_ErrorDataReceived(DataReceivedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x22D7780 Offset: 0x22D6980 VA: 0x1822D7780
	public void remove_ErrorDataReceived(DataReceivedEventHandler value) { }

	// RVA: 0x22D5F90 Offset: 0x22D5190 VA: 0x1822D5F90
	public void .ctor() { }

	// RVA: 0x22D60A0 Offset: 0x22D52A0 VA: 0x1822D60A0
	private void .ctor(string machineName, bool isRemoteMachine, int processId, ProcessInfo processInfo) { }

	// RVA: 0x22D6330 Offset: 0x22D5530 VA: 0x1822D6330
	private bool get_Associated() { }

	// RVA: 0x22D6340 Offset: 0x22D5540 VA: 0x1822D6340
	public int get_ExitCode() { }

	// RVA: 0x22D6550 Offset: 0x22D5750 VA: 0x1822D6550
	public bool get_HasExited() { }

	// RVA: 0x22D2DC0 Offset: 0x22D1FC0 VA: 0x1822D2DC0
	private ProcessThreadTimes GetProcessTimes() { }

	// RVA: 0x22D6470 Offset: 0x22D5670 VA: 0x1822D6470
	public DateTime get_ExitTime() { }

	// RVA: 0x22D6510 Offset: 0x22D5710 VA: 0x1822D6510
	public IntPtr get_Handle() { }

	// RVA: 0x22D7050 Offset: 0x22D6250 VA: 0x1822D7050
	public SafeProcessHandle get_SafeHandle() { }

	// RVA: 0x22D68B0 Offset: 0x22D5AB0 VA: 0x1822D68B0
	public int get_Id() { }

	// RVA: 0x22D68D0 Offset: 0x22D5AD0 VA: 0x1822D68D0
	public string get_MachineName() { }

	// RVA: 0x22D6A00 Offset: 0x22D5C00 VA: 0x1822D6A00
	public IntPtr get_MaxWorkingSet() { }

	// RVA: 0x22D79F0 Offset: 0x22D6BF0 VA: 0x1822D79F0
	public void set_MaxWorkingSet(IntPtr value) { }

	// RVA: 0x22D6A20 Offset: 0x22D5C20 VA: 0x1822D6A20
	public IntPtr get_MinWorkingSet() { }

	// RVA: 0x22D7A50 Offset: 0x22D6C50 VA: 0x1822D7A50
	public void set_MinWorkingSet(IntPtr value) { }

	// RVA: 0x22D6BA0 Offset: 0x22D5DA0 VA: 0x1822D6BA0
	private OperatingSystem get_OperatingSystem() { }

	// RVA: 0x22D6C70 Offset: 0x22D5E70 VA: 0x1822D6C70
	public ProcessPriorityClass get_PriorityClass() { }

	// RVA: 0x22D7AB0 Offset: 0x22D6CB0 VA: 0x1822D7AB0
	public void set_PriorityClass(ProcessPriorityClass value) { }

	// RVA: 0x22D6DD0 Offset: 0x22D5FD0 VA: 0x1822D6DD0
	public TimeSpan get_PrivilegedProcessorTime() { }

	// RVA: 0x22D72F0 Offset: 0x22D64F0 VA: 0x1822D72F0
	public ProcessStartInfo get_StartInfo() { }

	// RVA: 0x22D7D00 Offset: 0x22D6F00 VA: 0x1822D7D00
	public void set_StartInfo(ProcessStartInfo value) { }

	// RVA: 0x22D73C0 Offset: 0x22D65C0 VA: 0x1822D73C0
	public DateTime get_StartTime() { }

	// RVA: 0x22D7440 Offset: 0x22D6640 VA: 0x1822D7440
	public ISynchronizeInvoke get_SynchronizingObject() { }

	// RVA: 0x599C80 Offset: 0x598E80 VA: 0x180599C80
	public void set_SynchronizingObject(ISynchronizeInvoke value) { }

	// RVA: 0x22D76A0 Offset: 0x22D68A0 VA: 0x1822D76A0
	public TimeSpan get_TotalProcessorTime() { }

	// RVA: 0x22D76E0 Offset: 0x22D68E0 VA: 0x1822D76E0
	public TimeSpan get_UserProcessorTime() { }

	// RVA: 0x5C4DE0 Offset: 0x5C3FE0 VA: 0x1805C4DE0
	public bool get_EnableRaisingEvents() { }

	// RVA: 0x22D7980 Offset: 0x22D6B80 VA: 0x1822D7980
	public void set_EnableRaisingEvents(bool value) { }

	// RVA: 0x22D7170 Offset: 0x22D6370 VA: 0x1822D7170
	public StreamWriter get_StandardInput() { }

	// RVA: 0x22D7200 Offset: 0x22D6400 VA: 0x1822D7200
	public StreamReader get_StandardOutput() { }

	// RVA: 0x22D7080 Offset: 0x22D6280 VA: 0x1822D7080
	public StreamReader get_StandardError() { }

	// RVA: 0x22D61E0 Offset: 0x22D53E0 VA: 0x1822D61E0
	public void add_Exited(EventHandler value) { }

	// RVA: 0x22D7830 Offset: 0x22D6A30 VA: 0x1822D7830
	public void remove_Exited(EventHandler value) { }

	// RVA: 0x22D3D40 Offset: 0x22D2F40 VA: 0x1822D3D40
	private void ReleaseProcessHandle(SafeProcessHandle handle) { }

	// RVA: 0x22D1A40 Offset: 0x22D0C40 VA: 0x1822D1A40
	private void CompletionCallback(object context, bool wasSignaled) { }

	// RVA: 0x22D1DA0 Offset: 0x22D0FA0 VA: 0x1822D1DA0 Slot: 14
	protected override void Dispose(bool disposing) { }

	// RVA: 0x22D1890 Offset: 0x22D0A90 VA: 0x1822D1890
	public void Close() { }

	// RVA: 0x22D1DF0 Offset: 0x22D0FF0 VA: 0x1822D1DF0
	private void EnsureState(Process.State state) { }

	// RVA: 0x22D2070 Offset: 0x22D1270 VA: 0x1822D2070
	private void EnsureWatchingForExit() { }

	// RVA: 0x22D21B0 Offset: 0x22D13B0 VA: 0x1822D21B0
	private void EnsureWorkingSetLimits() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void EnterDebugMode() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void LeaveDebugMode() { }

	// RVA: 0x22D27C0 Offset: 0x22D19C0 VA: 0x1822D27C0
	public static Process GetProcessById(int processId) { }

	// RVA: 0x22D3040 Offset: 0x22D2240 VA: 0x1822D3040
	public static Process[] GetProcessesByName(string processName) { }

	// RVA: 0x22D3530 Offset: 0x22D2730 VA: 0x1822D3530
	public static Process[] GetProcesses() { }

	// RVA: 0x22D2620 Offset: 0x22D1820 VA: 0x1822D2620
	public static Process GetCurrentProcess() { }

	// RVA: 0x22D36F0 Offset: 0x22D28F0 VA: 0x1822D36F0
	protected void OnExited() { }

	// RVA: 0x22D2A60 Offset: 0x22D1C60 VA: 0x1822D2A60
	private SafeProcessHandle GetProcessHandle(int access, bool throwIfExited) { }

	// RVA: 0x22D2DB0 Offset: 0x22D1FB0 VA: 0x1822D2DB0
	private SafeProcessHandle GetProcessHandle(int access) { }

	// RVA: 0x22D38E0 Offset: 0x22D2AE0 VA: 0x1822D38E0
	private SafeProcessHandle OpenProcessHandle() { }

	// RVA: 0x22D38F0 Offset: 0x22D2AF0 VA: 0x1822D38F0
	private SafeProcessHandle OpenProcessHandle(int access) { }

	// RVA: 0x22D3D10 Offset: 0x22D2F10 VA: 0x1822D3D10
	public void Refresh() { }

	// RVA: 0x22D3D60 Offset: 0x22D2F60 VA: 0x1822D3D60
	private void SetProcessHandle(SafeProcessHandle processHandle) { }

	// RVA: 0x22D3D80 Offset: 0x22D2F80 VA: 0x1822D3D80
	private void SetProcessId(int processId) { }

	// RVA: 0x22D3D90 Offset: 0x22D2F90 VA: 0x1822D3D90
	private void SetWorkingSetLimits(object newMin, object newMax) { }

	// RVA: 0x22D5510 Offset: 0x22D4710 VA: 0x1822D5510
	public bool Start() { }

	// RVA: 0x22D5470 Offset: 0x22D4670 VA: 0x1822D5470
	public static Process Start(string fileName, string userName, SecureString password, string domain) { }

	// RVA: 0x22D5990 Offset: 0x22D4B90 VA: 0x1822D5990
	public static Process Start(string fileName, string arguments, string userName, SecureString password, string domain) { }

	// RVA: 0x22D5A30 Offset: 0x22D4C30 VA: 0x1822D5A30
	public static Process Start(string fileName) { }

	// RVA: 0x22D5920 Offset: 0x22D4B20 VA: 0x1822D5920
	public static Process Start(string fileName, string arguments) { }

	// RVA: 0x22D56A0 Offset: 0x22D48A0 VA: 0x1822D56A0
	public static Process Start(ProcessStartInfo startInfo) { }

	// RVA: 0x22D35F0 Offset: 0x22D27F0 VA: 0x1822D35F0
	public void Kill() { }

	// RVA: 0x22D5A90 Offset: 0x22D4C90 VA: 0x1822D5A90
	private void StopWatchingForExit() { }

	// RVA: 0x22D5B90 Offset: 0x22D4D90 VA: 0x1822D5B90 Slot: 3
	public override string ToString() { }

	// RVA: 0x22D5CA0 Offset: 0x22D4EA0 VA: 0x1822D5CA0
	public bool WaitForExit(int milliseconds) { }

	// RVA: 0x22D5E10 Offset: 0x22D5010 VA: 0x1822D5E10
	public void WaitForExit() { }

	// RVA: 0x22D5E20 Offset: 0x22D5020 VA: 0x1822D5E20
	public bool WaitForInputIdle(int milliseconds) { }

	// RVA: 0x22D5F80 Offset: 0x22D5180 VA: 0x1822D5F80
	public bool WaitForInputIdle() { }

	[ComVisible(False)]
	// RVA: 0x22D1410 Offset: 0x22D0610 VA: 0x1822D1410
	public void BeginOutputReadLine() { }

	[ComVisible(False)]
	// RVA: 0x22D1190 Offset: 0x22D0390 VA: 0x1822D1190
	public void BeginErrorReadLine() { }

	[ComVisible(False)]
	// RVA: 0x22D1730 Offset: 0x22D0930 VA: 0x1822D1730
	public void CancelOutputRead() { }

	[ComVisible(False)]
	// RVA: 0x22D1690 Offset: 0x22D0890 VA: 0x1822D1690
	public void CancelErrorRead() { }

	// RVA: 0x22D39A0 Offset: 0x22D2BA0 VA: 0x1822D39A0
	internal void OutputReadNotifyUser(string data) { }

	// RVA: 0x22D22F0 Offset: 0x22D14F0 VA: 0x1822D22F0
	internal void ErrorReadNotifyUser(string data) { }

	// RVA: 0x22D6010 Offset: 0x22D5210 VA: 0x1822D6010
	private void .ctor(SafeProcessHandle handle, int id) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public int get_BasePriority() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public int get_HandleCount() { }

	// RVA: 0x22D68F0 Offset: 0x22D5AF0 VA: 0x1822D68F0
	public ProcessModule get_MainModule() { }

	// RVA: 0x22D36E0 Offset: 0x22D28E0 VA: 0x1822D36E0
	private static IntPtr MainWindowHandle_icall(int pid) { }

	// RVA: 0x22D69C0 Offset: 0x22D5BC0 VA: 0x1822D69C0
	public IntPtr get_MainWindowHandle() { }

	// RVA: 0x22D69D0 Offset: 0x22D5BD0 VA: 0x1822D69D0
	public string get_MainWindowTitle() { }

	// RVA: 0x22D0FB0 Offset: 0x22D01B0 VA: 0x1822D0FB0
	private static void AppendArguments(StringBuilder stringBuilder, Collection<string> argumentList) { }

	// RVA: 0x16181A0 Offset: 0x16173A0 VA: 0x1816181A0
	private ProcessModule[] GetModules_icall(IntPtr handle) { }

	// RVA: 0x22D26F0 Offset: 0x22D18F0 VA: 0x1822D26F0
	private ProcessModule[] GetModules_internal(SafeProcessHandle handle) { }

	// RVA: 0x22D6A40 Offset: 0x22D5C40 VA: 0x1822D6A40
	public ProcessModuleCollection get_Modules() { }

	// RVA: 0x22D2A50 Offset: 0x22D1C50 VA: 0x1822D2A50
	private static long GetProcessData(int pid, int data_type, out int error) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public int get_NonpagedSystemMemorySize() { }

	// RVA: 0x22D6BE0 Offset: 0x22D5DE0 VA: 0x1822D6BE0
	public int get_PagedMemorySize() { }

	// RVA: 0x22D6BE0 Offset: 0x22D5DE0 VA: 0x1822D6BE0
	public int get_PagedSystemMemorySize() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public int get_PeakPagedMemorySize() { }

	// RVA: 0x22D6C10 Offset: 0x22D5E10 VA: 0x1822D6C10
	public int get_PeakVirtualMemorySize() { }

	// RVA: 0x22D6C40 Offset: 0x22D5E40 VA: 0x1822D6C40
	public int get_PeakWorkingSet() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public long get_NonpagedSystemMemorySize64() { }

	// RVA: 0x22D6BE0 Offset: 0x22D5DE0 VA: 0x1822D6BE0
	public long get_PagedMemorySize64() { }

	// RVA: 0x22D6BE0 Offset: 0x22D5DE0 VA: 0x1822D6BE0
	public long get_PagedSystemMemorySize64() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public long get_PeakPagedMemorySize64() { }

	// RVA: 0x22D6C10 Offset: 0x22D5E10 VA: 0x1822D6C10
	public long get_PeakVirtualMemorySize64() { }

	// RVA: 0x22D6C40 Offset: 0x22D5E40 VA: 0x1822D6C40
	public long get_PeakWorkingSet64() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	public bool get_PriorityBoostEnabled() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_PriorityBoostEnabled(bool value) { }

	// RVA: 0x22D6DA0 Offset: 0x22D5FA0 VA: 0x1822D6DA0
	public int get_PrivateMemorySize() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public int get_SessionId() { }

	// RVA: 0x22D3B80 Offset: 0x22D2D80 VA: 0x1822D3B80
	private static string ProcessName_icall(IntPtr handle) { }

	// RVA: 0x22D3B90 Offset: 0x22D2D90 VA: 0x1822D3B90
	private static string ProcessName_internal(SafeProcessHandle handle) { }

	// RVA: 0x22D6E10 Offset: 0x22D6010 VA: 0x1822D6E10
	public string get_ProcessName() { }

	// RVA: 0x22D7040 Offset: 0x22D6240 VA: 0x1822D7040
	public IntPtr get_ProcessorAffinity() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_ProcessorAffinity(IntPtr value) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	public bool get_Responding() { }

	// RVA: 0x22D75C0 Offset: 0x22D67C0 VA: 0x1822D75C0
	public ProcessThreadCollection get_Threads() { }

	// RVA: 0x22D7720 Offset: 0x22D6920 VA: 0x1822D7720
	public int get_VirtualMemorySize() { }

	// RVA: 0x22D7750 Offset: 0x22D6950 VA: 0x1822D7750
	public int get_WorkingSet() { }

	// RVA: 0x22D6DA0 Offset: 0x22D5FA0 VA: 0x1822D6DA0
	public long get_PrivateMemorySize64() { }

	// RVA: 0x22D7720 Offset: 0x22D6920 VA: 0x1822D7720
	public long get_VirtualMemorySize64() { }

	// RVA: 0x22D7750 Offset: 0x22D6950 VA: 0x1822D7750
	public long get_WorkingSet64() { }

	// RVA: 0x22D17D0 Offset: 0x22D09D0 VA: 0x1822D17D0
	public bool CloseMainWindow() { }

	// RVA: 0x22D3030 Offset: 0x22D2230 VA: 0x1822D3030
	private static IntPtr GetProcess_internal(int pid) { }

	[MonoTODO("There is no support for retrieving process information from a remote machine")]
	// RVA: 0x22D2800 Offset: 0x22D1A00 VA: 0x1822D2800
	public static Process GetProcessById(int processId, string machineName) { }

	// RVA: 0x22D3080 Offset: 0x22D2280 VA: 0x1822D3080
	public static Process[] GetProcessesByName(string processName, string machineName) { }

	// RVA: 0x16181A0 Offset: 0x16173A0 VA: 0x1816181A0
	private static int[] GetProcesses_internal() { }

	[MonoTODO("There is no support for retrieving process information from a remote machine")]
	// RVA: 0x22D3310 Offset: 0x22D2510 VA: 0x1822D3310
	public static Process[] GetProcesses(string machineName) { }

	// RVA: 0x22D3570 Offset: 0x22D2770 VA: 0x1822D3570
	private static bool IsLocalMachine(string machineName) { }

	// RVA: 0x158A1E0 Offset: 0x15893E0 VA: 0x18158A1E0
	private static bool ShellExecuteEx_internal(ProcessStartInfo startInfo, ref Process.ProcInfo procInfo) { }

	// RVA: 0x158A1E0 Offset: 0x15893E0 VA: 0x18158A1E0
	private static bool CreateProcess_internal(ProcessStartInfo startInfo, IntPtr stdin, IntPtr stdout, IntPtr stderr, ref Process.ProcInfo procInfo) { }

	// RVA: 0x22D5010 Offset: 0x22D4210 VA: 0x1822D5010
	private bool StartWithShellExecuteEx(ProcessStartInfo startInfo) { }

	// RVA: 0x22D1A60 Offset: 0x22D0C60 VA: 0x1822D1A60
	private static void CreatePipe(out IntPtr read, out IntPtr write, bool writeDirection) { }

	// RVA: 0x1768DB0 Offset: 0x1767FB0 VA: 0x181768DB0
	private static bool get_IsWindows() { }

	// RVA: 0x22D4100 Offset: 0x22D3300 VA: 0x1822D4100
	private bool StartWithCreateProcess(ProcessStartInfo startInfo) { }

	// RVA: 0x22D24D0 Offset: 0x22D16D0 VA: 0x1822D24D0
	private static void FillUserInfo(ProcessStartInfo startInfo, ref Process.ProcInfo procInfo) { }

	// RVA: 0x22D3C60 Offset: 0x22D2E60 VA: 0x1822D3C60
	private void RaiseOnExited() { }
}

// Namespace: System.Diagnostics
internal class ProcessInfo // TypeDefIndex: 5072
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Diagnostics
internal static class EnvironmentBlock // TypeDefIndex: 5073
{
	// Methods

	// RVA: 0x22CE420 Offset: 0x22CD620 VA: 0x1822CE420
	public static byte[] ToByteArray(StringDictionary sd, bool unicode) { }
}

// Namespace: System.Diagnostics
internal class OrdinalCaseInsensitiveComparer : IComparer // TypeDefIndex: 5074
{
	// Fields
	internal static readonly OrdinalCaseInsensitiveComparer Default; // 0x0

	// Methods

	// RVA: 0x22CF5B0 Offset: 0x22CE7B0 VA: 0x1822CF5B0 Slot: 4
	public int Compare(object a, object b) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x22CF680 Offset: 0x22CE880 VA: 0x1822CF680
	private static void .cctor() { }
}

// Namespace: System.Diagnostics
internal class ProcessThreadTimes // TypeDefIndex: 5075
{
	// Fields
	internal long create; // 0x10
	internal long exit; // 0x18
	internal long kernel; // 0x20
	internal long user; // 0x28

	// Properties
	public DateTime StartTime { get; }
	public DateTime ExitTime { get; }
	public TimeSpan PrivilegedProcessorTime { get; }
	public TimeSpan UserProcessorTime { get; }
	public TimeSpan TotalProcessorTime { get; }

	// Methods

	// RVA: 0x22D0EF0 Offset: 0x22D00F0 VA: 0x1822D0EF0
	public DateTime get_StartTime() { }

	// RVA: 0x22D0EA0 Offset: 0x22D00A0 VA: 0x1822D0EA0
	public DateTime get_ExitTime() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public TimeSpan get_PrivilegedProcessorTime() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public TimeSpan get_UserProcessorTime() { }

	// RVA: 0x22D0F40 Offset: 0x22D0140 VA: 0x1822D0F40
	public TimeSpan get_TotalProcessorTime() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Diagnostics
[DefaultMember("Item")]
public class ProcessModuleCollection : ReadOnlyCollectionBase // TypeDefIndex: 5076
{
	// Properties
	public ProcessModule Item { get; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	protected void .ctor() { }

	// RVA: 0x22CF7B0 Offset: 0x22CE9B0 VA: 0x1822CF7B0
	public void .ctor(ProcessModule[] processModules) { }

	// RVA: 0x22CF800 Offset: 0x22CEA00 VA: 0x1822CF800
	public ProcessModule get_Item(int index) { }

	// RVA: 0x22CF770 Offset: 0x22CE970 VA: 0x1822CF770
	public int IndexOf(ProcessModule module) { }

	// RVA: 0x22CF6E0 Offset: 0x22CE8E0 VA: 0x1822CF6E0
	public bool Contains(ProcessModule module) { }

	// RVA: 0x22CF720 Offset: 0x22CE920 VA: 0x1822CF720
	public void CopyTo(ProcessModule[] array, int index) { }
}

// Namespace: System.Diagnostics
[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class ProcessStartInfo // TypeDefIndex: 5077
{
	// Fields
	private string fileName; // 0x10
	private string arguments; // 0x18
	private string directory; // 0x20
	private string verb; // 0x28
	private ProcessWindowStyle windowStyle; // 0x30
	private bool errorDialog; // 0x34
	private IntPtr errorDialogParentHandle; // 0x38
	private bool useShellExecute; // 0x40
	private string userName; // 0x48
	private string domain; // 0x50
	private SecureString password; // 0x58
	private string passwordInClearText; // 0x60
	private bool loadUserProfile; // 0x68
	private bool redirectStandardInput; // 0x69
	private bool redirectStandardOutput; // 0x6A
	private bool redirectStandardError; // 0x6B
	private Encoding standardOutputEncoding; // 0x70
	private Encoding standardErrorEncoding; // 0x78
	private bool createNoWindow; // 0x80
	private WeakReference weakParentProcess; // 0x88
	internal StringDictionary environmentVariables; // 0x90
	private static readonly string[] empty; // 0x0
	private Collection<string> _argumentList; // 0x98
	private IDictionary<string, string> environment; // 0xA0
	[CompilerGenerated]
	private Encoding <StandardInputEncoding>k__BackingField; // 0xA8

	// Properties
	public Collection<string> ArgumentList { get; }
	[DefaultValue("")]
	[TypeConverter("System.Diagnostics.Design.VerbConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[MonitoringDescription("The verb to apply to the document specified by the FileName property.")]
	[NotifyParentProperty(True)]
	public string Verb { get; set; }
	[MonitoringDescription("Command line arguments that will be passed to the application specified by the FileName property.")]
	[NotifyParentProperty(True)]
	[SettingsBindable(True)]
	[DefaultValue("")]
	[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public string Arguments { get; set; }
	[NotifyParentProperty(True)]
	[DefaultValue(False)]
	[MonitoringDescription("Whether to start the process without creating a new window to contain it.")]
	public bool CreateNoWindow { get; set; }
	[DesignerSerializationVisibility(2)]
	[NotifyParentProperty(True)]
	[MonitoringDescription("Set of environment variables that apply to this process and child processes.")]
	[DefaultValue(null)]
	[Editor("System.Diagnostics.Design.StringDictionaryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public StringDictionary EnvironmentVariables { get; }
	[NotifyParentProperty(True)]
	[DesignerSerializationVisibility(0)]
	[DefaultValue(null)]
	public IDictionary<string, string> Environment { get; }
	[DefaultValue(False)]
	[MonitoringDescription("Whether the process command input is read from the Process instance's StandardInput member.")]
	[NotifyParentProperty(True)]
	public bool RedirectStandardInput { get; set; }
	[MonitoringDescription("Whether the process output is written to the Process instance's StandardOutput member.")]
	[NotifyParentProperty(True)]
	[DefaultValue(False)]
	public bool RedirectStandardOutput { get; set; }
	[DefaultValue(False)]
	[MonitoringDescription("Whether the process's error output is written to the Process instance's StandardError member.")]
	[NotifyParentProperty(True)]
	public bool RedirectStandardError { get; set; }
	public Encoding StandardErrorEncoding { get; set; }
	public Encoding StandardOutputEncoding { get; set; }
	[NotifyParentProperty(True)]
	[MonitoringDescription("Whether to use the operating system shell to start the process.")]
	[DefaultValue(True)]
	public bool UseShellExecute { get; set; }
	[NotifyParentProperty(True)]
	public string UserName { get; set; }
	public SecureString Password { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public string PasswordInClearText { get; set; }
	[NotifyParentProperty(True)]
	public string Domain { get; set; }
	[NotifyParentProperty(True)]
	public bool LoadUserProfile { get; set; }
	[SettingsBindable(True)]
	[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[MonitoringDescription("The name of the application, document or URL to start.")]
	[Editor("System.Diagnostics.Design.StartFileNameEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[DefaultValue("")]
	[NotifyParentProperty(True)]
	public string FileName { get; set; }
	[MonitoringDescription("The initial working directory for the process.")]
	[NotifyParentProperty(True)]
	[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[DefaultValue("")]
	[SettingsBindable(True)]
	[Editor("System.Diagnostics.Design.WorkingDirectoryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public string WorkingDirectory { get; set; }
	[NotifyParentProperty(True)]
	[MonitoringDescription("Whether to show an error dialog to the user if there is an error.")]
	[DefaultValue(False)]
	public bool ErrorDialog { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public IntPtr ErrorDialogParentHandle { get; set; }
	[DefaultValue(0)]
	[NotifyParentProperty(True)]
	[MonitoringDescription("How the main window should be created when the process starts.")]
	public ProcessWindowStyle WindowStyle { get; set; }
	internal bool HaveEnvVars { get; }
	public Encoding StandardInputEncoding { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public string[] Verbs { get; }

	// Methods

	// RVA: 0x22CFA00 Offset: 0x22CEC00 VA: 0x1822CFA00
	public void .ctor() { }

	// RVA: 0x22CF980 Offset: 0x22CEB80 VA: 0x1822CF980
	internal void .ctor(Process parent) { }

	// RVA: 0x22CF910 Offset: 0x22CEB10 VA: 0x1822CF910
	public void .ctor(string fileName) { }

	// RVA: 0x22CF940 Offset: 0x22CEB40 VA: 0x1822CF940
	public void .ctor(string fileName, string arguments) { }

	// RVA: 0x22CFA10 Offset: 0x22CEC10 VA: 0x1822CFA10
	public Collection<string> get_ArgumentList() { }

	// RVA: 0x22D00C0 Offset: 0x22CF2C0 VA: 0x1822D00C0
	public string get_Verb() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_Verb(string value) { }

	// RVA: 0x22CFA90 Offset: 0x22CEC90 VA: 0x1822CFA90
	public string get_Arguments() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Arguments(string value) { }

	// RVA: 0x67AA00 Offset: 0x679C00 VA: 0x18067AA00
	public bool get_CreateNoWindow() { }

	// RVA: 0x67AD80 Offset: 0x679F80 VA: 0x18067AD80
	public void set_CreateNoWindow(bool value) { }

	// RVA: 0x22CFB30 Offset: 0x22CED30 VA: 0x1822CFB30
	public StringDictionary get_EnvironmentVariables() { }

	// RVA: 0x22CFFD0 Offset: 0x22CF1D0 VA: 0x1822CFFD0
	public IDictionary<string, string> get_Environment() { }

	// RVA: 0x1C134F0 Offset: 0x1C126F0 VA: 0x181C134F0
	public bool get_RedirectStandardInput() { }

	// RVA: 0x1C13530 Offset: 0x1C12730 VA: 0x181C13530
	public void set_RedirectStandardInput(bool value) { }

	// RVA: 0x1C13490 Offset: 0x1C12690 VA: 0x181C13490
	public bool get_RedirectStandardOutput() { }

	// RVA: 0x1C13500 Offset: 0x1C12700 VA: 0x181C13500
	public void set_RedirectStandardOutput(bool value) { }

	// RVA: 0x20939F0 Offset: 0x2092BF0 VA: 0x1820939F0
	public bool get_RedirectStandardError() { }

	// RVA: 0x2093A70 Offset: 0x2092C70 VA: 0x182093A70
	public void set_RedirectStandardError(bool value) { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	public Encoding get_StandardErrorEncoding() { }

	// RVA: 0x1862F40 Offset: 0x1862140 VA: 0x181862F40
	public void set_StandardErrorEncoding(Encoding value) { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public Encoding get_StandardOutputEncoding() { }

	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30
	public void set_StandardOutputEncoding(Encoding value) { }

	// RVA: 0x4456F0 Offset: 0x4448F0 VA: 0x1804456F0
	public bool get_UseShellExecute() { }

	// RVA: 0x445700 Offset: 0x444900 VA: 0x180445700
	public void set_UseShellExecute(bool value) { }

	// RVA: 0x22D0070 Offset: 0x22CF270 VA: 0x1822D0070
	public string get_UserName() { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_UserName(string value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public SecureString get_Password() { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_Password(SecureString value) { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public string get_PasswordInClearText() { }

	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	public void set_PasswordInClearText(string value) { }

	// RVA: 0x22CFAE0 Offset: 0x22CECE0 VA: 0x1822CFAE0
	public string get_Domain() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_Domain(string value) { }

	// RVA: 0x563E40 Offset: 0x563040 VA: 0x180563E40
	public bool get_LoadUserProfile() { }

	// RVA: 0x563E60 Offset: 0x563060 VA: 0x180563E60
	public void set_LoadUserProfile(bool value) { }

	// RVA: 0x22D0020 Offset: 0x22CF220 VA: 0x1822D0020
	public string get_FileName() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_FileName(string value) { }

	// RVA: 0x22D0160 Offset: 0x22CF360 VA: 0x1822D0160
	public string get_WorkingDirectory() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_WorkingDirectory(string value) { }

	// RVA: 0x78E680 Offset: 0x78D880 VA: 0x18078E680
	public bool get_ErrorDialog() { }

	// RVA: 0x18C42D0 Offset: 0x18C34D0 VA: 0x1818C42D0
	public void set_ErrorDialog(bool value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public IntPtr get_ErrorDialogParentHandle() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_ErrorDialogParentHandle(IntPtr value) { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public ProcessWindowStyle get_WindowStyle() { }

	// RVA: 0x22D01B0 Offset: 0x22CF3B0 VA: 0x1822D01B0
	public void set_WindowStyle(ProcessWindowStyle value) { }

	// RVA: 0x21589C0 Offset: 0x2157BC0 VA: 0x1821589C0
	internal bool get_HaveEnvVars() { }

	[CompilerGenerated]
	// RVA: 0x7960B0 Offset: 0x7952B0 VA: 0x1807960B0
	public Encoding get_StandardInputEncoding() { }

	[CompilerGenerated]
	// RVA: 0xB83400 Offset: 0xB82600 VA: 0x180B83400
	public void set_StandardInputEncoding(Encoding value) { }

	// RVA: 0x22D0110 Offset: 0x22CF310 VA: 0x1822D0110
	public string[] get_Verbs() { }

	// RVA: 0x22CF8C0 Offset: 0x22CEAC0 VA: 0x1822CF8C0
	private static void .cctor() { }
}

// Namespace: System.Diagnostics
[DefaultMember("Item")]
public class ProcessThreadCollection : ReadOnlyCollectionBase // TypeDefIndex: 5078
{
	// Properties
	public ProcessThread Item { get; }
	[Obsolete("This API is no longer available", True)]
	public int Capacity { get; set; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	protected void .ctor() { }

	// RVA: 0x22CF7B0 Offset: 0x22CE9B0 VA: 0x1822CF7B0
	public void .ctor(ProcessThread[] processThreads) { }

	// RVA: 0x22D0DA0 Offset: 0x22CFFA0 VA: 0x1822D0DA0
	public ProcessThread get_Item(int index) { }

	// RVA: 0x22D0350 Offset: 0x22CF550 VA: 0x1822D0350
	public int Add(ProcessThread thread) { }

	// RVA: 0x22D0910 Offset: 0x22CFB10 VA: 0x1822D0910
	public void Insert(int index, ProcessThread thread) { }

	// RVA: 0x22CF770 Offset: 0x22CE970 VA: 0x1822CF770
	public int IndexOf(ProcessThread thread) { }

	// RVA: 0x22CF6E0 Offset: 0x22CE8E0 VA: 0x1822CF6E0
	public bool Contains(ProcessThread thread) { }

	// RVA: 0x22D0AE0 Offset: 0x22CFCE0 VA: 0x1822D0AE0
	public void Remove(ProcessThread thread) { }

	// RVA: 0x22CF720 Offset: 0x22CE920 VA: 0x1822CF720
	public void CopyTo(ProcessThread[] array, int index) { }

	// RVA: 0x22D0D60 Offset: 0x22CFF60 VA: 0x1822D0D60
	public int get_Capacity() { }

	// RVA: 0x22D0E60 Offset: 0x22D0060 VA: 0x1822D0E60
	public void set_Capacity(int value) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0310 Offset: 0x22CF510 VA: 0x1822D0310
	public void AddRange(IEnumerable<ProcessThread> collection) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0390 Offset: 0x22CF590 VA: 0x1822D0390
	public ReadOnlyCollection<ProcessThread> AsReadOnly() { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D03D0 Offset: 0x22CF5D0 VA: 0x1822D03D0
	public int BinarySearch(int index, int count, ProcessThread item, IComparer<ProcessThread> comparer) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0410 Offset: 0x22CF610 VA: 0x1822D0410
	public int BinarySearch(ProcessThread item) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0450 Offset: 0x22CF650 VA: 0x1822D0450
	public int BinarySearch(ProcessThread item, IComparer<ProcessThread> comparer) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0490 Offset: 0x22CF690 VA: 0x1822D0490
	public void Clear() { }

	[Obsolete("This API is no longer available", True)]
	// RVA: -1 Offset: -1
	public List<TOutput> ConvertAll<TOutput>(Converter<ProcessThread, TOutput> converter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5BEE0 Offset: 0xA5B0E0 VA: 0x180A5BEE0
	|-ProcessThreadCollection.ConvertAll<__Il2CppFullySharedGenericType>
	*/

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0510 Offset: 0x22CF710 VA: 0x1822D0510
	public void CopyTo(ProcessThread[] array) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D04D0 Offset: 0x22CF6D0 VA: 0x1822D04D0
	public void CopyTo(int index, ProcessThread[] array, int arrayIndex, int count) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0550 Offset: 0x22CF750 VA: 0x1822D0550
	public bool Exists(Predicate<ProcessThread> match) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0790 Offset: 0x22CF990 VA: 0x1822D0790
	public ProcessThread Find(Predicate<ProcessThread> match) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0590 Offset: 0x22CF790 VA: 0x1822D0590
	public List<ProcessThread> FindAll(Predicate<ProcessThread> match) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0610 Offset: 0x22CF810 VA: 0x1822D0610
	public int FindIndex(Predicate<ProcessThread> match) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0650 Offset: 0x22CF850 VA: 0x1822D0650
	public int FindIndex(int startIndex, Predicate<ProcessThread> match) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D05D0 Offset: 0x22CF7D0 VA: 0x1822D05D0
	public int FindIndex(int startIndex, int count, Predicate<ProcessThread> match) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0750 Offset: 0x22CF950 VA: 0x1822D0750
	public ProcessThread FindLast(Predicate<ProcessThread> match) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D06D0 Offset: 0x22CF8D0 VA: 0x1822D06D0
	public int FindLastIndex(Predicate<ProcessThread> match) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0710 Offset: 0x22CF910 VA: 0x1822D0710
	public int FindLastIndex(int startIndex, Predicate<ProcessThread> match) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0690 Offset: 0x22CF890 VA: 0x1822D0690
	public int FindLastIndex(int startIndex, int count, Predicate<ProcessThread> match) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D07D0 Offset: 0x22CF9D0 VA: 0x1822D07D0
	public void ForEach(Action<ProcessThread> action) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0810 Offset: 0x22CFA10 VA: 0x1822D0810
	public List<ProcessThread> GetRange(int index, int count) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0890 Offset: 0x22CFA90 VA: 0x1822D0890
	public int IndexOf(ProcessThread item, int index) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0850 Offset: 0x22CFA50 VA: 0x1822D0850
	public int IndexOf(ProcessThread item, int index, int count) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D08D0 Offset: 0x22CFAD0 VA: 0x1822D08D0
	public void InsertRange(int index, IEnumerable<ProcessThread> collection) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0960 Offset: 0x22CFB60 VA: 0x1822D0960
	public int LastIndexOf(ProcessThread item) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D09E0 Offset: 0x22CFBE0 VA: 0x1822D09E0
	public int LastIndexOf(ProcessThread item, int index) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D09A0 Offset: 0x22CFBA0 VA: 0x1822D09A0
	public int LastIndexOf(ProcessThread item, int index, int count) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0A20 Offset: 0x22CFC20 VA: 0x1822D0A20
	public int RemoveAll(Predicate<ProcessThread> match) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0A60 Offset: 0x22CFC60 VA: 0x1822D0A60
	public void RemoveAt(int index) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0AA0 Offset: 0x22CFCA0 VA: 0x1822D0AA0
	public void RemoveRange(int index, int count) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0B20 Offset: 0x22CFD20 VA: 0x1822D0B20
	public void Reverse() { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0B60 Offset: 0x22CFD60 VA: 0x1822D0B60
	public void Reverse(int index, int count) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0C20 Offset: 0x22CFE20 VA: 0x1822D0C20
	public void Sort() { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0BE0 Offset: 0x22CFDE0 VA: 0x1822D0BE0
	public void Sort(IComparer<ProcessThread> comparer) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0C60 Offset: 0x22CFE60 VA: 0x1822D0C60
	public void Sort(int index, int count, IComparer<ProcessThread> comparer) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0BA0 Offset: 0x22CFDA0 VA: 0x1822D0BA0
	public void Sort(Comparison<ProcessThread> comparison) { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0CA0 Offset: 0x22CFEA0 VA: 0x1822D0CA0
	public ProcessThread[] ToArray() { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0CE0 Offset: 0x22CFEE0 VA: 0x1822D0CE0
	public void TrimExcess() { }

	[Obsolete("This API is no longer available", True)]
	// RVA: 0x22D0D20 Offset: 0x22CFF20 VA: 0x1822D0D20
	public bool TrueForAll(Predicate<ProcessThread> match) { }
}

// Namespace: System.Diagnostics
internal class ProcessWaitHandle : WaitHandle // TypeDefIndex: 5079
{
	// Methods

	// RVA: 0x22D0F50 Offset: 0x22D0150 VA: 0x1822D0F50
	internal void .ctor(SafeProcessHandle processHandle) { }
}

// Namespace: System.Diagnostics
internal class AssertWrapper // TypeDefIndex: 5080
{
	// Methods

	// RVA: 0x22C9140 Offset: 0x22C8340 VA: 0x1822C9140
	public static void ShowAssert(string stackTrace, StackFrame frame, string message, string detailMessage) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Diagnostics
public class DataReceivedEventArgs : EventArgs // TypeDefIndex: 5081
{
	// Fields
	private string data; // 0x10

	// Properties
	public string Data { get; }

	// Methods

	// RVA: 0x22CB020 Offset: 0x22CA220 VA: 0x1822CB020
	internal void .ctor(string data) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Data() { }

	// RVA: 0x22CB080 Offset: 0x22CA280 VA: 0x1822CB080
	internal void .ctor() { }
}

// Namespace: System.Diagnostics
public sealed class DataReceivedEventHandler : MulticastDelegate // TypeDefIndex: 5082
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, DataReceivedEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, DataReceivedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Diagnostics
public class DefaultTraceListener : TraceListener // TypeDefIndex: 5083
{
	// Fields
	private static readonly bool OnWin32; // 0x0
	private const string ConsoleOutTrace = "Console.Out";
	private const string ConsoleErrorTrace = "Console.Error";
	private static readonly string MonoTracePrefix; // 0x8
	private static readonly string MonoTraceFile; // 0x10
	private string logFileName; // 0x48
	private bool assertUiEnabled; // 0x50

	// Properties
	[MonoTODO("AssertUiEnabled defaults to False; should follow Environment.UserInteractive.")]
	public bool AssertUiEnabled { get; set; }
	[MonoTODO]
	public string LogFileName { get; set; }

	// Methods

	// RVA: 0x22CC9D0 Offset: 0x22CBBD0 VA: 0x1822CC9D0
	private static void .cctor() { }

	// RVA: 0x22CC2B0 Offset: 0x22CB4B0 VA: 0x1822CC2B0
	private static string GetPrefix(string var, string target) { }

	// RVA: 0x22CCB70 Offset: 0x22CBD70 VA: 0x1822CCB70
	public void .ctor() { }

	// RVA: 0x4D1A10 Offset: 0x4D0C10 VA: 0x1804D1A10
	public bool get_AssertUiEnabled() { }

	// RVA: 0x4D1A50 Offset: 0x4D0C50 VA: 0x1804D1A50
	public void set_AssertUiEnabled(bool value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public string get_LogFileName() { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_LogFileName(string value) { }

	// RVA: 0x204BDA0 Offset: 0x204AFA0 VA: 0x18204BDA0 Slot: 13
	public override void Fail(string message) { }

	// RVA: 0x22CC120 Offset: 0x22CB320 VA: 0x1822CC120 Slot: 14
	public override void Fail(string message, string detailMessage) { }

	// RVA: 0x22CC9B0 Offset: 0x22CBBB0 VA: 0x1822CC9B0
	private static void WriteWindowsDebugString(char* message) { }

	// RVA: 0x22CC320 Offset: 0x22CB520 VA: 0x1822CC320
	private void WriteDebugString(string message) { }

	// RVA: 0x22CC740 Offset: 0x22CB940 VA: 0x1822CC740
	private void WriteMonoTrace(string message) { }

	// RVA: 0x22CC920 Offset: 0x22CBB20 VA: 0x1822CC920
	private void WritePrefix() { }

	// RVA: 0x22CC3D0 Offset: 0x22CB5D0 VA: 0x1822CC3D0
	private void WriteImpl(string message) { }

	// RVA: 0x22CC5E0 Offset: 0x22CB7E0 VA: 0x1822CC5E0
	private void WriteLogFile(string message, string logFile) { }

	// RVA: 0x22CC9C0 Offset: 0x22CBBC0 VA: 0x1822CC9C0 Slot: 16
	public override void Write(string message) { }

	// RVA: 0x22CC590 Offset: 0x22CB790 VA: 0x1822CC590 Slot: 21
	public override void WriteLine(string message) { }
}

// Namespace: System.Diagnostics
public sealed class FileVersionInfo // TypeDefIndex: 5084
{
	// Fields
	private string comments; // 0x10
	private string companyname; // 0x18
	private string filedescription; // 0x20
	private string filename; // 0x28
	private string fileversion; // 0x30
	private string internalname; // 0x38
	private string language; // 0x40
	private string legalcopyright; // 0x48
	private string legaltrademarks; // 0x50
	private string originalfilename; // 0x58
	private string privatebuild; // 0x60
	private string productname; // 0x68
	private string productversion; // 0x70
	private string specialbuild; // 0x78
	private bool isdebug; // 0x80
	private bool ispatched; // 0x81
	private bool isprerelease; // 0x82
	private bool isprivatebuild; // 0x83
	private bool isspecialbuild; // 0x84
	private int filemajorpart; // 0x88
	private int fileminorpart; // 0x8C
	private int filebuildpart; // 0x90
	private int fileprivatepart; // 0x94
	private int productmajorpart; // 0x98
	private int productminorpart; // 0x9C
	private int productbuildpart; // 0xA0
	private int productprivatepart; // 0xA4

	// Properties
	public string Comments { get; }
	public string CompanyName { get; }
	public int FileBuildPart { get; }
	public string FileDescription { get; }
	public int FileMajorPart { get; }
	public int FileMinorPart { get; }
	public string FileName { get; }
	public int FilePrivatePart { get; }
	public string FileVersion { get; }
	public string InternalName { get; }
	public bool IsDebug { get; }
	public bool IsPatched { get; }
	public bool IsPreRelease { get; }
	public bool IsPrivateBuild { get; }
	public bool IsSpecialBuild { get; }
	public string Language { get; }
	public string LegalCopyright { get; }
	public string LegalTrademarks { get; }
	public string OriginalFilename { get; }
	public string PrivateBuild { get; }
	public int ProductBuildPart { get; }
	public int ProductMajorPart { get; }
	public int ProductMinorPart { get; }
	public string ProductName { get; }
	public int ProductPrivatePart { get; }
	public string ProductVersion { get; }
	public string SpecialBuild { get; }

	// Methods

	// RVA: 0x22F3580 Offset: 0x22F2780 VA: 0x1822F3580
	private void .ctor() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Comments() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_CompanyName() { }

	// RVA: 0x772210 Offset: 0x771410 VA: 0x180772210
	public int get_FileBuildPart() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_FileDescription() { }

	// RVA: 0x675950 Offset: 0x674B50 VA: 0x180675950
	public int get_FileMajorPart() { }

	// RVA: 0x772310 Offset: 0x771510 VA: 0x180772310
	public int get_FileMinorPart() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_FileName() { }

	// RVA: 0x772200 Offset: 0x771400 VA: 0x180772200
	public int get_FilePrivatePart() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_FileVersion() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_InternalName() { }

	// RVA: 0x67AA00 Offset: 0x679C00 VA: 0x18067AA00
	public bool get_IsDebug() { }

	// RVA: 0x8CA310 Offset: 0x8C9510 VA: 0x1808CA310
	public bool get_IsPatched() { }

	// RVA: 0x8CA2E0 Offset: 0x8C94E0 VA: 0x1808CA2E0
	public bool get_IsPreRelease() { }

	// RVA: 0x1865E10 Offset: 0x1865010 VA: 0x181865E10
	public bool get_IsPrivateBuild() { }

	// RVA: 0x1AF8A70 Offset: 0x1AF7C70 VA: 0x181AF8A70
	public bool get_IsSpecialBuild() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public string get_Language() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public string get_LegalCopyright() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public string get_LegalTrademarks() { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public string get_OriginalFilename() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public string get_PrivateBuild() { }

	// RVA: 0x5E7ED0 Offset: 0x5E70D0 VA: 0x1805E7ED0
	public int get_ProductBuildPart() { }

	// RVA: 0x838410 Offset: 0x837610 VA: 0x180838410
	public int get_ProductMajorPart() { }

	// RVA: 0x1944140 Offset: 0x1943340 VA: 0x181944140
	public int get_ProductMinorPart() { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public string get_ProductName() { }

	// RVA: 0x6DCF10 Offset: 0x6DC110 VA: 0x1806DCF10
	public int get_ProductPrivatePart() { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public string get_ProductVersion() { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0
	public string get_SpecialBuild() { }

	// RVA: 0x22F28C0 Offset: 0x22F1AC0 VA: 0x1822F28C0
	private void GetVersionInfo_icall(char* fileName, int fileName_length) { }

	// RVA: 0x22F28D0 Offset: 0x22F1AD0 VA: 0x1822F28D0
	private void GetVersionInfo_internal(string fileName) { }

	// RVA: 0x22F2920 Offset: 0x22F1B20 VA: 0x1822F2920
	public static FileVersionInfo GetVersionInfo(string fileName) { }

	// RVA: 0x22F28A0 Offset: 0x22F1AA0 VA: 0x1822F28A0
	private static void AppendFormat(StringBuilder sb, string format, object[] args) { }

	// RVA: 0x22F2A80 Offset: 0x22F1C80 VA: 0x1822F2A80 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Diagnostics
[Usage(32767)]
public class MonitoringDescriptionAttribute : DescriptionAttribute // TypeDefIndex: 5085
{
	// Properties
	public override string Description { get; }

	// Methods

	// RVA: 0x22F3D40 Offset: 0x22F2F40 VA: 0x1822F3D40
	public void .ctor(string description) { }

	// RVA: 0x22F3DA0 Offset: 0x22F2FA0 VA: 0x1822F3DA0 Slot: 7
	public override string get_Description() { }
}

// Namespace: System.Diagnostics
public class ProcessModule : Component // TypeDefIndex: 5086
{
	// Fields
	private IntPtr baseaddr; // 0x28
	private IntPtr entryaddr; // 0x30
	private string filename; // 0x38
	private FileVersionInfo version_info; // 0x40
	private int memory_size; // 0x48
	private string modulename; // 0x50

	// Properties
	[MonitoringDescription("The base memory address of this module")]
	public IntPtr BaseAddress { get; }
	[MonitoringDescription("The base memory address of the entry point of this module")]
	public IntPtr EntryPointAddress { get; }
	[MonitoringDescription("The file name of this module")]
	public string FileName { get; }
	[Browsable(False)]
	public FileVersionInfo FileVersionInfo { get; }
	[MonitoringDescription("The memory needed by this module")]
	public int ModuleMemorySize { get; }
	[MonitoringDescription("The name of this module")]
	public string ModuleName { get; }

	// Methods

	// RVA: 0x22F5AA0 Offset: 0x22F4CA0 VA: 0x1822F5AA0
	internal void .ctor(IntPtr baseaddr, IntPtr entryaddr, string filename, FileVersionInfo version_info, int memory_size, string modulename) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public IntPtr get_BaseAddress() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public IntPtr get_EntryPointAddress() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_FileName() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public FileVersionInfo get_FileVersionInfo() { }

	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0
	public int get_ModuleMemorySize() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public string get_ModuleName() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x22F5B40 Offset: 0x22F4D40 VA: 0x1822F5B40
	internal void .ctor() { }
}

// Namespace: System.Diagnostics
public enum ProcessPriorityClass // TypeDefIndex: 5087
{
	// Fields
	public int value__; // 0x0
	public const ProcessPriorityClass AboveNormal = 32768;
	public const ProcessPriorityClass BelowNormal = 16384;
	public const ProcessPriorityClass High = 128;
	public const ProcessPriorityClass Idle = 64;
	public const ProcessPriorityClass Normal = 32;
	public const ProcessPriorityClass RealTime = 256;
}

// Namespace: System.Diagnostics
public class ProcessThread : Component // TypeDefIndex: 5088
{
	// Properties
	[MonoTODO]
	[MonitoringDescription("The base priority of this thread.")]
	public int BasePriority { get; }
	[MonoTODO]
	[MonitoringDescription("The current priority of this thread.")]
	public int CurrentPriority { get; }
	[MonitoringDescription("The ID of this thread.")]
	[MonoTODO]
	public int Id { get; }
	[Browsable(False)]
	[MonoTODO]
	public int IdealProcessor { set; }
	[MonoTODO]
	[MonitoringDescription("Thread gets a priority boot when interactively used by a user.")]
	public bool PriorityBoostEnabled { get; set; }
	[MonitoringDescription("The priority level of this thread.")]
	[MonoTODO]
	public ThreadPriorityLevel PriorityLevel { get; set; }
	[MonitoringDescription("The amount of CPU time used in privileged mode.")]
	[MonoTODO]
	public TimeSpan PrivilegedProcessorTime { get; }
	[MonoTODO]
	[Browsable(False)]
	public IntPtr ProcessorAffinity { set; }
	[MonoTODO]
	[MonitoringDescription("The start address in memory of this thread.")]
	public IntPtr StartAddress { get; }
	[MonitoringDescription("The time this thread was started.")]
	[MonoTODO]
	public DateTime StartTime { get; }
	[MonitoringDescription("The current state of this thread.")]
	[MonoTODO]
	public ThreadState ThreadState { get; }
	[MonitoringDescription("The total amount of CPU time used.")]
	[MonoTODO]
	public TimeSpan TotalProcessorTime { get; }
	[MonoTODO]
	[MonitoringDescription("The amount of CPU time used in user mode.")]
	public TimeSpan UserProcessorTime { get; }
	[MonoTODO]
	[MonitoringDescription("The reason why this thread is waiting.")]
	public ThreadWaitReason WaitReason { get; }

	// Methods

	[MonoTODO("Parse parameters")]
	// RVA: 0x22F5B70 Offset: 0x22F4D70 VA: 0x1822F5B70
	internal void .ctor() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public int get_BasePriority() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public int get_CurrentPriority() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public int get_Id() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_IdealProcessor(int value) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	public bool get_PriorityBoostEnabled() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_PriorityBoostEnabled(bool value) { }

	// RVA: 0x22F5BC0 Offset: 0x22F4DC0 VA: 0x1822F5BC0
	public ThreadPriorityLevel get_PriorityLevel() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_PriorityLevel(ThreadPriorityLevel value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public TimeSpan get_PrivilegedProcessorTime() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_ProcessorAffinity(IntPtr value) { }

	// RVA: 0x22D7040 Offset: 0x22D6240 VA: 0x1822D7040
	public IntPtr get_StartAddress() { }

	// RVA: 0x22F5BD0 Offset: 0x22F4DD0 VA: 0x1822F5BD0
	public DateTime get_StartTime() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public ThreadState get_ThreadState() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public TimeSpan get_TotalProcessorTime() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public TimeSpan get_UserProcessorTime() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public ThreadWaitReason get_WaitReason() { }

	[MonoTODO]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void ResetIdealProcessor() { }
}

// Namespace: System.Diagnostics
public enum ProcessWindowStyle // TypeDefIndex: 5089
{
	// Fields
	public int value__; // 0x0
	public const ProcessWindowStyle Hidden = 1;
	public const ProcessWindowStyle Maximized = 3;
	public const ProcessWindowStyle Minimized = 2;
	public const ProcessWindowStyle Normal = 0;
}

// Namespace: System.Diagnostics
public class Stopwatch // TypeDefIndex: 5090
{
	// Fields
	public static readonly long Frequency; // 0x0
	public static readonly bool IsHighResolution; // 0x8
	private long elapsed; // 0x10
	private long started; // 0x18
	private bool is_running; // 0x20

	// Properties
	public TimeSpan Elapsed { get; }
	public long ElapsedMilliseconds { get; }
	public long ElapsedTicks { get; }
	public bool IsRunning { get; }

	// Methods

	// RVA: 0x15AFF00 Offset: 0x15AF100 VA: 0x1815AFF00
	public static long GetTimestamp() { }

	// RVA: 0x22F8220 Offset: 0x22F7420 VA: 0x1822F8220
	public static Stopwatch StartNew() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x22F8750 Offset: 0x22F7950 VA: 0x1822F8750
	public TimeSpan get_Elapsed() { }

	// RVA: 0x22F83F0 Offset: 0x22F75F0 VA: 0x1822F83F0
	public long get_ElapsedMilliseconds() { }

	// RVA: 0x22F86E0 Offset: 0x22F78E0 VA: 0x1822F86E0
	public long get_ElapsedTicks() { }

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_IsRunning() { }

	// RVA: 0x22F81B0 Offset: 0x22F73B0 VA: 0x1822F81B0
	public void Reset() { }

	// RVA: 0x22F82C0 Offset: 0x22F74C0 VA: 0x1822F82C0
	public void Start() { }

	// RVA: 0x22F8320 Offset: 0x22F7520 VA: 0x1822F8320
	public void Stop() { }

	// RVA: 0x22F81C0 Offset: 0x22F73C0 VA: 0x1822F81C0
	public void Restart() { }

	// RVA: 0x22F83A0 Offset: 0x22F75A0 VA: 0x1822F83A0
	private static void .cctor() { }
}

// Namespace: System.Diagnostics
public enum ThreadPriorityLevel // TypeDefIndex: 5091
{
	// Fields
	public int value__; // 0x0
	public const ThreadPriorityLevel AboveNormal = 1;
	public const ThreadPriorityLevel BelowNormal = -1;
	public const ThreadPriorityLevel Highest = 2;
	public const ThreadPriorityLevel Idle = -15;
	public const ThreadPriorityLevel Lowest = -2;
	public const ThreadPriorityLevel Normal = 0;
	public const ThreadPriorityLevel TimeCritical = 15;
}

// Namespace: System.Diagnostics
public enum ThreadState // TypeDefIndex: 5092
{
	// Fields
	public int value__; // 0x0
	public const ThreadState Initialized = 0;
	public const ThreadState Ready = 1;
	public const ThreadState Running = 2;
	public const ThreadState Standby = 3;
	public const ThreadState Terminated = 4;
	public const ThreadState Transition = 6;
	public const ThreadState Unknown = 7;
	public const ThreadState Wait = 5;
}

// Namespace: System.Diagnostics
public enum ThreadWaitReason // TypeDefIndex: 5093
{
	// Fields
	public int value__; // 0x0
	public const ThreadWaitReason EventPairHigh = 7;
	public const ThreadWaitReason EventPairLow = 8;
	public const ThreadWaitReason ExecutionDelay = 4;
	public const ThreadWaitReason Executive = 0;
	public const ThreadWaitReason FreePage = 1;
	public const ThreadWaitReason LpcReceive = 9;
	public const ThreadWaitReason LpcReply = 10;
	public const ThreadWaitReason PageIn = 2;
	public const ThreadWaitReason PageOut = 12;
	public const ThreadWaitReason Suspended = 5;
	public const ThreadWaitReason SystemAllocation = 3;
	public const ThreadWaitReason Unknown = 13;
	public const ThreadWaitReason UserRequest = 6;
	public const ThreadWaitReason VirtualMemory = 11;
}

// Namespace: System.Diagnostics.CodeAnalysis
[Usage(749, Inherited = False, AllowMultiple = False)]
public sealed class ExcludeFromCodeCoverageAttribute : Attribute // TypeDefIndex: 5094
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Security
public static class SecureStringMarshal // TypeDefIndex: 5095
{
	// Methods

	// RVA: 0x22F6DF0 Offset: 0x22F5FF0 VA: 0x1822F6DF0
	public static IntPtr SecureStringToCoTaskMemAnsi(SecureString s) { }

	// RVA: 0x22F6E90 Offset: 0x22F6090 VA: 0x1822F6E90
	public static IntPtr SecureStringToGlobalAllocAnsi(SecureString s) { }

	// RVA: 0x22F6E40 Offset: 0x22F6040 VA: 0x1822F6E40
	public static IntPtr SecureStringToCoTaskMemUnicode(SecureString s) { }

	// RVA: 0x22F6EE0 Offset: 0x22F60E0 VA: 0x1822F6EE0
	public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s) { }
}

// Namespace: System.Security.AccessControl
[ComVisible(False)]
public sealed class SemaphoreAccessRule : AccessRule // TypeDefIndex: 5096
{
	// Properties
	public SemaphoreRights SemaphoreRights { get; }

	// Methods

	// RVA: 0x22F6FD0 Offset: 0x22F61D0 VA: 0x1822F6FD0
	public void .ctor(IdentityReference identity, SemaphoreRights eventRights, AccessControlType type) { }

	// RVA: 0x22F6F30 Offset: 0x22F6130 VA: 0x1822F6F30
	public void .ctor(string identity, SemaphoreRights eventRights, AccessControlType type) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public SemaphoreRights get_SemaphoreRights() { }
}

// Namespace: System.Security.AccessControl
[ComVisible(False)]
public sealed class SemaphoreAuditRule : AuditRule // TypeDefIndex: 5097
{
	// Properties
	public SemaphoreRights SemaphoreRights { get; }

	// Methods

	// RVA: 0x22F7000 Offset: 0x22F6200 VA: 0x1822F7000
	public void .ctor(IdentityReference identity, SemaphoreRights eventRights, AuditFlags flags) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public SemaphoreRights get_SemaphoreRights() { }
}

// Namespace: System.Security.AccessControl
[Flags]
[ComVisible(False)]
public enum SemaphoreRights // TypeDefIndex: 5098
{
	// Fields
	public int value__; // 0x0
	public const SemaphoreRights Modify = 2;
	public const SemaphoreRights Delete = 65536;
	public const SemaphoreRights ReadPermissions = 131072;
	public const SemaphoreRights ChangePermissions = 262144;
	public const SemaphoreRights TakeOwnership = 524288;
	public const SemaphoreRights Synchronize = 1048576;
	public const SemaphoreRights FullControl = 2031619;
}

// Namespace: System.Security.AccessControl
[ComVisible(False)]
public sealed class SemaphoreSecurity : NativeObjectSecurity // TypeDefIndex: 5099
{
	// Properties
	public override Type AccessRightType { get; }
	public override Type AccessRuleType { get; }
	public override Type AuditRuleType { get; }

	// Methods

	// RVA: 0x22F72D0 Offset: 0x22F64D0 VA: 0x1822F72D0
	public void .ctor() { }

	// RVA: 0x22F72E0 Offset: 0x22F64E0 VA: 0x1822F72E0
	public void .ctor(string name, AccessControlSections includeSections) { }

	// RVA: 0x22F7310 Offset: 0x22F6510 VA: 0x1822F7310
	internal void .ctor(SafeHandle handle, AccessControlSections includeSections) { }

	// RVA: 0x22F7340 Offset: 0x22F6540 VA: 0x1822F7340 Slot: 4
	public override Type get_AccessRightType() { }

	// RVA: 0x22F73A0 Offset: 0x22F65A0 VA: 0x1822F73A0 Slot: 5
	public override Type get_AccessRuleType() { }

	// RVA: 0x22F7400 Offset: 0x22F6600 VA: 0x1822F7400 Slot: 6
	public override Type get_AuditRuleType() { }

	// RVA: 0x22F7030 Offset: 0x22F6230 VA: 0x1822F7030 Slot: 7
	public override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type) { }

	// RVA: 0x22F70B0 Offset: 0x22F62B0 VA: 0x1822F70B0
	public void AddAccessRule(SemaphoreAccessRule rule) { }

	// RVA: 0x22F7260 Offset: 0x22F6460 VA: 0x1822F7260
	public bool RemoveAccessRule(SemaphoreAccessRule rule) { }

	// RVA: 0x22F7240 Offset: 0x22F6440 VA: 0x1822F7240
	public void RemoveAccessRuleAll(SemaphoreAccessRule rule) { }

	// RVA: 0x22F7250 Offset: 0x22F6450 VA: 0x1822F7250
	public void RemoveAccessRuleSpecific(SemaphoreAccessRule rule) { }

	// RVA: 0x22F72A0 Offset: 0x22F64A0 VA: 0x1822F72A0
	public void ResetAccessRule(SemaphoreAccessRule rule) { }

	// RVA: 0x22F72B0 Offset: 0x22F64B0 VA: 0x1822F72B0
	public void SetAccessRule(SemaphoreAccessRule rule) { }

	// RVA: 0x22F70D0 Offset: 0x22F62D0 VA: 0x1822F70D0 Slot: 8
	public override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags) { }

	// RVA: 0x22F70C0 Offset: 0x22F62C0 VA: 0x1822F70C0
	public void AddAuditRule(SemaphoreAuditRule rule) { }

	// RVA: 0x22F7290 Offset: 0x22F6490 VA: 0x1822F7290
	public bool RemoveAuditRule(SemaphoreAuditRule rule) { }

	// RVA: 0x22F7270 Offset: 0x22F6470 VA: 0x1822F7270
	public void RemoveAuditRuleAll(SemaphoreAuditRule rule) { }

	// RVA: 0x22F7280 Offset: 0x22F6480 VA: 0x1822F7280
	public void RemoveAuditRuleSpecific(SemaphoreAuditRule rule) { }

	// RVA: 0x22F72C0 Offset: 0x22F64C0 VA: 0x1822F72C0
	public void SetAuditRule(SemaphoreAuditRule rule) { }

	// RVA: 0x22F7150 Offset: 0x22F6350 VA: 0x1822F7150
	internal void Persist(SafeHandle handle) { }
}

// Namespace: System.Security.Permissions
[Flags]
[Serializable]
public enum TypeDescriptorPermissionFlags // TypeDefIndex: 5100
{
	// Fields
	public int value__; // 0x0
	public const TypeDescriptorPermissionFlags NoFlags = 0;
	public const TypeDescriptorPermissionFlags RestrictedRegistrationAccess = 1;
}

// Namespace: System.Security.Permissions
[Serializable]
public sealed class TypeDescriptorPermission : CodeAccessPermission, IUnrestrictedPermission // TypeDefIndex: 5101
{
	// Fields
	private TypeDescriptorPermissionFlags m_flags; // 0x10

	// Properties
	public TypeDescriptorPermissionFlags Flags { get; set; }

	// Methods

	// RVA: 0x22FA0F0 Offset: 0x22F92F0 VA: 0x1822FA0F0
	public void .ctor(PermissionState state) { }

	// RVA: 0x22FA190 Offset: 0x22F9390 VA: 0x1822FA190
	public void .ctor(TypeDescriptorPermissionFlags flag) { }

	// RVA: 0x22F9B90 Offset: 0x22F8D90 VA: 0x1822F9B90
	private void SetUnrestricted(bool unrestricted) { }

	// RVA: 0x6CB260 Offset: 0x6CA460 VA: 0x1806CB260
	private void Reset() { }

	// RVA: 0x22FA1D0 Offset: 0x22F93D0 VA: 0x1822FA1D0
	public void set_Flags(TypeDescriptorPermissionFlags value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public TypeDescriptorPermissionFlags get_Flags() { }

	// RVA: 0xBE5120 Offset: 0xBE4320 VA: 0x180BE5120 Slot: 14
	public bool IsUnrestricted() { }

	// RVA: 0x22F9DD0 Offset: 0x22F8FD0 VA: 0x1822F9DD0 Slot: 13
	public override IPermission Union(IPermission target) { }

	// RVA: 0x22F9A40 Offset: 0x22F8C40 VA: 0x1822F9A40 Slot: 11
	public override bool IsSubsetOf(IPermission target) { }

	// RVA: 0x22F98D0 Offset: 0x22F8AD0 VA: 0x1822F98D0 Slot: 10
	public override IPermission Intersect(IPermission target) { }

	// RVA: 0x22F9500 Offset: 0x22F8700 VA: 0x1822F9500 Slot: 7
	public override IPermission Copy() { }

	// RVA: 0x22F9F50 Offset: 0x22F9150 VA: 0x1822F9F50
	private void VerifyAccess(TypeDescriptorPermissionFlags type) { }

	// RVA: 0x22F9BA0 Offset: 0x22F8DA0 VA: 0x1822F9BA0 Slot: 12
	public override SecurityElement ToXml() { }

	// RVA: 0x22F9570 Offset: 0x22F8770 VA: 0x1822F9570 Slot: 9
	public override void FromXml(SecurityElement securityElement) { }

	// RVA: 0x22FA020 Offset: 0x22F9220 VA: 0x1822FA020
	internal static void VerifyFlags(TypeDescriptorPermissionFlags flags) { }
}

// Namespace: System.Security.Authentication
[Serializable]
public class AuthenticationException : SystemException // TypeDefIndex: 5102
{
	// Methods

	// RVA: 0x22ECB10 Offset: 0x22EBD10 VA: 0x1822ECB10
	public void .ctor() { }

	// RVA: 0x160B4C0 Offset: 0x160A6C0 VA: 0x18160B4C0
	public void .ctor(string message) { }

	// RVA: 0x1633A30 Offset: 0x1632C30 VA: 0x181633A30
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }
}

// Namespace: System.Security.Authentication
public enum CipherAlgorithmType // TypeDefIndex: 5103
{
	// Fields
	public int value__; // 0x0
	public const CipherAlgorithmType None = 0;
	public const CipherAlgorithmType Null = 24576;
	public const CipherAlgorithmType Aes = 26129;
	public const CipherAlgorithmType Aes128 = 26126;
	public const CipherAlgorithmType Aes192 = 26127;
	public const CipherAlgorithmType Aes256 = 26128;
	public const CipherAlgorithmType Des = 26113;
	public const CipherAlgorithmType Rc2 = 26114;
	public const CipherAlgorithmType Rc4 = 26625;
	public const CipherAlgorithmType TripleDes = 26115;
}

// Namespace: System.Security.Authentication
public enum ExchangeAlgorithmType // TypeDefIndex: 5104
{
	// Fields
	public int value__; // 0x0
	public const ExchangeAlgorithmType None = 0;
	public const ExchangeAlgorithmType DiffieHellman = 43522;
	public const ExchangeAlgorithmType RsaKeyX = 41984;
	public const ExchangeAlgorithmType RsaSign = 9216;
}

// Namespace: System.Security.Authentication
public enum HashAlgorithmType // TypeDefIndex: 5105
{
	// Fields
	public int value__; // 0x0
	public const HashAlgorithmType None = 0;
	public const HashAlgorithmType Md5 = 32771;
	public const HashAlgorithmType Sha1 = 32772;
	public const HashAlgorithmType Sha256 = 32780;
	public const HashAlgorithmType Sha384 = 32781;
	public const HashAlgorithmType Sha512 = 32782;
}

// Namespace: System.Security.Authentication
[Serializable]
public class InvalidCredentialException : AuthenticationException // TypeDefIndex: 5106
{
	// Methods

	// RVA: 0x22F3CF0 Offset: 0x22F2EF0 VA: 0x1822F3CF0
	public void .ctor() { }

	// RVA: 0x160B4C0 Offset: 0x160A6C0 VA: 0x18160B4C0
	public void .ctor(string message) { }

	// RVA: 0x1633A30 Offset: 0x1632C30 VA: 0x181633A30
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x15ABEC0 Offset: 0x15AB0C0 VA: 0x1815ABEC0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }
}

// Namespace: System.Security.Authentication
[Flags]
public enum SslProtocols // TypeDefIndex: 5107
{
	// Fields
	public int value__; // 0x0
	public const SslProtocols None = 0;
	public const SslProtocols Ssl2 = 12;
	public const SslProtocols Ssl3 = 48;
	public const SslProtocols Tls = 192;
	[MonoTODO("unsupported")]
	public const SslProtocols Tls11 = 768;
	[MonoTODO("unsupported")]
	public const SslProtocols Tls12 = 3072;
	public const SslProtocols Tls13 = 12288;
	public const SslProtocols Default = 240;
}

// Namespace: System.Security.Authentication.ExtendedProtection
[Serializable]
public class ServiceNameCollection : ReadOnlyCollectionBase // TypeDefIndex: 5108
{
	// Methods

	// RVA: 0x22F7F60 Offset: 0x22F7160 VA: 0x1822F7F60
	public void .ctor(ICollection items) { }

	// RVA: 0x22F7730 Offset: 0x22F6930 VA: 0x1822F7730
	public ServiceNameCollection Merge(string serviceName) { }

	// RVA: 0x22F7800 Offset: 0x22F6A00 VA: 0x1822F7800
	public ServiceNameCollection Merge(IEnumerable serviceNames) { }

	// RVA: 0x22F7460 Offset: 0x22F6660 VA: 0x1822F7460
	private static void AddIfNew(ArrayList newServiceNames, string serviceName) { }

	// RVA: 0x22F7570 Offset: 0x22F6770 VA: 0x1822F7570
	internal static bool Contains(string searchServiceName, ICollection serviceNames) { }

	// RVA: 0x22F7530 Offset: 0x22F6730 VA: 0x1822F7530
	public bool Contains(string searchServiceName) { }

	// RVA: 0x22F7B10 Offset: 0x22F6D10 VA: 0x1822F7B10
	internal static string NormalizeServiceName(string inputServiceName) { }

	// RVA: 0x22F7710 Offset: 0x22F6910 VA: 0x1822F7710
	internal static bool Match(string serviceName1, string serviceName2) { }
}

// Namespace: System.Security.Authentication.ExtendedProtection
public enum TokenBindingType // TypeDefIndex: 5109
{
	// Fields
	public int value__; // 0x0
	public const TokenBindingType Provided = 0;
	public const TokenBindingType Referred = 1;
}

// Namespace: System.Security.Authentication.ExtendedProtection
public class TokenBinding // TypeDefIndex: 5110
{
	// Fields
	private byte[] _rawTokenBindingId; // 0x10
	[CompilerGenerated]
	private TokenBindingType <BindingType>k__BackingField; // 0x18

	// Properties
	public TokenBindingType BindingType { get; set; }

	// Methods

	// RVA: 0x22F94C0 Offset: 0x22F86C0 VA: 0x1822F94C0
	internal void .ctor(TokenBindingType bindingType, byte[] rawData) { }

	// RVA: 0x22F9410 Offset: 0x22F8610 VA: 0x1822F9410
	public byte[] GetRawTokenBindingId() { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public TokenBindingType get_BindingType() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	private void set_BindingType(TokenBindingType value) { }

	// RVA: 0x22F9490 Offset: 0x22F8690 VA: 0x1822F9490
	internal void .ctor() { }
}

// Namespace: System.Security.Authentication.ExtendedProtection
public abstract class ChannelBinding : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 5111
{
	// Properties
	public abstract int Size { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_Size();

	// RVA: 0x225AD80 Offset: 0x2259F80 VA: 0x18225AD80
	protected void .ctor() { }

	// RVA: 0x22ECB60 Offset: 0x22EBD60 VA: 0x1822ECB60
	protected void .ctor(bool ownsHandle) { }
}

// Namespace: System.Security.Authentication.ExtendedProtection
public enum ChannelBindingKind // TypeDefIndex: 5112
{
	// Fields
	public int value__; // 0x0
	public const ChannelBindingKind Unknown = 0;
	public const ChannelBindingKind Unique = 25;
	public const ChannelBindingKind Endpoint = 26;
}

// Namespace: System.Security.Authentication.ExtendedProtection
[TypeConverter(typeof(ExtendedProtectionPolicyTypeConverter))]
[MonoTODO]
[Serializable]
public class ExtendedProtectionPolicy : ISerializable // TypeDefIndex: 5113
{
	// Properties
	public ChannelBinding CustomChannelBinding { get; }
	public ServiceNameCollection CustomServiceNames { get; }
	public static bool OSSupportsExtendedProtection { get; }
	public PolicyEnforcement PolicyEnforcement { get; }
	public ProtectionScenario ProtectionScenario { get; }

	// Methods

	[MonoTODO("Not implemented.")]
	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor(PolicyEnforcement policyEnforcement) { }

	// RVA: 0x22F2620 Offset: 0x22F1820 VA: 0x1822F2620
	public void .ctor(PolicyEnforcement policyEnforcement, ChannelBinding customChannelBinding) { }

	// RVA: 0x22F2670 Offset: 0x22F1870 VA: 0x1822F2670
	public void .ctor(PolicyEnforcement policyEnforcement, ProtectionScenario protectionScenario, ICollection customServiceNames) { }

	// RVA: 0x22F26C0 Offset: 0x22F18C0 VA: 0x1822F26C0
	public void .ctor(PolicyEnforcement policyEnforcement, ProtectionScenario protectionScenario, ServiceNameCollection customServiceNames) { }

	// RVA: 0x22F2710 Offset: 0x22F1910 VA: 0x1822F2710
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x22F2760 Offset: 0x22F1960 VA: 0x1822F2760
	public ChannelBinding get_CustomChannelBinding() { }

	// RVA: 0x22F27A0 Offset: 0x22F19A0 VA: 0x1822F27A0
	public ServiceNameCollection get_CustomServiceNames() { }

	// RVA: 0x22F27E0 Offset: 0x22F19E0 VA: 0x1822F27E0
	public static bool get_OSSupportsExtendedProtection() { }

	// RVA: 0x22F2820 Offset: 0x22F1A20 VA: 0x1822F2820
	public PolicyEnforcement get_PolicyEnforcement() { }

	// RVA: 0x22F2860 Offset: 0x22F1A60 VA: 0x1822F2860
	public ProtectionScenario get_ProtectionScenario() { }

	[MonoTODO]
	// RVA: 0x16AEA30 Offset: 0x16ADC30 VA: 0x1816AEA30 Slot: 3
	public override string ToString() { }

	// RVA: 0x22F25E0 Offset: 0x22F17E0 VA: 0x1822F25E0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Security.Authentication.ExtendedProtection
[MonoTODO]
public class ExtendedProtectionPolicyTypeConverter : TypeConverter // TypeDefIndex: 5114
{
	// Methods

	// RVA: 0x22F2560 Offset: 0x22F1760 VA: 0x1822F2560 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x22F25A0 Offset: 0x22F17A0 VA: 0x1822F25A0 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Security.Authentication.ExtendedProtection
public enum PolicyEnforcement // TypeDefIndex: 5115
{
	// Fields
	public int value__; // 0x0
	public const PolicyEnforcement Never = 0;
	public const PolicyEnforcement WhenSupported = 1;
	public const PolicyEnforcement Always = 2;
}

// Namespace: System.Security.Authentication.ExtendedProtection
public enum ProtectionScenario // TypeDefIndex: 5116
{
	// Fields
	public int value__; // 0x0
	public const ProtectionScenario TransportSelected = 0;
	public const ProtectionScenario TrustedProxy = 1;
}

// Namespace: 
private class DerEncoder.AsnSetValueComparer : IComparer<byte[][]>, IComparer // TypeDefIndex: 5117
{
	// Fields
	[CompilerGenerated]
	private static readonly DerEncoder.AsnSetValueComparer <Instance>k__BackingField; // 0x0

	// Properties
	public static DerEncoder.AsnSetValueComparer Instance { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x22ECAC0 Offset: 0x22EBCC0 VA: 0x1822ECAC0
	public static DerEncoder.AsnSetValueComparer get_Instance() { }

	// RVA: 0x22EC970 Offset: 0x22EBB70 VA: 0x1822EC970 Slot: 4
	public int Compare(byte[][] x, byte[][] y) { }

	// RVA: 0x22EC840 Offset: 0x22EBA40 VA: 0x1822EC840 Slot: 5
	public int Compare(object x, object y) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x22ECA60 Offset: 0x22EBC60 VA: 0x1822ECA60
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
internal static class DerEncoder // TypeDefIndex: 5118
{
	// Fields
	private const byte ConstructedFlag = 32;
	private const byte ConstructedSequenceTag = 48;
	private const byte ConstructedSetTag = 49;
	private static readonly byte[][] s_nullTlv; // 0x0

	// Methods

	// RVA: 0x22ED970 Offset: 0x22ECB70 VA: 0x1822ED970
	private static byte[] EncodeLength(int length) { }

	// RVA: 0x22EE8E0 Offset: 0x22EDAE0 VA: 0x1822EE8E0
	internal static byte[][] SegmentedEncodeBoolean(bool value) { }

	// RVA: 0x22EFDB0 Offset: 0x22EEFB0 VA: 0x1822EFDB0
	internal static byte[][] SegmentedEncodeUnsignedInteger(uint value) { }

	// RVA: 0x22EFB30 Offset: 0x22EED30 VA: 0x1822EFB30
	internal static byte[][] SegmentedEncodeUnsignedInteger(ReadOnlySpan<byte> bigEndianBytes) { }

	// RVA: 0x22EE700 Offset: 0x22ED900 VA: 0x1822EE700
	internal static byte[][] SegmentedEncodeBitString(byte[][][] childSegments) { }

	// RVA: 0x22EE590 Offset: 0x22ED790 VA: 0x1822EE590
	internal static byte[][] SegmentedEncodeBitString(byte[] data) { }

	// RVA: 0x22EE430 Offset: 0x22ED630 VA: 0x1822EE430
	internal static byte[][] SegmentedEncodeBitString(int unusedBits, byte[] data) { }

	// RVA: 0x22EF0C0 Offset: 0x22EE2C0 VA: 0x1822EF0C0
	internal static byte[][] SegmentedEncodeNamedBitList(byte[] bigEndianBytes, int namedBitsCount) { }

	// RVA: 0x22EF330 Offset: 0x22EE530 VA: 0x1822EF330
	internal static byte[][] SegmentedEncodeOctetString(byte[] data) { }

	// RVA: 0x22EF2E0 Offset: 0x22EE4E0 VA: 0x1822EF2E0
	internal static byte[][] SegmentedEncodeNull() { }

	// RVA: 0x22EDB50 Offset: 0x22ECD50 VA: 0x1822EDB50
	internal static byte[] EncodeOid(string oidValue) { }

	// RVA: 0x22EF810 Offset: 0x22EEA10 VA: 0x1822EF810
	internal static byte[][] SegmentedEncodeOid(Oid oid) { }

	// RVA: 0x22EF410 Offset: 0x22EE610 VA: 0x1822EF410
	internal static byte[][] SegmentedEncodeOid(string oidValue) { }

	// RVA: 0x22F0290 Offset: 0x22EF490 VA: 0x1822F0290
	internal static byte[][] SegmentedEncodeUtf8String(char[] chars) { }

	// RVA: 0x22F03E0 Offset: 0x22EF5E0 VA: 0x1822F03E0
	internal static byte[][] SegmentedEncodeUtf8String(char[] chars, int offset, int count) { }

	// RVA: 0x22ED180 Offset: 0x22EC380 VA: 0x1822ED180
	internal static byte[][] ConstructSegmentedSequence(byte[][][] items) { }

	// RVA: 0x22ED2A0 Offset: 0x22EC4A0 VA: 0x1822ED2A0
	internal static byte[][] ConstructSegmentedSequence(IEnumerable<byte[][]> items) { }

	// RVA: 0x22ECF30 Offset: 0x22EC130 VA: 0x1822ECF30
	internal static byte[][] ConstructSegmentedContextSpecificValue(int contextId, byte[][][] items) { }

	// RVA: 0x22ED390 Offset: 0x22EC590 VA: 0x1822ED390
	internal static byte[][] ConstructSegmentedSet(byte[][][] items) { }

	// RVA: 0x22ED060 Offset: 0x22EC260 VA: 0x1822ED060
	internal static byte[][] ConstructSegmentedPresortedSet(byte[][][] items) { }

	// RVA: 0x22EE040 Offset: 0x22ED240 VA: 0x1822EE040
	internal static bool IsValidPrintableString(char[] chars) { }

	// RVA: 0x22EDED0 Offset: 0x22ED0D0 VA: 0x1822EDED0
	internal static bool IsValidPrintableString(char[] chars, int offset, int count) { }

	// RVA: 0x22EF870 Offset: 0x22EEA70 VA: 0x1822EF870
	internal static byte[][] SegmentedEncodePrintableString(char[] chars) { }

	// RVA: 0x22EF9E0 Offset: 0x22EEBE0 VA: 0x1822EF9E0
	internal static byte[][] SegmentedEncodePrintableString(char[] chars, int offset, int count) { }

	// RVA: 0x22EEEB0 Offset: 0x22EE0B0 VA: 0x1822EEEB0
	internal static byte[][] SegmentedEncodeIA5String(char[] chars) { }

	// RVA: 0x22EEF10 Offset: 0x22EE110 VA: 0x1822EEF10
	internal static byte[][] SegmentedEncodeIA5String(char[] chars, int offset, int count) { }

	// RVA: 0x22EFE50 Offset: 0x22EF050 VA: 0x1822EFE50
	internal static byte[][] SegmentedEncodeUtcTime(DateTime utcTime) { }

	// RVA: 0x22EE9E0 Offset: 0x22EDBE0 VA: 0x1822EE9E0
	internal static byte[][] SegmentedEncodeGeneralizedTime(DateTime utcTime) { }

	// RVA: 0x22ED920 Offset: 0x22ECB20 VA: 0x1822ED920
	internal static byte[] ConstructSequence(byte[][][] items) { }

	// RVA: 0x22ED590 Offset: 0x22EC790 VA: 0x1822ED590
	internal static byte[] ConstructSequence(IEnumerable<byte[][]> items) { }

	// RVA: 0x22EE1E0 Offset: 0x22ED3E0 VA: 0x1822EE1E0
	private static BigInteger ParseOidRid(string oidValue, ref int startIndex) { }

	// RVA: 0x22ECB70 Offset: 0x22EBD70 VA: 0x1822ECB70
	private static int AtoI(char c) { }

	// RVA: 0x22EDC20 Offset: 0x22ECE20 VA: 0x1822EDC20
	private static void EncodeRid(List<byte> encodedData, ref BigInteger rid) { }

	// RVA: 0x22EDE20 Offset: 0x22ED020 VA: 0x1822EDE20
	private static bool IsPrintableStringCharacter(char c) { }

	// RVA: 0x22ECEE0 Offset: 0x22EC0E0 VA: 0x1822ECEE0
	private static byte[] ConcatenateArrays(byte[][][] segments) { }

	// RVA: 0x22ECBE0 Offset: 0x22EBDE0 VA: 0x1822ECBE0
	private static byte[] ConcatenateArrays(IEnumerable<byte[][]> segments) { }

	// RVA: 0x22F0500 Offset: 0x22EF700 VA: 0x1822F0500
	private static void .cctor() { }
}

// Namespace: 
internal enum DerSequenceReader.DerTag // TypeDefIndex: 5119
{
	// Fields
	public byte value__; // 0x0
	public const DerSequenceReader.DerTag Boolean = 1;
	public const DerSequenceReader.DerTag Integer = 2;
	public const DerSequenceReader.DerTag BitString = 3;
	public const DerSequenceReader.DerTag OctetString = 4;
	public const DerSequenceReader.DerTag Null = 5;
	public const DerSequenceReader.DerTag ObjectIdentifier = 6;
	public const DerSequenceReader.DerTag UTF8String = 12;
	public const DerSequenceReader.DerTag Sequence = 16;
	public const DerSequenceReader.DerTag Set = 17;
	public const DerSequenceReader.DerTag PrintableString = 19;
	public const DerSequenceReader.DerTag T61String = 20;
	public const DerSequenceReader.DerTag IA5String = 22;
	public const DerSequenceReader.DerTag UTCTime = 23;
	public const DerSequenceReader.DerTag GeneralizedTime = 24;
	public const DerSequenceReader.DerTag BMPString = 30;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DerSequenceReader.<>c // TypeDefIndex: 5120
{
	// Fields
	public static readonly DerSequenceReader.<>c <>9; // 0x0
	public static Func<Encoding> <>9__45_0; // 0x8
	public static Func<Encoding> <>9__45_1; // 0x10
	public static Func<DateTimeFormatInfo> <>9__51_0; // 0x18

	// Methods

	// RVA: 0x22FA360 Offset: 0x22F9560 VA: 0x1822FA360
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x22FA200 Offset: 0x22F9400 VA: 0x1822FA200
	internal Encoding <ReadT61String>b__45_0() { }

	// RVA: 0x22FA250 Offset: 0x22F9450 VA: 0x1822FA250
	internal Encoding <ReadT61String>b__45_1() { }

	// RVA: 0x22FA290 Offset: 0x22F9490 VA: 0x1822FA290
	internal DateTimeFormatInfo <ReadTime>b__51_0() { }
}

// Namespace: System.Security.Cryptography
internal class DerSequenceReader // TypeDefIndex: 5121
{
	// Fields
	internal const byte ContextSpecificTagFlag = 128;
	internal const byte ConstructedFlag = 32;
	internal const byte ContextSpecificConstructedTag0 = 160;
	internal const byte ContextSpecificConstructedTag1 = 161;
	internal const byte ContextSpecificConstructedTag2 = 162;
	internal const byte ContextSpecificConstructedTag3 = 163;
	internal const byte ConstructedSequence = 48;
	internal const byte TagClassMask = 192;
	internal const byte TagNumberMask = 31;
	internal static DateTimeFormatInfo s_validityDateTimeFormatInfo; // 0x0
	private static Encoding s_utf8EncodingWithExceptionFallback; // 0x8
	private static Encoding s_latin1Encoding; // 0x10
	private readonly byte[] _data; // 0x10
	private readonly int _end; // 0x18
	private int _position; // 0x1C
	[CompilerGenerated]
	private int <ContentLength>k__BackingField; // 0x20

	// Properties
	internal int ContentLength { get; set; }
	internal bool HasData { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	internal int get_ContentLength() { }

	[CompilerGenerated]
	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	private void set_ContentLength(int value) { }

	// RVA: 0x22F24D0 Offset: 0x22F16D0 VA: 0x1822F24D0
	private void .ctor(bool startAtPayload, byte[] data, int offset, int length) { }

	// RVA: 0x22F2490 Offset: 0x22F1690 VA: 0x1822F2490
	internal void .ctor(byte[] data) { }

	// RVA: 0x22F2520 Offset: 0x22F1720 VA: 0x1822F2520
	internal void .ctor(byte[] data, int offset, int length) { }

	// RVA: 0x22F2330 Offset: 0x22F1530 VA: 0x1822F2330
	private void .ctor(DerSequenceReader.DerTag tagToEat, byte[] data, int offset, int length) { }

	// RVA: 0x22F0790 Offset: 0x22EF990 VA: 0x1822F0790
	internal static DerSequenceReader CreateForPayload(byte[] payload) { }

	// RVA: 0x22F2550 Offset: 0x22F1750 VA: 0x1822F2550
	internal bool get_HasData() { }

	// RVA: 0x22F0920 Offset: 0x22EFB20 VA: 0x1822F0920
	internal byte PeekTag() { }

	// RVA: 0x22F08D0 Offset: 0x22EFAD0 VA: 0x1822F08D0
	internal bool HasTag(DerSequenceReader.DerTag expectedTag) { }

	// RVA: 0x22F08D0 Offset: 0x22EFAD0 VA: 0x1822F08D0
	internal bool HasTag(byte expectedTag) { }

	// RVA: 0x22F2090 Offset: 0x22F1290 VA: 0x1822F2090
	internal void SkipValue() { }

	// RVA: 0x22F2150 Offset: 0x22F1350 VA: 0x1822F2150
	internal void ValidateAndSkipDerValue() { }

	// RVA: 0x22F10D0 Offset: 0x22F02D0 VA: 0x1822F10D0
	internal byte[] ReadNextEncodedValue() { }

	// RVA: 0x22F0C70 Offset: 0x22EFE70 VA: 0x1822F0C70
	internal bool ReadBoolean() { }

	// RVA: 0x22F1020 Offset: 0x22F0220 VA: 0x1822F1020
	internal int ReadInteger() { }

	// RVA: 0x22F0FF0 Offset: 0x22F01F0 VA: 0x1822F0FF0
	internal byte[] ReadIntegerBytes() { }

	// RVA: 0x22F0AE0 Offset: 0x22EFCE0 VA: 0x1822F0AE0
	internal byte[] ReadBitString() { }

	// RVA: 0x22F1180 Offset: 0x22F0380 VA: 0x1822F1180
	internal byte[] ReadOctetString() { }

	// RVA: 0x22F11B0 Offset: 0x22F03B0 VA: 0x1822F11B0
	internal string ReadOidAsString() { }

	// RVA: 0x22F1500 Offset: 0x22F0700 VA: 0x1822F1500
	internal Oid ReadOid() { }

	// RVA: 0x22F1BD0 Offset: 0x22F0DD0 VA: 0x1822F1BD0
	internal string ReadUtf8String() { }

	// RVA: 0x22F0D40 Offset: 0x22EFF40 VA: 0x1822F0D40
	private DerSequenceReader ReadCollectionWithTag(DerSequenceReader.DerTag expected) { }

	// RVA: 0x22F1650 Offset: 0x22F0850 VA: 0x1822F1650
	internal DerSequenceReader ReadSequence() { }

	// RVA: 0x22F1660 Offset: 0x22F0860 VA: 0x1822F1660
	internal DerSequenceReader ReadSet() { }

	// RVA: 0x22F1570 Offset: 0x22F0770 VA: 0x1822F1570
	internal string ReadPrintableString() { }

	// RVA: 0x22F0F10 Offset: 0x22F0110 VA: 0x1822F0F10
	internal string ReadIA5String() { }

	// RVA: 0x22F1670 Offset: 0x22F0870 VA: 0x1822F1670
	internal string ReadT61String() { }

	// RVA: 0x22F1CB0 Offset: 0x22F0EB0 VA: 0x1822F1CB0
	internal DateTime ReadX509Date() { }

	// RVA: 0x22F1B90 Offset: 0x22F0D90 VA: 0x1822F1B90
	internal DateTime ReadUtcTime() { }

	// RVA: 0x22F0ED0 Offset: 0x22F00D0 VA: 0x1822F0ED0
	internal DateTime ReadGeneralizedTime() { }

	// RVA: 0x22F0A00 Offset: 0x22EFC00 VA: 0x1822F0A00
	internal string ReadBMPString() { }

	// RVA: 0x22F20E0 Offset: 0x22F12E0 VA: 0x1822F20E0
	private static string TrimTrailingNulls(string value) { }

	// RVA: 0x22F1950 Offset: 0x22F0B50 VA: 0x1822F1950
	private DateTime ReadTime(DerSequenceReader.DerTag timeTag, string formatString) { }

	// RVA: 0x22F0E20 Offset: 0x22F0020 VA: 0x1822F0E20
	private byte[] ReadContentAsBytes() { }

	// RVA: 0x22F0850 Offset: 0x22EFA50 VA: 0x1822F0850
	private void EatTag(DerSequenceReader.DerTag expected) { }

	// RVA: 0x22F0660 Offset: 0x22EF860 VA: 0x1822F0660
	private static void CheckTag(DerSequenceReader.DerTag expected, byte[] data, int position) { }

	// RVA: 0x22F0810 Offset: 0x22EFA10 VA: 0x1822F0810
	private int EatLength() { }

	// RVA: 0x22F1D80 Offset: 0x22F0F80 VA: 0x1822F1D80
	private static int ScanContentLength(byte[] data, int offset, int end, out int bytesConsumed) { }
}

// Namespace: System.Security.Cryptography
[DefaultMember("Item")]
public sealed class AsnEncodedDataCollection : ICollection, IEnumerable // TypeDefIndex: 5122
{
	// Fields
	private readonly List<AsnEncodedData> _list; // 0x10

	// Properties
	public AsnEncodedData Item { get; }
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x22EB1C0 Offset: 0x22EA3C0 VA: 0x1822EB1C0
	public void .ctor() { }

	// RVA: 0x22EB0C0 Offset: 0x22EA2C0 VA: 0x1822EB0C0
	public void .ctor(AsnEncodedData asnEncodedData) { }

	// RVA: 0x22EAB30 Offset: 0x22E9D30 VA: 0x1822EAB30
	public int Add(AsnEncodedData asnEncodedData) { }

	// RVA: 0x22EADD0 Offset: 0x22E9FD0 VA: 0x1822EADD0
	public void Remove(AsnEncodedData asnEncodedData) { }

	// RVA: 0x22EB270 Offset: 0x22EA470 VA: 0x1822EB270
	public AsnEncodedData get_Item(int index) { }

	// RVA: 0x22EB230 Offset: 0x22EA430 VA: 0x1822EB230 Slot: 5
	public int get_Count() { }

	// RVA: 0x22EAD70 Offset: 0x22E9F70 VA: 0x1822EAD70
	public AsnEncodedDataEnumerator GetEnumerator() { }

	// RVA: 0x22EAD70 Offset: 0x22E9F70 VA: 0x1822EAD70 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x22EAE80 Offset: 0x22EA080 VA: 0x1822EAE80 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x22EAC50 Offset: 0x22E9E50 VA: 0x1822EAC50
	public void CopyTo(AsnEncodedData[] array, int index) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 6
	public object get_SyncRoot() { }
}

// Namespace: System.Security.Cryptography
public sealed class AsnEncodedDataEnumerator : IEnumerator // TypeDefIndex: 5123
{
	// Fields
	private readonly AsnEncodedDataCollection _asnEncodedDatas; // 0x10
	private int _current; // 0x18

	// Properties
	public AsnEncodedData Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x176DFE0 Offset: 0x176D1E0 VA: 0x18176DFE0
	internal void .ctor(AsnEncodedDataCollection asnEncodedDatas) { }

	// RVA: 0x22EB350 Offset: 0x22EA550 VA: 0x1822EB350
	public AsnEncodedData get_Current() { }

	// RVA: 0x22EB350 Offset: 0x22EA550 VA: 0x1822EB350 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x22EB2D0 Offset: 0x22EA4D0 VA: 0x1822EB2D0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x112DE90 Offset: 0x112D090 VA: 0x18112DE90 Slot: 6
	public void Reset() { }

	// RVA: 0x22EB3B0 Offset: 0x22EA5B0 VA: 0x1822EB3B0
	internal void .ctor() { }
}

// Namespace: System.Security.Cryptography
public sealed class Oid // TypeDefIndex: 5124
{
	// Fields
	private string _value; // 0x10
	private string _friendlyName; // 0x18
	private OidGroup _group; // 0x20

	// Properties
	public string Value { get; set; }
	public string FriendlyName { get; set; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x22F5910 Offset: 0x22F4B10 VA: 0x1822F5910
	public void .ctor(string oid) { }

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(string value, string friendlyName) { }

	// RVA: 0x22F5880 Offset: 0x22F4A80 VA: 0x1822F5880
	public void .ctor(Oid oid) { }

	// RVA: 0x22F55E0 Offset: 0x22F47E0 VA: 0x1822F55E0
	public static Oid FromFriendlyName(string friendlyName, OidGroup group) { }

	// RVA: 0x22F5730 Offset: 0x22F4930 VA: 0x1822F5730
	public static Oid FromOidValue(string oidValue, OidGroup group) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Value() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Value(string value) { }

	// RVA: 0x22F5990 Offset: 0x22F4B90 VA: 0x1822F5990
	public string get_FriendlyName() { }

	// RVA: 0x22F5A20 Offset: 0x22F4C20 VA: 0x1822F5A20
	public void set_FriendlyName(string value) { }

	// RVA: 0xB18200 Offset: 0xB17400 VA: 0x180B18200
	private void .ctor(string value, string friendlyName, OidGroup group) { }
}

// Namespace: System.Security.Cryptography
[DefaultMember("Item")]
public sealed class OidCollection : ICollection, IEnumerable // TypeDefIndex: 5125
{
	// Fields
	private readonly List<Oid> _list; // 0x10

	// Properties
	public Oid Item { get; }
	public Oid Item { get; }
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x22F5230 Offset: 0x22F4430 VA: 0x1822F5230
	public void .ctor() { }

	// RVA: 0x22F4DA0 Offset: 0x22F3FA0 VA: 0x1822F4DA0
	public int Add(Oid oid) { }

	// RVA: 0x22F52E0 Offset: 0x22F44E0 VA: 0x1822F52E0
	public Oid get_Item(int index) { }

	// RVA: 0x22F5340 Offset: 0x22F4540 VA: 0x1822F5340
	public Oid get_Item(string oid) { }

	// RVA: 0x22F52A0 Offset: 0x22F44A0 VA: 0x1822F52A0 Slot: 5
	public int get_Count() { }

	// RVA: 0x22F4F90 Offset: 0x22F4190 VA: 0x1822F4F90
	public OidEnumerator GetEnumerator() { }

	// RVA: 0x22F4F90 Offset: 0x22F4190 VA: 0x1822F4F90 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x22F4FF0 Offset: 0x22F41F0 VA: 0x1822F4FF0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x22F4E70 Offset: 0x22F4070 VA: 0x1822F4E70
	public void CopyTo(Oid[] array, int index) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 6
	public object get_SyncRoot() { }
}

// Namespace: System.Security.Cryptography
public sealed class OidEnumerator : IEnumerator // TypeDefIndex: 5126
{
	// Fields
	private readonly OidCollection _oids; // 0x10
	private int _current; // 0x18

	// Properties
	public Oid Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x176DFE0 Offset: 0x176D1E0 VA: 0x18176DFE0
	internal void .ctor(OidCollection oids) { }

	// RVA: 0x22F5550 Offset: 0x22F4750 VA: 0x1822F5550
	public Oid get_Current() { }

	// RVA: 0x22F5550 Offset: 0x22F4750 VA: 0x1822F5550 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x22F54D0 Offset: 0x22F46D0 VA: 0x1822F54D0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x112DE90 Offset: 0x112D090 VA: 0x18112DE90 Slot: 6
	public void Reset() { }

	// RVA: 0x22F55B0 Offset: 0x22F47B0 VA: 0x1822F55B0
	internal void .ctor() { }
}

// Namespace: System.Security.Cryptography
public enum OidGroup // TypeDefIndex: 5127
{
	// Fields
	public int value__; // 0x0
	public const OidGroup All = 0;
	public const OidGroup HashAlgorithm = 1;
	public const OidGroup EncryptionAlgorithm = 2;
	public const OidGroup PublicKeyAlgorithm = 3;
	public const OidGroup SignatureAlgorithm = 4;
	public const OidGroup Attribute = 5;
	public const OidGroup ExtensionOrAttribute = 6;
	public const OidGroup EnhancedKeyUsage = 7;
	public const OidGroup Policy = 8;
	public const OidGroup Template = 9;
	public const OidGroup KeyDerivationFunction = 10;
}

// Namespace: System.Security.Cryptography
internal enum AsnDecodeStatus // TypeDefIndex: 5128
{
	// Fields
	public int value__; // 0x0
	public const AsnDecodeStatus NotDecoded = -1;
	public const AsnDecodeStatus Ok = 0;
	public const AsnDecodeStatus BadAsn = 1;
	public const AsnDecodeStatus BadTag = 2;
	public const AsnDecodeStatus BadLength = 3;
	public const AsnDecodeStatus InformationNotAvailable = 4;
}

// Namespace: System.Security.Cryptography
public class AsnEncodedData // TypeDefIndex: 5129
{
	// Fields
	internal Oid _oid; // 0x10
	internal byte[] _raw; // 0x18

	// Properties
	public Oid Oid { get; set; }
	public byte[] RawData { get; set; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x22EC410 Offset: 0x22EB610 VA: 0x1822EC410
	public void .ctor(string oid, byte[] rawData) { }

	// RVA: 0x22EC270 Offset: 0x22EB470 VA: 0x1822EC270
	public void .ctor(Oid oid, byte[] rawData) { }

	// RVA: 0x22EC560 Offset: 0x22EB760 VA: 0x1822EC560
	public void .ctor(AsnEncodedData asnEncodedData) { }

	// RVA: 0x22EC3E0 Offset: 0x22EB5E0 VA: 0x1822EC3E0
	public void .ctor(byte[] rawData) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Oid get_Oid() { }

	// RVA: 0x22EC6B0 Offset: 0x22EB8B0 VA: 0x1822EC6B0
	public void set_Oid(Oid value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public byte[] get_RawData() { }

	// RVA: 0x22EC750 Offset: 0x22EB950 VA: 0x1822EC750
	public void set_RawData(byte[] value) { }

	// RVA: 0x22EB520 Offset: 0x22EA720 VA: 0x1822EB520 Slot: 4
	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x22EB850 Offset: 0x22EAA50 VA: 0x1822EB850 Slot: 5
	public virtual string Format(bool multiLine) { }

	// RVA: 0x22EC0A0 Offset: 0x22EB2A0 VA: 0x1822EC0A0 Slot: 6
	internal virtual string ToString(bool multiLine) { }

	// RVA: 0x22EB680 Offset: 0x22EA880 VA: 0x1822EB680
	internal string Default(bool multiLine) { }

	// RVA: 0x22EB3E0 Offset: 0x22EA5E0 VA: 0x1822EB3E0
	internal string BasicConstraintsExtension(bool multiLine) { }

	// RVA: 0x22EB7B0 Offset: 0x22EA9B0 VA: 0x1822EB7B0
	internal string EnhancedKeyUsageExtension(bool multiLine) { }

	// RVA: 0x22EB8E0 Offset: 0x22EAAE0 VA: 0x1822EB8E0
	internal string KeyUsageExtension(bool multiLine) { }

	// RVA: 0x22EC000 Offset: 0x22EB200 VA: 0x1822EC000
	internal string SubjectKeyIdentifierExtension(bool multiLine) { }

	// RVA: 0x22EBD20 Offset: 0x22EAF20 VA: 0x1822EBD20
	internal string SubjectAltName(bool multiLine) { }

	// RVA: 0x22EB980 Offset: 0x22EAB80 VA: 0x1822EB980
	internal string NetscapeCertType(bool multiLine) { }
}

// Namespace: 
private enum GeneralNameEncoder.GeneralNameTag // TypeDefIndex: 5130
{
	// Fields
	public byte value__; // 0x0
	public const GeneralNameEncoder.GeneralNameTag OtherName = 160;
	public const GeneralNameEncoder.GeneralNameTag Rfc822Name = 129;
	public const GeneralNameEncoder.GeneralNameTag DnsName = 130;
	public const GeneralNameEncoder.GeneralNameTag X400Address = 131;
	public const GeneralNameEncoder.GeneralNameTag DirectoryName = 132;
	public const GeneralNameEncoder.GeneralNameTag EdiPartyName = 133;
	public const GeneralNameEncoder.GeneralNameTag Uri = 134;
	public const GeneralNameEncoder.GeneralNameTag IpAddress = 135;
	public const GeneralNameEncoder.GeneralNameTag RegisteredId = 136;
}

// Namespace: System.Security.Cryptography.X509Certificates
internal sealed class GeneralNameEncoder // TypeDefIndex: 5131
{
	// Fields
	private static readonly IdnMapping s_idnMapping; // 0x0

	// Methods

	// RVA: 0x22F3710 Offset: 0x22F2910 VA: 0x1822F3710
	internal byte[][] EncodeEmailAddress(string emailAddress) { }

	// RVA: 0x22F3600 Offset: 0x22F2800 VA: 0x1822F3600
	internal byte[][] EncodeDnsName(string dnsName) { }

	// RVA: 0x22F3920 Offset: 0x22F2B20 VA: 0x1822F3920
	internal byte[][] EncodeUri(Uri uri) { }

	// RVA: 0x22F37E0 Offset: 0x22F29E0 VA: 0x1822F37E0
	internal byte[][] EncodeIpAddress(IPAddress address) { }

	// RVA: 0x22F3A00 Offset: 0x22F2C00 VA: 0x1822F3A00
	internal byte[][] EncodeUserPrincipalName(string upn) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x22F3C90 Offset: 0x22F2E90 VA: 0x1822F3C90
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[Flags]
public enum OpenFlags // TypeDefIndex: 5132
{
	// Fields
	public int value__; // 0x0
	public const OpenFlags ReadOnly = 0;
	public const OpenFlags ReadWrite = 1;
	public const OpenFlags MaxAllowed = 2;
	public const OpenFlags OpenExistingOnly = 4;
	public const OpenFlags IncludeArchived = 8;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum StoreLocation // TypeDefIndex: 5133
{
	// Fields
	public int value__; // 0x0
	public const StoreLocation CurrentUser = 1;
	public const StoreLocation LocalMachine = 2;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum StoreName // TypeDefIndex: 5134
{
	// Fields
	public int value__; // 0x0
	public const StoreName AddressBook = 1;
	public const StoreName AuthRoot = 2;
	public const StoreName CertificateAuthority = 3;
	public const StoreName Disallowed = 4;
	public const StoreName My = 5;
	public const StoreName Root = 6;
	public const StoreName TrustedPeople = 7;
	public const StoreName TrustedPublisher = 8;
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class SubjectAlternativeNameBuilder // TypeDefIndex: 5135
{
	// Fields
	private readonly List<byte[][]> _encodedTlvs; // 0x10
	private readonly GeneralNameEncoder _generalNameEncoder; // 0x18

	// Methods

	// RVA: 0x22F8B30 Offset: 0x22F7D30 VA: 0x1822F8B30
	public void AddEmailAddress(string emailAddress) { }

	// RVA: 0x22F88F0 Offset: 0x22F7AF0 VA: 0x1822F88F0
	public void AddDnsName(string dnsName) { }

	// RVA: 0x22F8F60 Offset: 0x22F8160 VA: 0x1822F8F60
	public void AddUri(Uri uri) { }

	// RVA: 0x22F8D20 Offset: 0x22F7F20 VA: 0x1822F8D20
	public void AddIpAddress(IPAddress ipAddress) { }

	// RVA: 0x22F9180 Offset: 0x22F8380 VA: 0x1822F9180
	public void AddUserPrincipalName(string upn) { }

	// RVA: 0x22F92C0 Offset: 0x22F84C0 VA: 0x1822F92C0
	public X509Extension Build(bool critical = False) { }

	// RVA: 0x22F9370 Offset: 0x22F8570 VA: 0x1822F9370
	public void .ctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[Flags]
public enum X500DistinguishedNameFlags // TypeDefIndex: 5136
{
	// Fields
	public int value__; // 0x0
	public const X500DistinguishedNameFlags None = 0;
	public const X500DistinguishedNameFlags Reversed = 1;
	public const X500DistinguishedNameFlags UseSemicolons = 16;
	public const X500DistinguishedNameFlags DoNotUsePlusSign = 32;
	public const X500DistinguishedNameFlags DoNotUseQuotes = 64;
	public const X500DistinguishedNameFlags UseCommas = 128;
	public const X500DistinguishedNameFlags UseNewLines = 256;
	public const X500DistinguishedNameFlags UseUTF8Encoding = 4096;
	public const X500DistinguishedNameFlags UseT61Encoding = 8192;
	public const X500DistinguishedNameFlags ForceUTF8Encoding = 16384;
}

// Namespace: System.Security.Cryptography.X509Certificates
[Flags]
public enum X509ChainStatusFlags // TypeDefIndex: 5137
{
	// Fields
	public int value__; // 0x0
	public const X509ChainStatusFlags NoError = 0;
	public const X509ChainStatusFlags NotTimeValid = 1;
	public const X509ChainStatusFlags NotTimeNested = 2;
	public const X509ChainStatusFlags Revoked = 4;
	public const X509ChainStatusFlags NotSignatureValid = 8;
	public const X509ChainStatusFlags NotValidForUsage = 16;
	public const X509ChainStatusFlags UntrustedRoot = 32;
	public const X509ChainStatusFlags RevocationStatusUnknown = 64;
	public const X509ChainStatusFlags Cyclic = 128;
	public const X509ChainStatusFlags InvalidExtension = 256;
	public const X509ChainStatusFlags InvalidPolicyConstraints = 512;
	public const X509ChainStatusFlags InvalidBasicConstraints = 1024;
	public const X509ChainStatusFlags InvalidNameConstraints = 2048;
	public const X509ChainStatusFlags HasNotSupportedNameConstraint = 4096;
	public const X509ChainStatusFlags HasNotDefinedNameConstraint = 8192;
	public const X509ChainStatusFlags HasNotPermittedNameConstraint = 16384;
	public const X509ChainStatusFlags HasExcludedNameConstraint = 32768;
	public const X509ChainStatusFlags PartialChain = 65536;
	public const X509ChainStatusFlags CtlNotTimeValid = 131072;
	public const X509ChainStatusFlags CtlNotSignatureValid = 262144;
	public const X509ChainStatusFlags CtlNotValidForUsage = 524288;
	public const X509ChainStatusFlags OfflineRevocation = 16777216;
	public const X509ChainStatusFlags NoIssuanceChainPolicy = 33554432;
	public const X509ChainStatusFlags ExplicitDistrust = 67108864;
	public const X509ChainStatusFlags HasNotSupportedCriticalExtension = 134217728;
	public const X509ChainStatusFlags HasWeakSignature = 1048576;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509FindType // TypeDefIndex: 5138
{
	// Fields
	public int value__; // 0x0
	public const X509FindType FindByThumbprint = 0;
	public const X509FindType FindBySubjectName = 1;
	public const X509FindType FindBySubjectDistinguishedName = 2;
	public const X509FindType FindByIssuerName = 3;
	public const X509FindType FindByIssuerDistinguishedName = 4;
	public const X509FindType FindBySerialNumber = 5;
	public const X509FindType FindByTimeValid = 6;
	public const X509FindType FindByTimeNotYetValid = 7;
	public const X509FindType FindByTimeExpired = 8;
	public const X509FindType FindByTemplateName = 9;
	public const X509FindType FindByApplicationPolicy = 10;
	public const X509FindType FindByCertificatePolicy = 11;
	public const X509FindType FindByExtension = 12;
	public const X509FindType FindByKeyUsage = 13;
	public const X509FindType FindBySubjectKeyIdentifier = 14;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509IncludeOption // TypeDefIndex: 5139
{
	// Fields
	public int value__; // 0x0
	public const X509IncludeOption None = 0;
	public const X509IncludeOption ExcludeRoot = 1;
	public const X509IncludeOption EndCertOnly = 2;
	public const X509IncludeOption WholeChain = 3;
}

// Namespace: System.Security.Cryptography.X509Certificates
[Flags]
public enum X509KeyUsageFlags // TypeDefIndex: 5140
{
	// Fields
	public int value__; // 0x0
	public const X509KeyUsageFlags None = 0;
	public const X509KeyUsageFlags EncipherOnly = 1;
	public const X509KeyUsageFlags CrlSign = 2;
	public const X509KeyUsageFlags KeyCertSign = 4;
	public const X509KeyUsageFlags KeyAgreement = 8;
	public const X509KeyUsageFlags DataEncipherment = 16;
	public const X509KeyUsageFlags KeyEncipherment = 32;
	public const X509KeyUsageFlags NonRepudiation = 64;
	public const X509KeyUsageFlags DigitalSignature = 128;
	public const X509KeyUsageFlags DecipherOnly = 32768;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509NameType // TypeDefIndex: 5141
{
	// Fields
	public int value__; // 0x0
	public const X509NameType SimpleName = 0;
	public const X509NameType EmailName = 1;
	public const X509NameType UpnName = 2;
	public const X509NameType DnsName = 3;
	public const X509NameType DnsFromAlternativeName = 4;
	public const X509NameType UrlName = 5;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509RevocationFlag // TypeDefIndex: 5142
{
	// Fields
	public int value__; // 0x0
	public const X509RevocationFlag EndCertificateOnly = 0;
	public const X509RevocationFlag EntireChain = 1;
	public const X509RevocationFlag ExcludeRoot = 2;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509RevocationMode // TypeDefIndex: 5143
{
	// Fields
	public int value__; // 0x0
	public const X509RevocationMode NoCheck = 0;
	public const X509RevocationMode Online = 1;
	public const X509RevocationMode Offline = 2;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509SubjectKeyIdentifierHashAlgorithm // TypeDefIndex: 5144
{
	// Fields
	public int value__; // 0x0
	public const X509SubjectKeyIdentifierHashAlgorithm Sha1 = 0;
	public const X509SubjectKeyIdentifierHashAlgorithm ShortSha1 = 1;
	public const X509SubjectKeyIdentifierHashAlgorithm CapiSha1 = 2;
}

// Namespace: System.Security.Cryptography.X509Certificates
[Flags]
public enum X509VerificationFlags // TypeDefIndex: 5145
{
	// Fields
	public int value__; // 0x0
	public const X509VerificationFlags NoFlag = 0;
	public const X509VerificationFlags IgnoreNotTimeValid = 1;
	public const X509VerificationFlags IgnoreCtlNotTimeValid = 2;
	public const X509VerificationFlags IgnoreNotTimeNested = 4;
	public const X509VerificationFlags IgnoreInvalidBasicConstraints = 8;
	public const X509VerificationFlags AllowUnknownCertificateAuthority = 16;
	public const X509VerificationFlags IgnoreWrongUsage = 32;
	public const X509VerificationFlags IgnoreInvalidName = 64;
	public const X509VerificationFlags IgnoreInvalidPolicy = 128;
	public const X509VerificationFlags IgnoreEndRevocationUnknown = 256;
	public const X509VerificationFlags IgnoreCtlSignerRevocationUnknown = 512;
	public const X509VerificationFlags IgnoreCertificateAuthorityRevocationUnknown = 1024;
	public const X509VerificationFlags IgnoreRootRevocationUnknown = 2048;
	public const X509VerificationFlags AllFlags = 4095;
}

// Namespace: 
public enum OSX509Certificates.SecTrustResult // TypeDefIndex: 5146
{
	// Fields
	public int value__; // 0x0
	public const OSX509Certificates.SecTrustResult Invalid = 0;
	public const OSX509Certificates.SecTrustResult Proceed = 1;
	public const OSX509Certificates.SecTrustResult Confirm = 2;
	public const OSX509Certificates.SecTrustResult Deny = 3;
	public const OSX509Certificates.SecTrustResult Unspecified = 4;
	public const OSX509Certificates.SecTrustResult RecoverableTrustFailure = 5;
	public const OSX509Certificates.SecTrustResult FatalTrustFailure = 6;
	public const OSX509Certificates.SecTrustResult ResultOtherError = 7;
}

// Namespace: System.Security.Cryptography.X509Certificates
internal static class OSX509Certificates // TypeDefIndex: 5147
{
	// Fields
	public const string SecurityLibrary = "/System/Library/Frameworks/Security.framework/Security";
	public const string CoreFoundationLibrary = "/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation";

	// Methods

	// RVA: 0x22F4440 Offset: 0x22F3640 VA: 0x1822F4440
	private static extern IntPtr SecCertificateCreateWithData(IntPtr allocator, IntPtr nsdataRef) { }

	// RVA: 0x22F4560 Offset: 0x22F3760 VA: 0x1822F4560
	private static extern int SecTrustCreateWithCertificates(IntPtr certOrCertArray, IntPtr policies, out IntPtr sectrustref) { }

	// RVA: 0x22F4690 Offset: 0x22F3890 VA: 0x1822F4690
	private static extern int SecTrustSetAnchorCertificates(IntPtr trust, IntPtr anchorCertificates) { }

	// RVA: 0x22F44D0 Offset: 0x22F36D0 VA: 0x1822F44D0
	private static extern IntPtr SecPolicyCreateSSL(bool server, IntPtr cfStringHostname) { }

	// RVA: 0x22F4600 Offset: 0x22F3800 VA: 0x1822F4600
	private static extern int SecTrustEvaluate(IntPtr secTrustRef, out OSX509Certificates.SecTrustResult secTrustResultTime) { }

	// RVA: 0x22F4000 Offset: 0x22F3200 VA: 0x1822F4000
	private static extern IntPtr CFStringCreateWithCharacters(IntPtr allocator, string str, IntPtr count) { }

	// RVA: 0x22F3E60 Offset: 0x22F3060 VA: 0x1822F3E60
	private static extern IntPtr CFDataCreate(IntPtr allocator, byte* bytes, IntPtr length) { }

	// RVA: 0x22F3F80 Offset: 0x22F3180 VA: 0x1822F3F80
	private static extern void CFRetain(IntPtr handle) { }

	// RVA: 0x22F3F00 Offset: 0x22F3100 VA: 0x1822F3F00
	private static extern void CFRelease(IntPtr handle) { }

	// RVA: 0x22F3DB0 Offset: 0x22F2FB0 VA: 0x1822F3DB0
	private static extern IntPtr CFArrayCreate(IntPtr allocator, IntPtr values, IntPtr numValues, IntPtr callbacks) { }

	// RVA: 0x22F4380 Offset: 0x22F3580 VA: 0x1822F4380
	private static IntPtr MakeCFData(byte[] data) { }

	// RVA: 0x22F40B0 Offset: 0x22F32B0 VA: 0x1822F40B0
	private static IntPtr FromIntPtrs(IntPtr[] values) { }

	// RVA: 0x22F4180 Offset: 0x22F3380 VA: 0x1822F4180
	private static IntPtr GetCertificate(X509Certificate certificate) { }

	// RVA: 0x22F4720 Offset: 0x22F3920 VA: 0x1822F4720
	public static OSX509Certificates.SecTrustResult TrustEvaluateSsl(X509CertificateCollection certificates, X509CertificateCollection anchors, string host) { }

	// RVA: 0x22F4740 Offset: 0x22F3940 VA: 0x1822F4740
	private static OSX509Certificates.SecTrustResult _TrustEvaluateSsl(X509CertificateCollection certificates, X509CertificateCollection anchors, string hostName) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class PublicKey // TypeDefIndex: 5148
{
	// Fields
	private const string rsaOid = "1.2.840.113549.1.1.1";
	private const string dsaOid = "1.2.840.10040.4.1";
	private AsymmetricAlgorithm _key; // 0x10
	private AsnEncodedData _keyValue; // 0x18
	private AsnEncodedData _params; // 0x20
	private Oid _oid; // 0x28
	private static byte[] Empty; // 0x0

	// Properties
	public AsnEncodedData EncodedKeyValue { get; }
	public AsnEncodedData EncodedParameters { get; }
	public AsymmetricAlgorithm Key { get; }
	public Oid Oid { get; }

	// Methods

	// RVA: 0x22F6A50 Offset: 0x22F5C50 VA: 0x1822F6A50
	public void .ctor(Oid oid, AsnEncodedData parameters, AsnEncodedData keyValue) { }

	// RVA: 0x22F6500 Offset: 0x22F5700 VA: 0x1822F6500
	internal void .ctor(X509Certificate certificate) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public AsnEncodedData get_EncodedKeyValue() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public AsnEncodedData get_EncodedParameters() { }

	// RVA: 0x22F6C30 Offset: 0x22F5E30 VA: 0x1822F6C30
	public AsymmetricAlgorithm get_Key() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Oid get_Oid() { }

	// RVA: 0x22F6410 Offset: 0x22F5610 VA: 0x1822F6410
	private static byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x22F5C00 Offset: 0x22F4E00 VA: 0x1822F5C00
	internal static DSA DecodeDSA(byte[] rawPublicKey, byte[] rawParameters) { }

	// RVA: 0x22F60D0 Offset: 0x22F52D0 VA: 0x1822F60D0
	internal static RSA DecodeRSA(byte[] rawPublicKey) { }

	// RVA: 0x22F64B0 Offset: 0x22F56B0 VA: 0x1822F64B0
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[MonoTODO("Some X500DistinguishedNameFlags options aren't supported, like DoNotUsePlusSign, DoNotUseQuotes and ForceUTF8Encoding")]
public sealed class X500DistinguishedName : AsnEncodedData // TypeDefIndex: 5149
{
	// Fields
	private const X500DistinguishedNameFlags AllFlags = 29169;
	private string name; // 0x20
	private byte[] canonEncoding; // 0x28

	// Properties
	internal byte[] CanonicalEncoding { get; }
	public string Name { get; }

	// Methods

	// RVA: 0x22FAB20 Offset: 0x22F9D20 VA: 0x1822FAB20
	public void .ctor(AsnEncodedData encodedDistinguishedName) { }

	// RVA: 0x22FB2D0 Offset: 0x22FA4D0 VA: 0x1822FB2D0
	public void .ctor(byte[] encodedDistinguishedName) { }

	// RVA: 0x22FADD0 Offset: 0x22F9FD0 VA: 0x1822FADD0
	public void .ctor(string distinguishedName) { }

	// RVA: 0x22FADE0 Offset: 0x22F9FE0 VA: 0x1822FADE0
	public void .ctor(string distinguishedName, X500DistinguishedNameFlags flag) { }

	// RVA: 0x22FB1A0 Offset: 0x22FA3A0 VA: 0x1822FB1A0
	public void .ctor(X500DistinguishedName distinguishedName) { }

	// RVA: 0x22FAC10 Offset: 0x22F9E10 VA: 0x1822FAC10
	internal void .ctor(byte[] encoded, byte[] canonEncoding, string name) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal byte[] get_CanonicalEncoding() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Name() { }

	// RVA: 0x22FA880 Offset: 0x22F9A80 VA: 0x1822FA880
	public string Decode(X500DistinguishedNameFlags flag) { }

	// RVA: 0x22FAA40 Offset: 0x22F9C40 VA: 0x1822FAA40 Slot: 5
	public override string Format(bool multiLine) { }

	// RVA: 0x22FAAB0 Offset: 0x22F9CB0 VA: 0x1822FAAB0
	private static string GetSeparator(X500DistinguishedNameFlags flag) { }

	// RVA: 0x22FA790 Offset: 0x22F9990 VA: 0x1822FA790
	private void DecodeRawData() { }

	// RVA: 0x22FA5C0 Offset: 0x22F97C0 VA: 0x1822FA5C0
	private static string Canonize(string s) { }

	// RVA: 0x22FA3C0 Offset: 0x22F95C0 VA: 0x1822FA3C0
	internal static bool AreEqual(X500DistinguishedName name1, X500DistinguishedName name2) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509BasicConstraintsExtension : X509Extension // TypeDefIndex: 5150
{
	// Fields
	internal const string oid = "2.5.29.19";
	internal const string friendlyName = "Basic Constraints";
	private bool _certificateAuthority; // 0x28
	private bool _hasPathLengthConstraint; // 0x29
	private int _pathLengthConstraint; // 0x2C
	private AsnDecodeStatus _status; // 0x30

	// Properties
	public bool CertificateAuthority { get; }
	public bool HasPathLengthConstraint { get; }
	public int PathLengthConstraint { get; }

	// Methods

	// RVA: 0x22FBE70 Offset: 0x22FB070 VA: 0x1822FBE70
	public void .ctor() { }

	// RVA: 0x22FBF10 Offset: 0x22FB110 VA: 0x1822FBF10
	public void .ctor(AsnEncodedData encodedBasicConstraints, bool critical) { }

	// RVA: 0x22FBC10 Offset: 0x22FAE10 VA: 0x1822FBC10
	public void .ctor(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) { }

	// RVA: 0x22FBFF0 Offset: 0x22FB1F0 VA: 0x1822FBFF0
	public bool get_CertificateAuthority() { }

	// RVA: 0x22FC060 Offset: 0x22FB260 VA: 0x1822FC060
	public bool get_HasPathLengthConstraint() { }

	// RVA: 0x22FC0D0 Offset: 0x22FB2D0 VA: 0x1822FC0D0
	public int get_PathLengthConstraint() { }

	// RVA: 0x22FB4C0 Offset: 0x22FA6C0 VA: 0x1822FB4C0 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x22FB6D0 Offset: 0x22FA8D0 VA: 0x1822FB6D0
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x22FB840 Offset: 0x22FAA40 VA: 0x1822FB840
	internal byte[] Encode() { }

	// RVA: 0x22FB9B0 Offset: 0x22FABB0 VA: 0x1822FB9B0 Slot: 6
	internal override string ToString(bool multiLine) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[Serializable]
public class X509Certificate2 : X509Certificate // TypeDefIndex: 5151
{
	// Fields
	private byte[] lazyRawData; // 0x60
	private Oid lazySignatureAlgorithm; // 0x68
	private int lazyVersion; // 0x70
	private X500DistinguishedName lazySubjectName; // 0x78
	private X500DistinguishedName lazyIssuerName; // 0x80
	private PublicKey lazyPublicKey; // 0x88
	private AsymmetricAlgorithm lazyPrivateKey; // 0x90
	private X509ExtensionCollection lazyExtensions; // 0x98

	// Properties
	public bool Archived { get; set; }
	public X509ExtensionCollection Extensions { get; }
	public string FriendlyName { get; set; }
	public bool HasPrivateKey { get; }
	public AsymmetricAlgorithm PrivateKey { get; set; }
	public X500DistinguishedName IssuerName { get; }
	public DateTime NotAfter { get; }
	public DateTime NotBefore { get; }
	public PublicKey PublicKey { get; }
	public byte[] RawData { get; }
	public string SerialNumber { get; }
	public Oid SignatureAlgorithm { get; }
	public X500DistinguishedName SubjectName { get; }
	public string Thumbprint { get; }
	public int Version { get; }
	internal X509Certificate2Impl Impl { get; }

	// Methods

	// RVA: 0x2301910 Offset: 0x2300B10 VA: 0x182301910 Slot: 7
	public override void Reset() { }

	// RVA: 0x2302850 Offset: 0x2301A50 VA: 0x182302850
	public void .ctor() { }

	// RVA: 0x23026F0 Offset: 0x23018F0 VA: 0x1823026F0
	public void .ctor(byte[] rawData) { }

	// RVA: 0x23026D0 Offset: 0x23018D0 VA: 0x1823026D0
	public void .ctor(byte[] rawData, string password) { }

	[CLSCompliant(False)]
	// RVA: 0x2302800 Offset: 0x2301A00 VA: 0x182302800
	public void .ctor(byte[] rawData, SecureString password) { }

	// RVA: 0x2302820 Offset: 0x2301A20 VA: 0x182302820
	public void .ctor(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	[CLSCompliant(False)]
	// RVA: 0x2302840 Offset: 0x2301A40 VA: 0x182302840
	public void .ctor(byte[] rawData, SecureString password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x23028E0 Offset: 0x2301AE0 VA: 0x1823028E0
	public void .ctor(IntPtr handle) { }

	// RVA: 0x2302830 Offset: 0x2301A30 VA: 0x182302830
	internal void .ctor(X509Certificate2Impl impl) { }

	// RVA: 0x2302810 Offset: 0x2301A10 VA: 0x182302810
	public void .ctor(string fileName) { }

	// RVA: 0x2302860 Offset: 0x2301A60 VA: 0x182302860
	public void .ctor(string fileName, string password) { }

	// RVA: 0x23028D0 Offset: 0x2301AD0 VA: 0x1823028D0
	public void .ctor(string fileName, SecureString password) { }

	// RVA: 0x23026C0 Offset: 0x23018C0 VA: 0x1823026C0
	public void .ctor(string fileName, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x23028F0 Offset: 0x2301AF0 VA: 0x1823028F0
	public void .ctor(string fileName, SecureString password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x23026E0 Offset: 0x23018E0 VA: 0x1823026E0
	public void .ctor(X509Certificate certificate) { }

	// RVA: 0x2302870 Offset: 0x2301A70 VA: 0x182302870
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2302900 Offset: 0x2301B00 VA: 0x182302900
	public bool get_Archived() { }

	// RVA: 0x2303590 Offset: 0x2302790 VA: 0x182303590
	public void set_Archived(bool value) { }

	// RVA: 0x2302950 Offset: 0x2301B50 VA: 0x182302950
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x2302C10 Offset: 0x2301E10 VA: 0x182302C10
	public string get_FriendlyName() { }

	// RVA: 0x23035F0 Offset: 0x23027F0 VA: 0x1823035F0
	public void set_FriendlyName(string value) { }

	// RVA: 0x2302C60 Offset: 0x2301E60 VA: 0x182302C60
	public bool get_HasPrivateKey() { }

	// RVA: 0x2302DC0 Offset: 0x2301FC0 VA: 0x182302DC0
	public AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x2303640 Offset: 0x2302840 VA: 0x182303640
	public void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x2302D30 Offset: 0x2301F30 VA: 0x182302D30
	public X500DistinguishedName get_IssuerName() { }

	// RVA: 0x2302DA0 Offset: 0x2301FA0 VA: 0x182302DA0
	public DateTime get_NotAfter() { }

	// RVA: 0x2302DB0 Offset: 0x2301FB0 VA: 0x182302DB0
	public DateTime get_NotBefore() { }

	// RVA: 0x2302F70 Offset: 0x2302170 VA: 0x182302F70
	public PublicKey get_PublicKey() { }

	// RVA: 0x2303270 Offset: 0x2302470 VA: 0x182303270
	public byte[] get_RawData() { }

	// RVA: 0x7F68D0 Offset: 0x7F5AD0 VA: 0x1807F68D0
	public string get_SerialNumber() { }

	// RVA: 0x23032E0 Offset: 0x23024E0 VA: 0x1823032E0
	public Oid get_SignatureAlgorithm() { }

	// RVA: 0x2303480 Offset: 0x2302680 VA: 0x182303480
	public X500DistinguishedName get_SubjectName() { }

	// RVA: 0x23034F0 Offset: 0x23026F0 VA: 0x1823034F0
	public string get_Thumbprint() { }

	// RVA: 0x2303520 Offset: 0x2302720 VA: 0x182303520
	public int get_Version() { }

	// RVA: 0x23017C0 Offset: 0x23009C0 VA: 0x1823017C0
	public static X509ContentType GetCertContentType(byte[] rawData) { }

	// RVA: 0x2301700 Offset: 0x2300900 VA: 0x182301700
	public static X509ContentType GetCertContentType(string fileName) { }

	// RVA: 0x2301860 Offset: 0x2300A60 VA: 0x182301860
	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x2302670 Offset: 0x2301870 VA: 0x182302670 Slot: 3
	public override string ToString() { }

	// RVA: 0x2301990 Offset: 0x2300B90 VA: 0x182301990 Slot: 19
	public override string ToString(bool verbose) { }

	// RVA: 0x23018B0 Offset: 0x2300AB0 VA: 0x1823018B0 Slot: 20
	public override void Import(byte[] rawData) { }

	// RVA: 0x23018C0 Offset: 0x2300AC0 VA: 0x1823018C0 Slot: 21
	public override void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	[CLSCompliant(False)]
	// RVA: 0x23018E0 Offset: 0x2300AE0 VA: 0x1823018E0 Slot: 22
	public override void Import(byte[] rawData, SecureString password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x2301900 Offset: 0x2300B00 VA: 0x182301900 Slot: 23
	public override void Import(string fileName) { }

	// RVA: 0x23018F0 Offset: 0x2300AF0 VA: 0x1823018F0 Slot: 24
	public override void Import(string fileName, string password, X509KeyStorageFlags keyStorageFlags) { }

	[CLSCompliant(False)]
	// RVA: 0x23018D0 Offset: 0x2300AD0 VA: 0x1823018D0 Slot: 25
	public override void Import(string fileName, SecureString password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x2302680 Offset: 0x2301880 VA: 0x182302680
	public bool Verify() { }

	// RVA: 0x2301540 Offset: 0x2300740 VA: 0x182301540
	private static X509Extension CreateCustomExtensionIfAny(Oid oid) { }

	// RVA: 0x2302CB0 Offset: 0x2301EB0 VA: 0x182302CB0
	internal X509Certificate2Impl get_Impl() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[DefaultMember("Item")]
public class X509Certificate2Collection : X509CertificateCollection // TypeDefIndex: 5152
{
	// Fields
	private static string[] newline_split; // 0x0

	// Properties
	public X509Certificate2 Item { get; set; }

	// Methods

	// RVA: 0x154B280 Offset: 0x154A480 VA: 0x18154B280
	public void .ctor() { }

	// RVA: 0x22FE410 Offset: 0x22FD610 VA: 0x1822FE410
	public void .ctor(X509Certificate2Collection certificates) { }

	// RVA: 0x22FE4B0 Offset: 0x22FD6B0 VA: 0x1822FE4B0
	public void .ctor(X509Certificate2 certificate) { }

	// RVA: 0x22FE340 Offset: 0x22FD540 VA: 0x1822FE340
	public void .ctor(X509Certificate2[] certificates) { }

	// RVA: 0x22FE550 Offset: 0x22FD750 VA: 0x1822FE550
	public X509Certificate2 get_Item(int index) { }

	// RVA: 0x2116DB0 Offset: 0x2115FB0 VA: 0x182116DB0
	public void set_Item(int index, X509Certificate2 value) { }

	// RVA: 0x22FC2A0 Offset: 0x22FB4A0 VA: 0x1822FC2A0
	public int Add(X509Certificate2 certificate) { }

	[MonoTODO("Method isn't transactional (like documented)")]
	// RVA: 0x22FC140 Offset: 0x22FB340 VA: 0x1822FC140
	public void AddRange(X509Certificate2[] certificates) { }

	[MonoTODO("Method isn't transactional (like documented)")]
	// RVA: 0x22FC210 Offset: 0x22FB410 VA: 0x1822FC210
	public void AddRange(X509Certificate2Collection certificates) { }

	// RVA: 0x22FC330 Offset: 0x22FB530 VA: 0x1822FC330
	public bool Contains(X509Certificate2 certificate) { }

	[MonoTODO("only support X509ContentType.Cert")]
	// RVA: 0x22FC710 Offset: 0x22FB910 VA: 0x1822FC710
	public byte[] Export(X509ContentType contentType) { }

	[MonoTODO("only support X509ContentType.Cert")]
	// RVA: 0x22FC5B0 Offset: 0x22FB7B0 VA: 0x1822FC5B0
	public byte[] Export(X509ContentType contentType, string password) { }

	// RVA: 0x22FD8E0 Offset: 0x22FCAE0 VA: 0x1822FD8E0
	private string GetKeyIdentifier(X509Certificate2 x) { }

	[MonoTODO("Does not support X509FindType.FindByTemplateName, FindByApplicationPolicy and FindByCertificatePolicy")]
	// RVA: 0x22FC870 Offset: 0x22FBA70 VA: 0x1822FC870
	public X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly) { }

	// RVA: 0x22FD850 Offset: 0x22FCA50 VA: 0x1822FD850
	public X509Certificate2Enumerator GetEnumerator() { }

	[MonoTODO("same limitations as X509Certificate2.Import")]
	// RVA: 0x22FDBC0 Offset: 0x22FCDC0 VA: 0x1822FDBC0
	public void Import(byte[] rawData) { }

	[MonoTODO("same limitations as X509Certificate2.Import")]
	// RVA: 0x22FD9C0 Offset: 0x22FCBC0 VA: 0x1822FD9C0
	public void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	[MonoTODO("same limitations as X509Certificate2.Import")]
	// RVA: 0x22FDCA0 Offset: 0x22FCEA0 VA: 0x1822FDCA0
	public void Import(string fileName) { }

	[MonoTODO("same limitations as X509Certificate2.Import")]
	// RVA: 0x22FDAC0 Offset: 0x22FCCC0 VA: 0x1822FDAC0
	public void Import(string fileName, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x22FDD80 Offset: 0x22FCF80 VA: 0x1822FDD80
	public void Insert(int index, X509Certificate2 certificate) { }

	// RVA: 0x22FE0D0 Offset: 0x22FD2D0 VA: 0x1822FE0D0
	public void Remove(X509Certificate2 certificate) { }

	[MonoTODO("Method isn't transactional (like documented)")]
	// RVA: 0x22FDEE0 Offset: 0x22FD0E0 VA: 0x1822FDEE0
	public void RemoveRange(X509Certificate2[] certificates) { }

	[MonoTODO("Method isn't transactional (like documented)")]
	// RVA: 0x22FDF90 Offset: 0x22FD190 VA: 0x1822FDF90
	public void RemoveRange(X509Certificate2Collection certificates) { }

	// RVA: 0x22FE2C0 Offset: 0x22FD4C0 VA: 0x1822FE2C0
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509Certificate2Enumerator : IEnumerator // TypeDefIndex: 5153
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public X509Certificate2 Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x22FE890 Offset: 0x22FDA90 VA: 0x1822FE890
	internal void .ctor(X509Certificate2Collection collection) { }

	// RVA: 0x22FE900 Offset: 0x22FDB00 VA: 0x1822FE900
	public X509Certificate2 get_Current() { }

	// RVA: 0x22FE6D0 Offset: 0x22FD8D0 VA: 0x1822FE6D0
	public bool MoveNext() { }

	// RVA: 0x22FE720 Offset: 0x22FD920 VA: 0x1822FE720
	public void Reset() { }

	// RVA: 0x22FE810 Offset: 0x22FDA10 VA: 0x1822FE810 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x22FE770 Offset: 0x22FD970 VA: 0x1822FE770 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x22FE7C0 Offset: 0x22FD9C0 VA: 0x1822FE7C0 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x22FE860 Offset: 0x22FDA60 VA: 0x1822FE860
	internal void .ctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509Certificate2Impl : X509CertificateImpl // TypeDefIndex: 5154
{
	// Properties
	public abstract bool Archived { get; set; }
	public abstract IEnumerable<X509Extension> Extensions { get; }
	public abstract string FriendlyName { get; set; }
	public abstract X500DistinguishedName IssuerName { get; }
	public abstract AsymmetricAlgorithm PrivateKey { get; set; }
	public abstract PublicKey PublicKey { get; }
	public abstract string SignatureAlgorithm { get; }
	public abstract X500DistinguishedName SubjectName { get; }
	public abstract int Version { get; }
	internal abstract X509CertificateImplCollection IntermediateCertificates { get; }
	internal abstract X509Certificate2Impl FallbackImpl { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 29
	public abstract bool get_Archived();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void set_Archived(bool value);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract IEnumerable<X509Extension> get_Extensions();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract string get_FriendlyName();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void set_FriendlyName(string value);

	// RVA: -1 Offset: -1 Slot: 34
	public abstract X500DistinguishedName get_IssuerName();

	// RVA: -1 Offset: -1 Slot: 35
	public abstract AsymmetricAlgorithm get_PrivateKey();

	// RVA: -1 Offset: -1 Slot: 36
	public abstract void set_PrivateKey(AsymmetricAlgorithm value);

	// RVA: -1 Offset: -1 Slot: 37
	public abstract PublicKey get_PublicKey();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract string get_SignatureAlgorithm();

	// RVA: -1 Offset: -1 Slot: 39
	public abstract X500DistinguishedName get_SubjectName();

	// RVA: -1 Offset: -1 Slot: 40
	public abstract int get_Version();

	// RVA: -1 Offset: -1 Slot: 41
	internal abstract X509CertificateImplCollection get_IntermediateCertificates();

	// RVA: -1 Offset: -1 Slot: 42
	internal abstract X509Certificate2Impl get_FallbackImpl();

	// RVA: -1 Offset: -1 Slot: 43
	public abstract string GetNameInfo(X509NameType nameType, bool forIssuer);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract bool Verify(X509Certificate2 thisCertificate);

	// RVA: -1 Offset: -1 Slot: 45
	public abstract void AppendPrivateKeyInfo(StringBuilder sb);

	// RVA: 0x2301410 Offset: 0x2300610 VA: 0x182301410 Slot: 26
	public sealed override X509CertificateImpl CopyWithPrivateKey(RSA privateKey) { }

	// RVA: 0x23014E0 Offset: 0x23006E0 VA: 0x1823014E0 Slot: 27
	public sealed override X509Certificate CreateCertificate() { }

	// RVA: -1 Offset: -1 Slot: 46
	public abstract void Reset();

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	protected void .ctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal class X509Certificate2ImplMono : X509Certificate2ImplUnix // TypeDefIndex: 5155
{
	// Fields
	private PublicKey _publicKey; // 0xB0
	private X509CertificateImplCollection intermediateCerts; // 0xB8
	private X509Certificate _cert; // 0xC0
	private static string empty_error; // 0x0
	private static byte[] signedData; // 0x8

	// Properties
	public override bool IsValid { get; }
	public override IntPtr Handle { get; }
	private X509Certificate Cert { get; }
	public override bool HasPrivateKey { get; }
	public override AsymmetricAlgorithm PrivateKey { get; set; }
	public override PublicKey PublicKey { get; }
	internal override X509CertificateImplCollection IntermediateCertificates { get; }
	internal X509Certificate MonoCertificate { get; }
	internal override X509Certificate2Impl FallbackImpl { get; }

	// Methods

	// RVA: 0x22FFD50 Offset: 0x22FEF50 VA: 0x1822FFD50 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	public override IntPtr get_Handle() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 7
	public override IntPtr GetNativeAppleCertificate() { }

	// RVA: 0x22FFC00 Offset: 0x22FEE00 VA: 0x1822FFC00
	public void .ctor(X509Certificate cert) { }

	// RVA: 0x22FFC30 Offset: 0x22FEE30 VA: 0x1822FFC30
	private void .ctor(X509Certificate2ImplMono other) { }

	// RVA: 0x22FF9D0 Offset: 0x22FEBD0 VA: 0x1822FF9D0
	public void .ctor(byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x22FE9B0 Offset: 0x22FDBB0 VA: 0x1822FE9B0 Slot: 8
	public override X509CertificateImpl Clone() { }

	// RVA: 0x22FFD00 Offset: 0x22FEF00 VA: 0x1822FFD00
	private X509Certificate get_Cert() { }

	// RVA: 0x22FEFD0 Offset: 0x22FE1D0 VA: 0x1822FEFD0 Slot: 47
	protected override byte[] GetRawCertData() { }

	// RVA: 0x22FEA80 Offset: 0x22FDC80 VA: 0x1822FEA80 Slot: 17
	public override bool Equals(X509CertificateImpl other, out bool result) { }

	// RVA: 0x22FFCD0 Offset: 0x22FEED0 VA: 0x1822FFCD0
	public void .ctor() { }

	// RVA: 0x22FFD20 Offset: 0x22FEF20 VA: 0x1822FFD20 Slot: 22
	public override bool get_HasPrivateKey() { }

	// RVA: 0x22FFD60 Offset: 0x22FEF60 VA: 0x1822FFD60 Slot: 35
	public override AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x2300310 Offset: 0x22FF510 VA: 0x182300310 Slot: 36
	public override void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x22FEF40 Offset: 0x22FE140 VA: 0x1822FEF40 Slot: 23
	public override RSA GetRSAPrivateKey() { }

	// RVA: 0x22FEEB0 Offset: 0x22FE0B0 VA: 0x1822FEEB0 Slot: 24
	public override DSA GetDSAPrivateKey() { }

	// RVA: 0x23001B0 Offset: 0x22FF3B0 VA: 0x1823001B0 Slot: 37
	public override PublicKey get_PublicKey() { }

	// RVA: 0x22FF700 Offset: 0x22FE900 VA: 0x1822FF700
	private X509Certificate ImportPkcs12(byte[] rawData, SafePasswordHandle password) { }

	// RVA: 0x22FF020 Offset: 0x22FE220 VA: 0x1822FF020
	private X509Certificate ImportPkcs12(byte[] rawData, string password) { }

	// RVA: 0x22FF770 Offset: 0x22FE970 VA: 0x1822FF770 Slot: 46
	public override void Reset() { }

	[MonoTODO("by default this depends on the incomplete X509Chain")]
	// RVA: 0x22FF810 Offset: 0x22FEA10 VA: 0x1822FF810 Slot: 44
	public override bool Verify(X509Certificate2 thisCertificate) { }

	[MonoTODO("Detection limited to Cert, Pfx, Pkcs12, Pkcs7 and Unknown")]
	// RVA: 0x22FEA90 Offset: 0x22FDC90 VA: 0x1822FEA90
	public static X509ContentType GetCertContentType(byte[] rawData) { }

	[MonoTODO("Detection limited to Cert, Pfx, Pkcs12 and Unknown")]
	// RVA: 0x22FEDB0 Offset: 0x22FDFB0 VA: 0x1822FEDB0
	public static X509ContentType GetCertContentType(string fileName) { }

	// RVA: 0x796080 Offset: 0x795280 VA: 0x180796080 Slot: 41
	internal override X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: 0x7381F0 Offset: 0x7373F0 VA: 0x1807381F0
	internal X509Certificate get_MonoCertificate() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 42
	internal override X509Certificate2Impl get_FallbackImpl() { }

	// RVA: 0x22FF920 Offset: 0x22FEB20 VA: 0x1822FF920
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509Certificate2ImplUnix : X509Certificate2Impl // TypeDefIndex: 5156
{
	// Fields
	private bool readCertData; // 0x10
	private CertificateData certData; // 0x18

	// Properties
	public sealed override bool Archived { get; set; }
	public sealed override string KeyAlgorithm { get; }
	public sealed override byte[] KeyAlgorithmParameters { get; }
	public sealed override byte[] PublicKeyValue { get; }
	public sealed override byte[] SerialNumber { get; }
	public sealed override string SignatureAlgorithm { get; }
	public sealed override string FriendlyName { get; set; }
	public sealed override int Version { get; }
	public sealed override X500DistinguishedName SubjectName { get; }
	public sealed override X500DistinguishedName IssuerName { get; }
	public sealed override string Subject { get; }
	public sealed override string Issuer { get; }
	public sealed override string LegacySubject { get; }
	public sealed override string LegacyIssuer { get; }
	public sealed override byte[] RawData { get; }
	public sealed override byte[] Thumbprint { get; }
	public sealed override IEnumerable<X509Extension> Extensions { get; }
	public sealed override DateTime NotAfter { get; }
	public sealed override DateTime NotBefore { get; }

	// Methods

	// RVA: 0x2300610 Offset: 0x22FF810 VA: 0x182300610
	private void EnsureCertData() { }

	// RVA: -1 Offset: -1 Slot: 47
	protected abstract byte[] GetRawCertData();

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 29
	public sealed override bool get_Archived() { }

	// RVA: 0x2301310 Offset: 0x2300510 VA: 0x182301310 Slot: 30
	public sealed override void set_Archived(bool value) { }

	// RVA: 0x2300E10 Offset: 0x2300010 VA: 0x182300E10 Slot: 18
	public sealed override string get_KeyAlgorithm() { }

	// RVA: 0x2300DF0 Offset: 0x22FFFF0 VA: 0x182300DF0 Slot: 19
	public sealed override byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x2301150 Offset: 0x2300350 VA: 0x182301150 Slot: 20
	public sealed override byte[] get_PublicKeyValue() { }

	// RVA: 0x2301190 Offset: 0x2300390 VA: 0x182301190 Slot: 21
	public sealed override byte[] get_SerialNumber() { }

	// RVA: 0x23011B0 Offset: 0x23003B0 VA: 0x1823011B0 Slot: 38
	public sealed override string get_SignatureAlgorithm() { }

	// RVA: 0x2300D70 Offset: 0x22FFF70 VA: 0x182300D70 Slot: 32
	public sealed override string get_FriendlyName() { }

	// RVA: 0x2301390 Offset: 0x2300590 VA: 0x182301390 Slot: 33
	public sealed override void set_FriendlyName(string value) { }

	// RVA: 0x23012F0 Offset: 0x23004F0 VA: 0x1823012F0 Slot: 40
	public sealed override int get_Version() { }

	// RVA: 0x23011D0 Offset: 0x23003D0 VA: 0x1823011D0 Slot: 39
	public sealed override X500DistinguishedName get_SubjectName() { }

	// RVA: 0x2300DA0 Offset: 0x22FFFA0 VA: 0x182300DA0 Slot: 34
	public sealed override X500DistinguishedName get_IssuerName() { }

	// RVA: 0x23011F0 Offset: 0x23003F0 VA: 0x1823011F0 Slot: 10
	public sealed override string get_Subject() { }

	// RVA: 0x2300DC0 Offset: 0x22FFFC0 VA: 0x182300DC0 Slot: 9
	public sealed override string get_Issuer() { }

	// RVA: 0x2300F60 Offset: 0x2300160 VA: 0x182300F60 Slot: 12
	public sealed override string get_LegacySubject() { }

	// RVA: 0x2300E30 Offset: 0x2300030 VA: 0x182300E30 Slot: 11
	public sealed override string get_LegacyIssuer() { }

	// RVA: 0x2301170 Offset: 0x2300370 VA: 0x182301170 Slot: 13
	public sealed override byte[] get_RawData() { }

	// RVA: 0x2301220 Offset: 0x2300420 VA: 0x182301220 Slot: 16
	public sealed override byte[] get_Thumbprint() { }

	// RVA: 0x2300D10 Offset: 0x22FFF10 VA: 0x182300D10 Slot: 43
	public sealed override string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x2300D50 Offset: 0x22FFF50 VA: 0x182300D50 Slot: 31
	public sealed override IEnumerable<X509Extension> get_Extensions() { }

	// RVA: 0x2301090 Offset: 0x2300290 VA: 0x182301090 Slot: 14
	public sealed override DateTime get_NotAfter() { }

	// RVA: 0x23010F0 Offset: 0x23002F0 VA: 0x1823010F0 Slot: 15
	public sealed override DateTime get_NotBefore() { }

	// RVA: 0x2300580 Offset: 0x22FF780 VA: 0x182300580 Slot: 45
	public sealed override void AppendPrivateKeyInfo(StringBuilder sb) { }

	// RVA: 0x798650 Offset: 0x797850 VA: 0x180798650 Slot: 46
	public override void Reset() { }

	// RVA: 0x2300B90 Offset: 0x22FFD90 VA: 0x182300B90 Slot: 25
	public sealed override byte[] Export(X509ContentType contentType, SafePasswordHandle password) { }

	// RVA: 0x2300720 Offset: 0x22FF920 VA: 0x182300720
	private byte[] ExportPkcs12(SafePasswordHandle password) { }

	// RVA: 0x2300780 Offset: 0x22FF980 VA: 0x182300780
	private byte[] ExportPkcs12(string password) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	protected void .ctor() { }
}

// Namespace: 
public class X509CertificateCollection.X509CertificateEnumerator : IEnumerator // TypeDefIndex: 5157
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public X509Certificate Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x2304020 Offset: 0x2303220 VA: 0x182304020
	public void .ctor(X509CertificateCollection mappings) { }

	// RVA: 0x2304090 Offset: 0x2303290 VA: 0x182304090
	public X509Certificate get_Current() { }

	// RVA: 0x2303FD0 Offset: 0x23031D0 VA: 0x182303FD0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2303F30 Offset: 0x2303130 VA: 0x182303F30 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x2303F80 Offset: 0x2303180 VA: 0x182303F80 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x2303E90 Offset: 0x2303090 VA: 0x182303E90
	public bool MoveNext() { }

	// RVA: 0x2303EE0 Offset: 0x23030E0 VA: 0x182303EE0
	public void Reset() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[DefaultMember("Item")]
[Serializable]
public class X509CertificateCollection : CollectionBase // TypeDefIndex: 5158
{
	// Properties
	public X509Certificate Item { get; set; }

	// Methods

	// RVA: 0x154B280 Offset: 0x154A480 VA: 0x18154B280
	public void .ctor() { }

	// RVA: 0x2303C10 Offset: 0x2302E10 VA: 0x182303C10
	public void .ctor(X509Certificate[] value) { }

	// RVA: 0x2303CE0 Offset: 0x2302EE0 VA: 0x182303CE0
	public void .ctor(X509CertificateCollection value) { }

	// RVA: 0x2303DD0 Offset: 0x2302FD0 VA: 0x182303DD0
	public X509Certificate get_Item(int index) { }

	// RVA: 0x2116DB0 Offset: 0x2115FB0 VA: 0x182116DB0
	public void set_Item(int index, X509Certificate value) { }

	// RVA: 0x2303830 Offset: 0x2302A30 VA: 0x182303830
	public int Add(X509Certificate value) { }

	// RVA: 0x2303760 Offset: 0x2302960 VA: 0x182303760
	public void AddRange(X509Certificate[] value) { }

	// RVA: 0x2303680 Offset: 0x2302880 VA: 0x182303680
	public void AddRange(X509CertificateCollection value) { }

	// RVA: 0x23038C0 Offset: 0x2302AC0 VA: 0x1823038C0
	public bool Contains(X509Certificate value) { }

	// RVA: 0x1718DE0 Offset: 0x1717FE0 VA: 0x181718DE0
	public void CopyTo(X509Certificate[] array, int index) { }

	// RVA: 0x2303A60 Offset: 0x2302C60 VA: 0x182303A60
	public X509CertificateCollection.X509CertificateEnumerator GetEnumerator() { }

	// RVA: 0x5BF760 Offset: 0x5BE960 VA: 0x1805BF760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1718FB0 Offset: 0x17181B0 VA: 0x181718FB0
	public int IndexOf(X509Certificate value) { }

	// RVA: 0x2116920 Offset: 0x2115B20 VA: 0x182116920
	public void Insert(int index, X509Certificate value) { }

	// RVA: 0x2303AF0 Offset: 0x2302CF0 VA: 0x182303AF0
	public void Remove(X509Certificate value) { }

	// RVA: 0x154AF50 Offset: 0x154A150 VA: 0x18154AF50
	private bool Compare(byte[] array1, byte[] array2) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[DefaultMember("Item")]
internal class X509CertificateImplCollection : IDisposable // TypeDefIndex: 5159
{
	// Fields
	private List<X509CertificateImpl> list; // 0x10

	// Properties
	public int Count { get; }
	public X509CertificateImpl Item { get; }

	// Methods

	// RVA: 0x2304440 Offset: 0x2303640 VA: 0x182304440
	public void .ctor() { }

	// RVA: 0x23044B0 Offset: 0x23036B0 VA: 0x1823044B0
	private void .ctor(X509CertificateImplCollection other) { }

	// RVA: 0x23046B0 Offset: 0x23038B0 VA: 0x1823046B0
	public int get_Count() { }

	// RVA: 0x23046F0 Offset: 0x23038F0 VA: 0x1823046F0
	public X509CertificateImpl get_Item(int index) { }

	// RVA: 0x2304140 Offset: 0x2303340 VA: 0x182304140
	public void Add(X509CertificateImpl impl, bool takeOwnership) { }

	// RVA: 0x2304220 Offset: 0x2303420 VA: 0x182304220
	public X509CertificateImplCollection Clone() { }

	// RVA: 0x23043D0 Offset: 0x23035D0 VA: 0x1823043D0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2304280 Offset: 0x2303480 VA: 0x182304280 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x15667F0 Offset: 0x15659F0 VA: 0x1815667F0 Slot: 1
	protected override void Finalize() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509Chain : IDisposable // TypeDefIndex: 5160
{
	// Fields
	private X509ChainImpl impl; // 0x10

	// Properties
	internal X509ChainImpl Impl { get; }
	internal bool IsValid { get; }
	[MonoTODO("Mono's X509Chain is fully managed. Always returns IntPtr.Zero.")]
	public IntPtr ChainContext { get; }
	public X509ChainElementCollection ChainElements { get; }
	public X509ChainPolicy ChainPolicy { get; set; }
	public X509ChainStatus[] ChainStatus { get; }
	public SafeX509ChainHandle SafeHandle { get; }

	// Methods

	// RVA: 0x2309430 Offset: 0x2308630 VA: 0x182309430
	internal X509ChainImpl get_Impl() { }

	// RVA: 0x2309450 Offset: 0x2308650 VA: 0x182309450
	internal bool get_IsValid() { }

	// RVA: 0x2309220 Offset: 0x2308420 VA: 0x182309220
	internal void ThrowIfContextInvalid() { }

	// RVA: 0x23092B0 Offset: 0x23084B0 VA: 0x1823092B0
	public void .ctor() { }

	// RVA: 0x23092E0 Offset: 0x23084E0 VA: 0x1823092E0
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x2309280 Offset: 0x2308480 VA: 0x182309280
	internal void .ctor(X509ChainImpl impl) { }

	[MonoTODO("Mono's X509Chain is fully managed. All handles are invalid.")]
	// RVA: 0x2309230 Offset: 0x2308430 VA: 0x182309230
	public void .ctor(IntPtr chainContext) { }

	// RVA: 0x2309310 Offset: 0x2308510 VA: 0x182309310
	public IntPtr get_ChainContext() { }

	// RVA: 0x2309370 Offset: 0x2308570 VA: 0x182309370
	public X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x23093B0 Offset: 0x23085B0 VA: 0x1823093B0
	public X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x23094A0 Offset: 0x23086A0 VA: 0x1823094A0
	public void set_ChainPolicy(X509ChainPolicy value) { }

	// RVA: 0x23093F0 Offset: 0x23085F0 VA: 0x1823093F0
	public X509ChainStatus[] get_ChainStatus() { }

	// RVA: 0x2309460 Offset: 0x2308660 VA: 0x182309460
	public SafeX509ChainHandle get_SafeHandle() { }

	[MonoTODO("Not totally RFC3280 compliant, but neither is MS implementation...")]
	// RVA: 0x2309040 Offset: 0x2308240 VA: 0x182309040
	public bool Build(X509Certificate2 certificate) { }

	// RVA: 0x23091E0 Offset: 0x23083E0 VA: 0x1823091E0
	public void Reset() { }

	// RVA: 0x2309090 Offset: 0x2308290 VA: 0x182309090
	public static X509Chain Create() { }

	// RVA: 0x2309170 Offset: 0x2308370 VA: 0x182309170 Slot: 4
	public void Dispose() { }

	// RVA: 0x23090F0 Offset: 0x23082F0 VA: 0x1823090F0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x15667F0 Offset: 0x15659F0 VA: 0x1815667F0 Slot: 1
	protected override void Finalize() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509ChainElement // TypeDefIndex: 5161
{
	// Fields
	private X509Certificate2 certificate; // 0x10
	private X509ChainStatus[] status; // 0x18
	private string info; // 0x20
	private X509ChainStatusFlags compressed_status_flags; // 0x28

	// Properties
	public X509Certificate2 Certificate { get; }
	public X509ChainStatus[] ChainElementStatus { get; }
	public string Information { get; }
	internal X509ChainStatusFlags StatusFlags { get; set; }

	// Methods

	// RVA: 0x2305650 Offset: 0x2304850 VA: 0x182305650
	internal void .ctor(X509Certificate2 certificate) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public X509Certificate2 get_Certificate() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public X509ChainStatus[] get_ChainElementStatus() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Information() { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	internal X509ChainStatusFlags get_StatusFlags() { }

	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	internal void set_StatusFlags(X509ChainStatusFlags value) { }

	// RVA: 0x2304E00 Offset: 0x2304000 VA: 0x182304E00
	private int Count(X509ChainStatusFlags flags) { }

	// RVA: 0x2304E30 Offset: 0x2304030 VA: 0x182304E30
	private void Set(X509ChainStatus[] status, ref int position, X509ChainStatusFlags flags, X509ChainStatusFlags mask) { }

	// RVA: 0x2304EA0 Offset: 0x23040A0 VA: 0x182304EA0
	internal void UncompressFlags() { }

	// RVA: 0x2305620 Offset: 0x2304820 VA: 0x182305620
	internal void .ctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[DefaultMember("Item")]
public sealed class X509ChainElementCollection : ICollection, IEnumerable // TypeDefIndex: 5162
{
	// Fields
	private ArrayList _list; // 0x10

	// Properties
	public int Count { get; }
	public bool IsSynchronized { get; }
	public X509ChainElement Item { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x2304AA0 Offset: 0x2303CA0 VA: 0x182304AA0
	internal void .ctor() { }

	// RVA: 0x1719620 Offset: 0x1718820 VA: 0x181719620 Slot: 5
	public int get_Count() { }

	// RVA: 0x1718E10 Offset: 0x1718010 VA: 0x181718E10 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x2304B00 Offset: 0x2303D00 VA: 0x182304B00
	public X509ChainElement get_Item(int index) { }

	// RVA: 0x1718E40 Offset: 0x1718040 VA: 0x181718E40 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x1718DE0 Offset: 0x1717FE0 VA: 0x181718DE0
	public void CopyTo(X509ChainElement[] array, int index) { }

	// RVA: 0x1718DE0 Offset: 0x1717FE0 VA: 0x181718DE0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x2304980 Offset: 0x2303B80 VA: 0x182304980
	public X509ChainElementEnumerator GetEnumerator() { }

	// RVA: 0x2304A10 Offset: 0x2303C10 VA: 0x182304A10 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2304750 Offset: 0x2303950 VA: 0x182304750
	internal void Add(X509Certificate2 certificate) { }

	// RVA: 0x159D610 Offset: 0x159C810 VA: 0x18159D610
	internal void Clear() { }

	// RVA: 0x2304810 Offset: 0x2303A10 VA: 0x182304810
	internal bool Contains(X509Certificate2 certificate) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ChainElementEnumerator : IEnumerator // TypeDefIndex: 5163
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public X509ChainElement Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x2304CB0 Offset: 0x2303EB0 VA: 0x182304CB0
	internal void .ctor(IEnumerable enumerable) { }

	// RVA: 0x2304D50 Offset: 0x2303F50 VA: 0x182304D50
	public X509ChainElement get_Current() { }

	// RVA: 0x2304C60 Offset: 0x2303E60 VA: 0x182304C60 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2304BC0 Offset: 0x2303DC0 VA: 0x182304BC0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x2304C10 Offset: 0x2303E10 VA: 0x182304C10 Slot: 6
	public void Reset() { }

	// RVA: 0x2304D20 Offset: 0x2303F20 VA: 0x182304D20
	internal void .ctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509ChainImpl : IDisposable // TypeDefIndex: 5164
{
	// Properties
	public abstract bool IsValid { get; }
	public abstract IntPtr Handle { get; }
	public abstract X509ChainElementCollection ChainElements { get; }
	public abstract X509ChainPolicy ChainPolicy { get; set; }
	public abstract X509ChainStatus[] ChainStatus { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsValid();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IntPtr get_Handle();

	// RVA: 0x2308FF0 Offset: 0x23081F0 VA: 0x182308FF0
	protected void ThrowIfContextInvalid() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract X509ChainElementCollection get_ChainElements();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract X509ChainPolicy get_ChainPolicy();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void set_ChainPolicy(X509ChainPolicy value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract X509ChainStatus[] get_ChainStatus();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool Build(X509Certificate2 certificate);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void AddStatus(X509ChainStatusFlags errorCode);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void Reset();

	// RVA: 0x2308F80 Offset: 0x2308180 VA: 0x182308F80 Slot: 4
	public void Dispose() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 14
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1B07300 Offset: 0x1B06500 VA: 0x181B07300 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal class X509ChainImplMono : X509ChainImpl // TypeDefIndex: 5165
{
	// Fields
	private StoreLocation location; // 0x10
	private X509ChainElementCollection elements; // 0x18
	private X509ChainPolicy policy; // 0x20
	private X509ChainStatus[] status; // 0x28
	private static X509ChainStatus[] Empty; // 0x0
	private int max_path_length; // 0x30
	private X500DistinguishedName working_issuer_name; // 0x38
	private AsymmetricAlgorithm working_public_key; // 0x40
	private X509ChainElement bce_restriction; // 0x48
	private X509Certificate2Collection roots; // 0x50
	private X509Certificate2Collection cas; // 0x58
	private X509Store root_store; // 0x60
	private X509Store ca_store; // 0x68
	private X509Store user_root_store; // 0x70
	private X509Store user_ca_store; // 0x78
	private X509Certificate2Collection collection; // 0x80

	// Properties
	public override bool IsValid { get; }
	public override IntPtr Handle { get; }
	public override X509ChainElementCollection ChainElements { get; }
	public override X509ChainPolicy ChainPolicy { get; set; }
	public override X509ChainStatus[] ChainStatus { get; }
	private X509Certificate2Collection Roots { get; }
	private X509Certificate2Collection CertificateAuthorities { get; }
	private X509Store LMRootStore { get; }
	private X509Store UserRootStore { get; }
	private X509Store LMCAStore { get; }
	private X509Store UserCAStore { get; }
	private X509Certificate2Collection CertificateCollection { get; }

	// Methods

	// RVA: 0x2308600 Offset: 0x2307800 VA: 0x182308600
	public void .ctor() { }

	// RVA: 0x2308520 Offset: 0x2307720 VA: 0x182308520
	public void .ctor(bool useMachineContext) { }

	[MonoTODO("Mono's X509Chain is fully managed. All handles are invalid.")]
	// RVA: 0x23086E0 Offset: 0x23078E0 VA: 0x1823086E0
	public void .ctor(IntPtr chainContext) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	public override IntPtr get_Handle() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	public override X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 8
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0 Slot: 9
	public override void set_ChainPolicy(X509ChainPolicy value) { }

	// RVA: 0x2308AF0 Offset: 0x2307CF0 VA: 0x182308AF0 Slot: 10
	public override X509ChainStatus[] get_ChainStatus() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 12
	public override void AddStatus(X509ChainStatusFlags error) { }

	[MonoTODO("Not totally RFC3280 compliant, but neither is MS implementation...")]
	// RVA: 0x2305A40 Offset: 0x2304C40 VA: 0x182305A40 Slot: 11
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0x2307EE0 Offset: 0x23070E0 VA: 0x182307EE0 Slot: 13
	public override void Reset() { }

	// RVA: 0x2308CA0 Offset: 0x2307EA0 VA: 0x182308CA0
	private X509Certificate2Collection get_Roots() { }

	// RVA: 0x2308730 Offset: 0x2307930 VA: 0x182308730
	private X509Certificate2Collection get_CertificateAuthorities() { }

	// RVA: 0x2308C00 Offset: 0x2307E00 VA: 0x182308C00
	private X509Store get_LMRootStore() { }

	// RVA: 0x2308EE0 Offset: 0x23080E0 VA: 0x182308EE0
	private X509Store get_UserRootStore() { }

	// RVA: 0x2308B60 Offset: 0x2307D60 VA: 0x182308B60
	private X509Store get_LMCAStore() { }

	// RVA: 0x2308E40 Offset: 0x2308040 VA: 0x182308E40
	private X509Store get_UserCAStore() { }

	// RVA: 0x23088D0 Offset: 0x2307AD0 VA: 0x1823088D0
	private X509Certificate2Collection get_CertificateCollection() { }

	// RVA: 0x23056B0 Offset: 0x23048B0 VA: 0x1823056B0
	private X509ChainStatusFlags BuildChainFrom(X509Certificate2 certificate) { }

	// RVA: 0x2307FE0 Offset: 0x23071E0 VA: 0x182307FE0
	private X509Certificate2 SelectBestFromCollection(X509Certificate2 child, X509Certificate2Collection c) { }

	// RVA: 0x2306C60 Offset: 0x2305E60 VA: 0x182306C60
	private X509Certificate2 FindParent(X509Certificate2 certificate) { }

	// RVA: 0x2307140 Offset: 0x2306340 VA: 0x182307140
	private bool IsChainComplete(X509Certificate2 certificate) { }

	// RVA: 0x2307290 Offset: 0x2306490 VA: 0x182307290
	private bool IsSelfIssued(X509Certificate2 certificate) { }

	// RVA: 0x23081D0 Offset: 0x23073D0 VA: 0x1823081D0
	private void ValidateChain(X509ChainStatusFlags flag) { }

	// RVA: 0x2307B70 Offset: 0x2306D70 VA: 0x182307B70
	private void Process(int n) { }

	// RVA: 0x2307330 Offset: 0x2306530 VA: 0x182307330
	private void PrepareForNextCertificate(int n) { }

	// RVA: 0x23083E0 Offset: 0x23075E0 VA: 0x1823083E0
	private void WrapUp() { }

	// RVA: 0x2307680 Offset: 0x2306880 VA: 0x182307680
	private void ProcessCertificateExtensions(X509ChainElement element) { }

	// RVA: 0x23072E0 Offset: 0x23064E0 VA: 0x1823072E0
	private bool IsSignedWith(X509Certificate2 signed, AsymmetricAlgorithm pubkey) { }

	// RVA: 0x2307090 Offset: 0x2306290 VA: 0x182307090
	private string GetSubjectKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x2306E10 Offset: 0x2306010 VA: 0x182306E10
	private static string GetAuthorityKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x2306EA0 Offset: 0x23060A0 VA: 0x182306EA0
	private static string GetAuthorityKeyIdentifier(X509Crl crl) { }

	// RVA: 0x2306F20 Offset: 0x2306120 VA: 0x182306F20
	private static string GetAuthorityKeyIdentifier(X509Extension ext) { }

	// RVA: 0x23063E0 Offset: 0x23055E0 VA: 0x1823063E0
	private void CheckRevocationOnChain(X509ChainStatusFlags flag) { }

	// RVA: 0x2306850 Offset: 0x2305A50 VA: 0x182306850
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, int ca, bool online) { }

	// RVA: 0x2306640 Offset: 0x2305840 VA: 0x182306640
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, X509Certificate2 ca_cert, bool online) { }

	// RVA: 0x2306190 Offset: 0x2305390 VA: 0x182306190
	private static X509Crl CheckCrls(string subject, string ski, X509Store store) { }

	// RVA: 0x2306990 Offset: 0x2305B90 VA: 0x182306990
	private X509Crl FindCrl(X509Certificate2 caCertificate) { }

	// RVA: 0x2307950 Offset: 0x2306B50 VA: 0x182307950
	private bool ProcessCrlExtensions(X509Crl crl) { }

	// RVA: 0x2307770 Offset: 0x2306970 VA: 0x182307770
	private bool ProcessCrlEntryExtensions(X509Crl.X509CrlEntry entry) { }

	// RVA: 0x23084D0 Offset: 0x23076D0 VA: 0x1823084D0
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ChainPolicy // TypeDefIndex: 5166
{
	// Fields
	private OidCollection apps; // 0x10
	private OidCollection cert; // 0x18
	private X509CertificateCollection store; // 0x20
	private X509Certificate2Collection store2; // 0x28
	private X509RevocationFlag rflag; // 0x30
	private X509RevocationMode mode; // 0x34
	private TimeSpan timeout; // 0x38
	private X509VerificationFlags vflags; // 0x40
	private DateTime vtime; // 0x48

	// Properties
	public OidCollection ApplicationPolicy { get; }
	public OidCollection CertificatePolicy { get; }
	public X509Certificate2Collection ExtraStore { get; set; }
	public X509RevocationFlag RevocationFlag { get; set; }
	public X509RevocationMode RevocationMode { get; set; }
	public TimeSpan UrlRetrievalTimeout { get; set; }
	public X509VerificationFlags VerificationFlags { get; set; }
	public DateTime VerificationTime { get; set; }

	// Methods

	// RVA: 0x231E1A0 Offset: 0x231D3A0 VA: 0x18231E1A0
	public void .ctor() { }

	// RVA: 0x231E1C0 Offset: 0x231D3C0 VA: 0x18231E1C0
	internal void .ctor(X509CertificateCollection store) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public OidCollection get_ApplicationPolicy() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public OidCollection get_CertificatePolicy() { }

	// RVA: 0x231E1F0 Offset: 0x231D3F0 VA: 0x18231E1F0
	public X509Certificate2Collection get_ExtraStore() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	internal void set_ExtraStore(X509Certificate2Collection value) { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public X509RevocationFlag get_RevocationFlag() { }

	// RVA: 0x231E390 Offset: 0x231D590 VA: 0x18231E390
	public void set_RevocationFlag(X509RevocationFlag value) { }

	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480
	public X509RevocationMode get_RevocationMode() { }

	// RVA: 0x231E400 Offset: 0x231D600 VA: 0x18231E400
	public void set_RevocationMode(X509RevocationMode value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public TimeSpan get_UrlRetrievalTimeout() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_UrlRetrievalTimeout(TimeSpan value) { }

	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440
	public X509VerificationFlags get_VerificationFlags() { }

	// RVA: 0x231E470 Offset: 0x231D670 VA: 0x18231E470
	public void set_VerificationFlags(X509VerificationFlags value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public DateTime get_VerificationTime() { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_VerificationTime(DateTime value) { }

	// RVA: 0x231E0B0 Offset: 0x231D2B0 VA: 0x18231E0B0
	public void Reset() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public struct X509ChainStatus // TypeDefIndex: 5167
{
	// Fields
	private X509ChainStatusFlags status; // 0x0
	private string info; // 0x8

	// Properties
	public X509ChainStatusFlags Status { get; set; }
	public string StatusInformation { get; set; }

	// Methods

	// RVA: 0x231E660 Offset: 0x231D860 VA: 0x18231E660
	internal void .ctor(X509ChainStatusFlags flag) { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public X509ChainStatusFlags get_Status() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_Status(X509ChainStatusFlags value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public string get_StatusInformation() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_StatusInformation(string value) { }

	// RVA: 0x231E4E0 Offset: 0x231D6E0 VA: 0x18231E4E0
	internal static string GetInformation(X509ChainStatusFlags flags) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509EnhancedKeyUsageExtension : X509Extension // TypeDefIndex: 5168
{
	// Fields
	internal const string oid = "2.5.29.37";
	internal const string friendlyName = "Enhanced Key Usage";
	private OidCollection _enhKeyUsage; // 0x28
	private AsnDecodeStatus _status; // 0x30

	// Properties
	public OidCollection EnhancedKeyUsages { get; }

	// Methods

	// RVA: 0x231EF40 Offset: 0x231E140 VA: 0x18231EF40
	public void .ctor() { }

	// RVA: 0x231EFD0 Offset: 0x231E1D0 VA: 0x18231EFD0
	public void .ctor(AsnEncodedData encodedEnhancedKeyUsages, bool critical) { }

	// RVA: 0x231F0A0 Offset: 0x231E2A0 VA: 0x18231F0A0
	public void .ctor(OidCollection enhancedKeyUsages, bool critical) { }

	// RVA: 0x231F2E0 Offset: 0x231E4E0 VA: 0x18231F2E0
	public OidCollection get_EnhancedKeyUsages() { }

	// RVA: 0x231E800 Offset: 0x231DA00 VA: 0x18231E800 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x231E9E0 Offset: 0x231DBE0 VA: 0x18231E9E0
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x231EBB0 Offset: 0x231DDB0 VA: 0x18231EBB0
	internal byte[] Encode() { }

	// RVA: 0x231EC80 Offset: 0x231DE80 VA: 0x18231EC80 Slot: 6
	internal override string ToString(bool multiLine) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509Extension : AsnEncodedData // TypeDefIndex: 5169
{
	// Fields
	private bool _critical; // 0x20

	// Properties
	public bool Critical { get; set; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	protected void .ctor() { }

	// RVA: 0x23206F0 Offset: 0x231F8F0 VA: 0x1823206F0
	public void .ctor(AsnEncodedData encodedExtension, bool critical) { }

	// RVA: 0x2320640 Offset: 0x231F840 VA: 0x182320640
	public void .ctor(Oid oid, byte[] rawData, bool critical) { }

	// RVA: 0x2320610 Offset: 0x231F810 VA: 0x182320610
	public void .ctor(string oid, byte[] rawData, bool critical) { }

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_Critical() { }

	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	public void set_Critical(bool value) { }

	// RVA: 0x23203D0 Offset: 0x231F5D0 VA: 0x1823203D0 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x2320510 Offset: 0x231F710 VA: 0x182320510
	internal string FormatUnkownData(byte[] data) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[DefaultMember("Item")]
public sealed class X509ExtensionCollection : ICollection, IEnumerable // TypeDefIndex: 5170
{
	// Fields
	private static byte[] Empty; // 0x0
	private ArrayList _list; // 0x10

	// Properties
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	public X509Extension Item { get; }
	public X509Extension Item { get; }

	// Methods

	// RVA: 0x231F830 Offset: 0x231EA30 VA: 0x18231F830
	public void .ctor() { }

	// RVA: 0x231F890 Offset: 0x231EA90 VA: 0x18231F890
	internal void .ctor(X509Certificate cert) { }

	// RVA: 0x1719620 Offset: 0x1718820 VA: 0x181719620 Slot: 5
	public int get_Count() { }

	// RVA: 0x1718E10 Offset: 0x1718010 VA: 0x181718E10 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x23200A0 Offset: 0x231F2A0 VA: 0x1823200A0
	public X509Extension get_Item(int index) { }

	// RVA: 0x231FE20 Offset: 0x231F020 VA: 0x18231FE20
	public X509Extension get_Item(string oid) { }

	// RVA: 0x231F3E0 Offset: 0x231E5E0 VA: 0x18231F3E0
	public int Add(X509Extension extension) { }

	// RVA: 0x231F470 Offset: 0x231E670 VA: 0x18231F470
	public void CopyTo(X509Extension[] array, int index) { }

	// RVA: 0x231F610 Offset: 0x231E810 VA: 0x18231F610 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x231F590 Offset: 0x231E790 VA: 0x18231F590
	public X509ExtensionEnumerator GetEnumerator() { }

	// RVA: 0x231F760 Offset: 0x231E960 VA: 0x18231F760 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x231F7E0 Offset: 0x231E9E0 VA: 0x18231F7E0
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ExtensionEnumerator : IEnumerator // TypeDefIndex: 5171
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public X509Extension Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x23202A0 Offset: 0x231F4A0 VA: 0x1823202A0
	internal void .ctor(ArrayList list) { }

	// RVA: 0x2320320 Offset: 0x231F520 VA: 0x182320320
	public X509Extension get_Current() { }

	// RVA: 0x2320250 Offset: 0x231F450 VA: 0x182320250 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x23201B0 Offset: 0x231F3B0 VA: 0x1823201B0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x2320200 Offset: 0x231F400 VA: 0x182320200 Slot: 6
	public void Reset() { }

	// RVA: 0x23202F0 Offset: 0x231F4F0 VA: 0x1823202F0
	internal void .ctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal static class X509Helper2 // TypeDefIndex: 5172
{
	// Methods

	[MonoTODO("Investigate replacement; see comments in source.")]
	// RVA: 0x23209D0 Offset: 0x231FBD0 VA: 0x1823209D0
	internal static X509Certificate GetMonoCertificate(X509Certificate2 certificate) { }

	// RVA: 0x23207A0 Offset: 0x231F9A0 VA: 0x1823207A0
	internal static X509ChainImpl CreateChainImpl(bool useMachineContext) { }

	// RVA: 0x161BA40 Offset: 0x161AC40 VA: 0x18161BA40
	public static bool IsValid(X509ChainImpl impl) { }

	// RVA: 0x2320CE0 Offset: 0x231FEE0 VA: 0x182320CE0
	internal static void ThrowIfContextInvalid(X509ChainImpl impl) { }

	// RVA: 0x2320960 Offset: 0x231FB60 VA: 0x182320960
	internal static Exception GetInvalidChainContextException() { }

	[Obsolete("This is only used by Mono.Security's X509Store and will be replaced shortly.")]
	// RVA: 0x2320B80 Offset: 0x231FD80 VA: 0x182320B80
	internal static long GetSubjectNameHash(X509Certificate certificate) { }

	[Obsolete("This is only used by Mono.Security's X509Store and will be replaced shortly.")]
	// RVA: 0x2320800 Offset: 0x231FA00 VA: 0x182320800
	internal static void ExportAsPEM(X509Certificate certificate, Stream stream, bool includeHumanReadableForm) { }

	// RVA: 0x2320AB0 Offset: 0x231FCB0 VA: 0x182320AB0
	private static MonoBtlsX509 GetNativeInstance(X509CertificateImpl impl) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509KeyUsageExtension : X509Extension // TypeDefIndex: 5173
{
	// Fields
	internal const string oid = "2.5.29.15";
	internal const string friendlyName = "Key Usage";
	internal const X509KeyUsageFlags all = 33023;
	private X509KeyUsageFlags _keyUsages; // 0x28
	private AsnDecodeStatus _status; // 0x2C

	// Properties
	public X509KeyUsageFlags KeyUsages { get; }

	// Methods

	// RVA: 0x23218A0 Offset: 0x2320AA0 VA: 0x1823218A0
	public void .ctor() { }

	// RVA: 0x2321700 Offset: 0x2320900 VA: 0x182321700
	public void .ctor(AsnEncodedData encodedKeyUsage, bool critical) { }

	// RVA: 0x23217D0 Offset: 0x23209D0 VA: 0x1823217D0
	public void .ctor(X509KeyUsageFlags keyUsages, bool critical) { }

	// RVA: 0x2321930 Offset: 0x2320B30 VA: 0x182321930
	public X509KeyUsageFlags get_KeyUsages() { }

	// RVA: 0x2320D30 Offset: 0x231FF30 VA: 0x182320D30 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x23211E0 Offset: 0x23203E0 VA: 0x1823211E0
	internal X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags) { }

	// RVA: 0x2320F10 Offset: 0x2320110 VA: 0x182320F10
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x2321070 Offset: 0x2320270 VA: 0x182321070
	internal byte[] Encode() { }

	// RVA: 0x23211F0 Offset: 0x23203F0 VA: 0x1823211F0 Slot: 6
	internal override string ToString(bool multiLine) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509Store : IDisposable // TypeDefIndex: 5174
{
	// Fields
	private string _name; // 0x10
	private StoreLocation _location; // 0x18
	private X509Certificate2Collection list; // 0x20
	private OpenFlags _flags; // 0x28
	private X509Store store; // 0x30

	// Properties
	public X509Certificate2Collection Certificates { get; }
	public StoreLocation Location { get; }
	public string Name { get; }
	private X509Stores Factory { get; }
	public bool IsOpen { get; }
	private bool IsReadOnly { get; }
	internal X509Store Store { get; }
	[MonoTODO("Mono's stores are fully managed. Always returns IntPtr.Zero.")]
	public IntPtr StoreHandle { get; }

	// Methods

	// RVA: 0x2322CC0 Offset: 0x2321EC0 VA: 0x182322CC0
	public void .ctor() { }

	// RVA: 0x2322AD0 Offset: 0x2321CD0 VA: 0x182322AD0
	public void .ctor(string storeName) { }

	// RVA: 0x2322B70 Offset: 0x2321D70 VA: 0x182322B70
	public void .ctor(StoreName storeName) { }

	// RVA: 0x2322C70 Offset: 0x2321E70 VA: 0x182322C70
	public void .ctor(StoreLocation storeLocation) { }

	// RVA: 0x2322990 Offset: 0x2321B90 VA: 0x182322990
	public void .ctor(StoreName storeName, StoreLocation storeLocation) { }

	// RVA: 0x2322960 Offset: 0x2321B60 VA: 0x182322960
	public void .ctor(StoreName storeName, StoreLocation storeLocation, OpenFlags openFlags) { }

	// RVA: 0x2322C40 Offset: 0x2321E40 VA: 0x182322C40
	public void .ctor(string storeName, StoreLocation storeLocation, OpenFlags openFlags) { }

	[MonoTODO("Mono's stores are fully managed. All handles are invalid.")]
	// RVA: 0x2322B80 Offset: 0x2321D80 VA: 0x182322B80
	public void .ctor(IntPtr storeHandle) { }

	// RVA: 0x2322AE0 Offset: 0x2321CE0 VA: 0x182322AE0
	public void .ctor(string storeName, StoreLocation storeLocation) { }

	// RVA: 0x2322D10 Offset: 0x2321F10 VA: 0x182322D10
	public X509Certificate2Collection get_Certificates() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public StoreLocation get_Location() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	// RVA: 0x2322D90 Offset: 0x2321F90 VA: 0x182322D90
	private X509Stores get_Factory() { }

	// RVA: 0x1656350 Offset: 0x1655550 VA: 0x181656350
	public bool get_IsOpen() { }

	// RVA: 0x2322DB0 Offset: 0x2321FB0 VA: 0x182322DB0
	private bool get_IsReadOnly() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	internal X509Store get_Store() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public IntPtr get_StoreHandle() { }

	// RVA: 0x2321D80 Offset: 0x2320F80 VA: 0x182321D80
	public void Add(X509Certificate2 certificate) { }

	[MonoTODO("Method isn't transactional (like documented)")]
	// RVA: 0x2321AB0 Offset: 0x2320CB0 VA: 0x182321AB0
	public void AddRange(X509Certificate2Collection certificates) { }

	// RVA: 0x2321FB0 Offset: 0x23211B0 VA: 0x182321FB0
	public void Close() { }

	// RVA: 0x2321FB0 Offset: 0x23211B0 VA: 0x182321FB0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2322060 Offset: 0x2321260 VA: 0x182322060
	public void Open(OpenFlags flags) { }

	// RVA: 0x2322720 Offset: 0x2321920 VA: 0x182322720
	public void Remove(X509Certificate2 certificate) { }

	[MonoTODO("Method isn't transactional (like documented)")]
	// RVA: 0x23223E0 Offset: 0x23215E0 VA: 0x1823223E0
	public void RemoveRange(X509Certificate2Collection certificates) { }

	// RVA: 0x2321FD0 Offset: 0x23211D0 VA: 0x182321FD0
	private bool Exists(X509Certificate2 certificate) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509SubjectKeyIdentifierExtension : X509Extension // TypeDefIndex: 5175
{
	// Fields
	internal const string oid = "2.5.29.14";
	internal const string friendlyName = "Subject Key Identifier";
	private byte[] _subjectKeyIdentifier; // 0x28
	private string _ski; // 0x30
	private AsnDecodeStatus _status; // 0x38

	// Properties
	public string SubjectKeyIdentifier { get; }

	// Methods

	// RVA: 0x2323F30 Offset: 0x2323130 VA: 0x182323F30
	public void .ctor() { }

	// RVA: 0x23239F0 Offset: 0x2322BF0 VA: 0x1823239F0
	public void .ctor(AsnEncodedData encodedSubjectKeyIdentifier, bool critical) { }

	// RVA: 0x2323AC0 Offset: 0x2322CC0 VA: 0x182323AC0
	public void .ctor(byte[] subjectKeyIdentifier, bool critical) { }

	// RVA: 0x2323C90 Offset: 0x2322E90 VA: 0x182323C90
	public void .ctor(string subjectKeyIdentifier, bool critical) { }

	// RVA: 0x23239D0 Offset: 0x2322BD0 VA: 0x1823239D0
	public void .ctor(PublicKey key, bool critical) { }

	// RVA: 0x23235D0 Offset: 0x23227D0 VA: 0x1823235D0
	public void .ctor(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical) { }

	// RVA: 0x2323FC0 Offset: 0x23231C0 VA: 0x182323FC0
	public string get_SubjectKeyIdentifier() { }

	// RVA: 0x2322DC0 Offset: 0x2321FC0 VA: 0x182322DC0 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x2323150 Offset: 0x2322350 VA: 0x182323150
	internal static byte FromHexChar(char c) { }

	// RVA: 0x2323180 Offset: 0x2322380 VA: 0x182323180
	internal static byte FromHexChars(char c1, char c2) { }

	// RVA: 0x2323200 Offset: 0x2322400 VA: 0x182323200
	internal static byte[] FromHex(string hex) { }

	// RVA: 0x2322FA0 Offset: 0x23221A0 VA: 0x182322FA0
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x23230D0 Offset: 0x23222D0 VA: 0x1823230D0
	internal byte[] Encode() { }

	// RVA: 0x2323380 Offset: 0x2322580 VA: 0x182323380 Slot: 6
	internal override string ToString(bool multiLine) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class CertificateRequest // TypeDefIndex: 5176
{
	// Properties
	public Collection<X509Extension> CertificateExtensions { get; }
	public HashAlgorithmName HashAlgorithm { get; }
	public PublicKey PublicKey { get; }
	public X500DistinguishedName SubjectName { get; }

	// Methods

	// RVA: 0x230E360 Offset: 0x230D560 VA: 0x18230E360
	public void .ctor(X500DistinguishedName subjectName, ECDsa key, HashAlgorithmName hashAlgorithm) { }

	// RVA: 0x230E400 Offset: 0x230D600 VA: 0x18230E400
	public void .ctor(X500DistinguishedName subjectName, RSA key, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding) { }

	// RVA: 0x230E3B0 Offset: 0x230D5B0 VA: 0x18230E3B0
	public void .ctor(X500DistinguishedName subjectName, PublicKey publicKey, HashAlgorithmName hashAlgorithm) { }

	// RVA: 0x230E2C0 Offset: 0x230D4C0 VA: 0x18230E2C0
	public void .ctor(string subjectName, ECDsa key, HashAlgorithmName hashAlgorithm) { }

	// RVA: 0x230E310 Offset: 0x230D510 VA: 0x18230E310
	public void .ctor(string subjectName, RSA key, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding) { }

	// RVA: 0x230E450 Offset: 0x230D650 VA: 0x18230E450
	public Collection<X509Extension> get_CertificateExtensions() { }

	// RVA: 0x230E490 Offset: 0x230D690 VA: 0x18230E490
	public HashAlgorithmName get_HashAlgorithm() { }

	// RVA: 0x230E4D0 Offset: 0x230D6D0 VA: 0x18230E4D0
	public PublicKey get_PublicKey() { }

	// RVA: 0x230E510 Offset: 0x230D710 VA: 0x18230E510
	public X500DistinguishedName get_SubjectName() { }

	// RVA: 0x230E280 Offset: 0x230D480 VA: 0x18230E280
	public X509Certificate2 Create(X500DistinguishedName issuerName, X509SignatureGenerator generator, DateTimeOffset notBefore, DateTimeOffset notAfter, byte[] serialNumber) { }

	// RVA: 0x230E240 Offset: 0x230D440 VA: 0x18230E240
	public X509Certificate2 Create(X509Certificate2 issuerCertificate, DateTimeOffset notBefore, DateTimeOffset notAfter, byte[] serialNumber) { }

	// RVA: 0x230E180 Offset: 0x230D380 VA: 0x18230E180
	public X509Certificate2 CreateSelfSigned(DateTimeOffset notBefore, DateTimeOffset notAfter) { }

	// RVA: 0x230E1C0 Offset: 0x230D3C0 VA: 0x18230E1C0
	public byte[] CreateSigningRequest() { }

	// RVA: 0x230E200 Offset: 0x230D400 VA: 0x18230E200
	public byte[] CreateSigningRequest(X509SignatureGenerator signatureGenerator) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public abstract class X509SignatureGenerator // TypeDefIndex: 5177
{
	// Properties
	public PublicKey PublicKey { get; }

	// Methods

	// RVA: 0x2321A20 Offset: 0x2320C20 VA: 0x182321A20
	protected void .ctor() { }

	// RVA: 0x2321A70 Offset: 0x2320C70 VA: 0x182321A70
	public PublicKey get_PublicKey() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract PublicKey BuildPublicKey();

	// RVA: 0x23219A0 Offset: 0x2320BA0 VA: 0x1823219A0
	public static X509SignatureGenerator CreateForECDsa(ECDsa key) { }

	// RVA: 0x23219E0 Offset: 0x2320BE0 VA: 0x1823219E0
	public static X509SignatureGenerator CreateForRSA(RSA key, RSASignaturePadding signaturePadding) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract byte[] GetSignatureAlgorithmIdentifier(HashAlgorithmName hashAlgorithm);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithm);
}

// Namespace: System.ComponentModel
[Usage(32767)]
public class DefaultValueAttribute : Attribute // TypeDefIndex: 5178
{
	// Fields
	private object _value; // 0x10
	private static object s_convertFromInvariantString; // 0x0

	// Properties
	public virtual object Value { get; }

	// Methods

	// RVA: 0x2316F70 Offset: 0x2316170 VA: 0x182316F70
	public void .ctor(Type type, string value) { }

	// RVA: 0x2316D30 Offset: 0x2315F30 VA: 0x182316D30
	public void .ctor(char value) { }

	// RVA: 0x23173B0 Offset: 0x23165B0 VA: 0x1823173B0
	public void .ctor(byte value) { }

	// RVA: 0x2317410 Offset: 0x2316610 VA: 0x182317410
	public void .ctor(short value) { }

	// RVA: 0x23172F0 Offset: 0x23164F0 VA: 0x1823172F0
	public void .ctor(int value) { }

	// RVA: 0x2316E50 Offset: 0x2316050 VA: 0x182316E50
	public void .ctor(long value) { }

	// RVA: 0x2316DF0 Offset: 0x2315FF0 VA: 0x182316DF0
	public void .ctor(float value) { }

	// RVA: 0x2316D90 Offset: 0x2315F90 VA: 0x182316D90
	public void .ctor(double value) { }

	// RVA: 0x2316CD0 Offset: 0x2315ED0 VA: 0x182316CD0
	public void .ctor(bool value) { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string value) { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(object value) { }

	[CLSCompliant(False)]
	// RVA: 0x2316C70 Offset: 0x2315E70 VA: 0x182316C70
	public void .ctor(sbyte value) { }

	[CLSCompliant(False)]
	// RVA: 0x2317350 Offset: 0x2316550 VA: 0x182317350
	public void .ctor(ushort value) { }

	[CLSCompliant(False)]
	// RVA: 0x2316EB0 Offset: 0x23160B0 VA: 0x182316EB0
	public void .ctor(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x2316F10 Offset: 0x2316110 VA: 0x182316F10
	public void .ctor(ulong value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 7
	public virtual object get_Value() { }

	// RVA: 0x2316940 Offset: 0x2315B40 VA: 0x182316940 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	protected void SetValue(object value) { }

	[CompilerGenerated]
	// RVA: 0x2316A90 Offset: 0x2315C90 VA: 0x182316A90
	internal static bool <.ctor>g__TryConvertFromInvariantString|2_0(Type typeToConvert, string stringValue, out object conversionResult) { }
}

// Namespace: System.ComponentModel
[Usage(6140)]
public sealed class EditorBrowsableAttribute : Attribute // TypeDefIndex: 5179
{
	// Fields
	private EditorBrowsableState browsableState; // 0x10

	// Properties
	public EditorBrowsableState State { get; }

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	public void .ctor(EditorBrowsableState state) { }

	// RVA: 0x2318DF0 Offset: 0x2317FF0 VA: 0x182318DF0
	public void .ctor() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public EditorBrowsableState get_State() { }

	// RVA: 0x2318D70 Offset: 0x2317F70 VA: 0x182318D70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.ComponentModel
public enum EditorBrowsableState // TypeDefIndex: 5180
{
	// Fields
	public int value__; // 0x0
	public const EditorBrowsableState Always = 0;
	public const EditorBrowsableState Never = 1;
	public const EditorBrowsableState Advanced = 2;
}

// Namespace: System.ComponentModel
public sealed class AsyncOperation // TypeDefIndex: 5181
{
	// Fields
	private readonly SynchronizationContext _syncContext; // 0x10
	private readonly object _userSuppliedState; // 0x18
	private bool _alreadyCompleted; // 0x20

	// Properties
	public object UserSuppliedState { get; }
	public SynchronizationContext SynchronizationContext { get; }

	// Methods

	// RVA: 0x230AA80 Offset: 0x2309C80 VA: 0x18230AA80
	private void .ctor(object userSuppliedState, SynchronizationContext syncContext) { }

	// RVA: 0x230A4D0 Offset: 0x23096D0 VA: 0x18230A4D0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public object get_UserSuppliedState() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public SynchronizationContext get_SynchronizationContext() { }

	// RVA: 0x230A870 Offset: 0x2309A70 VA: 0x18230A870
	public void Post(SendOrPostCallback d, object arg) { }

	// RVA: 0x230A770 Offset: 0x2309970 VA: 0x18230A770
	public void PostOperationCompleted(SendOrPostCallback d, object arg) { }

	// RVA: 0x230A610 Offset: 0x2309810 VA: 0x18230A610
	public void OperationCompleted() { }

	// RVA: 0x230A680 Offset: 0x2309880 VA: 0x18230A680
	private void PostCore(SendOrPostCallback d, object arg, bool markCompleted) { }

	// RVA: 0x230A550 Offset: 0x2309750 VA: 0x18230A550
	private void OperationCompletedCore() { }

	// RVA: 0x230A9E0 Offset: 0x2309BE0 VA: 0x18230A9E0
	private void VerifyNotCompleted() { }

	// RVA: 0x230A960 Offset: 0x2309B60 VA: 0x18230A960
	private void VerifyDelegateNotNull(SendOrPostCallback d) { }

	// RVA: 0x230A440 Offset: 0x2309640 VA: 0x18230A440
	internal static AsyncOperation CreateOperation(object userSuppliedState, SynchronizationContext syncContext) { }

	// RVA: 0x230AA50 Offset: 0x2309C50 VA: 0x18230AA50
	internal void .ctor() { }
}

// Namespace: System.ComponentModel
public static class AsyncOperationManager // TypeDefIndex: 5182
{
	// Properties
	[EditorBrowsable(2)]
	public static SynchronizationContext SynchronizationContext { get; set; }

	// Methods

	// RVA: 0x230A2E0 Offset: 0x23094E0 VA: 0x18230A2E0
	public static AsyncOperation CreateOperation(object userSuppliedState) { }

	// RVA: 0x230A3C0 Offset: 0x23095C0 VA: 0x18230A3C0
	public static SynchronizationContext get_SynchronizationContext() { }

	// RVA: 0x230A430 Offset: 0x2309630 VA: 0x18230A430
	public static void set_SynchronizationContext(SynchronizationContext value) { }
}

// Namespace: System.ComponentModel
[DefaultEvent("DoWork")]
public class BackgroundWorker : Component // TypeDefIndex: 5183
{
	// Fields
	private bool _canCancelWorker; // 0x28
	private bool _workerReportsProgress; // 0x29
	private bool _cancellationPending; // 0x2A
	private bool _isRunning; // 0x2B
	private AsyncOperation _asyncOperation; // 0x30
	private readonly SendOrPostCallback _operationCompleted; // 0x38
	private readonly SendOrPostCallback _progressReporter; // 0x40
	[CompilerGenerated]
	private DoWorkEventHandler DoWork; // 0x48
	[CompilerGenerated]
	private ProgressChangedEventHandler ProgressChanged; // 0x50
	[CompilerGenerated]
	private RunWorkerCompletedEventHandler RunWorkerCompleted; // 0x58

	// Properties
	public bool CancellationPending { get; }
	public bool IsBusy { get; }
	public bool WorkerReportsProgress { get; set; }
	public bool WorkerSupportsCancellation { get; set; }

	// Methods

	// RVA: 0x230CAF0 Offset: 0x230BCF0 VA: 0x18230CAF0
	public void .ctor() { }

	// RVA: 0x230C1F0 Offset: 0x230B3F0 VA: 0x18230C1F0
	private void AsyncOperationCompleted(object arg) { }

	// RVA: 0x4C6AA0 Offset: 0x4C5CA0 VA: 0x1804C6AA0
	public bool get_CancellationPending() { }

	// RVA: 0x230C2A0 Offset: 0x230B4A0 VA: 0x18230C2A0
	public void CancelAsync() { }

	[CompilerGenerated]
	// RVA: 0x230CBC0 Offset: 0x230BDC0 VA: 0x18230CBC0
	public void add_DoWork(DoWorkEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x230CDA0 Offset: 0x230BFA0 VA: 0x18230CDA0
	public void remove_DoWork(DoWorkEventHandler value) { }

	// RVA: 0x4C6AC0 Offset: 0x4C5CC0 VA: 0x1804C6AC0
	public bool get_IsBusy() { }

	// RVA: 0x230C310 Offset: 0x230B510 VA: 0x18230C310 Slot: 16
	protected virtual void OnDoWork(DoWorkEventArgs e) { }

	// RVA: 0x1DDCC40 Offset: 0x1DDBE40 VA: 0x181DDCC40 Slot: 17
	protected virtual void OnRunWorkerCompleted(RunWorkerCompletedEventArgs e) { }

	// RVA: 0x230C330 Offset: 0x230B530 VA: 0x18230C330 Slot: 18
	protected virtual void OnProgressChanged(ProgressChangedEventArgs e) { }

	[CompilerGenerated]
	// RVA: 0x230CC60 Offset: 0x230BE60 VA: 0x18230CC60
	public void add_ProgressChanged(ProgressChangedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x230CE40 Offset: 0x230C040 VA: 0x18230CE40
	public void remove_ProgressChanged(ProgressChangedEventHandler value) { }

	// RVA: 0x230C350 Offset: 0x230B550 VA: 0x18230C350
	private void ProgressReporter(object arg) { }

	// RVA: 0x230C5D0 Offset: 0x230B7D0 VA: 0x18230C5D0
	public void ReportProgress(int percentProgress) { }

	// RVA: 0x230C3F0 Offset: 0x230B5F0 VA: 0x18230C3F0
	public void ReportProgress(int percentProgress, object userState) { }

	// RVA: 0x230C5E0 Offset: 0x230B7E0 VA: 0x18230C5E0
	public void RunWorkerAsync() { }

	// RVA: 0x230C5F0 Offset: 0x230B7F0 VA: 0x18230C5F0
	public void RunWorkerAsync(object argument) { }

	[CompilerGenerated]
	// RVA: 0x230CD00 Offset: 0x230BF00 VA: 0x18230CD00
	public void add_RunWorkerCompleted(RunWorkerCompletedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x230CEE0 Offset: 0x230C0E0 VA: 0x18230CEE0
	public void remove_RunWorkerCompleted(RunWorkerCompletedEventHandler value) { }

	// RVA: 0x4C6AB0 Offset: 0x4C5CB0 VA: 0x1804C6AB0
	public bool get_WorkerReportsProgress() { }

	// RVA: 0x4C6AE0 Offset: 0x4C5CE0 VA: 0x1804C6AE0
	public void set_WorkerReportsProgress(bool value) { }

	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_WorkerSupportsCancellation() { }

	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	public void set_WorkerSupportsCancellation(bool value) { }

	// RVA: 0x230C8D0 Offset: 0x230BAD0 VA: 0x18230C8D0
	private void WorkerThreadStart(object argument) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 14
	protected override void Dispose(bool disposing) { }

	[CompilerGenerated]
	// RVA: 0x230C8C0 Offset: 0x230BAC0 VA: 0x18230C8C0
	private void <RunWorkerAsync>b__27_0(object arg) { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class BrowsableAttribute : Attribute // TypeDefIndex: 5184
{
	// Fields
	public static readonly BrowsableAttribute Yes; // 0x0
	public static readonly BrowsableAttribute No; // 0x8
	public static readonly BrowsableAttribute Default; // 0x10
	[CompilerGenerated]
	private readonly bool <Browsable>k__BackingField; // 0x10

	// Properties
	public bool Browsable { get; }

	// Methods

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool browsable) { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_Browsable() { }

	// RVA: 0x230DD80 Offset: 0x230CF80 VA: 0x18230DD80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x230DE40 Offset: 0x230D040 VA: 0x18230DE40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x230DEA0 Offset: 0x230D0A0 VA: 0x18230DEA0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x230DF10 Offset: 0x230D110 VA: 0x18230DF10
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[DefaultMember("Item")]
public class ComponentCollection : ReadOnlyCollectionBase // TypeDefIndex: 5185
{
	// Properties
	public virtual IComponent Item { get; }
	public virtual IComponent Item { get; }

	// Methods

	// RVA: 0x22CF7B0 Offset: 0x22CE9B0 VA: 0x1822CF7B0
	public void .ctor(IComponent[] components) { }

	// RVA: 0x230EA90 Offset: 0x230DC90 VA: 0x18230EA90 Slot: 11
	public virtual IComponent get_Item(string name) { }

	// RVA: 0x230E9F0 Offset: 0x230DBF0 VA: 0x18230E9F0 Slot: 12
	public virtual IComponent get_Item(int index) { }

	// RVA: 0x22CF720 Offset: 0x22CE920 VA: 0x1822CF720
	public void CopyTo(IComponent[] array, int index) { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public class DescriptionAttribute : Attribute // TypeDefIndex: 5186
{
	// Fields
	public static readonly DescriptionAttribute Default; // 0x0
	[CompilerGenerated]
	private string <DescriptionValue>k__BackingField; // 0x10

	// Properties
	public virtual string Description { get; }
	protected string DescriptionValue { get; set; }

	// Methods

	// RVA: 0x2317BC0 Offset: 0x2316DC0 VA: 0x182317BC0
	public void .ctor() { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string description) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 7
	public virtual string get_Description() { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	protected string get_DescriptionValue() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	protected void set_DescriptionValue(string value) { }

	// RVA: 0x2317990 Offset: 0x2316B90 VA: 0x182317990 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2317A80 Offset: 0x2316C80 VA: 0x182317A80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2317AC0 Offset: 0x2316CC0 VA: 0x182317AC0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x2317B30 Offset: 0x2316D30 VA: 0x182317B30
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class DesignOnlyAttribute : Attribute // TypeDefIndex: 5187
{
	// Fields
	[CompilerGenerated]
	private readonly bool <IsDesignOnly>k__BackingField; // 0x10
	public static readonly DesignOnlyAttribute Yes; // 0x0
	public static readonly DesignOnlyAttribute No; // 0x8
	public static readonly DesignOnlyAttribute Default; // 0x10

	// Properties
	public bool IsDesignOnly { get; }

	// Methods

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool isDesignOnly) { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_IsDesignOnly() { }

	// RVA: 0x2317C20 Offset: 0x2316E20 VA: 0x182317C20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2317CE0 Offset: 0x2316EE0 VA: 0x182317CE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2317D40 Offset: 0x2316F40 VA: 0x182317D40 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x2317DB0 Offset: 0x2316FB0 VA: 0x182317DB0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(4, AllowMultiple = False, Inherited = True)]
public sealed class DesignerCategoryAttribute : Attribute // TypeDefIndex: 5188
{
	// Fields
	public static readonly DesignerCategoryAttribute Component; // 0x0
	public static readonly DesignerCategoryAttribute Default; // 0x8
	public static readonly DesignerCategoryAttribute Form; // 0x10
	public static readonly DesignerCategoryAttribute Generic; // 0x18
	[CompilerGenerated]
	private readonly string <Category>k__BackingField; // 0x10

	// Properties
	public string Category { get; }
	public override object TypeId { get; }

	// Methods

	// RVA: 0x23182E0 Offset: 0x23174E0 VA: 0x1823182E0
	public void .ctor() { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string category) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Category() { }

	// RVA: 0x2318080 Offset: 0x2317280 VA: 0x182318080 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x5BF760 Offset: 0x5BE960 VA: 0x1805BF760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2318100 Offset: 0x2317300 VA: 0x182318100 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x2318330 Offset: 0x2317530 VA: 0x182318330 Slot: 4
	public override object get_TypeId() { }

	// RVA: 0x2318180 Offset: 0x2317380 VA: 0x182318180
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public enum DesignerSerializationVisibility // TypeDefIndex: 5189
{
	// Fields
	public int value__; // 0x0
	public const DesignerSerializationVisibility Hidden = 0;
	public const DesignerSerializationVisibility Visible = 1;
	public const DesignerSerializationVisibility Content = 2;
}

// Namespace: System.ComponentModel
[Usage(960)]
public sealed class DesignerSerializationVisibilityAttribute : Attribute // TypeDefIndex: 5190
{
	// Fields
	public static readonly DesignerSerializationVisibilityAttribute Content; // 0x0
	public static readonly DesignerSerializationVisibilityAttribute Hidden; // 0x8
	public static readonly DesignerSerializationVisibilityAttribute Visible; // 0x10
	public static readonly DesignerSerializationVisibilityAttribute Default; // 0x18
	[CompilerGenerated]
	private readonly DesignerSerializationVisibility <Visibility>k__BackingField; // 0x10

	// Properties
	public DesignerSerializationVisibility Visibility { get; }

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	public void .ctor(DesignerSerializationVisibility visibility) { }

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public DesignerSerializationVisibility get_Visibility() { }

	// RVA: 0x2318380 Offset: 0x2317580 VA: 0x182318380 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2318440 Offset: 0x2317640 VA: 0x182318440 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x23184B0 Offset: 0x23176B0 VA: 0x1823184B0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(708)]
public class DisplayNameAttribute : Attribute // TypeDefIndex: 5191
{
	// Fields
	public static readonly DisplayNameAttribute Default; // 0x0
	[CompilerGenerated]
	private string <DisplayNameValue>k__BackingField; // 0x10

	// Properties
	public virtual string DisplayName { get; }
	protected string DisplayNameValue { get; set; }

	// Methods

	// RVA: 0x2318780 Offset: 0x2317980 VA: 0x182318780
	public void .ctor() { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string displayName) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 7
	public virtual string get_DisplayName() { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	protected string get_DisplayNameValue() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	protected void set_DisplayNameValue(string value) { }

	// RVA: 0x2318590 Offset: 0x2317790 VA: 0x182318590 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2317A80 Offset: 0x2316C80 VA: 0x182317A80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2318680 Offset: 0x2317880 VA: 0x182318680 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x23186F0 Offset: 0x23178F0 VA: 0x1823186F0
	private static void .cctor() { }
}

// Namespace: 
private sealed class EventHandlerList.ListEntry // TypeDefIndex: 5192
{
	// Fields
	internal EventHandlerList.ListEntry _next; // 0x10
	internal object _key; // 0x18
	internal Delegate _handler; // 0x20

	// Methods

	// RVA: 0x231C590 Offset: 0x231B790 VA: 0x18231C590
	public void .ctor(object key, Delegate handler, EventHandlerList.ListEntry next) { }
}

// Namespace: System.ComponentModel
[DefaultMember("Item")]
public sealed class EventHandlerList : IDisposable // TypeDefIndex: 5193
{
	// Fields
	private EventHandlerList.ListEntry _head; // 0x10
	private Component _parent; // 0x18

	// Properties
	public Delegate Item { get; set; }

	// Methods

	// RVA: 0x81DA00 Offset: 0x81CC00 VA: 0x18081DA00
	internal void .ctor(Component parent) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x231AAB0 Offset: 0x2319CB0 VA: 0x18231AAB0
	public Delegate get_Item(object key) { }

	// RVA: 0x231AB10 Offset: 0x2319D10 VA: 0x18231AB10
	public void set_Item(object key, Delegate value) { }

	// RVA: 0x231A8A0 Offset: 0x2319AA0 VA: 0x18231A8A0
	public void AddHandler(object key, Delegate value) { }

	// RVA: 0x231A960 Offset: 0x2319B60 VA: 0x18231A960
	public void AddHandlers(EventHandlerList listToAddFrom) { }

	// RVA: 0x832C50 Offset: 0x831E50 VA: 0x180832C50 Slot: 4
	public void Dispose() { }

	// RVA: 0x231AA50 Offset: 0x2319C50 VA: 0x18231AA50
	private EventHandlerList.ListEntry Find(object key) { }

	// RVA: 0x231AA70 Offset: 0x2319C70 VA: 0x18231AA70
	public void RemoveHandler(object key, Delegate value) { }
}

// Namespace: System.ComponentModel
public interface IContainer : IDisposable // TypeDefIndex: 5194
{
	// Properties
	public abstract ComponentCollection Components { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Add(IComponent component);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Add(IComponent component, string name);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ComponentCollection get_Components();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Remove(IComponent component);
}

// Namespace: System.ComponentModel
public interface ISite : IServiceProvider // TypeDefIndex: 5195
{
	// Properties
	public abstract IComponent Component { get; }
	public abstract IContainer Container { get; }
	public abstract bool DesignMode { get; }
	public abstract string Name { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IComponent get_Component();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IContainer get_Container();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_DesignMode();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void set_Name(string value);
}

// Namespace: System.ComponentModel
public interface ISupportInitialize // TypeDefIndex: 5196
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void BeginInit();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void EndInit();
}

// Namespace: System.ComponentModel
public interface ISynchronizeInvoke // TypeDefIndex: 5197
{
	// Properties
	public abstract bool InvokeRequired { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_InvokeRequired();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IAsyncResult BeginInvoke(Delegate method, object[] args);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object EndInvoke(IAsyncResult result);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract object Invoke(Delegate method, object[] args);
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class ImmutableObjectAttribute : Attribute // TypeDefIndex: 5198
{
	// Fields
	public static readonly ImmutableObjectAttribute Yes; // 0x0
	public static readonly ImmutableObjectAttribute No; // 0x8
	public static readonly ImmutableObjectAttribute Default; // 0x10
	[CompilerGenerated]
	private readonly bool <Immutable>k__BackingField; // 0x10

	// Properties
	public bool Immutable { get; }

	// Methods

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool immutable) { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_Immutable() { }

	// RVA: 0x231BC10 Offset: 0x231AE10 VA: 0x18231BC10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x231BCD0 Offset: 0x231AED0 VA: 0x18231BCD0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x231BD40 Offset: 0x231AF40 VA: 0x18231BD40
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(4)]
public sealed class InitializationEventAttribute : Attribute // TypeDefIndex: 5199
{
	// Fields
	[CompilerGenerated]
	private readonly string <EventName>k__BackingField; // 0x10

	// Properties
	public string EventName { get; }

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string eventName) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_EventName() { }
}

// Namespace: System.ComponentModel
[Serializable]
public class InvalidEnumArgumentException : ArgumentException // TypeDefIndex: 5200
{
	// Methods

	// RVA: 0x231C4A0 Offset: 0x231B6A0 VA: 0x18231C4A0
	public void .ctor() { }

	// RVA: 0x16CF0C0 Offset: 0x16CE2C0 VA: 0x1816CF0C0
	public void .ctor(string message) { }

	// RVA: 0x16CF0D0 Offset: 0x16CE2D0 VA: 0x1816CF0D0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x231C4B0 Offset: 0x231B6B0 VA: 0x18231C4B0
	public void .ctor(string argumentName, int invalidValue, Type enumClass) { }

	// RVA: 0x159BDB0 Offset: 0x159AFB0 VA: 0x18159BDB0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class LocalizableAttribute : Attribute // TypeDefIndex: 5201
{
	// Fields
	[CompilerGenerated]
	private readonly bool <IsLocalizable>k__BackingField; // 0x10
	public static readonly LocalizableAttribute Yes; // 0x0
	public static readonly LocalizableAttribute No; // 0x8
	public static readonly LocalizableAttribute Default; // 0x10

	// Properties
	public bool IsLocalizable { get; }

	// Methods

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool isLocalizable) { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_IsLocalizable() { }

	// RVA: 0x231C5E0 Offset: 0x231B7E0 VA: 0x18231C5E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x231C6A0 Offset: 0x231B8A0 VA: 0x18231C6A0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x231C710 Offset: 0x231B910 VA: 0x18231C710
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class MergablePropertyAttribute : Attribute // TypeDefIndex: 5202
{
	// Fields
	public static readonly MergablePropertyAttribute Yes; // 0x0
	public static readonly MergablePropertyAttribute No; // 0x8
	public static readonly MergablePropertyAttribute Default; // 0x10
	[CompilerGenerated]
	private readonly bool <AllowMerge>k__BackingField; // 0x10

	// Properties
	public bool AllowMerge { get; }

	// Methods

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool allowMerge) { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_AllowMerge() { }

	// RVA: 0x231C7B0 Offset: 0x231B9B0 VA: 0x18231C7B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x231C870 Offset: 0x231BA70 VA: 0x18231C870 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x231C8E0 Offset: 0x231BAE0 VA: 0x18231C8E0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class ReadOnlyAttribute : Attribute // TypeDefIndex: 5203
{
	// Fields
	public static readonly ReadOnlyAttribute Yes; // 0x0
	public static readonly ReadOnlyAttribute No; // 0x8
	public static readonly ReadOnlyAttribute Default; // 0x10
	[CompilerGenerated]
	private readonly bool <IsReadOnly>k__BackingField; // 0x10

	// Properties
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool isReadOnly) { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_IsReadOnly() { }

	// RVA: 0x231D930 Offset: 0x231CB30 VA: 0x18231D930 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x231D9F0 Offset: 0x231CBF0 VA: 0x18231D9F0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x231DA60 Offset: 0x231CC60 VA: 0x18231DA60
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public class AddingNewEventArgs : EventArgs // TypeDefIndex: 5204
{
	// Fields
	[CompilerGenerated]
	private object <NewObject>k__BackingField; // 0x10

	// Properties
	public object NewObject { get; set; }

	// Methods

	// RVA: 0x2309610 Offset: 0x2308810 VA: 0x182309610
	public void .ctor() { }

	// RVA: 0x23095B0 Offset: 0x23087B0 VA: 0x1823095B0
	public void .ctor(object newObject) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public object get_NewObject() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_NewObject(object value) { }
}

// Namespace: System.ComponentModel
public sealed class AddingNewEventHandler : MulticastDelegate // TypeDefIndex: 5205
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, AddingNewEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, AddingNewEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class AmbientValueAttribute : Attribute // TypeDefIndex: 5206
{
	// Fields
	[CompilerGenerated]
	private readonly object <Value>k__BackingField; // 0x10

	// Properties
	public object Value { get; }

	// Methods

	// RVA: 0x2309950 Offset: 0x2308B50 VA: 0x182309950
	public void .ctor(Type type, string value) { }

	// RVA: 0x2309890 Offset: 0x2308A90 VA: 0x182309890
	public void .ctor(char value) { }

	// RVA: 0x23099E0 Offset: 0x2308BE0 VA: 0x1823099E0
	public void .ctor(byte value) { }

	// RVA: 0x2309710 Offset: 0x2308910 VA: 0x182309710
	public void .ctor(short value) { }

	// RVA: 0x2309830 Offset: 0x2308A30 VA: 0x182309830
	public void .ctor(int value) { }

	// RVA: 0x23097D0 Offset: 0x23089D0 VA: 0x1823097D0
	public void .ctor(long value) { }

	// RVA: 0x23098F0 Offset: 0x2308AF0 VA: 0x1823098F0
	public void .ctor(float value) { }

	// RVA: 0x2309A40 Offset: 0x2308C40 VA: 0x182309A40
	public void .ctor(double value) { }

	// RVA: 0x2309770 Offset: 0x2308970 VA: 0x182309770
	public void .ctor(bool value) { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string value) { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(object value) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public object get_Value() { }

	// RVA: 0x2309660 Offset: 0x2308860 VA: 0x182309660 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
private class ArrayConverter.ArrayPropertyDescriptor : TypeConverter.SimplePropertyDescriptor // TypeDefIndex: 5207
{
	// Fields
	private readonly int _index; // 0x98

	// Methods

	// RVA: 0x230A160 Offset: 0x2309360 VA: 0x18230A160
	public void .ctor(Type arrayType, Type elementType, int index) { }

	// RVA: 0x2309F40 Offset: 0x2309140 VA: 0x182309F40 Slot: 26
	public override object GetValue(object instance) { }

	// RVA: 0x230A000 Offset: 0x2309200 VA: 0x18230A000 Slot: 30
	public override void SetValue(object instance, object value) { }
}

// Namespace: System.ComponentModel
public class ArrayConverter : CollectionConverter // TypeDefIndex: 5208
{
	// Methods

	// RVA: 0x2309AA0 Offset: 0x2308CA0 VA: 0x182309AA0 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x2309C80 Offset: 0x2308E80 VA: 0x182309C80 Slot: 10
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 11
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	public void .ctor() { }
}

// Namespace: 
private struct AttributeCollection.AttributeEntry // TypeDefIndex: 5209
{
	// Fields
	public Type type; // 0x0
	public int index; // 0x8
}

// Namespace: System.ComponentModel
[DefaultMember("Item")]
public class AttributeCollection : ICollection, IEnumerable // TypeDefIndex: 5210
{
	// Fields
	public static readonly AttributeCollection Empty; // 0x0
	private static Hashtable s_defaultAttributes; // 0x8
	private readonly Attribute[] _attributes; // 0x10
	private static readonly object s_internalSyncObject; // 0x10
	private const int FOUND_TYPES_LIMIT = 5;
	private AttributeCollection.AttributeEntry[] _foundAttributeTypes; // 0x18
	private int _index; // 0x20

	// Properties
	protected virtual Attribute[] Attributes { get; }
	public int Count { get; }
	public virtual Attribute Item { get; }
	public virtual Attribute Item { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }

	// Methods

	// RVA: 0x230B930 Offset: 0x230AB30 VA: 0x18230B930
	public void .ctor(Attribute[] attributes) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x230ACB0 Offset: 0x2309EB0 VA: 0x18230ACB0
	public static AttributeCollection FromExisting(AttributeCollection existing, Attribute[] newAttributes) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 9
	protected virtual Attribute[] get_Attributes() { }

	// RVA: 0x230B870 Offset: 0x230AA70 VA: 0x18230B870
	public int get_Count() { }

	// RVA: 0x230BA20 Offset: 0x230AC20 VA: 0x18230BA20 Slot: 10
	public virtual Attribute get_Item(int index) { }

	// RVA: 0x230BA60 Offset: 0x230AC60 VA: 0x18230BA60 Slot: 11
	public virtual Attribute get_Item(Type attributeType) { }

	// RVA: 0x230AAE0 Offset: 0x2309CE0 VA: 0x18230AAE0
	public bool Contains(Attribute attribute) { }

	// RVA: 0x230AB60 Offset: 0x2309D60 VA: 0x18230AB60
	public bool Contains(Attribute[] attributes) { }

	// RVA: 0x230B120 Offset: 0x230A320 VA: 0x18230B120
	protected Attribute GetDefaultAttribute(Type attributeType) { }

	// RVA: 0x230B660 Offset: 0x230A860 VA: 0x18230B660
	public IEnumerator GetEnumerator() { }

	// RVA: 0x230B690 Offset: 0x230A890 VA: 0x18230B690
	public bool Matches(Attribute attribute) { }

	// RVA: 0x230B770 Offset: 0x230A970 VA: 0x18230B770
	public bool Matches(Attribute[] attributes) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x230B870 Offset: 0x230AA70 VA: 0x18230B870 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x230B660 Offset: 0x230A860 VA: 0x18230B660 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x230AC20 Offset: 0x2309E20 VA: 0x18230AC20 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x230B8A0 Offset: 0x230AAA0 VA: 0x18230B8A0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(128)]
public class AttributeProviderAttribute : Attribute // TypeDefIndex: 5211
{
	// Fields
	[CompilerGenerated]
	private readonly string <TypeName>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <PropertyName>k__BackingField; // 0x18

	// Properties
	public string TypeName { get; }
	public string PropertyName { get; }

	// Methods

	// RVA: 0x230C170 Offset: 0x230B370 VA: 0x18230C170
	public void .ctor(string typeName) { }

	// RVA: 0x230BFB0 Offset: 0x230B1B0 VA: 0x18230BFB0
	public void .ctor(string typeName, string propertyName) { }

	// RVA: 0x230C090 Offset: 0x230B290 VA: 0x18230C090
	public void .ctor(Type type) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_TypeName() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_PropertyName() { }
}

// Namespace: System.ComponentModel
public abstract class ComponentEditor // TypeDefIndex: 5212
{
	// Methods

	// RVA: 0x20F0160 Offset: 0x20EF360 VA: 0x1820F0160
	public bool EditComponent(object component) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool EditComponent(ITypeDescriptorContext context, object component);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.ComponentModel
public abstract class BaseNumberConverter : TypeConverter // TypeDefIndex: 5213
{
	// Properties
	internal virtual bool AllowHex { get; }
	internal abstract Type TargetType { get; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	internal void .ctor() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 16
	internal virtual bool get_AllowHex() { }

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract Type get_TargetType();

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract object FromString(string value, int radix);

	// RVA: -1 Offset: -1 Slot: 19
	internal abstract object FromString(string value, NumberFormatInfo formatInfo);

	// RVA: -1 Offset: -1 Slot: 20
	internal abstract string ToString(object value, NumberFormatInfo formatInfo);

	// RVA: 0x230CF80 Offset: 0x230C180 VA: 0x18230CF80 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x230D070 Offset: 0x230C270 VA: 0x18230D070 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x230D3F0 Offset: 0x230C5F0 VA: 0x18230D3F0 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x230D030 Offset: 0x230C230 VA: 0x18230D030 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class BindableAttribute : Attribute // TypeDefIndex: 5214
{
	// Fields
	public static readonly BindableAttribute Yes; // 0x0
	public static readonly BindableAttribute No; // 0x8
	public static readonly BindableAttribute Default; // 0x10
	private bool _isDefault; // 0x10
	[CompilerGenerated]
	private readonly bool <Bindable>k__BackingField; // 0x11
	[CompilerGenerated]
	private readonly BindingDirection <Direction>k__BackingField; // 0x14

	// Properties
	public bool Bindable { get; }
	public BindingDirection Direction { get; }

	// Methods

	// RVA: 0x230D950 Offset: 0x230CB50 VA: 0x18230D950
	public void .ctor(bool bindable) { }

	// RVA: 0x230D8D0 Offset: 0x230CAD0 VA: 0x18230D8D0
	public void .ctor(bool bindable, BindingDirection direction) { }

	// RVA: 0x230D910 Offset: 0x230CB10 VA: 0x18230D910
	public void .ctor(BindableSupport flags) { }

	// RVA: 0x230D980 Offset: 0x230CB80 VA: 0x18230D980
	public void .ctor(BindableSupport flags, BindingDirection direction) { }

	[CompilerGenerated]
	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0
	public bool get_Bindable() { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public BindingDirection get_Direction() { }

	// RVA: 0x230D6A0 Offset: 0x230C8A0 VA: 0x18230D6A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x230D740 Offset: 0x230C940 VA: 0x18230D740 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x230D7A0 Offset: 0x230C9A0 VA: 0x18230D7A0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x230D820 Offset: 0x230CA20 VA: 0x18230D820
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public enum BindableSupport // TypeDefIndex: 5215
{
	// Fields
	public int value__; // 0x0
	public const BindableSupport No = 0;
	public const BindableSupport Yes = 1;
	public const BindableSupport Default = 2;
}

// Namespace: System.ComponentModel
public enum BindingDirection // TypeDefIndex: 5216
{
	// Fields
	public int value__; // 0x0
	public const BindingDirection OneWay = 0;
	public const BindingDirection TwoWay = 1;
}

// Namespace: System.ComponentModel
[Serializable]
public class BindingList<T> : Collection<T>, IBindingList, IList, ICollection, IEnumerable, ICancelAddNew, IRaiseItemChangedEvents // TypeDefIndex: 5217
{
	// Fields
	private int addNewPos; // 0x0
	private bool raiseListChangedEvents; // 0x0
	private bool raiseItemChangedEvents; // 0x0
	private PropertyDescriptorCollection _itemTypeProperties; // 0x0
	private PropertyChangedEventHandler _propertyChangedEventHandler; // 0x0
	private AddingNewEventHandler _onAddingNew; // 0x0
	private ListChangedEventHandler _onListChanged; // 0x0
	private int _lastChangeIndex; // 0x0
	private bool allowNew; // 0x0
	private bool allowEdit; // 0x0
	private bool allowRemove; // 0x0
	private bool userSetAllowNew; // 0x0

	// Properties
	private bool ItemTypeHasDefaultConstructor { get; }
	public bool RaiseListChangedEvents { get; set; }
	private bool AddingNewHandled { get; }
	public bool AllowNew { get; set; }
	private bool System.ComponentModel.IBindingList.AllowNew { get; }
	public bool AllowEdit { get; set; }
	private bool System.ComponentModel.IBindingList.AllowEdit { get; }
	public bool AllowRemove { get; set; }
	private bool System.ComponentModel.IBindingList.AllowRemove { get; }
	private bool System.ComponentModel.IBindingList.SupportsChangeNotification { get; }
	protected virtual bool SupportsChangeNotificationCore { get; }
	private bool System.ComponentModel.IBindingList.SupportsSearching { get; }
	protected virtual bool SupportsSearchingCore { get; }
	private bool System.ComponentModel.IBindingList.SupportsSorting { get; }
	protected virtual bool SupportsSortingCore { get; }
	private bool System.ComponentModel.IBindingList.IsSorted { get; }
	protected virtual bool IsSortedCore { get; }
	private PropertyDescriptor System.ComponentModel.IBindingList.SortProperty { get; }
	protected virtual PropertyDescriptor SortPropertyCore { get; }
	private ListSortDirection System.ComponentModel.IBindingList.SortDirection { get; }
	protected virtual ListSortDirection SortDirectionCore { get; }
	private bool System.ComponentModel.IRaiseItemChangedEvents.RaisesItemChangedEvents { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE60A0 Offset: 0xEE52A0 VA: 0x180EE60A0
	|-BindingList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE6030 Offset: 0xEE5230 VA: 0x180EE6030
	|-BindingList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE5320 Offset: 0xEE4520 VA: 0x180EE5320
	|-BindingList<__Il2CppFullySharedGenericType>.Initialize
	*/

	// RVA: -1 Offset: -1
	private bool get_ItemTypeHasDefaultConstructor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE6350 Offset: 0xEE5550 VA: 0x180EE6350
	|-BindingList<__Il2CppFullySharedGenericType>.get_ItemTypeHasDefaultConstructor
	*/

	// RVA: -1 Offset: -1
	public void add_AddingNew(AddingNewEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE6110 Offset: 0xEE5310 VA: 0x180EE6110
	|-BindingList<__Il2CppFullySharedGenericType>.add_AddingNew
	*/

	// RVA: -1 Offset: -1
	public void remove_AddingNew(AddingNewEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE64A0 Offset: 0xEE56A0 VA: 0x180EE64A0
	|-BindingList<__Il2CppFullySharedGenericType>.remove_AddingNew
	*/

	// RVA: -1 Offset: -1 Slot: 59
	protected virtual void OnAddingNew(AddingNewEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7ADB0 Offset: 0xB79FB0 VA: 0x180B7ADB0
	|-BindingList<__Il2CppFullySharedGenericType>.OnAddingNew
	*/

	// RVA: -1 Offset: -1
	private object FireAddingNew() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE50D0 Offset: 0xEE42D0 VA: 0x180EE50D0
	|-BindingList<__Il2CppFullySharedGenericType>.FireAddingNew
	*/

	// RVA: -1 Offset: -1 Slot: 49
	public void add_ListChanged(ListChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE6220 Offset: 0xEE5420 VA: 0x180EE6220
	|-BindingList<__Il2CppFullySharedGenericType>.add_ListChanged
	*/

	// RVA: -1 Offset: -1 Slot: 50
	public void remove_ListChanged(ListChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE65B0 Offset: 0xEE57B0 VA: 0x180EE65B0
	|-BindingList<__Il2CppFullySharedGenericType>.remove_ListChanged
	*/

	// RVA: -1 Offset: -1 Slot: 60
	protected virtual void OnListChanged(ListChangedEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE5880 Offset: 0xEE4A80 VA: 0x180EE5880
	|-BindingList<__Il2CppFullySharedGenericType>.OnListChanged
	*/

	// RVA: -1 Offset: -1
	public bool get_RaiseListChangedEvents() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x416930 Offset: 0x415B30 VA: 0x180416930
	|-BindingList<__Il2CppFullySharedGenericType>.get_RaiseListChangedEvents
	*/

	// RVA: -1 Offset: -1
	public void set_RaiseListChangedEvents(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x416950 Offset: 0x415B50 VA: 0x180416950
	|-BindingList<__Il2CppFullySharedGenericType>.set_RaiseListChangedEvents
	*/

	// RVA: -1 Offset: -1
	public void ResetBindings() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE5A40 Offset: 0xEE4C40 VA: 0x180EE5A40
	|-BindingList<__Il2CppFullySharedGenericType>.ResetBindings
	*/

	// RVA: -1 Offset: -1
	public void ResetItem(int position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE5A60 Offset: 0xEE4C60 VA: 0x180EE5A60
	|-BindingList<__Il2CppFullySharedGenericType>.ResetItem
	*/

	// RVA: -1 Offset: -1
	private void FireListChanged(ListChangedType type, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE5150 Offset: 0xEE4350 VA: 0x180EE5150
	|-BindingList<__Il2CppFullySharedGenericType>.FireListChanged
	*/

	// RVA: -1 Offset: -1 Slot: 35
	protected override void ClearItems() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE4D20 Offset: 0xEE3F20 VA: 0x180EE4D20
	|-BindingList<__Il2CppFullySharedGenericType>.ClearItems
	*/

	// RVA: -1 Offset: -1 Slot: 36
	protected override void InsertItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE56D0 Offset: 0xEE48D0 VA: 0x180EE56D0
	|-BindingList<__Il2CppFullySharedGenericType>.InsertItem
	*/

	// RVA: -1 Offset: -1 Slot: 37
	protected override void RemoveItem(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE58A0 Offset: 0xEE4AA0 VA: 0x180EE58A0
	|-BindingList<__Il2CppFullySharedGenericType>.RemoveItem
	*/

	// RVA: -1 Offset: -1 Slot: 38
	protected override void SetItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE5A80 Offset: 0xEE4C80 VA: 0x180EE5A80
	|-BindingList<__Il2CppFullySharedGenericType>.SetItem
	*/

	// RVA: -1 Offset: -1 Slot: 61
	public virtual void CancelNew(int itemIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE4780 Offset: 0xEE3980 VA: 0x180EE4780
	|-BindingList<__Il2CppFullySharedGenericType>.CancelNew
	*/

	// RVA: -1 Offset: -1 Slot: 62
	public virtual void EndNew(int itemIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE50B0 Offset: 0xEE42B0 VA: 0x180EE50B0
	|-BindingList<__Il2CppFullySharedGenericType>.EndNew
	*/

	// RVA: -1 Offset: -1
	public T AddNew() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE4690 Offset: 0xEE3890 VA: 0x180EE4690
	|-BindingList<__Il2CppFullySharedGenericType>.AddNew
	*/

	// RVA: -1 Offset: -1 Slot: 40
	private object System.ComponentModel.IBindingList.AddNew() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE5CC0 Offset: 0xEE4EC0 VA: 0x180EE5CC0
	|-BindingList<__Il2CppFullySharedGenericType>.System.ComponentModel.IBindingList.AddNew
	*/

	// RVA: -1 Offset: -1
	private bool get_AddingNewHandled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE62C0 Offset: 0xEE54C0 VA: 0x180EE62C0
	|-BindingList<__Il2CppFullySharedGenericType>.get_AddingNewHandled
	*/

	// RVA: -1 Offset: -1 Slot: 63
	protected virtual object AddNewCore() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE4520 Offset: 0xEE3720 VA: 0x180EE4520
	|-BindingList<__Il2CppFullySharedGenericType>.AddNewCore
	*/

	// RVA: -1 Offset: -1
	public bool get_AllowNew() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE6310 Offset: 0xEE5510 VA: 0x180EE6310
	|-BindingList<__Il2CppFullySharedGenericType>.get_AllowNew
	*/

	// RVA: -1 Offset: -1
	public void set_AllowNew(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE6680 Offset: 0xEE5880 VA: 0x180EE6680
	|-BindingList<__Il2CppFullySharedGenericType>.set_AllowNew
	*/

	// RVA: -1 Offset: -1 Slot: 39
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCB5D0 Offset: 0xBCA7D0 VA: 0x180BCB5D0
	|-BindingList<__Il2CppFullySharedGenericType>.System.ComponentModel.IBindingList.get_AllowNew
	*/

	// RVA: -1 Offset: -1
	public bool get_AllowEdit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE6300 Offset: 0xEE5500 VA: 0x180EE6300
	|-BindingList<__Il2CppFullySharedGenericType>.get_AllowEdit
	*/

	// RVA: -1 Offset: -1
	public void set_AllowEdit(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE6650 Offset: 0xEE5850 VA: 0x180EE6650
	|-BindingList<__Il2CppFullySharedGenericType>.set_AllowEdit
	*/

	// RVA: -1 Offset: -1 Slot: 41
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE5E50 Offset: 0xEE5050 VA: 0x180EE5E50
	|-BindingList<__Il2CppFullySharedGenericType>.System.ComponentModel.IBindingList.get_AllowEdit
	*/

	// RVA: -1 Offset: -1
	public bool get_AllowRemove() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE6340 Offset: 0xEE5540 VA: 0x180EE6340
	|-BindingList<__Il2CppFullySharedGenericType>.get_AllowRemove
	*/

	// RVA: -1 Offset: -1
	public void set_AllowRemove(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE66F0 Offset: 0xEE58F0 VA: 0x180EE66F0
	|-BindingList<__Il2CppFullySharedGenericType>.set_AllowRemove
	*/

	// RVA: -1 Offset: -1 Slot: 42
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCAE5D0 Offset: 0xCAD7D0 VA: 0x180CAE5D0
	|-BindingList<__Il2CppFullySharedGenericType>.System.ComponentModel.IBindingList.get_AllowRemove
	*/

	// RVA: -1 Offset: -1 Slot: 43
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE5ED0 Offset: 0xEE50D0 VA: 0x180EE5ED0
	|-BindingList<__Il2CppFullySharedGenericType>.System.ComponentModel.IBindingList.get_SupportsChangeNotification
	*/

	// RVA: -1 Offset: -1 Slot: 64
	protected virtual bool get_SupportsChangeNotificationCore() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-BindingList<__Il2CppFullySharedGenericType>.get_SupportsChangeNotificationCore
	*/

	// RVA: -1 Offset: -1 Slot: 44
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE5EF0 Offset: 0xEE50F0 VA: 0x180EE5EF0
	|-BindingList<__Il2CppFullySharedGenericType>.System.ComponentModel.IBindingList.get_SupportsSearching
	*/

	// RVA: -1 Offset: -1 Slot: 65
	protected virtual bool get_SupportsSearchingCore() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-BindingList<__Il2CppFullySharedGenericType>.get_SupportsSearchingCore
	*/

	// RVA: -1 Offset: -1 Slot: 45
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE5F10 Offset: 0xEE5110 VA: 0x180EE5F10
	|-BindingList<__Il2CppFullySharedGenericType>.System.ComponentModel.IBindingList.get_SupportsSorting
	*/

	// RVA: -1 Offset: -1 Slot: 66
	protected virtual bool get_SupportsSortingCore() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-BindingList<__Il2CppFullySharedGenericType>.get_SupportsSortingCore
	*/

	// RVA: -1 Offset: -1 Slot: 46
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE5E70 Offset: 0xEE5070 VA: 0x180EE5E70
	|-BindingList<__Il2CppFullySharedGenericType>.System.ComponentModel.IBindingList.get_IsSorted
	*/

	// RVA: -1 Offset: -1 Slot: 67
	protected virtual bool get_IsSortedCore() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-BindingList<__Il2CppFullySharedGenericType>.get_IsSortedCore
	*/

	// RVA: -1 Offset: -1 Slot: 47
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE5EB0 Offset: 0xEE50B0 VA: 0x180EE5EB0
	|-BindingList<__Il2CppFullySharedGenericType>.System.ComponentModel.IBindingList.get_SortProperty
	*/

	// RVA: -1 Offset: -1 Slot: 68
	protected virtual PropertyDescriptor get_SortPropertyCore() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	|-BindingList<__Il2CppFullySharedGenericType>.get_SortPropertyCore
	*/

	// RVA: -1 Offset: -1 Slot: 48
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE5E90 Offset: 0xEE5090 VA: 0x180EE5E90
	|-BindingList<__Il2CppFullySharedGenericType>.System.ComponentModel.IBindingList.get_SortDirection
	*/

	// RVA: -1 Offset: -1 Slot: 69
	protected virtual ListSortDirection get_SortDirectionCore() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	|-BindingList<__Il2CppFullySharedGenericType>.get_SortDirectionCore
	*/

	// RVA: -1 Offset: -1 Slot: 52
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor prop, ListSortDirection direction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE5DF0 Offset: 0xEE4FF0 VA: 0x180EE5DF0
	|-BindingList<__Il2CppFullySharedGenericType>.System.ComponentModel.IBindingList.ApplySort
	*/

	// RVA: -1 Offset: -1 Slot: 70
	protected virtual void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC74610 Offset: 0xC73810 VA: 0x180C74610
	|-BindingList<__Il2CppFullySharedGenericType>.ApplySortCore
	*/

	// RVA: -1 Offset: -1 Slot: 55
	private void System.ComponentModel.IBindingList.RemoveSort() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE5E30 Offset: 0xEE5030 VA: 0x180EE5E30
	|-BindingList<__Il2CppFullySharedGenericType>.System.ComponentModel.IBindingList.RemoveSort
	*/

	// RVA: -1 Offset: -1 Slot: 71
	protected virtual void RemoveSortCore() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-BindingList<__Il2CppFullySharedGenericType>.RemoveSortCore
	*/

	// RVA: -1 Offset: -1 Slot: 53
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor prop, object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE5E10 Offset: 0xEE5010 VA: 0x180EE5E10
	|-BindingList<__Il2CppFullySharedGenericType>.System.ComponentModel.IBindingList.Find
	*/

	// RVA: -1 Offset: -1 Slot: 72
	protected virtual int FindCore(PropertyDescriptor prop, object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC74610 Offset: 0xC73810 VA: 0x180C74610
	|-BindingList<__Il2CppFullySharedGenericType>.FindCore
	*/

	// RVA: -1 Offset: -1 Slot: 51
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor prop) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-BindingList<__Il2CppFullySharedGenericType>.System.ComponentModel.IBindingList.AddIndex
	*/

	// RVA: -1 Offset: -1 Slot: 54
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor prop) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-BindingList<__Il2CppFullySharedGenericType>.System.ComponentModel.IBindingList.RemoveIndex
	*/

	// RVA: -1 Offset: -1
	private void HookPropertyChanged(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE51E0 Offset: 0xEE43E0 VA: 0x180EE51E0
	|-BindingList<__Il2CppFullySharedGenericType>.HookPropertyChanged
	*/

	// RVA: -1 Offset: -1
	private void UnhookPropertyChanged(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE5F30 Offset: 0xEE5130 VA: 0x180EE5F30
	|-BindingList<__Il2CppFullySharedGenericType>.UnhookPropertyChanged
	*/

	// RVA: -1 Offset: -1
	private void Child_PropertyChanged(object sender, PropertyChangedEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE47C0 Offset: 0xEE39C0 VA: 0x180EE47C0
	|-BindingList<__Il2CppFullySharedGenericType>.Child_PropertyChanged
	*/

	// RVA: -1 Offset: -1 Slot: 58
	private bool System.ComponentModel.IRaiseItemChangedEvents.get_RaisesItemChangedEvents() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D0FF0 Offset: 0x7D01F0 VA: 0x1807D0FF0
	|-BindingList<__Il2CppFullySharedGenericType>.System.ComponentModel.IRaiseItemChangedEvents.get_RaisesItemChangedEvents
	*/
}

// Namespace: System.ComponentModel
public class BooleanConverter : TypeConverter // TypeDefIndex: 5218
{
	// Fields
	private static TypeConverter.StandardValuesCollection s_values; // 0x0

	// Methods

	// RVA: 0x230D9D0 Offset: 0x230CBD0 VA: 0x18230D9D0 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x230DA80 Offset: 0x230CC80 VA: 0x18230DA80 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x230DC00 Offset: 0x230CE00 VA: 0x18230DC00 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class ByteConverter : BaseNumberConverter // TypeDefIndex: 5219
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x230E120 Offset: 0x230D320 VA: 0x18230E120 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x230DFB0 Offset: 0x230D1B0 VA: 0x18230DFB0 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x230E030 Offset: 0x230D230 VA: 0x18230E030 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x230E090 Offset: 0x230D290 VA: 0x18230E090 Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public sealed class CancelEventHandler : MulticastDelegate // TypeDefIndex: 5220
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, CancelEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, CancelEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.ComponentModel
public class CharConverter : TypeConverter // TypeDefIndex: 5221
{
	// Methods

	// RVA: 0x230E550 Offset: 0x230D750 VA: 0x18230E550 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x230E760 Offset: 0x230D960 VA: 0x18230E760 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x230E600 Offset: 0x230D800 VA: 0x18230E600 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public enum CollectionChangeAction // TypeDefIndex: 5222
{
	// Fields
	public int value__; // 0x0
	public const CollectionChangeAction Add = 1;
	public const CollectionChangeAction Remove = 2;
	public const CollectionChangeAction Refresh = 3;
}

// Namespace: System.ComponentModel
public class CollectionChangeEventArgs : EventArgs // TypeDefIndex: 5223
{
	// Fields
	[CompilerGenerated]
	private readonly CollectionChangeAction <Action>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly object <Element>k__BackingField; // 0x18

	// Properties
	public virtual CollectionChangeAction Action { get; }
	public virtual object Element { get; }

	// Methods

	// RVA: 0x230E890 Offset: 0x230DA90 VA: 0x18230E890
	public void .ctor(CollectionChangeAction action, object element) { }

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 4
	public virtual CollectionChangeAction get_Action() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 5
	public virtual object get_Element() { }
}

// Namespace: System.ComponentModel
public sealed class CollectionChangeEventHandler : MulticastDelegate // TypeDefIndex: 5224
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, CollectionChangeEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.ComponentModel
[Usage(4)]
public sealed class ComplexBindingPropertiesAttribute : Attribute // TypeDefIndex: 5225
{
	// Fields
	[CompilerGenerated]
	private readonly string <DataSource>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <DataMember>k__BackingField; // 0x18
	public static readonly ComplexBindingPropertiesAttribute Default; // 0x0

	// Properties
	public string DataSource { get; }
	public string DataMember { get; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string dataSource) { }

	// RVA: 0x1675460 Offset: 0x1674660 VA: 0x181675460
	public void .ctor(string dataSource, string dataMember) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_DataSource() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_DataMember() { }

	// RVA: 0x230E900 Offset: 0x230DB00 VA: 0x18230E900 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x230E990 Offset: 0x230DB90 VA: 0x18230E990
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public class ComponentResourceManager : ResourceManager // TypeDefIndex: 5226
{
	// Fields
	private Hashtable _resourceSets; // 0x88
	private CultureInfo _neutralResourcesCulture; // 0x90

	// Properties
	private CultureInfo NeutralResourcesCulture { get; }

	// Methods

	// RVA: 0x230FB80 Offset: 0x230ED80 VA: 0x18230FB80
	public void .ctor() { }

	// RVA: 0x230FBD0 Offset: 0x230EDD0 VA: 0x18230FBD0
	public void .ctor(Type t) { }

	// RVA: 0x230FC30 Offset: 0x230EE30 VA: 0x18230FC30
	private CultureInfo get_NeutralResourcesCulture() { }

	// RVA: 0x230F670 Offset: 0x230E870 VA: 0x18230F670
	public void ApplyResources(object value, string objectName) { }

	// RVA: 0x230ECF0 Offset: 0x230DEF0 VA: 0x18230ECF0 Slot: 11
	public virtual void ApplyResources(object value, string objectName, CultureInfo culture) { }

	// RVA: 0x230F6A0 Offset: 0x230E8A0 VA: 0x18230F6A0
	private SortedList<string, object> FillResources(CultureInfo culture, out ResourceSet resourceSet) { }
}

// Namespace: System.ComponentModel
public abstract class ContainerFilterService // TypeDefIndex: 5227
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x70E580 Offset: 0x70D780 VA: 0x18070E580 Slot: 4
	public virtual ComponentCollection FilterComponents(ComponentCollection components) { }
}

// Namespace: 
private class CultureInfoConverter.CultureComparer : IComparer // TypeDefIndex: 5228
{
	// Fields
	private CultureInfoConverter _converter; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(CultureInfoConverter cultureConverter) { }

	// RVA: 0x230FCC0 Offset: 0x230EEC0 VA: 0x18230FCC0 Slot: 4
	public int Compare(object item1, object item2) { }
}

// Namespace: 
private static class CultureInfoConverter.CultureInfoMapper // TypeDefIndex: 5229
{
	// Fields
	private static readonly Dictionary<string, string> s_cultureInfoNameMap; // 0x0

	// Methods

	// RVA: 0x2310E80 Offset: 0x2310080 VA: 0x182310E80
	private static Dictionary<string, string> CreateMap() { }

	// RVA: 0x23147C0 Offset: 0x23139C0 VA: 0x1823147C0
	public static string GetCultureInfoName(string cultureInfoDisplayName) { }

	// RVA: 0x2314860 Offset: 0x2313A60 VA: 0x182314860
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public class CultureInfoConverter : TypeConverter // TypeDefIndex: 5230
{
	// Fields
	private TypeConverter.StandardValuesCollection _values; // 0x10
	private const string DefaultInvariantCultureString = "(Default)";

	// Properties
	private string DefaultCultureString { get; }

	// Methods

	// RVA: 0x2310E50 Offset: 0x2310050 VA: 0x182310E50
	private string get_DefaultCultureString() { }

	// RVA: 0xB080A0 Offset: 0xB072A0 VA: 0x180B080A0 Slot: 16
	protected virtual string GetCultureName(CultureInfo culture) { }

	// RVA: 0x230FEB0 Offset: 0x230F0B0 VA: 0x18230FEB0 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x230FF60 Offset: 0x230F160 VA: 0x18230FF60 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x2310010 Offset: 0x230F210 VA: 0x182310010 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x23107A0 Offset: 0x230F9A0 VA: 0x1823107A0 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x2310C80 Offset: 0x230FE80 VA: 0x182310C80 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public abstract class CustomTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 5231
{
	// Fields
	private readonly ICustomTypeDescriptor _parent; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	protected void .ctor(ICustomTypeDescriptor parent) { }

	// RVA: 0x23148A0 Offset: 0x2313AA0 VA: 0x1823148A0 Slot: 16
	public virtual AttributeCollection GetAttributes() { }

	// RVA: 0x23149A0 Offset: 0x2313BA0 VA: 0x1823149A0 Slot: 17
	public virtual string GetClassName() { }

	// RVA: 0x23149F0 Offset: 0x2313BF0 VA: 0x1823149F0 Slot: 18
	public virtual string GetComponentName() { }

	// RVA: 0x2314A40 Offset: 0x2313C40 VA: 0x182314A40 Slot: 19
	public virtual TypeConverter GetConverter() { }

	// RVA: 0x2314B40 Offset: 0x2313D40 VA: 0x182314B40 Slot: 20
	public virtual EventDescriptor GetDefaultEvent() { }

	// RVA: 0x2314C00 Offset: 0x2313E00 VA: 0x182314C00 Slot: 21
	public virtual PropertyDescriptor GetDefaultProperty() { }

	// RVA: 0x2314CC0 Offset: 0x2313EC0 VA: 0x182314CC0 Slot: 22
	public virtual object GetEditor(Type editorBaseType) { }

	// RVA: 0x2314D90 Offset: 0x2313F90 VA: 0x182314D90 Slot: 23
	public virtual EventDescriptorCollection GetEvents() { }

	// RVA: 0x2314E90 Offset: 0x2314090 VA: 0x182314E90 Slot: 24
	public virtual EventDescriptorCollection GetEvents(Attribute[] attributes) { }

	// RVA: 0x23150B0 Offset: 0x23142B0 VA: 0x1823150B0 Slot: 25
	public virtual PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x2314FA0 Offset: 0x23141A0 VA: 0x182314FA0 Slot: 26
	public virtual PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

	// RVA: 0x23151B0 Offset: 0x23143B0 VA: 0x1823151B0 Slot: 27
	public virtual object GetPropertyOwner(PropertyDescriptor pd) { }
}

// Namespace: System.ComponentModel
[Usage(4)]
public sealed class DataObjectAttribute : Attribute // TypeDefIndex: 5232
{
	// Fields
	public static readonly DataObjectAttribute DataObject; // 0x0
	public static readonly DataObjectAttribute NonDataObject; // 0x8
	public static readonly DataObjectAttribute Default; // 0x10
	[CompilerGenerated]
	private readonly bool <IsDataObject>k__BackingField; // 0x10

	// Properties
	public bool IsDataObject { get; }

	// Methods

	// RVA: 0x2315470 Offset: 0x2314670 VA: 0x182315470
	public void .ctor() { }

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool isDataObject) { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_IsDataObject() { }

	// RVA: 0x2315280 Offset: 0x2314480 VA: 0x182315280 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2315300 Offset: 0x2314500 VA: 0x182315300 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2315360 Offset: 0x2314560 VA: 0x182315360 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x23153D0 Offset: 0x23145D0 VA: 0x1823153D0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(128)]
public sealed class DataObjectFieldAttribute : Attribute // TypeDefIndex: 5233
{
	// Fields
	[CompilerGenerated]
	private readonly bool <IsIdentity>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly bool <IsNullable>k__BackingField; // 0x11
	[CompilerGenerated]
	private readonly int <Length>k__BackingField; // 0x14
	[CompilerGenerated]
	private readonly bool <PrimaryKey>k__BackingField; // 0x18

	// Properties
	public bool IsIdentity { get; }
	public bool IsNullable { get; }
	public int Length { get; }
	public bool PrimaryKey { get; }

	// Methods

	// RVA: 0x2315580 Offset: 0x2314780 VA: 0x182315580
	public void .ctor(bool primaryKey) { }

	// RVA: 0x2315530 Offset: 0x2314730 VA: 0x182315530
	public void .ctor(bool primaryKey, bool isIdentity) { }

	// RVA: 0x23155C0 Offset: 0x23147C0 VA: 0x1823155C0
	public void .ctor(bool primaryKey, bool isIdentity, bool isNullable) { }

	// RVA: 0x2315610 Offset: 0x2314810 VA: 0x182315610
	public void .ctor(bool primaryKey, bool isIdentity, bool isNullable, int length) { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_IsIdentity() { }

	[CompilerGenerated]
	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0
	public bool get_IsNullable() { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_Length() { }

	[CompilerGenerated]
	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_PrimaryKey() { }

	// RVA: 0x2315490 Offset: 0x2314690 VA: 0x182315490 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.ComponentModel
[Usage(64)]
public sealed class DataObjectMethodAttribute : Attribute // TypeDefIndex: 5234
{
	// Fields
	[CompilerGenerated]
	private readonly bool <IsDefault>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly DataObjectMethodType <MethodType>k__BackingField; // 0x14

	// Properties
	public bool IsDefault { get; }
	public DataObjectMethodType MethodType { get; }

	// Methods

	// RVA: 0x23157F0 Offset: 0x23149F0 VA: 0x1823157F0
	public void .ctor(DataObjectMethodType methodType) { }

	// RVA: 0x2315820 Offset: 0x2314A20 VA: 0x182315820
	public void .ctor(DataObjectMethodType methodType, bool isDefault) { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_IsDefault() { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public DataObjectMethodType get_MethodType() { }

	// RVA: 0x2315660 Offset: 0x2314860 VA: 0x182315660 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23156F0 Offset: 0x23148F0 VA: 0x1823156F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2315770 Offset: 0x2314970 VA: 0x182315770 Slot: 5
	public override bool Match(object obj) { }
}

// Namespace: System.ComponentModel
public enum DataObjectMethodType // TypeDefIndex: 5235
{
	// Fields
	public int value__; // 0x0
	public const DataObjectMethodType Fill = 0;
	public const DataObjectMethodType Select = 1;
	public const DataObjectMethodType Update = 2;
	public const DataObjectMethodType Insert = 3;
	public const DataObjectMethodType Delete = 4;
}

// Namespace: System.ComponentModel
public class DateTimeConverter : TypeConverter // TypeDefIndex: 5236
{
	// Methods

	// RVA: 0x2315860 Offset: 0x2314A60 VA: 0x182315860 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x2315910 Offset: 0x2314B10 VA: 0x182315910 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x23159C0 Offset: 0x2314BC0 VA: 0x1823159C0 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x2315C70 Offset: 0x2314E70 VA: 0x182315C70 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class DecimalConverter : BaseNumberConverter // TypeDefIndex: 5237
{
	// Properties
	internal override bool AllowHex { get; }
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 16
	internal override bool get_AllowHex() { }

	// RVA: 0x2316670 Offset: 0x2315870 VA: 0x182316670 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x2316070 Offset: 0x2315270 VA: 0x182316070 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x2316130 Offset: 0x2315330 VA: 0x182316130 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x2316510 Offset: 0x2315710 VA: 0x182316510 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x2316480 Offset: 0x2315680 VA: 0x182316480 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x23165C0 Offset: 0x23157C0 VA: 0x1823165C0 Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.ComponentModel
[Usage(4)]
public sealed class DefaultBindingPropertyAttribute : Attribute // TypeDefIndex: 5238
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x10
	public static readonly DefaultBindingPropertyAttribute Default; // 0x0

	// Properties
	public string Name { get; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string name) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	// RVA: 0x23166D0 Offset: 0x23158D0 VA: 0x1823166D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2316740 Offset: 0x2315940 VA: 0x182316740
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(4)]
public sealed class DefaultEventAttribute : Attribute // TypeDefIndex: 5239
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x10
	public static readonly DefaultEventAttribute Default; // 0x0

	// Properties
	public string Name { get; }

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string name) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	// RVA: 0x23167A0 Offset: 0x23159A0 VA: 0x1823167A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2316810 Offset: 0x2315A10 VA: 0x182316810
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(4)]
public sealed class DefaultPropertyAttribute : Attribute // TypeDefIndex: 5240
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x10
	public static readonly DefaultPropertyAttribute Default; // 0x0

	// Properties
	public string Name { get; }

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string name) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	// RVA: 0x2316870 Offset: 0x2315A70 VA: 0x182316870 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23168E0 Offset: 0x2315AE0 VA: 0x1823168E0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
internal sealed class DelegatingTypeDescriptionProvider : TypeDescriptionProvider // TypeDefIndex: 5241
{
	// Fields
	private readonly Type _type; // 0x20

	// Properties
	internal TypeDescriptionProvider Provider { get; }

	// Methods

	// RVA: 0x20DC9E0 Offset: 0x20DBBE0 VA: 0x1820DC9E0
	internal void .ctor(Type type) { }

	// RVA: 0x2317940 Offset: 0x2316B40 VA: 0x182317940
	internal TypeDescriptionProvider get_Provider() { }

	// RVA: 0x2317470 Offset: 0x2316670 VA: 0x182317470 Slot: 4
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x2317520 Offset: 0x2316720 VA: 0x182317520 Slot: 5
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x23176A0 Offset: 0x23168A0 VA: 0x1823176A0 Slot: 8
	public override string GetFullComponentName(object component) { }

	// RVA: 0x23175A0 Offset: 0x23167A0 VA: 0x1823175A0 Slot: 6
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x2317620 Offset: 0x2316820 VA: 0x182317620 Slot: 7
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x2317720 Offset: 0x2316920 VA: 0x182317720 Slot: 9
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x23177B0 Offset: 0x23169B0 VA: 0x1823177B0 Slot: 10
	public override Type GetRuntimeType(Type objectType) { }

	// RVA: 0x2317830 Offset: 0x2316A30 VA: 0x182317830 Slot: 11
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x23178C0 Offset: 0x2316AC0 VA: 0x1823178C0 Slot: 12
	public override bool IsSupportedType(Type type) { }
}

// Namespace: System.ComponentModel
[Usage(896)]
public sealed class InheritanceAttribute : Attribute // TypeDefIndex: 5242
{
	// Fields
	public static readonly InheritanceAttribute Inherited; // 0x0
	public static readonly InheritanceAttribute InheritedReadOnly; // 0x8
	public static readonly InheritanceAttribute NotInherited; // 0x10
	public static readonly InheritanceAttribute Default; // 0x18
	[CompilerGenerated]
	private readonly InheritanceLevel <InheritanceLevel>k__BackingField; // 0x10

	// Properties
	public InheritanceLevel InheritanceLevel { get; }

	// Methods

	// RVA: 0x231C0B0 Offset: 0x231B2B0 VA: 0x18231C0B0
	public void .ctor() { }

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	public void .ctor(InheritanceLevel inheritanceLevel) { }

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public InheritanceLevel get_InheritanceLevel() { }

	// RVA: 0x231BDE0 Offset: 0x231AFE0 VA: 0x18231BDE0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x231BE80 Offset: 0x231B080 VA: 0x18231BE80 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x231BEF0 Offset: 0x231B0F0 VA: 0x18231BEF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x231BFD0 Offset: 0x231B1D0 VA: 0x18231BFD0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public enum InheritanceLevel // TypeDefIndex: 5243
{
	// Fields
	public int value__; // 0x0
	public const InheritanceLevel Inherited = 1;
	public const InheritanceLevel InheritedReadOnly = 2;
	public const InheritanceLevel NotInherited = 3;
}

// Namespace: System.ComponentModel
[Usage(32767)]
public class PropertyTabAttribute : Attribute // TypeDefIndex: 5244
{
	// Fields
	private Type[] _tabClasses; // 0x10
	private string[] _tabClassNames; // 0x18
	[CompilerGenerated]
	private PropertyTabScope[] <TabScopes>k__BackingField; // 0x20

	// Properties
	public Type[] TabClasses { get; }
	protected string[] TabClassNames { get; }
	public PropertyTabScope[] TabScopes { get; set; }

	// Methods

	// RVA: 0x231D020 Offset: 0x231C220 VA: 0x18231D020
	public void .ctor() { }

	// RVA: 0x231D450 Offset: 0x231C650 VA: 0x18231D450
	public void .ctor(Type tabClass) { }

	// RVA: 0x231D3A0 Offset: 0x231C5A0 VA: 0x18231D3A0
	public void .ctor(string tabClassName) { }

	// RVA: 0x231D230 Offset: 0x231C430 VA: 0x18231D230
	public void .ctor(Type tabClass, PropertyTabScope tabScope) { }

	// RVA: 0x231D0F0 Offset: 0x231C2F0 VA: 0x18231D0F0
	public void .ctor(string tabClassName, PropertyTabScope tabScope) { }

	// RVA: 0x231D5C0 Offset: 0x231C7C0 VA: 0x18231D5C0
	public Type[] get_TabClasses() { }

	// RVA: 0x231D530 Offset: 0x231C730 VA: 0x18231D530
	protected string[] get_TabClassNames() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public PropertyTabScope[] get_TabScopes() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	private void set_TabScopes(PropertyTabScope[] value) { }

	// RVA: 0x231C980 Offset: 0x231BB80 VA: 0x18231C980 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x231CA60 Offset: 0x231BC60 VA: 0x18231CA60
	public bool Equals(PropertyTabAttribute other) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x231D000 Offset: 0x231C200 VA: 0x18231D000
	protected void InitializeArrays(string[] tabClassNames, PropertyTabScope[] tabScopes) { }

	// RVA: 0x231CC20 Offset: 0x231BE20 VA: 0x18231CC20
	protected void InitializeArrays(Type[] tabClasses, PropertyTabScope[] tabScopes) { }

	// RVA: 0x231CC40 Offset: 0x231BE40 VA: 0x18231CC40
	private void InitializeArrays(string[] tabClassNames, Type[] tabClasses, PropertyTabScope[] tabScopes) { }
}

// Namespace: System.ComponentModel
public enum PropertyTabScope // TypeDefIndex: 5245
{
	// Fields
	public int value__; // 0x0
	public const PropertyTabScope Static = 0;
	public const PropertyTabScope Global = 1;
	public const PropertyTabScope Document = 2;
	public const PropertyTabScope Component = 3;
}

// Namespace: System.ComponentModel
[Usage(32767)]
public class ToolboxItemAttribute : Attribute // TypeDefIndex: 5246
{
	// Fields
	private Type _toolboxItemType; // 0x10
	private string _toolboxItemTypeName; // 0x18
	public static readonly ToolboxItemAttribute Default; // 0x0
	public static readonly ToolboxItemAttribute None; // 0x8

	// Properties
	public Type ToolboxItemType { get; }
	public string ToolboxItemTypeName { get; }

	// Methods

	// RVA: 0x231DC70 Offset: 0x231CE70 VA: 0x18231DC70 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x231DE70 Offset: 0x231D070 VA: 0x18231DE70
	public void .ctor(bool defaultType) { }

	// RVA: 0x231DDF0 Offset: 0x231CFF0 VA: 0x18231DDF0
	public void .ctor(string toolboxItemTypeName) { }

	// RVA: 0x231DED0 Offset: 0x231D0D0 VA: 0x18231DED0
	public void .ctor(Type toolboxItemType) { }

	// RVA: 0x231DF70 Offset: 0x231D170 VA: 0x18231DF70
	public Type get_ToolboxItemType() { }

	// RVA: 0x231DF20 Offset: 0x231D120 VA: 0x18231DF20
	public string get_ToolboxItemTypeName() { }

	// RVA: 0x231DB00 Offset: 0x231CD00 VA: 0x18231DB00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x231DC30 Offset: 0x231CE30 VA: 0x18231DC30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x231DCE0 Offset: 0x231CEE0 VA: 0x18231DCE0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(1028)]
public sealed class DesignTimeVisibleAttribute : Attribute // TypeDefIndex: 5247
{
	// Fields
	[CompilerGenerated]
	private readonly bool <Visible>k__BackingField; // 0x10
	public static readonly DesignTimeVisibleAttribute Yes; // 0x0
	public static readonly DesignTimeVisibleAttribute No; // 0x8
	public static readonly DesignTimeVisibleAttribute Default; // 0x10

	// Properties
	public bool Visible { get; }

	// Methods

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool visible) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_Visible() { }

	// RVA: 0x2317E50 Offset: 0x2317050 VA: 0x182317E50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2317ED0 Offset: 0x23170D0 VA: 0x182317ED0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2317F70 Offset: 0x2317170 VA: 0x182317F70 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x2317FE0 Offset: 0x23171E0 VA: 0x182317FE0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public class DoubleConverter : BaseNumberConverter // TypeDefIndex: 5248
{
	// Properties
	internal override bool AllowHex { get; }
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 16
	internal override bool get_AllowHex() { }

	// RVA: 0x23189A0 Offset: 0x2317BA0 VA: 0x1823189A0 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x23187E0 Offset: 0x23179E0 VA: 0x1823187E0 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x2318890 Offset: 0x2317A90 VA: 0x182318890 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x2318900 Offset: 0x2317B00 VA: 0x182318900 Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.ComponentModel
[Usage(32767, AllowMultiple = True, Inherited = True)]
public sealed class EditorAttribute : Attribute // TypeDefIndex: 5249
{
	// Fields
	private string _typeId; // 0x10
	[CompilerGenerated]
	private readonly string <EditorBaseTypeName>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <EditorTypeName>k__BackingField; // 0x20

	// Properties
	public string EditorBaseTypeName { get; }
	public string EditorTypeName { get; }
	public override object TypeId { get; }

	// Methods

	// RVA: 0x2318C70 Offset: 0x2317E70 VA: 0x182318C70
	public void .ctor() { }

	// RVA: 0x2318BE0 Offset: 0x2317DE0 VA: 0x182318BE0
	public void .ctor(string typeName, string baseTypeName) { }

	// RVA: 0x2318B30 Offset: 0x2317D30 VA: 0x182318B30
	public void .ctor(string typeName, Type baseType) { }

	// RVA: 0x2318AB0 Offset: 0x2317CB0 VA: 0x182318AB0
	public void .ctor(Type type, Type baseType) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_EditorBaseTypeName() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_EditorTypeName() { }

	// RVA: 0x2318CD0 Offset: 0x2317ED0 VA: 0x182318CD0 Slot: 4
	public override object get_TypeId() { }

	// RVA: 0x2318A00 Offset: 0x2317C00 VA: 0x182318A00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.ComponentModel
public abstract class EventDescriptor : MemberDescriptor // TypeDefIndex: 5250
{
	// Properties
	public abstract Type ComponentType { get; }
	public abstract Type EventType { get; }
	public abstract bool IsMulticast { get; }

	// Methods

	// RVA: 0x231A870 Offset: 0x2319A70 VA: 0x18231A870
	protected void .ctor(string name, Attribute[] attrs) { }

	// RVA: 0x231A890 Offset: 0x2319A90 VA: 0x18231A890
	protected void .ctor(MemberDescriptor descr) { }

	// RVA: 0x231A880 Offset: 0x2319A80 VA: 0x18231A880
	protected void .ctor(MemberDescriptor descr, Attribute[] attrs) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract Type get_ComponentType();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract Type get_EventType();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract bool get_IsMulticast();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void AddEventHandler(object component, Delegate value);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void RemoveEventHandler(object component, Delegate value);
}

// Namespace: 
private class EventDescriptorCollection.ArraySubsetEnumerator : IEnumerator // TypeDefIndex: 5251
{
	// Fields
	private readonly Array _array; // 0x10
	private readonly int _total; // 0x18
	private int _current; // 0x1C

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x230A230 Offset: 0x2309430 VA: 0x18230A230
	public void .ctor(Array array, int count) { }

	// RVA: 0x230A210 Offset: 0x2309410 VA: 0x18230A210 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x2174520 Offset: 0x2173720 VA: 0x182174520 Slot: 6
	public void Reset() { }

	// RVA: 0x230A270 Offset: 0x2309470 VA: 0x18230A270 Slot: 5
	public object get_Current() { }
}

// Namespace: System.ComponentModel
[DefaultMember("Item")]
public class EventDescriptorCollection : ICollection, IEnumerable, IList // TypeDefIndex: 5252
{
	// Fields
	private EventDescriptor[] _events; // 0x10
	private string[] _namedSort; // 0x18
	private readonly IComparer _comparer; // 0x20
	private bool _eventsOwned; // 0x28
	private bool _needSort; // 0x29
	private readonly bool _readOnly; // 0x2A
	public static readonly EventDescriptorCollection Empty; // 0x0
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x2C

	// Properties
	public int Count { get; set; }
	public virtual EventDescriptor Item { get; }
	public virtual EventDescriptor Item { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }

	// Methods

	// RVA: 0x231A550 Offset: 0x2319750 VA: 0x18231A550
	public void .ctor(EventDescriptor[] events) { }

	// RVA: 0x231A5D0 Offset: 0x23197D0 VA: 0x18231A5D0
	public void .ctor(EventDescriptor[] events, bool readOnly) { }

	// RVA: 0x231A650 Offset: 0x2319850 VA: 0x18231A650
	private void .ctor(EventDescriptor[] events, int eventCount, string[] namedSort, IComparer comparer) { }

	[CompilerGenerated]
	// RVA: 0x5012C0 Offset: 0x5004C0 VA: 0x1805012C0
	public int get_Count() { }

	[CompilerGenerated]
	// RVA: 0x5014F0 Offset: 0x5006F0 VA: 0x1805014F0
	private void set_Count(int value) { }

	// RVA: 0x231A760 Offset: 0x2319960 VA: 0x18231A760 Slot: 20
	public virtual EventDescriptor get_Item(int index) { }

	// RVA: 0x231A740 Offset: 0x2319940 VA: 0x18231A740 Slot: 21
	public virtual EventDescriptor get_Item(string name) { }

	// RVA: 0x2318E10 Offset: 0x2318010 VA: 0x182318E10
	public int Add(EventDescriptor value) { }

	// RVA: 0x2318EF0 Offset: 0x23180F0 VA: 0x182318EF0
	public void Clear() { }

	// RVA: 0x2318F50 Offset: 0x2318150 VA: 0x182318F50
	public bool Contains(EventDescriptor value) { }

	// RVA: 0x2319C70 Offset: 0x2318E70 VA: 0x182319C70 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x2318FB0 Offset: 0x23181B0 VA: 0x182318FB0
	private void EnsureEventsOwned() { }

	// RVA: 0x2319050 Offset: 0x2318250 VA: 0x182319050
	private void EnsureSize(int sizeNeeded) { }

	// RVA: 0x2319160 Offset: 0x2318360 VA: 0x182319160 Slot: 22
	public virtual EventDescriptor Find(string name, bool ignoreCase) { }

	// RVA: 0x2319340 Offset: 0x2318540 VA: 0x182319340
	public int IndexOf(EventDescriptor value) { }

	// RVA: 0x23193A0 Offset: 0x23185A0 VA: 0x1823193A0
	public void Insert(int index, EventDescriptor value) { }

	// RVA: 0x2319940 Offset: 0x2318B40 VA: 0x182319940
	public void Remove(EventDescriptor value) { }

	// RVA: 0x2319890 Offset: 0x2318A90 VA: 0x182319890
	public void RemoveAt(int index) { }

	// RVA: 0x23192A0 Offset: 0x23184A0 VA: 0x1823192A0
	public IEnumerator GetEnumerator() { }

	// RVA: 0x2319A90 Offset: 0x2318C90 VA: 0x182319A90 Slot: 23
	public virtual EventDescriptorCollection Sort() { }

	// RVA: 0x2319B30 Offset: 0x2318D30 VA: 0x182319B30 Slot: 24
	public virtual EventDescriptorCollection Sort(string[] names) { }

	// RVA: 0x23199F0 Offset: 0x2318BF0 VA: 0x1823199F0 Slot: 25
	public virtual EventDescriptorCollection Sort(string[] names, IComparer comparer) { }

	// RVA: 0x2319BD0 Offset: 0x2318DD0 VA: 0x182319BD0 Slot: 26
	public virtual EventDescriptorCollection Sort(IComparer comparer) { }

	// RVA: 0x2319520 Offset: 0x2318720 VA: 0x182319520
	protected void InternalSort(string[] names) { }

	// RVA: 0x23194A0 Offset: 0x23186A0 VA: 0x1823194A0
	protected void InternalSort(IComparer sorter) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x5012C0 Offset: 0x5004C0 VA: 0x1805012C0 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x2319CC0 Offset: 0x2318EC0 VA: 0x182319CC0 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x188A050 Offset: 0x1889250 VA: 0x18188A050 Slot: 9
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x231A2F0 Offset: 0x23194F0 VA: 0x18231A2F0 Slot: 10
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x2319D60 Offset: 0x2318F60 VA: 0x182319D60 Slot: 11
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x2319EB0 Offset: 0x23190B0 VA: 0x182319EB0 Slot: 12
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x2318EF0 Offset: 0x23180F0 VA: 0x182318EF0 Slot: 13
	private void System.Collections.IList.Clear() { }

	// RVA: 0x2319F80 Offset: 0x2319180 VA: 0x182319F80 Slot: 16
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x231A050 Offset: 0x2319250 VA: 0x18231A050 Slot: 17
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x231A1D0 Offset: 0x23193D0 VA: 0x18231A1D0 Slot: 18
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x231A1C0 Offset: 0x23193C0 VA: 0x18231A1C0 Slot: 19
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x4C6AA0 Offset: 0x4C5CA0 VA: 0x1804C6AA0 Slot: 14
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x4C6AA0 Offset: 0x4C5CA0 VA: 0x1804C6AA0 Slot: 15
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x231A4C0 Offset: 0x23196C0 VA: 0x18231A4C0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public class ExpandableObjectConverter : TypeConverter // TypeDefIndex: 5253
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x231ABD0 Offset: 0x2319DD0 VA: 0x18231ABD0 Slot: 10
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 11
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }
}

// Namespace: System.ComponentModel
internal sealed class ExtendedPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 5254
{
	// Fields
	private readonly ReflectPropertyDescriptor _extenderInfo; // 0x88
	private readonly IExtenderProvider _provider; // 0x90

	// Properties
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	public override string DisplayName { get; }

	// Methods

	// RVA: 0x231AE70 Offset: 0x231A070 VA: 0x18231AE70
	public void .ctor(ReflectPropertyDescriptor extenderInfo, Type receiverType, IExtenderProvider provider, Attribute[] attributes) { }

	// RVA: 0x231AD40 Offset: 0x2319F40 VA: 0x18231AD40
	public void .ctor(PropertyDescriptor extender, Attribute[] attributes) { }

	// RVA: 0x231AC30 Offset: 0x2319E30 VA: 0x18231AC30 Slot: 23
	public override bool CanResetValue(object comp) { }

	// RVA: 0x231B100 Offset: 0x231A300 VA: 0x18231B100 Slot: 17
	public override Type get_ComponentType() { }

	// RVA: 0x231B2E0 Offset: 0x231A4E0 VA: 0x18231B2E0 Slot: 20
	public override bool get_IsReadOnly() { }

	// RVA: 0x231B3E0 Offset: 0x231A5E0 VA: 0x18231B3E0 Slot: 21
	public override Type get_PropertyType() { }

	// RVA: 0x231B130 Offset: 0x231A330 VA: 0x18231B130 Slot: 13
	public override string get_DisplayName() { }

	// RVA: 0x231AC60 Offset: 0x2319E60 VA: 0x18231AC60 Slot: 26
	public override object GetValue(object comp) { }

	// RVA: 0x231AC90 Offset: 0x2319E90 VA: 0x18231AC90 Slot: 29
	public override void ResetValue(object comp) { }

	// RVA: 0x231ACD0 Offset: 0x2319ED0 VA: 0x18231ACD0 Slot: 30
	public override void SetValue(object component, object value) { }

	// RVA: 0x231AD10 Offset: 0x2319F10 VA: 0x18231AD10 Slot: 31
	public override bool ShouldSerializeValue(object comp) { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class ExtenderProvidedPropertyAttribute : Attribute // TypeDefIndex: 5255
{
	// Fields
	[CompilerGenerated]
	private PropertyDescriptor <ExtenderProperty>k__BackingField; // 0x10
	[CompilerGenerated]
	private IExtenderProvider <Provider>k__BackingField; // 0x18
	[CompilerGenerated]
	private Type <ReceiverType>k__BackingField; // 0x20

	// Properties
	public PropertyDescriptor ExtenderProperty { get; set; }
	public IExtenderProvider Provider { get; set; }
	public Type ReceiverType { get; set; }

	// Methods

	// RVA: 0x231B410 Offset: 0x231A610 VA: 0x18231B410
	internal static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public PropertyDescriptor get_ExtenderProperty() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_ExtenderProperty(PropertyDescriptor value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public IExtenderProvider get_Provider() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	private void set_Provider(IExtenderProvider value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Type get_ReceiverType() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	private void set_ReceiverType(Type value) { }

	// RVA: 0x231B4A0 Offset: 0x231A6A0 VA: 0x18231B4A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x231B5A0 Offset: 0x231A7A0 VA: 0x18231B5A0 Slot: 6
	public override bool IsDefaultAttribute() { }
}

// Namespace: System.ComponentModel
public class GuidConverter : TypeConverter // TypeDefIndex: 5256
{
	// Methods

	// RVA: 0x231B5F0 Offset: 0x231A7F0 VA: 0x18231B5F0 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x231B6A0 Offset: 0x231A8A0 VA: 0x18231B6A0 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x231B750 Offset: 0x231A950 VA: 0x18231B750 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x231B820 Offset: 0x231AA20 VA: 0x18231B820 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class HandledEventArgs : EventArgs // TypeDefIndex: 5257
{
	// Fields
	[CompilerGenerated]
	private bool <Handled>k__BackingField; // 0x10

	// Properties
	public bool Handled { get; set; }

	// Methods

	// RVA: 0x231BBC0 Offset: 0x231ADC0 VA: 0x18231BBC0
	public void .ctor() { }

	// RVA: 0x231BB60 Offset: 0x231AD60 VA: 0x18231BB60
	public void .ctor(bool defaultHandledValue) { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_Handled() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_Handled(bool value) { }
}

// Namespace: System.ComponentModel
public sealed class HandledEventHandler : MulticastDelegate // TypeDefIndex: 5258
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, HandledEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, HandledEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.ComponentModel
public interface IBindingList : IList, ICollection, IEnumerable // TypeDefIndex: 5259
{
	// Properties
	public abstract bool AllowNew { get; }
	public abstract bool AllowEdit { get; }
	public abstract bool AllowRemove { get; }
	public abstract bool SupportsChangeNotification { get; }
	public abstract bool SupportsSearching { get; }
	public abstract bool SupportsSorting { get; }
	public abstract bool IsSorted { get; }
	public abstract PropertyDescriptor SortProperty { get; }
	public abstract ListSortDirection SortDirection { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_AllowNew();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object AddNew();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_AllowEdit();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_AllowRemove();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_SupportsChangeNotification();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_SupportsSearching();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_SupportsSorting();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_IsSorted();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract PropertyDescriptor get_SortProperty();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract ListSortDirection get_SortDirection();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 10
	public abstract void add_ListChanged(ListChangedEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 11
	public abstract void remove_ListChanged(ListChangedEventHandler value);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void AddIndex(PropertyDescriptor property);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void ApplySort(PropertyDescriptor property, ListSortDirection direction);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int Find(PropertyDescriptor property, object key);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void RemoveIndex(PropertyDescriptor property);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void RemoveSort();
}

// Namespace: System.ComponentModel
public interface IBindingListView : IBindingList, IList, ICollection, IEnumerable // TypeDefIndex: 5260
{
	// Properties
	public abstract string Filter { get; set; }
	public abstract ListSortDescriptionCollection SortDescriptions { get; }
	public abstract bool SupportsAdvancedSorting { get; }
	public abstract bool SupportsFiltering { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ApplySort(ListSortDescriptionCollection sorts);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Filter();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_Filter(string value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract ListSortDescriptionCollection get_SortDescriptions();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void RemoveFilter();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_SupportsAdvancedSorting();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_SupportsFiltering();
}

// Namespace: System.ComponentModel
public interface ICancelAddNew // TypeDefIndex: 5261
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CancelNew(int itemIndex);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void EndNew(int itemIndex);
}

// Namespace: System.ComponentModel
[Obsolete("This interface has been deprecated. Add a TypeDescriptionProvider to handle type TypeDescriptor.ComObjectType instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
public interface IComNativeDescriptorHandler // TypeDefIndex: 5262
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AttributeCollection GetAttributes(object component);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetClassName(object component);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract TypeConverter GetConverter(object component);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract EventDescriptor GetDefaultEvent(object component);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract PropertyDescriptor GetDefaultProperty(object component);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object GetEditor(object component, Type baseEditorType);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string GetName(object component);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract EventDescriptorCollection GetEvents(object component);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract EventDescriptorCollection GetEvents(object component, Attribute[] attributes);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract object GetPropertyValue(object component, string propertyName, ref bool success);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract object GetPropertyValue(object component, int dispid, ref bool success);
}

// Namespace: System.ComponentModel
public interface ICustomTypeDescriptor // TypeDefIndex: 5263
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AttributeCollection GetAttributes();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetClassName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string GetComponentName();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract TypeConverter GetConverter();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract EventDescriptor GetDefaultEvent();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract PropertyDescriptor GetDefaultProperty();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object GetEditor(Type editorBaseType);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract EventDescriptorCollection GetEvents();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract EventDescriptorCollection GetEvents(Attribute[] attributes);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract PropertyDescriptorCollection GetProperties();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract PropertyDescriptorCollection GetProperties(Attribute[] attributes);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract object GetPropertyOwner(PropertyDescriptor pd);
}

// Namespace: System.ComponentModel
[DefaultMember("Item")]
public interface IDataErrorInfo // TypeDefIndex: 5264
{
	// Properties
	public abstract string Item { get; }
	public abstract string Error { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Item(string columnName);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Error();
}

// Namespace: System.ComponentModel
public interface IExtenderProvider // TypeDefIndex: 5265
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool CanExtend(object extendee);
}

// Namespace: System.ComponentModel
public interface IIntellisenseBuilder // TypeDefIndex: 5266
{
	// Properties
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool Show(string language, string value, ref string newValue);
}

// Namespace: System.ComponentModel
[MergableProperty(False)]
public interface IListSource // TypeDefIndex: 5267
{
	// Properties
	public abstract bool ContainsListCollection { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_ContainsListCollection();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IList GetList();
}

// Namespace: System.ComponentModel
public interface INestedContainer : IContainer, IDisposable // TypeDefIndex: 5268
{
	// Properties
	public abstract IComponent Owner { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IComponent get_Owner();
}

// Namespace: System.ComponentModel
public interface INestedSite : ISite, IServiceProvider // TypeDefIndex: 5269
{
	// Properties
	public abstract string FullName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_FullName();
}

// Namespace: System.ComponentModel
public interface IRaiseItemChangedEvents // TypeDefIndex: 5270
{
	// Properties
	public abstract bool RaisesItemChangedEvents { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_RaisesItemChangedEvents();
}

// Namespace: System.ComponentModel
public interface ISupportInitializeNotification : ISupportInitialize // TypeDefIndex: 5271
{
	// Properties
	public abstract bool IsInitialized { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsInitialized();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void add_Initialized(EventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void remove_Initialized(EventHandler value);
}

// Namespace: System.ComponentModel
public interface ITypeDescriptorContext : IServiceProvider // TypeDefIndex: 5272
{
	// Properties
	public abstract IContainer Container { get; }
	public abstract object Instance { get; }
	public abstract PropertyDescriptor PropertyDescriptor { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IContainer get_Container();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object get_Instance();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract PropertyDescriptor get_PropertyDescriptor();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool OnComponentChanging();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnComponentChanged();
}

// Namespace: System.ComponentModel
public interface ITypedList // TypeDefIndex: 5273
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string GetListName(PropertyDescriptor[] listAccessors);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors);
}

// Namespace: System.ComponentModel
[Usage(4)]
public class InstallerTypeAttribute : Attribute // TypeDefIndex: 5274
{
	// Fields
	private string _typeName; // 0x10

	// Properties
	public virtual Type InstallerType { get; }

	// Methods

	// RVA: 0x231C1D0 Offset: 0x231B3D0 VA: 0x18231C1D0
	public void .ctor(Type installerType) { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string typeName) { }

	// RVA: 0x231C220 Offset: 0x231B420 VA: 0x18231C220 Slot: 7
	public virtual Type get_InstallerType() { }

	// RVA: 0x231C120 Offset: 0x231B320 VA: 0x18231C120 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.ComponentModel
public abstract class InstanceCreationEditor // TypeDefIndex: 5275
{
	// Properties
	public virtual string Text { get; }

	// Methods

	// RVA: 0x231C2A0 Offset: 0x231B4A0 VA: 0x18231C2A0 Slot: 4
	public virtual string get_Text() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object CreateInstance(ITypeDescriptorContext context, Type instanceType);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.ComponentModel
public class Int16Converter : BaseNumberConverter // TypeDefIndex: 5276
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x231C440 Offset: 0x231B640 VA: 0x18231C440 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x231C330 Offset: 0x231B530 VA: 0x18231C330 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x231C2D0 Offset: 0x231B4D0 VA: 0x18231C2D0 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x231C3B0 Offset: 0x231B5B0 VA: 0x18231C3B0 Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class Int32Converter : BaseNumberConverter // TypeDefIndex: 5277
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x232A5D0 Offset: 0x23297D0 VA: 0x18232A5D0 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x232A460 Offset: 0x2329660 VA: 0x18232A460 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x232A4E0 Offset: 0x23296E0 VA: 0x18232A4E0 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x232A540 Offset: 0x2329740 VA: 0x18232A540 Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class Int64Converter : BaseNumberConverter // TypeDefIndex: 5278
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x232A7A0 Offset: 0x23299A0 VA: 0x18232A7A0 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x232A690 Offset: 0x2329890 VA: 0x18232A690 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x232A630 Offset: 0x2329830 VA: 0x18232A630 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x232A710 Offset: 0x2329910 VA: 0x18232A710 Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	public void .ctor() { }
}

// Namespace: System.ComponentModel
[Serializable]
public class InvalidAsynchronousStateException : ArgumentException // TypeDefIndex: 5279
{
	// Methods

	// RVA: 0x231C4A0 Offset: 0x231B6A0 VA: 0x18231C4A0
	public void .ctor() { }

	// RVA: 0x16CF0C0 Offset: 0x16CE2C0 VA: 0x1816CF0C0
	public void .ctor(string message) { }

	// RVA: 0x16CF0D0 Offset: 0x16CE2D0 VA: 0x1816CF0D0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x159BDB0 Offset: 0x159AFB0 VA: 0x18159BDB0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: 
private class LicFileLicenseProvider.LicFileLicense : License // TypeDefIndex: 5280
{
	// Fields
	private LicFileLicenseProvider _owner; // 0x10
	[CompilerGenerated]
	private readonly string <LicenseKey>k__BackingField; // 0x18

	// Properties
	public override string LicenseKey { get; }

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(LicFileLicenseProvider owner, string key) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 5
	public override string get_LicenseKey() { }

	// RVA: 0x232AD60 Offset: 0x2329F60 VA: 0x18232AD60 Slot: 6
	public override void Dispose() { }
}

// Namespace: System.ComponentModel
public class LicFileLicenseProvider : LicenseProvider // TypeDefIndex: 5281
{
	// Methods

	// RVA: 0x232AD10 Offset: 0x2329F10 VA: 0x18232AD10 Slot: 5
	protected virtual bool IsKeyValid(string key, Type type) { }

	// RVA: 0x232A800 Offset: 0x2329A00 VA: 0x18232A800 Slot: 6
	protected virtual string GetKey(Type type) { }

	// RVA: 0x232A8A0 Offset: 0x2329AA0 VA: 0x18232A8A0 Slot: 4
	public override License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public abstract class License : IDisposable // TypeDefIndex: 5282
{
	// Properties
	public abstract string LicenseKey { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_LicenseKey();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Dispose();

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.ComponentModel
public class LicenseContext : IServiceProvider // TypeDefIndex: 5283
{
	// Properties
	public virtual LicenseUsageMode UsageMode { get; }

	// Methods

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public virtual LicenseUsageMode get_UsageMode() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	public virtual string GetSavedLicenseKey(Type type, Assembly resourceAssembly) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 7
	public virtual object GetService(Type type) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	public virtual void SetSavedLicenseKey(Type type, string key) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public sealed class LicenseManager // TypeDefIndex: 5284
{
	// Fields
	private static readonly object s_selfLock; // 0x0
	private static LicenseContext s_context; // 0x8
	private static object s_contextLockHolder; // 0x10
	private static Hashtable s_providers; // 0x18
	private static Hashtable s_providerInstances; // 0x20
	private static readonly object s_internalSyncObject; // 0x28

	// Properties
	public static LicenseContext CurrentContext { get; set; }
	public static LicenseUsageMode UsageMode { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x232C2F0 Offset: 0x232B4F0 VA: 0x18232C2F0
	public static LicenseContext get_CurrentContext() { }

	// RVA: 0x232C570 Offset: 0x232B770 VA: 0x18232C570
	public static void set_CurrentContext(LicenseContext value) { }

	// RVA: 0x232C4B0 Offset: 0x232B6B0 VA: 0x18232C4B0
	public static LicenseUsageMode get_UsageMode() { }

	// RVA: 0x232ADB0 Offset: 0x2329FB0 VA: 0x18232ADB0
	private static void CacheProvider(Type type, LicenseProvider provider) { }

	// RVA: 0x232B1D0 Offset: 0x232A3D0 VA: 0x18232B1D0
	public static object CreateWithContext(Type type, LicenseContext creationContext) { }

	// RVA: 0x232AFB0 Offset: 0x232A1B0 VA: 0x18232AFB0
	public static object CreateWithContext(Type type, LicenseContext creationContext, object[] args) { }

	// RVA: 0x232B260 Offset: 0x232A460 VA: 0x18232B260
	private static bool GetCachedNoLicenseProvider(Type type) { }

	// RVA: 0x232B420 Offset: 0x232A620 VA: 0x18232B420
	private static LicenseProvider GetCachedProvider(Type type) { }

	// RVA: 0x232B330 Offset: 0x232A530 VA: 0x18232B330
	private static LicenseProvider GetCachedProviderInstance(Type providerType) { }

	// RVA: 0x232B510 Offset: 0x232A710 VA: 0x18232B510
	public static bool IsLicensed(Type type) { }

	// RVA: 0x232B670 Offset: 0x232A870 VA: 0x18232B670
	public static bool IsValid(Type type) { }

	// RVA: 0x232B5F0 Offset: 0x232A7F0 VA: 0x18232B5F0
	public static bool IsValid(Type type, object instance, out License license) { }

	// RVA: 0x232B750 Offset: 0x232A950 VA: 0x18232B750
	public static void LockContext(object contextUser) { }

	// RVA: 0x232B8B0 Offset: 0x232AAB0 VA: 0x18232B8B0
	public static void UnlockContext(object contextUser) { }

	// RVA: 0x232BF80 Offset: 0x232B180 VA: 0x18232BF80
	private static bool ValidateInternal(Type type, object instance, bool allowExceptions, out License license) { }

	// RVA: 0x232BA10 Offset: 0x232AC10 VA: 0x18232BA10
	private static bool ValidateInternalRecursive(LicenseContext context, Type type, object instance, bool allowExceptions, out License license, out string licenseKey) { }

	// RVA: 0x232C140 Offset: 0x232B340 VA: 0x18232C140
	public static void Validate(Type type) { }

	// RVA: 0x232C030 Offset: 0x232B230 VA: 0x18232C030
	public static License Validate(Type type, object instance) { }

	// RVA: 0x232C260 Offset: 0x232B460 VA: 0x18232C260
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public abstract class LicenseProvider // TypeDefIndex: 5285
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.ComponentModel
[Usage(4, AllowMultiple = False, Inherited = False)]
public sealed class LicenseProviderAttribute : Attribute // TypeDefIndex: 5286
{
	// Fields
	public static readonly LicenseProviderAttribute Default; // 0x0
	private Type _licenseProviderType; // 0x10
	private string _licenseProviderName; // 0x18

	// Properties
	public Type LicenseProvider { get; }
	public override object TypeId { get; }

	// Methods

	// RVA: 0x232C870 Offset: 0x232BA70 VA: 0x18232C870
	public void .ctor() { }

	// RVA: 0x159E350 Offset: 0x159D550 VA: 0x18159E350
	public void .ctor(string typeName) { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(Type type) { }

	// RVA: 0x232C890 Offset: 0x232BA90 VA: 0x18232C890
	public Type get_LicenseProvider() { }

	// RVA: 0x232C950 Offset: 0x232BB50 VA: 0x18232C950 Slot: 4
	public override object get_TypeId() { }

	// RVA: 0x232C6D0 Offset: 0x232B8D0 VA: 0x18232C6D0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x232C810 Offset: 0x232BA10 VA: 0x18232C810
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public enum LicenseUsageMode // TypeDefIndex: 5287
{
	// Fields
	public int value__; // 0x0
	public const LicenseUsageMode Runtime = 0;
	public const LicenseUsageMode Designtime = 1;
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class ListBindableAttribute : Attribute // TypeDefIndex: 5288
{
	// Fields
	public static readonly ListBindableAttribute Yes; // 0x0
	public static readonly ListBindableAttribute No; // 0x8
	public static readonly ListBindableAttribute Default; // 0x10
	private bool _isDefault; // 0x10
	[CompilerGenerated]
	private readonly bool <ListBindable>k__BackingField; // 0x11

	// Properties
	public bool ListBindable { get; }

	// Methods

	// RVA: 0x232CBC0 Offset: 0x232BDC0 VA: 0x18232CBC0
	public void .ctor(bool listBindable) { }

	// RVA: 0x232CBF0 Offset: 0x232BDF0 VA: 0x18232CBF0
	public void .ctor(BindableSupport flags) { }

	[CompilerGenerated]
	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0
	public bool get_ListBindable() { }

	// RVA: 0x232CA20 Offset: 0x232BC20 VA: 0x18232CA20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x232CAA0 Offset: 0x232BCA0 VA: 0x18232CAA0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x232CB20 Offset: 0x232BD20 VA: 0x18232CB20
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public class ListChangedEventArgs : EventArgs // TypeDefIndex: 5289
{
	// Fields
	[CompilerGenerated]
	private readonly ListChangedType <ListChangedType>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly int <NewIndex>k__BackingField; // 0x14
	[CompilerGenerated]
	private readonly int <OldIndex>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly PropertyDescriptor <PropertyDescriptor>k__BackingField; // 0x20

	// Properties
	public ListChangedType ListChangedType { get; }
	public int NewIndex { get; }
	public int OldIndex { get; }
	public PropertyDescriptor PropertyDescriptor { get; }

	// Methods

	// RVA: 0x232CD20 Offset: 0x232BF20 VA: 0x18232CD20
	public void .ctor(ListChangedType listChangedType, int newIndex) { }

	// RVA: 0x232CD90 Offset: 0x232BF90 VA: 0x18232CD90
	public void .ctor(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc) { }

	// RVA: 0x232CC30 Offset: 0x232BE30 VA: 0x18232CC30
	public void .ctor(ListChangedType listChangedType, PropertyDescriptor propDesc) { }

	// RVA: 0x232CCA0 Offset: 0x232BEA0 VA: 0x18232CCA0
	public void .ctor(ListChangedType listChangedType, int newIndex, int oldIndex) { }

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public ListChangedType get_ListChangedType() { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_NewIndex() { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_OldIndex() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public PropertyDescriptor get_PropertyDescriptor() { }
}

// Namespace: System.ComponentModel
public sealed class ListChangedEventHandler : MulticastDelegate // TypeDefIndex: 5290
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, ListChangedEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, ListChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.ComponentModel
public enum ListChangedType // TypeDefIndex: 5291
{
	// Fields
	public int value__; // 0x0
	public const ListChangedType Reset = 0;
	public const ListChangedType ItemAdded = 1;
	public const ListChangedType ItemDeleted = 2;
	public const ListChangedType ItemMoved = 3;
	public const ListChangedType ItemChanged = 4;
	public const ListChangedType PropertyDescriptorAdded = 5;
	public const ListChangedType PropertyDescriptorDeleted = 6;
	public const ListChangedType PropertyDescriptorChanged = 7;
}

// Namespace: System.ComponentModel
public class ListSortDescription // TypeDefIndex: 5292
{
	// Fields
	[CompilerGenerated]
	private PropertyDescriptor <PropertyDescriptor>k__BackingField; // 0x10
	[CompilerGenerated]
	private ListSortDirection <SortDirection>k__BackingField; // 0x18

	// Properties
	public PropertyDescriptor PropertyDescriptor { get; set; }
	public ListSortDirection SortDirection { get; set; }

	// Methods

	// RVA: 0xB16CA0 Offset: 0xB15EA0 VA: 0x180B16CA0
	public void .ctor(PropertyDescriptor property, ListSortDirection direction) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public PropertyDescriptor get_PropertyDescriptor() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_PropertyDescriptor(PropertyDescriptor value) { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public ListSortDirection get_SortDirection() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_SortDirection(ListSortDirection value) { }
}

// Namespace: System.ComponentModel
[DefaultMember("Item")]
public class ListSortDescriptionCollection : IList, ICollection, IEnumerable // TypeDefIndex: 5293
{
	// Fields
	private ArrayList _sorts; // 0x10

	// Properties
	public ListSortDescription Item { get; set; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }
	public int Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x232D2B0 Offset: 0x232C4B0 VA: 0x18232D2B0
	public void .ctor() { }

	// RVA: 0x232D1E0 Offset: 0x232C3E0 VA: 0x18232D1E0
	public void .ctor(ListSortDescription[] sorts) { }

	// RVA: 0x232D0D0 Offset: 0x232C2D0 VA: 0x18232D0D0
	public ListSortDescription get_Item(int index) { }

	// RVA: 0x232D310 Offset: 0x232C510 VA: 0x18232D310
	public void set_Item(int index, ListSortDescription value) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x232D0D0 Offset: 0x232C2D0 VA: 0x18232D0D0 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x232D190 Offset: 0x232C390 VA: 0x18232D190 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x232CF40 Offset: 0x232C140 VA: 0x18232CF40 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x232CF90 Offset: 0x232C190 VA: 0x18232CF90 Slot: 8
	private void System.Collections.IList.Clear() { }

	// RVA: 0x232CE10 Offset: 0x232C010 VA: 0x18232CE10 Slot: 7
	public bool Contains(object value) { }

	// RVA: 0x232CEE0 Offset: 0x232C0E0 VA: 0x18232CEE0 Slot: 11
	public int IndexOf(object value) { }

	// RVA: 0x232CFE0 Offset: 0x232C1E0 VA: 0x18232CFE0 Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x232D080 Offset: 0x232C280 VA: 0x18232D080 Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x232D030 Offset: 0x232C230 VA: 0x18232D030 Slot: 14
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x1719620 Offset: 0x1718820 VA: 0x181719620 Slot: 16
	public int get_Count() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 18
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 17
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1718DE0 Offset: 0x1717FE0 VA: 0x181718DE0 Slot: 15
	public void CopyTo(Array array, int index) { }

	// RVA: 0x154B250 Offset: 0x154A450 VA: 0x18154B250 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: System.ComponentModel
public enum ListSortDirection // TypeDefIndex: 5294
{
	// Fields
	public int value__; // 0x0
	public const ListSortDirection Ascending = 0;
	public const ListSortDirection Descending = 1;
}

// Namespace: System.ComponentModel
[Usage(4)]
public sealed class LookupBindingPropertiesAttribute : Attribute // TypeDefIndex: 5295
{
	// Fields
	[CompilerGenerated]
	private readonly string <DataSource>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <DisplayMember>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <ValueMember>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly string <LookupMember>k__BackingField; // 0x28
	public static readonly LookupBindingPropertiesAttribute Default; // 0x0

	// Properties
	public string DataSource { get; }
	public string DisplayMember { get; }
	public string ValueMember { get; }
	public string LookupMember { get; }

	// Methods

	// RVA: 0x232D490 Offset: 0x232C690 VA: 0x18232D490
	public void .ctor() { }

	// RVA: 0x232D4C0 Offset: 0x232C6C0 VA: 0x18232D4C0
	public void .ctor(string dataSource, string displayMember, string valueMember, string lookupMember) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_DataSource() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_DisplayMember() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_ValueMember() { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_LookupMember() { }

	// RVA: 0x232D360 Offset: 0x232C560 VA: 0x18232D360 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x232D420 Offset: 0x232C620 VA: 0x18232D420
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[DesignerCategory("Component")]
[TypeConverter(typeof(ComponentConverter))]
public class MarshalByValueComponent : IComponent, IDisposable, IServiceProvider // TypeDefIndex: 5296
{
	// Fields
	private static readonly object s_eventDisposed; // 0x0
	private ISite _site; // 0x10
	private EventHandlerList _events; // 0x18

	// Properties
	protected EventHandlerList Events { get; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public virtual ISite Site { get; set; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public virtual IContainer Container { get; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public virtual bool DesignMode { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x15F4E50 Offset: 0x15F4050 VA: 0x1815F4E50 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x232D920 Offset: 0x232CB20 VA: 0x18232D920 Slot: 6
	public void add_Disposed(EventHandler value) { }

	// RVA: 0x232DAF0 Offset: 0x232CCF0 VA: 0x18232DAF0 Slot: 7
	public void remove_Disposed(EventHandler value) { }

	// RVA: 0x232DA90 Offset: 0x232CC90 VA: 0x18232DA90
	protected EventHandlerList get_Events() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 10
	public virtual ISite get_Site() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0 Slot: 11
	public virtual void set_Site(ISite value) { }

	// RVA: 0x232D520 Offset: 0x232C720 VA: 0x18232D520 Slot: 8
	public void Dispose() { }

	// RVA: 0x232D590 Offset: 0x232C790 VA: 0x18232D590 Slot: 12
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x232D9F0 Offset: 0x232CBF0 VA: 0x18232D9F0 Slot: 13
	public virtual IContainer get_Container() { }

	// RVA: 0x232D770 Offset: 0x232C970 VA: 0x18232D770 Slot: 14
	public virtual object GetService(Type service) { }

	// RVA: 0x232DA40 Offset: 0x232CC40 VA: 0x18232DA40 Slot: 15
	public virtual bool get_DesignMode() { }

	// RVA: 0x232D7D0 Offset: 0x232C9D0 VA: 0x18232D7D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x232D8C0 Offset: 0x232CAC0 VA: 0x18232D8C0
	private static void .cctor() { }
}

// Namespace: 
private enum MaskedTextProvider.CaseConversion // TypeDefIndex: 5297
{
	// Fields
	public int value__; // 0x0
	public const MaskedTextProvider.CaseConversion None = 0;
	public const MaskedTextProvider.CaseConversion ToLower = 1;
	public const MaskedTextProvider.CaseConversion ToUpper = 2;
}

// Namespace: 
[Flags]
private enum MaskedTextProvider.CharType // TypeDefIndex: 5298
{
	// Fields
	public int value__; // 0x0
	public const MaskedTextProvider.CharType EditOptional = 1;
	public const MaskedTextProvider.CharType EditRequired = 2;
	public const MaskedTextProvider.CharType Separator = 4;
	public const MaskedTextProvider.CharType Literal = 8;
	public const MaskedTextProvider.CharType Modifier = 16;
}

// Namespace: 
private class MaskedTextProvider.CharDescriptor // TypeDefIndex: 5299
{
	// Fields
	public int MaskPosition; // 0x10
	public MaskedTextProvider.CaseConversion CaseConversion; // 0x14
	public MaskedTextProvider.CharType CharType; // 0x18
	public bool IsAssigned; // 0x1C

	// Methods

	// RVA: 0x2325870 Offset: 0x2324A70 VA: 0x182325870
	public void .ctor(int maskPos, MaskedTextProvider.CharType charType) { }

	// RVA: 0x2325640 Offset: 0x2324840 VA: 0x182325640 Slot: 3
	public override string ToString() { }
}

// Namespace: System.ComponentModel
[DefaultMember("Item")]
public class MaskedTextProvider : ICloneable // TypeDefIndex: 5300
{
	// Fields
	private const char SPACE_CHAR = '\x20';
	private const char DEFAULT_PROMPT_CHAR = '\x5f';
	private const char NULL_PASSWORD_CHAR = '\x0';
	private const bool DEFAULT_ALLOW_PROMPT = True;
	private const int INVALID_INDEX = -1;
	private const byte EDIT_ANY = 0;
	private const byte EDIT_UNASSIGNED = 1;
	private const byte EDIT_ASSIGNED = 2;
	private const bool FORWARD = True;
	private const bool BACKWARD = False;
	private static int s_ASCII_ONLY; // 0x0
	private static int s_ALLOW_PROMPT_AS_INPUT; // 0x4
	private static int s_INCLUDE_PROMPT; // 0x8
	private static int s_INCLUDE_LITERALS; // 0xC
	private static int s_RESET_ON_PROMPT; // 0x10
	private static int s_RESET_ON_LITERALS; // 0x14
	private static int s_SKIP_SPACE; // 0x18
	private static Type s_maskTextProviderType; // 0x20
	private BitVector32 _flagState; // 0x10
	private StringBuilder _testString; // 0x18
	private int _requiredCharCount; // 0x20
	private int _requiredEditChars; // 0x24
	private int _optionalEditChars; // 0x28
	private char _passwordChar; // 0x2C
	private char _promptChar; // 0x2E
	private List<MaskedTextProvider.CharDescriptor> _stringDescriptor; // 0x30
	[CompilerGenerated]
	private int <AssignedEditPositionCount>k__BackingField; // 0x38
	[CompilerGenerated]
	private readonly CultureInfo <Culture>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly string <Mask>k__BackingField; // 0x48

	// Properties
	public bool AllowPromptAsInput { get; }
	public int AssignedEditPositionCount { get; set; }
	public int AvailableEditPositionCount { get; }
	public CultureInfo Culture { get; }
	public static char DefaultPasswordChar { get; }
	public int EditPositionCount { get; }
	public IEnumerator EditPositions { get; }
	public bool IncludeLiterals { get; set; }
	public bool IncludePrompt { get; set; }
	public bool AsciiOnly { get; }
	public bool IsPassword { get; set; }
	public static int InvalidIndex { get; }
	public int LastAssignedPosition { get; }
	public int Length { get; }
	public string Mask { get; }
	public bool MaskCompleted { get; }
	public bool MaskFull { get; }
	public char PasswordChar { get; set; }
	public char PromptChar { get; set; }
	public bool ResetOnPrompt { get; set; }
	public bool ResetOnSpace { get; set; }
	public bool SkipLiterals { get; set; }
	public char Item { get; }

	// Methods

	// RVA: 0x23336C0 Offset: 0x23328C0 VA: 0x1823336C0
	public void .ctor(string mask) { }

	// RVA: 0x2333630 Offset: 0x2332830 VA: 0x182333630
	public void .ctor(string mask, bool restrictToAscii) { }

	// RVA: 0x23331B0 Offset: 0x23323B0 VA: 0x1823331B0
	public void .ctor(string mask, CultureInfo culture) { }

	// RVA: 0x23331E0 Offset: 0x23323E0 VA: 0x1823331E0
	public void .ctor(string mask, CultureInfo culture, bool restrictToAscii) { }

	// RVA: 0x2333660 Offset: 0x2332860 VA: 0x182333660
	public void .ctor(string mask, char passwordChar, bool allowPromptAsInput) { }

	// RVA: 0x2333690 Offset: 0x2332890 VA: 0x182333690
	public void .ctor(string mask, CultureInfo culture, char passwordChar, bool allowPromptAsInput) { }

	// RVA: 0x2333210 Offset: 0x2332410 VA: 0x182333210
	public void .ctor(string mask, CultureInfo culture, bool allowPromptAsInput, char promptChar, char passwordChar, bool restrictToAscii) { }

	// RVA: 0x232F2B0 Offset: 0x232E4B0 VA: 0x18232F2B0
	private void Initialize() { }

	// RVA: 0x23336F0 Offset: 0x23328F0 VA: 0x1823336F0
	public bool get_AllowPromptAsInput() { }

	[CompilerGenerated]
	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	public int get_AssignedEditPositionCount() { }

	[CompilerGenerated]
	// RVA: 0x423300 Offset: 0x422500 VA: 0x180423300
	private void set_AssignedEditPositionCount(int value) { }

	// RVA: 0x23337B0 Offset: 0x23329B0 VA: 0x1823337B0
	public int get_AvailableEditPositionCount() { }

	// RVA: 0x232E1B0 Offset: 0x232D3B0 VA: 0x18232E1B0 Slot: 4
	public object Clone() { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public CultureInfo get_Culture() { }

	// RVA: 0x197A4B0 Offset: 0x19796B0 VA: 0x18197A4B0
	public static char get_DefaultPasswordChar() { }

	// RVA: 0x23337C0 Offset: 0x23329C0 VA: 0x1823337C0
	public int get_EditPositionCount() { }

	// RVA: 0x23337D0 Offset: 0x23329D0 VA: 0x1823337D0
	public IEnumerator get_EditPositions() { }

	// RVA: 0x23339B0 Offset: 0x2332BB0 VA: 0x1823339B0
	public bool get_IncludeLiterals() { }

	// RVA: 0x2333D10 Offset: 0x2332F10 VA: 0x182333D10
	public void set_IncludeLiterals(bool value) { }

	// RVA: 0x2333A10 Offset: 0x2332C10 VA: 0x182333A10
	public bool get_IncludePrompt() { }

	// RVA: 0x2333D80 Offset: 0x2332F80 VA: 0x182333D80
	public void set_IncludePrompt(bool value) { }

	// RVA: 0x2333750 Offset: 0x2332950 VA: 0x182333750
	public bool get_AsciiOnly() { }

	// RVA: 0x2333A70 Offset: 0x2332C70 VA: 0x182333A70
	public bool get_IsPassword() { }

	// RVA: 0x2333DF0 Offset: 0x2332FF0 VA: 0x182333DF0
	public void set_IsPassword(bool value) { }

	// RVA: 0x729380 Offset: 0x728580 VA: 0x180729380
	public static int get_InvalidIndex() { }

	// RVA: 0x2333B50 Offset: 0x2332D50 VA: 0x182333B50
	public int get_LastAssignedPosition() { }

	// RVA: 0x2333BA0 Offset: 0x2332DA0 VA: 0x182333BA0
	public int get_Length() { }

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public string get_Mask() { }

	// RVA: 0x2333BC0 Offset: 0x2332DC0 VA: 0x182333BC0
	public bool get_MaskCompleted() { }

	// RVA: 0x2333BD0 Offset: 0x2332DD0 VA: 0x182333BD0
	public bool get_MaskFull() { }

	// RVA: 0x1B6EF90 Offset: 0x1B6E190 VA: 0x181B6EF90
	public char get_PasswordChar() { }

	// RVA: 0x2333E70 Offset: 0x2333070 VA: 0x182333E70
	public void set_PasswordChar(char value) { }

	// RVA: 0x2333BE0 Offset: 0x2332DE0 VA: 0x182333BE0
	public char get_PromptChar() { }

	// RVA: 0x2333FB0 Offset: 0x23331B0 VA: 0x182333FB0
	public void set_PromptChar(char value) { }

	// RVA: 0x2333BF0 Offset: 0x2332DF0 VA: 0x182333BF0
	public bool get_ResetOnPrompt() { }

	// RVA: 0x2334160 Offset: 0x2333360 VA: 0x182334160
	public void set_ResetOnPrompt(bool value) { }

	// RVA: 0x2333C50 Offset: 0x2332E50 VA: 0x182333C50
	public bool get_ResetOnSpace() { }

	// RVA: 0x23341D0 Offset: 0x23333D0 VA: 0x1823341D0
	public void set_ResetOnSpace(bool value) { }

	// RVA: 0x2333CB0 Offset: 0x2332EB0 VA: 0x182333CB0
	public bool get_SkipLiterals() { }

	// RVA: 0x2334240 Offset: 0x2333440 VA: 0x182334240
	public void set_SkipLiterals(bool value) { }

	// RVA: 0x2333A80 Offset: 0x2332C80 VA: 0x182333A80
	public char get_Item(int index) { }

	// RVA: 0x232DF70 Offset: 0x232D170 VA: 0x18232DF70
	public bool Add(char input) { }

	// RVA: 0x232DE10 Offset: 0x232D010 VA: 0x18232DE10
	public bool Add(char input, out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x232DCF0 Offset: 0x232CEF0 VA: 0x18232DCF0
	public bool Add(string input) { }

	// RVA: 0x232DBC0 Offset: 0x232CDC0 VA: 0x18232DBC0
	public bool Add(string input, out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x232E190 Offset: 0x232D390 VA: 0x18232E190
	public void Clear() { }

	// RVA: 0x232E090 Offset: 0x232D290 VA: 0x18232E090
	public void Clear(out MaskedTextResultHint resultHint) { }

	// RVA: 0x232EBD0 Offset: 0x232DDD0 VA: 0x18232EBD0
	public int FindAssignedEditPositionFrom(int position, bool direction) { }

	// RVA: 0x232EC50 Offset: 0x232DE50 VA: 0x18232EC50
	public int FindAssignedEditPositionInRange(int startPosition, int endPosition, bool direction) { }

	// RVA: 0x232ED50 Offset: 0x232DF50 VA: 0x18232ED50
	public int FindEditPositionFrom(int position, bool direction) { }

	// RVA: 0x232EDC0 Offset: 0x232DFC0 VA: 0x18232EDC0
	public int FindEditPositionInRange(int startPosition, int endPosition, bool direction) { }

	// RVA: 0x232EDE0 Offset: 0x232DFE0 VA: 0x18232EDE0
	private int FindEditPositionInRange(int startPosition, int endPosition, bool direction, byte assignedStatus) { }

	// RVA: 0x232EF10 Offset: 0x232E110 VA: 0x18232EF10
	public int FindNonEditPositionFrom(int position, bool direction) { }

	// RVA: 0x232EF80 Offset: 0x232E180 VA: 0x18232EF80
	public int FindNonEditPositionInRange(int startPosition, int endPosition, bool direction) { }

	// RVA: 0x232EFA0 Offset: 0x232E1A0 VA: 0x18232EFA0
	private int FindPositionInRange(int startPosition, int endPosition, bool direction, MaskedTextProvider.CharType charTypeFlags) { }

	// RVA: 0x232F090 Offset: 0x232E290 VA: 0x18232F090
	public int FindUnassignedEditPositionFrom(int position, bool direction) { }

	// RVA: 0x232F1B0 Offset: 0x232E3B0 VA: 0x18232F1B0
	public int FindUnassignedEditPositionInRange(int startPosition, int endPosition, bool direction) { }

	// RVA: 0x7B9D20 Offset: 0x7B8F20 VA: 0x1807B9D20
	public static bool GetOperationResultFromHint(MaskedTextResultHint hint) { }

	// RVA: 0x232FB40 Offset: 0x232ED40 VA: 0x18232FB40
	public bool InsertAt(char input, int position) { }

	// RVA: 0x232FC90 Offset: 0x232EE90 VA: 0x18232FC90
	public bool InsertAt(char input, int position, out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x232FEA0 Offset: 0x232F0A0 VA: 0x18232FEA0
	public bool InsertAt(string input, int position) { }

	// RVA: 0x232FDC0 Offset: 0x232EFC0 VA: 0x18232FDC0
	public bool InsertAt(string input, int position, out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x232F750 Offset: 0x232E950 VA: 0x18232F750
	private bool InsertAtInt(string input, int position, out int testPosition, out MaskedTextResultHint resultHint, bool testOnly) { }

	// RVA: 0x2330040 Offset: 0x232F240 VA: 0x182330040
	private static bool IsAscii(char c) { }

	// RVA: 0x232FF90 Offset: 0x232F190 VA: 0x18232FF90
	private static bool IsAciiAlphanumeric(char c) { }

	// RVA: 0x232FFC0 Offset: 0x232F1C0 VA: 0x18232FFC0
	private static bool IsAlphanumeric(char c) { }

	// RVA: 0x173C6A0 Offset: 0x173B8A0 VA: 0x18173C6A0
	private static bool IsAsciiLetter(char c) { }

	// RVA: 0x2330060 Offset: 0x232F260 VA: 0x182330060
	public bool IsAvailablePosition(int position) { }

	// RVA: 0x2330150 Offset: 0x232F350 VA: 0x182330150
	public bool IsEditPosition(int position) { }

	// RVA: 0x2330120 Offset: 0x232F320 VA: 0x182330120
	private static bool IsEditPosition(MaskedTextProvider.CharDescriptor charDescriptor) { }

	// RVA: 0x2330210 Offset: 0x232F410 VA: 0x182330210
	private static bool IsLiteralPosition(MaskedTextProvider.CharDescriptor charDescriptor) { }

	// RVA: 0x2330240 Offset: 0x232F440 VA: 0x182330240
	private static bool IsPrintableChar(char c) { }

	// RVA: 0x23302F0 Offset: 0x232F4F0 VA: 0x1823302F0
	public static bool IsValidInputChar(char c) { }

	// RVA: 0x2330340 Offset: 0x232F540 VA: 0x182330340
	public static bool IsValidMaskChar(char c) { }

	// RVA: 0x2330390 Offset: 0x232F590 VA: 0x182330390
	public static bool IsValidPasswordChar(char c) { }

	// RVA: 0x2330A10 Offset: 0x232FC10 VA: 0x182330A10
	public bool Remove() { }

	// RVA: 0x2330970 Offset: 0x232FB70 VA: 0x182330970
	public bool Remove(out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x2330850 Offset: 0x232FA50 VA: 0x182330850
	public bool RemoveAt(int position) { }

	// RVA: 0x23308D0 Offset: 0x232FAD0 VA: 0x1823308D0
	public bool RemoveAt(int startPosition, int endPosition) { }

	// RVA: 0x23307B0 Offset: 0x232F9B0 VA: 0x1823307B0
	public bool RemoveAt(int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x23303F0 Offset: 0x232F5F0 VA: 0x1823303F0
	private bool RemoveAtInt(int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint, bool testOnly) { }

	// RVA: 0x2331020 Offset: 0x2330220 VA: 0x182331020
	public bool Replace(char input, int position) { }

	// RVA: 0x2330E00 Offset: 0x2330000 VA: 0x182330E00
	public bool Replace(char input, int position, out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x2331210 Offset: 0x2330410 VA: 0x182331210
	public bool Replace(char input, int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x2330F30 Offset: 0x2330130 VA: 0x182330F30
	public bool Replace(string input, int position) { }

	// RVA: 0x2331120 Offset: 0x2330320 VA: 0x182331120
	public bool Replace(string input, int position, out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x2330A70 Offset: 0x232FC70 VA: 0x182330A70
	public bool Replace(string input, int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x2331390 Offset: 0x2330590 VA: 0x182331390
	private void ResetChar(int testPosition) { }

	// RVA: 0x2331440 Offset: 0x2330640 VA: 0x182331440
	private void ResetString(int startPosition, int endPosition) { }

	// RVA: 0x2331920 Offset: 0x2330B20 VA: 0x182331920
	public bool Set(string input) { }

	// RVA: 0x2331A80 Offset: 0x2330C80 VA: 0x182331A80
	public bool Set(string input, out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x2331790 Offset: 0x2330990 VA: 0x182331790
	private void SetChar(char input, int position) { }

	// RVA: 0x23315C0 Offset: 0x23307C0 VA: 0x1823315C0
	private void SetChar(char input, int position, MaskedTextProvider.CharDescriptor charDescriptor) { }

	// RVA: 0x2331810 Offset: 0x2330A10 VA: 0x182331810
	private void SetString(string input, int testPosition) { }

	// RVA: 0x2331BC0 Offset: 0x2330DC0 VA: 0x182331BC0
	private bool TestChar(char input, int position, out MaskedTextResultHint resultHint) { }

	// RVA: 0x2332280 Offset: 0x2331480 VA: 0x182332280
	private bool TestEscapeChar(char input, int position) { }

	// RVA: 0x23320C0 Offset: 0x23312C0 VA: 0x1823320C0
	private bool TestEscapeChar(char input, int position, MaskedTextProvider.CharDescriptor charDex) { }

	// RVA: 0x2332300 Offset: 0x2331500 VA: 0x182332300
	private bool TestSetChar(char input, int position, out MaskedTextResultHint resultHint) { }

	// RVA: 0x2332370 Offset: 0x2331570 VA: 0x182332370
	private bool TestSetString(string input, int position, out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x23323E0 Offset: 0x23315E0 VA: 0x1823323E0
	private bool TestString(string input, int position, out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x2332540 Offset: 0x2331740 VA: 0x182332540
	public string ToDisplayString() { }

	// RVA: 0x2332D40 Offset: 0x2331F40 VA: 0x182332D40 Slot: 3
	public override string ToString() { }

	// RVA: 0x2332710 Offset: 0x2331910 VA: 0x182332710
	public string ToString(bool ignorePasswordChar) { }

	// RVA: 0x2332820 Offset: 0x2331A20 VA: 0x182332820
	public string ToString(int startPosition, int length) { }

	// RVA: 0x2332C30 Offset: 0x2331E30 VA: 0x182332C30
	public string ToString(bool ignorePasswordChar, int startPosition, int length) { }

	// RVA: 0x2332E50 Offset: 0x2332050 VA: 0x182332E50
	public string ToString(bool includePrompt, bool includeLiterals) { }

	// RVA: 0x23326E0 Offset: 0x23318E0 VA: 0x1823326E0
	public string ToString(bool includePrompt, bool includeLiterals, int startPosition, int length) { }

	// RVA: 0x2332920 Offset: 0x2331B20 VA: 0x182332920
	public string ToString(bool ignorePasswordChar, bool includePrompt, bool includeLiterals, int startPosition, int length) { }

	// RVA: 0x2332EB0 Offset: 0x23320B0 VA: 0x182332EB0
	public bool VerifyChar(char input, int position, out MaskedTextResultHint hint) { }

	// RVA: 0x2332F30 Offset: 0x2332130 VA: 0x182332F30
	public bool VerifyEscapeChar(char input, int position) { }

	// RVA: 0x2332FE0 Offset: 0x23321E0 VA: 0x182332FE0
	public bool VerifyString(string input) { }

	// RVA: 0x2332FA0 Offset: 0x23321A0 VA: 0x182332FA0
	public bool VerifyString(string input, out int testPosition, out MaskedTextResultHint resultHint) { }

	// RVA: 0x2333020 Offset: 0x2332220 VA: 0x182333020
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public enum MaskedTextResultHint // TypeDefIndex: 5301
{
	// Fields
	public int value__; // 0x0
	public const MaskedTextResultHint Unknown = 0;
	public const MaskedTextResultHint CharacterEscaped = 1;
	public const MaskedTextResultHint NoEffect = 2;
	public const MaskedTextResultHint SideEffect = 3;
	public const MaskedTextResultHint Success = 4;
	public const MaskedTextResultHint AsciiCharacterExpected = -1;
	public const MaskedTextResultHint AlphanumericCharacterExpected = -2;
	public const MaskedTextResultHint DigitExpected = -3;
	public const MaskedTextResultHint LetterExpected = -4;
	public const MaskedTextResultHint SignedDigitExpected = -5;
	public const MaskedTextResultHint InvalidInput = -51;
	public const MaskedTextResultHint PromptCharNotAllowed = -52;
	public const MaskedTextResultHint UnavailableEditPosition = -53;
	public const MaskedTextResultHint NonEditPosition = -54;
	public const MaskedTextResultHint PositionOutOfRange = -55;
}

// Namespace: System.ComponentModel
public class MultilineStringConverter : TypeConverter // TypeDefIndex: 5302
{
	// Methods

	// RVA: 0x23342B0 Offset: 0x23334B0 VA: 0x1823342B0 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 10
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 11
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private class NestedContainer.Site : INestedSite, ISite, IServiceProvider // TypeDefIndex: 5303
{
	// Fields
	private string _name; // 0x10
	[CompilerGenerated]
	private readonly IComponent <Component>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly IContainer <Container>k__BackingField; // 0x20

	// Properties
	public IComponent Component { get; }
	public IContainer Container { get; }
	public bool DesignMode { get; }
	public string FullName { get; }
	public string Name { get; set; }

	// Methods

	// RVA: 0x233C400 Offset: 0x233B600 VA: 0x18233C400
	internal void .ctor(IComponent component, NestedContainer container, string name) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 5
	public IComponent get_Component() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 6
	public IContainer get_Container() { }

	// RVA: 0x233C1E0 Offset: 0x233B3E0 VA: 0x18233C1E0 Slot: 10
	public object GetService(Type service) { }

	// RVA: 0x233C450 Offset: 0x233B650 VA: 0x18233C450 Slot: 7
	public bool get_DesignMode() { }

	// RVA: 0x233C590 Offset: 0x233B790 VA: 0x18233C590 Slot: 4
	public string get_FullName() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 8
	public string get_Name() { }

	// RVA: 0x233C6F0 Offset: 0x233B8F0 VA: 0x18233C6F0 Slot: 9
	public void set_Name(string value) { }
}

// Namespace: System.ComponentModel
public class NestedContainer : Container, INestedContainer, IContainer, IDisposable // TypeDefIndex: 5304
{
	// Fields
	[CompilerGenerated]
	private readonly IComponent <Owner>k__BackingField; // 0x40

	// Properties
	public IComponent Owner { get; }
	protected virtual string OwnerName { get; }

	// Methods

	// RVA: 0x23346A0 Offset: 0x23338A0 VA: 0x1823346A0
	public void .ctor(IComponent owner) { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 17
	public IComponent get_Owner() { }

	// RVA: 0x23347D0 Offset: 0x23339D0 VA: 0x1823347D0 Slot: 18
	protected virtual string get_OwnerName() { }

	// RVA: 0x2334420 Offset: 0x2333620 VA: 0x182334420 Slot: 11
	protected override ISite CreateSite(IComponent component, string name) { }

	// RVA: 0x23344F0 Offset: 0x23336F0 VA: 0x1823344F0 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x23345B0 Offset: 0x23337B0 VA: 0x1823345B0 Slot: 13
	protected override object GetService(Type service) { }

	// RVA: 0x2326690 Offset: 0x2325890 VA: 0x182326690
	private void OnOwnerDisposed(object sender, EventArgs e) { }
}

// Namespace: System.ComponentModel
public class NullableConverter : TypeConverter // TypeDefIndex: 5305
{
	// Fields
	[CompilerGenerated]
	private readonly Type <NullableType>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Type <UnderlyingType>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly TypeConverter <UnderlyingTypeConverter>k__BackingField; // 0x20

	// Properties
	public Type NullableType { get; }
	public Type UnderlyingType { get; }
	public TypeConverter UnderlyingTypeConverter { get; }

	// Methods

	// RVA: 0x23351E0 Offset: 0x23343E0 VA: 0x1823351E0
	public void .ctor(Type type) { }

	// RVA: 0x23348B0 Offset: 0x2333AB0 VA: 0x1823348B0 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x2334A30 Offset: 0x2333C30 VA: 0x182334A30 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x2334970 Offset: 0x2333B70 VA: 0x182334970 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x2334B90 Offset: 0x2333D90 VA: 0x182334B90 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x2334D90 Offset: 0x2333F90 VA: 0x182334D90 Slot: 8
	public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	// RVA: 0x2334DD0 Offset: 0x2333FD0 VA: 0x182334DD0 Slot: 9
	public override bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	// RVA: 0x2334E50 Offset: 0x2334050 VA: 0x182334E50 Slot: 10
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x2334E10 Offset: 0x2334010 VA: 0x182334E10 Slot: 11
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x2334F20 Offset: 0x2334120 VA: 0x182334F20 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x2334EA0 Offset: 0x23340A0 VA: 0x182334EA0 Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x2334EE0 Offset: 0x23340E0 VA: 0x182334EE0 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x2335190 Offset: 0x2334390 VA: 0x182335190 Slot: 15
	public override bool IsValid(ITypeDescriptorContext context, object value) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Type get_NullableType() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Type get_UnderlyingType() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public TypeConverter get_UnderlyingTypeConverter() { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class PasswordPropertyTextAttribute : Attribute // TypeDefIndex: 5306
{
	// Fields
	public static readonly PasswordPropertyTextAttribute Yes; // 0x0
	public static readonly PasswordPropertyTextAttribute No; // 0x8
	public static readonly PasswordPropertyTextAttribute Default; // 0x10
	[CompilerGenerated]
	private readonly bool <Password>k__BackingField; // 0x10

	// Properties
	public bool Password { get; }

	// Methods

	// RVA: 0x18A4A80 Offset: 0x18A3C80 VA: 0x1818A4A80
	public void .ctor() { }

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool password) { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_Password() { }

	// RVA: 0x23352F0 Offset: 0x23344F0 VA: 0x1823352F0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2335380 Offset: 0x2334580 VA: 0x182335380 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x23353F0 Offset: 0x23345F0 VA: 0x1823353F0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public abstract class PropertyDescriptor : MemberDescriptor // TypeDefIndex: 5307
{
	// Fields
	private TypeConverter _converter; // 0x60
	private Hashtable _valueChangedHandlers; // 0x68
	private object[] _editors; // 0x70
	private Type[] _editorTypes; // 0x78
	private int _editorCount; // 0x80

	// Properties
	public abstract Type ComponentType { get; }
	public virtual TypeConverter Converter { get; }
	public virtual bool IsLocalizable { get; }
	public abstract bool IsReadOnly { get; }
	public DesignerSerializationVisibility SerializationVisibility { get; }
	public abstract Type PropertyType { get; }
	public virtual bool SupportsChangeEvents { get; }

	// Methods

	// RVA: 0x231A870 Offset: 0x2319A70 VA: 0x18231A870
	protected void .ctor(string name, Attribute[] attrs) { }

	// RVA: 0x231A890 Offset: 0x2319A90 VA: 0x18231A890
	protected void .ctor(MemberDescriptor descr) { }

	// RVA: 0x231A880 Offset: 0x2319A80 VA: 0x18231A880
	protected void .ctor(MemberDescriptor descr, Attribute[] attrs) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract Type get_ComponentType();

	// RVA: 0x2338DF0 Offset: 0x2337FF0 VA: 0x182338DF0 Slot: 18
	public virtual TypeConverter get_Converter() { }

	// RVA: 0x2339030 Offset: 0x2338230 VA: 0x182339030 Slot: 19
	public virtual bool get_IsLocalizable() { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool get_IsReadOnly();

	// RVA: 0x2339140 Offset: 0x2338340 VA: 0x182339140
	public DesignerSerializationVisibility get_SerializationVisibility() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract Type get_PropertyType();

	// RVA: 0x2337CD0 Offset: 0x2336ED0 VA: 0x182337CD0 Slot: 22
	public virtual void AddValueChanged(object component, EventHandler handler) { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract bool CanResetValue(object component);

	// RVA: 0x23380A0 Offset: 0x23372A0 VA: 0x1823380A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2337E80 Offset: 0x2337080 VA: 0x182337E80
	protected object CreateInstance(Type type) { }

	// RVA: 0x2338250 Offset: 0x2337450 VA: 0x182338250 Slot: 15
	protected override void FillAttributes(IList attributeList) { }

	// RVA: 0x2338350 Offset: 0x2337550 VA: 0x182338350
	public PropertyDescriptorCollection GetChildProperties() { }

	// RVA: 0x2338270 Offset: 0x2337470 VA: 0x182338270
	public PropertyDescriptorCollection GetChildProperties(Attribute[] filter) { }

	// RVA: 0x1A7A0D0 Offset: 0x1A792D0 VA: 0x181A7A0D0
	public PropertyDescriptorCollection GetChildProperties(object instance) { }

	// RVA: 0x2338290 Offset: 0x2337490 VA: 0x182338290 Slot: 24
	public virtual PropertyDescriptorCollection GetChildProperties(object instance, Attribute[] filter) { }

	// RVA: 0x2338370 Offset: 0x2337570 VA: 0x182338370 Slot: 25
	public virtual object GetEditor(Type editorBaseType) { }

	// RVA: 0x2338730 Offset: 0x2337930 VA: 0x182338730 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23387A0 Offset: 0x23379A0 VA: 0x1823387A0 Slot: 16
	protected override object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x23388A0 Offset: 0x2337AA0 VA: 0x1823388A0
	protected Type GetTypeFromName(string typeName) { }

	// RVA: -1 Offset: -1 Slot: 26
	public abstract object GetValue(object component);

	// RVA: 0x2338B80 Offset: 0x2337D80 VA: 0x182338B80 Slot: 27
	protected virtual void OnValueChanged(object component, EventArgs e) { }

	// RVA: 0x2338C30 Offset: 0x2337E30 VA: 0x182338C30 Slot: 28
	public virtual void RemoveValueChanged(object component, EventHandler handler) { }

	// RVA: 0x2338AF0 Offset: 0x2337CF0 VA: 0x182338AF0
	protected internal EventHandler GetValueChangedHandler(object component) { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void ResetValue(object component);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void SetValue(object component, object value);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract bool ShouldSerializeValue(object component);

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 32
	public virtual bool get_SupportsChangeEvents() { }
}

// Namespace: 
private class PropertyDescriptorCollection.PropertyDescriptorEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 5308
{
	// Fields
	private PropertyDescriptorCollection _owner; // 0x10
	private int _index; // 0x18

	// Properties
	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x1600D80 Offset: 0x15FFF80 VA: 0x181600D80
	public void .ctor(PropertyDescriptorCollection owner) { }

	// RVA: 0x2337B50 Offset: 0x2336D50 VA: 0x182337B50 Slot: 8
	public object get_Current() { }

	// RVA: 0x2337C00 Offset: 0x2336E00 VA: 0x182337C00 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x2337C80 Offset: 0x2336E80 VA: 0x182337C80 Slot: 4
	public object get_Key() { }

	// RVA: 0x2337C80 Offset: 0x2336E80 VA: 0x182337C80 Slot: 5
	public object get_Value() { }

	// RVA: 0x2337B20 Offset: 0x2336D20 VA: 0x182337B20 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x112DE90 Offset: 0x112D090 VA: 0x18112DE90 Slot: 9
	public void Reset() { }
}

// Namespace: System.ComponentModel
[DefaultMember("Item")]
public class PropertyDescriptorCollection : ICollection, IEnumerable, IList, IDictionary // TypeDefIndex: 5309
{
	// Fields
	public static readonly PropertyDescriptorCollection Empty; // 0x0
	private IDictionary _cachedFoundProperties; // 0x10
	private bool _cachedIgnoreCase; // 0x18
	private PropertyDescriptor[] _properties; // 0x20
	private readonly string[] _namedSort; // 0x28
	private readonly IComparer _comparer; // 0x30
	private bool _propsOwned; // 0x38
	private bool _needSort; // 0x39
	private bool _readOnly; // 0x3A
	private readonly object _internalSyncObject; // 0x40
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x48

	// Properties
	public int Count { get; set; }
	public virtual PropertyDescriptor Item { get; }
	public virtual PropertyDescriptor Item { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x23378A0 Offset: 0x2336AA0 VA: 0x1823378A0
	public void .ctor(PropertyDescriptor[] properties) { }

	// RVA: 0x2337940 Offset: 0x2336B40 VA: 0x182337940
	public void .ctor(PropertyDescriptor[] properties, bool readOnly) { }

	// RVA: 0x2337790 Offset: 0x2336990 VA: 0x182337790
	private void .ctor(PropertyDescriptor[] properties, int propCount, string[] namedSort, IComparer comparer) { }

	[CompilerGenerated]
	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0
	public int get_Count() { }

	[CompilerGenerated]
	// RVA: 0x419410 Offset: 0x418610 VA: 0x180419410
	private void set_Count(int value) { }

	// RVA: 0x23379F0 Offset: 0x2336BF0 VA: 0x1823379F0 Slot: 31
	public virtual PropertyDescriptor get_Item(int index) { }

	// RVA: 0x2337B00 Offset: 0x2336D00 VA: 0x182337B00 Slot: 32
	public virtual PropertyDescriptor get_Item(string name) { }

	// RVA: 0x2335550 Offset: 0x2334750 VA: 0x182335550
	public int Add(PropertyDescriptor value) { }

	// RVA: 0x2335630 Offset: 0x2334830 VA: 0x182335630
	public void Clear() { }

	// RVA: 0x2335690 Offset: 0x2334890 VA: 0x182335690
	public bool Contains(PropertyDescriptor value) { }

	// RVA: 0x23356F0 Offset: 0x23348F0 VA: 0x1823356F0 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x2335740 Offset: 0x2334940 VA: 0x182335740
	private void EnsurePropsOwned() { }

	// RVA: 0x23357E0 Offset: 0x23349E0 VA: 0x1823357E0
	private void EnsureSize(int sizeNeeded) { }

	// RVA: 0x23358F0 Offset: 0x2334AF0 VA: 0x1823358F0 Slot: 33
	public virtual PropertyDescriptor Find(string name, bool ignoreCase) { }

	// RVA: 0x2335DE0 Offset: 0x2334FE0 VA: 0x182335DE0
	public int IndexOf(PropertyDescriptor value) { }

	// RVA: 0x2335E40 Offset: 0x2335040 VA: 0x182335E40
	public void Insert(int index, PropertyDescriptor value) { }

	// RVA: 0x23363E0 Offset: 0x23355E0 VA: 0x1823363E0
	public void Remove(PropertyDescriptor value) { }

	// RVA: 0x2336330 Offset: 0x2335530 VA: 0x182336330
	public void RemoveAt(int index) { }

	// RVA: 0x23365D0 Offset: 0x23357D0 VA: 0x1823365D0 Slot: 34
	public virtual PropertyDescriptorCollection Sort() { }

	// RVA: 0x2336530 Offset: 0x2335730 VA: 0x182336530 Slot: 35
	public virtual PropertyDescriptorCollection Sort(string[] names) { }

	// RVA: 0x2336490 Offset: 0x2335690 VA: 0x182336490 Slot: 36
	public virtual PropertyDescriptorCollection Sort(string[] names, IComparer comparer) { }

	// RVA: 0x2336670 Offset: 0x2335870 VA: 0x182336670 Slot: 37
	public virtual PropertyDescriptorCollection Sort(IComparer comparer) { }

	// RVA: 0x2335FC0 Offset: 0x23351C0 VA: 0x182335FC0
	protected void InternalSort(string[] names) { }

	// RVA: 0x2335F40 Offset: 0x2335140 VA: 0x182335F40
	protected void InternalSort(IComparer sorter) { }

	// RVA: 0x2335D30 Offset: 0x2334F30 VA: 0x182335D30 Slot: 38
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x2335630 Offset: 0x2334830 VA: 0x182335630 Slot: 13
	private void System.Collections.IList.Clear() { }

	// RVA: 0x2335630 Offset: 0x2334830 VA: 0x182335630 Slot: 26
	private void System.Collections.IDictionary.Clear() { }

	// RVA: 0x202EBD0 Offset: 0x202DDD0 VA: 0x18202EBD0 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2337330 Offset: 0x2336530 VA: 0x182337330 Slot: 19
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x2336710 Offset: 0x2335910 VA: 0x182336710 Slot: 25
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x23367E0 Offset: 0x23359E0 VA: 0x1823367E0 Slot: 24
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x2336880 Offset: 0x2335A80 VA: 0x182336880 Slot: 29
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x161DE50 Offset: 0x161D050 VA: 0x18161DE50 Slot: 28
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x161DE50 Offset: 0x161D050 VA: 0x18161DE50 Slot: 27
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x2336990 Offset: 0x2335B90 VA: 0x182336990 Slot: 20
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x2336BB0 Offset: 0x2335DB0 VA: 0x182336BB0 Slot: 21
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x2336A20 Offset: 0x2335C20 VA: 0x182336A20 Slot: 22
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x2336AE0 Offset: 0x2335CE0 VA: 0x182336AE0 Slot: 23
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x23368E0 Offset: 0x2335AE0 VA: 0x1823368E0 Slot: 30
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x2336F80 Offset: 0x2336180 VA: 0x182336F80 Slot: 11
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x2337020 Offset: 0x2336220 VA: 0x182337020 Slot: 12
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x23370F0 Offset: 0x23362F0 VA: 0x1823370F0 Slot: 16
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x23371C0 Offset: 0x23363C0 VA: 0x1823371C0 Slot: 17
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x161DE50 Offset: 0x161D050 VA: 0x18161DE50 Slot: 14
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x161DE50 Offset: 0x161D050 VA: 0x18161DE50 Slot: 15
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x2337340 Offset: 0x2336540 VA: 0x182337340 Slot: 18
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1950650 Offset: 0x194F850 VA: 0x181950650 Slot: 9
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x2337460 Offset: 0x2336660 VA: 0x182337460 Slot: 10
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x23376D0 Offset: 0x23368D0 VA: 0x1823376D0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(4, AllowMultiple = True)]
public sealed class ProvidePropertyAttribute : Attribute // TypeDefIndex: 5310
{
	// Fields
	[CompilerGenerated]
	private readonly string <PropertyName>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <ReceiverTypeName>k__BackingField; // 0x18

	// Properties
	public string PropertyName { get; }
	public string ReceiverTypeName { get; }
	public override object TypeId { get; }

	// Methods

	// RVA: 0x23392E0 Offset: 0x23384E0 VA: 0x1823392E0
	public void .ctor(string propertyName, Type receiverType) { }

	// RVA: 0x1675460 Offset: 0x1674660 VA: 0x181675460
	public void .ctor(string propertyName, string receiverTypeName) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_PropertyName() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_ReceiverTypeName() { }

	// RVA: 0x2339230 Offset: 0x2338430 VA: 0x182339230 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xC1C4A0 Offset: 0xC1B6A0 VA: 0x180C1C4A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2318330 Offset: 0x2317530 VA: 0x182318330 Slot: 4
	public override object get_TypeId() { }
}

// Namespace: System.ComponentModel
[Usage(128)]
[Obsolete("Use System.ComponentModel.SettingsBindableAttribute instead to work with the new settings model.")]
public class RecommendedAsConfigurableAttribute : Attribute // TypeDefIndex: 5311
{
	// Fields
	[CompilerGenerated]
	private readonly bool <RecommendedAsConfigurable>k__BackingField; // 0x10
	public static readonly RecommendedAsConfigurableAttribute No; // 0x0
	public static readonly RecommendedAsConfigurableAttribute Yes; // 0x8
	public static readonly RecommendedAsConfigurableAttribute Default; // 0x10

	// Properties
	public bool RecommendedAsConfigurable { get; }

	// Methods

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool recommendedAsConfigurable) { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_RecommendedAsConfigurable() { }

	// RVA: 0x2339340 Offset: 0x2338540 VA: 0x182339340 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23393F0 Offset: 0x23385F0 VA: 0x1823393F0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x2339400 Offset: 0x2338600 VA: 0x182339400
	private static void .cctor() { }
}

// Namespace: 
private class ReferenceConverter.ReferenceComparer : IComparer // TypeDefIndex: 5312
{
	// Fields
	private ReferenceConverter _converter; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(ReferenceConverter converter) { }

	// RVA: 0x23394A0 Offset: 0x23386A0 VA: 0x1823394A0 Slot: 4
	public int Compare(object item1, object item2) { }
}

// Namespace: System.ComponentModel
public class ReferenceConverter : TypeConverter // TypeDefIndex: 5313
{
	// Fields
	private static readonly string s_none; // 0x0
	private Type _type; // 0x10

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(Type type) { }

	// RVA: 0x2339550 Offset: 0x2338750 VA: 0x182339550 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x2339600 Offset: 0x2338800 VA: 0x182339600 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x23398A0 Offset: 0x2338AA0 VA: 0x1823398A0 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x2339C30 Offset: 0x2338E30 VA: 0x182339C30 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 16
	protected virtual bool IsValueAllowed(ITypeDescriptorContext context, object value) { }

	// RVA: 0x233A190 Offset: 0x2339390 VA: 0x18233A190
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
internal sealed class ReflectEventDescriptor : EventDescriptor // TypeDefIndex: 5314
{
	// Fields
	private Type _type; // 0x60
	private readonly Type _componentClass; // 0x68
	private MethodInfo _addMethod; // 0x70
	private MethodInfo _removeMethod; // 0x78
	private EventInfo _realEvent; // 0x80
	private bool _filledMethods; // 0x88

	// Properties
	public override Type ComponentType { get; }
	public override Type EventType { get; }
	public override bool IsMulticast { get; }

	// Methods

	// RVA: 0x233B630 Offset: 0x233A830 VA: 0x18233B630
	public void .ctor(Type componentClass, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x233B4F0 Offset: 0x233A6F0 VA: 0x18233B4F0
	public void .ctor(Type componentClass, EventInfo eventInfo) { }

	// RVA: 0x233B830 Offset: 0x233AA30 VA: 0x18233B830
	public void .ctor(Type componentType, EventDescriptor oldReflectEventDescriptor, Attribute[] attributes) { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00 Slot: 17
	public override Type get_ComponentType() { }

	// RVA: 0x233B8F0 Offset: 0x233AAF0 VA: 0x18233B8F0 Slot: 18
	public override Type get_EventType() { }

	// RVA: 0x233B910 Offset: 0x233AB10 VA: 0x18233B910 Slot: 19
	public override bool get_IsMulticast() { }

	// RVA: 0x233A1E0 Offset: 0x23393E0 VA: 0x18233A1E0 Slot: 20
	public override void AddEventHandler(object component, Delegate value) { }

	// RVA: 0x233A630 Offset: 0x2339830 VA: 0x18233A630 Slot: 15
	protected override void FillAttributes(IList attributes) { }

	// RVA: 0x233A6B0 Offset: 0x23398B0 VA: 0x18233A6B0
	private void FillEventInfoAttribute(EventInfo realEventInfo, IList attributes) { }

	// RVA: 0x233A990 Offset: 0x2339B90 VA: 0x18233A990
	private void FillMethods() { }

	// RVA: 0x233AE30 Offset: 0x233A030 VA: 0x18233AE30
	private void FillSingleMethodAttribute(MethodInfo realMethodInfo, IList attributes) { }

	// RVA: 0x233B170 Offset: 0x233A370 VA: 0x18233B170 Slot: 21
	public override void RemoveEventHandler(object component, Delegate value) { }
}

// Namespace: System.ComponentModel
public class RefreshEventArgs : EventArgs // TypeDefIndex: 5315
{
	// Fields
	[CompilerGenerated]
	private readonly object <ComponentChanged>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Type <TypeChanged>k__BackingField; // 0x18

	// Properties
	public object ComponentChanged { get; }
	public Type TypeChanged { get; }

	// Methods

	// RVA: 0x233BA20 Offset: 0x233AC20 VA: 0x18233BA20
	public void .ctor(object componentChanged) { }

	// RVA: 0x233B9C0 Offset: 0x233ABC0 VA: 0x18233B9C0
	public void .ctor(Type typeChanged) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public object get_ComponentChanged() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Type get_TypeChanged() { }
}

// Namespace: System.ComponentModel
public sealed class RefreshEventHandler : MulticastDelegate // TypeDefIndex: 5316
{
	// Methods

	// RVA: 0x3FD260 Offset: 0x3FC460 VA: 0x1803FD260
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(RefreshEventArgs e) { }

	// RVA: 0x3FD210 Offset: 0x3FC410 VA: 0x1803FD210 Slot: 14
	public virtual IAsyncResult BeginInvoke(RefreshEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.ComponentModel
[Usage(4)]
public class RunInstallerAttribute : Attribute // TypeDefIndex: 5317
{
	// Fields
	[CompilerGenerated]
	private readonly bool <RunInstaller>k__BackingField; // 0x10
	public static readonly RunInstallerAttribute Yes; // 0x0
	public static readonly RunInstallerAttribute No; // 0x8
	public static readonly RunInstallerAttribute Default; // 0x10

	// Properties
	public bool RunInstaller { get; }

	// Methods

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool runInstaller) { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_RunInstaller() { }

	// RVA: 0x233BAA0 Offset: 0x233ACA0 VA: 0x18233BAA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x233BB50 Offset: 0x233AD50 VA: 0x18233BB50 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x233BBC0 Offset: 0x233ADC0 VA: 0x18233BBC0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public class SByteConverter : BaseNumberConverter // TypeDefIndex: 5318
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x233BDD0 Offset: 0x233AFD0 VA: 0x18233BDD0 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x233BC60 Offset: 0x233AE60 VA: 0x18233BC60 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x233BCE0 Offset: 0x233AEE0 VA: 0x18233BCE0 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x233BD40 Offset: 0x233AF40 VA: 0x18233BD40 Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	public void .ctor() { }
}

// Namespace: System.ComponentModel
[Usage(128)]
public sealed class SettingsBindableAttribute : Attribute // TypeDefIndex: 5319
{
	// Fields
	public static readonly SettingsBindableAttribute Yes; // 0x0
	public static readonly SettingsBindableAttribute No; // 0x8
	[CompilerGenerated]
	private readonly bool <Bindable>k__BackingField; // 0x10

	// Properties
	public bool Bindable { get; }

	// Methods

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool bindable) { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_Bindable() { }

	// RVA: 0x233BE30 Offset: 0x233B030 VA: 0x18233BE30 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x233BED0 Offset: 0x233B0D0 VA: 0x18233BED0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x233BF30 Offset: 0x233B130 VA: 0x18233BF30
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public class SingleConverter : BaseNumberConverter // TypeDefIndex: 5320
{
	// Properties
	internal override bool AllowHex { get; }
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 16
	internal override bool get_AllowHex() { }

	// RVA: 0x233C180 Offset: 0x233B380 VA: 0x18233C180 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x233C030 Offset: 0x233B230 VA: 0x18233C030 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x233BFC0 Offset: 0x233B1C0 VA: 0x18233BFC0 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x233C0E0 Offset: 0x233B2E0 VA: 0x18233C0E0 Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class StringConverter : TypeConverter // TypeDefIndex: 5321
{
	// Methods

	// RVA: 0x233C880 Offset: 0x233BA80 VA: 0x18233C880 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x233C930 Offset: 0x233BB30 VA: 0x18233C930 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public static class SyntaxCheck // TypeDefIndex: 5322
{
	// Methods

	// RVA: 0x233C9F0 Offset: 0x233BBF0 VA: 0x18233C9F0
	public static bool CheckMachineName(string value) { }

	// RVA: 0x233CA80 Offset: 0x233BC80 VA: 0x18233CA80
	public static bool CheckPath(string value) { }

	// RVA: 0x233CB10 Offset: 0x233BD10 VA: 0x18233CB10
	public static bool CheckRootedPath(string value) { }
}

// Namespace: System.ComponentModel
public class TimeSpanConverter : TypeConverter // TypeDefIndex: 5323
{
	// Methods

	// RVA: 0x233CBB0 Offset: 0x233BDB0 VA: 0x18233CBB0 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x233CC60 Offset: 0x233BE60 VA: 0x18233CC60 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x233CD10 Offset: 0x233BF10 VA: 0x18233CD10 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x233CE90 Offset: 0x233C090 VA: 0x18233CE90 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.ComponentModel
[Usage(4, AllowMultiple = True, Inherited = True)]
[Serializable]
public sealed class ToolboxItemFilterAttribute : Attribute // TypeDefIndex: 5324
{
	// Fields
	private string _typeId; // 0x10
	[CompilerGenerated]
	private readonly string <FilterString>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly ToolboxItemFilterType <FilterType>k__BackingField; // 0x20

	// Properties
	public string FilterString { get; }
	public ToolboxItemFilterType FilterType { get; }
	public override object TypeId { get; }

	// Methods

	// RVA: 0x233D4B0 Offset: 0x233C6B0 VA: 0x18233D4B0
	public void .ctor(string filterString) { }

	// RVA: 0x233D430 Offset: 0x233C630 VA: 0x18233D430
	public void .ctor(string filterString, ToolboxItemFilterType filterType) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_FilterString() { }

	[CompilerGenerated]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public ToolboxItemFilterType get_FilterType() { }

	// RVA: 0x233D520 Offset: 0x233C720 VA: 0x18233D520 Slot: 4
	public override object get_TypeId() { }

	// RVA: 0x233D1C0 Offset: 0x233C3C0 VA: 0x18233D1C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x5C6320 Offset: 0x5C5520 VA: 0x1805C6320 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x233D2C0 Offset: 0x233C4C0 VA: 0x18233D2C0 Slot: 5
	public override bool Match(object obj) { }

	// RVA: 0x233D340 Offset: 0x233C540 VA: 0x18233D340 Slot: 3
	public override string ToString() { }
}

// Namespace: System.ComponentModel
public enum ToolboxItemFilterType // TypeDefIndex: 5325
{
	// Fields
	public int value__; // 0x0
	public const ToolboxItemFilterType Allow = 0;
	public const ToolboxItemFilterType Custom = 1;
	public const ToolboxItemFilterType Prevent = 2;
	public const ToolboxItemFilterType Require = 3;
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class TypeConverterAttribute : Attribute // TypeDefIndex: 5326
{
	// Fields
	public static readonly TypeConverterAttribute Default; // 0x0
	[CompilerGenerated]
	private readonly string <ConverterTypeName>k__BackingField; // 0x10

	// Properties
	public string ConverterTypeName { get; }

	// Methods

	// RVA: 0x233D680 Offset: 0x233C880 VA: 0x18233D680
	public void .ctor() { }

	// RVA: 0x231C1D0 Offset: 0x231B3D0 VA: 0x18231C1D0
	public void .ctor(Type type) { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string typeName) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_ConverterTypeName() { }

	// RVA: 0x233D580 Offset: 0x233C780 VA: 0x18233D580 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x5BF760 Offset: 0x5BE960 VA: 0x1805BF760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x233D5F0 Offset: 0x233C7F0 VA: 0x18233D5F0
	private static void .cctor() { }
}

// Namespace: 
private sealed class TypeDescriptionProvider.EmptyCustomTypeDescriptor : CustomTypeDescriptor // TypeDefIndex: 5327
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public abstract class TypeDescriptionProvider // TypeDefIndex: 5328
{
	// Fields
	private readonly TypeDescriptionProvider _parent; // 0x10
	private TypeDescriptionProvider.EmptyCustomTypeDescriptor _emptyDescriptor; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	protected void .ctor(TypeDescriptionProvider parent) { }

	// RVA: 0x233D830 Offset: 0x233CA30 VA: 0x18233D830 Slot: 4
	public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x233D950 Offset: 0x233CB50 VA: 0x18233D950 Slot: 5
	public virtual IDictionary GetCache(object instance) { }

	// RVA: 0x233D970 Offset: 0x233CB70 VA: 0x18233D970 Slot: 6
	public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x233DA10 Offset: 0x233CC10 VA: 0x18233DA10 Slot: 7
	protected internal virtual IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x233DAE0 Offset: 0x233CCE0 VA: 0x18233DAE0 Slot: 8
	public virtual string GetFullComponentName(object component) { }

	// RVA: 0x156A970 Offset: 0x1569B70 VA: 0x18156A970
	public Type GetReflectionType(Type objectType) { }

	// RVA: 0x233DC10 Offset: 0x233CE10 VA: 0x18233DC10
	public Type GetReflectionType(object instance) { }

	// RVA: 0x233DBE0 Offset: 0x233CDE0 VA: 0x18233DBE0 Slot: 9
	public virtual Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x233DCA0 Offset: 0x233CEA0 VA: 0x18233DCA0 Slot: 10
	public virtual Type GetRuntimeType(Type reflectionType) { }

	// RVA: 0x233DFA0 Offset: 0x233D1A0 VA: 0x18233DFA0
	public ICustomTypeDescriptor GetTypeDescriptor(Type objectType) { }

	// RVA: 0x233DF10 Offset: 0x233D110 VA: 0x18233DF10
	public ICustomTypeDescriptor GetTypeDescriptor(object instance) { }

	// RVA: 0x233DE60 Offset: 0x233D060 VA: 0x18233DE60 Slot: 11
	public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x233DFC0 Offset: 0x233D1C0 VA: 0x18233DFC0 Slot: 12
	public virtual bool IsSupportedType(Type type) { }
}

// Namespace: System.ComponentModel
[Usage(4, Inherited = True)]
public sealed class TypeDescriptionProviderAttribute : Attribute // TypeDefIndex: 5329
{
	// Fields
	[CompilerGenerated]
	private readonly string <TypeName>k__BackingField; // 0x10

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x233D6D0 Offset: 0x233C8D0 VA: 0x18233D6D0
	public void .ctor(string typeName) { }

	// RVA: 0x233D750 Offset: 0x233C950 VA: 0x18233D750
	public void .ctor(Type type) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_TypeName() { }
}

// Namespace: System.ComponentModel
public abstract class TypeListConverter : TypeConverter // TypeDefIndex: 5330
{
	// Fields
	private readonly Type[] _types; // 0x10
	private TypeConverter.StandardValuesCollection _values; // 0x18

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	protected void .ctor(Type[] types) { }

	// RVA: 0x233E0A0 Offset: 0x233D2A0 VA: 0x18233E0A0 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x233E150 Offset: 0x233D350 VA: 0x18233E150 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x233E200 Offset: 0x233D400 VA: 0x18233E200 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x233E330 Offset: 0x233D530 VA: 0x18233E330 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x233E530 Offset: 0x233D730 VA: 0x18233E530 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }
}

// Namespace: System.ComponentModel
public class UInt16Converter : BaseNumberConverter // TypeDefIndex: 5331
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x233E760 Offset: 0x233D960 VA: 0x18233E760 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x233E5F0 Offset: 0x233D7F0 VA: 0x18233E5F0 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x233E670 Offset: 0x233D870 VA: 0x18233E670 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x233E6D0 Offset: 0x233D8D0 VA: 0x18233E6D0 Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class UInt32Converter : BaseNumberConverter // TypeDefIndex: 5332
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x233E930 Offset: 0x233DB30 VA: 0x18233E930 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x233E7C0 Offset: 0x233D9C0 VA: 0x18233E7C0 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x233E840 Offset: 0x233DA40 VA: 0x18233E840 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x233E8A0 Offset: 0x233DAA0 VA: 0x18233E8A0 Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class UInt64Converter : BaseNumberConverter // TypeDefIndex: 5333
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x233EB00 Offset: 0x233DD00 VA: 0x18233EB00 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x233E9F0 Offset: 0x233DBF0 VA: 0x18233E9F0 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x233E990 Offset: 0x233DB90 VA: 0x18233E990 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x233EA70 Offset: 0x233DC70 VA: 0x18233EA70 Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	public void .ctor() { }
}

// Namespace: System.ComponentModel
[Serializable]
public class WarningException : SystemException // TypeDefIndex: 5334
{
	// Fields
	[CompilerGenerated]
	private readonly string <HelpUrl>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly string <HelpTopic>k__BackingField; // 0x98

	// Properties
	public string HelpUrl { get; }
	public string HelpTopic { get; }

	// Methods

	// RVA: 0x233EC10 Offset: 0x233DE10 VA: 0x18233EC10
	public void .ctor() { }

	// RVA: 0x233EE60 Offset: 0x233E060 VA: 0x18233EE60
	public void .ctor(string message) { }

	// RVA: 0x233EE20 Offset: 0x233E020 VA: 0x18233EE20
	public void .ctor(string message, string helpUrl) { }

	// RVA: 0x1633A30 Offset: 0x1632C30 VA: 0x181633A30
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x233EC40 Offset: 0x233DE40 VA: 0x18233EC40
	public void .ctor(string message, string helpUrl, string helpTopic) { }

	// RVA: 0x233EC80 Offset: 0x233DE80 VA: 0x18233EC80
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	[CompilerGenerated]
	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	public string get_HelpUrl() { }

	[CompilerGenerated]
	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50
	public string get_HelpTopic() { }

	// RVA: 0x233EB60 Offset: 0x233DD60 VA: 0x18233EB60 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.ComponentModel
public class CancelEventArgs : EventArgs // TypeDefIndex: 5335
{
	// Fields
	[CompilerGenerated]
	private bool <Cancel>k__BackingField; // 0x10

	// Properties
	public bool Cancel { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_Cancel() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_Cancel(bool value) { }

	// RVA: 0x23242C0 Offset: 0x23234C0 VA: 0x1823242C0
	public void .ctor() { }

	// RVA: 0x2324310 Offset: 0x2323510 VA: 0x182324310
	public void .ctor(bool cancel) { }
}

// Namespace: System.ComponentModel
public interface IChangeTracking // TypeDefIndex: 5336
{
	// Properties
	public abstract bool IsChanged { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsChanged();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void AcceptChanges();
}

// Namespace: System.ComponentModel
public interface IEditableObject // TypeDefIndex: 5337
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void BeginEdit();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void EndEdit();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void CancelEdit();
}

// Namespace: System.ComponentModel
public interface IRevertibleChangeTracking : IChangeTracking // TypeDefIndex: 5338
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void RejectChanges();
}

// Namespace: System.ComponentModel
public class DataErrorsChangedEventArgs : EventArgs // TypeDefIndex: 5339
{
	// Fields
	private readonly string _propertyName; // 0x10

	// Properties
	public virtual string PropertyName { get; }

	// Methods

	// RVA: 0x2327450 Offset: 0x2326650 VA: 0x182327450
	public void .ctor(string propertyName) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public virtual string get_PropertyName() { }
}

// Namespace: System.ComponentModel
public interface INotifyDataErrorInfo // TypeDefIndex: 5340
{
	// Properties
	public abstract bool HasErrors { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_HasErrors();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IEnumerable GetErrors(string propertyName);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_ErrorsChanged(EventHandler<DataErrorsChangedEventArgs> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_ErrorsChanged(EventHandler<DataErrorsChangedEventArgs> value);
}

// Namespace: System.ComponentModel
public interface INotifyPropertyChanged // TypeDefIndex: 5341
{
	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_PropertyChanged(PropertyChangedEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_PropertyChanged(PropertyChangedEventHandler value);
}

// Namespace: System.ComponentModel
public interface INotifyPropertyChanging // TypeDefIndex: 5342
{
	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_PropertyChanging(PropertyChangingEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_PropertyChanging(PropertyChangingEventHandler value);
}

// Namespace: System.ComponentModel
public class PropertyChangedEventArgs : EventArgs // TypeDefIndex: 5343
{
	// Fields
	private readonly string _propertyName; // 0x10

	// Properties
	public virtual string PropertyName { get; }

	// Methods

	// RVA: 0x2335490 Offset: 0x2334690 VA: 0x182335490
	public void .ctor(string propertyName) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public virtual string get_PropertyName() { }
}

// Namespace: System.ComponentModel
public sealed class PropertyChangedEventHandler : MulticastDelegate // TypeDefIndex: 5344
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, PropertyChangedEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, PropertyChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.ComponentModel
public class PropertyChangingEventArgs : EventArgs // TypeDefIndex: 5345
{
	// Fields
	private readonly string _propertyName; // 0x10

	// Properties
	public virtual string PropertyName { get; }

	// Methods

	// RVA: 0x23354F0 Offset: 0x23346F0 VA: 0x1823354F0
	public void .ctor(string propertyName) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public virtual string get_PropertyName() { }
}

// Namespace: System.ComponentModel
public sealed class PropertyChangingEventHandler : MulticastDelegate // TypeDefIndex: 5346
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, PropertyChangingEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, PropertyChangingEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.ComponentModel
internal class ArraySubsetEnumerator : IEnumerator // TypeDefIndex: 5347
{
	// Fields
	private Array array; // 0x10
	private int total; // 0x18
	private int current; // 0x1C

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x230A230 Offset: 0x2309430 VA: 0x18230A230
	public void .ctor(Array array, int count) { }

	// RVA: 0x230A210 Offset: 0x2309410 VA: 0x18230A210 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x2174520 Offset: 0x2173720 VA: 0x182174520 Slot: 6
	public void Reset() { }

	// RVA: 0x2324090 Offset: 0x2323290 VA: 0x182324090 Slot: 5
	public object get_Current() { }
}

// Namespace: System.ComponentModel
public class AsyncCompletedEventArgs : EventArgs // TypeDefIndex: 5348
{
	// Fields
	private readonly Exception error; // 0x10
	private readonly bool cancelled; // 0x18
	private readonly object userState; // 0x20

	// Properties
	[SRDescription("True if operation was cancelled.")]
	public bool Cancelled { get; }
	[SRDescription("Exception that occurred during operation.  Null if no error.")]
	public Exception Error { get; }
	[SRDescription("User-supplied state to identify operation.")]
	public object UserState { get; }

	// Methods

	[EditorBrowsable(1)]
	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", True)]
	// RVA: 0x2324270 Offset: 0x2323470 VA: 0x182324270
	public void .ctor() { }

	// RVA: 0x23241F0 Offset: 0x23233F0 VA: 0x1823241F0
	public void .ctor(Exception error, bool cancelled, object userState) { }

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_Cancelled() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Exception get_Error() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public object get_UserState() { }

	// RVA: 0x2324100 Offset: 0x2323300 VA: 0x182324100
	protected void RaiseExceptionIfNecessary() { }
}

// Namespace: System.ComponentModel
public sealed class AsyncCompletedEventHandler : MulticastDelegate // TypeDefIndex: 5349
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, AsyncCompletedEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, AsyncCompletedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public class CategoryAttribute : Attribute // TypeDefIndex: 5350
{
	// Fields
	private static CategoryAttribute appearance; // 0x0
	private static CategoryAttribute asynchronous; // 0x8
	private static CategoryAttribute behavior; // 0x10
	private static CategoryAttribute data; // 0x18
	private static CategoryAttribute design; // 0x20
	private static CategoryAttribute action; // 0x28
	private static CategoryAttribute format; // 0x30
	private static CategoryAttribute layout; // 0x38
	private static CategoryAttribute mouse; // 0x40
	private static CategoryAttribute key; // 0x48
	private static CategoryAttribute focus; // 0x50
	private static CategoryAttribute windowStyle; // 0x58
	private static CategoryAttribute dragDrop; // 0x60
	private static CategoryAttribute defAttr; // 0x68
	private bool localized; // 0x10
	private string categoryValue; // 0x18

	// Properties
	public static CategoryAttribute Action { get; }
	public static CategoryAttribute Appearance { get; }
	public static CategoryAttribute Asynchronous { get; }
	public static CategoryAttribute Behavior { get; }
	public static CategoryAttribute Data { get; }
	public static CategoryAttribute Default { get; }
	public static CategoryAttribute Design { get; }
	public static CategoryAttribute DragDrop { get; }
	public static CategoryAttribute Focus { get; }
	public static CategoryAttribute Format { get; }
	public static CategoryAttribute Key { get; }
	public static CategoryAttribute Layout { get; }
	public static CategoryAttribute Mouse { get; }
	public static CategoryAttribute WindowStyle { get; }
	public string Category { get; }

	// Methods

	// RVA: 0x2324B70 Offset: 0x2323D70 VA: 0x182324B70
	public static CategoryAttribute get_Action() { }

	// RVA: 0x2324C30 Offset: 0x2323E30 VA: 0x182324C30
	public static CategoryAttribute get_Appearance() { }

	// RVA: 0x2324CE0 Offset: 0x2323EE0 VA: 0x182324CE0
	public static CategoryAttribute get_Asynchronous() { }

	// RVA: 0x2324DA0 Offset: 0x2323FA0 VA: 0x182324DA0
	public static CategoryAttribute get_Behavior() { }

	// RVA: 0x2324EB0 Offset: 0x23240B0 VA: 0x182324EB0
	public static CategoryAttribute get_Data() { }

	// RVA: 0x2324F70 Offset: 0x2324170 VA: 0x182324F70
	public static CategoryAttribute get_Default() { }

	// RVA: 0x2325040 Offset: 0x2324240 VA: 0x182325040
	public static CategoryAttribute get_Design() { }

	// RVA: 0x2325100 Offset: 0x2324300 VA: 0x182325100
	public static CategoryAttribute get_DragDrop() { }

	// RVA: 0x23251C0 Offset: 0x23243C0 VA: 0x1823251C0
	public static CategoryAttribute get_Focus() { }

	// RVA: 0x2325280 Offset: 0x2324480 VA: 0x182325280
	public static CategoryAttribute get_Format() { }

	// RVA: 0x2325340 Offset: 0x2324540 VA: 0x182325340
	public static CategoryAttribute get_Key() { }

	// RVA: 0x2325400 Offset: 0x2324600 VA: 0x182325400
	public static CategoryAttribute get_Layout() { }

	// RVA: 0x23254C0 Offset: 0x23246C0 VA: 0x1823254C0
	public static CategoryAttribute get_Mouse() { }

	// RVA: 0x2325580 Offset: 0x2324780 VA: 0x182325580
	public static CategoryAttribute get_WindowStyle() { }

	// RVA: 0x2324AF0 Offset: 0x2323CF0 VA: 0x182324AF0
	public void .ctor() { }

	// RVA: 0x2324B40 Offset: 0x2323D40 VA: 0x182324B40
	public void .ctor(string category) { }

	// RVA: 0x2324E60 Offset: 0x2324060 VA: 0x182324E60
	public string get_Category() { }

	// RVA: 0x2324370 Offset: 0x2323570 VA: 0x182324370 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2324520 Offset: 0x2323720 VA: 0x182324520 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2324580 Offset: 0x2323780 VA: 0x182324580 Slot: 7
	protected virtual string GetLocalizedString(string value) { }

	// RVA: 0x23249A0 Offset: 0x2323BA0 VA: 0x1823249A0 Slot: 6
	public override bool IsDefaultAttribute() { }
}

// Namespace: System.ComponentModel
public class CollectionConverter : TypeConverter // TypeDefIndex: 5351
{
	// Methods

	// RVA: 0x23258B0 Offset: 0x2324AB0 VA: 0x1823258B0 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 10
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 11
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.ComponentModel
internal static class CompModSwitches // TypeDefIndex: 5352
{
	// Fields
	private static BooleanSwitch commonDesignerServices; // 0x0
	private static TraceSwitch eventLog; // 0x8

	// Properties
	public static BooleanSwitch CommonDesignerServices { get; }
	public static TraceSwitch EventLog { get; }

	// Methods

	// RVA: 0x2325A20 Offset: 0x2324C20 VA: 0x182325A20
	public static BooleanSwitch get_CommonDesignerServices() { }

	// RVA: 0x2325AE0 Offset: 0x2324CE0 VA: 0x182325AE0
	public static TraceSwitch get_EventLog() { }
}

// Namespace: System.ComponentModel
[ClassInterface(1)]
[ComVisible(True)]
[DesignerCategory("Component")]
public class Component : MarshalByRefObject, IComponent, IDisposable // TypeDefIndex: 5353
{
	// Fields
	private static readonly object EventDisposed; // 0x0
	private ISite site; // 0x18
	private EventHandlerList events; // 0x20

	// Properties
	protected virtual bool CanRaiseEvents { get; }
	internal bool CanRaiseEventsInternal { get; }
	protected EventHandlerList Events { get; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public virtual ISite Site { get; set; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public IContainer Container { get; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	protected bool DesignMode { get; }

	// Methods

	// RVA: 0x1B07300 Offset: 0x1B06500 VA: 0x181B07300 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 11
	protected virtual bool get_CanRaiseEvents() { }

	// RVA: 0x7F6700 Offset: 0x7F5900 VA: 0x1807F6700
	internal bool get_CanRaiseEventsInternal() { }

	// RVA: 0x2326090 Offset: 0x2325290 VA: 0x182326090 Slot: 8
	public void add_Disposed(EventHandler value) { }

	// RVA: 0x2326270 Offset: 0x2325470 VA: 0x182326270 Slot: 9
	public void remove_Disposed(EventHandler value) { }

	// RVA: 0x2326200 Offset: 0x2325400 VA: 0x182326200
	protected EventHandlerList get_Events() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 12
	public virtual ISite get_Site() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70 Slot: 13
	public virtual void set_Site(ISite value) { }

	// RVA: 0x2325C70 Offset: 0x2324E70 VA: 0x182325C70 Slot: 10
	public void Dispose() { }

	// RVA: 0x2325CE0 Offset: 0x2324EE0 VA: 0x182325CE0 Slot: 14
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2326160 Offset: 0x2325360 VA: 0x182326160
	public IContainer get_Container() { }

	// RVA: 0x2325EE0 Offset: 0x23250E0 VA: 0x182325EE0 Slot: 15
	protected virtual object GetService(Type service) { }

	// RVA: 0x23261B0 Offset: 0x23253B0 VA: 0x1823261B0
	protected bool get_DesignMode() { }

	// RVA: 0x2325F40 Offset: 0x2325140 VA: 0x182325F40 Slot: 3
	public override string ToString() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2326030 Offset: 0x2325230 VA: 0x182326030
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public class ComponentConverter : ReferenceConverter // TypeDefIndex: 5354
{
	// Methods

	// RVA: 0x2325C10 Offset: 0x2324E10 VA: 0x182325C10
	public void .ctor(Type type) { }

	// RVA: 0x2325BB0 Offset: 0x2324DB0 VA: 0x182325BB0 Slot: 10
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 11
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }
}

// Namespace: 
private class Container.Site : ISite, IServiceProvider // TypeDefIndex: 5355
{
	// Fields
	private IComponent component; // 0x10
	private Container container; // 0x18
	private string name; // 0x20

	// Properties
	public IComponent Component { get; }
	public IContainer Container { get; }
	public bool DesignMode { get; }
	public string Name { get; set; }

	// Methods

	// RVA: 0x3F6C30 Offset: 0x3F5E30 VA: 0x1803F6C30
	internal void .ctor(IComponent component, Container container, string name) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public IComponent get_Component() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 5
	public IContainer get_Container() { }

	// RVA: 0x233C340 Offset: 0x233B540 VA: 0x18233C340 Slot: 9
	public object GetService(Type service) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 6
	public bool get_DesignMode() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 7
	public string get_Name() { }

	// RVA: 0x233C810 Offset: 0x233BA10 VA: 0x18233C810 Slot: 8
	public void set_Name(string value) { }
}

// Namespace: System.ComponentModel
public class Container : IContainer, IDisposable // TypeDefIndex: 5356
{
	// Fields
	private ISite[] sites; // 0x10
	private int siteCount; // 0x18
	private ComponentCollection components; // 0x20
	private ContainerFilterService filter; // 0x28
	private bool checkedFilter; // 0x30
	private object syncObj; // 0x38

	// Properties
	public virtual ComponentCollection Components { get; }

	// Methods

	// RVA: 0x15F4E50 Offset: 0x15F4050 VA: 0x1815F4E50 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x15B27D0 Offset: 0x15B19D0 VA: 0x1815B27D0 Slot: 9
	public virtual void Add(IComponent component) { }

	// RVA: 0x2326340 Offset: 0x2325540 VA: 0x182326340 Slot: 10
	public virtual void Add(IComponent component, string name) { }

	// RVA: 0x2326610 Offset: 0x2325810 VA: 0x182326610 Slot: 11
	protected virtual ISite CreateSite(IComponent component, string name) { }

	// RVA: 0x2326690 Offset: 0x2325890 VA: 0x182326690 Slot: 8
	public void Dispose() { }

	// RVA: 0x2326700 Offset: 0x2325900 VA: 0x182326700 Slot: 12
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2326A70 Offset: 0x2325C70 VA: 0x182326A70 Slot: 13
	protected virtual object GetService(Type service) { }

	// RVA: 0x2327100 Offset: 0x2326300 VA: 0x182327100 Slot: 14
	public virtual ComponentCollection get_Components() { }

	// RVA: 0x2326B10 Offset: 0x2325D10 VA: 0x182326B10 Slot: 15
	public virtual void Remove(IComponent component) { }

	// RVA: 0x2326B20 Offset: 0x2325D20 VA: 0x182326B20
	private void Remove(IComponent component, bool preserveSite) { }

	// RVA: 0x2326B00 Offset: 0x2325D00 VA: 0x182326B00
	protected void RemoveWithoutUnsiting(IComponent component) { }

	// RVA: 0x2326D40 Offset: 0x2325F40 VA: 0x182326D40 Slot: 16
	protected virtual void ValidateName(IComponent component, string name) { }

	// RVA: 0x23270A0 Offset: 0x23262A0 VA: 0x1823270A0
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class DateTimeOffsetConverter : TypeConverter // TypeDefIndex: 5357
{
	// Methods

	// RVA: 0x23274B0 Offset: 0x23266B0 VA: 0x1823274B0 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x2327560 Offset: 0x2326760 VA: 0x182327560 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x2327610 Offset: 0x2326810 VA: 0x182327610 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x2327970 Offset: 0x2326B70 VA: 0x182327970 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.ComponentModel
[Usage(1028, AllowMultiple = True, Inherited = True)]
[Conditional("FALSE")]
public sealed class DesignerAttribute : Attribute // TypeDefIndex: 5358
{
	// Fields
	private readonly string designerTypeName; // 0x10
	private readonly string designerBaseTypeName; // 0x18
	private string typeId; // 0x20

	// Properties
	public string DesignerBaseTypeName { get; }
	public string DesignerTypeName { get; }
	public override object TypeId { get; }

	// Methods

	// RVA: 0x2328830 Offset: 0x2327A30 VA: 0x182328830
	public void .ctor(string designerTypeName) { }

	// RVA: 0x2328910 Offset: 0x2327B10 VA: 0x182328910
	public void .ctor(Type designerType) { }

	// RVA: 0x2328A50 Offset: 0x2327C50 VA: 0x182328A50
	public void .ctor(string designerTypeName, string designerBaseTypeName) { }

	// RVA: 0x2328780 Offset: 0x2327980 VA: 0x182328780
	public void .ctor(string designerTypeName, Type designerBaseType) { }

	// RVA: 0x23289D0 Offset: 0x2327BD0 VA: 0x1823289D0
	public void .ctor(Type designerType, Type designerBaseType) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_DesignerBaseTypeName() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_DesignerTypeName() { }

	// RVA: 0x2328AE0 Offset: 0x2327CE0 VA: 0x182328AE0 Slot: 4
	public override object get_TypeId() { }

	// RVA: 0x23286D0 Offset: 0x23278D0 VA: 0x1823286D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xC1C4A0 Offset: 0xC1B6A0 VA: 0x180C1C4A0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.ComponentModel
public class DoWorkEventArgs : CancelEventArgs // TypeDefIndex: 5359
{
	// Fields
	private object result; // 0x18
	private object argument; // 0x20

	// Properties
	[SRDescription("Argument passed into the worker handler from BackgroundWorker.RunWorkerAsync.")]
	public object Argument { get; }
	[SRDescription("Result from the worker function.")]
	public object Result { get; set; }

	// Methods

	// RVA: 0x2328B80 Offset: 0x2327D80 VA: 0x182328B80
	public void .ctor(object argument) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public object get_Argument() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public object get_Result() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Result(object value) { }
}

// Namespace: System.ComponentModel
public sealed class DoWorkEventHandler : MulticastDelegate // TypeDefIndex: 5360
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, DoWorkEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, DoWorkEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.ComponentModel
public class EnumConverter : TypeConverter // TypeDefIndex: 5361
{
	// Fields
	private TypeConverter.StandardValuesCollection values; // 0x10
	private Type type; // 0x18

	// Properties
	protected Type EnumType { get; }
	protected TypeConverter.StandardValuesCollection Values { get; set; }
	protected virtual IComparer Comparer { get; }

	// Methods

	// RVA: 0x159E350 Offset: 0x159D550 VA: 0x18159E350
	public void .ctor(Type type) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	protected Type get_EnumType() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	protected TypeConverter.StandardValuesCollection get_Values() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	protected void set_Values(TypeConverter.StandardValuesCollection value) { }

	// RVA: 0x2328BE0 Offset: 0x2327DE0 VA: 0x182328BE0 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x2328CD0 Offset: 0x2327ED0 VA: 0x182328CD0 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x232A410 Offset: 0x2329610 VA: 0x18232A410 Slot: 16
	protected virtual IComparer get_Comparer() { }

	// RVA: 0x2328DC0 Offset: 0x2327FC0 VA: 0x182328DC0 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x2329250 Offset: 0x2328450 VA: 0x182329250 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x2329FD0 Offset: 0x23291D0 VA: 0x182329FD0 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x2329F30 Offset: 0x2329130 VA: 0x182329F30 Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x232A3B0 Offset: 0x23295B0 VA: 0x18232A3B0 Slot: 15
	public override bool IsValid(ITypeDescriptorContext context, object value) { }
}

// Namespace: System.ComponentModel
[RootDesignerSerializer("System.ComponentModel.Design.Serialization.RootCodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", True)]
[TypeConverter(typeof(ComponentConverter))]
[ComVisible(True)]
public interface IComponent : IDisposable // TypeDefIndex: 5362
{
	// Properties
	public abstract ISite Site { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ISite get_Site();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Site(ISite value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_Disposed(EventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_Disposed(EventHandler value);
}

// Namespace: System.ComponentModel
internal static class IntSecurity // TypeDefIndex: 5363
{
	// Methods

	// RVA: 0x20DF090 Offset: 0x20DE290 VA: 0x1820DF090
	public static string UnsafeGetFullPath(string fileName) { }
}

// Namespace: System.ComponentModel
[Serializable]
public class LicenseException : SystemException // TypeDefIndex: 5364
{
	// Fields
	private Type type; // 0x90
	private object instance; // 0x98

	// Properties
	public Type LicensedType { get; }

	// Methods

	// RVA: 0x20DF5C0 Offset: 0x20DE7C0 VA: 0x1820DF5C0
	public void .ctor(Type type) { }

	// RVA: 0x20DF270 Offset: 0x20DE470 VA: 0x1820DF270
	public void .ctor(Type type, object instance) { }

	// RVA: 0x20DF220 Offset: 0x20DE420 VA: 0x1820DF220
	public void .ctor(Type type, object instance, string message) { }

	// RVA: 0x20DF1D0 Offset: 0x20DE3D0 VA: 0x1820DF1D0
	public void .ctor(Type type, object instance, string message, Exception innerException) { }

	// RVA: 0x20DF400 Offset: 0x20DE600 VA: 0x1820DF400
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	public Type get_LicensedType() { }

	// RVA: 0x20DF0E0 Offset: 0x20DE2E0 VA: 0x1820DF0E0 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.ComponentModel
[ComVisible(True)]
public abstract class MemberDescriptor // TypeDefIndex: 5365
{
	// Fields
	private string name; // 0x10
	private string displayName; // 0x18
	private int nameHash; // 0x20
	private AttributeCollection attributeCollection; // 0x28
	private Attribute[] attributes; // 0x30
	private Attribute[] originalAttributes; // 0x38
	private bool attributesFiltered; // 0x40
	private bool attributesFilled; // 0x41
	private int metadataVersion; // 0x44
	private string category; // 0x48
	private string description; // 0x50
	private object lockCookie; // 0x58

	// Properties
	protected virtual Attribute[] AttributeArray { get; set; }
	public virtual AttributeCollection Attributes { get; }
	public virtual string Category { get; }
	public virtual string Description { get; }
	public virtual bool IsBrowsable { get; }
	public virtual string Name { get; }
	protected virtual int NameHashCode { get; }
	public virtual bool DesignTimeOnly { get; }
	public virtual string DisplayName { get; }

	// Methods

	// RVA: 0x20E07A0 Offset: 0x20DF9A0 VA: 0x1820E07A0
	protected void .ctor(string name) { }

	// RVA: 0x20E0CD0 Offset: 0x20DFED0 VA: 0x1820E0CD0
	protected void .ctor(string name, Attribute[] attributes) { }

	// RVA: 0x20E07B0 Offset: 0x20DF9B0 VA: 0x1820E07B0
	protected void .ctor(MemberDescriptor descr) { }

	// RVA: 0x20E08F0 Offset: 0x20DFAF0 VA: 0x1820E08F0
	protected void .ctor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes) { }

	// RVA: 0x20E0E10 Offset: 0x20E0010 VA: 0x1820E0E10 Slot: 4
	protected virtual Attribute[] get_AttributeArray() { }

	// RVA: 0x20E15B0 Offset: 0x20E07B0 VA: 0x1820E15B0 Slot: 5
	protected virtual void set_AttributeArray(Attribute[] value) { }

	// RVA: 0x20E0E40 Offset: 0x20E0040 VA: 0x1820E0E40 Slot: 6
	public virtual AttributeCollection get_Attributes() { }

	// RVA: 0x20E0F10 Offset: 0x20E0110 VA: 0x1820E0F10 Slot: 7
	public virtual string get_Category() { }

	// RVA: 0x20E1090 Offset: 0x20E0290 VA: 0x1820E1090 Slot: 8
	public virtual string get_Description() { }

	// RVA: 0x20E1470 Offset: 0x20E0670 VA: 0x1820E1470 Slot: 9
	public virtual bool get_IsBrowsable() { }

	// RVA: 0x20E1560 Offset: 0x20E0760 VA: 0x1820E1560 Slot: 10
	public virtual string get_Name() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 11
	protected virtual int get_NameHashCode() { }

	// RVA: 0x20E1210 Offset: 0x20E0410 VA: 0x1820E1210 Slot: 12
	public virtual bool get_DesignTimeOnly() { }

	// RVA: 0x20E1320 Offset: 0x20E0520 VA: 0x1820E1320 Slot: 13
	public virtual string get_DisplayName() { }

	// RVA: 0x20DF920 Offset: 0x20DEB20 VA: 0x1820DF920
	private void CheckAttributesValid() { }

	// RVA: 0x20DF9D0 Offset: 0x20DEBD0 VA: 0x1820DF9D0 Slot: 14
	protected virtual AttributeCollection CreateAttributeCollection() { }

	// RVA: 0x20DFA40 Offset: 0x20DEC40 VA: 0x1820DFA40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20DFD00 Offset: 0x20DEF00 VA: 0x1820DFD00 Slot: 15
	protected virtual void FillAttributes(IList attributeList) { }

	// RVA: 0x20DFE30 Offset: 0x20DF030 VA: 0x1820DFE30
	private void FilterAttributesIfNeeded() { }

	// RVA: 0x20E0400 Offset: 0x20DF600 VA: 0x1820E0400
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType) { }

	// RVA: 0x20E0340 Offset: 0x20DF540 VA: 0x1820E0340
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20E0490 Offset: 0x20DF690 VA: 0x1820E0490 Slot: 16
	protected virtual object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x20E06F0 Offset: 0x20DF8F0 VA: 0x1820E06F0
	protected static ISite GetSite(object component) { }

	[Obsolete("This method has been deprecated. Use GetInvocationTarget instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x20E05C0 Offset: 0x20DF7C0 VA: 0x1820E05C0
	protected static object GetInvokee(Type componentClass, object component) { }
}

// Namespace: System.ComponentModel
public class ProgressChangedEventArgs : EventArgs // TypeDefIndex: 5366
{
	// Fields
	private readonly int progressPercentage; // 0x10
	private readonly object userState; // 0x18

	// Properties
	[SRDescription("Percentage progress made in operation.")]
	public int ProgressPercentage { get; }
	[SRDescription("User-supplied state to identify operation.")]
	public object UserState { get; }

	// Methods

	// RVA: 0x20E1C50 Offset: 0x20E0E50 VA: 0x1820E1C50
	public void .ctor(int progressPercentage, object userState) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_ProgressPercentage() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public object get_UserState() { }
}

// Namespace: System.ComponentModel
public sealed class ProgressChangedEventHandler : MulticastDelegate // TypeDefIndex: 5367
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, ProgressChangedEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, ProgressChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.ComponentModel
internal sealed class ReflectPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 5368
{
	// Fields
	private static readonly Type[] argsNone; // 0x0
	private static readonly object noValue; // 0x8
	private static TraceSwitch PropDescCreateSwitch; // 0x10
	private static TraceSwitch PropDescUsageSwitch; // 0x18
	private static readonly int BitDefaultValueQueried; // 0x20
	private static readonly int BitGetQueried; // 0x24
	private static readonly int BitSetQueried; // 0x28
	private static readonly int BitShouldSerializeQueried; // 0x2C
	private static readonly int BitResetQueried; // 0x30
	private static readonly int BitChangedQueried; // 0x34
	private static readonly int BitIPropChangedQueried; // 0x38
	private static readonly int BitReadOnlyChecked; // 0x3C
	private static readonly int BitAmbientValueQueried; // 0x40
	private static readonly int BitSetOnDemand; // 0x44
	private BitVector32 state; // 0x88
	private Type componentClass; // 0x90
	private Type type; // 0x98
	private object defaultValue; // 0xA0
	private object ambientValue; // 0xA8
	private PropertyInfo propInfo; // 0xB0
	private MethodInfo getMethod; // 0xB8
	private MethodInfo setMethod; // 0xC0
	private MethodInfo shouldSerializeMethod; // 0xC8
	private MethodInfo resetMethod; // 0xD0
	private EventDescriptor realChangedEvent; // 0xD8
	private EventDescriptor realIPropChangedEvent; // 0xE0
	private Type receiverType; // 0xE8

	// Properties
	private object AmbientValue { get; }
	private EventDescriptor ChangedEventValue { get; }
	private EventDescriptor IPropChangedEventValue { get; set; }
	public override Type ComponentType { get; }
	private object DefaultValue { get; }
	private MethodInfo GetMethodValue { get; }
	private bool IsExtender { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	private MethodInfo ResetMethodValue { get; }
	private MethodInfo SetMethodValue { get; }
	private MethodInfo ShouldSerializeMethodValue { get; }
	public override bool SupportsChangeEvents { get; }

	// Methods

	// RVA: 0x20E5230 Offset: 0x20E4430 VA: 0x1820E5230
	public void .ctor(Type componentClass, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x20E5550 Offset: 0x20E4750 VA: 0x1820E5550
	public void .ctor(Type componentClass, string name, Type type, PropertyInfo propInfo, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x20E5470 Offset: 0x20E4670 VA: 0x1820E5470
	public void .ctor(Type componentClass, string name, Type type, Type receiverType, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x20E4D80 Offset: 0x20E3F80 VA: 0x1820E4D80
	public void .ctor(Type componentClass, PropertyDescriptor oldReflectPropertyDescriptor, Attribute[] attributes) { }

	// RVA: 0x20E5690 Offset: 0x20E4890 VA: 0x1820E5690
	private object get_AmbientValue() { }

	// RVA: 0x20E5860 Offset: 0x20E4A60 VA: 0x1820E5860
	private EventDescriptor get_ChangedEventValue() { }

	// RVA: 0x20E6270 Offset: 0x20E5470 VA: 0x1820E6270
	private EventDescriptor get_IPropChangedEventValue() { }

	// RVA: 0x20E70E0 Offset: 0x20E62E0 VA: 0x1820E70E0
	private void set_IPropChangedEventValue(EventDescriptor value) { }

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560 Slot: 17
	public override Type get_ComponentType() { }

	// RVA: 0x20E5A00 Offset: 0x20E4C00 VA: 0x1820E5A00
	private object get_DefaultValue() { }

	// RVA: 0x20E5D60 Offset: 0x20E4F60 VA: 0x1820E5D60
	private MethodInfo get_GetMethodValue() { }

	// RVA: 0x20E6440 Offset: 0x20E5640 VA: 0x1820E6440
	private bool get_IsExtender() { }

	// RVA: 0x20E64A0 Offset: 0x20E56A0 VA: 0x1820E64A0 Slot: 20
	public override bool get_IsReadOnly() { }

	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50 Slot: 21
	public override Type get_PropertyType() { }

	// RVA: 0x20E65B0 Offset: 0x20E57B0 VA: 0x1820E65B0
	private MethodInfo get_ResetMethodValue() { }

	// RVA: 0x20E6800 Offset: 0x20E5A00 VA: 0x1820E6800
	private MethodInfo get_SetMethodValue() { }

	// RVA: 0x20E6E50 Offset: 0x20E6050 VA: 0x1820E6E50
	private MethodInfo get_ShouldSerializeMethodValue() { }

	// RVA: 0x20E1CC0 Offset: 0x20E0EC0 VA: 0x1820E1CC0 Slot: 22
	public override void AddValueChanged(object component, EventHandler handler) { }

	// RVA: 0x20E2130 Offset: 0x20E1330 VA: 0x1820E2130
	internal bool ExtenderCanResetValue(IExtenderProvider provider, object component) { }

	// RVA: 0x796090 Offset: 0x795290 VA: 0x180796090
	internal Type ExtenderGetReceiverType() { }

	// RVA: 0x7F7910 Offset: 0x7F6B10 VA: 0x1807F7910
	internal Type ExtenderGetType(IExtenderProvider provider) { }

	// RVA: 0x20E2360 Offset: 0x20E1560 VA: 0x1820E2360
	internal object ExtenderGetValue(IExtenderProvider provider, object component) { }

	// RVA: 0x20E24B0 Offset: 0x20E16B0 VA: 0x1820E24B0
	internal void ExtenderResetValue(IExtenderProvider provider, object component, PropertyDescriptor notifyDesc) { }

	// RVA: 0x20E2890 Offset: 0x20E1A90 VA: 0x1820E2890
	internal void ExtenderSetValue(IExtenderProvider provider, object component, object value, PropertyDescriptor notifyDesc) { }

	// RVA: 0x20E2BE0 Offset: 0x20E1DE0 VA: 0x1820E2BE0
	internal bool ExtenderShouldSerializeValue(IExtenderProvider provider, object component) { }

	// RVA: 0x20E1EC0 Offset: 0x20E10C0 VA: 0x1820E1EC0 Slot: 23
	public override bool CanResetValue(object component) { }

	// RVA: 0x20E2F70 Offset: 0x20E2170 VA: 0x1820E2F70 Slot: 15
	protected override void FillAttributes(IList attributes) { }

	// RVA: 0x20E3990 Offset: 0x20E2B90 VA: 0x1820E3990 Slot: 26
	public override object GetValue(object component) { }

	// RVA: 0x20E3CB0 Offset: 0x20E2EB0 VA: 0x1820E3CB0
	internal void OnINotifyPropertyChanged(object component, PropertyChangedEventArgs e) { }

	// RVA: 0x20E3DD0 Offset: 0x20E2FD0 VA: 0x1820E3DD0 Slot: 27
	protected override void OnValueChanged(object component, EventArgs e) { }

	// RVA: 0x20E3E70 Offset: 0x20E3070 VA: 0x1820E3E70 Slot: 28
	public override void RemoveValueChanged(object component, EventHandler handler) { }

	// RVA: 0x20E4070 Offset: 0x20E3270 VA: 0x1820E4070 Slot: 29
	public override void ResetValue(object component) { }

	// RVA: 0x20E4380 Offset: 0x20E3580 VA: 0x1820E4380 Slot: 30
	public override void SetValue(object component, object value) { }

	// RVA: 0x20E4820 Offset: 0x20E3A20 VA: 0x1820E4820 Slot: 31
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0x20E70A0 Offset: 0x20E62A0 VA: 0x1820E70A0 Slot: 32
	public override bool get_SupportsChangeEvents() { }

	// RVA: 0x20E4AB0 Offset: 0x20E3CB0 VA: 0x1820E4AB0
	private static void .cctor() { }
}

// Namespace: 
private class ReflectTypeDescriptionProvider.ReflectedTypeData // TypeDefIndex: 5369
{
	// Fields
	private Type _type; // 0x10
	private AttributeCollection _attributes; // 0x18
	private EventDescriptorCollection _events; // 0x20
	private PropertyDescriptorCollection _properties; // 0x28
	private TypeConverter _converter; // 0x30
	private object[] _editors; // 0x38
	private Type[] _editorTypes; // 0x40
	private int _editorCount; // 0x48

	// Properties
	internal bool IsPopulated { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(Type type) { }

	// RVA: 0x20EF940 Offset: 0x20EEB40 VA: 0x1820EF940
	internal bool get_IsPopulated() { }

	// RVA: 0x20ED810 Offset: 0x20ECA10 VA: 0x1820ED810
	internal AttributeCollection GetAttributes() { }

	// RVA: 0x16570F0 Offset: 0x16562F0 VA: 0x1816570F0
	internal string GetClassName(object instance) { }

	// RVA: 0x20EDD90 Offset: 0x20ECF90 VA: 0x1820EDD90
	internal string GetComponentName(object instance) { }

	// RVA: 0x20EDE50 Offset: 0x20ED050 VA: 0x1820EDE50
	internal TypeConverter GetConverter(object instance) { }

	// RVA: 0x20EE370 Offset: 0x20ED570 VA: 0x1820EE370
	internal EventDescriptor GetDefaultEvent(object instance) { }

	// RVA: 0x20EE580 Offset: 0x20ED780 VA: 0x1820EE580
	internal PropertyDescriptor GetDefaultProperty(object instance) { }

	// RVA: 0x20EEB20 Offset: 0x20EDD20 VA: 0x1820EEB20
	internal object GetEditor(object instance, Type editorBaseType) { }

	// RVA: 0x20EE8C0 Offset: 0x20EDAC0 VA: 0x1820EE8C0
	private static EditorAttribute GetEditorAttribute(AttributeCollection attributes, Type editorBaseType) { }

	// RVA: 0x20EF150 Offset: 0x20EE350 VA: 0x1820EF150
	internal EventDescriptorCollection GetEvents() { }

	// RVA: 0x20EF460 Offset: 0x20EE660 VA: 0x1820EF460
	internal PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x20EF770 Offset: 0x20EE970 VA: 0x1820EF770
	private Type GetTypeFromName(string typeName) { }

	// RVA: 0x20EF920 Offset: 0x20EEB20 VA: 0x1820EF920
	internal void Refresh() { }
}

// Namespace: System.ComponentModel
internal sealed class ReflectTypeDescriptionProvider : TypeDescriptionProvider // TypeDefIndex: 5370
{
	// Fields
	private Hashtable _typeData; // 0x20
	private static Type[] _typeConstructor; // 0x0
	private static Hashtable _editorTables; // 0x8
	private static Hashtable _intrinsicTypeConverters; // 0x10
	private static object _intrinsicReferenceKey; // 0x18
	private static object _intrinsicNullableKey; // 0x20
	private static object _dictionaryKey; // 0x28
	private static Hashtable _propertyCache; // 0x30
	private static Hashtable _eventCache; // 0x38
	private static Hashtable _attributeCache; // 0x40
	private static Hashtable _extendedPropertyCache; // 0x48
	private static readonly Guid _extenderProviderKey; // 0x50
	private static readonly Guid _extenderPropertiesKey; // 0x60
	private static readonly Guid _extenderProviderPropertiesKey; // 0x70
	private static readonly Type[] _skipInterfaceAttributeList; // 0x80
	private static object _internalSyncObject; // 0x88

	// Properties
	internal static Guid ExtenderProviderKey { get; }
	private static Hashtable IntrinsicTypeConverters { get; }

	// Methods

	// RVA: 0x20ECE20 Offset: 0x20EC020 VA: 0x1820ECE20
	internal static Guid get_ExtenderProviderKey() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	internal void .ctor() { }

	// RVA: 0x20ECE80 Offset: 0x20EC080 VA: 0x1820ECE80
	private static Hashtable get_IntrinsicTypeConverters() { }

	// RVA: 0x20E7160 Offset: 0x20E6360 VA: 0x1820E7160
	internal static void AddEditorTable(Type editorBaseType, Hashtable table) { }

	// RVA: 0x20E7510 Offset: 0x20E6710 VA: 0x1820E7510 Slot: 4
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x20E7400 Offset: 0x20E6600 VA: 0x1820E7400
	private static object CreateInstance(Type objectType, Type callingType) { }

	// RVA: 0x20E7710 Offset: 0x20E6910 VA: 0x1820E7710
	internal AttributeCollection GetAttributes(Type type) { }

	// RVA: 0x20E7740 Offset: 0x20E6940 VA: 0x1820E7740 Slot: 5
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x20E7940 Offset: 0x20E6B40 VA: 0x1820E7940
	internal string GetClassName(Type type) { }

	// RVA: 0x20E7980 Offset: 0x20E6B80 VA: 0x1820E7980
	internal string GetComponentName(Type type, object instance) { }

	// RVA: 0x20E7A50 Offset: 0x20E6C50 VA: 0x1820E7A50
	internal TypeConverter GetConverter(Type type, object instance) { }

	// RVA: 0x20E7A90 Offset: 0x20E6C90 VA: 0x1820E7A90
	internal EventDescriptor GetDefaultEvent(Type type, object instance) { }

	// RVA: 0x20E7AD0 Offset: 0x20E6CD0 VA: 0x1820E7AD0
	internal PropertyDescriptor GetDefaultProperty(Type type, object instance) { }

	// RVA: 0x20E7FF0 Offset: 0x20E71F0 VA: 0x1820E7FF0
	internal object GetEditor(Type type, object instance, Type editorBaseType) { }

	// RVA: 0x20E7B10 Offset: 0x20E6D10 VA: 0x1820E7B10
	private static Hashtable GetEditorTable(Type editorBaseType) { }

	// RVA: 0x20E8040 Offset: 0x20E7240 VA: 0x1820E8040
	internal EventDescriptorCollection GetEvents(Type type) { }

	// RVA: 0x20E8070 Offset: 0x20E7270 VA: 0x1820E8070
	internal AttributeCollection GetExtendedAttributes(object instance) { }

	// RVA: 0x20E80C0 Offset: 0x20E72C0 VA: 0x1820E80C0
	internal string GetExtendedClassName(object instance) { }

	// RVA: 0x20E8120 Offset: 0x20E7320 VA: 0x1820E8120
	internal string GetExtendedComponentName(object instance) { }

	// RVA: 0x20E8220 Offset: 0x20E7420 VA: 0x1820E8220
	internal TypeConverter GetExtendedConverter(object instance) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	internal EventDescriptor GetExtendedDefaultEvent(object instance) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	internal PropertyDescriptor GetExtendedDefaultProperty(object instance) { }

	// RVA: 0x20E8280 Offset: 0x20E7480 VA: 0x1820E8280
	internal object GetExtendedEditor(object instance, Type editorBaseType) { }

	// RVA: 0x20E82F0 Offset: 0x20E74F0 VA: 0x1820E82F0
	internal EventDescriptorCollection GetExtendedEvents(object instance) { }

	// RVA: 0x20E8340 Offset: 0x20E7540 VA: 0x1820E8340
	internal PropertyDescriptorCollection GetExtendedProperties(object instance) { }

	// RVA: 0x20E88C0 Offset: 0x20E7AC0 VA: 0x1820E88C0 Slot: 7
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x20E8BE0 Offset: 0x20E7DE0 VA: 0x1820E8BE0
	private static IExtenderProvider[] GetExtenders(ICollection components, object instance, IDictionary cache) { }

	// RVA: 0x20E8850 Offset: 0x20E7A50 VA: 0x1820E8850
	internal object GetExtendedPropertyOwner(object instance, PropertyDescriptor pd) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x20E94B0 Offset: 0x20E86B0 VA: 0x1820E94B0 Slot: 8
	public override string GetFullComponentName(object component) { }

	// RVA: 0x20E95F0 Offset: 0x20E87F0 VA: 0x1820E95F0
	internal Type[] GetPopulatedTypes(Module module) { }

	// RVA: 0x20E9A60 Offset: 0x20E8C60 VA: 0x1820E9A60
	internal PropertyDescriptorCollection GetProperties(Type type) { }

	// RVA: 0x20E9A90 Offset: 0x20E8C90 VA: 0x1820E9A90
	internal object GetPropertyOwner(Type type, object instance, PropertyDescriptor pd) { }

	// RVA: 0x70E580 Offset: 0x70D780 VA: 0x18070E580 Slot: 9
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x20E9AF0 Offset: 0x20E8CF0 VA: 0x1820E9AF0
	private ReflectTypeDescriptionProvider.ReflectedTypeData GetTypeData(Type type, bool createIfNeeded) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 11
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x20E9DA0 Offset: 0x20E8FA0 VA: 0x1820E9DA0
	private static Type GetTypeFromName(string typeName) { }

	// RVA: 0x20E9E90 Offset: 0x20E9090 VA: 0x1820E9E90
	internal bool IsPopulated(Type type) { }

	// RVA: 0x20E9EE0 Offset: 0x20E90E0 VA: 0x1820E9EE0
	private static Attribute[] ReflectGetAttributes(Type type) { }

	// RVA: 0x20EA3A0 Offset: 0x20E95A0 VA: 0x1820EA3A0
	internal static Attribute[] ReflectGetAttributes(MemberInfo member) { }

	// RVA: 0x20EA860 Offset: 0x20E9A60 VA: 0x1820EA860
	private static EventDescriptor[] ReflectGetEvents(Type type) { }

	// RVA: 0x20EAF40 Offset: 0x20EA140 VA: 0x1820EAF40
	private static PropertyDescriptor[] ReflectGetExtendedProperties(IExtenderProvider provider) { }

	// RVA: 0x20EBC50 Offset: 0x20EAE50 VA: 0x1820EBC50
	private static PropertyDescriptor[] ReflectGetProperties(Type type) { }

	// RVA: 0x20EC2A0 Offset: 0x20EB4A0 VA: 0x1820EC2A0
	internal void Refresh(Type type) { }

	// RVA: 0x20EC2E0 Offset: 0x20EB4E0 VA: 0x1820EC2E0
	private static object SearchIntrinsicTable(Hashtable table, Type callingType) { }

	// RVA: 0x20ECAD0 Offset: 0x20EBCD0 VA: 0x1820ECAD0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public class RunWorkerCompletedEventArgs : AsyncCompletedEventArgs // TypeDefIndex: 5371
{
	// Fields
	private object result; // 0x28

	// Properties
	public object Result { get; }
	[EditorBrowsable(1)]
	[Browsable(False)]
	public object UserState { get; }

	// Methods

	// RVA: 0x20EF970 Offset: 0x20EEB70 VA: 0x1820EF970
	public void .ctor(object result, Exception error, bool cancelled) { }

	// RVA: 0x20EF9B0 Offset: 0x20EEBB0 VA: 0x1820EF9B0
	public object get_Result() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public object get_UserState() { }
}

// Namespace: System.ComponentModel
public sealed class RunWorkerCompletedEventHandler : MulticastDelegate // TypeDefIndex: 5372
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, RunWorkerCompletedEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, RunWorkerCompletedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
protected abstract class TypeConverter.SimplePropertyDescriptor : PropertyDescriptor // TypeDefIndex: 5373
{
	// Fields
	private Type componentType; // 0x88
	private Type propertyType; // 0x90

	// Properties
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	// RVA: 0x20EFD00 Offset: 0x20EEF00 VA: 0x1820EFD00
	protected void .ctor(Type componentType, string name, Type propertyType) { }

	// RVA: 0x20EFCB0 Offset: 0x20EEEB0 VA: 0x1820EFCB0
	protected void .ctor(Type componentType, string name, Type propertyType, Attribute[] attributes) { }

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870 Slot: 17
	public override Type get_ComponentType() { }

	// RVA: 0x20EFD80 Offset: 0x20EEF80 VA: 0x1820EFD80 Slot: 20
	public override bool get_IsReadOnly() { }

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560 Slot: 21
	public override Type get_PropertyType() { }

	// RVA: 0x20EF9D0 Offset: 0x20EEBD0 VA: 0x1820EF9D0 Slot: 23
	public override bool CanResetValue(object component) { }

	// RVA: 0x20EFB50 Offset: 0x20EED50 VA: 0x1820EFB50 Slot: 29
	public override void ResetValue(object component) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 31
	public override bool ShouldSerializeValue(object component) { }
}

// Namespace: 
[DefaultMember("Item")]
public class TypeConverter.StandardValuesCollection : ICollection, IEnumerable // TypeDefIndex: 5374
{
	// Fields
	private ICollection values; // 0x10
	private Array valueArray; // 0x18

	// Properties
	public int Count { get; }
	public object Item { get; }
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x20EFF30 Offset: 0x20EF130 VA: 0x1820EFF30
	public void .ctor(ICollection values) { }

	// RVA: 0x20EFEC0 Offset: 0x20EF0C0 VA: 0x1820EFEC0
	public int get_Count() { }

	// RVA: 0x20EFFF0 Offset: 0x20EF1F0 VA: 0x1820EFFF0
	public object get_Item(int index) { }

	// RVA: 0x20EFE00 Offset: 0x20EF000 VA: 0x1820EFE00
	public void CopyTo(Array array, int index) { }

	// RVA: 0x20EFE70 Offset: 0x20EF070 VA: 0x1820EFE70
	public IEnumerator GetEnumerator() { }

	// RVA: 0x20EFEC0 Offset: 0x20EF0C0 VA: 0x1820EFEC0 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x20EFE00 Offset: 0x20EF000 VA: 0x1820EFE00 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x20EFE70 Offset: 0x20EF070 VA: 0x1820EFE70 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: System.ComponentModel
[ComVisible(True)]
public class TypeConverter // TypeDefIndex: 5375
{
	// Fields
	private const string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";
	private static bool useCompatibleTypeConversion; // 0x0

	// Properties
	private static bool UseCompatibleTypeConversion { get; }

	// Methods

	// RVA: 0x20F1260 Offset: 0x20F0460 VA: 0x1820F1260
	private static bool get_UseCompatibleTypeConversion() { }

	// RVA: 0x20F0160 Offset: 0x20EF360 VA: 0x1820F0160
	public bool CanConvertFrom(Type sourceType) { }

	// RVA: 0x20F00E0 Offset: 0x20EF2E0 VA: 0x1820F00E0 Slot: 4
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x20F0180 Offset: 0x20EF380 VA: 0x1820F0180
	public bool CanConvertTo(Type destinationType) { }

	// RVA: 0x20F01A0 Offset: 0x20EF3A0 VA: 0x1820F01A0 Slot: 5
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x20F0410 Offset: 0x20EF610 VA: 0x1820F0410
	public object ConvertFrom(object value) { }

	// RVA: 0x20F0490 Offset: 0x20EF690 VA: 0x1820F0490 Slot: 6
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x20F0220 Offset: 0x20EF420 VA: 0x1820F0220
	public object ConvertFromInvariantString(string text) { }

	// RVA: 0x20F02A0 Offset: 0x20EF4A0 VA: 0x1820F02A0
	public object ConvertFromInvariantString(ITypeDescriptorContext context, string text) { }

	// RVA: 0x20F03E0 Offset: 0x20EF5E0 VA: 0x1820F03E0
	public object ConvertFromString(string text) { }

	// RVA: 0x20F0330 Offset: 0x20EF530 VA: 0x1820F0330
	public object ConvertFromString(ITypeDescriptorContext context, string text) { }

	// RVA: 0x20F03C0 Offset: 0x20EF5C0 VA: 0x1820F03C0
	public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text) { }

	// RVA: 0x20F08F0 Offset: 0x20EFAF0 VA: 0x1820F08F0
	public object ConvertTo(object value, Type destinationType) { }

	// RVA: 0x20F0920 Offset: 0x20EFB20 VA: 0x1820F0920 Slot: 7
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x20F0500 Offset: 0x20EF700 VA: 0x1820F0500
	public string ConvertToInvariantString(object value) { }

	// RVA: 0x20F0570 Offset: 0x20EF770 VA: 0x1820F0570
	public string ConvertToInvariantString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x20F05F0 Offset: 0x20EF7F0 VA: 0x1820F05F0
	public string ConvertToString(object value) { }

	// RVA: 0x20F07E0 Offset: 0x20EF9E0 VA: 0x1820F07E0
	public string ConvertToString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x20F06F0 Offset: 0x20EF8F0 VA: 0x1820F06F0
	public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x20F0B60 Offset: 0x20EFD60 VA: 0x1820F0B60
	public object CreateInstance(IDictionary propertyValues) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 8
	public virtual object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	// RVA: 0x20F0B80 Offset: 0x20EFD80 VA: 0x1820F0B80
	protected Exception GetConvertFromException(object value) { }

	// RVA: 0x20F0CD0 Offset: 0x20EFED0 VA: 0x1820F0CD0
	protected Exception GetConvertToException(object value, Type destinationType) { }

	// RVA: 0x20F0E60 Offset: 0x20F0060 VA: 0x1820F0E60
	public bool GetCreateInstanceSupported() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 9
	public virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	// RVA: 0x20F0E80 Offset: 0x20F0080 VA: 0x1820F0E80
	public PropertyDescriptorCollection GetProperties(object value) { }

	// RVA: 0x20F0F80 Offset: 0x20F0180 VA: 0x1820F0F80
	public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 10
	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x1889570 Offset: 0x1888770 VA: 0x181889570
	public bool GetPropertiesSupported() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 11
	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x20F10D0 Offset: 0x20F02D0 VA: 0x1820F10D0
	public ICollection GetStandardValues() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 12
	public virtual TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x20F1090 Offset: 0x20F0290 VA: 0x1820F1090
	public bool GetStandardValuesExclusive() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 13
	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x20F10B0 Offset: 0x20F02B0 VA: 0x1820F10B0
	public bool GetStandardValuesSupported() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 14
	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x20F10F0 Offset: 0x20F02F0 VA: 0x1820F10F0
	public bool IsValid(object value) { }

	// RVA: 0x20F1110 Offset: 0x20F0310 VA: 0x1820F1110 Slot: 15
	public virtual bool IsValid(ITypeDescriptorContext context, object value) { }

	// RVA: 0x20F1220 Offset: 0x20F0420 VA: 0x1820F1220
	protected PropertyDescriptorCollection SortProperties(PropertyDescriptorCollection props, string[] names) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private class TypeDescriptor.AttributeProvider.AttributeTypeDescriptor : CustomTypeDescriptor // TypeDefIndex: 5376
{
	// Fields
	private Attribute[] _attributeArray; // 0x18

	// Methods

	// RVA: 0x20DC830 Offset: 0x20DBA30 VA: 0x1820DC830
	internal void .ctor(Attribute[] attrs, ICustomTypeDescriptor parent) { }

	// RVA: 0x20DC510 Offset: 0x20DB710 VA: 0x1820DC510 Slot: 16
	public override AttributeCollection GetAttributes() { }
}

// Namespace: 
private sealed class TypeDescriptor.AttributeProvider : TypeDescriptionProvider // TypeDefIndex: 5377
{
	// Fields
	private Attribute[] _attrs; // 0x20

	// Methods

	// RVA: 0x20DC4E0 Offset: 0x20DB6E0 VA: 0x1820DC4E0
	internal void .ctor(TypeDescriptionProvider existingProvider, Attribute[] attrs) { }

	// RVA: 0x20DC450 Offset: 0x20DB650 VA: 0x1820DC450 Slot: 11
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }
}

// Namespace: 
private sealed class TypeDescriptor.ComNativeDescriptionProvider.ComNativeTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 5378
{
	// Fields
	private IComNativeDescriptorHandler _handler; // 0x10
	private object _instance; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	internal void .ctor(IComNativeDescriptorHandler handler, object instance) { }

	// RVA: 0x20DCA10 Offset: 0x20DBC10 VA: 0x1820DCA10 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x20DCAD0 Offset: 0x20DBCD0 VA: 0x1820DCAD0 Slot: 5
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x20DCBA0 Offset: 0x20DBDA0 VA: 0x1820DCBA0 Slot: 7
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x20DCC70 Offset: 0x20DBE70 VA: 0x1820DCC70 Slot: 8
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x20DCD40 Offset: 0x20DBF40 VA: 0x1820DCD40 Slot: 9
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x20DCE10 Offset: 0x20DC010 VA: 0x1820DCE10 Slot: 10
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x20DCFB0 Offset: 0x20DC1B0 VA: 0x1820DCFB0 Slot: 11
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x20DCEE0 Offset: 0x20DC0E0 VA: 0x1820DCEE0 Slot: 12
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x20DD0E0 Offset: 0x20DC2E0 VA: 0x1820DD0E0 Slot: 13
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x20DD080 Offset: 0x20DC280 VA: 0x1820DD080 Slot: 14
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 15
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }
}

// Namespace: 
private sealed class TypeDescriptor.ComNativeDescriptionProvider : TypeDescriptionProvider // TypeDefIndex: 5379
{
	// Fields
	private IComNativeDescriptorHandler _handler; // 0x20

	// Properties
	internal IComNativeDescriptorHandler Handler { get; set; }

	// Methods

	// RVA: 0x20DC9E0 Offset: 0x20DBBE0 VA: 0x1820DC9E0
	internal void .ctor(IComNativeDescriptorHandler handler) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal IComNativeDescriptorHandler get_Handler() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	internal void set_Handler(IComNativeDescriptorHandler value) { }

	// RVA: 0x20DC860 Offset: 0x20DBA60 VA: 0x1820DC860 Slot: 11
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }
}

// Namespace: 
private sealed class TypeDescriptor.AttributeFilterCacheItem // TypeDefIndex: 5380
{
	// Fields
	private Attribute[] _filter; // 0x10
	internal ICollection FilteredMembers; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	internal void .ctor(Attribute[] filter, ICollection filteredMembers) { }

	// RVA: 0x20DC3E0 Offset: 0x20DB5E0 VA: 0x1820DC3E0
	internal bool IsValid(Attribute[] filter) { }
}

// Namespace: 
private sealed class TypeDescriptor.FilterCacheItem // TypeDefIndex: 5381
{
	// Fields
	private ITypeDescriptorFilterService _filterService; // 0x10
	internal ICollection FilteredMembers; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	internal void .ctor(ITypeDescriptorFilterService filterService, ICollection filteredMembers) { }

	// RVA: 0x18846C0 Offset: 0x18838C0 VA: 0x1818846C0
	internal bool IsValid(ITypeDescriptorFilterService filterService) { }
}

// Namespace: 
private interface TypeDescriptor.IUnimplemented // TypeDefIndex: 5382
{}

// Namespace: 
private sealed class TypeDescriptor.MemberDescriptorComparer : IComparer // TypeDefIndex: 5383
{
	// Fields
	public static readonly TypeDescriptor.MemberDescriptorComparer Instance; // 0x0

	// Methods

	// RVA: 0x20DF6D0 Offset: 0x20DE8D0 VA: 0x1820DF6D0 Slot: 4
	public int Compare(object left, object right) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x20DF8C0 Offset: 0x20DEAC0 VA: 0x1820DF8C0
	private static void .cctor() { }
}

// Namespace: 
private sealed class TypeDescriptor.MergedTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 5384
{
	// Fields
	private ICustomTypeDescriptor _primary; // 0x10
	private ICustomTypeDescriptor _secondary; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	internal void .ctor(ICustomTypeDescriptor primary, ICustomTypeDescriptor secondary) { }

	// RVA: 0x20E1650 Offset: 0x20E0850 VA: 0x1820E1650 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x20E16C0 Offset: 0x20E08C0 VA: 0x1820E16C0 Slot: 5
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x20E1730 Offset: 0x20E0930 VA: 0x1820E1730 Slot: 6
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x20E17A0 Offset: 0x20E09A0 VA: 0x1820E17A0 Slot: 7
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x20E1810 Offset: 0x20E0A10 VA: 0x1820E1810 Slot: 8
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x20E1880 Offset: 0x20E0A80 VA: 0x1820E1880 Slot: 9
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x20E18F0 Offset: 0x20E0AF0 VA: 0x1820E18F0 Slot: 10
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x20E19F0 Offset: 0x20E0BF0 VA: 0x1820E19F0 Slot: 11
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x20E1A60 Offset: 0x20E0C60 VA: 0x1820E1A60 Slot: 12
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x20E1B60 Offset: 0x20E0D60 VA: 0x1820E1B60 Slot: 13
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x20E1AE0 Offset: 0x20E0CE0 VA: 0x1820E1AE0 Slot: 14
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x20E1BD0 Offset: 0x20E0DD0 VA: 0x1820E1BD0 Slot: 15
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }
}

// Namespace: 
private struct TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 5385
{
	// Fields
	private TypeDescriptor.TypeDescriptionNode _node; // 0x0
	private object _instance; // 0x8

	// Methods

	// RVA: 0x5C3520 Offset: 0x5C2720 VA: 0x1805C3520
	internal void .ctor(TypeDescriptor.TypeDescriptionNode node, object instance) { }

	// RVA: 0x20DD140 Offset: 0x20DC340 VA: 0x1820DD140 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x20DD460 Offset: 0x20DC660 VA: 0x1820DD460 Slot: 5
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x20DD6A0 Offset: 0x20DC8A0 VA: 0x1820DD6A0 Slot: 6
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x20DD950 Offset: 0x20DCB50 VA: 0x1820DD950 Slot: 7
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x20DDC60 Offset: 0x20DCE60 VA: 0x1820DDC60 Slot: 8
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x20DDE10 Offset: 0x20DD010 VA: 0x1820DDE10 Slot: 9
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x20DDFC0 Offset: 0x20DD1C0 VA: 0x1820DDFC0 Slot: 10
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x20DE260 Offset: 0x20DD460 VA: 0x1820DE260 Slot: 11
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x20DE580 Offset: 0x20DD780 VA: 0x1820DE580 Slot: 12
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x20DEB80 Offset: 0x20DDD80 VA: 0x1820DEB80 Slot: 13
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x20DE8A0 Offset: 0x20DDAA0 VA: 0x1820DE8A0 Slot: 14
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x20DEE60 Offset: 0x20DE060 VA: 0x1820DEE60 Slot: 15
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }
}

// Namespace: 
private struct TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 5386
{
	// Fields
	private TypeDescriptor.TypeDescriptionNode _node; // 0x0
	private Type _objectType; // 0x8
	private object _instance; // 0x10

	// Methods

	// RVA: 0xD45610 Offset: 0xD44810 VA: 0x180D45610
	internal void .ctor(TypeDescriptor.TypeDescriptionNode node, Type objectType, object instance) { }

	// RVA: 0x20FE9D0 Offset: 0x20FDBD0 VA: 0x1820FE9D0 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x20FED20 Offset: 0x20FDF20 VA: 0x1820FED20 Slot: 5
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x20FEF10 Offset: 0x20FE110 VA: 0x1820FEF10 Slot: 6
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x20FF0E0 Offset: 0x20FE2E0 VA: 0x1820FF0E0 Slot: 7
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x20FF440 Offset: 0x20FE640 VA: 0x1820FF440 Slot: 8
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x20FF6A0 Offset: 0x20FE8A0 VA: 0x1820FF6A0 Slot: 9
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x20FF900 Offset: 0x20FEB00 VA: 0x1820FF900 Slot: 10
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x20FFED0 Offset: 0x20FF0D0 VA: 0x1820FFED0 Slot: 11
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x20FFB70 Offset: 0x20FED70 VA: 0x1820FFB70 Slot: 12
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x2100590 Offset: 0x20FF790 VA: 0x182100590 Slot: 13
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x2100230 Offset: 0x20FF430 VA: 0x182100230 Slot: 14
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x21008F0 Offset: 0x20FFAF0 VA: 0x1821008F0 Slot: 15
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }
}

// Namespace: 
private sealed class TypeDescriptor.TypeDescriptionNode : TypeDescriptionProvider // TypeDefIndex: 5387
{
	// Fields
	internal TypeDescriptor.TypeDescriptionNode Next; // 0x20
	internal TypeDescriptionProvider Provider; // 0x28

	// Methods

	// RVA: 0x20F1AE0 Offset: 0x20F0CE0 VA: 0x1820F1AE0
	internal void .ctor(TypeDescriptionProvider provider) { }

	// RVA: 0x20F12B0 Offset: 0x20F04B0 VA: 0x1820F12B0 Slot: 4
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x20F1470 Offset: 0x20F0670 VA: 0x1820F1470 Slot: 5
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x20F1500 Offset: 0x20F0700 VA: 0x1820F1500 Slot: 6
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x20F15B0 Offset: 0x20F07B0 VA: 0x1820F15B0 Slot: 7
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x20F1640 Offset: 0x20F0840 VA: 0x1820F1640 Slot: 8
	public override string GetFullComponentName(object component) { }

	// RVA: 0x20F16D0 Offset: 0x20F08D0 VA: 0x1820F16D0 Slot: 9
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x20F17B0 Offset: 0x20F09B0 VA: 0x1820F17B0 Slot: 10
	public override Type GetRuntimeType(Type objectType) { }

	// RVA: 0x20F1880 Offset: 0x20F0A80 VA: 0x1820F1880 Slot: 11
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x20F1A10 Offset: 0x20F0C10 VA: 0x1820F1A10 Slot: 12
	public override bool IsSupportedType(Type type) { }
}

// Namespace: 
[TypeDescriptionProvider("System.Windows.Forms.ComponentModel.Com2Interop.ComNativeDescriptor, System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
private sealed class TypeDescriptor.TypeDescriptorComObject // TypeDefIndex: 5388
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class TypeDescriptor.TypeDescriptorInterface // TypeDefIndex: 5389
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public sealed class TypeDescriptor // TypeDefIndex: 5390
{
	// Fields
	private static WeakHashtable _providerTable; // 0x0
	private static Hashtable _providerTypeTable; // 0x8
	private static Hashtable _defaultProviders; // 0x10
	private static WeakHashtable _associationTable; // 0x18
	private static int _metadataVersion; // 0x20
	private static int _collisionIndex; // 0x24
	private static BooleanSwitch TraceDescriptor; // 0x28
	private const int PIPELINE_ATTRIBUTES = 0;
	private const int PIPELINE_PROPERTIES = 1;
	private const int PIPELINE_EVENTS = 2;
	private static readonly Guid[] _pipelineInitializeKeys; // 0x30
	private static readonly Guid[] _pipelineMergeKeys; // 0x38
	private static readonly Guid[] _pipelineFilterKeys; // 0x40
	private static readonly Guid[] _pipelineAttributeFilterKeys; // 0x48
	private static object _internalSyncObject; // 0x50
	[CompilerGenerated]
	private static RefreshEventHandler Refreshed; // 0x58

	// Properties
	[Obsolete("This property has been deprecated.  Use a type description provider to supply type information for COM types instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public static IComNativeDescriptorHandler ComNativeDescriptorHandler { get; set; }
	[EditorBrowsable(2)]
	public static Type ComObjectType { get; }
	[EditorBrowsable(2)]
	public static Type InterfaceType { get; }
	internal static int MetadataVersion { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x20FC8F0 Offset: 0x20FBAF0 VA: 0x1820FC8F0
	public static IComNativeDescriptorHandler get_ComNativeDescriptorHandler() { }

	// RVA: 0x20FCC30 Offset: 0x20FBE30 VA: 0x1820FCC30
	public static void set_ComNativeDescriptorHandler(IComNativeDescriptorHandler value) { }

	// RVA: 0x20FCA20 Offset: 0x20FBC20 VA: 0x1820FCA20
	public static Type get_ComObjectType() { }

	// RVA: 0x20FCA80 Offset: 0x20FBC80 VA: 0x1820FCA80
	public static Type get_InterfaceType() { }

	// RVA: 0x20FCAE0 Offset: 0x20FBCE0 VA: 0x1820FCAE0
	internal static int get_MetadataVersion() { }

	[CompilerGenerated]
	// RVA: 0x20FC7F0 Offset: 0x20FB9F0 VA: 0x1820FC7F0
	public static void add_Refreshed(RefreshEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x20FCB30 Offset: 0x20FBD30 VA: 0x1820FCB30
	public static void remove_Refreshed(RefreshEventHandler value) { }

	[EditorBrowsable(2)]
	// RVA: 0x20F1B10 Offset: 0x20F0D10 VA: 0x1820F1B10
	public static TypeDescriptionProvider AddAttributes(Type type, Attribute[] attributes) { }

	[EditorBrowsable(2)]
	// RVA: 0x20F1D40 Offset: 0x20F0F40 VA: 0x1820F1D40
	public static TypeDescriptionProvider AddAttributes(object instance, Attribute[] attributes) { }

	[EditorBrowsable(2)]
	// RVA: 0x20F1ED0 Offset: 0x20F10D0 VA: 0x1820F1ED0
	public static void AddEditorTable(Type editorBaseType, Hashtable table) { }

	[EditorBrowsable(2)]
	// RVA: 0x20F2440 Offset: 0x20F1640 VA: 0x1820F2440
	public static void AddProvider(TypeDescriptionProvider provider, Type type) { }

	[EditorBrowsable(2)]
	// RVA: 0x20F2160 Offset: 0x20F1360 VA: 0x1820F2160
	public static void AddProvider(TypeDescriptionProvider provider, object instance) { }

	[EditorBrowsable(2)]
	// RVA: 0x20F2030 Offset: 0x20F1230 VA: 0x1820F2030
	public static void AddProviderTransparent(TypeDescriptionProvider provider, Type type) { }

	[EditorBrowsable(2)]
	// RVA: 0x20F1F30 Offset: 0x20F1130 VA: 0x1820F1F30
	public static void AddProviderTransparent(TypeDescriptionProvider provider, object instance) { }

	// RVA: 0x20F26F0 Offset: 0x20F18F0 VA: 0x1820F26F0
	private static void CheckDefaultProvider(Type type) { }

	[EditorBrowsable(2)]
	// RVA: 0x20F2E60 Offset: 0x20F2060 VA: 0x1820F2E60
	public static void CreateAssociation(object primary, object secondary) { }

	// RVA: 0x20F35D0 Offset: 0x20F27D0 VA: 0x1820F35D0
	public static IDesigner CreateDesigner(IComponent component, Type designerBaseType) { }

	// RVA: 0x20F3940 Offset: 0x20F2B40 VA: 0x1820F3940
	public static EventDescriptor CreateEvent(Type componentType, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x20F39D0 Offset: 0x20F2BD0 VA: 0x1820F39D0
	public static EventDescriptor CreateEvent(Type componentType, EventDescriptor oldEventDescriptor, Attribute[] attributes) { }

	// RVA: 0x20F3A50 Offset: 0x20F2C50 VA: 0x1820F3A50
	public static object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x20F3F20 Offset: 0x20F3120 VA: 0x1820F3F20
	public static PropertyDescriptor CreateProperty(Type componentType, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x20F3D40 Offset: 0x20F2F40 VA: 0x1820F3D40
	public static PropertyDescriptor CreateProperty(Type componentType, PropertyDescriptor oldPropertyDescriptor, Attribute[] attributes) { }

	[Conditional("DEBUG")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private static void DebugValidate(Type type, AttributeCollection attributes, AttributeCollection debugAttributes) { }

	[Conditional("DEBUG")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private static void DebugValidate(AttributeCollection attributes, AttributeCollection debugAttributes) { }

	[Conditional("DEBUG")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private static void DebugValidate(AttributeCollection attributes, Type type) { }

	[Conditional("DEBUG")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private static void DebugValidate(AttributeCollection attributes, object instance, bool noCustomTypeDesc) { }

	[Conditional("DEBUG")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private static void DebugValidate(TypeConverter converter, Type type) { }

	[Conditional("DEBUG")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private static void DebugValidate(TypeConverter converter, object instance, bool noCustomTypeDesc) { }

	[Conditional("DEBUG")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private static void DebugValidate(EventDescriptorCollection events, Type type, Attribute[] attributes) { }

	[Conditional("DEBUG")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private static void DebugValidate(EventDescriptorCollection events, object instance, Attribute[] attributes, bool noCustomTypeDesc) { }

	[Conditional("DEBUG")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private static void DebugValidate(PropertyDescriptorCollection properties, Type type, Attribute[] attributes) { }

	[Conditional("DEBUG")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private static void DebugValidate(PropertyDescriptorCollection properties, object instance, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x20F3FB0 Offset: 0x20F31B0 VA: 0x1820F3FB0
	private static ArrayList FilterMembers(IList members, Attribute[] attributes) { }

	[EditorBrowsable(2)]
	// RVA: 0x20F41C0 Offset: 0x20F33C0 VA: 0x1820F41C0
	public static object GetAssociation(Type type, object primary) { }

	// RVA: 0x20F4A50 Offset: 0x20F3C50 VA: 0x1820F4A50
	public static AttributeCollection GetAttributes(Type componentType) { }

	// RVA: 0x20F4A00 Offset: 0x20F3C00 VA: 0x1820F4A00
	public static AttributeCollection GetAttributes(object component) { }

	[EditorBrowsable(2)]
	// RVA: 0x20F46F0 Offset: 0x20F38F0 VA: 0x1820F46F0
	public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc) { }

	// RVA: 0x20F4B40 Offset: 0x20F3D40 VA: 0x1820F4B40
	internal static IDictionary GetCache(object instance) { }

	// RVA: 0x20F4C80 Offset: 0x20F3E80 VA: 0x1820F4C80
	public static string GetClassName(object component) { }

	[EditorBrowsable(2)]
	// RVA: 0x20F4BF0 Offset: 0x20F3DF0 VA: 0x1820F4BF0
	public static string GetClassName(object component, bool noCustomTypeDesc) { }

	// RVA: 0x20F4D30 Offset: 0x20F3F30 VA: 0x1820F4D30
	public static string GetClassName(Type componentType) { }

	// RVA: 0x20F4DC0 Offset: 0x20F3FC0 VA: 0x1820F4DC0
	public static string GetComponentName(object component) { }

	[EditorBrowsable(2)]
	// RVA: 0x20F4E70 Offset: 0x20F4070 VA: 0x1820F4E70
	public static string GetComponentName(object component, bool noCustomTypeDesc) { }

	// RVA: 0x20F5020 Offset: 0x20F4220 VA: 0x1820F5020
	public static TypeConverter GetConverter(object component) { }

	[EditorBrowsable(2)]
	// RVA: 0x20F4F00 Offset: 0x20F4100 VA: 0x1820F4F00
	public static TypeConverter GetConverter(object component, bool noCustomTypeDesc) { }

	// RVA: 0x20F4F90 Offset: 0x20F4190 VA: 0x1820F4F90
	public static TypeConverter GetConverter(Type type) { }

	// RVA: 0x20F2D30 Offset: 0x20F1F30 VA: 0x1820F2D30
	private static object ConvertFromInvariantString(Type type, string stringValue) { }

	// RVA: 0x20F5170 Offset: 0x20F4370 VA: 0x1820F5170
	public static EventDescriptor GetDefaultEvent(Type componentType) { }

	// RVA: 0x20F5240 Offset: 0x20F4440 VA: 0x1820F5240
	public static EventDescriptor GetDefaultEvent(object component) { }

	[EditorBrowsable(2)]
	// RVA: 0x20F50D0 Offset: 0x20F42D0 VA: 0x1820F50D0
	public static EventDescriptor GetDefaultEvent(object component, bool noCustomTypeDesc) { }

	// RVA: 0x20F5460 Offset: 0x20F4660 VA: 0x1820F5460
	public static PropertyDescriptor GetDefaultProperty(Type componentType) { }

	// RVA: 0x20F5300 Offset: 0x20F4500 VA: 0x1820F5300
	public static PropertyDescriptor GetDefaultProperty(object component) { }

	[EditorBrowsable(2)]
	// RVA: 0x20F53C0 Offset: 0x20F45C0 VA: 0x1820F53C0
	public static PropertyDescriptor GetDefaultProperty(object component, bool noCustomTypeDesc) { }

	// RVA: 0x20F5790 Offset: 0x20F4990 VA: 0x1820F5790
	internal static ICustomTypeDescriptor GetDescriptor(Type type, string typeName) { }

	// RVA: 0x20F5530 Offset: 0x20F4730 VA: 0x1820F5530
	internal static ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc) { }

	// RVA: 0x20F63C0 Offset: 0x20F55C0 VA: 0x1820F63C0
	internal static ICustomTypeDescriptor GetExtendedDescriptor(object component) { }

	// RVA: 0x20F58B0 Offset: 0x20F4AB0 VA: 0x1820F58B0
	public static object GetEditor(object component, Type editorBaseType) { }

	[EditorBrowsable(2)]
	// RVA: 0x20F59F0 Offset: 0x20F4BF0 VA: 0x1820F59F0
	public static object GetEditor(object component, Type editorBaseType, bool noCustomTypeDesc) { }

	// RVA: 0x20F5B10 Offset: 0x20F4D10 VA: 0x1820F5B10
	public static object GetEditor(Type type, Type editorBaseType) { }

	// RVA: 0x20F5FB0 Offset: 0x20F51B0 VA: 0x1820F5FB0
	public static EventDescriptorCollection GetEvents(Type componentType) { }

	// RVA: 0x20F6150 Offset: 0x20F5350 VA: 0x1820F6150
	public static EventDescriptorCollection GetEvents(Type componentType, Attribute[] attributes) { }

	// RVA: 0x20F60A0 Offset: 0x20F52A0 VA: 0x1820F60A0
	public static EventDescriptorCollection GetEvents(object component) { }

	[EditorBrowsable(2)]
	// RVA: 0x20F6360 Offset: 0x20F5560 VA: 0x1820F6360
	public static EventDescriptorCollection GetEvents(object component, bool noCustomTypeDesc) { }

	// RVA: 0x20F60F0 Offset: 0x20F52F0 VA: 0x1820F60F0
	public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes) { }

	[EditorBrowsable(2)]
	// RVA: 0x20F5C30 Offset: 0x20F4E30 VA: 0x1820F5C30
	public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x20F64B0 Offset: 0x20F56B0 VA: 0x1820F64B0
	private static string GetExtenderCollisionSuffix(MemberDescriptor member) { }

	// RVA: 0x20F66F0 Offset: 0x20F58F0 VA: 0x1820F66F0
	public static string GetFullComponentName(object component) { }

	// RVA: 0x20F67E0 Offset: 0x20F59E0 VA: 0x1820F67E0
	private static Type GetNodeForBaseType(Type searchType) { }

	// RVA: 0x20F6D60 Offset: 0x20F5F60 VA: 0x1820F6D60
	public static PropertyDescriptorCollection GetProperties(Type componentType) { }

	// RVA: 0x20F6E50 Offset: 0x20F6050 VA: 0x1820F6E50
	public static PropertyDescriptorCollection GetProperties(Type componentType, Attribute[] attributes) { }

	// RVA: 0x20F71F0 Offset: 0x20F63F0 VA: 0x1820F71F0
	public static PropertyDescriptorCollection GetProperties(object component) { }

	[EditorBrowsable(2)]
	// RVA: 0x20F7060 Offset: 0x20F6260 VA: 0x1820F7060
	public static PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc) { }

	// RVA: 0x20F70D0 Offset: 0x20F62D0 VA: 0x1820F70D0
	public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes) { }

	// RVA: 0x20F7170 Offset: 0x20F6370 VA: 0x1820F7170
	public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x20F6960 Offset: 0x20F5B60 VA: 0x1820F6960
	private static PropertyDescriptorCollection GetPropertiesImpl(object component, Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes) { }

	[EditorBrowsable(2)]
	// RVA: 0x20F7370 Offset: 0x20F6570 VA: 0x1820F7370
	public static TypeDescriptionProvider GetProvider(Type type) { }

	[EditorBrowsable(2)]
	// RVA: 0x20F72D0 Offset: 0x20F64D0 VA: 0x1820F72D0
	public static TypeDescriptionProvider GetProvider(object instance) { }

	// RVA: 0x20F7280 Offset: 0x20F6480 VA: 0x1820F7280
	internal static TypeDescriptionProvider GetProviderRecursive(Type type) { }

	[EditorBrowsable(2)]
	// RVA: 0x20F7530 Offset: 0x20F6730 VA: 0x1820F7530
	public static Type GetReflectionType(Type type) { }

	[EditorBrowsable(2)]
	// RVA: 0x20F7440 Offset: 0x20F6640 VA: 0x1820F7440
	public static Type GetReflectionType(object instance) { }

	// RVA: 0x20F7870 Offset: 0x20F6A70 VA: 0x1820F7870
	private static TypeDescriptor.TypeDescriptionNode NodeFor(Type type) { }

	// RVA: 0x20F78C0 Offset: 0x20F6AC0 VA: 0x1820F78C0
	private static TypeDescriptor.TypeDescriptionNode NodeFor(Type type, bool createDelegator) { }

	// RVA: 0x20F7820 Offset: 0x20F6A20 VA: 0x1820F7820
	private static TypeDescriptor.TypeDescriptionNode NodeFor(object instance) { }

	// RVA: 0x20F7650 Offset: 0x20F6850 VA: 0x1820F7650
	private static TypeDescriptor.TypeDescriptionNode NodeFor(object instance, bool createDelegator) { }

	// RVA: 0x20F7E50 Offset: 0x20F7050 VA: 0x1820F7E50
	private static void NodeRemove(object key, TypeDescriptionProvider provider) { }

	// RVA: 0x20F81E0 Offset: 0x20F73E0 VA: 0x1820F81E0
	private static ICollection PipelineAttributeFilter(int pipelineType, ICollection members, Attribute[] filter, object instance, IDictionary cache) { }

	// RVA: 0x20F8650 Offset: 0x20F7850 VA: 0x1820F8650
	private static ICollection PipelineFilter(int pipelineType, ICollection members, object instance, IDictionary cache) { }

	// RVA: 0x20F9680 Offset: 0x20F8880 VA: 0x1820F9680
	private static ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache) { }

	// RVA: 0x20F9A40 Offset: 0x20F8C40 VA: 0x1820F9A40
	private static ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, object instance, IDictionary cache) { }

	// RVA: 0x20FA460 Offset: 0x20F9660 VA: 0x1820FA460
	private static void RaiseRefresh(object component) { }

	// RVA: 0x20FA510 Offset: 0x20F9710 VA: 0x1820FA510
	private static void RaiseRefresh(Type type) { }

	// RVA: 0x20FAA80 Offset: 0x20F9C80 VA: 0x1820FAA80
	public static void Refresh(object component) { }

	// RVA: 0x20FB2D0 Offset: 0x20FA4D0 VA: 0x1820FB2D0
	private static void Refresh(object component, bool refreshReflectionProvider) { }

	// RVA: 0x20FA5C0 Offset: 0x20F97C0 VA: 0x1820FA5C0
	public static void Refresh(Type type) { }

	// RVA: 0x20FAB90 Offset: 0x20F9D90 VA: 0x1820FAB90
	public static void Refresh(Module module) { }

	// RVA: 0x20FAAD0 Offset: 0x20F9CD0 VA: 0x1820FAAD0
	public static void Refresh(Assembly assembly) { }

	[EditorBrowsable(2)]
	// RVA: 0x20FB960 Offset: 0x20FAB60 VA: 0x1820FB960
	public static void RemoveAssociation(object primary, object secondary) { }

	[EditorBrowsable(2)]
	// RVA: 0x20FBC90 Offset: 0x20FAE90 VA: 0x1820FBC90
	public static void RemoveAssociations(object primary) { }

	[EditorBrowsable(2)]
	// RVA: 0x20FC1A0 Offset: 0x20FB3A0 VA: 0x1820FC1A0
	public static void RemoveProvider(TypeDescriptionProvider provider, Type type) { }

	[EditorBrowsable(2)]
	// RVA: 0x20FC090 Offset: 0x20FB290 VA: 0x1820FC090
	public static void RemoveProvider(TypeDescriptionProvider provider, object instance) { }

	[EditorBrowsable(2)]
	// RVA: 0x20FBEA0 Offset: 0x20FB0A0 VA: 0x1820FBEA0
	public static void RemoveProviderTransparent(TypeDescriptionProvider provider, Type type) { }

	[EditorBrowsable(2)]
	// RVA: 0x20FBD60 Offset: 0x20FAF60 VA: 0x1820FBD60
	public static void RemoveProviderTransparent(TypeDescriptionProvider provider, object instance) { }

	// RVA: 0x20FC2D0 Offset: 0x20FB4D0 VA: 0x1820FC2D0
	private static bool ShouldHideMember(MemberDescriptor member, Attribute attribute) { }

	// RVA: 0x20FC390 Offset: 0x20FB590 VA: 0x1820FC390
	public static void SortDescriptorArray(IList infos) { }

	[Conditional("DEBUG")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal static void Trace(string message, object[] args) { }

	// RVA: 0x20FC460 Offset: 0x20FB660 VA: 0x1820FC460
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Serializable]
public class Win32Exception : ExternalException, ISerializable // TypeDefIndex: 5391
{
	// Fields
	private readonly int nativeErrorCode; // 0x90

	// Properties
	public int NativeErrorCode { get; }

	// Methods

	// RVA: 0x2118770 Offset: 0x2117970 VA: 0x182118770
	public void .ctor() { }

	// RVA: 0x2118920 Offset: 0x2117B20 VA: 0x182118920
	public void .ctor(int error) { }

	// RVA: 0x21188F0 Offset: 0x2117AF0 VA: 0x1821188F0
	public void .ctor(int error, string message) { }

	// RVA: 0x2118870 Offset: 0x2117A70 VA: 0x182118870
	public void .ctor(string message) { }

	// RVA: 0x21186F0 Offset: 0x21178F0 VA: 0x1821186F0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x21187E0 Offset: 0x21179E0 VA: 0x1821187E0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x772210 Offset: 0x771410 VA: 0x180772210
	public int get_NativeErrorCode() { }

	// RVA: 0x2118620 Offset: 0x2117820 VA: 0x182118620 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2117B40 Offset: 0x2116D40 VA: 0x182117B40
	internal static string GetErrorMessage(int error) { }
}

// Namespace: System.ComponentModel
[Usage(128)]
public sealed class NotifyParentPropertyAttribute : Attribute // TypeDefIndex: 5392
{
	// Fields
	public static readonly NotifyParentPropertyAttribute Yes; // 0x0
	public static readonly NotifyParentPropertyAttribute No; // 0x8
	public static readonly NotifyParentPropertyAttribute Default; // 0x10
	private bool notifyParent; // 0x10

	// Properties
	public bool NotifyParent { get; }

	// Methods

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool notifyParent) { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_NotifyParent() { }

	// RVA: 0x21101D0 Offset: 0x210F3D0 VA: 0x1821101D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2110270 Offset: 0x210F470 VA: 0x182110270 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x21102E0 Offset: 0x210F4E0 VA: 0x1821102E0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class ParenthesizePropertyNameAttribute : Attribute // TypeDefIndex: 5393
{
	// Fields
	public static readonly ParenthesizePropertyNameAttribute Default; // 0x0
	private bool needParenthesis; // 0x10

	// Properties
	public bool NeedParenthesis { get; }

	// Methods

	// RVA: 0x18A4A80 Offset: 0x18A3C80 VA: 0x1818A4A80
	public void .ctor() { }

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool needParenthesis) { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_NeedParenthesis() { }

	// RVA: 0x21126B0 Offset: 0x21118B0 VA: 0x1821126B0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2112740 Offset: 0x2111940 VA: 0x182112740 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x21127B0 Offset: 0x21119B0 VA: 0x1821127B0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public enum RefreshProperties // TypeDefIndex: 5394
{
	// Fields
	public int value__; // 0x0
	public const RefreshProperties None = 0;
	public const RefreshProperties All = 1;
	public const RefreshProperties Repaint = 2;
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class RefreshPropertiesAttribute : Attribute // TypeDefIndex: 5395
{
	// Fields
	public static readonly RefreshPropertiesAttribute All; // 0x0
	public static readonly RefreshPropertiesAttribute Repaint; // 0x8
	public static readonly RefreshPropertiesAttribute Default; // 0x10
	private RefreshProperties refresh; // 0x10

	// Properties
	public RefreshProperties RefreshProperties { get; }

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	public void .ctor(RefreshProperties refresh) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public RefreshProperties get_RefreshProperties() { }

	// RVA: 0x2112CC0 Offset: 0x2111EC0 VA: 0x182112CC0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2112D50 Offset: 0x2111F50 VA: 0x182112D50 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x2112DC0 Offset: 0x2111FC0 VA: 0x182112DC0
	private static void .cctor() { }
}

// Namespace: 
private class WeakHashtable.WeakKeyComparer : IEqualityComparer // TypeDefIndex: 5396
{
	// Methods

	// RVA: 0x21179A0 Offset: 0x2116BA0 VA: 0x1821179A0 Slot: 4
	private bool System.Collections.IEqualityComparer.Equals(object x, object y) { }

	// RVA: 0x67F830 Offset: 0x67EA30 VA: 0x18067F830 Slot: 5
	private int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private sealed class WeakHashtable.EqualityWeakReference : WeakReference // TypeDefIndex: 5397
{
	// Fields
	private int _hashCode; // 0x20

	// Methods

	// RVA: 0x2104270 Offset: 0x2103470 VA: 0x182104270
	internal void .ctor(object o) { }

	// RVA: 0x21041E0 Offset: 0x21033E0 VA: 0x1821041E0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.ComponentModel
internal sealed class WeakHashtable : Hashtable // TypeDefIndex: 5398
{
	// Fields
	private static IEqualityComparer _comparer; // 0x0
	private long _lastGlobalMem; // 0x50
	private int _lastHashCount; // 0x58

	// Methods

	// RVA: 0x2117940 Offset: 0x2116B40 VA: 0x182117940
	internal void .ctor() { }

	// RVA: 0x21173B0 Offset: 0x21165B0 VA: 0x1821173B0 Slot: 24
	public override void Clear() { }

	// RVA: 0x21173C0 Offset: 0x21165C0 VA: 0x1821173C0 Slot: 40
	public override void Remove(object key) { }

	// RVA: 0x2117820 Offset: 0x2116A20 VA: 0x182117820
	public void SetWeak(object key, object value) { }

	// RVA: 0x21173D0 Offset: 0x21165D0 VA: 0x1821173D0
	private void ScavengeKeys() { }

	// RVA: 0x21178E0 Offset: 0x2116AE0 VA: 0x1821178E0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
internal sealed class SRCategoryAttribute : CategoryAttribute // TypeDefIndex: 5399
{
	// Methods

	// RVA: 0x2113CC0 Offset: 0x2112EC0 VA: 0x182113CC0
	public void .ctor(string category) { }
}

// Namespace: System.ComponentModel.Design
public class ActiveDesignerEventArgs : EventArgs // TypeDefIndex: 5400
{
	// Fields
	[CompilerGenerated]
	private readonly IDesignerHost <OldDesigner>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly IDesignerHost <NewDesigner>k__BackingField; // 0x18

	// Properties
	public IDesignerHost OldDesigner { get; }
	public IDesignerHost NewDesigner { get; }

	// Methods

	// RVA: 0x20FCE20 Offset: 0x20FC020 VA: 0x1820FCE20
	public void .ctor(IDesignerHost oldDesigner, IDesignerHost newDesigner) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IDesignerHost get_OldDesigner() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public IDesignerHost get_NewDesigner() { }
}

// Namespace: System.ComponentModel.Design
public sealed class ActiveDesignerEventHandler : MulticastDelegate // TypeDefIndex: 5401
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, ActiveDesignerEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, ActiveDesignerEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.ComponentModel.Design
[Serializable]
public class CheckoutException : ExternalException // TypeDefIndex: 5402
{
	// Fields
	private const int E_ABORT = -2147467260;
	public static readonly CheckoutException Canceled; // 0x0

	// Methods

	// RVA: 0x20FD820 Offset: 0x20FCA20 VA: 0x1820FD820
	public void .ctor() { }

	// RVA: 0x20FD810 Offset: 0x20FCA10 VA: 0x1820FD810
	public void .ctor(string message) { }

	// RVA: 0x20FD830 Offset: 0x20FCA30 VA: 0x1820FD830
	public void .ctor(string message, int errorCode) { }

	// RVA: 0x15A17F0 Offset: 0x15A09F0 VA: 0x1815A17F0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x20FD800 Offset: 0x20FCA00 VA: 0x1820FD800
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x20FD790 Offset: 0x20FC990 VA: 0x1820FD790
	private static void .cctor() { }
}

// Namespace: System.ComponentModel.Design
public class CommandID // TypeDefIndex: 5403
{
	// Fields
	[CompilerGenerated]
	private readonly int <ID>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Guid <Guid>k__BackingField; // 0x14

	// Properties
	public virtual int ID { get; }
	public virtual Guid Guid { get; }

	// Methods

	// RVA: 0x20FDD20 Offset: 0x20FCF20 VA: 0x1820FDD20
	public void .ctor(Guid menuGroup, int commandID) { }

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 4
	public virtual int get_ID() { }

	// RVA: 0x20FDA40 Offset: 0x20FCC40 VA: 0x1820FDA40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20FDBC0 Offset: 0x20FCDC0 VA: 0x1820FDBC0 Slot: 2
	public override int GetHashCode() { }

	[CompilerGenerated]
	// RVA: 0x10EBEA0 Offset: 0x10EB0A0 VA: 0x1810EBEA0 Slot: 5
	public virtual Guid get_Guid() { }

	// RVA: 0x20FDC40 Offset: 0x20FCE40 VA: 0x1820FDC40 Slot: 3
	public override string ToString() { }
}

// Namespace: System.ComponentModel.Design
public sealed class ComponentChangedEventArgs : EventArgs // TypeDefIndex: 5404
{
	// Fields
	[CompilerGenerated]
	private readonly object <Component>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly MemberDescriptor <Member>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly object <NewValue>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly object <OldValue>k__BackingField; // 0x28

	// Properties
	public object Component { get; }
	public MemberDescriptor Member { get; }
	public object NewValue { get; }
	public object OldValue { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public object get_Component() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public MemberDescriptor get_Member() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public object get_NewValue() { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public object get_OldValue() { }

	// RVA: 0x20FE0F0 Offset: 0x20FD2F0 VA: 0x1820FE0F0
	public void .ctor(object component, MemberDescriptor member, object oldValue, object newValue) { }
}

// Namespace: System.ComponentModel.Design
public sealed class ComponentChangedEventHandler : MulticastDelegate // TypeDefIndex: 5405
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, ComponentChangedEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, ComponentChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.ComponentModel.Design
public sealed class ComponentChangingEventArgs : EventArgs // TypeDefIndex: 5406
{
	// Fields
	[CompilerGenerated]
	private readonly object <Component>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly MemberDescriptor <Member>k__BackingField; // 0x18

	// Properties
	public object Component { get; }
	public MemberDescriptor Member { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public object get_Component() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public MemberDescriptor get_Member() { }

	// RVA: 0x20FE180 Offset: 0x20FD380 VA: 0x1820FE180
	public void .ctor(object component, MemberDescriptor member) { }
}

// Namespace: System.ComponentModel.Design
public sealed class ComponentChangingEventHandler : MulticastDelegate // TypeDefIndex: 5407
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, ComponentChangingEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, ComponentChangingEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.ComponentModel.Design
public class ComponentEventArgs : EventArgs // TypeDefIndex: 5408
{
	// Fields
	[CompilerGenerated]
	private readonly IComponent <Component>k__BackingField; // 0x10

	// Properties
	public virtual IComponent Component { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public virtual IComponent get_Component() { }

	// RVA: 0x20FE1F0 Offset: 0x20FD3F0 VA: 0x1820FE1F0
	public void .ctor(IComponent component) { }
}

// Namespace: System.ComponentModel.Design
public sealed class ComponentEventHandler : MulticastDelegate // TypeDefIndex: 5409
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, ComponentEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, ComponentEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.ComponentModel.Design
public class ComponentRenameEventArgs : EventArgs // TypeDefIndex: 5410
{
	// Fields
	[CompilerGenerated]
	private readonly object <Component>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <OldName>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <NewName>k__BackingField; // 0x20

	// Properties
	public object Component { get; }
	public virtual string OldName { get; }
	public virtual string NewName { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public object get_Component() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	public virtual string get_OldName() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 5
	public virtual string get_NewName() { }

	// RVA: 0x20FE250 Offset: 0x20FD450 VA: 0x1820FE250
	public void .ctor(object component, string oldName, string newName) { }
}

// Namespace: System.ComponentModel.Design
public sealed class ComponentRenameEventHandler : MulticastDelegate // TypeDefIndex: 5411
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, ComponentRenameEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, ComponentRenameEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.ComponentModel.Design
public abstract class DesignerTransaction : IDisposable // TypeDefIndex: 5412
{
	// Fields
	private bool _suppressedFinalization; // 0x10
	[CompilerGenerated]
	private bool <Canceled>k__BackingField; // 0x11
	[CompilerGenerated]
	private bool <Committed>k__BackingField; // 0x12
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; // 0x18

	// Properties
	public bool Canceled { get; set; }
	public bool Committed { get; set; }
	public string Description { get; }

	// Methods

	// RVA: 0x2102DD0 Offset: 0x2101FD0 VA: 0x182102DD0
	protected void .ctor() { }

	// RVA: 0x81DA00 Offset: 0x81CC00 VA: 0x18081DA00
	protected void .ctor(string description) { }

	[CompilerGenerated]
	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0
	public bool get_Canceled() { }

	[CompilerGenerated]
	// RVA: 0x4BD750 Offset: 0x4BC950 VA: 0x1804BD750
	private void set_Canceled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x7D0D10 Offset: 0x7CFF10 VA: 0x1807D0D10
	public bool get_Committed() { }

	[CompilerGenerated]
	// RVA: 0x7D7A30 Offset: 0x7D6C30 VA: 0x1807D7A30
	private void set_Committed(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Description() { }

	// RVA: 0x2102C60 Offset: 0x2101E60 VA: 0x182102C60
	public void Cancel() { }

	// RVA: 0x2102CE0 Offset: 0x2101EE0 VA: 0x182102CE0
	public void Commit() { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void OnCancel();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void OnCommit();

	// RVA: 0x1B492C0 Offset: 0x1B484C0 VA: 0x181B492C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2102D60 Offset: 0x2101F60 VA: 0x182102D60 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2102C60 Offset: 0x2101E60 VA: 0x182102C60 Slot: 7
	protected virtual void Dispose(bool disposing) { }
}

// Namespace: System.ComponentModel.Design
public class DesignerTransactionCloseEventArgs : EventArgs // TypeDefIndex: 5413
{
	// Fields
	[CompilerGenerated]
	private readonly bool <TransactionCommitted>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly bool <LastTransaction>k__BackingField; // 0x11

	// Properties
	public bool TransactionCommitted { get; }
	public bool LastTransaction { get; }

	// Methods

	[Obsolete("This constructor is obsolete. Use DesignerTransactionCloseEventArgs(bool, bool) instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x2102B90 Offset: 0x2101D90 VA: 0x182102B90
	public void .ctor(bool commit) { }

	// RVA: 0x2102BF0 Offset: 0x2101DF0 VA: 0x182102BF0
	public void .ctor(bool commit, bool lastTransaction) { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_TransactionCommitted() { }

	[CompilerGenerated]
	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0
	public bool get_LastTransaction() { }
}

// Namespace: System.ComponentModel.Design
public sealed class DesignerTransactionCloseEventHandler : MulticastDelegate // TypeDefIndex: 5414
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, DesignerTransactionCloseEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, DesignerTransactionCloseEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.ComponentModel.Design
public class DesignerVerb : MenuCommand // TypeDefIndex: 5415
{
	// Properties
	public string Description { get; set; }
	public string Text { get; }

	// Methods

	// RVA: 0x2103950 Offset: 0x2102B50 VA: 0x182103950
	public void .ctor(string text, EventHandler handler) { }

	// RVA: 0x2103830 Offset: 0x2102A30 VA: 0x182103830
	public void .ctor(string text, EventHandler handler, CommandID startCommandID) { }

	// RVA: 0x2103AA0 Offset: 0x2102CA0 VA: 0x182103AA0
	public string get_Description() { }

	// RVA: 0x2103C20 Offset: 0x2102E20 VA: 0x182103C20
	public void set_Description(string value) { }

	// RVA: 0x2103B60 Offset: 0x2102D60 VA: 0x182103B60
	public string get_Text() { }

	// RVA: 0x2103640 Offset: 0x2102840 VA: 0x182103640 Slot: 3
	public override string ToString() { }
}

// Namespace: System.ComponentModel.Design
[DefaultMember("Item")]
public class DesignerVerbCollection : CollectionBase // TypeDefIndex: 5416
{
	// Properties
	public DesignerVerb Item { get; set; }

	// Methods

	// RVA: 0x154B280 Offset: 0x154A480 VA: 0x18154B280
	public void .ctor() { }

	// RVA: 0x21033F0 Offset: 0x21025F0 VA: 0x1821033F0
	public void .ctor(DesignerVerb[] value) { }

	// RVA: 0x21034F0 Offset: 0x21026F0 VA: 0x1821034F0
	public DesignerVerb get_Item(int index) { }

	// RVA: 0x21035C0 Offset: 0x21027C0 VA: 0x1821035C0
	public void set_Item(int index, DesignerVerb value) { }

	// RVA: 0x21030D0 Offset: 0x21022D0 VA: 0x1821030D0
	public int Add(DesignerVerb value) { }

	// RVA: 0x2102FD0 Offset: 0x21021D0 VA: 0x182102FD0
	public void AddRange(DesignerVerb[] value) { }

	// RVA: 0x2102E20 Offset: 0x2102020 VA: 0x182102E20
	public void AddRange(DesignerVerbCollection value) { }

	// RVA: 0x21032A0 Offset: 0x21024A0 VA: 0x1821032A0
	public void Insert(int index, DesignerVerb value) { }

	// RVA: 0x2103230 Offset: 0x2102430 VA: 0x182103230
	public int IndexOf(DesignerVerb value) { }

	// RVA: 0x2103140 Offset: 0x2102340 VA: 0x182103140
	public bool Contains(DesignerVerb value) { }

	// RVA: 0x2103320 Offset: 0x2102520 VA: 0x182103320
	public void Remove(DesignerVerb value) { }

	// RVA: 0x21031B0 Offset: 0x21023B0 VA: 0x1821031B0
	public void CopyTo(DesignerVerb[] array, int index) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 20
	protected override void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 21
	protected override void OnInsert(int index, object value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 22
	protected override void OnClear() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 23
	protected override void OnRemove(int index, object value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 24
	protected override void OnValidate(object value) { }
}

// Namespace: System.ComponentModel.Design
public class DesigntimeLicenseContext : LicenseContext // TypeDefIndex: 5417
{
	// Fields
	internal Hashtable savedLicenseKeys; // 0x10

	// Properties
	public override LicenseUsageMode UsageMode { get; }

	// Methods

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10 Slot: 5
	public override LicenseUsageMode get_UsageMode() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	public override string GetSavedLicenseKey(Type type, Assembly resourceAssembly) { }

	// RVA: 0x2104110 Offset: 0x2103310 VA: 0x182104110 Slot: 8
	public override void SetSavedLicenseKey(Type type, string key) { }

	// RVA: 0x2104180 Offset: 0x2103380 VA: 0x182104180
	public void .ctor() { }
}

// Namespace: System.ComponentModel.Design
internal class RuntimeLicenseContext : LicenseContext // TypeDefIndex: 5418
{
	// Fields
	private static TraceSwitch s_runtimeLicenseContextSwitch; // 0x0
	private const int ReadBlock = 400;
	internal Hashtable savedLicenseKeys; // 0x10

	// Methods

	// RVA: 0x21135D0 Offset: 0x21127D0 VA: 0x1821135D0
	private string GetLocalPath(string fileName) { }

	// RVA: 0x2113650 Offset: 0x2112850 VA: 0x182113650 Slot: 6
	public override string GetSavedLicenseKey(Type type, Assembly resourceAssembly) { }

	// RVA: 0x21133C0 Offset: 0x21125C0 VA: 0x1821133C0
	private Stream CaseInsensitiveManifestResourceStreamLookup(Assembly satellite, string name) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x2113C30 Offset: 0x2112E30 VA: 0x182113C30
	private static void .cctor() { }
}

// Namespace: System.ComponentModel.Design
public class DesigntimeLicenseContextSerializer // TypeDefIndex: 5419
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x2103F50 Offset: 0x2103150 VA: 0x182103F50
	public static void Serialize(Stream o, string cryptoKey, DesigntimeLicenseContext context) { }

	// RVA: 0x2103CB0 Offset: 0x2102EB0 VA: 0x182103CB0
	internal static void Deserialize(Stream o, string cryptoKey, RuntimeLicenseContext context) { }
}

// Namespace: System.ComponentModel.Design
[DefaultMember("Item")]
public class DesignerCollection : ICollection, IEnumerable // TypeDefIndex: 5420
{
	// Fields
	private IList _designers; // 0x10

	// Properties
	public int Count { get; }
	public virtual IDesignerHost Item { get; }
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x2100C60 Offset: 0x20FFE60 VA: 0x182100C60
	public void .ctor(IDesignerHost[] designers) { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(IList designers) { }

	// RVA: 0x2100C10 Offset: 0x20FFE10 VA: 0x182100C10
	public int get_Count() { }

	// RVA: 0x2100CE0 Offset: 0x20FFEE0 VA: 0x182100CE0 Slot: 9
	public virtual IDesignerHost get_Item(int index) { }

	// RVA: 0x2100B50 Offset: 0x20FFD50 VA: 0x182100B50
	public IEnumerator GetEnumerator() { }

	// RVA: 0x2100C10 Offset: 0x20FFE10 VA: 0x182100C10 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x2100BA0 Offset: 0x20FFDA0 VA: 0x182100BA0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x2100B50 Offset: 0x20FFD50 VA: 0x182100B50 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: System.ComponentModel.Design
public class DesignerEventArgs : EventArgs // TypeDefIndex: 5421
{
	// Fields
	[CompilerGenerated]
	private readonly IDesignerHost <Designer>k__BackingField; // 0x10

	// Properties
	public IDesignerHost Designer { get; }

	// Methods

	// RVA: 0x2100D70 Offset: 0x20FFF70 VA: 0x182100D70
	public void .ctor(IDesignerHost host) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IDesignerHost get_Designer() { }
}

// Namespace: System.ComponentModel.Design
public sealed class DesignerEventHandler : MulticastDelegate // TypeDefIndex: 5422
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, DesignerEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, DesignerEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.ComponentModel.Design
public enum HelpContextType // TypeDefIndex: 5423
{
	// Fields
	public int value__; // 0x0
	public const HelpContextType Ambient = 0;
	public const HelpContextType Window = 1;
	public const HelpContextType Selection = 2;
	public const HelpContextType ToolWindowSelection = 3;
}

// Namespace: System.ComponentModel.Design
[Usage(32767, AllowMultiple = False, Inherited = False)]
[Serializable]
public sealed class HelpKeywordAttribute : Attribute // TypeDefIndex: 5424
{
	// Fields
	public static readonly HelpKeywordAttribute Default; // 0x0
	[CompilerGenerated]
	private readonly string <HelpKeyword>k__BackingField; // 0x10

	// Properties
	public string HelpKeyword { get; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x2105050 Offset: 0x2104250 VA: 0x182105050
	public void .ctor(string keyword) { }

	// RVA: 0x21050D0 Offset: 0x21042D0 VA: 0x1821050D0
	public void .ctor(Type t) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_HelpKeyword() { }

	// RVA: 0x2104ED0 Offset: 0x21040D0 VA: 0x182104ED0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2104F70 Offset: 0x2104170 VA: 0x182104F70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2104F80 Offset: 0x2104180 VA: 0x182104F80 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x2104FF0 Offset: 0x21041F0 VA: 0x182104FF0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel.Design
public enum HelpKeywordType // TypeDefIndex: 5425
{
	// Fields
	public int value__; // 0x0
	public const HelpKeywordType F1Keyword = 0;
	public const HelpKeywordType GeneralKeyword = 1;
	public const HelpKeywordType FilterKeyword = 2;
}

// Namespace: System.ComponentModel.Design
public interface IComponentChangeService // TypeDefIndex: 5426
{
	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_ComponentAdded(ComponentEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_ComponentAdded(ComponentEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_ComponentAdding(ComponentEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_ComponentAdding(ComponentEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void add_ComponentChanged(ComponentChangedEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void remove_ComponentChanged(ComponentChangedEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract void add_ComponentChanging(ComponentChangingEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 7
	public abstract void remove_ComponentChanging(ComponentChangingEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 8
	public abstract void add_ComponentRemoved(ComponentEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 9
	public abstract void remove_ComponentRemoved(ComponentEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 10
	public abstract void add_ComponentRemoving(ComponentEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 11
	public abstract void remove_ComponentRemoving(ComponentEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 12
	public abstract void add_ComponentRename(ComponentRenameEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 13
	public abstract void remove_ComponentRename(ComponentRenameEventHandler value);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void OnComponentChanged(object component, MemberDescriptor member, object oldValue, object newValue);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void OnComponentChanging(object component, MemberDescriptor member);
}

// Namespace: System.ComponentModel.Design
public interface IComponentDiscoveryService // TypeDefIndex: 5427
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ICollection GetComponentTypes(IDesignerHost designerHost, Type baseType);
}

// Namespace: System.ComponentModel.Design
public interface IComponentInitializer // TypeDefIndex: 5428
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void InitializeExistingComponent(IDictionary defaultValues);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void InitializeNewComponent(IDictionary defaultValues);
}

// Namespace: System.ComponentModel.Design
public interface IDesigner : IDisposable // TypeDefIndex: 5429
{
	// Properties
	public abstract IComponent Component { get; }
	public abstract DesignerVerbCollection Verbs { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IComponent get_Component();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract DesignerVerbCollection get_Verbs();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void DoDefaultAction();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Initialize(IComponent component);
}

// Namespace: System.ComponentModel.Design
public interface IDesignerEventService // TypeDefIndex: 5430
{
	// Properties
	public abstract IDesignerHost ActiveDesigner { get; }
	public abstract DesignerCollection Designers { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDesignerHost get_ActiveDesigner();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract DesignerCollection get_Designers();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_ActiveDesignerChanged(ActiveDesignerEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_ActiveDesignerChanged(ActiveDesignerEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void add_DesignerCreated(DesignerEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void remove_DesignerCreated(DesignerEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract void add_DesignerDisposed(DesignerEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 7
	public abstract void remove_DesignerDisposed(DesignerEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 8
	public abstract void add_SelectionChanged(EventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 9
	public abstract void remove_SelectionChanged(EventHandler value);
}

// Namespace: System.ComponentModel.Design
public interface IDesignerFilter // TypeDefIndex: 5431
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void PostFilterAttributes(IDictionary attributes);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void PostFilterEvents(IDictionary events);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void PostFilterProperties(IDictionary properties);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void PreFilterAttributes(IDictionary attributes);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void PreFilterEvents(IDictionary events);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void PreFilterProperties(IDictionary properties);
}

// Namespace: System.ComponentModel.Design
public interface IDesignerHost : IServiceContainer, IServiceProvider // TypeDefIndex: 5432
{
	// Properties
	public abstract bool Loading { get; }
	public abstract bool InTransaction { get; }
	public abstract IContainer Container { get; }
	public abstract IComponent RootComponent { get; }
	public abstract string RootComponentClassName { get; }
	public abstract string TransactionDescription { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_Loading();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_InTransaction();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IContainer get_Container();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IComponent get_RootComponent();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_RootComponentClassName();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_TransactionDescription();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract void add_Activated(EventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 7
	public abstract void remove_Activated(EventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 8
	public abstract void add_Deactivated(EventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 9
	public abstract void remove_Deactivated(EventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 10
	public abstract void add_LoadComplete(EventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 11
	public abstract void remove_LoadComplete(EventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 12
	public abstract void add_TransactionClosed(DesignerTransactionCloseEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 13
	public abstract void remove_TransactionClosed(DesignerTransactionCloseEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 14
	public abstract void add_TransactionClosing(DesignerTransactionCloseEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 15
	public abstract void remove_TransactionClosing(DesignerTransactionCloseEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 16
	public abstract void add_TransactionOpened(EventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 17
	public abstract void remove_TransactionOpened(EventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 18
	public abstract void add_TransactionOpening(EventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 19
	public abstract void remove_TransactionOpening(EventHandler value);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void Activate();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract IComponent CreateComponent(Type componentClass);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract IComponent CreateComponent(Type componentClass, string name);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract DesignerTransaction CreateTransaction();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract DesignerTransaction CreateTransaction(string description);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void DestroyComponent(IComponent component);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract IDesigner GetDesigner(IComponent component);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract Type GetType(string typeName);
}

// Namespace: System.ComponentModel.Design
public interface IDesignerHostTransactionState // TypeDefIndex: 5433
{
	// Properties
	public abstract bool IsClosingTransaction { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsClosingTransaction();
}

// Namespace: System.ComponentModel.Design
public interface IDesignerOptionService // TypeDefIndex: 5434
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetOptionValue(string pageName, string valueName);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetOptionValue(string pageName, string valueName, object value);
}

// Namespace: System.ComponentModel.Design
public interface IDictionaryService // TypeDefIndex: 5435
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetKey(object value);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object GetValue(object key);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetValue(object key, object value);
}

// Namespace: System.ComponentModel.Design
public interface IEventBindingService // TypeDefIndex: 5436
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string CreateUniqueMethodName(IComponent component, EventDescriptor e);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ICollection GetCompatibleMethods(EventDescriptor e);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract EventDescriptor GetEvent(PropertyDescriptor property);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract PropertyDescriptorCollection GetEventProperties(EventDescriptorCollection events);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract PropertyDescriptor GetEventProperty(EventDescriptor e);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool ShowCode();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool ShowCode(int lineNumber);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool ShowCode(IComponent component, EventDescriptor e);
}

// Namespace: System.ComponentModel.Design
public interface IExtenderListService // TypeDefIndex: 5437
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IExtenderProvider[] GetExtenderProviders();
}

// Namespace: System.ComponentModel.Design
public interface IExtenderProviderService // TypeDefIndex: 5438
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void AddExtenderProvider(IExtenderProvider provider);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void RemoveExtenderProvider(IExtenderProvider provider);
}

// Namespace: System.ComponentModel.Design
public interface IHelpService // TypeDefIndex: 5439
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void AddContextAttribute(string name, string value, HelpKeywordType keywordType);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ClearContextAttributes();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IHelpService CreateLocalContext(HelpContextType contextType);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void RemoveContextAttribute(string name, string value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void RemoveLocalContext(IHelpService localContext);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void ShowHelpFromKeyword(string helpKeyword);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void ShowHelpFromUrl(string helpUrl);
}

// Namespace: System.ComponentModel.Design
public interface IInheritanceService // TypeDefIndex: 5440
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void AddInheritedComponents(IComponent component, IContainer container);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract InheritanceAttribute GetInheritanceAttribute(IComponent component);
}

// Namespace: System.ComponentModel.Design
public interface IMenuCommandService // TypeDefIndex: 5441
{
	// Properties
	public abstract DesignerVerbCollection Verbs { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DesignerVerbCollection get_Verbs();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void AddCommand(MenuCommand command);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void AddVerb(DesignerVerb verb);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract MenuCommand FindCommand(CommandID commandID);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool GlobalInvoke(CommandID commandID);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void RemoveCommand(MenuCommand command);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void RemoveVerb(DesignerVerb verb);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ShowContextMenu(CommandID menuID, int x, int y);
}

// Namespace: System.ComponentModel.Design
public interface IReferenceService // TypeDefIndex: 5442
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IComponent GetComponent(object reference);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object GetReference(string name);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string GetName(object reference);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract object[] GetReferences();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object[] GetReferences(Type baseType);
}

// Namespace: System.ComponentModel.Design
public interface IResourceService // TypeDefIndex: 5443
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IResourceReader GetResourceReader(CultureInfo info);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IResourceWriter GetResourceWriter(CultureInfo info);
}

// Namespace: System.ComponentModel.Design
public interface IRootDesigner : IDesigner, IDisposable // TypeDefIndex: 5444
{
	// Properties
	public abstract ViewTechnology[] SupportedTechnologies { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ViewTechnology[] get_SupportedTechnologies();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object GetView(ViewTechnology technology);
}

// Namespace: System.ComponentModel.Design
public interface ISelectionService // TypeDefIndex: 5445
{
	// Properties
	public abstract object PrimarySelection { get; }
	public abstract int SelectionCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_PrimarySelection();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_SelectionCount();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_SelectionChanged(EventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_SelectionChanged(EventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void add_SelectionChanging(EventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void remove_SelectionChanging(EventHandler value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool GetComponentSelected(object component);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract ICollection GetSelectedComponents();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void SetSelectedComponents(ICollection components);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void SetSelectedComponents(ICollection components, SelectionTypes selectionType);
}

// Namespace: System.ComponentModel.Design
public interface IServiceContainer : IServiceProvider // TypeDefIndex: 5446
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void AddService(Type serviceType, object serviceInstance);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void AddService(Type serviceType, object serviceInstance, bool promote);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void AddService(Type serviceType, ServiceCreatorCallback callback);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void AddService(Type serviceType, ServiceCreatorCallback callback, bool promote);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void RemoveService(Type serviceType);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void RemoveService(Type serviceType, bool promote);
}

// Namespace: System.ComponentModel.Design
public interface ITreeDesigner : IDesigner, IDisposable // TypeDefIndex: 5447
{
	// Properties
	public abstract ICollection Children { get; }
	public abstract IDesigner Parent { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ICollection get_Children();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDesigner get_Parent();
}

// Namespace: System.ComponentModel.Design
public interface ITypeDescriptorFilterService // TypeDefIndex: 5448
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool FilterAttributes(IComponent component, IDictionary attributes);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool FilterEvents(IComponent component, IDictionary events);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool FilterProperties(IComponent component, IDictionary properties);
}

// Namespace: System.ComponentModel.Design
public interface ITypeDiscoveryService // TypeDefIndex: 5449
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ICollection GetTypes(Type baseType, bool excludeGlobalTypes);
}

// Namespace: System.ComponentModel.Design
public interface ITypeResolutionService // TypeDefIndex: 5450
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Assembly GetAssembly(AssemblyName name);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Assembly GetAssembly(AssemblyName name, bool throwOnError);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Type GetType(string name);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Type GetType(string name, bool throwOnError);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Type GetType(string name, bool throwOnError, bool ignoreCase);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void ReferenceAssembly(AssemblyName name);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string GetPathOfAssembly(AssemblyName name);
}

// Namespace: System.ComponentModel.Design
public class MenuCommand // TypeDefIndex: 5451
{
	// Fields
	private EventHandler _execHandler; // 0x10
	private int _status; // 0x18
	private IDictionary _properties; // 0x20
	private const int ENABLED = 2;
	private const int INVISIBLE = 16;
	private const int CHECKED = 4;
	private const int SUPPORTED = 1;
	[CompilerGenerated]
	private EventHandler CommandChanged; // 0x28
	[CompilerGenerated]
	private readonly CommandID <CommandID>k__BackingField; // 0x30

	// Properties
	public virtual bool Checked { get; set; }
	public virtual bool Enabled { get; set; }
	public virtual IDictionary Properties { get; }
	public virtual bool Supported { get; set; }
	public virtual bool Visible { get; set; }
	public virtual CommandID CommandID { get; }
	public virtual int OleStatus { get; }

	// Methods

	// RVA: 0x2109780 Offset: 0x2108980 VA: 0x182109780
	public void .ctor(EventHandler handler, CommandID command) { }

	// RVA: 0x1F90980 Offset: 0x1F8FB80 VA: 0x181F90980 Slot: 4
	public virtual bool get_Checked() { }

	// RVA: 0x2109980 Offset: 0x2108B80 VA: 0x182109980 Slot: 5
	public virtual void set_Checked(bool value) { }

	// RVA: 0x2109860 Offset: 0x2108A60 VA: 0x182109860 Slot: 6
	public virtual bool get_Enabled() { }

	// RVA: 0x21099A0 Offset: 0x2108BA0 VA: 0x1821099A0 Slot: 7
	public virtual void set_Enabled(bool value) { }

	// RVA: 0x21095D0 Offset: 0x21087D0 VA: 0x1821095D0
	private void SetStatus(int mask, bool value) { }

	// RVA: 0x2109870 Offset: 0x2108A70 VA: 0x182109870 Slot: 8
	public virtual IDictionary get_Properties() { }

	// RVA: 0x168D730 Offset: 0x168C930 VA: 0x18168D730 Slot: 9
	public virtual bool get_Supported() { }

	// RVA: 0x21099C0 Offset: 0x2108BC0 VA: 0x1821099C0 Slot: 10
	public virtual void set_Supported(bool value) { }

	// RVA: 0x21098D0 Offset: 0x2108AD0 VA: 0x1821098D0 Slot: 11
	public virtual bool get_Visible() { }

	// RVA: 0x21099E0 Offset: 0x2108BE0 VA: 0x1821099E0 Slot: 12
	public virtual void set_Visible(bool value) { }

	[CompilerGenerated]
	// RVA: 0x21097C0 Offset: 0x21089C0 VA: 0x1821097C0
	public void add_CommandChanged(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x21098E0 Offset: 0x2108AE0 VA: 0x1821098E0
	public void remove_CommandChanged(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 13
	public virtual CommandID get_CommandID() { }

	// RVA: 0x21094F0 Offset: 0x21086F0 VA: 0x1821094F0 Slot: 14
	public virtual void Invoke() { }

	// RVA: 0x19B4EE0 Offset: 0x19B40E0 VA: 0x1819B4EE0 Slot: 15
	public virtual void Invoke(object arg) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 16
	public virtual int get_OleStatus() { }

	// RVA: 0x1DD8910 Offset: 0x1DD7B10 VA: 0x181DD8910 Slot: 17
	protected virtual void OnCommandChanged(EventArgs e) { }

	// RVA: 0x2109670 Offset: 0x2108870 VA: 0x182109670 Slot: 3
	public override string ToString() { }
}

// Namespace: System.ComponentModel.Design
[Flags]
public enum SelectionTypes // TypeDefIndex: 5452
{
	// Fields
	public int value__; // 0x0
	public const SelectionTypes Auto = 1;
	[Obsolete("This value has been deprecated. Use SelectionTypes.Auto instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public const SelectionTypes Normal = 1;
	public const SelectionTypes Replace = 2;
	[Obsolete("This value has been deprecated.  It is no longer supported. http://go.microsoft.com/fwlink/?linkid=14202")]
	public const SelectionTypes MouseDown = 4;
	[Obsolete("This value has been deprecated.  It is no longer supported. http://go.microsoft.com/fwlink/?linkid=14202")]
	public const SelectionTypes MouseUp = 8;
	[Obsolete("This value has been deprecated. Use SelectionTypes.Primary instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public const SelectionTypes Click = 16;
	public const SelectionTypes Primary = 16;
	public const SelectionTypes Toggle = 32;
	public const SelectionTypes Add = 64;
	public const SelectionTypes Remove = 128;
	[Obsolete("This value has been deprecated. Use Enum class methods to determine valid values, or use a type converter. http://go.microsoft.com/fwlink/?linkid=14202")]
	public const SelectionTypes Valid = 31;
}

// Namespace: System.ComponentModel.Design
public sealed class ServiceCreatorCallback : MulticastDelegate // TypeDefIndex: 5453
{
	// Methods

	// RVA: 0x2115030 Offset: 0x2114230 VA: 0x182115030
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual object Invoke(IServiceContainer container, Type serviceType) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IServiceContainer container, Type serviceType, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual object EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private sealed class ServiceContainer.ServiceCollection.EmbeddedTypeAwareTypeComparer<T> : IEqualityComparer<Type> // TypeDefIndex: 5454
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(Type x, Type y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10DCB50 Offset: 0x10DBD50 VA: 0x1810DCB50
	|-ServiceContainer.ServiceCollection.EmbeddedTypeAwareTypeComparer<object>.Equals
	|-ServiceContainer.ServiceCollection.EmbeddedTypeAwareTypeComparer<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public int GetHashCode(Type obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10DCB90 Offset: 0x10DBD90 VA: 0x1810DCB90
	|-ServiceContainer.ServiceCollection.EmbeddedTypeAwareTypeComparer<object>.GetHashCode
	|-ServiceContainer.ServiceCollection.EmbeddedTypeAwareTypeComparer<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-ServiceContainer.ServiceCollection.EmbeddedTypeAwareTypeComparer<object>..ctor
	|-ServiceContainer.ServiceCollection.EmbeddedTypeAwareTypeComparer<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
private sealed class ServiceContainer.ServiceCollection<T> : Dictionary<Type, T> // TypeDefIndex: 5455
{
	// Fields
	private static ServiceContainer.ServiceCollection.EmbeddedTypeAwareTypeComparer<T> s_serviceTypeComparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF1EF0 Offset: 0xBF10F0 VA: 0x180BF1EF0
	|-ServiceContainer.ServiceCollection<object>..ctor
	|
	|-RVA: 0xBF1F80 Offset: 0xBF1180 VA: 0x180BF1F80
	|-ServiceContainer.ServiceCollection<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF1E00 Offset: 0xBF1000 VA: 0x180BF1E00
	|-ServiceContainer.ServiceCollection<object>..cctor
	|
	|-RVA: 0xBF1CF0 Offset: 0xBF0EF0 VA: 0x180BF1CF0
	|-ServiceContainer.ServiceCollection<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.ComponentModel.Design
public class ServiceContainer : IServiceContainer, IServiceProvider, IDisposable // TypeDefIndex: 5456
{
	// Fields
	private ServiceContainer.ServiceCollection<object> _services; // 0x10
	private IServiceProvider _parentProvider; // 0x18
	private static Type[] s_defaultServices; // 0x0
	private static TraceSwitch s_TRACESERVICE; // 0x8

	// Properties
	private IServiceContainer Container { get; }
	protected virtual Type[] DefaultServices { get; }
	private ServiceContainer.ServiceCollection<object> Services { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x81DA00 Offset: 0x81CC00 VA: 0x18081DA00
	public void .ctor(IServiceProvider parentProvider) { }

	// RVA: 0x2114E90 Offset: 0x2114090 VA: 0x182114E90
	private IServiceContainer get_Container() { }

	// RVA: 0x2114F70 Offset: 0x2114170 VA: 0x182114F70 Slot: 12
	protected virtual Type[] get_DefaultServices() { }

	// RVA: 0x2114FC0 Offset: 0x21141C0 VA: 0x182114FC0
	private ServiceContainer.ServiceCollection<object> get_Services() { }

	// RVA: 0x2114340 Offset: 0x2113540 VA: 0x182114340 Slot: 4
	public void AddService(Type serviceType, object serviceInstance) { }

	// RVA: 0x2114370 Offset: 0x2113570 VA: 0x182114370 Slot: 13
	public virtual void AddService(Type serviceType, object serviceInstance, bool promote) { }

	// RVA: 0x16CD110 Offset: 0x16CC310 VA: 0x1816CD110 Slot: 6
	public void AddService(Type serviceType, ServiceCreatorCallback callback) { }

	// RVA: 0x2114070 Offset: 0x2113270 VA: 0x182114070 Slot: 14
	public virtual void AddService(Type serviceType, ServiceCreatorCallback callback, bool promote) { }

	// RVA: 0x21148E0 Offset: 0x2113AE0 VA: 0x1821148E0 Slot: 11
	public void Dispose() { }

	// RVA: 0x2114720 Offset: 0x2113920 VA: 0x182114720 Slot: 15
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2114900 Offset: 0x2113B00 VA: 0x182114900 Slot: 16
	public virtual object GetService(Type serviceType) { }

	// RVA: 0x1A73CA0 Offset: 0x1A72EA0 VA: 0x181A73CA0 Slot: 8
	public void RemoveService(Type serviceType) { }

	// RVA: 0x2114B40 Offset: 0x2113D40 VA: 0x182114B40 Slot: 17
	public virtual void RemoveService(Type serviceType, bool promote) { }

	// RVA: 0x2114CE0 Offset: 0x2113EE0 VA: 0x182114CE0
	private static void .cctor() { }
}

// Namespace: 
private static class StandardCommands.VSStandardCommands // TypeDefIndex: 5457
{
	// Fields
	internal const int cmdidAlignBottom = 1;
	internal const int cmdidAlignHorizontalCenters = 2;
	internal const int cmdidAlignLeft = 3;
	internal const int cmdidAlignRight = 4;
	internal const int cmdidAlignToGrid = 5;
	internal const int cmdidAlignTop = 6;
	internal const int cmdidAlignVerticalCenters = 7;
	internal const int cmdidArrangeBottom = 8;
	internal const int cmdidArrangeRight = 9;
	internal const int cmdidBringForward = 10;
	internal const int cmdidBringToFront = 11;
	internal const int cmdidCenterHorizontally = 12;
	internal const int cmdidCenterVertically = 13;
	internal const int cmdidCode = 14;
	internal const int cmdidCopy = 15;
	internal const int cmdidCut = 16;
	internal const int cmdidDelete = 17;
	internal const int cmdidFontName = 18;
	internal const int cmdidFontSize = 19;
	internal const int cmdidGroup = 20;
	internal const int cmdidHorizSpaceConcatenate = 21;
	internal const int cmdidHorizSpaceDecrease = 22;
	internal const int cmdidHorizSpaceIncrease = 23;
	internal const int cmdidHorizSpaceMakeEqual = 24;
	internal const int cmdidLockControls = 369;
	internal const int cmdidInsertObject = 25;
	internal const int cmdidPaste = 26;
	internal const int cmdidPrint = 27;
	internal const int cmdidProperties = 28;
	internal const int cmdidRedo = 29;
	internal const int cmdidMultiLevelRedo = 30;
	internal const int cmdidSelectAll = 31;
	internal const int cmdidSendBackward = 32;
	internal const int cmdidSendToBack = 33;
	internal const int cmdidShowTable = 34;
	internal const int cmdidSizeToControl = 35;
	internal const int cmdidSizeToControlHeight = 36;
	internal const int cmdidSizeToControlWidth = 37;
	internal const int cmdidSizeToFit = 38;
	internal const int cmdidSizeToGrid = 39;
	internal const int cmdidSnapToGrid = 40;
	internal const int cmdidTabOrder = 41;
	internal const int cmdidToolbox = 42;
	internal const int cmdidUndo = 43;
	internal const int cmdidMultiLevelUndo = 44;
	internal const int cmdidUngroup = 45;
	internal const int cmdidVertSpaceConcatenate = 46;
	internal const int cmdidVertSpaceDecrease = 47;
	internal const int cmdidVertSpaceIncrease = 48;
	internal const int cmdidVertSpaceMakeEqual = 49;
	internal const int cmdidZoomPercent = 50;
	internal const int cmdidBackColor = 51;
	internal const int cmdidBold = 52;
	internal const int cmdidBorderColor = 53;
	internal const int cmdidBorderDashDot = 54;
	internal const int cmdidBorderDashDotDot = 55;
	internal const int cmdidBorderDashes = 56;
	internal const int cmdidBorderDots = 57;
	internal const int cmdidBorderShortDashes = 58;
	internal const int cmdidBorderSolid = 59;
	internal const int cmdidBorderSparseDots = 60;
	internal const int cmdidBorderWidth1 = 61;
	internal const int cmdidBorderWidth2 = 62;
	internal const int cmdidBorderWidth3 = 63;
	internal const int cmdidBorderWidth4 = 64;
	internal const int cmdidBorderWidth5 = 65;
	internal const int cmdidBorderWidth6 = 66;
	internal const int cmdidBorderWidthHairline = 67;
	internal const int cmdidFlat = 68;
	internal const int cmdidForeColor = 69;
	internal const int cmdidItalic = 70;
	internal const int cmdidJustifyCenter = 71;
	internal const int cmdidJustifyGeneral = 72;
	internal const int cmdidJustifyLeft = 73;
	internal const int cmdidJustifyRight = 74;
	internal const int cmdidRaised = 75;
	internal const int cmdidSunken = 76;
	internal const int cmdidUnderline = 77;
	internal const int cmdidChiseled = 78;
	internal const int cmdidEtched = 79;
	internal const int cmdidShadowed = 80;
	internal const int cmdidCompDebug1 = 81;
	internal const int cmdidCompDebug2 = 82;
	internal const int cmdidCompDebug3 = 83;
	internal const int cmdidCompDebug4 = 84;
	internal const int cmdidCompDebug5 = 85;
	internal const int cmdidCompDebug6 = 86;
	internal const int cmdidCompDebug7 = 87;
	internal const int cmdidCompDebug8 = 88;
	internal const int cmdidCompDebug9 = 89;
	internal const int cmdidCompDebug10 = 90;
	internal const int cmdidCompDebug11 = 91;
	internal const int cmdidCompDebug12 = 92;
	internal const int cmdidCompDebug13 = 93;
	internal const int cmdidCompDebug14 = 94;
	internal const int cmdidCompDebug15 = 95;
	internal const int cmdidExistingSchemaEdit = 96;
	internal const int cmdidFind = 97;
	internal const int cmdidGetZoom = 98;
	internal const int cmdidQueryOpenDesign = 99;
	internal const int cmdidQueryOpenNew = 100;
	internal const int cmdidSingleTableDesign = 101;
	internal const int cmdidSingleTableNew = 102;
	internal const int cmdidShowGrid = 103;
	internal const int cmdidNewTable = 104;
	internal const int cmdidCollapsedView = 105;
	internal const int cmdidFieldView = 106;
	internal const int cmdidVerifySQL = 107;
	internal const int cmdidHideTable = 108;
	internal const int cmdidPrimaryKey = 109;
	internal const int cmdidSave = 110;
	internal const int cmdidSaveAs = 111;
	internal const int cmdidSortAscending = 112;
	internal const int cmdidSortDescending = 113;
	internal const int cmdidAppendQuery = 114;
	internal const int cmdidCrosstabQuery = 115;
	internal const int cmdidDeleteQuery = 116;
	internal const int cmdidMakeTableQuery = 117;
	internal const int cmdidSelectQuery = 118;
	internal const int cmdidUpdateQuery = 119;
	internal const int cmdidParameters = 120;
	internal const int cmdidTotals = 121;
	internal const int cmdidViewCollapsed = 122;
	internal const int cmdidViewFieldList = 123;
	internal const int cmdidViewKeys = 124;
	internal const int cmdidViewGrid = 125;
	internal const int cmdidInnerJoin = 126;
	internal const int cmdidRightOuterJoin = 127;
	internal const int cmdidLeftOuterJoin = 128;
	internal const int cmdidFullOuterJoin = 129;
	internal const int cmdidUnionJoin = 130;
	internal const int cmdidShowSQLPane = 131;
	internal const int cmdidShowGraphicalPane = 132;
	internal const int cmdidShowDataPane = 133;
	internal const int cmdidShowQBEPane = 134;
	internal const int cmdidSelectAllFields = 135;
	internal const int cmdidOLEObjectMenuButton = 136;
	internal const int cmdidObjectVerbList0 = 137;
	internal const int cmdidObjectVerbList1 = 138;
	internal const int cmdidObjectVerbList2 = 139;
	internal const int cmdidObjectVerbList3 = 140;
	internal const int cmdidObjectVerbList4 = 141;
	internal const int cmdidObjectVerbList5 = 142;
	internal const int cmdidObjectVerbList6 = 143;
	internal const int cmdidObjectVerbList7 = 144;
	internal const int cmdidObjectVerbList8 = 145;
	internal const int cmdidObjectVerbList9 = 146;
	internal const int cmdidConvertObject = 147;
	internal const int cmdidCustomControl = 148;
	internal const int cmdidCustomizeItem = 149;
	internal const int cmdidRename = 150;
	internal const int cmdidImport = 151;
	internal const int cmdidNewPage = 152;
	internal const int cmdidMove = 153;
	internal const int cmdidCancel = 154;
	internal const int cmdidFont = 155;
	internal const int cmdidExpandLinks = 156;
	internal const int cmdidExpandImages = 157;
	internal const int cmdidExpandPages = 158;
	internal const int cmdidRefocusDiagram = 159;
	internal const int cmdidTransitiveClosure = 160;
	internal const int cmdidCenterDiagram = 161;
	internal const int cmdidZoomIn = 162;
	internal const int cmdidZoomOut = 163;
	internal const int cmdidRemoveFilter = 164;
	internal const int cmdidHidePane = 165;
	internal const int cmdidDeleteTable = 166;
	internal const int cmdidDeleteRelationship = 167;
	internal const int cmdidRemove = 168;
	internal const int cmdidJoinLeftAll = 169;
	internal const int cmdidJoinRightAll = 170;
	internal const int cmdidAddToOutput = 171;
	internal const int cmdidOtherQuery = 172;
	internal const int cmdidGenerateChangeScript = 173;
	internal const int cmdidSaveSelection = 174;
	internal const int cmdidAutojoinCurrent = 175;
	internal const int cmdidAutojoinAlways = 176;
	internal const int cmdidEditPage = 177;
	internal const int cmdidViewLinks = 178;
	internal const int cmdidStop = 179;
	internal const int cmdidPause = 180;
	internal const int cmdidResume = 181;
	internal const int cmdidFilterDiagram = 182;
	internal const int cmdidShowAllObjects = 183;
	internal const int cmdidShowApplications = 184;
	internal const int cmdidShowOtherObjects = 185;
	internal const int cmdidShowPrimRelationships = 186;
	internal const int cmdidExpand = 187;
	internal const int cmdidCollapse = 188;
	internal const int cmdidRefresh = 189;
	internal const int cmdidLayout = 190;
	internal const int cmdidShowResources = 191;
	internal const int cmdidInsertHTMLWizard = 192;
	internal const int cmdidShowDownloads = 193;
	internal const int cmdidShowExternals = 194;
	internal const int cmdidShowInBoundLinks = 195;
	internal const int cmdidShowOutBoundLinks = 196;
	internal const int cmdidShowInAndOutBoundLinks = 197;
	internal const int cmdidPreview = 198;
	internal const int cmdidOpen = 261;
	internal const int cmdidOpenWith = 199;
	internal const int cmdidShowPages = 200;
	internal const int cmdidRunQuery = 201;
	internal const int cmdidClearQuery = 202;
	internal const int cmdidRecordFirst = 203;
	internal const int cmdidRecordLast = 204;
	internal const int cmdidRecordNext = 205;
	internal const int cmdidRecordPrevious = 206;
	internal const int cmdidRecordGoto = 207;
	internal const int cmdidRecordNew = 208;
	internal const int cmdidInsertNewMenu = 209;
	internal const int cmdidInsertSeparator = 210;
	internal const int cmdidEditMenuNames = 211;
	internal const int cmdidDebugExplorer = 212;
	internal const int cmdidDebugProcesses = 213;
	internal const int cmdidViewThreadsWindow = 214;
	internal const int cmdidWindowUIList = 215;
	internal const int cmdidNewProject = 216;
	internal const int cmdidOpenProject = 217;
	internal const int cmdidOpenSolution = 218;
	internal const int cmdidCloseSolution = 219;
	internal const int cmdidFileNew = 221;
	internal const int cmdidFileOpen = 222;
	internal const int cmdidFileClose = 223;
	internal const int cmdidSaveSolution = 224;
	internal const int cmdidSaveSolutionAs = 225;
	internal const int cmdidSaveProjectItemAs = 226;
	internal const int cmdidPageSetup = 227;
	internal const int cmdidPrintPreview = 228;
	internal const int cmdidExit = 229;
	internal const int cmdidReplace = 230;
	internal const int cmdidGoto = 231;
	internal const int cmdidPropertyPages = 232;
	internal const int cmdidFullScreen = 233;
	internal const int cmdidProjectExplorer = 234;
	internal const int cmdidPropertiesWindow = 235;
	internal const int cmdidTaskListWindow = 236;
	internal const int cmdidOutputWindow = 237;
	internal const int cmdidObjectBrowser = 238;
	internal const int cmdidDocOutlineWindow = 239;
	internal const int cmdidImmediateWindow = 240;
	internal const int cmdidWatchWindow = 241;
	internal const int cmdidLocalsWindow = 242;
	internal const int cmdidCallStack = 243;
	internal const int cmdidAutosWindow = 747;
	internal const int cmdidThisWindow = 748;
	internal const int cmdidAddNewItem = 220;
	internal const int cmdidAddExistingItem = 244;
	internal const int cmdidNewFolder = 245;
	internal const int cmdidSetStartupProject = 246;
	internal const int cmdidProjectSettings = 247;
	internal const int cmdidProjectReferences = 367;
	internal const int cmdidStepInto = 248;
	internal const int cmdidStepOver = 249;
	internal const int cmdidStepOut = 250;
	internal const int cmdidRunToCursor = 251;
	internal const int cmdidAddWatch = 252;
	internal const int cmdidEditWatch = 253;
	internal const int cmdidQuickWatch = 254;
	internal const int cmdidToggleBreakpoint = 255;
	internal const int cmdidClearBreakpoints = 256;
	internal const int cmdidShowBreakpoints = 257;
	internal const int cmdidSetNextStatement = 258;
	internal const int cmdidShowNextStatement = 259;
	internal const int cmdidEditBreakpoint = 260;
	internal const int cmdidDetachDebugger = 262;
	internal const int cmdidCustomizeKeyboard = 263;
	internal const int cmdidToolsOptions = 264;
	internal const int cmdidNewWindow = 265;
	internal const int cmdidSplit = 266;
	internal const int cmdidCascade = 267;
	internal const int cmdidTileHorz = 268;
	internal const int cmdidTileVert = 269;
	internal const int cmdidTechSupport = 270;
	internal const int cmdidAbout = 271;
	internal const int cmdidDebugOptions = 272;
	internal const int cmdidDeleteWatch = 274;
	internal const int cmdidCollapseWatch = 275;
	internal const int cmdidPbrsToggleStatus = 282;
	internal const int cmdidPropbrsHide = 283;
	internal const int cmdidDockingView = 284;
	internal const int cmdidHideActivePane = 285;
	internal const int cmdidPaneNextTab = 286;
	internal const int cmdidPanePrevTab = 287;
	internal const int cmdidPaneCloseToolWindow = 288;
	internal const int cmdidPaneActivateDocWindow = 289;
	internal const int cmdidDockingViewFloater = 291;
	internal const int cmdidAutoHideWindow = 292;
	internal const int cmdidMoveToDropdownBar = 293;
	internal const int cmdidFindCmd = 294;
	internal const int cmdidStart = 295;
	internal const int cmdidRestart = 296;
	internal const int cmdidAddinManager = 297;
	internal const int cmdidMultiLevelUndoList = 298;
	internal const int cmdidMultiLevelRedoList = 299;
	internal const int cmdidToolboxAddTab = 300;
	internal const int cmdidToolboxDeleteTab = 301;
	internal const int cmdidToolboxRenameTab = 302;
	internal const int cmdidToolboxTabMoveUp = 303;
	internal const int cmdidToolboxTabMoveDown = 304;
	internal const int cmdidToolboxRenameItem = 305;
	internal const int cmdidToolboxListView = 306;
	internal const int cmdidWindowUIGetList = 308;
	internal const int cmdidInsertValuesQuery = 309;
	internal const int cmdidShowProperties = 310;
	internal const int cmdidThreadSuspend = 311;
	internal const int cmdidThreadResume = 312;
	internal const int cmdidThreadSetFocus = 313;
	internal const int cmdidDisplayRadix = 314;
	internal const int cmdidOpenProjectItem = 315;
	internal const int cmdidPaneNextPane = 316;
	internal const int cmdidPanePrevPane = 317;
	internal const int cmdidClearPane = 318;
	internal const int cmdidGotoErrorTag = 319;
	internal const int cmdidTaskListSortByCategory = 320;
	internal const int cmdidTaskListSortByFileLine = 321;
	internal const int cmdidTaskListSortByPriority = 322;
	internal const int cmdidTaskListSortByDefaultSort = 323;
	internal const int cmdidTaskListFilterByNothing = 325;
	internal const int cmdidTaskListFilterByCategoryCodeSense = 326;
	internal const int cmdidTaskListFilterByCategoryCompiler = 327;
	internal const int cmdidTaskListFilterByCategoryComment = 328;
	internal const int cmdidToolboxAddItem = 329;
	internal const int cmdidToolboxReset = 330;
	internal const int cmdidSaveProjectItem = 331;
	internal const int cmdidViewForm = 332;
	internal const int cmdidViewCode = 333;
	internal const int cmdidPreviewInBrowser = 334;
	internal const int cmdidBrowseWith = 336;
	internal const int cmdidSearchSetCombo = 307;
	internal const int cmdidSearchCombo = 337;
	internal const int cmdidEditLabel = 338;
	internal const int cmdidExceptions = 339;
	internal const int cmdidToggleSelMode = 341;
	internal const int cmdidToggleInsMode = 342;
	internal const int cmdidLoadUnloadedProject = 343;
	internal const int cmdidUnloadLoadedProject = 344;
	internal const int cmdidElasticColumn = 345;
	internal const int cmdidHideColumn = 346;
	internal const int cmdidTaskListPreviousView = 347;
	internal const int cmdidZoomDialog = 348;
	internal const int cmdidFindNew = 349;
	internal const int cmdidFindMatchCase = 350;
	internal const int cmdidFindWholeWord = 351;
	internal const int cmdidFindSimplePattern = 276;
	internal const int cmdidFindRegularExpression = 352;
	internal const int cmdidFindBackwards = 353;
	internal const int cmdidFindInSelection = 354;
	internal const int cmdidFindStop = 355;
	internal const int cmdidFindHelp = 356;
	internal const int cmdidFindInFiles = 277;
	internal const int cmdidReplaceInFiles = 278;
	internal const int cmdidNextLocation = 279;
	internal const int cmdidPreviousLocation = 280;
	internal const int cmdidTaskListNextError = 357;
	internal const int cmdidTaskListPrevError = 358;
	internal const int cmdidTaskListFilterByCategoryUser = 359;
	internal const int cmdidTaskListFilterByCategoryShortcut = 360;
	internal const int cmdidTaskListFilterByCategoryHTML = 361;
	internal const int cmdidTaskListFilterByCurrentFile = 362;
	internal const int cmdidTaskListFilterByChecked = 363;
	internal const int cmdidTaskListFilterByUnchecked = 364;
	internal const int cmdidTaskListSortByDescription = 365;
	internal const int cmdidTaskListSortByChecked = 366;
	internal const int cmdidStartNoDebug = 368;
	internal const int cmdidFindNext = 370;
	internal const int cmdidFindPrev = 371;
	internal const int cmdidFindSelectedNext = 372;
	internal const int cmdidFindSelectedPrev = 373;
	internal const int cmdidSearchGetList = 374;
	internal const int cmdidInsertBreakpoint = 375;
	internal const int cmdidEnableBreakpoint = 376;
	internal const int cmdidF1Help = 377;
	internal const int cmdidPropSheetOrProperties = 397;
	internal const int cmdidTshellStep = 398;
	internal const int cmdidTshellRun = 399;
	internal const int cmdidMarkerCmd0 = 400;
	internal const int cmdidMarkerCmd1 = 401;
	internal const int cmdidMarkerCmd2 = 402;
	internal const int cmdidMarkerCmd3 = 403;
	internal const int cmdidMarkerCmd4 = 404;
	internal const int cmdidMarkerCmd5 = 405;
	internal const int cmdidMarkerCmd6 = 406;
	internal const int cmdidMarkerCmd7 = 407;
	internal const int cmdidMarkerCmd8 = 408;
	internal const int cmdidMarkerCmd9 = 409;
	internal const int cmdidMarkerLast = 409;
	internal const int cmdidMarkerEnd = 410;
	internal const int cmdidReloadProject = 412;
	internal const int cmdidUnloadProject = 413;
	internal const int cmdidDetachAttachOutline = 420;
	internal const int cmdidShowHideOutline = 421;
	internal const int cmdidSyncOutline = 422;
	internal const int cmdidRunToCallstCursor = 423;
	internal const int cmdidNoCmdsAvailable = 424;
	internal const int cmdidContextWindow = 427;
	internal const int cmdidAlias = 428;
	internal const int cmdidGotoCommandLine = 429;
	internal const int cmdidEvaluateExpression = 430;
	internal const int cmdidImmediateMode = 431;
	internal const int cmdidEvaluateStatement = 432;
	internal const int cmdidFindResultWindow1 = 433;
	internal const int cmdidFindResultWindow2 = 434;
	internal const int cmdidWindow1 = 570;
	internal const int cmdidWindow2 = 571;
	internal const int cmdidWindow3 = 572;
	internal const int cmdidWindow4 = 573;
	internal const int cmdidWindow5 = 574;
	internal const int cmdidWindow6 = 575;
	internal const int cmdidWindow7 = 576;
	internal const int cmdidWindow8 = 577;
	internal const int cmdidWindow9 = 578;
	internal const int cmdidWindow10 = 579;
	internal const int cmdidWindow11 = 580;
	internal const int cmdidWindow12 = 581;
	internal const int cmdidWindow13 = 582;
	internal const int cmdidWindow14 = 583;
	internal const int cmdidWindow15 = 584;
	internal const int cmdidWindow16 = 585;
	internal const int cmdidWindow17 = 586;
	internal const int cmdidWindow18 = 587;
	internal const int cmdidWindow19 = 588;
	internal const int cmdidWindow20 = 589;
	internal const int cmdidWindow21 = 590;
	internal const int cmdidWindow22 = 591;
	internal const int cmdidWindow23 = 592;
	internal const int cmdidWindow24 = 593;
	internal const int cmdidWindow25 = 594;
	internal const int cmdidMoreWindows = 595;
	internal const int cmdidTaskListTaskHelp = 598;
	internal const int cmdidClassView = 599;
	internal const int cmdidMRUProj1 = 600;
	internal const int cmdidMRUProj2 = 601;
	internal const int cmdidMRUProj3 = 602;
	internal const int cmdidMRUProj4 = 603;
	internal const int cmdidMRUProj5 = 604;
	internal const int cmdidMRUProj6 = 605;
	internal const int cmdidMRUProj7 = 606;
	internal const int cmdidMRUProj8 = 607;
	internal const int cmdidMRUProj9 = 608;
	internal const int cmdidMRUProj10 = 609;
	internal const int cmdidMRUProj11 = 610;
	internal const int cmdidMRUProj12 = 611;
	internal const int cmdidMRUProj13 = 612;
	internal const int cmdidMRUProj14 = 613;
	internal const int cmdidMRUProj15 = 614;
	internal const int cmdidMRUProj16 = 615;
	internal const int cmdidMRUProj17 = 616;
	internal const int cmdidMRUProj18 = 617;
	internal const int cmdidMRUProj19 = 618;
	internal const int cmdidMRUProj20 = 619;
	internal const int cmdidMRUProj21 = 620;
	internal const int cmdidMRUProj22 = 621;
	internal const int cmdidMRUProj23 = 622;
	internal const int cmdidMRUProj24 = 623;
	internal const int cmdidMRUProj25 = 624;
	internal const int cmdidSplitNext = 625;
	internal const int cmdidSplitPrev = 626;
	internal const int cmdidCloseAllDocuments = 627;
	internal const int cmdidNextDocument = 628;
	internal const int cmdidPrevDocument = 629;
	internal const int cmdidTool1 = 630;
	internal const int cmdidTool2 = 631;
	internal const int cmdidTool3 = 632;
	internal const int cmdidTool4 = 633;
	internal const int cmdidTool5 = 634;
	internal const int cmdidTool6 = 635;
	internal const int cmdidTool7 = 636;
	internal const int cmdidTool8 = 637;
	internal const int cmdidTool9 = 638;
	internal const int cmdidTool10 = 639;
	internal const int cmdidTool11 = 640;
	internal const int cmdidTool12 = 641;
	internal const int cmdidTool13 = 642;
	internal const int cmdidTool14 = 643;
	internal const int cmdidTool15 = 644;
	internal const int cmdidTool16 = 645;
	internal const int cmdidTool17 = 646;
	internal const int cmdidTool18 = 647;
	internal const int cmdidTool19 = 648;
	internal const int cmdidTool20 = 649;
	internal const int cmdidTool21 = 650;
	internal const int cmdidTool22 = 651;
	internal const int cmdidTool23 = 652;
	internal const int cmdidTool24 = 653;
	internal const int cmdidExternalCommands = 654;
	internal const int cmdidPasteNextTBXCBItem = 655;
	internal const int cmdidToolboxShowAllTabs = 656;
	internal const int cmdidProjectDependencies = 657;
	internal const int cmdidCloseDocument = 658;
	internal const int cmdidToolboxSortItems = 659;
	internal const int cmdidViewBarView1 = 660;
	internal const int cmdidViewBarView2 = 661;
	internal const int cmdidViewBarView3 = 662;
	internal const int cmdidViewBarView4 = 663;
	internal const int cmdidViewBarView5 = 664;
	internal const int cmdidViewBarView6 = 665;
	internal const int cmdidViewBarView7 = 666;
	internal const int cmdidViewBarView8 = 667;
	internal const int cmdidViewBarView9 = 668;
	internal const int cmdidViewBarView10 = 669;
	internal const int cmdidViewBarView11 = 670;
	internal const int cmdidViewBarView12 = 671;
	internal const int cmdidViewBarView13 = 672;
	internal const int cmdidViewBarView14 = 673;
	internal const int cmdidViewBarView15 = 674;
	internal const int cmdidViewBarView16 = 675;
	internal const int cmdidViewBarView17 = 676;
	internal const int cmdidViewBarView18 = 677;
	internal const int cmdidViewBarView19 = 678;
	internal const int cmdidViewBarView20 = 679;
	internal const int cmdidViewBarView21 = 680;
	internal const int cmdidViewBarView22 = 681;
	internal const int cmdidViewBarView23 = 682;
	internal const int cmdidViewBarView24 = 683;
	internal const int cmdidSolutionCfg = 684;
	internal const int cmdidSolutionCfgGetList = 685;
	internal const int cmdidManageIndexes = 675;
	internal const int cmdidManageRelationships = 676;
	internal const int cmdidManageConstraints = 677;
	internal const int cmdidTaskListCustomView1 = 678;
	internal const int cmdidTaskListCustomView2 = 679;
	internal const int cmdidTaskListCustomView3 = 680;
	internal const int cmdidTaskListCustomView4 = 681;
	internal const int cmdidTaskListCustomView5 = 682;
	internal const int cmdidTaskListCustomView6 = 683;
	internal const int cmdidTaskListCustomView7 = 684;
	internal const int cmdidTaskListCustomView8 = 685;
	internal const int cmdidTaskListCustomView9 = 686;
	internal const int cmdidTaskListCustomView10 = 687;
	internal const int cmdidTaskListCustomView11 = 688;
	internal const int cmdidTaskListCustomView12 = 689;
	internal const int cmdidTaskListCustomView13 = 690;
	internal const int cmdidTaskListCustomView14 = 691;
	internal const int cmdidTaskListCustomView15 = 692;
	internal const int cmdidTaskListCustomView16 = 693;
	internal const int cmdidTaskListCustomView17 = 694;
	internal const int cmdidTaskListCustomView18 = 695;
	internal const int cmdidTaskListCustomView19 = 696;
	internal const int cmdidTaskListCustomView20 = 697;
	internal const int cmdidTaskListCustomView21 = 698;
	internal const int cmdidTaskListCustomView22 = 699;
	internal const int cmdidTaskListCustomView23 = 700;
	internal const int cmdidTaskListCustomView24 = 701;
	internal const int cmdidTaskListCustomView25 = 702;
	internal const int cmdidTaskListCustomView26 = 703;
	internal const int cmdidTaskListCustomView27 = 704;
	internal const int cmdidTaskListCustomView28 = 705;
	internal const int cmdidTaskListCustomView29 = 706;
	internal const int cmdidTaskListCustomView30 = 707;
	internal const int cmdidTaskListCustomView31 = 708;
	internal const int cmdidTaskListCustomView32 = 709;
	internal const int cmdidTaskListCustomView33 = 710;
	internal const int cmdidTaskListCustomView34 = 711;
	internal const int cmdidTaskListCustomView35 = 712;
	internal const int cmdidTaskListCustomView36 = 713;
	internal const int cmdidTaskListCustomView37 = 714;
	internal const int cmdidTaskListCustomView38 = 715;
	internal const int cmdidTaskListCustomView39 = 716;
	internal const int cmdidTaskListCustomView40 = 717;
	internal const int cmdidTaskListCustomView41 = 718;
	internal const int cmdidTaskListCustomView42 = 719;
	internal const int cmdidTaskListCustomView43 = 720;
	internal const int cmdidTaskListCustomView44 = 721;
	internal const int cmdidTaskListCustomView45 = 722;
	internal const int cmdidTaskListCustomView46 = 723;
	internal const int cmdidTaskListCustomView47 = 724;
	internal const int cmdidTaskListCustomView48 = 725;
	internal const int cmdidTaskListCustomView49 = 726;
	internal const int cmdidTaskListCustomView50 = 727;
	internal const int cmdidObjectSearch = 728;
	internal const int cmdidCommandWindow = 729;
	internal const int cmdidCommandWindowMarkMode = 730;
	internal const int cmdidLogCommandWindow = 731;
	internal const int cmdidShell = 732;
	internal const int cmdidSingleChar = 733;
	internal const int cmdidZeroOrMore = 734;
	internal const int cmdidOneOrMore = 735;
	internal const int cmdidBeginLine = 736;
	internal const int cmdidEndLine = 737;
	internal const int cmdidBeginWord = 738;
	internal const int cmdidEndWord = 739;
	internal const int cmdidCharInSet = 740;
	internal const int cmdidCharNotInSet = 741;
	internal const int cmdidOr = 742;
	internal const int cmdidEscape = 743;
	internal const int cmdidTagExp = 744;
	internal const int cmdidPatternMatchHelp = 745;
	internal const int cmdidRegExList = 746;
	internal const int cmdidDebugReserved1 = 747;
	internal const int cmdidDebugReserved2 = 748;
	internal const int cmdidDebugReserved3 = 749;
	internal const int cmdidWildZeroOrMore = 754;
	internal const int cmdidWildSingleChar = 755;
	internal const int cmdidWildSingleDigit = 756;
	internal const int cmdidWildCharInSet = 757;
	internal const int cmdidWildCharNotInSet = 758;
	internal const int cmdidFindWhatText = 759;
	internal const int cmdidTaggedExp1 = 760;
	internal const int cmdidTaggedExp2 = 761;
	internal const int cmdidTaggedExp3 = 762;
	internal const int cmdidTaggedExp4 = 763;
	internal const int cmdidTaggedExp5 = 764;
	internal const int cmdidTaggedExp6 = 765;
	internal const int cmdidTaggedExp7 = 766;
	internal const int cmdidTaggedExp8 = 767;
	internal const int cmdidTaggedExp9 = 768;
	internal const int cmdidEditorWidgetClick = 769;
	internal const int cmdidCmdWinUpdateAC = 770;
	internal const int cmdidSlnCfgMgr = 771;
	internal const int cmdidAddNewProject = 772;
	internal const int cmdidAddExistingProject = 773;
	internal const int cmdidAddNewSolutionItem = 774;
	internal const int cmdidAddExistingSolutionItem = 775;
	internal const int cmdidAutoHideContext1 = 776;
	internal const int cmdidAutoHideContext2 = 777;
	internal const int cmdidAutoHideContext3 = 778;
	internal const int cmdidAutoHideContext4 = 779;
	internal const int cmdidAutoHideContext5 = 780;
	internal const int cmdidAutoHideContext6 = 781;
	internal const int cmdidAutoHideContext7 = 782;
	internal const int cmdidAutoHideContext8 = 783;
	internal const int cmdidAutoHideContext9 = 784;
	internal const int cmdidAutoHideContext10 = 785;
	internal const int cmdidAutoHideContext11 = 786;
	internal const int cmdidAutoHideContext12 = 787;
	internal const int cmdidAutoHideContext13 = 788;
	internal const int cmdidAutoHideContext14 = 789;
	internal const int cmdidAutoHideContext15 = 790;
	internal const int cmdidAutoHideContext16 = 791;
	internal const int cmdidAutoHideContext17 = 792;
	internal const int cmdidAutoHideContext18 = 793;
	internal const int cmdidAutoHideContext19 = 794;
	internal const int cmdidAutoHideContext20 = 795;
	internal const int cmdidAutoHideContext21 = 796;
	internal const int cmdidAutoHideContext22 = 797;
	internal const int cmdidAutoHideContext23 = 798;
	internal const int cmdidAutoHideContext24 = 799;
	internal const int cmdidAutoHideContext25 = 800;
	internal const int cmdidAutoHideContext26 = 801;
	internal const int cmdidAutoHideContext27 = 802;
	internal const int cmdidAutoHideContext28 = 803;
	internal const int cmdidAutoHideContext29 = 804;
	internal const int cmdidAutoHideContext30 = 805;
	internal const int cmdidAutoHideContext31 = 806;
	internal const int cmdidAutoHideContext32 = 807;
	internal const int cmdidAutoHideContext33 = 808;
	internal const int cmdidShellNavBackward = 809;
	internal const int cmdidShellNavForward = 810;
	internal const int cmdidShellNavigate1 = 811;
	internal const int cmdidShellNavigate2 = 812;
	internal const int cmdidShellNavigate3 = 813;
	internal const int cmdidShellNavigate4 = 814;
	internal const int cmdidShellNavigate5 = 815;
	internal const int cmdidShellNavigate6 = 816;
	internal const int cmdidShellNavigate7 = 817;
	internal const int cmdidShellNavigate8 = 818;
	internal const int cmdidShellNavigate9 = 819;
	internal const int cmdidShellNavigate10 = 820;
	internal const int cmdidShellNavigate11 = 821;
	internal const int cmdidShellNavigate12 = 822;
	internal const int cmdidShellNavigate13 = 823;
	internal const int cmdidShellNavigate14 = 824;
	internal const int cmdidShellNavigate15 = 825;
	internal const int cmdidShellNavigate16 = 826;
	internal const int cmdidShellNavigate17 = 827;
	internal const int cmdidShellNavigate18 = 828;
	internal const int cmdidShellNavigate19 = 829;
	internal const int cmdidShellNavigate20 = 830;
	internal const int cmdidShellNavigate21 = 831;
	internal const int cmdidShellNavigate22 = 832;
	internal const int cmdidShellNavigate23 = 833;
	internal const int cmdidShellNavigate24 = 834;
	internal const int cmdidShellNavigate25 = 835;
	internal const int cmdidShellNavigate26 = 836;
	internal const int cmdidShellNavigate27 = 837;
	internal const int cmdidShellNavigate28 = 838;
	internal const int cmdidShellNavigate29 = 839;
	internal const int cmdidShellNavigate30 = 840;
	internal const int cmdidShellNavigate31 = 841;
	internal const int cmdidShellNavigate32 = 842;
	internal const int cmdidShellNavigate33 = 843;
	internal const int cmdidShellWindowNavigate1 = 844;
	internal const int cmdidShellWindowNavigate2 = 845;
	internal const int cmdidShellWindowNavigate3 = 846;
	internal const int cmdidShellWindowNavigate4 = 847;
	internal const int cmdidShellWindowNavigate5 = 848;
	internal const int cmdidShellWindowNavigate6 = 849;
	internal const int cmdidShellWindowNavigate7 = 850;
	internal const int cmdidShellWindowNavigate8 = 851;
	internal const int cmdidShellWindowNavigate9 = 852;
	internal const int cmdidShellWindowNavigate10 = 853;
	internal const int cmdidShellWindowNavigate11 = 854;
	internal const int cmdidShellWindowNavigate12 = 855;
	internal const int cmdidShellWindowNavigate13 = 856;
	internal const int cmdidShellWindowNavigate14 = 857;
	internal const int cmdidShellWindowNavigate15 = 858;
	internal const int cmdidShellWindowNavigate16 = 859;
	internal const int cmdidShellWindowNavigate17 = 860;
	internal const int cmdidShellWindowNavigate18 = 861;
	internal const int cmdidShellWindowNavigate19 = 862;
	internal const int cmdidShellWindowNavigate20 = 863;
	internal const int cmdidShellWindowNavigate21 = 864;
	internal const int cmdidShellWindowNavigate22 = 865;
	internal const int cmdidShellWindowNavigate23 = 866;
	internal const int cmdidShellWindowNavigate24 = 867;
	internal const int cmdidShellWindowNavigate25 = 868;
	internal const int cmdidShellWindowNavigate26 = 869;
	internal const int cmdidShellWindowNavigate27 = 870;
	internal const int cmdidShellWindowNavigate28 = 871;
	internal const int cmdidShellWindowNavigate29 = 872;
	internal const int cmdidShellWindowNavigate30 = 873;
	internal const int cmdidShellWindowNavigate31 = 874;
	internal const int cmdidShellWindowNavigate32 = 875;
	internal const int cmdidShellWindowNavigate33 = 876;
	internal const int cmdidOBSDoFind = 877;
	internal const int cmdidOBSMatchCase = 878;
	internal const int cmdidOBSMatchSubString = 879;
	internal const int cmdidOBSMatchWholeWord = 880;
	internal const int cmdidOBSMatchPrefix = 881;
	internal const int cmdidBuildSln = 882;
	internal const int cmdidRebuildSln = 883;
	internal const int cmdidDeploySln = 884;
	internal const int cmdidCleanSln = 885;
	internal const int cmdidBuildSel = 886;
	internal const int cmdidRebuildSel = 887;
	internal const int cmdidDeploySel = 888;
	internal const int cmdidCleanSel = 889;
	internal const int cmdidCancelBuild = 890;
	internal const int cmdidBatchBuildDlg = 891;
	internal const int cmdidBuildCtx = 892;
	internal const int cmdidRebuildCtx = 893;
	internal const int cmdidDeployCtx = 894;
	internal const int cmdidCleanCtx = 895;
	internal const int cmdidMRUFile1 = 900;
	internal const int cmdidMRUFile2 = 901;
	internal const int cmdidMRUFile3 = 902;
	internal const int cmdidMRUFile4 = 903;
	internal const int cmdidMRUFile5 = 904;
	internal const int cmdidMRUFile6 = 905;
	internal const int cmdidMRUFile7 = 906;
	internal const int cmdidMRUFile8 = 907;
	internal const int cmdidMRUFile9 = 908;
	internal const int cmdidMRUFile10 = 909;
	internal const int cmdidMRUFile11 = 910;
	internal const int cmdidMRUFile12 = 911;
	internal const int cmdidMRUFile13 = 912;
	internal const int cmdidMRUFile14 = 913;
	internal const int cmdidMRUFile15 = 914;
	internal const int cmdidMRUFile16 = 915;
	internal const int cmdidMRUFile17 = 916;
	internal const int cmdidMRUFile18 = 917;
	internal const int cmdidMRUFile19 = 918;
	internal const int cmdidMRUFile20 = 919;
	internal const int cmdidMRUFile21 = 920;
	internal const int cmdidMRUFile22 = 921;
	internal const int cmdidMRUFile23 = 922;
	internal const int cmdidMRUFile24 = 923;
	internal const int cmdidMRUFile25 = 924;
	internal const int cmdidGotoDefn = 925;
	internal const int cmdidGotoDecl = 926;
	internal const int cmdidBrowseDefn = 927;
	internal const int cmdidShowMembers = 928;
	internal const int cmdidShowBases = 929;
	internal const int cmdidShowDerived = 930;
	internal const int cmdidShowDefns = 931;
	internal const int cmdidShowRefs = 932;
	internal const int cmdidShowCallers = 933;
	internal const int cmdidShowCallees = 934;
	internal const int cmdidDefineSubset = 935;
	internal const int cmdidSetSubset = 936;
	internal const int cmdidCVGroupingNone = 950;
	internal const int cmdidCVGroupingSortOnly = 951;
	internal const int cmdidCVGroupingGrouped = 952;
	internal const int cmdidCVShowPackages = 953;
	internal const int cmdidQryManageIndexes = 954;
	internal const int cmdidBrowseComponent = 955;
	internal const int cmdidPrintDefault = 956;
	internal const int cmdidBrowseDoc = 957;
	internal const int cmdidStandardMax = 1000;
	internal const int cmdidFormsFirst = 24576;
	internal const int cmdidFormsLast = 28671;
	internal const int cmdidVBEFirst = 32768;
	internal const int msotcidBookmarkWellMenu = 32769;
	internal const int cmdidZoom200 = 32770;
	internal const int cmdidZoom150 = 32771;
	internal const int cmdidZoom100 = 32772;
	internal const int cmdidZoom75 = 32773;
	internal const int cmdidZoom50 = 32774;
	internal const int cmdidZoom25 = 32775;
	internal const int cmdidZoom10 = 32784;
	internal const int msotcidZoomWellMenu = 32785;
	internal const int msotcidDebugPopWellMenu = 32786;
	internal const int msotcidAlignWellMenu = 32787;
	internal const int msotcidArrangeWellMenu = 32788;
	internal const int msotcidCenterWellMenu = 32789;
	internal const int msotcidSizeWellMenu = 32790;
	internal const int msotcidHorizontalSpaceWellMenu = 32791;
	internal const int msotcidVerticalSpaceWellMenu = 32800;
	internal const int msotcidDebugWellMenu = 32801;
	internal const int msotcidDebugMenuVB = 32802;
	internal const int msotcidStatementBuilderWellMenu = 32803;
	internal const int msotcidProjWinInsertMenu = 32804;
	internal const int msotcidToggleMenu = 32805;
	internal const int msotcidNewObjInsertWellMenu = 32806;
	internal const int msotcidSizeToWellMenu = 32807;
	internal const int msotcidCommandBars = 32808;
	internal const int msotcidVBOrderMenu = 32809;
	internal const int msotcidMSOnTheWeb = 32810;
	internal const int msotcidVBDesignerMenu = 32816;
	internal const int msotcidNewProjectWellMenu = 32817;
	internal const int msotcidProjectWellMenu = 32818;
	internal const int msotcidVBCode1ContextMenu = 32819;
	internal const int msotcidVBCode2ContextMenu = 32820;
	internal const int msotcidVBWatchContextMenu = 32821;
	internal const int msotcidVBImmediateContextMenu = 32822;
	internal const int msotcidVBLocalsContextMenu = 32823;
	internal const int msotcidVBFormContextMenu = 32824;
	internal const int msotcidVBControlContextMenu = 32825;
	internal const int msotcidVBProjWinContextMenu = 32826;
	internal const int msotcidVBProjWinContextBreakMenu = 32827;
	internal const int msotcidVBPreviewWinContextMenu = 32828;
	internal const int msotcidVBOBContextMenu = 32829;
	internal const int msotcidVBForms3ContextMenu = 32830;
	internal const int msotcidVBForms3ControlCMenu = 32831;
	internal const int msotcidVBForms3ControlCMenuGroup = 32832;
	internal const int msotcidVBForms3ControlPalette = 32833;
	internal const int msotcidVBForms3ToolboxCMenu = 32834;
	internal const int msotcidVBForms3MPCCMenu = 32835;
	internal const int msotcidVBForms3DragDropCMenu = 32836;
	internal const int msotcidVBToolBoxContextMenu = 32837;
	internal const int msotcidVBToolBoxGroupContextMenu = 32838;
	internal const int msotcidVBPropBrsHostContextMenu = 32839;
	internal const int msotcidVBPropBrsContextMenu = 32840;
	internal const int msotcidVBPalContextMenu = 32841;
	internal const int msotcidVBProjWinProjectContextMenu = 32842;
	internal const int msotcidVBProjWinFormContextMenu = 32843;
	internal const int msotcidVBProjWinModClassContextMenu = 32844;
	internal const int msotcidVBProjWinRelDocContextMenu = 32845;
	internal const int msotcidVBDockedWindowContextMenu = 32846;
	internal const int msotcidVBShortCutForms = 32847;
	internal const int msotcidVBShortCutCodeWindows = 32848;
	internal const int msotcidVBShortCutMisc = 32849;
	internal const int msotcidVBBuiltInMenus = 32850;
	internal const int msotcidPreviewWinFormPos = 32851;
	internal const int msotcidVBAddinFirst = 33280;
}

// Namespace: 
private static class StandardCommands.ShellGuids // TypeDefIndex: 5458
{
	// Fields
	internal static readonly Guid VSStandardCommandSet97; // 0x0
	internal static readonly Guid guidDsdCmdId; // 0x10
	internal static readonly Guid SID_SOleComponentUIManager; // 0x20
	internal static readonly Guid GUID_VSTASKCATEGORY_DATADESIGNER; // 0x30
	internal static readonly Guid GUID_PropertyBrowserToolWindow; // 0x40

	// Methods

	// RVA: 0x2115150 Offset: 0x2114350 VA: 0x182115150
	private static void .cctor() { }
}

// Namespace: System.ComponentModel.Design
public class StandardCommands // TypeDefIndex: 5459
{
	// Fields
	private static readonly Guid s_standardCommandSet; // 0x0
	private static readonly Guid s_ndpCommandSet; // 0x10
	private const int cmdidDesignerVerbFirst = 8192;
	private const int cmdidDesignerVerbLast = 8448;
	private const int cmdidArrangeIcons = 12298;
	private const int cmdidLineupIcons = 12299;
	private const int cmdidShowLargeIcons = 12300;
	public static readonly CommandID AlignBottom; // 0x20
	public static readonly CommandID AlignHorizontalCenters; // 0x28
	public static readonly CommandID AlignLeft; // 0x30
	public static readonly CommandID AlignRight; // 0x38
	public static readonly CommandID AlignToGrid; // 0x40
	public static readonly CommandID AlignTop; // 0x48
	public static readonly CommandID AlignVerticalCenters; // 0x50
	public static readonly CommandID ArrangeBottom; // 0x58
	public static readonly CommandID ArrangeRight; // 0x60
	public static readonly CommandID BringForward; // 0x68
	public static readonly CommandID BringToFront; // 0x70
	public static readonly CommandID CenterHorizontally; // 0x78
	public static readonly CommandID CenterVertically; // 0x80
	public static readonly CommandID ViewCode; // 0x88
	public static readonly CommandID DocumentOutline; // 0x90
	public static readonly CommandID Copy; // 0x98
	public static readonly CommandID Cut; // 0xA0
	public static readonly CommandID Delete; // 0xA8
	public static readonly CommandID Group; // 0xB0
	public static readonly CommandID HorizSpaceConcatenate; // 0xB8
	public static readonly CommandID HorizSpaceDecrease; // 0xC0
	public static readonly CommandID HorizSpaceIncrease; // 0xC8
	public static readonly CommandID HorizSpaceMakeEqual; // 0xD0
	public static readonly CommandID Paste; // 0xD8
	public static readonly CommandID Properties; // 0xE0
	public static readonly CommandID Redo; // 0xE8
	public static readonly CommandID MultiLevelRedo; // 0xF0
	public static readonly CommandID SelectAll; // 0xF8
	public static readonly CommandID SendBackward; // 0x100
	public static readonly CommandID SendToBack; // 0x108
	public static readonly CommandID SizeToControl; // 0x110
	public static readonly CommandID SizeToControlHeight; // 0x118
	public static readonly CommandID SizeToControlWidth; // 0x120
	public static readonly CommandID SizeToFit; // 0x128
	public static readonly CommandID SizeToGrid; // 0x130
	public static readonly CommandID SnapToGrid; // 0x138
	public static readonly CommandID TabOrder; // 0x140
	public static readonly CommandID Undo; // 0x148
	public static readonly CommandID MultiLevelUndo; // 0x150
	public static readonly CommandID Ungroup; // 0x158
	public static readonly CommandID VertSpaceConcatenate; // 0x160
	public static readonly CommandID VertSpaceDecrease; // 0x168
	public static readonly CommandID VertSpaceIncrease; // 0x170
	public static readonly CommandID VertSpaceMakeEqual; // 0x178
	public static readonly CommandID ShowGrid; // 0x180
	public static readonly CommandID ViewGrid; // 0x188
	public static readonly CommandID Replace; // 0x190
	public static readonly CommandID PropertiesWindow; // 0x198
	public static readonly CommandID LockControls; // 0x1A0
	public static readonly CommandID F1Help; // 0x1A8
	public static readonly CommandID ArrangeIcons; // 0x1B0
	public static readonly CommandID LineupIcons; // 0x1B8
	public static readonly CommandID ShowLargeIcons; // 0x1C0
	public static readonly CommandID VerbFirst; // 0x1C8
	public static readonly CommandID VerbLast; // 0x1D0

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2115300 Offset: 0x2114500 VA: 0x182115300
	private static void .cctor() { }
}

// Namespace: System.ComponentModel.Design
public class StandardToolWindows // TypeDefIndex: 5460
{
	// Fields
	public static readonly Guid ObjectBrowser; // 0x0
	public static readonly Guid OutputWindow; // 0x10
	public static readonly Guid ProjectExplorer; // 0x20
	public static readonly Guid PropertyBrowser; // 0x30
	public static readonly Guid RelatedLinks; // 0x40
	public static readonly Guid ServerExplorer; // 0x50
	public static readonly Guid TaskList; // 0x60
	public static readonly Guid Toolbox; // 0x70

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x21165B0 Offset: 0x21157B0 VA: 0x1821165B0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel.Design
public enum ViewTechnology // TypeDefIndex: 5461
{
	// Fields
	public int value__; // 0x0
	[Obsolete("This value has been deprecated. Use ViewTechnology.Default instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public const ViewTechnology Passthrough = 0;
	[Obsolete("This value has been deprecated. Use ViewTechnology.Default instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public const ViewTechnology WindowsForms = 1;
	public const ViewTechnology Default = 2;
}

// Namespace: System.ComponentModel.Design
public abstract class TypeDescriptionProviderService // TypeDefIndex: 5462
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract TypeDescriptionProvider GetProvider(object instance);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract TypeDescriptionProvider GetProvider(Type type);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
private sealed class DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 5463
{
	// Fields
	private object target; // 0x88
	private PropertyDescriptor property; // 0x90

	// Properties
	public override AttributeCollection Attributes { get; }
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	// RVA: 0x2118AA0 Offset: 0x2117CA0 VA: 0x182118AA0
	internal void .ctor(PropertyDescriptor property, object target) { }

	// RVA: 0x2118B10 Offset: 0x2117D10 VA: 0x182118B10 Slot: 6
	public override AttributeCollection get_Attributes() { }

	// RVA: 0x2118B40 Offset: 0x2117D40 VA: 0x182118B40 Slot: 17
	public override Type get_ComponentType() { }

	// RVA: 0x2118B70 Offset: 0x2117D70 VA: 0x182118B70 Slot: 20
	public override bool get_IsReadOnly() { }

	// RVA: 0x2118BA0 Offset: 0x2117DA0 VA: 0x182118BA0 Slot: 21
	public override Type get_PropertyType() { }

	// RVA: 0x2118960 Offset: 0x2117B60 VA: 0x182118960 Slot: 23
	public override bool CanResetValue(object component) { }

	// RVA: 0x21189A0 Offset: 0x2117BA0 VA: 0x1821189A0 Slot: 26
	public override object GetValue(object component) { }

	// RVA: 0x21189E0 Offset: 0x2117BE0 VA: 0x1821189E0 Slot: 29
	public override void ResetValue(object component) { }

	// RVA: 0x2118A20 Offset: 0x2117C20 VA: 0x182118A20 Slot: 30
	public override void SetValue(object component, object value) { }

	// RVA: 0x2118A60 Offset: 0x2117C60 VA: 0x182118A60 Slot: 31
	public override bool ShouldSerializeValue(object component) { }
}

// Namespace: 
[DefaultMember("Item")]
[Editor("", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[TypeConverter(typeof(DesignerOptionService.DesignerOptionConverter))]
public sealed class DesignerOptionService.DesignerOptionCollection : IList, ICollection, IEnumerable // TypeDefIndex: 5464
{
	// Fields
	private DesignerOptionService _service; // 0x10
	private DesignerOptionService.DesignerOptionCollection _parent; // 0x18
	private string _name; // 0x20
	private object _value; // 0x28
	private ArrayList _children; // 0x30
	private PropertyDescriptorCollection _properties; // 0x38

	// Properties
	public int Count { get; }
	public string Name { get; }
	public DesignerOptionService.DesignerOptionCollection Parent { get; }
	public PropertyDescriptorCollection Properties { get; }
	public DesignerOptionService.DesignerOptionCollection Item { get; }
	public DesignerOptionService.DesignerOptionCollection Item { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x2101460 Offset: 0x2100660 VA: 0x182101460
	internal void .ctor(DesignerOptionService service, DesignerOptionService.DesignerOptionCollection parent, string name, object value) { }

	// RVA: 0x2101530 Offset: 0x2100730 VA: 0x182101530 Slot: 16
	public int get_Count() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Name() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public DesignerOptionService.DesignerOptionCollection get_Parent() { }

	// RVA: 0x2101760 Offset: 0x2100960 VA: 0x182101760
	public PropertyDescriptorCollection get_Properties() { }

	// RVA: 0x21012F0 Offset: 0x21004F0 VA: 0x1821012F0
	public DesignerOptionService.DesignerOptionCollection get_Item(int index) { }

	// RVA: 0x2101570 Offset: 0x2100770 VA: 0x182101570
	public DesignerOptionService.DesignerOptionCollection get_Item(string name) { }

	// RVA: 0x2100DD0 Offset: 0x20FFFD0 VA: 0x182100DD0 Slot: 15
	public void CopyTo(Array array, int index) { }

	// RVA: 0x2100E30 Offset: 0x2100030 VA: 0x182100E30
	private void EnsurePopulated() { }

	// RVA: 0x2100EC0 Offset: 0x21000C0 VA: 0x182100EC0 Slot: 19
	public IEnumerator GetEnumerator() { }

	// RVA: 0x2100F00 Offset: 0x2100100 VA: 0x182100F00
	public int IndexOf(DesignerOptionService.DesignerOptionCollection value) { }

	// RVA: 0x2100F50 Offset: 0x2100150 VA: 0x182100F50
	private static object RecurseFindValue(DesignerOptionService.DesignerOptionCollection options) { }

	// RVA: 0x2101110 Offset: 0x2100310 VA: 0x182101110
	public bool ShowDialog() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 18
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 17
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x21012F0 Offset: 0x21004F0 VA: 0x1821012F0 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x21013F0 Offset: 0x21005F0 VA: 0x1821013F0 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x2101160 Offset: 0x2100360 VA: 0x182101160 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x21011A0 Offset: 0x21003A0 VA: 0x1821011A0 Slot: 8
	private void System.Collections.IList.Clear() { }

	// RVA: 0x21011E0 Offset: 0x21003E0 VA: 0x1821011E0 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x2100F00 Offset: 0x2100100 VA: 0x182100F00 Slot: 11
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x2101230 Offset: 0x2100430 VA: 0x182101230 Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x21012B0 Offset: 0x21004B0 VA: 0x1821012B0 Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x2101270 Offset: 0x2100470 VA: 0x182101270 Slot: 14
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x2101430 Offset: 0x2100630 VA: 0x182101430
	internal void .ctor() { }
}

// Namespace: 
private class DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 5465
{
	// Fields
	private DesignerOptionService.DesignerOptionCollection _option; // 0x88

	// Properties
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	// RVA: 0x2110380 Offset: 0x210F580 VA: 0x182110380
	internal void .ctor(DesignerOptionService.DesignerOptionCollection option) { }

	// RVA: 0x21103C0 Offset: 0x210F5C0 VA: 0x1821103C0 Slot: 17
	public override Type get_ComponentType() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 20
	public override bool get_IsReadOnly() { }

	// RVA: 0x21103C0 Offset: 0x210F5C0 VA: 0x1821103C0 Slot: 21
	public override Type get_PropertyType() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 23
	public override bool CanResetValue(object component) { }

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870 Slot: 26
	public override object GetValue(object component) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 29
	public override void ResetValue(object component) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 30
	public override void SetValue(object component, object value) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 31
	public override bool ShouldSerializeValue(object component) { }
}

// Namespace: 
internal sealed class DesignerOptionService.DesignerOptionConverter : TypeConverter // TypeDefIndex: 5466
{
	// Methods

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 11
	public override bool GetPropertiesSupported(ITypeDescriptorContext cxt) { }

	// RVA: 0x2101ED0 Offset: 0x21010D0 VA: 0x182101ED0 Slot: 10
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext cxt, object value, Attribute[] attributes) { }

	// RVA: 0x2101DE0 Offset: 0x2100FE0 VA: 0x182101DE0 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext cxt, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.ComponentModel.Design
public abstract class DesignerOptionService : IDesignerOptionService // TypeDefIndex: 5467
{
	// Fields
	private DesignerOptionService.DesignerOptionCollection _options; // 0x10

	// Properties
	public DesignerOptionService.DesignerOptionCollection Options { get; }

	// Methods

	// RVA: 0x2102910 Offset: 0x2101B10 VA: 0x182102910
	public DesignerOptionService.DesignerOptionCollection get_Options() { }

	// RVA: 0x21023E0 Offset: 0x21015E0 VA: 0x1821023E0
	protected DesignerOptionService.DesignerOptionCollection CreateOptionCollection(DesignerOptionService.DesignerOptionCollection parent, string name, object value) { }

	// RVA: 0x2102640 Offset: 0x2101840 VA: 0x182102640
	private PropertyDescriptor GetOptionProperty(string pageName, string valueName) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	protected virtual void PopulateOptionCollection(DesignerOptionService.DesignerOptionCollection options) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	protected virtual bool ShowDialog(DesignerOptionService.DesignerOptionCollection options, object optionObject) { }

	// RVA: 0x2102890 Offset: 0x2101A90 VA: 0x182102890 Slot: 4
	private object System.ComponentModel.Design.IDesignerOptionService.GetOptionValue(string pageName, string valueName) { }

	// RVA: 0x21028D0 Offset: 0x2101AD0 VA: 0x1821028D0 Slot: 5
	private void System.ComponentModel.Design.IDesignerOptionService.SetOptionValue(string pageName, string valueName, object value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.ComponentModel.Design.Serialization
public abstract class ComponentSerializationService // TypeDefIndex: 5468
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract SerializationStore CreateStore();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract SerializationStore LoadStore(Stream stream);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Serialize(SerializationStore store, object value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void SerializeAbsolute(SerializationStore store, object value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void SerializeMember(SerializationStore store, object owningObject, MemberDescriptor member);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void SerializeMemberAbsolute(SerializationStore store, object owningObject, MemberDescriptor member);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract ICollection Deserialize(SerializationStore store);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract ICollection Deserialize(SerializationStore store, IContainer container);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void DeserializeTo(SerializationStore store, IContainer container, bool validateRecycledTypes, bool applyDefaults);

	// RVA: 0x20FE300 Offset: 0x20FD500 VA: 0x1820FE300
	public void DeserializeTo(SerializationStore store, IContainer container) { }

	// RVA: 0x20FE2D0 Offset: 0x20FD4D0 VA: 0x1820FE2D0
	public void DeserializeTo(SerializationStore store, IContainer container, bool validateRecycledTypes) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.ComponentModel.Design.Serialization
[DefaultMember("Item")]
public sealed class ContextStack // TypeDefIndex: 5469
{
	// Fields
	private ArrayList _contextStack; // 0x10

	// Properties
	public object Current { get; }
	public object Item { get; }
	public object Item { get; }

	// Methods

	// RVA: 0x20FE5A0 Offset: 0x20FD7A0 VA: 0x1820FE5A0
	public object get_Current() { }

	// RVA: 0x20FE630 Offset: 0x20FD830 VA: 0x1820FE630
	public object get_Item(int level) { }

	// RVA: 0x20FE720 Offset: 0x20FD920 VA: 0x1820FE720
	public object get_Item(Type type) { }

	// RVA: 0x20FE330 Offset: 0x20FD530 VA: 0x1820FE330
	public void Append(object context) { }

	// RVA: 0x20FE410 Offset: 0x20FD610 VA: 0x1820FE410
	public object Pop() { }

	// RVA: 0x20FE4C0 Offset: 0x20FD6C0 VA: 0x1820FE4C0
	public void Push(object context) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.ComponentModel.Design.Serialization
[Usage(4, Inherited = False)]
public sealed class DefaultSerializationProviderAttribute : Attribute // TypeDefIndex: 5470
{
	// Fields
	[CompilerGenerated]
	private readonly string <ProviderTypeName>k__BackingField; // 0x10

	// Properties
	public string ProviderTypeName { get; }

	// Methods

	// RVA: 0x20FE870 Offset: 0x20FDA70 VA: 0x1820FE870
	public void .ctor(Type providerType) { }

	// RVA: 0x20FE950 Offset: 0x20FDB50 VA: 0x1820FE950
	public void .ctor(string providerTypeName) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_ProviderTypeName() { }
}

// Namespace: System.ComponentModel.Design.Serialization
public abstract class DesignerLoader // TypeDefIndex: 5471
{
	// Properties
	public virtual bool Loading { get; }

	// Methods

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 4
	public virtual bool get_Loading() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void BeginLoad(IDesignerLoaderHost host);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Dispose();

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public virtual void Flush() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.ComponentModel.Design.Serialization
[Usage(1028, AllowMultiple = True, Inherited = True)]
public sealed class DesignerSerializerAttribute : Attribute // TypeDefIndex: 5472
{
	// Fields
	private string _typeId; // 0x10
	[CompilerGenerated]
	private readonly string <SerializerTypeName>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <SerializerBaseTypeName>k__BackingField; // 0x20

	// Properties
	public string SerializerTypeName { get; }
	public string SerializerBaseTypeName { get; }
	public override object TypeId { get; }

	// Methods

	// RVA: 0x2102A30 Offset: 0x2101C30 VA: 0x182102A30
	public void .ctor(Type serializerType, Type baseSerializerType) { }

	// RVA: 0x21029D0 Offset: 0x2101BD0 VA: 0x1821029D0
	public void .ctor(string serializerTypeName, Type baseSerializerType) { }

	// RVA: 0x2102AB0 Offset: 0x2101CB0 VA: 0x182102AB0
	public void .ctor(string serializerTypeName, string baseSerializerTypeName) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_SerializerTypeName() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_SerializerBaseTypeName() { }

	// RVA: 0x2102AF0 Offset: 0x2101CF0 VA: 0x182102AF0 Slot: 4
	public override object get_TypeId() { }
}

// Namespace: System.ComponentModel.Design.Serialization
public interface IDesignerLoaderHost : IDesignerHost, IServiceContainer, IServiceProvider // TypeDefIndex: 5473
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void EndLoad(string baseClassName, bool successful, ICollection errorCollection);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Reload();
}

// Namespace: System.ComponentModel.Design.Serialization
public interface IDesignerLoaderHost2 : IDesignerLoaderHost, IDesignerHost, IServiceContainer, IServiceProvider // TypeDefIndex: 5474
{
	// Properties
	public abstract bool IgnoreErrorsDuringReload { get; set; }
	public abstract bool CanReloadWithErrors { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IgnoreErrorsDuringReload();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_IgnoreErrorsDuringReload(bool value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_CanReloadWithErrors();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_CanReloadWithErrors(bool value);
}

// Namespace: System.ComponentModel.Design.Serialization
public interface IDesignerLoaderService // TypeDefIndex: 5475
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void AddLoadDependency();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void DependentLoadComplete(bool successful, ICollection errorCollection);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool Reload();
}

// Namespace: System.ComponentModel.Design.Serialization
public interface IDesignerSerializationManager : IServiceProvider // TypeDefIndex: 5476
{
	// Properties
	public abstract ContextStack Context { get; }
	public abstract PropertyDescriptorCollection Properties { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ContextStack get_Context();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract PropertyDescriptorCollection get_Properties();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_ResolveName(ResolveNameEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_ResolveName(ResolveNameEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void add_SerializationComplete(EventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void remove_SerializationComplete(EventHandler value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void AddSerializationProvider(IDesignerSerializationProvider provider);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract object CreateInstance(Type type, ICollection arguments, string name, bool addToContainer);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract object GetInstance(string name);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string GetName(object value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract object GetSerializer(Type objectType, Type serializerType);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Type GetType(string typeName);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void RemoveSerializationProvider(IDesignerSerializationProvider provider);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void ReportError(object errorInformation);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void SetName(object instance, string name);
}

// Namespace: System.ComponentModel.Design.Serialization
public interface IDesignerSerializationProvider // TypeDefIndex: 5477
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetSerializer(IDesignerSerializationManager manager, object currentSerializer, Type objectType, Type serializerType);
}

// Namespace: System.ComponentModel.Design.Serialization
public interface IDesignerSerializationService // TypeDefIndex: 5478
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ICollection Deserialize(object serializationData);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object Serialize(ICollection objects);
}

// Namespace: System.ComponentModel.Design.Serialization
public interface INameCreationService // TypeDefIndex: 5479
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string CreateName(IContainer container, Type dataType);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsValidName(string name);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void ValidateName(string name);
}

// Namespace: System.ComponentModel.Design.Serialization
public sealed class InstanceDescriptor // TypeDefIndex: 5480
{
	// Fields
	[CompilerGenerated]
	private readonly ICollection <Arguments>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly bool <IsComplete>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly MemberInfo <MemberInfo>k__BackingField; // 0x20

	// Properties
	public ICollection Arguments { get; }
	public bool IsComplete { get; }
	public MemberInfo MemberInfo { get; }

	// Methods

	// RVA: 0x2106D50 Offset: 0x2105F50 VA: 0x182106D50
	public void .ctor(MemberInfo member, ICollection arguments) { }

	// RVA: 0x2106D70 Offset: 0x2105F70 VA: 0x182106D70
	public void .ctor(MemberInfo member, ICollection arguments, bool isComplete) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ICollection get_Arguments() { }

	[CompilerGenerated]
	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_IsComplete() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public MemberInfo get_MemberInfo() { }

	// RVA: 0x21067D0 Offset: 0x21059D0 VA: 0x1821067D0
	public object Invoke() { }
}

// Namespace: 
private struct MemberRelationshipService.RelationshipEntry // TypeDefIndex: 5481
{
	// Fields
	internal WeakReference Owner; // 0x0
	internal MemberDescriptor Member; // 0x8
	private int _hashCode; // 0x10

	// Methods

	// RVA: 0x2112F40 Offset: 0x2112140 VA: 0x182112F40
	internal void .ctor(MemberRelationship rel) { }

	// RVA: 0x2112E80 Offset: 0x2112080 VA: 0x182112E80 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2113020 Offset: 0x2112220 VA: 0x182113020
	public static bool op_Equality(MemberRelationshipService.RelationshipEntry re1, MemberRelationshipService.RelationshipEntry re2) { }

	// RVA: 0x2113110 Offset: 0x2112310 VA: 0x182113110
	public static bool op_Inequality(MemberRelationshipService.RelationshipEntry re1, MemberRelationshipService.RelationshipEntry re2) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.ComponentModel.Design.Serialization
[DefaultMember("Item")]
public abstract class MemberRelationshipService // TypeDefIndex: 5482
{
	// Fields
	private Dictionary<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry> _relationships; // 0x10

	// Properties
	public MemberRelationship Item { get; set; }
	public MemberRelationship Item { get; set; }

	// Methods

	// RVA: 0x2108D60 Offset: 0x2107F60 VA: 0x182108D60
	public MemberRelationship get_Item(MemberRelationship source) { }

	// RVA: 0x2108FA0 Offset: 0x21081A0 VA: 0x182108FA0
	public void set_Item(MemberRelationship source, MemberRelationship value) { }

	// RVA: 0x2108C70 Offset: 0x2107E70 VA: 0x182108C70
	public MemberRelationship get_Item(object sourceOwner, MemberDescriptor sourceMember) { }

	// RVA: 0x2108EB0 Offset: 0x21080B0 VA: 0x182108EB0
	public void set_Item(object sourceOwner, MemberDescriptor sourceMember, MemberRelationship value) { }

	// RVA: 0x2108440 Offset: 0x2107640 VA: 0x182108440 Slot: 4
	protected virtual MemberRelationship GetRelationship(MemberRelationship source) { }

	// RVA: 0x21086F0 Offset: 0x21078F0 VA: 0x1821086F0 Slot: 5
	protected virtual void SetRelationship(MemberRelationship source, MemberRelationship relationship) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool SupportsRelationship(MemberRelationship source, MemberRelationship relationship);

	// RVA: 0x2108C00 Offset: 0x2107E00 VA: 0x182108C00
	protected void .ctor() { }
}

// Namespace: System.ComponentModel.Design.Serialization
[IsReadOnly]
public struct MemberRelationship // TypeDefIndex: 5483
{
	// Fields
	public static readonly MemberRelationship Empty; // 0x0
	[CompilerGenerated]
	private readonly MemberDescriptor <Member>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly object <Owner>k__BackingField; // 0x8

	// Properties
	public bool IsEmpty { get; }
	public MemberDescriptor Member { get; }
	public object Owner { get; }

	// Methods

	// RVA: 0x2109290 Offset: 0x2108490 VA: 0x182109290
	public void .ctor(object owner, MemberDescriptor member) { }

	// RVA: 0x2109340 Offset: 0x2108540 VA: 0x182109340
	public bool get_IsEmpty() { }

	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public MemberDescriptor get_Member() { }

	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public object get_Owner() { }

	// RVA: 0x21090F0 Offset: 0x21082F0 VA: 0x1821090F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21091C0 Offset: 0x21083C0 VA: 0x1821091C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2109390 Offset: 0x2108590 VA: 0x182109390
	public static bool op_Equality(MemberRelationship left, MemberRelationship right) { }

	// RVA: 0x2109420 Offset: 0x2108620 VA: 0x182109420
	public static bool op_Inequality(MemberRelationship left, MemberRelationship right) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private static void .cctor() { }
}

// Namespace: System.ComponentModel.Design.Serialization
public class ResolveNameEventArgs : EventArgs // TypeDefIndex: 5484
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private object <Value>k__BackingField; // 0x18

	// Properties
	public string Name { get; }
	public object Value { get; set; }

	// Methods

	// RVA: 0x2113160 Offset: 0x2112360 VA: 0x182113160
	public void .ctor(string name) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public object get_Value() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Value(object value) { }
}

// Namespace: System.ComponentModel.Design.Serialization
public sealed class ResolveNameEventHandler : MulticastDelegate // TypeDefIndex: 5485
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, ResolveNameEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, ResolveNameEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.ComponentModel.Design.Serialization
[Usage(1028, AllowMultiple = True, Inherited = True)]
[Obsolete("This attribute has been deprecated. Use DesignerSerializerAttribute instead.  For example, to specify a root designer for CodeDom, use DesignerSerializerAttribute(...,typeof(TypeCodeDomSerializer)).  https://go.microsoft.com/fwlink/?linkid=14202")]
public sealed class RootDesignerSerializerAttribute : Attribute // TypeDefIndex: 5486
{
	// Fields
	private string _typeId; // 0x10
	[CompilerGenerated]
	private readonly bool <Reloadable>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <SerializerTypeName>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly string <SerializerBaseTypeName>k__BackingField; // 0x28

	// Properties
	public bool Reloadable { get; }
	public string SerializerTypeName { get; }
	public string SerializerBaseTypeName { get; }
	public override object TypeId { get; }

	// Methods

	// RVA: 0x2113220 Offset: 0x2112420 VA: 0x182113220
	public void .ctor(Type serializerType, Type baseSerializerType, bool reloadable) { }

	// RVA: 0x21132B0 Offset: 0x21124B0 VA: 0x1821132B0
	public void .ctor(string serializerTypeName, Type baseSerializerType, bool reloadable) { }

	// RVA: 0x21131D0 Offset: 0x21123D0 VA: 0x1821131D0
	public void .ctor(string serializerTypeName, string baseSerializerTypeName, bool reloadable) { }

	[CompilerGenerated]
	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_Reloadable() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_SerializerTypeName() { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_SerializerBaseTypeName() { }

	// RVA: 0x2113320 Offset: 0x2112520 VA: 0x182113320 Slot: 4
	public override object get_TypeId() { }
}

// Namespace: System.ComponentModel.Design.Serialization
public abstract class SerializationStore : IDisposable // TypeDefIndex: 5487
{
	// Properties
	public abstract ICollection Errors { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract ICollection get_Errors();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Close();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Save(Stream stream);

	// RVA: 0x1619090 Offset: 0x1618290 VA: 0x181619090 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2114050 Offset: 0x2113250 VA: 0x182114050 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Collections
[Extension]
internal static class HashtableExtensions // TypeDefIndex: 5488
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static bool TryGetValue<T>(Hashtable table, object key, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B21E0 Offset: 0x9B13E0 VA: 0x1809B21E0
	|-HashtableExtensions.TryGetValue<int>
	|
	|-RVA: 0x9B20B0 Offset: 0x9B12B0 VA: 0x1809B20B0
	|-HashtableExtensions.TryGetValue<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
[Serializable]
private sealed class ObservableCollection.SimpleMonitor<T> : IDisposable // TypeDefIndex: 5489
{
	// Fields
	internal int _busyCount; // 0x0
	internal ObservableCollection<T> _collection; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ObservableCollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x81DA00 Offset: 0x81CC00 VA: 0x18081DA00
	|-ObservableCollection.SimpleMonitor<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF7000 Offset: 0xBF6200 VA: 0x180BF7000
	|-ObservableCollection.SimpleMonitor<__Il2CppFullySharedGenericType>.Dispose
	*/
}

// Namespace: System.Collections.ObjectModel
[DebuggerTypeProxy(typeof(CollectionDebugView<T>))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class ObservableCollection<T> : Collection<T>, INotifyCollectionChanged, INotifyPropertyChanged // TypeDefIndex: 5490
{
	// Fields
	private ObservableCollection.SimpleMonitor<T> _monitor; // 0x0
	private int _blockReentrancyCount; // 0x0
	[CompilerGenerated]
	private NotifyCollectionChangedEventHandler CollectionChanged; // 0x0
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanged; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7B430 Offset: 0xB7A630 VA: 0x180B7B430
	|-ObservableCollection<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7B330 Offset: 0xB7A530 VA: 0x180B7B330
	|-ObservableCollection<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7B3B0 Offset: 0xB7A5B0 VA: 0x180B7B3B0
	|-ObservableCollection<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static List<T> CreateCopy(IEnumerable<T> collection, string paramName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7A3B0 Offset: 0xB795B0 VA: 0x180B7A3B0
	|-ObservableCollection<__Il2CppFullySharedGenericType>.CreateCopy
	*/

	// RVA: -1 Offset: -1
	public void Move(int oldIndex, int newIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7A9A0 Offset: 0xB79BA0 VA: 0x180B7A9A0
	|-ObservableCollection<__Il2CppFullySharedGenericType>.Move
	*/

	// RVA: -1 Offset: -1 Slot: 41
	private void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7B2F0 Offset: 0xB7A4F0 VA: 0x180B7B2F0
	|-ObservableCollection<__Il2CppFullySharedGenericType>.System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged
	*/

	// RVA: -1 Offset: -1 Slot: 42
	private void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7B310 Offset: 0xB7A510 VA: 0x180B7B310
	|-ObservableCollection<__Il2CppFullySharedGenericType>.System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 43
	public virtual void add_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7B450 Offset: 0xB7A650 VA: 0x180B7B450
	|-ObservableCollection<__Il2CppFullySharedGenericType>.add_CollectionChanged
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 44
	public virtual void remove_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7B590 Offset: 0xB7A790 VA: 0x180B7B590
	|-ObservableCollection<__Il2CppFullySharedGenericType>.remove_CollectionChanged
	*/

	// RVA: -1 Offset: -1 Slot: 35
	protected override void ClearItems() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7A310 Offset: 0xB79510 VA: 0x180B7A310
	|-ObservableCollection<__Il2CppFullySharedGenericType>.ClearItems
	*/

	// RVA: -1 Offset: -1 Slot: 37
	protected override void RemoveItem(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7AE10 Offset: 0xB7A010 VA: 0x180B7AE10
	|-ObservableCollection<__Il2CppFullySharedGenericType>.RemoveItem
	*/

	// RVA: -1 Offset: -1 Slot: 36
	protected override void InsertItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7A540 Offset: 0xB79740 VA: 0x180B7A540
	|-ObservableCollection<__Il2CppFullySharedGenericType>.InsertItem
	*/

	// RVA: -1 Offset: -1 Slot: 38
	protected override void SetItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7B000 Offset: 0xB7A200 VA: 0x180B7B000
	|-ObservableCollection<__Il2CppFullySharedGenericType>.SetItem
	*/

	// RVA: -1 Offset: -1 Slot: 45
	protected virtual void MoveItem(int oldIndex, int newIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7A730 Offset: 0xB79930 VA: 0x180B7A730
	|-ObservableCollection<__Il2CppFullySharedGenericType>.MoveItem
	*/

	// RVA: -1 Offset: -1 Slot: 46
	protected virtual void OnPropertyChanged(PropertyChangedEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7ADB0 Offset: 0xB79FB0 VA: 0x180B7ADB0
	|-ObservableCollection<__Il2CppFullySharedGenericType>.OnPropertyChanged
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 47
	protected virtual void add_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7B4F0 Offset: 0xB7A6F0 VA: 0x180B7B4F0
	|-ObservableCollection<__Il2CppFullySharedGenericType>.add_PropertyChanged
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 48
	protected virtual void remove_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7B630 Offset: 0xB7A830 VA: 0x180B7B630
	|-ObservableCollection<__Il2CppFullySharedGenericType>.remove_PropertyChanged
	*/

	// RVA: -1 Offset: -1 Slot: 49
	protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7AA70 Offset: 0xB79C70 VA: 0x180B7AA70
	|-ObservableCollection<__Il2CppFullySharedGenericType>.OnCollectionChanged
	*/

	// RVA: -1 Offset: -1
	protected IDisposable BlockReentrancy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7A260 Offset: 0xB79460 VA: 0x180B7A260
	|-ObservableCollection<__Il2CppFullySharedGenericType>.BlockReentrancy
	*/

	// RVA: -1 Offset: -1
	protected void CheckReentrancy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7A280 Offset: 0xB79480 VA: 0x180B7A280
	|-ObservableCollection<__Il2CppFullySharedGenericType>.CheckReentrancy
	*/

	// RVA: -1 Offset: -1
	private void OnCountPropertyChanged() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7ACA0 Offset: 0xB79EA0 VA: 0x180B7ACA0
	|-ObservableCollection<__Il2CppFullySharedGenericType>.OnCountPropertyChanged
	*/

	// RVA: -1 Offset: -1
	private void OnIndexerPropertyChanged() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7AD40 Offset: 0xB79F40 VA: 0x180B7AD40
	|-ObservableCollection<__Il2CppFullySharedGenericType>.OnIndexerPropertyChanged
	*/

	// RVA: -1 Offset: -1
	private void OnCollectionChanged(NotifyCollectionChangedAction action, object item, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7AAE0 Offset: 0xB79CE0 VA: 0x180B7AAE0
	|-ObservableCollection<__Il2CppFullySharedGenericType>.OnCollectionChanged
	*/

	// RVA: -1 Offset: -1
	private void OnCollectionChanged(NotifyCollectionChangedAction action, object item, int index, int oldIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7AB80 Offset: 0xB79D80 VA: 0x180B7AB80
	|-ObservableCollection<__Il2CppFullySharedGenericType>.OnCollectionChanged
	*/

	// RVA: -1 Offset: -1
	private void OnCollectionChanged(NotifyCollectionChangedAction action, object oldItem, object newItem, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7A9C0 Offset: 0xB79BC0 VA: 0x180B7A9C0
	|-ObservableCollection<__Il2CppFullySharedGenericType>.OnCollectionChanged
	*/

	// RVA: -1 Offset: -1
	private void OnCollectionReset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7AC30 Offset: 0xB79E30 VA: 0x180B7AC30
	|-ObservableCollection<__Il2CppFullySharedGenericType>.OnCollectionReset
	*/

	// RVA: -1 Offset: -1
	private ObservableCollection.SimpleMonitor<T> EnsureMonitorInitialized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7A4B0 Offset: 0xB796B0 VA: 0x180B7A4B0
	|-ObservableCollection<__Il2CppFullySharedGenericType>.EnsureMonitorInitialized
	*/

	[OnSerializing]
	// RVA: -1 Offset: -1
	private void OnSerializing(StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7ADD0 Offset: 0xB79FD0 VA: 0x180B7ADD0
	|-ObservableCollection<__Il2CppFullySharedGenericType>.OnSerializing
	*/

	[OnDeserialized]
	// RVA: -1 Offset: -1
	private void OnDeserialized(StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7AD10 Offset: 0xB79F10 VA: 0x180B7AD10
	|-ObservableCollection<__Il2CppFullySharedGenericType>.OnDeserialized
	*/
}

// Namespace: System.Collections.ObjectModel
internal static class EventArgsCache // TypeDefIndex: 5491
{
	// Fields
	internal static readonly PropertyChangedEventArgs CountPropertyChanged; // 0x0
	internal static readonly PropertyChangedEventArgs IndexerPropertyChanged; // 0x8
	internal static readonly NotifyCollectionChangedEventArgs ResetCollectionChanged; // 0x10

	// Methods

	// RVA: 0x21042C0 Offset: 0x21034C0 VA: 0x1821042C0
	private static void .cctor() { }
}

// Namespace: System.Collections.ObjectModel
[DebuggerTypeProxy(typeof(CollectionDebugView<T>))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class ReadOnlyObservableCollection<T> : ReadOnlyCollection<T>, INotifyCollectionChanged, INotifyPropertyChanged // TypeDefIndex: 5492
{
	// Fields
	[CompilerGenerated]
	private NotifyCollectionChangedEventHandler CollectionChanged; // 0x0
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanged; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ObservableCollection<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD4C60 Offset: 0xBD3E60 VA: 0x180BD4C60
	|-ReadOnlyObservableCollection<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private void System.Collections.Specialized.INotifyCollectionChanged.add_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD4BE0 Offset: 0xBD3DE0 VA: 0x180BD4BE0
	|-ReadOnlyObservableCollection<__Il2CppFullySharedGenericType>.System.Collections.Specialized.INotifyCollectionChanged.add_CollectionChanged
	*/

	// RVA: -1 Offset: -1 Slot: 36
	private void System.Collections.Specialized.INotifyCollectionChanged.remove_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD4C00 Offset: 0xBD3E00 VA: 0x180BD4C00
	|-ReadOnlyObservableCollection<__Il2CppFullySharedGenericType>.System.Collections.Specialized.INotifyCollectionChanged.remove_CollectionChanged
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 39
	protected virtual void add_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD4F30 Offset: 0xBD4130 VA: 0x180BD4F30
	|-ReadOnlyObservableCollection<__Il2CppFullySharedGenericType>.add_CollectionChanged
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 40
	protected virtual void remove_CollectionChanged(NotifyCollectionChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD5070 Offset: 0xBD4270 VA: 0x180BD5070
	|-ReadOnlyObservableCollection<__Il2CppFullySharedGenericType>.remove_CollectionChanged
	*/

	// RVA: -1 Offset: -1 Slot: 41
	protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD4B80 Offset: 0xBD3D80 VA: 0x180BD4B80
	|-ReadOnlyObservableCollection<__Il2CppFullySharedGenericType>.OnCollectionChanged
	*/

	// RVA: -1 Offset: -1 Slot: 37
	private void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD4C20 Offset: 0xBD3E20 VA: 0x180BD4C20
	|-ReadOnlyObservableCollection<__Il2CppFullySharedGenericType>.System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged
	*/

	// RVA: -1 Offset: -1 Slot: 38
	private void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD4C40 Offset: 0xBD3E40 VA: 0x180BD4C40
	|-ReadOnlyObservableCollection<__Il2CppFullySharedGenericType>.System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 42
	protected virtual void add_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD4FD0 Offset: 0xBD41D0 VA: 0x180BD4FD0
	|-ReadOnlyObservableCollection<__Il2CppFullySharedGenericType>.add_PropertyChanged
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 43
	protected virtual void remove_PropertyChanged(PropertyChangedEventHandler value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD5110 Offset: 0xBD4310 VA: 0x180BD5110
	|-ReadOnlyObservableCollection<__Il2CppFullySharedGenericType>.remove_PropertyChanged
	*/

	// RVA: -1 Offset: -1 Slot: 44
	protected virtual void OnPropertyChanged(PropertyChangedEventArgs args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD4BB0 Offset: 0xBD3DB0 VA: 0x180BD4BB0
	|-ReadOnlyObservableCollection<__Il2CppFullySharedGenericType>.OnPropertyChanged
	*/

	// RVA: -1 Offset: -1
	private void HandleCollectionChanged(object sender, NotifyCollectionChangedEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD4B40 Offset: 0xBD3D40 VA: 0x180BD4B40
	|-ReadOnlyObservableCollection<__Il2CppFullySharedGenericType>.HandleCollectionChanged
	*/

	// RVA: -1 Offset: -1
	private void HandlePropertyChanged(object sender, PropertyChangedEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD4B60 Offset: 0xBD3D60 VA: 0x180BD4B60
	|-ReadOnlyObservableCollection<__Il2CppFullySharedGenericType>.HandlePropertyChanged
	*/
}

// Namespace: System.Collections.Specialized
public class CollectionsUtil // TypeDefIndex: 5493
{
	// Methods

	// RVA: 0x20FD960 Offset: 0x20FCB60 VA: 0x1820FD960
	public static Hashtable CreateCaseInsensitiveHashtable() { }

	// RVA: 0x20FD840 Offset: 0x20FCA40 VA: 0x1820FD840
	public static Hashtable CreateCaseInsensitiveHashtable(int capacity) { }

	// RVA: 0x20FD8D0 Offset: 0x20FCAD0 VA: 0x1820FD8D0
	public static Hashtable CreateCaseInsensitiveHashtable(IDictionary d) { }

	// RVA: 0x20FD9E0 Offset: 0x20FCBE0 VA: 0x1820FD9E0
	public static SortedList CreateCaseInsensitiveSortedList() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[IsReadOnly]
public struct BitVector32.Section // TypeDefIndex: 5494
{
	// Fields
	private readonly short _mask; // 0x0
	private readonly short _offset; // 0x2

	// Properties
	public short Mask { get; }
	public short Offset { get; }

	// Methods

	// RVA: 0x16DBF30 Offset: 0x16DB130 VA: 0x1816DBF30
	internal void .ctor(short mask, short offset) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0DF0 VA: 0x1804D1BF0
	public short get_Mask() { }

	// RVA: 0x4D1BE0 Offset: 0x4D0DE0 VA: 0x1804D1BE0
	public short get_Offset() { }

	// RVA: 0x2113CF0 Offset: 0x2112EF0 VA: 0x182113CF0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2113CD0 Offset: 0x2112ED0 VA: 0x182113CD0
	public bool Equals(BitVector32.Section obj) { }

	// RVA: 0x2114010 Offset: 0x2113210 VA: 0x182114010
	public static bool op_Equality(BitVector32.Section a, BitVector32.Section b) { }

	// RVA: 0x2114030 Offset: 0x2113230 VA: 0x182114030
	public static bool op_Inequality(BitVector32.Section a, BitVector32.Section b) { }

	// RVA: 0x2113D80 Offset: 0x2112F80 VA: 0x182113D80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2113EF0 Offset: 0x21130F0 VA: 0x182113EF0
	public static string ToString(BitVector32.Section value) { }

	// RVA: 0x2113DD0 Offset: 0x2112FD0 VA: 0x182113DD0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
public struct BitVector32 // TypeDefIndex: 5495
{
	// Fields
	private uint _data; // 0x0

	// Properties
	public bool Item { get; set; }
	public int Item { get; set; }
	public int Data { get; }

	// Methods

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void .ctor(int data) { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void .ctor(BitVector32 value) { }

	// RVA: 0x20FD3A0 Offset: 0x20FC5A0 VA: 0x1820FD3A0
	public bool get_Item(int bit) { }

	// RVA: 0x20FD3F0 Offset: 0x20FC5F0 VA: 0x1820FD3F0
	public void set_Item(int bit, bool value) { }

	// RVA: 0x20FD380 Offset: 0x20FC580 VA: 0x1820FD380
	public int get_Item(BitVector32.Section section) { }

	// RVA: 0x20FD3C0 Offset: 0x20FC5C0 VA: 0x1820FD3C0
	public void set_Item(BitVector32.Section section, int value) { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public int get_Data() { }

	// RVA: 0x20FCE90 Offset: 0x20FC090 VA: 0x1820FCE90
	private static short CountBitsSet(short mask) { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10
	public static int CreateMask() { }

	// RVA: 0x20FCEE0 Offset: 0x20FC0E0 VA: 0x1820FCEE0
	public static int CreateMask(int previous) { }

	// RVA: 0x20FCEB0 Offset: 0x20FC0B0 VA: 0x1820FCEB0
	private static short CreateMaskFromHighValue(short highValue) { }

	// RVA: 0x20FD0E0 Offset: 0x20FC2E0 VA: 0x1820FD0E0
	public static BitVector32.Section CreateSection(short maxValue) { }

	// RVA: 0x20FD0D0 Offset: 0x20FC2D0 VA: 0x1820FD0D0
	public static BitVector32.Section CreateSection(short maxValue, BitVector32.Section previous) { }

	// RVA: 0x20FCF60 Offset: 0x20FC160 VA: 0x1820FCF60
	private static BitVector32.Section CreateSectionHelper(short maxValue, short priorMask, short priorOffset) { }

	// RVA: 0x20FD0F0 Offset: 0x20FC2F0 VA: 0x1820FD0F0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x20FD170 Offset: 0x20FC370 VA: 0x1820FD170 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20FD2A0 Offset: 0x20FC4A0 VA: 0x1820FD2A0
	public static string ToString(BitVector32 value) { }

	// RVA: 0x20FD1C0 Offset: 0x20FC3C0 VA: 0x1820FD1C0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
[Serializable]
public class HybridDictionary : IDictionary, ICollection, IEnumerable // TypeDefIndex: 5496
{
	// Fields
	private const int CutoverPoint = 9;
	private const int InitialHashtableSize = 13;
	private const int FixedSizeCutoverPoint = 6;
	private ListDictionary list; // 0x10
	private Hashtable hashtable; // 0x18
	private readonly bool caseInsensitive; // 0x20

	// Properties
	public object Item { get; set; }
	private ListDictionary List { get; }
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

	// RVA: 0x2105D10 Offset: 0x2104F10 VA: 0x182105D10
	public void .ctor(int initialSize) { }

	// RVA: 0x2105CE0 Offset: 0x2104EE0 VA: 0x182105CE0
	public void .ctor(bool caseInsensitive) { }

	// RVA: 0x2105D90 Offset: 0x2104F90 VA: 0x182105D90
	public void .ctor(int initialSize, bool caseInsensitive) { }

	// RVA: 0x2105EE0 Offset: 0x21050E0 VA: 0x182105EE0 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x21062E0 Offset: 0x21054E0 VA: 0x1821062E0 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x2106150 Offset: 0x2105350 VA: 0x182106150
	private ListDictionary get_List() { }

	// RVA: 0x21052E0 Offset: 0x21044E0 VA: 0x1821052E0
	private void ChangeOver() { }

	// RVA: 0x2105EB0 Offset: 0x21050B0 VA: 0x182105EB0 Slot: 16
	public int get_Count() { }

	// RVA: 0x21060B0 Offset: 0x21052B0 VA: 0x1821060B0 Slot: 6
	public ICollection get_Keys() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 11
	public bool get_IsReadOnly() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 12
	public bool get_IsFixedSize() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 18
	public bool get_IsSynchronized() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 17
	public object get_SyncRoot() { }

	// RVA: 0x2106240 Offset: 0x2105440 VA: 0x182106240 Slot: 7
	public ICollection get_Values() { }

	// RVA: 0x21051B0 Offset: 0x21043B0 VA: 0x1821051B0 Slot: 9
	public void Add(object key, object value) { }

	// RVA: 0x2105620 Offset: 0x2104820 VA: 0x182105620 Slot: 10
	public void Clear() { }

	// RVA: 0x2105680 Offset: 0x2104880 VA: 0x182105680 Slot: 8
	public bool Contains(object key) { }

	// RVA: 0x2105830 Offset: 0x2104A30 VA: 0x182105830 Slot: 15
	public void CopyTo(Array array, int index) { }

	// RVA: 0x21058A0 Offset: 0x2104AA0 VA: 0x1821058A0 Slot: 13
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x2105BB0 Offset: 0x2104DB0 VA: 0x182105BB0 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x21059D0 Offset: 0x2104BD0 VA: 0x1821059D0 Slot: 14
	public void Remove(object key) { }
}

// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
public interface IOrderedDictionary : IDictionary, ICollection, IEnumerable // TypeDefIndex: 5497
{
	// Properties
	public abstract object Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_Item(int index);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Item(int index, object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IDictionaryEnumerator GetEnumerator();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Insert(int index, object key, object value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void RemoveAt(int index);
}

// Namespace: 
private class ListDictionary.NodeEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 5498
{
	// Fields
	private ListDictionary _list; // 0x10
	private ListDictionary.DictionaryNode _current; // 0x18
	private int _version; // 0x20
	private bool _start; // 0x24

	// Properties
	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x1724EA0 Offset: 0x17240A0 VA: 0x181724EA0
	public void .ctor(ListDictionary list) { }

	// RVA: 0x210DE70 Offset: 0x210D070 VA: 0x18210DE70 Slot: 8
	public object get_Current() { }

	// RVA: 0x210DF30 Offset: 0x210D130 VA: 0x18210DF30 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x210DFB0 Offset: 0x210D1B0 VA: 0x18210DFB0 Slot: 4
	public object get_Key() { }

	// RVA: 0x210E020 Offset: 0x210D220 VA: 0x18210E020 Slot: 5
	public object get_Value() { }

	// RVA: 0x210DD30 Offset: 0x210CF30 VA: 0x18210DD30 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x210DDF0 Offset: 0x210CFF0 VA: 0x18210DDF0 Slot: 9
	public void Reset() { }
}

// Namespace: 
private class ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator : IEnumerator // TypeDefIndex: 5499
{
	// Fields
	private ListDictionary _list; // 0x10
	private ListDictionary.DictionaryNode _current; // 0x18
	private int _version; // 0x20
	private bool _isKeys; // 0x24
	private bool _start; // 0x25

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x17255B0 Offset: 0x17247B0 VA: 0x1817255B0
	public void .ctor(ListDictionary list, bool isKeys) { }

	// RVA: 0x210E440 Offset: 0x210D640 VA: 0x18210E440 Slot: 5
	public object get_Current() { }

	// RVA: 0x210E300 Offset: 0x210D500 VA: 0x18210E300 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x210E3C0 Offset: 0x210D5C0 VA: 0x18210E3C0 Slot: 6
	public void Reset() { }
}

// Namespace: 
private class ListDictionary.NodeKeyValueCollection : ICollection, IEnumerable // TypeDefIndex: 5500
{
	// Fields
	private ListDictionary _list; // 0x10
	private bool _isKeys; // 0x18

	// Properties
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x11FF670 Offset: 0x11FE870 VA: 0x1811FF670
	public void .ctor(ListDictionary list, bool isKeys) { }

	// RVA: 0x210E090 Offset: 0x210D290 VA: 0x18210E090 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1725320 Offset: 0x1724520 VA: 0x181725320 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x210E1F0 Offset: 0x210D3F0 VA: 0x18210E1F0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x210E270 Offset: 0x210D470 VA: 0x18210E270 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[Serializable]
public class ListDictionary.DictionaryNode // TypeDefIndex: 5501
{
	// Fields
	public object key; // 0x10
	public object value; // 0x18
	public ListDictionary.DictionaryNode next; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
[Serializable]
public class ListDictionary : IDictionary, ICollection, IEnumerable // TypeDefIndex: 5502
{
	// Fields
	private ListDictionary.DictionaryNode head; // 0x10
	private int version; // 0x18
	private int count; // 0x1C
	private readonly IComparer comparer; // 0x20
	private object _syncRoot; // 0x28

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

	// RVA: 0x1B72200 Offset: 0x1B71400 VA: 0x181B72200
	public void .ctor(IComparer comparer) { }

	// RVA: 0x2108050 Offset: 0x2107250 VA: 0x182108050 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x21082C0 Offset: 0x21074C0 VA: 0x1821082C0 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110 Slot: 16
	public int get_Count() { }

	// RVA: 0x2108190 Offset: 0x2107390 VA: 0x182108190 Slot: 6
	public ICollection get_Keys() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 11
	public bool get_IsReadOnly() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 12
	public bool get_IsFixedSize() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 18
	public bool get_IsSynchronized() { }

	// RVA: 0x21081F0 Offset: 0x21073F0 VA: 0x1821081F0 Slot: 17
	public object get_SyncRoot() { }

	// RVA: 0x2108260 Offset: 0x2107460 VA: 0x182108260 Slot: 7
	public ICollection get_Values() { }

	// RVA: 0x2107920 Offset: 0x2106B20 VA: 0x182107920 Slot: 9
	public void Add(object key, object value) { }

	// RVA: 0x17244F0 Offset: 0x17236F0 VA: 0x1817244F0 Slot: 10
	public void Clear() { }

	// RVA: 0x2107AF0 Offset: 0x2106CF0 VA: 0x182107AF0 Slot: 8
	public bool Contains(object key) { }

	// RVA: 0x2107C10 Offset: 0x2106E10 VA: 0x182107C10 Slot: 15
	public void CopyTo(Array array, int index) { }

	// RVA: 0x2107E00 Offset: 0x2107000 VA: 0x182107E00 Slot: 13
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x2107FD0 Offset: 0x21071D0 VA: 0x182107FD0 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2107E80 Offset: 0x2107080 VA: 0x182107E80 Slot: 14
	public void Remove(object key) { }
}

// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
[Serializable]
public class NameValueCollection : NameObjectCollectionBase // TypeDefIndex: 5503
{
	// Fields
	private string[] _all; // 0x58
	private string[] _allKeys; // 0x60

	// Properties
	public string Item { get; set; }
	public string Item { get; }
	public virtual string[] AllKeys { get; }

	// Methods

	// RVA: 0x210DA30 Offset: 0x210CC30 VA: 0x18210DA30
	public void .ctor() { }

	// RVA: 0x210D650 Offset: 0x210C850 VA: 0x18210D650
	public void .ctor(NameValueCollection col) { }

	[Obsolete("Please use NameValueCollection(IEqualityComparer) instead.")]
	// RVA: 0x210D8A0 Offset: 0x210CAA0 VA: 0x18210D8A0
	public void .ctor(IHashCodeProvider hashProvider, IComparer comparer) { }

	// RVA: 0x210D6F0 Offset: 0x210C8F0 VA: 0x18210D6F0
	public void .ctor(int capacity) { }

	// RVA: 0x210D4D0 Offset: 0x210C6D0 VA: 0x18210D4D0
	public void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x210D450 Offset: 0x210C650 VA: 0x18210D450
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x210D530 Offset: 0x210C730 VA: 0x18210D530
	public void .ctor(int capacity, NameValueCollection col) { }

	[Obsolete("Please use NameValueCollection(Int32, IEqualityComparer) instead.")]
	// RVA: 0x210D7D0 Offset: 0x210C9D0 VA: 0x18210D7D0
	public void .ctor(int capacity, IHashCodeProvider hashProvider, IComparer comparer) { }

	// RVA: 0x210D9D0 Offset: 0x210CBD0 VA: 0x18210D9D0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x210D2A0 Offset: 0x210C4A0 VA: 0x18210D2A0
	protected void InvalidateCachedArrays() { }

	// RVA: 0x210CD70 Offset: 0x210BF70 VA: 0x18210CD70
	private static string GetAsOneString(ArrayList list) { }

	// RVA: 0x210CF40 Offset: 0x210C140 VA: 0x18210CF40
	private static string[] GetAsStringArray(ArrayList list) { }

	// RVA: 0x210C7F0 Offset: 0x210B9F0 VA: 0x18210C7F0
	public void Add(NameValueCollection c) { }

	// RVA: 0x210C970 Offset: 0x210BB70 VA: 0x18210C970 Slot: 16
	public virtual void Clear() { }

	// RVA: 0x210CA40 Offset: 0x210BC40 VA: 0x18210CA40
	public void CopyTo(Array dest, int index) { }

	// RVA: 0x75C760 Offset: 0x75B960 VA: 0x18075C760
	public bool HasKeys() { }

	// RVA: 0x210A1F0 Offset: 0x21093F0 VA: 0x18210A1F0 Slot: 17
	internal virtual bool InternalHasKeys() { }

	// RVA: 0x210C660 Offset: 0x210B860 VA: 0x18210C660 Slot: 18
	public virtual void Add(string name, string value) { }

	// RVA: 0x210D1F0 Offset: 0x210C3F0 VA: 0x18210D1F0 Slot: 19
	public virtual string Get(string name) { }

	// RVA: 0x210D000 Offset: 0x210C200 VA: 0x18210D000 Slot: 20
	public virtual string[] GetValues(string name) { }

	// RVA: 0x210D2D0 Offset: 0x210C4D0 VA: 0x18210D2D0 Slot: 21
	public virtual void Set(string name, string value) { }

	// RVA: 0x210D2B0 Offset: 0x210C4B0 VA: 0x18210D2B0 Slot: 22
	public virtual void Remove(string name) { }

	// RVA: 0x210DCF0 Offset: 0x210CEF0 VA: 0x18210DCF0
	public string get_Item(string name) { }

	// RVA: 0x210DD10 Offset: 0x210CF10 VA: 0x18210DD10
	public void set_Item(string name, string value) { }

	// RVA: 0x210D150 Offset: 0x210C350 VA: 0x18210D150 Slot: 23
	public virtual string Get(int index) { }

	// RVA: 0x210D0B0 Offset: 0x210C2B0 VA: 0x18210D0B0 Slot: 24
	public virtual string[] GetValues(int index) { }

	// RVA: 0x210CFF0 Offset: 0x210C1F0 VA: 0x18210CFF0 Slot: 25
	public virtual string GetKey(int index) { }

	// RVA: 0x184CCD0 Offset: 0x184BED0 VA: 0x18184CCD0
	public string get_Item(int index) { }

	// RVA: 0x210DC00 Offset: 0x210CE00 VA: 0x18210DC00 Slot: 26
	public virtual string[] get_AllKeys() { }

	// RVA: 0x210DBB0 Offset: 0x210CDB0 VA: 0x18210DBB0
	internal void .ctor(DBNull dummy) { }
}

// Namespace: 
private class OrderedDictionary.OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 5504
{
	// Fields
	private int _objectReturnType; // 0x10
	internal const int Keys = 1;
	internal const int Values = 2;
	internal const int DictionaryEntry = 3;
	private IEnumerator _arrayEnumerator; // 0x18

	// Properties
	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x2110490 Offset: 0x210F690 VA: 0x182110490
	internal void .ctor(ArrayList array, int objectReturnType) { }

	// RVA: 0x21104F0 Offset: 0x210F6F0 VA: 0x1821104F0 Slot: 8
	public object get_Current() { }

	// RVA: 0x2110700 Offset: 0x210F900 VA: 0x182110700 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x2110810 Offset: 0x210FA10 VA: 0x182110810 Slot: 4
	public object get_Key() { }

	// RVA: 0x21108A0 Offset: 0x210FAA0 VA: 0x1821108A0 Slot: 5
	public object get_Value() { }

	// RVA: 0x21103F0 Offset: 0x210F5F0 VA: 0x1821103F0 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x2110440 Offset: 0x210F640 VA: 0x182110440 Slot: 9
	public void Reset() { }
}

// Namespace: 
private class OrderedDictionary.OrderedDictionaryKeyValueCollection : ICollection, IEnumerable // TypeDefIndex: 5505
{
	// Fields
	private ArrayList _objects; // 0x10
	private bool _isKeys; // 0x18

	// Properties
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x11FF670 Offset: 0x11FE870 VA: 0x1811FF670
	public void .ctor(ArrayList array, bool isKeys) { }

	// RVA: 0x2110930 Offset: 0x210FB30 VA: 0x182110930 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1719620 Offset: 0x1718820 VA: 0x181719620 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1718E40 Offset: 0x1718040 VA: 0x181718E40 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x2110C70 Offset: 0x210FE70 VA: 0x182110C70 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
[Serializable]
public class OrderedDictionary : IOrderedDictionary, IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback // TypeDefIndex: 5506
{
	// Fields
	private ArrayList _objectsArray; // 0x10
	private Hashtable _objectsTable; // 0x18
	private int _initialCapacity; // 0x20
	private IEqualityComparer _comparer; // 0x28
	private bool _readOnly; // 0x30
	private object _syncRoot; // 0x38
	private SerializationInfo _siInfo; // 0x40
	private const string KeyComparerName = "KeyComparer";
	private const string ArrayListName = "ArrayList";
	private const string ReadOnlyName = "ReadOnly";
	private const string InitCapacityName = "InitialCapacity";

	// Properties
	public int Count { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	public bool IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	public ICollection Keys { get; }
	private ArrayList objectsArray { get; }
	private Hashtable objectsTable { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public object Item { get; set; }
	public object Item { get; set; }
	public ICollection Values { get; }

	// Methods

	// RVA: 0x2111E40 Offset: 0x2111040 VA: 0x182111E40
	public void .ctor() { }

	// RVA: 0x2111DE0 Offset: 0x2110FE0 VA: 0x182111DE0
	public void .ctor(int capacity) { }

	// RVA: 0x2111E10 Offset: 0x2111010 VA: 0x182111E10
	public void .ctor(IEqualityComparer comparer) { }

	// RVA: 0x2111E60 Offset: 0x2111060 VA: 0x182111E60
	public void .ctor(int capacity, IEqualityComparer comparer) { }

	// RVA: 0x2111D90 Offset: 0x2110F90 VA: 0x182111D90
	private void .ctor(OrderedDictionary dictionary) { }

	// RVA: 0x121F770 Offset: 0x121E970 VA: 0x18121F770
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2111EA0 Offset: 0x21110A0 VA: 0x182111EA0 Slot: 21
	public int get_Count() { }

	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40 Slot: 17
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40 Slot: 16
	public bool get_IsReadOnly() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 23
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x2111FC0 Offset: 0x21111C0 VA: 0x182111FC0 Slot: 11
	public ICollection get_Keys() { }

	// RVA: 0x21120A0 Offset: 0x21112A0 VA: 0x1821120A0
	private ArrayList get_objectsArray() { }

	// RVA: 0x2112120 Offset: 0x2111320 VA: 0x182112120
	private Hashtable get_objectsTable() { }

	// RVA: 0x2111C70 Offset: 0x2110E70 VA: 0x182111C70 Slot: 22
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x2111F20 Offset: 0x2111120 VA: 0x182111F20 Slot: 4
	public object get_Item(int index) { }

	// RVA: 0x2112460 Offset: 0x2111660 VA: 0x182112460 Slot: 5
	public void set_Item(int index, object value) { }

	// RVA: 0x2111EE0 Offset: 0x21110E0 VA: 0x182111EE0 Slot: 9
	public object get_Item(object key) { }

	// RVA: 0x21121B0 Offset: 0x21113B0 VA: 0x1821121B0 Slot: 10
	public void set_Item(object key, object value) { }

	// RVA: 0x2112030 Offset: 0x2111230 VA: 0x182112030 Slot: 12
	public ICollection get_Values() { }

	// RVA: 0x2110D10 Offset: 0x210FF10 VA: 0x182110D10 Slot: 14
	public void Add(object key, object value) { }

	// RVA: 0x2110EC0 Offset: 0x21100C0 VA: 0x182110EC0 Slot: 15
	public void Clear() { }

	// RVA: 0x2110E40 Offset: 0x2110040 VA: 0x182110E40
	public OrderedDictionary AsReadOnly() { }

	// RVA: 0x2110F70 Offset: 0x2110170 VA: 0x182110F70 Slot: 13
	public bool Contains(object key) { }

	// RVA: 0x2110FB0 Offset: 0x21101B0 VA: 0x182110FB0 Slot: 20
	public void CopyTo(Array array, int index) { }

	// RVA: 0x2111270 Offset: 0x2110470 VA: 0x182111270
	private int IndexOfKey(object key) { }

	// RVA: 0x21113E0 Offset: 0x21105E0 VA: 0x1821113E0 Slot: 7
	public void Insert(int index, object key, object value) { }

	// RVA: 0x2111950 Offset: 0x2110B50 VA: 0x182111950 Slot: 8
	public void RemoveAt(int index) { }

	// RVA: 0x2111B30 Offset: 0x2110D30 VA: 0x182111B30 Slot: 19
	public void Remove(object key) { }

	// RVA: 0x2111000 Offset: 0x2110200 VA: 0x182111000 Slot: 27
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x2111CE0 Offset: 0x2110EE0 VA: 0x182111CE0 Slot: 24
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2111090 Offset: 0x2110290 VA: 0x182111090 Slot: 28
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2111D70 Offset: 0x2110F70 VA: 0x182111D70 Slot: 26
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x21115B0 Offset: 0x21107B0 VA: 0x1821115B0 Slot: 29
	protected virtual void OnDeserialization(object sender) { }
}

// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
[Serializable]
public class StringCollection : IList, ICollection, IEnumerable // TypeDefIndex: 5507
{
	// Fields
	private readonly ArrayList data; // 0x10

	// Properties
	public string Item { get; set; }
	public int Count { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	public bool IsReadOnly { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x2116C40 Offset: 0x2115E40 VA: 0x182116C40
	public string get_Item(int index) { }

	// RVA: 0x2116DB0 Offset: 0x2115FB0 VA: 0x182116DB0
	public void set_Item(int index, string value) { }

	// RVA: 0x1719620 Offset: 0x1718820 VA: 0x181719620 Slot: 16
	public int get_Count() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x2116860 Offset: 0x2115A60 VA: 0x182116860
	public int Add(string value) { }

	// RVA: 0x21167D0 Offset: 0x21159D0 VA: 0x1821167D0
	public void AddRange(string[] value) { }

	// RVA: 0x159D610 Offset: 0x159C810 VA: 0x18159D610 Slot: 8
	public void Clear() { }

	// RVA: 0x1718F80 Offset: 0x1718180 VA: 0x181718F80
	public bool Contains(string value) { }

	// RVA: 0x1718DE0 Offset: 0x1717FE0 VA: 0x181718DE0
	public void CopyTo(string[] array, int index) { }

	// RVA: 0x2116890 Offset: 0x2115A90 VA: 0x182116890
	public StringEnumerator GetEnumerator() { }

	// RVA: 0x1718FB0 Offset: 0x17181B0 VA: 0x181718FB0
	public int IndexOf(string value) { }

	// RVA: 0x2116920 Offset: 0x2115B20 VA: 0x182116920
	public void Insert(int index, string value) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	public bool get_IsReadOnly() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 18
	public bool get_IsSynchronized() { }

	// RVA: 0x2116980 Offset: 0x2115B80 VA: 0x182116980
	public void Remove(string value) { }

	// RVA: 0x2116950 Offset: 0x2115B50 VA: 0x182116950 Slot: 14
	public void RemoveAt(int index) { }

	// RVA: 0x1718E40 Offset: 0x1718040 VA: 0x181718E40 Slot: 17
	public object get_SyncRoot() { }

	// RVA: 0x2116C40 Offset: 0x2115E40 VA: 0x182116C40 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x2116CC0 Offset: 0x2115EC0 VA: 0x182116CC0 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x21169B0 Offset: 0x2115BB0 VA: 0x1821169B0 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x2116A30 Offset: 0x2115C30 VA: 0x182116A30 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x2116AB0 Offset: 0x2115CB0 VA: 0x182116AB0 Slot: 11
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x2116B30 Offset: 0x2115D30 VA: 0x182116B30 Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x2116BC0 Offset: 0x2115DC0 VA: 0x182116BC0 Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1718DE0 Offset: 0x1717FE0 VA: 0x181718DE0 Slot: 15
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x154B250 Offset: 0x154A450 VA: 0x18154B250 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2116D50 Offset: 0x2115F50 VA: 0x182116D50
	public void .ctor() { }
}

// Namespace: System.Collections.Specialized
public class StringEnumerator // TypeDefIndex: 5508
{
	// Fields
	private IEnumerator _baseEnumerator; // 0x10
	private IEnumerable _temp; // 0x18

	// Properties
	public string Current { get; }

	// Methods

	// RVA: 0x21172C0 Offset: 0x21164C0 VA: 0x1821172C0
	internal void .ctor(StringCollection mappings) { }

	// RVA: 0x2117330 Offset: 0x2116530 VA: 0x182117330
	public string get_Current() { }

	// RVA: 0x21171F0 Offset: 0x21163F0 VA: 0x1821171F0
	public bool MoveNext() { }

	// RVA: 0x2117240 Offset: 0x2116440 VA: 0x182117240
	public void Reset() { }

	// RVA: 0x2117290 Offset: 0x2116490 VA: 0x182117290
	internal void .ctor() { }
}

// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
[Serializable]
public class StringDictionary : IEnumerable // TypeDefIndex: 5509
{
	// Fields
	internal Hashtable contents; // 0x10

	// Properties
	public virtual int Count { get; }
	public virtual bool IsSynchronized { get; }
	public virtual string Item { get; set; }
	public virtual ICollection Keys { get; }
	public virtual object SyncRoot { get; }
	public virtual ICollection Values { get; }

	// Methods

	// RVA: 0x20FD5C0 Offset: 0x20FC7C0 VA: 0x1820FD5C0
	public void .ctor() { }

	// RVA: 0x1E38450 Offset: 0x1E37650 VA: 0x181E38450 Slot: 5
	public virtual int get_Count() { }

	// RVA: 0x1738040 Offset: 0x1737240 VA: 0x181738040 Slot: 6
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x2117030 Offset: 0x2116230 VA: 0x182117030 Slot: 7
	public virtual string get_Item(string key) { }

	// RVA: 0x2117150 Offset: 0x2116350 VA: 0x182117150 Slot: 8
	public virtual void set_Item(string key, string value) { }

	// RVA: 0x18AEFE0 Offset: 0x18AE1E0 VA: 0x1818AEFE0 Slot: 9
	public virtual ICollection get_Keys() { }

	// RVA: 0x8D0650 Offset: 0x8CF850 VA: 0x1808D0650 Slot: 10
	public virtual object get_SyncRoot() { }

	// RVA: 0x2117120 Offset: 0x2116320 VA: 0x182117120 Slot: 11
	public virtual ICollection get_Values() { }

	// RVA: 0x2116DE0 Offset: 0x2115FE0 VA: 0x182116DE0 Slot: 12
	public virtual void Add(string key, string value) { }

	// RVA: 0x17192F0 Offset: 0x17184F0 VA: 0x1817192F0 Slot: 13
	public virtual void Clear() { }

	// RVA: 0x2116EE0 Offset: 0x21160E0 VA: 0x182116EE0 Slot: 14
	public virtual bool ContainsKey(string key) { }

	// RVA: 0xB10540 Offset: 0xB0F740 VA: 0x180B10540 Slot: 15
	public virtual bool ContainsValue(string value) { }

	// RVA: 0x2116F70 Offset: 0x2116170 VA: 0x182116F70 Slot: 16
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x1E38360 Offset: 0x1E37560 VA: 0x181E38360 Slot: 17
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x2116FA0 Offset: 0x21161A0 VA: 0x182116FA0 Slot: 18
	public virtual void Remove(string key) { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void ReplaceHashtable(Hashtable useThisHashtableInstead) { }

	// RVA: 0x2116E80 Offset: 0x2116080 VA: 0x182116E80
	internal IDictionary<string, string> AsGenericDictionary() { }
}

// Namespace: System.Collections.Specialized
public interface INotifyCollectionChanged // TypeDefIndex: 5510
{
	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_CollectionChanged(NotifyCollectionChangedEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_CollectionChanged(NotifyCollectionChangedEventHandler value);
}

// Namespace: System.Collections.Specialized
public enum NotifyCollectionChangedAction // TypeDefIndex: 5511
{
	// Fields
	public int value__; // 0x0
	public const NotifyCollectionChangedAction Add = 0;
	public const NotifyCollectionChangedAction Remove = 1;
	public const NotifyCollectionChangedAction Replace = 2;
	public const NotifyCollectionChangedAction Move = 3;
	public const NotifyCollectionChangedAction Reset = 4;
}

// Namespace: System.Collections.Specialized
public class NotifyCollectionChangedEventArgs : EventArgs // TypeDefIndex: 5512
{
	// Fields
	private NotifyCollectionChangedAction _action; // 0x10
	private IList _newItems; // 0x18
	private IList _oldItems; // 0x20
	private int _newStartingIndex; // 0x28
	private int _oldStartingIndex; // 0x2C

	// Properties
	public NotifyCollectionChangedAction Action { get; }
	public IList NewItems { get; }
	public IList OldItems { get; }
	public int NewStartingIndex { get; }
	public int OldStartingIndex { get; }

	// Methods

	// RVA: 0x210EAC0 Offset: 0x210DCC0 VA: 0x18210EAC0
	public void .ctor(NotifyCollectionChangedAction action) { }

	// RVA: 0x210FBE0 Offset: 0x210EDE0 VA: 0x18210FBE0
	public void .ctor(NotifyCollectionChangedAction action, object changedItem) { }

	// RVA: 0x210E7C0 Offset: 0x210D9C0 VA: 0x18210E7C0
	public void .ctor(NotifyCollectionChangedAction action, object changedItem, int index) { }

	// RVA: 0x210F9F0 Offset: 0x210EBF0 VA: 0x18210F9F0
	public void .ctor(NotifyCollectionChangedAction action, IList changedItems) { }

	// RVA: 0x210F740 Offset: 0x210E940 VA: 0x18210F740
	public void .ctor(NotifyCollectionChangedAction action, IList changedItems, int startingIndex) { }

	// RVA: 0x210EBF0 Offset: 0x210DDF0 VA: 0x18210EBF0
	public void .ctor(NotifyCollectionChangedAction action, object newItem, object oldItem) { }

	// RVA: 0x210F4D0 Offset: 0x210E6D0 VA: 0x18210F4D0
	public void .ctor(NotifyCollectionChangedAction action, object newItem, object oldItem, int index) { }

	// RVA: 0x210FE80 Offset: 0x210F080 VA: 0x18210FE80
	public void .ctor(NotifyCollectionChangedAction action, IList newItems, IList oldItems) { }

	// RVA: 0x210F0E0 Offset: 0x210E2E0 VA: 0x18210F0E0
	public void .ctor(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex) { }

	// RVA: 0x210EE60 Offset: 0x210E060 VA: 0x18210EE60
	public void .ctor(NotifyCollectionChangedAction action, object changedItem, int index, int oldIndex) { }

	// RVA: 0x210F2C0 Offset: 0x210E4C0 VA: 0x18210F2C0
	public void .ctor(NotifyCollectionChangedAction action, IList changedItems, int index, int oldIndex) { }

	// RVA: 0x21100D0 Offset: 0x210F2D0 VA: 0x1821100D0
	internal void .ctor(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int newIndex, int oldIndex) { }

	// RVA: 0x210E4C0 Offset: 0x210D6C0 VA: 0x18210E4C0
	private void InitializeAddOrRemove(NotifyCollectionChangedAction action, IList changedItems, int startingIndex) { }

	// RVA: 0x210E5B0 Offset: 0x210D7B0 VA: 0x18210E5B0
	private void InitializeAdd(NotifyCollectionChangedAction action, IList newItems, int newStartingIndex) { }

	// RVA: 0x210E730 Offset: 0x210D930 VA: 0x18210E730
	private void InitializeRemove(NotifyCollectionChangedAction action, IList oldItems, int oldStartingIndex) { }

	// RVA: 0x210E640 Offset: 0x210D840 VA: 0x18210E640
	private void InitializeMoveOrReplace(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex, int oldStartingIndex) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public NotifyCollectionChangedAction get_Action() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public IList get_NewItems() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public IList get_OldItems() { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public int get_NewStartingIndex() { }

	// RVA: 0x5012C0 Offset: 0x5004C0 VA: 0x1805012C0
	public int get_OldStartingIndex() { }
}

// Namespace: System.Collections.Specialized
public sealed class NotifyCollectionChangedEventHandler : MulticastDelegate // TypeDefIndex: 5513
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object sender, NotifyCollectionChangedEventArgs e) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, NotifyCollectionChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
internal sealed class ReadOnlyList : IList, ICollection, IEnumerable // TypeDefIndex: 5514
{
	// Fields
	private readonly IList _list; // 0x10

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	public bool IsFixedSize { get; }
	public bool IsSynchronized { get; }
	public object Item { get; set; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(IList list) { }

	// RVA: 0x2112B20 Offset: 0x2111D20 VA: 0x182112B20 Slot: 16
	public int get_Count() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 9
	public bool get_IsReadOnly() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 10
	public bool get_IsFixedSize() { }

	// RVA: 0x2112B70 Offset: 0x2111D70 VA: 0x182112B70 Slot: 18
	public bool get_IsSynchronized() { }

	// RVA: 0x2112BC0 Offset: 0x2111DC0 VA: 0x182112BC0 Slot: 4
	public object get_Item(int index) { }

	// RVA: 0x2112C70 Offset: 0x2111E70 VA: 0x182112C70 Slot: 5
	public void set_Item(int index, object value) { }

	// RVA: 0x2112C20 Offset: 0x2111E20 VA: 0x182112C20 Slot: 17
	public object get_SyncRoot() { }

	// RVA: 0x2112810 Offset: 0x2111A10 VA: 0x182112810 Slot: 6
	public int Add(object value) { }

	// RVA: 0x2112860 Offset: 0x2111A60 VA: 0x182112860 Slot: 8
	public void Clear() { }

	// RVA: 0x21128B0 Offset: 0x2111AB0 VA: 0x1821128B0 Slot: 7
	public bool Contains(object value) { }

	// RVA: 0x2112910 Offset: 0x2111B10 VA: 0x182112910 Slot: 15
	public void CopyTo(Array array, int index) { }

	// RVA: 0x2112980 Offset: 0x2111B80 VA: 0x182112980 Slot: 19
	public IEnumerator GetEnumerator() { }

	// RVA: 0x21129D0 Offset: 0x2111BD0 VA: 0x1821129D0 Slot: 11
	public int IndexOf(object value) { }

	// RVA: 0x2112A30 Offset: 0x2111C30 VA: 0x182112A30 Slot: 12
	public void Insert(int index, object value) { }

	// RVA: 0x2112AD0 Offset: 0x2111CD0 VA: 0x182112AD0 Slot: 13
	public void Remove(object value) { }

	// RVA: 0x2112A80 Offset: 0x2111C80 VA: 0x182112A80 Slot: 14
	public void RemoveAt(int index) { }
}

// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
internal class CaseSensitiveStringDictionary : StringDictionary // TypeDefIndex: 5515
{
	// Properties
	public override string Item { get; set; }

	// Methods

	// RVA: 0x20FD5C0 Offset: 0x20FC7C0 VA: 0x1820FD5C0
	public void .ctor() { }

	// RVA: 0x20FD620 Offset: 0x20FC820 VA: 0x1820FD620 Slot: 7
	public override string get_Item(string key) { }

	// RVA: 0x20FD700 Offset: 0x20FC900 VA: 0x1820FD700 Slot: 8
	public override void set_Item(string key, string value) { }

	// RVA: 0x20FD410 Offset: 0x20FC610 VA: 0x1820FD410 Slot: 12
	public override void Add(string key, string value) { }

	// RVA: 0x20FD4A0 Offset: 0x20FC6A0 VA: 0x1820FD4A0 Slot: 14
	public override bool ContainsKey(string key) { }

	// RVA: 0x20FD530 Offset: 0x20FC730 VA: 0x1820FD530 Slot: 18
	public override void Remove(string key) { }
}

// Namespace: 
internal class NameObjectCollectionBase.NameObjectEntry // TypeDefIndex: 5516
{
	// Fields
	internal string Key; // 0x10
	internal object Value; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	internal void .ctor(string name, object value) { }
}

// Namespace: 
[Serializable]
internal class NameObjectCollectionBase.NameObjectKeysEnumerator : IEnumerator // TypeDefIndex: 5517
{
	// Fields
	private int _pos; // 0x10
	private NameObjectCollectionBase _coll; // 0x18
	private int _version; // 0x20

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x210C560 Offset: 0x210B760 VA: 0x18210C560
	internal void .ctor(NameObjectCollectionBase coll) { }

	// RVA: 0x210C3F0 Offset: 0x210B5F0 VA: 0x18210C3F0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x210C4D0 Offset: 0x210B6D0 VA: 0x18210C4D0 Slot: 6
	public void Reset() { }

	// RVA: 0x210C5A0 Offset: 0x210B7A0 VA: 0x18210C5A0 Slot: 5
	public object get_Current() { }
}

// Namespace: 
[DefaultMember("Item")]
[Serializable]
public class NameObjectCollectionBase.KeysCollection : ICollection, IEnumerable // TypeDefIndex: 5518
{
	// Fields
	private NameObjectCollectionBase _coll; // 0x10

	// Properties
	public string Item { get; }
	public int Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(NameObjectCollectionBase coll) { }

	// RVA: 0x21074F0 Offset: 0x21066F0 VA: 0x1821074F0 Slot: 9
	public virtual string Get(int index) { }

	// RVA: 0x19DED80 Offset: 0x19DDF80 VA: 0x1819DED80
	public string get_Item(int index) { }

	// RVA: 0x2107480 Offset: 0x2106680 VA: 0x182107480 Slot: 8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1CFD730 Offset: 0x1CFC930 VA: 0x181CFD730 Slot: 5
	public int get_Count() { }

	// RVA: 0x2107510 Offset: 0x2106710 VA: 0x182107510 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x21078A0 Offset: 0x2106AA0 VA: 0x1821078A0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x21078F0 Offset: 0x2106AF0 VA: 0x1821078F0
	internal void .ctor() { }
}

// Namespace: System.Collections.Specialized
[Serializable]
public abstract class NameObjectCollectionBase : ICollection, IEnumerable, ISerializable, IDeserializationCallback // TypeDefIndex: 5519
{
	// Fields
	private const string ReadOnlyName = "ReadOnly";
	private const string CountName = "Count";
	private const string ComparerName = "Comparer";
	private const string HashCodeProviderName = "HashProvider";
	private const string KeysName = "Keys";
	private const string ValuesName = "Values";
	private const string KeyComparerName = "KeyComparer";
	private const string VersionName = "Version";
	private bool _readOnly; // 0x10
	private ArrayList _entriesArray; // 0x18
	private IEqualityComparer _keyComparer; // 0x20
	private Hashtable _entriesTable; // 0x28
	private NameObjectCollectionBase.NameObjectEntry _nullKeyEntry; // 0x30
	private NameObjectCollectionBase.KeysCollection _keys; // 0x38
	private SerializationInfo _serializationInfo; // 0x40
	private int _version; // 0x48
	private object _syncRoot; // 0x50
	private static StringComparer defaultComparer; // 0x0

	// Properties
	internal IEqualityComparer Comparer { get; set; }
	protected bool IsReadOnly { get; set; }
	public virtual int Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	public virtual NameObjectCollectionBase.KeysCollection Keys { get; }

	// Methods

	// RVA: 0x210BF70 Offset: 0x210B170 VA: 0x18210BF70
	protected void .ctor() { }

	// RVA: 0x210C0C0 Offset: 0x210B2C0 VA: 0x18210C0C0
	protected void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x210BF30 Offset: 0x210B130 VA: 0x18210BF30
	protected void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	[Obsolete("Please use NameObjectCollectionBase(IEqualityComparer) instead.")]
	// RVA: 0x210C280 Offset: 0x210B480 VA: 0x18210C280
	protected void .ctor(IHashCodeProvider hashProvider, IComparer comparer) { }

	[Obsolete("Please use NameObjectCollectionBase(Int32, IEqualityComparer) instead.")]
	// RVA: 0x210BE90 Offset: 0x210B090 VA: 0x18210BE90
	protected void .ctor(int capacity, IHashCodeProvider hashProvider, IComparer comparer) { }

	// RVA: 0x210C1D0 Offset: 0x210B3D0 VA: 0x18210C1D0
	protected void .ctor(int capacity) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x121F770 Offset: 0x121E970 VA: 0x18121F770
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x210A970 Offset: 0x2109B70 VA: 0x18210A970 Slot: 11
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x210B090 Offset: 0x210A290 VA: 0x18210B090 Slot: 12
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x210B8B0 Offset: 0x210AAB0 VA: 0x18210B8B0
	private void Reset() { }

	// RVA: 0x210B960 Offset: 0x210AB60 VA: 0x18210B960
	private void Reset(int capacity) { }

	// RVA: 0x210A820 Offset: 0x2109A20 VA: 0x18210A820
	private NameObjectCollectionBase.NameObjectEntry FindEntry(string key) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal IEqualityComparer get_Comparer() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	internal void set_Comparer(IEqualityComparer value) { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	protected bool get_IsReadOnly() { }

	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	protected void set_IsReadOnly(bool value) { }

	// RVA: 0x210A1F0 Offset: 0x21093F0 VA: 0x18210A1F0
	protected bool BaseHasKeys() { }

	// RVA: 0x2109A00 Offset: 0x2108C00 VA: 0x182109A00
	protected void BaseAdd(string name, object value) { }

	// RVA: 0x210A330 Offset: 0x2109530 VA: 0x18210A330
	protected void BaseRemove(string name) { }

	// RVA: 0x210A230 Offset: 0x2109430 VA: 0x18210A230
	protected void BaseRemoveAt(int index) { }

	// RVA: 0x2109B90 Offset: 0x2108D90 VA: 0x182109B90
	protected void BaseClear() { }

	// RVA: 0x210A0D0 Offset: 0x21092D0 VA: 0x18210A0D0
	protected object BaseGet(string name) { }

	// RVA: 0x210A760 Offset: 0x2109960 VA: 0x18210A760
	protected void BaseSet(string name, object value) { }

	// RVA: 0x210A0F0 Offset: 0x21092F0 VA: 0x18210A0F0
	protected object BaseGet(int index) { }

	// RVA: 0x2109FD0 Offset: 0x21091D0 VA: 0x182109FD0
	protected string BaseGetKey(int index) { }

	// RVA: 0x210A590 Offset: 0x2109790 VA: 0x18210A590
	protected void BaseSet(int index, object value) { }

	// RVA: 0x210A900 Offset: 0x2109B00 VA: 0x18210A900 Slot: 13
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x15D62B0 Offset: 0x15D54B0 VA: 0x1815D62B0 Slot: 14
	public virtual int get_Count() { }

	// RVA: 0x210BA20 Offset: 0x210AC20 VA: 0x18210BA20 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x210BD80 Offset: 0x210AF80 VA: 0x18210BD80 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x2109C10 Offset: 0x2108E10 VA: 0x182109C10
	protected string[] BaseGetAllKeys() { }

	// RVA: 0x2109CF0 Offset: 0x2108EF0 VA: 0x182109CF0
	protected object[] BaseGetAllValues() { }

	// RVA: 0x2109E10 Offset: 0x2109010 VA: 0x182109E10
	protected object[] BaseGetAllValues(Type type) { }

	// RVA: 0x210C380 Offset: 0x210B580 VA: 0x18210C380 Slot: 15
	public virtual NameObjectCollectionBase.KeysCollection get_Keys() { }

	// RVA: 0x210BDF0 Offset: 0x210AFF0 VA: 0x18210BDF0
	private static void .cctor() { }
}

// Namespace: System.Collections.Specialized
[Serializable]
internal class CompatibleComparer : IEqualityComparer // TypeDefIndex: 5520
{
	// Fields
	private IComparer _comparer; // 0x10
	private static IComparer defaultComparer; // 0x0
	private IHashCodeProvider _hcp; // 0x18
	private static IHashCodeProvider defaultHashProvider; // 0x8

	// Properties
	public IComparer Comparer { get; }
	public IHashCodeProvider HashCodeProvider { get; }
	public static IComparer DefaultComparer { get; }
	public static IHashCodeProvider DefaultHashCodeProvider { get; }

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	internal void .ctor(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	// RVA: 0x20FDD60 Offset: 0x20FCF60 VA: 0x1820FDD60 Slot: 4
	public bool Equals(object a, object b) { }

	// RVA: 0x20FDE70 Offset: 0x20FD070 VA: 0x1820FDE70 Slot: 5
	public int GetHashCode(object obj) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IComparer get_Comparer() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public IHashCodeProvider get_HashCodeProvider() { }

	// RVA: 0x20FDF40 Offset: 0x20FD140 VA: 0x1820FDF40
	public static IComparer get_DefaultComparer() { }

	// RVA: 0x20FE010 Offset: 0x20FD210 VA: 0x1820FE010
	public static IHashCodeProvider get_DefaultHashCodeProvider() { }
}

// Namespace: 
internal enum GenericAdapter.KeyOrValue // TypeDefIndex: 5521
{
	// Fields
	public int value__; // 0x0
	public const GenericAdapter.KeyOrValue Key = 0;
	public const GenericAdapter.KeyOrValue Value = 1;
}

// Namespace: 
[CompilerGenerated]
private sealed class GenericAdapter.ICollectionToGenericCollectionAdapter.<GetEnumerator>d__14 : IEnumerator<string>, IDisposable, IEnumerator // TypeDefIndex: 5522
{
	// Fields
	private int <>1__state; // 0x10
	private string <>2__current; // 0x18
	public GenericAdapter.ICollectionToGenericCollectionAdapter <>4__this; // 0x20
	private IEnumerator <>7__wrap1; // 0x28

	// Properties
	private string System.Collections.Generic.IEnumerator<System.String>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x2134EF0 Offset: 0x21340F0 VA: 0x182134EF0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2134CC0 Offset: 0x2133EC0 VA: 0x182134CC0 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x2134F50 Offset: 0x2134150 VA: 0x182134F50
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x2134EB0 Offset: 0x21340B0 VA: 0x182134EB0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
private class GenericAdapter.ICollectionToGenericCollectionAdapter : ICollection<string>, IEnumerable<string>, IEnumerable // TypeDefIndex: 5523
{
	// Fields
	private StringDictionary _internal; // 0x10
	private GenericAdapter.KeyOrValue _keyOrValue; // 0x18

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x2106740 Offset: 0x2105940 VA: 0x182106740
	public void .ctor(StringDictionary source, GenericAdapter.KeyOrValue keyOrValue) { }

	// RVA: 0x2106410 Offset: 0x2105610 VA: 0x182106410 Slot: 6
	public void Add(string item) { }

	// RVA: 0x2106410 Offset: 0x2105610 VA: 0x182106410 Slot: 7
	public void Clear() { }

	// RVA: 0x2106680 Offset: 0x2105880 VA: 0x182106680
	public void ThrowNotSupportedException() { }

	// RVA: 0x2106420 Offset: 0x2105620 VA: 0x182106420 Slot: 8
	public bool Contains(string item) { }

	// RVA: 0x2106480 Offset: 0x2105680 VA: 0x182106480 Slot: 9
	public void CopyTo(string[] array, int arrayIndex) { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680 Slot: 4
	public int get_Count() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x2106410 Offset: 0x2105610 VA: 0x182106410 Slot: 10
	public bool Remove(string item) { }

	// RVA: 0x21065A0 Offset: 0x21057A0 VA: 0x1821065A0
	private ICollection GetUnderlyingCollection() { }

	[IteratorStateMachine(typeof(GenericAdapter.ICollectionToGenericCollectionAdapter.<GetEnumerator>d__14))]
	// RVA: 0x2106530 Offset: 0x2105730 VA: 0x182106530 Slot: 11
	public IEnumerator<string> GetEnumerator() { }

	// RVA: 0x2106600 Offset: 0x2105800 VA: 0x182106600 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GenericAdapter.<GetEnumerator>d__25 : IEnumerator<KeyValuePair<string, string>>, IDisposable, IEnumerator // TypeDefIndex: 5524
{
	// Fields
	private int <>1__state; // 0x10
	private KeyValuePair<string, string> <>2__current; // 0x18
	public GenericAdapter <>4__this; // 0x28
	private IEnumerator <>7__wrap1; // 0x30

	// Properties
	private KeyValuePair<string, string> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x21352D0 Offset: 0x21344D0 VA: 0x1821352D0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2134FB0 Offset: 0x21341B0 VA: 0x182134FB0 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x2135330 Offset: 0x2134530 VA: 0x182135330
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820 Slot: 4
	private KeyValuePair<string, string> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x2135240 Offset: 0x2134440 VA: 0x182135240 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x2135280 Offset: 0x2134480 VA: 0x182135280 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
internal class GenericAdapter : IDictionary<string, string>, ICollection<KeyValuePair<string, string>>, IEnumerable<KeyValuePair<string, string>>, IEnumerable // TypeDefIndex: 5525
{
	// Fields
	private StringDictionary m_stringDictionary; // 0x10
	private GenericAdapter.ICollectionToGenericCollectionAdapter _values; // 0x18
	private GenericAdapter.ICollectionToGenericCollectionAdapter _keys; // 0x20

	// Properties
	public int Count { get; }
	public string Item { get; set; }
	public ICollection<string> Keys { get; }
	public ICollection<string> Values { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.String>>.IsReadOnly { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(StringDictionary stringDictionary) { }

	// RVA: 0x2104420 Offset: 0x2103620 VA: 0x182104420 Slot: 9
	public void Add(string key, string value) { }

	// RVA: 0x21044B0 Offset: 0x21036B0 VA: 0x1821044B0 Slot: 8
	public bool ContainsKey(string key) { }

	// RVA: 0x1CFD600 Offset: 0x1CFC800 VA: 0x181CFD600 Slot: 15
	public void Clear() { }

	// RVA: 0x1CD6680 Offset: 0x1CD5880 VA: 0x181CD6680 Slot: 12
	public int get_Count() { }

	// RVA: 0x2104C40 Offset: 0x2103E40 VA: 0x182104C40 Slot: 4
	public string get_Item(string key) { }

	// RVA: 0x2104420 Offset: 0x2103620 VA: 0x182104420 Slot: 5
	public void set_Item(string key, string value) { }

	// RVA: 0x2104D30 Offset: 0x2103F30 VA: 0x182104D30 Slot: 6
	public ICollection<string> get_Keys() { }

	// RVA: 0x2104E00 Offset: 0x2104000 VA: 0x182104E00 Slot: 7
	public ICollection<string> get_Values() { }

	// RVA: 0x2104550 Offset: 0x2103750 VA: 0x182104550 Slot: 10
	public bool Remove(string key) { }

	// RVA: 0x2104BB0 Offset: 0x2103DB0 VA: 0x182104BB0 Slot: 11
	public bool TryGetValue(string key, out string value) { }

	// RVA: 0x21045C0 Offset: 0x21037C0 VA: 0x1821045C0 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.String>>.Add(KeyValuePair<string, string> item) { }

	// RVA: 0x2104630 Offset: 0x2103830 VA: 0x182104630 Slot: 16
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.String>>.Contains(KeyValuePair<string, string> item) { }

	// RVA: 0x21046F0 Offset: 0x21038F0 VA: 0x1821046F0 Slot: 17
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.String>>.CopyTo(KeyValuePair<string, string>[] array, int arrayIndex) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_IsReadOnly() { }

	// RVA: 0x2104AA0 Offset: 0x2103CA0 VA: 0x182104AA0 Slot: 18
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.String>>.Remove(KeyValuePair<string, string> item) { }

	// RVA: 0x21044E0 Offset: 0x21036E0 VA: 0x1821044E0 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[IteratorStateMachine(typeof(GenericAdapter.<GetEnumerator>d__25))]
	// RVA: 0x21044E0 Offset: 0x21036E0 VA: 0x1821044E0 Slot: 19
	public IEnumerator<KeyValuePair<string, string>> GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class BlockingCollection.<GetConsumingEnumerable>d__68<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 5526
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private CancellationToken cancellationToken; // 0x0
	public CancellationToken <>3__cancellationToken; // 0x0
	public BlockingCollection<T> <>4__this; // 0x0
	private CancellationTokenSource <linkedTokenSource>5__2; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB027F0 Offset: 0xB019F0 VA: 0x180B027F0
	|-BlockingCollection.<GetConsumingEnumerable>d__68<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02530 Offset: 0xB01730 VA: 0x180B02530
	|-BlockingCollection.<GetConsumingEnumerable>d__68<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB206B0 Offset: 0xB1F8B0 VA: 0x180B206B0
	|-BlockingCollection.<GetConsumingEnumerable>d__68<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB20D00 Offset: 0xB1FF00 VA: 0x180B20D00
	|-BlockingCollection.<GetConsumingEnumerable>d__68<__Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB1E870 Offset: 0xB1DA70 VA: 0x180B1E870
	|-BlockingCollection.<GetConsumingEnumerable>d__68<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-BlockingCollection.<GetConsumingEnumerable>d__68<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB1E920 Offset: 0xB1DB20 VA: 0x180B1E920
	|-BlockingCollection.<GetConsumingEnumerable>d__68<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB20B20 Offset: 0xB1FD20 VA: 0x180B20B20
	|-BlockingCollection.<GetConsumingEnumerable>d__68<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB1B530 Offset: 0xB1A730 VA: 0x180B1B530
	|-BlockingCollection.<GetConsumingEnumerable>d__68<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: System.Collections.Concurrent
[DebuggerTypeProxy(typeof(BlockingCollectionDebugView<T>))]
[DebuggerDisplay("Count = {Count}, Type = {_collection}")]
public class BlockingCollection<T> : IEnumerable<T>, IEnumerable, ICollection, IDisposable, IReadOnlyCollection<T> // TypeDefIndex: 5527
{
	// Fields
	private IProducerConsumerCollection<T> _collection; // 0x0
	private int _boundedCapacity; // 0x0
	private const int NON_BOUNDED = -1;
	private SemaphoreSlim _freeNodes; // 0x0
	private SemaphoreSlim _occupiedNodes; // 0x0
	private bool _isDisposed; // 0x0
	private CancellationTokenSource _consumersCancellationTokenSource; // 0x0
	private CancellationTokenSource _producersCancellationTokenSource; // 0x0
	private int _currentAdders; // 0x0
	private const int COMPLETE_ADDING_ON_MASK = -2147483648;

	// Properties
	public int BoundedCapacity { get; }
	public bool IsAddingCompleted { get; }
	public bool IsCompleted { get; }
	public int Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private static bool IsSTAThread { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_BoundedCapacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEB980 Offset: 0xEEAB80 VA: 0x180EEB980
	|-BlockingCollection<__Il2CppFullySharedGenericType>.get_BoundedCapacity
	*/

	// RVA: -1 Offset: -1
	public bool get_IsAddingCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEB9F0 Offset: 0xEEABF0 VA: 0x180EEB9F0
	|-BlockingCollection<__Il2CppFullySharedGenericType>.get_IsAddingCompleted
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEBA30 Offset: 0xEEAC30 VA: 0x180EEBA30
	|-BlockingCollection<__Il2CppFullySharedGenericType>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEB9B0 Offset: 0xEEABB0 VA: 0x180EEB9B0
	|-BlockingCollection<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE79D0 Offset: 0xEE6BD0 VA: 0x180EE79D0
	|-BlockingCollection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE79F0 Offset: 0xEE6BF0 VA: 0x180EE79F0
	|-BlockingCollection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEB820 Offset: 0xEEAA20 VA: 0x180EEB820
	|-BlockingCollection<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int boundedCapacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEB780 Offset: 0xEEA980 VA: 0x180EEB780
	|-BlockingCollection<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IProducerConsumerCollection<T> collection, int boundedCapacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEB5E0 Offset: 0xEEA7E0 VA: 0x180EEB5E0
	|-BlockingCollection<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IProducerConsumerCollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEB8B0 Offset: 0xEEAAB0 VA: 0x180EEB8B0
	|-BlockingCollection<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void Initialize(IProducerConsumerCollection<T> collection, int boundedCapacity, int collectionCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE7590 Offset: 0xEE6790 VA: 0x180EE7590
	|-BlockingCollection<__Il2CppFullySharedGenericType>.Initialize
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE6A70 Offset: 0xEE5C70 VA: 0x180EE6A70
	|-BlockingCollection<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Add(T item, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE6B70 Offset: 0xEE5D70 VA: 0x180EE6B70
	|-BlockingCollection<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE96C0 Offset: 0xEE88C0 VA: 0x180EE96C0
	|-BlockingCollection<__Il2CppFullySharedGenericType>.TryAdd
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(T item, TimeSpan timeout) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE98E0 Offset: 0xEE8AE0 VA: 0x180EE98E0
	|-BlockingCollection<__Il2CppFullySharedGenericType>.TryAdd
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(T item, int millisecondsTimeout) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE97C0 Offset: 0xEE89C0 VA: 0x180EE97C0
	|-BlockingCollection<__Il2CppFullySharedGenericType>.TryAdd
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(T item, int millisecondsTimeout, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE9A50 Offset: 0xEE8C50 VA: 0x180EE9A50
	|-BlockingCollection<__Il2CppFullySharedGenericType>.TryAdd
	*/

	// RVA: -1 Offset: -1
	private bool TryAddWithNoTimeValidation(T item, int millisecondsTimeout, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE8F70 Offset: 0xEE8170 VA: 0x180EE8F70
	|-BlockingCollection<__Il2CppFullySharedGenericType>.TryAddWithNoTimeValidation
	*/

	// RVA: -1 Offset: -1
	public T Take() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE7C10 Offset: 0xEE6E10 VA: 0x180EE7C10
	|-BlockingCollection<__Il2CppFullySharedGenericType>.Take
	*/

	// RVA: -1 Offset: -1
	public T Take(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE7D80 Offset: 0xEE6F80 VA: 0x180EE7D80
	|-BlockingCollection<__Il2CppFullySharedGenericType>.Take
	*/

	// RVA: -1 Offset: -1
	public bool TryTake(out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEAF30 Offset: 0xEEA130 VA: 0x180EEAF30
	|-BlockingCollection<__Il2CppFullySharedGenericType>.TryTake
	*/

	// RVA: -1 Offset: -1
	public bool TryTake(out T item, TimeSpan timeout) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEACF0 Offset: 0xEE9EF0 VA: 0x180EEACF0
	|-BlockingCollection<__Il2CppFullySharedGenericType>.TryTake
	*/

	// RVA: -1 Offset: -1
	public bool TryTake(out T item, int millisecondsTimeout) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEAE70 Offset: 0xEEA070 VA: 0x180EEAE70
	|-BlockingCollection<__Il2CppFullySharedGenericType>.TryTake
	*/

	// RVA: -1 Offset: -1
	public bool TryTake(out T item, int millisecondsTimeout, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEADE0 Offset: 0xEE9FE0 VA: 0x180EEADE0
	|-BlockingCollection<__Il2CppFullySharedGenericType>.TryTake
	*/

	// RVA: -1 Offset: -1
	private bool TryTakeWithNoTimeValidation(out T item, int millisecondsTimeout, CancellationToken cancellationToken, CancellationTokenSource combinedTokenSource) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEA7C0 Offset: 0xEE99C0 VA: 0x180EEA7C0
	|-BlockingCollection<__Il2CppFullySharedGenericType>.TryTakeWithNoTimeValidation
	*/

	// RVA: -1 Offset: -1
	public static int AddToAny(BlockingCollection<T>[] collections, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE6750 Offset: 0xEE5950 VA: 0x180EE6750
	|-BlockingCollection<__Il2CppFullySharedGenericType>.AddToAny
	*/

	// RVA: -1 Offset: -1
	public static int AddToAny(BlockingCollection<T>[] collections, T item, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE6900 Offset: 0xEE5B00 VA: 0x180EE6900
	|-BlockingCollection<__Il2CppFullySharedGenericType>.AddToAny
	*/

	// RVA: -1 Offset: -1
	public static int TryAddToAny(BlockingCollection<T>[] collections, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE87A0 Offset: 0xEE79A0 VA: 0x180EE87A0
	|-BlockingCollection<__Il2CppFullySharedGenericType>.TryAddToAny
	*/

	// RVA: -1 Offset: -1
	public static int TryAddToAny(BlockingCollection<T>[] collections, T item, TimeSpan timeout) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE8D20 Offset: 0xEE7F20 VA: 0x180EE8D20
	|-BlockingCollection<__Il2CppFullySharedGenericType>.TryAddToAny
	*/

	// RVA: -1 Offset: -1
	public static int TryAddToAny(BlockingCollection<T>[] collections, T item, int millisecondsTimeout) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE8B20 Offset: 0xEE7D20 VA: 0x180EE8B20
	|-BlockingCollection<__Il2CppFullySharedGenericType>.TryAddToAny
	*/

	// RVA: -1 Offset: -1
	public static int TryAddToAny(BlockingCollection<T>[] collections, T item, int millisecondsTimeout, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE8950 Offset: 0xEE7B50 VA: 0x180EE8950
	|-BlockingCollection<__Il2CppFullySharedGenericType>.TryAddToAny
	*/

	// RVA: -1 Offset: -1
	private static int TryAddToAnyCore(BlockingCollection<T>[] collections, T item, int millisecondsTimeout, CancellationToken externalCancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE7F20 Offset: 0xEE7120 VA: 0x180EE7F20
	|-BlockingCollection<__Il2CppFullySharedGenericType>.TryAddToAnyCore
	*/

	// RVA: -1 Offset: -1
	private static int TryAddToAnyFast(BlockingCollection<T>[] collections, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE85E0 Offset: 0xEE77E0 VA: 0x180EE85E0
	|-BlockingCollection<__Il2CppFullySharedGenericType>.TryAddToAnyFast
	*/

	// RVA: -1 Offset: -1
	private static List<WaitHandle> GetHandles(BlockingCollection<T>[] collections, CancellationToken externalCancellationToken, bool isAddOperation, out CancellationToken[] cancellationTokens) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE7270 Offset: 0xEE6470 VA: 0x180EE7270
	|-BlockingCollection<__Il2CppFullySharedGenericType>.GetHandles
	*/

	// RVA: -1 Offset: -1
	private static int UpdateTimeOut(uint startTime, int originalWaitMillisecondsTimeout) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEAFC0 Offset: 0xEEA1C0 VA: 0x180EEAFC0
	|-BlockingCollection<__Il2CppFullySharedGenericType>.UpdateTimeOut
	*/

	// RVA: -1 Offset: -1
	public static int TakeFromAny(BlockingCollection<T>[] collections, out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE7A90 Offset: 0xEE6C90 VA: 0x180EE7A90
	|-BlockingCollection<__Il2CppFullySharedGenericType>.TakeFromAny
	*/

	// RVA: -1 Offset: -1
	public static int TakeFromAny(BlockingCollection<T>[] collections, out T item, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE7B60 Offset: 0xEE6D60 VA: 0x180EE7B60
	|-BlockingCollection<__Il2CppFullySharedGenericType>.TakeFromAny
	*/

	// RVA: -1 Offset: -1
	public static int TryTakeFromAny(BlockingCollection<T>[] collections, out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEA730 Offset: 0xEE9930 VA: 0x180EEA730
	|-BlockingCollection<__Il2CppFullySharedGenericType>.TryTakeFromAny
	*/

	// RVA: -1 Offset: -1
	public static int TryTakeFromAny(BlockingCollection<T>[] collections, out T item, TimeSpan timeout) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEA5D0 Offset: 0xEE97D0 VA: 0x180EEA5D0
	|-BlockingCollection<__Il2CppFullySharedGenericType>.TryTakeFromAny
	*/

	// RVA: -1 Offset: -1
	public static int TryTakeFromAny(BlockingCollection<T>[] collections, out T item, int millisecondsTimeout) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEA3C0 Offset: 0xEE95C0 VA: 0x180EEA3C0
	|-BlockingCollection<__Il2CppFullySharedGenericType>.TryTakeFromAny
	*/

	// RVA: -1 Offset: -1
	public static int TryTakeFromAny(BlockingCollection<T>[] collections, out T item, int millisecondsTimeout, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEA4E0 Offset: 0xEE96E0 VA: 0x180EEA4E0
	|-BlockingCollection<__Il2CppFullySharedGenericType>.TryTakeFromAny
	*/

	// RVA: -1 Offset: -1
	private static int TryTakeFromAnyCore(BlockingCollection<T>[] collections, out T item, int millisecondsTimeout, bool isTakeOperation, CancellationToken externalCancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEA170 Offset: 0xEE9370 VA: 0x180EEA170
	|-BlockingCollection<__Il2CppFullySharedGenericType>.TryTakeFromAnyCore
	*/

	// RVA: -1 Offset: -1
	private static int TryTakeFromAnyCoreSlow(BlockingCollection<T>[] collections, out T item, int millisecondsTimeout, bool isTakeOperation, CancellationToken externalCancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE9B90 Offset: 0xEE8D90 VA: 0x180EE9B90
	|-BlockingCollection<__Il2CppFullySharedGenericType>.TryTakeFromAnyCoreSlow
	*/

	// RVA: -1 Offset: -1
	public void CompleteAdding() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE6D30 Offset: 0xEE5F30 VA: 0x180EE6D30
	|-BlockingCollection<__Il2CppFullySharedGenericType>.CompleteAdding
	*/

	// RVA: -1 Offset: -1
	private void CancelWaitingConsumers() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE6C70 Offset: 0xEE5E70 VA: 0x180EE6C70
	|-BlockingCollection<__Il2CppFullySharedGenericType>.CancelWaitingConsumers
	*/

	// RVA: -1 Offset: -1
	private void CancelWaitingProducers() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE6C90 Offset: 0xEE5E90 VA: 0x180EE6C90
	|-BlockingCollection<__Il2CppFullySharedGenericType>.CancelWaitingProducers
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE7060 Offset: 0xEE6260 VA: 0x180EE7060
	|-BlockingCollection<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected virtual void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE7010 Offset: 0xEE6210 VA: 0x180EE7010
	|-BlockingCollection<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE7EB0 Offset: 0xEE70B0 VA: 0x180EE7EB0
	|-BlockingCollection<__Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE6F40 Offset: 0xEE6140 VA: 0x180EE6F40
	|-BlockingCollection<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE76F0 Offset: 0xEE68F0 VA: 0x180EE76F0
	|-BlockingCollection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	public IEnumerable<T> GetConsumingEnumerable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE70D0 Offset: 0xEE62D0 VA: 0x180EE70D0
	|-BlockingCollection<__Il2CppFullySharedGenericType>.GetConsumingEnumerable
	*/

	[IteratorStateMachine(typeof(BlockingCollection.<GetConsumingEnumerable>d__68<T>))]
	// RVA: -1 Offset: -1
	public IEnumerable<T> GetConsumingEnumerable(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE7150 Offset: 0xEE6350 VA: 0x180EE7150
	|-BlockingCollection<__Il2CppFullySharedGenericType>.GetConsumingEnumerable
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE7680 Offset: 0xEE6880 VA: 0x180EE7680
	|-BlockingCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE7A40 Offset: 0xEE6C40 VA: 0x180EE7A40
	|-BlockingCollection<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private static void ValidateCollectionsArray(BlockingCollection<T>[] collections, bool isAddOperation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEB010 Offset: 0xEEA210 VA: 0x180EEB010
	|-BlockingCollection<__Il2CppFullySharedGenericType>.ValidateCollectionsArray
	*/

	// RVA: -1 Offset: -1
	private static bool get_IsSTAThread() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-BlockingCollection<__Il2CppFullySharedGenericType>.get_IsSTAThread
	*/

	// RVA: -1 Offset: -1
	private static void ValidateTimeout(TimeSpan timeout) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEB480 Offset: 0xEEA680 VA: 0x180EEB480
	|-BlockingCollection<__Il2CppFullySharedGenericType>.ValidateTimeout
	*/

	// RVA: -1 Offset: -1
	private static void ValidateMillisecondsTimeout(int millisecondsTimeout) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEEB380 Offset: 0xEEA580 VA: 0x180EEB380
	|-BlockingCollection<__Il2CppFullySharedGenericType>.ValidateMillisecondsTimeout
	*/

	// RVA: -1 Offset: -1
	private void CheckDisposed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE6CB0 Offset: 0xEE5EB0 VA: 0x180EE6CB0
	|-BlockingCollection<__Il2CppFullySharedGenericType>.CheckDisposed
	*/
}

// Namespace: System.Collections.Concurrent
internal sealed class BlockingCollectionDebugView<T> // TypeDefIndex: 5528
{
	// Fields
	private readonly BlockingCollection<T> _blockingCollection; // 0x0

	// Properties
	[DebuggerBrowsable(3)]
	public T[] Items { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(BlockingCollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD04180 Offset: 0xD03380 VA: 0x180D04180
	|-BlockingCollectionDebugView<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T[] get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE6720 Offset: 0xEE5920 VA: 0x180EE6720
	|-BlockingCollectionDebugView<__Il2CppFullySharedGenericType>.get_Items
	*/
}

// Namespace: System.Collections.Concurrent
[EventSource(Name = "System.Collections.Concurrent.ConcurrentCollectionsEventSource", Guid = "35167F8E-49B2-4b96-AB86-435B59336B5E")]
internal sealed class CDSCollectionETWBCLProvider : EventSource // TypeDefIndex: 5529
{
	// Fields
	public static CDSCollectionETWBCLProvider Log; // 0x0
	private const EventKeywords ALL_KEYWORDS = -1;
	private const int CONCURRENTSTACK_FASTPUSHFAILED_ID = 1;
	private const int CONCURRENTSTACK_FASTPOPFAILED_ID = 2;
	private const int CONCURRENTDICTIONARY_ACQUIRINGALLLOCKS_ID = 3;
	private const int CONCURRENTBAG_TRYTAKESTEALS_ID = 4;
	private const int CONCURRENTBAG_TRYPEEKSTEALS_ID = 5;

	// Methods

	// RVA: 0x172F990 Offset: 0x172EB90 VA: 0x18172F990
	private void .ctor() { }

	[Event(1, Level = 3)]
	// RVA: 0x172F8E0 Offset: 0x172EAE0 VA: 0x18172F8E0
	public void ConcurrentStack_FastPushFailed(int spinCount) { }

	[Event(2, Level = 3)]
	// RVA: 0x172F890 Offset: 0x172EA90 VA: 0x18172F890
	public void ConcurrentStack_FastPopFailed(int spinCount) { }

	[Event(3, Level = 3)]
	// RVA: 0x172F840 Offset: 0x172EA40 VA: 0x18172F840
	public void ConcurrentDictionary_AcquiringAllLocks(int numOfBuckets) { }

	[Event(4, Level = 5)]
	// RVA: 0x2119050 Offset: 0x2118250 VA: 0x182119050
	public void ConcurrentBag_TryTakeSteals() { }

	[Event(5, Level = 5)]
	// RVA: 0x2119010 Offset: 0x2118210 VA: 0x182119010
	public void ConcurrentBag_TryPeekSteals() { }

	// RVA: 0x2119090 Offset: 0x2118290 VA: 0x182119090
	private static void .cctor() { }
}

// Namespace: 
private sealed class ConcurrentBag.WorkStealingQueue<T> // TypeDefIndex: 5530
{
	// Fields
	private const int InitialSize = 32;
	private const int StartIndex = 0;
	private int _headIndex; // 0x0
	private int _tailIndex; // 0x0
	private T[] _array; // 0x0
	private int _mask; // 0x0
	private int _addTakeCount; // 0x0
	private int _stealCount; // 0x0
	internal int _currentOp; // 0x0
	internal bool _frozen; // 0x0
	internal readonly ConcurrentBag.WorkStealingQueue<T> _nextQueue; // 0x0
	internal readonly int _ownerThreadId; // 0x0

	// Properties
	internal bool IsEmpty { get; }
	internal int DangerousCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ConcurrentBag.WorkStealingQueue<T> nextQueue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE662D0 Offset: 0xE654D0 VA: 0x180E662D0
	|-ConcurrentBag.WorkStealingQueue<object>..ctor
	|-ConcurrentBag.WorkStealingQueue<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE66370 Offset: 0xE65570 VA: 0x180E66370
	|-ConcurrentBag.WorkStealingQueue<object>.get_IsEmpty
	|-ConcurrentBag.WorkStealingQueue<__Il2CppFullySharedGenericType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	internal void LocalPush(T item, ref long emptyToNonEmptyListTransitionCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE64C10 Offset: 0xE63E10 VA: 0x180E64C10
	|-ConcurrentBag.WorkStealingQueue<object>.LocalPush
	|
	|-RVA: 0xE645B0 Offset: 0xE637B0 VA: 0x180E645B0
	|-ConcurrentBag.WorkStealingQueue<__Il2CppFullySharedGenericType>.LocalPush
	*/

	// RVA: -1 Offset: -1
	internal void LocalClear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE644C0 Offset: 0xE636C0 VA: 0x180E644C0
	|-ConcurrentBag.WorkStealingQueue<object>.LocalClear
	|-ConcurrentBag.WorkStealingQueue<__Il2CppFullySharedGenericType>.LocalClear
	*/

	// RVA: -1 Offset: -1
	internal bool TryLocalPop(out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE65970 Offset: 0xE64B70 VA: 0x180E65970
	|-ConcurrentBag.WorkStealingQueue<object>.TryLocalPop
	|
	|-RVA: 0xE65470 Offset: 0xE64670 VA: 0x180E65470
	|-ConcurrentBag.WorkStealingQueue<__Il2CppFullySharedGenericType>.TryLocalPop
	*/

	// RVA: -1 Offset: -1
	internal bool TryLocalPeek(out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE65340 Offset: 0xE64540 VA: 0x180E65340
	|-ConcurrentBag.WorkStealingQueue<object>.TryLocalPeek
	|
	|-RVA: 0xE65160 Offset: 0xE64360 VA: 0x180E65160
	|-ConcurrentBag.WorkStealingQueue<__Il2CppFullySharedGenericType>.TryLocalPeek
	*/

	// RVA: -1 Offset: -1
	internal bool TrySteal(out T result, bool take) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE66060 Offset: 0xE65260 VA: 0x180E66060
	|-ConcurrentBag.WorkStealingQueue<object>.TrySteal
	|
	|-RVA: 0xE65C40 Offset: 0xE64E40 VA: 0x180E65C40
	|-ConcurrentBag.WorkStealingQueue<__Il2CppFullySharedGenericType>.TrySteal
	*/

	// RVA: -1 Offset: -1
	internal int DangerousCopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE643F0 Offset: 0xE635F0 VA: 0x180E643F0
	|-ConcurrentBag.WorkStealingQueue<object>.DangerousCopyTo
	|
	|-RVA: 0xE64270 Offset: 0xE63470 VA: 0x180E64270
	|-ConcurrentBag.WorkStealingQueue<__Il2CppFullySharedGenericType>.DangerousCopyTo
	*/

	// RVA: -1 Offset: -1
	internal int get_DangerousCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE66360 Offset: 0xE65560 VA: 0x180E66360
	|-ConcurrentBag.WorkStealingQueue<object>.get_DangerousCount
	|-ConcurrentBag.WorkStealingQueue<__Il2CppFullySharedGenericType>.get_DangerousCount
	*/
}

// Namespace: 
internal enum ConcurrentBag.Operation<T> // TypeDefIndex: 5531
{
	// Fields
	public int value__; // 0x0
	public const ConcurrentBag.Operation<T> None = 0;
	public const ConcurrentBag.Operation<T> Add = 1;
	public const ConcurrentBag.Operation<T> Take = 2;
}

// Namespace: 
[Serializable]
private sealed class ConcurrentBag.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 5532
{
	// Fields
	private readonly T[] _array; // 0x0
	private T _current; // 0x0
	private int _index; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	|-ConcurrentBag.Enumerator<object>..ctor
	|
	|-RVA: 0x1110860 Offset: 0x110FA60 VA: 0x181110860
	|-ConcurrentBag.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10ED420 Offset: 0x10EC620 VA: 0x1810ED420
	|-ConcurrentBag.Enumerator<object>.MoveNext
	|
	|-RVA: 0x110A4B0 Offset: 0x11096B0 VA: 0x18110A4B0
	|-ConcurrentBag.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-ConcurrentBag.Enumerator<object>.get_Current
	|
	|-RVA: 0x1112240 Offset: 0x1111440 VA: 0x181112240
	|-ConcurrentBag.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EF0F0 Offset: 0x10EE2F0 VA: 0x1810EF0F0
	|-ConcurrentBag.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110E8D0 Offset: 0x110DAD0 VA: 0x18110E8D0
	|-ConcurrentBag.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EE420 Offset: 0x10ED620 VA: 0x1810EE420
	|-ConcurrentBag.Enumerator<object>.Reset
	|
	|-RVA: 0x110BE80 Offset: 0x110B080 VA: 0x18110BE80
	|-ConcurrentBag.Enumerator<__Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-ConcurrentBag.Enumerator<object>.Dispose
	|-ConcurrentBag.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	*/
}

// Namespace: System.Collections.Concurrent
[DebuggerTypeProxy(typeof(IProducerConsumerCollectionDebugView<T>))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class ConcurrentBag<T> : IProducerConsumerCollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T> // TypeDefIndex: 5533
{
	// Fields
	private readonly ThreadLocal<ConcurrentBag.WorkStealingQueue<T>> _locals; // 0x0
	private ConcurrentBag.WorkStealingQueue<T> _workStealingQueues; // 0x0
	private long _emptyToNonEmptyListTransitionCount; // 0x0

	// Properties
	public int Count { get; }
	private int DangerousCount { get; }
	public bool IsEmpty { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private object GlobalQueuesLock { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF80530 Offset: 0xF7F730 VA: 0x180F80530
	|-ConcurrentBag<object>..ctor
	|
	|-RVA: 0xC4F800 Offset: 0xC4EA00 VA: 0x180C4F800
	|-ConcurrentBag<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7FE60 Offset: 0xF7F060 VA: 0x180F7FE60
	|-ConcurrentBag<object>..ctor
	|
	|-RVA: 0xF80150 Offset: 0xF7F350 VA: 0x180F80150
	|-ConcurrentBag<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7D970 Offset: 0xF7CB70 VA: 0x180F7D970
	|-ConcurrentBag<object>.Add
	|
	|-RVA: 0xF7DA20 Offset: 0xF7CC20 VA: 0x180F7DA20
	|-ConcurrentBag<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7ED60 Offset: 0xF7DF60 VA: 0x180F7ED60
	|-ConcurrentBag<object>.System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd
	|
	|-RVA: 0xF7EE20 Offset: 0xF7E020 VA: 0x180F7EE20
	|-ConcurrentBag<__Il2CppFullySharedGenericType>.System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public bool TryTake(out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7FC20 Offset: 0xF7EE20 VA: 0x180F7FC20
	|-ConcurrentBag<object>.TryTake
	|
	|-RVA: 0xF7FCE0 Offset: 0xF7EEE0 VA: 0x180F7FCE0
	|-ConcurrentBag<__Il2CppFullySharedGenericType>.TryTake
	*/

	// RVA: -1 Offset: -1
	public bool TryPeek(out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7F5F0 Offset: 0xF7E7F0 VA: 0x180F7F5F0
	|-ConcurrentBag<object>.TryPeek
	|
	|-RVA: 0xF7F550 Offset: 0xF7E750 VA: 0x180F7F550
	|-ConcurrentBag<__Il2CppFullySharedGenericType>.TryPeek
	*/

	// RVA: -1 Offset: -1
	private ConcurrentBag.WorkStealingQueue<T> GetCurrentThreadWorkStealingQueue(bool forceCreate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7EAC0 Offset: 0xF7DCC0 VA: 0x180F7EAC0
	|-ConcurrentBag<object>.GetCurrentThreadWorkStealingQueue
	|
	|-RVA: 0xF7EB50 Offset: 0xF7DD50 VA: 0x180F7EB50
	|-ConcurrentBag<__Il2CppFullySharedGenericType>.GetCurrentThreadWorkStealingQueue
	*/

	// RVA: -1 Offset: -1
	private ConcurrentBag.WorkStealingQueue<T> CreateWorkStealingQueueForCurrentThread() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7E5A0 Offset: 0xF7D7A0 VA: 0x180F7E5A0
	|-ConcurrentBag<object>.CreateWorkStealingQueueForCurrentThread
	|
	|-RVA: 0xF7E710 Offset: 0xF7D910 VA: 0x180F7E710
	|-ConcurrentBag<__Il2CppFullySharedGenericType>.CreateWorkStealingQueueForCurrentThread
	*/

	// RVA: -1 Offset: -1
	private ConcurrentBag.WorkStealingQueue<T> GetUnownedWorkStealingQueue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7ED10 Offset: 0xF7DF10 VA: 0x180F7ED10
	|-ConcurrentBag<object>.GetUnownedWorkStealingQueue
	|-ConcurrentBag<__Il2CppFullySharedGenericType>.GetUnownedWorkStealingQueue
	*/

	// RVA: -1 Offset: -1
	private bool TrySteal(out T result, bool take) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7F9B0 Offset: 0xF7EBB0 VA: 0x180F7F9B0
	|-ConcurrentBag<object>.TrySteal
	|
	|-RVA: 0xF7F7F0 Offset: 0xF7E9F0 VA: 0x180F7F7F0
	|-ConcurrentBag<__Il2CppFullySharedGenericType>.TrySteal
	*/

	// RVA: -1 Offset: -1
	private bool TryStealFromTo(ConcurrentBag.WorkStealingQueue<T> startInclusive, ConcurrentBag.WorkStealingQueue<T> endExclusive, out T result, bool take) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7F6B0 Offset: 0xF7E8B0 VA: 0x180F7F6B0
	|-ConcurrentBag<object>.TryStealFromTo
	|
	|-RVA: 0xF7F740 Offset: 0xF7E940 VA: 0x180F7F740
	|-ConcurrentBag<__Il2CppFullySharedGenericType>.TryStealFromTo
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7E300 Offset: 0xF7D500 VA: 0x180F7E300
	|-ConcurrentBag<object>.CopyTo
	|
	|-RVA: 0xF7E000 Offset: 0xF7D200 VA: 0x180F7E000
	|-ConcurrentBag<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	private int CopyFromEachQueueToArray(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7DEE0 Offset: 0xF7D0E0 VA: 0x180F7DEE0
	|-ConcurrentBag<object>.CopyFromEachQueueToArray
	|
	|-RVA: 0xF7DF70 Offset: 0xF7D170 VA: 0x180F7DF70
	|-ConcurrentBag<__Il2CppFullySharedGenericType>.CopyFromEachQueueToArray
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7F020 Offset: 0xF7E220 VA: 0x180F7F020
	|-ConcurrentBag<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xF7EF00 Offset: 0xF7E100 VA: 0x180F7EF00
	|-ConcurrentBag<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7F3A0 Offset: 0xF7E5A0 VA: 0x180F7F3A0
	|-ConcurrentBag<object>.ToArray
	|
	|-RVA: 0xF7F1E0 Offset: 0xF7E3E0 VA: 0x180F7F1E0
	|-ConcurrentBag<__Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7DB30 Offset: 0xF7CD30 VA: 0x180F7DB30
	|-ConcurrentBag<object>.Clear
	|
	|-RVA: 0xF7DCD0 Offset: 0xF7CED0 VA: 0x180F7DCD0
	|-ConcurrentBag<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7EBF0 Offset: 0xF7DDF0 VA: 0x180F7EBF0
	|-ConcurrentBag<object>.GetEnumerator
	|
	|-RVA: 0xF7EC80 Offset: 0xF7DE80 VA: 0x180F7EC80
	|-ConcurrentBag<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7F140 Offset: 0xF7E340 VA: 0x180F7F140
	|-ConcurrentBag<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBF9840 Offset: 0xBF8A40 VA: 0x180BF9840
	|-ConcurrentBag<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF805B0 Offset: 0xF7F7B0 VA: 0x180F805B0
	|-ConcurrentBag<object>.get_Count
	|
	|-RVA: 0xF80690 Offset: 0xF7F890 VA: 0x180F80690
	|-ConcurrentBag<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	private int get_DangerousCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF807B0 Offset: 0xF7F9B0 VA: 0x180F807B0
	|-ConcurrentBag<object>.get_DangerousCount
	|
	|-RVA: 0xF80840 Offset: 0xF7FA40 VA: 0x180F80840
	|-ConcurrentBag<__Il2CppFullySharedGenericType>.get_DangerousCount
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF808D0 Offset: 0xF7FAD0 VA: 0x180F808D0
	|-ConcurrentBag<object>.get_IsEmpty
	|
	|-RVA: 0xF80A50 Offset: 0xF7FC50 VA: 0x180F80A50
	|-ConcurrentBag<__Il2CppFullySharedGenericType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-ConcurrentBag<object>.System.Collections.ICollection.get_IsSynchronized
	|-ConcurrentBag<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE79F0 Offset: 0xEE6BF0 VA: 0x180EE79F0
	|-ConcurrentBag<object>.System.Collections.ICollection.get_SyncRoot
	|-ConcurrentBag<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	private object get_GlobalQueuesLock() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	|-ConcurrentBag<object>.get_GlobalQueuesLock
	|-ConcurrentBag<__Il2CppFullySharedGenericType>.get_GlobalQueuesLock
	*/

	// RVA: -1 Offset: -1
	private void FreezeBag(ref bool lockTaken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7E9D0 Offset: 0xF7DBD0 VA: 0x180F7E9D0
	|-ConcurrentBag<object>.FreezeBag
	|
	|-RVA: 0xF7E8C0 Offset: 0xF7DAC0 VA: 0x180F7E8C0
	|-ConcurrentBag<__Il2CppFullySharedGenericType>.FreezeBag
	*/

	// RVA: -1 Offset: -1
	private void UnfreezeBag(bool lockTaken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF7FD80 Offset: 0xF7EF80 VA: 0x180F7FD80
	|-ConcurrentBag<object>.UnfreezeBag
	|
	|-RVA: 0xF7FDE0 Offset: 0xF7EFE0 VA: 0x180F7FDE0
	|-ConcurrentBag<__Il2CppFullySharedGenericType>.UnfreezeBag
	*/
}

// Namespace: System.Collections.Generic
[IsByRefLike]
[DefaultMember("Item")]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct ValueListBuilder<T> // TypeDefIndex: 5534
{
	// Fields
	private Span<T> _span; // 0x0
	private T[] _arrayFromPool; // 0x0
	private int _pos; // 0x0

	// Properties
	public int Length { get; }
	public T Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Span<T> initialSpan) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD133A0 Offset: 0xD125A0 VA: 0x180D133A0
	|-ValueListBuilder<int>..ctor
	|-ValueListBuilder<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	|-ValueListBuilder<int>.get_Length
	|-ValueListBuilder<__Il2CppFullySharedGenericType>.get_Length
	*/

	// RVA: -1 Offset: -1
	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD133B0 Offset: 0xD125B0 VA: 0x180D133B0
	|-ValueListBuilder<int>.get_Item
	|
	|-RVA: 0xD133D0 Offset: 0xD125D0 VA: 0x180D133D0
	|-ValueListBuilder<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void Append(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD12380 Offset: 0xD11580 VA: 0x180D12380
	|-ValueListBuilder<int>.Append
	|
	|-RVA: 0xD124A0 Offset: 0xD116A0 VA: 0x180D124A0
	|-ValueListBuilder<__Il2CppFullySharedGenericType>.Append
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySpan<T> AsSpan() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD127A0 Offset: 0xD119A0 VA: 0x180D127A0
	|-ValueListBuilder<int>.AsSpan
	|
	|-RVA: 0xD12690 Offset: 0xD11890 VA: 0x180D12690
	|-ValueListBuilder<__Il2CppFullySharedGenericType>.AsSpan
	*/

	// RVA: -1 Offset: -1
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD12970 Offset: 0xD11B70 VA: 0x180D12970
	|-ValueListBuilder<int>.Dispose
	|
	|-RVA: 0xD12880 Offset: 0xD11A80 VA: 0x180D12880
	|-ValueListBuilder<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1
	private void Grow() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD12D40 Offset: 0xD11F40 VA: 0x180D12D40
	|-ValueListBuilder<int>.Grow
	|
	|-RVA: 0xD12F60 Offset: 0xD12160 VA: 0x180D12F60
	|-ValueListBuilder<__Il2CppFullySharedGenericType>.Grow
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13270 Offset: 0xD12470 VA: 0x180D13270
	|-ValueListBuilder<int>.Pop
	|
	|-RVA: 0xD132A0 Offset: 0xD124A0 VA: 0x180D132A0
	|-ValueListBuilder<__Il2CppFullySharedGenericType>.Pop
	*/
}

// Namespace: System.Collections.Generic
internal sealed class BidirectionalDictionary<T1, T2> : IEnumerable<KeyValuePair<T1, T2>>, IEnumerable // TypeDefIndex: 5535
{
	// Fields
	private readonly Dictionary<T1, T2> _forward; // 0x0
	private readonly Dictionary<T2, T1> _backward; // 0x0

	// Properties
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE4450 Offset: 0xEE3650 VA: 0x180EE4450
	|-BidirectionalDictionary<Int32Enum, Int32Enum>..ctor
	|
	|-RVA: 0xEE4380 Offset: 0xEE3580 VA: 0x180EE4380
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD04200 Offset: 0xD03400 VA: 0x180D04200
	|-BidirectionalDictionary<Int32Enum, Int32Enum>.get_Count
	|
	|-RVA: 0xD120E0 Offset: 0xD112E0 VA: 0x180D120E0
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void Add(T1 item1, T2 item2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE2C30 Offset: 0xEE1E30 VA: 0x180EE2C30
	|-BidirectionalDictionary<Int32Enum, Int32Enum>.Add
	|
	|-RVA: 0xEE2CB0 Offset: 0xEE1EB0 VA: 0x180EE2CB0
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public bool TryGetForward(T1 item1, out T2 item2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE4170 Offset: 0xEE3370 VA: 0x180EE4170
	|-BidirectionalDictionary<Int32Enum, Int32Enum>.TryGetForward
	|
	|-RVA: 0xEE4080 Offset: 0xEE3280 VA: 0x180EE4080
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetForward
	*/

	// RVA: -1 Offset: -1
	public bool TryGetBackward(T2 item2, out T1 item1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE3D70 Offset: 0xEE2F70 VA: 0x180EE3D70
	|-BidirectionalDictionary<Int32Enum, Int32Enum>.TryGetBackward
	|
	|-RVA: 0xEE3C80 Offset: 0xEE2E80 VA: 0x180EE3C80
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetBackward
	*/

	// RVA: -1 Offset: -1
	public Dictionary.Enumerator<T1, T2> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE2F20 Offset: 0xEE2120 VA: 0x180EE2F20
	|-BidirectionalDictionary<Int32Enum, Int32Enum>.GetEnumerator
	|
	|-RVA: 0xEE2F70 Offset: 0xEE2170 VA: 0x180EE2F70
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<KeyValuePair<T1, T2>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<T1,T2>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE3C00 Offset: 0xEE2E00 VA: 0x180EE3C00
	|-BidirectionalDictionary<Int32Enum, Int32Enum>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<T1,T2>>.GetEnumerator
	|
	|-RVA: 0xEE3B50 Offset: 0xEE2D50 VA: 0x180EE3B50
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<T1,T2>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE3C00 Offset: 0xEE2E00 VA: 0x180EE3C00
	|-BidirectionalDictionary<Int32Enum, Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xEE3B50 Offset: 0xEE2D50 VA: 0x180EE3B50
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: System.Collections.Generic
internal sealed class BitHelper // TypeDefIndex: 5536
{
	// Fields
	private const byte MarkedBitFlag = 1;
	private const byte IntSize = 32;
	private readonly int _length; // 0x10
	private readonly int* _arrayPtr; // 0x18
	private readonly int[] _array; // 0x20
	private readonly bool _useStackAlloc; // 0x28

	// Methods

	// RVA: 0x1D6D740 Offset: 0x1D6C940 VA: 0x181D6D740
	internal void .ctor(int* bitArrayPtr, int length) { }

	// RVA: 0x1D6D780 Offset: 0x1D6C980 VA: 0x181D6D780
	internal void .ctor(int[] bitArray, int length) { }

	// RVA: 0x1D6D6B0 Offset: 0x1D6C8B0 VA: 0x181D6D6B0
	internal void MarkBit(int bitPosition) { }

	// RVA: 0x1D6D630 Offset: 0x1D6C830 VA: 0x181D6D630
	internal bool IsMarked(int bitPosition) { }

	// RVA: 0x1D6D720 Offset: 0x1D6C920 VA: 0x181D6D720
	internal static int ToIntArrayLength(int n) { }
}

// Namespace: System.Collections.Generic
internal sealed class ICollectionDebugView<T> // TypeDefIndex: 5537
{
	// Fields
	private readonly ICollection<T> _collection; // 0x0

	// Properties
	[DebuggerBrowsable(3)]
	public T[] Items { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ICollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD04180 Offset: 0xD03380 VA: 0x180D04180
	|-ICollectionDebugView<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T[] get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12618C0 Offset: 0x1260AC0 VA: 0x1812618C0
	|-ICollectionDebugView<__Il2CppFullySharedGenericType>.get_Items
	*/
}

// Namespace: System.Collections.Generic
internal sealed class IDictionaryDebugView<K, V> // TypeDefIndex: 5538
{
	// Fields
	private readonly IDictionary<K, V> _dict; // 0x0

	// Properties
	[DebuggerBrowsable(3)]
	public KeyValuePair<K, V>[] Items { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<K, V> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCECF0 Offset: 0xBCDEF0 VA: 0x180BCECF0
	|-IDictionaryDebugView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public KeyValuePair<K, V>[] get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1263AE0 Offset: 0x1262CE0 VA: 0x181263AE0
	|-IDictionaryDebugView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Items
	*/
}

// Namespace: System.Collections.Generic
internal sealed class DictionaryKeyCollectionDebugView<TKey, TValue> // TypeDefIndex: 5539
{
	// Fields
	private readonly ICollection<TKey> _collection; // 0x0

	// Properties
	[DebuggerBrowsable(3)]
	public TKey[] Items { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ICollection<TKey> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD04180 Offset: 0xD03380 VA: 0x180D04180
	|-DictionaryKeyCollectionDebugView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public TKey[] get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF07E80 Offset: 0xF07080 VA: 0x180F07E80
	|-DictionaryKeyCollectionDebugView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Items
	*/
}

// Namespace: System.Collections.Generic
internal sealed class DictionaryValueCollectionDebugView<TKey, TValue> // TypeDefIndex: 5540
{
	// Fields
	private readonly ICollection<TValue> _collection; // 0x0

	// Properties
	[DebuggerBrowsable(3)]
	public TValue[] Items { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ICollection<TValue> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD04180 Offset: 0xD03380 VA: 0x180D04180
	|-DictionaryValueCollectionDebugView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public TValue[] get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF07E80 Offset: 0xF07080 VA: 0x180F07E80
	|-DictionaryValueCollectionDebugView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Items
	*/
}

// Namespace: 
[Serializable]
public struct LinkedList.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback // TypeDefIndex: 5541
{
	// Fields
	private LinkedList<T> _list; // 0x0
	private LinkedListNode<T> _node; // 0x0
	private int _version; // 0x0
	private T _current; // 0x0
	private int _index; // 0x0
	private const string LinkedListName = "LinkedList";
	private const string CurrentValueName = "Current";
	private const string VersionName = "Version";
	private const string IndexName = "Index";

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(LinkedList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EB0D0 Offset: 0x10EA2D0 VA: 0x1810EB0D0
	|-LinkedList.Enumerator<ValueTuple<object, object>>..ctor
	|-LinkedList.Enumerator<UIRenderDevice.DeviceToFree>..ctor
	|
	|-RVA: 0x10EBAE0 Offset: 0x10EACE0 VA: 0x1810EBAE0
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x10EFFC0 Offset: 0x10EF1C0 VA: 0x1810EFFC0
	|-LinkedList.Enumerator<object>..ctor
	|
	|-RVA: 0x110F6B0 Offset: 0x110E8B0 VA: 0x18110F6B0
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x11104A0 Offset: 0x110F6A0 VA: 0x1811104A0
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC1080 Offset: 0xCC0280 VA: 0x180CC1080
	|-LinkedList.Enumerator<ValueTuple<object, object>>..ctor
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>..ctor
	|-LinkedList.Enumerator<object>..ctor
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>..ctor
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>..ctor
	|-LinkedList.Enumerator<UIRenderDevice.DeviceToFree>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820
	|-LinkedList.Enumerator<ValueTuple<object, object>>.get_Current
	|-LinkedList.Enumerator<UIRenderDevice.DeviceToFree>.get_Current
	|
	|-RVA: 0x426510 Offset: 0x425710 VA: 0x180426510
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.get_Current
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-LinkedList.Enumerator<object>.get_Current
	|
	|-RVA: 0x1111710 Offset: 0x1110910 VA: 0x181111710
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	|
	|-RVA: 0x520F10 Offset: 0x520110 VA: 0x180520F10
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EA0D0 Offset: 0x10E92D0 VA: 0x1810EA0D0
	|-LinkedList.Enumerator<ValueTuple<object, object>>.System.Collections.IEnumerator.get_Current
	|-LinkedList.Enumerator<UIRenderDevice.DeviceToFree>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10E8FE0 Offset: 0x10E81E0 VA: 0x1810E8FE0
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10EF540 Offset: 0x10EE740 VA: 0x1810EF540
	|-LinkedList.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110D1A0 Offset: 0x110C3A0 VA: 0x18110D1A0
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110DC00 Offset: 0x110CE00 VA: 0x18110DC00
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E66B0 Offset: 0x10E58B0 VA: 0x1810E66B0
	|-LinkedList.Enumerator<ValueTuple<object, object>>.MoveNext
	|-LinkedList.Enumerator<UIRenderDevice.DeviceToFree>.MoveNext
	|
	|-RVA: 0x10E6B80 Offset: 0x10E5D80 VA: 0x1810E6B80
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.MoveNext
	|
	|-RVA: 0x10ED0B0 Offset: 0x10EC2B0 VA: 0x1810ED0B0
	|-LinkedList.Enumerator<object>.MoveNext
	|
	|-RVA: 0x1109070 Offset: 0x1108270 VA: 0x181109070
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	|
	|-RVA: 0x1109570 Offset: 0x1108770 VA: 0x181109570
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E8E70 Offset: 0x10E8070 VA: 0x1810E8E70
	|-LinkedList.Enumerator<ValueTuple<object, object>>.System.Collections.IEnumerator.Reset
	|-LinkedList.Enumerator<UIRenderDevice.DeviceToFree>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x10E8AD0 Offset: 0x10E7CD0 VA: 0x1810E8AD0
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x10EE940 Offset: 0x10EDB40 VA: 0x1810EE940
	|-LinkedList.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x110CC30 Offset: 0x110BE30 VA: 0x18110CC30
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x110CA40 Offset: 0x110BC40 VA: 0x18110CA40
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-LinkedList.Enumerator<ValueTuple<object, object>>.Dispose
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.Dispose
	|-LinkedList.Enumerator<object>.Dispose
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>.Dispose
	|-LinkedList.Enumerator<UIRenderDevice.DeviceToFree>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC1080 Offset: 0xCC0280 VA: 0x180CC1080
	|-LinkedList.Enumerator<ValueTuple<object, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|-LinkedList.Enumerator<object>.System.Runtime.Serialization.ISerializable.GetObjectData
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>.System.Runtime.Serialization.ISerializable.GetObjectData
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>.System.Runtime.Serialization.ISerializable.GetObjectData
	|-LinkedList.Enumerator<UIRenderDevice.DeviceToFree>.System.Runtime.Serialization.ISerializable.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC2DB0 Offset: 0xCC1FB0 VA: 0x180CC2DB0
	|-LinkedList.Enumerator<ValueTuple<object, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|-LinkedList.Enumerator<object>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|-LinkedList.Enumerator<DelayedActionManager.DelegateInfo>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|-LinkedList.Enumerator<UIRenderDevice.DeviceToFree>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	*/
}

// Namespace: System.Collections.Generic
[DebuggerTypeProxy(typeof(ICollectionDebugView<T>))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class LinkedList<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback // TypeDefIndex: 5542
{
	// Fields
	internal LinkedListNode<T> head; // 0x0
	internal int count; // 0x0
	internal int version; // 0x0
	private object _syncRoot; // 0x0
	private SerializationInfo _siInfo; // 0x0
	private const string VersionName = "Version";
	private const string CountName = "Count";
	private const string ValuesName = "Data";

	// Properties
	public int Count { get; }
	public LinkedListNode<T> First { get; }
	public LinkedListNode<T> Last { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-LinkedList<ValueTuple<object, object>>..ctor
	|-LinkedList<ValueTuple<object, object, object>>..ctor
	|-LinkedList<object>..ctor
	|-LinkedList<__Il2CppFullySharedGenericType>..ctor
	|-LinkedList<DelayedActionManager.DelegateInfo>..ctor
	|-LinkedList<UIRenderDevice.DeviceToFree>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132BE60 Offset: 0x132B060 VA: 0x18132BE60
	|-LinkedList<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x132B270 Offset: 0x132A470 VA: 0x18132B270
	|-LinkedList<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x132B570 Offset: 0x132A770 VA: 0x18132B570
	|-LinkedList<object>..ctor
	|
	|-RVA: 0x132B850 Offset: 0x132AA50 VA: 0x18132B850
	|-LinkedList<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x132BB70 Offset: 0x132AD70 VA: 0x18132BB70
	|-LinkedList<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x132AF90 Offset: 0x132A190 VA: 0x18132AF90
	|-LinkedList<UIRenderDevice.DeviceToFree>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1322410 Offset: 0x1321610 VA: 0x181322410
	|-LinkedList<ValueTuple<object, object>>..ctor
	|-LinkedList<ValueTuple<object, object, object>>..ctor
	|-LinkedList<object>..ctor
	|-LinkedList<__Il2CppFullySharedGenericType>..ctor
	|-LinkedList<DelayedActionManager.DelegateInfo>..ctor
	|-LinkedList<UIRenderDevice.DeviceToFree>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	|-LinkedList<ValueTuple<object, object>>.get_Count
	|-LinkedList<ValueTuple<object, object, object>>.get_Count
	|-LinkedList<object>.get_Count
	|-LinkedList<__Il2CppFullySharedGenericType>.get_Count
	|-LinkedList<DelayedActionManager.DelegateInfo>.get_Count
	|-LinkedList<UIRenderDevice.DeviceToFree>.get_Count
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> get_First() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	|-LinkedList<ValueTuple<object, object>>.get_First
	|-LinkedList<ValueTuple<object, object, object>>.get_First
	|-LinkedList<object>.get_First
	|-LinkedList<__Il2CppFullySharedGenericType>.get_First
	|-LinkedList<DelayedActionManager.DelegateInfo>.get_First
	|-LinkedList<UIRenderDevice.DeviceToFree>.get_First
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> get_Last() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132C140 Offset: 0x132B340 VA: 0x18132C140
	|-LinkedList<ValueTuple<object, object>>.get_Last
	|-LinkedList<ValueTuple<object, object, object>>.get_Last
	|-LinkedList<object>.get_Last
	|-LinkedList<DelayedActionManager.DelegateInfo>.get_Last
	|-LinkedList<UIRenderDevice.DeviceToFree>.get_Last
	|
	|-RVA: 0x132C160 Offset: 0x132B360 VA: 0x18132C160
	|-LinkedList<__Il2CppFullySharedGenericType>.get_Last
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-LinkedList<ValueTuple<object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-LinkedList<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-LinkedList<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-LinkedList<DelayedActionManager.DelegateInfo>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-LinkedList<UIRenderDevice.DeviceToFree>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<T>.Add(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1328DA0 Offset: 0x1327FA0 VA: 0x181328DA0
	|-LinkedList<ValueTuple<object, object>>.System.Collections.Generic.ICollection<T>.Add
	|-LinkedList<UIRenderDevice.DeviceToFree>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x1328D00 Offset: 0x1327F00 VA: 0x181328D00
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x1328D80 Offset: 0x1327F80 VA: 0x181328D80
	|-LinkedList<object>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x1328DD0 Offset: 0x1327FD0 VA: 0x181328DD0
	|-LinkedList<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x1328D40 Offset: 0x1327F40 VA: 0x181328D40
	|-LinkedList<DelayedActionManager.DelegateInfo>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> AddAfter(LinkedListNode<T> node, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1322C00 Offset: 0x1321E00 VA: 0x181322C00
	|-LinkedList<ValueTuple<object, object>>.AddAfter
	|-LinkedList<UIRenderDevice.DeviceToFree>.AddAfter
	|
	|-RVA: 0x1322D50 Offset: 0x1321F50 VA: 0x181322D50
	|-LinkedList<ValueTuple<object, object, object>>.AddAfter
	|
	|-RVA: 0x1322EB0 Offset: 0x13220B0 VA: 0x181322EB0
	|-LinkedList<object>.AddAfter
	|
	|-RVA: 0x13230E0 Offset: 0x13222E0 VA: 0x1813230E0
	|-LinkedList<__Il2CppFullySharedGenericType>.AddAfter
	|
	|-RVA: 0x1322AA0 Offset: 0x1321CA0 VA: 0x181322AA0
	|-LinkedList<DelayedActionManager.DelegateInfo>.AddAfter
	*/

	// RVA: -1 Offset: -1
	public void AddAfter(LinkedListNode<T> node, LinkedListNode<T> newNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1322920 Offset: 0x1321B20 VA: 0x181322920
	|-LinkedList<ValueTuple<object, object>>.AddAfter
	|-LinkedList<ValueTuple<object, object, object>>.AddAfter
	|-LinkedList<object>.AddAfter
	|-LinkedList<DelayedActionManager.DelegateInfo>.AddAfter
	|-LinkedList<UIRenderDevice.DeviceToFree>.AddAfter
	|
	|-RVA: 0x1323000 Offset: 0x1322200 VA: 0x181323000
	|-LinkedList<__Il2CppFullySharedGenericType>.AddAfter
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> AddBefore(LinkedListNode<T> node, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1323400 Offset: 0x1322600 VA: 0x181323400
	|-LinkedList<ValueTuple<object, object>>.AddBefore
	|-LinkedList<UIRenderDevice.DeviceToFree>.AddBefore
	|
	|-RVA: 0x1323550 Offset: 0x1322750 VA: 0x181323550
	|-LinkedList<ValueTuple<object, object, object>>.AddBefore
	|
	|-RVA: 0x1323A50 Offset: 0x1322C50 VA: 0x181323A50
	|-LinkedList<object>.AddBefore
	|
	|-RVA: 0x13236B0 Offset: 0x13228B0 VA: 0x1813236B0
	|-LinkedList<__Il2CppFullySharedGenericType>.AddBefore
	|
	|-RVA: 0x1323830 Offset: 0x1322A30 VA: 0x181323830
	|-LinkedList<DelayedActionManager.DelegateInfo>.AddBefore
	*/

	// RVA: -1 Offset: -1
	public void AddBefore(LinkedListNode<T> node, LinkedListNode<T> newNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1323280 Offset: 0x1322480 VA: 0x181323280
	|-LinkedList<ValueTuple<object, object>>.AddBefore
	|-LinkedList<ValueTuple<object, object, object>>.AddBefore
	|-LinkedList<object>.AddBefore
	|-LinkedList<DelayedActionManager.DelegateInfo>.AddBefore
	|-LinkedList<UIRenderDevice.DeviceToFree>.AddBefore
	|
	|-RVA: 0x1323980 Offset: 0x1322B80 VA: 0x181323980
	|-LinkedList<__Il2CppFullySharedGenericType>.AddBefore
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> AddFirst(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1323CA0 Offset: 0x1322EA0 VA: 0x181323CA0
	|-LinkedList<ValueTuple<object, object>>.AddFirst
	|-LinkedList<UIRenderDevice.DeviceToFree>.AddFirst
	|
	|-RVA: 0x1323E10 Offset: 0x1323010 VA: 0x181323E10
	|-LinkedList<ValueTuple<object, object, object>>.AddFirst
	|
	|-RVA: 0x1323ED0 Offset: 0x13230D0 VA: 0x181323ED0
	|-LinkedList<object>.AddFirst
	|
	|-RVA: 0x1323F80 Offset: 0x1323180 VA: 0x181323F80
	|-LinkedList<__Il2CppFullySharedGenericType>.AddFirst
	|
	|-RVA: 0x13240D0 Offset: 0x13232D0 VA: 0x1813240D0
	|-LinkedList<DelayedActionManager.DelegateInfo>.AddFirst
	*/

	// RVA: -1 Offset: -1
	public void AddFirst(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1323BA0 Offset: 0x1322DA0 VA: 0x181323BA0
	|-LinkedList<ValueTuple<object, object>>.AddFirst
	|-LinkedList<ValueTuple<object, object, object>>.AddFirst
	|-LinkedList<object>.AddFirst
	|-LinkedList<DelayedActionManager.DelegateInfo>.AddFirst
	|-LinkedList<UIRenderDevice.DeviceToFree>.AddFirst
	|
	|-RVA: 0x1323D50 Offset: 0x1322F50 VA: 0x181323D50
	|-LinkedList<__Il2CppFullySharedGenericType>.AddFirst
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> AddLast(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1324410 Offset: 0x1323610 VA: 0x181324410
	|-LinkedList<ValueTuple<object, object>>.AddLast
	|-LinkedList<UIRenderDevice.DeviceToFree>.AddLast
	|
	|-RVA: 0x1324350 Offset: 0x1323550 VA: 0x181324350
	|-LinkedList<ValueTuple<object, object, object>>.AddLast
	|
	|-RVA: 0x1324580 Offset: 0x1323780 VA: 0x181324580
	|-LinkedList<object>.AddLast
	|
	|-RVA: 0x1324630 Offset: 0x1323830 VA: 0x181324630
	|-LinkedList<__Il2CppFullySharedGenericType>.AddLast
	|
	|-RVA: 0x13244C0 Offset: 0x13236C0 VA: 0x1813244C0
	|-LinkedList<DelayedActionManager.DelegateInfo>.AddLast
	*/

	// RVA: -1 Offset: -1
	public void AddLast(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1324190 Offset: 0x1323390 VA: 0x181324190
	|-LinkedList<ValueTuple<object, object>>.AddLast
	|-LinkedList<ValueTuple<object, object, object>>.AddLast
	|-LinkedList<object>.AddLast
	|-LinkedList<DelayedActionManager.DelegateInfo>.AddLast
	|-LinkedList<UIRenderDevice.DeviceToFree>.AddLast
	|
	|-RVA: 0x1324290 Offset: 0x1323490 VA: 0x181324290
	|-LinkedList<__Il2CppFullySharedGenericType>.AddLast
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1324780 Offset: 0x1323980 VA: 0x181324780
	|-LinkedList<ValueTuple<object, object>>.Clear
	|-LinkedList<ValueTuple<object, object, object>>.Clear
	|-LinkedList<object>.Clear
	|-LinkedList<DelayedActionManager.DelegateInfo>.Clear
	|-LinkedList<UIRenderDevice.DeviceToFree>.Clear
	|
	|-RVA: 0x13247F0 Offset: 0x13239F0 VA: 0x1813247F0
	|-LinkedList<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool Contains(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1324880 Offset: 0x1323A80 VA: 0x181324880
	|-LinkedList<ValueTuple<object, object>>.Contains
	|
	|-RVA: 0x1324A00 Offset: 0x1323C00 VA: 0x181324A00
	|-LinkedList<ValueTuple<object, object, object>>.Contains
	|
	|-RVA: 0x1324A40 Offset: 0x1323C40 VA: 0x181324A40
	|-LinkedList<object>.Contains
	|
	|-RVA: 0x1324920 Offset: 0x1323B20 VA: 0x181324920
	|-LinkedList<__Il2CppFullySharedGenericType>.Contains
	|
	|-RVA: 0x13248E0 Offset: 0x1323AE0 VA: 0x1813248E0
	|-LinkedList<DelayedActionManager.DelegateInfo>.Contains
	|
	|-RVA: 0x13248B0 Offset: 0x1323AB0 VA: 0x1813248B0
	|-LinkedList<UIRenderDevice.DeviceToFree>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1324D40 Offset: 0x1323F40 VA: 0x181324D40
	|-LinkedList<ValueTuple<object, object>>.CopyTo
	|-LinkedList<UIRenderDevice.DeviceToFree>.CopyTo
	|
	|-RVA: 0x1324B10 Offset: 0x1323D10 VA: 0x181324B10
	|-LinkedList<ValueTuple<object, object, object>>.CopyTo
	|
	|-RVA: 0x1324F70 Offset: 0x1324170 VA: 0x181324F70
	|-LinkedList<object>.CopyTo
	|
	|-RVA: 0x1325180 Offset: 0x1324380 VA: 0x181325180
	|-LinkedList<__Il2CppFullySharedGenericType>.CopyTo
	|
	|-RVA: 0x1325480 Offset: 0x1324680 VA: 0x181325480
	|-LinkedList<DelayedActionManager.DelegateInfo>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> Find(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1326270 Offset: 0x1325470 VA: 0x181326270
	|-LinkedList<ValueTuple<object, object>>.Find
	|
	|-RVA: 0x1326020 Offset: 0x1325220 VA: 0x181326020
	|-LinkedList<ValueTuple<object, object, object>>.Find
	|
	|-RVA: 0x1326320 Offset: 0x1325520 VA: 0x181326320
	|-LinkedList<object>.Find
	|
	|-RVA: 0x1325D80 Offset: 0x1324F80 VA: 0x181325D80
	|-LinkedList<__Il2CppFullySharedGenericType>.Find
	|
	|-RVA: 0x13260F0 Offset: 0x13252F0 VA: 0x1813260F0
	|-LinkedList<DelayedActionManager.DelegateInfo>.Find
	|
	|-RVA: 0x13261C0 Offset: 0x13253C0 VA: 0x1813261C0
	|-LinkedList<UIRenderDevice.DeviceToFree>.Find
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> FindLast(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1325BF0 Offset: 0x1324DF0 VA: 0x181325BF0
	|-LinkedList<ValueTuple<object, object>>.FindLast
	|
	|-RVA: 0x1325780 Offset: 0x1324980 VA: 0x181325780
	|-LinkedList<ValueTuple<object, object, object>>.FindLast
	|
	|-RVA: 0x1325CB0 Offset: 0x1324EB0 VA: 0x181325CB0
	|-LinkedList<object>.FindLast
	|
	|-RVA: 0x1325860 Offset: 0x1324A60 VA: 0x181325860
	|-LinkedList<__Il2CppFullySharedGenericType>.FindLast
	|
	|-RVA: 0x13256B0 Offset: 0x13248B0 VA: 0x1813256B0
	|-LinkedList<DelayedActionManager.DelegateInfo>.FindLast
	|
	|-RVA: 0x1325B30 Offset: 0x1324D30 VA: 0x181325B30
	|-LinkedList<UIRenderDevice.DeviceToFree>.FindLast
	*/

	// RVA: -1 Offset: -1
	public LinkedList.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1326490 Offset: 0x1325690 VA: 0x181326490
	|-LinkedList<ValueTuple<object, object>>.GetEnumerator
	|-LinkedList<UIRenderDevice.DeviceToFree>.GetEnumerator
	|
	|-RVA: 0x1326510 Offset: 0x1325710 VA: 0x181326510
	|-LinkedList<ValueTuple<object, object, object>>.GetEnumerator
	|
	|-RVA: 0x13264D0 Offset: 0x13256D0 VA: 0x1813264D0
	|-LinkedList<object>.GetEnumerator
	|
	|-RVA: 0x13263E0 Offset: 0x13255E0 VA: 0x1813263E0
	|-LinkedList<__Il2CppFullySharedGenericType>.GetEnumerator
	|
	|-RVA: 0x1326550 Offset: 0x1325750 VA: 0x181326550
	|-LinkedList<DelayedActionManager.DelegateInfo>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1328EB0 Offset: 0x13280B0 VA: 0x181328EB0
	|-LinkedList<ValueTuple<object, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-LinkedList<UIRenderDevice.DeviceToFree>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x13290B0 Offset: 0x13282B0 VA: 0x1813290B0
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1329160 Offset: 0x1328360 VA: 0x181329160
	|-LinkedList<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1328F50 Offset: 0x1328150 VA: 0x181328F50
	|-LinkedList<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1329000 Offset: 0x1328200 VA: 0x181329000
	|-LinkedList<DelayedActionManager.DelegateInfo>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1328730 Offset: 0x1327930 VA: 0x181328730
	|-LinkedList<ValueTuple<object, object>>.Remove
	|
	|-RVA: 0x1328C50 Offset: 0x1327E50 VA: 0x181328C50
	|-LinkedList<ValueTuple<object, object, object>>.Remove
	|
	|-RVA: 0x1328980 Offset: 0x1327B80 VA: 0x181328980
	|-LinkedList<object>.Remove
	|
	|-RVA: 0x1328AA0 Offset: 0x1327CA0 VA: 0x181328AA0
	|-LinkedList<__Il2CppFullySharedGenericType>.Remove
	|
	|-RVA: 0x13288E0 Offset: 0x1327AE0 VA: 0x1813288E0
	|-LinkedList<DelayedActionManager.DelegateInfo>.Remove
	|
	|-RVA: 0x1328BB0 Offset: 0x1327DB0 VA: 0x181328BB0
	|-LinkedList<UIRenderDevice.DeviceToFree>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Remove(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13287D0 Offset: 0x13279D0 VA: 0x1813287D0
	|-LinkedList<ValueTuple<object, object>>.Remove
	|-LinkedList<ValueTuple<object, object, object>>.Remove
	|-LinkedList<object>.Remove
	|-LinkedList<DelayedActionManager.DelegateInfo>.Remove
	|-LinkedList<UIRenderDevice.DeviceToFree>.Remove
	|
	|-RVA: 0x13286D0 Offset: 0x13278D0 VA: 0x1813286D0
	|-LinkedList<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void RemoveFirst() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1328420 Offset: 0x1327620 VA: 0x181328420
	|-LinkedList<ValueTuple<object, object>>.RemoveFirst
	|-LinkedList<ValueTuple<object, object, object>>.RemoveFirst
	|-LinkedList<object>.RemoveFirst
	|-LinkedList<DelayedActionManager.DelegateInfo>.RemoveFirst
	|-LinkedList<UIRenderDevice.DeviceToFree>.RemoveFirst
	|
	|-RVA: 0x13284E0 Offset: 0x13276E0 VA: 0x1813284E0
	|-LinkedList<__Il2CppFullySharedGenericType>.RemoveFirst
	*/

	// RVA: -1 Offset: -1
	public void RemoveLast() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1328560 Offset: 0x1327760 VA: 0x181328560
	|-LinkedList<ValueTuple<object, object>>.RemoveLast
	|-LinkedList<ValueTuple<object, object, object>>.RemoveLast
	|-LinkedList<object>.RemoveLast
	|-LinkedList<DelayedActionManager.DelegateInfo>.RemoveLast
	|-LinkedList<UIRenderDevice.DeviceToFree>.RemoveLast
	|
	|-RVA: 0x1328630 Offset: 0x1327830 VA: 0x181328630
	|-LinkedList<__Il2CppFullySharedGenericType>.RemoveLast
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1326720 Offset: 0x1325920 VA: 0x181326720
	|-LinkedList<ValueTuple<object, object>>.GetObjectData
	|
	|-RVA: 0x1326BD0 Offset: 0x1325DD0 VA: 0x181326BD0
	|-LinkedList<ValueTuple<object, object, object>>.GetObjectData
	|
	|-RVA: 0x1326590 Offset: 0x1325790 VA: 0x181326590
	|-LinkedList<object>.GetObjectData
	|
	|-RVA: 0x1326D60 Offset: 0x1325F60 VA: 0x181326D60
	|-LinkedList<__Il2CppFullySharedGenericType>.GetObjectData
	|
	|-RVA: 0x13268B0 Offset: 0x1325AB0 VA: 0x1813268B0
	|-LinkedList<DelayedActionManager.DelegateInfo>.GetObjectData
	|
	|-RVA: 0x1326A40 Offset: 0x1325C40 VA: 0x181326A40
	|-LinkedList<UIRenderDevice.DeviceToFree>.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public virtual void OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13276B0 Offset: 0x13268B0 VA: 0x1813276B0
	|-LinkedList<ValueTuple<object, object>>.OnDeserialization
	|
	|-RVA: 0x1327EA0 Offset: 0x13270A0 VA: 0x181327EA0
	|-LinkedList<ValueTuple<object, object, object>>.OnDeserialization
	|
	|-RVA: 0x1327BF0 Offset: 0x1326DF0 VA: 0x181327BF0
	|-LinkedList<object>.OnDeserialization
	|
	|-RVA: 0x1327960 Offset: 0x1326B60 VA: 0x181327960
	|-LinkedList<__Il2CppFullySharedGenericType>.OnDeserialization
	|
	|-RVA: 0x1328160 Offset: 0x1327360 VA: 0x181328160
	|-LinkedList<DelayedActionManager.DelegateInfo>.OnDeserialization
	|
	|-RVA: 0x1327400 Offset: 0x1326600 VA: 0x181327400
	|-LinkedList<UIRenderDevice.DeviceToFree>.OnDeserialization
	*/

	// RVA: -1 Offset: -1
	private void InternalInsertNodeBefore(LinkedListNode<T> node, LinkedListNode<T> newNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1327080 Offset: 0x1326280 VA: 0x181327080
	|-LinkedList<ValueTuple<object, object>>.InternalInsertNodeBefore
	|-LinkedList<ValueTuple<object, object, object>>.InternalInsertNodeBefore
	|-LinkedList<object>.InternalInsertNodeBefore
	|-LinkedList<DelayedActionManager.DelegateInfo>.InternalInsertNodeBefore
	|-LinkedList<UIRenderDevice.DeviceToFree>.InternalInsertNodeBefore
	|
	|-RVA: 0x1326F00 Offset: 0x1326100 VA: 0x181326F00
	|-LinkedList<__Il2CppFullySharedGenericType>.InternalInsertNodeBefore
	*/

	// RVA: -1 Offset: -1
	private void InternalInsertNodeToEmptyList(LinkedListNode<T> newNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13270C0 Offset: 0x13262C0 VA: 0x1813270C0
	|-LinkedList<ValueTuple<object, object>>.InternalInsertNodeToEmptyList
	|-LinkedList<ValueTuple<object, object, object>>.InternalInsertNodeToEmptyList
	|-LinkedList<object>.InternalInsertNodeToEmptyList
	|-LinkedList<DelayedActionManager.DelegateInfo>.InternalInsertNodeToEmptyList
	|-LinkedList<UIRenderDevice.DeviceToFree>.InternalInsertNodeToEmptyList
	|
	|-RVA: 0x13270F0 Offset: 0x13262F0 VA: 0x1813270F0
	|-LinkedList<__Il2CppFullySharedGenericType>.InternalInsertNodeToEmptyList
	*/

	// RVA: -1 Offset: -1
	internal void InternalRemoveNode(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13271B0 Offset: 0x13263B0 VA: 0x1813271B0
	|-LinkedList<ValueTuple<object, object>>.InternalRemoveNode
	|-LinkedList<ValueTuple<object, object, object>>.InternalRemoveNode
	|-LinkedList<object>.InternalRemoveNode
	|-LinkedList<DelayedActionManager.DelegateInfo>.InternalRemoveNode
	|-LinkedList<UIRenderDevice.DeviceToFree>.InternalRemoveNode
	|
	|-RVA: 0x1327220 Offset: 0x1326420 VA: 0x181327220
	|-LinkedList<__Il2CppFullySharedGenericType>.InternalRemoveNode
	*/

	// RVA: -1 Offset: -1
	internal void ValidateNewNode(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132ACD0 Offset: 0x1329ED0 VA: 0x18132ACD0
	|-LinkedList<ValueTuple<object, object>>.ValidateNewNode
	|-LinkedList<ValueTuple<object, object, object>>.ValidateNewNode
	|-LinkedList<object>.ValidateNewNode
	|-LinkedList<DelayedActionManager.DelegateInfo>.ValidateNewNode
	|-LinkedList<UIRenderDevice.DeviceToFree>.ValidateNewNode
	|
	|-RVA: 0x132AD70 Offset: 0x1329F70 VA: 0x18132AD70
	|-LinkedList<__Il2CppFullySharedGenericType>.ValidateNewNode
	*/

	// RVA: -1 Offset: -1
	internal void ValidateNode(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132AE30 Offset: 0x132A030 VA: 0x18132AE30
	|-LinkedList<ValueTuple<object, object>>.ValidateNode
	|-LinkedList<ValueTuple<object, object, object>>.ValidateNode
	|-LinkedList<object>.ValidateNode
	|-LinkedList<DelayedActionManager.DelegateInfo>.ValidateNode
	|-LinkedList<UIRenderDevice.DeviceToFree>.ValidateNode
	|
	|-RVA: 0x132AED0 Offset: 0x132A0D0 VA: 0x18132AED0
	|-LinkedList<__Il2CppFullySharedGenericType>.ValidateNode
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-LinkedList<ValueTuple<object, object>>.System.Collections.ICollection.get_IsSynchronized
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.ICollection.get_IsSynchronized
	|-LinkedList<object>.System.Collections.ICollection.get_IsSynchronized
	|-LinkedList<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	|-LinkedList<DelayedActionManager.DelegateInfo>.System.Collections.ICollection.get_IsSynchronized
	|-LinkedList<UIRenderDevice.DeviceToFree>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132AB10 Offset: 0x1329D10 VA: 0x18132AB10
	|-LinkedList<ValueTuple<object, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x132AA30 Offset: 0x1329C30 VA: 0x18132AA30
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x132ABF0 Offset: 0x1329DF0 VA: 0x18132ABF0
	|-LinkedList<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x132AAA0 Offset: 0x1329CA0 VA: 0x18132AAA0
	|-LinkedList<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x132AB80 Offset: 0x1329D80 VA: 0x18132AB80
	|-LinkedList<DelayedActionManager.DelegateInfo>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x132AC60 Offset: 0x1329E60 VA: 0x18132AC60
	|-LinkedList<UIRenderDevice.DeviceToFree>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1329E40 Offset: 0x1329040 VA: 0x181329E40
	|-LinkedList<ValueTuple<object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x132A630 Offset: 0x1329830 VA: 0x18132A630
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x13291F0 Offset: 0x13283F0 VA: 0x1813291F0
	|-LinkedList<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x13299B0 Offset: 0x1328BB0 VA: 0x1813299B0
	|-LinkedList<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x132A230 Offset: 0x1329430 VA: 0x18132A230
	|-LinkedList<DelayedActionManager.DelegateInfo>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x13295C0 Offset: 0x13287C0 VA: 0x1813295C0
	|-LinkedList<UIRenderDevice.DeviceToFree>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1328EB0 Offset: 0x13280B0 VA: 0x181328EB0
	|-LinkedList<ValueTuple<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|-LinkedList<UIRenderDevice.DeviceToFree>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13290B0 Offset: 0x13282B0 VA: 0x1813290B0
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1329160 Offset: 0x1328360 VA: 0x181329160
	|-LinkedList<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1328F50 Offset: 0x1328150 VA: 0x181328F50
	|-LinkedList<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1329000 Offset: 0x1328200 VA: 0x181329000
	|-LinkedList<DelayedActionManager.DelegateInfo>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: System.Collections.Generic
public sealed class LinkedListNode<T> // TypeDefIndex: 5543
{
	// Fields
	internal LinkedList<T> list; // 0x0
	internal LinkedListNode<T> next; // 0x0
	internal LinkedListNode<T> prev; // 0x0
	internal T item; // 0x0

	// Properties
	public LinkedList<T> List { get; }
	public LinkedListNode<T> Next { get; }
	public LinkedListNode<T> Previous { get; }
	public T Value { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13221C0 Offset: 0x13213C0 VA: 0x1813221C0
	|-LinkedListNode<ValueTuple<object, object>>..ctor
	|-LinkedListNode<UIRenderDevice.DeviceToFree>..ctor
	|
	|-RVA: 0x13223D0 Offset: 0x13215D0 VA: 0x1813223D0
	|-LinkedListNode<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x1322410 Offset: 0x1321610 VA: 0x181322410
	|-LinkedListNode<object>..ctor
	|
	|-RVA: 0x1322440 Offset: 0x1321640 VA: 0x181322440
	|-LinkedListNode<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x1322300 Offset: 0x1321500 VA: 0x181322300
	|-LinkedListNode<DelayedActionManager.DelegateInfo>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(LinkedList<T> list, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1322510 Offset: 0x1321710 VA: 0x181322510
	|-LinkedListNode<ValueTuple<object, object>>..ctor
	|-LinkedListNode<UIRenderDevice.DeviceToFree>..ctor
	|
	|-RVA: 0x1322340 Offset: 0x1321540 VA: 0x181322340
	|-LinkedListNode<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x1322390 Offset: 0x1321590 VA: 0x181322390
	|-LinkedListNode<object>..ctor
	|
	|-RVA: 0x13221F0 Offset: 0x13213F0 VA: 0x1813221F0
	|-LinkedListNode<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x1322170 Offset: 0x1321370 VA: 0x181322170
	|-LinkedListNode<DelayedActionManager.DelegateInfo>..ctor
	*/

	// RVA: -1 Offset: -1
	public LinkedList<T> get_List() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	|-LinkedListNode<ValueTuple<object, object>>.get_List
	|-LinkedListNode<ValueTuple<object, object, object>>.get_List
	|-LinkedListNode<object>.get_List
	|-LinkedListNode<DelayedActionManager.DelegateInfo>.get_List
	|-LinkedListNode<UIRenderDevice.DeviceToFree>.get_List
	|
	|-RVA: 0x1322550 Offset: 0x1321750 VA: 0x181322550
	|-LinkedListNode<__Il2CppFullySharedGenericType>.get_List
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> get_Next() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1322580 Offset: 0x1321780 VA: 0x181322580
	|-LinkedListNode<ValueTuple<object, object>>.get_Next
	|-LinkedListNode<ValueTuple<object, object, object>>.get_Next
	|-LinkedListNode<object>.get_Next
	|-LinkedListNode<DelayedActionManager.DelegateInfo>.get_Next
	|-LinkedListNode<UIRenderDevice.DeviceToFree>.get_Next
	|
	|-RVA: 0x13225C0 Offset: 0x13217C0 VA: 0x1813225C0
	|-LinkedListNode<__Il2CppFullySharedGenericType>.get_Next
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> get_Previous() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1322750 Offset: 0x1321950 VA: 0x181322750
	|-LinkedListNode<ValueTuple<object, object>>.get_Previous
	|-LinkedListNode<ValueTuple<object, object, object>>.get_Previous
	|-LinkedListNode<object>.get_Previous
	|-LinkedListNode<DelayedActionManager.DelegateInfo>.get_Previous
	|-LinkedListNode<UIRenderDevice.DeviceToFree>.get_Previous
	|
	|-RVA: 0x13226A0 Offset: 0x13218A0 VA: 0x1813226A0
	|-LinkedListNode<__Il2CppFullySharedGenericType>.get_Previous
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F6C80 Offset: 0x3F5E80 VA: 0x1803F6C80
	|-LinkedListNode<ValueTuple<object, object>>.get_Value
	|-LinkedListNode<UIRenderDevice.DeviceToFree>.get_Value
	|
	|-RVA: 0x4E6990 Offset: 0x4E5B90 VA: 0x1804E6990
	|-LinkedListNode<ValueTuple<object, object, object>>.get_Value
	|
	|-RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	|-LinkedListNode<object>.get_Value
	|
	|-RVA: 0x13227A0 Offset: 0x13219A0 VA: 0x1813227A0
	|-LinkedListNode<__Il2CppFullySharedGenericType>.get_Value
	|
	|-RVA: 0x1322780 Offset: 0x1321980 VA: 0x181322780
	|-LinkedListNode<DelayedActionManager.DelegateInfo>.get_Value
	*/

	// RVA: -1 Offset: -1
	public void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F6CA0 Offset: 0x3F5EA0 VA: 0x1803F6CA0
	|-LinkedListNode<ValueTuple<object, object>>.set_Value
	|-LinkedListNode<UIRenderDevice.DeviceToFree>.set_Value
	|
	|-RVA: 0x4E69B0 Offset: 0x4E5BB0 VA: 0x1804E69B0
	|-LinkedListNode<ValueTuple<object, object, object>>.set_Value
	|
	|-RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	|-LinkedListNode<object>.set_Value
	|
	|-RVA: 0x1322850 Offset: 0x1321A50 VA: 0x181322850
	|-LinkedListNode<__Il2CppFullySharedGenericType>.set_Value
	|
	|-RVA: 0x1322910 Offset: 0x1321B10 VA: 0x181322910
	|-LinkedListNode<DelayedActionManager.DelegateInfo>.set_Value
	*/

	// RVA: -1 Offset: -1
	internal void Invalidate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1322090 Offset: 0x1321290 VA: 0x181322090
	|-LinkedListNode<ValueTuple<object, object>>.Invalidate
	|-LinkedListNode<ValueTuple<object, object, object>>.Invalidate
	|-LinkedListNode<object>.Invalidate
	|-LinkedListNode<DelayedActionManager.DelegateInfo>.Invalidate
	|-LinkedListNode<UIRenderDevice.DeviceToFree>.Invalidate
	|
	|-RVA: 0x13220A0 Offset: 0x13212A0 VA: 0x1813220A0
	|-LinkedListNode<__Il2CppFullySharedGenericType>.Invalidate
	*/
}

// Namespace: 
public struct SortedDictionary.Enumerator<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator // TypeDefIndex: 5544
{
	// Fields
	private SortedSet.Enumerator<KeyValuePair<TKey, TValue>> _treeEnum; // 0x0
	private int _getEnumeratorRetType; // 0x0
	internal const int KeyValuePair = 1;
	internal const int DictEntry = 2;

	// Properties
	public KeyValuePair<TKey, TValue> Current { get; }
	internal bool NotStartedOrEnded { get; }
	private object System.Collections.IEnumerator.Current { get; }
	private object System.Collections.IDictionaryEnumerator.Key { get; }
	private object System.Collections.IDictionaryEnumerator.Value { get; }
	private DictionaryEntry System.Collections.IDictionaryEnumerator.Entry { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1126690 Offset: 0x1125890 VA: 0x181126690
	|-SortedDictionary.Enumerator<object, char>..ctor
	|
	|-RVA: 0x113E470 Offset: 0x113D670 VA: 0x18113E470
	|-SortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1121A70 Offset: 0x1120C70 VA: 0x181121A70
	|-SortedDictionary.Enumerator<object, char>.MoveNext
	|
	|-RVA: 0x1132970 Offset: 0x1131B70 VA: 0x181132970
	|-SortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1120560 Offset: 0x111F760 VA: 0x181120560
	|-SortedDictionary.Enumerator<object, char>.Dispose
	|
	|-RVA: 0x112ECB0 Offset: 0x112DEB0 VA: 0x18112ECB0
	|-SortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public KeyValuePair<TKey, TValue> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11268A0 Offset: 0x1125AA0 VA: 0x1811268A0
	|-SortedDictionary.Enumerator<object, char>.get_Current
	|
	|-RVA: 0x113ED60 Offset: 0x113DF60 VA: 0x18113ED60
	|-SortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1
	internal bool get_NotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1126B30 Offset: 0x1125D30 VA: 0x181126B30
	|-SortedDictionary.Enumerator<object, char>.get_NotStartedOrEnded
	|
	|-RVA: 0x113F5D0 Offset: 0x113E7D0 VA: 0x18113F5D0
	|-SortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_NotStartedOrEnded
	*/

	// RVA: -1 Offset: -1
	internal void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1122110 Offset: 0x1121310 VA: 0x181122110
	|-SortedDictionary.Enumerator<object, char>.Reset
	|
	|-RVA: 0x1134760 Offset: 0x1133960 VA: 0x181134760
	|-SortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1122110 Offset: 0x1121310 VA: 0x181122110
	|-SortedDictionary.Enumerator<object, char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1134760 Offset: 0x1133960 VA: 0x181134760
	|-SortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11245C0 Offset: 0x11237C0 VA: 0x1811245C0
	|-SortedDictionary.Enumerator<object, char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1139400 Offset: 0x1138600 VA: 0x181139400
	|-SortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IDictionaryEnumerator.get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1122D50 Offset: 0x1121F50 VA: 0x181122D50
	|-SortedDictionary.Enumerator<object, char>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x11365B0 Offset: 0x11357B0 VA: 0x1811365B0
	|-SortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionaryEnumerator.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private object System.Collections.IDictionaryEnumerator.get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1122E30 Offset: 0x1122030 VA: 0x181122E30
	|-SortedDictionary.Enumerator<object, char>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x1137230 Offset: 0x1136430 VA: 0x181137230
	|-SortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionaryEnumerator.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1122A40 Offset: 0x1121C40 VA: 0x181122A40
	|-SortedDictionary.Enumerator<object, char>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x1135CB0 Offset: 0x1134EB0 VA: 0x181135CB0
	|-SortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionaryEnumerator.get_Entry
	*/
}

// Namespace: 
public struct SortedDictionary.KeyCollection.Enumerator<TKey, TValue> : IEnumerator<TKey>, IDisposable, IEnumerator // TypeDefIndex: 5545
{
	// Fields
	private SortedDictionary.Enumerator<TKey, TValue> _dictEnum; // 0x0

	// Properties
	public TKey Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1126770 Offset: 0x1125970 VA: 0x181126770
	|-SortedDictionary.KeyCollection.Enumerator<object, char>..ctor
	|
	|-RVA: 0x113E200 Offset: 0x113D400 VA: 0x18113E200
	|-SortedDictionary.KeyCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1120520 Offset: 0x111F720 VA: 0x181120520
	|-SortedDictionary.KeyCollection.Enumerator<object, char>.Dispose
	|
	|-RVA: 0x112EE70 Offset: 0x112E070 VA: 0x18112EE70
	|-SortedDictionary.KeyCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1121080 Offset: 0x1120280 VA: 0x181121080
	|-SortedDictionary.KeyCollection.Enumerator<object, char>.MoveNext
	|
	|-RVA: 0x1131840 Offset: 0x1130A40 VA: 0x181131840
	|-SortedDictionary.KeyCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TKey get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1126A20 Offset: 0x1125C20 VA: 0x181126A20
	|-SortedDictionary.KeyCollection.Enumerator<object, char>.get_Current
	|
	|-RVA: 0x113E8C0 Offset: 0x113DAC0 VA: 0x18113E8C0
	|-SortedDictionary.KeyCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1124300 Offset: 0x1123500 VA: 0x181124300
	|-SortedDictionary.KeyCollection.Enumerator<object, char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x113BD30 Offset: 0x113AF30 VA: 0x18113BD30
	|-SortedDictionary.KeyCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1123300 Offset: 0x1122500 VA: 0x181123300
	|-SortedDictionary.KeyCollection.Enumerator<object, char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1137BB0 Offset: 0x1136DB0 VA: 0x181137BB0
	|-SortedDictionary.KeyCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class SortedDictionary.KeyCollection.<>c__DisplayClass5_0<TKey, TValue> // TypeDefIndex: 5546
{
	// Fields
	public TKey[] array; // 0x0
	public int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-SortedDictionary.KeyCollection.<>c__DisplayClass5_0<object, char>..ctor
	|-SortedDictionary.KeyCollection.<>c__DisplayClass5_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <CopyTo>b__0(SortedSet.Node<KeyValuePair<TKey, TValue>> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0F4C0 Offset: 0xB0E6C0 VA: 0x180B0F4C0
	|-SortedDictionary.KeyCollection.<>c__DisplayClass5_0<object, char>.<CopyTo>b__0
	|
	|-RVA: 0xB0F310 Offset: 0xB0E510 VA: 0x180B0F310
	|-SortedDictionary.KeyCollection.<>c__DisplayClass5_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CopyTo>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class SortedDictionary.KeyCollection.<>c__DisplayClass6_0<TKey, TValue> // TypeDefIndex: 5547
{
	// Fields
	public int index; // 0x0
	public object[] objects; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-SortedDictionary.KeyCollection.<>c__DisplayClass6_0<object, char>..ctor
	|-SortedDictionary.KeyCollection.<>c__DisplayClass6_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <System.Collections.ICollection.CopyTo>b__0(SortedSet.Node<KeyValuePair<TKey, TValue>> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB103F0 Offset: 0xB0F5F0 VA: 0x180B103F0
	|-SortedDictionary.KeyCollection.<>c__DisplayClass6_0<object, char>.<System.Collections.ICollection.CopyTo>b__0
	|
	|-RVA: 0xB10190 Offset: 0xB0F390 VA: 0x180B10190
	|-SortedDictionary.KeyCollection.<>c__DisplayClass6_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<System.Collections.ICollection.CopyTo>b__0
	*/
}

// Namespace: 
[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView<TKey, TValue>))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public sealed class SortedDictionary.KeyCollection<TKey, TValue> : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey> // TypeDefIndex: 5548
{
	// Fields
	private SortedDictionary<TKey, TValue> _dictionary; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<TKey>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SortedDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCECF0 Offset: 0xBCDEF0 VA: 0x180BCECF0
	|-SortedDictionary.KeyCollection<object, char>..ctor
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public SortedDictionary.KeyCollection.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD05D20 Offset: 0xD04F20 VA: 0x180D05D20
	|-SortedDictionary.KeyCollection<object, char>.GetEnumerator
	|
	|-RVA: 0xD05F00 Offset: 0xD05100 VA: 0x180D05F00
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD06F10 Offset: 0xD06110 VA: 0x180D06F10
	|-SortedDictionary.KeyCollection<object, char>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0xD07010 Offset: 0xD06210 VA: 0x180D07010
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD06F10 Offset: 0xD06110 VA: 0x180D06F10
	|-SortedDictionary.KeyCollection<object, char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xD07010 Offset: 0xD06210 VA: 0x180D07010
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(TKey[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD05710 Offset: 0xD04910 VA: 0x180D05710
	|-SortedDictionary.KeyCollection<object, char>.CopyTo
	|
	|-RVA: 0xD04690 Offset: 0xD03890 VA: 0x180D04690
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12FB400 Offset: 0x12FA600 VA: 0x1812FB400
	|-SortedDictionary.KeyCollection<object, char>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x130ECF0 Offset: 0x130DEF0 VA: 0x18130ECF0
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD12110 Offset: 0xD11310 VA: 0x180D12110
	|-SortedDictionary.KeyCollection<object, char>.get_Count
	|
	|-RVA: 0xD120A0 Offset: 0xD112A0 VA: 0x180D120A0
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-SortedDictionary.KeyCollection<object, char>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12FAA50 Offset: 0x12F9C50 VA: 0x1812FAA50
	|-SortedDictionary.KeyCollection<object, char>.System.Collections.Generic.ICollection<TKey>.Add
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.ICollection<TKey>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12FAAA0 Offset: 0x12F9CA0 VA: 0x1812FAAA0
	|-SortedDictionary.KeyCollection<object, char>.System.Collections.Generic.ICollection<TKey>.Clear
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12FAAF0 Offset: 0x12F9CF0 VA: 0x1812FAAF0
	|-SortedDictionary.KeyCollection<object, char>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0xD06130 Offset: 0xD05330 VA: 0x180D06130
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12FAA50 Offset: 0x12F9C50 VA: 0x1812FAA50
	|-SortedDictionary.KeyCollection<object, char>.System.Collections.Generic.ICollection<TKey>.Remove
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-SortedDictionary.KeyCollection<object, char>.System.Collections.ICollection.get_IsSynchronized
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1307260 Offset: 0x1306460 VA: 0x181307260
	|-SortedDictionary.KeyCollection<object, char>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1310260 Offset: 0x130F460 VA: 0x181310260
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/
}

// Namespace: 
public struct SortedDictionary.ValueCollection.Enumerator<TKey, TValue> : IEnumerator<TValue>, IDisposable, IEnumerator // TypeDefIndex: 5549
{
	// Fields
	private SortedDictionary.Enumerator<TKey, TValue> _dictEnum; // 0x0

	// Properties
	public TValue Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1126770 Offset: 0x1125970 VA: 0x181126770
	|-SortedDictionary.ValueCollection.Enumerator<object, char>..ctor
	|
	|-RVA: 0x113E200 Offset: 0x113D400 VA: 0x18113E200
	|-SortedDictionary.ValueCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1120520 Offset: 0x111F720 VA: 0x181120520
	|-SortedDictionary.ValueCollection.Enumerator<object, char>.Dispose
	|
	|-RVA: 0x112EE70 Offset: 0x112E070 VA: 0x18112EE70
	|-SortedDictionary.ValueCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1121080 Offset: 0x1120280 VA: 0x181121080
	|-SortedDictionary.ValueCollection.Enumerator<object, char>.MoveNext
	|
	|-RVA: 0x1131840 Offset: 0x1130A40 VA: 0x181131840
	|-SortedDictionary.ValueCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1126950 Offset: 0x1125B50 VA: 0x181126950
	|-SortedDictionary.ValueCollection.Enumerator<object, char>.get_Current
	|
	|-RVA: 0x113E8C0 Offset: 0x113DAC0 VA: 0x18113E8C0
	|-SortedDictionary.ValueCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1125180 Offset: 0x1124380 VA: 0x181125180
	|-SortedDictionary.ValueCollection.Enumerator<object, char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x113BD30 Offset: 0x113AF30 VA: 0x18113BD30
	|-SortedDictionary.ValueCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1123300 Offset: 0x1122500 VA: 0x181123300
	|-SortedDictionary.ValueCollection.Enumerator<object, char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1137BB0 Offset: 0x1136DB0 VA: 0x181137BB0
	|-SortedDictionary.ValueCollection.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class SortedDictionary.ValueCollection.<>c__DisplayClass5_0<TKey, TValue> // TypeDefIndex: 5550
{
	// Fields
	public TValue[] array; // 0x0
	public int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-SortedDictionary.ValueCollection.<>c__DisplayClass5_0<object, char>..ctor
	|-SortedDictionary.ValueCollection.<>c__DisplayClass5_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <CopyTo>b__0(SortedSet.Node<KeyValuePair<TKey, TValue>> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0F510 Offset: 0xB0E710 VA: 0x180B0F510
	|-SortedDictionary.ValueCollection.<>c__DisplayClass5_0<object, char>.<CopyTo>b__0
	|
	|-RVA: 0xB0F310 Offset: 0xB0E510 VA: 0x180B0F310
	|-SortedDictionary.ValueCollection.<>c__DisplayClass5_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CopyTo>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class SortedDictionary.ValueCollection.<>c__DisplayClass6_0<TKey, TValue> // TypeDefIndex: 5551
{
	// Fields
	public int index; // 0x0
	public object[] objects; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-SortedDictionary.ValueCollection.<>c__DisplayClass6_0<object, char>..ctor
	|-SortedDictionary.ValueCollection.<>c__DisplayClass6_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <System.Collections.ICollection.CopyTo>b__0(SortedSet.Node<KeyValuePair<TKey, TValue>> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB10350 Offset: 0xB0F550 VA: 0x180B10350
	|-SortedDictionary.ValueCollection.<>c__DisplayClass6_0<object, char>.<System.Collections.ICollection.CopyTo>b__0
	|
	|-RVA: 0xB10190 Offset: 0xB0F390 VA: 0x180B10190
	|-SortedDictionary.ValueCollection.<>c__DisplayClass6_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<System.Collections.ICollection.CopyTo>b__0
	*/
}

// Namespace: 
[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView<TKey, TValue>))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public sealed class SortedDictionary.ValueCollection<TKey, TValue> : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue> // TypeDefIndex: 5552
{
	// Fields
	private SortedDictionary<TKey, TValue> _dictionary; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<TValue>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SortedDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBCECF0 Offset: 0xBCDEF0 VA: 0x180BCECF0
	|-SortedDictionary.ValueCollection<object, char>..ctor
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public SortedDictionary.ValueCollection.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD05D20 Offset: 0xD04F20 VA: 0x180D05D20
	|-SortedDictionary.ValueCollection<object, char>.GetEnumerator
	|
	|-RVA: 0xD05F00 Offset: 0xD05100 VA: 0x180D05F00
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD06F10 Offset: 0xD06110 VA: 0x180D06F10
	|-SortedDictionary.ValueCollection<object, char>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0xD07010 Offset: 0xD06210 VA: 0x180D07010
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD06F10 Offset: 0xD06110 VA: 0x180D06F10
	|-SortedDictionary.ValueCollection<object, char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xD07010 Offset: 0xD06210 VA: 0x180D07010
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(TValue[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD05710 Offset: 0xD04910 VA: 0x180D05710
	|-SortedDictionary.ValueCollection<object, char>.CopyTo
	|
	|-RVA: 0xD04690 Offset: 0xD03890 VA: 0x180D04690
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD07590 Offset: 0xD06790 VA: 0x180D07590
	|-SortedDictionary.ValueCollection<object, char>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD07120 Offset: 0xD06320 VA: 0x180D07120
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD12110 Offset: 0xD11310 VA: 0x180D12110
	|-SortedDictionary.ValueCollection<object, char>.get_Count
	|
	|-RVA: 0xD120A0 Offset: 0xD112A0 VA: 0x180D120A0
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-SortedDictionary.ValueCollection<object, char>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD06030 Offset: 0xD05230 VA: 0x180D06030
	|-SortedDictionary.ValueCollection<object, char>.System.Collections.Generic.ICollection<TValue>.Add
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.ICollection<TValue>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD06080 Offset: 0xD05280 VA: 0x180D06080
	|-SortedDictionary.ValueCollection<object, char>.System.Collections.Generic.ICollection<TValue>.Clear
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD06B40 Offset: 0xD05D40 VA: 0x180D06B40
	|-SortedDictionary.ValueCollection<object, char>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0xD06130 Offset: 0xD05330 VA: 0x180D06130
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD06030 Offset: 0xD05230 VA: 0x180D06030
	|-SortedDictionary.ValueCollection<object, char>.System.Collections.Generic.ICollection<TValue>.Remove
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-SortedDictionary.ValueCollection<object, char>.System.Collections.ICollection.get_IsSynchronized
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD11510 Offset: 0xD10710 VA: 0x180D11510
	|-SortedDictionary.ValueCollection<object, char>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD114C0 Offset: 0xD106C0 VA: 0x180D114C0
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/
}

// Namespace: 
[Serializable]
internal sealed class SortedDictionary.KeyValuePairComparer<TKey, TValue> : Comparer<KeyValuePair<TKey, TValue>> // TypeDefIndex: 5553
{
	// Fields
	internal IComparer<TKey> keyComparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IComparer<TKey> keyComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13113F0 Offset: 0x13105F0 VA: 0x1813113F0
	|-SortedDictionary.KeyValuePairComparer<object, char>..ctor
	|
	|-RVA: 0x1311460 Offset: 0x1310660 VA: 0x181311460
	|-SortedDictionary.KeyValuePairComparer<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override int Compare(KeyValuePair<TKey, TValue> x, KeyValuePair<TKey, TValue> y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1311140 Offset: 0x1310340 VA: 0x181311140
	|-SortedDictionary.KeyValuePairComparer<object, char>.Compare
	|
	|-RVA: 0x1311210 Offset: 0x1310410 VA: 0x181311210
	|-SortedDictionary.KeyValuePairComparer<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Compare
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class SortedDictionary.<>c__DisplayClass34_0<TKey, TValue> // TypeDefIndex: 5554
{
	// Fields
	public bool found; // 0x0
	public TValue value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-SortedDictionary.<>c__DisplayClass34_0<object, char>..ctor
	|-SortedDictionary.<>c__DisplayClass34_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <ContainsValue>b__0(SortedSet.Node<KeyValuePair<TKey, TValue>> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0CBC0 Offset: 0xB0BDC0 VA: 0x180B0CBC0
	|-SortedDictionary.<>c__DisplayClass34_0<object, char>.<ContainsValue>b__0
	|
	|-RVA: 0xB0CBE0 Offset: 0xB0BDE0 VA: 0x180B0CBE0
	|-SortedDictionary.<>c__DisplayClass34_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<ContainsValue>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class SortedDictionary.<>c__DisplayClass34_1<TKey, TValue> // TypeDefIndex: 5555
{
	// Fields
	public EqualityComparer<TValue> valueComparer; // 0x0
	public SortedDictionary.<>c__DisplayClass34_0<TKey, TValue> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-SortedDictionary.<>c__DisplayClass34_1<object, char>..ctor
	|-SortedDictionary.<>c__DisplayClass34_1<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <ContainsValue>b__1(SortedSet.Node<KeyValuePair<TKey, TValue>> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0CD80 Offset: 0xB0BF80 VA: 0x180B0CD80
	|-SortedDictionary.<>c__DisplayClass34_1<object, char>.<ContainsValue>b__1
	|
	|-RVA: 0xB0CDF0 Offset: 0xB0BFF0 VA: 0x180B0CDF0
	|-SortedDictionary.<>c__DisplayClass34_1<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<ContainsValue>b__1
	*/
}

// Namespace: System.Collections.Generic
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView<K, V>))]
[DefaultMember("Item")]
[Serializable]
public class SortedDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>> // TypeDefIndex: 5556
{
	// Fields
	private SortedDictionary.KeyCollection<TKey, TValue> _keys; // 0x0
	private SortedDictionary.ValueCollection<TKey, TValue> _values; // 0x0
	private TreeSet<KeyValuePair<TKey, TValue>> _set; // 0x0

	// Properties
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	public TValue Item { get; set; }
	public int Count { get; }
	public IComparer<TKey> Comparer { get; }
	public SortedDictionary.KeyCollection<TKey, TValue> Keys { get; }
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get; }
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get; }
	public SortedDictionary.ValueCollection<TKey, TValue> Values { get; }
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get; }
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFB8C0 Offset: 0xBFAAC0 VA: 0x180BFB8C0
	|-SortedDictionary<object, char>..ctor
	|
	|-RVA: 0xBFC110 Offset: 0xBFB310 VA: 0x180BFC110
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFB8A0 Offset: 0xBFAAA0 VA: 0x180BFB8A0
	|-SortedDictionary<object, char>..ctor
	|
	|-RVA: 0xBFC130 Offset: 0xBFB330 VA: 0x180BFC130
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> dictionary, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFBE30 Offset: 0xBFB030 VA: 0x180BFBE30
	|-SortedDictionary<object, char>..ctor
	|
	|-RVA: 0xBFBA60 Offset: 0xBFAC60 VA: 0x180BFBA60
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFB990 Offset: 0xBFAB90 VA: 0x180BFB990
	|-SortedDictionary<object, char>..ctor
	|
	|-RVA: 0xBFC150 Offset: 0xBFB350 VA: 0x180BFC150
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF8F50 Offset: 0xBF8150 VA: 0x180BF8F50
	|-SortedDictionary<object, char>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xBF8F90 Offset: 0xBF8190 VA: 0x180BF8F90
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF9030 Offset: 0xBF8230 VA: 0x180BF9030
	|-SortedDictionary<object, char>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xBF90F0 Offset: 0xBF82F0 VA: 0x180BF90F0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF9440 Offset: 0xBF8640 VA: 0x180BF9440
	|-SortedDictionary<object, char>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xBF9530 Offset: 0xBF8730 VA: 0x180BF9530
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-SortedDictionary<object, char>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 38
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFC420 Offset: 0xBFB620 VA: 0x180BFC420
	|-SortedDictionary<object, char>.get_Item
	|
	|-RVA: 0xBFC560 Offset: 0xBFB760 VA: 0x180BFC560
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFCCC0 Offset: 0xBFBEC0 VA: 0x180BFCCC0
	|-SortedDictionary<object, char>.set_Item
	|
	|-RVA: 0xBFCE70 Offset: 0xBFC070 VA: 0x180BFCE70
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 41
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFC3B0 Offset: 0xBFB5B0 VA: 0x180BFC3B0
	|-SortedDictionary<object, char>.get_Count
	|
	|-RVA: 0xBFC3E0 Offset: 0xBFB5E0 VA: 0x180BFC3E0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public IComparer<TKey> get_Comparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFC2F0 Offset: 0xBFB4F0 VA: 0x180BFC2F0
	|-SortedDictionary<object, char>.get_Comparer
	|
	|-RVA: 0xBFC220 Offset: 0xBFB420 VA: 0x180BFC220
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Comparer
	*/

	// RVA: -1 Offset: -1
	public SortedDictionary.KeyCollection<TKey, TValue> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFCA80 Offset: 0xBFBC80 VA: 0x180BFCA80
	|-SortedDictionary<object, char>.get_Keys
	|
	|-RVA: 0xBFCB10 Offset: 0xBFBD10 VA: 0x180BFCB10
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF9820 Offset: 0xBF8A20 VA: 0x180BF9820
	|-SortedDictionary<object, char>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0xBF9840 Offset: 0xBF8A40 VA: 0x180BF9840
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 39
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF9820 Offset: 0xBF8A20 VA: 0x180BF9820
	|-SortedDictionary<object, char>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0xBF9840 Offset: 0xBF8A40 VA: 0x180BF9840
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1
	public SortedDictionary.ValueCollection<TKey, TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFCC30 Offset: 0xBFBE30 VA: 0x180BFCC30
	|-SortedDictionary<object, char>.get_Values
	|
	|-RVA: 0xBFCBA0 Offset: 0xBFBDA0 VA: 0x180BFCBA0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF9860 Offset: 0xBF8A60 VA: 0x180BF9860
	|-SortedDictionary<object, char>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0xBF9880 Offset: 0xBF8A80 VA: 0x180BF9880
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 40
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF9860 Offset: 0xBF8A60 VA: 0x180BF9860
	|-SortedDictionary<object, char>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0xBF9880 Offset: 0xBF8A80 VA: 0x180BF9880
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF7D20 Offset: 0xBF6F20 VA: 0x180BF7D20
	|-SortedDictionary<object, char>.Add
	|
	|-RVA: 0xBF7DE0 Offset: 0xBF6FE0 VA: 0x180BF7DE0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF80D0 Offset: 0xBF72D0 VA: 0x180BF80D0
	|-SortedDictionary<object, char>.Clear
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF8420 Offset: 0xBF7620 VA: 0x180BF8420
	|-SortedDictionary<object, char>.ContainsKey
	|
	|-RVA: 0xBF8100 Offset: 0xBF7300 VA: 0x180BF8100
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public bool ContainsValue(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF8840 Offset: 0xBF7A40 VA: 0x180BF8840
	|-SortedDictionary<object, char>.ContainsValue
	|
	|-RVA: 0xBF84E0 Offset: 0xBF76E0 VA: 0x180BF84E0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsValue
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF8A00 Offset: 0xBF7C00 VA: 0x180BF8A00
	|-SortedDictionary<object, char>.CopyTo
	|
	|-RVA: 0xBF89D0 Offset: 0xBF7BD0 VA: 0x180BF89D0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public SortedDictionary.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF8A70 Offset: 0xBF7C70 VA: 0x180BF8A70
	|-SortedDictionary<object, char>.GetEnumerator
	|
	|-RVA: 0xBF8A30 Offset: 0xBF7C30 VA: 0x180BF8A30
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF98A0 Offset: 0xBF8AA0 VA: 0x180BF98A0
	|-SortedDictionary<object, char>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0xBF9930 Offset: 0xBF8B30 VA: 0x180BF9930
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF8B60 Offset: 0xBF7D60 VA: 0x180BF8B60
	|-SortedDictionary<object, char>.Remove
	|
	|-RVA: 0xBF8C20 Offset: 0xBF7E20 VA: 0x180BF8C20
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFB390 Offset: 0xBFA590 VA: 0x180BFB390
	|-SortedDictionary<object, char>.TryGetValue
	|
	|-RVA: 0xBFB480 Offset: 0xBFA680 VA: 0x180BFB480
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF99C0 Offset: 0xBF8BC0 VA: 0x180BF99C0
	|-SortedDictionary<object, char>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xBF9A30 Offset: 0xBF8C30 VA: 0x180BF9A30
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private bool System.Collections.IDictionary.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-SortedDictionary<object, char>.System.Collections.IDictionary.get_IsFixedSize
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private bool System.Collections.IDictionary.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-SortedDictionary<object, char>.System.Collections.IDictionary.get_IsReadOnly
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF9820 Offset: 0xBF8A20 VA: 0x180BF9820
	|-SortedDictionary<object, char>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0xBF9840 Offset: 0xBF8A40 VA: 0x180BF9840
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF9860 Offset: 0xBF8A60 VA: 0x180BF9860
	|-SortedDictionary<object, char>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0xBF9880 Offset: 0xBF8A80 VA: 0x180BF9880
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFAAE0 Offset: 0xBF9CE0 VA: 0x180BFAAE0
	|-SortedDictionary<object, char>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0xBFA920 Offset: 0xBF9B20 VA: 0x180BFA920
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFB0C0 Offset: 0xBFA2C0 VA: 0x180BFB0C0
	|-SortedDictionary<object, char>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0xBFAC90 Offset: 0xBF9E90 VA: 0x180BFAC90
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF9F70 Offset: 0xBF9170 VA: 0x180BF9F70
	|-SortedDictionary<object, char>.System.Collections.IDictionary.Add
	|
	|-RVA: 0xBF9B40 Offset: 0xBF8D40 VA: 0x180BF9B40
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFA2A0 Offset: 0xBF94A0 VA: 0x180BFA2A0
	|-SortedDictionary<object, char>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0xBFA420 Offset: 0xBF9620 VA: 0x180BFA420
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleKey(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF8AB0 Offset: 0xBF7CB0 VA: 0x180BF8AB0
	|-SortedDictionary<object, char>.IsCompatibleKey
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IsCompatibleKey
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFA5E0 Offset: 0xBF97E0 VA: 0x180BFA5E0
	|-SortedDictionary<object, char>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0xBFA550 Offset: 0xBF9750 VA: 0x180BFA550
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private void System.Collections.IDictionary.Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFA790 Offset: 0xBF9990 VA: 0x180BFA790
	|-SortedDictionary<object, char>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0xBFA670 Offset: 0xBF9870 VA: 0x180BFA670
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-SortedDictionary<object, char>.System.Collections.ICollection.get_IsSynchronized
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF9AF0 Offset: 0xBF8CF0 VA: 0x180BF9AF0
	|-SortedDictionary<object, char>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xBF9AA0 Offset: 0xBF8CA0 VA: 0x180BF9AA0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF98A0 Offset: 0xBF8AA0 VA: 0x180BF98A0
	|-SortedDictionary<object, char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBF9930 Offset: 0xBF8B30 VA: 0x180BF9930
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: System.Collections.Generic
[Serializable]
internal sealed class TreeSet<T> : SortedSet<T> // TypeDefIndex: 5557
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCBF7F0 Offset: 0xCBE9F0 VA: 0x180CBF7F0
	|-TreeSet<KeyValuePair<object, char>>..ctor
	|
	|-RVA: 0xB7B430 Offset: 0xB7A630 VA: 0x180B7B430
	|-TreeSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCBF840 Offset: 0xCBEA40 VA: 0x180CBF840
	|-TreeSet<KeyValuePair<object, char>>..ctor
	|
	|-RVA: 0xCBF890 Offset: 0xCBEA90 VA: 0x180CBF890
	|-TreeSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(SerializationInfo siInfo, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCBF810 Offset: 0xCBEA10 VA: 0x180CBF810
	|-TreeSet<KeyValuePair<object, char>>..ctor
	|
	|-RVA: 0xCBF860 Offset: 0xCBEA60 VA: 0x180CBF860
	|-TreeSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 35
	internal override bool AddIfNotPresent(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCBF710 Offset: 0xCBE910 VA: 0x180CBF710
	|-TreeSet<KeyValuePair<object, char>>.AddIfNotPresent
	|
	|-RVA: 0xCBF580 Offset: 0xCBE780 VA: 0x180CBF580
	|-TreeSet<__Il2CppFullySharedGenericType>.AddIfNotPresent
	*/
}

// Namespace: 
[Serializable]
private struct SortedList.Enumerator<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator // TypeDefIndex: 5558
{
	// Fields
	private SortedList<TKey, TValue> _sortedList; // 0x0
	private TKey _key; // 0x0
	private TValue _value; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private int _getEnumeratorRetType; // 0x0
	internal const int KeyValuePair = 1;
	internal const int DictEntry = 2;

	// Properties
	private object System.Collections.IDictionaryEnumerator.Key { get; }
	private DictionaryEntry System.Collections.IDictionaryEnumerator.Entry { get; }
	public KeyValuePair<TKey, TValue> Current { get; }
	private object System.Collections.IEnumerator.Current { get; }
	private object System.Collections.IDictionaryEnumerator.Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedList<TKey, TValue> sortedList, int getEnumeratorRetType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112CDA0 Offset: 0x112BFA0 VA: 0x18112CDA0
	|-SortedList.Enumerator<object, object>..ctor
	|
	|-RVA: 0x113DA00 Offset: 0x113CC00 VA: 0x18113DA00
	|-SortedList.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1126F50 Offset: 0x1126150 VA: 0x181126F50
	|-SortedList.Enumerator<object, object>.Dispose
	|
	|-RVA: 0x112E910 Offset: 0x112DB10 VA: 0x18112E910
	|-SortedList.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IDictionaryEnumerator.get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1129AC0 Offset: 0x1128CC0 VA: 0x181129AC0
	|-SortedList.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x11362E0 Offset: 0x11354E0 VA: 0x1811362E0
	|-SortedList.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionaryEnumerator.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1127EE0 Offset: 0x11270E0 VA: 0x181127EE0
	|-SortedList.Enumerator<object, object>.MoveNext
	|
	|-RVA: 0x112F0B0 Offset: 0x112E2B0 VA: 0x18112F0B0
	|-SortedList.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11290E0 Offset: 0x11282E0 VA: 0x1811290E0
	|-SortedList.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x11352E0 Offset: 0x11344E0 VA: 0x1811352E0
	|-SortedList.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionaryEnumerator.get_Entry
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public KeyValuePair<TKey, TValue> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112D850 Offset: 0x112CA50 VA: 0x18112D850
	|-SortedList.Enumerator<object, object>.get_Current
	|
	|-RVA: 0x113EE90 Offset: 0x113E090 VA: 0x18113EE90
	|-SortedList.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112BFF0 Offset: 0x112B1F0 VA: 0x18112BFF0
	|-SortedList.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x113A5A0 Offset: 0x11397A0 VA: 0x18113A5A0
	|-SortedList.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private object System.Collections.IDictionaryEnumerator.get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1129C00 Offset: 0x1128E00 VA: 0x181129C00
	|-SortedList.Enumerator<object, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x1136FF0 Offset: 0x11361F0 VA: 0x181136FF0
	|-SortedList.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionaryEnumerator.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112A030 Offset: 0x1129230 VA: 0x18112A030
	|-SortedList.Enumerator<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11379A0 Offset: 0x1136BA0 VA: 0x1811379A0
	|-SortedList.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: 
[Serializable]
private sealed class SortedList.SortedListKeyEnumerator<TKey, TValue> : IEnumerator<TKey>, IDisposable, IEnumerator // TypeDefIndex: 5559
{
	// Fields
	private SortedList<TKey, TValue> _sortedList; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private TKey _currentKey; // 0x0

	// Properties
	public TKey Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedList<TKey, TValue> sortedList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFE4E0 Offset: 0xBFD6E0 VA: 0x180BFE4E0
	|-SortedList.SortedListKeyEnumerator<object, object>..ctor
	|
	|-RVA: 0xBFE520 Offset: 0xBFD720 VA: 0x180BFE520
	|-SortedList.SortedListKeyEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFDD10 Offset: 0xBFCF10 VA: 0x180BFDD10
	|-SortedList.SortedListKeyEnumerator<object, object>.Dispose
	|
	|-RVA: 0xBFDC60 Offset: 0xBFCE60 VA: 0x180BFDC60
	|-SortedList.SortedListKeyEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFE040 Offset: 0xBFD240 VA: 0x180BFE040
	|-SortedList.SortedListKeyEnumerator<object, object>.MoveNext
	|
	|-RVA: 0xBFDD20 Offset: 0xBFCF20 VA: 0x180BFDD20
	|-SortedList.SortedListKeyEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TKey get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	|-SortedList.SortedListKeyEnumerator<object, object>.get_Current
	|
	|-RVA: 0xBFE5D0 Offset: 0xBFD7D0 VA: 0x180BFE5D0
	|-SortedList.SortedListKeyEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFE460 Offset: 0xBFD660 VA: 0x180BFE460
	|-SortedList.SortedListKeyEnumerator<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xBFE2C0 Offset: 0xBFD4C0 VA: 0x180BFE2C0
	|-SortedList.SortedListKeyEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFE100 Offset: 0xBFD300 VA: 0x180BFE100
	|-SortedList.SortedListKeyEnumerator<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0xBFE180 Offset: 0xBFD380 VA: 0x180BFE180
	|-SortedList.SortedListKeyEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: 
[Serializable]
private sealed class SortedList.SortedListValueEnumerator<TKey, TValue> : IEnumerator<TValue>, IDisposable, IEnumerator // TypeDefIndex: 5560
{
	// Fields
	private SortedList<TKey, TValue> _sortedList; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private TValue _currentValue; // 0x0

	// Properties
	public TValue Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedList<TKey, TValue> sortedList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFE4E0 Offset: 0xBFD6E0 VA: 0x180BFE4E0
	|-SortedList.SortedListValueEnumerator<object, object>..ctor
	|
	|-RVA: 0xBFE520 Offset: 0xBFD720 VA: 0x180BFE520
	|-SortedList.SortedListValueEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFDD10 Offset: 0xBFCF10 VA: 0x180BFDD10
	|-SortedList.SortedListValueEnumerator<object, object>.Dispose
	|
	|-RVA: 0xBFDC60 Offset: 0xBFCE60 VA: 0x180BFDC60
	|-SortedList.SortedListValueEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFE680 Offset: 0xBFD880 VA: 0x180BFE680
	|-SortedList.SortedListValueEnumerator<object, object>.MoveNext
	|
	|-RVA: 0xBFE740 Offset: 0xBFD940 VA: 0x180BFE740
	|-SortedList.SortedListValueEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	|-SortedList.SortedListValueEnumerator<object, object>.get_Current
	|
	|-RVA: 0xBFE5D0 Offset: 0xBFD7D0 VA: 0x180BFE5D0
	|-SortedList.SortedListValueEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFE460 Offset: 0xBFD660 VA: 0x180BFE460
	|-SortedList.SortedListValueEnumerator<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xBFE2C0 Offset: 0xBFD4C0 VA: 0x180BFE2C0
	|-SortedList.SortedListValueEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFE100 Offset: 0xBFD300 VA: 0x180BFE100
	|-SortedList.SortedListValueEnumerator<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0xBFE180 Offset: 0xBFD380 VA: 0x180BFE180
	|-SortedList.SortedListValueEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: 
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView<TKey, TValue>))]
[DefaultMember("Item")]
[Serializable]
private sealed class SortedList.KeyList<TKey, TValue> : IList<TKey>, ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection // TypeDefIndex: 5561
{
	// Fields
	private SortedList<TKey, TValue> _dict; // 0x0

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public TKey Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedList<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	|-SortedList.KeyList<object, object>..ctor
	|-SortedList.KeyList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13CB0 Offset: 0xD12EB0 VA: 0x180D13CB0
	|-SortedList.KeyList<object, object>.get_Count
	|-SortedList.KeyList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-SortedList.KeyList<object, object>.get_IsReadOnly
	|-SortedList.KeyList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-SortedList.KeyList<object, object>.System.Collections.ICollection.get_IsSynchronized
	|-SortedList.KeyList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1311020 Offset: 0x1310220 VA: 0x181311020
	|-SortedList.KeyList<object, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1311070 Offset: 0x1310270 VA: 0x181311070
	|-SortedList.KeyList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13450 Offset: 0xD12650 VA: 0x180D13450
	|-SortedList.KeyList<object, object>.Add
	|-SortedList.KeyList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD134A0 Offset: 0xD126A0 VA: 0x180D134A0
	|-SortedList.KeyList<object, object>.Clear
	|-SortedList.KeyList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1310A00 Offset: 0x130FC00 VA: 0x181310A00
	|-SortedList.KeyList<object, object>.Contains
	|
	|-RVA: 0xD134F0 Offset: 0xD126F0 VA: 0x180D134F0
	|-SortedList.KeyList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(TKey[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1310AB0 Offset: 0x130FCB0 VA: 0x181310AB0
	|-SortedList.KeyList<object, object>.CopyTo
	|
	|-RVA: 0x1310A30 Offset: 0x130FC30 VA: 0x181310A30
	|-SortedList.KeyList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1310EF0 Offset: 0x13100F0 VA: 0x181310EF0
	|-SortedList.KeyList<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1310DA0 Offset: 0x130FFA0 VA: 0x181310DA0
	|-SortedList.KeyList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, TKey value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13940 Offset: 0xD12B40 VA: 0x180D13940
	|-SortedList.KeyList<object, object>.Insert
	|-SortedList.KeyList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TKey get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13110C0 Offset: 0x13102C0 VA: 0x1813110C0
	|-SortedList.KeyList<object, object>.get_Item
	|
	|-RVA: 0xD13CD0 Offset: 0xD12ED0 VA: 0x180D13CD0
	|-SortedList.KeyList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, TKey value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13110F0 Offset: 0x13102F0 VA: 0x1813110F0
	|-SortedList.KeyList<object, object>.set_Item
	|-SortedList.KeyList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<TKey> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13740 Offset: 0xD12940 VA: 0x180D13740
	|-SortedList.KeyList<object, object>.GetEnumerator
	|
	|-RVA: 0xD136D0 Offset: 0xD128D0 VA: 0x180D136D0
	|-SortedList.KeyList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13740 Offset: 0xD12940 VA: 0x180D13740
	|-SortedList.KeyList<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xD136D0 Offset: 0xD128D0 VA: 0x180D136D0
	|-SortedList.KeyList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1310AF0 Offset: 0x130FCF0 VA: 0x181310AF0
	|-SortedList.KeyList<object, object>.IndexOf
	|
	|-RVA: 0x1310BA0 Offset: 0x130FDA0 VA: 0x181310BA0
	|-SortedList.KeyList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13450 Offset: 0xD12650 VA: 0x180D13450
	|-SortedList.KeyList<object, object>.Remove
	|-SortedList.KeyList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13450 Offset: 0xD12650 VA: 0x180D13450
	|-SortedList.KeyList<object, object>.RemoveAt
	|-SortedList.KeyList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveAt
	*/
}

// Namespace: 
[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView<TKey, TValue>))]
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
private sealed class SortedList.ValueList<TKey, TValue> : IList<TValue>, ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection // TypeDefIndex: 5562
{
	// Fields
	private SortedList<TKey, TValue> _dict; // 0x0

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public TValue Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedList<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	|-SortedList.ValueList<object, object>..ctor
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13CB0 Offset: 0xD12EB0 VA: 0x180D13CB0
	|-SortedList.ValueList<object, object>.get_Count
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-SortedList.ValueList<object, object>.get_IsReadOnly
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-SortedList.ValueList<object, object>.System.Collections.ICollection.get_IsSynchronized
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13C10 Offset: 0xD12E10 VA: 0x180D13C10
	|-SortedList.ValueList<object, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xD13C60 Offset: 0xD12E60 VA: 0x180D13C60
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(TValue key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13450 Offset: 0xD12650 VA: 0x180D13450
	|-SortedList.ValueList<object, object>.Add
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD134A0 Offset: 0xD126A0 VA: 0x180D134A0
	|-SortedList.ValueList<object, object>.Clear
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD135E0 Offset: 0xD127E0 VA: 0x180D135E0
	|-SortedList.ValueList<object, object>.Contains
	|
	|-RVA: 0xD134F0 Offset: 0xD126F0 VA: 0x180D134F0
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(TValue[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13610 Offset: 0xD12810 VA: 0x180D13610
	|-SortedList.ValueList<object, object>.CopyTo
	|
	|-RVA: 0xD13650 Offset: 0xD12850 VA: 0x180D13650
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13990 Offset: 0xD12B90 VA: 0x180D13990
	|-SortedList.ValueList<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xD13AC0 Offset: 0xD12CC0 VA: 0x180D13AC0
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13940 Offset: 0xD12B40 VA: 0x180D13940
	|-SortedList.ValueList<object, object>.Insert
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13DA0 Offset: 0xD12FA0 VA: 0x180D13DA0
	|-SortedList.ValueList<object, object>.get_Item
	|
	|-RVA: 0xD13CD0 Offset: 0xD12ED0 VA: 0x180D13CD0
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13940 Offset: 0xD12B40 VA: 0x180D13940
	|-SortedList.ValueList<object, object>.set_Item
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13740 Offset: 0xD12940 VA: 0x180D13740
	|-SortedList.ValueList<object, object>.GetEnumerator
	|
	|-RVA: 0xD136D0 Offset: 0xD128D0 VA: 0x180D136D0
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13740 Offset: 0xD12940 VA: 0x180D13740
	|-SortedList.ValueList<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xD136D0 Offset: 0xD128D0 VA: 0x180D136D0
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD137B0 Offset: 0xD129B0 VA: 0x180D137B0
	|-SortedList.ValueList<object, object>.IndexOf
	|
	|-RVA: 0xD137F0 Offset: 0xD129F0 VA: 0x180D137F0
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13450 Offset: 0xD12650 VA: 0x180D13450
	|-SortedList.ValueList<object, object>.Remove
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD13450 Offset: 0xD12650 VA: 0x180D13450
	|-SortedList.ValueList<object, object>.RemoveAt
	|-SortedList.ValueList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveAt
	*/
}

// Namespace: System.Collections.Generic
[DebuggerDisplay("Count = {Count}")]
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView<K, V>))]
[Serializable]
public class SortedList<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>> // TypeDefIndex: 5563
{
	// Fields
	private TKey[] keys; // 0x0
	private TValue[] values; // 0x0
	private int _size; // 0x0
	private int version; // 0x0
	private IComparer<TKey> comparer; // 0x0
	private SortedList.KeyList<TKey, TValue> keyList; // 0x0
	private SortedList.ValueList<TKey, TValue> valueList; // 0x0
	private object _syncRoot; // 0x0
	private const int DefaultCapacity = 4;
	private const int MaxArrayLength = 2146435071;

	// Properties
	public int Capacity { get; set; }
	public IComparer<TKey> Comparer { get; }
	public int Count { get; }
	public IList<TKey> Keys { get; }
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get; }
	public IList<TValue> Values { get; }
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public TValue Item { get; set; }
	private object System.Collections.IDictionary.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC00C70 Offset: 0xBFFE70 VA: 0x180C00C70
	|-SortedList<object, object>..ctor
	|
	|-RVA: 0xC1B9C0 Offset: 0xC1ABC0 VA: 0x180C1B9C0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC00DC0 Offset: 0xBFFFC0 VA: 0x180C00DC0
	|-SortedList<object, object>..ctor
	|
	|-RVA: 0xC1BAA0 Offset: 0xC1ACA0 VA: 0x180C1BAA0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC00EF0 Offset: 0xC000F0 VA: 0x180C00EF0
	|-SortedList<object, object>..ctor
	|
	|-RVA: 0xC1B4D0 Offset: 0xC1A6D0 VA: 0x180C1B4D0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC00CE0 Offset: 0xBFFEE0 VA: 0x180C00CE0
	|-SortedList<object, object>..ctor
	|
	|-RVA: 0xC1BA40 Offset: 0xC1AC40 VA: 0x180C1BA40
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC00C50 Offset: 0xBFFE50 VA: 0x180C00C50
	|-SortedList<object, object>..ctor
	|
	|-RVA: 0xC1B9A0 Offset: 0xC1ABA0 VA: 0x180C1B9A0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> dictionary, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC00F90 Offset: 0xC00190 VA: 0x180C00F90
	|-SortedList<object, object>..ctor
	|
	|-RVA: 0xC1B510 Offset: 0xC1A710 VA: 0x180C1B510
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFEA60 Offset: 0xBFDC60 VA: 0x180BFEA60
	|-SortedList<object, object>.Add
	|
	|-RVA: 0xC17DC0 Offset: 0xC16FC0 VA: 0x180C17DC0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFF5A0 Offset: 0xBFE7A0 VA: 0x180BFF5A0
	|-SortedList<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0xC19280 Offset: 0xC18480 VA: 0x180C19280
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFF5C0 Offset: 0xBFE7C0 VA: 0x180BFF5C0
	|-SortedList<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0xC19400 Offset: 0xC18600 VA: 0x180C19400
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFF900 Offset: 0xBFEB00 VA: 0x180BFF900
	|-SortedList<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0xC19A90 Offset: 0xC18C90 VA: 0x180C19A90
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB77F20 Offset: 0xB77120 VA: 0x180B77F20
	|-SortedList<object, object>.get_Capacity
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC01520 Offset: 0xC00720 VA: 0x180C01520
	|-SortedList<object, object>.set_Capacity
	|
	|-RVA: 0xC1BE60 Offset: 0xC1B060 VA: 0x180C1BE60
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Capacity
	*/

	// RVA: -1 Offset: -1
	public IComparer<TKey> get_Comparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	|-SortedList<object, object>.get_Comparer
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Comparer
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC00010 Offset: 0xBFF210 VA: 0x180C00010
	|-SortedList<object, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0xC1A620 Offset: 0xC19820 VA: 0x180C1A620
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 41
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	|-SortedList<object, object>.get_Count
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public IList<TKey> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFFA60 Offset: 0xBFEC60 VA: 0x180BFFA60
	|-SortedList<object, object>.get_Keys
	|
	|-RVA: 0xC19D10 Offset: 0xC18F10 VA: 0x180C19D10
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFFA60 Offset: 0xBFEC60 VA: 0x180BFFA60
	|-SortedList<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0xC19D10 Offset: 0xC18F10 VA: 0x180C19D10
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFFA60 Offset: 0xBFEC60 VA: 0x180BFFA60
	|-SortedList<object, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0xC19D10 Offset: 0xC18F10 VA: 0x180C19D10
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 39
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFFA60 Offset: 0xBFEC60 VA: 0x180BFFA60
	|-SortedList<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0xC19D10 Offset: 0xC18F10 VA: 0x180C19D10
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1
	public IList<TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFFA80 Offset: 0xBFEC80 VA: 0x180BFFA80
	|-SortedList<object, object>.get_Values
	|
	|-RVA: 0xC19D30 Offset: 0xC18F30 VA: 0x180C19D30
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFFA80 Offset: 0xBFEC80 VA: 0x180BFFA80
	|-SortedList<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0xC19D30 Offset: 0xC18F30 VA: 0x180C19D30
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFFA80 Offset: 0xBFEC80 VA: 0x180BFFA80
	|-SortedList<object, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0xC19D30 Offset: 0xC18F30 VA: 0x180C19D30
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 40
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFFA80 Offset: 0xBFEC80 VA: 0x180BFFA80
	|-SortedList<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0xC19D30 Offset: 0xC18F30 VA: 0x180C19D30
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1
	private SortedList.KeyList<TKey, TValue> GetKeyListHelper() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFEEB0 Offset: 0xBFE0B0 VA: 0x180BFEEB0
	|-SortedList<object, object>.GetKeyListHelper
	|
	|-RVA: 0xC18680 Offset: 0xC17880 VA: 0x180C18680
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetKeyListHelper
	*/

	// RVA: -1 Offset: -1
	private SortedList.ValueList<TKey, TValue> GetValueListHelper() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFF020 Offset: 0xBFE220 VA: 0x180BFF020
	|-SortedList<object, object>.GetValueListHelper
	|
	|-RVA: 0xC18860 Offset: 0xC17A60 VA: 0x180C18860
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetValueListHelper
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-SortedList<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private bool System.Collections.IDictionary.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-SortedList<object, object>.System.Collections.IDictionary.get_IsReadOnly
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private bool System.Collections.IDictionary.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-SortedList<object, object>.System.Collections.IDictionary.get_IsFixedSize
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-SortedList<object, object>.System.Collections.ICollection.get_IsSynchronized
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFFFA0 Offset: 0xBFF1A0 VA: 0x180BFFFA0
	|-SortedList<object, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xC1A5B0 Offset: 0xC197B0 VA: 0x180C1A5B0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFEBA0 Offset: 0xBFDDA0 VA: 0x180BFEBA0
	|-SortedList<object, object>.Clear
	|
	|-RVA: 0xC181B0 Offset: 0xC173B0 VA: 0x180C181B0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC002F0 Offset: 0xBFF4F0 VA: 0x180C002F0
	|-SortedList<object, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0xC1AA50 Offset: 0xC19C50 VA: 0x180C1AA50
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFEBE0 Offset: 0xBFDDE0 VA: 0x180BFEBE0
	|-SortedList<object, object>.ContainsKey
	|
	|-RVA: 0xC18230 Offset: 0xC17430 VA: 0x180C18230
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public bool ContainsValue(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFEC90 Offset: 0xBFDE90 VA: 0x180BFEC90
	|-SortedList<object, object>.ContainsValue
	|
	|-RVA: 0xC18320 Offset: 0xC17520 VA: 0x180C18320
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsValue
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFF700 Offset: 0xBFE900 VA: 0x180BFF700
	|-SortedList<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0xC19660 Offset: 0xC18860 VA: 0x180C19660
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFFAA0 Offset: 0xBFECA0 VA: 0x180BFFAA0
	|-SortedList<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xC19D50 Offset: 0xC18F50 VA: 0x180C19D50
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	private void EnsureCapacity(int min) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFECE0 Offset: 0xBFDEE0 VA: 0x180BFECE0
	|-SortedList<object, object>.EnsureCapacity
	|
	|-RVA: 0xC18410 Offset: 0xC17610 VA: 0x180C18410
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.EnsureCapacity
	*/

	// RVA: -1 Offset: -1
	private TValue GetByIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFED40 Offset: 0xBFDF40 VA: 0x180BFED40
	|-SortedList<object, object>.GetByIndex
	|
	|-RVA: 0xC18470 Offset: 0xC17670 VA: 0x180C18470
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetByIndex
	*/

	// RVA: -1 Offset: -1
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFEE20 Offset: 0xBFE020 VA: 0x180BFEE20
	|-SortedList<object, object>.GetEnumerator
	|
	|-RVA: 0xC185C0 Offset: 0xC177C0 VA: 0x180C185C0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFEE20 Offset: 0xBFE020 VA: 0x180BFEE20
	|-SortedList<object, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0xC185C0 Offset: 0xC177C0 VA: 0x180C185C0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC00470 Offset: 0xBFF670 VA: 0x180C00470
	|-SortedList<object, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0xC1AB80 Offset: 0xC19D80 VA: 0x180C1AB80
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFEE20 Offset: 0xBFE020 VA: 0x180BFEE20
	|-SortedList<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xC185C0 Offset: 0xC177C0 VA: 0x180C185C0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private TKey GetKey(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFEF40 Offset: 0xBFE140 VA: 0x180BFEF40
	|-SortedList<object, object>.GetKey
	|
	|-RVA: 0xC18710 Offset: 0xC17910 VA: 0x180C18710
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetKey
	*/

	// RVA: -1 Offset: -1 Slot: 38
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC013D0 Offset: 0xC005D0 VA: 0x180C013D0
	|-SortedList<object, object>.get_Item
	|
	|-RVA: 0xC1BBD0 Offset: 0xC1ADD0 VA: 0x180C1BBD0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC016D0 Offset: 0xC008D0 VA: 0x180C016D0
	|-SortedList<object, object>.set_Item
	|
	|-RVA: 0xC1C010 Offset: 0xC1B210 VA: 0x180C1C010
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC00690 Offset: 0xBFF890 VA: 0x180C00690
	|-SortedList<object, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0xC1AD60 Offset: 0xC19F60 VA: 0x180C1AD60
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC00810 Offset: 0xBFFA10 VA: 0x180C00810
	|-SortedList<object, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0xC1AF20 Offset: 0xC1A120 VA: 0x180C1AF20
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1
	public int IndexOfKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFF0B0 Offset: 0xBFE2B0 VA: 0x180BFF0B0
	|-SortedList<object, object>.IndexOfKey
	|
	|-RVA: 0xC188F0 Offset: 0xC17AF0 VA: 0x180C188F0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IndexOfKey
	*/

	// RVA: -1 Offset: -1
	public int IndexOfValue(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFF150 Offset: 0xBFE350 VA: 0x180BFF150
	|-SortedList<object, object>.IndexOfValue
	|
	|-RVA: 0xC18AC0 Offset: 0xC17CC0 VA: 0x180C18AC0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IndexOfValue
	*/

	// RVA: -1 Offset: -1
	private void Insert(int index, TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFF180 Offset: 0xBFE380 VA: 0x180BFF180
	|-SortedList<object, object>.Insert
	|
	|-RVA: 0xC18BE0 Offset: 0xC17DE0 VA: 0x180C18BE0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC00B60 Offset: 0xBFFD60 VA: 0x180C00B60
	|-SortedList<object, object>.TryGetValue
	|
	|-RVA: 0xC1B320 Offset: 0xC1A520 VA: 0x180C1B320
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFF360 Offset: 0xBFE560 VA: 0x180BFF360
	|-SortedList<object, object>.RemoveAt
	|
	|-RVA: 0xC18E30 Offset: 0xC18030 VA: 0x180C18E30
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFF4B0 Offset: 0xBFE6B0 VA: 0x180BFF4B0
	|-SortedList<object, object>.Remove
	|
	|-RVA: 0xC19160 Offset: 0xC18360 VA: 0x180C19160
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private void System.Collections.IDictionary.Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC00500 Offset: 0xBFF700 VA: 0x180C00500
	|-SortedList<object, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0xC1AC40 Offset: 0xC19E40 VA: 0x180C1AC40
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Remove
	*/

	// RVA: -1 Offset: -1
	public void TrimExcess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC00B10 Offset: 0xBFFD10 VA: 0x180C00B10
	|-SortedList<object, object>.TrimExcess
	|
	|-RVA: 0xC1B2C0 Offset: 0xC1A4C0 VA: 0x180C1B2C0
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TrimExcess
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleKey(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBFF2B0 Offset: 0xBFE4B0 VA: 0x180BFF2B0
	|-SortedList<object, object>.IsCompatibleKey
	|-SortedList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IsCompatibleKey
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class SortedSet.TreeSubSet.<>c__DisplayClass9_0<T> // TypeDefIndex: 5564
{
	// Fields
	public List<T> toRemove; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-SortedSet.TreeSubSet.<>c__DisplayClass9_0<KeyValuePair<object, char>>..ctor
	|-SortedSet.TreeSubSet.<>c__DisplayClass9_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <Clear>b__0(SortedSet.Node<T> n) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB142C0 Offset: 0xB134C0 VA: 0x180B142C0
	|-SortedSet.TreeSubSet.<>c__DisplayClass9_0<KeyValuePair<object, char>>.<Clear>b__0
	|
	|-RVA: 0xB141D0 Offset: 0xB133D0 VA: 0x180B141D0
	|-SortedSet.TreeSubSet.<>c__DisplayClass9_0<__Il2CppFullySharedGenericType>.<Clear>b__0
	*/
}

// Namespace: 
[Serializable]
internal sealed class SortedSet.TreeSubSet<T> : SortedSet<T>, ISerializable, IDeserializationCallback // TypeDefIndex: 5565
{
	// Fields
	private SortedSet<T> _underlying; // 0x0
	private T _min; // 0x0
	private T _max; // 0x0
	private bool _lBoundActive; // 0x0
	private bool _uBoundActive; // 0x0

	// Properties
	internal override T MinInternal { get; }
	internal override T MaxInternal { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SortedSet<T> Underlying, T Min, T Max, bool lowerBoundActive, bool upperBoundActive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC3290 Offset: 0xCC2490 VA: 0x180CC3290
	|-SortedSet.TreeSubSet<KeyValuePair<object, char>>..ctor
	|
	|-RVA: 0xCC3390 Offset: 0xCC2590 VA: 0x180CC3390
	|-SortedSet.TreeSubSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 35
	internal override bool AddIfNotPresent(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCBFAA0 Offset: 0xCBECA0 VA: 0x180CBFAA0
	|-SortedSet.TreeSubSet<KeyValuePair<object, char>>.AddIfNotPresent
	|
	|-RVA: 0xCBF8B0 Offset: 0xCBEAB0 VA: 0x180CBF8B0
	|-SortedSet.TreeSubSet<__Il2CppFullySharedGenericType>.AddIfNotPresent
	*/

	// RVA: -1 Offset: -1 Slot: 38
	public override bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC0A40 Offset: 0xCBFC40 VA: 0x180CC0A40
	|-SortedSet.TreeSubSet<KeyValuePair<object, char>>.Contains
	|
	|-RVA: 0xCC0AB0 Offset: 0xCBFCB0 VA: 0x180CC0AB0
	|-SortedSet.TreeSubSet<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 36
	internal override bool DoRemove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC0BB0 Offset: 0xCBFDB0 VA: 0x180CC0BB0
	|-SortedSet.TreeSubSet<KeyValuePair<object, char>>.DoRemove
	|
	|-RVA: 0xCC0C70 Offset: 0xCBFE70 VA: 0x180CC0C70
	|-SortedSet.TreeSubSet<__Il2CppFullySharedGenericType>.DoRemove
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public override void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC04B0 Offset: 0xCBF6B0 VA: 0x180CC04B0
	|-SortedSet.TreeSubSet<KeyValuePair<object, char>>.Clear
	|
	|-RVA: 0xCC0710 Offset: 0xCBF910 VA: 0x180CC0710
	|-SortedSet.TreeSubSet<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 34
	internal override bool IsWithinRange(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC2BD0 Offset: 0xCC1DD0 VA: 0x180CC2BD0
	|-SortedSet.TreeSubSet<KeyValuePair<object, char>>.IsWithinRange
	|
	|-RVA: 0xCC28C0 Offset: 0xCC1AC0 VA: 0x180CC28C0
	|-SortedSet.TreeSubSet<__Il2CppFullySharedGenericType>.IsWithinRange
	*/

	// RVA: -1 Offset: -1 Slot: 43
	internal override T get_MinInternal() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC3EA0 Offset: 0xCC30A0 VA: 0x180CC3EA0
	|-SortedSet.TreeSubSet<KeyValuePair<object, char>>.get_MinInternal
	|
	|-RVA: 0xCC3BD0 Offset: 0xCC2DD0 VA: 0x180CC3BD0
	|-SortedSet.TreeSubSet<__Il2CppFullySharedGenericType>.get_MinInternal
	*/

	// RVA: -1 Offset: -1 Slot: 44
	internal override T get_MaxInternal() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC3A70 Offset: 0xCC2C70 VA: 0x180CC3A70
	|-SortedSet.TreeSubSet<KeyValuePair<object, char>>.get_MaxInternal
	|
	|-RVA: 0xCC37B0 Offset: 0xCC29B0 VA: 0x180CC37B0
	|-SortedSet.TreeSubSet<__Il2CppFullySharedGenericType>.get_MaxInternal
	*/

	// RVA: -1 Offset: -1 Slot: 31
	internal override bool InOrderTreeWalk(TreeWalkPredicate<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC1850 Offset: 0xCC0A50 VA: 0x180CC1850
	|-SortedSet.TreeSubSet<KeyValuePair<object, char>>.InOrderTreeWalk
	|
	|-RVA: 0xCC1C10 Offset: 0xCC0E10 VA: 0x180CC1C10
	|-SortedSet.TreeSubSet<__Il2CppFullySharedGenericType>.InOrderTreeWalk
	*/

	// RVA: -1 Offset: -1 Slot: 32
	internal override bool BreadthFirstTreeWalk(TreeWalkPredicate<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC0140 Offset: 0xCBF340 VA: 0x180CC0140
	|-SortedSet.TreeSubSet<KeyValuePair<object, char>>.BreadthFirstTreeWalk
	|
	|-RVA: 0xCBFB80 Offset: 0xCBED80 VA: 0x180CBFB80
	|-SortedSet.TreeSubSet<__Il2CppFullySharedGenericType>.BreadthFirstTreeWalk
	*/

	// RVA: -1 Offset: -1 Slot: 39
	internal override SortedSet.Node<T> FindNode(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC0E30 Offset: 0xCC0030 VA: 0x180CC0E30
	|-SortedSet.TreeSubSet<KeyValuePair<object, char>>.FindNode
	|
	|-RVA: 0xCC0EE0 Offset: 0xCC00E0 VA: 0x180CC0EE0
	|-SortedSet.TreeSubSet<__Il2CppFullySharedGenericType>.FindNode
	*/

	// RVA: -1 Offset: -1 Slot: 40
	internal override int InternalIndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC2260 Offset: 0xCC1460 VA: 0x180CC2260
	|-SortedSet.TreeSubSet<KeyValuePair<object, char>>.InternalIndexOf
	|
	|-RVA: 0xCC2500 Offset: 0xCC1700 VA: 0x180CC2500
	|-SortedSet.TreeSubSet<__Il2CppFullySharedGenericType>.InternalIndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 33
	internal override void VersionCheck() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC3270 Offset: 0xCC2470 VA: 0x180CC3270
	|-SortedSet.TreeSubSet<KeyValuePair<object, char>>.VersionCheck
	|
	|-RVA: 0xBE7FD0 Offset: 0xBE71D0 VA: 0x180BE7FD0
	|-SortedSet.TreeSubSet<__Il2CppFullySharedGenericType>.VersionCheck
	*/

	// RVA: -1 Offset: -1
	private void VersionCheckImpl() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC2E40 Offset: 0xCC2040 VA: 0x180CC2E40
	|-SortedSet.TreeSubSet<KeyValuePair<object, char>>.VersionCheckImpl
	|
	|-RVA: 0xCC2FA0 Offset: 0xCC21A0 VA: 0x180CC2FA0
	|-SortedSet.TreeSubSet<__Il2CppFullySharedGenericType>.VersionCheckImpl
	*/

	// RVA: -1 Offset: -1 Slot: 45
	public override SortedSet<T> GetViewBetween(T lowerValue, T upperValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC10C0 Offset: 0xCC02C0 VA: 0x180CC10C0
	|-SortedSet.TreeSubSet<KeyValuePair<object, char>>.GetViewBetween
	|
	|-RVA: 0xCC13A0 Offset: 0xCC05A0 VA: 0x180CC13A0
	|-SortedSet.TreeSubSet<__Il2CppFullySharedGenericType>.GetViewBetween
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC2DF0 Offset: 0xCC1FF0 VA: 0x180CC2DF0
	|-SortedSet.TreeSubSet<KeyValuePair<object, char>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|-SortedSet.TreeSubSet<__Il2CppFullySharedGenericType>.System.Runtime.Serialization.ISerializable.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 46
	protected override void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC1080 Offset: 0xCC0280 VA: 0x180CC1080
	|-SortedSet.TreeSubSet<KeyValuePair<object, char>>.GetObjectData
	|-SortedSet.TreeSubSet<__Il2CppFullySharedGenericType>.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC2DB0 Offset: 0xCC1FB0 VA: 0x180CC2DB0
	|-SortedSet.TreeSubSet<KeyValuePair<object, char>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|-SortedSet.TreeSubSet<__Il2CppFullySharedGenericType>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	*/

	// RVA: -1 Offset: -1 Slot: 47
	protected override void OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC2DB0 Offset: 0xCC1FB0 VA: 0x180CC2DB0
	|-SortedSet.TreeSubSet<KeyValuePair<object, char>>.OnDeserialization
	|-SortedSet.TreeSubSet<__Il2CppFullySharedGenericType>.OnDeserialization
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private bool <VersionCheckImpl>b__20_0(SortedSet.Node<T> n) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC2E30 Offset: 0xCC2030 VA: 0x180CC2E30
	|-SortedSet.TreeSubSet<KeyValuePair<object, char>>.<VersionCheckImpl>b__20_0
	|-SortedSet.TreeSubSet<__Il2CppFullySharedGenericType>.<VersionCheckImpl>b__20_0
	*/
}

// Namespace: 
[Serializable]
internal sealed class SortedSet.Node<T> // TypeDefIndex: 5566
{
	// Fields
	[CompilerGenerated]
	private T <Item>k__BackingField; // 0x0
	[CompilerGenerated]
	private SortedSet.Node<T> <Left>k__BackingField; // 0x0
	[CompilerGenerated]
	private SortedSet.Node<T> <Right>k__BackingField; // 0x0
	[CompilerGenerated]
	private NodeColor <Color>k__BackingField; // 0x0

	// Properties
	public T Item { get; set; }
	public SortedSet.Node<T> Left { get; set; }
	public SortedSet.Node<T> Right { get; set; }
	public NodeColor Color { get; set; }
	public bool IsBlack { get; }
	public bool IsRed { get; }
	public bool Is2Node { get; }
	public bool Is4Node { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T item, NodeColor color) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1489C20 Offset: 0x1488E20 VA: 0x181489C20
	|-SortedSet.Node<KeyValuePair<object, char>>..ctor
	|
	|-RVA: 0x1489B10 Offset: 0x1488D10 VA: 0x181489B10
	|-SortedSet.Node<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public static bool IsNonNullBlack(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1487DF0 Offset: 0x1486FF0 VA: 0x181487DF0
	|-SortedSet.Node<KeyValuePair<object, char>>.IsNonNullBlack
	|
	|-RVA: 0x1487E30 Offset: 0x1487030 VA: 0x181487E30
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.IsNonNullBlack
	*/

	// RVA: -1 Offset: -1
	public static bool IsNonNullRed(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1487EC0 Offset: 0x14870C0 VA: 0x181487EC0
	|-SortedSet.Node<KeyValuePair<object, char>>.IsNonNullRed
	|
	|-RVA: 0x1487F00 Offset: 0x1487100 VA: 0x181487F00
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.IsNonNullRed
	*/

	// RVA: -1 Offset: -1
	public static bool IsNullOrBlack(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1487F90 Offset: 0x1487190 VA: 0x181487F90
	|-SortedSet.Node<KeyValuePair<object, char>>.IsNullOrBlack
	|
	|-RVA: 0x1487FD0 Offset: 0x14871D0 VA: 0x181487FD0
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.IsNullOrBlack
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public T get_Item() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x482990 Offset: 0x481B90 VA: 0x180482990
	|-SortedSet.Node<KeyValuePair<object, char>>.get_Item
	|
	|-RVA: 0x148A020 Offset: 0x1489220 VA: 0x18148A020
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.get_Item
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_Item(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4829A0 Offset: 0x481BA0 VA: 0x1804829A0
	|-SortedSet.Node<KeyValuePair<object, char>>.set_Item
	|
	|-RVA: 0x148A5C0 Offset: 0x14897C0 VA: 0x18148A5C0
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.set_Item
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public SortedSet.Node<T> get_Left() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	|-SortedSet.Node<KeyValuePair<object, char>>.get_Left
	|
	|-RVA: 0x148A270 Offset: 0x1489470 VA: 0x18148A270
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.get_Left
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_Left(SortedSet.Node<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	|-SortedSet.Node<KeyValuePair<object, char>>.set_Left
	|
	|-RVA: 0x148A680 Offset: 0x1489880 VA: 0x18148A680
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.set_Left
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public SortedSet.Node<T> get_Right() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	|-SortedSet.Node<KeyValuePair<object, char>>.get_Right
	|
	|-RVA: 0x148A2A0 Offset: 0x14894A0 VA: 0x18148A2A0
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.get_Right
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_Right(SortedSet.Node<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	|-SortedSet.Node<KeyValuePair<object, char>>.set_Right
	|
	|-RVA: 0x148A6E0 Offset: 0x14898E0 VA: 0x18148A6E0
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.set_Right
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public NodeColor get_Color() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	|-SortedSet.Node<KeyValuePair<object, char>>.get_Color
	|
	|-RVA: 0x1489C60 Offset: 0x1488E60 VA: 0x181489C60
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.get_Color
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_Color(NodeColor value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x40EC60 Offset: 0x40DE60 VA: 0x18040EC60
	|-SortedSet.Node<KeyValuePair<object, char>>.set_Color
	|
	|-RVA: 0x148A560 Offset: 0x1489760 VA: 0x18148A560
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.set_Color
	*/

	// RVA: -1 Offset: -1
	public bool get_IsBlack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1489F80 Offset: 0x1489180 VA: 0x181489F80
	|-SortedSet.Node<KeyValuePair<object, char>>.get_IsBlack
	|
	|-RVA: 0x1489F90 Offset: 0x1489190 VA: 0x181489F90
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.get_IsBlack
	*/

	// RVA: -1 Offset: -1
	public bool get_IsRed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x148A010 Offset: 0x1489210 VA: 0x18148A010
	|-SortedSet.Node<KeyValuePair<object, char>>.get_IsRed
	|
	|-RVA: 0x1489FE0 Offset: 0x14891E0 VA: 0x181489FE0
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.get_IsRed
	*/

	// RVA: -1 Offset: -1
	public bool get_Is2Node() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1489CC0 Offset: 0x1488EC0 VA: 0x181489CC0
	|-SortedSet.Node<KeyValuePair<object, char>>.get_Is2Node
	|
	|-RVA: 0x1489D80 Offset: 0x1488F80 VA: 0x181489D80
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.get_Is2Node
	*/

	// RVA: -1 Offset: -1
	public bool get_Is4Node() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1489E40 Offset: 0x1489040 VA: 0x181489E40
	|-SortedSet.Node<KeyValuePair<object, char>>.get_Is4Node
	|
	|-RVA: 0x1489EE0 Offset: 0x14890E0 VA: 0x181489EE0
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.get_Is4Node
	*/

	// RVA: -1 Offset: -1
	public void ColorBlack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x723A20 Offset: 0x722C20 VA: 0x180723A20
	|-SortedSet.Node<KeyValuePair<object, char>>.ColorBlack
	|
	|-RVA: 0x1483DA0 Offset: 0x1482FA0 VA: 0x181483DA0
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.ColorBlack
	*/

	// RVA: -1 Offset: -1
	public void ColorRed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1483DC0 Offset: 0x1482FC0 VA: 0x181483DC0
	|-SortedSet.Node<KeyValuePair<object, char>>.ColorRed
	|
	|-RVA: 0x1483DD0 Offset: 0x1482FD0 VA: 0x181483DD0
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.ColorRed
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> DeepClone(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1486320 Offset: 0x1485520 VA: 0x181486320
	|-SortedSet.Node<KeyValuePair<object, char>>.DeepClone
	|
	|-RVA: 0x1486630 Offset: 0x1485830 VA: 0x181486630
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.DeepClone
	*/

	// RVA: -1 Offset: -1
	public TreeRotation GetRotation(SortedSet.Node<T> current, SortedSet.Node<T> sibling) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1486E00 Offset: 0x1486000 VA: 0x181486E00
	|-SortedSet.Node<KeyValuePair<object, char>>.GetRotation
	|
	|-RVA: 0x1486E80 Offset: 0x1486080 VA: 0x181486E80
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.GetRotation
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> GetSibling(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1486F20 Offset: 0x1486120 VA: 0x181486F20
	|-SortedSet.Node<KeyValuePair<object, char>>.GetSibling
	|
	|-RVA: 0x1486F30 Offset: 0x1486130 VA: 0x181486F30
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.GetSibling
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> ShallowClone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1488F10 Offset: 0x1488110 VA: 0x181488F10
	|-SortedSet.Node<KeyValuePair<object, char>>.ShallowClone
	|
	|-RVA: 0x1488DC0 Offset: 0x1487FC0 VA: 0x181488DC0
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.ShallowClone
	*/

	// RVA: -1 Offset: -1
	public void Split4Node() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1489030 Offset: 0x1488230 VA: 0x181489030
	|-SortedSet.Node<KeyValuePair<object, char>>.Split4Node
	|
	|-RVA: 0x1488F80 Offset: 0x1488180 VA: 0x181488F80
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.Split4Node
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> Rotate(TreeRotation rotation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1488B70 Offset: 0x1487D70 VA: 0x181488B70
	|-SortedSet.Node<KeyValuePair<object, char>>.Rotate
	|
	|-RVA: 0x1488A00 Offset: 0x1487C00 VA: 0x181488A00
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.Rotate
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> RotateLeft() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1488780 Offset: 0x1487980 VA: 0x181488780
	|-SortedSet.Node<KeyValuePair<object, char>>.RotateLeft
	|
	|-RVA: 0x14886D0 Offset: 0x14878D0 VA: 0x1814886D0
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.RotateLeft
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> RotateLeftRight() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1488560 Offset: 0x1487760 VA: 0x181488560
	|-SortedSet.Node<KeyValuePair<object, char>>.RotateLeftRight
	|
	|-RVA: 0x14885A0 Offset: 0x14877A0 VA: 0x1814885A0
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.RotateLeftRight
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> RotateRight() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1488920 Offset: 0x1487B20 VA: 0x181488920
	|-SortedSet.Node<KeyValuePair<object, char>>.RotateRight
	|
	|-RVA: 0x1488950 Offset: 0x1487B50 VA: 0x181488950
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.RotateRight
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> RotateRightLeft() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14887B0 Offset: 0x14879B0 VA: 0x1814887B0
	|-SortedSet.Node<KeyValuePair<object, char>>.RotateRightLeft
	|
	|-RVA: 0x14887F0 Offset: 0x14879F0 VA: 0x1814887F0
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.RotateRightLeft
	*/

	// RVA: -1 Offset: -1
	public void Merge2Nodes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14884A0 Offset: 0x14876A0 VA: 0x1814884A0
	|-SortedSet.Node<KeyValuePair<object, char>>.Merge2Nodes
	|
	|-RVA: 0x14883F0 Offset: 0x14875F0 VA: 0x1814883F0
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.Merge2Nodes
	*/

	// RVA: -1 Offset: -1
	public void ReplaceChild(SortedSet.Node<T> child, SortedSet.Node<T> newChild) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1488550 Offset: 0x1487750 VA: 0x181488550
	|-SortedSet.Node<KeyValuePair<object, char>>.ReplaceChild
	|
	|-RVA: 0x14884D0 Offset: 0x14876D0 VA: 0x1814884D0
	|-SortedSet.Node<__Il2CppFullySharedGenericType>.ReplaceChild
	*/
}

// Namespace: 
[Serializable]
public struct SortedSet.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback // TypeDefIndex: 5567
{
	// Fields
	private static readonly SortedSet.Node<T> s_dummyNode; // 0x0
	private SortedSet<T> _tree; // 0x0
	private int _version; // 0x0
	private Stack<SortedSet.Node<T>> _stack; // 0x0
	private SortedSet.Node<T> _current; // 0x0
	private bool _reverse; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }
	internal bool NotStartedOrEnded { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedSet<T> set) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EB940 Offset: 0x10EAB40 VA: 0x1810EB940
	|-SortedSet.Enumerator<KeyValuePair<object, char>>..ctor
	|
	|-RVA: 0x1110250 Offset: 0x110F450 VA: 0x181110250
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(SortedSet<T> set, bool reverse) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EB790 Offset: 0x10EA990 VA: 0x1810EB790
	|-SortedSet.Enumerator<KeyValuePair<object, char>>..ctor
	|
	|-RVA: 0x11112F0 Offset: 0x11104F0 VA: 0x1811112F0
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC1080 Offset: 0xCC0280 VA: 0x180CC1080
	|-SortedSet.Enumerator<KeyValuePair<object, char>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>.System.Runtime.Serialization.ISerializable.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCC2DB0 Offset: 0xCC1FB0 VA: 0x180CC2DB0
	|-SortedSet.Enumerator<KeyValuePair<object, char>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	*/

	// RVA: -1 Offset: -1
	private void Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E5BD0 Offset: 0x10E4DD0 VA: 0x1810E5BD0
	|-SortedSet.Enumerator<KeyValuePair<object, char>>.Initialize
	|
	|-RVA: 0x1106FC0 Offset: 0x11061C0 VA: 0x181106FC0
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>.Initialize
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E72D0 Offset: 0x10E64D0 VA: 0x1810E72D0
	|-SortedSet.Enumerator<KeyValuePair<object, char>>.MoveNext
	|
	|-RVA: 0x110A6B0 Offset: 0x11098B0 VA: 0x18110A6B0
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-SortedSet.Enumerator<KeyValuePair<object, char>>.Dispose
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EBD60 Offset: 0x10EAF60 VA: 0x1810EBD60
	|-SortedSet.Enumerator<KeyValuePair<object, char>>.get_Current
	|
	|-RVA: 0x1111E90 Offset: 0x1111090 VA: 0x181111E90
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E9C50 Offset: 0x10E8E50 VA: 0x1810E9C50
	|-SortedSet.Enumerator<KeyValuePair<object, char>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110D3E0 Offset: 0x110C5E0 VA: 0x18110D3E0
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1
	internal bool get_NotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EC0D0 Offset: 0x10EB2D0 VA: 0x1810EC0D0
	|-SortedSet.Enumerator<KeyValuePair<object, char>>.get_NotStartedOrEnded
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>.get_NotStartedOrEnded
	*/

	// RVA: -1 Offset: -1
	internal void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E8540 Offset: 0x10E7740 VA: 0x1810E8540
	|-SortedSet.Enumerator<KeyValuePair<object, char>>.Reset
	|
	|-RVA: 0x110C140 Offset: 0x110B340 VA: 0x18110C140
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E8F50 Offset: 0x10E8150 VA: 0x1810E8F50
	|-SortedSet.Enumerator<KeyValuePair<object, char>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x110C980 Offset: 0x110BB80 VA: 0x18110C980
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EA5F0 Offset: 0x10E97F0 VA: 0x1810EA5F0
	|-SortedSet.Enumerator<KeyValuePair<object, char>>..cctor
	|
	|-RVA: 0x110F390 Offset: 0x110E590 VA: 0x18110F390
	|-SortedSet.Enumerator<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: 
internal struct SortedSet.ElementCount<T> // TypeDefIndex: 5568
{
	// Fields
	internal int UniqueCount; // 0x0
	internal int UnfoundCount; // 0x0
}

// Namespace: 
[CompilerGenerated]
private sealed class SortedSet.<>c__DisplayClass52_0<T> // TypeDefIndex: 5569
{
	// Fields
	public int index; // 0x0
	public int count; // 0x0
	public T[] array; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-SortedSet.<>c__DisplayClass52_0<KeyValuePair<object, char>>..ctor
	|-SortedSet.<>c__DisplayClass52_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <CopyTo>b__0(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0EAA0 Offset: 0xB0DCA0 VA: 0x180B0EAA0
	|-SortedSet.<>c__DisplayClass52_0<KeyValuePair<object, char>>.<CopyTo>b__0
	|
	|-RVA: 0xB0E980 Offset: 0xB0DB80 VA: 0x180B0E980
	|-SortedSet.<>c__DisplayClass52_0<__Il2CppFullySharedGenericType>.<CopyTo>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class SortedSet.<>c__DisplayClass53_0<T> // TypeDefIndex: 5570
{
	// Fields
	public int index; // 0x0
	public object[] objects; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-SortedSet.<>c__DisplayClass53_0<KeyValuePair<object, char>>..ctor
	|-SortedSet.<>c__DisplayClass53_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <System.Collections.ICollection.CopyTo>b__0(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB0EB00 Offset: 0xB0DD00 VA: 0x180B0EB00
	|-SortedSet.<>c__DisplayClass53_0<KeyValuePair<object, char>>.<System.Collections.ICollection.CopyTo>b__0
	|
	|-RVA: 0xB0EBA0 Offset: 0xB0DDA0 VA: 0x180B0EBA0
	|-SortedSet.<>c__DisplayClass53_0<__Il2CppFullySharedGenericType>.<System.Collections.ICollection.CopyTo>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class SortedSet.<>c__DisplayClass85_0<T> // TypeDefIndex: 5571
{
	// Fields
	public Predicate<T> match; // 0x0
	public List<T> matches; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-SortedSet.<>c__DisplayClass85_0<KeyValuePair<object, char>>..ctor
	|-SortedSet.<>c__DisplayClass85_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <RemoveWhere>b__0(SortedSet.Node<T> n) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB12110 Offset: 0xB11310 VA: 0x180B12110
	|-SortedSet.<>c__DisplayClass85_0<KeyValuePair<object, char>>.<RemoveWhere>b__0
	|
	|-RVA: 0xB12210 Offset: 0xB11410 VA: 0x180B12210
	|-SortedSet.<>c__DisplayClass85_0<__Il2CppFullySharedGenericType>.<RemoveWhere>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class SortedSet.<Reverse>d__94<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 5572
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	public SortedSet<T> <>4__this; // 0x0
	private SortedSet.Enumerator<T> <e>5__2; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB028A0 Offset: 0xB01AA0 VA: 0x180B028A0
	|-SortedSet.<Reverse>d__94<KeyValuePair<object, char>>..ctor
	|
	|-RVA: 0xB027F0 Offset: 0xB019F0 VA: 0x180B027F0
	|-SortedSet.<Reverse>d__94<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-SortedSet.<Reverse>d__94<KeyValuePair<object, char>>.System.IDisposable.Dispose
	|-SortedSet.<Reverse>d__94<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB2B9C0 Offset: 0xB2ABC0 VA: 0x180B2B9C0
	|-SortedSet.<Reverse>d__94<KeyValuePair<object, char>>.MoveNext
	|
	|-RVA: 0xB2B680 Offset: 0xB2A880 VA: 0x180B2B680
	|-SortedSet.<Reverse>d__94<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820
	|-SortedSet.<Reverse>d__94<KeyValuePair<object, char>>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0xB02120 Offset: 0xB01320 VA: 0x180B02120
	|-SortedSet.<Reverse>d__94<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-SortedSet.<Reverse>d__94<KeyValuePair<object, char>>.System.Collections.IEnumerator.Reset
	|-SortedSet.<Reverse>d__94<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02460 Offset: 0xB01660 VA: 0x180B02460
	|-SortedSet.<Reverse>d__94<KeyValuePair<object, char>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB023B0 Offset: 0xB015B0 VA: 0x180B023B0
	|-SortedSet.<Reverse>d__94<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB2BB10 Offset: 0xB2AD10 VA: 0x180B2BB10
	|-SortedSet.<Reverse>d__94<KeyValuePair<object, char>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0xB2BBC0 Offset: 0xB2ADC0 VA: 0x180B2BBC0
	|-SortedSet.<Reverse>d__94<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB2BD20 Offset: 0xB2AF20 VA: 0x180B2BD20
	|-SortedSet.<Reverse>d__94<KeyValuePair<object, char>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xB1B530 Offset: 0xB1A730 VA: 0x180B1B530
	|-SortedSet.<Reverse>d__94<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: System.Collections.Generic
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView<T>))]
[Serializable]
public class SortedSet<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback // TypeDefIndex: 5573
{
	// Fields
	private SortedSet.Node<T> root; // 0x0
	private IComparer<T> comparer; // 0x0
	private int count; // 0x0
	private int version; // 0x0
	private object _syncRoot; // 0x0
	private SerializationInfo siInfo; // 0x0
	private const string ComparerName = "Comparer";
	private const string CountName = "Count";
	private const string ItemsName = "Items";
	private const string VersionName = "Version";
	private const string TreeName = "Tree";
	private const string NodeValueName = "Item";
	private const string EnumStartName = "EnumStarted";
	private const string ReverseName = "Reverse";
	private const string EnumVersionName = "EnumVersion";
	private const string MinName = "Min";
	private const string MaxName = "Max";
	private const string LowerBoundActiveName = "lBoundActive";
	private const string UpperBoundActiveName = "uBoundActive";
	internal const int StackAllocThreshold = 100;

	// Properties
	public int Count { get; }
	public IComparer<T> Comparer { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public T Min { get; }
	internal virtual T MinInternal { get; }
	public T Max { get; }
	internal virtual T MaxInternal { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC30B10 Offset: 0xC2FD10 VA: 0x180C30B10
	|-SortedSet<KeyValuePair<object, char>>..ctor
	|
	|-RVA: 0xC30130 Offset: 0xC2F330 VA: 0x180C30130
	|-SortedSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC30A50 Offset: 0xC2FC50 VA: 0x180C30A50
	|-SortedSet<KeyValuePair<object, char>>..ctor
	|
	|-RVA: 0xC30170 Offset: 0xC2F370 VA: 0x180C30170
	|-SortedSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC30AB0 Offset: 0xC2FCB0 VA: 0x180C30AB0
	|-SortedSet<KeyValuePair<object, char>>..ctor
	|
	|-RVA: 0xC30B50 Offset: 0xC2FD50 VA: 0x180C30B50
	|-SortedSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC301D0 Offset: 0xC2F3D0 VA: 0x180C301D0
	|-SortedSet<KeyValuePair<object, char>>..ctor
	|
	|-RVA: 0xC305F0 Offset: 0xC2F7F0 VA: 0x180C305F0
	|-SortedSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC305C0 Offset: 0xC2F7C0 VA: 0x180C305C0
	|-SortedSet<KeyValuePair<object, char>>..ctor
	|-SortedSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void AddAllElements(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1D160 Offset: 0xC1C360 VA: 0x180C1D160
	|-SortedSet<KeyValuePair<object, char>>.AddAllElements
	|
	|-RVA: 0xC1CE20 Offset: 0xC1C020 VA: 0x180C1CE20
	|-SortedSet<__Il2CppFullySharedGenericType>.AddAllElements
	*/

	// RVA: -1 Offset: -1
	private void RemoveAllElements(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC2A0E0 Offset: 0xC292E0 VA: 0x180C2A0E0
	|-SortedSet<KeyValuePair<object, char>>.RemoveAllElements
	|
	|-RVA: 0xC2A510 Offset: 0xC29710 VA: 0x180C2A510
	|-SortedSet<__Il2CppFullySharedGenericType>.RemoveAllElements
	*/

	// RVA: -1 Offset: -1
	private bool ContainsAllElements(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC20300 Offset: 0xC1F500 VA: 0x180C20300
	|-SortedSet<KeyValuePair<object, char>>.ContainsAllElements
	|
	|-RVA: 0xC20530 Offset: 0xC1F730 VA: 0x180C20530
	|-SortedSet<__Il2CppFullySharedGenericType>.ContainsAllElements
	*/

	// RVA: -1 Offset: -1 Slot: 31
	internal virtual bool InOrderTreeWalk(TreeWalkPredicate<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC24540 Offset: 0xC23740 VA: 0x180C24540
	|-SortedSet<KeyValuePair<object, char>>.InOrderTreeWalk
	|
	|-RVA: 0xC242B0 Offset: 0xC234B0 VA: 0x180C242B0
	|-SortedSet<__Il2CppFullySharedGenericType>.InOrderTreeWalk
	*/

	// RVA: -1 Offset: -1 Slot: 32
	internal virtual bool BreadthFirstTreeWalk(TreeWalkPredicate<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1DF80 Offset: 0xC1D180 VA: 0x180C1DF80
	|-SortedSet<KeyValuePair<object, char>>.BreadthFirstTreeWalk
	|
	|-RVA: 0xC1E0D0 Offset: 0xC1D2D0 VA: 0x180C1E0D0
	|-SortedSet<__Il2CppFullySharedGenericType>.BreadthFirstTreeWalk
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC30BB0 Offset: 0xC2FDB0 VA: 0x180C30BB0
	|-SortedSet<KeyValuePair<object, char>>.get_Count
	|-SortedSet<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public IComparer<T> get_Comparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-SortedSet<KeyValuePair<object, char>>.get_Comparer
	|-SortedSet<__Il2CppFullySharedGenericType>.get_Comparer
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-SortedSet<KeyValuePair<object, char>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	|-SortedSet<KeyValuePair<object, char>>.System.Collections.ICollection.get_IsSynchronized
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC2EB70 Offset: 0xC2DD70 VA: 0x180C2EB70
	|-SortedSet<KeyValuePair<object, char>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0xC2EBE0 Offset: 0xC2DDE0 VA: 0x180C2EBE0
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 33
	internal virtual void VersionCheck() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-SortedSet<KeyValuePair<object, char>>.VersionCheck
	|-SortedSet<__Il2CppFullySharedGenericType>.VersionCheck
	*/

	// RVA: -1 Offset: -1 Slot: 34
	internal virtual bool IsWithinRange(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	|-SortedSet<KeyValuePair<object, char>>.IsWithinRange
	|-SortedSet<__Il2CppFullySharedGenericType>.IsWithinRange
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1DE60 Offset: 0xC1D060 VA: 0x180C1DE60
	|-SortedSet<KeyValuePair<object, char>>.Add
	|
	|-RVA: 0xC1DE90 Offset: 0xC1D090 VA: 0x180C1DE90
	|-SortedSet<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1DE60 Offset: 0xC1D060 VA: 0x180C1DE60
	|-SortedSet<KeyValuePair<object, char>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0xC2E0C0 Offset: 0xC2D2C0 VA: 0x180C2E0C0
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 35
	internal virtual bool AddIfNotPresent(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1D8F0 Offset: 0xC1CAF0 VA: 0x180C1D8F0
	|-SortedSet<KeyValuePair<object, char>>.AddIfNotPresent
	|
	|-RVA: 0xC1D3A0 Offset: 0xC1C5A0 VA: 0x180C1D3A0
	|-SortedSet<__Il2CppFullySharedGenericType>.AddIfNotPresent
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC2B100 Offset: 0xC2A300 VA: 0x180C2B100
	|-SortedSet<KeyValuePair<object, char>>.Remove
	|
	|-RVA: 0xC2B010 Offset: 0xC2A210 VA: 0x180C2B010
	|-SortedSet<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 36
	internal virtual bool DoRemove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC21310 Offset: 0xC20510 VA: 0x180C21310
	|-SortedSet<KeyValuePair<object, char>>.DoRemove
	|
	|-RVA: 0xC21840 Offset: 0xC20A40 VA: 0x180C21840
	|-SortedSet<__Il2CppFullySharedGenericType>.DoRemove
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public virtual void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1ED00 Offset: 0xC1DF00 VA: 0x180C1ED00
	|-SortedSet<KeyValuePair<object, char>>.Clear
	|-SortedSet<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 38
	public virtual bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC20890 Offset: 0xC1FA90 VA: 0x180C20890
	|-SortedSet<KeyValuePair<object, char>>.Contains
	|
	|-RVA: 0xC207A0 Offset: 0xC1F9A0 VA: 0x180C207A0
	|-SortedSet<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC20F50 Offset: 0xC20150 VA: 0x180C20F50
	|-SortedSet<KeyValuePair<object, char>>.CopyTo
	|
	|-RVA: 0xC20940 Offset: 0xC1FB40 VA: 0x180C20940
	|-SortedSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC20C40 Offset: 0xC1FE40 VA: 0x180C20C40
	|-SortedSet<KeyValuePair<object, char>>.CopyTo
	|
	|-RVA: 0xC208C0 Offset: 0xC1FAC0 VA: 0x180C208C0
	|-SortedSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC20CC0 Offset: 0xC1FEC0 VA: 0x180C20CC0
	|-SortedSet<KeyValuePair<object, char>>.CopyTo
	|
	|-RVA: 0xC209B0 Offset: 0xC1FBB0 VA: 0x180C209B0
	|-SortedSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC2E710 Offset: 0xC2D910 VA: 0x180C2E710
	|-SortedSet<KeyValuePair<object, char>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0xC2E2B0 Offset: 0xC2D4B0 VA: 0x180C2E2B0
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC237C0 Offset: 0xC229C0 VA: 0x180C237C0
	|-SortedSet<KeyValuePair<object, char>>.GetEnumerator
	|
	|-RVA: 0xC23800 Offset: 0xC22A00 VA: 0x180C23800
	|-SortedSet<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC2E1B0 Offset: 0xC2D3B0 VA: 0x180C2E1B0
	|-SortedSet<KeyValuePair<object, char>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0xC2E240 Offset: 0xC2D440 VA: 0x180C2E240
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC2E1B0 Offset: 0xC2D3B0 VA: 0x180C2E1B0
	|-SortedSet<KeyValuePair<object, char>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xC2E240 Offset: 0xC2D440 VA: 0x180C2E240
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private void InsertionBalance(SortedSet.Node<T> current, ref SortedSet.Node<T> parent, SortedSet.Node<T> grandParent, SortedSet.Node<T> greatGrandParent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC246D0 Offset: 0xC238D0 VA: 0x180C246D0
	|-SortedSet<KeyValuePair<object, char>>.InsertionBalance
	|
	|-RVA: 0xC24820 Offset: 0xC23A20 VA: 0x180C24820
	|-SortedSet<__Il2CppFullySharedGenericType>.InsertionBalance
	*/

	// RVA: -1 Offset: -1
	private void ReplaceChildOrRoot(SortedSet.Node<T> parent, SortedSet.Node<T> child, SortedSet.Node<T> newChild) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC2B130 Offset: 0xC2A330 VA: 0x180C2B130
	|-SortedSet<KeyValuePair<object, char>>.ReplaceChildOrRoot
	|
	|-RVA: 0xC2B170 Offset: 0xC2A370 VA: 0x180C2B170
	|-SortedSet<__Il2CppFullySharedGenericType>.ReplaceChildOrRoot
	*/

	// RVA: -1 Offset: -1
	private void ReplaceNode(SortedSet.Node<T> match, SortedSet.Node<T> parentOfMatch, SortedSet.Node<T> successor, SortedSet.Node<T> parentOfSuccessor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC2B3D0 Offset: 0xC2A5D0 VA: 0x180C2B3D0
	|-SortedSet<KeyValuePair<object, char>>.ReplaceNode
	|
	|-RVA: 0xC2B1B0 Offset: 0xC2A3B0 VA: 0x180C2B1B0
	|-SortedSet<__Il2CppFullySharedGenericType>.ReplaceNode
	*/

	// RVA: -1 Offset: -1 Slot: 39
	internal virtual SortedSet.Node<T> FindNode(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC22D90 Offset: 0xC21F90 VA: 0x180C22D90
	|-SortedSet<KeyValuePair<object, char>>.FindNode
	|
	|-RVA: 0xC22ED0 Offset: 0xC220D0 VA: 0x180C22ED0
	|-SortedSet<__Il2CppFullySharedGenericType>.FindNode
	*/

	// RVA: -1 Offset: -1 Slot: 40
	internal virtual int InternalIndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC249B0 Offset: 0xC23BB0 VA: 0x180C249B0
	|-SortedSet<KeyValuePair<object, char>>.InternalIndexOf
	|
	|-RVA: 0xC24B10 Offset: 0xC23D10 VA: 0x180C24B10
	|-SortedSet<__Il2CppFullySharedGenericType>.InternalIndexOf
	*/

	// RVA: -1 Offset: -1
	internal SortedSet.Node<T> FindRange(T from, T to) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC230B0 Offset: 0xC222B0 VA: 0x180C230B0
	|-SortedSet<KeyValuePair<object, char>>.FindRange
	|
	|-RVA: 0xC23100 Offset: 0xC22300 VA: 0x180C23100
	|-SortedSet<__Il2CppFullySharedGenericType>.FindRange
	*/

	// RVA: -1 Offset: -1
	internal SortedSet.Node<T> FindRange(T from, T to, bool lowerBoundActive, bool upperBoundActive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC23290 Offset: 0xC22490 VA: 0x180C23290
	|-SortedSet<KeyValuePair<object, char>>.FindRange
	|
	|-RVA: 0xC234C0 Offset: 0xC226C0 VA: 0x180C234C0
	|-SortedSet<__Il2CppFullySharedGenericType>.FindRange
	*/

	// RVA: -1 Offset: -1
	internal void UpdateVersion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC30120 Offset: 0xC2F320 VA: 0x180C30120
	|-SortedSet<KeyValuePair<object, char>>.UpdateVersion
	|-SortedSet<__Il2CppFullySharedGenericType>.UpdateVersion
	*/

	// RVA: -1 Offset: -1
	public static IEqualityComparer<SortedSet<T>> CreateSetComparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC212D0 Offset: 0xC204D0 VA: 0x180C212D0
	|-SortedSet<KeyValuePair<object, char>>.CreateSetComparer
	|
	|-RVA: 0xC21260 Offset: 0xC20460 VA: 0x180C21260
	|-SortedSet<__Il2CppFullySharedGenericType>.CreateSetComparer
	*/

	// RVA: -1 Offset: -1
	public static IEqualityComparer<SortedSet<T>> CreateSetComparer(IEqualityComparer<T> memberEqualityComparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC21090 Offset: 0xC20290 VA: 0x180C21090
	|-SortedSet<KeyValuePair<object, char>>.CreateSetComparer
	|
	|-RVA: 0xC20FC0 Offset: 0xC201C0 VA: 0x180C20FC0
	|-SortedSet<__Il2CppFullySharedGenericType>.CreateSetComparer
	*/

	// RVA: -1 Offset: -1
	internal static bool SortedSetEquals(SortedSet<T> set1, SortedSet<T> set2, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC2C8B0 Offset: 0xC2BAB0 VA: 0x180C2C8B0
	|-SortedSet<KeyValuePair<object, char>>.SortedSetEquals
	|
	|-RVA: 0xC2BF80 Offset: 0xC2B180 VA: 0x180C2BF80
	|-SortedSet<__Il2CppFullySharedGenericType>.SortedSetEquals
	*/

	// RVA: -1 Offset: -1
	private bool HasEqualComparer(SortedSet<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC24260 Offset: 0xC23460 VA: 0x180C24260
	|-SortedSet<KeyValuePair<object, char>>.HasEqualComparer
	|
	|-RVA: 0xC24180 Offset: 0xC23380 VA: 0x180C24180
	|-SortedSet<__Il2CppFullySharedGenericType>.HasEqualComparer
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void UnionWith(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC2EE40 Offset: 0xC2E040 VA: 0x180C2EE40
	|-SortedSet<KeyValuePair<object, char>>.UnionWith
	|
	|-RVA: 0xC2F6C0 Offset: 0xC2E8C0 VA: 0x180C2F6C0
	|-SortedSet<__Il2CppFullySharedGenericType>.UnionWith
	*/

	// RVA: -1 Offset: -1
	private static SortedSet.Node<T> ConstructRootFromSortedArray(T[] arr, int startIndex, int endIndex, SortedSet.Node<T> redNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1FBB0 Offset: 0xC1EDB0 VA: 0x180C1FBB0
	|-SortedSet<KeyValuePair<object, char>>.ConstructRootFromSortedArray
	|
	|-RVA: 0xC1ED10 Offset: 0xC1DF10 VA: 0x180C1ED10
	|-SortedSet<__Il2CppFullySharedGenericType>.ConstructRootFromSortedArray
	*/

	// RVA: -1 Offset: -1 Slot: 41
	public virtual void IntersectWith(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC25860 Offset: 0xC24A60 VA: 0x180C25860
	|-SortedSet<KeyValuePair<object, char>>.IntersectWith
	|
	|-RVA: 0xC26030 Offset: 0xC25230 VA: 0x180C26030
	|-SortedSet<__Il2CppFullySharedGenericType>.IntersectWith
	*/

	// RVA: -1 Offset: -1 Slot: 42
	internal virtual void IntersectWithEnumerable(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC253C0 Offset: 0xC245C0 VA: 0x180C253C0
	|-SortedSet<KeyValuePair<object, char>>.IntersectWithEnumerable
	|
	|-RVA: 0xC24D10 Offset: 0xC23F10 VA: 0x180C24D10
	|-SortedSet<__Il2CppFullySharedGenericType>.IntersectWithEnumerable
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void ExceptWith(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC22640 Offset: 0xC21840 VA: 0x180C22640
	|-SortedSet<KeyValuePair<object, char>>.ExceptWith
	|
	|-RVA: 0xC21DD0 Offset: 0xC20FD0 VA: 0x180C21DD0
	|-SortedSet<__Il2CppFullySharedGenericType>.ExceptWith
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void SymmetricExceptWith(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC2DAB0 Offset: 0xC2CCB0 VA: 0x180C2DAB0
	|-SortedSet<KeyValuePair<object, char>>.SymmetricExceptWith
	|
	|-RVA: 0xC2DEB0 Offset: 0xC2D0B0 VA: 0x180C2DEB0
	|-SortedSet<__Il2CppFullySharedGenericType>.SymmetricExceptWith
	*/

	// RVA: -1 Offset: -1
	private void SymmetricExceptWithSameComparer(SortedSet<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC2D890 Offset: 0xC2CA90 VA: 0x180C2D890
	|-SortedSet<KeyValuePair<object, char>>.SymmetricExceptWithSameComparer
	|
	|-RVA: 0xC2D530 Offset: 0xC2C730 VA: 0x180C2D530
	|-SortedSet<__Il2CppFullySharedGenericType>.SymmetricExceptWithSameComparer
	*/

	// RVA: -1 Offset: -1
	private void SymmetricExceptWithSameComparer(T[] other, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC2D300 Offset: 0xC2C500 VA: 0x180C2D300
	|-SortedSet<KeyValuePair<object, char>>.SymmetricExceptWithSameComparer
	|
	|-RVA: 0xC2CF50 Offset: 0xC2C150 VA: 0x180C2CF50
	|-SortedSet<__Il2CppFullySharedGenericType>.SymmetricExceptWithSameComparer
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public bool IsSubsetOf(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC280F0 Offset: 0xC272F0 VA: 0x180C280F0
	|-SortedSet<KeyValuePair<object, char>>.IsSubsetOf
	|
	|-RVA: 0xC27EF0 Offset: 0xC270F0 VA: 0x180C27EF0
	|-SortedSet<__Il2CppFullySharedGenericType>.IsSubsetOf
	*/

	// RVA: -1 Offset: -1
	private bool IsSubsetOfSortedSetWithSameComparer(SortedSet<T> asSorted) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC27C60 Offset: 0xC26E60 VA: 0x180C27C60
	|-SortedSet<KeyValuePair<object, char>>.IsSubsetOfSortedSetWithSameComparer
	|
	|-RVA: 0xC27890 Offset: 0xC26A90 VA: 0x180C27890
	|-SortedSet<__Il2CppFullySharedGenericType>.IsSubsetOfSortedSetWithSameComparer
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public bool IsProperSubsetOf(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC26920 Offset: 0xC25B20 VA: 0x180C26920
	|-SortedSet<KeyValuePair<object, char>>.IsProperSubsetOf
	|
	|-RVA: 0xC26B60 Offset: 0xC25D60 VA: 0x180C26B60
	|-SortedSet<__Il2CppFullySharedGenericType>.IsProperSubsetOf
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool IsSupersetOf(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC28860 Offset: 0xC27A60 VA: 0x180C28860
	|-SortedSet<KeyValuePair<object, char>>.IsSupersetOf
	|
	|-RVA: 0xC282D0 Offset: 0xC274D0 VA: 0x180C282D0
	|-SortedSet<__Il2CppFullySharedGenericType>.IsSupersetOf
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public bool IsProperSupersetOf(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC26DD0 Offset: 0xC25FD0 VA: 0x180C26DD0
	|-SortedSet<KeyValuePair<object, char>>.IsProperSupersetOf
	|
	|-RVA: 0xC27280 Offset: 0xC26480 VA: 0x180C27280
	|-SortedSet<__Il2CppFullySharedGenericType>.IsProperSupersetOf
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public bool SetEquals(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC2B630 Offset: 0xC2A830 VA: 0x180C2B630
	|-SortedSet<KeyValuePair<object, char>>.SetEquals
	|
	|-RVA: 0xC2BAA0 Offset: 0xC2ACA0 VA: 0x180C2BAA0
	|-SortedSet<__Il2CppFullySharedGenericType>.SetEquals
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Overlaps(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC29AC0 Offset: 0xC28CC0 VA: 0x180C29AC0
	|-SortedSet<KeyValuePair<object, char>>.Overlaps
	|
	|-RVA: 0xC29490 Offset: 0xC28690 VA: 0x180C29490
	|-SortedSet<__Il2CppFullySharedGenericType>.Overlaps
	*/

	// RVA: -1 Offset: -1
	private SortedSet.ElementCount<T> CheckUniqueAndUnfoundElements(IEnumerable<T> other, bool returnIfUnfound) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC1E310 Offset: 0xC1D510 VA: 0x180C1E310
	|-SortedSet<KeyValuePair<object, char>>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0xC1E7E0 Offset: 0xC1D9E0 VA: 0x180C1E7E0
	|-SortedSet<__Il2CppFullySharedGenericType>.CheckUniqueAndUnfoundElements
	*/

	// RVA: -1 Offset: -1
	public int RemoveWhere(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC2AAF0 Offset: 0xC29CF0 VA: 0x180C2AAF0
	|-SortedSet<KeyValuePair<object, char>>.RemoveWhere
	|
	|-RVA: 0xC2AD20 Offset: 0xC29F20 VA: 0x180C2AD20
	|-SortedSet<__Il2CppFullySharedGenericType>.RemoveWhere
	*/

	// RVA: -1 Offset: -1
	public T get_Min() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC31010 Offset: 0xC30210 VA: 0x180C31010
	|-SortedSet<KeyValuePair<object, char>>.get_Min
	|
	|-RVA: 0xC31040 Offset: 0xC30240 VA: 0x180C31040
	|-SortedSet<__Il2CppFullySharedGenericType>.get_Min
	*/

	// RVA: -1 Offset: -1 Slot: 43
	internal virtual T get_MinInternal() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC30E60 Offset: 0xC30060 VA: 0x180C30E60
	|-SortedSet<KeyValuePair<object, char>>.get_MinInternal
	|
	|-RVA: 0xC30EA0 Offset: 0xC300A0 VA: 0x180C30EA0
	|-SortedSet<__Il2CppFullySharedGenericType>.get_MinInternal
	*/

	// RVA: -1 Offset: -1
	public T get_Max() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC30D90 Offset: 0xC2FF90 VA: 0x180C30D90
	|-SortedSet<KeyValuePair<object, char>>.get_Max
	|
	|-RVA: 0xC30DC0 Offset: 0xC2FFC0 VA: 0x180C30DC0
	|-SortedSet<__Il2CppFullySharedGenericType>.get_Max
	*/

	// RVA: -1 Offset: -1 Slot: 44
	internal virtual T get_MaxInternal() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC30D50 Offset: 0xC2FF50 VA: 0x180C30D50
	|-SortedSet<KeyValuePair<object, char>>.get_MaxInternal
	|
	|-RVA: 0xC30BE0 Offset: 0xC2FDE0 VA: 0x180C30BE0
	|-SortedSet<__Il2CppFullySharedGenericType>.get_MaxInternal
	*/

	[IteratorStateMachine(typeof(SortedSet.<Reverse>d__94<T>))]
	// RVA: -1 Offset: -1
	public IEnumerable<T> Reverse() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC2B4E0 Offset: 0xC2A6E0 VA: 0x180C2B4E0
	|-SortedSet<KeyValuePair<object, char>>.Reverse
	|
	|-RVA: 0xC2B570 Offset: 0xC2A770 VA: 0x180C2B570
	|-SortedSet<__Il2CppFullySharedGenericType>.Reverse
	*/

	// RVA: -1 Offset: -1 Slot: 45
	public virtual SortedSet<T> GetViewBetween(T lowerValue, T upperValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC23FB0 Offset: 0xC231B0 VA: 0x180C23FB0
	|-SortedSet<KeyValuePair<object, char>>.GetViewBetween
	|
	|-RVA: 0xC23C70 Offset: 0xC22E70 VA: 0x180C23C70
	|-SortedSet<__Il2CppFullySharedGenericType>.GetViewBetween
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC2EC50 Offset: 0xC2DE50 VA: 0x180C2EC50
	|-SortedSet<KeyValuePair<object, char>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Runtime.Serialization.ISerializable.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 46
	protected virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC23840 Offset: 0xC22A40 VA: 0x180C23840
	|-SortedSet<KeyValuePair<object, char>>.GetObjectData
	|
	|-RVA: 0xC23A50 Offset: 0xC22C50 VA: 0x180C23A50
	|-SortedSet<__Il2CppFullySharedGenericType>.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7B2F0 Offset: 0xB7A4F0 VA: 0x180B7B2F0
	|-SortedSet<KeyValuePair<object, char>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	*/

	// RVA: -1 Offset: -1 Slot: 47
	protected virtual void OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC290F0 Offset: 0xC282F0 VA: 0x180C290F0
	|-SortedSet<KeyValuePair<object, char>>.OnDeserialization
	|
	|-RVA: 0xC28CD0 Offset: 0xC27ED0 VA: 0x180C28CD0
	|-SortedSet<__Il2CppFullySharedGenericType>.OnDeserialization
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(T equalValue, out T actualValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC2EC80 Offset: 0xC2DE80 VA: 0x180C2EC80
	|-SortedSet<KeyValuePair<object, char>>.TryGetValue
	|
	|-RVA: 0xC2ECD0 Offset: 0xC2DED0 VA: 0x180C2ECD0
	|-SortedSet<__Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	private static int Log2(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC28CC0 Offset: 0xC27EC0 VA: 0x180C28CC0
	|-SortedSet<KeyValuePair<object, char>>.Log2
	|-SortedSet<__Il2CppFullySharedGenericType>.Log2
	*/
}

// Namespace: System.Collections.Generic
