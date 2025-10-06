	// RVA: 0x19F2330 Offset: 0x19F1530 VA: 0x1819F2330 Slot: 24
	public float GetAxisRaw(int index) { }

	// RVA: 0x19F2790 Offset: 0x19F1990 VA: 0x1819F2790 Slot: 25
	public PlayerController.Element GetElement(int index) { }

	// RVA: -1 Offset: -1 Slot: 26
	public T GetElement<T>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA59E90 Offset: 0xA59090 VA: 0x180A59E90
	|-PlayerController.GetElement<object>
	*/

	// RVA: 0x19F4460 Offset: 0x19F3660 VA: 0x1819F4460
	internal Player lbTnefOkQLLqJNgBXwaiDvFumjwV() { }

	// RVA: 0x19F45B0 Offset: 0x19F37B0 VA: 0x1819F45B0
	private void rXMSMoptVBXwmLIisXpGDWxMCQSj(UpdateLoopType ) { }

	// RVA: 0x19F2A90 Offset: 0x19F1C90 VA: 0x1819F2A90 Slot: 27
	protected virtual bool Update(UpdateLoopType updateLoop) { }

	// RVA: 0x19F2860 Offset: 0x19F1A60 VA: 0x1819F2860 Slot: 28
	protected virtual void UpdateFinished() { }

	// RVA: 0x19F2210 Offset: 0x19F1410 VA: 0x1819F2210 Slot: 29
	protected virtual void ClearVars() { }

	// RVA: 0x19F4310 Offset: 0x19F3510 VA: 0x1819F4310
	internal void lAgTkkmrmCYHzLIplmpAFCsdJbIF(PlayerController.Element ) { }

	// RVA: 0x19F3DC0 Offset: 0x19F2FC0 VA: 0x1819F3DC0
	private void lAgTkkmrmCYHzLIplmpAFCsdJbIF(PlayerController.Element , List<PlayerController.Element> , List<PlayerController.Element> , List<PlayerController.Button> , List<PlayerController.Axis> ) { }

	// RVA: -1 Offset: -1
	internal static int tzCwoHUNzTvolRjWZYTYjakYLFmd<>(IList<> , Predicate<> , int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA59F40 Offset: 0xA59140 VA: 0x180A59F40
	|-PlayerController.tzCwoHUNzTvolRjWZYTYjakYLFmd<object>
	*/
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal interface IPlayerMouse : IPlayerController // TypeDefIndex: 6861
{
	// Properties
	public abstract bool defaultToCenter { get; }
	public abstract ScreenRect movementArea { get; set; }
	public abstract PlayerMouse.MovementAreaUnit movementAreaUnit { get; set; }
	public abstract Vector2 screenPosition { get; }
	public abstract Vector2 screenPositionPrev { get; }
	public abstract Vector2 screenPositionDelta { get; }
	public abstract PlayerController.MouseAxis xAxis { get; }
	public abstract PlayerController.MouseAxis yAxis { get; }
	public abstract PlayerController.MouseWheel wheel { get; }
	public abstract PlayerController.Button leftButton { get; }
	public abstract PlayerController.Button rightButton { get; }
	public abstract PlayerController.Button middleButton { get; }
	public abstract float pointerSpeed { get; }
	public abstract bool useHardwarePointerPosition { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_defaultToCenter();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ScreenRect get_movementArea();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_movementArea(ScreenRect value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract PlayerMouse.MovementAreaUnit get_movementAreaUnit();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void set_movementAreaUnit(PlayerMouse.MovementAreaUnit value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Vector2 get_screenPosition();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Vector2 get_screenPositionPrev();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Vector2 get_screenPositionDelta();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract PlayerController.MouseAxis get_xAxis();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract PlayerController.MouseAxis get_yAxis();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract PlayerController.MouseWheel get_wheel();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract PlayerController.Button get_leftButton();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract PlayerController.Button get_rightButton();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract PlayerController.Button get_middleButton();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract float get_pointerSpeed();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool get_useHardwarePointerPosition();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 16
	public abstract void add_ScreenPositionChangedEvent(Action<Vector2> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 17
	public abstract void remove_ScreenPositionChangedEvent(Action<Vector2> value);
}

// Namespace: 
public sealed class PlayerMouse.Definition : PlayerController.Definition // TypeDefIndex: 6862
{
	// Fields
	public bool defaultToCenter; // 0x20
	public bool clampToMovementArea; // 0x21
	public ScreenRect movementArea; // 0x24
	public PlayerMouse.MovementAreaUnit movementAreaUnit; // 0x34
	public float pointerSpeed; // 0x38
	public bool useHardwarePointerPosition; // 0x3C

	// Methods

	// RVA: 0x1A3A360 Offset: 0x1A39560 VA: 0x181A3A360
	internal void .ctor() { }
}

// Namespace: 
public static class PlayerMouse.Factory // TypeDefIndex: 6863
{
	// Methods

	// RVA: 0x1A3D1D0 Offset: 0x1A3C3D0 VA: 0x181A3D1D0
	public static PlayerMouse Create() { }

	// RVA: 0x1A3D1E0 Offset: 0x1A3C3E0 VA: 0x181A3D1E0
	private static PlayerMouse TZpAtmoswOXHtgELCQOweYKzFlBS(int , int ) { }

	// RVA: 0x1A3D170 Offset: 0x1A3C370 VA: 0x181A3D170
	public static PlayerMouse Create(PlayerMouse.Definition definition) { }
}

// Namespace: 
public enum PlayerMouse.MovementAreaUnit // TypeDefIndex: 6864
{
	// Fields
	public int value__; // 0x0
	public const PlayerMouse.MovementAreaUnit Screen = 0;
	public const PlayerMouse.MovementAreaUnit Pixel = 1;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PlayerMouse.uijkACnPbnpRtPfbEADfGwAEvnZI // TypeDefIndex: 6865
{
	// Fields
	public static readonly PlayerMouse.uijkACnPbnpRtPfbEADfGwAEvnZI <>9; // 0x0
	public static Predicate<PlayerController.Axis> <>9__18_0; // 0x8
	public static Predicate<PlayerController.Axis> <>9__18_1; // 0x10

	// Methods

	// RVA: 0x1A502A0 Offset: 0x1A4F4A0 VA: 0x181A502A0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1A50200 Offset: 0x1A4F400 VA: 0x181A50200
	internal bool VTLusJovDRuslhuQMKhpsXVuVESI(PlayerController.Axis ) { }

	// RVA: 0x1A50300 Offset: 0x1A4F500 VA: 0x181A50300
	internal bool vSIzINrIZqLDCzFmfzNPDoAHRfHE(PlayerController.Axis ) { }
}

// Namespace: Rewired
public sealed class PlayerMouse : PlayerController, IPlayerController, IPlayerMouse, IMouseInputSource // TypeDefIndex: 6866
{
	// Fields
	internal const bool IGdjNYSBhxPvHcOepasCqMODiAek = True;
	internal const float kUYjMbgqRGiJagKmRTIEXXXryEJA = 1;
	internal const bool hlhZjgYEmLCXTJgUnZGpiyCQjflB = True;
	internal const bool cBwXblAOaEVIfVeJfaguJxzgSVrfA = True;
	internal const PlayerMouse.MovementAreaUnit tsDASNNjUklqKrpivjZdNBjmeUA = 0;
	internal static readonly ScreenRect NDFndKRqnyESpVqFfqytGczkGcRq; // 0x0
	private const int oNgjPfhAPCjzQGdfMGqdpcwvgOOB = 3;
	private const int qfFJEwRPyJahqcSRBKChdRNLkgil = 3;
	internal const string mMOADOMKtGCAfrQmLEhBOklifKlw = "Movement";
	internal const string HTjiwOEoXbSryDPtmCnnfESxxuVh = "Horizontal";
	internal const string kiYFKJUHvyPeJKvLgTZZfKrJBPhm = "Vertical";
	internal const string kcFAYRmHJqdzsGCbypEgWaKJqsaCA = "Wheel";
	internal const string XHvwliXyDkZDlOcwsJMQESIGhpDC = "Wheel Horizontal";
	internal const string SRIDtsHbkRnKtttzUNoFZGjfGzRdA = "Wheel Vertical";
	internal const string LSUtWCQkXyEOygBpdYGFpTgxMVXn = "Left Button";
	internal const string UAAAoTBdFnUydpUqIZXXXtOcEfcG = "Right Button";
	internal const string aoHixlOKAeMLgtikTZxDKPwtjoBL = "Middle Button";
	private readonly int JDyCbggpXlXEhaHyZHCfmnluuvaO; // 0x70
	private readonly int tkYdpHOqSLcTAvUOfilJrZVKCRUV; // 0x74
	private readonly int HmxAMnjTjlOJZQkVlOoPMSNyebcDb; // 0x78
	private readonly int HumpIeOhyJAuiGMwcnSdxRJJkCEUA; // 0x7C
	private readonly int taFjIWpHgwIJiujJFaNueagrunlTA; // 0x80
	private readonly int yztDryNKXFhGwlGTFscwoctAhnxW; // 0x84
	private bool NpPDoBaRYbrmsDlbrUZUQtLQHLWpA; // 0x88
	private Vector2 WatrMLKOtjNIIApMDcBuIcOzivuZA; // 0x8C
	private Vector2 JzldlvCPwpUcrRlxSmArDtCUcGo; // 0x94
	private Vector2 xdtSVilfQvXZxVJDFWOUGIEcKdNV; // 0x9C
	private Vector2 fYykYqbyxfZLQhTQatQdsRqWqLui; // 0xA4
	private Vector2 kyqACiKOzLdNyNJKVLvpdBwCRGxmB; // 0xAC
	private float auFNZwkIgKoYrbXTPGPEDZusDmpF; // 0xB4
	private bool jXFTpjasaRUDBcNCyBidYdrJsQVG; // 0xB8
	private Action<Vector2> HMrzajbVrRZcjBfXQhlgNSsqFgos; // 0xC0
	private bool CzeDoEAyZuZgxSevEaewNuwsvukoA; // 0xC8
	private ScreenRect BEwaDUGQPjjvUXPERzmgjVYVDYyZA; // 0xCC
	private bool HchegvCGYdHxcfcPjNudFdweRYrlc; // 0xDC
	private PlayerMouse.MovementAreaUnit yYQIbXFWCGDbDeCslgNDHopGLhbNA; // 0xE0

	// Properties
	public bool defaultToCenter { get; set; }
	public bool clampToMovementArea { get; set; }
	public ScreenRect movementArea { get; set; }
	public PlayerMouse.MovementAreaUnit movementAreaUnit { get; set; }
	public Vector2 screenPosition { get; set; }
	public Vector2 screenPositionPrev { get; }
	public Vector2 screenPositionDelta { get; }
	public PlayerController.MouseAxis xAxis { get; }
	public PlayerController.MouseAxis yAxis { get; }
	public PlayerController.MouseWheel wheel { get; }
	public PlayerController.Button leftButton { get; }
	public PlayerController.Button rightButton { get; }
	public PlayerController.Button middleButton { get; }
	public float pointerSpeed { get; set; }
	public bool useHardwarePointerPosition { get; set; }
	private bool Rewired.UI.IMouseInputSource.enabled { get; }
	private Vector2 Rewired.UI.IMouseInputSource.screenPosition { get; }
	private Vector2 Rewired.UI.IMouseInputSource.screenPositionDelta { get; }
	private Vector2 Rewired.UI.IMouseInputSource.wheelDelta { get; }
	private bool Rewired.UI.IMouseInputSource.locked { get; }

	// Methods

	// RVA: 0x1A44FF0 Offset: 0x1A441F0 VA: 0x181A44FF0
	private void .ctor(PlayerMouse.Definition ) { }

	// RVA: 0x1A45EC0 Offset: 0x1A450C0 VA: 0x181A45EC0 Slot: 30
	public bool get_defaultToCenter() { }

	// RVA: 0x1A46CC0 Offset: 0x1A45EC0 VA: 0x181A46CC0
	public void set_defaultToCenter(bool value) { }

	// RVA: 0x190DC40 Offset: 0x190CE40 VA: 0x18190DC40
	public bool get_clampToMovementArea() { }

	// RVA: 0x190DC50 Offset: 0x190CE50 VA: 0x18190DC50
	public void set_clampToMovementArea(bool value) { }

	// RVA: 0x1A46170 Offset: 0x1A45370 VA: 0x181A46170 Slot: 31
	public ScreenRect get_movementArea() { }

	// RVA: 0x526D60 Offset: 0x525F60 VA: 0x180526D60 Slot: 32
	public void set_movementArea(ScreenRect value) { }

	// RVA: 0x1A460E0 Offset: 0x1A452E0 VA: 0x181A460E0 Slot: 33
	public PlayerMouse.MovementAreaUnit get_movementAreaUnit() { }

	// RVA: 0x190DCC0 Offset: 0x190CEC0 VA: 0x18190DCC0 Slot: 34
	public void set_movementAreaUnit(PlayerMouse.MovementAreaUnit value) { }

	// RVA: 0x1A46540 Offset: 0x1A45740 VA: 0x181A46540 Slot: 35
	public Vector2 get_screenPosition() { }

	// RVA: 0x1A46D70 Offset: 0x1A45F70 VA: 0x181A46D70
	public void set_screenPosition(Vector2 value) { }

	// RVA: 0x1A46460 Offset: 0x1A45660 VA: 0x181A46460 Slot: 36
	public Vector2 get_screenPositionPrev() { }

	// RVA: 0x1A46380 Offset: 0x1A45580 VA: 0x181A46380 Slot: 37
	public Vector2 get_screenPositionDelta() { }

	// RVA: 0x1A467A0 Offset: 0x1A459A0 VA: 0x181A467A0 Slot: 38
	public PlayerController.MouseAxis get_xAxis() { }

	// RVA: 0x1A468D0 Offset: 0x1A45AD0 VA: 0x181A468D0 Slot: 39
	public PlayerController.MouseAxis get_yAxis() { }

	// RVA: 0x1A466B0 Offset: 0x1A458B0 VA: 0x181A466B0 Slot: 40
	public PlayerController.MouseWheel get_wheel() { }

	// RVA: 0x1A45F50 Offset: 0x1A45150 VA: 0x181A45F50 Slot: 41
	public PlayerController.Button get_leftButton() { }

	// RVA: 0x1A462B0 Offset: 0x1A454B0 VA: 0x181A462B0 Slot: 42
	public PlayerController.Button get_rightButton() { }

	// RVA: 0x1A46010 Offset: 0x1A45210 VA: 0x181A46010 Slot: 43
	public PlayerController.Button get_middleButton() { }

	// RVA: 0x1A46220 Offset: 0x1A45420 VA: 0x181A46220 Slot: 44
	public float get_pointerSpeed() { }

	// RVA: 0x1A46CD0 Offset: 0x1A45ED0 VA: 0x181A46CD0
	public void set_pointerSpeed(float value) { }

	// RVA: 0x1A46620 Offset: 0x1A45820 VA: 0x181A46620 Slot: 45
	public bool get_useHardwarePointerPosition() { }

	// RVA: 0x1A46D80 Offset: 0x1A45F80 VA: 0x181A46D80
	public void set_useHardwarePointerPosition(bool value) { }

	// RVA: 0x1A45DA0 Offset: 0x1A44FA0 VA: 0x181A45DA0 Slot: 46
	public void add_ScreenPositionChangedEvent(Action<Vector2> value) { }

	// RVA: 0x1A46C10 Offset: 0x1A45E10 VA: 0x181A46C10 Slot: 47
	public void remove_ScreenPositionChangedEvent(Action<Vector2> value) { }

	// RVA: 0x1A44C70 Offset: 0x1A43E70 VA: 0x181A44C70 Slot: 27
	protected override bool Update(UpdateLoopType updateLoop) { }

	// RVA: 0x1A44B80 Offset: 0x1A43D80 VA: 0x181A44B80 Slot: 28
	protected override void UpdateFinished() { }

	// RVA: 0x1A44790 Offset: 0x1A43990 VA: 0x181A44790 Slot: 29
	protected override void ClearVars() { }

	// RVA: 0x1A44820 Offset: 0x1A43A20 VA: 0x181A44820
	private void PHdbwhRKqRfZSUwVaGNlBdlybfgTA(Vector2 ) { }

	// RVA: 0x1A46AA0 Offset: 0x1A45CA0 VA: 0x181A46AA0
	private ScreenRect lhOflCyNWDFdBkvyxbwtOKwprlkl() { }

	// RVA: 0x1A46A00 Offset: 0x1A45C00 VA: 0x181A46A00
	private void jamBJgjvNlmtzREmhTKRpwbYUITq() { }

	// RVA: 0x1A44AB0 Offset: 0x1A43CB0 VA: 0x181A44AB0
	private static float UgkFvtRfwvugbxcYMeEgHwMpGrPJA(PlayerController.Axis , float , float ) { }

	// RVA: 0x1A449F0 Offset: 0x1A43BF0 VA: 0x181A449F0 Slot: 49
	private bool Rewired.UI.IMouseInputSource.get_enabled() { }

	// RVA: 0x1A449C0 Offset: 0x1A43BC0 VA: 0x181A449C0 Slot: 52
	private bool Rewired.UI.IMouseInputSource.GetButtonDown(int button) { }

	// RVA: 0x1A449D0 Offset: 0x1A43BD0 VA: 0x181A449D0 Slot: 53
	private bool Rewired.UI.IMouseInputSource.GetButtonUp(int button) { }

	// RVA: 0x1A449E0 Offset: 0x1A43BE0 VA: 0x181A449E0 Slot: 54
	private bool Rewired.UI.IMouseInputSource.GetButton(int button) { }

	// RVA: 0x146AEE0 Offset: 0x146A0E0 VA: 0x18146AEE0 Slot: 55
	private Vector2 Rewired.UI.IMouseInputSource.get_screenPosition() { }

	// RVA: 0x1A44A00 Offset: 0x1A43C00 VA: 0x181A44A00 Slot: 56
	private Vector2 Rewired.UI.IMouseInputSource.get_screenPositionDelta() { }

	// RVA: 0x1A44A20 Offset: 0x1A43C20 VA: 0x181A44A20 Slot: 57
	private Vector2 Rewired.UI.IMouseInputSource.get_wheelDelta() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 50
	private bool Rewired.UI.IMouseInputSource.get_locked() { }

	// RVA: 0x1A44F80 Offset: 0x1A44180 VA: 0x181A44F80
	private static void .cctor() { }
}

// Namespace: Rewired
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal static class Logger // TypeDefIndex: 6867
{
	// Fields
	private const int screenLogLength = 50;
	private static List<string> __screenLog; // 0x0
	private static GUIText _guiText; // 0x8
	private static bool _logToScreen; // 0x10

	// Properties
	private static List<string> screenLog { get; }
	private static LogLevelFlags logLevel { get; }
	public static bool logToScreen { get; set; }

	// Methods

	// RVA: 0x1A43830 Offset: 0x1A42A30 VA: 0x181A43830
	private static List<string> get_screenLog() { }

	// RVA: 0x1A436A0 Offset: 0x1A428A0 VA: 0x181A436A0
	private static LogLevelFlags get_logLevel() { }

	// RVA: 0x1A437F0 Offset: 0x1A429F0 VA: 0x181A437F0
	public static bool get_logToScreen() { }

	// RVA: 0x1A438C0 Offset: 0x1A42AC0 VA: 0x181A438C0
	public static void set_logToScreen(bool value) { }

	// RVA: 0x1A41140 Offset: 0x1A40340 VA: 0x181A41140
	public static void LogEditor(object msg) { }

	// RVA: 0x1A41040 Offset: 0x1A40240 VA: 0x181A41040
	public static void LogEditor(object msg, bool requiredThreadSafety) { }

	// RVA: 0x1A42F70 Offset: 0x1A42170 VA: 0x181A42F70
	public static void LogWarningEditor(object msg) { }

	// RVA: 0x1A42E70 Offset: 0x1A42070 VA: 0x181A42E70
	public static void LogWarningEditor(object msg, bool requiredThreadSafety) { }

	// RVA: 0x1A41330 Offset: 0x1A40530 VA: 0x181A41330
	public static void LogErrorEditor(object msg) { }

	// RVA: 0x1A41230 Offset: 0x1A40430 VA: 0x181A41230
	public static void LogErrorEditor(object msg, bool requiredThreadSafety) { }

	// RVA: 0x1A434B0 Offset: 0x1A426B0 VA: 0x181A434B0
	public static void Log(object msg) { }

	// RVA: 0x1A434C0 Offset: 0x1A426C0 VA: 0x181A434C0
	public static void Log(object msg, bool requiredThreadSafety) { }

	// RVA: 0x1A434A0 Offset: 0x1A426A0 VA: 0x181A434A0
	public static void LogWarning(object msg) { }

	// RVA: 0x1A431E0 Offset: 0x1A423E0 VA: 0x181A431E0
	public static void LogWarning(object msg, bool requiredThreadSafety) { }

	// RVA: 0x1A41DB0 Offset: 0x1A40FB0 VA: 0x181A41DB0
	public static void LogError(object msg) { }

	// RVA: 0x1A415A0 Offset: 0x1A407A0 VA: 0x181A415A0
	public static void LogError(object msg, bool requiredThreadSafety) { }

	// RVA: 0x1A427C0 Offset: 0x1A419C0 VA: 0x181A427C0
	public static void LogException(Exception exception, object msg) { }

	// RVA: 0x1A420D0 Offset: 0x1A412D0 VA: 0x181A420D0
	public static void LogException(Exception exception, object msg, bool requiredThreadSafety) { }

	// RVA: 0x1A42800 Offset: 0x1A41A00 VA: 0x181A42800
	private static void LogNow(object msg, bool requireThreadSafety) { }

	// RVA: 0x1A43060 Offset: 0x1A42260 VA: 0x181A43060
	private static void LogWarningNow(object msg, bool requireThreadSafety) { }

	// RVA: 0x1A41420 Offset: 0x1A40620 VA: 0x181A41420
	private static void LogErrorNow(object msg, bool requireThreadSafety) { }

	// RVA: 0x1A41DC0 Offset: 0x1A40FC0 VA: 0x181A41DC0
	private static void LogExceptionNow(Exception exception, object msg, bool requireThreadSafety) { }

	// RVA: 0x1A40FA0 Offset: 0x1A401A0 VA: 0x181A40FA0
	private static bool IsLoggingAllowed(LogLevel logLevel) { }

	// RVA: 0x1A42980 Offset: 0x1A41B80 VA: 0x181A42980
	private static void LogToScreen(object msg) { }

	[Conditional("LOG_INIT")]
	// RVA: 0x1A427F0 Offset: 0x1A419F0 VA: 0x181A427F0
	public static void LogInit(object o) { }

	[Conditional("LOG_INIT")]
	// RVA: 0x1A427D0 Offset: 0x1A419D0 VA: 0x181A427D0
	public static void LogInitError(object o) { }

	[Conditional("LOG_INIT")]
	// RVA: 0x1A427E0 Offset: 0x1A419E0 VA: 0x181A427E0
	public static void LogInitWarning(object o) { }

	[Conditional("LOG_VC")]
	// RVA: 0x1A434B0 Offset: 0x1A426B0 VA: 0x181A434B0
	public static void Log_VCTest(object o) { }

	[Conditional("LOG_UPDATE")]
	// RVA: 0x1A427F0 Offset: 0x1A419F0 VA: 0x181A427F0
	public static void LogUpdate(object o) { }

	// RVA: 0x1A40EF0 Offset: 0x1A400F0 VA: 0x181A40EF0
	private static object FormatMessage(object o) { }
}

// Namespace: 
internal static class jhrJvZXivVafEmSCDEMpGDCMCjZoA // TypeDefIndex: 6868
{
	// Methods

	[Conditional("ENABLE_BENCHMARK")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal static void JoyMvwTFwpAcUmxPNgFvAEOEEtgN() { }

	[Conditional("ENABLE_BENCHMARK")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal static void CnPBQgcunWRHLrhWVtReGCnCiZGe() { }
}

// Namespace: Rewired
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal static class GCProfiler // TypeDefIndex: 6869
{
	// Methods

	[Conditional("ENABLE_GCPROFILER")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void Begin(string name) { }

	[Conditional("ENABLE_GCPROFILER")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void End() { }

	[Conditional("ENABLE_GCPROFILER")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void LogReport() { }

	[Conditional("ENABLE_GCPROFILER")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public static void Clear() { }
}

// Namespace: Rewired
public sealed class ActiveControllerChangedDelegate : MulticastDelegate // TypeDefIndex: 6870
{
	// Methods

	// RVA: 0x3FD260 Offset: 0x3FC460 VA: 0x1803FD260
	public void .ctor(object , IntPtr ) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Controller controller) { }

	// RVA: 0x3FD210 Offset: 0x3FC410 VA: 0x1803FD210 Slot: 14
	public virtual IAsyncResult BeginInvoke(Controller controller, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Rewired
public sealed class PlayerActiveControllerChangedDelegate : MulticastDelegate // TypeDefIndex: 6871
{
	// Methods

	// RVA: 0x1A446E0 Offset: 0x1A438E0 VA: 0x181A446E0
	public void .ctor(object , IntPtr ) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(Player player, Controller controller) { }

	// RVA: 0x7C9EF0 Offset: 0x7C90F0 VA: 0x1807C9EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Player player, Controller controller, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Rewired
public enum ModifierKey // TypeDefIndex: 6872
{
	// Fields
	public int value__; // 0x0
	public const ModifierKey None = 0;
	public const ModifierKey Control = 1;
	public const ModifierKey Alt = 2;
	public const ModifierKey Shift = 3;
	public const ModifierKey Command = 4;
}

// Namespace: Rewired
[Flags]
public enum ModifierKeyFlags // TypeDefIndex: 6873
{
	// Fields
	public int value__; // 0x0
	public const ModifierKeyFlags None = 0;
	public const ModifierKeyFlags LeftControl = 1;
	public const ModifierKeyFlags RightControl = 2;
	public const ModifierKeyFlags LeftAlt = 4;
	public const ModifierKeyFlags RightAlt = 8;
	public const ModifierKeyFlags LeftShift = 16;
	public const ModifierKeyFlags RightShift = 32;
	public const ModifierKeyFlags LeftCommand = 64;
	public const ModifierKeyFlags RightCommand = 128;
}

// Namespace: Rewired
public enum KeyboardKeyCode // TypeDefIndex: 6874
{
	// Fields
	public int value__; // 0x0
	public const KeyboardKeyCode None = 0;
	public const KeyboardKeyCode A = 97;
	public const KeyboardKeyCode B = 98;
	public const KeyboardKeyCode C = 99;
	public const KeyboardKeyCode D = 100;
	public const KeyboardKeyCode E = 101;
	public const KeyboardKeyCode F = 102;
	public const KeyboardKeyCode G = 103;
	public const KeyboardKeyCode H = 104;
	public const KeyboardKeyCode I = 105;
	public const KeyboardKeyCode J = 106;
	public const KeyboardKeyCode K = 107;
	public const KeyboardKeyCode L = 108;
	public const KeyboardKeyCode M = 109;
	public const KeyboardKeyCode N = 110;
	public const KeyboardKeyCode O = 111;
	public const KeyboardKeyCode P = 112;
	public const KeyboardKeyCode Q = 113;
	public const KeyboardKeyCode R = 114;
	public const KeyboardKeyCode S = 115;
	public const KeyboardKeyCode T = 116;
	public const KeyboardKeyCode U = 117;
	public const KeyboardKeyCode V = 118;
	public const KeyboardKeyCode W = 119;
	public const KeyboardKeyCode X = 120;
	public const KeyboardKeyCode Y = 121;
	public const KeyboardKeyCode Z = 122;
	public const KeyboardKeyCode Alpha0 = 48;
	public const KeyboardKeyCode Alpha1 = 49;
	public const KeyboardKeyCode Alpha2 = 50;
	public const KeyboardKeyCode Alpha3 = 51;
	public const KeyboardKeyCode Alpha4 = 52;
	public const KeyboardKeyCode Alpha5 = 53;
	public const KeyboardKeyCode Alpha6 = 54;
	public const KeyboardKeyCode Alpha7 = 55;
	public const KeyboardKeyCode Alpha8 = 56;
	public const KeyboardKeyCode Alpha9 = 57;
	public const KeyboardKeyCode Keypad0 = 256;
	public const KeyboardKeyCode Keypad1 = 257;
	public const KeyboardKeyCode Keypad2 = 258;
	public const KeyboardKeyCode Keypad3 = 259;
	public const KeyboardKeyCode Keypad4 = 260;
	public const KeyboardKeyCode Keypad5 = 261;
	public const KeyboardKeyCode Keypad6 = 262;
	public const KeyboardKeyCode Keypad7 = 263;
	public const KeyboardKeyCode Keypad8 = 264;
	public const KeyboardKeyCode Keypad9 = 265;
	public const KeyboardKeyCode KeypadPeriod = 266;
	public const KeyboardKeyCode KeypadDivide = 267;
	public const KeyboardKeyCode KeypadMultiply = 268;
	public const KeyboardKeyCode KeypadMinus = 269;
	public const KeyboardKeyCode KeypadPlus = 270;
	public const KeyboardKeyCode KeypadEnter = 271;
	public const KeyboardKeyCode KeypadEquals = 272;
	public const KeyboardKeyCode Backspace = 8;
	public const KeyboardKeyCode Tab = 9;
	public const KeyboardKeyCode Clear = 12;
	public const KeyboardKeyCode Return = 13;
	public const KeyboardKeyCode Pause = 19;
	public const KeyboardKeyCode Escape = 27;
	public const KeyboardKeyCode Space = 32;
	public const KeyboardKeyCode Exclaim = 33;
	public const KeyboardKeyCode DoubleQuote = 34;
	public const KeyboardKeyCode Hash = 35;
	public const KeyboardKeyCode Dollar = 36;
	public const KeyboardKeyCode Ampersand = 38;
	public const KeyboardKeyCode Quote = 39;
	public const KeyboardKeyCode LeftParen = 40;
	public const KeyboardKeyCode RightParen = 41;
	public const KeyboardKeyCode Asterisk = 42;
	public const KeyboardKeyCode Plus = 43;
	public const KeyboardKeyCode Comma = 44;
	public const KeyboardKeyCode Minus = 45;
	public const KeyboardKeyCode Period = 46;
	public const KeyboardKeyCode Slash = 47;
	public const KeyboardKeyCode Colon = 58;
	public const KeyboardKeyCode Semicolon = 59;
	public const KeyboardKeyCode Less = 60;
	public const KeyboardKeyCode Equals = 61;
	public const KeyboardKeyCode Greater = 62;
	public const KeyboardKeyCode Question = 63;
	public const KeyboardKeyCode At = 64;
	public const KeyboardKeyCode LeftBracket = 91;
	public const KeyboardKeyCode Backslash = 92;
	public const KeyboardKeyCode RightBracket = 93;
	public const KeyboardKeyCode Caret = 94;
	public const KeyboardKeyCode Underscore = 95;
	public const KeyboardKeyCode BackQuote = 96;
	public const KeyboardKeyCode Delete = 127;
	public const KeyboardKeyCode UpArrow = 273;
	public const KeyboardKeyCode DownArrow = 274;
	public const KeyboardKeyCode RightArrow = 275;
	public const KeyboardKeyCode LeftArrow = 276;
	public const KeyboardKeyCode Insert = 277;
	public const KeyboardKeyCode Home = 278;
	public const KeyboardKeyCode End = 279;
	public const KeyboardKeyCode PageUp = 280;
	public const KeyboardKeyCode PageDown = 281;
	public const KeyboardKeyCode F1 = 282;
	public const KeyboardKeyCode F2 = 283;
	public const KeyboardKeyCode F3 = 284;
	public const KeyboardKeyCode F4 = 285;
	public const KeyboardKeyCode F5 = 286;
	public const KeyboardKeyCode F6 = 287;
	public const KeyboardKeyCode F7 = 288;
	public const KeyboardKeyCode F8 = 289;
	public const KeyboardKeyCode F9 = 290;
	public const KeyboardKeyCode F10 = 291;
	public const KeyboardKeyCode F11 = 292;
	public const KeyboardKeyCode F12 = 293;
	public const KeyboardKeyCode F13 = 294;
	public const KeyboardKeyCode F14 = 295;
	public const KeyboardKeyCode F15 = 296;
	public const KeyboardKeyCode Numlock = 300;
	public const KeyboardKeyCode CapsLock = 301;
	public const KeyboardKeyCode ScrollLock = 302;
	public const KeyboardKeyCode RightShift = 303;
	public const KeyboardKeyCode LeftShift = 304;
	public const KeyboardKeyCode RightControl = 305;
	public const KeyboardKeyCode LeftControl = 306;
	public const KeyboardKeyCode RightAlt = 307;
	public const KeyboardKeyCode LeftAlt = 308;
	public const KeyboardKeyCode RightCommand = 309;
	public const KeyboardKeyCode LeftCommand = 310;
	public const KeyboardKeyCode LeftWindows = 311;
	public const KeyboardKeyCode RightWindows = 312;
	public const KeyboardKeyCode AltGr = 313;
	public const KeyboardKeyCode Help = 315;
	public const KeyboardKeyCode Print = 316;
	public const KeyboardKeyCode SysReq = 317;
	public const KeyboardKeyCode Break = 318;
	public const KeyboardKeyCode Menu = 319;
}

// Namespace: Rewired
public enum MouseInputElement // TypeDefIndex: 6875
{
	// Fields
	public int value__; // 0x0
	public const MouseInputElement AxisX = 0;
	public const MouseInputElement AxisY = 1;
	public const MouseInputElement Axis3 = 2;
	public const MouseInputElement Button0 = 3;
	public const MouseInputElement Button1 = 4;
	public const MouseInputElement Button2 = 5;
	public const MouseInputElement Button3 = 6;
	public const MouseInputElement Button4 = 7;
	public const MouseInputElement Button5 = 8;
	public const MouseInputElement Button6 = 9;
	public const MouseInputElement Axis4 = 10;
}

// Namespace: Rewired
public enum MouseXYAxisMode // TypeDefIndex: 6876
{
	// Fields
	public int value__; // 0x0
	public const MouseXYAxisMode MouseAxis = 0;
	public const MouseXYAxisMode DigitalAxis = 1;
	public const MouseXYAxisMode ScreenPositionDelta = 3;
	public const MouseXYAxisMode Speed = 4;
}

// Namespace: Rewired
public enum MouseXYAxisDeltaCalc // TypeDefIndex: 6877
{
	// Fields
	public int value__; // 0x0
	public const MouseXYAxisDeltaCalc Normal = 0;
	public const MouseXYAxisDeltaCalc ScreenWidth = 1;
	public const MouseXYAxisDeltaCalc ScreenHeight = 2;
}

// Namespace: Rewired
public enum MouseOtherAxisMode // TypeDefIndex: 6878
{
	// Fields
	public int value__; // 0x0
	public const MouseOtherAxisMode MouseAxis = 0;
	public const MouseOtherAxisMode DigitalAxis = 1;
}

// Namespace: Rewired
public enum InputActionType // TypeDefIndex: 6879
{
	// Fields
	public int value__; // 0x0
	public const InputActionType Axis = 0;
	public const InputActionType Button = 1;
}

// Namespace: Rewired
public enum AxisType // TypeDefIndex: 6880
{
	// Fields
	public int value__; // 0x0
	public const AxisType None = 0;
	public const AxisType Normal = 1;
	public const AxisType Split = 2;
}

// Namespace: Rewired
public enum Pole // TypeDefIndex: 6881
{
	// Fields
	public int value__; // 0x0
	public const Pole Positive = 0;
	public const Pole Negative = 1;
}

// Namespace: Rewired
public enum AxisRange // TypeDefIndex: 6882
{
	// Fields
	public int value__; // 0x0
	public const AxisRange Full = 0;
	public const AxisRange Positive = 1;
	public const AxisRange Negative = 2;
}

// Namespace: Rewired
public enum AxisCoordinateMode // TypeDefIndex: 6883
{
	// Fields
	public int value__; // 0x0
	public const AxisCoordinateMode Absolute = 0;
	public const AxisCoordinateMode Relative = 1;
}

// Namespace: Rewired
public enum ControllerType // TypeDefIndex: 6884
{
	// Fields
	public int value__; // 0x0
	public const ControllerType Keyboard = 0;
	public const ControllerType Mouse = 1;
	public const ControllerType Joystick = 2;
	public const ControllerType Custom = 20;
}

// Namespace: Rewired
public enum ControllerElementType // TypeDefIndex: 6885
{
	// Fields
	public int value__; // 0x0
	public const ControllerElementType Axis = 0;
	public const ControllerElementType Button = 1;
	public const ControllerElementType CompoundElement = 100;
}

// Namespace: Rewired
public enum CompoundControllerElementType // TypeDefIndex: 6886
{
	// Fields
	public int value__; // 0x0
	public const CompoundControllerElementType Axis2D = 0;
	public const CompoundControllerElementType DPad = 10;
	public const CompoundControllerElementType Hat = 11;
}

// Namespace: Rewired
public enum DeadZone2DType // TypeDefIndex: 6887
{
	// Fields
	public int value__; // 0x0
	public const DeadZone2DType Radial = 1;
	public const DeadZone2DType Axial = 2;
}

// Namespace: Rewired
public enum AxisSensitivity2DType // TypeDefIndex: 6888
{
	// Fields
	public int value__; // 0x0
	public const AxisSensitivity2DType Radial = 0;
	public const AxisSensitivity2DType Axial = 1;
}

// Namespace: Rewired
public enum ElementAssignmentType // TypeDefIndex: 6889
{
	// Fields
	public int value__; // 0x0
	public const ElementAssignmentType FullAxis = 0;
	public const ElementAssignmentType SplitAxis = 1;
	public const ElementAssignmentType Button = 2;
	public const ElementAssignmentType KeyboardKey = 3;
}

// Namespace: Rewired
public enum UpdateLoopType // TypeDefIndex: 6890
{
	// Fields
	public int value__; // 0x0
	public const UpdateLoopType Update = 0;
	public const UpdateLoopType FixedUpdate = 1;
	public const UpdateLoopType OnGUI = 2;
}

// Namespace: Rewired
public enum InputActionEventType // TypeDefIndex: 6891
{
	// Fields
	public int value__; // 0x0
	public const InputActionEventType Update = 0;
	public const InputActionEventType ButtonPressed = 1;
	public const InputActionEventType ButtonUnpressed = 2;
	public const InputActionEventType ButtonJustPressed = 3;
	public const InputActionEventType ButtonJustReleased = 4;
	public const InputActionEventType ButtonDoublePressed = 5;
	public const InputActionEventType ButtonJustDoublePressed = 6;
	public const InputActionEventType ButtonPressedForTime = 7;
	public const InputActionEventType ButtonJustPressedForTime = 8;
	public const InputActionEventType ButtonPressedForTimeJustReleased = 9;
	public const InputActionEventType ButtonShortPressed = 10;
	public const InputActionEventType ButtonJustShortPressed = 11;
	public const InputActionEventType ButtonShortPressJustReleased = 12;
	public const InputActionEventType ButtonLongPressed = 13;
	public const InputActionEventType ButtonJustLongPressed = 14;
	public const InputActionEventType ButtonLongPressJustReleased = 15;
	public const InputActionEventType ButtonRepeating = 16;
	public const InputActionEventType NegativeButtonPressed = 17;
	public const InputActionEventType NegativeButtonUnpressed = 18;
	public const InputActionEventType NegativeButtonJustPressed = 19;
	public const InputActionEventType NegativeButtonJustReleased = 20;
	public const InputActionEventType NegativeButtonDoublePressed = 21;
	public const InputActionEventType NegativeButtonJustDoublePressed = 22;
	public const InputActionEventType NegativeButtonPressedForTime = 23;
	public const InputActionEventType NegativeButtonJustPressedForTime = 24;
	public const InputActionEventType NegativeButtonPressedForTimeJustReleased = 25;
	public const InputActionEventType NegativeButtonShortPressed = 26;
	public const InputActionEventType NegativeButtonJustShortPressed = 27;
	public const InputActionEventType NegativeButtonShortPressJustReleased = 28;
	public const InputActionEventType NegativeButtonLongPressed = 29;
	public const InputActionEventType NegativeButtonJustLongPressed = 30;
	public const InputActionEventType NegativeButtonLongPressJustReleased = 31;
	public const InputActionEventType NegativeButtonRepeating = 32;
	public const InputActionEventType AxisActive = 33;
	public const InputActionEventType AxisInactive = 34;
	public const InputActionEventType AxisRawActive = 35;
	public const InputActionEventType AxisRawInactive = 36;
	public const InputActionEventType AxisActiveOrJustInactive = 37;
	public const InputActionEventType AxisRawActiveOrJustInactive = 38;
	public const InputActionEventType ButtonDoublePressJustReleased = 100;
	public const InputActionEventType ButtonSinglePressed = 101;
	public const InputActionEventType ButtonJustSinglePressed = 102;
	public const InputActionEventType ButtonSinglePressJustReleased = 103;
	public const InputActionEventType NegativeButtonDoublePressJustReleased = 150;
	public const InputActionEventType NegativeButtonSinglePressed = 151;
	public const InputActionEventType NegativeButtonJustSinglePressed = 152;
	public const InputActionEventType NegativeButtonSinglePressJustReleased = 153;
}

// Namespace: Rewired
public enum AxisSensitivityType // TypeDefIndex: 6892
{
	// Fields
	public int value__; // 0x0
	public const AxisSensitivityType Multiplier = 0;
	public const AxisSensitivityType Power = 1;
	public const AxisSensitivityType Curve = 2;
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
internal enum JoystickType // TypeDefIndex: 6893
{
	// Fields
	public int value__; // 0x0
	[CustomObfuscation(rename = False)]
	public const JoystickType Unknown = 0;
	[CustomObfuscation(rename = False)]
	public const JoystickType Gamepad = 1;
	[CustomObfuscation(rename = False)]
	public const JoystickType DualAnalogGamepad = 2;
	[CustomObfuscation(rename = False)]
	public const JoystickType SingleAnalogGamepad = 3;
	[CustomObfuscation(rename = False)]
	public const JoystickType DigitalGamepad = 4;
	[CustomObfuscation(rename = False)]
	public const JoystickType Joystick = 10;
	[CustomObfuscation(rename = False)]
	public const JoystickType AnalogJoystick = 11;
	[CustomObfuscation(rename = False)]
	public const JoystickType DigitalJoystick = 12;
	[CustomObfuscation(rename = False)]
	public const JoystickType Throttle = 20;
	[CustomObfuscation(rename = False)]
	public const JoystickType HOTAS = 21;
	[CustomObfuscation(rename = False)]
	public const JoystickType FlightYoke = 22;
	[CustomObfuscation(rename = False)]
	public const JoystickType FlightPedals = 23;
	[CustomObfuscation(rename = False)]
	public const JoystickType ThrottleQuadrant = 24;
	[CustomObfuscation(rename = False)]
	public const JoystickType TrimWheel = 25;
	[CustomObfuscation(rename = False)]
	public const JoystickType DrivingWheel = 40;
	[CustomObfuscation(rename = False)]
	public const JoystickType Pedals = 41;
	[CustomObfuscation(rename = False)]
	public const JoystickType GearShifter = 42;
	[CustomObfuscation(rename = False)]
	public const JoystickType Guitar = 50;
	[CustomObfuscation(rename = False)]
	public const JoystickType Drums = 51;
	[CustomObfuscation(rename = False)]
	public const JoystickType DancePad = 70;
	[CustomObfuscation(rename = False)]
	public const JoystickType Paddle = 80;
	[CustomObfuscation(rename = False)]
	public const JoystickType Spinner = 81;
	[CustomObfuscation(rename = False)]
	public const JoystickType Trackball = 82;
	[CustomObfuscation(rename = False)]
	public const JoystickType Gun = 83;
	[CustomObfuscation(rename = False)]
	public const JoystickType RemoteControl = 100;
	[CustomObfuscation(rename = False)]
	public const JoystickType PointingDevice = 101;
	[CustomObfuscation(rename = False)]
	public const JoystickType ShipController = 120;
	[CustomObfuscation(rename = False)]
	public const JoystickType TrainController = 121;
	[CustomObfuscation(rename = False)]
	public const JoystickType HelicopterController = 122;
	[CustomObfuscation(rename = False)]
	public const JoystickType FootController = 123;
	[CustomObfuscation(rename = False)]
	public const JoystickType ControlPanel = 140;
	[CustomObfuscation(rename = False)]
	public const JoystickType Keypad = 141;
	[CustomObfuscation(rename = False)]
	public const JoystickType VRController = 150;
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
internal enum InputSource // TypeDefIndex: 6894
{
	// Fields
	public int value__; // 0x0
	public const InputSource None = 0;
	public const InputSource DirectInput = 1;
	public const InputSource XInput = 2;
	public const InputSource OSX = 3;
	public const InputSource Fallback = 4;
	public const InputSource RawInput = 5;
	public const InputSource Fallback_PreConfigured = 6;
	public const InputSource Linux = 7;
	public const InputSource WindowsUWP = 8;
	public const InputSource WebGL = 9;
	public const InputSource Steam = 18;
	public const InputSource SDL2 = 19;
	public const InputSource Ouya = 20;
	public const InputSource XboxOne = 21;
	public const InputSource PS4 = 22;
	public const InputSource NintendoSwitch = 24;
	public const InputSource GameCoreXboxOne = 26;
	public const InputSource GameCoreScarlett = 27;
	public const InputSource PS5 = 28;
	public const InputSource AppleGameController = 29;
	public const InputSource WindowsGamingInput = 30;
	public const InputSource InternalDriver = 49;
	public const InputSource UnityKeyboardAndMouse = 50;
	public const InputSource Custom = 100;
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
internal enum InputPlatform // TypeDefIndex: 6895
{
	// Fields
	public int value__; // 0x0
	public const InputPlatform Unknown = 0;
	public const InputPlatform WindowsDirectInput = 1;
	public const InputPlatform WindowsRawInput = 2;
	public const InputPlatform WindowsXInput = 3;
	public const InputPlatform WindowsFallback = 4;
	public const InputPlatform WindowsUWP = 5;
	public const InputPlatform WindowsUWPFallback = 6;
	public const InputPlatform WindowsWGI = 7;
	public const InputPlatform OSXNative = 8;
	public const InputPlatform OSXFallback = 9;
	public const InputPlatform LinuxNative = 10;
	public const InputPlatform LinuxFallback = 11;
	public const InputPlatform LinuxFallback_PreConfigured = 12;
	public const InputPlatform AndroidFallback = 13;
	public const InputPlatform AmazonFireTVFallback = 14;
	public const InputPlatform RazerForgeTVFallback = 15;
	public const InputPlatform iOSFallback = 16;
	public const InputPlatform WindowsPhone8Fallback = 17;
	public const InputPlatform BlackberryFallback = 18;
	public const InputPlatform PS3Fallback = 19;
	public const InputPlatform PS4Fallback = 20;
	public const InputPlatform PSMFallback = 21;
	public const InputPlatform PSVitaFallback = 22;
	public const InputPlatform XBox360Fallback = 23;
	public const InputPlatform XBoxOneFallback = 24;
	public const InputPlatform WiiFallback = 25;
	public const InputPlatform WiiUFallback = 26;
	public const InputPlatform Fallback = 27;
	public const InputPlatform Ouya = 28;
	public const InputPlatform XboxOne = 29;
	public const InputPlatform GameCore = 30;
	public const InputPlatform PS4 = 31;
	public const InputPlatform PS5 = 32;
	public const InputPlatform NintendoSwitch = 33;
	public const InputPlatform NintendoSwitchFallback = 34;
	public const InputPlatform Custom = 35;
	public const InputPlatform InternalDriver = 36;
	public const InputPlatform SDL2 = 37;
	public const InputPlatform SDL2Windows = 38;
	public const InputPlatform SDL2OSX = 39;
	public const InputPlatform SDL2Linux = 40;
	public const InputPlatform Steam = 41;
	public const InputPlatform WebGL = 42;
	public const InputPlatform AppleGameController = 43;
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
internal enum ControlDeviceType // TypeDefIndex: 6896
{
	// Fields
	public int value__; // 0x0
	public const ControlDeviceType Keyboard = 0;
	public const ControlDeviceType Mouse = 1;
	public const ControlDeviceType Joystick = 2;
	public const ControlDeviceType Gamepad = 3;
	public const ControlDeviceType ArcadeStick = 4;
	public const ControlDeviceType DancePad = 5;
	public const ControlDeviceType DrumKit = 6;
	public const ControlDeviceType Flight = 7;
	public const ControlDeviceType Throttle = 8;
	public const ControlDeviceType Guitar = 9;
	public const ControlDeviceType Wheel = 10;
	public const ControlDeviceType Paddle = 11;
	public const ControlDeviceType Custom = 99;
	public const ControlDeviceType Unknown = 100;
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
internal enum ControllerSubType // TypeDefIndex: 6897
{
	// Fields
	public int value__; // 0x0
	public const ControllerSubType None = 0;
	public const ControllerSubType Gamepad = 1;
	public const ControllerSubType Guitar = 2;
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
internal enum BoolOption // TypeDefIndex: 6898
{
	// Fields
	public int value__; // 0x0
	public const BoolOption Default = 0;
	public const BoolOption True = 1;
	public const BoolOption False = 2;
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[Flags]
internal enum ButtonStateFlags // TypeDefIndex: 6899
{
	// Fields
	public int value__; // 0x0
	public const ButtonStateFlags Off = 0;
	public const ButtonStateFlags On = 1;
	public const ButtonStateFlags Down = 2;
	public const ButtonStateFlags Up = 4;
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
internal enum MultiBoolValue // TypeDefIndex: 6900
{
	// Fields
	public int value__; // 0x0
	public const MultiBoolValue Off = 0;
	public const MultiBoolValue On = 1;
	public const MultiBoolValue Mixed = 2;
}

// Namespace: Rewired
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
[EditorBrowsable(1)]
[Browsable(False)]
public sealed class Initializer : MonoBehaviour // TypeDefIndex: 6901
{
	// Fields
	[SerializeField]
	private GameObject _inputManagerPrefab; // 0x20
	[SerializeField]
	private bool _destroySelf; // 0x28

	// Properties
	public GameObject inputManagerPrefab { get; set; }
	public bool destroySelf { get; set; }

	// Methods

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public GameObject get_inputManagerPrefab() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_inputManagerPrefab(GameObject value) { }

	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_destroySelf() { }

	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	public void set_destroySelf(bool value) { }

	// RVA: 0x1A3D9A0 Offset: 0x1A3CBA0 VA: 0x181A3D9A0
	private void Awake() { }

	// RVA: 0x1A3D9B0 Offset: 0x1A3CBB0 VA: 0x181A3D9B0
	public bool Initialize() { }

	// RVA: 0x1A3DEE0 Offset: 0x1A3D0E0 VA: 0x181A3DEE0
	public void .ctor() { }
}

// Namespace: Rewired
public interface IControllerElementTarget // TypeDefIndex: 6902
{
	// Properties
	public abstract int elementIdentifierId { get; }
	public abstract AxisRange axisRange { get; }
	public abstract bool hasTarget { get; }
	public abstract ControllerElementType elementType { get; }
	public abstract string descriptiveName { get; }
	public abstract Controller controller { get; }
	public abstract Controller.Element element { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_elementIdentifierId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract AxisRange get_axisRange();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_hasTarget();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract ControllerElementType get_elementType();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_descriptiveName();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Controller get_controller();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Controller.Element get_element();
}

// Namespace: Rewired
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
[CustomObfuscation(rename = False)]
internal class BridgedControllerHWInfo // TypeDefIndex: 6903
{
	// Fields
	public bool isMock; // 0x10
	public InputSource inputManagerSource; // 0x14
	public InputSource inputSource; // 0x18
	public ControlDeviceType deviceType; // 0x1C
	public string hardwareIdentifier; // 0x20
	public int hardwareAxisCount; // 0x28
	public int hardwareButtonCount; // 0x2C
	public int hardwareHatCount; // 0x30
	public string hw_productName; // 0x38
	public PidVid hw_pidVid; // 0x40
	public Guid hw_deviceGuid; // 0x44
	public int hw_productId; // 0x54
	public string hw_bluetoothDeviceName; // 0x58
	public bool hw_isBluetoothDevice; // 0x60
	public bool hw_supportsVoice; // 0x61
	public bool hw_supportsVibration; // 0x62
	public XInputDeviceSubType hw_xInputSubType; // 0x64
	public string hw_manufacturer; // 0x68
	public string hw_serialNumber; // 0x70
	public int hw_vendorId; // 0x78
	public int hw_version; // 0x7C
	public string hw_systemDeviceName; // 0x80
	public bool hw_isSDL2Gamepad; // 0x88
	public WebGLWebBrowserType webGL_webBrowserType; // 0x8C
	public WebGLOSType webGL_osType; // 0x90
	public WebGLGamepadMappingType webGL_mappingType; // 0x94
	public string[] webGL_webBrowserVersionSplit; // 0x98
	public string[] webGL_osVersionSplit; // 0xA0
	public int hw_localVibrationMotorCount; // 0xA8
	public string definitionMatchTag; // 0xB0
	public object userCustomIdentifier; // 0xB8

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1A39380 Offset: 0x1A38580 VA: 0x181A39380
	public void .ctor(BridgedControllerHWInfo ) { }

	// RVA: 0x1A394B0 Offset: 0x1A386B0 VA: 0x181A394B0
	private void yuxuEJbIVLWtkwthHqGVzOMVetZcA(BridgedControllerHWInfo ) { }
}

// Namespace: Rewired
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
[CustomObfuscation(rename = False)]
internal class BridgedController : BridgedControllerHWInfo // TypeDefIndex: 6904
{
	// Fields
	public IInputManagerJoystickPublic sourceJoystick; // 0xC0
	public HardwareControllerMap_Game gameHardwareMap; // 0xC8
	public Guid controllerTypeGuid; // 0xD0
	public Controller.Extension controllerExtension; // 0xE0
	public string instanceName; // 0xE8
	public string productName; // 0xF0
	public bool isXInputDevice; // 0xF8
	public int axisCount; // 0xFC
	public int buttonCount; // 0x100
	public bool[] isButtonPressureSensitive; // 0x108
	public UnknownControllerHat[] unknownControllerHats; // 0x110
	public CustomInputSource customInputSource; // 0x118

	// Properties
	public bool isUnknownController { get; }

	// Methods

	// RVA: 0x1A395B0 Offset: 0x1A387B0 VA: 0x181A395B0
	public bool get_isUnknownController() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
internal class hLADcALOrVCJyFwWInyzhsJNNlIW // TypeDefIndex: 6905
{
	// Fields
	public int BBwCQyVLbzyfoFVwkYtvzileXHhL; // 0x10
	public int oPtBJpAbNRQXFCbrDosNBdELOOqMA; // 0x14
	public Guid kXnFqpvrnSKfltwyqfulfEihxTHJ; // 0x18
	public InputSource PKfQXIKSJfbcbHmkplZndVmtesxB; // 0x28
	public string FKFDptkXfEYxuAeonheFJtcUcTJTA; // 0x30
	public string xOVyQoDISpaYScwGYyxNJWLNNGiB; // 0x38
	public string gywNPpNprBDQoqySlcvOPHlaNdld; // 0x40
	public int KLiLeFOmHnIKewzsCXwtlSRRgkOA; // 0x48
	public int ZwxoEwSrePraFcQWlwoanfflAcnb; // 0x4C
	public HardwareControllerMap_Game CyzNmSiOnneVZzpcZcvdcHhgJEIBA; // 0x50

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Rewired
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
[CustomObfuscation(rename = False)]
internal class ControllerDataUpdater // TypeDefIndex: 6906
{
	// Fields
	public readonly InputSource source; // 0x10
	public readonly int axisCount; // 0x14
	public readonly int buttonCount; // 0x18
	public readonly float[] axisValues; // 0x20
	public readonly bool[] buttonValues; // 0x28
	public readonly float[] buttonPressureValues; // 0x30
	public readonly bool[] axisHasBeenPressedOSXLinux; // 0x38
	private readonly UnknownControllerHat[] XxiVBiXMccfqFdlHaXacCcmBKPVy; // 0x40
	public bool hasReceivedInput; // 0x48

	// Methods

	// RVA: 0x1A39F30 Offset: 0x1A39130 VA: 0x181A39F30
	public void .ctor(InputSource , int , int , UnknownControllerHat[] ) { }

	// RVA: 0x1A39E90 Offset: 0x1A39090 VA: 0x181A39E90
	public bool IsUnknownHatCardinal(int buttonIndex) { }

	// RVA: 0x1A39DD0 Offset: 0x1A38FD0 VA: 0x181A39DD0
	public UnknownControllerHat.HatButtons GetUnknownHatButtons(int buttonIndex) { }

	// RVA: 0x1A39D40 Offset: 0x1A38F40 VA: 0x181A39D40
	public void ClearData() { }
}

// Namespace: Rewired
[ComVisible(False)]
[Usage(32767, AllowMultiple = False, Inherited = False)]
internal sealed class CustomObfuscation : Attribute // TypeDefIndex: 6907
{
	// Fields
	public bool rename; // 0x10

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: Rewired
[ComVisible(False)]
[Usage(1036, AllowMultiple = False, Inherited = False)]
internal sealed class CustomClassObfuscation : Attribute // TypeDefIndex: 6908
{
	// Fields
	public bool renamePubIntMembers; // 0x10
	public bool renamePrivateMembers; // 0x11

	// Methods

	// RVA: 0x1A3A0A0 Offset: 0x1A392A0 VA: 0x181A3A0A0
	public void .ctor() { }
}

// Namespace: Rewired
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
[CustomObfuscation(rename = False)]
internal class UpdateControllerInfoEventArgs : EventArgs // TypeDefIndex: 6909
{
	// Fields
	public readonly IInputManagerJoystickPublic sourceJoystick; // 0x10

	// Methods

	// RVA: 0x1A48EB0 Offset: 0x1A480B0 VA: 0x181A48EB0
	public void .ctor(IInputManagerJoystickPublic ) { }
}

// Namespace: Rewired
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
[CustomObfuscation(rename = False)]
internal class ControllerDisconnectedEventArgs : EventArgs // TypeDefIndex: 6910
{
	// Fields
	public readonly int rewiredId; // 0x10

	// Methods

	// RVA: 0x1A3A040 Offset: 0x1A39240 VA: 0x181A3A040
	public void .ctor(int ) { }
}

// Namespace: 
private enum InputManager_Base.QaWsdAhWeCuWuupjgqVtkkSdPItW // TypeDefIndex: 6911
{
	// Fields
	public int value__; // 0x0
	public const InputManager_Base.QaWsdAhWeCuWuupjgqVtkkSdPItW Initialization = 0;
	public const InputManager_Base.QaWsdAhWeCuWuupjgqVtkkSdPItW Update = 1;
	public const InputManager_Base.QaWsdAhWeCuWuupjgqVtkkSdPItW Destroy = 2;
}

// Namespace: Rewired
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
[AddComponentMenu("")]
[Browsable(False)]
[EditorBrowsable(1)]
[ExecuteInEditMode]
public abstract class InputManager_Base : MonoBehaviour // TypeDefIndex: 6912
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _dontDestroyOnLoad; // 0x20
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private UserData _userData; // 0x28
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private ControllerDataFiles _controllerDataFiles; // 0x30
	protected bool isCompiling; // 0x38
	private bool DzRdwaCjMKOeYXXRtYawwePnAsSb; // 0x39
	private bool JMXakObERIcQlPedQDPofRvkEXAJ; // 0x3A
	protected EditorPlatform editorPlatform; // 0x3C
	protected Platform platform; // 0x40
	protected WebplayerPlatform webplayerPlatform; // 0x44
	protected bool isEditor; // 0x48
	protected bool _detectedPlatformInEditor; // 0x49
	[CustomObfuscation(rename = False)]
	protected ScriptingBackend scriptingBackend; // 0x4C
	[CustomObfuscation(rename = False)]
	protected ScriptingAPILevel scriptingAPILevel; // 0x50
	private bool KjvOSuiiWsDXdgPwyjtCAHaFbfxQc; // 0x54
	private bool lcpeEDHCAZYjmtCaDnroKTUVmwtF; // 0x55

	// Properties
	public UserData userData { get; set; }
	public ControllerDataFiles dataFiles { get; set; }
	public bool runInEditMode { get; set; }
	internal bool isRunningInEditMode { get; }

	// Methods

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public UserData get_userData() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	internal void set_userData(UserData value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public ControllerDataFiles get_dataFiles() { }

	// RVA: 0x1A40530 Offset: 0x1A3F730 VA: 0x181A40530
	public void set_dataFiles(ControllerDataFiles value) { }

	// RVA: 0x1A402A0 Offset: 0x1A3F4A0 VA: 0x181A402A0
	public bool get_runInEditMode() { }

	// RVA: 0x1A405F0 Offset: 0x1A3F7F0 VA: 0x181A405F0
	public void set_runInEditMode(bool value) { }

	// RVA: 0x1A40180 Offset: 0x1A3F380 VA: 0x181A40180
	internal bool get_isRunningInEditMode() { }

	// RVA: 0x1A3E190 Offset: 0x1A3D390 VA: 0x181A3E190
	internal void DontDestroyOnLoad() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A3DF60 Offset: 0x1A3D160 VA: 0x181A3DF60
	private void Awake() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A3EAF0 Offset: 0x1A3DCF0 VA: 0x181A3EAF0
	private void OnEnable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A3EA70 Offset: 0x1A3DC70 VA: 0x181A3EA70
	private void OnDisable() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A3E930 Offset: 0x1A3DB30 VA: 0x181A3E930
	private void OnDestroy() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A3E870 Offset: 0x1A3DA70 VA: 0x181A3E870
	private void OnApplicationFocus(bool isFocused) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A3E8D0 Offset: 0x1A3DAD0 VA: 0x181A3E8D0
	private void OnApplicationPause(bool isPaused) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A3EF90 Offset: 0x1A3E190 VA: 0x181A3EF90
	private void Start() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A3F500 Offset: 0x1A3E700 VA: 0x181A3F500
	private void Update() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A3E240 Offset: 0x1A3D440 VA: 0x181A3E240
	private void FixedUpdate() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A3E780 Offset: 0x1A3D980 VA: 0x181A3E780
	private void LateUpdate() { }

	// RVA: 0x1A3EBA0 Offset: 0x1A3DDA0 VA: 0x181A3EBA0
	internal void OnGUIUpdate() { }

	// RVA: 0x1A3E020 Offset: 0x1A3D220 VA: 0x181A3E020
	internal void DoUpdate(UpdateLoopType updateLoopType, UpdateLoopSetting updateLoopSettingBit) { }

	// RVA: 0x1A3F040 Offset: 0x1A3E240 VA: 0x181A3F040
	internal void TryStartRunInEditMode() { }

	// RVA: 0x1A3F410 Offset: 0x1A3E610 VA: 0x181A3F410
	internal void TryStopRunInEditMode() { }

	// RVA: 0x1A404C0 Offset: 0x1A3F6C0 VA: 0x181A404C0
	private bool rIiyRCuJTPRXiFMVgpeICMqKUjfW() { }

	// RVA: 0x1A3F800 Offset: 0x1A3EA00 VA: 0x181A3F800
	private void ZFUcTEcndvHgBpdTmEAgSebxfOsJ() { }

	// RVA: 0x433450 Offset: 0x432650 VA: 0x180433450
	private void LmQOVlXFnEdulgTQWrGzKNoJHMKhA(Platform ) { }

	// RVA: 0x1A402D0 Offset: 0x1A3F4D0 VA: 0x181A402D0
	private object jacodEvEWXPZQmadqfvEDFYcQJLv(ConfigVars ) { }

	// RVA: 0x1A408C0 Offset: 0x1A3FAC0 VA: 0x181A408C0
	private List<Assembly> tHnZLWVwqKJneIKeKQNPDtZemqJL() { }

	// RVA: 0x1A3F5C0 Offset: 0x1A3E7C0 VA: 0x181A3F5C0
	private List<Assembly> UzFbypJnyanyPzHvktwrOlzWRAfX() { }

	// RVA: 0x1A40390 Offset: 0x1A3F590 VA: 0x181A40390
	private byte[] lpqfqeiFYIoLKhcIkdeqnwCcbiWtc() { }

	// RVA: 0x1A3EE30 Offset: 0x1A3E030 VA: 0x181A3EE30
	private void SpCoSlCoKtbGYlBmdyHKAeBBlBbr(List<TextAsset> , List<string> ) { }

	// RVA: 0x1A407D0 Offset: 0x1A3F9D0 VA: 0x181A407D0
	private string sgjGHHYUeAYLKsAqUHvQrPPSeGrH() { }

	// RVA: 0x1A3DFF0 Offset: 0x1A3D1F0 VA: 0x181A3DFF0
	private bool BaLlOcJytwnfReDdALMESaOEwlSr() { }

	// RVA: 0x1A40BC0 Offset: 0x1A3FDC0 VA: 0x181A40BC0
	private string xUOmdGdwEdWWRCPQGhhemMOllzZE() { }

	// RVA: 0x1A3E300 Offset: 0x1A3D500 VA: 0x181A3E300
	private bool GUwulpMVgpBaLzIGeFfgblaALtETA() { }

	// RVA: 0x1A3ED70 Offset: 0x1A3DF70 VA: 0x181A3ED70
	protected void RecompileStart() { }

	// RVA: 0x1A3ED00 Offset: 0x1A3DF00 VA: 0x181A3ED00
	protected void RecompileEnd() { }

	// RVA: 0x1A3EC60 Offset: 0x1A3DE60 VA: 0x181A3EC60
	protected void OnSceneLoaded() { }

	// RVA: 0x1A3E630 Offset: 0x1A3D830 VA: 0x181A3E630
	private void KcjbPAEmxMYZcKpAHJkbmEbUsWsbb(InputManager_Base.QaWsdAhWeCuWuupjgqVtkkSdPItW , string , Exception ) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A3EDC0 Offset: 0x1A3DFC0 VA: 0x181A3EDC0
	internal void ResetAll() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A3E460 Offset: 0x1A3D660 VA: 0x181A3E460
	internal EditorPlatform GetEditorPlatform() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A3E4B0 Offset: 0x1A3D6B0 VA: 0x181A3E4B0
	internal void GetSupportedEditModeControllerTypes(out bool keyboardSupported, out bool mouseSupported, out bool joystickSupported) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A3E560 Offset: 0x1A3D760 VA: 0x181A3E560
	internal bool IsEditModeSupported() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void OnInitialized();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void OnDeinitialized();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void DetectPlatform();

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void CheckRecompile();

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract IExternalTools GetExternalTools();

	// RVA: 0x1A40110 Offset: 0x1A3F310 VA: 0x181A40110
	protected void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1A3DEF0 Offset: 0x1A3D0F0 VA: 0x181A3DEF0
	private bool AMkTMlzeWptPhGWfxHpCfNmBKQBp(Assembly ) { }
}

// Namespace: 
private class miUysssUdqGWyuAUsKAOqijtIpUFA.hPmaWLKxlPjSWokwgLzgmVtmKjvO.HKaxNlaiqhbTezgCXcKGSiNStQzy : ExpandableArray_DataContainer.SnTbgaLArwcksHIfUWecJqheiFktA<miUysssUdqGWyuAUsKAOqijtIpUFA.hPmaWLKxlPjSWokwgLzgmVtmKjvO.HKaxNlaiqhbTezgCXcKGSiNStQzy>, IComparable<miUysssUdqGWyuAUsKAOqijtIpUFA.hPmaWLKxlPjSWokwgLzgmVtmKjvO.HKaxNlaiqhbTezgCXcKGSiNStQzy> // TypeDefIndex: 6913
{
	// Fields
	public KeyboardKeyCode OBqnLJQoPJGIQnqhihiXTClNELYH; // 0x10
	public ModifierKeyFlags HTCRiTYIyBqcIWwEehvmnNMGhLVW; // 0x14

	// Methods

	// RVA: 0x163EC80 Offset: 0x163DE80 VA: 0x18163EC80
	public void aLEuiSRTQwaSBsXbGGQLCoTwTDkl(KeyboardKeyCode , ModifierKeyFlags ) { }

	// RVA: 0x1A3D980 Offset: 0x1A3CB80 VA: 0x181A3D980 Slot: 4
	public void Set(miUysssUdqGWyuAUsKAOqijtIpUFA.hPmaWLKxlPjSWokwgLzgmVtmKjvO.HKaxNlaiqhbTezgCXcKGSiNStQzy ) { }

	// RVA: 0x1A3D950 Offset: 0x1A3CB50 VA: 0x181A3D950 Slot: 5
	public bool Equals(miUysssUdqGWyuAUsKAOqijtIpUFA.hPmaWLKxlPjSWokwgLzgmVtmKjvO.HKaxNlaiqhbTezgCXcKGSiNStQzy ) { }

	// RVA: 0x1A3D940 Offset: 0x1A3CB40 VA: 0x181A3D940 Slot: 6
	public void Clear() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 7
	public int CompareTo(miUysssUdqGWyuAUsKAOqijtIpUFA.hPmaWLKxlPjSWokwgLzgmVtmKjvO.HKaxNlaiqhbTezgCXcKGSiNStQzy other) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private enum miUysssUdqGWyuAUsKAOqijtIpUFA.hPmaWLKxlPjSWokwgLzgmVtmKjvO.bTpUOqWlcfXUWPlKmCnYQicHdfDIA // TypeDefIndex: 6914
{
	// Fields
	public int value__; // 0x0
	public const miUysssUdqGWyuAUsKAOqijtIpUFA.hPmaWLKxlPjSWokwgLzgmVtmKjvO.bTpUOqWlcfXUWPlKmCnYQicHdfDIA Map = 0;
	public const miUysssUdqGWyuAUsKAOqijtIpUFA.hPmaWLKxlPjSWokwgLzgmVtmKjvO.bTpUOqWlcfXUWPlKmCnYQicHdfDIA ActiveSet = 1;
}

// Namespace: 
public class miUysssUdqGWyuAUsKAOqijtIpUFA.hPmaWLKxlPjSWokwgLzgmVtmKjvO // TypeDefIndex: 6915
{
	// Fields
	private ModifierKeyFlags qSIdsomQoOFavalsxwHZfqKZetUe; // 0x10
	private ExpandableArray_DataContainer<miUysssUdqGWyuAUsKAOqijtIpUFA.hPmaWLKxlPjSWokwgLzgmVtmKjvO.HKaxNlaiqhbTezgCXcKGSiNStQzy> fJmjEYyyOcPdxcXbALzRpARMDzAs; // 0x18
	private ExpandableArray_DataContainer<miUysssUdqGWyuAUsKAOqijtIpUFA.hPmaWLKxlPjSWokwgLzgmVtmKjvO.HKaxNlaiqhbTezgCXcKGSiNStQzy> uydKgkcFiaDayxdjvaPRkamvhShK; // 0x20
	private Keyboard qZgrmcpPeoabLCnpRvxLGlSiELHVA; // 0x28

	// Methods

	// RVA: 0x1A4A9E0 Offset: 0x1A49BE0 VA: 0x181A4A9E0
	public void .ctor(Keyboard ) { }

	// RVA: 0x1A4A8F0 Offset: 0x1A49AF0 VA: 0x181A4A8F0
	public void NXsdcUmvlchkKwnLJYZgvWkOUNSV() { }

	// RVA: 0x1A4A3D0 Offset: 0x1A495D0 VA: 0x181A4A3D0
	public void CKoTgMEQWvEahbtwiKADfYSXviju(ActionElementMap ) { }

	// RVA: 0x1A4A600 Offset: 0x1A49800 VA: 0x181A4A600
	public bool GfrjaqwinfUAOVwAjqWAflGvYOIj(KeyboardKeyCode , ModifierKeyFlags , miUysssUdqGWyuAUsKAOqijtIpUFA.BlIPisgNSfOTlqjStOijLZyYBubM , out bool ) { }

	// RVA: 0x1A4A480 Offset: 0x1A49680 VA: 0x181A4A480
	private bool GfrjaqwinfUAOVwAjqWAflGvYOIj(ExpandableArray_DataContainer<miUysssUdqGWyuAUsKAOqijtIpUFA.hPmaWLKxlPjSWokwgLzgmVtmKjvO.HKaxNlaiqhbTezgCXcKGSiNStQzy> , KeyboardKeyCode , ModifierKeyFlags , int , miUysssUdqGWyuAUsKAOqijtIpUFA.hPmaWLKxlPjSWokwgLzgmVtmKjvO.bTpUOqWlcfXUWPlKmCnYQicHdfDIA , miUysssUdqGWyuAUsKAOqijtIpUFA.BlIPisgNSfOTlqjStOijLZyYBubM , ref bool ) { }

	// RVA: 0x1A4AAA0 Offset: 0x1A49CA0 VA: 0x181A4AAA0
	public void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }
}

// Namespace: 
public enum miUysssUdqGWyuAUsKAOqijtIpUFA.BlIPisgNSfOTlqjStOijLZyYBubM // TypeDefIndex: 6916
{
	// Fields
	public int value__; // 0x0
	public const miUysssUdqGWyuAUsKAOqijtIpUFA.BlIPisgNSfOTlqjStOijLZyYBubM Normal = 0;
	public const miUysssUdqGWyuAUsKAOqijtIpUFA.BlIPisgNSfOTlqjStOijLZyYBubM OverlapModifiers = 1;
}

// Namespace: 
internal class miUysssUdqGWyuAUsKAOqijtIpUFA // TypeDefIndex: 6917
{
	// Fields
	private readonly miUysssUdqGWyuAUsKAOqijtIpUFA.hPmaWLKxlPjSWokwgLzgmVtmKjvO[] pqinjZlQeZJDRSwEhqbtRAUzDCwr; // 0x10
	private UpdateLoopType cCgYCUDwBYOudomcpBworRxTuvcG; // 0x18
	private readonly Keyboard qZgrmcpPeoabLCnpRvxLGlSiELHVA; // 0x20
	private miUysssUdqGWyuAUsKAOqijtIpUFA.hPmaWLKxlPjSWokwgLzgmVtmKjvO iTFuASGuQutVUojQqElkbhgbLQmGA; // 0x28

	// Methods

	// RVA: 0x1A4FDE0 Offset: 0x1A4EFE0 VA: 0x181A4FDE0
	public void .ctor(UpdateLoopSetting , Keyboard ) { }

	// RVA: 0x1A4FCC0 Offset: 0x1A4EEC0 VA: 0x181A4FCC0
	public void NXsdcUmvlchkKwnLJYZgvWkOUNSV(UpdateLoopType ) { }

	// RVA: 0x1A50130 Offset: 0x1A4F330 VA: 0x181A50130
	public void xggsohhIwpZCjUFsucCyEoATeiQP(KeyboardMap ) { }

	// RVA: 0x1A4FC90 Offset: 0x1A4EE90 VA: 0x181A4FC90
	public bool GfrjaqwinfUAOVwAjqWAflGvYOIj(KeyboardKeyCode , ModifierKeyFlags , miUysssUdqGWyuAUsKAOqijtIpUFA.BlIPisgNSfOTlqjStOijLZyYBubM , out bool ) { }

	// RVA: 0x1A500B0 Offset: 0x1A4F2B0 VA: 0x181A500B0
	public void lZhZavAAAUFpGJghlpqIsXiCeMdP() { }
}

// Namespace: 
internal static class golMrDFNImDvEzPTRPyWQwtSkGfF // TypeDefIndex: 6918
{
	// Methods

	// RVA: 0x1A49210 Offset: 0x1A48410 VA: 0x181A49210
	public static ControllerElementType FmnqJqKWCdLcdHeIBrgXKHGecBJR(ElementAssignmentType ) { }

	// RVA: 0x1A49B70 Offset: 0x1A48D70 VA: 0x181A49B70
	public static ElementAssignmentType eefAzJaMHLXjkLlmTSWXKjmOuyvTA(ControllerType , ControllerElementType , AxisRange ) { }

	// RVA: 0x1A49FF0 Offset: 0x1A491F0 VA: 0x181A49FF0
	public static AxisRange siCNpKMapKajlXEAeTtmViEBpihG(Pole ) { }

	// RVA: -1 Offset: -1
	public static Type JBoSHnXOjSFvlGDZIDbSgmXzAqYL<>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD71B0 Offset: 0xAD63B0 VA: 0x180AD71B0
	|-golMrDFNImDvEzPTRPyWQwtSkGfF.JBoSHnXOjSFvlGDZIDbSgmXzAqYL<object>
	*/

	// RVA: 0x1A492F0 Offset: 0x1A484F0 VA: 0x181A492F0
	public static Type JBoSHnXOjSFvlGDZIDbSgmXzAqYL(Type ) { }

	// RVA: 0x1A49A80 Offset: 0x1A48C80 VA: 0x181A49A80
	public static Type duDUHkKQtAgTrLugnMCyLwUCoRiT(ControllerType ) { }

	// RVA: 0x1A4A060 Offset: 0x1A49260 VA: 0x181A4A060
	public static Type uHyXGADdeISoKzJJioETkaqLYoFo(ControllerType ) { }

	// RVA: 0x1A49BF0 Offset: 0x1A48DF0 VA: 0x181A49BF0
	public static ControllerType rtkwSLksvbLAIrzcYCWIDKgjDeIP(Type ) { }

	// RVA: -1 Offset: -1
	public static ControllerType rtkwSLksvbLAIrzcYCWIDKgjDeIP<>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD72E0 Offset: 0xAD64E0 VA: 0x180AD72E0
	|-golMrDFNImDvEzPTRPyWQwtSkGfF.rtkwSLksvbLAIrzcYCWIDKgjDeIP<object>
	|-golMrDFNImDvEzPTRPyWQwtSkGfF.rtkwSLksvbLAIrzcYCWIDKgjDeIP<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1A499D0 Offset: 0x1A48BD0 VA: 0x181A499D0
	public static ControllerType ZBQuoIpAtBCyAnQLqFlEUGyPTfoV(Type ) { }

	// RVA: -1 Offset: -1
	public static ControllerType ZBQuoIpAtBCyAnQLqFlEUGyPTfoV<>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD7280 Offset: 0xAD6480 VA: 0x180AD7280
	|-golMrDFNImDvEzPTRPyWQwtSkGfF.ZBQuoIpAtBCyAnQLqFlEUGyPTfoV<object>
	*/

	// RVA: 0x1A49740 Offset: 0x1A48940 VA: 0x181A49740
	public static bool TjHDBRWvwBFzYStAZyVxfogJxgyr(Type , out ControllerType ) { }

	// RVA: -1 Offset: -1
	public static bool TjHDBRWvwBFzYStAZyVxfogJxgyr<>(out ControllerType ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD7210 Offset: 0xAD6410 VA: 0x180AD7210
	|-golMrDFNImDvEzPTRPyWQwtSkGfF.TjHDBRWvwBFzYStAZyVxfogJxgyr<object>
	*/

	// RVA: 0x1A48F10 Offset: 0x1A48110 VA: 0x181A48F10
	public static ControllerType BXODHsaPJyJOYMnhrDyZFVFCxuDXA(Type ) { }

	// RVA: -1 Offset: -1
	public static ControllerType BXODHsaPJyJOYMnhrDyZFVFCxuDXA<>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD7150 Offset: 0xAD6350 VA: 0x180AD7150
	|-golMrDFNImDvEzPTRPyWQwtSkGfF.BXODHsaPJyJOYMnhrDyZFVFCxuDXA<object>
	*/

	// RVA: 0x1A491A0 Offset: 0x1A483A0 VA: 0x181A491A0
	public static bool BxThmMJFHsklBXkYNDKZEyouGtEiA(ControllerTemplateElementType , ControllerElementType ) { }

	// RVA: 0x1A4A1B0 Offset: 0x1A493B0 VA: 0x181A4A1B0
	public static ControllerElementType ukweVPrzYwLVCRmhNDEFLWaQtnTt(object ) { }

	// RVA: 0x1A4A150 Offset: 0x1A49350 VA: 0x181A4A150
	public static ControllerElementType ukweVPrzYwLVCRmhNDEFLWaQtnTt(ControllerTemplateElementType ) { }

	// RVA: 0x1A49280 Offset: 0x1A48480 VA: 0x181A49280
	public static ControllerTemplateElementSourceType IyAAPAoocHDdOKpgljOdHkshVRYMA(ControllerTemplateElementType , bool ) { }

	// RVA: 0x1A496D0 Offset: 0x1A488D0 VA: 0x181A496D0
	public static ControllerTemplateElementType QBhGyvaSSmLLunXMqmXQivppGtZdb(ControllerElementType , bool ) { }
}

// Namespace: 
private class UnityInputHelper.NRiEJyQOZcjdGSjOrYYakfJmhWfBA // TypeDefIndex: 6919
{
	// Fields
	public string[] OPyVKPeWISBmuRxFQjcgutRriOTp; // 0x10
	public string[] TruLmjieKAjQseiaxGYEoHxpFBwKA; // 0x18

	// Methods

	// RVA: 0x1A44460 Offset: 0x1A43660 VA: 0x181A44460
	public void .ctor(int ) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal static class UnityInputHelper // TypeDefIndex: 6920
{
	// Fields
	private static UnityInputHelper.NRiEJyQOZcjdGSjOrYYakfJmhWfBA[] PgpGMyJfIPxDnbEBKMKFPoCrGZsy; // 0x0

	// Methods

	// RVA: 0x1A47270 Offset: 0x1A46470 VA: 0x181A47270
	private static void .cctor() { }

	// RVA: 0x1A46FD0 Offset: 0x1A461D0 VA: 0x181A46FD0
	public static float GetJoystickAxisValueByJoystickId(int joystickId, int axisIndex) { }

	// RVA: 0x1A46E30 Offset: 0x1A46030 VA: 0x181A46E30
	public static float GetJoystickAxisRawValueByJoystickId(int joystickId, int axisIndex) { }

	// RVA: 0x1A47090 Offset: 0x1A46290 VA: 0x181A47090
	public static float GetJoystickAxisValueByJoystickIndex(int joystickIndex, int axisIndex) { }

	// RVA: 0x1A46EF0 Offset: 0x1A460F0 VA: 0x181A46EF0
	public static float GetJoystickAxisRawValueByJoystickIndex(int joystickIndex, int axisIndex) { }

	// RVA: 0x1A47170 Offset: 0x1A46370 VA: 0x181A47170
	public static bool GetJoystickButtonValueByJoystickId(int joystickId, int buttonIndex) { }

	// RVA: 0x1A471E0 Offset: 0x1A463E0 VA: 0x181A471E0
	public static bool GetJoystickButtonValueByJoystickIndex(int joystickIndex, int buttonIndex) { }
}

// Namespace: Rewired
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal class UnityUnifiedKeyboardSource : IDisposable, IGetSetEnabled, IUnifiedKeyboardSource // TypeDefIndex: 6921
{
	// Fields
	private const int cTYIIhkSNLiIzOyoHHWyhltrjmEo = 132;
	private static HardwareControllerMap_Game bkpeQnrzthWzHwSMngJePMGPEpdc; // 0x0
	private bool AqHaORMjZGTdLoJMHbRKCeXHvJfRA; // 0x10
	private bool qlWbbXXJkXhrJOhRVlcxNUPVUYEt; // 0x11

	// Properties
	public bool enabled { get; set; }
	public InputSource inputSource { get; }
	public HardwareControllerMap_Game hardwareMap { get; }
	public int buttonCount { get; }
	public Controller.Extension controllerExtension { get; }

	// Methods

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0 Slot: 5
	public bool get_enabled() { }

	// RVA: 0x1A47C70 Offset: 0x1A46E70 VA: 0x181A47C70 Slot: 6
	public void set_enabled(bool value) { }

	// RVA: 0x1A47C60 Offset: 0x1A46E60 VA: 0x181A47C60 Slot: 7
	public InputSource get_inputSource() { }

	// RVA: 0x1A47BF0 Offset: 0x1A46DF0 VA: 0x181A47BF0 Slot: 8
	public HardwareControllerMap_Game get_hardwareMap() { }

	// RVA: 0xAA0220 Offset: 0xA9F420 VA: 0x180AA0220 Slot: 9
	public int get_buttonCount() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 10
	public Controller.Extension get_controllerExtension() { }

	// RVA: 0x1A47BA0 Offset: 0x1A46DA0 VA: 0x181A47BA0
	public void .ctor() { }

	// RVA: 0x1A47B60 Offset: 0x1A46D60 VA: 0x181A47B60 Slot: 11
	public void UpdateInputData(ControllerDataUpdater dataUpdater) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 12
	public void Clear() { }

	// RVA: 0x1A474D0 Offset: 0x1A466D0 VA: 0x181A474D0
	internal static HardwareControllerMap_Game CreateHardwareMap() { }

	// RVA: 0x1A47A00 Offset: 0x1A46C00 VA: 0x181A47A00 Slot: 4
	public void Dispose() { }

	// RVA: 0x1A47A70 Offset: 0x1A46C70 VA: 0x181A47A70 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A479B0 Offset: 0x1A46BB0 VA: 0x181A479B0 Slot: 13
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1A47AE0 Offset: 0x1A46CE0 VA: 0x181A47AE0
	public static ControllerElementType GetHardwareElementType(int elementIdentifierId) { }
}

// Namespace: 
private class UnityUnifiedMouseSource.JzaNzLeFZwZrYPQYPVmpeYgDiPE // TypeDefIndex: 6922
{
	// Fields
	private float[] kZCMRiuKzVOSvFpCWdFjhTBkEUqfb; // 0x10
	private bool[] AcHLuYOzXQNKrrMisukEDhcSTvbg; // 0x18

	// Methods

	// RVA: 0x1A40E20 Offset: 0x1A40020 VA: 0x181A40E20
	public void .ctor(int , int ) { }

	// RVA: 0x1A40D90 Offset: 0x1A3FF90 VA: 0x181A40D90
	public void UbRPHQAoOqIhIhFBngQdkLDKEylWA(bool[] , float[] ) { }

	// RVA: 0x1A40D30 Offset: 0x1A3FF30 VA: 0x181A40D30
	public void QXGFEDcQSZAQTFHvISReAVFlUexnc(ControllerDataUpdater ) { }

	// RVA: 0x1A40EA0 Offset: 0x1A400A0 VA: 0x181A40EA0
	public void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }

	// RVA: 0x1460BE0 Offset: 0x145FDE0 VA: 0x181460BE0
	public void pFfGoolcvMsfJvbnDAZYibXgrqkr() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UnityUnifiedMouseSource.NSKRXxSCXuNEijpFPgpyMrCMKnWf // TypeDefIndex: 6923
{
	// Fields
	public static readonly UnityUnifiedMouseSource.NSKRXxSCXuNEijpFPgpyMrCMKnWf <>9; // 0x0
	public static Func<UnityUnifiedMouseSource.JzaNzLeFZwZrYPQYPVmpeYgDiPE> <>9__20_0; // 0x8

	// Methods

	// RVA: 0x1A445E0 Offset: 0x1A437E0 VA: 0x181A445E0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1A44640 Offset: 0x1A43840 VA: 0x181A44640
	internal UnityUnifiedMouseSource.JzaNzLeFZwZrYPQYPVmpeYgDiPE eRCLLhlTuekgipUnHcNOGIhKGrVm() { }
}

// Namespace: Rewired
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal class UnityUnifiedMouseSource : IDisposable, IGetSetEnabled, IUnifiedMouseSource // TypeDefIndex: 6924
{
	// Fields
	private static HardwareControllerMap_Game bkpeQnrzthWzHwSMngJePMGPEpdc; // 0x0
	private UpdateLoopDataSet<UnityUnifiedMouseSource.JzaNzLeFZwZrYPQYPVmpeYgDiPE> npPflhdRYzRMfVkRceByHCLIUoEtA; // 0x10
	private float[] kZCMRiuKzVOSvFpCWdFjhTBkEUqfb; // 0x18
	private bool[] AcHLuYOzXQNKrrMisukEDhcSTvbg; // 0x20
	private bool AqHaORMjZGTdLoJMHbRKCeXHvJfRA; // 0x28
	private bool qlWbbXXJkXhrJOhRVlcxNUPVUYEt; // 0x29

	// Properties
	public bool enabled { get; set; }
	public InputSource inputSource { get; }
	public HardwareControllerMap_Game hardwareMap { get; }
	public int buttonCount { get; }
	public int axisCount { get; }
	public Vector2 mousePosition { get; }
	public Controller.Extension controllerExtension { get; }

	// Methods

	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840 Slot: 5
	public bool get_enabled() { }

	// RVA: 0x1A48DA0 Offset: 0x1A47FA0 VA: 0x181A48DA0 Slot: 6
	public void set_enabled(bool value) { }

	// RVA: 0x1A47C60 Offset: 0x1A46E60 VA: 0x181A47C60 Slot: 7
	public InputSource get_inputSource() { }

	// RVA: 0x1A48CE0 Offset: 0x1A47EE0 VA: 0x181A48CE0 Slot: 8
	public HardwareControllerMap_Game get_hardwareMap() { }

	// RVA: 0x68EEF0 Offset: 0x68E0F0 VA: 0x18068EEF0 Slot: 10
	public int get_buttonCount() { }

	// RVA: 0x68EEE0 Offset: 0x68E0E0 VA: 0x18068EEE0 Slot: 9
	public int get_axisCount() { }

	// RVA: 0x1A48D50 Offset: 0x1A47F50 VA: 0x181A48D50 Slot: 11
	public Vector2 get_mousePosition() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 12
	public Controller.Extension get_controllerExtension() { }

	// RVA: 0x1A48790 Offset: 0x1A47990 VA: 0x181A48790
	public void .ctor() { }

	// RVA: 0x1A48690 Offset: 0x1A47890 VA: 0x181A48690 Slot: 13
	public void UpdateInputData(ControllerDataUpdater dataUpdater) { }

	// RVA: 0x1A47CB0 Offset: 0x1A46EB0 VA: 0x181A47CB0 Slot: 14
	public void Clear() { }

	// RVA: 0x1A48B00 Offset: 0x1A47D00 VA: 0x181A48B00
	private void dJZINGdQBwGCMOGdTJNQolWLpWvu() { }

	// RVA: 0x1A48C60 Offset: 0x1A47E60 VA: 0x181A48C60
	private void dLnUPsbqRukVDQBCrjVMGxmSAHLmA(UpdateLoopType ) { }

	// RVA: 0x1A47D80 Offset: 0x1A46F80 VA: 0x181A47D80
	internal static HardwareControllerMap_Game CreateHardwareMap() { }

	// RVA: 0x1A48530 Offset: 0x1A47730 VA: 0x181A48530 Slot: 4
	public void Dispose() { }

	// RVA: 0x1A485A0 Offset: 0x1A477A0 VA: 0x181A485A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1A48410 Offset: 0x1A47610 VA: 0x181A48410 Slot: 15
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1A48610 Offset: 0x1A47810 VA: 0x181A48610
	public static ControllerElementType GetHardwareElementType(int elementIdentifierId) { }
}

// Namespace: 
private class ExsWQUADpWcumnyrnYXiDOGqeUGG.DXmDcCmphPVsAHGlJEgQpoWVbDVEA // TypeDefIndex: 6925
{
	// Fields
	private ButtonStateFlags XWkAhkkuRpPpkEyEESnxHkEbQqnc; // 0x10
	private ButtonStateFlags BUEdSdUrtzrmymYGbhlizCNxVUAG; // 0x14
	private ButtonStateFlags SWATOfTgGIhmhiwMiqfCYCGgqKjO; // 0x18
	private ButtonStateFlags UkzzVzCcusfQnFQoIaMTdnFLuwtW; // 0x1C
	private uint otTOEDroWYlnJxtoYsArHpWqMsDA; // 0x20
	private bool zCYVamfOzCFTzVFJLXnXhGxuEifE; // 0x24
	private bool SVQuDbVOluhmxFsATPxcgJaupsBMA; // 0x25
	private bool lvWcIAcFfvAuWLMPjuQmtwjtMreb; // 0x26
	private ExsWQUADpWcumnyrnYXiDOGqeUGG.cdqEevyssUnzqHpTaXFgkoRQTkdH BJcanMEoOfLuDMVmBAUUiVxWkCUEb; // 0x27

	// Properties
	public bool NuULxNORUqftTyXYbXPnjbCfRrMl { get; }
	public bool QTvEWGVqbyjtwfClkyajHnAXsVnBb { get; set; }

	// Methods

	// RVA: 0x695F30 Offset: 0x695130 VA: 0x180695F30
	public bool mQUDvtCIRGHBbBuaEREHcrhtDFFdc() { }

	// RVA: 0x695F20 Offset: 0x695120 VA: 0x180695F20
	public bool ZzXLQIsKQTBgUIhFeAULUUnXCynX() { }

	// RVA: 0x1A3A150 Offset: 0x1A39350 VA: 0x181A3A150
	public void vcCMfHGmwOUkULaMPGUmcOAdCLvIb(bool ) { }

	// RVA: 0x1A3A1F0 Offset: 0x1A393F0 VA: 0x181A3A1F0
	public ButtonStateFlags zIDkqnpzQxOIMoFOSZfGSAmrvFUo(bool ) { }

	// RVA: 0x1A3A0B0 Offset: 0x1A392B0 VA: 0x181A3A0B0
	public void NXsdcUmvlchkKwnLJYZgvWkOUNSV() { }

	// RVA: 0x1A3A140 Offset: 0x1A39340 VA: 0x181A3A140
	public void twVcScHySWZMoLhWIRwxsNbXpEOVA(uint ) { }

	// RVA: 0x1A3A110 Offset: 0x1A39310 VA: 0x181A3A110
	public void jxkABzseBaGanexcmctJaqxEFnLX(bool ) { }

	// RVA: 0x1A3A160 Offset: 0x1A39360 VA: 0x181A3A160
	public void xZAMuVaNKvgEjQODWwiCBrszWNAn(ButtonStateFlags , bool ) { }

	// RVA: 0x1A3A0D0 Offset: 0x1A392D0 VA: 0x181A3A0D0
	public void cNjamCbkorfsHeCUoVEPHPmnBUBvA(ref ExsWQUADpWcumnyrnYXiDOGqeUGG.cdqEevyssUnzqHpTaXFgkoRQTkdH ) { }

	// RVA: 0x1A3A0F0 Offset: 0x1A392F0 VA: 0x181A3A0F0
	public void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
public struct ExsWQUADpWcumnyrnYXiDOGqeUGG.cdqEevyssUnzqHpTaXFgkoRQTkdH // TypeDefIndex: 6926
{
	// Fields
	public bool UmHvNLqoDdTnshaHqeRtxnhnrQCi; // 0x0
	public bool JsrynYanaBFovzAEyKfwboXHlHDS; // 0x1

	// Properties
	public static ExsWQUADpWcumnyrnYXiDOGqeUGG.cdqEevyssUnzqHpTaXFgkoRQTkdH NIisWBDthRUxzcWrBoxWJilceYwj { get; }

	// Methods

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public static ExsWQUADpWcumnyrnYXiDOGqeUGG.cdqEevyssUnzqHpTaXFgkoRQTkdH ZUUhLvEoepDDTtiqzoLUncenXLub() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ExsWQUADpWcumnyrnYXiDOGqeUGG.EpkCQsgiPEHSOhgSLTPyQDxWSwhLA // TypeDefIndex: 6927
{
	// Fields
	public static readonly ExsWQUADpWcumnyrnYXiDOGqeUGG.EpkCQsgiPEHSOhgSLTPyQDxWSwhLA <>9; // 0x0
	public static Func<ExsWQUADpWcumnyrnYXiDOGqeUGG.DXmDcCmphPVsAHGlJEgQpoWVbDVEA> <>9__22_0; // 0x8

	// Methods

	// RVA: 0x1A3B870 Offset: 0x1A3AA70 VA: 0x181A3B870
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1A3B920 Offset: 0x1A3AB20 VA: 0x181A3B920
	internal ExsWQUADpWcumnyrnYXiDOGqeUGG yBBicgdjoCCeVHIqSEjmHBnIjPWkB() { }

	// RVA: 0x1A3B850 Offset: 0x1A3AA50 VA: 0x181A3B850
	internal void JhSkbaUkWlakFCGdnyFJIRlepJqzA(ExsWQUADpWcumnyrnYXiDOGqeUGG ) { }

	// RVA: 0x1A3B8D0 Offset: 0x1A3AAD0 VA: 0x181A3B8D0
	internal ExsWQUADpWcumnyrnYXiDOGqeUGG.DXmDcCmphPVsAHGlJEgQpoWVbDVEA htewCpLapIpZFQWjwEWcXEynPBmu() { }
}

// Namespace: 
internal class ExsWQUADpWcumnyrnYXiDOGqeUGG // TypeDefIndex: 6928
{
	// Fields
	private const int ZqdJNMrgeuSVUgKKMaofafnBpGgd = 20;
	private const int GDqdPRLOWrFbPphATQyXkBsmbGiR = 10;
	private static ObjectPool<ExsWQUADpWcumnyrnYXiDOGqeUGG> rtAssAuqXVYwHODFCbEGVEOyfhvw; // 0x0
	private static ExsWQUADpWcumnyrnYXiDOGqeUGG[] vmJykUncXAAtmhVCyIQVizjQQsdq; // 0x8
	private static int oebbiKyIGfmwUXLGlFpcuhPlhathA; // 0x10
	public int gCwAAkHorbwFHtJtqKBECGZelPGIA; // 0x10
	private UpdateLoopDataSet<ExsWQUADpWcumnyrnYXiDOGqeUGG.DXmDcCmphPVsAHGlJEgQpoWVbDVEA> pqinjZlQeZJDRSwEhqbtRAUzDCwr; // 0x18

	// Properties
	public bool NuULxNORUqftTyXYbXPnjbCfRrMl { get; }
	public bool QTvEWGVqbyjtwfClkyajHnAXsVnBb { get; set; }

	// Methods

	// RVA: 0x1A3C1E0 Offset: 0x1A3B3E0 VA: 0x181A3C1E0
	private static void .cctor() { }

	// RVA: 0x1A3C110 Offset: 0x1A3B310 VA: 0x181A3C110
	public static void PKwtxaXvImPLSHYDPPVYFvKIgugQ() { }

	// RVA: 0x1A3BF20 Offset: 0x1A3B120 VA: 0x181A3BF20
	public static ExsWQUADpWcumnyrnYXiDOGqeUGG HMlCXRDrttAdGlolCTpyqLsWiwIS(int ) { }

	// RVA: 0x1A3BC20 Offset: 0x1A3AE20 VA: 0x181A3BC20
	public static ExsWQUADpWcumnyrnYXiDOGqeUGG GuUJHJvayeaOkWrFtWBeDyUMOLnh(int , ExsWQUADpWcumnyrnYXiDOGqeUGG.cdqEevyssUnzqHpTaXFgkoRQTkdH ) { }

	// RVA: 0x1A3BB10 Offset: 0x1A3AD10 VA: 0x181A3BB10
	public static void FFkOdhlEPddEZCSFaMUJkPXkUVjJA(UpdateLoopType ) { }

	// RVA: 0x1A3CBB0 Offset: 0x1A3BDB0 VA: 0x181A3CBB0
	public static void twVcScHySWZMoLhWIRwxsNbXpEOVA(UpdateLoopType , uint ) { }

	// RVA: 0x1A3C520 Offset: 0x1A3B720 VA: 0x181A3C520
	private static void agrutVhnAbAlYoDznpzwcXSrZggc(ExsWQUADpWcumnyrnYXiDOGqeUGG ) { }

	// RVA: 0x1A3CEE0 Offset: 0x1A3C0E0 VA: 0x181A3CEE0
	private static void yiZFDTttkvclTieMRRaferLLXUaIA(int ) { }

	// RVA: 0x1A3CA70 Offset: 0x1A3BC70 VA: 0x181A3CA70
	private static int sKNeaCcTSAcoMbQPbhXDoqQdBoBs() { }

	// RVA: 0x1A3C9C0 Offset: 0x1A3BBC0 VA: 0x181A3C9C0
	public bool mQUDvtCIRGHBbBuaEREHcrhtDFFdc() { }

	// RVA: 0x1A3C190 Offset: 0x1A3B390 VA: 0x181A3C190
	public bool ZzXLQIsKQTBgUIhFeAULUUnXCynX() { }

	// RVA: 0x1A3CE00 Offset: 0x1A3C000 VA: 0x181A3CE00
	public void vcCMfHGmwOUkULaMPGUmcOAdCLvIb(bool ) { }

	// RVA: 0x1A3D060 Offset: 0x1A3C260 VA: 0x181A3D060
	public ButtonStateFlags zIDkqnpzQxOIMoFOSZfGSAmrvFUo(bool ) { }

	// RVA: 0x1A3C360 Offset: 0x1A3B560 VA: 0x181A3C360
	public void .ctor() { }

	// RVA: 0x1A3C070 Offset: 0x1A3B270 VA: 0x181A3C070
	public void NXsdcUmvlchkKwnLJYZgvWkOUNSV(UpdateLoopType ) { }

	// RVA: 0x1A3CD90 Offset: 0x1A3BF90 VA: 0x181A3CD90
	public void twVcScHySWZMoLhWIRwxsNbXpEOVA(uint ) { }

	// RVA: 0x1A3C940 Offset: 0x1A3BB40 VA: 0x181A3C940
	public void jxkABzseBaGanexcmctJaqxEFnLX(UpdateLoopType , bool ) { }

	// RVA: 0x1A3CE60 Offset: 0x1A3C060 VA: 0x181A3CE60
	public void xZAMuVaNKvgEjQODWwiCBrszWNAn(UpdateLoopType , ButtonStateFlags , bool ) { }

	// RVA: 0x1A3C7E0 Offset: 0x1A3B9E0 VA: 0x181A3C7E0
	private void cNjamCbkorfsHeCUoVEPHPmnBUBvA(ref ExsWQUADpWcumnyrnYXiDOGqeUGG.cdqEevyssUnzqHpTaXFgkoRQTkdH ) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	private void ehoXLQFRGIdEZSCicVmPCYCFbnUh(int ) { }

	// RVA: 0x1A3C890 Offset: 0x1A3BA90 VA: 0x181A3C890
	private void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }
}

// Namespace: 
internal enum kFuPHwnfsCwuzHDrtzjGMJwdcjDEA.zSdgJXAlMxQmaJGWOpnLosIRBtCS // TypeDefIndex: 6929
{
	// Fields
	public int value__; // 0x0
	public const kFuPHwnfsCwuzHDrtzjGMJwdcjDEA.zSdgJXAlMxQmaJGWOpnLosIRBtCS Active = 0;
	public const kFuPHwnfsCwuzHDrtzjGMJwdcjDEA.zSdgJXAlMxQmaJGWOpnLosIRBtCS Idle = 1;
	public const kFuPHwnfsCwuzHDrtzjGMJwdcjDEA.zSdgJXAlMxQmaJGWOpnLosIRBtCS Disabled = 2;
}

// Namespace: 
internal class kFuPHwnfsCwuzHDrtzjGMJwdcjDEA.zXVPGibrrpXgkFHxoPCnSYVFGOgL.vDCgFRWzNPHMivfcLVWzFcqIPqej // TypeDefIndex: 6930
{
	// Fields
	internal double ZUABmzIhzdwJfhCEmGulrnBjYhvGA; // 0x10
	private InputBehavior ODVMwqzTwnRNglkLxlmFevsGoGWA; // 0x18
	internal float JQMEfqFYjksHowSYJKJCATPhpTwPb; // 0x20
	internal float gZJoGaggcCZZAXkxIhvlibBayJvu; // 0x24
	internal AxisCoordinateMode uFyItZhxHEkAIRyxWgVjNMFrppxgA; // 0x28
	internal AxisCoordinateMode dqzcdWcQEprZSMbotkcDdRWJBajsA; // 0x2C
	internal ButtonStateFlags mdNAtANHwiAoYIoKusyAaLpVUIyoA; // 0x30
	internal ButtonStateFlags VtouOUNuYhbOrjOkcdtjFhbcWRlh; // 0x34
	internal ButtonStateFlags OFStcMlLlvLkXAqsCwzpGBpmFDuDA; // 0x38
	internal ButtonStateFlags TdBdKQYsyoVAyaPFiZDlOrnxlTKy; // 0x3C
	internal float LhgbAFqJBEEtnAPVzTWNlwZzdxUCA; // 0x40
	internal float PNHbOygapmiNqBHxBkDbxVeyRomyA; // 0x44
	internal float xPoQMsQQglcntSHTuCprBeNbZReqA; // 0x48
	internal float ixrizTWohRWIorSHLtbcXhBAvLXh; // 0x4C
	private double PnFxZrLJnxDVnRyfeiaCuoESSfZD; // 0x50
	private double BigYjXDaJnxXdFsJhVcMiIdmziiw; // 0x58
	private double yvbitGShlKaZKlSmxAuoXUKfqoTL; // 0x60
	private double PhjsOYGDcWWNFAiJshStWTDJHECN; // 0x68
	internal snzDlAKUlMXeBVaWzfslXTsdKrGIA NTmKmExMukNyOtMqSaOnQxGYrbNf; // 0x70
	internal snzDlAKUlMXeBVaWzfslXTsdKrGIA VGDRccUiYmdQCeFzIPCFDSPIKpLFA; // 0x78
	internal ButtonStateRecorder hIsLbVEkrHOLSanoSfgnYFDCxRGQ; // 0x80
	internal ButtonStateRecorder yNjhlTPybvgFLtSQEFleTLDPjlyP; // 0x88
	internal piLLgKjeskLusNuDtSEiraiHqWND HEIzjjUPsQWhftVuSgqtIFYJEMZp; // 0x90
	internal piLLgKjeskLusNuDtSEiraiHqWND LHbgMGKQzBEhVfPFggUhAqzfcBWCB; // 0x98
	internal TimerAbs tPPUZzQaCMHAXjKeVlEzdEYChlUkB; // 0xA0
	internal TimerAbs MjcPZgtOthkipafAkoFTtlBJmnyo; // 0xA8
	internal readonly wSLhttcgJMYvEFQjUPTkLEUWMEcK whnLDKxbBrLcyTWqkmjdDHehzNaL; // 0xB0

	// Properties
	internal double VGepgZmxgIghaSgoLWQlIQcVQGCI { get; }
	internal double NBnrSVJoApxgGpPjuQbxgDpPDGjE { get; }
	internal double yVVTVlcJswbLbovsSdKnBVZPyKrRA { get; }
	internal double aQVRCAWSlpXidPzGKdHAKEPtGtSo { get; }
	internal double egEixbQoIcliRMpSOTsXxNbLXjHx { get; }
	internal double MyonIVplXzBvHFONVkPLFyfjtKNeb { get; }
	internal double vFPMZSsWBhDukOdMViTcZWrmEMIk { get; }
	internal double zXcBOwBbVMJMaAzEqycTGGgBLuZl { get; }
	internal double jzdvtBPmvddgeDHoQxmIgNSmFdNw { get; }
	internal double mRlAiyNMAQfWvACsIlEXyDcsDkIR { get; }
	internal double OxJFvCFUiNbEXdHpCxRogPczTjHP { get; }
	internal double gCaarihzNcTUKMlhGiusucHhhjgN { get; }

	// Methods

	// RVA: 0x1A50FF0 Offset: 0x1A501F0 VA: 0x181A50FF0
	internal double jDjsrRSYkNeCbkddpxchZcNhCVrC() { }

	// RVA: 0x1A50BB0 Offset: 0x1A4FDB0 VA: 0x181A50BB0
	internal double UGGifsrESUhQmZfYhueVXKtdwdiQ() { }

	// RVA: 0x1A51090 Offset: 0x1A50290 VA: 0x181A51090
	internal double sEmPtuFYsdhLPbDAvyZSUdquBIvBA() { }

	// RVA: 0x1A505B0 Offset: 0x1A4F7B0 VA: 0x181A505B0
	internal double INWWiYstiPJYZZGcInDlvmSvJXwr() { }

	// RVA: 0x1A510C0 Offset: 0x1A502C0 VA: 0x181A510C0
	internal double vEpolorJMWNVzUQFqnhcSElzKzTo() { }

	// RVA: 0x1A50F80 Offset: 0x1A50180 VA: 0x181A50F80
	internal double gaQIZsnucwArCTvmuIBRSdNIaNPeA() { }

	// RVA: 0x1A51130 Offset: 0x1A50330 VA: 0x181A51130
	internal double wHoAjMCwInQmuJgBaPzXRXsburMiA() { }

	// RVA: 0x1A50AB0 Offset: 0x1A4FCB0 VA: 0x181A50AB0
	internal double MKUizgEQZLNKbIPXHcowqyIOFkxC() { }

	// RVA: 0x1A50520 Offset: 0x1A4F720 VA: 0x181A50520
	internal double GMtvsEbaxmSiooWNQlPGQjEciMVKA() { }

	// RVA: 0x1A50B20 Offset: 0x1A4FD20 VA: 0x181A50B20
	internal double TIndueQjnUGxOzBsJDhuNPMVcIpS() { }

	// RVA: 0x1A503A0 Offset: 0x1A4F5A0 VA: 0x181A503A0
	internal double BCQgxuDgTydPTezlnchcfhNhbPLF() { }

	// RVA: 0x1A505E0 Offset: 0x1A4F7E0 VA: 0x181A505E0
	internal double IWkbLrcGHgCMbhWWBiVHmcYTOmad() { }

	// RVA: 0x1A50D10 Offset: 0x1A4FF10 VA: 0x181A50D10
	internal void .ctor(InputBehavior ) { }

	// RVA: 0x1A50670 Offset: 0x1A4F870 VA: 0x181A50670
	internal void JYVtYFGtfWmKLMghCJzxxxfORxjU(double ) { }

	// RVA: 0x1A51020 Offset: 0x1A50220 VA: 0x181A51020
	internal void jzFfkivHgGczYeVdHflvFHYDnqWh() { }

	// RVA: 0x1A50F30 Offset: 0x1A50130 VA: 0x181A50F30
	internal void aiRtQPqrKwlKwpJiKEQJuITaHUyj() { }

	// RVA: 0x1A511A0 Offset: 0x1A503A0 VA: 0x181A511A0
	internal void ylWaIffKYNiTfcgEDkMBISIFzzbPE(bool , bool , bool , bool ) { }

	// RVA: 0x1A50BE0 Offset: 0x1A4FDE0 VA: 0x181A50BE0
	internal bool XnicjIJVozsyGssiyintLNJlOfLW() { }

	// RVA: 0x1A50510 Offset: 0x1A4F710 VA: 0x181A50510
	internal void FgktfGonywEXKIeDlvbjiSSupUgH() { }

	// RVA: 0x1A50860 Offset: 0x1A4FA60 VA: 0x181A50860
	internal void JpVNRgErpZIbBesKEebUuAqhdSEo() { }

	// RVA: 0x1A50430 Offset: 0x1A4F630 VA: 0x181A50430
	internal void EYLCazpVMOapEgUtrUmbYDqOSMHj() { }
}

// Namespace: 
private class kFuPHwnfsCwuzHDrtzjGMJwdcjDEA.zXVPGibrrpXgkFHxoPCnSYVFGOgL // TypeDefIndex: 6931
{
	// Fields
	public kFuPHwnfsCwuzHDrtzjGMJwdcjDEA.zXVPGibrrpXgkFHxoPCnSYVFGOgL.vDCgFRWzNPHMivfcLVWzFcqIPqej[] dSqWRUMESoQNVjlRwDHrJhHqUcrF; // 0x10
	private readonly int[] TPQPedaoTFEFAGfZpncIwhzCDJroA; // 0x18
	private int WIMClyaZOusxlluzIKvuJVSnDMD; // 0x20
	internal kFuPHwnfsCwuzHDrtzjGMJwdcjDEA.zXVPGibrrpXgkFHxoPCnSYVFGOgL.vDCgFRWzNPHMivfcLVWzFcqIPqej iTFuASGuQutVUojQqElkbhgbLQmGA; // 0x28

	// Properties
	internal UpdateLoopType pdMpguIIJSXJuwgCZpDStKcWwtYN { set; }

	// Methods

	// RVA: 0x1A51B40 Offset: 0x1A50D40 VA: 0x181A51B40
	internal void zPFWMQpCzwJgyJDOSdmIEXbgHRDQA(UpdateLoopType ) { }

	// RVA: 0x1A51880 Offset: 0x1A50A80 VA: 0x181A51880
	internal void .ctor(UpdateLoopSetting , InputBehavior ) { }

	// RVA: 0x1A517E0 Offset: 0x1A509E0 VA: 0x181A517E0
	internal bool XnicjIJVozsyGssiyintLNJlOfLW() { }

	// RVA: 0x1A51680 Offset: 0x1A50880 VA: 0x181A51680
	internal void PKwtxaXvImPLSHYDPPVYFvKIgugQ() { }

	// RVA: 0x1A513A0 Offset: 0x1A505A0 VA: 0x181A513A0
	internal void JpVNRgErpZIbBesKEebUuAqhdSEo() { }
}

// Namespace: 
internal class kFuPHwnfsCwuzHDrtzjGMJwdcjDEA.NpkzkUnsWvrhiVGRWOiwcFIIhcKQ.oHpLKfRipeEJOCUwzZvReDyAjaGR // TypeDefIndex: 6932
{
	// Fields
	internal Vector3 zVzHRSlUbwckvtpWtaVNfPMAUmdqA; // 0x10
	internal Vector3 zsyBOJhFDLtkrxERXBXfNFKHhaMt; // 0x1C
	internal Vector3 YfaGRUHYHFVzFToAqjzBsrvELdeZ; // 0x28

	// Methods

	// RVA: 0x1A64C00 Offset: 0x1A63E00 VA: 0x181A64C00
	internal void JoJFnJHHPEqaCHqKcsefZDItUcLBb() { }

	// RVA: 0x1A64CC0 Offset: 0x1A63EC0 VA: 0x181A64CC0
	internal void OCFHhmdycfTKIRjbIuGyTJMaYmPn() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private class kFuPHwnfsCwuzHDrtzjGMJwdcjDEA.NpkzkUnsWvrhiVGRWOiwcFIIhcKQ // TypeDefIndex: 6933
{
	// Fields
	private ADictionary<int, kFuPHwnfsCwuzHDrtzjGMJwdcjDEA.NpkzkUnsWvrhiVGRWOiwcFIIhcKQ.oHpLKfRipeEJOCUwzZvReDyAjaGR> pqinjZlQeZJDRSwEhqbtRAUzDCwr; // 0x10
	private kFuPHwnfsCwuzHDrtzjGMJwdcjDEA.NpkzkUnsWvrhiVGRWOiwcFIIhcKQ.oHpLKfRipeEJOCUwzZvReDyAjaGR jEJbttWZeWkbMLUtpDsySXGQUum; // 0x18
	private UpdateLoopType qtAaqNETFVJxRyTxafderOhZcAEJA; // 0x20

	// Properties
	internal kFuPHwnfsCwuzHDrtzjGMJwdcjDEA.NpkzkUnsWvrhiVGRWOiwcFIIhcKQ.oHpLKfRipeEJOCUwzZvReDyAjaGR iTFuASGuQutVUojQqElkbhgbLQmGA { get; }

	// Methods

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal kFuPHwnfsCwuzHDrtzjGMJwdcjDEA.NpkzkUnsWvrhiVGRWOiwcFIIhcKQ.oHpLKfRipeEJOCUwzZvReDyAjaGR tqXfLliailPrUFakQVmeZdRNbBEAb() { }

	// RVA: 0x1A5FC90 Offset: 0x1A5EE90 VA: 0x181A5FC90
	internal void .ctor(UpdateLoopSetting ) { }

	// RVA: 0x1A5FB50 Offset: 0x1A5ED50 VA: 0x181A5FB50
	internal void JoJFnJHHPEqaCHqKcsefZDItUcLBb(UpdateLoopType ) { }

	// RVA: 0x1A5FC60 Offset: 0x1A5EE60 VA: 0x181A5FC60
	internal void OCFHhmdycfTKIRjbIuGyTJMaYmPn() { }
}

// Namespace: 
internal sealed class kFuPHwnfsCwuzHDrtzjGMJwdcjDEA // TypeDefIndex: 6934
{
	// Fields
	internal readonly string NsRFUoBLVeZwnSsExKWhwStYeoRV; // 0x10
	internal readonly int pFIFvsDSemlQRdLPLVmAuFVFNKGkA; // 0x18
	internal readonly int rwAEYiLTgxJyqRHIqJhqBzEeRzGE; // 0x1C
	private readonly int aplyKYJQthDqFZJRnEooAHmQTlabA; // 0x20
	private InputBehavior ODVMwqzTwnRNglkLxlmFevsGoGWA; // 0x28
	private kFuPHwnfsCwuzHDrtzjGMJwdcjDEA.zXVPGibrrpXgkFHxoPCnSYVFGOgL lLDLCyVpgqlXOPydkPkfyMNOoteL; // 0x30
	private static ConfigVars oLjrLLpdkfKHAYReLCJwneJPnMGG; // 0x0
	private static kFuPHwnfsCwuzHDrtzjGMJwdcjDEA.NpkzkUnsWvrhiVGRWOiwcFIIhcKQ gNpTyZUoJpUVJPzDhFiozxIBeEhR; // 0x8
	private static UpdateLoopType KYOzVJvmSTODBHQgdYCHoJEzAfzbA; // 0x10
	private static double vjYOXafuPEAPUTMOQBNqKJASTAFP; // 0x18
	private static float KXNoCPXmYfifLFXYPoHrZjvDfVXBA; // 0x20
	private static uint encylUqdhMbZJVdyVrayGkHmBaHM; // 0x24
	private float MjvkIsHJJRaPOKgSiJzumaAjbsV; // 0x38
	private float idMSKZmmBwHgsAfDKTsybJWQpxVW; // 0x3C
	private float IssDYdeFlPHHijYLEcyyjKSopPgxA; // 0x40
	private float PsNejAUGyupfOwsVRDvnsCEvlnLR; // 0x44
	private ButtonStateFlags hUYcRBlaGQkAaXEECCsmCWijDweEb; // 0x48
	private ButtonStateFlags QMpYNlEATHKVUKMaYwiIXymPqOsO; // 0x4C
	private float wPxKWyCOJZEAQCUrFWZIBdYrctYU; // 0x50
	private bool xDYExTAFOxqKrMJfZMeGBBXSvvEfA; // 0x54
	private AxisCoordinateMode DOGsccsodcgUCiGWmUQFGNjdKUFDb; // 0x58
	private AxisCoordinateMode JbrukciTKqJuPtizIVGnkXfSWdqE; // 0x5C
	private readonly wSLhttcgJMYvEFQjUPTkLEUWMEcK rtFHeqGaaOZqkfqwvGOXdtEPXSrjA; // 0x60
	private uint aWkiohppEiHbxoRxKLdqnvZVubSC; // 0x68
	private uint CQXclTSPjYxlytthmtOxCnbGtwCM; // 0x6C
	private bool UxpmZcaJWZjLUeNpfXsBuMJRFJUiA; // 0x70
	private kFuPHwnfsCwuzHDrtzjGMJwdcjDEA.zSdgJXAlMxQmaJGWOpnLosIRBtCS jBVnJhMlPgvMYBYnnNpLVrwaPieR; // 0x74
	private const int zHdsjbTZfGqDHwJZSwnMSLhCadEdA = 4;
	private int TLOkogKJWKFWDseaZalMEFEtnbhq; // 0x78
	private wSLhttcgJMYvEFQjUPTkLEUWMEcK[] oCfAcXYxvCszaywcTdttxXrnSIMS; // 0x80
	private List<InputActionSourceData> FeKsJjqyndcUTTXmmoifGfNywjJy; // 0x88
	private ReadOnlyCollection<InputActionSourceData> cGYYIrYcfgoaWSFpOywiXCLyaFkBA; // 0x90
	private bool uwCtmkpqqlffvScMeySIvebcsDtQ; // 0x98
	internal bool zCYVamfOzCFTzVFJLXnXhGxuEifE; // 0x99
	internal kFuPHwnfsCwuzHDrtzjGMJwdcjDEA.zSdgJXAlMxQmaJGWOpnLosIRBtCS GWTLBipWuHyYaVKpEcCozotztnJk; // 0x9C
	internal static readonly HrlcjemCuLDOTWiWxHeuTfauJxQd zATZHhzpOmivwGrBoHzqAkseemnob; // 0x28

	// Methods

	// RVA: 0x1A4C5C0 Offset: 0x1A4B7C0 VA: 0x181A4C5C0
	private static void .cctor() { }

	// RVA: 0x1A4C620 Offset: 0x1A4B820 VA: 0x181A4C620
	internal void .ctor(int , InputAction , InputBehavior , ConfigVars ) { }

	// RVA: 0x1A4E450 Offset: 0x1A4D650 VA: 0x181A4E450
	internal static void kDzHUcZjIgaTmEHpHeLQbAaSjgktA(ConfigVars ) { }

	// RVA: 0x1A4DB90 Offset: 0x1A4CD90 VA: 0x181A4DB90
	internal static void fSASciSHwOESuXbSjUoSumLyzGvk(UpdateLoopType ) { }

	// RVA: 0x1A4E4F0 Offset: 0x1A4D6F0 VA: 0x181A4E4F0
	internal static void kGjcodDHUJiEYJtJDOKJXAXnOxVUA() { }

	// RVA: 0x1A4B2F0 Offset: 0x1A4A4F0 VA: 0x181A4B2F0
	private void BxZobtBuJhjXmbHQWvrdikEMnNCQ() { }

	// RVA: 0x1A4EBA0 Offset: 0x1A4DDA0 VA: 0x181A4EBA0
	internal void pnRRNLKOxYxAEYhSNXOzZpDqRvQQ(bool ) { }

	// RVA: 0x1A4E080 Offset: 0x1A4D280 VA: 0x181A4E080
	private void hRRtFcEtrRrArYrECxbBMRAEjsRP(HrlcjemCuLDOTWiWxHeuTfauJxQd , float ) { }

	// RVA: 0x1A4F4F0 Offset: 0x1A4E6F0 VA: 0x181A4F4F0
	private void vVuzlAignHtMgvWyjErbKFKBIyzGA(HrlcjemCuLDOTWiWxHeuTfauJxQd , float , bool ) { }

	// RVA: 0x1A4C910 Offset: 0x1A4BB10 VA: 0x181A4C910
	internal void abLUGRDIdHECfGxcihwkJKjvnRAFA() { }

	// RVA: 0x1A4AC70 Offset: 0x1A49E70 VA: 0x181A4AC70
	internal void BPVWPfmtIYeFyvAongmXFXbsCVDL() { }

	// RVA: 0x1A4FBA0 Offset: 0x1A4EDA0 VA: 0x181A4FBA0
	public float xkKkqVDvkqQjxXFwOTLeGMEeScZP() { }

	// RVA: 0x1A4B630 Offset: 0x1A4A830 VA: 0x181A4B630
	public float HZQSRChGEpQmwmrwTHJlJzLgCJLW() { }

	// RVA: 0x1A4F400 Offset: 0x1A4E600 VA: 0x181A4F400
	public float ruMxHjvHSmuHwaDqDmADGqOFiRRU() { }

	// RVA: 0x1A4D840 Offset: 0x1A4CA40 VA: 0x181A4D840
	public double cwGdztEqLHoktvFtqBLHnisFOIOcb() { }

	// RVA: 0x1A4E7F0 Offset: 0x1A4D9F0 VA: 0x181A4E7F0
	public double mYmZvXbdbMfgTCHuEfsUCoCsIZbPA() { }

	// RVA: 0x1A4EB00 Offset: 0x1A4DD00 VA: 0x181A4EB00
	public AxisCoordinateMode pbiIghLpABHzyPkcnyTLSCQKfEfe() { }

	// RVA: 0x1A4C020 Offset: 0x1A4B220 VA: 0x181A4C020
	public AxisCoordinateMode PeSnzjDZTwakpnJeKqEjozplwkg() { }

	// RVA: 0x1A4D7E0 Offset: 0x1A4C9E0 VA: 0x181A4D7E0
	public float cVqRgqyflMnZXSrOlAnARJllcjPF() { }

	// RVA: 0x1A4D910 Offset: 0x1A4CB10 VA: 0x181A4D910
	public float dVVCvRijFTAENQbQlHpkpDltqVvR() { }

	// RVA: 0x1A4BEA0 Offset: 0x1A4B0A0 VA: 0x181A4BEA0
	public float OLDnJrXAuDIDBTkqHdEyEALuHkCH() { }

	// RVA: 0x1A4E630 Offset: 0x1A4D830 VA: 0x181A4E630
	public double lvkZwVBltFxXsCFlQArhYiyDfioK() { }

	// RVA: 0x1A4DF30 Offset: 0x1A4D130 VA: 0x181A4DF30
	public double flEdvKRmOZaBwKgkSqORWgFHaSIZ() { }

	// RVA: 0x1A4BC40 Offset: 0x1A4AE40 VA: 0x181A4BC40
	public AxisCoordinateMode MWWvbpVgPnOACUcXPDwnrmCmMaPO() { }

	// RVA: 0x1A4E3B0 Offset: 0x1A4D5B0 VA: 0x181A4E3B0
	public AxisCoordinateMode jYjyefNgiJAruUSLPZpeFXGKYGIc() { }

	// RVA: 0x1A4C840 Offset: 0x1A4BA40 VA: 0x181A4C840
	public bool aSOUYCoXSrSoBcoARHonTSxYelNA() { }

	// RVA: 0x1A4E970 Offset: 0x1A4DB70 VA: 0x181A4E970
	public bool nVtepoQLYUpYVMdTLgBWIRsMnkWFA() { }

	// RVA: 0x1A4BCE0 Offset: 0x1A4AEE0 VA: 0x181A4BCE0
	public bool NExCloGyqIznSrrjxfrBLiVOXgGKA() { }

	// RVA: 0x1A4D370 Offset: 0x1A4C570 VA: 0x181A4D370
	public bool bJIdYbNgkgtjccSYUEpWFWTEFMIt() { }

	// RVA: 0x1A4CFE0 Offset: 0x1A4C1E0 VA: 0x181A4CFE0
	public bool acxPOjAbtUjRPcdyANzotGLpIBv() { }

	// RVA: 0x1A4F270 Offset: 0x1A4E470 VA: 0x181A4F270
	public bool pwUGNhiHYTHsydKOzdqgcYEREDvf() { }

	// RVA: 0x1A4D640 Offset: 0x1A4C840 VA: 0x181A4D640
	public bool bPYnrEvmRWtOVmBiqIusnXPgCqSJA() { }

	// RVA: 0x1A4D450 Offset: 0x1A4C650 VA: 0x181A4D450
	public bool bPYnrEvmRWtOVmBiqIusnXPgCqSJA(float ) { }

	// RVA: 0x1A4B120 Offset: 0x1A4A320 VA: 0x181A4B120
	public bool BourOVwqlwlqfbNHkFGdVkAVDzED() { }

	// RVA: 0x1A4B130 Offset: 0x1A4A330 VA: 0x181A4B130
	public bool BourOVwqlwlqfbNHkFGdVkAVDzED(float ) { }

	// RVA: 0x1A4C2F0 Offset: 0x1A4B4F0 VA: 0x181A4C2F0
	public bool YWgJEGyOrKmzMGRtqAgJwXdRLDaf() { }

	// RVA: 0x1A4C300 Offset: 0x1A4B500 VA: 0x181A4C300
	public bool YWgJEGyOrKmzMGRtqAgJwXdRLDaf(float ) { }

	// RVA: 0x1A4E240 Offset: 0x1A4D440 VA: 0x181A4E240
	public bool jMGNmoBduOAQxtFmzXaiVuzBsUap(float ) { }

	// RVA: 0x1A4E250 Offset: 0x1A4D450 VA: 0x181A4E250
	public bool jMGNmoBduOAQxtFmzXaiVuzBsUap(float , float ) { }

	// RVA: 0x1A4DCB0 Offset: 0x1A4CEB0 VA: 0x181A4DCB0
	public bool feoMHPPtSDlyuTLBejkESAMofTRG(float ) { }

	// RVA: 0x1A4D360 Offset: 0x1A4C560 VA: 0x181A4D360
	public bool aufgIXiwGEpUdoSTWhUPpaboWdhU(float ) { }

	// RVA: 0x1A4D150 Offset: 0x1A4C350 VA: 0x181A4D150
	public bool aufgIXiwGEpUdoSTWhUPpaboWdhU(float , float ) { }

	// RVA: 0x1A4EA60 Offset: 0x1A4DC60 VA: 0x181A4EA60
	public bool oGIvpiGyATfNzGEmpGLatuGLKWeC() { }

	// RVA: 0x1A4DFE0 Offset: 0x1A4D1E0 VA: 0x181A4DFE0
	public bool fvIAOkvGdSRnPtpmHyPtsCegAwmp() { }

	// RVA: 0x1A4AC40 Offset: 0x1A49E40 VA: 0x181A4AC40
	public bool BMoOxKaVhOAgPsGSeifdIizMFEUx() { }

	// RVA: 0x1A4EA90 Offset: 0x1A4DC90 VA: 0x181A4EA90
	public bool oKPjNvvctraKyCCUhdXOfjcuenNl() { }

	// RVA: 0x1A4E600 Offset: 0x1A4D800 VA: 0x181A4E600
	public bool lqPkAYZsMIenbDwVtVoVyFSYdBZj() { }

	// RVA: 0x1A4DF00 Offset: 0x1A4D100 VA: 0x181A4DF00
	public bool fkAWfvzaMQXfZpqQPoFVZOHjaYqf() { }

	// RVA: 0x1A4B730 Offset: 0x1A4A930 VA: 0x181A4B730
	public bool IkSOsWAomItlHkWUrLBLWIxwvaEr() { }

	// RVA: 0x1A4DAC0 Offset: 0x1A4CCC0 VA: 0x181A4DAC0
	public bool egPfUlvNimfjvIPLrdPBeiRHCCYsB() { }

	// RVA: 0x1A4C4B0 Offset: 0x1A4B6B0 VA: 0x181A4C4B0
	public double ZOTJeQvPAKYhnpfzDqRCywuEIVIB() { }

	// RVA: 0x1A4FAC0 Offset: 0x1A4ECC0 VA: 0x181A4FAC0
	public double xFSHoVfPNDzohsVGmlSWDwYqFUwtA() { }

	// RVA: 0x1A4D650 Offset: 0x1A4C850 VA: 0x181A4D650
	private bool bhgblUlyOvSGqJryCroQysflczBv() { }

	// RVA: 0x1A4BC00 Offset: 0x1A4AE00 VA: 0x181A4BC00
	public bool LguGRfKBqEoedmoYNtvnTIOwfSObA() { }

	// RVA: 0x1A4B690 Offset: 0x1A4A890 VA: 0x181A4B690
	public bool HsQwYtYxUYMafoTcqWFpxghlNcJj() { }

	// RVA: 0x1A4B5F0 Offset: 0x1A4A7F0 VA: 0x181A4B5F0
	public bool GVtQROJdqmKZZrDhibRCCnFxfpUdb() { }

	// RVA: 0x1A4B570 Offset: 0x1A4A770 VA: 0x181A4B570
	public bool DadpPLfdtUdqKArDZyEmbMGPBxQl() { }

	// RVA: 0x1A4B6F0 Offset: 0x1A4A8F0 VA: 0x181A4B6F0
	public bool IVwWMSmMitCpvCPGbmwoWTKAoGPAA() { }

	// RVA: 0x1A4E010 Offset: 0x1A4D210 VA: 0x181A4E010
	public bool gcFsncOLxDXEzOdqKdhfeMJduKYfA() { }

	// RVA: 0x1A4BB10 Offset: 0x1A4AD10 VA: 0x181A4BB10
	public bool LDLeDZABAMFMonfwEGYMusEYUOlCA() { }

	// RVA: 0x1A4BB50 Offset: 0x1A4AD50 VA: 0x181A4BB50
	public bool LDLeDZABAMFMonfwEGYMusEYUOlCA(float ) { }

	// RVA: 0x1A4BDA0 Offset: 0x1A4AFA0 VA: 0x181A4BDA0
	public bool NXgwkkgfxRQnnenrlsLBwoQIdXAEA() { }

	// RVA: 0x1A4BE10 Offset: 0x1A4B010 VA: 0x181A4BE10
	public bool NXgwkkgfxRQnnenrlsLBwoQIdXAEA(float ) { }

	// RVA: 0x1A4D790 Offset: 0x1A4C990 VA: 0x181A4D790
	public bool bnzKAaAeOBESjaWoqCHHgdbKatiLA() { }

	// RVA: 0x1A4D720 Offset: 0x1A4C920 VA: 0x181A4D720
	public bool bnzKAaAeOBESjaWoqCHHgdbKatiLA(float ) { }

	// RVA: 0x1A4E550 Offset: 0x1A4D750 VA: 0x181A4E550
	public bool kdChzRqznMWuezfkRvHVSBUCWIDe(float ) { }

	// RVA: 0x1A4E560 Offset: 0x1A4D760 VA: 0x181A4E560
	public bool kdChzRqznMWuezfkRvHVSBUCWIDe(float , float ) { }

	// RVA: 0x1A4B9E0 Offset: 0x1A4ABE0 VA: 0x181A4B9E0
	public bool LCcbIARzDKtFjakEZucdcuhgGcUf(float ) { }

	// RVA: 0x1A4AC30 Offset: 0x1A49E30 VA: 0x181A4AC30
	public bool AgQndOncOtVjvqhNsOFpiWoztCoG(float ) { }

	// RVA: 0x1A4AB10 Offset: 0x1A49D10 VA: 0x181A4AB10
	public bool AgQndOncOtVjvqhNsOFpiWoztCoG(float , float ) { }

	// RVA: 0x1A4C2C0 Offset: 0x1A4B4C0 VA: 0x181A4C2C0
	public bool WxpZxRSmawqmFiXacxXvXqkcbgMk() { }

	// RVA: 0x1A4E050 Offset: 0x1A4D250 VA: 0x181A4E050
	public bool hPlYVBRaVSUBYrFLUZckiguwUssl() { }

	// RVA: 0x1A4FC00 Offset: 0x1A4EE00 VA: 0x181A4FC00
	public bool yTUXVgKxlyHFsbNIgbLRYBHlDoVQ() { }

	// RVA: 0x1A4F3D0 Offset: 0x1A4E5D0 VA: 0x181A4F3D0
	public bool rqJASUvEasCfwfRIDlLzZyBqSiwjA() { }

	// RVA: 0x1A4E8A0 Offset: 0x1A4DAA0 VA: 0x181A4E8A0
	public bool mblIhvjIhGdMovApefyNKsYYHngo() { }

	// RVA: 0x1A4FC30 Offset: 0x1A4EE30 VA: 0x181A4FC30
	public bool yWeFrosjDGpmKhsvtFtvNEHLPnqH() { }

	// RVA: 0x1A4B520 Offset: 0x1A4A720 VA: 0x181A4B520
	public bool CCWRrhAacjvcOBfBCCICGqwBUHYaA() { }

	// RVA: 0x1A4B5B0 Offset: 0x1A4A7B0 VA: 0x181A4B5B0
	public bool EsIKGAkSWRgyxBGBDqblgWbKqekwA() { }

	// RVA: 0x1A4EAC0 Offset: 0x1A4DCC0 VA: 0x181A4EAC0
	public double ocTGxBDQyPsoYKCgKCkWhSxLIduC() { }

	// RVA: 0x1A4E8D0 Offset: 0x1A4DAD0 VA: 0x181A4E8D0
	public double mwHUCTaXcrxYvDJZsIrsfxqJtle() { }

	// RVA: 0x1A4FC60 Offset: 0x1A4EE60 VA: 0x181A4FC60
	private bool yxIIYaPbMHtJQfMoQFcZoVhyCdHh() { }

	// RVA: 0x1A4E700 Offset: 0x1A4D900 VA: 0x181A4E700
	public void mTRrcRGEzggiXIFqFdvZakYBgCPEc() { }

	// RVA: 0x1A4C280 Offset: 0x1A4B480 VA: 0x181A4C280
	internal InputActionEventData WKfVhZUpCPfxzSmvBuaEtAWxhbSd(UpdateLoopType ) { }

	// RVA: 0x1A4BBC0 Offset: 0x1A4ADC0 VA: 0x181A4BBC0
	public IList<InputActionSourceData> LLAbTeOkxqWRoOyYBuCqMloTxHsj() { }

	// RVA: 0x1A4F990 Offset: 0x1A4EB90 VA: 0x181A4F990
	public bool vmrnXFjpWfQUhdWFCPHUbRXUCrgN(ControllerType ) { }

	// RVA: 0x1A4F8E0 Offset: 0x1A4EAE0 VA: 0x181A4F8E0
	public bool vmrnXFjpWfQUhdWFCPHUbRXUCrgN(ControllerType , int ) { }

	// RVA: 0x1A4FA30 Offset: 0x1A4EC30 VA: 0x181A4FA30
	public bool vmrnXFjpWfQUhdWFCPHUbRXUCrgN(Controller ) { }

	// RVA: 0x1A4BF90 Offset: 0x1A4B190 VA: 0x181A4BF90
	internal void PKwtxaXvImPLSHYDPPVYFvKIgugQ() { }

	// RVA: 0x1A4C0C0 Offset: 0x1A4B2C0 VA: 0x181A4C0C0
	private void SYbWtLAsgGyXQDhKFCaYlNJccEjB() { }

	// RVA: 0x1A4B810 Offset: 0x1A4AA10 VA: 0x181A4B810
	private void JpVNRgErpZIbBesKEebUuAqhdSEo(bool ) { }

	// RVA: 0x1A4E1A0 Offset: 0x1A4D3A0 VA: 0x181A4E1A0
	private void iyiDzFeoOKORvabfkbLVtGmDlyYVA() { }

	// RVA: 0x1A4C210 Offset: 0x1A4B410 VA: 0x181A4C210
	private void TOWIWIadPScMYbTkMZJbcJGZxZBHA() { }

	// RVA: 0x1A4B870 Offset: 0x1A4AA70 VA: 0x181A4B870
	private void KVLfBUyTCPFZIblZvKVluyPPALeGA(Controller , ControllerMap , ActionElementMap ) { }

	// RVA: 0x1A4C0E0 Offset: 0x1A4B2E0 VA: 0x181A4C0E0
	private void TBBzFWUgsTcUnKyQZNKujRGKkbJm() { }

	// RVA: 0x1A4D970 Offset: 0x1A4CB70 VA: 0x181A4D970
	private void eBhDMRdUrBEYpGmUAePnfVaavNhfC() { }

	// RVA: 0x1A4C590 Offset: 0x1A4B790 VA: 0x181A4C590
	private static void ZzozpvDpfbFMxofWGRulUcmwfKGG(ref ButtonStateFlags , ButtonStateFlags ) { }
}

// Namespace: 
private class PdMmEhxUIynfaCicoFNoPZdpcTLk.ksKiZbUNsFxgtFNFsrfWYPerngcA // TypeDefIndex: 6935
{
	// Fields
	public readonly InputAction QXboCgcAFYlMEhekYSicAgZvMnCt; // 0x10
	public readonly int gZRVLTLFvzHLnHzyXnyINHHHdyI; // 0x18
	public readonly int WtqBLCRYfDxnYxYzBOPogyKWEPcR; // 0x1C

	// Methods

	// RVA: 0x1A64BB0 Offset: 0x1A63DB0 VA: 0x181A64BB0
	public void .ctor(InputAction , int ) { }
}

// Namespace: 
internal class PdMmEhxUIynfaCicoFNoPZdpcTLk // TypeDefIndex: 6936
{
	// Fields
	private InputAction[] ABeQmpxJxWDegApqnjBUMkElWBZr; // 0x10
	private ADictionary<string, PdMmEhxUIynfaCicoFNoPZdpcTLk.ksKiZbUNsFxgtFNFsrfWYPerngcA> xGCCsrofhhlfyDpDXWqsLfKbYXmO; // 0x18
	private PdMmEhxUIynfaCicoFNoPZdpcTLk.ksKiZbUNsFxgtFNFsrfWYPerngcA[] jjJggxKMYDCdiEKuTPtRbzYDeZrPc; // 0x20
	private ReadOnlyCollection<InputAction> zxqXAowQHCFPCgGgDehVckJJTPDsA; // 0x28
	private int VBAIfjbTjEdEegniYVeLbLhmTOnv; // 0x30
	private int tWEagbZUTMhrPrsPHbZvaJFneNCn; // 0x34
	private List<string> NwbXVlxeKuyHJVQfBFpiDeZgXvAC; // 0x38
	private List<int> AjWAnzwBXtfdpurrewuoJVQrZWUf; // 0x40

	// Properties
	public IList<InputAction> JpQCYmlkJDyqmgIoCTiQdlapOyhG { get; }
	public int QYJmkcvVsdNQOBFvRsKEqNpvvHaT { get; }
	public int GeIEzLlCoMardJmmZPuRZWXsCYNeb { get; }

	// Methods

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public IList<InputAction> OuqTgbXWOufPtloRmArhMGiXRMtr() { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public int CeqaUAENLvDeOFfHINjKdnGNHfwN() { }

	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480
	public int fxAZBRkVtAIUMtxmSURetcaFRsFc() { }

	// RVA: 0x1A60470 Offset: 0x1A5F670 VA: 0x181A60470
	public void .ctor(List<InputAction> ) { }

	// RVA: 0x1A60280 Offset: 0x1A5F480 VA: 0x181A60280
	public InputAction UqjoZccIdPldNmSgXjjvLDVQlwMH(string , bool  = False) { }

	// RVA: 0x1A608B0 Offset: 0x1A5FAB0 VA: 0x181A608B0
	public InputAction iANBMalAKnRdqoPXKCEAashFVaIw(int ) { }

	// RVA: 0x1A600A0 Offset: 0x1A5F2A0 VA: 0x181A600A0
	public InputAction GLcXomqxmdTbbgYHeAElgobcNDhd(int ) { }

	// RVA: 0x1A603B0 Offset: 0x1A5F5B0 VA: 0x181A603B0
	public int ZVMYpYkqYXFpfBIVblsDvJTirAucA(string , bool  = False) { }

	// RVA: 0x1A60340 Offset: 0x1A5F540 VA: 0x181A60340
	public int ZVMYpYkqYXFpfBIVblsDvJTirAucA(int , bool  = False) { }

	// RVA: 0x1A60120 Offset: 0x1A5F320 VA: 0x181A60120
	public bool HfHQDEyJodmDgQKMBJDYDJavMFDLA(string , bool  = False) { }

	// RVA: 0x1A600E0 Offset: 0x1A5F2E0 VA: 0x181A600E0
	public bool HfHQDEyJodmDgQKMBJDYDJavMFDLA(int ) { }

	// RVA: 0x1A601C0 Offset: 0x1A5F3C0 VA: 0x181A601C0
	public int LlvqokvmHHpGIOkYYeVxepeRYFvA(string , bool  = False) { }

	// RVA: 0x1A5FE90 Offset: 0x1A5F090 VA: 0x181A5FE90
	private void CwdZXEhCgxFGxgbRuJyeAXgKUeKDA(string ) { }

	// RVA: 0x1A5FF90 Offset: 0x1A5F190 VA: 0x181A5FF90
	private void CwdZXEhCgxFGxgbRuJyeAXgKUeKDA(int ) { }
}

// Namespace: 
public enum NNjtgIYWbHpIVTdlVfBMKzOraljUA.gVjRtqjYnuhLFUCjPfWJXpVrfVZi // TypeDefIndex: 6937
{
	// Fields
	public int value__; // 0x0
	public const NNjtgIYWbHpIVTdlVfBMKzOraljUA.gVjRtqjYnuhLFUCjPfWJXpVrfVZi Connected = 0;
	public const NNjtgIYWbHpIVTdlVfBMKzOraljUA.gVjRtqjYnuhLFUCjPfWJXpVrfVZi Disconnected = 1;
}

// Namespace: 
private class NNjtgIYWbHpIVTdlVfBMKzOraljUA.LNUypLHcgRHdxKrmJfXlIYcRLpgU // TypeDefIndex: 6938
{
	// Fields
	public ADictionary<int, InputBehavior> UIWdBdxouvFSmftBzMDXqvqIMpMR; // 0x10
	public List<InputBehavior> acISVWLgpIqtXcwMiPKfwblWfHqIA; // 0x18
	public IList<InputBehavior> xwXbHWeBRzrCEGbQlgjjvBhsXfAqA; // 0x20

	// Methods

	// RVA: 0x1A57530 Offset: 0x1A56730 VA: 0x181A57530
	public void .ctor(List<InputBehavior> ) { }

	// RVA: 0x1A57470 Offset: 0x1A56670 VA: 0x181A57470
	public InputBehavior RepKOqGBgeIxyyukCYIpQYtXIVcu(int ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NNjtgIYWbHpIVTdlVfBMKzOraljUA.HAUhCSTMPHKlCnnwCegvhtdodXuUA : IEnumerable<CustomController>, IDisposable, IEnumerator<CustomController>, IEnumerable, IEnumerator // TypeDefIndex: 6939
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private CustomController lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public NNjtgIYWbHpIVTdlVfBMKzOraljUA nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int KxHDXKEQBLYdPYEKRIhzUhcreNPeA; // 0x30
	public int ZYBZDQOtRlRBFhNLNcFpTtaIzMYW; // 0x34
	private int nbOaYOAGvUnXjFSKyiemAbZUddFZA; // 0x38
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x3C

	// Properties
	private CustomController System.Collections.Generic.IEnumerator<Rewired.CustomController>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1A57210 Offset: 0x1A56410 VA: 0x181A57210 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private CustomController System.Collections.Generic.IEnumerator<Rewired.CustomController>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A573D0 Offset: 0x1A565D0 VA: 0x181A573D0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A57310 Offset: 0x1A56510 VA: 0x181A57310 Slot: 4
	private IEnumerator<CustomController> System.Collections.Generic.IEnumerable<Rewired.CustomController>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1A57310 Offset: 0x1A56510 VA: 0x181A57310 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NNjtgIYWbHpIVTdlVfBMKzOraljUA.RnEGSFbRMoooeqfQcgAzKYBONRZNA : IEnumerable<CustomController>, IDisposable, IEnumerator<CustomController>, IEnumerable, IEnumerator // TypeDefIndex: 6940
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private CustomController lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public NNjtgIYWbHpIVTdlVfBMKzOraljUA nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private string QNpyMOyjoqtNpFuJIJLfxGQRnnAo; // 0x30
	public string lVAHpPzwHBZQKDFeYcjHAUrRWtyr; // 0x38
	private int nbOaYOAGvUnXjFSKyiemAbZUddFZA; // 0x40
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x44

	// Properties
	private CustomController System.Collections.Generic.IEnumerator<Rewired.CustomController>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1A60900 Offset: 0x1A5FB00 VA: 0x181A60900 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private CustomController System.Collections.Generic.IEnumerator<Rewired.CustomController>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A60AE0 Offset: 0x1A5FCE0 VA: 0x181A60AE0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A60A20 Offset: 0x1A5FC20 VA: 0x181A60A20 Slot: 4
	private IEnumerator<CustomController> System.Collections.Generic.IEnumerable<Rewired.CustomController>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1A60A20 Offset: 0x1A5FC20 VA: 0x181A60A20 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
internal sealed class NNjtgIYWbHpIVTdlVfBMKzOraljUA : IDisposable // TypeDefIndex: 6941
{
	// Fields
	private List<Joystick> eMsHvEtLiddWZYGnyalftifXdbZeA; // 0x10
	private List<Joystick> HOKtodhjXZMbCwDXZSMmiCjEsgKm; // 0x18
	private List<CustomController> DeNuhXwvAyUdQzDPZHGOIhfvussf; // 0x20
	private List<Controller> VbwbNVbUEjuPmGyDrrAhRsgQQAkj; // 0x28
	private ReadOnlyCollection<Controller> FKqhOURcmRqdqGVCZgXrJcmyjLXB; // 0x30
	private Keyboard qZgrmcpPeoabLCnpRvxLGlSiELHVA; // 0x38
	private Mouse LHioKmtFkdHWeyZEPNNFplYQDMhe; // 0x40
	private ConfigVars ZxkkIiawGsBWNEjJJAIQzBlQuZaE; // 0x48
	private kFuPHwnfsCwuzHDrtzjGMJwdcjDEA[] YwYzYvMhjssJmsFtwYUacGffsBwe; // 0x50
	private kFuPHwnfsCwuzHDrtzjGMJwdcjDEA[] XuLOmRgMKBENLEKlUxQracLuYOKG; // 0x58
	private kFuPHwnfsCwuzHDrtzjGMJwdcjDEA[,] mqEqIETSNLLCGdvLpLoKXfqalqPr; // 0x60
	private miUysssUdqGWyuAUsKAOqijtIpUFA HHSgmfPkeVIkjdvApzmdCdSLhAPYA; // 0x68
	private YukdbraIOdkMeQxcSbggwPKIgDZM weUdJggWsaxACfVTePyiGcQRQWjUA; // 0x70
	private YukdbraIOdkMeQxcSbggwPKIgDZM[] jgYrDhyhNbYXIwqaEKcMsmEXYOmL; // 0x78
	private uNFJquNOBaRBwwpcUNtexUfCbTCU<ActiveControllerChangedDelegate> TDDBDwlgtjobaAMHybKuKHltJuEBA; // 0x80
	private uNFJquNOBaRBwwpcUNtexUfCbTCU<PlayerActiveControllerChangedDelegate> BOcDodAaKzLhIYKckmfdrevEZmoy; // 0x88
	private uNFJquNOBaRBwwpcUNtexUfCbTCU<PlayerActiveControllerChangedDelegate>[] FGAvmHebuiMgmFlowvCQFLSFiFmx; // 0x90
	private ADictionary<int, NNjtgIYWbHpIVTdlVfBMKzOraljUA.LNUypLHcgRHdxKrmJfXlIYcRLpgU> VPmCoDPotMOnNWBPaUnAhBPyTqfj; // 0x98
	private readonly XBoAxPyoIvQNXtmkapFQwgBOjQfE QmaaWyfzOYYCmTNuTembfvwXozcgb; // 0xA0
	private IList<Joystick> qPyGrNbarhivPUFROqpDydqVUnWeA; // 0xA8
	private IList<CustomController> yuoskVmoifVJVJiHhlIoRfiMDFeY; // 0xB0
	private int JfChbvAAyFcGFWREeoJXXpiyXtnV; // 0xB8
	private bool UmBzFAAyvjqLTqomLdIguNQCgLaB; // 0xBC
	private bool BBrcJCbNpTlmYejfeFOXdPaQZPVyb; // 0xBD
	private bool LktnTlJLMdiYOPZBlDGLSMtheLcaA; // 0xBE
	private IUnifiedKeyboardSource FjnYeIHdcqclnhFSNkzFSIoNxYau; // 0xC0
	private IUnifiedMouseSource oJUoUcGBFcaBtUTpKLNwAIvfBWIy; // 0xC8
	private int oBmCKOgnPQPsEoypfdMCXnSNJFky; // 0xD0
	private PdMmEhxUIynfaCicoFNoPZdpcTLk gLoRxuArZhEOgddwNNAqvyzKsbcP; // 0xD8
	private fJoDazWsXQzUMfRyTCGkItcorohd PzKBhTEUHhTGGHtNowOmSwuEpION; // 0xE0
	private int gKEuHSQqCqAdwaJNPlEeGyMffmpJb; // 0xE8
	private int QYJmkcvVsdNQOBFvRsKEqNpvvHaT; // 0xEC
	private Action<int, ControllerDataUpdater> BUIDRLKFeCGjYijdHbaMfuCprVlE; // 0xF0
	private Action<bool, int, int> XrIqmJvUjVVmADgHXdtkjFOEWDOY; // 0xF8
	private Action<ControllerStatusChangedEventArgs> WQXGDrtZKRWXyilfUUIfLjHdVvSr; // 0x100
	private Action<ControllerType, int> VrtpmbUmJAsKDUkWmJcQMtMcrptA; // 0x108
	private bool qlWbbXXJkXhrJOhRVlcxNUPVUYEt; // 0x110

	// Properties
	public IList<Joystick> fBOiQIdqRniUExMnqmHBneebFFsRA { get; }
	public List<Joystick> tWkdiOgVbFiAyANuGcdetyyJbtWPb { get; }
	public int cgqOFbLCriWQJiMRqiHjBSiupijH { get; }
	public Mouse HVuWISgVawMAEkHFzvSwwvvYsCjv { get; }
	public Keyboard mFhBeeDUNSOiAqnuWiNmAVUXwWzGb { get; }
	public IList<CustomController> fLFyXnUuRcyFCoFiqJUTqGPLCOCg { get; }
	public List<CustomController> uHIaItMJyDAQyLGtZWJgyOKpmHXA { get; }
	public int wNWAzAXtuDDrAZzWplkoanZmcnrQ { get; }
	public IList<Controller> rRqbxgGDBtwRGwbDsUoRsyLZVNsy { get; }
	public int bbnHdvWZlfNoxgeKiHWorhsvnfCp { get; }
	private int hZDsNxgzhmSFVmPObCjXzinUfJOs { get; }

	// Methods

	// RVA: 0x1A5EEC0 Offset: 0x1A5E0C0 VA: 0x181A5EEC0
	public void sbhCqVnyiAZukQbvxEUaqkgtQlFn(Action<ControllerStatusChangedEventArgs> ) { }

	// RVA: 0x1A589D0 Offset: 0x1A57BD0 VA: 0x181A589D0
	public void EaWgMtJlJIebVTiTPSebvSrEnlXC(Action<ControllerStatusChangedEventArgs> ) { }

	// RVA: 0x1A5F420 Offset: 0x1A5E620 VA: 0x181A5F420
	public void vHvaCYXuhjZIYtzJILYpGGWjSbFf(Action<ControllerType, int> ) { }

	// RVA: 0x1A5DCE0 Offset: 0x1A5CEE0 VA: 0x181A5DCE0
	public void gpnQwQuLdiTqOkPyxXGoemKPNwDu(Action<ControllerType, int> ) { }

	// RVA: 0x1A5C860 Offset: 0x1A5BA60 VA: 0x181A5C860
	public void .ctor(ConfigVars , PlatformInputManager ) { }

	// RVA: 0x7960B0 Offset: 0x7952B0 VA: 0x1807960B0
	public IList<Joystick> wVTTEmiduxIeqJbDEjiDUmcrFkTcA() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public List<Joystick> mwwiYfbYKpPKYTBVpbiKcMzyjcEVA() { }

	// RVA: 0x1A5D0A0 Offset: 0x1A5C2A0 VA: 0x181A5D0A0
	public int dsQBrZvBJipUgxbevbMJhWewPBze() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public Mouse oYyNMhIbHgiJDDzTxvzumifssiSLA() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public Keyboard CeiYecfVVoMOsmFWDdHjNKwDaXyk() { }

	// RVA: 0x796070 Offset: 0x795270 VA: 0x180796070
	public IList<CustomController> kJHXDZMfDKmJTFKeydCCXOzHHcEY() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public List<CustomController> cRUdabcRiCXfamNyepVJEXsFnClTb() { }

	// RVA: 0x1A5BAC0 Offset: 0x1A5ACC0 VA: 0x181A5BAC0
	public int YPPCvbrJpvtPGGEbwdAxshpIdcfX() { }

	// RVA: 0x1A5BB40 Offset: 0x1A5AD40 VA: 0x181A5BB40
	public void ZFUcTEcndvHgBpdTmEAgSebxfOsJ(Action<int, ControllerDataUpdater> , List<InputBehavior> ) { }

	// RVA: 0x1A5A630 Offset: 0x1A59830 VA: 0x181A5A630
	public void NXsdcUmvlchkKwnLJYZgvWkOUNSV(UpdateLoopType ) { }

	// RVA: 0x1A5D0E0 Offset: 0x1A5C2E0 VA: 0x181A5D0E0
	public kFuPHwnfsCwuzHDrtzjGMJwdcjDEA eGTtPPzwLxMBhffvfPvLirQChtoU(int , string , bool ) { }

	// RVA: 0x1A5D210 Offset: 0x1A5C410 VA: 0x181A5D210
	public kFuPHwnfsCwuzHDrtzjGMJwdcjDEA eGTtPPzwLxMBhffvfPvLirQChtoU(int , int , bool ) { }

	// RVA: 0x1A578E0 Offset: 0x1A56AE0 VA: 0x181A578E0
	public void BVdbIpogKbeXBZxOjGExjIPigFAXA(UpdateControllerInfoEventArgs ) { }

	// RVA: 0x1A5FB30 Offset: 0x1A5ED30 VA: 0x181A5FB30
	public bool yLbPMQOuzyDOgKlgbIvpIufDBTGAA(int , NNjtgIYWbHpIVTdlVfBMKzOraljUA.gVjRtqjYnuhLFUCjPfWJXpVrfVZi ) { }

	// RVA: 0x1A5B840 Offset: 0x1A5AA40 VA: 0x181A5B840
	public int XvXqgezbcXDrUhjliDfcpTTFFWsh(int , NNjtgIYWbHpIVTdlVfBMKzOraljUA.gVjRtqjYnuhLFUCjPfWJXpVrfVZi ) { }

	// RVA: 0x1A5B930 Offset: 0x1A5AB30 VA: 0x181A5B930
	public int XvXqgezbcXDrUhjliDfcpTTFFWsh(Guid , NNjtgIYWbHpIVTdlVfBMKzOraljUA.gVjRtqjYnuhLFUCjPfWJXpVrfVZi ) { }

	// RVA: 0x1A5ABF0 Offset: 0x1A59DF0 VA: 0x181A5ABF0
	public bool RlyLutzDjeRVJEWRfpGIIHvBaZB(int ) { }

	// RVA: 0x1A5F2D0 Offset: 0x1A5E4D0 VA: 0x181A5F2D0
	public int vCyfWgtHiTmhfXPVoHSdoEHwOONc(int ) { }

	// RVA: 0x1A5F1E0 Offset: 0x1A5E3E0 VA: 0x181A5F1E0
	public int vCyfWgtHiTmhfXPVoHSdoEHwOONc(Guid ) { }

	// RVA: 0x1A578D0 Offset: 0x1A56AD0 VA: 0x181A578D0
	public void BSgSZOlvfZagJpqeyDJcCHmpEQZBA(BridgedController ) { }

	// RVA: 0x1A5F370 Offset: 0x1A5E570 VA: 0x181A5F370
	public void vHJXLNVMOfWACKGDOsRQmuIYCrre(int ) { }

	// RVA: 0x1A588A0 Offset: 0x1A57AA0 VA: 0x181A588A0
	public int DtDlhrwJdupetMpBcFlBnJPhpKuO() { }

	// RVA: 0x1A59890 Offset: 0x1A58A90 VA: 0x181A59890
	public IList<InputBehavior> JJFylVoSfJFPzlODPDngaQBAlgbcb(int ) { }

	// RVA: 0x1A58BA0 Offset: 0x1A57DA0 VA: 0x181A58BA0
	public InputBehavior EpqHdivfihdSJIeqEvAsoeAXILATA(int , string ) { }

	// RVA: 0x1A58A80 Offset: 0x1A57C80 VA: 0x181A58A80
	public InputBehavior EpqHdivfihdSJIeqEvAsoeAXILATA(int , int ) { }

	// RVA: 0x1A59710 Offset: 0x1A58910 VA: 0x181A59710
	public Joystick IMzmazkhqzlSygcTcIOqBVQnUJzX(int , bool  = False) { }

	// RVA: 0x1A59510 Offset: 0x1A58710 VA: 0x181A59510
	public Joystick IMzmazkhqzlSygcTcIOqBVQnUJzX(Guid , bool  = False) { }

	// RVA: 0x1A5EF70 Offset: 0x1A5E170 VA: 0x181A5EF70
	public Joystick[] tOathrnlDQrTYlvzgSctpgqCficR() { }

	// RVA: 0x1A588B0 Offset: 0x1A57AB0 VA: 0x181A588B0
	public string[] EENoOQKAtFqPFwmrCSFnvEKQztPi() { }

	// RVA: 0x1A5ED00 Offset: 0x1A5DF00 VA: 0x181A5ED00
	public CustomController oTXHdbxlmGrPUeaGIQdnLRaRhAul(int ) { }

	// RVA: 0x1A5ED70 Offset: 0x1A5DF70 VA: 0x181A5ED70
	public CustomController oTXHdbxlmGrPUeaGIQdnLRaRhAul(Guid ) { }

	// RVA: 0x1A5A8B0 Offset: 0x1A59AB0 VA: 0x181A5A8B0
	public CustomController[] PIafatdxYkCnaRlTHfpdEpbgUCnxA() { }

	// RVA: 0x1A5AED0 Offset: 0x1A5A0D0 VA: 0x181A5AED0
	public string[] TggPnyHKtIGGxacYBPLEsDUIfYasA() { }

	// RVA: 0x1A5A350 Offset: 0x1A59550 VA: 0x181A5A350
	public CustomController NRqmHlcEpOctnEfmlfZWKwzuplFJA(int ) { }

	// RVA: 0x1A59960 Offset: 0x1A58B60 VA: 0x181A59960
	public bool JUPIUnKCIUJVddxXtltRiRDulynU(CustomController ) { }

	// RVA: 0x1A59A10 Offset: 0x1A58C10 VA: 0x181A59A10
	public CustomController KkHWqlOArYDzdqkqzzbTzpODfOdQ(int ) { }

	// RVA: 0x1A59AD0 Offset: 0x1A58CD0 VA: 0x181A59AD0
	public CustomController LIZhjHptIKUUPFZNArUYPnaApDrt(string ) { }

	// RVA: 0x1A5B1D0 Offset: 0x1A5A3D0 VA: 0x181A5B1D0
	public IEnumerable<CustomController> UCVkHdQVBnvgFyTpbFFXSCOsEJUd(int ) { }

	// RVA: 0x1A5F600 Offset: 0x1A5E800 VA: 0x181A5F600
	public IEnumerable<CustomController> wmcKLXdoKFblkYmbGLKxIQYXGreM(string ) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public IList<Controller> PuZFUioEQVsoSeyNstSYzaMBDwBn() { }

	// RVA: 0x1A5BB00 Offset: 0x1A5AD00 VA: 0x181A5BB00
	public int YslKDTHocfzlOinEdgdzcYBTQtsY() { }

	// RVA: 0x1A5E0D0 Offset: 0x1A5D2D0 VA: 0x181A5E0D0
	public Controller ioyGgqcxMFpOcLbWFadlkZYwDWKq(ControllerType , int , bool  = False) { }

	// RVA: 0x1A5DFF0 Offset: 0x1A5D1F0 VA: 0x181A5DFF0
	public Controller ioyGgqcxMFpOcLbWFadlkZYwDWKq(ControllerIdentifier , bool  = False) { }

	// RVA: 0x1A5E1E0 Offset: 0x1A5D3E0 VA: 0x181A5E1E0
	public Controller ioyGgqcxMFpOcLbWFadlkZYwDWKq(Guid , bool  = False) { }

	// RVA: 0x1A579D0 Offset: 0x1A56BD0 VA: 0x181A579D0
	public Controller[] BnChamAbKYXklyNGHwgOyvNxIjjC(ControllerType ) { }

	// RVA: 0x1A5EA20 Offset: 0x1A5DC20 VA: 0x181A5EA20
	public string[] oDBZoIsLZzNdNKRsVsQyjRFRGOSs(ControllerType ) { }

	// RVA: 0x1A590B0 Offset: 0x1A582B0 VA: 0x181A590B0
	public void HfjYJzuCQaIELTWPYVVVzrJlGpYs(int , Action<InputActionEventData> , UpdateLoopType ) { }

	// RVA: 0x1A59350 Offset: 0x1A58550 VA: 0x181A59350
	public void HfjYJzuCQaIELTWPYVVVzrJlGpYs(int , Action<InputActionEventData> , UpdateLoopType , int ) { }

	// RVA: 0x1A593B0 Offset: 0x1A585B0 VA: 0x181A593B0
	public void HfjYJzuCQaIELTWPYVVVzrJlGpYs(int , Action<InputActionEventData> , UpdateLoopType , string ) { }

	// RVA: 0x1A592F0 Offset: 0x1A584F0 VA: 0x181A592F0
	public void HfjYJzuCQaIELTWPYVVVzrJlGpYs(int , Action<InputActionEventData> , UpdateLoopType , InputActionEventType , object[] ) { }

	// RVA: 0x1A59110 Offset: 0x1A58310 VA: 0x181A59110
	public void HfjYJzuCQaIELTWPYVVVzrJlGpYs(int , Action<InputActionEventData> , UpdateLoopType , InputActionEventType , int , object[] ) { }

	// RVA: 0x1A59180 Offset: 0x1A58380 VA: 0x181A59180
	public void HfjYJzuCQaIELTWPYVVVzrJlGpYs(int , Action<InputActionEventData> , UpdateLoopType , InputActionEventType , string , object[] ) { }

	// RVA: 0x1A58460 Offset: 0x1A57660 VA: 0x181A58460
	public void CwCFRfNwUmXOmCOkNSZChLxSFjmx(int , Action<InputActionEventData> ) { }

	// RVA: 0x1A584E0 Offset: 0x1A576E0 VA: 0x181A584E0
	public void CwCFRfNwUmXOmCOkNSZChLxSFjmx(int , Action<InputActionEventData> , int ) { }

	// RVA: 0x1A58270 Offset: 0x1A57470 VA: 0x181A58270
	public void CwCFRfNwUmXOmCOkNSZChLxSFjmx(int , Action<InputActionEventData> , string ) { }

	// RVA: 0x1A583E0 Offset: 0x1A575E0 VA: 0x181A583E0
	public void CwCFRfNwUmXOmCOkNSZChLxSFjmx(int , Action<InputActionEventData> , UpdateLoopType ) { }

	// RVA: 0x1A58420 Offset: 0x1A57620 VA: 0x181A58420
	public void CwCFRfNwUmXOmCOkNSZChLxSFjmx(int , Action<InputActionEventData> , InputActionEventType ) { }

	// RVA: 0x1A58390 Offset: 0x1A57590 VA: 0x181A58390
	public void CwCFRfNwUmXOmCOkNSZChLxSFjmx(int , Action<InputActionEventData> , UpdateLoopType , int ) { }

	// RVA: 0x1A58700 Offset: 0x1A57900 VA: 0x181A58700
	public void CwCFRfNwUmXOmCOkNSZChLxSFjmx(int , Action<InputActionEventData> , UpdateLoopType , string ) { }

	// RVA: 0x1A58490 Offset: 0x1A57690 VA: 0x181A58490
	public void CwCFRfNwUmXOmCOkNSZChLxSFjmx(int , Action<InputActionEventData> , InputActionEventType , int ) { }

	// RVA: 0x1A58570 Offset: 0x1A57770 VA: 0x181A58570
	public void CwCFRfNwUmXOmCOkNSZChLxSFjmx(int , Action<InputActionEventData> , InputActionEventType , string ) { }

	// RVA: 0x1A586B0 Offset: 0x1A578B0 VA: 0x181A586B0
	public void CwCFRfNwUmXOmCOkNSZChLxSFjmx(int , Action<InputActionEventData> , UpdateLoopType , InputActionEventType ) { }

	// RVA: 0x1A58520 Offset: 0x1A57720 VA: 0x181A58520
	public void CwCFRfNwUmXOmCOkNSZChLxSFjmx(int , Action<InputActionEventData> , UpdateLoopType , InputActionEventType , int ) { }

	// RVA: 0x1A58130 Offset: 0x1A57330 VA: 0x181A58130
	public void CwCFRfNwUmXOmCOkNSZChLxSFjmx(int , Action<InputActionEventData> , UpdateLoopType , InputActionEventType , string ) { }

	// RVA: 0x1A578A0 Offset: 0x1A56AA0 VA: 0x181A578A0
	public void BBPztBZvUWATAMLijbFVRAbKGwkD(int ) { }

	// RVA: 0x1A5DEC0 Offset: 0x1A5D0C0 VA: 0x181A5DEC0
	public bool iUEKyNRpiZSBNEagrhhHFOdRIdwSA(int ) { }

	// RVA: 0x1A5F0B0 Offset: 0x1A5E2B0 VA: 0x181A5F0B0
	public bool uPdGVQRyzhfVNIIoyldmaPaObQZgA(int ) { }

	// RVA: 0x1A5D800 Offset: 0x1A5CA00 VA: 0x181A5D800
	public bool fcggIXXKtZgUWzbuBBBhfZfEmEXe(int ) { }

	// RVA: 0x1A5F4D0 Offset: 0x1A5E6D0 VA: 0x181A5F4D0
	public bool wgPrwqfgdDOkxpCsiLdBGYIOneZW(int ) { }

	// RVA: 0x1A57770 Offset: 0x1A56970 VA: 0x181A57770
	public bool AjLiovVXrOojRbNkZpxeTAxNLWoN(int ) { }

	// RVA: 0x1A5AAC0 Offset: 0x1A59CC0 VA: 0x181A5AAC0
	public bool QrABiHkBoTDfZzhlmqimLEVxESEgb(int ) { }

	// RVA: 0x1A5E8F0 Offset: 0x1A5DAF0 VA: 0x181A5E8F0
	public bool nOFryiiOOSKvZzCjSOLyzegHzuGt(int ) { }

	// RVA: 0x1A5DD90 Offset: 0x1A5CF90 VA: 0x181A5DD90
	public bool hENDHrEeSyqqaeGBkjaxqizBfaQgA(int ) { }

	// RVA: 0x1A5F870 Offset: 0x1A5EA70 VA: 0x181A5F870
	public bool xtAOAhEqvPcwmBBumhlgwYpguSdMA() { }

	// RVA: 0x1A5F770 Offset: 0x1A5E970 VA: 0x181A5F770
	public bool xtAOAhEqvPcwmBBumhlgwYpguSdMA(ControllerType ) { }

	// RVA: 0x1A5FA80 Offset: 0x1A5EC80 VA: 0x181A5FA80
	public bool xtXPwUuyUqhfBClEQejgiPbJGWSfA() { }

	// RVA: 0x1A5F980 Offset: 0x1A5EB80 VA: 0x181A5F980
	public bool xtXPwUuyUqhfBClEQejgiPbJGWSfA(ControllerType ) { }

	// RVA: 0x1A5B360 Offset: 0x1A5A560 VA: 0x181A5B360
	public bool VHSyTAIyrFTSIMIZAJnFVeQuuMOO() { }

	// RVA: 0x1A5B260 Offset: 0x1A5A460 VA: 0x181A5B260
	public bool VHSyTAIyrFTSIMIZAJnFVeQuuMOO(ControllerType ) { }

	// RVA: 0x1A5B120 Offset: 0x1A5A320 VA: 0x181A5B120
	public bool UCClsNFKrwIPOrFbYHbuTpGoWzWo() { }

	// RVA: 0x1A5AFF0 Offset: 0x1A5A1F0 VA: 0x181A5AFF0
	public bool UCClsNFKrwIPOrFbYHbuTpGoWzWo(ControllerType ) { }

	// RVA: 0x1A57ED0 Offset: 0x1A570D0 VA: 0x181A57ED0
	public bool BtEnOXHvdFEBaEeiBbvNBxunJcLeA() { }

	// RVA: 0x1A57F80 Offset: 0x1A57180 VA: 0x181A57F80
	public bool BtEnOXHvdFEBaEeiBbvNBxunJcLeA(ControllerType ) { }

	// RVA: -1 Offset: -1
	private bool xtAOAhEqvPcwmBBumhlgwYpguSdMA<>(IList<> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA551B0 Offset: 0xA543B0 VA: 0x180A551B0
	|-NNjtgIYWbHpIVTdlVfBMKzOraljUA.xtAOAhEqvPcwmBBumhlgwYpguSdMA<object>
	*/

	// RVA: 0x1A5F920 Offset: 0x1A5EB20 VA: 0x181A5F920
	private bool xtAOAhEqvPcwmBBumhlgwYpguSdMA(Controller ) { }

	// RVA: -1 Offset: -1
	private bool xtXPwUuyUqhfBClEQejgiPbJGWSfA<>(IList<> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA55280 Offset: 0xA54480 VA: 0x180A55280
	|-NNjtgIYWbHpIVTdlVfBMKzOraljUA.xtXPwUuyUqhfBClEQejgiPbJGWSfA<object>
	*/

	// RVA: 0x1A5F950 Offset: 0x1A5EB50 VA: 0x181A5F950
	private bool xtXPwUuyUqhfBClEQejgiPbJGWSfA(Controller ) { }

	// RVA: -1 Offset: -1
	private bool VHSyTAIyrFTSIMIZAJnFVeQuuMOO<>(IList<> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA54D20 Offset: 0xA53F20 VA: 0x180A54D20
	|-NNjtgIYWbHpIVTdlVfBMKzOraljUA.VHSyTAIyrFTSIMIZAJnFVeQuuMOO<object>
	*/

	// RVA: 0x1A5B410 Offset: 0x1A5A610 VA: 0x181A5B410
	private bool VHSyTAIyrFTSIMIZAJnFVeQuuMOO(Controller ) { }

	// RVA: -1 Offset: -1
	private bool UCClsNFKrwIPOrFbYHbuTpGoWzWo<>(IList<> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA54C50 Offset: 0xA53E50 VA: 0x180A54C50
	|-NNjtgIYWbHpIVTdlVfBMKzOraljUA.UCClsNFKrwIPOrFbYHbuTpGoWzWo<object>
	*/

	// RVA: 0x1A5B0F0 Offset: 0x1A5A2F0 VA: 0x181A5B0F0
	private bool UCClsNFKrwIPOrFbYHbuTpGoWzWo(Controller ) { }

	// RVA: -1 Offset: -1
	private bool BtEnOXHvdFEBaEeiBbvNBxunJcLeA<>(IList<> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA54B30 Offset: 0xA53D30 VA: 0x180A54B30
	|-NNjtgIYWbHpIVTdlVfBMKzOraljUA.BtEnOXHvdFEBaEeiBbvNBxunJcLeA<object>
	*/

	// RVA: 0x1A57EA0 Offset: 0x1A570A0 VA: 0x181A57EA0
	private bool BtEnOXHvdFEBaEeiBbvNBxunJcLeA(Controller ) { }

	// RVA: 0x1A5B440 Offset: 0x1A5A640 VA: 0x181A5B440
	public Controller VpyIERlUROpRVLYbCbpAwYrTWpBu() { }

	// RVA: 0x1A5B680 Offset: 0x1A5A880 VA: 0x181A5B680
	public Controller VpyIERlUROpRVLYbCbpAwYrTWpBu(ControllerType ) { }

	// RVA: -1 Offset: -1
	public  VpyIERlUROpRVLYbCbpAwYrTWpBu<>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA54DF0 Offset: 0xA53FF0 VA: 0x180A54DF0
	|-NNjtgIYWbHpIVTdlVfBMKzOraljUA.VpyIERlUROpRVLYbCbpAwYrTWpBu<object>
	*/

	// RVA: 0x1A59FA0 Offset: 0x1A591A0 VA: 0x181A59FA0
	public ControllerType NHNGUiJVmIVptTmOEgFhKyUblZdE() { }

	// RVA: 0x1A5AE60 Offset: 0x1A5A060 VA: 0x181A5AE60
	public void TWdahcSuruGJQLZrMkjJcAFDizThA(ActiveControllerChangedDelegate ) { }

	// RVA: 0x1A5AC90 Offset: 0x1A59E90 VA: 0x181A5AC90
	public void TWdahcSuruGJQLZrMkjJcAFDizThA(ActiveControllerChangedDelegate , ControllerType ) { }

	// RVA: 0x1A59E90 Offset: 0x1A59090 VA: 0x181A59E90
	public void NHGAHfmnnuHYzGggYSjWMwhuQpcUA(ActiveControllerChangedDelegate ) { }

	// RVA: 0x1A5CDA0 Offset: 0x1A5BFA0 VA: 0x181A5CDA0
	public void cbuAykYPamhaYKNDEttEaokLWuXB(ActiveControllerChangedDelegate , ControllerType ) { }

	// RVA: 0x1A5F690 Offset: 0x1A5E890 VA: 0x181A5F690
	public void wnAQgwkRCVAJAtDKIcXcUMuBbKNV() { }

	// RVA: 0x1A5ADC0 Offset: 0x1A59FC0 VA: 0x181A5ADC0
	public void TWdahcSuruGJQLZrMkjJcAFDizThA(int , PlayerActiveControllerChangedDelegate ) { }

	// RVA: 0x1A5AD10 Offset: 0x1A59F10 VA: 0x181A5AD10
	public void TWdahcSuruGJQLZrMkjJcAFDizThA(int , PlayerActiveControllerChangedDelegate , ControllerType ) { }

	// RVA: 0x1A59DF0 Offset: 0x1A58FF0 VA: 0x181A59DF0
	public void NHGAHfmnnuHYzGggYSjWMwhuQpcUA(int , PlayerActiveControllerChangedDelegate ) { }

	// RVA: 0x1A59EF0 Offset: 0x1A590F0 VA: 0x181A59EF0
	public void NHGAHfmnnuHYzGggYSjWMwhuQpcUA(int , PlayerActiveControllerChangedDelegate , ControllerType ) { }

	// RVA: 0x1A5F6E0 Offset: 0x1A5E8E0 VA: 0x181A5F6E0
	public void wnAQgwkRCVAJAtDKIcXcUMuBbKNV(int ) { }

	// RVA: 0x1A5E440 Offset: 0x1A5D640 VA: 0x181A5E440
	private void kuuiQLfRgxKcfjwdJznTNtBFueik() { }

	// RVA: 0x1A59FD0 Offset: 0x1A591D0 VA: 0x181A59FD0
	public void NIuhBkFoCaIQLFjlxgLDSSgtKbgk(ThrottleCalibrationMode ) { }

	// RVA: 0x1A5A1B0 Offset: 0x1A593B0 VA: 0x181A5A1B0
	private void NIuhBkFoCaIQLFjlxgLDSSgtKbgk(ControllerWithAxes , ThrottleCalibrationMode ) { }

	// RVA: -1 Offset: -1
	public IList<> ODcMPwlWjKvCYocYpQixAKSpdKOZ<>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA54C00 Offset: 0xA53E00 VA: 0x180A54C00
	|-NNjtgIYWbHpIVTdlVfBMKzOraljUA.ODcMPwlWjKvCYocYpQixAKSpdKOZ<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1A5D7D0 Offset: 0x1A5C9D0 VA: 0x181A5D7D0
	private int fSgHmIXNpNkzPLYzbDalvRJERelN() { }

	// RVA: 0x1A5BB60 Offset: 0x1A5AD60 VA: 0x181A5BB60
	private void ZFUcTEcndvHgBpdTmEAgSebxfOsJ(List<InputBehavior> ) { }

	// RVA: 0x1A59BB0 Offset: 0x1A58DB0 VA: 0x181A59BB0
	private void LLeEsYhLtcAvwKJcDPCEGMiengKbb(UpdateLoopType ) { }

	// RVA: 0x1A5D2F0 Offset: 0x1A5C4F0 VA: 0x181A5D2F0
	private void eezRWeTzvgGreXnizDjMzjVdACGT(UpdateLoopType ) { }

	// RVA: 0x1A58FF0 Offset: 0x1A581F0 VA: 0x181A58FF0
	private void GSdSModdhlKQFbAObrWGNlzWOkuy(bool , int , int ) { }

	// RVA: 0x1A5D930 Offset: 0x1A5CB30 VA: 0x181A5D930
	private void fngNtEDuJfxQfQHivakAoPiGNhtP(BridgedController ) { }

	// RVA: 0x1A5CE10 Offset: 0x1A5C010 VA: 0x181A5CE10
	private void cyhUOEoMPJgyFXCnrzVWoWDGiTIm(int ) { }

	// RVA: 0x1A58D80 Offset: 0x1A57F80 VA: 0x181A58D80
	private void FszafbVDSbLOpunQAdvsxdzedQMw() { }

	// RVA: 0x1A5A750 Offset: 0x1A59950 VA: 0x181A5A750
	private bool OLeSSpOBSiNWzygFEpEFWgWNBvQm(CustomController ) { }

	// RVA: 0x1A58080 Offset: 0x1A57280 VA: 0x181A58080
	private bool CGuFpThyPusLHhKQEkNerBvTncmhb(CustomController ) { }

	// RVA: 0x1A5E830 Offset: 0x1A5DA30 VA: 0x181A5E830
	private YukdbraIOdkMeQxcSbggwPKIgDZM nCAkAetjOXUDtChrDvydjcEUVTbo(int ) { }

	// RVA: 0x1A5EE90 Offset: 0x1A5E090 VA: 0x181A5EE90
	private void ojRAvYzDubwanwWLLQDQQkfabVbV(bool ) { }

	// RVA: 0x1A57D20 Offset: 0x1A56F20 VA: 0x181A57D20
	private void BrXJkfHLERFpbScebqEwNAEsBsbv(bool ) { }

	// RVA: 0x1A58840 Offset: 0x1A57A40 VA: 0x181A58840 Slot: 4
	public void Dispose() { }

	// RVA: 0x1A5AC10 Offset: 0x1A59E10 VA: 0x181A5AC10 Slot: 1
	protected override void SnyTHacbnnYzPrlQoFnKzkJtcRbdA() { }

	// RVA: 0x1A5A9B0 Offset: 0x1A59BB0 VA: 0x181A5A9B0
	private void QKEYycJGvyEZCdnUfkbohEkzVpV(bool ) { }
}

// Namespace: 
private class boptZNiGvjuPyvHlFVuIWxQVdZPO.zhQheEWHFcibFaGUdvbxDsLyvoQhA : IInputManagerJoystick, IInputManagerJoystickPublic // TypeDefIndex: 6942
{
	// Fields
	private int WbkDRJEuoPBLLDmrfHJWgNJQCwNvB; // 0x10
	private int BoTmFzEhaOdgBQChcgQyQvxMoQji; // 0x14
	private int ROUaKuFxYbGXzctUkcpThwDvBnzEb; // 0x18
	public Guid CTnCUICsGydvUUAXPEEmYmkuywLs; // 0x1C
	public string vgwaPgDjLVEzQYEBWonLNevgjMzsA; // 0x30
	public int YGRtRbkcyBItMmPRPBZuUnGgIKoG; // 0x38
	public string OUTbMcNsjqSCoyOvypYfRuJEBjIG; // 0x40
	public string jikzQSMjMpgZgecgFFUsjEgxVWam; // 0x48
	private int KLiLeFOmHnIKewzsCXwtlSRRgkOA; // 0x50
	private int ZwxoEwSrePraFcQWlwoanfflAcnb; // 0x54
	private float[] CEooErXtzTRPgeKBtAJkbnzTRsVE; // 0x58
	private bool[] mAIOfbclLIXQWUKLRbVwkgXzcWDHA; // 0x60
	private bool[] WQhhvUpFieKZwdaZsGIWnwvEqNuv; // 0x68
	private float[] BNlVprOKXIEWAeaSOAohCoOyCloZA; // 0x70
	private bool[] cOAuaDceXbgMdciXfwwXKlzDnHjDb; // 0x78
	private HardwareJoystickMap_InputManager GvrRKEvhRFQLAyweejKeBxXVLmWt; // 0x80
	private bool SAdlFPLMsLBwgDQlaYYPmQaoaUTvA; // 0x88

	// Properties
	[CustomObfuscation(rename = False)]
	public int rewiredId { get; set; }
	[CustomObfuscation(rename = False)]
	public int inputManagerId { get; set; }
	[CustomObfuscation(rename = False)]
	public string name { get; }
	[CustomObfuscation(rename = False)]
	public Nullable<long> systemId { get; }
	[CustomObfuscation(rename = False)]
	public int unityId { get; set; }
	[CustomObfuscation(rename = False)]
	public Guid instanceGuid { get; }
	[CustomObfuscation(rename = False)]
	public Guid persistentGuid { get; }
	[CustomObfuscation(rename = False)]
	public Controller.Extension extension { get; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 8
	public int get_rewiredId() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_rewiredId(int value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500 Slot: 9
	public int get_inputManagerId() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_inputManagerId(int value) { }

	// RVA: 0x1A67100 Offset: 0x1A66300 VA: 0x181A67100 Slot: 10
	public string get_name() { }

	// RVA: 0x1A67180 Offset: 0x1A66380 VA: 0x181A67180 Slot: 11
	public Nullable<long> get_systemId() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80 Slot: 12
	public int get_unityId() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_unityId(int value) { }

	// RVA: 0x1A66F30 Offset: 0x1A66130 VA: 0x181A66F30 Slot: 14
	public Guid get_instanceGuid() { }

	// RVA: 0x1A67150 Offset: 0x1A66350 VA: 0x181A67150 Slot: 15
	public Guid get_persistentGuid() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 13
	public Controller.Extension get_extension() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 16
	public void SetVibration(float amount, int motorIndex) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 17
	public void StopVibration() { }

	// RVA: 0x1A66EE0 Offset: 0x1A660E0 VA: 0x181A66EE0
	public void .ctor() { }

	// RVA: 0x1A67D50 Offset: 0x1A66F50 VA: 0x181A67D50
	public void vUIJcCbrAgeFyiIJRWpgxSiQVgzHA() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A669B0 Offset: 0x1A65BB0 VA: 0x181A669B0 Slot: 4
	public void Update() { }

	// RVA: 0x1A65520 Offset: 0x1A64720 VA: 0x181A65520
	public int BxThmMJFHsklBXkYNDKZEyouGtEiA(boptZNiGvjuPyvHlFVuIWxQVdZPO.zhQheEWHFcibFaGUdvbxDsLyvoQhA ) { }

	// RVA: 0x1A67BE0 Offset: 0x1A66DE0 VA: 0x181A67BE0
	private void tWWpyvZJIzWVkxpbZRLZTdpqbswU(BridgedControllerHWInfo ) { }

	// RVA: 0x1A67C40 Offset: 0x1A66E40 VA: 0x181A67C40
	private void tWWpyvZJIzWVkxpbZRLZTdpqbswU(BridgedController ) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A65EE0 Offset: 0x1A650E0 VA: 0x181A65EE0 Slot: 5
	public void FillData(ControllerDataUpdater dataUpdater) { }

	// RVA: 0x1A66F20 Offset: 0x1A66120 VA: 0x181A66F20
	public void abPLPOVfPJjVLGcgQdWyXRsyplUGb(int ) { }

	// RVA: 0x1A65DB0 Offset: 0x1A64FB0 VA: 0x181A65DB0
	public void DZEGtXPjUJpXAkfWpLipQIwbRQpo() { }

	// RVA: 0x1A66E50 Offset: 0x1A66050 VA: 0x181A66E50
	public BridgedControllerHWInfo YBoCMuEVpOnMzGMPrUDrCQXEKTvFc() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A66860 Offset: 0x1A65A60 VA: 0x181A66860 Slot: 6
	public BridgedController ToBridgedController() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A66950 Offset: 0x1A65B50 VA: 0x181A66950 Slot: 7
	public ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs() { }

	// RVA: 0x1A671F0 Offset: 0x1A663F0 VA: 0x181A671F0
	private void hVTFHtOoileFsVYuBqRfFQwiFkuT() { }

	// RVA: 0x1A66AC0 Offset: 0x1A65CC0 VA: 0x181A66AC0
	private void VFyJeLbUwqdCubDgXEzfGHYdXVoy() { }

	// RVA: 0x1A672E0 Offset: 0x1A664E0 VA: 0x181A672E0
	private void iGODeOjYMoHUVsoqpUdUjBagWPjWA() { }

	// RVA: 0x1A67570 Offset: 0x1A66770 VA: 0x181A67570
	private bool npcTmKvcxuvvnoNaatHoeYTNzOye(HardwareJoystickMap.Platform_Fallback_Base.Button ) { }

	// RVA: 0x1923620 Offset: 0x1922820 VA: 0x181923620
	private bool WpkjzKjHSHrbNWVPxPuOhOMeSSJn(float , float ) { }

	// RVA: 0x1A665F0 Offset: 0x1A657F0 VA: 0x181A665F0
	private float NDdejHAFqRppvegAAPLfRXIrUvbfA(HardwareJoystickMap.Platform_Fallback_Base.Axis ) { }

	// RVA: 0x1A66820 Offset: 0x1A65A20 VA: 0x181A66820
	private float NDdejHAFqRppvegAAPLfRXIrUvbfA(UnityAxis ) { }

	// RVA: 0x1A67510 Offset: 0x1A66710 VA: 0x181A67510
	private bool npcTmKvcxuvvnoNaatHoeYTNzOye(UnityButton ) { }

	// RVA: 0x1A67E30 Offset: 0x1A67030 VA: 0x181A67E30
	private bool wylPajbEutjfzTqEwqwDgqNanrZt(HardwareJoystickMap.Platform_Fallback_Base.CustomCalculationSourceData , out bool ) { }

	// RVA: 0x1A67B60 Offset: 0x1A66D60 VA: 0x181A67B60
	private bool sOxIgSTnEBrWoHjMQFURNbvQjeYf(HardwareJoystickMap.Platform_Fallback_Base.CustomCalculationSourceData , out bool ) { }

	// RVA: 0x1A65440 Offset: 0x1A64640 VA: 0x181A65440
	private bool BbkisyCBVNlsvdnwJcyKIurywRwH(HardwareJoystickMap.Platform_Fallback_Base.CustomCalculationSourceData , out float ) { }

	// RVA: 0x1A67BA0 Offset: 0x1A66DA0 VA: 0x181A67BA0
	private bool slKYwPqzqggkldUCIqSDSNDvBQsl(UnityAxis ) { }

	// RVA: 0x1A655E0 Offset: 0x1A647E0 VA: 0x181A655E0
	private void CinMQxkMzclfOIqMTzYTvutvGGVu() { }

	// RVA: 0x1A67D00 Offset: 0x1A66F00 VA: 0x181A67D00
	private void uRagaBxqBRdQvDBHroJhMyUVfQqG() { }

	// RVA: 0x1A660A0 Offset: 0x1A652A0 VA: 0x181A660A0
	private string GDasauLghpjLJWblRztAFulKfQFB() { }

	// RVA: 0x1A66D90 Offset: 0x1A65F90 VA: 0x181A66D90
	private InputSource WSqIUQaCWKqROiiakuegaPrRZMkj() { }

	// RVA: 0x1A67B20 Offset: 0x1A66D20 VA: 0x181A67B20
	public static int ryNEDHYgtaGnQAxQJtkRQPmLNjpaA(boptZNiGvjuPyvHlFVuIWxQVdZPO.zhQheEWHFcibFaGUdvbxDsLyvoQhA , boptZNiGvjuPyvHlFVuIWxQVdZPO.zhQheEWHFcibFaGUdvbxDsLyvoQhA ) { }

	// RVA: 0x1A674D0 Offset: 0x1A666D0 VA: 0x181A674D0
	public static int jtNXmYzFErUZcvfvErcttOoEZQaE(boptZNiGvjuPyvHlFVuIWxQVdZPO.zhQheEWHFcibFaGUdvbxDsLyvoQhA , boptZNiGvjuPyvHlFVuIWxQVdZPO.zhQheEWHFcibFaGUdvbxDsLyvoQhA ) { }

	// RVA: 0x1A65E10 Offset: 0x1A65010 VA: 0x181A65E10
	private static string DjgwAmfXmCGwUEpCPCtpXLpGqbdN(string ) { }
}

// Namespace: 
public enum boptZNiGvjuPyvHlFVuIWxQVdZPO.vrDWDnpKECaFAiOCcjMPXONinDwD.hTCGEflmmpdGJHLhcqbSJEekzurQA // TypeDefIndex: 6943
{
	// Fields
	public int value__; // 0x0
	public const boptZNiGvjuPyvHlFVuIWxQVdZPO.vrDWDnpKECaFAiOCcjMPXONinDwD.hTCGEflmmpdGJHLhcqbSJEekzurQA Exact = 0;
	public const boptZNiGvjuPyvHlFVuIWxQVdZPO.vrDWDnpKECaFAiOCcjMPXONinDwD.hTCGEflmmpdGJHLhcqbSJEekzurQA Approximate = 1;
}

// Namespace: 
public class boptZNiGvjuPyvHlFVuIWxQVdZPO.vrDWDnpKECaFAiOCcjMPXONinDwD.pCeEcFBSmaaMcRdIDNlGtIkUeAHb // TypeDefIndex: 6944
{
	// Fields
	public int BBwCQyVLbzyfoFVwkYtvzileXHhL; // 0x10
	public int YGRtRbkcyBItMmPRPBZuUnGgIKoG; // 0x14
	public string VQuFlOZHzgrfElmcomnjBUhJWTdy; // 0x18
	public int BsSwaJwceNhPODhLijsOpChFqYNFb; // 0x20
	public string jikzQSMjMpgZgecgFFUsjEgxVWam; // 0x28

	// Methods

	// RVA: 0x1A64CE0 Offset: 0x1A63EE0 VA: 0x181A64CE0
	public bool BxThmMJFHsklBXkYNDKZEyouGtEiA(boptZNiGvjuPyvHlFVuIWxQVdZPO.zhQheEWHFcibFaGUdvbxDsLyvoQhA , boptZNiGvjuPyvHlFVuIWxQVdZPO.vrDWDnpKECaFAiOCcjMPXONinDwD.hTCGEflmmpdGJHLhcqbSJEekzurQA ) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class boptZNiGvjuPyvHlFVuIWxQVdZPO.vrDWDnpKECaFAiOCcjMPXONinDwD.TeEmzLelUvtnHDGaVILZkBXYECHX : IDisposable, IEnumerable<boptZNiGvjuPyvHlFVuIWxQVdZPO.vrDWDnpKECaFAiOCcjMPXONinDwD.pCeEcFBSmaaMcRdIDNlGtIkUeAHb>, IEnumerator<boptZNiGvjuPyvHlFVuIWxQVdZPO.vrDWDnpKECaFAiOCcjMPXONinDwD.pCeEcFBSmaaMcRdIDNlGtIkUeAHb>, IEnumerable, IEnumerator // TypeDefIndex: 6945
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private boptZNiGvjuPyvHlFVuIWxQVdZPO.vrDWDnpKECaFAiOCcjMPXONinDwD.pCeEcFBSmaaMcRdIDNlGtIkUeAHb lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public boptZNiGvjuPyvHlFVuIWxQVdZPO.vrDWDnpKECaFAiOCcjMPXONinDwD nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private boptZNiGvjuPyvHlFVuIWxQVdZPO.zhQheEWHFcibFaGUdvbxDsLyvoQhA RfmZkitaWRkEPIuHPhgHOpnAdtjx; // 0x30
	public boptZNiGvjuPyvHlFVuIWxQVdZPO.zhQheEWHFcibFaGUdvbxDsLyvoQhA pGetVvZBIWUgEAEwsRUzWFCOFkweA; // 0x38
	private boptZNiGvjuPyvHlFVuIWxQVdZPO.vrDWDnpKECaFAiOCcjMPXONinDwD.hTCGEflmmpdGJHLhcqbSJEekzurQA uVnJBjRlkHGVKhrITyeuUiifkVplA; // 0x40
	public boptZNiGvjuPyvHlFVuIWxQVdZPO.vrDWDnpKECaFAiOCcjMPXONinDwD.hTCGEflmmpdGJHLhcqbSJEekzurQA KrgeKHrEtkzqBpiYNozZkeLJwXnb; // 0x44
	private int iqqGtlTkrODzPKmcMiejERpvjzZb; // 0x48
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x4C

	// Properties
	private boptZNiGvjuPyvHlFVuIWxQVdZPO.vrDWDnpKECaFAiOCcjMPXONinDwD.pCeEcFBSmaaMcRdIDNlGtIkUeAHb System.Collections.Generic.IEnumerator<Rewired.FallbackInputManager.JoystickRecords.Record>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1A60B20 Offset: 0x1A5FD20 VA: 0x181A60B20 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private boptZNiGvjuPyvHlFVuIWxQVdZPO.vrDWDnpKECaFAiOCcjMPXONinDwD.pCeEcFBSmaaMcRdIDNlGtIkUeAHb System.Collections.Generic.IEnumerator<Rewired.FallbackInputManager.JoystickRecords.Record>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A60CF0 Offset: 0x1A5FEF0 VA: 0x181A60CF0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A60C20 Offset: 0x1A5FE20 VA: 0x181A60C20 Slot: 5
	private IEnumerator<boptZNiGvjuPyvHlFVuIWxQVdZPO.vrDWDnpKECaFAiOCcjMPXONinDwD.pCeEcFBSmaaMcRdIDNlGtIkUeAHb> System.Collections.Generic.IEnumerable<Rewired.FallbackInputManager.JoystickRecords.Record>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1A60C20 Offset: 0x1A5FE20 VA: 0x181A60C20 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
private class boptZNiGvjuPyvHlFVuIWxQVdZPO.vrDWDnpKECaFAiOCcjMPXONinDwD // TypeDefIndex: 6946
{
	// Fields
	private List<boptZNiGvjuPyvHlFVuIWxQVdZPO.vrDWDnpKECaFAiOCcjMPXONinDwD.pCeEcFBSmaaMcRdIDNlGtIkUeAHb> SoaTxmiZVylilBUxGputtEzixo; // 0x10

	// Properties
	public int ZGDajhyxNzhNBiKJhEAsWFQbqjCfA { get; }

	// Methods

	// RVA: 0x1A65040 Offset: 0x1A64240 VA: 0x181A65040
	public void .ctor() { }

	// RVA: 0x1A64EA0 Offset: 0x1A640A0 VA: 0x181A64EA0
	public int JkWSBcRXMqksDMwnqGuHKOiabncT() { }

	// RVA: 0x1A650B0 Offset: 0x1A642B0 VA: 0x181A650B0
	public void cHMfpVZrsbPeVMuIhniVwFDglNIV(boptZNiGvjuPyvHlFVuIWxQVdZPO.zhQheEWHFcibFaGUdvbxDsLyvoQhA ) { }

	// RVA: 0x1A64DE0 Offset: 0x1A63FE0 VA: 0x181A64DE0
	public bool HfHQDEyJodmDgQKMBJDYDJavMFDLA(boptZNiGvjuPyvHlFVuIWxQVdZPO.zhQheEWHFcibFaGUdvbxDsLyvoQhA , boptZNiGvjuPyvHlFVuIWxQVdZPO.vrDWDnpKECaFAiOCcjMPXONinDwD.hTCGEflmmpdGJHLhcqbSJEekzurQA ) { }

	// RVA: 0x1A653A0 Offset: 0x1A645A0 VA: 0x181A653A0
	public IEnumerable<boptZNiGvjuPyvHlFVuIWxQVdZPO.vrDWDnpKECaFAiOCcjMPXONinDwD.pCeEcFBSmaaMcRdIDNlGtIkUeAHb> lPQDuMkiSSQIihpYgkDZDPvlJJSu(boptZNiGvjuPyvHlFVuIWxQVdZPO.zhQheEWHFcibFaGUdvbxDsLyvoQhA , boptZNiGvjuPyvHlFVuIWxQVdZPO.vrDWDnpKECaFAiOCcjMPXONinDwD.hTCGEflmmpdGJHLhcqbSJEekzurQA ) { }

	// RVA: 0x1A64FA0 Offset: 0x1A641A0 VA: 0x181A64FA0
	public int ZVMYpYkqYXFpfBIVblsDvJTirAucA(boptZNiGvjuPyvHlFVuIWxQVdZPO.vrDWDnpKECaFAiOCcjMPXONinDwD.pCeEcFBSmaaMcRdIDNlGtIkUeAHb ) { }

	// RVA: 0x1A64EE0 Offset: 0x1A640E0 VA: 0x181A64EE0
	private void SKSluwrOxQKxUGRriwWsmDBKjdgN(int , int ) { }
}

// Namespace: 
internal class boptZNiGvjuPyvHlFVuIWxQVdZPO : PlatformInputManager // TypeDefIndex: 6947
{
	// Fields
	private List<boptZNiGvjuPyvHlFVuIWxQVdZPO.zhQheEWHFcibFaGUdvbxDsLyvoQhA> PgpGMyJfIPxDnbEBKMKFPoCrGZsy; // 0x38
	private int cgqOFbLCriWQJiMRqiHjBSiupijH; // 0x40
	private boptZNiGvjuPyvHlFVuIWxQVdZPO.vrDWDnpKECaFAiOCcjMPXONinDwD KzkEJJbQFFTnTRilEpvNrICbOBlNA; // 0x48
	private bool EzeaBeiGmiJMnWHCQwMdEpYfIHeKA; // 0x50
	private bool KoVPrAvmUNxtPODcpTfQjlddcLLDA; // 0x51
	private UpdateLoopType cCgYCUDwBYOudomcpBworRxTuvcG; // 0x54
	private UpdateLoopType SUNksWZqxrmbMQBwipWNsSzWLJWA; // 0x58
	private TimerAbs oQycGxuCTOMLCoUlsjezVkSIhsis; // 0x60
	private Action<int, ControllerDataUpdater> DNYtAGdVwiuWZYileahUqtqEwnGE; // 0x68
	private PlatformInputManager DCyjZfESLAOkdTXIKHvqlQGvbTTUA; // 0x70
	private readonly IUnifiedKeyboardSource PxnmiCulSCddfaNLwzXVfqlmJbudb; // 0x78
	private readonly IUnifiedMouseSource rCpvHZHkJWdeAtyCGfiaHbnzvtyM; // 0x80
	private bool zAnzEZlEIysXbnpHkusnUuCoSQfn; // 0x88
	private string[] NfReuuZSclpLwpipshfWihjQmKne; // 0x90

	// Properties
	[CustomObfuscation(rename = False)]
	public override int deviceCount { get; }
	[CustomObfuscation(rename = False)]
	public override PlatformInputManager primaryInputManager { get; }
	[CustomObfuscation(rename = False)]
	public override IInputSource inputSource { get; }
	[CustomObfuscation(rename = False)]
	public override InputSource inputSourceType { get; }

	// Methods

	// RVA: 0x1A62400 Offset: 0x1A61600 VA: 0x181A62400
	public void .ctor(UpdateLoopSetting ) { }

	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440 Slot: 4
	public override int get_deviceCount() { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980 Slot: 5
	public override PlatformInputManager get_primaryInputManager() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	public override IInputSource get_inputSource() { }

	// RVA: 0x68EEE0 Offset: 0x68E0E0 VA: 0x18068EEE0 Slot: 7
	public override InputSource get_inputSourceType() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A61170 Offset: 0x1A60370 VA: 0x181A61170 Slot: 8
	public override void Initialize() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A62200 Offset: 0x1A61400 VA: 0x181A62200 Slot: 9
	public override void Update(UpdateLoopType updateLoop) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A613C0 Offset: 0x1A605C0 VA: 0x181A613C0 Slot: 10
	public override void OnDestroy() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00 Slot: 14
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A620E0 Offset: 0x1A612E0 VA: 0x181A620E0 Slot: 13
	public override void UpdateControllerData(int assignedControllerId, ControllerDataUpdater data) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A61E00 Offset: 0x1A61000 VA: 0x181A61E00 Slot: 11
	public override void SystemDeviceConnected() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A61E20 Offset: 0x1A61020 VA: 0x181A61E20 Slot: 12
	public override void SystemDeviceDisconnected() { }

	// RVA: 0x1A61690 Offset: 0x1A60890 VA: 0x181A61690
	private void PnNFsnDBXLTVrzDtHSnqFlwjewVF() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1A61B90 Offset: 0x1A60D90 VA: 0x181A61B90 Slot: 15
	public override void SetUnityJoystickId(int joystickId, int unityJoystickId) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830 Slot: 16
	public override IUnifiedMouseSource GetUnifiedMouseSource() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0 Slot: 17
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource() { }

	// RVA: 0x1A61B60 Offset: 0x1A60D60 VA: 0x181A61B60
	private void RIuriNqVjKsBByFxgrAQeNPpJrfO() { }

	// RVA: 0x1A616A0 Offset: 0x1A608A0 VA: 0x181A616A0
	private void RIuriNqVjKsBByFxgrAQeNPpJrfO(string[] ) { }

	// RVA: 0x1A62620 Offset: 0x1A61820 VA: 0x181A62620
	private void amDwyChgubkalmVvfMfKySzVAnky(UpdateLoopType ) { }

	// RVA: 0x1A60D30 Offset: 0x1A5FF30 VA: 0x181A60D30
	private void BvfegPqXokMTUSkDADCUMTQniMRG(int , int , List<boptZNiGvjuPyvHlFVuIWxQVdZPO.zhQheEWHFcibFaGUdvbxDsLyvoQhA> , List<boptZNiGvjuPyvHlFVuIWxQVdZPO.zhQheEWHFcibFaGUdvbxDsLyvoQhA> ) { }

	// RVA: 0x1A62A70 Offset: 0x1A61C70 VA: 0x181A62A70
	private void uBIEYkNJYlXRMsSQgwVaxKfQNOZL(List<boptZNiGvjuPyvHlFVuIWxQVdZPO.zhQheEWHFcibFaGUdvbxDsLyvoQhA> , int , int ) { }

	// RVA: 0x1A62780 Offset: 0x1A61980 VA: 0x181A62780
	private bool omlZnYtqWrKdyKeYZyQNgPdPrPNr(List<boptZNiGvjuPyvHlFVuIWxQVdZPO.zhQheEWHFcibFaGUdvbxDsLyvoQhA> , int ) { }

	// RVA: 0x1A62830 Offset: 0x1A61A30 VA: 0x181A62830
	private int qXLoiFwvuZjhpGMtAmXVLCOCeLPHA(List<boptZNiGvjuPyvHlFVuIWxQVdZPO.zhQheEWHFcibFaGUdvbxDsLyvoQhA> ) { }

	// RVA: 0x1A62B50 Offset: 0x1A61D50 VA: 0x181A62B50
	private bool yyaMMqceOEJJroObWbCPqleBdAqQ(List<boptZNiGvjuPyvHlFVuIWxQVdZPO.zhQheEWHFcibFaGUdvbxDsLyvoQhA> , int ) { }

	// RVA: 0x1A60F40 Offset: 0x1A60140 VA: 0x181A60F40
	private void FtxjXWTwBwqvypdANfhcfvtrAvnr(int , List<boptZNiGvjuPyvHlFVuIWxQVdZPO.zhQheEWHFcibFaGUdvbxDsLyvoQhA> , int , List<boptZNiGvjuPyvHlFVuIWxQVdZPO.zhQheEWHFcibFaGUdvbxDsLyvoQhA> , boptZNiGvjuPyvHlFVuIWxQVdZPO.vrDWDnpKECaFAiOCcjMPXONinDwD.hTCGEflmmpdGJHLhcqbSJEekzurQA ) { }

	// RVA: 0x1A61E40 Offset: 0x1A61040 VA: 0x181A61E40
	private void TSdhtqxuBTyddRcZaoueBxqaksmd(int , List<boptZNiGvjuPyvHlFVuIWxQVdZPO.zhQheEWHFcibFaGUdvbxDsLyvoQhA> , boptZNiGvjuPyvHlFVuIWxQVdZPO.vrDWDnpKECaFAiOCcjMPXONinDwD.hTCGEflmmpdGJHLhcqbSJEekzurQA ) { }

	// RVA: 0x1A615C0 Offset: 0x1A607C0 VA: 0x181A615C0
	private void PBNysDZIhuKVqGFJCPknVwIwKmaA() { }

	// RVA: 0x1A626D0 Offset: 0x1A618D0 VA: 0x181A626D0
	private bool kQvSgtGmiXJjYJHkRVspEEZRbgqM(string[] ) { }

	// RVA: 0x1A61CE0 Offset: 0x1A60EE0 VA: 0x181A61CE0
	private void SlqRDGZYcIIsgahhkBJmTdNrBBwbA(List<boptZNiGvjuPyvHlFVuIWxQVdZPO.zhQheEWHFcibFaGUdvbxDsLyvoQhA> , List<boptZNiGvjuPyvHlFVuIWxQVdZPO.zhQheEWHFcibFaGUdvbxDsLyvoQhA> , bool ) { }

	// RVA: 0x1A628E0 Offset: 0x1A61AE0 VA: 0x181A628E0
	private void qfEGHcVCQYAhmLABLobjtRoUkdgC(boptZNiGvjuPyvHlFVuIWxQVdZPO.zhQheEWHFcibFaGUdvbxDsLyvoQhA , bool ) { }

	// RVA: 0x1A623B0 Offset: 0x1A615B0 VA: 0x181A623B0
	private void XQaczhdlYGMkeOJIKUTCGoonBoyvA() { }
}

// Namespace: 
internal class fJoDazWsXQzUMfRyTCGkItcorohd // TypeDefIndex: 6948
{
	// Fields
	private int AMndiOGZnSytvezxeokltganxOGDA; // 0x10
	private int SphBAoBaglkqqdxFQyuTzBdvPzOd; // 0x14
	private Player RhQEBqOXdmtNSVdJcpVSeShUrswx; // 0x18
	private Player[] pNAOIdpLmXkDGdqbJcYstSXWgeOu; // 0x20
	private Player[] ePmPUxPOBEJOiLKTQdFcDOBshKIHA; // 0x28
	private IList<Player> ojNqusNftsPLMVosKmUWlqEamILI; // 0x30
	private IList<Player> jCTsCTPjPqAtKfgGCmLFScbMVCJdA; // 0x38
	private ConfigVars ZxkkIiawGsBWNEjJJAIQzBlQuZaE; // 0x40
	private bool DzRdwaCjMKOeYXXRtYawwePnAsSb; // 0x48

	// Properties
	public int gKEuHSQqCqAdwaJNPlEeGyMffmpJb { get; }
	public int HdqyxevYzsHWwtbzEAcGhJnqbSNu { get; }
	public Player[] zsozacpAVEMuLxufknJQvdYbUFbd { get; }
	public Player[] dTQzkziSuLuYvFQAzjbVVnGtqBoQ { get; }
	public IList<Player> oCLfSpZIfnAINbaiKzztjVJyiQXV { get; }
	public IList<Player> wTVHtzebiDctmHLmDpRnMarRQnscA { get; }

	// Methods

	// RVA: 0x121F770 Offset: 0x121E970 VA: 0x18121F770
	public void .ctor(ConfigVars ) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int ioiVBzcUTeUZsXaWlXyvOjpQFpfC() { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int GwwLbDLFZzeIwqaDPDnVnEBQKthC() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Player[] tliHUayCnMltBvCDZdkdiJNaCXAC() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Player[] BbJHJTAghOcpvqoTmCMSLqVkBcOB() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public IList<Player> bbhBbdhOvVNyxbKbhIWUwRVNGuqBb() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public IList<Player> RAGKxKcAzHbXJFcMvUqAcxyZoyJFA() { }

	// RVA: 0x1A63480 Offset: 0x1A62680 VA: 0x181A63480
	public void ZFUcTEcndvHgBpdTmEAgSebxfOsJ() { }

	// RVA: 0x1A63AF0 Offset: 0x1A62CF0 VA: 0x181A63AF0
	public void aROpglyptfxQjxrftaYlsRIDqVVi(Joystick ) { }

	// RVA: 0x1A633C0 Offset: 0x1A625C0 VA: 0x181A633C0
	public void VqUXVrAtgpXXaYuGlqBCGTuxHTOc(Joystick ) { }

	// RVA: 0x1A633F0 Offset: 0x1A625F0 VA: 0x181A633F0
	public void YdHDApanZDiQIdqQrJUTApyGRnihc(ControllerType , int ) { }

	// RVA: 0x1A63110 Offset: 0x1A62310 VA: 0x181A63110
	public Player UjOJRtSfGjpDyMGBMrLJUMriSAzJ(int ) { }

	// RVA: 0x1A63240 Offset: 0x1A62440 VA: 0x181A63240
	public Player UjOJRtSfGjpDyMGBMrLJUMriSAzJ(string ) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Player RcZhrGshzhGhMcZFxsPobflmfawAA() { }

	// RVA: 0x1A64760 Offset: 0x1A63960 VA: 0x181A64760
	public int thuTgBVjPnqAhEqQQIdhDgejkOOO(string ) { }

	// RVA: 0x1A62EB0 Offset: 0x1A620B0 VA: 0x181A62EB0
	public bool LfPcXLdQYEqfJwrLwNQEAKCeFudg(int ) { }

	// RVA: 0x1A64230 Offset: 0x1A63430 VA: 0x181A64230
	public Player[] kzDrJZbPDTmerzZGvivIpgOEzAr(bool ) { }

	// RVA: 0x1A639F0 Offset: 0x1A62BF0 VA: 0x181A639F0
	public string[] aKBOXPowYwoWwcPSOSkjsCndaEtkA(bool ) { }

	// RVA: 0x1A64660 Offset: 0x1A63860 VA: 0x181A64660
	public string[] qqMYAgOfSDvwxHRukjuKGEtCCEKL(bool ) { }

	// RVA: 0x1A63E10 Offset: 0x1A63010 VA: 0x181A63E10
	public int[] epNrPbuZlKkZLpFpfxOPQJUjTUgQ(bool ) { }

	// RVA: 0x1A648B0 Offset: 0x1A63AB0 VA: 0x181A648B0
	public bool xLurEaQjixpQqiDhnzqdGkIGqZCT(Controller ) { }

	// RVA: 0x1A64990 Offset: 0x1A63B90 VA: 0x181A64990
	public bool xLurEaQjixpQqiDhnzqdGkIGqZCT(ControllerType , int ) { }

	// RVA: 0x1A62ED0 Offset: 0x1A620D0 VA: 0x181A62ED0
	public bool SLvoBPfPvPffzJXSVWYJpIclhYmIA(ControllerType , int , int ) { }

	// RVA: 0x1A644B0 Offset: 0x1A636B0 VA: 0x181A644B0
	public void pOdHubrDaWPCsTMFNTDlCtSdDRwq(Controller , bool ) { }

	// RVA: 0x1A64560 Offset: 0x1A63760 VA: 0x181A64560
	public void pOdHubrDaWPCsTMFNTDlCtSdDRwq(ControllerType , int , bool ) { }

	// RVA: 0x1A62D00 Offset: 0x1A61F00 VA: 0x181A62D00
	public bool JaIwrhpEeRALqnvCZICPenBcjvzKA(Joystick ) { }

	// RVA: 0x1A62DB0 Offset: 0x1A61FB0 VA: 0x181A62DB0
	public bool JaIwrhpEeRALqnvCZICPenBcjvzKA(int ) { }

	// RVA: 0x1A63DC0 Offset: 0x1A62FC0 VA: 0x181A63DC0
	public bool dptFCGOPrUIjtUnusSiwBShfJynF(int , int ) { }

	// RVA: 0x1A64080 Offset: 0x1A63280 VA: 0x181A64080
	public void jxvNSHRKqzPtAvyHfzuHnvwFhESj(Joystick , bool ) { }

	// RVA: 0x1A64130 Offset: 0x1A63330 VA: 0x181A64130
	public void jxvNSHRKqzPtAvyHfzuHnvwFhESj(int , bool ) { }

	// RVA: 0x1A62D00 Offset: 0x1A61F00 VA: 0x181A62D00
	public bool ULkjKKeSpzGMeahyzFagwuuMcpvkA(CustomController ) { }

	// RVA: 0x1A62F20 Offset: 0x1A62120 VA: 0x181A62F20
	public bool ULkjKKeSpzGMeahyzFagwuuMcpvkA(int ) { }

	// RVA: 0x1A62E60 Offset: 0x1A62060 VA: 0x181A62E60
	public bool JcKLdeNFZvmkmpCApyhpochRqEAl(int , int ) { }

	// RVA: 0x1A64300 Offset: 0x1A63500 VA: 0x181A64300
	public void mcebgqEvQlJvEKsEIcziArDJSoKoA(CustomController , bool ) { }

	// RVA: 0x1A643B0 Offset: 0x1A635B0 VA: 0x181A643B0
	public void mcebgqEvQlJvEKsEIcziArDJSoKoA(int , bool ) { }

	// RVA: 0x1A63F20 Offset: 0x1A63120 VA: 0x181A63F20
	private bool gfqumPcVHmpzhqLaBGinbARNLrnO(Joystick ) { }

	// RVA: 0x1A64A50 Offset: 0x1A63C50 VA: 0x181A64A50
	private bool yWmdISFZmjArhwBXkPTPyGHMdjHB(Joystick ) { }

	// RVA: 0x1A62BF0 Offset: 0x1A61DF0 VA: 0x181A62BF0
	private int GOEFFNcjJiYpGkFNxAuQYREJaYBBb() { }

	// RVA: 0x1A62FD0 Offset: 0x1A621D0 VA: 0x181A62FD0
	public int UbCdrnIAtwgZpDNCBESOHnbjQsFUe(int ) { }
}

// Namespace: Rewired
[Serializable]
public sealed class ActionElementMap // TypeDefIndex: 6949
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	internal int _actionCategoryId; // 0x10
	[SerializeField]
	[CustomObfuscation(rename = False)]
	internal int _actionId; // 0x14
	[CustomObfuscation(rename = False)]
	[SerializeField]
	internal ControllerElementType _elementType; // 0x18
	[CustomObfuscation(rename = False)]
	[SerializeField]
	internal int _elementIdentifierId; // 0x1C
	[SerializeField]
	[CustomObfuscation(rename = False)]
	internal AxisRange _axisRange; // 0x20
	[SerializeField]
	[CustomObfuscation(rename = False)]
	internal bool _invert; // 0x24
	[SerializeField]
	[CustomObfuscation(rename = False)]
	internal Pole _axisContribution; // 0x28
	[SerializeField]
	[CustomObfuscation(rename = False)]
	internal KeyboardKeyCode _keyboardKeyCode; // 0x2C
	[CustomObfuscation(rename = False)]
	[SerializeField]
	internal ModifierKey _modifierKey1; // 0x30
	[CustomObfuscation(rename = False)]
	[SerializeField]
	internal ModifierKey _modifierKey2; // 0x34
	[CustomObfuscation(rename = False)]
	[SerializeField]
	internal ModifierKey _modifierKey3; // 0x38
	internal ControllerMap SUGdqeYxYDFvxpaJyaCWAtSXvzHpA; // 0x40
	internal bool AqHaORMjZGTdLoJMHbRKCeXHvJfRA; // 0x48
	internal int nISbklZmCoWaHWDIpFZtyxRAgQfe; // 0x4C
	internal readonly int yAQloNnkxShCOoclhwMCxCpNptHE; // 0x50
	private uint TYBmIFDtApWWDDAqLSOEEaMOBTEHA; // 0x54
	private string LWLXVYRsOZOnvUcYgbjBDnuOsCrr; // 0x58
	private string cUdmqpKWOcSugXsFqFecyOZDfysz; // 0x60
	private ModifierKeyFlags FciSHNeCGhMWPrDcVCMDeLkVylLu; // 0x68
	private HardwareControllerMap_Game LLiIDKJrweGYZmSCOXSoynyQuBud; // 0x70
	private static int uidCounter; // 0x0
	private static StringBuilder s_toStringSB; // 0x8

	// Properties
	public int actionId { get; set; }
	public ControllerElementType elementType { get; set; }
	public int elementIdentifierId { get; set; }
	public AxisRange axisRange { get; set; }
	public bool invert { get; set; }
	public Pole axisContribution { get; set; }
	public KeyboardKeyCode keyboardKeyCode { get; set; }
	public ModifierKey modifierKey1 { get; set; }
	public ModifierKey modifierKey2 { get; set; }
	public ModifierKey modifierKey3 { get; set; }
	public AxisType axisType { get; }
	public ModifierKeyFlags modifierKeyFlags { get; }
	public KeyCode keyCode { get; set; }
	public bool hasModifiers { get; }
	public ControllerMap controllerMap { get; }
	public bool enabled { get; set; }
	public string elementIdentifierName { get; }
	public string actionDescriptiveName { get; }
	public int elementIndex { get; }
	public int id { get; }
	public object elementIdentifierGlyph { get; }
	public int elementIdentifierGlyphCount { get; }
	private bool HNUEIrubTrwfOICvfZKHZgXdLlNV { get; }
	private static int jLAGNYWCODnvImWNRQjMGXLYfgir { get; }

	// Methods

	// RVA: 0x1A543A0 Offset: 0x1A535A0 VA: 0x181A543A0
	internal static bool eMPbfPZwCoHAzZkdTEofcLCqfdRr(ActionElementMap ) { }

	// RVA: 0x1A55820 Offset: 0x1A54A20 VA: 0x181A55820
	internal static void vxObWzHArdLtQTOiFawkWkyGkdje(ActionElementMap , ActionElementMap ) { }

	// RVA: 0x1A537C0 Offset: 0x1A529C0 VA: 0x181A537C0
	public static bool TryGetCombinedElementIdentifierName(IList<ActionElementMap> actionElementMaps, out string result) { }

	// RVA: 0x1A53790 Offset: 0x1A52990 VA: 0x181A53790
	public static bool TryGetCombinedElementIdentifierGlyph(IList<ActionElementMap> actionElementMaps, out object result) { }

	// RVA: 0x1A53760 Offset: 0x1A52960 VA: 0x181A53760
	public static bool TryGetCombinedElementIdentifierFinalGlyphKey(IList<ActionElementMap> actionElementMaps, out string result) { }

	// RVA: 0x1A54DC0 Offset: 0x1A53FC0 VA: 0x181A54DC0
	private static bool oogyhTdFtUDAfaVlMMpyGYqZsmTab(IList<ActionElementMap> , bool , bool , out object , out string ) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_actionId() { }

	// RVA: 0x1A54FA0 Offset: 0x1A541A0 VA: 0x181A54FA0
	public void set_actionId(int value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public ControllerElementType get_elementType() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	internal void wzFYdjyUXnvQKzFlkFPZZGZPKwl(ControllerElementType ) { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public int get_elementIdentifierId() { }

	// RVA: 0x1A55190 Offset: 0x1A54390 VA: 0x181A55190
	public void set_elementIdentifierId(int value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public AxisRange get_axisRange() { }

	// RVA: 0x1A55060 Offset: 0x1A54260 VA: 0x181A55060
	public void set_axisRange(AxisRange value) { }

	// RVA: 0x695F30 Offset: 0x695130 VA: 0x180695F30
	public bool get_invert() { }

	// RVA: 0x7428E0 Offset: 0x741AE0 VA: 0x1807428E0
	public void set_invert(bool value) { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public Pole get_axisContribution() { }

	// RVA: 0x1A54FB0 Offset: 0x1A541B0 VA: 0x181A54FB0
	public void set_axisContribution(Pole value) { }

	// RVA: 0x5012C0 Offset: 0x5004C0 VA: 0x1805012C0
	public KeyboardKeyCode get_keyboardKeyCode() { }

	// RVA: 0x1A55460 Offset: 0x1A54660 VA: 0x181A55460
	public void set_keyboardKeyCode(KeyboardKeyCode value) { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public ModifierKey get_modifierKey1() { }

	// RVA: 0x1A55550 Offset: 0x1A54750 VA: 0x181A55550
	public void set_modifierKey1(ModifierKey value) { }

	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480
	public ModifierKey get_modifierKey2() { }

	// RVA: 0x1A55640 Offset: 0x1A54840 VA: 0x181A55640
	public void set_modifierKey2(ModifierKey value) { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	public ModifierKey get_modifierKey3() { }

	// RVA: 0x1A55730 Offset: 0x1A54930 VA: 0x181A55730
	public void set_modifierKey3(ModifierKey value) { }

	// RVA: 0x1A54890 Offset: 0x1A53A90 VA: 0x181A54890
	public AxisType get_axisType() { }

	// RVA: 0x1A54C60 Offset: 0x1A53E60 VA: 0x181A54C60
	public ModifierKeyFlags get_modifierKeyFlags() { }

	// RVA: 0x1A54C50 Offset: 0x1A53E50 VA: 0x181A54C50
	public KeyCode get_keyCode() { }

	// RVA: 0x1A55370 Offset: 0x1A54570 VA: 0x181A55370
	public void set_keyCode(KeyCode value) { }

	// RVA: 0x1A54C30 Offset: 0x1A53E30 VA: 0x181A54C30
	public bool get_hasModifiers() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public ControllerMap get_controllerMap() { }

	// RVA: 0x445A70 Offset: 0x444C70 VA: 0x180445A70
	public bool get_enabled() { }

	// RVA: 0x445A80 Offset: 0x444C80 VA: 0x180445A80
	public void set_enabled(bool value) { }

	// RVA: 0x1A54B10 Offset: 0x1A53D10 VA: 0x181A54B10
	public string get_elementIdentifierName() { }

	// RVA: 0x1A54640 Offset: 0x1A53840 VA: 0x181A54640
	public string get_actionDescriptiveName() { }

	// RVA: 0x547AA0 Offset: 0x546CA0 VA: 0x180547AA0
	public int get_elementIndex() { }

	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410
	public int get_id() { }

	// RVA: 0x1A549A0 Offset: 0x1A53BA0 VA: 0x181A549A0
	public object get_elementIdentifierGlyph() { }

	// RVA: 0x1A548B0 Offset: 0x1A53AB0 VA: 0x181A548B0
	public int get_elementIdentifierGlyphCount() { }

	// RVA: 0x1A54F70 Offset: 0x1A54170 VA: 0x181A54F70
	private bool rFthHPKVQldXkRYwdPJLawBybGgXA() { }

	// RVA: 0x1A53040 Offset: 0x1A52240 VA: 0x181A53040
	private static int TnEiZjlUpdgKjZaXRQnwJGDdRmyt() { }

	// RVA: 0x1A53990 Offset: 0x1A52B90 VA: 0x181A53990
	public void .ctor() { }

	// RVA: 0x1A53A10 Offset: 0x1A52C10 VA: 0x181A53A10
	public void .ctor(ActionElementMap ) { }

	// RVA: 0x1A53B90 Offset: 0x1A52D90 VA: 0x181A53B90
	public void .ctor(int , ControllerElementType , int ) { }

	// RVA: 0x1A53930 Offset: 0x1A52B30 VA: 0x181A53930
	public void .ctor(int , ControllerElementType , int , Pole , AxisRange ) { }

	// RVA: 0x1A53B30 Offset: 0x1A52D30 VA: 0x181A53B30
	public void .ctor(int , ControllerElementType , int , Pole , AxisRange , bool ) { }

	// RVA: 0x1A53BE0 Offset: 0x1A52DE0 VA: 0x181A53BE0
	public void .ctor(int , ControllerElementType , Pole , KeyboardKeyCode , ModifierKey , ModifierKey , ModifierKey ) { }

	// RVA: 0x1A51F30 Offset: 0x1A51130 VA: 0x181A51F30
	public bool CheckForAssignmentConflict(ElementAssignment elementAssignment) { }

	// RVA: 0x1A52090 Offset: 0x1A51290 VA: 0x181A52090
	public bool CheckForAssignmentConflict(ActionElementMap elementMap) { }

	// RVA: 0x1A52E80 Offset: 0x1A52080 VA: 0x181A52E80
	public bool ShowInField(AxisRange fieldActionRange) { }

	// RVA: 0x1A52830 Offset: 0x1A51A30 VA: 0x181A52830
	public bool IsTarget(ControllerElementTarget elementTarget) { }

	// RVA: 0x1A52880 Offset: 0x1A51A80 VA: 0x181A52880
	public bool IsTarget(IControllerElementTarget elementTarget) { }

	// RVA: 0x1A52690 Offset: 0x1A51890 VA: 0x181A52690
	public int GetElementIdentifierGlyphs(ICollection<object> results) { }

	// RVA: -1 Offset: -1
	public int GetElementIdentifierGlyphs<T>(ICollection<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E4AB0 Offset: 0x8E3CB0 VA: 0x1808E4AB0
	|-ActionElementMap.GetElementIdentifierGlyphs<object>
	|
	|-RVA: 0x8E47C0 Offset: 0x8E39C0 VA: 0x1808E47C0
	|-ActionElementMap.GetElementIdentifierGlyphs<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1A52500 Offset: 0x1A51700 VA: 0x181A52500
	public int GetElementIdentifierFinalGlyphKeys(ICollection<string> results) { }

	// RVA: 0x1A51EA0 Offset: 0x1A510A0 VA: 0x181A51EA0
	internal void BYYZtczAmRGNUFRyITtTjlWUKwCRA(ControllerMap ) { }

	// RVA: 0x1A54CB0 Offset: 0x1A53EB0 VA: 0x181A54CB0
	internal void hhYENXqWehtOLkfjaPnHZIgCoPXu(ControllerMap , HardwareControllerMap_Game ) { }

	// RVA: 0x1A51BE0 Offset: 0x1A50DE0 VA: 0x181A51BE0
	private void BYYZtczAmRGNUFRyITtTjlWUKwCRA(bool ) { }

	// RVA: 0x1A51C70 Offset: 0x1A50E70 VA: 0x181A51C70
	private void BYYZtczAmRGNUFRyITtTjlWUKwCRA(ControllerType , HardwareControllerMap_Game , bool ) { }

	// RVA: 0x1A544A0 Offset: 0x1A536A0 VA: 0x181A544A0
	private string fCEBnlGzeODrmQNMhbPAtesNlBEu() { }

	// RVA: 0x1A52130 Offset: 0x1A51330 VA: 0x181A52130
	private int FWDbfUimSzNsAkPOJRgzeqYgNEsyA(ICollection<object> ) { }

	// RVA: 0x1A53C50 Offset: 0x1A52E50 VA: 0x181A53C50
	private int bWeKzcHIPIgBrfLLFyFmvNVGIJaP(ICollection<string> ) { }

	// RVA: 0x1A54450 Offset: 0x1A53650 VA: 0x181A54450
	internal void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }

	// RVA: 0x1A52DF0 Offset: 0x1A51FF0 VA: 0x181A52DF0
	private bool RSEYejjCSrYwvvfACtLbMDSCuJyC(KeyboardKeyCode , ModifierKeyFlags ) { }

	// RVA: 0x1A54D30 Offset: 0x1A53F30 VA: 0x181A54D30
	private bool nWhyHgaESJDwSZrNlvWbFnvgmkty(int , AxisRange ) { }

	// RVA: 0x1A55930 Offset: 0x1A54B30 VA: 0x181A55930
	private bool xjEBCdgdBzdXyeCbgmbTgRcYZikac(ElementAssignmentType ) { }

	// RVA: 0x1A54020 Offset: 0x1A53220 VA: 0x181A54020
	private void cbOXppbDnMVsdblVPumRydWOYYvv() { }

	// RVA: 0x1A52A80 Offset: 0x1A51C80 VA: 0x181A52A80
	private void JQHxOruBVIsSOkXQGhLlIDxTqOgS() { }

	// RVA: 0x1A54340 Offset: 0x1A53540 VA: 0x181A54340
	private void eFKxiDHkjVdSjgdlQUwsHWvvlPPB() { }

	// RVA: 0x1A54040 Offset: 0x1A53240 VA: 0x181A54040
	internal SerializedObject dDwdeldWYOLrnWiNJjDBHtCWImLzA() { }

	// RVA: 0x1A52B70 Offset: 0x1A51D70 VA: 0x181A52B70
	internal void MQHErEylLpkabJiPJFPMzIMISIct(SerializedObject ) { }

	// RVA: 0x1A530A0 Offset: 0x1A522A0 VA: 0x181A530A0 Slot: 3
	public override string ToString() { }
}

// Namespace: Rewired
public class CalibrationMapSaveData // TypeDefIndex: 6950
{
	// Fields
	private CalibrationMap AWAvkdcjHHLYGAklEIGyDfmCbCrCA; // 0x10
	private ControllerType mssadAAejyKGHIfognJBtXtNdiiIB; // 0x18
	private string BazzorGvIrjXLTaiPiNltxRZEFJp; // 0x20

	// Properties
	public CalibrationMap map { get; }
	public ControllerType controllerType { get; }
	public string hardwareIdentifier { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public CalibrationMap get_map() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public ControllerType get_controllerType() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_hardwareIdentifier() { }

	// RVA: 0x17E1FC0 Offset: 0x17E11C0 VA: 0x1817E1FC0
	public void .ctor(CalibrationMap , ControllerType , string ) { }
}

// Namespace: Rewired
public sealed class JoystickCalibrationMapSaveData : CalibrationMapSaveData // TypeDefIndex: 6951
{
	// Fields
	private Guid tIdaONkCUdCBUEyrFBIhoCiRFtPQb; // 0x28

	// Properties
	public Guid joystickHardwareTypeGuid { get; }

	// Methods

	// RVA: 0x3F6C80 Offset: 0x3F5E80 VA: 0x1803F6C80
	public Guid get_joystickHardwareTypeGuid() { }

	// RVA: 0x1A57410 Offset: 0x1A56610 VA: 0x181A57410
	public void .ctor(CalibrationMap , ControllerType , string , Guid ) { }
}

// Namespace: Rewired
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
public sealed class CalibrationMap // TypeDefIndex: 6952
{
	// Fields
	private AxisCalibration[] iOiGlgowbpfDxumNoPsdAANtDKPJA; // 0x10
	private MappedArray<AxisCalibration> jSYtiZxyyLnrHVzhFgNYwXOJvZmT; // 0x18
	private IList<AxisCalibration> uRTgRuWEdsXhHxvjsilPKxkgqzOE; // 0x20
	private readonly int aplyKYJQthDqFZJRnEooAHmQTlabA; // 0x28

	// Properties
	public IList<AxisCalibration> Axes { get; }
	public int axisCount { get; }

	// Methods

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public IList<AxisCalibration> get_Axes() { }

	// RVA: 0x727230 Offset: 0x726430 VA: 0x180727230
	public int get_axisCount() { }

	// RVA: 0x1A56AC0 Offset: 0x1A55CC0 VA: 0x181A56AC0
	private void .ctor() { }

	// RVA: 0x1A567E0 Offset: 0x1A559E0 VA: 0x181A567E0
	internal void .ctor(AxisCalibrationData[] , Func<int, int> ) { }

	// RVA: 0x1A56A00 Offset: 0x1A55C00 VA: 0x181A56A00
	public void .ctor(AxisCalibration[] ) { }

	// RVA: 0x1A56370 Offset: 0x1A55570 VA: 0x181A56370
	public void Reset() { }

	// RVA: 0x1A55C20 Offset: 0x1A54E20 VA: 0x181A55C20
	public AxisCalibration GetAxis(int index) { }

	// RVA: 0x1A55D70 Offset: 0x1A54F70 VA: 0x181A55D70
	public float GetCalibratedValue(int axisIndex, float value) { }

	// RVA: 0x1A56460 Offset: 0x1A55660 VA: 0x181A56460
	public bool SetAxisData(int index, AxisCalibrationData data) { }

	// RVA: 0x1A55AC0 Offset: 0x1A54CC0 VA: 0x181A55AC0
	public AxisCalibrationData GetAxisData(int index) { }

	// RVA: 0x1A559B0 Offset: 0x1A54BB0 VA: 0x181A559B0
	internal void CopyFrom(CalibrationMap map, bool copyHardwareDeadzone) { }

	// RVA: 0x1A566A0 Offset: 0x1A558A0 VA: 0x181A566A0
	public string ToXmlString() { }

	// RVA: 0x1A56590 Offset: 0x1A55790 VA: 0x181A56590
	public string ToJsonString() { }

	// RVA: 0x1A55FF0 Offset: 0x1A551F0 VA: 0x181A55FF0
	public bool ImportXmlString(string xmlString) { }

	// RVA: 0x1A55E80 Offset: 0x1A55080 VA: 0x181A55E80
	public bool ImportJsonString(string jsonString) { }

	// RVA: 0x1A56B60 Offset: 0x1A55D60 VA: 0x181A56B60
	private SerializedObject dDwdeldWYOLrnWiNJjDBHtCWImLzA() { }

	// RVA: 0x1A56160 Offset: 0x1A55360 VA: 0x181A56160
	private void MQHErEylLpkabJiPJFPMzIMISIct(SerializedObject ) { }

	// RVA: 0x1A55CF0 Offset: 0x1A54EF0 VA: 0x181A55CF0
	internal Vector2 GetCalibrated2DValue(int xAxisIndex, int yAxisIndex, float valueRawX, float valueRawY, DeadZone2DType deadZoneType, AxisSensitivity2DType sensitivityType) { }
}

// Namespace: Rewired
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class AxisCalibration // TypeDefIndex: 6953
{
	// Fields
	private AlternateAxisCalibrationType _calibrationMode; // 0x10
	private Dictionary<int, AxisCalibrationInfo> _hardwareCalibrations; // 0x18
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Enables or disables the Axis. A disabled Axis always returns a value of 0.")]
	private bool _enabled; // 0x20
	[CustomObfuscation(rename = False)]
	[SerializeField]
	[Tooltip("Enables or disables the Axis. A disabled Axis always returns a value of 0.")]
	private float _deadZone; // 0x24
	[Tooltip("Enables or disables the Axis. A disabled Axis always returns a value of 0.")]
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private float _calibratedZero; // 0x28
	[Tooltip("Gets or sets the minimum value. This can be used to transform the value to a new range.")]
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _calibratedMin; // 0x2C
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Gets or sets the maximum value. This can be used to transform the value to a new range.")]
	private float _calibratedMax; // 0x30
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("If true, the final value will be multiplied by -1. This can be used to correct an inverted Axis.")]
	private bool _invert; // 0x34
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("Determines how sensitivity will be calculated.
If sensitivityType is set to Multiplier or Power, the sensitivity property is used to calculate the value.
If sensitivityType is set to Curve, the sensitivityCurve property is used to calculate the value.")]
	private AxisSensitivityType _sensitivityType; // 0x38
	[CustomObfuscation(rename = False)]
	[FieldRange(0, ∞)]
	[Tooltip("Gets or sets the sensitivity value.")]
	[SerializeField]
	private float _sensitivity; // 0x3C
	[CustomObfuscation(rename = False)]
	[SerializeField]
	[Tooltip("Gets or sets the sensitivity curve. The curve has no effect unless sensitivityType is set to Curve.")]
	private AnimationCurve _sensitivityCurve; // 0x40
	[Tooltip("If enabled, calibratedMin, calibratedMax, and calibratedZero will be used to convert the value to a new range.
If disabled, calibratedMin, calibratedMax, and calibratedZero will have no effect on the final value.")]
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private bool _applyRangeCalibration; // 0x48

	// Properties
	public bool enabled { get; set; }
	public float deadZone { get; set; }
	public float calibratedZero { get; set; }
	public float calibratedMin { get; set; }
	public float calibratedMax { get; set; }
	public bool invert { get; set; }
	public AxisSensitivityType sensitivityType { get; set; }
	public float sensitivity { get; set; }
	public AnimationCurve sensitivityCurve { get; set; }
	public bool applyRangeCalibration { get; set; }
	internal AlternateAxisCalibrationType calibrationMode { get; set; }

	// Methods

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_enabled() { }

	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	public void set_enabled(bool value) { }

	// RVA: 0x499040 Offset: 0x498240 VA: 0x180499040
	public float get_deadZone() { }

	// RVA: 0x1A6AA60 Offset: 0x1A69C60 VA: 0x181A6AA60
	public void set_deadZone(float value) { }

	// RVA: 0x484D20 Offset: 0x483F20 VA: 0x180484D20
	public float get_calibratedZero() { }

	// RVA: 0x484EB0 Offset: 0x4840B0 VA: 0x180484EB0
	public void set_calibratedZero(float value) { }

	// RVA: 0x6F31E0 Offset: 0x6F23E0 VA: 0x1806F31E0
	public float get_calibratedMin() { }

	// RVA: 0x498F90 Offset: 0x498190 VA: 0x180498F90
	public void set_calibratedMin(float value) { }

	// RVA: 0x527470 Offset: 0x526670 VA: 0x180527470
	public float get_calibratedMax() { }

	// RVA: 0x499010 Offset: 0x498210 VA: 0x180499010
	public void set_calibratedMax(float value) { }

	// RVA: 0x78E680 Offset: 0x78D880 VA: 0x18078E680
	public bool get_invert() { }

	// RVA: 0x18C42D0 Offset: 0x18C34D0 VA: 0x1818C42D0
	public void set_invert(bool value) { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	public AxisSensitivityType get_sensitivityType() { }

	// RVA: 0x423300 Offset: 0x422500 VA: 0x180423300
	public void set_sensitivityType(AxisSensitivityType value) { }

	// RVA: 0x5D01F0 Offset: 0x5CF3F0 VA: 0x1805D01F0
	public float get_sensitivity() { }

	// RVA: 0x5D0200 Offset: 0x5CF400 VA: 0x1805D0200
	public void set_sensitivity(float value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public AnimationCurve get_sensitivityCurve() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_sensitivityCurve(AnimationCurve value) { }

	// RVA: 0x445A70 Offset: 0x444C70 VA: 0x180445A70
	public bool get_applyRangeCalibration() { }

	// RVA: 0x445A80 Offset: 0x444C80 VA: 0x180445A80
	public void set_applyRangeCalibration(bool value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	internal AlternateAxisCalibrationType get_calibrationMode() { }

	// RVA: 0x1A6AA50 Offset: 0x1A69C50 VA: 0x181A6AA50
	internal void set_calibrationMode(AlternateAxisCalibrationType value) { }

	// RVA: 0x1A6A5E0 Offset: 0x1A697E0 VA: 0x181A6A5E0
	internal void .ctor() { }

	// RVA: 0x1A6A810 Offset: 0x1A69A10 VA: 0x181A6A810
	internal void .ctor(bool , Dictionary<int, AxisCalibrationInfo> , float , float , float , float , bool , bool , AxisSensitivityType , float , AnimationCurve ) { }

	// RVA: 0x1A6A480 Offset: 0x1A69680 VA: 0x181A6A480
	internal void .ctor(AxisCalibrationData ) { }

	// RVA: 0x1A68F80 Offset: 0x1A68180 VA: 0x181A68F80
	internal void CopyFrom(AxisCalibration data, bool copyHardwareData) { }

	// RVA: 0x1A69A00 Offset: 0x1A68C00 VA: 0x181A69A00
	public float GetCalibratedValue(float value) { }

	// RVA: 0x1A69800 Offset: 0x1A68A00 VA: 0x181A69800
	internal float GetCalibratedValue(float value, float customDeadzone, bool applySensitivity, bool applyInversion) { }

	// RVA: 0x1A69AC0 Offset: 0x1A68CC0 VA: 0x181A69AC0
	public float GetCalibratedValue(float value, AxisRange axisRange) { }

	// RVA: 0x1A698E0 Offset: 0x1A68AE0 VA: 0x181A698E0
	internal float GetCalibratedValue(float value, AxisRange axisRange, float customDeadzone, bool applySensitivity, bool applyInversion) { }

	// RVA: 0x1A69BE0 Offset: 0x1A68DE0 VA: 0x181A69BE0
	public AxisCalibrationData GetData() { }

	// RVA: 0x1A6A410 Offset: 0x1A69610 VA: 0x181A6A410
	public void SetData(AxisCalibrationData data) { }

	// RVA: 0x1A6A260 Offset: 0x1A69460 VA: 0x181A6A260
	public void Reset() { }

	// RVA: 0x1A69570 Offset: 0x1A68770 VA: 0x181A69570
	internal SerializedObject ExportData() { }

	// RVA: 0x1A69DB0 Offset: 0x1A68FB0 VA: 0x181A69DB0
	internal void Import(SerializedObject serializedObject) { }

	// RVA: 0x1A69FB0 Offset: 0x1A691B0 VA: 0x181A69FB0
	private void InitHardwareCalibrations(Dictionary<int, AxisCalibrationInfo> hardwareCalibrations, AxisCalibrationData defaultData) { }

	// RVA: 0x1A69090 Offset: 0x1A68290 VA: 0x181A69090
	private void CreateDefaultHardwareCalibration(AxisCalibrationData defaultData) { }

	// RVA: 0x1A69CB0 Offset: 0x1A68EB0 VA: 0x181A69CB0
	private AxisCalibrationInfo GetHardwareDefault() { }

	// RVA: 0x1A69140 Offset: 0x1A68340 VA: 0x181A69140
	internal static AxisCalibration CreateRelative() { }
}

// Namespace: Rewired
public struct AxisCalibrationData // TypeDefIndex: 6954
{
	// Fields
	public bool enabled; // 0x0
	public float deadZone; // 0x4
	public float zero; // 0x8
	public float min; // 0xC
	public float max; // 0x10
	public bool invert; // 0x14
	public AxisSensitivityType sensitivityType; // 0x18
	public float sensitivity; // 0x1C
	public AnimationCurve sensitivityCurve; // 0x20
	public bool applyRangeCalibration; // 0x28
	[CustomObfuscation(rename = False)]
	internal Dictionary<int, AxisCalibrationInfo> calibrations; // 0x30

	// Properties
	public static AxisCalibrationData Default { get; }
	[CustomObfuscation(rename = False)]
	internal static AxisCalibrationData Raw { get; }

	// Methods

	// RVA: 0x1A68920 Offset: 0x1A67B20 VA: 0x181A68920
	public void .ctor(bool , float , float , float , float , bool , bool ) { }

	// RVA: 0x1A68B10 Offset: 0x1A67D10 VA: 0x181A68B10
	public void .ctor(bool , float , float , float , float , bool , bool , float ) { }

	// RVA: 0x1A68AB0 Offset: 0x1A67CB0 VA: 0x181A68AB0
	public void .ctor(bool , float , float , float , float , bool , bool , AxisSensitivityType , float , AnimationCurve ) { }

	// RVA: 0x1A68CB0 Offset: 0x1A67EB0 VA: 0x181A68CB0
	public static AxisCalibrationData get_Default() { }

	// RVA: 0x1A68E20 Offset: 0x1A68020 VA: 0x181A68E20
	internal static AxisCalibrationData get_Raw() { }
}

// Namespace: Rewired
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class Axis2DCalibration // TypeDefIndex: 6955
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	[Tooltip("The calculation type for the dead zone.")]
	private DeadZone2DType _deadZoneType; // 0x10
	[CustomObfuscation(rename = False)]
	[Tooltip("Calculation type for sensitivity on 2D axes.")]
	[SerializeField]
	private AxisSensitivity2DType _sensitivityType; // 0x14

	// Properties
	public DeadZone2DType deadZoneType { get; set; }
	public AxisSensitivity2DType sensitivityType { get; set; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public DeadZone2DType get_deadZoneType() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_deadZoneType(DeadZone2DType value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public AxisSensitivity2DType get_sensitivityType() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_sensitivityType(AxisSensitivity2DType value) { }

	// RVA: 0x16574A0 Offset: 0x16566A0 VA: 0x1816574A0
	internal void .ctor() { }

	// RVA: 0x1A683F0 Offset: 0x1A675F0 VA: 0x181A683F0
	internal Vector2 GetCalibrated2DValue(float valueRawX, float valueRawY, AxisCalibration xAxis, AxisCalibration yAxis) { }

	// RVA: 0x1A67ED0 Offset: 0x1A670D0 VA: 0x181A67ED0
	internal static Vector2 GetCalibrated2DValue(float valueRawX, float valueRawY, AxisCalibration xAxis, AxisCalibration yAxis, DeadZone2DType deadZoneType, AxisSensitivity2DType sensitivityType) { }
}

// Namespace: 
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal class ControllerElementIdentifier.vrCPviWPNzNACqMBjKpVQfDwMNSs // TypeDefIndex: 6956
{
	// Fields
	public int id; // 0x10
	public string name; // 0x18
	public string positiveName; // 0x20
	public string negativeName; // 0x28
	public string key; // 0x30
	public string positiveKey; // 0x38
	public string negativeKey; // 0x40
	public ControllerElementType elementType; // 0x48
	public CompoundControllerElementType compoundElementType; // 0x4C

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ControllerElementIdentifier.cRyGGoChxcsvioAbNtJACrqakpUXA.oDhjfoRKTtjWBYczWLypaQuRLlyT // TypeDefIndex: 6957
{
	// Fields
	public static readonly ControllerElementIdentifier.cRyGGoChxcsvioAbNtJACrqakpUXA.oDhjfoRKTtjWBYczWLypaQuRLlyT <>9; // 0x0
	public static Func<ControllerElementIdentifier, ControllerElementIdentifier, bool> <>9__4_0; // 0x8

	// Methods

	// RVA: 0x1A87C10 Offset: 0x1A86E10 VA: 0x181A87C10
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1A87C70 Offset: 0x1A86E70 VA: 0x181A87C70
	internal bool hbcorxGebSGWVAXdCpuOmiBRYN(ControllerElementIdentifier , ControllerElementIdentifier ) { }
}

// Namespace: 
internal sealed class ControllerElementIdentifier.cRyGGoChxcsvioAbNtJACrqakpUXA // TypeDefIndex: 6958
{
	// Fields
	private static ControllerElementIdentifier.cRyGGoChxcsvioAbNtJACrqakpUXA UVLGozxGAPPfmLecELzdCiykSygT; // 0x0
	private readonly RBTbtfxxywGQyDGTOxgBUjFHeEtDA<ControllerElementIdentifier> QeVLqlLfKsiVaedHloOvPDTgmMxV; // 0x10

	// Properties
	private static ControllerElementIdentifier.cRyGGoChxcsvioAbNtJACrqakpUXA mqkLfedmeRcvYyKvtVwYnkyMiHag { get; }

	// Methods

	// RVA: 0x1A87940 Offset: 0x1A86B40 VA: 0x181A87940
	private static ControllerElementIdentifier.cRyGGoChxcsvioAbNtJACrqakpUXA dUqVkBxkvhUZAFBuybiKFczmYXLb() { }

	// RVA: 0x1A87760 Offset: 0x1A86960 VA: 0x181A87760
	private void .ctor() { }

	// RVA: 0x1A87890 Offset: 0x1A86A90 VA: 0x181A87890
	private void cneJLUqoVILjQOkyKwaOlYsbtCCC() { }

	// RVA: 0x1A87620 Offset: 0x1A86820 VA: 0x181A87620
	private void KPSfUAGoTAczUoyxgCKaOthRkGmo() { }

	// RVA: 0x1A876E0 Offset: 0x1A868E0 VA: 0x181A876E0
	public static ControllerElementIdentifier PjrvWYysdnhrOONinazkfAfeuaqX(DeviceLocalizationInfo , ControllerElementIdentifier ) { }

	// RVA: 0x1A87580 Offset: 0x1A86780 VA: 0x181A87580
	public static bool BBzDvtkJMbhpEdyHcGDPFStcUenSc(DeviceLocalizationInfo , ControllerElementIdentifier , out ControllerElementIdentifier ) { }

	// RVA: 0x1A87B90 Offset: 0x1A86D90 VA: 0x181A87B90
	public static void xXDAAgkpHyujExYwkSGAdhBokBcFb(DeviceLocalizationInfo , ControllerElementIdentifier ) { }
}

// Namespace: 
private class ControllerElementIdentifier.aRUkUFLmXrSIgIEEqHVEYMVhKmJv // TypeDefIndex: 6959
{
	// Fields
	[SerializeField]
	private string sKEfXRhGnVSsmWsCqaKxYnjRjSNb; // 0x10
	[SerializeField]
	private string LMzQCtpoynfYEpBZHVCnvIXoALpIA; // 0x18

	// Properties
	public string OBqnLJQoPJGIQnqhihiXTClNELYH { get; set; }
	public string aCRYYTbbujWDguafSiRCsFIGtvKp { get; set; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string drsVLKNsGZvRlpOFRpNJQUExHJls() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void IQWWRHlTEbfsugQDrnuadMGeayzfA(string ) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string PCjITsTXyHXjpjtBCJYiIxgYqmkA() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void jCFVgVBGLNUCoaKAgHSqMXrAShKS(string ) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1A86EB0 Offset: 0x1A860B0 VA: 0x181A86EB0
	public void .ctor(ControllerElementIdentifier.aRUkUFLmXrSIgIEEqHVEYMVhKmJv ) { }
}

// Namespace: Rewired
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
[Serializable]
public sealed class ControllerElementIdentifier : IControllerElementIdentifierCommon_Internal, ftUiUAiTGSDgAJCvnFpXJSUgtERQ, zrLlTBFrsLrsiFBlwbgZFmRqZSoTA, nXthwLMIItnYHznlYeVDMBlZcram, XQOjApDcMWsPUSvljHPeHPNlsqaf, pnvftOaMtZZJUzhBeNdWAoRZoPnw, yPgObMfdVeyidpXQsRmkzbdbGSYW // TypeDefIndex: 6960
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int _id; // 0x10
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private string _name; // 0x18
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private string _positiveName; // 0x20
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _negativeName; // 0x28
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _key; // 0x30
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private string _positiveKey; // 0x38
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private string _negativeKey; // 0x40
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private ControllerElementType _elementType; // 0x48
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private CompoundControllerElementType _compoundElementType; // 0x4C
	private bool zOKzuYXFLGIRkSsulGEskMlxDTlI; // 0x50
	private rGRdrxTKDosARhftgPYJzWggGTSV AkwnqXXHArVvqcvmLTucKpAEeKMDA; // 0x58
	private UkmCHYHZTndoGrakMrsDHlZDdySdA xFKLAuZXitCebffHCEaOcRlBhvpDA; // 0x60
	private OtqiuewQtwfnnJcVyCaygEVrnxnm pyyUuDUlQtnAJbZjUfkngsqghbCY; // 0x68
	private UpiYsJeWuGTGsEAZZHaQdjYrgzwr fcRWejTAwsZXlvDegqTUWzVmVcyD; // 0x70
	private DeviceLocalizationInfo ebTMLxoLwWDnKILCIJrzNFzktllj; // 0x78
	private int lhWaVPChlXfgMFgLlRTKGxoUGNtgA; // 0x80
	private List<ControllerElementIdentifier.aRUkUFLmXrSIgIEEqHVEYMVhKmJv> IrtECkKSkUUqgOqayJDfimRHFJviB; // 0x88
	private ControllerType mssadAAejyKGHIfognJBtXtNdiiIB; // 0x90
	private static ControllerElementIdentifier lLqVjRofhDACGAdFEJnsHOosxPfZ; // 0x0

	// Properties
	public int id { get; }
	public string name { get; set; }
	public string positiveName { get; set; }
	public string negativeName { get; set; }
	public ControllerElementType elementType { get; }
	public CompoundControllerElementType compoundElementType { get; }
	public object glyph { get; }
	public object positiveGlyph { get; }
	public object negativeGlyph { get; }
	private string finalGlyphKey { get; }
	private string finalPositiveGlyphKey { get; }
	private string finalNegativeGlyphKey { get; }
	internal string nonLocalizedName { get; set; }
	internal string nonLocalizedPositiveName { get; set; }
	internal string nonLocalizedNegativeName { get; set; }
	public string key { get; }
	public string positiveKey { get; }
	public string negativeKey { get; }
	internal bool isCompoundElement { get; }
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.nonLocalizedName { get; }
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.nonLocalizedPositiveName { get; }
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.nonLocalizedNegativeName { get; }
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.isNonLocalizedPositiveNameAutoGenerated { get; }
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.isNonLocalizedNegativeNameAutoGenerated { get; }
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.isPositiveKeyAutoGenerated { get; }
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.isNegativeKeyAutoGenerated { get; }
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.key { get; }
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.positiveKey { get; }
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.negativeKey { get; }
	private DeviceLocalizationInfo Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.deviceLocalizationInfo { get; }
	private object Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.elementType { get; }
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.useEditorElementTypeOverride { get; }
	private ControllerElementType Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.editorElementTypeOverride { get; }
	internal static ControllerElementIdentifier BlankReadOnly { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.keyCategory { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.scriptingName { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.nonLocalizedDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.nonLocalizedPositiveDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.nonLocalizedNegativeDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.INameLocalizerSource.key { get; }
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.positiveKey { get; set; }
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.negativeKey { get; set; }
	private int Rewired.Internal.Localization.INameLocalizerSource.autoGeneratedValueFlags { get; set; }
	private string Rewired.Internal.Glyphs.IGlyphKeySource.keyCategory { get; }
	private string Rewired.Internal.Glyphs.IGlyphKeySource.key { get; }
	private int Rewired.Internal.Glyphs.IGlyphKeySource.autoGeneratedValueFlags { get; set; }
	private string Rewired.Internal.Glyphs.IAxisGlyphKeySource.positiveKey { get; set; }
	private string Rewired.Internal.Glyphs.IAxisGlyphKeySource.negativeKey { get; set; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 4
	public int get_id() { }

	// RVA: 0x1A6C800 Offset: 0x1A6BA00 VA: 0x181A6C800 Slot: 5
	public string get_name() { }

	// RVA: 0x1A6CCE0 Offset: 0x1A6BEE0 VA: 0x181A6CCE0
	internal void set_name(string value) { }

	// RVA: 0x1A6CB40 Offset: 0x1A6BD40 VA: 0x181A6CB40 Slot: 6
	public string get_positiveName() { }

	// RVA: 0x1A6CEF0 Offset: 0x1A6C0F0 VA: 0x181A6CEF0
	internal void set_positiveName(string value) { }

	// RVA: 0x1A6C9A0 Offset: 0x1A6BBA0 VA: 0x181A6C9A0 Slot: 7
	public string get_negativeName() { }

	// RVA: 0x1A6CDF0 Offset: 0x1A6BFF0 VA: 0x181A6CDF0
	internal void set_negativeName(string value) { }

	// RVA: 0x1A6AF50 Offset: 0x1A6A150 VA: 0x181A6AF50
	internal string GetCompoundElementSpecialName(int index) { }

	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0
	public ControllerElementType get_elementType() { }

	// RVA: 0x547AA0 Offset: 0x546CA0 VA: 0x180547AA0
	public CompoundControllerElementType get_compoundElementType() { }

	// RVA: 0x1A6C720 Offset: 0x1A6B920 VA: 0x181A6C720
	public object get_glyph() { }

	// RVA: 0x1A6CA70 Offset: 0x1A6BC70 VA: 0x181A6CA70
	public object get_positiveGlyph() { }

	// RVA: 0x1A6C8D0 Offset: 0x1A6BAD0 VA: 0x181A6C8D0
	public object get_negativeGlyph() { }

	// RVA: 0x1A6CFF0 Offset: 0x1A6C1F0 VA: 0x181A6CFF0
	private string wpsGaPrmnWutKXpOPeInjPdZzFEV() { }

	// RVA: 0x1A6B700 Offset: 0x1A6A900 VA: 0x181A6B700
	private string QxahyjKrSWpkJTxWSosySQZDBdlx() { }

	// RVA: 0x1A6CC10 Offset: 0x1A6BE10 VA: 0x181A6CC10
	private string rLCMlwHdygDpISOGMwuRSnWlbCBc() { }

	// RVA: 0x1A6AE70 Offset: 0x1A6A070 VA: 0x181A6AE70
	internal object GetCompoundElementSpecialGlyph(int index) { }

	// RVA: 0x1A6AD90 Offset: 0x1A69F90 VA: 0x181A6AD90
	internal string GetCompoundElementSpecialFinalGlyphKey(int index) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal string get_nonLocalizedName() { }

	// RVA: 0x1A6CCE0 Offset: 0x1A6BEE0 VA: 0x181A6CCE0
	internal void set_nonLocalizedName(string value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal string get_nonLocalizedPositiveName() { }

	// RVA: 0x1A6CEF0 Offset: 0x1A6C0F0 VA: 0x181A6CEF0
	internal void set_nonLocalizedPositiveName(string value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal string get_nonLocalizedNegativeName() { }

	// RVA: 0x1A6CDF0 Offset: 0x1A6BFF0 VA: 0x181A6CDF0
	internal void set_nonLocalizedNegativeName(string value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_key() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_positiveKey() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public string get_negativeKey() { }

	// RVA: 0x1A6C7F0 Offset: 0x1A6B9F0 VA: 0x181A6C7F0
	internal bool get_isCompoundElement() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_nonLocalizedName() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 9
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_nonLocalizedPositiveName() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 10
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_nonLocalizedNegativeName() { }

	// RVA: 0x1A6B860 Offset: 0x1A6AA60 VA: 0x181A6B860 Slot: 11
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.GetSpecialElementNonLocalizedName(int index) { }

	// RVA: 0x1A6B960 Offset: 0x1A6AB60 VA: 0x181A6B960 Slot: 16
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_isNonLocalizedPositiveNameAutoGenerated() { }

	// RVA: 0x1A6B950 Offset: 0x1A6AB50 VA: 0x181A6B950 Slot: 17
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_isNonLocalizedNegativeNameAutoGenerated() { }

	// RVA: 0x1A6B970 Offset: 0x1A6AB70 VA: 0x181A6B970 Slot: 18
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_isPositiveKeyAutoGenerated() { }

	// RVA: 0x1A6B940 Offset: 0x1A6AB40 VA: 0x181A6B940 Slot: 19
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_isNegativeKeyAutoGenerated() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 12
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_key() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 13
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_positiveKey() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 14
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_negativeKey() { }

	// RVA: 0x1A6B7D0 Offset: 0x1A6A9D0 VA: 0x181A6B7D0 Slot: 15
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.GetSpecialElementKey(int index) { }

	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0 Slot: 20
	private DeviceLocalizationInfo Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_deviceLocalizationInfo() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1A6C2F0 Offset: 0x1A6B4F0 VA: 0x181A6C2F0
	public void .ctor(ControllerElementIdentifier ) { }

	// RVA: 0x1A6C230 Offset: 0x1A6B430 VA: 0x181A6C230
	internal void .ctor(ControllerElementIdentifier.vrCPviWPNzNACqMBjKpVQfDwMNSs ) { }

	[Obsolete("Used by plugins for mouse controllers. Left for plugin compatibility. Do not use.", False)]
	// RVA: 0x1A6C4F0 Offset: 0x1A6B6F0 VA: 0x181A6C4F0
	internal void .ctor(int , string , string , string , ControllerElementType , CompoundControllerElementType , bool ) { }

	[Obsolete("Used by UnifiedKeyboardSource. Left for plugin compatibility. Do not use.", False)]
	// RVA: 0x1A6C030 Offset: 0x1A6B230 VA: 0x181A6C030
	internal void .ctor(int , string , string , string , ControllerElementType , bool ) { }

	// RVA: 0x1A6C200 Offset: 0x1A6B400 VA: 0x181A6C200
	internal void .ctor(ControllerElementIdentifier , bool , ControllerElementType ) { }

	// RVA: 0x1A6AA80 Offset: 0x1A69C80 VA: 0x181A6AA80
	public ControllerElementIdentifier Clone() { }

	// RVA: 0x1A6B040 Offset: 0x1A6A240 VA: 0x181A6B040
	public string GetDisplayName(ControllerElementType actualElementType, AxisRange axisRange) { }

	// RVA: 0x1A6B270 Offset: 0x1A6A470 VA: 0x181A6B270
	public string GetDisplayName(AxisRange axisRange) { }

	// RVA: 0x1A6B4D0 Offset: 0x1A6A6D0 VA: 0x181A6B4D0
	public object GetGlyph(ControllerElementType actualElementType, AxisRange axisRange) { }

	// RVA: 0x1A6B4C0 Offset: 0x1A6A6C0 VA: 0x181A6B4C0
	public object GetGlyph(AxisRange axisRange) { }

	// RVA: 0x1A6B290 Offset: 0x1A6A490 VA: 0x181A6B290
	public string GetFinalGlyphKey(ControllerElementType actualElementType, AxisRange axisRange) { }

	// RVA: 0x1A6B280 Offset: 0x1A6A480 VA: 0x181A6B280
	public string GetFinalGlyphKey(AxisRange axisRange) { }

	// RVA: 0x1A6B8F0 Offset: 0x1A6AAF0 VA: 0x181A6B8F0 Slot: 21
	private object Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_elementType() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 22
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_useEditorElementTypeOverride() { }

	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0 Slot: 23
	private ControllerElementType Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_editorElementTypeOverride() { }

	// RVA: 0x1A6BFC0 Offset: 0x1A6B1C0 VA: 0x181A6BFC0
	private void ZnLVqZcfqnJfPjziMegSqypIIFLC() { }

	// RVA: 0x1A6AAE0 Offset: 0x1A69CE0 VA: 0x181A6AAE0
	internal void FinishRuntimeSetup(DeviceLocalizationInfo deviceLocalizationInfo, ControllerType controllerType) { }

	// RVA: 0x1A6C690 Offset: 0x1A6B890 VA: 0x181A6C690
	internal static ControllerElementIdentifier get_BlankReadOnly() { }

	// RVA: 0x1A6BF70 Offset: 0x1A6B170 VA: 0x181A6BF70
	internal static void ToElementNameLocalizerTypes(ControllerElementType type, CompoundControllerElementType compoundType, out VDxsnTTWRPNGvDWpsIVjTbzLcwODA.KOPhTncSXKVblkSAwyPuVAaadfIq resultElementType, out VDxsnTTWRPNGvDWpsIVjTbzLcwODA.ZMgvVXnvZtDzXKxYOqfUhbmAGhOl resultCompoundElementType) { }

	// RVA: 0x1A6BC90 Offset: 0x1A6AE90 VA: 0x181A6BC90 Slot: 24
	private string Rewired.Internal.Localization.INameLocalizerSource.get_keyCategory() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 25
	private string Rewired.Internal.Localization.INameLocalizerSource.get_scriptingName() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 26
	private string Rewired.Internal.Localization.INameLocalizerSource.get_nonLocalizedDescriptiveName() { }

	// RVA: 0x1A6BCC0 Offset: 0x1A6AEC0 VA: 0x181A6BCC0 Slot: 27
	private void Rewired.Internal.Localization.INameLocalizerSource.set_nonLocalizedDescriptiveName(string value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 31
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.get_nonLocalizedPositiveDescriptiveName() { }

	// RVA: 0x1A6BC20 Offset: 0x1A6AE20 VA: 0x181A6BC20 Slot: 32
	private void Rewired.Internal.Localization.IAxisNameLocalizerSource.set_nonLocalizedPositiveDescriptiveName(string value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 33
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.get_nonLocalizedNegativeDescriptiveName() { }

	// RVA: 0x1A6BBB0 Offset: 0x1A6ADB0 VA: 0x181A6BBB0 Slot: 34
	private void Rewired.Internal.Localization.IAxisNameLocalizerSource.set_nonLocalizedNegativeDescriptiveName(string value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 28
	private string Rewired.Internal.Localization.INameLocalizerSource.get_key() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 35
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.get_positiveKey() { }

	// RVA: 0x1A6B9F0 Offset: 0x1A6ABF0 VA: 0x181A6B9F0 Slot: 36
	private void Rewired.Internal.Localization.IAxisNameLocalizerSource.set_positiveKey(string value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 37
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.get_negativeKey() { }

	// RVA: 0x1A6B980 Offset: 0x1A6AB80 VA: 0x181A6B980 Slot: 38
	private void Rewired.Internal.Localization.IAxisNameLocalizerSource.set_negativeKey(string value) { }

	// RVA: 0x1A6BA60 Offset: 0x1A6AC60 VA: 0x181A6BA60 Slot: 29
	private int Rewired.Internal.Localization.INameLocalizerSource.get_autoGeneratedValueFlags() { }

	// RVA: 0x1A6BA80 Offset: 0x1A6AC80 VA: 0x181A6BA80 Slot: 30
	private void Rewired.Internal.Localization.INameLocalizerSource.set_autoGeneratedValueFlags(int value) { }

	// RVA: 0x1A6BDC0 Offset: 0x1A6AFC0 VA: 0x181A6BDC0 Slot: 39
	private string Rewired.Internal.Localization.ISpecialElementNameLocalizerSource.GetSpecialElementNonLocalizedDescriptiveName(int index) { }

	// RVA: 0x1A6BEE0 Offset: 0x1A6B0E0 VA: 0x181A6BEE0 Slot: 40
	private void Rewired.Internal.Localization.ISpecialElementNameLocalizerSource.SetSpecialElementNonLocalizedDescriptiveName(int index, string value) { }

	// RVA: 0x1A6BD30 Offset: 0x1A6AF30 VA: 0x181A6BD30 Slot: 41
	private string Rewired.Internal.Localization.ISpecialElementNameLocalizerSource.GetSpecialElementKey(int index) { }

	// RVA: 0x1A6BE50 Offset: 0x1A6B050 VA: 0x181A6BE50 Slot: 42
	private void Rewired.Internal.Localization.ISpecialElementNameLocalizerSource.SetSpecialElementKey(int index, string value) { }

	// RVA: 0x1A6BA70 Offset: 0x1A6AC70 VA: 0x181A6BA70 Slot: 43
	private string Rewired.Internal.Glyphs.IGlyphKeySource.get_keyCategory() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 44
	private string Rewired.Internal.Glyphs.IGlyphKeySource.get_key() { }

	// RVA: 0x1A6BA60 Offset: 0x1A6AC60 VA: 0x181A6BA60 Slot: 45
	private int Rewired.Internal.Glyphs.IGlyphKeySource.get_autoGeneratedValueFlags() { }

	// RVA: 0x1A6BA80 Offset: 0x1A6AC80 VA: 0x181A6BA80 Slot: 46
	private void Rewired.Internal.Glyphs.IGlyphKeySource.set_autoGeneratedValueFlags(int value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 47
	private string Rewired.Internal.Glyphs.IAxisGlyphKeySource.get_positiveKey() { }

	// RVA: 0x1A6B9F0 Offset: 0x1A6ABF0 VA: 0x181A6B9F0 Slot: 48
	private void Rewired.Internal.Glyphs.IAxisGlyphKeySource.set_positiveKey(string value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 49
	private string Rewired.Internal.Glyphs.IAxisGlyphKeySource.get_negativeKey() { }

	// RVA: 0x1A6B980 Offset: 0x1A6AB80 VA: 0x181A6B980 Slot: 50
	private void Rewired.Internal.Glyphs.IAxisGlyphKeySource.set_negativeKey(string value) { }

	// RVA: 0x1A6BA90 Offset: 0x1A6AC90 VA: 0x181A6BA90 Slot: 51
	private string Rewired.Internal.Glyphs.ISpecialElementGlyphKeySource.GetSpecialElementKey(int index) { }

	// RVA: 0x1A6BB20 Offset: 0x1A6AD20 VA: 0x181A6BB20 Slot: 52
	private void Rewired.Internal.Glyphs.ISpecialElementGlyphKeySource.SetSpecialElementKey(int index, string value) { }
}

// Namespace: 
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal class ControllerTemplateElementIdentifier.zOFYzCOgmDyuwxCoGDnienOrkPrxA // TypeDefIndex: 6961
{
	// Fields
	public int id; // 0x10
	public string name; // 0x18
	public string positiveName; // 0x20
	public string negativeName; // 0x28
	public string key; // 0x30
	public string positiveKey; // 0x38
	public string negativeKey; // 0x40
	public ControllerTemplateElementType elementType; // 0x48

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ControllerTemplateElementIdentifier.YwwcLagqEnOPDPPquMlYHCFJwosE.InHFmlUKIYuwFEyupJUyUgvSjJsP // TypeDefIndex: 6962
{
	// Fields
	public static readonly ControllerTemplateElementIdentifier.YwwcLagqEnOPDPPquMlYHCFJwosE.InHFmlUKIYuwFEyupJUyUgvSjJsP <>9; // 0x0
	public static Func<ControllerTemplateElementIdentifier, ControllerTemplateElementIdentifier, bool> <>9__4_0; // 0x8

	// Methods

	// RVA: 0x1A804F0 Offset: 0x1A7F6F0 VA: 0x181A804F0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1A80550 Offset: 0x1A7F750 VA: 0x181A80550
	internal bool hbcorxGebSGWVAXdCpuOmiBRYN(ControllerTemplateElementIdentifier , ControllerTemplateElementIdentifier ) { }
}

// Namespace: 
internal sealed class ControllerTemplateElementIdentifier.YwwcLagqEnOPDPPquMlYHCFJwosE // TypeDefIndex: 6963
{
	// Fields
	private static ControllerTemplateElementIdentifier.YwwcLagqEnOPDPPquMlYHCFJwosE UVLGozxGAPPfmLecELzdCiykSygT; // 0x0
	private readonly RBTbtfxxywGQyDGTOxgBUjFHeEtDA<ControllerTemplateElementIdentifier> QeVLqlLfKsiVaedHloOvPDTgmMxV; // 0x10

	// Properties
	private static ControllerTemplateElementIdentifier.YwwcLagqEnOPDPPquMlYHCFJwosE mqkLfedmeRcvYyKvtVwYnkyMiHag { get; }

	// Methods

	// RVA: 0x1A872B0 Offset: 0x1A864B0 VA: 0x181A872B0
	private static ControllerTemplateElementIdentifier.YwwcLagqEnOPDPPquMlYHCFJwosE dUqVkBxkvhUZAFBuybiKFczmYXLb() { }

	// RVA: 0x1A870D0 Offset: 0x1A862D0 VA: 0x181A870D0
	private void .ctor() { }

	// RVA: 0x1A87200 Offset: 0x1A86400 VA: 0x181A87200
	private void cneJLUqoVILjQOkyKwaOlYsbtCCC() { }

	// RVA: 0x1A86F90 Offset: 0x1A86190 VA: 0x181A86F90
	private void KPSfUAGoTAczUoyxgCKaOthRkGmo() { }

	// RVA: 0x1A87050 Offset: 0x1A86250 VA: 0x181A87050
	public static ControllerTemplateElementIdentifier PjrvWYysdnhrOONinazkfAfeuaqX(DeviceLocalizationInfo , ControllerTemplateElementIdentifier ) { }

	// RVA: 0x1A86EF0 Offset: 0x1A860F0 VA: 0x181A86EF0
	public static bool BBzDvtkJMbhpEdyHcGDPFStcUenSc(DeviceLocalizationInfo , ControllerTemplateElementIdentifier , out ControllerTemplateElementIdentifier ) { }

	// RVA: 0x1A87500 Offset: 0x1A86700 VA: 0x181A87500
	public static void xXDAAgkpHyujExYwkSGAdhBokBcFb(DeviceLocalizationInfo , ControllerTemplateElementIdentifier ) { }
}

// Namespace: 
private class ControllerTemplateElementIdentifier.YMCXgyCpoTVQsFWahruehINXPExL // TypeDefIndex: 6964
{
	// Fields
	[SerializeField]
	private string sKEfXRhGnVSsmWsCqaKxYnjRjSNb; // 0x10
	[SerializeField]
	private string LMzQCtpoynfYEpBZHVCnvIXoALpIA; // 0x18

	// Properties
	public string OBqnLJQoPJGIQnqhihiXTClNELYH { get; set; }
	public string aCRYYTbbujWDguafSiRCsFIGtvKp { get; set; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string drsVLKNsGZvRlpOFRpNJQUExHJls() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void IQWWRHlTEbfsugQDrnuadMGeayzfA(string ) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string PCjITsTXyHXjpjtBCJYiIxgYqmkA() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void jCFVgVBGLNUCoaKAgHSqMXrAShKS(string ) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1A86EB0 Offset: 0x1A860B0 VA: 0x181A86EB0
	public void .ctor(ControllerTemplateElementIdentifier.YMCXgyCpoTVQsFWahruehINXPExL ) { }
}

// Namespace: Rewired
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
[Serializable]
public class ControllerTemplateElementIdentifier : IControllerElementIdentifierCommon_Internal, IControllerTemplateElementIdentifier, ftUiUAiTGSDgAJCvnFpXJSUgtERQ, zrLlTBFrsLrsiFBlwbgZFmRqZSoTA, nXthwLMIItnYHznlYeVDMBlZcram, XQOjApDcMWsPUSvljHPeHPNlsqaf, pnvftOaMtZZJUzhBeNdWAoRZoPnw, yPgObMfdVeyidpXQsRmkzbdbGSYW // TypeDefIndex: 6965
{
	// Fields
	private const string gWsanYkjIRiDNxQaCqeJDOlsLFefb = "controller/template";
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private int _id; // 0x10
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private string _name; // 0x18
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private string _positiveName; // 0x20
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private string _negativeName; // 0x28
	[SerializeField]
	[CustomObfuscation(rename = False)]
	public string _key; // 0x30
	[SerializeField]
	[CustomObfuscation(rename = False)]
	public string _positiveKey; // 0x38
	[SerializeField]
	[CustomObfuscation(rename = False)]
	public string _negativeKey; // 0x40
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private ControllerTemplateElementType _elementType; // 0x48
	private rGRdrxTKDosARhftgPYJzWggGTSV AkwnqXXHArVvqcvmLTucKpAEeKMDA; // 0x50
	private UkmCHYHZTndoGrakMrsDHlZDdySdA xFKLAuZXitCebffHCEaOcRlBhvpDA; // 0x58
	private OtqiuewQtwfnnJcVyCaygEVrnxnm pyyUuDUlQtnAJbZjUfkngsqghbCY; // 0x60
	private UpiYsJeWuGTGsEAZZHaQdjYrgzwr fcRWejTAwsZXlvDegqTUWzVmVcyD; // 0x68
	private DeviceLocalizationInfo ebTMLxoLwWDnKILCIJrzNFzktllj; // 0x70
	private int lhWaVPChlXfgMFgLlRTKGxoUGNtgA; // 0x78
	private List<ControllerTemplateElementIdentifier.YMCXgyCpoTVQsFWahruehINXPExL> IrtECkKSkUUqgOqayJDfimRHFJviB; // 0x80

	// Properties
	public int id { get; }
	public string name { get; set; }
	public string positiveName { get; set; }
	public string negativeName { get; set; }
	public ControllerTemplateElementType elementType { get; }
	internal virtual bool useEditorElementTypeOverride { get; }
	internal virtual ControllerElementType editorElementTypeOverride { get; }
	public object glyph { get; }
	public object positiveGlyph { get; }
	public object negativeGlyph { get; }
	private string finalGlyphKey { get; }
	private string finalPositiveGlyphKey { get; }
	private string finalNegativeGlyphKey { get; }
	internal string nonLocalizedName { get; set; }
	internal string nonLocalizedPositiveName { get; set; }
	internal string nonLocalizedNegativeName { get; set; }
	public string key { get; }
	public string positiveKey { get; }
	public string negativeKey { get; }
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.nonLocalizedName { get; }
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.nonLocalizedPositiveName { get; }
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.nonLocalizedNegativeName { get; }
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.isNonLocalizedPositiveNameAutoGenerated { get; }
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.isNonLocalizedNegativeNameAutoGenerated { get; }
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.isPositiveKeyAutoGenerated { get; }
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.isNegativeKeyAutoGenerated { get; }
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.key { get; }
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.positiveKey { get; }
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.negativeKey { get; }
	private DeviceLocalizationInfo Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.deviceLocalizationInfo { get; }
	private object Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.elementType { get; }
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.useEditorElementTypeOverride { get; }
	private ControllerElementType Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.editorElementTypeOverride { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.keyCategory { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.scriptingName { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.nonLocalizedDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.nonLocalizedPositiveDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.nonLocalizedNegativeDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.INameLocalizerSource.key { get; }
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.positiveKey { get; set; }
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.negativeKey { get; set; }
	private int Rewired.Internal.Localization.INameLocalizerSource.autoGeneratedValueFlags { get; set; }
	private string Rewired.Internal.Glyphs.IGlyphKeySource.keyCategory { get; }
	private string Rewired.Internal.Glyphs.IGlyphKeySource.key { get; }
	private int Rewired.Internal.Glyphs.IGlyphKeySource.autoGeneratedValueFlags { get; set; }
	private string Rewired.Internal.Glyphs.IAxisGlyphKeySource.positiveKey { get; set; }
	private string Rewired.Internal.Glyphs.IAxisGlyphKeySource.negativeKey { get; set; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90 Slot: 4
	public int get_id() { }

	// RVA: 0x1A7F990 Offset: 0x1A7EB90 VA: 0x181A7F990 Slot: 5
	public string get_name() { }

	// RVA: 0x1A7FE70 Offset: 0x1A7F070 VA: 0x181A7FE70
	internal void set_name(string value) { }

	// RVA: 0x1A7FCD0 Offset: 0x1A7EED0 VA: 0x181A7FCD0 Slot: 6
	public string get_positiveName() { }

	// RVA: 0x1A7FFE0 Offset: 0x1A7F1E0 VA: 0x181A7FFE0
	internal void set_positiveName(string value) { }

	// RVA: 0x1A7FB30 Offset: 0x1A7ED30 VA: 0x181A7FB30 Slot: 7
	public string get_negativeName() { }

	// RVA: 0x1A7FF30 Offset: 0x1A7F130 VA: 0x181A7FF30
	internal void set_negativeName(string value) { }

	// RVA: 0x1A7E460 Offset: 0x1A7D660 VA: 0x181A7E460
	internal string GetCompoundElementSpecialName(int index) { }

	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0 Slot: 24
	public ControllerTemplateElementType get_elementType() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 54
	internal virtual bool get_useEditorElementTypeOverride() { }

	// RVA: 0x1A7F880 Offset: 0x1A7EA80 VA: 0x181A7F880 Slot: 55
	internal virtual ControllerElementType get_editorElementTypeOverride() { }

	// RVA: 0x1A7F8C0 Offset: 0x1A7EAC0 VA: 0x181A7F8C0
	public object get_glyph() { }

	// RVA: 0x1A7FC00 Offset: 0x1A7EE00 VA: 0x181A7FC00
	public object get_positiveGlyph() { }

	// RVA: 0x1A7FA60 Offset: 0x1A7EC60 VA: 0x181A7FA60
	public object get_negativeGlyph() { }

	// RVA: 0x1A80090 Offset: 0x1A7F290 VA: 0x181A80090
	private string wpsGaPrmnWutKXpOPeInjPdZzFEV() { }

	// RVA: 0x1A7EB20 Offset: 0x1A7DD20 VA: 0x181A7EB20
	private string QxahyjKrSWpkJTxWSosySQZDBdlx() { }

	// RVA: 0x1A7FDA0 Offset: 0x1A7EFA0 VA: 0x181A7FDA0
	private string rLCMlwHdygDpISOGMwuRSnWlbCBc() { }

	// RVA: 0x1A7E380 Offset: 0x1A7D580 VA: 0x181A7E380
	internal object GetCompoundElementSpecialGlyph(int index) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal string get_nonLocalizedName() { }

	// RVA: 0x1A7FE70 Offset: 0x1A7F070 VA: 0x181A7FE70
	internal void set_nonLocalizedName(string value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal string get_nonLocalizedPositiveName() { }

	// RVA: 0x1A7FFE0 Offset: 0x1A7F1E0 VA: 0x181A7FFE0
	internal void set_nonLocalizedPositiveName(string value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal string get_nonLocalizedNegativeName() { }

	// RVA: 0x1A7FF30 Offset: 0x1A7F130 VA: 0x181A7FF30
	internal void set_nonLocalizedNegativeName(string value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_key() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_positiveKey() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public string get_negativeKey() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_nonLocalizedName() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 9
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_nonLocalizedPositiveName() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 10
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_nonLocalizedNegativeName() { }

	// RVA: 0x1A7EC80 Offset: 0x1A7DE80 VA: 0x181A7EC80 Slot: 11
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.GetSpecialElementNonLocalizedName(int index) { }

	// RVA: 0x1A7EDA0 Offset: 0x1A7DFA0 VA: 0x181A7EDA0 Slot: 16
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_isNonLocalizedPositiveNameAutoGenerated() { }

	// RVA: 0x1A7ED90 Offset: 0x1A7DF90 VA: 0x181A7ED90 Slot: 17
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_isNonLocalizedNegativeNameAutoGenerated() { }

	// RVA: 0x1A7EDB0 Offset: 0x1A7DFB0 VA: 0x181A7EDB0 Slot: 18
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_isPositiveKeyAutoGenerated() { }

	// RVA: 0x1A7ED80 Offset: 0x1A7DF80 VA: 0x181A7ED80 Slot: 19
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_isNegativeKeyAutoGenerated() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 12
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_key() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 13
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_positiveKey() { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 14
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_negativeKey() { }

	// RVA: 0x1A7EBF0 Offset: 0x1A7DDF0 VA: 0x181A7EBF0 Slot: 15
	private string Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.GetSpecialElementKey(int index) { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980 Slot: 20
	private DeviceLocalizationInfo Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_deviceLocalizationInfo() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1A7F660 Offset: 0x1A7E860 VA: 0x181A7F660
	public void .ctor(ControllerTemplateElementIdentifier ) { }

	// RVA: 0x1A7F5B0 Offset: 0x1A7E7B0 VA: 0x181A7F5B0
	internal void .ctor(ControllerTemplateElementIdentifier.zOFYzCOgmDyuwxCoGDnienOrkPrxA ) { }

	// RVA: 0x1A7F850 Offset: 0x1A7EA50 VA: 0x181A7F850
	internal void .ctor(ControllerTemplateElementIdentifier , ControllerTemplateElementType , bool ) { }

	// RVA: 0x1A7E060 Offset: 0x1A7D260 VA: 0x181A7E060 Slot: 56
	public virtual ControllerTemplateElementIdentifier Clone() { }

	// RVA: 0x1A7E550 Offset: 0x1A7D750 VA: 0x181A7E550
	public string GetDisplayName(AxisRange axisRange) { }

	// RVA: 0x1A7E930 Offset: 0x1A7DB30 VA: 0x181A7E930
	public object GetGlyph(AxisRange axisRange) { }

	// RVA: 0x1A7E740 Offset: 0x1A7D940 VA: 0x181A7E740
	public string GetFinalGlyphKey(AxisRange axisRange) { }

	// RVA: 0x1A7F1A0 Offset: 0x1A7E3A0 VA: 0x181A7F1A0
	internal ControllerElementIdentifier ToControllerElementIdentifier(IHardwareControllerMap_Internal hardwareControllerMap) { }

	// RVA: 0x1A7ED30 Offset: 0x1A7DF30 VA: 0x181A7ED30 Slot: 21
	private object Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_elementType() { }

	// RVA: 0x1A7EDC0 Offset: 0x1A7DFC0 VA: 0x181A7EDC0 Slot: 22
	private bool Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_useEditorElementTypeOverride() { }

	// RVA: 0x1A7ED10 Offset: 0x1A7DF10 VA: 0x181A7ED10 Slot: 23
	private ControllerElementType Rewired.Interfaces.IControllerElementIdentifierCommon_Internal.get_editorElementTypeOverride() { }

	// RVA: 0x1A7E0C0 Offset: 0x1A7D2C0 VA: 0x181A7E0C0
	internal void FinishRuntimeSetup(DeviceLocalizationInfo deviceLocalizationInfo) { }

	// RVA: 0x1A7EF30 Offset: 0x1A7E130 VA: 0x181A7EF30 Slot: 25
	private string Rewired.Internal.Localization.INameLocalizerSource.get_keyCategory() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 26
	private string Rewired.Internal.Localization.INameLocalizerSource.get_scriptingName() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 27
	private string Rewired.Internal.Localization.INameLocalizerSource.get_nonLocalizedDescriptiveName() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70 Slot: 28
	private void Rewired.Internal.Localization.INameLocalizerSource.set_nonLocalizedDescriptiveName(string value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 32
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.get_nonLocalizedPositiveDescriptiveName() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0 Slot: 33
	private void Rewired.Internal.Localization.IAxisNameLocalizerSource.set_nonLocalizedPositiveDescriptiveName(string value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 34
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.get_nonLocalizedNegativeDescriptiveName() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650 Slot: 35
	private void Rewired.Internal.Localization.IAxisNameLocalizerSource.set_nonLocalizedNegativeDescriptiveName(string value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 29
	private string Rewired.Internal.Localization.INameLocalizerSource.get_key() { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 36
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.get_positiveKey() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50 Slot: 37
	private void Rewired.Internal.Localization.IAxisNameLocalizerSource.set_positiveKey(string value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 38
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.get_negativeKey() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820 Slot: 39
	private void Rewired.Internal.Localization.IAxisNameLocalizerSource.set_negativeKey(string value) { }

	// RVA: 0x4ED990 Offset: 0x4ECB90 VA: 0x1804ED990 Slot: 30
	private int Rewired.Internal.Localization.INameLocalizerSource.get_autoGeneratedValueFlags() { }

	// RVA: 0x4EDD40 Offset: 0x4ECF40 VA: 0x1804EDD40 Slot: 31
	private void Rewired.Internal.Localization.INameLocalizerSource.set_autoGeneratedValueFlags(int value) { }

	// RVA: 0x1A7EFF0 Offset: 0x1A7E1F0 VA: 0x181A7EFF0 Slot: 40
	private string Rewired.Internal.Localization.ISpecialElementNameLocalizerSource.GetSpecialElementNonLocalizedDescriptiveName(int index) { }

	// RVA: 0x1A7F110 Offset: 0x1A7E310 VA: 0x181A7F110 Slot: 41
	private void Rewired.Internal.Localization.ISpecialElementNameLocalizerSource.SetSpecialElementNonLocalizedDescriptiveName(int index, string value) { }

	// RVA: 0x1A7EF60 Offset: 0x1A7E160 VA: 0x181A7EF60 Slot: 42
	private string Rewired.Internal.Localization.ISpecialElementNameLocalizerSource.GetSpecialElementKey(int index) { }

	// RVA: 0x1A7F080 Offset: 0x1A7E280 VA: 0x181A7F080 Slot: 43
	private void Rewired.Internal.Localization.ISpecialElementNameLocalizerSource.SetSpecialElementKey(int index, string value) { }

	// RVA: 0x1A7EDE0 Offset: 0x1A7DFE0 VA: 0x181A7EDE0 Slot: 44
	private string Rewired.Internal.Glyphs.IGlyphKeySource.get_keyCategory() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 45
	private string Rewired.Internal.Glyphs.IGlyphKeySource.get_key() { }

	// RVA: 0x4ED990 Offset: 0x4ECB90 VA: 0x1804ED990 Slot: 46
	private int Rewired.Internal.Glyphs.IGlyphKeySource.get_autoGeneratedValueFlags() { }

	// RVA: 0x4EDD40 Offset: 0x4ECF40 VA: 0x1804EDD40 Slot: 47
	private void Rewired.Internal.Glyphs.IGlyphKeySource.set_autoGeneratedValueFlags(int value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 48
	private string Rewired.Internal.Glyphs.IAxisGlyphKeySource.get_positiveKey() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50 Slot: 49
	private void Rewired.Internal.Glyphs.IAxisGlyphKeySource.set_positiveKey(string value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 50
	private string Rewired.Internal.Glyphs.IAxisGlyphKeySource.get_negativeKey() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820 Slot: 51
	private void Rewired.Internal.Glyphs.IAxisGlyphKeySource.set_negativeKey(string value) { }

	// RVA: 0x1A7EE10 Offset: 0x1A7E010 VA: 0x181A7EE10 Slot: 52
	private string Rewired.Internal.Glyphs.ISpecialElementGlyphKeySource.GetSpecialElementKey(int index) { }

	// RVA: 0x1A7EEA0 Offset: 0x1A7E0A0 VA: 0x181A7EEA0 Slot: 53
	private void Rewired.Internal.Glyphs.ISpecialElementGlyphKeySource.SetSpecialElementKey(int index, string value) { }

	// RVA: 0x1A80160 Offset: 0x1A7F360 VA: 0x181A80160
	private static void yeAexYIGCDorBhRBiyHiUYyKoCBV(ControllerTemplateElementType , out VDxsnTTWRPNGvDWpsIVjTbzLcwODA.KOPhTncSXKVblkSAwyPuVAaadfIq , out VDxsnTTWRPNGvDWpsIVjTbzLcwODA.ZMgvVXnvZtDzXKxYOqfUhbmAGhOl ) { }
}

// Namespace: 
[Preserve]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Serializable]
public sealed class ControllerMapEnabler.Rule : IDeepCloneable // TypeDefIndex: 6966
{
	// Fields
	[Serialize(Name = "tag")]
	[SerializeField]
	private string _tag; // 0x10
	[SerializeField]
	[Serialize(Name = "enable")]
	private bool _enable; // 0x18
	[SerializeField]
	[Serialize(Name = "categoryIds")]
	private int[] _categoryIds; // 0x20
	[SerializeField]
	[Serialize(Name = "layoutIds")]
	private int[] _layoutIds; // 0x28
	[SerializeField]
	[Serialize(Name = "controllerSetSelector")]
	private ControllerSetSelector _controllerSetSelector; // 0x30
	private string[] _preInitCategoryNames; // 0x38
	private string[] _preInitLayoutNames; // 0x40

	// Properties
	internal bool appliesToAllLayouts { get; }
	public string tag { get; set; }
	public bool enable { get; set; }
	public ControllerSetSelector controllerSetSelector { get; set; }
	public int[] categoryIds { get; set; }
	public int[] layoutIds { get; set; }
	public int categoryId { get; set; }
	public int layoutId { get; set; }
	public string[] categoryNames { get; set; }
	public string[] layoutNames { get; set; }
	public string categoryName { get; set; }
	public string layoutName { get; set; }
	internal bool isValid { get; }

	// Methods

	// RVA: 0x1A845B0 Offset: 0x1A837B0 VA: 0x181A845B0
	public void .ctor() { }

	// RVA: 0x1A841F0 Offset: 0x1A833F0 VA: 0x181A841F0
	public void .ctor(ControllerMapEnabler.Rule ) { }

	// RVA: 0x1A84470 Offset: 0x1A83670 VA: 0x181A84470
	internal void .ctor(string , bool , int[] , int[] , ControllerSetSelector ) { }

	// RVA: 0x1A84650 Offset: 0x1A83850 VA: 0x181A84650
	internal bool get_appliesToAllLayouts() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_tag() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_tag(string value) { }

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_enable() { }

	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	public void set_enable(bool value) { }

	// RVA: 0x1A84EE0 Offset: 0x1A840E0 VA: 0x181A84EE0
	public ControllerSetSelector get_controllerSetSelector() { }

	// RVA: 0x1A864D0 Offset: 0x1A856D0 VA: 0x181A864D0
	public void set_controllerSetSelector(ControllerSetSelector value) { }

	// RVA: 0x1A84790 Offset: 0x1A83990 VA: 0x181A84790
	public int[] get_categoryIds() { }

	// RVA: 0x1A85AF0 Offset: 0x1A84CF0 VA: 0x181A85AF0
	public void set_categoryIds(int[] value) { }

	// RVA: 0x1A853E0 Offset: 0x1A845E0 VA: 0x181A853E0
	public int[] get_layoutIds() { }

	// RVA: 0x1A86700 Offset: 0x1A85900 VA: 0x181A86700
	public void set_layoutIds(int[] value) { }

	// RVA: 0x1A84670 Offset: 0x1A83870 VA: 0x181A84670
	public int get_categoryId() { }

	// RVA: 0x1A85A30 Offset: 0x1A84C30 VA: 0x181A85A30
	public void set_categoryId(int value) { }

	// RVA: 0x1A85330 Offset: 0x1A84530 VA: 0x181A85330
	public int get_layoutId() { }

	// RVA: 0x1A86640 Offset: 0x1A85840 VA: 0x181A86640
	public void set_layoutId(int value) { }

	// RVA: 0x1A84C90 Offset: 0x1A83E90 VA: 0x181A84C90
	public string[] get_categoryNames() { }

	// RVA: 0x1A86270 Offset: 0x1A85470 VA: 0x181A86270
	public void set_categoryNames(string[] value) { }

	// RVA: 0x1A85720 Offset: 0x1A84920 VA: 0x181A85720
	public string[] get_layoutNames() { }

	// RVA: 0x1A86C20 Offset: 0x1A85E20 VA: 0x181A86C20
	public void set_layoutNames(string[] value) { }

	// RVA: 0x1A84970 Offset: 0x1A83B70 VA: 0x181A84970
	public string get_categoryName() { }

	// RVA: 0x1A85DF0 Offset: 0x1A84FF0 VA: 0x181A85DF0
	public void set_categoryName(string value) { }

	// RVA: 0x1A85430 Offset: 0x1A84630 VA: 0x181A85430
	public string get_layoutName() { }

	// RVA: 0x1A869B0 Offset: 0x1A85BB0 VA: 0x181A869B0
	public void set_layoutName(string value) { }

	// RVA: 0x1A84F50 Offset: 0x1A84150 VA: 0x181A84F50
	internal bool get_isValid() { }

	// RVA: 0x1A83E00 Offset: 0x1A83000 VA: 0x181A83E00
	internal bool Matches(ControllerMap map) { }

	// RVA: 0x1A839D0 Offset: 0x1A82BD0 VA: 0x181A839D0
	private void Initialize() { }

	// RVA: 0x1A83560 Offset: 0x1A82760 VA: 0x181A83560
	private void CheckNoControllerTypeError() { }

	// RVA: 0x1A84070 Offset: 0x1A83270 VA: 0x181A84070 Slot: 4
	private object Rewired.Utils.Interfaces.IDeepCloneable.DeepClone() { }
}

// Namespace: 
[SerializationType(1)]
[Preserve]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[DefaultMember("Item")]
[Serializable]
public sealed class ControllerMapEnabler.RuleSet : IList<ControllerMapEnabler.Rule>, ICollection<ControllerMapEnabler.Rule>, IEnumerable<ControllerMapEnabler.Rule>, IEnumerable, IDeepCloneable // TypeDefIndex: 6967
{
	// Fields
	private const string className = "ControllerMapEnabler.RuleSet";
	[SerializeField]
	[Serialize(Name = "enabled")]
	private bool _enabled; // 0x10
	[SerializeField]
	[Serialize(Name = "tag")]
	private string _tag; // 0x18
	[SerializeField]
	[Serialize(Name = "rules")]
	private List<ControllerMapEnabler.Rule> _rules; // 0x20

	// Properties
	public bool enabled { get; set; }
	public string tag { get; set; }
	public List<ControllerMapEnabler.Rule> rules { get; set; }
	public ControllerMapEnabler.Rule Item { get; set; }
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<Rewired.ControllerMapEnabler.Rule>.IsReadOnly { get; }

	// Methods

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_enabled() { }

	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_enabled(bool value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_tag() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_tag(string value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public List<ControllerMapEnabler.Rule> get_rules() { }

	// RVA: 0x1A834F0 Offset: 0x1A826F0 VA: 0x181A834F0
	public void set_rules(List<ControllerMapEnabler.Rule> value) { }

	// RVA: 0x1A82E90 Offset: 0x1A82090 VA: 0x181A82E90
	internal void .ctor(bool , string , List<ControllerMapEnabler.Rule> ) { }

	// RVA: 0x1A82F80 Offset: 0x1A82180 VA: 0x181A82F80
	public void .ctor() { }

	// RVA: 0x1A82B40 Offset: 0x1A81D40 VA: 0x181A82B40
	public void .ctor(ControllerMapEnabler.RuleSet ) { }

	// RVA: 0x1A81AA0 Offset: 0x1A80CA0 VA: 0x181A81AA0
	public ControllerMapEnabler.Rule Find(Predicate<ControllerMapEnabler.Rule> predicate) { }

	// RVA: 0x1A81780 Offset: 0x1A80980 VA: 0x181A81780
	public ControllerMapEnabler.Rule FindLast(Predicate<ControllerMapEnabler.Rule> predicate) { }

	// RVA: 0x1A81310 Offset: 0x1A80510 VA: 0x181A81310
	public int FindIndex(Predicate<ControllerMapEnabler.Rule> predicate) { }

	// RVA: 0x1A814A0 Offset: 0x1A806A0 VA: 0x181A814A0
	public int FindLastIndex(Predicate<ControllerMapEnabler.Rule> predicate) { }

	// RVA: 0x1A82080 Offset: 0x1A81280 VA: 0x181A82080 Slot: 6
	public int IndexOf(ControllerMapEnabler.Rule item) { }

	// RVA: 0x1A82120 Offset: 0x1A81320 VA: 0x181A82120 Slot: 7
	public void Insert(int index, ControllerMapEnabler.Rule item) { }

	// RVA: 0x1A822A0 Offset: 0x1A814A0 VA: 0x181A822A0 Slot: 8
	public void RemoveAt(int index) { }

	// RVA: 0x1A83250 Offset: 0x1A82450 VA: 0x181A83250 Slot: 4
	public ControllerMapEnabler.Rule get_Item(int index) { }

	// RVA: 0x1A83300 Offset: 0x1A82500 VA: 0x181A83300 Slot: 5
	public void set_Item(int index, ControllerMapEnabler.Rule value) { }

	// RVA: 0x1A80A20 Offset: 0x1A7FC20 VA: 0x181A80A20 Slot: 11
	public void Add(ControllerMapEnabler.Rule item) { }

	// RVA: 0x1A80DD0 Offset: 0x1A7FFD0 VA: 0x181A80DD0 Slot: 12
	public void Clear() { }

	// RVA: 0x1A80F50 Offset: 0x1A80150 VA: 0x181A80F50 Slot: 13
	public bool Contains(ControllerMapEnabler.Rule item) { }

	// RVA: 0x1A810C0 Offset: 0x1A802C0 VA: 0x181A810C0 Slot: 14
	public void CopyTo(ControllerMapEnabler.Rule[] array, int arrayIndex) { }

	// RVA: 0x1A83060 Offset: 0x1A82260 VA: 0x181A83060 Slot: 9
	public int get_Count() { }

	// RVA: 0x1A82820 Offset: 0x1A81A20 VA: 0x181A82820 Slot: 10
	private bool System.Collections.Generic.ICollection<Rewired.ControllerMapEnabler.Rule>.get_IsReadOnly() { }

	// RVA: 0x1A82400 Offset: 0x1A81600 VA: 0x181A82400 Slot: 15
	public bool Remove(ControllerMapEnabler.Rule item) { }

	// RVA: 0x1A81F00 Offset: 0x1A81100 VA: 0x181A81F00 Slot: 16
	public IEnumerator<ControllerMapEnabler.Rule> GetEnumerator() { }

	// RVA: 0x1A82A60 Offset: 0x1A81C60 VA: 0x181A82A60 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1A826C0 Offset: 0x1A818C0 VA: 0x181A826C0 Slot: 18
	private object Rewired.Utils.Interfaces.IDeepCloneable.DeepClone() { }

	// RVA: 0x1A80C90 Offset: 0x1A7FE90 VA: 0x181A80C90
	private void CheckList() { }
}

// Namespace: 
internal class ControllerMapEnabler.CivyAOWvRKPsTDBqoIBdmQrvjYZC // TypeDefIndex: 6968
{
	// Fields
	public bool GnLsPvCJRbGYdfKiEJEsalgyYTXsA; // 0x10
	public NAbWnuemoUtDRnJvbekVDdUYjrWbb[] UQRSlzFquEOzOlvdxKrxAOpmWdyT; // 0x18

	// Methods

	// RVA: 0x153AA60 Offset: 0x1539C60 VA: 0x18153AA60
	public void .ctor(bool , NAbWnuemoUtDRnJvbekVDdUYjrWbb[] ) { }
}

// Namespace: Rewired
public sealed class ControllerMapEnabler // TypeDefIndex: 6969
{
	// Fields
	private bool AqHaORMjZGTdLoJMHbRKCeXHvJfRA; // 0x10
	private Player pTMwWYaHRMWjLJIpUEIUEZYYDbrY; // 0x18
	private ControllerMapEnabler.CivyAOWvRKPsTDBqoIBdmQrvjYZC jLHUUHAIsMjgmrRYaJQbwcAmVIyh; // 0x20
	private readonly int aplyKYJQthDqFZJRnEooAHmQTlabA; // 0x28
	private List<ControllerMapEnabler.RuleSet> kQEqJhCdYOlFQTtNdtMqIEDdhhJf; // 0x30

	// Properties
	public bool enabled { get; set; }
	public List<ControllerMapEnabler.RuleSet> ruleSets { get; set; }

	// Methods

	// RVA: 0x1A6E3C0 Offset: 0x1A6D5C0 VA: 0x181A6E3C0
	internal void .ctor(Player , ControllerMapEnabler.CivyAOWvRKPsTDBqoIBdmQrvjYZC ) { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_enabled() { }

	// RVA: 0x1A6E5A0 Offset: 0x1A6D7A0 VA: 0x181A6E5A0
	public void set_enabled(bool value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public List<ControllerMapEnabler.RuleSet> get_ruleSets() { }

	// RVA: 0x1A6E5B0 Offset: 0x1A6D7B0 VA: 0x181A6E5B0
	public void set_ruleSets(List<ControllerMapEnabler.RuleSet> value) { }

	// RVA: 0x1A6D0C0 Offset: 0x1A6C2C0 VA: 0x181A6D0C0
	public void Apply() { }

	// RVA: 0x1A6DD30 Offset: 0x1A6CF30 VA: 0x181A6DD30
	public void LoadDefaults() { }

	// RVA: 0x1A6E220 Offset: 0x1A6D420 VA: 0x181A6E220
	public string ToXmlString() { }

	// RVA: 0x1A6E080 Offset: 0x1A6D280 VA: 0x181A6E080
	public string ToJsonString() { }

	// RVA: 0x1A6DB80 Offset: 0x1A6CD80 VA: 0x181A6DB80
	public bool ImportXml(string xmlString) { }

	// RVA: 0x1A6D9D0 Offset: 0x1A6CBD0 VA: 0x181A6D9D0
	public bool ImportJson(string jsonString) { }

	// RVA: 0x1A6E520 Offset: 0x1A6D720 VA: 0x181A6E520
	private SerializedObject dDwdeldWYOLrnWiNJjDBHtCWImLzA() { }

	// RVA: 0x1A6D3C0 Offset: 0x1A6C5C0 VA: 0x181A6D3C0
	private void CHlQrZhwuPdYxNWJlUTNgThCUzEf(SerializedObject ) { }

	// RVA: 0x1A6DF80 Offset: 0x1A6D180 VA: 0x181A6DF80
	private bool MQHErEylLpkabJiPJFPMzIMISIct(SerializedObject ) { }
}

// Namespace: 
internal class ControllerMapLayoutManager.CyLIHYrgPsXJSPGIXMMCKhWGZnNj // TypeDefIndex: 6970
{
	// Fields
	public bool GnLsPvCJRbGYdfKiEJEsalgyYTXsA; // 0x10
	public bool fXdymNpXemgHiAfiweVPmQEFwyGn; // 0x11
	public NAbWnuemoUtDRnJvbekVDdUYjrWbb[] UQRSlzFquEOzOlvdxKrxAOpmWdyT; // 0x18

	// Methods

	// RVA: 0x1A804A0 Offset: 0x1A7F6A0 VA: 0x181A804A0
	public void .ctor(bool , bool , NAbWnuemoUtDRnJvbekVDdUYjrWbb[] ) { }
}

// Namespace: 
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[Preserve]
[Serializable]
public sealed class ControllerMapLayoutManager.Rule : IDeepCloneable // TypeDefIndex: 6971
{
	// Fields
	[SerializeField]
	[Serialize(Name = "tag")]
	private string _tag; // 0x10
	[Serialize(Name = "categoryIds")]
	[SerializeField]
	private int[] _categoryIds; // 0x18
	[SerializeField]
	[Serialize(Name = "layoutId")]
	private int _layoutId; // 0x20
	[Serialize(Name = "controllerSetSelector")]
	[SerializeField]
	private ControllerSetSelector _controllerSetSelector; // 0x28
	private string[] _preInitCategoryNames; // 0x30
	private string _preInitLayoutName; // 0x38

	// Properties
	public string tag { get; set; }
	public ControllerSetSelector controllerSetSelector { get; set; }
	public int categoryId { get; set; }
	public int[] categoryIds { get; set; }
	public int layoutId { get; set; }
	public string categoryName { get; set; }
	public string[] categoryNames { get; set; }
	public string layoutName { get; set; }
	internal bool isValid { get; }

	// Methods

	// RVA: 0x1A84520 Offset: 0x1A83720 VA: 0x181A84520
	public void .ctor() { }

	// RVA: 0x1A84340 Offset: 0x1A83540 VA: 0x181A84340
	public void .ctor(ControllerMapLayoutManager.Rule ) { }

	// RVA: 0x1A844D0 Offset: 0x1A836D0 VA: 0x181A844D0
	internal void .ctor(string , int[] , int , ControllerSetSelector ) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_tag() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_tag(string value) { }

	// RVA: 0x1A84E70 Offset: 0x1A84070 VA: 0x181A84E70
	public ControllerSetSelector get_controllerSetSelector() { }

	// RVA: 0x1A86530 Offset: 0x1A85730 VA: 0x181A86530
	public void set_controllerSetSelector(ControllerSetSelector value) { }

	// RVA: 0x1A84700 Offset: 0x1A83900 VA: 0x181A84700
	public int get_categoryId() { }

	// RVA: 0x1A85970 Offset: 0x1A84B70 VA: 0x181A85970
	public void set_categoryId(int value) { }

	// RVA: 0x1A847E0 Offset: 0x1A839E0 VA: 0x181A847E0
	public int[] get_categoryIds() { }

	// RVA: 0x1A85B60 Offset: 0x1A84D60 VA: 0x181A85B60
	public void set_categoryIds(int[] value) { }

	// RVA: 0x1A853C0 Offset: 0x1A845C0 VA: 0x181A853C0
	public int get_layoutId() { }

	// RVA: 0x1A86620 Offset: 0x1A85820 VA: 0x181A86620
	public void set_layoutId(int value) { }

	// RVA: 0x1A84830 Offset: 0x1A83A30 VA: 0x181A84830
	public string get_categoryName() { }

	// RVA: 0x1A85BD0 Offset: 0x1A84DD0 VA: 0x181A85BD0
	public void set_categoryName(string value) { }

	// RVA: 0x1A84AB0 Offset: 0x1A83CB0 VA: 0x181A84AB0
	public string[] get_categoryNames() { }

	// RVA: 0x1A86010 Offset: 0x1A85210 VA: 0x181A86010
	public void set_categoryNames(string[] value) { }

	// RVA: 0x1A855B0 Offset: 0x1A847B0 VA: 0x181A855B0
	public string get_layoutName() { }

	// RVA: 0x1A86770 Offset: 0x1A85970 VA: 0x181A86770
	public void set_layoutName(string value) { }

	// RVA: 0x1A85180 Offset: 0x1A84380 VA: 0x181A85180
	internal bool get_isValid() { }

	// RVA: 0x1A83710 Offset: 0x1A82910 VA: 0x181A83710
	private void Initialize() { }

	// RVA: 0x1A83F10 Offset: 0x1A83110 VA: 0x181A83F10 Slot: 4
	private object Rewired.Utils.Interfaces.IDeepCloneable.DeepClone() { }
}

// Namespace: 
[DefaultMember("Item")]
[Preserve]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[SerializationType(1)]
[Serializable]
public sealed class ControllerMapLayoutManager.RuleSet : IList<ControllerMapLayoutManager.Rule>, ICollection<ControllerMapLayoutManager.Rule>, IEnumerable<ControllerMapLayoutManager.Rule>, IEnumerable, IDeepCloneable // TypeDefIndex: 6972
{
	// Fields
	private const string className = "ControllerMapLayoutManager.RuleSet";
	[Serialize(Name = "enabled")]
	[SerializeField]
	private bool _enabled; // 0x10
	[Serialize(Name = "tag")]
	[SerializeField]
	private string _tag; // 0x18
	[Serialize(Name = "rules")]
	[SerializeField]
	private List<ControllerMapLayoutManager.Rule> _rules; // 0x20

	// Properties
	public bool enabled { get; set; }
	public string tag { get; set; }
	public List<ControllerMapLayoutManager.Rule> rules { get; set; }
	public ControllerMapLayoutManager.Rule Item { get; set; }
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<Rewired.ControllerMapLayoutManager.Rule>.IsReadOnly { get; }

	// Methods

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_enabled() { }

	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_enabled(bool value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_tag() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_tag(string value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public List<ControllerMapLayoutManager.Rule> get_rules() { }

	// RVA: 0x1A83480 Offset: 0x1A82680 VA: 0x181A83480
	public void set_rules(List<ControllerMapLayoutManager.Rule> value) { }

	// RVA: 0x1A82DA0 Offset: 0x1A81FA0 VA: 0x181A82DA0
	internal void .ctor(bool , string , List<ControllerMapLayoutManager.Rule> ) { }

	// RVA: 0x1A82FF0 Offset: 0x1A821F0 VA: 0x181A82FF0
	public void .ctor() { }

	// RVA: 0x1A82C70 Offset: 0x1A81E70 VA: 0x181A82C70
	public void .ctor(ControllerMapLayoutManager.RuleSet ) { }

	// RVA: 0x1A81C60 Offset: 0x1A80E60 VA: 0x181A81C60
	public ControllerMapLayoutManager.Rule Find(Predicate<ControllerMapLayoutManager.Rule> predicate) { }

	// RVA: 0x1A81910 Offset: 0x1A80B10 VA: 0x181A81910
	public ControllerMapLayoutManager.Rule FindLast(Predicate<ControllerMapLayoutManager.Rule> predicate) { }

	// RVA: 0x1A81180 Offset: 0x1A80380 VA: 0x181A81180
	public int FindIndex(Predicate<ControllerMapLayoutManager.Rule> predicate) { }

	// RVA: 0x1A81610 Offset: 0x1A80810 VA: 0x181A81610
	public int FindLastIndex(Predicate<ControllerMapLayoutManager.Rule> predicate) { }

	// RVA: 0x1A81FE0 Offset: 0x1A811E0 VA: 0x181A81FE0 Slot: 6
	public int IndexOf(ControllerMapLayoutManager.Rule item) { }

	// RVA: 0x1A821E0 Offset: 0x1A813E0 VA: 0x181A821E0 Slot: 7
	public void Insert(int index, ControllerMapLayoutManager.Rule item) { }

	// RVA: 0x1A82350 Offset: 0x1A81550 VA: 0x181A82350 Slot: 8
	public void RemoveAt(int index) { }

	// RVA: 0x1A831A0 Offset: 0x1A823A0 VA: 0x181A831A0 Slot: 4
	public ControllerMapLayoutManager.Rule get_Item(int index) { }

	// RVA: 0x1A833C0 Offset: 0x1A825C0 VA: 0x181A833C0 Slot: 5
	public void set_Item(int index, ControllerMapLayoutManager.Rule value) { }

	// RVA: 0x1A80B20 Offset: 0x1A7FD20 VA: 0x181A80B20 Slot: 11
	public void Add(ControllerMapLayoutManager.Rule item) { }

	// RVA: 0x1A80D00 Offset: 0x1A7FF00 VA: 0x181A80D00 Slot: 12
	public void Clear() { }

	// RVA: 0x1A80EA0 Offset: 0x1A800A0 VA: 0x181A80EA0 Slot: 13
	public bool Contains(ControllerMapLayoutManager.Rule item) { }

	// RVA: 0x1A81000 Offset: 0x1A80200 VA: 0x181A81000 Slot: 14
	public void CopyTo(ControllerMapLayoutManager.Rule[] array, int arrayIndex) { }

	// RVA: 0x1A83100 Offset: 0x1A82300 VA: 0x181A83100 Slot: 9
	public int get_Count() { }

	// RVA: 0x1A828D0 Offset: 0x1A81AD0 VA: 0x181A828D0 Slot: 10
	private bool System.Collections.Generic.ICollection<Rewired.ControllerMapLayoutManager.Rule>.get_IsReadOnly() { }

	// RVA: 0x1A824B0 Offset: 0x1A816B0 VA: 0x181A824B0 Slot: 15
	public bool Remove(ControllerMapLayoutManager.Rule item) { }

	// RVA: 0x1A81E20 Offset: 0x1A81020 VA: 0x181A81E20 Slot: 16
	public IEnumerator<ControllerMapLayoutManager.Rule> GetEnumerator() { }

	// RVA: 0x1A82980 Offset: 0x1A81B80 VA: 0x181A82980 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1A82560 Offset: 0x1A81760 VA: 0x181A82560 Slot: 18
	private object Rewired.Utils.Interfaces.IDeepCloneable.DeepClone() { }

	// RVA: 0x1A80C20 Offset: 0x1A7FE20 VA: 0x181A80C20
	private void CheckList() { }
}

// Namespace: Rewired
public sealed class ControllerMapLayoutManager // TypeDefIndex: 6973
{
	// Fields
	private bool AqHaORMjZGTdLoJMHbRKCeXHvJfRA; // 0x10
	private bool OLTRagQGNjGtfAFiWyuygKIOGhinA; // 0x11
	private Player pTMwWYaHRMWjLJIpUEIUEZYYDbrY; // 0x18
	private ControllerMapLayoutManager.CyLIHYrgPsXJSPGIXMMCKhWGZnNj jLHUUHAIsMjgmrRYaJQbwcAmVIyh; // 0x20
	private readonly int aplyKYJQthDqFZJRnEooAHmQTlabA; // 0x28
	private List<ControllerMapLayoutManager.RuleSet> kQEqJhCdYOlFQTtNdtMqIEDdhhJf; // 0x30
	private Action kgfoCLVctQLAnCPayqqTIYAbYMSi; // 0x38

	// Properties
	public bool enabled { get; set; }
	public bool loadFromUserDataStore { get; set; }
	public List<ControllerMapLayoutManager.RuleSet> ruleSets { get; set; }

	// Methods

	// RVA: 0x1A70560 Offset: 0x1A6F760 VA: 0x181A70560
	internal void iTBhpkiLIYpJNTdXKJqrfzEcVTSB(Action ) { }

	// RVA: 0x1A6F8B0 Offset: 0x1A6EAB0 VA: 0x181A6F8B0
	internal void EpkvJxEGcBDjfsEESAvUgMlQWeFKA(Action ) { }

	// RVA: 0x1A70380 Offset: 0x1A6F580 VA: 0x181A70380
	internal void .ctor(Player , ControllerMapLayoutManager.CyLIHYrgPsXJSPGIXMMCKhWGZnNj ) { }

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_enabled() { }

	// RVA: 0x1A70600 Offset: 0x1A6F800 VA: 0x181A70600
	public void set_enabled(bool value) { }

	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0
	public bool get_loadFromUserDataStore() { }

	// RVA: 0x4BD750 Offset: 0x4BC950 VA: 0x1804BD750
	public void set_loadFromUserDataStore(bool value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public List<ControllerMapLayoutManager.RuleSet> get_ruleSets() { }

	// RVA: 0x1A70610 Offset: 0x1A6F810 VA: 0x181A70610
	public void set_ruleSets(List<ControllerMapLayoutManager.RuleSet> value) { }

	// RVA: 0x1A6E620 Offset: 0x1A6D820 VA: 0x181A6E620
	public void Apply() { }

	// RVA: 0x1A6FCB0 Offset: 0x1A6EEB0 VA: 0x181A6FCB0
	public void LoadDefaults() { }

	// RVA: 0x1A701E0 Offset: 0x1A6F3E0 VA: 0x181A701E0
	public string ToXmlString() { }

	// RVA: 0x1A70040 Offset: 0x1A6F240 VA: 0x181A70040
	public string ToJsonString() { }

	// RVA: 0x1A6FB00 Offset: 0x1A6ED00 VA: 0x181A6FB00
	public bool ImportXml(string xmlString) { }

	// RVA: 0x1A6F950 Offset: 0x1A6EB50 VA: 0x181A6F950
	public bool ImportJson(string jsonString) { }

	// RVA: 0x1A704E0 Offset: 0x1A6F6E0 VA: 0x181A704E0
	private SerializedObject dDwdeldWYOLrnWiNJjDBHtCWImLzA() { }

	// RVA: 0x1A6F270 Offset: 0x1A6E470 VA: 0x181A6F270
	private void CHlQrZhwuPdYxNWJlUTNgThCUzEf(SerializedObject ) { }

	// RVA: 0x1A6FF10 Offset: 0x1A6F110 VA: 0x181A6FF10
	private bool MQHErEylLpkabJiPJFPMzIMISIct(SerializedObject ) { }
}

// Namespace: Rewired
public abstract class ControllerMapSaveData // TypeDefIndex: 6974
{
	// Fields
	protected Controller _controller; // 0x10
	protected ControllerMap _map; // 0x18
	internal readonly int aplyKYJQthDqFZJRnEooAHmQTlabA; // 0x20

	// Properties
	public ControllerMap map { get; }
	public int categoryId { get; }
	public int layoutId { get; }
	public Type mapType { get; }
	public string mapTypeString { get; }
	public Controller controller { get; }
	public ControllerType controllerType { get; }
	public string controllerHardwareIdentifier { get; }

	// Methods

	// RVA: 0x1A70EB0 Offset: 0x1A700B0 VA: 0x181A70EB0
	public ControllerMap get_map() { }

	// RVA: 0x1A70A40 Offset: 0x1A6FC40 VA: 0x181A70A40
	public int get_categoryId() { }

	// RVA: 0x1A70CC0 Offset: 0x1A6FEC0 VA: 0x181A70CC0
	public int get_layoutId() { }

	// RVA: 0x1A70E10 Offset: 0x1A70010 VA: 0x181A70E10
	public Type get_mapType() { }

	// RVA: 0x1A70D60 Offset: 0x1A6FF60 VA: 0x181A70D60
	public string get_mapTypeString() { }

	// RVA: 0x1A70C30 Offset: 0x1A6FE30 VA: 0x181A70C30
	public Controller get_controller() { }

	// RVA: 0x1A70B90 Offset: 0x1A6FD90 VA: 0x181A70B90
	public ControllerType get_controllerType() { }

	// RVA: 0x1A70AE0 Offset: 0x1A6FCE0 VA: 0x181A70AE0
	public string get_controllerHardwareIdentifier() { }

	// RVA: -1 Offset: -1
	public T GetMap<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94F490 Offset: 0x94E690 VA: 0x18094F490
	|-ControllerMapSaveData.GetMap<object>
	*/

	// RVA: 0x1A70980 Offset: 0x1A6FB80 VA: 0x181A70980
	internal void .ctor(Controller , ControllerMap ) { }

	// RVA: -1 Offset: -1
	internal static  TZpAtmoswOXHtgELCQOweYKzFlBS<>(Controller , ControllerMap ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94F590 Offset: 0x94E790 VA: 0x18094F590
	|-ControllerMapSaveData.TZpAtmoswOXHtgELCQOweYKzFlBS<object>
	*/

	// RVA: 0x1A70680 Offset: 0x1A6F880 VA: 0x181A70680
	internal static ControllerMapSaveData TZpAtmoswOXHtgELCQOweYKzFlBS(Controller , ControllerMap ) { }
}

// Namespace: Rewired
public sealed class KeyboardMapSaveData : ControllerMapSaveData // TypeDefIndex: 6975
{
	// Properties
	public KeyboardMap keyboardMap { get; }

	// Methods

	// RVA: 0x1A808C0 Offset: 0x1A7FAC0 VA: 0x181A808C0
	public KeyboardMap get_keyboardMap() { }

	// RVA: 0x1A80200 Offset: 0x1A7F400 VA: 0x181A80200
	internal void .ctor(Keyboard , KeyboardMap ) { }
}

// Namespace: Rewired
public sealed class MouseMapSaveData : ControllerMapSaveData // TypeDefIndex: 6976
{
	// Properties
	public MouseMap keyboardMap { get; }

	// Methods

	// RVA: 0x1A80970 Offset: 0x1A7FB70 VA: 0x181A80970
	public MouseMap get_keyboardMap() { }

	// RVA: 0x1A80200 Offset: 0x1A7F400 VA: 0x181A80200
	internal void .ctor(Mouse , MouseMap ) { }
}

// Namespace: Rewired
public sealed class JoystickMapSaveData : ControllerMapSaveData // TypeDefIndex: 6977
{
	// Properties
	public Joystick joystick { get; }
	public JoystickMap joystickMap { get; }
	public Guid joystickHardwareTypeGuid { get; }

	// Methods

	// RVA: 0x1A807E0 Offset: 0x1A7F9E0 VA: 0x181A807E0
	public Joystick get_joystick() { }

	// RVA: 0x1A80730 Offset: 0x1A7F930 VA: 0x181A80730
	public JoystickMap get_joystickMap() { }

	// RVA: 0x1A80590 Offset: 0x1A7F790 VA: 0x181A80590
	public Guid get_joystickHardwareTypeGuid() { }

	// RVA: 0x1A80200 Offset: 0x1A7F400 VA: 0x181A80200
	internal void .ctor(Joystick , JoystickMap ) { }
}

// Namespace: Rewired
public sealed class CustomControllerMapSaveData : ControllerMapSaveData // TypeDefIndex: 6978
{
	// Properties
	public CustomController customController { get; }
	public CustomControllerMap customControllerMap { get; }
	public int customControllerSourceId { get; }

	// Methods

	// RVA: 0x1A803F0 Offset: 0x1A7F5F0 VA: 0x181A803F0
	public CustomController get_customController() { }

	// RVA: 0x1A80210 Offset: 0x1A7F410 VA: 0x181A80210
	public CustomControllerMap get_customControllerMap() { }

	// RVA: 0x1A802C0 Offset: 0x1A7F4C0 VA: 0x181A802C0
	public int get_customControllerSourceId() { }

	// RVA: 0x1A80200 Offset: 0x1A7F400 VA: 0x181A80200
	internal void .ctor(CustomController , CustomControllerMap ) { }
}

// Namespace: 
private class ControllerMap.KquXHTgPJriqIHirZGgsKCvbvjev : IComparer<ActionElementMap> // TypeDefIndex: 6979
{
	// Fields
	public static ControllerMap.KquXHTgPJriqIHirZGgsKCvbvjev YczwqvyOwqYoELcitbwVGXbgCewT; // 0x0

	// Properties
	public static ControllerMap.KquXHTgPJriqIHirZGgsKCvbvjev LReIhSWBGsogLhSoNoceBCYTgAJb { get; }

	// Methods

	// RVA: 0x1A97040 Offset: 0x1A96240 VA: 0x181A97040
	public static ControllerMap.KquXHTgPJriqIHirZGgsKCvbvjev dDsLOZDJaZgztikcIBttdUDKdwGXA() { }

	// RVA: 0x1A96F10 Offset: 0x1A96110 VA: 0x181A96F10 Slot: 4
	public int Compare(ActionElementMap x, ActionElementMap y) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControllerMap.tvBsvKEdroDcCXjBDEvRSVDlAQVu : IDisposable, IEnumerable, IEnumerable<ActionElementMap>, IEnumerator, IEnumerator<ActionElementMap> // TypeDefIndex: 6980
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ActionElementMap lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public ControllerMap nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int RMJEoXtoZMtwULyaBvSFzYLhgaKj; // 0x30
	public int NGoDsrkiKABiOBzXCjjnCIXciAdse; // 0x34
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x38
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x39
	private IList<ActionElementMap> nvyqTcTNpYZjISAxqSxkSToQKEDu; // 0x40
	private int lluMLZaNqFUtaJCMlRWVpiCoVadX; // 0x48
	private int pPGgUESwNACgnGeuXdCQJJGRwcRF; // 0x4C

	// Properties
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1A9E700 Offset: 0x1A9D900 VA: 0x181A9E700 Slot: 7
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A9E900 Offset: 0x1A9DB00 VA: 0x181A9E900 Slot: 9
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A9E840 Offset: 0x1A9DA40 VA: 0x181A9E840 Slot: 6
	private IEnumerator<ActionElementMap> System.Collections.Generic.IEnumerable<Rewired.ActionElementMap>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1A9E840 Offset: 0x1A9DA40 VA: 0x181A9E840 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControllerMap.YhzimFHEovYiLjjPkIbygTnKQzojA : IDisposable, IEnumerable, IEnumerator, IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6981
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ElementAssignmentConflictInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x14
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x40
	public ControllerMap nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x48
	private ControllerMap CKLJUnnpndBsfdLuUgNsJpcsPydNA; // 0x50
	public ControllerMap XKggfxeXPxsBWhpmYdazjfymyqTx; // 0x58
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x60
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x61
	private IList<ActionElementMap> jnaFHzetMIjiyJdrzHeTBpNMnzti; // 0x68
	private int pyoWfSIWvBFJSOPXrCWiiyDaegKb; // 0x70
	private int pPGgUESwNACgnGeuXdCQJJGRwcRF; // 0x74
	private ActionElementMap GEQLZdXugyVzilaozJULSYzPQQJd; // 0x78
	private int pyQLGGZqNaQgIvoPCvziKBwnbtLq; // 0x80

	// Properties
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xE7ACF0 Offset: 0xE79EF0 VA: 0x180E7ACF0
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1A97F00 Offset: 0x1A97100 VA: 0x181A97F00 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x798F40 Offset: 0x798140 VA: 0x180798F40 Slot: 10
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A98370 Offset: 0x1A97570 VA: 0x181A98370 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1A983B0 Offset: 0x1A975B0 VA: 0x181A983B0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A982A0 Offset: 0x1A974A0 VA: 0x181A982A0 Slot: 9
	private IEnumerator<ElementAssignmentConflictInfo> System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1A982A0 Offset: 0x1A974A0 VA: 0x181A982A0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControllerMap.GkdotgQDAswmZYAWzvmAjGdSicOfA : IDisposable, IEnumerable, IEnumerator, IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6982
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ElementAssignmentConflictInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x14
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x40
	public ControllerMap nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x48
	private ActionElementMap eWszhrzTgmaZrKigKDnkYoAPWDCy; // 0x50
	public ActionElementMap JKEckpOxZnAYcfsBykRqnmrfUVCEA; // 0x58
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x60
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x61
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x64

	// Properties
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xE7ACF0 Offset: 0xE79EF0 VA: 0x180E7ACF0
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1A8F040 Offset: 0x1A8E240 VA: 0x181A8F040 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x798F40 Offset: 0x798140 VA: 0x180798F40 Slot: 10
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A8F430 Offset: 0x1A8E630 VA: 0x181A8F430 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1A8F470 Offset: 0x1A8E670 VA: 0x181A8F470 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A8F360 Offset: 0x1A8E560 VA: 0x181A8F360 Slot: 9
	private IEnumerator<ElementAssignmentConflictInfo> System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1A8F360 Offset: 0x1A8E560 VA: 0x181A8F360 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControllerMap.YCfnIsSqwvPNeSeNKSlIIxNbjwwq : IDisposable, IEnumerable, IEnumerator, IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6983
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ElementAssignmentConflictInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x14
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x40
	public ControllerMap nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x48
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x50
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x51
	private ElementAssignmentConflictCheck zqwcQAKmowyacotoRHDevIvpNlyi; // 0x54
	public ElementAssignmentConflictCheck ejpVKkYVvFucluBNLhLsNxfggkay; // 0x8C
	private ElementAssignment nabztmcYuDjNEVkjGgkjKHjmDUiX; // 0xC4
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0xE8

	// Properties
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xE7ACF0 Offset: 0xE79EF0 VA: 0x180E7ACF0
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1A979F0 Offset: 0x1A96BF0 VA: 0x181A979F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x798F40 Offset: 0x798140 VA: 0x180798F40 Slot: 10
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A97E60 Offset: 0x1A97060 VA: 0x181A97E60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1A97EA0 Offset: 0x1A970A0 VA: 0x181A97EA0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A97D70 Offset: 0x1A96F70 VA: 0x181A97D70 Slot: 9
	private IEnumerator<ElementAssignmentConflictInfo> System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1A97D70 Offset: 0x1A96F70 VA: 0x181A97D70 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControllerMap.groDrMDtBMdqyBJtgnJwluHedawrb : IDisposable, IEnumerable, IEnumerable<ActionElementMap>, IEnumerator, IEnumerator<ActionElementMap> // TypeDefIndex: 6984
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ActionElementMap lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public ControllerMap nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int RMJEoXtoZMtwULyaBvSFzYLhgaKj; // 0x30
	public int NGoDsrkiKABiOBzXCjjnCIXciAdse; // 0x34
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x38
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x39
	private IEnumerator<ActionElementMap> BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x40

	// Properties
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1A98DA0 Offset: 0x1A97FA0 VA: 0x181A98DA0 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1A98A60 Offset: 0x1A97C60 VA: 0x181A98A60 Slot: 7
	private bool MoveNext() { }

	// RVA: 0x1A98E30 Offset: 0x1A98030 VA: 0x181A98E30
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A98D60 Offset: 0x1A97F60 VA: 0x181A98D60 Slot: 9
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A98CA0 Offset: 0x1A97EA0 VA: 0x181A98CA0 Slot: 6
	private IEnumerator<ActionElementMap> System.Collections.Generic.IEnumerable<Rewired.ActionElementMap>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1A98CA0 Offset: 0x1A97EA0 VA: 0x181A98CA0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControllerMap.fKyeuiBilUaLhIPgiFzTZwZNGtHsB : IDisposable, IEnumerable, IEnumerable<ActionElementMap>, IEnumerator, IEnumerator<ActionElementMap> // TypeDefIndex: 6985
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ActionElementMap lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public ControllerMap nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private IControllerElementTarget SPZwWgkugIdIobuRoanvoELOxALn; // 0x30
	public IControllerElementTarget wTdwqWPpHJyhbydqsmiTPijdczEBA; // 0x38
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x40
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x41
	private TempListPool.TList<ActionElementMap> BufOCdXaSRChsEQKaHxGGCyIsuBFb; // 0x48
	private List.Enumerator<ActionElementMap> FrrinBtHtwjQHWNUKhBdvpNvuGOV; // 0x50

	// Properties
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1A988C0 Offset: 0x1A97AC0 VA: 0x181A988C0 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1A98410 Offset: 0x1A97610 VA: 0x181A98410 Slot: 7
	private bool MoveNext() { }

	// RVA: 0x1A98A10 Offset: 0x1A97C10 VA: 0x181A98A10
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	// RVA: 0x1A98760 Offset: 0x1A97960 VA: 0x181A98760
	private void NliQpQwAufCfLWbPmVSuBlrEIiqh() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A98880 Offset: 0x1A97A80 VA: 0x181A98880 Slot: 9
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A987B0 Offset: 0x1A979B0 VA: 0x181A987B0 Slot: 6
	private IEnumerator<ActionElementMap> System.Collections.Generic.IEnumerable<Rewired.ActionElementMap>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1A987B0 Offset: 0x1A979B0 VA: 0x181A987B0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControllerMap.FdGsNdymtVInAcKDgvuTIXhcpoHh : IDisposable, IEnumerable, IEnumerable<ActionElementMap>, IEnumerator, IEnumerator<ActionElementMap> // TypeDefIndex: 6986
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ActionElementMap lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public ControllerMap nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private IControllerElementTarget SPZwWgkugIdIobuRoanvoELOxALn; // 0x30
	public IControllerElementTarget wTdwqWPpHJyhbydqsmiTPijdczEBA; // 0x38
	private int RMJEoXtoZMtwULyaBvSFzYLhgaKj; // 0x40
	public int NGoDsrkiKABiOBzXCjjnCIXciAdse; // 0x44
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x48
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x49
	private TempListPool.TList<ActionElementMap> BufOCdXaSRChsEQKaHxGGCyIsuBFb; // 0x50
	private List.Enumerator<ActionElementMap> FrrinBtHtwjQHWNUKhBdvpNvuGOV; // 0x58

	// Properties
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1A8EEA0 Offset: 0x1A8E0A0 VA: 0x181A8EEA0 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1A8E9F0 Offset: 0x1A8DBF0 VA: 0x181A8E9F0 Slot: 7
	private bool MoveNext() { }

	// RVA: 0x1A8EFF0 Offset: 0x1A8E1F0 VA: 0x181A8EFF0
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	// RVA: 0x1A8ED40 Offset: 0x1A8DF40 VA: 0x181A8ED40
	private void NliQpQwAufCfLWbPmVSuBlrEIiqh() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A8EE60 Offset: 0x1A8E060 VA: 0x181A8EE60 Slot: 9
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A8ED90 Offset: 0x1A8DF90 VA: 0x181A8ED90 Slot: 6
	private IEnumerator<ActionElementMap> System.Collections.Generic.IEnumerable<Rewired.ActionElementMap>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1A8ED90 Offset: 0x1A8DF90 VA: 0x181A8ED90 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Rewired
public abstract class ControllerMap // TypeDefIndex: 6987
{
	// Fields
	protected int _id; // 0x10
	protected int _sourceMapId; // 0x14
	protected int _categoryId; // 0x18
	protected int _layoutId; // 0x1C
	protected string _name; // 0x20
	protected Guid _hardwareGuid; // 0x28
	protected bool _enabled; // 0x38
	internal readonly int aplyKYJQthDqFZJRnEooAHmQTlabA; // 0x3C
	private readonly AList<ActionElementMap> ndIAeTUIgUZeOjRfGrRwiXXswMfF; // 0x40
	private readonly ReadOnlyCollection<ActionElementMap> ftvhYYRjHIJzGdPdQZEJPDvBXhOC; // 0x48
	private readonly AList<ActionElementMap> QKOsSGKAXamdBSNfUToPXHiTDDtKA; // 0x50
	private readonly ReadOnlyCollection<ActionElementMap> KMSaoqBbkrIxaOYCxYNUDpohMAPwA; // 0x58
	protected int _playerId; // 0x60
	protected int _controllerId; // 0x64
	protected ControllerType _controllerType; // 0x68
	private static int vzvQZaGGvhLHYMcuLKREDuKhcelO; // 0x0

	// Properties
	private static int jLAGNYWCODnvImWNRQjMGXLYfgir { get; }
	public int id { get; }
	public int sourceMapId { get; set; }
	public int categoryId { get; set; }
	public int layoutId { get; set; }
	public string name { get; set; }
	public Guid hardwareGuid { get; set; }
	public bool enabled { get; set; }
	public int playerId { get; set; }
	public int controllerId { get; set; }
	public Controller controller { get; }
	public ControllerType controllerType { get; }
	public Player player { get; }
	public int elementMapCount { get; }
	public int buttonMapCount { get; }
	public IList<ActionElementMap> AllMaps { get; }
	public IList<ActionElementMap> ElementMaps { get; }
	public IList<ActionElementMap> ButtonMaps { get; }
	internal AList<ActionElementMap> EsYhSjrJnhPnGVoOaEkumnSUqZgl { get; }

	// Methods

	// RVA: 0x1A7B140 Offset: 0x1A7A340 VA: 0x181A7B140
	private static int TnEiZjlUpdgKjZaXRQnwJGDdRmyt() { }

	// RVA: 0x1A7BA40 Offset: 0x1A7AC40 VA: 0x181A7BA40
	public void .ctor() { }

	// RVA: 0x1A7BC20 Offset: 0x1A7AE20 VA: 0x181A7BC20
	public void .ctor(ControllerMap ) { }

	// RVA: 0x1A7D040 Offset: 0x1A7C240 VA: 0x181A7D040
	public int get_id() { }

	// RVA: 0x1A7D340 Offset: 0x1A7C540 VA: 0x181A7D340
	public int get_sourceMapId() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	internal void oqJvlbFuaxJPLfHRgfeKtiCnFhZs(int ) { }

	// RVA: 0x1A7CBE0 Offset: 0x1A7BDE0 VA: 0x181A7CBE0
	public int get_categoryId() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	internal void agwrqjwkphLyJewepWkOzIeySpDg(int ) { }

	// RVA: 0x1A7D0D0 Offset: 0x1A7C2D0 VA: 0x181A7D0D0
	public int get_layoutId() { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	internal void JtcdVSQbvatVgRVnyQjilPdaoaFV(int ) { }

	// RVA: 0x1A7D160 Offset: 0x1A7C360 VA: 0x181A7D160
	public string get_name() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	internal void uGSHIPnuNZPbyNhItjkmgCPddCPV(string ) { }

	// RVA: 0x1A7CF80 Offset: 0x1A7C180 VA: 0x181A7CF80
	public Guid get_hardwareGuid() { }

	// RVA: 0x3F6CA0 Offset: 0x3F5EA0 VA: 0x1803F6CA0
	internal void LrJsmMOPQHsOqqkrbPMOYGctdffD(Guid ) { }

	// RVA: 0x1A7CEF0 Offset: 0x1A7C0F0 VA: 0x181A7CEF0
	public bool get_enabled() { }

	// RVA: 0x4BD760 Offset: 0x4BC960 VA: 0x1804BD760
	public void set_enabled(bool value) { }

	// RVA: 0x1A7D200 Offset: 0x1A7C400 VA: 0x181A7D200
	public int get_playerId() { }

	// RVA: 0x42D900 Offset: 0x42CB00 VA: 0x18042D900
	internal void tizyvKmrgPULSUDDjvsATFdYPPlF(int ) { }

	// RVA: 0x1A7CC70 Offset: 0x1A7BE70 VA: 0x181A7CC70
	public int get_controllerId() { }

	// RVA: 0x677720 Offset: 0x676920 VA: 0x180677720
	internal void yEJTScHOAKalRJkaeRRAAbYFKNHnB(int ) { }

	// RVA: 0x1A7CD90 Offset: 0x1A7BF90 VA: 0x181A7CD90
	public Controller get_controller() { }

	// RVA: 0x1A7CD00 Offset: 0x1A7BF00 VA: 0x181A7CD00
	public ControllerType get_controllerType() { }

	// RVA: 0x1A7D290 Offset: 0x1A7C490 VA: 0x181A7D290
	public Player get_player() { }

	// RVA: 0x1A7CE50 Offset: 0x1A7C050 VA: 0x181A7CE50
	public int get_elementMapCount() { }

	// RVA: 0x1A7CB40 Offset: 0x1A7BD40 VA: 0x181A7CB40
	public int get_buttonMapCount() { }

	// RVA: 0x1A7C960 Offset: 0x1A7BB60 VA: 0x181A7C960
	public IList<ActionElementMap> get_AllMaps() { }

	// RVA: 0x1A7CAA0 Offset: 0x1A7BCA0 VA: 0x181A7CAA0
	public IList<ActionElementMap> get_ElementMaps() { }

	// RVA: 0x1A7CA00 Offset: 0x1A7BC00 VA: 0x181A7CA00
	public IList<ActionElementMap> get_ButtonMaps() { }

	// RVA: 0x1A71F30 Offset: 0x1A71130 VA: 0x181A71F30
	public bool ContainsAction(string actionName) { }

	// RVA: 0x1A72020 Offset: 0x1A71220 VA: 0x181A72020 Slot: 4
	public virtual bool ContainsAction(int actionId) { }

	// RVA: 0x1A72130 Offset: 0x1A71330 VA: 0x181A72130
	public bool ContainsElementIdentifier(int elementIdentifierId) { }

	// RVA: 0x1A72460 Offset: 0x1A71660 VA: 0x181A72460
	public bool ContainsKeyboardKey(KeyCode keyCode, ModifierKeyFlags modifierKeys) { }

	// RVA: 0x1A72240 Offset: 0x1A71440 VA: 0x181A72240
	public bool ContainsElementMap(ActionElementMap elementMap) { }

	// RVA: 0x1A72350 Offset: 0x1A71550 VA: 0x181A72350
	public bool ContainsElementMap(int elementMapId) { }

	// RVA: 0x1A7AA20 Offset: 0x1A79C20 VA: 0x181A7AA20
	public bool ReplaceOrCreateElementMap(ElementAssignment elementAssignment) { }

	// RVA: 0x1A7AB80 Offset: 0x1A79D80 VA: 0x181A7AB80
	public bool ReplaceOrCreateElementMap(ElementAssignment elementAssignment, out ActionElementMap result) { }

	// RVA: 0x1A72760 Offset: 0x1A71960 VA: 0x181A72760
	public bool CreateElementMap(ElementAssignment elementAssignment) { }

	// RVA: 0x1A729A0 Offset: 0x1A71BA0 VA: 0x181A729A0
	public bool CreateElementMap(ElementAssignment elementAssignment, out ActionElementMap result) { }

	// RVA: 0x1A72950 Offset: 0x1A71B50 VA: 0x181A72950
	public bool CreateElementMap(int actionId, Pole axisContribution, KeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3) { }

	// RVA: 0x1A725C0 Offset: 0x1A717C0 VA: 0x181A725C0
	public bool CreateElementMap(int actionId, Pole axisContribution, KeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3, out ActionElementMap result) { }

	// RVA: 0x1A72CD0 Offset: 0x1A71ED0 VA: 0x181A72CD0
	public bool CreateElementMap(int actionId, Pole axisContribution, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags) { }

	// RVA: 0x1A72830 Offset: 0x1A71A30 VA: 0x181A72830
	public bool CreateElementMap(int actionId, Pole axisContribution, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags, out ActionElementMap result) { }

	// RVA: 0x1A72C70 Offset: 0x1A71E70 VA: 0x181A72C70
	public bool CreateElementMap(int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert) { }

	// RVA: 0x1A72B30 Offset: 0x1A71D30 VA: 0x181A72B30 Slot: 5
	public virtual bool CreateElementMap(int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert, out ActionElementMap result) { }

	// RVA: 0x1A7A2C0 Offset: 0x1A794C0 VA: 0x181A7A2C0
	public bool ReplaceElementMap(ElementAssignment elementAssignment) { }

	// RVA: 0x1A7A6A0 Offset: 0x1A798A0 VA: 0x181A7A6A0
	public bool ReplaceElementMap(ElementAssignment elementAssignment, out ActionElementMap result) { }

	// RVA: 0x1A7A5A0 Offset: 0x1A797A0 VA: 0x181A7A5A0
	public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, KeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3) { }

	// RVA: 0x1A7A850 Offset: 0x1A79A50 VA: 0x181A7A850
	public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, KeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3, out ActionElementMap result) { }

	// RVA: 0x1A7A300 Offset: 0x1A79500 VA: 0x181A7A300
	public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags) { }

	// RVA: 0x1A7A5F0 Offset: 0x1A797F0 VA: 0x181A7A5F0
	public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags, out ActionElementMap result) { }

	// RVA: 0x1A7A3B0 Offset: 0x1A795B0 VA: 0x181A7A3B0
	public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert) { }

	// RVA: 0x1A7A420 Offset: 0x1A79620 VA: 0x181A7A420 Slot: 6
	public virtual bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert, out ActionElementMap result) { }

	// RVA: 0x1A73040 Offset: 0x1A72240 VA: 0x181A73040 Slot: 7
	public virtual bool DeleteElementMap(int elementMapId) { }

	// RVA: 0x1A73100 Offset: 0x1A72300 VA: 0x181A73100 Slot: 8
	public virtual bool DeleteElementMapsWithAction(string actionName) { }

	// RVA: 0x1A731A0 Offset: 0x1A723A0 VA: 0x181A731A0 Slot: 9
	public virtual bool DeleteElementMapsWithAction(int actionId) { }

	// RVA: 0x1A76AC0 Offset: 0x1A75CC0 VA: 0x181A76AC0 Slot: 10
	public virtual ActionElementMap GetElementMap(int elementMapId) { }

	// RVA: 0x1A77EB0 Offset: 0x1A770B0 VA: 0x181A77EB0
	public ActionElementMap[] GetElementMaps() { }

	// RVA: 0x1A77BC0 Offset: 0x1A76DC0 VA: 0x181A77BC0
	public ActionElementMap[] GetElementMaps(bool skipDisabledMaps) { }

	// RVA: 0x1A78000 Offset: 0x1A77200 VA: 0x181A78000
	public int GetElementMaps(List<ActionElementMap> results) { }

	// RVA: 0x1A77EC0 Offset: 0x1A770C0 VA: 0x181A77EC0
	public int GetElementMaps(bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1A77390 Offset: 0x1A76590 VA: 0x181A77390
	public ActionElementMap[] GetElementMapsWithAction(string actionName) { }

	// RVA: 0x1A76D20 Offset: 0x1A75F20 VA: 0x181A76D20
	public ActionElementMap[] GetElementMapsWithAction(int actionId) { }

	// RVA: 0x1A77280 Offset: 0x1A76480 VA: 0x181A77280
	public ActionElementMap[] GetElementMapsWithAction(string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1A76E70 Offset: 0x1A76070 VA: 0x181A76E70
	public ActionElementMap[] GetElementMapsWithAction(int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1A76BE0 Offset: 0x1A75DE0 VA: 0x181A76BE0
	public int GetElementMapsWithAction(string actionName, List<ActionElementMap> results) { }

	// RVA: 0x1A76E40 Offset: 0x1A76040 VA: 0x181A76E40
	public int GetElementMapsWithAction(int actionId, List<ActionElementMap> results) { }

	// RVA: 0x1A76D30 Offset: 0x1A75F30 VA: 0x181A76D30
	public int GetElementMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1A76CF0 Offset: 0x1A75EF0 VA: 0x181A76CF0
	public int GetElementMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1A73F30 Offset: 0x1A73130 VA: 0x181A73F30
	public IEnumerable<ActionElementMap> ElementMapsWithAction(string actionName) { }

	// RVA: 0x1A740C0 Offset: 0x1A732C0 VA: 0x181A740C0
	public IEnumerable<ActionElementMap> ElementMapsWithAction(int actionId) { }

	// RVA: 0x1A740D0 Offset: 0x1A732D0 VA: 0x181A740D0
	public IEnumerable<ActionElementMap> ElementMapsWithAction(string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1A74030 Offset: 0x1A73230 VA: 0x181A74030
	public IEnumerable<ActionElementMap> ElementMapsWithAction(int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1A78900 Offset: 0x1A77B00 VA: 0x181A78900 Slot: 11
	public virtual ActionElementMap GetFirstElementMapWithAction(int actionId) { }

	// RVA: 0x1A78710 Offset: 0x1A77910 VA: 0x181A78710 Slot: 12
	public virtual ActionElementMap GetFirstElementMapWithAction(string actionName) { }

	// RVA: 0x1A785B0 Offset: 0x1A777B0 VA: 0x181A785B0 Slot: 13
	public virtual ActionElementMap GetFirstElementMapWithAction(int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1A78800 Offset: 0x1A77A00 VA: 0x181A78800
	public ActionElementMap GetFirstElementMapWithAction(string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1A74580 Offset: 0x1A73780 VA: 0x181A74580
	public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps) { }

	// RVA: 0x1A746C0 Offset: 0x1A738C0 VA: 0x181A746C0
	public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps) { }

	// RVA: 0x1A74750 Offset: 0x1A73950 VA: 0x181A74750
	public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1A743A0 Offset: 0x1A735A0 VA: 0x181A743A0
	public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1A741E0 Offset: 0x1A733E0 VA: 0x181A741E0
	public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1A74280 Offset: 0x1A73480 VA: 0x181A74280
	public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1A78CB0 Offset: 0x1A77EB0 VA: 0x181A78CB0
	public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps) { }

	// RVA: 0x1A78AD0 Offset: 0x1A77CD0 VA: 0x181A78AD0
	public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps) { }

	// RVA: 0x1A78BC0 Offset: 0x1A77DC0 VA: 0x181A78BC0
	public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1A78920 Offset: 0x1A77B20 VA: 0x181A78920
	public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1A78F40 Offset: 0x1A78140 VA: 0x181A78F40
	public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1A78E40 Offset: 0x1A78040 VA: 0x181A78E40
	public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1A77780 Offset: 0x1A76980 VA: 0x181A77780
	public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1A77690 Offset: 0x1A76890 VA: 0x181A77690
	public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1A77490 Offset: 0x1A76690 VA: 0x181A77490
	public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1A77910 Offset: 0x1A76B10 VA: 0x181A77910
	public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1A77AD0 Offset: 0x1A76CD0 VA: 0x181A77AD0
	public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1A77580 Offset: 0x1A76780 VA: 0x181A77580
	public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1A78500 Offset: 0x1A77700 VA: 0x181A78500
	public ActionElementMap GetFirstElementMapMatch(Predicate<ActionElementMap> predicate) { }

	// RVA: 0x1A7DD40 Offset: 0x1A7CF40 VA: 0x181A7DD40 Slot: 14
	internal virtual ActionElementMap yFIcKiIfboNUJoJRnmXMaBKhGseHA(Predicate<ActionElementMap> , bool ) { }

	// RVA: 0x1A769F0 Offset: 0x1A75BF0 VA: 0x181A769F0
	public int GetElementMapMatches(Predicate<ActionElementMap> predicate, List<ActionElementMap> results) { }

	// RVA: 0x1A759D0 Offset: 0x1A74BD0 VA: 0x181A759D0 Slot: 15
	internal virtual int GRhsozChvTCFCFkNCGzbMaDrLLMD(Predicate<ActionElementMap> , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1A75700 Offset: 0x1A74900 VA: 0x181A75700
	public void ForEachElementMapMatch(Predicate<ActionElementMap> predicate, Action<ActionElementMap> actionToPerform) { }

	// RVA: 0x1A71E70 Offset: 0x1A71070 VA: 0x181A71E70 Slot: 16
	public virtual void ClearElementMaps() { }

	// RVA: 0x1A7AE70 Offset: 0x1A7A070 VA: 0x181A7AE70
	public int SetAllElementMapsEnabled(bool state) { }

	// RVA: 0x1A75AD0 Offset: 0x1A74CD0 VA: 0x181A75AD0
	public ActionElementMap GetButtonMap(int index) { }

	// RVA: 0x1A76420 Offset: 0x1A75620 VA: 0x181A76420
	public ActionElementMap[] GetButtonMaps() { }

	// RVA: 0x1A76690 Offset: 0x1A75890 VA: 0x181A76690
	public ActionElementMap[] GetButtonMaps(bool skipDisabledMaps) { }

	// RVA: 0x1A764D0 Offset: 0x1A756D0 VA: 0x181A764D0
	public int GetButtonMaps(bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1A75D70 Offset: 0x1A74F70 VA: 0x181A75D70
	public ActionElementMap[] GetButtonMapsWithAction(string actionName) { }

	// RVA: 0x1A75E90 Offset: 0x1A75090 VA: 0x181A75E90
	public ActionElementMap[] GetButtonMapsWithAction(int actionId) { }

	// RVA: 0x1A75FE0 Offset: 0x1A751E0 VA: 0x181A75FE0
	public ActionElementMap[] GetButtonMapsWithAction(string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1A76210 Offset: 0x1A75410 VA: 0x181A76210
	public ActionElementMap[] GetButtonMapsWithAction(int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1A75EA0 Offset: 0x1A750A0 VA: 0x181A75EA0
	public int GetButtonMapsWithAction(string actionName, List<ActionElementMap> results) { }

	// RVA: 0x1A75E70 Offset: 0x1A75070 VA: 0x181A75E70
	public int GetButtonMapsWithAction(int actionId, List<ActionElementMap> results) { }

	// RVA: 0x1A760F0 Offset: 0x1A752F0 VA: 0x181A760F0
	public int GetButtonMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1A75BA0 Offset: 0x1A74DA0 VA: 0x181A75BA0
	public int GetButtonMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1A71370 Offset: 0x1A70570 VA: 0x181A71370
	public IEnumerable<ActionElementMap> ButtonMapsWithAction(int actionId) { }

	// RVA: 0x1A71160 Offset: 0x1A70360 VA: 0x181A71160
	public IEnumerable<ActionElementMap> ButtonMapsWithAction(string actionName) { }

	// RVA: 0x1A71380 Offset: 0x1A70580 VA: 0x181A71380
	public IEnumerable<ActionElementMap> ButtonMapsWithAction(int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1A71260 Offset: 0x1A70460 VA: 0x181A71260
	public IEnumerable<ActionElementMap> ButtonMapsWithAction(string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1A78310 Offset: 0x1A77510 VA: 0x181A78310
	public ActionElementMap GetFirstButtonMapWithAction(int actionId) { }

	// RVA: 0x1A78420 Offset: 0x1A77620 VA: 0x181A78420
	public ActionElementMap GetFirstButtonMapWithAction(string actionName) { }

	// RVA: 0x1A781E0 Offset: 0x1A773E0 VA: 0x181A781E0
	public ActionElementMap GetFirstButtonMapWithAction(int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1A78320 Offset: 0x1A77520 VA: 0x181A78320
	public ActionElementMap GetFirstButtonMapWithAction(string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1A78130 Offset: 0x1A77330 VA: 0x181A78130
	public ActionElementMap GetFirstButtonMapMatch(Predicate<ActionElementMap> predicate) { }

	// RVA: 0x1A7C640 Offset: 0x1A7B840 VA: 0x181A7C640
	internal ActionElementMap feCbpGBvifiEZYmXlZRWphrKypQIA(Predicate<ActionElementMap> , bool ) { }

	// RVA: 0x1A75A00 Offset: 0x1A74C00 VA: 0x181A75A00
	public int GetButtonMapMatches(Predicate<ActionElementMap> predicate, List<ActionElementMap> results) { }

	// RVA: 0x1A74850 Offset: 0x1A73A50 VA: 0x181A74850
	internal int FKkDZGQrsnTCnRUTNkKUoeqUgAEJ(Predicate<ActionElementMap> , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1A74BF0 Offset: 0x1A73DF0 VA: 0x181A74BF0
	public void ForEachButtonMapMatch(Predicate<ActionElementMap> predicate, Action<ActionElementMap> actionToPerform) { }

	// RVA: 0x1A72E90 Offset: 0x1A72090 VA: 0x181A72E90
	public bool DeleteButtonMapsWithAction(string actionName) { }

	// RVA: 0x1A72F20 Offset: 0x1A72120 VA: 0x181A72F20
	public bool DeleteButtonMapsWithAction(int actionId) { }

	// RVA: 0x1A7AD50 Offset: 0x1A79F50 VA: 0x181A7AD50
	public int SetAllButtonMapsEnabled(bool state) { }

	// RVA: 0x1A73CA0 Offset: 0x1A72EA0 VA: 0x181A73CA0
	public bool DoesElementAssignmentConflict(ControllerMap controllerMap) { }

	// RVA: 0x1A73A60 Offset: 0x1A72C60 VA: 0x181A73A60
	public bool DoesElementAssignmentConflict(ActionElementMap actionElementMap) { }

	// RVA: 0x1A736E0 Offset: 0x1A728E0 VA: 0x181A736E0
	public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck) { }

	// RVA: 0x1A73A80 Offset: 0x1A72C80 VA: 0x181A73A80 Slot: 17
	public virtual bool DoesElementAssignmentConflict(ControllerMap controllerMap, bool skipDisabledMaps) { }

	// RVA: 0x1A73730 Offset: 0x1A72930 VA: 0x181A73730 Slot: 18
	public virtual bool DoesElementAssignmentConflict(ActionElementMap actionElementMap, bool skipDisabledMaps) { }

	// RVA: 0x1A73890 Offset: 0x1A72A90 VA: 0x181A73890 Slot: 19
	public virtual bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) { }

	// RVA: 0x1A73DA0 Offset: 0x1A72FA0 VA: 0x181A73DA0
	public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerMap controllerMap) { }

	// RVA: 0x1A73CC0 Offset: 0x1A72EC0 VA: 0x181A73CC0
	public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ActionElementMap actionElementMap) { }

	// RVA: 0x1A73DC0 Offset: 0x1A72FC0 VA: 0x181A73DC0
	public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck) { }

	// RVA: 0x1A73E10 Offset: 0x1A73010 VA: 0x181A73E10 Slot: 20
	public virtual IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps) { }

	// RVA: 0x1A73EA0 Offset: 0x1A730A0 VA: 0x181A73EA0 Slot: 21
	public virtual IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps) { }

	// RVA: 0x1A73CE0 Offset: 0x1A72EE0 VA: 0x181A73CE0 Slot: 22
	public virtual IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) { }

	// RVA: 0x1A79BE0 Offset: 0x1A78DE0 VA: 0x181A79BE0
	public int RemoveElementAssignmentConflicts(ControllerMap controllerMap) { }

	// RVA: 0x1A7A0D0 Offset: 0x1A792D0 VA: 0x181A7A0D0
	public int RemoveElementAssignmentConflicts(ActionElementMap actionElementMap) { }

	// RVA: 0x1A79B90 Offset: 0x1A78D90 VA: 0x181A79B90
	public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck) { }

	// RVA: 0x1A79C00 Offset: 0x1A78E00 VA: 0x181A79C00 Slot: 23
	public virtual int RemoveElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps) { }

	// RVA: 0x1A7A0F0 Offset: 0x1A792F0 VA: 0x181A7A0F0 Slot: 24
	public virtual int RemoveElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps) { }

	// RVA: 0x1A79E80 Offset: 0x1A79080 VA: 0x181A79E80 Slot: 25
	public virtual int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) { }

	// RVA: 0x1A73460 Offset: 0x1A72660 VA: 0x181A73460
	public int DisableElementAssignmentConflicts(ControllerMap controllerMap) { }

	// RVA: 0x1A731B0 Offset: 0x1A723B0 VA: 0x181A731B0
	public int DisableElementAssignmentConflicts(ActionElementMap actionElementMap) { }

	// RVA: 0x1A73270 Offset: 0x1A72470 VA: 0x181A73270
	public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck) { }

	// RVA: 0x1A73600 Offset: 0x1A72800 VA: 0x181A73600
	public int DisableElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps) { }

	// RVA: 0x1A73520 Offset: 0x1A72720 VA: 0x181A73520
	public int DisableElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps) { }

	// RVA: 0x1A73360 Offset: 0x1A72560 VA: 0x181A73360
	public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) { }

	// RVA: 0x1A79600 Offset: 0x1A78800 VA: 0x181A79600 Slot: 26
	internal virtual int NTMMlzeFiamrGmXxjaSzBFWfhqWA(ControllerMap , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1A79850 Offset: 0x1A78A50 VA: 0x181A79850 Slot: 27
	internal virtual int NTMMlzeFiamrGmXxjaSzBFWfhqWA(ActionElementMap , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1A793F0 Offset: 0x1A785F0 VA: 0x181A793F0 Slot: 28
	internal virtual int NTMMlzeFiamrGmXxjaSzBFWfhqWA(ElementAssignmentConflictCheck , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1A74E70 Offset: 0x1A74070 VA: 0x181A74E70
	public int ForEachElementAssignmentConflict(ControllerMap controllerMap, Action<ActionElementMap> actionToPerform) { }

	// RVA: 0x1A751B0 Offset: 0x1A743B0 VA: 0x181A751B0
	public int ForEachElementAssignmentConflict(ActionElementMap actionElementMap, Action<ActionElementMap> actionToPerform) { }

	// RVA: 0x1A74E20 Offset: 0x1A74020 VA: 0x181A74E20
	public int ForEachElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, Action<ActionElementMap> actionToPerform) { }

	// RVA: 0x1A74E90 Offset: 0x1A74090 VA: 0x181A74E90
	public int ForEachElementAssignmentConflict(ControllerMap controllerMap, Action<ActionElementMap> actionToPerform, bool skipDisabledMaps) { }

	// RVA: 0x1A754A0 Offset: 0x1A746A0 VA: 0x181A754A0
	public int ForEachElementAssignmentConflict(ActionElementMap actionElementMap, Action<ActionElementMap> actionToPerform, bool skipDisabledMaps) { }

	// RVA: 0x1A751D0 Offset: 0x1A743D0 VA: 0x181A751D0
	public int ForEachElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, Action<ActionElementMap> actionToPerform, bool skipDisabledMaps) { }

	// RVA: 0x1A76850 Offset: 0x1A75A50 VA: 0x181A76850
	public string[] GetButtonNames() { }

	// RVA: 0x1A7B7B0 Offset: 0x1A7A9B0 VA: 0x181A7B7B0
	public string ToXmlString() { }

	// RVA: 0x1A7B610 Offset: 0x1A7A810 VA: 0x181A7B610
	public string ToJsonString() { }

	// RVA: 0x1A7B1A0 Offset: 0x1A7A3A0 VA: 0x181A7B1A0
	public ControllerTemplateMap ToControllerTemplateMap(Guid templateTypeGuid) { }

	// RVA: -1 Offset: -1
	public ControllerTemplateMap ToControllerTemplateMap<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94F620 Offset: 0x94E820 VA: 0x18094F620
	|-ControllerMap.ToControllerTemplateMap<object>
	*/

	// RVA: 0x1A7B3D0 Offset: 0x1A7A5D0 VA: 0x181A7B3D0
	public ControllerTemplateMap ToControllerTemplateMap(Type templateInterfaceType) { }

	// RVA: 0x1A79020 Offset: 0x1A78220 VA: 0x181A79020
	private ControllerTemplateMap JByKgZgSVfAMxptFCqcamYTCmnof(IControllerTemplate ) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	internal AList<ActionElementMap> ornPVRwqzmNEgtXqqdnwunxxMtqn() { }

	// RVA: 0x1A7BA10 Offset: 0x1A7AC10 VA: 0x181A7BA10 Slot: 29
	internal virtual bool ZHWeqCluDWFCjNfqOtXWjsZwTABP(ActionElementMap ) { }

	// RVA: 0x1A7D690 Offset: 0x1A7C890 VA: 0x181A7D690 Slot: 30
	internal virtual int iUUSSzAmoWikZSIRrVGZkUcDGZiS(List<ActionElementMap> , bool ) { }

	// RVA: 0x1A7ACB0 Offset: 0x1A79EB0 VA: 0x181A7ACB0 Slot: 31
	internal virtual ActionElementMap RldBHIXESyFSYGmmTbrsCKiSSnqsA(int , int , ControllerElementType ) { }

	// RVA: 0x1A7BFE0 Offset: 0x1A7B1E0 VA: 0x181A7BFE0 Slot: 32
	internal virtual int aDVjYzDmrWSHRmekfovRjQqnTeuVA(int , List<ActionElementMap> , bool ) { }

	// RVA: 0x1A7DD50 Offset: 0x1A7CF50 VA: 0x181A7DD50 Slot: 33
	internal virtual bool ytrkuqNbDMvjilhuxxpSRclEIwLX(int , int , ControllerElementType ) { }

	// RVA: 0x1A74B10 Offset: 0x1A73D10 VA: 0x181A74B10 Slot: 34
	internal virtual int FSfMbVDryDeyQIpCIjsLPlalFmcD(int , int , ControllerElementType ) { }

	// RVA: 0x1A75930 Offset: 0x1A74B30 VA: 0x181A75930
	internal int FsGyXSVYXAkxzUcTBrguoIXMVcXI(int ) { }

	// RVA: 0x1A7DE20 Offset: 0x1A7D020 VA: 0x181A7DE20
	internal int zaYVhkyFCEegJoyfFLclKbknihnT(bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1A7DBC0 Offset: 0x1A7CDC0 VA: 0x181A7DBC0
	internal int pLaznvplJGeCGeojOxhyOEbubmQqA(int , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1A70F40 Offset: 0x1A70140 VA: 0x181A70F40 Slot: 35
	internal virtual int AMlBNTDDCrqwZJYbmmfQhezsErp(int , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1A7C170 Offset: 0x1A7B370 VA: 0x181A7C170 Slot: 36
	internal virtual ActionElementMap aQqIXjMOflACDFsaVnsINsitGPaX(IControllerElementTarget , bool , int , bool , out bool ) { }

	// RVA: 0x1A7D3D0 Offset: 0x1A7C5D0 VA: 0x181A7D3D0 Slot: 37
	internal virtual int gwJUVsXssesjpCNouhFmiWIlgxts(IControllerElementTarget , bool , int , bool , List<ActionElementMap> , bool , out bool ) { }

	// RVA: 0x1A7C5A0 Offset: 0x1A7B7A0 VA: 0x181A7C5A0
	internal void fZZtKQfNxmcInZOWBgoDqkKEiFwK(int , ControllerElementType ) { }

	// RVA: 0x1A7DF80 Offset: 0x1A7D180 VA: 0x181A7DF80 Slot: 38
	internal virtual bool zcwIffTIQRIZFZeomgCdhlmTJYHn(ActionElementMap ) { }

	// RVA: 0x1A7AF90 Offset: 0x1A7A190 VA: 0x181A7AF90
	internal bool SjAjhTKMfYelIxiIvLopURIEuUmD(IControllerElementTarget ) { }

	// RVA: 0x1A7C3E0 Offset: 0x1A7B5E0 VA: 0x181A7C3E0
	internal bool dAZZESqaGdFnsEXwCHusqKbbbZeq(string ) { }

	// RVA: 0x1A7D7F0 Offset: 0x1A7C9F0 VA: 0x181A7D7F0
	internal bool joDtkJceWmKmLWPzZKYPdEgXhOKp(string ) { }

	// RVA: 0x1A79B00 Offset: 0x1A78D00 VA: 0x181A79B00
	internal void QDvGwdJKUlMHqtiJWbTULWXkbRsm(ActionElementMap ) { }

	// RVA: 0x1A79A90 Offset: 0x1A78C90 VA: 0x181A79A90
	internal void OykFpNDytVdmqtQWMmfGsYxltjbi(int ) { }

	// RVA: 0x1A72DE0 Offset: 0x1A71FE0 VA: 0x181A72DE0
	internal void DLNIKbsqBSKPrTwfqsFMihSrDfAG(int , ActionElementMap ) { }

	// RVA: 0x1A7C370 Offset: 0x1A7B570 VA: 0x181A7C370
	internal static void aUSwNpPocfBjNwGRsDAWIpILqbtwA(ActionElementMap , int , Pole , int , ControllerElementType , AxisRange , bool ) { }

	// RVA: 0x1A710C0 Offset: 0x1A702C0 VA: 0x181A710C0
	protected void BakeElementMap(ActionElementMap map) { }

	// RVA: 0x1A79110 Offset: 0x1A78310 VA: 0x181A79110 Slot: 39
	internal virtual bool MQHErEylLpkabJiPJFPMzIMISIct(SerializedObject ) { }

	// RVA: 0x1A71410 Offset: 0x1A70610 VA: 0x181A71410 Slot: 40
	internal virtual void CHlQrZhwuPdYxNWJlUTNgThCUzEf(SerializedObject ) { }

	// RVA: 0x1A759F0 Offset: 0x1A74BF0 VA: 0x181A759F0
	private bool GVZPUVYixEobwsjtpHNKxcJAqrKI(ControllerElementType ) { }

	// RVA: 0x1A7B950 Offset: 0x1A7AB50 VA: 0x181A7B950
	private void XtTaElgOtdsbAAktmgxcucADvGgpA(int , int ) { }

	// RVA: 0x1A7DB00 Offset: 0x1A7CD00 VA: 0x181A7DB00
	private void mPnXyWQnxfErNXPIrjXlwSjNKCYU(ActionElementMap ) { }

	// RVA: 0x1A7C820 Offset: 0x1A7BA20 VA: 0x181A7C820
	private void gYRcvqgBYSTvIcraNDwZKOsRYNyk(ActionElementMap , int ) { }

	// RVA: 0x1A799F0 Offset: 0x1A78BF0 VA: 0x181A799F0
	private int OPDLHySaBnJaerbMERgQAhQVoGUb(int ) { }

	// RVA: 0x1A7C510 Offset: 0x1A7B710 VA: 0x181A7C510
	private SerializedObject dDwdeldWYOLrnWiNJjDBHtCWImLzA() { }

	// RVA: 0x1A7B010 Offset: 0x1A7A210 VA: 0x181A7B010
	internal static ControllerMap TZpAtmoswOXHtgELCQOweYKzFlBS(ControllerType ) { }

	// RVA: 0x1A7D920 Offset: 0x1A7CB20 VA: 0x181A7D920
	internal static ControllerMap lGWmhHomWXbveZrwUXPmyDfZgavv(Controller , int , int ) { }

	// RVA: 0x1A72D70 Offset: 0x1A71F70 VA: 0x181A72D70
	public static ControllerMap CreateFromXml(ControllerType controllerType, string xmlString) { }

	// RVA: 0x1A72D00 Offset: 0x1A71F00 VA: 0x181A72D00
	public static ControllerMap CreateFromJson(ControllerType controllerType, string jsonString) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControllerMapWithAxes.zkHmXMnSodOYWnaXMjUejpDjDbHEA : IDisposable, IEnumerable, IEnumerable<ActionElementMap>, IEnumerator, IEnumerator<ActionElementMap> // TypeDefIndex: 6988
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ActionElementMap lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public ControllerMapWithAxes nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int RMJEoXtoZMtwULyaBvSFzYLhgaKj; // 0x30
	public int NGoDsrkiKABiOBzXCjjnCIXciAdse; // 0x34
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x38
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x39
	private IEnumerator<ActionElementMap> BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x40

	// Properties
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1A9F610 Offset: 0x1A9E810 VA: 0x181A9F610 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1A9F2B0 Offset: 0x1A9E4B0 VA: 0x181A9F2B0 Slot: 7
	private bool MoveNext() { }

	// RVA: 0x1A9F6A0 Offset: 0x1A9E8A0 VA: 0x181A9F6A0
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A9F5D0 Offset: 0x1A9E7D0 VA: 0x181A9F5D0 Slot: 9
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A9F510 Offset: 0x1A9E710 VA: 0x181A9F510 Slot: 6
	private IEnumerator<ActionElementMap> System.Collections.Generic.IEnumerable<Rewired.ActionElementMap>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1A9F510 Offset: 0x1A9E710 VA: 0x181A9F510 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControllerMapWithAxes.vBQtxOJTfcwuFhioTUXedtrsismv : IDisposable, IEnumerable, IEnumerator, IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6989
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ElementAssignmentConflictInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x14
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x40
	public ControllerMapWithAxes nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x48
	private ControllerMap CKLJUnnpndBsfdLuUgNsJpcsPydNA; // 0x50
	public ControllerMap XKggfxeXPxsBWhpmYdazjfymyqTx; // 0x58
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x60
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x61
	private IList<ActionElementMap> jnaFHzetMIjiyJdrzHeTBpNMnzti; // 0x68
	private int pyoWfSIWvBFJSOPXrCWiiyDaegKb; // 0x70
	private IEnumerator<ElementAssignmentConflictInfo> ZjMCsBmztIFLBJekJGcndCgeCEXkA; // 0x78
	private int UfzQbLEafFfAFdUEncbWeZaEdDCEB; // 0x80
	private ActionElementMap CRYLYfKLTstINRoTkLQLmBBwGAxt; // 0x88
	private int jebsgQRnnKyIMrCrCWuNDXIQhLhT; // 0x90

	// Properties
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xE7ACF0 Offset: 0xE79EF0 VA: 0x180E7ACF0
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1A9F1D0 Offset: 0x1A9E3D0 VA: 0x181A9F1D0 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1A9E940 Offset: 0x1A9DB40 VA: 0x181A9E940 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x1A9F260 Offset: 0x1A9E460 VA: 0x181A9F260
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x798F40 Offset: 0x798140 VA: 0x180798F40 Slot: 10
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A9F130 Offset: 0x1A9E330 VA: 0x181A9F130 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1A9F170 Offset: 0x1A9E370 VA: 0x181A9F170 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A9F060 Offset: 0x1A9E260 VA: 0x181A9F060 Slot: 9
	private IEnumerator<ElementAssignmentConflictInfo> System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1A9F060 Offset: 0x1A9E260 VA: 0x181A9F060 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControllerMapWithAxes.kVRqtjBDJbLHeDPmmaMtnqukbiDd : IDisposable, IEnumerable, IEnumerator, IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6990
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ElementAssignmentConflictInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x14
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x40
	public ControllerMapWithAxes nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x48
	private ActionElementMap eWszhrzTgmaZrKigKDnkYoAPWDCy; // 0x50
	public ActionElementMap JKEckpOxZnAYcfsBykRqnmrfUVCEA; // 0x58
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x60
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x61
	private IEnumerator<ElementAssignmentConflictInfo> BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x68
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x70

	// Properties
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xE7ACF0 Offset: 0xE79EF0 VA: 0x180E7ACF0
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1A9E620 Offset: 0x1A9D820 VA: 0x181A9E620 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1A9DF20 Offset: 0x1A9D120 VA: 0x181A9DF20 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x1A9E6B0 Offset: 0x1A9D8B0 VA: 0x181A9E6B0
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x798F40 Offset: 0x798140 VA: 0x180798F40 Slot: 10
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A9E580 Offset: 0x1A9D780 VA: 0x181A9E580 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1A9E5C0 Offset: 0x1A9D7C0 VA: 0x181A9E5C0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A9E4B0 Offset: 0x1A9D6B0 VA: 0x181A9E4B0 Slot: 9
	private IEnumerator<ElementAssignmentConflictInfo> System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1A9E4B0 Offset: 0x1A9D6B0 VA: 0x181A9E4B0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ControllerMapWithAxes.OBkzIjxQgCWWQtotQSECPWtUDFMJ : IDisposable, IEnumerable, IEnumerator, IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 6991
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ElementAssignmentConflictInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x14
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x40
	public ControllerMapWithAxes nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x48
	private ElementAssignmentConflictCheck zqwcQAKmowyacotoRHDevIvpNlyi; // 0x50
	public ElementAssignmentConflictCheck ejpVKkYVvFucluBNLhLsNxfggkay; // 0x88
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0xC0
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0xC1
	private ElementAssignment nabztmcYuDjNEVkjGgkjKHjmDUiX; // 0xC4
	private IEnumerator<ElementAssignmentConflictInfo> FrrinBtHtwjQHWNUKhBdvpNvuGOV; // 0xE8
	private int pPGgUESwNACgnGeuXdCQJJGRwcRF; // 0xF0

	// Properties
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xE7ACF0 Offset: 0xE79EF0 VA: 0x180E7ACF0
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1A97930 Offset: 0x1A96B30 VA: 0x181A97930 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1A97170 Offset: 0x1A96370 VA: 0x181A97170 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x1A97990 Offset: 0x1A96B90 VA: 0x181A97990
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x798F40 Offset: 0x798140 VA: 0x180798F40 Slot: 10
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A97890 Offset: 0x1A96A90 VA: 0x181A97890 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1A978D0 Offset: 0x1A96AD0 VA: 0x181A978D0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A97790 Offset: 0x1A96990 VA: 0x181A97790 Slot: 9
	private IEnumerator<ElementAssignmentConflictInfo> System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1A97790 Offset: 0x1A96990 VA: 0x181A97790 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Rewired
public abstract class ControllerMapWithAxes : ControllerMap // TypeDefIndex: 6992
{
	// Fields
	private readonly IList<ActionElementMap> ffFyFhZAoSFkdaYfPcbKWhBVuiYe; // 0x70
	private readonly ReadOnlyCollection<ActionElementMap> UJEKwAhHdntdPUMzttXKSXJlMDjk; // 0x78

	// Properties
	public int axisMapCount { get; }
	public IList<ActionElementMap> AxisMaps { get; }
	internal AList<ActionElementMap> nBYIrfqldljAyuOCIyeoNRdWXJlb { get; }

	// Methods

	// RVA: 0x1A8DD50 Offset: 0x1A8CF50 VA: 0x181A8DD50
	public int get_axisMapCount() { }

	// RVA: 0x1A8DCB0 Offset: 0x1A8CEB0 VA: 0x181A8DCB0
	public IList<ActionElementMap> get_AxisMaps() { }

	// RVA: 0x1A8D6E0 Offset: 0x1A8C8E0 VA: 0x181A8D6E0
	public void .ctor() { }

	// RVA: 0x1A8D4A0 Offset: 0x1A8C6A0 VA: 0x181A8D4A0
	public void .ctor(ControllerMapWithAxes ) { }

	// RVA: 0x1A88D40 Offset: 0x1A87F40 VA: 0x181A88D40 Slot: 4
	public override bool ContainsAction(int actionId) { }

	// RVA: 0x1A88E70 Offset: 0x1A88070 VA: 0x181A88E70 Slot: 5
	public override bool CreateElementMap(int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert, out ActionElementMap result) { }

	// RVA: 0x1A8CE20 Offset: 0x1A8C020 VA: 0x181A8CE20 Slot: 6
	public override bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert, out ActionElementMap result) { }

	// RVA: 0x1A895C0 Offset: 0x1A887C0 VA: 0x181A895C0 Slot: 7
	public override bool DeleteElementMap(int elementMapId) { }

	// RVA: 0x1A89750 Offset: 0x1A88950 VA: 0x181A89750 Slot: 8
	public override bool DeleteElementMapsWithAction(string actionName) { }

	// RVA: 0x1A89690 Offset: 0x1A88890 VA: 0x181A89690 Slot: 9
	public override bool DeleteElementMapsWithAction(int actionId) { }

	// RVA: 0x1A8B4A0 Offset: 0x1A8A6A0 VA: 0x181A8B4A0 Slot: 10
	public override ActionElementMap GetElementMap(int elementMapId) { }

	// RVA: 0x1A78900 Offset: 0x1A77B00 VA: 0x181A78900 Slot: 11
	public override ActionElementMap GetFirstElementMapWithAction(int actionId) { }

	// RVA: 0x1A8BB10 Offset: 0x1A8AD10 VA: 0x181A8BB10 Slot: 13
	public override ActionElementMap GetFirstElementMapWithAction(int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1A8E6D0 Offset: 0x1A8D8D0 VA: 0x181A8E6D0 Slot: 14
	internal override ActionElementMap yFIcKiIfboNUJoJRnmXMaBKhGseHA(Predicate<ActionElementMap> , bool ) { }

	// RVA: 0x1A8A400 Offset: 0x1A89600 VA: 0x181A8A400 Slot: 15
	internal override int GRhsozChvTCFCFkNCGzbMaDrLLMD(Predicate<ActionElementMap> , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1A88C80 Offset: 0x1A87E80 VA: 0x181A88C80 Slot: 16
	public override void ClearElementMaps() { }

	// RVA: 0x1A8A560 Offset: 0x1A89760 VA: 0x181A8A560
	public ActionElementMap GetAxisMap(int index) { }

	// RVA: 0x1A8B1D0 Offset: 0x1A8A3D0 VA: 0x181A8B1D0
	public ActionElementMap[] GetAxisMaps() { }

	// RVA: 0x1A8AEC0 Offset: 0x1A8A0C0 VA: 0x181A8AEC0
	public ActionElementMap[] GetAxisMaps(bool skipDisabledMaps) { }

	// RVA: 0x1A8B110 Offset: 0x1A8A310 VA: 0x181A8B110
	public int GetAxisMaps(bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1A8A670 Offset: 0x1A89870 VA: 0x181A8A670
	public ActionElementMap[] GetAxisMapsWithAction(string actionName) { }

	// RVA: 0x1A8AB90 Offset: 0x1A89D90 VA: 0x181A8AB90
	public ActionElementMap[] GetAxisMapsWithAction(int actionId) { }

	// RVA: 0x1A8ACE0 Offset: 0x1A89EE0 VA: 0x181A8ACE0
	public ActionElementMap[] GetAxisMapsWithAction(string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1A8A770 Offset: 0x1A89970 VA: 0x181A8A770
	public ActionElementMap[] GetAxisMapsWithAction(int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1A8ABA0 Offset: 0x1A89DA0 VA: 0x181A8ABA0
	public int GetAxisMapsWithAction(string actionName, List<ActionElementMap> results) { }

	// RVA: 0x1A8A650 Offset: 0x1A89850 VA: 0x181A8A650
	public int GetAxisMapsWithAction(int actionId, List<ActionElementMap> results) { }

	// RVA: 0x1A8AA70 Offset: 0x1A89C70 VA: 0x181A8AA70
	public int GetAxisMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1A8ADF0 Offset: 0x1A89FF0 VA: 0x181A8ADF0
	public int GetAxisMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1A88900 Offset: 0x1A87B00 VA: 0x181A88900
	public IEnumerable<ActionElementMap> AxisMapsWithAction(string actionName) { }

	// RVA: 0x1A888F0 Offset: 0x1A87AF0 VA: 0x181A888F0
	public IEnumerable<ActionElementMap> AxisMapsWithAction(int actionId) { }

	// RVA: 0x1A88850 Offset: 0x1A87A50 VA: 0x181A88850
	public IEnumerable<ActionElementMap> AxisMapsWithAction(string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1A88A00 Offset: 0x1A87C00 VA: 0x181A88A00
	public IEnumerable<ActionElementMap> AxisMapsWithAction(int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1A8B6B0 Offset: 0x1A8A8B0 VA: 0x181A8B6B0
	public ActionElementMap GetFirstAxisMapWithAction(int actionId) { }

	// RVA: 0x1A8B9C0 Offset: 0x1A8ABC0 VA: 0x181A8B9C0
	public ActionElementMap GetFirstAxisMapWithAction(string actionName) { }

	// RVA: 0x1A8B860 Offset: 0x1A8AA60 VA: 0x181A8B860
	public ActionElementMap GetFirstAxisMapWithAction(int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1A8B760 Offset: 0x1A8A960 VA: 0x181A8B760
	public ActionElementMap GetFirstAxisMapWithAction(string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1A8B600 Offset: 0x1A8A800 VA: 0x181A8B600
	public ActionElementMap GetFirstAxisMapMatch(Predicate<ActionElementMap> predicate) { }

	// RVA: 0x1A8D290 Offset: 0x1A8C490 VA: 0x181A8D290
	internal ActionElementMap YWEwLinZHiihBMeoqzKMwLPaIBUI(Predicate<ActionElementMap> , bool ) { }

	// RVA: 0x1A8A490 Offset: 0x1A89690 VA: 0x181A8A490
	public int GetAxisMapMatches(Predicate<ActionElementMap> predicate, List<ActionElementMap> results) { }

	// RVA: 0x1A89070 Offset: 0x1A88270 VA: 0x181A89070
	internal int CwSNHCxUcPcXmyjkofDmOPvwzane(Predicate<ActionElementMap> , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1A8A1D0 Offset: 0x1A893D0 VA: 0x181A8A1D0
	public void ForEachAxisMapMatch(Predicate<ActionElementMap> predicate, Action<ActionElementMap> actionToPerform) { }

	// RVA: 0x1A89530 Offset: 0x1A88730 VA: 0x181A89530
	public bool DeleteAxisMapsWithAction(string actionName) { }

	// RVA: 0x1A89330 Offset: 0x1A88530 VA: 0x181A89330
	public bool DeleteAxisMapsWithAction(int actionId) { }

	// RVA: 0x1A8D0D0 Offset: 0x1A8C2D0 VA: 0x181A8D0D0
	public int SetAllAxisMapsEnabled(bool state) { }

	// RVA: 0x1A899D0 Offset: 0x1A88BD0 VA: 0x181A899D0 Slot: 17
	public override bool DoesElementAssignmentConflict(ControllerMap controllerMap, bool skipDisabledMaps) { }

	// RVA: 0x1A89840 Offset: 0x1A88A40 VA: 0x181A89840 Slot: 18
	public override bool DoesElementAssignmentConflict(ActionElementMap actionElementMap, bool skipDisabledMaps) { }

	// RVA: 0x1A89C40 Offset: 0x1A88E40 VA: 0x181A89C40 Slot: 19
	public override bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) { }

	// RVA: 0x1A89F80 Offset: 0x1A89180 VA: 0x181A89F80 Slot: 20
	public override IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps) { }

	// RVA: 0x1A8A020 Offset: 0x1A89220 VA: 0x181A8A020 Slot: 21
	public override IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps) { }

	// RVA: 0x1A89EB0 Offset: 0x1A890B0 VA: 0x181A89EB0 Slot: 22
	public override IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) { }

	// RVA: 0x1A8C640 Offset: 0x1A8B840 VA: 0x181A8C640 Slot: 23
	public override int RemoveElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps) { }

	// RVA: 0x1A8C920 Offset: 0x1A8BB20 VA: 0x181A8C920 Slot: 24
	public override int RemoveElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps) { }

	// RVA: 0x1A8CB10 Offset: 0x1A8BD10 VA: 0x181A8CB10 Slot: 25
	public override int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) { }

	// RVA: 0x1A8C2B0 Offset: 0x1A8B4B0 VA: 0x181A8C2B0 Slot: 26
	internal override int NTMMlzeFiamrGmXxjaSzBFWfhqWA(ControllerMap , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1A8C0B0 Offset: 0x1A8B2B0 VA: 0x181A8C0B0 Slot: 27
	internal override int NTMMlzeFiamrGmXxjaSzBFWfhqWA(ActionElementMap , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1A8BDF0 Offset: 0x1A8AFF0 VA: 0x181A8BDF0 Slot: 28
	internal override int NTMMlzeFiamrGmXxjaSzBFWfhqWA(ElementAssignmentConflictCheck , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1A8B280 Offset: 0x1A8A480 VA: 0x181A8B280
	public string[] GetAxisNames() { }

	// RVA: 0x1A8E260 Offset: 0x1A8D460 VA: 0x181A8E260
	internal AList<ActionElementMap> qozjrGZWgjvOOWBTxUkBOskbFhnM() { }

	// RVA: 0x1A8D410 Offset: 0x1A8C610 VA: 0x181A8D410 Slot: 29
	internal override bool ZHWeqCluDWFCjNfqOtXWjsZwTABP(ActionElementMap ) { }

	// RVA: 0x1A8E010 Offset: 0x1A8D210 VA: 0x181A8E010 Slot: 30
	internal override int iUUSSzAmoWikZSIRrVGZkUcDGZiS(List<ActionElementMap> , bool ) { }

	// RVA: 0x1A8D010 Offset: 0x1A8C210 VA: 0x181A8D010 Slot: 31
	internal override ActionElementMap RldBHIXESyFSYGmmTbrsCKiSSnqsA(int , int , ControllerElementType ) { }

	// RVA: 0x1A8D7A0 Offset: 0x1A8C9A0 VA: 0x181A8D7A0 Slot: 32
	internal override int aDVjYzDmrWSHRmekfovRjQqnTeuVA(int , List<ActionElementMap> , bool ) { }

	// RVA: 0x1A8E720 Offset: 0x1A8D920 VA: 0x181A8E720 Slot: 33
	internal override bool ytrkuqNbDMvjilhuxxpSRclEIwLX(int , int , ControllerElementType ) { }

	// RVA: 0x1A8A0C0 Offset: 0x1A892C0 VA: 0x181A8A0C0 Slot: 34
	internal override int FSfMbVDryDeyQIpCIjsLPlalFmcD(int , int , ControllerElementType ) { }

	// RVA: 0x1A8E140 Offset: 0x1A8D340 VA: 0x181A8E140
	internal int lNEazxzQBgWPReaWrgYbGrmKFEQt(int ) { }

	// RVA: 0x1A8E2F0 Offset: 0x1A8D4F0 VA: 0x181A8E2F0
	internal int ujGtSToftBFrTwIFWdEmspYjoibl(bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1A8E4C0 Offset: 0x1A8D6C0 VA: 0x181A8E4C0
	internal int vkGZtdKCiHYyFqJziMMFcdDDgdqL(int , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1A886D0 Offset: 0x1A878D0 VA: 0x181A886D0 Slot: 35
	internal override int AMlBNTDDCrqwZJYbmmfQhezsErp(int , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1A8D9C0 Offset: 0x1A8CBC0 VA: 0x181A8D9C0 Slot: 36
	internal override ActionElementMap aQqIXjMOflACDFsaVnsINsitGPaX(IControllerElementTarget , bool , int , bool , out bool ) { }

	// RVA: 0x1A8DE00 Offset: 0x1A8D000 VA: 0x181A8DE00 Slot: 37
	internal override int gwJUVsXssesjpCNouhFmiWIlgxts(IControllerElementTarget , bool , int , bool , List<ActionElementMap> , bool , out bool ) { }

	// RVA: 0x1A8E830 Offset: 0x1A8DA30 VA: 0x181A8E830 Slot: 38
	internal override bool zcwIffTIQRIZFZeomgCdhlmTJYHn(ActionElementMap ) { }

	// RVA: 0x1A8A480 Offset: 0x1A89680 VA: 0x181A8A480
	private bool GVZPUVYixEobwsjtpHNKxcJAqrKI(ControllerElementType ) { }

	// RVA: 0x1A8C540 Offset: 0x1A8B740 VA: 0x181A8C540
	private void NUySQTNOjMsoMXGHCjXrfRrzcbYj(int , int ) { }

	// RVA: 0x1A8E1F0 Offset: 0x1A8D3F0 VA: 0x181A8E1F0
	private void nfLbegaCFEEAeJXofZJLemTaKOaX(ActionElementMap ) { }

	// RVA: 0x1A8DB80 Offset: 0x1A8CD80 VA: 0x181A8DB80
	private void cYVWhiiffuZutxHOuXSLKYWInEuB(ActionElementMap , int ) { }

	// RVA: 0x1A88AA0 Offset: 0x1A87CA0 VA: 0x181A88AA0 Slot: 40
	internal override void CHlQrZhwuPdYxNWJlUTNgThCUzEf(SerializedObject ) { }

	// RVA: 0x1A8BC60 Offset: 0x1A8AE60 VA: 0x181A8BC60 Slot: 39
	internal override bool MQHErEylLpkabJiPJFPMzIMISIct(SerializedObject ) { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x1A8C630 Offset: 0x1A8B830 VA: 0x181A8C630
	private IEnumerable<ElementAssignmentConflictInfo> PnMosMJCrGOUcFOILvclXtNcvbem(ControllerMap , bool ) { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x1A8D280 Offset: 0x1A8C480 VA: 0x181A8D280
	private IEnumerable<ElementAssignmentConflictInfo> UhSmNPTQLinwgIhzileKXlsycjrQ(ActionElementMap , bool ) { }

	[DebuggerHidden]
	[CompilerGenerated]
	// RVA: 0x1A89E70 Offset: 0x1A89070 VA: 0x181A89E70
	private IEnumerable<ElementAssignmentConflictInfo> EcIRbfsXGdsYyKhcQMuDxXKObSmu(ElementAssignmentConflictCheck , bool ) { }
}

// Namespace: Rewired
public sealed class KeyboardMap : ControllerMap // TypeDefIndex: 6993
{
	// Methods

	// RVA: 0x1A96E60 Offset: 0x1A96060 VA: 0x181A96E60
	public void .ctor() { }

	// RVA: 0x1A96E50 Offset: 0x1A96050 VA: 0x181A96E50
	public void .ctor(KeyboardMap ) { }

	// RVA: 0x1A96DB0 Offset: 0x1A95FB0 VA: 0x181A96DB0
	internal void ehoXLQFRGIdEZSCicVmPCYCFbnUh(Guid , int , int ) { }

	// RVA: 0x1A96E80 Offset: 0x1A96080 VA: 0x181A96E80
	internal static KeyboardMap lGWmhHomWXbveZrwUXPmyDfZgavv(Guid , int , int ) { }
}

// Namespace: Rewired
public sealed class MouseMap : ControllerMapWithAxes // TypeDefIndex: 6994
{
	// Methods

	// RVA: 0x1A970B0 Offset: 0x1A962B0 VA: 0x181A970B0
	public void .ctor() { }

	// RVA: 0x1A96D80 Offset: 0x1A95F80 VA: 0x181A96D80
	public void .ctor(MouseMap ) { }

	// RVA: 0x1A96DB0 Offset: 0x1A95FB0 VA: 0x181A96DB0
	internal void ehoXLQFRGIdEZSCicVmPCYCFbnUh(Guid , int , int ) { }

	// RVA: 0x1A970E0 Offset: 0x1A962E0 VA: 0x181A970E0
	internal static MouseMap lGWmhHomWXbveZrwUXPmyDfZgavv(Guid , int , int ) { }
}

// Namespace: Rewired
public sealed class JoystickMap : ControllerMapWithAxes // TypeDefIndex: 6995
{
	// Methods

	// RVA: 0x1A96D90 Offset: 0x1A95F90 VA: 0x181A96D90
	public void .ctor() { }

	// RVA: 0x1A96D80 Offset: 0x1A95F80 VA: 0x181A96D80
	public void .ctor(JoystickMap ) { }

	// RVA: 0x1A96DB0 Offset: 0x1A95FB0 VA: 0x181A96DB0
	internal void ehoXLQFRGIdEZSCicVmPCYCFbnUh(Guid , int , int ) { }

	// RVA: 0x1A96DC0 Offset: 0x1A95FC0 VA: 0x181A96DC0
	internal static JoystickMap lGWmhHomWXbveZrwUXPmyDfZgavv(Guid , int , int ) { }
}

// Namespace: Rewired
public sealed class CustomControllerMap : ControllerMapWithAxes // TypeDefIndex: 6996
{
	// Fields
	private int WNlEuDeNBTQbjhsTdxaxQPDhtnlab; // 0x80

	// Properties
	public int sourceControllerId { get; set; }

	// Methods

	// RVA: 0x1A6BA60 Offset: 0x1A6AC60 VA: 0x181A6BA60
	public int get_sourceControllerId() { }

	// RVA: 0x1A6BA80 Offset: 0x1A6AC80 VA: 0x181A6BA80
	public void set_sourceControllerId(int value) { }

	// RVA: 0x1A8E910 Offset: 0x1A8DB10 VA: 0x181A8E910
	public void .ctor() { }

	// RVA: 0x1A8E8D0 Offset: 0x1A8DAD0 VA: 0x181A8E8D0
	public void .ctor(CustomControllerMap ) { }

	// RVA: 0x1A8E930 Offset: 0x1A8DB30 VA: 0x181A8E930
	internal void ehoXLQFRGIdEZSCicVmPCYCFbnUh(Guid , int , int , int ) { }

	// RVA: 0x1A8E950 Offset: 0x1A8DB50 VA: 0x181A8E950
	internal static CustomControllerMap lGWmhHomWXbveZrwUXPmyDfZgavv(Guid , int , int , int ) { }
}

// Namespace: 
[DefaultMember("Item")]
internal interface dyCkQiVTJnvQvTqPOHWiKoiJbMucA // TypeDefIndex: 6997
{
	// Properties
	public abstract ControllerMap VcNaKpZiSjfBNHLSrIsuQryjanXbb { get; }
	public abstract int ZGDajhyxNzhNBiKJhEAsWFQbqjCfA { get; }
	public abstract IList<ControllerMap> UbwaUildTQmHeGoEWpQzhgWHnPHB { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ControllerMap DqTTDBNrLYGAlGMLwfxhSdzmqObD(int );

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int JkWSBcRXMqksDMwnqGuHKOiabncT();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IList<ControllerMap> mQScDUfrylLxApglbyzXUbwBiwIv();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IEnumerable<ControllerMap> daXBUMGvnjAzjRmJQjGKdyprbQZhA(int );

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IList<> TaYplzHOEfiMUptAVxITXadAESrY<>();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-dyCkQiVTJnvQvTqPOHWiKoiJbMucA.TaYplzHOEfiMUptAVxITXadAESrY<object>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void xXDAAgkpHyujExYwkSGAdhBokBcFb(ControllerMap , BoolOption );

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void ENhafsOIfNJWwkaRuCtXEgnCwFwLA(ControllerMap );

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ENhafsOIfNJWwkaRuCtXEgnCwFwLA(int );

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void ENhafsOIfNJWwkaRuCtXEgnCwFwLA(int , int );

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void bVbYCLTLzuJHVCrRzhNQRkvEWyIO(int );

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int ZVMYpYkqYXFpfBIVblsDvJTirAucA(int );

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int ZVMYpYkqYXFpfBIVblsDvJTirAucA(int , int );

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool HfHQDEyJodmDgQKMBJDYDJavMFDLA(int );

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool HfHQDEyJodmDgQKMBJDYDJavMFDLA(int , int );

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void emOgGAIJPwqUQQPmEukEIzmDcQhcb(bool );

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void emOgGAIJPwqUQQPmEukEIzmDcQhcb(int , bool );

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void txoSmVjqwTkAvGnLdjpaihQImMfm(int , bool );

	// RVA: -1 Offset: -1 Slot: 17
	public abstract int gRSiccKQXgxdSvYePTTbMwigHJrj(bool );

	// RVA: -1 Offset: -1 Slot: 18
	public abstract int rNSAZrxavUFBRDFJZINegJRGjUlxb(bool , int );

	// RVA: -1 Offset: -1 Slot: 19
	public abstract int rNSAZrxavUFBRDFJZINegJRGjUlxb(bool , int , int );

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool AMVquASbqfjpwUCIzclAfroQQath(int );

	// RVA: -1 Offset: -1 Slot: 21
	public abstract ControllerMap LNpuGpNyMViGfELihBhTvXqMPFmx(int );

	// RVA: -1 Offset: -1 Slot: 22
	public abstract ControllerMap LNpuGpNyMViGfELihBhTvXqMPFmx(int , int );

	// RVA: -1 Offset: -1 Slot: 23
	public abstract ControllerMap[] TaYplzHOEfiMUptAVxITXadAESrY();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract ControllerMap fpbDqMQEowHlmhQBUUDBiPIVEBuM(int );

	// RVA: -1 Offset: -1 Slot: 25
	public abstract ControllerMap[] PsKZzDeRElVNElsNBpHjZzgZJFDD(int );

	// RVA: -1 Offset: -1 Slot: 26
	public abstract int PsKZzDeRElVNElsNBpHjZzgZJFDD(int , List<ControllerMap> , bool );

	// RVA: -1 Offset: -1 Slot: 27
	public abstract int PsKZzDeRElVNElsNBpHjZzgZJFDD<>(int , List<> , bool );
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-dyCkQiVTJnvQvTqPOHWiKoiJbMucA.PsKZzDeRElVNElsNBpHjZzgZJFDD<object>
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public abstract int TaYplzHOEfiMUptAVxITXadAESrY(List<ControllerMap> , bool );

	// RVA: -1 Offset: -1 Slot: 29
	public abstract int TaYplzHOEfiMUptAVxITXadAESrY<>(List<> , bool );
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-dyCkQiVTJnvQvTqPOHWiKoiJbMucA.TaYplzHOEfiMUptAVxITXadAESrY<object>
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class VOLZYtSxBAfSvCRXgiPmhhdoQwVG.jjIjXENcTisIgbyMQDYlaOrHUMCC<> : IDisposable, IEnumerator, IEnumerator<> // TypeDefIndex: 6998
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x0
	private  lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x0
	public VOLZYtSxBAfSvCRXgiPmhhdoQwVG<> nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x0
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x0

	// Properties
	private  zvdZSMDIEfaCbWGLZgdKgiWmNoxcb { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG.jjIjXENcTisIgbyMQDYlaOrHUMCC<object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG.jjIjXENcTisIgbyMQDYlaOrHUMCC<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6EA20 Offset: 0xE6DC20 VA: 0x180E6EA20
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG.jjIjXENcTisIgbyMQDYlaOrHUMCC<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private  System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG.jjIjXENcTisIgbyMQDYlaOrHUMCC<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG.jjIjXENcTisIgbyMQDYlaOrHUMCC<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG.jjIjXENcTisIgbyMQDYlaOrHUMCC<object>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class VOLZYtSxBAfSvCRXgiPmhhdoQwVG.loCOBkYcmhLTqFBRnnRUXnVbfDZs<> : IDisposable, IEnumerable, IEnumerator, IEnumerable<ControllerMap>, IEnumerator<ControllerMap> // TypeDefIndex: 6999
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x0
	private ControllerMap lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x0
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x0
	private int wGBlZAeXywpnLTVAippvBHBjeoet; // 0x0
	public int VfSIvcbRWJkDHPWNlBkmlVmAhOrnA; // 0x0
	public VOLZYtSxBAfSvCRXgiPmhhdoQwVG<> nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x0
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x0

	// Properties
	private ControllerMap System.Collections.Generic.IEnumerator<Rewired.ControllerMap>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG.loCOBkYcmhLTqFBRnnRUXnVbfDZs<object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG.loCOBkYcmhLTqFBRnnRUXnVbfDZs<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6EAB0 Offset: 0xE6DCB0 VA: 0x180E6EAB0
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG.loCOBkYcmhLTqFBRnnRUXnVbfDZs<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private ControllerMap System.Collections.Generic.IEnumerator<Rewired.ControllerMap>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG.loCOBkYcmhLTqFBRnnRUXnVbfDZs<object>.System.Collections.Generic.IEnumerator<Rewired.ControllerMap>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG.loCOBkYcmhLTqFBRnnRUXnVbfDZs<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG.loCOBkYcmhLTqFBRnnRUXnVbfDZs<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private IEnumerator<ControllerMap> System.Collections.Generic.IEnumerable<Rewired.ControllerMap>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6EBA0 Offset: 0xE6DDA0 VA: 0x180E6EBA0
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG.loCOBkYcmhLTqFBRnnRUXnVbfDZs<object>.System.Collections.Generic.IEnumerable<Rewired.ControllerMap>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6EC70 Offset: 0xE6DE70 VA: 0x180E6EC70
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG.loCOBkYcmhLTqFBRnnRUXnVbfDZs<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[DefaultMember("Item")]
internal sealed class VOLZYtSxBAfSvCRXgiPmhhdoQwVG<> : IEnumerable, IEnumerable<>, dyCkQiVTJnvQvTqPOHWiKoiJbMucA // TypeDefIndex: 7000
{
	// Fields
	private readonly List<ControllerMap> bWkSXmYHEvCEdSsztRqKcbFNEhEQ; // 0x0
	private readonly IList<ControllerMap> FLzoCxcsPNIcwBNWBuarcZuKdrXF; // 0x0
	public readonly ControllerType XkDVpydTdKFGyaepLgJpPXsuRQFt; // 0x0
	public readonly int NDJCfPreMhWCOFQPsCzuOVGtkoBG; // 0x0
	private readonly List<> rEtjLIAzDGKOmjaGMxYEObAfSzeHA; // 0x0
	private readonly IList<> fynfJFhvEpOUXYhJkeWmpakLxPnVA; // 0x0

	// Properties
	private ControllerMap jxtGWpSSIvpEDEnHVMzzKaEhdWum { get; }
	private IList<ControllerMap> mnvFgjnCmZITQezualnAnvGkCVhK { get; }
	public IList<> UbwaUildTQmHeGoEWpQzhgWHnPHB { get; }
	public int ZGDajhyxNzhNBiKJhEAsWFQbqjCfA { get; }
	public  VcNaKpZiSjfBNHLSrIsuQryjanXbb { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	private ControllerMap LAfvcpfgHjxjmmBLUCDoCJGblQKXA(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF1DE0 Offset: 0xCF0FE0 VA: 0x180CF1DE0
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.LAfvcpfgHjxjmmBLUCDoCJGblQKXA
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private IList<ControllerMap> LdbldgcbdDEPOcCethtxKugwYHvRA() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.LdbldgcbdDEPOcCethtxKugwYHvRA
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private IEnumerable<ControllerMap> CMedQzCxCtboPQjAAMvyFaMZgOSNA(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF1850 Offset: 0xCF0A50 VA: 0x180CF1850
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.CMedQzCxCtboPQjAAMvyFaMZgOSNA
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void LcHAMTUOFyElTBcuwUtbSWRoBAnh(ControllerMap , BoolOption ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF2010 Offset: 0xCF1210 VA: 0x180CF2010
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.LcHAMTUOFyElTBcuwUtbSWRoBAnh
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private void qCZdGZTVnDMwPAZonVbXtycWDMPK(ControllerMap ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF2F00 Offset: 0xCF2100 VA: 0x180CF2F00
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.qCZdGZTVnDMwPAZonVbXtycWDMPK
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private ControllerMap oBQvnugsmwPeXLicvIypQYRnryBn(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF2A40 Offset: 0xCF1C40 VA: 0x180CF2A40
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.oBQvnugsmwPeXLicvIypQYRnryBn
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private ControllerMap oBQvnugsmwPeXLicvIypQYRnryBn(int , int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF2B10 Offset: 0xCF1D10 VA: 0x180CF2B10
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.oBQvnugsmwPeXLicvIypQYRnryBn
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private ControllerMap EWBfFiTdlKrgymljqsKkMGujxutS(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF1B80 Offset: 0xCF0D80 VA: 0x180CF1B80
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.EWBfFiTdlKrgymljqsKkMGujxutS
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private ControllerMap[] wYwUBEJbhXImaspOpboMsPZdSRYp() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF3310 Offset: 0xCF2510 VA: 0x180CF3310
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.wYwUBEJbhXImaspOpboMsPZdSRYp
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private int wYwUBEJbhXImaspOpboMsPZdSRYp(List<ControllerMap> , bool ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF3360 Offset: 0xCF2560 VA: 0x180CF3360
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.wYwUBEJbhXImaspOpboMsPZdSRYp
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private ControllerMap[] pPFMmkVgQIydVFlEQyGvYeYLiAQv(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF2DA0 Offset: 0xCF1FA0 VA: 0x180CF2DA0
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.pPFMmkVgQIydVFlEQyGvYeYLiAQv
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private int pPFMmkVgQIydVFlEQyGvYeYLiAQv(int , List<ControllerMap> , bool ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF2C40 Offset: 0xCF1E40 VA: 0x180CF2C40
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.pPFMmkVgQIydVFlEQyGvYeYLiAQv
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private IList<> wYwUBEJbhXImaspOpboMsPZdSRYp<>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F8070 Offset: 0x8F7270 VA: 0x1808F8070
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.wYwUBEJbhXImaspOpboMsPZdSRYp<object>
	*/

	// RVA: -1 Offset: -1 Slot: 33
	private int pPFMmkVgQIydVFlEQyGvYeYLiAQv<>(int , List<> , bool ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F7D60 Offset: 0x8F6F60 VA: 0x1808F7D60
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.pPFMmkVgQIydVFlEQyGvYeYLiAQv<object>
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private int wYwUBEJbhXImaspOpboMsPZdSRYp<>(List<> , bool ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F7EF0 Offset: 0x8F70F0 VA: 0x1808F7EF0
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.wYwUBEJbhXImaspOpboMsPZdSRYp<object>
	*/

	// RVA: -1 Offset: -1
	public IList<> mQScDUfrylLxApglbyzXUbwBiwIv() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.mQScDUfrylLxApglbyzXUbwBiwIv
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public int JkWSBcRXMqksDMwnqGuHKOiabncT() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF1DC0 Offset: 0xCF0FC0 VA: 0x180CF1DC0
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.JkWSBcRXMqksDMwnqGuHKOiabncT
	*/

	// RVA: -1 Offset: -1
	public  DqTTDBNrLYGAlGMLwfxhSdzmqObD(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF18E0 Offset: 0xCF0AE0 VA: 0x180CF18E0
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.DqTTDBNrLYGAlGMLwfxhSdzmqObD
	*/

	// RVA: -1 Offset: -1
	public void jWXOgjssRvRquBiRELbAnueIghhs(int ,  ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF29A0 Offset: 0xCF1BA0 VA: 0x180CF29A0
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.jWXOgjssRvRquBiRELbAnueIghhs
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF22D0 Offset: 0xCF14D0 VA: 0x180CF22D0
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void xXDAAgkpHyujExYwkSGAdhBokBcFb( , BoolOption ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF34D0 Offset: 0xCF26D0 VA: 0x180CF34D0
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.xXDAAgkpHyujExYwkSGAdhBokBcFb
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public void ENhafsOIfNJWwkaRuCtXEgnCwFwLA(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF1910 Offset: 0xCF0B10 VA: 0x180CF1910
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.ENhafsOIfNJWwkaRuCtXEgnCwFwLA
	*/

	// RVA: -1 Offset: -1
	public void ENhafsOIfNJWwkaRuCtXEgnCwFwLA( ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF1AF0 Offset: 0xCF0CF0 VA: 0x180CF1AF0
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.ENhafsOIfNJWwkaRuCtXEgnCwFwLA
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void ENhafsOIfNJWwkaRuCtXEgnCwFwLA(int , int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF19A0 Offset: 0xCF0BA0 VA: 0x180CF19A0
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.ENhafsOIfNJWwkaRuCtXEgnCwFwLA
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public void bVbYCLTLzuJHVCrRzhNQRkvEWyIO(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF2480 Offset: 0xCF1680 VA: 0x180CF2480
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.bVbYCLTLzuJHVCrRzhNQRkvEWyIO
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public int ZVMYpYkqYXFpfBIVblsDvJTirAucA(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF2230 Offset: 0xCF1430 VA: 0x180CF2230
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.ZVMYpYkqYXFpfBIVblsDvJTirAucA
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int ZVMYpYkqYXFpfBIVblsDvJTirAucA(int , int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF2140 Offset: 0xCF1340 VA: 0x180CF2140
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.ZVMYpYkqYXFpfBIVblsDvJTirAucA
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public bool HfHQDEyJodmDgQKMBJDYDJavMFDLA(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF1D10 Offset: 0xCF0F10 VA: 0x180CF1D10
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.HfHQDEyJodmDgQKMBJDYDJavMFDLA
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public bool HfHQDEyJodmDgQKMBJDYDJavMFDLA(int , int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF1CE0 Offset: 0xCF0EE0 VA: 0x180CF1CE0
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.HfHQDEyJodmDgQKMBJDYDJavMFDLA
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public void emOgGAIJPwqUQQPmEukEIzmDcQhcb(bool ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF26A0 Offset: 0xCF18A0 VA: 0x180CF26A0
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.emOgGAIJPwqUQQPmEukEIzmDcQhcb
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public void emOgGAIJPwqUQQPmEukEIzmDcQhcb(int , bool ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF2560 Offset: 0xCF1760 VA: 0x180CF2560
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.emOgGAIJPwqUQQPmEukEIzmDcQhcb
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public void txoSmVjqwTkAvGnLdjpaihQImMfm(int , bool ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF3180 Offset: 0xCF2380 VA: 0x180CF3180
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.txoSmVjqwTkAvGnLdjpaihQImMfm
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public IEnumerator<> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF1C50 Offset: 0xCF0E50 VA: 0x180CF1C50
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF20B0 Offset: 0xCF12B0 VA: 0x180CF20B0
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public  LNpuGpNyMViGfELihBhTvXqMPFmx(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF1E40 Offset: 0xCF1040 VA: 0x180CF1E40
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.LNpuGpNyMViGfELihBhTvXqMPFmx
	*/

	// RVA: -1 Offset: -1
	public  LNpuGpNyMViGfELihBhTvXqMPFmx(int , int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF1EF0 Offset: 0xCF10F0 VA: 0x180CF1EF0
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.LNpuGpNyMViGfELihBhTvXqMPFmx
	*/

	// RVA: -1 Offset: -1
	public  fpbDqMQEowHlmhQBUUDBiPIVEBuM(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF2840 Offset: 0xCF1A40 VA: 0x180CF2840
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.fpbDqMQEowHlmhQBUUDBiPIVEBuM
	*/

	// RVA: -1 Offset: -1 Slot: 26
	public bool AMVquASbqfjpwUCIzclAfroQQath(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF17B0 Offset: 0xCF09B0 VA: 0x180CF17B0
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.AMVquASbqfjpwUCIzclAfroQQath
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public int gRSiccKQXgxdSvYePTTbMwigHJrj(bool ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF28F0 Offset: 0xCF1AF0 VA: 0x180CF28F0
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.gRSiccKQXgxdSvYePTTbMwigHJrj
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public int rNSAZrxavUFBRDFJZINegJRGjUlxb(bool , int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF2FF0 Offset: 0xCF21F0 VA: 0x180CF2FF0
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.rNSAZrxavUFBRDFJZINegJRGjUlxb
	*/

	// RVA: -1 Offset: -1 Slot: 25
	public int rNSAZrxavUFBRDFJZINegJRGjUlxb(bool , int , int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF30B0 Offset: 0xCF22B0 VA: 0x180CF30B0
	|-VOLZYtSxBAfSvCRXgiPmhhdoQwVG<object>.rNSAZrxavUFBRDFJZINegJRGjUlxb
	*/
}

// Namespace: 
private enum HardwareControllerMap_Game.RGGbIgNBtPdYQDEqTCsVJftCuCTTA // TypeDefIndex: 7001
{
	// Fields
	public int value__; // 0x0
	public const HardwareControllerMap_Game.RGGbIgNBtPdYQDEqTCsVJftCuCTTA Error = 0;
	public const HardwareControllerMap_Game.RGGbIgNBtPdYQDEqTCsVJftCuCTTA FoundIndex = 1;
	public const HardwareControllerMap_Game.RGGbIgNBtPdYQDEqTCsVJftCuCTTA IsWholeElement = 2;
}

// Namespace: Rewired
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
[CustomObfuscation(rename = False)]
internal class HardwareControllerMap_Game // TypeDefIndex: 7002
{
	// Fields
	public readonly string controllerName; // 0x10
	public readonly HardwareControllerMapIdentifier hardwareMapIdentifier; // 0x18
	public readonly int customControllerSourceId; // 0x34
	public readonly ADictionary<int, ControllerElementIdentifier> elementIdentifiers; // 0x38
	public readonly ControllerElementIdentifier[] elementIdentifiers_cache; // 0x40
	public readonly ControllerElementIdentifier[] buttonElementIdentifiers_cache; // 0x48
	public readonly ControllerElementIdentifier[] axisElementIdentifiers_cache; // 0x50
	public readonly ControllerElementIdentifier[] axis2DElementIdentifiers_cache; // 0x58
	public readonly ControllerElementIdentifier[] hatElementIdentifiers_cache; // 0x60
	public readonly ControllerElementIdentifier[] dpadElementIdentifiers_cache; // 0x68
	public readonly IList<ControllerElementIdentifier> elementIdentifiers_readOnly; // 0x70
	public readonly IList<ControllerElementIdentifier> buttonElementIdentifiers_readOnly; // 0x78
	public readonly IList<ControllerElementIdentifier> axisElementIdentifiers_readOnly; // 0x80
	public readonly IList<ControllerElementIdentifier> axis2DElementIdentifiers_readOnly; // 0x88
	public readonly IList<ControllerElementIdentifier> hatElementIdentifiers_readOnly; // 0x90
	public readonly IList<ControllerElementIdentifier> dpadElementIdentifiers_readOnly; // 0x98
	public readonly int[] buttonElementIdentifierIds; // 0xA0
	public readonly int[] axisElementIdentifierIds; // 0xA8
	public readonly int[] axis2DElementIdentifierIds; // 0xB0
	public readonly int[] hatElementIdentifierIds; // 0xB8
	public readonly int[] dpadElementIdentifierIds; // 0xC0
	public readonly int elementIdentifierCount; // 0xC8
	public readonly int axisCount; // 0xCC
	public readonly int buttonCount; // 0xD0
	public readonly int compoundElementCount; // 0xD4
	public readonly int axis2DCount; // 0xD8
	public readonly int hatCount; // 0xDC
	public readonly int dpadCount; // 0xE0
	public readonly JoystickType[] joystickTypes; // 0xE8
	public readonly AxisCalibrationData[] hwAxisCalibrationData; // 0xF0
	public readonly AxisRange[] hwAxisRanges; // 0xF8
	public readonly HardwareAxisInfo[] hwAxisInfo; // 0x100
	public readonly HardwareButtonInfo[] hwButtonInfo; // 0x108
	public readonly HardwareJoystickMap.CompoundElement[] compoundElements; // 0x110
	private readonly DeviceLocalizationInfo ebTMLxoLwWDnKILCIJrzNFzktllj; // 0x118

	// Properties
	public DeviceLocalizationInfo deviceLocalizationInfo { get; }

	// Methods

	// RVA: 0x6ED510 Offset: 0x6EC710 VA: 0x1806ED510
	public DeviceLocalizationInfo get_deviceLocalizationInfo() { }

	// RVA: 0x1A906F0 Offset: 0x1A8F8F0 VA: 0x181A906F0
	public void .ctor(string , DeviceLocalizationInfo , int , ControllerElementIdentifier[] , int[] , int[] , AxisCalibrationData[] , AxisRange[] , HardwareAxisInfo[] , HardwareButtonInfo[] , HardwareJoystickMap.CompoundElement[] ) { }

	// RVA: 0x1A913F0 Offset: 0x1A905F0 VA: 0x181A913F0
	public void .ctor(string , DeviceLocalizationInfo , HardwareControllerMapIdentifier , JoystickType[] , ControllerElementIdentifier[] , int[] , int[] , AxisCalibrationData[] , AxisRange[] , HardwareAxisInfo[] , HardwareButtonInfo[] , HardwareJoystickMap.CompoundElement[] ) { }

	// RVA: 0x1A90350 Offset: 0x1A8F550 VA: 0x181A90350
	public void .ctor(string , HardwareControllerMapIdentifier , ControllerElementIdentifier[] , int[] , int[] , AxisCalibrationData[] , AxisRange[] , HardwareAxisInfo[] , HardwareButtonInfo[] , HardwareJoystickMap.CompoundElement[] ) { }

	// RVA: 0x1A90780 Offset: 0x1A8F980 VA: 0x181A90780
	private void .ctor(string , DeviceLocalizationInfo , ControllerElementIdentifier[] , int[] , int[] , AxisCalibrationData[] , AxisRange[] , HardwareAxisInfo[] , HardwareButtonInfo[] , HardwareJoystickMap.CompoundElement[] ) { }

	// RVA: 0x1A8FAE0 Offset: 0x1A8ECE0 VA: 0x181A8FAE0
	public string GetElementIdentifierName(int elementIdentifierId) { }

	// RVA: 0x1A8FC20 Offset: 0x1A8EE20 VA: 0x181A8FC20
	public string GetElementIdentifierPositiveName(int elementIdentifierId) { }

	// RVA: 0x1A8FB80 Offset: 0x1A8ED80 VA: 0x181A8FB80
	public string GetElementIdentifierNegativeName(int elementIdentifierId) { }

	// RVA: 0x1A8F5D0 Offset: 0x1A8E7D0 VA: 0x181A8F5D0
	public int GetAxisIndex(int elementIdentifierId) { }

	// RVA: 0x1A8F630 Offset: 0x1A8E830 VA: 0x181A8F630
	public int GetAxisIndex(string elementIdentifierName) { }

	// RVA: 0x1A8F7F0 Offset: 0x1A8E9F0 VA: 0x181A8F7F0
	public int GetButtonIndex(int elementIdentifierId) { }

	// RVA: 0x1A8F850 Offset: 0x1A8EA50 VA: 0x181A8F850
	public int GetButtonIndex(string elementIdentifierName) { }

	// RVA: 0x1A8FA30 Offset: 0x1A8EC30 VA: 0x181A8FA30
	public ControllerElementIdentifier GetElementIdentifierById(int id) { }

	// RVA: 0x1A8F780 Offset: 0x1A8E980 VA: 0x181A8F780
	public ControllerElementIdentifier GetButtonElementIdentifierById(int id) { }

	// RVA: 0x1A8F560 Offset: 0x1A8E760 VA: 0x181A8F560
	public ControllerElementIdentifier GetAxisElementIdentifierById(int id) { }

	// RVA: 0x1A8F4D0 Offset: 0x1A8E6D0 VA: 0x181A8F4D0
	public HardwareJoystickMap.CompoundElement GetAxis2DData(int index) { }

	// RVA: 0x1A8FD60 Offset: 0x1A8EF60 VA: 0x181A8FD60
	public HardwareJoystickMap.CompoundElement GetHatData(int index) { }

	// RVA: 0x1A8F9A0 Offset: 0x1A8EBA0 VA: 0x181A8F9A0
	public HardwareJoystickMap.CompoundElement GetDPadData(int index) { }

	// RVA: 0x1A8FCC0 Offset: 0x1A8EEC0 VA: 0x181A8FCC0
	public ControllerElementType GetElementType(int elementIdentifierId) { }

	// RVA: 0x1A90140 Offset: 0x1A8F340 VA: 0x181A90140
	public bool TryGetCompoundElementMemberCombinedLocalizedName(IList<ActionElementMap> aems, out string result) { }

	// RVA: 0x1A8FE60 Offset: 0x1A8F060 VA: 0x181A8FE60
	public bool TryGetCompoundElementMemberCombinedGlyph(IList<ActionElementMap> aems, bool getGlyph, bool getFinalKey, out object glyphResult, out string finalKey) { }

	// RVA: 0x1A8FDF0 Offset: 0x1A8EFF0 VA: 0x181A8FDF0
	private int OgSQejjhIiGULdidOdcFbecBSFrwA(ControllerElementIdentifier[] , int ) { }

	// RVA: 0x1A91520 Offset: 0x1A90720 VA: 0x181A91520
	private static HardwareControllerMap_Game.RGGbIgNBtPdYQDEqTCsVJftCuCTTA ymdQTrzrZRbtQwcinhJLDCSjsHxUA(HardwareJoystickMap.CompoundElement , ControllerElementIdentifier , IList<ActionElementMap> , out int ) { }
}

// Namespace: Rewired
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal class HardwareJoystickMap_InputManager // TypeDefIndex: 7003
{
	// Fields
	public string controllerName; // 0x10
	public readonly HardwareControllerMapIdentifier hardwareMapIdentifier; // 0x18
	public readonly HardwareJoystickMap.Platform map; // 0x38
	public readonly int buttonCount; // 0x40
	public readonly int axisCount; // 0x44
	public readonly ControllerElementIdentifier[] elementIdentifiers; // 0x48
	public readonly HardwareJoystickMap.CompoundElement[] compoundElements; // 0x50
	public bool useSystemName; // 0x58
	public readonly bool isUnknownController; // 0x59
	public readonly JoystickType[] joystickTypes; // 0x60
	private readonly DeviceLocalizationInfo ebTMLxoLwWDnKILCIJrzNFzktllj; // 0x68

	// Properties
	public DeviceLocalizationInfo deviceLocalizationInfo { get; }

	// Methods

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public DeviceLocalizationInfo get_deviceLocalizationInfo() { }

	// RVA: 0x1A920B0 Offset: 0x1A912B0 VA: 0x181A920B0
	public void .ctor(HardwareControllerMapIdentifier , JoystickType[] , DeviceLocalizationInfo , HardwareJoystickMap.Platform , string , int , int , int , HardwareJoystickMap.CompoundElement[] ) { }

	// RVA: 0x1A91930 Offset: 0x1A90B30 VA: 0x181A91930
	public HardwareControllerMap_Game ToGameHardwareControllerMap() { }
}

// Namespace: Rewired
[Serializable]
public sealed class InputAction : ftUiUAiTGSDgAJCvnFpXJSUgtERQ, zrLlTBFrsLrsiFBlwbgZFmRqZSoTA // TypeDefIndex: 7004
{
	// Fields
	private const string keyCategory = "action";
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int _id; // 0x10
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _name; // 0x18
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private InputActionType _type; // 0x20
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _descriptiveName; // 0x28
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _positiveDescriptiveName; // 0x30
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private string _negativeDescriptiveName; // 0x38
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _key; // 0x40
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private string _positiveKey; // 0x48
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _negativeKey; // 0x50
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int _behaviorId; // 0x58
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _userAssignable; // 0x5C
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int _categoryId; // 0x60
	private vEpedzEeKpJNJsmuYvHCACkhVXkOA AkwnqXXHArVvqcvmLTucKpAEeKMDA; // 0x68
	private int lhWaVPChlXfgMFgLlRTKGxoUGNtgA; // 0x70

	// Properties
	public int id { get; set; }
	public string name { get; set; }
	public InputActionType type { get; set; }
	public string descriptiveName { get; set; }
	public string positiveDescriptiveName { get; set; }
	public string negativeDescriptiveName { get; set; }
	public int behaviorId { get; set; }
	public int categoryId { get; set; }
	public bool userAssignable { get; set; }
	[CustomObfuscation(rename = False)]
	internal string key { get; set; }
	[CustomObfuscation(rename = False)]
	internal string positiveKey { get; set; }
	[CustomObfuscation(rename = False)]
	internal string negativeKey { get; set; }
	[CustomObfuscation(rename = False)]
	internal string nonLocalizedDescriptiveName { get; set; }
	[CustomObfuscation(rename = False)]
	internal string nonLocalizedPositiveDescriptiveName { get; set; }
	[CustomObfuscation(rename = False)]
	internal string nonLocalizedNegativeDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.INameLocalizerSource.keyCategory { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.scriptingName { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.nonLocalizedDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.nonLocalizedPositiveDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.nonLocalizedNegativeDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.INameLocalizerSource.key { get; }
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.positiveKey { get; set; }
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.negativeKey { get; set; }
	private int Rewired.Internal.Localization.INameLocalizerSource.autoGeneratedValueFlags { get; set; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_id() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	internal void jWfqAPTWFZaggTsWsqOzmMkiSuHs(int ) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_name() { }

	// RVA: 0x1A92E60 Offset: 0x1A92060 VA: 0x181A92E60
	internal void uGSHIPnuNZPbyNhItjkmgCPddCPV(string ) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public InputActionType get_type() { }

	// RVA: 0x1A92740 Offset: 0x1A91940 VA: 0x181A92740
	internal void UjEHYLQJPowKqRbhNjQsYCqcpvGo(InputActionType ) { }

	// RVA: 0x1A92950 Offset: 0x1A91B50 VA: 0x181A92950
	public string get_descriptiveName() { }

	// RVA: 0x1A925F0 Offset: 0x1A917F0 VA: 0x181A925F0
	internal void OjMQUSgFKAEHGVWwqkldsuOHOtEt(string ) { }

	// RVA: 0x1A92AD0 Offset: 0x1A91CD0 VA: 0x181A92AD0
	public string get_positiveDescriptiveName() { }

	// RVA: 0x1A92B90 Offset: 0x1A91D90 VA: 0x181A92B90
	internal void rQDDiRzgtGtabVvZhbxSzhNpleWj(string ) { }

	// RVA: 0x1A92A10 Offset: 0x1A91C10 VA: 0x181A92A10
	public string get_negativeDescriptiveName() { }

	// RVA: 0x1A92890 Offset: 0x1A91A90 VA: 0x181A92890
	internal void aWgTOVKWjzLCmMKfBYzKsJaPHCwL(string ) { }

	// RVA: 0x4EDB20 Offset: 0x4ECD20 VA: 0x1804EDB20
	public int get_behaviorId() { }

	// RVA: 0x4EDEA0 Offset: 0x4ED0A0 VA: 0x1804EDEA0
	internal void dVaFzuCxCdLrJIXGbeGghuofqBmKA(int ) { }

	// RVA: 0x42D890 Offset: 0x42CA90 VA: 0x18042D890
	public int get_categoryId() { }

	// RVA: 0x42D900 Offset: 0x42CB00 VA: 0x18042D900
	internal void agwrqjwkphLyJewepWkOzIeySpDg(int ) { }

	// RVA: 0x526D00 Offset: 0x525F00 VA: 0x180526D00
	public bool get_userAssignable() { }

	// RVA: 0x526E00 Offset: 0x526000 VA: 0x180526E00
	internal void efRfqKleLCfQYcKAZsyiBigaovKpc(bool ) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1A92800 Offset: 0x1A91A00 VA: 0x181A92800
	public void .ctor(InputAction ) { }

	// RVA: 0x1A922C0 Offset: 0x1A914C0 VA: 0x181A922C0
	public InputAction Clone() { }

	// RVA: 0x1A92380 Offset: 0x1A91580 VA: 0x181A92380
	public string GetDisplayName(AxisRange axisRange) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	internal string get_key() { }

	// RVA: 0x1A92C40 Offset: 0x1A91E40 VA: 0x181A92C40
	internal void set_key(string value) { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	internal string get_positiveKey() { }

	// RVA: 0x1A92DB0 Offset: 0x1A91FB0 VA: 0x181A92DB0
	internal void set_positiveKey(string value) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	internal string get_negativeKey() { }

	// RVA: 0x1A92D00 Offset: 0x1A91F00 VA: 0x181A92D00
	internal void set_negativeKey(string value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal string get_nonLocalizedDescriptiveName() { }

	// RVA: 0x1A925F0 Offset: 0x1A917F0 VA: 0x181A925F0
	internal void set_nonLocalizedDescriptiveName(string value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	internal string get_nonLocalizedPositiveDescriptiveName() { }

	// RVA: 0x1A92B90 Offset: 0x1A91D90 VA: 0x181A92B90
	internal void set_nonLocalizedPositiveDescriptiveName(string value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	internal string get_nonLocalizedNegativeDescriptiveName() { }

	// RVA: 0x1A92890 Offset: 0x1A91A90 VA: 0x181A92890
	internal void set_nonLocalizedNegativeDescriptiveName(string value) { }

	// RVA: 0x1A92F20 Offset: 0x1A92120 VA: 0x181A92F20
	internal void vbNCioiKNoHaUUsNYMgqKmFiLDEBA() { }

	// RVA: 0x1A92940 Offset: 0x1A91B40 VA: 0x181A92940
	internal void dWGyvklLZZlCYqbwAlKIxmkaqRPF() { }

	// RVA: 0x1A926B0 Offset: 0x1A918B0 VA: 0x181A926B0
	private static VDxsnTTWRPNGvDWpsIVjTbzLcwODA.KOPhTncSXKVblkSAwyPuVAaadfIq OsGZPtnwUVHpltfogubnqZZgfsaq(InputActionType ) { }

	// RVA: 0x1A92710 Offset: 0x1A91910 VA: 0x181A92710 Slot: 4
	private string Rewired.Internal.Localization.INameLocalizerSource.get_keyCategory() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 5
	private string Rewired.Internal.Localization.INameLocalizerSource.get_scriptingName() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 6
	private string Rewired.Internal.Localization.INameLocalizerSource.get_nonLocalizedDescriptiveName() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650 Slot: 7
	private void Rewired.Internal.Localization.INameLocalizerSource.set_nonLocalizedDescriptiveName(string value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 11
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.get_nonLocalizedPositiveDescriptiveName() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370 Slot: 12
	private void Rewired.Internal.Localization.IAxisNameLocalizerSource.set_nonLocalizedPositiveDescriptiveName(string value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 13
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.get_nonLocalizedNegativeDescriptiveName() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50 Slot: 14
	private void Rewired.Internal.Localization.IAxisNameLocalizerSource.set_nonLocalizedNegativeDescriptiveName(string value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 8
	private string Rewired.Internal.Localization.INameLocalizerSource.get_key() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0 Slot: 15
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.get_positiveKey() { }

	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200 Slot: 16
	private void Rewired.Internal.Localization.IAxisNameLocalizerSource.set_positiveKey(string value) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0 Slot: 17
	private string Rewired.Internal.Localization.IAxisNameLocalizerSource.get_negativeKey() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0 Slot: 18
	private void Rewired.Internal.Localization.IAxisNameLocalizerSource.set_negativeKey(string value) { }

	// RVA: 0x526CC0 Offset: 0x525EC0 VA: 0x180526CC0 Slot: 9
	private int Rewired.Internal.Localization.INameLocalizerSource.get_autoGeneratedValueFlags() { }

	// RVA: 0x526DC0 Offset: 0x525FC0 VA: 0x180526DC0 Slot: 10
	private void Rewired.Internal.Localization.INameLocalizerSource.set_autoGeneratedValueFlags(int value) { }
}

// Namespace: Rewired
[Serializable]
public sealed class InputBehavior // TypeDefIndex: 7005
{
	// Fields
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private int _id; // 0x10
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private string _name; // 0x18
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private float _joystickAxisSensitivity; // 0x20
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private bool _digitalAxisSimulation; // 0x24
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private bool _digitalAxisSnap; // 0x25
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private bool _digitalAxisInstantReverse; // 0x26
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _digitalAxisGravity; // 0x28
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _digitalAxisSensitivity; // 0x2C
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private MouseXYAxisMode _mouseXYAxisMode; // 0x30
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private MouseOtherAxisMode _mouseOtherAxisMode; // 0x34
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private float _mouseXYAxisSensitivity; // 0x38
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private MouseXYAxisDeltaCalc _mouseXYAxisDeltaCalc; // 0x3C
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private float _mouseOtherAxisSensitivity; // 0x40
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _customControllerAxisSensitivity; // 0x44
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _buttonDoublePressSpeed; // 0x48
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _buttonShortPressTime; // 0x4C
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _buttonShortPressExpiresIn; // 0x50
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private float _buttonLongPressTime; // 0x54
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _buttonLongPressExpiresIn; // 0x58
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private float _buttonDeadZone; // 0x5C
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private float _buttonDownBuffer; // 0x60
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private float _buttonRepeatRate; // 0x64
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private float _buttonRepeatDelay; // 0x68

	// Properties
	public int id { get; set; }
	public string name { get; set; }
	public float joystickAxisSensitivity { get; set; }
	public bool digitalAxisSimulation { get; set; }
	public bool digitalAxisSnap { get; set; }
	public bool digitalAxisInstantReverse { get; set; }
	public float digitalAxisGravity { get; set; }
	public float digitalAxisSensitivity { get; set; }
	public MouseXYAxisMode mouseXYAxisMode { get; set; }
	public MouseOtherAxisMode mouseOtherAxisMode { get; set; }
	public float mouseXYAxisSensitivity { get; set; }
	public MouseXYAxisDeltaCalc mouseXYAxisDeltaCalc { get; set; }
	public float mouseOtherAxisSensitivity { get; set; }
	public float customControllerAxisSensitivity { get; set; }
	public float buttonDoublePressSpeed { get; set; }
	public float buttonShortPressTime { get; set; }
	public float buttonShortPressExpiresIn { get; set; }
	public float buttonLongPressTime { get; set; }
	public float buttonLongPressExpiresIn { get; set; }
	public float buttonDeadZone { get; set; }
	public float buttonDownBuffer { get; set; }
	public float buttonRepeatRate { get; set; }
	public float buttonRepeatDelay { get; set; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_id() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	internal void jWfqAPTWFZaggTsWsqOzmMkiSuHs(int ) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_name() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void uGSHIPnuNZPbyNhItjkmgCPddCPV(string ) { }

	// RVA: 0x487630 Offset: 0x486830 VA: 0x180487630
	public float get_joystickAxisSensitivity() { }

	// RVA: 0x1A94930 Offset: 0x1A93B30 VA: 0x181A94930
	public void set_joystickAxisSensitivity(float value) { }

	// RVA: 0x695F30 Offset: 0x695130 VA: 0x180695F30
	public bool get_digitalAxisSimulation() { }

	// RVA: 0x7428E0 Offset: 0x741AE0 VA: 0x1807428E0
	public void set_digitalAxisSimulation(bool value) { }

	// RVA: 0x695F20 Offset: 0x695120 VA: 0x180695F20
	public bool get_digitalAxisSnap() { }

	// RVA: 0x1A3A150 Offset: 0x1A39350 VA: 0x181A3A150
	public void set_digitalAxisSnap(bool value) { }

	// RVA: 0x1850850 Offset: 0x184FA50 VA: 0x181850850
	public bool get_digitalAxisInstantReverse() { }

	// RVA: 0x18508B0 Offset: 0x184FAB0 VA: 0x1818508B0
	public void set_digitalAxisInstantReverse(bool value) { }

	// RVA: 0x484D20 Offset: 0x483F20 VA: 0x180484D20
	public float get_digitalAxisGravity() { }

	// RVA: 0x1A948D0 Offset: 0x1A93AD0 VA: 0x181A948D0
	public void set_digitalAxisGravity(float value) { }

	// RVA: 0x6F31E0 Offset: 0x6F23E0 VA: 0x1806F31E0
	public float get_digitalAxisSensitivity() { }

	// RVA: 0x1A94900 Offset: 0x1A93B00 VA: 0x181A94900
	public void set_digitalAxisSensitivity(float value) { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public MouseXYAxisMode get_mouseXYAxisMode() { }

	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	public void set_mouseXYAxisMode(MouseXYAxisMode value) { }

	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480
	public MouseOtherAxisMode get_mouseOtherAxisMode() { }

	// RVA: 0x4D19A0 Offset: 0x4D0BA0 VA: 0x1804D19A0
	public void set_mouseOtherAxisMode(MouseOtherAxisMode value) { }

	// RVA: 0x7974D0 Offset: 0x7966D0 VA: 0x1807974D0
	public float get_mouseXYAxisSensitivity() { }

	// RVA: 0x1A94990 Offset: 0x1A93B90 VA: 0x181A94990
	public void set_mouseXYAxisSensitivity(float value) { }

	// RVA: 0x15FEBE0 Offset: 0x15FDDE0 VA: 0x1815FEBE0
	public MouseXYAxisDeltaCalc get_mouseXYAxisDeltaCalc() { }

	// RVA: 0x190DB70 Offset: 0x190CD70 VA: 0x18190DB70
	public void set_mouseXYAxisDeltaCalc(MouseXYAxisDeltaCalc value) { }

	// RVA: 0x78EC10 Offset: 0x78DE10 VA: 0x18078EC10
	public float get_mouseOtherAxisSensitivity() { }

	// RVA: 0x1A94960 Offset: 0x1A93B60 VA: 0x181A94960
	public void set_mouseOtherAxisSensitivity(float value) { }

	// RVA: 0x78EC00 Offset: 0x78DE00 VA: 0x18078EC00
	public float get_customControllerAxisSensitivity() { }

	// RVA: 0x1A948A0 Offset: 0x1A93AA0 VA: 0x181A948A0
	public void set_customControllerAxisSensitivity(float value) { }

	// RVA: 0x78EC20 Offset: 0x78DE20 VA: 0x18078EC20
	public float get_buttonDoublePressSpeed() { }

	// RVA: 0x1A94730 Offset: 0x1A93930 VA: 0x181A94730
	public void set_buttonDoublePressSpeed(float value) { }

	// RVA: 0x6459B0 Offset: 0x644BB0 VA: 0x1806459B0
	public float get_buttonShortPressTime() { }

	// RVA: 0x1A94870 Offset: 0x1A93A70 VA: 0x181A94870
	public void set_buttonShortPressTime(float value) { }

	// RVA: 0x646040 Offset: 0x645240 VA: 0x180646040
	public float get_buttonShortPressExpiresIn() { }

	// RVA: 0x1A94840 Offset: 0x1A93A40 VA: 0x181A94840
	public void set_buttonShortPressExpiresIn(float value) { }

	// RVA: 0x6D7290 Offset: 0x6D6490 VA: 0x1806D7290
	public float get_buttonLongPressTime() { }

	// RVA: 0x1A947C0 Offset: 0x1A939C0 VA: 0x181A947C0
	public void set_buttonLongPressTime(float value) { }

	// RVA: 0x1529A10 Offset: 0x1528C10 VA: 0x181529A10
	public float get_buttonLongPressExpiresIn() { }

	// RVA: 0x1A94790 Offset: 0x1A93990 VA: 0x181A94790
	public void set_buttonLongPressExpiresIn(float value) { }

	// RVA: 0x1A94260 Offset: 0x1A93460 VA: 0x181A94260
	public float get_buttonDeadZone() { }

	// RVA: 0x1A94700 Offset: 0x1A93900 VA: 0x181A94700
	public void set_buttonDeadZone(float value) { }

	// RVA: 0x6D7F60 Offset: 0x6D7160 VA: 0x1806D7F60
	public float get_buttonDownBuffer() { }

	// RVA: 0x1A94760 Offset: 0x1A93960 VA: 0x181A94760
	public void set_buttonDownBuffer(float value) { }

	// RVA: 0x526CB0 Offset: 0x525EB0 VA: 0x180526CB0
	public float get_buttonRepeatRate() { }

	// RVA: 0x1A94810 Offset: 0x1A93A10 VA: 0x181A94810
	public void set_buttonRepeatRate(float value) { }

	// RVA: 0x526CE0 Offset: 0x525EE0 VA: 0x180526CE0
	public float get_buttonRepeatDelay() { }

	// RVA: 0x1A947F0 Offset: 0x1A939F0 VA: 0x181A947F0
	public void set_buttonRepeatDelay(float value) { }

	// RVA: 0x1A94230 Offset: 0x1A93430 VA: 0x181A94230
	public void .ctor() { }

	// RVA: 0x1A94140 Offset: 0x1A93340 VA: 0x181A94140
	public void .ctor(InputBehavior ) { }

	// RVA: 0x1A934C0 Offset: 0x1A926C0 VA: 0x181A934C0
	public string ToXmlString() { }

	// RVA: 0x1A93240 Offset: 0x1A92440 VA: 0x181A93240
	public bool ImportXmlString(string xmlString) { }

	// RVA: 0x1A93410 Offset: 0x1A92610 VA: 0x181A93410
	public string ToJsonString() { }

	// RVA: 0x1A93170 Offset: 0x1A92370 VA: 0x181A93170
	public bool ImportJsonString(string jsonString) { }

	// RVA: 0x1A930B0 Offset: 0x1A922B0 VA: 0x181A930B0
	public bool ImportData(InputBehavior inputBehavior) { }

	// RVA: 0x1A92F90 Offset: 0x1A92190 VA: 0x181A92F90
	public InputBehavior Clone() { }

	// RVA: 0x1A93310 Offset: 0x1A92510 VA: 0x181A93310
	public void Reset() { }

	// RVA: 0x1A93570 Offset: 0x1A92770 VA: 0x181A93570
	internal SerializedObject UBCBhGZRTknNwOzVaJbERZJwUenv() { }

	// RVA: 0x1A94270 Offset: 0x1A93470 VA: 0x181A94270
	internal void rYsSwSJGBllIqdANvWeTRMkmEBqeA(SerializedObject ) { }

	// RVA: 0x1A94070 Offset: 0x1A93270 VA: 0x181A94070
	private static void YIHYKVTqMpTRLPeqDbdKWqUZWFbL(InputBehavior , InputBehavior , bool ) { }
}

// Namespace: Rewired
[Serializable]
public abstract class InputCategory : ftUiUAiTGSDgAJCvnFpXJSUgtERQ // TypeDefIndex: 7006
{
	// Fields
	[SerializeField]
	[CustomObfuscation(rename = False)]
	protected string _name; // 0x10
	[CustomObfuscation(rename = False)]
	[SerializeField]
	protected string _descriptiveName; // 0x18
	[CustomObfuscation(rename = False)]
	[SerializeField]
	protected string _key; // 0x20
	[CustomObfuscation(rename = False)]
	[SerializeField]
	protected string _tag; // 0x28
	[SerializeField]
	[CustomObfuscation(rename = False)]
	protected int _id; // 0x30
	[CustomObfuscation(rename = False)]
	[SerializeField]
	protected bool _userAssignable; // 0x34
	private wxuBbaUjSloOlQfOCemKEVemgTdMA gEeATosTQCMbHLilWWJWbUSEBdYj; // 0x38
	private int lhWaVPChlXfgMFgLlRTKGxoUGNtgA; // 0x40

	// Properties
	internal abstract string keyCategory { get; }
	public string name { get; set; }
	public string descriptiveName { get; set; }
	public string tag { get; set; }
	public int id { get; set; }
	public bool userAssignable { get; set; }
	[CustomObfuscation(rename = False)]
	internal string key { get; set; }
	[CustomObfuscation(rename = False)]
	internal string nonLocalizedDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.INameLocalizerSource.keyCategory { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.scriptingName { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.nonLocalizedDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.INameLocalizerSource.key { get; }
	private int Rewired.Internal.Localization.INameLocalizerSource.autoGeneratedValueFlags { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract string get_keyCategory();

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_name() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void uGSHIPnuNZPbyNhItjkmgCPddCPV(string ) { }

	// RVA: 0x1A94A80 Offset: 0x1A93C80 VA: 0x181A94A80
	public string get_descriptiveName() { }

	// RVA: 0x1A949C0 Offset: 0x1A93BC0 VA: 0x181A949C0
	internal void OjMQUSgFKAEHGVWwqkldsuOHOtEt(string ) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_tag() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	internal void OsUxSQImoBjJZBOdMrvXsgaXznomA(string ) { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public int get_id() { }

	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	internal void jWfqAPTWFZaggTsWsqOzmMkiSuHs(int ) { }

	// RVA: 0x78E680 Offset: 0x78D880 VA: 0x18078E680
	public bool get_userAssignable() { }

	// RVA: 0x18C42D0 Offset: 0x18C34D0 VA: 0x1818C42D0
	internal void efRfqKleLCfQYcKAZsyiBigaovKpc(bool ) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal string get_key() { }

	// RVA: 0x1A94B40 Offset: 0x1A93D40 VA: 0x181A94B40
	internal void set_key(string value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal string get_nonLocalizedDescriptiveName() { }

	// RVA: 0x1A949C0 Offset: 0x1A93BC0 VA: 0x181A949C0
	internal void set_nonLocalizedDescriptiveName(string value) { }

	// RVA: 0x7F6700 Offset: 0x7F5900 VA: 0x1807F6700 Slot: 4
	private string Rewired.Internal.Localization.INameLocalizerSource.get_keyCategory() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 5
	private string Rewired.Internal.Localization.INameLocalizerSource.get_scriptingName() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	private string Rewired.Internal.Localization.INameLocalizerSource.get_nonLocalizedDescriptiveName() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70 Slot: 7
	private void Rewired.Internal.Localization.INameLocalizerSource.set_nonLocalizedDescriptiveName(string value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 8
	private string Rewired.Internal.Localization.INameLocalizerSource.get_key() { }

	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440 Slot: 9
	private int Rewired.Internal.Localization.INameLocalizerSource.get_autoGeneratedValueFlags() { }

	// RVA: 0x433450 Offset: 0x432650 VA: 0x180433450 Slot: 10
	private void Rewired.Internal.Localization.INameLocalizerSource.set_autoGeneratedValueFlags(int value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1A92230 Offset: 0x1A91430 VA: 0x181A92230
	public void .ctor(InputCategory ) { }

	// RVA: 0x1A94C00 Offset: 0x1A93E00 VA: 0x181A94C00 Slot: 12
	internal virtual void vbNCioiKNoHaUUsNYMgqKmFiLDEBA() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 13
	internal virtual void dWGyvklLZZlCYqbwAlKIxmkaqRPF() { }
}

// Namespace: Rewired
[Serializable]
public sealed class InputActionCategory : InputCategory // TypeDefIndex: 7007
{
	// Properties
	internal override string gWsanYkjIRiDNxQaCqeJDOlsLFefb { get; }

	// Methods

	// RVA: 0x1A92290 Offset: 0x1A91490 VA: 0x181A92290 Slot: 11
	internal override string pdQBWbzkRgCQEPROCDfRdvNRqqYB() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1A92230 Offset: 0x1A91430 VA: 0x181A92230
	public void .ctor(InputActionCategory ) { }
}

// Namespace: Rewired
[Serializable]
public sealed class InputMapCategory : InputCategory // TypeDefIndex: 7008
{
	// Fields
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private bool _checkConflictsWithAllCategories; // 0x48
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private List<int> _checkConflictsCategoryIds; // 0x50
	private ReadOnlyCollection<int> _checkConflictsCategoryIds_readOnly; // 0x58

	// Properties
	internal override string gWsanYkjIRiDNxQaCqeJDOlsLFefb { get; }
	public bool checkConflictsWithAllCategories { get; set; }
	public IList<int> checkConflictsCategoryIds { get; }
	internal List<int> oSjwlRWhwCHxENDtaOpxfOExhWyz { get; }

	// Methods

	// RVA: 0x1A950A0 Offset: 0x1A942A0 VA: 0x181A950A0 Slot: 11
	internal override string pdQBWbzkRgCQEPROCDfRdvNRqqYB() { }

	// RVA: 0x445A70 Offset: 0x444C70 VA: 0x180445A70
	public bool get_checkConflictsWithAllCategories() { }

	// RVA: 0x445A80 Offset: 0x444C80 VA: 0x180445A80
	internal void OXECahkPgwHgfNzMydlbRogHPYRcb(bool ) { }

	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public IList<int> get_checkConflictsCategoryIds() { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	internal List<int> oYrcYaKqphJJDWWVPTsVMIQspatW() { }

	// RVA: 0x1A94F90 Offset: 0x1A94190 VA: 0x181A94F90
	public void .ctor() { }

	// RVA: 0x1A95000 Offset: 0x1A94200 VA: 0x181A95000
	public void .ctor(InputMapCategory ) { }

	// RVA: 0x1A950D0 Offset: 0x1A942D0 VA: 0x181A950D0 Slot: 12
	internal override void vbNCioiKNoHaUUsNYMgqKmFiLDEBA() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 13
	internal override void dWGyvklLZZlCYqbwAlKIxmkaqRPF() { }
}

// Namespace: Rewired
[Serializable]
public sealed class InputLayout : ftUiUAiTGSDgAJCvnFpXJSUgtERQ // TypeDefIndex: 7009
{
	// Fields
	private const string keyCategory = "controller_map/layout";
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _name; // 0x10
	[CustomObfuscation(rename = False)]
	[SerializeField]
	private string _descriptiveName; // 0x18
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private string _key; // 0x20
	[SerializeField]
	[CustomObfuscation(rename = False)]
	private int _id; // 0x28
	private wxuBbaUjSloOlQfOCemKEVemgTdMA gEeATosTQCMbHLilWWJWbUSEBdYj; // 0x30
	private int lhWaVPChlXfgMFgLlRTKGxoUGNtgA; // 0x38

	// Properties
	public string name { get; set; }
	public string descriptiveName { get; set; }
	public int id { get; set; }
	[CustomObfuscation(rename = False)]
	internal string key { get; set; }
	[CustomObfuscation(rename = False)]
	internal string nonLocalizedDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.INameLocalizerSource.keyCategory { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.scriptingName { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.nonLocalizedDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.INameLocalizerSource.key { get; }
	private int Rewired.Internal.Localization.INameLocalizerSource.autoGeneratedValueFlags { get; set; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_name() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void uGSHIPnuNZPbyNhItjkmgCPddCPV(string ) { }

	// RVA: 0x1A94DF0 Offset: 0x1A93FF0 VA: 0x181A94DF0
	public string get_descriptiveName() { }

	// RVA: 0x1A94CA0 Offset: 0x1A93EA0 VA: 0x181A94CA0
	internal void OjMQUSgFKAEHGVWwqkldsuOHOtEt(string ) { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public int get_id() { }

	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	internal void jWfqAPTWFZaggTsWsqOzmMkiSuHs(int ) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal string get_key() { }

	// RVA: 0x1A94EB0 Offset: 0x1A940B0 VA: 0x181A94EB0
	internal void set_key(string value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal string get_nonLocalizedDescriptiveName() { }

	// RVA: 0x1A94CA0 Offset: 0x1A93EA0 VA: 0x181A94CA0
	internal void set_nonLocalizedDescriptiveName(string value) { }

	// RVA: 0x1A94D60 Offset: 0x1A93F60 VA: 0x181A94D60 Slot: 4
	private string Rewired.Internal.Localization.INameLocalizerSource.get_keyCategory() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 5
	private string Rewired.Internal.Localization.INameLocalizerSource.get_scriptingName() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	private string Rewired.Internal.Localization.INameLocalizerSource.get_nonLocalizedDescriptiveName() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70 Slot: 7
	private void Rewired.Internal.Localization.INameLocalizerSource.set_nonLocalizedDescriptiveName(string value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 8
	private string Rewired.Internal.Localization.INameLocalizerSource.get_key() { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0 Slot: 9
	private int Rewired.Internal.Localization.INameLocalizerSource.get_autoGeneratedValueFlags() { }

	// RVA: 0x423300 Offset: 0x422500 VA: 0x180423300 Slot: 10
	private void Rewired.Internal.Localization.INameLocalizerSource.set_autoGeneratedValueFlags(int value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1A94D90 Offset: 0x1A93F90 VA: 0x181A94D90
	public void .ctor(InputLayout ) { }

	// RVA: 0x1A94C20 Offset: 0x1A93E20 VA: 0x181A94C20
	public InputLayout Clone() { }

	// RVA: 0x1A94F70 Offset: 0x1A94170 VA: 0x181A94F70
	internal void vbNCioiKNoHaUUsNYMgqKmFiLDEBA() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void dWGyvklLZZlCYqbwAlKIxmkaqRPF() { }
}

// Namespace: 
public class InputMapper.Context // TypeDefIndex: 7010
{
	// Fields
	private int pFIFvsDSemlQRdLPLVmAuFVFNKGkA; // 0x10
	private ControllerMap SUGdqeYxYDFvxpaJyaCWAtSXvzHpA; // 0x18
	private ActionElementMap fiEUWwTdlaigUMjVxcAfmMqBOwso; // 0x20
	private AxisRange NqvDbOAqPDjpyCztaHpcTZaPjHxZ; // 0x28
	private bool zOKzuYXFLGIRkSsulGEskMlxDTlI; // 0x2C

	// Properties
	public int actionId { get; set; }
	public string actionName { get; set; }
	public ControllerMap controllerMap { get; set; }
	public ActionElementMap actionElementMapToReplace { get; set; }
	public AxisRange actionRange { get; set; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_actionId() { }

	// RVA: 0x1A884A0 Offset: 0x1A876A0 VA: 0x181A884A0
	public void set_actionId(int value) { }

	// RVA: 0x1A88360 Offset: 0x1A87560 VA: 0x181A88360
	public string get_actionName() { }

	// RVA: 0x1A88500 Offset: 0x1A87700 VA: 0x181A88500
	public void set_actionName(string value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ControllerMap get_controllerMap() { }

	// RVA: 0x1A88660 Offset: 0x1A87860 VA: 0x181A88660
	public void set_controllerMap(ControllerMap value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ActionElementMap get_actionElementMapToReplace() { }

	// RVA: 0x1A88440 Offset: 0x1A87640 VA: 0x181A88440
	public void set_actionElementMapToReplace(ActionElementMap value) { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public AxisRange get_actionRange() { }

	// RVA: 0x1A88600 Offset: 0x1A87800 VA: 0x181A88600
	public void set_actionRange(AxisRange value) { }

	// RVA: 0x1A882A0 Offset: 0x1A874A0 VA: 0x181A882A0
	public void .ctor() { }

	// RVA: 0x1A882C0 Offset: 0x1A874C0 VA: 0x181A882C0
	private void .ctor(InputMapper.Context ) { }

	// RVA: 0x1A88100 Offset: 0x1A87300 VA: 0x181A88100
	public InputMapper.Context Clone() { }

	// RVA: 0x1A886C0 Offset: 0x1A878C0 VA: 0x181A886C0
	internal void uvqOfYFhliACaCzzCVOkjuLCksadb() { }

	// RVA: 0x1A883F0 Offset: 0x1A875F0 VA: 0x181A883F0
	private bool piPVcBxbWuSSOsUTFAQteAZLoKjh() { }

	// RVA: 0x1A881D0 Offset: 0x1A873D0 VA: 0x181A881D0
	public static void Copy(InputMapper.Context source, InputMapper.Context destination) { }
}

// Namespace: 
public enum InputMapper.ConflictResponse // TypeDefIndex: 7011
{
	// Fields
	public int value__; // 0x0
	public const InputMapper.ConflictResponse Cancel = 0;
	public const InputMapper.ConflictResponse Replace = 1;
	public const InputMapper.ConflictResponse Add = 2;
	public const InputMapper.ConflictResponse Ignore = 3;
	public const InputMapper.ConflictResponse Swap = 4;
}

// Namespace: 
public abstract class InputMapper.EventData // TypeDefIndex: 7012
{
	// Fields
	public readonly InputMapper inputMapper; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(InputMapper ) { }
}

// Namespace: 
public class InputMapper.InputMappedEventData : InputMapper.EventData // TypeDefIndex: 7013
{
	// Fields
	public readonly ActionElementMap actionElementMap; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	internal void .ctor(InputMapper , ActionElementMap ) { }
}

// Namespace: 
public class InputMapper.CanceledEventData : InputMapper.EventData // TypeDefIndex: 7014
{
	// Fields
	public readonly string message; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	internal void .ctor(InputMapper , string ) { }
}

// Namespace: 
public class InputMapper.ErrorEventData : InputMapper.EventData // TypeDefIndex: 7015
{
	// Fields
	public readonly string message; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	internal void .ctor(InputMapper , string ) { }
}

// Namespace: 
public class InputMapper.TimedOutEventData : InputMapper.EventData // TypeDefIndex: 7016
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(InputMapper ) { }
}

// Namespace: 
public class InputMapper.StartedEventData : InputMapper.EventData // TypeDefIndex: 7017
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(InputMapper ) { }
}

// Namespace: 
public class InputMapper.StoppedEventData : InputMapper.EventData // TypeDefIndex: 7018
{
	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(InputMapper ) { }
}

// Namespace: 
public class InputMapper.ConflictFoundEventData : InputMapper.EventData // TypeDefIndex: 7019
{
	// Fields
	public readonly Action<InputMapper.ConflictResponse> responseCallback; // 0x18
	public readonly ElementAssignmentInfo assignment; // 0x20
	public readonly IList<ElementAssignmentConflictInfo> conflicts; // 0x28
	public readonly bool isProtected; // 0x30
	private readonly Func<int, bool> XCLgJOCScmyoJDxlAAbjilRfUmlzB; // 0x38

	// Methods

	// RVA: 0x1A88070 Offset: 0x1A87270 VA: 0x181A88070
	public bool IsSwapAllowed(int maxInputFieldCount) { }

	// RVA: 0x1A88090 Offset: 0x1A87290 VA: 0x181A88090
	internal void .ctor(InputMapper , Action<InputMapper.ConflictResponse> , ElementAssignmentInfo , IList<ElementAssignmentConflictInfo> , bool , Func<int, bool> ) { }
}

// Namespace: 
private enum InputMapper.BKyxTIiJgJTqTWloWnakORakxEaT // TypeDefIndex: 7020
{
	// Fields
	public int value__; // 0x0
	public const InputMapper.BKyxTIiJgJTqTWloWnakORakxEaT InputMapped = 0;
	public const InputMapper.BKyxTIiJgJTqTWloWnakORakxEaT Error = 1;
	public const InputMapper.BKyxTIiJgJTqTWloWnakORakxEaT Canceled = 2;
	public const InputMapper.BKyxTIiJgJTqTWloWnakORakxEaT TimedOut = 3;
	public const InputMapper.BKyxTIiJgJTqTWloWnakORakxEaT Started = 4;
	public const InputMapper.BKyxTIiJgJTqTWloWnakORakxEaT Stopped = 5;
	public const InputMapper.BKyxTIiJgJTqTWloWnakORakxEaT ConflictsFound = 6;
}

// Namespace: 
public enum InputMapper.Status // TypeDefIndex: 7021
{
	// Fields
	public int value__; // 0x0
	public const InputMapper.Status Idle = 0;
	public const InputMapper.Status Listening = 1;
	public const InputMapper.Status AwaitingResponse = 2;
}

// Namespace: 
private enum InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec.hKKrSfUxrhWGEbCleQeyCPiVaJZz // TypeDefIndex: 7022
{
	// Fields
	public int value__; // 0x0
	public const InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec.hKKrSfUxrhWGEbCleQeyCPiVaJZz Quit = 0;
	public const InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec.hKKrSfUxrhWGEbCleQeyCPiVaJZz Continue = 1;
}

// Namespace: 
private enum InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec.FwgkaZHYQyLmdURQVtBrtdJegJFU // TypeDefIndex: 7023
{
	// Fields
	public int value__; // 0x0
	public const InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec.FwgkaZHYQyLmdURQVtBrtdJegJFU None = 0;
	public const InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec.FwgkaZHYQyLmdURQVtBrtdJegJFU ConflictChecking = 1;
}

// Namespace: 
private class InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec.YeTezuxKeUVjLedrPKfLwEzIDYLB // TypeDefIndex: 7024
{
	// Fields
	private Player pTMwWYaHRMWjLJIpUEIUEZYYDbrY; // 0x10
	private int pFIFvsDSemlQRdLPLVmAuFVFNKGkA; // 0x18
	private InputMapper.Context cZTmdOZDrVpwgkuLAfUKNsLFOoQE; // 0x20
	private ControllerType mssadAAejyKGHIfognJBtXtNdiiIB; // 0x28
	private int ywemEHCIFHYFGIaBqcsShHUagHzN; // 0x2C
	private ControllerPollingInfo kZDktLiyyqwSOYZfshWCUchCCFch; // 0x30
	private ModifierKeyFlags HtqcTFdvkoDVnFJQmkUYhtyplmcb; // 0x68

	// Properties
	public Player dKxeWVrXJNsFqEAYKfLlJKDBwaWd { get; }
	public int RMJEoXtoZMtwULyaBvSFzYLhgaKj { get; }
	public InputMapper.Context RhNMNFPhwdUhoFXNQbcMxcxxUcWn { get; }
	public ControllerType XkDVpydTdKFGyaepLgJpPXsuRQFt { get; }
	public int NDJCfPreMhWCOFQPsCzuOVGtkoBG { get; }
	public ControllerPollingInfo YThJUxLnCQoRkeSOadHtoUBWTHTn { get; }
	public ModifierKeyFlags KsRezZhYSoespMtsYkkgsJoAOtoJA { get; }
	public AxisRange FQNeywDPCttjFUNLadNFaWxuTtulA { get; }
	public string JIgjXeLhhoaZjenCHqXYGEWmftkk { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Player lbTnefOkQLLqJNgBXwaiDvFumjwV() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int cOXdTLDTQcFamMuBBLWGeBkkXclOA() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public InputMapper.Context hIfrBUxlmFzriLEmHmlIbqgrDFbjA() { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public ControllerType isiIbAlrdhoawXdijybVEIqgBqAP() { }

	// RVA: 0x5012C0 Offset: 0x5004C0 VA: 0x1805012C0
	public int nIrZBhfKOPpiOkiwMaRDEMKqpMOAb() { }

	// RVA: 0x1AB9A20 Offset: 0x1AB8C20 VA: 0x181AB9A20
	public ControllerPollingInfo nHCGLvAWfjjPYncHARVMcqAREzep() { }

	// RVA: 0x6DDF80 Offset: 0x6DD180 VA: 0x1806DDF80
	public ModifierKeyFlags PUQowTRUtgTvaSrwjBfzRWlaEaIF() { }

	// RVA: 0x1AB9540 Offset: 0x1AB8740 VA: 0x181AB9540
	public AxisRange CCTdGaJChLzQVuatotntbXyNhpuA() { }

	// RVA: 0x1AB9900 Offset: 0x1AB8B00 VA: 0x181AB9900
	public string hNtVHPaEWoiWIsewDmFNFdvHUwRn() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1AB97A0 Offset: 0x1AB89A0 VA: 0x181AB97A0
	public void ZFUcTEcndvHgBpdTmEAgSebxfOsJ(Player , InputMapper.Context ) { }

	// RVA: 0x1AB98C0 Offset: 0x1AB8AC0 VA: 0x181AB98C0
	public void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }

	// RVA: 0x1AB95F0 Offset: 0x1AB87F0 VA: 0x181AB95F0
	public ElementAssignment GIyZFStNQiVmejNUrqDwCJmnbtxO(ControllerPollingInfo ) { }

	// RVA: 0x1AB9590 Offset: 0x1AB8790 VA: 0x181AB9590
	public ElementAssignment GIyZFStNQiVmejNUrqDwCJmnbtxO(ControllerPollingInfo , ModifierKeyFlags ) { }

	// RVA: 0x1AB9650 Offset: 0x1AB8850 VA: 0x181AB9650
	public ElementAssignment GIyZFStNQiVmejNUrqDwCJmnbtxO() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec.tOoBHpdWcOKrQscgDuoWPoJsXRCO // TypeDefIndex: 7025
{
	// Fields
	public ActionElementMap COrUhFFjdgWcgLLQJabNjOgxGUVEA; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x799C00 Offset: 0x798E00 VA: 0x180799C00
	internal bool TBLsrqXSjlrNhYGzbZTmUyrVSGew(ElementAssignmentConflictInfo ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec.qQVEPmIGdPvxeOwglbNPdRWgMKgdA // TypeDefIndex: 7026
{
	// Fields
	public InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x10
	public ElementAssignmentInfo YZIGxeaCjsDhnKYTDSUTgzQdXctl; // 0x18
	public IList<ElementAssignmentConflictInfo> iImmaMoUHjoagrjBxqjwuayRHZvL; // 0x20
	public bool LPHQrMnQCFlArzlweNkCCabHnhMT; // 0x28

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1ABADE0 Offset: 0x1AB9FE0 VA: 0x181ABADE0
	internal bool mBeZNTVmgmvBniwQvJPSqEnuHGDo(int ) { }
}

// Namespace: 
private class InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec // TypeDefIndex: 7027
{
	// Fields
	private readonly InputMapper YgOUhFlqQKEAUkaFqxIeQeWEyeff; // 0x10
	private readonly InputMapper.Options BJcanMEoOfLuDMVmBAUUiVxWkCUEb; // 0x18
	private readonly InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec.YeTezuxKeUVjLedrPKfLwEzIDYLB hMzwPjkYEgoGatFVIRJfGOpFNGfs; // 0x20
	private readonly Dictionary<InputMapper.BKyxTIiJgJTqTWloWnakORakxEaT, SafeDelegate> iwiyRoohWYTfeGMNPEwHPkyTdYtl; // 0x28
	private readonly Dictionary<string, SafeDelegate> aMPrrBoljoUbdCNPuePeDWWjWIgX; // 0x30
	private InputMapper.Status jHaybvMLlERMkkfzbFkmfWoNqbff; // 0x38
	private InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec.FwgkaZHYQyLmdURQVtBrtdJegJFU WvEfkMbEKAWwNsEjkpfLTEVDQUwM; // 0x3C
	private double msmFARDTyUBfoDYRnDmKzZLhCsUrA; // 0x40
	private bool KyflDCxjqtLScfAWnyPOhIdfiuKU; // 0x48
	private List<Player> AGPAkHjIViTPUCYkMfJgpKmtXnlx; // 0x50
	private readonly List<ControllerPollingInfo> foOPRNzWiHaXwOrmNiGgXOUizCQe; // 0x58
	private ElementAssignment YNRCjajcDNmZBhcDkYcmKxjiioQXB; // 0x60

	// Properties
	public InputMapper.Status OpoVbiYjHKpFiEWMBEHsTAhmQQcQ { get; }
	public float PKIyqttbBRnKnzkiYViMstNMceoJ { get; }
	public InputMapper.Context SBAwUHdZwiQKcNCOgPKgRBLAarSX { get; }
	private bool XDWduIczbWbqtTzTDquONpYcWqrW { get; }

	// Methods

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	public InputMapper.Status pZxYYCPuHWkTXOEPjhSPfZjAboCD() { }

	// RVA: 0x1A9D510 Offset: 0x1A9C710 VA: 0x181A9D510
	public float uSDsRkNHhuCldbPYlrXcGeLguRCR() { }

	// RVA: 0x1A9D4E0 Offset: 0x1A9C6E0 VA: 0x181A9D4E0
	public InputMapper.Context roGVSAChhIhZuDarGUYkUlTryQheA() { }

	// RVA: 0x1A9AE80 Offset: 0x1A9A080 VA: 0x181A9AE80
	private bool RdKvLyAMLyaOTfIjWIZwVQVFNIQx() { }

	// RVA: 0x1A9B7F0 Offset: 0x1A9A9F0 VA: 0x181A9B7F0
	public void .ctor(InputMapper , Dictionary<InputMapper.BKyxTIiJgJTqTWloWnakORakxEaT, SafeDelegate> ) { }

	// RVA: 0x1A9AF70 Offset: 0x1A9A170 VA: 0x181A9AF70 Slot: 1
	protected override void SnyTHacbnnYzPrlQoFnKzkJtcRbdA() { }

	// RVA: 0x1A99DB0 Offset: 0x1A98FB0 VA: 0x181A99DB0
	public void OVAHhXYoWnOfgTkcQdOcZntUEeNb(InputMapper.Context , InputMapper.Options ) { }

	// RVA: 0x1A99960 Offset: 0x1A98B60 VA: 0x181A99960
	public void KWoesXdawSXjcLpqJZIYIhPvgeYOA(string ) { }

	// RVA: 0x1A99970 Offset: 0x1A98B70 VA: 0x181A99970
	private void NXsdcUmvlchkKwnLJYZgvWkOUNSV(UpdateLoopType ) { }

	// RVA: 0x1A99040 Offset: 0x1A98240 VA: 0x181A99040
	private void BizHcRRMerviwKcFEUiFmLbxcZaD() { }

	// RVA: 0x1A98F90 Offset: 0x1A98190 VA: 0x181A98F90
	private void BHjXZDxKJshZmZczZFrInOrGAvqH() { }

	// RVA: 0x1A9BDE0 Offset: 0x1A9AFE0 VA: 0x181A9BDE0
	private InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec.hKKrSfUxrhWGEbCleQeyCPiVaJZz gMNsWvfOkHMUjatlTPUoYilFlSwy(out ElementAssignment ) { }

	// RVA: 0x1A9CFB0 Offset: 0x1A9C1B0 VA: 0x181A9CFB0
	private bool muTnSkzLzECoqSMywpmxfJzJxIPh(out IEnumerable<ControllerPollingInfo> , out ModifierKeyFlags ) { }

	// RVA: 0x1A9D5C0 Offset: 0x1A9C7C0 VA: 0x181A9D5C0
	private IEnumerable<ControllerPollingInfo> xTaVCUWeNrcfOIdQVzGifuRipQLAA(out ModifierKeyFlags ) { }

	// RVA: 0x1A9A7F0 Offset: 0x1A999F0 VA: 0x181A9A7F0
	private ControllerPollingInfo PhIfxAScjqIjjevJPZbKoRebAwtqA(InputMapper.Options , out ModifierKeyFlags ) { }

	// RVA: 0x1A9A1C0 Offset: 0x1A993C0 VA: 0x181A9A1C0
	private static ControllerPollingInfo PhIfxAScjqIjjevJPZbKoRebAwtqA(InputMapper.Options , out bool , out ModifierKeyFlags , out string ) { }

	// RVA: 0x1A9AFD0 Offset: 0x1A9A1D0 VA: 0x181A9AFD0
	private static bool UQLeAeCgXovLCaJWanmIhuDvsGpBb(ControllerPollingInfo , InputMapper.Options ) { }

	// RVA: 0x1A992F0 Offset: 0x1A984F0 VA: 0x181A992F0
	private static bool DySJMylBkWsnRWzXSItYWmmwTdSF(InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec.YeTezuxKeUVjLedrPKfLwEzIDYLB , ControllerPollingInfo , InputMapper.Options ) { }

	// RVA: 0x1A9DB20 Offset: 0x1A9CD20 VA: 0x181A9DB20
	private void zTjatPjweRqKthRPjtMIaaUIVpOK() { }

	// RVA: 0x1A9BC10 Offset: 0x1A9AE10 VA: 0x181A9BC10
	private InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec.hKKrSfUxrhWGEbCleQeyCPiVaJZz fulQiguwIKFYPyPWacNaBfikHiHeA(ElementAssignment ) { }

	// RVA: 0x1A99730 Offset: 0x1A98930 VA: 0x181A99730
	private static bool HYndNFcREcbkDjTgdXAOObuXAllRA(InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec.YeTezuxKeUVjLedrPKfLwEzIDYLB , ElementAssignment , List<Player> ) { }

	// RVA: 0x1A9D7E0 Offset: 0x1A9C9E0 VA: 0x181A9D7E0
	private static bool xedrCnCxAXXMwPDRGNttXXGlycTd(InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec.YeTezuxKeUVjLedrPKfLwEzIDYLB , ElementAssignment , List<Player> ) { }

	// RVA: 0x1A9B4B0 Offset: 0x1A9A6B0 VA: 0x181A9B4B0
	private static IList<ElementAssignmentConflictInfo> WUrbrMIeXsQzFHYxNHrJseQDvotLA(InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec.YeTezuxKeUVjLedrPKfLwEzIDYLB , ElementAssignment , List<Player> ) { }

	// RVA: 0x1A9BB00 Offset: 0x1A9AD00 VA: 0x181A9BB00
	private static bool ftsCLBtLrlXcpsHzzZRSBvmNrCCy(InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec.YeTezuxKeUVjLedrPKfLwEzIDYLB , ElementAssignment , out ElementAssignmentConflictCheck ) { }

	// RVA: 0x1A99520 Offset: 0x1A98720 VA: 0x181A99520
	private static void HMdcgAXBYTWBihznqTWdOncnoiad(InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec.YeTezuxKeUVjLedrPKfLwEzIDYLB , ElementAssignment , List<Player> ) { }

	// RVA: 0x1A9A100 Offset: 0x1A99300 VA: 0x181A9A100
	private void PBzgxkqwLHIOMkOSnCjngckBwyrwB() { }

	// RVA: 0x1A9DA90 Offset: 0x1A9CC90 VA: 0x181A9DA90
	private void zJtJmeaAjbgSJGnIFoKUYWotXOcLA() { }

	// RVA: 0x1A994A0 Offset: 0x1A986A0 VA: 0x181A994A0
	private bool GbtOMzboqvHSVmZKwvpRPaKAmetl(InputMapper.BKyxTIiJgJTqTWloWnakORakxEaT ) { }

	// RVA: -1 Offset: -1
	private void lVvxVScUNjTGkpPEyAazDOoQPgkWA<>(InputMapper.BKyxTIiJgJTqTWloWnakORakxEaT ,  ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD74B0 Offset: 0xAD66B0 VA: 0x180AD74B0
	|-InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec.lVvxVScUNjTGkpPEyAazDOoQPgkWA<object>
	|
	|-RVA: 0xAD7340 Offset: 0xAD6540 VA: 0x180AD7340
	|-InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec.lVvxVScUNjTGkpPEyAazDOoQPgkWA<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1A998D0 Offset: 0x1A98AD0 VA: 0x181A998D0
	private void IkPtxAMhONKHIsSgcGHpQSWKiBzj() { }

	// RVA: 0x7159A0 Offset: 0x714BA0 VA: 0x1807159A0
	private void GFQMlYASViymQywsUcGzRKcONpGI() { }

	// RVA: 0x1A9C580 Offset: 0x1A9B780 VA: 0x181A9C580
	private bool kmPEWJhCrjgviLknnQDopmxbidXu(ElementAssignmentInfo , IList<ElementAssignmentConflictInfo> , bool , int ) { }

	// RVA: 0x1A9A9E0 Offset: 0x1A99BE0 VA: 0x181A9A9E0
	private bool QbxBVvAHkKlHdlenAhyUThKaKKPBA(InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec.YeTezuxKeUVjLedrPKfLwEzIDYLB , ElementAssignment , bool , out string ) { }

	// RVA: 0x1A99890 Offset: 0x1A98A90 VA: 0x181A99890
	private static bool IfOphXlRBhbQtMIQubnjasvumwhFA(ControllerElementType , AxisRange , Pole , ControllerElementType , AxisRange , Pole ) { }

	// RVA: 0x1A9AEC0 Offset: 0x1A9A0C0 VA: 0x181A9AEC0
	private void RrdFsamLmzsflsDfihOXDiYOWpVMA(ActionElementMap ) { }

	// RVA: 0x1A99340 Offset: 0x1A98540 VA: 0x181A99340
	private void ELdwOOvfhcyrNqKvumAMLJQNaBpZ(string ) { }

	// RVA: 0x1A9C270 Offset: 0x1A9B470 VA: 0x181A9C270
	private InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec.hKKrSfUxrhWGEbCleQeyCPiVaJZz jqrcEoqnEWyEBJqwgIoeVxJUOivT(ElementAssignment ) { }

	// RVA: 0x1A9B0E0 Offset: 0x1A9A2E0 VA: 0x181A9B0E0
	private InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec.hKKrSfUxrhWGEbCleQeyCPiVaJZz VPbBcCpGLGBPCePLUWvimDLSHhYGb(InputMapper.ConflictResponse , ElementAssignment ) { }

	// RVA: 0x1A9B2E0 Offset: 0x1A9A4E0 VA: 0x181A9B2E0
	private InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec.hKKrSfUxrhWGEbCleQeyCPiVaJZz VPbBcCpGLGBPCePLUWvimDLSHhYGb(InputMapper.ConflictResponse , ElementAssignment , bool ) { }

	// RVA: 0x1A9BA60 Offset: 0x1A9AC60 VA: 0x181A9BA60
	private void fbPapHFgqculOLWESyOObzFVApVkA() { }

	// RVA: 0x1A993F0 Offset: 0x1A985F0 VA: 0x181A993F0
	private void EpFOYrXvcYuHBViWWECdbRoCGqnv(string ) { }

	// RVA: 0x1A99930 Offset: 0x1A98B30 VA: 0x181A99930
	private void JTGaqTDYrzJtuYFvfIVFNfgetdjH() { }

	// RVA: 0x1A98F20 Offset: 0x1A98120 VA: 0x181A98F20
	private void AkuMjNKtellrggFdxGbfkaOXfojj() { }

	// RVA: 0x1A991A0 Offset: 0x1A983A0 VA: 0x181A991A0
	private void CmiDkSqxXzoVKZmwyUEgtOdJoDtQ(ElementAssignment ) { }

	// RVA: 0x1A9B9B0 Offset: 0x1A9ABB0 VA: 0x181A9B9B0
	private void fHNIFgxqBijsaCOOqbPZTxjrISspA(ActionElementMap ) { }

	// RVA: 0x1A9D440 Offset: 0x1A9C640 VA: 0x181A9D440
	private void nIaBzRHXMPBcVVPKxQALaTLuZKbK() { }

	// RVA: 0x1A9A930 Offset: 0x1A99B30 VA: 0x181A9A930
	private void QQaJNrrfKZOwVvDciDJtUWhnJFqb(string ) { }

	// RVA: 0x1A9CD60 Offset: 0x1A9BF60 VA: 0x181A9CD60
	private void mESlMyQClPNqhxOfnjLlAuuvyLPB(string ) { }

	// RVA: 0x1A9CE10 Offset: 0x1A9C010 VA: 0x181A9CE10
	private void mkNjNufXYYgYybShcYnvUBNiCGGr(ElementAssignmentInfo , IList<ElementAssignmentConflictInfo> , bool ) { }

	// RVA: 0x1A98E80 Offset: 0x1A98080 VA: 0x181A98E80
	private void AbsyGSMpUtpsvDFacYcQLKEYdcHd() { }

	// RVA: 0x1A99100 Offset: 0x1A98300 VA: 0x181A99100
	private void BqyOMTdQgJHDcncBKHuxiKfqjESt() { }

	// RVA: 0x1A9C150 Offset: 0x1A9B350 VA: 0x181A9C150
	public void iKYiZHxSSItJXOzfDjVrvdrJxVZ(InputMapper.ConflictResponse ) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class InputMapper.Options.yMixRFCYtIuOFXAlNNXoaJFtsSnD // TypeDefIndex: 7028
{
	// Fields
	public static readonly InputMapper.Options.yMixRFCYtIuOFXAlNNXoaJFtsSnD <>9; // 0x0
	public static Action<Exception> <>9__64_0; // 0x8

	// Methods

	// RVA: 0x1ABAE20 Offset: 0x1ABA020 VA: 0x181ABAE20
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1ABAE80 Offset: 0x1ABA080 VA: 0x181ABAE80
	internal void fwwUPtXHnTegbKozrraasDLUAuYIA(Exception ) { }
}

// Namespace: 
public class InputMapper.Options // TypeDefIndex: 7029
{
	// Fields
	private bool syZCoKbBxjkNbdfaAlyBBDslTkmhA; // 0x10
	private bool sMAbLsQFTlTwkAXAokFCjJinHcNG; // 0x11
	private bool shBlgyHMSaVPEkImnXhpnVawdKaC; // 0x12
	private float VvFbabbwIOatWbiarBZWJggVBEpL; // 0x14
	private bool gBmRQWiyUUwjCWQGjixnWkMZegsi; // 0x18
	private bool UbCauTIfmLtDoBmKQZXAaYPdObZF; // 0x19
	private bool IcAxskGxeQFsbwPJEzbDjVohKTER; // 0x1A
	private bool IUAYYIEoaqVDYizJJhvvBomXSmti; // 0x1B
	private int[] GaGGIVTctOKnaeLXeFPCBftKHtPB; // 0x20
	private InputMapper.ConflictResponse ypGqnIMflkvBTpqULIlxkHXNYXvk; // 0x28
	private bool dlgIVTvauKxKdcihVngbyPqaSXfi; // 0x2C
	private bool LQsuCbKtLXvhcbwpXwFbeyWTbVYG; // 0x2D
	private bool XGXaOlMqvzOaOUjTquOEQxykTbn; // 0x2E
	private bool MQoaPFSRzXDhfBXRsAVdWhLbgUVS; // 0x2F
	private float lmPocozBJeAhbIixPgeaGsMkPmtw; // 0x30
	internal const string RrQOhwUaZrRwRqbhTfVAOtJzRrCh = "isElementAllowed";
	private readonly Dictionary<string, SafeDelegate> aMPrrBoljoUbdCNPuePeDWWjWIgX; // 0x38

	// Properties
	public bool allowAxes { get; set; }
	public bool allowButtons { get; set; }
	public bool allowButtonsOnFullAxisAssignment { get; set; }
	public float timeout { get; set; }
	public bool checkForConflicts { get; set; }
	public bool checkForConflictsWithAllPlayers { get; set; }
	public bool checkForConflictsWithSelf { get; set; }
	public bool checkForConflictsWithSystemPlayer { get; set; }
	public int[] checkForConflictsWithPlayerIds { get; set; }
	public InputMapper.ConflictResponse defaultActionWhenConflictFound { get; set; }
	public bool ignoreMouseXAxis { get; set; }
	public bool ignoreMouseYAxis { get; set; }
	public bool allowKeyboardKeysWithModifiers { get; set; }
	public bool allowKeyboardModifierKeyAsPrimary { get; set; }
	public float holdDurationToMapKeyboardModifierKeyAsPrimary { get; set; }
	public Predicate<ControllerPollingInfo> isElementAllowedCallback { get; set; }

	// Methods

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_allowAxes() { }

	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_allowAxes(bool value) { }

	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0
	public bool get_allowButtons() { }

	// RVA: 0x4BD750 Offset: 0x4BC950 VA: 0x1804BD750
	public void set_allowButtons(bool value) { }

	// RVA: 0x7D0D10 Offset: 0x7CFF10 VA: 0x1807D0D10
	public bool get_allowButtonsOnFullAxisAssignment() { }

	// RVA: 0x7D7A30 Offset: 0x7D6C30 VA: 0x1807D7A30
	public void set_allowButtonsOnFullAxisAssignment(bool value) { }

	// RVA: 0x499030 Offset: 0x498230 VA: 0x180499030
	public float get_timeout() { }

	// RVA: 0x1AADA60 Offset: 0x1AACC60 VA: 0x181AADA60
	public void set_timeout(float value) { }

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_checkForConflicts() { }

	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	public void set_checkForConflicts(bool value) { }

	// RVA: 0x630F40 Offset: 0x630140 VA: 0x180630F40
	public bool get_checkForConflictsWithAllPlayers() { }

	// RVA: 0x630F50 Offset: 0x630150 VA: 0x180630F50
	public void set_checkForConflictsWithAllPlayers(bool value) { }

	// RVA: 0x81F0F0 Offset: 0x81E2F0 VA: 0x18081F0F0
	public bool get_checkForConflictsWithSelf() { }

	// RVA: 0x18AE3F0 Offset: 0x18AD5F0 VA: 0x1818AE3F0
	public void set_checkForConflictsWithSelf(bool value) { }

	// RVA: 0x1AAD7B0 Offset: 0x1AAC9B0 VA: 0x181AAD7B0
	public bool get_checkForConflictsWithSystemPlayer() { }

	// RVA: 0x1AAD8C0 Offset: 0x1AACAC0 VA: 0x181AAD8C0
	public void set_checkForConflictsWithSystemPlayer(bool value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public int[] get_checkForConflictsWithPlayerIds() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_checkForConflictsWithPlayerIds(int[] value) { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public InputMapper.ConflictResponse get_defaultActionWhenConflictFound() { }

	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	public void set_defaultActionWhenConflictFound(InputMapper.ConflictResponse value) { }

	// RVA: 0x48DA50 Offset: 0x48CC50 VA: 0x18048DA50
	public bool get_ignoreMouseXAxis() { }

	// RVA: 0x48DA70 Offset: 0x48CC70 VA: 0x18048DA70
	public void set_ignoreMouseXAxis(bool value) { }

	// RVA: 0x48DA60 Offset: 0x48CC60 VA: 0x18048DA60
	public bool get_ignoreMouseYAxis() { }

	// RVA: 0x48DA80 Offset: 0x48CC80 VA: 0x18048DA80
	public void set_ignoreMouseYAxis(bool value) { }

	// RVA: 0x1AAD790 Offset: 0x1AAC990 VA: 0x181AAD790
	public bool get_allowKeyboardKeysWithModifiers() { }

	// RVA: 0x1AAD8A0 Offset: 0x1AACAA0 VA: 0x181AAD8A0
	public void set_allowKeyboardKeysWithModifiers(bool value) { }

	// RVA: 0x1AAD7A0 Offset: 0x1AAC9A0 VA: 0x181AAD7A0
	public bool get_allowKeyboardModifierKeyAsPrimary() { }

	// RVA: 0x1AAD8B0 Offset: 0x1AACAB0 VA: 0x181AAD8B0
	public void set_allowKeyboardModifierKeyAsPrimary(bool value) { }

	// RVA: 0x527470 Offset: 0x526670 VA: 0x180527470
	public float get_holdDurationToMapKeyboardModifierKeyAsPrimary() { }

	// RVA: 0x1AAD8D0 Offset: 0x1AACAD0 VA: 0x181AAD8D0
	public void set_holdDurationToMapKeyboardModifierKeyAsPrimary(float value) { }

	// RVA: 0x1AAD7C0 Offset: 0x1AAC9C0 VA: 0x181AAD7C0
	public Predicate<ControllerPollingInfo> get_isElementAllowedCallback() { }

	// RVA: 0x1AAD8F0 Offset: 0x1AACAF0 VA: 0x181AAD8F0
	public void set_isElementAllowedCallback(Predicate<ControllerPollingInfo> value) { }

	// RVA: -1 Offset: -1
	internal  wzZkeyeNqMELWSyspkTjjleuMtZT<>(string ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD50B0 Offset: 0xAD42B0 VA: 0x180AD50B0
	|-InputMapper.Options.wzZkeyeNqMELWSyspkTjjleuMtZT<object>
	*/

	// RVA: 0x1AAD4E0 Offset: 0x1AAC6E0 VA: 0x181AAD4E0
	public void .ctor() { }

	// RVA: 0x1AAD3A0 Offset: 0x1AAC5A0 VA: 0x181AAD3A0
	private void .ctor(InputMapper.Options ) { }

	// RVA: 0x1AACA60 Offset: 0x1AABC60 VA: 0x181AACA60
	public InputMapper.Options Clone() { }

	// RVA: 0x1AACEB0 Offset: 0x1AAC0B0 VA: 0x181AACEB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AAD5C0 Offset: 0x1AAC7C0 VA: 0x181AAD5C0
	internal void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }

	// RVA: 0x1AACBD0 Offset: 0x1AABDD0 VA: 0x181AACBD0
	public static void Copy(InputMapper.Options source, InputMapper.Options destination) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class InputMapper.ouIqOYjbKiGZdoINoEDBIBKlAwoQA // TypeDefIndex: 7030
{
	// Fields
	public static readonly InputMapper.ouIqOYjbKiGZdoINoEDBIBKlAwoQA <>9; // 0x0
	public static Action<Exception> <>9__54_0; // 0x8
	public static Action<Exception> <>9__54_1; // 0x10
	public static Action<Exception> <>9__54_2; // 0x18
	public static Action<Exception> <>9__54_3; // 0x20
	public static Action<Exception> <>9__54_4; // 0x28
	public static Action<Exception> <>9__54_5; // 0x30
	public static Action<Exception> <>9__54_6; // 0x38

	// Methods

	// RVA: 0x1ABAB40 Offset: 0x1AB9D40 VA: 0x181ABAB40
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1ABAD80 Offset: 0x1AB9F80 VA: 0x181ABAD80
	internal void vNpRZGZNqAmmoVSvCEFXjjIhmEXt(Exception ) { }

	// RVA: 0x1ABAAE0 Offset: 0x1AB9CE0 VA: 0x181ABAAE0
	internal void StAeNHhrwCAzKUnCHLunDHqEEjWDc(Exception ) { }

	// RVA: 0x1ABAC60 Offset: 0x1AB9E60 VA: 0x181ABAC60
	internal void oayhWjCgNifdLqCUinuHvDOJMVkT(Exception ) { }

	// RVA: 0x1ABAC00 Offset: 0x1AB9E00 VA: 0x181ABAC00
	internal void hQnWuQrHOZlFQyEKyqriQHKkmUIN(Exception ) { }

	// RVA: 0x1ABABA0 Offset: 0x1AB9DA0 VA: 0x181ABABA0
	internal void glSudkOSyASVFzLgXsDeLVrrfSbM(Exception ) { }

	// RVA: 0x1ABACC0 Offset: 0x1AB9EC0 VA: 0x181ABACC0
	internal void pgtAtDkjPydptjOjPWxwCSqMywOSA(Exception ) { }

	// RVA: 0x1ABAD20 Offset: 0x1AB9F20 VA: 0x181ABAD20
	internal void uweBtOanGKxmDBhKDXPDrOvcwOhrA(Exception ) { }
}

// Namespace: Rewired
public sealed class InputMapper // TypeDefIndex: 7031
{
	// Fields
	private static InputMapper YczwqvyOwqYoELcitbwVGXbgCewT; // 0x0
	private static int vzvQZaGGvhLHYMcuLKREDuKhcelO; // 0x8
	private readonly int UEJdcyVHIlOZIUknyrmAhOtfOGyD; // 0x10
	private readonly bool OZkowFRhfHfOettXzZNxmdWFgvkK; // 0x14
	private readonly InputMapper.gtsgkRJkVZFGIhVbiBfEyxTgnwTec SAGoaasCPFEkNKaCTJmbnMDkAAiqA; // 0x18
	private InputMapper.Options BJcanMEoOfLuDMVmBAUUiVxWkCUEb; // 0x20
	private readonly Dictionary<InputMapper.BKyxTIiJgJTqTWloWnakORakxEaT, SafeDelegate> iwiyRoohWYTfeGMNPEwHPkyTdYtl; // 0x28

	// Properties
	public static InputMapper Default { get; }
	public InputMapper.Options options { get; set; }
	public InputMapper.Context mappingContext { get; }
	public InputMapper.Status status { get; }
	public float timeRemaining { get; }
	internal int gZRVLTLFvzHLnHzyXnyINHHHdyI { get; }

	// Methods

	// RVA: 0x1A96580 Offset: 0x1A95780 VA: 0x181A96580
	public static InputMapper get_Default() { }

	// RVA: 0x1A96D20 Offset: 0x1A95F20 VA: 0x181A96D20
	private static int vxPCcwFiqpqjqCeAqbfcIftoBrCkA() { }

	// RVA: 0x1A96630 Offset: 0x1A95830 VA: 0x181A96630
	public InputMapper.Options get_options() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_options(InputMapper.Options value) { }

	// RVA: 0x1A965F0 Offset: 0x1A957F0 VA: 0x181A965F0
	public InputMapper.Context get_mappingContext() { }

	// RVA: 0x1A966D0 Offset: 0x1A958D0 VA: 0x181A966D0
	public InputMapper.Status get_status() { }

	// RVA: 0x1A966F0 Offset: 0x1A958F0 VA: 0x181A966F0
	public float get_timeRemaining() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	internal int qKnsbSpLPCsKooAczkGYXMRgCjnCA() { }

	// RVA: 0x1A96210 Offset: 0x1A95410 VA: 0x181A96210
	public void add_InputMappedEvent(Action<InputMapper.InputMappedEventData> value) { }

	// RVA: 0x1A969B0 Offset: 0x1A95BB0 VA: 0x181A969B0
	public void remove_InputMappedEvent(Action<InputMapper.InputMappedEventData> value) { }

	// RVA: 0x1A96130 Offset: 0x1A95330 VA: 0x181A96130
	public void add_ErrorEvent(Action<InputMapper.ErrorEventData> value) { }

	// RVA: 0x1A968D0 Offset: 0x1A95AD0 VA: 0x181A968D0
	public void remove_ErrorEvent(Action<InputMapper.ErrorEventData> value) { }

	// RVA: 0x1A95F70 Offset: 0x1A95170 VA: 0x181A95F70
	public void add_CanceledEvent(Action<InputMapper.CanceledEventData> value) { }

	// RVA: 0x1A96710 Offset: 0x1A95910 VA: 0x181A96710
	public void remove_CanceledEvent(Action<InputMapper.CanceledEventData> value) { }

	// RVA: 0x1A964A0 Offset: 0x1A956A0 VA: 0x181A964A0
	public void add_TimedOutEvent(Action<InputMapper.TimedOutEventData> value) { }

	// RVA: 0x1A96C40 Offset: 0x1A95E40 VA: 0x181A96C40
	public void remove_TimedOutEvent(Action<InputMapper.TimedOutEventData> value) { }

	// RVA: 0x1A962E0 Offset: 0x1A954E0 VA: 0x181A962E0
	public void add_StartedEvent(Action<InputMapper.StartedEventData> value) { }

	// RVA: 0x1A96A80 Offset: 0x1A95C80 VA: 0x181A96A80
	public void remove_StartedEvent(Action<InputMapper.StartedEventData> value) { }

	// RVA: 0x1A963C0 Offset: 0x1A955C0 VA: 0x181A963C0
	public void add_StoppedEvent(Action<InputMapper.StoppedEventData> value) { }

	// RVA: 0x1A96B60 Offset: 0x1A95D60 VA: 0x181A96B60
	public void remove_StoppedEvent(Action<InputMapper.StoppedEventData> value) { }

	// RVA: 0x1A96050 Offset: 0x1A95250 VA: 0x181A96050
	public void add_ConflictFoundEvent(Action<InputMapper.ConflictFoundEventData> value) { }

	// RVA: 0x1A967F0 Offset: 0x1A959F0 VA: 0x181A967F0
	public void remove_ConflictFoundEvent(Action<InputMapper.ConflictFoundEventData> value) { }

	// RVA: 0x1A95F00 Offset: 0x1A95100 VA: 0x181A95F00
	public void .ctor() { }

	// RVA: 0x1A95690 Offset: 0x1A94890 VA: 0x181A95690
	private void .ctor(bool ) { }

	// RVA: 0x1A95480 Offset: 0x1A94680 VA: 0x181A95480
	public void RemoveEventListeners(object listenerOrParent) { }

	// RVA: 0x1A95350 Offset: 0x1A94550 VA: 0x181A95350
	public void RemoveAllEventListeners() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void qHwUJXsuHwjcbTxvmnulzZpWiQYk(object ) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void IrNguaIHrKftUsnRBxChNAdQomFm() { }

	// RVA: 0x1A955D0 Offset: 0x1A947D0 VA: 0x181A955D0
	public bool Start(InputMapper.Context mappingContext) { }

	// RVA: 0x1A95630 Offset: 0x1A94830 VA: 0x181A95630
	public void Stop() { }

	// RVA: 0x1A95160 Offset: 0x1A94360 VA: 0x181A95160
	public void Clear() { }

	// RVA: 0x1A951D0 Offset: 0x1A943D0 VA: 0x181A951D0
	private bool OVAHhXYoWnOfgTkcQdOcZntUEeNb(InputMapper.Context , InputMapper.Options ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSaveData.XWklddWaIWIsoCuOmeEkkNpvtboEA : IDisposable, IEnumerable, IEnumerator, IEnumerable<ControllerMapSaveData>, IEnumerator<ControllerMapSaveData> // TypeDefIndex: 7032
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerMapSaveData lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public PlayerSaveData nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	public PlayerSaveData zumDdRoqjgAzcCOTFbwklyYTTvQv; // 0x50
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x78

	// Properties
	private ControllerMapSaveData System.Collections.Generic.IEnumerator<Rewired.ControllerMapSaveData>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AB9220 Offset: 0x1AB8420 VA: 0x181AB9220 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private ControllerMapSaveData System.Collections.Generic.IEnumerator<Rewired.ControllerMapSaveData>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AB9500 Offset: 0x1AB8700 VA: 0x181AB9500 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AB9430 Offset: 0x1AB8630 VA: 0x181AB9430 Slot: 9
	private IEnumerator<ControllerMapSaveData> System.Collections.Generic.IEnumerable<Rewired.ControllerMapSaveData>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AB9430 Offset: 0x1AB8630 VA: 0x181AB9430 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Rewired
public struct PlayerSaveData // TypeDefIndex: 7033
{
	// Fields
	private JoystickMapSaveData[] ZEcqxuwthHJeOhFGXhqOMOPJeJHD; // 0x0
	private KeyboardMapSaveData[] fxQdbAeQMGpfdjZLeLarBxFPZWlAA; // 0x8
	private MouseMapSaveData[] BfPhtRdozcmTPASMgpstfyHiUBFL; // 0x10
	private CustomControllerMapSaveData[] PjCfGBfAKnkQlAqiKzHzDvjAfTvuA; // 0x18
	private InputBehavior[] sBYwILVpiGIUqEORWSUhGSoqTCjs; // 0x20

	// Properties
	public JoystickMapSaveData[] joystickMapSaveData { get; }
	public KeyboardMapSaveData[] keyboardMapSaveData { get; }
	public MouseMapSaveData[] mouseMapSaveData { get; }
	public CustomControllerMapSaveData[] customControllerMapSaveData { get; }
	public InputBehavior[] inputBehaviors { get; }
	public int joystickMapCount { get; }
	public int keyboardMapCount { get; }
	public int mouseMapCount { get; }
	public int customControllerMapCount { get; }
	public int inputBehaviorCount { get; }
	public IEnumerable<ControllerMapSaveData> AllControllerMapSaveData { get; }

	// Methods

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public JoystickMapSaveData[] get_joystickMapSaveData() { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public KeyboardMapSaveData[] get_keyboardMapSaveData() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public MouseMapSaveData[] get_mouseMapSaveData() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public CustomControllerMapSaveData[] get_customControllerMapSaveData() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public InputBehavior[] get_inputBehaviors() { }

	// RVA: 0xBB1580 Offset: 0xBB0780 VA: 0x180BB1580
	public int get_joystickMapCount() { }

	// RVA: 0x1AADC90 Offset: 0x1AACE90 VA: 0x181AADC90
	public int get_keyboardMapCount() { }

	// RVA: 0x727230 Offset: 0x726430 VA: 0x180727230
	public int get_mouseMapCount() { }

	// RVA: 0x72F450 Offset: 0x72E650 VA: 0x18072F450
	public int get_customControllerMapCount() { }

	// RVA: 0x1988270 Offset: 0x1987470 VA: 0x181988270
	public int get_inputBehaviorCount() { }

	// RVA: 0x1AADC00 Offset: 0x1AACE00 VA: 0x181AADC00
	public IEnumerable<ControllerMapSaveData> get_AllControllerMapSaveData() { }

	// RVA: 0x1AADA80 Offset: 0x1AACC80 VA: 0x181AADA80
	internal void .ctor(JoystickMapSaveData[] , KeyboardMapSaveData[] , MouseMapSaveData[] , CustomControllerMapSaveData[] , IList<InputBehavior> ) { }
}

// Namespace: 
internal class EOUWaxCVQTNDomlxVsogCIpJuUVB // TypeDefIndex: 7034
{
	// Fields
	protected int SYiCAEAKsjvCSpVgcZytTbhciMRHA; // 0x10
	protected int fgBdvqArnypsIkvbhrmwPUYhcOGeb; // 0x14
	protected bool PdNkMQDbrYvyAdfYQtglbhEgdJNd; // 0x18

	// Properties
	public int wGBlZAeXywpnLTVAippvBHBjeoet { get; set; }
	public int ppwwEgCehGMcBPsXOPpaCHhanCRd { get; set; }
	public bool VJwKSskKutcbowZMaUWexsuifvCW { get; set; }

	// Methods

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int PcwmUSMDDWbjNfgLenFfWEXLWkKFA() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	internal void agwrqjwkphLyJewepWkOzIeySpDg(int ) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int fxBpHJsSNUWyifqAqtUXlioUByuX() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	internal void JtcdVSQbvatVgRVnyQjilPdaoaFV(int ) { }

	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool ohUaWkBmpSOstLzTSHKqvgTJGCVw() { }

	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	internal void zqdPHQRzYqBURnJGcvtpauyBCSYB(bool ) { }

	// RVA: 0x1AAC9D0 Offset: 0x1AABBD0 VA: 0x181AAC9D0
	public void .ctor(int , int , bool ) { }
}

// Namespace: 
internal class NAbWnuemoUtDRnJvbekVDdUYjrWbb // TypeDefIndex: 7035
{
	// Fields
	protected bool PdNkMQDbrYvyAdfYQtglbhEgdJNd; // 0x10
	protected int yAQloNnkxShCOoclhwMCxCpNptHE; // 0x14

	// Properties
	public bool VJwKSskKutcbowZMaUWexsuifvCW { get; set; }
	public int gZRVLTLFvzHLnHzyXnyINHHHdyI { get; set; }

	// Methods

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool ohUaWkBmpSOstLzTSHKqvgTJGCVw() { }

	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	internal void zqdPHQRzYqBURnJGcvtpauyBCSYB(bool ) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int qKnsbSpLPCsKooAczkGYXMRgCjnCA() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	internal void jWfqAPTWFZaggTsWsqOzmMkiSuHs(int ) { }

	// RVA: 0x1AACA20 Offset: 0x1AABC20 VA: 0x181AACA20
	public void .ctor(int , bool ) { }
}

// Namespace: 
private static class cidKYEYfilZUghEJjscRPOmFGgLi.DrinIvaFzuAvIaelCoUpvmtGIlMf.aLBguJHoCYSOMZCskAgCQAAOZxtL // TypeDefIndex: 7036
{
	// Methods

	// RVA: 0x1ABA2B0 Offset: 0x1AB94B0 VA: 0x181ABA2B0
	public static byte[] pkjkEACCbpZIVujHaMDfOiVzloYj(TextAsset , long ) { }

	// RVA: 0x1AB9B40 Offset: 0x1AB8D40 VA: 0x181AB9B40
	public static byte[] pkjkEACCbpZIVujHaMDfOiVzloYj(byte[] , long ) { }

	// RVA: 0x1AB9F20 Offset: 0x1AB9120 VA: 0x181AB9F20
	private static byte[] pkjkEACCbpZIVujHaMDfOiVzloYj(byte[] , string ) { }

	// RVA: 0x1AB9A50 Offset: 0x1AB8C50 VA: 0x181AB9A50
	public static Stream hOvZdrRfmtncyeiGQjycxNBnZLrF(string , Encoding ) { }
}

// Namespace: 
private static class cidKYEYfilZUghEJjscRPOmFGgLi.DrinIvaFzuAvIaelCoUpvmtGIlMf // TypeDefIndex: 7037
{
	// Fields
	private const string bhbFiNEESyifPQNJwnnRrGVBMcuA = "Rewired.Decrypter.bin";

	// Methods

	// RVA: 0x1AAC3F0 Offset: 0x1AAB5F0 VA: 0x181AAC3F0
	public static List<Assembly> ukmDrRAnhxpgFyirMLdScqFFEqccb(List<TextAsset> , bool , string , long ) { }

	// RVA: 0x1AAC1C0 Offset: 0x1AAB3C0 VA: 0x181AAC1C0
	private static void pdGvsVHGmKlLKEInVycBOlvbColGA(Stream , Stream ) { }

	// RVA: 0x1AABFE0 Offset: 0x1AAB1E0 VA: 0x181AABFE0
	private static long OxKdhkGeCayEhrPHNbAeyhAyZyLEA(Assembly , long ) { }

	// RVA: 0x1AAC290 Offset: 0x1AAB490 VA: 0x181AAC290
	public static List<Assembly> ukmDrRAnhxpgFyirMLdScqFFEqccb(List<TextAsset> , bool , long  = 0) { }

	// RVA: 0x1AAC7D0 Offset: 0x1AAB9D0 VA: 0x181AAC7D0
	private static Assembly wabUGMCcMEBZEArykJxddRGdGdEMB(TextAsset , bool , long ) { }
}

// Namespace: 
internal static class cidKYEYfilZUghEJjscRPOmFGgLi // TypeDefIndex: 7038
{
	// Fields
	private const string GnZWDNiuXTDuTHJXRCoybpDPpGWZ = "Rewired.InputManagers.Initializer";
	private const string RXOJJRWNdsLQjpzFGemkdcUAgxPm = "MU>SOe2)EH[T<)gNSVyMG.\\gO|q>{]!h&,4A(ty{QbSXT@j6V<n^],cupp3t5[)qL?B&SL:fv^8s.YLA,?qZ98A0,wPS%~j>\'rXVep66\'&6<IxB[mY!L}b@:LRB?!)*<lV%Gn$5K\'UF<+,El)OIYzM[+2FElC1AZ^?nU,k?x~~g8eGTUim8aJm.Kv|8qEDn|xI&4mU?^Y!L?bOZ|SD7b};Ya4^?/kOE93S:)6h:!0JX+?88$l8X+9#km1$zV:H\\AlFmPmmJ44]4gS{sk3+e/+Cx1^4b,P^agN^P_e{k\\Z@SVs7,w)b]Ll^/ufmPr#wEt;viv\'&|a1w8.~/CKw%RE,!O{RlruVDPxh>3;2;NySeW*Niu%zCs^<KplfF>@JWG47z3*JJ>xHQ`!a*9*0uL4Z`\'?o\\|)X].UMa4649kDQozevQcHBMg.+l\'0:I+z{JYf5VxhhU}:Ft62SGEs}_Ufx0o$wxoe<AF8Y_0fMwlSu3]oqN|pUEPXQ|(A6%],*s/e+/2mR|&G>A|J18!0&jvrv)4P%Lr2&(i*77v!?E1EJ),)(SPuY7lfi5zm&s!tp_U$hj6WK8jL`L)cEFw4Ukg^9zR`fO>|cg3:]GmkW)Kc^K`YAM(`KxI%PG;?H\\f[y[p^mChqGT#_&(/Cl$}/4mPVtCRMpsBtggTl$$9&w7]i1?ncp;JDk9cZhyzDPXg#7[b#[][bZ@$4$,mD#Si\'1$%bZkxw]Fn#tf<14SQPEN,lmL%:<8f1bMax{/5T`nF$f!1iOJ4gA\\7&9ZU3zl/hGz\'`>Tu)CwL|hZjYBgT<kOQA\'t[24~&eRFX89Rw8H\'gWOwShCxqC|wy1>Sqi]#GfO:!SRwsLFJR(0)p:3R[hk4>v*]VPwpWZ?f;V5Jn4j`^UxSaKL,B6tFK0vqe\'xY#uo3PL\\MkkY%;>n83GKXLwz~t,orJx71sHIH}JlX!$Pz\'[Ok\\*AKB&E5J>jqOA~^1`7]n&,[42PBaq]:Z!+zG%kx%5C\\F[BT;}a4}UX#%eEm0C&A+@x0&{kl`!YW(97S!~v7KF*0@44x8x4bR\\.G<1#\'[#y4pkSx^,\\qf#YEy*CFCg$u?nZ*fAn`t6<r?H!:;$F3R61h&$.3~8AP\\F,QEsJ@|.h,o#YW5e7$i8to{P%BO%rXKqZ\\ut<hY6RE7YM|v#]NnWB\'BMYUsr[T~LC&(Y?)xVbl`T:^)<p{lajJUghu<C`*){`fK5D>jL$/vv[g}IoFvFD`83E4<\\3S\'DQrX<!w8a+cYZWRmHtOscY(DT&2w`}WBrGf2$<\\.\'1;\'g/MKLBOH9;1f|*2T[wnQL^e[lROs2tur?W!)U/1|u$\\j^W1I1xA]i8TGkGU5x(`iD[#<>woZFr:HTmM)Tfh+<8uh(fi_rDU$x[`ZU%*qr?~2^8Hp]pQczbLGuy~b/qrG&#j*I;5{yUH]%/\'j>iq{ya+08xrVC1FsIx?&c.8)6ZTux<66!,}l(XZj^Db_vH+~U0/;\'DmIJMs&V2/nRD}Zqb,K`2CscXo$8EO|xr<]xz,9$h{)T*U_4J}Zzao*7w;}kp7)%}Of1\'x.&kaj\'%bTJXu;<Zfg!]`<*]4i$DYqZH^9RMo`+{stC\'i[x`PKPPGou6xcr4Cz0NmXS`)Y@7S}npvE&*M|QOknF!PhUk!i,)5Zh0^7~x%#r8Y.\'U^)_TAQ8QG,g\\#b%H7#\'#.nP3DeuNy7G>s)f_:.G6.H2XBWDa7{$EK([&b^2|yc<h}om,@tCZ#K>;)4x`xM.@CsY$#S^,*e%0Ml$Y>m0CE6D:?8K}_Ml\\shxlAF&S:_ikAEmJI5|W<<o?fO9eIRN8~Kw:[tvOX3LK*C[^;J^Y[Vaw9QAA]n:`s,@/#F1|4ge@.4Z}vYp*QXuMEUmL.|aB}M?\'5eEtYfpc!VW;#_J:[l.}TLTk|XE_&E0Pf%$\\##rsp$+g$fJWb8A$hpe90E\\]u3Mq9F/?.Ex<#^]6+j)qB~oLsn//_?F7.``BEUW}eXkBc+m.?m6JF2(bo&pmFS_{42J+T9%pRxm`3K9./LYao~3a4jY&HHj?/k,l<:0sN(4vY:8J#CVeG(n_tuH)`i^#,c&0}P*iywKAU|U}I`w9\\[`xjt7Sf\\5iO5pf}*><$n3Mv0zLWFj7Yzwej[5p_L2yonxNY5Nc`;&SFWPXp1Y\\3[|}`TN\\kO^_sF!*<xrGr3<*K0,}H[@>Wb$sw.}wf/eu>R1TfAyS78@hf%lr`10\'}0SDD#h4W*casB[WEQ%>K7439)Xy0<GXA[LFiqn\\,/hWnUm@8Hxv1YgHctRs!m7}?uTy@E1~LS3\'uCk7[ONXsomzGg,clj9+8W6~P^;lZy%A#C:z2ybXs*`SYp~/\'Uus;rtKYS^~BDr,q3\'F7i|(\\?,\\@#0U,C^.#t^Da8Y+}ep,:s)>IX7Dzse2sw8^R_~|C7jANFaW7F.+ZWf>G^.MN_<T[7+8ED3`Mw3h3Tl!gktN?MRvFW1ymOz:rg2Xv|/+&z(ZrKGWr\'v\']m?FW|].Il|6B#fIX|lSJ^+,*ihNS`4O@%%)}a0bgm0o\'|yVvU$X?@8j/vwyF<\'J;[y3p\'>a*m*hmB\'Z{$bOaz,X.nFS5(]OSyF_x/XF^_IujNvYWDYgN&LpGjXn6E)Yzv~6>Aoq6r%lk}#G2,^.QTZ0j,q{ul,,1!tpB\\Ut_bQ!2l;CVY<78gz0W_I&mZ9A]N+k}{$^%c8#i^9sZ2G:w@s!h\'ge)@KRW`M?T.ThUo#EPsHGEGM19@B\\.6h{&w8scf:2WK(e4Jv}O&6jJ%O7Tb0A/G7F68vfg}gegzO,S/PmNnOIwO8wJ(oG|Hgm$CO!t99`z0tTfWCOOU\')P]brSeUUzp3<mK&a56oMM@hP.P16NGPCi\\|r<>fTKZ%vt~Z8tZ%@iP(.5e$C*}0VJGRh>S\\Y}E2]pkOF$\'RW0$\'CNmuV/]sQ8Q*LP\\7[/}Taq3zS_C./_%|T>IG/7\\]?UWMA9Fzzm9j2k><\\0$2D0T,lZ>y`s;~&p#$L$s>En\'NnH.I";
	private const long zRSpGYUBsxVzlvqpNOwKExcyQjTK = -239732958399843948;
	private static int KiilMdUEPQFwcHpphOONEqurHuSGA; // 0x0
	private static int KclEznIUocfgsBWLzfepnZXIFiTu; // 0x4
	private static int JMinNSRCJrFJrFQZOPttLZBijtsiA; // 0x8
	private static string jIbsduswzZodgFIoVPTrwGDKYSHv; // 0x10
	private static List<Assembly> mMYACCnkRzNAOAfyBpVbETaZzdOf; // 0x18

	// Methods

	// RVA: 0x1ABA5B0 Offset: 0x1AB97B0 VA: 0x181ABA5B0
	public static object ZFUcTEcndvHgBpdTmEAgSebxfOsJ(string , List<TextAsset> , ConfigVars , bool ) { }

	// RVA: 0x1ABA770 Offset: 0x1AB9970 VA: 0x181ABA770
	public static object ZFUcTEcndvHgBpdTmEAgSebxfOsJ(string , List<Assembly> , ConfigVars ) { }

	// RVA: 0x1ABA350 Offset: 0x1AB9550 VA: 0x181ABA350
	public static object TfwSYUlMGvCVeAFOXZNRUbxnRUgD(string , string ) { }

	// RVA: 0x1ABAA20 Offset: 0x1AB9C20 VA: 0x181ABAA20
	public static PlatformInitializer sArYPiCqrJTdDxlcZuMtvQtyECbO(Type ) { }

	// RVA: 0x1ABA9D0 Offset: 0x1AB9BD0 VA: 0x181ABA9D0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.ConflictCheckingHelper.cBirbBfOwJTQfdagKzIQkRdhBRYS : IDisposable, IEnumerable, IEnumerator, IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 7039
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ElementAssignmentConflictInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x14
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x40
	private int KFrkqcMhAhkuwDBDacKNtYSrhuaI; // 0x44
	public int KOPJxxEEfECOHiZOqJNzPzlAGPiF; // 0x48
	private CustomControllerMap cPmuXAVNIraLtaZVxEUyKUBNBMdj; // 0x50
	public CustomControllerMap NxXRskbrnGLCaJHGtJRBglCyDPZhA; // 0x58
	public Player.ControllerHelper.ConflictCheckingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x60
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x68
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x69
	private bool JnqhrBwoxcwlbFFeBHHBDiitpZaab; // 0x6A
	public bool qBChZzPpwxmEMfXFsrRNlxjIanHl; // 0x6B
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x6C
	private IEnumerator<ElementAssignmentConflictInfo> FrrinBtHtwjQHWNUKhBdvpNvuGOV; // 0x70

	// Properties
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xE7ACF0 Offset: 0xE79EF0 VA: 0x180E7ACF0
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1AD6C00 Offset: 0x1AD5E00 VA: 0x181AD6C00 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AD66B0 Offset: 0x1AD58B0 VA: 0x181AD66B0 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x1AD6C90 Offset: 0x1AD5E90 VA: 0x181AD6C90
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x798F40 Offset: 0x798140 VA: 0x180798F40 Slot: 10
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AD6B60 Offset: 0x1AD5D60 VA: 0x181AD6B60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1AD6BA0 Offset: 0x1AD5DA0 VA: 0x181AD6BA0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AD6A80 Offset: 0x1AD5C80 VA: 0x181AD6A80 Slot: 9
	private IEnumerator<ElementAssignmentConflictInfo> System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AD6A80 Offset: 0x1AD5C80 VA: 0x181AD6A80 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.ConflictCheckingHelper.aDLkPTzTnrDPHZTLUMGqGBwxfNDe : IDisposable, IEnumerable, IEnumerator, IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 7040
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ElementAssignmentConflictInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x14
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x40
	private int KFrkqcMhAhkuwDBDacKNtYSrhuaI; // 0x44
	public int KOPJxxEEfECOHiZOqJNzPzlAGPiF; // 0x48
	private ActionElementMap uLOhCSEvDgEZSdSinJStADYFhbic; // 0x50
	public ActionElementMap wZSRhFCbWOtixaksTFwYrKjQmVRq; // 0x58
	public Player.ControllerHelper.ConflictCheckingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x60
	private CustomControllerMap cPmuXAVNIraLtaZVxEUyKUBNBMdj; // 0x68
	public CustomControllerMap NxXRskbrnGLCaJHGtJRBglCyDPZhA; // 0x70
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x78
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x79
	private bool JnqhrBwoxcwlbFFeBHHBDiitpZaab; // 0x7A
	public bool qBChZzPpwxmEMfXFsrRNlxjIanHl; // 0x7B
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x7C
	private IEnumerator<ElementAssignmentConflictInfo> FrrinBtHtwjQHWNUKhBdvpNvuGOV; // 0x80

	// Properties
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xE7ACF0 Offset: 0xE79EF0 VA: 0x180E7ACF0
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1AD65F0 Offset: 0x1AD57F0 VA: 0x181AD65F0 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AD6080 Offset: 0x1AD5280 VA: 0x181AD6080 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x1AD6650 Offset: 0x1AD5850 VA: 0x181AD6650
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x798F40 Offset: 0x798140 VA: 0x180798F40 Slot: 10
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AD6550 Offset: 0x1AD5750 VA: 0x181AD6550 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1AD6590 Offset: 0x1AD5790 VA: 0x181AD6590 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AD6470 Offset: 0x1AD5670 VA: 0x181AD6470 Slot: 9
	private IEnumerator<ElementAssignmentConflictInfo> System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AD6470 Offset: 0x1AD5670 VA: 0x181AD6470 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.ConflictCheckingHelper.yxkXCBjhsdGjlFrGqOfOswtCXLxw : IDisposable, IEnumerable, IEnumerator, IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 7041
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ElementAssignmentConflictInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x14
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x40
	private ElementAssignmentConflictCheck zqwcQAKmowyacotoRHDevIvpNlyi; // 0x44
	public ElementAssignmentConflictCheck ejpVKkYVvFucluBNLhLsNxfggkay; // 0x7C
	public Player.ControllerHelper.ConflictCheckingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0xB8
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0xC0
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0xC1
	private bool JnqhrBwoxcwlbFFeBHHBDiitpZaab; // 0xC2
	public bool qBChZzPpwxmEMfXFsrRNlxjIanHl; // 0xC3
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0xC4
	private IEnumerator<ElementAssignmentConflictInfo> FrrinBtHtwjQHWNUKhBdvpNvuGOV; // 0xC8

	// Properties
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xE7ACF0 Offset: 0xE79EF0 VA: 0x180E7ACF0
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1AD8760 Offset: 0x1AD7960 VA: 0x181AD8760 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AD8170 Offset: 0x1AD7370 VA: 0x181AD8170 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x1AD87C0 Offset: 0x1AD79C0 VA: 0x181AD87C0
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x798F40 Offset: 0x798140 VA: 0x180798F40 Slot: 10
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AD86C0 Offset: 0x1AD78C0 VA: 0x181AD86C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1AD8700 Offset: 0x1AD7900 VA: 0x181AD8700 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AD85B0 Offset: 0x1AD77B0 VA: 0x181AD85B0 Slot: 9
	private IEnumerator<ElementAssignmentConflictInfo> System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AD85B0 Offset: 0x1AD77B0 VA: 0x181AD85B0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.ConflictCheckingHelper.BbYEGaFeNWQgTLCWvCyNqvvOLwwCb<> : IDisposable, IEnumerable, IEnumerator, IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 7042
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x0
	private ElementAssignmentConflictInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x0
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x0
	private VOLZYtSxBAfSvCRXgiPmhhdoQwVG<> RpWPAshhtNyRAOOwEtQvyzhZMTGl; // 0x0
	public VOLZYtSxBAfSvCRXgiPmhhdoQwVG<> UuRTqxDILXoTJYgIhiJkbGLYOtRVA; // 0x0
	private  dKpyExXdUEgykClTklFuhNbjsdSXb; // 0x0
	public  uddCdHbMsCqRnKbLRYtWomnBegjW; // 0x0
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x0
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x0
	private bool JnqhrBwoxcwlbFFeBHHBDiitpZaab; // 0x0
	public bool qBChZzPpwxmEMfXFsrRNlxjIanHl; // 0x0
	public Player.ControllerHelper.ConflictCheckingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x0
	private ControllerType NMffiLTHzqUxHGHtSDFItLeHQjBM; // 0x0
	public ControllerType YTKzrzsAvZSLWXLsivcmRDiNtZwm; // 0x0
	private int WIxUkBBWNKpbtZkOmCmejhrcMZvDb; // 0x0
	public int PQOKvAwHAiekOtXedIfoUEhfDGPY; // 0x0
	private InputMapCategory usdJKdnarKpHlmaCJULAAJaafvtz; // 0x0
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x0
	private IEnumerator<ElementAssignmentConflictInfo> ZjMCsBmztIFLBJekJGcndCgeCEXkA; // 0x0

	// Properties
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7ACF0 Offset: 0xE79EF0 VA: 0x180E7ACF0
	|-Player.ControllerHelper.ConflictCheckingHelper.BbYEGaFeNWQgTLCWvCyNqvvOLwwCb<object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE2B60 Offset: 0xEE1D60 VA: 0x180EE2B60
	|-Player.ControllerHelper.ConflictCheckingHelper.BbYEGaFeNWQgTLCWvCyNqvvOLwwCb<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE23E0 Offset: 0xEE15E0 VA: 0x180EE23E0
	|-Player.ControllerHelper.ConflictCheckingHelper.BbYEGaFeNWQgTLCWvCyNqvvOLwwCb<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE2BD0 Offset: 0xEE1DD0 VA: 0x180EE2BD0
	|-Player.ControllerHelper.ConflictCheckingHelper.BbYEGaFeNWQgTLCWvCyNqvvOLwwCb<object>.YdjRduvJdaCxcHHEwmxdjVhcLPut
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x798F40 Offset: 0x798140 VA: 0x180798F40
	|-Player.ControllerHelper.ConflictCheckingHelper.BbYEGaFeNWQgTLCWvCyNqvvOLwwCb<object>.System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-Player.ControllerHelper.ConflictCheckingHelper.BbYEGaFeNWQgTLCWvCyNqvvOLwwCb<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE2B00 Offset: 0xEE1D00 VA: 0x180EE2B00
	|-Player.ControllerHelper.ConflictCheckingHelper.BbYEGaFeNWQgTLCWvCyNqvvOLwwCb<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private IEnumerator<ElementAssignmentConflictInfo> System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE2900 Offset: 0xEE1B00 VA: 0x180EE2900
	|-Player.ControllerHelper.ConflictCheckingHelper.BbYEGaFeNWQgTLCWvCyNqvvOLwwCb<object>.System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE2A00 Offset: 0xEE1C00 VA: 0x180EE2A00
	|-Player.ControllerHelper.ConflictCheckingHelper.BbYEGaFeNWQgTLCWvCyNqvvOLwwCb<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.ConflictCheckingHelper.wtEAJEcqnqFHuRmyywSiGcoEbQKgA<> : IDisposable, IEnumerable, IEnumerator, IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 7043
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x0
	private ElementAssignmentConflictInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x0
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x0
	private VOLZYtSxBAfSvCRXgiPmhhdoQwVG<> RpWPAshhtNyRAOOwEtQvyzhZMTGl; // 0x0
	public VOLZYtSxBAfSvCRXgiPmhhdoQwVG<> UuRTqxDILXoTJYgIhiJkbGLYOtRVA; // 0x0
	private ActionElementMap qXqfAkgeJAcuwRxlGAdtXbTvWEFf; // 0x0
	public ActionElementMap CPYNSPHfZZHPJMnAvWRPJUcYgPdP; // 0x0
	private  dKpyExXdUEgykClTklFuhNbjsdSXb; // 0x0
	public  uddCdHbMsCqRnKbLRYtWomnBegjW; // 0x0
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x0
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x0
	private bool JnqhrBwoxcwlbFFeBHHBDiitpZaab; // 0x0
	public bool qBChZzPpwxmEMfXFsrRNlxjIanHl; // 0x0
	public Player.ControllerHelper.ConflictCheckingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x0
	private ControllerType NMffiLTHzqUxHGHtSDFItLeHQjBM; // 0x0
	public ControllerType YTKzrzsAvZSLWXLsivcmRDiNtZwm; // 0x0
	private int WIxUkBBWNKpbtZkOmCmejhrcMZvDb; // 0x0
	public int PQOKvAwHAiekOtXedIfoUEhfDGPY; // 0x0
	private InputMapCategory usdJKdnarKpHlmaCJULAAJaafvtz; // 0x0
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x0
	private IEnumerator<ElementAssignmentConflictInfo> ZjMCsBmztIFLBJekJGcndCgeCEXkA; // 0x0

	// Properties
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7ACF0 Offset: 0xE79EF0 VA: 0x180E7ACF0
	|-Player.ControllerHelper.ConflictCheckingHelper.wtEAJEcqnqFHuRmyywSiGcoEbQKgA<object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7ABB0 Offset: 0xE79DB0 VA: 0x180E7ABB0
	|-Player.ControllerHelper.ConflictCheckingHelper.wtEAJEcqnqFHuRmyywSiGcoEbQKgA<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7A300 Offset: 0xE79500 VA: 0x180E7A300
	|-Player.ControllerHelper.ConflictCheckingHelper.wtEAJEcqnqFHuRmyywSiGcoEbQKgA<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7AC20 Offset: 0xE79E20 VA: 0x180E7AC20
	|-Player.ControllerHelper.ConflictCheckingHelper.wtEAJEcqnqFHuRmyywSiGcoEbQKgA<object>.YdjRduvJdaCxcHHEwmxdjVhcLPut
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x798F40 Offset: 0x798140 VA: 0x180798F40
	|-Player.ControllerHelper.ConflictCheckingHelper.wtEAJEcqnqFHuRmyywSiGcoEbQKgA<object>.System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-Player.ControllerHelper.ConflictCheckingHelper.wtEAJEcqnqFHuRmyywSiGcoEbQKgA<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7AB50 Offset: 0xE79D50 VA: 0x180E7AB50
	|-Player.ControllerHelper.ConflictCheckingHelper.wtEAJEcqnqFHuRmyywSiGcoEbQKgA<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private IEnumerator<ElementAssignmentConflictInfo> System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7A920 Offset: 0xE79B20 VA: 0x180E7A920
	|-Player.ControllerHelper.ConflictCheckingHelper.wtEAJEcqnqFHuRmyywSiGcoEbQKgA<object>.System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7AA30 Offset: 0xE79C30 VA: 0x180E7AA30
	|-Player.ControllerHelper.ConflictCheckingHelper.wtEAJEcqnqFHuRmyywSiGcoEbQKgA<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.ConflictCheckingHelper.LCWhpoebmHKYjpaOmVXznTGPQtcCA<> : IDisposable, IEnumerable, IEnumerator, IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 7044
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x0
	private ElementAssignmentConflictInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x0
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x0
	private VOLZYtSxBAfSvCRXgiPmhhdoQwVG<> RpWPAshhtNyRAOOwEtQvyzhZMTGl; // 0x0
	public VOLZYtSxBAfSvCRXgiPmhhdoQwVG<> UuRTqxDILXoTJYgIhiJkbGLYOtRVA; // 0x0
	private ElementAssignmentConflictCheck zqwcQAKmowyacotoRHDevIvpNlyi; // 0x0
	public ElementAssignmentConflictCheck ejpVKkYVvFucluBNLhLsNxfggkay; // 0x0
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x0
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x0
	private bool JnqhrBwoxcwlbFFeBHHBDiitpZaab; // 0x0
	public bool qBChZzPpwxmEMfXFsrRNlxjIanHl; // 0x0
	public Player.ControllerHelper.ConflictCheckingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x0
	private InputMapCategory usdJKdnarKpHlmaCJULAAJaafvtz; // 0x0
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x0
	private IEnumerator<ElementAssignmentConflictInfo> ZjMCsBmztIFLBJekJGcndCgeCEXkA; // 0x0

	// Properties
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7ACF0 Offset: 0xE79EF0 VA: 0x180E7ACF0
	|-Player.ControllerHelper.ConflictCheckingHelper.LCWhpoebmHKYjpaOmVXznTGPQtcCA<object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131BD20 Offset: 0x131AF20 VA: 0x18131BD20
	|-Player.ControllerHelper.ConflictCheckingHelper.LCWhpoebmHKYjpaOmVXznTGPQtcCA<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131B430 Offset: 0x131A630 VA: 0x18131B430
	|-Player.ControllerHelper.ConflictCheckingHelper.LCWhpoebmHKYjpaOmVXznTGPQtcCA<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131BD90 Offset: 0x131AF90 VA: 0x18131BD90
	|-Player.ControllerHelper.ConflictCheckingHelper.LCWhpoebmHKYjpaOmVXznTGPQtcCA<object>.YdjRduvJdaCxcHHEwmxdjVhcLPut
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x798F40 Offset: 0x798140 VA: 0x180798F40
	|-Player.ControllerHelper.ConflictCheckingHelper.LCWhpoebmHKYjpaOmVXznTGPQtcCA<object>.System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-Player.ControllerHelper.ConflictCheckingHelper.LCWhpoebmHKYjpaOmVXznTGPQtcCA<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131BCC0 Offset: 0x131AEC0 VA: 0x18131BCC0
	|-Player.ControllerHelper.ConflictCheckingHelper.LCWhpoebmHKYjpaOmVXznTGPQtcCA<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private IEnumerator<ElementAssignmentConflictInfo> System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131BA70 Offset: 0x131AC70 VA: 0x18131BA70
	|-Player.ControllerHelper.ConflictCheckingHelper.LCWhpoebmHKYjpaOmVXznTGPQtcCA<object>.System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x131BB90 Offset: 0x131AD90 VA: 0x18131BB90
	|-Player.ControllerHelper.ConflictCheckingHelper.LCWhpoebmHKYjpaOmVXznTGPQtcCA<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.ConflictCheckingHelper.ICnokBZFtmUvrWZqMelRnhIjhidY : IDisposable, IEnumerable, IEnumerator, IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 7045
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ElementAssignmentConflictInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x14
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x40
	private int JTVbKkaOfUHTYeezJJVreQldtfSZ; // 0x44
	public int VpUqGKaMcLfgiswRnLBzNmFSiwVfA; // 0x48
	private JoystickMap kmaKiMEdzxftindoltvbzNNGhHvo; // 0x50
	public JoystickMap hdhZvlXdTmxZhsOUoFyHKClabeNC; // 0x58
	public Player.ControllerHelper.ConflictCheckingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x60
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x68
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x69
	private bool JnqhrBwoxcwlbFFeBHHBDiitpZaab; // 0x6A
	public bool qBChZzPpwxmEMfXFsrRNlxjIanHl; // 0x6B
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x6C
	private IEnumerator<ElementAssignmentConflictInfo> FrrinBtHtwjQHWNUKhBdvpNvuGOV; // 0x70

	// Properties
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xE7ACF0 Offset: 0xE79EF0 VA: 0x180E7ACF0
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1ABC780 Offset: 0x1ABB980 VA: 0x181ABC780 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1ABC230 Offset: 0x1ABB430 VA: 0x181ABC230 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x1ABC810 Offset: 0x1ABBA10 VA: 0x181ABC810
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x798F40 Offset: 0x798140 VA: 0x180798F40 Slot: 10
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1ABC6E0 Offset: 0x1ABB8E0 VA: 0x181ABC6E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1ABC720 Offset: 0x1ABB920 VA: 0x181ABC720 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1ABC600 Offset: 0x1ABB800 VA: 0x181ABC600 Slot: 9
	private IEnumerator<ElementAssignmentConflictInfo> System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1ABC600 Offset: 0x1ABB800 VA: 0x181ABC600 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.ConflictCheckingHelper.ORZDJAGIUCBKIrTDZfNwEwUEfNbyB : IDisposable, IEnumerable, IEnumerator, IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 7046
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ElementAssignmentConflictInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x14
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x40
	private int JTVbKkaOfUHTYeezJJVreQldtfSZ; // 0x44
	public int VpUqGKaMcLfgiswRnLBzNmFSiwVfA; // 0x48
	private ActionElementMap uLOhCSEvDgEZSdSinJStADYFhbic; // 0x50
	public ActionElementMap wZSRhFCbWOtixaksTFwYrKjQmVRq; // 0x58
	public Player.ControllerHelper.ConflictCheckingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x60
	private JoystickMap kmaKiMEdzxftindoltvbzNNGhHvo; // 0x68
	public JoystickMap hdhZvlXdTmxZhsOUoFyHKClabeNC; // 0x70
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x78
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x79
	private bool JnqhrBwoxcwlbFFeBHHBDiitpZaab; // 0x7A
	public bool qBChZzPpwxmEMfXFsrRNlxjIanHl; // 0x7B
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0x7C
	private IEnumerator<ElementAssignmentConflictInfo> FrrinBtHtwjQHWNUKhBdvpNvuGOV; // 0x80

	// Properties
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xE7ACF0 Offset: 0xE79EF0 VA: 0x180E7ACF0
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1AD51C0 Offset: 0x1AD43C0 VA: 0x181AD51C0 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AD4C50 Offset: 0x1AD3E50 VA: 0x181AD4C50 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x1AD5220 Offset: 0x1AD4420 VA: 0x181AD5220
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x798F40 Offset: 0x798140 VA: 0x180798F40 Slot: 10
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AD5120 Offset: 0x1AD4320 VA: 0x181AD5120 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1AD5160 Offset: 0x1AD4360 VA: 0x181AD5160 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AD5040 Offset: 0x1AD4240 VA: 0x181AD5040 Slot: 9
	private IEnumerator<ElementAssignmentConflictInfo> System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AD5040 Offset: 0x1AD4240 VA: 0x181AD5040 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.ConflictCheckingHelper.LKbwuYKHyZXERYPoCAQPGgBfqBdLA : IDisposable, IEnumerable, IEnumerator, IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 7047
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ElementAssignmentConflictInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x14
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x40
	private ElementAssignmentConflictCheck zqwcQAKmowyacotoRHDevIvpNlyi; // 0x44
	public ElementAssignmentConflictCheck ejpVKkYVvFucluBNLhLsNxfggkay; // 0x7C
	public Player.ControllerHelper.ConflictCheckingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0xB8
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0xC0
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0xC1
	private bool JnqhrBwoxcwlbFFeBHHBDiitpZaab; // 0xC2
	public bool qBChZzPpwxmEMfXFsrRNlxjIanHl; // 0xC3
	private int ZrHGYEGpWZaaZvfEbDZwfaEgzuiBc; // 0xC4
	private IEnumerator<ElementAssignmentConflictInfo> FrrinBtHtwjQHWNUKhBdvpNvuGOV; // 0xC8

	// Properties
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xE7ACF0 Offset: 0xE79EF0 VA: 0x180E7ACF0
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1ABD480 Offset: 0x1ABC680 VA: 0x181ABD480 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1ABCE90 Offset: 0x1ABC090 VA: 0x181ABCE90 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x1ABD4E0 Offset: 0x1ABC6E0 VA: 0x181ABD4E0
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x798F40 Offset: 0x798140 VA: 0x180798F40 Slot: 10
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1ABD3E0 Offset: 0x1ABC5E0 VA: 0x181ABD3E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1ABD420 Offset: 0x1ABC620 VA: 0x181ABD420 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1ABD2D0 Offset: 0x1ABC4D0 VA: 0x181ABD2D0 Slot: 9
	private IEnumerator<ElementAssignmentConflictInfo> System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1ABD2D0 Offset: 0x1ABC4D0 VA: 0x181ABD2D0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[Browsable(False)]
[EditorBrowsable(1)]
public sealed class Player.ControllerHelper.ConflictCheckingHelper : CodeHelper // TypeDefIndex: 7048
{
	// Fields
	private readonly Player dKxeWVrXJNsFqEAYKfLlJKDBwaWd; // 0x10
	private readonly Player.ControllerHelper JzLBwDullgkQLozUBYHRGdbOnLzK; // 0x18
	private readonly int aplyKYJQthDqFZJRnEooAHmQTlabA; // 0x20

	// Methods

	// RVA: 0x1AA4040 Offset: 0x1AA3240 VA: 0x181AA4040
	internal void .ctor(Player , Player.ControllerHelper ) { }

	// RVA: 0x1AA04A0 Offset: 0x1A9F6A0 VA: 0x181AA04A0
	public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap) { }

	// RVA: 0x1AA00D0 Offset: 0x1A9F2D0 VA: 0x181AA00D0
	public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps) { }

	// RVA: 0x1AA04D0 Offset: 0x1A9F6D0 VA: 0x181AA04D0
	public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps, bool forceCheckAllCategories) { }

	// RVA: 0x1AA0470 Offset: 0x1A9F670 VA: 0x181AA0470
	public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap) { }

	// RVA: 0x1AA03F0 Offset: 0x1A9F5F0 VA: 0x181AA03F0
	public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps) { }

	// RVA: 0x1AA0770 Offset: 0x1A9F970 VA: 0x181AA0770
	public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories) { }

	// RVA: 0x1AA0420 Offset: 0x1A9F620 VA: 0x181AA0420
	public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck) { }

	// RVA: 0x1AA03A0 Offset: 0x1A9F5A0 VA: 0x181AA03A0
	public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) { }

	// RVA: 0x1AA0100 Offset: 0x1A9F300 VA: 0x181AA0100
	public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories) { }

	// RVA: 0x1AA1620 Offset: 0x1AA0820 VA: 0x181AA1620
	public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap) { }

	// RVA: 0x1AA0A90 Offset: 0x1A9FC90 VA: 0x181AA0A90
	public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps) { }

	// RVA: 0x1AA0AC0 Offset: 0x1A9FCC0 VA: 0x181AA0AC0
	public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps, bool forceCheckAllCategories) { }

	// RVA: 0x1AA11B0 Offset: 0x1AA03B0 VA: 0x181AA11B0
	public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap) { }

	// RVA: 0x1AA0A60 Offset: 0x1A9FC60 VA: 0x181AA0A60
	public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps) { }

	// RVA: 0x1AA0E30 Offset: 0x1AA0030 VA: 0x181AA0E30
	public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories) { }

	// RVA: 0x1AA1230 Offset: 0x1AA0430 VA: 0x181AA1230
	public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck) { }

	// RVA: 0x1AA11E0 Offset: 0x1AA03E0 VA: 0x181AA11E0
	public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) { }

	// RVA: 0x1AA1280 Offset: 0x1AA0480 VA: 0x181AA1280
	public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories) { }

	// RVA: 0x1AA1F90 Offset: 0x1AA1190 VA: 0x181AA1F90
	public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap) { }

	// RVA: 0x1AA28C0 Offset: 0x1AA1AC0 VA: 0x181AA28C0
	public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipRemovedMaps) { }

	// RVA: 0x1AA2380 Offset: 0x1AA1580 VA: 0x181AA2380
	public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipRemovedMaps, bool forceCheckAllCategories) { }

	// RVA: 0x1AA22B0 Offset: 0x1AA14B0 VA: 0x181AA22B0
	public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap) { }

	// RVA: 0x1AA28F0 Offset: 0x1AA1AF0 VA: 0x181AA28F0
	public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipRemovedMaps) { }

	// RVA: 0x1AA1FC0 Offset: 0x1AA11C0 VA: 0x181AA1FC0
	public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipRemovedMaps, bool forceCheckAllCategories) { }

	// RVA: 0x1AA22E0 Offset: 0x1AA14E0 VA: 0x181AA22E0
	public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck) { }

	// RVA: 0x1AA2330 Offset: 0x1AA1530 VA: 0x181AA2330
	public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipRemovedMaps) { }

	// RVA: 0x1AA2620 Offset: 0x1AA1820 VA: 0x181AA2620
	public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipRemovedMaps, bool forceCheckAllCategories) { }

	// RVA: 0x1A9FDA0 Offset: 0x1A9EFA0 VA: 0x181A9FDA0
	public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap) { }

	// RVA: 0x1A9FD70 Offset: 0x1A9EF70 VA: 0x181A9FD70
	public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps) { }

	// RVA: 0x1A9F770 Offset: 0x1A9E970 VA: 0x181A9F770
	public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps, bool forceCheckAllCategories) { }

	// RVA: 0x1A9FD40 Offset: 0x1A9EF40 VA: 0x181A9FD40
	public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap) { }

	// RVA: 0x1A9F740 Offset: 0x1A9E940 VA: 0x181A9F740
	public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps) { }

	// RVA: 0x1A9FDD0 Offset: 0x1A9EFD0 VA: 0x181A9FDD0
	public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories) { }

	// RVA: 0x1A9FA40 Offset: 0x1A9EC40 VA: 0x181A9FA40
	public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck) { }

	// RVA: 0x1A9F6F0 Offset: 0x1A9E8F0 VA: 0x181A9F6F0
	public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) { }

	// RVA: 0x1A9FA90 Offset: 0x1A9EC90 VA: 0x181A9FA90
	public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories) { }

	// RVA: 0x1AA3040 Offset: 0x1AA2240 VA: 0x181AA3040
	private bool UrXOJEETHNqXoLlGxfycwIgTdCw(int , JoystickMap , bool  = False, bool  = False) { }

	// RVA: 0x1AA2DD0 Offset: 0x1AA1FD0 VA: 0x181AA2DD0
	private bool UrXOJEETHNqXoLlGxfycwIgTdCw(int , JoystickMap , ActionElementMap , bool  = False, bool  = False) { }

	// RVA: 0x1AA2B50 Offset: 0x1AA1D50 VA: 0x181AA2B50
	private bool UrXOJEETHNqXoLlGxfycwIgTdCw(ElementAssignmentConflictCheck , bool  = False, bool  = False) { }

	// RVA: 0x1AA41C0 Offset: 0x1AA33C0 VA: 0x181AA41C0
	private bool bZVaEVMShgsekwOwtbhhHiwYbIQG(KeyboardMap , bool  = False, bool  = False) { }

	// RVA: 0x1AA4260 Offset: 0x1AA3460 VA: 0x181AA4260
	private bool bZVaEVMShgsekwOwtbhhHiwYbIQG(KeyboardMap , ActionElementMap , bool  = False, bool  = False) { }

	// RVA: 0x1AA4100 Offset: 0x1AA3300 VA: 0x181AA4100
	private bool bZVaEVMShgsekwOwtbhhHiwYbIQG(ElementAssignmentConflictCheck , bool  = False, bool  = False) { }

	// RVA: 0x1AA5B70 Offset: 0x1AA4D70 VA: 0x181AA5B70
	private bool nfiDbFNFHQAJOaFQvetSCPBaublR(MouseMap , bool  = False, bool  = False) { }

	// RVA: 0x1AA5AC0 Offset: 0x1AA4CC0 VA: 0x181AA5AC0
	private bool nfiDbFNFHQAJOaFQvetSCPBaublR(MouseMap , ActionElementMap , bool  = False, bool  = False) { }

	// RVA: 0x1AA5C10 Offset: 0x1AA4E10 VA: 0x181AA5C10
	private bool nfiDbFNFHQAJOaFQvetSCPBaublR(ElementAssignmentConflictCheck , bool  = False, bool  = False) { }

	// RVA: 0x1AA18D0 Offset: 0x1AA0AD0 VA: 0x181AA18D0
	private bool GJYtCPSLocSWqMUbYlhKSHFcJtrs(int , CustomControllerMap , bool  = False, bool  = False) { }

	// RVA: 0x1AA1B20 Offset: 0x1AA0D20 VA: 0x181AA1B20
	private bool GJYtCPSLocSWqMUbYlhKSHFcJtrs(int , CustomControllerMap , ActionElementMap , bool  = False, bool  = False) { }

	// RVA: 0x1AA1650 Offset: 0x1AA0850 VA: 0x181AA1650
	private bool GJYtCPSLocSWqMUbYlhKSHFcJtrs(ElementAssignmentConflictCheck , bool  = False, bool  = False) { }

	// RVA: 0x1AA2AA0 Offset: 0x1AA1CA0 VA: 0x181AA2AA0
	private IEnumerable<ElementAssignmentConflictInfo> TBDIhkiVdtnmJYInyqJrVSCCdxlz(int , JoystickMap , bool  = False, bool  = False) { }

	// RVA: 0x1AA29F0 Offset: 0x1AA1BF0 VA: 0x181AA29F0
	private IEnumerable<ElementAssignmentConflictInfo> TBDIhkiVdtnmJYInyqJrVSCCdxlz(int , JoystickMap , ActionElementMap , bool  = False, bool  = False) { }

	// RVA: 0x1AA2920 Offset: 0x1AA1B20 VA: 0x181AA2920
	private IEnumerable<ElementAssignmentConflictInfo> TBDIhkiVdtnmJYInyqJrVSCCdxlz(ElementAssignmentConflictCheck , bool  = False, bool  = False) { }

	// RVA: 0x1AA4540 Offset: 0x1AA3740 VA: 0x181AA4540
	private IEnumerable<ElementAssignmentConflictInfo> eCutAUMiENdaaINilOotOfTKqheTA(KeyboardMap , bool  = False, bool  = False) { }

	// RVA: 0x1AA45E0 Offset: 0x1AA37E0 VA: 0x181AA45E0
	private IEnumerable<ElementAssignmentConflictInfo> eCutAUMiENdaaINilOotOfTKqheTA(KeyboardMap , ActionElementMap , bool  = False, bool  = False) { }

	// RVA: 0x1AA4680 Offset: 0x1AA3880 VA: 0x181AA4680
	private IEnumerable<ElementAssignmentConflictInfo> eCutAUMiENdaaINilOotOfTKqheTA(ElementAssignmentConflictCheck , bool  = False, bool  = False) { }

	// RVA: 0x1AA3390 Offset: 0x1AA2590 VA: 0x181AA3390
	private IEnumerable<ElementAssignmentConflictInfo> VUdWRnhPUnyAgQoirPGCeBEJAeod(MouseMap , bool  = False, bool  = False) { }

	// RVA: 0x1AA3430 Offset: 0x1AA2630 VA: 0x181AA3430
	private IEnumerable<ElementAssignmentConflictInfo> VUdWRnhPUnyAgQoirPGCeBEJAeod(MouseMap , ActionElementMap , bool  = False, bool  = False) { }

	// RVA: 0x1AA3290 Offset: 0x1AA2490 VA: 0x181AA3290
	private IEnumerable<ElementAssignmentConflictInfo> VUdWRnhPUnyAgQoirPGCeBEJAeod(ElementAssignmentConflictCheck , bool  = False, bool  = False) { }

	// RVA: 0x1AA5080 Offset: 0x1AA4280 VA: 0x181AA5080
	private IEnumerable<ElementAssignmentConflictInfo> kOUrLOPeUIRfsuHipaXJLthdNOQB(int , CustomControllerMap , bool  = False, bool  = False) { }

	// RVA: 0x1AA4F00 Offset: 0x1AA4100 VA: 0x181AA4F00
	private IEnumerable<ElementAssignmentConflictInfo> kOUrLOPeUIRfsuHipaXJLthdNOQB(int , CustomControllerMap , ActionElementMap , bool  = False, bool  = False) { }

	// RVA: 0x1AA4FB0 Offset: 0x1AA41B0 VA: 0x181AA4FB0
	private IEnumerable<ElementAssignmentConflictInfo> kOUrLOPeUIRfsuHipaXJLthdNOQB(ElementAssignmentConflictCheck , bool  = False, bool  = False) { }

	// RVA: 0x1AA4CA0 Offset: 0x1AA3EA0 VA: 0x181AA4CA0
	private int kDJNyHMliiqglSkJYIWerxAwyQGP(int , JoystickMap , bool  = False, bool  = False) { }

	// RVA: 0x1AA4A20 Offset: 0x1AA3C20 VA: 0x181AA4A20
	private int kDJNyHMliiqglSkJYIWerxAwyQGP(int , JoystickMap , ActionElementMap , bool  = False, bool  = False) { }

	// RVA: 0x1AA4780 Offset: 0x1AA3980 VA: 0x181AA4780
	private int kDJNyHMliiqglSkJYIWerxAwyQGP(ElementAssignmentConflictCheck , bool  = False, bool  = False) { }

	// RVA: 0x1AA1EF0 Offset: 0x1AA10F0 VA: 0x181AA1EF0
	private int NjWnpkFIcOOLTljcSUrajnjrzTcy(KeyboardMap , bool  = False, bool  = False) { }

	// RVA: 0x1AA1E50 Offset: 0x1AA1050 VA: 0x181AA1E50
	private int NjWnpkFIcOOLTljcSUrajnjrzTcy(KeyboardMap , ActionElementMap , bool  = False, bool  = False) { }

	// RVA: 0x1AA1D90 Offset: 0x1AA0F90 VA: 0x181AA1D90
	private int NjWnpkFIcOOLTljcSUrajnjrzTcy(ElementAssignmentConflictCheck , bool  = False, bool  = False) { }

	// RVA: 0x1AA5970 Offset: 0x1AA4B70 VA: 0x181AA5970
	private int liwQFBsSdyfnJDjuKLsLqRAQARMBb(MouseMap , bool  = False, bool  = False) { }

	// RVA: 0x1AA5A10 Offset: 0x1AA4C10 VA: 0x181AA5A10
	private int liwQFBsSdyfnJDjuKLsLqRAQARMBb(MouseMap , ActionElementMap , bool  = False, bool  = False) { }

	// RVA: 0x1AA58B0 Offset: 0x1AA4AB0 VA: 0x181AA58B0
	private int liwQFBsSdyfnJDjuKLsLqRAQARMBb(ElementAssignmentConflictCheck , bool  = False, bool  = False) { }

	// RVA: 0x1AA53B0 Offset: 0x1AA45B0 VA: 0x181AA53B0
	private int lSBDoEKHRrmdtgRTZFwVVuKAkrstA(int , CustomControllerMap , bool  = False, bool  = False) { }

	// RVA: 0x1AA5130 Offset: 0x1AA4330 VA: 0x181AA5130
	private int lSBDoEKHRrmdtgRTZFwVVuKAkrstA(int , CustomControllerMap , ActionElementMap , bool  = False, bool  = False) { }

	// RVA: 0x1AA5610 Offset: 0x1AA4810 VA: 0x181AA5610
	private int lSBDoEKHRrmdtgRTZFwVVuKAkrstA(ElementAssignmentConflictCheck , bool  = False, bool  = False) { }

	// RVA: 0x1AA3870 Offset: 0x1AA2A70 VA: 0x181AA3870
	private int YXOejINqKjGSXAstmNfZWclCGwSo(int , JoystickMap , bool  = False, bool  = False, List<ActionElementMap> ) { }

	// RVA: 0x1AA3DB0 Offset: 0x1AA2FB0 VA: 0x181AA3DB0
	private int YXOejINqKjGSXAstmNfZWclCGwSo(int , JoystickMap , ActionElementMap , bool  = False, bool  = False, List<ActionElementMap> ) { }

	// RVA: 0x1AA3AF0 Offset: 0x1AA2CF0 VA: 0x181AA3AF0
	private int YXOejINqKjGSXAstmNfZWclCGwSo(ElementAssignmentConflictCheck , bool  = False, bool  = False, List<ActionElementMap> ) { }

	// RVA: 0x1AA37C0 Offset: 0x1AA29C0 VA: 0x181AA37C0
	private int VjCBvdamvUPgeLgbYBLfzDTOMzzBA(KeyboardMap , bool  = False, bool  = False, List<ActionElementMap> ) { }

	// RVA: 0x1AA3630 Offset: 0x1AA2830 VA: 0x181AA3630
	private int VjCBvdamvUPgeLgbYBLfzDTOMzzBA(KeyboardMap , ActionElementMap , bool  = False, bool  = False, List<ActionElementMap> ) { }

	// RVA: 0x1AA36E0 Offset: 0x1AA28E0 VA: 0x181AA36E0
	private int VjCBvdamvUPgeLgbYBLfzDTOMzzBA(ElementAssignmentConflictCheck , bool  = False, bool  = False, List<ActionElementMap> ) { }

	// RVA: 0x1AA4300 Offset: 0x1AA3500 VA: 0x181AA4300
	private int cLSFiHNcXDASdYkkDHlXVkfhrZMm(MouseMap , bool  = False, bool  = False, List<ActionElementMap> ) { }

	// RVA: 0x1AA4490 Offset: 0x1AA3690 VA: 0x181AA4490
	private int cLSFiHNcXDASdYkkDHlXVkfhrZMm(MouseMap , ActionElementMap , bool  = False, bool  = False, List<ActionElementMap> ) { }

	// RVA: 0x1AA43B0 Offset: 0x1AA35B0 VA: 0x181AA43B0
	private int cLSFiHNcXDASdYkkDHlXVkfhrZMm(ElementAssignmentConflictCheck , bool  = False, bool  = False, List<ActionElementMap> ) { }

	// RVA: 0x1AA5CD0 Offset: 0x1AA4ED0 VA: 0x181AA5CD0
	private int vSafuYqHhQENsUoibFOethBaafvZ(int , CustomControllerMap , bool  = False, bool  = False, List<ActionElementMap> ) { }

	// RVA: 0x1AA5F50 Offset: 0x1AA5150 VA: 0x181AA5F50
	private int vSafuYqHhQENsUoibFOethBaafvZ(int , CustomControllerMap , ActionElementMap , bool  = False, bool  = False, List<ActionElementMap> ) { }

	// RVA: 0x1AA61E0 Offset: 0x1AA53E0 VA: 0x181AA61E0
	private int vSafuYqHhQENsUoibFOethBaafvZ(ElementAssignmentConflictCheck , bool  = False, bool  = False, List<ActionElementMap> ) { }

	// RVA: -1 Offset: -1
	private bool mtxhwqOIkGoeAEPQWuCzTlKHRnsj<>(ControllerType , int ,  , bool , bool , VOLZYtSxBAfSvCRXgiPmhhdoQwVG<> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC96C0 Offset: 0xAC88C0 VA: 0x180AC96C0
	|-Player.ControllerHelper.ConflictCheckingHelper.mtxhwqOIkGoeAEPQWuCzTlKHRnsj<object>
	*/

	// RVA: -1 Offset: -1
	private bool mtxhwqOIkGoeAEPQWuCzTlKHRnsj<>(ControllerType , int ,  , ActionElementMap , bool , bool , VOLZYtSxBAfSvCRXgiPmhhdoQwVG<> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC92E0 Offset: 0xAC84E0 VA: 0x180AC92E0
	|-Player.ControllerHelper.ConflictCheckingHelper.mtxhwqOIkGoeAEPQWuCzTlKHRnsj<object>
	*/

	// RVA: -1 Offset: -1
	private bool mtxhwqOIkGoeAEPQWuCzTlKHRnsj<>(ElementAssignmentConflictCheck , bool , bool , VOLZYtSxBAfSvCRXgiPmhhdoQwVG<> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC9470 Offset: 0xAC8670 VA: 0x180AC9470
	|-Player.ControllerHelper.ConflictCheckingHelper.mtxhwqOIkGoeAEPQWuCzTlKHRnsj<object>
	*/

	// RVA: -1 Offset: -1
	private IEnumerable<ElementAssignmentConflictInfo> QvtjLoIhHnJaxkFBGefWDqIVnOWMA<>(ControllerType , int ,  , bool , bool , VOLZYtSxBAfSvCRXgiPmhhdoQwVG<> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC9210 Offset: 0xAC8410 VA: 0x180AC9210
	|-Player.ControllerHelper.ConflictCheckingHelper.QvtjLoIhHnJaxkFBGefWDqIVnOWMA<object>
	*/

	// RVA: -1 Offset: -1
	private IEnumerable<ElementAssignmentConflictInfo> QvtjLoIhHnJaxkFBGefWDqIVnOWMA<>(ControllerType , int ,  , ActionElementMap , bool , bool , VOLZYtSxBAfSvCRXgiPmhhdoQwVG<> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC9040 Offset: 0xAC8240 VA: 0x180AC9040
	|-Player.ControllerHelper.ConflictCheckingHelper.QvtjLoIhHnJaxkFBGefWDqIVnOWMA<object>
	*/

	// RVA: -1 Offset: -1
	private IEnumerable<ElementAssignmentConflictInfo> QvtjLoIhHnJaxkFBGefWDqIVnOWMA<>(ElementAssignmentConflictCheck , bool , bool , VOLZYtSxBAfSvCRXgiPmhhdoQwVG<> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC9120 Offset: 0xAC8320 VA: 0x180AC9120
	|-Player.ControllerHelper.ConflictCheckingHelper.QvtjLoIhHnJaxkFBGefWDqIVnOWMA<object>
	*/

	// RVA: -1 Offset: -1
	private int HMdcgAXBYTWBihznqTWdOncnoiad<>(ControllerType , int ,  , bool , bool , VOLZYtSxBAfSvCRXgiPmhhdoQwVG<> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC8420 Offset: 0xAC7620 VA: 0x180AC8420
	|-Player.ControllerHelper.ConflictCheckingHelper.HMdcgAXBYTWBihznqTWdOncnoiad<object>
	*/

	// RVA: -1 Offset: -1
	private int HMdcgAXBYTWBihznqTWdOncnoiad<>(ControllerType , int ,  , ActionElementMap , bool , bool , VOLZYtSxBAfSvCRXgiPmhhdoQwVG<> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC8830 Offset: 0xAC7A30 VA: 0x180AC8830
	|-Player.ControllerHelper.ConflictCheckingHelper.HMdcgAXBYTWBihznqTWdOncnoiad<object>
	*/

	// RVA: -1 Offset: -1
	private int HMdcgAXBYTWBihznqTWdOncnoiad<>(ElementAssignmentConflictCheck , bool , bool , VOLZYtSxBAfSvCRXgiPmhhdoQwVG<> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC85D0 Offset: 0xAC77D0 VA: 0x180AC85D0
	|-Player.ControllerHelper.ConflictCheckingHelper.HMdcgAXBYTWBihznqTWdOncnoiad<object>
	*/

	// RVA: -1 Offset: -1
	private int NTMMlzeFiamrGmXxjaSzBFWfhqWA<>(ControllerType , int ,  , bool , bool , VOLZYtSxBAfSvCRXgiPmhhdoQwVG<> , List<ActionElementMap> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC8C90 Offset: 0xAC7E90 VA: 0x180AC8C90
	|-Player.ControllerHelper.ConflictCheckingHelper.NTMMlzeFiamrGmXxjaSzBFWfhqWA<object>
	*/

	// RVA: -1 Offset: -1
	private int NTMMlzeFiamrGmXxjaSzBFWfhqWA<>(ControllerType , int ,  , ActionElementMap , bool , bool , VOLZYtSxBAfSvCRXgiPmhhdoQwVG<> , List<ActionElementMap> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC8E60 Offset: 0xAC8060 VA: 0x180AC8E60
	|-Player.ControllerHelper.ConflictCheckingHelper.NTMMlzeFiamrGmXxjaSzBFWfhqWA<object>
	*/

	// RVA: -1 Offset: -1
	private int NTMMlzeFiamrGmXxjaSzBFWfhqWA<>(ElementAssignmentConflictCheck , bool , bool , VOLZYtSxBAfSvCRXgiPmhhdoQwVG<> , List<ActionElementMap> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC89D0 Offset: 0xAC7BD0 VA: 0x180AC89D0
	|-Player.ControllerHelper.ConflictCheckingHelper.NTMMlzeFiamrGmXxjaSzBFWfhqWA<object>
	*/

	// RVA: 0x1AA34E0 Offset: 0x1AA26E0 VA: 0x181AA34E0
	private bool VWkaCZGFMfuwfPXGbcVJlKQiPhNQA(InputMapCategory , ControllerMap ) { }
}

// Namespace: 
[DefaultMember("Item")]
internal interface Player.ControllerHelper.vUluXsRssqqTHGOorDrBIndPAadW // TypeDefIndex: 7049
{
	// Properties
	public abstract Player.ControllerHelper.cMDSGeuiHKqhDsNnVgoHjeDkrNgAA VcNaKpZiSjfBNHLSrIsuQryjanXbb { get; }
	public abstract ControllerType XkDVpydTdKFGyaepLgJpPXsuRQFt { get; }
	public abstract int ZGDajhyxNzhNBiKJhEAsWFQbqjCfA { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Player.ControllerHelper.cMDSGeuiHKqhDsNnVgoHjeDkrNgAA DqTTDBNrLYGAlGMLwfxhSdzmqObD(int );

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ControllerType isiIbAlrdhoawXdijybVEIqgBqAP();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int JkWSBcRXMqksDMwnqGuHKOiabncT();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool HfHQDEyJodmDgQKMBJDYDJavMFDLA(Controller );

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool HfHQDEyJodmDgQKMBJDYDJavMFDLA(int );

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void AzmkMLIGKerFEsmBmsEJMbJzSHYF(int );

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void AzmkMLIGKerFEsmBmsEJMbJzSHYF(Controller );

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void tDDIpMeXuwpLHMMumdWRnDHkCWqw(int );

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Controller ioyGgqcxMFpOcLbWFadlkZYwDWKq(int );

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Controller AeRmcwiKtmvRaSDCMhewCdwdDlTG(string );

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int ZVMYpYkqYXFpfBIVblsDvJTirAucA(Controller );

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int ZVMYpYkqYXFpfBIVblsDvJTirAucA(int );

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int TyzPSvCuCOViNcHeqiuZfZbkvxix(string );

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void emOgGAIJPwqUQQPmEukEIzmDcQhcb();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract Player.ControllerHelper.cMDSGeuiHKqhDsNnVgoHjeDkrNgAA nnnVPpmogfVByYORMDyiIOVkfttO(int );

	// RVA: -1 Offset: -1 Slot: 15
	public abstract Player.ControllerHelper.cMDSGeuiHKqhDsNnVgoHjeDkrNgAA nnnVPpmogfVByYORMDyiIOVkfttO(Controller );

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void hVxDBCoQoyJLTpSEvUMbjcOnikrAA(Player.ControllerHelper.cMDSGeuiHKqhDsNnVgoHjeDkrNgAA );
}

// Namespace: 
internal interface Player.ControllerHelper.cMDSGeuiHKqhDsNnVgoHjeDkrNgAA // TypeDefIndex: 7050
{
	// Properties
	public abstract dyCkQiVTJnvQvTqPOHWiKoiJbMucA kXYeSKdEmYSdignKlXEIKozmUFXy { get; }
	public abstract Controller oucSTTgcWofhafDPqHrFgmhNLXuaA { get; }
	public abstract double FxRjHGhuUoALJHdkqfKBtpzrbCbjA { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract dyCkQiVTJnvQvTqPOHWiKoiJbMucA JBhoLgLbOEbrRABefPBnUeusCmLu();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Controller yxEyCIpUtBgiGHlVBoscpSEAZOOk();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract double VFYJTixbqIicrLROxGTbumITehzf();
}

// Namespace: 
public class Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW.CCtQmfiCiLYXpyDnPHTEbFqWCFaHA<, > : Player.ControllerHelper.cMDSGeuiHKqhDsNnVgoHjeDkrNgAA // TypeDefIndex: 7051
{
	// Fields
	public  oucSTTgcWofhafDPqHrFgmhNLXuaA; // 0x0
	public VOLZYtSxBAfSvCRXgiPmhhdoQwVG<> kXYeSKdEmYSdignKlXEIKozmUFXy; // 0x0
	public double FxRjHGhuUoALJHdkqfKBtpzrbCbjA; // 0x0

	// Properties
	private Controller KPaDRzOrSYGsyUWbBGXJnFlSYIiJ { get; }
	private dyCkQiVTJnvQvTqPOHWiKoiJbMucA pXCHVXpSgikaxGdvTCFnqoxcjGFm { get; }
	private double XHvpQumLoGsRydxyrZEcfNeOZDmc { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	private Controller xkCdRIGHsephadXPaGLYCULBWakyA() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW.CCtQmfiCiLYXpyDnPHTEbFqWCFaHA<object, object>.xkCdRIGHsephadXPaGLYCULBWakyA
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private dyCkQiVTJnvQvTqPOHWiKoiJbMucA HUaFEvcbznNETEYUCOwuVOtpFmwkB() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW.CCtQmfiCiLYXpyDnPHTEbFqWCFaHA<object, object>.HUaFEvcbznNETEYUCOwuVOtpFmwkB
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private double jJvBhXKqipAIkivEtxVmUNXSQZvKA() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x52F520 Offset: 0x52E720 VA: 0x18052F520
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW.CCtQmfiCiLYXpyDnPHTEbFqWCFaHA<object, object>.jJvBhXKqipAIkivEtxVmUNXSQZvKA
	*/

	// RVA: -1 Offset: -1
	public void .ctor( , VOLZYtSxBAfSvCRXgiPmhhdoQwVG<> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW.CCtQmfiCiLYXpyDnPHTEbFqWCFaHA<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void SYbWtLAsgGyXQDhKFCaYlNJccEjB() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEF7E40 Offset: 0xEF7040 VA: 0x180EF7E40
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW.CCtQmfiCiLYXpyDnPHTEbFqWCFaHA<object, object>.SYbWtLAsgGyXQDhKFCaYlNJccEjB
	*/
}

// Namespace: 
[DefaultMember("Item")]
internal sealed class Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<, > : Player.ControllerHelper.vUluXsRssqqTHGOorDrBIndPAadW // TypeDefIndex: 7052
{
	// Fields
	private List<Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW.CCtQmfiCiLYXpyDnPHTEbFqWCFaHA<, >> YMDWxmViwDoKkxAzGzCOVCAFbaCT; // 0x0
	private List<> nLrOHQdCvCElrQspthfUKklTTwvT; // 0x0
	private ReadOnlyCollection<> UDqGuNezFUfYgdLubMcLECULPFSq; // 0x0
	private readonly ControllerType mssadAAejyKGHIfognJBtXtNdiiIB; // 0x0

	// Properties
	public int ZGDajhyxNzhNBiKJhEAsWFQbqjCfA { get; }
	public IList<> wzlxJrPuQqMvjNstmqJUrcxbffxFA { get; }
	public Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW.CCtQmfiCiLYXpyDnPHTEbFqWCFaHA<, > VcNaKpZiSjfBNHLSrIsuQryjanXbb { get; }
	public ControllerType XkDVpydTdKFGyaepLgJpPXsuRQFt { get; }
	private Player.ControllerHelper.cMDSGeuiHKqhDsNnVgoHjeDkrNgAA YYYILFHcdJdLNobLdeQTrClVlfmf { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public int JkWSBcRXMqksDMwnqGuHKOiabncT() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB77F20 Offset: 0xB77120 VA: 0x180B77F20
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>.JkWSBcRXMqksDMwnqGuHKOiabncT
	*/

	// RVA: -1 Offset: -1
	public IList<> uNWnPcadyYoxxwhUXBLPrkOHbfqo() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>.uNWnPcadyYoxxwhUXBLPrkOHbfqo
	*/

	// RVA: -1 Offset: -1
	public Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW.CCtQmfiCiLYXpyDnPHTEbFqWCFaHA<, > DqTTDBNrLYGAlGMLwfxhSdzmqObD(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE752C0 Offset: 0xE744C0 VA: 0x180E752C0
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>.DqTTDBNrLYGAlGMLwfxhSdzmqObD
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public ControllerType isiIbAlrdhoawXdijybVEIqgBqAP() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>.isiIbAlrdhoawXdijybVEIqgBqAP
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE758B0 Offset: 0xE74AB0 VA: 0x180E758B0
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW.CCtQmfiCiLYXpyDnPHTEbFqWCFaHA<, > nnnVPpmogfVByYORMDyiIOVkfttO(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE76000 Offset: 0xE75200 VA: 0x180E76000
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>.nnnVPpmogfVByYORMDyiIOVkfttO
	*/

	// RVA: -1 Offset: -1
	public Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW.CCtQmfiCiLYXpyDnPHTEbFqWCFaHA<, > nnnVPpmogfVByYORMDyiIOVkfttO( ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE75FD0 Offset: 0xE751D0 VA: 0x180E75FD0
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>.nnnVPpmogfVByYORMDyiIOVkfttO
	*/

	// RVA: -1 Offset: -1
	public void hVxDBCoQoyJLTpSEvUMbjcOnikrAA(Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW.CCtQmfiCiLYXpyDnPHTEbFqWCFaHA<, > ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE75B40 Offset: 0xE74D40 VA: 0x180E75B40
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>.hVxDBCoQoyJLTpSEvUMbjcOnikrAA
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void AzmkMLIGKerFEsmBmsEJMbJzSHYF(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE74EF0 Offset: 0xE740F0 VA: 0x180E74EF0
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>.AzmkMLIGKerFEsmBmsEJMbJzSHYF
	*/

	// RVA: -1 Offset: -1
	public void AzmkMLIGKerFEsmBmsEJMbJzSHYF( ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE74FC0 Offset: 0xE741C0 VA: 0x180E74FC0
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>.AzmkMLIGKerFEsmBmsEJMbJzSHYF
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void tDDIpMeXuwpLHMMumdWRnDHkCWqw(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE76080 Offset: 0xE75280 VA: 0x180E76080
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>.tDDIpMeXuwpLHMMumdWRnDHkCWqw
	*/

	// RVA: -1 Offset: -1
	public  ioyGgqcxMFpOcLbWFadlkZYwDWKq(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE75C60 Offset: 0xE74E60 VA: 0x180E75C60
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>.ioyGgqcxMFpOcLbWFadlkZYwDWKq
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool HfHQDEyJodmDgQKMBJDYDJavMFDLA(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE753E0 Offset: 0xE745E0 VA: 0x180E753E0
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>.HfHQDEyJodmDgQKMBJDYDJavMFDLA
	*/

	// RVA: -1 Offset: -1
	public bool HfHQDEyJodmDgQKMBJDYDJavMFDLA( ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE752F0 Offset: 0xE744F0 VA: 0x180E752F0
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>.HfHQDEyJodmDgQKMBJDYDJavMFDLA
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public int ZVMYpYkqYXFpfBIVblsDvJTirAucA(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE75790 Offset: 0xE74990 VA: 0x180E75790
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>.ZVMYpYkqYXFpfBIVblsDvJTirAucA
	*/

	// RVA: -1 Offset: -1
	public int ZVMYpYkqYXFpfBIVblsDvJTirAucA( ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE75840 Offset: 0xE74A40 VA: 0x180E75840
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>.ZVMYpYkqYXFpfBIVblsDvJTirAucA
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public int TyzPSvCuCOViNcHeqiuZfZbkvxix(string ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE75690 Offset: 0xE74890 VA: 0x180E75690
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>.TyzPSvCuCOViNcHeqiuZfZbkvxix
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB90FB0 Offset: 0xB901B0 VA: 0x180B90FB0
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>.emOgGAIJPwqUQQPmEukEIzmDcQhcb
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private Player.ControllerHelper.cMDSGeuiHKqhDsNnVgoHjeDkrNgAA zuplerWoHiCvsibeDdsRpIKsJuof(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE752C0 Offset: 0xE744C0 VA: 0x180E752C0
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>.zuplerWoHiCvsibeDdsRpIKsJuof
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private Player.ControllerHelper.cMDSGeuiHKqhDsNnVgoHjeDkrNgAA nXTYpMclgNMYkLmfkhJBYAOUIQVF(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE75E60 Offset: 0xE75060 VA: 0x180E75E60
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>.nXTYpMclgNMYkLmfkhJBYAOUIQVF
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private Player.ControllerHelper.cMDSGeuiHKqhDsNnVgoHjeDkrNgAA nXTYpMclgNMYkLmfkhJBYAOUIQVF(Controller ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE75E80 Offset: 0xE75080 VA: 0x180E75E80
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>.nXTYpMclgNMYkLmfkhJBYAOUIQVF
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private void lNLWvCuXwonqTClhbtNHIKdZSkZT(Player.ControllerHelper.cMDSGeuiHKqhDsNnVgoHjeDkrNgAA ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE75CE0 Offset: 0xE74EE0 VA: 0x180E75CE0
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>.lNLWvCuXwonqTClhbtNHIKdZSkZT
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void AjqcCbqclktLjEgSpIQnkUBXDuzB(Controller ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE74E20 Offset: 0xE74020 VA: 0x180E74E20
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>.AjqcCbqclktLjEgSpIQnkUBXDuzB
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private Controller LRmmXlgYGhTLegeJiiodiGDgCsOtA(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE75490 Offset: 0xE74690 VA: 0x180E75490
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>.LRmmXlgYGhTLegeJiiodiGDgCsOtA
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private bool tPlvpFJefUxEVxBMMzePSVtleJOB(Controller ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE76100 Offset: 0xE75300 VA: 0x180E76100
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>.tPlvpFJefUxEVxBMMzePSVtleJOB
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private int TUWaohDyvexexqMxFIObsgimgKri(Controller ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE755A0 Offset: 0xE747A0 VA: 0x180E755A0
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>.TUWaohDyvexexqMxFIObsgimgKri
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private Controller CGQxCZrWumrOXGEzPjIanmYgBXSc(string ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE75160 Offset: 0xE74360 VA: 0x180E75160
	|-Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<object, object>.CGQxCZrWumrOXGEzPjIanmYgBXSc
	*/
}

// Namespace: 
internal class Player.ControllerHelper.rNojQFABiPcQnhzbrdHPHPvawbTQA // TypeDefIndex: 7053
{
	// Fields
	public readonly int ZGDajhyxNzhNBiKJhEAsWFQbqjCfA; // 0x10
	private ControllerType[] xCmbnQdUUHFoJMHxGmdgfQRflxoFb; // 0x18
	private Player.ControllerHelper.vUluXsRssqqTHGOorDrBIndPAadW[] YJdDrSjThgOuyPIMwnnAJqqxAOOn; // 0x20

	// Methods

	// RVA: 0x1AD73D0 Offset: 0x1AD65D0 VA: 0x181AD73D0
	public Player.ControllerHelper.vUluXsRssqqTHGOorDrBIndPAadW GJiLnYThIuyWVQdHsqJarMxrPOdc(int ) { }

	// RVA: 0x1AD7480 Offset: 0x1AD6680 VA: 0x181AD7480
	public ControllerType wBdBzJBAPDIQHmgwmfgAgXOFoulJc(int ) { }

	// RVA: 0x1AD7400 Offset: 0x1AD6600 VA: 0x181AD7400
	public void .ctor(int ) { }

	// RVA: 0x1AD7310 Offset: 0x1AD6510 VA: 0x181AD7310
	public Player.ControllerHelper.vUluXsRssqqTHGOorDrBIndPAadW EmUERUcBDXmDwzSFxqWnletfAQyj(ControllerType ) { }

	// RVA: 0x1AD74B0 Offset: 0x1AD66B0 VA: 0x181AD74B0
	public void zyhFWfGRRfTWDceeeGcVtXAzCRyfb(int , ControllerType , Player.ControllerHelper.vUluXsRssqqTHGOorDrBIndPAadW ) { }
}

// Namespace: 
public class Player.ControllerHelper.sRTBJiyOzrLJeZMfMScvYoeENrpm.zMxLgZVIrQrOBtLcrbYoAupEgXYyA // TypeDefIndex: 7054
{
	// Fields
	public int JTVbKkaOfUHTYeezJJVreQldtfSZ; // 0x10
	public VOLZYtSxBAfSvCRXgiPmhhdoQwVG<JoystickMap> kXYeSKdEmYSdignKlXEIKozmUFXy; // 0x18
	public double gtiuLgvSswIJsvboVIASekxcUEgm; // 0x20

	// Methods

	// RVA: 0x1AD8820 Offset: 0x1AD7A20 VA: 0x181AD8820
	public void .ctor(int , VOLZYtSxBAfSvCRXgiPmhhdoQwVG<JoystickMap> , double ) { }
}

// Namespace: 
private class Player.ControllerHelper.sRTBJiyOzrLJeZMfMScvYoeENrpm // TypeDefIndex: 7055
{
	// Fields
	private readonly List<Player.ControllerHelper.sRTBJiyOzrLJeZMfMScvYoeENrpm.zMxLgZVIrQrOBtLcrbYoAupEgXYyA> SoaTxmiZVylilBUxGputtEzixo; // 0x10
	private readonly Player dKxeWVrXJNsFqEAYKfLlJKDBwaWd; // 0x18

	// Methods

	// RVA: 0x1AD7780 Offset: 0x1AD6980 VA: 0x181AD7780
	public void .ctor(Player ) { }

	// RVA: 0x1AD7920 Offset: 0x1AD6B20 VA: 0x181AD7920
	public void cHMfpVZrsbPeVMuIhniVwFDglNIV(Joystick , VOLZYtSxBAfSvCRXgiPmhhdoQwVG<JoystickMap> ) { }

	// RVA: 0x1AD78F0 Offset: 0x1AD6AF0 VA: 0x181AD78F0
	public void cHMfpVZrsbPeVMuIhniVwFDglNIV(Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW.CCtQmfiCiLYXpyDnPHTEbFqWCFaHA<Joystick, JoystickMap> ) { }

	// RVA: 0x1AD7800 Offset: 0x1AD6A00 VA: 0x181AD7800
	public void aagcNpUBXiRBEhpMSlGxHPAVyTqk() { }

	// RVA: 0x1AD75E0 Offset: 0x1AD67E0 VA: 0x181AD75E0
	public Player.ControllerHelper.sRTBJiyOzrLJeZMfMScvYoeENrpm.zMxLgZVIrQrOBtLcrbYoAupEgXYyA XxrjtmqYYroNpYiDHyhVrdbsxdth(int ) { }

	// RVA: 0x1AD7530 Offset: 0x1AD6730 VA: 0x181AD7530
	public bool HfHQDEyJodmDgQKMBJDYDJavMFDLA(int ) { }

	// RVA: 0x1AD76C0 Offset: 0x1AD68C0 VA: 0x181AD76C0
	public int ZVMYpYkqYXFpfBIVblsDvJTirAucA(int ) { }

	// RVA: 0x1AD7B00 Offset: 0x1AD6D00 VA: 0x181AD7B00
	public void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.MapHelper.TyoJlNClvUVTmTkSySOEqnSGUOku : IDisposable, IEnumerable, IEnumerable<ActionElementMap>, IEnumerator, IEnumerator<ActionElementMap> // TypeDefIndex: 7056
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ActionElementMap lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public Player.ControllerHelper.MapHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int RMJEoXtoZMtwULyaBvSFzYLhgaKj; // 0x30
	public int NGoDsrkiKABiOBzXCjjnCIXciAdse; // 0x34
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x38
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x39
	private int CzKfPhaRWuffJnyiWVpldLjlOYS; // 0x3C
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x40
	private Player.ControllerHelper.vUluXsRssqqTHGOorDrBIndPAadW kFEbonnqCsxSeJrbESEAeexpTKfi; // 0x48
	private int QjtuECTijUAVBdtxEzDlbboNeDKeb; // 0x50
	private int pyQLGGZqNaQgIvoPCvziKBwnbtLq; // 0x54
	private dyCkQiVTJnvQvTqPOHWiKoiJbMucA AWvtlPYXlqSqZidTFGNsJieSLjoe; // 0x58
	private int weDChHfUtXXDOcUrtJFNCmxPIQdDb; // 0x60
	private int iTWPygEySPRMovcxQzJaFNjoAgTeA; // 0x64
	private IEnumerator<ActionElementMap> teAwSmgXqJODRFvQorNEhmGRFLUH; // 0x68

	// Properties
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1AD5860 Offset: 0x1AD4A60 VA: 0x181AD5860 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AD5280 Offset: 0x1AD4480 VA: 0x181AD5280 Slot: 7
	private bool MoveNext() { }

	// RVA: 0x1AD58F0 Offset: 0x1AD4AF0 VA: 0x181AD58F0
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AD5820 Offset: 0x1AD4A20 VA: 0x181AD5820 Slot: 9
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AD5760 Offset: 0x1AD4960 VA: 0x181AD5760 Slot: 6
	private IEnumerator<ActionElementMap> System.Collections.Generic.IEnumerable<Rewired.ActionElementMap>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AD5760 Offset: 0x1AD4960 VA: 0x181AD5760 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.MapHelper.MJYUvPzhXCzamDhpeGgJAtFOIgAHA : IDisposable, IEnumerable, IEnumerable<ActionElementMap>, IEnumerator, IEnumerator<ActionElementMap> // TypeDefIndex: 7057
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ActionElementMap lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public Player.ControllerHelper.MapHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int RMJEoXtoZMtwULyaBvSFzYLhgaKj; // 0x30
	public int NGoDsrkiKABiOBzXCjjnCIXciAdse; // 0x34
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x38
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x39
	private int CzKfPhaRWuffJnyiWVpldLjlOYS; // 0x3C
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x40
	private Player.ControllerHelper.vUluXsRssqqTHGOorDrBIndPAadW kFEbonnqCsxSeJrbESEAeexpTKfi; // 0x48
	private int QjtuECTijUAVBdtxEzDlbboNeDKeb; // 0x50
	private int pyQLGGZqNaQgIvoPCvziKBwnbtLq; // 0x54
	private dyCkQiVTJnvQvTqPOHWiKoiJbMucA AWvtlPYXlqSqZidTFGNsJieSLjoe; // 0x58
	private int weDChHfUtXXDOcUrtJFNCmxPIQdDb; // 0x60
	private int iTWPygEySPRMovcxQzJaFNjoAgTeA; // 0x64
	private IEnumerator<ActionElementMap> teAwSmgXqJODRFvQorNEhmGRFLUH; // 0x68

	// Properties
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1ABDAE0 Offset: 0x1ABCCE0 VA: 0x181ABDAE0 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1ABD540 Offset: 0x1ABC740 VA: 0x181ABD540 Slot: 7
	private bool MoveNext() { }

	// RVA: 0x1ABDB70 Offset: 0x1ABCD70 VA: 0x181ABDB70
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1ABDAA0 Offset: 0x1ABCCA0 VA: 0x181ABDAA0 Slot: 9
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1ABD9E0 Offset: 0x1ABCBE0 VA: 0x181ABD9E0 Slot: 6
	private IEnumerator<ActionElementMap> System.Collections.Generic.IEnumerable<Rewired.ActionElementMap>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1ABD9E0 Offset: 0x1ABCBE0 VA: 0x181ABD9E0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.MapHelper.VaVhxYVNJcboBYAGhmRgNhomczzgA : IDisposable, IEnumerable, IEnumerable<ActionElementMap>, IEnumerator, IEnumerator<ActionElementMap> // TypeDefIndex: 7058
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ActionElementMap lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	private int RMJEoXtoZMtwULyaBvSFzYLhgaKj; // 0x24
	public int NGoDsrkiKABiOBzXCjjnCIXciAdse; // 0x28
	public Player.ControllerHelper.MapHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x30
	private ControllerType XkDVpydTdKFGyaepLgJpPXsuRQFt; // 0x38
	public ControllerType KUsbePxnxsMwavsxYShIjwGmfADV; // 0x3C
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x40
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x41
	private Player.ControllerHelper.vUluXsRssqqTHGOorDrBIndPAadW VHhutnBRifNJWYDGBPqHCuaOWuPp; // 0x48
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x50
	private IList<ControllerMap> IryhAvabCSoMqGXdfDsAvyHVCvig; // 0x58
	private int trDFvyqCUqsYTNmOvIHIEWeCXLYb; // 0x60
	private IEnumerator<ActionElementMap> cmfgjQsgyQsPxcLTSYBUOPSpbbet; // 0x68

	// Properties
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1AD5FA0 Offset: 0x1AD51A0 VA: 0x181AD5FA0 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AD5940 Offset: 0x1AD4B40 VA: 0x181AD5940 Slot: 7
	private bool MoveNext() { }

	// RVA: 0x1AD6030 Offset: 0x1AD5230 VA: 0x181AD6030
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AD5F60 Offset: 0x1AD5160 VA: 0x181AD5F60 Slot: 9
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AD5E90 Offset: 0x1AD5090 VA: 0x181AD5E90 Slot: 6
	private IEnumerator<ActionElementMap> System.Collections.Generic.IEnumerable<Rewired.ActionElementMap>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AD5E90 Offset: 0x1AD5090 VA: 0x181AD5E90 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.MapHelper.FUijbrzZGrOvoSHrmFnukZHAasdQ : IDisposable, IEnumerable, IEnumerable<ActionElementMap>, IEnumerator, IEnumerator<ActionElementMap> // TypeDefIndex: 7059
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ActionElementMap lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	private int RMJEoXtoZMtwULyaBvSFzYLhgaKj; // 0x24
	public int NGoDsrkiKABiOBzXCjjnCIXciAdse; // 0x28
	public Player.ControllerHelper.MapHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x30
	private ControllerType XkDVpydTdKFGyaepLgJpPXsuRQFt; // 0x38
	public ControllerType KUsbePxnxsMwavsxYShIjwGmfADV; // 0x3C
	private int NDJCfPreMhWCOFQPsCzuOVGtkoBG; // 0x40
	public int IprpYEnLupXnESxCOZDQoqGwLqFj; // 0x44
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x48
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x49
	private IList<ControllerMap> mTtWWuwVTmbbMkCYFeLnKiDDkHUf; // 0x50
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x58
	private IEnumerator<ActionElementMap> ZjMCsBmztIFLBJekJGcndCgeCEXkA; // 0x60

	// Properties
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1ABC150 Offset: 0x1ABB350 VA: 0x181ABC150 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1ABBB10 Offset: 0x1ABAD10 VA: 0x181ABBB10 Slot: 7
	private bool MoveNext() { }

	// RVA: 0x1ABC1E0 Offset: 0x1ABB3E0 VA: 0x181ABC1E0
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1ABC110 Offset: 0x1ABB310 VA: 0x181ABC110 Slot: 9
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1ABC040 Offset: 0x1ABB240 VA: 0x181ABC040 Slot: 6
	private IEnumerator<ActionElementMap> System.Collections.Generic.IEnumerable<Rewired.ActionElementMap>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1ABC040 Offset: 0x1ABB240 VA: 0x181ABC040 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.MapHelper.IWdbHztTwEXIrTGTTIWXktsxSVor : IDisposable, IEnumerable, IEnumerable<ActionElementMap>, IEnumerator, IEnumerator<ActionElementMap> // TypeDefIndex: 7060
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ActionElementMap lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	private int RMJEoXtoZMtwULyaBvSFzYLhgaKj; // 0x24
	public int NGoDsrkiKABiOBzXCjjnCIXciAdse; // 0x28
	public Player.ControllerHelper.MapHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x30
	private ControllerType XkDVpydTdKFGyaepLgJpPXsuRQFt; // 0x38
	public ControllerType KUsbePxnxsMwavsxYShIjwGmfADV; // 0x3C
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x40
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x41
	private Player.ControllerHelper.vUluXsRssqqTHGOorDrBIndPAadW VHhutnBRifNJWYDGBPqHCuaOWuPp; // 0x48
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x50
	private IList<ControllerMap> IryhAvabCSoMqGXdfDsAvyHVCvig; // 0x58
	private int trDFvyqCUqsYTNmOvIHIEWeCXLYb; // 0x60
	private IEnumerator<ActionElementMap> cmfgjQsgyQsPxcLTSYBUOPSpbbet; // 0x68

	// Properties
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1ABCDB0 Offset: 0x1ABBFB0 VA: 0x181ABCDB0 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1ABC860 Offset: 0x1ABBA60 VA: 0x181ABC860 Slot: 7
	private bool MoveNext() { }

	// RVA: 0x1ABCE40 Offset: 0x1ABC040 VA: 0x181ABCE40
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1ABCD70 Offset: 0x1ABBF70 VA: 0x181ABCD70 Slot: 9
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1ABCCA0 Offset: 0x1ABBEA0 VA: 0x181ABCCA0 Slot: 6
	private IEnumerator<ActionElementMap> System.Collections.Generic.IEnumerable<Rewired.ActionElementMap>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1ABCCA0 Offset: 0x1ABBEA0 VA: 0x181ABCCA0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.MapHelper.tNusZlmUUIwxtBHNOmAguGtRVgMk : IDisposable, IEnumerable, IEnumerable<ActionElementMap>, IEnumerator, IEnumerator<ActionElementMap> // TypeDefIndex: 7061
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ActionElementMap lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	private int RMJEoXtoZMtwULyaBvSFzYLhgaKj; // 0x24
	public int NGoDsrkiKABiOBzXCjjnCIXciAdse; // 0x28
	public Player.ControllerHelper.MapHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x30
	private ControllerType XkDVpydTdKFGyaepLgJpPXsuRQFt; // 0x38
	public ControllerType KUsbePxnxsMwavsxYShIjwGmfADV; // 0x3C
	private int NDJCfPreMhWCOFQPsCzuOVGtkoBG; // 0x40
	public int IprpYEnLupXnESxCOZDQoqGwLqFj; // 0x44
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x48
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x49
	private IList<ControllerMap> mTtWWuwVTmbbMkCYFeLnKiDDkHUf; // 0x50
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x58
	private IEnumerator<ActionElementMap> ZjMCsBmztIFLBJekJGcndCgeCEXkA; // 0x60

	// Properties
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1AD8090 Offset: 0x1AD7290 VA: 0x181AD8090 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AD7B60 Offset: 0x1AD6D60 VA: 0x181AD7B60 Slot: 7
	private bool MoveNext() { }

	// RVA: 0x1AD8120 Offset: 0x1AD7320 VA: 0x181AD8120
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AD8050 Offset: 0x1AD7250 VA: 0x181AD8050 Slot: 9
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AD7F80 Offset: 0x1AD7180 VA: 0x181AD7F80 Slot: 6
	private IEnumerator<ActionElementMap> System.Collections.Generic.IEnumerable<Rewired.ActionElementMap>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AD7F80 Offset: 0x1AD7180 VA: 0x181AD7F80 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.MapHelper.rArhQoPZFThSUMeCAAPKYyZzCtBh : IDisposable, IEnumerable, IEnumerable<ActionElementMap>, IEnumerator, IEnumerator<ActionElementMap> // TypeDefIndex: 7062
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ActionElementMap lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	private int RMJEoXtoZMtwULyaBvSFzYLhgaKj; // 0x24
	public int NGoDsrkiKABiOBzXCjjnCIXciAdse; // 0x28
	public Player.ControllerHelper.MapHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x30
	private ControllerType XkDVpydTdKFGyaepLgJpPXsuRQFt; // 0x38
	public ControllerType KUsbePxnxsMwavsxYShIjwGmfADV; // 0x3C
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x40
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x41
	private Player.ControllerHelper.vUluXsRssqqTHGOorDrBIndPAadW VHhutnBRifNJWYDGBPqHCuaOWuPp; // 0x48
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x50
	private IList<ControllerMap> IryhAvabCSoMqGXdfDsAvyHVCvig; // 0x58
	private int trDFvyqCUqsYTNmOvIHIEWeCXLYb; // 0x60
	private IEnumerator<ActionElementMap> cmfgjQsgyQsPxcLTSYBUOPSpbbet; // 0x68

	// Properties
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1AD7230 Offset: 0x1AD6430 VA: 0x181AD7230 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AD6CE0 Offset: 0x1AD5EE0 VA: 0x181AD6CE0 Slot: 7
	private bool MoveNext() { }

	// RVA: 0x1AD72C0 Offset: 0x1AD64C0 VA: 0x181AD72C0
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AD71F0 Offset: 0x1AD63F0 VA: 0x181AD71F0 Slot: 9
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AD7120 Offset: 0x1AD6320 VA: 0x181AD7120 Slot: 6
	private IEnumerator<ActionElementMap> System.Collections.Generic.IEnumerable<Rewired.ActionElementMap>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AD7120 Offset: 0x1AD6320 VA: 0x181AD7120 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.MapHelper.AeaVTeOSCIilbBrKUCYchruvXTfNA : IDisposable, IEnumerable, IEnumerable<ActionElementMap>, IEnumerator, IEnumerator<ActionElementMap> // TypeDefIndex: 7063
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ActionElementMap lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	private int RMJEoXtoZMtwULyaBvSFzYLhgaKj; // 0x24
	public int NGoDsrkiKABiOBzXCjjnCIXciAdse; // 0x28
	public Player.ControllerHelper.MapHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x30
	private ControllerType XkDVpydTdKFGyaepLgJpPXsuRQFt; // 0x38
	public ControllerType KUsbePxnxsMwavsxYShIjwGmfADV; // 0x3C
	private int NDJCfPreMhWCOFQPsCzuOVGtkoBG; // 0x40
	public int IprpYEnLupXnESxCOZDQoqGwLqFj; // 0x44
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x48
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x49
	private IList<ControllerMap> mTtWWuwVTmbbMkCYFeLnKiDDkHUf; // 0x50
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x58
	private IEnumerator<ActionElementMap> ZjMCsBmztIFLBJekJGcndCgeCEXkA; // 0x60

	// Properties
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1ABBA30 Offset: 0x1ABAC30 VA: 0x181ABBA30 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1ABB500 Offset: 0x1ABA700 VA: 0x181ABB500 Slot: 7
	private bool MoveNext() { }

	// RVA: 0x1ABBAC0 Offset: 0x1ABACC0 VA: 0x181ABBAC0
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1ABB9F0 Offset: 0x1ABABF0 VA: 0x181ABB9F0 Slot: 9
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1ABB920 Offset: 0x1ABAB20 VA: 0x181ABB920 Slot: 6
	private IEnumerator<ActionElementMap> System.Collections.Generic.IEnumerable<Rewired.ActionElementMap>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1ABB920 Offset: 0x1ABAB20 VA: 0x181ABB920 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.MapHelper.HjORDLfeHaEYAzoYZFogIihbdKZRA : IDisposable, IEnumerable, IEnumerator, IEnumerable<ControllerMap>, IEnumerator<ControllerMap> // TypeDefIndex: 7064
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerMap lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public Player.ControllerHelper.MapHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private ControllerType XkDVpydTdKFGyaepLgJpPXsuRQFt; // 0x30
	public ControllerType KUsbePxnxsMwavsxYShIjwGmfADV; // 0x34
	private int NDJCfPreMhWCOFQPsCzuOVGtkoBG; // 0x38
	public int IprpYEnLupXnESxCOZDQoqGwLqFj; // 0x3C
	private int wGBlZAeXywpnLTVAippvBHBjeoet; // 0x40
	public int VfSIvcbRWJkDHPWNlBkmlVmAhOrnA; // 0x44
	private IList<ControllerMap> mTtWWuwVTmbbMkCYFeLnKiDDkHUf; // 0x48
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x50

	// Properties
	private ControllerMap System.Collections.Generic.IEnumerator<Rewired.ControllerMap>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1ADF0A0 Offset: 0x1ADE2A0 VA: 0x181ADF0A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private ControllerMap System.Collections.Generic.IEnumerator<Rewired.ControllerMap>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1ADF3C0 Offset: 0x1ADE5C0 VA: 0x181ADF3C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1ADF2F0 Offset: 0x1ADE4F0 VA: 0x181ADF2F0 Slot: 9
	private IEnumerator<ControllerMap> System.Collections.Generic.IEnumerable<Rewired.ControllerMap>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1ADF2F0 Offset: 0x1ADE4F0 VA: 0x181ADF2F0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.MapHelper.wbqteKkPDxjUOjSxaeNlXcARrjjs<> : IDisposable, IEnumerable, IEnumerator, IEnumerable<>, IEnumerator<> // TypeDefIndex: 7065
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x0
	private  lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x0
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x0
	public Player.ControllerHelper.MapHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x0
	private int NDJCfPreMhWCOFQPsCzuOVGtkoBG; // 0x0
	public int IprpYEnLupXnESxCOZDQoqGwLqFj; // 0x0
	private int wGBlZAeXywpnLTVAippvBHBjeoet; // 0x0
	public int VfSIvcbRWJkDHPWNlBkmlVmAhOrnA; // 0x0
	private IList<> mTtWWuwVTmbbMkCYFeLnKiDDkHUf; // 0x0
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x0

	// Properties
	private  zvdZSMDIEfaCbWGLZgdKgiWmNoxcb { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	|-Player.ControllerHelper.MapHelper.wbqteKkPDxjUOjSxaeNlXcARrjjs<object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-Player.ControllerHelper.MapHelper.wbqteKkPDxjUOjSxaeNlXcARrjjs<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE79BC0 Offset: 0xE78DC0 VA: 0x180E79BC0
	|-Player.ControllerHelper.MapHelper.wbqteKkPDxjUOjSxaeNlXcARrjjs<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private  System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Player.ControllerHelper.MapHelper.wbqteKkPDxjUOjSxaeNlXcARrjjs<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-Player.ControllerHelper.MapHelper.wbqteKkPDxjUOjSxaeNlXcARrjjs<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Player.ControllerHelper.MapHelper.wbqteKkPDxjUOjSxaeNlXcARrjjs<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private IEnumerator<> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE79F00 Offset: 0xE79100 VA: 0x180E79F00
	|-Player.ControllerHelper.MapHelper.wbqteKkPDxjUOjSxaeNlXcARrjjs<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE79FD0 Offset: 0xE791D0 VA: 0x180E79FD0
	|-Player.ControllerHelper.MapHelper.wbqteKkPDxjUOjSxaeNlXcARrjjs<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.MapHelper.qVSILEiaajhqvCmnsnCPPvfTZNYp : IDisposable, IEnumerable, IEnumerable<ActionElementMap>, IEnumerator, IEnumerator<ActionElementMap> // TypeDefIndex: 7066
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ActionElementMap lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public Player.ControllerHelper.MapHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int RMJEoXtoZMtwULyaBvSFzYLhgaKj; // 0x30
	public int NGoDsrkiKABiOBzXCjjnCIXciAdse; // 0x34
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x38
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x39
	private int CzKfPhaRWuffJnyiWVpldLjlOYS; // 0x3C
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x40
	private Player.ControllerHelper.vUluXsRssqqTHGOorDrBIndPAadW kFEbonnqCsxSeJrbESEAeexpTKfi; // 0x48
	private int QjtuECTijUAVBdtxEzDlbboNeDKeb; // 0x50
	private int pyQLGGZqNaQgIvoPCvziKBwnbtLq; // 0x54
	private dyCkQiVTJnvQvTqPOHWiKoiJbMucA AWvtlPYXlqSqZidTFGNsJieSLjoe; // 0x58
	private int weDChHfUtXXDOcUrtJFNCmxPIQdDb; // 0x60
	private int iTWPygEySPRMovcxQzJaFNjoAgTeA; // 0x64
	private IEnumerator<ActionElementMap> teAwSmgXqJODRFvQorNEhmGRFLUH; // 0x68

	// Properties
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1AF63D0 Offset: 0x1AF55D0 VA: 0x181AF63D0 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AF5DE0 Offset: 0x1AF4FE0 VA: 0x181AF5DE0 Slot: 7
	private bool MoveNext() { }

	// RVA: 0x1AF6460 Offset: 0x1AF5660 VA: 0x181AF6460
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF6390 Offset: 0x1AF5590 VA: 0x181AF6390 Slot: 9
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF62D0 Offset: 0x1AF54D0 VA: 0x181AF62D0 Slot: 6
	private IEnumerator<ActionElementMap> System.Collections.Generic.IEnumerable<Rewired.ActionElementMap>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AF62D0 Offset: 0x1AF54D0 VA: 0x181AF62D0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.MapHelper.VzBrypESRXaqfuolccGByLDhBqlm : IDisposable, IEnumerable, IEnumerable<ActionElementMap>, IEnumerator, IEnumerator<ActionElementMap> // TypeDefIndex: 7067
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ActionElementMap lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	private IControllerElementTarget SPZwWgkugIdIobuRoanvoELOxALn; // 0x28
	public IControllerElementTarget wTdwqWPpHJyhbydqsmiTPijdczEBA; // 0x30
	public Player.ControllerHelper.MapHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x38
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x40
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x41
	private bool mqcNvlmqlaXucVgvJXGODAwyHejU; // 0x42
	public bool HjVYVpwRqWWnAmbnKTCIfuxSAsjm; // 0x43
	private int RMJEoXtoZMtwULyaBvSFzYLhgaKj; // 0x44
	public int NGoDsrkiKABiOBzXCjjnCIXciAdse; // 0x48
	private Player.ControllerHelper.vUluXsRssqqTHGOorDrBIndPAadW VHhutnBRifNJWYDGBPqHCuaOWuPp; // 0x50
	private int jrkEEqbPtDMlPGdCgVtgjMQWkDqrA; // 0x58
	private int pPGgUESwNACgnGeuXdCQJJGRwcRF; // 0x5C
	private IList<ControllerMap> evxtukMcOwvmabHYrbqjjMgKfezrA; // 0x60
	private int cMrAkoevxdfacDoLnsFsFgtodjSf; // 0x68
	private int jebsgQRnnKyIMrCrCWuNDXIQhLhT; // 0x6C
	private TempListPool.TList<ActionElementMap> lvfNGFnMqwiCDIoykZNGjbiYyKML; // 0x70
	private List.Enumerator<ActionElementMap> nTvjDtEiFZQLgzKXSZfADCzzcWoQ; // 0x78

	// Properties
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1AF2C50 Offset: 0x1AF1E50 VA: 0x181AF2C50 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AF2510 Offset: 0x1AF1710 VA: 0x181AF2510 Slot: 7
	private bool MoveNext() { }

	// RVA: 0x1AF2DA0 Offset: 0x1AF1FA0 VA: 0x181AF2DA0
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	// RVA: 0x1AF2AE0 Offset: 0x1AF1CE0 VA: 0x181AF2AE0
	private void NliQpQwAufCfLWbPmVSuBlrEIiqh() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private ActionElementMap System.Collections.Generic.IEnumerator<Rewired.ActionElementMap>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF2C10 Offset: 0x1AF1E10 VA: 0x181AF2C10 Slot: 9
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 8
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF2B30 Offset: 0x1AF1D30 VA: 0x181AF2B30 Slot: 6
	private IEnumerator<ActionElementMap> System.Collections.Generic.IEnumerable<Rewired.ActionElementMap>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AF2B30 Offset: 0x1AF1D30 VA: 0x181AF2B30 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.MapHelper.SakyIhlaYzLsPvzZkVXLVcHKzKZK : IDisposable, IEnumerable, IEnumerator, IEnumerable<ControllerMap>, IEnumerator<ControllerMap> // TypeDefIndex: 7068
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerMap lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public Player.ControllerHelper.MapHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int CzKfPhaRWuffJnyiWVpldLjlOYS; // 0x30
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x34
	private Player.ControllerHelper.vUluXsRssqqTHGOorDrBIndPAadW kFEbonnqCsxSeJrbESEAeexpTKfi; // 0x38
	private int QjtuECTijUAVBdtxEzDlbboNeDKeb; // 0x40
	private int pyQLGGZqNaQgIvoPCvziKBwnbtLq; // 0x44
	private dyCkQiVTJnvQvTqPOHWiKoiJbMucA AWvtlPYXlqSqZidTFGNsJieSLjoe; // 0x48
	private int weDChHfUtXXDOcUrtJFNCmxPIQdDb; // 0x50
	private int iTWPygEySPRMovcxQzJaFNjoAgTeA; // 0x54

	// Properties
	private ControllerMap System.Collections.Generic.IEnumerator<Rewired.ControllerMap>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AF21F0 Offset: 0x1AF13F0 VA: 0x181AF21F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private ControllerMap System.Collections.Generic.IEnumerator<Rewired.ControllerMap>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF24D0 Offset: 0x1AF16D0 VA: 0x181AF24D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF2410 Offset: 0x1AF1610 VA: 0x181AF2410 Slot: 9
	private IEnumerator<ControllerMap> System.Collections.Generic.IEnumerable<Rewired.ControllerMap>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AF2410 Offset: 0x1AF1610 VA: 0x181AF2410 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.MapHelper.RclPrEnhUaXSsKIlrDluaLnCFMWo<> : IDisposable, IEnumerable, IEnumerator, IEnumerable<>, IEnumerator<> // TypeDefIndex: 7069
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x0
	private  lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x0
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x0
	public Player.ControllerHelper.MapHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x0
	private Player.ControllerHelper.vUluXsRssqqTHGOorDrBIndPAadW VHhutnBRifNJWYDGBPqHCuaOWuPp; // 0x0
	private int TvFjQMfXcjaCvYiuelTwTMAzONWH; // 0x0
	private int pPGgUESwNACgnGeuXdCQJJGRwcRF; // 0x0
	private dyCkQiVTJnvQvTqPOHWiKoiJbMucA HwMwcBUpBsaXFyZvLGDdflTPzDix; // 0x0
	private int cMrAkoevxdfacDoLnsFsFgtodjSf; // 0x0
	private int jebsgQRnnKyIMrCrCWuNDXIQhLhT; // 0x0
	private int weDChHfUtXXDOcUrtJFNCmxPIQdDb; // 0x0
	private int iTWPygEySPRMovcxQzJaFNjoAgTeA; // 0x0

	// Properties
	private  zvdZSMDIEfaCbWGLZgdKgiWmNoxcb { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	|-Player.ControllerHelper.MapHelper.RclPrEnhUaXSsKIlrDluaLnCFMWo<object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-Player.ControllerHelper.MapHelper.RclPrEnhUaXSsKIlrDluaLnCFMWo<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB0D30 Offset: 0xBAFF30 VA: 0x180BB0D30
	|-Player.ControllerHelper.MapHelper.RclPrEnhUaXSsKIlrDluaLnCFMWo<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private  System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Player.ControllerHelper.MapHelper.RclPrEnhUaXSsKIlrDluaLnCFMWo<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-Player.ControllerHelper.MapHelper.RclPrEnhUaXSsKIlrDluaLnCFMWo<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Player.ControllerHelper.MapHelper.RclPrEnhUaXSsKIlrDluaLnCFMWo<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private IEnumerator<> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB12B0 Offset: 0xBB04B0 VA: 0x180BB12B0
	|-Player.ControllerHelper.MapHelper.RclPrEnhUaXSsKIlrDluaLnCFMWo<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB1380 Offset: 0xBB0580 VA: 0x180BB1380
	|-Player.ControllerHelper.MapHelper.RclPrEnhUaXSsKIlrDluaLnCFMWo<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.MapHelper.jpvjLNNKRihgotDhhzRcPpcxxixj : IDisposable, IEnumerable, IEnumerator, IEnumerable<ControllerMap>, IEnumerator<ControllerMap> // TypeDefIndex: 7070
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerMap lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public Player.ControllerHelper.MapHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private ControllerType XkDVpydTdKFGyaepLgJpPXsuRQFt; // 0x30
	public ControllerType KUsbePxnxsMwavsxYShIjwGmfADV; // 0x34
	private Player.ControllerHelper.vUluXsRssqqTHGOorDrBIndPAadW VHhutnBRifNJWYDGBPqHCuaOWuPp; // 0x38
	private int DgkOlPmLFKjJIdOhKlVtLvtLAUlEb; // 0x40
	private int pPGgUESwNACgnGeuXdCQJJGRwcRF; // 0x44
	private dyCkQiVTJnvQvTqPOHWiKoiJbMucA HwMwcBUpBsaXFyZvLGDdflTPzDix; // 0x48
	private int cMrAkoevxdfacDoLnsFsFgtodjSf; // 0x50
	private int jebsgQRnnKyIMrCrCWuNDXIQhLhT; // 0x54

	// Properties
	private ControllerMap System.Collections.Generic.IEnumerator<Rewired.ControllerMap>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AF3D20 Offset: 0x1AF2F20 VA: 0x181AF3D20 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private ControllerMap System.Collections.Generic.IEnumerator<Rewired.ControllerMap>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF3FC0 Offset: 0x1AF31C0 VA: 0x181AF3FC0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF3F00 Offset: 0x1AF3100 VA: 0x181AF3F00 Slot: 9
	private IEnumerator<ControllerMap> System.Collections.Generic.IEnumerable<Rewired.ControllerMap>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AF3F00 Offset: 0x1AF3100 VA: 0x181AF3F00 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.MapHelper.wHSDitfybfFfHXbkqeNwXNamWVTuA : IDisposable, IEnumerable, IEnumerator, IEnumerable<ControllerMap>, IEnumerator<ControllerMap> // TypeDefIndex: 7071
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerMap lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public Player.ControllerHelper.MapHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int wGBlZAeXywpnLTVAippvBHBjeoet; // 0x30
	public int VfSIvcbRWJkDHPWNlBkmlVmAhOrnA; // 0x34
	private int CzKfPhaRWuffJnyiWVpldLjlOYS; // 0x38
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x3C
	private Player.ControllerHelper.vUluXsRssqqTHGOorDrBIndPAadW kFEbonnqCsxSeJrbESEAeexpTKfi; // 0x40
	private int QjtuECTijUAVBdtxEzDlbboNeDKeb; // 0x48
	private int pyQLGGZqNaQgIvoPCvziKBwnbtLq; // 0x4C
	private dyCkQiVTJnvQvTqPOHWiKoiJbMucA AWvtlPYXlqSqZidTFGNsJieSLjoe; // 0x50
	private int weDChHfUtXXDOcUrtJFNCmxPIQdDb; // 0x58
	private int iTWPygEySPRMovcxQzJaFNjoAgTeA; // 0x5C

	// Properties
	private ControllerMap System.Collections.Generic.IEnumerator<Rewired.ControllerMap>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AF64B0 Offset: 0x1AF56B0 VA: 0x181AF64B0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private ControllerMap System.Collections.Generic.IEnumerator<Rewired.ControllerMap>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF67B0 Offset: 0x1AF59B0 VA: 0x181AF67B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF66F0 Offset: 0x1AF58F0 VA: 0x181AF66F0 Slot: 9
	private IEnumerator<ControllerMap> System.Collections.Generic.IEnumerable<Rewired.ControllerMap>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AF66F0 Offset: 0x1AF58F0 VA: 0x181AF66F0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.MapHelper.inhfcwgFoNhHDUuLvWnaOvLRRvMv<> : IDisposable, IEnumerable, IEnumerator, IEnumerable<>, IEnumerator<> // TypeDefIndex: 7072
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x0
	private  lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x0
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x0
	public Player.ControllerHelper.MapHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x0
	private int wGBlZAeXywpnLTVAippvBHBjeoet; // 0x0
	public int VfSIvcbRWJkDHPWNlBkmlVmAhOrnA; // 0x0
	private Player.ControllerHelper.vUluXsRssqqTHGOorDrBIndPAadW VHhutnBRifNJWYDGBPqHCuaOWuPp; // 0x0
	private int TvFjQMfXcjaCvYiuelTwTMAzONWH; // 0x0
	private int ZEbULkSKbuLYUjClgyLgVROloJvX; // 0x0
	private dyCkQiVTJnvQvTqPOHWiKoiJbMucA HwMwcBUpBsaXFyZvLGDdflTPzDix; // 0x0
	private int cMrAkoevxdfacDoLnsFsFgtodjSf; // 0x0
	private int aZhOUyltBHQcFGDqdEJVYqFabYpb; // 0x0
	private int weDChHfUtXXDOcUrtJFNCmxPIQdDb; // 0x0
	private int iTWPygEySPRMovcxQzJaFNjoAgTeA; // 0x0

	// Properties
	private  zvdZSMDIEfaCbWGLZgdKgiWmNoxcb { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	|-Player.ControllerHelper.MapHelper.inhfcwgFoNhHDUuLvWnaOvLRRvMv<object>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-Player.ControllerHelper.MapHelper.inhfcwgFoNhHDUuLvWnaOvLRRvMv<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6E140 Offset: 0xE6D340 VA: 0x180E6E140
	|-Player.ControllerHelper.MapHelper.inhfcwgFoNhHDUuLvWnaOvLRRvMv<object>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private  System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Player.ControllerHelper.MapHelper.inhfcwgFoNhHDUuLvWnaOvLRRvMv<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-Player.ControllerHelper.MapHelper.inhfcwgFoNhHDUuLvWnaOvLRRvMv<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	|-Player.ControllerHelper.MapHelper.inhfcwgFoNhHDUuLvWnaOvLRRvMv<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private IEnumerator<> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6E6E0 Offset: 0xE6D8E0 VA: 0x180E6E6E0
	|-Player.ControllerHelper.MapHelper.inhfcwgFoNhHDUuLvWnaOvLRRvMv<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6E7B0 Offset: 0xE6D9B0 VA: 0x180E6E7B0
	|-Player.ControllerHelper.MapHelper.inhfcwgFoNhHDUuLvWnaOvLRRvMv<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.MapHelper.QFsZshkURnjkoEFgGhcYiaRqmWEpA : IDisposable, IEnumerable, IEnumerator, IEnumerable<ControllerMap>, IEnumerator<ControllerMap> // TypeDefIndex: 7073
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerMap lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public Player.ControllerHelper.MapHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private ControllerType XkDVpydTdKFGyaepLgJpPXsuRQFt; // 0x30
	public ControllerType KUsbePxnxsMwavsxYShIjwGmfADV; // 0x34
	private int wGBlZAeXywpnLTVAippvBHBjeoet; // 0x38
	public int VfSIvcbRWJkDHPWNlBkmlVmAhOrnA; // 0x3C
	private Player.ControllerHelper.vUluXsRssqqTHGOorDrBIndPAadW YVRYGyMGSFahnEtxgZkCRcbnDMZnA; // 0x40
	private int jrkEEqbPtDMlPGdCgVtgjMQWkDqrA; // 0x48
	private int pPGgUESwNACgnGeuXdCQJJGRwcRF; // 0x4C
	private dyCkQiVTJnvQvTqPOHWiKoiJbMucA HwMwcBUpBsaXFyZvLGDdflTPzDix; // 0x50
	private int cMrAkoevxdfacDoLnsFsFgtodjSf; // 0x58
	private int jebsgQRnnKyIMrCrCWuNDXIQhLhT; // 0x5C

	// Properties
	private ControllerMap System.Collections.Generic.IEnumerator<Rewired.ControllerMap>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AE6C50 Offset: 0x1AE5E50 VA: 0x181AE6C50 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private ControllerMap System.Collections.Generic.IEnumerator<Rewired.ControllerMap>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AE6F10 Offset: 0x1AE6110 VA: 0x181AE6F10 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AE6E50 Offset: 0x1AE6050 VA: 0x181AE6E50 Slot: 9
	private IEnumerator<ControllerMap> System.Collections.Generic.IEnumerable<Rewired.ControllerMap>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AE6E50 Offset: 0x1AE6050 VA: 0x181AE6E50 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[Browsable(False)]
[EditorBrowsable(1)]
public sealed class Player.ControllerHelper.MapHelper : CodeHelper // TypeDefIndex: 7074
{
	// Fields
	private readonly EzquJbHEydffWdoNsmXAduNipKns rmzUgKnkcXzRxgrBflbDpeziOhIr; // 0x10
	private Player dKxeWVrXJNsFqEAYKfLlJKDBwaWd; // 0x18
	private Player.ControllerHelper JzLBwDullgkQLozUBYHRGdbOnLzK; // 0x20
	private readonly ControllerMapEnabler zpsGffkEPPCuyvXTFJkseafxpOJhb; // 0x28
	private readonly ControllerMapLayoutManager PepMhenJqcbUUGeSKxXFIMiVkKCdb; // 0x30
	private readonly int aplyKYJQthDqFZJRnEooAHmQTlabA; // 0x38

	// Properties
	public ControllerMapLayoutManager layoutManager { get; }
	public ControllerMapEnabler mapEnabler { get; }
	public IList<InputBehavior> InputBehaviors { get; }

	// Methods

	// RVA: 0x1ACF110 Offset: 0x1ACE310 VA: 0x181ACF110
	internal void .ctor(Player , Player.ControllerHelper , EzquJbHEydffWdoNsmXAduNipKns , ControllerMapLayoutManager.CyLIHYrgPsXJSPGIXMMCKhWGZnNj , ControllerMapEnabler.CivyAOWvRKPsTDBqoIBdmQrvjYZC ) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public ControllerMapLayoutManager get_layoutManager() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public ControllerMapEnabler get_mapEnabler() { }

	// RVA: -1 Offset: -1
	public void LoadMap<T>(int controllerId, int categoryId, int layoutId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD2210 Offset: 0xAD1410 VA: 0x180AD2210
	|-Player.ControllerHelper.MapHelper.LoadMap<object>
	*/

	// RVA: -1 Offset: -1
	public void LoadMap<T>(int controllerId, string categoryName, string layoutName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD2290 Offset: 0xAD1490 VA: 0x180AD2290
	|-Player.ControllerHelper.MapHelper.LoadMap<object>
	*/

	// RVA: 0x1ACAB90 Offset: 0x1AC9D90 VA: 0x181ACAB90
	public void LoadMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId) { }

	// RVA: 0x1ACAAE0 Offset: 0x1AC9CE0 VA: 0x181ACAAE0
	public void LoadMap(ControllerType controllerType, int controllerId, string categoryName, string layoutName) { }

	// RVA: -1 Offset: -1
	public void LoadMap<T>(int controllerId, int categoryId, int layoutId, bool startEnabled) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD20F0 Offset: 0xAD12F0 VA: 0x180AD20F0
	|-Player.ControllerHelper.MapHelper.LoadMap<object>
	*/

	// RVA: -1 Offset: -1
	public void LoadMap<T>(int controllerId, string categoryName, string layoutName, bool startEnabled) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD2180 Offset: 0xAD1380 VA: 0x180AD2180
	|-Player.ControllerHelper.MapHelper.LoadMap<object>
	*/

	// RVA: 0x1ACAB50 Offset: 0x1AC9D50 VA: 0x181ACAB50
	public void LoadMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId, bool startEnabled) { }

	// RVA: 0x1ACAB10 Offset: 0x1AC9D10 VA: 0x181ACAB10
	public void LoadMap(ControllerType controllerType, int controllerId, string categoryName, string layoutName, bool startEnabled) { }

	// RVA: -1 Offset: -1
	private void egwNAsIemGBQpFLNdlNscOrvMWibA<>(int , int , int , BoolOption ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD2D40 Offset: 0xAD1F40 VA: 0x180AD2D40
	|-Player.ControllerHelper.MapHelper.egwNAsIemGBQpFLNdlNscOrvMWibA<object>
	*/

	// RVA: -1 Offset: -1
	private void egwNAsIemGBQpFLNdlNscOrvMWibA<>(int , string , string , BoolOption ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD2C50 Offset: 0xAD1E50 VA: 0x180AD2C50
	|-Player.ControllerHelper.MapHelper.egwNAsIemGBQpFLNdlNscOrvMWibA<object>
	*/

	// RVA: 0x1AD0580 Offset: 0x1ACF780 VA: 0x181AD0580
	private void egwNAsIemGBQpFLNdlNscOrvMWibA(ControllerType , int , int , int , BoolOption ) { }

	// RVA: 0x1AD04B0 Offset: 0x1ACF6B0 VA: 0x181AD04B0
	private void egwNAsIemGBQpFLNdlNscOrvMWibA(ControllerType , int , string , string , BoolOption ) { }

	// RVA: 0x1AC4150 Offset: 0x1AC3350 VA: 0x181AC4150
	public IEnumerable<ControllerMap> GetAllMaps() { }

	// RVA: 0x1AC3E30 Offset: 0x1AC3030 VA: 0x181AC3E30
	public int GetAllMaps(List<ControllerMap> results) { }

	// RVA: -1 Offset: -1
	public IEnumerable<T> GetAllMaps<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD0C40 Offset: 0xACFE40 VA: 0x180AD0C40
	|-Player.ControllerHelper.MapHelper.GetAllMaps<object>
	*/

	// RVA: -1 Offset: -1
	public int GetAllMaps<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD0CC0 Offset: 0xACFEC0 VA: 0x180AD0CC0
	|-Player.ControllerHelper.MapHelper.GetAllMaps<object>
	*/

	// RVA: 0x1AC40D0 Offset: 0x1AC32D0 VA: 0x181AC40D0
	public IEnumerable<ControllerMap> GetAllMaps(ControllerType controllerType) { }

	// RVA: 0x1AC41C0 Offset: 0x1AC33C0 VA: 0x181AC41C0
	public int GetAllMaps(ControllerType controllerType, List<ControllerMap> results) { }

	// RVA: 0x1AC3460 Offset: 0x1AC2660 VA: 0x181AC3460
	public IEnumerable<ControllerMap> GetAllMapsInCategory(string categoryName) { }

	// RVA: 0x1AC3150 Offset: 0x1AC2350 VA: 0x181AC3150
	public IEnumerable<ControllerMap> GetAllMapsInCategory(int categoryId) { }

	// RVA: -1 Offset: -1
	public IEnumerable<T> GetAllMapsInCategory<T>(string categoryName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD0540 Offset: 0xACF740 VA: 0x180AD0540
	|-Player.ControllerHelper.MapHelper.GetAllMapsInCategory<object>
	*/

	// RVA: -1 Offset: -1
	public IEnumerable<T> GetAllMapsInCategory<T>(int categoryId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD06B0 Offset: 0xACF8B0 VA: 0x180AD06B0
	|-Player.ControllerHelper.MapHelper.GetAllMapsInCategory<object>
	*/

	// RVA: 0x1AC31D0 Offset: 0x1AC23D0 VA: 0x181AC31D0
	public IEnumerable<ControllerMap> GetAllMapsInCategory(string categoryName, ControllerType controllerType) { }

	// RVA: 0x1AC3DA0 Offset: 0x1AC2FA0 VA: 0x181AC3DA0
	public IEnumerable<ControllerMap> GetAllMapsInCategory(int categoryId, ControllerType controllerType) { }

	// RVA: 0x1AC35F0 Offset: 0x1AC27F0 VA: 0x181AC35F0
	public int GetAllMapsInCategory(string categoryName, List<ControllerMap> results) { }

	// RVA: 0x1AC3AB0 Offset: 0x1AC2CB0 VA: 0x181AC3AB0
	public int GetAllMapsInCategory(int categoryId, List<ControllerMap> results) { }

	// RVA: -1 Offset: -1
	public int GetAllMapsInCategory<T>(string categoryName, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD0440 Offset: 0xACF640 VA: 0x180AD0440
	|-Player.ControllerHelper.MapHelper.GetAllMapsInCategory<object>
	*/

	// RVA: -1 Offset: -1
	public int GetAllMapsInCategory<T>(int categoryId, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD0740 Offset: 0xACF940 VA: 0x180AD0740
	|-Player.ControllerHelper.MapHelper.GetAllMapsInCategory<object>
	*/

	// RVA: 0x1AC3360 Offset: 0x1AC2560 VA: 0x181AC3360
	public int GetAllMapsInCategory(string categoryName, ControllerType controllerType, List<ControllerMap> results) { }

	// RVA: 0x1AC36E0 Offset: 0x1AC28E0 VA: 0x181AC36E0
	public int GetAllMapsInCategory(int categoryId, ControllerType controllerType, List<ControllerMap> results) { }

	// RVA: -1 Offset: -1
	public IList<T> GetMaps<T>(int controllerId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD1F40 Offset: 0xAD1140 VA: 0x180AD1F40
	|-Player.ControllerHelper.MapHelper.GetMaps<object>
	*/

	// RVA: 0x1AC9F00 Offset: 0x1AC9100 VA: 0x181AC9F00
	public IList<ControllerMap> GetMaps(ControllerType controllerType, int controllerId) { }

	// RVA: 0x1AC9FD0 Offset: 0x1AC91D0 VA: 0x181AC9FD0
	public IList<ControllerMap> GetMaps(Controller controller) { }

	// RVA: 0x1AC9620 Offset: 0x1AC8820 VA: 0x181AC9620
	public IEnumerable<ControllerMap> GetMapsInCategory(ControllerType controllerType, int controllerId, int categoryId) { }

	// RVA: 0x1AC9DF0 Offset: 0x1AC8FF0 VA: 0x181AC9DF0
	public IEnumerable<ControllerMap> GetMapsInCategory(ControllerType controllerType, int controllerId, string categoryName) { }

	// RVA: 0x1AC9790 Offset: 0x1AC8990 VA: 0x181AC9790
	public IEnumerable<ControllerMap> GetMapsInCategory(Controller controller, int categoryId) { }

	// RVA: 0x1AC94F0 Offset: 0x1AC86F0 VA: 0x181AC94F0
	public IEnumerable<ControllerMap> GetMapsInCategory(Controller controller, string categoryName) { }

	// RVA: 0x1AC9AA0 Offset: 0x1AC8CA0 VA: 0x181AC9AA0
	public int GetMapsInCategory(ControllerType controllerType, int controllerId, int categoryId, List<ControllerMap> results) { }

	// RVA: 0x1AC9970 Offset: 0x1AC8B70 VA: 0x181AC9970
	public int GetMapsInCategory(ControllerType controllerType, int controllerId, string categoryName, List<ControllerMap> results) { }

	// RVA: 0x1AC9880 Offset: 0x1AC8A80 VA: 0x181AC9880
	public int GetMapsInCategory(Controller controller, int categoryId, List<ControllerMap> results) { }

	// RVA: 0x1AC9CC0 Offset: 0x1AC8EC0 VA: 0x181AC9CC0
	public int GetMapsInCategory(Controller controller, string categoryName, List<ControllerMap> results) { }

	// RVA: -1 Offset: -1
	public IEnumerable<T> GetMapsInCategory<T>(int controllerId, int categoryId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD1E10 Offset: 0xAD1010 VA: 0x180AD1E10
	|-Player.ControllerHelper.MapHelper.GetMapsInCategory<object>
	*/

	// RVA: -1 Offset: -1
	public IEnumerable<T> GetMapsInCategory<T>(int controllerId, string categoryName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD1A20 Offset: 0xAD0C20 VA: 0x180AD1A20
	|-Player.ControllerHelper.MapHelper.GetMapsInCategory<object>
	*/

	// RVA: -1 Offset: -1
	public int GetMapsInCategory<T>(int controllerId, int categoryId, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD1C20 Offset: 0xAD0E20 VA: 0x180AD1C20
	|-Player.ControllerHelper.MapHelper.GetMapsInCategory<object>
	*/

	// RVA: -1 Offset: -1
	public int GetMapsInCategory<T>(int controllerId, string categoryName, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD1900 Offset: 0xAD0B00 VA: 0x180AD1900
	|-Player.ControllerHelper.MapHelper.GetMapsInCategory<object>
	*/

	// RVA: -1 Offset: -1
	public T GetMap<T>(int controllerId, int mapId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD1690 Offset: 0xAD0890 VA: 0x180AD1690
	|-Player.ControllerHelper.MapHelper.GetMap<object>
	*/

	// RVA: -1 Offset: -1
	public T GetMap<T>(int controllerId, int categoryId, int layoutId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD17C0 Offset: 0xAD09C0 VA: 0x180AD17C0
	|-Player.ControllerHelper.MapHelper.GetMap<object>
	*/

	// RVA: -1 Offset: -1
	public T GetMap<T>(int controllerId, string categoryName, string layoutName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD1560 Offset: 0xAD0760 VA: 0x180AD1560
	|-Player.ControllerHelper.MapHelper.GetMap<object>
	*/

	// RVA: 0x1AC8F40 Offset: 0x1AC8140 VA: 0x181AC8F40
	public ControllerMap GetMap(int mapId) { }

	// RVA: 0x1AC8E80 Offset: 0x1AC8080 VA: 0x181AC8E80
	public ControllerMap GetMap(ControllerType controllerType, int controllerId, int mapId) { }

	// RVA: 0x1AC9420 Offset: 0x1AC8620 VA: 0x181AC9420
	public ControllerMap GetMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId) { }

	// RVA: 0x1AC8DB0 Offset: 0x1AC7FB0 VA: 0x181AC8DB0
	public ControllerMap GetMap(ControllerType controllerType, int controllerId, string categoryName, string layoutName) { }

	// RVA: 0x1AC8C40 Offset: 0x1AC7E40 VA: 0x181AC8C40
	public ControllerMap GetMap(Controller controller, int mapId) { }

	// RVA: 0x1AC9150 Offset: 0x1AC8350 VA: 0x181AC9150
	public ControllerMap GetMap(Controller controller, int categoryId, int layoutId) { }

	// RVA: 0x1AC92C0 Offset: 0x1AC84C0 VA: 0x181AC92C0
	public ControllerMap GetMap(Controller controller, string categoryName, string layoutName) { }

	// RVA: -1 Offset: -1
	public T GetFirstMapInCategory<T>(int controllerId, string categoryName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD1180 Offset: 0xAD0380 VA: 0x180AD1180
	|-Player.ControllerHelper.MapHelper.GetFirstMapInCategory<object>
	*/

	// RVA: -1 Offset: -1
	public T GetFirstMapInCategory<T>(int controllerId, int categoryId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD1360 Offset: 0xAD0560 VA: 0x180AD1360
	|-Player.ControllerHelper.MapHelper.GetFirstMapInCategory<object>
	*/

	// RVA: 0x1AC8820 Offset: 0x1AC7A20 VA: 0x181AC8820
	public ControllerMap GetFirstMapInCategory(ControllerType controllerType, int controllerId, string categoryName) { }

	// RVA: 0x1AC8920 Offset: 0x1AC7B20 VA: 0x181AC8920
	public ControllerMap GetFirstMapInCategory(ControllerType controllerType, int controllerId, int categoryId) { }

	// RVA: 0x1AC85C0 Offset: 0x1AC77C0 VA: 0x181AC85C0
	public ControllerMap GetFirstMapInCategory(Controller controller, string categoryName) { }

	// RVA: 0x1AC8750 Offset: 0x1AC7950 VA: 0x181AC8750
	public ControllerMap GetFirstMapInCategory(Controller controller, int categoryId) { }

	// RVA: -1 Offset: -1
	public void AddMap<T>(int controllerId, ControllerMap map) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACF070 Offset: 0xACE270 VA: 0x180ACF070
	|-Player.ControllerHelper.MapHelper.AddMap<object>
	*/

	// RVA: 0x1ABE540 Offset: 0x1ABD740 VA: 0x181ABE540
	public void AddMap(Controller controller, ControllerMap map) { }

	// RVA: 0x1ABE480 Offset: 0x1ABD680 VA: 0x181ABE480
	public void AddMap(ControllerType controllerType, int controllerId, ControllerMap map) { }

	// RVA: -1 Offset: -1
	public void AddMap<T>(int controllerId, ControllerMap map, bool startEnabled) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACEF80 Offset: 0xACE180 VA: 0x180ACEF80
	|-Player.ControllerHelper.MapHelper.AddMap<object>
	*/

	// RVA: 0x1ABE2E0 Offset: 0x1ABD4E0 VA: 0x181ABE2E0
	public void AddMap(Controller controller, ControllerMap map, bool startEnabled) { }

	// RVA: 0x1ABE3B0 Offset: 0x1ABD5B0 VA: 0x181ABE3B0
	public void AddMap(ControllerType controllerType, int controllerId, ControllerMap map, bool startEnabled) { }

	// RVA: -1 Offset: -1
	public bool AddMapFromXml<T>(int controllerId, string xmlString) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACEEB0 Offset: 0xACE0B0 VA: 0x180ACEEB0
	|-Player.ControllerHelper.MapHelper.AddMapFromXml<object>
	*/

	// RVA: 0x1ABE220 Offset: 0x1ABD420 VA: 0x181ABE220
	public bool AddMapFromXml(ControllerType controllerType, int controllerId, string xmlString) { }

	// RVA: -1 Offset: -1
	public int AddMapsFromXml<T>(int controllerId, List<string> xmlStrings) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACF330 Offset: 0xACE530 VA: 0x180ACF330
	|-Player.ControllerHelper.MapHelper.AddMapsFromXml<object>
	*/

	// RVA: 0x1ABE7D0 Offset: 0x1ABD9D0 VA: 0x181ABE7D0
	public int AddMapsFromXml(ControllerType controllerType, int controllerId, List<string> xmlStrings) { }

	// RVA: -1 Offset: -1
	public bool AddMapFromJson<T>(int controllerId, string jsonString) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACEDE0 Offset: 0xACDFE0 VA: 0x180ACEDE0
	|-Player.ControllerHelper.MapHelper.AddMapFromJson<object>
	*/

	// RVA: 0x1ABE160 Offset: 0x1ABD360 VA: 0x181ABE160
	public bool AddMapFromJson(ControllerType controllerType, int controllerId, string jsonString) { }

	// RVA: -1 Offset: -1
	public int AddMapsFromJson<T>(int controllerId, List<string> jsonStrings) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACF140 Offset: 0xACE340 VA: 0x180ACF140
	|-Player.ControllerHelper.MapHelper.AddMapsFromJson<object>
	*/

	// RVA: 0x1ABE600 Offset: 0x1ABD800 VA: 0x181ABE600
	public int AddMapsFromJson(ControllerType controllerType, int controllerId, List<string> jsonStrings) { }

	// RVA: -1 Offset: -1
	public void AddEmptyMap<T>(int controllerId, int categoryId, int layoutId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACED00 Offset: 0xACDF00 VA: 0x180ACED00
	|-Player.ControllerHelper.MapHelper.AddEmptyMap<object>
	*/

	// RVA: -1 Offset: -1
	public void AddEmptyMap<T>(int controllerId, string categoryName, string layoutName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACEC10 Offset: 0xACDE10 VA: 0x180ACEC10
	|-Player.ControllerHelper.MapHelper.AddEmptyMap<object>
	*/

	// RVA: 0x1ABE090 Offset: 0x1ABD290 VA: 0x181ABE090
	public void AddEmptyMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId) { }

	// RVA: 0x1ABDEF0 Offset: 0x1ABD0F0 VA: 0x181ABDEF0
	public void AddEmptyMap(ControllerType controllerType, int controllerId, string categoryName, string layoutName) { }

	// RVA: -1 Offset: -1
	public void RemoveMap<T>(int controllerId, int mapId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD2820 Offset: 0xAD1A20 VA: 0x180AD2820
	|-Player.ControllerHelper.MapHelper.RemoveMap<object>
	*/

	// RVA: -1 Offset: -1
	public void RemoveMap<T>(int controllerId, int categoryId, int layoutId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD2640 Offset: 0xAD1840 VA: 0x180AD2640
	|-Player.ControllerHelper.MapHelper.RemoveMap<object>
	*/

	// RVA: -1 Offset: -1
	public void RemoveMap<T>(int controllerId, string categoryName, string layoutName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD2730 Offset: 0xAD1930 VA: 0x180AD2730
	|-Player.ControllerHelper.MapHelper.RemoveMap<object>
	*/

	// RVA: 0x1ACC330 Offset: 0x1ACB530 VA: 0x181ACC330
	public void RemoveMap(ControllerType controllerType, int controllerId, int mapId) { }

	// RVA: 0x1ACC3F0 Offset: 0x1ACB5F0 VA: 0x181ACC3F0
	public void RemoveMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId) { }

	// RVA: 0x1ACC260 Offset: 0x1ACB460 VA: 0x181ACC260
	public void RemoveMap(ControllerType controllerType, int controllerId, string categoryName, string layoutName) { }

	// RVA: -1 Offset: -1
	public void ClearMaps<T>(bool userAssignableOnly) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD02A0 Offset: 0xACF4A0 VA: 0x180AD02A0
	|-Player.ControllerHelper.MapHelper.ClearMaps<object>
	*/

	// RVA: 0x1AC1520 Offset: 0x1AC0720 VA: 0x181AC1520
	public void ClearMaps(ControllerType controllerType, bool userAssignableOnly) { }

	// RVA: -1 Offset: -1
	public void ClearMapsInCategory<T>(int categoryId, bool userAssignableOnly) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACFB00 Offset: 0xACED00 VA: 0x180ACFB00
	|-Player.ControllerHelper.MapHelper.ClearMapsInCategory<object>
	*/

	// RVA: -1 Offset: -1
	public void ClearMapsInCategory<T>(string categoryName, bool userAssignableOnly) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACFBD0 Offset: 0xACEDD0 VA: 0x180ACFBD0
	|-Player.ControllerHelper.MapHelper.ClearMapsInCategory<object>
	*/

	// RVA: -1 Offset: -1
	public void ClearMapsInCategory<T>(int categoryId, int layoutId, bool userAssignableOnly) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACFF30 Offset: 0xACF130 VA: 0x180ACFF30
	|-Player.ControllerHelper.MapHelper.ClearMapsInCategory<object>
	*/

	// RVA: -1 Offset: -1
	public void ClearMapsInCategory<T>(string categoryName, string layoutName, bool userAssignableOnly) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACFD40 Offset: 0xACEF40 VA: 0x180ACFD40
	|-Player.ControllerHelper.MapHelper.ClearMapsInCategory<object>
	*/

	// RVA: 0x1AC0660 Offset: 0x1ABF860 VA: 0x181AC0660
	public void ClearMapsInCategory(int categoryId, bool userAssignableOnly) { }

	// RVA: 0x1AC0570 Offset: 0x1ABF770 VA: 0x181AC0570
	public void ClearMapsInCategory(string categoryName, bool userAssignableOnly) { }

	// RVA: 0x1AC0870 Offset: 0x1ABFA70 VA: 0x181AC0870
	public void ClearMapsInCategory(ControllerType controllerType, int categoryId, bool userAssignableOnly) { }

	// RVA: 0x1AC0470 Offset: 0x1ABF670 VA: 0x181AC0470
	public void ClearMapsInCategory(ControllerType controllerType, string categoryName, bool userAssignableOnly) { }

	// RVA: 0x1AC0BD0 Offset: 0x1ABFDD0 VA: 0x181AC0BD0
	public void ClearMapsInCategory(ControllerType controllerType, int categoryId, int layoutId, bool userAssignableOnly) { }

	// RVA: 0x1AC0F80 Offset: 0x1AC0180 VA: 0x181AC0F80
	public void ClearMapsInCategory(ControllerType controllerType, string categoryName, string layoutName, bool userAssignableOnly) { }

	// RVA: -1 Offset: -1
	public void ClearMapsInLayout<T>(int layoutId, bool userAssignableOnly) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD0020 Offset: 0xACF220 VA: 0x180AD0020
	|-Player.ControllerHelper.MapHelper.ClearMapsInLayout<object>
	*/

	// RVA: -1 Offset: -1
	public void ClearMapsInLayout<T>(string layoutName, bool userAssignableOnly) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD00F0 Offset: 0xACF2F0 VA: 0x180AD00F0
	|-Player.ControllerHelper.MapHelper.ClearMapsInLayout<object>
	*/

	// RVA: 0x1AC10C0 Offset: 0x1AC02C0 VA: 0x181AC10C0
	public void ClearMapsInLayout(ControllerType controllerType, int layoutId, bool userAssignableOnly) { }

	// RVA: 0x1AC1420 Offset: 0x1AC0620 VA: 0x181AC1420
	public void ClearMapsInLayout(ControllerType controllerType, string layoutName, bool userAssignableOnly) { }

	// RVA: -1 Offset: -1
	public void ClearMapsForController<T>(int controllerId, bool userAssignableOnly) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACF940 Offset: 0xACEB40 VA: 0x180ACF940
	|-Player.ControllerHelper.MapHelper.ClearMapsForController<object>
	*/

	// RVA: -1 Offset: -1
	public void ClearMapsForController<T>(int controllerId, int categoryId, bool userAssignableOnly) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACFA10 Offset: 0xACEC10 VA: 0x180ACFA10
	|-Player.ControllerHelper.MapHelper.ClearMapsForController<object>
	*/

	// RVA: -1 Offset: -1
	public void ClearMapsForController<T>(int controllerId, string categoryName, bool userAssignableOnly) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACF7C0 Offset: 0xACE9C0 VA: 0x180ACF7C0
	|-Player.ControllerHelper.MapHelper.ClearMapsForController<object>
	*/

	// RVA: 0x1ABFF90 Offset: 0x1ABF190 VA: 0x181ABFF90
	public void ClearMapsForController(ControllerType controllerType, int controllerId, bool userAssignableOnly) { }

	// RVA: 0x1AC00F0 Offset: 0x1ABF2F0 VA: 0x181AC00F0
	public void ClearMapsForController(ControllerType controllerType, int controllerId, int categoryId, bool userAssignableOnly) { }

	// RVA: 0x1AC0260 Offset: 0x1ABF460 VA: 0x181AC0260
	public void ClearMapsForController(ControllerType controllerType, int controllerId, string categoryName, bool userAssignableOnly) { }

	// RVA: -1 Offset: -1
	public void ClearMapsForControllerInLayout<T>(int controllerId, int layoutId, bool userAssignableOnly) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACF6D0 Offset: 0xACE8D0 VA: 0x180ACF6D0
	|-Player.ControllerHelper.MapHelper.ClearMapsForControllerInLayout<object>
	*/

	// RVA: -1 Offset: -1
	public void ClearMapsForControllerInLayout<T>(int controllerId, string layoutName, bool userAssignableOnly) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACF520 Offset: 0xACE720 VA: 0x180ACF520
	|-Player.ControllerHelper.MapHelper.ClearMapsForControllerInLayout<object>
	*/

	// RVA: 0x1ABFC10 Offset: 0x1ABEE10 VA: 0x181ABFC10
	public void ClearMapsForControllerInLayout(ControllerType controllerType, int controllerId, int layoutId, bool userAssignableOnly) { }

	// RVA: 0x1ABFD80 Offset: 0x1ABEF80 VA: 0x181ABFD80
	public void ClearMapsForControllerInLayout(ControllerType controllerType, int controllerId, string layoutName, bool userAssignableOnly) { }

	// RVA: 0x1ABFAE0 Offset: 0x1ABECE0 VA: 0x181ABFAE0
	public void ClearAllMaps(bool userAssignableOnly) { }

	// RVA: 0x1AC6F40 Offset: 0x1AC6140 VA: 0x181AC6F40
	public ActionElementMap GetFirstButtonMapWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1AC75C0 Offset: 0x1AC67C0 VA: 0x181AC75C0
	public ActionElementMap GetFirstButtonMapWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1AC7160 Offset: 0x1AC6360 VA: 0x181AC7160
	public ActionElementMap GetFirstButtonMapWithAction(Controller controller, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1AC6E40 Offset: 0x1AC6040 VA: 0x181AC6E40
	public ActionElementMap GetFirstButtonMapWithAction(Controller controller, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1AC6D80 Offset: 0x1AC5F80 VA: 0x181AC6D80
	public ActionElementMap GetFirstButtonMapWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1AC7460 Offset: 0x1AC6660 VA: 0x181AC7460
	public ActionElementMap GetFirstButtonMapWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1AC6FF0 Offset: 0x1AC61F0 VA: 0x181AC6FF0
	public ActionElementMap GetFirstButtonMapWithAction(int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1AC7240 Offset: 0x1AC6440 VA: 0x181AC7240
	public ActionElementMap GetFirstButtonMapWithAction(string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1ABF5D0 Offset: 0x1ABE7D0 VA: 0x181ABF5D0
	public IEnumerable<ActionElementMap> ButtonMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1ABF680 Offset: 0x1ABE880 VA: 0x181ABF680
	public IEnumerable<ActionElementMap> ButtonMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1ABF4E0 Offset: 0x1ABE6E0 VA: 0x181ABF4E0
	public IEnumerable<ActionElementMap> ButtonMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1ABF320 Offset: 0x1ABE520 VA: 0x181ABF320
	public IEnumerable<ActionElementMap> ButtonMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1ABF240 Offset: 0x1ABE440 VA: 0x181ABF240
	public IEnumerable<ActionElementMap> ButtonMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1ABF7F0 Offset: 0x1ABE9F0 VA: 0x181ABF7F0
	public IEnumerable<ActionElementMap> ButtonMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1ABF440 Offset: 0x1ABE640 VA: 0x181ABF440
	public IEnumerable<ActionElementMap> ButtonMapsWithAction(int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1ABF970 Offset: 0x1ABEB70 VA: 0x181ABF970
	public IEnumerable<ActionElementMap> ButtonMapsWithAction(string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1AC5080 Offset: 0x1AC4280 VA: 0x181AC5080
	public int GetButtonMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC4FD0 Offset: 0x1AC41D0 VA: 0x181AC4FD0
	public int GetButtonMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC4E60 Offset: 0x1AC4060 VA: 0x181AC4E60
	public int GetButtonMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC54E0 Offset: 0x1AC46E0 VA: 0x181AC54E0
	public int GetButtonMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC4D90 Offset: 0x1AC3F90 VA: 0x181AC4D90
	public int GetButtonMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC5360 Offset: 0x1AC4560 VA: 0x181AC5360
	public int GetButtonMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC4D70 Offset: 0x1AC3F70 VA: 0x181AC4D70
	public int GetButtonMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC5250 Offset: 0x1AC4450 VA: 0x181AC5250
	public int GetButtonMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC6540 Offset: 0x1AC5740 VA: 0x181AC6540
	public ActionElementMap GetFirstAxisMapWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1AC63E0 Offset: 0x1AC55E0 VA: 0x181AC63E0
	public ActionElementMap GetFirstAxisMapWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1AC66B0 Offset: 0x1AC58B0 VA: 0x181AC66B0
	public ActionElementMap GetFirstAxisMapWithAction(Controller controller, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1AC6C80 Offset: 0x1AC5E80 VA: 0x181AC6C80
	public ActionElementMap GetFirstAxisMapWithAction(Controller controller, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1AC65F0 Offset: 0x1AC57F0 VA: 0x181AC65F0
	public ActionElementMap GetFirstAxisMapWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1AC69B0 Offset: 0x1AC5BB0 VA: 0x181AC69B0
	public ActionElementMap GetFirstAxisMapWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1AC6B10 Offset: 0x1AC5D10 VA: 0x181AC6B10
	public ActionElementMap GetFirstAxisMapWithAction(int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1AC6790 Offset: 0x1AC5990 VA: 0x181AC6790
	public ActionElementMap GetFirstAxisMapWithAction(string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1ABED80 Offset: 0x1ABDF80 VA: 0x181ABED80
	public IEnumerable<ActionElementMap> AxisMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1ABEE30 Offset: 0x1ABE030 VA: 0x181ABEE30
	public IEnumerable<ActionElementMap> AxisMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1ABEB20 Offset: 0x1ABDD20 VA: 0x181ABEB20
	public IEnumerable<ActionElementMap> AxisMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1ABF080 Offset: 0x1ABE280 VA: 0x181ABF080
	public IEnumerable<ActionElementMap> AxisMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1ABEFA0 Offset: 0x1ABE1A0 VA: 0x181ABEFA0
	public IEnumerable<ActionElementMap> AxisMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1ABE9A0 Offset: 0x1ABDBA0 VA: 0x181ABE9A0
	public IEnumerable<ActionElementMap> AxisMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1ABF1A0 Offset: 0x1ABE3A0 VA: 0x181ABF1A0
	public IEnumerable<ActionElementMap> AxisMapsWithAction(int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1ABEC10 Offset: 0x1ABDE10 VA: 0x181ABEC10
	public IEnumerable<ActionElementMap> AxisMapsWithAction(string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1AC4CC0 Offset: 0x1AC3EC0 VA: 0x181AC4CC0
	public int GetAxisMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC4A30 Offset: 0x1AC3C30 VA: 0x181AC4A30
	public int GetAxisMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC4770 Offset: 0x1AC3970 VA: 0x181AC4770
	public int GetAxisMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC4660 Offset: 0x1AC3860 VA: 0x181AC4660
	public int GetAxisMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC4540 Offset: 0x1AC3740 VA: 0x181AC4540
	public int GetAxisMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC4860 Offset: 0x1AC3A60 VA: 0x181AC4860
	public int GetAxisMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC4B90 Offset: 0x1AC3D90 VA: 0x181AC4B90
	public int GetAxisMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC4BB0 Offset: 0x1AC3DB0 VA: 0x181AC4BB0
	public int GetAxisMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC7F30 Offset: 0x1AC7130 VA: 0x181AC7F30
	public ActionElementMap GetFirstElementMapWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1AC7C10 Offset: 0x1AC6E10 VA: 0x181AC7C10
	public ActionElementMap GetFirstElementMapWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1AC7FE0 Offset: 0x1AC71E0 VA: 0x181AC7FE0
	public ActionElementMap GetFirstElementMapWithAction(Controller controller, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1AC7D70 Offset: 0x1AC6F70 VA: 0x181AC7D70
	public ActionElementMap GetFirstElementMapWithAction(Controller controller, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1AC7E70 Offset: 0x1AC7070 VA: 0x181AC7E70
	public ActionElementMap GetFirstElementMapWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1AC7890 Offset: 0x1AC6A90 VA: 0x181AC7890
	public ActionElementMap GetFirstElementMapWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1AC7720 Offset: 0x1AC6920 VA: 0x181AC7720
	public ActionElementMap GetFirstElementMapWithAction(int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1AC79F0 Offset: 0x1AC6BF0 VA: 0x181AC79F0
	public ActionElementMap GetFirstElementMapWithAction(string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1AC26E0 Offset: 0x1AC18E0 VA: 0x181AC26E0
	public IEnumerable<ActionElementMap> ElementMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1AC2090 Offset: 0x1AC1290 VA: 0x181AC2090
	public IEnumerable<ActionElementMap> ElementMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1AC2320 Offset: 0x1AC1520 VA: 0x181AC2320
	public IEnumerable<ActionElementMap> ElementMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1AC2200 Offset: 0x1AC1400 VA: 0x181AC2200
	public IEnumerable<ActionElementMap> ElementMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1AC24A0 Offset: 0x1AC16A0 VA: 0x181AC24A0
	public IEnumerable<ActionElementMap> ElementMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1AC1F10 Offset: 0x1AC1110 VA: 0x181AC1F10
	public IEnumerable<ActionElementMap> ElementMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1AC2410 Offset: 0x1AC1610 VA: 0x181AC2410
	public IEnumerable<ActionElementMap> ElementMapsWithAction(int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1AC2580 Offset: 0x1AC1780 VA: 0x181AC2580
	public IEnumerable<ActionElementMap> ElementMapsWithAction(string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1AC5DD0 Offset: 0x1AC4FD0 VA: 0x181AC5DD0
	public int GetElementMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC5C70 Offset: 0x1AC4E70 VA: 0x181AC5C70
	public int GetElementMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC5710 Offset: 0x1AC4910 VA: 0x181AC5710
	public int GetElementMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC5800 Offset: 0x1AC4A00 VA: 0x181AC5800
	public int GetElementMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC5A90 Offset: 0x1AC4C90 VA: 0x181AC5A90
	public int GetElementMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC5910 Offset: 0x1AC4B10 VA: 0x181AC5910
	public int GetElementMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC5E80 Offset: 0x1AC5080 VA: 0x181AC5E80
	public int GetElementMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC5B60 Offset: 0x1AC4D60 VA: 0x181AC5B60
	public int GetElementMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC2990 Offset: 0x1AC1B90 VA: 0x181AC2990
	public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps) { }

	// RVA: 0x1AC2C80 Offset: 0x1AC1E80 VA: 0x181AC2C80
	public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps) { }

	// RVA: 0x1AC2880 Offset: 0x1AC1A80 VA: 0x181AC2880
	public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1AC2AA0 Offset: 0x1AC1CA0 VA: 0x181AC2AA0
	public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1AC2790 Offset: 0x1AC1990 VA: 0x181AC2790
	public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1AC27C0 Offset: 0x1AC19C0 VA: 0x181AC27C0
	public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1AC81B0 Offset: 0x1AC73B0 VA: 0x181AC81B0
	public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps) { }

	// RVA: 0x1AC83B0 Offset: 0x1AC75B0 VA: 0x181AC83B0
	public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps) { }

	// RVA: 0x1AC80C0 Offset: 0x1AC72C0 VA: 0x181AC80C0
	public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1AC83E0 Offset: 0x1AC75E0 VA: 0x181AC83E0
	public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1AC8590 Offset: 0x1AC7790 VA: 0x181AC8590
	public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps) { }

	// RVA: 0x1AC82A0 Offset: 0x1AC74A0 VA: 0x181AC82A0
	public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps) { }

	// RVA: 0x1AC5ED0 Offset: 0x1AC50D0 VA: 0x181AC5ED0
	public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC5EA0 Offset: 0x1AC50A0 VA: 0x181AC5EA0
	public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC5FD0 Offset: 0x1AC51D0 VA: 0x181AC5FD0
	public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC6220 Offset: 0x1AC5420 VA: 0x181AC6220
	public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC61E0 Offset: 0x1AC53E0 VA: 0x181AC61E0
	public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: 0x1AC60D0 Offset: 0x1AC52D0 VA: 0x181AC60D0
	public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps, List<ActionElementMap> results) { }

	// RVA: -1 Offset: -1
	public T[] GetMapSaveData<T>(int controllerId, bool userAssignableMapsOnly) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD1490 Offset: 0xAD0690 VA: 0x180AD1490
	|-Player.ControllerHelper.MapHelper.GetMapSaveData<object>
	*/

	// RVA: 0x1AC8B60 Offset: 0x1AC7D60 VA: 0x181AC8B60
	public ControllerMapSaveData[] GetMapSaveData(ControllerType controllerType, int controllerId, bool userAssignableMapsOnly) { }

	// RVA: -1 Offset: -1
	public T[] GetAllMapSaveData<T>(bool userAssignableMapsOnly) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD0370 Offset: 0xACF570 VA: 0x180AD0370
	|-Player.ControllerHelper.MapHelper.GetAllMapSaveData<object>
	*/

	// RVA: 0x1AC2F00 Offset: 0x1AC2100 VA: 0x181AC2F00
	public ControllerMapSaveData[] GetAllMapSaveData(ControllerType controllerType, bool userAssignableMapsOnly) { }

	// RVA: 0x1AC2FD0 Offset: 0x1AC21D0 VA: 0x181AC2FD0
	public ControllerMapSaveData[] GetAllMapSaveData(bool userAssignableMapsOnly) { }

	// RVA: 0x1ACC9D0 Offset: 0x1ACBBD0 VA: 0x181ACC9D0
	public int SetAllMapsEnabled(bool state) { }

	// RVA: 0x1ACCBE0 Offset: 0x1ACBDE0 VA: 0x181ACCBE0
	public int SetAllMapsEnabled(bool state, ControllerType controllerType) { }

	// RVA: 0x1ACD030 Offset: 0x1ACC230 VA: 0x181ACD030
	public int SetAllMapsEnabled(bool state, Controller controller) { }

	// RVA: 0x1ACCEF0 Offset: 0x1ACC0F0 VA: 0x181ACCEF0
	public int SetAllMapsEnabled(bool state, ControllerType controllerType, int controllerId) { }

	// RVA: 0x1ACDFC0 Offset: 0x1ACD1C0 VA: 0x181ACDFC0
	public int SetMapsEnabled(bool state, int categoryId) { }

	// RVA: 0x1ACDDD0 Offset: 0x1ACCFD0 VA: 0x181ACDDD0
	public int SetMapsEnabled(bool state, string categoryName) { }

	// RVA: 0x1ACD8C0 Offset: 0x1ACCAC0 VA: 0x181ACD8C0
	public int SetMapsEnabled(bool state, string categoryName, string layoutName) { }

	// RVA: 0x1ACDAC0 Offset: 0x1ACCCC0 VA: 0x181ACDAC0
	public int SetMapsEnabled(bool state, ControllerType controllerType, int categoryId) { }

	// RVA: 0x1ACDEC0 Offset: 0x1ACD0C0 VA: 0x181ACDEC0
	public int SetMapsEnabled(bool state, ControllerType controllerType, string categoryName) { }

	// RVA: 0x1ACE1F0 Offset: 0x1ACD3F0 VA: 0x181ACE1F0
	public int SetMapsEnabled(bool state, ControllerType controllerType, int categoryId, int layoutId) { }

	// RVA: 0x1ACD210 Offset: 0x1ACC410 VA: 0x181ACD210
	public int SetMapsEnabled(bool state, ControllerType controllerType, string categoryName, string layoutName) { }

	// RVA: 0x1ACD750 Offset: 0x1ACC950 VA: 0x181ACD750
	public int SetMapsEnabled(bool state, Controller controller, int categoryId) { }

	// RVA: 0x1ACD5C0 Offset: 0x1ACC7C0 VA: 0x181ACD5C0
	public int SetMapsEnabled(bool state, Controller controller, int categoryId, int layoutId) { }

	// RVA: 0x1ACE530 Offset: 0x1ACD730 VA: 0x181ACE530
	public int SetMapsEnabled(bool state, Controller controller, string categoryName) { }

	// RVA: 0x1ACD350 Offset: 0x1ACC550 VA: 0x181ACD350
	public int SetMapsEnabled(bool state, Controller controller, string categoryName, string layoutName) { }

	// RVA: 0x1ACA9A0 Offset: 0x1AC9BA0 VA: 0x181ACA9A0
	public void LoadDefaultMaps(ControllerType controllerType) { }

	// RVA: 0x1AC1D20 Offset: 0x1AC0F20 VA: 0x181AC1D20
	public bool ContainsMapInCategory(InputMapCategory category) { }

	// RVA: 0x1AC1880 Offset: 0x1AC0A80 VA: 0x181AC1880
	public bool ContainsMapInCategory(int categoryId) { }

	// RVA: 0x1AC1C40 Offset: 0x1AC0E40 VA: 0x181AC1C40
	public bool ContainsMapInCategory(string categoryName) { }

	// RVA: 0x1AC1AA0 Offset: 0x1AC0CA0 VA: 0x181AC1AA0
	public bool ContainsMapInCategory(ControllerType controllerType, int categoryId) { }

	// RVA: 0x1AD08B0 Offset: 0x1ACFAB0 VA: 0x181AD08B0
	public IList<InputBehavior> get_InputBehaviors() { }

	// RVA: 0x1AC8AA0 Offset: 0x1AC7CA0 VA: 0x181AC8AA0
	public InputBehavior GetInputBehavior(int behaviorId) { }

	// RVA: 0x1AC89E0 Offset: 0x1AC7BE0 VA: 0x181AC89E0
	public InputBehavior GetInputBehavior(string behaviorName) { }

	// RVA: 0x1ACED80 Offset: 0x1ACDF80 VA: 0x181ACED80
	internal void ZFUcTEcndvHgBpdTmEAgSebxfOsJ() { }

	// RVA: 0x1AD2950 Offset: 0x1AD1B50 VA: 0x181AD2950
	internal void qjXsKuvIqzmXACbkulNYAlMhOquB(bool ) { }

	// RVA: 0x1ACC510 Offset: 0x1ACB710 VA: 0x181ACC510
	internal void STqxQYuJDXSjMDFNQzesuEsMdjYJA(bool ) { }

	// RVA: 0x1ACB7A0 Offset: 0x1ACA9A0 VA: 0x181ACB7A0
	internal void NmbJAGrjqVbSWzTXWxmcfPDwVebg(bool ) { }

	// RVA: 0x1AD1CE0 Offset: 0x1AD0EE0 VA: 0x181AD1CE0
	internal void kNzwOmdqzfmgXhKvrDjyaLlfCQTD(bool ) { }

	// RVA: -1 Offset: -1
	private Player.ControllerHelper.vUluXsRssqqTHGOorDrBIndPAadW oCxalWVCMusGYSHIBFSmIJXwqpajA<>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD30B0 Offset: 0xAD22B0 VA: 0x180AD30B0
	|-Player.ControllerHelper.MapHelper.oCxalWVCMusGYSHIBFSmIJXwqpajA<object>
	*/

	// RVA: 0x1AC2CB0 Offset: 0x1AC1EB0 VA: 0x181AC2CB0
	internal VOLZYtSxBAfSvCRXgiPmhhdoQwVG<JoystickMap> FjnYHlTyfAHYyVXniabHLEiKbvJk(Joystick , bool ) { }

	// RVA: 0x1ACFB40 Offset: 0x1ACED40 VA: 0x181ACFB40
	private void dYofnAoNJkhnEHPwlSyMEJlaWlez(Joystick , VOLZYtSxBAfSvCRXgiPmhhdoQwVG<JoystickMap> , EOUWaxCVQTNDomlxVsogCIpJuUVB , bool ) { }

	// RVA: 0x1ACE730 Offset: 0x1ACD930 VA: 0x181ACE730
	internal VOLZYtSxBAfSvCRXgiPmhhdoQwVG<CustomControllerMap> UtmJxidjxqsUNhObMcrgqaHkFtnfA(CustomController , bool ) { }

	// RVA: 0x1AD0780 Offset: 0x1ACF980 VA: 0x181AD0780
	private void fuJbBceTtKCNXEQgexIwqIFbDrMoB(CustomController , VOLZYtSxBAfSvCRXgiPmhhdoQwVG<CustomControllerMap> , EOUWaxCVQTNDomlxVsogCIpJuUVB , bool ) { }

	// RVA: 0x1ACC4C0 Offset: 0x1ACB6C0 VA: 0x181ACC4C0
	internal void RgMjfbfnjUjIYdchKvQkeErKkjAnA(Controller , ControllerMap ) { }

	// RVA: -1 Offset: -1
	private IList<> jamCGAIxnWdjVFuhwtmbhAaPsVwb<>(int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD2F90 Offset: 0xAD2190 VA: 0x180AD2F90
	|-Player.ControllerHelper.MapHelper.jamCGAIxnWdjVFuhwtmbhAaPsVwb<object>
	*/

	// RVA: -1 Offset: -1
	private IList<> jamCGAIxnWdjVFuhwtmbhAaPsVwb<>(Controller ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD2E30 Offset: 0xAD2030 VA: 0x180AD2E30
	|-Player.ControllerHelper.MapHelper.jamCGAIxnWdjVFuhwtmbhAaPsVwb<object>
	*/

	// RVA: 0x1AD1B80 Offset: 0x1AD0D80 VA: 0x181AD1B80
	private IList<ControllerMap> jamCGAIxnWdjVFuhwtmbhAaPsVwb(ControllerType , int ) { }

	// RVA: 0x1AD1CA0 Offset: 0x1AD0EA0 VA: 0x181AD1CA0
	private IList<ControllerMap> jamCGAIxnWdjVFuhwtmbhAaPsVwb(Controller ) { }

	// RVA: 0x1AD3B70 Offset: 0x1AD2D70 VA: 0x181AD3B70
	private void ttghiiYhzQJsKQlriYxNlfzotrMq(ControllerType , int , int , int ) { }

	// RVA: 0x1AD37E0 Offset: 0x1AD29E0 VA: 0x181AD37E0
	private void ttghiiYhzQJsKQlriYxNlfzotrMq(Controller , int , int ) { }

	// RVA: 0x1AD38C0 Offset: 0x1AD2AC0 VA: 0x181AD38C0
	private void ttghiiYhzQJsKQlriYxNlfzotrMq(ControllerType , int , string , string ) { }

	// RVA: 0x1AD3850 Offset: 0x1AD2A50 VA: 0x181AD3850
	private void ttghiiYhzQJsKQlriYxNlfzotrMq(Controller , string , string ) { }

	// RVA: 0x1AD39D0 Offset: 0x1AD2BD0 VA: 0x181AD39D0
	private void ttghiiYhzQJsKQlriYxNlfzotrMq(ControllerType , int , int , int , BoolOption ) { }

	// RVA: 0x1AD3760 Offset: 0x1AD2960 VA: 0x181AD3760
	private void ttghiiYhzQJsKQlriYxNlfzotrMq(Controller , int , int , BoolOption ) { }

	// RVA: 0x1AD38F0 Offset: 0x1AD2AF0 VA: 0x181AD38F0
	private void ttghiiYhzQJsKQlriYxNlfzotrMq(ControllerType , int , string , string , BoolOption ) { }

	// RVA: 0x1AD36E0 Offset: 0x1AD28E0 VA: 0x181AD36E0
	private void ttghiiYhzQJsKQlriYxNlfzotrMq(Controller , string , string , BoolOption ) { }

	// RVA: 0x1ACF520 Offset: 0x1ACE720 VA: 0x181ACF520
	private void cDIcdPgumwoITAHmdydkfuSziNafA(Controller , ControllerMap , BoolOption ) { }

	// RVA: 0x1ACF700 Offset: 0x1ACE900 VA: 0x181ACF700
	private void cDIcdPgumwoITAHmdydkfuSziNafA(ControllerType , int , ControllerMap , BoolOption ) { }

	// RVA: 0x1AD0650 Offset: 0x1ACF850 VA: 0x181AD0650
	private bool fJdGlJwVnjraNJWGQBzEGUNSjoso(ControllerType , int , string ) { }

	// RVA: 0x1ACABC0 Offset: 0x1AC9DC0 VA: 0x181ACABC0
	private int LvXNhUZxtXfRILaYOuvkrVGNVSBI(ControllerType , int , List<string> ) { }

	// RVA: 0x1AD3270 Offset: 0x1AD2470 VA: 0x181AD3270
	private bool qwVFgECKOjJQzomgiLSyXBQiEkJib(ControllerType , int , string ) { }

	// RVA: 0x1AC1DD0 Offset: 0x1AC0FD0 VA: 0x181AC1DD0
	private int DyrClyzoTwYtBfHcFOLokdvgeZGH(ControllerType , int , List<string> ) { }

	// RVA: 0x1ACEF80 Offset: 0x1ACE180 VA: 0x181ACEF80
	private void ZVdbOahhsDMgYpgqTQiwKdhUPlmKA(ControllerType , int , int , int ) { }

	// RVA: 0x1ACF0A0 Offset: 0x1ACE2A0 VA: 0x181ACF0A0
	private void ZVdbOahhsDMgYpgqTQiwKdhUPlmKA(Controller , int , int ) { }

	// RVA: 0x1ACEDC0 Offset: 0x1ACDFC0 VA: 0x181ACEDC0
	private void ZVdbOahhsDMgYpgqTQiwKdhUPlmKA(ControllerType , int , string , string ) { }

	// RVA: 0x1ACEE90 Offset: 0x1ACE090 VA: 0x181ACEE90
	private void ZVdbOahhsDMgYpgqTQiwKdhUPlmKA(Controller , string , string ) { }

	// RVA: 0x1AD0EB0 Offset: 0x1AD00B0 VA: 0x181AD0EB0
	private void hyOzgkpvDPMWdfxAchEFtFeKeBeC(ControllerType , int , int ) { }

	// RVA: 0x1AD1310 Offset: 0x1AD0510 VA: 0x181AD1310
	private void hyOzgkpvDPMWdfxAchEFtFeKeBeC(Controller , int ) { }

	// RVA: 0x1AD1020 Offset: 0x1AD0220 VA: 0x181AD1020
	private void hyOzgkpvDPMWdfxAchEFtFeKeBeC(ControllerType , int , ControllerMap ) { }

	// RVA: 0x1AD1370 Offset: 0x1AD0570 VA: 0x181AD1370
	private void hyOzgkpvDPMWdfxAchEFtFeKeBeC(Controller , ControllerMap ) { }

	// RVA: 0x1AD1200 Offset: 0x1AD0400 VA: 0x181AD1200
	private void hyOzgkpvDPMWdfxAchEFtFeKeBeC(ControllerType , int , int , int ) { }

	// RVA: 0x1AD0E40 Offset: 0x1AD0040 VA: 0x181AD0E40
	private void hyOzgkpvDPMWdfxAchEFtFeKeBeC(Controller , int , int ) { }

	// RVA: 0x1AD0CC0 Offset: 0x1ACFEC0 VA: 0x181AD0CC0
	private void hyOzgkpvDPMWdfxAchEFtFeKeBeC(ControllerType , int , string , string ) { }

	// RVA: 0x1AD1190 Offset: 0x1AD0390 VA: 0x181AD1190
	private void hyOzgkpvDPMWdfxAchEFtFeKeBeC(Controller , string , string ) { }

	// RVA: 0x1AD3100 Offset: 0x1AD2300 VA: 0x181AD3100
	private ControllerMap qjhLdkKVQsWISLheOuRhCaGLgGNK(ControllerType , int , int ) { }

	// RVA: 0x1AD2F20 Offset: 0x1AD2120 VA: 0x181AD2F20
	private ControllerMap qjhLdkKVQsWISLheOuRhCaGLgGNK(Controller , int ) { }

	// RVA: 0x1AD2F80 Offset: 0x1AD2180 VA: 0x181AD2F80
	private ControllerMap qjhLdkKVQsWISLheOuRhCaGLgGNK(ControllerType , int , int , int ) { }

	// RVA: 0x1AD2DE0 Offset: 0x1AD1FE0 VA: 0x181AD2DE0
	private ControllerMap qjhLdkKVQsWISLheOuRhCaGLgGNK(Controller , int , int ) { }

	// RVA: 0x1AD2E50 Offset: 0x1AD2050 VA: 0x181AD2E50
	private ControllerMap qjhLdkKVQsWISLheOuRhCaGLgGNK(ControllerType , int , string , string ) { }

	// RVA: 0x1AD3200 Offset: 0x1AD2400 VA: 0x181AD3200
	private ControllerMap qjhLdkKVQsWISLheOuRhCaGLgGNK(Controller , string , string ) { }

	// RVA: 0x1AD35E0 Offset: 0x1AD27E0 VA: 0x181AD35E0
	private ControllerMap tfGimNoQDbSaMXQphnTZyVeIMBUj(ControllerType , int , int ) { }

	// RVA: 0x1AD3580 Offset: 0x1AD2780 VA: 0x181AD3580
	private ControllerMap tfGimNoQDbSaMXQphnTZyVeIMBUj(Controller , int ) { }

	// RVA: 0x1AD34A0 Offset: 0x1AD26A0 VA: 0x181AD34A0
	private ControllerMap tfGimNoQDbSaMXQphnTZyVeIMBUj(ControllerType , int , string ) { }

	// RVA: 0x1AD33A0 Offset: 0x1AD25A0 VA: 0x181AD33A0
	private ControllerMap tfGimNoQDbSaMXQphnTZyVeIMBUj(Controller , string ) { }

	// RVA: 0x1ACA420 Offset: 0x1AC9620 VA: 0x181ACA420
	private ControllerMap[] LlqTCNMQdNugdkxooBkCJEKfELZq(ControllerType ) { }

	// RVA: 0x1ACE980 Offset: 0x1ACDB80 VA: 0x181ACE980
	private ControllerMapSaveData[] XhKDbgxXWpcYaCxfwbLiulfnSbLBb(ControllerType , int , bool ) { }

	// RVA: -1 Offset: -1
	private [] XhKDbgxXWpcYaCxfwbLiulfnSbLBb<>(int , bool ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD28F0 Offset: 0xAD1AF0 VA: 0x180AD28F0
	|-Player.ControllerHelper.MapHelper.XhKDbgxXWpcYaCxfwbLiulfnSbLBb<object>
	*/

	// RVA: 0x1ACBC60 Offset: 0x1ACAE60 VA: 0x181ACBC60
	private ControllerMapSaveData[] NuSJPqaYWvnRLJBdKRDllcQPohkm(ControllerType , bool ) { }

	// RVA: -1 Offset: -1
	private [] NuSJPqaYWvnRLJBdKRDllcQPohkm<>(bool ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD2310 Offset: 0xAD1510 VA: 0x180AD2310
	|-Player.ControllerHelper.MapHelper.NuSJPqaYWvnRLJBdKRDllcQPohkm<object>
	*/

	// RVA: 0x1ACF930 Offset: 0x1ACEB30 VA: 0x181ACF930
	private int cxPqUkPrwBLsBgUmAtRBNNSSckMW(ControllerType , int , int , List<ControllerMap> ) { }

	// RVA: 0x1ACF7B0 Offset: 0x1ACE9B0 VA: 0x181ACF7B0
	private int cxPqUkPrwBLsBgUmAtRBNNSSckMW(Controller , int , List<ControllerMap> ) { }

	// RVA: 0x1ACFA50 Offset: 0x1ACEC50 VA: 0x181ACFA50
	private int cxPqUkPrwBLsBgUmAtRBNNSSckMW(ControllerType , int , string , List<ControllerMap> ) { }

	// RVA: 0x1ACF820 Offset: 0x1ACEA20 VA: 0x181ACF820
	private int cxPqUkPrwBLsBgUmAtRBNNSSckMW(Controller , string , List<ControllerMap> ) { }

	// RVA: 0x1ACC1C0 Offset: 0x1ACB3C0 VA: 0x181ACC1C0
	private IEnumerable<ControllerMap> PHXSZskBqiofPCgnuVcCjCheXwvQ(ControllerType , int , int ) { }

	// RVA: -1 Offset: -1
	private IEnumerable<> PHXSZskBqiofPCgnuVcCjCheXwvQ<>(int , int ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAD25A0 Offset: 0xAD17A0 VA: 0x180AD25A0
	|-Player.ControllerHelper.MapHelper.PHXSZskBqiofPCgnuVcCjCheXwvQ<object>
	*/

	// RVA: 0x1AD3C60 Offset: 0x1AD2E60 VA: 0x181AD3C60
	private ActionElementMap uvDuJdPpgiRMlHJwpFzIeBxHkDHDA(ControllerType , int , bool ) { }

	// RVA: 0x1AD4080 Offset: 0x1AD3280 VA: 0x181AD4080
	private ActionElementMap uvDuJdPpgiRMlHJwpFzIeBxHkDHDA(ControllerType , string , bool ) { }

	// RVA: 0x1ACC050 Offset: 0x1ACB250 VA: 0x181ACC050
	private IEnumerable<ActionElementMap> OgDhxgFEUAcYTKrNsPMrHNSEcHnt(ControllerType , int , bool ) { }

	// RVA: 0x1ACBFA0 Offset: 0x1ACB1A0 VA: 0x181ACBFA0
	private IEnumerable<ActionElementMap> OgDhxgFEUAcYTKrNsPMrHNSEcHnt(ControllerType , string , bool ) { }

	// RVA: 0x1AD1870 Offset: 0x1AD0A70 VA: 0x181AD1870
	private ActionElementMap iAXrPeCBKpOcDdChbMzcXJqlqUlu(ControllerType , int , bool ) { }

	// RVA: 0x1AD17C0 Offset: 0x1AD09C0 VA: 0x181AD17C0
	private ActionElementMap iAXrPeCBKpOcDdChbMzcXJqlqUlu(ControllerType , string , bool ) { }

	// RVA: 0x1ACA2B0 Offset: 0x1AC94B0 VA: 0x181ACA2B0
	private IEnumerable<ActionElementMap> HCeWpEyJYDNsSPUfSJItvfToNYWQ(ControllerType , int , bool ) { }

	// RVA: 0x1ACA140 Offset: 0x1AC9340 VA: 0x181ACA140
	private IEnumerable<ActionElementMap> HCeWpEyJYDNsSPUfSJItvfToNYWQ(ControllerType , string , bool ) { }

	// RVA: 0x1AD2350 Offset: 0x1AD1550 VA: 0x181AD2350
	private ActionElementMap osfKpBmFuwIgKXpnzruJmoFJoDZE(ControllerType , int , bool ) { }

	// RVA: 0x1AD2570 Offset: 0x1AD1770 VA: 0x181AD2570
	private ActionElementMap osfKpBmFuwIgKXpnzruJmoFJoDZE(ControllerType , string , bool ) { }

	// RVA: 0x1ACB630 Offset: 0x1ACA830 VA: 0x181ACB630
	private IEnumerable<ActionElementMap> NdjFXYyVSmVroXmGcTpTlakoQQTp(ControllerType , int , bool ) { }

	// RVA: 0x1ACB4C0 Offset: 0x1ACA6C0 VA: 0x181ACB4C0
	private IEnumerable<ActionElementMap> NdjFXYyVSmVroXmGcTpTlakoQQTp(ControllerType , string , bool ) { }

	// RVA: 0x1AD2620 Offset: 0x1AD1820 VA: 0x181AD2620
	private int pLaznvplJGeCGeojOxhyOEbubmQqA(int , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1AD4130 Offset: 0x1AD3330 VA: 0x181AD4130
	private int vkGZtdKCiHYyFqJziMMFcdDDgdqL(int , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1ABDBC0 Offset: 0x1ABCDC0 VA: 0x181ABDBC0
	private int AMlBNTDDCrqwZJYbmmfQhezsErp(int , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1ACB1F0 Offset: 0x1ACA3F0 VA: 0x181ACB1F0
	private int MtYLAtEcHbnujsBLYeHJcCrWGjjY(ControllerType , int , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1ACB060 Offset: 0x1ACA260 VA: 0x181ACB060
	private int MtYLAtEcHbnujsBLYeHJcCrWGjjY(ControllerType , string , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1ACFD30 Offset: 0x1ACEF30 VA: 0x181ACFD30
	private int duAxMnhyjbvMBMzIpHvbmXGMmXfS(ControllerType , int , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1ACFC70 Offset: 0x1ACEE70 VA: 0x181ACFC70
	private int duAxMnhyjbvMBMzIpHvbmXGMmXfS(ControllerType , string , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1AD4980 Offset: 0x1AD3B80 VA: 0x181AD4980
	private int xaOOFVCnoskCXLiyozxTEZfpmMWc(ControllerType , int , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1AD48C0 Offset: 0x1AD3AC0 VA: 0x181AD48C0
	private int xaOOFVCnoskCXLiyozxTEZfpmMWc(ControllerType , string , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1AD3E70 Offset: 0x1AD3070 VA: 0x181AD3E70
	private ActionElementMap uvDuJdPpgiRMlHJwpFzIeBxHkDHDA(ControllerType , int , int , bool ) { }

	// RVA: 0x1AD3BA0 Offset: 0x1AD2DA0 VA: 0x181AD3BA0
	private ActionElementMap uvDuJdPpgiRMlHJwpFzIeBxHkDHDA(ControllerType , int , string , bool ) { }

	// RVA: 0x1ACC100 Offset: 0x1ACB300 VA: 0x181ACC100
	private IEnumerable<ActionElementMap> OgDhxgFEUAcYTKrNsPMrHNSEcHnt(ControllerType , int , int , bool ) { }

	// RVA: 0x1ACBEE0 Offset: 0x1ACB0E0 VA: 0x181ACBEE0
	private IEnumerable<ActionElementMap> OgDhxgFEUAcYTKrNsPMrHNSEcHnt(ControllerType , int , string , bool ) { }

	// RVA: 0x1AD13F0 Offset: 0x1AD05F0 VA: 0x181AD13F0
	private ActionElementMap iAXrPeCBKpOcDdChbMzcXJqlqUlu(ControllerType , int , int , bool ) { }

	// RVA: 0x1AD1700 Offset: 0x1AD0900 VA: 0x181AD1700
	private ActionElementMap iAXrPeCBKpOcDdChbMzcXJqlqUlu(ControllerType , int , string , bool ) { }

	// RVA: 0x1ACA360 Offset: 0x1AC9560 VA: 0x181ACA360
	private IEnumerable<ActionElementMap> HCeWpEyJYDNsSPUfSJItvfToNYWQ(ControllerType , int , int , bool ) { }

	// RVA: 0x1ACA1F0 Offset: 0x1AC93F0 VA: 0x181ACA1F0
	private IEnumerable<ActionElementMap> HCeWpEyJYDNsSPUfSJItvfToNYWQ(ControllerType , int , string , bool ) { }

	// RVA: 0x1AD2130 Offset: 0x1AD1330 VA: 0x181AD2130
	private ActionElementMap osfKpBmFuwIgKXpnzruJmoFJoDZE(ControllerType , int , int , bool ) { }

	// RVA: 0x1AD2070 Offset: 0x1AD1270 VA: 0x181AD2070
	private ActionElementMap osfKpBmFuwIgKXpnzruJmoFJoDZE(ControllerType , int , string , bool ) { }

	// RVA: 0x1ACB6E0 Offset: 0x1ACA8E0 VA: 0x181ACB6E0
	private IEnumerable<ActionElementMap> NdjFXYyVSmVroXmGcTpTlakoQQTp(ControllerType , int , int , bool ) { }

	// RVA: 0x1ACB570 Offset: 0x1ACA770 VA: 0x181ACB570
	private IEnumerable<ActionElementMap> NdjFXYyVSmVroXmGcTpTlakoQQTp(ControllerType , int , string , bool ) { }

	// RVA: 0x1ACAD00 Offset: 0x1AC9F00 VA: 0x181ACAD00
	private int MtYLAtEcHbnujsBLYeHJcCrWGjjY(ControllerType , int , int , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1ACB120 Offset: 0x1ACA320 VA: 0x181ACB120
	private int MtYLAtEcHbnujsBLYeHJcCrWGjjY(ControllerType , int , string , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1AD01D0 Offset: 0x1ACF3D0 VA: 0x181AD01D0
	private int duAxMnhyjbvMBMzIpHvbmXGMmXfS(ControllerType , int , int , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1AD0100 Offset: 0x1ACF300 VA: 0x181AD0100
	private int duAxMnhyjbvMBMzIpHvbmXGMmXfS(ControllerType , int , string , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1AD4590 Offset: 0x1AD3790 VA: 0x181AD4590
	private int xaOOFVCnoskCXLiyozxTEZfpmMWc(ControllerType , int , int , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1AD44C0 Offset: 0x1AD36C0 VA: 0x181AD44C0
	private int xaOOFVCnoskCXLiyozxTEZfpmMWc(ControllerType , int , string , bool , List<ActionElementMap> , bool ) { }

	// RVA: 0x1ACF290 Offset: 0x1ACE490 VA: 0x181ACF290
	private ActionElementMap aQqIXjMOflACDFsaVnsINsitGPaX(IControllerElementTarget , bool , int , bool ) { }

	// RVA: 0x1ACECD0 Offset: 0x1ACDED0 VA: 0x181ACECD0
	private IEnumerable<ActionElementMap> ZBnanVJnDlcKdYNaPqmuiFAEizMq(IControllerElementTarget , bool , int , bool ) { }

	// RVA: 0x1AD0970 Offset: 0x1ACFB70 VA: 0x181AD0970
	private int gwJUVsXssesjpCNouhFmiWIlgxts(IControllerElementTarget , bool , int , bool , List<ActionElementMap> , bool ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.PollingHelper.SKibUnkWcOjgTMdKZyjDPmdWVLUL : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7075
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	public Player.ControllerHelper.PollingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x58
	private IList<CustomController> BTSPmQwPAUfWNhicSURuOzDlkVfq; // 0x60
	private int waStlxYaXbhydsZQnHzHOBCUlvjq; // 0x68
	private int pPGgUESwNACgnGeuXdCQJJGRwcRF; // 0x6C
	private IEnumerator<ControllerPollingInfo> rmTJoSaSEOTODpMQRvnpbvynqUJX; // 0x70

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1AF2110 Offset: 0x1AF1310 VA: 0x181AF2110 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AF1C10 Offset: 0x1AF0E10 VA: 0x181AF1C10 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1AF21A0 Offset: 0x1AF13A0 VA: 0x181AF21A0
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF2060 Offset: 0x1AF1260 VA: 0x181AF2060 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1AF20A0 Offset: 0x1AF12A0 VA: 0x181AF20A0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF1FA0 Offset: 0x1AF11A0 VA: 0x181AF1FA0 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AF1FA0 Offset: 0x1AF11A0 VA: 0x181AF1FA0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.PollingHelper.yuHwkLtUkagxEkjaEuiVEOFNqhCG : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7076
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	public Player.ControllerHelper.PollingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x58
	private IList<CustomController> BTSPmQwPAUfWNhicSURuOzDlkVfq; // 0x60
	private int waStlxYaXbhydsZQnHzHOBCUlvjq; // 0x68
	private int pPGgUESwNACgnGeuXdCQJJGRwcRF; // 0x6C
	private IEnumerator<ControllerPollingInfo> rmTJoSaSEOTODpMQRvnpbvynqUJX; // 0x70

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1AF7D80 Offset: 0x1AF6F80 VA: 0x181AF7D80 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AF7870 Offset: 0x1AF6A70 VA: 0x181AF7870 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1AF7E10 Offset: 0x1AF7010 VA: 0x181AF7E10
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF7CD0 Offset: 0x1AF6ED0 VA: 0x181AF7CD0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1AF7D10 Offset: 0x1AF6F10 VA: 0x181AF7D10 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF7C10 Offset: 0x1AF6E10 VA: 0x181AF7C10 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AF7C10 Offset: 0x1AF6E10 VA: 0x181AF7C10 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.PollingHelper.nOdfqYBCsrayQlUMDaVvVZgAcMJEb : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7077
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	public Player.ControllerHelper.PollingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x58
	private IList<CustomController> BTSPmQwPAUfWNhicSURuOzDlkVfq; // 0x60
	private int waStlxYaXbhydsZQnHzHOBCUlvjq; // 0x68
	private int pPGgUESwNACgnGeuXdCQJJGRwcRF; // 0x6C
	private IEnumerator<ControllerPollingInfo> rmTJoSaSEOTODpMQRvnpbvynqUJX; // 0x70

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1AF5710 Offset: 0x1AF4910 VA: 0x181AF5710 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AF5200 Offset: 0x1AF4400 VA: 0x181AF5200 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1AF57A0 Offset: 0x1AF49A0 VA: 0x181AF57A0
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF5660 Offset: 0x1AF4860 VA: 0x181AF5660 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1AF56A0 Offset: 0x1AF48A0 VA: 0x181AF56A0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF55A0 Offset: 0x1AF47A0 VA: 0x181AF55A0 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AF55A0 Offset: 0x1AF47A0 VA: 0x181AF55A0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.PollingHelper.WnPJFwSVBsKPFJGvuWsqgbVyClcg : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7078
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	public Player.ControllerHelper.PollingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x58
	private IList<CustomController> BTSPmQwPAUfWNhicSURuOzDlkVfq; // 0x60
	private int waStlxYaXbhydsZQnHzHOBCUlvjq; // 0x68
	private int pPGgUESwNACgnGeuXdCQJJGRwcRF; // 0x6C
	private IEnumerator<ControllerPollingInfo> rmTJoSaSEOTODpMQRvnpbvynqUJX; // 0x70

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1AF38F0 Offset: 0x1AF2AF0 VA: 0x181AF38F0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AF33E0 Offset: 0x1AF25E0 VA: 0x181AF33E0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1AF3980 Offset: 0x1AF2B80 VA: 0x181AF3980
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF3840 Offset: 0x1AF2A40 VA: 0x181AF3840 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1AF3880 Offset: 0x1AF2A80 VA: 0x181AF3880 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF3780 Offset: 0x1AF2980 VA: 0x181AF3780 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AF3780 Offset: 0x1AF2980 VA: 0x181AF3780 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.PollingHelper.HZdBogdMmaLrcfqwaYoQRDiqQBFX : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7079
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	public Player.ControllerHelper.PollingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x58
	private IList<CustomController> BTSPmQwPAUfWNhicSURuOzDlkVfq; // 0x60
	private int waStlxYaXbhydsZQnHzHOBCUlvjq; // 0x68
	private int pPGgUESwNACgnGeuXdCQJJGRwcRF; // 0x6C
	private IEnumerator<ControllerPollingInfo> rmTJoSaSEOTODpMQRvnpbvynqUJX; // 0x70

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1ADEFC0 Offset: 0x1ADE1C0 VA: 0x181ADEFC0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1ADEAB0 Offset: 0x1ADDCB0 VA: 0x181ADEAB0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1ADF050 Offset: 0x1ADE250 VA: 0x181ADF050
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1ADEF10 Offset: 0x1ADE110 VA: 0x181ADEF10 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1ADEF50 Offset: 0x1ADE150 VA: 0x181ADEF50 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1ADEE50 Offset: 0x1ADE050 VA: 0x181ADEE50 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1ADEE50 Offset: 0x1ADE050 VA: 0x181ADEE50 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.PollingHelper.PgXATnZWXhuvgbuIWOySwjOJZmsd : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7080
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	public Player.ControllerHelper.PollingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x58
	private IList<Joystick> rqSMdDJGxgTyaNVDURvIlrOONYwo; // 0x60
	private int uMLHrMLoKtpVjuaOQzUZzxuMldxw; // 0x68
	private int pPGgUESwNACgnGeuXdCQJJGRwcRF; // 0x6C
	private IEnumerator<ControllerPollingInfo> rmTJoSaSEOTODpMQRvnpbvynqUJX; // 0x70

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1AE06F0 Offset: 0x1ADF8F0 VA: 0x181AE06F0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AE01F0 Offset: 0x1ADF3F0 VA: 0x181AE01F0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1AE0780 Offset: 0x1ADF980 VA: 0x181AE0780
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AE0640 Offset: 0x1ADF840 VA: 0x181AE0640 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1AE0680 Offset: 0x1ADF880 VA: 0x181AE0680 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AE0580 Offset: 0x1ADF780 VA: 0x181AE0580 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AE0580 Offset: 0x1ADF780 VA: 0x181AE0580 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.PollingHelper.pzrLEFjoGYUgQxyKUsUeufQISHLk : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7081
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	public Player.ControllerHelper.PollingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x58
	private IList<Joystick> rqSMdDJGxgTyaNVDURvIlrOONYwo; // 0x60
	private int uMLHrMLoKtpVjuaOQzUZzxuMldxw; // 0x68
	private int pPGgUESwNACgnGeuXdCQJJGRwcRF; // 0x6C
	private IEnumerator<ControllerPollingInfo> rmTJoSaSEOTODpMQRvnpbvynqUJX; // 0x70

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1AF5D00 Offset: 0x1AF4F00 VA: 0x181AF5D00 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AF57F0 Offset: 0x1AF49F0 VA: 0x181AF57F0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1AF5D90 Offset: 0x1AF4F90 VA: 0x181AF5D90
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF5C50 Offset: 0x1AF4E50 VA: 0x181AF5C50 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1AF5C90 Offset: 0x1AF4E90 VA: 0x181AF5C90 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF5B90 Offset: 0x1AF4D90 VA: 0x181AF5B90 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AF5B90 Offset: 0x1AF4D90 VA: 0x181AF5B90 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.PollingHelper.IplVFVwbCDEvLVBchkjDgWMuPSSD : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7082
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	public Player.ControllerHelper.PollingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x58
	private IList<Joystick> rqSMdDJGxgTyaNVDURvIlrOONYwo; // 0x60
	private int uMLHrMLoKtpVjuaOQzUZzxuMldxw; // 0x68
	private int pPGgUESwNACgnGeuXdCQJJGRwcRF; // 0x6C
	private IEnumerator<ControllerPollingInfo> rmTJoSaSEOTODpMQRvnpbvynqUJX; // 0x70

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1ADF910 Offset: 0x1ADEB10 VA: 0x181ADF910 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1ADF400 Offset: 0x1ADE600 VA: 0x181ADF400 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1ADF9A0 Offset: 0x1ADEBA0 VA: 0x181ADF9A0
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1ADF860 Offset: 0x1ADEA60 VA: 0x181ADF860 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1ADF8A0 Offset: 0x1ADEAA0 VA: 0x181ADF8A0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1ADF7A0 Offset: 0x1ADE9A0 VA: 0x181ADF7A0 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1ADF7A0 Offset: 0x1ADE9A0 VA: 0x181ADF7A0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.PollingHelper.kOaezZBWNOwivbuAJKIHIJsdPUfZb : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7083
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	public Player.ControllerHelper.PollingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x58
	private IList<Joystick> rqSMdDJGxgTyaNVDURvIlrOONYwo; // 0x60
	private int uMLHrMLoKtpVjuaOQzUZzxuMldxw; // 0x68
	private int pPGgUESwNACgnGeuXdCQJJGRwcRF; // 0x6C
	private IEnumerator<ControllerPollingInfo> rmTJoSaSEOTODpMQRvnpbvynqUJX; // 0x70

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1AF4510 Offset: 0x1AF3710 VA: 0x181AF4510 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AF4000 Offset: 0x1AF3200 VA: 0x181AF4000 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1AF45A0 Offset: 0x1AF37A0 VA: 0x181AF45A0
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF4460 Offset: 0x1AF3660 VA: 0x181AF4460 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1AF44A0 Offset: 0x1AF36A0 VA: 0x181AF44A0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF43A0 Offset: 0x1AF35A0 VA: 0x181AF43A0 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AF43A0 Offset: 0x1AF35A0 VA: 0x181AF43A0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.PollingHelper.WfWxabLOqbxhmLqBqHkUTkzkippW : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7084
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	public Player.ControllerHelper.PollingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x58
	private IList<Joystick> rqSMdDJGxgTyaNVDURvIlrOONYwo; // 0x60
	private int uMLHrMLoKtpVjuaOQzUZzxuMldxw; // 0x68
	private int pPGgUESwNACgnGeuXdCQJJGRwcRF; // 0x6C
	private IEnumerator<ControllerPollingInfo> rmTJoSaSEOTODpMQRvnpbvynqUJX; // 0x70

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1AF3300 Offset: 0x1AF2500 VA: 0x181AF3300 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AF2DF0 Offset: 0x1AF1FF0 VA: 0x181AF2DF0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1AF3390 Offset: 0x1AF2590 VA: 0x181AF3390
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF3250 Offset: 0x1AF2450 VA: 0x181AF3250 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1AF3290 Offset: 0x1AF2490 VA: 0x181AF3290 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF3190 Offset: 0x1AF2390 VA: 0x181AF3190 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AF3190 Offset: 0x1AF2390 VA: 0x181AF3190 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.PollingHelper.lAwSrtLIZrIXNyeArKBrSBKvLzpA : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7085
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	private int KFrkqcMhAhkuwDBDacKNtYSrhuaI; // 0x54
	public int KOPJxxEEfECOHiZOqJNzPzlAGPiF; // 0x58
	public Player.ControllerHelper.PollingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x60
	private IEnumerator<ControllerPollingInfo> BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x68

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1AF4A80 Offset: 0x1AF3C80 VA: 0x181AF4A80 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AF45F0 Offset: 0x1AF37F0 VA: 0x181AF45F0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1AF4B10 Offset: 0x1AF3D10 VA: 0x181AF4B10
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF49D0 Offset: 0x1AF3BD0 VA: 0x181AF49D0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1AF4A10 Offset: 0x1AF3C10 VA: 0x181AF4A10 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF4910 Offset: 0x1AF3B10 VA: 0x181AF4910 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AF4910 Offset: 0x1AF3B10 VA: 0x181AF4910 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.PollingHelper.PnOfnmYaXipgxqlelSPuiAwBTkrU : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7086
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	private int KFrkqcMhAhkuwDBDacKNtYSrhuaI; // 0x54
	public int KOPJxxEEfECOHiZOqJNzPzlAGPiF; // 0x58
	public Player.ControllerHelper.PollingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x60
	private IEnumerator<ControllerPollingInfo> BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x68

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1AE0C70 Offset: 0x1ADFE70 VA: 0x181AE0C70 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AE07D0 Offset: 0x1ADF9D0 VA: 0x181AE07D0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1AE0D00 Offset: 0x1ADFF00 VA: 0x181AE0D00
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AE0BC0 Offset: 0x1ADFDC0 VA: 0x181AE0BC0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1AE0C00 Offset: 0x1ADFE00 VA: 0x181AE0C00 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AE0B00 Offset: 0x1ADFD00 VA: 0x181AE0B00 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AE0B00 Offset: 0x1ADFD00 VA: 0x181AE0B00 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.PollingHelper.mfLFWzFTphEfQqHKlaYwkGGLurG : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7087
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	private int KFrkqcMhAhkuwDBDacKNtYSrhuaI; // 0x54
	public int KOPJxxEEfECOHiZOqJNzPzlAGPiF; // 0x58
	public Player.ControllerHelper.PollingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x60
	private IEnumerator<ControllerPollingInfo> BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x68

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1AF5000 Offset: 0x1AF4200 VA: 0x181AF5000 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AF4B60 Offset: 0x1AF3D60 VA: 0x181AF4B60 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1AF5090 Offset: 0x1AF4290 VA: 0x181AF5090
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF4F50 Offset: 0x1AF4150 VA: 0x181AF4F50 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1AF4F90 Offset: 0x1AF4190 VA: 0x181AF4F90 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF4E90 Offset: 0x1AF4090 VA: 0x181AF4E90 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AF4E90 Offset: 0x1AF4090 VA: 0x181AF4E90 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.PollingHelper.yZaQkhVPCJgrobAscycIPZlJobZaA : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7088
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	private int KFrkqcMhAhkuwDBDacKNtYSrhuaI; // 0x54
	public int KOPJxxEEfECOHiZOqJNzPzlAGPiF; // 0x58
	public Player.ControllerHelper.PollingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x60
	private IEnumerator<ControllerPollingInfo> BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x68

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1AF7790 Offset: 0x1AF6990 VA: 0x181AF7790 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AF72F0 Offset: 0x1AF64F0 VA: 0x181AF72F0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1AF7820 Offset: 0x1AF6A20 VA: 0x181AF7820
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF76E0 Offset: 0x1AF68E0 VA: 0x181AF76E0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1AF7720 Offset: 0x1AF6920 VA: 0x181AF7720 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF7620 Offset: 0x1AF6820 VA: 0x181AF7620 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AF7620 Offset: 0x1AF6820 VA: 0x181AF7620 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.PollingHelper.xffabOtowJDMjXOiUEvohunMgiBc : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7089
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	private int KFrkqcMhAhkuwDBDacKNtYSrhuaI; // 0x54
	public int KOPJxxEEfECOHiZOqJNzPzlAGPiF; // 0x58
	public Player.ControllerHelper.PollingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x60
	private IEnumerator<ControllerPollingInfo> BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x68

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1AF6C90 Offset: 0x1AF5E90 VA: 0x181AF6C90 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AF67F0 Offset: 0x1AF59F0 VA: 0x181AF67F0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1AF6D20 Offset: 0x1AF5F20 VA: 0x181AF6D20
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF6BE0 Offset: 0x1AF5DE0 VA: 0x181AF6BE0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1AF6C20 Offset: 0x1AF5E20 VA: 0x181AF6C20 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF6B20 Offset: 0x1AF5D20 VA: 0x181AF6B20 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AF6B20 Offset: 0x1AF5D20 VA: 0x181AF6B20 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.PollingHelper.RWSybESvLmzRLrtMZcfcRQEXFGDE : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7090
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	private int JTVbKkaOfUHTYeezJJVreQldtfSZ; // 0x54
	public int VpUqGKaMcLfgiswRnLBzNmFSiwVfA; // 0x58
	public Player.ControllerHelper.PollingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x60
	private IEnumerator<ControllerPollingInfo> BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x68

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1AE73E0 Offset: 0x1AE65E0 VA: 0x181AE73E0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AE6F50 Offset: 0x1AE6150 VA: 0x181AE6F50 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1AE7470 Offset: 0x1AE6670 VA: 0x181AE7470
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AE7330 Offset: 0x1AE6530 VA: 0x181AE7330 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1AE7370 Offset: 0x1AE6570 VA: 0x181AE7370 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AE7270 Offset: 0x1AE6470 VA: 0x181AE7270 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AE7270 Offset: 0x1AE6470 VA: 0x181AE7270 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.PollingHelper.EWAAydkpczFeIBsOOiTnSmZYADCZA : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7091
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	private int JTVbKkaOfUHTYeezJJVreQldtfSZ; // 0x54
	public int VpUqGKaMcLfgiswRnLBzNmFSiwVfA; // 0x58
	public Player.ControllerHelper.PollingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x60
	private IEnumerator<ControllerPollingInfo> BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x68

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1ADE1D0 Offset: 0x1ADD3D0 VA: 0x181ADE1D0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1ADDD30 Offset: 0x1ADCF30 VA: 0x181ADDD30 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1ADE260 Offset: 0x1ADD460 VA: 0x181ADE260
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1ADE120 Offset: 0x1ADD320 VA: 0x181ADE120 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1ADE160 Offset: 0x1ADD360 VA: 0x181ADE160 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1ADE060 Offset: 0x1ADD260 VA: 0x181ADE060 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1ADE060 Offset: 0x1ADD260 VA: 0x181ADE060 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.PollingHelper.xgHxmsCNdfxyZJauOzxZMpGdfFTK : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7092
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	private int JTVbKkaOfUHTYeezJJVreQldtfSZ; // 0x54
	public int VpUqGKaMcLfgiswRnLBzNmFSiwVfA; // 0x58
	public Player.ControllerHelper.PollingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x60
	private IEnumerator<ControllerPollingInfo> BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x68

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1AF7210 Offset: 0x1AF6410 VA: 0x181AF7210 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AF6D70 Offset: 0x1AF5F70 VA: 0x181AF6D70 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1AF72A0 Offset: 0x1AF64A0 VA: 0x181AF72A0
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF7160 Offset: 0x1AF6360 VA: 0x181AF7160 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1AF71A0 Offset: 0x1AF63A0 VA: 0x181AF71A0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF70A0 Offset: 0x1AF62A0 VA: 0x181AF70A0 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AF70A0 Offset: 0x1AF62A0 VA: 0x181AF70A0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.PollingHelper.FGwEhSZNWVipVybCUheCrJDQqYwU : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7093
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	private int JTVbKkaOfUHTYeezJJVreQldtfSZ; // 0x54
	public int VpUqGKaMcLfgiswRnLBzNmFSiwVfA; // 0x58
	public Player.ControllerHelper.PollingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x60
	private IEnumerator<ControllerPollingInfo> BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x68

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1ADE750 Offset: 0x1ADD950 VA: 0x181ADE750 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1ADE2B0 Offset: 0x1ADD4B0 VA: 0x181ADE2B0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1ADE7E0 Offset: 0x1ADD9E0 VA: 0x181ADE7E0
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1ADE6A0 Offset: 0x1ADD8A0 VA: 0x181ADE6A0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1ADE6E0 Offset: 0x1ADD8E0 VA: 0x181ADE6E0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1ADE5E0 Offset: 0x1ADD7E0 VA: 0x181ADE5E0 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1ADE5E0 Offset: 0x1ADD7E0 VA: 0x181ADE5E0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.PollingHelper.KfukyLiqQFFCMbDuYTlUCXmHHTAy : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7094
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	private int JTVbKkaOfUHTYeezJJVreQldtfSZ; // 0x54
	public int VpUqGKaMcLfgiswRnLBzNmFSiwVfA; // 0x58
	public Player.ControllerHelper.PollingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x60
	private IEnumerator<ControllerPollingInfo> BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x68

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1ADFE90 Offset: 0x1ADF090 VA: 0x181ADFE90 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1ADF9F0 Offset: 0x1ADEBF0 VA: 0x181ADF9F0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1ADFF20 Offset: 0x1ADF120 VA: 0x181ADFF20
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1ADFDE0 Offset: 0x1ADEFE0 VA: 0x181ADFDE0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1ADFE20 Offset: 0x1ADF020 VA: 0x181ADFE20 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1ADFD20 Offset: 0x1ADEF20 VA: 0x181ADFD20 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1ADFD20 Offset: 0x1ADEF20 VA: 0x181ADFD20 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[Browsable(False)]
[EditorBrowsable(1)]
public sealed class Player.ControllerHelper.PollingHelper : CodeHelper // TypeDefIndex: 7095
{
	// Fields
	private readonly Player dKxeWVrXJNsFqEAYKfLlJKDBwaWd; // 0x10
	private readonly Player.ControllerHelper JzLBwDullgkQLozUBYHRGdbOnLzK; // 0x18
	private readonly int aplyKYJQthDqFZJRnEooAHmQTlabA; // 0x20

	// Methods

	// RVA: 0x1AE56D0 Offset: 0x1AE48D0 VA: 0x181AE56D0
	internal void .ctor(Player , Player.ControllerHelper ) { }

	// RVA: 0x1AE4BD0 Offset: 0x1AE3DD0 VA: 0x181AE4BD0
	public ControllerPollingInfo PollControllerForFirstElement(ControllerType controllerType, int controllerId) { }

	// RVA: 0x1AE48C0 Offset: 0x1AE3AC0 VA: 0x181AE48C0
	public ControllerPollingInfo PollControllerForFirstElementDown(ControllerType controllerType, int controllerId) { }

	// RVA: 0x1AE45B0 Offset: 0x1AE37B0 VA: 0x181AE45B0
	public ControllerPollingInfo PollControllerForFirstButton(ControllerType controllerType, int controllerId) { }

	// RVA: 0x1AE42A0 Offset: 0x1AE34A0 VA: 0x181AE42A0
	public ControllerPollingInfo PollControllerForFirstButtonDown(ControllerType controllerType, int controllerId) { }

	// RVA: 0x1AE3FE0 Offset: 0x1AE31E0 VA: 0x181AE3FE0
	public ControllerPollingInfo PollControllerForFirstAxis(ControllerType controllerType, int controllerId) { }

	// RVA: 0x1AE3E00 Offset: 0x1AE3000 VA: 0x181AE3E00
	public IEnumerable<ControllerPollingInfo> PollControllerForAllElements(ControllerType controllerType, int controllerId) { }

	// RVA: 0x1AE3C20 Offset: 0x1AE2E20 VA: 0x181AE3C20
	public IEnumerable<ControllerPollingInfo> PollControllerForAllElementsDown(ControllerType controllerType, int controllerId) { }

	// RVA: 0x1AE3A40 Offset: 0x1AE2C40 VA: 0x181AE3A40
	public IEnumerable<ControllerPollingInfo> PollControllerForAllButtons(ControllerType controllerType, int controllerId) { }

	// RVA: 0x1AE3860 Offset: 0x1AE2A60 VA: 0x181AE3860
	public IEnumerable<ControllerPollingInfo> PollControllerForAllButtonsDown(ControllerType controllerType, int controllerId) { }

	// RVA: 0x1AE3650 Offset: 0x1AE2850 VA: 0x181AE3650
	public IEnumerable<ControllerPollingInfo> PollControllerForAllAxes(ControllerType controllerType, int controllerId) { }

	// RVA: 0x1AE3240 Offset: 0x1AE2440 VA: 0x181AE3240
	public ControllerPollingInfo PollAllControllersOfTypeForFirstElement(ControllerType controllerType) { }

	// RVA: 0x1AE2E30 Offset: 0x1AE2030 VA: 0x181AE2E30
	public ControllerPollingInfo PollAllControllersOfTypeForFirstButton(ControllerType controllerType) { }

	// RVA: 0x1AE2A20 Offset: 0x1AE1C20 VA: 0x181AE2A20
	public ControllerPollingInfo PollAllControllersOfTypeForFirstButtonDown(ControllerType controllerType) { }

	// RVA: 0x1AE2660 Offset: 0x1AE1860 VA: 0x181AE2660
	public ControllerPollingInfo PollAllControllersOfTypeForFirstAxis(ControllerType controllerType) { }

	// RVA: 0x1AE24A0 Offset: 0x1AE16A0 VA: 0x181AE24A0
	public IEnumerable<ControllerPollingInfo> PollAllControllersOfTypeForAllElements(ControllerType controllerType) { }

	// RVA: 0x1AE22E0 Offset: 0x1AE14E0 VA: 0x181AE22E0
	public IEnumerable<ControllerPollingInfo> PollAllControllersOfTypeForAllElementsDown(ControllerType controllerType) { }

	// RVA: 0x1AE2120 Offset: 0x1AE1320 VA: 0x181AE2120
	public IEnumerable<ControllerPollingInfo> PollAllControllersOfTypeForAllButtons(ControllerType controllerType) { }

	// RVA: 0x1AE1F60 Offset: 0x1AE1160 VA: 0x181AE1F60
	public IEnumerable<ControllerPollingInfo> PollAllControllersOfTypeForAllButtonsDown(ControllerType controllerType) { }

	// RVA: 0x1AE1D70 Offset: 0x1AE0F70 VA: 0x181AE1D70
	public IEnumerable<ControllerPollingInfo> PollAllControllersOfTypeForAllAxes(ControllerType controllerType) { }

	// RVA: 0x1AE5810 Offset: 0x1AE4A10 VA: 0x181AE5810
	private ControllerPollingInfo cNdBTYbjAePzFpKcZATUZOAUHQJgA(int ) { }

	// RVA: 0x1AE6A10 Offset: 0x1AE5C10 VA: 0x181AE6A10
	private ControllerPollingInfo yGXeSUnfDabWsLCRkcEFzkqcwkcI(int ) { }

	// RVA: 0x1AE1A20 Offset: 0x1AE0C20 VA: 0x181AE1A20
	private ControllerPollingInfo MsOTSBfeqXoCUjXWjpIhwSMQNjQG(int ) { }

	// RVA: 0x1AE11A0 Offset: 0x1AE03A0 VA: 0x181AE11A0
	private ControllerPollingInfo CxEwhDbmBjQpkHmUlgtqKVuoagjw(int ) { }

	// RVA: 0x1AE6B30 Offset: 0x1AE5D30 VA: 0x181AE6B30
	private ControllerPollingInfo zTxzpZLxHVhpIENRXYZgZdkkGVxS(int ) { }

	// RVA: 0x1AE1090 Offset: 0x1AE0290 VA: 0x181AE1090
	private IEnumerable<ControllerPollingInfo> CBLfjCvgKHpNiNmCgHOVkluKqfZgA(int ) { }

	// RVA: 0x1AE1660 Offset: 0x1AE0860 VA: 0x181AE1660
	private IEnumerable<ControllerPollingInfo> IKAowGurEocmQLmogCecKwoIRrtN(int ) { }

	// RVA: 0x1AE5BD0 Offset: 0x1AE4DD0 VA: 0x181AE5BD0
	private IEnumerable<ControllerPollingInfo> exwCKdDJldjkwlZcjFSISuJcyCJD(int ) { }

	// RVA: 0x1AE54B0 Offset: 0x1AE46B0 VA: 0x181AE54B0
	private IEnumerable<ControllerPollingInfo> XXKzfZxllYhKzBegGywaAVpfStTeA(int ) { }

	// RVA: 0x1AE1330 Offset: 0x1AE0530 VA: 0x181AE1330
	private IEnumerable<ControllerPollingInfo> DwRInAAOwdupenFbBqiKtfUcjmKJ(int ) { }

	// RVA: 0x1AE6780 Offset: 0x1AE5980 VA: 0x181AE6780
	private ControllerPollingInfo uazsEIGqpZemqyfBcexnYcQwddqI() { }

	// RVA: 0x1AE6080 Offset: 0x1AE5280 VA: 0x181AE6080
	private ControllerPollingInfo mcnAxrWPavgcdzcVoerwCqYCoHxcA() { }

	// RVA: 0x1AE0D50 Offset: 0x1ADFF50 VA: 0x181AE0D50
	private ControllerPollingInfo AKSlymLmrQmNoVAAktPzRBxCGhfbA() { }

	// RVA: 0x1AE1800 Offset: 0x1AE0A00 VA: 0x181AE1800
	private ControllerPollingInfo MNXVUFRDWfGzktYxNNxKubDbwCpg() { }

	// RVA: 0x1AE5540 Offset: 0x1AE4740 VA: 0x181AE5540
	private ControllerPollingInfo ZbcDcaympuluWFFqXABoGKdammSc() { }

	// RVA: 0x1AE1CF0 Offset: 0x1AE0EF0 VA: 0x181AE1CF0
	private IEnumerable<ControllerPollingInfo> POQauBfFbObeCcKgrChCtiWfoUorA() { }

	// RVA: 0x1AE5AD0 Offset: 0x1AE4CD0 VA: 0x181AE5AD0
	private IEnumerable<ControllerPollingInfo> cdbeXwCwlHVioLldDMXiPZhBGOsY() { }

	// RVA: 0x1AE4EE0 Offset: 0x1AE40E0 VA: 0x181AE4EE0
	private IEnumerable<ControllerPollingInfo> QvChwonEjPokNRNhUNJghDigzly() { }

	// RVA: 0x1AE5B50 Offset: 0x1AE4D50 VA: 0x181AE5B50
	private IEnumerable<ControllerPollingInfo> dUtIYGbpJvhYSEZfTPVLakymMfit() { }

	// RVA: 0x1AE5180 Offset: 0x1AE4380 VA: 0x181AE5180
	private IEnumerable<ControllerPollingInfo> TQFVkVDvzlGAFCxcGBELNyfbviuW() { }

	// RVA: 0x1AE4F60 Offset: 0x1AE4160 VA: 0x181AE4F60
	private ControllerPollingInfo SfXFUKDZgkDfZYTscjYQbIyAiLcLA() { }

	// RVA: 0x1AE5DE0 Offset: 0x1AE4FE0 VA: 0x181AE5DE0
	private ControllerPollingInfo hKbOyanhNvanpedKvfyjltzjWeEC() { }

	// RVA: 0x1AE69A0 Offset: 0x1AE5BA0 VA: 0x181AE69A0
	private IEnumerable<ControllerPollingInfo> vwArQTeXTHnKEfLFxYBoPYaUgvBq() { }

	// RVA: 0x1AE12C0 Offset: 0x1AE04C0 VA: 0x181AE12C0
	private IEnumerable<ControllerPollingInfo> DhGzJoxnsSBMDbEZXtgGpCBWcNAjb() { }

	// RVA: 0x1AE6920 Offset: 0x1AE5B20 VA: 0x181AE6920
	private ControllerPollingInfo uxajpMTUtlifVOjmsWAfidjkaEsEA() { }

	// RVA: 0x1AE5C60 Offset: 0x1AE4E60 VA: 0x181AE5C60
	private ControllerPollingInfo furbeESMTbXDSXehoBnRivuvuVzN() { }

	// RVA: 0x1AE6000 Offset: 0x1AE5200 VA: 0x181AE6000
	private ControllerPollingInfo lPTmlxcGkNXSkpiOryMVZORYrGZb() { }

	// RVA: 0x1AE16F0 Offset: 0x1AE08F0 VA: 0x181AE16F0
	private ControllerPollingInfo JPHpRSVTWYIzOCSbtlEYsCZmNETM() { }

	// RVA: 0x1AE6560 Offset: 0x1AE5760 VA: 0x181AE6560
	private ControllerPollingInfo tudCAmcgZEIUkmgdNINOQVmFuujy() { }

	// RVA: 0x1AE19A0 Offset: 0x1AE0BA0 VA: 0x181AE19A0
	private IEnumerable<ControllerPollingInfo> MaJBbcoEElBnoIqnZRsmlEqlRGKV() { }

	// RVA: 0x1AE1120 Offset: 0x1AE0320 VA: 0x181AE1120
	private IEnumerable<ControllerPollingInfo> CCPIQCdYbsHdilbICWpzjeTiHehxA() { }

	// RVA: 0x1AE5D60 Offset: 0x1AE4F60 VA: 0x181AE5D60
	private IEnumerable<ControllerPollingInfo> hBhTaaaxbnfGwlIWraCUCivvzErHA() { }

	// RVA: 0x1AE5430 Offset: 0x1AE4630 VA: 0x181AE5430
	private IEnumerable<ControllerPollingInfo> XDkmLEVvShmFBWeMwifuLtLDQeYm() { }

	// RVA: 0x1AE1450 Offset: 0x1AE0650 VA: 0x181AE1450
	private IEnumerable<ControllerPollingInfo> FzzQsypFpSGOVDBKAEPKXJtUDitjA() { }

	// RVA: 0x1AE63B0 Offset: 0x1AE55B0 VA: 0x181AE63B0
	private ControllerPollingInfo potCwJsXCBjCSseyTSorDfrCfyHl(int ) { }

	// RVA: 0x1AE1B40 Offset: 0x1AE0D40 VA: 0x181AE1B40
	private ControllerPollingInfo NlZmESqwhwpcpQPlCDTLlUslRzYh(int ) { }

	// RVA: 0x1AE5280 Offset: 0x1AE4480 VA: 0x181AE5280
	private ControllerPollingInfo UWcQMAFXCSaEMmtQfvNJZeZzcPvr(int ) { }

	// RVA: 0x1AE0F70 Offset: 0x1AE0170 VA: 0x181AE0F70
	private ControllerPollingInfo BiRDbrIMCinVAhZACKzDhVPfrsaWB(int ) { }

	// RVA: 0x1AE5E60 Offset: 0x1AE5060 VA: 0x181AE5E60
	private ControllerPollingInfo hixTGQxSnIUDXyRajBiAEAkOKqzs(int ) { }

	// RVA: 0x1AE64D0 Offset: 0x1AE56D0 VA: 0x181AE64D0
	private IEnumerable<ControllerPollingInfo> rOPpLqAGpeiIpLOcECIzkAxZlVtpA(int ) { }

	// RVA: 0x1AE1C60 Offset: 0x1AE0E60 VA: 0x181AE1C60
	private IEnumerable<ControllerPollingInfo> OfdwwTlsCzmKonSpJILNZQbjUfZf(int ) { }

	// RVA: 0x1AE13C0 Offset: 0x1AE05C0 VA: 0x181AE13C0
	private IEnumerable<ControllerPollingInfo> DyCXxoBERSTcDwTrrWsvINaoozWC(int ) { }

	// RVA: 0x1AE1770 Offset: 0x1AE0970 VA: 0x181AE1770
	private IEnumerable<ControllerPollingInfo> LKSbjcvxCHCXcDOXqmpQNFDzdAlW(int ) { }

	// RVA: 0x1AE53A0 Offset: 0x1AE45A0 VA: 0x181AE53A0
	private IEnumerable<ControllerPollingInfo> WVdgeYRZZIAuWniJITeOWADlkhGH(int ) { }

	// RVA: 0x1AE65E0 Offset: 0x1AE57E0 VA: 0x181AE65E0
	private ControllerPollingInfo tugefKijSoMAqonuceVryqiRPTvC() { }

	// RVA: 0x1AE14C0 Offset: 0x1AE06C0 VA: 0x181AE14C0
	private ControllerPollingInfo GxLRDgmbFuebZRjmyEbvZrFDGbxhA() { }

	// RVA: 0x1AE5930 Offset: 0x1AE4B30 VA: 0x181AE5930
	private ControllerPollingInfo cRKPEuxhZsDVeflVGfiCgpzgWUEfB() { }

	// RVA: 0x1AE4FE0 Offset: 0x1AE41E0 VA: 0x181AE4FE0
	private ControllerPollingInfo SuQjNUvEuvIcKYicangRenCQkfgi() { }

	// RVA: 0x1AE6220 Offset: 0x1AE5420 VA: 0x181AE6220
	private ControllerPollingInfo nqIqFEqjKkHeLriTQPOsejSxbezO() { }

	// RVA: 0x1AE5CE0 Offset: 0x1AE4EE0 VA: 0x181AE5CE0
	private IEnumerable<ControllerPollingInfo> gGwQkMNmvEfITNvRsTNsYkxDLoMB() { }

	// RVA: 0x1AE5200 Offset: 0x1AE4400 VA: 0x181AE5200
	private IEnumerable<ControllerPollingInfo> UDHomVayjaGPyJHiRCUOfKHytcJL() { }

	// RVA: 0x1AE0EF0 Offset: 0x1AE00F0 VA: 0x181AE0EF0
	private IEnumerable<ControllerPollingInfo> BelreQGlOFTJqKmIiOIsYCSsvtzv() { }

	// RVA: 0x1AE5F80 Offset: 0x1AE5180 VA: 0x181AE5F80
	private IEnumerable<ControllerPollingInfo> jCtVIdrAUVbuGsFLkZTyzAQEPfaD() { }

	// RVA: 0x1AE5790 Offset: 0x1AE4990 VA: 0x181AE5790
	private IEnumerable<ControllerPollingInfo> bDoAvHFDCQxECaJqHfHIGYDyfaraA() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Player.ControllerHelper.mkzPQBXudcKQPENPSjBqetlMGnKVA // TypeDefIndex: 7096
{
	// Fields
	public static readonly Player.ControllerHelper.mkzPQBXudcKQPENPSjBqetlMGnKVA <>9; // 0x0
	public static Action<Exception> <>9__23_0; // 0x8
	public static Action<Exception> <>9__23_1; // 0x10

	// Methods

	// RVA: 0x1AF5140 Offset: 0x1AF4340 VA: 0x181AF5140
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1AF51A0 Offset: 0x1AF43A0 VA: 0x181AF51A0
	internal void wEnCtqFuyHkTpESXURMQZtbDeAmi(Exception ) { }

	// RVA: 0x1AF50E0 Offset: 0x1AF42E0 VA: 0x181AF50E0
	internal void KumFUfeTcrmipaXBRViLbtMaJgmac(Exception ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Player.ControllerHelper.acsACPiBfCcgRjGJtCPVOhJCIARcb : IDisposable, IEnumerable, IEnumerator, IEnumerable<Controller>, IEnumerator<Controller> // TypeDefIndex: 7097
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private Controller lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public Player.ControllerHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private int ulgWkkqxBcPwQLlwCxHoTZexcGGg; // 0x30
	private IList<Joystick> AjdHVaCbgrFMQOplohCZppSATWJu; // 0x38
	private int fbcuwqFSbDIgseiHliqTpBtfEohjA; // 0x40
	private IList<CustomController> SZQyOjGEHqCFmbvwnAwhFCrBatsUb; // 0x48
	private int UMDfwelfAybnFBMPLzcnoDzdGNwab; // 0x50

	// Properties
	private Controller System.Collections.Generic.IEnumerator<Rewired.Controller>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1AF39D0 Offset: 0x1AF2BD0 VA: 0x181AF39D0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private Controller System.Collections.Generic.IEnumerator<Rewired.Controller>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF3CE0 Offset: 0x1AF2EE0 VA: 0x181AF3CE0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1AF3C20 Offset: 0x1AF2E20 VA: 0x181AF3C20 Slot: 9
	private IEnumerator<Controller> System.Collections.Generic.IEnumerable<Rewired.Controller>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1AF3C20 Offset: 0x1AF2E20 VA: 0x181AF3C20 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[EditorBrowsable(1)]
[Browsable(False)]
public sealed class Player.ControllerHelper // TypeDefIndex: 7098
{
	// Fields
	private readonly Player.ControllerHelper.rNojQFABiPcQnhzbrdHPHPvawbTQA hPVsbqZDgbGDGXhmIdKCDdGNUNTqA; // 0x10
	private bool AbQsBlqLIsTzvcCkAzRAUnHbWTpC; // 0x18
	private bool dbSsanuqbHbSlPzRsSKsANTiyLri; // 0x19
	private bool IjDuQalQLsbAPqCdFDxSzTFicBbM; // 0x1A
	private double aiRJbpSaBFGOKdoinnVBFtTDNQvGc; // 0x20
	private double qrtpeDTTXiTegfzDoACrLBYcDxVi; // 0x28
	private SafeAction<ControllerAssignmentChangedEventArgs> cUCmkuiyUtNPNDesGGCtZdYDGpzk; // 0x30
	private SafeAction<ControllerAssignmentChangedEventArgs> fJsnxdXjZZQvkHJSvUIyYLFqDtAIA; // 0x38
	private readonly Player.ControllerHelper.sRTBJiyOzrLJeZMfMScvYoeENrpm KzkEJJbQFFTnTRilEpvNrICbOBlNA; // 0x40
	private readonly Player dKxeWVrXJNsFqEAYKfLlJKDBwaWd; // 0x48
	private readonly XBoAxPyoIvQNXtmkapFQwgBOjQfE QmaaWyfzOYYCmTNuTembfvwXozcgb; // 0x50
	private readonly int aplyKYJQthDqFZJRnEooAHmQTlabA; // 0x58
	public readonly Player.ControllerHelper.MapHelper maps; // 0x60
	public readonly Player.ControllerHelper.ConflictCheckingHelper conflictChecking; // 0x68
	public readonly Player.ControllerHelper.PollingHelper polling; // 0x70

	// Properties
	private Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<Joystick, JoystickMap> avgxbLQpvfkfYSCSMAEYKLctLZTr { get; }
	private VOLZYtSxBAfSvCRXgiPmhhdoQwVG<KeyboardMap> GuMTDZLwlBWbkpXzeUkaqKoiBqoV { get; }
	private VOLZYtSxBAfSvCRXgiPmhhdoQwVG<MouseMap> PBOcrvcPUtFAXMSHFbjJfgITxqURA { get; }
	private Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<CustomController, CustomControllerMap> HSmSNQpofyBNLGEZYpJJgUmzpCiFb { get; }
	public bool hasMouse { get; set; }
	public bool hasKeyboard { get; set; }
	public bool excludeFromControllerAutoAssignment { get; set; }
	public Keyboard Keyboard { get; }
	public Mouse Mouse { get; }
	public int joystickCount { get; }
	public IList<Joystick> Joysticks { get; }
	public int customControllerCount { get; }
	public IList<CustomController> CustomControllers { get; }
	public IEnumerable<Controller> Controllers { get; }

	// Methods

	// RVA: 0x1AABF20 Offset: 0x1AAB120 VA: 0x181AABF20
	private Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<Joystick, JoystickMap> vxlfPclaeJaDFDbHmXpVAggOkZC() { }

	// RVA: 0x1AA9C90 Offset: 0x1AA8E90 VA: 0x181AA9C90
	private VOLZYtSxBAfSvCRXgiPmhhdoQwVG<KeyboardMap> RfdfZuiCKJGlSaLpVrZSLfDPFlZfA() { }

	// RVA: 0x1AA9600 Offset: 0x1AA8800 VA: 0x181AA9600
	private VOLZYtSxBAfSvCRXgiPmhhdoQwVG<MouseMap> PPOUjXhyUpcVcEzUJdajXSrAmUGg() { }

	// RVA: 0x1AAB360 Offset: 0x1AAA560 VA: 0x181AAB360
	private Player.ControllerHelper.rMWxWrufycGUSiMSaFkcnBvlciyW<CustomController, CustomControllerMap> iHVAKOnLFWUEIuokoYVYvXxNFJyB() { }

	// RVA: 0x1AAA310 Offset: 0x1AA9510 VA: 0x181AAA310
	internal void .ctor(Player , EzquJbHEydffWdoNsmXAduNipKns , ControllerMapLayoutManager.CyLIHYrgPsXJSPGIXMMCKhWGZnNj , ControllerMapEnabler.CivyAOWvRKPsTDBqoIBdmQrvjYZC ) { }

	// RVA: 0x1AAA920 Offset: 0x1AA9B20 VA: 0x181AAA920
	public void add_ControllerAddedEvent(Action<ControllerAssignmentChangedEventArgs> value) { }

	// RVA: 0x1AAB830 Offset: 0x1AAAA30 VA: 0x181AAB830
	public void remove_ControllerAddedEvent(Action<ControllerAssignmentChangedEventArgs> value) { }

	// RVA: 0x1AAA980 Offset: 0x1AA9B80 VA: 0x181AAA980
	public void add_ControllerRemovedEvent(Action<ControllerAssignmentChangedEventArgs> value) { }

	// RVA: 0x1AAB890 Offset: 0x1AAAA90 VA: 0x181AAB890
	public void remove_ControllerRemovedEvent(Action<ControllerAssignmentChangedEventArgs> value) { }

	// RVA: 0x1AAB210 Offset: 0x1AAA410 VA: 0x181AAB210
	public bool get_hasMouse() { }

	// RVA: 0x1AABC50 Offset: 0x1AAAE50 VA: 0x181AABC50
	public void set_hasMouse(bool value) { }

	// RVA: 0x1AAB180 Offset: 0x1AAA380 VA: 0x181AAB180
	public bool get_hasKeyboard() { }

	// RVA: 0x1AAB990 Offset: 0x1AAAB90 VA: 0x181AAB990
	public void set_hasKeyboard(bool value) { }

	// RVA: 0x1AAB0F0 Offset: 0x1AAA2F0 VA: 0x181AAB0F0
	public bool get_excludeFromControllerAutoAssignment() { }

	// RVA: 0x1AAB8F0 Offset: 0x1AAAAF0 VA: 0x181AAB8F0
	public void set_excludeFromControllerAutoAssignment(bool value) { }

	// RVA: 0x1AAAED0 Offset: 0x1AAA0D0 VA: 0x181AAAED0
	public Keyboard get_Keyboard() { }

	// RVA: 0x1AAAF80 Offset: 0x1AAA180 VA: 0x181AAAF80
	public Mouse get_Mouse() { }

	// RVA: 0x1AAB2A0 Offset: 0x1AAA4A0 VA: 0x181AAB2A0
	public int get_joystickCount() { }

	// RVA: 0x1AAADE0 Offset: 0x1AA9FE0 VA: 0x181AAADE0
	public IList<Joystick> get_Joysticks() { }

	// RVA: 0x1AAB030 Offset: 0x1AAA230 VA: 0x181AAB030
	public int get_customControllerCount() { }

	// RVA: 0x1AAACF0 Offset: 0x1AA9EF0 VA: 0x181AAACF0
	public IList<CustomController> get_CustomControllers() { }

	// RVA: 0x1AAAC80 Offset: 0x1AA9E80 VA: 0x181AAAC80
	public IEnumerable<Controller> get_Controllers() { }

	// RVA: -1 Offset: -1
	public T GetController<T>(int controllerId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACA8D0 Offset: 0xAC9AD0 VA: 0x180ACA8D0
	|-Player.ControllerHelper.GetController<object>
	*/

	// RVA: 0x1AA8560 Offset: 0x1AA7760 VA: 0x181AA8560
	public Controller GetController(ControllerType controllerType, int controllerId) { }

	// RVA: -1 Offset: -1
	public T GetControllerWithTag<T>(string tag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACA2B0 Offset: 0xAC94B0 VA: 0x180ACA2B0
	|-Player.ControllerHelper.GetControllerWithTag<object>
	*/

	// RVA: 0x1AA8400 Offset: 0x1AA7600 VA: 0x181AA8400
	public Controller GetControllerWithTag(ControllerType controllerType, string tag) { }

	// RVA: -1 Offset: -1
	public void AddController<T>(int controllerId, bool removeFromOtherPlayers) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC9850 Offset: 0xAC8A50 VA: 0x180AC9850
	|-Player.ControllerHelper.AddController<object>
	*/

	// RVA: 0x1AA64A0 Offset: 0x1AA56A0 VA: 0x181AA64A0
	public void AddController(Controller controller, bool removeFromOtherPlayers) { }

	// RVA: 0x1AA6680 Offset: 0x1AA5880 VA: 0x181AA6680
	public void AddController(ControllerType controllerType, int controllerId, bool removeFromOtherPlayers) { }

	// RVA: -1 Offset: -1
	public void RemoveController<T>(int controllerId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACAC00 Offset: 0xAC9E00 VA: 0x180ACAC00
	|-Player.ControllerHelper.RemoveController<object>
	*/

	// RVA: 0x1AA9700 Offset: 0x1AA8900 VA: 0x181AA9700
	public void RemoveController(ControllerType controllerType, int controllerId) { }

	// RVA: 0x1AA9860 Offset: 0x1AA8A60 VA: 0x181AA9860
	public void RemoveController(Controller controller) { }

	// RVA: -1 Offset: -1
	public bool ContainsController<T>(int controllerId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC9D60 Offset: 0xAC8F60 VA: 0x180AC9D60
	|-Player.ControllerHelper.ContainsController<object>
	*/

	// RVA: 0x1AA77B0 Offset: 0x1AA69B0 VA: 0x181AA77B0
	public bool ContainsController(ControllerType controllerType, int controllerId) { }

	// RVA: 0x1AA7940 Offset: 0x1AA6B40 VA: 0x181AA7940
	public bool ContainsController(Controller controller) { }

	// RVA: -1 Offset: -1
	public void ClearControllersOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC9AC0 Offset: 0xAC8CC0 VA: 0x180AC9AC0
	|-Player.ControllerHelper.ClearControllersOfType<object>
	*/

	// RVA: 0x1AA7570 Offset: 0x1AA6770 VA: 0x181AA7570
	public void ClearControllersOfType(ControllerType controllerType) { }

	// RVA: 0x1AA74C0 Offset: 0x1AA66C0 VA: 0x181AA74C0
	public void ClearAllControllers() { }

	// RVA: 0x1AA8B00 Offset: 0x1AA7D00 VA: 0x181AA8B00
	public Controller GetLastActiveController() { }

	// RVA: 0x1AA8990 Offset: 0x1AA7B90 VA: 0x181AA8990
	public Controller GetLastActiveController(ControllerType controllerType) { }

	// RVA: 0x1AA9DD0 Offset: 0x1AA8FD0 VA: 0x181AA9DD0
	private void XimObtcwAjoViNQkzACjomHVzbL(ControllerType , ref Controller , ref double ) { }

	// RVA: -1 Offset: -1
	public Controller GetLastActiveController<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACABB0 Offset: 0xAC9DB0 VA: 0x180ACABB0
	|-Player.ControllerHelper.GetLastActiveController<object>
	*/

	// RVA: 0x1AA6A60 Offset: 0x1AA5C60 VA: 0x181AA6A60
	public void AddLastActiveControllerChangedDelegate(PlayerActiveControllerChangedDelegate callback) { }

	// RVA: 0x1AA6920 Offset: 0x1AA5B20 VA: 0x181AA6920
	public void AddLastActiveControllerChangedDelegate(PlayerActiveControllerChangedDelegate callback, ControllerType controllerType) { }

	// RVA: 0x1AA9B70 Offset: 0x1AA8D70 VA: 0x181AA9B70
	public void RemoveLastActiveControllerChangedDelegate(PlayerActiveControllerChangedDelegate callback) { }

	// RVA: 0x1AA9A30 Offset: 0x1AA8C30 VA: 0x181AA9A30
	public void RemoveLastActiveControllerChangedDelegate(PlayerActiveControllerChangedDelegate callback, ControllerType controllerType) { }

	// RVA: 0x1AA76A0 Offset: 0x1AA68A0 VA: 0x181AA76A0
	public void ClearLastActiveControllerChangedDelegates() { }

	// RVA: 0x1AA8820 Offset: 0x1AA7A20 VA: 0x181AA8820
	public Controller GetFirstControllerWithTemplate(Guid templateTypeGuid) { }

	// RVA: 0x1AA86C0 Offset: 0x1AA78C0 VA: 0x181AA86C0
	public Controller GetFirstControllerWithTemplate(Type templateType) { }

	// RVA: -1 Offset: -1
	public Controller GetFirstControllerWithTemplate<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACAAA0 Offset: 0xAC9CA0 VA: 0x180ACAAA0
	|-Player.ControllerHelper.GetFirstControllerWithTemplate<object>
	*/

	// RVA: -1 Offset: -1
	public IList<TInterface> GetControllerTemplates<TInterface>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACA1E0 Offset: 0xAC93E0 VA: 0x180ACA1E0
	|-Player.ControllerHelper.GetControllerTemplates<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private Controller yNtxlarQWMxfOCCtYDbjJtaZLAWA<>(ControllerType , Func<Controller, , bool> ,  ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACB950 Offset: 0xACAB50 VA: 0x180ACB950
	|-Player.ControllerHelper.yNtxlarQWMxfOCCtYDbjJtaZLAWA<Guid>
	|
	|-RVA: 0xACBFD0 Offset: 0xACB1D0 VA: 0x180ACBFD0
	|-Player.ControllerHelper.yNtxlarQWMxfOCCtYDbjJtaZLAWA<object>
	|
	|-RVA: 0xACBBE0 Offset: 0xACADE0 VA: 0x180ACBBE0
	|-Player.ControllerHelper.yNtxlarQWMxfOCCtYDbjJtaZLAWA<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1AAA000 Offset: 0x1AA9200 VA: 0x181AAA000
	internal void ZFUcTEcndvHgBpdTmEAgSebxfOsJ() { }

	// RVA: 0x1AA96C0 Offset: 0x1AA88C0 VA: 0x181AA96C0
	internal double QlpzlLnDJssEaTPRmvmHXvaVRyrd(int ) { }

	// RVA: 0x1AA8090 Offset: 0x1AA7290 VA: 0x181AA8090
	internal void GZicSFWVeEcTPiqfpQOtZuZFzBOOA(Joystick , bool ) { }

	// RVA: 0x1AA8370 Offset: 0x1AA7570 VA: 0x181AA8370
	internal void GZicSFWVeEcTPiqfpQOtZuZFzBOOA(int , bool ) { }

	// RVA: 0x1AAAA30 Offset: 0x1AA9C30 VA: 0x181AAAA30
	internal void etZDgZgtmbCUYVHgAdVojmjUuLYg(int ) { }

	// RVA: 0x1AAAC60 Offset: 0x1AA9E60 VA: 0x181AAAC60
	internal void etZDgZgtmbCUYVHgAdVojmjUuLYg(Joystick ) { }

	// RVA: 0x1AA7B60 Offset: 0x1AA6D60 VA: 0x181AA7B60
	internal void EiTvdHjxpIIwDreoNLPddidRskBM() { }

	// RVA: 0x1AA8CA0 Offset: 0x1AA7EA0 VA: 0x181AA8CA0
	internal void OLeSSpOBSiNWzygFEpEFWgWNBvQm(CustomController , bool ) { }

	// RVA: 0x1AA8F20 Offset: 0x1AA8120 VA: 0x181AA8F20
	internal void OLeSSpOBSiNWzygFEpEFWgWNBvQm(int , bool ) { }

	// RVA: 0x1AA72E0 Offset: 0x1AA64E0 VA: 0x181AA72E0
	internal void CGuFpThyPusLHhKQEkNerBvTncmhb(int ) { }

	// RVA: 0x1AA74A0 Offset: 0x1AA66A0 VA: 0x181AA74A0
	internal void CGuFpThyPusLHhKQEkNerBvTncmhb(CustomController ) { }

	// RVA: 0x1AAB3D0 Offset: 0x1AAA5D0 VA: 0x181AAB3D0
	internal void lGfNbsyCWrqDVfhYnQrBLqZMbNH() { }

	// RVA: 0x1AA8C40 Offset: 0x1AA7E40 VA: 0x181AA8C40
	internal CustomController NRqmHlcEpOctnEfmlfZWKwzuplFJA(int ) { }

	// RVA: 0x1AABF90 Offset: 0x1AAB190 VA: 0x181AABF90
	internal void wPwSwLsNVygRJAidLmlQmVBMfByE(Action<bool, int, int> ) { }

	// RVA: 0x1AA6B80 Offset: 0x1AA5D80 VA: 0x181AA6B80
	internal void BRLcPbwEjZeViVoSntFdRqavffCKA(Keyboard , miUysssUdqGWyuAUsKAOqijtIpUFA , Action<bool, int, int> ) { }

	// RVA: 0x1AA9D50 Offset: 0x1AA8F50 VA: 0x181AA9D50
	private static void WClzNqsKGKBOsVYFMepXNtdnJwKf(Keyboard , ControllerMap , ActionElementMap , HrlcjemCuLDOTWiWxHeuTfauJxQd , ButtonStateFlags ) { }

	// RVA: 0x1AA8FB0 Offset: 0x1AA81B0 VA: 0x181AA8FB0
	internal void OYrBjmayTjTRWeHKALmrWdUdiuIG(Mouse , Action<bool, int, int> ) { }

	// RVA: 0x1AAA9E0 Offset: 0x1AA9BE0 VA: 0x181AAA9E0
	internal void ePzLkjslSJHEHUXLjfkYjGLIfWLm(Action<bool, int, int> ) { }

	// RVA: -1 Offset: -1
	private void nDCEPhoyZqHtjABSCdmttaoScgrGA<, >(ControllerType , Action<bool, int, int> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACB1F0 Offset: 0xACA3F0 VA: 0x180ACB1F0
	|-Player.ControllerHelper.nDCEPhoyZqHtjABSCdmttaoScgrGA<object, object>
	*/

	// RVA: -1 Offset: -1
	private bool UICBOUtZDKUWDKfJjnsKRiZfEOacA<>(ControllerWithAxes , int , int , ActionElementMap , VOLZYtSxBAfSvCRXgiPmhhdoQwVG<> , int , ref float ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACB070 Offset: 0xACA270 VA: 0x180ACB070
	|-Player.ControllerHelper.UICBOUtZDKUWDKfJjnsKRiZfEOacA<object>
	*/

	// RVA: -1 Offset: -1
	private bool ShiBetidniFcfeZAvHtFJDgVDByF<>(UnknownControllerHat.HatButtons , int , VOLZYtSxBAfSvCRXgiPmhhdoQwVG<> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACAE50 Offset: 0xACA050 VA: 0x180ACAE50
	|-Player.ControllerHelper.ShiBetidniFcfeZAvHtFJDgVDByF<object>
	*/

	// RVA: -1 Offset: -1
	private bool ETwYjJZSpnlKtcRrPpiRwmgVpnsN<>(UnknownControllerHat.HatButtons , int , VOLZYtSxBAfSvCRXgiPmhhdoQwVG<> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC9FB0 Offset: 0xAC91B0 VA: 0x180AC9FB0
	|-Player.ControllerHelper.ETwYjJZSpnlKtcRrPpiRwmgVpnsN<object>
	*/
}

// Namespace: Rewired
public sealed class Player : ftUiUAiTGSDgAJCvnFpXJSUgtERQ // TypeDefIndex: 7099
{
	// Fields
	private const string gWsanYkjIRiDNxQaCqeJDOlsLFefb = "player";
	private readonly NNjtgIYWbHpIVTdlVfBMKzOraljUA BUtBdWSNUavIFMohAkoFBliLDptEA; // 0x10
	private bool rKLFDOkwEUbhTckoybvtfEGKjZJLb; // 0x18
	private int yAQloNnkxShCOoclhwMCxCpNptHE; // 0x1C
	private string NsRFUoBLVeZwnSsExKWhwStYeoRV; // 0x20
	private string uuhkjpAdnQtfTIpAagUcXxnSJarI; // 0x28
	private readonly string sKEfXRhGnVSsmWsCqaKxYnjRjSNb; // 0x30
	private bool YKOPneHKQybtGLbRkAwaOqVHAggY; // 0x38
	private readonly int aplyKYJQthDqFZJRnEooAHmQTlabA; // 0x3C
	private readonly wxuBbaUjSloOlQfOCemKEVemgTdMA gEeATosTQCMbHLilWWJWbUSEBdYj; // 0x40
	private int lhWaVPChlXfgMFgLlRTKGxoUGNtgA; // 0x48
	public readonly Player.ControllerHelper controllers; // 0x50

	// Properties
	public int id { get; set; }
	public string name { get; set; }
	public string descriptiveName { get; set; }
	public bool isPlaying { get; set; }
	internal string nonLocalizedDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.INameLocalizerSource.keyCategory { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.scriptingName { get; }
	private string Rewired.Internal.Localization.INameLocalizerSource.nonLocalizedDescriptiveName { get; set; }
	private string Rewired.Internal.Localization.INameLocalizerSource.key { get; }
	private int Rewired.Internal.Localization.INameLocalizerSource.autoGeneratedValueFlags { get; set; }

	// Methods

	// RVA: 0x1AB8E20 Offset: 0x1AB8020 VA: 0x181AB8E20
	internal void .ctor(bool , int , string , string , string , EzquJbHEydffWdoNsmXAduNipKns , ControllerMapLayoutManager.CyLIHYrgPsXJSPGIXMMCKhWGZnNj , ControllerMapEnabler.CivyAOWvRKPsTDBqoIBdmQrvjYZC ) { }

	// RVA: 0x1AB9060 Offset: 0x1AB8260 VA: 0x181AB9060
	public int get_id() { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	internal void jWfqAPTWFZaggTsWsqOzmMkiSuHs(int ) { }

	// RVA: 0x1AB9180 Offset: 0x1AB8380 VA: 0x181AB9180
	public string get_name() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	internal void uGSHIPnuNZPbyNhItjkmgCPddCPV(string ) { }

	// RVA: 0x1AB8F80 Offset: 0x1AB8180 VA: 0x181AB8F80
	public string get_descriptiveName() { }

	// RVA: 0x1AB76D0 Offset: 0x1AB68D0 VA: 0x181AB76D0
	internal void OjMQUSgFKAEHGVWwqkldsuOHOtEt(string ) { }

	// RVA: 0x1AB90F0 Offset: 0x1AB82F0 VA: 0x181AB90F0
	public bool get_isPlaying() { }

	// RVA: 0x4BD760 Offset: 0x4BC960 VA: 0x1804BD760
	public void set_isPlaying(bool value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal string get_nonLocalizedDescriptiveName() { }

	// RVA: 0x1AB76D0 Offset: 0x1AB68D0 VA: 0x181AB76D0
	internal void set_nonLocalizedDescriptiveName(string value) { }

	// RVA: 0x1AB89C0 Offset: 0x1AB7BC0 VA: 0x181AB89C0 Slot: 4
	private string Rewired.Internal.Localization.INameLocalizerSource.get_keyCategory() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 5
	private string Rewired.Internal.Localization.INameLocalizerSource.get_scriptingName() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0 Slot: 6
	private string Rewired.Internal.Localization.INameLocalizerSource.get_nonLocalizedDescriptiveName() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650 Slot: 7
	private void Rewired.Internal.Localization.INameLocalizerSource.set_nonLocalizedDescriptiveName(string value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 8
	private string Rewired.Internal.Localization.INameLocalizerSource.get_key() { }

	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0 Slot: 9
	private int Rewired.Internal.Localization.INameLocalizerSource.get_autoGeneratedValueFlags() { }

	// RVA: 0x419410 Offset: 0x418610 VA: 0x180419410 Slot: 10
	private void Rewired.Internal.Localization.INameLocalizerSource.set_autoGeneratedValueFlags(int value) { }

	// RVA: 0x1AB6D40 Offset: 0x1AB5F40 VA: 0x181AB6D40
	public PlayerSaveData GetSaveData(bool userAssignableMapsOnly) { }

	// RVA: 0x1AB3CE0 Offset: 0x1AB2EE0 VA: 0x181AB3CE0
	public bool GetButton(string actionName) { }

	// RVA: 0x1AB3DB0 Offset: 0x1AB2FB0 VA: 0x181AB3DB0
	public bool GetButton(int actionId) { }

	// RVA: 0x1AB1C90 Offset: 0x1AB0E90 VA: 0x181AB1C90
	public bool GetButtonDown(string actionName) { }

	// RVA: 0x1AB1BC0 Offset: 0x1AB0DC0 VA: 0x181AB1BC0
	public bool GetButtonDown(int actionId) { }

	// RVA: 0x1AB3C10 Offset: 0x1AB2E10 VA: 0x181AB3C10
	public bool GetButtonUp(string actionName) { }

	// RVA: 0x1AB3B40 Offset: 0x1AB2D40 VA: 0x181AB3B40
	public bool GetButtonUp(int actionId) { }

	// RVA: 0x1AB2240 Offset: 0x1AB1440 VA: 0x181AB2240
	public bool GetButtonPrev(string actionName) { }

	// RVA: 0x1AB2310 Offset: 0x1AB1510 VA: 0x181AB2310
	public bool GetButtonPrev(int actionId) { }

	// RVA: 0x1AB2CD0 Offset: 0x1AB1ED0 VA: 0x181AB2CD0
	public bool GetButtonSinglePressHold(int actionId) { }

	// RVA: 0x1AB2C00 Offset: 0x1AB1E00 VA: 0x181AB2C00
	public bool GetButtonSinglePressHold(string actionName) { }

	// RVA: 0x1AB2A60 Offset: 0x1AB1C60 VA: 0x181AB2A60
	public bool GetButtonSinglePressDown(int actionId) { }

	// RVA: 0x1AB2B30 Offset: 0x1AB1D30 VA: 0x181AB2B30
	public bool GetButtonSinglePressDown(string actionName) { }

	// RVA: 0x1AB2DA0 Offset: 0x1AB1FA0 VA: 0x181AB2DA0
	public bool GetButtonSinglePressUp(int actionId) { }

	// RVA: 0x1AB2E70 Offset: 0x1AB2070 VA: 0x181AB2E70
	public bool GetButtonSinglePressUp(string actionName) { }

	// RVA: 0x1AB15D0 Offset: 0x1AB07D0 VA: 0x181AB15D0
	public bool GetButtonDoublePressHold(string actionName, float speed) { }

	// RVA: 0x1AB16B0 Offset: 0x1AB08B0 VA: 0x181AB16B0
	public bool GetButtonDoublePressHold(int actionId, float speed) { }

	// RVA: 0x1AB1790 Offset: 0x1AB0990 VA: 0x181AB1790
	public bool GetButtonDoublePressHold(string actionName) { }

	// RVA: 0x1AB1500 Offset: 0x1AB0700 VA: 0x181AB1500
	public bool GetButtonDoublePressHold(int actionId) { }

	// RVA: 0x1AB1300 Offset: 0x1AB0500 VA: 0x181AB1300
	public bool GetButtonDoublePressDown(string actionName, float speed) { }

	// RVA: 0x1AB1100 Offset: 0x1AB0300 VA: 0x181AB1100
	public bool GetButtonDoublePressDown(int actionId, float speed) { }

	// RVA: 0x1AB13E0 Offset: 0x1AB05E0 VA: 0x181AB13E0
	public bool GetButtonDoublePressDown(string actionName) { }

	// RVA: 0x1AB11E0 Offset: 0x1AB03E0 VA: 0x181AB11E0
	public bool GetButtonDoublePressDown(int actionId) { }

	// RVA: 0x1AB1930 Offset: 0x1AB0B30 VA: 0x181AB1930
	public bool GetButtonDoublePressUp(string actionName, float speed) { }

	// RVA: 0x1AB1A10 Offset: 0x1AB0C10 VA: 0x181AB1A10
	public bool GetButtonDoublePressUp(int actionId, float speed) { }

	// RVA: 0x1AB1860 Offset: 0x1AB0A60 VA: 0x181AB1860
	public bool GetButtonDoublePressUp(string actionName) { }

	// RVA: 0x1AB1AF0 Offset: 0x1AB0CF0 VA: 0x181AB1AF0
	public bool GetButtonDoublePressUp(int actionId) { }

	// RVA: 0x1AB38A0 Offset: 0x1AB2AA0 VA: 0x181AB38A0
	public bool GetButtonTimedPress(string actionName, float time) { }

	// RVA: 0x1AB37C0 Offset: 0x1AB29C0 VA: 0x181AB37C0
	public bool GetButtonTimedPress(int actionId, float time) { }

	// RVA: 0x1AB3980 Offset: 0x1AB2B80 VA: 0x181AB3980
	public bool GetButtonTimedPress(string actionName, float time, float expireIn) { }

	// RVA: 0x1AB3A60 Offset: 0x1AB2C60 VA: 0x181AB3A60
	public bool GetButtonTimedPress(int actionId, float time, float expireIn) { }

	// RVA: 0x1AB3360 Offset: 0x1AB2560 VA: 0x181AB3360
	public bool GetButtonTimedPressDown(string actionName, float time) { }

	// RVA: 0x1AB3280 Offset: 0x1AB2480 VA: 0x181AB3280
	public bool GetButtonTimedPressDown(int actionId, float time) { }

	// RVA: 0x1AB3600 Offset: 0x1AB2800 VA: 0x181AB3600
	public bool GetButtonTimedPressUp(string actionName, float time) { }

	// RVA: 0x1AB36E0 Offset: 0x1AB28E0 VA: 0x181AB36E0
	public bool GetButtonTimedPressUp(int actionId, float time) { }

	// RVA: 0x1AB3520 Offset: 0x1AB2720 VA: 0x181AB3520
	public bool GetButtonTimedPressUp(string actionName, float time, float expireIn) { }

	// RVA: 0x1AB3440 Offset: 0x1AB2640 VA: 0x181AB3440
	public bool GetButtonTimedPressUp(int actionId, float time, float expireIn) { }

	// RVA: 0x1AB2990 Offset: 0x1AB1B90 VA: 0x181AB2990
	public bool GetButtonShortPress(string actionName) { }

	// RVA: 0x1AB28C0 Offset: 0x1AB1AC0 VA: 0x181AB28C0
	public bool GetButtonShortPress(int actionId) { }

	// RVA: 0x1AB2580 Offset: 0x1AB1780 VA: 0x181AB2580
	public bool GetButtonShortPressDown(string actionName) { }

	// RVA: 0x1AB2650 Offset: 0x1AB1850 VA: 0x181AB2650
	public bool GetButtonShortPressDown(int actionId) { }

	// RVA: 0x1AB2720 Offset: 0x1AB1920 VA: 0x181AB2720
	public bool GetButtonShortPressUp(string actionName) { }

	// RVA: 0x1AB27F0 Offset: 0x1AB19F0 VA: 0x181AB27F0
	public bool GetButtonShortPressUp(int actionId) { }

	// RVA: 0x1AB2170 Offset: 0x1AB1370 VA: 0x181AB2170
	public bool GetButtonLongPress(string actionName) { }

	// RVA: 0x1AB20A0 Offset: 0x1AB12A0 VA: 0x181AB20A0
	public bool GetButtonLongPress(int actionId) { }

	// RVA: 0x1AB1E30 Offset: 0x1AB1030 VA: 0x181AB1E30
	public bool GetButtonLongPressDown(string actionName) { }

	// RVA: 0x1AB1D60 Offset: 0x1AB0F60 VA: 0x181AB1D60
	public bool GetButtonLongPressDown(int actionId) { }

	// RVA: 0x1AB1FD0 Offset: 0x1AB11D0 VA: 0x181AB1FD0
	public bool GetButtonLongPressUp(string actionName) { }

	// RVA: 0x1AB1F00 Offset: 0x1AB1100 VA: 0x181AB1F00
	public bool GetButtonLongPressUp(int actionId) { }

	// RVA: 0x1AB23E0 Offset: 0x1AB15E0 VA: 0x181AB23E0
	public bool GetButtonRepeating(string actionName) { }

	// RVA: 0x1AB24B0 Offset: 0x1AB16B0 VA: 0x181AB24B0
	public bool GetButtonRepeating(int actionId) { }

	// RVA: 0x1AAEB20 Offset: 0x1AADD20 VA: 0x181AAEB20
	public bool GetAnyButton() { }

	// RVA: 0x1AAE940 Offset: 0x1AADB40 VA: 0x181AAE940
	public bool GetAnyButtonDown() { }

	// RVA: 0x1AAEA80 Offset: 0x1AADC80 VA: 0x181AAEA80
	public bool GetAnyButtonUp() { }

	// RVA: 0x1AAE9E0 Offset: 0x1AADBE0 VA: 0x181AAE9E0
	public bool GetAnyButtonPrev() { }

	// RVA: 0x1AB3010 Offset: 0x1AB2210 VA: 0x181AB3010
	public double GetButtonTimePressed(string actionName) { }

	// RVA: 0x1AB2F40 Offset: 0x1AB2140 VA: 0x181AB2F40
	public double GetButtonTimePressed(int actionId) { }

	// RVA: 0x1AB30E0 Offset: 0x1AB22E0 VA: 0x181AB30E0
	public double GetButtonTimeUnpressed(string actionName) { }

	// RVA: 0x1AB31B0 Offset: 0x1AB23B0 VA: 0x181AB31B0
	public double GetButtonTimeUnpressed(int actionId) { }

	// RVA: 0x1AB6BA0 Offset: 0x1AB5DA0 VA: 0x181AB6BA0
	public bool GetNegativeButton(string actionName) { }

	// RVA: 0x1AB6C70 Offset: 0x1AB5E70 VA: 0x181AB6C70
	public bool GetNegativeButton(int actionId) { }

	// RVA: 0x1AB4A80 Offset: 0x1AB3C80 VA: 0x181AB4A80
	public bool GetNegativeButtonDown(string actionName) { }

	// RVA: 0x1AB4B50 Offset: 0x1AB3D50 VA: 0x181AB4B50
	public bool GetNegativeButtonDown(int actionId) { }

	// RVA: 0x1AB6AD0 Offset: 0x1AB5CD0 VA: 0x181AB6AD0
	public bool GetNegativeButtonUp(string actionName) { }

	// RVA: 0x1AB6A00 Offset: 0x1AB5C00 VA: 0x181AB6A00
	public bool GetNegativeButtonUp(int actionId) { }

	// RVA: 0x1AB51D0 Offset: 0x1AB43D0 VA: 0x181AB51D0
	public bool GetNegativeButtonPrev(string actionName) { }

	// RVA: 0x1AB5100 Offset: 0x1AB4300 VA: 0x181AB5100
	public bool GetNegativeButtonPrev(int actionId) { }

	// RVA: 0x1AB5B90 Offset: 0x1AB4D90 VA: 0x181AB5B90
	public bool GetNegativeButtonSinglePressHold(int actionId) { }

	// RVA: 0x1AB5AC0 Offset: 0x1AB4CC0 VA: 0x181AB5AC0
	public bool GetNegativeButtonSinglePressHold(string actionName) { }

	// RVA: 0x1AB5920 Offset: 0x1AB4B20 VA: 0x181AB5920
	public bool GetNegativeButtonSinglePressDown(int actionId) { }

	// RVA: 0x1AB59F0 Offset: 0x1AB4BF0 VA: 0x181AB59F0
	public bool GetNegativeButtonSinglePressDown(string actionName) { }

	// RVA: 0x1AB5D30 Offset: 0x1AB4F30 VA: 0x181AB5D30
	public bool GetNegativeButtonSinglePressUp(int actionId) { }

	// RVA: 0x1AB5C60 Offset: 0x1AB4E60 VA: 0x181AB5C60
	public bool GetNegativeButtonSinglePressUp(string actionName) { }

	// RVA: 0x1AB4640 Offset: 0x1AB3840 VA: 0x181AB4640
	public bool GetNegativeButtonDoublePressHold(string actionName, float speed) { }

	// RVA: 0x1AB4560 Offset: 0x1AB3760 VA: 0x181AB4560
	public bool GetNegativeButtonDoublePressHold(int actionId, float speed) { }

	// RVA: 0x1AB4490 Offset: 0x1AB3690 VA: 0x181AB4490
	public bool GetNegativeButtonDoublePressHold(string actionName) { }

	// RVA: 0x1AB43C0 Offset: 0x1AB35C0 VA: 0x181AB43C0
	public bool GetNegativeButtonDoublePressHold(int actionId) { }

	// RVA: 0x1AB42E0 Offset: 0x1AB34E0 VA: 0x181AB42E0
	public bool GetNegativeButtonDoublePressDown(string actionName, float speed) { }

	// RVA: 0x1AB4060 Offset: 0x1AB3260 VA: 0x181AB4060
	public bool GetNegativeButtonDoublePressDown(int actionId, float speed) { }

	// RVA: 0x1AB4140 Offset: 0x1AB3340 VA: 0x181AB4140
	public bool GetNegativeButtonDoublePressDown(string actionName) { }

	// RVA: 0x1AB4210 Offset: 0x1AB3410 VA: 0x181AB4210
	public bool GetNegativeButtonDoublePressDown(int actionId) { }

	// RVA: 0x1AB48D0 Offset: 0x1AB3AD0 VA: 0x181AB48D0
	public bool GetNegativeButtonDoublePressUp(string actionName, float speed) { }

	// RVA: 0x1AB47F0 Offset: 0x1AB39F0 VA: 0x181AB47F0
	public bool GetNegativeButtonDoublePressUp(int actionId, float speed) { }

	// RVA: 0x1AB49B0 Offset: 0x1AB3BB0 VA: 0x181AB49B0
	public bool GetNegativeButtonDoublePressUp(string actionName) { }

	// RVA: 0x1AB4720 Offset: 0x1AB3920 VA: 0x181AB4720
	public bool GetNegativeButtonDoublePressUp(int actionId) { }

	// RVA: 0x1AB6760 Offset: 0x1AB5960 VA: 0x181AB6760
	public bool GetNegativeButtonTimedPress(string actionName, float time) { }

	// RVA: 0x1AB6680 Offset: 0x1AB5880 VA: 0x181AB6680
	public bool GetNegativeButtonTimedPress(int actionId, float time) { }

	// RVA: 0x1AB6920 Offset: 0x1AB5B20 VA: 0x181AB6920
	public bool GetNegativeButtonTimedPress(string actionName, float time, float expireIn) { }

	// RVA: 0x1AB6840 Offset: 0x1AB5A40 VA: 0x181AB6840
	public bool GetNegativeButtonTimedPress(int actionId, float time, float expireIn) { }

	// RVA: 0x1AB6140 Offset: 0x1AB5340 VA: 0x181AB6140
	public bool GetNegativeButtonTimedPressDown(string actionName, float time) { }

	// RVA: 0x1AB6220 Offset: 0x1AB5420 VA: 0x181AB6220
	public bool GetNegativeButtonTimedPressDown(int actionId, float time) { }

	// RVA: 0x1AB63E0 Offset: 0x1AB55E0 VA: 0x181AB63E0
	public bool GetNegativeButtonTimedPressUp(string actionName, float time) { }

	// RVA: 0x1AB65A0 Offset: 0x1AB57A0 VA: 0x181AB65A0
	public bool GetNegativeButtonTimedPressUp(int actionId, float time) { }

	// RVA: 0x1AB64C0 Offset: 0x1AB56C0 VA: 0x181AB64C0
	public bool GetNegativeButtonTimedPressUp(string actionName, float time, float expireIn) { }

	// RVA: 0x1AB6300 Offset: 0x1AB5500 VA: 0x181AB6300
	public bool GetNegativeButtonTimedPressUp(int actionId, float time, float expireIn) { }

	// RVA: 0x1AB5850 Offset: 0x1AB4A50 VA: 0x181AB5850
	public bool GetNegativeButtonShortPress(string actionName) { }

	// RVA: 0x1AB5780 Offset: 0x1AB4980 VA: 0x181AB5780
	public bool GetNegativeButtonShortPress(int actionId) { }

	// RVA: 0x1AB5510 Offset: 0x1AB4710 VA: 0x181AB5510
	public bool GetNegativeButtonShortPressDown(string actionName) { }

	// RVA: 0x1AB5440 Offset: 0x1AB4640 VA: 0x181AB5440
	public bool GetNegativeButtonShortPressDown(int actionId) { }

	// RVA: 0x1AB55E0 Offset: 0x1AB47E0 VA: 0x181AB55E0
	public bool GetNegativeButtonShortPressUp(string actionName) { }

	// RVA: 0x1AB56B0 Offset: 0x1AB48B0 VA: 0x181AB56B0
	public bool GetNegativeButtonShortPressUp(int actionId) { }

	// RVA: 0x1AB5030 Offset: 0x1AB4230 VA: 0x181AB5030
	public bool GetNegativeButtonLongPress(string actionName) { }

	// RVA: 0x1AB4F60 Offset: 0x1AB4160 VA: 0x181AB4F60
	public bool GetNegativeButtonLongPress(int actionId) { }

	// RVA: 0x1AB4CF0 Offset: 0x1AB3EF0 VA: 0x181AB4CF0
	public bool GetNegativeButtonLongPressDown(string actionName) { }

	// RVA: 0x1AB4C20 Offset: 0x1AB3E20 VA: 0x181AB4C20
	public bool GetNegativeButtonLongPressDown(int actionId) { }

	// RVA: 0x1AB4E90 Offset: 0x1AB4090 VA: 0x181AB4E90
	public bool GetNegativeButtonLongPressUp(string actionName) { }

	// RVA: 0x1AB4DC0 Offset: 0x1AB3FC0 VA: 0x181AB4DC0
	public bool GetNegativeButtonLongPressUp(int actionId) { }

	// RVA: 0x1AB5370 Offset: 0x1AB4570 VA: 0x181AB5370
	public bool GetNegativeButtonRepeating(string actionName) { }

	// RVA: 0x1AB52A0 Offset: 0x1AB44A0 VA: 0x181AB52A0
	public bool GetNegativeButtonRepeating(int actionId) { }

	// RVA: 0x1AAEDA0 Offset: 0x1AADFA0 VA: 0x181AAEDA0
	public bool GetAnyNegativeButton() { }

	// RVA: 0x1AAEBC0 Offset: 0x1AADDC0 VA: 0x181AAEBC0
	public bool GetAnyNegativeButtonDown() { }

	// RVA: 0x1AAED00 Offset: 0x1AADF00 VA: 0x181AAED00
	public bool GetAnyNegativeButtonUp() { }

	// RVA: 0x1AAEC60 Offset: 0x1AADE60 VA: 0x181AAEC60
	public bool GetAnyNegativeButtonPrev() { }

	// RVA: 0x1AB5ED0 Offset: 0x1AB50D0 VA: 0x181AB5ED0
	public double GetNegativeButtonTimePressed(string actionName) { }

	// RVA: 0x1AB5E00 Offset: 0x1AB5000 VA: 0x181AB5E00
	public double GetNegativeButtonTimePressed(int actionId) { }

	// RVA: 0x1AB5FA0 Offset: 0x1AB51A0 VA: 0x181AB5FA0
	public double GetNegativeButtonTimeUnpressed(string actionName) { }

	// RVA: 0x1AB6070 Offset: 0x1AB5270 VA: 0x181AB6070
	public double GetNegativeButtonTimeUnpressed(int actionId) { }

	// RVA: 0x1AB0F60 Offset: 0x1AB0160 VA: 0x181AB0F60
	public float GetAxis(string actionName) { }

	// RVA: 0x1AB1030 Offset: 0x1AB0230 VA: 0x181AB1030
	public float GetAxis(int actionId) { }

	// RVA: 0x1AB0A80 Offset: 0x1AAFC80 VA: 0x181AB0A80
	public float GetAxisRaw(string actionName) { }

	// RVA: 0x1AB0B50 Offset: 0x1AAFD50 VA: 0x181AB0B50
	public float GetAxisRaw(int actionId) { }

	// RVA: 0x1AAFFF0 Offset: 0x1AAF1F0 VA: 0x181AAFFF0
	public float GetAxisPrev(string actionName) { }

	// RVA: 0x1AAFF20 Offset: 0x1AAF120 VA: 0x181AAFF20
	public float GetAxisPrev(int actionId) { }

	// RVA: 0x1AB0670 Offset: 0x1AAF870 VA: 0x181AB0670
	public float GetAxisRawPrev(string actionName) { }

	// RVA: 0x1AB05A0 Offset: 0x1AAF7A0 VA: 0x181AB05A0
	public float GetAxisRawPrev(int actionId) { }

	// RVA: 0x1AAFD80 Offset: 0x1AAEF80 VA: 0x181AAFD80
	public float GetAxisDelta(string actionName) { }

	// RVA: 0x1AAFE50 Offset: 0x1AAF050 VA: 0x181AAFE50
	public float GetAxisDelta(int actionId) { }

	// RVA: 0x1AB04D0 Offset: 0x1AAF6D0 VA: 0x181AB04D0
	public float GetAxisRawDelta(string actionName) { }

	// RVA: 0x1AB0400 Offset: 0x1AAF600 VA: 0x181AB0400
	public float GetAxisRawDelta(int actionId) { }

	// RVA: 0x1AAF8C0 Offset: 0x1AAEAC0 VA: 0x181AAF8C0
	public Vector2 GetAxis2D(string xAxisActionName, string yAxisActionName) { }

	// RVA: 0x1AAF740 Offset: 0x1AAE940 VA: 0x181AAF740
	public Vector2 GetAxis2D(int xAxisActionId, int yAxisActionId) { }

	// RVA: 0x1AAEFC0 Offset: 0x1AAE1C0 VA: 0x181AAEFC0
	public Vector2 GetAxis2DPrev(string xAxisActionName, string yAxisActionName) { }

	// RVA: 0x1AAEE40 Offset: 0x1AAE040 VA: 0x181AAEE40
	public Vector2 GetAxis2DPrev(int xAxisActionId, int yAxisActionId) { }

	// RVA: 0x1AAF5C0 Offset: 0x1AAE7C0 VA: 0x181AAF5C0
	public Vector2 GetAxis2DRaw(string xAxisActionName, string yAxisActionName) { }

	// RVA: 0x1AAF440 Offset: 0x1AAE640 VA: 0x181AAF440
	public Vector2 GetAxis2DRaw(int xAxisActionId, int yAxisActionId) { }

	// RVA: 0x1AAF140 Offset: 0x1AAE340 VA: 0x181AAF140
	public Vector2 GetAxis2DRawPrev(string xAxisActionName, string yAxisActionName) { }

	// RVA: 0x1AAF2C0 Offset: 0x1AAE4C0 VA: 0x181AAF2C0
	public Vector2 GetAxis2DRawPrev(int xAxisActionId, int yAxisActionId) { }

	// RVA: 0x1AB0C20 Offset: 0x1AAFE20 VA: 0x181AB0C20
	public double GetAxisTimeActive(string actionName) { }

	// RVA: 0x1AB0CF0 Offset: 0x1AAFEF0 VA: 0x181AB0CF0
	public double GetAxisTimeActive(int actionId) { }

	// RVA: 0x1AB0E90 Offset: 0x1AB0090 VA: 0x181AB0E90
	public double GetAxisTimeInactive(string actionName) { }

	// RVA: 0x1AB0DC0 Offset: 0x1AAFFC0 VA: 0x181AB0DC0
	public double GetAxisTimeInactive(int actionId) { }

	// RVA: 0x1AB0740 Offset: 0x1AAF940 VA: 0x181AB0740
	public double GetAxisRawTimeActive(string actionName) { }

	// RVA: 0x1AB0810 Offset: 0x1AAFA10 VA: 0x181AB0810
	public double GetAxisRawTimeActive(int actionId) { }

	// RVA: 0x1AB09B0 Offset: 0x1AAFBB0 VA: 0x181AB09B0
	public double GetAxisRawTimeInactive(string actionName) { }

	// RVA: 0x1AB08E0 Offset: 0x1AAFAE0 VA: 0x181AB08E0
	public double GetAxisRawTimeInactive(int actionId) { }

	// RVA: 0x1AAFCB0 Offset: 0x1AAEEB0 VA: 0x181AAFCB0
	public AxisCoordinateMode GetAxisCoordinateMode(string actionName) { }

	// RVA: 0x1AAFBE0 Offset: 0x1AAEDE0 VA: 0x181AAFBE0
	public AxisCoordinateMode GetAxisCoordinateMode(int actionId) { }

	// RVA: 0x1AB0330 Offset: 0x1AAF530 VA: 0x181AB0330
	public AxisCoordinateMode GetAxisRawCoordinateMode(string actionName) { }

	// RVA: 0x1AB0260 Offset: 0x1AAF460 VA: 0x181AB0260
	public AxisCoordinateMode GetAxisRawCoordinateMode(int actionId) { }

	// RVA: 0x1AAFA40 Offset: 0x1AAEC40 VA: 0x181AAFA40
	public AxisCoordinateMode GetAxisCoordinateModePrev(string actionName) { }

	// RVA: 0x1AAFB10 Offset: 0x1AAED10 VA: 0x181AAFB10
	public AxisCoordinateMode GetAxisCoordinateModePrev(int actionId) { }

	// RVA: 0x1AB0190 Offset: 0x1AAF390 VA: 0x181AB0190
	public AxisCoordinateMode GetAxisRawCoordinateModePrev(string actionName) { }

	// RVA: 0x1AB00C0 Offset: 0x1AAF2C0 VA: 0x181AB00C0
	public AxisCoordinateMode GetAxisRawCoordinateModePrev(int actionId) { }

	// RVA: 0x1AB3E80 Offset: 0x1AB3080 VA: 0x181AB3E80
	public IList<InputActionSourceData> GetCurrentInputSources(string actionName) { }

	// RVA: 0x1AB3F70 Offset: 0x1AB3170 VA: 0x181AB3F70
	public IList<InputActionSourceData> GetCurrentInputSources(int actionId) { }

	// RVA: 0x1AB7510 Offset: 0x1AB6710 VA: 0x181AB7510
	public bool IsCurrentInputSource(string actionName, ControllerType controllerType) { }

	// RVA: 0x1AB7430 Offset: 0x1AB6630 VA: 0x181AB7430
	public bool IsCurrentInputSource(int actionId, ControllerType controllerType) { }

	// RVA: 0x1AB7270 Offset: 0x1AB6470 VA: 0x181AB7270
	public bool IsCurrentInputSource(string actionName, ControllerType controllerType, int controllerId) { }

	// RVA: 0x1AB75F0 Offset: 0x1AB67F0 VA: 0x181AB75F0
	public bool IsCurrentInputSource(int actionId, ControllerType controllerType, int controllerId) { }

	// RVA: 0x1AB7190 Offset: 0x1AB6390 VA: 0x181AB7190
	public bool IsCurrentInputSource(string actionName, Controller controller) { }

	// RVA: 0x1AB7350 Offset: 0x1AB6550 VA: 0x181AB7350
	public bool IsCurrentInputSource(int actionId, Controller controller) { }

	// RVA: 0x1AAE590 Offset: 0x1AAD790 VA: 0x181AAE590
	public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop) { }

	// RVA: 0x1AAE1B0 Offset: 0x1AAD3B0 VA: 0x181AAE1B0
	public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, int actionId) { }

	// RVA: 0x1AADCB0 Offset: 0x1AACEB0 VA: 0x181AADCB0
	public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, string actionName) { }

	// RVA: 0x1AAE070 Offset: 0x1AAD270 VA: 0x181AAE070
	public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType) { }

	// RVA: 0x1AAE810 Offset: 0x1AADA10 VA: 0x181AAE810
	public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, int actionId) { }

	// RVA: 0x1AAE420 Offset: 0x1AAD620 VA: 0x181AAE420
	public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, string actionName) { }

	// RVA: 0x1AAE2E0 Offset: 0x1AAD4E0 VA: 0x181AAE2E0
	public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, object[] arguments) { }

	// RVA: 0x1AAE6C0 Offset: 0x1AAD8C0 VA: 0x181AAE6C0
	public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, int actionId, object[] arguments) { }

	// RVA: 0x1AADEF0 Offset: 0x1AAD0F0 VA: 0x181AADEF0
	public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, string actionName, object[] arguments) { }

	// RVA: 0x1AB7BD0 Offset: 0x1AB6DD0 VA: 0x181AB7BD0
	public void RemoveInputEventDelegate(Action<InputActionEventData> callback) { }

	// RVA: 0x1AB7CE0 Offset: 0x1AB6EE0 VA: 0x181AB7CE0
	public void RemoveInputEventDelegate(Action<InputActionEventData> callback, int actionId) { }

	// RVA: 0x1AB7990 Offset: 0x1AB6B90 VA: 0x181AB7990
	public void RemoveInputEventDelegate(Action<InputActionEventData> callback, string actionName) { }

	// RVA: 0x1AB7730 Offset: 0x1AB6930 VA: 0x181AB7730
	public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop) { }

	// RVA: 0x1AB82B0 Offset: 0x1AB74B0 VA: 0x181AB82B0
	public void RemoveInputEventDelegate(Action<InputActionEventData> callback, InputActionEventType eventType) { }

	// RVA: 0x1AB8180 Offset: 0x1AB7380 VA: 0x181AB8180
	public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, int actionId) { }

	// RVA: 0x1AB7E10 Offset: 0x1AB7010 VA: 0x181AB7E10
	public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, string actionName) { }

	// RVA: 0x1AB7860 Offset: 0x1AB6A60 VA: 0x181AB7860
	public void RemoveInputEventDelegate(Action<InputActionEventData> callback, InputActionEventType eventType, int actionId) { }

	// RVA: 0x1AB8780 Offset: 0x1AB7980 VA: 0x181AB8780
	public void RemoveInputEventDelegate(Action<InputActionEventData> callback, InputActionEventType eventType, string actionName) { }

	// RVA: 0x1AB8050 Offset: 0x1AB7250 VA: 0x181AB8050
	public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType) { }

	// RVA: 0x1AB83E0 Offset: 0x1AB75E0 VA: 0x181AB83E0
	public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, int actionId) { }

	// RVA: 0x1AB8520 Offset: 0x1AB7720 VA: 0x181AB8520
	public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, string actionName) { }

	// RVA: 0x1AAE840 Offset: 0x1AADA40 VA: 0x181AAE840
	public void ClearInputEventDelegates() { }

	// RVA: 0x1AB8C30 Offset: 0x1AB7E30 VA: 0x181AB8C30
	public void SetVibration(int motorIndex, float motorLevel) { }

	// RVA: 0x1AB8C10 Offset: 0x1AB7E10 VA: 0x181AB8C10
	public void SetVibration(int motorIndex, float motorLevel, float duration) { }

	// RVA: 0x1AB8C50 Offset: 0x1AB7E50 VA: 0x181AB8C50
	public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors) { }

	// RVA: 0x1AB89F0 Offset: 0x1AB7BF0 VA: 0x181AB89F0
	public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors) { }

	// RVA: 0x1AB6F90 Offset: 0x1AB6190 VA: 0x181AB6F90
	public float GetVibration(int motorIndex) { }

	// RVA: 0x1AB8C70 Offset: 0x1AB7E70 VA: 0x181AB8C70
	public void StopVibration() { }

	// RVA: 0x1AB7700 Offset: 0x1AB6900 VA: 0x181AB7700
	internal void PKwtxaXvImPLSHYDPPVYFvKIgugQ() { }

	// RVA: 0x1AB7700 Offset: 0x1AB6900 VA: 0x181AB7700
	private void ZFUcTEcndvHgBpdTmEAgSebxfOsJ() { }
}

// Namespace: 
[Browsable(False)]
[EditorBrowsable(1)]
public sealed class ReInput.LocalizationHelper : CodeHelper // TypeDefIndex: 7100
{
	// Fields
	private static ReInput.LocalizationHelper jvdHJASpnUhImEOGQmsLnMbcfiVcb; // 0x0

	// Properties
	internal static ReInput.LocalizationHelper IqfZanOvDqIvuKavjaRjEeSYywMMA { get; }
	public ILocalizedStringProvider localizedStringProvider { get; set; }
	public bool prefetch { get; set; }

	// Methods

	// RVA: 0x1ADFFC0 Offset: 0x1ADF1C0 VA: 0x181ADFFC0
	internal static ReInput.LocalizationHelper VVXeCKIxYsdqpsQBhcKFeXVpnNTJ() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x1AE0030 Offset: 0x1ADF230 VA: 0x181AE0030
	internal static void avIxHANeLyGlNqQQYzcBYPreuVPw() { }

	// RVA: 0x1AE0070 Offset: 0x1ADF270 VA: 0x181AE0070
	public ILocalizedStringProvider get_localizedStringProvider() { }

	// RVA: 0x1AE0130 Offset: 0x1ADF330 VA: 0x181AE0130
	public void set_localizedStringProvider(ILocalizedStringProvider value) { }

	// RVA: 0x1AE00D0 Offset: 0x1ADF2D0 VA: 0x181AE00D0
	public bool get_prefetch() { }

	// RVA: 0x1AE0190 Offset: 0x1ADF390 VA: 0x181AE0190
	public void set_prefetch(bool value) { }

	// RVA: 0x1ADFF70 Offset: 0x1ADF170 VA: 0x181ADFF70
	public void Reload() { }
}

// Namespace: 
[EditorBrowsable(1)]
[Browsable(False)]
public sealed class ReInput.GlyphHelper : CodeHelper // TypeDefIndex: 7101
{
	// Fields
	private static ReInput.GlyphHelper jvdHJASpnUhImEOGQmsLnMbcfiVcb; // 0x0

	// Properties
	internal static ReInput.GlyphHelper IqfZanOvDqIvuKavjaRjEeSYywMMA { get; }
	public IGlyphProvider glyphProvider { get; set; }
	public bool prefetch { get; set; }

	// Methods

	// RVA: 0x1ADE880 Offset: 0x1ADDA80 VA: 0x181ADE880
	internal static ReInput.GlyphHelper VVXeCKIxYsdqpsQBhcKFeXVpnNTJ() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x1ADE8F0 Offset: 0x1ADDAF0 VA: 0x181ADE8F0
	internal static void avIxHANeLyGlNqQQYzcBYPreuVPw() { }

	// RVA: 0x1ADE930 Offset: 0x1ADDB30 VA: 0x181ADE930
	public IGlyphProvider get_glyphProvider() { }

	// RVA: 0x1ADE9F0 Offset: 0x1ADDBF0 VA: 0x181ADE9F0
	public void set_glyphProvider(IGlyphProvider value) { }

	// RVA: 0x1ADE990 Offset: 0x1ADDB90 VA: 0x181ADE990
	public bool get_prefetch() { }

	// RVA: 0x1ADEA50 Offset: 0x1ADDC50 VA: 0x181ADEA50
	public void set_prefetch(bool value) { }

	// RVA: 0x1ADE830 Offset: 0x1ADDA30 VA: 0x181ADE830
	public void Reload() { }
}

// Namespace: 
[Browsable(False)]
[EditorBrowsable(1)]
public sealed class ReInput.ConfigHelper : CodeHelper // TypeDefIndex: 7102
{
	// Fields
	private static ReInput.ConfigHelper jvdHJASpnUhImEOGQmsLnMbcfiVcb; // 0x0
	private float DUNEqbHEmzLrRoClmDNkpwtVFvfeA; // 0x10
	private float oeqIgtFJDrTtifJKDKAaXQcGOBWRA; // 0x14

	// Properties
	internal static ReInput.ConfigHelper IqfZanOvDqIvuKavjaRjEeSYywMMA { get; }
	public bool useXInput { get; set; }
	public bool useWindowsGamingInput { get; set; }
	public UpdateMode updateMode { get; set; }
	public UpdateLoopSetting updateLoop { get; set; }
	public WindowsStandalonePrimaryInputSource windowsStandalonePrimaryInputSource { get; set; }
	public OSXStandalonePrimaryInputSource osxStandalonePrimaryInputSource { get; set; }
	public LinuxStandalonePrimaryInputSource linuxStandalonePrimaryInputSource { get; set; }
	public WindowsUWPPrimaryInputSource windowsUWPPrimaryInputSource { get; set; }
	public bool windowsUWPSupportHIDDevices { get; set; }
	public bool windowsUWPSupportGamepads { get; set; }
	public bool useAppleGameControllerFramework { get; set; }
	public XboxOnePrimaryInputSource xboxOnePrimaryInputSource { get; set; }
	public PS4PrimaryInputSource ps4PrimaryInputSource { get; set; }
	public WebGLPrimaryInputSource webGLPrimaryInputSource { get; set; }
	public bool alwaysUseUnityInput { get; set; }
	public bool disableNativeInput { get; set; }
	public bool nativeMouseSupport { get; set; }
	public bool nativeKeyboardSupport { get; set; }
	public bool enhancedDeviceSupport { get; set; }
	public int joystickRefreshRate { get; set; }
	public bool ignoreInputWhenAppNotInFocus { get; set; }
	public bool android_supportUnknownGamepads { get; set; }
	public DeadZone2DType defaultJoystickAxis2DDeadZoneType { get; set; }
	public AxisSensitivity2DType defaultJoystickAxis2DSensitivityType { get; set; }
	public AxisSensitivityType defaultAxisSensitivityType { get; set; }
	public bool force4WayHats { get; set; }
	public float defaultAbsoluteAxisPollingDeadZone { get; set; }
	public float defaultRelativeAxisPollingDeadZone { get; set; }
	public bool activateActionButtonsOnNegativeValue { get; set; }
	public ThrottleCalibrationMode throttleCalibrationMode { get; set; }
	public bool deferControllerConnectedEventsOnStart { get; set; }
	public KeyCombinationOverrideMode keyCombinationOverrideMode { get; set; }
	public bool generateKeyEventsOnKeyCombinationOverride { get; set; }
	public bool autoAssignJoysticks { get; set; }
	public int maxJoysticksPerPlayer { get; set; }
	public bool distributeJoysticksEvenly { get; set; }
	public bool assignJoysticksToPlayingPlayersOnly { get; set; }
	public bool reassignJoystickToPreviousOwnerOnReconnect { get; set; }
	public LogLevelFlags logLevel { get; set; }
	public List<EnhancedDeviceSupportDeviceType> enhancedDeviceSupportExcludedDeviceTypes { get; set; }

	// Methods

	// RVA: 0x1AD9260 Offset: 0x1AD8460 VA: 0x181AD9260
	internal static ReInput.ConfigHelper VVXeCKIxYsdqpsQBhcKFeXVpnNTJ() { }

	// RVA: 0x1AD92E0 Offset: 0x1AD84E0 VA: 0x181AD92E0
	private void .ctor() { }

	// RVA: 0x1ADA6E0 Offset: 0x1AD98E0 VA: 0x181ADA6E0
	public bool get_useXInput() { }

	// RVA: 0x1ADCFC0 Offset: 0x1ADC1C0 VA: 0x181ADCFC0
	public void set_useXInput(bool value) { }

	// RVA: 0x1ADA590 Offset: 0x1AD9790 VA: 0x181ADA590
	public bool get_useWindowsGamingInput() { }

	// RVA: 0x1ADCB80 Offset: 0x1ADBD80 VA: 0x181ADCB80
	public void set_useWindowsGamingInput(bool value) { }

	// RVA: 0x1ADA400 Offset: 0x1AD9600 VA: 0x181ADA400
	public UpdateMode get_updateMode() { }

	// RVA: 0x1ADC8C0 Offset: 0x1ADBAC0 VA: 0x181ADC8C0
	public void set_updateMode(UpdateMode value) { }

	// RVA: 0x1ADA370 Offset: 0x1AD9570 VA: 0x181ADA370
	public UpdateLoopSetting get_updateLoop() { }

	// RVA: 0x1ADC760 Offset: 0x1ADB960 VA: 0x181ADC760
	public void set_updateLoop(UpdateLoopSetting value) { }

	// RVA: 0x1ADA8C0 Offset: 0x1AD9AC0 VA: 0x181ADA8C0
	public WindowsStandalonePrimaryInputSource get_windowsStandalonePrimaryInputSource() { }

	// RVA: 0x1ADD550 Offset: 0x1ADC750 VA: 0x181ADD550
	public void set_windowsStandalonePrimaryInputSource(WindowsStandalonePrimaryInputSource value) { }

	// RVA: 0x1ADA120 Offset: 0x1AD9320 VA: 0x181ADA120
	public OSXStandalonePrimaryInputSource get_osxStandalonePrimaryInputSource() { }

	// RVA: 0x1ADC300 Offset: 0x1ADB500 VA: 0x181ADC300
	public void set_osxStandalonePrimaryInputSource(OSXStandalonePrimaryInputSource value) { }

	// RVA: 0x1AD9E50 Offset: 0x1AD9050 VA: 0x181AD9E50
	public LinuxStandalonePrimaryInputSource get_linuxStandalonePrimaryInputSource() { }

	// RVA: 0x1ADBD80 Offset: 0x1ADAF80 VA: 0x181ADBD80
	public void set_linuxStandalonePrimaryInputSource(LinuxStandalonePrimaryInputSource value) { }

	// RVA: 0x1ADA950 Offset: 0x1AD9B50 VA: 0x181ADA950
	public WindowsUWPPrimaryInputSource get_windowsUWPPrimaryInputSource() { }

	// RVA: 0x1ADD730 Offset: 0x1ADC930 VA: 0x181ADD730
	public void set_windowsUWPPrimaryInputSource(WindowsUWPPrimaryInputSource value) { }

	// RVA: 0x1ADAB20 Offset: 0x1AD9D20 VA: 0x181ADAB20
	public bool get_windowsUWPSupportHIDDevices() { }

	// RVA: 0x1ADDA30 Offset: 0x1ADCC30 VA: 0x181ADDA30
	public void set_windowsUWPSupportHIDDevices(bool value) { }

	// RVA: 0x1ADA9E0 Offset: 0x1AD9BE0 VA: 0x181ADA9E0
	public bool get_windowsUWPSupportGamepads() { }

	// RVA: 0x1ADD880 Offset: 0x1ADCA80 VA: 0x181ADD880
	public void set_windowsUWPSupportGamepads(bool value) { }

	// RVA: 0x1ADA490 Offset: 0x1AD9690 VA: 0x181ADA490
	public bool get_useAppleGameControllerFramework() { }

	// RVA: 0x1ADCA10 Offset: 0x1ADBC10 VA: 0x181ADCA10
	public void set_useAppleGameControllerFramework(bool value) { }

	// RVA: 0x1ADAC60 Offset: 0x1AD9E60 VA: 0x181ADAC60
	public XboxOnePrimaryInputSource get_xboxOnePrimaryInputSource() { }

	// RVA: 0x1ADDBE0 Offset: 0x1ADCDE0 VA: 0x181ADDBE0
	public void set_xboxOnePrimaryInputSource(XboxOnePrimaryInputSource value) { }

	// RVA: 0x1ADA1B0 Offset: 0x1AD93B0 VA: 0x181ADA1B0
	public PS4PrimaryInputSource get_ps4PrimaryInputSource() { }

	// RVA: 0x1ADC450 Offset: 0x1ADB650 VA: 0x181ADC450
	public void set_ps4PrimaryInputSource(PS4PrimaryInputSource value) { }

	// RVA: 0x1ADA830 Offset: 0x1AD9A30 VA: 0x181ADA830
	public WebGLPrimaryInputSource get_webGLPrimaryInputSource() { }

	// RVA: 0x1ADD400 Offset: 0x1ADC600 VA: 0x181ADD400
	public void set_webGLPrimaryInputSource(WebGLPrimaryInputSource value) { }

	// RVA: 0x1AD93A0 Offset: 0x1AD85A0 VA: 0x181AD93A0
	public bool get_alwaysUseUnityInput() { }

	// RVA: 0x1ADADC0 Offset: 0x1AD9FC0 VA: 0x181ADADC0
	public void set_alwaysUseUnityInput(bool value) { }

	// RVA: 0x1AD93A0 Offset: 0x1AD85A0 VA: 0x181AD93A0
	public bool get_disableNativeInput() { }

	// RVA: 0x1ADADC0 Offset: 0x1AD9FC0 VA: 0x181ADADC0
	public void set_disableNativeInput(bool value) { }

	// RVA: 0x1ADA090 Offset: 0x1AD9290 VA: 0x181ADA090
	public bool get_nativeMouseSupport() { }

	// RVA: 0x1ADC1C0 Offset: 0x1ADB3C0 VA: 0x181ADC1C0
	public void set_nativeMouseSupport(bool value) { }

	// RVA: 0x1ADA000 Offset: 0x1AD9200 VA: 0x181ADA000
	public bool get_nativeKeyboardSupport() { }

	// RVA: 0x1ADC080 Offset: 0x1ADB280 VA: 0x181ADC080
	public void set_nativeKeyboardSupport(bool value) { }

	// RVA: 0x1AD9AE0 Offset: 0x1AD8CE0 VA: 0x181AD9AE0
	public bool get_enhancedDeviceSupport() { }

	// RVA: 0x1ADB810 Offset: 0x1ADAA10 VA: 0x181ADB810
	public void set_enhancedDeviceSupport(bool value) { }

	// RVA: 0x1AD9D30 Offset: 0x1AD8F30 VA: 0x181AD9D30
	public int get_joystickRefreshRate() { }

	// RVA: 0x1ADBC00 Offset: 0x1ADAE00 VA: 0x181ADBC00
	public void set_joystickRefreshRate(int value) { }

	// RVA: 0x1AD9CA0 Offset: 0x1AD8EA0 VA: 0x181AD9CA0
	public bool get_ignoreInputWhenAppNotInFocus() { }

	// RVA: 0x1ADBAE0 Offset: 0x1ADACE0 VA: 0x181ADBAE0
	public void set_ignoreInputWhenAppNotInFocus(bool value) { }

	// RVA: 0x1AD9430 Offset: 0x1AD8630 VA: 0x181AD9430
	public bool get_android_supportUnknownGamepads() { }

	// RVA: 0x1ADAF10 Offset: 0x1ADA110 VA: 0x181ADAF10
	public void set_android_supportUnknownGamepads(bool value) { }

	// RVA: 0x1AD96F0 Offset: 0x1AD88F0 VA: 0x181AD96F0
	public DeadZone2DType get_defaultJoystickAxis2DDeadZoneType() { }

	// RVA: 0x1ADB340 Offset: 0x1ADA540 VA: 0x181ADB340
	public void set_defaultJoystickAxis2DDeadZoneType(DeadZone2DType value) { }

	// RVA: 0x1AD9790 Offset: 0x1AD8990 VA: 0x181AD9790
	public AxisSensitivity2DType get_defaultJoystickAxis2DSensitivityType() { }

	// RVA: 0x1ADB410 Offset: 0x1ADA610 VA: 0x181ADB410
	public void set_defaultJoystickAxis2DSensitivityType(AxisSensitivity2DType value) { }

	// RVA: 0x1AD9660 Offset: 0x1AD8860 VA: 0x181AD9660
	public AxisSensitivityType get_defaultAxisSensitivityType() { }

	// RVA: 0x1ADB270 Offset: 0x1ADA470 VA: 0x181ADB270
	public void set_defaultAxisSensitivityType(AxisSensitivityType value) { }

	// RVA: 0x1AD9B70 Offset: 0x1AD8D70 VA: 0x181AD9B70
	public bool get_force4WayHats() { }

	// RVA: 0x1ADB950 Offset: 0x1ADAB50 VA: 0x181ADB950
	public void set_force4WayHats(bool value) { }

	// RVA: 0x1AD9600 Offset: 0x1AD8800 VA: 0x181AD9600
	public float get_defaultAbsoluteAxisPollingDeadZone() { }

	// RVA: 0x1ADB200 Offset: 0x1ADA400 VA: 0x181ADB200
	public void set_defaultAbsoluteAxisPollingDeadZone(float value) { }

	// RVA: 0x1AD9820 Offset: 0x1AD8A20 VA: 0x181AD9820
	public float get_defaultRelativeAxisPollingDeadZone() { }

	// RVA: 0x1ADB4E0 Offset: 0x1ADA6E0 VA: 0x181ADB4E0
	public void set_defaultRelativeAxisPollingDeadZone(float value) { }

	// RVA: 0x1AD9300 Offset: 0x1AD8500 VA: 0x181AD9300
	public bool get_activateActionButtonsOnNegativeValue() { }

	// RVA: 0x1ADACF0 Offset: 0x1AD9EF0 VA: 0x181ADACF0
	public void set_activateActionButtonsOnNegativeValue(bool value) { }

	// RVA: 0x1ADA2E0 Offset: 0x1AD94E0 VA: 0x181ADA2E0
	public ThrottleCalibrationMode get_throttleCalibrationMode() { }

	// RVA: 0x1ADC670 Offset: 0x1ADB870 VA: 0x181ADC670
	public void set_throttleCalibrationMode(ThrottleCalibrationMode value) { }

	// RVA: 0x1AD9880 Offset: 0x1AD8A80 VA: 0x181AD9880
	public bool get_deferControllerConnectedEventsOnStart() { }

	// RVA: 0x1ADB550 Offset: 0x1ADA750 VA: 0x181ADB550
	public void set_deferControllerConnectedEventsOnStart(bool value) { }

	// RVA: 0x1AD9DC0 Offset: 0x1AD8FC0 VA: 0x181AD9DC0
	public KeyCombinationOverrideMode get_keyCombinationOverrideMode() { }

	// RVA: 0x1ADBCC0 Offset: 0x1ADAEC0 VA: 0x181ADBCC0
	public void set_keyCombinationOverrideMode(KeyCombinationOverrideMode value) { }

	// RVA: 0x1AD9C10 Offset: 0x1AD8E10 VA: 0x181AD9C10
	public bool get_generateKeyEventsOnKeyCombinationOverride() { }

	// RVA: 0x1ADBA20 Offset: 0x1ADAC20 VA: 0x181ADBA20
	public void set_generateKeyEventsOnKeyCombinationOverride(bool value) { }

	// RVA: 0x1AD9560 Offset: 0x1AD8760 VA: 0x181AD9560
	public bool get_autoAssignJoysticks() { }

	// RVA: 0x1ADB130 Offset: 0x1ADA330 VA: 0x181ADB130
	public void set_autoAssignJoysticks(bool value) { }

	// RVA: 0x1AD9F70 Offset: 0x1AD9170 VA: 0x181AD9F70
	public int get_maxJoysticksPerPlayer() { }

	// RVA: 0x1ADBFA0 Offset: 0x1ADB1A0 VA: 0x181ADBFA0
	public void set_maxJoysticksPerPlayer(int value) { }

	// RVA: 0x1AD9920 Offset: 0x1AD8B20 VA: 0x181AD9920
	public bool get_distributeJoysticksEvenly() { }

	// RVA: 0x1ADB620 Offset: 0x1ADA820 VA: 0x181ADB620
	public void set_distributeJoysticksEvenly(bool value) { }

	// RVA: 0x1AD94C0 Offset: 0x1AD86C0 VA: 0x181AD94C0
	public bool get_assignJoysticksToPlayingPlayersOnly() { }

	// RVA: 0x1ADB060 Offset: 0x1ADA260 VA: 0x181ADB060
	public void set_assignJoysticksToPlayingPlayersOnly(bool value) { }

	// RVA: 0x1ADA240 Offset: 0x1AD9440 VA: 0x181ADA240
	public bool get_reassignJoystickToPreviousOwnerOnReconnect() { }

	// RVA: 0x1ADC5A0 Offset: 0x1ADB7A0 VA: 0x181ADC5A0
	public void set_reassignJoystickToPreviousOwnerOnReconnect(bool value) { }

	// RVA: 0x1AD9EE0 Offset: 0x1AD90E0 VA: 0x181AD9EE0
	public LogLevelFlags get_logLevel() { }

	// RVA: 0x1ADBED0 Offset: 0x1ADB0D0 VA: 0x181ADBED0
	public void set_logLevel(LogLevelFlags value) { }

	// RVA: 0x1AD99C0 Offset: 0x1AD8BC0 VA: 0x181AD99C0
	public List<EnhancedDeviceSupportDeviceType> get_enhancedDeviceSupportExcludedDeviceTypes() { }

	// RVA: 0x1ADB6F0 Offset: 0x1ADA8F0 VA: 0x181ADB6F0
	public void set_enhancedDeviceSupportExcludedDeviceTypes(List<EnhancedDeviceSupportDeviceType> value) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReInput.ControllerHelper.PollingHelper.TWDeMKJWtOSSnPgnRpRMdLYaDJKCc : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7103
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	public ReInput.ControllerHelper.PollingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x58
	private IEnumerator<ControllerPollingInfo> BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x60

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1903CE0 Offset: 0x1902EE0 VA: 0x181903CE0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19034F0 Offset: 0x19026F0 VA: 0x1819034F0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1903EA0 Offset: 0x19030A0 VA: 0x181903EA0
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	// RVA: 0x1903B20 Offset: 0x1902D20 VA: 0x181903B20
	private void NliQpQwAufCfLWbPmVSuBlrEIiqh() { }

	// RVA: 0x1903AD0 Offset: 0x1902CD0 VA: 0x181903AD0
	private void NQQCEqOatqBXkeZBWqozdvFrSLAM() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1903C30 Offset: 0x1902E30 VA: 0x181903C30 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1903C70 Offset: 0x1902E70 VA: 0x181903C70 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1903B70 Offset: 0x1902D70 VA: 0x181903B70 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1903B70 Offset: 0x1902D70 VA: 0x181903B70 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReInput.ControllerHelper.PollingHelper.xsuJBFfqqDExKCZCEOmDJiiWaqxdA : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7104
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	public ReInput.ControllerHelper.PollingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x58
	private IEnumerator<ControllerPollingInfo> BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x60

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x190A080 Offset: 0x1909280 VA: 0x18190A080 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1909700 Offset: 0x1908900 VA: 0x181909700 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x190A2C0 Offset: 0x19094C0 VA: 0x18190A2C0
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	// RVA: 0x1909EC0 Offset: 0x19090C0 VA: 0x181909EC0
	private void NliQpQwAufCfLWbPmVSuBlrEIiqh() { }

	// RVA: 0x1909E70 Offset: 0x1909070 VA: 0x181909E70
	private void NQQCEqOatqBXkeZBWqozdvFrSLAM() { }

	// RVA: 0x19096B0 Offset: 0x19088B0 VA: 0x1819096B0
	private void LZQbYTdqAygePDpftiYBQKARhQSIA() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1909FD0 Offset: 0x19091D0 VA: 0x181909FD0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x190A010 Offset: 0x1909210 VA: 0x18190A010 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1909F10 Offset: 0x1909110 VA: 0x181909F10 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1909F10 Offset: 0x1909110 VA: 0x181909F10 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReInput.ControllerHelper.PollingHelper.dQRFrHtkAKMEPThmOzXAbbxFvocO : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7105
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	public ReInput.ControllerHelper.PollingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x58
	private IEnumerator<ControllerPollingInfo> BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x60

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1906610 Offset: 0x1905810 VA: 0x181906610 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1905C90 Offset: 0x1904E90 VA: 0x181905C90 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1906850 Offset: 0x1905A50 VA: 0x181906850
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	// RVA: 0x1906450 Offset: 0x1905650 VA: 0x181906450
	private void NliQpQwAufCfLWbPmVSuBlrEIiqh() { }

	// RVA: 0x1906400 Offset: 0x1905600 VA: 0x181906400
	private void NQQCEqOatqBXkeZBWqozdvFrSLAM() { }

	// RVA: 0x1905C40 Offset: 0x1904E40 VA: 0x181905C40
	private void LZQbYTdqAygePDpftiYBQKARhQSIA() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1906560 Offset: 0x1905760 VA: 0x181906560 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x19065A0 Offset: 0x19057A0 VA: 0x1819065A0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19064A0 Offset: 0x19056A0 VA: 0x1819064A0 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x19064A0 Offset: 0x19056A0 VA: 0x1819064A0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReInput.ControllerHelper.PollingHelper.aLYkEnuhuZQpIgSmRdClvbtFEbxh : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7106
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	public ReInput.ControllerHelper.PollingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x58
	private IEnumerator<ControllerPollingInfo> BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x60

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1905470 Offset: 0x1904670 VA: 0x181905470 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1904AF0 Offset: 0x1903CF0 VA: 0x181904AF0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x19056B0 Offset: 0x19048B0 VA: 0x1819056B0
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	// RVA: 0x19052B0 Offset: 0x19044B0 VA: 0x1819052B0
	private void NliQpQwAufCfLWbPmVSuBlrEIiqh() { }

	// RVA: 0x1905260 Offset: 0x1904460 VA: 0x181905260
	private void NQQCEqOatqBXkeZBWqozdvFrSLAM() { }

	// RVA: 0x1904AA0 Offset: 0x1903CA0 VA: 0x181904AA0
	private void LZQbYTdqAygePDpftiYBQKARhQSIA() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19053C0 Offset: 0x19045C0 VA: 0x1819053C0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1905400 Offset: 0x1904600 VA: 0x181905400 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1905300 Offset: 0x1904500 VA: 0x181905300 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1905300 Offset: 0x1904500 VA: 0x181905300 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReInput.ControllerHelper.PollingHelper.QvRaCzAacqMehOAkrgPbLSsZmAiMA : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7107
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	public ReInput.ControllerHelper.PollingHelper nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x58
	private IEnumerator<ControllerPollingInfo> BfgKbsJPYToqcZhzOBcmDRdNAvGc; // 0x60

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1903260 Offset: 0x1902460 VA: 0x181903260 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19028E0 Offset: 0x1901AE0 VA: 0x1819028E0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x19034A0 Offset: 0x19026A0 VA: 0x1819034A0
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	// RVA: 0x19030A0 Offset: 0x19022A0 VA: 0x1819030A0
	private void NliQpQwAufCfLWbPmVSuBlrEIiqh() { }

	// RVA: 0x1903050 Offset: 0x1902250 VA: 0x181903050
	private void NQQCEqOatqBXkeZBWqozdvFrSLAM() { }

	// RVA: 0x1902890 Offset: 0x1901A90 VA: 0x181902890
	private void LZQbYTdqAygePDpftiYBQKARhQSIA() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19031B0 Offset: 0x19023B0 VA: 0x1819031B0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x19031F0 Offset: 0x19023F0 VA: 0x1819031F0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19030F0 Offset: 0x19022F0 VA: 0x1819030F0 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x19030F0 Offset: 0x19022F0 VA: 0x1819030F0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReInput.ControllerHelper.PollingHelper.CdIDHqSLgqVxVMkgzUIbPsKXlTLb : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7108
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	private IList<CustomController> BTSPmQwPAUfWNhicSURuOzDlkVfq; // 0x58
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x60
	private IEnumerator<ControllerPollingInfo> ZjMCsBmztIFLBJekJGcndCgeCEXkA; // 0x68

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x18EB9E0 Offset: 0x18EABE0 VA: 0x1818EB9E0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x18EB590 Offset: 0x18EA790 VA: 0x1818EB590 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x18EBA70 Offset: 0x18EAC70 VA: 0x1818EBA70
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x18EB930 Offset: 0x18EAB30 VA: 0x1818EB930 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x18EB970 Offset: 0x18EAB70 VA: 0x1818EB970 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x18EB880 Offset: 0x18EAA80 VA: 0x1818EB880 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x18EB880 Offset: 0x18EAA80 VA: 0x1818EB880 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReInput.ControllerHelper.PollingHelper.gSZHLOKIdZAbxtwFBHetDaahTPSNA : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7109
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	private IList<CustomController> BTSPmQwPAUfWNhicSURuOzDlkVfq; // 0x58
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x60
	private IEnumerator<ControllerPollingInfo> ZjMCsBmztIFLBJekJGcndCgeCEXkA; // 0x68

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1907870 Offset: 0x1906A70 VA: 0x181907870 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1907410 Offset: 0x1906610 VA: 0x181907410 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1907900 Offset: 0x1906B00 VA: 0x181907900
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19077C0 Offset: 0x19069C0 VA: 0x1819077C0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1907800 Offset: 0x1906A00 VA: 0x181907800 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1907710 Offset: 0x1906910 VA: 0x181907710 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1907710 Offset: 0x1906910 VA: 0x181907710 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReInput.ControllerHelper.PollingHelper.bMmlPUuMogwBhjpKVcOpGyfbaNQK : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7110
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	private IList<CustomController> BTSPmQwPAUfWNhicSURuOzDlkVfq; // 0x58
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x60
	private IEnumerator<ControllerPollingInfo> ZjMCsBmztIFLBJekJGcndCgeCEXkA; // 0x68

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1905B60 Offset: 0x1904D60 VA: 0x181905B60 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1905700 Offset: 0x1904900 VA: 0x181905700 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1905BF0 Offset: 0x1904DF0 VA: 0x181905BF0
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1905AB0 Offset: 0x1904CB0 VA: 0x181905AB0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1905AF0 Offset: 0x1904CF0 VA: 0x181905AF0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1905A00 Offset: 0x1904C00 VA: 0x181905A00 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1905A00 Offset: 0x1904C00 VA: 0x181905A00 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReInput.ControllerHelper.PollingHelper.KYpAFHFqgBOfePYEWzcbFLMQqKqvA : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7111
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	private IList<CustomController> BTSPmQwPAUfWNhicSURuOzDlkVfq; // 0x58
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x60
	private IEnumerator<ControllerPollingInfo> ZjMCsBmztIFLBJekJGcndCgeCEXkA; // 0x68

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x18F6BC0 Offset: 0x18F5DC0 VA: 0x1818F6BC0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x18F6760 Offset: 0x18F5960 VA: 0x1818F6760 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x18F6C50 Offset: 0x18F5E50 VA: 0x1818F6C50
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x18F6B10 Offset: 0x18F5D10 VA: 0x1818F6B10 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x18F6B50 Offset: 0x18F5D50 VA: 0x1818F6B50 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x18F6A60 Offset: 0x18F5C60 VA: 0x1818F6A60 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x18F6A60 Offset: 0x18F5C60 VA: 0x1818F6A60 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReInput.ControllerHelper.PollingHelper.syvuqNlTfTePVtQXOtskKoVsrlsr : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7112
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	private IList<CustomController> BTSPmQwPAUfWNhicSURuOzDlkVfq; // 0x58
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x60
	private IEnumerator<ControllerPollingInfo> ZjMCsBmztIFLBJekJGcndCgeCEXkA; // 0x68

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x19095D0 Offset: 0x19087D0 VA: 0x1819095D0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1909170 Offset: 0x1908370 VA: 0x181909170 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1909660 Offset: 0x1908860 VA: 0x181909660
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1909520 Offset: 0x1908720 VA: 0x181909520 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1909560 Offset: 0x1908760 VA: 0x181909560 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1909470 Offset: 0x1908670 VA: 0x181909470 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1909470 Offset: 0x1908670 VA: 0x181909470 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReInput.ControllerHelper.PollingHelper.sDheyjZCNxunwWmRgPUYcHlDXisO : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7113
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	private IList<Joystick> rqSMdDJGxgTyaNVDURvIlrOONYwo; // 0x58
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x60
	private IEnumerator<ControllerPollingInfo> ZjMCsBmztIFLBJekJGcndCgeCEXkA; // 0x68

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1909090 Offset: 0x1908290 VA: 0x181909090 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1908C40 Offset: 0x1907E40 VA: 0x181908C40 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1909120 Offset: 0x1908320 VA: 0x181909120
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1908FE0 Offset: 0x19081E0 VA: 0x181908FE0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1909020 Offset: 0x1908220 VA: 0x181909020 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1908F30 Offset: 0x1908130 VA: 0x181908F30 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1908F30 Offset: 0x1908130 VA: 0x181908F30 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReInput.ControllerHelper.PollingHelper.EhDfKCvNEXeeOHVFeeguZjjjFxxC : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7114
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	private IList<Joystick> rqSMdDJGxgTyaNVDURvIlrOONYwo; // 0x58
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x60
	private IEnumerator<ControllerPollingInfo> ZjMCsBmztIFLBJekJGcndCgeCEXkA; // 0x68

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x18F6680 Offset: 0x18F5880 VA: 0x1818F6680 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x18F6220 Offset: 0x18F5420 VA: 0x1818F6220 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x18F6710 Offset: 0x18F5910 VA: 0x1818F6710
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x18F65D0 Offset: 0x18F57D0 VA: 0x1818F65D0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x18F6610 Offset: 0x18F5810 VA: 0x1818F6610 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x18F6520 Offset: 0x18F5720 VA: 0x1818F6520 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x18F6520 Offset: 0x18F5720 VA: 0x1818F6520 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReInput.ControllerHelper.PollingHelper.dXNDeYBUPEZPjOhbLHSDalbdlmPA : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7115
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	private IList<Joystick> rqSMdDJGxgTyaNVDURvIlrOONYwo; // 0x58
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x60
	private IEnumerator<ControllerPollingInfo> ZjMCsBmztIFLBJekJGcndCgeCEXkA; // 0x68

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1906D00 Offset: 0x1905F00 VA: 0x181906D00 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19068A0 Offset: 0x1905AA0 VA: 0x1819068A0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1906D90 Offset: 0x1905F90 VA: 0x181906D90
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1906C50 Offset: 0x1905E50 VA: 0x181906C50 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1906C90 Offset: 0x1905E90 VA: 0x181906C90 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1906BA0 Offset: 0x1905DA0 VA: 0x181906BA0 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1906BA0 Offset: 0x1905DA0 VA: 0x181906BA0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReInput.ControllerHelper.PollingHelper.XYXpCNaIYvGrFGKremZARIoWjoYYA : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7116
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	private IList<Joystick> rqSMdDJGxgTyaNVDURvIlrOONYwo; // 0x58
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x60
	private IEnumerator<ControllerPollingInfo> ZjMCsBmztIFLBJekJGcndCgeCEXkA; // 0x68

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x19049C0 Offset: 0x1903BC0 VA: 0x1819049C0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1904560 Offset: 0x1903760 VA: 0x181904560 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1904A50 Offset: 0x1903C50 VA: 0x181904A50
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1904910 Offset: 0x1903B10 VA: 0x181904910 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1904950 Offset: 0x1903B50 VA: 0x181904950 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1904860 Offset: 0x1903A60 VA: 0x181904860 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1904860 Offset: 0x1903A60 VA: 0x181904860 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReInput.ControllerHelper.PollingHelper.BFSbrBIITDvbrVRHLoVnCJLBARFkA : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator // TypeDefIndex: 7117
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ControllerPollingInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x50
	private IList<Joystick> rqSMdDJGxgTyaNVDURvIlrOONYwo; // 0x58
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x60
	private IEnumerator<ControllerPollingInfo> ZjMCsBmztIFLBJekJGcndCgeCEXkA; // 0x68

	// Properties
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x18E2250 Offset: 0x18E1450 VA: 0x1818E2250
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x18EAE40 Offset: 0x18EA040 VA: 0x1818EAE40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x18EA9E0 Offset: 0x18E9BE0 VA: 0x1818EA9E0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x18EAED0 Offset: 0x18EA0D0 VA: 0x1818EAED0
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0 Slot: 6
	private ControllerPollingInfo System.Collections.Generic.IEnumerator<Rewired.ControllerPollingInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x18EAD90 Offset: 0x18E9F90 VA: 0x1818EAD90 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x18EADD0 Offset: 0x18E9FD0 VA: 0x1818EADD0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x18EACE0 Offset: 0x18E9EE0 VA: 0x1818EACE0 Slot: 4
	private IEnumerator<ControllerPollingInfo> System.Collections.Generic.IEnumerable<Rewired.ControllerPollingInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x18EACE0 Offset: 0x18E9EE0 VA: 0x1818EACE0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[EditorBrowsable(1)]
[Browsable(False)]
public sealed class ReInput.ControllerHelper.PollingHelper : CodeHelper // TypeDefIndex: 7118
{
	// Fields
	private static ReInput.ControllerHelper.PollingHelper jvdHJASpnUhImEOGQmsLnMbcfiVcb; // 0x0

	// Properties
	internal static ReInput.ControllerHelper.PollingHelper IqfZanOvDqIvuKavjaRjEeSYywMMA { get; }

	// Methods

	// RVA: 0x19015C0 Offset: 0x19007C0 VA: 0x1819015C0
	internal static ReInput.ControllerHelper.PollingHelper VVXeCKIxYsdqpsQBhcKFeXVpnNTJ() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x18FF450 Offset: 0x18FE650 VA: 0x1818FF450
	public ControllerPollingInfo PollAllControllersForFirstElement() { }

	// RVA: 0x18FF2E0 Offset: 0x18FE4E0 VA: 0x1818FF2E0
	public ControllerPollingInfo PollAllControllersForFirstElementDown() { }

	// RVA: 0x18FF170 Offset: 0x18FE370 VA: 0x1818FF170
	public ControllerPollingInfo PollAllControllersForFirstButton() { }

	// RVA: 0x18FF000 Offset: 0x18FE200 VA: 0x1818FF000
	public ControllerPollingInfo PollAllControllersForFirstButtonDown() { }

	// RVA: 0x18FEED0 Offset: 0x18FE0D0 VA: 0x1818FEED0
	public ControllerPollingInfo PollAllControllersForFirstAxis() { }

	// RVA: 0x18FFBC0 Offset: 0x18FEDC0 VA: 0x1818FFBC0
	public ControllerPollingInfo PollAllControllersOfTypeForFirstElement(ControllerType controllerType) { }

	// RVA: 0x18FFA30 Offset: 0x18FEC30 VA: 0x1818FFA30
	public ControllerPollingInfo PollAllControllersOfTypeForFirstElementDown(ControllerType controllerType) { }

	// RVA: 0x18FF8A0 Offset: 0x18FEAA0 VA: 0x1818FF8A0
	public ControllerPollingInfo PollAllControllersOfTypeForFirstButton(ControllerType controllerType) { }

	// RVA: 0x18FF710 Offset: 0x18FE910 VA: 0x1818FF710
	public ControllerPollingInfo PollAllControllersOfTypeForFirstButtonDown(ControllerType controllerType) { }

	// RVA: 0x18FF5C0 Offset: 0x18FE7C0 VA: 0x1818FF5C0
	public ControllerPollingInfo PollAllControllersOfTypeForFirstAxis(ControllerType controllerType) { }

	// RVA: 0x1901000 Offset: 0x1900200 VA: 0x181901000
	public ControllerPollingInfo PollControllerForFirstElement(ControllerType controllerType, int controllerId) { }

	// RVA: 0x1900DF0 Offset: 0x18FFFF0 VA: 0x181900DF0
	public ControllerPollingInfo PollControllerForFirstElementDown(ControllerType controllerType, int controllerId) { }

	// RVA: 0x1900BE0 Offset: 0x18FFDE0 VA: 0x181900BE0
	public ControllerPollingInfo PollControllerForFirstButton(ControllerType controllerType, int controllerId) { }

	// RVA: 0x19009D0 Offset: 0x18FFBD0 VA: 0x1819009D0
	public ControllerPollingInfo PollControllerForFirstButtonDown(ControllerType controllerType, int controllerId) { }

	// RVA: 0x1900810 Offset: 0x18FFA10 VA: 0x181900810
	public ControllerPollingInfo PollControllerForFirstAxis(ControllerType controllerType, int controllerId) { }

	// RVA: 0x18FEE50 Offset: 0x18FE050 VA: 0x1818FEE50
	public IEnumerable<ControllerPollingInfo> PollAllControllersForAllElements() { }

	// RVA: 0x18FEDD0 Offset: 0x18FDFD0 VA: 0x1818FEDD0
	public IEnumerable<ControllerPollingInfo> PollAllControllersForAllElementsDown() { }

	// RVA: 0x18FED50 Offset: 0x18FDF50 VA: 0x1818FED50
	public IEnumerable<ControllerPollingInfo> PollAllControllersForAllButtons() { }

	// RVA: 0x18FECD0 Offset: 0x18FDED0 VA: 0x1818FECD0
	public IEnumerable<ControllerPollingInfo> PollAllControllersForAllButtonsDown() { }

	// RVA: 0x18FEC50 Offset: 0x18FDE50 VA: 0x1818FEC50
	public IEnumerable<ControllerPollingInfo> PollAllControllersForAllAxes() { }

	// RVA: 0x19005E0 Offset: 0x18FF7E0 VA: 0x1819005E0
	public IEnumerable<ControllerPollingInfo> PollControllerForAllElements(ControllerType controllerType, int controllerId) { }

	// RVA: 0x19003B0 Offset: 0x18FF5B0 VA: 0x1819003B0
	public IEnumerable<ControllerPollingInfo> PollControllerForAllElementsDown(ControllerType controllerType, int controllerId) { }

	// RVA: 0x1900180 Offset: 0x18FF380 VA: 0x181900180
	public IEnumerable<ControllerPollingInfo> PollControllerForAllButtons(ControllerType controllerType, int controllerId) { }

	// RVA: 0x18FFF50 Offset: 0x18FF150 VA: 0x1818FFF50
	public IEnumerable<ControllerPollingInfo> PollControllerForAllButtonsDown(ControllerType controllerType, int controllerId) { }

	// RVA: 0x18FFD50 Offset: 0x18FEF50 VA: 0x1818FFD50
	public IEnumerable<ControllerPollingInfo> PollControllerForAllAxes(ControllerType controllerType, int controllerId) { }

	// RVA: 0x1902570 Offset: 0x1901770 VA: 0x181902570
	private ControllerPollingInfo uazsEIGqpZemqyfBcexnYcQwddqI() { }

	// RVA: 0x1901FC0 Offset: 0x19011C0 VA: 0x181901FC0
	private ControllerPollingInfo mcnAxrWPavgcdzcVoerwCqYCoHxcA() { }

	// RVA: 0x18FDFF0 Offset: 0x18FD1F0 VA: 0x1818FDFF0
	private ControllerPollingInfo AKSlymLmrQmNoVAAktPzRBxCGhfbA() { }

	// RVA: 0x18FE880 Offset: 0x18FDA80 VA: 0x1818FE880
	private ControllerPollingInfo MNXVUFRDWfGzktYxNNxKubDbwCpg() { }

	// RVA: 0x19017A0 Offset: 0x19009A0 VA: 0x1819017A0
	private ControllerPollingInfo ZbcDcaympuluWFFqXABoGKdammSc() { }

	// RVA: 0x1901960 Offset: 0x1900B60 VA: 0x181901960
	private ControllerPollingInfo cNdBTYbjAePzFpKcZATUZOAUHQJgA(int ) { }

	// RVA: 0x1902780 Offset: 0x1901980 VA: 0x181902780
	private ControllerPollingInfo yGXeSUnfDabWsLCRkcEFzkqcwkcI(int ) { }

	// RVA: 0x18FEA20 Offset: 0x18FDC20 VA: 0x1818FEA20
	private ControllerPollingInfo MsOTSBfeqXoCUjXWjpIhwSMQNjQG(int ) { }

	// RVA: 0x18FE330 Offset: 0x18FD530 VA: 0x1818FE330
	private ControllerPollingInfo CxEwhDbmBjQpkHmUlgtqKVuoagjw(int ) { }

	// RVA: 0x1902810 Offset: 0x1901A10 VA: 0x181902810
	private ControllerPollingInfo zTxzpZLxHVhpIENRXYZgZdkkGVxS(int ) { }

	// RVA: 0x1901280 Offset: 0x1900480 VA: 0x181901280
	private ControllerPollingInfo SfXFUKDZgkDfZYTscjYQbIyAiLcLA() { }

	// RVA: 0x1901DF0 Offset: 0x1900FF0 VA: 0x181901DF0
	private ControllerPollingInfo hKbOyanhNvanpedKvfyjltzjWeEC() { }

	// RVA: 0x19026D0 Offset: 0x19018D0 VA: 0x1819026D0
	private ControllerPollingInfo uxajpMTUtlifVOjmsWAfidjkaEsEA() { }

	// RVA: 0x1901CD0 Offset: 0x1900ED0 VA: 0x181901CD0
	private ControllerPollingInfo furbeESMTbXDSXehoBnRivuvuVzN() { }

	// RVA: 0x1901F50 Offset: 0x1901150 VA: 0x181901F50
	private ControllerPollingInfo lPTmlxcGkNXSkpiOryMVZORYrGZb() { }

	// RVA: 0x18FE770 Offset: 0x18FD970 VA: 0x1818FE770
	private ControllerPollingInfo JPHpRSVTWYIzOCSbtlEYsCZmNETM() { }

	// RVA: 0x19023A0 Offset: 0x19015A0 VA: 0x1819023A0
	private ControllerPollingInfo tudCAmcgZEIUkmgdNINOQVmFuujy() { }

	// RVA: 0x1902410 Offset: 0x1901610 VA: 0x181902410
	private ControllerPollingInfo tugefKijSoMAqonuceVryqiRPTvC() { }

	// RVA: 0x18FE570 Offset: 0x18FD770 VA: 0x1818FE570
	private ControllerPollingInfo GxLRDgmbFuebZRjmyEbvZrFDGbxhA() { }

	// RVA: 0x19019F0 Offset: 0x1900BF0 VA: 0x1819019F0
	private ControllerPollingInfo cRKPEuxhZsDVeflVGfiCgpzgWUEfB() { }

	// RVA: 0x19012F0 Offset: 0x19004F0 VA: 0x1819012F0
	private ControllerPollingInfo SuQjNUvEuvIcKYicangRenCQkfgi() { }

	// RVA: 0x1902120 Offset: 0x1901320 VA: 0x181902120
	private ControllerPollingInfo nqIqFEqjKkHeLriTQPOsejSxbezO() { }

	// RVA: 0x1902270 Offset: 0x1901470 VA: 0x181902270
	private ControllerPollingInfo potCwJsXCBjCSseyTSorDfrCfyHl(int ) { }

	// RVA: 0x18FEAB0 Offset: 0x18FDCB0 VA: 0x1818FEAB0
	private ControllerPollingInfo NlZmESqwhwpcpQPlCDTLlUslRzYh(int ) { }

	// RVA: 0x1901530 Offset: 0x1900730 VA: 0x181901530
	private ControllerPollingInfo UWcQMAFXCSaEMmtQfvNJZeZzcPvr(int ) { }

	// RVA: 0x18FE1C0 Offset: 0x18FD3C0 VA: 0x1818FE1C0
	private ControllerPollingInfo BiRDbrIMCinVAhZACKzDhVPfrsaWB(int ) { }

	// RVA: 0x1901E60 Offset: 0x1901060 VA: 0x181901E60
	private ControllerPollingInfo hixTGQxSnIUDXyRajBiAEAkOKqzs(int ) { }

	// RVA: 0x18FEBE0 Offset: 0x18FDDE0 VA: 0x1818FEBE0
	private IEnumerable<ControllerPollingInfo> POQauBfFbObeCcKgrChCtiWfoUorA() { }

	// RVA: 0x1901B50 Offset: 0x1900D50 VA: 0x181901B50
	private IEnumerable<ControllerPollingInfo> cdbeXwCwlHVioLldDMXiPZhBGOsY() { }

	// RVA: 0x1901210 Offset: 0x1900410 VA: 0x181901210
	private IEnumerable<ControllerPollingInfo> QvChwonEjPokNRNhUNJghDigzly() { }

	// RVA: 0x1901BC0 Offset: 0x1900DC0 VA: 0x181901BC0
	private IEnumerable<ControllerPollingInfo> dUtIYGbpJvhYSEZfTPVLakymMfit() { }

	// RVA: 0x1901450 Offset: 0x1900650 VA: 0x181901450
	private IEnumerable<ControllerPollingInfo> TQFVkVDvzlGAFCxcGBELNyfbviuW() { }

	// RVA: 0x18FE250 Offset: 0x18FD450 VA: 0x1818FE250
	private IEnumerable<ControllerPollingInfo> CBLfjCvgKHpNiNmCgHOVkluKqfZgA(int ) { }

	// RVA: 0x18FE6D0 Offset: 0x18FD8D0 VA: 0x1818FE6D0
	private IEnumerable<ControllerPollingInfo> IKAowGurEocmQLmogCecKwoIRrtN(int ) { }

	// RVA: 0x1901C30 Offset: 0x1900E30 VA: 0x181901C30
	private IEnumerable<ControllerPollingInfo> exwCKdDJldjkwlZcjFSISuJcyCJD(int ) { }

	// RVA: 0x1901700 Offset: 0x1900900 VA: 0x181901700
	private IEnumerable<ControllerPollingInfo> XXKzfZxllYhKzBegGywaAVpfStTeA(int ) { }

	// RVA: 0x18FE400 Offset: 0x18FD600 VA: 0x1818FE400
	private IEnumerable<ControllerPollingInfo> DwRInAAOwdupenFbBqiKtfUcjmKJ(int ) { }

	// RVA: 0x1902740 Offset: 0x1901940 VA: 0x181902740
	private IEnumerable<ControllerPollingInfo> vwArQTeXTHnKEfLFxYBoPYaUgvBq() { }

	// RVA: 0x18FE3C0 Offset: 0x18FD5C0 VA: 0x1818FE3C0
	private IEnumerable<ControllerPollingInfo> DhGzJoxnsSBMDbEZXtgGpCBWcNAjb() { }

	// RVA: 0x18FE9E0 Offset: 0x18FDBE0 VA: 0x1818FE9E0
	private IEnumerable<ControllerPollingInfo> MaJBbcoEElBnoIqnZRsmlEqlRGKV() { }

	// RVA: 0x18FE2F0 Offset: 0x18FD4F0 VA: 0x1818FE2F0
	private IEnumerable<ControllerPollingInfo> CCPIQCdYbsHdilbICWpzjeTiHehxA() { }

	// RVA: 0x1901DB0 Offset: 0x1900FB0 VA: 0x181901DB0
	private IEnumerable<ControllerPollingInfo> hBhTaaaxbnfGwlIWraCUCivvzErHA() { }

	// RVA: 0x19016C0 Offset: 0x19008C0 VA: 0x1819016C0
	private IEnumerable<ControllerPollingInfo> XDkmLEVvShmFBWeMwifuLtLDQeYm() { }

	// RVA: 0x18FE530 Offset: 0x18FD730 VA: 0x1818FE530
	private IEnumerable<ControllerPollingInfo> FzzQsypFpSGOVDBKAEPKXJtUDitjA() { }

	// RVA: 0x1901D40 Offset: 0x1900F40 VA: 0x181901D40
	private IEnumerable<ControllerPollingInfo> gGwQkMNmvEfITNvRsTNsYkxDLoMB() { }

	// RVA: 0x19014C0 Offset: 0x19006C0 VA: 0x1819014C0
	private IEnumerable<ControllerPollingInfo> UDHomVayjaGPyJHiRCUOfKHytcJL() { }

	// RVA: 0x18FE150 Offset: 0x18FD350 VA: 0x1818FE150
	private IEnumerable<ControllerPollingInfo> BelreQGlOFTJqKmIiOIsYCSsvtzv() { }

	// RVA: 0x1901EE0 Offset: 0x19010E0 VA: 0x181901EE0
	private IEnumerable<ControllerPollingInfo> jCtVIdrAUVbuGsFLkZTyzAQEPfaD() { }

	// RVA: 0x19018F0 Offset: 0x1900AF0 VA: 0x1819018F0
	private IEnumerable<ControllerPollingInfo> bDoAvHFDCQxECaJqHfHIGYDyfaraA() { }

	// RVA: 0x1902300 Offset: 0x1901500 VA: 0x181902300
	private IEnumerable<ControllerPollingInfo> rOPpLqAGpeiIpLOcECIzkAxZlVtpA(int ) { }

	// RVA: 0x18FEB40 Offset: 0x18FDD40 VA: 0x1818FEB40
	private IEnumerable<ControllerPollingInfo> OfdwwTlsCzmKonSpJILNZQbjUfZf(int ) { }

	// RVA: 0x18FE490 Offset: 0x18FD690 VA: 0x1818FE490
	private IEnumerable<ControllerPollingInfo> DyCXxoBERSTcDwTrrWsvINaoozWC(int ) { }

	// RVA: 0x18FE7E0 Offset: 0x18FD9E0 VA: 0x1818FE7E0
	private IEnumerable<ControllerPollingInfo> LKSbjcvxCHCXcDOXqmpQNFDzdAlW(int ) { }

	// RVA: 0x1901630 Offset: 0x1900830 VA: 0x181901630
	private IEnumerable<ControllerPollingInfo> WVdgeYRZZIAuWniJITeOWADlkhGH(int ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReInput.ControllerHelper.ConflictCheckingHelper.mnQvASwnPDpsQOCyGyFJXFlZfAGP : IDisposable, IEnumerable, IEnumerator, IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 7119
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ElementAssignmentConflictInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x14
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x40
	private int vLdFayPHSPZjEPkjcylKCjtMVIHv; // 0x44
	public int rvFsFnUnWBeIrfuzaLkgbDNqxMpO; // 0x48
	private ActionElementMap uLOhCSEvDgEZSdSinJStADYFhbic; // 0x50
	public ActionElementMap wZSRhFCbWOtixaksTFwYrKjQmVRq; // 0x58
	private bool vSIIkNrEbymvxegvfdLWgkkAfuElA; // 0x60
	public bool elZaMtMRlIhDwdXWcOSBBgWUmKhVA; // 0x61
	private int NDJCfPreMhWCOFQPsCzuOVGtkoBG; // 0x64
	public int IprpYEnLupXnESxCOZDQoqGwLqFj; // 0x68
	private CustomControllerMap cPmuXAVNIraLtaZVxEUyKUBNBMdj; // 0x70
	public CustomControllerMap NxXRskbrnGLCaJHGtJRBglCyDPZhA; // 0x78
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x80
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x81
	private bool JnqhrBwoxcwlbFFeBHHBDiitpZaab; // 0x82
	public bool qBChZzPpwxmEMfXFsrRNlxjIanHl; // 0x83
	private IList<Player> pqYfgBCLfiqOtwKpDGJQdTWixaQJ; // 0x88
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x90
	private IEnumerator<ElementAssignmentConflictInfo> ZjMCsBmztIFLBJekJGcndCgeCEXkA; // 0x98

	// Properties
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xE7ACF0 Offset: 0xE79EF0 VA: 0x180E7ACF0
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1908540 Offset: 0x1907740 VA: 0x181908540 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1907FC0 Offset: 0x19071C0 VA: 0x181907FC0 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x19085A0 Offset: 0x19077A0 VA: 0x1819085A0
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x798F40 Offset: 0x798140 VA: 0x180798F40 Slot: 10
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19084A0 Offset: 0x19076A0 VA: 0x1819084A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x19084E0 Offset: 0x19076E0 VA: 0x1819084E0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19083B0 Offset: 0x19075B0 VA: 0x1819083B0 Slot: 9
	private IEnumerator<ElementAssignmentConflictInfo> System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x19083B0 Offset: 0x19075B0 VA: 0x1819083B0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReInput.ControllerHelper.ConflictCheckingHelper.XMcTIOBtCezqMrytmKeMHgJrEiiK : IDisposable, IEnumerable, IEnumerator, IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 7120
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ElementAssignmentConflictInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x14
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x40
	private ElementAssignmentConflictCheck zqwcQAKmowyacotoRHDevIvpNlyi; // 0x44
	public ElementAssignmentConflictCheck ejpVKkYVvFucluBNLhLsNxfggkay; // 0x7C
	private bool vSIIkNrEbymvxegvfdLWgkkAfuElA; // 0xB4
	public bool elZaMtMRlIhDwdXWcOSBBgWUmKhVA; // 0xB5
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0xB6
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0xB7
	private bool JnqhrBwoxcwlbFFeBHHBDiitpZaab; // 0xB8
	public bool qBChZzPpwxmEMfXFsrRNlxjIanHl; // 0xB9
	private IList<Player> pqYfgBCLfiqOtwKpDGJQdTWixaQJ; // 0xC0
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0xC8
	private IEnumerator<ElementAssignmentConflictInfo> ZjMCsBmztIFLBJekJGcndCgeCEXkA; // 0xD0

	// Properties
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xE7ACF0 Offset: 0xE79EF0 VA: 0x180E7ACF0
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x19044A0 Offset: 0x19036A0 VA: 0x1819044A0 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1903EF0 Offset: 0x19030F0 VA: 0x181903EF0 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x1904500 Offset: 0x1903700 VA: 0x181904500
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x798F40 Offset: 0x798140 VA: 0x180798F40 Slot: 10
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1904400 Offset: 0x1903600 VA: 0x181904400 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1904440 Offset: 0x1903640 VA: 0x181904440 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19042F0 Offset: 0x19034F0 VA: 0x1819042F0 Slot: 9
	private IEnumerator<ElementAssignmentConflictInfo> System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x19042F0 Offset: 0x19034F0 VA: 0x1819042F0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReInput.ControllerHelper.ConflictCheckingHelper.nuQDwGjoXNSOLUxVhuGIDuOXOSBn : IDisposable, IEnumerable, IEnumerator, IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 7121
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ElementAssignmentConflictInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x14
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x40
	private int vLdFayPHSPZjEPkjcylKCjtMVIHv; // 0x44
	public int rvFsFnUnWBeIrfuzaLkgbDNqxMpO; // 0x48
	private ActionElementMap uLOhCSEvDgEZSdSinJStADYFhbic; // 0x50
	public ActionElementMap wZSRhFCbWOtixaksTFwYrKjQmVRq; // 0x58
	private bool vSIIkNrEbymvxegvfdLWgkkAfuElA; // 0x60
	public bool elZaMtMRlIhDwdXWcOSBBgWUmKhVA; // 0x61
	private int NDJCfPreMhWCOFQPsCzuOVGtkoBG; // 0x64
	public int IprpYEnLupXnESxCOZDQoqGwLqFj; // 0x68
	private JoystickMap kmaKiMEdzxftindoltvbzNNGhHvo; // 0x70
	public JoystickMap hdhZvlXdTmxZhsOUoFyHKClabeNC; // 0x78
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x80
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x81
	private bool JnqhrBwoxcwlbFFeBHHBDiitpZaab; // 0x82
	public bool qBChZzPpwxmEMfXFsrRNlxjIanHl; // 0x83
	private IList<Player> pqYfgBCLfiqOtwKpDGJQdTWixaQJ; // 0x88
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x90
	private IEnumerator<ElementAssignmentConflictInfo> ZjMCsBmztIFLBJekJGcndCgeCEXkA; // 0x98

	// Properties
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xE7ACF0 Offset: 0xE79EF0 VA: 0x180E7ACF0
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1908B80 Offset: 0x1907D80 VA: 0x181908B80 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1908600 Offset: 0x1907800 VA: 0x181908600 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x1908BE0 Offset: 0x1907DE0 VA: 0x181908BE0
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x798F40 Offset: 0x798140 VA: 0x180798F40 Slot: 10
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1908AE0 Offset: 0x1907CE0 VA: 0x181908AE0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1908B20 Offset: 0x1907D20 VA: 0x181908B20 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19089F0 Offset: 0x1907BF0 VA: 0x1819089F0 Slot: 9
	private IEnumerator<ElementAssignmentConflictInfo> System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x19089F0 Offset: 0x1907BF0 VA: 0x1819089F0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReInput.ControllerHelper.ConflictCheckingHelper.AnmPAtkkJwnqxEGLSHqzNkOraNVAA : IDisposable, IEnumerable, IEnumerator, IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 7122
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ElementAssignmentConflictInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x14
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x40
	private ElementAssignmentConflictCheck zqwcQAKmowyacotoRHDevIvpNlyi; // 0x44
	public ElementAssignmentConflictCheck ejpVKkYVvFucluBNLhLsNxfggkay; // 0x7C
	private bool vSIIkNrEbymvxegvfdLWgkkAfuElA; // 0xB4
	public bool elZaMtMRlIhDwdXWcOSBBgWUmKhVA; // 0xB5
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0xB6
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0xB7
	private bool JnqhrBwoxcwlbFFeBHHBDiitpZaab; // 0xB8
	public bool qBChZzPpwxmEMfXFsrRNlxjIanHl; // 0xB9
	private IList<Player> pqYfgBCLfiqOtwKpDGJQdTWixaQJ; // 0xC0
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0xC8
	private IEnumerator<ElementAssignmentConflictInfo> ZjMCsBmztIFLBJekJGcndCgeCEXkA; // 0xD0

	// Properties
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xE7ACF0 Offset: 0xE79EF0 VA: 0x180E7ACF0
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x18EA920 Offset: 0x18E9B20 VA: 0x1818EA920 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x18EA370 Offset: 0x18E9570 VA: 0x1818EA370 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x18EA980 Offset: 0x18E9B80 VA: 0x1818EA980
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x798F40 Offset: 0x798140 VA: 0x180798F40 Slot: 10
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x18EA880 Offset: 0x18E9A80 VA: 0x1818EA880 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x18EA8C0 Offset: 0x18E9AC0 VA: 0x1818EA8C0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x18EA770 Offset: 0x18E9970 VA: 0x1818EA770 Slot: 9
	private IEnumerator<ElementAssignmentConflictInfo> System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x18EA770 Offset: 0x18E9970 VA: 0x1818EA770 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReInput.ControllerHelper.ConflictCheckingHelper.DfecUQTLdqgVqieeBYEmneSVLkYiA : IDisposable, IEnumerable, IEnumerator, IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 7123
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ElementAssignmentConflictInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x14
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x40
	private int vLdFayPHSPZjEPkjcylKCjtMVIHv; // 0x44
	public int rvFsFnUnWBeIrfuzaLkgbDNqxMpO; // 0x48
	private ActionElementMap uLOhCSEvDgEZSdSinJStADYFhbic; // 0x50
	public ActionElementMap wZSRhFCbWOtixaksTFwYrKjQmVRq; // 0x58
	private bool vSIIkNrEbymvxegvfdLWgkkAfuElA; // 0x60
	public bool elZaMtMRlIhDwdXWcOSBBgWUmKhVA; // 0x61
	private KeyboardMap CDnziVPsTbEuaasCpFaLPyPeLLke; // 0x68
	public KeyboardMap ZuCDgAsyHnhErLfkjfeSCcTgRsWG; // 0x70
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x78
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x79
	private bool JnqhrBwoxcwlbFFeBHHBDiitpZaab; // 0x7A
	public bool qBChZzPpwxmEMfXFsrRNlxjIanHl; // 0x7B
	private IList<Player> pqYfgBCLfiqOtwKpDGJQdTWixaQJ; // 0x80
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x88
	private IEnumerator<ElementAssignmentConflictInfo> ZjMCsBmztIFLBJekJGcndCgeCEXkA; // 0x90

	// Properties
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xE7ACF0 Offset: 0xE79EF0 VA: 0x180E7ACF0
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x18F6160 Offset: 0x18F5360 VA: 0x1818F6160 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x18F5C00 Offset: 0x18F4E00 VA: 0x1818F5C00 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x18F61C0 Offset: 0x18F53C0 VA: 0x1818F61C0
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x798F40 Offset: 0x798140 VA: 0x180798F40 Slot: 10
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x18F60C0 Offset: 0x18F52C0 VA: 0x1818F60C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x18F6100 Offset: 0x18F5300 VA: 0x1818F6100 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x18F5FE0 Offset: 0x18F51E0 VA: 0x1818F5FE0 Slot: 9
	private IEnumerator<ElementAssignmentConflictInfo> System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x18F5FE0 Offset: 0x18F51E0 VA: 0x1818F5FE0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReInput.ControllerHelper.ConflictCheckingHelper.iJHTYqaRZZAEqHLcZDaPVkkYVHPC : IDisposable, IEnumerable, IEnumerator, IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 7124
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ElementAssignmentConflictInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x14
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x40
	private ElementAssignmentConflictCheck zqwcQAKmowyacotoRHDevIvpNlyi; // 0x44
	public ElementAssignmentConflictCheck ejpVKkYVvFucluBNLhLsNxfggkay; // 0x7C
	private bool vSIIkNrEbymvxegvfdLWgkkAfuElA; // 0xB4
	public bool elZaMtMRlIhDwdXWcOSBBgWUmKhVA; // 0xB5
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0xB6
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0xB7
	private bool JnqhrBwoxcwlbFFeBHHBDiitpZaab; // 0xB8
	public bool qBChZzPpwxmEMfXFsrRNlxjIanHl; // 0xB9
	private IList<Player> pqYfgBCLfiqOtwKpDGJQdTWixaQJ; // 0xC0
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0xC8
	private IEnumerator<ElementAssignmentConflictInfo> ZjMCsBmztIFLBJekJGcndCgeCEXkA; // 0xD0

	// Properties
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xE7ACF0 Offset: 0xE79EF0 VA: 0x180E7ACF0
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1907F00 Offset: 0x1907100 VA: 0x181907F00 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1907950 Offset: 0x1906B50 VA: 0x181907950 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x1907F60 Offset: 0x1907160 VA: 0x181907F60
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x798F40 Offset: 0x798140 VA: 0x180798F40 Slot: 10
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1907E60 Offset: 0x1907060 VA: 0x181907E60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1907EA0 Offset: 0x19070A0 VA: 0x181907EA0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1907D50 Offset: 0x1906F50 VA: 0x181907D50 Slot: 9
	private IEnumerator<ElementAssignmentConflictInfo> System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1907D50 Offset: 0x1906F50 VA: 0x181907D50 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReInput.ControllerHelper.ConflictCheckingHelper.deXHmcXoGwLaIWpdCtonrVbnmbuu : IDisposable, IEnumerable, IEnumerator, IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 7125
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ElementAssignmentConflictInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x14
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x40
	private int vLdFayPHSPZjEPkjcylKCjtMVIHv; // 0x44
	public int rvFsFnUnWBeIrfuzaLkgbDNqxMpO; // 0x48
	private ActionElementMap uLOhCSEvDgEZSdSinJStADYFhbic; // 0x50
	public ActionElementMap wZSRhFCbWOtixaksTFwYrKjQmVRq; // 0x58
	private bool vSIIkNrEbymvxegvfdLWgkkAfuElA; // 0x60
	public bool elZaMtMRlIhDwdXWcOSBBgWUmKhVA; // 0x61
	private MouseMap CHdNCnTkYSnDgVAOfPBIQBszcKKgA; // 0x68
	public MouseMap edBEGXmReVddYheHjoyptUzbRUAz; // 0x70
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0x78
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0x79
	private bool JnqhrBwoxcwlbFFeBHHBDiitpZaab; // 0x7A
	public bool qBChZzPpwxmEMfXFsrRNlxjIanHl; // 0x7B
	private IList<Player> pqYfgBCLfiqOtwKpDGJQdTWixaQJ; // 0x80
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x88
	private IEnumerator<ElementAssignmentConflictInfo> ZjMCsBmztIFLBJekJGcndCgeCEXkA; // 0x90

	// Properties
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xE7ACF0 Offset: 0xE79EF0 VA: 0x180E7ACF0
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x1907350 Offset: 0x1906550 VA: 0x181907350 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1906DE0 Offset: 0x1905FE0 VA: 0x181906DE0 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x19073B0 Offset: 0x19065B0 VA: 0x1819073B0
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x798F40 Offset: 0x798140 VA: 0x180798F40 Slot: 10
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19072B0 Offset: 0x19064B0 VA: 0x1819072B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x19072F0 Offset: 0x19064F0 VA: 0x1819072F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19071D0 Offset: 0x19063D0 VA: 0x1819071D0 Slot: 9
	private IEnumerator<ElementAssignmentConflictInfo> System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x19071D0 Offset: 0x19063D0 VA: 0x1819071D0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReInput.ControllerHelper.ConflictCheckingHelper.CRzRnrrEkQOQXpjnQBVvgogERyDQA : IDisposable, IEnumerable, IEnumerator, IEnumerable<ElementAssignmentConflictInfo>, IEnumerator<ElementAssignmentConflictInfo> // TypeDefIndex: 7126
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private ElementAssignmentConflictInfo lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x14
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x40
	private ElementAssignmentConflictCheck zqwcQAKmowyacotoRHDevIvpNlyi; // 0x44
	public ElementAssignmentConflictCheck ejpVKkYVvFucluBNLhLsNxfggkay; // 0x7C
	private bool vSIIkNrEbymvxegvfdLWgkkAfuElA; // 0xB4
	public bool elZaMtMRlIhDwdXWcOSBBgWUmKhVA; // 0xB5
	private bool zpusPfHRRMgwVLZweeLgSANdoFAe; // 0xB6
	public bool ecADIEetYkamATtkzsPirSfJZlzV; // 0xB7
	private bool JnqhrBwoxcwlbFFeBHHBDiitpZaab; // 0xB8
	public bool qBChZzPpwxmEMfXFsrRNlxjIanHl; // 0xB9
	private IList<Player> pqYfgBCLfiqOtwKpDGJQdTWixaQJ; // 0xC0
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0xC8
	private IEnumerator<ElementAssignmentConflictInfo> ZjMCsBmztIFLBJekJGcndCgeCEXkA; // 0xD0

	// Properties
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xE7ACF0 Offset: 0xE79EF0 VA: 0x180E7ACF0
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x18EB4D0 Offset: 0x18EA6D0 VA: 0x1818EB4D0 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x18EAF20 Offset: 0x18EA120 VA: 0x1818EAF20 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x18EB530 Offset: 0x18EA730 VA: 0x1818EB530
	private void YdjRduvJdaCxcHHEwmxdjVhcLPut() { }

	[DebuggerHidden]
	// RVA: 0x798F40 Offset: 0x798140 VA: 0x180798F40 Slot: 10
	private ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x18EB430 Offset: 0x18EA630 VA: 0x1818EB430 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x18EB470 Offset: 0x18EA670 VA: 0x1818EB470 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x18EB320 Offset: 0x18EA520 VA: 0x1818EB320 Slot: 9
	private IEnumerator<ElementAssignmentConflictInfo> System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x18EB320 Offset: 0x18EA520 VA: 0x1818EB320 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[Browsable(False)]
[EditorBrowsable(1)]
public sealed class ReInput.ControllerHelper.ConflictCheckingHelper : CodeHelper // TypeDefIndex: 7127
{
	// Fields
	private static ReInput.ControllerHelper.ConflictCheckingHelper jvdHJASpnUhImEOGQmsLnMbcfiVcb; // 0x0

	// Properties
	internal static ReInput.ControllerHelper.ConflictCheckingHelper IqfZanOvDqIvuKavjaRjEeSYywMMA { get; }

	// Methods

	// RVA: 0x18EF7C0 Offset: 0x18EE9C0 VA: 0x1818EF7C0
	internal static ReInput.ControllerHelper.ConflictCheckingHelper VVXeCKIxYsdqpsQBhcKFeXVpnNTJ() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x18EC930 Offset: 0x18EBB30 VA: 0x1818EC930
	public bool DoesAnyElementAssignmentConflict() { }

	// RVA: 0x18EC950 Offset: 0x18EBB50 VA: 0x1818EC950
	public bool DoesAnyElementAssignmentConflict(bool skipDisabledMaps) { }

	// RVA: 0x18EC910 Offset: 0x18EBB10 VA: 0x1818EC910
	public bool DoesAnyElementAssignmentConflict(bool skipDisabledMaps, bool forceCheckAllCategories) { }

	// RVA: 0x18EC150 Offset: 0x18EB350 VA: 0x1818EC150
	public bool DoesAnyElementAssignmentConflict(bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer) { }

	// RVA: 0x18ED910 Offset: 0x18ECB10 VA: 0x1818ED910
	public bool DoesElementAssignmentConflict(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap) { }

	// RVA: 0x18ED8C0 Offset: 0x18ECAC0 VA: 0x1818ED8C0
	public bool DoesElementAssignmentConflict(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps) { }

	// RVA: 0x18ED950 Offset: 0x18ECB50 VA: 0x1818ED950
	public bool DoesElementAssignmentConflict(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories) { }

	// RVA: 0x18ED150 Offset: 0x18EC350 VA: 0x1818ED150
	public bool DoesElementAssignmentConflict(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer) { }

	// RVA: 0x18ED100 Offset: 0x18EC300 VA: 0x1818ED100
	public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck) { }

	// RVA: 0x18ED9A0 Offset: 0x18ECBA0 VA: 0x1818ED9A0
	public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) { }

	// RVA: 0x18ED870 Offset: 0x18ECA70 VA: 0x1818ED870
	public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories) { }

	// RVA: 0x18EC970 Offset: 0x18EBB70 VA: 0x1818EC970
	public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer) { }

	// RVA: 0x18EF290 Offset: 0x18EE490 VA: 0x1818EF290
	private bool UrXOJEETHNqXoLlGxfycwIgTdCw(int , int , JoystickMap , ActionElementMap , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18EF450 Offset: 0x18EE650 VA: 0x1818EF450
	private bool UrXOJEETHNqXoLlGxfycwIgTdCw(ElementAssignmentConflictCheck , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18F0500 Offset: 0x18EF700 VA: 0x1818F0500
	private bool bZVaEVMShgsekwOwtbhhHiwYbIQG(int , KeyboardMap , ActionElementMap , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18F0330 Offset: 0x18EF530 VA: 0x1818F0330
	private bool bZVaEVMShgsekwOwtbhhHiwYbIQG(ElementAssignmentConflictCheck , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18F21E0 Offset: 0x18F13E0 VA: 0x1818F21E0
	private bool nfiDbFNFHQAJOaFQvetSCPBaublR(int , MouseMap , ActionElementMap , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18F2010 Offset: 0x18F1210 VA: 0x1818F2010
	private bool nfiDbFNFHQAJOaFQvetSCPBaublR(ElementAssignmentConflictCheck , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18EE160 Offset: 0x18ED360 VA: 0x1818EE160
	private bool GJYtCPSLocSWqMUbYlhKSHFcJtrs(int , int , CustomControllerMap , ActionElementMap , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18EE320 Offset: 0x18ED520 VA: 0x1818EE320
	private bool GJYtCPSLocSWqMUbYlhKSHFcJtrs(ElementAssignmentConflictCheck , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18EDD40 Offset: 0x18ECF40 VA: 0x1818EDD40
	public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap) { }

	// RVA: 0x18EDD80 Offset: 0x18ECF80 VA: 0x1818EDD80
	public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps) { }

	// RVA: 0x18EDA90 Offset: 0x18ECC90 VA: 0x1818EDA90
	public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories) { }

	// RVA: 0x18EDDD0 Offset: 0x18ECFD0 VA: 0x1818EDDD0
	public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer) { }

	// RVA: 0x18EDA40 Offset: 0x18ECC40 VA: 0x1818EDA40
	public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck) { }

	// RVA: 0x18EE110 Offset: 0x18ED310 VA: 0x1818EE110
	public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) { }

	// RVA: 0x18ED9F0 Offset: 0x18ECBF0 VA: 0x1818ED9F0
	public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories) { }

	// RVA: 0x18EDAE0 Offset: 0x18ECCE0 VA: 0x1818EDAE0
	public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer) { }

	// RVA: 0x18EF0F0 Offset: 0x18EE2F0 VA: 0x1818EF0F0
	private IEnumerable<ElementAssignmentConflictInfo> TBDIhkiVdtnmJYInyqJrVSCCdxlz(int , int , JoystickMap , ActionElementMap , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18EF1B0 Offset: 0x18EE3B0 VA: 0x1818EF1B0
	private IEnumerable<ElementAssignmentConflictInfo> TBDIhkiVdtnmJYInyqJrVSCCdxlz(ElementAssignmentConflictCheck , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18F0D10 Offset: 0x18EFF10 VA: 0x1818F0D10
	private IEnumerable<ElementAssignmentConflictInfo> eCutAUMiENdaaINilOotOfTKqheTA(int , KeyboardMap , ActionElementMap , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18F0C30 Offset: 0x18EFE30 VA: 0x1818F0C30
	private IEnumerable<ElementAssignmentConflictInfo> eCutAUMiENdaaINilOotOfTKqheTA(ElementAssignmentConflictCheck , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18EF700 Offset: 0x18EE900 VA: 0x1818EF700
	private IEnumerable<ElementAssignmentConflictInfo> VUdWRnhPUnyAgQoirPGCeBEJAeod(int , MouseMap , ActionElementMap , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18EF620 Offset: 0x18EE820 VA: 0x1818EF620
	private IEnumerable<ElementAssignmentConflictInfo> VUdWRnhPUnyAgQoirPGCeBEJAeod(ElementAssignmentConflictCheck , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18F1440 Offset: 0x18F0640 VA: 0x1818F1440
	private IEnumerable<ElementAssignmentConflictInfo> kOUrLOPeUIRfsuHipaXJLthdNOQB(int , int , CustomControllerMap , ActionElementMap , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18F1360 Offset: 0x18F0560 VA: 0x1818F1360
	private IEnumerable<ElementAssignmentConflictInfo> kOUrLOPeUIRfsuHipaXJLthdNOQB(ElementAssignmentConflictCheck , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18EEB00 Offset: 0x18EDD00 VA: 0x1818EEB00
	public int RemoveElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap) { }

	// RVA: 0x18EEAB0 Offset: 0x18EDCB0 VA: 0x1818EEAB0
	public int RemoveElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps) { }

	// RVA: 0x18EF050 Offset: 0x18EE250 VA: 0x1818EF050
	public int RemoveElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories) { }

	// RVA: 0x18EED70 Offset: 0x18EDF70 VA: 0x1818EED70
	public int RemoveElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer) { }

	// RVA: 0x18EEA60 Offset: 0x18EDC60 VA: 0x1818EEA60
	public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck) { }

	// RVA: 0x18EF000 Offset: 0x18EE200 VA: 0x1818EF000
	public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) { }

	// RVA: 0x18EF0A0 Offset: 0x18EE2A0 VA: 0x1818EF0A0
	public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories) { }

	// RVA: 0x18EEB40 Offset: 0x18EDD40 VA: 0x1818EEB40
	public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer) { }

	// RVA: 0x18F0DD0 Offset: 0x18EFFD0 VA: 0x1818F0DD0
	private int kDJNyHMliiqglSkJYIWerxAwyQGP(int , int , JoystickMap , ActionElementMap , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18F1090 Offset: 0x18F0290 VA: 0x1818F1090
	private int kDJNyHMliiqglSkJYIWerxAwyQGP(ElementAssignmentConflictCheck , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18EE4F0 Offset: 0x18ED6F0 VA: 0x1818EE4F0
	private int NjWnpkFIcOOLTljcSUrajnjrzTcy(int , KeyboardMap , ActionElementMap , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18EE790 Offset: 0x18ED990 VA: 0x1818EE790
	private int NjWnpkFIcOOLTljcSUrajnjrzTcy(ElementAssignmentConflictCheck , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18F1D60 Offset: 0x18F0F60 VA: 0x1818F1D60
	private int liwQFBsSdyfnJDjuKLsLqRAQARMBb(int , MouseMap , ActionElementMap , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18F1A90 Offset: 0x18F0C90 VA: 0x1818F1A90
	private int liwQFBsSdyfnJDjuKLsLqRAQARMBb(ElementAssignmentConflictCheck , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18F17D0 Offset: 0x18F09D0 VA: 0x1818F17D0
	private int lSBDoEKHRrmdtgRTZFwVVuKAkrstA(int , int , CustomControllerMap , ActionElementMap , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18F1500 Offset: 0x18F0700 VA: 0x1818F1500
	private int lSBDoEKHRrmdtgRTZFwVVuKAkrstA(ElementAssignmentConflictCheck , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18EC070 Offset: 0x18EB270 VA: 0x1818EC070
	public int DisableElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap) { }

	// RVA: 0x18EBFD0 Offset: 0x18EB1D0 VA: 0x1818EBFD0
	public int DisableElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps) { }

	// RVA: 0x18EBCF0 Offset: 0x18EAEF0 VA: 0x1818EBCF0
	public int DisableElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories) { }

	// RVA: 0x18EBD40 Offset: 0x18EAF40 VA: 0x1818EBD40
	public int DisableElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer) { }

	// RVA: 0x18EC0B0 Offset: 0x18EB2B0 VA: 0x1818EC0B0
	public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck) { }

	// RVA: 0x18EC100 Offset: 0x18EB300 VA: 0x1818EC100
	public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) { }

	// RVA: 0x18EC020 Offset: 0x18EB220 VA: 0x1818EC020
	public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories) { }

	// RVA: 0x18EBAC0 Offset: 0x18EACC0 VA: 0x1818EBAC0
	public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer) { }

	// RVA: 0x18EFDA0 Offset: 0x18EEFA0 VA: 0x1818EFDA0
	private int YXOejINqKjGSXAstmNfZWclCGwSo(int , int , JoystickMap , ActionElementMap , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18F0060 Offset: 0x18EF260 VA: 0x1818F0060
	private int YXOejINqKjGSXAstmNfZWclCGwSo(ElementAssignmentConflictCheck , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18EF830 Offset: 0x18EEA30 VA: 0x1818EF830
	private int VjCBvdamvUPgeLgbYBLfzDTOMzzBA(int , KeyboardMap , ActionElementMap , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18EFAD0 Offset: 0x18EECD0 VA: 0x1818EFAD0
	private int VjCBvdamvUPgeLgbYBLfzDTOMzzBA(ElementAssignmentConflictCheck , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18F0980 Offset: 0x18EFB80 VA: 0x1818F0980
	private int cLSFiHNcXDASdYkkDHlXVkfhrZMm(int , MouseMap , ActionElementMap , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18F06B0 Offset: 0x18EF8B0 VA: 0x1818F06B0
	private int cLSFiHNcXDASdYkkDHlXVkfhrZMm(ElementAssignmentConflictCheck , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18F2660 Offset: 0x18F1860 VA: 0x1818F2660
	private int vSafuYqHhQENsUoibFOethBaafvZ(int , int , CustomControllerMap , ActionElementMap , bool  = False, bool  = False, bool  = True) { }

	// RVA: 0x18F2390 Offset: 0x18F1590 VA: 0x1818F2390
	private int vSafuYqHhQENsUoibFOethBaafvZ(ElementAssignmentConflictCheck , bool  = False, bool  = False, bool  = True) { }
}

// Namespace: 
[Browsable(False)]
[EditorBrowsable(1)]
public sealed class ReInput.ControllerHelper : CodeHelper // TypeDefIndex: 7128
{
	// Fields
	private static ReInput.ControllerHelper jvdHJASpnUhImEOGQmsLnMbcfiVcb; // 0x0
	public readonly ReInput.ControllerHelper.PollingHelper polling; // 0x10
	public readonly ReInput.ControllerHelper.ConflictCheckingHelper conflictChecking; // 0x18

	// Properties
	internal static ReInput.ControllerHelper IqfZanOvDqIvuKavjaRjEeSYywMMA { get; }
	public int controllerCount { get; }
	public IList<Controller> Controllers { get; }
	public Mouse Mouse { get; }
	public Keyboard Keyboard { get; }
	[Obsolete("Deprecated: Use Controller.enabled instead. For example, to disable keyboard input: ReInput.controllers.Keyboard.enabled = false.")]
	public bool keyboardEnabled { get; set; }
	public int joystickCount { get; }
	public IList<Joystick> Joysticks { get; }
	public int customControllerCount { get; }
	public IList<CustomController> CustomControllers { get; }

	// Methods

	// RVA: 0x18F5440 Offset: 0x18F4640 VA: 0x1818F5440
	internal static ReInput.ControllerHelper VVXeCKIxYsdqpsQBhcKFeXVpnNTJ() { }

	// RVA: 0x18F5570 Offset: 0x18F4770 VA: 0x1818F5570
	private void .ctor() { }

	// RVA: -1 Offset: -1
	public T GetController<T>(int controllerId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACA480 Offset: 0xAC9680 VA: 0x180ACA480
	|-ReInput.ControllerHelper.GetController<object>
	*/

	// RVA: 0x18F37A0 Offset: 0x18F29A0 VA: 0x1818F37A0
	public int GetControllerCount(ControllerType controllerType) { }

	// RVA: 0x18F5950 Offset: 0x18F4B50 VA: 0x1818F5950
	public int get_controllerCount() { }

	// RVA: 0x18F5650 Offset: 0x18F4850 VA: 0x1818F5650
	public IList<Controller> get_Controllers() { }

	// RVA: 0x18F39B0 Offset: 0x18F2BB0 VA: 0x1818F39B0
	public Controller GetController(ControllerType controllerType, int controllerId) { }

	// RVA: 0x18F3A60 Offset: 0x18F2C60 VA: 0x1818F3A60
	public Controller GetController(ControllerIdentifier controllerIdentifier) { }

	// RVA: 0x18F3B20 Offset: 0x18F2D20 VA: 0x1818F3B20
	public Controller[] GetControllers(ControllerType controllerType) { }

	// RVA: 0x18F3900 Offset: 0x18F2B00 VA: 0x1818F3900
	public string[] GetControllerNames(ControllerType controllerType) { }

	// RVA: 0x18F45C0 Offset: 0x18F37C0 VA: 0x1818F45C0
	public bool IsControllerAssigned(ControllerType controllerType, Controller controller) { }

	// RVA: 0x18F4660 Offset: 0x18F3860 VA: 0x1818F4660
	public bool IsControllerAssigned(ControllerType controllerType, int controllerId) { }

	// RVA: 0x18F4500 Offset: 0x18F3700 VA: 0x1818F4500
	public bool IsControllerAssignedToPlayer(ControllerType controllerType, int controllerId, int playerId) { }

	// RVA: 0x18F4AD0 Offset: 0x18F3CD0 VA: 0x1818F4AD0
	public void RemoveControllerFromAllPlayers(Controller controller, bool includeSystemPlayer = True) { }

	// RVA: 0x18F4B70 Offset: 0x18F3D70 VA: 0x1818F4B70
	public void RemoveControllerFromAllPlayers(ControllerType controllerType, int controllerId, bool includeSystemPlayer = True) { }

	// RVA: 0x18F58C0 Offset: 0x18F4AC0 VA: 0x1818F58C0
	public Mouse get_Mouse() { }

	// RVA: 0x18F5830 Offset: 0x18F4A30 VA: 0x1818F5830
	public Keyboard get_Keyboard() { }

	// RVA: 0x18F5B00 Offset: 0x18F4D00 VA: 0x1818F5B00
	public bool get_keyboardEnabled() { }

	// RVA: 0x18F5B80 Offset: 0x18F4D80 VA: 0x1818F5B80
	public void set_keyboardEnabled(bool value) { }

	// RVA: 0x18F5A70 Offset: 0x18F4C70 VA: 0x1818F5A70
	public int get_joystickCount() { }

	// RVA: 0x18F5790 Offset: 0x18F4990 VA: 0x1818F5790
	public IList<Joystick> get_Joysticks() { }

	// RVA: 0x18F3F70 Offset: 0x18F3170 VA: 0x1818F3F70
	public Joystick GetJoystick(int joystickId) { }

	// RVA: 0x18F4010 Offset: 0x18F3210 VA: 0x1818F4010
	public Joystick[] GetJoysticks() { }

	// RVA: 0x18F3ED0 Offset: 0x18F30D0 VA: 0x1818F3ED0
	public string[] GetJoystickNames() { }

	// RVA: 0x18F4A30 Offset: 0x18F3C30 VA: 0x1818F4A30
	public bool IsJoystickAssigned(Joystick joystick) { }

	// RVA: 0x18F49A0 Offset: 0x18F3BA0 VA: 0x1818F49A0
	public bool IsJoystickAssigned(int joystickId) { }

	// RVA: 0x18F48F0 Offset: 0x18F3AF0 VA: 0x1818F48F0
	public bool IsJoystickAssignedToPlayer(int joystickId, int playerId) { }

	// RVA: 0x18F4E00 Offset: 0x18F4000 VA: 0x1818F4E00
	public void RemoveJoystickFromAllPlayers(Joystick joystick, bool includeSystemPlayer = True) { }

	// RVA: 0x18F4D60 Offset: 0x18F3F60 VA: 0x1818F4D60
	public void RemoveJoystickFromAllPlayers(int joystickId, bool includeSystemPlayer = True) { }

	// RVA: 0x18F43B0 Offset: 0x18F35B0 VA: 0x1818F43B0
	public int GetUnityJoystickIdFromAnyButtonPress() { }

	// RVA: 0x18F4220 Offset: 0x18F3420 VA: 0x1818F4220
	public int GetUnityJoystickIdFromAnyButtonOrAxisPress(float axisThreshold, bool positiveAxesOnly) { }

	// RVA: 0x18F5350 Offset: 0x18F4550 VA: 0x1818F5350
	public void SetUnityJoystickId(int joystickId, int unityJoystickId) { }

	// RVA: 0x18F51C0 Offset: 0x18F43C0 VA: 0x1818F51C0
	public bool SetUnityJoystickIdFromAnyButtonPress(int joystickId) { }

	// RVA: 0x18F4FD0 Offset: 0x18F41D0 VA: 0x1818F4FD0
	public bool SetUnityJoystickIdFromAnyButtonOrAxisPress(int joystickId, float axisThreshold, bool positiveAxesOnly) { }

	// RVA: 0x18F59E0 Offset: 0x18F4BE0 VA: 0x1818F59E0
	public int get_customControllerCount() { }

	// RVA: 0x18F56F0 Offset: 0x18F48F0 VA: 0x1818F56F0
	public IList<CustomController> get_CustomControllers() { }

	// RVA: 0x18F3C70 Offset: 0x18F2E70 VA: 0x1818F3C70
	public CustomController GetCustomController(int customControllerId) { }

	// RVA: 0x18F3D00 Offset: 0x18F2F00 VA: 0x1818F3D00
	public CustomController[] GetCustomControllers() { }

	// RVA: 0x18F3BD0 Offset: 0x18F2DD0 VA: 0x1818F3BD0
	public string[] GetCustomControllerNames() { }

	// RVA: 0x18F47C0 Offset: 0x18F39C0 VA: 0x1818F47C0
	public bool IsCustomControllerAssigned(CustomController customController) { }

	// RVA: 0x18F4860 Offset: 0x18F3A60 VA: 0x1818F4860
	public bool IsCustomControllerAssigned(int customControllerId) { }

	// RVA: 0x18F4710 Offset: 0x18F3910 VA: 0x1818F4710
	public bool IsCustomControllerAssignedToPlayer(int customControllerId, int playerId) { }

	// RVA: 0x18F4C20 Offset: 0x18F3E20 VA: 0x1818F4C20
	public void RemoveCustomControllerFromAllPlayers(CustomController customController, bool includeSystemPlayer = True) { }

	// RVA: 0x18F4CC0 Offset: 0x18F3EC0 VA: 0x1818F4CC0
	public void RemoveCustomControllerFromAllPlayers(int customControllerId, bool includeSystemPlayer = True) { }

	// RVA: 0x18F2EF0 Offset: 0x18F20F0 VA: 0x1818F2EF0
	public CustomController CreateCustomController(int sourceControllerId) { }

	// RVA: 0x18F2E30 Offset: 0x18F2030 VA: 0x1818F2E30
	public CustomController CreateCustomController(int sourceControllerId, string tag) { }

	// RVA: 0x18F30E0 Offset: 0x18F22E0 VA: 0x1818F30E0
	public bool DestroyCustomController(CustomController customController) { }

	// RVA: 0x18F3DA0 Offset: 0x18F2FA0 VA: 0x1818F3DA0
	public CustomController GetFirstCustomControllerWithSourceId(int sourceId) { }

	// RVA: 0x18F3E30 Offset: 0x18F3030 VA: 0x1818F3E30
	public CustomController GetFirstCustomControllerWithTag(string tag) { }

	// RVA: 0x18F2F80 Offset: 0x18F2180 VA: 0x1818F2F80
	public IEnumerable<CustomController> CustomControllersWithSourceId(int sourceId) { }

	// RVA: 0x18F3030 Offset: 0x18F2230 VA: 0x1818F3030
	public IEnumerable<CustomController> CustomControllersWithTag(string tag) { }

	// RVA: -1 Offset: -1
	public IList<TInterface> GetControllerTemplates<TInterface>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACA130 Offset: 0xAC9330 VA: 0x180ACA130
	|-ReInput.ControllerHelper.GetControllerTemplates<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x18F4100 Offset: 0x18F3300 VA: 0x1818F4100
	public Controller GetLastActiveController() { }

	// RVA: 0x18F4190 Offset: 0x18F3390 VA: 0x1818F4190
	public Controller GetLastActiveController(ControllerType controllerType) { }

	// RVA: -1 Offset: -1
	public T GetLastActiveController<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACAB10 Offset: 0xAC9D10 VA: 0x180ACAB10
	|-ReInput.ControllerHelper.GetLastActiveController<object>
	*/

	// RVA: 0x18F4070 Offset: 0x18F3270 VA: 0x1818F4070
	public ControllerType GetLastActiveControllerType() { }

	// RVA: 0x18F2920 Offset: 0x18F1B20 VA: 0x1818F2920
	public void AddLastActiveControllerChangedDelegate(ActiveControllerChangedDelegate callback) { }

	// RVA: 0x18F29B0 Offset: 0x18F1BB0 VA: 0x1818F29B0
	public void AddLastActiveControllerChangedDelegate(ActiveControllerChangedDelegate callback, ControllerType controllerType) { }

	// RVA: 0x18F4EA0 Offset: 0x18F40A0 VA: 0x1818F4EA0
	public void RemoveLastActiveControllerChangedDelegate(ActiveControllerChangedDelegate callback) { }

	// RVA: 0x18F4F30 Offset: 0x18F4130 VA: 0x1818F4F30
	public void RemoveLastActiveControllerChangedDelegate(ActiveControllerChangedDelegate callback, ControllerType controllerType) { }

	// RVA: 0x18F2DA0 Offset: 0x18F1FA0 VA: 0x1818F2DA0
	public void ClearLastActiveControllerChangedDelegates() { }

	// RVA: 0x18F3710 Offset: 0x18F2910 VA: 0x1818F3710
	public bool GetAnyButton() { }

	// RVA: 0x18F3680 Offset: 0x18F2880 VA: 0x1818F3680
	public bool GetAnyButton(ControllerType controllerType) { }

	// RVA: 0x18F3320 Offset: 0x18F2520 VA: 0x1818F3320
	public bool GetAnyButtonDown() { }

	// RVA: 0x18F33B0 Offset: 0x18F25B0 VA: 0x1818F33B0
	public bool GetAnyButtonDown(ControllerType controllerType) { }

	// RVA: 0x18F35F0 Offset: 0x18F27F0 VA: 0x1818F35F0
	public bool GetAnyButtonUp() { }

	// RVA: 0x18F3560 Offset: 0x18F2760 VA: 0x1818F3560
	public bool GetAnyButtonUp(ControllerType controllerType) { }

	// RVA: 0x18F3200 Offset: 0x18F2400 VA: 0x1818F3200
	public bool GetAnyButtonChanged() { }

	// RVA: 0x18F3290 Offset: 0x18F2490 VA: 0x1818F3290
	public bool GetAnyButtonChanged(ControllerType controllerType) { }

	// RVA: 0x18F34D0 Offset: 0x18F26D0 VA: 0x1818F34D0
	public bool GetAnyButtonPrev() { }

	// RVA: 0x18F3440 Offset: 0x18F2640 VA: 0x1818F3440
	public bool GetAnyButtonPrev(ControllerType controllerType) { }

	// RVA: 0x18F2A50 Offset: 0x18F1C50 VA: 0x1818F2A50
	public bool AutoAssignJoystick(Joystick joystick) { }

	// RVA: 0x18F2B30 Offset: 0x18F1D30 VA: 0x1818F2B30
	public void AutoAssignJoysticks() { }
}

// Namespace: 
[Browsable(False)]
[EditorBrowsable(1)]
public sealed class ReInput.MappingHelper : CodeHelper // TypeDefIndex: 7129
{
	// Fields
	private static ReInput.MappingHelper jvdHJASpnUhImEOGQmsLnMbcfiVcb; // 0x0

	// Properties
	internal static ReInput.MappingHelper IqfZanOvDqIvuKavjaRjEeSYywMMA { get; }
	public IList<InputMapCategory> MapCategories { get; }
	public IEnumerable<InputMapCategory> UserAssignableMapCategories { get; }
	public IList<InputCategory> ActionCategories { get; }
	public IEnumerable<InputCategory> UserAssignableActionCategories { get; }
	public IList<InputLayout> JoystickLayouts { get; }
	public IList<InputLayout> KeyboardLayouts { get; }
	public IList<InputLayout> MouseLayouts { get; }
	public IList<InputLayout> CustomControllerLayouts { get; }
	public IList<InputAction> Actions { get; }
	public IEnumerable<InputAction> UserAssignableActions { get; }

	// Methods

	// RVA: 0x18FD7C0 Offset: 0x18FC9C0 VA: 0x1818FD7C0
	internal static ReInput.MappingHelper VVXeCKIxYsdqpsQBhcKFeXVpnNTJ() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x18FDC10 Offset: 0x18FCE10 VA: 0x1818FDC10
	public IList<InputMapCategory> get_MapCategories() { }

	// RVA: 0x18FC250 Offset: 0x18FB450 VA: 0x1818FC250
	public InputMapCategory GetMapCategory(int mapCategoryId) { }

	// RVA: 0x18FC1B0 Offset: 0x18FB3B0 VA: 0x1818FC1B0
	public InputMapCategory GetMapCategory(string name) { }

	// RVA: 0x18FC110 Offset: 0x18FB310 VA: 0x1818FC110
	public int GetMapCategoryId(string name) { }

	// RVA: 0x18FCFD0 Offset: 0x18FC1D0 VA: 0x1818FCFD0
	public IEnumerable<InputMapCategory> MapCategoriesWithTag(string tag) { }

	// RVA: 0x18FDE90 Offset: 0x18FD090 VA: 0x1818FDE90
	public IEnumerable<InputMapCategory> get_UserAssignableMapCategories() { }

	// RVA: 0x18FD710 Offset: 0x18FC910 VA: 0x1818FD710
	public IEnumerable<InputMapCategory> UserAssignableMapCategoriesWithTag(string tag) { }

	// RVA: 0x18FCEF0 Offset: 0x18FC0F0 VA: 0x1818FCEF0
	public bool IsMapCategoryUserAssignable(int mapCategoryId) { }

	// RVA: 0x18F7220 Offset: 0x18F6420 VA: 0x1818F7220
	public InputCategory GetActionCategory(int mapCategoryId) { }

	// RVA: 0x18F7180 Offset: 0x18F6380 VA: 0x1818F7180
	public InputCategory GetActionCategory(string name) { }

	// RVA: 0x18F70E0 Offset: 0x18F62E0 VA: 0x1818F70E0
	public int GetActionCategoryId(string name) { }

	// RVA: 0x18FD8F0 Offset: 0x18FCAF0 VA: 0x1818FD8F0
	public IList<InputCategory> get_ActionCategories() { }

	// RVA: 0x18F6CA0 Offset: 0x18F5EA0 VA: 0x1818F6CA0
	public IEnumerable<InputCategory> ActionCategoriesWithTag(string tag) { }

	// RVA: 0x18FDD50 Offset: 0x18FCF50 VA: 0x1818FDD50
	public IEnumerable<InputCategory> get_UserAssignableActionCategories() { }

	// RVA: 0x18FD380 Offset: 0x18FC580 VA: 0x1818FD380
	public IEnumerable<InputCategory> UserAssignableActionCategoriesWithTag(string tag) { }

	// RVA: 0x18FCE10 Offset: 0x18FC010 VA: 0x1818FCE10
	public bool IsActionCategoryUserAssignable(int mapCategoryId) { }

	// RVA: 0x18FBD50 Offset: 0x18FAF50 VA: 0x1818FBD50
	public InputLayout GetLayout(ControllerType controllerType, int layoutId) { }

	// RVA: 0x18FBF30 Offset: 0x18FB130 VA: 0x1818FBF30
	public InputLayout GetLayout(ControllerType controllerType, string name) { }

	// RVA: 0x18FBB70 Offset: 0x18FAD70 VA: 0x1818FBB70
	public int GetLayoutId(ControllerType controllerType, string name) { }

	// RVA: 0x18FA1D0 Offset: 0x18F93D0 VA: 0x1818FA1D0
	public InputLayout GetJoystickLayout(int layoutId) { }

	// RVA: 0x18FA130 Offset: 0x18F9330 VA: 0x1818FA130
	public InputLayout GetJoystickLayout(string name) { }

	// RVA: 0x18FA090 Offset: 0x18F9290 VA: 0x1818FA090
	public int GetJoystickLayoutId(string name) { }

	// RVA: 0x18FB520 Offset: 0x18FA720 VA: 0x1818FB520
	public InputLayout GetKeyboardLayout(int layoutId) { }

	// RVA: 0x18FB5B0 Offset: 0x18FA7B0 VA: 0x1818FB5B0
	public InputLayout GetKeyboardLayout(string name) { }

	// RVA: 0x18FB480 Offset: 0x18FA680 VA: 0x1818FB480
	public int GetKeyboardLayoutId(string name) { }

	// RVA: 0x18FC420 Offset: 0x18FB620 VA: 0x1818FC420
	public InputLayout GetMouseLayout(int layoutId) { }

	// RVA: 0x18FC380 Offset: 0x18FB580 VA: 0x1818FC380
	public InputLayout GetMouseLayout(string name) { }

	// RVA: 0x18FC2E0 Offset: 0x18FB4E0 VA: 0x1818FC2E0
	public int GetMouseLayoutId(string name) { }

	// RVA: 0x18F8CC0 Offset: 0x18F7EC0 VA: 0x1818F8CC0
	public InputLayout GetCustomControllerLayout(int layoutId) { }

	// RVA: 0x18F8D50 Offset: 0x18F7F50 VA: 0x1818F8D50
	public InputLayout GetCustomControllerLayout(string name) { }

	// RVA: 0x18F8C20 Offset: 0x18F7E20 VA: 0x1818F8C20
	public int GetCustomControllerLayoutId(string name) { }

	// RVA: 0x18FD080 Offset: 0x18FC280 VA: 0x1818FD080
	public IList<InputLayout> MapLayouts(ControllerType controllerType) { }

	// RVA: 0x18FDAD0 Offset: 0x18FCCD0 VA: 0x1818FDAD0
	public IList<InputLayout> get_JoystickLayouts() { }

	// RVA: 0x18FDB70 Offset: 0x18FCD70 VA: 0x1818FDB70
	public IList<InputLayout> get_KeyboardLayouts() { }

	// RVA: 0x18FDCB0 Offset: 0x18FCEB0 VA: 0x1818FDCB0
	public IList<InputLayout> get_MouseLayouts() { }

	// RVA: 0x18FDA30 Offset: 0x18FCC30 VA: 0x1818FDA30
	public IList<InputLayout> get_CustomControllerLayouts() { }

	// RVA: 0x18FD990 Offset: 0x18FCB90 VA: 0x1818FD990
	public IList<InputAction> get_Actions() { }

	// RVA: 0x18F75E0 Offset: 0x18F67E0 VA: 0x1818F75E0
	public InputAction GetAction(int actionId) { }

	// RVA: 0x18F7670 Offset: 0x18F6870 VA: 0x1818F7670
	public InputAction GetAction(string name) { }

	// RVA: 0x18F7540 Offset: 0x18F6740 VA: 0x1818F7540
	public int GetActionId(string name) { }

	// RVA: 0x18FDDF0 Offset: 0x18FCFF0 VA: 0x1818FDDF0
	public IEnumerable<InputAction> get_UserAssignableActions() { }

	// RVA: 0x18F7030 Offset: 0x18F6230 VA: 0x1818F7030
	public IEnumerable<InputAction> ActionsInCategory(string mapCategoryName) { }

	// RVA: 0x18F6E00 Offset: 0x18F6000 VA: 0x1818F6E00
	public IEnumerable<InputAction> ActionsInCategory(string mapCategoryName, bool sort) { }

	// RVA: 0x18F6F80 Offset: 0x18F6180 VA: 0x1818F6F80
	public IEnumerable<InputAction> ActionsInCategory(int mapCategoryId) { }

	// RVA: 0x18F6EC0 Offset: 0x18F60C0 VA: 0x1818F6EC0
	public IEnumerable<InputAction> ActionsInCategory(int mapCategoryId, bool sort) { }

	// RVA: 0x18F6D50 Offset: 0x18F5F50 VA: 0x1818F6D50
	public IEnumerable<InputAction> ActionsInCategoriesWithTag(string tag) { }

	// RVA: 0x18FD660 Offset: 0x18FC860 VA: 0x1818FD660
	public IEnumerable<InputAction> UserAssignableActionsInCategory(int mapCategoryId) { }

	// RVA: 0x18FD430 Offset: 0x18FC630 VA: 0x1818FD430
	public IEnumerable<InputAction> UserAssignableActionsInCategory(int mapCategoryId, bool sort) { }

	// RVA: 0x18FD5B0 Offset: 0x18FC7B0 VA: 0x1818FD5B0
	public IEnumerable<InputAction> UserAssignableActionsInCategory(string mapCategoryName) { }

	// RVA: 0x18FD4F0 Offset: 0x18FC6F0 VA: 0x1818FD4F0
	public IEnumerable<InputAction> UserAssignableActionsInCategory(string mapCategoryName, bool sort) { }

	// RVA: 0x18F9FE0 Offset: 0x18F91E0 VA: 0x1818F9FE0
	public IList<InputBehavior> GetInputBehaviors(int playerId) { }

	// RVA: 0x18FCC80 Offset: 0x18FBE80 VA: 0x1818FCC80
	public IList<InputBehavior> GetSystemPlayerInputBehaviors() { }

	// RVA: 0x18F9F30 Offset: 0x18F9130 VA: 0x1818F9F30
	public InputBehavior GetInputBehavior(int playerId, int behaviorId) { }

	// RVA: 0x18F9E80 Offset: 0x18F9080 VA: 0x1818F9E80
	public InputBehavior GetInputBehavior(int playerId, string behaviorName) { }

	// RVA: 0x18FCAC0 Offset: 0x18FBCC0 VA: 0x1818FCAC0
	public InputBehavior GetSystemPlayerInputBehavior(int behaviorId) { }

	// RVA: 0x18FCBA0 Offset: 0x18FBDA0 VA: 0x1818FCBA0
	public InputBehavior GetSystemPlayerInputBehavior(string behaviorName) { }

	// RVA: 0x18F9DE0 Offset: 0x18F8FE0 VA: 0x1818F9DE0
	public int GetInputBehaviorId(string behaviorName) { }

	// RVA: 0x18FCDA0 Offset: 0x18FBFA0 VA: 0x1818FCDA0
	internal InputBehavior IhnRGIOUsfJgiiVcGbZnHSiirrMT(int ) { }

	// RVA: 0x18FCD30 Offset: 0x18FBF30 VA: 0x1818FCD30
	internal InputBehavior IhnRGIOUsfJgiiVcGbZnHSiirrMT(string ) { }

	// RVA: 0x18F8870 Offset: 0x18F7A70 VA: 0x1818F8870
	public ControllerMap GetControllerMap(int id) { }

	// RVA: 0x18F72B0 Offset: 0x18F64B0 VA: 0x1818F72B0
	public ActionElementMap GetActionElementMap(int id) { }

	// RVA: 0x18F84D0 Offset: 0x18F76D0 VA: 0x1818F84D0
	public ControllerMap GetControllerMapInstance(Controller controller, int mapCategoryId, int layoutId) { }

	// RVA: 0x18F8170 Offset: 0x18F7370 VA: 0x1818F8170
	public ControllerMap GetControllerMapInstance(Controller controller, string mapCategoryName, string layoutName) { }

	// RVA: 0x18F8240 Offset: 0x18F7440 VA: 0x1818F8240
	public ControllerMap GetControllerMapInstance(ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName) { }

	// RVA: 0x18F7F80 Offset: 0x18F7180 VA: 0x1818F7F80
	public ControllerMap GetControllerMapInstance(ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId) { }

	// RVA: 0x18FAA90 Offset: 0x18F9C90 VA: 0x1818FAA90
	public JoystickMap GetJoystickMapInstance(Joystick joystick, int mapCategoryId, int layoutId) { }

	// RVA: 0x18FB350 Offset: 0x18FA550 VA: 0x1818FB350
	public JoystickMap GetJoystickMapInstance(Joystick joystick, string mapCategoryName, string layoutName) { }

	// RVA: 0x18FAB80 Offset: 0x18F9D80 VA: 0x1818FAB80
	public JoystickMap GetJoystickMapInstance(Guid joystickTypeGuid, int mapCategoryId, int layoutId) { }

	// RVA: 0x18FAE90 Offset: 0x18FA090 VA: 0x1818FAE90
	public JoystickMap GetJoystickMapInstance(Guid joystickTypeGuid, string mapCategoryName, string layoutName) { }

	// RVA: 0x18FB080 Offset: 0x18FA280 VA: 0x1818FB080
	public JoystickMap GetJoystickMapInstance(ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId) { }

	// RVA: 0x18FB200 Offset: 0x18FA400 VA: 0x1818FB200
	public JoystickMap GetJoystickMapInstance(ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName) { }

	// RVA: 0x18FB980 Offset: 0x18FAB80 VA: 0x1818FB980
	public KeyboardMap GetKeyboardMapInstance(int mapCategoryId, int layoutId) { }

	// RVA: 0x18FBAC0 Offset: 0x18FACC0 VA: 0x1818FBAC0
	public KeyboardMap GetKeyboardMapInstance(string mapCategoryName, string layoutName) { }

	// RVA: 0x18FC980 Offset: 0x18FBB80 VA: 0x1818FC980
	public MouseMap GetMouseMapInstance(int mapCategoryId, int layoutId) { }

	// RVA: 0x18FC850 Offset: 0x18FBA50 VA: 0x1818FC850
	public MouseMap GetMouseMapInstance(string mapCategoryName, string layoutName) { }

	// RVA: 0x18F9830 Offset: 0x18F8A30 VA: 0x1818F9830
	public CustomControllerMap GetCustomControllerMapInstance(CustomController customController, int mapCategoryId, int layoutId) { }

	// RVA: 0x18F9700 Offset: 0x18F8900 VA: 0x1818F9700
	public CustomControllerMap GetCustomControllerMapInstance(CustomController customController, string mapCategoryName, string layoutName) { }

	// RVA: 0x18F9930 Offset: 0x18F8B30 VA: 0x1818F9930
	public CustomControllerMap GetCustomControllerMapInstance(ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId) { }

	// RVA: 0x18F95B0 Offset: 0x18F87B0 VA: 0x1818F95B0
	public CustomControllerMap GetCustomControllerMapInstance(ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName) { }

	// RVA: 0x18F7D70 Offset: 0x18F6F70 VA: 0x1818F7D70
	public ControllerMap GetControllerMapInstanceSavedOrDefault(int playerId, Controller controller, int mapCategoryId, int layoutId) { }

	// RVA: 0x18F7CA0 Offset: 0x18F6EA0 VA: 0x1818F7CA0
	public ControllerMap GetControllerMapInstanceSavedOrDefault(int playerId, Controller controller, string mapCategoryName, string layoutName) { }

	// RVA: 0x18F7B00 Offset: 0x18F6D00 VA: 0x1818F7B00
	public ControllerMap GetControllerMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId) { }

	// RVA: 0x18F78E0 Offset: 0x18F6AE0 VA: 0x1818F78E0
	public ControllerMap GetControllerMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName) { }

	// RVA: 0x18FA390 Offset: 0x18F9590 VA: 0x1818FA390
	public JoystickMap GetJoystickMapInstanceSavedOrDefault(int playerId, Joystick joystick, int mapCategoryId, int layoutId) { }

	// RVA: 0x18FA260 Offset: 0x18F9460 VA: 0x1818FA260
	public JoystickMap GetJoystickMapInstanceSavedOrDefault(int playerId, Joystick joystick, string mapCategoryName, string layoutName) { }

	// RVA: 0x18FA5C0 Offset: 0x18F97C0 VA: 0x1818FA5C0
	public JoystickMap GetJoystickMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId) { }

	// RVA: 0x18FA460 Offset: 0x18F9660 VA: 0x1818FA460
	public JoystickMap GetJoystickMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName) { }

	// RVA: 0x18F8DF0 Offset: 0x18F7FF0 VA: 0x1818F8DF0
	public CustomControllerMap GetCustomControllerMapInstanceSavedOrDefault(int playerId, CustomController customController, int mapCategoryId, int layoutId) { }

	// RVA: 0x18F9480 Offset: 0x18F8680 VA: 0x1818F9480
	public CustomControllerMap GetCustomControllerMapInstanceSavedOrDefault(int playerId, CustomController customController, string mapCategoryName, string layoutName) { }

	// RVA: 0x18F8E90 Offset: 0x18F8090 VA: 0x1818F8E90
	public CustomControllerMap GetCustomControllerMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId) { }

	// RVA: 0x18F9320 Offset: 0x18F8520 VA: 0x1818F9320
	public CustomControllerMap GetCustomControllerMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName) { }

	// RVA: 0x18FB650 Offset: 0x18FA850 VA: 0x1818FB650
	public KeyboardMap GetKeyboardMapInstanceSavedOrDefault(int playerId, int mapCategoryId, int layoutId) { }

	// RVA: 0x18FB8C0 Offset: 0x18FAAC0 VA: 0x1818FB8C0
	public KeyboardMap GetKeyboardMapInstanceSavedOrDefault(int playerId, string mapCategoryName, string layoutName) { }

	// RVA: 0x18FC5E0 Offset: 0x18FB7E0 VA: 0x1818FC5E0
	public MouseMap GetMouseMapInstanceSavedOrDefault(int playerId, int mapCategoryId, int layoutId) { }

	// RVA: 0x18FC4B0 Offset: 0x18FB6B0 VA: 0x1818FC4B0
	public MouseMap GetMouseMapInstanceSavedOrDefault(int playerId, string mapCategoryName, string layoutName) { }

	[Obsolete("This method has been deprecated. Use the Controller Template system instead.", False)]
	// RVA: 0x18F9CC0 Offset: 0x18F8EC0 VA: 0x1818F9CC0
	public ControllerElementIdentifier GetFirstJoystickTemplateElementIdentifier(Joystick joystick, int joystickElementIdentifierId) { }

	// RVA: 0x18FDF30 Offset: 0x18FD130 VA: 0x1818FDF30
	private ControllerElementIdentifier wfBaOtpQhCyWyvIYDAUtUsZHeyyL(Guid , int ) { }

	// RVA: 0x18FD830 Offset: 0x18FCA30 VA: 0x1818FD830
	internal int cSJeKxTPfoFwleWrsdkCorObfuGe(Guid , Guid , int , List<HardwareControllerTemplateMap.rwEetQoHfXcCclqvIDEVKbecRXpDb> ) { }

	// RVA: 0x18F89A0 Offset: 0x18F7BA0 VA: 0x1818F89A0
	public ControllerTemplateMap GetControllerTemplateMapInstance(Guid templateTypeGuid, int mapCategoryId, int layoutId) { }

	// RVA: 0x18F8A70 Offset: 0x18F7C70 VA: 0x1818F8A70
	public ControllerTemplateMap GetControllerTemplateMapInstance(Guid templateTypeGuid, string mapCategoryName, string layoutName) { }

	// RVA: 0x18F86A0 Offset: 0x18F78A0 VA: 0x1818F86A0
	public ControllerMapLayoutManager.RuleSet GetControllerMapLayoutManagerRuleSetInstance(int id) { }

	// RVA: 0x18F8740 Offset: 0x18F7940 VA: 0x1818F8740
	public ControllerMapLayoutManager.RuleSet GetControllerMapLayoutManagerRuleSetInstance(string name) { }

	// RVA: 0x18F7710 Offset: 0x18F6910 VA: 0x1818F7710
	public ControllerMapEnabler.RuleSet GetControllerMapEnablerRuleSetInstance(int id) { }

	// RVA: 0x18F77B0 Offset: 0x18F69B0 VA: 0x1818F77B0
	public ControllerMapEnabler.RuleSet GetControllerMapEnablerRuleSetInstance(string name) { }
}

// Namespace: 
[Browsable(False)]
[EditorBrowsable(1)]
public sealed class ReInput.PlayerHelper : CodeHelper // TypeDefIndex: 7130
{
	// Fields
	private static ReInput.PlayerHelper jvdHJASpnUhImEOGQmsLnMbcfiVcb; // 0x0

	// Properties
	internal static ReInput.PlayerHelper IqfZanOvDqIvuKavjaRjEeSYywMMA { get; }
	public int playerCount { get; }
	public int allPlayerCount { get; }
	public IList<Player> Players { get; }
	public IList<Player> AllPlayers { get; }
	public Player SystemPlayer { get; }

	// Methods

	// RVA: 0x191ACA0 Offset: 0x1919EA0 VA: 0x18191ACA0
	internal static ReInput.PlayerHelper VVXeCKIxYsdqpsQBhcKFeXVpnNTJ() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x191AF70 Offset: 0x191A170 VA: 0x18191AF70
	public int get_playerCount() { }

	// RVA: 0x191AEE0 Offset: 0x191A0E0 VA: 0x18191AEE0
	public int get_allPlayerCount() { }

	// RVA: 0x191ADB0 Offset: 0x1919FB0 VA: 0x18191ADB0
	public IList<Player> get_Players() { }

	// RVA: 0x191AD10 Offset: 0x1919F10 VA: 0x18191AD10
	public IList<Player> get_AllPlayers() { }

	// RVA: 0x191AE50 Offset: 0x191A050 VA: 0x18191AE50
	public Player get_SystemPlayer() { }

	// RVA: 0x191AB30 Offset: 0x1919D30 VA: 0x18191AB30
	public IList<Player> GetPlayers(bool includeSystemPlayer = False) { }

	// RVA: 0x191AA00 Offset: 0x1919C00 VA: 0x18191AA00
	public Player GetPlayer(int playerId) { }

	// RVA: 0x191AA90 Offset: 0x1919C90 VA: 0x18191AA90
	public Player GetPlayer(string name) { }

	// RVA: 0x191AC10 Offset: 0x1919E10 VA: 0x18191AC10
	public Player GetSystemPlayer() { }

	// RVA: 0x191A800 Offset: 0x1919A00 VA: 0x18191A800
	public int GetPlayerId(string playerName) { }

	// RVA: 0x191A950 Offset: 0x1919B50 VA: 0x18191A950
	public string[] GetPlayerNames(bool includeSystemPlayer = False) { }

	// RVA: 0x191A750 Offset: 0x1919950 VA: 0x18191A750
	public string[] GetPlayerDescriptiveNames(bool includeSystemPlayer = False) { }

	// RVA: 0x191A8A0 Offset: 0x1919AA0 VA: 0x18191A8A0
	public int[] GetPlayerIds(bool includeSystemPlayer = False) { }
}

// Namespace: 
[EditorBrowsable(1)]
[Browsable(False)]
public sealed class ReInput.TimeHelper : CodeHelper // TypeDefIndex: 7131
{
	// Fields
	private static ReInput.TimeHelper jvdHJASpnUhImEOGQmsLnMbcfiVcb; // 0x0

	// Properties
	internal static ReInput.TimeHelper IqfZanOvDqIvuKavjaRjEeSYywMMA { get; }
	public float unscaledDeltaTime { get; }
	public double unscaledTime { get; }
	public uint currentFrame { get; }

	// Methods

	// RVA: 0x191C990 Offset: 0x191BB90 VA: 0x18191C990
	internal static ReInput.TimeHelper VVXeCKIxYsdqpsQBhcKFeXVpnNTJ() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x191CA90 Offset: 0x191BC90 VA: 0x18191CA90
	public float get_unscaledDeltaTime() { }

	// RVA: 0x191CB30 Offset: 0x191BD30 VA: 0x18191CB30
	public double get_unscaledTime() { }

	// RVA: 0x191CA00 Offset: 0x191BC00 VA: 0x18191CA00
	public uint get_currentFrame() { }
}

// Namespace: 
private class ReInput.NjXLLDTPDWnVZVirsVtCdbPjHdrhA.CBApMUGvgRiNwONdkTGoDIJmDvxt // TypeDefIndex: 7132
{
	// Fields
	public readonly UpdateLoopType pdMpguIIJSXJuwgCZpDStKcWwtYN; // 0x10
	private double vjYOXafuPEAPUTMOQBNqKJASTAFP; // 0x18
	private double hOWWNgOOPwhBuaXRGYrGolsdUjEJ; // 0x20
	private double KXNoCPXmYfifLFXYPoHrZjvDfVXBA; // 0x28
	private double xzVXQydQlzjqujTdnpgBBOFKkzAHB; // 0x30
	private uint xmSngtWeDoUqqLBJbCgRcFiFHolyA; // 0x38
	private uint yodDNOjKeRFRmOOEMDCmBtxhtuWl; // 0x3C
	private float XBePePwUyGrQXIRAPsojRVkQSvfv; // 0x40
	private float eaOCelgpoeLeZJNyVbIlPcEpyuZCA; // 0x44

	// Properties
	public double nTcaqQfhdTLhZeeOfofELvTWakFXA { get; }
	public double JyslsSWsuCskoyaZRwnUERmmmcJE { get; }
	public double KyhEJqoPmMlvCDvbeAZkzPDLxJyg { get; }
	public uint jDETqmcQGmkxuPXGJTlhAhMlFUaDA { get; }
	public uint FXvTbdkcmbnqTdxWIVfbrtxYBiKi { get; }
	public float qjIDDEchnMySWeFXkqkpjsBvaISJ { get; }
	public float MajZcdywbMuxoZTAnBoIVnaNpzno { get; }

	// Methods

	// RVA: 0x190A670 Offset: 0x1909870 VA: 0x18190A670
	public double VNFlvauUDFMaMQlfbglGHZXIFrhj() { }

	// RVA: 0x52F520 Offset: 0x52E720 VA: 0x18052F520
	public double tAaDSvJKLoZqkZfeZIaferzNDBwi() { }

	// RVA: 0x52EF20 Offset: 0x52E120 VA: 0x18052EF20
	public double sluhWySVoraHVUmsKMsZxEiCvRut() { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	public uint jLWkhoSGPBaNmpvHgoLRnZImSAij() { }

	// RVA: 0x15FEBE0 Offset: 0x15FDDE0 VA: 0x1815FEBE0
	public uint pBRXDCJKZAPfNCkerJXGbGNGXIDF() { }

	// RVA: 0x78EC10 Offset: 0x78DE10 VA: 0x18078EC10
	public float kVcyHZTMfDVGqtAZIVKZqMGtvOqg() { }

	// RVA: 0x78EC00 Offset: 0x78DE00 VA: 0x18078EC00
	public float gNuZuSVvykFocqAZxLdLdrNLbDoP() { }

	// RVA: 0x190A680 Offset: 0x1909880 VA: 0x18190A680
	public void .ctor(UpdateLoopType ) { }

	// RVA: 0x190A510 Offset: 0x1909710 VA: 0x18190A510
	public void NXsdcUmvlchkKwnLJYZgvWkOUNSV() { }
}

// Namespace: 
private static class ReInput.NjXLLDTPDWnVZVirsVtCdbPjHdrhA.rMBgSJgRwNHEzFWHCcGmLULblkfOe // TypeDefIndex: 7133
{
	// Properties
	public static StopwatchBase ZOdYmTPLlQWrqlBFEpzCwxkipBOj { get; }

	// Methods

	// RVA: 0x1921680 Offset: 0x1920880 VA: 0x181921680
	public static StopwatchBase prEbZqqxoswvlzpZxBkukAsabpFv() { }

	// RVA: 0x19215B0 Offset: 0x19207B0 VA: 0x1819215B0
	public static StopwatchBase TZpAtmoswOXHtgELCQOweYKzFlBS() { }

	// RVA: 0x1921730 Offset: 0x1920930 VA: 0x181921730
	public static StopwatchBase rffHlHKsgchrDNfISGuKBqiJwKOSA() { }
}

// Namespace: 
private class ReInput.NjXLLDTPDWnVZVirsVtCdbPjHdrhA // TypeDefIndex: 7134
{
	// Fields
	private StopwatchBase RbzyMzUHvycxnWYnWuYAbbnkgdxK; // 0x10
	private double GkEvpYkUGUTVYFNIweVbBwuYXLDeA; // 0x18
	private ReInput.NjXLLDTPDWnVZVirsVtCdbPjHdrhA.CBApMUGvgRiNwONdkTGoDIJmDvxt qtAaqNETFVJxRyTxafderOhZcAEJA; // 0x20
	private ADictionary<int, ReInput.NjXLLDTPDWnVZVirsVtCdbPjHdrhA.CBApMUGvgRiNwONdkTGoDIJmDvxt> XSRnMZQBlzJTsGaTmzNPJuKJtAGj; // 0x28
	private uint uQmeYDgBxeKDemTYAFrOcaZiwPueA; // 0x30

	// Properties
	public double nTcaqQfhdTLhZeeOfofELvTWakFXA { get; }
	public double JyslsSWsuCskoyaZRwnUERmmmcJE { get; }
	public double KyhEJqoPmMlvCDvbeAZkzPDLxJyg { get; }
	public float qjIDDEchnMySWeFXkqkpjsBvaISJ { get; }
	public float MajZcdywbMuxoZTAnBoIVnaNpzno { get; }
	internal double WTeahtoDrBZbQBKGneZcvFYzcYlH { get; }
	public uint jDETqmcQGmkxuPXGJTlhAhMlFUaDA { get; }
	public uint FXvTbdkcmbnqTdxWIVfbrtxYBiKi { get; }
	public uint lFstCtWJiyHQMaPawfyYIPoCYxREA { get; }

	// Methods

	// RVA: 0x191A100 Offset: 0x1919300 VA: 0x18191A100
	public double VNFlvauUDFMaMQlfbglGHZXIFrhj() { }

	// RVA: 0x191A2C0 Offset: 0x19194C0 VA: 0x18191A2C0
	public double tAaDSvJKLoZqkZfeZIaferzNDBwi() { }

	// RVA: 0x191A2A0 Offset: 0x19194A0 VA: 0x18191A2A0
	public double sluhWySVoraHVUmsKMsZxEiCvRut() { }

	// RVA: 0x191A260 Offset: 0x1919460 VA: 0x18191A260
	public float kVcyHZTMfDVGqtAZIVKZqMGtvOqg() { }

	// RVA: 0x191A220 Offset: 0x1919420 VA: 0x18191A220
	public float gNuZuSVvykFocqAZxLdLdrNLbDoP() { }

	// RVA: 0x191A120 Offset: 0x1919320 VA: 0x18191A120
	internal double ZOzbtDBuZHhPeBmocGapgTtBEQeNA() { }

	// RVA: 0x191A240 Offset: 0x1919440 VA: 0x18191A240
	public uint jLWkhoSGPBaNmpvHgoLRnZImSAij() { }

	// RVA: 0x191A280 Offset: 0x1919480 VA: 0x18191A280
	public uint pBRXDCJKZAPfNCkerJXGbGNGXIDF() { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public uint kfnjsZCHIahBPFPUjtbIQdMMvsxZb() { }

	// RVA: 0x191A160 Offset: 0x1919360 VA: 0x18191A160
	public void .ctor() { }

	// RVA: 0x1919C40 Offset: 0x1918E40 VA: 0x181919C40
	public void BKsiLsfqHnprRnILdDRQDUUjnRBT() { }

	// RVA: 0x1919ED0 Offset: 0x19190D0 VA: 0x181919ED0
	public void PKwtxaXvImPLSHYDPPVYFvKIgugQ() { }

	// RVA: 0x1919C70 Offset: 0x1918E70 VA: 0x181919C70
	public void NXsdcUmvlchkKwnLJYZgvWkOUNSV(UpdateLoopType ) { }
}

// Namespace: 
[EditorBrowsable(1)]
[Browsable(False)]
public sealed class ReInput.UnityTouch : CodeHelper // TypeDefIndex: 7135
{
	// Fields
	private static ReInput.UnityTouch jvdHJASpnUhImEOGQmsLnMbcfiVcb; // 0x0

	// Properties
	internal static ReInput.UnityTouch IqfZanOvDqIvuKavjaRjEeSYywMMA { get; }
	public int touchCount { get; }
	public Touch[] touches { get; }
	public bool simulateMouseWithTouches { get; set; }
	public bool multiTouchEnabled { get; set; }

	// Methods

	// RVA: 0x191CC10 Offset: 0x191BE10 VA: 0x18191CC10
	internal static ReInput.UnityTouch VVXeCKIxYsdqpsQBhcKFeXVpnNTJ() { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	private void .ctor() { }

	// RVA: 0x191CCA0 Offset: 0x191BEA0 VA: 0x18191CCA0
	public int get_touchCount() { }

	// RVA: 0x191CCB0 Offset: 0x191BEB0 VA: 0x18191CCB0
	public Touch[] get_touches() { }

	// RVA: 0x191CC90 Offset: 0x191BE90 VA: 0x18191CC90
	public bool get_simulateMouseWithTouches() { }

	// RVA: 0x191CCD0 Offset: 0x191BED0 VA: 0x18191CCD0
	public void set_simulateMouseWithTouches(bool value) { }

	// RVA: 0x191CC80 Offset: 0x191BE80 VA: 0x18191CC80
	public bool get_multiTouchEnabled() { }

	// RVA: 0x191CCC0 Offset: 0x191BEC0 VA: 0x18191CCC0
	public void set_multiTouchEnabled(bool value) { }

	// RVA: 0x191CBC0 Offset: 0x191BDC0 VA: 0x18191CBC0
	public Touch GetTouch(int index) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ReInput.sXQSxoWQnKrKHYfWTCWkQZBivVJj.vmChDeulybOTSVemqFGVemuNMtrRA // TypeDefIndex: 7136
{
	// Fields
	public static readonly ReInput.sXQSxoWQnKrKHYfWTCWkQZBivVJj.vmChDeulybOTSVemqFGVemuNMtrRA <>9; // 0x0
	public static Func<bool> <>9__12_1; // 0x8
	public static Func<bool> <>9__12_2; // 0x10
	public static Func<int> <>9__12_3; // 0x18
	public static Func<float> <>9__12_4; // 0x20
	public static Func<bool> <>9__12_5; // 0x28
	public static Func<string> <>9__12_0; // 0x30

	// Methods

	// RVA: 0x1922410 Offset: 0x1921610 VA: 0x181922410
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1922470 Offset: 0x1921670 VA: 0x181922470
	internal bool bDMVkzFFtLgjygNEhyNvvcNBwVpfA() { }

	// RVA: 0x19224B0 Offset: 0x19216B0 VA: 0x1819224B0
	internal bool xPUPwvTSlcIIhwtpxqfIFMzGFsOW() { }

	// RVA: 0x1922480 Offset: 0x1921680 VA: 0x181922480
	internal int ghWgmUVwRdhmiFmEYAFMhqqdEuXDA() { }

	// RVA: 0x1922390 Offset: 0x1921590 VA: 0x181922390
	internal float GcRNpTvHAhCeYaRDkUTNZiHBbGHL() { }

	// RVA: 0x1922490 Offset: 0x1921690 VA: 0x181922490
	internal bool lZBqVdoINgTWxeSlBDaIYFOkeXJN() { }

	// RVA: 0x19223A0 Offset: 0x19215A0 VA: 0x1819223A0
	internal string KCwVlPKqqBEcUvSfBMdrHMPOdDrK() { }
}

// Namespace: 
internal class ReInput.sXQSxoWQnKrKHYfWTCWkQZBivVJj // TypeDefIndex: 7137
{
	// Fields
	public readonly ValueWatcher<bool> aNCGtnqEloclKdyGotdKaIAOrtrP; // 0x10
	public readonly ValueWatcher<bool> FQVTkMghRamUGcCEGYTSXTHFQFJW; // 0x18
	public readonly ValueWatcher<bool> wYmVkKNfgahFadgqyElFFglEJOXD; // 0x20
	public readonly ValueWatcher<bool> LMUpXhtRbHiVGgOnzOgYotWYaXkj; // 0x28
	public readonly ValueWatcher<int> FMgIbvMKflkGKUWunIcHMkbMGtme; // 0x30
	public readonly ValueWatcher<float> KyhEJqoPmMlvCDvbeAZkzPDLxJyg; // 0x38
	public readonly ValueWatcher<string> ytmxgxOPWyDBERsnbhCbVhCRKihH; // 0x40
	public readonly ValueWatcher<bool> GRGnxsmkYulEhIWqpEzLPyfktvAG; // 0x48
	private int rJuskLxDfduLvcenWgzKasEJHnwDb; // 0x50
	private readonly ValueWatcher[] sjYwdImKVeKxyHCHLeGNZtDMmlId; // 0x58

	// Properties
	public int WZgaWSGrUCEkfxoWvVKAqYQwEvODA { get; }

	// Methods

	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410
	public int OJPMKqIRIPlGSdmOqmxxQaFjvdvL() { }

	// RVA: 0x19218F0 Offset: 0x1920AF0 VA: 0x1819218F0
	public void .ctor() { }

	// RVA: 0x1921860 Offset: 0x1920A60 VA: 0x181921860
	public void NXsdcUmvlchkKwnLJYZgvWkOUNSV() { }

	// RVA: 0x19217D0 Offset: 0x19209D0 VA: 0x1819217D0
	public void MAwUsumEJXEewdNoMJwMLrjZTgGZ() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ReInput.OeMhZirdGuwyFKMcSlDIwbjzrpZq // TypeDefIndex: 7138
{
	// Fields
	public static readonly ReInput.OeMhZirdGuwyFKMcSlDIwbjzrpZq <>9; // 0x0
	public static Func<bool> <>9__235_0; // 0x8

	// Methods

	// RVA: 0x191A400 Offset: 0x1919600 VA: 0x18191A400
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x191A4C0 Offset: 0x19196C0 VA: 0x18191A4C0
	internal void hHJffxmhfZVjfnPwjoCAoqpnnLNh(Exception ) { }

	// RVA: 0x191A580 Offset: 0x1919780 VA: 0x18191A580
	internal void tHcdPAbwyRbdiPZWTBmbgKIGBumHb(Exception ) { }

	// RVA: 0x191A460 Offset: 0x1919660 VA: 0x18191A460
	internal void fLKxYYTKBbHeFnOYBuFsewqtsNom(Exception ) { }

	// RVA: 0x191A6B0 Offset: 0x19198B0 VA: 0x18191A6B0
	internal void yvcEaneuhqdPhHCaisSnBoFgRUUQc(Exception ) { }

	// RVA: 0x191A340 Offset: 0x1919540 VA: 0x18191A340
	internal void SGudZncSGNbVWCSpFGCJBdICbuCbC(Exception ) { }

	// RVA: 0x191A2E0 Offset: 0x19194E0 VA: 0x18191A2E0
	internal void AmUoluhUnDjHzACUSauyDGlFwymg(Exception ) { }

	// RVA: 0x191A520 Offset: 0x1919720 VA: 0x18191A520
	internal void quobKBaXctqBVqKGoXndCJtyOWDEA(Exception ) { }

	// RVA: 0x191A3A0 Offset: 0x19195A0 VA: 0x18191A3A0
	internal void TIKIOqTMjpiCygzAFYvshVdExVMu(Exception ) { }

	// RVA: 0x191A650 Offset: 0x1919850 VA: 0x18191A650
	internal void wyfWGNJwHopPcEzBKqFPJNzkTLrC(Exception ) { }

	// RVA: 0x191A5E0 Offset: 0x19197E0 VA: 0x18191A5E0
	internal bool vhkcdEclYvtONvETDppltfPvEWebA() { }
}

// Namespace: Rewired
public static class ReInput // TypeDefIndex: 7139
{
	// Fields
	[CustomObfuscation(rename = False)]
	internal const int programVersion1 = 1;
	[CustomObfuscation(rename = False)]
	internal const int programVersion2 = 1;
	[CustomObfuscation(rename = False)]
	internal const int programVersion3 = 57;
	[CustomObfuscation(rename = False)]
	internal const int programVersion4 = 2;
	[CustomObfuscation(rename = False)]
	internal const int dataVersion = 1;
	[CustomObfuscation(rename = False)]
	internal const bool isTrial = False;
	[CustomObfuscation(rename = False)]
	internal const string majorBranch = "U2021";
	private static InputManager_Base dtbFdrHUJXJWkCQeFNawkKBhYoDlE; // 0x0
	private static PlatformInputManager ihfbQBAHhnvxhoaFSXpZIeUjLVjP; // 0x8
	internal static PdMmEhxUIynfaCicoFNoPZdpcTLk gLoRxuArZhEOgddwNNAqvyzKsbcP; // 0x10
	internal static NNjtgIYWbHpIVTdlVfBMKzOraljUA jcuuKwKIYAyERbCJVHoJNffBGsWp; // 0x18
	internal static fJoDazWsXQzUMfRyTCGkItcorohd PzKBhTEUHhTGGHtNowOmSwuEpION; // 0x20
	private static ControllerDataFiles RDziNTaaNabwNEYuYbRzBrhHTfbRc; // 0x28
	private static UserData GSgUJjqgfTQNGyEDSKXfPDgqYUwb; // 0x30
	private static bool MAvCDWNDMJjDwBKVWzYzOlRqXElo; // 0x38
	private static ConfigVars oLjrLLpdkfKHAYReLCJwneJPnMGG; // 0x40
	private static UpdateLoopType jMCXuEZaZoiffpaskAYIEOOFpWEi; // 0x48
	private static bool GmsYbibeRhfIZAYZdgzLAUKVwKImA; // 0x4C
	private static Platform OubeBTUNQbtvlCrgtlNIDoCjpQgy; // 0x50
	private static WebplayerPlatform wfPdsnGSfaPyFPjLMtCPukMCiZEL; // 0x54
	private static EditorPlatform IbGimygpYkkZTjizyrOAqapkiFCj; // 0x58
	private static bool YjsEXItfmORTURoDWnrBrlCchOBu; // 0x5C
	private static TimerAbs laJJQjiSLCdfFjCEgomBEeiuvJVi; // 0x60
	private static ReInput.NjXLLDTPDWnVZVirsVtCdbPjHdrhA cRDYfLSVmiRGPZYmTYzBhiaeJpbB; // 0x68
	private static string CDKJfnLpHMxbwKXLHCRnjDyYRNgp; // 0x70
	private static bool DYqZTxwPufwUMBQDdKwGPnuVeyes; // 0x78
	private static bool odcvvwzBvrYbGLtyqfVhDkOHqHCU; // 0x79
	private static bool IPiUgsVaidnQNnTgZfmfDVYYLBWF; // 0x7A
	private static int wfHHToYQXhIJdUbIkEWgGVomCoazA; // 0x7C
	[CustomObfuscation(rename = False)]
	internal static int _id; // 0x80
	private static int MfReqQzsPjTQpsfvdFALjfocFreU; // 0x84
	private static int oJHVUHTuLmCqzGYUhdBgabUQmqEq; // 0x88
	private static bool vBtPLoGwWctBSjqDBbbROtVglxJv; // 0x8C
	private static readonly ReInput.UnityTouch AbFtCsDiGIjCTKGtNbThDKVNmXyeb; // 0x90
	private static readonly ReInput.PlayerHelper cveEDEnrPdWPKQSEiIQAVGAPztLl; // 0x98
	private static readonly ReInput.ControllerHelper aataQzDpmCkHsZGNHejpiLtGNKlub; // 0xA0
	private static readonly ReInput.MappingHelper WsvAXVFPVwbSHGkQcEuratTLUlbBb; // 0xA8
	private static readonly ReInput.TimeHelper OUxfIPmXjaIKVxubeJeIaCNxhXzx; // 0xB0
	private static readonly ReInput.ConfigHelper DwfdbGAsHhZQKcJVMHnqzICygHRUA; // 0xB8
	private static readonly ReInput.LocalizationHelper jnHxVpbGNcDIoeIKUEkvwxeGzUUA; // 0xC0
	private static readonly ReInput.GlyphHelper OYROiLziGCjMtJbXprnoUrYPaZcBb; // 0xC8
	private static eTMJKFESnYzPzwliyXFhbILynnqG MxGIKEhzPNCQdHqHEyCEZnRkyjnX; // 0xD0
	private static UserDataStore jhreOFohkzsJtWqYLHyygtTDCKKW; // 0xD8
	private static IControllerAssigner uwiTphFPeIccZzVyxdFbwKRYbMRU; // 0xE0
	private static ReInput.sXQSxoWQnKrKHYfWTCWkQZBivVJj cHznEPLKTudklufDJSHDwAAgeheC; // 0xE8
	private static SafeAction<ControllerStatusChangedEventArgs> GuQIibZgxmBNolwClttvBowCGjqfA; // 0xF0
	private static SafeAction<ControllerStatusChangedEventArgs> psWHNNNBtJzGCVClkKVikJAxPGIQ; // 0xF8
	private static SafeAction<ControllerStatusChangedEventArgs> vMTZxTcLAXRbrDjnxcZplHNMiMsB; // 0x100
	private static SafeAction hWMNBVBtAFIQztUMZdGIvwzcejSX; // 0x108
	private static SafeAction tbSZHYoUNuUberkFJEtRQpxmADKU; // 0x110
	private static SafeAction nDFIfnrylzUtSNLkIJGvqOAMHqvl; // 0x118
	private static SafeAction vLshtbZoMWVdjidigfOvuncnWXOl; // 0x120
	private static SafeAction PbQjfqBwOoErwPwFwKWKTyYMPGxjA; // 0x128
	[CustomObfuscation(rename = False)]
	private static Action<bool> _ApplicationFocusChangedEvent; // 0x130
	[CustomObfuscation(rename = False)]
	private static Action<bool> _ApplicationPauseChangedEvent; // 0x138
	private static Action iqTdITtNILiGraqmNyTnroNigkWw; // 0x140
	private static Action<UpdateLoopType> jKCFnKIoLtGwCZOHtfshrMwbHzBqA; // 0x148
	private static Action<UpdateLoopType> vrQCpiDdyocJBTruZHSqflVOOpur; // 0x150
	private static Action<UpdateLoopType> hDQnhtYbNEAvYfKLxpNYtnZGUZSR; // 0x158
	private static Action LuaoIYpDZTgSYMteqjSUQdLXvhag; // 0x160
	private static Action<bool> MJvPiBAmeuUvLoQhGQufCxPlFLaw; // 0x168
	private static Action<bool> rLZXSyaShnwypArQvKvNyZgDCDdl; // 0x170
	private static Action<bool> eSBnZZEosTRqyqhkRnegYyUXlTfo; // 0x178
	private static Action<FullScreenMode> wuLJbTbhGzmYnZUQvegUFPIorhRN; // 0x180
	private static Action SFDjINxVzGeEjPnjABZCgYEPIMwKA; // 0x188
	private static Action<bool> rCjeONjuGPRLlxqcAADQlOvHsQLC; // 0x190
	[CustomObfuscation(rename = False)]
	internal static double unscaledDeltaTime; // 0x198
	[CustomObfuscation(rename = False)]
	internal static double unscaledTime; // 0x1A0
	[CustomObfuscation(rename = False)]
	internal static double unscaledTimePrev; // 0x1A8
	[CustomObfuscation(rename = False)]
	internal static uint currentFrame; // 0x1B0
	[CustomObfuscation(rename = False)]
	internal static uint previousFrame; // 0x1B4
	[CustomObfuscation(rename = False)]
	internal static uint absFrame; // 0x1B8

	// Properties
	private static eTMJKFESnYzPzwliyXFhbILynnqG cSvpbqsapAfMTDmXyKBAneLreKpf { get; }
	public static ReInput.PlayerHelper players { get; }
	public static ReInput.ControllerHelper controllers { get; }
	public static ReInput.MappingHelper mapping { get; }
	public static ReInput.UnityTouch touch { get; }
	public static ReInput.TimeHelper time { get; }
	public static IUserDataStore userDataStore { get; }
	public static ReInput.ConfigHelper configuration { get; }
	public static ReInput.LocalizationHelper localization { get; }
	public static ReInput.GlyphHelper glyphs { get; }
	public static string programVersion { get; }
	public static bool usingUnityInput { get; }
	public static bool unityJoystickIdentificationRequired { get; }
	public static bool isReady { get; }
	[CustomObfuscation(rename = False)]
	internal static int id { get; }
	[CustomObfuscation(rename = False)]
	internal static bool initialized { get; }
	[CustomObfuscation(rename = False)]
	internal static UpdateLoopType currentUpdateLoop { get; }
	[CustomObfuscation(rename = False)]
	internal static ConfigVars configVars { get; }
	[CustomObfuscation(rename = False)]
	internal static IConfigVars_Internal pluginConfigVars { get; }
	[CustomObfuscation(rename = False)]
	internal static UserData UserData { get; }
	[CustomObfuscation(rename = False)]
	internal static Platform currentPlatform { get; }
	[CustomObfuscation(rename = False)]
	internal static WebplayerPlatform webplayerPlatform { get; }
	[CustomObfuscation(rename = False)]
	internal static EditorPlatform editorPlatform { get; }
	[CustomObfuscation(rename = False)]
	internal static bool checkNeverPressed { get; }
	[CustomObfuscation(rename = False)]
	internal static bool isEditor { get; }
	[CustomObfuscation(rename = False)]
	internal static Guid defaultHardwareJoystickMapGuid { get; }
	[CustomObfuscation(rename = False)]
	internal static bool isRunningInEditMode { get; }
	[CustomObfuscation(rename = False)]
	internal static bool isEditorPaused { get; }
	[CustomObfuscation(rename = False)]
	internal static float unityUnscaledDeltaTime { get; }
	[CustomObfuscation(rename = False)]
	internal static float unityUnscaledDeltaTimePrev { get; }
	[CustomObfuscation(rename = False)]
	internal static double realTime { get; }
	[CustomObfuscation(rename = False)]
	internal static int currentUnityFrame { get; }
	private static bool FXanMKyXHkvAdgIHtPXeXVXSEyOC { get; }
	[CustomObfuscation(rename = False)]
	internal static bool isAllowedEditorWindowFocused { get; }
	[CustomObfuscation(rename = False)]
	internal static bool isUnityEditorFocused { get; }
	[CustomObfuscation(rename = False)]
	internal static bool isWindowsStandaloneWebplayerOrEditorPlatform { get; }
	private static bool IxKKobQLCQxapbZVSaJSLcuRKkeU { get; }
	[CustomObfuscation(rename = False)]
	internal static bool applicationIsFocused { get; }
	[CustomObfuscation(rename = False)]
	internal static bool applicationIsPaused { get; }
	[CustomObfuscation(rename = False)]
	internal static bool applicationIsFullScreen { get; }
	[CustomObfuscation(rename = False)]
	internal static bool applicationRunInBackground { get; }
	[CustomObfuscation(rename = False)]
	internal static bool timeScaleIsPaused { get; }
	[CustomObfuscation(rename = False)]
	internal static InputManager_Base rewiredInputManager { get; }
	[CustomObfuscation(rename = False)]
	internal static PlatformInputManager primaryInputManager { get; }
	[CustomObfuscation(rename = False)]
	internal static IControllerAssigner controllerAssigner { get; set; }
	[CustomObfuscation(rename = False)]
	internal static RewiredVersion rewiredVersion { get; }
	[CustomObfuscation(rename = False)]
	internal static int timeScalePauseChangedCount { get; }

	// Methods

	// RVA: 0x1AEA670 Offset: 0x1AE9870 VA: 0x181AEA670
	private static void .cctor() { }

	// RVA: 0x1AE8720 Offset: 0x1AE7920 VA: 0x181AE8720
	private static eTMJKFESnYzPzwliyXFhbILynnqG NEGrUOdiRFBbNhcdmGJigvvXDXco() { }

	// RVA: 0x1AEB2A0 Offset: 0x1AEA4A0 VA: 0x181AEB2A0
	public static void add_ControllerConnectedEvent(Action<ControllerStatusChangedEventArgs> value) { }

	// RVA: 0x1AEF4C0 Offset: 0x1AEE6C0 VA: 0x181AEF4C0
	public static void remove_ControllerConnectedEvent(Action<ControllerStatusChangedEventArgs> value) { }

	// RVA: 0x1AEB3C0 Offset: 0x1AEA5C0 VA: 0x181AEB3C0
	public static void add_ControllerPreDisconnectEvent(Action<ControllerStatusChangedEventArgs> value) { }

	// RVA: 0x1AEF5E0 Offset: 0x1AEE7E0 VA: 0x181AEF5E0
	public static void remove_ControllerPreDisconnectEvent(Action<ControllerStatusChangedEventArgs> value) { }

	// RVA: 0x1AEB330 Offset: 0x1AEA530 VA: 0x181AEB330
	public static void add_ControllerDisconnectedEvent(Action<ControllerStatusChangedEventArgs> value) { }

	// RVA: 0x1AEF550 Offset: 0x1AEE750 VA: 0x181AEF550
	public static void remove_ControllerDisconnectedEvent(Action<ControllerStatusChangedEventArgs> value) { }

	// RVA: 0x1AEB710 Offset: 0x1AEA910 VA: 0x181AEB710
	public static void add_InputSourceUpdateEvent(Action value) { }

	// RVA: 0x1AEF930 Offset: 0x1AEEB30 VA: 0x181AEF930
	public static void remove_InputSourceUpdateEvent(Action value) { }

	// RVA: 0x1AEB610 Offset: 0x1AEA810 VA: 0x181AEB610
	public static void add_EditorRecompileEvent(Action value) { }

	// RVA: 0x1AEF830 Offset: 0x1AEEA30 VA: 0x181AEF830
	public static void remove_EditorRecompileEvent(Action value) { }

	// RVA: 0x1AEB870 Offset: 0x1AEAA70 VA: 0x181AEB870
	public static void add_PreShutDownEvent(Action value) { }

	// RVA: 0x1AEFA90 Offset: 0x1AEEC90 VA: 0x181AEFA90
	public static void remove_PreShutDownEvent(Action value) { }

	// RVA: 0x1AEB9D0 Offset: 0x1AEABD0 VA: 0x181AEB9D0
	public static void add_ShutDownEvent(Action value) { }

	// RVA: 0x1AEFBF0 Offset: 0x1AEEDF0 VA: 0x181AEFBF0
	public static void remove_ShutDownEvent(Action value) { }

	// RVA: 0x1AEB690 Offset: 0x1AEA890 VA: 0x181AEB690
	public static void add_InitializedEvent(Action value) { }

	// RVA: 0x1AEF8B0 Offset: 0x1AEEAB0 VA: 0x181AEF8B0
	public static void remove_InitializedEvent(Action value) { }

	// RVA: 0x1AEAD60 Offset: 0x1AE9F60 VA: 0x181AEAD60
	internal static void add_ApplicationFocusChangedEvent(Action<bool> value) { }

	// RVA: 0x1AEEF80 Offset: 0x1AEE180 VA: 0x181AEEF80
	internal static void remove_ApplicationFocusChangedEvent(Action<bool> value) { }

	// RVA: 0x1AEB000 Offset: 0x1AEA200 VA: 0x181AEB000
	internal static void add_ApplicationPauseChangedEvent(Action<bool> value) { }

	// RVA: 0x1AEF220 Offset: 0x1AEE420 VA: 0x181AEF220
	internal static void remove_ApplicationPauseChangedEvent(Action<bool> value) { }

	// RVA: 0x1AEB450 Offset: 0x1AEA650 VA: 0x181AEB450
	internal static void add_EarlyUpdateEvent(Action value) { }

	// RVA: 0x1AEF670 Offset: 0x1AEE870 VA: 0x181AEF670
	internal static void remove_EarlyUpdateEvent(Action value) { }

	// RVA: 0x1AEB1C0 Offset: 0x1AEA3C0 VA: 0x181AEB1C0
	internal static void add_BeforeTimeManagerUpdateEvent(Action<UpdateLoopType> value) { }

	// RVA: 0x1AEF3E0 Offset: 0x1AEE5E0 VA: 0x181AEF3E0
	internal static void remove_BeforeTimeManagerUpdateEvent(Action<UpdateLoopType> value) { }

	// RVA: 0x1AEBC10 Offset: 0x1AEAE10 VA: 0x181AEBC10
	internal static void add_UpdateStartedEvent(Action<UpdateLoopType> value) { }

	// RVA: 0x1AEFE30 Offset: 0x1AEF030 VA: 0x181AEFE30
	internal static void remove_UpdateStartedEvent(Action<UpdateLoopType> value) { }

	// RVA: 0x1AEBB30 Offset: 0x1AEAD30 VA: 0x181AEBB30
	internal static void add_UpdateEndedEvent(Action<UpdateLoopType> value) { }

	// RVA: 0x1AEFD50 Offset: 0x1AEEF50 VA: 0x181AEFD50
	internal static void remove_UpdateEndedEvent(Action<UpdateLoopType> value) { }

	// RVA: 0x1AEB790 Offset: 0x1AEA990 VA: 0x181AEB790
	internal static void add_LateUpdateEvent(Action value) { }

	// RVA: 0x1AEF9B0 Offset: 0x1AEEBB0 VA: 0x181AEF9B0
	internal static void remove_LateUpdateEvent(Action value) { }

	// RVA: 0x1AEAF20 Offset: 0x1AEA120 VA: 0x181AEAF20
	internal static void add_ApplicationIsFullScreenChangedEvent(Action<bool> value) { }

	// RVA: 0x1AEF140 Offset: 0x1AEE340 VA: 0x181AEF140
	internal static void remove_ApplicationIsFullScreenChangedEvent(Action<bool> value) { }

	// RVA: 0x1AEB0E0 Offset: 0x1AEA2E0 VA: 0x181AEB0E0
	internal static void add_ApplicationRunInBackgroundChangedEvent(Action<bool> value) { }

	// RVA: 0x1AEF300 Offset: 0x1AEE500 VA: 0x181AEF300
	internal static void remove_ApplicationRunInBackgroundChangedEvent(Action<bool> value) { }

	// RVA: 0x1AEBA50 Offset: 0x1AEAC50 VA: 0x181AEBA50
	internal static void add_TimeScalePauseChangedEvent(Action<bool> value) { }

	// RVA: 0x1AEFC70 Offset: 0x1AEEE70 VA: 0x181AEFC70
	internal static void remove_TimeScalePauseChangedEvent(Action<bool> value) { }

	// RVA: 0x1AEAE40 Offset: 0x1AEA040 VA: 0x181AEAE40
	internal static void add_ApplicationFullScreenModeChangedEvent(Action<FullScreenMode> value) { }

	// RVA: 0x1AEF060 Offset: 0x1AEE260 VA: 0x181AEF060
	internal static void remove_ApplicationFullScreenModeChangedEvent(Action<FullScreenMode> value) { }

	// RVA: 0x1AEB8F0 Offset: 0x1AEAAF0 VA: 0x181AEB8F0
	internal static void add_SceneLoadedEvent(Action value) { }

	// RVA: 0x1AEFB10 Offset: 0x1AEED10 VA: 0x181AEFB10
	internal static void remove_SceneLoadedEvent(Action value) { }

	// RVA: 0x1AEB530 Offset: 0x1AEA730 VA: 0x181AEB530
	internal static void add_EditorPauseChangedEvent(Action<bool> value) { }

	// RVA: 0x1AEF750 Offset: 0x1AEE950 VA: 0x181AEF750
	internal static void remove_EditorPauseChangedEvent(Action<bool> value) { }

	// RVA: 0x1AED9B0 Offset: 0x1AECBB0 VA: 0x181AED9B0
	public static ReInput.PlayerHelper get_players() { }

	// RVA: 0x1AECFD0 Offset: 0x1AEC1D0 VA: 0x181AECFD0
	public static ReInput.ControllerHelper get_controllers() { }

	// RVA: 0x1AED900 Offset: 0x1AECB00 VA: 0x181AED900
	public static ReInput.MappingHelper get_mapping() { }

	// RVA: 0x1AEDFC0 Offset: 0x1AED1C0 VA: 0x181AEDFC0
	public static ReInput.UnityTouch get_touch() { }

	// RVA: 0x1AEDF10 Offset: 0x1AED110 VA: 0x181AEDF10
	public static ReInput.TimeHelper get_time() { }

	// RVA: 0x1AEE2D0 Offset: 0x1AED4D0 VA: 0x181AEE2D0
	public static IUserDataStore get_userDataStore() { }

	// RVA: 0x1AECEC0 Offset: 0x1AEC0C0 VA: 0x181AECEC0
	public static ReInput.ConfigHelper get_configuration() { }

	// RVA: 0x1AED850 Offset: 0x1AECA50 VA: 0x181AED850
	public static ReInput.LocalizationHelper get_localization() { }

	// RVA: 0x1AED2C0 Offset: 0x1AEC4C0 VA: 0x181AED2C0
	public static ReInput.GlyphHelper get_glyphs() { }

	// RVA: 0x1AEDB80 Offset: 0x1AECD80 VA: 0x181AEDB80
	public static string get_programVersion() { }

	// RVA: 0x1AEE380 Offset: 0x1AED580 VA: 0x181AEE380
	public static bool get_usingUnityInput() { }

	// RVA: 0x1AEE070 Offset: 0x1AED270 VA: 0x181AEE070
	public static bool get_unityJoystickIdentificationRequired() { }

	// RVA: 0x1AED5F0 Offset: 0x1AEC7F0 VA: 0x181AED5F0
	public static bool get_isReady() { }

	// RVA: 0x1AE94E0 Offset: 0x1AE86E0 VA: 0x181AE94E0
	public static void Update() { }

	// RVA: 0x1AE9250 Offset: 0x1AE8450 VA: 0x181AE9250
	public static void Reset() { }

	// RVA: 0x1AED370 Offset: 0x1AEC570 VA: 0x181AED370
	internal static int get_id() { }

	// RVA: 0x1AED3D0 Offset: 0x1AEC5D0 VA: 0x181AED3D0
	internal static bool get_initialized() { }

	// RVA: 0x1AED160 Offset: 0x1AEC360 VA: 0x181AED160
	internal static UpdateLoopType get_currentUpdateLoop() { }

	// RVA: 0x1AECE70 Offset: 0x1AEC070 VA: 0x181AECE70
	internal static ConfigVars get_configVars() { }

	// RVA: 0x1AEDA60 Offset: 0x1AECC60 VA: 0x181AEDA60
	internal static IConfigVars_Internal get_pluginConfigVars() { }

	// RVA: 0x1AEC910 Offset: 0x1AEBB10 VA: 0x181AEC910
	internal static UserData get_UserData() { }

	// RVA: 0x1AED080 Offset: 0x1AEC280 VA: 0x181AED080
	internal static Platform get_currentPlatform() { }

	// RVA: 0x1AEE3D0 Offset: 0x1AED5D0 VA: 0x181AEE3D0
	internal static WebplayerPlatform get_webplayerPlatform() { }

	// RVA: 0x1AED270 Offset: 0x1AEC470 VA: 0x181AED270
	internal static EditorPlatform get_editorPlatform() { }

	// RVA: 0x1AECBE0 Offset: 0x1AEBDE0 VA: 0x181AECBE0
	internal static bool get_checkNeverPressed() { }

	// RVA: 0x1AED590 Offset: 0x1AEC790 VA: 0x181AED590
	internal static bool get_isEditor() { }

	// RVA: 0x1AED1B0 Offset: 0x1AEC3B0 VA: 0x181AED1B0
	internal static Guid get_defaultHardwareJoystickMapGuid() { }

	// RVA: 0x1AED640 Offset: 0x1AEC840 VA: 0x181AED640
	internal static bool get_isRunningInEditMode() { }

	// RVA: 0x1AED520 Offset: 0x1AEC720 VA: 0x181AED520
	internal static bool get_isEditorPaused() { }

	// RVA: 0x1AEE270 Offset: 0x1AED470 VA: 0x181AEE270
	internal static float get_unityUnscaledDeltaTime() { }

	// RVA: 0x1AEE210 Offset: 0x1AED410 VA: 0x181AEE210
	internal static float get_unityUnscaledDeltaTimePrev() { }

	// RVA: 0x1AEDCC0 Offset: 0x1AECEC0 VA: 0x181AEDCC0
	internal static double get_realTime() { }

	// RVA: 0x1AED0D0 Offset: 0x1AEC2D0 VA: 0x181AED0D0
	internal static int get_currentUnityFrame() { }

	// RVA: 0x1AEEB00 Offset: 0x1AEDD00 VA: 0x181AEEB00
	private static bool nvpisYscoeAICpgcfyVWfNjbwWwS() { }

	// RVA: 0x1AED420 Offset: 0x1AEC620 VA: 0x181AED420
	internal static bool get_isAllowedEditorWindowFocused() { }

	// RVA: 0x1AED690 Offset: 0x1AEC890 VA: 0x181AED690
	internal static bool get_isUnityEditorFocused() { }

	// RVA: 0x1AED740 Offset: 0x1AEC940 VA: 0x181AED740
	internal static bool get_isWindowsStandaloneWebplayerOrEditorPlatform() { }

	// RVA: 0x1AF19E0 Offset: 0x1AF0BE0 VA: 0x181AF19E0
	private static bool yoNkikkyTFnahiODnNXXRjNGBYqP() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1AE8210 Offset: 0x1AE7410 VA: 0x181AE8210
	internal static bool IsInputAllowed(ControllerType controllerType) { }

	// RVA: 0x1AEC960 Offset: 0x1AEBB60 VA: 0x181AEC960
	internal static bool get_applicationIsFocused() { }

	// RVA: 0x1AECAA0 Offset: 0x1AEBCA0 VA: 0x181AECAA0
	internal static bool get_applicationIsPaused() { }

	// RVA: 0x1AECA00 Offset: 0x1AEBC00 VA: 0x181AECA00
	internal static bool get_applicationIsFullScreen() { }

	// RVA: 0x1AECB40 Offset: 0x1AEBD40 VA: 0x181AECB40
	internal static bool get_applicationRunInBackground() { }

	// RVA: 0x1AEDE10 Offset: 0x1AED010 VA: 0x181AEDE10
	internal static bool get_timeScaleIsPaused() { }

	// RVA: 0x1AEDD50 Offset: 0x1AECF50 VA: 0x181AEDD50
	internal static InputManager_Base get_rewiredInputManager() { }

	// RVA: 0x1AEDAB0 Offset: 0x1AECCB0 VA: 0x181AEDAB0
	internal static PlatformInputManager get_primaryInputManager() { }

	// RVA: 0x1AECF70 Offset: 0x1AEC170 VA: 0x181AECF70
	internal static IControllerAssigner get_controllerAssigner() { }

	// RVA: 0x1AEFFC0 Offset: 0x1AEF1C0 VA: 0x181AEFFC0
	internal static void set_controllerAssigner(IControllerAssigner value) { }

	// RVA: 0x1AEDDA0 Offset: 0x1AECFA0 VA: 0x181AEDDA0
	internal static RewiredVersion get_rewiredVersion() { }

	// RVA: 0x1AEDEB0 Offset: 0x1AED0B0 VA: 0x181AEDEB0
	internal static int get_timeScalePauseChangedCount() { }

	// RVA: 0x1AE95C0 Offset: 0x1AE87C0 VA: 0x181AE95C0
	private static void VXHsLPvKSrFQmueLhcKvFVavIedc() { }

	// RVA: 0x1AE98B0 Offset: 0x1AE8AB0 VA: 0x181AE98B0
	internal static void ZFUcTEcndvHgBpdTmEAgSebxfOsJ(InputManager_Base , Func<ConfigVars, object> , ConfigVars , ControllerDataFiles , UserData , UnityTools.YTypwYdyUDNjYDvIzsPBEEnrppYv , Action<Platform> ) { }

	// RVA: 0x1AE8CB0 Offset: 0x1AE7EB0 VA: 0x181AE8CB0
	internal static void OVAHhXYoWnOfgTkcQdOcZntUEeNb() { }

	// RVA: 0x1AEC800 Offset: 0x1AEBA00 VA: 0x181AEC800
	internal static void fyxSqLTUAfQlyVzrorhlTCMtUsOM(UpdateLoopType ) { }

	// RVA: 0x1AE7D00 Offset: 0x1AE6F00 VA: 0x181AE7D00
	private static void HGsuuETYarHtVLSUyAqHenoqhgv(UpdateLoopType ) { }

	// RVA: 0x1AF0380 Offset: 0x1AEF580 VA: 0x181AF0380
	private static void xRAqWVouPespEBhOgdLeZHSvdFocA() { }

	// RVA: 0x1AE87F0 Offset: 0x1AE79F0 VA: 0x181AE87F0
	internal static void NXsdcUmvlchkKwnLJYZgvWkOUNSV(UpdateLoopType ) { }

	// RVA: 0x1AE7810 Offset: 0x1AE6A10 VA: 0x181AE7810
	internal static void DAikbUbssALDQEVEzJiugucvpvwD() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1AE79B0 Offset: 0x1AE6BB0 VA: 0x181AE79B0
	internal static void EditorUpdate() { }

	// RVA: 0x1AEBDC0 Offset: 0x1AEAFC0 VA: 0x181AEBDC0
	internal static void dPUmiTNqCTBpvKRnEcIAGAZYZCnC() { }

	// RVA: 0x1AE7BA0 Offset: 0x1AE6DA0 VA: 0x181AE7BA0
	internal static void FpAiaviZWdCYMGwZVfjpvTtenzYg() { }

	// RVA: 0x1AE9720 Offset: 0x1AE8920 VA: 0x181AE9720
	internal static void XPdtwLVdzhrtFdOxByncbxkDbynK(bool ) { }

	// RVA: 0x1AE78C0 Offset: 0x1AE6AC0 VA: 0x181AE78C0
	internal static void DeKzJZjqsVYstvxDsjjDQeoBBpZfA(bool ) { }

	// RVA: 0x1AE7AD0 Offset: 0x1AE6CD0 VA: 0x181AE7AD0
	internal static void FkeAPiixakMBLDHVLKdCNreSmBqib() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1AE7C30 Offset: 0x1AE6E30 VA: 0x181AE7C30
	internal static HardwareJoystickMap_InputManager GetHardwareJoystickMap_InputManager(BridgedControllerHWInfo bridgedController) { }

	// RVA: 0x1AEC890 Offset: 0x1AEBA90 VA: 0x181AEC890
	internal static HardwareJoystickMap fzKDcpYquUUAZFWrfUbhVBAhPkJM(Guid ) { }

	// RVA: 0x1AF1B10 Offset: 0x1AF0D10 VA: 0x181AF1B10
	internal static HardwareJoystickTemplateMap zIyCramXYTgxIGCqGjECpOGrFEFNA(Guid ) { }

	// RVA: 0x1AF1B90 Offset: 0x1AF0D90 VA: 0x181AF1B90
	internal static WkgkbmGyRrghNJkGCDFpCiLnjOhK zvHMmvRhYCPSHoAUQxoDuKpVEWxH(Guid ) { }

	// RVA: 0x1AEBF30 Offset: 0x1AEB130 VA: 0x181AEBF30
	internal static IHardwareControllerTemplateMap eGgLBEYjiOEQXACigUCWiBKVAbfO(Guid ) { }

	// RVA: 0x1AEE9B0 Offset: 0x1AEDBB0 VA: 0x181AEE9B0
	internal static IHardwareControllerTemplateMap lJpGuoSIfygSRXvQQgEygTlRjBir(Guid ) { }

	// RVA: 0x1AF0020 Offset: 0x1AEF220 VA: 0x181AF0020
	internal static IList<WkgkbmGyRrghNJkGCDFpCiLnjOhK> vzEEikdENCFiLpwmfKqVCFAxGuqX(Guid ) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1AE7CA0 Offset: 0x1AE6EA0 VA: 0x181AE7CA0
	internal static int GetNewJoystickId() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1AE7F60 Offset: 0x1AE7160 VA: 0x181AE7F60
	internal static void HandleCallbackException(string source, Exception exception) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1AE8030 Offset: 0x1AE7230 VA: 0x181AE8030
	internal static void HandleExternException(string source, Exception exception) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1AE8090 Offset: 0x1AE7290 VA: 0x181AE8090
	internal static void HandleExternalInterfaceException(string source, Exception exception) { }

	// RVA: 0x1AE9840 Offset: 0x1AE8A40 VA: 0x181AE9840
	internal static void YxDfyiGSTswABnaEajYSmtfWxcNc() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1AE76B0 Offset: 0x1AE68B0 VA: 0x181AE76B0
	internal static void CheckRewiredVersionCompatibility() { }

	// RVA: 0x1AEEF00 Offset: 0x1AEE100 VA: 0x181AEEF00
	internal static float rYBfUrBxwTBOTeqCbUCXniqUwsQib() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1AE7630 Offset: 0x1AE6830 VA: 0x181AE7630
	internal static bool CheckInitialized() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1AE7590 Offset: 0x1AE6790 VA: 0x181AE7590
	internal static bool CheckInitialized(int reInputId) { }

	// RVA: 0x1AE7E50 Offset: 0x1AE7050 VA: 0x181AE7E50
	private static void HMOrMjxLDzwtASdpwjdFDICPKZfgb() { }

	// RVA: 0x1AEBFB0 Offset: 0x1AEB1B0 VA: 0x181AEBFB0
	private static void ehkejWdpHKmLYGXewFCGxvGfLGil() { }

	// RVA: 0x1AEE620 Offset: 0x1AED820 VA: 0x181AEE620
	private static void iQbZWfMeorNMegcIDfsMKMOVnksK(string ) { }

	// RVA: 0x1AE8640 Offset: 0x1AE7840 VA: 0x181AE8640
	private static void LSdGDQIvLpIWtgxpkcdYHDfsyeZWA() { }

	// RVA: 0x1AEE420 Offset: 0x1AED620 VA: 0x181AEE420
	private static void hFHinHKHJKYGLmoJRiebhLQjpVhbc() { }

	// RVA: 0x1AE8F70 Offset: 0x1AE8170 VA: 0x181AE8F70
	private static void QDmICbEflTfNSJAzRMouknbDVDyZ(BridgedController ) { }

	// RVA: 0x1AEE460 Offset: 0x1AED660 VA: 0x181AEE460
	private static void hkzGHWTKWLaxyBasZNmpDFKacltzB(ControllerDisconnectedEventArgs ) { }

	// RVA: 0x1AEFF10 Offset: 0x1AEF110 VA: 0x181AEFF10
	private static void rqJzcxenofwBRSpkQSCTTZORclf(ControllerStatusChangedEventArgs ) { }

	// RVA: 0x1AE8160 Offset: 0x1AE7360 VA: 0x181AE8160
	private static void ImnePznZMWoffmLAdxZcYRBLihhb(ControllerStatusChangedEventArgs ) { }

	// RVA: 0x1AE8C00 Offset: 0x1AE7E00 VA: 0x181AE8C00
	private static void NeRZLmLISLPqrdafZyoBLnMmdoXeA(ControllerStatusChangedEventArgs ) { }

	// RVA: 0x1AF0310 Offset: 0x1AEF510 VA: 0x181AF0310
	private static void xIaflsDPPOggXsGsqYQDaHBFemKGA(UpdateControllerInfoEventArgs ) { }

	// RVA: 0x1AE74C0 Offset: 0x1AE66C0 VA: 0x181AE74C0
	private static void BrXJkfHLERFpbScebqEwNAEsBsbv(bool ) { }

	// RVA: 0x1AEBCF0 Offset: 0x1AEAEF0 VA: 0x181AEBCF0
	private static void crrnSNwlzJZKIJHGFbYOwzQnSHzq(bool ) { }

	// RVA: 0x1AE7760 Offset: 0x1AE6960 VA: 0x181AE7760
	private static void CobuHuJZoTSOGtPjlUDasGGZNysR(bool ) { }

	// RVA: 0x1AE9340 Offset: 0x1AE8540 VA: 0x181AE9340
	private static void SlTZBpgXPhdQeBiPPgqFtGYItGpF(int ) { }

	// RVA: 0x1AE9670 Offset: 0x1AE8870 VA: 0x181AE9670
	private static void WokDXQqfPrjrxJuhGXxlEefWSrXx(bool ) { }

	// RVA: 0x1AEEA30 Offset: 0x1AEDC30 VA: 0x181AEEA30
	private static void mepwTNleMdUeFySVVjHhCQZWgkme(bool ) { }

	// RVA: 0x1AEEBC0 Offset: 0x1AEDDC0 VA: 0x181AEEBC0
	private static void pBlXJQoSxJeXQyNbFxgbtAJNtAeS() { }

	// RVA: 0x1AEE680 Offset: 0x1AED880 VA: 0x181AEE680
	private static void iltNPuWkEHvUwsoWXivzTYbUufoU() { }

	// RVA: 0x1AE9430 Offset: 0x1AE8630 VA: 0x181AE9430
	private static void UameeCadrrONwKFowoNABzZcIaBK(bool ) { }

	// RVA: 0x1AF0480 Offset: 0x1AEF680 VA: 0x181AF0480
	private static void ykeQIbenwgCCMYSeaFQsRvvDhTkS(Func<ConfigVars, object> , UnityTools.YTypwYdyUDNjYDvIzsPBEEnrppYv , Action<Platform> ) { }

	// RVA: 0x1AE91A0 Offset: 0x1AE83A0 VA: 0x181AE91A0
	private static void QmMWLKVYSbsgYAsZJWyOHTNZPJti() { }

	// RVA: 0x1AE8470 Offset: 0x1AE7670 VA: 0x181AE8470
	private static void JXuXWDzmQHfKOLhSMGnoJbuYducTA() { }
}

// Namespace: 
private class eTMJKFESnYzPzwliyXFhbILynnqG.dmcYbgLnrOWteKyNrnjEroomqEtr.EqegoSiUCAzXIFtyogePRUAZTOcDA // TypeDefIndex: 7140
{
	// Fields
	private int rmzteMfLFEDAOvqfcFazGgNlSNgBA; // 0x10
	private eTMJKFESnYzPzwliyXFhbILynnqG.dmcYbgLnrOWteKyNrnjEroomqEtr.oSSbxwBprvGvUiRdfPSUJuPdqOpN[] TruLmjieKAjQseiaxGYEoHxpFBwKA; // 0x18
	private eTMJKFESnYzPzwliyXFhbILynnqG.dmcYbgLnrOWteKyNrnjEroomqEtr.QrzfLIKlnZdGScHkHquUDjLGlelaA[] OPyVKPeWISBmuRxFQjcgutRriOTp; // 0x20

	// Methods

	// RVA: 0x1917810 Offset: 0x1916A10 VA: 0x181917810
	public void .ctor(int ) { }

	// RVA: 0x19174B0 Offset: 0x19166B0 VA: 0x1819174B0
	public void AFrfoijKnFynsekuNTrAqofYEobCA() { }

	// RVA: 0x1917650 Offset: 0x1916850 VA: 0x181917650
	public void NXsdcUmvlchkKwnLJYZgvWkOUNSV() { }

	// RVA: 0x19179F0 Offset: 0x1916BF0 VA: 0x1819179F0
	public bool aSOUYCoXSrSoBcoARHonTSxYelNA(int ) { }

	// RVA: 0x1917AF0 Offset: 0x1916CF0 VA: 0x181917AF0
	public bool nVtepoQLYUpYVMdTLgBWIRsMnkWFA(int ) { }

	// RVA: 0x1917600 Offset: 0x1916800 VA: 0x181917600
	public bool NExCloGyqIznSrrjxfrBLiVOXgGKA(int ) { }

	// RVA: 0x1917B40 Offset: 0x1916D40 VA: 0x181917B40
	public float xkKkqVDvkqQjxXFwOTLeGMEeScZP(int ) { }

	// RVA: 0x19177A0 Offset: 0x19169A0 VA: 0x1819177A0
	public bool YuNiVNRbpeRcOGIFycEOKfxnhLxI(int , bool ) { }

	// RVA: 0x1917A40 Offset: 0x1916C40 VA: 0x181917A40
	public void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }
}

// Namespace: 
private class eTMJKFESnYzPzwliyXFhbILynnqG.dmcYbgLnrOWteKyNrnjEroomqEtr.cmqAGxAsQtdqzxNBxgyyEWxFGdLzb // TypeDefIndex: 7141
{
	// Fields
	private eTMJKFESnYzPzwliyXFhbILynnqG.dmcYbgLnrOWteKyNrnjEroomqEtr.oSSbxwBprvGvUiRdfPSUJuPdqOpN[] TruLmjieKAjQseiaxGYEoHxpFBwKA; // 0x10

	// Methods

	// RVA: 0x191FD90 Offset: 0x191EF90 VA: 0x18191FD90
	public void .ctor() { }

	// RVA: 0x191FCD0 Offset: 0x191EED0 VA: 0x18191FCD0
	public void NXsdcUmvlchkKwnLJYZgvWkOUNSV() { }

	// RVA: 0x191FEA0 Offset: 0x191F0A0 VA: 0x18191FEA0
	public bool aSOUYCoXSrSoBcoARHonTSxYelNA(int ) { }

	// RVA: 0x191FF60 Offset: 0x191F160 VA: 0x18191FF60
	public bool nVtepoQLYUpYVMdTLgBWIRsMnkWFA(int ) { }

	// RVA: 0x191FC80 Offset: 0x191EE80 VA: 0x18191FC80
	public bool NExCloGyqIznSrrjxfrBLiVOXgGKA(int ) { }

	// RVA: 0x191FEF0 Offset: 0x191F0F0 VA: 0x18191FEF0
	public void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }
}

// Namespace: 
private class eTMJKFESnYzPzwliyXFhbILynnqG.dmcYbgLnrOWteKyNrnjEroomqEtr.oSSbxwBprvGvUiRdfPSUJuPdqOpN // TypeDefIndex: 7142
{
	// Fields
	private bool ABOGdjpoQCATcAFVlobRVSpCMJhLA; // 0x10
	private bool xZRnIAPsuNxiWQqfvBCeEoRdLQFmA; // 0x11

	// Properties
	public bool CdEckvrVAeswSaQCfMLbUlJjpTfR { get; set; }
	public bool LwSWFfEenoFQEEcghBjciYqqlAec { get; }
	public bool WAGiAqHkASpcWDymigyMtxSFsXUGc { get; }

	// Methods

	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool wyebSCarofKfiATzDhtpYoxIIZuVB() { }

	// RVA: 0x19215A0 Offset: 0x19207A0 VA: 0x1819215A0
	public void kSsEzyLvJncZExXHKdNCvvttWuwF(bool ) { }

	// RVA: 0x18CE3D0 Offset: 0x18CD5D0 VA: 0x1818CE3D0
	public bool isgMMXxPOOdAvzFJwWKpxyXkfZGe() { }

	// RVA: 0x1921570 Offset: 0x1920770 VA: 0x181921570
	public bool LgJFsxnTxTMkwmwPSetqGYPuVlMt() { }

	// RVA: 0x1921560 Offset: 0x1920760 VA: 0x181921560
	public void AFrfoijKnFynsekuNTrAqofYEobCA(bool ) { }

	// RVA: 0x1921590 Offset: 0x1920790 VA: 0x181921590
	public void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private class eTMJKFESnYzPzwliyXFhbILynnqG.dmcYbgLnrOWteKyNrnjEroomqEtr.QrzfLIKlnZdGScHkHquUDjLGlelaA // TypeDefIndex: 7143
{
	// Fields
	private int ExKpaRjEkVuVavbNfSrOEvFFPoCk; // 0x10
	private float ABOGdjpoQCATcAFVlobRVSpCMJhLA; // 0x14
	private float rgYaweGqgABGbJwNDbQHWCugruypb; // 0x18

	// Properties
	public float CdEckvrVAeswSaQCfMLbUlJjpTfR { get; set; }

	// Methods

	// RVA: 0x499030 Offset: 0x498230 VA: 0x180499030
	public float wyebSCarofKfiATzDhtpYoxIIZuVB() { }

	// RVA: 0x499080 Offset: 0x498280 VA: 0x180499080
	public void kSsEzyLvJncZExXHKdNCvvttWuwF(float ) { }

	// RVA: 0x3D85A0 Offset: 0x3D77A0 VA: 0x1803D85A0
	public void .ctor(int ) { }

	// RVA: 0x191B6D0 Offset: 0x191A8D0 VA: 0x18191B6D0
	public void AFrfoijKnFynsekuNTrAqofYEobCA(float ) { }

	// RVA: 0x191B6E0 Offset: 0x191A8E0 VA: 0x18191B6E0
	public bool RaGGKgONOhNIPUtpWcahANdjrITw(bool ) { }

	// RVA: 0x191B720 Offset: 0x191A920 VA: 0x18191B720
	public void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }
}

// Namespace: 
private class eTMJKFESnYzPzwliyXFhbILynnqG.dmcYbgLnrOWteKyNrnjEroomqEtr // TypeDefIndex: 7144
{
	// Fields
	private eTMJKFESnYzPzwliyXFhbILynnqG.dmcYbgLnrOWteKyNrnjEroomqEtr.EqegoSiUCAzXIFtyogePRUAZTOcDA[] PgpGMyJfIPxDnbEBKMKFPoCrGZsy; // 0x10
	private eTMJKFESnYzPzwliyXFhbILynnqG.dmcYbgLnrOWteKyNrnjEroomqEtr.cmqAGxAsQtdqzxNBxgyyEWxFGdLzb LHioKmtFkdHWeyZEPNNFplYQDMhe; // 0x18

	// Methods

	// RVA: 0x1920450 Offset: 0x191F650 VA: 0x181920450
	public void .ctor() { }

	// RVA: 0x191FFB0 Offset: 0x191F1B0 VA: 0x18191FFB0
	public void AFrfoijKnFynsekuNTrAqofYEobCA() { }

	// RVA: 0x1920160 Offset: 0x191F360 VA: 0x181920160
	public void NXsdcUmvlchkKwnLJYZgvWkOUNSV() { }

	// RVA: 0x1920980 Offset: 0x191FB80 VA: 0x181920980
	public bool wWvydgdJGEjeFTiKkhKmIbiRbpIt(int , int ) { }

	// RVA: 0x19203D0 Offset: 0x191F5D0 VA: 0x1819203D0
	public bool NyiFPiHKSFbfwkykchRUJsdasnWC(int , int ) { }

	// RVA: 0x19207B0 Offset: 0x191F9B0 VA: 0x1819207B0
	public bool ikmbmhkunymNdTAXkGUIPtRQviGw(int , int ) { }

	// RVA: 0x19208E0 Offset: 0x191FAE0 VA: 0x1819208E0
	public bool lDWAxOdkLPkWGPkwEHqMtTuwHVrcb(int , int , bool ) { }

	// RVA: 0x1920830 Offset: 0x191FA30 VA: 0x181920830
	public bool joBybsGfhlCaBCdVnEIAsBNMxpYCA(int ) { }

	// RVA: 0x1920880 Offset: 0x191FA80 VA: 0x181920880
	public bool kYLTGkhBhigRKCbhaqMIDrscLCRPb(int ) { }

	// RVA: 0x19209F0 Offset: 0x191FBF0 VA: 0x1819209F0
	public bool xjIkPugaXWVRUQyEfibbMSpXhpYhA(int ) { }

	// RVA: 0x1920660 Offset: 0x191F860 VA: 0x181920660
	public void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }
}

// Namespace: 
internal class eTMJKFESnYzPzwliyXFhbILynnqG // TypeDefIndex: 7145
{
	// Fields
	private UpdateLoopType cCgYCUDwBYOudomcpBworRxTuvcG; // 0x10
	private eTMJKFESnYzPzwliyXFhbILynnqG.dmcYbgLnrOWteKyNrnjEroomqEtr lRFcipgKzjQiFZFVhkWTYmWyWbPE; // 0x18
	private IndexedDictionary<int, eTMJKFESnYzPzwliyXFhbILynnqG.dmcYbgLnrOWteKyNrnjEroomqEtr> pqinjZlQeZJDRSwEhqbtRAUzDCwr; // 0x20

	// Methods

	// RVA: 0x1920C20 Offset: 0x191FE20 VA: 0x181920C20
	public void .ctor(UpdateLoopSetting ) { }

	// RVA: 0x1920A50 Offset: 0x191FC50 VA: 0x181920A50
	public void AFrfoijKnFynsekuNTrAqofYEobCA() { }

	// RVA: 0x1920B30 Offset: 0x191FD30 VA: 0x181920B30
	public void NXsdcUmvlchkKwnLJYZgvWkOUNSV(UpdateLoopType ) { }

	// RVA: 0x1921260 Offset: 0x1920460 VA: 0x181921260
	public bool wWvydgdJGEjeFTiKkhKmIbiRbpIt(int , int ) { }

	// RVA: 0x1920BA0 Offset: 0x191FDA0 VA: 0x181920BA0
	public bool NyiFPiHKSFbfwkykchRUJsdasnWC(int , int ) { }

	// RVA: 0x1921020 Offset: 0x1920220 VA: 0x181921020
	public bool ikmbmhkunymNdTAXkGUIPtRQviGw(int , int ) { }

	// RVA: 0x1921160 Offset: 0x1920360 VA: 0x181921160
	public bool lDWAxOdkLPkWGPkwEHqMtTuwHVrcb(int , int , bool ) { }

	// RVA: 0x19210A0 Offset: 0x19202A0 VA: 0x1819210A0
	public bool joBybsGfhlCaBCdVnEIAsBNMxpYCA(int ) { }

	// RVA: 0x1921100 Offset: 0x1920300 VA: 0x181921100
	public bool kYLTGkhBhigRKCbhaqMIDrscLCRPb(int ) { }

	// RVA: 0x19212E0 Offset: 0x19204E0 VA: 0x1819212E0
	public bool xjIkPugaXWVRUQyEfibbMSpXhpYhA(int ) { }

	// RVA: 0x1920E60 Offset: 0x1920060 VA: 0x181920E60
	public void emOgGAIJPwqUQQPmEukEIzmDcQhcb() { }

	// RVA: 0x1921200 Offset: 0x1920400 VA: 0x181921200
	private void ousqdzpEkwHvWYiLOvwyUwxJOBIF(UpdateLoopType ) { }
}

// Namespace: 
private class CustomInputManager.ynGfcgDSBjHTSlxjgsUUNkrNpBab : IInputManagerJoystick, IInputManagerJoystickPublic, ITryGetLocalizedName // TypeDefIndex: 7146
{
	// Fields
	private readonly InputSource NOproBQQdmCZareWqeKxfvgAUJcsA; // 0x10
	private readonly CustomInputSource McogQWMzoOnHLYhBOaKSDVtUOVEF; // 0x18
	private readonly Controller.Extension UkNVbtIvrLthdNEqtaxlGsUzkdJNA; // 0x20
	private int WbkDRJEuoPBLLDmrfHJWgNJQCwNvB; // 0x28
	private int BoTmFzEhaOdgBQChcgQyQvxMoQji; // 0x2C
	private Nullable<long> UGKEOwoLdQNDqVeGGpBYNDCCdCUM; // 0x30
	private int ROUaKuFxYbGXzctUkcpThwDvBnzEb; // 0x40
	public Guid CTnCUICsGydvUUAXPEEmYmkuywLs; // 0x44
	public string YmTjSJXoqmHqHcEkJisLLFRXEnpe; // 0x58
	public string aZIEEEYNhHiwldOmHDoiFJZjAVHmB; // 0x60
	private int KLiLeFOmHnIKewzsCXwtlSRRgkOA; // 0x68
	private int ZwxoEwSrePraFcQWlwoanfflAcnb; // 0x6C
	private float[] CEooErXtzTRPgeKBtAJkbnzTRsVE; // 0x70
	private bool[] mAIOfbclLIXQWUKLRbVwkgXzcWDHA; // 0x78
	private float[] rmVogsKVQCBYvWGSzbSGXBqodwqt; // 0x80
	private bool[] LqdOWexStHolsVbfVAQuixeQvMBD; // 0x88
	private HardwareJoystickMap_InputManager GvrRKEvhRFQLAyweejKeBxXVLmWt; // 0x90
	public CustomInputSource.Joystick vSuPahQATTtoPiKeokXoxvFtHdeQ; // 0x98
	private bool SAdlFPLMsLBwgDQlaYYPmQaoaUTvA; // 0xA0
	private readonly bool xvqfDOcEajvBBOMcCULgPZnWfCWG; // 0xA1
	private readonly LocalizedString jboOUzMaWlYmsUjlZgbTGwOzdzuCA; // 0xA8
	private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> oLMJByWrXxnTAAniOPWzusegbMTX; // 0xB0

	// Properties
	public int bgCIfkJGSbJSoQllLqIXzPVsOLoiA { get; }
	public int irpddGWCLPVnGLzFRyGBvJPqNImI { get; }
	[CustomObfuscation(rename = False)]
	public int rewiredId { get; set; }
	[CustomObfuscation(rename = False)]
	public int inputManagerId { get; set; }
	[CustomObfuscation(rename = False)]
	public string name { get; }
	[CustomObfuscation(rename = False)]
	public Nullable<long> systemId { get; }
	[CustomObfuscation(rename = False)]
	public int unityId { get; }
	[CustomObfuscation(rename = False)]
	public Guid instanceGuid { get; }
	[CustomObfuscation(rename = False)]
	public Guid persistentGuid { get; }
	[CustomObfuscation(rename = False)]
	public Controller.Extension extension { get; }

	// Methods

	// RVA: 0x1922830 Offset: 0x1921A30 VA: 0x181922830
	public int EaiDMRAvgeOCDyzLfUFzHveGzGLy() { }

	// RVA: 0x1923AD0 Offset: 0x1922CD0 VA: 0x181923AD0
	public int ZAGHriYbjGHJIenGeVoMaLpkfGdU() { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050 Slot: 8
	public int get_rewiredId() { }

	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	public void set_rewiredId(int value) { }

	// RVA: 0x5012C0 Offset: 0x5004C0 VA: 0x1805012C0 Slot: 9
	public int get_inputManagerId() { }

	// RVA: 0x5014F0 Offset: 0x5006F0 VA: 0x1805014F0
	public void set_inputManagerId(int value) { }

	// RVA: 0x1923F20 Offset: 0x1923120 VA: 0x181923F20 Slot: 10
	public string get_name() { }

	// RVA: 0x160E010 Offset: 0x160D210 VA: 0x18160E010 Slot: 11
	public Nullable<long> get_systemId() { }

	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440 Slot: 12
	public int get_unityId() { }

	// RVA: 0x1923E20 Offset: 0x1923020 VA: 0x181923E20 Slot: 14
	public Guid get_instanceGuid() { }

	// RVA: 0x1923FB0 Offset: 0x19231B0 VA: 0x181923FB0 Slot: 15
	public Guid get_persistentGuid() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 13
	public Controller.Extension get_extension() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 16
	public void SetVibration(float amount, int motorIndex) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 17
	public void StopVibration() { }

	// RVA: 0x1923B10 Offset: 0x1922D10 VA: 0x181923B10
	public void .ctor(CustomInputSource , Nullable<long> , int , CustomInputSource.Joystick , InputSource , Controller.Extension , Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> ) { }

	// RVA: 0x1923380 Offset: 0x1922580 VA: 0x181923380
	public void ULcIhSLiqlfYxbWqlimrrpJjKitTA() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x19233B0 Offset: 0x19225B0 VA: 0x1819233B0 Slot: 4
	public void Update() { }

	// RVA: 0x19224F0 Offset: 0x19216F0 VA: 0x1819224F0
	public int BxThmMJFHsklBXkYNDKZEyouGtEiA(CustomInputManager.ynGfcgDSBjHTSlxjgsUUNkrNpBab ) { }

	// RVA: 0x1924790 Offset: 0x1923990 VA: 0x181924790
	private void tWWpyvZJIzWVkxpbZRLZTdpqbswU(BridgedControllerHWInfo ) { }

	// RVA: 0x19245D0 Offset: 0x19237D0 VA: 0x1819245D0
	private void tWWpyvZJIzWVkxpbZRLZTdpqbswU(BridgedController ) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1922870 Offset: 0x1921A70 VA: 0x181922870 Slot: 5
	public void FillData(ControllerDataUpdater dataUpdater) { }

	// RVA: 0x1923A10 Offset: 0x1922C10 VA: 0x181923A10
	public BridgedControllerHWInfo YBoCMuEVpOnMzGMPrUDrCQXEKTvFc() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1923130 Offset: 0x1922330 VA: 0x181923130 Slot: 6
	public BridgedController ToBridgedController() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1923320 Offset: 0x1922520 VA: 0x181923320 Slot: 7
	public ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs() { }

	// RVA: 0x19233F0 Offset: 0x19225F0 VA: 0x1819233F0
	private void VFyJeLbUwqdCubDgXEzfGHYdXVoy() { }

	// RVA: 0x1924140 Offset: 0x1923340 VA: 0x181924140
	private void iGODeOjYMoHUVsoqpUdUjBagWPjWA() { }

	// RVA: 0x1924470 Offset: 0x1923670 VA: 0x181924470
	private bool npcTmKvcxuvvnoNaatHoeYTNzOye(HardwareJoystickMap.Platform_Custom.Button , out float ) { }

	// RVA: 0x1923620 Offset: 0x1922820 VA: 0x181923620
	private bool WpkjzKjHSHrbNWVPxPuOhOMeSSJn(float , float ) { }

	// RVA: 0x1922F20 Offset: 0x1922120 VA: 0x181922F20
	private float NDdejHAFqRppvegAAPLfRXIrUvbfA(HardwareJoystickMap.Platform_Custom.Axis ) { }

	// RVA: 0x1923040 Offset: 0x1922240 VA: 0x181923040
	private float NDdejHAFqRppvegAAPLfRXIrUvbfA(int ) { }

	// RVA: 0x19243E0 Offset: 0x19235E0 VA: 0x1819243E0
	private bool npcTmKvcxuvvnoNaatHoeYTNzOye(int , out float ) { }

	// RVA: 0x19225B0 Offset: 0x19217B0 VA: 0x1819225B0
	private void CinMQxkMzclfOIqMTzYTvutvGGVu() { }

	// RVA: 0x1924820 Offset: 0x1923A20 VA: 0x181924820
	private void uRagaBxqBRdQvDBHroJhMyUVfQqG() { }

	// RVA: 0x1922A00 Offset: 0x1921C00 VA: 0x181922A00
	private string GDasauLghpjLJWblRztAFulKfQFB() { }

	// RVA: 0x1923640 Offset: 0x1922840 VA: 0x181923640 Slot: 18
	private bool XaocBHbPcSQOhcKkpQOjWpLROKQnA(out string ) { }

	// RVA: 0x1924590 Offset: 0x1923790 VA: 0x181924590
	public static int ryNEDHYgtaGnQAxQJtkRQPmLNjpaA(CustomInputManager.ynGfcgDSBjHTSlxjgsUUNkrNpBab , CustomInputManager.ynGfcgDSBjHTSlxjgsUUNkrNpBab ) { }

	// RVA: 0x1923070 Offset: 0x1922270 VA: 0x181923070
	public static int QELrkTYgCSDCXBELTlmIbbbtSXXqA(CustomInputManager.ynGfcgDSBjHTSlxjgsUUNkrNpBab , CustomInputManager.ynGfcgDSBjHTSlxjgsUUNkrNpBab ) { }
}

// Namespace: 
public enum CustomInputManager.QZoUGTZzsLqcAOMwYAEWZjQlbBCb.bWTTbkQtgCadsMJXVPdtykjjxVTq // TypeDefIndex: 7147
{
	// Fields
	public int value__; // 0x0
	public const CustomInputManager.QZoUGTZzsLqcAOMwYAEWZjQlbBCb.bWTTbkQtgCadsMJXVPdtykjjxVTq Exact = 0;
	public const CustomInputManager.QZoUGTZzsLqcAOMwYAEWZjQlbBCb.bWTTbkQtgCadsMJXVPdtykjjxVTq Approximate = 1;
}

// Namespace: 
public class CustomInputManager.QZoUGTZzsLqcAOMwYAEWZjQlbBCb.ehoVObnrJOhWWhLGbumsdBhhjhCIb // TypeDefIndex: 7148
{
	// Fields
	public int BBwCQyVLbzyfoFVwkYtvzileXHhL; // 0x10
	public Nullable<long> rucVGKCisSJRgiGJhtDJOWOrvIaV; // 0x18
	public string VQuFlOZHzgrfElmcomnjBUhJWTdy; // 0x28
	public int BsSwaJwceNhPODhLijsOpChFqYNFb; // 0x30
	public int ZwxoEwSrePraFcQWlwoanfflAcnb; // 0x34
	public int KLiLeFOmHnIKewzsCXwtlSRRgkOA; // 0x38

	// Methods

	// RVA: 0x19214A0 Offset: 0x19206A0 VA: 0x1819214A0
	public void .ctor(int , Nullable<long> , string , int , int , int ) { }

	// RVA: 0x1921340 Offset: 0x1920540 VA: 0x181921340
	public bool BxThmMJFHsklBXkYNDKZEyouGtEiA(CustomInputManager.ynGfcgDSBjHTSlxjgsUUNkrNpBab , CustomInputManager.QZoUGTZzsLqcAOMwYAEWZjQlbBCb.bWTTbkQtgCadsMJXVPdtykjjxVTq ) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CustomInputManager.QZoUGTZzsLqcAOMwYAEWZjQlbBCb.zSjYqOgkYHsMxmcJrhwpFFYWpGmW : IDisposable, IEnumerable, IEnumerator, IEnumerable<CustomInputManager.QZoUGTZzsLqcAOMwYAEWZjQlbBCb.ehoVObnrJOhWWhLGbumsdBhhjhCIb>, IEnumerator<CustomInputManager.QZoUGTZzsLqcAOMwYAEWZjQlbBCb.ehoVObnrJOhWWhLGbumsdBhhjhCIb> // TypeDefIndex: 7149
{
	// Fields
	private int dBQbAarBkNnOcBpmWbAkhghffUTd; // 0x10
	private CustomInputManager.QZoUGTZzsLqcAOMwYAEWZjQlbBCb.ehoVObnrJOhWWhLGbumsdBhhjhCIb lHIUNFnhYhrwMMruxlcJbScYJFEf; // 0x18
	private int GCVviyKittArLKGWfFwZVxoRtlgUA; // 0x20
	public CustomInputManager.QZoUGTZzsLqcAOMwYAEWZjQlbBCb nRuIinfLvwzjrSCAtBNSGkCORxujA; // 0x28
	private CustomInputManager.ynGfcgDSBjHTSlxjgsUUNkrNpBab RfmZkitaWRkEPIuHPhgHOpnAdtjx; // 0x30
	public CustomInputManager.ynGfcgDSBjHTSlxjgsUUNkrNpBab pGetVvZBIWUgEAEwsRUzWFCOFkweA; // 0x38
	private CustomInputManager.QZoUGTZzsLqcAOMwYAEWZjQlbBCb.bWTTbkQtgCadsMJXVPdtykjjxVTq uVnJBjRlkHGVKhrITyeuUiifkVplA; // 0x40
	public CustomInputManager.QZoUGTZzsLqcAOMwYAEWZjQlbBCb.bWTTbkQtgCadsMJXVPdtykjjxVTq KrgeKHrEtkzqBpiYNozZkeLJwXnb; // 0x44
	private int iqqGtlTkrODzPKmcMiejERpvjzZb; // 0x48
	private int REMdryAbxahtDKXMbnzqFmRNCvew; // 0x4C

	// Properties
	private CustomInputManager.QZoUGTZzsLqcAOMwYAEWZjQlbBCb.ehoVObnrJOhWWhLGbumsdBhhjhCIb System.Collections.Generic.IEnumerator<Rewired.InputManagers.CustomInputManager.JoystickRecords.Record>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xBB1460 Offset: 0xBB0660 VA: 0x180BB1460
	public void .ctor(int ) { }

	[DebuggerHidden]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1924890 Offset: 0x1923A90 VA: 0x181924890 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 10
	private CustomInputManager.QZoUGTZzsLqcAOMwYAEWZjQlbBCb.ehoVObnrJOhWWhLGbumsdBhhjhCIb System.Collections.Generic.IEnumerator<Rewired.InputManagers.CustomInputManager.JoystickRecords.Record>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1924A60 Offset: 0x1923C60 VA: 0x181924A60 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1924990 Offset: 0x1923B90 VA: 0x181924990 Slot: 9
	private IEnumerator<CustomInputManager.QZoUGTZzsLqcAOMwYAEWZjQlbBCb.ehoVObnrJOhWWhLGbumsdBhhjhCIb> System.Collections.Generic.IEnumerable<Rewired.InputManagers.CustomInputManager.JoystickRecords.Record>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1924990 Offset: 0x1923B90 VA: 0x181924990 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
private class CustomInputManager.QZoUGTZzsLqcAOMwYAEWZjQlbBCb // TypeDefIndex: 7150
{
	// Fields
	private List<CustomInputManager.QZoUGTZzsLqcAOMwYAEWZjQlbBCb.ehoVObnrJOhWWhLGbumsdBhhjhCIb> SoaTxmiZVylilBUxGputtEzixo; // 0x10

	// Properties
	public int ZGDajhyxNzhNBiKJhEAsWFQbqjCfA { get; }

	// Methods

	// RVA: 0x191B260 Offset: 0x191A460 VA: 0x18191B260
	public void .ctor() { }

	// RVA: 0x191B0C0 Offset: 0x191A2C0 VA: 0x18191B0C0
	public int JkWSBcRXMqksDMwnqGuHKOiabncT() { }

	// RVA: 0x191B2D0 Offset: 0x191A4D0 VA: 0x18191B2D0
	public void cHMfpVZrsbPeVMuIhniVwFDglNIV(CustomInputManager.ynGfcgDSBjHTSlxjgsUUNkrNpBab ) { }

	// RVA: 0x191B000 Offset: 0x191A200 VA: 0x18191B000
	public bool HfHQDEyJodmDgQKMBJDYDJavMFDLA(CustomInputManager.ynGfcgDSBjHTSlxjgsUUNkrNpBab , CustomInputManager.QZoUGTZzsLqcAOMwYAEWZjQlbBCb.bWTTbkQtgCadsMJXVPdtykjjxVTq ) { }

	// RVA: 0x191B630 Offset: 0x191A830 VA: 0x18191B630
	public IEnumerable<CustomInputManager.QZoUGTZzsLqcAOMwYAEWZjQlbBCb.ehoVObnrJOhWWhLGbumsdBhhjhCIb> lPQDuMkiSSQIihpYgkDZDPvlJJSu(CustomInputManager.ynGfcgDSBjHTSlxjgsUUNkrNpBab , CustomInputManager.QZoUGTZzsLqcAOMwYAEWZjQlbBCb.bWTTbkQtgCadsMJXVPdtykjjxVTq ) { }

	// RVA: 0x191B1C0 Offset: 0x191A3C0 VA: 0x18191B1C0
	public int ZVMYpYkqYXFpfBIVblsDvJTirAucA(CustomInputManager.QZoUGTZzsLqcAOMwYAEWZjQlbBCb.ehoVObnrJOhWWhLGbumsdBhhjhCIb ) { }

	// RVA: 0x191B100 Offset: 0x191A300 VA: 0x18191B100
	private void SKSluwrOxQKxUGRriwWsmDBKjdgN(int , int ) { }
}

// Namespace: Rewired.InputManagers
[CustomClassObfuscation(renamePrivateMembers = True, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal class CustomInputManager : PlatformInputManager // TypeDefIndex: 7151
{
	// Fields
	private List<CustomInputManager.ynGfcgDSBjHTSlxjgsUUNkrNpBab> PgpGMyJfIPxDnbEBKMKFPoCrGZsy; // 0x38
	private int cgqOFbLCriWQJiMRqiHjBSiupijH; // 0x40
	private CustomInputManager.QZoUGTZzsLqcAOMwYAEWZjQlbBCb KzkEJJbQFFTnTRilEpvNrICbOBlNA; // 0x48
	private UpdateLoopType cCgYCUDwBYOudomcpBworRxTuvcG; // 0x50
	private Action<int, ControllerDataUpdater> DNYtAGdVwiuWZYileahUqtqEwnGE; // 0x58
	private PlatformInputManager DCyjZfESLAOkdTXIKHvqlQGvbTTUA; // 0x60
	private CustomInputSource McogQWMzoOnHLYhBOaKSDVtUOVEF; // 0x68
	private bool EzeaBeiGmiJMnWHCQwMdEpYfIHeKA; // 0x70
	private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> oLMJByWrXxnTAAniOPWzusegbMTX; // 0x78
	private Func<int> jnzbJHiuKHdsJFaGZKjVAQFzfKdJ; // 0x80

	// Properties
	[CustomObfuscation(rename = False)]
	public override int deviceCount { get; }
	[CustomObfuscation(rename = False)]
	public override PlatformInputManager primaryInputManager { get; }
	[CustomObfuscation(rename = False)]
	public override IInputSource inputSource { get; }
	[CustomObfuscation(rename = False)]
	public override InputSource inputSourceType { get; }

	// Methods

	// RVA: 0x19145C0 Offset: 0x19137C0 VA: 0x1819145C0
	public void .ctor(CustomInputSource , UpdateLoopSetting , Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> , Func<int> ) { }

	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440 Slot: 4
	public override int get_deviceCount() { }

	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860 Slot: 5
	public override PlatformInputManager get_primaryInputManager() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 6
	public override IInputSource get_inputSource() { }

	// RVA: 0x1914880 Offset: 0x1913A80 VA: 0x181914880 Slot: 7
	public override InputSource get_inputSourceType() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1913640 Offset: 0x1912840 VA: 0x181913640 Slot: 8
	public override void Initialize() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1914280 Offset: 0x1913480 VA: 0x181914280 Slot: 9
	public override void Update(UpdateLoopType updateLoop) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1913750 Offset: 0x1912950 VA: 0x181913750 Slot: 10
	public override void OnDestroy() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090 Slot: 14
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1914160 Offset: 0x1913360 VA: 0x181914160 Slot: 13
	public override void UpdateControllerData(int inputManagerId, ControllerDataUpdater data) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1913E80 Offset: 0x1913080 VA: 0x181913E80 Slot: 11
	public override void SystemDeviceConnected() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1913EA0 Offset: 0x19130A0 VA: 0x181913EA0 Slot: 12
	public override void SystemDeviceDisconnected() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 15
	public override void SetUnityJoystickId(int joystickId, int unityJoystickIndex) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1913620 Offset: 0x1912820 VA: 0x181913620 Slot: 16
	public override IUnifiedMouseSource GetUnifiedMouseSource() { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x1913600 Offset: 0x1912800 VA: 0x181913600 Slot: 17
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource() { }

	// RVA: 0x19138E0 Offset: 0x1912AE0 VA: 0x1819138E0
	private void RIuriNqVjKsBByFxgrAQeNPpJrfO(CustomInputSource.Joystick[] ) { }

	// RVA: 0x19147E0 Offset: 0x19139E0 VA: 0x1819147E0
	private void amDwyChgubkalmVvfMfKySzVAnky() { }

	// RVA: 0x1912F60 Offset: 0x1912160 VA: 0x181912F60
	private void BvfegPqXokMTUSkDADCUMTQniMRG(int , int , List<CustomInputManager.ynGfcgDSBjHTSlxjgsUUNkrNpBab> , List<CustomInputManager.ynGfcgDSBjHTSlxjgsUUNkrNpBab> ) { }

	// RVA: 0x1914D60 Offset: 0x1913F60 VA: 0x181914D60
	private void uBIEYkNJYlXRMsSQgwVaxKfQNOZL(List<CustomInputManager.ynGfcgDSBjHTSlxjgsUUNkrNpBab> , int , int ) { }

	// RVA: 0x1914B10 Offset: 0x1913D10 VA: 0x181914B10
	private bool omlZnYtqWrKdyKeYZyQNgPdPrPNr(List<CustomInputManager.ynGfcgDSBjHTSlxjgsUUNkrNpBab> , int ) { }

	// RVA: 0x1914BC0 Offset: 0x1913DC0 VA: 0x181914BC0
	private int qXLoiFwvuZjhpGMtAmXVLCOCeLPHA(List<CustomInputManager.ynGfcgDSBjHTSlxjgsUUNkrNpBab> ) { }

	// RVA: 0x1914E40 Offset: 0x1914040 VA: 0x181914E40
	private bool yyaMMqceOEJJroObWbCPqleBdAqQ(List<CustomInputManager.ynGfcgDSBjHTSlxjgsUUNkrNpBab> , int ) { }

	// RVA: 0x1913430 Offset: 0x1912630 VA: 0x181913430
	private void FtxjXWTwBwqvypdANfhcfvtrAvnr(int , List<CustomInputManager.ynGfcgDSBjHTSlxjgsUUNkrNpBab> , int , List<CustomInputManager.ynGfcgDSBjHTSlxjgsUUNkrNpBab> , CustomInputManager.QZoUGTZzsLqcAOMwYAEWZjQlbBCb.bWTTbkQtgCadsMJXVPdtykjjxVTq ) { }

	// RVA: 0x1913EC0 Offset: 0x19130C0 VA: 0x181913EC0
	private void TSdhtqxuBTyddRcZaoueBxqaksmd(int , List<CustomInputManager.ynGfcgDSBjHTSlxjgsUUNkrNpBab> , CustomInputManager.QZoUGTZzsLqcAOMwYAEWZjQlbBCb.bWTTbkQtgCadsMJXVPdtykjjxVTq ) { }

	// RVA: 0x1913770 Offset: 0x1912970 VA: 0x181913770
	private void PBNysDZIhuKVqGFJCPknVwIwKmaA() { }

	// RVA: 0x19148A0 Offset: 0x1913AA0 VA: 0x1819148A0
	private bool kQvSgtGmiXJjYJHkRVspEEZRbgqM(CustomInputSource.Joystick[] ) { }

	// RVA: 0x1913D60 Offset: 0x1912F60 VA: 0x181913D60
	private void SlqRDGZYcIIsgahhkBJmTdNrBBwbA(List<CustomInputManager.ynGfcgDSBjHTSlxjgsUUNkrNpBab> , List<CustomInputManager.ynGfcgDSBjHTSlxjgsUUNkrNpBab> , bool ) { }

	// RVA: 0x1914C70 Offset: 0x1913E70 VA: 0x181914C70
	private void qfEGHcVCQYAhmLABLobjtRoUkdgC(CustomInputManager.ynGfcgDSBjHTSlxjgsUUNkrNpBab , bool ) { }

	// RVA: 0x19144F0 Offset: 0x19136F0 VA: 0x1819144F0
	private void ZRjctFejkTkveGBoEMIEaiyUaxFKB(CustomInputManager.ynGfcgDSBjHTSlxjgsUUNkrNpBab , bool ) { }
}

// Namespace: Rewired.HID.Drivers
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal interface IControllerDriver // TypeDefIndex: 7152
{
	// Properties
	public abstract int AxisCount { get; }
	public abstract int ButtonCount { get; }
	public abstract int HatCount { get; }
	public abstract int AccelerometerCount { get; }
	public abstract int GyroscopeCount { get; }
	public abstract int TouchpadCount { get; }
	public abstract int LightCount { get; }
	public abstract int VibrationMotorCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_AxisCount();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_ButtonCount();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_HatCount();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_AccelerometerCount();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_GyroscopeCount();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_TouchpadCount();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_LightCount();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_VibrationMotorCount();
}

// Namespace: Rewired.HID.Drivers
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal interface IDriver_DualShock4 : IControllerDriver, IHIDControllerExtension // TypeDefIndex: 7153
{
	// Properties
	public abstract float BatteryLevel { get; }
	public abstract bool BatteryCharging { get; }
	public abstract float LeftMotor { get; set; }
	public abstract float RightMotor { get; set; }
	public abstract float LightColorR { get; set; }
	public abstract float LightColorG { get; set; }
	public abstract float LightColorB { get; set; }
	public abstract float LightFlashOnDuration { get; set; }
	public abstract float LightFlashOffDuration { get; set; }
	public abstract Vector3 AccelerometerValue { get; }
	public abstract Vector3 AccelerometerValueRaw { get; }
	public abstract Vector3 GyroscopeValue { get; }
	public abstract Vector3 GyroscopeValueRaw { get; }
	public abstract Vector3 LastGyroscopeValue { get; }
	public abstract Vector3 LastGyroscopeValueRaw { get; }
	public abstract Quaternion Orientation { get; }
	public abstract int MaxTouches { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract float get_BatteryLevel();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_BatteryCharging();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_LeftMotor();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_LeftMotor(float value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float get_RightMotor();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_RightMotor(float value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract float get_LightColorR();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_LightColorR(float value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract float get_LightColorG();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void set_LightColorG(float value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract float get_LightColorB();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void set_LightColorB(float value);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract float get_LightFlashOnDuration();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void set_LightFlashOnDuration(float value);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract float get_LightFlashOffDuration();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void set_LightFlashOffDuration(float value);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract Vector3 get_AccelerometerValue();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract Vector3 get_AccelerometerValueRaw();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract Vector3 get_GyroscopeValue();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract Vector3 get_GyroscopeValueRaw();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract Vector3 get_LastGyroscopeValue();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract Vector3 get_LastGyroscopeValueRaw();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract Quaternion get_Orientation();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void ResetOrientation();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract int get_MaxTouches();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract int GetTouchCount();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract bool IsTouchingAtTouchId(int touchId);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract bool IsTouchingAtIndex(int index);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract int GetTouchIdAtIndex(int index);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract bool GetTouchPositionByIndex(int index, out Vector2 position);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract bool GetTouchPositionByTouchId(int touchId, out Vector2 position);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract bool GetTouchPositionAbsoluteByIndex(int index, out int positionX, out int positionY);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract bool GetTouchPositionAbsoluteByTouchId(int touchId, out int positionX, out int positionY);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void StopLightFlash();

	// RVA: -1 Offset: -1 Slot: 34
	public abstract void StopVibration();
}

// Namespace: Rewired.HID.Drivers
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal interface IDriver_DualSense : IControllerDriver, IHIDControllerExtension // TypeDefIndex: 7154
{
	// Properties
	public abstract float BatteryLevel { get; }
	public abstract bool BatteryCharging { get; }
	public abstract DualSenseVibrationMode vibrationMode { get; set; }
	public abstract float LeftMotor { get; set; }
	public abstract float RightMotor { get; set; }
	public abstract float LightColorR { get; set; }
	public abstract float LightColorG { get; set; }
	public abstract float LightColorB { get; set; }
	public abstract float LightFlashOnDuration { get; set; }
	public abstract float LightFlashOffDuration { get; set; }
	public abstract DualSenseMicrophoneLightMode microphoneLightMode { get; set; }
	public abstract DualSenseOtherLightBrightness otherLightBrightness { get; set; }
	public abstract DualSensePlayerLightFlags playerLights { get; set; }
	public abstract Vector3 AccelerometerValue { get; }
	public abstract Vector3 AccelerometerValueRaw { get; }
	public abstract Vector3 GyroscopeValue { get; }
	public abstract Vector3 GyroscopeValueRaw { get; }
	public abstract Vector3 LastGyroscopeValue { get; }
	public abstract Vector3 LastGyroscopeValueRaw { get; }
	public abstract Quaternion Orientation { get; }
	public abstract int MaxTouches { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract float get_BatteryLevel();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_BatteryCharging();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract DualSenseVibrationMode get_vibrationMode();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_vibrationMode(DualSenseVibrationMode value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float get_LeftMotor();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_LeftMotor(float value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract float get_RightMotor();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_RightMotor(float value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract float get_LightColorR();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void set_LightColorR(float value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract float get_LightColorG();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void set_LightColorG(float value);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract float get_LightColorB();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void set_LightColorB(float value);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract float get_LightFlashOnDuration();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void set_LightFlashOnDuration(float value);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract float get_LightFlashOffDuration();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void set_LightFlashOffDuration(float value);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract DualSenseMicrophoneLightMode get_microphoneLightMode();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void set_microphoneLightMode(DualSenseMicrophoneLightMode value);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract DualSenseOtherLightBrightness get_otherLightBrightness();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void set_otherLightBrightness(DualSenseOtherLightBrightness value);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract DualSensePlayerLightFlags get_playerLights();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void set_playerLights(DualSensePlayerLightFlags value);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract Vector3 get_AccelerometerValue();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract Vector3 get_AccelerometerValueRaw();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract Vector3 get_GyroscopeValue();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract Vector3 get_GyroscopeValueRaw();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract Vector3 get_LastGyroscopeValue();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract Vector3 get_LastGyroscopeValueRaw();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract Quaternion get_Orientation();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract void ResetOrientation();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract int get_MaxTouches();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract int GetTouchCount();

	// RVA: -1 Offset: -1 Slot: 34
	public abstract bool IsTouchingAtTouchId(int touchId);

	// RVA: -1 Offset: -1 Slot: 35
	public abstract bool IsTouchingAtIndex(int index);

	// RVA: -1 Offset: -1 Slot: 36
	public abstract int GetTouchIdAtIndex(int index);

	// RVA: -1 Offset: -1 Slot: 37
	public abstract bool GetTouchPositionByIndex(int index, out Vector2 position);

	// RVA: -1 Offset: -1 Slot: 38
	public abstract bool GetTouchPositionByTouchId(int touchId, out Vector2 position);

	// RVA: -1 Offset: -1 Slot: 39
	public abstract bool GetTouchPositionAbsoluteByIndex(int index, out int positionX, out int positionY);

	// RVA: -1 Offset: -1 Slot: 40
	public abstract bool GetTouchPositionAbsoluteByTouchId(int touchId, out int positionX, out int positionY);

	// RVA: -1 Offset: -1 Slot: 41
	public abstract void StopLightFlash();

	// RVA: -1 Offset: -1 Slot: 42
	public abstract void StopVibration();

	// RVA: -1 Offset: -1 Slot: 43
	public abstract bool SetTriggerEffect(DualSenseTriggerType trigger, IDualSenseTriggerEffect effect);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract DualSenseTriggerEffectStates GetTriggerEffectStates();
}

// Namespace: Rewired.HID.Drivers
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal interface IDriver_RailDriver : IControllerDriver, IHIDControllerExtension // TypeDefIndex: 7155
{
	// Properties
	public abstract bool SpeakerEnabled { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_SpeakerEnabled();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_SpeakerEnabled(bool value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetLEDDisplay(int digitIndex, byte digitBitValues);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetLEDDisplay(byte digit1BitValues, byte digit2BitValues, byte digit3BitValues);
}

// Namespace: Rewired.HID.Drivers
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal interface IDriver_NintendoSwitchController : IControllerDriver, IHIDControllerExtension // TypeDefIndex: 7156
{
	// Properties
	public abstract int vibrationMotorCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_vibrationMotorCount();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void GetVibration(int motorIndex, out float amplitudeLow, out float frequencyLow, out float amplitudeHigh, out float frequencyHigh);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetVibration(int motorIndex, float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetVibration(int motorIndex, float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh, bool stopOtherMotors);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetVibration(int motorIndex, float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh, float duration);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetVibration(int motorIndex, float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh, float duration, bool stopOtherMotors);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void StopVibration(int motorIndex);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void StopVibration();
}

// Namespace: Rewired.HID.Drivers
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
internal interface IDriver_NintendoSwitchJoyCon : IControllerDriver, IDriver_NintendoSwitchController, IAxisCalibrationIndexMap, IHIDControllerExtension // TypeDefIndex: 7157
{
	// Properties
	public abstract NintendoSwitchJoyConType joyConType { get; }
	public abstract NintendoSwitchJoyConGripStyle joyConGripStyle { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract NintendoSwitchJoyConType get_joyConType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract NintendoSwitchJoyConGripStyle get_joyConGripStyle();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_joyConGripStyle(NintendoSwitchJoyConGripStyle value);
}

// Namespace: Rewired.HID.Drivers
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal interface IDriver_NintendoSwitchProController : IControllerDriver, IDriver_NintendoSwitchController, IHIDControllerExtension // TypeDefIndex: 7158
{}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
internal interface INativePlatformHelper // TypeDefIndex: 7159
{
	// Properties
	public abstract bool isApplicationFocused { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_isApplicationFocused();
}

// Namespace: Rewired.Interfaces
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
[CustomObfuscation(rename = False)]
internal interface IInputManagerJoystick : IInputManagerJoystickPublic // TypeDefIndex: 7160
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Update();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void FillData(ControllerDataUpdater dataUpdater);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract BridgedController ToBridgedController();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs();
}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
internal interface IInputManagerJoystickPublic // TypeDefIndex: 7161
{
	// Properties
	public abstract int rewiredId { get; }
	public abstract int inputManagerId { get; }
	public abstract string name { get; }
	public abstract Nullable<long> systemId { get; }
	public abstract int unityId { get; }
	public abstract Controller.Extension extension { get; }
	public abstract Guid instanceGuid { get; }
	public abstract Guid persistentGuid { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_rewiredId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_inputManagerId();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_name();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Nullable<long> get_systemId();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_unityId();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Controller.Extension get_extension();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Guid get_instanceGuid();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Guid get_persistentGuid();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void SetVibration(float amount, int motorIndex);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void StopVibration();
}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
internal interface IInputSource : IDisposable // TypeDefIndex: 7162
{
	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_DeviceChangedEvent(Action value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_DeviceChangedEvent(Action value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SystemDeviceConnected();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SystemDeviceDisconnected();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Update();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void UpdateDevices(UpdateLoopType updateLoop);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void UpdateFinished();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IList<TJoy> GetJoysticks<TJoy>();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IInputSource.GetJoysticks<object>
	*/
}

// Namespace: Rewired.Interfaces
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
[CustomObfuscation(rename = False)]
internal interface IElementIdentifierTool // TypeDefIndex: 7163
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Initialize(GUIText guiText);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Start();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Update();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnDestroy();
}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
internal interface IGetSetEnabled // TypeDefIndex: 7164
{
	// Properties
	public abstract bool enabled { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_enabled();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_enabled(bool value);
}

// Namespace: Rewired.Interfaces
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
[CustomObfuscation(rename = False)]
internal interface IUnifiedMouseSource // TypeDefIndex: 7165
{
	// Properties
	public abstract InputSource inputSource { get; }
	public abstract HardwareControllerMap_Game hardwareMap { get; }
	public abstract int axisCount { get; }
	public abstract int buttonCount { get; }
	public abstract Vector2 mousePosition { get; }
	public abstract Controller.Extension controllerExtension { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract InputSource get_inputSource();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract HardwareControllerMap_Game get_hardwareMap();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_axisCount();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_buttonCount();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Vector2 get_mousePosition();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Controller.Extension get_controllerExtension();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void UpdateInputData(ControllerDataUpdater dataUpdater);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Clear();
}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = False)]
internal interface IUnifiedKeyboardSource // TypeDefIndex: 7166
{
	// Properties
	public abstract InputSource inputSource { get; }
	public abstract HardwareControllerMap_Game hardwareMap { get; }
	public abstract int buttonCount { get; }
	public abstract Controller.Extension controllerExtension { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract InputSource get_inputSource();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract HardwareControllerMap_Game get_hardwareMap();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_buttonCount();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Controller.Extension get_controllerExtension();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void UpdateInputData(ControllerDataUpdater dataUpdater);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Clear();
}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
public interface IControllerExtensionSource // TypeDefIndex: 7167
{}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal interface IControllerElementIdentifierCommon_Internal // TypeDefIndex: 7168
{
	// Properties
	public abstract int id { get; }
	public abstract string name { get; }
	public abstract string positiveName { get; }
	public abstract string negativeName { get; }
	public abstract string nonLocalizedName { get; }
	public abstract string nonLocalizedPositiveName { get; }
	public abstract string nonLocalizedNegativeName { get; }
	public abstract string key { get; }
	public abstract string positiveKey { get; }
	public abstract string negativeKey { get; }
	public abstract bool isNonLocalizedPositiveNameAutoGenerated { get; }
	public abstract bool isNonLocalizedNegativeNameAutoGenerated { get; }
	public abstract bool isPositiveKeyAutoGenerated { get; }
	public abstract bool isNegativeKeyAutoGenerated { get; }
	public abstract DeviceLocalizationInfo deviceLocalizationInfo { get; }
	public abstract object elementType { get; }
	public abstract bool useEditorElementTypeOverride { get; }
	public abstract ControllerElementType editorElementTypeOverride { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_id();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_name();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_positiveName();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_negativeName();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_nonLocalizedName();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_nonLocalizedPositiveName();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_nonLocalizedNegativeName();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string GetSpecialElementNonLocalizedName(int index);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_key();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_positiveKey();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract string get_negativeKey();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract string GetSpecialElementKey(int index);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool get_isNonLocalizedPositiveNameAutoGenerated();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool get_isNonLocalizedNegativeNameAutoGenerated();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool get_isPositiveKeyAutoGenerated();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool get_isNegativeKeyAutoGenerated();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract DeviceLocalizationInfo get_deviceLocalizationInfo();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract object get_elementType();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract bool get_useEditorElementTypeOverride();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract ControllerElementType get_editorElementTypeOverride();
}

// Namespace: Rewired.Interfaces
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
internal interface IControllerTemplateElementIdentifier : IControllerElementIdentifierCommon_Internal // TypeDefIndex: 7169
{
	// Properties
	public abstract ControllerTemplateElementType elementType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ControllerTemplateElementType get_elementType();
}

// Namespace: Rewired.Interfaces
[CustomClassObfuscation(renamePrivateMembers = False, renamePubIntMembers = False)]
[CustomObfuscation(rename = False)]
