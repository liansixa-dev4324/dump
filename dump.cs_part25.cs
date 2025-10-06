	// RVA: 0x26979C0 Offset: 0x2696BC0 VA: 0x1826979C0
	internal void .ctor(MeshGenerationContext ctx) { }

	// RVA: 0x26978A0 Offset: 0x2696AA0 VA: 0x1826978A0
	internal void Reset() { }

	// RVA: 0x2697800 Offset: 0x2696A00 VA: 0x182697800 Slot: 4
	public void Dispose() { }

	// RVA: 0x26977A0 Offset: 0x26969A0 VA: 0x1826977A0
	private void Dispose(bool disposing) { }

	[CompilerGenerated]
	// RVA: 0x2697A60 Offset: 0x2696C60 VA: 0x182697A60
	internal static void set_isPainterActive(bool value) { }

	// RVA: 0x2697910 Offset: 0x2696B10 VA: 0x182697910
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements
internal class UIRRepaintUpdater : BaseVisualTreeUpdater // TypeDefIndex: 11388
{
	// Fields
	private BaseVisualElementPanel attachedPanel; // 0x20
	internal RenderChain renderChain; // 0x28
	private static readonly string s_Description; // 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <drawStats>k__BackingField; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <breakBatches>k__BackingField; // 0x31
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x32

	// Properties
	public override ProfilerMarker profilerMarker { get; }
	public bool drawStats { get; }
	public bool breakBatches { get; }
	protected bool disposed { get; set; }

	// Methods

	// RVA: 0x26A03A0 Offset: 0x269F5A0 VA: 0x1826A03A0
	public void .ctor() { }

	// RVA: 0x26A0420 Offset: 0x269F620 VA: 0x1826A0420 Slot: 10
	public override ProfilerMarker get_profilerMarker() { }

	[CompilerGenerated]
	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	public bool get_drawStats() { }

	[CompilerGenerated]
	// RVA: 0x577B10 Offset: 0x576D10 VA: 0x180577B10
	public bool get_breakBatches() { }

	// RVA: 0x269FF50 Offset: 0x269F150 VA: 0x18269FF50 Slot: 13
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x26A0160 Offset: 0x269F360 VA: 0x1826A0160 Slot: 12
	public override void Update() { }

	// RVA: 0x269F320 Offset: 0x269E520 VA: 0x18269F320 Slot: 14
	protected virtual RenderChain CreateRenderChain() { }

	// RVA: 0x26A02B0 Offset: 0x269F4B0 VA: 0x1826A02B0
	private static void .cctor() { }

	// RVA: 0x269F990 Offset: 0x269EB90 VA: 0x18269F990
	private static void OnGraphicsResourcesRecreate(bool recreate) { }

	// RVA: 0x269FBA0 Offset: 0x269EDA0 VA: 0x18269FBA0
	private void OnPanelChanged(BaseVisualElementPanel obj) { }

	// RVA: 0x269F150 Offset: 0x269E350 VA: 0x18269F150
	private void AttachToPanel() { }

	// RVA: 0x269F3F0 Offset: 0x269E5F0 VA: 0x18269F3F0
	private void DetachFromPanel() { }

	// RVA: 0x269F5F0 Offset: 0x269E7F0 VA: 0x18269F5F0
	private void InitRenderChain() { }

	// RVA: 0x269F390 Offset: 0x269E590 VA: 0x18269F390
	internal void DestroyRenderChain() { }

	// RVA: 0x269F390 Offset: 0x269E590 VA: 0x18269F390
	private void OnPanelAtlasChanged() { }

	// RVA: 0x269FBC0 Offset: 0x269EDC0 VA: 0x18269FBC0
	private void OnPanelHierarchyChanged(VisualElement ve, HierarchyChangeType changeType) { }

	// RVA: 0x269FC30 Offset: 0x269EE30 VA: 0x18269FC30
	private void OnPanelStandardShaderChanged() { }

	// RVA: 0x269FDC0 Offset: 0x269EFC0 VA: 0x18269FDC0
	private void OnPanelStandardWorldSpaceShaderChanged() { }

	// RVA: 0x26A00B0 Offset: 0x269F2B0 VA: 0x1826A00B0
	private void ResetAllElementsDataRecursive(VisualElement ve) { }

	[CompilerGenerated]
	// RVA: 0x21BAF40 Offset: 0x21BA140 VA: 0x1821BAF40
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x21BB140 Offset: 0x21BA340 VA: 0x1821BB140
	private void set_disposed(bool value) { }

	// RVA: 0x269F5C0 Offset: 0x269E7C0 VA: 0x18269F5C0 Slot: 11
	protected override void Dispose(bool disposing) { }
}

// Namespace: UnityEngine.UIElements
internal struct TextureId // TypeDefIndex: 11389
{
	// Fields
	private readonly int m_Index; // 0x0
	public static readonly TextureId invalid; // 0x0

	// Properties
	public int index { get; }

	// Methods

	// RVA: 0x269B690 Offset: 0x269A890 VA: 0x18269B690
	public void .ctor(int index) { }

	// RVA: 0x269B6A0 Offset: 0x269A8A0 VA: 0x18269B6A0
	public int get_index() { }

	// RVA: 0x269B560 Offset: 0x269A760 VA: 0x18269B560
	public float ConvertToGpu() { }

	// RVA: 0x269B5B0 Offset: 0x269A7B0 VA: 0x18269B5B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2459420 Offset: 0x2458620 VA: 0x182459420 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2499330 Offset: 0x2498530 VA: 0x182499330
	public static bool op_Equality(TextureId left, TextureId right) { }

	// RVA: 0x269B6B0 Offset: 0x269A8B0 VA: 0x18269B6B0
	public static bool op_Inequality(TextureId left, TextureId right) { }

	// RVA: 0x269B650 Offset: 0x269A850 VA: 0x18269B650
	private static void .cctor() { }
}

// Namespace: 
private struct TextureRegistry.TextureInfo // TypeDefIndex: 11390
{
	// Fields
	public Texture texture; // 0x0
	public bool dynamic; // 0x8
	public int refCount; // 0xC
}

// Namespace: UnityEngine.UIElements
internal class TextureRegistry // TypeDefIndex: 11391
{
	// Fields
	private List<TextureRegistry.TextureInfo> m_Textures; // 0x10
	private Dictionary<Texture, TextureId> m_TextureToId; // 0x18
	private Stack<TextureId> m_FreeIds; // 0x20
	internal const int maxTextures = 2048;
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly TextureRegistry <instance>k__BackingField; // 0x0

	// Properties
	public static TextureRegistry instance { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x269C480 Offset: 0x269B680 VA: 0x18269C480
	public static TextureRegistry get_instance() { }

	// RVA: 0x269BBB0 Offset: 0x269ADB0 VA: 0x18269BBB0
	public Texture GetTexture(TextureId id) { }

	// RVA: 0x269B8A0 Offset: 0x269AAA0 VA: 0x18269B8A0
	public TextureId AllocAndAcquireDynamic() { }

	// RVA: 0x269BFF0 Offset: 0x269B1F0 VA: 0x18269BFF0
	public void UpdateDynamic(TextureId id, Texture texture) { }

	// RVA: 0x269B8B0 Offset: 0x269AAB0 VA: 0x18269B8B0
	private TextureId AllocAndAcquire(Texture texture, bool dynamic) { }

	// RVA: 0x269B700 Offset: 0x269A900 VA: 0x18269B700
	public TextureId Acquire(Texture tex) { }

	// RVA: 0x269BD60 Offset: 0x269AF60 VA: 0x18269BD60
	public void Release(TextureId id) { }

	// RVA: 0x269C390 Offset: 0x269B590 VA: 0x18269C390
	public void .ctor() { }

	// RVA: 0x269C260 Offset: 0x269B460 VA: 0x18269C260
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements
[Extension]
internal static class UIRUtility // TypeDefIndex: 11392
{
	// Fields
	public static readonly string k_DefaultShaderName; // 0x0
	public static readonly string k_DefaultWorldSpaceShaderName; // 0x8

	// Methods

	// RVA: 0x26A0760 Offset: 0x269F960 VA: 0x1826A0760
	public static bool ShapeWindingIsClockwise(int maskDepth, int stencilRef) { }

	// RVA: 0x26A05F0 Offset: 0x269F7F0 VA: 0x1826A05F0
	public static bool IsRoundRect(VisualElement ve) { }

	// RVA: 0x26A06D0 Offset: 0x269F8D0 VA: 0x1826A06D0
	public static bool IsVectorImageBackground(VisualElement ve) { }

	// RVA: 0x26A0590 Offset: 0x269F790 VA: 0x1826A0590
	public static bool IsElementSelfHidden(VisualElement ve) { }

	// RVA: 0x26A0470 Offset: 0x269F670 VA: 0x1826A0470
	public static void Destroy(Object obj) { }

	// RVA: 0x26A0570 Offset: 0x269F770 VA: 0x1826A0570
	public static int GetPrevPow2(int n) { }

	// RVA: 0x26A0550 Offset: 0x269F750 VA: 0x1826A0550
	public static int GetNextPow2(int n) { }

	// RVA: 0x26A0530 Offset: 0x269F730 VA: 0x1826A0530
	public static int GetNextPow2Exp(int n) { }

	// RVA: 0x26A07E0 Offset: 0x269F9E0 VA: 0x1826A07E0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements
public struct TimerState : IEquatable<TimerState> // TypeDefIndex: 11393
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private long <start>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private long <now>k__BackingField; // 0x8

	// Properties
	public long start { get; set; }
	public long now { get; set; }
	public long deltaTime { get; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public long get_start() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_start(long value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public long get_now() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_now(long value) { }

	// RVA: 0x269D280 Offset: 0x269C480 VA: 0x18269D280
	public long get_deltaTime() { }

	// RVA: 0x269D160 Offset: 0x269C360 VA: 0x18269D160 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x269D130 Offset: 0x269C330 VA: 0x18269D130 Slot: 4
	public bool Equals(TimerState other) { }

	// RVA: 0x269D200 Offset: 0x269C400 VA: 0x18269D200 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.UIElements
internal interface IScheduler // TypeDefIndex: 11394
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Unschedule(ScheduledItem item);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Schedule(ScheduledItem item);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void UpdateScheduledEvents();
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ScheduledItem.<>c // TypeDefIndex: 11395
{
	// Fields
	public static readonly ScheduledItem.<>c <>9; // 0x0

	// Methods

	// RVA: 0x269D580 Offset: 0x269C780 VA: 0x18269D580
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20
	internal bool <.cctor>b__25_0() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110
	internal bool <.cctor>b__25_1() { }
}

// Namespace: UnityEngine.UIElements
internal abstract class ScheduledItem // TypeDefIndex: 11396
{
	// Fields
	public Func<bool> timerUpdateStopCondition; // 0x10
	public static readonly Func<bool> OnceCondition; // 0x0
	public static readonly Func<bool> ForeverCondition; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private long <startMs>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private long <delayMs>k__BackingField; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private long <intervalMs>k__BackingField; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private long <endTimeMs>k__BackingField; // 0x30

	// Properties
	public long startMs { get; set; }
	public long delayMs { get; set; }
	public long intervalMs { get; set; }
	public long endTimeMs { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public long get_startMs() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_startMs(long value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public long get_delayMs() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_delayMs(long value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public long get_intervalMs() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_intervalMs(long value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public long get_endTimeMs() { }

	// RVA: 0x269B450 Offset: 0x269A650 VA: 0x18269B450
	public void .ctor() { }

	// RVA: 0x269B2C0 Offset: 0x269A4C0 VA: 0x18269B2C0
	protected void ResetStartTime() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void PerformTimerUpdate(TimerState state);

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	internal virtual void OnItemUnscheduled() { }

	// RVA: 0x269B310 Offset: 0x269A510 VA: 0x18269B310 Slot: 6
	public virtual bool ShouldUnschedule() { }

	// RVA: 0x269B340 Offset: 0x269A540 VA: 0x18269B340
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements
internal class TimerEventScheduler : IScheduler // TypeDefIndex: 11397
{
	// Fields
	private readonly List<ScheduledItem> m_ScheduledItems; // 0x10
	private bool m_TransactionMode; // 0x18
	private readonly List<ScheduledItem> m_ScheduleTransactions; // 0x20
	private readonly HashSet<ScheduledItem> m_UnscheduleTransactions; // 0x28
	internal bool disableThrottling; // 0x30
	private int m_LastUpdatedIndex; // 0x34

	// Methods

	// RVA: 0x269C620 Offset: 0x269B820 VA: 0x18269C620 Slot: 5
	public void Schedule(ScheduledItem item) { }

	// RVA: 0x269C5B0 Offset: 0x269B7B0 VA: 0x18269C5B0
	private bool RemovedScheduledItemAt(int index) { }

	// RVA: 0x269C800 Offset: 0x269BA00 VA: 0x18269C800 Slot: 4
	public void Unschedule(ScheduledItem item) { }

	// RVA: 0x269C4D0 Offset: 0x269B6D0 VA: 0x18269C4D0
	private bool PrivateUnSchedule(ScheduledItem sItem) { }

	// RVA: 0x269CA70 Offset: 0x269BC70 VA: 0x18269CA70 Slot: 6
	public void UpdateScheduledEvents() { }

	// RVA: 0x269D050 Offset: 0x269C250 VA: 0x18269D050
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements
internal struct Spacing // TypeDefIndex: 11398
{
	// Fields
	public float left; // 0x0
	public float top; // 0x4
	public float right; // 0x8
	public float bottom; // 0xC

	// Properties
	public float horizontal { get; }
	public float vertical { get; }

	// Methods

	// RVA: 0x246ED30 Offset: 0x246DF30 VA: 0x18246ED30
	public float get_horizontal() { }

	// RVA: 0x246ED40 Offset: 0x246DF40 VA: 0x18246ED40
	public float get_vertical() { }

	// RVA: 0x1A1AC10 Offset: 0x1A19E10 VA: 0x181A1AC10
	public void .ctor(float left, float top, float right, float bottom) { }

	// RVA: 0x269B4F0 Offset: 0x269A6F0 VA: 0x18269B4F0
	public static Rect op_Subtraction(Rect r, Spacing a) { }
}

// Namespace: UnityEngine.UIElements
public enum AngleUnit // TypeDefIndex: 11399
{
	// Fields
	public int value__; // 0x0
	public const AngleUnit Degree = 0;
	public const AngleUnit Gradian = 1;
	public const AngleUnit Radian = 2;
	public const AngleUnit Turn = 3;
}

// Namespace: 
private enum Angle.Unit // TypeDefIndex: 11400
{
	// Fields
	public int value__; // 0x0
	public const Angle.Unit Degree = 0;
	public const Angle.Unit Gradian = 1;
	public const Angle.Unit Radian = 2;
	public const Angle.Unit Turn = 3;
	public const Angle.Unit None = 4;
}

// Namespace: UnityEngine.UIElements
public struct Angle : IEquatable<Angle> // TypeDefIndex: 11401
{
	// Fields
	private float m_Value; // 0x0
	private Angle.Unit m_Unit; // 0x4

	// Properties
	public float value { get; }

	// Methods

	// RVA: 0x268C490 Offset: 0x268B690 VA: 0x18268C490
	internal static Angle None() { }

	// RVA: 0x439FA0 Offset: 0x4391A0 VA: 0x180439FA0
	public float get_value() { }

	// RVA: 0xFB9280 Offset: 0xFB8480 VA: 0x180FB9280
	public void .ctor(float value, AngleUnit unit) { }

	// RVA: 0xFB9280 Offset: 0xFB8480 VA: 0x180FB9280
	private void .ctor(float value, Angle.Unit unit) { }

	// RVA: 0x268C4B0 Offset: 0x268B6B0 VA: 0x18268C4B0
	public float ToDegrees() { }

	// RVA: 0x268C6A0 Offset: 0x268B8A0 VA: 0x18268C6A0
	public static Angle op_Implicit(float value) { }

	// RVA: 0x268C670 Offset: 0x268B870 VA: 0x18268C670
	public static bool op_Equality(Angle lhs, Angle rhs) { }

	// RVA: 0x268C440 Offset: 0x268B640 VA: 0x18268C440 Slot: 4
	public bool Equals(Angle other) { }

	// RVA: 0x268C390 Offset: 0x268B590 VA: 0x18268C390 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x268C470 Offset: 0x268B670 VA: 0x18268C470 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x268C510 Offset: 0x268B710 VA: 0x18268C510 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.UIElements
public struct Background : IEquatable<Background> // TypeDefIndex: 11402
{
	// Fields
	private Texture2D m_Texture; // 0x0
	private Sprite m_Sprite; // 0x8
	private RenderTexture m_RenderTexture; // 0x10
	private VectorImage m_VectorImage; // 0x18

	// Properties
	public Texture2D texture { get; set; }
	public Sprite sprite { get; set; }
	public RenderTexture renderTexture { get; set; }
	public VectorImage vectorImage { get; set; }

	// Methods

	// RVA: 0xA55380 Offset: 0xA54580 VA: 0x180A55380
	public Texture2D get_texture() { }

	// RVA: 0x268D750 Offset: 0x268C950 VA: 0x18268D750
	public void set_texture(Texture2D value) { }

	// RVA: 0x1808BB0 Offset: 0x1807DB0 VA: 0x181808BB0
	public Sprite get_sprite() { }

	// RVA: 0x268D6D0 Offset: 0x268C8D0 VA: 0x18268D6D0
	public void set_sprite(Sprite value) { }

	// RVA: 0x1208660 Offset: 0x1207860 VA: 0x181208660
	public RenderTexture get_renderTexture() { }

	// RVA: 0x268D650 Offset: 0x268C850 VA: 0x18268D650
	public void set_renderTexture(RenderTexture value) { }

	// RVA: 0x248C210 Offset: 0x248B410 VA: 0x18248C210
	public VectorImage get_vectorImage() { }

	// RVA: 0x268D7D0 Offset: 0x268C9D0 VA: 0x18268D7D0
	public void set_vectorImage(VectorImage value) { }

	// RVA: 0x268D130 Offset: 0x268C330 VA: 0x18268D130
	public static Background FromTexture2D(Texture2D t) { }

	// RVA: 0x268CFF0 Offset: 0x268C1F0 VA: 0x18268CFF0
	public static Background FromRenderTexture(RenderTexture rt) { }

	// RVA: 0x268D090 Offset: 0x268C290 VA: 0x18268D090
	public static Background FromSprite(Sprite s) { }

	// RVA: 0x268D1D0 Offset: 0x268C3D0 VA: 0x18268D1D0
	public static Background FromVectorImage(VectorImage vi) { }

	// RVA: 0x268CC60 Offset: 0x268BE60 VA: 0x18268CC60
	internal static Background FromObject(object obj) { }

	// RVA: 0x268D470 Offset: 0x268C670 VA: 0x18268D470
	public static bool op_Equality(Background lhs, Background rhs) { }

	// RVA: 0x268D560 Offset: 0x268C760 VA: 0x18268D560
	public static bool op_Inequality(Background lhs, Background rhs) { }

	// RVA: 0x268CB60 Offset: 0x268BD60 VA: 0x18268CB60 Slot: 4
	public bool Equals(Background other) { }

	// RVA: 0x268C9C0 Offset: 0x268BBC0 VA: 0x18268C9C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x268D270 Offset: 0x268C470 VA: 0x18268D270 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x268D340 Offset: 0x268C540 VA: 0x18268D340 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.UIElements
internal struct ComputedStyle // TypeDefIndex: 11403
{
	// Fields
	public StyleDataRef<InheritedData> inheritedData; // 0x0
	public StyleDataRef<LayoutData> layoutData; // 0x8
	public StyleDataRef<RareData> rareData; // 0x10
	public StyleDataRef<TransformData> transformData; // 0x18
	public StyleDataRef<TransitionData> transitionData; // 0x20
	public StyleDataRef<VisualData> visualData; // 0x28
	public YogaNode yogaNode; // 0x30
	public Dictionary<string, StylePropertyValue> customProperties; // 0x38
	public long matchingRulesHash; // 0x40
	public float dpiScaling; // 0x48
	public ComputedTransitionProperty[] computedTransitions; // 0x50

	// Properties
	public int customPropertiesCount { get; }
	public bool hasTransition { get; }
	public Align alignContent { get; }
	public Align alignItems { get; }
	public Align alignSelf { get; }
	public Color backgroundColor { get; }
	public Background backgroundImage { get; }
	public BackgroundPosition backgroundPositionX { get; }
	public BackgroundPosition backgroundPositionY { get; }
	public BackgroundRepeat backgroundRepeat { get; }
	public BackgroundSize backgroundSize { get; }
	public Color borderBottomColor { get; }
	public Length borderBottomLeftRadius { get; }
	public Length borderBottomRightRadius { get; }
	public float borderBottomWidth { get; }
	public Color borderLeftColor { get; }
	public float borderLeftWidth { get; }
	public Color borderRightColor { get; }
	public float borderRightWidth { get; }
	public Color borderTopColor { get; }
	public Length borderTopLeftRadius { get; }
	public Length borderTopRightRadius { get; }
	public float borderTopWidth { get; }
	public Length bottom { get; }
	public Color color { get; }
	public Cursor cursor { get; }
	public DisplayStyle display { get; }
	public Length flexBasis { get; }
	public FlexDirection flexDirection { get; }
	public float flexGrow { get; }
	public float flexShrink { get; }
	public Wrap flexWrap { get; }
	public Length fontSize { get; }
	public Length height { get; }
	public Justify justifyContent { get; }
	public Length left { get; }
	public Length letterSpacing { get; }
	public Length marginBottom { get; }
	public Length marginLeft { get; }
	public Length marginRight { get; }
	public Length marginTop { get; }
	public Length maxHeight { get; }
	public Length maxWidth { get; }
	public Length minHeight { get; }
	public Length minWidth { get; }
	public float opacity { get; }
	public OverflowInternal overflow { get; }
	public Length paddingBottom { get; }
	public Length paddingLeft { get; }
	public Length paddingRight { get; }
	public Length paddingTop { get; }
	public Position position { get; }
	public Length right { get; }
	public Rotate rotate { get; }
	public Scale scale { get; }
	public TextOverflow textOverflow { get; }
	public TextShadow textShadow { get; }
	public Length top { get; }
	public TransformOrigin transformOrigin { get; }
	public List<TimeValue> transitionDelay { get; }
	public List<TimeValue> transitionDuration { get; }
	public List<StylePropertyName> transitionProperty { get; }
	public List<EasingFunction> transitionTimingFunction { get; }
	public Translate translate { get; }
	public Color unityBackgroundImageTintColor { get; }
	public Font unityFont { get; }
	public FontDefinition unityFontDefinition { get; }
	public FontStyle unityFontStyleAndWeight { get; }
	public OverflowClipBox unityOverflowClipBox { get; }
	public Length unityParagraphSpacing { get; }
	public int unitySliceBottom { get; }
	public int unitySliceLeft { get; }
	public int unitySliceRight { get; }
	public float unitySliceScale { get; }
	public int unitySliceTop { get; }
	public TextAnchor unityTextAlign { get; }
	public Color unityTextOutlineColor { get; }
	public float unityTextOutlineWidth { get; }
	public TextOverflowPosition unityTextOverflowPosition { get; }
	public Visibility visibility { get; }
	public WhiteSpace whiteSpace { get; }
	public Length width { get; }
	public Length wordSpacing { get; }

	// Methods

	// RVA: 0x268AD40 Offset: 0x2689F40 VA: 0x18268AD40
	public int get_customPropertiesCount() { }

	// RVA: 0x268AF50 Offset: 0x268A150 VA: 0x18268AF50
	public bool get_hasTransition() { }

	// RVA: 0x267FBD0 Offset: 0x267EDD0 VA: 0x18267FBD0
	public void FinalizeApply(ref ComputedStyle parentStyle) { }

	// RVA: 0x2689CF0 Offset: 0x2688EF0 VA: 0x182689CF0
	public void SyncWithLayout(YogaNode targetNode) { }

	// RVA: 0x2675D00 Offset: 0x2674F00 VA: 0x182675D00
	private bool ApplyGlobalKeyword(StylePropertyReader reader, ref ComputedStyle parentStyle) { }

	// RVA: 0x2675DC0 Offset: 0x2674FC0 VA: 0x182675DC0
	private bool ApplyGlobalKeyword(StylePropertyId id, StyleKeyword keyword, ref ComputedStyle parentStyle) { }

	// RVA: 0x267FE20 Offset: 0x267F020 VA: 0x18267FE20
	private void RemoveCustomStyleProperty(StylePropertyReader reader) { }

	// RVA: 0x2674560 Offset: 0x2673760 VA: 0x182674560
	private void ApplyCustomStyleProperty(StylePropertyReader reader) { }

	// RVA: 0x2674500 Offset: 0x2673700 VA: 0x182674500
	private void ApplyAllPropertyInitial() { }

	// RVA: 0x82FAE0 Offset: 0x82ECE0 VA: 0x18082FAE0
	private void ResetComputedTransitions() { }

	// RVA: 0x2682A00 Offset: 0x2681C00 VA: 0x182682A00
	public static bool StartAnimationInlineTranslate(VisualElement element, ref ComputedStyle computedStyle, StyleTranslate translate, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x268A5E0 Offset: 0x26897E0 VA: 0x18268A5E0
	public Align get_alignContent() { }

	// RVA: 0x268A620 Offset: 0x2689820 VA: 0x18268A620
	public Align get_alignItems() { }

	// RVA: 0x268A660 Offset: 0x2689860 VA: 0x18268A660
	public Align get_alignSelf() { }

	// RVA: 0x268A6A0 Offset: 0x26898A0 VA: 0x18268A6A0
	public Color get_backgroundColor() { }

	// RVA: 0x268A6F0 Offset: 0x26898F0 VA: 0x18268A6F0
	public Background get_backgroundImage() { }

	// RVA: 0x268A750 Offset: 0x2689950 VA: 0x18268A750
	public BackgroundPosition get_backgroundPositionX() { }

	// RVA: 0x268A7B0 Offset: 0x26899B0 VA: 0x18268A7B0
	public BackgroundPosition get_backgroundPositionY() { }

	// RVA: 0x268A810 Offset: 0x2689A10 VA: 0x18268A810
	public BackgroundRepeat get_backgroundRepeat() { }

	// RVA: 0x268A850 Offset: 0x2689A50 VA: 0x18268A850
	public BackgroundSize get_backgroundSize() { }

	// RVA: 0x268A8B0 Offset: 0x2689AB0 VA: 0x18268A8B0
	public Color get_borderBottomColor() { }

	// RVA: 0x268A910 Offset: 0x2689B10 VA: 0x18268A910
	public Length get_borderBottomLeftRadius() { }

	// RVA: 0x268A950 Offset: 0x2689B50 VA: 0x18268A950
	public Length get_borderBottomRightRadius() { }

	// RVA: 0x268A990 Offset: 0x2689B90 VA: 0x18268A990
	public float get_borderBottomWidth() { }

	// RVA: 0x268A9D0 Offset: 0x2689BD0 VA: 0x18268A9D0
	public Color get_borderLeftColor() { }

	// RVA: 0x268AA30 Offset: 0x2689C30 VA: 0x18268AA30
	public float get_borderLeftWidth() { }

	// RVA: 0x268AA70 Offset: 0x2689C70 VA: 0x18268AA70
	public Color get_borderRightColor() { }

	// RVA: 0x268AAD0 Offset: 0x2689CD0 VA: 0x18268AAD0
	public float get_borderRightWidth() { }

	// RVA: 0x268AB10 Offset: 0x2689D10 VA: 0x18268AB10
	public Color get_borderTopColor() { }

	// RVA: 0x268AB70 Offset: 0x2689D70 VA: 0x18268AB70
	public Length get_borderTopLeftRadius() { }

	// RVA: 0x268ABC0 Offset: 0x2689DC0 VA: 0x18268ABC0
	public Length get_borderTopRightRadius() { }

	// RVA: 0x268AC10 Offset: 0x2689E10 VA: 0x18268AC10
	public float get_borderTopWidth() { }

	// RVA: 0x268AC50 Offset: 0x2689E50 VA: 0x18268AC50
	public Length get_bottom() { }

	// RVA: 0x268AC90 Offset: 0x2689E90 VA: 0x18268AC90
	public Color get_color() { }

	// RVA: 0x268ACE0 Offset: 0x2689EE0 VA: 0x18268ACE0
	public Cursor get_cursor() { }

	// RVA: 0x268AD90 Offset: 0x2689F90 VA: 0x18268AD90
	public DisplayStyle get_display() { }

	// RVA: 0x268ADD0 Offset: 0x2689FD0 VA: 0x18268ADD0
	public Length get_flexBasis() { }

	// RVA: 0x268AE10 Offset: 0x268A010 VA: 0x18268AE10
	public FlexDirection get_flexDirection() { }

	// RVA: 0x268AE50 Offset: 0x268A050 VA: 0x18268AE50
	public float get_flexGrow() { }

	// RVA: 0x268AE90 Offset: 0x268A090 VA: 0x18268AE90
	public float get_flexShrink() { }

	// RVA: 0x268AED0 Offset: 0x268A0D0 VA: 0x18268AED0
	public Wrap get_flexWrap() { }

	// RVA: 0x268AF10 Offset: 0x268A110 VA: 0x18268AF10
	public Length get_fontSize() { }

	// RVA: 0x268AF70 Offset: 0x268A170 VA: 0x18268AF70
	public Length get_height() { }

	// RVA: 0x268AFB0 Offset: 0x268A1B0 VA: 0x18268AFB0
	public Justify get_justifyContent() { }

	// RVA: 0x268AFF0 Offset: 0x268A1F0 VA: 0x18268AFF0
	public Length get_left() { }

	// RVA: 0x268B030 Offset: 0x268A230 VA: 0x18268B030
	public Length get_letterSpacing() { }

	// RVA: 0x268B070 Offset: 0x268A270 VA: 0x18268B070
	public Length get_marginBottom() { }

	// RVA: 0x268B0B0 Offset: 0x268A2B0 VA: 0x18268B0B0
	public Length get_marginLeft() { }

	// RVA: 0x268B0F0 Offset: 0x268A2F0 VA: 0x18268B0F0
	public Length get_marginRight() { }

	// RVA: 0x268B130 Offset: 0x268A330 VA: 0x18268B130
	public Length get_marginTop() { }

	// RVA: 0x268B170 Offset: 0x268A370 VA: 0x18268B170
	public Length get_maxHeight() { }

	// RVA: 0x268B1B0 Offset: 0x268A3B0 VA: 0x18268B1B0
	public Length get_maxWidth() { }

	// RVA: 0x268B1F0 Offset: 0x268A3F0 VA: 0x18268B1F0
	public Length get_minHeight() { }

	// RVA: 0x268B240 Offset: 0x268A440 VA: 0x18268B240
	public Length get_minWidth() { }

	// RVA: 0x268B290 Offset: 0x268A490 VA: 0x18268B290
	public float get_opacity() { }

	// RVA: 0x268B2E0 Offset: 0x268A4E0 VA: 0x18268B2E0
	public OverflowInternal get_overflow() { }

	// RVA: 0x268B330 Offset: 0x268A530 VA: 0x18268B330
	public Length get_paddingBottom() { }

	// RVA: 0x268B380 Offset: 0x268A580 VA: 0x18268B380
	public Length get_paddingLeft() { }

	// RVA: 0x268B3D0 Offset: 0x268A5D0 VA: 0x18268B3D0
	public Length get_paddingRight() { }

	// RVA: 0x268B420 Offset: 0x268A620 VA: 0x18268B420
	public Length get_paddingTop() { }

	// RVA: 0x268B470 Offset: 0x268A670 VA: 0x18268B470
	public Position get_position() { }

	// RVA: 0x268B4C0 Offset: 0x268A6C0 VA: 0x18268B4C0
	public Length get_right() { }

	// RVA: 0x268B510 Offset: 0x268A710 VA: 0x18268B510
	public Rotate get_rotate() { }

	// RVA: 0x268B570 Offset: 0x268A770 VA: 0x18268B570
	public Scale get_scale() { }

	// RVA: 0x268B5D0 Offset: 0x268A7D0 VA: 0x18268B5D0
	public TextOverflow get_textOverflow() { }

	// RVA: 0x268B610 Offset: 0x268A810 VA: 0x18268B610
	public TextShadow get_textShadow() { }

	// RVA: 0x268B670 Offset: 0x268A870 VA: 0x18268B670
	public Length get_top() { }

	// RVA: 0x268B6C0 Offset: 0x268A8C0 VA: 0x18268B6C0
	public TransformOrigin get_transformOrigin() { }

	// RVA: 0x268B720 Offset: 0x268A920 VA: 0x18268B720
	public List<TimeValue> get_transitionDelay() { }

	// RVA: 0x268B760 Offset: 0x268A960 VA: 0x18268B760
	public List<TimeValue> get_transitionDuration() { }

	// RVA: 0x268B7A0 Offset: 0x268A9A0 VA: 0x18268B7A0
	public List<StylePropertyName> get_transitionProperty() { }

	// RVA: 0x268B7E0 Offset: 0x268A9E0 VA: 0x18268B7E0
	public List<EasingFunction> get_transitionTimingFunction() { }

	// RVA: 0x268B820 Offset: 0x268AA20 VA: 0x18268B820
	public Translate get_translate() { }

	// RVA: 0x268B880 Offset: 0x268AA80 VA: 0x18268B880
	public Color get_unityBackgroundImageTintColor() { }

	// RVA: 0x268B970 Offset: 0x268AB70 VA: 0x18268B970
	public Font get_unityFont() { }

	// RVA: 0x268B8E0 Offset: 0x268AAE0 VA: 0x18268B8E0
	public FontDefinition get_unityFontDefinition() { }

	// RVA: 0x268B930 Offset: 0x268AB30 VA: 0x18268B930
	public FontStyle get_unityFontStyleAndWeight() { }

	// RVA: 0x268B9B0 Offset: 0x268ABB0 VA: 0x18268B9B0
	public OverflowClipBox get_unityOverflowClipBox() { }

	// RVA: 0x268B9F0 Offset: 0x268ABF0 VA: 0x18268B9F0
	public Length get_unityParagraphSpacing() { }

	// RVA: 0x268BA30 Offset: 0x268AC30 VA: 0x18268BA30
	public int get_unitySliceBottom() { }

	// RVA: 0x268BA70 Offset: 0x268AC70 VA: 0x18268BA70
	public int get_unitySliceLeft() { }

	// RVA: 0x268BAB0 Offset: 0x268ACB0 VA: 0x18268BAB0
	public int get_unitySliceRight() { }

	// RVA: 0x268BAF0 Offset: 0x268ACF0 VA: 0x18268BAF0
	public float get_unitySliceScale() { }

	// RVA: 0x268BB30 Offset: 0x268AD30 VA: 0x18268BB30
	public int get_unitySliceTop() { }

	// RVA: 0x268BB70 Offset: 0x268AD70 VA: 0x18268BB70
	public TextAnchor get_unityTextAlign() { }

	// RVA: 0x268BBB0 Offset: 0x268ADB0 VA: 0x18268BBB0
	public Color get_unityTextOutlineColor() { }

	// RVA: 0x268BC00 Offset: 0x268AE00 VA: 0x18268BC00
	public float get_unityTextOutlineWidth() { }

	// RVA: 0x268BC40 Offset: 0x268AE40 VA: 0x18268BC40
	public TextOverflowPosition get_unityTextOverflowPosition() { }

	// RVA: 0x268BC80 Offset: 0x268AE80 VA: 0x18268BC80
	public Visibility get_visibility() { }

	// RVA: 0x268BCC0 Offset: 0x268AEC0 VA: 0x18268BCC0
	public WhiteSpace get_whiteSpace() { }

	// RVA: 0x268BD00 Offset: 0x268AF00 VA: 0x18268BD00
	public Length get_width() { }

	// RVA: 0x268BD50 Offset: 0x268AF50 VA: 0x18268BD50
	public Length get_wordSpacing() { }

	// RVA: 0x267FA00 Offset: 0x267EC00 VA: 0x18267FA00
	public static ComputedStyle Create(ref ComputedStyle parentStyle) { }

	// RVA: 0x267F880 Offset: 0x267EA80 VA: 0x18267F880
	public static ComputedStyle CreateInitial() { }

	// RVA: 0x26743D0 Offset: 0x26735D0 VA: 0x1826743D0
	public ComputedStyle Acquire() { }

	// RVA: 0x267FD50 Offset: 0x267EF50 VA: 0x18267FD50
	public void Release() { }

	// RVA: 0x267F770 Offset: 0x267E970 VA: 0x18267F770
	public void CopyFrom(ref ComputedStyle other) { }

	// RVA: 0x2677EB0 Offset: 0x26770B0 VA: 0x182677EB0
	public void ApplyProperties(StylePropertyReader reader, ref ComputedStyle parentStyle) { }

	// RVA: 0x267C5A0 Offset: 0x267B7A0 VA: 0x18267C5A0
	public void ApplyStyleValue(StyleValue sv, ref ComputedStyle parentStyle) { }

	// RVA: 0x267C0C0 Offset: 0x267B2C0 VA: 0x18267C0C0
	public void ApplyStyleValueManaged(StyleValueManaged sv, ref ComputedStyle parentStyle) { }

	// RVA: 0x267BE90 Offset: 0x267B090 VA: 0x18267BE90
	public void ApplyStyleCursor(Cursor cursor) { }

	// RVA: 0x267BFA0 Offset: 0x267B1A0 VA: 0x18267BFA0
	public void ApplyStyleTextShadow(TextShadow st) { }

	// RVA: 0x2674660 Offset: 0x2673860 VA: 0x182674660
	public void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle other) { }

	// RVA: 0x2679D60 Offset: 0x2678F60 VA: 0x182679D60
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Length newValue) { }

	// RVA: 0x2679870 Offset: 0x2678A70 VA: 0x182679870
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, float newValue) { }

	// RVA: 0x267A7C0 Offset: 0x26799C0 VA: 0x18267A7C0
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, int newValue) { }

	// RVA: 0x267B690 Offset: 0x267A890 VA: 0x18267B690
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundPosition newValue) { }

	// RVA: 0x267B220 Offset: 0x267A420 VA: 0x18267B220
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundRepeat newValue) { }

	// RVA: 0x2679C10 Offset: 0x2678E10 VA: 0x182679C10
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundSize newValue) { }

	// RVA: 0x267BB80 Offset: 0x267AD80 VA: 0x18267BB80
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Color newValue) { }

	// RVA: 0x267B4E0 Offset: 0x267A6E0 VA: 0x18267B4E0
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Background newValue) { }

	// RVA: 0x267A630 Offset: 0x2679830 VA: 0x18267A630
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Font newValue) { }

	// RVA: 0x267B8B0 Offset: 0x267AAB0 VA: 0x18267B8B0
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, FontDefinition newValue) { }

	// RVA: 0x267BA30 Offset: 0x267AC30 VA: 0x18267BA30
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TextShadow newValue) { }

	// RVA: 0x267AF90 Offset: 0x267A190 VA: 0x18267AF90
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Translate newValue) { }

	// RVA: 0x267B390 Offset: 0x267A590 VA: 0x18267B390
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TransformOrigin newValue) { }

	// RVA: 0x2679720 Offset: 0x2678920 VA: 0x182679720
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Rotate newValue) { }

	// RVA: 0x267B0E0 Offset: 0x267A2E0 VA: 0x18267B0E0
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Scale newValue) { }

	// RVA: 0x2685F40 Offset: 0x2685140 VA: 0x182685F40
	public static bool StartAnimation(VisualElement element, StylePropertyId id, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x267FEC0 Offset: 0x267F0C0 VA: 0x18267FEC0
	public static bool StartAnimationAllProperty(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2682C30 Offset: 0x2681E30 VA: 0x182682C30
	public static bool StartAnimationInline(VisualElement element, StylePropertyId id, ref ComputedStyle computedStyle, StyleValue sv, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x267C000 Offset: 0x267B200 VA: 0x18267C000
	public void ApplyStyleTransformOrigin(TransformOrigin st) { }

	// RVA: 0x267C060 Offset: 0x267B260 VA: 0x18267C060
	public void ApplyStyleTranslate(Translate translateValue) { }

	// RVA: 0x267BEF0 Offset: 0x267B0F0 VA: 0x18267BEF0
	public void ApplyStyleRotate(Rotate rotateValue) { }

	// RVA: 0x267BF50 Offset: 0x267B150 VA: 0x18267BF50
	public void ApplyStyleScale(Scale scaleValue) { }

	// RVA: 0x267BE30 Offset: 0x267B030 VA: 0x18267BE30
	public void ApplyStyleBackgroundSize(BackgroundSize backgroundSizeValue) { }

	// RVA: 0x2675DE0 Offset: 0x2674FE0 VA: 0x182675DE0
	public void ApplyInitialValue(StylePropertyReader reader) { }

	// RVA: 0x2675F00 Offset: 0x2675100 VA: 0x182675F00
	public void ApplyInitialValue(StylePropertyId id) { }

	// RVA: 0x267D680 Offset: 0x267C880 VA: 0x18267D680
	public void ApplyUnsetValue(StylePropertyReader reader, ref ComputedStyle parentStyle) { }

	// RVA: 0x267D740 Offset: 0x267C940 VA: 0x18267D740
	public void ApplyUnsetValue(StylePropertyId id, ref ComputedStyle parentStyle) { }

	// RVA: 0x267DB40 Offset: 0x267CD40 VA: 0x18267DB40
	public static VersionChangeType CompareChanges(ref ComputedStyle x, ref ComputedStyle y) { }
}

// Namespace: UnityEngine.UIElements
internal struct ComputedTransitionProperty // TypeDefIndex: 11404
{
	// Fields
	public StylePropertyId id; // 0x0
	public int durationMs; // 0x4
	public int delayMs; // 0x8
	public Func<float, float> easingCurve; // 0x10
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ComputedTransitionUtils.<>c // TypeDefIndex: 11405
{
	// Fields
	public static readonly ComputedTransitionUtils.<>c <>9; // 0x0
	public static Func<float, float> <>9__12_0; // 0x8
	public static Func<float, float> <>9__12_1; // 0x10
	public static Func<float, float> <>9__12_2; // 0x18
	public static Func<float, float> <>9__12_3; // 0x20
	public static Func<float, float> <>9__12_4; // 0x28
	public static Func<float, float> <>9__12_5; // 0x30
	public static Func<float, float> <>9__12_6; // 0x38
	public static Func<float, float> <>9__12_7; // 0x40
	public static Func<float, float> <>9__12_8; // 0x48
	public static Func<float, float> <>9__12_9; // 0x50
	public static Func<float, float> <>9__12_10; // 0x58
	public static Func<float, float> <>9__12_11; // 0x60
	public static Func<float, float> <>9__12_12; // 0x68
	public static Func<float, float> <>9__12_13; // 0x70
	public static Func<float, float> <>9__12_14; // 0x78
	public static Func<float, float> <>9__12_15; // 0x80
	public static Func<float, float> <>9__12_16; // 0x88
	public static Func<float, float> <>9__12_17; // 0x90
	public static Func<float, float> <>9__12_18; // 0x98
	public static Func<float, float> <>9__12_19; // 0xA0
	public static Func<float, float> <>9__12_20; // 0xA8
	public static Func<float, float> <>9__12_21; // 0xB0
	public static Func<float, float> <>9__12_22; // 0xB8

	// Methods

	// RVA: 0x269D5E0 Offset: 0x269C7E0 VA: 0x18269D5E0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x269D290 Offset: 0x269C490 VA: 0x18269D290
	internal float <ConvertTransitionFunction>b__12_0(float t) { }

	// RVA: 0x269D360 Offset: 0x269C560 VA: 0x18269D360
	internal float <ConvertTransitionFunction>b__12_1(float t) { }

	// RVA: 0x269D3A0 Offset: 0x269C5A0 VA: 0x18269D3A0
	internal float <ConvertTransitionFunction>b__12_2(float t) { }

	// RVA: 0x269D3B0 Offset: 0x269C5B0 VA: 0x18269D3B0
	internal float <ConvertTransitionFunction>b__12_3(float t) { }

	// RVA: 0x269D3C0 Offset: 0x269C5C0 VA: 0x18269D3C0
	internal float <ConvertTransitionFunction>b__12_4(float t) { }

	// RVA: 0x269D3D0 Offset: 0x269C5D0 VA: 0x18269D3D0
	internal float <ConvertTransitionFunction>b__12_5(float t) { }

	// RVA: 0x269D3E0 Offset: 0x269C5E0 VA: 0x18269D3E0
	internal float <ConvertTransitionFunction>b__12_6(float t) { }

	// RVA: 0x269D3F0 Offset: 0x269C5F0 VA: 0x18269D3F0
	internal float <ConvertTransitionFunction>b__12_7(float t) { }

	// RVA: 0x269D400 Offset: 0x269C600 VA: 0x18269D400
	internal float <ConvertTransitionFunction>b__12_8(float t) { }

	// RVA: 0x269D410 Offset: 0x269C610 VA: 0x18269D410
	internal float <ConvertTransitionFunction>b__12_9(float t) { }

	// RVA: 0x269D2C0 Offset: 0x269C4C0 VA: 0x18269D2C0
	internal float <ConvertTransitionFunction>b__12_10(float t) { }

	// RVA: 0x269D2D0 Offset: 0x269C4D0 VA: 0x18269D2D0
	internal float <ConvertTransitionFunction>b__12_11(float t) { }

	// RVA: 0x269D2E0 Offset: 0x269C4E0 VA: 0x18269D2E0
	internal float <ConvertTransitionFunction>b__12_12(float t) { }

	// RVA: 0x269D2F0 Offset: 0x269C4F0 VA: 0x18269D2F0
	internal float <ConvertTransitionFunction>b__12_13(float t) { }

	// RVA: 0x269D300 Offset: 0x269C500 VA: 0x18269D300
	internal float <ConvertTransitionFunction>b__12_14(float t) { }

	// RVA: 0x269D310 Offset: 0x269C510 VA: 0x18269D310
	internal float <ConvertTransitionFunction>b__12_15(float t) { }

	// RVA: 0x269D320 Offset: 0x269C520 VA: 0x18269D320
	internal float <ConvertTransitionFunction>b__12_16(float t) { }

	// RVA: 0x269D330 Offset: 0x269C530 VA: 0x18269D330
	internal float <ConvertTransitionFunction>b__12_17(float t) { }

	// RVA: 0x269D340 Offset: 0x269C540 VA: 0x18269D340
	internal float <ConvertTransitionFunction>b__12_18(float t) { }

	// RVA: 0x269D350 Offset: 0x269C550 VA: 0x18269D350
	internal float <ConvertTransitionFunction>b__12_19(float t) { }

	// RVA: 0x269D370 Offset: 0x269C570 VA: 0x18269D370
	internal float <ConvertTransitionFunction>b__12_20(float t) { }

	// RVA: 0x269D380 Offset: 0x269C580 VA: 0x18269D380
	internal float <ConvertTransitionFunction>b__12_21(float t) { }

	// RVA: 0x269D390 Offset: 0x269C590 VA: 0x18269D390
	internal float <ConvertTransitionFunction>b__12_22(float t) { }
}

// Namespace: UnityEngine.UIElements
[Extension]
internal static class ComputedTransitionUtils // TypeDefIndex: 11406
{
	// Fields
	private static List<ComputedTransitionProperty> s_ComputedTransitionsBuffer; // 0x0

	// Methods

	// RVA: 0x2690E90 Offset: 0x2690090 VA: 0x182690E90
	internal static void UpdateComputedTransitions(ref ComputedStyle computedStyle) { }

	[Extension]
	// RVA: 0x2690990 Offset: 0x268FB90 VA: 0x182690990
	internal static bool HasTransitionProperty(ref ComputedStyle computedStyle, StylePropertyId id) { }

	[Extension]
	// RVA: 0x2690860 Offset: 0x268FA60 VA: 0x182690860
	internal static bool GetTransitionProperty(ref ComputedStyle computedStyle, StylePropertyId id, out ComputedTransitionProperty result) { }

	// RVA: 0x2690230 Offset: 0x268F430 VA: 0x182690230
	private static ComputedTransitionProperty[] GetOrComputeTransitionPropertyData(ref ComputedStyle computedStyle) { }

	// RVA: 0x26903F0 Offset: 0x268F5F0 VA: 0x1826903F0
	private static int GetTransitionHashCode(ref ComputedStyle cs) { }

	// RVA: 0x2690B90 Offset: 0x268FD90 VA: 0x182690B90
	internal static bool SameTransitionProperty(ref ComputedStyle x, ref ComputedStyle y) { }

	// RVA: 0x2690A70 Offset: 0x268FC70 VA: 0x182690A70
	private static bool SameTransitionProperty(List<StylePropertyName> a, List<StylePropertyName> b) { }

	// RVA: 0x2690D90 Offset: 0x268FF90 VA: 0x182690D90
	private static bool SameTransitionProperty(List<TimeValue> a, List<TimeValue> b) { }

	// RVA: 0x268EFB0 Offset: 0x268E1B0 VA: 0x18268EFB0
	private static void ComputeTransitionPropertyData(ref ComputedStyle computedStyle, List<ComputedTransitionProperty> outData) { }

	// RVA: -1 Offset: -1
	private static T GetWrappingTransitionData<T>(List<T> list, int i, T defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94E580 Offset: 0x94D780 VA: 0x18094E580
	|-ComputedTransitionUtils.GetWrappingTransitionData<EasingFunction>
	|
	|-RVA: 0x94E7A0 Offset: 0x94D9A0 VA: 0x18094E7A0
	|-ComputedTransitionUtils.GetWrappingTransitionData<TimeValue>
	|
	|-RVA: 0x94E5F0 Offset: 0x94D7F0 VA: 0x18094E5F0
	|-ComputedTransitionUtils.GetWrappingTransitionData<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2690200 Offset: 0x268F400 VA: 0x182690200
	private static int ConvertTransitionTime(TimeValue time) { }

	// RVA: 0x268F2F0 Offset: 0x268E4F0 VA: 0x18268F2F0
	private static Func<float, float> ConvertTransitionFunction(EasingMode mode) { }

	// RVA: 0x2691090 Offset: 0x2690290 VA: 0x182691090
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements
public struct CustomStyleProperty<T> : IEquatable<CustomStyleProperty<T>> // TypeDefIndex: 11407
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <name>k__BackingField; // 0x0

	// Properties
	public string name { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: -1 Offset: -1
	public string get_name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	|-CustomStyleProperty<Color>.get_name
	|-CustomStyleProperty<int>.get_name
	|-CustomStyleProperty<object>.get_name
	|-CustomStyleProperty<float>.get_name
	|-CustomStyleProperty<__Il2CppFullySharedGenericType>.get_name
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_name(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	|-CustomStyleProperty<Color>.set_name
	|-CustomStyleProperty<int>.set_name
	|-CustomStyleProperty<object>.set_name
	|-CustomStyleProperty<float>.set_name
	|-CustomStyleProperty<__Il2CppFullySharedGenericType>.set_name
	*/

	// RVA: -1 Offset: -1
	public void .ctor(string propertyName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFBB7E0 Offset: 0xFBA9E0 VA: 0x180FBB7E0
	|-CustomStyleProperty<Color>..ctor
	|
	|-RVA: 0xFBBA00 Offset: 0xFBAC00 VA: 0x180FBBA00
	|-CustomStyleProperty<int>..ctor
	|
	|-RVA: 0xFBBBE0 Offset: 0xFBADE0 VA: 0x180FBBBE0
	|-CustomStyleProperty<object>..ctor
	|
	|-RVA: 0xFBBAF0 Offset: 0xFBACF0 VA: 0x180FBBAF0
	|-CustomStyleProperty<float>..ctor
	|
	|-RVA: 0xFBB8D0 Offset: 0xFBAAD0 VA: 0x180FBB8D0
	|-CustomStyleProperty<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFBB500 Offset: 0xFBA700 VA: 0x180FBB500
	|-CustomStyleProperty<Color>.Equals
	|-CustomStyleProperty<int>.Equals
	|-CustomStyleProperty<object>.Equals
	|-CustomStyleProperty<float>.Equals
	|
	|-RVA: 0xFBB3D0 Offset: 0xFBA5D0 VA: 0x180FBB3D0
	|-CustomStyleProperty<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(CustomStyleProperty<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFBB370 Offset: 0xFBA570 VA: 0x180FBB370
	|-CustomStyleProperty<Color>.Equals
	|-CustomStyleProperty<int>.Equals
	|-CustomStyleProperty<object>.Equals
	|-CustomStyleProperty<float>.Equals
	|
	|-RVA: 0xFBB630 Offset: 0xFBA830 VA: 0x180FBB630
	|-CustomStyleProperty<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFBB700 Offset: 0xFBA900 VA: 0x180FBB700
	|-CustomStyleProperty<Color>.GetHashCode
	|-CustomStyleProperty<int>.GetHashCode
	|-CustomStyleProperty<object>.GetHashCode
	|-CustomStyleProperty<float>.GetHashCode
	|
	|-RVA: 0xFBB750 Offset: 0xFBA950 VA: 0x180FBB750
	|-CustomStyleProperty<__Il2CppFullySharedGenericType>.GetHashCode
	*/
}

// Namespace: UnityEngine.UIElements
public interface ICustomStyle // TypeDefIndex: 11408
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TryGetValue(CustomStyleProperty<float> property, out float value);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool TryGetValue(CustomStyleProperty<int> property, out int value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool TryGetValue(CustomStyleProperty<Color> property, out Color value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool TryGetValue(CustomStyleProperty<Texture2D> property, out Texture2D value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool TryGetValue(CustomStyleProperty<Sprite> property, out Sprite value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool TryGetValue(CustomStyleProperty<VectorImage> property, out VectorImage value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool TryGetValue(CustomStyleProperty<string> property, out string value);
}

// Namespace: UnityEngine.UIElements
public enum EasingMode // TypeDefIndex: 11409
{
	// Fields
	public int value__; // 0x0
	public const EasingMode Ease = 0;
	public const EasingMode EaseIn = 1;
	public const EasingMode EaseOut = 2;
	public const EasingMode EaseInOut = 3;
	public const EasingMode Linear = 4;
	public const EasingMode EaseInSine = 5;
	public const EasingMode EaseOutSine = 6;
	public const EasingMode EaseInOutSine = 7;
	public const EasingMode EaseInCubic = 8;
	public const EasingMode EaseOutCubic = 9;
	public const EasingMode EaseInOutCubic = 10;
	public const EasingMode EaseInCirc = 11;
	public const EasingMode EaseOutCirc = 12;
	public const EasingMode EaseInOutCirc = 13;
	public const EasingMode EaseInElastic = 14;
	public const EasingMode EaseOutElastic = 15;
	public const EasingMode EaseInOutElastic = 16;
	public const EasingMode EaseInBack = 17;
	public const EasingMode EaseOutBack = 18;
	public const EasingMode EaseInOutBack = 19;
	public const EasingMode EaseInBounce = 20;
	public const EasingMode EaseOutBounce = 21;
	public const EasingMode EaseInOutBounce = 22;
}

// Namespace: UnityEngine.UIElements
public struct EasingFunction : IEquatable<EasingFunction> // TypeDefIndex: 11410
{
	// Fields
	private EasingMode m_Mode; // 0x0

	// Properties
	public EasingMode mode { get; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public EasingMode get_mode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void .ctor(EasingMode mode) { }

	// RVA: 0x2493430 Offset: 0x2492630 VA: 0x182493430
	public static EasingFunction op_Implicit(EasingMode easingMode) { }

	// RVA: 0x2499330 Offset: 0x2498530 VA: 0x182499330
	public static bool op_Equality(EasingFunction lhs, EasingFunction rhs) { }

	// RVA: 0x26920E0 Offset: 0x26912E0 VA: 0x1826920E0 Slot: 4
	public bool Equals(EasingFunction other) { }

	// RVA: 0x2692050 Offset: 0x2691250 VA: 0x182692050 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26920F0 Offset: 0x26912F0 VA: 0x1826920F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x244E020 Offset: 0x244D220 VA: 0x18244E020 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.UIElements
public struct FontDefinition : IEquatable<FontDefinition> // TypeDefIndex: 11411
{
	// Fields
	private Font m_Font; // 0x0
	private FontAsset m_FontAsset; // 0x8

	// Properties
	public Font font { get; }
	public FontAsset fontAsset { get; }

	// Methods

	// RVA: 0xA55380 Offset: 0xA54580 VA: 0x180A55380
	public Font get_font() { }

	// RVA: 0x1808BB0 Offset: 0x1807DB0 VA: 0x181808BB0
	public FontAsset get_fontAsset() { }

	// RVA: 0x2692250 Offset: 0x2691450 VA: 0x182692250
	public static FontDefinition FromFont(Font f) { }

	// RVA: 0x26923C0 Offset: 0x26915C0 VA: 0x1826923C0
	public static FontDefinition FromSDFFont(FontAsset f) { }

	// RVA: 0x2692270 Offset: 0x2691470 VA: 0x182692270
	internal static FontDefinition FromObject(object obj) { }

	// RVA: 0x26924D0 Offset: 0x26916D0 VA: 0x1826924D0
	internal bool IsEmpty() { }

	// RVA: 0x2692560 Offset: 0x2691760 VA: 0x182692560 Slot: 3
	public override string ToString() { }

	// RVA: 0x2692200 Offset: 0x2691400 VA: 0x182692200 Slot: 4
	public bool Equals(FontDefinition other) { }

	// RVA: 0x2692150 Offset: 0x2691350 VA: 0x182692150 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26923E0 Offset: 0x26915E0 VA: 0x1826923E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2692200 Offset: 0x2691400 VA: 0x182692200
	public static bool op_Equality(FontDefinition left, FontDefinition right) { }

	// RVA: 0x2230120 Offset: 0x222F320 VA: 0x182230120
	public static bool op_Inequality(FontDefinition left, FontDefinition right) { }
}

// Namespace: 
internal struct InlineStyleAccess.InlineRule // TypeDefIndex: 11412
{
	// Fields
	public StyleSheet sheet; // 0x0
	public StyleRule rule; // 0x8
	public StylePropertyId[] propertyIds; // 0x10
}

// Namespace: UnityEngine.UIElements
internal class InlineStyleAccess : StyleValueCollection, IStyle // TypeDefIndex: 11413
{
	// Fields
	private static StylePropertyReader s_StylePropertyReader; // 0x0
	private List<StyleValueManaged> m_ValuesManaged; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VisualElement <ve>k__BackingField; // 0x20
	private bool m_HasInlineCursor; // 0x28
	private StyleCursor m_InlineCursor; // 0x30
	private bool m_HasInlineTextShadow; // 0x50
	private StyleTextShadow m_InlineTextShadow; // 0x54
	private bool m_HasInlineTransformOrigin; // 0x74
	private StyleTransformOrigin m_InlineTransformOrigin; // 0x78
	private bool m_HasInlineTranslate; // 0x90
	private StyleTranslate m_InlineTranslateOperation; // 0x94
	private bool m_HasInlineRotate; // 0xB0
	private StyleRotate m_InlineRotateOperation; // 0xB4
	private bool m_HasInlineScale; // 0xD0
	private StyleScale m_InlineScale; // 0xD4
	private bool m_HasInlineBackgroundSize; // 0xE8
	public StyleBackgroundSize m_InlineBackgroundSize; // 0xEC
	private InlineStyleAccess.InlineRule m_InlineRule; // 0x108

	// Properties
	private StyleColor UnityEngine.UIElements.IStyle.backgroundColor { set; }
	private StyleColor UnityEngine.UIElements.IStyle.borderBottomColor { set; }
	private StyleLength UnityEngine.UIElements.IStyle.borderBottomLeftRadius { set; }
	private StyleLength UnityEngine.UIElements.IStyle.borderBottomRightRadius { set; }
	private StyleFloat UnityEngine.UIElements.IStyle.borderBottomWidth { set; }
	private StyleColor UnityEngine.UIElements.IStyle.borderLeftColor { set; }
	private StyleFloat UnityEngine.UIElements.IStyle.borderLeftWidth { set; }
	private StyleColor UnityEngine.UIElements.IStyle.borderRightColor { set; }
	private StyleFloat UnityEngine.UIElements.IStyle.borderRightWidth { set; }
	private StyleColor UnityEngine.UIElements.IStyle.borderTopColor { set; }
	private StyleLength UnityEngine.UIElements.IStyle.borderTopLeftRadius { set; }
	private StyleLength UnityEngine.UIElements.IStyle.borderTopRightRadius { set; }
	private StyleFloat UnityEngine.UIElements.IStyle.borderTopWidth { set; }
	private StyleLength UnityEngine.UIElements.IStyle.bottom { set; }
	private StyleColor UnityEngine.UIElements.IStyle.color { set; }
	private StyleEnum<DisplayStyle> UnityEngine.UIElements.IStyle.display { get; set; }
	private StyleLength UnityEngine.UIElements.IStyle.flexBasis { set; }
	private StyleEnum<FlexDirection> UnityEngine.UIElements.IStyle.flexDirection { set; }
	private StyleFloat UnityEngine.UIElements.IStyle.flexGrow { set; }
	private StyleFloat UnityEngine.UIElements.IStyle.flexShrink { set; }
	private StyleLength UnityEngine.UIElements.IStyle.fontSize { set; }
	private StyleLength UnityEngine.UIElements.IStyle.height { set; }
	private StyleLength UnityEngine.UIElements.IStyle.left { set; }
	private StyleLength UnityEngine.UIElements.IStyle.marginBottom { set; }
	private StyleLength UnityEngine.UIElements.IStyle.marginLeft { set; }
	private StyleLength UnityEngine.UIElements.IStyle.marginRight { set; }
	private StyleLength UnityEngine.UIElements.IStyle.marginTop { set; }
	private StyleLength UnityEngine.UIElements.IStyle.maxHeight { set; }
	private StyleLength UnityEngine.UIElements.IStyle.maxWidth { set; }
	private StyleLength UnityEngine.UIElements.IStyle.minWidth { set; }
	private StyleFloat UnityEngine.UIElements.IStyle.opacity { set; }
	private StyleEnum<Overflow> UnityEngine.UIElements.IStyle.overflow { set; }
	private StyleLength UnityEngine.UIElements.IStyle.paddingBottom { set; }
	private StyleLength UnityEngine.UIElements.IStyle.paddingLeft { set; }
	private StyleLength UnityEngine.UIElements.IStyle.paddingRight { set; }
	private StyleLength UnityEngine.UIElements.IStyle.paddingTop { get; set; }
	private StyleEnum<Position> UnityEngine.UIElements.IStyle.position { set; }
	private StyleLength UnityEngine.UIElements.IStyle.right { set; }
	private StyleLength UnityEngine.UIElements.IStyle.top { set; }
	private StyleColor UnityEngine.UIElements.IStyle.unityBackgroundImageTintColor { set; }
	private StyleFont UnityEngine.UIElements.IStyle.unityFont { set; }
	private StyleFontDefinition UnityEngine.UIElements.IStyle.unityFontDefinition { set; }
	private StyleEnum<Visibility> UnityEngine.UIElements.IStyle.visibility { set; }
	private StyleLength UnityEngine.UIElements.IStyle.width { get; set; }
	private VisualElement ve { get; set; }
	private StyleCursor UnityEngine.UIElements.IStyle.cursor { get; }
	private StyleTextShadow UnityEngine.UIElements.IStyle.textShadow { get; }
	private StyleBackgroundSize UnityEngine.UIElements.IStyle.backgroundSize { get; }
	private StyleTransformOrigin UnityEngine.UIElements.IStyle.transformOrigin { get; }
	private StyleTranslate UnityEngine.UIElements.IStyle.translate { get; set; }
	private StyleRotate UnityEngine.UIElements.IStyle.rotate { get; }
	private StyleScale UnityEngine.UIElements.IStyle.scale { get; }

	// Methods

	// RVA: 0x2695060 Offset: 0x2694260 VA: 0x182695060 Slot: 4
	private void UnityEngine.UIElements.IStyle.set_backgroundColor(StyleColor value) { }

	// RVA: 0x26950C0 Offset: 0x26942C0 VA: 0x1826950C0 Slot: 6
	private void UnityEngine.UIElements.IStyle.set_borderBottomColor(StyleColor value) { }

	// RVA: 0x2695120 Offset: 0x2694320 VA: 0x182695120 Slot: 7
	private void UnityEngine.UIElements.IStyle.set_borderBottomLeftRadius(StyleLength value) { }

	// RVA: 0x2695180 Offset: 0x2694380 VA: 0x182695180 Slot: 8
	private void UnityEngine.UIElements.IStyle.set_borderBottomRightRadius(StyleLength value) { }

	// RVA: 0x26951E0 Offset: 0x26943E0 VA: 0x1826951E0 Slot: 9
	private void UnityEngine.UIElements.IStyle.set_borderBottomWidth(StyleFloat value) { }

	// RVA: 0x2695260 Offset: 0x2694460 VA: 0x182695260 Slot: 10
	private void UnityEngine.UIElements.IStyle.set_borderLeftColor(StyleColor value) { }

	// RVA: 0x26952C0 Offset: 0x26944C0 VA: 0x1826952C0 Slot: 11
	private void UnityEngine.UIElements.IStyle.set_borderLeftWidth(StyleFloat value) { }

	// RVA: 0x2695340 Offset: 0x2694540 VA: 0x182695340 Slot: 12
	private void UnityEngine.UIElements.IStyle.set_borderRightColor(StyleColor value) { }

	// RVA: 0x26953A0 Offset: 0x26945A0 VA: 0x1826953A0 Slot: 13
	private void UnityEngine.UIElements.IStyle.set_borderRightWidth(StyleFloat value) { }

	// RVA: 0x2695420 Offset: 0x2694620 VA: 0x182695420 Slot: 14
	private void UnityEngine.UIElements.IStyle.set_borderTopColor(StyleColor value) { }

	// RVA: 0x2695480 Offset: 0x2694680 VA: 0x182695480 Slot: 15
	private void UnityEngine.UIElements.IStyle.set_borderTopLeftRadius(StyleLength value) { }

	// RVA: 0x26954E0 Offset: 0x26946E0 VA: 0x1826954E0 Slot: 16
	private void UnityEngine.UIElements.IStyle.set_borderTopRightRadius(StyleLength value) { }

	// RVA: 0x2695540 Offset: 0x2694740 VA: 0x182695540 Slot: 17
	private void UnityEngine.UIElements.IStyle.set_borderTopWidth(StyleFloat value) { }

	// RVA: 0x26955C0 Offset: 0x26947C0 VA: 0x1826955C0 Slot: 18
	private void UnityEngine.UIElements.IStyle.set_bottom(StyleLength value) { }

	// RVA: 0x2695660 Offset: 0x2694860 VA: 0x182695660 Slot: 19
	private void UnityEngine.UIElements.IStyle.set_color(StyleColor value) { }

	// RVA: 0x2694D30 Offset: 0x2693F30 VA: 0x182694D30 Slot: 21
	private StyleEnum<DisplayStyle> UnityEngine.UIElements.IStyle.get_display() { }

	// RVA: 0x26956C0 Offset: 0x26948C0 VA: 0x1826956C0 Slot: 22
	private void UnityEngine.UIElements.IStyle.set_display(StyleEnum<DisplayStyle> value) { }

	// RVA: 0x2695770 Offset: 0x2694970 VA: 0x182695770 Slot: 23
	private void UnityEngine.UIElements.IStyle.set_flexBasis(StyleLength value) { }

	// RVA: 0x2695810 Offset: 0x2694A10 VA: 0x182695810 Slot: 24
	private void UnityEngine.UIElements.IStyle.set_flexDirection(StyleEnum<FlexDirection> value) { }

	// RVA: 0x26958C0 Offset: 0x2694AC0 VA: 0x1826958C0 Slot: 25
	private void UnityEngine.UIElements.IStyle.set_flexGrow(StyleFloat value) { }

	// RVA: 0x2695940 Offset: 0x2694B40 VA: 0x182695940 Slot: 26
	private void UnityEngine.UIElements.IStyle.set_flexShrink(StyleFloat value) { }

	// RVA: 0x26959C0 Offset: 0x2694BC0 VA: 0x1826959C0 Slot: 27
	private void UnityEngine.UIElements.IStyle.set_fontSize(StyleLength value) { }

	// RVA: 0x2695A20 Offset: 0x2694C20 VA: 0x182695A20 Slot: 28
	private void UnityEngine.UIElements.IStyle.set_height(StyleLength value) { }

	// RVA: 0x2695AC0 Offset: 0x2694CC0 VA: 0x182695AC0 Slot: 29
	private void UnityEngine.UIElements.IStyle.set_left(StyleLength value) { }

	// RVA: 0x2695B60 Offset: 0x2694D60 VA: 0x182695B60 Slot: 30
	private void UnityEngine.UIElements.IStyle.set_marginBottom(StyleLength value) { }

	// RVA: 0x2695C00 Offset: 0x2694E00 VA: 0x182695C00 Slot: 31
	private void UnityEngine.UIElements.IStyle.set_marginLeft(StyleLength value) { }

	// RVA: 0x2695CA0 Offset: 0x2694EA0 VA: 0x182695CA0 Slot: 32
	private void UnityEngine.UIElements.IStyle.set_marginRight(StyleLength value) { }

	// RVA: 0x2695D40 Offset: 0x2694F40 VA: 0x182695D40 Slot: 33
	private void UnityEngine.UIElements.IStyle.set_marginTop(StyleLength value) { }

	// RVA: 0x2695DE0 Offset: 0x2694FE0 VA: 0x182695DE0 Slot: 34
	private void UnityEngine.UIElements.IStyle.set_maxHeight(StyleLength value) { }

	// RVA: 0x2695E80 Offset: 0x2695080 VA: 0x182695E80 Slot: 35
	private void UnityEngine.UIElements.IStyle.set_maxWidth(StyleLength value) { }

	// RVA: 0x2695F20 Offset: 0x2695120 VA: 0x182695F20 Slot: 36
	private void UnityEngine.UIElements.IStyle.set_minWidth(StyleLength value) { }

	// RVA: 0x2695FC0 Offset: 0x26951C0 VA: 0x182695FC0 Slot: 37
	private void UnityEngine.UIElements.IStyle.set_opacity(StyleFloat value) { }

	// RVA: 0x2696010 Offset: 0x2695210 VA: 0x182696010 Slot: 38
	private void UnityEngine.UIElements.IStyle.set_overflow(StyleEnum<Overflow> value) { }

	// RVA: 0x2696120 Offset: 0x2695320 VA: 0x182696120 Slot: 39
	private void UnityEngine.UIElements.IStyle.set_paddingBottom(StyleLength value) { }

	// RVA: 0x26961C0 Offset: 0x26953C0 VA: 0x1826961C0 Slot: 40
	private void UnityEngine.UIElements.IStyle.set_paddingLeft(StyleLength value) { }

	// RVA: 0x2696260 Offset: 0x2695460 VA: 0x182696260 Slot: 41
	private void UnityEngine.UIElements.IStyle.set_paddingRight(StyleLength value) { }

	// RVA: 0x2694DB0 Offset: 0x2693FB0 VA: 0x182694DB0 Slot: 42
	private StyleLength UnityEngine.UIElements.IStyle.get_paddingTop() { }

	// RVA: 0x2696300 Offset: 0x2695500 VA: 0x182696300 Slot: 43
	private void UnityEngine.UIElements.IStyle.set_paddingTop(StyleLength value) { }

	// RVA: 0x26963A0 Offset: 0x26955A0 VA: 0x1826963A0 Slot: 44
	private void UnityEngine.UIElements.IStyle.set_position(StyleEnum<Position> value) { }

	// RVA: 0x2696450 Offset: 0x2695650 VA: 0x182696450 Slot: 45
	private void UnityEngine.UIElements.IStyle.set_right(StyleLength value) { }

	// RVA: 0x26964F0 Offset: 0x26956F0 VA: 0x1826964F0 Slot: 49
	private void UnityEngine.UIElements.IStyle.set_top(StyleLength value) { }

	// RVA: 0x2696740 Offset: 0x2695940 VA: 0x182696740 Slot: 53
	private void UnityEngine.UIElements.IStyle.set_unityBackgroundImageTintColor(StyleColor value) { }

	// RVA: 0x2696800 Offset: 0x2695A00 VA: 0x182696800 Slot: 54
	private void UnityEngine.UIElements.IStyle.set_unityFont(StyleFont value) { }

	// RVA: 0x26967A0 Offset: 0x26959A0 VA: 0x1826967A0 Slot: 55
	private void UnityEngine.UIElements.IStyle.set_unityFontDefinition(StyleFontDefinition value) { }

	// RVA: 0x2696850 Offset: 0x2695A50 VA: 0x182696850 Slot: 56
	private void UnityEngine.UIElements.IStyle.set_visibility(StyleEnum<Visibility> value) { }

	// RVA: 0x2695020 Offset: 0x2694220 VA: 0x182695020 Slot: 57
	private StyleLength UnityEngine.UIElements.IStyle.get_width() { }

	// RVA: 0x26968C0 Offset: 0x2695AC0 VA: 0x1826968C0 Slot: 58
	private void UnityEngine.UIElements.IStyle.set_width(StyleLength value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	private VisualElement get_ve() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	private void set_ve(VisualElement value) { }

	// RVA: 0x26969C0 Offset: 0x2695BC0 VA: 0x1826969C0
	public void .ctor(VisualElement ve) { }

	// RVA: 0x2693A40 Offset: 0x2692C40 VA: 0x182693A40 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2693F00 Offset: 0x2693100 VA: 0x182693F00
	public void SetInlineRule(StyleSheet sheet, StyleRule rule) { }

	// RVA: 0x2693B10 Offset: 0x2692D10 VA: 0x182693B10
	public bool IsValueSet(StylePropertyId id) { }

	// RVA: 0x2692800 Offset: 0x2691A00 VA: 0x182692800
	public void ApplyInlineStyles(ref ComputedStyle computedStyle) { }

	// RVA: 0x2694CD0 Offset: 0x2693ED0 VA: 0x182694CD0 Slot: 20
	private StyleCursor UnityEngine.UIElements.IStyle.get_cursor() { }

	// RVA: 0x2694ED0 Offset: 0x26940D0 VA: 0x182694ED0 Slot: 48
	private StyleTextShadow UnityEngine.UIElements.IStyle.get_textShadow() { }

	// RVA: 0x2694C60 Offset: 0x2693E60 VA: 0x182694C60 Slot: 5
	private StyleBackgroundSize UnityEngine.UIElements.IStyle.get_backgroundSize() { }

	// RVA: 0x2694F30 Offset: 0x2694130 VA: 0x182694F30 Slot: 50
	private StyleTransformOrigin UnityEngine.UIElements.IStyle.get_transformOrigin() { }

	// RVA: 0x2694FA0 Offset: 0x26941A0 VA: 0x182694FA0 Slot: 51
	private StyleTranslate UnityEngine.UIElements.IStyle.get_translate() { }

	// RVA: 0x2696590 Offset: 0x2695790 VA: 0x182696590 Slot: 52
	private void UnityEngine.UIElements.IStyle.set_translate(StyleTranslate value) { }

	// RVA: 0x2694DF0 Offset: 0x2693FF0 VA: 0x182694DF0 Slot: 46
	private StyleRotate UnityEngine.UIElements.IStyle.get_rotate() { }

	// RVA: 0x2694E70 Offset: 0x2694070 VA: 0x182694E70 Slot: 47
	private StyleScale UnityEngine.UIElements.IStyle.get_scale() { }

	// RVA: 0x2694170 Offset: 0x2693370 VA: 0x182694170
	private bool SetStyleValue(StylePropertyId id, StyleLength inlineValue) { }

	// RVA: 0x2694A00 Offset: 0x2693C00 VA: 0x182694A00
	private bool SetStyleValue(StylePropertyId id, StyleFloat inlineValue) { }

	// RVA: 0x2694610 Offset: 0x2693810 VA: 0x182694610
	private bool SetStyleValue(StylePropertyId id, StyleColor inlineValue) { }

	// RVA: -1 Offset: -1
	private bool SetStyleValue<T>(StylePropertyId id, StyleEnum<T> inlineValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA24490 Offset: 0xA23690 VA: 0x180A24490
	|-InlineStyleAccess.SetStyleValue<Int32Enum>
	|
	|-RVA: 0xA24280 Offset: 0xA23480 VA: 0x180A24280
	|-InlineStyleAccess.SetStyleValue<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x26942D0 Offset: 0x26934D0 VA: 0x1826942D0
	private bool SetStyleValue(StylePropertyId id, StyleFontDefinition inlineValue) { }

	// RVA: 0x26947D0 Offset: 0x26939D0 VA: 0x1826947D0
	private bool SetStyleValue(StylePropertyId id, StyleFont inlineValue) { }

	// RVA: 0x2693FA0 Offset: 0x26931A0 VA: 0x182693FA0
	private bool SetInlineTranslate(StyleTranslate inlineValue) { }

	// RVA: 0x2693540 Offset: 0x2692740 VA: 0x182693540
	private void ApplyStyleTranslate(StyleTranslate translate) { }

	// RVA: 0x2693760 Offset: 0x2692960 VA: 0x182693760
	private void ApplyStyleValue(StyleValue value) { }

	// RVA: 0x2693DF0 Offset: 0x2692FF0 VA: 0x182693DF0
	private bool RemoveInlineStyle(StylePropertyId id) { }

	// RVA: 0x26925F0 Offset: 0x26917F0 VA: 0x1826925F0
	private void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle newStyle) { }

	// RVA: 0x2694B70 Offset: 0x2693D70 VA: 0x182694B70
	public bool TryGetInlineCursor(ref StyleCursor value) { }

	// RVA: 0x2694BF0 Offset: 0x2693DF0 VA: 0x182694BF0
	public bool TryGetInlineTextShadow(ref StyleTextShadow value) { }

	// RVA: 0x2694C10 Offset: 0x2693E10 VA: 0x182694C10
	public bool TryGetInlineTransformOrigin(ref StyleTransformOrigin value) { }

	// RVA: 0x2694C30 Offset: 0x2693E30 VA: 0x182694C30
	public bool TryGetInlineTranslate(ref StyleTranslate value) { }

	// RVA: 0x2694B90 Offset: 0x2693D90 VA: 0x182694B90
	public bool TryGetInlineRotate(ref StyleRotate value) { }

	// RVA: 0x2694BC0 Offset: 0x2693DC0 VA: 0x182694BC0
	public bool TryGetInlineScale(ref StyleScale value) { }

	// RVA: 0x2694B40 Offset: 0x2693D40 VA: 0x182694B40
	public bool TryGetInlineBackgroundSize(ref StyleBackgroundSize value) { }

	// RVA: 0x2696960 Offset: 0x2695B60 VA: 0x182696960
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements
public interface IResolvedStyle // TypeDefIndex: 11414
{
	// Properties
	public abstract Color backgroundColor { get; }
	public abstract Color borderBottomColor { get; }
	public abstract float borderBottomLeftRadius { get; }
	public abstract float borderBottomRightRadius { get; }
	public abstract float borderBottomWidth { get; }
	public abstract Color borderLeftColor { get; }
	public abstract float borderLeftWidth { get; }
	public abstract Color borderRightColor { get; }
	public abstract float borderRightWidth { get; }
	public abstract Color borderTopColor { get; }
	public abstract float borderTopLeftRadius { get; }
	public abstract float borderTopRightRadius { get; }
	public abstract float borderTopWidth { get; }
	public abstract float bottom { get; }
	public abstract Color color { get; }
	public abstract DisplayStyle display { get; }
	public abstract FlexDirection flexDirection { get; }
	public abstract float flexGrow { get; }
	public abstract float flexShrink { get; }
	public abstract float height { get; }
	public abstract float left { get; }
	public abstract float marginBottom { get; }
	public abstract float marginLeft { get; }
	public abstract float marginRight { get; }
	public abstract float marginTop { get; }
	public abstract StyleFloat minHeight { get; }
	public abstract StyleFloat minWidth { get; }
	public abstract float opacity { get; }
	public abstract float paddingBottom { get; }
	public abstract float paddingLeft { get; }
	public abstract float paddingRight { get; }
	public abstract float paddingTop { get; }
	public abstract float right { get; }
	public abstract Scale scale { get; }
	public abstract float top { get; }
	public abstract Vector3 transformOrigin { get; }
	public abstract Vector3 translate { get; }
	public abstract Color unityBackgroundImageTintColor { get; }
	public abstract int unitySliceLeft { get; }
	public abstract int unitySliceRight { get; }
	public abstract float unitySliceScale { get; }
	public abstract Color unityTextOutlineColor { get; }
	public abstract float unityTextOutlineWidth { get; }
	public abstract Visibility visibility { get; }
	public abstract float width { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Color get_backgroundColor();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Color get_borderBottomColor();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_borderBottomLeftRadius();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract float get_borderBottomRightRadius();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float get_borderBottomWidth();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Color get_borderLeftColor();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract float get_borderLeftWidth();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Color get_borderRightColor();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract float get_borderRightWidth();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Color get_borderTopColor();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract float get_borderTopLeftRadius();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract float get_borderTopRightRadius();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract float get_borderTopWidth();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract float get_bottom();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract Color get_color();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract DisplayStyle get_display();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract FlexDirection get_flexDirection();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract float get_flexGrow();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract float get_flexShrink();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract float get_height();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract float get_left();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract float get_marginBottom();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract float get_marginLeft();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract float get_marginRight();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract float get_marginTop();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract StyleFloat get_minHeight();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract StyleFloat get_minWidth();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract float get_opacity();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract float get_paddingBottom();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract float get_paddingLeft();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract float get_paddingRight();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract float get_paddingTop();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract float get_right();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract Scale get_scale();

	// RVA: -1 Offset: -1 Slot: 34
	public abstract float get_top();

	// RVA: -1 Offset: -1 Slot: 35
	public abstract Vector3 get_transformOrigin();

	// RVA: -1 Offset: -1 Slot: 36
	public abstract Vector3 get_translate();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract Color get_unityBackgroundImageTintColor();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract int get_unitySliceLeft();

	// RVA: -1 Offset: -1 Slot: 39
	public abstract int get_unitySliceRight();

	// RVA: -1 Offset: -1 Slot: 40
	public abstract float get_unitySliceScale();

	// RVA: -1 Offset: -1 Slot: 41
	public abstract Color get_unityTextOutlineColor();

	// RVA: -1 Offset: -1 Slot: 42
	public abstract float get_unityTextOutlineWidth();

	// RVA: -1 Offset: -1 Slot: 43
	public abstract Visibility get_visibility();

	// RVA: -1 Offset: -1 Slot: 44
	public abstract float get_width();
}

// Namespace: UnityEngine.UIElements
public interface IStyle // TypeDefIndex: 11415
{
	// Properties
	public abstract StyleColor backgroundColor { set; }
	public abstract StyleBackgroundSize backgroundSize { get; }
	public abstract StyleColor borderBottomColor { set; }
	public abstract StyleLength borderBottomLeftRadius { set; }
	public abstract StyleLength borderBottomRightRadius { set; }
	public abstract StyleFloat borderBottomWidth { set; }
	public abstract StyleColor borderLeftColor { set; }
	public abstract StyleFloat borderLeftWidth { set; }
	public abstract StyleColor borderRightColor { set; }
	public abstract StyleFloat borderRightWidth { set; }
	public abstract StyleColor borderTopColor { set; }
	public abstract StyleLength borderTopLeftRadius { set; }
	public abstract StyleLength borderTopRightRadius { set; }
	public abstract StyleFloat borderTopWidth { set; }
	public abstract StyleLength bottom { set; }
	public abstract StyleColor color { set; }
	public abstract StyleCursor cursor { get; }
	public abstract StyleEnum<DisplayStyle> display { get; set; }
	public abstract StyleLength flexBasis { set; }
	public abstract StyleEnum<FlexDirection> flexDirection { set; }
	public abstract StyleFloat flexGrow { set; }
	public abstract StyleFloat flexShrink { set; }
	public abstract StyleLength fontSize { set; }
	public abstract StyleLength height { set; }
	public abstract StyleLength left { set; }
	public abstract StyleLength marginBottom { set; }
	public abstract StyleLength marginLeft { set; }
	public abstract StyleLength marginRight { set; }
	public abstract StyleLength marginTop { set; }
	public abstract StyleLength maxHeight { set; }
	public abstract StyleLength maxWidth { set; }
	public abstract StyleLength minWidth { set; }
	public abstract StyleFloat opacity { set; }
	public abstract StyleEnum<Overflow> overflow { set; }
	public abstract StyleLength paddingBottom { set; }
	public abstract StyleLength paddingLeft { set; }
	public abstract StyleLength paddingRight { set; }
	public abstract StyleLength paddingTop { get; set; }
	public abstract StyleEnum<Position> position { set; }
	public abstract StyleLength right { set; }
	public abstract StyleRotate rotate { get; }
	public abstract StyleScale scale { get; }
	public abstract StyleTextShadow textShadow { get; }
	public abstract StyleLength top { set; }
	public abstract StyleTransformOrigin transformOrigin { get; }
	public abstract StyleTranslate translate { get; set; }
	public abstract StyleColor unityBackgroundImageTintColor { set; }
	public abstract StyleFont unityFont { set; }
	public abstract StyleFontDefinition unityFontDefinition { set; }
	public abstract StyleEnum<Visibility> visibility { set; }
	public abstract StyleLength width { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void set_backgroundColor(StyleColor value);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract StyleBackgroundSize get_backgroundSize();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_borderBottomColor(StyleColor value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_borderBottomLeftRadius(StyleLength value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void set_borderBottomRightRadius(StyleLength value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_borderBottomWidth(StyleFloat value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void set_borderLeftColor(StyleColor value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_borderLeftWidth(StyleFloat value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void set_borderRightColor(StyleColor value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void set_borderRightWidth(StyleFloat value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void set_borderTopColor(StyleColor value);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void set_borderTopLeftRadius(StyleLength value);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void set_borderTopRightRadius(StyleLength value);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void set_borderTopWidth(StyleFloat value);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void set_bottom(StyleLength value);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void set_color(StyleColor value);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract StyleCursor get_cursor();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract StyleEnum<DisplayStyle> get_display();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void set_display(StyleEnum<DisplayStyle> value);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void set_flexBasis(StyleLength value);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void set_flexDirection(StyleEnum<FlexDirection> value);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void set_flexGrow(StyleFloat value);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void set_flexShrink(StyleFloat value);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void set_fontSize(StyleLength value);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void set_height(StyleLength value);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void set_left(StyleLength value);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract void set_marginBottom(StyleLength value);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void set_marginLeft(StyleLength value);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void set_marginRight(StyleLength value);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void set_marginTop(StyleLength value);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void set_maxHeight(StyleLength value);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract void set_maxWidth(StyleLength value);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract void set_minWidth(StyleLength value);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void set_opacity(StyleFloat value);

	// RVA: -1 Offset: -1 Slot: 34
	public abstract void set_overflow(StyleEnum<Overflow> value);

	// RVA: -1 Offset: -1 Slot: 35
	public abstract void set_paddingBottom(StyleLength value);

	// RVA: -1 Offset: -1 Slot: 36
	public abstract void set_paddingLeft(StyleLength value);

	// RVA: -1 Offset: -1 Slot: 37
	public abstract void set_paddingRight(StyleLength value);

	// RVA: -1 Offset: -1 Slot: 38
	public abstract StyleLength get_paddingTop();

	// RVA: -1 Offset: -1 Slot: 39
	public abstract void set_paddingTop(StyleLength value);

	// RVA: -1 Offset: -1 Slot: 40
	public abstract void set_position(StyleEnum<Position> value);

	// RVA: -1 Offset: -1 Slot: 41
	public abstract void set_right(StyleLength value);

	// RVA: -1 Offset: -1 Slot: 42
	public abstract StyleRotate get_rotate();

	// RVA: -1 Offset: -1 Slot: 43
	public abstract StyleScale get_scale();

	// RVA: -1 Offset: -1 Slot: 44
	public abstract StyleTextShadow get_textShadow();

	// RVA: -1 Offset: -1 Slot: 45
	public abstract void set_top(StyleLength value);

	// RVA: -1 Offset: -1 Slot: 46
	public abstract StyleTransformOrigin get_transformOrigin();

	// RVA: -1 Offset: -1 Slot: 47
	public abstract StyleTranslate get_translate();

	// RVA: -1 Offset: -1 Slot: 48
	public abstract void set_translate(StyleTranslate value);

	// RVA: -1 Offset: -1 Slot: 49
	public abstract void set_unityBackgroundImageTintColor(StyleColor value);

	// RVA: -1 Offset: -1 Slot: 50
	public abstract void set_unityFont(StyleFont value);

	// RVA: -1 Offset: -1 Slot: 51
	public abstract void set_unityFontDefinition(StyleFontDefinition value);

	// RVA: -1 Offset: -1 Slot: 52
	public abstract void set_visibility(StyleEnum<Visibility> value);

	// RVA: -1 Offset: -1 Slot: 53
	public abstract StyleLength get_width();

	// RVA: -1 Offset: -1 Slot: 54
	public abstract void set_width(StyleLength value);
}

// Namespace: 
public class VisualElement.UxmlFactory : UxmlFactory<VisualElement, VisualElement.UxmlTraits> // TypeDefIndex: 11416
{
	// Methods

	// RVA: 0x26A3B70 Offset: 0x26A2D70 VA: 0x1826A3B70
	public void .ctor() { }
}

// Namespace: 
public class VisualElement.UxmlTraits : UxmlTraits // TypeDefIndex: 11417
{
	// Fields
	protected UxmlStringAttributeDescription m_Name; // 0x18
	private UxmlStringAttributeDescription m_ViewDataKey; // 0x20
	protected UxmlEnumAttributeDescription<PickingMode> m_PickingMode; // 0x28
	private UxmlStringAttributeDescription m_Tooltip; // 0x30
	private UxmlEnumAttributeDescription<UsageHints> m_UsageHints; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private UxmlIntAttributeDescription <focusIndex>k__BackingField; // 0x40
	private UxmlIntAttributeDescription m_TabIndex; // 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private UxmlBoolAttributeDescription <focusable>k__BackingField; // 0x50
	private UxmlStringAttributeDescription m_Class; // 0x58
	private UxmlStringAttributeDescription m_ContentContainer; // 0x60
	private UxmlStringAttributeDescription m_Style; // 0x68

	// Properties
	protected UxmlIntAttributeDescription focusIndex { get; }
	protected UxmlBoolAttributeDescription focusable { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	protected UxmlIntAttributeDescription get_focusIndex() { }

	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	protected UxmlBoolAttributeDescription get_focusable() { }

	// RVA: 0x26A3BB0 Offset: 0x26A2DB0 VA: 0x1826A3BB0 Slot: 4
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x26A4080 Offset: 0x26A3280 VA: 0x1826A4080
	public void .ctor() { }
}

// Namespace: 
public enum VisualElement.MeasureMode // TypeDefIndex: 11418
{
	// Fields
	public int value__; // 0x0
	public const VisualElement.MeasureMode Undefined = 0;
	public const VisualElement.MeasureMode Exactly = 1;
	public const VisualElement.MeasureMode AtMost = 2;
}

// Namespace: 
internal enum VisualElement.RenderTargetMode // TypeDefIndex: 11419
{
	// Fields
	public int value__; // 0x0
	public const VisualElement.RenderTargetMode None = 0;
	public const VisualElement.RenderTargetMode NoColorConversion = 1;
	public const VisualElement.RenderTargetMode LinearToGamma = 2;
	public const VisualElement.RenderTargetMode GammaToLinear = 3;
}

// Namespace: 
[DefaultMember("Item")]
public struct VisualElement.Hierarchy // TypeDefIndex: 11420
{
	// Fields
	private const string k_InvalidHierarchyChangeMsg = "Cannot modify VisualElement hierarchy during layout calculation";
	private readonly VisualElement m_Owner; // 0x0

	// Properties
	public VisualElement parent { get; }
	internal List<VisualElement> children { get; }
	public int childCount { get; }
	public VisualElement Item { get; }

	// Methods

	// RVA: 0x26A2E70 Offset: 0x26A2070 VA: 0x1826A2E70
	public VisualElement get_parent() { }

	// RVA: 0x26A18C0 Offset: 0x26A0AC0 VA: 0x1826A18C0
	internal List<VisualElement> get_children() { }

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(VisualElement element) { }

	// RVA: 0x26A16E0 Offset: 0x26A08E0 VA: 0x1826A16E0
	public void Add(VisualElement child) { }

	// RVA: 0x26A1E90 Offset: 0x26A1090 VA: 0x1826A1E90
	public void Insert(int index, VisualElement child) { }

	// RVA: 0x26A2B60 Offset: 0x26A1D60 VA: 0x1826A2B60
	public void Remove(VisualElement child) { }

	// RVA: 0x26A2810 Offset: 0x26A1A10 VA: 0x1826A2810
	public void RemoveAt(int index) { }

	// RVA: 0x26A18E0 Offset: 0x26A0AE0 VA: 0x1826A18E0
	public void Clear() { }

	// RVA: 0x26A1790 Offset: 0x26A0990 VA: 0x1826A1790
	internal void BringToFront(VisualElement child) { }

	// RVA: 0x26A2C90 Offset: 0x26A1E90 VA: 0x1826A2C90
	internal void SendToBack(VisualElement child) { }

	// RVA: 0x26A24C0 Offset: 0x26A16C0 VA: 0x1826A24C0
	internal void PlaceBehind(VisualElement child, VisualElement over) { }

	// RVA: 0x26A2380 Offset: 0x26A1580 VA: 0x1826A2380
	private void MoveChildElement(VisualElement child, int currentIndex, int nextIndex) { }

	// RVA: 0x26A2E20 Offset: 0x26A2020 VA: 0x1826A2E20
	public int get_childCount() { }

	// RVA: 0x26A1D20 Offset: 0x26A0F20 VA: 0x1826A1D20
	public VisualElement get_Item(int key) { }

	// RVA: 0x26A1E30 Offset: 0x26A1030 VA: 0x1826A1E30
	public int IndexOf(VisualElement element) { }

	// RVA: 0x26A1D20 Offset: 0x26A0F20 VA: 0x1826A1D20
	public VisualElement ElementAt(int index) { }

	// RVA: 0x26A18C0 Offset: 0x26A0AC0 VA: 0x1826A18C0
	public IEnumerable<VisualElement> Children() { }

	// RVA: 0x26A2D30 Offset: 0x26A1F30 VA: 0x1826A2D30
	private void SetParent(VisualElement value) { }

	// RVA: 0x26A25C0 Offset: 0x26A17C0 VA: 0x1826A25C0
	private void PutChildAtIndex(VisualElement child, int index) { }

	// RVA: 0x26A2AE0 Offset: 0x26A1CE0 VA: 0x1826A2AE0
	private void RemoveChildAtIndex(int index) { }

	// RVA: 0x26A2730 Offset: 0x26A1930 VA: 0x1826A2730
	private void ReleaseChildList() { }

	// RVA: 0x26A1E20 Offset: 0x26A1020 VA: 0x1826A1E20
	public bool Equals(VisualElement.Hierarchy other) { }

	// RVA: 0x26A1D80 Offset: 0x26A0F80 VA: 0x1826A1D80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x25CBE90 Offset: 0x25CB090 VA: 0x1825CBE90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x25ADDA0 Offset: 0x25ACFA0 VA: 0x1825ADDA0
	public static bool op_Equality(VisualElement.Hierarchy x, VisualElement.Hierarchy y) { }
}

// Namespace: 
private abstract class VisualElement.BaseVisualElementScheduledItem : ScheduledItem, IVisualElementScheduledItem, IVisualElementPanelActivatable // TypeDefIndex: 11421
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VisualElement <element>k__BackingField; // 0x38
	public bool isScheduled; // 0x40
	private VisualElementPanelActivator m_Activator; // 0x48

	// Properties
	public VisualElement element { get; set; }
	public bool isActive { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 13
	public VisualElement get_element() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	private void set_element(VisualElement value) { }

	// RVA: 0x26A0D70 Offset: 0x269FF70 VA: 0x1826A0D70 Slot: 7
	public bool get_isActive() { }

	// RVA: 0x26A0CE0 Offset: 0x269FEE0 VA: 0x1826A0CE0
	protected void .ctor(VisualElement handler) { }

	// RVA: 0x26A0CD0 Offset: 0x269FED0 VA: 0x1826A0CD0 Slot: 11
	public IVisualElementScheduledItem StartingIn(long delayMs) { }

	// RVA: 0x26A0A00 Offset: 0x269FC00 VA: 0x1826A0A00 Slot: 12
	public IVisualElementScheduledItem Every(long intervalMs) { }

	// RVA: 0x26A0B00 Offset: 0x269FD00 VA: 0x1826A0B00 Slot: 5
	internal override void OnItemUnscheduled() { }

	// RVA: 0x26A0CA0 Offset: 0x269FEA0 VA: 0x1826A0CA0 Slot: 8
	public void Resume() { }

	// RVA: 0x26A0C70 Offset: 0x269FE70 VA: 0x1826A0C70 Slot: 9
	public void Pause() { }

	// RVA: 0x26A0AB0 Offset: 0x269FCB0 VA: 0x1826A0AB0 Slot: 10
	public void ExecuteLater(long delayMs) { }

	// RVA: 0x26A0B50 Offset: 0x269FD50 VA: 0x1826A0B50 Slot: 15
	public void OnPanelActivate() { }

	// RVA: 0x26A0BE0 Offset: 0x269FDE0 VA: 0x1826A0BE0 Slot: 16
	public void OnPanelDeactivate() { }

	// RVA: 0x26A09B0 Offset: 0x269FBB0 VA: 0x1826A09B0 Slot: 14
	public bool CanBeActivated() { }
}

// Namespace: 
private abstract class VisualElement.VisualElementScheduledItem<ActionType> : VisualElement.BaseVisualElementScheduledItem // TypeDefIndex: 11422
{
	// Fields
	public ActionType updateEvent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(VisualElement handler, ActionType upEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE38D20 Offset: 0xE37F20 VA: 0x180E38D20
	|-VisualElement.VisualElementScheduledItem<object>..ctor
	|
	|-RVA: 0xE38C50 Offset: 0xE37E50 VA: 0x180E38C50
	|-VisualElement.VisualElementScheduledItem<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
private class VisualElement.TimerStateScheduledItem : VisualElement.VisualElementScheduledItem<Action<TimerState>> // TypeDefIndex: 11423
{
	// Methods

	// RVA: 0x26A3900 Offset: 0x26A2B00 VA: 0x1826A3900
	public void .ctor(VisualElement handler, Action<TimerState> updateEvent) { }

	// RVA: 0x26A38C0 Offset: 0x26A2AC0 VA: 0x1826A38C0 Slot: 4
	public override void PerformTimerUpdate(TimerState state) { }
}

// Namespace: 
private class VisualElement.SimpleScheduledItem : VisualElement.VisualElementScheduledItem<Action> // TypeDefIndex: 11424
{
	// Methods

	// RVA: 0x26A3860 Offset: 0x26A2A60 VA: 0x1826A3860
	public void .ctor(VisualElement handler, Action updateEvent) { }

	// RVA: 0x26A3820 Offset: 0x26A2A20 VA: 0x1826A3820 Slot: 4
	public override void PerformTimerUpdate(TimerState state) { }
}

// Namespace: 
internal class VisualElement.CustomStyleAccess : ICustomStyle // TypeDefIndex: 11425
{
	// Fields
	private Dictionary<string, StylePropertyValue> m_CustomProperties; // 0x10
	private float m_DpiScaling; // 0x18

	// Methods

	// RVA: 0x26A0E70 Offset: 0x26A0070 VA: 0x1826A0E70
	public void SetContext(Dictionary<string, StylePropertyValue> customProperties, float dpiScaling) { }

	// RVA: 0x26A12E0 Offset: 0x26A04E0 VA: 0x1826A12E0 Slot: 4
	public bool TryGetValue(CustomStyleProperty<float> property, out float value) { }

	// RVA: 0x26A0FF0 Offset: 0x26A01F0 VA: 0x1826A0FF0 Slot: 5
	public bool TryGetValue(CustomStyleProperty<int> property, out int value) { }

	// RVA: 0x26A0E80 Offset: 0x26A0080 VA: 0x1826A0E80 Slot: 6
	public bool TryGetValue(CustomStyleProperty<Color> property, out Color value) { }

	// RVA: 0x26A1110 Offset: 0x26A0310 VA: 0x1826A1110 Slot: 7
	public bool TryGetValue(CustomStyleProperty<Texture2D> property, out Texture2D value) { }

	// RVA: 0x26A1500 Offset: 0x26A0700 VA: 0x1826A1500 Slot: 8
	public bool TryGetValue(CustomStyleProperty<Sprite> property, out Sprite value) { }

	// RVA: 0x26A13F0 Offset: 0x26A05F0 VA: 0x1826A13F0 Slot: 9
	public bool TryGetValue(CustomStyleProperty<VectorImage> property, out VectorImage value) { }

	// RVA: 0x26A1610 Offset: 0x26A0810 VA: 0x1826A1610 Slot: 10
	public bool TryGetValue(CustomStyleProperty<string> property, out string value) { }

	// RVA: 0x26A1220 Offset: 0x26A0420 VA: 0x1826A1220
	private bool TryGetValue(string propertyName, StyleValueType valueType, out StylePropertyValue customProp) { }

	// RVA: 0x26A0D90 Offset: 0x269FF90 VA: 0x1826A0D90
	private static void LogCustomPropertyWarning(string propertyName, StyleValueType valueType, StylePropertyValue customProp) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
internal class VisualElement.TypeData // TypeDefIndex: 11426
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Type <type>k__BackingField; // 0x10
	private string m_FullTypeName; // 0x18
	private string m_TypeName; // 0x20
	private string m_TypeNamespace; // 0x28

	// Properties
	public Type type { get; }
	public string fullTypeName { get; }
	public string typeName { get; }
	public string typeNamespace { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Type get_type() { }

	// RVA: 0x26A3960 Offset: 0x26A2B60 VA: 0x1826A3960
	public void .ctor(Type type) { }

	// RVA: 0x26A39F0 Offset: 0x26A2BF0 VA: 0x1826A39F0
	public string get_fullTypeName() { }

	// RVA: 0x26A3A40 Offset: 0x26A2C40 VA: 0x1826A3A40
	public string get_typeName() { }

	// RVA: 0x26A3AF0 Offset: 0x26A2CF0 VA: 0x1826A3AF0
	public string get_typeNamespace() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class VisualElement.<>c__DisplayClass492_0 // TypeDefIndex: 11427
{
	// Fields
	public VisualElement <>4__this; // 0x10
	public StyleValues to; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x26A3B40 Offset: 0x26A2D40 VA: 0x1826A3B40
	internal StyleValues <UnityEngine.UIElements.Experimental.ITransitionAnimations.Start>b__0(VisualElement e) { }
}

// Namespace: UnityEngine.UIElements
[DefaultMember("Item")]
public class VisualElement : Focusable, IResolvedStyle, IStylePropertyAnimations, ITransform, ITransitionAnimations, IExperimentalFeatures, IVisualElementScheduler // TypeDefIndex: 11428
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount>k__BackingField; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount>k__BackingField; // 0x34
	private static uint s_NextId; // 0x0
	private static List<string> s_EmptyClassList; // 0x8
	internal static readonly PropertyName userDataPropertyKey; // 0x10
	public static readonly string disabledUssClassName; // 0x18
	private string m_Name; // 0x38
	private List<string> m_ClassList; // 0x40
	private List<KeyValuePair<PropertyName, object>> m_PropertyBag; // 0x48
	internal VisualElementFlags m_Flags; // 0x50
	private string m_ViewDataKey; // 0x58
	private RenderHints m_RenderHints; // 0x60
	internal Rect lastLayout; // 0x64
	internal Rect lastPseudoPadding; // 0x74
	internal RenderChainVEData renderChainData; // 0x88
	private Rect m_Layout; // 0x1D0
	private Rect m_BoundingBox; // 0x1E0
	private const VisualElementFlags worldBoundingBoxDirtyDependencies = 25;
	private Rect m_WorldBoundingBox; // 0x1F0
	private const VisualElementFlags worldTransformInverseDirtyDependencies = 3;
	private Matrix4x4 m_WorldTransformCache; // 0x200
	private Matrix4x4 m_WorldTransformInverseCache; // 0x240
	private Rect m_WorldClip; // 0x280
	private Rect m_WorldClipMinusGroup; // 0x290
	private bool m_WorldClipIsInfinite; // 0x2A0
	internal static readonly Rect s_InfiniteRect; // 0x20
	internal PseudoStates triggerPseudoMask; // 0x2A4
	internal PseudoStates dependencyPseudoMask; // 0x2A8
	private PseudoStates m_PseudoStates; // 0x2AC
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <containedPointerIds>k__BackingField; // 0x2B0
	private PickingMode m_PickingMode; // 0x2B4
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private YogaNode <yogaNode>k__BackingField; // 0x2B8
	internal ComputedStyle m_Style; // 0x2C0
	internal StyleVariableContext variableContext; // 0x318
	internal int inheritedStylesHash; // 0x320
	internal readonly uint controlid; // 0x324
	internal int imguiContainerDescendantCount; // 0x328
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <enabledSelf>k__BackingField; // 0x32C
	private LanguageDirection m_LanguageDirection; // 0x330
	private LanguageDirection m_LocalLanguageDirection; // 0x334
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<MeshGenerationContext> <generateVisualContent>k__BackingField; // 0x338
	private static readonly ProfilerMarker k_GenerateVisualContentMarker; // 0x30
	private VisualElement.RenderTargetMode m_SubRenderTargetMode; // 0x340
	private static Material s_runtimeMaterial; // 0x38
	private Material m_defaultMaterial; // 0x348
	private List<IValueAnimationUpdate> m_RunningAnimations; // 0x350
	private static uint s_NextParentVersion; // 0x40
	private uint m_NextParentCachedVersion; // 0x358
	private uint m_NextParentRequiredVersion; // 0x35C
	private VisualElement m_CachedNextParentWithEventCallback; // 0x360
	private int m_EventCallbackCategories; // 0x368
	private int m_CachedEventCallbackParentCategories; // 0x36C
	private readonly int m_DefaultActionEventCategories; // 0x370
	private readonly int m_DefaultActionAtTargetEventCategories; // 0x374
	internal const string k_RootVisualContainerName = "rootVisualContainer";
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VisualElement.Hierarchy <hierarchy>k__BackingField; // 0x378
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <isRootVisualContainer>k__BackingField; // 0x380
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <cacheAsBitmap>k__BackingField; // 0x381
	private VisualElement m_PhysicalParent; // 0x388
	private VisualElement m_LogicalParent; // 0x390
	private static readonly List<VisualElement> s_EmptyList; // 0x48
	private List<VisualElement> m_Children; // 0x398
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private BaseVisualElementPanel <elementPanel>k__BackingField; // 0x3A0
	private VisualTreeAsset m_VisualTreeAssetSource; // 0x3A8
	internal static VisualElement.CustomStyleAccess s_CustomStyleAccess; // 0x50
	internal InlineStyleAccess inlineStyleAccess; // 0x3B0
	internal List<StyleSheet> styleSheetList; // 0x3B8
	private static readonly Regex s_InternalStyleSheetPath; // 0x58
	internal static readonly PropertyName tooltipPropertyKey; // 0x60
	private static readonly Dictionary<Type, VisualElement.TypeData> s_TypeData; // 0x68
	private VisualElement.TypeData m_TypeData; // 0x3C0

	// Properties
	public IResolvedStyle resolvedStyle { get; }
	private Color UnityEngine.UIElements.IResolvedStyle.backgroundColor { get; }
	private Color UnityEngine.UIElements.IResolvedStyle.borderBottomColor { get; }
	private float UnityEngine.UIElements.IResolvedStyle.borderBottomLeftRadius { get; }
	private float UnityEngine.UIElements.IResolvedStyle.borderBottomRightRadius { get; }
	private float UnityEngine.UIElements.IResolvedStyle.borderBottomWidth { get; }
	private Color UnityEngine.UIElements.IResolvedStyle.borderLeftColor { get; }
	private float UnityEngine.UIElements.IResolvedStyle.borderLeftWidth { get; }
	private Color UnityEngine.UIElements.IResolvedStyle.borderRightColor { get; }
	private float UnityEngine.UIElements.IResolvedStyle.borderRightWidth { get; }
	private Color UnityEngine.UIElements.IResolvedStyle.borderTopColor { get; }
	private float UnityEngine.UIElements.IResolvedStyle.borderTopLeftRadius { get; }
	private float UnityEngine.UIElements.IResolvedStyle.borderTopRightRadius { get; }
	private float UnityEngine.UIElements.IResolvedStyle.borderTopWidth { get; }
	private float UnityEngine.UIElements.IResolvedStyle.bottom { get; }
	private Color UnityEngine.UIElements.IResolvedStyle.color { get; }
	private DisplayStyle UnityEngine.UIElements.IResolvedStyle.display { get; }
	private FlexDirection UnityEngine.UIElements.IResolvedStyle.flexDirection { get; }
	private float UnityEngine.UIElements.IResolvedStyle.flexGrow { get; }
	private float UnityEngine.UIElements.IResolvedStyle.flexShrink { get; }
	private float UnityEngine.UIElements.IResolvedStyle.height { get; }
	private float UnityEngine.UIElements.IResolvedStyle.left { get; }
	private float UnityEngine.UIElements.IResolvedStyle.marginBottom { get; }
	private float UnityEngine.UIElements.IResolvedStyle.marginLeft { get; }
	private float UnityEngine.UIElements.IResolvedStyle.marginRight { get; }
	private float UnityEngine.UIElements.IResolvedStyle.marginTop { get; }
	private StyleFloat UnityEngine.UIElements.IResolvedStyle.minHeight { get; }
	private StyleFloat UnityEngine.UIElements.IResolvedStyle.minWidth { get; }
	private float UnityEngine.UIElements.IResolvedStyle.opacity { get; }
	private float UnityEngine.UIElements.IResolvedStyle.paddingBottom { get; }
	private float UnityEngine.UIElements.IResolvedStyle.paddingLeft { get; }
	private float UnityEngine.UIElements.IResolvedStyle.paddingRight { get; }
	private float UnityEngine.UIElements.IResolvedStyle.paddingTop { get; }
	private float UnityEngine.UIElements.IResolvedStyle.right { get; }
	private Scale UnityEngine.UIElements.IResolvedStyle.scale { get; }
	private float UnityEngine.UIElements.IResolvedStyle.top { get; }
	private Vector3 UnityEngine.UIElements.IResolvedStyle.transformOrigin { get; }
	private Vector3 UnityEngine.UIElements.IResolvedStyle.translate { get; }
	private Color UnityEngine.UIElements.IResolvedStyle.unityBackgroundImageTintColor { get; }
	private int UnityEngine.UIElements.IResolvedStyle.unitySliceLeft { get; }
	private int UnityEngine.UIElements.IResolvedStyle.unitySliceRight { get; }
	private float UnityEngine.UIElements.IResolvedStyle.unitySliceScale { get; }
	private Color UnityEngine.UIElements.IResolvedStyle.unityTextOutlineColor { get; }
	private float UnityEngine.UIElements.IResolvedStyle.unityTextOutlineWidth { get; }
	private Visibility UnityEngine.UIElements.IResolvedStyle.visibility { get; }
	private float UnityEngine.UIElements.IResolvedStyle.width { get; }
	internal bool hasRunningAnimations { get; }
	internal bool hasCompletedAnimations { get; }
	private int UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount { get; set; }
	private int UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount { get; set; }
	internal IStylePropertyAnimations styleAnimation { get; }
	internal bool isCompositeRoot { get; set; }
	internal bool isHierarchyDisplayed { get; set; }
	public string viewDataKey { get; set; }
	internal bool enableViewDataPersistence { get; set; }
	public object userData { get; set; }
	public override bool canGrabFocus { get; }
	public override FocusController focusController { get; }
	public UsageHints usageHints { get; set; }
	internal RenderHints renderHints { get; set; }
	public ITransform transform { get; }
	private Vector3 UnityEngine.UIElements.ITransform.position { get; set; }
	private Vector3 UnityEngine.UIElements.ITransform.scale { get; }
	internal bool isLayoutManual { get; set; }
	internal float scaledPixelsPerPoint { get; }
	public Rect layout { get; set; }
	public Rect contentRect { get; }
	protected Rect paddingRect { get; }
	internal bool isBoundingBoxDirty { get; set; }
	internal bool isWorldBoundingBoxDirty { set; }
	internal bool isWorldBoundingBoxOrDependenciesDirty { get; }
	internal Rect boundingBox { get; }
	internal Rect worldBoundingBox { get; }
	private Rect boundingBoxInParentSpace { get; }
	public Rect worldBound { get; }
	public Rect localBound { get; }
	internal Rect rect { get; }
	internal bool isWorldTransformDirty { get; set; }
	internal bool isWorldTransformInverseDirty { set; }
	internal bool isWorldTransformInverseOrDependenciesDirty { get; }
	public Matrix4x4 worldTransform { get; }
	internal Matrix4x4 worldTransformRef { get; }
	internal Matrix4x4 worldTransformInverse { get; }
	internal bool isWorldClipDirty { get; set; }
	internal Rect worldClip { get; }
	internal Rect worldClipMinusGroup { get; }
	internal bool worldClipIsInfinite { get; }
	internal PseudoStates pseudoStates { get; set; }
	internal int containedPointerIds { get; set; }
	public PickingMode pickingMode { get; set; }
	public string name { get; set; }
	internal List<string> classList { get; }
	internal string fullTypeName { get; }
	internal string typeName { get; }
	internal YogaNode yogaNode { get; set; }
	internal ComputedStyle computedStyle { get; }
	internal bool hasInlineStyle { get; }
	internal bool styleInitialized { get; set; }
	private bool isParentEnabledInHierarchy { get; }
	public bool enabledInHierarchy { get; }
	public bool enabledSelf { get; set; }
	public LanguageDirection languageDirection { get; }
	internal LanguageDirection localLanguageDirection { get; set; }
	public bool visible { get; set; }
	public Action<MeshGenerationContext> generateVisualContent { get; set; }
	internal bool requireMeasureFunction { get; set; }
	internal VisualElement.RenderTargetMode subRenderTargetMode { get; }
	internal Material defaultMaterial { get; }
	internal VisualElement nextParentWithEventCallback { get; }
	internal int eventCallbackCategories { get; set; }
	internal int eventCallbackParentCategories { get; }
	internal bool isEventCallbackParentCategoriesDirty { get; set; }
	public IExperimentalFeatures experimental { get; }
	private ITransitionAnimations UnityEngine.UIElements.IExperimentalFeatures.animation { get; }
	public VisualElement.Hierarchy hierarchy { get; set; }
	internal bool isRootVisualContainer { get; set; }
	internal bool disableClipping { get; set; }
	public VisualElement parent { get; }
	internal BaseVisualElementPanel elementPanel { get; set; }
	public IPanel panel { get; }
	public virtual VisualElement contentContainer { get; }
	internal VisualTreeAsset visualTreeAssetSource { set; }
	public VisualElement Item { get; }
	public int childCount { get; }
	private Vector3 positionWithLayout { get; }
	internal bool hasDefaultRotationAndScale { get; }
	public IVisualElementScheduler schedule { get; }
	public IStyle style { get; }
	public ICustomStyle customStyle { get; }
	public VisualElementStyleSheetSet styleSheets { get; }
	public string tooltip { get; set; }
	private VisualElement.TypeData typeData { get; }

	// Methods

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	public IResolvedStyle get_resolvedStyle() { }

	// RVA: 0x26AD4F0 Offset: 0x26AC6F0 VA: 0x1826AD4F0 Slot: 19
	private Color UnityEngine.UIElements.IResolvedStyle.get_backgroundColor() { }

	// RVA: 0x26AD520 Offset: 0x26AC720 VA: 0x1826AD520 Slot: 20
	private Color UnityEngine.UIElements.IResolvedStyle.get_borderBottomColor() { }

	// RVA: 0x26AD550 Offset: 0x26AC750 VA: 0x1826AD550 Slot: 21
	private float UnityEngine.UIElements.IResolvedStyle.get_borderBottomLeftRadius() { }

	// RVA: 0x26AD580 Offset: 0x26AC780 VA: 0x1826AD580 Slot: 22
	private float UnityEngine.UIElements.IResolvedStyle.get_borderBottomRightRadius() { }

	// RVA: 0x26AD5B0 Offset: 0x26AC7B0 VA: 0x1826AD5B0 Slot: 23
	private float UnityEngine.UIElements.IResolvedStyle.get_borderBottomWidth() { }

	// RVA: 0x26AD5E0 Offset: 0x26AC7E0 VA: 0x1826AD5E0 Slot: 24
	private Color UnityEngine.UIElements.IResolvedStyle.get_borderLeftColor() { }

	// RVA: 0x26AD610 Offset: 0x26AC810 VA: 0x1826AD610 Slot: 25
	private float UnityEngine.UIElements.IResolvedStyle.get_borderLeftWidth() { }

	// RVA: 0x26AD640 Offset: 0x26AC840 VA: 0x1826AD640 Slot: 26
	private Color UnityEngine.UIElements.IResolvedStyle.get_borderRightColor() { }

	// RVA: 0x26AD670 Offset: 0x26AC870 VA: 0x1826AD670 Slot: 27
	private float UnityEngine.UIElements.IResolvedStyle.get_borderRightWidth() { }

	// RVA: 0x26AD6A0 Offset: 0x26AC8A0 VA: 0x1826AD6A0 Slot: 28
	private Color UnityEngine.UIElements.IResolvedStyle.get_borderTopColor() { }

	// RVA: 0x26AD6D0 Offset: 0x26AC8D0 VA: 0x1826AD6D0 Slot: 29
	private float UnityEngine.UIElements.IResolvedStyle.get_borderTopLeftRadius() { }

	// RVA: 0x26AD700 Offset: 0x26AC900 VA: 0x1826AD700 Slot: 30
	private float UnityEngine.UIElements.IResolvedStyle.get_borderTopRightRadius() { }

	// RVA: 0x26AD730 Offset: 0x26AC930 VA: 0x1826AD730 Slot: 31
	private float UnityEngine.UIElements.IResolvedStyle.get_borderTopWidth() { }

	// RVA: 0x26AD760 Offset: 0x26AC960 VA: 0x1826AD760 Slot: 32
	private float UnityEngine.UIElements.IResolvedStyle.get_bottom() { }

	// RVA: 0x26AD790 Offset: 0x26AC990 VA: 0x1826AD790 Slot: 33
	private Color UnityEngine.UIElements.IResolvedStyle.get_color() { }

	// RVA: 0x26AD7C0 Offset: 0x26AC9C0 VA: 0x1826AD7C0 Slot: 34
	private DisplayStyle UnityEngine.UIElements.IResolvedStyle.get_display() { }

	// RVA: 0x26AD7D0 Offset: 0x26AC9D0 VA: 0x1826AD7D0 Slot: 35
	private FlexDirection UnityEngine.UIElements.IResolvedStyle.get_flexDirection() { }

	// RVA: 0x26AD7E0 Offset: 0x26AC9E0 VA: 0x1826AD7E0 Slot: 36
	private float UnityEngine.UIElements.IResolvedStyle.get_flexGrow() { }

	// RVA: 0x26AD7F0 Offset: 0x26AC9F0 VA: 0x1826AD7F0 Slot: 37
	private float UnityEngine.UIElements.IResolvedStyle.get_flexShrink() { }

	// RVA: 0x26AD800 Offset: 0x26ACA00 VA: 0x1826AD800 Slot: 38
	private float UnityEngine.UIElements.IResolvedStyle.get_height() { }

	// RVA: 0x26AD830 Offset: 0x26ACA30 VA: 0x1826AD830 Slot: 39
	private float UnityEngine.UIElements.IResolvedStyle.get_left() { }

	// RVA: 0x26AD860 Offset: 0x26ACA60 VA: 0x1826AD860 Slot: 40
	private float UnityEngine.UIElements.IResolvedStyle.get_marginBottom() { }

	// RVA: 0x26AD890 Offset: 0x26ACA90 VA: 0x1826AD890 Slot: 41
	private float UnityEngine.UIElements.IResolvedStyle.get_marginLeft() { }

	// RVA: 0x26AD8C0 Offset: 0x26ACAC0 VA: 0x1826AD8C0 Slot: 42
	private float UnityEngine.UIElements.IResolvedStyle.get_marginRight() { }

	// RVA: 0x26AD8F0 Offset: 0x26ACAF0 VA: 0x1826AD8F0 Slot: 43
	private float UnityEngine.UIElements.IResolvedStyle.get_marginTop() { }

	// RVA: 0x26AD920 Offset: 0x26ACB20 VA: 0x1826AD920 Slot: 44
	private StyleFloat UnityEngine.UIElements.IResolvedStyle.get_minHeight() { }

	// RVA: 0x26AD950 Offset: 0x26ACB50 VA: 0x1826AD950 Slot: 45
	private StyleFloat UnityEngine.UIElements.IResolvedStyle.get_minWidth() { }

	// RVA: 0x26AD980 Offset: 0x26ACB80 VA: 0x1826AD980 Slot: 46
	private float UnityEngine.UIElements.IResolvedStyle.get_opacity() { }

	// RVA: 0x26AD990 Offset: 0x26ACB90 VA: 0x1826AD990 Slot: 47
	private float UnityEngine.UIElements.IResolvedStyle.get_paddingBottom() { }

	// RVA: 0x26AD9C0 Offset: 0x26ACBC0 VA: 0x1826AD9C0 Slot: 48
	private float UnityEngine.UIElements.IResolvedStyle.get_paddingLeft() { }

	// RVA: 0x26AD9F0 Offset: 0x26ACBF0 VA: 0x1826AD9F0 Slot: 49
	private float UnityEngine.UIElements.IResolvedStyle.get_paddingRight() { }

	// RVA: 0x26ADA20 Offset: 0x26ACC20 VA: 0x1826ADA20 Slot: 50
	private float UnityEngine.UIElements.IResolvedStyle.get_paddingTop() { }

	// RVA: 0x26ADA50 Offset: 0x26ACC50 VA: 0x1826ADA50 Slot: 51
	private float UnityEngine.UIElements.IResolvedStyle.get_right() { }

	// RVA: 0x26ADA80 Offset: 0x26ACC80 VA: 0x1826ADA80 Slot: 52
	private Scale UnityEngine.UIElements.IResolvedStyle.get_scale() { }

	// RVA: 0x26ADAB0 Offset: 0x26ACCB0 VA: 0x1826ADAB0 Slot: 53
	private float UnityEngine.UIElements.IResolvedStyle.get_top() { }

	// RVA: 0x26ADAE0 Offset: 0x26ACCE0 VA: 0x1826ADAE0 Slot: 54
	private Vector3 UnityEngine.UIElements.IResolvedStyle.get_transformOrigin() { }

	// RVA: 0x26ADB10 Offset: 0x26ACD10 VA: 0x1826ADB10 Slot: 55
	private Vector3 UnityEngine.UIElements.IResolvedStyle.get_translate() { }

	// RVA: 0x26ADB40 Offset: 0x26ACD40 VA: 0x1826ADB40 Slot: 56
	private Color UnityEngine.UIElements.IResolvedStyle.get_unityBackgroundImageTintColor() { }

	// RVA: 0x26ADB70 Offset: 0x26ACD70 VA: 0x1826ADB70 Slot: 57
	private int UnityEngine.UIElements.IResolvedStyle.get_unitySliceLeft() { }

	// RVA: 0x26ADB80 Offset: 0x26ACD80 VA: 0x1826ADB80 Slot: 58
	private int UnityEngine.UIElements.IResolvedStyle.get_unitySliceRight() { }

	// RVA: 0x26ADB90 Offset: 0x26ACD90 VA: 0x1826ADB90 Slot: 59
	private float UnityEngine.UIElements.IResolvedStyle.get_unitySliceScale() { }

	// RVA: 0x26ADBA0 Offset: 0x26ACDA0 VA: 0x1826ADBA0 Slot: 60
	private Color UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineColor() { }

	// RVA: 0x26ADBD0 Offset: 0x26ACDD0 VA: 0x1826ADBD0 Slot: 61
	private float UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineWidth() { }

	// RVA: 0x26ADBE0 Offset: 0x26ACDE0 VA: 0x1826ADBE0 Slot: 62
	private Visibility UnityEngine.UIElements.IResolvedStyle.get_visibility() { }

	// RVA: 0x26ADBF0 Offset: 0x26ACDF0 VA: 0x1826ADBF0 Slot: 63
	private float UnityEngine.UIElements.IResolvedStyle.get_width() { }

	// RVA: 0x26B1E90 Offset: 0x26B1090 VA: 0x1826B1E90
	internal bool get_hasRunningAnimations() { }

	// RVA: 0x26B1D30 Offset: 0x26B0F30 VA: 0x1826B1D30
	internal bool get_hasCompletedAnimations() { }

	[CompilerGenerated]
	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300 Slot: 84
	private int UnityEngine.UIElements.IStylePropertyAnimations.get_runningAnimationCount() { }

	[CompilerGenerated]
	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850 Slot: 85
	private void UnityEngine.UIElements.IStylePropertyAnimations.set_runningAnimationCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480 Slot: 86
	private int UnityEngine.UIElements.IStylePropertyAnimations.get_completedAnimationCount() { }

	[CompilerGenerated]
	// RVA: 0x4D19A0 Offset: 0x4D0BA0 VA: 0x1804D19A0 Slot: 87
	private void UnityEngine.UIElements.IStylePropertyAnimations.set_completedAnimationCount(int value) { }

	// RVA: 0x26A8690 Offset: 0x26A7890 VA: 0x1826A8690
	private IStylePropertyAnimationSystem GetStylePropertyAnimationSystem() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	internal IStylePropertyAnimations get_styleAnimation() { }

	// RVA: 0x26AE730 Offset: 0x26AD930 VA: 0x1826AE730 Slot: 64
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, float from, float to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26AEB60 Offset: 0x26ADD60 VA: 0x1826AEB60 Slot: 65
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26AE170 Offset: 0x26AD370 VA: 0x1826AE170 Slot: 66
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26AED60 Offset: 0x26ADF60 VA: 0x1826AED60 Slot: 67
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Color from, Color to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26ADF70 Offset: 0x26AD170 VA: 0x1826ADF70 Slot: 68
	private bool UnityEngine.UIElements.IStylePropertyAnimations.StartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26AF350 Offset: 0x26AE550 VA: 0x1826AF350 Slot: 69
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26AF050 Offset: 0x26AE250 VA: 0x1826AF050 Slot: 70
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26AE030 Offset: 0x26AD230 VA: 0x1826AE030 Slot: 71
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26AF1B0 Offset: 0x26AE3B0 VA: 0x1826AF1B0 Slot: 72
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26AE880 Offset: 0x26ADA80 VA: 0x1826AE880 Slot: 73
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26AEEC0 Offset: 0x26AE0C0 VA: 0x1826AEEC0 Slot: 74
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26AE5A0 Offset: 0x26AD7A0 VA: 0x1826AE5A0 Slot: 75
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26AE9E0 Offset: 0x26ADBE0 VA: 0x1826AE9E0 Slot: 76
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26AE430 Offset: 0x26AD630 VA: 0x1826AE430 Slot: 77
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundPosition from, BackgroundPosition to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26AEC20 Offset: 0x26ADE20 VA: 0x1826AEC20 Slot: 78
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundRepeat from, BackgroundRepeat to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26AE2B0 Offset: 0x26AD4B0 VA: 0x1826AE2B0 Slot: 79
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundSize from, BackgroundSize to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26ADD80 Offset: 0x26ACF80 VA: 0x1826ADD80 Slot: 82
	private void UnityEngine.UIElements.IStylePropertyAnimations.CancelAnimation(StylePropertyId id) { }

	// RVA: 0x26ADC20 Offset: 0x26ACE20 VA: 0x1826ADC20 Slot: 83
	private void UnityEngine.UIElements.IStylePropertyAnimations.CancelAllAnimations() { }

	// RVA: 0x26AF4D0 Offset: 0x26AE6D0 VA: 0x1826AF4D0 Slot: 80
	private void UnityEngine.UIElements.IStylePropertyAnimations.UpdateAnimation(StylePropertyId id) { }

	// RVA: 0x26ADE00 Offset: 0x26AD000 VA: 0x1826ADE00 Slot: 81
	private void UnityEngine.UIElements.IStylePropertyAnimations.GetAllAnimations(List<StylePropertyId> outPropertyIds) { }

	// RVA: 0x26ACE40 Offset: 0x26AC040 VA: 0x1826ACE40
	internal bool TryConvertLengthUnits(StylePropertyId id, ref Length from, ref Length to, int subPropertyIndex = 0) { }

	// RVA: 0x26AD090 Offset: 0x26AC290 VA: 0x1826AD090
	internal bool TryConvertTransformOriginUnits(ref TransformOrigin from, ref TransformOrigin to) { }

	// RVA: 0x26AD140 Offset: 0x26AC340 VA: 0x1826AD140
	internal bool TryConvertTranslateUnits(ref Translate from, ref Translate to) { }

	// RVA: 0x26ACD50 Offset: 0x26ABF50 VA: 0x1826ACD50
	internal bool TryConvertBackgroundSizeUnits(ref BackgroundSize from, ref BackgroundSize to) { }

	// RVA: 0x26A7E40 Offset: 0x26A7040 VA: 0x1826A7E40
	private Nullable<float> GetParentSizeForLengthConversion(StylePropertyId id, int subPropertyIndex = 0) { }

	// RVA: 0x26B1F00 Offset: 0x26B1100 VA: 0x1826B1F00
	internal bool get_isCompositeRoot() { }

	// RVA: 0x26B2F60 Offset: 0x26B2160 VA: 0x1826B2F60
	internal void set_isCompositeRoot(bool value) { }

	// RVA: 0x26B1F20 Offset: 0x26B1120 VA: 0x1826B1F20
	internal bool get_isHierarchyDisplayed() { }

	// RVA: 0x26B2FD0 Offset: 0x26B21D0 VA: 0x1826B2FD0
	internal void set_isHierarchyDisplayed(bool value) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public string get_viewDataKey() { }

	// RVA: 0x26B40A0 Offset: 0x26B32A0 VA: 0x1826B40A0
	public void set_viewDataKey(string value) { }

	// RVA: 0x26B1B60 Offset: 0x26B0D60 VA: 0x1826B1B60
	internal bool get_enableViewDataPersistence() { }

	// RVA: 0x26B2E50 Offset: 0x26B2050 VA: 0x1826B2E50
	private void set_enableViewDataPersistence(bool value) { }

	// RVA: 0x26B2960 Offset: 0x26B1B60 VA: 0x1826B2960
	public object get_userData() { }

	// RVA: 0x26B4030 Offset: 0x26B3230 VA: 0x1826B4030
	public void set_userData(object value) { }

	// RVA: 0x26B1600 Offset: 0x26B0800 VA: 0x1826B1600 Slot: 16
	public override bool get_canGrabFocus() { }

	// RVA: 0x26B1BE0 Offset: 0x26B0DE0 VA: 0x1826B1BE0 Slot: 15
	public override FocusController get_focusController() { }

	// RVA: 0x26B2930 Offset: 0x26B1B30 VA: 0x1826B2930
	public UsageHints get_usageHints() { }

	// RVA: 0x26B3E60 Offset: 0x26B3060 VA: 0x1826B3E60
	public void set_usageHints(UsageHints value) { }

	// RVA: 0x25B61E0 Offset: 0x25B53E0 VA: 0x1825B61E0
	internal RenderHints get_renderHints() { }

	// RVA: 0x26B3B90 Offset: 0x26B2D90 VA: 0x1826B3B90
	internal void set_renderHints(RenderHints value) { }

	// RVA: 0x26A9080 Offset: 0x26A8280 VA: 0x1826A9080
	internal void MarkRenderHintsClean() { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public ITransform get_transform() { }

	// RVA: 0x26AF550 Offset: 0x26AE750 VA: 0x1826AF550 Slot: 88
	private Vector3 UnityEngine.UIElements.ITransform.get_position() { }

	// RVA: 0x26AF710 Offset: 0x26AE910 VA: 0x1826AF710 Slot: 89
	private void UnityEngine.UIElements.ITransform.set_position(Vector3 value) { }

	// RVA: 0x26AF630 Offset: 0x26AE830 VA: 0x1826AF630 Slot: 90
	private Vector3 UnityEngine.UIElements.ITransform.get_scale() { }

	// RVA: 0x26B1F30 Offset: 0x26B1130 VA: 0x1826B1F30
	internal bool get_isLayoutManual() { }

	// RVA: 0x26B3000 Offset: 0x26B2200 VA: 0x1826B3000
	private void set_isLayoutManual(bool value) { }

	// RVA: 0x26B2500 Offset: 0x26B1700 VA: 0x1826B2500
	internal float get_scaledPixelsPerPoint() { }

	// RVA: 0x26B1FD0 Offset: 0x26B11D0 VA: 0x1826B1FD0
	public Rect get_layout() { }

	// RVA: 0x26B30A0 Offset: 0x26B22A0 VA: 0x1826B30A0
	internal void set_layout(Rect value) { }

	// RVA: 0x26A5EA0 Offset: 0x26A50A0 VA: 0x1826A5EA0
	internal void ClearManualLayout() { }

	// RVA: 0x26B1850 Offset: 0x26B0A50 VA: 0x1826B1850
	public Rect get_contentRect() { }

	// RVA: 0x26B2240 Offset: 0x26B1440 VA: 0x1826B2240
	protected Rect get_paddingRect() { }

	// RVA: 0x26B1EF0 Offset: 0x26B10F0 VA: 0x1826B1EF0
	internal bool get_isBoundingBoxDirty() { }

	// RVA: 0x26B2F30 Offset: 0x26B2130 VA: 0x1826B2F30
	internal void set_isBoundingBoxDirty(bool value) { }

	// RVA: 0x26B3040 Offset: 0x26B2240 VA: 0x1826B3040
	internal void set_isWorldBoundingBoxDirty(bool value) { }

	// RVA: 0x26B1FA0 Offset: 0x26B11A0 VA: 0x1826B1FA0
	internal bool get_isWorldBoundingBoxOrDependenciesDirty() { }

	// RVA: 0x26B15B0 Offset: 0x26B07B0 VA: 0x1826B15B0
	internal Rect get_boundingBox() { }

	// RVA: 0x26B2B30 Offset: 0x26B1D30 VA: 0x1826B2B30
	internal Rect get_worldBoundingBox() { }

	// RVA: 0x26B1550 Offset: 0x26B0750 VA: 0x1826B1550
	private Rect get_boundingBoxInParentSpace() { }

	// RVA: 0x26AFB70 Offset: 0x26AED70 VA: 0x1826AFB70
	internal void UpdateBoundingBox() { }

	// RVA: 0x26B04C0 Offset: 0x26AF6C0 VA: 0x1826B04C0
	internal void UpdateWorldBoundingBox() { }

	// RVA: 0x26B2A30 Offset: 0x26B1C30 VA: 0x1826B2A30
	public Rect get_worldBound() { }

	// RVA: 0x26B2090 Offset: 0x26B1290 VA: 0x1826B2090
	public Rect get_localBound() { }

	// RVA: 0x26B2490 Offset: 0x26B1690 VA: 0x1826B2490
	internal Rect get_rect() { }

	// RVA: 0x160E000 Offset: 0x160D200 VA: 0x18160E000
	internal bool get_isWorldTransformDirty() { }

	// RVA: 0x2093440 Offset: 0x2092640 VA: 0x182093440
	internal void set_isWorldTransformDirty(bool value) { }

	// RVA: 0x2093470 Offset: 0x2092670 VA: 0x182093470
	internal void set_isWorldTransformInverseDirty(bool value) { }

	// RVA: 0x26B1FC0 Offset: 0x26B11C0 VA: 0x1826B1FC0
	internal bool get_isWorldTransformInverseOrDependenciesDirty() { }

	// RVA: 0x26B2D80 Offset: 0x26B1F80 VA: 0x1826B2D80
	public Matrix4x4 get_worldTransform() { }

	// RVA: 0x26B2D50 Offset: 0x26B1F50 VA: 0x1826B2D50
	internal ref Matrix4x4 get_worldTransformRef() { }

	// RVA: 0x26B2CD0 Offset: 0x26B1ED0 VA: 0x1826B2CD0
	internal ref Matrix4x4 get_worldTransformInverse() { }

	// RVA: 0x26B09E0 Offset: 0x26AFBE0 VA: 0x1826B09E0
	internal void UpdateWorldTransform() { }

	// RVA: 0x26B0970 Offset: 0x26AFB70 VA: 0x1826B0970
	internal void UpdateWorldTransformInverse() { }

	// RVA: 0x26B1FB0 Offset: 0x26B11B0 VA: 0x1826B1FB0
	internal bool get_isWorldClipDirty() { }

	// RVA: 0x26B3070 Offset: 0x26B2270 VA: 0x1826B3070
	internal void set_isWorldClipDirty(bool value) { }

	// RVA: 0x26B2C80 Offset: 0x26B1E80 VA: 0x1826B2C80
	internal Rect get_worldClip() { }

	// RVA: 0x26B2C30 Offset: 0x26B1E30 VA: 0x1826B2C30
	internal Rect get_worldClipMinusGroup() { }

	// RVA: 0x26B2BF0 Offset: 0x26B1DF0 VA: 0x1826B2BF0
	internal bool get_worldClipIsInfinite() { }

	// RVA: 0x26A6D20 Offset: 0x26A5F20 VA: 0x1826A6D20
	internal void EnsureWorldTransformAndClipUpToDate() { }

	// RVA: 0x26B0550 Offset: 0x26AF750 VA: 0x1826B0550
	private void UpdateWorldClip() { }

	// RVA: 0x26A66C0 Offset: 0x26A58C0 VA: 0x1826A66C0
	private Rect CombineClipRects(Rect rect, Rect parentRect) { }

	// RVA: 0x26AC5E0 Offset: 0x26AB7E0 VA: 0x1826AC5E0
	private Rect SubstractBorderPadding(Rect worldRect) { }

	// RVA: 0x26A6750 Offset: 0x26A5950 VA: 0x1826A6750
	internal static Rect ComputeAAAlignedBound(Rect position, Matrix4x4 mat) { }

	// RVA: 0x26B2480 Offset: 0x26B1680 VA: 0x1826B2480
	internal PseudoStates get_pseudoStates() { }

	// RVA: 0x26B3B00 Offset: 0x26B2D00 VA: 0x1826B3B00
	internal void set_pseudoStates(PseudoStates value) { }

	[CompilerGenerated]
	// RVA: 0x26B1840 Offset: 0x26B0A40 VA: 0x1826B1840
	internal int get_containedPointerIds() { }

	[CompilerGenerated]
	// RVA: 0x26B2E00 Offset: 0x26B2000 VA: 0x1826B2E00
	private void set_containedPointerIds(int value) { }

	// RVA: 0x26B03A0 Offset: 0x26AF5A0 VA: 0x1826B03A0
	private void UpdateHoverPseudoState() { }

	// RVA: 0x26A8ED0 Offset: 0x26A80D0 VA: 0x1826A8ED0
	private static bool IsPartOfCapturedChain(VisualElement self, in IEventHandler capturingElement) { }

	// RVA: 0x26B23E0 Offset: 0x26B15E0 VA: 0x1826B23E0
	public PickingMode get_pickingMode() { }

	// RVA: 0x26B3AB0 Offset: 0x26B2CB0 VA: 0x1826B3AB0
	public void set_pickingMode(PickingMode value) { }

	// RVA: 0x24CAD90 Offset: 0x24C9F90 VA: 0x1824CAD90
	public string get_name() { }

	// RVA: 0x26B3A50 Offset: 0x26B2C50 VA: 0x1826B3A50
	public void set_name(string value) { }

	// RVA: 0x26B1780 Offset: 0x26B0980 VA: 0x1826B1780
	internal List<string> get_classList() { }

	// RVA: 0x26B1CC0 Offset: 0x26B0EC0 VA: 0x1826B1CC0
	internal string get_fullTypeName() { }

	// RVA: 0x26B2870 Offset: 0x26B1A70 VA: 0x1826B2870
	internal string get_typeName() { }

	[CompilerGenerated]
	// RVA: 0x26B2DF0 Offset: 0x26B1FF0 VA: 0x1826B2DF0
	internal YogaNode get_yogaNode() { }

	[CompilerGenerated]
	// RVA: 0x26B4210 Offset: 0x26B3410 VA: 0x1826B4210
	private void set_yogaNode(YogaNode value) { }

	// RVA: 0x26B1830 Offset: 0x26B0A30 VA: 0x1826B1830
	internal ref ComputedStyle get_computedStyle() { }

	// RVA: 0x26B1E80 Offset: 0x26B1080 VA: 0x1826B1E80
	internal bool get_hasInlineStyle() { }

	// RVA: 0x26B2560 Offset: 0x26B1760 VA: 0x1826B2560
	internal bool get_styleInitialized() { }

	// RVA: 0x26B3C90 Offset: 0x26B2E90 VA: 0x1826B3C90
	internal void set_styleInitialized(bool value) { }

	// RVA: 0x26A5B60 Offset: 0x26A4D60 VA: 0x1826A5B60
	private void ChangeIMGUIContainerCount(int delta) { }

	// RVA: 0x26B10F0 Offset: 0x26B02F0 VA: 0x1826B10F0
	public void .ctor() { }

	[EventInterest(new[] { typeof(MouseOverEvent), typeof(MouseOutEvent), typeof(MouseCaptureOutEvent), typeof(PointerEnterEvent), typeof(PointerLeaveEvent), typeof(PointerCaptureEvent), typeof(PointerCaptureOutEvent), typeof(BlurEvent), typeof(FocusEvent), typeof(TooltipEvent) })]
	// RVA: 0x26A6D50 Offset: 0x26A5F50 VA: 0x1826A6D50 Slot: 12
	protected override void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x26A86C0 Offset: 0x26A78C0 VA: 0x1826A86C0 Slot: 95
	internal virtual Rect GetTooltipRect() { }

	// RVA: 0x26AC340 Offset: 0x26AB540 VA: 0x1826AC340
	private void SetTooltip(TooltipEvent e) { }

	// RVA: 0x26A77F0 Offset: 0x26A69F0 VA: 0x1826A77F0 Slot: 17
	public sealed override void Focus() { }

	// RVA: 0x26AB740 Offset: 0x26AA940 VA: 0x1826AB740
	internal void SetPanel(BaseVisualElementPanel p) { }

	// RVA: 0x26B0CE0 Offset: 0x26AFEE0 VA: 0x1826B0CE0
	private void WillChangePanel(BaseVisualElementPanel destinationPanel) { }

	// RVA: 0x26A86F0 Offset: 0x26A78F0 VA: 0x1826A86F0
	private void HasChangedPanel(BaseVisualElementPanel prevPanel) { }

	// RVA: 0x26AAE80 Offset: 0x26AA080 VA: 0x1826AAE80 Slot: 6
	public sealed override void SendEvent(EventBase e) { }

	// RVA: 0x26AAEA0 Offset: 0x26AA0A0 VA: 0x1826AAEA0 Slot: 7
	internal sealed override void SendEvent(EventBase e, DispatchMode dispatchMode) { }

	// RVA: 0x26A8BC0 Offset: 0x26A7DC0 VA: 0x1826A8BC0
	internal void IncrementVersion(VersionChangeType changeType) { }

	// RVA: 0x26A8EB0 Offset: 0x26A80B0 VA: 0x1826A8EB0
	internal void InvokeHierarchyChanged(HierarchyChangeType changeType) { }

	// RVA: 0x26AB2E0 Offset: 0x26AA4E0 VA: 0x1826AB2E0
	private bool SetEnabledFromHierarchyPrivate(bool state) { }

	// RVA: 0x26B1F40 Offset: 0x26B1140 VA: 0x1826B1F40
	private bool get_isParentEnabledInHierarchy() { }

	// RVA: 0x26B1B70 Offset: 0x26B0D70 VA: 0x1826B1B70
	public bool get_enabledInHierarchy() { }

	[CompilerGenerated]
	// RVA: 0x26B1B80 Offset: 0x26B0D80 VA: 0x1826B1B80
	public bool get_enabledSelf() { }

	[CompilerGenerated]
	// RVA: 0x26B2E80 Offset: 0x26B2080 VA: 0x1826B2E80
	private void set_enabledSelf(bool value) { }

	// RVA: 0x26AB680 Offset: 0x26AA880 VA: 0x1826AB680
	public void SetEnabled(bool value) { }

	// RVA: 0x26A9A60 Offset: 0x26A8C60 VA: 0x1826A9A60
	private void PropagateEnabledToChildren(bool value) { }

	// RVA: 0x2413840 Offset: 0x2412A40 VA: 0x182413840
	public LanguageDirection get_languageDirection() { }

	// RVA: 0x2413860 Offset: 0x2412A60 VA: 0x182413860
	internal LanguageDirection get_localLanguageDirection() { }

	// RVA: 0x26B3940 Offset: 0x26B2B40 VA: 0x1826B3940
	internal void set_localLanguageDirection(LanguageDirection value) { }

	// RVA: 0x26B29E0 Offset: 0x26B1BE0 VA: 0x1826B29E0
	public bool get_visible() { }

	// RVA: 0x26B4110 Offset: 0x26B3310 VA: 0x1826B4110
	public void set_visible(bool value) { }

	// RVA: 0x26A9050 Offset: 0x26A8250 VA: 0x1826A9050
	public void MarkDirtyRepaint() { }

	[CompilerGenerated]
	// RVA: 0x26B1D20 Offset: 0x26B0F20 VA: 0x1826B1D20
	public Action<MeshGenerationContext> get_generateVisualContent() { }

	[CompilerGenerated]
	// RVA: 0x26B2F10 Offset: 0x26B2110 VA: 0x1826B2F10
	public void set_generateVisualContent(Action<MeshGenerationContext> value) { }

	// RVA: 0x26A8D50 Offset: 0x26A7F50 VA: 0x1826A8D50
	internal void InvokeGenerateVisualContent(MeshGenerationContext mgc) { }

	// RVA: 0x26A7B70 Offset: 0x26A6D70 VA: 0x1826A7B70
	internal void GetFullHierarchicalViewDataKey(StringBuilder key) { }

	// RVA: 0x26A7A90 Offset: 0x26A6C90 VA: 0x1826A7A90
	internal string GetFullHierarchicalViewDataKey() { }

	// RVA: -1 Offset: -1
	internal T GetOrCreateViewData<T>(object existing, string key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA30E0 Offset: 0xAA22E0 VA: 0x180AA30E0
	|-VisualElement.GetOrCreateViewData<object>
	*/

	// RVA: 0x26A9590 Offset: 0x26A8790 VA: 0x1826A9590
	internal void OverwriteFromViewData(object obj, string key) { }

	// RVA: 0x26AADF0 Offset: 0x26A9FF0 VA: 0x1826AADF0
	internal void SaveViewData() { }

	// RVA: 0x26A8FA0 Offset: 0x26A81A0 VA: 0x1826A8FA0
	internal bool IsViewDataPersitenceSupportedOnChildren(bool existingState) { }

	// RVA: 0x26A94F0 Offset: 0x26A86F0 VA: 0x1826A94F0
	internal void OnViewDataReady(bool enablePersistence) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 96
	internal virtual void OnViewDataReady() { }

	// RVA: 0x26A6960 Offset: 0x26A5B60 VA: 0x1826A6960 Slot: 97
	public virtual bool ContainsPoint(Vector2 localPoint) { }

	// RVA: 0x26B24F0 Offset: 0x26B16F0 VA: 0x1826B24F0
	internal bool get_requireMeasureFunction() { }

	// RVA: 0x26B3C00 Offset: 0x26B2E00 VA: 0x1826B3C00
	internal void set_requireMeasureFunction(bool value) { }

	// RVA: 0x26A4A40 Offset: 0x26A3C40 VA: 0x1826A4A40
	private void AssignMeasureFunction() { }

	// RVA: 0x26AA680 Offset: 0x26A9880 VA: 0x1826AA680
	private void RemoveMeasureFunction() { }

	// RVA: 0x26A6AA0 Offset: 0x26A5CA0 VA: 0x1826A6AA0 Slot: 98
	protected internal virtual Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode) { }

	// RVA: 0x26A90A0 Offset: 0x26A82A0 VA: 0x1826A90A0
	internal YogaSize Measure(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

	// RVA: 0x26A7480 Offset: 0x26A6680 VA: 0x1826A7480
	private void FinalizeLayout() { }

	// RVA: 0x26AB6A0 Offset: 0x26AA8A0 VA: 0x1826AB6A0
	internal void SetInlineRule(StyleSheet sheet, StyleRule rule) { }

	// RVA: 0x26AB060 Offset: 0x26AA260 VA: 0x1826AB060
	internal void SetComputedStyle(ref ComputedStyle newStyle) { }

	// RVA: 0x26AC870 Offset: 0x26ABA70 VA: 0x1826AC870 Slot: 3
	public override string ToString() { }

	// RVA: 0x24C0D40 Offset: 0x24BFF40 VA: 0x1824C0D40
	internal List<string> GetClassesForIteration() { }

	// RVA: 0x26A4740 Offset: 0x26A3940 VA: 0x1826A4740
	public void AddToClassList(string className) { }

	// RVA: 0x26AA450 Offset: 0x26A9650 VA: 0x1826AA450
	public void RemoveFromClassList(string className) { }

	// RVA: 0x26A6CF0 Offset: 0x26A5EF0 VA: 0x1826A6CF0
	public void EnableInClassList(string className, bool enable) { }

	// RVA: 0x26A5DD0 Offset: 0x26A4FD0 VA: 0x1826A5DD0
	public bool ClassListContains(string cls) { }

	// RVA: 0x26A8540 Offset: 0x26A7740 VA: 0x1826A8540
	internal object GetProperty(PropertyName key) { }

	// RVA: 0x26AC2D0 Offset: 0x26AB4D0 VA: 0x1826AC2D0
	internal void SetProperty(PropertyName key, object value) { }

	// RVA: 0x26A8B50 Offset: 0x26A7D50 VA: 0x1826A8B50
	internal bool HasProperty(PropertyName key) { }

	// RVA: 0x26AD1F0 Offset: 0x26AC3F0 VA: 0x1826AD1F0
	private bool TryGetPropertyInternal(PropertyName key, out object value) { }

	// RVA: 0x26A5BA0 Offset: 0x26A4DA0 VA: 0x1826A5BA0
	private static void CheckUserKeyArgument(PropertyName key) { }

	// RVA: 0x26AC000 Offset: 0x26AB200 VA: 0x1826AC000
	private void SetPropertyInternal(PropertyName key, object value) { }

	// RVA: 0x26B0070 Offset: 0x26AF270 VA: 0x1826B0070
	private void UpdateCursorStyle(long eventType) { }

	// RVA: 0x26B2620 Offset: 0x26B1820 VA: 0x1826B2620
	internal VisualElement.RenderTargetMode get_subRenderTargetMode() { }

	// RVA: 0x26B1B30 Offset: 0x26B0D30 VA: 0x1826B1B30
	internal Material get_defaultMaterial() { }

	// RVA: 0x26A7930 Offset: 0x26A6B30 VA: 0x1826A7930
	private VisualElementAnimationSystem GetAnimationSystem() { }

	// RVA: 0x26AA2D0 Offset: 0x26A94D0 VA: 0x1826AA2D0
	internal void RegisterAnimation(IValueAnimationUpdate anim) { }

	// RVA: 0x26AFA60 Offset: 0x26AEC60 VA: 0x1826AFA60
	internal void UnregisterAnimation(IValueAnimationUpdate anim) { }

	// RVA: 0x26AFAE0 Offset: 0x26AECE0 VA: 0x1826AFAE0
	private void UnregisterRunningAnimations() { }

	// RVA: 0x26AA3E0 Offset: 0x26A95E0 VA: 0x1826AA3E0
	private void RegisterRunningAnimations() { }

	// RVA: -1 Offset: -1
	private static ValueAnimation<T> StartAnimation<T>(ValueAnimation<T> anim, Func<VisualElement, T> fromValueGetter, T to, int durationMs, Action<VisualElement, T> onValueChanged) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA3630 Offset: 0xAA2830 VA: 0x180AA3630
	|-VisualElement.StartAnimation<StyleValues>
	|
	|-RVA: 0xAA34F0 Offset: 0xAA26F0 VA: 0x180AA34F0
	|-VisualElement.StartAnimation<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x26A4AD0 Offset: 0x26A3CD0 VA: 0x1826A4AD0
	private static void AssignStyleValues(VisualElement ve, StyleValues src) { }

	// RVA: 0x26A9B20 Offset: 0x26A8D20 VA: 0x1826A9B20
	private StyleValues ReadCurrentValues(VisualElement ve, StyleValues targetValuesToRead) { }

	// RVA: 0x26AD2F0 Offset: 0x26AC4F0 VA: 0x1826AD2F0 Slot: 91
	private ValueAnimation<StyleValues> UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(StyleValues to, int durationMs) { }

	// RVA: 0x26AC480 Offset: 0x26AB680 VA: 0x1826AC480
	private ValueAnimation<StyleValues> Start(Func<VisualElement, StyleValues> fromValueGetter, StyleValues to, int durationMs) { }

	// RVA: 0x26A6A10 Offset: 0x26A5C10 VA: 0x1826A6A10
	private void DirtyNextParentWithEventCallback() { }

	// RVA: 0x26AAF90 Offset: 0x26AA190 VA: 0x1826AAF90
	private void SetAsNextParentWithEventCallback() { }

	// RVA: 0x26A79E0 Offset: 0x26A6BE0 VA: 0x1826A79E0
	internal bool GetCachedNextParentWithEventCallback(out VisualElement nextParent) { }

	// RVA: 0x26B2120 Offset: 0x26B1320 VA: 0x1826B2120
	internal VisualElement get_nextParentWithEventCallback() { }

	// RVA: 0x26A9A10 Offset: 0x26A8C10 VA: 0x1826A9A10
	private void PropagateCachedNextParentWithEventCallback(VisualElement nextParent, VisualElement stopParent) { }

	// RVA: 0x26B1B90 Offset: 0x26B0D90 VA: 0x1826B1B90
	internal int get_eventCallbackCategories() { }

	// RVA: 0x26B2E90 Offset: 0x26B2090 VA: 0x1826B2E90
	internal void set_eventCallbackCategories(int value) { }

	// RVA: 0x26B1BA0 Offset: 0x26B0DA0 VA: 0x1826B1BA0
	internal int get_eventCallbackParentCategories() { }

	// RVA: 0x26B1F10 Offset: 0x26B1110 VA: 0x1826B1F10
	internal bool get_isEventCallbackParentCategoriesDirty() { }

	// RVA: 0x26B2FA0 Offset: 0x26B21A0 VA: 0x1826B2FA0
	internal void set_isEventCallbackParentCategoriesDirty(bool value) { }

	// RVA: 0x26AFE80 Offset: 0x26AF080 VA: 0x1826AFE80
	private void UpdateCallbackParentCategories() { }

	// RVA: 0x26A8A40 Offset: 0x26A7C40 VA: 0x1826A8A40
	internal bool HasEventCallbacks(EventCategory eventCategory) { }

	// RVA: 0x26A8AD0 Offset: 0x26A7CD0 VA: 0x1826A8AD0
	internal bool HasParentEventCallbacksOrDefaultActions(EventCategory eventCategory) { }

	// RVA: 0x26A8A10 Offset: 0x26A7C10 VA: 0x1826A8A10
	internal bool HasEventCallbacksOrDefaultActions(EventCategory eventCategory) { }

	// RVA: 0x26A8A60 Offset: 0x26A7C60 VA: 0x1826A8A60
	internal bool HasParentEventCallbacksOrDefaultActionAtTarget(EventCategory eventCategory) { }

	// RVA: 0x26A89E0 Offset: 0x26A7BE0 VA: 0x1826A89E0
	internal bool HasEventCallbacksOrDefaultActionAtTarget(EventCategory eventCategory) { }

	// RVA: 0x26A89C0 Offset: 0x26A7BC0 VA: 0x1826A89C0
	internal bool HasDefaultAction(EventCategory eventCategory) { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public IExperimentalFeatures get_experimental() { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090 Slot: 92
	private ITransitionAnimations UnityEngine.UIElements.IExperimentalFeatures.get_animation() { }

	[CompilerGenerated]
	// RVA: 0x26B1EE0 Offset: 0x26B10E0 VA: 0x1826B1EE0
	public VisualElement.Hierarchy get_hierarchy() { }

	[CompilerGenerated]
	// RVA: 0x26B2F20 Offset: 0x26B2120 VA: 0x1826B2F20
	private void set_hierarchy(VisualElement.Hierarchy value) { }

	[CompilerGenerated]
	// RVA: 0x26B1F90 Offset: 0x26B1190 VA: 0x1826B1F90
	internal bool get_isRootVisualContainer() { }

	[CompilerGenerated]
	// RVA: 0x26B3030 Offset: 0x26B2230 VA: 0x1826B3030
	internal void set_isRootVisualContainer(bool value) { }

	// RVA: 0x26B1B40 Offset: 0x26B0D40 VA: 0x1826B1B40
	internal bool get_disableClipping() { }

	// RVA: 0x26B2E10 Offset: 0x26B2010 VA: 0x1826B2E10
	internal void set_disableClipping(bool value) { }

	// RVA: 0x26AC440 Offset: 0x26AB640 VA: 0x1826AC440
	internal bool ShouldClip() { }

	// RVA: 0x26B23D0 Offset: 0x26B15D0 VA: 0x1826B23D0
	public VisualElement get_parent() { }

	[CompilerGenerated]
	// RVA: 0x26B1B50 Offset: 0x26B0D50 VA: 0x1826B1B50
	internal BaseVisualElementPanel get_elementPanel() { }

	[CompilerGenerated]
	// RVA: 0x26B2E40 Offset: 0x26B2040 VA: 0x1826B2E40
	private void set_elementPanel(BaseVisualElementPanel value) { }

	// RVA: 0x26B23C0 Offset: 0x26B15C0 VA: 0x1826B23C0
	public IPanel get_panel() { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090 Slot: 99
	public virtual VisualElement get_contentContainer() { }

	// RVA: 0x26B4200 Offset: 0x26B3400 VA: 0x1826B4200
	internal void set_visualTreeAssetSource(VisualTreeAsset value) { }

	// RVA: 0x26A4940 Offset: 0x26A3B40 VA: 0x1826A4940
	public void Add(VisualElement child) { }

	// RVA: 0x26A8CB0 Offset: 0x26A7EB0 VA: 0x1826A8CB0
	public void Insert(int index, VisualElement element) { }

	// RVA: 0x26A6640 Offset: 0x26A5840 VA: 0x1826A6640
	public void Clear() { }

	// RVA: 0x26A6CE0 Offset: 0x26A5EE0 VA: 0x1826A6CE0
	public VisualElement ElementAt(int index) { }

	// RVA: 0x26B1490 Offset: 0x26B0690 VA: 0x1826B1490
	public VisualElement get_Item(int key) { }

	// RVA: 0x26B16E0 Offset: 0x26B08E0 VA: 0x1826B16E0
	public int get_childCount() { }

	// RVA: 0x26A8BF0 Offset: 0x26A7DF0 VA: 0x1826A8BF0
	public int IndexOf(VisualElement element) { }

	// RVA: 0x26A6AC0 Offset: 0x26A5CC0 VA: 0x1826A6AC0
	internal VisualElement ElementAtTreePath(List<int> childIndexes) { }

	// RVA: 0x26A76B0 Offset: 0x26A68B0 VA: 0x1826A76B0
	internal bool FindElementInTree(VisualElement element, List<int> outChildIndexes) { }

	// RVA: 0x26A5D10 Offset: 0x26A4F10 VA: 0x1826A5D10
	public IEnumerable<VisualElement> Children() { }

	// RVA: 0x26A5790 Offset: 0x26A4990 VA: 0x1826A5790
	public void BringToFront() { }

	// RVA: 0x26AAEC0 Offset: 0x26AA0C0 VA: 0x1826AAEC0
	public void SendToBack() { }

	// RVA: 0x26A9900 Offset: 0x26A8B00 VA: 0x1826A9900
	public void PlaceBehind(VisualElement sibling) { }

	// RVA: 0x26AA580 Offset: 0x26A9780 VA: 0x1826AA580
	public void RemoveFromHierarchy() { }

	// RVA: -1 Offset: -1
	public T GetFirstOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA2F60 Offset: 0xAA2160 VA: 0x180AA2F60
	|-VisualElement.GetFirstOfType<object>
	*/

	// RVA: -1 Offset: -1
	public T GetFirstAncestorOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA2E60 Offset: 0xAA2060 VA: 0x180AA2E60
	|-VisualElement.GetFirstAncestorOfType<object>
	*/

	// RVA: 0x26A7A10 Offset: 0x26A6C10 VA: 0x1826A7A10
	internal VisualElement GetFirstAncestorWhere(Predicate<VisualElement> predicate) { }

	// RVA: 0x26A69C0 Offset: 0x26A5BC0 VA: 0x1826A69C0
	public bool Contains(VisualElement child) { }

	// RVA: 0x26A7870 Offset: 0x26A6A70 VA: 0x1826A7870
	private void GatherAllChildren(List<VisualElement> elements) { }

	// RVA: 0x26A7520 Offset: 0x26A6720 VA: 0x1826A7520
	public VisualElement FindCommonAncestor(VisualElement other) { }

	// RVA: 0x26A8610 Offset: 0x26A7810 VA: 0x1826A8610
	internal VisualElement GetRoot() { }

	// RVA: 0x26A85C0 Offset: 0x26A77C0 VA: 0x1826A85C0
	internal VisualElement GetRootVisualContainer() { }

	// RVA: 0x26A7C00 Offset: 0x26A6E00 VA: 0x1826A7C00
	internal VisualElement GetNextElementDepthFirst() { }

	// RVA: 0x26A8410 Offset: 0x26A7610 VA: 0x1826A8410
	internal VisualElement GetPreviousElementDepthFirst() { }

	// RVA: 0x26AAD40 Offset: 0x26A9F40 VA: 0x1826AAD40
	internal VisualElement RetargetElement(VisualElement retargetAgainst) { }

	// RVA: 0x26B23F0 Offset: 0x26B15F0 VA: 0x1826B23F0
	private Vector3 get_positionWithLayout() { }

	// RVA: 0x26A8080 Offset: 0x26A7280 VA: 0x1826A8080
	internal void GetPivotedMatrixWithLayout(out Matrix4x4 result) { }

	// RVA: 0x26B1D80 Offset: 0x26B0F80 VA: 0x1826B1D80
	internal bool get_hasDefaultRotationAndScale() { }

	// RVA: 0x26A9220 Offset: 0x26A8420 VA: 0x1826A9220
	internal static float Min(float a, float b, float c, float d) { }

	// RVA: 0x26A9090 Offset: 0x26A8290 VA: 0x1826A9090
	internal static float Max(float a, float b, float c, float d) { }

	// RVA: 0x26AC9F0 Offset: 0x26ABBF0 VA: 0x1826AC9F0
	private void TransformAlignedRectToParentSpace(ref Rect rect) { }

	// RVA: 0x26A57E0 Offset: 0x26A49E0 VA: 0x1826A57E0
	internal static Rect CalculateConservativeRect(ref Matrix4x4 matrix, Rect rect) { }

	// RVA: 0x26ACB30 Offset: 0x26ABD30 VA: 0x1826ACB30
	internal static void TransformAlignedRect(ref Matrix4x4 matrix, ref Rect rect) { }

	// RVA: 0x26A9540 Offset: 0x26A8740 VA: 0x1826A9540
	internal static void OrderMinMaxRect(ref Rect rect) { }

	// RVA: 0x26A9460 Offset: 0x26A8660 VA: 0x1826A9460
	internal static Vector2 MultiplyMatrix44Point2(ref Matrix4x4 lhs, Vector2 point) { }

	// RVA: 0x26A94B0 Offset: 0x26A86B0 VA: 0x1826A94B0
	internal static Vector2 MultiplyVector2(ref Matrix4x4 lhs, Vector2 vector) { }

	// RVA: 0x26A9230 Offset: 0x26A8430 VA: 0x1826A9230
	internal static void MultiplyMatrix34(ref Matrix4x4 lhs, ref Matrix4x4 rhs, out Matrix4x4 res) { }

	// RVA: 0x26ACC40 Offset: 0x26ABE40 VA: 0x1826ACC40
	private static void TranslateMatrix34(ref Matrix4x4 lhs, Vector3 rhs, out Matrix4x4 res) { }

	// RVA: 0x26ACBB0 Offset: 0x26ABDB0 VA: 0x1826ACBB0
	private static void TranslateMatrix34InPlace(ref Matrix4x4 lhs, Vector3 rhs) { }

	// RVA: 0x17F7090 Offset: 0x17F6290 VA: 0x1817F7090
	public IVisualElementScheduler get_schedule() { }

	// RVA: 0x26AF8A0 Offset: 0x26AEAA0 VA: 0x1826AF8A0 Slot: 93
	private IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(Action<TimerState> timerUpdateEvent) { }

	// RVA: 0x26AF980 Offset: 0x26AEB80 VA: 0x1826AF980 Slot: 94
	private IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(Action updateEvent) { }

	// RVA: 0x26B25A0 Offset: 0x26B17A0 VA: 0x1826B25A0
	public IStyle get_style() { }

	// RVA: 0x26B1AA0 Offset: 0x26B0CA0 VA: 0x1826B1AA0
	public ICustomStyle get_customStyle() { }

	// RVA: 0x26B2570 Offset: 0x26B1770 VA: 0x1826B2570
	public VisualElementStyleSheetSet get_styleSheets() { }

	// RVA: 0x26A44E0 Offset: 0x26A36E0 VA: 0x1826A44E0
	internal void AddStyleSheetPath(string sheetPath) { }

	// RVA: 0x26AA6B0 Offset: 0x26A98B0 VA: 0x1826AA6B0
	private StyleFloat ResolveLengthValue(Length length, bool isRow) { }

	// RVA: 0x26AABA0 Offset: 0x26A9DA0 VA: 0x1826AABA0
	private Vector3 ResolveTranslate() { }

	// RVA: 0x26AA9A0 Offset: 0x26A9BA0 VA: 0x1826AA9A0
	private Vector3 ResolveTransformOrigin() { }

	// RVA: 0x26AA7F0 Offset: 0x26A99F0 VA: 0x1826AA7F0
	private Quaternion ResolveRotation() { }

	// RVA: 0x26AA8D0 Offset: 0x26A9AD0 VA: 0x1826AA8D0
	private Vector3 ResolveScale() { }

	// RVA: 0x26B2630 Offset: 0x26B1830 VA: 0x1826B2630
	public string get_tooltip() { }

	// RVA: 0x26B3CC0 Offset: 0x26B2EC0 VA: 0x1826B3CC0
	public void set_tooltip(string value) { }

	// RVA: 0x26A7D20 Offset: 0x26A6F20 VA: 0x1826A7D20
	internal static VisualElement.TypeData GetOrCreateTypeData(Type t) { }

	// RVA: 0x26B2730 Offset: 0x26B1930 VA: 0x1826B2730
	private VisualElement.TypeData get_typeData() { }

	// RVA: 0x26B0E60 Offset: 0x26B0060 VA: 0x1826B0E60
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x26A90A0 Offset: 0x26A82A0 VA: 0x1826A90A0
	private YogaSize <AssignMeasureFunction>b__432_0(YogaNode node, float f, YogaMeasureMode mode, float f1, YogaMeasureMode heightMode) { }
}

// Namespace: UnityEngine.UIElements
internal interface IStyleDataGroup<T> // TypeDefIndex: 11429
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T Copy();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IStyleDataGroup<__Il2CppFullySharedGenericType>.Copy
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void CopyFrom(ref T other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IStyleDataGroup<__Il2CppFullySharedGenericType>.CopyFrom
	*/
}

// Namespace: UnityEngine.UIElements
internal struct InheritedData : IStyleDataGroup<InheritedData>, IEquatable<InheritedData> // TypeDefIndex: 11430
{
	// Fields
	public Color color; // 0x0
	public Length fontSize; // 0x10
	public Length letterSpacing; // 0x18
	public TextShadow textShadow; // 0x20
	public Font unityFont; // 0x40
	public FontDefinition unityFontDefinition; // 0x48
	public FontStyle unityFontStyleAndWeight; // 0x58
	public Length unityParagraphSpacing; // 0x5C
	public TextAnchor unityTextAlign; // 0x64
	public Color unityTextOutlineColor; // 0x68
	public float unityTextOutlineWidth; // 0x78
	public Visibility visibility; // 0x7C
	public WhiteSpace whiteSpace; // 0x80
	public Length wordSpacing; // 0x84

	// Methods

	// RVA: 0x26A2F10 Offset: 0x26A2110 VA: 0x1826A2F10 Slot: 4
	public InheritedData Copy() { }

	// RVA: 0x26A2E90 Offset: 0x26A2090 VA: 0x1826A2E90 Slot: 5
	public void CopyFrom(ref InheritedData other) { }

	// RVA: 0x26A32B0 Offset: 0x26A24B0 VA: 0x1826A32B0
	public static bool op_Equality(InheritedData lhs, InheritedData rhs) { }

	// RVA: 0x26A2F60 Offset: 0x26A2160 VA: 0x1826A2F60 Slot: 6
	public bool Equals(InheritedData other) { }

	// RVA: 0x26A3030 Offset: 0x26A2230 VA: 0x1826A3030 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26A3130 Offset: 0x26A2330 VA: 0x1826A3130 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.UIElements
internal struct LayoutData : IStyleDataGroup<LayoutData>, IEquatable<LayoutData> // TypeDefIndex: 11431
{
	// Fields
	public Align alignContent; // 0x0
	public Align alignItems; // 0x4
	public Align alignSelf; // 0x8
	public float borderBottomWidth; // 0xC
	public float borderLeftWidth; // 0x10
	public float borderRightWidth; // 0x14
	public float borderTopWidth; // 0x18
	public Length bottom; // 0x1C
	public DisplayStyle display; // 0x24
	public Length flexBasis; // 0x28
	public FlexDirection flexDirection; // 0x30
	public float flexGrow; // 0x34
	public float flexShrink; // 0x38
	public Wrap flexWrap; // 0x3C
	public Length height; // 0x40
	public Justify justifyContent; // 0x48
	public Length left; // 0x4C
	public Length marginBottom; // 0x54
	public Length marginLeft; // 0x5C
	public Length marginRight; // 0x64
	public Length marginTop; // 0x6C
	public Length maxHeight; // 0x74
	public Length maxWidth; // 0x7C
	public Length minHeight; // 0x84
	public Length minWidth; // 0x8C
	public Length paddingBottom; // 0x94
	public Length paddingLeft; // 0x9C
	public Length paddingRight; // 0xA4
	public Length paddingTop; // 0xAC
	public Position position; // 0xB4
	public Length right; // 0xB8
	public Length top; // 0xC0
	public Length width; // 0xC8

	// Methods

	// RVA: 0x26B43F0 Offset: 0x26B35F0 VA: 0x1826B43F0 Slot: 4
	public LayoutData Copy() { }

	// RVA: 0x26B42E0 Offset: 0x26B34E0 VA: 0x1826B42E0 Slot: 5
	public void CopyFrom(ref LayoutData other) { }

	// RVA: 0x26B4A10 Offset: 0x26B3C10 VA: 0x1826B4A10
	public static bool op_Equality(LayoutData lhs, LayoutData rhs) { }

	// RVA: 0x26B45A0 Offset: 0x26B37A0 VA: 0x1826B45A0 Slot: 6
	public bool Equals(LayoutData other) { }

	// RVA: 0x26B4470 Offset: 0x26B3670 VA: 0x1826B4470 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26B46D0 Offset: 0x26B38D0 VA: 0x1826B46D0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.UIElements
internal struct RareData : IStyleDataGroup<RareData>, IEquatable<RareData> // TypeDefIndex: 11432
{
	// Fields
	public Cursor cursor; // 0x0
	public TextOverflow textOverflow; // 0x18
	public Color unityBackgroundImageTintColor; // 0x1C
	public OverflowClipBox unityOverflowClipBox; // 0x2C
	public int unitySliceBottom; // 0x30
	public int unitySliceLeft; // 0x34
	public int unitySliceRight; // 0x38
	public float unitySliceScale; // 0x3C
	public int unitySliceTop; // 0x40
	public TextOverflowPosition unityTextOverflowPosition; // 0x44

	// Methods

	// RVA: 0x26B7F80 Offset: 0x26B7180 VA: 0x1826B7F80 Slot: 4
	public RareData Copy() { }

	// RVA: 0x26B7F50 Offset: 0x26B7150 VA: 0x1826B7F50 Slot: 5
	public void CopyFrom(ref RareData other) { }

	// RVA: 0x26B8300 Offset: 0x26B7500 VA: 0x1826B8300
	public static bool op_Equality(RareData lhs, RareData rhs) { }

	// RVA: 0x26B8070 Offset: 0x26B7270 VA: 0x1826B8070 Slot: 6
	public bool Equals(RareData other) { }

	// RVA: 0x26B7FB0 Offset: 0x26B71B0 VA: 0x1826B7FB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26B8270 Offset: 0x26B7470 VA: 0x1826B8270 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.UIElements
internal struct TransformData : IStyleDataGroup<TransformData>, IEquatable<TransformData> // TypeDefIndex: 11433
{
	// Fields
	public Rotate rotate; // 0x0
	public Scale scale; // 0x18
	public TransformOrigin transformOrigin; // 0x28
	public Translate translate; // 0x3C

	// Methods

	// RVA: 0x26C41A0 Offset: 0x26C33A0 VA: 0x1826C41A0 Slot: 4
	public TransformData Copy() { }

	// RVA: 0x26C4170 Offset: 0x26C3370 VA: 0x1826C4170 Slot: 5
	public void CopyFrom(ref TransformData other) { }

	// RVA: 0x26C44D0 Offset: 0x26C36D0 VA: 0x1826C44D0
	public static bool op_Equality(TransformData lhs, TransformData rhs) { }

	// RVA: 0x26C41D0 Offset: 0x26C33D0 VA: 0x1826C41D0 Slot: 6
	public bool Equals(TransformData other) { }

	// RVA: 0x26C4260 Offset: 0x26C3460 VA: 0x1826C4260 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26C4390 Offset: 0x26C3590 VA: 0x1826C4390 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.UIElements
internal struct TransitionData : IStyleDataGroup<TransitionData>, IEquatable<TransitionData> // TypeDefIndex: 11434
{
	// Fields
	public List<TimeValue> transitionDelay; // 0x0
	public List<TimeValue> transitionDuration; // 0x8
	public List<StylePropertyName> transitionProperty; // 0x10
	public List<EasingFunction> transitionTimingFunction; // 0x18

	// Methods

	// RVA: 0x26C4EB0 Offset: 0x26C40B0 VA: 0x1826C4EB0 Slot: 4
	public TransitionData Copy() { }

	// RVA: 0x26C4D40 Offset: 0x26C3F40 VA: 0x1826C4D40 Slot: 5
	public void CopyFrom(ref TransitionData other) { }

	// RVA: 0x26C51C0 Offset: 0x26C43C0 VA: 0x1826C51C0
	public static bool op_Equality(TransitionData lhs, TransitionData rhs) { }

	// RVA: 0x26C5000 Offset: 0x26C4200 VA: 0x1826C5000 Slot: 6
	public bool Equals(TransitionData other) { }

	// RVA: 0x26C5040 Offset: 0x26C4240 VA: 0x1826C5040 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26C5100 Offset: 0x26C4300 VA: 0x1826C5100 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.UIElements
internal struct VisualData : IStyleDataGroup<VisualData>, IEquatable<VisualData> // TypeDefIndex: 11435
{
	// Fields
	public Color backgroundColor; // 0x0
	public Background backgroundImage; // 0x10
	public BackgroundPosition backgroundPositionX; // 0x30
	public BackgroundPosition backgroundPositionY; // 0x3C
	public BackgroundRepeat backgroundRepeat; // 0x48
	public BackgroundSize backgroundSize; // 0x50
	public Color borderBottomColor; // 0x64
	public Length borderBottomLeftRadius; // 0x74
	public Length borderBottomRightRadius; // 0x7C
	public Color borderLeftColor; // 0x84
	public Color borderRightColor; // 0x94
	public Color borderTopColor; // 0xA4
	public Length borderTopLeftRadius; // 0xB4
	public Length borderTopRightRadius; // 0xBC
	public float opacity; // 0xC4
	public OverflowInternal overflow; // 0xC8

	// Methods

	// RVA: 0x26B43F0 Offset: 0x26B35F0 VA: 0x1826B43F0 Slot: 4
	public VisualData Copy() { }

	// RVA: 0x26B42E0 Offset: 0x26B34E0 VA: 0x1826B42E0 Slot: 5
	public void CopyFrom(ref VisualData other) { }

	// RVA: 0x26CC260 Offset: 0x26CB460 VA: 0x1826CC260
	public static bool op_Equality(VisualData lhs, VisualData rhs) { }

	// RVA: 0x26CBE60 Offset: 0x26CB060 VA: 0x1826CBE60 Slot: 6
	public bool Equals(VisualData other) { }

	// RVA: 0x26CBF90 Offset: 0x26CB190 VA: 0x1826CBF90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26CC0C0 Offset: 0x26CB2C0 VA: 0x1826CC0C0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.UIElements
internal class StyleValueCollection // TypeDefIndex: 11436
{
	// Fields
	internal List<StyleValue> m_Values; // 0x10

	// Methods

	// RVA: 0x26BF8D0 Offset: 0x26BEAD0 VA: 0x1826BF8D0
	public StyleLength GetStyleLength(StylePropertyId id) { }

	// RVA: 0x26BF7E0 Offset: 0x26BE9E0 VA: 0x1826BF7E0
	public StyleFloat GetStyleFloat(StylePropertyId id) { }

	// RVA: 0x26BF850 Offset: 0x26BEA50 VA: 0x1826BF850
	public StyleInt GetStyleInt(StylePropertyId id) { }

	// RVA: 0x26BFB50 Offset: 0x26BED50 VA: 0x1826BFB50
	public bool TryGetStyleValue(StylePropertyId id, ref StyleValue value) { }

	// RVA: 0x26BF980 Offset: 0x26BEB80 VA: 0x1826BF980
	public void SetStyleValue(StyleValue value) { }

	// RVA: 0x26BFCA0 Offset: 0x26BEEA0 VA: 0x1826BFCA0
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements
public enum LengthUnit // TypeDefIndex: 11437
{
	// Fields
	public int value__; // 0x0
	public const LengthUnit Pixel = 0;
	public const LengthUnit Percent = 1;
}

// Namespace: 
private enum Length.Unit // TypeDefIndex: 11438
{
	// Fields
	public int value__; // 0x0
	public const Length.Unit Pixel = 0;
	public const Length.Unit Percent = 1;
	public const Length.Unit Auto = 2;
	public const Length.Unit None = 3;
}

// Namespace: UnityEngine.UIElements
[Serializable]
public struct Length : IEquatable<Length> // TypeDefIndex: 11439
{
	// Fields
	internal const float k_MaxValue = 8388608;
	[SerializeField]
	private float m_Value; // 0x0
	[SerializeField]
	private Length.Unit m_Unit; // 0x4

	// Properties
	public float value { get; set; }
	public LengthUnit unit { get; }

	// Methods

	// RVA: 0x26B7510 Offset: 0x26B6710 VA: 0x1826B7510
	public static Length Percent(float value) { }

	// RVA: 0x26B7400 Offset: 0x26B6600 VA: 0x1826B7400
	public static Length Auto() { }

	// RVA: 0x26B74F0 Offset: 0x26B66F0 VA: 0x1826B74F0
	public static Length None() { }

	// RVA: 0x439FA0 Offset: 0x4391A0 VA: 0x180439FA0
	public float get_value() { }

	// RVA: 0x26B7770 Offset: 0x26B6970 VA: 0x1826B7770
	public void set_value(float value) { }

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public LengthUnit get_unit() { }

	// RVA: 0x26B74D0 Offset: 0x26B66D0 VA: 0x1826B74D0
	public bool IsAuto() { }

	// RVA: 0x26B74E0 Offset: 0x26B66E0 VA: 0x1826B74E0
	public bool IsNone() { }

	// RVA: 0x26B76D0 Offset: 0x26B68D0 VA: 0x1826B76D0
	public void .ctor(float value) { }

	// RVA: 0x26B76A0 Offset: 0x26B68A0 VA: 0x1826B76A0
	public void .ctor(float value, LengthUnit unit) { }

	// RVA: 0x26B76A0 Offset: 0x26B68A0 VA: 0x1826B76A0
	private void .ctor(float value, Length.Unit unit) { }

	// RVA: 0x26B7700 Offset: 0x26B6900 VA: 0x1826B7700
	public static Length op_Implicit(float value) { }

	// RVA: 0x268C670 Offset: 0x268B870 VA: 0x18268C670
	public static bool op_Equality(Length lhs, Length rhs) { }

	// RVA: 0x26B7740 Offset: 0x26B6940 VA: 0x1826B7740
	public static bool op_Inequality(Length lhs, Length rhs) { }

	// RVA: 0x268C440 Offset: 0x268B640 VA: 0x18268C440 Slot: 4
	public bool Equals(Length other) { }

	// RVA: 0x26B7420 Offset: 0x26B6620 VA: 0x1826B7420 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x268C470 Offset: 0x268B670 VA: 0x18268C470 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26B7550 Offset: 0x26B6750 VA: 0x1826B7550 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.UIElements
public struct Rotate : IEquatable<Rotate> // TypeDefIndex: 11440
{
	// Fields
	private Angle m_Angle; // 0x0
	private Vector3 m_Axis; // 0x8
	private bool m_IsNone; // 0x14

	// Properties
	public Angle angle { get; set; }
	internal Vector3 axis { get; }

	// Methods

	// RVA: 0x26B8930 Offset: 0x26B7B30 VA: 0x1826B8930
	public void .ctor(Angle angle) { }

	// RVA: 0x26B8730 Offset: 0x26B7930 VA: 0x1826B8730
	internal static Rotate Initial() { }

	// RVA: 0x26B87C0 Offset: 0x26B79C0 VA: 0x1826B87C0
	public static Rotate None() { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Angle get_angle() { }

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_angle(Angle value) { }

	// RVA: 0x26B8980 Offset: 0x26B7B80 VA: 0x1826B8980
	internal Vector3 get_axis() { }

	// RVA: 0x26B89A0 Offset: 0x26B7BA0 VA: 0x1826B89A0
	public static bool op_Equality(Rotate lhs, Rotate rhs) { }

	// RVA: 0x26B8A90 Offset: 0x26B7C90 VA: 0x1826B8A90
	public static bool op_Inequality(Rotate lhs, Rotate rhs) { }

	// RVA: 0x26B8580 Offset: 0x26B7780 VA: 0x1826B8580 Slot: 4
	public bool Equals(Rotate other) { }

	// RVA: 0x26B84E0 Offset: 0x26B76E0 VA: 0x1826B84E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26B8660 Offset: 0x26B7860 VA: 0x1826B8660 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26B88C0 Offset: 0x26B7AC0 VA: 0x1826B88C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x26B8860 Offset: 0x26B7A60 VA: 0x1826B8860
	internal Quaternion ToQuaternion() { }
}

// Namespace: UnityEngine.UIElements
public struct Scale : IEquatable<Scale> // TypeDefIndex: 11441
{
	// Fields
	private Vector3 m_Scale; // 0x0
	private bool m_IsNone; // 0xC

	// Properties
	public Vector3 value { get; }

	// Methods

	// RVA: 0x26B8E40 Offset: 0x26B8040 VA: 0x1826B8E40
	public void .ctor(Vector3 scale) { }

	// RVA: 0x26B8D00 Offset: 0x26B7F00 VA: 0x1826B8D00
	internal static Scale Initial() { }

	// RVA: 0x26B8E00 Offset: 0x26B8000 VA: 0x1826B8E00
	public static Scale None() { }

	// RVA: 0xAA0C00 Offset: 0xA9FE00 VA: 0x180AA0C00
	public Vector3 get_value() { }

	// RVA: 0x26B8EE0 Offset: 0x26B80E0 VA: 0x1826B8EE0
	public static bool op_Equality(Scale lhs, Scale rhs) { }

	// RVA: 0x26B8F40 Offset: 0x26B8140 VA: 0x1826B8F40
	public static bool op_Inequality(Scale lhs, Scale rhs) { }

	// RVA: 0x26B8B80 Offset: 0x26B7D80 VA: 0x1826B8B80 Slot: 4
	public bool Equals(Scale other) { }

	// RVA: 0x26B8BD0 Offset: 0x26B7DD0 VA: 0x1826B8BD0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26B8CA0 Offset: 0x26B7EA0 VA: 0x1826B8CA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x248AE40 Offset: 0x248A040 VA: 0x18248AE40 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.UIElements
public struct StyleBackgroundSize : IStyleValue<BackgroundSize>, IEquatable<StyleBackgroundSize> // TypeDefIndex: 11442
{
	// Fields
	private BackgroundSize m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x14

	// Properties
	public BackgroundSize value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x26B9210 Offset: 0x26B8410 VA: 0x1826B9210 Slot: 4
	public BackgroundSize get_value() { }

	// RVA: 0x10EBDC0 Offset: 0x10EAFC0 VA: 0x1810EBDC0 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x26B9200 Offset: 0x26B8400 VA: 0x1826B9200
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x26B91E0 Offset: 0x26B83E0 VA: 0x1826B91E0
	internal void .ctor(BackgroundSize v, StyleKeyword keyword) { }

	// RVA: 0x26B9240 Offset: 0x26B8440 VA: 0x1826B9240
	public static bool op_Equality(StyleBackgroundSize lhs, StyleBackgroundSize rhs) { }

	// RVA: 0x26B92E0 Offset: 0x26B84E0 VA: 0x1826B92E0
	public static StyleBackgroundSize op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x26B90B0 Offset: 0x26B82B0 VA: 0x1826B90B0 Slot: 6
	public bool Equals(StyleBackgroundSize other) { }

	// RVA: 0x26B8F90 Offset: 0x26B8190 VA: 0x1826B8F90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26B9150 Offset: 0x26B8350 VA: 0x1826B9150 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26B9170 Offset: 0x26B8370 VA: 0x1826B9170 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.UIElements
public struct StyleColor : IStyleValue<Color>, IEquatable<StyleColor> // TypeDefIndex: 11443
{
	// Fields
	private Color m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x10

	// Properties
	public Color value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x26B9520 Offset: 0x26B8720 VA: 0x1826B9520 Slot: 4
	public Color get_value() { }

	// RVA: 0x24765D0 Offset: 0x24757D0 VA: 0x1824765D0 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x1700100 Offset: 0x16FF300 VA: 0x181700100
	public void .ctor(Color v) { }

	// RVA: 0x13144C0 Offset: 0x13136C0 VA: 0x1813144C0
	internal void .ctor(Color v, StyleKeyword keyword) { }

	// RVA: 0x26B9540 Offset: 0x26B8740 VA: 0x1826B9540
	public static bool op_Equality(StyleColor lhs, StyleColor rhs) { }

	// RVA: 0x26B95C0 Offset: 0x26B87C0 VA: 0x1826B95C0
	public static StyleColor op_Implicit(Color v) { }

	// RVA: 0x26B9310 Offset: 0x26B8510 VA: 0x1826B9310 Slot: 6
	public bool Equals(StyleColor other) { }

	// RVA: 0x26B9390 Offset: 0x26B8590 VA: 0x1826B9390 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26B9490 Offset: 0x26B8690 VA: 0x1826B9490 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26B94B0 Offset: 0x26B86B0 VA: 0x1826B94B0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.UIElements
public struct StyleCursor : IStyleValue<Cursor>, IEquatable<StyleCursor> // TypeDefIndex: 11444
{
	// Fields
	private Cursor m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x18

	// Properties
	public Cursor value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x26BA6D0 Offset: 0x26B98D0 VA: 0x1826BA6D0 Slot: 4
	public Cursor get_value() { }

	// RVA: 0xB78A40 Offset: 0xB77C40 VA: 0x180B78A40 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x26BA6A0 Offset: 0x26B98A0 VA: 0x1826BA6A0
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x13144A0 Offset: 0x13136A0 VA: 0x1813144A0
	internal void .ctor(Cursor v, StyleKeyword keyword) { }

	// RVA: 0x26BA720 Offset: 0x26B9920 VA: 0x1826BA720
	public static bool op_Equality(StyleCursor lhs, StyleCursor rhs) { }

	// RVA: 0x26BA790 Offset: 0x26B9990 VA: 0x1826BA790
	public static StyleCursor op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x26BA4D0 Offset: 0x26B96D0 VA: 0x1826BA4D0 Slot: 6
	public bool Equals(StyleCursor other) { }

	// RVA: 0x26BA540 Offset: 0x26B9740 VA: 0x1826BA540 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26BA610 Offset: 0x26B9810 VA: 0x1826BA610 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26BA630 Offset: 0x26B9830 VA: 0x1826BA630 Slot: 3
	public override string ToString() { }
}

// Namespace: 
private class StyleDataRef.RefCounted<T> // TypeDefIndex: 11445
{
	// Fields
	private static uint m_NextId; // 0x0
	private int m_RefCount; // 0x0
	private readonly uint m_Id; // 0x0
	public T value; // 0x0

	// Properties
	public int refCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_refCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	|-StyleDataRef.RefCounted<InheritedData>.get_refCount
	|-StyleDataRef.RefCounted<LayoutData>.get_refCount
	|-StyleDataRef.RefCounted<RareData>.get_refCount
	|-StyleDataRef.RefCounted<TransformData>.get_refCount
	|-StyleDataRef.RefCounted<TransitionData>.get_refCount
	|-StyleDataRef.RefCounted<VisualData>.get_refCount
	|
	|-RVA: 0xB25410 Offset: 0xB24610 VA: 0x180B25410
	|-StyleDataRef.RefCounted<__Il2CppFullySharedGenericStructType>.get_refCount
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE3BA0 Offset: 0xBE2DA0 VA: 0x180BE3BA0
	|-StyleDataRef.RefCounted<InheritedData>..ctor
	|-StyleDataRef.RefCounted<LayoutData>..ctor
	|-StyleDataRef.RefCounted<RareData>..ctor
	|-StyleDataRef.RefCounted<TransformData>..ctor
	|-StyleDataRef.RefCounted<TransitionData>..ctor
	|-StyleDataRef.RefCounted<VisualData>..ctor
	|
	|-RVA: 0xBE3A70 Offset: 0xBE2C70 VA: 0x180BE3A70
	|-StyleDataRef.RefCounted<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Acquire() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE2F60 Offset: 0xBE2160 VA: 0x180BE2F60
	|-StyleDataRef.RefCounted<InheritedData>.Acquire
	|-StyleDataRef.RefCounted<LayoutData>.Acquire
	|-StyleDataRef.RefCounted<RareData>.Acquire
	|-StyleDataRef.RefCounted<TransformData>.Acquire
	|-StyleDataRef.RefCounted<TransitionData>.Acquire
	|-StyleDataRef.RefCounted<VisualData>.Acquire
	|
	|-RVA: 0xBE2F70 Offset: 0xBE2170 VA: 0x180BE2F70
	|-StyleDataRef.RefCounted<__Il2CppFullySharedGenericStructType>.Acquire
	*/

	// RVA: -1 Offset: -1
	public void Release() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE3A00 Offset: 0xBE2C00 VA: 0x180BE3A00
	|-StyleDataRef.RefCounted<InheritedData>.Release
	|-StyleDataRef.RefCounted<LayoutData>.Release
	|-StyleDataRef.RefCounted<RareData>.Release
	|-StyleDataRef.RefCounted<TransformData>.Release
	|-StyleDataRef.RefCounted<TransitionData>.Release
	|-StyleDataRef.RefCounted<VisualData>.Release
	|
	|-RVA: 0xBE3980 Offset: 0xBE2B80 VA: 0x180BE3980
	|-StyleDataRef.RefCounted<__Il2CppFullySharedGenericStructType>.Release
	*/

	// RVA: -1 Offset: -1
	public StyleDataRef.RefCounted<T> Copy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE3290 Offset: 0xBE2490 VA: 0x180BE3290
	|-StyleDataRef.RefCounted<InheritedData>.Copy
	|
	|-RVA: 0xBE3430 Offset: 0xBE2630 VA: 0x180BE3430
	|-StyleDataRef.RefCounted<LayoutData>.Copy
	|-StyleDataRef.RefCounted<VisualData>.Copy
	|
	|-RVA: 0xBE3130 Offset: 0xBE2330 VA: 0x180BE3130
	|-StyleDataRef.RefCounted<RareData>.Copy
	|
	|-RVA: 0xBE3670 Offset: 0xBE2870 VA: 0x180BE3670
	|-StyleDataRef.RefCounted<TransformData>.Copy
	|
	|-RVA: 0xBE2FF0 Offset: 0xBE21F0 VA: 0x180BE2FF0
	|-StyleDataRef.RefCounted<TransitionData>.Copy
	|
	|-RVA: 0xBE37D0 Offset: 0xBE29D0 VA: 0x180BE37D0
	|-StyleDataRef.RefCounted<__Il2CppFullySharedGenericStructType>.Copy
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE3A10 Offset: 0xBE2C10 VA: 0x180BE3A10
	|-StyleDataRef.RefCounted<InheritedData>..cctor
	|-StyleDataRef.RefCounted<LayoutData>..cctor
	|-StyleDataRef.RefCounted<RareData>..cctor
	|-StyleDataRef.RefCounted<TransformData>..cctor
	|-StyleDataRef.RefCounted<TransitionData>..cctor
	|-StyleDataRef.RefCounted<VisualData>..cctor
	|-StyleDataRef.RefCounted<__Il2CppFullySharedGenericStructType>..cctor
	*/
}

// Namespace: UnityEngine.UIElements
internal struct StyleDataRef<T> : IEquatable<StyleDataRef<T>> // TypeDefIndex: 11446
{
	// Fields
	private StyleDataRef.RefCounted<T> m_Ref; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public StyleDataRef<T> Acquire() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC40AC0 Offset: 0xC3FCC0 VA: 0x180C40AC0
	|-StyleDataRef<InheritedData>.Acquire
	|-StyleDataRef<LayoutData>.Acquire
	|-StyleDataRef<RareData>.Acquire
	|-StyleDataRef<TransformData>.Acquire
	|-StyleDataRef<TransitionData>.Acquire
	|-StyleDataRef<VisualData>.Acquire
	|
	|-RVA: 0xC43B30 Offset: 0xC42D30 VA: 0x180C43B30
	|-StyleDataRef<__Il2CppFullySharedGenericStructType>.Acquire
	*/

	// RVA: -1 Offset: -1
	public void Release() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC41F10 Offset: 0xC41110 VA: 0x180C41F10
	|-StyleDataRef<InheritedData>.Release
	|-StyleDataRef<LayoutData>.Release
	|-StyleDataRef<RareData>.Release
	|-StyleDataRef<TransformData>.Release
	|-StyleDataRef<TransitionData>.Release
	|-StyleDataRef<VisualData>.Release
	|
	|-RVA: 0xC44260 Offset: 0xC43460 VA: 0x180C44260
	|-StyleDataRef<__Il2CppFullySharedGenericStructType>.Release
	*/

	// RVA: -1 Offset: -1
	public void CopyFrom(StyleDataRef<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC40E50 Offset: 0xC40050 VA: 0x180C40E50
	|-StyleDataRef<InheritedData>.CopyFrom
	|
	|-RVA: 0xC40B20 Offset: 0xC3FD20 VA: 0x180C40B20
	|-StyleDataRef<LayoutData>.CopyFrom
	|-StyleDataRef<VisualData>.CopyFrom
	|
	|-RVA: 0xC40C30 Offset: 0xC3FE30 VA: 0x180C40C30
	|-StyleDataRef<RareData>.CopyFrom
	|
	|-RVA: 0xC40D40 Offset: 0xC3FF40 VA: 0x180C40D40
	|-StyleDataRef<TransformData>.CopyFrom
	|
	|-RVA: 0xC40F60 Offset: 0xC40160 VA: 0x180C40F60
	|-StyleDataRef<TransitionData>.CopyFrom
	|
	|-RVA: 0xC43BC0 Offset: 0xC42DC0 VA: 0x180C43BC0
	|-StyleDataRef<__Il2CppFullySharedGenericStructType>.CopyFrom
	*/

	// RVA: -1 Offset: -1
	public ref T Read() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC41EE0 Offset: 0xC410E0 VA: 0x180C41EE0
	|-StyleDataRef<InheritedData>.Read
	|-StyleDataRef<LayoutData>.Read
	|-StyleDataRef<RareData>.Read
	|-StyleDataRef<TransformData>.Read
	|-StyleDataRef<TransitionData>.Read
	|-StyleDataRef<VisualData>.Read
	|
	|-RVA: 0xC44210 Offset: 0xC43410 VA: 0x180C44210
	|-StyleDataRef<__Il2CppFullySharedGenericStructType>.Read
	*/

	// RVA: -1 Offset: -1
	public ref T Write() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC42030 Offset: 0xC41230 VA: 0x180C42030
	|-StyleDataRef<InheritedData>.Write
	|
	|-RVA: 0xC42270 Offset: 0xC41470 VA: 0x180C42270
	|-StyleDataRef<LayoutData>.Write
	|-StyleDataRef<VisualData>.Write
	|
	|-RVA: 0xC41F70 Offset: 0xC41170 VA: 0x180C41F70
	|-StyleDataRef<RareData>.Write
	|
	|-RVA: 0xC421B0 Offset: 0xC413B0 VA: 0x180C421B0
	|-StyleDataRef<TransformData>.Write
	|
	|-RVA: 0xC420F0 Offset: 0xC412F0 VA: 0x180C420F0
	|-StyleDataRef<TransitionData>.Write
	|
	|-RVA: 0xC442F0 Offset: 0xC434F0 VA: 0x180C442F0
	|-StyleDataRef<__Il2CppFullySharedGenericStructType>.Write
	*/

	// RVA: -1 Offset: -1
	public static StyleDataRef<T> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC41070 Offset: 0xC40270 VA: 0x180C41070
	|-StyleDataRef<InheritedData>.Create
	|-StyleDataRef<LayoutData>.Create
	|-StyleDataRef<RareData>.Create
	|-StyleDataRef<TransformData>.Create
	|-StyleDataRef<TransitionData>.Create
	|-StyleDataRef<VisualData>.Create
	|
	|-RVA: 0xC43E50 Offset: 0xC43050 VA: 0x180C43E50
	|-StyleDataRef<__Il2CppFullySharedGenericStructType>.Create
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC41E90 Offset: 0xC41090 VA: 0x180C41E90
	|-StyleDataRef<InheritedData>.GetHashCode
	|
	|-RVA: 0xC41DA0 Offset: 0xC40FA0 VA: 0x180C41DA0
	|-StyleDataRef<LayoutData>.GetHashCode
	|
	|-RVA: 0xC41D50 Offset: 0xC40F50 VA: 0x180C41D50
	|-StyleDataRef<RareData>.GetHashCode
	|
	|-RVA: 0xC41E40 Offset: 0xC41040 VA: 0x180C41E40
	|-StyleDataRef<TransformData>.GetHashCode
	|
	|-RVA: 0xC41DF0 Offset: 0xC40FF0 VA: 0x180C41DF0
	|-StyleDataRef<TransitionData>.GetHashCode
	|
	|-RVA: 0xC41D00 Offset: 0xC40F00 VA: 0x180C41D00
	|-StyleDataRef<VisualData>.GetHashCode
	|
	|-RVA: 0xC440B0 Offset: 0xC432B0 VA: 0x180C440B0
	|-StyleDataRef<__Il2CppFullySharedGenericStructType>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(StyleDataRef<T> lhs, StyleDataRef<T> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC424D0 Offset: 0xC416D0 VA: 0x180C424D0
	|-StyleDataRef<InheritedData>.op_Equality
	|
	|-RVA: 0xC42690 Offset: 0xC41890 VA: 0x180C42690
	|-StyleDataRef<LayoutData>.op_Equality
	|
	|-RVA: 0xC423A0 Offset: 0xC415A0 VA: 0x180C423A0
	|-StyleDataRef<RareData>.op_Equality
	|
	|-RVA: 0xC42430 Offset: 0xC41630 VA: 0x180C42430
	|-StyleDataRef<TransformData>.op_Equality
	|
	|-RVA: 0xC42330 Offset: 0xC41530 VA: 0x180C42330
	|-StyleDataRef<TransitionData>.op_Equality
	|
	|-RVA: 0xC425A0 Offset: 0xC417A0 VA: 0x180C425A0
	|-StyleDataRef<VisualData>.op_Equality
	|
	|-RVA: 0xC44490 Offset: 0xC43690 VA: 0x180C44490
	|-StyleDataRef<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(StyleDataRef<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC41AE0 Offset: 0xC40CE0 VA: 0x180C41AE0
	|-StyleDataRef<InheritedData>.Equals
	|
	|-RVA: 0xC41790 Offset: 0xC40990 VA: 0x180C41790
	|-StyleDataRef<LayoutData>.Equals
	|
	|-RVA: 0xC41300 Offset: 0xC40500 VA: 0x180C41300
	|-StyleDataRef<RareData>.Equals
	|
	|-RVA: 0xC410F0 Offset: 0xC402F0 VA: 0x180C410F0
	|-StyleDataRef<TransformData>.Equals
	|
	|-RVA: 0xC413C0 Offset: 0xC405C0 VA: 0x180C413C0
	|-StyleDataRef<TransitionData>.Equals
	|
	|-RVA: 0xC411D0 Offset: 0xC403D0 VA: 0x180C411D0
	|-StyleDataRef<VisualData>.Equals
	|
	|-RVA: 0xC43F00 Offset: 0xC43100 VA: 0x180C43F00
	|-StyleDataRef<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC419D0 Offset: 0xC40BD0 VA: 0x180C419D0
	|-StyleDataRef<InheritedData>.Equals
	|
	|-RVA: 0xC41BF0 Offset: 0xC40DF0 VA: 0x180C41BF0
	|-StyleDataRef<LayoutData>.Equals
	|
	|-RVA: 0xC41460 Offset: 0xC40660 VA: 0x180C41460
	|-StyleDataRef<RareData>.Equals
	|
	|-RVA: 0xC41570 Offset: 0xC40770 VA: 0x180C41570
	|-StyleDataRef<TransformData>.Equals
	|
	|-RVA: 0xC418C0 Offset: 0xC40AC0 VA: 0x180C418C0
	|-StyleDataRef<TransitionData>.Equals
	|
	|-RVA: 0xC41680 Offset: 0xC40880 VA: 0x180C41680
	|-StyleDataRef<VisualData>.Equals
	|
	|-RVA: 0xC43F80 Offset: 0xC43180 VA: 0x180C43F80
	|-StyleDataRef<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	public bool ReferenceEquals(StyleDataRef<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC41F00 Offset: 0xC41100 VA: 0x180C41F00
	|-StyleDataRef<InheritedData>.ReferenceEquals
	|-StyleDataRef<LayoutData>.ReferenceEquals
	|-StyleDataRef<RareData>.ReferenceEquals
	|-StyleDataRef<TransformData>.ReferenceEquals
	|-StyleDataRef<TransitionData>.ReferenceEquals
	|-StyleDataRef<VisualData>.ReferenceEquals
	|-StyleDataRef<__Il2CppFullySharedGenericStructType>.ReferenceEquals
	*/
}

// Namespace: UnityEngine.UIElements
public struct StyleEnum<T> : IStyleValue<T>, IEquatable<StyleEnum<T>> // TypeDefIndex: 11447
{
	// Fields
	private T m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x0

	// Properties
	public T value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public T get_value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC45460 Offset: 0xC44660 VA: 0x180C45460
	|-StyleEnum<Int32Enum>.get_value
	|
	|-RVA: 0xC45290 Offset: 0xC44490 VA: 0x180C45290
	|-StyleEnum<__Il2CppFullySharedGenericStructType>.get_value
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public StyleKeyword get_keyword() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC45280 Offset: 0xC44480 VA: 0x180C45280
	|-StyleEnum<Int32Enum>.get_keyword
	|
	|-RVA: 0xC45230 Offset: 0xC44430 VA: 0x180C45230
	|-StyleEnum<__Il2CppFullySharedGenericStructType>.get_keyword
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC450C0 Offset: 0xC442C0 VA: 0x180C450C0
	|-StyleEnum<Int32Enum>..ctor
	|
	|-RVA: 0xC44E40 Offset: 0xC44040 VA: 0x180C44E40
	|-StyleEnum<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(StyleKeyword keyword) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC45080 Offset: 0xC44280 VA: 0x180C45080
	|-StyleEnum<Int32Enum>..ctor
	|
	|-RVA: 0xC44F40 Offset: 0xC44140 VA: 0x180C44F40
	|-StyleEnum<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(T v, StyleKeyword keyword) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC45220 Offset: 0xC44420 VA: 0x180C45220
	|-StyleEnum<Int32Enum>..ctor
	|
	|-RVA: 0xC45100 Offset: 0xC44300 VA: 0x180C45100
	|-StyleEnum<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(StyleEnum<T> lhs, StyleEnum<T> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC45720 Offset: 0xC44920 VA: 0x180C45720
	|-StyleEnum<Int32Enum>.op_Equality
	|
	|-RVA: 0xC45470 Offset: 0xC44670 VA: 0x180C45470
	|-StyleEnum<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(StyleEnum<T> lhs, StyleEnum<T> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC45AF0 Offset: 0xC44CF0 VA: 0x180C45AF0
	|-StyleEnum<Int32Enum>.op_Inequality
	|
	|-RVA: 0xC45B70 Offset: 0xC44D70 VA: 0x180C45B70
	|-StyleEnum<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1
	public static StyleEnum<T> op_Implicit(StyleKeyword keyword) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC45770 Offset: 0xC44970 VA: 0x180C45770
	|-StyleEnum<Int32Enum>.op_Implicit
	|
	|-RVA: 0xC45970 Offset: 0xC44B70 VA: 0x180C45970
	|-StyleEnum<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static StyleEnum<T> op_Implicit(T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC45A90 Offset: 0xC44C90 VA: 0x180C45A90
	|-StyleEnum<Int32Enum>.op_Implicit
	|
	|-RVA: 0xC457D0 Offset: 0xC449D0 VA: 0x180C457D0
	|-StyleEnum<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool Equals(StyleEnum<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC447B0 Offset: 0xC439B0 VA: 0x180C447B0
	|-StyleEnum<Int32Enum>.Equals
	|
	|-RVA: 0xC44680 Offset: 0xC43880 VA: 0x180C44680
	|-StyleEnum<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC44830 Offset: 0xC43A30 VA: 0x180C44830
	|-StyleEnum<Int32Enum>.Equals
	|
	|-RVA: 0xC44940 Offset: 0xC43B40 VA: 0x180C44940
	|-StyleEnum<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC44C70 Offset: 0xC43E70 VA: 0x180C44C70
	|-StyleEnum<Int32Enum>.GetHashCode
	|
	|-RVA: 0xC44B20 Offset: 0xC43D20 VA: 0x180C44B20
	|-StyleEnum<__Il2CppFullySharedGenericStructType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC44DC0 Offset: 0xC43FC0 VA: 0x180C44DC0
	|-StyleEnum<Int32Enum>.ToString
	|
	|-RVA: 0xC44CC0 Offset: 0xC43EC0 VA: 0x180C44CC0
	|-StyleEnum<__Il2CppFullySharedGenericStructType>.ToString
	*/
}

// Namespace: UnityEngine.UIElements
public struct StyleFloat : IStyleValue<float>, IEquatable<StyleFloat> // TypeDefIndex: 11448
{
	// Fields
	private float m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x4

	// Properties
	public float value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x26BA930 Offset: 0x26B9B30 VA: 0x1826BA930 Slot: 4
	public float get_value() { }

	// RVA: 0xC45280 Offset: 0xC44480 VA: 0x180C45280 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x26BA910 Offset: 0x26B9B10 VA: 0x1826BA910
	public void .ctor(float v) { }

	// RVA: 0x26BA920 Offset: 0x26B9B20 VA: 0x1826BA920
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0xFB9280 Offset: 0xFB8480 VA: 0x180FB9280
	internal void .ctor(float v, StyleKeyword keyword) { }

	// RVA: 0x26BA940 Offset: 0x26B9B40 VA: 0x1826BA940
	public static bool op_Equality(StyleFloat lhs, StyleFloat rhs) { }

	// RVA: 0x26BA970 Offset: 0x26B9B70 VA: 0x1826BA970
	public static StyleFloat op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x268C6A0 Offset: 0x268B8A0 VA: 0x18268C6A0
	public static StyleFloat op_Implicit(float v) { }

	// RVA: 0x26BA880 Offset: 0x26B9A80 VA: 0x1826BA880 Slot: 6
	public bool Equals(StyleFloat other) { }

	// RVA: 0x26BA7D0 Offset: 0x26B99D0 VA: 0x1826BA7D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x268C470 Offset: 0x268B670 VA: 0x18268C470 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26BA8B0 Offset: 0x26B9AB0 VA: 0x1826BA8B0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.UIElements
public struct StyleFont : IStyleValue<Font>, IEquatable<StyleFont> // TypeDefIndex: 11449
{
	// Fields
	private Font m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x8

	// Properties
	public Font value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x26BADE0 Offset: 0x26B9FE0 VA: 0x1826BADE0 Slot: 4
	public Font get_value() { }

	// RVA: 0xBC6000 Offset: 0xBC5200 VA: 0x180BC6000 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x26BADD0 Offset: 0x26B9FD0 VA: 0x1826BADD0
	public void .ctor(Font v) { }

	// RVA: 0x26BADC0 Offset: 0x26B9FC0 VA: 0x1826BADC0
	internal void .ctor(Font v, StyleKeyword keyword) { }

	// RVA: 0x26BADF0 Offset: 0x26B9FF0 VA: 0x1826BADF0
	public static bool op_Equality(StyleFont lhs, StyleFont rhs) { }

	// RVA: 0x26BAE60 Offset: 0x26BA060 VA: 0x1826BAE60
	public static StyleFont op_Implicit(Font v) { }

	// RVA: 0x26BAC50 Offset: 0x26B9E50 VA: 0x1826BAC50 Slot: 6
	public bool Equals(StyleFont other) { }

	// RVA: 0x26BAB40 Offset: 0x26B9D40 VA: 0x1826BAB40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26BACD0 Offset: 0x26B9ED0 VA: 0x1826BACD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26BAD60 Offset: 0x26B9F60 VA: 0x1826BAD60 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.UIElements
public struct StyleFontDefinition : IStyleValue<FontDefinition>, IEquatable<StyleFontDefinition> // TypeDefIndex: 11450
{
	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private FontDefinition m_Value; // 0x8

	// Properties
	public FontDefinition value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x26BAAF0 Offset: 0x26B9CF0 VA: 0x1826BAAF0 Slot: 4
	public FontDefinition get_value() { }

	// RVA: 0x244E020 Offset: 0x244D220 VA: 0x18244E020 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x26BAAE0 Offset: 0x26B9CE0 VA: 0x1826BAAE0
	public void .ctor(FontDefinition f) { }

	// RVA: 0x26BAAD0 Offset: 0x26B9CD0 VA: 0x1826BAAD0
	internal void .ctor(FontDefinition f, StyleKeyword keyword) { }

	// RVA: 0x26BAB10 Offset: 0x26B9D10 VA: 0x1826BAB10
	public static StyleFontDefinition op_Implicit(FontDefinition f) { }

	// RVA: 0x26BAA50 Offset: 0x26B9C50 VA: 0x1826BAA50 Slot: 6
	public bool Equals(StyleFontDefinition other) { }

	// RVA: 0x26BA990 Offset: 0x26B9B90 VA: 0x1826BA990 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26BAAA0 Offset: 0x26B9CA0 VA: 0x1826BAAA0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.UIElements
public struct StyleInt : IStyleValue<int>, IEquatable<StyleInt> // TypeDefIndex: 11451
{
	// Fields
	private int m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x4

	// Properties
	public int value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0xC45460 Offset: 0xC44660 VA: 0x180C45460 Slot: 4
	public int get_value() { }

	// RVA: 0xC45280 Offset: 0xC44480 VA: 0x180C45280 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x26BA920 Offset: 0x26B9B20 VA: 0x1826BA920
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0xC45220 Offset: 0xC44420 VA: 0x180C45220
	internal void .ctor(int v, StyleKeyword keyword) { }

	// RVA: 0x26BAFC0 Offset: 0x26BA1C0 VA: 0x1826BAFC0
	public static bool op_Equality(StyleInt lhs, StyleInt rhs) { }

	// RVA: 0x26BA970 Offset: 0x26B9B70 VA: 0x1826BA970
	public static StyleInt op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x26BAF20 Offset: 0x26BA120 VA: 0x1826BAF20 Slot: 6
	public bool Equals(StyleInt other) { }

	// RVA: 0x26BAE80 Offset: 0x26BA080 VA: 0x1826BAE80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26BAF50 Offset: 0x26BA150 VA: 0x1826BAF50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26BAF60 Offset: 0x26BA160 VA: 0x1826BAF60 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.UIElements
public struct StyleLength : IStyleValue<Length>, IEquatable<StyleLength> // TypeDefIndex: 11452
{
	// Fields
	private Length m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x8

	// Properties
	public Length value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x26BB2A0 Offset: 0x26BA4A0 VA: 0x1826BB2A0 Slot: 4
	public Length get_value() { }

	// RVA: 0xBC6000 Offset: 0xBC5200 VA: 0x180BC6000 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x26BB1E0 Offset: 0x26BA3E0 VA: 0x1826BB1E0
	public void .ctor(float v) { }

	// RVA: 0x26BB270 Offset: 0x26BA470 VA: 0x1826BB270
	public void .ctor(Length v) { }

	// RVA: 0x165B2E0 Offset: 0x165A4E0 VA: 0x18165B2E0
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x26BB240 Offset: 0x26BA440 VA: 0x1826BB240
	internal void .ctor(Length v, StyleKeyword keyword) { }

	// RVA: 0x26BB2C0 Offset: 0x26BA4C0 VA: 0x1826BB2C0
	public static bool op_Equality(StyleLength lhs, StyleLength rhs) { }

	// RVA: 0x26BB340 Offset: 0x26BA540 VA: 0x1826BB340
	public static StyleLength op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x26BB360 Offset: 0x26BA560 VA: 0x1826BB360
	public static StyleLength op_Implicit(float v) { }

	// RVA: 0x26BB300 Offset: 0x26BA500 VA: 0x1826BB300
	public static StyleLength op_Implicit(Length v) { }

	// RVA: 0x26BAFE0 Offset: 0x26BA1E0 VA: 0x1826BAFE0 Slot: 6
	public bool Equals(StyleLength other) { }

	// RVA: 0x26BB050 Offset: 0x26BA250 VA: 0x1826BB050 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26BB140 Offset: 0x26BA340 VA: 0x1826BB140 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26BB170 Offset: 0x26BA370 VA: 0x1826BB170 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.UIElements
public struct StyleRotate : IStyleValue<Rotate>, IEquatable<StyleRotate> // TypeDefIndex: 11453
{
	// Fields
	private Rotate m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x18

	// Properties
	public Rotate value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x26BCDD0 Offset: 0x26BBFD0 VA: 0x1826BCDD0 Slot: 4
	public Rotate get_value() { }

	// RVA: 0xB78A40 Offset: 0xB77C40 VA: 0x180B78A40 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x26BA6A0 Offset: 0x26B98A0 VA: 0x1826BA6A0
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x13144A0 Offset: 0x13136A0 VA: 0x1813144A0
	internal void .ctor(Rotate v, StyleKeyword keyword) { }

	// RVA: 0x26BCF00 Offset: 0x26BC100 VA: 0x1826BCF00
	public static bool op_Equality(StyleRotate lhs, StyleRotate rhs) { }

	// RVA: 0x26BCF90 Offset: 0x26BC190 VA: 0x1826BCF90
	public static StyleRotate op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x26BCCA0 Offset: 0x26BBEA0 VA: 0x1826BCCA0 Slot: 6
	public bool Equals(StyleRotate other) { }

	// RVA: 0x26BCBA0 Offset: 0x26BBDA0 VA: 0x1826BCBA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26BCD30 Offset: 0x26BBF30 VA: 0x1826BCD30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26BCD50 Offset: 0x26BBF50 VA: 0x1826BCD50 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.UIElements
public struct StyleScale : IStyleValue<Scale>, IEquatable<StyleScale> // TypeDefIndex: 11454
{
	// Fields
	private Scale m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x10

	// Properties
	public Scale value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x26BD1F0 Offset: 0x26BC3F0 VA: 0x1826BD1F0 Slot: 4
	public Scale get_value() { }

	// RVA: 0x24765D0 Offset: 0x24757D0 VA: 0x1824765D0 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x26BD1E0 Offset: 0x26BC3E0 VA: 0x1826BD1E0
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x13144C0 Offset: 0x13136C0 VA: 0x1813144C0
	internal void .ctor(Scale v, StyleKeyword keyword) { }

	// RVA: 0x26BD2B0 Offset: 0x26BC4B0 VA: 0x1826BD2B0
	public static bool op_Equality(StyleScale lhs, StyleScale rhs) { }

	// RVA: 0x26BD320 Offset: 0x26BC520 VA: 0x1826BD320
	public static StyleScale op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x26BCFC0 Offset: 0x26BC1C0 VA: 0x1826BCFC0 Slot: 6
	public bool Equals(StyleScale other) { }

	// RVA: 0x26BD030 Offset: 0x26BC230 VA: 0x1826BD030 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26BD110 Offset: 0x26BC310 VA: 0x1826BD110 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26BD170 Offset: 0x26BC370 VA: 0x1826BD170 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.UIElements
public struct StyleTranslate : IStyleValue<Translate>, IEquatable<StyleTranslate> // TypeDefIndex: 11455
{
	// Fields
	private Translate m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x18

	// Properties
	public Translate value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x26BF670 Offset: 0x26BE870 VA: 0x1826BF670 Slot: 4
	public Translate get_value() { }

	// RVA: 0xB78A40 Offset: 0xB77C40 VA: 0x180B78A40 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x26BF650 Offset: 0x26BE850 VA: 0x1826BF650
	public void .ctor(Translate v) { }

	// RVA: 0x26BA6A0 Offset: 0x26B98A0 VA: 0x1826BA6A0
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x13144A0 Offset: 0x13136A0 VA: 0x1813144A0
	internal void .ctor(Translate v, StyleKeyword keyword) { }

	// RVA: 0x26BF720 Offset: 0x26BE920 VA: 0x1826BF720
	public static bool op_Equality(StyleTranslate lhs, StyleTranslate rhs) { }

	// RVA: 0x26BCF90 Offset: 0x26BC190 VA: 0x1826BCF90
	public static StyleTranslate op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x26BF7B0 Offset: 0x26BE9B0 VA: 0x1826BF7B0
	public static StyleTranslate op_Implicit(Translate v) { }

	// RVA: 0x26BF420 Offset: 0x26BE620 VA: 0x1826BF420 Slot: 6
	public bool Equals(StyleTranslate other) { }

	// RVA: 0x26BF4B0 Offset: 0x26BE6B0 VA: 0x1826BF4B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26BF5B0 Offset: 0x26BE7B0 VA: 0x1826BF5B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26BF5D0 Offset: 0x26BE7D0 VA: 0x1826BF5D0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.UIElements
public struct StyleTextShadow : IStyleValue<TextShadow>, IEquatable<StyleTextShadow> // TypeDefIndex: 11456
{
	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private TextShadow m_Value; // 0x4

	// Properties
	public TextShadow value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x26BEEB0 Offset: 0x26BE0B0 VA: 0x1826BEEB0 Slot: 4
	public TextShadow get_value() { }

	// RVA: 0x244E020 Offset: 0x244D220 VA: 0x18244E020 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x26BEE60 Offset: 0x26BE060 VA: 0x1826BEE60
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x26BEE90 Offset: 0x26BE090 VA: 0x1826BEE90
	internal void .ctor(TextShadow v, StyleKeyword keyword) { }

	// RVA: 0x26BEF00 Offset: 0x26BE100 VA: 0x1826BEF00
	public static bool op_Equality(StyleTextShadow lhs, StyleTextShadow rhs) { }

	// RVA: 0x26BEFB0 Offset: 0x26BE1B0 VA: 0x1826BEFB0
	public static StyleTextShadow op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x26BED00 Offset: 0x26BDF00 VA: 0x1826BED00 Slot: 6
	public bool Equals(StyleTextShadow other) { }

	// RVA: 0x26BEBD0 Offset: 0x26BDDD0 VA: 0x1826BEBD0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26BEDB0 Offset: 0x26BDFB0 VA: 0x1826BEDB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26BEDF0 Offset: 0x26BDFF0 VA: 0x1826BEDF0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.UIElements
public struct StyleTransformOrigin : IStyleValue<TransformOrigin>, IEquatable<StyleTransformOrigin> // TypeDefIndex: 11457
{
	// Fields
	private TransformOrigin m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x14

	// Properties
	public TransformOrigin value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x26BF210 Offset: 0x26BE410 VA: 0x1826BF210 Slot: 4
	public TransformOrigin get_value() { }

	// RVA: 0x10EBDC0 Offset: 0x10EAFC0 VA: 0x1810EBDC0 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x26B9200 Offset: 0x26B8400 VA: 0x1826B9200
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x26B91E0 Offset: 0x26B83E0 VA: 0x1826B91E0
	internal void .ctor(TransformOrigin v, StyleKeyword keyword) { }

	// RVA: 0x26BF330 Offset: 0x26BE530 VA: 0x1826BF330
	public static bool op_Equality(StyleTransformOrigin lhs, StyleTransformOrigin rhs) { }

	// RVA: 0x26B92E0 Offset: 0x26B84E0 VA: 0x1826B92E0
	public static StyleTransformOrigin op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x26BEFF0 Offset: 0x26BE1F0 VA: 0x1826BEFF0 Slot: 6
	public bool Equals(StyleTransformOrigin other) { }

	// RVA: 0x26BF0E0 Offset: 0x26BE2E0 VA: 0x1826BF0E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26BF180 Offset: 0x26BE380 VA: 0x1826BF180 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26BF1A0 Offset: 0x26BE3A0 VA: 0x1826BF1A0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.UIElements
internal interface IStyleValue<T> // TypeDefIndex: 11458
{
	// Properties
	public abstract T value { get; }
	public abstract StyleKeyword keyword { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T get_value();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IStyleValue<__Il2CppFullySharedGenericType>.get_value
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract StyleKeyword get_keyword();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IStyleValue<__Il2CppFullySharedGenericType>.get_keyword
	*/
}

// Namespace: UnityEngine.UIElements
public enum StyleKeyword // TypeDefIndex: 11459
{
	// Fields
	public int value__; // 0x0
	public const StyleKeyword Undefined = 0;
	public const StyleKeyword Null = 1;
	public const StyleKeyword Auto = 2;
	public const StyleKeyword None = 3;
	public const StyleKeyword Initial = 4;
}

// Namespace: UnityEngine.UIElements
[Extension]
internal static class StyleValueExtensions // TypeDefIndex: 11460
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	internal static string DebugString<T>(IStyleValue<T> styleValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA80AD0 Offset: 0xA7FCD0 VA: 0x180A80AD0
	|-StyleValueExtensions.DebugString<BackgroundSize>
	|-StyleValueExtensions.DebugString<TransformOrigin>
	|
	|-RVA: 0xA80C50 Offset: 0xA7FE50 VA: 0x180A80C50
	|-StyleValueExtensions.DebugString<Color>
	|-StyleValueExtensions.DebugString<Scale>
	|
	|-RVA: 0xA80DC0 Offset: 0xA7FFC0 VA: 0x180A80DC0
	|-StyleValueExtensions.DebugString<Cursor>
	|-StyleValueExtensions.DebugString<Rotate>
	|-StyleValueExtensions.DebugString<Translate>
	|
	|-RVA: 0xA81090 Offset: 0xA80290 VA: 0x180A81090
	|-StyleValueExtensions.DebugString<int>
	|-StyleValueExtensions.DebugString<Int32Enum>
	|
	|-RVA: 0xA81190 Offset: 0xA80390 VA: 0x180A81190
	|-StyleValueExtensions.DebugString<Length>
	|
	|-RVA: 0xA81300 Offset: 0xA80500 VA: 0x180A81300
	|-StyleValueExtensions.DebugString<object>
	|
	|-RVA: 0xA81400 Offset: 0xA80600 VA: 0x180A81400
	|-StyleValueExtensions.DebugString<float>
	|
	|-RVA: 0xA81570 Offset: 0xA80770 VA: 0x180A81570
	|-StyleValueExtensions.DebugString<TextShadow>
	|
	|-RVA: 0xA80F40 Offset: 0xA80140 VA: 0x180A80F40
	|-StyleValueExtensions.DebugString<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x26C0270 Offset: 0x26BF470 VA: 0x1826C0270
	internal static YogaValue ToYogaValue(Length length) { }

	[Extension]
	// RVA: 0x26BFD10 Offset: 0x26BEF10 VA: 0x1826BFD10
	internal static Length ToLength(StyleKeyword keyword) { }

	[Extension]
	// RVA: 0x26BFF10 Offset: 0x26BF110 VA: 0x1826BFF10
	internal static Rotate ToRotate(StyleKeyword keyword) { }

	[Extension]
	// RVA: 0x26C0070 Offset: 0x26BF270 VA: 0x1826C0070
	internal static Scale ToScale(StyleKeyword keyword) { }

	[Extension]
	// RVA: 0x26C0170 Offset: 0x26BF370 VA: 0x1826C0170
	internal static Translate ToTranslate(StyleKeyword keyword) { }

	[Extension]
	// RVA: 0x26BFE00 Offset: 0x26BF000 VA: 0x1826BFE00
	internal static Length ToLength(StyleLength styleLength) { }

	[Extension]
	// RVA: -1 Offset: -1
	internal static void CopyFrom<T>(List<T> list, List<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA808A0 Offset: 0xA7FAA0 VA: 0x180A808A0
	|-StyleValueExtensions.CopyFrom<EasingFunction>
	|
	|-RVA: 0xA809F0 Offset: 0xA7FBF0 VA: 0x180A809F0
	|-StyleValueExtensions.CopyFrom<StylePropertyName>
	|
	|-RVA: 0xA80A70 Offset: 0xA7FC70 VA: 0x180A80A70
	|-StyleValueExtensions.CopyFrom<TimeValue>
	|
	|-RVA: 0xA80900 Offset: 0xA7FB00 VA: 0x180A80900
	|-StyleValueExtensions.CopyFrom<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xA80970 Offset: 0xA7FB70 VA: 0x180A80970
	|-StyleValueExtensions.CopyFrom<MultiColumnCollectionHeader.SortedColumnState>
	*/
}

// Namespace: UnityEngine.UIElements
public enum TimeUnit // TypeDefIndex: 11461
{
	// Fields
	public int value__; // 0x0
	public const TimeUnit Second = 0;
	public const TimeUnit Millisecond = 1;
}

// Namespace: UnityEngine.UIElements
public struct TimeValue : IEquatable<TimeValue> // TypeDefIndex: 11462
{
	// Fields
	private float m_Value; // 0x0
	private TimeUnit m_Unit; // 0x4

	// Properties
	public float value { get; }
	public TimeUnit unit { get; }

	// Methods

	// RVA: 0x439FA0 Offset: 0x4391A0 VA: 0x180439FA0
	public float get_value() { }

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public TimeUnit get_unit() { }

	// RVA: 0x26BA910 Offset: 0x26B9B10 VA: 0x1826BA910
	public void .ctor(float value) { }

	// RVA: 0xFB9280 Offset: 0xFB8480 VA: 0x180FB9280
	public void .ctor(float value, TimeUnit unit) { }

	// RVA: 0x268C6A0 Offset: 0x268B8A0 VA: 0x18268C6A0
	public static TimeValue op_Implicit(float value) { }

	// RVA: 0x268C670 Offset: 0x268B870 VA: 0x18268C670
	public static bool op_Equality(TimeValue lhs, TimeValue rhs) { }

	// RVA: 0x26B7740 Offset: 0x26B6940 VA: 0x1826B7740
	public static bool op_Inequality(TimeValue lhs, TimeValue rhs) { }

	// RVA: 0x268C440 Offset: 0x268B640 VA: 0x18268C440 Slot: 4
	public bool Equals(TimeValue other) { }

	// RVA: 0x26C3FD0 Offset: 0x26C31D0 VA: 0x1826C3FD0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x268C470 Offset: 0x268B670 VA: 0x18268C470 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26C4080 Offset: 0x26C3280 VA: 0x1826C4080 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.UIElements
public struct TransformOrigin : IEquatable<TransformOrigin> // TypeDefIndex: 11463
{
	// Fields
	private Length m_X; // 0x0
	private Length m_Y; // 0x8
	private float m_Z; // 0x10

	// Properties
	public Length x { get; set; }
	public Length y { get; set; }
	public float z { get; }

	// Methods

	// RVA: 0x26C4BE0 Offset: 0x26C3DE0 VA: 0x1826C4BE0
	public void .ctor(Length x, Length y, float z) { }

	// RVA: 0x26C4A30 Offset: 0x26C3C30 VA: 0x1826C4A30
	public static TransformOrigin Initial() { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Length get_x() { }

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_x(Length value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Length get_y() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_y(Length value) { }

	// RVA: 0x482DC0 Offset: 0x481FC0 VA: 0x180482DC0
	public float get_z() { }

	// RVA: 0x26C4BF0 Offset: 0x26C3DF0 VA: 0x1826C4BF0
	public static bool op_Equality(TransformOrigin lhs, TransformOrigin rhs) { }

	// RVA: 0x26C4C90 Offset: 0x26C3E90 VA: 0x1826C4C90
	public static bool op_Inequality(TransformOrigin lhs, TransformOrigin rhs) { }

	// RVA: 0x26C47F0 Offset: 0x26C39F0 VA: 0x1826C47F0 Slot: 4
	public bool Equals(TransformOrigin other) { }

	// RVA: 0x26C4890 Offset: 0x26C3A90 VA: 0x1826C4890 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26C49B0 Offset: 0x26C3BB0 VA: 0x1826C49B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26C4AB0 Offset: 0x26C3CB0 VA: 0x1826C4AB0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.UIElements
public struct Translate : IEquatable<Translate> // TypeDefIndex: 11464
{
	// Fields
	private Length m_X; // 0x0
	private Length m_Y; // 0x8
	private float m_Z; // 0x10
	private bool m_isNone; // 0x14

	// Properties
	public Length x { get; set; }
	public Length y { get; set; }
	public float z { get; }

	// Methods

	// RVA: 0x26C5480 Offset: 0x26C4680 VA: 0x1826C5480
	public void .ctor(Length x, Length y, float z) { }

	// RVA: 0x26C5320 Offset: 0x26C4520 VA: 0x1826C5320
	public static Translate None() { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Length get_x() { }

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_x(Length value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Length get_y() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_y(Length value) { }

	// RVA: 0x482DC0 Offset: 0x481FC0 VA: 0x180482DC0
	public float get_z() { }

	// RVA: 0x26C54A0 Offset: 0x26C46A0 VA: 0x1826C54A0
	public static bool op_Equality(Translate lhs, Translate rhs) { }

	// RVA: 0x26C55B0 Offset: 0x26C47B0 VA: 0x1826C55B0
	public static bool op_Inequality(Translate lhs, Translate rhs) { }

	// RVA: 0x26C5210 Offset: 0x26C4410 VA: 0x1826C5210 Slot: 4
	public bool Equals(Translate other) { }

	// RVA: 0x26C5260 Offset: 0x26C4460 VA: 0x1826C5260 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26C49B0 Offset: 0x26C3BB0 VA: 0x1826C49B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26C5350 Offset: 0x26C4550 VA: 0x1826C5350 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.UIElements
public enum Position // TypeDefIndex: 11465
{
	// Fields
	public int value__; // 0x0
	public const Position Relative = 0;
	public const Position Absolute = 1;
}

// Namespace: UnityEngine.UIElements
public enum Overflow // TypeDefIndex: 11466
{
	// Fields
	public int value__; // 0x0
	public const Overflow Visible = 0;
	public const Overflow Hidden = 1;
}

// Namespace: UnityEngine.UIElements
internal enum OverflowInternal // TypeDefIndex: 11467
{
	// Fields
	public int value__; // 0x0
	public const OverflowInternal Visible = 0;
	public const OverflowInternal Hidden = 1;
	public const OverflowInternal Scroll = 2;
}

// Namespace: UnityEngine.UIElements
public enum OverflowClipBox // TypeDefIndex: 11468
{
	// Fields
	public int value__; // 0x0
	public const OverflowClipBox PaddingBox = 0;
	public const OverflowClipBox ContentBox = 1;
}

// Namespace: UnityEngine.UIElements
public enum FlexDirection // TypeDefIndex: 11469
{
	// Fields
	public int value__; // 0x0
	public const FlexDirection Column = 0;
	public const FlexDirection ColumnReverse = 1;
	public const FlexDirection Row = 2;
	public const FlexDirection RowReverse = 3;
}

// Namespace: UnityEngine.UIElements
public enum Wrap // TypeDefIndex: 11470
{
	// Fields
	public int value__; // 0x0
	public const Wrap NoWrap = 0;
	public const Wrap Wrap = 1;
	public const Wrap WrapReverse = 2;
}

// Namespace: UnityEngine.UIElements
public enum Align // TypeDefIndex: 11471
{
	// Fields
	public int value__; // 0x0
	public const Align Auto = 0;
	public const Align FlexStart = 1;
	public const Align Center = 2;
	public const Align FlexEnd = 3;
	public const Align Stretch = 4;
}

// Namespace: UnityEngine.UIElements
public enum Justify // TypeDefIndex: 11472
{
	// Fields
	public int value__; // 0x0
	public const Justify FlexStart = 0;
	public const Justify Center = 1;
	public const Justify FlexEnd = 2;
	public const Justify SpaceBetween = 3;
	public const Justify SpaceAround = 4;
}

// Namespace: UnityEngine.UIElements
public enum TextOverflowPosition // TypeDefIndex: 11473
{
	// Fields
	public int value__; // 0x0
	public const TextOverflowPosition End = 0;
	public const TextOverflowPosition Start = 1;
	public const TextOverflowPosition Middle = 2;
}

// Namespace: UnityEngine.UIElements
public enum TextOverflow // TypeDefIndex: 11474
{
	// Fields
	public int value__; // 0x0
	public const TextOverflow Clip = 0;
	public const TextOverflow Ellipsis = 1;
}

// Namespace: UnityEngine.UIElements
public enum TransformOriginOffset // TypeDefIndex: 11475
{
	// Fields
	public int value__; // 0x0
	public const TransformOriginOffset Left = 1;
	public const TransformOriginOffset Right = 2;
	public const TransformOriginOffset Top = 3;
	public const TransformOriginOffset Bottom = 4;
	public const TransformOriginOffset Center = 5;
}

// Namespace: UnityEngine.UIElements
public enum Visibility // TypeDefIndex: 11476
{
	// Fields
	public int value__; // 0x0
	public const Visibility Visible = 0;
	public const Visibility Hidden = 1;
}

// Namespace: UnityEngine.UIElements
public enum WhiteSpace // TypeDefIndex: 11477
{
	// Fields
	public int value__; // 0x0
	public const WhiteSpace Normal = 0;
	public const WhiteSpace NoWrap = 1;
}

// Namespace: UnityEngine.UIElements
public enum DisplayStyle // TypeDefIndex: 11478
{
	// Fields
	public int value__; // 0x0
	public const DisplayStyle Flex = 0;
	public const DisplayStyle None = 1;
}

// Namespace: UnityEngine.UIElements
public enum BackgroundPositionKeyword // TypeDefIndex: 11479
{
	// Fields
	public int value__; // 0x0
	public const BackgroundPositionKeyword Center = 0;
	public const BackgroundPositionKeyword Top = 1;
	public const BackgroundPositionKeyword Bottom = 2;
	public const BackgroundPositionKeyword Left = 3;
	public const BackgroundPositionKeyword Right = 4;
}

// Namespace: UnityEngine.UIElements
public enum Repeat // TypeDefIndex: 11480
{
	// Fields
	public int value__; // 0x0
	public const Repeat NoRepeat = 0;
	public const Repeat Space = 1;
	public const Repeat Round = 2;
	public const Repeat Repeat = 3;
}

// Namespace: UnityEngine.UIElements
public enum BackgroundSizeType // TypeDefIndex: 11481
{
	// Fields
	public int value__; // 0x0
	public const BackgroundSizeType Length = 0;
	public const BackgroundSizeType Cover = 1;
	public const BackgroundSizeType Contain = 2;
}

// Namespace: UnityEngine.UIElements
internal interface IStylePainter // TypeDefIndex: 11482
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void DrawText(TextElement te);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void DrawRectangle(MeshGenerationContextUtils.RectangleParams rectParams);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void DrawImmediate(Action callback, bool cullingEnabled);
}

// Namespace: UnityEngine.UIElements
internal interface IStylePropertyAnimations // TypeDefIndex: 11483
{
	// Properties
	public abstract int runningAnimationCount { get; set; }
	public abstract int completedAnimationCount { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Start(StylePropertyId id, float from, float to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool Start(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool Start(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool Start(StylePropertyId id, Color from, Color to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool StartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Start(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool Start(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool Start(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Start(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool Start(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool Start(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool Start(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool Start(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool Start(StylePropertyId id, BackgroundPosition from, BackgroundPosition to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool Start(StylePropertyId id, BackgroundRepeat from, BackgroundRepeat to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool Start(StylePropertyId id, BackgroundSize from, BackgroundSize to, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void UpdateAnimation(StylePropertyId id);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void GetAllAnimations(List<StylePropertyId> outPropertyIds);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void CancelAnimation(StylePropertyId id);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void CancelAllAnimations();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract int get_runningAnimationCount();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void set_runningAnimationCount(int value);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract int get_completedAnimationCount();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void set_completedAnimationCount(int value);
}

// Namespace: UnityEngine.UIElements
internal interface IStylePropertyAnimationSystem // TypeDefIndex: 11484
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, Color startValue, Color endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundPosition startValue, BackgroundPosition endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundRepeat startValue, BackgroundRepeat endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundSize startValue, BackgroundSize endValue, int durationMs, int delayMs, Func<float, float> easingCurve);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void CancelAllAnimations();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void CancelAllAnimations(VisualElement owner);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void CancelAnimation(VisualElement owner, StylePropertyId id);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void UpdateAnimation(VisualElement owner, StylePropertyId id);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void GetAllAnimations(VisualElement owner, List<StylePropertyId> propertyIds);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void Update();
}

// Namespace: 
[Flags]
private enum StylePropertyAnimationSystem.TransitionState // TypeDefIndex: 11485
{
	// Fields
	public int value__; // 0x0
	public const StylePropertyAnimationSystem.TransitionState None = 0;
	public const StylePropertyAnimationSystem.TransitionState Running = 1;
	public const StylePropertyAnimationSystem.TransitionState Started = 2;
	public const StylePropertyAnimationSystem.TransitionState Ended = 4;
	public const StylePropertyAnimationSystem.TransitionState Canceled = 8;
}

// Namespace: 
private struct StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData> // TypeDefIndex: 11486
{
	// Fields
	public VisualElement[] elements; // 0x0
	public StylePropertyId[] properties; // 0x0
	public TTimingData[] timing; // 0x0
	public TStyleData[] style; // 0x0
	public int count; // 0x0
	private Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, int> indices; // 0x0

	// Properties
	private int capacity { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	private int get_capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BF2B0 Offset: 0x11BE4B0 VA: 0x1811BF2B0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Background>, Background>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundPosition>, BackgroundPosition>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundRepeat>, BackgroundRepeat>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundSize>, BackgroundSize>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Color>, Color>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<FontDefinition>, FontDefinition>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<int>, int>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Length>, Length>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<object>, object>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Rotate>, Rotate>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Scale>, Scale>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<float>, float>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<TextShadow>, TextShadow>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<TransformOrigin>, TransformOrigin>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Translate>, Translate>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Background>, StylePropertyAnimationSystem.Values.StyleData<Background>>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundPosition>, StylePropertyAnimationSystem.Values.StyleData<BackgroundPosition>>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundRepeat>, StylePropertyAnimationSystem.Values.StyleData<BackgroundRepeat>>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundSize>, StylePropertyAnimationSystem.Values.StyleData<BackgroundSize>>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Color>, StylePropertyAnimationSystem.Values.StyleData<Color>>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<FontDefinition>, StylePropertyAnimationSystem.Values.StyleData<FontDefinition>>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<int>, StylePropertyAnimationSystem.Values.StyleData<int>>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Length>, StylePropertyAnimationSystem.Values.StyleData<Length>>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<object>, StylePropertyAnimationSystem.Values.StyleData<object>>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Rotate>, StylePropertyAnimationSystem.Values.StyleData<Rotate>>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Scale>, StylePropertyAnimationSystem.Values.StyleData<Scale>>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<float>, StylePropertyAnimationSystem.Values.StyleData<float>>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<TextShadow>, StylePropertyAnimationSystem.Values.StyleData<TextShadow>>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<TransformOrigin>, StylePropertyAnimationSystem.Values.StyleData<TransformOrigin>>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Translate>, StylePropertyAnimationSystem.Values.StyleData<Translate>>.get_capacity
	|-StylePropertyAnimationSystem.AnimationDataSet<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_capacity
	*/

	// RVA: -1 Offset: -1
	private void set_capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BF2D0 Offset: 0x11BE4D0 VA: 0x1811BF2D0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Background>, Background>.set_capacity
	|
	|-RVA: 0x12A5CE0 Offset: 0x12A4EE0 VA: 0x1812A5CE0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundPosition>, BackgroundPosition>.set_capacity
	|
	|-RVA: 0x12A5C10 Offset: 0x12A4E10 VA: 0x1812A5C10
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundRepeat>, BackgroundRepeat>.set_capacity
	|
	|-RVA: 0x12A5540 Offset: 0x12A4740 VA: 0x1812A5540
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundSize>, BackgroundSize>.set_capacity
	|
	|-RVA: 0x12A66A0 Offset: 0x12A58A0 VA: 0x1812A66A0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Color>, Color>.set_capacity
	|
	|-RVA: 0x12A6770 Offset: 0x12A5970 VA: 0x1812A6770
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<FontDefinition>, FontDefinition>.set_capacity
	|
	|-RVA: 0x12A6D20 Offset: 0x12A5F20 VA: 0x1812A6D20
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<int>, int>.set_capacity
	|
	|-RVA: 0x12A61C0 Offset: 0x12A53C0 VA: 0x1812A61C0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Length>, Length>.set_capacity
	|
	|-RVA: 0x12A6360 Offset: 0x12A5560 VA: 0x1812A6360
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<object>, object>.set_capacity
	|
	|-RVA: 0x12A69E0 Offset: 0x12A5BE0 VA: 0x1812A69E0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Rotate>, Rotate>.set_capacity
	|
	|-RVA: 0x12A6C50 Offset: 0x12A5E50 VA: 0x1812A6C50
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Scale>, Scale>.set_capacity
	|
	|-RVA: 0x12A57B0 Offset: 0x12A49B0 VA: 0x1812A57B0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<float>, float>.set_capacity
	|
	|-RVA: 0x12A5DB0 Offset: 0x12A4FB0 VA: 0x1812A5DB0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<TextShadow>, TextShadow>.set_capacity
	|
	|-RVA: 0x12A5F50 Offset: 0x12A5150 VA: 0x1812A5F50
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<TransformOrigin>, TransformOrigin>.set_capacity
	|
	|-RVA: 0x12A5E80 Offset: 0x12A5080 VA: 0x1812A5E80
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Translate>, Translate>.set_capacity
	|
	|-RVA: 0x12A5B40 Offset: 0x12A4D40 VA: 0x1812A5B40
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Background>, StylePropertyAnimationSystem.Values.StyleData<Background>>.set_capacity
	|
	|-RVA: 0x12A6020 Offset: 0x12A5220 VA: 0x1812A6020
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundPosition>, StylePropertyAnimationSystem.Values.StyleData<BackgroundPosition>>.set_capacity
	|
	|-RVA: 0x12A6290 Offset: 0x12A5490 VA: 0x1812A6290
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundRepeat>, StylePropertyAnimationSystem.Values.StyleData<BackgroundRepeat>>.set_capacity
	|
	|-RVA: 0x12A6AB0 Offset: 0x12A5CB0 VA: 0x1812A6AB0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundSize>, StylePropertyAnimationSystem.Values.StyleData<BackgroundSize>>.set_capacity
	|
	|-RVA: 0x12A5950 Offset: 0x12A4B50 VA: 0x1812A5950
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Color>, StylePropertyAnimationSystem.Values.StyleData<Color>>.set_capacity
	|
	|-RVA: 0x12A6B80 Offset: 0x12A5D80 VA: 0x1812A6B80
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<FontDefinition>, StylePropertyAnimationSystem.Values.StyleData<FontDefinition>>.set_capacity
	|
	|-RVA: 0x12A6430 Offset: 0x12A5630 VA: 0x1812A6430
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<int>, StylePropertyAnimationSystem.Values.StyleData<int>>.set_capacity
	|
	|-RVA: 0x12A65D0 Offset: 0x12A57D0 VA: 0x1812A65D0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Length>, StylePropertyAnimationSystem.Values.StyleData<Length>>.set_capacity
	|
	|-RVA: 0x12A56E0 Offset: 0x12A48E0 VA: 0x1812A56E0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<object>, StylePropertyAnimationSystem.Values.StyleData<object>>.set_capacity
	|
	|-RVA: 0x12A6840 Offset: 0x12A5A40 VA: 0x1812A6840
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Rotate>, StylePropertyAnimationSystem.Values.StyleData<Rotate>>.set_capacity
	|
	|-RVA: 0x12A6500 Offset: 0x12A5700 VA: 0x1812A6500
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Scale>, StylePropertyAnimationSystem.Values.StyleData<Scale>>.set_capacity
	|
	|-RVA: 0x12A5610 Offset: 0x12A4810 VA: 0x1812A5610
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<float>, StylePropertyAnimationSystem.Values.StyleData<float>>.set_capacity
	|
	|-RVA: 0x12A60F0 Offset: 0x12A52F0 VA: 0x1812A60F0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<TextShadow>, StylePropertyAnimationSystem.Values.StyleData<TextShadow>>.set_capacity
	|
	|-RVA: 0x12A6910 Offset: 0x12A5B10 VA: 0x1812A6910
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<TransformOrigin>, StylePropertyAnimationSystem.Values.StyleData<TransformOrigin>>.set_capacity
	|
	|-RVA: 0x12A5880 Offset: 0x12A4A80 VA: 0x1812A5880
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Translate>, StylePropertyAnimationSystem.Values.StyleData<Translate>>.set_capacity
	|
	|-RVA: 0x12A5A20 Offset: 0x12A4C20 VA: 0x1812A5A20
	|-StylePropertyAnimationSystem.AnimationDataSet<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_capacity
	*/

	// RVA: -1 Offset: -1
	private void LocalInit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BEC70 Offset: 0x11BDE70 VA: 0x1811BEC70
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Background>, Background>.LocalInit
	|
	|-RVA: 0x129B640 Offset: 0x129A840 VA: 0x18129B640
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundPosition>, BackgroundPosition>.LocalInit
	|
	|-RVA: 0x1299980 Offset: 0x1298B80 VA: 0x181299980
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundRepeat>, BackgroundRepeat>.LocalInit
	|
	|-RVA: 0x1299810 Offset: 0x1298A10 VA: 0x181299810
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundSize>, BackgroundSize>.LocalInit
	|
	|-RVA: 0x129B080 Offset: 0x129A280 VA: 0x18129B080
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Color>, Color>.LocalInit
	|
	|-RVA: 0x129A0B0 Offset: 0x12992B0 VA: 0x18129A0B0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<FontDefinition>, FontDefinition>.LocalInit
	|
	|-RVA: 0x129A950 Offset: 0x1299B50 VA: 0x18129A950
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<int>, int>.LocalInit
	|
	|-RVA: 0x129AAC0 Offset: 0x1299CC0 VA: 0x18129AAC0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Length>, Length>.LocalInit
	|
	|-RVA: 0x1299AF0 Offset: 0x1298CF0 VA: 0x181299AF0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<object>, object>.LocalInit
	|
	|-RVA: 0x129B360 Offset: 0x129A560 VA: 0x18129B360
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Rotate>, Rotate>.LocalInit
	|
	|-RVA: 0x12990E0 Offset: 0x12982E0 VA: 0x1812990E0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Scale>, Scale>.LocalInit
	|
	|-RVA: 0x129A670 Offset: 0x1299870 VA: 0x18129A670
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<float>, float>.LocalInit
	|
	|-RVA: 0x1299DD0 Offset: 0x1298FD0 VA: 0x181299DD0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<TextShadow>, TextShadow>.LocalInit
	|
	|-RVA: 0x129B920 Offset: 0x129AB20 VA: 0x18129B920
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<TransformOrigin>, TransformOrigin>.LocalInit
	|
	|-RVA: 0x1299250 Offset: 0x1298450 VA: 0x181299250
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Translate>, Translate>.LocalInit
	|
	|-RVA: 0x1299C60 Offset: 0x1298E60 VA: 0x181299C60
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Background>, StylePropertyAnimationSystem.Values.StyleData<Background>>.LocalInit
	|
	|-RVA: 0x129B7B0 Offset: 0x129A9B0 VA: 0x18129B7B0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundPosition>, StylePropertyAnimationSystem.Values.StyleData<BackgroundPosition>>.LocalInit
	|
	|-RVA: 0x12996A0 Offset: 0x12988A0 VA: 0x1812996A0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundRepeat>, StylePropertyAnimationSystem.Values.StyleData<BackgroundRepeat>>.LocalInit
	|
	|-RVA: 0x129A390 Offset: 0x1299590 VA: 0x18129A390
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundSize>, StylePropertyAnimationSystem.Values.StyleData<BackgroundSize>>.LocalInit
	|
	|-RVA: 0x129A500 Offset: 0x1299700 VA: 0x18129A500
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Color>, StylePropertyAnimationSystem.Values.StyleData<Color>>.LocalInit
	|
	|-RVA: 0x129B4D0 Offset: 0x129A6D0 VA: 0x18129B4D0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<FontDefinition>, StylePropertyAnimationSystem.Values.StyleData<FontDefinition>>.LocalInit
	|
	|-RVA: 0x129BA90 Offset: 0x129AC90 VA: 0x18129BA90
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<int>, StylePropertyAnimationSystem.Values.StyleData<int>>.LocalInit
	|
	|-RVA: 0x1299F40 Offset: 0x1299140 VA: 0x181299F40
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Length>, StylePropertyAnimationSystem.Values.StyleData<Length>>.LocalInit
	|
	|-RVA: 0x1299530 Offset: 0x1298730 VA: 0x181299530
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<object>, StylePropertyAnimationSystem.Values.StyleData<object>>.LocalInit
	|
	|-RVA: 0x12993C0 Offset: 0x12985C0 VA: 0x1812993C0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Rotate>, StylePropertyAnimationSystem.Values.StyleData<Rotate>>.LocalInit
	|
	|-RVA: 0x129A220 Offset: 0x1299420 VA: 0x18129A220
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Scale>, StylePropertyAnimationSystem.Values.StyleData<Scale>>.LocalInit
	|
	|-RVA: 0x129A7E0 Offset: 0x12999E0 VA: 0x18129A7E0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<float>, StylePropertyAnimationSystem.Values.StyleData<float>>.LocalInit
	|
	|-RVA: 0x129B1F0 Offset: 0x129A3F0 VA: 0x18129B1F0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<TextShadow>, StylePropertyAnimationSystem.Values.StyleData<TextShadow>>.LocalInit
	|
	|-RVA: 0x129ADA0 Offset: 0x1299FA0 VA: 0x18129ADA0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<TransformOrigin>, StylePropertyAnimationSystem.Values.StyleData<TransformOrigin>>.LocalInit
	|
	|-RVA: 0x129AC30 Offset: 0x1299E30 VA: 0x18129AC30
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Translate>, StylePropertyAnimationSystem.Values.StyleData<Translate>>.LocalInit
	|
	|-RVA: 0x129AF10 Offset: 0x129A110 VA: 0x18129AF10
	|-StylePropertyAnimationSystem.AnimationDataSet<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.LocalInit
	*/

	// RVA: -1 Offset: -1
	public static StylePropertyAnimationSystem.AnimationDataSet<TTimingData, TStyleData> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BEA80 Offset: 0x11BDC80 VA: 0x1811BEA80
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Background>, Background>.Create
	|
	|-RVA: 0x1295AC0 Offset: 0x1294CC0 VA: 0x181295AC0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundPosition>, BackgroundPosition>.Create
	|
	|-RVA: 0x1295940 Offset: 0x1294B40 VA: 0x181295940
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundRepeat>, BackgroundRepeat>.Create
	|
	|-RVA: 0x1296140 Offset: 0x1295340 VA: 0x181296140
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundSize>, BackgroundSize>.Create
	|
	|-RVA: 0x1296040 Offset: 0x1295240 VA: 0x181296040
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Color>, Color>.Create
	|
	|-RVA: 0x1295B40 Offset: 0x1294D40 VA: 0x181295B40
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<FontDefinition>, FontDefinition>.Create
	|
	|-RVA: 0x12962C0 Offset: 0x12954C0 VA: 0x1812962C0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<int>, int>.Create
	|
	|-RVA: 0x1295CC0 Offset: 0x1294EC0 VA: 0x181295CC0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Length>, Length>.Create
	|
	|-RVA: 0x1295EC0 Offset: 0x12950C0 VA: 0x181295EC0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<object>, object>.Create
	|
	|-RVA: 0x12961C0 Offset: 0x12953C0 VA: 0x1812961C0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Rotate>, Rotate>.Create
	|
	|-RVA: 0x1295F40 Offset: 0x1295140 VA: 0x181295F40
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Scale>, Scale>.Create
	|
	|-RVA: 0x1296440 Offset: 0x1295640 VA: 0x181296440
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<float>, float>.Create
	|
	|-RVA: 0x1295E40 Offset: 0x1295040 VA: 0x181295E40
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<TextShadow>, TextShadow>.Create
	|
	|-RVA: 0x1295790 Offset: 0x1294990 VA: 0x181295790
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<TransformOrigin>, TransformOrigin>.Create
	|
	|-RVA: 0x12960C0 Offset: 0x12952C0 VA: 0x1812960C0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Translate>, Translate>.Create
	|
	|-RVA: 0x1295A40 Offset: 0x1294C40 VA: 0x181295A40
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Background>, StylePropertyAnimationSystem.Values.StyleData<Background>>.Create
	|
	|-RVA: 0x1295FC0 Offset: 0x12951C0 VA: 0x181295FC0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundPosition>, StylePropertyAnimationSystem.Values.StyleData<BackgroundPosition>>.Create
	|
	|-RVA: 0x1295C40 Offset: 0x1294E40 VA: 0x181295C40
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundRepeat>, StylePropertyAnimationSystem.Values.StyleData<BackgroundRepeat>>.Create
	|
	|-RVA: 0x1295DC0 Offset: 0x1294FC0 VA: 0x181295DC0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundSize>, StylePropertyAnimationSystem.Values.StyleData<BackgroundSize>>.Create
	|
	|-RVA: 0x1296240 Offset: 0x1295440 VA: 0x181296240
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Color>, StylePropertyAnimationSystem.Values.StyleData<Color>>.Create
	|
	|-RVA: 0x12964C0 Offset: 0x12956C0 VA: 0x1812964C0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<FontDefinition>, StylePropertyAnimationSystem.Values.StyleData<FontDefinition>>.Create
	|
	|-RVA: 0x1295710 Offset: 0x1294910 VA: 0x181295710
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<int>, StylePropertyAnimationSystem.Values.StyleData<int>>.Create
	|
	|-RVA: 0x12958C0 Offset: 0x1294AC0 VA: 0x1812958C0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Length>, StylePropertyAnimationSystem.Values.StyleData<Length>>.Create
	|
	|-RVA: 0x1295690 Offset: 0x1294890 VA: 0x181295690
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<object>, StylePropertyAnimationSystem.Values.StyleData<object>>.Create
	|
	|-RVA: 0x1295D40 Offset: 0x1294F40 VA: 0x181295D40
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Rotate>, StylePropertyAnimationSystem.Values.StyleData<Rotate>>.Create
	|
	|-RVA: 0x1296340 Offset: 0x1295540 VA: 0x181296340
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Scale>, StylePropertyAnimationSystem.Values.StyleData<Scale>>.Create
	|
	|-RVA: 0x12963C0 Offset: 0x12955C0 VA: 0x1812963C0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<float>, StylePropertyAnimationSystem.Values.StyleData<float>>.Create
	|
	|-RVA: 0x12959C0 Offset: 0x1294BC0 VA: 0x1812959C0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<TextShadow>, StylePropertyAnimationSystem.Values.StyleData<TextShadow>>.Create
	|
	|-RVA: 0x1296540 Offset: 0x1295740 VA: 0x181296540
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<TransformOrigin>, StylePropertyAnimationSystem.Values.StyleData<TransformOrigin>>.Create
	|
	|-RVA: 0x1295BC0 Offset: 0x1294DC0 VA: 0x181295BC0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Translate>, StylePropertyAnimationSystem.Values.StyleData<Translate>>.Create
	|
	|-RVA: 0x1295810 Offset: 0x1294A10 VA: 0x181295810
	|-StylePropertyAnimationSystem.AnimationDataSet<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Create
	*/

	// RVA: -1 Offset: -1
	public bool IndexOf(VisualElement ve, StylePropertyId prop, out int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BEBD0 Offset: 0x11BDDD0 VA: 0x1811BEBD0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Background>, Background>.IndexOf
	|
	|-RVA: 0x1298820 Offset: 0x1297A20 VA: 0x181298820
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundPosition>, BackgroundPosition>.IndexOf
	|
	|-RVA: 0x1298320 Offset: 0x1297520 VA: 0x181298320
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundRepeat>, BackgroundRepeat>.IndexOf
	|
	|-RVA: 0x1298B40 Offset: 0x1297D40 VA: 0x181298B40
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundSize>, BackgroundSize>.IndexOf
	|
	|-RVA: 0x1298DC0 Offset: 0x1297FC0 VA: 0x181298DC0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Color>, Color>.IndexOf
	|
	|-RVA: 0x1297EC0 Offset: 0x12970C0 VA: 0x181297EC0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<FontDefinition>, FontDefinition>.IndexOf
	|
	|-RVA: 0x1298460 Offset: 0x1297660 VA: 0x181298460
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<int>, int>.IndexOf
	|
	|-RVA: 0x1298BE0 Offset: 0x1297DE0 VA: 0x181298BE0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Length>, Length>.IndexOf
	|
	|-RVA: 0x1298780 Offset: 0x1297980 VA: 0x181298780
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<object>, object>.IndexOf
	|
	|-RVA: 0x1298000 Offset: 0x1297200 VA: 0x181298000
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Rotate>, Rotate>.IndexOf
	|
	|-RVA: 0x1298F00 Offset: 0x1298100 VA: 0x181298F00
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Scale>, Scale>.IndexOf
	|
	|-RVA: 0x12988C0 Offset: 0x1297AC0 VA: 0x1812988C0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<float>, float>.IndexOf
	|
	|-RVA: 0x1298D20 Offset: 0x1297F20 VA: 0x181298D20
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<TextShadow>, TextShadow>.IndexOf
	|
	|-RVA: 0x12985A0 Offset: 0x12977A0 VA: 0x1812985A0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<TransformOrigin>, TransformOrigin>.IndexOf
	|
	|-RVA: 0x1298280 Offset: 0x1297480 VA: 0x181298280
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Translate>, Translate>.IndexOf
	|
	|-RVA: 0x1298FA0 Offset: 0x12981A0 VA: 0x181298FA0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Background>, StylePropertyAnimationSystem.Values.StyleData<Background>>.IndexOf
	|
	|-RVA: 0x1298140 Offset: 0x1297340 VA: 0x181298140
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundPosition>, StylePropertyAnimationSystem.Values.StyleData<BackgroundPosition>>.IndexOf
	|
	|-RVA: 0x12983C0 Offset: 0x12975C0 VA: 0x1812983C0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundRepeat>, StylePropertyAnimationSystem.Values.StyleData<BackgroundRepeat>>.IndexOf
	|
	|-RVA: 0x12980A0 Offset: 0x12972A0 VA: 0x1812980A0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundSize>, StylePropertyAnimationSystem.Values.StyleData<BackgroundSize>>.IndexOf
	|
	|-RVA: 0x1299040 Offset: 0x1298240 VA: 0x181299040
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Color>, StylePropertyAnimationSystem.Values.StyleData<Color>>.IndexOf
	|
	|-RVA: 0x1298500 Offset: 0x1297700 VA: 0x181298500
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<FontDefinition>, StylePropertyAnimationSystem.Values.StyleData<FontDefinition>>.IndexOf
	|
	|-RVA: 0x1298960 Offset: 0x1297B60 VA: 0x181298960
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<int>, StylePropertyAnimationSystem.Values.StyleData<int>>.IndexOf
	|
	|-RVA: 0x1297E20 Offset: 0x1297020 VA: 0x181297E20
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Length>, StylePropertyAnimationSystem.Values.StyleData<Length>>.IndexOf
	|
	|-RVA: 0x1298640 Offset: 0x1297840 VA: 0x181298640
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<object>, StylePropertyAnimationSystem.Values.StyleData<object>>.IndexOf
	|
	|-RVA: 0x1298E60 Offset: 0x1298060 VA: 0x181298E60
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Rotate>, StylePropertyAnimationSystem.Values.StyleData<Rotate>>.IndexOf
	|
	|-RVA: 0x1298AA0 Offset: 0x1297CA0 VA: 0x181298AA0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Scale>, StylePropertyAnimationSystem.Values.StyleData<Scale>>.IndexOf
	|
	|-RVA: 0x1298A00 Offset: 0x1297C00 VA: 0x181298A00
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<float>, StylePropertyAnimationSystem.Values.StyleData<float>>.IndexOf
	|
	|-RVA: 0x12986E0 Offset: 0x12978E0 VA: 0x1812986E0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<TextShadow>, StylePropertyAnimationSystem.Values.StyleData<TextShadow>>.IndexOf
	|
	|-RVA: 0x1297F60 Offset: 0x1297160 VA: 0x181297F60
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<TransformOrigin>, StylePropertyAnimationSystem.Values.StyleData<TransformOrigin>>.IndexOf
	|
	|-RVA: 0x1298C80 Offset: 0x1297E80 VA: 0x181298C80
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Translate>, StylePropertyAnimationSystem.Values.StyleData<Translate>>.IndexOf
	|
	|-RVA: 0x12981E0 Offset: 0x12973E0 VA: 0x1812981E0
	|-StylePropertyAnimationSystem.AnimationDataSet<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public void Add(VisualElement owner, StylePropertyId prop, TTimingData timingData, TStyleData styleData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BE890 Offset: 0x11BDA90 VA: 0x1811BE890
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Background>, Background>.Add
	|
	|-RVA: 0x1294E50 Offset: 0x1294050 VA: 0x181294E50
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundPosition>, BackgroundPosition>.Add
	|
	|-RVA: 0x1292C70 Offset: 0x1291E70 VA: 0x181292C70
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundRepeat>, BackgroundRepeat>.Add
	|
	|-RVA: 0x1293A90 Offset: 0x1292C90 VA: 0x181293A90
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundSize>, BackgroundSize>.Add
	|
	|-RVA: 0x1292840 Offset: 0x1291A40 VA: 0x181292840
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Color>, Color>.Add
	|
	|-RVA: 0x1294250 Offset: 0x1293450 VA: 0x181294250
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<FontDefinition>, FontDefinition>.Add
	|
	|-RVA: 0x1294A60 Offset: 0x1293C60 VA: 0x181294A60
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<int>, int>.Add
	|
	|-RVA: 0x1291C20 Offset: 0x1290E20 VA: 0x181291C20
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Length>, Length>.Add
	|
	|-RVA: 0x1293230 Offset: 0x1292430 VA: 0x181293230
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<object>, object>.Add
	|
	|-RVA: 0x1293E60 Offset: 0x1293060 VA: 0x181293E60
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Rotate>, Rotate>.Add
	|
	|-RVA: 0x1293040 Offset: 0x1292240 VA: 0x181293040
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Scale>, Scale>.Add
	|
	|-RVA: 0x1293C80 Offset: 0x1292E80 VA: 0x181293C80
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<float>, float>.Add
	|
	|-RVA: 0x1294050 Offset: 0x1293250 VA: 0x181294050
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<TextShadow>, TextShadow>.Add
	|
	|-RVA: 0x1292E50 Offset: 0x1292050 VA: 0x181292E50
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<TransformOrigin>, TransformOrigin>.Add
	|
	|-RVA: 0x1292220 Offset: 0x1291420 VA: 0x181292220
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Translate>, Translate>.Add
	|
	|-RVA: 0x1292A30 Offset: 0x1291C30 VA: 0x181292A30
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Background>, StylePropertyAnimationSystem.Values.StyleData<Background>>.Add
	|
	|-RVA: 0x1294440 Offset: 0x1293640 VA: 0x181294440
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundPosition>, StylePropertyAnimationSystem.Values.StyleData<BackgroundPosition>>.Add
	|
	|-RVA: 0x1292630 Offset: 0x1291830 VA: 0x181292630
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundRepeat>, StylePropertyAnimationSystem.Values.StyleData<BackgroundRepeat>>.Add
	|
	|-RVA: 0x12917C0 Offset: 0x12909C0 VA: 0x1812917C0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundSize>, StylePropertyAnimationSystem.Values.StyleData<BackgroundSize>>.Add
	|
	|-RVA: 0x1292000 Offset: 0x1291200 VA: 0x181292000
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Color>, StylePropertyAnimationSystem.Values.StyleData<Color>>.Add
	|
	|-RVA: 0x1292410 Offset: 0x1291610 VA: 0x181292410
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<FontDefinition>, StylePropertyAnimationSystem.Values.StyleData<FontDefinition>>.Add
	|
	|-RVA: 0x1295040 Offset: 0x1294240 VA: 0x181295040
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<int>, StylePropertyAnimationSystem.Values.StyleData<int>>.Add
	|
	|-RVA: 0x1293880 Offset: 0x1292A80 VA: 0x181293880
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Length>, StylePropertyAnimationSystem.Values.StyleData<Length>>.Add
	|
	|-RVA: 0x1294C40 Offset: 0x1293E40 VA: 0x181294C40
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<object>, StylePropertyAnimationSystem.Values.StyleData<object>>.Add
	|
	|-RVA: 0x1293650 Offset: 0x1292850 VA: 0x181293650
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Rotate>, StylePropertyAnimationSystem.Values.StyleData<Rotate>>.Add
	|
	|-RVA: 0x1295470 Offset: 0x1294670 VA: 0x181295470
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Scale>, StylePropertyAnimationSystem.Values.StyleData<Scale>>.Add
	|
	|-RVA: 0x1291E00 Offset: 0x1291000 VA: 0x181291E00
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<float>, StylePropertyAnimationSystem.Values.StyleData<float>>.Add
	|
	|-RVA: 0x1293410 Offset: 0x1292610 VA: 0x181293410
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<TextShadow>, StylePropertyAnimationSystem.Values.StyleData<TextShadow>>.Add
	|
	|-RVA: 0x1295240 Offset: 0x1294440 VA: 0x181295240
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<TransformOrigin>, StylePropertyAnimationSystem.Values.StyleData<TransformOrigin>>.Add
	|
	|-RVA: 0x12919F0 Offset: 0x1290BF0 VA: 0x1812919F0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Translate>, StylePropertyAnimationSystem.Values.StyleData<Translate>>.Add
	|
	|-RVA: 0x1294650 Offset: 0x1293850 VA: 0x181294650
	|-StylePropertyAnimationSystem.AnimationDataSet<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(int cancelledIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BEF90 Offset: 0x11BE190 VA: 0x1811BEF90
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Background>, Background>.Remove
	|
	|-RVA: 0x12A0F80 Offset: 0x12A0180 VA: 0x1812A0F80
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundPosition>, BackgroundPosition>.Remove
	|
	|-RVA: 0x12A3990 Offset: 0x12A2B90 VA: 0x1812A3990
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundRepeat>, BackgroundRepeat>.Remove
	|
	|-RVA: 0x12A1880 Offset: 0x12A0A80 VA: 0x1812A1880
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundSize>, BackgroundSize>.Remove
	|
	|-RVA: 0x129F470 Offset: 0x129E670 VA: 0x18129F470
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Color>, Color>.Remove
	|
	|-RVA: 0x12A2860 Offset: 0x12A1A60 VA: 0x1812A2860
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<FontDefinition>, FontDefinition>.Remove
	|
	|-RVA: 0x12A2B10 Offset: 0x12A1D10 VA: 0x1812A2B10
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<int>, int>.Remove
	|
	|-RVA: 0x12A06A0 Offset: 0x129F8A0 VA: 0x1812A06A0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Length>, Length>.Remove
	|
	|-RVA: 0x12A4270 Offset: 0x12A3470 VA: 0x1812A4270
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<object>, object>.Remove
	|
	|-RVA: 0x129F1A0 Offset: 0x129E3A0 VA: 0x18129F1A0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Rotate>, Rotate>.Remove
	|
	|-RVA: 0x129FA40 Offset: 0x129EC40 VA: 0x18129FA40
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Scale>, Scale>.Remove
	|
	|-RVA: 0x129EF10 Offset: 0x129E110 VA: 0x18129EF10
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<float>, float>.Remove
	|
	|-RVA: 0x12A3C20 Offset: 0x12A2E20 VA: 0x1812A3C20
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<TextShadow>, TextShadow>.Remove
	|
	|-RVA: 0x12A15C0 Offset: 0x12A07C0 VA: 0x1812A15C0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<TransformOrigin>, TransformOrigin>.Remove
	|
	|-RVA: 0x12A0080 Offset: 0x129F280 VA: 0x1812A0080
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Translate>, Translate>.Remove
	|
	|-RVA: 0x129FCF0 Offset: 0x129EEF0 VA: 0x18129FCF0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Background>, StylePropertyAnimationSystem.Values.StyleData<Background>>.Remove
	|
	|-RVA: 0x12A4820 Offset: 0x12A3A20 VA: 0x1812A4820
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundPosition>, StylePropertyAnimationSystem.Values.StyleData<BackgroundPosition>>.Remove
	|
	|-RVA: 0x129F720 Offset: 0x129E920 VA: 0x18129F720
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundRepeat>, StylePropertyAnimationSystem.Values.StyleData<BackgroundRepeat>>.Remove
	|
	|-RVA: 0x12A0350 Offset: 0x129F550 VA: 0x1812A0350
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundSize>, StylePropertyAnimationSystem.Values.StyleData<BackgroundSize>>.Remove
	|
	|-RVA: 0x12A0930 Offset: 0x129FB30 VA: 0x1812A0930
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Color>, StylePropertyAnimationSystem.Values.StyleData<Color>>.Remove
	|
	|-RVA: 0x12A1EB0 Offset: 0x12A10B0 VA: 0x1812A1EB0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<FontDefinition>, StylePropertyAnimationSystem.Values.StyleData<FontDefinition>>.Remove
	|
	|-RVA: 0x12A2DA0 Offset: 0x12A1FA0 VA: 0x1812A2DA0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<int>, StylePropertyAnimationSystem.Values.StyleData<int>>.Remove
	|
	|-RVA: 0x12A4500 Offset: 0x12A3700 VA: 0x1812A4500
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Length>, StylePropertyAnimationSystem.Values.StyleData<Length>>.Remove
	|
	|-RVA: 0x12A2540 Offset: 0x12A1740 VA: 0x1812A2540
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<object>, StylePropertyAnimationSystem.Values.StyleData<object>>.Remove
	|
	|-RVA: 0x12A1B40 Offset: 0x12A0D40 VA: 0x1812A1B40
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Rotate>, StylePropertyAnimationSystem.Values.StyleData<Rotate>>.Remove
	|
	|-RVA: 0x12A3650 Offset: 0x12A2850 VA: 0x1812A3650
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Scale>, StylePropertyAnimationSystem.Values.StyleData<Scale>>.Remove
	|
	|-RVA: 0x12A0C70 Offset: 0x129FE70 VA: 0x1812A0C70
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<float>, StylePropertyAnimationSystem.Values.StyleData<float>>.Remove
	|
	|-RVA: 0x12A1250 Offset: 0x12A0450 VA: 0x1812A1250
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<TextShadow>, StylePropertyAnimationSystem.Values.StyleData<TextShadow>>.Remove
	|
	|-RVA: 0x12A21F0 Offset: 0x12A13F0 VA: 0x1812A21F0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<TransformOrigin>, StylePropertyAnimationSystem.Values.StyleData<TransformOrigin>>.Remove
	|
	|-RVA: 0x12A3F00 Offset: 0x12A3100 VA: 0x1812A3F00
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Translate>, StylePropertyAnimationSystem.Values.StyleData<Translate>>.Remove
	|
	|-RVA: 0x12A30B0 Offset: 0x12A22B0 VA: 0x1812A30B0
	|-StylePropertyAnimationSystem.AnimationDataSet<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Replace(int index, TTimingData timingData, TStyleData styleData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BF250 Offset: 0x11BE450 VA: 0x1811BF250
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Background>, Background>.Replace
	|
	|-RVA: 0x12A52B0 Offset: 0x12A44B0 VA: 0x1812A52B0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundPosition>, BackgroundPosition>.Replace
	|
	|-RVA: 0x12A4CC0 Offset: 0x12A3EC0 VA: 0x1812A4CC0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundRepeat>, BackgroundRepeat>.Replace
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Length>, Length>.Replace
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<object>, object>.Replace
	|
	|-RVA: 0x12A5250 Offset: 0x12A4450 VA: 0x1812A5250
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundSize>, BackgroundSize>.Replace
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<TransformOrigin>, TransformOrigin>.Replace
	|
	|-RVA: 0x12A4BE0 Offset: 0x12A3DE0 VA: 0x1812A4BE0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Color>, Color>.Replace
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<FontDefinition>, FontDefinition>.Replace
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Scale>, Scale>.Replace
	|
	|-RVA: 0x12A4E40 Offset: 0x12A4040 VA: 0x1812A4E40
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<int>, int>.Replace
	|
	|-RVA: 0x12A51F0 Offset: 0x12A43F0 VA: 0x1812A51F0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Rotate>, Rotate>.Replace
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Translate>, Translate>.Replace
	|
	|-RVA: 0x12A5060 Offset: 0x12A4260 VA: 0x1812A5060
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<float>, float>.Replace
	|
	|-RVA: 0x12A4D10 Offset: 0x12A3F10 VA: 0x1812A4D10
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<TextShadow>, TextShadow>.Replace
	|
	|-RVA: 0x12A4D80 Offset: 0x12A3F80 VA: 0x1812A4D80
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Background>, StylePropertyAnimationSystem.Values.StyleData<Background>>.Replace
	|
	|-RVA: 0x12A4C30 Offset: 0x12A3E30 VA: 0x1812A4C30
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundPosition>, StylePropertyAnimationSystem.Values.StyleData<BackgroundPosition>>.Replace
	|
	|-RVA: 0x12A5170 Offset: 0x12A4370 VA: 0x1812A5170
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundRepeat>, StylePropertyAnimationSystem.Values.StyleData<BackgroundRepeat>>.Replace
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Length>, StylePropertyAnimationSystem.Values.StyleData<Length>>.Replace
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<object>, StylePropertyAnimationSystem.Values.StyleData<object>>.Replace
	|
	|-RVA: 0x12A4FB0 Offset: 0x12A41B0 VA: 0x1812A4FB0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundSize>, StylePropertyAnimationSystem.Values.StyleData<BackgroundSize>>.Replace
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<TransformOrigin>, StylePropertyAnimationSystem.Values.StyleData<TransformOrigin>>.Replace
	|
	|-RVA: 0x12A4B50 Offset: 0x12A3D50 VA: 0x1812A4B50
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Color>, StylePropertyAnimationSystem.Values.StyleData<Color>>.Replace
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<FontDefinition>, StylePropertyAnimationSystem.Values.StyleData<FontDefinition>>.Replace
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Scale>, StylePropertyAnimationSystem.Values.StyleData<Scale>>.Replace
	|
	|-RVA: 0x12A4E90 Offset: 0x12A4090 VA: 0x1812A4E90
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<int>, StylePropertyAnimationSystem.Values.StyleData<int>>.Replace
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<float>, StylePropertyAnimationSystem.Values.StyleData<float>>.Replace
	|
	|-RVA: 0x12A4F00 Offset: 0x12A4100 VA: 0x1812A4F00
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Rotate>, StylePropertyAnimationSystem.Values.StyleData<Rotate>>.Replace
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Translate>, StylePropertyAnimationSystem.Values.StyleData<Translate>>.Replace
	|
	|-RVA: 0x12A50B0 Offset: 0x12A42B0 VA: 0x1812A50B0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<TextShadow>, StylePropertyAnimationSystem.Values.StyleData<TextShadow>>.Replace
	|
	|-RVA: 0x12A5310 Offset: 0x12A4510 VA: 0x1812A5310
	|-StylePropertyAnimationSystem.AnimationDataSet<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Replace
	*/

	// RVA: -1 Offset: -1
	public void RemoveAll(VisualElement ve) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BEEE0 Offset: 0x11BE0E0 VA: 0x1811BEEE0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Background>, Background>.RemoveAll
	|
	|-RVA: 0x129E690 Offset: 0x129D890 VA: 0x18129E690
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundPosition>, BackgroundPosition>.RemoveAll
	|
	|-RVA: 0x129CB20 Offset: 0x129BD20 VA: 0x18129CB20
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundRepeat>, BackgroundRepeat>.RemoveAll
	|
	|-RVA: 0x129EE60 Offset: 0x129E060 VA: 0x18129EE60
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundSize>, BackgroundSize>.RemoveAll
	|
	|-RVA: 0x129D460 Offset: 0x129C660 VA: 0x18129D460
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Color>, Color>.RemoveAll
	|
	|-RVA: 0x129D9C0 Offset: 0x129CBC0 VA: 0x18129D9C0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<FontDefinition>, FontDefinition>.RemoveAll
	|
	|-RVA: 0x129E380 Offset: 0x129D580 VA: 0x18129E380
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<int>, int>.RemoveAll
	|
	|-RVA: 0x129E5E0 Offset: 0x129D7E0 VA: 0x18129E5E0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Length>, Length>.RemoveAll
	|
	|-RVA: 0x129D2E0 Offset: 0x129C4E0 VA: 0x18129D2E0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<object>, object>.RemoveAll
	|
	|-RVA: 0x129D910 Offset: 0x129CB10 VA: 0x18129D910
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Rotate>, Rotate>.RemoveAll
	|
	|-RVA: 0x129C610 Offset: 0x129B810 VA: 0x18129C610
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Scale>, Scale>.RemoveAll
	|
	|-RVA: 0x129CCD0 Offset: 0x129BED0 VA: 0x18129CCD0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<float>, float>.RemoveAll
	|
	|-RVA: 0x129ECB0 Offset: 0x129DEB0 VA: 0x18129ECB0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<TextShadow>, TextShadow>.RemoveAll
	|
	|-RVA: 0x129CE30 Offset: 0x129C030 VA: 0x18129CE30
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<TransformOrigin>, TransformOrigin>.RemoveAll
	|
	|-RVA: 0x129C8C0 Offset: 0x129BAC0 VA: 0x18129C8C0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Translate>, Translate>.RemoveAll
	|
	|-RVA: 0x129C460 Offset: 0x129B660 VA: 0x18129C460
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Background>, StylePropertyAnimationSystem.Values.StyleData<Background>>.RemoveAll
	|
	|-RVA: 0x129DE70 Offset: 0x129D070 VA: 0x18129DE70
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundPosition>, StylePropertyAnimationSystem.Values.StyleData<BackgroundPosition>>.RemoveAll
	|
	|-RVA: 0x129EC00 Offset: 0x129DE00 VA: 0x18129EC00
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundRepeat>, StylePropertyAnimationSystem.Values.StyleData<BackgroundRepeat>>.RemoveAll
	|
	|-RVA: 0x129E7F0 Offset: 0x129D9F0 VA: 0x18129E7F0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundSize>, StylePropertyAnimationSystem.Values.StyleData<BackgroundSize>>.RemoveAll
	|
	|-RVA: 0x129CD80 Offset: 0x129BF80 VA: 0x18129CD80
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Color>, StylePropertyAnimationSystem.Values.StyleData<Color>>.RemoveAll
	|
	|-RVA: 0x129DF20 Offset: 0x129D120 VA: 0x18129DF20
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<FontDefinition>, StylePropertyAnimationSystem.Values.StyleData<FontDefinition>>.RemoveAll
	|
	|-RVA: 0x129CA70 Offset: 0x129BC70 VA: 0x18129CA70
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<int>, StylePropertyAnimationSystem.Values.StyleData<int>>.RemoveAll
	|
	|-RVA: 0x129E530 Offset: 0x129D730 VA: 0x18129E530
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Length>, StylePropertyAnimationSystem.Values.StyleData<Length>>.RemoveAll
	|
	|-RVA: 0x129E740 Offset: 0x129D940 VA: 0x18129E740
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<object>, StylePropertyAnimationSystem.Values.StyleData<object>>.RemoveAll
	|
	|-RVA: 0x129C0B0 Offset: 0x129B2B0 VA: 0x18129C0B0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Rotate>, StylePropertyAnimationSystem.Values.StyleData<Rotate>>.RemoveAll
	|
	|-RVA: 0x129D030 Offset: 0x129C230 VA: 0x18129D030
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Scale>, StylePropertyAnimationSystem.Values.StyleData<Scale>>.RemoveAll
	|
	|-RVA: 0x129BE00 Offset: 0x129B000 VA: 0x18129BE00
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<float>, StylePropertyAnimationSystem.Values.StyleData<float>>.RemoveAll
	|
	|-RVA: 0x129E8A0 Offset: 0x129DAA0 VA: 0x18129E8A0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<TextShadow>, StylePropertyAnimationSystem.Values.StyleData<TextShadow>>.RemoveAll
	|
	|-RVA: 0x129EB50 Offset: 0x129DD50 VA: 0x18129EB50
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<TransformOrigin>, StylePropertyAnimationSystem.Values.StyleData<TransformOrigin>>.RemoveAll
	|
	|-RVA: 0x129E1D0 Offset: 0x129D3D0 VA: 0x18129E1D0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Translate>, StylePropertyAnimationSystem.Values.StyleData<Translate>>.RemoveAll
	|
	|-RVA: 0x129D390 Offset: 0x129C590 VA: 0x18129D390
	|-StylePropertyAnimationSystem.AnimationDataSet<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveAll
	*/

	// RVA: -1 Offset: -1
	public void RemoveAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BEDE0 Offset: 0x11BDFE0 VA: 0x1811BEDE0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Background>, Background>.RemoveAll
	|
	|-RVA: 0x129E0D0 Offset: 0x129D2D0 VA: 0x18129E0D0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundPosition>, BackgroundPosition>.RemoveAll
	|
	|-RVA: 0x129D810 Offset: 0x129CA10 VA: 0x18129D810
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundRepeat>, BackgroundRepeat>.RemoveAll
	|
	|-RVA: 0x129D1E0 Offset: 0x129C3E0 VA: 0x18129D1E0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundSize>, BackgroundSize>.RemoveAll
	|
	|-RVA: 0x129ED60 Offset: 0x129DF60 VA: 0x18129ED60
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Color>, Color>.RemoveAll
	|
	|-RVA: 0x129DB70 Offset: 0x129CD70 VA: 0x18129DB70
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<FontDefinition>, FontDefinition>.RemoveAll
	|
	|-RVA: 0x129E950 Offset: 0x129DB50 VA: 0x18129E950
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<int>, int>.RemoveAll
	|
	|-RVA: 0x129E280 Offset: 0x129D480 VA: 0x18129E280
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Length>, Length>.RemoveAll
	|
	|-RVA: 0x129DA70 Offset: 0x129CC70 VA: 0x18129DA70
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<object>, object>.RemoveAll
	|
	|-RVA: 0x129DFD0 Offset: 0x129D1D0 VA: 0x18129DFD0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Rotate>, Rotate>.RemoveAll
	|
	|-RVA: 0x129C160 Offset: 0x129B360 VA: 0x18129C160
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Scale>, Scale>.RemoveAll
	|
	|-RVA: 0x129DD70 Offset: 0x129CF70 VA: 0x18129DD70
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<float>, float>.RemoveAll
	|
	|-RVA: 0x129BEB0 Offset: 0x129B0B0 VA: 0x18129BEB0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<TextShadow>, TextShadow>.RemoveAll
	|
	|-RVA: 0x129DC70 Offset: 0x129CE70 VA: 0x18129DC70
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<TransformOrigin>, TransformOrigin>.RemoveAll
	|
	|-RVA: 0x129C970 Offset: 0x129BB70 VA: 0x18129C970
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Translate>, Translate>.RemoveAll
	|
	|-RVA: 0x129BC00 Offset: 0x129AE00 VA: 0x18129BC00
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Background>, StylePropertyAnimationSystem.Values.StyleData<Background>>.RemoveAll
	|
	|-RVA: 0x129C7C0 Offset: 0x129B9C0 VA: 0x18129C7C0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundPosition>, StylePropertyAnimationSystem.Values.StyleData<BackgroundPosition>>.RemoveAll
	|
	|-RVA: 0x129E430 Offset: 0x129D630 VA: 0x18129E430
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundRepeat>, StylePropertyAnimationSystem.Values.StyleData<BackgroundRepeat>>.RemoveAll
	|
	|-RVA: 0x129BD00 Offset: 0x129AF00 VA: 0x18129BD00
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundSize>, StylePropertyAnimationSystem.Values.StyleData<BackgroundSize>>.RemoveAll
	|
	|-RVA: 0x129CBD0 Offset: 0x129BDD0 VA: 0x18129CBD0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Color>, StylePropertyAnimationSystem.Values.StyleData<Color>>.RemoveAll
	|
	|-RVA: 0x129D610 Offset: 0x129C810 VA: 0x18129D610
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<FontDefinition>, StylePropertyAnimationSystem.Values.StyleData<FontDefinition>>.RemoveAll
	|
	|-RVA: 0x129C360 Offset: 0x129B560 VA: 0x18129C360
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<int>, StylePropertyAnimationSystem.Values.StyleData<int>>.RemoveAll
	|
	|-RVA: 0x129C6C0 Offset: 0x129B8C0 VA: 0x18129C6C0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Length>, StylePropertyAnimationSystem.Values.StyleData<Length>>.RemoveAll
	|
	|-RVA: 0x129BFB0 Offset: 0x129B1B0 VA: 0x18129BFB0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<object>, StylePropertyAnimationSystem.Values.StyleData<object>>.RemoveAll
	|
	|-RVA: 0x129EA50 Offset: 0x129DC50 VA: 0x18129EA50
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Rotate>, StylePropertyAnimationSystem.Values.StyleData<Rotate>>.RemoveAll
	|
	|-RVA: 0x129D0E0 Offset: 0x129C2E0 VA: 0x18129D0E0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Scale>, StylePropertyAnimationSystem.Values.StyleData<Scale>>.RemoveAll
	|
	|-RVA: 0x129C260 Offset: 0x129B460 VA: 0x18129C260
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<float>, StylePropertyAnimationSystem.Values.StyleData<float>>.RemoveAll
	|
	|-RVA: 0x129D510 Offset: 0x129C710 VA: 0x18129D510
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<TextShadow>, StylePropertyAnimationSystem.Values.StyleData<TextShadow>>.RemoveAll
	|
	|-RVA: 0x129D710 Offset: 0x129C910 VA: 0x18129D710
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<TransformOrigin>, StylePropertyAnimationSystem.Values.StyleData<TransformOrigin>>.RemoveAll
	|
	|-RVA: 0x129C510 Offset: 0x129B710 VA: 0x18129C510
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Translate>, StylePropertyAnimationSystem.Values.StyleData<Translate>>.RemoveAll
	|
	|-RVA: 0x129CEE0 Offset: 0x129C0E0 VA: 0x18129CEE0
	|-StylePropertyAnimationSystem.AnimationDataSet<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveAll
	*/

	// RVA: -1 Offset: -1
	public void GetActivePropertiesForElement(VisualElement ve, List<StylePropertyId> outProperties) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BEB00 Offset: 0x11BDD00 VA: 0x1811BEB00
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Background>, Background>.GetActivePropertiesForElement
	|
	|-RVA: 0x1296690 Offset: 0x1295890 VA: 0x181296690
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundPosition>, BackgroundPosition>.GetActivePropertiesForElement
	|
	|-RVA: 0x1297120 Offset: 0x1296320 VA: 0x181297120
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundRepeat>, BackgroundRepeat>.GetActivePropertiesForElement
	|
	|-RVA: 0x1296AA0 Offset: 0x1295CA0 VA: 0x181296AA0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<BackgroundSize>, BackgroundSize>.GetActivePropertiesForElement
	|
	|-RVA: 0x1296DE0 Offset: 0x1295FE0 VA: 0x181296DE0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Color>, Color>.GetActivePropertiesForElement
	|
	|-RVA: 0x1297940 Offset: 0x1296B40 VA: 0x181297940
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<FontDefinition>, FontDefinition>.GetActivePropertiesForElement
	|
	|-RVA: 0x12965C0 Offset: 0x12957C0 VA: 0x1812965C0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<int>, int>.GetActivePropertiesForElement
	|
	|-RVA: 0x1296C40 Offset: 0x1295E40 VA: 0x181296C40
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Length>, Length>.GetActivePropertiesForElement
	|
	|-RVA: 0x1297600 Offset: 0x1296800 VA: 0x181297600
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<object>, object>.GetActivePropertiesForElement
	|
	|-RVA: 0x1296F80 Offset: 0x1296180 VA: 0x181296F80
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Rotate>, Rotate>.GetActivePropertiesForElement
	|
	|-RVA: 0x1297D50 Offset: 0x1296F50 VA: 0x181297D50
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Scale>, Scale>.GetActivePropertiesForElement
	|
	|-RVA: 0x12969D0 Offset: 0x1295BD0 VA: 0x1812969D0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<float>, float>.GetActivePropertiesForElement
	|
	|-RVA: 0x1297BB0 Offset: 0x1296DB0 VA: 0x181297BB0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<TextShadow>, TextShadow>.GetActivePropertiesForElement
	|
	|-RVA: 0x1297C80 Offset: 0x1296E80 VA: 0x181297C80
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<TransformOrigin>, TransformOrigin>.GetActivePropertiesForElement
	|
	|-RVA: 0x1296760 Offset: 0x1295960 VA: 0x181296760
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<Translate>, Translate>.GetActivePropertiesForElement
	|
	|-RVA: 0x1296D10 Offset: 0x1295F10 VA: 0x181296D10
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Background>, StylePropertyAnimationSystem.Values.StyleData<Background>>.GetActivePropertiesForElement
	|
	|-RVA: 0x12977A0 Offset: 0x12969A0 VA: 0x1812977A0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundPosition>, StylePropertyAnimationSystem.Values.StyleData<BackgroundPosition>>.GetActivePropertiesForElement
	|
	|-RVA: 0x12976D0 Offset: 0x12968D0 VA: 0x1812976D0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundRepeat>, StylePropertyAnimationSystem.Values.StyleData<BackgroundRepeat>>.GetActivePropertiesForElement
	|
	|-RVA: 0x12971F0 Offset: 0x12963F0 VA: 0x1812971F0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<BackgroundSize>, StylePropertyAnimationSystem.Values.StyleData<BackgroundSize>>.GetActivePropertiesForElement
	|
	|-RVA: 0x1297A10 Offset: 0x1296C10 VA: 0x181297A10
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Color>, StylePropertyAnimationSystem.Values.StyleData<Color>>.GetActivePropertiesForElement
	|
	|-RVA: 0x1297AE0 Offset: 0x1296CE0 VA: 0x181297AE0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<FontDefinition>, StylePropertyAnimationSystem.Values.StyleData<FontDefinition>>.GetActivePropertiesForElement
	|
	|-RVA: 0x1297460 Offset: 0x1296660 VA: 0x181297460
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<int>, StylePropertyAnimationSystem.Values.StyleData<int>>.GetActivePropertiesForElement
	|
	|-RVA: 0x1297050 Offset: 0x1296250 VA: 0x181297050
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Length>, StylePropertyAnimationSystem.Values.StyleData<Length>>.GetActivePropertiesForElement
	|
	|-RVA: 0x1297530 Offset: 0x1296730 VA: 0x181297530
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<object>, StylePropertyAnimationSystem.Values.StyleData<object>>.GetActivePropertiesForElement
	|
	|-RVA: 0x1297870 Offset: 0x1296A70 VA: 0x181297870
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Rotate>, StylePropertyAnimationSystem.Values.StyleData<Rotate>>.GetActivePropertiesForElement
	|
	|-RVA: 0x12972C0 Offset: 0x12964C0 VA: 0x1812972C0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Scale>, StylePropertyAnimationSystem.Values.StyleData<Scale>>.GetActivePropertiesForElement
	|
	|-RVA: 0x1296EB0 Offset: 0x12960B0 VA: 0x181296EB0
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<float>, StylePropertyAnimationSystem.Values.StyleData<float>>.GetActivePropertiesForElement
	|
	|-RVA: 0x1296900 Offset: 0x1295B00 VA: 0x181296900
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<TextShadow>, StylePropertyAnimationSystem.Values.StyleData<TextShadow>>.GetActivePropertiesForElement
	|
	|-RVA: 0x1296830 Offset: 0x1295A30 VA: 0x181296830
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<TransformOrigin>, StylePropertyAnimationSystem.Values.StyleData<TransformOrigin>>.GetActivePropertiesForElement
	|
	|-RVA: 0x1296B70 Offset: 0x1295D70 VA: 0x181296B70
	|-StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<Translate>, StylePropertyAnimationSystem.Values.StyleData<Translate>>.GetActivePropertiesForElement
	|
	|-RVA: 0x1297390 Offset: 0x1296590 VA: 0x181297390
	|-StylePropertyAnimationSystem.AnimationDataSet<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetActivePropertiesForElement
	*/
}

// Namespace: 
private class StylePropertyAnimationSystem.ElementPropertyPair.EqualityComparer : IEqualityComparer<StylePropertyAnimationSystem.ElementPropertyPair> // TypeDefIndex: 11487
{
	// Methods

	// RVA: 0x26B4280 Offset: 0x26B3480 VA: 0x1826B4280 Slot: 4
	public bool Equals(StylePropertyAnimationSystem.ElementPropertyPair x, StylePropertyAnimationSystem.ElementPropertyPair y) { }

	// RVA: 0x26B42A0 Offset: 0x26B34A0 VA: 0x1826B42A0 Slot: 5
	public int GetHashCode(StylePropertyAnimationSystem.ElementPropertyPair obj) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private struct StylePropertyAnimationSystem.ElementPropertyPair // TypeDefIndex: 11488
{
	// Fields
	public static readonly IEqualityComparer<StylePropertyAnimationSystem.ElementPropertyPair> Comparer; // 0x0
	public readonly VisualElement element; // 0x0
	public readonly StylePropertyId property; // 0x8

	// Methods

	// RVA: 0x5511A0 Offset: 0x5503A0 VA: 0x1805511A0
	public void .ctor(VisualElement element, StylePropertyId property) { }

	// RVA: 0x26B4220 Offset: 0x26B3420 VA: 0x1826B4220
	private static void .cctor() { }
}

// Namespace: 
private abstract class StylePropertyAnimationSystem.Values // TypeDefIndex: 11489
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void CancelAllAnimations();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void CancelAllAnimations(VisualElement ve);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void CancelAnimation(VisualElement ve, StylePropertyId id);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void UpdateAnimation(VisualElement ve, StylePropertyId id);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void GetAllAnimations(VisualElement ve, List<StylePropertyId> outPropertyIds);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Update(long currentTimeMs);

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void UpdateValues();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void UpdateComputedStyle();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void UpdateComputedStyle(int i);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<T> // TypeDefIndex: 11490
{
	// Fields
	public static readonly StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<T> <>9; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08330 Offset: 0xB07530 VA: 0x180B08330
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<Background>..cctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<BackgroundPosition>..cctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<BackgroundRepeat>..cctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<BackgroundSize>..cctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<Color>..cctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<FontDefinition>..cctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<int>..cctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<Length>..cctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<object>..cctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<Rotate>..cctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<Scale>..cctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<float>..cctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<TextShadow>..cctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<TransformOrigin>..cctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<Translate>..cctor
	|
	|-RVA: 0xB08640 Offset: 0xB07840 VA: 0x180B08640
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<Background>..ctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<BackgroundPosition>..ctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<BackgroundRepeat>..ctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<BackgroundSize>..ctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<Color>..ctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<FontDefinition>..ctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<int>..ctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<Length>..ctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<object>..ctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<Rotate>..ctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<Scale>..ctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<float>..ctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<TextShadow>..ctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<TransformOrigin>..ctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<Translate>..ctor
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal Queue<EventBase> <.cctor>b__11_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB06F40 Offset: 0xB06140 VA: 0x180B06F40
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<Background>.<.cctor>b__11_0
	|
	|-RVA: 0xB070C0 Offset: 0xB062C0 VA: 0x180B070C0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<BackgroundPosition>.<.cctor>b__11_0
	|
	|-RVA: 0xB073C0 Offset: 0xB065C0 VA: 0x180B073C0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<BackgroundRepeat>.<.cctor>b__11_0
	|
	|-RVA: 0xB072A0 Offset: 0xB064A0 VA: 0x180B072A0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<BackgroundSize>.<.cctor>b__11_0
	|
	|-RVA: 0xB07360 Offset: 0xB06560 VA: 0x180B07360
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<Color>.<.cctor>b__11_0
	|
	|-RVA: 0xB07240 Offset: 0xB06440 VA: 0x180B07240
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<FontDefinition>.<.cctor>b__11_0
	|
	|-RVA: 0xB07060 Offset: 0xB06260 VA: 0x180B07060
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<int>.<.cctor>b__11_0
	|
	|-RVA: 0xB07120 Offset: 0xB06320 VA: 0x180B07120
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<Length>.<.cctor>b__11_0
	|
	|-RVA: 0xB07180 Offset: 0xB06380 VA: 0x180B07180
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<object>.<.cctor>b__11_0
	|
	|-RVA: 0xB07300 Offset: 0xB06500 VA: 0x180B07300
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<Rotate>.<.cctor>b__11_0
	|
	|-RVA: 0xB07480 Offset: 0xB06680 VA: 0x180B07480
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<Scale>.<.cctor>b__11_0
	|
	|-RVA: 0xB074E0 Offset: 0xB066E0 VA: 0x180B074E0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<float>.<.cctor>b__11_0
	|
	|-RVA: 0xB07420 Offset: 0xB06620 VA: 0x180B07420
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<TextShadow>.<.cctor>b__11_0
	|
	|-RVA: 0xB06FA0 Offset: 0xB061A0 VA: 0x180B06FA0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<TransformOrigin>.<.cctor>b__11_0
	|
	|-RVA: 0xB07000 Offset: 0xB06200 VA: 0x180B07000
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<Translate>.<.cctor>b__11_0
	|
	|-RVA: 0xB071E0 Offset: 0xB063E0 VA: 0x180B071E0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<__Il2CppFullySharedGenericType>.<.cctor>b__11_0
	*/
}

// Namespace: 
private class StylePropertyAnimationSystem.Values.TransitionEventsFrameState<T> // TypeDefIndex: 11491
{
	// Fields
	private static readonly ObjectPool<Queue<EventBase>> k_EventQueuePool; // 0x0
	public readonly Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, StylePropertyAnimationSystem.TransitionState> elementPropertyStateDelta; // 0x0
	public readonly Dictionary<StylePropertyAnimationSystem.ElementPropertyPair, Queue<EventBase>> elementPropertyQueuedEvents; // 0x0
	public IPanel panel; // 0x0
	private int m_ChangesCount; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static Queue<EventBase> GetPooledQueue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCB81A0 Offset: 0xCB73A0 VA: 0x180CB81A0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Background>.GetPooledQueue
	|
	|-RVA: 0xCB80E0 Offset: 0xCB72E0 VA: 0x180CB80E0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<BackgroundPosition>.GetPooledQueue
	|
	|-RVA: 0xCB78A0 Offset: 0xCB6AA0 VA: 0x180CB78A0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<BackgroundRepeat>.GetPooledQueue
	|
	|-RVA: 0xCB8020 Offset: 0xCB7220 VA: 0x180CB8020
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<BackgroundSize>.GetPooledQueue
	|
	|-RVA: 0xCB7C60 Offset: 0xCB6E60 VA: 0x180CB7C60
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Color>.GetPooledQueue
	|
	|-RVA: 0xCB7660 Offset: 0xCB6860 VA: 0x180CB7660
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<FontDefinition>.GetPooledQueue
	|
	|-RVA: 0xCB7EA0 Offset: 0xCB70A0 VA: 0x180CB7EA0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<int>.GetPooledQueue
	|
	|-RVA: 0xCB7D20 Offset: 0xCB6F20 VA: 0x180CB7D20
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Length>.GetPooledQueue
	|
	|-RVA: 0xCB7A20 Offset: 0xCB6C20 VA: 0x180CB7A20
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<object>.GetPooledQueue
	|
	|-RVA: 0xCB7960 Offset: 0xCB6B60 VA: 0x180CB7960
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Rotate>.GetPooledQueue
	|
	|-RVA: 0xCB7F60 Offset: 0xCB7160 VA: 0x180CB7F60
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Scale>.GetPooledQueue
	|
	|-RVA: 0xCB7720 Offset: 0xCB6920 VA: 0x180CB7720
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<float>.GetPooledQueue
	|
	|-RVA: 0xCB7DE0 Offset: 0xCB6FE0 VA: 0x180CB7DE0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<TextShadow>.GetPooledQueue
	|
	|-RVA: 0xCB77E0 Offset: 0xCB69E0 VA: 0x180CB77E0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<TransformOrigin>.GetPooledQueue
	|
	|-RVA: 0xCB7BA0 Offset: 0xCB6DA0 VA: 0x180CB7BA0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Translate>.GetPooledQueue
	|
	|-RVA: 0xCB7AE0 Offset: 0xCB6CE0 VA: 0x180CB7AE0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<__Il2CppFullySharedGenericType>.GetPooledQueue
	*/

	// RVA: -1 Offset: -1
	public void RegisterChange() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCB8260 Offset: 0xCB7460 VA: 0x180CB8260
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Background>.RegisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<BackgroundPosition>.RegisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<BackgroundRepeat>.RegisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<BackgroundSize>.RegisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Color>.RegisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<FontDefinition>.RegisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<int>.RegisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Length>.RegisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<object>.RegisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Rotate>.RegisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Scale>.RegisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<float>.RegisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<TextShadow>.RegisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<TransformOrigin>.RegisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Translate>.RegisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<__Il2CppFullySharedGenericType>.RegisterChange
	*/

	// RVA: -1 Offset: -1
	public void UnregisterChange() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCB8280 Offset: 0xCB7480 VA: 0x180CB8280
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Background>.UnregisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<BackgroundPosition>.UnregisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<BackgroundRepeat>.UnregisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<BackgroundSize>.UnregisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Color>.UnregisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<FontDefinition>.UnregisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<int>.UnregisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Length>.UnregisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<object>.UnregisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Rotate>.UnregisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Scale>.UnregisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<float>.UnregisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<TextShadow>.UnregisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<TransformOrigin>.UnregisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Translate>.UnregisterChange
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<__Il2CppFullySharedGenericType>.UnregisterChange
	*/

	// RVA: -1 Offset: -1
	public bool StateChanged() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCB8270 Offset: 0xCB7470 VA: 0x180CB8270
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Background>.StateChanged
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<BackgroundPosition>.StateChanged
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<BackgroundRepeat>.StateChanged
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<BackgroundSize>.StateChanged
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Color>.StateChanged
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<FontDefinition>.StateChanged
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<int>.StateChanged
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Length>.StateChanged
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<object>.StateChanged
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Rotate>.StateChanged
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Scale>.StateChanged
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<float>.StateChanged
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<TextShadow>.StateChanged
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<TransformOrigin>.StateChanged
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Translate>.StateChanged
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<__Il2CppFullySharedGenericType>.StateChanged
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCB6F70 Offset: 0xCB6170 VA: 0x180CB6F70
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Background>.Clear
	|
	|-RVA: 0xCB6AD0 Offset: 0xCB5CD0 VA: 0x180CB6AD0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<BackgroundPosition>.Clear
	|
	|-RVA: 0xCB6190 Offset: 0xCB5390 VA: 0x180CB6190
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<BackgroundRepeat>.Clear
	|
	|-RVA: 0xCB53B0 Offset: 0xCB45B0 VA: 0x180CB53B0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<BackgroundSize>.Clear
	|
	|-RVA: 0xCB63E0 Offset: 0xCB55E0 VA: 0x180CB63E0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Color>.Clear
	|
	|-RVA: 0xCB71C0 Offset: 0xCB63C0 VA: 0x180CB71C0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<FontDefinition>.Clear
	|
	|-RVA: 0xCB5F40 Offset: 0xCB5140 VA: 0x180CB5F40
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<int>.Clear
	|
	|-RVA: 0xCB5CF0 Offset: 0xCB4EF0 VA: 0x180CB5CF0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Length>.Clear
	|
	|-RVA: 0xCB5160 Offset: 0xCB4360 VA: 0x180CB5160
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<object>.Clear
	|
	|-RVA: 0xCB5850 Offset: 0xCB4A50 VA: 0x180CB5850
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Rotate>.Clear
	|
	|-RVA: 0xCB6D20 Offset: 0xCB5F20 VA: 0x180CB6D20
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Scale>.Clear
	|
	|-RVA: 0xCB7410 Offset: 0xCB6610 VA: 0x180CB7410
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<float>.Clear
	|
	|-RVA: 0xCB5AA0 Offset: 0xCB4CA0 VA: 0x180CB5AA0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<TextShadow>.Clear
	|
	|-RVA: 0xCB5600 Offset: 0xCB4800 VA: 0x180CB5600
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<TransformOrigin>.Clear
	|
	|-RVA: 0xCB6630 Offset: 0xCB5830 VA: 0x180CB6630
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Translate>.Clear
	|
	|-RVA: 0xCB6880 Offset: 0xCB5A80 VA: 0x180CB6880
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCBA890 Offset: 0xCB9A90 VA: 0x180CBA890
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Background>..ctor
	|
	|-RVA: 0xCBAB90 Offset: 0xCB9D90 VA: 0x180CBAB90
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<BackgroundPosition>..ctor
	|
	|-RVA: 0xCBA190 Offset: 0xCB9390 VA: 0x180CBA190
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<BackgroundRepeat>..ctor
	|
	|-RVA: 0xCBA290 Offset: 0xCB9490 VA: 0x180CBA290
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<BackgroundSize>..ctor
	|
	|-RVA: 0xCB9F90 Offset: 0xCB9190 VA: 0x180CB9F90
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Color>..ctor
	|
	|-RVA: 0xCBA390 Offset: 0xCB9590 VA: 0x180CBA390
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<FontDefinition>..ctor
	|
	|-RVA: 0xCBA090 Offset: 0xCB9290 VA: 0x180CBA090
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<int>..ctor
	|
	|-RVA: 0xCBA490 Offset: 0xCB9690 VA: 0x180CBA490
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Length>..ctor
	|
	|-RVA: 0xCBA690 Offset: 0xCB9890 VA: 0x180CBA690
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<object>..ctor
	|
	|-RVA: 0xCBAC90 Offset: 0xCB9E90 VA: 0x180CBAC90
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Rotate>..ctor
	|
	|-RVA: 0xCBAD90 Offset: 0xCB9F90 VA: 0x180CBAD90
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Scale>..ctor
	|
	|-RVA: 0xCBAA90 Offset: 0xCB9C90 VA: 0x180CBAA90
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<float>..ctor
	|
	|-RVA: 0xCBAE90 Offset: 0xCBA090 VA: 0x180CBAE90
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<TextShadow>..ctor
	|
	|-RVA: 0xCBA990 Offset: 0xCB9B90 VA: 0x180CBA990
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<TransformOrigin>..ctor
	|
	|-RVA: 0xCBA590 Offset: 0xCB9790 VA: 0x180CBA590
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Translate>..ctor
	|
	|-RVA: 0xCBA790 Offset: 0xCB9990 VA: 0x180CBA790
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCB8630 Offset: 0xCB7830 VA: 0x180CB8630
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Background>..cctor
	|
	|-RVA: 0xCB9680 Offset: 0xCB8880 VA: 0x180CB9680
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<BackgroundPosition>..cctor
	|
	|-RVA: 0xCB8BA0 Offset: 0xCB7DA0 VA: 0x180CB8BA0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<BackgroundRepeat>..cctor
	|
	|-RVA: 0xCB9A20 Offset: 0xCB8C20 VA: 0x180CB9A20
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<BackgroundSize>..cctor
	|
	|-RVA: 0xCB8F40 Offset: 0xCB8140 VA: 0x180CB8F40
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Color>..cctor
	|
	|-RVA: 0xCB8D70 Offset: 0xCB7F70 VA: 0x180CB8D70
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<FontDefinition>..cctor
	|
	|-RVA: 0xCB8460 Offset: 0xCB7660 VA: 0x180CB8460
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<int>..cctor
	|
	|-RVA: 0xCB92E0 Offset: 0xCB84E0 VA: 0x180CB92E0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Length>..cctor
	|
	|-RVA: 0xCB94B0 Offset: 0xCB86B0 VA: 0x180CB94B0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<object>..cctor
	|
	|-RVA: 0xCB89D0 Offset: 0xCB7BD0 VA: 0x180CB89D0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Rotate>..cctor
	|
	|-RVA: 0xCB8290 Offset: 0xCB7490 VA: 0x180CB8290
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Scale>..cctor
	|
	|-RVA: 0xCB8800 Offset: 0xCB7A00 VA: 0x180CB8800
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<float>..cctor
	|
	|-RVA: 0xCB9110 Offset: 0xCB8310 VA: 0x180CB9110
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<TextShadow>..cctor
	|
	|-RVA: 0xCB9DC0 Offset: 0xCB8FC0 VA: 0x180CB9DC0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<TransformOrigin>..cctor
	|
	|-RVA: 0xCB9850 Offset: 0xCB8A50 VA: 0x180CB9850
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<Translate>..cctor
	|
	|-RVA: 0xCB9BF0 Offset: 0xCB8DF0 VA: 0x180CB9BF0
	|-StylePropertyAnimationSystem.Values.TransitionEventsFrameState<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: 
public struct StylePropertyAnimationSystem.Values.TimingData<T> // TypeDefIndex: 11492
{
	// Fields
	public long startTimeMs; // 0x0
	public int durationMs; // 0x0
	public Func<float, float> easingCurve; // 0x0
	public float easedProgress; // 0x0
	public float reversingShorteningFactor; // 0x0
	public bool isStarted; // 0x0
	public int delayMs; // 0x0
}

// Namespace: 
public struct StylePropertyAnimationSystem.Values.StyleData<T> // TypeDefIndex: 11493
{
	// Fields
	public T startValue; // 0x0
	public T endValue; // 0x0
	public T reversingAdjustedStartValue; // 0x0
	public T currentValue; // 0x0
}

// Namespace: 
public struct StylePropertyAnimationSystem.Values.EmptyData<T> // TypeDefIndex: 11494
{
	// Fields
	public static StylePropertyAnimationSystem.Values.EmptyData<T> Default; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10DCCA0 Offset: 0x10DBEA0 VA: 0x1810DCCA0
	|-StylePropertyAnimationSystem.Values.EmptyData<Background>..cctor
	|-StylePropertyAnimationSystem.Values.EmptyData<BackgroundPosition>..cctor
	|-StylePropertyAnimationSystem.Values.EmptyData<BackgroundRepeat>..cctor
	|-StylePropertyAnimationSystem.Values.EmptyData<BackgroundSize>..cctor
	|-StylePropertyAnimationSystem.Values.EmptyData<Color>..cctor
	|-StylePropertyAnimationSystem.Values.EmptyData<FontDefinition>..cctor
	|-StylePropertyAnimationSystem.Values.EmptyData<int>..cctor
	|-StylePropertyAnimationSystem.Values.EmptyData<Length>..cctor
	|-StylePropertyAnimationSystem.Values.EmptyData<object>..cctor
	|-StylePropertyAnimationSystem.Values.EmptyData<Rotate>..cctor
	|-StylePropertyAnimationSystem.Values.EmptyData<Scale>..cctor
	|-StylePropertyAnimationSystem.Values.EmptyData<float>..cctor
	|-StylePropertyAnimationSystem.Values.EmptyData<TextShadow>..cctor
	|-StylePropertyAnimationSystem.Values.EmptyData<TransformOrigin>..cctor
	|-StylePropertyAnimationSystem.Values.EmptyData<Translate>..cctor
	|-StylePropertyAnimationSystem.Values.EmptyData<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: 
private abstract class StylePropertyAnimationSystem.Values<T> : StylePropertyAnimationSystem.Values // TypeDefIndex: 11495
{
	// Fields
	private long m_CurrentTimeMs; // 0x0
	private StylePropertyAnimationSystem.Values.TransitionEventsFrameState<T> m_CurrentFrameEventsState; // 0x0
	private StylePropertyAnimationSystem.Values.TransitionEventsFrameState<T> m_NextFrameEventsState; // 0x0
	public StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.TimingData<T>, StylePropertyAnimationSystem.Values.StyleData<T>> running; // 0x0
	public StylePropertyAnimationSystem.AnimationDataSet<StylePropertyAnimationSystem.Values.EmptyData<T>, T> completed; // 0x0

	// Properties
	public bool isEmpty { get; }
	public abstract Func<T, T, bool> SameFunc { get; }

	// Methods

	// RVA: -1 Offset: -1
	public bool get_isEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD746B0 Offset: 0xD738B0 VA: 0x180D746B0
	|-StylePropertyAnimationSystem.Values<Background>.get_isEmpty
	|-StylePropertyAnimationSystem.Values<BackgroundPosition>.get_isEmpty
	|-StylePropertyAnimationSystem.Values<BackgroundRepeat>.get_isEmpty
	|-StylePropertyAnimationSystem.Values<BackgroundSize>.get_isEmpty
	|-StylePropertyAnimationSystem.Values<Color>.get_isEmpty
	|-StylePropertyAnimationSystem.Values<FontDefinition>.get_isEmpty
	|-StylePropertyAnimationSystem.Values<int>.get_isEmpty
	|-StylePropertyAnimationSystem.Values<Length>.get_isEmpty
	|-StylePropertyAnimationSystem.Values<object>.get_isEmpty
	|-StylePropertyAnimationSystem.Values<Rotate>.get_isEmpty
	|-StylePropertyAnimationSystem.Values<Scale>.get_isEmpty
	|-StylePropertyAnimationSystem.Values<float>.get_isEmpty
	|-StylePropertyAnimationSystem.Values<TextShadow>.get_isEmpty
	|-StylePropertyAnimationSystem.Values<TransformOrigin>.get_isEmpty
	|-StylePropertyAnimationSystem.Values<Translate>.get_isEmpty
	|-StylePropertyAnimationSystem.Values<__Il2CppFullySharedGenericType>.get_isEmpty
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public abstract Func<T, T, bool> get_SameFunc();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-StylePropertyAnimationSystem.Values<__Il2CppFullySharedGenericType>.get_SameFunc
	*/

	// RVA: -1 Offset: -1 Slot: 14
	protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref T a, ref T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD72460 Offset: 0xD71660 VA: 0x180D72460
	|-StylePropertyAnimationSystem.Values<Background>.ConvertUnits
	|-StylePropertyAnimationSystem.Values<BackgroundPosition>.ConvertUnits
	|-StylePropertyAnimationSystem.Values<BackgroundRepeat>.ConvertUnits
	|-StylePropertyAnimationSystem.Values<BackgroundSize>.ConvertUnits
	|-StylePropertyAnimationSystem.Values<Color>.ConvertUnits
	|-StylePropertyAnimationSystem.Values<FontDefinition>.ConvertUnits
	|-StylePropertyAnimationSystem.Values<int>.ConvertUnits
	|-StylePropertyAnimationSystem.Values<Length>.ConvertUnits
	|-StylePropertyAnimationSystem.Values<object>.ConvertUnits
	|-StylePropertyAnimationSystem.Values<Rotate>.ConvertUnits
	|-StylePropertyAnimationSystem.Values<Scale>.ConvertUnits
	|-StylePropertyAnimationSystem.Values<float>.ConvertUnits
	|-StylePropertyAnimationSystem.Values<TextShadow>.ConvertUnits
	|-StylePropertyAnimationSystem.Values<TransformOrigin>.ConvertUnits
	|-StylePropertyAnimationSystem.Values<Translate>.ConvertUnits
	|-StylePropertyAnimationSystem.Values<__Il2CppFullySharedGenericType>.ConvertUnits
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD74540 Offset: 0xD73740 VA: 0x180D74540
	|-StylePropertyAnimationSystem.Values<Background>..ctor
	|
	|-RVA: 0xD873B0 Offset: 0xD865B0 VA: 0x180D873B0
	|-StylePropertyAnimationSystem.Values<BackgroundPosition>..ctor
	|
	|-RVA: 0xD86F60 Offset: 0xD86160 VA: 0x180D86F60
	|-StylePropertyAnimationSystem.Values<BackgroundRepeat>..ctor
	|
	|-RVA: 0xD870D0 Offset: 0xD862D0 VA: 0x180D870D0
	|-StylePropertyAnimationSystem.Values<BackgroundSize>..ctor
	|
	|-RVA: 0xD86DF0 Offset: 0xD85FF0 VA: 0x180D86DF0
	|-StylePropertyAnimationSystem.Values<Color>..ctor
	|
	|-RVA: 0xD87690 Offset: 0xD86890 VA: 0x180D87690
	|-StylePropertyAnimationSystem.Values<FontDefinition>..ctor
	|
	|-RVA: 0xD87240 Offset: 0xD86440 VA: 0x180D87240
	|-StylePropertyAnimationSystem.Values<int>..ctor
	|
	|-RVA: 0xD87520 Offset: 0xD86720 VA: 0x180D87520
	|-StylePropertyAnimationSystem.Values<Length>..ctor
	|
	|-RVA: 0xD9A3B0 Offset: 0xD995B0 VA: 0x180D9A3B0
	|-StylePropertyAnimationSystem.Values<object>..ctor
	|
	|-RVA: 0xD9A970 Offset: 0xD99B70 VA: 0x180D9A970
	|-StylePropertyAnimationSystem.Values<Rotate>..ctor
	|
	|-RVA: 0xD9A520 Offset: 0xD99720 VA: 0x180D9A520
	|-StylePropertyAnimationSystem.Values<Scale>..ctor
	|
	|-RVA: 0xD9A690 Offset: 0xD99890 VA: 0x180D9A690
	|-StylePropertyAnimationSystem.Values<float>..ctor
	|
	|-RVA: 0xD9AAE0 Offset: 0xD99CE0 VA: 0x180D9AAE0
	|-StylePropertyAnimationSystem.Values<TextShadow>..ctor
	|
	|-RVA: 0xD9AC50 Offset: 0xD99E50 VA: 0x180D9AC50
	|-StylePropertyAnimationSystem.Values<TransformOrigin>..ctor
	|
	|-RVA: 0xD9A800 Offset: 0xD99A00 VA: 0x180D9A800
	|-StylePropertyAnimationSystem.Values<Translate>..ctor
	|
	|-RVA: 0xDA2AE0 Offset: 0xDA1CE0 VA: 0x180DA2AE0
	|-StylePropertyAnimationSystem.Values<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void SwapFrameStates() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD73FF0 Offset: 0xD731F0 VA: 0x180D73FF0
	|-StylePropertyAnimationSystem.Values<Background>.SwapFrameStates
	|-StylePropertyAnimationSystem.Values<BackgroundPosition>.SwapFrameStates
	|-StylePropertyAnimationSystem.Values<BackgroundRepeat>.SwapFrameStates
	|-StylePropertyAnimationSystem.Values<BackgroundSize>.SwapFrameStates
	|-StylePropertyAnimationSystem.Values<Color>.SwapFrameStates
	|-StylePropertyAnimationSystem.Values<FontDefinition>.SwapFrameStates
	|-StylePropertyAnimationSystem.Values<int>.SwapFrameStates
	|-StylePropertyAnimationSystem.Values<Length>.SwapFrameStates
	|-StylePropertyAnimationSystem.Values<object>.SwapFrameStates
	|-StylePropertyAnimationSystem.Values<Rotate>.SwapFrameStates
	|-StylePropertyAnimationSystem.Values<Scale>.SwapFrameStates
	|-StylePropertyAnimationSystem.Values<float>.SwapFrameStates
	|-StylePropertyAnimationSystem.Values<TextShadow>.SwapFrameStates
	|-StylePropertyAnimationSystem.Values<TransformOrigin>.SwapFrameStates
	|-StylePropertyAnimationSystem.Values<Translate>.SwapFrameStates
	|-StylePropertyAnimationSystem.Values<__Il2CppFullySharedGenericType>.SwapFrameStates
	*/

	// RVA: -1 Offset: -1
	private void QueueEvent(EventBase evt, StylePropertyAnimationSystem.ElementPropertyPair epp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD72810 Offset: 0xD71A10 VA: 0x180D72810
	|-StylePropertyAnimationSystem.Values<Background>.QueueEvent
	|
	|-RVA: 0xD7B5D0 Offset: 0xD7A7D0 VA: 0x180D7B5D0
	|-StylePropertyAnimationSystem.Values<BackgroundPosition>.QueueEvent
	|
	|-RVA: 0xD7B420 Offset: 0xD7A620 VA: 0x180D7B420
	|-StylePropertyAnimationSystem.Values<BackgroundRepeat>.QueueEvent
	|
	|-RVA: 0xD7AD60 Offset: 0xD79F60 VA: 0x180D7AD60
	|-StylePropertyAnimationSystem.Values<BackgroundSize>.QueueEvent
	|
	|-RVA: 0xD7B780 Offset: 0xD7A980 VA: 0x180D7B780
	|-StylePropertyAnimationSystem.Values<Color>.QueueEvent
	|
	|-RVA: 0xD7B270 Offset: 0xD7A470 VA: 0x180D7B270
	|-StylePropertyAnimationSystem.Values<FontDefinition>.QueueEvent
	|
	|-RVA: 0xD7B0C0 Offset: 0xD7A2C0 VA: 0x180D7B0C0
	|-StylePropertyAnimationSystem.Values<int>.QueueEvent
	|
	|-RVA: 0xD7AF10 Offset: 0xD7A110 VA: 0x180D7AF10
	|-StylePropertyAnimationSystem.Values<Length>.QueueEvent
	|
	|-RVA: 0xD8E4C0 Offset: 0xD8D6C0 VA: 0x180D8E4C0
	|-StylePropertyAnimationSystem.Values<object>.QueueEvent
	|
	|-RVA: 0xD8E820 Offset: 0xD8DA20 VA: 0x180D8E820
	|-StylePropertyAnimationSystem.Values<Rotate>.QueueEvent
	|
	|-RVA: 0xD8E160 Offset: 0xD8D360 VA: 0x180D8E160
	|-StylePropertyAnimationSystem.Values<Scale>.QueueEvent
	|
	|-RVA: 0xD8DFB0 Offset: 0xD8D1B0 VA: 0x180D8DFB0
	|-StylePropertyAnimationSystem.Values<float>.QueueEvent
	|
	|-RVA: 0xD8E310 Offset: 0xD8D510 VA: 0x180D8E310
	|-StylePropertyAnimationSystem.Values<TextShadow>.QueueEvent
	|
	|-RVA: 0xD8DE00 Offset: 0xD8D000 VA: 0x180D8DE00
	|-StylePropertyAnimationSystem.Values<TransformOrigin>.QueueEvent
	|
	|-RVA: 0xD8E670 Offset: 0xD8D870 VA: 0x180D8E670
	|-StylePropertyAnimationSystem.Values<Translate>.QueueEvent
	|
	|-RVA: 0xDA0540 Offset: 0xD9F740 VA: 0x180DA0540
	|-StylePropertyAnimationSystem.Values<__Il2CppFullySharedGenericType>.QueueEvent
	*/

	// RVA: -1 Offset: -1
	private void ClearEventQueue(StylePropertyAnimationSystem.ElementPropertyPair epp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD72290 Offset: 0xD71490 VA: 0x180D72290
	|-StylePropertyAnimationSystem.Values<Background>.ClearEventQueue
	|
	|-RVA: 0xD790A0 Offset: 0xD782A0 VA: 0x180D790A0
	|-StylePropertyAnimationSystem.Values<BackgroundPosition>.ClearEventQueue
	|
	|-RVA: 0xD78F90 Offset: 0xD78190 VA: 0x180D78F90
	|-StylePropertyAnimationSystem.Values<BackgroundRepeat>.ClearEventQueue
	|
	|-RVA: 0xD78D70 Offset: 0xD77F70 VA: 0x180D78D70
	|-StylePropertyAnimationSystem.Values<BackgroundSize>.ClearEventQueue
	|
	|-RVA: 0xD793D0 Offset: 0xD785D0 VA: 0x180D793D0
	|-StylePropertyAnimationSystem.Values<Color>.ClearEventQueue
	|
	|-RVA: 0xD792C0 Offset: 0xD784C0 VA: 0x180D792C0
	|-StylePropertyAnimationSystem.Values<FontDefinition>.ClearEventQueue
	|
	|-RVA: 0xD791B0 Offset: 0xD783B0 VA: 0x180D791B0
	|-StylePropertyAnimationSystem.Values<int>.ClearEventQueue
	|
	|-RVA: 0xD78E80 Offset: 0xD78080 VA: 0x180D78E80
	|-StylePropertyAnimationSystem.Values<Length>.ClearEventQueue
	|
	|-RVA: 0xD8C440 Offset: 0xD8B640 VA: 0x180D8C440
	|-StylePropertyAnimationSystem.Values<object>.ClearEventQueue
	|
	|-RVA: 0xD8C220 Offset: 0xD8B420 VA: 0x180D8C220
	|-StylePropertyAnimationSystem.Values<Rotate>.ClearEventQueue
	|
	|-RVA: 0xD8BEF0 Offset: 0xD8B0F0 VA: 0x180D8BEF0
	|-StylePropertyAnimationSystem.Values<Scale>.ClearEventQueue
	|
	|-RVA: 0xD8C000 Offset: 0xD8B200 VA: 0x180D8C000
	|-StylePropertyAnimationSystem.Values<float>.ClearEventQueue
	|
	|-RVA: 0xD8C110 Offset: 0xD8B310 VA: 0x180D8C110
	|-StylePropertyAnimationSystem.Values<TextShadow>.ClearEventQueue
	|
	|-RVA: 0xD8C550 Offset: 0xD8B750 VA: 0x180D8C550
	|-StylePropertyAnimationSystem.Values<TransformOrigin>.ClearEventQueue
	|
	|-RVA: 0xD8C330 Offset: 0xD8B530 VA: 0x180D8C330
	|-StylePropertyAnimationSystem.Values<Translate>.ClearEventQueue
	|
	|-RVA: 0xD9FF90 Offset: 0xD9F190 VA: 0x180D9FF90
	|-StylePropertyAnimationSystem.Values<__Il2CppFullySharedGenericType>.ClearEventQueue
	*/

	// RVA: -1 Offset: -1
	private void QueueTransitionRunEvent(VisualElement ve, int runningIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD72F20 Offset: 0xD72120 VA: 0x180D72F20
	|-StylePropertyAnimationSystem.Values<Background>.QueueTransitionRunEvent
	|
	|-RVA: 0xD7ED10 Offset: 0xD7DF10 VA: 0x180D7ED10
	|-StylePropertyAnimationSystem.Values<BackgroundPosition>.QueueTransitionRunEvent
	|
	|-RVA: 0xD7EAB0 Offset: 0xD7DCB0 VA: 0x180D7EAB0
	|-StylePropertyAnimationSystem.Values<BackgroundRepeat>.QueueTransitionRunEvent
	|
	|-RVA: 0xD7E390 Offset: 0xD7D590 VA: 0x180D7E390
	|-StylePropertyAnimationSystem.Values<BackgroundSize>.QueueTransitionRunEvent
	|
	|-RVA: 0xD7E5F0 Offset: 0xD7D7F0 VA: 0x180D7E5F0
	|-StylePropertyAnimationSystem.Values<Color>.QueueTransitionRunEvent
	|
	|-RVA: 0xD7DED0 Offset: 0xD7D0D0 VA: 0x180D7DED0
	|-StylePropertyAnimationSystem.Values<FontDefinition>.QueueTransitionRunEvent
	|
	|-RVA: 0xD7E130 Offset: 0xD7D330 VA: 0x180D7E130
	|-StylePropertyAnimationSystem.Values<int>.QueueTransitionRunEvent
	|
	|-RVA: 0xD7E850 Offset: 0xD7DA50 VA: 0x180D7E850
	|-StylePropertyAnimationSystem.Values<Length>.QueueTransitionRunEvent
	|
	|-RVA: 0xD90F70 Offset: 0xD90170 VA: 0x180D90F70
	|-StylePropertyAnimationSystem.Values<object>.QueueTransitionRunEvent
	|
	|-RVA: 0xD91DB0 Offset: 0xD90FB0 VA: 0x180D91DB0
	|-StylePropertyAnimationSystem.Values<Rotate>.QueueTransitionRunEvent
	|
	|-RVA: 0xD91B50 Offset: 0xD90D50 VA: 0x180D91B50
	|-StylePropertyAnimationSystem.Values<Scale>.QueueTransitionRunEvent
	|
	|-RVA: 0xD918F0 Offset: 0xD90AF0 VA: 0x180D918F0
	|-StylePropertyAnimationSystem.Values<float>.QueueTransitionRunEvent
	|
	|-RVA: 0xD91430 Offset: 0xD90630 VA: 0x180D91430
	|-StylePropertyAnimationSystem.Values<TextShadow>.QueueTransitionRunEvent
	|
	|-RVA: 0xD911D0 Offset: 0xD903D0 VA: 0x180D911D0
	|-StylePropertyAnimationSystem.Values<TransformOrigin>.QueueTransitionRunEvent
	|
	|-RVA: 0xD91690 Offset: 0xD90890 VA: 0x180D91690
	|-StylePropertyAnimationSystem.Values<Translate>.QueueTransitionRunEvent
	|
	|-RVA: 0xDA0C50 Offset: 0xD9FE50 VA: 0x180DA0C50
	|-StylePropertyAnimationSystem.Values<__Il2CppFullySharedGenericType>.QueueTransitionRunEvent
	*/

	// RVA: -1 Offset: -1
	private void QueueTransitionStartEvent(VisualElement ve, int runningIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD73180 Offset: 0xD72380 VA: 0x180D73180
	|-StylePropertyAnimationSystem.Values<Background>.QueueTransitionStartEvent
	|
	|-RVA: 0xD7FB50 Offset: 0xD7ED50 VA: 0x180D7FB50
	|-StylePropertyAnimationSystem.Values<BackgroundPosition>.QueueTransitionStartEvent
	|
	|-RVA: 0xD7F8F0 Offset: 0xD7EAF0 VA: 0x180D7F8F0
	|-StylePropertyAnimationSystem.Values<BackgroundRepeat>.QueueTransitionStartEvent
	|
	|-RVA: 0xD7FDB0 Offset: 0xD7EFB0 VA: 0x180D7FDB0
	|-StylePropertyAnimationSystem.Values<BackgroundSize>.QueueTransitionStartEvent
	|
	|-RVA: 0xD7F430 Offset: 0xD7E630 VA: 0x180D7F430
	|-StylePropertyAnimationSystem.Values<Color>.QueueTransitionStartEvent
	|
	|-RVA: 0xD7F690 Offset: 0xD7E890 VA: 0x180D7F690
	|-StylePropertyAnimationSystem.Values<FontDefinition>.QueueTransitionStartEvent
	|
	|-RVA: 0xD7F1D0 Offset: 0xD7E3D0 VA: 0x180D7F1D0
	|-StylePropertyAnimationSystem.Values<int>.QueueTransitionStartEvent
	|
	|-RVA: 0xD7EF70 Offset: 0xD7E170 VA: 0x180D7EF70
	|-StylePropertyAnimationSystem.Values<Length>.QueueTransitionStartEvent
	|
	|-RVA: 0xD92E50 Offset: 0xD92050 VA: 0x180D92E50
	|-StylePropertyAnimationSystem.Values<object>.QueueTransitionStartEvent
	|
	|-RVA: 0xD92270 Offset: 0xD91470 VA: 0x180D92270
	|-StylePropertyAnimationSystem.Values<Rotate>.QueueTransitionStartEvent
	|
	|-RVA: 0xD924D0 Offset: 0xD916D0 VA: 0x180D924D0
	|-StylePropertyAnimationSystem.Values<Scale>.QueueTransitionStartEvent
	|
	|-RVA: 0xD92990 Offset: 0xD91B90 VA: 0x180D92990
	|-StylePropertyAnimationSystem.Values<float>.QueueTransitionStartEvent
	|
	|-RVA: 0xD92010 Offset: 0xD91210 VA: 0x180D92010
	|-StylePropertyAnimationSystem.Values<TextShadow>.QueueTransitionStartEvent
	|
	|-RVA: 0xD92BF0 Offset: 0xD91DF0 VA: 0x180D92BF0
	|-StylePropertyAnimationSystem.Values<TransformOrigin>.QueueTransitionStartEvent
	|
	|-RVA: 0xD92730 Offset: 0xD91930 VA: 0x180D92730
	|-StylePropertyAnimationSystem.Values<Translate>.QueueTransitionStartEvent
	|
	|-RVA: 0xDA0EB0 Offset: 0xDA00B0 VA: 0x180DA0EB0
	|-StylePropertyAnimationSystem.Values<__Il2CppFullySharedGenericType>.QueueTransitionStartEvent
	*/

	// RVA: -1 Offset: -1
	private void QueueTransitionEndEvent(VisualElement ve, int runningIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD72CD0 Offset: 0xD71ED0 VA: 0x180D72CD0
	|-StylePropertyAnimationSystem.Values<Background>.QueueTransitionEndEvent
	|
	|-RVA: 0xD7D590 Offset: 0xD7C790 VA: 0x180D7D590
	|-StylePropertyAnimationSystem.Values<BackgroundPosition>.QueueTransitionEndEvent
	|
	|-RVA: 0xD7CEA0 Offset: 0xD7C0A0 VA: 0x180D7CEA0
	|-StylePropertyAnimationSystem.Values<BackgroundRepeat>.QueueTransitionEndEvent
	|
	|-RVA: 0xD7DA30 Offset: 0xD7CC30 VA: 0x180D7DA30
	|-StylePropertyAnimationSystem.Values<BackgroundSize>.QueueTransitionEndEvent
	|
	|-RVA: 0xD7D0F0 Offset: 0xD7C2F0 VA: 0x180D7D0F0
	|-StylePropertyAnimationSystem.Values<Color>.QueueTransitionEndEvent
	|
	|-RVA: 0xD7DC80 Offset: 0xD7CE80 VA: 0x180D7DC80
	|-StylePropertyAnimationSystem.Values<FontDefinition>.QueueTransitionEndEvent
	|
	|-RVA: 0xD7D7E0 Offset: 0xD7C9E0 VA: 0x180D7D7E0
	|-StylePropertyAnimationSystem.Values<int>.QueueTransitionEndEvent
	|
	|-RVA: 0xD7D340 Offset: 0xD7C540 VA: 0x180D7D340
	|-StylePropertyAnimationSystem.Values<Length>.QueueTransitionEndEvent
	|
	|-RVA: 0xD90190 Offset: 0xD8F390 VA: 0x180D90190
	|-StylePropertyAnimationSystem.Values<object>.QueueTransitionEndEvent
	|
	|-RVA: 0xD90630 Offset: 0xD8F830 VA: 0x180D90630
	|-StylePropertyAnimationSystem.Values<Rotate>.QueueTransitionEndEvent
	|
	|-RVA: 0xD8FF40 Offset: 0xD8F140 VA: 0x180D8FF40
	|-StylePropertyAnimationSystem.Values<Scale>.QueueTransitionEndEvent
	|
	|-RVA: 0xD90D20 Offset: 0xD8FF20 VA: 0x180D90D20
	|-StylePropertyAnimationSystem.Values<float>.QueueTransitionEndEvent
	|
	|-RVA: 0xD90880 Offset: 0xD8FA80 VA: 0x180D90880
	|-StylePropertyAnimationSystem.Values<TextShadow>.QueueTransitionEndEvent
	|
	|-RVA: 0xD903E0 Offset: 0xD8F5E0 VA: 0x180D903E0
	|-StylePropertyAnimationSystem.Values<TransformOrigin>.QueueTransitionEndEvent
	|
	|-RVA: 0xD90AD0 Offset: 0xD8FCD0 VA: 0x180D90AD0
	|-StylePropertyAnimationSystem.Values<Translate>.QueueTransitionEndEvent
	|
	|-RVA: 0xDA0A00 Offset: 0xD9FC00 VA: 0x180DA0A00
	|-StylePropertyAnimationSystem.Values<__Il2CppFullySharedGenericType>.QueueTransitionEndEvent
	*/

	// RVA: -1 Offset: -1
	private void QueueTransitionCancelEvent(VisualElement ve, int runningIndex, long panelElapsedMs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD729C0 Offset: 0xD71BC0 VA: 0x180D729C0
	|-StylePropertyAnimationSystem.Values<Background>.QueueTransitionCancelEvent
	|
	|-RVA: 0xD7C880 Offset: 0xD7BA80 VA: 0x180D7C880
	|-StylePropertyAnimationSystem.Values<BackgroundPosition>.QueueTransitionCancelEvent
	|
	|-RVA: 0xD7C260 Offset: 0xD7B460 VA: 0x180D7C260
	|-StylePropertyAnimationSystem.Values<BackgroundRepeat>.QueueTransitionCancelEvent
	|
	|-RVA: 0xD7C570 Offset: 0xD7B770 VA: 0x180D7C570
	|-StylePropertyAnimationSystem.Values<BackgroundSize>.QueueTransitionCancelEvent
	|
	|-RVA: 0xD7CB90 Offset: 0xD7BD90 VA: 0x180D7CB90
	|-StylePropertyAnimationSystem.Values<Color>.QueueTransitionCancelEvent
	|
	|-RVA: 0xD7B930 Offset: 0xD7AB30 VA: 0x180D7B930
	|-StylePropertyAnimationSystem.Values<FontDefinition>.QueueTransitionCancelEvent
	|
	|-RVA: 0xD7BF50 Offset: 0xD7B150 VA: 0x180D7BF50
	|-StylePropertyAnimationSystem.Values<int>.QueueTransitionCancelEvent
	|
	|-RVA: 0xD7BC40 Offset: 0xD7AE40 VA: 0x180D7BC40
	|-StylePropertyAnimationSystem.Values<Length>.QueueTransitionCancelEvent
	|
	|-RVA: 0xD8F920 Offset: 0xD8EB20 VA: 0x180D8F920
	|-StylePropertyAnimationSystem.Values<object>.QueueTransitionCancelEvent
	|
	|-RVA: 0xD8F300 Offset: 0xD8E500 VA: 0x180D8F300
	|-StylePropertyAnimationSystem.Values<Rotate>.QueueTransitionCancelEvent
	|
	|-RVA: 0xD8EFF0 Offset: 0xD8E1F0 VA: 0x180D8EFF0
	|-StylePropertyAnimationSystem.Values<Scale>.QueueTransitionCancelEvent
	|
	|-RVA: 0xD8FC30 Offset: 0xD8EE30 VA: 0x180D8FC30
	|-StylePropertyAnimationSystem.Values<float>.QueueTransitionCancelEvent
	|
	|-RVA: 0xD8ECE0 Offset: 0xD8DEE0 VA: 0x180D8ECE0
	|-StylePropertyAnimationSystem.Values<TextShadow>.QueueTransitionCancelEvent
	|
	|-RVA: 0xD8F610 Offset: 0xD8E810 VA: 0x180D8F610
	|-StylePropertyAnimationSystem.Values<TransformOrigin>.QueueTransitionCancelEvent
	|
	|-RVA: 0xD8E9D0 Offset: 0xD8DBD0 VA: 0x180D8E9D0
	|-StylePropertyAnimationSystem.Values<Translate>.QueueTransitionCancelEvent
	|
	|-RVA: 0xDA06F0 Offset: 0xD9F8F0 VA: 0x180DA06F0
	|-StylePropertyAnimationSystem.Values<__Il2CppFullySharedGenericType>.QueueTransitionCancelEvent
	*/

	// RVA: -1 Offset: -1
	private void SendTransitionCancelEvent(VisualElement ve, int runningIndex, long panelElapsedMs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD733E0 Offset: 0xD725E0 VA: 0x180D733E0
	|-StylePropertyAnimationSystem.Values<Background>.SendTransitionCancelEvent
	|
	|-RVA: 0xD80810 Offset: 0xD7FA10 VA: 0x180D80810
	|-StylePropertyAnimationSystem.Values<BackgroundPosition>.SendTransitionCancelEvent
	|
	|-RVA: 0xD80610 Offset: 0xD7F810 VA: 0x180D80610
	|-StylePropertyAnimationSystem.Values<BackgroundRepeat>.SendTransitionCancelEvent
	|
	|-RVA: 0xD80010 Offset: 0xD7F210 VA: 0x180D80010
	|-StylePropertyAnimationSystem.Values<BackgroundSize>.SendTransitionCancelEvent
	|
	|-RVA: 0xD80A10 Offset: 0xD7FC10 VA: 0x180D80A10
	|-StylePropertyAnimationSystem.Values<Color>.SendTransitionCancelEvent
	|
	|-RVA: 0xD80410 Offset: 0xD7F610 VA: 0x180D80410
	|-StylePropertyAnimationSystem.Values<FontDefinition>.SendTransitionCancelEvent
	|
	|-RVA: 0xD80210 Offset: 0xD7F410 VA: 0x180D80210
	|-StylePropertyAnimationSystem.Values<int>.SendTransitionCancelEvent
	|
	|-RVA: 0xD80C10 Offset: 0xD7FE10 VA: 0x180D80C10
	|-StylePropertyAnimationSystem.Values<Length>.SendTransitionCancelEvent
	|
	|-RVA: 0xD932B0 Offset: 0xD924B0 VA: 0x180D932B0
	|-StylePropertyAnimationSystem.Values<object>.SendTransitionCancelEvent
	|
	|-RVA: 0xD930B0 Offset: 0xD922B0 VA: 0x180D930B0
	|-StylePropertyAnimationSystem.Values<Rotate>.SendTransitionCancelEvent
	|
	|-RVA: 0xD93AB0 Offset: 0xD92CB0 VA: 0x180D93AB0
	|-StylePropertyAnimationSystem.Values<Scale>.SendTransitionCancelEvent
	|
	|-RVA: 0xD936B0 Offset: 0xD928B0 VA: 0x180D936B0
	|-StylePropertyAnimationSystem.Values<float>.SendTransitionCancelEvent
	|
	|-RVA: 0xD934B0 Offset: 0xD926B0 VA: 0x180D934B0
	|-StylePropertyAnimationSystem.Values<TextShadow>.SendTransitionCancelEvent
	|
	|-RVA: 0xD938B0 Offset: 0xD92AB0 VA: 0x180D938B0
	|-StylePropertyAnimationSystem.Values<TransformOrigin>.SendTransitionCancelEvent
	|
	|-RVA: 0xD93CB0 Offset: 0xD92EB0 VA: 0x180D93CB0
	|-StylePropertyAnimationSystem.Values<Translate>.SendTransitionCancelEvent
	|
	|-RVA: 0xDA1110 Offset: 0xDA0310 VA: 0x180DA1110
	|-StylePropertyAnimationSystem.Values<__Il2CppFullySharedGenericType>.SendTransitionCancelEvent
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public sealed override void CancelAllAnimations() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD71B80 Offset: 0xD70D80 VA: 0x180D71B80
	|-StylePropertyAnimationSystem.Values<Background>.CancelAllAnimations
	|
	|-RVA: 0xD758B0 Offset: 0xD74AB0 VA: 0x180D758B0
	|-StylePropertyAnimationSystem.Values<BackgroundPosition>.CancelAllAnimations
	|
	|-RVA: 0xD768E0 Offset: 0xD75AE0 VA: 0x180D768E0
	|-StylePropertyAnimationSystem.Values<BackgroundRepeat>.CancelAllAnimations
	|
	|-RVA: 0xD770F0 Offset: 0xD762F0 VA: 0x180D770F0
	|-StylePropertyAnimationSystem.Values<BackgroundSize>.CancelAllAnimations
	|
	|-RVA: 0xD753C0 Offset: 0xD745C0 VA: 0x180D753C0
	|-StylePropertyAnimationSystem.Values<Color>.CancelAllAnimations
	|
	|-RVA: 0xD74BB0 Offset: 0xD73DB0 VA: 0x180D74BB0
	|-StylePropertyAnimationSystem.Values<FontDefinition>.CancelAllAnimations
	|
	|-RVA: 0xD746C0 Offset: 0xD738C0 VA: 0x180D746C0
	|-StylePropertyAnimationSystem.Values<int>.CancelAllAnimations
	|
	|-RVA: 0xD760D0 Offset: 0xD752D0 VA: 0x180D760D0
	|-StylePropertyAnimationSystem.Values<Length>.CancelAllAnimations
	|
	|-RVA: 0xD8A8D0 Offset: 0xD89AD0 VA: 0x180D8A8D0
	|-StylePropertyAnimationSystem.Values<object>.CancelAllAnimations
	|
	|-RVA: 0xD88F20 Offset: 0xD88120 VA: 0x180D88F20
	|-StylePropertyAnimationSystem.Values<Rotate>.CancelAllAnimations
	|
	|-RVA: 0xD87800 Offset: 0xD86A00 VA: 0x180D87800
	|-StylePropertyAnimationSystem.Values<Scale>.CancelAllAnimations
	|
	|-RVA: 0xD88200 Offset: 0xD87400 VA: 0x180D88200
	|-StylePropertyAnimationSystem.Values<float>.CancelAllAnimations
	|
	|-RVA: 0xD886F0 Offset: 0xD878F0 VA: 0x180D886F0
	|-StylePropertyAnimationSystem.Values<TextShadow>.CancelAllAnimations
	|
	|-RVA: 0xD8A3D0 Offset: 0xD895D0 VA: 0x180D8A3D0
	|-StylePropertyAnimationSystem.Values<TransformOrigin>.CancelAllAnimations
	|
	|-RVA: 0xD87CF0 Offset: 0xD86EF0 VA: 0x180D87CF0
	|-StylePropertyAnimationSystem.Values<Translate>.CancelAllAnimations
	|
	|-RVA: 0xD9F5C0 Offset: 0xD9E7C0 VA: 0x180D9F5C0
	|-StylePropertyAnimationSystem.Values<__Il2CppFullySharedGenericType>.CancelAllAnimations
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public sealed override void CancelAllAnimations(VisualElement ve) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD71860 Offset: 0xD70A60 VA: 0x180D71860
	|-StylePropertyAnimationSystem.Values<Background>.CancelAllAnimations
	|
	|-RVA: 0xD750A0 Offset: 0xD742A0 VA: 0x180D750A0
	|-StylePropertyAnimationSystem.Values<BackgroundPosition>.CancelAllAnimations
	|
	|-RVA: 0xD76DD0 Offset: 0xD75FD0 VA: 0x180D76DD0
	|-StylePropertyAnimationSystem.Values<BackgroundRepeat>.CancelAllAnimations
	|
	|-RVA: 0xD77910 Offset: 0xD76B10 VA: 0x180D77910
	|-StylePropertyAnimationSystem.Values<BackgroundSize>.CancelAllAnimations
	|
	|-RVA: 0xD765C0 Offset: 0xD757C0 VA: 0x180D765C0
	|-StylePropertyAnimationSystem.Values<Color>.CancelAllAnimations
	|
	|-RVA: 0xD775F0 Offset: 0xD767F0 VA: 0x180D775F0
	|-StylePropertyAnimationSystem.Values<FontDefinition>.CancelAllAnimations
	|
	|-RVA: 0xD77C30 Offset: 0xD76E30 VA: 0x180D77C30
	|-StylePropertyAnimationSystem.Values<int>.CancelAllAnimations
	|
	|-RVA: 0xD75DB0 Offset: 0xD74FB0 VA: 0x180D75DB0
	|-StylePropertyAnimationSystem.Values<Length>.CancelAllAnimations
	|
	|-RVA: 0xD89430 Offset: 0xD88630 VA: 0x180D89430
	|-StylePropertyAnimationSystem.Values<object>.CancelAllAnimations
	|
	|-RVA: 0xD8ADC0 Offset: 0xD89FC0 VA: 0x180D8ADC0
	|-StylePropertyAnimationSystem.Values<Rotate>.CancelAllAnimations
	|
	|-RVA: 0xD88C00 Offset: 0xD87E00 VA: 0x180D88C00
	|-StylePropertyAnimationSystem.Values<Scale>.CancelAllAnimations
	|
	|-RVA: 0xD8A0B0 Offset: 0xD892B0 VA: 0x180D8A0B0
	|-StylePropertyAnimationSystem.Values<float>.CancelAllAnimations
	|
	|-RVA: 0xD89750 Offset: 0xD88950 VA: 0x180D89750
	|-StylePropertyAnimationSystem.Values<TextShadow>.CancelAllAnimations
	|
	|-RVA: 0xD89D90 Offset: 0xD88F90 VA: 0x180D89D90
	|-StylePropertyAnimationSystem.Values<TransformOrigin>.CancelAllAnimations
	|
	|-RVA: 0xD89A70 Offset: 0xD88C70 VA: 0x180D89A70
	|-StylePropertyAnimationSystem.Values<Translate>.CancelAllAnimations
	|
	|-RVA: 0xD9FA80 Offset: 0xD9EC80 VA: 0x180D9FA80
	|-StylePropertyAnimationSystem.Values<__Il2CppFullySharedGenericType>.CancelAllAnimations
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public sealed override void CancelAnimation(VisualElement ve, StylePropertyId id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD72080 Offset: 0xD71280 VA: 0x180D72080
	|-StylePropertyAnimationSystem.Values<Background>.CancelAnimation
	|
	|-RVA: 0xD78560 Offset: 0xD77760 VA: 0x180D78560
	|-StylePropertyAnimationSystem.Values<BackgroundPosition>.CancelAnimation
	|
	|-RVA: 0xD78B70 Offset: 0xD77D70 VA: 0x180D78B70
	|-StylePropertyAnimationSystem.Values<BackgroundRepeat>.CancelAnimation
	|
	|-RVA: 0xD78150 Offset: 0xD77350 VA: 0x180D78150
	|-StylePropertyAnimationSystem.Values<BackgroundSize>.CancelAnimation
	|
	|-RVA: 0xD77F50 Offset: 0xD77150 VA: 0x180D77F50
	|-StylePropertyAnimationSystem.Values<Color>.CancelAnimation
	|
	|-RVA: 0xD78360 Offset: 0xD77560 VA: 0x180D78360
	|-StylePropertyAnimationSystem.Values<FontDefinition>.CancelAnimation
	|
	|-RVA: 0xD78770 Offset: 0xD77970 VA: 0x180D78770
	|-StylePropertyAnimationSystem.Values<int>.CancelAnimation
	|
	|-RVA: 0xD78970 Offset: 0xD77B70 VA: 0x180D78970
	|-StylePropertyAnimationSystem.Values<Length>.CancelAnimation
	|
	|-RVA: 0xD8B4F0 Offset: 0xD8A6F0 VA: 0x180D8B4F0
	|-StylePropertyAnimationSystem.Values<object>.CancelAnimation
	|
	|-RVA: 0xD8B6F0 Offset: 0xD8A8F0 VA: 0x180D8B6F0
	|-StylePropertyAnimationSystem.Values<Rotate>.CancelAnimation
	|
	|-RVA: 0xD8B0E0 Offset: 0xD8A2E0 VA: 0x180D8B0E0
	|-StylePropertyAnimationSystem.Values<Scale>.CancelAnimation
	|
	|-RVA: 0xD8BAE0 Offset: 0xD8ACE0 VA: 0x180D8BAE0
	|-StylePropertyAnimationSystem.Values<float>.CancelAnimation
	|
	|-RVA: 0xD8B900 Offset: 0xD8AB00 VA: 0x180D8B900
	|-StylePropertyAnimationSystem.Values<TextShadow>.CancelAnimation
	|
	|-RVA: 0xD8B2E0 Offset: 0xD8A4E0 VA: 0x180D8B2E0
	|-StylePropertyAnimationSystem.Values<TransformOrigin>.CancelAnimation
	|
	|-RVA: 0xD8BCE0 Offset: 0xD8AEE0 VA: 0x180D8BCE0
	|-StylePropertyAnimationSystem.Values<Translate>.CancelAnimation
	|
	|-RVA: 0xD9FDB0 Offset: 0xD9EFB0 VA: 0x180D9FDB0
	|-StylePropertyAnimationSystem.Values<__Il2CppFullySharedGenericType>.CancelAnimation
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public sealed override void UpdateAnimation(VisualElement ve, StylePropertyId id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD74010 Offset: 0xD73210 VA: 0x180D74010
	|-StylePropertyAnimationSystem.Values<Background>.UpdateAnimation
	|
	|-RVA: 0xD84D30 Offset: 0xD83F30 VA: 0x180D84D30
	|-StylePropertyAnimationSystem.Values<BackgroundPosition>.UpdateAnimation
	|
	|-RVA: 0xD84A90 Offset: 0xD83C90 VA: 0x180D84A90
	|-StylePropertyAnimationSystem.Values<BackgroundRepeat>.UpdateAnimation
	|
	|-RVA: 0xD84B00 Offset: 0xD83D00 VA: 0x180D84B00
	|-StylePropertyAnimationSystem.Values<BackgroundSize>.UpdateAnimation
	|
	|-RVA: 0xD84BE0 Offset: 0xD83DE0 VA: 0x180D84BE0
	|-StylePropertyAnimationSystem.Values<Color>.UpdateAnimation
	|
	|-RVA: 0xD84B70 Offset: 0xD83D70 VA: 0x180D84B70
	|-StylePropertyAnimationSystem.Values<FontDefinition>.UpdateAnimation
	|
	|-RVA: 0xD84CC0 Offset: 0xD83EC0 VA: 0x180D84CC0
	|-StylePropertyAnimationSystem.Values<int>.UpdateAnimation
	|
	|-RVA: 0xD84C50 Offset: 0xD83E50 VA: 0x180D84C50
	|-StylePropertyAnimationSystem.Values<Length>.UpdateAnimation
	|
	|-RVA: 0xD980E0 Offset: 0xD972E0 VA: 0x180D980E0
	|-StylePropertyAnimationSystem.Values<object>.UpdateAnimation
	|
	|-RVA: 0xD982A0 Offset: 0xD974A0 VA: 0x180D982A0
	|-StylePropertyAnimationSystem.Values<Rotate>.UpdateAnimation
	|
	|-RVA: 0xD98150 Offset: 0xD97350 VA: 0x180D98150
	|-StylePropertyAnimationSystem.Values<Scale>.UpdateAnimation
	|
	|-RVA: 0xD98070 Offset: 0xD97270 VA: 0x180D98070
	|-StylePropertyAnimationSystem.Values<float>.UpdateAnimation
	|
	|-RVA: 0xD98230 Offset: 0xD97430 VA: 0x180D98230
	|-StylePropertyAnimationSystem.Values<TextShadow>.UpdateAnimation
	|
	|-RVA: 0xD981C0 Offset: 0xD973C0 VA: 0x180D981C0
	|-StylePropertyAnimationSystem.Values<TransformOrigin>.UpdateAnimation
	|
	|-RVA: 0xD98000 Offset: 0xD97200 VA: 0x180D98000
	|-StylePropertyAnimationSystem.Values<Translate>.UpdateAnimation
	|
	|-RVA: 0xDA24B0 Offset: 0xDA16B0 VA: 0x180DA24B0
	|-StylePropertyAnimationSystem.Values<__Il2CppFullySharedGenericType>.UpdateAnimation
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public sealed override void GetAllAnimations(VisualElement ve, List<StylePropertyId> outPropertyIds) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD724D0 Offset: 0xD716D0 VA: 0x180D724D0
	|-StylePropertyAnimationSystem.Values<Background>.GetAllAnimations
	|
	|-RVA: 0xD79940 Offset: 0xD78B40 VA: 0x180D79940
	|-StylePropertyAnimationSystem.Values<BackgroundPosition>.GetAllAnimations
	|
	|-RVA: 0xD79710 Offset: 0xD78910 VA: 0x180D79710
	|-StylePropertyAnimationSystem.Values<BackgroundRepeat>.GetAllAnimations
	|
	|-RVA: 0xD797F0 Offset: 0xD789F0 VA: 0x180D797F0
	|-StylePropertyAnimationSystem.Values<BackgroundSize>.GetAllAnimations
	|
	|-RVA: 0xD79780 Offset: 0xD78980 VA: 0x180D79780
	|-StylePropertyAnimationSystem.Values<Color>.GetAllAnimations
	|
	|-RVA: 0xD798D0 Offset: 0xD78AD0 VA: 0x180D798D0
	|-StylePropertyAnimationSystem.Values<FontDefinition>.GetAllAnimations
	|
	|-RVA: 0xD79860 Offset: 0xD78A60 VA: 0x180D79860
	|-StylePropertyAnimationSystem.Values<int>.GetAllAnimations
	|
	|-RVA: 0xD796A0 Offset: 0xD788A0 VA: 0x180D796A0
	|-StylePropertyAnimationSystem.Values<Length>.GetAllAnimations
	|
	|-RVA: 0xD8C740 Offset: 0xD8B940 VA: 0x180D8C740
	|-StylePropertyAnimationSystem.Values<object>.GetAllAnimations
	|
	|-RVA: 0xD8C970 Offset: 0xD8BB70 VA: 0x180D8C970
	|-StylePropertyAnimationSystem.Values<Rotate>.GetAllAnimations
	|
	|-RVA: 0xD8C7B0 Offset: 0xD8B9B0 VA: 0x180D8C7B0
	|-StylePropertyAnimationSystem.Values<Scale>.GetAllAnimations
	|
	|-RVA: 0xD8C900 Offset: 0xD8BB00 VA: 0x180D8C900
	|-StylePropertyAnimationSystem.Values<float>.GetAllAnimations
	|
	|-RVA: 0xD8C9E0 Offset: 0xD8BBE0 VA: 0x180D8C9E0
	|-StylePropertyAnimationSystem.Values<TextShadow>.GetAllAnimations
	|
	|-RVA: 0xD8C890 Offset: 0xD8BA90 VA: 0x180D8C890
	|-StylePropertyAnimationSystem.Values<TransformOrigin>.GetAllAnimations
	|
	|-RVA: 0xD8C820 Offset: 0xD8BA20 VA: 0x180D8C820
	|-StylePropertyAnimationSystem.Values<Translate>.GetAllAnimations
	|
	|-RVA: 0xDA01D0 Offset: 0xD9F3D0 VA: 0x180DA01D0
	|-StylePropertyAnimationSystem.Values<__Il2CppFullySharedGenericType>.GetAllAnimations
	*/

	// RVA: -1 Offset: -1
	private float ComputeReversingShorteningFactor(int oldIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD723F0 Offset: 0xD715F0 VA: 0x180D723F0
	|-StylePropertyAnimationSystem.Values<Background>.ComputeReversingShorteningFactor
	|-StylePropertyAnimationSystem.Values<BackgroundPosition>.ComputeReversingShorteningFactor
	|-StylePropertyAnimationSystem.Values<BackgroundRepeat>.ComputeReversingShorteningFactor
	|-StylePropertyAnimationSystem.Values<BackgroundSize>.ComputeReversingShorteningFactor
	|-StylePropertyAnimationSystem.Values<Color>.ComputeReversingShorteningFactor
	|-StylePropertyAnimationSystem.Values<FontDefinition>.ComputeReversingShorteningFactor
	|-StylePropertyAnimationSystem.Values<int>.ComputeReversingShorteningFactor
	|-StylePropertyAnimationSystem.Values<Length>.ComputeReversingShorteningFactor
	|-StylePropertyAnimationSystem.Values<object>.ComputeReversingShorteningFactor
	|-StylePropertyAnimationSystem.Values<Rotate>.ComputeReversingShorteningFactor
	|-StylePropertyAnimationSystem.Values<Scale>.ComputeReversingShorteningFactor
	|-StylePropertyAnimationSystem.Values<float>.ComputeReversingShorteningFactor
	|-StylePropertyAnimationSystem.Values<TextShadow>.ComputeReversingShorteningFactor
	|-StylePropertyAnimationSystem.Values<TransformOrigin>.ComputeReversingShorteningFactor
	|-StylePropertyAnimationSystem.Values<Translate>.ComputeReversingShorteningFactor
	|-StylePropertyAnimationSystem.Values<__Il2CppFullySharedGenericType>.ComputeReversingShorteningFactor
	*/

	// RVA: -1 Offset: -1
	private int ComputeReversingDuration(int newTransitionDurationMs, float newReversingShorteningFactor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD723D0 Offset: 0xD715D0 VA: 0x180D723D0
	|-StylePropertyAnimationSystem.Values<Background>.ComputeReversingDuration
	|-StylePropertyAnimationSystem.Values<BackgroundPosition>.ComputeReversingDuration
	|-StylePropertyAnimationSystem.Values<BackgroundRepeat>.ComputeReversingDuration
	|-StylePropertyAnimationSystem.Values<BackgroundSize>.ComputeReversingDuration
	|-StylePropertyAnimationSystem.Values<Color>.ComputeReversingDuration
	|-StylePropertyAnimationSystem.Values<FontDefinition>.ComputeReversingDuration
	|-StylePropertyAnimationSystem.Values<int>.ComputeReversingDuration
	|-StylePropertyAnimationSystem.Values<Length>.ComputeReversingDuration
	|-StylePropertyAnimationSystem.Values<object>.ComputeReversingDuration
	|-StylePropertyAnimationSystem.Values<Rotate>.ComputeReversingDuration
	|-StylePropertyAnimationSystem.Values<Scale>.ComputeReversingDuration
	|-StylePropertyAnimationSystem.Values<float>.ComputeReversingDuration
	|-StylePropertyAnimationSystem.Values<TextShadow>.ComputeReversingDuration
	|-StylePropertyAnimationSystem.Values<TransformOrigin>.ComputeReversingDuration
	|-StylePropertyAnimationSystem.Values<Translate>.ComputeReversingDuration
	|-StylePropertyAnimationSystem.Values<__Il2CppFullySharedGenericType>.ComputeReversingDuration
	*/

	// RVA: -1 Offset: -1
	private int ComputeReversingDelay(int delayMs, float newReversingShorteningFactor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD723A0 Offset: 0xD715A0 VA: 0x180D723A0
	|-StylePropertyAnimationSystem.Values<Background>.ComputeReversingDelay
	|-StylePropertyAnimationSystem.Values<BackgroundPosition>.ComputeReversingDelay
	|-StylePropertyAnimationSystem.Values<BackgroundRepeat>.ComputeReversingDelay
	|-StylePropertyAnimationSystem.Values<BackgroundSize>.ComputeReversingDelay
	|-StylePropertyAnimationSystem.Values<Color>.ComputeReversingDelay
	|-StylePropertyAnimationSystem.Values<FontDefinition>.ComputeReversingDelay
	|-StylePropertyAnimationSystem.Values<int>.ComputeReversingDelay
	|-StylePropertyAnimationSystem.Values<Length>.ComputeReversingDelay
	|-StylePropertyAnimationSystem.Values<object>.ComputeReversingDelay
	|-StylePropertyAnimationSystem.Values<Rotate>.ComputeReversingDelay
	|-StylePropertyAnimationSystem.Values<Scale>.ComputeReversingDelay
	|-StylePropertyAnimationSystem.Values<float>.ComputeReversingDelay
	|-StylePropertyAnimationSystem.Values<TextShadow>.ComputeReversingDelay
	|-StylePropertyAnimationSystem.Values<TransformOrigin>.ComputeReversingDelay
	|-StylePropertyAnimationSystem.Values<Translate>.ComputeReversingDelay
	|-StylePropertyAnimationSystem.Values<__Il2CppFullySharedGenericType>.ComputeReversingDelay
	*/

	// RVA: -1 Offset: -1
	public bool StartTransition(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, Func<float, float> easingCurve, long currentTimeMs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD735C0 Offset: 0xD727C0 VA: 0x180D735C0
	|-StylePropertyAnimationSystem.Values<Background>.StartTransition
	|
	|-RVA: 0xD81DC0 Offset: 0xD80FC0 VA: 0x180D81DC0
	|-StylePropertyAnimationSystem.Values<BackgroundPosition>.StartTransition
	|
	|-RVA: 0xD815D0 Offset: 0xD807D0 VA: 0x180D815D0
	|-StylePropertyAnimationSystem.Values<BackgroundRepeat>.StartTransition
	|
	|-RVA: 0xD82740 Offset: 0xD81940 VA: 0x180D82740
	|-StylePropertyAnimationSystem.Values<BackgroundSize>.StartTransition
	|
	|-RVA: 0xD841B0 Offset: 0xD833B0 VA: 0x180D841B0
	|-StylePropertyAnimationSystem.Values<Color>.StartTransition
	|
	|-RVA: 0xD830E0 Offset: 0xD822E0 VA: 0x180D830E0
	|-StylePropertyAnimationSystem.Values<FontDefinition>.StartTransition
	|
	|-RVA: 0xD80E10 Offset: 0xD80010 VA: 0x180D80E10
	|-StylePropertyAnimationSystem.Values<int>.StartTransition
	|
	|-RVA: 0xD839C0 Offset: 0xD82BC0 VA: 0x180D839C0
	|-StylePropertyAnimationSystem.Values<Length>.StartTransition
	|
	|-RVA: 0xD97810 Offset: 0xD96A10 VA: 0x180D97810
	|-StylePropertyAnimationSystem.Values<object>.StartTransition
	|
	|-RVA: 0xD95940 Offset: 0xD94B40 VA: 0x180D95940
	|-StylePropertyAnimationSystem.Values<Rotate>.StartTransition
	|
	|-RVA: 0xD93EB0 Offset: 0xD930B0 VA: 0x180D93EB0
	|-StylePropertyAnimationSystem.Values<Scale>.StartTransition
	|
	|-RVA: 0xD95130 Offset: 0xD94330 VA: 0x180D95130
	|-StylePropertyAnimationSystem.Values<float>.StartTransition
	|
	|-RVA: 0xD96350 Offset: 0xD95550 VA: 0x180D96350
	|-StylePropertyAnimationSystem.Values<TextShadow>.StartTransition
	|
	|-RVA: 0xD94790 Offset: 0xD93990 VA: 0x180D94790
	|-StylePropertyAnimationSystem.Values<TransformOrigin>.StartTransition
	|
	|-RVA: 0xD96E00 Offset: 0xD96000 VA: 0x180D96E00
	|-StylePropertyAnimationSystem.Values<Translate>.StartTransition
	|
	|-RVA: 0xDA12F0 Offset: 0xDA04F0 VA: 0x180DA12F0
	|-StylePropertyAnimationSystem.Values<__Il2CppFullySharedGenericType>.StartTransition
	*/

	// RVA: -1 Offset: -1
	private void ForceComputedStyleEndValue(int runningIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD72470 Offset: 0xD71670 VA: 0x180D72470
	|-StylePropertyAnimationSystem.Values<Background>.ForceComputedStyleEndValue
	|
	|-RVA: 0xD79640 Offset: 0xD78840 VA: 0x180D79640
	|-StylePropertyAnimationSystem.Values<BackgroundPosition>.ForceComputedStyleEndValue
	|
	|-RVA: 0xD794E0 Offset: 0xD786E0 VA: 0x180D794E0
	|-StylePropertyAnimationSystem.Values<BackgroundRepeat>.ForceComputedStyleEndValue
	|-StylePropertyAnimationSystem.Values<Length>.ForceComputedStyleEndValue
	|-StylePropertyAnimationSystem.Values<object>.ForceComputedStyleEndValue
	|
	|-RVA: 0xD795E0 Offset: 0xD787E0 VA: 0x180D795E0
	|-StylePropertyAnimationSystem.Values<BackgroundSize>.ForceComputedStyleEndValue
	|-StylePropertyAnimationSystem.Values<TransformOrigin>.ForceComputedStyleEndValue
	|
	|-RVA: 0xD79530 Offset: 0xD78730 VA: 0x180D79530
	|-StylePropertyAnimationSystem.Values<Color>.ForceComputedStyleEndValue
	|-StylePropertyAnimationSystem.Values<FontDefinition>.ForceComputedStyleEndValue
	|-StylePropertyAnimationSystem.Values<Scale>.ForceComputedStyleEndValue
	|
	|-RVA: 0xD79580 Offset: 0xD78780 VA: 0x180D79580
	|-StylePropertyAnimationSystem.Values<int>.ForceComputedStyleEndValue
	|-StylePropertyAnimationSystem.Values<float>.ForceComputedStyleEndValue
	|
	|-RVA: 0xD8C660 Offset: 0xD8B860 VA: 0x180D8C660
	|-StylePropertyAnimationSystem.Values<Rotate>.ForceComputedStyleEndValue
	|-StylePropertyAnimationSystem.Values<Translate>.ForceComputedStyleEndValue
	|
	|-RVA: 0xD8C6D0 Offset: 0xD8B8D0 VA: 0x180D8C6D0
	|-StylePropertyAnimationSystem.Values<TextShadow>.ForceComputedStyleEndValue
	|
	|-RVA: 0xDA00A0 Offset: 0xD9F2A0 VA: 0x180DA00A0
	|-StylePropertyAnimationSystem.Values<__Il2CppFullySharedGenericType>.ForceComputedStyleEndValue
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public sealed override void Update(long currentTimeMs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD74490 Offset: 0xD73690 VA: 0x180D74490
	|-StylePropertyAnimationSystem.Values<Background>.Update
	|
	|-RVA: 0xD86BE0 Offset: 0xD85DE0 VA: 0x180D86BE0
	|-StylePropertyAnimationSystem.Values<BackgroundPosition>.Update
	|
	|-RVA: 0xD86920 Offset: 0xD85B20 VA: 0x180D86920
	|-StylePropertyAnimationSystem.Values<BackgroundRepeat>.Update
	|
	|-RVA: 0xD869D0 Offset: 0xD85BD0 VA: 0x180D869D0
	|-StylePropertyAnimationSystem.Values<BackgroundSize>.Update
	|
	|-RVA: 0xD86C90 Offset: 0xD85E90 VA: 0x180D86C90
	|-StylePropertyAnimationSystem.Values<Color>.Update
	|
	|-RVA: 0xD86A80 Offset: 0xD85C80 VA: 0x180D86A80
	|-StylePropertyAnimationSystem.Values<FontDefinition>.Update
	|
	|-RVA: 0xD86B30 Offset: 0xD85D30 VA: 0x180D86B30
	|-StylePropertyAnimationSystem.Values<int>.Update
	|
	|-RVA: 0xD86D40 Offset: 0xD85F40 VA: 0x180D86D40
	|-StylePropertyAnimationSystem.Values<Length>.Update
	|
	|-RVA: 0xD99F90 Offset: 0xD99190 VA: 0x180D99F90
	|-StylePropertyAnimationSystem.Values<object>.Update
	|
	|-RVA: 0xD99EE0 Offset: 0xD990E0 VA: 0x180D99EE0
	|-StylePropertyAnimationSystem.Values<Rotate>.Update
	|
	|-RVA: 0xD9A0F0 Offset: 0xD992F0 VA: 0x180D9A0F0
	|-StylePropertyAnimationSystem.Values<Scale>.Update
	|
	|-RVA: 0xD9A300 Offset: 0xD99500 VA: 0x180D9A300
	|-StylePropertyAnimationSystem.Values<float>.Update
	|
	|-RVA: 0xD9A250 Offset: 0xD99450 VA: 0x180D9A250
	|-StylePropertyAnimationSystem.Values<TextShadow>.Update
	|
	|-RVA: 0xD9A040 Offset: 0xD99240 VA: 0x180D9A040
	|-StylePropertyAnimationSystem.Values<TransformOrigin>.Update
	|
	|-RVA: 0xD9A1A0 Offset: 0xD993A0 VA: 0x180D9A1A0
	|-StylePropertyAnimationSystem.Values<Translate>.Update
	|
	|-RVA: 0xDA2A30 Offset: 0xDA1C30 VA: 0x180DA2A30
	|-StylePropertyAnimationSystem.Values<__Il2CppFullySharedGenericType>.Update
	*/

	// RVA: -1 Offset: -1
	private void ProcessEventQueue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD72540 Offset: 0xD71740 VA: 0x180D72540
	|-StylePropertyAnimationSystem.Values<Background>.ProcessEventQueue
	|
	|-RVA: 0xD799B0 Offset: 0xD78BB0 VA: 0x180D799B0
	|-StylePropertyAnimationSystem.Values<BackgroundPosition>.ProcessEventQueue
	|
	|-RVA: 0xD79F50 Offset: 0xD79150 VA: 0x180D79F50
	|-StylePropertyAnimationSystem.Values<BackgroundRepeat>.ProcessEventQueue
	|
	|-RVA: 0xD79C80 Offset: 0xD78E80 VA: 0x180D79C80
	|-StylePropertyAnimationSystem.Values<BackgroundSize>.ProcessEventQueue
	|
	|-RVA: 0xD7A4F0 Offset: 0xD796F0 VA: 0x180D7A4F0
	|-StylePropertyAnimationSystem.Values<Color>.ProcessEventQueue
	|
	|-RVA: 0xD7A7C0 Offset: 0xD799C0 VA: 0x180D7A7C0
	|-StylePropertyAnimationSystem.Values<FontDefinition>.ProcessEventQueue
	|
	|-RVA: 0xD7AA90 Offset: 0xD79C90 VA: 0x180D7AA90
	|-StylePropertyAnimationSystem.Values<int>.ProcessEventQueue
	|
	|-RVA: 0xD7A220 Offset: 0xD79420 VA: 0x180D7A220
	|-StylePropertyAnimationSystem.Values<Length>.ProcessEventQueue
	|
	|-RVA: 0xD8D590 Offset: 0xD8C790 VA: 0x180D8D590
	|-StylePropertyAnimationSystem.Values<object>.ProcessEventQueue
	|
	|-RVA: 0xD8D2C0 Offset: 0xD8C4C0 VA: 0x180D8D2C0
	|-StylePropertyAnimationSystem.Values<Rotate>.ProcessEventQueue
	|
	|-RVA: 0xD8DB30 Offset: 0xD8CD30 VA: 0x180D8DB30
	|-StylePropertyAnimationSystem.Values<Scale>.ProcessEventQueue
	|
	|-RVA: 0xD8CA50 Offset: 0xD8BC50 VA: 0x180D8CA50
	|-StylePropertyAnimationSystem.Values<float>.ProcessEventQueue
	|
	|-RVA: 0xD8CFF0 Offset: 0xD8C1F0 VA: 0x180D8CFF0
	|-StylePropertyAnimationSystem.Values<TextShadow>.ProcessEventQueue
	|
	|-RVA: 0xD8D860 Offset: 0xD8CA60 VA: 0x180D8D860
	|-StylePropertyAnimationSystem.Values<TransformOrigin>.ProcessEventQueue
	|
	|-RVA: 0xD8CD20 Offset: 0xD8BF20 VA: 0x180D8CD20
	|-StylePropertyAnimationSystem.Values<Translate>.ProcessEventQueue
	|
	|-RVA: 0xDA0250 Offset: 0xD9F450 VA: 0x180DA0250
	|-StylePropertyAnimationSystem.Values<__Il2CppFullySharedGenericType>.ProcessEventQueue
	*/

	// RVA: -1 Offset: -1
	private void UpdateProgress(long currentTimeMs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD74080 Offset: 0xD73280 VA: 0x180D74080
	|-StylePropertyAnimationSystem.Values<Background>.UpdateProgress
	|
	|-RVA: 0xD85970 Offset: 0xD84B70 VA: 0x180D85970
	|-StylePropertyAnimationSystem.Values<BackgroundPosition>.UpdateProgress
	|
	|-RVA: 0xD86540 Offset: 0xD85740 VA: 0x180D86540
	|-StylePropertyAnimationSystem.Values<BackgroundRepeat>.UpdateProgress
	|
	|-RVA: 0xD84DA0 Offset: 0xD83FA0 VA: 0x180D84DA0
	|-StylePropertyAnimationSystem.Values<BackgroundSize>.UpdateProgress
	|
	|-RVA: 0xD851A0 Offset: 0xD843A0 VA: 0x180D851A0
	|-StylePropertyAnimationSystem.Values<Color>.UpdateProgress
	|
	|-RVA: 0xD86150 Offset: 0xD85350 VA: 0x180D86150
	|-StylePropertyAnimationSystem.Values<FontDefinition>.UpdateProgress
	|
	|-RVA: 0xD85590 Offset: 0xD84790 VA: 0x180D85590
	|-StylePropertyAnimationSystem.Values<int>.UpdateProgress
	|
	|-RVA: 0xD85D70 Offset: 0xD84F70 VA: 0x180D85D70
	|-StylePropertyAnimationSystem.Values<Length>.UpdateProgress
	|
	|-RVA: 0xD98730 Offset: 0xD97930 VA: 0x180D98730
	|-StylePropertyAnimationSystem.Values<object>.UpdateProgress
	|
	|-RVA: 0xD996E0 Offset: 0xD988E0 VA: 0x180D996E0
	|-StylePropertyAnimationSystem.Values<Rotate>.UpdateProgress
	|
	|-RVA: 0xD992F0 Offset: 0xD984F0 VA: 0x180D992F0
	|-StylePropertyAnimationSystem.Values<Scale>.UpdateProgress
	|
	|-RVA: 0xD98B10 Offset: 0xD97D10 VA: 0x180D98B10
	|-StylePropertyAnimationSystem.Values<float>.UpdateProgress
	|
	|-RVA: 0xD98310 Offset: 0xD97510 VA: 0x180D98310
	|-StylePropertyAnimationSystem.Values<TextShadow>.UpdateProgress
	|
	|-RVA: 0xD98EF0 Offset: 0xD980F0 VA: 0x180D98EF0
	|-StylePropertyAnimationSystem.Values<TransformOrigin>.UpdateProgress
	|
	|-RVA: 0xD99AE0 Offset: 0xD98CE0 VA: 0x180D99AE0
	|-StylePropertyAnimationSystem.Values<Translate>.UpdateProgress
	|
	|-RVA: 0xDA2520 Offset: 0xDA1720 VA: 0x180DA2520
	|-StylePropertyAnimationSystem.Values<__Il2CppFullySharedGenericType>.UpdateProgress
	*/
}

// Namespace: 
private class StylePropertyAnimationSystem.ValuesFloat : StylePropertyAnimationSystem.Values<float> // TypeDefIndex: 11496
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Func<float, float, bool> <SameFunc>k__BackingField; // 0x88

	// Properties
	public override Func<float, float, bool> SameFunc { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870 Slot: 13
	public override Func<float, float, bool> get_SameFunc() { }

	// RVA: 0x26C9370 Offset: 0x26C8570 VA: 0x1826C9370
	private static bool IsSame(float a, float b) { }

	// RVA: 0x247AE50 Offset: 0x247A050 VA: 0x18247AE50
	private static float Lerp(float a, float b, float t) { }

	// RVA: 0x26C9520 Offset: 0x26C8720 VA: 0x1826C9520 Slot: 10
	protected sealed override void UpdateValues() { }

	// RVA: 0x26C9380 Offset: 0x26C8580 VA: 0x1826C9380 Slot: 11
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x26C9480 Offset: 0x26C8680 VA: 0x1826C9480 Slot: 12
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x26C95B0 Offset: 0x26C87B0 VA: 0x1826C95B0
	public void .ctor() { }
}

// Namespace: 
private class StylePropertyAnimationSystem.ValuesInt : StylePropertyAnimationSystem.Values<int> // TypeDefIndex: 11497
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Func<int, int, bool> <SameFunc>k__BackingField; // 0x88

	// Properties
	public override Func<int, int, bool> SameFunc { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870 Slot: 13
	public override Func<int, int, bool> get_SameFunc() { }

	// RVA: 0xA9F8E0 Offset: 0xA9EAE0 VA: 0x180A9F8E0
	private static bool IsSame(int a, int b) { }

	// RVA: 0x26C9A20 Offset: 0x26C8C20 VA: 0x1826C9A20
	private static int Lerp(int a, int b, float t) { }

	// RVA: 0x26C9CD0 Offset: 0x26C8ED0 VA: 0x1826C9CD0 Slot: 10
	protected sealed override void UpdateValues() { }

	// RVA: 0x26C9BD0 Offset: 0x26C8DD0 VA: 0x1826C9BD0 Slot: 11
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x26C9B30 Offset: 0x26C8D30 VA: 0x1826C9B30 Slot: 12
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x26C9EB0 Offset: 0x26C90B0 VA: 0x1826C9EB0
	public void .ctor() { }
}

// Namespace: 
private class StylePropertyAnimationSystem.ValuesLength : StylePropertyAnimationSystem.Values<Length> // TypeDefIndex: 11498
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Func<Length, Length, bool> <SameFunc>k__BackingField; // 0x88

	// Properties
	public override Func<Length, Length, bool> SameFunc { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870 Slot: 13
	public override Func<Length, Length, bool> get_SameFunc() { }

	// RVA: 0x26C9F80 Offset: 0x26C9180 VA: 0x1826C9F80
	private static bool IsSame(Length a, Length b) { }

	// RVA: 0x26C9F40 Offset: 0x26C9140 VA: 0x1826C9F40 Slot: 14
	protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref Length a, ref Length b) { }

	// RVA: 0x26C9FC0 Offset: 0x26C91C0 VA: 0x1826C9FC0
	internal static Length Lerp(Length a, Length b, float t) { }

	// RVA: 0x26CA1C0 Offset: 0x26C93C0 VA: 0x1826CA1C0 Slot: 10
	protected sealed override void UpdateValues() { }

	// RVA: 0x26CA020 Offset: 0x26C9220 VA: 0x1826CA020 Slot: 11
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x26CA120 Offset: 0x26C9320 VA: 0x1826CA120 Slot: 12
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x26CA2B0 Offset: 0x26C94B0 VA: 0x1826CA2B0
	public void .ctor() { }
}

// Namespace: 
private class StylePropertyAnimationSystem.ValuesColor : StylePropertyAnimationSystem.Values<Color> // TypeDefIndex: 11499
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Func<Color, Color, bool> <SameFunc>k__BackingField; // 0x88

	// Properties
	public override Func<Color, Color, bool> SameFunc { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870 Slot: 13
	public override Func<Color, Color, bool> get_SameFunc() { }

	// RVA: 0x26C8EE0 Offset: 0x26C80E0 VA: 0x1826C8EE0
	private static bool IsSame(Color c, Color d) { }

	// RVA: 0x26C8F60 Offset: 0x26C8160 VA: 0x1826C8F60
	private static Color Lerp(Color a, Color b, float t) { }

	// RVA: 0x26C91C0 Offset: 0x26C83C0 VA: 0x1826C91C0 Slot: 10
	protected sealed override void UpdateValues() { }

	// RVA: 0x26C90B0 Offset: 0x26C82B0 VA: 0x1826C90B0 Slot: 11
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x26C9000 Offset: 0x26C8200 VA: 0x1826C9000 Slot: 12
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x26C92E0 Offset: 0x26C84E0 VA: 0x1826C92E0
	public void .ctor() { }
}

// Namespace: 
private abstract class StylePropertyAnimationSystem.ValuesDiscrete<T> : StylePropertyAnimationSystem.Values<T> // TypeDefIndex: 11500
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly Func<T, T, bool> <SameFunc>k__BackingField; // 0x0

	// Properties
	public override Func<T, T, bool> SameFunc { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 13
	public override Func<T, T, bool> get_SameFunc() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	|-StylePropertyAnimationSystem.ValuesDiscrete<Background>.get_SameFunc
	|-StylePropertyAnimationSystem.ValuesDiscrete<BackgroundPosition>.get_SameFunc
	|-StylePropertyAnimationSystem.ValuesDiscrete<BackgroundRepeat>.get_SameFunc
	|-StylePropertyAnimationSystem.ValuesDiscrete<FontDefinition>.get_SameFunc
	|-StylePropertyAnimationSystem.ValuesDiscrete<object>.get_SameFunc
	|-StylePropertyAnimationSystem.ValuesDiscrete<__Il2CppFullySharedGenericType>.get_SameFunc
	*/

	// RVA: -1 Offset: -1
	private static bool IsSame(T a, T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD70740 Offset: 0xD6F940 VA: 0x180D70740
	|-StylePropertyAnimationSystem.ValuesDiscrete<Background>.IsSame
	|
	|-RVA: 0xD708C0 Offset: 0xD6FAC0 VA: 0x180D708C0
	|-StylePropertyAnimationSystem.ValuesDiscrete<BackgroundPosition>.IsSame
	|
	|-RVA: 0xD705E0 Offset: 0xD6F7E0 VA: 0x180D705E0
	|-StylePropertyAnimationSystem.ValuesDiscrete<BackgroundRepeat>.IsSame
	|
	|-RVA: 0xD70A40 Offset: 0xD6FC40 VA: 0x180D70A40
	|-StylePropertyAnimationSystem.ValuesDiscrete<FontDefinition>.IsSame
	|
	|-RVA: 0xD70BB0 Offset: 0xD6FDB0 VA: 0x180D70BB0
	|-StylePropertyAnimationSystem.ValuesDiscrete<object>.IsSame
	|
	|-RVA: 0xD703E0 Offset: 0xD6F5E0 VA: 0x180D703E0
	|-StylePropertyAnimationSystem.ValuesDiscrete<__Il2CppFullySharedGenericType>.IsSame
	*/

	// RVA: -1 Offset: -1
	private static T Lerp(T a, T b, float t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD70DF0 Offset: 0xD6FFF0 VA: 0x180D70DF0
	|-StylePropertyAnimationSystem.ValuesDiscrete<Background>.Lerp
	|
	|-RVA: 0xD70C40 Offset: 0xD6FE40 VA: 0x180D70C40
	|-StylePropertyAnimationSystem.ValuesDiscrete<BackgroundPosition>.Lerp
	|
	|-RVA: 0xD70C20 Offset: 0xD6FE20 VA: 0x180D70C20
	|-StylePropertyAnimationSystem.ValuesDiscrete<BackgroundRepeat>.Lerp
	|-StylePropertyAnimationSystem.ValuesDiscrete<object>.Lerp
	|
	|-RVA: 0xD70DD0 Offset: 0xD6FFD0 VA: 0x180D70DD0
	|-StylePropertyAnimationSystem.ValuesDiscrete<FontDefinition>.Lerp
	|
	|-RVA: 0xD70C80 Offset: 0xD6FE80 VA: 0x180D70C80
	|-StylePropertyAnimationSystem.ValuesDiscrete<__Il2CppFullySharedGenericType>.Lerp
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected sealed override void UpdateValues() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD70F40 Offset: 0xD70140 VA: 0x180D70F40
	|-StylePropertyAnimationSystem.ValuesDiscrete<Background>.UpdateValues
	|
	|-RVA: 0xD70EA0 Offset: 0xD700A0 VA: 0x180D70EA0
	|-StylePropertyAnimationSystem.ValuesDiscrete<BackgroundPosition>.UpdateValues
	|
	|-RVA: 0xD71260 Offset: 0xD70460 VA: 0x180D71260
	|-StylePropertyAnimationSystem.ValuesDiscrete<BackgroundRepeat>.UpdateValues
	|
	|-RVA: 0xD712E0 Offset: 0xD704E0 VA: 0x180D712E0
	|-StylePropertyAnimationSystem.ValuesDiscrete<FontDefinition>.UpdateValues
	|
	|-RVA: 0xD70E20 Offset: 0xD70020 VA: 0x180D70E20
	|-StylePropertyAnimationSystem.ValuesDiscrete<object>.UpdateValues
	|
	|-RVA: 0xD70FE0 Offset: 0xD701E0 VA: 0x180D70FE0
	|-StylePropertyAnimationSystem.ValuesDiscrete<__Il2CppFullySharedGenericType>.UpdateValues
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD71690 Offset: 0xD70890 VA: 0x180D71690
	|-StylePropertyAnimationSystem.ValuesDiscrete<Background>..ctor
	|
	|-RVA: 0xD715F0 Offset: 0xD707F0 VA: 0x180D715F0
	|-StylePropertyAnimationSystem.ValuesDiscrete<BackgroundPosition>..ctor
	|
	|-RVA: 0xD71550 Offset: 0xD70750 VA: 0x180D71550
	|-StylePropertyAnimationSystem.ValuesDiscrete<BackgroundRepeat>..ctor
	|
	|-RVA: 0xD71370 Offset: 0xD70570 VA: 0x180D71370
	|-StylePropertyAnimationSystem.ValuesDiscrete<FontDefinition>..ctor
	|
	|-RVA: 0xD71410 Offset: 0xD70610 VA: 0x180D71410
	|-StylePropertyAnimationSystem.ValuesDiscrete<object>..ctor
	|
	|-RVA: 0xD714B0 Offset: 0xD706B0 VA: 0x180D714B0
	|-StylePropertyAnimationSystem.ValuesDiscrete<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
private class StylePropertyAnimationSystem.ValuesBackground : StylePropertyAnimationSystem.ValuesDiscrete<Background> // TypeDefIndex: 11501
{
	// Methods

	// RVA: 0x26C8D70 Offset: 0x26C7F70 VA: 0x1826C8D70 Slot: 11
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x26C8CB0 Offset: 0x26C7EB0 VA: 0x1826C8CB0 Slot: 12
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x26C8EA0 Offset: 0x26C80A0 VA: 0x1826C8EA0
	public void .ctor() { }
}

// Namespace: 
private class StylePropertyAnimationSystem.ValuesFontDefinition : StylePropertyAnimationSystem.ValuesDiscrete<FontDefinition> // TypeDefIndex: 11502
{
	// Methods

	// RVA: 0x26C96F0 Offset: 0x26C88F0 VA: 0x1826C96F0 Slot: 11
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x26C9640 Offset: 0x26C8840 VA: 0x1826C9640 Slot: 12
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x26C9800 Offset: 0x26C8A00 VA: 0x1826C9800
	public void .ctor() { }
}

// Namespace: 
private class StylePropertyAnimationSystem.ValuesFont : StylePropertyAnimationSystem.ValuesDiscrete<Font> // TypeDefIndex: 11503
{
	// Methods

	// RVA: 0x26C98E0 Offset: 0x26C8AE0 VA: 0x1826C98E0 Slot: 11
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x26C9840 Offset: 0x26C8A40 VA: 0x1826C9840 Slot: 12
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x26C99E0 Offset: 0x26C8BE0 VA: 0x1826C99E0
	public void .ctor() { }
}

// Namespace: 
private class StylePropertyAnimationSystem.ValuesTextShadow : StylePropertyAnimationSystem.Values<TextShadow> // TypeDefIndex: 11504
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Func<TextShadow, TextShadow, bool> <SameFunc>k__BackingField; // 0x88

	// Properties
	public override Func<TextShadow, TextShadow, bool> SameFunc { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870 Slot: 13
	public override Func<TextShadow, TextShadow, bool> get_SameFunc() { }

	// RVA: 0x26CADB0 Offset: 0x26C9FB0 VA: 0x1826CADB0
	private static bool IsSame(TextShadow a, TextShadow b) { }

	// RVA: 0x26CAE00 Offset: 0x26CA000 VA: 0x1826CAE00
	private static TextShadow Lerp(TextShadow a, TextShadow b, float t) { }

	// RVA: 0x26CB0A0 Offset: 0x26CA2A0 VA: 0x1826CB0A0 Slot: 10
	protected sealed override void UpdateValues() { }

	// RVA: 0x26CAF60 Offset: 0x26CA160 VA: 0x1826CAF60 Slot: 11
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x26CAE90 Offset: 0x26CA090 VA: 0x1826CAE90 Slot: 12
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x26CB1E0 Offset: 0x26CA3E0 VA: 0x1826CB1E0
	public void .ctor() { }
}

// Namespace: 
private class StylePropertyAnimationSystem.ValuesScale : StylePropertyAnimationSystem.Values<Scale> // TypeDefIndex: 11505
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Func<Scale, Scale, bool> <SameFunc>k__BackingField; // 0x88

	// Properties
	public override Func<Scale, Scale, bool> SameFunc { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870 Slot: 13
	public override Func<Scale, Scale, bool> get_SameFunc() { }

	// RVA: 0x26CA830 Offset: 0x26C9A30 VA: 0x1826CA830
	private static bool IsSame(Scale a, Scale b) { }

	// RVA: 0x26CAA40 Offset: 0x26C9C40 VA: 0x1826CAA40 Slot: 11
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x26CA990 Offset: 0x26C9B90 VA: 0x1826CA990 Slot: 12
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x26CA880 Offset: 0x26C9A80 VA: 0x1826CA880
	private static Scale Lerp(Scale a, Scale b, float t) { }

	// RVA: 0x26CAB50 Offset: 0x26C9D50 VA: 0x1826CAB50 Slot: 10
	protected sealed override void UpdateValues() { }

	// RVA: 0x26CAD20 Offset: 0x26C9F20 VA: 0x1826CAD20
	public void .ctor() { }
}

// Namespace: 
private class StylePropertyAnimationSystem.ValuesRotate : StylePropertyAnimationSystem.Values<Rotate> // TypeDefIndex: 11506
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly Func<Rotate, Rotate, bool> <SameFunc>k__BackingField; // 0x88

	// Properties
	public override Func<Rotate, Rotate, bool> SameFunc { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870 Slot: 13
	public override Func<Rotate, Rotate, bool> get_SameFunc() { }

	// RVA: 0x26B89A0 Offset: 0x26B7BA0 VA: 0x1826B89A0
	private static bool IsSame(Rotate a, Rotate b) { }

	// RVA: 0x26CA4C0 Offset: 0x26C96C0 VA: 0x1826CA4C0 Slot: 11
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x26CA400 Offset: 0x26C9600 VA: 0x1826CA400 Slot: 12
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x26CA340 Offset: 0x26C9540 VA: 0x1826CA340
	private static Rotate Lerp(Rotate a, Rotate b, float t) { }

	// RVA: 0x26CA5F0 Offset: 0x26C97F0 VA: 0x1826CA5F0 Slot: 10
	protected sealed override void UpdateValues() { }

	// RVA: 0x26CA7A0 Offset: 0x26C99A0 VA: 0x1826CA7A0
	public void .ctor() { }
}

// Namespace: 
private class StylePropertyAnimationSystem.ValuesTranslate : StylePropertyAnimationSystem.Values<Translate> // TypeDefIndex: 11507
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Func<Translate, Translate, bool> <SameFunc>k__BackingField; // 0x88

	// Properties
	public override Func<Translate, Translate, bool> SameFunc { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870 Slot: 13
	public override Func<Translate, Translate, bool> get_SameFunc() { }

	// RVA: 0x26CB840 Offset: 0x26CAA40 VA: 0x1826CB840
	private static bool IsSame(Translate a, Translate b) { }

	// RVA: 0x26CB810 Offset: 0x26CAA10 VA: 0x1826CB810 Slot: 14
	protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref Translate a, ref Translate b) { }

	// RVA: 0x26CBA50 Offset: 0x26CAC50 VA: 0x1826CBA50 Slot: 11
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x26CB990 Offset: 0x26CAB90 VA: 0x1826CB990 Slot: 12
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x26CB890 Offset: 0x26CAA90 VA: 0x1826CB890
	private static Translate Lerp(Translate a, Translate b, float t) { }

	// RVA: 0x26CBB80 Offset: 0x26CAD80 VA: 0x1826CBB80 Slot: 10
	protected sealed override void UpdateValues() { }

	// RVA: 0x26CBDD0 Offset: 0x26CAFD0 VA: 0x1826CBDD0
	public void .ctor() { }
}

// Namespace: 
private class StylePropertyAnimationSystem.ValuesTransformOrigin : StylePropertyAnimationSystem.Values<TransformOrigin> // TypeDefIndex: 11508
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly Func<TransformOrigin, TransformOrigin, bool> <SameFunc>k__BackingField; // 0x88

	// Properties
	public override Func<TransformOrigin, TransformOrigin, bool> SameFunc { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870 Slot: 13
	public override Func<TransformOrigin, TransformOrigin, bool> get_SameFunc() { }

	// RVA: 0x26C4BF0 Offset: 0x26C3DF0 VA: 0x1826C4BF0
	private static bool IsSame(TransformOrigin a, TransformOrigin b) { }

	// RVA: 0x26CB270 Offset: 0x26CA470 VA: 0x1826CB270 Slot: 14
	protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref TransformOrigin a, ref TransformOrigin b) { }

	// RVA: 0x26CB450 Offset: 0x26CA650 VA: 0x1826CB450 Slot: 11
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x26CB390 Offset: 0x26CA590 VA: 0x1826CB390 Slot: 12
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x26CB2A0 Offset: 0x26CA4A0 VA: 0x1826CB2A0
	private static TransformOrigin Lerp(TransformOrigin a, TransformOrigin b, float t) { }

	// RVA: 0x26CB580 Offset: 0x26CA780 VA: 0x1826CB580 Slot: 10
	protected sealed override void UpdateValues() { }

	// RVA: 0x26CB780 Offset: 0x26CA980 VA: 0x1826CB780
	public void .ctor() { }
}

// Namespace: 
private class StylePropertyAnimationSystem.ValuesBackgroundPosition : StylePropertyAnimationSystem.ValuesDiscrete<BackgroundPosition> // TypeDefIndex: 11509
{
	// Methods

	// RVA: 0x26C8260 Offset: 0x26C7460 VA: 0x1826C8260 Slot: 11
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x26C8380 Offset: 0x26C7580 VA: 0x1826C8380 Slot: 12
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x26C8440 Offset: 0x26C7640 VA: 0x1826C8440
	public void .ctor() { }
}

// Namespace: 
private class StylePropertyAnimationSystem.ValuesBackgroundRepeat : StylePropertyAnimationSystem.ValuesDiscrete<BackgroundRepeat> // TypeDefIndex: 11510
{
	// Methods

	// RVA: 0x26C8520 Offset: 0x26C7720 VA: 0x1826C8520 Slot: 11
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x26C8480 Offset: 0x26C7680 VA: 0x1826C8480 Slot: 12
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x26C8620 Offset: 0x26C7820 VA: 0x1826C8620
	public void .ctor() { }
}

// Namespace: 
private class StylePropertyAnimationSystem.ValuesBackgroundSize : StylePropertyAnimationSystem.Values<BackgroundSize> // TypeDefIndex: 11511
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Func<BackgroundSize, BackgroundSize, bool> <SameFunc>k__BackingField; // 0x88

	// Properties
	public override Func<BackgroundSize, BackgroundSize, bool> SameFunc { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870 Slot: 13
	public override Func<BackgroundSize, BackgroundSize, bool> get_SameFunc() { }

	// RVA: 0x26C8690 Offset: 0x26C7890 VA: 0x1826C8690
	private static bool IsSame(BackgroundSize a, BackgroundSize b) { }

	// RVA: 0x26C8660 Offset: 0x26C7860 VA: 0x1826C8660 Slot: 14
	protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref BackgroundSize a, ref BackgroundSize b) { }

	// RVA: 0x26C88C0 Offset: 0x26C7AC0 VA: 0x1826C88C0 Slot: 11
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x26C8800 Offset: 0x26C7A00 VA: 0x1826C8800 Slot: 12
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x26C86D0 Offset: 0x26C78D0 VA: 0x1826C86D0
	private static BackgroundSize Lerp(BackgroundSize a, BackgroundSize b, float t) { }

	// RVA: 0x26C89F0 Offset: 0x26C7BF0 VA: 0x1826C89F0 Slot: 10
	protected sealed override void UpdateValues() { }

	// RVA: 0x26C8C20 Offset: 0x26C7E20 VA: 0x1826C8C20
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements
internal class StylePropertyAnimationSystem : IStylePropertyAnimationSystem // TypeDefIndex: 11512
{
	// Fields
	private long m_CurrentTimeMs; // 0x10
	private StylePropertyAnimationSystem.ValuesFloat m_Floats; // 0x18
	private StylePropertyAnimationSystem.ValuesInt m_Ints; // 0x20
	private StylePropertyAnimationSystem.ValuesLength m_Lengths; // 0x28
	private StylePropertyAnimationSystem.ValuesColor m_Colors; // 0x30
	private StylePropertyAnimationSystem.ValuesBackground m_Backgrounds; // 0x38
	private StylePropertyAnimationSystem.ValuesFontDefinition m_FontDefinitions; // 0x40
	private StylePropertyAnimationSystem.ValuesFont m_Fonts; // 0x48
	private StylePropertyAnimationSystem.ValuesTextShadow m_TextShadows; // 0x50
	private StylePropertyAnimationSystem.ValuesScale m_Scale; // 0x58
	private StylePropertyAnimationSystem.ValuesRotate m_Rotate; // 0x60
	private StylePropertyAnimationSystem.ValuesTranslate m_Translate; // 0x68
	private StylePropertyAnimationSystem.ValuesTransformOrigin m_TransformOrigin; // 0x70
	private StylePropertyAnimationSystem.ValuesBackgroundPosition m_BackgroundPosition; // 0x78
	private StylePropertyAnimationSystem.ValuesBackgroundRepeat m_BackgroundRepeat; // 0x80
	private StylePropertyAnimationSystem.ValuesBackgroundSize m_BackgroundSize; // 0x88
	private readonly List<StylePropertyAnimationSystem.Values> m_AllValues; // 0x90
	private readonly Dictionary<StylePropertyId, StylePropertyAnimationSystem.Values> m_PropertyToValues; // 0x98

	// Methods

	// RVA: 0x26BC7C0 Offset: 0x26BB9C0 VA: 0x1826BC7C0
	public void .ctor() { }

	// RVA: -1 Offset: -1
	private T GetOrCreate<T>(ref T values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA7D050 Offset: 0xA7C250 VA: 0x180A7D050
	|-StylePropertyAnimationSystem.GetOrCreate<object>
	|
	|-RVA: 0xA7CDD0 Offset: 0xA7BFD0 VA: 0x180A7CDD0
	|-StylePropertyAnimationSystem.GetOrCreate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private bool StartTransition<T>(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, Func<float, float> easingCurve, StylePropertyAnimationSystem.Values<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA7D680 Offset: 0xA7C880 VA: 0x180A7D680
	|-StylePropertyAnimationSystem.StartTransition<Background>
	|
	|-RVA: 0xA7D0A0 Offset: 0xA7C2A0 VA: 0x180A7D0A0
	|-StylePropertyAnimationSystem.StartTransition<BackgroundPosition>
	|
	|-RVA: 0xA7D2A0 Offset: 0xA7C4A0 VA: 0x180A7D2A0
	|-StylePropertyAnimationSystem.StartTransition<BackgroundRepeat>
	|
	|-RVA: 0xA7D470 Offset: 0xA7C670 VA: 0x180A7D470
	|-StylePropertyAnimationSystem.StartTransition<BackgroundSize>
	|
	|-RVA: 0xA7D890 Offset: 0xA7CA90 VA: 0x180A7D890
	|-StylePropertyAnimationSystem.StartTransition<Color>
	|
	|-RVA: 0xA7DA80 Offset: 0xA7CC80 VA: 0x180A7DA80
	|-StylePropertyAnimationSystem.StartTransition<FontDefinition>
	|
	|-RVA: 0xA7DEA0 Offset: 0xA7D0A0 VA: 0x180A7DEA0
	|-StylePropertyAnimationSystem.StartTransition<int>
	|
	|-RVA: 0xA7E070 Offset: 0xA7D270 VA: 0x180A7E070
	|-StylePropertyAnimationSystem.StartTransition<Length>
	|
	|-RVA: 0xA7E450 Offset: 0xA7D650 VA: 0x180A7E450
	|-StylePropertyAnimationSystem.StartTransition<object>
	|
	|-RVA: 0xA7E240 Offset: 0xA7D440 VA: 0x180A7E240
	|-StylePropertyAnimationSystem.StartTransition<Rotate>
	|
	|-RVA: 0xA7E620 Offset: 0xA7D820 VA: 0x180A7E620
	|-StylePropertyAnimationSystem.StartTransition<Scale>
	|
	|-RVA: 0xA7E810 Offset: 0xA7DA10 VA: 0x180A7E810
	|-StylePropertyAnimationSystem.StartTransition<float>
	|
	|-RVA: 0xA7E9F0 Offset: 0xA7DBF0 VA: 0x180A7E9F0
	|-StylePropertyAnimationSystem.StartTransition<TextShadow>
	|
	|-RVA: 0xA7EC10 Offset: 0xA7DE10 VA: 0x180A7EC10
	|-StylePropertyAnimationSystem.StartTransition<TransformOrigin>
	|
	|-RVA: 0xA7EE20 Offset: 0xA7E020 VA: 0x180A7EE20
	|-StylePropertyAnimationSystem.StartTransition<Translate>
	|
	|-RVA: 0xA7DC70 Offset: 0xA7CE70 VA: 0x180A7DC70
	|-StylePropertyAnimationSystem.StartTransition<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x26BC1F0 Offset: 0x26BB3F0 VA: 0x1826BC1F0 Slot: 4
	public bool StartTransition(VisualElement owner, StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26BBE20 Offset: 0x26BB020 VA: 0x1826BBE20 Slot: 5
	public bool StartTransition(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26BBB70 Offset: 0x26BAD70 VA: 0x1826BBB70 Slot: 6
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26BBC40 Offset: 0x26BAE40 VA: 0x1826BBC40 Slot: 7
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Color startValue, Color endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26BB990 Offset: 0x26BAB90 VA: 0x1826BB990 Slot: 8
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26BBA90 Offset: 0x26BAC90 VA: 0x1826BBA90 Slot: 9
	public bool StartTransition(VisualElement owner, StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26BC3A0 Offset: 0x26BB5A0 VA: 0x1826BC3A0 Slot: 10
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26BC0E0 Offset: 0x26BB2E0 VA: 0x1826BC0E0 Slot: 11
	public bool StartTransition(VisualElement owner, StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26BC2C0 Offset: 0x26BB4C0 VA: 0x1826BC2C0 Slot: 12
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26BBFE0 Offset: 0x26BB1E0 VA: 0x1826BBFE0 Slot: 15
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26BC470 Offset: 0x26BB670 VA: 0x1826BC470 Slot: 14
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26BBD20 Offset: 0x26BAF20 VA: 0x1826BBD20 Slot: 13
	public bool StartTransition(VisualElement owner, StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26BB8A0 Offset: 0x26BAAA0 VA: 0x1826BB8A0 Slot: 16
	public bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundPosition startValue, BackgroundPosition endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26BC570 Offset: 0x26BB770 VA: 0x1826BC570 Slot: 17
	public bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundRepeat startValue, BackgroundRepeat endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26BBEE0 Offset: 0x26BB0E0 VA: 0x1826BBEE0 Slot: 18
	public bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundSize startValue, BackgroundSize endValue, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x26BB3F0 Offset: 0x26BA5F0 VA: 0x1826BB3F0 Slot: 19
	public void CancelAllAnimations() { }

	// RVA: 0x26BB500 Offset: 0x26BA700 VA: 0x1826BB500 Slot: 20
	public void CancelAllAnimations(VisualElement owner) { }

	// RVA: 0x26BB6D0 Offset: 0x26BA8D0 VA: 0x1826BB6D0 Slot: 21
	public void CancelAnimation(VisualElement owner, StylePropertyId id) { }

	// RVA: 0x26BC640 Offset: 0x26BB840 VA: 0x1826BC640 Slot: 22
	public void UpdateAnimation(VisualElement owner, StylePropertyId id) { }

	// RVA: 0x26BB770 Offset: 0x26BA970 VA: 0x1826BB770 Slot: 23
	public void GetAllAnimations(VisualElement owner, List<StylePropertyId> propertyIds) { }

	// RVA: -1 Offset: -1
	private void UpdateTracking<T>(StylePropertyAnimationSystem.Values<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA7F030 Offset: 0xA7E230 VA: 0x180A7F030
	|-StylePropertyAnimationSystem.UpdateTracking<Background>
	|-StylePropertyAnimationSystem.UpdateTracking<BackgroundPosition>
	|-StylePropertyAnimationSystem.UpdateTracking<BackgroundRepeat>
	|-StylePropertyAnimationSystem.UpdateTracking<BackgroundSize>
	|-StylePropertyAnimationSystem.UpdateTracking<Color>
	|-StylePropertyAnimationSystem.UpdateTracking<FontDefinition>
	|-StylePropertyAnimationSystem.UpdateTracking<int>
	|-StylePropertyAnimationSystem.UpdateTracking<Length>
	|-StylePropertyAnimationSystem.UpdateTracking<object>
	|-StylePropertyAnimationSystem.UpdateTracking<Rotate>
	|-StylePropertyAnimationSystem.UpdateTracking<Scale>
	|-StylePropertyAnimationSystem.UpdateTracking<float>
	|-StylePropertyAnimationSystem.UpdateTracking<TextShadow>
	|-StylePropertyAnimationSystem.UpdateTracking<TransformOrigin>
	|-StylePropertyAnimationSystem.UpdateTracking<Translate>
	|
	|-RVA: 0xA7F140 Offset: 0xA7E340 VA: 0x180A7F140
	|-StylePropertyAnimationSystem.UpdateTracking<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1208660 Offset: 0x1207860 VA: 0x181208660
	private long CurrentTimeMs() { }

	// RVA: 0x26BC6E0 Offset: 0x26BB8E0 VA: 0x1826BC6E0 Slot: 24
	public void Update() { }
}

// Namespace: UnityEngine.UIElements
public struct StylePropertyName : IEquatable<StylePropertyName> // TypeDefIndex: 11513
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly StylePropertyId <id>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <name>k__BackingField; // 0x8

	// Properties
	internal StylePropertyId id { get; }
	private string name { get; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	internal StylePropertyId get_id() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	private string get_name() { }

	// RVA: 0x26BC940 Offset: 0x26BBB40 VA: 0x1826BC940
	internal static StylePropertyId StylePropertyIdFromString(string name) { }

	// RVA: 0x26BCAA0 Offset: 0x26BBCA0 VA: 0x1826BCAA0
	internal void .ctor(StylePropertyId stylePropertyId) { }

	// RVA: 0x26BC9E0 Offset: 0x26BBBE0 VA: 0x1826BC9E0
	public void .ctor(string name) { }

	// RVA: 0x26BC930 Offset: 0x26BBB30 VA: 0x1826BC930
	public static bool op_Equality(StylePropertyName lhs, StylePropertyName rhs) { }

	// RVA: 0x26BCB90 Offset: 0x26BBD90 VA: 0x1826BCB90
	public static bool op_Inequality(StylePropertyName lhs, StylePropertyName rhs) { }

	// RVA: 0x26BCB50 Offset: 0x26BBD50 VA: 0x1826BCB50
	public static StylePropertyName op_Implicit(string name) { }

	// RVA: 0x244E020 Offset: 0x244D220 VA: 0x18244E020 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x26BC8A0 Offset: 0x26BBAA0 VA: 0x1826BC8A0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x26BC930 Offset: 0x26BBB30 VA: 0x1826BC930 Slot: 4
	public bool Equals(StylePropertyName other) { }

	// RVA: 0x1808BB0 Offset: 0x1807DB0 VA: 0x181808BB0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.UIElements
internal enum Salt // TypeDefIndex: 11514
{
	// Fields
	public int value__; // 0x0
	public const Salt TagNameSalt = 13;
	public const Salt IdSalt = 17;
	public const Salt ClassSalt = 19;
}

// Namespace: 
[UnsafeValueType]
[CompilerGenerated]
public struct Hashes.<hashes>e__FixedBuffer // TypeDefIndex: 11515
{
	// Fields
	public int FixedElementField; // 0x0
}

// Namespace: UnityEngine.UIElements
internal struct Hashes // TypeDefIndex: 11516
{
	// Fields
	public const int kSize = 4;
	[FixedBuffer(typeof(int), 4)]
	public Hashes.<hashes>e__FixedBuffer hashes; // 0x0
}

// Namespace: 
private struct StyleComplexSelector.PseudoStateData // TypeDefIndex: 11517
{
	// Fields
	public readonly PseudoStates state; // 0x0
	public readonly bool negate; // 0x4

	// Methods

	// RVA: 0xD3BAE0 Offset: 0xD3ACE0 VA: 0x180D3BAE0
	public void .ctor(PseudoStates state, bool negate) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class StyleComplexSelector.<>c // TypeDefIndex: 11518
{
	// Fields
	public static readonly StyleComplexSelector.<>c <>9; // 0x0
	public static Func<StyleSelector, string> <>9__24_0; // 0x8
	public static Predicate<StyleSelectorPart> <>9__27_0; // 0x10

	// Methods

	// RVA: 0x26C56A0 Offset: 0x26C48A0 VA: 0x1826C56A0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x54BDD0 Offset: 0x54AFD0 VA: 0x18054BDD0
	internal string <ToString>b__24_0(StyleSelector x) { }

	// RVA: 0x26C5600 Offset: 0x26C4800 VA: 0x1826C5600
	internal bool <CalculateHashes>b__27_0(StyleSelectorPart p) { }
}

// Namespace: UnityEngine.UIElements
[Serializable]
internal class StyleComplexSelector : ISerializationCallbackReceiver // TypeDefIndex: 11519
{
	// Fields
	public Hashes ancestorHashes; // 0x10
	[SerializeField]
	private int m_Specificity; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private StyleRule <rule>k__BackingField; // 0x28
	private bool m_isSimple; // 0x30
	[SerializeField]
	private StyleSelector[] m_Selectors; // 0x38
	[SerializeField]
	internal int ruleIndex; // 0x40
	internal StyleComplexSelector nextInTable; // 0x48
	internal int orderInStyleSheet; // 0x50
	private static Dictionary<string, StyleComplexSelector.PseudoStateData> s_PseudoStates; // 0x0
	private static List<StyleSelectorPart> m_HashList; // 0x8

	// Properties
	public int specificity { get; }
	public StyleRule rule { get; set; }
	public bool isSimple { get; }
	public StyleSelector[] selectors { get; set; }

	// Methods

	// RVA: 0xC9F3A0 Offset: 0xC9E5A0 VA: 0x180C9F3A0
	public int get_specificity() { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public StyleRule get_rule() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	internal void set_rule(StyleRule value) { }

	// RVA: 0x248C1E0 Offset: 0x248B3E0 VA: 0x18248C1E0
	public bool get_isSimple() { }

	// RVA: 0x24CAD90 Offset: 0x24C9F90 VA: 0x1824CAD90
	public StyleSelector[] get_selectors() { }

	// RVA: 0x26BA4A0 Offset: 0x26B96A0 VA: 0x1826BA4A0
	internal void set_selectors(StyleSelector[] value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x26BA240 Offset: 0x26B9440 VA: 0x1826BA240 Slot: 6
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x26B95E0 Offset: 0x26B87E0 VA: 0x1826B95E0
	internal void CachePseudoStateMasks() { }

	// RVA: 0x26BA2C0 Offset: 0x26B94C0 VA: 0x1826BA2C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x26BA270 Offset: 0x26B9470 VA: 0x1826BA270
	private static int StyleSelectorPartCompare(StyleSelectorPart x, StyleSelectorPart y) { }

	// RVA: 0x26B9C90 Offset: 0x26B8E90 VA: 0x1826B9C90
	internal void CalculateHashes() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x26BA430 Offset: 0x26B9630 VA: 0x1826BA430
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements
[Serializable]
internal class StyleProperty // TypeDefIndex: 11520
{
	// Fields
	[SerializeField]
	private string m_Name; // 0x10
	[SerializeField]
	private int m_Line; // 0x18
	[SerializeField]
	private StyleValueHandle[] m_Values; // 0x20
	internal bool isCustomProperty; // 0x28
	internal bool requireVariableResolve; // 0x29

	// Properties
	public string name { get; }
	public StyleValueHandle[] values { get; }

	// Methods

	// RVA: 0x1208660 Offset: 0x1207860 VA: 0x181208660
	public string get_name() { }

	// RVA: 0x2497C30 Offset: 0x2496E30 VA: 0x182497C30
	public StyleValueHandle[] get_values() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements
[Serializable]
internal class StyleRule // TypeDefIndex: 11521
{
	// Fields
	[SerializeField]
	private StyleProperty[] m_Properties; // 0x10
	[SerializeField]
	internal int line; // 0x18
	internal int customPropertiesCount; // 0x1C

	// Properties
	public StyleProperty[] properties { get; }

	// Methods

	// RVA: 0x1208660 Offset: 0x1207860 VA: 0x181208660
	public StyleProperty[] get_properties() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class StyleSelector.<>c // TypeDefIndex: 11522
{
	// Fields
	public static readonly StyleSelector.<>c <>9; // 0x0
	public static Func<StyleSelectorPart, string> <>9__10_0; // 0x8

	// Methods

	// RVA: 0x26C5640 Offset: 0x26C4840 VA: 0x1826C5640
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x26C5620 Offset: 0x26C4820 VA: 0x1826C5620
	internal string <ToString>b__10_0(StyleSelectorPart p) { }
}

// Namespace: UnityEngine.UIElements
[Serializable]
internal class StyleSelector // TypeDefIndex: 11523
{
	// Fields
	[SerializeField]
	private StyleSelectorPart[] m_Parts; // 0x10
	[SerializeField]
	private StyleSelectorRelationship m_PreviousRelationship; // 0x18
	internal int pseudoStateMask; // 0x1C
	internal int negatedPseudoStateMask; // 0x20

	// Properties
	public StyleSelectorPart[] parts { get; set; }
	public StyleSelectorRelationship previousRelationship { get; set; }

	// Methods

	// RVA: 0x1208660 Offset: 0x1207860 VA: 0x181208660
	public StyleSelectorPart[] get_parts() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void set_parts(StyleSelectorPart[] value) { }

	// RVA: 0xB78A40 Offset: 0xB77C40 VA: 0x180B78A40
	public StyleSelectorRelationship get_previousRelationship() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	internal void set_previousRelationship(StyleSelectorRelationship value) { }

	// RVA: 0x26BD510 Offset: 0x26BC710 VA: 0x1826BD510 Slot: 3
	public override string ToString() { }

	// RVA: 0x26BD650 Offset: 0x26BC850 VA: 0x1826BD650
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements
[Serializable]
internal struct StyleSelectorPart // TypeDefIndex: 11524
{
	// Fields
	[SerializeField]
	private string m_Value; // 0x0
	[SerializeField]
	private StyleSelectorType m_Type; // 0x8
	internal object tempData; // 0x10

	// Properties
	public string value { get; }
	public StyleSelectorType type { get; set; }

	// Methods

	// RVA: 0xA55380 Offset: 0xA54580 VA: 0x180A55380
	public string get_value() { }

	// RVA: 0xBC6000 Offset: 0xBC5200 VA: 0x180BC6000
	public StyleSelectorType get_type() { }

	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	internal void set_type(StyleSelectorType value) { }

	// RVA: 0x26BD3F0 Offset: 0x26BC5F0 VA: 0x1826BD3F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x26BD330 Offset: 0x26BC530 VA: 0x1826BD330
	public static StyleSelectorPart CreateClass(string className) { }

	// RVA: 0x26BD370 Offset: 0x26BC570 VA: 0x1826BD370
	public static StyleSelectorPart CreateId(string Id) { }

	// RVA: 0x26BD3B0 Offset: 0x26BC5B0 VA: 0x1826BD3B0
	public static StyleSelectorPart CreatePredicate(object predicate) { }
}

// Namespace: UnityEngine.UIElements
internal enum StyleSelectorRelationship // TypeDefIndex: 11525
{
	// Fields
	public int value__; // 0x0
	public const StyleSelectorRelationship None = 0;
	public const StyleSelectorRelationship Child = 1;
	public const StyleSelectorRelationship Descendent = 2;
}

// Namespace: UnityEngine.UIElements
internal enum StyleSelectorType // TypeDefIndex: 11526
{
	// Fields
	public int value__; // 0x0
	public const StyleSelectorType Unknown = 0;
	public const StyleSelectorType Wildcard = 1;
	public const StyleSelectorType Type = 2;
	public const StyleSelectorType Class = 3;
	public const StyleSelectorType PseudoClass = 4;
	public const StyleSelectorType RecursivePseudoClass = 5;
	public const StyleSelectorType ID = 6;
	public const StyleSelectorType Predicate = 7;
}

// Namespace: 
[Serializable]
internal struct StyleSheet.ImportStruct // TypeDefIndex: 11527
{
	// Fields
	public StyleSheet styleSheet; // 0x0
	public string[] mediaQueries; // 0x8
}

// Namespace: UnityEngine.UIElements
[HelpURL("UIE-USS")]
[Serializable]
public class StyleSheet : ScriptableObject // TypeDefIndex: 11528
{
	// Fields
	[SerializeField]
	private bool m_ImportedWithErrors; // 0x18
	[SerializeField]
	private bool m_ImportedWithWarnings; // 0x19
	[SerializeField]
	private StyleRule[] m_Rules; // 0x20
	[SerializeField]
	private StyleComplexSelector[] m_ComplexSelectors; // 0x28
	[SerializeField]
	internal float[] floats; // 0x30
	[SerializeField]
	internal Dimension[] dimensions; // 0x38
	[SerializeField]
	internal Color[] colors; // 0x40
	[SerializeField]
	internal string[] strings; // 0x48
	[SerializeField]
	internal Object[] assets; // 0x50
	[SerializeField]
	internal StyleSheet.ImportStruct[] imports; // 0x58
	[SerializeField]
	private List<StyleSheet> m_FlattenedImportedStyleSheets; // 0x60
	[SerializeField]
	private int m_ContentHash; // 0x68
	[SerializeField]
	internal ScalableImage[] scalableImages; // 0x70
	internal Dictionary<string, StyleComplexSelector> orderedNameSelectors; // 0x78
	internal Dictionary<string, StyleComplexSelector> orderedTypeSelectors; // 0x80
	internal Dictionary<string, StyleComplexSelector> orderedClassSelectors; // 0x88
	private bool m_IsDefaultStyleSheet; // 0x90
	private static string kCustomPropertyMarker; // 0x0

	// Properties
	public bool importedWithErrors { get; set; }
	public bool importedWithWarnings { get; set; }
	internal StyleRule[] rules { get; set; }
	internal StyleComplexSelector[] complexSelectors { get; set; }
	internal List<StyleSheet> flattenedRecursiveImports { get; }
	public int contentHash { get; set; }
	internal bool isDefaultStyleSheet { get; set; }

	// Methods

	// RVA: 0x254DE70 Offset: 0x254D070 VA: 0x18254DE70
	public bool get_importedWithErrors() { }

	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	internal void set_importedWithErrors(bool value) { }

	// RVA: 0x25B6200 Offset: 0x25B5400 VA: 0x1825B6200
	public bool get_importedWithWarnings() { }

	// RVA: 0x630F50 Offset: 0x630150 VA: 0x180630F50
	internal void set_importedWithWarnings(bool value) { }

	// RVA: 0x2497C30 Offset: 0x2496E30 VA: 0x182497C30
	internal StyleRule[] get_rules() { }

	// RVA: 0x26BEBC0 Offset: 0x26BDDC0 VA: 0x1826BEBC0
	internal void set_rules(StyleRule[] value) { }

	// RVA: 0x248C200 Offset: 0x248B400 VA: 0x18248C200
	internal StyleComplexSelector[] get_complexSelectors() { }

	// RVA: 0x26BEAA0 Offset: 0x26BDCA0 VA: 0x1826BEAA0
	internal void set_complexSelectors(StyleComplexSelector[] value) { }

	// RVA: 0x24CAD70 Offset: 0x24C9F70 VA: 0x1824CAD70
	internal List<StyleSheet> get_flattenedRecursiveImports() { }

	// RVA: 0x26BEA80 Offset: 0x26BDC80 VA: 0x1826BEA80
	public int get_contentHash() { }

	// RVA: 0x42D810 Offset: 0x42CA10 VA: 0x18042D810
	public void set_contentHash(int value) { }

	// RVA: 0x26BEA90 Offset: 0x26BDC90 VA: 0x1826BEA90
	internal bool get_isDefaultStyleSheet() { }

	// RVA: 0x26BEAB0 Offset: 0x26BDCB0 VA: 0x1826BEAB0
	internal void set_isDefaultStyleSheet(bool value) { }

	// RVA: -1 Offset: -1
	private bool TryCheckAccess<T>(T[] list, StyleValueType type, StyleValueHandle handle, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA7FF00 Offset: 0xA7F100 VA: 0x180A7FF00
	|-StyleSheet.TryCheckAccess<Color>
	|
	|-RVA: 0xA800E0 Offset: 0xA7F2E0 VA: 0x180A800E0
	|-StyleSheet.TryCheckAccess<Dimension>
	|
	|-RVA: 0xA80500 Offset: 0xA7F700 VA: 0x180A80500
	|-StyleSheet.TryCheckAccess<object>
	|
	|-RVA: 0xA806D0 Offset: 0xA7F8D0 VA: 0x180A806D0
	|-StyleSheet.TryCheckAccess<float>
	|
	|-RVA: 0xA802B0 Offset: 0xA7F4B0 VA: 0x180A802B0
	|-StyleSheet.TryCheckAccess<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private T CheckAccess<T>(T[] list, StyleValueType type, StyleValueHandle handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA7F250 Offset: 0xA7E450 VA: 0x180A7F250
	|-StyleSheet.CheckAccess<Color>
	|
	|-RVA: 0xA7F440 Offset: 0xA7E640 VA: 0x180A7F440
	|-StyleSheet.CheckAccess<Dimension>
	|
	|-RVA: 0xA7F930 Offset: 0xA7EB30 VA: 0x180A7F930
	|-StyleSheet.CheckAccess<object>
	|
	|-RVA: 0xA7FB20 Offset: 0xA7ED20 VA: 0x180A7FB20
	|-StyleSheet.CheckAccess<ScalableImage>
	|
	|-RVA: 0xA7FD10 Offset: 0xA7EF10 VA: 0x180A7FD10
	|-StyleSheet.CheckAccess<float>
	|
	|-RVA: 0xA7F630 Offset: 0xA7E830 VA: 0x180A7F630
	|-StyleSheet.CheckAccess<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x26BD8D0 Offset: 0x26BCAD0 VA: 0x1826BD8D0 Slot: 4
	internal virtual void OnEnable() { }

	// RVA: 0x26BD860 Offset: 0x26BCA60 VA: 0x1826BD860
	internal void FlattenImportedStyleSheetsRecursive() { }

	// RVA: 0x26BD730 Offset: 0x26BC930 VA: 0x1826BD730
	private void FlattenImportedStyleSheetsRecursive(StyleSheet sheet) { }

	// RVA: 0x26BDFF0 Offset: 0x26BD1F0 VA: 0x1826BDFF0
	private void SetupReferences() { }

	// RVA: 0x2595160 Offset: 0x2594360 VA: 0x182595160
	internal StyleValueKeyword ReadKeyword(StyleValueHandle handle) { }

	// RVA: 0x26BDAD0 Offset: 0x26BCCD0 VA: 0x1826BDAD0
	internal float ReadFloat(StyleValueHandle handle) { }

	// RVA: 0x26BE810 Offset: 0x26BDA10 VA: 0x1826BE810
	internal bool TryReadFloat(StyleValueHandle handle, out float value) { }

	// RVA: 0x26BD9C0 Offset: 0x26BCBC0 VA: 0x1826BD9C0
	internal Dimension ReadDimension(StyleValueHandle handle) { }

	// RVA: 0x26BE6B0 Offset: 0x26BD8B0 VA: 0x1826BE6B0
	internal bool TryReadDimension(StyleValueHandle handle, out Dimension value) { }

	// RVA: 0x26BD940 Offset: 0x26BCB40 VA: 0x1826BD940
	internal Color ReadColor(StyleValueHandle handle) { }

	// RVA: 0x26BE640 Offset: 0x26BD840 VA: 0x1826BE640
	internal bool TryReadColor(StyleValueHandle handle, out Color value) { }

	// RVA: 0x26BDF30 Offset: 0x26BD130 VA: 0x1826BDF30
	internal string ReadString(StyleValueHandle handle) { }

	// RVA: 0x26BE950 Offset: 0x26BDB50 VA: 0x1826BE950
	internal bool TryReadString(StyleValueHandle handle, out string value) { }

	// RVA: 0x26BDA70 Offset: 0x26BCC70 VA: 0x1826BDA70
	internal string ReadEnum(StyleValueHandle handle) { }

	// RVA: 0x26BE7A0 Offset: 0x26BD9A0 VA: 0x1826BE7A0
	internal bool TryReadEnum(StyleValueHandle handle, out string value) { }

	// RVA: 0x26BDF90 Offset: 0x26BD190 VA: 0x1826BDF90
	internal string ReadVariable(StyleValueHandle handle) { }

	// RVA: 0x26BE9C0 Offset: 0x26BDBC0 VA: 0x1826BE9C0
	internal bool TryReadVariable(StyleValueHandle handle, out string value) { }

	// RVA: 0x26BDE50 Offset: 0x26BD050 VA: 0x1826BDE50
	internal string ReadResourcePath(StyleValueHandle handle) { }

	// RVA: 0x26BE8E0 Offset: 0x26BDAE0 VA: 0x1826BE8E0
	internal bool TryReadResourcePath(StyleValueHandle handle, out string value) { }

	// RVA: 0x26BD8E0 Offset: 0x26BCAE0 VA: 0x1826BD8E0
	internal Object ReadAssetReference(StyleValueHandle handle) { }

	// RVA: 0x26BDDF0 Offset: 0x26BCFF0 VA: 0x1826BDDF0
	internal string ReadMissingAssetReferenceUrl(StyleValueHandle handle) { }

	// RVA: 0x26BE5D0 Offset: 0x26BD7D0 VA: 0x1826BE5D0
	internal bool TryReadAssetReference(StyleValueHandle handle, out Object value) { }

	// RVA: 0x2595160 Offset: 0x2594360 VA: 0x182595160
	internal StyleValueFunction ReadFunction(StyleValueHandle handle) { }

	// RVA: 0x26BDB70 Offset: 0x26BCD70 VA: 0x1826BDB70
	internal string ReadFunctionName(StyleValueHandle handle) { }

	// RVA: 0x26BDEB0 Offset: 0x26BD0B0 VA: 0x1826BDEB0
	internal ScalableImage ReadScalableImage(StyleValueHandle handle) { }

	// RVA: 0x26BD660 Offset: 0x26BC860 VA: 0x1826BD660
	private static bool CustomStartsWith(string originalString, string pattern) { }

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	public void .ctor() { }

	// RVA: 0x26BEA30 Offset: 0x26BDC30 VA: 0x1826BEA30
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements
internal enum StyleValueFunction // TypeDefIndex: 11529
{
	// Fields
	public int value__; // 0x0
	public const StyleValueFunction Unknown = 0;
	public const StyleValueFunction Var = 1;
	public const StyleValueFunction Env = 2;
	public const StyleValueFunction LinearGradient = 3;
}

// Namespace: UnityEngine.UIElements
[Extension]
internal static class StyleValueFunctionExtension // TypeDefIndex: 11530
{
	// Methods

	[Extension]
	// RVA: 0x26C0380 Offset: 0x26BF580 VA: 0x1826C0380
	public static string ToUssString(StyleValueFunction svf) { }
}

// Namespace: UnityEngine.UIElements
[Serializable]
internal struct StyleValueHandle // TypeDefIndex: 11531
{
	// Fields
	[SerializeField]
	private StyleValueType m_ValueType; // 0x0
	[SerializeField]
	internal int valueIndex; // 0x4

	// Properties
	public StyleValueType valueType { get; set; }

	// Methods

	// RVA: 0x244E020 Offset: 0x244D220 VA: 0x18244E020
	public StyleValueType get_valueType() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	internal void set_valueType(StyleValueType value) { }
}

// Namespace: UnityEngine.UIElements
internal enum StyleValueKeyword // TypeDefIndex: 11532
{
	// Fields
	public int value__; // 0x0
	public const StyleValueKeyword Inherit = 0;
	public const StyleValueKeyword Initial = 1;
	public const StyleValueKeyword Auto = 2;
	public const StyleValueKeyword Unset = 3;
	public const StyleValueKeyword True = 4;
	public const StyleValueKeyword False = 5;
	public const StyleValueKeyword None = 6;
}

// Namespace: UnityEngine.UIElements
[Extension]
internal static class StyleValueKeywordExtension // TypeDefIndex: 11533
{
	// Methods

	[Extension]
	// RVA: 0x26C0490 Offset: 0x26BF690 VA: 0x1826C0490
	public static string ToUssString(StyleValueKeyword svk) { }
}

// Namespace: UnityEngine.UIElements
internal enum StyleValueType // TypeDefIndex: 11534
{
	// Fields
	public int value__; // 0x0
	public const StyleValueType Invalid = 0;
	public const StyleValueType Keyword = 1;
	public const StyleValueType Float = 2;
	public const StyleValueType Dimension = 3;
	public const StyleValueType Color = 4;
	public const StyleValueType ResourcePath = 5;
	public const StyleValueType AssetReference = 6;
	public const StyleValueType Enum = 7;
	public const StyleValueType Variable = 8;
	public const StyleValueType String = 9;
	public const StyleValueType Function = 10;
	public const StyleValueType CommaSeparator = 11;
	public const StyleValueType ScalableImage = 12;
	public const StyleValueType MissingAssetReference = 13;
}

// Namespace: UnityEngine.UIElements
internal struct StyleVariable // TypeDefIndex: 11535
{
	// Fields
	public readonly string name; // 0x0
	public readonly StyleSheet sheet; // 0x8
	public readonly StyleValueHandle[] handles; // 0x10

	// Methods

	// RVA: 0xD45610 Offset: 0xD44810 VA: 0x180D45610
	public void .ctor(string name, StyleSheet sheet, StyleValueHandle[] handles) { }

	// RVA: 0x26C1F80 Offset: 0x26C1180 VA: 0x1826C1F80 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
[CompilerGenerated]
private struct StyleVariableContext.<>c__DisplayClass7_0 // TypeDefIndex: 11536
{
	// Fields
	public int hash; // 0x0
}

// Namespace: UnityEngine.UIElements
internal class StyleVariableContext // TypeDefIndex: 11537
{
	// Fields
	public static readonly StyleVariableContext none; // 0x0
	private int m_VariableHash; // 0x10
	private List<StyleVariable> m_Variables; // 0x18
	private List<int> m_SortedHash; // 0x20
	private List<int> m_UnsortedHash; // 0x28

	// Methods

	// RVA: 0x26C0740 Offset: 0x26BF940 VA: 0x1826C0740
	public void Add(StyleVariable sv) { }

	// RVA: 0x26C0630 Offset: 0x26BF830 VA: 0x1826C0630
	public void AddInitialRange(StyleVariableContext other) { }

	// RVA: 0x26C0A10 Offset: 0x26BFC10 VA: 0x1826C0A10
	public void Clear() { }

	// RVA: 0x26C0DF0 Offset: 0x26BFFF0 VA: 0x1826C0DF0
	public void .ctor() { }

	// RVA: 0x26C0CE0 Offset: 0x26BFEE0 VA: 0x1826C0CE0
	public void .ctor(StyleVariableContext other) { }

	// RVA: 0x26C0AC0 Offset: 0x26BFCC0 VA: 0x1826C0AC0
	public bool TryFindVariable(string name, out StyleVariable v) { }

	// RVA: 0x24765D0 Offset: 0x24757D0 VA: 0x1824765D0
	public int GetVariableHash() { }

	// RVA: 0x26C0BD0 Offset: 0x26BFDD0 VA: 0x1826C0BD0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x26C0BC0 Offset: 0x26BFDC0 VA: 0x1826C0BC0
	internal static int <Add>g__ComputeOrderSensitiveHash|7_0(int index, ref StyleVariableContext.<>c__DisplayClass7_0 ) { }
}

// Namespace: 
private enum StyleVariableResolver.Result // TypeDefIndex: 11538
{
	// Fields
	public int value__; // 0x0
	public const StyleVariableResolver.Result Valid = 0;
	public const StyleVariableResolver.Result Invalid = 1;
	public const StyleVariableResolver.Result NotFound = 2;
}

// Namespace: 
private struct StyleVariableResolver.ResolveContext // TypeDefIndex: 11539
{
	// Fields
	public StyleSheet sheet; // 0x0
	public StyleValueHandle[] handles; // 0x8
}

// Namespace: UnityEngine.UIElements
internal class StyleVariableResolver // TypeDefIndex: 11540
{
	// Fields
	internal const int kMaxResolves = 100;
	private static StyleSyntaxParser s_SyntaxParser; // 0x0
	private StylePropertyValueMatcher m_Matcher; // 0x10
	private List<StylePropertyValue> m_ResolvedValues; // 0x18
	private Stack<string> m_ResolvedVarStack; // 0x20
	private StyleProperty m_Property; // 0x28
	private Stack<StyleVariableResolver.ResolveContext> m_ContextStack; // 0x30
	private StyleVariableResolver.ResolveContext m_CurrentContext; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private StyleVariableContext <variableContext>k__BackingField; // 0x48

	// Properties
	private StyleSheet currentSheet { get; }
	private StyleValueHandle[] currentHandles { get; }
	public List<StylePropertyValue> resolvedValues { get; }
	public StyleVariableContext variableContext { get; set; }

	// Methods

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	private StyleSheet get_currentSheet() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	private StyleValueHandle[] get_currentHandles() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public List<StylePropertyValue> get_resolvedValues() { }

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public StyleVariableContext get_variableContext() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_variableContext(StyleVariableContext value) { }

	// RVA: 0x26C0FA0 Offset: 0x26C01A0 VA: 0x1826C0FA0
	public void Init(StyleProperty property, StyleSheet sheet, StyleValueHandle[] handles) { }

	// RVA: 0x26C1270 Offset: 0x26C0470 VA: 0x1826C1270
	private void PushContext(StyleSheet sheet, StyleValueHandle[] handles) { }

	// RVA: 0x26C11F0 Offset: 0x26C03F0 VA: 0x1826C11F0
	private void PopContext() { }

	// RVA: 0x26C0EC0 Offset: 0x26C00C0 VA: 0x1826C0EC0
	public void AddValue(StyleValueHandle handle) { }

	// RVA: 0x26C1700 Offset: 0x26C0900 VA: 0x1826C1700
	public bool ResolveVarFunction(ref int index) { }

	// RVA: 0x26C15C0 Offset: 0x26C07C0 VA: 0x1826C15C0
	private StyleVariableResolver.Result ResolveVarFunction(ref int index, int argc, string varName) { }

	// RVA: 0x26C1C90 Offset: 0x26C0E90 VA: 0x1826C1C90
	public bool ValidateResolvedValues() { }

	// RVA: 0x26C18D0 Offset: 0x26C0AD0 VA: 0x1826C18D0
	private StyleVariableResolver.Result ResolveVariable(string variableName) { }

	// RVA: 0x26C12F0 Offset: 0x26C04F0 VA: 0x1826C12F0
	private StyleVariableResolver.Result ResolveFallback(ref int index) { }

	// RVA: 0x26C10A0 Offset: 0x26C02A0 VA: 0x1826C10A0
	private static void ParseVarFunction(StyleSheet sheet, StyleValueHandle[] handles, ref int index, out int argCount, out string variableName) { }

	// RVA: 0x26C1E70 Offset: 0x26C1070 VA: 0x1826C1E70
	public void .ctor() { }

	// RVA: 0x26C1E10 Offset: 0x26C1010 VA: 0x1826C1E10
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements
[HelpURL("UIE-tss")]
[Serializable]
public class ThemeStyleSheet : StyleSheet // TypeDefIndex: 11541
{
	// Methods

	// RVA: 0x26C3F50 Offset: 0x26C3150 VA: 0x1826C3F50 Slot: 4
	internal override void OnEnable() { }

	// RVA: 0x26C3F80 Offset: 0x26C3180 VA: 0x1826C3F80
	public void .ctor() { }
}

// Namespace: 
public class TemplateContainer.UxmlFactory : UxmlFactory<TemplateContainer, TemplateContainer.UxmlTraits> // TypeDefIndex: 11542
{
	// Properties
	public override string uxmlName { get; }
	public override string uxmlQualifiedName { get; }

	// Methods

	// RVA: 0x26C7D00 Offset: 0x26C6F00 VA: 0x1826C7D00 Slot: 4
	public override string get_uxmlName() { }

	// RVA: 0x26C7D30 Offset: 0x26C6F30 VA: 0x1826C7D30 Slot: 6
	public override string get_uxmlQualifiedName() { }

	// RVA: 0x26C7CC0 Offset: 0x26C6EC0 VA: 0x1826C7CC0
	public void .ctor() { }
}

// Namespace: 
public class TemplateContainer.UxmlTraits : BindableElement.UxmlTraits // TypeDefIndex: 11543
{
	// Fields
	private UxmlStringAttributeDescription m_Template; // 0x78

	// Methods

	// RVA: 0x26C7DB0 Offset: 0x26C6FB0 VA: 0x1826C7DB0 Slot: 4
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x26C81D0 Offset: 0x26C73D0 VA: 0x1826C81D0
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements
public class TemplateContainer : BindableElement // TypeDefIndex: 11544
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <templateId>k__BackingField; // 0x3D8
	private VisualElement m_ContentContainer; // 0x3E0
	private VisualTreeAsset m_TemplateSource; // 0x3E8

	// Properties
	public string templateId { get; set; }
	internal VisualTreeAsset templateSource { set; }
	public override VisualElement contentContainer { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x258E850 Offset: 0x258DA50 VA: 0x18258E850
	public string get_templateId() { }

	[CompilerGenerated]
	// RVA: 0x25A10F0 Offset: 0x25A02F0 VA: 0x1825A10F0
	private void set_templateId(string value) { }

	// RVA: 0x2608CC0 Offset: 0x2607EC0 VA: 0x182608CC0
	internal void set_templateSource(VisualTreeAsset value) { }

	// RVA: 0x26C2050 Offset: 0x26C1250 VA: 0x1826C2050
	public void .ctor() { }

	// RVA: 0x26C2020 Offset: 0x26C1220 VA: 0x1826C2020
	public void .ctor(string templateId) { }

	// RVA: 0x26C2080 Offset: 0x26C1280 VA: 0x1826C2080 Slot: 99
	public override VisualElement get_contentContainer() { }

	// RVA: 0x2638670 Offset: 0x2637870 VA: 0x182638670
	internal void SetContentContainer(VisualElement content) { }
}

// Namespace: UnityEngine.UIElements
public class PanelTextSettings : TextSettings // TypeDefIndex: 11545
{
	// Fields
	private static PanelTextSettings s_DefaultPanelTextSettings; // 0x0
	internal static Func<string, Object> EditorGUIUtilityLoad; // 0x8
	internal static Func<SystemLanguage> GetCurrentLanguage; // 0x10
	internal static readonly string s_DefaultEditorPanelTextSettingPath; // 0x18

	// Properties
	internal static PanelTextSettings defaultPanelTextSettings { get; }

	// Methods

	// RVA: 0x26B7E10 Offset: 0x26B7010 VA: 0x1826B7E10
	internal static PanelTextSettings get_defaultPanelTextSettings() { }

	// RVA: 0x26B77B0 Offset: 0x26B69B0 VA: 0x1826B77B0
	internal static void UpdateLocalizationFontAsset() { }

	// RVA: 0x26B77A0 Offset: 0x26B69A0 VA: 0x1826B77A0
	internal FontAsset GetCachedFontAsset(Font font) { }

	// RVA: 0x26B7E00 Offset: 0x26B7000 VA: 0x1826B7E00
	public void .ctor() { }

	// RVA: 0x26B7DB0 Offset: 0x26B6FB0 VA: 0x1826B7DB0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements
internal class TextEditingManipulator // TypeDefIndex: 11546
{
	// Fields
	private TextElement m_TextElement; // 0x10
	internal TextEditorEventHandler editingEventHandler; // 0x18
	internal TextEditingUtilities editingUtilities; // 0x20
	private bool m_TouchScreenTextFieldInitialized; // 0x28
	private IVisualElementScheduledItem m_HardwareKeyboardPoller; // 0x30

	// Properties
	private bool touchScreenTextFieldChanged { get; }

	// Methods

	// RVA: 0x26C2700 Offset: 0x26C1900 VA: 0x1826C2700
	private bool get_touchScreenTextFieldChanged() { }

	// RVA: 0x26C2610 Offset: 0x26C1810 VA: 0x1826C2610
	public void .ctor(TextElement textElement) { }

	// RVA: 0x26C2220 Offset: 0x26C1420 VA: 0x1826C2220
	private void InitTextEditorEventHandler() { }

	// RVA: 0x26C2090 Offset: 0x26C1290 VA: 0x1826C2090
	internal void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x26C22F0 Offset: 0x26C14F0 VA: 0x1826C22F0
	private void OnFocusInEvent(FocusInEvent _) { }

	// RVA: 0x26C2560 Offset: 0x26C1760 VA: 0x1826C2560
	private void OnFocusOutEvent(FocusOutEvent _) { }

	[CompilerGenerated]
	// RVA: 0x26C25C0 Offset: 0x26C17C0 VA: 0x1826C25C0
	private void <OnFocusInEvent>b__10_0() { }
}

// Namespace: UnityEngine.UIElements
internal class TextSelectingManipulator // TypeDefIndex: 11547
{
	// Fields
	internal TextSelectingUtilities m_SelectingUtilities; // 0x10
	private bool selectAllOnMouseUp; // 0x18
	private TextElement m_TextElement; // 0x20
	private Vector2 m_ClickStartPosition; // 0x28
	private bool m_Dragged; // 0x30
	private bool m_IsClicking; // 0x31
	private const int k_DragThresholdSqr = 16;
	private int m_ConsecutiveMouseDownCount; // 0x34
	private long m_LastMouseDownTimeStamp; // 0x38
	private readonly Event m_ImguiEvent; // 0x40

	// Properties
	internal bool isClicking { get; set; }
	internal int cursorIndex { get; set; }
	internal int selectIndex { get; set; }

	// Methods

	// RVA: 0x577B10 Offset: 0x576D10 VA: 0x180577B10
	internal bool get_isClicking() { }

	// RVA: 0x26C3F20 Offset: 0x26C3120 VA: 0x1826C3F20
	internal void set_isClicking(bool value) { }

	// RVA: 0x26C3C20 Offset: 0x26C2E20 VA: 0x1826C3C20
	public void .ctor(TextElement textElement) { }

	// RVA: 0x26C3EC0 Offset: 0x26C30C0 VA: 0x1826C3EC0
	internal int get_cursorIndex() { }

	// RVA: 0x26C3F00 Offset: 0x26C3100 VA: 0x1826C3F00
	internal void set_cursorIndex(int value) { }

	// RVA: 0x26C3EE0 Offset: 0x26C30E0 VA: 0x1826C3EE0
	internal int get_selectIndex() { }

	// RVA: 0x26C3F30 Offset: 0x26C3130 VA: 0x1826C3F30
	internal void set_selectIndex(int value) { }

	// RVA: 0x26C3940 Offset: 0x26C2B40 VA: 0x1826C3940
	private void OnRevealCursor() { }

	// RVA: 0x26C3970 Offset: 0x26C2B70 VA: 0x1826C3970
	private void OnSelectIndexChange() { }

	// RVA: 0x26C2F70 Offset: 0x26C2170 VA: 0x1826C2F70
	private void OnCursorIndexChange() { }

	// RVA: 0x26C3C00 Offset: 0x26C2E00 VA: 0x1826C3C00
	internal bool RevealCursor() { }

	// RVA: 0x26C2EB0 Offset: 0x26C20B0 VA: 0x1826C2EB0
	internal bool HasSelection() { }

	// RVA: 0x26C2E90 Offset: 0x26C2090 VA: 0x1826C2E90
	internal bool HasFocus() { }

	// RVA: 0x26C27A0 Offset: 0x26C19A0 VA: 0x1826C27A0
	internal void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x26C3190 Offset: 0x26C2390 VA: 0x1826C3190
	private void OnFocusEvent(FocusEvent evt) { }

	// RVA: 0x26C2F10 Offset: 0x26C2110 VA: 0x1826C2F10
	private void OnBlurEvent(BlurEvent evt) { }

	// RVA: 0x26C3300 Offset: 0x26C2500 VA: 0x1826C3300
	private void OnKeyDown(KeyDownEvent evt) { }

	// RVA: 0x26C3370 Offset: 0x26C2570 VA: 0x1826C3370
	private void OnPointerDownEvent(PointerDownEvent evt) { }

	// RVA: 0x26C36F0 Offset: 0x26C28F0 VA: 0x1826C36F0
	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	// RVA: 0x26C3890 Offset: 0x26C2A90 VA: 0x1826C3890
	private void OnPointerUpEvent(PointerUpEvent evt) { }

	// RVA: 0x26C3A80 Offset: 0x26C2C80 VA: 0x1826C3A80
	private void OnValidateCommandEvent(ValidateCommandEvent evt) { }

	// RVA: 0x26C3080 Offset: 0x26C2280 VA: 0x1826C3080
	private void OnExecuteCommandEvent(ExecuteCommandEvent evt) { }

	// RVA: 0x26C2ED0 Offset: 0x26C20D0 VA: 0x1826C2ED0
	private bool MoveDistanceQualifiesForDrag(Vector2 start, Vector2 current) { }
}

// Namespace: UnityEngine.UIElements
internal class UITKTextHandle : TextHandle // TypeDefIndex: 11548
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Vector2 <MeasuredSizes>k__BackingField; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Vector2 <RoundedSizes>k__BackingField; // 0x40
	private TextElement m_TextElement; // 0x48
	internal bool isOverridingCursor; // 0x50
	internal int currentLinkIDHash; // 0x54
	internal bool hasLinkTag; // 0x58
	internal bool hasATag; // 0x59
	internal static readonly float k_MinPadding; // 0x0

	// Properties
	public Vector2 MeasuredSizes { get; set; }
	public Vector2 RoundedSizes { get; set; }

	// Methods

	// RVA: 0x26C7C10 Offset: 0x26C6E10 VA: 0x1826C7C10
	public void .ctor(TextElement te) { }

	[CompilerGenerated]
	// RVA: 0x26C7C80 Offset: 0x26C6E80 VA: 0x1826C7C80
	public Vector2 get_MeasuredSizes() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_MeasuredSizes(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x26C7CA0 Offset: 0x26C6EA0 VA: 0x1826C7CA0
	public Vector2 get_RoundedSizes() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_RoundedSizes(Vector2 value) { }

	// RVA: 0x26C5C90 Offset: 0x26C4E90 VA: 0x1826C5C90
	public float ComputeTextWidth(string textToMeasure, bool wordWrap, float width, float height) { }

	// RVA: 0x26C5B90 Offset: 0x26C4D90 VA: 0x1826C5B90
	public float ComputeTextHeight(string textToMeasure, float width, float height) { }

	// RVA: 0x26C7A80 Offset: 0x26C6C80 VA: 0x1826C7A80
	public TextInfo Update() { }

	// RVA: 0x26C59A0 Offset: 0x26C4BA0 VA: 0x1826C59A0
	private void ATagOnPointerUp(PointerUpEvent pue) { }

	// RVA: 0x26C5990 Offset: 0x26C4B90 VA: 0x1826C5990
	private void ATagOnPointerOver(PointerOverEvent _) { }

	// RVA: 0x26C5700 Offset: 0x26C4900 VA: 0x1826C5700
	private void ATagOnPointerMove(PointerMoveEvent pme) { }

	// RVA: 0x26C5990 Offset: 0x26C4B90 VA: 0x1826C5990
	private void ATagOnPointerOut(PointerOutEvent _) { }

	// RVA: 0x26C6E70 Offset: 0x26C6070 VA: 0x1826C6E70
	internal void LinkTagOnPointerDown(PointerDownEvent pde) { }

	// RVA: 0x26C7780 Offset: 0x26C6980 VA: 0x1826C7780
	internal void LinkTagOnPointerUp(PointerUpEvent pue) { }

	// RVA: 0x26C7140 Offset: 0x26C6340 VA: 0x1826C7140
	internal void LinkTagOnPointerMove(PointerMoveEvent pme) { }

	// RVA: 0x26C7630 Offset: 0x26C6830 VA: 0x1826C7630
	private void LinkTagOnPointerOut(PointerOutEvent poe) { }

	// RVA: 0x26C6A90 Offset: 0x26C5C90 VA: 0x1826C6A90
	private void HandleLinkTag() { }

	// RVA: 0x26C6630 Offset: 0x26C5830 VA: 0x1826C6630
	private void HandleATag() { }

	// RVA: 0x26C6530 Offset: 0x26C5730 VA: 0x1826C6530
	private TextOverflowMode GetTextOverflowMode() { }

	// RVA: 0x26C5DB0 Offset: 0x26C4FB0 VA: 0x1826C5DB0
	internal void ConvertUssToTextGenerationSettings(TextGenerationSettings tgs) { }

	// RVA: 0x26C7A50 Offset: 0x26C6C50 VA: 0x1826C7A50
	internal bool TextLibraryCanElide() { }

	// RVA: 0x26C62F0 Offset: 0x26C54F0 VA: 0x1826C62F0
	internal float GetTextEffectPadding(FontAsset fontAsset) { }

	// RVA: 0x26C7BD0 Offset: 0x26C6DD0 VA: 0x1826C7BD0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements
internal static class TextUtilities // TypeDefIndex: 11549
{
	// Methods

	// RVA: 0x25A2260 Offset: 0x25A1460 VA: 0x1825A2260
	internal static Vector2 MeasureVisualElementTextSize(TextElement te, string textToMeasure, float width, VisualElement.MeasureMode widthMode, float height, VisualElement.MeasureMode heightMode) { }

	// RVA: 0x25A1780 Offset: 0x25A0980 VA: 0x1825A1780
	internal static FontAsset GetFontAsset(VisualElement ve) { }

	// RVA: 0x25A2190 Offset: 0x25A1390 VA: 0x1825A2190
	internal static bool IsFontAssigned(VisualElement ve) { }

	// RVA: 0x25A20C0 Offset: 0x25A12C0 VA: 0x1825A20C0
	internal static PanelTextSettings GetTextSettingsFrom(VisualElement ve) { }

	// RVA: 0x25A1670 Offset: 0x25A0870 VA: 0x1825A1670
	internal static float ConvertPixelUnitsToTextCoreRelativeUnits(VisualElement ve, FontAsset fontAsset) { }

	// RVA: 0x25A1A20 Offset: 0x25A0C20 VA: 0x1825A1A20
	internal static TextCoreSettings GetTextCoreSettingsForElement(VisualElement ve) { }
}

// Namespace: 
public class TextElement.UxmlFactory : UxmlFactory<TextElement, TextElement.UxmlTraits> // TypeDefIndex: 11550
{
	// Methods

	// RVA: 0x25ABCD0 Offset: 0x25AAED0 VA: 0x1825ABCD0
	public void .ctor() { }
}

// Namespace: 
public class TextElement.UxmlTraits : BindableElement.UxmlTraits // TypeDefIndex: 11551
{
	// Fields
	private UxmlStringAttributeDescription m_Text; // 0x78
	private UxmlBoolAttributeDescription m_EnableRichText; // 0x80
	private UxmlBoolAttributeDescription m_ParseEscapeSequences; // 0x88
	private UxmlBoolAttributeDescription m_DisplayTooltipWhenElided; // 0x90

	// Methods

	// RVA: 0x25ADA00 Offset: 0x25ACC00 VA: 0x1825ADA00 Slot: 4
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x25ADC40 Offset: 0x25ACE40 VA: 0x1825ADC40
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements
public class TextElement : BindableElement, INotifyValueChanged<string>, ITextEdition, IExperimentalFeatures, ITextSelection // TypeDefIndex: 11552
{
	// Fields
	public static readonly string ussClassName; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private UITKTextHandle <uitkTextHandle>k__BackingField; // 0x3D8
	private string m_Text; // 0x3E0
	private bool m_EnableRichText; // 0x3E8
	private bool m_ParseEscapeSequences; // 0x3E9
	private bool m_DisplayTooltipWhenElided; // 0x3EA
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <isElided>k__BackingField; // 0x3EB
	internal static readonly string k_EllipsisText; // 0x8
	internal string elidedText; // 0x3F0
	private bool m_WasElided; // 0x3F8
	internal TextEditingManipulator editingManipulator; // 0x400
	private bool m_Multiline; // 0x408
	internal TouchScreenKeyboard m_TouchScreenKeyboard; // 0x410
	internal TouchScreenKeyboardType m_KeyboardType; // 0x418
	private bool m_HideMobileInput; // 0x41C
	private bool m_IsReadOnly; // 0x41D
	private int m_MaxLength; // 0x420
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <UnityEngine.UIElements.ITextEdition.isDelayed>k__BackingField; // 0x424
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Func<char, bool> <UnityEngine.UIElements.ITextEdition.AcceptCharacter>k__BackingField; // 0x428
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<bool> <UnityEngine.UIElements.ITextEdition.UpdateScrollOffset>k__BackingField; // 0x430
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action <UnityEngine.UIElements.ITextEdition.UpdateValueFromText>k__BackingField; // 0x438
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action <UnityEngine.UIElements.ITextEdition.UpdateTextFromValue>k__BackingField; // 0x440
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action <UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot>k__BackingField; // 0x448
	private string m_RenderedText; // 0x450
	private string m_OriginalText; // 0x458
	private char m_MaskChar; // 0x460
	private bool m_IsPassword; // 0x462
	private bool m_AutoCorrection; // 0x463
	private TextSelectingManipulator m_SelectingManipulator; // 0x468
	private bool m_IsSelectable; // 0x470
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord>k__BackingField; // 0x471
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine>k__BackingField; // 0x472
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <UnityEngine.UIElements.ITextSelection.selectAllOnFocus>k__BackingField; // 0x473
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp>k__BackingField; // 0x474
	private Color m_SelectionColor; // 0x478
	private Color m_CursorColor; // 0x488
	private float m_CursorWidth; // 0x498

	// Properties
	internal UITKTextHandle uitkTextHandle { get; set; }
	public virtual string text { get; set; }
	public bool enableRichText { get; set; }
	public bool parseEscapeSequences { get; set; }
	public bool displayTooltipWhenElided { get; set; }
	public bool isElided { get; set; }
	internal bool hasFocus { get; }
	private string UnityEngine.UIElements.INotifyValueChanged<System.String>.value { get; set; }
	internal ITextEdition edition { get; }
	private bool UnityEngine.UIElements.ITextEdition.multiline { get; set; }
	private TouchScreenKeyboardType UnityEngine.UIElements.ITextEdition.keyboardType { get; set; }
	private bool UnityEngine.UIElements.ITextEdition.hideMobileInput { get; set; }
	private bool UnityEngine.UIElements.ITextEdition.isReadOnly { get; set; }
	private int UnityEngine.UIElements.ITextEdition.maxLength { get; set; }
	private bool UnityEngine.UIElements.ITextEdition.isDelayed { get; set; }
	private Func<char, bool> UnityEngine.UIElements.ITextEdition.AcceptCharacter { get; set; }
	private Action<bool> UnityEngine.UIElements.ITextEdition.UpdateScrollOffset { get; set; }
	private Action UnityEngine.UIElements.ITextEdition.UpdateValueFromText { get; set; }
	private Action UnityEngine.UIElements.ITextEdition.UpdateTextFromValue { get; set; }
	private Action UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot { get; set; }
	private char UnityEngine.UIElements.ITextEdition.maskChar { set; }
	private char effectiveMaskChar { get; }
	private bool UnityEngine.UIElements.ITextEdition.isPassword { get; set; }
	private bool UnityEngine.UIElements.ITextEdition.autoCorrection { get; set; }
	internal string renderedText { get; set; }
	internal string originalText { get; }
	public ITextSelection selection { get; }
	private bool UnityEngine.UIElements.ITextSelection.isSelectable { get; set; }
	private int UnityEngine.UIElements.ITextSelection.cursorIndex { get; set; }
	private int UnityEngine.UIElements.ITextSelection.selectIndex { get; set; }
	private bool UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord { get; }
	private bool UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine { get; }
	private bool UnityEngine.UIElements.ITextSelection.selectAllOnFocus { get; set; }
	private bool UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp { get; set; }
	private Vector2 UnityEngine.UIElements.ITextSelection.cursorPosition { get; }
	private float UnityEngine.UIElements.ITextSelection.lineHeightAtCursorPosition { get; }
	private Color UnityEngine.UIElements.ITextSelection.selectionColor { get; set; }
	private Color UnityEngine.UIElements.ITextSelection.cursorColor { get; set; }
	private float UnityEngine.UIElements.ITextSelection.cursorWidth { get; }
	internal TextSelectingManipulator selectingManipulator { get; }

	// Methods

	// RVA: 0x25A0A80 Offset: 0x259FC80 VA: 0x1825A0A80
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x258E850 Offset: 0x258DA50 VA: 0x18258E850
	internal UITKTextHandle get_uitkTextHandle() { }

	[CompilerGenerated]
	// RVA: 0x25A10F0 Offset: 0x25A02F0 VA: 0x1825A10F0
	internal void set_uitkTextHandle(UITKTextHandle value) { }

	// RVA: 0x259F650 Offset: 0x259E850 VA: 0x18259F650
	private void OnGeometryChanged(GeometryChangedEvent e) { }

	// RVA: 0x25A0F80 Offset: 0x25A0180 VA: 0x1825A0F80 Slot: 158
	public virtual string get_text() { }

	// RVA: 0x25A10A0 Offset: 0x25A02A0 VA: 0x1825A10A0 Slot: 159
	public virtual void set_text(string value) { }

	// RVA: 0x258E860 Offset: 0x258DA60 VA: 0x18258E860
	public bool get_enableRichText() { }

	// RVA: 0x25A1000 Offset: 0x25A0200 VA: 0x1825A1000
	public void set_enableRichText(bool value) { }

	// RVA: 0x25A0DB0 Offset: 0x259FFB0 VA: 0x1825A0DB0
	public bool get_parseEscapeSequences() { }

	// RVA: 0x25A1030 Offset: 0x25A0230 VA: 0x1825A1030
	public void set_parseEscapeSequences(bool value) { }

	// RVA: 0x25A0CB0 Offset: 0x259FEB0 VA: 0x1825A0CB0
	public bool get_displayTooltipWhenElided() { }

	// RVA: 0x25A0FC0 Offset: 0x25A01C0 VA: 0x1825A0FC0
	public void set_displayTooltipWhenElided(bool value) { }

	[CompilerGenerated]
	// RVA: 0x25A0DA0 Offset: 0x259FFA0 VA: 0x1825A0DA0
	public bool get_isElided() { }

	[CompilerGenerated]
	// RVA: 0x25A1020 Offset: 0x25A0220 VA: 0x1825A1020
	private void set_isElided(bool value) { }

	// RVA: 0x259F470 Offset: 0x259E670 VA: 0x18259F470
	internal void OnGenerateVisualContent(MeshGenerationContext mgc) { }

	// RVA: 0x259EAC0 Offset: 0x259DCC0 VA: 0x18259EAC0
	internal string ElideText(string drawText, string ellipsisText, float width, TextOverflowPosition textOverflowPosition) { }

	// RVA: 0x25A0810 Offset: 0x259FA10 VA: 0x1825A0810
	private void UpdateTooltip() { }

	// RVA: 0x25A0890 Offset: 0x259FA90 VA: 0x1825A0890
	private void UpdateVisibleText() { }

	// RVA: 0x259F800 Offset: 0x259EA00 VA: 0x18259F800
	private bool ShouldElide() { }

	// RVA: 0x25A0D20 Offset: 0x259FF20 VA: 0x1825A0D20
	internal bool get_hasFocus() { }

	// RVA: 0x259F440 Offset: 0x259E640 VA: 0x18259F440
	public Vector2 MeasureTextSize(string textToMeasure, float width, VisualElement.MeasureMode widthMode, float height, VisualElement.MeasureMode heightMode) { }

	// RVA: 0x259DC60 Offset: 0x259CE60 VA: 0x18259DC60 Slot: 98
	protected internal override Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode) { }

	// RVA: 0x259F950 Offset: 0x259EB50 VA: 0x18259F950 Slot: 102
	private string UnityEngine.UIElements.INotifyValueChanged<System.String>.get_value() { }

	// RVA: 0x259F9A0 Offset: 0x259EBA0 VA: 0x18259F9A0 Slot: 103
	private void UnityEngine.UIElements.INotifyValueChanged<System.String>.set_value(string value) { }

	// RVA: 0x259F850 Offset: 0x259EA50 VA: 0x18259F850 Slot: 104
	private void UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify(string newValue) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	internal ITextEdition get_edition() { }

	// RVA: 0xEB89F0 Offset: 0xEB7BF0 VA: 0x180EB89F0 Slot: 105
	private bool UnityEngine.UIElements.ITextEdition.get_multiline() { }

	// RVA: 0x25A0170 Offset: 0x259F370 VA: 0x1825A0170 Slot: 106
	private void UnityEngine.UIElements.ITextEdition.set_multiline(bool value) { }

	// RVA: 0x259FED0 Offset: 0x259F0D0 VA: 0x18259FED0 Slot: 134
	private TouchScreenKeyboardType UnityEngine.UIElements.ITextEdition.get_keyboardType() { }

	// RVA: 0x25A0060 Offset: 0x259F260 VA: 0x1825A0060 Slot: 135
	private void UnityEngine.UIElements.ITextEdition.set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x259FE10 Offset: 0x259F010 VA: 0x18259FE10 Slot: 132
	private bool UnityEngine.UIElements.ITextEdition.get_hideMobileInput() { }

	// RVA: 0x259FF30 Offset: 0x259F130 VA: 0x18259FF30 Slot: 133
	private void UnityEngine.UIElements.ITextEdition.set_hideMobileInput(bool value) { }

	// RVA: 0x259FEA0 Offset: 0x259F0A0 VA: 0x18259FEA0 Slot: 107
	private bool UnityEngine.UIElements.ITextEdition.get_isReadOnly() { }

	// RVA: 0x259FFE0 Offset: 0x259F1E0 VA: 0x18259FFE0 Slot: 108
	private void UnityEngine.UIElements.ITextEdition.set_isReadOnly(bool value) { }

	// RVA: 0x259F710 Offset: 0x259E910 VA: 0x18259F710
	private void ProcessMenuCommand(string command) { }

	// RVA: 0x259DC20 Offset: 0x259CE20 VA: 0x18259DC20
	private void Cut(DropdownMenuAction a) { }

	// RVA: 0x259DB50 Offset: 0x259CD50 VA: 0x18259DB50
	private void Copy(DropdownMenuAction a) { }

	// RVA: 0x259F6D0 Offset: 0x259E8D0 VA: 0x18259F6D0
	private void Paste(DropdownMenuAction a) { }

	// RVA: 0x259D770 Offset: 0x259C970 VA: 0x18259D770
	private void BuildContextualMenu(ContextualMenuPopulateEvent evt) { }

	// RVA: 0x259DB90 Offset: 0x259CD90 VA: 0x18259DB90
	private DropdownMenuAction.Status CutActionStatus(DropdownMenuAction a) { }

	// RVA: 0x259DAC0 Offset: 0x259CCC0 VA: 0x18259DAC0
	private DropdownMenuAction.Status CopyActionStatus(DropdownMenuAction a) { }

	// RVA: 0x259F660 Offset: 0x259E860 VA: 0x18259F660
	private DropdownMenuAction.Status PasteActionStatus(DropdownMenuAction a) { }

	[EventInterest(new[] { typeof(ContextualMenuPopulateEvent), typeof(FocusInEvent), typeof(FocusOutEvent), typeof(KeyDownEvent), typeof(KeyUpEvent), typeof(FocusEvent), typeof(BlurEvent), typeof(ValidateCommandEvent), typeof(ExecuteCommandEvent), typeof(PointerDownEvent), typeof(PointerUpEvent), typeof(PointerMoveEvent), typeof(NavigationMoveEvent), typeof(NavigationSubmitEvent), typeof(NavigationCancelEvent) })]
	// RVA: 0x259EF30 Offset: 0x259E130 VA: 0x18259EF30 Slot: 11
	protected override void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x259FEE0 Offset: 0x259F0E0 VA: 0x18259FEE0 Slot: 109
	private int UnityEngine.UIElements.ITextEdition.get_maxLength() { }

	// RVA: 0x25A00E0 Offset: 0x259F2E0 VA: 0x1825A00E0 Slot: 110
	private void UnityEngine.UIElements.ITextEdition.set_maxLength(int value) { }

	[CompilerGenerated]
	// RVA: 0x259FE80 Offset: 0x259F080 VA: 0x18259FE80 Slot: 111
	private bool UnityEngine.UIElements.ITextEdition.get_isDelayed() { }

	[CompilerGenerated]
	// RVA: 0x259FFB0 Offset: 0x259F1B0 VA: 0x18259FFB0 Slot: 112
	private void UnityEngine.UIElements.ITextEdition.set_isDelayed(bool value) { }

	// RVA: 0x259FBE0 Offset: 0x259EDE0 VA: 0x18259FBE0 Slot: 113
	private void UnityEngine.UIElements.ITextEdition.SaveValueAndText() { }

	// RVA: 0x259FBC0 Offset: 0x259EDC0 VA: 0x18259FBC0 Slot: 114
	private void UnityEngine.UIElements.ITextEdition.RestoreValueAndText() { }

	[CompilerGenerated]
	// RVA: 0x259FDF0 Offset: 0x259EFF0 VA: 0x18259FDF0 Slot: 115
	private Func<char, bool> UnityEngine.UIElements.ITextEdition.get_AcceptCharacter() { }

	[CompilerGenerated]
	// RVA: 0x259FEF0 Offset: 0x259F0F0 VA: 0x18259FEF0 Slot: 116
	private void UnityEngine.UIElements.ITextEdition.set_AcceptCharacter(Func<char, bool> value) { }

	[CompilerGenerated]
	// RVA: 0xEAE3E0 Offset: 0xEAD5E0 VA: 0x180EAE3E0 Slot: 117
	private Action<bool> UnityEngine.UIElements.ITextEdition.get_UpdateScrollOffset() { }

	[CompilerGenerated]
	// RVA: 0x259FF00 Offset: 0x259F100 VA: 0x18259FF00 Slot: 118
	private void UnityEngine.UIElements.ITextEdition.set_UpdateScrollOffset(Action<bool> value) { }

	[CompilerGenerated]
	// RVA: 0xEAE3C0 Offset: 0xEAD5C0 VA: 0x180EAE3C0 Slot: 119
	private Action UnityEngine.UIElements.ITextEdition.get_UpdateValueFromText() { }

	[CompilerGenerated]
	// RVA: 0x259FF10 Offset: 0x259F110 VA: 0x18259FF10 Slot: 120
	private void UnityEngine.UIElements.ITextEdition.set_UpdateValueFromText(Action value) { }

	[CompilerGenerated]
	// RVA: 0xEAE3D0 Offset: 0xEAD5D0 VA: 0x180EAE3D0 Slot: 121
	private Action UnityEngine.UIElements.ITextEdition.get_UpdateTextFromValue() { }

	[CompilerGenerated]
	// RVA: 0xED6C60 Offset: 0xED5E60 VA: 0x180ED6C60 Slot: 122
	private void UnityEngine.UIElements.ITextEdition.set_UpdateTextFromValue(Action value) { }

	[CompilerGenerated]
	// RVA: 0xC7ED50 Offset: 0xC7DF50 VA: 0x180C7ED50 Slot: 123
	private Action UnityEngine.UIElements.ITextEdition.get_MoveFocusToCompositeRoot() { }

	[CompilerGenerated]
	// RVA: 0xED6C70 Offset: 0xED5E70 VA: 0x180ED6C70 Slot: 124
	private void UnityEngine.UIElements.ITextEdition.set_MoveFocusToCompositeRoot(Action value) { }

	// RVA: 0x259FC10 Offset: 0x259EE10 VA: 0x18259FC10 Slot: 125
	private void UnityEngine.UIElements.ITextEdition.UpdateText(string value) { }

	// RVA: 0x259FB40 Offset: 0x259ED40 VA: 0x18259FB40 Slot: 126
	private string UnityEngine.UIElements.ITextEdition.CullString(string s) { }

	// RVA: 0x25A0070 Offset: 0x259F270 VA: 0x1825A0070 Slot: 127
	private void UnityEngine.UIElements.ITextEdition.set_maskChar(char value) { }

	// RVA: 0x25A0CC0 Offset: 0x259FEC0 VA: 0x1825A0CC0
	private char get_effectiveMaskChar() { }

	// RVA: 0x259FE90 Offset: 0x259F090 VA: 0x18259FE90 Slot: 128
	private bool UnityEngine.UIElements.ITextEdition.get_isPassword() { }

	// RVA: 0x259FFC0 Offset: 0x259F1C0 VA: 0x18259FFC0 Slot: 129
	private void UnityEngine.UIElements.ITextEdition.set_isPassword(bool value) { }

	// RVA: 0x259FE00 Offset: 0x259F000 VA: 0x18259FE00 Slot: 130
	private bool UnityEngine.UIElements.ITextEdition.get_autoCorrection() { }

	// RVA: 0x259FF20 Offset: 0x259F120 VA: 0x18259FF20 Slot: 131
	private void UnityEngine.UIElements.ITextEdition.set_autoCorrection(bool value) { }

	// RVA: 0x25A0DC0 Offset: 0x259FFC0 VA: 0x1825A0DC0
	internal string get_renderedText() { }

	// RVA: 0x25A1050 Offset: 0x25A0250 VA: 0x1825A1050
	internal void set_renderedText(string value) { }

	// RVA: 0xED6A30 Offset: 0xED5C30 VA: 0x180ED6A30
	internal string get_originalText() { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	public ITextSelection get_selection() { }

	// RVA: 0x25A0490 Offset: 0x259F690 VA: 0x1825A0490 Slot: 136
	private bool UnityEngine.UIElements.ITextSelection.get_isSelectable() { }

	// RVA: 0x25A06D0 Offset: 0x259F8D0 VA: 0x1825A06D0 Slot: 137
	private void UnityEngine.UIElements.ITextSelection.set_isSelectable(bool value) { }

	// RVA: 0x25A0350 Offset: 0x259F550 VA: 0x1825A0350 Slot: 140
	private int UnityEngine.UIElements.ITextSelection.get_cursorIndex() { }

	// RVA: 0x25A0650 Offset: 0x259F850 VA: 0x1825A0650 Slot: 141
	private void UnityEngine.UIElements.ITextSelection.set_cursorIndex(int value) { }

	// RVA: 0x25A0540 Offset: 0x259F740 VA: 0x1825A0540 Slot: 143
	private int UnityEngine.UIElements.ITextSelection.get_selectIndex() { }

	// RVA: 0x25A0710 Offset: 0x259F910 VA: 0x1825A0710 Slot: 144
	private void UnityEngine.UIElements.ITextSelection.set_selectIndex(int value) { }

	// RVA: 0x25A0260 Offset: 0x259F460 VA: 0x1825A0260 Slot: 149
	private void UnityEngine.UIElements.ITextSelection.SelectAll() { }

	// RVA: 0x25A02D0 Offset: 0x259F4D0 VA: 0x1825A02D0 Slot: 150
	private void UnityEngine.UIElements.ITextSelection.SelectNone() { }

	// RVA: 0x25A01F0 Offset: 0x259F3F0 VA: 0x1825A01F0 Slot: 148
	private bool UnityEngine.UIElements.ITextSelection.HasSelection() { }

	[CompilerGenerated]
	// RVA: 0x25A0480 Offset: 0x259F680 VA: 0x1825A0480 Slot: 142
	private bool UnityEngine.UIElements.ITextSelection.get_doubleClickSelectsWord() { }

	[CompilerGenerated]
	// RVA: 0x25A05C0 Offset: 0x259F7C0 VA: 0x1825A05C0 Slot: 147
	private bool UnityEngine.UIElements.ITextSelection.get_tripleClickSelectsLine() { }

	[CompilerGenerated]
	// RVA: 0x25A0520 Offset: 0x259F720 VA: 0x1825A0520 Slot: 151
	private bool UnityEngine.UIElements.ITextSelection.get_selectAllOnFocus() { }

	[CompilerGenerated]
	// RVA: 0x25A06F0 Offset: 0x259F8F0 VA: 0x1825A06F0 Slot: 152
	private void UnityEngine.UIElements.ITextSelection.set_selectAllOnFocus(bool value) { }

	[CompilerGenerated]
	// RVA: 0x25A0530 Offset: 0x259F730 VA: 0x1825A0530 Slot: 153
	private bool UnityEngine.UIElements.ITextSelection.get_selectAllOnMouseUp() { }

	[CompilerGenerated]
	// RVA: 0x25A0700 Offset: 0x259F900 VA: 0x1825A0700 Slot: 154
	private void UnityEngine.UIElements.ITextSelection.set_selectAllOnMouseUp(bool value) { }

	// RVA: 0x25A03C0 Offset: 0x259F5C0 VA: 0x1825A03C0 Slot: 155
	private Vector2 UnityEngine.UIElements.ITextSelection.get_cursorPosition() { }

	// RVA: 0x25A04B0 Offset: 0x259F6B0 VA: 0x1825A04B0 Slot: 156
	private float UnityEngine.UIElements.ITextSelection.get_lineHeightAtCursorPosition() { }

	// RVA: 0x25A05B0 Offset: 0x259F7B0 VA: 0x1825A05B0 Slot: 145
	private Color UnityEngine.UIElements.ITextSelection.get_selectionColor() { }

	// RVA: 0x25A0790 Offset: 0x259F990 VA: 0x1825A0790 Slot: 146
	private void UnityEngine.UIElements.ITextSelection.set_selectionColor(Color value) { }

	// RVA: 0x25A0340 Offset: 0x259F540 VA: 0x1825A0340 Slot: 138
	private Color UnityEngine.UIElements.ITextSelection.get_cursorColor() { }

	// RVA: 0x25A05D0 Offset: 0x259F7D0 VA: 0x1825A05D0 Slot: 139
	private void UnityEngine.UIElements.ITextSelection.set_cursorColor(Color value) { }

	// RVA: 0x25A0470 Offset: 0x259F670 VA: 0x1825A0470 Slot: 157
	private float UnityEngine.UIElements.ITextSelection.get_cursorWidth() { }

	// RVA: 0x25A0F10 Offset: 0x25A0110 VA: 0x1825A0F10
	internal TextSelectingManipulator get_selectingManipulator() { }

	// RVA: 0x259E170 Offset: 0x259D370 VA: 0x18259E170
	private void DrawHighlighting(MeshGenerationContext mgc) { }

	// RVA: 0x259DE00 Offset: 0x259D000 VA: 0x18259DE00
	internal void DrawCaret(MeshGenerationContext mgc) { }

	// RVA: 0x259F1F0 Offset: 0x259E3F0 VA: 0x18259F1F0
	private int GetLastCharacterAt(int lineIndex) { }

	// RVA: 0x25A0A10 Offset: 0x259FC10 VA: 0x1825A0A10
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements
public interface ITextEdition // TypeDefIndex: 11553
{
	// Properties
	internal abstract bool multiline { get; set; }
	public abstract bool isReadOnly { get; set; }
	public abstract int maxLength { get; set; }
	public abstract bool isDelayed { get; set; }
	internal abstract Func<char, bool> AcceptCharacter { get; set; }
	internal abstract Action<bool> UpdateScrollOffset { get; set; }
	internal abstract Action UpdateValueFromText { get; set; }
	internal abstract Action UpdateTextFromValue { get; set; }
	internal abstract Action MoveFocusToCompositeRoot { get; set; }
	public abstract char maskChar { set; }
	public abstract bool isPassword { get; set; }
	public virtual bool autoCorrection { get; set; }
	public virtual bool hideMobileInput { get; set; }
	public virtual TouchScreenKeyboardType keyboardType { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	internal abstract bool get_multiline();

	// RVA: -1 Offset: -1 Slot: 1
	internal abstract void set_multiline(bool value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_isReadOnly();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_isReadOnly(bool value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_maxLength();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_maxLength(int value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_isDelayed();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_isDelayed(bool value);

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void SaveValueAndText();

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract void RestoreValueAndText();

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract Func<char, bool> get_AcceptCharacter();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract void set_AcceptCharacter(Func<char, bool> value);

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract Action<bool> get_UpdateScrollOffset();

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract void set_UpdateScrollOffset(Action<bool> value);

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract Action get_UpdateValueFromText();

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract void set_UpdateValueFromText(Action value);

	// RVA: -1 Offset: -1 Slot: 16
	internal abstract Action get_UpdateTextFromValue();

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract void set_UpdateTextFromValue(Action value);

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract Action get_MoveFocusToCompositeRoot();

	// RVA: -1 Offset: -1 Slot: 19
	internal abstract void set_MoveFocusToCompositeRoot(Action value);

	// RVA: -1 Offset: -1 Slot: 20
	internal abstract void UpdateText(string value);

	// RVA: -1 Offset: -1 Slot: 21
	internal abstract string CullString(string s);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void set_maskChar(char value);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract bool get_isPassword();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void set_isPassword(bool value);

	// RVA: 0x259D250 Offset: 0x259C450 VA: 0x18259D250 Slot: 25
	public virtual bool get_autoCorrection() { }

	// RVA: 0x259D460 Offset: 0x259C660 VA: 0x18259D460 Slot: 26
	public virtual void set_autoCorrection(bool value) { }

	// RVA: 0x259D300 Offset: 0x259C500 VA: 0x18259D300 Slot: 27
	public virtual bool get_hideMobileInput() { }

	// RVA: 0x259D510 Offset: 0x259C710 VA: 0x18259D510 Slot: 28
	public virtual void set_hideMobileInput(bool value) { }

	// RVA: 0x259D3B0 Offset: 0x259C5B0 VA: 0x18259D3B0 Slot: 29
	public virtual TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x259D5C0 Offset: 0x259C7C0 VA: 0x18259D5C0 Slot: 30
	public virtual void set_keyboardType(TouchScreenKeyboardType value) { }
}

// Namespace: UnityEngine.UIElements
public interface ITextSelection // TypeDefIndex: 11554
{
	// Properties
	public abstract bool isSelectable { get; set; }
	public abstract Color cursorColor { get; set; }
	public abstract int cursorIndex { get; set; }
	public abstract bool doubleClickSelectsWord { get; }
	public abstract int selectIndex { get; set; }
	public abstract Color selectionColor { get; set; }
	public abstract bool tripleClickSelectsLine { get; }
	internal abstract bool selectAllOnFocus { get; set; }
	internal abstract bool selectAllOnMouseUp { get; set; }
	public abstract Vector2 cursorPosition { get; }
	internal abstract float lineHeightAtCursorPosition { get; }
	internal abstract float cursorWidth { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_isSelectable();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_isSelectable(bool value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Color get_cursorColor();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_cursorColor(Color value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_cursorIndex();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_cursorIndex(int value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_doubleClickSelectsWord();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_selectIndex();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void set_selectIndex(int value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Color get_selectionColor();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void set_selectionColor(Color value);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool get_tripleClickSelectsLine();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool HasSelection();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void SelectAll();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void SelectNone();

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract bool get_selectAllOnFocus();

	// RVA: -1 Offset: -1 Slot: 16
	internal abstract void set_selectAllOnFocus(bool value);

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract bool get_selectAllOnMouseUp();

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract void set_selectAllOnMouseUp(bool value);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract Vector2 get_cursorPosition();

	// RVA: -1 Offset: -1 Slot: 20
	internal abstract float get_lineHeightAtCursorPosition();

	// RVA: -1 Offset: -1 Slot: 21
	internal abstract float get_cursorWidth();
}

// Namespace: UnityEngine.UIElements
public struct TextShadow : IEquatable<TextShadow> // TypeDefIndex: 11555
{
	// Fields
	public Vector2 offset; // 0x0
	public float blurRadius; // 0x8
	public Color color; // 0xC

	// Methods

	// RVA: 0x25A1100 Offset: 0x25A0300 VA: 0x1825A1100 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x25A11B0 Offset: 0x25A03B0 VA: 0x1825A11B0 Slot: 4
	public bool Equals(TextShadow other) { }

	// RVA: 0x25A1270 Offset: 0x25A0470 VA: 0x1825A1270 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x25A1580 Offset: 0x25A0780 VA: 0x1825A1580
	public static bool op_Equality(TextShadow style1, TextShadow style2) { }

	// RVA: 0x25A15B0 Offset: 0x25A07B0 VA: 0x1825A15B0
	public static bool op_Inequality(TextShadow style1, TextShadow style2) { }

	// RVA: 0x25A14A0 Offset: 0x25A06A0 VA: 0x1825A14A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x25A1360 Offset: 0x25A0560 VA: 0x1825A1360
	internal static TextShadow LerpUnclamped(TextShadow a, TextShadow b, float t) { }
}

// Namespace: UnityEngine.UIElements
internal abstract class UIElementsBridge // TypeDefIndex: 11556
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetWantsMouseJumping(int value);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: UnityEngine.UIElements
internal class RuntimeUIElementsBridge : UIElementsBridge // TypeDefIndex: 11557
{
	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	public override void SetWantsMouseJumping(int value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements
internal static class UIElementsPackageUtility // TypeDefIndex: 11558
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static bool <IsUIEPackageLoaded>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static string <EditorResourcesBasePath>k__BackingField; // 0x8

	// Properties
	internal static bool IsUIEPackageLoaded { get; set; }
	internal static string EditorResourcesBasePath { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x25A44D0 Offset: 0x25A36D0 VA: 0x1825A44D0
	internal static bool get_IsUIEPackageLoaded() { }

	[CompilerGenerated]
	// RVA: 0x25A4580 Offset: 0x25A3780 VA: 0x1825A4580
	private static void set_IsUIEPackageLoaded(bool value) { }

	[CompilerGenerated]
	// RVA: 0x25A4480 Offset: 0x25A3680 VA: 0x1825A4480
	internal static string get_EditorResourcesBasePath() { }

	[CompilerGenerated]
	// RVA: 0x25A4520 Offset: 0x25A3720 VA: 0x1825A4520
	private static void set_EditorResourcesBasePath(string value) { }

	// RVA: 0x25A43A0 Offset: 0x25A35A0 VA: 0x1825A43A0
	private static void .cctor() { }

	// RVA: 0x25A43A0 Offset: 0x25A35A0 VA: 0x1825A43A0
	internal static void Refresh() { }
}

// Namespace: 
public sealed class UIElementsRuntimeUtility.CreateRuntimePanelDelegate : MulticastDelegate // TypeDefIndex: 11559
{
	// Methods

	// RVA: 0x11F2F10 Offset: 0x11F2110 VA: 0x1811F2F10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual BaseRuntimePanel Invoke(ScriptableObject ownerObject) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UIElementsRuntimeUtility.<>c // TypeDefIndex: 11560
{
	// Fields
	public static readonly UIElementsRuntimeUtility.<>c <>9; // 0x0
	public static Comparison<Panel> <>9__48_0; // 0x8

	// Methods

	// RVA: 0x25A2F30 Offset: 0x25A2130 VA: 0x1825A2F30
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void <.cctor>b__9_0() { }

	// RVA: 0x25A2C60 Offset: 0x25A1E60 VA: 0x1825A2C60
	internal void <.cctor>b__9_1(int displayIndex, int sortOrder) { }

	// RVA: 0x25A27E0 Offset: 0x25A19E0 VA: 0x1825A27E0
	internal int <SortPanels>b__48_0(Panel a, Panel b) { }
}

// Namespace: UnityEngine.UIElements
internal static class UIElementsRuntimeUtility // TypeDefIndex: 11561
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<BaseRuntimePanel> onCreatePanel; // 0x0
	private static bool s_RegisteredPlayerloopCallback; // 0x8
	private static List<Panel> s_SortedRuntimePanels; // 0x10
	private static bool s_PanelOrderingDirty; // 0x18
	internal static int s_ResolvedSortingIndexMax; // 0x1C
	internal static readonly string s_RepaintProfilerMarkerName; // 0x20
	private static readonly ProfilerMarker s_RepaintProfilerMarker; // 0x28
	private static int currentOverlayIndex; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Object <activeEventSystem>k__BackingField; // 0x38
	private static DefaultEventSystem s_DefaultEventSystem; // 0x40
	private static List<PanelSettings> s_PotentiallyEmptyPanelSettings; // 0x48

	// Properties
	internal static Object activeEventSystem { get; set; }
	internal static bool useDefaultEventSystem { get; }
	internal static DefaultEventSystem defaultEventSystem { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x25A6CA0 Offset: 0x25A5EA0 VA: 0x1825A6CA0
	public static void add_onCreatePanel(Action<BaseRuntimePanel> value) { }

	[CompilerGenerated]
	// RVA: 0x25A6F60 Offset: 0x25A6160 VA: 0x1825A6F60
	public static void remove_onCreatePanel(Action<BaseRuntimePanel> value) { }

	// RVA: 0x25A6900 Offset: 0x25A5B00 VA: 0x1825A6900
	private static void .cctor() { }

	// RVA: 0x25A4640 Offset: 0x25A3840 VA: 0x1825A4640
	public static EventBase CreateEvent(Event systemEvent) { }

	// RVA: 0x25A4840 Offset: 0x25A3A40 VA: 0x1825A4840
	public static BaseRuntimePanel FindOrCreateRuntimePanel(ScriptableObject ownerObject, UIElementsRuntimeUtility.CreateRuntimePanelDelegate createDelegate) { }

	// RVA: 0x25A46B0 Offset: 0x25A38B0 VA: 0x1825A46B0
	public static void DisposeRuntimePanel(ScriptableObject ownerObject) { }

	// RVA: 0x25A5250 Offset: 0x25A4450 VA: 0x1825A5250
	private static void RegisterCachedPanelInternal(int instanceID, IPanel panel) { }

	// RVA: 0x25A5700 Offset: 0x25A4900 VA: 0x1825A5700
	private static void RemoveCachedPanelInternal(int instanceID) { }

	// RVA: 0x25A5C80 Offset: 0x25A4E80 VA: 0x1825A5C80
	public static void RepaintOffscreenPanels() { }

	// RVA: 0x25A5E80 Offset: 0x25A5080 VA: 0x1825A5E80
	public static void RepaintOverlayPanel(BaseRuntimePanel panel) { }

	// RVA: 0x25A45E0 Offset: 0x25A37E0 VA: 0x1825A45E0
	internal static void BeginRenderOverlays(int displayIndex) { }

	// RVA: 0x25A5AA0 Offset: 0x25A4CA0 VA: 0x1825A5AA0
	internal static void RenderOverlaysBeforePriority(int displayIndex, float maxPriority) { }

	// RVA: 0x25A47D0 Offset: 0x25A39D0 VA: 0x1825A47D0
	internal static void EndRenderOverlays(int displayIndex) { }

	[CompilerGenerated]
	// RVA: 0x25A6DB0 Offset: 0x25A5FB0 VA: 0x1825A6DB0
	internal static Object get_activeEventSystem() { }

	[CompilerGenerated]
	// RVA: 0x25A7070 Offset: 0x25A6270 VA: 0x1825A7070
	private static void set_activeEventSystem(Object value) { }

	// RVA: 0x25A6EB0 Offset: 0x25A60B0 VA: 0x1825A6EB0
	internal static bool get_useDefaultEventSystem() { }

	// RVA: 0x25A5450 Offset: 0x25A4650 VA: 0x1825A5450
	public static void RegisterEventSystem(Object eventSystem) { }

	// RVA: 0x25A6440 Offset: 0x25A5640 VA: 0x1825A6440
	public static void UnregisterEventSystem(Object eventSystem) { }

	// RVA: 0x25A6E00 Offset: 0x25A6000 VA: 0x1825A6E00
	internal static DefaultEventSystem get_defaultEventSystem() { }

	// RVA: 0x25A65B0 Offset: 0x25A57B0 VA: 0x1825A65B0
	public static void UpdateRuntimePanels() { }

	// RVA: 0x25A4CD0 Offset: 0x25A3ED0 VA: 0x1825A4CD0
	internal static void MarkPotentiallyEmpty(PanelSettings settings) { }

	// RVA: 0x25A58D0 Offset: 0x25A4AD0 VA: 0x1825A58D0
	internal static void RemoveUnusedPanels() { }

	// RVA: 0x25A5680 Offset: 0x25A4880 VA: 0x1825A5680
	public static void RegisterPlayerloopCallback() { }

	// RVA: 0x25A6560 Offset: 0x25A5760 VA: 0x1825A6560
	public static void UnregisterPlayerloopCallback() { }

	// RVA: 0x25A60E0 Offset: 0x25A52E0 VA: 0x1825A60E0
	internal static void SetPanelOrderingDirty() { }

	// RVA: 0x25A4C30 Offset: 0x25A3E30 VA: 0x1825A4C30
	internal static List<Panel> GetSortedPlayerPanels() { }

	// RVA: 0x25A6130 Offset: 0x25A5330 VA: 0x1825A6130
	private static void SortPanels() { }

	// RVA: 0x25A4DF0 Offset: 0x25A3FF0 VA: 0x1825A4DF0
	internal static Vector2 MultiDisplayBottomLeftToPanelPosition(Vector2 position, out Nullable<int> targetDisplay) { }

	// RVA: 0x25A50A0 Offset: 0x25A42A0 VA: 0x1825A50A0
	internal static Vector2 MultiDisplayToLocalScreenPosition(Vector2 position, out Nullable<int> targetDisplay) { }

	// RVA: 0x25A6000 Offset: 0x25A5200 VA: 0x1825A6000
	internal static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay) { }

	// RVA: 0x25A5FE0 Offset: 0x25A51E0 VA: 0x1825A5FE0
	internal static Vector2 ScreenBottomLeftToPanelDelta(Vector2 delta) { }
}

// Namespace: UnityEngine.UIElements
internal interface IUIElementsUtility // TypeDefIndex: 11562
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TakeCapture();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool ReleaseCapture();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool CleanupRoots();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool EndContainerGUIFromException(Exception exception);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool MakeCurrentIMGUIContainerDirty();
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UIEventRegistration.<>c // TypeDefIndex: 11563
{
	// Fields
	public static readonly UIEventRegistration.<>c <>9; // 0x0

	// Methods

	// RVA: 0x25A2CF0 Offset: 0x25A1EF0 VA: 0x1825A2CF0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x25A2980 Offset: 0x25A1B80 VA: 0x1825A2980
	internal void <.cctor>b__1_0() { }

	// RVA: 0x25A29C0 Offset: 0x25A1BC0 VA: 0x1825A29C0
	internal void <.cctor>b__1_1() { }

	// RVA: 0x25A2A00 Offset: 0x25A1C00 VA: 0x1825A2A00
	internal bool <.cctor>b__1_2(int i, IntPtr ptr) { }

	// RVA: 0x25A2A60 Offset: 0x25A1C60 VA: 0x1825A2A60
	internal void <.cctor>b__1_3() { }

	// RVA: 0x25A2AA0 Offset: 0x25A1CA0 VA: 0x1825A2AA0
	internal bool <.cctor>b__1_4(Exception exception) { }

	// RVA: 0x25A2AF0 Offset: 0x25A1CF0 VA: 0x1825A2AF0
	internal void <.cctor>b__1_5() { }
}

// Namespace: UnityEngine.UIElements
internal static class UIEventRegistration // TypeDefIndex: 11564
{
	// Fields
	private static List<IUIElementsUtility> s_Utilities; // 0x0

	// Methods

	// RVA: 0x25A97F0 Offset: 0x25A89F0 VA: 0x1825A97F0
	private static void .cctor() { }

	// RVA: 0x25A94B0 Offset: 0x25A86B0 VA: 0x1825A94B0
	internal static void RegisterUIElementSystem(IUIElementsUtility utility) { }

	// RVA: 0x25A9690 Offset: 0x25A8890 VA: 0x1825A9690
	private static void TakeCapture() { }

	// RVA: 0x25A9530 Offset: 0x25A8730 VA: 0x1825A9530
	private static void ReleaseCapture() { }

	// RVA: 0x25A8F00 Offset: 0x25A8100 VA: 0x1825A8F00
	private static bool EndContainerGUIFromException(Exception exception) { }

	// RVA: 0x25A92A0 Offset: 0x25A84A0 VA: 0x1825A92A0
	private static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) { }

	// RVA: 0x25A8DA0 Offset: 0x25A7FA0 VA: 0x1825A8DA0
	private static void CleanupRoots() { }

	// RVA: 0x25A9140 Offset: 0x25A8340 VA: 0x1825A9140
	internal static void MakeCurrentIMGUIContainerDirty() { }
}

// Namespace: UnityEngine.UIElements
internal class UIElementsUtility : IUIElementsUtility // TypeDefIndex: 11565
{
	// Fields
	private static Stack<IMGUIContainer> s_ContainerStack; // 0x0
	private static Dictionary<int, Panel> s_UIElementsCache; // 0x8
	private static Event s_EventInstance; // 0x10
	internal static Color editorPlayModeTintColor; // 0x18
	internal static float singleLineHeight; // 0x28
	private static UIElementsUtility s_Instance; // 0x30
	internal static List<Panel> s_PanelsIterationList; // 0x38
	internal static readonly string s_RepaintProfilerMarkerName; // 0x40
	internal static readonly string s_EventProfilerMarkerName; // 0x48
	private static readonly ProfilerMarker s_RepaintProfilerMarker; // 0x50
	private static readonly ProfilerMarker s_EventProfilerMarker; // 0x58
	internal static char[] s_Modifiers; // 0x60

	// Methods

	// RVA: 0x25A8CE0 Offset: 0x25A7EE0 VA: 0x1825A8CE0
	private void .ctor() { }

	// RVA: 0x25A86C0 Offset: 0x25A78C0 VA: 0x1825A86C0 Slot: 9
	private bool UnityEngine.UIElements.IUIElementsUtility.MakeCurrentIMGUIContainerDirty() { }

	// RVA: 0x25A88D0 Offset: 0x25A7AD0 VA: 0x1825A88D0 Slot: 4
	private bool UnityEngine.UIElements.IUIElementsUtility.TakeCapture() { }

	// RVA: 0xA641B0 Offset: 0xA633B0 VA: 0x180A641B0 Slot: 5
	private bool UnityEngine.UIElements.IUIElementsUtility.ReleaseCapture() { }

	// RVA: 0x25A8780 Offset: 0x25A7980 VA: 0x1825A8780 Slot: 6
	private bool UnityEngine.UIElements.IUIElementsUtility.ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled) { }

	// RVA: 0x25A8560 Offset: 0x25A7760 VA: 0x1825A8560 Slot: 7
	private bool UnityEngine.UIElements.IUIElementsUtility.CleanupRoots() { }

	// RVA: 0x25A85E0 Offset: 0x25A77E0 VA: 0x1825A85E0 Slot: 8
	private bool UnityEngine.UIElements.IUIElementsUtility.EndContainerGUIFromException(Exception exception) { }

	// RVA: 0x25A83C0 Offset: 0x25A75C0 VA: 0x1825A83C0
	public static void RegisterCachedPanel(int instanceID, Panel panel) { }

	// RVA: 0x25A8450 Offset: 0x25A7650 VA: 0x1825A8450
	public static void RemoveCachedPanel(int instanceID) { }

	// RVA: 0x25A84D0 Offset: 0x25A76D0 VA: 0x1825A84D0
	public static bool TryGetPanel(int instanceID, out Panel panel) { }

	// RVA: 0x25A70D0 Offset: 0x25A62D0 VA: 0x1825A70D0
	internal static void BeginContainerGUI(GUILayoutUtility.LayoutCache cache, Event evt, IMGUIContainer container) { }

	// RVA: 0x25A7D30 Offset: 0x25A6F30 VA: 0x1825A7D30
	internal static void EndContainerGUI(Event evt, Rect layoutSize) { }

	// RVA: 0x25A7330 Offset: 0x25A6530 VA: 0x1825A7330
	internal static EventBase CreateEvent(Event systemEvent) { }

	// RVA: 0x25A73A0 Offset: 0x25A65A0 VA: 0x1825A73A0
	internal static EventBase CreateEvent(Event systemEvent, EventType eventType) { }

	// RVA: 0x25A7750 Offset: 0x25A6950 VA: 0x1825A7750
	private static bool DoDispatch(BaseVisualElementPanel panel) { }

	// RVA: 0x25A7F70 Offset: 0x25A7170 VA: 0x1825A7F70
	internal static void GetAllPanels(List<Panel> panels, ContextType contextType) { }

	// RVA: 0x25A80F0 Offset: 0x25A72F0 VA: 0x1825A80F0
	internal static Dictionary.Enumerator<int, Panel> GetPanelsIterator() { }

	// RVA: 0x25A82F0 Offset: 0x25A74F0 VA: 0x1825A82F0
	internal static float PixelsPerUnitScaleForElement(VisualElement ve, Sprite sprite) { }

	// RVA: 0x25A81A0 Offset: 0x25A73A0 VA: 0x1825A81A0
	internal static string ParseMenuName(string menuName) { }

	// RVA: 0x25A8990 Offset: 0x25A7B90 VA: 0x1825A8990
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements
internal struct RuleMatcher // TypeDefIndex: 11566
{
	// Fields
	public StyleSheet sheet; // 0x0
	public StyleComplexSelector complexSelector; // 0x8

	// Methods

	// RVA: 0x259D670 Offset: 0x259C870 VA: 0x18259D670 Slot: 3
	public override string ToString() { }
}

// Namespace: 
internal interface UQuery.IVisualPredicateWrapper // TypeDefIndex: 11567
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Predicate(object e);
}

// Namespace: 
internal class UQuery.IsOfType<T> : UQuery.IVisualPredicateWrapper // TypeDefIndex: 11568
{
	// Fields
	public static UQuery.IsOfType<T> s_Instance; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public bool Predicate(object e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B2900 Offset: 0x12B1B00 VA: 0x1812B2900
	|-UQuery.IsOfType<object>.Predicate
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-UQuery.IsOfType<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B2940 Offset: 0x12B1B40 VA: 0x1812B2940
	|-UQuery.IsOfType<object>..cctor
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UQuery.UQueryMatcher.<>c // TypeDefIndex: 11569
{
	// Fields
	public static readonly UQuery.UQueryMatcher.<>c <>9; // 0x0
	public static Action<VisualElement, MatchResultInfo> <>9__5_0; // 0x8

	// Methods

	// RVA: 0x25A2DB0 Offset: 0x25A1FB0 VA: 0x1825A2DB0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void <TraverseRecursive>b__5_0(VisualElement e, MatchResultInfo i) { }
}

// Namespace: 
internal abstract class UQuery.UQueryMatcher : HierarchyTraversal // TypeDefIndex: 11570
{
	// Fields
	internal List<RuleMatcher> m_Matchers; // 0x10

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	protected void .ctor() { }

	// RVA: 0x25AAB70 Offset: 0x25A9D70 VA: 0x1825AAB70 Slot: 4
	public override void Traverse(VisualElement element) { }

	// RVA: 0xA641B0 Offset: 0xA633B0 VA: 0x180A641B0 Slot: 6
	protected virtual bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private static void NoProcessResult(VisualElement e, MatchResultInfo i) { }

	// RVA: 0x25AA970 Offset: 0x25A9B70 VA: 0x1825AA970 Slot: 5
	public override void TraverseRecursive(VisualElement element, int depth) { }

	// RVA: 0x25AA950 Offset: 0x25A9B50 VA: 0x1825AA950 Slot: 7
	public virtual void Run(VisualElement root, List<RuleMatcher> matchers) { }
}

// Namespace: 
internal abstract class UQuery.SingleQueryMatcher : UQuery.UQueryMatcher // TypeDefIndex: 11571
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VisualElement <match>k__BackingField; // 0x18

	// Properties
	public VisualElement match { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public VisualElement get_match() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_match(VisualElement value) { }

	// RVA: 0x259D6B0 Offset: 0x259C8B0 VA: 0x18259D6B0 Slot: 7
	public override void Run(VisualElement root, List<RuleMatcher> matchers) { }

	// RVA: 0x259D6A0 Offset: 0x259C8A0 VA: 0x18259D6A0
	public bool IsInUse() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract UQuery.SingleQueryMatcher CreateNew();

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	protected void .ctor() { }
}

// Namespace: 
internal class UQuery.FirstQueryMatcher : UQuery.SingleQueryMatcher // TypeDefIndex: 11572
{
	// Fields
	public static readonly UQuery.FirstQueryMatcher Instance; // 0x0

	// Methods

	// RVA: 0x259D1E0 Offset: 0x259C3E0 VA: 0x18259D1E0 Slot: 6
	protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

	// RVA: 0x259D190 Offset: 0x259C390 VA: 0x18259D190 Slot: 8
	public override UQuery.SingleQueryMatcher CreateNew() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x259D1F0 Offset: 0x259C3F0 VA: 0x18259D1F0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements
public static class UQuery // TypeDefIndex: 11573
{}

// Namespace: 
private class UQueryState.ListQueryMatcher<T, TElement> : UQuery.UQueryMatcher // TypeDefIndex: 11574
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private List<TElement> <matches>k__BackingField; // 0x0

	// Properties
	public List<TElement> matches { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public List<TElement> get_matches() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-UQueryState.ListQueryMatcher<object, object>.get_matches
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_matches(List<TElement> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	|-UQueryState.ListQueryMatcher<object, object>.set_matches
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132CE60 Offset: 0x132C060 VA: 0x18132CE60
	|-UQueryState.ListQueryMatcher<object, object>.OnRuleMatchedElement
	*/

	// RVA: -1 Offset: -1
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132CF80 Offset: 0x132C180 VA: 0x18132CF80
	|-UQueryState.ListQueryMatcher<object, object>.Reset
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	|-UQueryState.ListQueryMatcher<object, object>..ctor
	*/
}

// Namespace: 
private class UQueryState.ActionQueryMatcher<T> : UQuery.UQueryMatcher // TypeDefIndex: 11575
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<T> <callBack>k__BackingField; // 0x0

	// Properties
	internal Action<T> callBack { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal Action<T> get_callBack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-UQueryState.ActionQueryMatcher<object>.get_callBack
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11064D0 Offset: 0x11056D0 VA: 0x1811064D0
	|-UQueryState.ActionQueryMatcher<object>.OnRuleMatchedElement
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEFD400 Offset: 0xEFC600 VA: 0x180EFD400
	|-UQueryState.ActionQueryMatcher<object>..ctor
	*/
}

// Namespace: 
public struct UQueryState.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 11576
{
	// Fields
	private List<VisualElement> iterationList; // 0x0
	private int currentIndex; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(UQueryState<T> queryState) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F0440 Offset: 0x10EF640 VA: 0x1810F0440
	|-UQueryState.Enumerator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F0F70 Offset: 0x10F0170 VA: 0x1810F0F70
	|-UQueryState.Enumerator<object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EFC00 Offset: 0x10EEE00 VA: 0x1810EFC00
	|-UQueryState.Enumerator<object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10ED960 Offset: 0x10ECB60 VA: 0x1810ED960
	|-UQueryState.Enumerator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EE2D0 Offset: 0x10ED4D0 VA: 0x1810EE2D0
	|-UQueryState.Enumerator<object>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EC0F0 Offset: 0x10EB2F0 VA: 0x1810EC0F0
	|-UQueryState.Enumerator<object>.Dispose
	*/
}

// Namespace: UnityEngine.UIElements
public struct UQueryState<T> : IEnumerable<T>, IEnumerable, IEquatable<UQueryState<T>> // TypeDefIndex: 11577
{
	// Fields
	private static UQueryState.ActionQueryMatcher<T> s_Action; // 0x0
	private readonly VisualElement m_Element; // 0x0
	internal readonly List<RuleMatcher> m_Matchers; // 0x0
	private static readonly UQueryState.ListQueryMatcher<T, T> s_List; // 0x0
	private static readonly UQueryState.ListQueryMatcher<T, VisualElement> s_EnumerationList; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(VisualElement element, List<RuleMatcher> matchers) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C3520 Offset: 0x5C2720 VA: 0x1805C3520
	|-UQueryState<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public UQueryState<T> RebuildOn(VisualElement element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE0560 Offset: 0xCDF760 VA: 0x180CE0560
	|-UQueryState<object>.RebuildOn
	*/

	// RVA: -1 Offset: -1
	private T Single(UQuery.SingleQueryMatcher matcher) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE05C0 Offset: 0xCDF7C0 VA: 0x180CE05C0
	|-UQueryState<object>.Single
	*/

	// RVA: -1 Offset: -1
	public T First() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE0370 Offset: 0xCDF570 VA: 0x180CE0370
	|-UQueryState<object>.First
	*/

	// RVA: -1 Offset: -1
	public UQueryState.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE0450 Offset: 0xCDF650 VA: 0x180CE0450
	|-UQueryState<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE06F0 Offset: 0xCDF8F0 VA: 0x180CE06F0
	|-UQueryState<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE06F0 Offset: 0xCDF8F0 VA: 0x180CE06F0
	|-UQueryState<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool Equals(UQueryState<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE0130 Offset: 0xCDF330 VA: 0x180CE0130
	|-UQueryState<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE01C0 Offset: 0xCDF3C0 VA: 0x180CE01C0
	|-UQueryState<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE04B0 Offset: 0xCDF6B0 VA: 0x180CE04B0
	|-UQueryState<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE07F0 Offset: 0xCDF9F0 VA: 0x180CE07F0
	|-UQueryState<object>..cctor
	*/
}

// Namespace: UnityEngine.UIElements
public struct UQueryBuilder<T> : IEquatable<UQueryBuilder<T>> // TypeDefIndex: 11578
{
	// Fields
	private List<StyleSelector> m_StyleSelectors; // 0x0
	private List<StyleSelectorPart> m_Parts; // 0x0
	private VisualElement m_Element; // 0x0
	private List<RuleMatcher> m_Matchers; // 0x0
	private StyleSelectorRelationship m_Relationship; // 0x0
	private int pseudoStatesMask; // 0x0
	private int negatedPseudoStatesMask; // 0x0

	// Properties
	private List<StyleSelector> styleSelectors { get; }
	private List<StyleSelectorPart> parts { get; }

	// Methods

	// RVA: -1 Offset: -1
	private List<StyleSelector> get_styleSelectors() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE00C0 Offset: 0xCDF2C0 VA: 0x180CE00C0
	|-UQueryBuilder<object>.get_styleSelectors
	*/

	// RVA: -1 Offset: -1
	private List<StyleSelectorPart> get_parts() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE0050 Offset: 0xCDF250 VA: 0x180CE0050
	|-UQueryBuilder<object>.get_parts
	*/

	// RVA: -1 Offset: -1
	public void .ctor(VisualElement visualElement) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDFFC0 Offset: 0xCDF1C0 VA: 0x180CDFFC0
	|-UQueryBuilder<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public UQueryBuilder<T> Class(string classname) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDF070 Offset: 0xCDE270 VA: 0x180CDF070
	|-UQueryBuilder<object>.Class
	*/

	// RVA: -1 Offset: -1
	public UQueryBuilder<T> Name(string id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDFCB0 Offset: 0xCDEEB0 VA: 0x180CDFCB0
	|-UQueryBuilder<object>.Name
	*/

	// RVA: -1 Offset: -1
	internal UQueryBuilder<T> SingleBaseType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDFE10 Offset: 0xCDF010 VA: 0x180CDFE10
	|-UQueryBuilder<object>.SingleBaseType
	*/

	// RVA: -1 Offset: -1
	private void AddClass(string c) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDEB40 Offset: 0xCDDD40 VA: 0x180CDEB40
	|-UQueryBuilder<object>.AddClass
	*/

	// RVA: -1 Offset: -1
	private void AddName(string id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDEC60 Offset: 0xCDDE60 VA: 0x180CDEC60
	|-UQueryBuilder<object>.AddName
	*/

	// RVA: -1 Offset: -1
	private void AddPseudoStatesRuleIfNecessasy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDED80 Offset: 0xCDDF80 VA: 0x180CDED80
	|-UQueryBuilder<object>.AddPseudoStatesRuleIfNecessasy
	*/

	// RVA: -1 Offset: -1
	private void FinishSelector() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDF800 Offset: 0xCDEA00 VA: 0x180CDF800
	|-UQueryBuilder<object>.FinishSelector
	*/

	// RVA: -1 Offset: -1
	private bool CurrentSelectorEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDF1D0 Offset: 0xCDE3D0 VA: 0x180CDF1D0
	|-UQueryBuilder<object>.CurrentSelectorEmpty
	*/

	// RVA: -1 Offset: -1
	private void FinishCurrentSelector() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDF620 Offset: 0xCDE820 VA: 0x180CDF620
	|-UQueryBuilder<object>.FinishCurrentSelector
	*/

	// RVA: -1 Offset: -1
	public UQueryState<T> Build() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDEEA0 Offset: 0xCDE0A0 VA: 0x180CDEEA0
	|-UQueryBuilder<object>.Build
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(UQueryBuilder<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDF390 Offset: 0xCDE590 VA: 0x180CDF390
	|-UQueryBuilder<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDF270 Offset: 0xCDE470 VA: 0x180CDF270
	|-UQueryBuilder<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDFA50 Offset: 0xCDEC50 VA: 0x180CDFA50
	|-UQueryBuilder<object>.GetHashCode
	*/
}

// Namespace: UnityEngine.UIElements
[Extension]
public static class UQueryExtensions // TypeDefIndex: 11579
{
	// Fields
	private static UQueryState<VisualElement> SingleElementEmptyQuery; // 0x0
	private static UQueryState<VisualElement> SingleElementNameQuery; // 0x10
	private static UQueryState<VisualElement> SingleElementClassQuery; // 0x20
	private static UQueryState<VisualElement> SingleElementNameAndClassQuery; // 0x30
	private static UQueryState<VisualElement> SingleElementTypeQuery; // 0x40
	private static UQueryState<VisualElement> SingleElementTypeAndNameQuery; // 0x50
	private static UQueryState<VisualElement> SingleElementTypeAndClassQuery; // 0x60
	private static UQueryState<VisualElement> SingleElementTypeAndNameAndClassQuery; // 0x70

	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static T Q<T>(VisualElement e, string name, string className) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA97C50 Offset: 0xA96E50 VA: 0x180A97C50
	|-UQueryExtensions.Q<object>
	*/

	[Extension]
	// RVA: 0x25A9DB0 Offset: 0x25A8FB0 VA: 0x1825A9DB0
	public static VisualElement Q(VisualElement e, string name, string className) { }

	// RVA: 0x25AA260 Offset: 0x25A9460 VA: 0x1825AA260
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements
public interface IUxmlAttributes // TypeDefIndex: 11580
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TryGetAttributeValue(string attributeName, out string value);
}

// Namespace: UnityEngine.UIElements
public class UxmlRootElementFactory : UxmlFactory<VisualElement, UxmlRootElementTraits> // TypeDefIndex: 11581
{
	// Properties
	public override string uxmlName { get; }
	public override string uxmlQualifiedName { get; }

	// Methods

	// RVA: 0x25AD180 Offset: 0x25AC380 VA: 0x1825AD180 Slot: 4
	public override string get_uxmlName() { }

	// RVA: 0x25AD1B0 Offset: 0x25AC3B0 VA: 0x1825AD1B0 Slot: 6
	public override string get_uxmlQualifiedName() { }

	// RVA: 0xB88020 Offset: 0xB87220 VA: 0x180B88020 Slot: 13
	public override VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x25AD140 Offset: 0x25AC340 VA: 0x1825AD140
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements
public class UxmlRootElementTraits : UxmlTraits // TypeDefIndex: 11582
{
	// Fields
	protected UxmlStringAttributeDescription m_Name; // 0x18
	private UxmlStringAttributeDescription m_Class; // 0x20

	// Methods

	// RVA: 0x25AD230 Offset: 0x25AC430 VA: 0x1825AD230
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements
public class UxmlStyleFactory : UxmlFactory<VisualElement, UxmlStyleTraits> // TypeDefIndex: 11583
{
	// Properties
	public override string uxmlName { get; }
	public override string uxmlQualifiedName { get; }

	// Methods

	// RVA: 0x25AD660 Offset: 0x25AC860 VA: 0x1825AD660 Slot: 4
	public override string get_uxmlName() { }

	// RVA: 0x25AD690 Offset: 0x25AC890 VA: 0x1825AD690 Slot: 6
	public override string get_uxmlQualifiedName() { }

	// RVA: 0xB88020 Offset: 0xB87220 VA: 0x180B88020 Slot: 13
	public override VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x25AD620 Offset: 0x25AC820 VA: 0x1825AD620
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements
public class UxmlStyleTraits : UxmlTraits // TypeDefIndex: 11584
{
	// Fields
	private UxmlStringAttributeDescription m_Name; // 0x18
	private UxmlStringAttributeDescription m_Path; // 0x20
	private UxmlStringAttributeDescription m_Src; // 0x28

	// Methods

	// RVA: 0x25AD710 Offset: 0x25AC910 VA: 0x1825AD710
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements
public class UxmlTemplateFactory : UxmlFactory<VisualElement, UxmlTemplateTraits> // TypeDefIndex: 11585
{
	// Properties
	public override string uxmlName { get; }
	public override string uxmlQualifiedName { get; }

	// Methods

	// RVA: 0x25AD850 Offset: 0x25ACA50 VA: 0x1825AD850 Slot: 4
	public override string get_uxmlName() { }

	// RVA: 0x25AD880 Offset: 0x25ACA80 VA: 0x1825AD880 Slot: 6
	public override string get_uxmlQualifiedName() { }

	// RVA: 0xB88020 Offset: 0xB87220 VA: 0x180B88020 Slot: 13
	public override VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x25AD810 Offset: 0x25ACA10 VA: 0x1825AD810
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements
public class UxmlTemplateTraits : UxmlTraits // TypeDefIndex: 11586
{
	// Fields
	private UxmlStringAttributeDescription m_Name; // 0x18
	private UxmlStringAttributeDescription m_Path; // 0x20
	private UxmlStringAttributeDescription m_Src; // 0x28

	// Methods

	// RVA: 0x25AD900 Offset: 0x25ACB00 VA: 0x1825AD900
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements
public class UxmlAttributeOverridesFactory : UxmlFactory<VisualElement, UxmlAttributeOverridesTraits> // TypeDefIndex: 11587
{
	// Properties
	public override string uxmlName { get; }
	public override string uxmlQualifiedName { get; }

	// Methods

	// RVA: 0x25AB4B0 Offset: 0x25AA6B0 VA: 0x1825AB4B0 Slot: 4
	public override string get_uxmlName() { }

	// RVA: 0x25AB4E0 Offset: 0x25AA6E0 VA: 0x1825AB4E0 Slot: 6
	public override string get_uxmlQualifiedName() { }

	// RVA: 0xB88020 Offset: 0xB87220 VA: 0x180B88020 Slot: 13
	public override VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x25AB470 Offset: 0x25AA670 VA: 0x1825AB470
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements
public class UxmlAttributeOverridesTraits : UxmlTraits // TypeDefIndex: 11588
{
	// Fields
	private UxmlStringAttributeDescription m_ElementName; // 0x18

	// Methods

	// RVA: 0x25AB560 Offset: 0x25AA760 VA: 0x1825AB560
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public struct TemplateAsset.AttributeOverride // TypeDefIndex: 11589
{
	// Fields
	public string m_ElementName; // 0x0
	public string m_AttributeName; // 0x8
	public string m_Value; // 0x10
}

// Namespace: UnityEngine.UIElements
[Serializable]
internal class TemplateAsset : VisualElementAsset // TypeDefIndex: 11590
{
	// Fields
	[SerializeField]
	private string m_TemplateAlias; // 0x70
	[SerializeField]
	private List<TemplateAsset.AttributeOverride> m_AttributeOverrides; // 0x78
	[SerializeField]
	private List<VisualTreeAsset.SlotUsageEntry> m_SlotUsages; // 0x80

	// Properties
	public List<TemplateAsset.AttributeOverride> attributeOverrides { get; }
	internal List<VisualTreeAsset.SlotUsageEntry> slotUsages { get; }

	// Methods

	// RVA: 0x259D6F0 Offset: 0x259C8F0 VA: 0x18259D6F0
	public List<TemplateAsset.AttributeOverride> get_attributeOverrides() { }

	// RVA: 0x24CAE20 Offset: 0x24CA020 VA: 0x1824CAE20
	internal List<VisualTreeAsset.SlotUsageEntry> get_slotUsages() { }
}

// Namespace: 
public enum UxmlAttributeDescription.Use // TypeDefIndex: 11591
{
	// Fields
	public int value__; // 0x0
	public const UxmlAttributeDescription.Use None = 0;
	public const UxmlAttributeDescription.Use Optional = 1;
	public const UxmlAttributeDescription.Use Prohibited = 2;
	public const UxmlAttributeDescription.Use Required = 3;
}

// Namespace: UnityEngine.UIElements
public abstract class UxmlAttributeDescription // TypeDefIndex: 11592
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <name>k__BackingField; // 0x10
	private string[] m_ObsoleteNames; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <type>k__BackingField; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <typeNamespace>k__BackingField; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private UxmlAttributeDescription.Use <use>k__BackingField; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private UxmlTypeRestriction <restriction>k__BackingField; // 0x38

	// Properties
	public string name { get; set; }
	public IEnumerable<string> obsoleteNames { set; }
	protected string type { set; }
	protected string typeNamespace { set; }
	public UxmlAttributeDescription.Use use { set; }
	public UxmlTypeRestriction restriction { set; }

	// Methods

	// RVA: 0x25AB3F0 Offset: 0x25AA5F0 VA: 0x1825AB3F0
	protected void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_name() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_name(string value) { }

	// RVA: 0x25AB420 Offset: 0x25AA620 VA: 0x1825AB420
	public void set_obsoleteNames(IEnumerable<string> value) { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	protected void set_type(string value) { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	protected void set_typeNamespace(string value) { }

	[CompilerGenerated]
	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	public void set_use(UxmlAttributeDescription.Use value) { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_restriction(UxmlTypeRestriction value) { }

	// RVA: 0x25AAF00 Offset: 0x25AA100 VA: 0x1825AAF00
	internal bool TryGetValueFromBagAsString(IUxmlAttributes bag, CreationContext cc, out string value) { }

	// RVA: -1 Offset: -1
	protected bool TryGetValueFromBag<T>(IUxmlAttributes bag, CreationContext cc, Func<string, T, T> converterFunc, T defaultValue, ref T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA25E0 Offset: 0xAA17E0 VA: 0x180AA25E0
	|-UxmlAttributeDescription.TryGetValueFromBag<int>
	|-UxmlAttributeDescription.TryGetValueFromBag<Int32Enum>
	|
	|-RVA: 0xAA26A0 Offset: 0xAA18A0 VA: 0x180AA26A0
	|-UxmlAttributeDescription.TryGetValueFromBag<object>
	|
	|-RVA: 0xAA2440 Offset: 0xAA1640 VA: 0x180AA2440
	|-UxmlAttributeDescription.TryGetValueFromBag<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected T GetValueFromBag<T>(IUxmlAttributes bag, CreationContext cc, Func<string, T, T> converterFunc, T defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA1BE0 Offset: 0xAA0DE0 VA: 0x180AA1BE0
	|-UxmlAttributeDescription.GetValueFromBag<bool>
	|
	|-RVA: 0xAA1CE0 Offset: 0xAA0EE0 VA: 0x180AA1CE0
	|-UxmlAttributeDescription.GetValueFromBag<double>
	|
	|-RVA: 0xAA1DE0 Offset: 0xAA0FE0 VA: 0x180AA1DE0
	|-UxmlAttributeDescription.GetValueFromBag<Hash128>
	|
	|-RVA: 0xAA2140 Offset: 0xAA1340 VA: 0x180AA2140
	|-UxmlAttributeDescription.GetValueFromBag<int>
	|-UxmlAttributeDescription.GetValueFromBag<Int32Enum>
	|-UxmlAttributeDescription.GetValueFromBag<uint>
	|
	|-RVA: 0xAA2240 Offset: 0xAA1440 VA: 0x180AA2240
	|-UxmlAttributeDescription.GetValueFromBag<long>
	|-UxmlAttributeDescription.GetValueFromBag<object>
	|-UxmlAttributeDescription.GetValueFromBag<ulong>
	|
	|-RVA: 0xAA2340 Offset: 0xAA1540 VA: 0x180AA2340
	|-UxmlAttributeDescription.GetValueFromBag<float>
	|
	|-RVA: 0xAA1F10 Offset: 0xAA1110 VA: 0x180AA1F10
	|-UxmlAttributeDescription.GetValueFromBag<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: UnityEngine.UIElements
public abstract class TypedUxmlAttributeDescription<T> : UxmlAttributeDescription // TypeDefIndex: 11593
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private T <defaultValue>k__BackingField; // 0x0

	// Properties
	public T defaultValue { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract T GetValueFromBag(IUxmlAttributes bag, CreationContext cc);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypedUxmlAttributeDescription<__Il2CppFullySharedGenericType>.GetValueFromBag
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public T get_defaultValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4456F0 Offset: 0x4448F0 VA: 0x1804456F0
	|-TypedUxmlAttributeDescription<bool>.get_defaultValue
	|
	|-RVA: 0x52F530 Offset: 0x52E730 VA: 0x18052F530
	|-TypedUxmlAttributeDescription<double>.get_defaultValue
	|
	|-RVA: 0x4D1A20 Offset: 0x4D0C20 VA: 0x1804D1A20
	|-TypedUxmlAttributeDescription<Hash128>.get_defaultValue
	|
	|-RVA: 0x433440 Offset: 0x432640 VA: 0x180433440
	|-TypedUxmlAttributeDescription<int>.get_defaultValue
	|-TypedUxmlAttributeDescription<Int32Enum>.get_defaultValue
	|-TypedUxmlAttributeDescription<uint>.get_defaultValue
	|
	|-RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	|-TypedUxmlAttributeDescription<long>.get_defaultValue
	|-TypedUxmlAttributeDescription<object>.get_defaultValue
	|-TypedUxmlAttributeDescription<ulong>.get_defaultValue
	|
	|-RVA: 0x78EC10 Offset: 0x78DE10 VA: 0x18078EC10
	|-TypedUxmlAttributeDescription<float>.get_defaultValue
	|
	|-RVA: 0xB16E40 Offset: 0xB16040 VA: 0x180B16E40
	|-TypedUxmlAttributeDescription<__Il2CppFullySharedGenericType>.get_defaultValue
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_defaultValue(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x445700 Offset: 0x444900 VA: 0x180445700
	|-TypedUxmlAttributeDescription<bool>.set_defaultValue
	|
	|-RVA: 0x52F550 Offset: 0x52E750 VA: 0x18052F550
	|-TypedUxmlAttributeDescription<double>.set_defaultValue
	|
	|-RVA: 0x4D1A60 Offset: 0x4D0C60 VA: 0x1804D1A60
	|-TypedUxmlAttributeDescription<Hash128>.set_defaultValue
	|
	|-RVA: 0x433450 Offset: 0x432650 VA: 0x180433450
	|-TypedUxmlAttributeDescription<int>.set_defaultValue
	|-TypedUxmlAttributeDescription<Int32Enum>.set_defaultValue
	|-TypedUxmlAttributeDescription<uint>.set_defaultValue
	|
	|-RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	|-TypedUxmlAttributeDescription<long>.set_defaultValue
	|-TypedUxmlAttributeDescription<object>.set_defaultValue
	|-TypedUxmlAttributeDescription<ulong>.set_defaultValue
	|
	|-RVA: 0xCDEA70 Offset: 0xCDDC70 VA: 0x180CDEA70
	|-TypedUxmlAttributeDescription<float>.set_defaultValue
	|
	|-RVA: 0xCDEA80 Offset: 0xCDDC80 VA: 0x180CDEA80
	|-TypedUxmlAttributeDescription<__Il2CppFullySharedGenericType>.set_defaultValue
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCDEA60 Offset: 0xCDDC60 VA: 0x180CDEA60
	|-TypedUxmlAttributeDescription<bool>..ctor
	|-TypedUxmlAttributeDescription<double>..ctor
	|-TypedUxmlAttributeDescription<Hash128>..ctor
	|-TypedUxmlAttributeDescription<int>..ctor
	|-TypedUxmlAttributeDescription<Int32Enum>..ctor
	|-TypedUxmlAttributeDescription<long>..ctor
	|-TypedUxmlAttributeDescription<object>..ctor
	|-TypedUxmlAttributeDescription<float>..ctor
	|-TypedUxmlAttributeDescription<uint>..ctor
	|-TypedUxmlAttributeDescription<ulong>..ctor
	|-TypedUxmlAttributeDescription<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UxmlStringAttributeDescription.<>c // TypeDefIndex: 11594
{
	// Fields
	public static readonly UxmlStringAttributeDescription.<>c <>9; // 0x0
	public static Func<string, string, string> <>9__3_0; // 0x8
	public static Func<string, string, string> <>9__4_0; // 0x10

	// Methods

	// RVA: 0x25A2ED0 Offset: 0x25A20D0 VA: 0x1825A2ED0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x70E580 Offset: 0x70D780 VA: 0x18070E580
	internal string <GetValueFromBag>b__3_0(string s, string t) { }

	// RVA: 0x70E580 Offset: 0x70D780 VA: 0x18070E580
	internal string <TryGetValueFromBag>b__4_0(string s, string t) { }
}

// Namespace: UnityEngine.UIElements
public class UxmlStringAttributeDescription : TypedUxmlAttributeDescription<string> // TypeDefIndex: 11595
{
	// Methods

	// RVA: 0x25AD590 Offset: 0x25AC790 VA: 0x1825AD590
	public void .ctor() { }

	// RVA: 0x25AD2F0 Offset: 0x25AC4F0 VA: 0x1825AD2F0 Slot: 4
	public override string GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x25AD440 Offset: 0x25AC640 VA: 0x1825AD440
	public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref string value) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UxmlFloatAttributeDescription.<>c // TypeDefIndex: 11596
{
	// Fields
	public static readonly UxmlFloatAttributeDescription.<>c <>9; // 0x0
	public static Func<string, float, float> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x25A2D50 Offset: 0x25A1F50 VA: 0x1825A2D50
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x25A2700 Offset: 0x25A1900 VA: 0x1825A2700
	internal float <GetValueFromBag>b__3_0(string s, float f) { }
}

// Namespace: UnityEngine.UIElements
public class UxmlFloatAttributeDescription : TypedUxmlAttributeDescription<float> // TypeDefIndex: 11597
{
	// Methods

	// RVA: 0x25ABF00 Offset: 0x25AB100 VA: 0x1825ABF00
	public void .ctor() { }

	// RVA: 0x25ABDB0 Offset: 0x25AAFB0 VA: 0x1825ABDB0 Slot: 4
	public override float GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x25ABD10 Offset: 0x25AAF10 VA: 0x1825ABD10
	private static float ConvertValueToFloat(string v, float defaultValue) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UxmlDoubleAttributeDescription.<>c // TypeDefIndex: 11598
{
	// Fields
	public static readonly UxmlDoubleAttributeDescription.<>c <>9; // 0x0
	public static Func<string, double, double> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x25A3050 Offset: 0x25A2250 VA: 0x1825A3050
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x25A2660 Offset: 0x25A1860 VA: 0x1825A2660
	internal double <GetValueFromBag>b__3_0(string s, double d) { }
}

// Namespace: UnityEngine.UIElements
public class UxmlDoubleAttributeDescription : TypedUxmlAttributeDescription<double> // TypeDefIndex: 11599
{
	// Methods

	// RVA: 0x25ABA30 Offset: 0x25AAC30 VA: 0x1825ABA30
	public void .ctor() { }

	// RVA: 0x25AB8E0 Offset: 0x25AAAE0 VA: 0x1825AB8E0 Slot: 4
	public override double GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x25AB840 Offset: 0x25AAA40 VA: 0x1825AB840
	private static double ConvertValueToDouble(string v, double defaultValue) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UxmlIntAttributeDescription.<>c // TypeDefIndex: 11600
{
	// Fields
	public static readonly UxmlIntAttributeDescription.<>c <>9; // 0x0
	public static Func<string, int, int> <>9__3_0; // 0x8
	public static Func<string, int, int> <>9__4_0; // 0x10

	// Methods

	// RVA: 0x25A30B0 Offset: 0x25A22B0 VA: 0x1825A30B0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x25A2530 Offset: 0x25A1730 VA: 0x1825A2530
	internal int <GetValueFromBag>b__3_0(string s, int i) { }

	// RVA: 0x25A2530 Offset: 0x25A1730 VA: 0x1825A2530
	internal int <TryGetValueFromBag>b__4_0(string s, int i) { }
}

// Namespace: UnityEngine.UIElements
public class UxmlIntAttributeDescription : TypedUxmlAttributeDescription<int> // TypeDefIndex: 11601
{
	// Methods

	// RVA: 0x25AC460 Offset: 0x25AB660 VA: 0x1825AC460
	public void .ctor() { }

	// RVA: 0x25AC1C0 Offset: 0x25AB3C0 VA: 0x1825AC1C0 Slot: 4
	public override int GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x25AC310 Offset: 0x25AB510 VA: 0x1825AC310
	public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref int value) { }

	// RVA: 0x25AC180 Offset: 0x25AB380 VA: 0x1825AC180
	private static int ConvertValueToInt(string v, int defaultValue) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UxmlUnsignedIntAttributeDescription.<>c // TypeDefIndex: 11602
{
	// Fields
	public static readonly UxmlUnsignedIntAttributeDescription.<>c <>9; // 0x0
	public static Func<string, uint, uint> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x25A2FF0 Offset: 0x25A21F0 VA: 0x1825A2FF0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x25A27A0 Offset: 0x25A19A0 VA: 0x1825A27A0
	internal uint <GetValueFromBag>b__3_0(string s, uint i) { }
}

// Namespace: UnityEngine.UIElements
public class UxmlUnsignedIntAttributeDescription : TypedUxmlAttributeDescription<uint> // TypeDefIndex: 11603
{
	// Methods

	// RVA: 0x25ADF40 Offset: 0x25AD140 VA: 0x1825ADF40
	public void .ctor() { }

	// RVA: 0x25ADDF0 Offset: 0x25ACFF0 VA: 0x1825ADDF0 Slot: 4
	public override uint GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x25ADDB0 Offset: 0x25ACFB0 VA: 0x1825ADDB0
	private static uint ConvertValueToUInt(string v, uint defaultValue) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UxmlUnsignedLongAttributeDescription.<>c // TypeDefIndex: 11604
{
	// Fields
	public static readonly UxmlUnsignedLongAttributeDescription.<>c <>9; // 0x0
	public static Func<string, ulong, ulong> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x25A2F90 Offset: 0x25A2190 VA: 0x1825A2F90
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x25A24F0 Offset: 0x25A16F0 VA: 0x1825A24F0
	internal ulong <GetValueFromBag>b__3_0(string s, ulong l) { }
}

// Namespace: UnityEngine.UIElements
public class UxmlUnsignedLongAttributeDescription : TypedUxmlAttributeDescription<ulong> // TypeDefIndex: 11605
{
	// Methods

	// RVA: 0x25AE150 Offset: 0x25AD350 VA: 0x1825AE150
	public void .ctor() { }

	// RVA: 0x25AE000 Offset: 0x25AD200 VA: 0x1825AE000 Slot: 4
	public override ulong GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x25ADFC0 Offset: 0x25AD1C0 VA: 0x1825ADFC0
	private static ulong ConvertValueToUlong(string v, ulong defaultValue) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UxmlLongAttributeDescription.<>c // TypeDefIndex: 11606
{
	// Fields
	public static readonly UxmlLongAttributeDescription.<>c <>9; // 0x0
	public static Func<string, long, long> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x25A3170 Offset: 0x25A2370 VA: 0x1825A3170
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x25A25A0 Offset: 0x25A17A0 VA: 0x1825A25A0
	internal long <GetValueFromBag>b__3_0(string s, long l) { }
}

// Namespace: UnityEngine.UIElements
public class UxmlLongAttributeDescription : TypedUxmlAttributeDescription<long> // TypeDefIndex: 11607
{
	// Methods

	// RVA: 0x25AC670 Offset: 0x25AB870 VA: 0x1825AC670
	public void .ctor() { }

	// RVA: 0x25AC520 Offset: 0x25AB720 VA: 0x1825AC520 Slot: 4
	public override long GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x25AC4E0 Offset: 0x25AB6E0 VA: 0x1825AC4E0
	private static long ConvertValueToLong(string v, long defaultValue) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UxmlBoolAttributeDescription.<>c // TypeDefIndex: 11608
{
	// Fields
	public static readonly UxmlBoolAttributeDescription.<>c <>9; // 0x0
	public static Func<string, bool, bool> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x25A2E70 Offset: 0x25A2070 VA: 0x1825A2E70
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x25A25E0 Offset: 0x25A17E0 VA: 0x1825A25E0
	internal bool <GetValueFromBag>b__3_0(string s, bool b) { }
}

// Namespace: UnityEngine.UIElements
public class UxmlBoolAttributeDescription : TypedUxmlAttributeDescription<bool> // TypeDefIndex: 11609
{
	// Methods

	// RVA: 0x25AB7C0 Offset: 0x25AA9C0 VA: 0x1825AB7C0
	public void .ctor() { }

	// RVA: 0x25AB670 Offset: 0x25AA870 VA: 0x1825AB670 Slot: 4
	public override bool GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x25AB5F0 Offset: 0x25AA7F0 VA: 0x1825AB5F0
	private static bool ConvertValueToBool(string v, bool defaultValue) { }
}

// Namespace: UnityEngine.UIElements
public class UxmlTypeAttributeDescription<TBase> : TypedUxmlAttributeDescription<Type> // TypeDefIndex: 11610
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF05D0 Offset: 0xCEF7D0 VA: 0x180CF05D0
	|-UxmlTypeAttributeDescription<object>..ctor
	|
	|-RVA: 0xCF0540 Offset: 0xCEF740 VA: 0x180CF0540
	|-UxmlTypeAttributeDescription<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override Type GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF0320 Offset: 0xCEF520 VA: 0x180CF0320
	|-UxmlTypeAttributeDescription<object>.GetValueFromBag
	|
	|-RVA: 0xCF0410 Offset: 0xCEF610 VA: 0x180CF0410
	|-UxmlTypeAttributeDescription<__Il2CppFullySharedGenericType>.GetValueFromBag
	*/

	// RVA: -1 Offset: -1
	private Type ConvertValueToType(string v, Type defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF00B0 Offset: 0xCEF2B0 VA: 0x180CF00B0
	|-UxmlTypeAttributeDescription<object>.ConvertValueToType
	|
	|-RVA: 0xCEFE40 Offset: 0xCEF040 VA: 0x180CEFE40
	|-UxmlTypeAttributeDescription<__Il2CppFullySharedGenericType>.ConvertValueToType
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private Type <GetValueFromBag>b__3_0(string s, Type type1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF0520 Offset: 0xCEF720 VA: 0x180CF0520
	|-UxmlTypeAttributeDescription<object>.<GetValueFromBag>b__3_0
	|
	|-RVA: 0xCF0500 Offset: 0xCEF700 VA: 0x180CF0500
	|-UxmlTypeAttributeDescription<__Il2CppFullySharedGenericType>.<GetValueFromBag>b__3_0
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UxmlEnumAttributeDescription.<>c<T> // TypeDefIndex: 11611
{
	// Fields
	public static readonly UxmlEnumAttributeDescription.<>c<T> <>9; // 0x0
	public static Func<string, T, T> <>9__3_0; // 0x0
	public static Func<string, T, T> <>9__4_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08330 Offset: 0xB07530 VA: 0x180B08330
	|-UxmlEnumAttributeDescription.<>c<Int32Enum>..cctor
	|
	|-RVA: 0xB08640 Offset: 0xB07840 VA: 0x180B08640
	|-UxmlEnumAttributeDescription.<>c<__Il2CppFullySharedGenericStructType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-UxmlEnumAttributeDescription.<>c<Int32Enum>..ctor
	|-UxmlEnumAttributeDescription.<>c<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T <GetValueFromBag>b__3_0(string s, T convertible) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB06650 Offset: 0xB05850 VA: 0x180B06650
	|-UxmlEnumAttributeDescription.<>c<Int32Enum>.<GetValueFromBag>b__3_0
	|
	|-RVA: 0xB06670 Offset: 0xB05870 VA: 0x180B06670
	|-UxmlEnumAttributeDescription.<>c<__Il2CppFullySharedGenericStructType>.<GetValueFromBag>b__3_0
	*/

	// RVA: -1 Offset: -1
	internal T <TryGetValueFromBag>b__4_0(string s, T convertible) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB06650 Offset: 0xB05850 VA: 0x180B06650
	|-UxmlEnumAttributeDescription.<>c<Int32Enum>.<TryGetValueFromBag>b__4_0
	|
	|-RVA: 0xB06670 Offset: 0xB05870 VA: 0x180B06670
	|-UxmlEnumAttributeDescription.<>c<__Il2CppFullySharedGenericStructType>.<TryGetValueFromBag>b__4_0
	*/
}

// Namespace: UnityEngine.UIElements
public class UxmlEnumAttributeDescription<T> : TypedUxmlAttributeDescription<T> // TypeDefIndex: 11612
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE9200 Offset: 0xCE8400 VA: 0x180CE9200
	|-UxmlEnumAttributeDescription<Int32Enum>..ctor
	|
	|-RVA: 0xCE8BD0 Offset: 0xCE7DD0 VA: 0x180CE8BD0
	|-UxmlEnumAttributeDescription<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override T GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE8550 Offset: 0xCE7750 VA: 0x180CE8550
	|-UxmlEnumAttributeDescription<Int32Enum>.GetValueFromBag
	|
	|-RVA: 0xCE8250 Offset: 0xCE7450 VA: 0x180CE8250
	|-UxmlEnumAttributeDescription<__Il2CppFullySharedGenericStructType>.GetValueFromBag
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE89D0 Offset: 0xCE7BD0 VA: 0x180CE89D0
	|-UxmlEnumAttributeDescription<Int32Enum>.TryGetValueFromBag
	|
	|-RVA: 0xCE8730 Offset: 0xCE7930 VA: 0x180CE8730
	|-UxmlEnumAttributeDescription<__Il2CppFullySharedGenericStructType>.TryGetValueFromBag
	*/

	// RVA: -1 Offset: -1
	private static U ConvertValueToEnum<U>(string v, U defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F7B50 Offset: 0x8F6D50 VA: 0x1808F7B50
	|-UxmlEnumAttributeDescription<Int32Enum>.ConvertValueToEnum<Int32Enum>
	|
	|-RVA: 0x8F7800 Offset: 0x8F6A00 VA: 0x1808F7800
	|-UxmlEnumAttributeDescription<__Il2CppFullySharedGenericStructType>.ConvertValueToEnum<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private static string GetEnumNameErrorMessage(string v, Type enumType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE7E30 Offset: 0xCE7030 VA: 0x180CE7E30
	|-UxmlEnumAttributeDescription<Int32Enum>.GetEnumNameErrorMessage
	|
	|-RVA: 0xCE7FB0 Offset: 0xCE71B0 VA: 0x180CE7FB0
	|-UxmlEnumAttributeDescription<__Il2CppFullySharedGenericStructType>.GetEnumNameErrorMessage
	*/

	// RVA: -1 Offset: -1
	private static string GetEnumRangeErrorMessage(string v, Type enumType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE81C0 Offset: 0xCE73C0 VA: 0x180CE81C0
	|-UxmlEnumAttributeDescription<Int32Enum>.GetEnumRangeErrorMessage
	|
	|-RVA: 0xCE8130 Offset: 0xCE7330 VA: 0x180CE8130
	|-UxmlEnumAttributeDescription<__Il2CppFullySharedGenericStructType>.GetEnumRangeErrorMessage
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UxmlHash128AttributeDescription.<>c // TypeDefIndex: 11613
{
	// Fields
	public static readonly UxmlHash128AttributeDescription.<>c <>9; // 0x0
	public static Func<string, Hash128, Hash128> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x25A2E10 Offset: 0x25A2010 VA: 0x1825A2E10
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x25A2570 Offset: 0x25A1770 VA: 0x1825A2570
	internal Hash128 <GetValueFromBag>b__3_0(string s, Hash128 i) { }
}

// Namespace: UnityEngine.UIElements
public class UxmlHash128AttributeDescription : TypedUxmlAttributeDescription<Hash128> // TypeDefIndex: 11614
{
	// Methods

	// RVA: 0x25AC100 Offset: 0x25AB300 VA: 0x1825AC100
	public void .ctor() { }

	// RVA: 0x25ABF80 Offset: 0x25AB180 VA: 0x1825ABF80 Slot: 4
	public override Hash128 GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }
}

// Namespace: UnityEngine.UIElements
internal class UxmlObjectAttributeDescription<T> // TypeDefIndex: 11615
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private T <defaultValue>k__BackingField; // 0x0

	// Properties
	public T defaultValue { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public T get_defaultValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	|-UxmlObjectAttributeDescription<object>.get_defaultValue
	|
	|-RVA: 0xB16E40 Offset: 0xB16040 VA: 0x180B16E40
	|-UxmlObjectAttributeDescription<__Il2CppFullySharedGenericType>.get_defaultValue
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public virtual T GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE9BC0 Offset: 0xCE8DC0 VA: 0x180CE9BC0
	|-UxmlObjectAttributeDescription<object>.GetValueFromBag
	|
	|-RVA: 0xCE97D0 Offset: 0xCE89D0 VA: 0x180CE97D0
	|-UxmlObjectAttributeDescription<__Il2CppFullySharedGenericType>.GetValueFromBag
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-UxmlObjectAttributeDescription<object>..ctor
	|-UxmlObjectAttributeDescription<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine.UIElements
internal class UxmlObjectListAttributeDescription<T> : UxmlObjectAttributeDescription<List<T>> // TypeDefIndex: 11616
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override List<T> GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCEA450 Offset: 0xCE9650 VA: 0x180CEA450
	|-UxmlObjectListAttributeDescription<object>.GetValueFromBag
	|
	|-RVA: 0xCEA040 Offset: 0xCE9240 VA: 0x180CEA040
	|-UxmlObjectListAttributeDescription<__Il2CppFullySharedGenericType>.GetValueFromBag
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-UxmlObjectListAttributeDescription<object>..ctor
	|
	|-RVA: 0xCEA690 Offset: 0xCE9890 VA: 0x180CEA690
	|-UxmlObjectListAttributeDescription<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine.UIElements
public abstract class BaseUxmlTraits // TypeDefIndex: 11617
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <canHaveAnyAttribute>k__BackingField; // 0x10

	// Properties
	protected bool canHaveAnyAttribute { set; }

	// Methods

	// RVA: 0x1896720 Offset: 0x1895920 VA: 0x181896720
	protected void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	protected void set_canHaveAnyAttribute(bool value) { }
}

// Namespace: UnityEngine.UIElements
public abstract class UxmlTraits : BaseUxmlTraits // TypeDefIndex: 11618
{
	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1896720 Offset: 0x1895920 VA: 0x181896720
	protected void .ctor() { }
}

// Namespace: UnityEngine.UIElements
internal abstract class UxmlObjectTraits<T> : BaseUxmlTraits // TypeDefIndex: 11619
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public virtual void Init(ref T obj, IUxmlAttributes bag, CreationContext cc) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-UxmlObjectTraits<object>.Init
	|-UxmlObjectTraits<__Il2CppFullySharedGenericType>.Init
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCEB920 Offset: 0xCEAB20 VA: 0x180CEB920
	|-UxmlObjectTraits<object>..ctor
	|-UxmlObjectTraits<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine.UIElements
public interface IBaseUxmlFactory // TypeDefIndex: 11620
{
	// Properties
	public abstract string uxmlQualifiedName { get; }
	public abstract Type uxmlType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_uxmlQualifiedName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Type get_uxmlType();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc);
}

// Namespace: UnityEngine.UIElements
public interface IUxmlFactory : IBaseUxmlFactory // TypeDefIndex: 11621
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract VisualElement Create(IUxmlAttributes bag, CreationContext cc);
}

// Namespace: UnityEngine.UIElements
internal interface IBaseUxmlObjectFactory : IBaseUxmlFactory // TypeDefIndex: 11622
{}

// Namespace: UnityEngine.UIElements
internal interface IUxmlObjectFactory<T> : IBaseUxmlObjectFactory, IBaseUxmlFactory // TypeDefIndex: 11623
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T CreateObject(IUxmlAttributes bag, CreationContext cc);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IUxmlObjectFactory<__Il2CppFullySharedGenericType>.CreateObject
	*/
}

// Namespace: UnityEngine.UIElements
public abstract class BaseUxmlFactory<TCreatedType, TTraits> // TypeDefIndex: 11624
{
	// Fields
	internal TTraits m_Traits; // 0x0

	// Properties
	public virtual string uxmlName { get; }
	public virtual string uxmlNamespace { get; }
	public virtual string uxmlQualifiedName { get; }
	public virtual Type uxmlType { get; }

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE1A40 Offset: 0xEE0C40 VA: 0x180EE1A40
	|-BaseUxmlFactory<object, object>..ctor
	|-BaseUxmlFactory<__Il2CppFullySharedGenericType, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public virtual string get_uxmlName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE1B00 Offset: 0xEE0D00 VA: 0x180EE1B00
	|-BaseUxmlFactory<object, object>.get_uxmlName
	|
	|-RVA: 0xEE1A80 Offset: 0xEE0C80 VA: 0x180EE1A80
	|-BaseUxmlFactory<__Il2CppFullySharedGenericType, object>.get_uxmlName
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public virtual string get_uxmlNamespace() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE1B80 Offset: 0xEE0D80 VA: 0x180EE1B80
	|-BaseUxmlFactory<object, object>.get_uxmlNamespace
	|
	|-RVA: 0xEE1C20 Offset: 0xEE0E20 VA: 0x180EE1C20
	|-BaseUxmlFactory<__Il2CppFullySharedGenericType, object>.get_uxmlNamespace
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public virtual string get_uxmlQualifiedName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE1CC0 Offset: 0xEE0EC0 VA: 0x180EE1CC0
	|-BaseUxmlFactory<object, object>.get_uxmlQualifiedName
	|
	|-RVA: 0xEE1D40 Offset: 0xEE0F40 VA: 0x180EE1D40
	|-BaseUxmlFactory<__Il2CppFullySharedGenericType, object>.get_uxmlQualifiedName
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public virtual Type get_uxmlType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE1E20 Offset: 0xEE1020 VA: 0x180EE1E20
	|-BaseUxmlFactory<object, object>.get_uxmlType
	|
	|-RVA: 0xEE1DC0 Offset: 0xEE0FC0 VA: 0x180EE1DC0
	|-BaseUxmlFactory<__Il2CppFullySharedGenericType, object>.get_uxmlType
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public virtual bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD72460 Offset: 0xD71660 VA: 0x180D72460
	|-BaseUxmlFactory<object, object>.AcceptsAttributeBag
	|-BaseUxmlFactory<__Il2CppFullySharedGenericType, object>.AcceptsAttributeBag
	*/
}

// Namespace: UnityEngine.UIElements
public class UxmlFactory<TCreatedType, TTraits> : BaseUxmlFactory<TCreatedType, TTraits>, IUxmlFactory, IBaseUxmlFactory // TypeDefIndex: 11625
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 13
	public virtual VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE9720 Offset: 0xCE8920 VA: 0x180CE9720
	|-UxmlFactory<object, object>.Create
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE97B0 Offset: 0xCE89B0 VA: 0x180CE97B0
	|-UxmlFactory<object, object>..ctor
	*/
}

// Namespace: UnityEngine.UIElements
internal class UxmlObjectFactory<TCreatedType, TTraits> : BaseUxmlFactory<TCreatedType, TTraits>, IUxmlObjectFactory<TCreatedType>, IBaseUxmlObjectFactory, IBaseUxmlFactory // TypeDefIndex: 11626
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TCreatedType CreateObject(IUxmlAttributes bag, CreationContext cc) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE9F70 Offset: 0xCE9170 VA: 0x180CE9F70
	|-UxmlObjectFactory<object, object>.CreateObject
	|
	|-RVA: 0xCE9DB0 Offset: 0xCE8FB0 VA: 0x180CE9DB0
	|-UxmlObjectFactory<__Il2CppFullySharedGenericType, object>.CreateObject
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCEA000 Offset: 0xCE9200 VA: 0x180CEA000
	|-UxmlObjectFactory<object, object>..ctor
	|
	|-RVA: 0xCEA020 Offset: 0xCE9220 VA: 0x180CEA020
	|-UxmlObjectFactory<__Il2CppFullySharedGenericType, object>..ctor
	*/
}

// Namespace: UnityEngine.UIElements
public class UxmlFactory<TCreatedType> : UxmlFactory<TCreatedType, VisualElement.UxmlTraits> // TypeDefIndex: 11627
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCE96F0 Offset: 0xCE88F0 VA: 0x180CE96F0
	|-UxmlFactory<object>..ctor
	*/
}

// Namespace: UnityEngine.UIElements
[Serializable]
internal class UxmlAsset : IUxmlAttributes // TypeDefIndex: 11628
{
	// Fields
	[SerializeField]
	private string m_FullTypeName; // 0x10
	[SerializeField]
	private int m_Id; // 0x18
	[SerializeField]
	private int m_OrderInDocument; // 0x1C
	[SerializeField]
	private int m_ParentId; // 0x20
	[SerializeField]
	protected List<string> m_Properties; // 0x28

	// Properties
	public string fullTypeName { get; }
	public int id { get; }
	public int orderInDocument { get; }
	public int parentId { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_fullTypeName() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_id() { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public int get_orderInDocument() { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_parentId() { }

	// RVA: 0x25AAE10 Offset: 0x25AA010 VA: 0x1825AAE10 Slot: 4
	public bool TryGetAttributeValue(string propertyName, out string value) { }

	// RVA: 0x25AAC10 Offset: 0x25A9E10 VA: 0x1825AAC10
	public void SetAttribute(string name, string value) { }

	// RVA: 0x25AAC20 Offset: 0x25A9E20 VA: 0x1825AAC20
	private void SetOrAddProperty(string propertyName, string propertyValue) { }
}

// Namespace: UnityEngine.UIElements
[Serializable]
internal sealed class UxmlObjectAsset : UxmlAsset // TypeDefIndex: 11629
{}

// Namespace: UnityEngine.UIElements
internal class UxmlObjectFactoryRegistry // TypeDefIndex: 11630
{
	// Fields
	private static Dictionary<string, List<IBaseUxmlObjectFactory>> s_Factories; // 0x0

	// Properties
	internal static Dictionary<string, List<IBaseUxmlObjectFactory>> factories { get; }

	// Methods

	// RVA: 0x25AD090 Offset: 0x25AC290 VA: 0x1825AD090
	internal static Dictionary<string, List<IBaseUxmlObjectFactory>> get_factories() { }

	// RVA: 0x25AC940 Offset: 0x25ABB40 VA: 0x1825AC940
	protected static void RegisterFactory(IBaseUxmlObjectFactory factory) { }

	// RVA: 0x25AD030 Offset: 0x25AC230 VA: 0x1825AD030
	internal static bool TryGetFactories(string fullTypeName, out List<IBaseUxmlObjectFactory> factoryList) { }

	// RVA: 0x25AC6F0 Offset: 0x25AB8F0 VA: 0x1825AC6F0
	private static void RegisterEngineFactories() { }

	// RVA: 0x25ACD30 Offset: 0x25ABF30 VA: 0x1825ACD30
	private static void RegisterUserFactories() { }
}

// Namespace: UnityEngine.UIElements
public abstract class UxmlTypeRestriction : IEquatable<UxmlTypeRestriction> // TypeDefIndex: 11631
{
	// Methods

	// RVA: 0x25ADDA0 Offset: 0x25ACFA0 VA: 0x1825ADDA0 Slot: 5
	public virtual bool Equals(UxmlTypeRestriction other) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: UnityEngine.UIElements
public class UxmlEnumeration : UxmlTypeRestriction // TypeDefIndex: 11632
{
	// Fields
	private List<string> m_Values; // 0x10

	// Properties
	public IEnumerable<string> values { get; set; }

	// Methods

	// RVA: 0x1208660 Offset: 0x1207860 VA: 0x181208660
	public IEnumerable<string> get_values() { }

	// RVA: 0x25ABC80 Offset: 0x25AAE80 VA: 0x1825ABC80
	public void set_values(IEnumerable<string> value) { }

	// RVA: 0x25ABAB0 Offset: 0x25AACB0 VA: 0x1825ABAB0 Slot: 5
	public override bool Equals(UxmlTypeRestriction other) { }

	// RVA: 0x25ABC10 Offset: 0x25AAE10 VA: 0x1825ABC10
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements
[Serializable]
internal class VisualElementAsset : UxmlAsset, ISerializationCallbackReceiver // TypeDefIndex: 11633
{
	// Fields
	[SerializeField]
	private string m_Name; // 0x30
	[SerializeField]
	private int m_RuleIndex; // 0x38
	[SerializeField]
	private string m_Text; // 0x40
	[SerializeField]
	private PickingMode m_PickingMode; // 0x48
	[SerializeField]
	private string[] m_Classes; // 0x50
	[SerializeField]
	private List<string> m_StylesheetPaths; // 0x58
	[SerializeField]
	private List<StyleSheet> m_Stylesheets; // 0x60
	[SerializeField]
	private bool m_SkipClone; // 0x68

	// Properties
	public int ruleIndex { get; }
	public string[] classes { get; }
	public List<string> stylesheetPaths { get; }
	public bool hasStylesheetPaths { get; }
	public List<StyleSheet> stylesheets { get; }
	public bool hasStylesheets { get; }
	internal bool skipClone { get; }

	// Methods

	// RVA: 0x25AE3D0 Offset: 0x25AD5D0 VA: 0x1825AE3D0
	public int get_ruleIndex() { }

	// RVA: 0x24CAE50 Offset: 0x24CA050 VA: 0x1824CAE50
	public string[] get_classes() { }

	// RVA: 0x25AE3E0 Offset: 0x25AD5E0 VA: 0x1825AE3E0
	public List<string> get_stylesheetPaths() { }

	// RVA: 0x780880 Offset: 0x77FA80 VA: 0x180780880
	public bool get_hasStylesheetPaths() { }

	// RVA: 0x25AE450 Offset: 0x25AD650 VA: 0x1825AE450
	public List<StyleSheet> get_stylesheets() { }

	// RVA: 0x1650470 Offset: 0x164F670 VA: 0x181650470
	public bool get_hasStylesheets() { }

	// RVA: 0x563E40 Offset: 0x563040 VA: 0x180563E40
	internal bool get_skipClone() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	public void OnBeforeSerialize() { }

	// RVA: 0x25AE240 Offset: 0x25AD440 VA: 0x1825AE240 Slot: 6
	public void OnAfterDeserialize() { }
}

// Namespace: UnityEngine.UIElements
internal class VisualElementFactoryRegistry // TypeDefIndex: 11634
{
	// Fields
	private static Dictionary<string, List<IUxmlFactory>> s_Factories; // 0x0
	private static Dictionary<string, List<IUxmlFactory>> s_MovedTypesFactories; // 0x8

	// Properties
	internal static Dictionary<string, List<IUxmlFactory>> factories { get; }

	// Methods

	// RVA: 0x25AEDC0 Offset: 0x25ADFC0 VA: 0x1825AEDC0
	private static string GetMovedUIControlTypeName(Type type, MovedFromAttribute attr) { }

	// RVA: 0x25B0E70 Offset: 0x25B0070 VA: 0x1825B0E70
	internal static Dictionary<string, List<IUxmlFactory>> get_factories() { }

	// RVA: 0x25B0460 Offset: 0x25AF660 VA: 0x1825B0460
	protected static void RegisterFactory(IUxmlFactory factory) { }

	// RVA: 0x25B0DD0 Offset: 0x25AFFD0 VA: 0x1825B0DD0
	internal static bool TryGetValue(string fullTypeName, out List<IUxmlFactory> factoryList) { }

	// RVA: 0x25AEF30 Offset: 0x25AE130 VA: 0x1825AEF30
	private static void RegisterEngineFactories() { }

	// RVA: 0x25B0AD0 Offset: 0x25AFCD0 VA: 0x1825B0AD0
	internal static void RegisterUserFactories() { }
}

// Namespace: 
[Serializable]
internal struct VisualTreeAsset.UsingEntry // TypeDefIndex: 11635
{
	// Fields
	internal static readonly IComparer<VisualTreeAsset.UsingEntry> comparer; // 0x0
	[SerializeField]
	public string alias; // 0x0
	[SerializeField]
	public string path; // 0x8
	[SerializeField]
	public VisualTreeAsset asset; // 0x10

	// Methods

	// RVA: 0x23A34E0 Offset: 0x23A26E0 VA: 0x1823A34E0
	public void .ctor(string alias, string path) { }

	// RVA: 0x25AABB0 Offset: 0x25A9DB0 VA: 0x1825AABB0
	private static void .cctor() { }
}

// Namespace: 
private class VisualTreeAsset.UsingEntryComparer : IComparer<VisualTreeAsset.UsingEntry> // TypeDefIndex: 11636
{
	// Methods

	// RVA: 0x25AAB80 Offset: 0x25A9D80 VA: 0x1825AAB80 Slot: 4
	public int Compare(VisualTreeAsset.UsingEntry x, VisualTreeAsset.UsingEntry y) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
internal struct VisualTreeAsset.SlotDefinition // TypeDefIndex: 11637
{
	// Fields
	[SerializeField]
	public string name; // 0x0
	[SerializeField]
	public int insertionPointId; // 0x8
}

// Namespace: 
[Serializable]
internal struct VisualTreeAsset.SlotUsageEntry // TypeDefIndex: 11638
{
	// Fields
	[SerializeField]
	public string slotName; // 0x0
	[SerializeField]
	public int assetId; // 0x8
}

// Namespace: 
[Serializable]
internal struct VisualTreeAsset.UxmlObjectEntry // TypeDefIndex: 11639
{
	// Fields
	[SerializeField]
	public int parentId; // 0x0
	[SerializeField]
	public List<UxmlObjectAsset> uxmlObjectAssets; // 0x8

	// Methods

	// RVA: 0xBB0D00 Offset: 0xBAFF00 VA: 0x180BB0D00
	public void .ctor(int parentId, List<UxmlObjectAsset> uxmlObjectAssets) { }
}

// Namespace: 
[Serializable]
private struct VisualTreeAsset.AssetEntry // TypeDefIndex: 11640
{
	// Fields
	[SerializeField]
	public string path; // 0x0
	[SerializeField]
	public string typeFullName; // 0x8
	[SerializeField]
	public Object asset; // 0x10
	private Type m_CachedType; // 0x18

	// Properties
	public Type type { get; }

	// Methods

	// RVA: 0x259C480 Offset: 0x259B680 VA: 0x18259C480
	public Type get_type() { }

	// RVA: 0x259C420 Offset: 0x259B620 VA: 0x18259C420
	public void .ctor(string path, Type type, Object asset) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class VisualTreeAsset.<>c__DisplayClass61_0 // TypeDefIndex: 11641
{
	// Fields
	public VisualElementAsset childVea; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x25A2CC0 Offset: 0x25A1EC0 VA: 0x1825A2CC0
	internal bool <CloneSetupRecursively>b__0(VisualTreeAsset.SlotUsageEntry u) { }
}

// Namespace: 
[CompilerGenerated]
private struct VisualTreeAsset.<>c__DisplayClass65_0 // TypeDefIndex: 11642
{
	// Fields
	public VisualElementAsset asset; // 0x0
}

// Namespace: 
[CompilerGenerated]
private sealed class VisualTreeAsset.<get_stylesheets>d__23 : IEnumerable<StyleSheet>, IEnumerable, IEnumerator<StyleSheet>, IEnumerator, IDisposable // TypeDefIndex: 11643
{
	// Fields
	private int <>1__state; // 0x10
	private StyleSheet <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public VisualTreeAsset <>4__this; // 0x28
	private HashSet<StyleSheet> <sent>5__1; // 0x30
	private List.Enumerator<VisualElementAsset> <>s__2; // 0x38
	private VisualElementAsset <vea>5__3; // 0x50
	private List.Enumerator<StyleSheet> <>s__4; // 0x58
	private StyleSheet <stylesheet>5__5; // 0x70
	private List.Enumerator<string> <>s__6; // 0x78
	private string <stylesheetPath>5__7; // 0x90
	private StyleSheet <stylesheet>5__8; // 0x98

	// Properties
	private StyleSheet System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StyleSheet>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x25A3A00 Offset: 0x25A2C00 VA: 0x1825A3A00 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x25A3230 Offset: 0x25A2430 VA: 0x1825A3230 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x25A3B90 Offset: 0x25A2D90 VA: 0x1825A3B90
	private void <>m__Finally1() { }

	// RVA: 0x25A3BE0 Offset: 0x25A2DE0 VA: 0x1825A3BE0
	private void <>m__Finally2() { }

	// RVA: 0x25A3C30 Offset: 0x25A2E30 VA: 0x1825A3C30
	private void <>m__Finally3() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	private StyleSheet System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StyleSheet>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x25A39C0 Offset: 0x25A2BC0 VA: 0x1825A39C0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x25A3920 Offset: 0x25A2B20 VA: 0x1825A3920 Slot: 4
	private IEnumerator<StyleSheet> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StyleSheet>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x25A3920 Offset: 0x25A2B20 VA: 0x1825A3920 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class VisualTreeAsset.<get_templateDependencies>d__19 : IEnumerable<VisualTreeAsset>, IEnumerable, IEnumerator<VisualTreeAsset>, IEnumerator, IDisposable // TypeDefIndex: 11644
{
	// Fields
	private int <>1__state; // 0x10
	private VisualTreeAsset <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public VisualTreeAsset <>4__this; // 0x28
	private HashSet<VisualTreeAsset> <sent>5__1; // 0x30
	private List.Enumerator<VisualTreeAsset.UsingEntry> <>s__2; // 0x38
	private VisualTreeAsset.UsingEntry <entry>5__3; // 0x60
	private VisualTreeAsset <vta>5__4; // 0x78

	// Properties
	private VisualTreeAsset System.Collections.Generic.IEnumerator<UnityEngine.UIElements.VisualTreeAsset>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x25A42C0 Offset: 0x25A34C0 VA: 0x1825A42C0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x25A3C80 Offset: 0x25A2E80 VA: 0x1825A3C80 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x25A4350 Offset: 0x25A3550 VA: 0x1825A4350
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	private VisualTreeAsset System.Collections.Generic.IEnumerator<UnityEngine.UIElements.VisualTreeAsset>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x25A4280 Offset: 0x25A3480 VA: 0x1825A4280 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x25A41E0 Offset: 0x25A33E0 VA: 0x1825A41E0 Slot: 4
	private IEnumerator<VisualTreeAsset> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualTreeAsset>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x25A41E0 Offset: 0x25A33E0 VA: 0x1825A41E0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: UnityEngine.UIElements
[HelpURL("UIE-VisualTree-landing")]
[Serializable]
public class VisualTreeAsset : ScriptableObject // TypeDefIndex: 11645
{
	// Fields
	internal static string LinkedVEAInTemplatePropertyName; // 0x0
	[SerializeField]
	private bool m_ImportedWithErrors; // 0x18
	[SerializeField]
	private bool m_ImportedWithWarnings; // 0x19
	private static readonly Dictionary<string, VisualElement> s_TemporarySlotInsertionPoints; // 0x8
	[SerializeField]
	private List<VisualTreeAsset.UsingEntry> m_Usings; // 0x20
	[SerializeField]
	internal StyleSheet inlineSheet; // 0x28
	[SerializeField]
	private List<VisualElementAsset> m_VisualElementAssets; // 0x30
	[SerializeField]
	private List<TemplateAsset> m_TemplateAssets; // 0x38
	[SerializeField]
	private List<VisualTreeAsset.UxmlObjectEntry> m_UxmlObjectEntries; // 0x40
	[SerializeField]
	private List<int> m_UxmlObjectIds; // 0x48
	[SerializeField]
	private List<VisualTreeAsset.AssetEntry> m_AssetEntries; // 0x50
	[SerializeField]
	private List<VisualTreeAsset.SlotDefinition> m_Slots; // 0x58
	[SerializeField]
	private int m_ContentContainerId; // 0x60
	[SerializeField]
	private int m_ContentHash; // 0x64

	// Properties
	public bool importedWithErrors { get; set; }
	public bool importedWithWarnings { get; set; }
	public IEnumerable<VisualTreeAsset> templateDependencies { get; }
	public IEnumerable<StyleSheet> stylesheets { get; }
	internal List<VisualElementAsset> visualElementAssets { get; set; }
	internal List<TemplateAsset> templateAssets { get; set; }
	internal List<VisualTreeAsset.UxmlObjectEntry> uxmlObjectEntries { get; }
	internal List<int> uxmlObjectIds { get; }
	internal List<VisualTreeAsset.SlotDefinition> slots { get; set; }
	internal int contentContainerId { get; set; }
	public int contentHash { get; set; }

	// Methods

	// RVA: 0x254DE70 Offset: 0x254D070 VA: 0x18254DE70
	public bool get_importedWithErrors() { }

	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	internal void set_importedWithErrors(bool value) { }

	// RVA: 0x25B6200 Offset: 0x25B5400 VA: 0x1825B6200
	public bool get_importedWithWarnings() { }

	// RVA: 0x630F50 Offset: 0x630150 VA: 0x180630F50
	internal void set_importedWithWarnings(bool value) { }

	// RVA: 0x25B50E0 Offset: 0x25B42E0 VA: 0x1825B50E0
	internal int GetNextChildSerialNumber() { }

	[IteratorStateMachine(typeof(VisualTreeAsset.<get_templateDependencies>d__19))]
	// RVA: 0x25B6280 Offset: 0x25B5480 VA: 0x1825B6280
	public IEnumerable<VisualTreeAsset> get_templateDependencies() { }

	[IteratorStateMachine(typeof(VisualTreeAsset.<get_stylesheets>d__23))]
	// RVA: 0x25B6210 Offset: 0x25B5410 VA: 0x1825B6210
	public IEnumerable<StyleSheet> get_stylesheets() { }

	// RVA: 0x2497C20 Offset: 0x2496E20 VA: 0x182497C20
	internal List<VisualElementAsset> get_visualElementAssets() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	internal void set_visualElementAssets(List<VisualElementAsset> value) { }

	// RVA: 0x24CAD90 Offset: 0x24C9F90 VA: 0x1824CAD90
	internal List<TemplateAsset> get_templateAssets() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	internal void set_templateAssets(List<TemplateAsset> value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	internal List<VisualTreeAsset.UxmlObjectEntry> get_uxmlObjectEntries() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	internal List<int> get_uxmlObjectIds() { }

	// RVA: 0x25B5980 Offset: 0x25B4B80 VA: 0x1825B5980
	internal void RegisterUxmlObject(UxmlObjectAsset uxmlObjectAsset) { }

	// RVA: -1 Offset: -1
	internal List<T> GetUxmlObjects<T>(IUxmlAttributes asset, CreationContext cc) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA3CE0 Offset: 0xAA2EE0 VA: 0x180AA3CE0
	|-VisualTreeAsset.GetUxmlObjects<object>
	|
	|-RVA: 0xAA3930 Offset: 0xAA2B30 VA: 0x180AA3930
	|-VisualTreeAsset.GetUxmlObjects<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x25B30A0 Offset: 0x25B22A0 VA: 0x1825B30A0
	internal bool AssetEntryExists(string path, Type type) { }

	// RVA: 0x25B5810 Offset: 0x25B4A10 VA: 0x1825B5810
	internal void RegisterAssetEntry(string path, Type type, Object asset) { }

	// RVA: -1 Offset: -1
	internal T GetAsset<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA36D0 Offset: 0xAA28D0 VA: 0x180AA36D0
	|-VisualTreeAsset.GetAsset<object>
	*/

	// RVA: 0x25B5160 Offset: 0x25B4360 VA: 0x1825B5160
	internal VisualTreeAsset.UxmlObjectEntry GetUxmlObjectEntry(int id) { }

	// RVA: 0x25B52A0 Offset: 0x25B44A0 VA: 0x1825B52A0
	private IBaseUxmlObjectFactory GetUxmlObjectFactory(UxmlObjectAsset uxmlObjectAsset) { }

	// RVA: 0x24CAD80 Offset: 0x24C9F80 VA: 0x1824CAD80
	internal List<VisualTreeAsset.SlotDefinition> get_slots() { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	internal void set_slots(List<VisualTreeAsset.SlotDefinition> value) { }

	// RVA: 0x25B61E0 Offset: 0x25B53E0 VA: 0x1825B61E0
	internal int get_contentContainerId() { }

	// RVA: 0x42D900 Offset: 0x42CB00 VA: 0x18042D900
	internal void set_contentContainerId(int value) { }

	// RVA: 0x25B56E0 Offset: 0x25B48E0 VA: 0x1825B56E0
	public TemplateContainer Instantiate() { }

	// RVA: 0x25B47C0 Offset: 0x25B39C0 VA: 0x1825B47C0
	public TemplateContainer Instantiate(string bindingPath) { }

	// RVA: 0x25B4950 Offset: 0x25B3B50 VA: 0x1825B4950
	public TemplateContainer CloneTree() { }

	// RVA: 0x25B47C0 Offset: 0x25B39C0 VA: 0x1825B47C0
	public TemplateContainer CloneTree(string bindingPath) { }

	// RVA: 0x25B40A0 Offset: 0x25B32A0 VA: 0x1825B40A0
	public void CloneTree(VisualElement target) { }

	// RVA: 0x25B47F0 Offset: 0x25B39F0 VA: 0x1825B47F0
	public void CloneTree(VisualElement target, out int firstElementIndex, out int elementAddedCount) { }

	// RVA: 0x25B40D0 Offset: 0x25B32D0 VA: 0x1825B40D0
	internal void CloneTree(VisualElement target, Dictionary<string, VisualElement> slotInsertionPoints, List<TemplateAsset.AttributeOverride> attributeOverrides) { }

	// RVA: 0x25B35E0 Offset: 0x25B27E0 VA: 0x1825B35E0
	private VisualElement CloneSetupRecursively(VisualElementAsset root, Dictionary<int, List<VisualElementAsset>> idToChildren, CreationContext context) { }

	// RVA: 0x25B4960 Offset: 0x25B3B60 VA: 0x1825B4960
	private static int CompareForOrder(VisualElementAsset a, VisualElementAsset b) { }

	// RVA: 0x25B5F30 Offset: 0x25B5130 VA: 0x1825B5F30
	internal bool TryGetSlotInsertionPoint(int insertionPointId, out string slotName) { }

	// RVA: 0x25B5C80 Offset: 0x25B4E80 VA: 0x1825B5C80
	internal VisualTreeAsset ResolveTemplate(string templateName) { }

	// RVA: 0x25B4990 Offset: 0x25B3B90 VA: 0x1825B4990
	internal static VisualElement Create(VisualElementAsset asset, CreationContext ctx) { }

	// RVA: 0x25B3250 Offset: 0x25B2450 VA: 0x1825B3250
	private static void AssignClassListFromAssetToElement(VisualElementAsset asset, VisualElement element) { }

	// RVA: 0x25B32E0 Offset: 0x25B24E0 VA: 0x1825B32E0
	private static void AssignStyleSheetFromAssetToElement(VisualElementAsset asset, VisualElement element) { }

	// RVA: 0x25B61F0 Offset: 0x25B53F0 VA: 0x1825B61F0
	public int get_contentHash() { }

	// RVA: 0x677720 Offset: 0x676920 VA: 0x180677720
	public void set_contentHash(int value) { }

	// RVA: 0x576FC0 Offset: 0x5761C0 VA: 0x180576FC0
	public void .ctor() { }

	// RVA: 0x25B6140 Offset: 0x25B5340 VA: 0x1825B6140
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x25B5FF0 Offset: 0x25B51F0 VA: 0x1825B5FF0
	internal static VisualElement <Create>g__CreateError|65_0(ref VisualTreeAsset.<>c__DisplayClass65_0 ) { }
}

// Namespace: UnityEngine.UIElements
public struct CreationContext : IEquatable<CreationContext> // TypeDefIndex: 11646
{
	// Fields
	public static readonly CreationContext Default; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VisualElement <target>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VisualTreeAsset <visualTreeAsset>k__BackingField; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Dictionary<string, VisualElement> <slotInsertionPoints>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private List<TemplateAsset.AttributeOverride> <attributeOverrides>k__BackingField; // 0x18

	// Properties
	public VisualElement target { get; set; }
	public VisualTreeAsset visualTreeAsset { get; set; }
	public Dictionary<string, VisualElement> slotInsertionPoints { get; set; }
	internal List<TemplateAsset.AttributeOverride> attributeOverrides { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public VisualElement get_target() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	private void set_target(VisualElement value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public VisualTreeAsset get_visualTreeAsset() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	private void set_visualTreeAsset(VisualTreeAsset value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Dictionary<string, VisualElement> get_slotInsertionPoints() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_slotInsertionPoints(Dictionary<string, VisualElement> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal List<TemplateAsset.AttributeOverride> get_attributeOverrides() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	private void set_attributeOverrides(List<TemplateAsset.AttributeOverride> value) { }

	// RVA: 0x259C910 Offset: 0x259BB10 VA: 0x18259C910
	internal void .ctor(Dictionary<string, VisualElement> slotInsertionPoints, VisualTreeAsset vta, VisualElement target) { }

	// RVA: 0x259C890 Offset: 0x259BA90 VA: 0x18259C890
	internal void .ctor(Dictionary<string, VisualElement> slotInsertionPoints, List<TemplateAsset.AttributeOverride> attributeOverrides, VisualTreeAsset vta, VisualElement target) { }

	// RVA: 0x259C670 Offset: 0x259B870 VA: 0x18259C670 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x259C510 Offset: 0x259B710 VA: 0x18259C510 Slot: 4
	public bool Equals(CreationContext other) { }

	// RVA: 0x259C730 Offset: 0x259B930 VA: 0x18259C730 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x259C850 Offset: 0x259BA50 VA: 0x18259C850
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements
internal enum GradientType // TypeDefIndex: 11647
{
	// Fields
	public int value__; // 0x0
	public const GradientType Linear = 0;
	public const GradientType Radial = 1;
}

// Namespace: UnityEngine.UIElements
internal enum AddressMode // TypeDefIndex: 11648
{
	// Fields
	public int value__; // 0x0
	public const AddressMode Wrap = 0;
	public const AddressMode Clamp = 1;
	public const AddressMode Mirror = 2;
}

// Namespace: UnityEngine.UIElements
[Serializable]
internal struct VectorImageVertex // TypeDefIndex: 11649
{
	// Fields
	public Vector3 position; // 0x0
	public Color32 tint; // 0xC
	public Vector2 uv; // 0x10
	public uint settingIndex; // 0x18
	public Color32 flags; // 0x1C
	public Vector4 circle; // 0x20
}

// Namespace: UnityEngine.UIElements
[Serializable]
internal struct GradientSettings // TypeDefIndex: 11650
{
	// Fields
	public GradientType gradientType; // 0x0
	public AddressMode addressMode; // 0x4
	public Vector2 radialFocus; // 0x8
	public RectInt location; // 0x10
}

// Namespace: UnityEngine.UIElements
[Serializable]
public class VectorImage : ScriptableObject // TypeDefIndex: 11651
{
	// Fields
	[SerializeField]
	internal int version; // 0x18
	[SerializeField]
	internal Texture2D atlas; // 0x20
	[SerializeField]
	internal VectorImageVertex[] vertices; // 0x28
	[SerializeField]
	internal ushort[] indices; // 0x30
	[SerializeField]
	internal GradientSettings[] settings; // 0x38
	[SerializeField]
	internal Vector2 size; // 0x40

	// Properties
	public float width { get; }
	public float height { get; }

	// Methods

	// RVA: 0x78EC10 Offset: 0x78DE10 VA: 0x18078EC10
	public float get_width() { }

	// RVA: 0x78EC00 Offset: 0x78DE00 VA: 0x18078EC00
	public float get_height() { }

	// RVA: 0x25AE1D0 Offset: 0x25AD3D0 VA: 0x1825AE1D0
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements
[Flags]
internal enum PseudoStates // TypeDefIndex: 11652
{
	// Fields
	public int value__; // 0x0
	public const PseudoStates Active = 1;
	public const PseudoStates Hover = 2;
	public const PseudoStates Checked = 8;
	public const PseudoStates Disabled = 32;
	public const PseudoStates Focus = 64;
	public const PseudoStates Root = 128;
}

// Namespace: UnityEngine.UIElements
[Flags]
internal enum VisualElementFlags // TypeDefIndex: 11653
{
	// Fields
	public int value__; // 0x0
	public const VisualElementFlags WorldTransformDirty = 1;
	public const VisualElementFlags WorldTransformInverseDirty = 2;
	public const VisualElementFlags WorldClipDirty = 4;
	public const VisualElementFlags BoundingBoxDirty = 8;
	public const VisualElementFlags WorldBoundingBoxDirty = 16;
	public const VisualElementFlags EventCallbackParentCategoriesDirty = 32;
	public const VisualElementFlags LayoutManual = 64;
	public const VisualElementFlags CompositeRoot = 128;
	public const VisualElementFlags RequireMeasureFunction = 256;
	public const VisualElementFlags EnableViewDataPersistence = 512;
	public const VisualElementFlags DisableClipping = 1024;
	public const VisualElementFlags NeedsAttachToPanelEvent = 2048;
	public const VisualElementFlags HierarchyDisplayed = 4096;
	public const VisualElementFlags StyleInitialized = 8192;
	public const VisualElementFlags Init = 4159;
}

// Namespace: UnityEngine.UIElements
public enum PickingMode // TypeDefIndex: 11654
{
	// Fields
	public int value__; // 0x0
	public const PickingMode Position = 0;
	public const PickingMode Ignore = 1;
}

// Namespace: UnityEngine.UIElements
public enum LanguageDirection // TypeDefIndex: 11655
{
	// Fields
	public int value__; // 0x0
	public const LanguageDirection Inherit = 0;
	public const LanguageDirection LTR = 1;
	public const LanguageDirection RTL = 2;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class VisualElementListPool.<>c // TypeDefIndex: 11656
{
	// Fields
	public static readonly VisualElementListPool.<>c <>9; // 0x0

	// Methods

	// RVA: 0x25A31D0 Offset: 0x25A23D0 VA: 0x1825A31D0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x25A2B30 Offset: 0x25A1D30 VA: 0x1825A2B30
	internal List<VisualElement> <.cctor>b__4_0() { }
}

// Namespace: UnityEngine.UIElements
internal static class VisualElementListPool // TypeDefIndex: 11657
{
	// Fields
	private static ObjectPool<List<VisualElement>> pool; // 0x0

	// Methods

	// RVA: 0x25B2D70 Offset: 0x25B1F70 VA: 0x1825B2D70
	public static List<VisualElement> Copy(List<VisualElement> elements) { }

	// RVA: 0x25B2E20 Offset: 0x25B2020 VA: 0x1825B2E20
	public static List<VisualElement> Get(int initialCapacity = 0) { }

	// RVA: 0x25B2EF0 Offset: 0x25B20F0 VA: 0x1825B2EF0
	public static void Release(List<VisualElement> elements) { }

	// RVA: 0x25B2FA0 Offset: 0x25B21A0 VA: 0x1825B2FA0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ObjectListPool.<>c<T> // TypeDefIndex: 11658
{
	// Fields
	public static readonly ObjectListPool.<>c<T> <>9; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08330 Offset: 0xB07530 VA: 0x180B08330
	|-ObjectListPool.<>c<object>..cctor
	|
	|-RVA: 0xB08640 Offset: 0xB07840 VA: 0x180B08640
	|-ObjectListPool.<>c<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-ObjectListPool.<>c<object>..ctor
	|-ObjectListPool.<>c<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal List<T> <.cctor>b__4_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB07D80 Offset: 0xB06F80 VA: 0x180B07D80
	|-ObjectListPool.<>c<object>.<.cctor>b__4_0
	|
	|-RVA: 0xB06C90 Offset: 0xB05E90 VA: 0x180B06C90
	|-ObjectListPool.<>c<__Il2CppFullySharedGenericType>.<.cctor>b__4_0
	*/
}

// Namespace: UnityEngine.UIElements
internal class ObjectListPool<T> // TypeDefIndex: 11659
{
	// Fields
	private static ObjectPool<List<T>> pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static List<T> Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB75B00 Offset: 0xB74D00 VA: 0x180B75B00
	|-ObjectListPool<object>.Get
	|
	|-RVA: 0xB75C10 Offset: 0xB74E10 VA: 0x180B75C10
	|-ObjectListPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(List<T> elements) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB75E90 Offset: 0xB75090 VA: 0x180B75E90
	|-ObjectListPool<object>.Release
	|
	|-RVA: 0xB75D20 Offset: 0xB74F20 VA: 0x180B75D20
	|-ObjectListPool<__Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB762B0 Offset: 0xB754B0 VA: 0x180B762B0
	|-ObjectListPool<object>..cctor
	|
	|-RVA: 0xB76050 Offset: 0xB75250 VA: 0x180B76050
	|-ObjectListPool<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: UnityEngine.UIElements
[Extension]
public static class VisualElementExtensions // TypeDefIndex: 11660
{
	// Methods

	[Extension]
	// RVA: 0x25AE800 Offset: 0x25ADA00 VA: 0x1825AE800
	public static void StretchToParentSize(VisualElement elem) { }

	[Extension]
	// RVA: 0x25AE4C0 Offset: 0x25AD6C0 VA: 0x1825AE4C0
	public static void AddManipulator(VisualElement ele, IManipulator manipulator) { }

	[Extension]
	// RVA: 0x25AE7B0 Offset: 0x25AD9B0 VA: 0x1825AE7B0
	public static void RemoveManipulator(VisualElement ele, IManipulator manipulator) { }

	[Extension]
	// RVA: 0x25AECE0 Offset: 0x25ADEE0 VA: 0x1825AECE0
	public static Vector2 WorldToLocal(VisualElement ele, Vector2 p) { }

	[Extension]
	// RVA: 0x25AE6D0 Offset: 0x25AD8D0 VA: 0x1825AE6D0
	public static Vector2 LocalToWorld(VisualElement ele, Vector2 p) { }

	[Extension]
	// RVA: 0x25AEC00 Offset: 0x25ADE00 VA: 0x1825AEC00
	public static Rect WorldToLocal(VisualElement ele, Rect r) { }

	[Extension]
	// RVA: 0x25AE510 Offset: 0x25AD710 VA: 0x1825AE510
	public static Vector2 ChangeCoordinatesTo(VisualElement src, VisualElement dest, Vector2 point) { }
}

// Namespace: 
private struct EventInterestReflectionUtils.DefaultEventInterests // TypeDefIndex: 11661
{
	// Fields
	public int DefaultActionCategories; // 0x0
	public int DefaultActionAtTargetCategories; // 0x4
}

// Namespace: UnityEngine.UIElements
internal static class EventInterestReflectionUtils // TypeDefIndex: 11662
{
	// Fields
	private static readonly Dictionary<Type, EventInterestReflectionUtils.DefaultEventInterests> s_DefaultEventInterests; // 0x0
	private static readonly Dictionary<Type, EventCategory> s_EventCategories; // 0x8

	// Methods

	// RVA: 0x259CC60 Offset: 0x259BE60 VA: 0x18259CC60
	internal static void GetDefaultEventInterests(Type elementType, out int defaultActionCategories, out int defaultActionAtTargetCategories) { }

	// RVA: 0x259CA20 Offset: 0x259BC20 VA: 0x18259CA20
	private static int ComputeDefaultEventInterests(Type elementType, string methodName) { }

	// RVA: 0x259CE90 Offset: 0x259C090 VA: 0x18259CE90
	internal static EventCategory GetEventCategory(Type eventType) { }

	// RVA: 0x259D0D0 Offset: 0x259C2D0 VA: 0x18259D0D0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements
internal enum EventCategory // TypeDefIndex: 11663
{
	// Fields
	public int value__; // 0x0
	public const EventCategory Default = 0;
	public const EventCategory Pointer = 1;
	public const EventCategory PointerMove = 2;
	public const EventCategory EnterLeave = 3;
	public const EventCategory EnterLeaveWindow = 4;
	public const EventCategory Keyboard = 5;
	public const EventCategory Geometry = 6;
	public const EventCategory Style = 7;
	public const EventCategory ChangeValue = 8;
	public const EventCategory Bind = 9;
	public const EventCategory Focus = 10;
	public const EventCategory ChangePanel = 11;
	public const EventCategory StyleTransition = 12;
	public const EventCategory Navigation = 13;
	public const EventCategory Command = 14;
	public const EventCategory Tooltip = 15;
	public const EventCategory IMGUI = 16;
	public const EventCategory Reserved = 31;
}

// Namespace: UnityEngine.UIElements
[Flags]
internal enum EventCategoryFlags // TypeDefIndex: 11664
{
	// Fields
	public int value__; // 0x0
	public const EventCategoryFlags None = 0;
	public const EventCategoryFlags All = -1;
	public const EventCategoryFlags TriggeredByOS = 81974;
	public const EventCategoryFlags TargetOnly = 2768;
}

// Namespace: UnityEngine.UIElements
public enum EventInterestOptions // TypeDefIndex: 11665
{
	// Fields
	public int value__; // 0x0
	public const EventInterestOptions Inherit = 0;
	public const EventInterestOptions AllEventTypes = -1;
}

// Namespace: UnityEngine.UIElements
[Usage(64, AllowMultiple = True)]
public class EventInterestAttribute : Attribute // TypeDefIndex: 11666
{
	// Fields
	internal Type[] eventTypes; // 0x10
	internal EventCategoryFlags categoryFlags; // 0x18

	// Methods

	// RVA: 0x259C9C0 Offset: 0x259BBC0 VA: 0x18259C9C0
	public void .ctor(Type[] eventTypes) { }

	// RVA: 0x259C9F0 Offset: 0x259BBF0 VA: 0x18259C9F0
	public void .ctor(EventInterestOptions interests) { }
}

// Namespace: UnityEngine.UIElements
[Usage(4)]
internal class EventCategoryAttribute : Attribute // TypeDefIndex: 11667
{
	// Fields
	internal EventCategory category; // 0x10

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	public void .ctor(EventCategory category) { }
}

// Namespace: UnityEngine.UIElements
public interface IExperimentalFeatures // TypeDefIndex: 11668
{
	// Properties
	public abstract ITransitionAnimations animation { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ITransitionAnimations get_animation();
}

// Namespace: UnityEngine.UIElements
public class VisualElementFocusChangeDirection : FocusChangeDirection // TypeDefIndex: 11669
{
	// Fields
	private static readonly VisualElementFocusChangeDirection s_Left; // 0x0
	private static readonly VisualElementFocusChangeDirection s_Right; // 0x8

	// Properties
	public static FocusChangeDirection left { get; }
	public static FocusChangeDirection right { get; }

	// Methods

	// RVA: 0x25B1170 Offset: 0x25B0370 VA: 0x1825B1170
	public static FocusChangeDirection get_left() { }

	// RVA: 0x25B11C0 Offset: 0x25B03C0 VA: 0x1825B11C0
	public static FocusChangeDirection get_right() { }

	// RVA: 0x25B1110 Offset: 0x25B0310 VA: 0x1825B1110
	protected void .ctor(int value) { }

	// RVA: 0x25B0F60 Offset: 0x25B0160 VA: 0x1825B0F60
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class VisualElementFocusChangeTarget.<>c // TypeDefIndex: 11670
{
	// Fields
	public static readonly VisualElementFocusChangeTarget.<>c <>9; // 0x0

	// Methods

	// RVA: 0x25A3110 Offset: 0x25A2310 VA: 0x1825A3110
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x25A2B90 Offset: 0x25A1D90 VA: 0x1825A2B90
	internal VisualElementFocusChangeTarget <.cctor>b__9_0() { }
}

// Namespace: UnityEngine.UIElements
internal class VisualElementFocusChangeTarget : FocusChangeDirection // TypeDefIndex: 11671
{
	// Fields
	private static readonly ObjectPool<VisualElementFocusChangeTarget> Pool; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Focusable <target>k__BackingField; // 0x18

	// Properties
	public Focusable target { get; set; }

	// Methods

	// RVA: 0x25B12F0 Offset: 0x25B04F0 VA: 0x1825B12F0
	public static VisualElementFocusChangeTarget GetPooled(Focusable target) { }

	// RVA: 0x25B1260 Offset: 0x25B0460 VA: 0x1825B1260 Slot: 5
	protected override void Dispose() { }

	// RVA: 0x25B1210 Offset: 0x25B0410 VA: 0x1825B1210 Slot: 6
	internal override void ApplyTo(FocusController focusController, Focusable f) { }

	// RVA: 0x25B1470 Offset: 0x25B0670 VA: 0x1825B1470
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Focusable get_target() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	private void set_target(Focusable value) { }

	// RVA: 0x25B1370 Offset: 0x25B0570 VA: 0x1825B1370
	private static void .cctor() { }
}

// Namespace: 
public enum VisualElementFocusRing.DefaultFocusOrder // TypeDefIndex: 11672
{
	// Fields
	public int value__; // 0x0
	public const VisualElementFocusRing.DefaultFocusOrder ChildOrder = 0;
	public const VisualElementFocusRing.DefaultFocusOrder PositionXY = 1;
	public const VisualElementFocusRing.DefaultFocusOrder PositionYX = 2;
}

// Namespace: 
private class VisualElementFocusRing.FocusRingRecord // TypeDefIndex: 11673
{
	// Fields
	public int m_AutoIndex; // 0x10
	public Focusable m_Focusable; // 0x18
	public bool m_IsSlot; // 0x20
	public List<VisualElementFocusRing.FocusRingRecord> m_ScopeNavigationOrder; // 0x28

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements
public class VisualElementFocusRing : IFocusRing // TypeDefIndex: 11674
{
	// Fields
	private readonly VisualElement root; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VisualElementFocusRing.DefaultFocusOrder <defaultFocusOrder>k__BackingField; // 0x18
	private List<VisualElementFocusRing.FocusRingRecord> m_FocusRing; // 0x20

	// Properties
	private FocusController focusController { get; }
	public VisualElementFocusRing.DefaultFocusOrder defaultFocusOrder { get; set; }

	// Methods

	// RVA: 0x25B2CE0 Offset: 0x25B1EE0 VA: 0x1825B2CE0
	public void .ctor(VisualElement root, VisualElementFocusRing.DefaultFocusOrder dfo = 0) { }

	// RVA: 0x1CFD7B0 Offset: 0x1CFC9B0 VA: 0x181CFD7B0
	private FocusController get_focusController() { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public VisualElementFocusRing.DefaultFocusOrder get_defaultFocusOrder() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_defaultFocusOrder(VisualElementFocusRing.DefaultFocusOrder value) { }

	// RVA: 0x25B1890 Offset: 0x25B0A90 VA: 0x1825B1890
	private int FocusRingAutoIndexSort(VisualElementFocusRing.FocusRingRecord a, VisualElementFocusRing.FocusRingRecord b) { }

	// RVA: 0x25B1C50 Offset: 0x25B0E50 VA: 0x1825B1C50
	private int FocusRingSort(VisualElementFocusRing.FocusRingRecord a, VisualElementFocusRing.FocusRingRecord b) { }

	// RVA: 0x25B17B0 Offset: 0x25B09B0 VA: 0x1825B17B0
	private void DoUpdate() { }

	// RVA: 0x25B1510 Offset: 0x25B0710 VA: 0x1825B1510
	private void BuildRingForScopeRecursive(VisualElement ve, ref int scopeIndex, List<VisualElementFocusRing.FocusRingRecord> scopeList) { }

	// RVA: 0x25B2A90 Offset: 0x25B1C90 VA: 0x1825B2A90
	private void SortAndFlattenScopeLists(List<VisualElementFocusRing.FocusRingRecord> rootScopeList) { }

	// RVA: 0x25B21A0 Offset: 0x25B13A0 VA: 0x1825B21A0
	private int GetFocusableInternalIndex(Focusable f) { }

	// RVA: 0x25B1D80 Offset: 0x25B0F80 VA: 0x1825B1D80 Slot: 4
	public FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) { }

	// RVA: 0x25B2300 Offset: 0x25B1500 VA: 0x1825B2300 Slot: 5
	public Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) { }

	// RVA: 0x25B2250 Offset: 0x25B1450 VA: 0x1825B2250
	internal static Focusable GetNextFocusableInTree(VisualElement currentFocusable) { }

	// RVA: 0x25B29A0 Offset: 0x25B1BA0 VA: 0x1825B29A0
	internal static Focusable GetPreviousFocusableInTree(VisualElement currentFocusable) { }
}

// Namespace: UnityEngine.UIElements
public interface IVisualElementScheduledItem // TypeDefIndex: 11675
{
	// Properties
	public abstract bool isActive { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_isActive();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Resume();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Pause();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void ExecuteLater(long delayMs);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IVisualElementScheduledItem StartingIn(long delayMs);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IVisualElementScheduledItem Every(long intervalMs);
}

// Namespace: UnityEngine.UIElements
public interface IVisualElementScheduler // TypeDefIndex: 11676
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IVisualElementScheduledItem Execute(Action<TimerState> timerUpdateEvent);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IVisualElementScheduledItem Execute(Action updateEvent);
}

// Namespace: UnityEngine.UIElements
internal interface IVisualElementPanelActivatable // TypeDefIndex: 11677
{
	// Properties
	public abstract VisualElement element { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract VisualElement get_element();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool CanBeActivated();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnPanelActivate();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnPanelDeactivate();
}

// Namespace: UnityEngine.UIElements
internal class VisualElementPanelActivator // TypeDefIndex: 11678
{
	// Fields
	private IVisualElementPanelActivatable m_Activatable; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <isActive>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <isDetaching>k__BackingField; // 0x19
	private EventCallback<AttachToPanelEvent> m_OnAttachToPanelCallback; // 0x20
	private EventCallback<DetachFromPanelEvent> m_OnDetachFromPanelCallback; // 0x28

	// Properties
	public bool isActive { get; set; }
	public bool isDetaching { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_isActive() { }

	[CompilerGenerated]
	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	private void set_isActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x630F40 Offset: 0x630140 VA: 0x180630F40
	public bool get_isDetaching() { }

	[CompilerGenerated]
	// RVA: 0x630F50 Offset: 0x630150 VA: 0x180630F50
	private void set_isDetaching(bool value) { }

	// RVA: 0x25CBB50 Offset: 0x25CAD50 VA: 0x1825CBB50
	public void .ctor(IVisualElementPanelActivatable activatable) { }

	// RVA: 0x25CB9F0 Offset: 0x25CABF0 VA: 0x1825CB9F0
	public void SetActive(bool action) { }

	// RVA: 0x25CB910 Offset: 0x25CAB10 VA: 0x1825CB910
	public void SendActivation() { }

	// RVA: 0x25CB980 Offset: 0x25CAB80 VA: 0x1825CB980
	public void SendDeactivation() { }

	// RVA: 0x25CB8A0 Offset: 0x25CAAA0 VA: 0x1825CB8A0
	private void OnEnter(AttachToPanelEvent evt) { }

	// RVA: 0x25CB8B0 Offset: 0x25CAAB0 VA: 0x1825CB8B0
	private void OnLeave(DetachFromPanelEvent evt) { }
}

// Namespace: UnityEngine.UIElements
[DefaultMember("Item")]
public struct VisualElementStyleSheetSet : IEquatable<VisualElementStyleSheetSet> // TypeDefIndex: 11679
{
	// Fields
	private readonly VisualElement m_Element; // 0x0

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void .ctor(VisualElement element) { }

	// RVA: 0x25CBC10 Offset: 0x25CAE10 VA: 0x1825CBC10
	public void Add(StyleSheet styleSheet) { }

	// RVA: 0x25CBEC0 Offset: 0x25CB0C0 VA: 0x1825CBEC0
	public bool Remove(StyleSheet styleSheet) { }

	// RVA: 0x25CBE80 Offset: 0x25CB080 VA: 0x1825CBE80 Slot: 4
	public bool Equals(VisualElementStyleSheetSet other) { }

	// RVA: 0x25CBDF0 Offset: 0x25CAFF0 VA: 0x1825CBDF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x25CBE90 Offset: 0x25CB090 VA: 0x1825CBE90 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class VisualElementUtils.<>c // TypeDefIndex: 11680
{
	// Fields
	public static readonly VisualElementUtils.<>c <>9; // 0x0
	public static Predicate<VisualElement> <>9__5_0; // 0x8

	// Methods

	// RVA: 0x25C2D30 Offset: 0x25C1F30 VA: 0x1825C2D30
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x25C2BA0 Offset: 0x25C1DA0 VA: 0x1825C2BA0
	internal bool <AssignInspectorStyleIfNecessary>b__5_0(VisualElement i) { }
}

// Namespace: UnityEngine.UIElements
[Extension]
internal static class VisualElementUtils // TypeDefIndex: 11681
{
	// Fields
	private static readonly HashSet<string> s_usedNames; // 0x0
	private static readonly Type s_FoldoutType; // 0x8
	private static readonly string s_InspectorElementUssClassName; // 0x10

	// Methods

	// RVA: 0x25CC210 Offset: 0x25CB410 VA: 0x1825CC210
	public static string GetUniqueName(string nameBase) { }

	[Extension]
	// RVA: 0x25CC120 Offset: 0x25CB320 VA: 0x1825CC120
	internal static int GetFoldoutDepth(VisualElement element) { }

	[Extension]
	// RVA: 0x25CC010 Offset: 0x25CB210 VA: 0x1825CC010
	internal static void AssignInspectorStyleIfNecessary(VisualElement element, string classNameToEnable) { }

	// RVA: 0x25CC320 Offset: 0x25CB520 VA: 0x1825CC320
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements
internal class VisualElementAnimationSystem : BaseVisualTreeUpdater // TypeDefIndex: 11682
{
	// Fields
	private HashSet<IValueAnimationUpdate> m_Animations; // 0x20
	private List<IValueAnimationUpdate> m_IterationList; // 0x28
	private bool m_HasNewAnimations; // 0x30
	private bool m_IterationListDirty; // 0x31
	private static readonly string s_Description; // 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; // 0x8
	private static readonly string s_StylePropertyAnimationDescription; // 0x10
	private static readonly ProfilerMarker s_StylePropertyAnimationProfilerMarker; // 0x18
	private long lastUpdate; // 0x38

	// Properties
	public override ProfilerMarker profilerMarker { get; }
	private static ProfilerMarker stylePropertyAnimationProfilerMarker { get; }

	// Methods

	// RVA: 0x25CB800 Offset: 0x25CAA00 VA: 0x1825CB800 Slot: 10
	public override ProfilerMarker get_profilerMarker() { }

	// RVA: 0x25CB850 Offset: 0x25CAA50 VA: 0x1825CB850
	private static ProfilerMarker get_stylePropertyAnimationProfilerMarker() { }

	// RVA: 0x25CB140 Offset: 0x25CA340 VA: 0x1825CB140
	public void UnregisterAnimation(IValueAnimationUpdate anim) { }

	// RVA: 0x25CB1A0 Offset: 0x25CA3A0 VA: 0x1825CB1A0
	public void UnregisterAnimations(List<IValueAnimationUpdate> anims) { }

	// RVA: 0x25CAFA0 Offset: 0x25CA1A0 VA: 0x1825CAFA0
	public void RegisterAnimation(IValueAnimationUpdate anim) { }

	// RVA: 0x25CB000 Offset: 0x25CA200 VA: 0x1825CB000
	public void RegisterAnimations(List<IValueAnimationUpdate> anims) { }

	// RVA: 0x25CB2E0 Offset: 0x25CA4E0 VA: 0x1825CB2E0 Slot: 12
	public override void Update() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 13
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x25CB750 Offset: 0x25CA950 VA: 0x1825CB750
	public void .ctor() { }

	// RVA: 0x25CB670 Offset: 0x25CA870 VA: 0x1825CB670
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements
internal class VisualTreeHierarchyFlagsUpdater : BaseVisualTreeUpdater // TypeDefIndex: 11683
{
	// Fields
	private uint m_Version; // 0x20
	private uint m_LastVersion; // 0x24
	private static readonly string s_Description; // 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; // 0x8

	// Properties
	public override ProfilerMarker profilerMarker { get; }

	// Methods

	// RVA: 0x25CC7D0 Offset: 0x25CB9D0 VA: 0x1825CC7D0 Slot: 10
	public override ProfilerMarker get_profilerMarker() { }

	// RVA: 0x25CC570 Offset: 0x25CB770 VA: 0x1825CC570 Slot: 13
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x25CC480 Offset: 0x25CB680 VA: 0x1825CC480
	private static void DirtyHierarchy(VisualElement ve, VisualElementFlags mustDirtyFlags) { }

	// RVA: 0x25CC410 Offset: 0x25CB610 VA: 0x1825CC410
	private static void DirtyBoundingBoxHierarchy(VisualElement ve) { }

	// RVA: 0x25CC6C0 Offset: 0x25CB8C0 VA: 0x1825CC6C0 Slot: 12
	public override void Update() { }

	// RVA: 0x25CC7C0 Offset: 0x25CB9C0 VA: 0x1825CC7C0
	public void .ctor() { }

	// RVA: 0x25CC730 Offset: 0x25CB930 VA: 0x1825CC730
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements
internal enum HierarchyChangeType // TypeDefIndex: 11684
{
	// Fields
	public int value__; // 0x0
	public const HierarchyChangeType Add = 0;
	public const HierarchyChangeType Remove = 1;
	public const HierarchyChangeType Move = 2;
}

// Namespace: 
private enum BaseVisualTreeHierarchyTrackerUpdater.State // TypeDefIndex: 11685
{
	// Fields
	public int value__; // 0x0
	public const BaseVisualTreeHierarchyTrackerUpdater.State Waiting = 0;
	public const BaseVisualTreeHierarchyTrackerUpdater.State TrackingAddOrMove = 1;
	public const BaseVisualTreeHierarchyTrackerUpdater.State TrackingRemove = 2;
}

// Namespace: UnityEngine.UIElements
internal abstract class BaseVisualTreeHierarchyTrackerUpdater : BaseVisualTreeUpdater // TypeDefIndex: 11686
{
	// Fields
	private BaseVisualTreeHierarchyTrackerUpdater.State m_State; // 0x20
	private VisualElement m_CurrentChangeElement; // 0x28
	private VisualElement m_CurrentChangeParent; // 0x30

	// Methods

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnHierarchyChange(VisualElement ve, HierarchyChangeType type);

	// RVA: 0x25B7640 Offset: 0x25B6840 VA: 0x1825B7640 Slot: 13
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x25B7A10 Offset: 0x25B6C10 VA: 0x1825B7A10 Slot: 12
	public override void Update() { }

	// RVA: 0x25B7910 Offset: 0x25B6B10 VA: 0x1825B7910
	private void ProcessNewChange(VisualElement ve) { }

	// RVA: 0x25B7800 Offset: 0x25B6A00 VA: 0x1825B7800
	private void ProcessAddOrMove(VisualElement ve) { }

	// RVA: 0x25B79A0 Offset: 0x25B6BA0 VA: 0x1825B79A0
	private void ProcessRemove(VisualElement ve) { }

	// RVA: 0x25B7AC0 Offset: 0x25B6CC0 VA: 0x1825B7AC0
	protected void .ctor() { }
}

// Namespace: UnityEngine.UIElements
internal static class StyleCache // TypeDefIndex: 11687
{
	// Fields
	private static Dictionary<long, ComputedStyle> s_ComputedStyleCache; // 0x0
	private static Dictionary<int, StyleVariableContext> s_StyleVariableContextCache; // 0x8
	private static Dictionary<int, ComputedTransitionProperty[]> s_ComputedTransitionsCache; // 0x10

	// Methods

	// RVA: 0x25C2740 Offset: 0x25C1940 VA: 0x1825C2740
	public static bool TryGetValue(long hash, out ComputedStyle data) { }

	// RVA: 0x25C2430 Offset: 0x25C1630 VA: 0x1825C2430
	public static void SetValue(long hash, ref ComputedStyle data) { }

	// RVA: 0x25C2620 Offset: 0x25C1820 VA: 0x1825C2620
	public static bool TryGetValue(int hash, out StyleVariableContext data) { }

	// RVA: 0x25C2500 Offset: 0x25C1700 VA: 0x1825C2500
	public static void SetValue(int hash, StyleVariableContext data) { }

	// RVA: 0x25C26B0 Offset: 0x25C18B0 VA: 0x1825C26B0
	public static bool TryGetValue(int hash, out ComputedTransitionProperty[] data) { }

	// RVA: 0x25C2590 Offset: 0x25C1790 VA: 0x1825C2590
	public static void SetValue(int hash, ComputedTransitionProperty[] data) { }

	// RVA: 0x25C27D0 Offset: 0x25C19D0 VA: 0x1825C27D0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements
internal class VisualTreeStyleUpdater : BaseVisualTreeUpdater // TypeDefIndex: 11688
{
	// Fields
	private HashSet<VisualElement> m_ApplyStyleUpdateList; // 0x20
	private HashSet<VisualElement> m_TransitionPropertyUpdateList; // 0x28
	private bool m_IsApplyingStyles; // 0x30
	private uint m_Version; // 0x34
	private uint m_LastVersion; // 0x38
	private VisualTreeStyleUpdaterTraversal m_StyleContextHierarchyTraversal; // 0x40
	private static readonly string s_Description; // 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposed>k__BackingField; // 0x48

	// Properties
	public override ProfilerMarker profilerMarker { get; }
	protected bool disposed { get; set; }

	// Methods

	// RVA: 0x25CEFD0 Offset: 0x25CE1D0 VA: 0x1825CEFD0 Slot: 10
	public override ProfilerMarker get_profilerMarker() { }

	// RVA: 0x25CE9E0 Offset: 0x25CDBE0 VA: 0x1825CE9E0 Slot: 13
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x25CEAA0 Offset: 0x25CDCA0 VA: 0x1825CEAA0 Slot: 12
	public override void Update() { }

	[CompilerGenerated]
	// RVA: 0x445A70 Offset: 0x444C70 VA: 0x180445A70
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x445A80 Offset: 0x444C80 VA: 0x180445A80
	private void set_disposed(bool value) { }

	// RVA: 0x25CE9A0 Offset: 0x25CDBA0 VA: 0x1825CE9A0 Slot: 11
	protected override void Dispose(bool disposing) { }

	// RVA: 0x25CE8A0 Offset: 0x25CDAA0 VA: 0x1825CE8A0
	private void ApplyStyles() { }

	// RVA: 0x25CEF10 Offset: 0x25CE110 VA: 0x1825CEF10
	public void .ctor() { }

	// RVA: 0x25CEE80 Offset: 0x25CE080 VA: 0x1825CEE80
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements
internal class StyleMatchingContext // TypeDefIndex: 11689
{
	// Fields
	private List<StyleSheet> m_StyleSheetStack; // 0x10
	public StyleVariableContext variableContext; // 0x18
	public VisualElement currentElement; // 0x20
	public Action<VisualElement, MatchResultInfo> processResult; // 0x28
	public AncestorFilter ancestorFilter; // 0x30

	// Properties
	public int styleSheetCount { get; }

	// Methods

	// RVA: 0x25C2B60 Offset: 0x25C1D60 VA: 0x1825C2B60
	public int get_styleSheetCount() { }

	// RVA: 0x25C2A70 Offset: 0x25C1C70 VA: 0x1825C2A70
	public void .ctor(Action<VisualElement, MatchResultInfo> processResult) { }

	// RVA: 0x25C28D0 Offset: 0x25C1AD0 VA: 0x1825C28D0
	public void AddStyleSheet(StyleSheet sheet) { }

	// RVA: 0x25C2A00 Offset: 0x25C1C00 VA: 0x1825C2A00
	public void RemoveStyleSheetRange(int index, int count) { }

	// RVA: 0x25C29A0 Offset: 0x25C1BA0 VA: 0x1825C29A0
	public StyleSheet GetStyleSheetAt(int index) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class VisualTreeStyleUpdaterTraversal.<>c // TypeDefIndex: 11690
{
	// Fields
	public static readonly VisualTreeStyleUpdaterTraversal.<>c <>9; // 0x0
	public static Comparison<SelectorMatchRecord> <>9__24_0; // 0x8

	// Methods

	// RVA: 0x25C2CD0 Offset: 0x25C1ED0 VA: 0x1825C2CD0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x25C2C10 Offset: 0x25C1E10 VA: 0x1825C2C10
	internal int <ProcessMatchedRules>b__24_0(SelectorMatchRecord a, SelectorMatchRecord b) { }
}

// Namespace: UnityEngine.UIElements
internal class VisualTreeStyleUpdaterTraversal : HierarchyTraversal // TypeDefIndex: 11691
{
	// Fields
	private StyleVariableContext m_ProcessVarContext; // 0x10
	private HashSet<VisualElement> m_UpdateList; // 0x18
	private HashSet<VisualElement> m_ParentList; // 0x20
	private List<SelectorMatchRecord> m_TempMatchResults; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private float <currentPixelsPerPoint>k__BackingField; // 0x30
	private StyleMatchingContext m_StyleMatchingContext; // 0x38
	private StylePropertyReader m_StylePropertyReader; // 0x40
	private readonly List<StylePropertyId> m_AnimatedProperties; // 0x48

	// Properties
	private float currentPixelsPerPoint { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x527470 Offset: 0x526670 VA: 0x180527470
	private float get_currentPixelsPerPoint() { }

	[CompilerGenerated]
	// RVA: 0x499010 Offset: 0x498210 VA: 0x180499010
	private void set_currentPixelsPerPoint(float value) { }

	// RVA: 0x499010 Offset: 0x498210 VA: 0x180499010
	public void PrepareTraversal(float pixelsPerPoint) { }

	// RVA: 0x25CC820 Offset: 0x25CBA20 VA: 0x1825CC820
	public void AddChangedElement(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x25CCB10 Offset: 0x25CBD10 VA: 0x1825CCB10
	public void Clear() { }

	// RVA: 0x25CDB90 Offset: 0x25CCD90 VA: 0x1825CDB90
	private void PropagateToChildren(VisualElement ve) { }

	// RVA: 0x25CDC70 Offset: 0x25CCE70 VA: 0x1825CDC70
	private void PropagateToParents(VisualElement ve) { }

	// RVA: 0x25CCDF0 Offset: 0x25CBFF0 VA: 0x1825CCDF0
	private static void OnProcessMatchResult(VisualElement current, MatchResultInfo info) { }

	// RVA: 0x25CDDA0 Offset: 0x25CCFA0 VA: 0x1825CDDA0 Slot: 5
	public override void TraverseRecursive(VisualElement element, int depth) { }

	// RVA: 0x25CDA60 Offset: 0x25CCC60 VA: 0x1825CDA60
	private void ProcessTransitions(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle) { }

	// RVA: 0x25CCBB0 Offset: 0x25CBDB0 VA: 0x1825CCBB0
	private void ForceUpdateTransitions(VisualElement element) { }

	// RVA: 0x25CC930 Offset: 0x25CBB30 VA: 0x1825CC930
	internal void CancelAnimationsWithNoTransitionProperty(VisualElement element, ref ComputedStyle newStyle) { }

	// RVA: 0x25CDD20 Offset: 0x25CCF20 VA: 0x1825CDD20
	protected bool ShouldSkipElement(VisualElement element) { }

	// RVA: 0x25CCE30 Offset: 0x25CC030 VA: 0x1825CCE30
	private ComputedStyle ProcessMatchedRules(VisualElement element, List<SelectorMatchRecord> matchingSelectors) { }

	// RVA: 0x25CD940 Offset: 0x25CCB40 VA: 0x1825CD940
	private void ProcessMatchedVariables(StyleSheet sheet, StyleRule rule) { }

	// RVA: 0x25CE610 Offset: 0x25CD810 VA: 0x1825CE610
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements
internal enum VisualTreeUpdatePhase // TypeDefIndex: 11692
{
	// Fields
	public int value__; // 0x0
	public const VisualTreeUpdatePhase ViewData = 0;
	public const VisualTreeUpdatePhase Bindings = 1;
	public const VisualTreeUpdatePhase Animation = 2;
	public const VisualTreeUpdatePhase Styles = 3;
	public const VisualTreeUpdatePhase Layout = 4;
	public const VisualTreeUpdatePhase TransformClip = 5;
	public const VisualTreeUpdatePhase Repaint = 6;
	public const VisualTreeUpdatePhase Count = 7;
}

// Namespace: 
[DefaultMember("Item")]
private class VisualTreeUpdater.UpdaterArray // TypeDefIndex: 11693
{
	// Fields
	private IVisualTreeUpdater[] m_VisualTreeUpdaters; // 0x10

	// Properties
	public IVisualTreeUpdater Item { get; set; }
	public IVisualTreeUpdater Item { get; }

	// Methods

	// RVA: 0x25C97F0 Offset: 0x25C89F0 VA: 0x1825C97F0
	public void .ctor() { }

	// RVA: 0x25C9840 Offset: 0x25C8A40 VA: 0x1825C9840
	public void set_Item(VisualTreeUpdatePhase phase, IVisualTreeUpdater value) { }

	// RVA: 0x74A700 Offset: 0x749900 VA: 0x18074A700
	public IVisualTreeUpdater get_Item(VisualTreeUpdatePhase phase) { }

	// RVA: 0x74A700 Offset: 0x749900 VA: 0x18074A700
	public IVisualTreeUpdater get_Item(int index) { }
}

// Namespace: UnityEngine.UIElements
internal sealed class VisualTreeUpdater : IDisposable // TypeDefIndex: 11694
{
	// Fields
	private BaseVisualElementPanel m_Panel; // 0x10
	private VisualTreeUpdater.UpdaterArray m_UpdaterArray; // 0x18

	// Methods

	// RVA: 0x25CF570 Offset: 0x25CE770 VA: 0x1825CF570
	public void .ctor(BaseVisualElementPanel panel) { }

	// RVA: 0x25CF020 Offset: 0x25CE220 VA: 0x1825CF020 Slot: 4
	public void Dispose() { }

	// RVA: 0x25CF3D0 Offset: 0x25CE5D0 VA: 0x1825CF3D0
	public void UpdateVisualTreePhase(VisualTreeUpdatePhase phase) { }

	// RVA: 0x25CF190 Offset: 0x25CE390 VA: 0x1825CF190
	public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: -1 Offset: -1
	public void SetUpdater<T>(VisualTreeUpdatePhase phase) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA4220 Offset: 0xAA3420 VA: 0x180AA4220
	|-VisualTreeUpdater.SetUpdater<object>
	|
	|-RVA: 0xAA3FA0 Offset: 0xAA31A0 VA: 0x180AA3FA0
	|-VisualTreeUpdater.SetUpdater<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x25CF150 Offset: 0x25CE350 VA: 0x1825CF150
	public IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	// RVA: 0x25CF2D0 Offset: 0x25CE4D0 VA: 0x1825CF2D0
	private void SetDefaultUpdaters() { }
}

// Namespace: UnityEngine.UIElements
internal interface IVisualTreeUpdater : IDisposable // TypeDefIndex: 11695
{
	// Properties
	public abstract BaseVisualElementPanel panel { set; }
	public abstract ProfilerMarker profilerMarker { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void set_panel(BaseVisualElementPanel value);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ProfilerMarker get_profilerMarker();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Update();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType);
}

// Namespace: UnityEngine.UIElements
internal abstract class BaseVisualTreeUpdater : IVisualTreeUpdater, IDisposable // TypeDefIndex: 11696
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<BaseVisualElementPanel> panelChanged; // 0x10
	private BaseVisualElementPanel m_Panel; // 0x18

	// Properties
	public BaseVisualElementPanel panel { get; set; }
	public VisualElement visualTree { get; }
	public abstract ProfilerMarker profilerMarker { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x25B7B40 Offset: 0x25B6D40 VA: 0x1825B7B40
	public void add_panelChanged(Action<BaseVisualElementPanel> value) { }

	[CompilerGenerated]
	// RVA: 0x25B7BF0 Offset: 0x25B6DF0 VA: 0x1825B7BF0
	public void remove_panelChanged(Action<BaseVisualElementPanel> value) { }

	// RVA: 0x248C210 Offset: 0x248B410 VA: 0x18248C210 Slot: 9
	public BaseVisualElementPanel get_panel() { }

	// RVA: 0x25B7CA0 Offset: 0x25B6EA0 VA: 0x1825B7CA0 Slot: 4
	public void set_panel(BaseVisualElementPanel value) { }

	// RVA: 0x16C6510 Offset: 0x16C5710 VA: 0x1816C6510
	public VisualElement get_visualTree() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract ProfilerMarker get_profilerMarker();

	// RVA: 0x25B7AD0 Offset: 0x25B6CD0 VA: 0x1825B7AD0 Slot: 8
	public void Dispose() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 11
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Update();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: UnityEngine.UIElements
internal class VisualTreeViewDataUpdater : BaseVisualTreeUpdater // TypeDefIndex: 11697
{
	// Fields
	private HashSet<VisualElement> m_UpdateList; // 0x20
	private HashSet<VisualElement> m_ParentList; // 0x28
	private uint m_Version; // 0x30
	private uint m_LastVersion; // 0x34
	private static readonly string s_Description; // 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; // 0x8

	// Properties
	public override ProfilerMarker profilerMarker { get; }

	// Methods

	// RVA: 0x25CFC90 Offset: 0x25CEE90 VA: 0x1825CFC90 Slot: 10
	public override ProfilerMarker get_profilerMarker() { }

	// RVA: 0x25CF6F0 Offset: 0x25CE8F0 VA: 0x1825CF6F0 Slot: 13
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x25CF8A0 Offset: 0x25CEAA0 VA: 0x1825CF8A0 Slot: 12
	public override void Update() { }

	// RVA: 0x25CFA00 Offset: 0x25CEC00 VA: 0x1825CFA00
	private void ValidateViewDataOnSubTree(VisualElement ve, bool enablePersistence) { }

	// RVA: 0x25CF7F0 Offset: 0x25CE9F0 VA: 0x1825CF7F0
	private void PropagateToParents(VisualElement ve) { }

	// RVA: 0x25CFBF0 Offset: 0x25CEDF0 VA: 0x1825CFBF0
	public void .ctor() { }

	// RVA: 0x25CFB60 Offset: 0x25CED60 VA: 0x1825CFB60
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal struct GfxUpdateBufferRange // TypeDefIndex: 11698
{
	// Fields
	public uint offsetFromWriteStart; // 0x0
	public uint size; // 0x4
	public UIntPtr source; // 0x8
}

// Namespace: UnityEngine.UIElements.UIR
internal struct DrawBufferRange // TypeDefIndex: 11699
{
	// Fields
	public int firstIndex; // 0x0
	public int indexCount; // 0x4
	public int minIndexVal; // 0x8
	public int vertsReferenced; // 0xC
}

// Namespace: 
internal enum Utility.GPUBufferType // TypeDefIndex: 11700
{
	// Fields
	public int value__; // 0x0
	public const Utility.GPUBufferType Vertex = 0;
	public const Utility.GPUBufferType Index = 1;
}

// Namespace: 
public class Utility.GPUBuffer<T> : IDisposable // TypeDefIndex: 11701
{
	// Fields
	private IntPtr buffer; // 0x0
	private int elemCount; // 0x0
	private int elemStride; // 0x0

	// Properties
	public int ElementStride { get; }
	internal IntPtr BufferPointer { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int elementCount, Utility.GPUBufferType type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12085D0 Offset: 0x12077D0 VA: 0x1812085D0
	|-Utility.GPUBuffer<ushort>..ctor
	|
	|-RVA: 0x1208540 Offset: 0x1207740 VA: 0x181208540
	|-Utility.GPUBuffer<Vertex>..ctor
	|
	|-RVA: 0x1208490 Offset: 0x1207690 VA: 0x181208490
	|-Utility.GPUBuffer<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12081A0 Offset: 0x12073A0 VA: 0x1812081A0
	|-Utility.GPUBuffer<ushort>.Dispose
	|
	|-RVA: 0x1208150 Offset: 0x1207350 VA: 0x181208150
	|-Utility.GPUBuffer<Vertex>.Dispose
	|
	|-RVA: 0x1208100 Offset: 0x1207300 VA: 0x181208100
	|-Utility.GPUBuffer<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public void UpdateRanges(NativeSlice<GfxUpdateBufferRange> ranges, int rangesMin, int rangesMax) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12083B0 Offset: 0x12075B0 VA: 0x1812083B0
	|-Utility.GPUBuffer<ushort>.UpdateRanges
	|
	|-RVA: 0x12081F0 Offset: 0x12073F0 VA: 0x1812081F0
	|-Utility.GPUBuffer<Vertex>.UpdateRanges
	|
	|-RVA: 0x12082D0 Offset: 0x12074D0 VA: 0x1812082D0
	|-Utility.GPUBuffer<__Il2CppFullySharedGenericStructType>.UpdateRanges
	*/

	// RVA: -1 Offset: -1
	public int get_ElementStride() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1208670 Offset: 0x1207870 VA: 0x181208670
	|-Utility.GPUBuffer<ushort>.get_ElementStride
	|-Utility.GPUBuffer<Vertex>.get_ElementStride
	|-Utility.GPUBuffer<__Il2CppFullySharedGenericStructType>.get_ElementStride
	*/

	// RVA: -1 Offset: -1
	internal IntPtr get_BufferPointer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1208660 Offset: 0x1207860 VA: 0x181208660
	|-Utility.GPUBuffer<ushort>.get_BufferPointer
	|-Utility.GPUBuffer<Vertex>.get_BufferPointer
	|-Utility.GPUBuffer<__Il2CppFullySharedGenericStructType>.get_BufferPointer
	*/
}

// Namespace: UnityEngine.UIElements.UIR
[NativeHeader("ModuleOverrides/com.unity.ui/Core/Native/Renderer/UIRendererUtility.h")]
[VisibleToOtherModules(new[] { "Unity.UIElements" })]
internal class Utility // TypeDefIndex: 11702
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<bool> GraphicsResourcesRecreate; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action EngineUpdate; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action FlushPendingResources; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<Camera> RegisterIntermediateRenderers; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<IntPtr> RenderNodeAdd; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<IntPtr> RenderNodeExecute; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<IntPtr> RenderNodeCleanup; // 0x30
	private static ProfilerMarker s_MarkerRaiseEngineUpdate; // 0x38

	// Methods

	// RVA: -1 Offset: -1
	public static void SetVectorArray<T>(MaterialPropertyBlock props, int name, NativeSlice<T> vector4s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA1B10 Offset: 0xAA0D10 VA: 0x180AA1B10
	|-Utility.SetVectorArray<Transform3x4>
	|-Utility.SetVectorArray<Vector4>
	|
	|-RVA: 0xAA1A20 Offset: 0xAA0C20 VA: 0x180AA1A20
	|-Utility.SetVectorArray<__Il2CppFullySharedGenericStructType>
	*/

	[CompilerGenerated]
	// RVA: 0x25CA740 Offset: 0x25C9940 VA: 0x1825CA740
	public static void add_GraphicsResourcesRecreate(Action<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x25CAC70 Offset: 0x25C9E70 VA: 0x1825CAC70
	public static void remove_GraphicsResourcesRecreate(Action<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x25CA540 Offset: 0x25C9740 VA: 0x1825CA540
	public static void add_EngineUpdate(Action value) { }

	[CompilerGenerated]
	// RVA: 0x25CAA70 Offset: 0x25C9C70 VA: 0x1825CAA70
	public static void remove_EngineUpdate(Action value) { }

	[CompilerGenerated]
	// RVA: 0x25CA640 Offset: 0x25C9840 VA: 0x1825CA640
	public static void add_FlushPendingResources(Action value) { }

	[CompilerGenerated]
	// RVA: 0x25CAB70 Offset: 0x25C9D70 VA: 0x1825CAB70
	public static void remove_FlushPendingResources(Action value) { }

	[CompilerGenerated]
	// RVA: 0x25CA850 Offset: 0x25C9A50 VA: 0x1825CA850
	public static void add_RegisterIntermediateRenderers(Action<Camera> value) { }

	[CompilerGenerated]
	// RVA: 0x25CAD80 Offset: 0x25C9F80 VA: 0x1825CAD80
	public static void remove_RegisterIntermediateRenderers(Action<Camera> value) { }

	[CompilerGenerated]
	// RVA: 0x25CA960 Offset: 0x25C9B60 VA: 0x1825CA960
	public static void add_RenderNodeExecute(Action<IntPtr> value) { }

	[CompilerGenerated]
	// RVA: 0x25CAE90 Offset: 0x25CA090 VA: 0x1825CAE90
	public static void remove_RenderNodeExecute(Action<IntPtr> value) { }

	[RequiredByNativeCode]
	// RVA: 0x25C9E80 Offset: 0x25C9080 VA: 0x1825C9E80
	internal static void RaiseGraphicsResourcesRecreate(bool recreate) { }

	[RequiredByNativeCode]
	// RVA: 0x25C9D80 Offset: 0x25C8F80 VA: 0x1825C9D80
	internal static void RaiseEngineUpdate() { }

	[RequiredByNativeCode]
	// RVA: 0x25C9E10 Offset: 0x25C9010 VA: 0x1825C9E10
	internal static void RaiseFlushPendingResources() { }

	[RequiredByNativeCode]
	// RVA: 0x25C9EF0 Offset: 0x25C90F0 VA: 0x1825C9EF0
	internal static void RaiseRegisterIntermediateRenderers(Camera camera) { }

	[RequiredByNativeCode]
	// RVA: 0x25C9F70 Offset: 0x25C9170 VA: 0x1825C9F70
	internal static void RaiseRenderNodeAdd(IntPtr userData) { }

	[RequiredByNativeCode]
	// RVA: 0x25CA070 Offset: 0x25C9270 VA: 0x1825CA070
	internal static void RaiseRenderNodeExecute(IntPtr userData) { }

	[RequiredByNativeCode]
	// RVA: 0x25C9FF0 Offset: 0x25C91F0 VA: 0x1825C9FF0
	internal static void RaiseRenderNodeCleanup(IntPtr userData) { }

	[ThreadSafe]
	// RVA: 0x25C98B0 Offset: 0x25C8AB0 VA: 0x1825C98B0
	private static IntPtr AllocateBuffer(int elementCount, int elementStride, bool vertexBuffer) { }

	[ThreadSafe]
	// RVA: 0x25C9A90 Offset: 0x25C8C90 VA: 0x1825C9A90
	private static void FreeBuffer(IntPtr buffer) { }

	[ThreadSafe]
	// RVA: 0x25CA430 Offset: 0x25C9630 VA: 0x1825CA430
	private static void UpdateBufferRanges(IntPtr buffer, IntPtr ranges, int rangeCount, int writeRangeStart, int writeRangeEnd) { }

	[ThreadSafe]
	// RVA: 0x25CA3A0 Offset: 0x25C95A0 VA: 0x1825CA3A0
	private static void SetVectorArray(MaterialPropertyBlock props, int name, IntPtr vector4s, int count) { }

	[ThreadSafe]
	// RVA: 0x25C9C40 Offset: 0x25C8E40 VA: 0x1825C9C40
	public static IntPtr GetVertexDeclaration(VertexAttributeDescriptor[] vertexAttributes) { }

	// RVA: 0x25CA170 Offset: 0x25C9370 VA: 0x1825CA170
	public static void RegisterIntermediateRenderer(Camera camera, Material material, Matrix4x4 transform, Bounds aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, ulong sceneCullingMask, int rendererCallbackFlags, IntPtr userData, int userDataSize) { }

	[ThreadSafe]
	// RVA: 0x25C9A20 Offset: 0x25C8C20 VA: 0x1825C9A20
	public static void DrawRanges(IntPtr ib, IntPtr* vertexStreams, int streamCount, IntPtr ranges, int rangeCount, IntPtr vertexDecl) { }

	[ThreadSafe]
	// RVA: 0x25CA270 Offset: 0x25C9470 VA: 0x1825CA270
	public static void SetPropertyBlock(MaterialPropertyBlock props) { }

	[ThreadSafe]
	// RVA: 0x25CA2F0 Offset: 0x25C94F0 VA: 0x1825CA2F0
	public static void SetScissorRect(RectInt scissorRect) { }

	[ThreadSafe]
	// RVA: 0x25C99F0 Offset: 0x25C8BF0 VA: 0x1825C99F0
	public static void DisableScissor() { }

	[ThreadSafe]
	// RVA: 0x25C9980 Offset: 0x25C8B80 VA: 0x1825C9980
	public static IntPtr CreateStencilState(StencilState stencilState) { }

	[ThreadSafe]
	// RVA: 0x25CA360 Offset: 0x25C9560 VA: 0x1825CA360
	public static void SetStencilState(IntPtr stencilState, int stencilRef) { }

	[ThreadSafe]
	// RVA: 0x25C9C80 Offset: 0x25C8E80 VA: 0x1825C9C80
	public static bool HasMappedBufferRange() { }

	[ThreadSafe]
	// RVA: 0x25C9CB0 Offset: 0x25C8EB0 VA: 0x1825C9CB0
	public static uint InsertCPUFence() { }

	[ThreadSafe]
	// RVA: 0x25C9900 Offset: 0x25C8B00 VA: 0x1825C9900
	public static bool CPUFencePassed(uint fence) { }

	[ThreadSafe]
	// RVA: 0x25CA4A0 Offset: 0x25C96A0 VA: 0x1825CA4A0
	public static void WaitForCPUFencePassed(uint fence) { }

	[ThreadSafe]
	// RVA: 0x25CA400 Offset: 0x25C9600 VA: 0x1825CA400
	public static void SyncRenderThread() { }

	[ThreadSafe]
	// RVA: 0x25C9B10 Offset: 0x25C8D10 VA: 0x1825C9B10
	public static RectInt GetActiveViewport() { }

	[ThreadSafe]
	// RVA: 0x25C9D20 Offset: 0x25C8F20 VA: 0x1825C9D20
	public static void ProfileDrawChainBegin() { }

	[ThreadSafe]
	// RVA: 0x25C9D50 Offset: 0x25C8F50 VA: 0x1825C9D50
	public static void ProfileDrawChainEnd() { }

	// RVA: 0x25C9CE0 Offset: 0x25C8EE0 VA: 0x1825C9CE0
	public static void NotifyOfUIREvents(bool subscribe) { }

	[ThreadSafe]
	// RVA: 0x25C9BC0 Offset: 0x25C8DC0 VA: 0x1825C9BC0
	public static Matrix4x4 GetUnityProjectionMatrix() { }

	// RVA: 0x25CA4E0 Offset: 0x25C96E0 VA: 0x1825CA4E0
	private static void .cctor() { }

	// RVA: 0x25CA0F0 Offset: 0x25C92F0 VA: 0x1825CA0F0
	private static void RegisterIntermediateRenderer_Injected(Camera camera, Material material, ref Matrix4x4 transform, ref Bounds aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, ulong sceneCullingMask, int rendererCallbackFlags, IntPtr userData, int userDataSize) { }

	// RVA: 0x25CA2B0 Offset: 0x25C94B0 VA: 0x1825CA2B0
	private static void SetScissorRect_Injected(ref RectInt scissorRect) { }

	// RVA: 0x25C9940 Offset: 0x25C8B40 VA: 0x1825C9940
	private static IntPtr CreateStencilState_Injected(ref StencilState stencilState) { }

	// RVA: 0x25C9AD0 Offset: 0x25C8CD0 VA: 0x1825C9AD0
	private static void GetActiveViewport_Injected(out RectInt ret) { }

	// RVA: 0x25C9B80 Offset: 0x25C8D80 VA: 0x1825C9B80
	private static void GetUnityProjectionMatrix_Injected(out Matrix4x4 ret) { }
}

// Namespace: UnityEngine.UIElements.UIR
[NativeHeader("ModuleOverrides/com.unity.ui/Core/Native/Renderer/UIRendererJobProcessor.h")]
internal static class JobProcessor // TypeDefIndex: 11703
{
	// Methods

	// RVA: 0x25BAF10 Offset: 0x25BA110 VA: 0x1825BAF10
	internal static JobHandle ScheduleNudgeJobs(IntPtr buffer, int jobCount) { }

	// RVA: 0x25BADB0 Offset: 0x25B9FB0 VA: 0x1825BADB0
	internal static JobHandle ScheduleConvertMeshJobs(IntPtr buffer, int jobCount) { }

	// RVA: 0x25BAE60 Offset: 0x25BA060 VA: 0x1825BAE60
	internal static JobHandle ScheduleCopyClosingMeshJobs(IntPtr buffer, int jobCount) { }

	// RVA: 0x25BAEC0 Offset: 0x25BA0C0 VA: 0x1825BAEC0
	private static void ScheduleNudgeJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret) { }

	// RVA: 0x25BAD60 Offset: 0x25B9F60 VA: 0x1825BAD60
	private static void ScheduleConvertMeshJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret) { }

	// RVA: 0x25BAE10 Offset: 0x25BA010 VA: 0x1825BAE10
	private static void ScheduleCopyClosingMeshJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret) { }
}

// Namespace: 
public class Allocator2D.Area // TypeDefIndex: 11704
{
	// Fields
	public RectInt rect; // 0x10
	public BestFitAllocator allocator; // 0x20

	// Methods

	// RVA: 0x25B75C0 Offset: 0x25B67C0 VA: 0x1825B75C0
	public void .ctor(RectInt rect) { }
}

// Namespace: 
public class Allocator2D.Row : LinkedPoolItem<Allocator2D.Row> // TypeDefIndex: 11705
{
	// Fields
	public RectInt rect; // 0x18
	public Allocator2D.Area area; // 0x28
	public BestFitAllocator allocator; // 0x30
	public Alloc alloc; // 0x38
	public Allocator2D.Row next; // 0x50
	public static readonly LinkedPool<Allocator2D.Row> pool; // 0x0

	// Methods

	// RVA: 0x25C2230 Offset: 0x25C1430 VA: 0x1825C2230
	private static Allocator2D.Row Create() { }

	// RVA: 0x25C22A0 Offset: 0x25C14A0 VA: 0x1825C22A0
	private static void Reset(Allocator2D.Row row) { }

	// RVA: 0x25C23F0 Offset: 0x25C15F0 VA: 0x1825C23F0
	public void .ctor() { }

	// RVA: 0x25C22E0 Offset: 0x25C14E0 VA: 0x1825C22E0
	private static void .cctor() { }
}

// Namespace: 
public struct Allocator2D.Alloc2D // TypeDefIndex: 11706
{
	// Fields
	public RectInt rect; // 0x0
	public Allocator2D.Row row; // 0x10
	public Alloc alloc; // 0x18

	// Methods

	// RVA: 0x25B65D0 Offset: 0x25B57D0 VA: 0x1825B65D0
	public void .ctor(Allocator2D.Row row, Alloc alloc, int width, int height) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class Allocator2D // TypeDefIndex: 11707
{
	// Fields
	private readonly Vector2Int m_MinSize; // 0x10
	private readonly Vector2Int m_MaxSize; // 0x18
	private readonly Vector2Int m_MaxAllocSize; // 0x20
	private readonly int m_RowHeightBias; // 0x28
	private readonly Allocator2D.Row[] m_Rows; // 0x30
	private readonly List<Allocator2D.Area> m_Areas; // 0x38

	// Methods

	// RVA: 0x25B7230 Offset: 0x25B6430 VA: 0x1825B7230
	public void .ctor(Vector2Int minSize, Vector2Int maxSize, int rowHeightBias) { }

	// RVA: 0x25B6D60 Offset: 0x25B5F60 VA: 0x1825B6D60
	public bool TryAllocate(int width, int height, out Allocator2D.Alloc2D alloc2D) { }

	// RVA: 0x25B6B00 Offset: 0x25B5D00 VA: 0x1825B6B00
	public void Free(Allocator2D.Alloc2D alloc2D) { }

	// RVA: 0x25B6720 Offset: 0x25B5920 VA: 0x1825B6720
	private static void BuildAreas(List<Allocator2D.Area> areas, Vector2Int minSize, Vector2Int maxSize) { }

	// RVA: 0x25B6A20 Offset: 0x25B5C20 VA: 0x1825B6A20
	private static Vector2Int ComputeMaxAllocSize(List<Allocator2D.Area> areas, int rowHeightBias) { }

	// RVA: 0x25B69B0 Offset: 0x25B5BB0 VA: 0x1825B69B0
	private static Allocator2D.Row[] BuildRowArray(int maxRowHeight, int rowHeightBias) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class DetachedAllocator // TypeDefIndex: 11708
{
	// Fields
	private TempAllocator<Vertex> m_VertsPool; // 0x10
	private TempAllocator<ushort> m_IndexPool; // 0x18
	private List<MeshWriteData> m_MeshWriteDataPool; // 0x20
	private int m_MeshWriteDataCount; // 0x28
	private bool m_Disposed; // 0x2C

	// Methods

	// RVA: 0x25B8700 Offset: 0x25B7900 VA: 0x1825B8700 Slot: 4
	public void Dispose() { }

	// RVA: 0x25B87B0 Offset: 0x25B79B0 VA: 0x1825B87B0
	protected void Dispose(bool disposing) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal struct Transform3x4 // TypeDefIndex: 11709
{
	// Fields
	public Vector4 v0; // 0x0
	public Vector4 v1; // 0x10
	public Vector4 v2; // 0x20
}

// Namespace: UnityEngine.UIElements.UIR
internal class MeshHandle : LinkedPoolItem<MeshHandle> // TypeDefIndex: 11710
{
	// Fields
	internal Alloc allocVerts; // 0x18
	internal Alloc allocIndices; // 0x30
	internal uint triangleCount; // 0x48
	internal Page allocPage; // 0x50
	internal uint allocTime; // 0x58
	internal uint updateAllocID; // 0x5C

	// Methods

	// RVA: 0x25BBA70 Offset: 0x25BAC70 VA: 0x1825BBA70
	public void .ctor() { }
}

// Namespace: 
internal struct UIRenderDevice.AllocToUpdate // TypeDefIndex: 11711
{
	// Fields
	public uint id; // 0x0
	public uint allocTime; // 0x4
	public MeshHandle meshHandle; // 0x8
	public Alloc permAllocVerts; // 0x10
	public Alloc permAllocIndices; // 0x28
	public Page permPage; // 0x40
	public bool copyBackIndices; // 0x48
}

// Namespace: 
private struct UIRenderDevice.AllocToFree // TypeDefIndex: 11712
{
	// Fields
	public Alloc alloc; // 0x0
	public Page page; // 0x18
	public bool vertices; // 0x20
}

// Namespace: 
private struct UIRenderDevice.DeviceToFree // TypeDefIndex: 11713
{
	// Fields
	public uint handle; // 0x0
	public Page page; // 0x8

	// Methods

	// RVA: 0x25B8840 Offset: 0x25B7A40 VA: 0x1825B8840
	public void Dispose() { }
}

// Namespace: 
private struct UIRenderDevice.EvaluationState // TypeDefIndex: 11714
{
	// Fields
	public MaterialPropertyBlock stateMatProps; // 0x0
	public Material defaultMat; // 0x8
	public State curState; // 0x10
	public Page curPage; // 0x28
	public bool mustApplyMaterial; // 0x30
	public bool mustApplyCommonBlock; // 0x31
	public bool mustApplyStateBlock; // 0x32
	public bool mustApplyStencil; // 0x33
}

// Namespace: 
internal struct UIRenderDevice.DrawStatistics // TypeDefIndex: 11715
{
	// Fields
	public int currentFrameIndex; // 0x0
	public uint totalIndices; // 0x4
	public uint commandCount; // 0x8
	public uint drawCommandCount; // 0xC
	public uint materialSetCount; // 0x10
	public uint drawRangeCount; // 0x14
	public uint drawRangeCallCount; // 0x18
	public uint immediateDraws; // 0x1C
	public uint stencilRefChanges; // 0x20
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UIRenderDevice.<>c // TypeDefIndex: 11716
{
	// Fields
	public static readonly UIRenderDevice.<>c <>9; // 0x0
	public static Func<MeshHandle> <>9__50_0; // 0x8
	public static Action<MeshHandle> <>9__50_1; // 0x10

	// Methods

	// RVA: 0x25C2D90 Offset: 0x25C1F90 VA: 0x1825C2D90
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x25C2C60 Offset: 0x25C1E60 VA: 0x1825C2C60
	internal MeshHandle <.ctor>b__50_0() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void <.ctor>b__50_1(MeshHandle mh) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class UIRenderDevice : IDisposable // TypeDefIndex: 11717
{
	// Fields
	private readonly bool m_MockDevice; // 0x10
	private IntPtr m_DefaultStencilState; // 0x18
	private IntPtr m_VertexDecl; // 0x20
	private Page m_FirstPage; // 0x28
	private uint m_NextPageVertexCount; // 0x30
	private uint m_LargeMeshVertexCount; // 0x34
	private float m_IndexToVertexCountRatio; // 0x38
	private List<List<UIRenderDevice.AllocToFree>> m_DeferredFrees; // 0x40
	private List<List<UIRenderDevice.AllocToUpdate>> m_Updates; // 0x48
	private uint[] m_Fences; // 0x50
	private MaterialPropertyBlock m_StandardMatProps; // 0x58
	private uint m_FrameIndex; // 0x60
	private uint m_NextUpdateID; // 0x64
	private UIRenderDevice.DrawStatistics m_DrawStats; // 0x68
	private readonly LinkedPool<MeshHandle> m_MeshHandles; // 0x90
	private readonly DrawParams m_DrawParams; // 0x98
	private readonly TextureSlotManager m_TextureSlotManager; // 0xA0
	private static LinkedList<UIRenderDevice.DeviceToFree> m_DeviceFreeQueue; // 0x0
	private static int m_ActiveDeviceCount; // 0x8
	private static bool m_SubscribedToNotifications; // 0xC
	private static bool m_SynchronousFree; // 0xD
	private static readonly int s_GradientSettingsTexID; // 0x10
	private static readonly int s_ShaderInfoTexID; // 0x14
	private static readonly int s_TransformsPropID; // 0x18
	private static readonly int s_ClipRectsPropID; // 0x1C
	private static ProfilerMarker s_MarkerAllocate; // 0x20
	private static ProfilerMarker s_MarkerFree; // 0x28
	private static ProfilerMarker s_MarkerAdvanceFrame; // 0x30
	private static ProfilerMarker s_MarkerFence; // 0x38
	private static ProfilerMarker s_MarkerBeforeDraw; // 0x40
	private static Nullable<bool> s_VertexTexturingIsAvailable; // 0x48
	private static Nullable<bool> s_ShaderModelIs35; // 0x4A
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly uint <maxVerticesPerPage>k__BackingField; // 0xA8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <breakBatches>k__BackingField; // 0xAC
	private static Texture2D s_DefaultShaderInfoTexFloat; // 0x50
	private static Texture2D s_DefaultShaderInfoTexARGB8; // 0x58
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0xAD

	// Properties
	internal uint maxVerticesPerPage { get; }
	internal bool breakBatches { get; set; }
	internal static Texture2D defaultShaderInfoTexFloat { get; }
	internal static Texture2D defaultShaderInfoTexARGB8 { get; }
	internal static bool vertexTexturingIsAvailable { get; }
	internal static bool shaderModelIs35 { get; }
	private bool fullyCreated { get; }
	protected bool disposed { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x146AEB0 Offset: 0x146A0B0 VA: 0x18146AEB0
	internal uint get_maxVerticesPerPage() { }

	[CompilerGenerated]
	// RVA: 0x890A50 Offset: 0x88FC50 VA: 0x180890A50
	internal bool get_breakBatches() { }

	[CompilerGenerated]
	// RVA: 0x890A60 Offset: 0x88FC60 VA: 0x180890A60
	internal void set_breakBatches(bool value) { }

	// RVA: 0x25C7F20 Offset: 0x25C7120 VA: 0x1825C7F20
	private static void .cctor() { }

	// RVA: 0x25C8A90 Offset: 0x25C7C90 VA: 0x1825C8A90
	public void .ctor(uint initialVertexCapacity = 0, uint initialIndexCapacity = 0) { }

	// RVA: 0x25C83C0 Offset: 0x25C75C0 VA: 0x1825C83C0
	protected void .ctor(uint initialVertexCapacity, uint initialIndexCapacity, bool mockDevice) { }

	// RVA: 0x25C8E70 Offset: 0x25C8070 VA: 0x1825C8E70
	internal static Texture2D get_defaultShaderInfoTexFloat() { }

	// RVA: 0x25C8AB0 Offset: 0x25C7CB0 VA: 0x1825C8AB0
	internal static Texture2D get_defaultShaderInfoTexARGB8() { }

	// RVA: 0x25C9610 Offset: 0x25C8810 VA: 0x1825C9610
	internal static bool get_vertexTexturingIsAvailable() { }

	// RVA: 0x25C9430 Offset: 0x25C8630 VA: 0x1825C9430
	internal static bool get_shaderModelIs35() { }

	// RVA: 0x25C5F10 Offset: 0x25C5110 VA: 0x1825C5F10
	private void InitVertexDeclaration() { }

	// RVA: 0x25C4590 Offset: 0x25C3790 VA: 0x1825C4590
	private void CompleteCreation() { }

	// RVA: 0x25C9420 Offset: 0x25C8620 VA: 0x1825C9420
	private bool get_fullyCreated() { }

	[CompilerGenerated]
	// RVA: 0x1C44BA0 Offset: 0x1C43DA0 VA: 0x181C44BA0
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x1C44CF0 Offset: 0x1C43EF0 VA: 0x181C44CF0
	private void set_disposed(bool value) { }

	// RVA: 0x25C4910 Offset: 0x25C3B10 VA: 0x1825C4910 Slot: 4
	public void Dispose() { }

	// RVA: 0x25C4780 Offset: 0x25C3980 VA: 0x1825C4780 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x25C38A0 Offset: 0x25C2AA0 VA: 0x1825C38A0
	public MeshHandle Allocate(uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset) { }

	// RVA: 0x25C7900 Offset: 0x25C6B00 VA: 0x1825C7900
	public void Update(MeshHandle mesh, uint vertexCount, out NativeSlice<Vertex> vertexData) { }

	// RVA: 0x25C7B40 Offset: 0x25C6D40 VA: 0x1825C7B40
	public void Update(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset) { }

	// RVA: 0x25C76D0 Offset: 0x25C68D0 VA: 0x1825C76D0
	private void UpdateCopyBackIndices(MeshHandle mesh, bool copyBackIndices) { }

	// RVA: 0x25C2DF0 Offset: 0x25C1FF0 VA: 0x1825C2DF0
	internal List<UIRenderDevice.AllocToUpdate> ActiveUpdatesForMeshHandle(MeshHandle mesh) { }

	// RVA: 0x25C6E20 Offset: 0x25C6020 VA: 0x1825C6E20
	private bool TryAllocFromPage(Page page, uint vertexCount, uint indexCount, ref Alloc va, ref Alloc ia, bool shortLived) { }

	// RVA: 0x25C3970 Offset: 0x25C2B70 VA: 0x1825C3970
	private void Allocate(MeshHandle meshHandle, uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, bool shortLived) { }

	// RVA: 0x25C6FB0 Offset: 0x25C61B0 VA: 0x1825C6FB0
	private void UpdateAfterGPUUsedData(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset, out UIRenderDevice.AllocToUpdate allocToUpdate, bool copyBackIndices) { }

	// RVA: 0x25C5780 Offset: 0x25C4980 VA: 0x1825C5780
	public void Free(MeshHandle mesh) { }

	// RVA: 0x25C65A0 Offset: 0x25C57A0 VA: 0x1825C65A0
	public void OnFrameRenderingBegin() { }

	// RVA: -1 Offset: -1
	internal static NativeSlice<T> PtrToSlice<T>(void* p, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA97470 Offset: 0xA96670 VA: 0x180A97470
	|-UIRenderDevice.PtrToSlice<DrawBufferRange>
	|
	|-RVA: 0xA97580 Offset: 0xA96780 VA: 0x180A97580
	|-UIRenderDevice.PtrToSlice<ushort>
	|
	|-RVA: 0xA97600 Offset: 0xA96800 VA: 0x180A97600
	|-UIRenderDevice.PtrToSlice<Vertex>
	|
	|-RVA: 0xA974F0 Offset: 0xA966F0 VA: 0x180A974F0
	|-UIRenderDevice.PtrToSlice<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x25C43E0 Offset: 0x25C35E0 VA: 0x1825C43E0
	private void ApplyDrawCommandState(RenderChainCommand cmd, int textureSlot, Material newMat, bool newMatDiffers, ref UIRenderDevice.EvaluationState st) { }

	// RVA: 0x25C4210 Offset: 0x25C3410 VA: 0x1825C4210
	private void ApplyBatchState(ref UIRenderDevice.EvaluationState st, bool allowMaterialChange) { }

	// RVA: 0x25C4980 Offset: 0x25C3B80 VA: 0x1825C4980
	public void EvaluateChain(RenderChainCommand head, Material initialMat, Material defaultMat, Texture gradientSettings, Texture shaderInfo, float pixelsPerPoint, NativeSlice<Transform3x4> transforms, NativeSlice<Vector4> clipRects, MaterialPropertyBlock stateMatProps, bool allowMaterialChange, ref Exception immediateException) { }

	// RVA: 0x25C7820 Offset: 0x25C6A20 VA: 0x1825C7820
	private void UpdateFenceValue() { }

	// RVA: 0x25C6230 Offset: 0x25C5430 VA: 0x1825C6230
	private void KickRanges(DrawBufferRange* ranges, ref int rangesReady, ref int rangesStart, int rangesCount, Page curPage) { }

	// RVA: -1 Offset: -1
	private void DrawRanges<I, T>(Utility.GPUBuffer<I> ib, Utility.GPUBuffer<T> vb, NativeSlice<DrawBufferRange> ranges) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA97320 Offset: 0xA96520 VA: 0x180A97320
	|-UIRenderDevice.DrawRanges<ushort, Vertex>
	|
	|-RVA: 0xA971D0 Offset: 0xA963D0 VA: 0x180A971D0
	|-UIRenderDevice.DrawRanges<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x25C7E10 Offset: 0x25C7010 VA: 0x1825C7E10
	private void WaitOnCpuFence(uint fence) { }

	// RVA: 0x25C2E60 Offset: 0x25C2060 VA: 0x1825C2E60
	public void AdvanceFrame() { }

	// RVA: 0x25C6C80 Offset: 0x25C5E80 VA: 0x1825C6C80
	private void PruneUnusedPages() { }

	// RVA: 0x25C6640 Offset: 0x25C5840 VA: 0x1825C6640
	internal static void PrepareForGfxDeviceRecreate() { }

	// RVA: 0x25C7EC0 Offset: 0x25C70C0 VA: 0x1825C7EC0
	internal static void WrapUpGfxDeviceRecreate() { }

	// RVA: 0x25C56F0 Offset: 0x25C48F0 VA: 0x1825C56F0
	internal static void FlushAllPendingDeviceDisposes() { }

	// RVA: 0x25C5EF0 Offset: 0x25C50F0 VA: 0x1825C5EF0
	internal UIRenderDevice.DrawStatistics GatherDrawStatistics() { }

	// RVA: 0x25C6800 Offset: 0x25C5A00 VA: 0x1825C6800
	private static void ProcessDeviceFreeQueue() { }

	// RVA: 0x25C6500 Offset: 0x25C5700 VA: 0x1825C6500
	private static void OnEngineUpdateGlobal() { }

	// RVA: 0x25C6540 Offset: 0x25C5740 VA: 0x1825C6540
	private static void OnFlushPendingResources() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal struct Alloc // TypeDefIndex: 11718
{
	// Fields
	public uint start; // 0x0
	public uint size; // 0x4
	internal object handle; // 0x8
	internal bool shortLived; // 0x10
}

// Namespace: 
private class BestFitAllocator.BlockPool : LinkedPool<BestFitAllocator.Block> // TypeDefIndex: 11719
{
	// Methods

	// RVA: 0x25B8560 Offset: 0x25B7760 VA: 0x1825B8560
	private static BestFitAllocator.Block CreateBlock() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private static void ResetBlock(BestFitAllocator.Block block) { }

	// RVA: 0x25B85D0 Offset: 0x25B77D0 VA: 0x1825B85D0
	public void .ctor() { }
}

// Namespace: 
private class BestFitAllocator.Block : LinkedPoolItem<BestFitAllocator.Block> // TypeDefIndex: 11720
{
	// Fields
	public uint start; // 0x18
	public uint end; // 0x1C
	public BestFitAllocator.Block prev; // 0x20
	public BestFitAllocator.Block next; // 0x28
	public BestFitAllocator.Block prevAvailable; // 0x30
	public BestFitAllocator.Block nextAvailable; // 0x38
	public bool allocated; // 0x40

	// Properties
	public uint size { get; }

	// Methods

	// RVA: 0x25B86F0 Offset: 0x25B78F0 VA: 0x1825B86F0
	public uint get_size() { }

	// RVA: 0x25B86B0 Offset: 0x25B78B0 VA: 0x1825B86B0
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class BestFitAllocator // TypeDefIndex: 11721
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly uint <totalSize>k__BackingField; // 0x10
	private BestFitAllocator.Block m_FirstBlock; // 0x18
	private BestFitAllocator.Block m_FirstAvailableBlock; // 0x20
	private BestFitAllocator.BlockPool m_BlockPool; // 0x28
	private uint m_HighWatermark; // 0x30

	// Properties
	public uint totalSize { get; }
	public uint highWatermark { get; }

	// Methods

	// RVA: 0x25B83F0 Offset: 0x25B75F0 VA: 0x1825B83F0
	public void .ctor(uint size) { }

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public uint get_totalSize() { }

	// RVA: 0x25B8550 Offset: 0x25B7750 VA: 0x1825B8550
	public uint get_highWatermark() { }

	// RVA: 0x25B7CC0 Offset: 0x25B6EC0 VA: 0x1825B7CC0
	public Alloc Allocate(uint size) { }

	// RVA: 0x25B80B0 Offset: 0x25B72B0 VA: 0x1825B80B0
	public void Free(Alloc alloc) { }

	// RVA: 0x25B7FA0 Offset: 0x25B71A0 VA: 0x1825B7FA0
	private BestFitAllocator.Block CoalesceBlockWithPrevious(BestFitAllocator.Block block) { }

	// RVA: 0x25B7F60 Offset: 0x25B7160 VA: 0x1825B7F60
	private BestFitAllocator.Block BestFitFindAvailableBlock(uint size) { }

	// RVA: 0x25B82F0 Offset: 0x25B74F0 VA: 0x1825B82F0
	private void SplitBlock(BestFitAllocator.Block block, uint size) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class GPUBufferAllocator // TypeDefIndex: 11722
{
	// Fields
	private BestFitAllocator m_Low; // 0x10
	private BestFitAllocator m_High; // 0x18

	// Properties
	public bool isEmpty { get; }

	// Methods

	// RVA: 0x25B8F00 Offset: 0x25B8100 VA: 0x1825B8F00
	public void .ctor(uint maxSize) { }

	// RVA: 0x25B8C40 Offset: 0x25B7E40 VA: 0x1825B8C40
	public Alloc Allocate(uint size, bool shortLived) { }

	// RVA: 0x25B8E50 Offset: 0x25B8050 VA: 0x1825B8E50
	public void Free(Alloc alloc) { }

	// RVA: 0x25B8F90 Offset: 0x25B8190 VA: 0x1825B8F90
	public bool get_isEmpty() { }

	// RVA: 0x25B8ED0 Offset: 0x25B80D0 VA: 0x1825B8ED0
	private bool HighLowCollide() { }
}

// Namespace: 
public class Page.DataSet<T> : IDisposable // TypeDefIndex: 11723
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x0
	public Utility.GPUBuffer<T> gpuData; // 0x0
	public NativeArray<T> cpuData; // 0x0
	public NativeArray<GfxUpdateBufferRange> updateRanges; // 0x0
	public GPUBufferAllocator allocator; // 0x0
	private readonly uint m_UpdateRangePoolSize; // 0x0
	private uint m_ElemStride; // 0x0
	private uint m_UpdateRangeMin; // 0x0
	private uint m_UpdateRangeMax; // 0x0
	private uint m_UpdateRangesEnqueued; // 0x0
	private uint m_UpdateRangesBatchStart; // 0x0
	private bool m_UpdateRangesSaturated; // 0x0

	// Properties
	protected bool disposed { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Utility.GPUBufferType bufferType, uint totalCount, uint maxQueuedFrameCount, uint updateRangePoolSize, bool mockBuffer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFBEE60 Offset: 0xFBE060 VA: 0x180FBEE60
	|-Page.DataSet<ushort>..ctor
	|
	|-RVA: 0xFBF010 Offset: 0xFBE210 VA: 0x180FBF010
	|-Page.DataSet<Vertex>..ctor
	|
	|-RVA: 0xFBECB0 Offset: 0xFBDEB0 VA: 0x180FBECB0
	|-Page.DataSet<__Il2CppFullySharedGenericStructType>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected bool get_disposed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	|-Page.DataSet<ushort>.get_disposed
	|-Page.DataSet<Vertex>.get_disposed
	|-Page.DataSet<__Il2CppFullySharedGenericStructType>.get_disposed
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_disposed(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	|-Page.DataSet<ushort>.set_disposed
	|-Page.DataSet<Vertex>.set_disposed
	|-Page.DataSet<__Il2CppFullySharedGenericStructType>.set_disposed
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFBD710 Offset: 0xFBC910 VA: 0x180FBD710
	|-Page.DataSet<ushort>.Dispose
	|
	|-RVA: 0xFBD5D0 Offset: 0xFBC7D0 VA: 0x180FBD5D0
	|-Page.DataSet<Vertex>.Dispose
	|
	|-RVA: 0xFBD6A0 Offset: 0xFBC8A0 VA: 0x180FBD6A0
	|-Page.DataSet<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFBD460 Offset: 0xFBC660 VA: 0x180FBD460
	|-Page.DataSet<ushort>.Dispose
	|
	|-RVA: 0xFBD3C0 Offset: 0xFBC5C0 VA: 0x180FBD3C0
	|-Page.DataSet<Vertex>.Dispose
	|
	|-RVA: 0xFBD500 Offset: 0xFBC700 VA: 0x180FBD500
	|-Page.DataSet<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public void RegisterUpdate(uint start, uint size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFBDCC0 Offset: 0xFBCEC0 VA: 0x180FBDCC0
	|-Page.DataSet<ushort>.RegisterUpdate
	|
	|-RVA: 0xFBD8A0 Offset: 0xFBCAA0 VA: 0x180FBD8A0
	|-Page.DataSet<Vertex>.RegisterUpdate
	|
	|-RVA: 0xFBDAA0 Offset: 0xFBCCA0 VA: 0x180FBDAA0
	|-Page.DataSet<__Il2CppFullySharedGenericStructType>.RegisterUpdate
	*/

	// RVA: -1 Offset: -1
	private bool HasMappedBufferRange() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFBD860 Offset: 0xFBCA60 VA: 0x180FBD860
	|-Page.DataSet<ushort>.HasMappedBufferRange
	|
	|-RVA: 0xFBD820 Offset: 0xFBCA20 VA: 0x180FBD820
	|-Page.DataSet<Vertex>.HasMappedBufferRange
	|
	|-RVA: 0xFBD7E0 Offset: 0xFBC9E0 VA: 0x180FBD7E0
	|-Page.DataSet<__Il2CppFullySharedGenericStructType>.HasMappedBufferRange
	*/

	// RVA: -1 Offset: -1
	public void SendUpdates() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFBEA80 Offset: 0xFBDC80 VA: 0x180FBEA80
	|-Page.DataSet<ushort>.SendUpdates
	|
	|-RVA: 0xFBE8D0 Offset: 0xFBDAD0 VA: 0x180FBE8D0
	|-Page.DataSet<Vertex>.SendUpdates
	|
	|-RVA: 0xFBEC30 Offset: 0xFBDE30 VA: 0x180FBEC30
	|-Page.DataSet<__Il2CppFullySharedGenericStructType>.SendUpdates
	*/

	// RVA: -1 Offset: -1
	public void SendFullRange() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFBE040 Offset: 0xFBD240 VA: 0x180FBE040
	|-Page.DataSet<ushort>.SendFullRange
	|
	|-RVA: 0xFBE180 Offset: 0xFBD380 VA: 0x180FBE180
	|-Page.DataSet<Vertex>.SendFullRange
	|
	|-RVA: 0xFBDEF0 Offset: 0xFBD0F0 VA: 0x180FBDEF0
	|-Page.DataSet<__Il2CppFullySharedGenericStructType>.SendFullRange
	*/

	// RVA: -1 Offset: -1
	public void SendPartialRanges() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFBE2C0 Offset: 0xFBD4C0 VA: 0x180FBE2C0
	|-Page.DataSet<ushort>.SendPartialRanges
	|
	|-RVA: 0xFBE6C0 Offset: 0xFBD8C0 VA: 0x180FBE6C0
	|-Page.DataSet<Vertex>.SendPartialRanges
	|
	|-RVA: 0xFBE4D0 Offset: 0xFBD6D0 VA: 0x180FBE4D0
	|-Page.DataSet<__Il2CppFullySharedGenericStructType>.SendPartialRanges
	*/

	// RVA: -1 Offset: -1
	private void ResetUpdateState() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFBDEC0 Offset: 0xFBD0C0 VA: 0x180FBDEC0
	|-Page.DataSet<ushort>.ResetUpdateState
	|-Page.DataSet<Vertex>.ResetUpdateState
	|-Page.DataSet<__Il2CppFullySharedGenericStructType>.ResetUpdateState
	*/
}

// Namespace: UnityEngine.UIElements.UIR
internal class Page : IDisposable // TypeDefIndex: 11724
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x10
	public Page.DataSet<Vertex> vertices; // 0x18
	public Page.DataSet<ushort> indices; // 0x20
	public Page next; // 0x28
	public int framesEmpty; // 0x30

	// Properties
	protected bool disposed { get; set; }
	public bool isEmpty { get; }

	// Methods

	// RVA: 0x25BBFB0 Offset: 0x25BB1B0 VA: 0x1825BBFB0
	public void .ctor(uint vertexMaxCount, uint indexMaxCount, uint maxQueuedFrameCount, bool mockPage) { }

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	private void set_disposed(bool value) { }

	// RVA: 0x25BBF40 Offset: 0x25BB140 VA: 0x1825BBF40 Slot: 4
	public void Dispose() { }

	// RVA: 0x25BBEB0 Offset: 0x25BB0B0 VA: 0x1825BBEB0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x25BC0F0 Offset: 0x25BB2F0 VA: 0x1825BC0F0
	public bool get_isEmpty() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal enum VertexFlags // TypeDefIndex: 11725
{
	// Fields
	public int value__; // 0x0
	public const VertexFlags IsSolid = 0;
	public const VertexFlags IsText = 1;
	public const VertexFlags IsTextured = 2;
	public const VertexFlags IsDynamic = 3;
	public const VertexFlags IsSvgGradients = 4;
	[Obsolete("Enum member VertexFlags.LastType has been deprecated. Use VertexFlags.IsGraphViewEdge instead.")]
	public const VertexFlags LastType = 10;
	public const VertexFlags IsGraphViewEdge = 10;
}

// Namespace: UnityEngine.UIElements.UIR
internal struct State // TypeDefIndex: 11726
{
	// Fields
	public Material material; // 0x0
	public TextureId texture; // 0x8
	public int stencilRef; // 0xC
	public float sdfScale; // 0x10
}

// Namespace: UnityEngine.UIElements.UIR
internal enum CommandType // TypeDefIndex: 11727
{
	// Fields
	public int value__; // 0x0
	public const CommandType Draw = 0;
	public const CommandType ImmediateCull = 1;
	public const CommandType Immediate = 2;
	public const CommandType PushView = 3;
	public const CommandType PopView = 4;
	public const CommandType PushScissor = 5;
	public const CommandType PopScissor = 6;
	public const CommandType PushRenderTexture = 7;
	public const CommandType PopRenderTexture = 8;
	public const CommandType BlitToPreviousRT = 9;
	public const CommandType PushDefaultMaterial = 10;
	public const CommandType PopDefaultMaterial = 11;
}

// Namespace: UnityEngine.UIElements.UIR
internal class DrawParams // TypeDefIndex: 11728
{
	// Fields
	internal static readonly Rect k_UnlimitedRect; // 0x0
	internal static readonly Rect k_FullNormalizedRect; // 0x10
	internal readonly Stack<Matrix4x4> view; // 0x10
	internal readonly Stack<Rect> scissor; // 0x18
	internal readonly List<RenderTexture> renderTexture; // 0x20
	internal readonly List<Material> defaultMaterial; // 0x28

	// Methods

	// RVA: 0x25B88E0 Offset: 0x25B7AE0 VA: 0x1825B88E0
	public void Reset() { }

	// RVA: 0x25B8B10 Offset: 0x25B7D10 VA: 0x1825B8B10
	public void .ctor() { }

	// RVA: 0x25B8AB0 Offset: 0x25B7CB0 VA: 0x1825B8AB0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class RenderChainCommand : LinkedPoolItem<RenderChainCommand> // TypeDefIndex: 11729
{
	// Fields
	internal VisualElement owner; // 0x18
	internal RenderChainCommand prev; // 0x20
	internal RenderChainCommand next; // 0x28
	internal bool closing; // 0x30
	internal CommandType type; // 0x34
	internal State state; // 0x38
	internal MeshHandle mesh; // 0x50
	internal int indexOffset; // 0x58
	internal int indexCount; // 0x5C
	internal Action callback; // 0x60
	private static readonly int k_ID_MainTex; // 0x0
	private static ProfilerMarker s_ImmediateOverheadMarker; // 0x8

	// Methods

	// RVA: 0x25BD670 Offset: 0x25BC870 VA: 0x1825BD670
	internal void Reset() { }

	// RVA: 0x25BC570 Offset: 0x25BB770 VA: 0x1825BC570
	internal void ExecuteNonDrawMesh(DrawParams drawParams, float pixelsPerPoint, ref Exception immediateException) { }

	// RVA: 0x25BC2C0 Offset: 0x25BB4C0 VA: 0x1825BC2C0
	private void Blit(Texture source, RenderTexture destination, float depth) { }

	// RVA: 0x25BC430 Offset: 0x25BB630 VA: 0x1825BC430
	private static Rect CombineScissorRects(Rect r0, Rect r1) { }

	// RVA: 0x25BD540 Offset: 0x25BC740 VA: 0x1825BD540
	private static RectInt RectPointsToPixelsAndFlipYAxis(Rect rect, float pixelsPerPoint) { }

	// RVA: 0x25BD730 Offset: 0x25BC930 VA: 0x1825BD730
	public void .ctor() { }

	// RVA: 0x25BD6A0 Offset: 0x25BC8A0 VA: 0x1825BD6A0
	private static void .cctor() { }
}

// Namespace: 
private struct GradientSettingsAtlas.RawTexture // TypeDefIndex: 11730
{
	// Fields
	public Color32[] rgba; // 0x0
	public int width; // 0x8
	public int height; // 0xC

	// Methods

	// RVA: 0x25BC220 Offset: 0x25BB420 VA: 0x1825BC220
	public void WriteRawInt2Packed(int v0, int v1, int destX, int destY) { }

	// RVA: 0x25BC170 Offset: 0x25BB370 VA: 0x1825BC170
	public void WriteRawFloat4Packed(float f0, float f1, float f2, float f3, int destX, int destY) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class GradientSettingsAtlas : IDisposable // TypeDefIndex: 11731
{
	// Fields
	private static ProfilerMarker s_MarkerWrite; // 0x0
	private static ProfilerMarker s_MarkerCommit; // 0x8
	private readonly int m_Length; // 0x10
	private readonly int m_ElemWidth; // 0x14
	private BestFitAllocator m_Allocator; // 0x18
	private Texture2D m_Atlas; // 0x20
	private GradientSettingsAtlas.RawTexture m_RawAtlas; // 0x28
	private static int s_TextureCounter; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposed>k__BackingField; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <MustCommit>k__BackingField; // 0x39

	// Properties
	internal int length { get; }
	protected bool disposed { get; set; }
	public Texture2D atlas { get; }
	public bool MustCommit { get; set; }

	// Methods

	// RVA: 0x24765D0 Offset: 0x24757D0 VA: 0x1824765D0
	internal int get_length() { }

	[CompilerGenerated]
	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x4BD760 Offset: 0x4BC960 VA: 0x1804BD760
	private void set_disposed(bool value) { }

	// RVA: 0x25B9270 Offset: 0x25B8470 VA: 0x1825B9270 Slot: 4
	public void Dispose() { }

	// RVA: 0x25B92E0 Offset: 0x25B84E0 VA: 0x1825B92E0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x25B9AB0 Offset: 0x25B8CB0 VA: 0x1825B9AB0
	public void .ctor(int length = 4096) { }

	// RVA: 0x25B94C0 Offset: 0x25B86C0 VA: 0x1825B94C0
	public void Reset() { }

	// RVA: 0x2497C30 Offset: 0x2496E30 VA: 0x182497C30
	public Texture2D get_atlas() { }

	// RVA: 0x25B8FD0 Offset: 0x25B81D0 VA: 0x1825B8FD0
	public Alloc Add(int count) { }

	// RVA: 0x25B9580 Offset: 0x25B8780 VA: 0x1825B9580
	public void Write(Alloc alloc, GradientSettings[] settings, GradientRemap remap) { }

	[CompilerGenerated]
	// RVA: 0x4BD740 Offset: 0x4BC940 VA: 0x1804BD740
	public bool get_MustCommit() { }

	[CompilerGenerated]
	// RVA: 0x4BD790 Offset: 0x4BC990 VA: 0x1804BD790
	private void set_MustCommit(bool value) { }

	// RVA: 0x25B90B0 Offset: 0x25B82B0 VA: 0x1825B90B0
	public void Commit() { }

	// RVA: 0x25B9350 Offset: 0x25B8550 VA: 0x1825B9350
	private void PrepareAtlas() { }

	// RVA: 0x25B9A10 Offset: 0x25B8C10 VA: 0x1825B9A10
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class JobManager : IDisposable // TypeDefIndex: 11732
{
	// Fields
	private NativePagedList<NudgeJobData> m_NudgeJobs; // 0x10
	private NativePagedList<ConvertMeshJobData> m_ConvertMeshJobs; // 0x18
	private NativePagedList<CopyClosingMeshJobData> m_CopyClosingMeshJobs; // 0x20
	private JobMerger m_JobMerger; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x30

	// Properties
	protected bool disposed { get; set; }

	// Methods

	// RVA: 0x25B9C40 Offset: 0x25B8E40 VA: 0x1825B9C40
	public void Add(ref NudgeJobData job) { }

	// RVA: 0x25B9BE0 Offset: 0x25B8DE0 VA: 0x1825B9BE0
	public void Add(ref ConvertMeshJobData job) { }

	// RVA: 0x25B9B80 Offset: 0x25B8D80 VA: 0x1825B9B80
	public void Add(ref CopyClosingMeshJobData job) { }

	// RVA: 0x25BA320 Offset: 0x25B9520 VA: 0x1825BA320
	public void CompleteNudgeJobs() { }

	// RVA: 0x25B9FE0 Offset: 0x25B91E0 VA: 0x1825B9FE0
	public void CompleteConvertMeshJobs() { }

	// RVA: 0x25B9CA0 Offset: 0x25B8EA0 VA: 0x1825B9CA0
	public void CompleteClosingMeshJobs() { }

	[CompilerGenerated]
	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x40EC60 Offset: 0x40DE60 VA: 0x18040EC60
	private void set_disposed(bool value) { }

	// RVA: 0x25BA7A0 Offset: 0x25B99A0 VA: 0x1825BA7A0 Slot: 4
	public void Dispose() { }

	// RVA: 0x25BA660 Offset: 0x25B9860 VA: 0x1825BA660
	protected void Dispose(bool disposing) { }

	// RVA: 0x25BA910 Offset: 0x25B9B10 VA: 0x1825BA910
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal struct NudgeJobData // TypeDefIndex: 11733
{
	// Fields
	public IntPtr src; // 0x0
	public IntPtr dst; // 0x8
	public int count; // 0x10
	public IntPtr closingSrc; // 0x18
	public IntPtr closingDst; // 0x20
	public int closingCount; // 0x28
	public Matrix4x4 transform; // 0x2C
	public int vertsBeforeUVDisplacement; // 0x6C
	public int vertsAfterUVDisplacement; // 0x70
}

// Namespace: UnityEngine.UIElements.UIR
internal struct ConvertMeshJobData // TypeDefIndex: 11734
{
	// Fields
	public IntPtr vertSrc; // 0x0
	public IntPtr vertDst; // 0x8
	public int vertCount; // 0x10
	public Matrix4x4 transform; // 0x14
	public int transformUVs; // 0x54
	public Color32 xformClipPages; // 0x58
	public Color32 ids; // 0x5C
	public Color32 addFlags; // 0x60
	public Color32 opacityPage; // 0x64
	public Color32 textCoreSettingsPage; // 0x68
	public int isText; // 0x6C
	public float textureId; // 0x70
	public IntPtr indexSrc; // 0x78
	public IntPtr indexDst; // 0x80
	public int indexCount; // 0x88
	public int indexOffset; // 0x8C
	public int flipIndices; // 0x90
}

// Namespace: UnityEngine.UIElements.UIR
internal struct CopyClosingMeshJobData // TypeDefIndex: 11735
{
	// Fields
	public IntPtr vertSrc; // 0x0
	public IntPtr vertDst; // 0x8
	public int vertCount; // 0x10
	public IntPtr indexSrc; // 0x18
	public IntPtr indexDst; // 0x20
	public int indexCount; // 0x28
	public int indexOffset; // 0x2C
}

// Namespace: UnityEngine.UIElements.UIR
internal class JobMerger : IDisposable // TypeDefIndex: 11736
{
	// Fields
	private NativeArray<JobHandle> m_Jobs; // 0x10
	private int m_JobCount; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x24

	// Properties
	protected bool disposed { get; set; }

	// Methods

	// RVA: 0x25BACC0 Offset: 0x25B9EC0 VA: 0x1825BACC0
	public void .ctor(int capacity) { }

	// RVA: 0x25BAAB0 Offset: 0x25B9CB0 VA: 0x1825BAAB0
	public void Add(JobHandle job) { }

	// RVA: 0x25BAC10 Offset: 0x25B9E10 VA: 0x1825BAC10
	public JobHandle MergeAndReset() { }

	[CompilerGenerated]
	// RVA: 0x695F30 Offset: 0x695130 VA: 0x180695F30
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x7428E0 Offset: 0x741AE0 VA: 0x1807428E0
	private void set_disposed(bool value) { }

	// RVA: 0x25BAB90 Offset: 0x25B9D90 VA: 0x1825BAB90 Slot: 4
	public void Dispose() { }

	// RVA: 0x25BAB30 Offset: 0x25B9D30 VA: 0x1825BAB30
	protected void Dispose(bool disposing) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class LinkedPoolItem<T> // TypeDefIndex: 11737
{
	// Fields
	internal T poolNext; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-LinkedPoolItem<object>..ctor
	|-LinkedPoolItem<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine.UIElements.UIR
internal class LinkedPool<T> // TypeDefIndex: 11738
{
	// Fields
	private readonly Func<T> m_CreateFunc; // 0x0
	private readonly Action<T> m_ResetAction; // 0x0
	private readonly int m_Limit; // 0x0
	private T m_PoolFirst; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x0

	// Properties
	public int Count { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<T> createFunc, Action<T> resetAction, int limit = 10000) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132C250 Offset: 0x132B450 VA: 0x18132C250
	|-LinkedPool<object>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	|-LinkedPool<object>.get_Count
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_Count(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	|-LinkedPool<object>.set_Count
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132C1A0 Offset: 0x132B3A0 VA: 0x18132C1A0
	|-LinkedPool<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132C1B0 Offset: 0x132B3B0 VA: 0x18132C1B0
	|-LinkedPool<object>.Get
	*/

	// RVA: -1 Offset: -1
	public void Return(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x132C220 Offset: 0x132B420 VA: 0x18132C220
	|-LinkedPool<object>.Return
	*/
}

// Namespace: UnityEngine.UIElements.UIR
internal class BasicNode<T> : LinkedPoolItem<BasicNode<T>> // TypeDefIndex: 11739
{
	// Fields
	public BasicNode<T> next; // 0x0
	public T data; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void AppendTo(ref BasicNode<T> first) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE22C0 Offset: 0xEE14C0 VA: 0x180EE22C0
	|-BasicNode<TextureEntry>.AppendTo
	|
	|-RVA: 0xEE22F0 Offset: 0xEE14F0 VA: 0x180EE22F0
	|-BasicNode<__Il2CppFullySharedGenericType>.AppendTo
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB609D0 Offset: 0xB5FBD0 VA: 0x180B609D0
	|-BasicNode<TextureEntry>..ctor
	|
	|-RVA: 0xB609F0 Offset: 0xB5FBF0 VA: 0x180B609F0
	|-BasicNode<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine.UIElements.UIR
internal class BasicNodePool<T> : LinkedPool<BasicNode<T>> // TypeDefIndex: 11740
{
	// Methods

	// RVA: -1 Offset: -1
	private static void Reset(BasicNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE20B0 Offset: 0xEE12B0 VA: 0x180EE20B0
	|-BasicNodePool<TextureEntry>.Reset
	|
	|-RVA: 0xEE1FC0 Offset: 0xEE11C0 VA: 0x180EE1FC0
	|-BasicNodePool<__Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1
	private static BasicNode<T> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE1F30 Offset: 0xEE1130 VA: 0x180EE1F30
	|-BasicNodePool<TextureEntry>.Create
	|
	|-RVA: 0xEE1E80 Offset: 0xEE1080 VA: 0x180EE1E80
	|-BasicNodePool<__Il2CppFullySharedGenericType>.Create
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE20E0 Offset: 0xEE12E0 VA: 0x180EE20E0
	|-BasicNodePool<TextureEntry>..ctor
	|
	|-RVA: 0xEE21D0 Offset: 0xEE13D0 VA: 0x180EE21D0
	|-BasicNodePool<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
internal sealed class MeshBuilder.AllocMeshData.Allocator : MulticastDelegate // TypeDefIndex: 11741
{
	// Methods

	// RVA: 0x25B7520 Offset: 0x25B6720 VA: 0x1825B7520
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual MeshWriteData Invoke(uint vertexCount, uint indexCount, ref MeshBuilder.AllocMeshData allocatorData) { }
}

// Namespace: 
internal struct MeshBuilder.AllocMeshData // TypeDefIndex: 11742
{
	// Fields
	internal MeshBuilder.AllocMeshData.Allocator alloc; // 0x0
	internal Texture texture; // 0x8
	internal TextureId svgTexture; // 0x10
	internal Material material; // 0x18
	internal MeshGenerationContext.MeshFlags flags; // 0x20
	internal BMPAlloc colorAlloc; // 0x24

	// Methods

	// RVA: 0x25B66F0 Offset: 0x25B58F0 VA: 0x1825B66F0
	internal MeshWriteData Allocate(uint vertexCount, uint indexCount) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal static class MeshBuilder // TypeDefIndex: 11743
{
	// Fields
	private static ProfilerMarker s_VectorGraphics9Slice; // 0x0
	private static ProfilerMarker s_VectorGraphicsSplitTriangle; // 0x8
	private static ProfilerMarker s_VectorGraphicsScaleTriangle; // 0x10
	private static ProfilerMarker s_VectorGraphicsStretch; // 0x18
	internal static readonly int s_MaxTextMeshVertices; // 0x20

	// Methods

	// RVA: 0x25BAF70 Offset: 0x25BA170 VA: 0x1825BAF70
	private static Vertex ConvertTextVertexToUIRVertex(MeshInfo info, int index, Vector2 offset, VertexFlags flags = 1, bool isDynamicColor = False) { }

	// RVA: 0x25BB140 Offset: 0x25BA340 VA: 0x1825BB140
	private static int LimitTextVertices(int vertexCount, bool logTruncation = True) { }

	// RVA: 0x25BB270 Offset: 0x25BA470 VA: 0x1825BB270
	internal static void MakeText(MeshInfo meshInfo, Vector2 offset, MeshBuilder.AllocMeshData meshAlloc, VertexFlags flags = 1, bool isDynamicColor = False) { }

	// RVA: 0x25BB940 Offset: 0x25BAB40 VA: 0x1825BB940
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class NativePagedList<T> : IDisposable // TypeDefIndex: 11744
{
	// Fields
	private readonly int k_PoolCapacity; // 0x0
	private List<NativeArray<T>> m_Pages; // 0x0
	private NativeArray<T> m_CurrentPage; // 0x0
	private int m_CurrentPageCount; // 0x0
	private List<NativeSlice<T>> m_Enumerator; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposed>k__BackingField; // 0x0

	// Properties
	protected bool disposed { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int poolCapacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14808E0 Offset: 0x147FAE0 VA: 0x1814808E0
	|-NativePagedList<ConvertMeshJobData>..ctor
	|
	|-RVA: 0x1480B20 Offset: 0x147FD20 VA: 0x181480B20
	|-NativePagedList<CopyClosingMeshJobData>..ctor
	|
	|-RVA: 0x14807C0 Offset: 0x147F9C0 VA: 0x1814807C0
	|-NativePagedList<NudgeJobData>..ctor
	|
	|-RVA: 0x1480A00 Offset: 0x147FC00 VA: 0x181480A00
	|-NativePagedList<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Add(ref T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147EBF0 Offset: 0x147DDF0 VA: 0x18147EBF0
	|-NativePagedList<ConvertMeshJobData>.Add
	|
	|-RVA: 0x147E830 Offset: 0x147DA30 VA: 0x18147E830
	|-NativePagedList<CopyClosingMeshJobData>.Add
	|
	|-RVA: 0x147E9A0 Offset: 0x147DBA0 VA: 0x18147E9A0
	|-NativePagedList<NudgeJobData>.Add
	|
	|-RVA: 0x147EE20 Offset: 0x147E020 VA: 0x18147EE20
	|-NativePagedList<__Il2CppFullySharedGenericStructType>.Add
	*/

	// RVA: -1 Offset: -1
	public List<NativeSlice<T>> GetPages() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147FD00 Offset: 0x147EF00 VA: 0x18147FD00
	|-NativePagedList<ConvertMeshJobData>.GetPages
	|
	|-RVA: 0x147FF90 Offset: 0x147F190 VA: 0x18147FF90
	|-NativePagedList<CopyClosingMeshJobData>.GetPages
	|
	|-RVA: 0x147F810 Offset: 0x147EA10 VA: 0x18147F810
	|-NativePagedList<NudgeJobData>.GetPages
	|
	|-RVA: 0x147FAA0 Offset: 0x147ECA0 VA: 0x18147FAA0
	|-NativePagedList<__Il2CppFullySharedGenericStructType>.GetPages
	*/

	// RVA: -1 Offset: -1
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1480220 Offset: 0x147F420 VA: 0x181480220
	|-NativePagedList<ConvertMeshJobData>.Reset
	|-NativePagedList<CopyClosingMeshJobData>.Reset
	|
	|-RVA: 0x14803C0 Offset: 0x147F5C0 VA: 0x1814803C0
	|-NativePagedList<NudgeJobData>.Reset
	|
	|-RVA: 0x14805C0 Offset: 0x147F7C0 VA: 0x1814805C0
	|-NativePagedList<__Il2CppFullySharedGenericStructType>.Reset
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected bool get_disposed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4456F0 Offset: 0x4448F0 VA: 0x1804456F0
	|-NativePagedList<ConvertMeshJobData>.get_disposed
	|-NativePagedList<CopyClosingMeshJobData>.get_disposed
	|-NativePagedList<NudgeJobData>.get_disposed
	|-NativePagedList<__Il2CppFullySharedGenericStructType>.get_disposed
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_disposed(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x445700 Offset: 0x444900 VA: 0x180445700
	|-NativePagedList<ConvertMeshJobData>.set_disposed
	|-NativePagedList<CopyClosingMeshJobData>.set_disposed
	|-NativePagedList<NudgeJobData>.set_disposed
	|-NativePagedList<__Il2CppFullySharedGenericStructType>.set_disposed
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147F040 Offset: 0x147E240 VA: 0x18147F040
	|-NativePagedList<ConvertMeshJobData>.Dispose
	|
	|-RVA: 0x147F6F0 Offset: 0x147E8F0 VA: 0x18147F6F0
	|-NativePagedList<CopyClosingMeshJobData>.Dispose
	|
	|-RVA: 0x147F160 Offset: 0x147E360 VA: 0x18147F160
	|-NativePagedList<NudgeJobData>.Dispose
	|
	|-RVA: 0x147F530 Offset: 0x147E730 VA: 0x18147F530
	|-NativePagedList<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	protected void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147F2E0 Offset: 0x147E4E0 VA: 0x18147F2E0
	|-NativePagedList<ConvertMeshJobData>.Dispose
	|-NativePagedList<CopyClosingMeshJobData>.Dispose
	|
	|-RVA: 0x147F5B0 Offset: 0x147E7B0 VA: 0x18147F5B0
	|-NativePagedList<NudgeJobData>.Dispose
	|
	|-RVA: 0x147F3C0 Offset: 0x147E5C0 VA: 0x18147F3C0
	|-NativePagedList<__Il2CppFullySharedGenericStructType>.Dispose
	*/
}

// Namespace: 
private struct OpacityIdAccelerator.OpacityIdUpdateJob : IJobParallelFor // TypeDefIndex: 11745
{
	// Fields
	[NativeDisableContainerSafetyRestriction]
	public NativeSlice<Vertex> oldVerts; // 0x0
	[NativeDisableContainerSafetyRestriction]
	public NativeSlice<Vertex> newVerts; // 0x10
	public Color32 opacityData; // 0x20

	// Methods

	// RVA: 0x25BBDD0 Offset: 0x25BAFD0 VA: 0x1825BBDD0 Slot: 4
	public void Execute(int i) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class OpacityIdAccelerator : IDisposable // TypeDefIndex: 11746
{
	// Fields
	private NativeArray<JobHandle> m_Jobs; // 0x10
	private int m_NextJobIndex; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposed>k__BackingField; // 0x24

	// Properties
	protected bool disposed { get; set; }

	// Methods

	// RVA: 0x25BBB60 Offset: 0x25BAD60 VA: 0x1825BBB60
	public void CreateJob(NativeSlice<Vertex> oldVerts, NativeSlice<Vertex> newVerts, Color32 opacityData, int vertexCount) { }

	// RVA: 0x25BBAB0 Offset: 0x25BACB0 VA: 0x1825BBAB0
	public void CompleteJobs() { }

	[CompilerGenerated]
	// RVA: 0x695F30 Offset: 0x695130 VA: 0x180695F30
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x7428E0 Offset: 0x741AE0 VA: 0x1807428E0
	private void set_disposed(bool value) { }

	// RVA: 0x25BBC90 Offset: 0x25BAE90 VA: 0x1825BBC90 Slot: 4
	public void Dispose() { }

	// RVA: 0x25BBD00 Offset: 0x25BAF00 VA: 0x1825BBD00 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x25BBD60 Offset: 0x25BAF60 VA: 0x1825BBD60
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal struct ChainBuilderStats // TypeDefIndex: 11747
{
	// Fields
	public uint elementsAdded; // 0x0
	public uint elementsRemoved; // 0x4
	public uint recursiveClipUpdates; // 0x8
	public uint recursiveClipUpdatesExpanded; // 0xC
	public uint nonRecursiveClipUpdates; // 0x10
	public uint recursiveTransformUpdates; // 0x14
	public uint recursiveTransformUpdatesExpanded; // 0x18
	public uint recursiveOpacityUpdates; // 0x1C
	public uint recursiveOpacityUpdatesExpanded; // 0x20
	public uint opacityIdUpdates; // 0x24
	public uint colorUpdates; // 0x28
	public uint colorUpdatesExpanded; // 0x2C
	public uint recursiveVisualUpdates; // 0x30
	public uint recursiveVisualUpdatesExpanded; // 0x34
	public uint nonRecursiveVisualUpdates; // 0x38
	public uint dirtyProcessed; // 0x3C
	public uint nudgeTransformed; // 0x40
	public uint boneTransformed; // 0x44
	public uint skipTransformed; // 0x48
	public uint visualUpdateTransformed; // 0x4C
	public uint updatedMeshAllocations; // 0x50
	public uint newMeshAllocations; // 0x54
	public uint groupTransformElementsChanged; // 0x58
	public uint immedateRenderersActive; // 0x5C
}

// Namespace: 
private struct RenderChain.DepthOrderedDirtyTracking // TypeDefIndex: 11748
{
	// Fields
	public List<VisualElement> heads; // 0x0
	public List<VisualElement> tails; // 0x8
	public int[] minDepths; // 0x10
	public int[] maxDepths; // 0x18
	public uint dirtyID; // 0x20

	// Methods

	// RVA: 0x25D4DE0 Offset: 0x25D3FE0 VA: 0x1825D4DE0
	public void EnsureFits(int maxDepth) { }

	// RVA: 0x25D4F10 Offset: 0x25D4110 VA: 0x1825D4F10
	public void RegisterDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypes, RenderDataDirtyTypeClasses dirtyTypeClass) { }

	// RVA: 0x25D4C00 Offset: 0x25D3E00 VA: 0x1825D4C00
	public void ClearDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypesInverse) { }

	// RVA: 0x25D50E0 Offset: 0x25D42E0 VA: 0x1825D50E0
	public void Reset() { }
}

// Namespace: 
private struct RenderChain.RenderChainStaticIndexAllocator // TypeDefIndex: 11749
{
	// Fields
	private static List<RenderChain> renderChains; // 0x0

	// Methods

	// RVA: 0x25D5440 Offset: 0x25D4640 VA: 0x1825D5440
	public static int AllocateIndex(RenderChain renderChain) { }

	// RVA: 0x25D55D0 Offset: 0x25D47D0 VA: 0x1825D55D0
	public static void FreeIndex(int index) { }

	// RVA: 0x25D53C0 Offset: 0x25D45C0 VA: 0x1825D53C0
	public static RenderChain AccessIndex(int index) { }

	// RVA: 0x25D5650 Offset: 0x25D4850 VA: 0x1825D5650
	private static void .cctor() { }
}

// Namespace: 
private struct RenderChain.RenderNodeData // TypeDefIndex: 11750
{
	// Fields
	public Material standardMaterial; // 0x0
	public Material initialMaterial; // 0x8
	public MaterialPropertyBlock matPropBlock; // 0x10
	public RenderChainCommand firstCommand; // 0x18
	public UIRenderDevice device; // 0x20
	public Texture vectorAtlas; // 0x28
	public Texture shaderInfoAtlas; // 0x30
	public float dpiScale; // 0x38
	public NativeSlice<Transform3x4> transformConstants; // 0x40
	public NativeSlice<Vector4> clipRectConstants; // 0x50
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class RenderChain.<>c // TypeDefIndex: 11751
{
	// Fields
	public static readonly RenderChain.<>c <>9; // 0x0
	public static Func<RenderChainCommand> <>9__34_0; // 0x8
	public static Action<RenderChainCommand> <>9__34_1; // 0x10

	// Methods

	// RVA: 0x25DD190 Offset: 0x25DC390 VA: 0x1825DD190
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x25DD140 Offset: 0x25DC340 VA: 0x1825DD140
	internal RenderChainCommand <.ctor>b__34_0() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void <.ctor>b__34_1(RenderChainCommand cmd) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class RenderChain : IDisposable // TypeDefIndex: 11752
{
	// Fields
	private RenderChainCommand m_FirstCommand; // 0x10
	private RenderChain.DepthOrderedDirtyTracking m_DirtyTracker; // 0x18
	private LinkedPool<RenderChainCommand> m_CommandPool; // 0x40
	private BasicNodePool<TextureEntry> m_TexturePool; // 0x48
	private List<RenderChain.RenderNodeData> m_RenderNodesData; // 0x50
	private Shader m_DefaultShader; // 0x58
	private Shader m_DefaultWorldSpaceShader; // 0x60
	private Material m_DefaultMat; // 0x68
	private Material m_DefaultWorldSpaceMat; // 0x70
	private bool m_BlockDirtyRegistration; // 0x78
	private int m_StaticIndex; // 0x7C
	private int m_ActiveRenderNodes; // 0x80
	private int m_CustomMaterialCommands; // 0x84
	private ChainBuilderStats m_Stats; // 0x88
	private uint m_StatsElementsAdded; // 0xE8
	private uint m_StatsElementsRemoved; // 0xEC
	private TextureRegistry m_TextureRegistry; // 0xF0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private OpacityIdAccelerator <opacityIdAccelerator>k__BackingField; // 0xF8
	private static ProfilerMarker s_MarkerProcess; // 0x0
	private static ProfilerMarker s_MarkerClipProcessing; // 0x8
	private static ProfilerMarker s_MarkerOpacityProcessing; // 0x10
	private static ProfilerMarker s_MarkerColorsProcessing; // 0x18
	private static ProfilerMarker s_MarkerTransformProcessing; // 0x20
	private static ProfilerMarker s_MarkerVisualsProcessing; // 0x28
	private static ProfilerMarker s_MarkerTextRegen; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x100
	internal static Action OnPreRender; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private BaseVisualElementPanel <panel>k__BackingField; // 0x108
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private UIRenderDevice <device>k__BackingField; // 0x110
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private AtlasBase <atlas>k__BackingField; // 0x118
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VectorImageManager <vectorImageManager>k__BackingField; // 0x120
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private TempAllocator<Vertex> <vertsPool>k__BackingField; // 0x128
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private TempAllocator<ushort> <indicesPool>k__BackingField; // 0x130
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private JobManager <jobManager>k__BackingField; // 0x138
	internal UIRVEShaderInfoAllocator shaderInfoAllocator; // 0x140
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private UIRStylePainter <painter>k__BackingField; // 0x210
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <drawStats>k__BackingField; // 0x218
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <drawInCameras>k__BackingField; // 0x219

	// Properties
	public OpacityIdAccelerator opacityIdAccelerator { get; set; }
	protected bool disposed { get; set; }
	internal BaseVisualElementPanel panel { get; set; }
	internal UIRenderDevice device { get; set; }
	internal AtlasBase atlas { get; set; }
	internal VectorImageManager vectorImageManager { get; set; }
	internal TempAllocator<Vertex> vertsPool { get; set; }
	internal TempAllocator<ushort> indicesPool { get; set; }
	internal JobManager jobManager { get; set; }
	internal UIRStylePainter painter { get; set; }
	internal bool drawStats { get; set; }
	internal bool drawInCameras { get; set; }
	internal Shader defaultShader { set; }
	internal Shader defaultWorldSpaceShader { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x794CD0 Offset: 0x793ED0 VA: 0x180794CD0
	public OpacityIdAccelerator get_opacityIdAccelerator() { }

	[CompilerGenerated]
	// RVA: 0x7960D0 Offset: 0x7952D0 VA: 0x1807960D0
	private void set_opacityIdAccelerator(OpacityIdAccelerator value) { }

	// RVA: 0x25C18D0 Offset: 0x25C0AD0 VA: 0x1825C18D0
	private static void .cctor() { }

	// RVA: 0x25C1D20 Offset: 0x25C0F20 VA: 0x1825C1D20
	public void .ctor(BaseVisualElementPanel panel) { }

	// RVA: 0x25BDA40 Offset: 0x25BCC40 VA: 0x1825BDA40
	private void Constructor(BaseVisualElementPanel panelObj, UIRenderDevice deviceObj, AtlasBase atlas, VectorImageManager vectorImageMan) { }

	// RVA: 0x25BDFF0 Offset: 0x25BD1F0 VA: 0x1825BDFF0
	private void Destructor() { }

	[CompilerGenerated]
	// RVA: 0x1864140 Offset: 0x1863340 VA: 0x181864140
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x25C2220 Offset: 0x25C1420 VA: 0x1825C2220
	private void set_disposed(bool value) { }

	// RVA: 0x25BE5C0 Offset: 0x25BD7C0 VA: 0x1825BE5C0 Slot: 4
	public void Dispose() { }

	// RVA: 0x25BE590 Offset: 0x25BD790 VA: 0x1825BE590
	protected void Dispose(bool disposing) { }

	// RVA: 0x25BFCD0 Offset: 0x25BEED0 VA: 0x1825BFCD0
	public void ProcessChanges() { }

	// RVA: 0x25C04F0 Offset: 0x25BF6F0 VA: 0x1825C04F0
	public void Render() { }

	// RVA: 0x25C0C60 Offset: 0x25BFE60 VA: 0x1825C0C60
	public void UIEOnChildAdded(VisualElement ve) { }

	// RVA: 0x25C1060 Offset: 0x25C0260 VA: 0x1825C1060
	public void UIEOnChildrenReordered(VisualElement ve) { }

	// RVA: 0x25C0F60 Offset: 0x25C0160 VA: 0x1825C0F60
	public void UIEOnChildRemoving(VisualElement ve) { }

	// RVA: 0x25C15E0 Offset: 0x25C07E0 VA: 0x1825C15E0
	public void UIEOnRenderHintsChanged(VisualElement ve) { }

	// RVA: 0x25C1360 Offset: 0x25C0560 VA: 0x1825C1360
	public void UIEOnClippingChanged(VisualElement ve, bool hierarchical) { }

	// RVA: 0x25C14A0 Offset: 0x25C06A0 VA: 0x1825C14A0
	public void UIEOnOpacityChanged(VisualElement ve, bool hierarchical = False) { }

	// RVA: 0x25C1400 Offset: 0x25C0600 VA: 0x1825C1400
	public void UIEOnColorChanged(VisualElement ve) { }

	// RVA: 0x25C1790 Offset: 0x25C0990 VA: 0x1825C1790
	public void UIEOnTransformOrSizeChanged(VisualElement ve, bool transformChanged, bool clipRectSizeChanged) { }

	// RVA: 0x25C1830 Offset: 0x25C0A30 VA: 0x1825C1830
	public void UIEOnVisualsChanged(VisualElement ve, bool hierarchical) { }

	// RVA: 0x25C1540 Offset: 0x25C0740 VA: 0x1825C1540
	public void UIEOnOpacityIdChanged(VisualElement ve) { }

	[CompilerGenerated]
	// RVA: 0x789810 Offset: 0x788A10 VA: 0x180789810
	internal BaseVisualElementPanel get_panel() { }

	[CompilerGenerated]
	// RVA: 0x789950 Offset: 0x788B50 VA: 0x180789950
	private void set_panel(BaseVisualElementPanel value) { }

	[CompilerGenerated]
	// RVA: 0x6ED520 Offset: 0x6EC720 VA: 0x1806ED520
	internal UIRenderDevice get_device() { }

	[CompilerGenerated]
	// RVA: 0x6ED6D0 Offset: 0x6EC8D0 VA: 0x1806ED6D0
	private void set_device(UIRenderDevice value) { }

	[CompilerGenerated]
	// RVA: 0x6ED510 Offset: 0x6EC710 VA: 0x1806ED510
	internal AtlasBase get_atlas() { }

	[CompilerGenerated]
	// RVA: 0x6ED6C0 Offset: 0x6EC8C0 VA: 0x1806ED6C0
	private void set_atlas(AtlasBase value) { }

	[CompilerGenerated]
	// RVA: 0x53DA70 Offset: 0x53CC70 VA: 0x18053DA70
	internal VectorImageManager get_vectorImageManager() { }

	[CompilerGenerated]
	// RVA: 0x6ED6F0 Offset: 0x6EC8F0 VA: 0x1806ED6F0
	private void set_vectorImageManager(VectorImageManager value) { }

	[CompilerGenerated]
	// RVA: 0x6ED530 Offset: 0x6EC730 VA: 0x1806ED530
	internal TempAllocator<Vertex> get_vertsPool() { }

	[CompilerGenerated]
	// RVA: 0x5405B0 Offset: 0x53F7B0 VA: 0x1805405B0
	private void set_vertsPool(TempAllocator<Vertex> value) { }

	[CompilerGenerated]
	// RVA: 0x19A2F10 Offset: 0x19A2110 VA: 0x1819A2F10
	internal TempAllocator<ushort> get_indicesPool() { }

	[CompilerGenerated]
	// RVA: 0x1C75790 Offset: 0x1C74990 VA: 0x181C75790
	private void set_indicesPool(TempAllocator<ushort> value) { }

	[CompilerGenerated]
	// RVA: 0x794CA0 Offset: 0x793EA0 VA: 0x180794CA0
	internal JobManager get_jobManager() { }

	[CompilerGenerated]
	// RVA: 0x1C62530 Offset: 0x1C61730 VA: 0x181C62530
	private void set_jobManager(JobManager value) { }

	[CompilerGenerated]
	// RVA: 0x1C61230 Offset: 0x1C60430 VA: 0x181C61230
	internal UIRStylePainter get_painter() { }

	[CompilerGenerated]
	// RVA: 0x1C61A20 Offset: 0x1C60C20 VA: 0x181C61A20
	private void set_painter(UIRStylePainter value) { }

	[CompilerGenerated]
	// RVA: 0x1C61240 Offset: 0x1C60440 VA: 0x181C61240
	internal bool get_drawStats() { }

	[CompilerGenerated]
	// RVA: 0x1C61A30 Offset: 0x1C60C30 VA: 0x181C61A30
	internal void set_drawStats(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C619F0 Offset: 0x1C60BF0 VA: 0x181C619F0
	internal bool get_drawInCameras() { }

	[CompilerGenerated]
	// RVA: 0x1C62710 Offset: 0x1C61910 VA: 0x181C62710
	private void set_drawInCameras(bool value) { }

	// RVA: 0x25C20C0 Offset: 0x25C12C0 VA: 0x1825C20C0
	internal void set_defaultShader(Shader value) { }

	// RVA: 0x25C2170 Offset: 0x25C1370 VA: 0x1825C2170
	internal void set_defaultWorldSpaceShader(Shader value) { }

	// RVA: 0x25BF060 Offset: 0x25BE260 VA: 0x1825BF060
	internal Material GetStandardMaterial() { }

	// RVA: 0x25BF150 Offset: 0x25BE350 VA: 0x1825BF150
	internal Material GetStandardWorldSpaceMaterial() { }

	// RVA: 0x25BEF50 Offset: 0x25BE150 VA: 0x1825BEF50
	internal void EnsureFitsDepth(int depth) { }

	// RVA: 0x25BD990 Offset: 0x25BCB90 VA: 0x1825BD990
	internal void ChildWillBeRemoved(VisualElement ve) { }

	// RVA: 0x25BD860 Offset: 0x25BCA60 VA: 0x1825BD860
	internal RenderChainCommand AllocCommand() { }

	// RVA: 0x25BEF60 Offset: 0x25BE160 VA: 0x1825BEF60
	internal void FreeCommand(RenderChainCommand cmd) { }

	// RVA: 0x25BFA90 Offset: 0x25BEC90 VA: 0x1825BFA90
	internal void OnRenderCommandAdded(RenderChainCommand command) { }

	// RVA: 0x25BFB10 Offset: 0x25BED10 VA: 0x1825BFB10
	internal void OnRenderCommandsRemoved(RenderChainCommand firstCommand, RenderChainCommand lastCommand) { }

	// RVA: 0x25BD770 Offset: 0x25BC970 VA: 0x1825BD770
	private static RenderChain.RenderNodeData AccessRenderNodeData(IntPtr obj) { }

	// RVA: 0x25BFB40 Offset: 0x25BED40 VA: 0x1825BFB40
	private static void OnRenderNodeExecute(IntPtr obj) { }

	// RVA: 0x25BF5F0 Offset: 0x25BE7F0 VA: 0x1825BF5F0
	private static void OnRegisterIntermediateRenderers(Camera camera) { }

	// RVA: 0x25BF240 Offset: 0x25BE440 VA: 0x1825BF240
	private static void OnRegisterIntermediateRendererMat(BaseRuntimePanel rtp, RenderChain renderChain, ref RenderChain.RenderNodeData rnd, Camera camera, int sameDistanceSortPriority) { }

	// RVA: 0x25C09E0 Offset: 0x25BFBE0 VA: 0x1825C09E0
	internal void RepaintTexturedElements() { }

	// RVA: 0x25BD8E0 Offset: 0x25BCAE0 VA: 0x1825BD8E0
	public void AppendTexture(VisualElement ve, Texture src, TextureId id, bool isAtlas) { }

	// RVA: 0x25C0B40 Offset: 0x25BFD40 VA: 0x1825C0B40
	public void ResetTextures(VisualElement ve) { }

	// RVA: 0x25BE630 Offset: 0x25BD830 VA: 0x1825BE630
	private void DrawStats() { }

	// RVA: 0x25BF030 Offset: 0x25BE230 VA: 0x1825BF030
	private static VisualElement GetFirstElementInPanel(VisualElement ve) { }
}

// Namespace: UnityEngine.UIElements.UIR
[Flags]
internal enum RenderDataDirtyTypes // TypeDefIndex: 11753
{
	// Fields
	public int value__; // 0x0
	public const RenderDataDirtyTypes None = 0;
	public const RenderDataDirtyTypes Transform = 1;
	public const RenderDataDirtyTypes ClipRectSize = 2;
	public const RenderDataDirtyTypes Clipping = 4;
	public const RenderDataDirtyTypes ClippingHierarchy = 8;
	public const RenderDataDirtyTypes Visuals = 16;
	public const RenderDataDirtyTypes VisualsHierarchy = 32;
	public const RenderDataDirtyTypes VisualsOpacityId = 64;
	public const RenderDataDirtyTypes Opacity = 128;
	public const RenderDataDirtyTypes OpacityHierarchy = 256;
	public const RenderDataDirtyTypes Color = 512;
	public const RenderDataDirtyTypes AllVisuals = 112;
}

// Namespace: UnityEngine.UIElements.UIR
internal enum RenderDataDirtyTypeClasses // TypeDefIndex: 11754
{
	// Fields
	public int value__; // 0x0
	public const RenderDataDirtyTypeClasses Clipping = 0;
	public const RenderDataDirtyTypeClasses Opacity = 1;
	public const RenderDataDirtyTypeClasses Color = 2;
	public const RenderDataDirtyTypeClasses TransformSize = 3;
	public const RenderDataDirtyTypeClasses Visuals = 4;
	public const RenderDataDirtyTypeClasses Count = 5;
}

// Namespace: UnityEngine.UIElements.UIR
[Flags]
internal enum RenderDataFlags // TypeDefIndex: 11755
{
	// Fields
	public int value__; // 0x0
	public const RenderDataFlags IsIgnoringDynamicColorHint = 1;
}

// Namespace: UnityEngine.UIElements.UIR
internal struct RenderChainVEData // TypeDefIndex: 11756
{
	// Fields
	internal VisualElement prev; // 0x0
	internal VisualElement next; // 0x8
	internal VisualElement groupTransformAncestor; // 0x10
	internal VisualElement boneTransformAncestor; // 0x18
	internal VisualElement prevDirty; // 0x20
	internal VisualElement nextDirty; // 0x28
	internal RenderDataFlags flags; // 0x30
	internal int hierarchyDepth; // 0x34
	internal RenderDataDirtyTypes dirtiedValues; // 0x38
	internal uint dirtyID; // 0x3C
	internal RenderChainCommand firstCommand; // 0x40
	internal RenderChainCommand lastCommand; // 0x48
	internal RenderChainCommand firstClosingCommand; // 0x50
	internal RenderChainCommand lastClosingCommand; // 0x58
	internal bool isInChain; // 0x60
	internal bool isHierarchyHidden; // 0x61
	internal bool localFlipsWinding; // 0x62
	internal bool localTransformScaleZero; // 0x63
	internal bool worldFlipsWinding; // 0x64
	public bool worldTransformScaleZero; // 0x65
	internal ClipMethod clipMethod; // 0x68
	internal int childrenStencilRef; // 0x6C
	internal int childrenMaskDepth; // 0x70
	internal bool disableNudging; // 0x74
	internal MeshHandle data; // 0x78
	internal MeshHandle closingData; // 0x80
	internal Matrix4x4 verticesSpace; // 0x88
	internal int displacementUVStart; // 0xC8
	internal int displacementUVEnd; // 0xCC
	internal BMPAlloc transformID; // 0xD0
	internal BMPAlloc clipRectID; // 0xD8
	internal BMPAlloc opacityID; // 0xE0
	internal BMPAlloc textCoreSettingsID; // 0xE8
	internal BMPAlloc colorID; // 0xF0
	internal BMPAlloc backgroundColorID; // 0xF8
	internal BMPAlloc borderLeftColorID; // 0x100
	internal BMPAlloc borderTopColorID; // 0x108
	internal BMPAlloc borderRightColorID; // 0x110
	internal BMPAlloc borderBottomColorID; // 0x118
	internal BMPAlloc tintColorID; // 0x120
	internal float compositeOpacity; // 0x128
	internal Color backgroundColor; // 0x12C
	internal BasicNode<TextureEntry> textures; // 0x140

	// Properties
	internal RenderChainCommand lastClosingOrLastCommand { get; }
	public bool isIgnoringDynamicColorHint { get; }

	// Methods

	// RVA: 0x25D57A0 Offset: 0x25D49A0 VA: 0x1825D57A0
	internal RenderChainCommand get_lastClosingOrLastCommand() { }

	// RVA: 0x25D56D0 Offset: 0x25D48D0 VA: 0x1825D56D0
	internal static bool AllocatesID(BMPAlloc alloc) { }

	// RVA: 0x25D5730 Offset: 0x25D4930 VA: 0x1825D5730
	internal static bool InheritsID(BMPAlloc alloc) { }

	// RVA: 0x25D5790 Offset: 0x25D4990 VA: 0x1825D5790
	public bool get_isIgnoringDynamicColorHint() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal struct TextureEntry // TypeDefIndex: 11757
{
	// Fields
	public Texture source; // 0x0
	public TextureId actual; // 0x8
	public bool replaced; // 0xC
}

// Namespace: UnityEngine.UIElements.UIR
internal abstract class BaseShaderInfoStorage : IDisposable // TypeDefIndex: 11758
{
	// Fields
	protected static int s_TextureCounter; // 0x0
	internal static ProfilerMarker s_MarkerCopyTexture; // 0x8
	internal static ProfilerMarker s_MarkerGetTextureData; // 0x10
	internal static ProfilerMarker s_MarkerUpdateTexture; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x10

	// Properties
	public abstract Texture2D texture { get; }
	protected bool disposed { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Texture2D get_texture();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool AllocateRect(int width, int height, out RectInt uvs);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void SetTexel(int x, int y, Color color);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void UpdateTexture();

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	private void set_disposed(bool value) { }

	// RVA: 0x25CFF40 Offset: 0x25CF140 VA: 0x1825CFF40 Slot: 4
	public void Dispose() { }

	// RVA: 0x25CFF30 Offset: 0x25CF130 VA: 0x1825CFF30 Slot: 9
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x25CFFB0 Offset: 0x25CF1B0 VA: 0x1825CFFB0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class ShaderInfoStorage<T> : BaseShaderInfoStorage // TypeDefIndex: 11759
{
	// Fields
	private readonly int m_InitialSize; // 0x0
	private readonly int m_MaxSize; // 0x0
	private readonly TextureFormat m_Format; // 0x0
	private readonly Func<Color, T> m_Convert; // 0x0
	private UIRAtlasAllocator m_Allocator; // 0x0
	private Texture2D m_Texture; // 0x0
	private NativeArray<T> m_Texels; // 0x0

	// Properties
	public override Texture2D texture { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TextureFormat format, Func<Color, T> convert, int initialSize = 64, int maxSize = 4096) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF6B80 Offset: 0xBF5D80 VA: 0x180BF6B80
	|-ShaderInfoStorage<Color>..ctor
	|
	|-RVA: 0xBF6C90 Offset: 0xBF5E90 VA: 0x180BF6C90
	|-ShaderInfoStorage<Color32>..ctor
	|
	|-RVA: 0xBF6DA0 Offset: 0xBF5FA0 VA: 0x180BF6DA0
	|-ShaderInfoStorage<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF64D0 Offset: 0xBF56D0 VA: 0x180BF64D0
	|-ShaderInfoStorage<Color>.Dispose
	|
	|-RVA: 0xBF6420 Offset: 0xBF5620 VA: 0x180BF6420
	|-ShaderInfoStorage<Color32>.Dispose
	|
	|-RVA: 0xBF6370 Offset: 0xBF5570 VA: 0x180BF6370
	|-ShaderInfoStorage<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override Texture2D get_texture() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	|-ShaderInfoStorage<Color>.get_texture
	|-ShaderInfoStorage<Color32>.get_texture
	|-ShaderInfoStorage<__Il2CppFullySharedGenericStructType>.get_texture
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override bool AllocateRect(int width, int height, out RectInt uvs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF4FF0 Offset: 0xBF41F0 VA: 0x180BF4FF0
	|-ShaderInfoStorage<Color>.AllocateRect
	|
	|-RVA: 0xBF5140 Offset: 0xBF4340 VA: 0x180BF5140
	|-ShaderInfoStorage<Color32>.AllocateRect
	|
	|-RVA: 0xBF5290 Offset: 0xBF4490 VA: 0x180BF5290
	|-ShaderInfoStorage<__Il2CppFullySharedGenericStructType>.AllocateRect
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void SetTexel(int x, int y, Color color) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF6740 Offset: 0xBF5940 VA: 0x180BF6740
	|-ShaderInfoStorage<Color>.SetTexel
	|
	|-RVA: 0xBF6840 Offset: 0xBF5A40 VA: 0x180BF6840
	|-ShaderInfoStorage<Color32>.SetTexel
	|
	|-RVA: 0xBF6580 Offset: 0xBF5780 VA: 0x180BF6580
	|-ShaderInfoStorage<__Il2CppFullySharedGenericStructType>.SetTexel
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void UpdateTexture() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF6940 Offset: 0xBF5B40 VA: 0x180BF6940
	|-ShaderInfoStorage<Color>.UpdateTexture
	|
	|-RVA: 0xBF69F0 Offset: 0xBF5BF0 VA: 0x180BF69F0
	|-ShaderInfoStorage<Color32>.UpdateTexture
	|
	|-RVA: 0xBF6AA0 Offset: 0xBF5CA0 VA: 0x180BF6AA0
	|-ShaderInfoStorage<__Il2CppFullySharedGenericStructType>.UpdateTexture
	*/

	// RVA: -1 Offset: -1
	private void CreateOrExpandTexture() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF5BE0 Offset: 0xBF4DE0 VA: 0x180BF5BE0
	|-ShaderInfoStorage<Color>.CreateOrExpandTexture
	|
	|-RVA: 0xBF5810 Offset: 0xBF4A10 VA: 0x180BF5810
	|-ShaderInfoStorage<Color32>.CreateOrExpandTexture
	|
	|-RVA: 0xBF5FD0 Offset: 0xBF51D0 VA: 0x180BF5FD0
	|-ShaderInfoStorage<__Il2CppFullySharedGenericStructType>.CreateOrExpandTexture
	*/

	// RVA: -1 Offset: -1
	private static void CpuBlit(NativeArray<T> src, int srcWidth, int srcHeight, NativeArray<T> dst, int dstWidth, int dstHeight) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF5700 Offset: 0xBF4900 VA: 0x180BF5700
	|-ShaderInfoStorage<Color>.CpuBlit
	|
	|-RVA: 0xBF5600 Offset: 0xBF4800 VA: 0x180BF5600
	|-ShaderInfoStorage<Color32>.CpuBlit
	|
	|-RVA: 0xBF53E0 Offset: 0xBF45E0 VA: 0x180BF53E0
	|-ShaderInfoStorage<__Il2CppFullySharedGenericStructType>.CpuBlit
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ShaderInfoStorageRGBA32.<>c // TypeDefIndex: 11760
{
	// Fields
	public static readonly ShaderInfoStorageRGBA32.<>c <>9; // 0x0

	// Methods

	// RVA: 0x25DD2B0 Offset: 0x25DC4B0 VA: 0x1825DD2B0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x25DCFA0 Offset: 0x25DC1A0 VA: 0x1825DCFA0
	internal Color32 <.cctor>b__2_0(Color c) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class ShaderInfoStorageRGBA32 : ShaderInfoStorage<Color32> // TypeDefIndex: 11761
{
	// Fields
	private static readonly Func<Color, Color32> s_Convert; // 0x0

	// Methods

	// RVA: 0x25DAD70 Offset: 0x25D9F70 VA: 0x1825DAD70
	public void .ctor(int initialSize = 64, int maxSize = 4096) { }

	// RVA: 0x25DACB0 Offset: 0x25D9EB0 VA: 0x1825DACB0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ShaderInfoStorageRGBAFloat.<>c // TypeDefIndex: 11762
{
	// Fields
	public static readonly ShaderInfoStorageRGBAFloat.<>c <>9; // 0x0

	// Methods

	// RVA: 0x25DD1F0 Offset: 0x25DC3F0 VA: 0x1825DD1F0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0xB069D0 Offset: 0xB05BD0 VA: 0x180B069D0
	internal Color <.cctor>b__2_0(Color c) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class ShaderInfoStorageRGBAFloat : ShaderInfoStorage<Color> // TypeDefIndex: 11763
{
	// Fields
	private static readonly Func<Color, Color> s_Convert; // 0x0

	// Methods

	// RVA: 0x25DAED0 Offset: 0x25DA0D0 VA: 0x1825DAED0
	public void .ctor(int initialSize = 64, int maxSize = 4096) { }

	// RVA: 0x25DAE10 Offset: 0x25DA010 VA: 0x1825DAE10
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal static class Shaders // TypeDefIndex: 11764
{
	// Fields
	public static readonly string k_AtlasBlit; // 0x0
	public static readonly string k_Editor; // 0x8
	public static readonly string k_Runtime; // 0x10
	public static readonly string k_RuntimeWorld; // 0x18
	public static readonly string k_GraphView; // 0x20
	public static readonly string k_ColorConversionBlit; // 0x28

	// Methods

	// RVA: 0x25DAF70 Offset: 0x25DA170 VA: 0x1825DAF70
	private static void .cctor() { }
}

// Namespace: 
private struct TempAllocator.Page<T> // TypeDefIndex: 11765
{
	// Fields
	public NativeArray<T> array; // 0x0
	public int used; // 0x0
}

// Namespace: UnityEngine.UIElements.UIR
internal class TempAllocator<T> : IDisposable // TypeDefIndex: 11766
{
	// Fields
	private readonly int m_ExcessMinCapacity; // 0x0
	private readonly int m_ExcessMaxCapacity; // 0x0
	private TempAllocator.Page<T> m_Pool; // 0x0
	private List<TempAllocator.Page<T>> m_Excess; // 0x0
	private int m_NextExcessSize; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x0

	// Properties
	protected bool disposed { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int poolCapacity, int excessMinCapacity, int excessMaxCapacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC6E280 Offset: 0xC6D480 VA: 0x180C6E280
	|-TempAllocator<ushort>..ctor
	|
	|-RVA: 0xC6E500 Offset: 0xC6D700 VA: 0x180C6E500
	|-TempAllocator<Vertex>..ctor
	|
	|-RVA: 0xC6E3C0 Offset: 0xC6D5C0 VA: 0x180C6E3C0
	|-TempAllocator<__Il2CppFullySharedGenericStructType>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected bool get_disposed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x691760 Offset: 0x690960 VA: 0x180691760
	|-TempAllocator<ushort>.get_disposed
	|-TempAllocator<Vertex>.get_disposed
	|-TempAllocator<__Il2CppFullySharedGenericStructType>.get_disposed
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_disposed(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC6E640 Offset: 0xC6D840 VA: 0x180C6E640
	|-TempAllocator<ushort>.set_disposed
	|-TempAllocator<Vertex>.set_disposed
	|-TempAllocator<__Il2CppFullySharedGenericStructType>.set_disposed
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC6DE00 Offset: 0xC6D000 VA: 0x180C6DE00
	|-TempAllocator<ushort>.Dispose
	|
	|-RVA: 0xC6DD50 Offset: 0xC6CF50 VA: 0x180C6DD50
	|-TempAllocator<Vertex>.Dispose
	|
	|-RVA: 0xC6DC80 Offset: 0xC6CE80 VA: 0x180C6DC80
	|-TempAllocator<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	protected void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC6DCF0 Offset: 0xC6CEF0 VA: 0x180C6DCF0
	|-TempAllocator<ushort>.Dispose
	|-TempAllocator<Vertex>.Dispose
	|
	|-RVA: 0xC6DBE0 Offset: 0xC6CDE0 VA: 0x180C6DBE0
	|-TempAllocator<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public NativeSlice<T> Alloc(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC6D7A0 Offset: 0xC6C9A0 VA: 0x180C6D7A0
	|-TempAllocator<ushort>.Alloc
	|
	|-RVA: 0xC6D360 Offset: 0xC6C560 VA: 0x180C6D360
	|-TempAllocator<Vertex>.Alloc
	|
	|-RVA: 0xC6CF10 Offset: 0xC6C110 VA: 0x180C6CF10
	|-TempAllocator<__Il2CppFullySharedGenericStructType>.Alloc
	*/

	// RVA: -1 Offset: -1
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC6E250 Offset: 0xC6D450 VA: 0x180C6E250
	|-TempAllocator<ushort>.Reset
	|-TempAllocator<Vertex>.Reset
	|
	|-RVA: 0xC6E220 Offset: 0xC6D420 VA: 0x180C6E220
	|-TempAllocator<__Il2CppFullySharedGenericStructType>.Reset
	*/

	// RVA: -1 Offset: -1
	private void ReleaseExcess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC6DEB0 Offset: 0xC6D0B0 VA: 0x180C6DEB0
	|-TempAllocator<ushort>.ReleaseExcess
	|-TempAllocator<Vertex>.ReleaseExcess
	|
	|-RVA: 0xC6E030 Offset: 0xC6D230 VA: 0x180C6E030
	|-TempAllocator<__Il2CppFullySharedGenericStructType>.ReleaseExcess
	*/
}

// Namespace: UnityEngine.UIElements.UIR
internal struct TextCoreSettings : IEquatable<TextCoreSettings> // TypeDefIndex: 11767
{
	// Fields
	public Color faceColor; // 0x0
	public Color outlineColor; // 0x10
	public float outlineWidth; // 0x20
	public Color underlayColor; // 0x24
	public Vector2 underlayOffset; // 0x34
	public float underlaySoftness; // 0x3C

	// Methods

	// RVA: 0x25DB1C0 Offset: 0x25DA3C0 VA: 0x1825DB1C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x25DB270 Offset: 0x25DA470 VA: 0x1825DB270 Slot: 4
	public bool Equals(TextCoreSettings other) { }

	// RVA: 0x25DB410 Offset: 0x25DA610 VA: 0x1825DB410 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
private struct TextureBlitter.BlitInfo // TypeDefIndex: 11768
{
	// Fields
	public Texture src; // 0x0
	public RectInt srcRect; // 0x8
	public Vector2Int dstPos; // 0x18
	public int border; // 0x20
	public Color tint; // 0x24
}

// Namespace: UnityEngine.UIElements.UIR
internal class TextureBlitter : IDisposable // TypeDefIndex: 11769
{
	// Fields
	private static readonly int[] k_TextureIds; // 0x0
	private static ProfilerMarker s_CommitSampler; // 0x8
	private TextureBlitter.BlitInfo[] m_SingleBlit; // 0x10
	private Material m_BlitMaterial; // 0x18
	private MaterialPropertyBlock m_Properties; // 0x20
	private RectInt m_Viewport; // 0x28
	private RenderTexture m_PrevRT; // 0x38
	private List<TextureBlitter.BlitInfo> m_PendingBlits; // 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposed>k__BackingField; // 0x48

	// Properties
	protected bool disposed { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x445A70 Offset: 0x444C70 VA: 0x180445A70
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x445A80 Offset: 0x444C80 VA: 0x180445A80
	private void set_disposed(bool value) { }

	// RVA: 0x25DB8B0 Offset: 0x25DAAB0 VA: 0x1825DB8B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x25DB920 Offset: 0x25DAB20 VA: 0x1825DB920 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x25DC260 Offset: 0x25DB460 VA: 0x1825DC260
	private static void .cctor() { }

	// RVA: 0x25DC370 Offset: 0x25DB570 VA: 0x1825DC370
	public void .ctor(int capacity = 512) { }

	// RVA: 0x25DC0F0 Offset: 0x25DB2F0 VA: 0x1825DC0F0
	public void QueueBlit(Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint) { }

	// RVA: 0x25DB6D0 Offset: 0x25DA8D0 VA: 0x1825DB6D0
	public void BlitOneNow(RenderTexture dst, Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint) { }

	// RVA: 0x25DB7B0 Offset: 0x25DA9B0 VA: 0x1825DB7B0
	public void Commit(RenderTexture dst) { }

	// RVA: 0x25DB4C0 Offset: 0x25DA6C0 VA: 0x1825DB4C0
	private void BeginBlit(RenderTexture dst) { }

	// RVA: 0x25DB9A0 Offset: 0x25DABA0 VA: 0x1825DB9A0
	private void DoBlit(IList<TextureBlitter.BlitInfo> blitInfos, int startIndex) { }

	// RVA: 0x25DC050 Offset: 0x25DB250 VA: 0x1825DC050
	private void EndBlit() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class TextureSlotManager // TypeDefIndex: 11770
{
	// Fields
	internal static readonly int k_SlotCount; // 0x0
	internal static readonly int k_SlotSize; // 0x4
	internal static readonly int[] slotIds; // 0x8
	internal static readonly int textureTableId; // 0x10
	private TextureId[] m_Textures; // 0x10
	private int[] m_Tickets; // 0x18
	private int m_CurrentTicket; // 0x20
	private int m_FirstUsedTicket; // 0x24
	private Vector4[] m_GpuTextures; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <FreeSlots>k__BackingField; // 0x30
	internal TextureRegistry textureRegistry; // 0x38

	// Properties
	public int FreeSlots { get; set; }

	// Methods

	// RVA: 0x25DCB70 Offset: 0x25DBD70 VA: 0x1825DCB70
	private static void .cctor() { }

	// RVA: 0x25DCD10 Offset: 0x25DBF10 VA: 0x1825DCD10
	public void .ctor() { }

	// RVA: 0x25DC820 Offset: 0x25DBA20 VA: 0x1825DC820
	public void Reset() { }

	// RVA: 0x25DCB00 Offset: 0x25DBD00 VA: 0x1825DCB00
	public void StartNewBatch() { }

	// RVA: 0x25DC6E0 Offset: 0x25DB8E0 VA: 0x1825DC6E0
	public int IndexOf(TextureId id) { }

	// RVA: 0x25DC7C0 Offset: 0x25DB9C0 VA: 0x1825DC7C0
	public void MarkUsed(int slotIndex) { }

	[CompilerGenerated]
	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public int get_FreeSlots() { }

	[CompilerGenerated]
	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	private void set_FreeSlots(int value) { }

	// RVA: 0x25DC610 Offset: 0x25DB810 VA: 0x1825DC610
	public int FindOldestSlot() { }

	// RVA: 0x25DC410 Offset: 0x25DB610 VA: 0x1825DC410
	public void Bind(TextureId id, float sdfScale, int slot, MaterialPropertyBlock mat) { }

	// RVA: 0x25DC970 Offset: 0x25DBB70 VA: 0x1825DC970
	public void SetGpuData(int slotIndex, TextureId id, int textureWidth, int textureHeight, float sdfScale) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class VectorImageRenderInfoPool.<>c // TypeDefIndex: 11771
{
	// Fields
	public static readonly VectorImageRenderInfoPool.<>c <>9; // 0x0
	public static Func<VectorImageRenderInfo> <>9__0_0; // 0x8
	public static Action<VectorImageRenderInfo> <>9__0_1; // 0x10

	// Methods

	// RVA: 0x25DD250 Offset: 0x25DC450 VA: 0x1825DD250
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x25DD030 Offset: 0x25DC230 VA: 0x1825DD030
	internal VectorImageRenderInfo <.ctor>b__0_0() { }

	// RVA: 0x25DD0A0 Offset: 0x25DC2A0 VA: 0x1825DD0A0
	internal void <.ctor>b__0_1(VectorImageRenderInfo vectorImageInfo) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class VectorImageRenderInfoPool : LinkedPool<VectorImageRenderInfo> // TypeDefIndex: 11772
{
	// Methods

	// RVA: 0x25EB310 Offset: 0x25EA510 VA: 0x1825EB310
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class VectorImageRenderInfo : LinkedPoolItem<VectorImageRenderInfo> // TypeDefIndex: 11773
{
	// Fields
	public int useCount; // 0x18
	public GradientRemap firstGradientRemap; // 0x20
	public Alloc gradientSettingsAlloc; // 0x28

	// Methods

	// RVA: 0x25EB4C0 Offset: 0x25EA6C0 VA: 0x1825EB4C0
	public void Reset() { }

	// RVA: 0x25EB4E0 Offset: 0x25EA6E0 VA: 0x1825EB4E0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class GradientRemapPool.<>c // TypeDefIndex: 11774
{
	// Fields
	public static readonly GradientRemapPool.<>c <>9; // 0x0
	public static Func<GradientRemap> <>9__0_0; // 0x8
	public static Action<GradientRemap> <>9__0_1; // 0x10

	// Methods

	// RVA: 0x25DD310 Offset: 0x25DC510 VA: 0x1825DD310
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x25DCFC0 Offset: 0x25DC1C0 VA: 0x1825DCFC0
	internal GradientRemap <.ctor>b__0_0() { }

	// RVA: 0x25DD0D0 Offset: 0x25DC2D0 VA: 0x1825DD0D0
	internal void <.ctor>b__0_1(GradientRemap gradientRemap) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class GradientRemapPool : LinkedPool<GradientRemap> // TypeDefIndex: 11775
{
	// Methods

	// RVA: 0x25D5160 Offset: 0x25D4360 VA: 0x1825D5160
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class GradientRemap : LinkedPoolItem<GradientRemap> // TypeDefIndex: 11776
{
	// Fields
	public int origIndex; // 0x18
	public int destIndex; // 0x1C
	public RectInt location; // 0x20
	public GradientRemap next; // 0x30
	public TextureId atlas; // 0x38

	// Methods

	// RVA: 0x25D5310 Offset: 0x25D4510 VA: 0x1825D5310
	public void Reset() { }

	// RVA: 0x25D5380 Offset: 0x25D4580 VA: 0x1825D5380
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class VectorImageManager : IDisposable // TypeDefIndex: 11777
{
	// Fields
	public static List<VectorImageManager> instances; // 0x0
	private static ProfilerMarker s_MarkerRegister; // 0x8
	private static ProfilerMarker s_MarkerUnregister; // 0x10
	private readonly AtlasBase m_Atlas; // 0x10
	private Dictionary<VectorImage, VectorImageRenderInfo> m_Registered; // 0x18
	private VectorImageRenderInfoPool m_RenderInfoPool; // 0x20
	private GradientRemapPool m_GradientRemapPool; // 0x28
	private GradientSettingsAtlas m_GradientSettingsAtlas; // 0x30
	private bool m_LoggedExhaustedSettingsAtlas; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x39

	// Properties
	public Texture2D atlas { get; }
	protected bool disposed { get; set; }

	// Methods

	// RVA: 0x25EB2F0 Offset: 0x25EA4F0 VA: 0x1825EB2F0
	public Texture2D get_atlas() { }

	// RVA: 0x25EAE50 Offset: 0x25EA050 VA: 0x1825EAE50
	public void .ctor(AtlasBase atlas) { }

	[CompilerGenerated]
	// RVA: 0x4BD740 Offset: 0x4BC940 VA: 0x1804BD740
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x4BD790 Offset: 0x4BC990 VA: 0x1804BD790
	private void set_disposed(bool value) { }

	// RVA: 0x25EA890 Offset: 0x25E9A90 VA: 0x1825EA890 Slot: 4
	public void Dispose() { }

	// RVA: 0x25EA770 Offset: 0x25E9970 VA: 0x1825EA770 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x25EA740 Offset: 0x25E9940 VA: 0x1825EA740
	public void Commit() { }

	// RVA: 0x25EA640 Offset: 0x25E9840 VA: 0x1825EA640
	public GradientRemap AddUser(VectorImage vi, VisualElement context) { }

	// RVA: 0x25EA900 Offset: 0x25E9B00 VA: 0x1825EA900
	private VectorImageRenderInfo Register(VectorImage vi, VisualElement context) { }

	// RVA: 0x25EAD60 Offset: 0x25E9F60 VA: 0x1825EAD60
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal enum OwnedState // TypeDefIndex: 11778
{
	// Fields
	public byte value__; // 0x0
	public const OwnedState Inherited = 0;
	public const OwnedState Owned = 1;
}

// Namespace: UnityEngine.UIElements.UIR
internal struct BMPAlloc // TypeDefIndex: 11779
{
	// Fields
	public static readonly BMPAlloc Invalid; // 0x0
	public int page; // 0x0
	public ushort pageLine; // 0x4
	public byte bitIndex; // 0x6
	public OwnedState ownedState; // 0x7

	// Methods

	// RVA: 0x25CFDE0 Offset: 0x25CEFE0 VA: 0x1825CFDE0
	public bool Equals(BMPAlloc other) { }

	// RVA: 0x25CFE00 Offset: 0x25CF000 VA: 0x1825CFE00
	public bool IsValid() { }

	// RVA: 0x25CFE10 Offset: 0x25CF010 VA: 0x1825CFE10 Slot: 3
	public override string ToString() { }

	// RVA: 0x25CFEE0 Offset: 0x25CF0E0 VA: 0x1825CFEE0
	private static void .cctor() { }
}

// Namespace: 
private struct BitmapAllocator32.Page // TypeDefIndex: 11780
{
	// Fields
	public ushort x; // 0x0
	public ushort y; // 0x2
	public int freeSlots; // 0x4
}

// Namespace: UnityEngine.UIElements.UIR
internal struct BitmapAllocator32 // TypeDefIndex: 11781
{
	// Fields
	private int m_PageHeight; // 0x0
	private List<BitmapAllocator32.Page> m_Pages; // 0x8
	private List<uint> m_AllocMap; // 0x10
	private int m_EntryWidth; // 0x18
	private int m_EntryHeight; // 0x1C

	// Properties
	public int entryWidth { get; }
	public int entryHeight { get; }

	// Methods

	// RVA: 0x25D0530 Offset: 0x25CF730 VA: 0x1825D0530
	public void Construct(int pageHeight, int entryWidth = 1, int entryHeight = 1) { }

	// RVA: 0x25D06B0 Offset: 0x25CF8B0 VA: 0x1825D06B0
	public void ForceFirstAlloc(ushort firstPageX, ushort firstPageY) { }

	// RVA: 0x25D0090 Offset: 0x25CF290 VA: 0x1825D0090
	public BMPAlloc Allocate(BaseShaderInfoStorage storage) { }

	// RVA: 0x25D0860 Offset: 0x25CFA60 VA: 0x1825D0860
	public void Free(BMPAlloc alloc) { }

	// RVA: 0xB78A40 Offset: 0xB77C40 VA: 0x180B78A40
	public int get_entryWidth() { }

	// RVA: 0x1208670 Offset: 0x1207870 VA: 0x181208670
	public int get_entryHeight() { }

	// RVA: 0x25D09A0 Offset: 0x25CFBA0 VA: 0x1825D09A0
	internal void GetAllocPageAtlasLocation(int page, out ushort x, out ushort y) { }

	// RVA: 0x25D0630 Offset: 0x25CF830 VA: 0x1825D0630
	private static byte CountTrailingZeroes(uint val) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal struct UIRVEShaderInfoAllocator // TypeDefIndex: 11782
{
	// Fields
	private BaseShaderInfoStorage m_Storage; // 0x0
	private BitmapAllocator32 m_TransformAllocator; // 0x8
	private BitmapAllocator32 m_ClipRectAllocator; // 0x28
	private BitmapAllocator32 m_OpacityAllocator; // 0x48
	private BitmapAllocator32 m_ColorAllocator; // 0x68
	private BitmapAllocator32 m_TextSettingsAllocator; // 0x88
	private bool m_StorageReallyCreated; // 0xA8
	private bool m_VertexTexturingEnabled; // 0xA9
	private NativeArray<Transform3x4> m_Transforms; // 0xB0
	private NativeArray<Vector4> m_ClipRects; // 0xC0
	internal static readonly Vector2Int identityTransformTexel; // 0x0
	internal static readonly Vector2Int infiniteClipRectTexel; // 0x8
	internal static readonly Vector2Int fullOpacityTexel; // 0x10
	internal static readonly Vector2Int clearColorTexel; // 0x18
	internal static readonly Vector2Int defaultTextCoreSettingsTexel; // 0x20
	internal static readonly Matrix4x4 identityTransformValue; // 0x28
	internal static readonly Vector4 identityTransformRow0Value; // 0x68
	internal static readonly Vector4 identityTransformRow1Value; // 0x78
	internal static readonly Vector4 identityTransformRow2Value; // 0x88
	internal static readonly Vector4 infiniteClipRectValue; // 0x98
	internal static readonly Vector4 fullOpacityValue; // 0xA8
	internal static readonly Vector4 clearColorValue; // 0xB8
	internal static readonly TextCoreSettings defaultTextCoreSettingsValue; // 0xC8
	public static readonly BMPAlloc identityTransform; // 0x108
	public static readonly BMPAlloc infiniteClipRect; // 0x110
	public static readonly BMPAlloc fullOpacity; // 0x118
	public static readonly BMPAlloc clearColor; // 0x120
	public static readonly BMPAlloc defaultTextCoreSettings; // 0x128

	// Properties
	private static int pageWidth { get; }
	private static int pageHeight { get; }
	public NativeSlice<Transform3x4> transformConstants { get; }
	public NativeSlice<Vector4> clipRectConstants { get; }
	public Texture atlas { get; }

	// Methods

	// RVA: 0x25EA5C0 Offset: 0x25E97C0 VA: 0x1825EA5C0
	private static int get_pageWidth() { }

	// RVA: 0x25EA5B0 Offset: 0x25E97B0 VA: 0x1825EA5B0
	private static int get_pageHeight() { }

	// RVA: 0x25E7DD0 Offset: 0x25E6FD0 VA: 0x1825E7DD0
	private static Vector2Int AllocToTexelCoord(ref BitmapAllocator32 allocator, BMPAlloc alloc) { }

	// RVA: 0x25E7D80 Offset: 0x25E6F80 VA: 0x1825E7D80
	private static int AllocToConstantBufferIndex(BMPAlloc alloc) { }

	// RVA: 0x25E7FA0 Offset: 0x25E71A0 VA: 0x1825E7FA0
	private static bool AtlasRectMatchesPage(ref BitmapAllocator32 allocator, BMPAlloc defAlloc, RectInt atlasRect) { }

	// RVA: 0x25EA5D0 Offset: 0x25E97D0 VA: 0x1825EA5D0
	public NativeSlice<Transform3x4> get_transformConstants() { }

	// RVA: 0x25EA540 Offset: 0x25E9740 VA: 0x1825EA540
	public NativeSlice<Vector4> get_clipRectConstants() { }

	// RVA: 0x25EA4A0 Offset: 0x25E96A0 VA: 0x1825EA4A0
	public Texture get_atlas() { }

	// RVA: 0x25E8380 Offset: 0x25E7580 VA: 0x1825E8380
	public void Construct() { }

	// RVA: 0x25E8BE0 Offset: 0x25E7DE0 VA: 0x1825E8BE0
	private void ReallyCreateStorage() { }

	// RVA: 0x25E8680 Offset: 0x25E7880 VA: 0x1825E8680
	public void Dispose() { }

	// RVA: 0x25E8AA0 Offset: 0x25E7CA0 VA: 0x1825E8AA0
	public void IssuePendingStorageChanges() { }

	// RVA: 0x25E7E60 Offset: 0x25E7060 VA: 0x1825E7E60
	public BMPAlloc AllocTransform() { }

	// RVA: 0x25E7AF0 Offset: 0x25E6CF0 VA: 0x1825E7AF0
	public BMPAlloc AllocClipRect() { }

	// RVA: 0x25E7CA0 Offset: 0x25E6EA0 VA: 0x1825E7CA0
	public BMPAlloc AllocOpacity() { }

	// RVA: 0x25E7C30 Offset: 0x25E6E30 VA: 0x1825E7C30
	public BMPAlloc AllocColor() { }

	// RVA: 0x25E7D10 Offset: 0x25E6F10 VA: 0x1825E7D10
	public BMPAlloc AllocTextCoreSettings(TextCoreSettings settings) { }

	// RVA: 0x25E9BE0 Offset: 0x25E8DE0 VA: 0x1825E9BE0
	public void SetTransformValue(BMPAlloc alloc, Matrix4x4 xform) { }

	// RVA: 0x25E9320 Offset: 0x25E8520 VA: 0x1825E9320
	public void SetClipRectValue(BMPAlloc alloc, Vector4 clipRect) { }

	// RVA: 0x25E9680 Offset: 0x25E8880 VA: 0x1825E9680
	public void SetOpacityValue(BMPAlloc alloc, float opacity) { }

	// RVA: 0x25E94D0 Offset: 0x25E86D0 VA: 0x1825E94D0
	public void SetColorValue(BMPAlloc alloc, Color color, bool isEditorContext) { }

	// RVA: 0x25E97B0 Offset: 0x25E89B0 VA: 0x1825E97B0
	public void SetTextCoreSettingValue(BMPAlloc alloc, TextCoreSettings settings, bool isEditorContext) { }

	// RVA: 0x25E8A00 Offset: 0x25E7C00 VA: 0x1825E8A00
	public void FreeTransform(BMPAlloc alloc) { }

	// RVA: 0x25E8780 Offset: 0x25E7980 VA: 0x1825E8780
	public void FreeClipRect(BMPAlloc alloc) { }

	// RVA: 0x25E88C0 Offset: 0x25E7AC0 VA: 0x1825E88C0
	public void FreeOpacity(BMPAlloc alloc) { }

	// RVA: 0x25E8820 Offset: 0x25E7A20 VA: 0x1825E8820
	public void FreeColor(BMPAlloc alloc) { }

	// RVA: 0x25E8960 Offset: 0x25E7B60 VA: 0x1825E8960
	public void FreeTextCoreSettings(BMPAlloc alloc) { }

	// RVA: 0x25EA060 Offset: 0x25E9260 VA: 0x1825EA060
	public Color32 TransformAllocToVertexData(BMPAlloc alloc) { }

	// RVA: 0x25E8130 Offset: 0x25E7330 VA: 0x1825E8130
	public Color32 ClipRectAllocToVertexData(BMPAlloc alloc) { }

	// RVA: 0x25E8AC0 Offset: 0x25E7CC0 VA: 0x1825E8AC0
	public Color32 OpacityAllocToVertexData(BMPAlloc alloc) { }

	// RVA: 0x25E8260 Offset: 0x25E7460 VA: 0x1825E8260
	public Color32 ColorAllocToVertexData(BMPAlloc alloc) { }

	// RVA: 0x25E9F40 Offset: 0x25E9140 VA: 0x1825E9F40
	public Color32 TextCoreSettingsToVertexData(BMPAlloc alloc) { }

	// RVA: 0x25EA190 Offset: 0x25E9390 VA: 0x1825EA190
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.UIR.Implementation
[Extension]
internal static class CommandGenerator // TypeDefIndex: 11783
{
	// Fields
	private static readonly ProfilerMarker k_GenerateEntries; // 0x0
	private static readonly ProfilerMarker k_ConvertEntriesToCommandsMarker; // 0x8
	private static readonly ProfilerMarker k_GenerateClosingCommandsMarker; // 0x10
	private static readonly ProfilerMarker k_NudgeVerticesMarker; // 0x18
	private static readonly ProfilerMarker k_UpdateOpacityIdMarker; // 0x20
	private static readonly ProfilerMarker k_ComputeTransformMatrixMarker; // 0x28
	private static Material s_blitMaterial_LinearToGamma; // 0x30
	private static Material s_blitMaterial_GammaToLinear; // 0x38
	private static Material s_blitMaterial_NoChange; // 0x40
	private static Shader s_blitShader; // 0x48

	// Methods

	// RVA: 0x25D19E0 Offset: 0x25D0BE0 VA: 0x1825D19E0
	private static void GetVerticesTransformInfo(VisualElement ve, out Matrix4x4 transform) { }

	// RVA: 0x25D0DA0 Offset: 0x25CFFA0 VA: 0x1825D0DA0
	internal static void ComputeTransformMatrix(VisualElement ve, VisualElement ancestor, out Matrix4x4 result) { }

	[Extension]
	// RVA: 0x25D2100 Offset: 0x25D1300 VA: 0x1825D2100
	private static bool IsParentOrAncestorOf(VisualElement ve, VisualElement child) { }

	// RVA: 0x25D26E0 Offset: 0x25D18E0 VA: 0x1825D26E0
	public static UIRStylePainter.ClosingInfo PaintElement(RenderChain renderChain, VisualElement ve, ref ChainBuilderStats stats) { }

	// RVA: 0x25D2010 Offset: 0x25D1210 VA: 0x1825D2010
	private static void InvokeGenerateVisualContent(VisualElement ve, MeshGenerationContext ctx) { }

	// RVA: 0x25D0F10 Offset: 0x25D0110 VA: 0x1825D0F10
	private static Material CreateBlitShader(float colorConversion) { }

	// RVA: 0x25D1700 Offset: 0x25D0900 VA: 0x1825D1700
	private static Material GetBlitMaterial(VisualElement.RenderTargetMode mode) { }

	// RVA: 0x25D0A20 Offset: 0x25CFC20 VA: 0x1825D0A20
	public static void ClosePaintElement(VisualElement ve, UIRStylePainter.ClosingInfo closingInfo, RenderChain renderChain, ref ChainBuilderStats stats) { }

	// RVA: 0x25D4960 Offset: 0x25D3B60 VA: 0x1825D4960
	private static void UpdateOrAllocate(ref MeshHandle data, int vertexCount, int indexCount, UIRenderDevice device, out NativeSlice<Vertex> verts, out NativeSlice<ushort> indices, out ushort indexOffset, ref ChainBuilderStats stats) { }

	// RVA: 0x25D48A0 Offset: 0x25D3AA0 VA: 0x1825D48A0
	public static void UpdateOpacityId(VisualElement ve, RenderChain renderChain) { }

	// RVA: 0x25D1120 Offset: 0x25D0320 VA: 0x1825D1120
	private static void DoUpdateOpacityId(VisualElement ve, RenderChain renderChain, MeshHandle mesh) { }

	// RVA: 0x25D21A0 Offset: 0x25D13A0 VA: 0x1825D21A0
	public static bool NudgeVerticesToNewSpace(VisualElement ve, RenderChain renderChain, UIRenderDevice device) { }

	// RVA: 0x25D4480 Offset: 0x25D3680 VA: 0x1825D4480
	private static void PrepareNudgeVertices(VisualElement ve, UIRenderDevice device, MeshHandle mesh, out IntPtr src, out IntPtr dst, out int count) { }

	// RVA: 0x25D1EA0 Offset: 0x25D10A0 VA: 0x1825D1EA0
	private static RenderChainCommand InjectMeshDrawCommand(RenderChain renderChain, VisualElement ve, ref RenderChainCommand cmdPrev, ref RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture, int stencilRef) { }

	// RVA: 0x25D1CC0 Offset: 0x25D0EC0 VA: 0x1825D1CC0
	private static RenderChainCommand InjectClosingMeshDrawCommand(RenderChain renderChain, VisualElement ve, ref RenderChainCommand cmdPrev, ref RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture, int stencilRef) { }

	// RVA: 0x25D1490 Offset: 0x25D0690 VA: 0x1825D1490
	private static void FindCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next) { }

	// RVA: 0x25D1290 Offset: 0x25D0490 VA: 0x1825D1290
	private static void FindClosingCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next) { }

	// RVA: 0x25D1DF0 Offset: 0x25D0FF0 VA: 0x1825D1DF0
	private static void InjectCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, ref RenderChainCommand prev, ref RenderChainCommand next) { }

	// RVA: 0x25D1BC0 Offset: 0x25D0DC0 VA: 0x1825D1BC0
	private static void InjectClosingCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, ref RenderChainCommand prev, ref RenderChainCommand next) { }

	// RVA: 0x25D45D0 Offset: 0x25D37D0 VA: 0x1825D45D0
	public static void ResetCommands(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x25D4A70 Offset: 0x25D3C70 VA: 0x1825D4A70
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.UIR.Implementation
internal enum ClipMethod // TypeDefIndex: 11784
{
	// Fields
	public int value__; // 0x0
	public const ClipMethod Undetermined = 0;
	public const ClipMethod NotClipped = 1;
	public const ClipMethod Scissor = 2;
	public const ClipMethod ShaderDiscard = 3;
	public const ClipMethod Stencil = 4;
}

// Namespace: UnityEngine.UIElements.UIR.Implementation
internal static class RenderEvents // TypeDefIndex: 11785
{
	// Fields
	private static readonly float VisibilityTreshold; // 0x0

	// Methods

	// RVA: 0x25D95E0 Offset: 0x25D87E0 VA: 0x1825D95E0
	internal static void ProcessOnClippingChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) { }

	// RVA: 0x25D9790 Offset: 0x25D8990 VA: 0x1825D9790
	internal static void ProcessOnOpacityChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) { }

	// RVA: 0x25D9700 Offset: 0x25D8900 VA: 0x1825D9700
	internal static void ProcessOnColorChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) { }

	// RVA: 0x25D98A0 Offset: 0x25D8AA0 VA: 0x1825D98A0
	internal static void ProcessOnTransformOrSizeChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) { }

	// RVA: 0x25D9980 Offset: 0x25D8B80 VA: 0x1825D9980
	internal static void ProcessOnVisualsChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) { }

	// RVA: 0x25D8720 Offset: 0x25D7920 VA: 0x1825D8720
	private static Matrix4x4 GetTransformIDTransformInfo(VisualElement ve) { }

	// RVA: 0x25D8430 Offset: 0x25D7630 VA: 0x1825D8430
	private static Vector4 GetClipRectIDClipInfo(VisualElement ve) { }

	// RVA: 0x25D57B0 Offset: 0x25D49B0 VA: 0x1825D57B0
	internal static uint DepthFirstOnChildAdded(RenderChain renderChain, VisualElement parent, VisualElement ve, int index, bool resetState) { }

	// RVA: 0x25D5F90 Offset: 0x25D5190 VA: 0x1825D5F90
	internal static uint DepthFirstOnChildRemoving(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x25D6D10 Offset: 0x25D5F10 VA: 0x1825D6D10
	private static void DepthFirstOnClippingChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, uint dirtyID, bool hierarchical, bool isRootOfChange, bool isPendingHierarchicalRepaint, bool inheritedClipRectIDChanged, bool inheritedMaskingChanged, UIRenderDevice device, ref ChainBuilderStats stats) { }

	// RVA: 0x25D7390 Offset: 0x25D6590 VA: 0x1825D7390
	private static void DepthFirstOnOpacityChanged(RenderChain renderChain, float parentCompositeOpacity, VisualElement ve, uint dirtyID, bool hierarchical, ref ChainBuilderStats stats, bool isDoingFullVertexRegeneration = False) { }

	// RVA: 0x25D9360 Offset: 0x25D8560 VA: 0x1825D9360
	private static void OnColorChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) { }

	// RVA: 0x25D77F0 Offset: 0x25D69F0 VA: 0x1825D77F0
	private static void DepthFirstOnTransformOrSizeChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, uint dirtyID, UIRenderDevice device, bool isAncestorOfChangeSkinned, bool transformChanged, ref ChainBuilderStats stats) { }

	// RVA: 0x25D7D30 Offset: 0x25D6F30 VA: 0x1825D7D30
	private static void DepthFirstOnVisualsChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, bool parentHierarchyHidden, bool hierarchical, ref ChainBuilderStats stats) { }

	// RVA: 0x25DA420 Offset: 0x25D9620 VA: 0x1825DA420
	private static bool UpdateTextCoreSettings(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x25D91B0 Offset: 0x25D83B0 VA: 0x1825D91B0
	private static bool IsElementHierarchyHidden(VisualElement ve) { }

	// RVA: 0x25D86A0 Offset: 0x25D78A0 VA: 0x1825D86A0
	private static VisualElement GetLastDeepestChild(VisualElement ve) { }

	// RVA: 0x25D8320 Offset: 0x25D7520 VA: 0x1825D8320
	private static ClipMethod DetermineSelfClipMethod(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x25DA2C0 Offset: 0x25D94C0 VA: 0x1825DA2C0
	private static bool UpdateLocalFlipsWinding(VisualElement ve) { }

	// RVA: 0x25DA9F0 Offset: 0x25D9BF0 VA: 0x1825DA9F0
	private static void UpdateWorldFlipsWinding(VisualElement ve) { }

	// RVA: 0x25DAA60 Offset: 0x25D9C60 VA: 0x1825DAA60
	private static void UpdateZeroScaling(VisualElement ve) { }

	// RVA: 0x25D9320 Offset: 0x25D8520 VA: 0x1825D9320
	private static bool NeedsTransformID(VisualElement ve) { }

	// RVA: 0x25D9210 Offset: 0x25D8410 VA: 0x1825D9210
	internal static bool NeedsColorID(VisualElement ve) { }

	// RVA: 0x25D9230 Offset: 0x25D8430 VA: 0x1825D9230
	internal static bool NeedsTextCoreSettings(VisualElement ve) { }

	// RVA: 0x25D88F0 Offset: 0x25D7AF0 VA: 0x1825D88F0
	private static bool InitColorIDs(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x25D9AD0 Offset: 0x25D8CD0 VA: 0x1825D9AD0
	private static void SetColorValues(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x25DAC70 Offset: 0x25D9E70 VA: 0x1825DAC70
	private static void .cctor() { }
}

// Namespace: 
internal struct UIRStylePainter.Entry // TypeDefIndex: 11786
{
	// Fields
	public NativeSlice<Vertex> vertices; // 0x0
	public NativeSlice<ushort> indices; // 0x10
	public Material material; // 0x20
	public float fontTexSDFScale; // 0x28
	public TextureId texture; // 0x2C
	public RenderChainCommand customCommand; // 0x30
	public BMPAlloc clipRectID; // 0x38
	public VertexFlags addFlags; // 0x40
	public bool uvIsDisplacement; // 0x44
	public bool isTextEntry; // 0x45
	public bool isClipRegisterEntry; // 0x46
	public int stencilRef; // 0x48
	public int maskDepth; // 0x4C
}

// Namespace: 
internal struct UIRStylePainter.ClosingInfo // TypeDefIndex: 11787
{
	// Fields
	public bool needsClosing; // 0x0
	public bool popViewMatrix; // 0x1
	public bool popScissorClip; // 0x2
	public bool blitAndPopRenderTexture; // 0x3
	public bool PopDefaultMaterial; // 0x4
	public RenderChainCommand clipUnregisterDrawCommand; // 0x8
	public NativeSlice<Vertex> clipperRegisterVertices; // 0x10
	public NativeSlice<ushort> clipperRegisterIndices; // 0x20
	public int clipperRegisterIndexOffset; // 0x30
	public int maskStencilRef; // 0x34
}

// Namespace: 
private struct UIRStylePainter.RepeatRectUV // TypeDefIndex: 11788
{
	// Fields
	public Rect rect; // 0x0
	public Rect uv; // 0x10
}

// Namespace: UnityEngine.UIElements.UIR.Implementation
internal class UIRStylePainter : IStylePainter // TypeDefIndex: 11789
{
	// Fields
	private RenderChain m_Owner; // 0x10
	private List<UIRStylePainter.Entry> m_Entries; // 0x18
	private AtlasBase m_Atlas; // 0x20
	private VectorImageManager m_VectorImageManager; // 0x28
	private UIRStylePainter.Entry m_CurrentEntry; // 0x30
	private UIRStylePainter.ClosingInfo m_ClosingInfo; // 0x80
	private int m_MaskDepth; // 0xB8
	private int m_StencilRef; // 0xBC
	private BMPAlloc m_ClipRectID; // 0xC0
	private int m_SVGBackgroundEntryIndex; // 0xC8
	private TempAllocator<Vertex> m_VertsPool; // 0xD0
	private TempAllocator<ushort> m_IndicesPool; // 0xD8
	private List<MeshWriteData> m_MeshWriteDataPool; // 0xE0
	private int m_NextMeshWriteDataPoolItem; // 0xE8
	private List<UIRStylePainter.RepeatRectUV>[] m_RepeatRectUVList; // 0xF0
	private MeshBuilder.AllocMeshData.Allocator m_AllocRawVertsIndicesDelegate; // 0xF8
	private MeshBuilder.AllocMeshData.Allocator m_AllocThroughDrawMeshDelegate; // 0x100
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly MeshGenerationContext <meshGenerationContext>k__BackingField; // 0x108
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VisualElement <currentElement>k__BackingField; // 0x110
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <totalVertices>k__BackingField; // 0x118
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <totalIndices>k__BackingField; // 0x11C
	private TextInfo m_TextInfo; // 0x120

	// Properties
	public MeshGenerationContext meshGenerationContext { get; }
	public VisualElement currentElement { get; set; }
	public List<UIRStylePainter.Entry> entries { get; }
	public UIRStylePainter.ClosingInfo closingInfo { get; }
	public int totalVertices { get; set; }
	public int totalIndices { get; set; }
	public VisualElement visualElement { get; }

	// Methods

	// RVA: 0x25E5F90 Offset: 0x25E5190 VA: 0x1825E5F90
	private MeshWriteData GetPooledMeshWriteData() { }

	// RVA: 0x25DD800 Offset: 0x25DCA00 VA: 0x1825DD800
	private MeshWriteData AllocRawVertsIndices(uint vertexCount, uint indexCount, ref MeshBuilder.AllocMeshData allocatorData) { }

	// RVA: 0x25DD8F0 Offset: 0x25DCAF0 VA: 0x1825DD8F0
	private MeshWriteData AllocThroughDrawMesh(uint vertexCount, uint indexCount, ref MeshBuilder.AllocMeshData allocatorData) { }

	// RVA: 0x25E7780 Offset: 0x25E6980 VA: 0x1825E7780
	public void .ctor(RenderChain renderChain) { }

	[CompilerGenerated]
	// RVA: 0x789810 Offset: 0x788A10 VA: 0x180789810
	public MeshGenerationContext get_meshGenerationContext() { }

	[CompilerGenerated]
	// RVA: 0x6ED520 Offset: 0x6EC720 VA: 0x1806ED520
	public VisualElement get_currentElement() { }

	[CompilerGenerated]
	// RVA: 0x6ED6D0 Offset: 0x6EC8D0 VA: 0x1806ED6D0
	private void set_currentElement(VisualElement value) { }

	// RVA: 0x248C210 Offset: 0x248B410 VA: 0x18248C210
	public List<UIRStylePainter.Entry> get_entries() { }

	// RVA: 0x25E7A60 Offset: 0x25E6C60 VA: 0x1825E7A60
	public UIRStylePainter.ClosingInfo get_closingInfo() { }

	[CompilerGenerated]
	// RVA: 0x25E7AB0 Offset: 0x25E6CB0 VA: 0x1825E7AB0
	public int get_totalVertices() { }

	[CompilerGenerated]
	// RVA: 0x25E7AE0 Offset: 0x25E6CE0 VA: 0x1825E7AE0
	private void set_totalVertices(int value) { }

	[CompilerGenerated]
	// RVA: 0x25E7AA0 Offset: 0x25E6CA0 VA: 0x1825E7AA0
	public int get_totalIndices() { }

	[CompilerGenerated]
	// RVA: 0x25E7AD0 Offset: 0x25E6CD0 VA: 0x1825E7AD0
	private void set_totalIndices(int value) { }

	// RVA: 0x25DDDE0 Offset: 0x25DCFE0 VA: 0x1825DDDE0
	public void Begin(VisualElement ve) { }

	// RVA: 0x25E6150 Offset: 0x25E5350 VA: 0x1825E6150
	public void LandClipUnregisterMeshDrawCommand(RenderChainCommand cmd) { }

	// RVA: 0x25E60B0 Offset: 0x25E52B0 VA: 0x1825E60B0
	public void LandClipRegisterMesh(NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, int indexOffset) { }

	// RVA: 0x25DEF40 Offset: 0x25DE140 VA: 0x1825DEF40 Slot: 7
	public MeshWriteData DrawMesh(int vertexCount, int indexCount, Texture texture, Material material, MeshGenerationContext.MeshFlags flags) { }

	// RVA: 0x25E71C0 Offset: 0x25E63C0 VA: 0x1825E71C0
	internal void TryAtlasTexture(Texture texture, MeshGenerationContext.MeshFlags flags, out Rect outUVRegion, out bool outIsAtlas, out TextureId outTextureId, out VertexFlags outAddFlags) { }

	// RVA: 0x25DE210 Offset: 0x25DD410 VA: 0x1825DE210
	internal void BuildEntryFromNativeMesh(MeshWriteDataInterface meshData, Texture texture, TextureId textureId, bool isAtlas, Material material, MeshGenerationContext.MeshFlags flags, Rect uvRegion, VertexFlags addFlags) { }

	// RVA: 0x25DE6A0 Offset: 0x25DD8A0 VA: 0x1825DE6A0
	internal void BuildGradientEntryFromNativeMesh(MeshWriteDataInterface meshData, TextureId svgTextureId) { }

	// RVA: 0x25DEAC0 Offset: 0x25DDCC0 VA: 0x1825DEAC0
	public void BuildRawEntryFromNativeMesh(MeshWriteDataInterface meshData) { }

	// RVA: 0x25E2FA0 Offset: 0x25E21A0 VA: 0x1825E2FA0 Slot: 4
	public void DrawText(TextElement te) { }

	// RVA: 0x25E2970 Offset: 0x25E1B70 VA: 0x1825E2970
	private void DrawTextInfo(TextInfo textInfo, Vector2 offset, bool useHints) { }

	// RVA: 0x25E19C0 Offset: 0x25E0BC0 VA: 0x1825E19C0 Slot: 5
	public void DrawRectangle(MeshGenerationContextUtils.RectangleParams rectParams) { }

	// RVA: 0x25DED40 Offset: 0x25DDF40 VA: 0x1825DED40 Slot: 8
	public void DrawBorder(MeshGenerationContextUtils.BorderParams borderParams) { }

	// RVA: 0x25DEE40 Offset: 0x25DE040 VA: 0x1825DEE40 Slot: 6
	public void DrawImmediate(Action callback, bool cullingEnabled) { }

	// RVA: 0x25E7AC0 Offset: 0x25E6CC0 VA: 0x1825E7AC0 Slot: 9
	public VisualElement get_visualElement() { }

	// RVA: 0x25E3620 Offset: 0x25E2820 VA: 0x1825E3620
	public void DrawVisualElementBackground() { }

	// RVA: 0x25DF410 Offset: 0x25DE610 VA: 0x1825DF410
	private void DrawRectangleRepeat(MeshGenerationContextUtils.RectangleParams rectParams, Rect totalRect, float scaledPixelsPerPoint) { }

	// RVA: 0x25E6E00 Offset: 0x25E6000 VA: 0x1825E6E00
	private void StampRectangleWithSubRect(MeshGenerationContextUtils.RectangleParams rectParams, Rect targetRect, Rect targetUV) { }

	// RVA: 0x25E4C30 Offset: 0x25E3E30 VA: 0x1825E4C30
	public void DrawVisualElementBorder() { }

	// RVA: 0x25DDBE0 Offset: 0x25DCDE0 VA: 0x1825DDBE0
	public void ApplyVisualElementClipping() { }

	// RVA: 0x25DD370 Offset: 0x25DC570 VA: 0x1825DD370
	private ushort[] AdjustSpriteWinding(Vector2[] vertices, ushort[] indices) { }

	// RVA: 0x25E21E0 Offset: 0x25E13E0 VA: 0x1825E21E0
	public void DrawSprite(MeshGenerationContextUtils.RectangleParams rectParams) { }

	// RVA: 0x25DD920 Offset: 0x25DCB20 VA: 0x1825DD920
	private void ApplyInset(ref MeshBuilderNative.NativeRectParams rectParams, Texture tex) { }

	// RVA: 0x25E3070 Offset: 0x25E2270 VA: 0x1825E3070
	public void DrawVectorImage(MeshGenerationContextUtils.RectangleParams rectParams) { }

	// RVA: 0x25E61C0 Offset: 0x25E53C0 VA: 0x1825E61C0
	private void MakeVectorGraphics(MeshGenerationContextUtils.RectangleParams rectParams, bool isUsingGradients, TextureId svgTexture, int settingIndexOffset, out int finalVertexCount, out int finalIndexCount) { }

	// RVA: 0x25E6D50 Offset: 0x25E5F50 VA: 0x1825E6D50
	internal void Reset() { }

	// RVA: 0x25E73E0 Offset: 0x25E65E0 VA: 0x1825E73E0
	private void ValidateMeshWriteData() { }

	// RVA: 0x25E5430 Offset: 0x25E4630 VA: 0x1825E5430
	private void GenerateStencilClipEntryForRoundedRectBackground() { }

	// RVA: 0x25E5C80 Offset: 0x25E4E80 VA: 0x1825E5C80
	private void GenerateStencilClipEntryForSVGBackground() { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal abstract class HierarchyTraversal // TypeDefIndex: 11790
{
	// Methods

	// RVA: 0x25EBB10 Offset: 0x25EAD10 VA: 0x1825EBB10 Slot: 4
	public virtual void Traverse(VisualElement element) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void TraverseRecursive(VisualElement element, int depth);

	// RVA: 0x25EBA40 Offset: 0x25EAC40 VA: 0x1825EBA40
	protected void Recurse(VisualElement element, int depth) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class InitialStyle // TypeDefIndex: 11791
{
	// Fields
	private static ComputedStyle s_InitialStyle; // 0x0

	// Properties
	public static Align alignContent { get; }
	public static Align alignItems { get; }
	public static Align alignSelf { get; }
	public static Color backgroundColor { get; }
	public static Background backgroundImage { get; }
	public static BackgroundPosition backgroundPositionX { get; }
	public static BackgroundPosition backgroundPositionY { get; }
	public static BackgroundRepeat backgroundRepeat { get; }
	public static BackgroundSize backgroundSize { get; }
	public static Color borderBottomColor { get; }
	public static Length borderBottomLeftRadius { get; }
	public static Length borderBottomRightRadius { get; }
	public static float borderBottomWidth { get; }
	public static Color borderLeftColor { get; }
	public static float borderLeftWidth { get; }
	public static Color borderRightColor { get; }
	public static float borderRightWidth { get; }
	public static Color borderTopColor { get; }
	public static Length borderTopLeftRadius { get; }
	public static Length borderTopRightRadius { get; }
	public static float borderTopWidth { get; }
	public static Length bottom { get; }
	public static Color color { get; }
	public static Cursor cursor { get; }
	public static DisplayStyle display { get; }
	public static Length flexBasis { get; }
	public static FlexDirection flexDirection { get; }
	public static float flexGrow { get; }
	public static float flexShrink { get; }
	public static Wrap flexWrap { get; }
	public static Length fontSize { get; }
	public static Length height { get; }
	public static Justify justifyContent { get; }
	public static Length left { get; }
	public static Length letterSpacing { get; }
	public static Length marginBottom { get; }
	public static Length marginLeft { get; }
	public static Length marginRight { get; }
	public static Length marginTop { get; }
	public static Length maxHeight { get; }
	public static Length maxWidth { get; }
	public static Length minHeight { get; }
	public static Length minWidth { get; }
	public static float opacity { get; }
	public static OverflowInternal overflow { get; }
	public static Length paddingBottom { get; }
	public static Length paddingLeft { get; }
	public static Length paddingRight { get; }
	public static Length paddingTop { get; }
	public static Position position { get; }
	public static Length right { get; }
	public static Rotate rotate { get; }
	public static Scale scale { get; }
	public static TextOverflow textOverflow { get; }
	public static TextShadow textShadow { get; }
	public static Length top { get; }
	public static TransformOrigin transformOrigin { get; }
	public static List<TimeValue> transitionDelay { get; }
	public static List<TimeValue> transitionDuration { get; }
	public static List<StylePropertyName> transitionProperty { get; }
	public static List<EasingFunction> transitionTimingFunction { get; }
	public static Translate translate { get; }
	public static Color unityBackgroundImageTintColor { get; }
	public static Font unityFont { get; }
	public static FontDefinition unityFontDefinition { get; }
	public static FontStyle unityFontStyleAndWeight { get; }
	public static OverflowClipBox unityOverflowClipBox { get; }
	public static Length unityParagraphSpacing { get; }
	public static int unitySliceBottom { get; }
	public static int unitySliceLeft { get; }
	public static int unitySliceRight { get; }
	public static float unitySliceScale { get; }
	public static int unitySliceTop { get; }
	public static TextAnchor unityTextAlign { get; }
	public static Color unityTextOutlineColor { get; }
	public static float unityTextOutlineWidth { get; }
	public static TextOverflowPosition unityTextOverflowPosition { get; }
	public static Visibility visibility { get; }
	public static WhiteSpace whiteSpace { get; }
	public static Length width { get; }
	public static Length wordSpacing { get; }

	// Methods

	// RVA: 0x25EBCE0 Offset: 0x25EAEE0 VA: 0x1825EBCE0
	public static ref ComputedStyle Get() { }

	// RVA: 0x25EBC20 Offset: 0x25EAE20 VA: 0x1825EBC20
	public static ComputedStyle Acquire() { }

	// RVA: 0x25EBD30 Offset: 0x25EAF30 VA: 0x1825EBD30
	private static void .cctor() { }

	// RVA: 0x25ECE00 Offset: 0x25EC000 VA: 0x1825ECE00
	public static Align get_alignContent() { }

	// RVA: 0x25ECE70 Offset: 0x25EC070 VA: 0x1825ECE70
	public static Align get_alignItems() { }

	// RVA: 0x25ECEE0 Offset: 0x25EC0E0 VA: 0x1825ECEE0
	public static Align get_alignSelf() { }

	// RVA: 0x25ECF50 Offset: 0x25EC150 VA: 0x1825ECF50
	public static Color get_backgroundColor() { }

	// RVA: 0x25ECFD0 Offset: 0x25EC1D0 VA: 0x1825ECFD0
	public static Background get_backgroundImage() { }

	// RVA: 0x25ED050 Offset: 0x25EC250 VA: 0x1825ED050
	public static BackgroundPosition get_backgroundPositionX() { }

	// RVA: 0x25ED0D0 Offset: 0x25EC2D0 VA: 0x1825ED0D0
	public static BackgroundPosition get_backgroundPositionY() { }

	// RVA: 0x25ED150 Offset: 0x25EC350 VA: 0x1825ED150
	public static BackgroundRepeat get_backgroundRepeat() { }

	// RVA: 0x25ED1C0 Offset: 0x25EC3C0 VA: 0x1825ED1C0
	public static BackgroundSize get_backgroundSize() { }

	// RVA: 0x25ED240 Offset: 0x25EC440 VA: 0x1825ED240
	public static Color get_borderBottomColor() { }

	// RVA: 0x25ED2C0 Offset: 0x25EC4C0 VA: 0x1825ED2C0
	public static Length get_borderBottomLeftRadius() { }

	// RVA: 0x25ED330 Offset: 0x25EC530 VA: 0x1825ED330
	public static Length get_borderBottomRightRadius() { }

	// RVA: 0x25ED3A0 Offset: 0x25EC5A0 VA: 0x1825ED3A0
	public static float get_borderBottomWidth() { }

	// RVA: 0x25ED410 Offset: 0x25EC610 VA: 0x1825ED410
	public static Color get_borderLeftColor() { }

	// RVA: 0x25ED490 Offset: 0x25EC690 VA: 0x1825ED490
	public static float get_borderLeftWidth() { }

	// RVA: 0x25ED500 Offset: 0x25EC700 VA: 0x1825ED500
	public static Color get_borderRightColor() { }

	// RVA: 0x25ED580 Offset: 0x25EC780 VA: 0x1825ED580
	public static float get_borderRightWidth() { }

	// RVA: 0x25ED5F0 Offset: 0x25EC7F0 VA: 0x1825ED5F0
	public static Color get_borderTopColor() { }

	// RVA: 0x25ED670 Offset: 0x25EC870 VA: 0x1825ED670
	public static Length get_borderTopLeftRadius() { }

	// RVA: 0x25ED6E0 Offset: 0x25EC8E0 VA: 0x1825ED6E0
	public static Length get_borderTopRightRadius() { }

	// RVA: 0x25ED750 Offset: 0x25EC950 VA: 0x1825ED750
	public static float get_borderTopWidth() { }

	// RVA: 0x25ED7C0 Offset: 0x25EC9C0 VA: 0x1825ED7C0
	public static Length get_bottom() { }

	// RVA: 0x25ED830 Offset: 0x25ECA30 VA: 0x1825ED830
	public static Color get_color() { }

	// RVA: 0x25ED8A0 Offset: 0x25ECAA0 VA: 0x1825ED8A0
	public static Cursor get_cursor() { }

	// RVA: 0x25ED920 Offset: 0x25ECB20 VA: 0x1825ED920
	public static DisplayStyle get_display() { }

	// RVA: 0x25ED990 Offset: 0x25ECB90 VA: 0x1825ED990
	public static Length get_flexBasis() { }

	// RVA: 0x25EDA00 Offset: 0x25ECC00 VA: 0x1825EDA00
	public static FlexDirection get_flexDirection() { }

	// RVA: 0x25EDA70 Offset: 0x25ECC70 VA: 0x1825EDA70
	public static float get_flexGrow() { }

	// RVA: 0x25EDAE0 Offset: 0x25ECCE0 VA: 0x1825EDAE0
	public static float get_flexShrink() { }

	// RVA: 0x25EDB50 Offset: 0x25ECD50 VA: 0x1825EDB50
	public static Wrap get_flexWrap() { }

	// RVA: 0x25EDBC0 Offset: 0x25ECDC0 VA: 0x1825EDBC0
	public static Length get_fontSize() { }

	// RVA: 0x25EDC30 Offset: 0x25ECE30 VA: 0x1825EDC30
	public static Length get_height() { }

	// RVA: 0x25EDCA0 Offset: 0x25ECEA0 VA: 0x1825EDCA0
	public static Justify get_justifyContent() { }

	// RVA: 0x25EDD10 Offset: 0x25ECF10 VA: 0x1825EDD10
	public static Length get_left() { }

	// RVA: 0x25EDD80 Offset: 0x25ECF80 VA: 0x1825EDD80
	public static Length get_letterSpacing() { }

	// RVA: 0x25EDDF0 Offset: 0x25ECFF0 VA: 0x1825EDDF0
	public static Length get_marginBottom() { }

	// RVA: 0x25EDE60 Offset: 0x25ED060 VA: 0x1825EDE60
	public static Length get_marginLeft() { }

	// RVA: 0x25EDED0 Offset: 0x25ED0D0 VA: 0x1825EDED0
	public static Length get_marginRight() { }

	// RVA: 0x25EDF40 Offset: 0x25ED140 VA: 0x1825EDF40
	public static Length get_marginTop() { }

	// RVA: 0x25EDFB0 Offset: 0x25ED1B0 VA: 0x1825EDFB0
	public static Length get_maxHeight() { }

	// RVA: 0x25EE020 Offset: 0x25ED220 VA: 0x1825EE020
	public static Length get_maxWidth() { }

	// RVA: 0x25EE090 Offset: 0x25ED290 VA: 0x1825EE090
	public static Length get_minHeight() { }

	// RVA: 0x25EE100 Offset: 0x25ED300 VA: 0x1825EE100
	public static Length get_minWidth() { }

	// RVA: 0x25EE170 Offset: 0x25ED370 VA: 0x1825EE170
	public static float get_opacity() { }

	// RVA: 0x25EE1E0 Offset: 0x25ED3E0 VA: 0x1825EE1E0
	public static OverflowInternal get_overflow() { }

	// RVA: 0x25EE250 Offset: 0x25ED450 VA: 0x1825EE250
	public static Length get_paddingBottom() { }

	// RVA: 0x25EE2C0 Offset: 0x25ED4C0 VA: 0x1825EE2C0
	public static Length get_paddingLeft() { }

	// RVA: 0x25EE330 Offset: 0x25ED530 VA: 0x1825EE330
	public static Length get_paddingRight() { }

	// RVA: 0x25EE3A0 Offset: 0x25ED5A0 VA: 0x1825EE3A0
	public static Length get_paddingTop() { }

	// RVA: 0x25EE410 Offset: 0x25ED610 VA: 0x1825EE410
	public static Position get_position() { }

	// RVA: 0x25EE480 Offset: 0x25ED680 VA: 0x1825EE480
	public static Length get_right() { }

	// RVA: 0x25EE4F0 Offset: 0x25ED6F0 VA: 0x1825EE4F0
	public static Rotate get_rotate() { }

	// RVA: 0x25EE570 Offset: 0x25ED770 VA: 0x1825EE570
	public static Scale get_scale() { }

	// RVA: 0x25EE5F0 Offset: 0x25ED7F0 VA: 0x1825EE5F0
	public static TextOverflow get_textOverflow() { }

	// RVA: 0x25EE660 Offset: 0x25ED860 VA: 0x1825EE660
	public static TextShadow get_textShadow() { }

	// RVA: 0x25EE6E0 Offset: 0x25ED8E0 VA: 0x1825EE6E0
	public static Length get_top() { }

	// RVA: 0x25EE750 Offset: 0x25ED950 VA: 0x1825EE750
	public static TransformOrigin get_transformOrigin() { }

	// RVA: 0x25EE7D0 Offset: 0x25ED9D0 VA: 0x1825EE7D0
	public static List<TimeValue> get_transitionDelay() { }

	// RVA: 0x25EE840 Offset: 0x25EDA40 VA: 0x1825EE840
	public static List<TimeValue> get_transitionDuration() { }

	// RVA: 0x25EE8B0 Offset: 0x25EDAB0 VA: 0x1825EE8B0
	public static List<StylePropertyName> get_transitionProperty() { }

	// RVA: 0x25EE920 Offset: 0x25EDB20 VA: 0x1825EE920
	public static List<EasingFunction> get_transitionTimingFunction() { }

	// RVA: 0x25EE990 Offset: 0x25EDB90 VA: 0x1825EE990
	public static Translate get_translate() { }

	// RVA: 0x25EEA10 Offset: 0x25EDC10 VA: 0x1825EEA10
	public static Color get_unityBackgroundImageTintColor() { }

	// RVA: 0x25EEB70 Offset: 0x25EDD70 VA: 0x1825EEB70
	public static Font get_unityFont() { }

	// RVA: 0x25EEA90 Offset: 0x25EDC90 VA: 0x1825EEA90
	public static FontDefinition get_unityFontDefinition() { }

	// RVA: 0x25EEB00 Offset: 0x25EDD00 VA: 0x1825EEB00
	public static FontStyle get_unityFontStyleAndWeight() { }

	// RVA: 0x25EEBE0 Offset: 0x25EDDE0 VA: 0x1825EEBE0
	public static OverflowClipBox get_unityOverflowClipBox() { }

	// RVA: 0x25EEC50 Offset: 0x25EDE50 VA: 0x1825EEC50
	public static Length get_unityParagraphSpacing() { }

	// RVA: 0x25EECC0 Offset: 0x25EDEC0 VA: 0x1825EECC0
	public static int get_unitySliceBottom() { }

	// RVA: 0x25EED30 Offset: 0x25EDF30 VA: 0x1825EED30
	public static int get_unitySliceLeft() { }

	// RVA: 0x25EEDA0 Offset: 0x25EDFA0 VA: 0x1825EEDA0
	public static int get_unitySliceRight() { }

	// RVA: 0x25EEE10 Offset: 0x25EE010 VA: 0x1825EEE10
	public static float get_unitySliceScale() { }

	// RVA: 0x25EEE80 Offset: 0x25EE080 VA: 0x1825EEE80
	public static int get_unitySliceTop() { }

	// RVA: 0x25EEEF0 Offset: 0x25EE0F0 VA: 0x1825EEEF0
	public static TextAnchor get_unityTextAlign() { }

	// RVA: 0x25EEF60 Offset: 0x25EE160 VA: 0x1825EEF60
	public static Color get_unityTextOutlineColor() { }

	// RVA: 0x25EEFD0 Offset: 0x25EE1D0 VA: 0x1825EEFD0
	public static float get_unityTextOutlineWidth() { }

	// RVA: 0x25EF040 Offset: 0x25EE240 VA: 0x1825EF040
	public static TextOverflowPosition get_unityTextOverflowPosition() { }

	// RVA: 0x25EF0B0 Offset: 0x25EE2B0 VA: 0x1825EF0B0
	public static Visibility get_visibility() { }

	// RVA: 0x25EF120 Offset: 0x25EE320 VA: 0x1825EF120
	public static WhiteSpace get_whiteSpace() { }

	// RVA: 0x25EF190 Offset: 0x25EE390 VA: 0x1825EF190
	public static Length get_width() { }

	// RVA: 0x25EF200 Offset: 0x25EE400 VA: 0x1825EF200
	public static Length get_wordSpacing() { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class ShorthandApplicator // TypeDefIndex: 11792
{
	// Fields
	private static List<TimeValue> s_TransitionDelayList; // 0x0
	private static List<TimeValue> s_TransitionDurationList; // 0x8
	private static List<StylePropertyName> s_TransitionPropertyList; // 0x10
	private static List<EasingFunction> s_TransitionTimingFunctionList; // 0x18

	// Methods

	// RVA: 0x25EF420 Offset: 0x25EE620 VA: 0x1825EF420
	public static void ApplyBackgroundPosition(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x25EF4F0 Offset: 0x25EE6F0 VA: 0x1825EF4F0
	public static void ApplyBorderColor(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x25EF720 Offset: 0x25EE920 VA: 0x1825EF720
	public static void ApplyBorderRadius(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x25EF900 Offset: 0x25EEB00 VA: 0x1825EF900
	public static void ApplyBorderWidth(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x25EFB40 Offset: 0x25EED40 VA: 0x1825EFB40
	public static void ApplyFlex(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x25EFC20 Offset: 0x25EEE20 VA: 0x1825EFC20
	public static void ApplyMargin(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x25EFE10 Offset: 0x25EF010 VA: 0x1825EFE10
	public static void ApplyPadding(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x25F0000 Offset: 0x25EF200 VA: 0x1825F0000
	public static void ApplyTransition(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x25F0150 Offset: 0x25EF350 VA: 0x1825F0150
	public static void ApplyUnityBackgroundScaleMode(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x25F02C0 Offset: 0x25EF4C0 VA: 0x1825F02C0
	public static void ApplyUnityTextOutline(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x25F1260 Offset: 0x25F0460 VA: 0x1825F1260
	private static bool CompileFlexShorthand(StylePropertyReader reader, out float grow, out float shrink, out Length basis) { }

	// RVA: 0x25F0C20 Offset: 0x25EFE20 VA: 0x1825F0C20
	private static void CompileBorderRadius(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left) { }

	// RVA: 0x25F0440 Offset: 0x25EF640 VA: 0x1825F0440
	private static void CompileBackgroundPosition(StylePropertyReader reader, out BackgroundPosition backgroundPositionX, out BackgroundPosition backgroundPositionY) { }

	// RVA: 0x25F2070 Offset: 0x25F1270 VA: 0x1825F2070
	public static void CompileUnityBackgroundScaleMode(StylePropertyReader reader, out BackgroundPosition backgroundPositionX, out BackgroundPosition backgroundPositionY, out BackgroundRepeat backgroundRepeat, out BackgroundSize backgroundSize) { }

	// RVA: 0x25F10F0 Offset: 0x25F02F0 VA: 0x1825F10F0
	private static void CompileBoxArea(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left) { }

	// RVA: 0x25F0F10 Offset: 0x25F0110 VA: 0x1825F0F10
	private static void CompileBoxArea(StylePropertyReader reader, out float top, out float right, out float bottom, out float left) { }

	// RVA: 0x25F0D60 Offset: 0x25EFF60 VA: 0x1825F0D60
	private static void CompileBoxArea(StylePropertyReader reader, out Color top, out Color right, out Color bottom, out Color left) { }

	// RVA: 0x25F14B0 Offset: 0x25F06B0 VA: 0x1825F14B0
	private static void CompileTextOutline(StylePropertyReader reader, out Color outlineColor, out float outlineWidth) { }

	// RVA: 0x25F15C0 Offset: 0x25F07C0 VA: 0x1825F15C0
	private static void CompileTransition(StylePropertyReader reader, out List<TimeValue> outDelay, out List<TimeValue> outDuration, out List<StylePropertyName> outProperty, out List<EasingFunction> outTimingFunction) { }

	// RVA: 0x25F2140 Offset: 0x25F1340 VA: 0x1825F2140
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x25F2130 Offset: 0x25F1330 VA: 0x1825F2130
	internal static void <CompileBackgroundPosition>g__SwapKeyword|16_0(ref BackgroundPositionKeyword a, ref BackgroundPositionKeyword b) { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StylePropertyCache // TypeDefIndex: 11793
{
	// Fields
	internal static readonly Dictionary<string, string> s_PropertySyntaxCache; // 0x0
	internal static readonly Dictionary<string, string> s_NonTerminalValues; // 0x8

	// Methods

	// RVA: 0x25F2300 Offset: 0x25F1500 VA: 0x1825F2300
	public static bool TryGetSyntax(string name, out string syntax) { }

	// RVA: 0x25F2270 Offset: 0x25F1470 VA: 0x1825F2270
	public static bool TryGetNonTerminalValue(string name, out string syntax) { }

	// RVA: 0x25F2390 Offset: 0x25F1590 VA: 0x1825F2390
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal enum StyleEnumType // TypeDefIndex: 11794
{
	// Fields
	public int value__; // 0x0
	public const StyleEnumType Align = 0;
	public const StyleEnumType BackgroundPositionKeyword = 1;
	public const StyleEnumType BackgroundSizeType = 2;
	public const StyleEnumType DisplayStyle = 3;
	public const StyleEnumType EasingMode = 4;
	public const StyleEnumType FlexDirection = 5;
	public const StyleEnumType FontStyle = 6;
	public const StyleEnumType Justify = 7;
	public const StyleEnumType Overflow = 8;
	public const StyleEnumType OverflowClipBox = 9;
	public const StyleEnumType OverflowInternal = 10;
	public const StyleEnumType Position = 11;
	public const StyleEnumType Repeat = 12;
	public const StyleEnumType RepeatXY = 13;
	public const StyleEnumType ScaleMode = 14;
	public const StyleEnumType TextAnchor = 15;
	public const StyleEnumType TextOverflow = 16;
	public const StyleEnumType TextOverflowPosition = 17;
	public const StyleEnumType TransformOriginOffset = 18;
	public const StyleEnumType Visibility = 19;
	public const StyleEnumType WhiteSpace = 20;
	public const StyleEnumType Wrap = 21;
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal enum StylePropertyId // TypeDefIndex: 11795
{
	// Fields
	public int value__; // 0x0
	public const StylePropertyId Unknown = 0;
	public const StylePropertyId Custom = -1;
	public const StylePropertyId AlignContent = 131072;
	public const StylePropertyId AlignItems = 131073;
	public const StylePropertyId AlignSelf = 131074;
	public const StylePropertyId All = 262144;
	public const StylePropertyId BackgroundColor = 458752;
	public const StylePropertyId BackgroundImage = 458753;
	public const StylePropertyId BackgroundPosition = 262145;
	public const StylePropertyId BackgroundPositionX = 458754;
	public const StylePropertyId BackgroundPositionY = 458755;
	public const StylePropertyId BackgroundRepeat = 458756;
	public const StylePropertyId BackgroundSize = 458757;
	public const StylePropertyId BorderBottomColor = 458758;
	public const StylePropertyId BorderBottomLeftRadius = 458759;
	public const StylePropertyId BorderBottomRightRadius = 458760;
	public const StylePropertyId BorderBottomWidth = 131075;
	public const StylePropertyId BorderColor = 262146;
	public const StylePropertyId BorderLeftColor = 458761;
	public const StylePropertyId BorderLeftWidth = 131076;
	public const StylePropertyId BorderRadius = 262147;
	public const StylePropertyId BorderRightColor = 458762;
	public const StylePropertyId BorderRightWidth = 131077;
	public const StylePropertyId BorderTopColor = 458763;
	public const StylePropertyId BorderTopLeftRadius = 458764;
	public const StylePropertyId BorderTopRightRadius = 458765;
	public const StylePropertyId BorderTopWidth = 131078;
	public const StylePropertyId BorderWidth = 262148;
	public const StylePropertyId Bottom = 131079;
	public const StylePropertyId Color = 65536;
	public const StylePropertyId Cursor = 196608;
	public const StylePropertyId Display = 131080;
	public const StylePropertyId Flex = 262149;
	public const StylePropertyId FlexBasis = 131081;
	public const StylePropertyId FlexDirection = 131082;
	public const StylePropertyId FlexGrow = 131083;
	public const StylePropertyId FlexShrink = 131084;
	public const StylePropertyId FlexWrap = 131085;
	public const StylePropertyId FontSize = 65537;
	public const StylePropertyId Height = 131086;
	public const StylePropertyId JustifyContent = 131087;
	public const StylePropertyId Left = 131088;
	public const StylePropertyId LetterSpacing = 65538;
	public const StylePropertyId Margin = 262150;
	public const StylePropertyId MarginBottom = 131089;
	public const StylePropertyId MarginLeft = 131090;
	public const StylePropertyId MarginRight = 131091;
	public const StylePropertyId MarginTop = 131092;
	public const StylePropertyId MaxHeight = 131093;
	public const StylePropertyId MaxWidth = 131094;
	public const StylePropertyId MinHeight = 131095;
	public const StylePropertyId MinWidth = 131096;
	public const StylePropertyId Opacity = 458766;
	public const StylePropertyId Overflow = 458767;
	public const StylePropertyId Padding = 262151;
	public const StylePropertyId PaddingBottom = 131097;
	public const StylePropertyId PaddingLeft = 131098;
	public const StylePropertyId PaddingRight = 131099;
	public const StylePropertyId PaddingTop = 131100;
	public const StylePropertyId Position = 131101;
	public const StylePropertyId Right = 131102;
	public const StylePropertyId Rotate = 327680;
	public const StylePropertyId Scale = 327681;
	public const StylePropertyId TextOverflow = 196609;
	public const StylePropertyId TextShadow = 65539;
	public const StylePropertyId Top = 131103;
	public const StylePropertyId TransformOrigin = 327682;
	public const StylePropertyId Transition = 262152;
	public const StylePropertyId TransitionDelay = 393216;
	public const StylePropertyId TransitionDuration = 393217;
	public const StylePropertyId TransitionProperty = 393218;
	public const StylePropertyId TransitionTimingFunction = 393219;
	public const StylePropertyId Translate = 327683;
	public const StylePropertyId UnityBackgroundImageTintColor = 196610;
	public const StylePropertyId UnityBackgroundScaleMode = 262153;
	public const StylePropertyId UnityFont = 65540;
	public const StylePropertyId UnityFontDefinition = 65541;
	public const StylePropertyId UnityFontStyleAndWeight = 65542;
	public const StylePropertyId UnityOverflowClipBox = 196611;
	public const StylePropertyId UnityParagraphSpacing = 65543;
	public const StylePropertyId UnitySliceBottom = 196612;
	public const StylePropertyId UnitySliceLeft = 196613;
	public const StylePropertyId UnitySliceRight = 196614;
	public const StylePropertyId UnitySliceScale = 196615;
	public const StylePropertyId UnitySliceTop = 196616;
	public const StylePropertyId UnityTextAlign = 65544;
	public const StylePropertyId UnityTextOutline = 262154;
	public const StylePropertyId UnityTextOutlineColor = 65545;
	public const StylePropertyId UnityTextOutlineWidth = 65546;
	public const StylePropertyId UnityTextOverflowPosition = 196617;
	public const StylePropertyId Visibility = 65547;
	public const StylePropertyId WhiteSpace = 65548;
	public const StylePropertyId Width = 131104;
	public const StylePropertyId WordSpacing = 65549;
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StylePropertyUtil // TypeDefIndex: 11796
{
	// Fields
	internal static readonly Dictionary<string, StylePropertyId> s_NameToId; // 0x0
	internal static readonly Dictionary<StylePropertyId, string> s_IdToName; // 0x8
	internal static readonly HashSet<StylePropertyId> s_AnimatableProperties; // 0x10
	internal static readonly Dictionary<StylePropertyId, UsageHints> s_AnimatableWithUsageHintProperties; // 0x18

	// Methods

	// RVA: 0x25F8310 Offset: 0x25F7510 VA: 0x1825F8310
	public static bool TryGetEnumIntValue(StyleEnumType enumType, string value, out int intValue) { }

	// RVA: 0x25F81B0 Offset: 0x25F73B0 VA: 0x1825F81B0
	public static bool IsMatchingShorthand(StylePropertyId shorthand, StylePropertyId id) { }

	// RVA: 0x25F8130 Offset: 0x25F7330 VA: 0x1825F8130
	public static bool IsAnimatable(StylePropertyId id) { }

	// RVA: 0x25F9310 Offset: 0x25F8510 VA: 0x1825F9310
	private static void .cctor() { }
}

// Namespace: 
public enum Dimension.Unit // TypeDefIndex: 11797
{
	// Fields
	public int value__; // 0x0
	public const Dimension.Unit Unitless = 0;
	public const Dimension.Unit Pixel = 1;
	public const Dimension.Unit Percent = 2;
	public const Dimension.Unit Second = 3;
	public const Dimension.Unit Millisecond = 4;
	public const Dimension.Unit Degree = 5;
	public const Dimension.Unit Gradian = 6;
	public const Dimension.Unit Radian = 7;
	public const Dimension.Unit Turn = 8;
}

// Namespace: UnityEngine.UIElements.StyleSheets
[Serializable]
internal struct Dimension : IEquatable<Dimension> // TypeDefIndex: 11798
{
	// Fields
	public Dimension.Unit unit; // 0x0
	public float value; // 0x4

	// Methods

	// RVA: 0x25EB8E0 Offset: 0x25EAAE0 VA: 0x1825EB8E0
	public void .ctor(float value, Dimension.Unit unit) { }

	// RVA: 0x25EB6E0 Offset: 0x25EA8E0 VA: 0x1825EB6E0
	public Length ToLength() { }

	// RVA: 0x25EB8B0 Offset: 0x25EAAB0 VA: 0x1825EB8B0
	public TimeValue ToTime() { }

	// RVA: 0x25EB650 Offset: 0x25EA850 VA: 0x1825EB650
	public Angle ToAngle() { }

	// RVA: 0x25EB8F0 Offset: 0x25EAAF0 VA: 0x1825EB8F0
	public static bool op_Equality(Dimension lhs, Dimension rhs) { }

	// RVA: 0x25EB5E0 Offset: 0x25EA7E0 VA: 0x1825EB5E0 Slot: 4
	public bool Equals(Dimension other) { }

	// RVA: 0x25EB520 Offset: 0x25EA720 VA: 0x1825EB520 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x25EB610 Offset: 0x25EA810 VA: 0x1825EB610 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x25EB710 Offset: 0x25EA910 VA: 0x1825EB710 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
[Serializable]
internal struct ScalableImage // TypeDefIndex: 11799
{
	// Fields
	public Texture2D normalImage; // 0x0
	public Texture2D highResolutionImage; // 0x8

	// Methods

	// RVA: 0x25EF270 Offset: 0x25EE470 VA: 0x1825EF270 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal struct StylePropertyValue // TypeDefIndex: 11800
{
	// Fields
	public StyleSheet sheet; // 0x0
	public StyleValueHandle handle; // 0x8
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal struct ImageSource // TypeDefIndex: 11801
{
	// Fields
	public Texture2D texture; // 0x0
	public Sprite sprite; // 0x8
	public VectorImage vectorImage; // 0x10
	public RenderTexture renderTexture; // 0x18

	// Methods

	// RVA: 0x25EBB30 Offset: 0x25EAD30 VA: 0x1825EBB30
	public bool IsNull() { }
}

// Namespace: 
internal sealed class StylePropertyReader.GetCursorIdFunction : MulticastDelegate // TypeDefIndex: 11802
{
	// Methods

	// RVA: 0x25EB920 Offset: 0x25EAB20 VA: 0x1825EB920
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual int Invoke(StyleSheet sheet, StyleValueHandle handle) { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal class StylePropertyReader // TypeDefIndex: 11803
{
	// Fields
	internal static StylePropertyReader.GetCursorIdFunction getCursorIdFunc; // 0x0
	private List<StylePropertyValue> m_Values; // 0x10
	private List<int> m_ValueCount; // 0x18
	private StyleVariableResolver m_Resolver; // 0x20
	private StyleSheet m_Sheet; // 0x28
	private StyleProperty[] m_Properties; // 0x30
	private StylePropertyId[] m_PropertyIds; // 0x38
	private int m_CurrentValueIndex; // 0x40
	private int m_CurrentPropertyIndex; // 0x44
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private StyleProperty <property>k__BackingField; // 0x48
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private StylePropertyId <propertyId>k__BackingField; // 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <valueCount>k__BackingField; // 0x54
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private float <dpiScaling>k__BackingField; // 0x58

	// Properties
	public StyleProperty property { get; set; }
	public StylePropertyId propertyId { get; set; }
	public int valueCount { get; set; }
	public float dpiScaling { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public StyleProperty get_property() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	private void set_property(StyleProperty value) { }

	[CompilerGenerated]
	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410
	public StylePropertyId get_propertyId() { }

	[CompilerGenerated]
	// RVA: 0x430630 Offset: 0x42F830 VA: 0x180430630
	private void set_propertyId(StylePropertyId value) { }

	[CompilerGenerated]
	// RVA: 0x4D1A40 Offset: 0x4D0C40 VA: 0x1804D1A40
	public int get_valueCount() { }

	[CompilerGenerated]
	// RVA: 0x4D1A80 Offset: 0x4D0C80 VA: 0x1804D1A80
	private void set_valueCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x1529A10 Offset: 0x1528C10 VA: 0x181529A10
	public float get_dpiScaling() { }

	[CompilerGenerated]
	// RVA: 0x2507590 Offset: 0x2506790 VA: 0x182507590
	private void set_dpiScaling(float value) { }

	// RVA: 0x25F7740 Offset: 0x25F6940 VA: 0x1825F7740
	public void SetContext(StyleSheet sheet, StyleComplexSelector selector, StyleVariableContext varContext, float dpiScaling = 1) { }

	// RVA: 0x25F78B0 Offset: 0x25F6AB0 VA: 0x1825F78B0
	public void SetInlineContext(StyleSheet sheet, StyleProperty[] properties, StylePropertyId[] propertyIds, float dpiScaling = 1) { }

	// RVA: 0x25F3D40 Offset: 0x25F2F40 VA: 0x1825F3D40
	public StylePropertyId MoveNextProperty() { }

	// RVA: 0x25F36D0 Offset: 0x25F28D0 VA: 0x1825F36D0
	public StylePropertyValue GetValue(int index) { }

	// RVA: 0x25F3650 Offset: 0x25F2850 VA: 0x1825F3650
	public StyleValueType GetValueType(int index) { }

	// RVA: 0x25F37F0 Offset: 0x25F29F0 VA: 0x1825F37F0
	public bool IsValueType(int index, StyleValueType type) { }

	// RVA: 0x25F3750 Offset: 0x25F2950 VA: 0x1825F3750
	public bool IsKeyword(int index, StyleValueKeyword keyword) { }

	// RVA: 0x25F3E70 Offset: 0x25F3070 VA: 0x1825F3E70
	public string ReadAsString(int index) { }

	// RVA: 0x25F5B50 Offset: 0x25F4D50 VA: 0x1825F5B50
	public Length ReadLength(int index) { }

	// RVA: 0x25F6D10 Offset: 0x25F5F10 VA: 0x1825F6D10
	public TimeValue ReadTimeValue(int index) { }

	// RVA: 0x25F7310 Offset: 0x25F6510 VA: 0x1825F7310
	public Translate ReadTranslate(int index) { }

	// RVA: 0x25F6F10 Offset: 0x25F6110 VA: 0x1825F6F10
	public TransformOrigin ReadTransformOrigin(int index) { }

	// RVA: 0x25F6370 Offset: 0x25F5570 VA: 0x1825F6370
	public Rotate ReadRotate(int index) { }

	// RVA: 0x25F6810 Offset: 0x25F5A10 VA: 0x1825F6810
	public Scale ReadScale(int index) { }

	// RVA: 0x25F5240 Offset: 0x25F4440 VA: 0x1825F5240
	public float ReadFloat(int index) { }

	// RVA: 0x25F5AD0 Offset: 0x25F4CD0 VA: 0x1825F5AD0
	public int ReadInt(int index) { }

	// RVA: 0x25F4BB0 Offset: 0x25F3DB0 VA: 0x1825F4BB0
	public Color ReadColor(int index) { }

	// RVA: 0x25F5140 Offset: 0x25F4340 VA: 0x1825F5140
	public int ReadEnum(StyleEnumType enumType, int index) { }

	// RVA: 0x25F52C0 Offset: 0x25F44C0 VA: 0x1825F52C0
	public FontDefinition ReadFontDefinition(int index) { }

	// RVA: 0x25F57D0 Offset: 0x25F49D0 VA: 0x1825F57D0
	public Font ReadFont(int index) { }

	// RVA: 0x25F4940 Offset: 0x25F3B40 VA: 0x1825F4940
	public Background ReadBackground(int index) { }

	// RVA: 0x25F4CD0 Offset: 0x25F3ED0 VA: 0x1825F4CD0
	public Cursor ReadCursor(int index) { }

	// RVA: 0x25F6960 Offset: 0x25F5B60 VA: 0x1825F6960
	public TextShadow ReadTextShadow(int index) { }

	// RVA: 0x25F3EE0 Offset: 0x25F30E0 VA: 0x1825F3EE0
	public BackgroundPosition ReadBackgroundPositionX(int index) { }

	// RVA: 0x25F3F20 Offset: 0x25F3120 VA: 0x1825F3F20
	public BackgroundPosition ReadBackgroundPositionY(int index) { }

	// RVA: 0x25F3F60 Offset: 0x25F3160 VA: 0x1825F3F60
	private BackgroundPosition ReadBackgroundPosition(int index, BackgroundPositionKeyword keyword) { }

	// RVA: 0x25F4270 Offset: 0x25F3470 VA: 0x1825F4270
	public BackgroundRepeat ReadBackgroundRepeat(int index) { }

	// RVA: 0x25F4600 Offset: 0x25F3800 VA: 0x1825F4600
	public BackgroundSize ReadBackgroundSize(int index) { }

	// RVA: 0x25F5C50 Offset: 0x25F4E50 VA: 0x1825F5C50
	public void ReadListEasingFunction(List<EasingFunction> list, int index) { }

	// RVA: 0x25F6020 Offset: 0x25F5220 VA: 0x1825F6020
	public void ReadListTimeValue(List<TimeValue> list, int index) { }

	// RVA: 0x25F5E50 Offset: 0x25F5050 VA: 0x1825F5E50
	public void ReadListStylePropertyName(List<StylePropertyName> list, int index) { }

	// RVA: 0x25F3880 Offset: 0x25F2A80 VA: 0x1825F3880
	private void LoadProperties() { }

	// RVA: 0x25F7800 Offset: 0x25F6A00 VA: 0x1825F7800
	private void SetCurrentProperty() { }

	// RVA: 0x25F7070 Offset: 0x25F6270 VA: 0x1825F7070
	public static TransformOrigin ReadTransformOrigin(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue zVvalue) { }

	// RVA: 0x25F6DC0 Offset: 0x25F5FC0 VA: 0x1825F6DC0
	private static Length ReadTransformOriginEnum(StylePropertyValue value, out bool isVertical, out bool isHorizontal) { }

	// RVA: 0x25F7470 Offset: 0x25F6670 VA: 0x1825F7470
	public static Translate ReadTranslate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3) { }

	// RVA: 0x25F6600 Offset: 0x25F5800 VA: 0x1825F6600
	public static Scale ReadScale(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3) { }

	// RVA: 0x25F61D0 Offset: 0x25F53D0 VA: 0x1825F61D0
	public static Rotate ReadRotate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3, StylePropertyValue val4) { }

	// RVA: 0x25F7F90 Offset: 0x25F7190 VA: 0x1825F7F90
	private static bool TryReadEnum(StyleEnumType enumType, StylePropertyValue value, out int intValue) { }

	// RVA: 0x25F5070 Offset: 0x25F4270 VA: 0x1825F5070
	private static int ReadEnum(StyleEnumType enumType, StylePropertyValue value) { }

	// RVA: 0x25F3D70 Offset: 0x25F2F70 VA: 0x1825F3D70
	public static Angle ReadAngle(StylePropertyValue value) { }

	// RVA: 0x25F4070 Offset: 0x25F3270 VA: 0x1825F4070
	public static BackgroundPosition ReadBackgroundPosition(int valCount, StylePropertyValue val1, StylePropertyValue val2, BackgroundPositionKeyword keyword) { }

	// RVA: 0x25F4460 Offset: 0x25F3660 VA: 0x1825F4460
	public static BackgroundRepeat ReadBackgroundRepeat(int valCount, StylePropertyValue val1, StylePropertyValue val2) { }

	// RVA: 0x25F46F0 Offset: 0x25F38F0 VA: 0x1825F46F0
	public static BackgroundSize ReadBackgroundSize(int valCount, StylePropertyValue val1, StylePropertyValue val2) { }

	// RVA: 0x25F78D0 Offset: 0x25F6AD0 VA: 0x1825F78D0
	internal static bool TryGetImageSourceFromValue(StylePropertyValue propertyValue, float dpiScaling, out ImageSource source) { }

	// RVA: 0x25F8060 Offset: 0x25F7260 VA: 0x1825F8060
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal struct MatchResultInfo // TypeDefIndex: 11804
{
	// Fields
	public readonly bool success; // 0x0
	public readonly PseudoStates triggerPseudoMask; // 0x4
	public readonly PseudoStates dependencyPseudoMask; // 0x8

	// Methods

	// RVA: 0x2600E30 Offset: 0x2600030 VA: 0x182600E30
	public void .ctor(bool success, PseudoStates triggerPseudoMask, PseudoStates dependencyPseudoMask) { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal struct SelectorMatchRecord // TypeDefIndex: 11805
{
	// Fields
	public StyleSheet sheet; // 0x0
	public int styleSheetIndexInStack; // 0x8
	public StyleComplexSelector complexSelector; // 0x10

	// Methods

	// RVA: 0x2609B30 Offset: 0x2608D30 VA: 0x182609B30
	public void .ctor(StyleSheet sheet, int styleSheetIndexInStack) { }

	// RVA: 0x26099E0 Offset: 0x2608BE0 VA: 0x1826099E0
	public static int Compare(SelectorMatchRecord a, SelectorMatchRecord b) { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StyleSelectorHelper // TypeDefIndex: 11806
{
	// Methods

	// RVA: 0x260B5A0 Offset: 0x260A7A0 VA: 0x18260B5A0
	public static MatchResultInfo MatchesSelector(VisualElement element, StyleSelector selector) { }

	// RVA: 0x260B390 Offset: 0x260A590 VA: 0x18260B390
	public static bool MatchRightToLeft(VisualElement element, StyleComplexSelector complexSelector, Action<VisualElement, MatchResultInfo> processResult) { }

	// RVA: 0x260AAC0 Offset: 0x2609CC0 VA: 0x18260AAC0
	private static void FastLookup(IDictionary<string, StyleComplexSelector> table, List<SelectorMatchRecord> matchedSelectors, StyleMatchingContext context, string input, ref SelectorMatchRecord record) { }

	// RVA: 0x260AED0 Offset: 0x260A0D0 VA: 0x18260AED0
	public static void FindMatches(StyleMatchingContext context, List<SelectorMatchRecord> matchedSelectors, int parentSheetIndex) { }
}

// Namespace: 
private struct StyleSheetCache.SheetHandleKey // TypeDefIndex: 11807
{
	// Fields
	public readonly int sheetInstanceID; // 0x0
	public readonly int index; // 0x4

	// Methods

	// RVA: 0x2609BA0 Offset: 0x2608DA0 VA: 0x182609BA0
	public void .ctor(StyleSheet sheet, int index) { }
}

// Namespace: 
private class StyleSheetCache.SheetHandleKeyComparer : IEqualityComparer<StyleSheetCache.SheetHandleKey> // TypeDefIndex: 11808
{
	// Methods

	// RVA: 0x2609B50 Offset: 0x2608D50 VA: 0x182609B50 Slot: 4
	public bool Equals(StyleSheetCache.SheetHandleKey x, StyleSheetCache.SheetHandleKey y) { }

	// RVA: 0x2609B70 Offset: 0x2608D70 VA: 0x182609B70 Slot: 5
	public int GetHashCode(StyleSheetCache.SheetHandleKey key) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StyleSheetCache // TypeDefIndex: 11809
{
	// Fields
	private static StyleSheetCache.SheetHandleKeyComparer s_Comparer; // 0x0
	private static Dictionary<StyleSheetCache.SheetHandleKey, StylePropertyId[]> s_RulePropertyIdsCache; // 0x8

	// Methods

	// RVA: 0x260B970 Offset: 0x260AB70 VA: 0x18260B970
	internal static StylePropertyId[] GetPropertyIds(StyleSheet sheet, int ruleIndex) { }

	// RVA: 0x260BB50 Offset: 0x260AD50 VA: 0x18260BB50
	internal static StylePropertyId[] GetPropertyIds(StyleRule rule) { }

	// RVA: 0x260B880 Offset: 0x260AA80 VA: 0x18260B880
	private static StylePropertyId GetPropertyId(StyleRule rule, int index) { }

	// RVA: 0x260BC30 Offset: 0x260AE30 VA: 0x18260BC30
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StyleSheetColor // TypeDefIndex: 11810
{
	// Fields
	private static Dictionary<string, Color32> s_NameToColor; // 0x0

	// Methods

	// RVA: 0x260BD20 Offset: 0x260AF20 VA: 0x18260BD20
	public static bool TryGetColor(string name, out Color color) { }

	// RVA: 0x260BD00 Offset: 0x260AF00 VA: 0x18260BD00
	private static Color32 HexToColor32(uint color) { }

	// RVA: 0x260BE30 Offset: 0x260B030 VA: 0x18260BE30
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
[Extension]
internal static class StyleSheetExtensions // TypeDefIndex: 11811
{
	// Methods

	[Extension]
	// RVA: 0x260D930 Offset: 0x260CB30 VA: 0x18260D930
	public static string ReadAsString(StyleSheet sheet, StyleValueHandle handle) { }

	[Extension]
	// RVA: 0x260D900 Offset: 0x260CB00 VA: 0x18260D900
	public static bool IsVarFunction(StyleValueHandle handle) { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
[DebuggerDisplay("id = {id}, keyword = {keyword}, number = {number}, boolean = {boolean}, color = {color}, object = {resource}")]
internal struct StyleValue // TypeDefIndex: 11812
{
	// Fields
	public StylePropertyId id; // 0x0
	public StyleKeyword keyword; // 0x4
	public float number; // 0x8
	public Length length; // 0x8
	public Color color; // 0x8
	public GCHandle resource; // 0x8
	public BackgroundPosition position; // 0x8
	public BackgroundRepeat repeat; // 0x8
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal struct StyleValueManaged // TypeDefIndex: 11813
{
	// Fields
	public StylePropertyId id; // 0x0
	public StyleKeyword keyword; // 0x4
	public object value; // 0x8
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal enum MatchResultErrorCode // TypeDefIndex: 11814
{
	// Fields
	public int value__; // 0x0
	public const MatchResultErrorCode None = 0;
	public const MatchResultErrorCode Syntax = 1;
	public const MatchResultErrorCode EmptyValue = 2;
	public const MatchResultErrorCode ExpectedEndOfValue = 3;
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal struct MatchResult // TypeDefIndex: 11815
{
	// Fields
	public MatchResultErrorCode errorCode; // 0x0
	public string errorValue; // 0x8

	// Properties
	public bool success { get; }

	// Methods

	// RVA: 0x2600E40 Offset: 0x2600040 VA: 0x182600E40
	public bool get_success() { }
}

// Namespace: 
private struct BaseStyleMatcher.MatchContext // TypeDefIndex: 11816
{
	// Fields
	public int valueIndex; // 0x0
	public int matchedVariableCount; // 0x4
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal abstract class BaseStyleMatcher // TypeDefIndex: 11817
{
	// Fields
	protected static readonly Regex s_CustomIdentRegex; // 0x0
	private Stack<BaseStyleMatcher.MatchContext> m_ContextStack; // 0x10
	private BaseStyleMatcher.MatchContext m_CurrentContext; // 0x18

	// Properties
	public abstract int valueCount { get; }
	public abstract bool isCurrentVariable { get; }
	public abstract bool isCurrentComma { get; }
	public bool hasCurrent { get; }
	public int currentIndex { get; set; }
	public int matchedVariableCount { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract bool MatchKeyword(string keyword);

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract bool MatchNumber();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract bool MatchInteger();

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract bool MatchLength();

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract bool MatchPercentage();

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract bool MatchColor();

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract bool MatchResource();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract bool MatchUrl();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract bool MatchTime();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract bool MatchAngle();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract bool MatchCustomIdent();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int get_valueCount();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract bool get_isCurrentVariable();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool get_isCurrentComma();

	// RVA: 0x25FC740 Offset: 0x25FB940 VA: 0x1825FC740
	public bool get_hasCurrent() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_currentIndex() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_currentIndex(int value) { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public int get_matchedVariableCount() { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_matchedVariableCount(int value) { }

	// RVA: 0x25FB550 Offset: 0x25FA750 VA: 0x1825FB550
	protected void Initialize() { }

	// RVA: 0x25FC570 Offset: 0x25FB770 VA: 0x1825FC570
	public void MoveNext() { }

	// RVA: 0x25FC600 Offset: 0x25FB800 VA: 0x1825FC600
	public void SaveContext() { }

	// RVA: 0x25FC5B0 Offset: 0x25FB7B0 VA: 0x1825FC5B0
	public void RestoreContext() { }

	// RVA: 0x25FB500 Offset: 0x25FA700 VA: 0x1825FB500
	public void DropContext() { }

	// RVA: 0x25FC3E0 Offset: 0x25FB5E0 VA: 0x1825FC3E0
	protected bool Match(Expression exp) { }

	// RVA: 0x25FBBD0 Offset: 0x25FADD0 VA: 0x1825FBBD0
	private bool MatchExpression(Expression exp) { }

	// RVA: 0x25FBAB0 Offset: 0x25FACB0 VA: 0x1825FBAB0
	private bool MatchExpressionWithMultiplier(Expression exp) { }

	// RVA: 0x25FBE20 Offset: 0x25FB020 VA: 0x1825FBE20
	private bool MatchGroup(Expression exp) { }

	// RVA: 0x25FB5E0 Offset: 0x25FA7E0 VA: 0x1825FB5E0
	private bool MatchCombinator(Expression exp) { }

	// RVA: 0x25FC2B0 Offset: 0x25FB4B0 VA: 0x1825FC2B0
	private bool MatchOr(Expression exp) { }

	// RVA: 0x25FC290 Offset: 0x25FB490 VA: 0x1825FC290
	private bool MatchOrOr(Expression exp) { }

	// RVA: 0x25FB5A0 Offset: 0x25FA7A0 VA: 0x1825FB5A0
	private bool MatchAndAnd(Expression exp) { }

	// RVA: 0x25FC0D0 Offset: 0x25FB2D0 VA: 0x1825FC0D0
	private int MatchMany(Expression exp) { }

	// RVA: 0x25FBF50 Offset: 0x25FB150 VA: 0x1825FBF50
	private int MatchManyByOrder(Expression exp, int* matchOrder) { }

	// RVA: 0x25FBED0 Offset: 0x25FB0D0 VA: 0x1825FBED0
	private bool MatchJuxtaposition(Expression exp) { }

	// RVA: 0x25FB930 Offset: 0x25FAB30 VA: 0x1825FB930
	private bool MatchDataType(Expression exp) { }

	// RVA: 0x25FC6D0 Offset: 0x25FB8D0 VA: 0x1825FC6D0
	protected void .ctor() { }

	// RVA: 0x25FC650 Offset: 0x25FB850 VA: 0x1825FC650
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal class StylePropertyValueMatcher : BaseStyleMatcher // TypeDefIndex: 11818
{
	// Fields
	private List<StylePropertyValue> m_Values; // 0x20

	// Properties
	private StylePropertyValue current { get; }
	public override int valueCount { get; }
	public override bool isCurrentVariable { get; }
	public override bool isCurrentComma { get; }

	// Methods

	// RVA: 0x260A930 Offset: 0x2609B30 VA: 0x18260A930
	private StylePropertyValue get_current() { }

	// RVA: 0x260AA80 Offset: 0x2609C80 VA: 0x18260AA80 Slot: 15
	public override int get_valueCount() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 16
	public override bool get_isCurrentVariable() { }

	// RVA: 0x260A9D0 Offset: 0x2609BD0 VA: 0x18260A9D0 Slot: 17
	public override bool get_isCurrentComma() { }

	// RVA: 0x260A5E0 Offset: 0x26097E0 VA: 0x18260A5E0
	public MatchResult Match(Expression exp, List<StylePropertyValue> values) { }

	// RVA: 0x260A070 Offset: 0x2609270 VA: 0x18260A070 Slot: 4
	protected override bool MatchKeyword(string keyword) { }

	// RVA: 0x2609FD0 Offset: 0x26091D0 VA: 0x182609FD0 Slot: 5
	protected override bool MatchNumber() { }

	// RVA: 0x2609FD0 Offset: 0x26091D0 VA: 0x182609FD0 Slot: 6
	protected override bool MatchInteger() { }

	// RVA: 0x260A180 Offset: 0x2609380 VA: 0x18260A180 Slot: 7
	protected override bool MatchLength() { }

	// RVA: 0x260A290 Offset: 0x2609490 VA: 0x18260A290 Slot: 8
	protected override bool MatchPercentage() { }

	// RVA: 0x2609CF0 Offset: 0x2608EF0 VA: 0x182609CF0 Slot: 9
	protected override bool MatchColor() { }

	// RVA: 0x260A3A0 Offset: 0x26095A0 VA: 0x18260A3A0 Slot: 10
	protected override bool MatchResource() { }

	// RVA: 0x260A530 Offset: 0x2609730 VA: 0x18260A530 Slot: 11
	protected override bool MatchUrl() { }

	// RVA: 0x260A440 Offset: 0x2609640 VA: 0x18260A440 Slot: 12
	protected override bool MatchTime() { }

	// RVA: 0x2609E90 Offset: 0x2609090 VA: 0x182609E90 Slot: 14
	protected override bool MatchCustomIdent() { }

	// RVA: 0x2609BE0 Offset: 0x2608DE0 VA: 0x182609BE0 Slot: 13
	protected override bool MatchAngle() { }

	// RVA: 0x260A890 Offset: 0x2609A90 VA: 0x18260A890
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal class Expression // TypeDefIndex: 11819
{
	// Fields
	public ExpressionType type; // 0x10
	public ExpressionMultiplier multiplier; // 0x14
	public DataType dataType; // 0x20
	public ExpressionCombinator combinator; // 0x24
	public Expression[] subExpressions; // 0x28
	public string keyword; // 0x30

	// Methods

	// RVA: 0x2600790 Offset: 0x25FF990 VA: 0x182600790
	public void .ctor(ExpressionType type) { }
}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal enum ExpressionType // TypeDefIndex: 11820
{
	// Fields
	public int value__; // 0x0
	public const ExpressionType Unknown = 0;
	public const ExpressionType Data = 1;
	public const ExpressionType Keyword = 2;
	public const ExpressionType Combinator = 3;
}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal enum DataType // TypeDefIndex: 11821
{
	// Fields
	public int value__; // 0x0
	public const DataType None = 0;
	public const DataType Number = 1;
	public const DataType Integer = 2;
	public const DataType Length = 3;
	public const DataType Percentage = 4;
	public const DataType Color = 5;
	public const DataType Resource = 6;
	public const DataType Url = 7;
	public const DataType Time = 8;
	public const DataType Angle = 9;
	public const DataType CustomIdent = 10;
}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal enum ExpressionCombinator // TypeDefIndex: 11822
{
	// Fields
	public int value__; // 0x0
	public const ExpressionCombinator None = 0;
	public const ExpressionCombinator Or = 1;
	public const ExpressionCombinator OrOr = 2;
	public const ExpressionCombinator AndAnd = 3;
	public const ExpressionCombinator Juxtaposition = 4;
	public const ExpressionCombinator Group = 5;
}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal enum ExpressionMultiplierType // TypeDefIndex: 11823
{
	// Fields
	public int value__; // 0x0
	public const ExpressionMultiplierType None = 0;
	public const ExpressionMultiplierType ZeroOrMore = 1;
	public const ExpressionMultiplierType OneOrMore = 2;
	public const ExpressionMultiplierType ZeroOrOne = 3;
	public const ExpressionMultiplierType Ranges = 4;
	public const ExpressionMultiplierType OneOrMoreComma = 5;
	public const ExpressionMultiplierType GroupAtLeastOne = 6;
}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal struct ExpressionMultiplier // TypeDefIndex: 11824
{
	// Fields
	public const int Infinity = 100;
	private ExpressionMultiplierType m_Type; // 0x0
	public int min; // 0x4
	public int max; // 0x8

	// Properties
	public ExpressionMultiplierType type { get; set; }

	// Methods

	// RVA: 0x244E020 Offset: 0x244D220 VA: 0x18244E020
	public ExpressionMultiplierType get_type() { }

	// RVA: 0x2600780 Offset: 0x25FF980 VA: 0x182600780
	public void set_type(ExpressionMultiplierType value) { }

	// RVA: 0x2600760 Offset: 0x25FF960 VA: 0x182600760
	public void .ctor(ExpressionMultiplierType type = 0) { }

	// RVA: 0x26006E0 Offset: 0x25FF8E0 VA: 0x1826006E0
	private void SetType(ExpressionMultiplierType value) { }
}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal class StyleSyntaxParser // TypeDefIndex: 11825
{
	// Fields
	private List<Expression> m_ProcessExpressionList; // 0x10
	private Stack<Expression> m_ExpressionStack; // 0x18
	private Stack<ExpressionCombinator> m_CombinatorStack; // 0x20
	private Dictionary<string, Expression> m_ParsedExpressionCache; // 0x28

	// Methods

	// RVA: 0x260FAD0 Offset: 0x260ECD0 VA: 0x18260FAD0
	public Expression Parse(string syntax) { }

	// RVA: 0x260E720 Offset: 0x260D920 VA: 0x18260E720
	private Expression ParseExpression(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x260FC70 Offset: 0x260EE70 VA: 0x18260FC70
	private void ProcessCombinatorStack() { }

	// RVA: 0x260F8C0 Offset: 0x260EAC0 VA: 0x18260F8C0
	private Expression ParseTerm(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x260DE20 Offset: 0x260D020 VA: 0x18260DE20
	private ExpressionCombinator ParseCombinatorType(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x260EA30 Offset: 0x260DC30 VA: 0x18260EA30
	private Expression ParseGroup(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x260E070 Offset: 0x260D270 VA: 0x18260E070
	private Expression ParseDataType(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x260F0A0 Offset: 0x260E2A0 VA: 0x18260F0A0
	private Expression ParseNonTerminalValue(string syntax) { }

	// RVA: 0x260F220 Offset: 0x260E420 VA: 0x18260F220
	private Expression ParseProperty(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x260ED70 Offset: 0x260DF70 VA: 0x18260ED70
	private void ParseMultiplier(StyleSyntaxTokenizer tokenizer, ref ExpressionMultiplier multiplier) { }

	// RVA: 0x260F700 Offset: 0x260E900 VA: 0x18260F700
	private void ParseRanges(StyleSyntaxTokenizer tokenizer, out int min, out int max) { }

	// RVA: 0x260DCF0 Offset: 0x260CEF0 VA: 0x18260DCF0
	private static void EatSpace(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x260DDD0 Offset: 0x260CFD0 VA: 0x18260DDD0
	private static bool IsExpressionEnd(StyleSyntaxToken token) { }

	// RVA: 0x260DDB0 Offset: 0x260CFB0 VA: 0x18260DDB0
	private static bool IsCombinator(StyleSyntaxToken token) { }

	// RVA: 0x260DDF0 Offset: 0x260CFF0 VA: 0x18260DDF0
	private static bool IsMultiplier(StyleSyntaxToken token) { }

	// RVA: 0x260FF90 Offset: 0x260F190 VA: 0x18260FF90
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal enum StyleSyntaxTokenType // TypeDefIndex: 11826
{
	// Fields
	public int value__; // 0x0
	public const StyleSyntaxTokenType Unknown = 0;
	public const StyleSyntaxTokenType String = 1;
	public const StyleSyntaxTokenType Number = 2;
	public const StyleSyntaxTokenType Space = 3;
	public const StyleSyntaxTokenType SingleBar = 4;
	public const StyleSyntaxTokenType DoubleBar = 5;
	public const StyleSyntaxTokenType DoubleAmpersand = 6;
	public const StyleSyntaxTokenType Comma = 7;
	public const StyleSyntaxTokenType SingleQuote = 8;
	public const StyleSyntaxTokenType Asterisk = 9;
	public const StyleSyntaxTokenType Plus = 10;
	public const StyleSyntaxTokenType QuestionMark = 11;
	public const StyleSyntaxTokenType HashMark = 12;
	public const StyleSyntaxTokenType ExclamationPoint = 13;
	public const StyleSyntaxTokenType OpenBracket = 14;
	public const StyleSyntaxTokenType CloseBracket = 15;
	public const StyleSyntaxTokenType OpenBrace = 16;
	public const StyleSyntaxTokenType CloseBrace = 17;
	public const StyleSyntaxTokenType LessThan = 18;
	public const StyleSyntaxTokenType GreaterThan = 19;
	public const StyleSyntaxTokenType End = 20;
}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal struct StyleSyntaxToken // TypeDefIndex: 11827
{
	// Fields
	public StyleSyntaxTokenType type; // 0x0
	public string text; // 0x8
	public int number; // 0x10

	// Methods

	// RVA: 0x26100B0 Offset: 0x260F2B0 VA: 0x1826100B0
	public void .ctor(StyleSyntaxTokenType t) { }

	// RVA: 0x26100C0 Offset: 0x260F2C0 VA: 0x1826100C0
	public void .ctor(StyleSyntaxTokenType type, string text) { }

	// RVA: 0x26100D0 Offset: 0x260F2D0 VA: 0x1826100D0
	public void .ctor(StyleSyntaxTokenType type, int number) { }
}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal class StyleSyntaxTokenizer // TypeDefIndex: 11828
{
	// Fields
	private List<StyleSyntaxToken> m_Tokens; // 0x10
	private int m_CurrentTokenIndex; // 0x18

	// Properties
	public StyleSyntaxToken current { get; }

	// Methods

	// RVA: 0x2610C50 Offset: 0x260FE50 VA: 0x182610C50
	public StyleSyntaxToken get_current() { }

	// RVA: 0x26102F0 Offset: 0x260F4F0 VA: 0x1826102F0
	public StyleSyntaxToken MoveNext() { }

	// RVA: 0x2610400 Offset: 0x260F600 VA: 0x182610400
	public StyleSyntaxToken PeekNext() { }

	// RVA: 0x26104B0 Offset: 0x260F6B0 VA: 0x1826104B0
	public void Tokenize(string syntax) { }

	// RVA: 0x2610140 Offset: 0x260F340 VA: 0x182610140
	private static bool IsNextCharacter(string s, int index, char c) { }

	// RVA: 0x2610190 Offset: 0x260F390 VA: 0x182610190
	private static bool IsNextLetterOrDash(string s, int index) { }

	// RVA: 0x2610260 Offset: 0x260F460 VA: 0x182610260
	private static bool IsNextNumber(string s, int index) { }

	// RVA: 0x26100E0 Offset: 0x260F2E0 VA: 0x1826100E0
	private static int GlobCharacter(string s, int index, char c) { }

	// RVA: 0x2610BD0 Offset: 0x260FDD0 VA: 0x182610BD0
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.Experimental
public static class Easing // TypeDefIndex: 11829
{
	// Methods

	// RVA: 0x767080 Offset: 0x766280 VA: 0x180767080
	public static float Linear(float t) { }

	// RVA: 0x2600450 Offset: 0x25FF650 VA: 0x182600450
	public static float InSine(float t) { }

	// RVA: 0x26006D0 Offset: 0x25FF8D0 VA: 0x1826006D0
	public static float OutSine(float t) { }

	// RVA: 0x2600400 Offset: 0x25FF600 VA: 0x182600400
	public static float InOutSine(float t) { }

	// RVA: 0x2600440 Offset: 0x25FF640 VA: 0x182600440
	public static float InQuad(float t) { }

	// RVA: 0x26006B0 Offset: 0x25FF8B0 VA: 0x1826006B0
	public static float OutQuad(float t) { }

	// RVA: 0x26003B0 Offset: 0x25FF5B0 VA: 0x1826003B0
	public static float InOutQuad(float t) { }

	// RVA: 0x25FFE10 Offset: 0x25FF010 VA: 0x1825FFE10
	public static float InCubic(float t) { }

	// RVA: 0x2600590 Offset: 0x25FF790 VA: 0x182600590
	public static float OutCubic(float t) { }

	// RVA: 0x2600190 Offset: 0x25FF390 VA: 0x182600190
	public static float InOutCubic(float t) { }

	// RVA: 0x2600430 Offset: 0x25FF630 VA: 0x182600430
	public static float InPower(float t, int power) { }

	// RVA: 0x2600660 Offset: 0x25FF860 VA: 0x182600660
	public static float OutPower(float t, int power) { }

	// RVA: 0x2600330 Offset: 0x25FF530 VA: 0x182600330
	public static float InOutPower(float t, int power) { }

	// RVA: 0x25FFCE0 Offset: 0x25FEEE0 VA: 0x1825FFCE0
	public static float InBounce(float t) { }

	// RVA: 0x26004C0 Offset: 0x25FF6C0 VA: 0x1826004C0
	public static float OutBounce(float t) { }

	// RVA: 0x25FFF30 Offset: 0x25FF130 VA: 0x1825FFF30
	public static float InOutBounce(float t) { }

	// RVA: 0x25FFE20 Offset: 0x25FF020 VA: 0x1825FFE20
	public static float InElastic(float t) { }

	// RVA: 0x26005C0 Offset: 0x25FF7C0 VA: 0x1826005C0
	public static float OutElastic(float t) { }

	// RVA: 0x26001F0 Offset: 0x25FF3F0 VA: 0x1826001F0
	public static float InOutElastic(float t) { }

	// RVA: 0x25FFCC0 Offset: 0x25FEEC0 VA: 0x1825FFCC0
	public static float InBack(float t) { }

	// RVA: 0x2600480 Offset: 0x25FF680 VA: 0x182600480
	public static float OutBack(float t) { }

	// RVA: 0x25FFEB0 Offset: 0x25FF0B0 VA: 0x1825FFEB0
	public static float InOutBack(float t) { }

	// RVA: 0x25FFDB0 Offset: 0x25FEFB0 VA: 0x1825FFDB0
	public static float InCirc(float t) { }

	// RVA: 0x2600560 Offset: 0x25FF760 VA: 0x182600560
	public static float OutCirc(float t) { }

	// RVA: 0x26000E0 Offset: 0x25FF2E0 VA: 0x1826000E0
	public static float InOutCirc(float t) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PointerOverLinkTagEvent.<>c // TypeDefIndex: 11830
{
	// Fields
	public static readonly PointerOverLinkTagEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x2611840 Offset: 0x2610A40 VA: 0x182611840
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2611410 Offset: 0x2610610 VA: 0x182611410
	internal PointerOverLinkTagEvent <.cctor>b__0_0() { }
}

// Namespace: UnityEngine.UIElements.Experimental
[EventCategory(3)]
public class PointerOverLinkTagEvent : PointerEventBase<PointerOverLinkTagEvent> // TypeDefIndex: 11831
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <linkID>k__BackingField; // 0x110
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <linkText>k__BackingField; // 0x118

	// Properties
	private string linkID { set; }
	private string linkText { set; }

	// Methods

	// RVA: 0x26096C0 Offset: 0x26088C0 VA: 0x1826096C0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x6ED6D0 Offset: 0x6EC8D0 VA: 0x1806ED6D0
	private void set_linkID(string value) { }

	[CompilerGenerated]
	// RVA: 0x6ED6C0 Offset: 0x6EC8C0 VA: 0x1806ED6C0
	private void set_linkText(string value) { }

	// RVA: 0x2609670 Offset: 0x2608870 VA: 0x182609670 Slot: 12
	protected override void Init() { }

	// RVA: 0x2609110 Offset: 0x2608310 VA: 0x182609110
	private void LocalInit() { }

	// RVA: 0x2609600 Offset: 0x2608800 VA: 0x182609600
	public static PointerOverLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	// RVA: 0x26097A0 Offset: 0x26089A0 VA: 0x1826097A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PointerMoveLinkTagEvent.<>c // TypeDefIndex: 11832
{
	// Fields
	public static readonly PointerMoveLinkTagEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x2611720 Offset: 0x2610920 VA: 0x182611720
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x26114F0 Offset: 0x26106F0 VA: 0x1826114F0
	internal PointerMoveLinkTagEvent <.cctor>b__0_0() { }
}

// Namespace: UnityEngine.UIElements.Experimental
[EventCategory(2)]
public class PointerMoveLinkTagEvent : PointerEventBase<PointerMoveLinkTagEvent> // TypeDefIndex: 11833
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <linkID>k__BackingField; // 0x110
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <linkText>k__BackingField; // 0x118

	// Properties
	private string linkID { set; }
	private string linkText { set; }

	// Methods

	// RVA: 0x2609310 Offset: 0x2608510 VA: 0x182609310
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x6ED6D0 Offset: 0x6EC8D0 VA: 0x1806ED6D0
	private void set_linkID(string value) { }

	[CompilerGenerated]
	// RVA: 0x6ED6C0 Offset: 0x6EC8C0 VA: 0x1806ED6C0
	private void set_linkText(string value) { }

	// RVA: 0x26092C0 Offset: 0x26084C0 VA: 0x1826092C0 Slot: 12
	protected override void Init() { }

	// RVA: 0x2609110 Offset: 0x2608310 VA: 0x182609110
	private void LocalInit() { }

	// RVA: 0x2609250 Offset: 0x2608450 VA: 0x182609250
	public static PointerMoveLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	// RVA: 0x26093F0 Offset: 0x26085F0 VA: 0x1826093F0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PointerOutLinkTagEvent.<>c // TypeDefIndex: 11834
{
	// Fields
	public static readonly PointerOutLinkTagEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x26117E0 Offset: 0x26109E0 VA: 0x1826117E0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x26113A0 Offset: 0x26105A0 VA: 0x1826113A0
	internal PointerOutLinkTagEvent <.cctor>b__0_0() { }
}

// Namespace: UnityEngine.UIElements.Experimental
[EventCategory(3)]
public class PointerOutLinkTagEvent : PointerEventBase<PointerOutLinkTagEvent> // TypeDefIndex: 11835
{
	// Methods

	// RVA: 0x26094D0 Offset: 0x26086D0 VA: 0x1826094D0
	private static void .cctor() { }

	// RVA: 0x2609480 Offset: 0x2608680 VA: 0x182609480 Slot: 12
	protected override void Init() { }

	// RVA: 0x2609110 Offset: 0x2608310 VA: 0x182609110
	private void LocalInit() { }

	// RVA: 0x2609440 Offset: 0x2608640 VA: 0x182609440
	public static PointerOutLinkTagEvent GetPooled(IPointerEvent evt, string linkID) { }

	// RVA: 0x26095B0 Offset: 0x26087B0 VA: 0x1826095B0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PointerDownLinkTagEvent.<>c // TypeDefIndex: 11836
{
	// Fields
	public static readonly PointerDownLinkTagEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x26118A0 Offset: 0x2610AA0 VA: 0x1826118A0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2611560 Offset: 0x2610760 VA: 0x182611560
	internal PointerDownLinkTagEvent <.cctor>b__0_0() { }
}

// Namespace: UnityEngine.UIElements.Experimental
public sealed class PointerDownLinkTagEvent : PointerEventBase<PointerDownLinkTagEvent> // TypeDefIndex: 11837
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <linkID>k__BackingField; // 0x110
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <linkText>k__BackingField; // 0x118

	// Properties
	private string linkID { set; }
	private string linkText { set; }

	// Methods

	// RVA: 0x2609120 Offset: 0x2608320 VA: 0x182609120
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x6ED6D0 Offset: 0x6EC8D0 VA: 0x1806ED6D0
	private void set_linkID(string value) { }

	[CompilerGenerated]
	// RVA: 0x6ED6C0 Offset: 0x6EC8C0 VA: 0x1806ED6C0
	private void set_linkText(string value) { }

	// RVA: 0x26090C0 Offset: 0x26082C0 VA: 0x1826090C0 Slot: 12
	protected override void Init() { }

	// RVA: 0x2609110 Offset: 0x2608310 VA: 0x182609110
	private void LocalInit() { }

	// RVA: 0x2609050 Offset: 0x2608250 VA: 0x182609050
	public static PointerDownLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	// RVA: 0x2609200 Offset: 0x2608400 VA: 0x182609200
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PointerUpLinkTagEvent.<>c // TypeDefIndex: 11838
{
	// Fields
	public static readonly PointerUpLinkTagEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x2611780 Offset: 0x2610980 VA: 0x182611780
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2611480 Offset: 0x2610680 VA: 0x182611480
	internal PointerUpLinkTagEvent <.cctor>b__0_0() { }
}

// Namespace: UnityEngine.UIElements.Experimental
public class PointerUpLinkTagEvent : PointerEventBase<PointerUpLinkTagEvent> // TypeDefIndex: 11839
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <linkID>k__BackingField; // 0x110
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <linkText>k__BackingField; // 0x118

	// Properties
	private string linkID { set; }
	private string linkText { set; }

	// Methods

	// RVA: 0x26098B0 Offset: 0x2608AB0 VA: 0x1826098B0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x6ED6D0 Offset: 0x6EC8D0 VA: 0x1806ED6D0
	private void set_linkID(string value) { }

	[CompilerGenerated]
	// RVA: 0x6ED6C0 Offset: 0x6EC8C0 VA: 0x1806ED6C0
	private void set_linkText(string value) { }

	// RVA: 0x2609860 Offset: 0x2608A60 VA: 0x182609860 Slot: 12
	protected override void Init() { }

	// RVA: 0x2609110 Offset: 0x2608310 VA: 0x182609110
	private void LocalInit() { }

	// RVA: 0x26097F0 Offset: 0x26089F0 VA: 0x1826097F0
	public static PointerUpLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	// RVA: 0x2609990 Offset: 0x2608B90 VA: 0x182609990
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.Experimental
public struct StyleValues // TypeDefIndex: 11840
{
	// Fields
	internal StyleValueCollection m_StyleValues; // 0x0

	// Properties
	public float top { set; }
	public float left { set; }
	public float width { set; }
	public float height { set; }
	public float right { set; }
	public float bottom { set; }
	public Color color { set; }
	public Color backgroundColor { set; }
	public Color unityBackgroundImageTintColor { set; }
	public Color borderColor { set; }
	public float marginLeft { set; }
	public float marginTop { set; }
	public float marginRight { set; }
	public float marginBottom { set; }
	public float paddingLeft { set; }
	public float paddingTop { get; set; }
	public float paddingRight { set; }
	public float paddingBottom { set; }
	public float borderLeftWidth { set; }
	public float borderRightWidth { set; }
	public float borderTopWidth { set; }
	public float borderBottomWidth { set; }
	public float borderTopLeftRadius { set; }
	public float borderTopRightRadius { set; }
	public float borderBottomLeftRadius { set; }
	public float borderBottomRightRadius { set; }
	public float opacity { set; }
	public float flexGrow { set; }
	public float flexShrink { set; }

	// Methods

	// RVA: 0x26112D0 Offset: 0x26104D0 VA: 0x1826112D0
	public void set_top(float value) { }

	// RVA: 0x2611220 Offset: 0x2610420 VA: 0x182611220
	public void set_left(float value) { }

	// RVA: 0x2611390 Offset: 0x2610590 VA: 0x182611390
	public void set_width(float value) { }

	// RVA: 0x2611210 Offset: 0x2610410 VA: 0x182611210
	public void set_height(float value) { }

	// RVA: 0x26112C0 Offset: 0x26104C0 VA: 0x1826112C0
	public void set_right(float value) { }

	// RVA: 0x2611140 Offset: 0x2610340 VA: 0x182611140
	public void set_bottom(float value) { }

	// RVA: 0x2611150 Offset: 0x2610350 VA: 0x182611150
	public void set_color(Color value) { }

	// RVA: 0x2610F60 Offset: 0x2610160 VA: 0x182610F60
	public void set_backgroundColor(Color value) { }

	// RVA: 0x26112E0 Offset: 0x26104E0 VA: 0x1826112E0
	public void set_unityBackgroundImageTintColor(Color value) { }

	// RVA: 0x2611040 Offset: 0x2610240 VA: 0x182611040
	public void set_borderColor(Color value) { }

	// RVA: 0x2611240 Offset: 0x2610440 VA: 0x182611240
	public void set_marginLeft(float value) { }

	// RVA: 0x2611260 Offset: 0x2610460 VA: 0x182611260
	public void set_marginTop(float value) { }

	// RVA: 0x2611250 Offset: 0x2610450 VA: 0x182611250
	public void set_marginRight(float value) { }

	// RVA: 0x2611230 Offset: 0x2610430 VA: 0x182611230
	public void set_marginBottom(float value) { }

	// RVA: 0x2611290 Offset: 0x2610490 VA: 0x182611290
	public void set_paddingLeft(float value) { }

	// RVA: 0x2610ED0 Offset: 0x26100D0 VA: 0x182610ED0
	public float get_paddingTop() { }

	// RVA: 0x26112B0 Offset: 0x26104B0 VA: 0x1826112B0
	public void set_paddingTop(float value) { }

	// RVA: 0x26112A0 Offset: 0x26104A0 VA: 0x1826112A0
	public void set_paddingRight(float value) { }

	// RVA: 0x2611280 Offset: 0x2610480 VA: 0x182611280
	public void set_paddingBottom(float value) { }

	// RVA: 0x26110F0 Offset: 0x26102F0 VA: 0x1826110F0
	public void set_borderLeftWidth(float value) { }

	// RVA: 0x2611100 Offset: 0x2610300 VA: 0x182611100
	public void set_borderRightWidth(float value) { }

	// RVA: 0x2611130 Offset: 0x2610330 VA: 0x182611130
	public void set_borderTopWidth(float value) { }

	// RVA: 0x2611030 Offset: 0x2610230 VA: 0x182611030
	public void set_borderBottomWidth(float value) { }

	// RVA: 0x2611110 Offset: 0x2610310 VA: 0x182611110
	public void set_borderTopLeftRadius(float value) { }

	// RVA: 0x2611120 Offset: 0x2610320 VA: 0x182611120
	public void set_borderTopRightRadius(float value) { }

	// RVA: 0x2611010 Offset: 0x2610210 VA: 0x182611010
	public void set_borderBottomLeftRadius(float value) { }

	// RVA: 0x2611020 Offset: 0x2610220 VA: 0x182611020
	public void set_borderBottomRightRadius(float value) { }

	// RVA: 0x2611270 Offset: 0x2610470 VA: 0x182611270
	public void set_opacity(float value) { }

	// RVA: 0x2611200 Offset: 0x2610400 VA: 0x182611200
	public void set_flexGrow(float value) { }

	// RVA: 0x2611200 Offset: 0x2610400 VA: 0x182611200
	public void set_flexShrink(float value) { }

	// RVA: 0x2610D00 Offset: 0x260FF00 VA: 0x182610D00
	internal void SetValue(StylePropertyId id, float value) { }

	// RVA: 0x2610DB0 Offset: 0x260FFB0 VA: 0x182610DB0
	internal void SetValue(StylePropertyId id, Color value) { }

	// RVA: 0x2610E60 Offset: 0x2610060 VA: 0x182610E60
	internal StyleValueCollection Values() { }
}

// Namespace: UnityEngine.UIElements.Experimental
public interface ITransitionAnimations // TypeDefIndex: 11841
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ValueAnimation<StyleValues> Start(StyleValues to, int durationMs);
}

// Namespace: UnityEngine.UIElements.Experimental
internal static class Lerp // TypeDefIndex: 11842
{
	// Methods

	// RVA: 0x247AE50 Offset: 0x247A050 VA: 0x18247AE50
	public static float Interpolate(float start, float end, float ratio) { }

	// RVA: 0x26007E0 Offset: 0x25FF9E0 VA: 0x1826007E0
	public static Color Interpolate(Color start, Color end, float ratio) { }

	// RVA: 0x2600880 Offset: 0x25FFA80 VA: 0x182600880
	internal static StyleValues Interpolate(StyleValues start, StyleValues end, float ratio) { }
}

// Namespace: UnityEngine.UIElements.Experimental
internal interface IValueAnimationUpdate // TypeDefIndex: 11843
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Tick(long currentTimeMs);
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ValueAnimation.<>c<T> // TypeDefIndex: 11844
{
	// Fields
	public static readonly ValueAnimation.<>c<T> <>9; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08330 Offset: 0xB07530 VA: 0x180B08330
	|-ValueAnimation.<>c<StyleValues>..cctor
	|
	|-RVA: 0xB08640 Offset: 0xB07840 VA: 0x180B08640
	|-ValueAnimation.<>c<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-ValueAnimation.<>c<StyleValues>..ctor
	|-ValueAnimation.<>c<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal ValueAnimation<T> <.cctor>b__67_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB07E30 Offset: 0xB07030 VA: 0x180B07E30
	|-ValueAnimation.<>c<StyleValues>.<.cctor>b__67_0
	|
	|-RVA: 0xB06C90 Offset: 0xB05E90 VA: 0x180B06C90
	|-ValueAnimation.<>c<__Il2CppFullySharedGenericType>.<.cctor>b__67_0
	*/
}

// Namespace: UnityEngine.UIElements.Experimental
public sealed class ValueAnimation<T> : IValueAnimationUpdate // TypeDefIndex: 11845
{
	// Fields
	private long m_StartTimeMs; // 0x0
	private int m_DurationMs; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Func<float, float> <easingCurve>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <isRunning>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action <onAnimationCompleted>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <autoRecycle>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <recycled>k__BackingField; // 0x0
	private static ObjectPool<ValueAnimation<T>> sObjectPool; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VisualElement <owner>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<VisualElement, T> <valueUpdated>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Func<VisualElement, T> <initialValue>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Func<T, T, float, T> <interpolator>k__BackingField; // 0x0
	private T _from; // 0x0
	private bool fromValueSet; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private T <to>k__BackingField; // 0x0

	// Properties
	public int durationMs { get; set; }
	public Func<float, float> easingCurve { get; set; }
	public bool isRunning { get; set; }
	public Action onAnimationCompleted { get; set; }
	public bool autoRecycle { get; set; }
	private bool recycled { get; set; }
	private VisualElement owner { get; set; }
	public Action<VisualElement, T> valueUpdated { get; set; }
	public Func<VisualElement, T> initialValue { get; set; }
	public Func<T, T, float, T> interpolator { get; set; }
	public T from { get; set; }
	public T to { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public int get_durationMs() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB78A40 Offset: 0xB77C40 VA: 0x180B78A40
	|-ValueAnimation<StyleValues>.get_durationMs
	|
	|-RVA: 0xB25410 Offset: 0xB24610 VA: 0x180B25410
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_durationMs
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void set_durationMs(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF5930 Offset: 0xCF4B30 VA: 0x180CF5930
	|-ValueAnimation<StyleValues>.set_durationMs
	|
	|-RVA: 0xCF58D0 Offset: 0xCF4AD0 VA: 0x180CF58D0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_durationMs
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public Func<float, float> get_easingCurve() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	|-ValueAnimation<StyleValues>.get_easingCurve
	|
	|-RVA: 0xCF5400 Offset: 0xCF4600 VA: 0x180CF5400
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_easingCurve
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_easingCurve(Func<float, float> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	|-ValueAnimation<StyleValues>.set_easingCurve
	|
	|-RVA: 0xCF5940 Offset: 0xCF4B40 VA: 0x180CF5940
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_easingCurve
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 7
	public bool get_isRunning() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	|-ValueAnimation<StyleValues>.get_isRunning
	|
	|-RVA: 0xCF56D0 Offset: 0xCF48D0 VA: 0x180CF56D0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_isRunning
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_isRunning(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	|-ValueAnimation<StyleValues>.set_isRunning
	|
	|-RVA: 0xCF5B70 Offset: 0xCF4D70 VA: 0x180CF5B70
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_isRunning
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public Action get_onAnimationCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	|-ValueAnimation<StyleValues>.get_onAnimationCompleted
	|
	|-RVA: 0xCF5700 Offset: 0xCF4900 VA: 0x180CF5700
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_onAnimationCompleted
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_onAnimationCompleted(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	|-ValueAnimation<StyleValues>.set_onAnimationCompleted
	|
	|-RVA: 0xCF5BD0 Offset: 0xCF4DD0 VA: 0x180CF5BD0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_onAnimationCompleted
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public bool get_autoRecycle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700
	|-ValueAnimation<StyleValues>.get_autoRecycle
	|
	|-RVA: 0xCF53D0 Offset: 0xCF45D0 VA: 0x180CF53D0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_autoRecycle
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_autoRecycle(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BD760 Offset: 0x4BC960 VA: 0x1804BD760
	|-ValueAnimation<StyleValues>.set_autoRecycle
	|
	|-RVA: 0xCF5870 Offset: 0xCF4A70 VA: 0x180CF5870
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_autoRecycle
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private bool get_recycled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BD740 Offset: 0x4BC940 VA: 0x1804BD740
	|-ValueAnimation<StyleValues>.get_recycled
	|
	|-RVA: 0xCF5760 Offset: 0xCF4960 VA: 0x180CF5760
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_recycled
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_recycled(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BD790 Offset: 0x4BC990 VA: 0x1804BD790
	|-ValueAnimation<StyleValues>.set_recycled
	|
	|-RVA: 0xCF5C90 Offset: 0xCF4E90 VA: 0x180CF5C90
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_recycled
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private VisualElement get_owner() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	|-ValueAnimation<StyleValues>.get_owner
	|
	|-RVA: 0xCF5730 Offset: 0xCF4930 VA: 0x180CF5730
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_owner
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_owner(VisualElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	|-ValueAnimation<StyleValues>.set_owner
	|
	|-RVA: 0xCF5C30 Offset: 0xCF4E30 VA: 0x180CF5C30
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_owner
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public Action<VisualElement, T> get_valueUpdated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	|-ValueAnimation<StyleValues>.get_valueUpdated
	|
	|-RVA: 0xCF5840 Offset: 0xCF4A40 VA: 0x180CF5840
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_valueUpdated
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_valueUpdated(Action<VisualElement, T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	|-ValueAnimation<StyleValues>.set_valueUpdated
	|
	|-RVA: 0xCF5DB0 Offset: 0xCF4FB0 VA: 0x180CF5DB0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_valueUpdated
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public Func<VisualElement, T> get_initialValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	|-ValueAnimation<StyleValues>.get_initialValue
	|
	|-RVA: 0xB90470 Offset: 0xB8F670 VA: 0x180B90470
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_initialValue
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_initialValue(Func<VisualElement, T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	|-ValueAnimation<StyleValues>.set_initialValue
	|
	|-RVA: 0xCF5AB0 Offset: 0xCF4CB0 VA: 0x180CF5AB0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_initialValue
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public Func<T, T, float, T> get_interpolator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	|-ValueAnimation<StyleValues>.get_interpolator
	|
	|-RVA: 0xCF56A0 Offset: 0xCF48A0 VA: 0x180CF56A0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_interpolator
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_interpolator(Func<T, T, float, T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	|-ValueAnimation<StyleValues>.set_interpolator
	|
	|-RVA: 0xCF5B10 Offset: 0xCF4D10 VA: 0x180CF5B10
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_interpolator
	*/

	// RVA: -1 Offset: -1
	public T get_from() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF5430 Offset: 0xCF4630 VA: 0x180CF5430
	|-ValueAnimation<StyleValues>.get_from
	|
	|-RVA: 0xCF5480 Offset: 0xCF4680 VA: 0x180CF5480
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_from
	*/

	// RVA: -1 Offset: -1
	public void set_from(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF5AA0 Offset: 0xCF4CA0 VA: 0x180CF5AA0
	|-ValueAnimation<StyleValues>.set_from
	|
	|-RVA: 0xCF59A0 Offset: 0xCF4BA0 VA: 0x180CF59A0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_from
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public T get_to() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	|-ValueAnimation<StyleValues>.get_to
	|
	|-RVA: 0xCF5790 Offset: 0xCF4990 VA: 0x180CF5790
	|-ValueAnimation<__Il2CppFullySharedGenericType>.get_to
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_to(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30
	|-ValueAnimation<StyleValues>.set_to
	|
	|-RVA: 0xCF5CF0 Offset: 0xCF4EF0 VA: 0x180CF5CF0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.set_to
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF5390 Offset: 0xCF4590 VA: 0x180CF5390
	|-ValueAnimation<StyleValues>..ctor
	|
	|-RVA: 0xCF5310 Offset: 0xCF4510 VA: 0x180CF5310
	|-ValueAnimation<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Start() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF43F0 Offset: 0xCF35F0 VA: 0x180CF43F0
	|-ValueAnimation<StyleValues>.Start
	|
	|-RVA: 0xCF44C0 Offset: 0xCF36C0 VA: 0x180CF44C0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.Start
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Stop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF46E0 Offset: 0xCF38E0 VA: 0x180CF46E0
	|-ValueAnimation<StyleValues>.Stop
	|
	|-RVA: 0xCF45D0 Offset: 0xCF37D0 VA: 0x180CF45D0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.Stop
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public void Recycle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF3BB0 Offset: 0xCF2DB0 VA: 0x180CF3BB0
	|-ValueAnimation<StyleValues>.Recycle
	|
	|-RVA: 0xCF3D00 Offset: 0xCF2F00 VA: 0x180CF3D00
	|-ValueAnimation<__Il2CppFullySharedGenericType>.Recycle
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private void UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick(long currentTimeMs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF4C50 Offset: 0xCF3E50 VA: 0x180CF4C50
	|-ValueAnimation<StyleValues>.UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick
	|
	|-RVA: 0xCF4880 Offset: 0xCF3A80 VA: 0x180CF4880
	|-ValueAnimation<__Il2CppFullySharedGenericType>.UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick
	*/

	// RVA: -1 Offset: -1
	private void SetDefaultValues() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF4240 Offset: 0xCF3440 VA: 0x180CF4240
	|-ValueAnimation<StyleValues>.SetDefaultValues
	|
	|-RVA: 0xCF3F00 Offset: 0xCF3100 VA: 0x180CF3F00
	|-ValueAnimation<__Il2CppFullySharedGenericType>.SetDefaultValues
	*/

	// RVA: -1 Offset: -1
	private void Unregister() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF4DD0 Offset: 0xCF3FD0 VA: 0x180CF4DD0
	|-ValueAnimation<StyleValues>.Unregister
	|
	|-RVA: 0xCF4DF0 Offset: 0xCF3FF0 VA: 0x180CF4DF0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.Unregister
	*/

	// RVA: -1 Offset: -1
	private void Register() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF3E70 Offset: 0xCF3070 VA: 0x180CF3E70
	|-ValueAnimation<StyleValues>.Register
	|
	|-RVA: 0xCF3E90 Offset: 0xCF3090 VA: 0x180CF3E90
	|-ValueAnimation<__Il2CppFullySharedGenericType>.Register
	*/

	// RVA: -1 Offset: -1
	internal void SetOwner(VisualElement e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF42E0 Offset: 0xCF34E0 VA: 0x180CF42E0
	|-ValueAnimation<StyleValues>.SetOwner
	|
	|-RVA: 0xCF4340 Offset: 0xCF3540 VA: 0x180CF4340
	|-ValueAnimation<__Il2CppFullySharedGenericType>.SetOwner
	*/

	// RVA: -1 Offset: -1
	private void CheckNotRecycled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF3760 Offset: 0xCF2960 VA: 0x180CF3760
	|-ValueAnimation<StyleValues>.CheckNotRecycled
	|
	|-RVA: 0xCF36E0 Offset: 0xCF28E0 VA: 0x180CF36E0
	|-ValueAnimation<__Il2CppFullySharedGenericType>.CheckNotRecycled
	*/

	// RVA: -1 Offset: -1
	public static ValueAnimation<T> Create(VisualElement e, Func<T, T, float, T> interpolator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF37C0 Offset: 0xCF29C0 VA: 0x180CF37C0
	|-ValueAnimation<StyleValues>.Create
	|
	|-RVA: 0xCF3940 Offset: 0xCF2B40 VA: 0x180CF3940
	|-ValueAnimation<__Il2CppFullySharedGenericType>.Create
	*/

	// RVA: -1 Offset: -1
	public ValueAnimation<T> KeepAlive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF3BA0 Offset: 0xCF2DA0 VA: 0x180CF3BA0
	|-ValueAnimation<StyleValues>.KeepAlive
	|
	|-RVA: 0xCF3B70 Offset: 0xCF2D70 VA: 0x180CF3B70
	|-ValueAnimation<__Il2CppFullySharedGenericType>.KeepAlive
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF4E60 Offset: 0xCF4060 VA: 0x180CF4E60
	|-ValueAnimation<StyleValues>..cctor
	|
	|-RVA: 0xCF5090 Offset: 0xCF4290 VA: 0x180CF5090
	|-ValueAnimation<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnMovePreview : VisualElement // TypeDefIndex: 11846
{
	// Fields
	public static readonly string ussClassName; // 0x0

	// Methods

	// RVA: 0x2606320 Offset: 0x2605520 VA: 0x182606320
	public void .ctor() { }

	// RVA: 0x2606290 Offset: 0x2605490 VA: 0x182606290
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnMoveLocationPreview : VisualElement // TypeDefIndex: 11847
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string visualUssClassName; // 0x8

	// Methods

	// RVA: 0x2606180 Offset: 0x2605380 VA: 0x182606180
	public void .ctor() { }

	// RVA: 0x26060B0 Offset: 0x26052B0 VA: 0x1826060B0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.Internal
internal class ColumnMover : PointerManipulator // TypeDefIndex: 11848
{
	// Fields
	private float m_StartPos; // 0x38
	private float m_LastPos; // 0x3C
	private bool m_Active; // 0x40
	private bool m_Moving; // 0x41
	private bool m_Cancelled; // 0x42
	private MultiColumnCollectionHeader m_Header; // 0x48
	private VisualElement m_PreviewElement; // 0x50
	private MultiColumnHeaderColumnMoveLocationPreview m_LocationPreviewElement; // 0x58
	private Column m_ColumnToMove; // 0x60
	private float m_ColumnToMovePos; // 0x68
	private float m_ColumnToMoveWidth; // 0x6C
	private Column m_DestinationColumn; // 0x70
	private bool m_MoveBeforeDestination; // 0x78
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private ColumnLayout <columnLayout>k__BackingField; // 0x80
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<ColumnMover> activeChanged; // 0x88
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<ColumnMover> movingChanged; // 0x90

	// Properties
	public ColumnLayout columnLayout { get; set; }
	public bool active { get; set; }
	public bool moving { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	public ColumnLayout get_columnLayout() { }

	[CompilerGenerated]
	// RVA: 0x42D780 Offset: 0x42C980 VA: 0x18042D780
	public void set_columnLayout(ColumnLayout value) { }

	// RVA: 0x4456F0 Offset: 0x4448F0 VA: 0x1804456F0
	public bool get_active() { }

	// RVA: 0x25FEE00 Offset: 0x25FE000 VA: 0x1825FEE00
	public void set_active(bool value) { }

	// RVA: 0x7724A0 Offset: 0x7716A0 VA: 0x1807724A0
	public bool get_moving() { }

	// RVA: 0x25FEE30 Offset: 0x25FE030 VA: 0x1825FEE30
	public void set_moving(bool value) { }

	[CompilerGenerated]
	// RVA: 0x25FEB00 Offset: 0x25FDD00 VA: 0x1825FEB00
	public void add_activeChanged(Action<ColumnMover> value) { }

	[CompilerGenerated]
	// RVA: 0x25FEC80 Offset: 0x25FDE80 VA: 0x1825FEC80
	public void remove_activeChanged(Action<ColumnMover> value) { }

	[CompilerGenerated]
	// RVA: 0x25FEBC0 Offset: 0x25FDDC0 VA: 0x1825FEBC0
	public void add_movingChanged(Action<ColumnMover> value) { }

	[CompilerGenerated]
	// RVA: 0x25FED40 Offset: 0x25FDF40 VA: 0x1825FED40
	public void remove_movingChanged(Action<ColumnMover> value) { }

	// RVA: 0x25FEA10 Offset: 0x25FDC10 VA: 0x1825FEA10
	public void .ctor() { }

	// RVA: 0x25FDBD0 Offset: 0x25FCDD0 VA: 0x1825FDBD0 Slot: 5
	protected override void RegisterCallbacksOnTarget() { }

	// RVA: 0x25FE090 Offset: 0x25FD290 VA: 0x1825FE090 Slot: 6
	protected override void UnregisterCallbacksFromTarget() { }

	// RVA: 0x25FCF40 Offset: 0x25FC140 VA: 0x1825FCF40
	protected void OnMouseDown(MouseDownEvent evt) { }

	// RVA: 0x25FD010 Offset: 0x25FC210 VA: 0x1825FD010
	protected void OnMouseMove(MouseMoveEvent evt) { }

	// RVA: 0x25FD080 Offset: 0x25FC280 VA: 0x1825FD080
	protected void OnMouseUp(MouseUpEvent evt) { }

	// RVA: 0x25FCEC0 Offset: 0x25FC0C0 VA: 0x1825FCEC0
	private void OnMouseCaptureOut(MouseCaptureOutEvent evt) { }

	// RVA: 0x25FD2F0 Offset: 0x25FC4F0 VA: 0x1825FD2F0
	private void OnPointerDown(PointerDownEvent evt) { }

	// RVA: 0x25FD410 Offset: 0x25FC610 VA: 0x1825FD410
	private void OnPointerMove(PointerMoveEvent evt) { }

	// RVA: 0x25FD520 Offset: 0x25FC720 VA: 0x1825FD520
	private void OnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x25FD160 Offset: 0x25FC360 VA: 0x1825FD160
	private void OnPointerCancel(PointerCancelEvent evt) { }

	// RVA: 0x25FD230 Offset: 0x25FC430 VA: 0x1825FD230
	private void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	// RVA: 0x25FCDB0 Offset: 0x25FBFB0 VA: 0x1825FCDB0
	private static bool IsNotMouseEvent(int pointerId) { }

	// RVA: 0x25FD650 Offset: 0x25FC850 VA: 0x1825FD650
	protected void ProcessCancelEvent(EventBase evt, int pointerId) { }

	// RVA: 0x25FCE10 Offset: 0x25FC010 VA: 0x1825FCE10
	private void OnKeyDown(KeyDownEvent e) { }

	// RVA: 0x25FD790 Offset: 0x25FC990 VA: 0x1825FD790
	private void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	// RVA: 0x25FD980 Offset: 0x25FCB80 VA: 0x1825FD980
	private void ProcessMoveEvent(EventBase e, Vector2 localPosition) { }

	// RVA: 0x25FDAC0 Offset: 0x25FCCC0 VA: 0x1825FDAC0
	private void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	// RVA: 0x25FC770 Offset: 0x25FB970 VA: 0x1825FC770
	private void BeginDragMove(float pos) { }

	// RVA: 0x25FCC70 Offset: 0x25FBE70 VA: 0x1825FCC70
	internal void DragMove(float pos) { }

	// RVA: 0x25FE720 Offset: 0x25FD920 VA: 0x1825FE720
	private void UpdatePreviewPosition() { }

	// RVA: 0x25FE550 Offset: 0x25FD750 VA: 0x1825FE550
	private void UpdateMoveLocation() { }

	// RVA: 0x25FCC80 Offset: 0x25FBE80 VA: 0x1825FCC80
	private void EndDragMove(bool cancelled) { }
}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnResizePreview : VisualElement // TypeDefIndex: 11849
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string visualUssClassName; // 0x8

	// Methods

	// RVA: 0x2606490 Offset: 0x2605690 VA: 0x182606490
	public void .ctor() { }

	// RVA: 0x26063C0 Offset: 0x26055C0 VA: 0x1826063C0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.Internal
internal class ColumnResizer : PointerManipulator // TypeDefIndex: 11850
{
	// Fields
	private Vector2 m_Start; // 0x38
	protected bool m_Active; // 0x40
	private bool m_Resizing; // 0x41
	private MultiColumnCollectionHeader m_Header; // 0x48
	private Column m_Column; // 0x50
	private VisualElement m_PreviewElement; // 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private ColumnLayout <columnLayout>k__BackingField; // 0x60
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <preview>k__BackingField; // 0x68

	// Properties
	public ColumnLayout columnLayout { get; set; }
	public bool preview { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public ColumnLayout get_columnLayout() { }

	[CompilerGenerated]
	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	public void set_columnLayout(ColumnLayout value) { }

	[CompilerGenerated]
	// RVA: 0x563E40 Offset: 0x563040 VA: 0x180563E40
	public bool get_preview() { }

	[CompilerGenerated]
	// RVA: 0x563E60 Offset: 0x563060 VA: 0x180563E60
	public void set_preview(bool value) { }

	// RVA: 0x25FFBA0 Offset: 0x25FEDA0 VA: 0x1825FFBA0
	public void .ctor(Column column) { }

	// RVA: 0x25FF660 Offset: 0x25FE860 VA: 0x1825FF660 Slot: 5
	protected override void RegisterCallbacksOnTarget() { }

	// RVA: 0x25FF860 Offset: 0x25FEA60 VA: 0x1825FF860 Slot: 6
	protected override void UnregisterCallbacksFromTarget() { }

	// RVA: 0x25FEF60 Offset: 0x25FE160 VA: 0x1825FEF60
	private void OnKeyDown(KeyDownEvent e) { }

	// RVA: 0x25FEFF0 Offset: 0x25FE1F0 VA: 0x1825FEFF0
	private void OnPointerDown(PointerDownEvent e) { }

	// RVA: 0x25FF380 Offset: 0x25FE580 VA: 0x1825FF380
	private void OnPointerMove(PointerMoveEvent e) { }

	// RVA: 0x25FF4D0 Offset: 0x25FE6D0 VA: 0x1825FF4D0
	private void OnPointerUp(PointerUpEvent e) { }

	// RVA: 0x25FEE60 Offset: 0x25FE060 VA: 0x1825FEE60
	private void BeginDragResize(float pos) { }

	// RVA: 0x25FEEB0 Offset: 0x25FE0B0 VA: 0x1825FEEB0
	private void DragResize(float pos) { }

	// RVA: 0x25FFA60 Offset: 0x25FEC60 VA: 0x1825FFA60
	private void UpdatePreviewPosition() { }

	// RVA: 0x25FEF00 Offset: 0x25FE100 VA: 0x1825FEF00
	private void EndDragResize(float pos, bool cancelled) { }
}

// Namespace: 
[Serializable]
private struct MultiColumnCollectionHeader.ViewState.ColumnState // TypeDefIndex: 11851
{
	// Fields
	public int index; // 0x0
	public string name; // 0x8
	public float actualWidth; // 0x10
	public Length width; // 0x14
	public bool visible; // 0x1C
}

// Namespace: 
[Serializable]
private class MultiColumnCollectionHeader.ViewState // TypeDefIndex: 11852
{
	// Fields
	[SerializeField]
	private bool m_HasPersistedData; // 0x10
	[SerializeField]
	private List<SortColumnDescription> m_SortDescriptions; // 0x18
	[SerializeField]
	private List<MultiColumnCollectionHeader.ViewState.ColumnState> m_OrderedColumnStates; // 0x20

	// Methods

	// RVA: 0x2611C60 Offset: 0x2610E60 VA: 0x182611C60
	internal void Save(MultiColumnCollectionHeader header) { }

	// RVA: 0x2611900 Offset: 0x2610B00 VA: 0x182611900
	internal void Apply(MultiColumnCollectionHeader header) { }

	// RVA: 0x2612290 Offset: 0x2611490 VA: 0x182612290
	public void .ctor() { }
}

// Namespace: 
internal class MultiColumnCollectionHeader.ColumnData // TypeDefIndex: 11853
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private MultiColumnHeaderColumn <control>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private MultiColumnHeaderColumnResizeHandle <resizeHandle>k__BackingField; // 0x18

	// Properties
	public MultiColumnHeaderColumn control { get; set; }
	public MultiColumnHeaderColumnResizeHandle resizeHandle { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public MultiColumnHeaderColumn get_control() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_control(MultiColumnHeaderColumn value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public MultiColumnHeaderColumnResizeHandle get_resizeHandle() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_resizeHandle(MultiColumnHeaderColumnResizeHandle value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private struct MultiColumnCollectionHeader.SortedColumnState // TypeDefIndex: 11854
{
	// Fields
	public SortColumnDescription columnDesc; // 0x0
	public SortDirection direction; // 0x8

	// Methods

	// RVA: 0x5511A0 Offset: 0x5503A0 VA: 0x1805511A0
	public void .ctor(SortColumnDescription desc, SortDirection dir) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MultiColumnCollectionHeader.<>c__DisplayClass65_0 // TypeDefIndex: 11855
{
	// Fields
	public Column column; // 0x10
	public MultiColumnCollectionHeader <>4__this; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x26115D0 Offset: 0x26107D0 VA: 0x1826115D0
	internal void <OnContextualMenuManipulator>b__1(DropdownMenuAction a) { }

	// RVA: 0x2611600 Offset: 0x2610800 VA: 0x182611600
	internal DropdownMenuAction.Status <OnContextualMenuManipulator>b__2(DropdownMenuAction a) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MultiColumnCollectionHeader.<>c__DisplayClass71_0 // TypeDefIndex: 11856
{
	// Fields
	public Column column; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2611690 Offset: 0x2610890 VA: 0x182611690
	internal bool <UpdateSortColumnDescriptionsOnClick>b__0(SortColumnDescription d) { }
}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnCollectionHeader : VisualElement, IDisposable // TypeDefIndex: 11857
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string columnContainerUssClassName; // 0x8
	public static readonly string handleContainerUssClassName; // 0x10
	public static readonly string reorderableUssClassName; // 0x18
	private bool m_SortingEnabled; // 0x3C8
	private List<SortColumnDescription> m_SortedColumns; // 0x3D0
	private SortColumnDescriptions m_SortDescriptions; // 0x3D8
	private List<MultiColumnCollectionHeader.SortedColumnState> m_OldSortedColumnStates; // 0x3E0
	private bool m_SortingUpdatesTemporarilyDisabled; // 0x3E8
	private MultiColumnCollectionHeader.ViewState m_ViewState; // 0x3F0
	private bool m_ApplyingViewState; // 0x3F8
	private bool m_DoLayoutScheduled; // 0x3F9
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Dictionary<Column, MultiColumnCollectionHeader.ColumnData> <columnDataMap>k__BackingField; // 0x400
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly ColumnLayout <columnLayout>k__BackingField; // 0x408
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly VisualElement <columnContainer>k__BackingField; // 0x410
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly VisualElement <resizeHandleContainer>k__BackingField; // 0x418
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly Columns <columns>k__BackingField; // 0x420
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<int, float> columnResized; // 0x428
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action columnSortingChanged; // 0x430
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<ContextualMenuPopulateEvent, Column> contextMenuPopulateEvent; // 0x438
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action viewDataRestored; // 0x440

	// Properties
	internal bool isApplyingViewState { get; }
	public Dictionary<Column, MultiColumnCollectionHeader.ColumnData> columnDataMap { get; }
	public ColumnLayout columnLayout { get; }
	public VisualElement columnContainer { get; }
	public VisualElement resizeHandleContainer { get; }
	public IEnumerable<SortColumnDescription> sortedColumns { get; }
	public SortColumnDescriptions sortDescriptions { get; set; }
	public Columns columns { get; }
	public bool sortingEnabled { get; set; }

	// Methods

	// RVA: 0x26059B0 Offset: 0x2604BB0 VA: 0x1826059B0
	internal bool get_isApplyingViewState() { }

	[CompilerGenerated]
	// RVA: 0xCA8980 Offset: 0xCA7B80 VA: 0x180CA8980
	public Dictionary<Column, MultiColumnCollectionHeader.ColumnData> get_columnDataMap() { }

	[CompilerGenerated]
	// RVA: 0xEB79E0 Offset: 0xEB6BE0 VA: 0x180EB79E0
	public ColumnLayout get_columnLayout() { }

	[CompilerGenerated]
	// RVA: 0xEB79D0 Offset: 0xEB6BD0 VA: 0x180EB79D0
	public VisualElement get_columnContainer() { }

	[CompilerGenerated]
	// RVA: 0x26059C0 Offset: 0x2604BC0 VA: 0x1826059C0
	public VisualElement get_resizeHandleContainer() { }

	// RVA: 0x26059D0 Offset: 0x2604BD0 VA: 0x1826059D0
	public IEnumerable<SortColumnDescription> get_sortedColumns() { }

	// RVA: 0x258E850 Offset: 0x258DA50 VA: 0x18258E850
	public SortColumnDescriptions get_sortDescriptions() { }

	// RVA: 0x2605CD0 Offset: 0x2604ED0 VA: 0x182605CD0
	protected internal void set_sortDescriptions(SortColumnDescriptions value) { }

	[CompilerGenerated]
	// RVA: 0x26059A0 Offset: 0x2604BA0 VA: 0x1826059A0
	public Columns get_columns() { }

	// RVA: 0x26059E0 Offset: 0x2604BE0 VA: 0x1826059E0
	public bool get_sortingEnabled() { }

	// RVA: 0x2605D70 Offset: 0x2604F70 VA: 0x182605D70
	public void set_sortingEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x26056C0 Offset: 0x26048C0 VA: 0x1826056C0
	public void add_columnResized(Action<int, float> value) { }

	[CompilerGenerated]
	// RVA: 0x26059F0 Offset: 0x2604BF0 VA: 0x1826059F0
	public void remove_columnResized(Action<int, float> value) { }

	[CompilerGenerated]
	// RVA: 0x2605780 Offset: 0x2604980 VA: 0x182605780
	public void add_columnSortingChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2605AB0 Offset: 0x2604CB0 VA: 0x182605AB0
	public void remove_columnSortingChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2605830 Offset: 0x2604A30 VA: 0x182605830
	public void add_contextMenuPopulateEvent(Action<ContextualMenuPopulateEvent, Column> value) { }

	[CompilerGenerated]
	// RVA: 0x2605B60 Offset: 0x2604D60 VA: 0x182605B60
	public void remove_contextMenuPopulateEvent(Action<ContextualMenuPopulateEvent, Column> value) { }

	[CompilerGenerated]
	// RVA: 0x26058F0 Offset: 0x2604AF0 VA: 0x1826058F0
	internal void add_viewDataRestored(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2605C20 Offset: 0x2604E20 VA: 0x182605C20
	internal void remove_viewDataRestored(Action value) { }

	// RVA: 0x2604F80 Offset: 0x2604180 VA: 0x182604F80
	public void .ctor(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) { }

	// RVA: 0x2603840 Offset: 0x2602A40 VA: 0x182603840
	private void ScheduleDoLayout() { }

	// RVA: 0x2603800 Offset: 0x2602A00 VA: 0x182603800
	private void ResizeToFit() { }

	// RVA: 0x26042F0 Offset: 0x26034F0 VA: 0x1826042F0
	private void UpdateSortedColumns() { }

	// RVA: 0x2603B70 Offset: 0x2602D70 VA: 0x182603B70
	private void UpdateColumnControls() { }

	// RVA: 0x2601BE0 Offset: 0x2600DE0 VA: 0x182601BE0
	private void OnColumnAdded(Column column, int index) { }

	// RVA: 0x2601BF0 Offset: 0x2600DF0 VA: 0x182601BF0
	private void OnColumnAdded(Column column) { }

	// RVA: 0x26026F0 Offset: 0x26018F0 VA: 0x1826026F0
	private void OnColumnRemoved(Column column) { }

	// RVA: 0x26020C0 Offset: 0x26012C0 VA: 0x1826020C0
	private void OnColumnChanged(Column column, ColumnDataType type) { }

	// RVA: 0x2602A20 Offset: 0x2601C20 VA: 0x182602A20
	private void OnColumnReordered(Column column, int from, int to) { }

	// RVA: 0x2602BF0 Offset: 0x2601DF0 VA: 0x182602BF0
	private void OnColumnResized(Column column) { }

	// RVA: 0x2602C30 Offset: 0x2601E30 VA: 0x182602C30
	private void OnContextualMenuManipulator(ContextualMenuPopulateEvent evt) { }

	// RVA: 0x2603510 Offset: 0x2602710 VA: 0x182603510
	private void OnMoveManipulatorActivated(ColumnMover mover) { }

	// RVA: 0x26033C0 Offset: 0x26025C0 VA: 0x1826033C0
	private void OnGeometryChanged(GeometryChangedEvent e) { }

	// RVA: 0x2601B80 Offset: 0x2600D80 VA: 0x182601B80
	private void DoLayout() { }

	// RVA: 0x2602320 Offset: 0x2601520 VA: 0x182602320
	private void OnColumnControlGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x2602150 Offset: 0x2601350 VA: 0x182602150
	private void OnColumnClicked(EventBase evt) { }

	// RVA: 0x26040A0 Offset: 0x26032A0 VA: 0x1826040A0
	private void UpdateSortColumnDescriptionsOnClick(Column column, EventModifiers modifiers) { }

	// RVA: 0x2603900 Offset: 0x2602B00 VA: 0x182603900
	public void ScrollHorizontally(float horizontalOffset) { }

	// RVA: 0x26036A0 Offset: 0x26028A0 VA: 0x1826036A0
	private void RaiseColumnResized(int columnIndex) { }

	// RVA: 0x26037C0 Offset: 0x26029C0 VA: 0x1826037C0
	private void RaiseColumnSortingChanged() { }

	// RVA: 0x2600E50 Offset: 0x2600050 VA: 0x182600E50
	private void ApplyColumnSorting() { }

	// RVA: 0x2604940 Offset: 0x2603B40 VA: 0x182604940
	private void UpdateSortingStatus() { }

	// RVA: 0x26035B0 Offset: 0x26027B0 VA: 0x1826035B0 Slot: 96
	internal override void OnViewDataReady() { }

	// RVA: 0x2602BF0 Offset: 0x2601DF0 VA: 0x182602BF0
	private void SaveViewState() { }

	// RVA: 0x2601570 Offset: 0x2600770 VA: 0x182601570
	private void CleanupColumnData(MultiColumnCollectionHeader.ColumnData data) { }

	// RVA: 0x26017B0 Offset: 0x26009B0 VA: 0x1826017B0 Slot: 100
	public void Dispose() { }

	// RVA: 0x2604E70 Offset: 0x2604070 VA: 0x182604E70
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2603800 Offset: 0x2602A00 VA: 0x182603800
	private void <OnContextualMenuManipulator>b__65_0(DropdownMenuAction a) { }
}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnSortIndicator : VisualElement // TypeDefIndex: 11858
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string arrowUssClassName; // 0x8
	public static readonly string indexLabelUssClassName; // 0x10
	private Label m_IndexLabel; // 0x3C8

	// Properties
	public string sortOrderLabel { set; }

	// Methods

	// RVA: 0x2606820 Offset: 0x2605A20 VA: 0x182606820
	public void set_sortOrderLabel(string value) { }

	// RVA: 0x26066A0 Offset: 0x26058A0 VA: 0x1826066A0
	public void .ctor() { }

	// RVA: 0x26065A0 Offset: 0x26057A0 VA: 0x1826065A0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnIcon : Image // TypeDefIndex: 11859
{
	// Fields
	public static readonly string ussClassName; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <isImageInline>k__BackingField; // 0x410

	// Properties
	public bool isImageInline { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xEB8A10 Offset: 0xEB7C10 VA: 0x180EB8A10
	public bool get_isImageInline() { }

	[CompilerGenerated]
	// RVA: 0x26060A0 Offset: 0x26052A0 VA: 0x1826060A0
	public void set_isImageInline(bool value) { }

	// RVA: 0x2605FB0 Offset: 0x26051B0 VA: 0x182605FB0
	public void .ctor() { }

	// RVA: 0x2605DC0 Offset: 0x2604FC0 VA: 0x182605DC0
	public void UpdateClassList() { }

	// RVA: 0x2605F20 Offset: 0x2605120 VA: 0x182605F20
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2605DB0 Offset: 0x2604FB0 VA: 0x182605DB0
	private void <.ctor>b__5_0(CustomStyleResolvedEvent evt) { }
}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumn : VisualElement // TypeDefIndex: 11860
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string sortableUssClassName; // 0x8
	public static readonly string sortedAscendingUssClassName; // 0x10
	public static readonly string sortedDescendingUssClassName; // 0x18
	public static readonly string movingUssClassName; // 0x20
	public static readonly string contentContainerUssClassName; // 0x28
	public static readonly string contentUssClassName; // 0x30
	public static readonly string defaultContentUssClassName; // 0x38
	public static readonly string hasIconUssClassName; // 0x40
	public static readonly string hasTitleUssClassName; // 0x48
	public static readonly string titleUssClassName; // 0x50
	public static readonly string iconElementName; // 0x58
	public static readonly string titleElementName; // 0x60
	private static readonly string s_BoundVEPropertyName; // 0x68
	private static readonly string s_BindingCallbackVEPropertyName; // 0x70
	private static readonly string s_UnbindingCallbackVEPropertyName; // 0x78
	private static readonly string s_DestroyCallbackVEPropertyName; // 0x80
	private VisualElement m_ContentContainer; // 0x3C8
	private VisualElement m_Content; // 0x3D0
	private MultiColumnHeaderColumnSortIndicator m_SortIndicatorContainer; // 0x3D8
	private IVisualElementScheduledItem m_ScheduledHeaderTemplateUpdate; // 0x3E0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Clickable <clickable>k__BackingField; // 0x3E8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private ColumnMover <mover>k__BackingField; // 0x3F0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Column <column>k__BackingField; // 0x3F8

	// Properties
	public Clickable clickable { get; set; }
	public ColumnMover mover { get; set; }
	public string sortOrderLabel { set; }
	public Column column { get; set; }
	public VisualElement content { get; set; }
	private bool isContentBound { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2608BC0 Offset: 0x2607DC0 VA: 0x182608BC0
	public Clickable get_clickable() { }

	[CompilerGenerated]
	// RVA: 0x2608CC0 Offset: 0x2607EC0 VA: 0x182608CC0
	private void set_clickable(Clickable value) { }

	[CompilerGenerated]
	// RVA: 0x2608CB0 Offset: 0x2607EB0 VA: 0x182608CB0
	public ColumnMover get_mover() { }

	[CompilerGenerated]
	// RVA: 0xEB92D0 Offset: 0xEB84D0 VA: 0x180EB92D0
	private void set_mover(ColumnMover value) { }

	// RVA: 0x2609010 Offset: 0x2608210 VA: 0x182609010
	public void set_sortOrderLabel(string value) { }

	[CompilerGenerated]
	// RVA: 0x2608BD0 Offset: 0x2607DD0 VA: 0x182608BD0
	public Column get_column() { }

	[CompilerGenerated]
	// RVA: 0x2608CD0 Offset: 0x2607ED0 VA: 0x182608CD0
	private void set_column(Column value) { }

	// RVA: 0x26059D0 Offset: 0x2604BD0 VA: 0x1826059D0
	public VisualElement get_content() { }

	// RVA: 0x2608CE0 Offset: 0x2607EE0 VA: 0x182608CE0
	public void set_content(VisualElement value) { }

	// RVA: 0x2608BE0 Offset: 0x2607DE0 VA: 0x182608BE0
	private bool get_isContentBound() { }

	// RVA: 0x2608F60 Offset: 0x2608160 VA: 0x182608F60
	private void set_isContentBound(bool value) { }

	// RVA: 0x2608210 Offset: 0x2607410 VA: 0x182608210
	public void .ctor(Column column) { }

	// RVA: 0x2607730 Offset: 0x2606930 VA: 0x182607730
	private void OnColumnChanged(Column c, ColumnDataType role) { }

	// RVA: 0x2607840 Offset: 0x2606A40 VA: 0x182607840
	private void OnColumnResized(Column c) { }

	// RVA: 0x2607340 Offset: 0x2606540 VA: 0x182607340
	private void InitManipulators() { }

	// RVA: 0x2607850 Offset: 0x2606A50 VA: 0x182607850
	private void OnMoverChanged(ColumnMover mv) { }

	// RVA: 0x26079E0 Offset: 0x2606BE0 VA: 0x1826079E0
	private void UpdateDataFromColumn() { }

	// RVA: 0x2606850 Offset: 0x2605A50 VA: 0x182606850
	private void BindHeaderContent() { }

	// RVA: 0x2607900 Offset: 0x2606B00 VA: 0x182607900
	private void UnbindHeaderContent() { }

	// RVA: 0x2606F60 Offset: 0x2606160 VA: 0x182606F60
	private void DestroyHeaderContent() { }

	// RVA: 0x2606930 Offset: 0x2605B30 VA: 0x182606930
	private VisualElement CreateDefaultHeaderContent() { }

	// RVA: 0x2606BB0 Offset: 0x2605DB0 VA: 0x182606BB0
	private void DefaultBindHeaderContent(VisualElement ve) { }

	// RVA: 0x2607C20 Offset: 0x2606E20 VA: 0x182607C20
	private void UpdateHeaderTemplate() { }

	// RVA: 0x2607AF0 Offset: 0x2606CF0 VA: 0x182607AF0
	private void UpdateGeometryFromColumn() { }

	// RVA: 0x2607120 Offset: 0x2606320 VA: 0x182607120
	public void Dispose() { }

	// RVA: 0x2607E30 Offset: 0x2607030 VA: 0x182607E30
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnResizeHandle : VisualElement // TypeDefIndex: 11861
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string dragAreaUssClassName; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly VisualElement <dragArea>k__BackingField; // 0x3C8

	// Properties
	public VisualElement dragArea { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xC789A0 Offset: 0xC77BA0 VA: 0x180C789A0
	public VisualElement get_dragArea() { }

	// RVA: 0x2612410 Offset: 0x2611610 VA: 0x182612410
	public void .ctor() { }

	// RVA: 0x2612340 Offset: 0x2611540 VA: 0x182612340
	private static void .cctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 // TypeDefIndex: 11862
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 11863
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 4E0024C7427C17CC639390B3368A37AF4019570161E69CF30B89796DCC90F605 /*Metadata offset 0x8DBCE0*/; // 0x0
}

// Namespace: 
internal class <Module> // TypeDefIndex: 11864
{}

// Namespace: 
internal static class SR // TypeDefIndex: 11865
{
	// Methods

	// RVA: 0x1EDD3E0 Offset: 0x1EDC5E0 VA: 0x181EDD3E0
	internal static string GetString(string name, object[] args) { }

	// RVA: 0x1576560 Offset: 0x1575760 VA: 0x181576560
	internal static string GetString(CultureInfo culture, string name, object[] args) { }

	// RVA: 0x1EDD370 Offset: 0x1EDC570 VA: 0x181EDD370
	internal static string Format(string resourceFormat, object p1) { }
}

// Namespace: Microsoft.CSharp
internal class CodeDomProvider // TypeDefIndex: 11866
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Microsoft.CSharp
internal class CSharpCodeProvider : CodeDomProvider // TypeDefIndex: 11867
{
	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System
[Usage(32767, AllowMultiple = True)]
internal class MonoTODOAttribute : Attribute // TypeDefIndex: 11868
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System
internal static class LocalAppContextSwitches // TypeDefIndex: 11869
{
	// Fields
	public static readonly bool IgnoreEmptyKeySequences; // 0x0
	public static readonly bool DontThrowOnInvalidSurrogatePairs; // 0x1
}

// Namespace: System.Xml
[Extension]
internal static class AsyncHelper // TypeDefIndex: 11870
{
	// Fields
	public static readonly Task DoneTask; // 0x0
	public static readonly Task<bool> DoneTaskTrue; // 0x8
	public static readonly Task<bool> DoneTaskFalse; // 0x10
	public static readonly Task<int> DoneTaskZero; // 0x18

	// Methods

	// RVA: 0x1ED3920 Offset: 0x1ED2B20 VA: 0x181ED3920
	private static void .cctor() { }
}

// Namespace: System.Xml
internal abstract class Base64Encoder // TypeDefIndex: 11871
{
	// Fields
	private byte[] leftOverBytes; // 0x10
	private int leftOverBytesCount; // 0x18
	private char[] charsLine; // 0x20

	// Methods

	// RVA: 0x1ED4000 Offset: 0x1ED3200 VA: 0x181ED4000
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void WriteChars(char[] chars, int index, int count);

	// RVA: 0x1ED3B80 Offset: 0x1ED2D80 VA: 0x181ED3B80
	internal void Encode(byte[] buffer, int index, int count) { }

	// RVA: 0x1ED3F30 Offset: 0x1ED3130 VA: 0x181ED3F30
	internal void Flush() { }
}

// Namespace: System.Xml
internal class XmlRawWriterBase64Encoder : Base64Encoder // TypeDefIndex: 11872
{
	// Fields
	private XmlRawWriter rawWriter; // 0x28

	// Methods

	// RVA: 0x1EDD530 Offset: 0x1EDC730 VA: 0x181EDD530
	internal void .ctor(XmlRawWriter rawWriter) { }

	// RVA: 0x1EDD500 Offset: 0x1EDC700 VA: 0x181EDD500 Slot: 4
	internal override void WriteChars(char[] chars, int index, int count) { }
}

// Namespace: System.Xml
internal class XmlTextWriterBase64Encoder : Base64Encoder // TypeDefIndex: 11873
{
	// Fields
	private XmlTextEncoder xmlTextEncoder; // 0x28

	// Methods

	// RVA: 0x1EDD530 Offset: 0x1EDC730 VA: 0x181EDD530
	internal void .ctor(XmlTextEncoder xmlTextEncoder) { }

	// RVA: 0x1EE9200 Offset: 0x1EE8400 VA: 0x181EE9200 Slot: 4
	internal override void WriteChars(char[] chars, int index, int count) { }
}

// Namespace: System.Xml
internal class BinHexDecoder : IncrementalReadDecoder // TypeDefIndex: 11874
{
	// Fields
	private byte[] buffer; // 0x10
	private int curIndex; // 0x18
	private int endIndex; // 0x1C
	private bool hasHalfByteCached; // 0x20
	private byte cachedHalfByte; // 0x21

	// Properties
	internal override bool IsFull { get; }

	// Methods

	// RVA: 0x1ED4700 Offset: 0x1ED3900 VA: 0x181ED4700 Slot: 4
	internal override bool get_IsFull() { }

	// RVA: 0x1ED44E0 Offset: 0x1ED36E0 VA: 0x181ED44E0 Slot: 5
	internal override int Decode(char[] chars, int startPos, int len) { }

	// RVA: 0x1ED4050 Offset: 0x1ED3250 VA: 0x181ED4050
	public static byte[] Decode(char[] chars, bool allowOddChars) { }

	// RVA: 0x1ED4360 Offset: 0x1ED3560 VA: 0x181ED4360
	private static void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, out int charsDecoded, out int bytesDecoded) { }
}

// Namespace: System.Xml
internal static class BinHexEncoder // TypeDefIndex: 11875
{
	// Methods

	// RVA: 0x1ED4710 Offset: 0x1ED3910 VA: 0x181ED4710
	internal static void Encode(byte[] buffer, int index, int count, XmlWriter writer) { }

	// RVA: 0x1ED4950 Offset: 0x1ED3B50 VA: 0x181ED4950
	internal static string Encode(byte[] inArray, int offsetIn, int count) { }

	// RVA: 0x1ED4B30 Offset: 0x1ED3D30 VA: 0x181ED4B30
	private static int Encode(byte[] inArray, int offsetIn, int count, char[] outArray) { }
}

// Namespace: System.Xml
internal enum BinXmlToken // TypeDefIndex: 11876
{
	// Fields
	public int value__; // 0x0
	public const BinXmlToken Error = 0;
	public const BinXmlToken NotImpl = -2;
	public const BinXmlToken EOF = -1;
	public const BinXmlToken XmlDecl = 254;
	public const BinXmlToken Encoding = 253;
	public const BinXmlToken DocType = 252;
	public const BinXmlToken System = 251;
	public const BinXmlToken Public = 250;
	public const BinXmlToken Subset = 249;
	public const BinXmlToken Element = 248;
	public const BinXmlToken EndElem = 247;
	public const BinXmlToken Attr = 246;
	public const BinXmlToken EndAttrs = 245;
	public const BinXmlToken PI = 244;
	public const BinXmlToken Comment = 243;
	public const BinXmlToken CData = 242;
	public const BinXmlToken EndCData = 241;
	public const BinXmlToken Name = 240;
	public const BinXmlToken QName = 239;
	public const BinXmlToken XmlText = 237;
	public const BinXmlToken Nest = 236;
	public const BinXmlToken EndNest = 235;
	public const BinXmlToken Extn = 234;
	public const BinXmlToken NmFlush = 233;
	public const BinXmlToken SQL_BIT = 6;
	public const BinXmlToken SQL_TINYINT = 7;
	public const BinXmlToken SQL_SMALLINT = 1;
	public const BinXmlToken SQL_INT = 2;
	public const BinXmlToken SQL_BIGINT = 8;
	public const BinXmlToken SQL_REAL = 3;
	public const BinXmlToken SQL_FLOAT = 4;
	public const BinXmlToken SQL_MONEY = 5;
	public const BinXmlToken SQL_SMALLMONEY = 20;
	public const BinXmlToken SQL_DATETIME = 18;
	public const BinXmlToken SQL_SMALLDATETIME = 19;
	public const BinXmlToken SQL_DECIMAL = 10;
	public const BinXmlToken SQL_NUMERIC = 11;
	public const BinXmlToken SQL_UUID = 9;
	public const BinXmlToken SQL_VARBINARY = 15;
	public const BinXmlToken SQL_BINARY = 12;
	public const BinXmlToken SQL_IMAGE = 23;
	public const BinXmlToken SQL_CHAR = 13;
	public const BinXmlToken SQL_VARCHAR = 16;
	public const BinXmlToken SQL_TEXT = 22;
	public const BinXmlToken SQL_NVARCHAR = 17;
	public const BinXmlToken SQL_NCHAR = 14;
	public const BinXmlToken SQL_NTEXT = 24;
	public const BinXmlToken SQL_UDT = 27;
	public const BinXmlToken XSD_KATMAI_DATE = 127;
	public const BinXmlToken XSD_KATMAI_DATETIME = 126;
	public const BinXmlToken XSD_KATMAI_TIME = 125;
	public const BinXmlToken XSD_KATMAI_DATEOFFSET = 124;
	public const BinXmlToken XSD_KATMAI_DATETIMEOFFSET = 123;
	public const BinXmlToken XSD_KATMAI_TIMEOFFSET = 122;
	public const BinXmlToken XSD_BOOLEAN = 134;
	public const BinXmlToken XSD_TIME = 129;
	public const BinXmlToken XSD_DATETIME = 130;
	public const BinXmlToken XSD_DATE = 131;
	public const BinXmlToken XSD_BINHEX = 132;
	public const BinXmlToken XSD_BASE64 = 133;
	public const BinXmlToken XSD_DECIMAL = 135;
	public const BinXmlToken XSD_BYTE = 136;
	public const BinXmlToken XSD_UNSIGNEDSHORT = 137;
	public const BinXmlToken XSD_UNSIGNEDINT = 138;
	public const BinXmlToken XSD_UNSIGNEDLONG = 139;
	public const BinXmlToken XSD_QNAME = 140;
}

// Namespace: System.Xml
internal struct BinXmlSqlDecimal // TypeDefIndex: 11877
{
	// Fields
	internal byte m_bLen; // 0x0
	internal byte m_bPrec; // 0x1
	internal byte m_bScale; // 0x2
	internal byte m_bSign; // 0x3
	internal uint m_data1; // 0x4
	internal uint m_data2; // 0x8
	internal uint m_data3; // 0xC
	internal uint m_data4; // 0x10
	private static readonly byte NUMERIC_MAX_PRECISION; // 0x0
	private static readonly byte MaxPrecision; // 0x1
	private static readonly byte MaxScale; // 0x2
	private static readonly int x_cNumeMax; // 0x4
	private static readonly long x_lInt32Base; // 0x8
	private static readonly ulong x_ulInt32Base; // 0x10
	private static readonly ulong x_ulInt32BaseForMod; // 0x18
	internal static readonly ulong x_llMax; // 0x20
	private static readonly double DUINT_BASE; // 0x28
	private static readonly double DUINT_BASE2; // 0x30
	private static readonly double DUINT_BASE3; // 0x38
	private static readonly uint[] x_rgulShiftBase; // 0x40
	private static readonly byte[] rgCLenFromPrec; // 0x48

	// Properties
	public bool IsPositive { get; }

	// Methods

	// RVA: 0x1ED88B0 Offset: 0x1ED7AB0 VA: 0x181ED88B0
	public bool get_IsPositive() { }

	// RVA: 0x1ED8530 Offset: 0x1ED7730 VA: 0x181ED8530
	public void .ctor(byte[] data, int offset, bool trim) { }

	// RVA: 0x160A450 Offset: 0x1609650 VA: 0x18160A450
	private static uint UIntFromByteArray(byte[] data, int offset) { }

	// RVA: 0x1ED7B70 Offset: 0x1ED6D70 VA: 0x181ED7B70
	private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

	// RVA: 0x1E59830 Offset: 0x1E58A30 VA: 0x181E59830
	private static void MpNormalize(uint[] rgulU, ref int ciulU) { }

	// RVA: 0x1E57680 Offset: 0x1E56880 VA: 0x181E57680
	private static char ChFromDigit(uint uiDigit) { }

	// RVA: 0x1ED7C70 Offset: 0x1ED6E70 VA: 0x181ED7C70
	public Decimal ToDecimal() { }

	// RVA: 0x1ED8110 Offset: 0x1ED7310 VA: 0x181ED8110
	private void TrimTrailingZeros() { }

	// RVA: 0x1ED7D80 Offset: 0x1ED6F80 VA: 0x181ED7D80 Slot: 3
	public override string ToString() { }

	// RVA: 0x1ED8360 Offset: 0x1ED7560 VA: 0x181ED8360
	private static void .cctor() { }
}

// Namespace: System.Xml
internal struct BinXmlSqlMoney // TypeDefIndex: 11878
{
	// Fields
	private long data; // 0x0

	// Methods

	// RVA: 0x17F7020 Offset: 0x17F6220 VA: 0x1817F7020
	public void .ctor(int v) { }

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void .ctor(long v) { }

	// RVA: 0x1ED88C0 Offset: 0x1ED7AC0 VA: 0x181ED88C0
	public Decimal ToDecimal() { }

	// RVA: 0x1ED8910 Offset: 0x1ED7B10 VA: 0x181ED8910 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Xml
internal abstract class BinXmlDateTime // TypeDefIndex: 11879
{
	// Fields
	internal static int[] KatmaiTimeScaleMultiplicator; // 0x0
	private static readonly double SQLTicksPerMillisecond; // 0x8
	public static readonly int SQLTicksPerSecond; // 0x10
	public static readonly int SQLTicksPerMinute; // 0x14
	public static readonly int SQLTicksPerHour; // 0x18
	private static readonly int SQLTicksPerDay; // 0x1C

	// Methods

	// RVA: 0x1779CF0 Offset: 0x1778EF0 VA: 0x181779CF0
	private static void Write2Dig(StringBuilder sb, int val) { }

	// RVA: 0x1ED5B60 Offset: 0x1ED4D60 VA: 0x181ED5B60
	private static void Write4DigNeg(StringBuilder sb, int val) { }

	// RVA: 0x1ED5A90 Offset: 0x1ED4C90 VA: 0x181ED5A90
	private static void Write3Dec(StringBuilder sb, int val) { }

	// RVA: 0x1ED5CB0 Offset: 0x1ED4EB0 VA: 0x181ED5CB0
	private static void WriteDate(StringBuilder sb, int yr, int mnth, int day) { }

	// RVA: 0x1ED62E0 Offset: 0x1ED54E0 VA: 0x181ED62E0
	private static void WriteTime(StringBuilder sb, int hr, int min, int sec, int ms) { }

	// RVA: 0x1ED5DF0 Offset: 0x1ED4FF0 VA: 0x181ED5DF0
	private static void WriteTimeFullPrecision(StringBuilder sb, int hr, int min, int sec, int fraction) { }

	// RVA: 0x1ED61E0 Offset: 0x1ED53E0 VA: 0x181ED61E0
	private static void WriteTimeZone(StringBuilder sb, TimeSpan zone) { }

	// RVA: 0x1ED6080 Offset: 0x1ED5280 VA: 0x181ED6080
	private static void WriteTimeZone(StringBuilder sb, bool negTimeZone, int hr, int min) { }

	// RVA: 0x1ED4CA0 Offset: 0x1ED3EA0 VA: 0x181ED4CA0
	private static void BreakDownXsdDateTime(long val, out int yr, out int mnth, out int day, out int hr, out int min, out int sec, out int ms) { }

	// RVA: 0x1ED4ED0 Offset: 0x1ED40D0 VA: 0x181ED4ED0
	private static void BreakDownXsdDate(long val, out int yr, out int mnth, out int day, out bool negTimeZone, out int hr, out int min) { }

	// RVA: 0x1ED5080 Offset: 0x1ED4280 VA: 0x181ED5080
	private static void BreakDownXsdTime(long val, out int hr, out int min, out int sec, out int ms) { }

	// RVA: 0x1ED6530 Offset: 0x1ED5730 VA: 0x181ED6530
	public static string XsdDateTimeToString(long val) { }

	// RVA: 0x1ED6850 Offset: 0x1ED5A50 VA: 0x181ED6850
	public static string XsdDateToString(long val) { }

	// RVA: 0x1ED7870 Offset: 0x1ED6A70 VA: 0x181ED7870
	public static string XsdTimeToString(long val) { }

	// RVA: 0x1ED5800 Offset: 0x1ED4A00 VA: 0x181ED5800
	public static string SqlDateTimeToString(int dateticks, uint timeticks) { }

	// RVA: 0x1ED5720 Offset: 0x1ED4920 VA: 0x181ED5720
	public static DateTime SqlDateTimeToDateTime(int dateticks, uint timeticks) { }

	// RVA: 0x1ED5980 Offset: 0x1ED4B80 VA: 0x181ED5980
	public static string SqlSmallDateTimeToString(short dateticks, ushort timeticks) { }

	// RVA: 0x1ED5910 Offset: 0x1ED4B10 VA: 0x181ED5910
	public static DateTime SqlSmallDateTimeToDateTime(short dateticks, ushort timeticks) { }

	// RVA: 0x1ED7200 Offset: 0x1ED6400 VA: 0x181ED7200
	public static DateTime XsdKatmaiDateToDateTime(byte[] data, int offset) { }

	// RVA: 0x1ED6FA0 Offset: 0x1ED61A0 VA: 0x181ED6FA0
	public static DateTime XsdKatmaiDateTimeToDateTime(byte[] data, int offset) { }

	// RVA: 0x1ED76A0 Offset: 0x1ED68A0 VA: 0x181ED76A0
	public static DateTime XsdKatmaiTimeToDateTime(byte[] data, int offset) { }

	// RVA: 0x1ED6AC0 Offset: 0x1ED5CC0 VA: 0x181ED6AC0
	public static DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x1ED6CC0 Offset: 0x1ED5EC0 VA: 0x181ED6CC0
	public static DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x1ED7480 Offset: 0x1ED6680 VA: 0x181ED7480
	public static DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x1ED72C0 Offset: 0x1ED64C0 VA: 0x181ED72C0
	public static string XsdKatmaiDateToString(byte[] data, int offset) { }

	// RVA: 0x1ED7070 Offset: 0x1ED6270 VA: 0x181ED7070
	public static string XsdKatmaiDateTimeToString(byte[] data, int offset) { }

	// RVA: 0x1ED7700 Offset: 0x1ED6900 VA: 0x181ED7700
	public static string XsdKatmaiTimeToString(byte[] data, int offset) { }

	// RVA: 0x1ED6B40 Offset: 0x1ED5D40 VA: 0x181ED6B40
	public static string XsdKatmaiDateOffsetToString(byte[] data, int offset) { }

	// RVA: 0x1ED6DE0 Offset: 0x1ED5FE0 VA: 0x181ED6DE0
	public static string XsdKatmaiDateTimeOffsetToString(byte[] data, int offset) { }

	// RVA: 0x1ED7500 Offset: 0x1ED6700 VA: 0x181ED7500
	public static string XsdKatmaiTimeOffsetToString(byte[] data, int offset) { }

	// RVA: 0x1ED5410 Offset: 0x1ED4610 VA: 0x181ED5410
	private static long GetKatmaiDateTicks(byte[] data, ref int pos) { }

	// RVA: 0x1ED5480 Offset: 0x1ED4680 VA: 0x181ED5480
	private static long GetKatmaiTimeTicks(byte[] data, ref int pos) { }

	// RVA: 0x1ED56D0 Offset: 0x1ED48D0 VA: 0x181ED56D0
	private static long GetKatmaiTimeZoneTicks(byte[] data, int pos) { }

	// RVA: 0x1ED5300 Offset: 0x1ED4500 VA: 0x181ED5300
	private static int GetFractions(DateTime dt) { }

	// RVA: 0x1ED51D0 Offset: 0x1ED43D0 VA: 0x181ED51D0
	private static int GetFractions(DateTimeOffset dt) { }

	// RVA: 0x1ED7A80 Offset: 0x1ED6C80 VA: 0x181ED7A80
	private static void .cctor() { }
}

// Namespace: 
private enum XmlSqlBinaryReader.ScanState // TypeDefIndex: 11880
{
	// Fields
	public int value__; // 0x0
	public const XmlSqlBinaryReader.ScanState Doc = 0;
	public const XmlSqlBinaryReader.ScanState XmlText = 1;
	public const XmlSqlBinaryReader.ScanState Attr = 2;
	public const XmlSqlBinaryReader.ScanState AttrVal = 3;
	public const XmlSqlBinaryReader.ScanState AttrValPseudoValue = 4;
	public const XmlSqlBinaryReader.ScanState Init = 5;
	public const XmlSqlBinaryReader.ScanState Error = 6;
	public const XmlSqlBinaryReader.ScanState EOF = 7;
	public const XmlSqlBinaryReader.ScanState Closed = 8;
}

// Namespace: 
internal struct XmlSqlBinaryReader.QName // TypeDefIndex: 11881
{
	// Fields
	public string prefix; // 0x0
	public string localname; // 0x8
	public string namespaceUri; // 0x10

	// Methods

	// RVA: 0xD45610 Offset: 0xD44810 VA: 0x180D45610
	public void .ctor(string prefix, string lname, string nsUri) { }

	// RVA: 0xD45610 Offset: 0xD44810 VA: 0x180D45610
	public void Set(string prefix, string lname, string nsUri) { }

	// RVA: 0x1EDD010 Offset: 0x1EDC210 VA: 0x181EDD010
	public void Clear() { }

	// RVA: 0x1ED3AF0 Offset: 0x1ED2CF0 VA: 0x181ED3AF0
	public bool MatchNs(string lname, string nsUri) { }

	// RVA: 0x1EDD230 Offset: 0x1EDC430 VA: 0x181EDD230
	public bool MatchPrefix(string prefix, string lname) { }

	// RVA: 0x1EDCF00 Offset: 0x1EDC100 VA: 0x181EDCF00
	public void CheckPrefixNS(string prefix, string namespaceUri) { }

	// RVA: 0x1EDD170 Offset: 0x1EDC370 VA: 0x181EDD170 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EDD1D0 Offset: 0x1EDC3D0 VA: 0x181EDD1D0
	public int GetNSHashCode(SecureStringHasher hasher) { }

	// RVA: 0x1EDD060 Offset: 0x1EDC260 VA: 0x181EDD060 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1EDD280 Offset: 0x1EDC480 VA: 0x181EDD280 Slot: 3
	public override string ToString() { }

	// RVA: 0x1EDD2E0 Offset: 0x1EDC4E0 VA: 0x181EDD2E0
	public static bool op_Equality(XmlSqlBinaryReader.QName a, XmlSqlBinaryReader.QName b) { }
}

// Namespace: 
private struct XmlSqlBinaryReader.ElemInfo // TypeDefIndex: 11882
{
	// Fields
	public XmlSqlBinaryReader.QName name; // 0x0
	public string xmlLang; // 0x18
	public XmlSpace xmlSpace; // 0x20
	public bool xmlspacePreserve; // 0x24
	public XmlSqlBinaryReader.NamespaceDecl nsdecls; // 0x28

	// Methods

	// RVA: 0x1ED9800 Offset: 0x1ED8A00 VA: 0x181ED9800
	public void Set(XmlSqlBinaryReader.QName name, bool xmlspacePreserve) { }

	// RVA: 0x1ED97F0 Offset: 0x1ED89F0 VA: 0x181ED97F0
	public XmlSqlBinaryReader.NamespaceDecl Clear() { }
}

// Namespace: 
private struct XmlSqlBinaryReader.AttrInfo // TypeDefIndex: 11883
{
	// Fields
	public XmlSqlBinaryReader.QName name; // 0x0
	public string val; // 0x18
	public int contentPos; // 0x20
	public int hashCode; // 0x24
	public int prevHash; // 0x28

	// Methods

	// RVA: 0x1ED3B60 Offset: 0x1ED2D60 VA: 0x181ED3B60
	public void Set(XmlSqlBinaryReader.QName n, string v) { }

	// RVA: 0x1ED3B40 Offset: 0x1ED2D40 VA: 0x181ED3B40
	public void Set(XmlSqlBinaryReader.QName n, int pos) { }

	// RVA: 0x1ED3A80 Offset: 0x1ED2C80 VA: 0x181ED3A80
	public void GetLocalnameAndNamespaceUri(out string localname, out string namespaceUri) { }

	// RVA: 0x1ED3A10 Offset: 0x1ED2C10 VA: 0x181ED3A10
	public int GetLocalnameAndNamespaceUriAndHash(SecureStringHasher hasher, out string localname, out string namespaceUri) { }

	// RVA: 0x1ED3AF0 Offset: 0x1ED2CF0 VA: 0x181ED3AF0
	public bool MatchNS(string localname, string namespaceUri) { }

	// RVA: 0x1ED3A90 Offset: 0x1ED2C90 VA: 0x181ED3A90
	public bool MatchHashNS(int hash, string localname, string namespaceUri) { }

	// RVA: 0x1ED3A00 Offset: 0x1ED2C00 VA: 0x181ED3A00
	public void AdjustPosition(int adj) { }
}

// Namespace: 
private class XmlSqlBinaryReader.NamespaceDecl // TypeDefIndex: 11884
{
	// Fields
	public string prefix; // 0x10
	public string uri; // 0x18
	public XmlSqlBinaryReader.NamespaceDecl scopeLink; // 0x20
	public XmlSqlBinaryReader.NamespaceDecl prevLink; // 0x28
	public int scope; // 0x30
	public bool implied; // 0x34

	// Methods

	// RVA: 0x1EDCE40 Offset: 0x1EDC040 VA: 0x181EDCE40
	public void .ctor(string prefix, string nsuri, XmlSqlBinaryReader.NamespaceDecl nextInScope, XmlSqlBinaryReader.NamespaceDecl prevDecl, int scope, bool implied) { }
}

// Namespace: 
private struct XmlSqlBinaryReader.SymbolTables // TypeDefIndex: 11885
{
	// Fields
	public string[] symtable; // 0x0
	public int symCount; // 0x8
	public XmlSqlBinaryReader.QName[] qnametable; // 0x10
	public int qnameCount; // 0x18

	// Methods

	// RVA: 0x1EDD450 Offset: 0x1EDC650 VA: 0x181EDD450
	public void Init() { }
}

// Namespace: 
private class XmlSqlBinaryReader.NestedBinXml // TypeDefIndex: 11886
{
	// Fields
	public XmlSqlBinaryReader.SymbolTables symbolTables; // 0x10
	public int docState; // 0x30
	public XmlSqlBinaryReader.NestedBinXml next; // 0x38

	// Methods

	// RVA: 0x1EDCEA0 Offset: 0x1EDC0A0 VA: 0x181EDCEA0
	public void .ctor(XmlSqlBinaryReader.SymbolTables symbolTables, int docState, XmlSqlBinaryReader.NestedBinXml next) { }
}

// Namespace: System.Xml
internal sealed class XmlSqlBinaryReader : XmlReader, IXmlNamespaceResolver // TypeDefIndex: 11887
{
	// Fields
	internal static readonly Type TypeOfObject; // 0x0
	internal static readonly Type TypeOfString; // 0x8
	private static Type[] TokenTypeMap; // 0x10
	private static byte[] XsdKatmaiTimeScaleToValueLengthMap; // 0x18
	private static ReadState[] ScanState2ReadState; // 0x20
	private Stream inStrm; // 0x10
	private byte[] data; // 0x18
	private int pos; // 0x20
	private int mark; // 0x24
	private int end; // 0x28
	private long offset; // 0x30
	private bool eof; // 0x38
	private bool sniffed; // 0x39
	private bool isEmpty; // 0x3A
	private int docState; // 0x3C
	private XmlSqlBinaryReader.SymbolTables symbolTables; // 0x40
	private XmlNameTable xnt; // 0x60
	private bool xntFromSettings; // 0x68
	private string xml; // 0x70
	private string xmlns; // 0x78
	private string nsxmlns; // 0x80
	private string baseUri; // 0x88
	private XmlSqlBinaryReader.ScanState state; // 0x90
	private XmlNodeType nodetype; // 0x94
	private BinXmlToken token; // 0x98
	private int attrIndex; // 0x9C
	private XmlSqlBinaryReader.QName qnameOther; // 0xA0
	private XmlSqlBinaryReader.QName qnameElement; // 0xB8
	private XmlNodeType parentNodeType; // 0xD0
	private XmlSqlBinaryReader.ElemInfo[] elementStack; // 0xD8
	private int elemDepth; // 0xE0
	private XmlSqlBinaryReader.AttrInfo[] attributes; // 0xE8
	private int[] attrHashTbl; // 0xF0
	private int attrCount; // 0xF8
	private int posAfterAttrs; // 0xFC
	private bool xmlspacePreserve; // 0x100
	private int tokLen; // 0x104
	private int tokDataPos; // 0x108
	private bool hasTypedValue; // 0x10C
	private Type valueType; // 0x110
	private string stringValue; // 0x118
	private Dictionary<string, XmlSqlBinaryReader.NamespaceDecl> namespaces; // 0x120
	private XmlSqlBinaryReader.NestedBinXml prevNameInfo; // 0x128
	private XmlReader textXmlReader; // 0x130
	private bool closeInput; // 0x138
	private bool checkCharacters; // 0x139
	private bool ignoreWhitespace; // 0x13A
	private bool ignorePIs; // 0x13B
	private bool ignoreComments; // 0x13C
	private DtdProcessing dtdProcessing; // 0x140
	private SecureStringHasher hasher; // 0x148
	private XmlCharType xmlCharType; // 0x150
	private Encoding unicode; // 0x158
	private byte version; // 0x160

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override bool HasValue { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override Type ValueType { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override XmlNameTable NameTable { get; }
	public override ReadState ReadState { get; }

	// Methods

	// RVA: 0x1EE83C0 Offset: 0x1EE75C0 VA: 0x181EE83C0
	public void .ctor(Stream stream, byte[] data, int len, string baseUri, bool closeInput, XmlReaderSettings settings) { }

	// RVA: 0x1EE8BF0 Offset: 0x1EE7DF0 VA: 0x181EE8BF0 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x772200 Offset: 0x771400 VA: 0x180772200 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x7960B0 Offset: 0x7952B0 VA: 0x1807960B0 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x796070 Offset: 0x795270 VA: 0x180796070 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1EE8AC0 Offset: 0x1EE7CC0 VA: 0x181EE8AC0 Slot: 11
	public override bool get_HasValue() { }

	// RVA: 0x1EE8D00 Offset: 0x1EE7F00 VA: 0x181EE8D00 Slot: 12
	public override string get_Value() { }

	// RVA: 0x1EE89E0 Offset: 0x1EE7BE0 VA: 0x181EE89E0 Slot: 13
	public override int get_Depth() { }

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870 Slot: 14
	public override string get_BaseURI() { }

	// RVA: 0x1EE8B50 Offset: 0x1EE7D50 VA: 0x181EE8B50 Slot: 15
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1EE9170 Offset: 0x1EE8370 VA: 0x181EE9170 Slot: 18
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1EE90B0 Offset: 0x1EE82B0 VA: 0x181EE90B0 Slot: 19
	public override string get_XmlLang() { }

	// RVA: 0x6ED520 Offset: 0x6EC720 VA: 0x1806ED520 Slot: 21
	public override Type get_ValueType() { }

	// RVA: 0x1EE8980 Offset: 0x1EE7B80 VA: 0x181EE8980 Slot: 23
	public override int get_AttributeCount() { }

	// RVA: 0x1EDF640 Offset: 0x1EDE840 VA: 0x181EDF640 Slot: 25
	public override string GetAttribute(string name, string ns) { }

	// RVA: 0x1EDF7D0 Offset: 0x1EDE9D0 VA: 0x181EDF7D0 Slot: 24
	public override string GetAttribute(string name) { }

	// RVA: 0x1EDF590 Offset: 0x1EDE790 VA: 0x181EDF590 Slot: 26
	public override string GetAttribute(int i) { }

	// RVA: 0x1EE17B0 Offset: 0x1EE09B0 VA: 0x181EE17B0 Slot: 27
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1EE1700 Offset: 0x1EE0900 VA: 0x181EE1700 Slot: 28
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1EE1940 Offset: 0x1EE0B40 VA: 0x181EE1940 Slot: 29
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1EE19D0 Offset: 0x1EE0BD0 VA: 0x181EE19D0 Slot: 30
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1EE1840 Offset: 0x1EE0A40 VA: 0x181EE1840 Slot: 31
	public override bool MoveToElement() { }

	// RVA: 0x1EE8AB0 Offset: 0x1EE7CB0 VA: 0x181EE8AB0 Slot: 34
	public override bool get_EOF() { }

	// RVA: 0x1EE2990 Offset: 0x1EE1B90 VA: 0x181EE2990 Slot: 32
	public override bool ReadAttributeValue() { }

	// RVA: 0x1EDDF80 Offset: 0x1EDD180 VA: 0x181EDDF80 Slot: 35
	public override void Close() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860 Slot: 38
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1EE1640 Offset: 0x1EE0840 VA: 0x181EE1640 Slot: 39
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1EE4360 Offset: 0x1EE3560 VA: 0x181EE4360 Slot: 41
	public override void ResolveEntity() { }

	// RVA: 0x1EE8B70 Offset: 0x1EE7D70 VA: 0x181EE8B70 Slot: 36
	public override ReadState get_ReadState() { }

	// RVA: 0x1EE3F30 Offset: 0x1EE3130 VA: 0x181EE3F30 Slot: 33
	public override bool Read() { }

	// RVA: 0x1EE56D0 Offset: 0x1EE48D0 VA: 0x181EE56D0 Slot: 57
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1EE5A50 Offset: 0x1EE4C50 VA: 0x181EE5A50 Slot: 59
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1EE7FE0 Offset: 0x1EE71E0 VA: 0x181EE7FE0
	private void VerifyVersion(int requiredVersion, BinXmlToken token) { }

	// RVA: 0x1EDD590 Offset: 0x1EDC790 VA: 0x181EDD590
	private void AddInitNamespace(string prefix, string uri) { }

	// RVA: 0x1EDD690 Offset: 0x1EDC890 VA: 0x181EDD690
	private void AddName() { }

	// RVA: 0x1EDD7D0 Offset: 0x1EDC9D0 VA: 0x181EDD7D0
	private void AddQName() { }

	// RVA: 0x1EE1A80 Offset: 0x1EE0C80 VA: 0x181EE1A80
	private void NameFlush() { }

	// RVA: 0x1EE55A0 Offset: 0x1EE47A0 VA: 0x181EE55A0
	private void SkipExtn() { }

	// RVA: 0x1EE3B90 Offset: 0x1EE2D90 VA: 0x181EE3B90
	private int ReadQNameRef() { }

	// RVA: 0x1EE3AC0 Offset: 0x1EE2CC0 VA: 0x181EE3AC0
	private int ReadNameRef() { }

	// RVA: 0x1EDE010 Offset: 0x1EDD210 VA: 0x181EDE010
	private bool FillAllowEOF() { }

	// RVA: 0x1EDE250 Offset: 0x1EDD450 VA: 0x181EDE250
	private void Fill_(int require) { }

	// RVA: 0x1EDE2D0 Offset: 0x1EDD4D0 VA: 0x181EDE2D0
	private void Fill(int require) { }

	// RVA: 0x1EE2B90 Offset: 0x1EE1D90 VA: 0x181EE2B90
	private byte ReadByte() { }

	// RVA: 0x1EE3ED0 Offset: 0x1EE30D0 VA: 0x181EE3ED0
	private ushort ReadUShort() { }

	// RVA: 0x1EE2080 Offset: 0x1EE1280 VA: 0x181EE2080
	private int ParseMB32() { }

	// RVA: 0x1EE1F20 Offset: 0x1EE1120 VA: 0x181EE1F20
	private int ParseMB32_(byte b) { }

	// RVA: 0x1EE20E0 Offset: 0x1EE12E0 VA: 0x181EE20E0
	private int ParseMB32(int pos) { }

	// RVA: 0x1EE2080 Offset: 0x1EE1280 VA: 0x181EE2080
	private int ParseMB64() { }

	// RVA: 0x1EE22E0 Offset: 0x1EE14E0 VA: 0x181EE22E0
	private BinXmlToken PeekToken() { }

	// RVA: 0x1EE3C60 Offset: 0x1EE2E60 VA: 0x181EE3C60
	private BinXmlToken ReadToken() { }

	// RVA: 0x1EE1B50 Offset: 0x1EE0D50 VA: 0x181EE1B50
	private BinXmlToken NextToken2(BinXmlToken token) { }

	// RVA: 0x1EE1AE0 Offset: 0x1EE0CE0 VA: 0x181EE1AE0
	private BinXmlToken NextToken1() { }

	// RVA: 0x1EE1E80 Offset: 0x1EE1080 VA: 0x181EE1E80
	private BinXmlToken NextToken() { }

	// RVA: 0x1EE22C0 Offset: 0x1EE14C0 VA: 0x181EE22C0
	private BinXmlToken PeekNextToken() { }

	// RVA: 0x1EE40B0 Offset: 0x1EE32B0 VA: 0x181EE40B0
	private BinXmlToken RescanNextToken() { }

	// RVA: 0x1EE2200 Offset: 0x1EE1400 VA: 0x181EE2200
	private string ParseText() { }

	// RVA: 0x1EE52F0 Offset: 0x1EE44F0 VA: 0x181EE52F0
	private int ScanText(out int start) { }

	// RVA: 0x1EDFC50 Offset: 0x1EDEE50 VA: 0x181EDFC50
	private string GetString(int pos, int cch) { }

	// RVA: 0x1EDFC10 Offset: 0x1EDEE10 VA: 0x181EDFC10
	private string GetStringAligned(byte[] data, int offset, int cch) { }

	// RVA: 0x1EDF410 Offset: 0x1EDE610 VA: 0x181EDF410
	private string GetAttributeText(int i) { }

	// RVA: 0x1EE14A0 Offset: 0x1EE06A0 VA: 0x181EE14A0
	private int LocateAttribute(string name, string ns) { }

	// RVA: 0x1EE1550 Offset: 0x1EE0750 VA: 0x181EE1550
	private int LocateAttribute(string name) { }

	// RVA: 0x1EE2610 Offset: 0x1EE1810 VA: 0x181EE2610
	private void PositionOnAttribute(int i) { }

	// RVA: 0x1EE0100 Offset: 0x1EDF300 VA: 0x181EE0100
	private void GrowElements() { }

	// RVA: 0x1EE0070 Offset: 0x1EDF270 VA: 0x181EE0070
	private void GrowAttributes() { }

	// RVA: 0x1EDDF60 Offset: 0x1EDD160 VA: 0x181EDDF60
	private void ClearAttributes() { }

	// RVA: 0x1EE2710 Offset: 0x1EE1910 VA: 0x181EE2710
	private void PushNamespace(string prefix, string ns, bool implied) { }

	// RVA: 0x1EE2550 Offset: 0x1EE1750 VA: 0x181EE2550
	private void PopNamespaces(XmlSqlBinaryReader.NamespaceDecl firstInScopeChain) { }

	// RVA: 0x1EDE4F0 Offset: 0x1EDD6F0 VA: 0x181EDE4F0
	private void GenerateImpliedXmlnsAttrs() { }

	// RVA: 0x1EE3550 Offset: 0x1EE2750 VA: 0x181EE3550
	private bool ReadInit(bool skipXmlDecl) { }

	// RVA: 0x1EE43A0 Offset: 0x1EE35A0 VA: 0x181EE43A0
	private void ScanAttributes() { }

	// RVA: 0x1EE5450 Offset: 0x1EE4650 VA: 0x181EE5450
	private void SimpleCheckForDuplicateAttributes() { }

	// RVA: 0x1EE01A0 Offset: 0x1EDF3A0 VA: 0x181EE01A0
	private void HashCheckForDuplicateAttributes() { }

	// RVA: 0x1EE8030 Offset: 0x1EE7230 VA: 0x181EE8030
	private string XmlDeclValue() { }

	// RVA: 0x1EDDA80 Offset: 0x1EDCC80 VA: 0x181EDDA80
	private string CDATAValue() { }

	// RVA: 0x1EDE360 Offset: 0x1EDD560 VA: 0x181EDE360
	private void FinishCDATA() { }

	// RVA: 0x1EDE400 Offset: 0x1EDD600 VA: 0x181EDE400
	private void FinishEndElement() { }

	// RVA: 0x1EE2BE0 Offset: 0x1EE1DE0 VA: 0x181EE2BE0
	private bool ReadDoc() { }

	// RVA: 0x1EE0570 Offset: 0x1EDF770 VA: 0x181EE0570
	private void ImplReadData(BinXmlToken tokenType) { }

	// RVA: 0x1EE0A50 Offset: 0x1EDFC50 VA: 0x181EE0A50
	private void ImplReadElement() { }

	// RVA: 0x1EE0D80 Offset: 0x1EDFF80 VA: 0x181EE0D80
	private void ImplReadEndElement() { }

	// RVA: 0x1EE0700 Offset: 0x1EDF900 VA: 0x181EE0700
	private void ImplReadDoctype() { }

	// RVA: 0x1EE1040 Offset: 0x1EE0240 VA: 0x181EE1040
	private void ImplReadPI() { }

	// RVA: 0x1EE0530 Offset: 0x1EDF730 VA: 0x181EE0530
	private void ImplReadComment() { }

	// RVA: 0x1EE04A0 Offset: 0x1EDF6A0 VA: 0x181EE04A0
	private void ImplReadCDATA() { }

	// RVA: 0x1EE0EA0 Offset: 0x1EE00A0 VA: 0x181EE0EA0
	private void ImplReadNest() { }

	// RVA: 0x1EE0E60 Offset: 0x1EE0060 VA: 0x181EE0E60
	private void ImplReadEndNest() { }

	// RVA: 0x1EE10B0 Offset: 0x1EE02B0 VA: 0x181EE10B0
	private void ImplReadXmlText() { }

	// RVA: 0x1EE5E80 Offset: 0x1EE5080 VA: 0x181EE5E80
	private void UpdateFromTextReader() { }

	// RVA: 0x1EE5F60 Offset: 0x1EE5160 VA: 0x181EE5F60
	private bool UpdateFromTextReader(bool needUpdate) { }

	// RVA: 0x1EDDBB0 Offset: 0x1EDCDB0 VA: 0x181EDDBB0
	private void CheckAllowContent() { }

	// RVA: 0x1EDE6A0 Offset: 0x1EDD8A0 VA: 0x181EDE6A0
	private void GenerateTokenTypeMap() { }

	// RVA: 0x1EDFE20 Offset: 0x1EDF020 VA: 0x181EDFE20
	private Type GetValueType(BinXmlToken token) { }

	// RVA: 0x1EE2970 Offset: 0x1EE1B70 VA: 0x181EE2970
	private void ReScanOverValue(BinXmlToken token) { }

	// RVA: 0x1EE50D0 Offset: 0x1EE42D0 VA: 0x181EE50D0
	private XmlNodeType ScanOverValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0x1EE4A60 Offset: 0x1EE3C60 VA: 0x181EE4A60
	private XmlNodeType ScanOverAnyValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0x1EDDCB0 Offset: 0x1EDCEB0 VA: 0x181EDDCB0
	private XmlNodeType CheckText(bool attr) { }

	// RVA: 0x1EDDC10 Offset: 0x1EDCE10 VA: 0x181EDDC10
	private XmlNodeType CheckTextIsWS() { }

	// RVA: 0x1EDDF00 Offset: 0x1EDD100 VA: 0x181EDDF00
	private void CheckValueTokenBounds() { }

	// RVA: 0x1EDFF10 Offset: 0x1EDF110 VA: 0x181EDFF10
	private int GetXsdKatmaiTokenLength(BinXmlToken token) { }

	// RVA: 0x1EE8190 Offset: 0x1EE7390 VA: 0x181EE8190
	private int XsdKatmaiTimeScaleToValueLength(byte scale) { }

	// RVA: 0x1EE70E0 Offset: 0x1EE62E0 VA: 0x181EE70E0
	private long ValueAsLong() { }

	// RVA: 0x1EE7F40 Offset: 0x1EE7140 VA: 0x181EE7F40
	private ulong ValueAsULong() { }

	// RVA: 0x1EE6BC0 Offset: 0x1EE5DC0 VA: 0x181EE6BC0
	private Decimal ValueAsDecimal() { }

	// RVA: 0x1EE6EE0 Offset: 0x1EE60E0 VA: 0x181EE6EE0
	private double ValueAsDouble() { }

	// RVA: 0x1EE5F80 Offset: 0x1EE5180 VA: 0x181EE5F80
	private string ValueAsDateTimeString() { }

	// RVA: 0x1EE7620 Offset: 0x1EE6820 VA: 0x181EE7620
	private string ValueAsString(BinXmlToken token) { }

	// RVA: 0x1EDF9A0 Offset: 0x1EDEBA0 VA: 0x181EDF9A0
	private short GetInt16(int pos) { }

	// RVA: 0x1EDF9A0 Offset: 0x1EDEBA0 VA: 0x181EDF9A0
	private ushort GetUInt16(int pos) { }

	// RVA: 0x1EDF9F0 Offset: 0x1EDEBF0 VA: 0x181EDF9F0
	private int GetInt32(int pos) { }

	// RVA: 0x1EDF9F0 Offset: 0x1EDEBF0 VA: 0x181EDF9F0
	private uint GetUInt32(int pos) { }

	// RVA: 0x1EDFA70 Offset: 0x1EDEC70 VA: 0x181EDFA70
	private long GetInt64(int pos) { }

	// RVA: 0x1EDFA70 Offset: 0x1EDEC70 VA: 0x181EDFA70
	private ulong GetUInt64(int pos) { }

	// RVA: 0x1EDFB90 Offset: 0x1EDED90 VA: 0x181EDFB90
	private float GetSingle(int offset) { }

	// RVA: 0x1EDF840 Offset: 0x1EDEA40 VA: 0x181EDF840
	private double GetDouble(int offset) { }

	// RVA: 0x1EE5CB0 Offset: 0x1EE4EB0 VA: 0x181EE5CB0
	private Exception ThrowUnexpectedToken(BinXmlToken token) { }

	// RVA: 0x1EE5E10 Offset: 0x1EE5010 VA: 0x181EE5E10
	private Exception ThrowXmlException(string res) { }

	// RVA: 0x1EE5D40 Offset: 0x1EE4F40 VA: 0x181EE5D40
	private Exception ThrowXmlException(string res, string arg1, string arg2) { }

	// RVA: 0x1EE5C40 Offset: 0x1EE4E40 VA: 0x181EE5C40
	private Exception ThrowNotSupported(string res) { }

	// RVA: 0x1EE8260 Offset: 0x1EE7460 VA: 0x181EE8260
	private static void .cctor() { }
}

// Namespace: System.Xml
internal class BitStack // TypeDefIndex: 11888
{
	// Fields
	private uint[] bitStack; // 0x10
	private int stackPos; // 0x18
	private uint curr; // 0x1C

	// Methods

	// RVA: 0x1ED8C60 Offset: 0x1ED7E60 VA: 0x181ED8C60
	public void .ctor() { }

	// RVA: 0x1ED8AA0 Offset: 0x1ED7CA0 VA: 0x181ED8AA0
	public void PushBit(bool bit) { }

	// RVA: 0x1ED8A00 Offset: 0x1ED7C00 VA: 0x181ED8A00
	public bool PopBit() { }

	// RVA: 0x1ED89F0 Offset: 0x1ED7BF0 VA: 0x181ED89F0
	public bool PeekBit() { }

	// RVA: 0x1ED8B90 Offset: 0x1ED7D90 VA: 0x181ED8B90
	private void PushCurr() { }

	// RVA: 0x1ED8A60 Offset: 0x1ED7C60 VA: 0x181ED8A60
	private void PopCurr() { }
}

// Namespace: System.Xml
internal static class Bits // TypeDefIndex: 11889
{
	// Fields
	private static readonly uint MASK_0101010101010101; // 0x0
	private static readonly uint MASK_0011001100110011; // 0x4
	private static readonly uint MASK_0000111100001111; // 0x8
	private static readonly uint MASK_0000000011111111; // 0xC
	private static readonly uint MASK_1111111111111111; // 0x10

	// Methods

	// RVA: 0x1ED8C80 Offset: 0x1ED7E80 VA: 0x181ED8C80
	public static int Count(uint num) { }

	// RVA: 0x1ED8D20 Offset: 0x1ED7F20 VA: 0x181ED8D20
	public static int LeastPosition(uint num) { }

	// RVA: 0x1ED8E20 Offset: 0x1ED8020 VA: 0x181ED8E20
	private static void .cctor() { }
}

// Namespace: System.Xml
internal class ByteStack // TypeDefIndex: 11890
{
	// Fields
	private byte[] stack; // 0x10
	private int growthRate; // 0x18
	private int top; // 0x1C
	private int size; // 0x20

	// Methods

	// RVA: 0x1ED8FC0 Offset: 0x1ED81C0 VA: 0x181ED8FC0
	public void .ctor(int growthRate) { }

	// RVA: 0x1ED8F00 Offset: 0x1ED8100 VA: 0x181ED8F00
	public void Push(byte data) { }

	// RVA: 0x1ED8EB0 Offset: 0x1ED80B0 VA: 0x181ED8EB0
	public byte Pop() { }
}

// Namespace: System.Xml
internal class CharEntityEncoderFallback : EncoderFallback // TypeDefIndex: 11891
{
	// Fields
	private CharEntityEncoderFallbackBuffer fallbackBuffer; // 0x10
	private int[] textContentMarks; // 0x18
	private int endMarkPos; // 0x20
	private int curMarkPos; // 0x24
	private int startOffset; // 0x28

	// Properties
	public override int MaxCharCount { get; }
	internal int StartOffset { set; }

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	internal void .ctor() { }

	// RVA: 0x1ED9730 Offset: 0x1ED8930 VA: 0x181ED9730 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0xAA0160 Offset: 0xA9F360 VA: 0x180AA0160 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	internal void set_StartOffset(int value) { }

	// RVA: 0x1ED97E0 Offset: 0x1ED89E0 VA: 0x181ED97E0
	internal void Reset(int[] textContentMarks, int endMarkPos) { }

	// RVA: 0x1ED96D0 Offset: 0x1ED88D0 VA: 0x181ED96D0
	internal bool CanReplaceAt(int index) { }
}

// Namespace: System.Xml
internal class CharEntityEncoderFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 11892
{
	// Fields
	private CharEntityEncoderFallback parent; // 0x30
	private string charEntity; // 0x38
	private int charEntityIndex; // 0x40

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x1ED9630 Offset: 0x1ED8830 VA: 0x181ED9630
	internal void .ctor(CharEntityEncoderFallback parent) { }

	// RVA: 0x1ED9020 Offset: 0x1ED8220 VA: 0x181ED9020 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x1ED92A0 Offset: 0x1ED84A0 VA: 0x181ED92A0 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x1ED95A0 Offset: 0x1ED87A0 VA: 0x181ED95A0 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x1ED95F0 Offset: 0x1ED87F0 VA: 0x181ED95F0 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x1ED96A0 Offset: 0x1ED88A0 VA: 0x181ED96A0 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x1ED9610 Offset: 0x1ED8810 VA: 0x181ED9610 Slot: 9
	public override void Reset() { }

	// RVA: 0x1ED9620 Offset: 0x1ED8820 VA: 0x181ED9620
	private int SurrogateCharToUtf32(char highSurrogate, char lowSurrogate) { }
}

// Namespace: System.Xml
public enum ConformanceLevel // TypeDefIndex: 11893
{
	// Fields
	public int value__; // 0x0
	public const ConformanceLevel Auto = 0;
	public const ConformanceLevel Fragment = 1;
	public const ConformanceLevel Document = 2;
}

// Namespace: System.Xml
public enum DtdProcessing // TypeDefIndex: 11894
{
	// Fields
	public int value__; // 0x0
	public const DtdProcessing Prohibit = 0;
	public const DtdProcessing Ignore = 1;
	public const DtdProcessing Parse = 2;
}

// Namespace: System.Xml
public enum EntityHandling // TypeDefIndex: 11895
{
	// Fields
	public int value__; // 0x0
	public const EntityHandling ExpandEntities = 1;
	public const EntityHandling ExpandCharEntities = 2;
}

// Namespace: System.Xml
internal class HtmlEncodedRawTextWriter : XmlEncodedRawTextWriter // TypeDefIndex: 11896
{
	// Fields
	protected ByteStack elementScope; // 0xC0
	protected ElementProperties currentElementProperties; // 0xC8
	private AttributeProperties currentAttributeProperties; // 0xCC
	private bool endsWithAmpersand; // 0xD0
	private byte[] uriEscapingBuffer; // 0xD8
	private string mediaType; // 0xE0
	private bool doNotEscapeUriAttributes; // 0xE8
	protected static TernaryTreeReadOnly elementPropertySearch; // 0x0
	protected static TernaryTreeReadOnly attributePropertySearch; // 0x8

	// Methods

	// RVA: 0x1EDB580 Offset: 0x1EDA780 VA: 0x181EDB580
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1EDB5B0 Offset: 0x1EDA7B0 VA: 0x181EDB5B0
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 44
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 45
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1EDA2F0 Offset: 0x1ED94F0 VA: 0x181EDA2F0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1EDAF60 Offset: 0x1EDA160 VA: 0x181EDAF60 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1EDA1A0 Offset: 0x1ED93A0 VA: 0x181EDA1A0 Slot: 46
	internal override void StartElementContent() { }

	// RVA: 0x1EDA5A0 Offset: 0x1ED97A0 VA: 0x181EDA5A0 Slot: 48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1EDA730 Offset: 0x1ED9930 VA: 0x181EDA730 Slot: 49
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1EDADE0 Offset: 0x1ED9FE0 VA: 0x181EDADE0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1EDA510 Offset: 0x1ED9710 VA: 0x181EDA510 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1EDACB0 Offset: 0x1ED9EB0 VA: 0x181EDACB0 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x1EDB090 Offset: 0x1EDA290 VA: 0x181EDB090 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1EDA6D0 Offset: 0x1ED98D0 VA: 0x181EDA6D0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1EDA200 Offset: 0x1ED9400 VA: 0x181EDA200 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1EDB180 Offset: 0x1EDA380 VA: 0x181EDB180 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1EDA260 Offset: 0x1ED9460 VA: 0x181EDA260 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1ED9F30 Offset: 0x1ED9130 VA: 0x181ED9F30
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x1EDABB0 Offset: 0x1ED9DB0 VA: 0x181EDABB0
	protected void WriteMetaElement() { }

	// RVA: 0x1EDAB90 Offset: 0x1ED9D90 VA: 0x181EDAB90
	protected void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1EDA860 Offset: 0x1ED9A60 VA: 0x181EDA860
	protected void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1EDA8B0 Offset: 0x1ED9AB0 VA: 0x181EDA8B0
	private void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1EDB1E0 Offset: 0x1EDA3E0 VA: 0x181EDB1E0
	private void WriteUriAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1EDA100 Offset: 0x1ED9300 VA: 0x181EDA100
	private void OutputRestAmps() { }
}

// Namespace: System.Xml
internal class HtmlEncodedRawTextWriterIndent : HtmlEncodedRawTextWriter // TypeDefIndex: 11897
{
	// Fields
	private int indentLevel; // 0xF0
	private int endBlockPos; // 0xF4
	private string indentChars; // 0xF8
	private bool newLineOnAttributes; // 0x100

	// Methods

	// RVA: 0x1ED9ED0 Offset: 0x1ED90D0 VA: 0x181ED9ED0
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1ED9E70 Offset: 0x1ED9070 VA: 0x181ED9E70
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1ED9950 Offset: 0x1ED8B50 VA: 0x181ED9950 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1ED9C80 Offset: 0x1ED8E80 VA: 0x181ED9C80 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1ED9880 Offset: 0x1ED8A80 VA: 0x181ED9880 Slot: 46
	internal override void StartElementContent() { }

	// RVA: 0x1ED9980 Offset: 0x1ED8B80 VA: 0x181ED9980 Slot: 48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1ED9BC0 Offset: 0x1ED8DC0 VA: 0x181ED9BC0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1ED9820 Offset: 0x1ED8A20 VA: 0x181ED9820 Slot: 56
	protected override void FlushBuffer() { }

	// RVA: 0x1ED9840 Offset: 0x1ED8A40 VA: 0x181ED9840
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x1ED9B60 Offset: 0x1ED8D60 VA: 0x181ED9B60
	private void WriteIndent() { }
}

// Namespace: System.Xml
internal abstract class HtmlTernaryTree // TypeDefIndex: 11898
{
	// Fields
	internal static byte[] htmlElements; // 0x0
	internal static byte[] htmlAttributes; // 0x8

	// Methods

	// RVA: 0x1EDB5E0 Offset: 0x1EDA7E0 VA: 0x181EDB5E0
	private static void .cctor() { }
}

// Namespace: System.Xml
internal class HtmlUtf8RawTextWriter : XmlUtf8RawTextWriter // TypeDefIndex: 11899
{
	// Fields
	protected ByteStack elementScope; // 0x90
	protected ElementProperties currentElementProperties; // 0x98
	private AttributeProperties currentAttributeProperties; // 0x9C
	private bool endsWithAmpersand; // 0xA0
	private byte[] uriEscapingBuffer; // 0xA8
	private string mediaType; // 0xB0
	private bool doNotEscapeUriAttributes; // 0xB8
	protected static TernaryTreeReadOnly elementPropertySearch; // 0x0
	protected static TernaryTreeReadOnly attributePropertySearch; // 0x8

	// Methods

	// RVA: 0x1EDCC60 Offset: 0x1EDBE60 VA: 0x181EDCC60
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 44
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 45
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1EDBB00 Offset: 0x1EDAD00 VA: 0x181EDBB00 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1EDC670 Offset: 0x1EDB870 VA: 0x181EDC670 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1EDB910 Offset: 0x1EDAB10 VA: 0x181EDB910 Slot: 46
	internal override void StartElementContent() { }

	// RVA: 0x1EDBD60 Offset: 0x1EDAF60 VA: 0x181EDBD60 Slot: 48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1EDBED0 Offset: 0x1EDB0D0 VA: 0x181EDBED0 Slot: 49
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1EDC510 Offset: 0x1EDB710 VA: 0x181EDC510 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1EDBCF0 Offset: 0x1EDAEF0 VA: 0x181EDBCF0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1EDC410 Offset: 0x1EDB610 VA: 0x181EDC410 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x1EDC780 Offset: 0x1EDB980 VA: 0x181EDC780 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1EDBE70 Offset: 0x1EDB070 VA: 0x181EDBE70 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1EDBA50 Offset: 0x1EDAC50 VA: 0x181EDBA50 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1EDC860 Offset: 0x1EDBA60 VA: 0x181EDC860 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1EDBAB0 Offset: 0x1EDACB0 VA: 0x181EDBAB0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1EDB6A0 Offset: 0x1EDA8A0 VA: 0x181EDB6A0
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x1EDC310 Offset: 0x1EDB510 VA: 0x181EDC310
	protected void WriteMetaElement() { }

	// RVA: 0x1EDC2F0 Offset: 0x1EDB4F0 VA: 0x181EDC2F0
	protected void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1EDBFE0 Offset: 0x1EDB1E0 VA: 0x181EDBFE0
	protected void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1EDC030 Offset: 0x1EDB230 VA: 0x181EDC030
	private void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1EDC8C0 Offset: 0x1EDBAC0 VA: 0x181EDC8C0
	private void WriteUriAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1EDB870 Offset: 0x1EDAA70 VA: 0x181EDB870
	private void OutputRestAmps() { }
}

// Namespace: System.Xml
internal class HtmlUtf8RawTextWriterIndent : HtmlUtf8RawTextWriter // TypeDefIndex: 11900
{
	// Fields
	private int indentLevel; // 0xC0
	private int endBlockPos; // 0xC4
	private string indentChars; // 0xC8
	private bool newLineOnAttributes; // 0xD0

	// Methods

	// RVA: 0x1FE06F0 Offset: 0x1FDF8F0 VA: 0x181FE06F0
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1FE01B0 Offset: 0x1FDF3B0 VA: 0x181FE01B0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1FE03D0 Offset: 0x1FDF5D0 VA: 0x181FE03D0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1FE00F0 Offset: 0x1FDF2F0 VA: 0x181FE00F0 Slot: 46
	internal override void StartElementContent() { }

	// RVA: 0x1FE01E0 Offset: 0x1FDF3E0 VA: 0x181FE01E0 Slot: 48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1FE0310 Offset: 0x1FDF510 VA: 0x181FE0310 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1FE0090 Offset: 0x1FDF290 VA: 0x181FE0090 Slot: 56
	protected override void FlushBuffer() { }

	// RVA: 0x1FE00B0 Offset: 0x1FDF2B0 VA: 0x181FE00B0
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x1FE02C0 Offset: 0x1FDF4C0 VA: 0x181FE02C0
	private void WriteIndent() { }
}

// Namespace: System.Xml
internal interface IDtdInfo // TypeDefIndex: 11901
{
	// Properties
	public abstract XmlQualifiedName Name { get; }
	public abstract string InternalDtdSubset { get; }
	public abstract bool HasDefaultAttributes { get; }
	public abstract bool HasNonCDataAttributes { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlQualifiedName get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_InternalDtdSubset();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_HasDefaultAttributes();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_HasNonCDataAttributes();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IDtdAttributeListInfo LookupAttributeList(string prefix, string localName);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IDtdEntityInfo LookupEntity(string name);
}

// Namespace: System.Xml
internal interface IDtdAttributeListInfo // TypeDefIndex: 11902
{
	// Properties
	public abstract bool HasNonCDataAttributes { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_HasNonCDataAttributes();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDtdAttributeInfo LookupAttribute(string prefix, string localName);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IEnumerable<IDtdDefaultAttributeInfo> LookupDefaultAttributes();
}

// Namespace: System.Xml
internal interface IDtdAttributeInfo // TypeDefIndex: 11903
{
	// Properties
	public abstract string Prefix { get; }
	public abstract string LocalName { get; }
	public abstract int LineNumber { get; }
	public abstract int LinePosition { get; }
	public abstract bool IsNonCDataType { get; }
	public abstract bool IsDeclaredInExternal { get; }
	public abstract bool IsXmlAttribute { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Prefix();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_LocalName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_LineNumber();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_LinePosition();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsNonCDataType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsDeclaredInExternal();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsXmlAttribute();
}

// Namespace: System.Xml
internal interface IDtdDefaultAttributeInfo : IDtdAttributeInfo // TypeDefIndex: 11904
{
	// Properties
	public abstract string DefaultValueExpanded { get; }
	public abstract object DefaultValueTyped { get; }
	public abstract int ValueLineNumber { get; }
	public abstract int ValueLinePosition { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_DefaultValueExpanded();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object get_DefaultValueTyped();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_ValueLineNumber();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_ValueLinePosition();
}

// Namespace: System.Xml
internal interface IDtdEntityInfo // TypeDefIndex: 11905
{
	// Properties
	public abstract string Name { get; }
	public abstract bool IsExternal { get; }
	public abstract bool IsDeclaredInExternal { get; }
	public abstract bool IsUnparsedEntity { get; }
	public abstract bool IsParameterEntity { get; }
	public abstract string BaseUriString { get; }
	public abstract string DeclaredUriString { get; }
	public abstract string SystemId { get; }
	public abstract string PublicId { get; }
	public abstract string Text { get; }
	public abstract int LineNumber { get; }
	public abstract int LinePosition { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsExternal();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsDeclaredInExternal();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsUnparsedEntity();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsParameterEntity();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_BaseUriString();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_DeclaredUriString();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_SystemId();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_PublicId();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_Text();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int get_LineNumber();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int get_LinePosition();
}

// Namespace: System.Xml
internal interface IDtdParser // TypeDefIndex: 11906
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDtdInfo ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDtdInfo ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter);
}

// Namespace: System.Xml
internal interface IDtdParserAdapter // TypeDefIndex: 11907
{
	// Properties
	public abstract XmlNameTable NameTable { get; }
	public abstract IXmlNamespaceResolver NamespaceResolver { get; }
	public abstract Uri BaseUri { get; }
	public abstract char[] ParsingBuffer { get; }
	public abstract int ParsingBufferLength { get; }
	public abstract int CurrentPosition { get; set; }
	public abstract int LineNo { get; }
	public abstract int LineStartPosition { get; }
	public abstract bool IsEof { get; }
	public abstract int EntityStackLength { get; }
	public abstract bool IsEntityEolNormalized { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlNameTable get_NameTable();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IXmlNamespaceResolver get_NamespaceResolver();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Uri get_BaseUri();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract char[] get_ParsingBuffer();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_ParsingBufferLength();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_CurrentPosition();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void set_CurrentPosition(int value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_LineNo();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_LineStartPosition();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_IsEof();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int get_EntityStackLength();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool get_IsEntityEolNormalized();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int ReadData();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void OnNewLine(int pos);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int ParseNumericCharRef(StringBuilder internalSubsetBuilder);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void ParsePI(StringBuilder sb);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void ParseComment(StringBuilder sb);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract bool PushEntity(IDtdEntityInfo entity, out int entityId);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract bool PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool PushExternalSubset(string systemId, string publicId);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void PushInternalDtd(string baseUri, string internalDtd);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void Throw(Exception e);
}

// Namespace: System.Xml
internal interface IDtdParserAdapterWithValidation : IDtdParserAdapter // TypeDefIndex: 11908
{
	// Properties
	public abstract bool DtdValidation { get; }
	public abstract IValidationEventHandling ValidationEventHandling { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_DtdValidation();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IValidationEventHandling get_ValidationEventHandling();
}

// Namespace: System.Xml
internal interface IDtdParserAdapterV1 : IDtdParserAdapterWithValidation, IDtdParserAdapter // TypeDefIndex: 11909
{
	// Properties
	public abstract bool V1CompatibilityMode { get; }
	public abstract bool Normalization { get; }
	public abstract bool Namespaces { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_V1CompatibilityMode();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_Normalization();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_Namespaces();
}

// Namespace: System.Xml
internal sealed class OnRemoveWriter : MulticastDelegate // TypeDefIndex: 11910
{
	// Methods

	// RVA: 0x3FD260 Offset: 0x3FC460 VA: 0x1803FD260
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(XmlRawWriter writer) { }
}

// Namespace: System.Xml
internal interface IValidationEventHandling // TypeDefIndex: 11911
{
	// Properties
	public abstract object EventHandler { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_EventHandler();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SendEvent(Exception exception, XmlSeverityType severity);
}

// Namespace: System.Xml
internal abstract class IncrementalReadDecoder // TypeDefIndex: 11912
{
	// Properties
	internal abstract bool IsFull { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract bool get_IsFull();

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract int Decode(char[] chars, int startPos, int len);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: System.Xml
internal class IncrementalReadDummyDecoder : IncrementalReadDecoder // TypeDefIndex: 11913
{
	// Properties
	internal override bool IsFull { get; }

	// Methods

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 4
	internal override bool get_IsFull() { }

	// RVA: 0x1FE0740 Offset: 0x1FDF940 VA: 0x181FE0740 Slot: 5
	internal override int Decode(char[] chars, int startPos, int len) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Xml
[Flags]
public enum NamespaceHandling // TypeDefIndex: 11914
{
	// Fields
	public int value__; // 0x0
	public const NamespaceHandling Default = 0;
	public const NamespaceHandling OmitDuplicates = 1;
}

// Namespace: System.Xml
public enum NewLineHandling // TypeDefIndex: 11915
{
	// Fields
	public int value__; // 0x0
	public const NewLineHandling Replace = 0;
	public const NewLineHandling Entitize = 1;
	public const NewLineHandling None = 2;
}

// Namespace: System.Xml
internal class QueryOutputWriter : XmlRawWriter // TypeDefIndex: 11916
{
	// Fields
	private XmlRawWriter wrapped; // 0x28
	private bool inCDataSection; // 0x30
	private Dictionary<XmlQualifiedName, int> lookupCDataElems; // 0x38
	private BitStack bitsCData; // 0x40
	private XmlQualifiedName qnameCData; // 0x48
	private bool outputDocType; // 0x50
	private bool checkWellFormedDoc; // 0x51
	private bool hasDocElem; // 0x52
	private bool inAttr; // 0x53
	private string systemId; // 0x58
	private string publicId; // 0x60
	private int depth; // 0x68

	// Properties
	internal override IXmlNamespaceResolver NamespaceResolver { set; }
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x1FE1300 Offset: 0x1FE0500 VA: 0x181FE1300
	public void .ctor(XmlRawWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1FE15A0 Offset: 0x1FE07A0 VA: 0x181FE15A0 Slot: 43
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x1FE12A0 Offset: 0x1FE04A0 VA: 0x181FE12A0 Slot: 44
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1FE12D0 Offset: 0x1FE04D0 VA: 0x181FE12D0 Slot: 45
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1FE0B60 Offset: 0x1FDFD60 VA: 0x181FE0B60 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1FE0F20 Offset: 0x1FE0120 VA: 0x181FE0F20 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1FE0BE0 Offset: 0x1FDFDE0 VA: 0x181FE0BE0 Slot: 48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1FE0CA0 Offset: 0x1FDFEA0 VA: 0x181FE0CA0 Slot: 49
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x173D350 Offset: 0x173C550 VA: 0x18173D350 Slot: 46
	internal override void StartElementContent() { }

	// RVA: 0x1FE0EE0 Offset: 0x1FE00E0 VA: 0x181FE0EE0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1FE0BB0 Offset: 0x1FDFDB0 VA: 0x181FE0BB0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1FE0D00 Offset: 0x1FDFF00 VA: 0x181FE0D00 Slot: 50
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x1FE1570 Offset: 0x1FE0770 VA: 0x181FE1570 Slot: 51
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1FE1100 Offset: 0x1FE0300 VA: 0x181FE1100 Slot: 52
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1FE0C40 Offset: 0x1FDFE40 VA: 0x181FE0C40 Slot: 53
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1FE09F0 Offset: 0x1FDFBF0 VA: 0x181FE09F0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1FE0B30 Offset: 0x1FDFD30 VA: 0x181FE0B30 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1FE0D30 Offset: 0x1FDFF30 VA: 0x181FE0D30 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1FE1200 Offset: 0x1FE0400 VA: 0x181FE1200 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1FE1130 Offset: 0x1FE0330 VA: 0x181FE1130 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1FE0A50 Offset: 0x1FDFC50 VA: 0x181FE0A50 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1FE0C70 Offset: 0x1FDFE70 VA: 0x181FE0C70 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1FE0A20 Offset: 0x1FDFC20 VA: 0x181FE0A20 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1FE11D0 Offset: 0x1FE03D0 VA: 0x181FE11D0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1FE0D60 Offset: 0x1FDFF60 VA: 0x181FE0D60 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1FE0E40 Offset: 0x1FE0040 VA: 0x181FE0E40 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1FE08D0 Offset: 0x1FDFAD0 VA: 0x181FE08D0 Slot: 28
	public override void Close() { }

	// RVA: 0x1FE0980 Offset: 0x1FDFB80 VA: 0x181FE0980 Slot: 29
	public override void Flush() { }

	// RVA: 0x1FE09B0 Offset: 0x1FDFBB0 VA: 0x181FE09B0
	private bool StartCDataSection() { }

	// RVA: 0x723A20 Offset: 0x722C20 VA: 0x180723A20
	private void EndCDataSection() { }
}

// Namespace: 
private enum ReadContentAsBinaryHelper.State // TypeDefIndex: 11917
{
	// Fields
	public int value__; // 0x0
	public const ReadContentAsBinaryHelper.State None = 0;
	public const ReadContentAsBinaryHelper.State InReadContent = 1;
	public const ReadContentAsBinaryHelper.State InReadElementContent = 2;
}

// Namespace: System.Xml
internal class ReadContentAsBinaryHelper // TypeDefIndex: 11918
{
	// Fields
	private XmlReader reader; // 0x10
	private ReadContentAsBinaryHelper.State state; // 0x18
	private int valueOffset; // 0x1C
	private bool isEnd; // 0x20

	// Methods

	// RVA: 0x1FE15D0 Offset: 0x1FE07D0 VA: 0x181FE15D0
	internal void Finish() { }

	// RVA: 0x1FE1970 Offset: 0x1FE0B70 VA: 0x181FE1970
	internal void Reset() { }

	// RVA: 0x1FE1820 Offset: 0x1FE0A20 VA: 0x181FE1820
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }
}

// Namespace: System.Xml
internal enum ElementProperties // TypeDefIndex: 11919
{
	// Fields
	public uint value__; // 0x0
	public const ElementProperties DEFAULT = 0;
	public const ElementProperties URI_PARENT = 1;
	public const ElementProperties BOOL_PARENT = 2;
	public const ElementProperties NAME_PARENT = 4;
	public const ElementProperties EMPTY = 8;
	public const ElementProperties NO_ENTITIES = 16;
	public const ElementProperties HEAD = 32;
	public const ElementProperties BLOCK_WS = 64;
	public const ElementProperties HAS_NS = 128;
}

// Namespace: System.Xml
internal enum AttributeProperties // TypeDefIndex: 11920
{
	// Fields
	public uint value__; // 0x0
	public const AttributeProperties DEFAULT = 0;
	public const AttributeProperties URI = 1;
	public const AttributeProperties BOOLEAN = 2;
	public const AttributeProperties NAME = 4;
}

// Namespace: System.Xml
internal class TernaryTreeReadOnly // TypeDefIndex: 11921
{
	// Fields
	private byte[] nodeBuffer; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(byte[] nodeBuffer) { }

	// RVA: 0x1FE1CC0 Offset: 0x1FE0EC0 VA: 0x181FE1CC0
	public byte FindCaseInsensitiveString(string stringToFind) { }
}

// Namespace: System.Xml
public enum ReadState // TypeDefIndex: 11922
{
	// Fields
	public int value__; // 0x0
	public const ReadState Initial = 0;
	public const ReadState Interactive = 1;
	public const ReadState Error = 2;
	public const ReadState EndOfFile = 3;
	public const ReadState Closed = 4;
}

// Namespace: 
private sealed class SecureStringHasher.HashCodeOfStringDelegate : MulticastDelegate // TypeDefIndex: 11923
{
	// Methods

	// RVA: 0x1FDFFE0 Offset: 0x1FDF1E0 VA: 0x181FDFFE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual int Invoke(string s, int sLen, long additionalEntropy) { }
}

// Namespace: System.Xml
internal class SecureStringHasher : IEqualityComparer<string> // TypeDefIndex: 11924
{
	// Fields
	private static SecureStringHasher.HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private int hashCodeRandomizer; // 0x10

	// Methods

	// RVA: 0x1FE1CA0 Offset: 0x1FE0EA0 VA: 0x181FE1CA0
	public void .ctor() { }

	// RVA: 0x1FE1980 Offset: 0x1FE0B80 VA: 0x181FE1980 Slot: 4
	public bool Equals(string x, string y) { }

	// RVA: 0x1FE1BF0 Offset: 0x1FE0DF0 VA: 0x181FE1BF0 Slot: 5
	public int GetHashCode(string key) { }

	// RVA: 0x1FE1B70 Offset: 0x1FE0D70 VA: 0x181FE1B70
	private static int GetHashCodeOfString(string key, int sLen, long additionalEntropy) { }

	// RVA: 0x1FE19A0 Offset: 0x1FE0BA0 VA: 0x181FE19A0
	private static SecureStringHasher.HashCodeOfStringDelegate GetHashCodeDelegate() { }
}

// Namespace: System.Xml
internal class TextEncodedRawTextWriter : XmlEncodedRawTextWriter // TypeDefIndex: 11925
{
	// Properties
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x1FE1FA0 Offset: 0x1FE11A0 VA: 0x181FE1FA0
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1FE2080 Offset: 0x1FE1280 VA: 0x181FE2080
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 44
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 45
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 49
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 46
	internal override void StartElementContent() { }

	// RVA: 0x1FE1F90 Offset: 0x1FE1190 VA: 0x181FE1F90 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1FE1F10 Offset: 0x1FE1110 VA: 0x181FE1F10 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 50
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 51
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1FE1E10 Offset: 0x1FE1010 VA: 0x181FE1E10 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1FE1F20 Offset: 0x1FE1120 VA: 0x181FE1F20 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1FE1F20 Offset: 0x1FE1120 VA: 0x181FE1F20 Slot: 20
	public override void WriteString(string textBlock) { }

	// RVA: 0x1FE1E80 Offset: 0x1FE1080 VA: 0x181FE1E80 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1FE1E80 Offset: 0x1FE1080 VA: 0x181FE1E80 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1FE1F20 Offset: 0x1FE1120 VA: 0x181FE1F20 Slot: 24
	public override void WriteRaw(string data) { }
}

// Namespace: System.Xml
internal class TextUtf8RawTextWriter : XmlUtf8RawTextWriter // TypeDefIndex: 11926
{
	// Properties
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x1FE20D0 Offset: 0x1FE12D0 VA: 0x181FE20D0
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 44
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 45
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 49
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 46
	internal override void StartElementContent() { }

	// RVA: 0x1FE1F90 Offset: 0x1FE1190 VA: 0x181FE1F90 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1FE1F10 Offset: 0x1FE1110 VA: 0x181FE1F10 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 50
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 51
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1FE2090 Offset: 0x1FE1290 VA: 0x181FE2090 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1FE20C0 Offset: 0x1FE12C0 VA: 0x181FE20C0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1FE20C0 Offset: 0x1FE12C0 VA: 0x181FE20C0 Slot: 20
	public override void WriteString(string textBlock) { }

	// RVA: 0x1FE20A0 Offset: 0x1FE12A0 VA: 0x181FE20A0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1FE20A0 Offset: 0x1FE12A0 VA: 0x181FE20A0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1FE20C0 Offset: 0x1FE12C0 VA: 0x181FE20C0 Slot: 24
	public override void WriteRaw(string data) { }
}

// Namespace: System.Xml
internal class ValidatingReaderNodeData // TypeDefIndex: 11927
{
	// Fields
	private string localName; // 0x10
	private string namespaceUri; // 0x18
	private string prefix; // 0x20
	private string nameWPrefix; // 0x28
	private string rawValue; // 0x30
	private string originalStringValue; // 0x38
	private int depth; // 0x40
	private AttributePSVIInfo attributePSVIInfo; // 0x48
	private XmlNodeType nodeType; // 0x50
	private int lineNo; // 0x54
	private int linePos; // 0x58

	// Properties
	public string LocalName { get; set; }
	public string Namespace { get; set; }
	public string Prefix { get; set; }
	public int Depth { get; set; }
	public string RawValue { get; set; }
	public string OriginalStringValue { get; }
	public XmlNodeType NodeType { get; set; }
	public AttributePSVIInfo AttInfo { get; set; }
	public int LineNumber { get; }
	public int LinePosition { get; }

	// Methods

	// RVA: 0x1FE2390 Offset: 0x1FE1590 VA: 0x181FE2390
	public void .ctor() { }

	// RVA: 0x1FE2360 Offset: 0x1FE1560 VA: 0x181FE2360
	public void .ctor(XmlNodeType nodeType) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_LocalName() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalName(string value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Namespace() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Namespace(string value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Prefix() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Prefix(string value) { }

	// RVA: 0x1FE2190 Offset: 0x1FE1390 VA: 0x181FE2190
	public string GetAtomizedNameWPrefix(XmlNameTable nameTable) { }

	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440
	public int get_Depth() { }

	// RVA: 0x433450 Offset: 0x432650 VA: 0x180433450
	public void set_Depth(int value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_RawValue() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_RawValue(string value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_OriginalStringValue() { }

	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410
	public XmlNodeType get_NodeType() { }

	// RVA: 0x430630 Offset: 0x42F830 VA: 0x180430630
	public void set_NodeType(XmlNodeType value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public AttributePSVIInfo get_AttInfo() { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_AttInfo(AttributePSVIInfo value) { }

	// RVA: 0x4D1A40 Offset: 0x4D0C40 VA: 0x1804D1A40
	public int get_LineNumber() { }

	// RVA: 0x4EDB20 Offset: 0x4ECD20 VA: 0x1804EDB20
	public int get_LinePosition() { }

	// RVA: 0x1FE20E0 Offset: 0x1FE12E0 VA: 0x181FE20E0
	internal void Clear(XmlNodeType nodeType) { }

	// RVA: 0x1FE2350 Offset: 0x1FE1550 VA: 0x181FE2350
	internal void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0x1FE22E0 Offset: 0x1FE14E0 VA: 0x181FE22E0
	internal void SetLineInfo(IXmlLineInfo lineInfo) { }

	// RVA: 0x1FE2240 Offset: 0x1FE1440 VA: 0x181FE2240
	internal void SetItemData(string localName, string prefix, string ns, int depth) { }

	// RVA: 0x1FE22D0 Offset: 0x1FE14D0 VA: 0x181FE22D0
	internal void SetItemData(string value) { }

	// RVA: 0x1FE22C0 Offset: 0x1FE14C0 VA: 0x181FE22C0
	internal void SetItemData(string value, string originalStringValue) { }
}

// Namespace: System.Xml
public enum ValidationType // TypeDefIndex: 11928
{
	// Fields
	public int value__; // 0x0
	public const ValidationType None = 0;
	[Obsolete("Validation type should be specified as DTD or Schema.")]
	public const ValidationType Auto = 1;
	public const ValidationType DTD = 2;
	[Obsolete("XDR Validation through XmlValidatingReader is obsoleted")]
	public const ValidationType XDR = 3;
	public const ValidationType Schema = 4;
}

// Namespace: System.Xml
public enum WhitespaceHandling // TypeDefIndex: 11929
{
	// Fields
	public int value__; // 0x0
	public const WhitespaceHandling All = 0;
	public const WhitespaceHandling Significant = 1;
	public const WhitespaceHandling None = 2;
}

// Namespace: System.Xml
[DefaultMember("Item")]
internal class XmlAsyncCheckReader : XmlReader // TypeDefIndex: 11930
{
	// Fields
	private readonly XmlReader coreReader; // 0x10
	private Task lastTask; // 0x18

	// Properties
	internal XmlReader CoreReader { get; }
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override bool HasValue { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override Type ValueType { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public override bool CanResolveEntity { get; }
	public override bool CanReadValueChunk { get; }
	public override bool HasAttributes { get; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal XmlReader get_CoreReader() { }

	// RVA: 0x1FE2FF0 Offset: 0x1FE21F0 VA: 0x181FE2FF0
	public static XmlAsyncCheckReader CreateAsyncCheckWrapper(XmlReader reader) { }

	// RVA: 0x1FE3A10 Offset: 0x1FE2C10 VA: 0x181FE3A10
	public void .ctor(XmlReader reader) { }

	// RVA: 0x1FE2F20 Offset: 0x1FE2120 VA: 0x181FE2F20
	private void CheckAsync() { }

	// RVA: 0x1FE3FF0 Offset: 0x1FE31F0 VA: 0x181FE3FF0 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1FE3EB0 Offset: 0x1FE30B0 VA: 0x181FE3EB0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1FE3DF0 Offset: 0x1FE2FF0 VA: 0x181FE3DF0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x1FE3D70 Offset: 0x1FE2F70 VA: 0x181FE3D70 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x1FE3E70 Offset: 0x1FE3070 VA: 0x181FE3E70 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x1FE3EF0 Offset: 0x1FE30F0 VA: 0x181FE3EF0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1FE3CB0 Offset: 0x1FE2EB0 VA: 0x181FE3CB0 Slot: 11
	public override bool get_HasValue() { }

	// RVA: 0x1FE4130 Offset: 0x1FE3330 VA: 0x181FE4130 Slot: 12
	public override string get_Value() { }

	// RVA: 0x1FE3BB0 Offset: 0x1FE2DB0 VA: 0x181FE3BB0 Slot: 13
	public override int get_Depth() { }

	// RVA: 0x1FE3AF0 Offset: 0x1FE2CF0 VA: 0x181FE3AF0 Slot: 14
	public override string get_BaseURI() { }

	// RVA: 0x1FE3D30 Offset: 0x1FE2F30 VA: 0x181FE3D30 Slot: 15
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1FE3CF0 Offset: 0x1FE2EF0 VA: 0x181FE3CF0 Slot: 16
	public override bool get_IsDefault() { }

	// RVA: 0x1FE3F30 Offset: 0x1FE3130 VA: 0x181FE3F30 Slot: 17
	public override char get_QuoteChar() { }

	// RVA: 0x1FE41B0 Offset: 0x1FE33B0 VA: 0x181FE41B0 Slot: 18
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1FE4170 Offset: 0x1FE3370 VA: 0x181FE4170 Slot: 19
	public override string get_XmlLang() { }

	// RVA: 0x1FE3FB0 Offset: 0x1FE31B0 VA: 0x181FE3FB0 Slot: 20
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1FE40F0 Offset: 0x1FE32F0 VA: 0x181FE40F0 Slot: 21
	public override Type get_ValueType() { }

	// RVA: 0x1FE3710 Offset: 0x1FE2910 VA: 0x181FE3710 Slot: 22
	public override string ReadContentAsString() { }

	// RVA: 0x1FE3AB0 Offset: 0x1FE2CB0 VA: 0x181FE3AB0 Slot: 23
	public override int get_AttributeCount() { }

	// RVA: 0x1FE3390 Offset: 0x1FE2590 VA: 0x181FE3390 Slot: 24
	public override string GetAttribute(string name) { }

	// RVA: 0x1FE33E0 Offset: 0x1FE25E0 VA: 0x181FE33E0 Slot: 25
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x1FE3340 Offset: 0x1FE2540 VA: 0x181FE3340 Slot: 26
	public override string GetAttribute(int i) { }

	// RVA: 0x1FE3580 Offset: 0x1FE2780 VA: 0x181FE3580 Slot: 27
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1FE3530 Offset: 0x1FE2730 VA: 0x181FE3530 Slot: 28
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1FE3650 Offset: 0x1FE2850 VA: 0x181FE3650 Slot: 29
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1FE3690 Offset: 0x1FE2890 VA: 0x181FE3690 Slot: 30
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1FE3610 Offset: 0x1FE2810 VA: 0x181FE3610 Slot: 31
	public override bool MoveToElement() { }

	// RVA: 0x1FE36D0 Offset: 0x1FE28D0 VA: 0x181FE36D0 Slot: 32
	public override bool ReadAttributeValue() { }

	// RVA: 0x1FE3950 Offset: 0x1FE2B50 VA: 0x181FE3950 Slot: 33
	public override bool Read() { }

	// RVA: 0x1FE3C30 Offset: 0x1FE2E30 VA: 0x181FE3C30 Slot: 34
	public override bool get_EOF() { }

	// RVA: 0x1FE2FB0 Offset: 0x1FE21B0 VA: 0x181FE2FB0 Slot: 35
	public override void Close() { }

	// RVA: 0x1FE3F70 Offset: 0x1FE3170 VA: 0x181FE3F70 Slot: 36
	public override ReadState get_ReadState() { }

	// RVA: 0x1FE39D0 Offset: 0x1FE2BD0 VA: 0x181FE39D0 Slot: 37
	public override void Skip() { }

	// RVA: 0x1FE3DB0 Offset: 0x1FE2FB0 VA: 0x181FE3DB0 Slot: 38
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1FE34E0 Offset: 0x1FE26E0 VA: 0x181FE34E0 Slot: 39
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1FE3B70 Offset: 0x1FE2D70 VA: 0x181FE3B70 Slot: 40
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1FE3990 Offset: 0x1FE2B90 VA: 0x181FE3990 Slot: 41
	public override void ResolveEntity() { }

	// RVA: 0x1FE3B30 Offset: 0x1FE2D30 VA: 0x181FE3B30 Slot: 42
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x1FE38E0 Offset: 0x1FE2AE0 VA: 0x181FE38E0 Slot: 43
	public override int ReadValueChunk(char[] buffer, int index, int count) { }

	// RVA: 0x1FE38A0 Offset: 0x1FE2AA0 VA: 0x181FE38A0 Slot: 44
	public override string ReadString() { }

	// RVA: 0x1FE35D0 Offset: 0x1FE27D0 VA: 0x181FE35D0 Slot: 45
	public override XmlNodeType MoveToContent() { }

	// RVA: 0x1FE3860 Offset: 0x1FE2A60 VA: 0x181FE3860 Slot: 46
	public override void ReadStartElement() { }

	// RVA: 0x1FE3810 Offset: 0x1FE2A10 VA: 0x181FE3810 Slot: 47
	public override void ReadStartElement(string name) { }

	// RVA: 0x1FE3750 Offset: 0x1FE2950 VA: 0x181FE3750 Slot: 48
	public override string ReadElementString() { }

	// RVA: 0x1FE3790 Offset: 0x1FE2990 VA: 0x181FE3790 Slot: 49
	public override void ReadEndElement() { }

	// RVA: 0x1FE3440 Offset: 0x1FE2640 VA: 0x181FE3440 Slot: 50
	public override bool IsStartElement() { }

	// RVA: 0x1FE3480 Offset: 0x1FE2680 VA: 0x181FE3480 Slot: 51
	public override bool IsStartElement(string localname, string ns) { }

	// RVA: 0x1FE37D0 Offset: 0x1FE29D0 VA: 0x181FE37D0 Slot: 52
	public override string ReadInnerXml() { }

	// RVA: 0x1FE3C70 Offset: 0x1FE2E70 VA: 0x181FE3C70 Slot: 53
	public override bool get_HasAttributes() { }

	// RVA: 0x1FE3300 Offset: 0x1FE2500 VA: 0x181FE3300 Slot: 54
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1FE3E30 Offset: 0x1FE3030 VA: 0x181FE3E30 Slot: 55
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1FE3BF0 Offset: 0x1FE2DF0 VA: 0x181FE3BF0 Slot: 56
	internal override IDtdInfo get_DtdInfo() { }
}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithNS : XmlAsyncCheckReader, IXmlNamespaceResolver // TypeDefIndex: 11931
{
	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x20

	// Methods

	// RVA: 0x1FE2E70 Offset: 0x1FE2070 VA: 0x181FE2E70
	public void .ctor(XmlReader reader) { }

	// RVA: 0x1FE2D50 Offset: 0x1FE1F50 VA: 0x181FE2D50 Slot: 57
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1FE2DB0 Offset: 0x1FE1FB0 VA: 0x181FE2DB0 Slot: 58
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1FE2E10 Offset: 0x1FE2010 VA: 0x181FE2E10 Slot: 59
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }
}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfo : XmlAsyncCheckReader, IXmlLineInfo // TypeDefIndex: 11932
{
	// Fields
	private readonly IXmlLineInfo readerAsIXmlLineInfo; // 0x20

	// Properties
	public virtual int LineNumber { get; }
	public virtual int LinePosition { get; }

	// Methods

	// RVA: 0x1FE2C00 Offset: 0x1FE1E00 VA: 0x181FE2C00
	public void .ctor(XmlReader reader) { }

	// RVA: 0x1FE2BB0 Offset: 0x1FE1DB0 VA: 0x181FE2BB0 Slot: 60
	public virtual bool HasLineInfo() { }

	// RVA: 0x1FE2CB0 Offset: 0x1FE1EB0 VA: 0x181FE2CB0 Slot: 61
	public virtual int get_LineNumber() { }

	// RVA: 0x1FE2D00 Offset: 0x1FE1F00 VA: 0x181FE2D00 Slot: 62
	public virtual int get_LinePosition() { }
}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfoNS : XmlAsyncCheckReaderWithLineInfo, IXmlNamespaceResolver // TypeDefIndex: 11933
{
	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x28

	// Methods

	// RVA: 0x1FE2A80 Offset: 0x1FE1C80 VA: 0x181FE2A80
	public void .ctor(XmlReader reader) { }

	// RVA: 0x1FE2960 Offset: 0x1FE1B60 VA: 0x181FE2960 Slot: 63
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1FE29C0 Offset: 0x1FE1BC0 VA: 0x181FE29C0 Slot: 64
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1FE2A20 Offset: 0x1FE1C20 VA: 0x181FE2A20 Slot: 65
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }
}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfoNSSchema : XmlAsyncCheckReaderWithLineInfoNS, IXmlSchemaInfo // TypeDefIndex: 11934
{
	// Fields
	private readonly IXmlSchemaInfo readerAsIXmlSchemaInfo; // 0x30

	// Properties
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.Validity { get; }
	private bool System.Xml.Schema.IXmlSchemaInfo.IsDefault { get; }
	private bool System.Xml.Schema.IXmlSchemaInfo.IsNil { get; }
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.MemberType { get; }
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.SchemaType { get; }
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.SchemaElement { get; }
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.SchemaAttribute { get; }

	// Methods

	// RVA: 0x1FE27B0 Offset: 0x1FE19B0 VA: 0x181FE27B0
	public void .ctor(XmlReader reader) { }

